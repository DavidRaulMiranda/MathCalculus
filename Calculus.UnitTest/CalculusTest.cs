using NUnit.Framework;
using MathCalculus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculus.UnitTest
{
    public class CalculusTest
    {
        [TestCase(0, 5)]
        public void SetDeCalcul_Infinite_ExpectedException(int a, int b)
        {
            var rules = new Calculus();
            var result = rules.SetDeCalcul(a, b);
            Assert.That(result, Throws.Div);
}
    }
}
