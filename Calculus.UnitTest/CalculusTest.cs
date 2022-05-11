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



        [TestCase(15, 10)]
        [TestCase(10, 15)]
        public void CalculaMCD_Normal_ExpectedValue(int a, int b)
        {
            var rules = new MathCalculus.Calculus();
            rules.set = new OBJSetDeCalculs();
            rules.set.numA = a;
            rules.set.numB = b;
            var result = rules.CalculaMCD();
            Assert.AreEqual(result, "5");
        }
        [TestCase(9,12,3)]
        [TestCase(12,9,3)]
        public void CalculaMCM_Normal_ExpectedValue(int a, int b, int c)
        {
            var rules = new MathCalculus.Calculus();
            rules.set = new OBJSetDeCalculs();
            rules.set.numA = a;
            rules.set.numB = b;
            rules.set.MCD = c;
            var result = rules.CalculaMCM();
            Assert.AreEqual(result, "36");
        }
        [TestCase(5, 7)]
        public void SetDeCalcul_Normal_Value(int a, int b)
        {
            List<int> expected = new List<int>() { 12, -2, 2, 35, 0, 1 };

            var rules = new MathCalculus.Calculus();
            rules.set = new OBJSetDeCalculs();
            rules.set.numA = a;
            rules.set.numB = b;
           
            var result = rules.SetDeCalcul();
            CollectionAssert.AreEqual(result, expected);
        }
        [TestCase(0, 5)]
        [TestCase(10, 31)]
        public void SetDeCalcul_Infinite_ExpectedNull(int a, int b)
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
