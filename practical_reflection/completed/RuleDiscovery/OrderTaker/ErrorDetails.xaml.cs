using OrderRules.Interface;
using OrderRules.RuleChecker;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace OrderTaker
{
    public partial class ErrorDetails : Window
    {
        //private List<IOrderRule> errorList;

        public ErrorDetails(List<BrokenRule> brokenRules)
        {
            InitializeComponent();
            var errorList = brokenRules.Select(
                b => new { BrokenRule = b, TypeName = b.GetType().FullName, AssemblyName = b.GetType().Assembly.GetName().Name });
            ErrorDetailsListBox.ItemsSource = errorList;
        }

    }
}
