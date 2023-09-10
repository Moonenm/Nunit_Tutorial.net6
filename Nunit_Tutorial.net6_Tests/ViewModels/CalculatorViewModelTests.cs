using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Nunit_Tutorial.net6.ViewModels;


namespace Nunit_Tutorial.net6_Tests.ViewModels
{
    [TestFixture]
    public class CalculatorViewModelTests
    {
        CalculatorViewModel calculatorViewModel = new CalculatorViewModel();
        [Test]
        public void Add_TwoIntegers_SetsResultLabelToResult()
        {
            //Arrange
            calculatorViewModel.Number1 = "7";
            calculatorViewModel.Number2 = "7";

            //Act
            calculatorViewModel.Add();

            //Assert
            //Assert.AreEqual("14", calculatorViewModel.Result);
            Assert.That(calculatorViewModel.Result, Is.EqualTo("14"));
        }


        [Test]
        public void Subtract_TwoIntegers_SetsResultLabelToResult()
        {
            //Arrange
            calculatorViewModel.Number1 = "7";
            calculatorViewModel.Number2 = "7";

            //Act
            calculatorViewModel.Subtract();
       
            //Assert
            Assert.That(calculatorViewModel.Result, Is.InstanceOf<string>());
            Assert.That(calculatorViewModel.Result, Is.EqualTo("0"));
        }

        [Test]
        public void Multiply_TwoIntegers_SetsResultLabelToResult()
        {
            //Arrange
            calculatorViewModel.Number1 = "7";
            calculatorViewModel.Number2 = "7";

            //Act
            calculatorViewModel.Multiply();

            //Assert
            Assert.That(calculatorViewModel.Result, Is.EqualTo("49"));
        }

        [Test]
        public void Divide_TwoIntegers_SetsResultLabelToResult()
        {
            //Arrange
            calculatorViewModel.Number1 = "7";
            calculatorViewModel.Number2 = "7";

            //Act
            calculatorViewModel.Divide();

            //Assert
            Assert.That(calculatorViewModel.Result, Is.EqualTo("1 rest 0"));
        }

        [Test]
        public void Execute_Default_ErrorText()
        {
            //Arrange
            object test = "Test";

            //Act
            calculatorViewModel.Execute(test);

            //Assert
            Assert.That(calculatorViewModel.Number1, Is.InstanceOf<string>());
            Assert.That(calculatorViewModel.Number2, Is.InstanceOf<string>());
            Assert.That(calculatorViewModel.Result, Is.InstanceOf<string>());

            Assert.That(calculatorViewModel.Number1, Has.Length.EqualTo(3));
            Assert.That('y', Is.EqualTo(calculatorViewModel.Number1[2]));

            Assert.That(calculatorViewModel.Number1, Is.EqualTo("Fly"));
            Assert.That(calculatorViewModel.Number2, Is.Empty);
            Assert.That(calculatorViewModel.Result, Is.EqualTo("Fools"));
        }

    }
}
