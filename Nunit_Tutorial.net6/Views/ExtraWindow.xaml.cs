using Nunit_Tutorial.net6.ViewModels;
using System.Threading;
using System.Windows;


namespace Nunit_Tutorial.net6.Views
{
    /// <summary>
    /// Interaction logic for ExtraWindow.xaml
    /// </summary>
    public partial class ExtraWindow : Window
    {
        public ExtraWindow()
        {
            InitializeComponent();
        }
        private void OpenCalculator_Click(object sender, RoutedEventArgs e)
        {
            var calculatorWindow = new CalculatorWindow();
            CalculatorViewModel calculatorViewModel = new CalculatorViewModel();
            calculatorWindow.DataContext = calculatorViewModel;
            calculatorWindow.Show();
            Thread.Sleep(3000);
            this.Close();
        }
    }
}
