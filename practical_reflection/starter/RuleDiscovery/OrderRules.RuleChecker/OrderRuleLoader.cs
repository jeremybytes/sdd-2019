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

            // TODO: Load the rules here

            return rules;
        }
    }
}
