using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using NUnit.Framework;
using Nunit_Tutorial.net6.Views;
using Nunit_Tutorial.net6.ViewModels;
using System.Security.Principal;

namespace Nunit_Tutorial.net6_Tests.Views
{
    [TestFixture]
    public class ExtraWindowTests
    {
        [Test]

        public void StartWindow()
        {
            var app = Application.Launch("C:\\Users\\u0157634\\OneDrive - Thomas More\\Agile en Testing\\E2E testing\\Nunit Tutorial.net6\\Nunit_Tutorial.net6_Tests\\bin\\Debug\\net6.0-windows\\Nunit_Tutorial.net6.exe");

            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);
                var calculator = window.FindFirstDescendant(x => x.ByAutomationId("Calculator")).AsButton();

                // Act
                calculator.Invoke();

                // Assert
                //Assert.That(app.GetAllTopLevelWindows(automation).Length, Is.EqualTo(2));

                Thread.Sleep(2000);

                var window2 = app.GetMainWindow(automation);

                var number1 = window2.FindFirstDescendant(x => x.ByAutomationId("FirstNumber")).AsTextBox();
                var number2 = window2.FindFirstDescendant(x => x.ByAutomationId("SecondNumber")).AsTextBox();
                var addButton = window2.FindFirstDescendant(x => x.ByAutomationId("AddButton")).AsButton();
                var result = window2.FindFirstDescendant(x => x.ByAutomationId("ResultLabel")).AsLabel();

                // Act
                number1.Enter("10");
                number2.Enter("5");

                addButton.Invoke();
                while (result.Name == "")
                    Thread.Sleep(1);
                
                // Assert
                Assert.That(result.Name, Is.EqualTo("15"));
                window2.Close();
            }
        }

    }
    
}
