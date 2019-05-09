using OrderRules.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderRules.RuleChecker
{
    public class BrokenRule
    {
        public IOrderRule OrderRule { get; set; }
        public string Message { get; set; }
    }
}
