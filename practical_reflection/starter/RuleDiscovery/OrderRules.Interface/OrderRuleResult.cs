
namespace OrderRules.Interface
{
    public class OrderRuleResult
    {
        public bool Result { get; set; }
        public string Message { get; set; }

        public OrderRuleResult(bool result, string message)
        {
            Result = result;
            Message = message;
        }
    }
}
