using System;
using Nunit_Tutorial.net6.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Tutorial.net6.ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {
        #region GettersAndSetters
        private string number1 = "";
        public string Number1
        {
            get { return this.number1; }
            set
            {
                this.number1 = value;
                NotifyPropertyChanged();
            }
        }
        private string number2 = "";
        public string Number2
        {
            get { return this.number2; }
            set
            {
                this.number2 = value;
                NotifyPropertyChanged();
            }
        }
        private string result = "";
        public string Result
        {
            get { return this.result; }
            set
            {
                this.result = value;
                NotifyPropertyChanged();
            }
        }
        #endregion
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
            switch (parameter.ToString())
            {
                case "Add":
                    this.Add();
                    break;
                case "Subtract":
                    this.Subtract();
                    break;
                case "Multiply":
                    this.Multiply();
                    break;
                case "Divide":
                    this.Divide();
                    break;
                default:
                    this.number1 = "Fly";
                    this.number2 = "";
                    this.result = "Fools";
                    break;
            }
        }

        public void Add()
        {
            this.Result = (int.Parse(this.number1) + int.Parse(this.number2)).ToString();
        }

        public void Subtract()
        {
            this.Result = (int.Parse(this.number1) - int.Parse(this.number2)).ToString();
        }

        public void Multiply()
        {
            this.Result = (int.Parse(this.number1) * int.Parse(this.number2)).ToString();
        }

        public void Divide()
        {
            this.Result = (int.Parse(this.number1) / int.Parse(this.number2)).ToString() + " rest " + (int.Parse(this.number1) % int.Parse(this.number2)).ToString();
        }
    }
}
