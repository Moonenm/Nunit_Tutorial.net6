using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using NUnit.Framework;

namespace Nunit_Tutorial.net6_Tests.Views
{
    [TestFixture]
    public class CalculatorWindowTests
    {
        [Test]
        public void AddNumbers()
        {
            var app = Application.Launch("C:\\Users\\u0157634\\OneDrive - Thomas More\\Agile en Testing\\E2E testing\\Nunit Tutorial\\Nunit Tutorial\\bin\\Debug\\Nunit Tutorial.exe");

            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);
                var number1 = window.FindFirstDescendant(x => x.ByAutomationId("FirstNumber")).AsTextBox();
                var number2 = window.FindFirstDescendant(x => x.ByAutomationId("SecondNumber")).AsTextBox();
                var addButton = window.FindFirstDescendant(x => x.ByAutomationId("AddButton")).AsButton();
                var result = window.FindFirstDescendant(x => x.ByAutomationId("ResultLabel")).AsLabel();

                // Act
                number1.Enter("10");
                number2.Enter("5");

                addButton.Click();

                // Assert
                Assert.That(result.Name, Is.EqualTo("15"));

                window.Close();
            }
        }

        [Test]
        public void SubtractNumbers()
        {
            var app = Application.Launch("C:\\Users\\u0157634\\OneDrive - Thomas More\\Agile en Testing\\E2E testing\\Nunit Tutorial\\Nunit Tutorial\\bin\\Debug\\Nunit Tutorial.exe");
            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);

                var number1 = window.FindFirstDescendant(x => x.ByAutomationId("FirstNumber")).AsTextBox();
                var number2 = window.FindFirstDescendant(x => x.ByAutomationId("SecondNumber")).AsTextBox();
                var subtractButton = window.FindFirstDescendant(x => x.ByAutomationId("SubtractButton")).AsButton();
                var result = window.FindFirstDescendant(x => x.ByAutomationId("ResultLabel")).AsLabel();

                // Act
                number1.Enter("10");
                number2.Enter("5");

                subtractButton.Click();

                // Assert
                Assert.That(result.Name, Is.EqualTo("5"));

                window.Close();
            }
        }

        [Test]
        public void MultiplyNumbers()
        {
            var app = Application.Launch("C:\\Users\\u0157634\\OneDrive - Thomas More\\Agile en Testing\\E2E testing\\Nunit Tutorial\\Nunit Tutorial\\bin\\Debug\\Nunit Tutorial.exe");
            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);

                var number1 = window.FindFirstDescendant(x => x.ByAutomationId("FirstNumber")).AsTextBox();
                var number2 = window.FindFirstDescendant(x => x.ByAutomationId("SecondNumber")).AsTextBox();
                var multiplyButton = window.FindFirstDescendant(x => x.ByAutomationId("MultiplyButton")).AsButton();
                var result = window.FindFirstDescendant(x => x.ByAutomationId("ResultLabel")).AsLabel();

                // Act
                number1.Enter("10");
                number2.Enter("5");
                multiplyButton.Click();

                // Assert
                Assert.That(result.Name, Is.EqualTo("50"));

                window.Close();
            }
        }

        [Test]
        public void DivideNumbers()
        {
            var app = Application.Launch("C:\\Users\\u0157634\\OneDrive - Thomas More\\Agile en Testing\\E2E testing\\Nunit Tutorial\\Nunit Tutorial\\bin\\Debug\\Nunit Tutorial.exe");
            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);

                var number1 = window.FindFirstDescendant(x => x.ByAutomationId("FirstNumber")).AsTextBox();
                var number2 = window.FindFirstDescendant(x => x.ByAutomationId("SecondNumber")).AsTextBox();
                var divideButton = window.FindFirstDescendant(x => x.ByAutomationId("DivideButton")).AsButton();
                var result = window.FindFirstDescendant(x => x.ByAutomationId("ResultLabel")).AsLabel();
                
                // Act
                number1.Enter("10");
                number2.Enter("5");

                divideButton.Click();

                // Assert
                Assert.That(result.Name, Is.EqualTo("2 rest 0"));

                window.Close();
            }
        }
    }
    
}
