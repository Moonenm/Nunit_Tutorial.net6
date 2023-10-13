using Nunit_Tutorial.net6.ViewModels;
using Nunit_Tutorial.net6.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Nunit_Tutorial.net6
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            CalculatorWindow calculatorWindow = new CalculatorWindow();
            CalculatorViewModel calculatorViewModel = new CalculatorViewModel();
            calculatorWindow.DataContext = calculatorViewModel;
           /* calculatorWindow.Show();*/

            ExtraWindow ExtraWindow = new ExtraWindow();
            ExtraWindowViewModel extraWindowViewModel = new ExtraWindowViewModel();
           // extraWindowViewModel.DataContext = extraWindowViewModel;
            ExtraWindow.Show();
        }
    }
}
