using OrderRules.Interface;
using OrderTaker.SharedObjects;
using System.Collections.Generic;

namespace OrderRules.RuleChecker
{
    public class OrderRuleChecker
    {
        private List<IOrderRule> orderRules;
        public List<BrokenRule> BrokenRules { get; private set; }

        public OrderRuleChecker(string rulePath)
        {
            orderRules = OrderRuleLoader.LoadRules(rulePath);
        }

        public bool CheckRules(Order order)
        {
            BrokenRules = new List<BrokenRule>();
            foreach (var rule in orderRules)
            {
                var result = rule.CheckRule(order);
                if (!result.Result)
                {
                    BrokenRules.Add(new BrokenRule { OrderRule = rule, Message = result.Message });
                }
            }
            return BrokenRules.Count == 0;
        }
    }
}
