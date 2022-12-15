using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace Un16.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            calculator.Additional(100, 50);
            Assert.Equals(150, calculator.Additional(100, 50));
        }

        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            calculator.Subtraction(100, 50);
            Assert.Equals(50, calculator.Subtraction(100, 50)) ;
        }

        public void MiltiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            calculator.Miltiplication(100, 50);
            Assert.Equals(5000, calculator.Miltiplication(100, 50));
        }

        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            calculator.Division(100, 50);
            Assert.Equals(2, calculator.Division(100, 50));
        }
    }
}
