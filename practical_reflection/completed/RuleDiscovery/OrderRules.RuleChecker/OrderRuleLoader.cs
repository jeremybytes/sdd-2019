using OrderRules.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace OrderRules.RuleChecker
{
    public class OrderRuleLoader
    {
        public static List<IOrderRule> LoadRules(string assemblyPath)
        {
            var rules = new List<IOrderRule>();

            if (!Directory.Exists(assemblyPath))
                return rules;

            IEnumerable<string> assemblyFiles = Directory.EnumerateFiles(
                assemblyPath, "*.dll", SearchOption.TopDirectoryOnly);

            foreach (string assemblyFile in assemblyFiles)
            {
                Assembly assembly = Assembly.LoadFrom(assemblyFile);

                var ruleTypes = assembly.ExportedTypes
                    .Where(rt => rt.IsClass && typeof(IOrderRule).IsAssignableFrom(rt));

                foreach (Type type in ruleTypes)
                {
                    IOrderRule rule = Activator.CreateInstance(type) as IOrderRule;
                    rules.Add(rule);
                }
            }

            return rules;
        }
    }
}
