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
            var rules = new MathCalculus.Calculus();
            rules.set = new OBJSetDeCalculs();
            rules.set.numA = a;
            rules.set.numB = b;
            var result = rules.SetDeCalcul();
            Assert.That(result, Is.Null);
}
    }
}
