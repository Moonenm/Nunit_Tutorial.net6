using System;
using Nunit_Tutorial.net6.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Tutorial.net6.ViewModels
{
    public class ExtraWindowViewModel : BaseViewModel
    {

        public override string this[string columnName]
        {
            get
            {
                return "";
            }
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            if(parameter.ToString()== "Calculator") { 
                Calculator();
              }


        }
        public void Calculator()
        {
            CalculatorWindow subWindow = new CalculatorWindow();
            subWindow.Show();
            ExtraWindow window = new ExtraWindow();
            window.Close();
        }

    }
}
