using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleHelper.Tests
{
    [TestClass()]
    public class CalculationsTests
    {
        [TestMethod()]
        public void PerimeterTest_success()
        {
            var result=Calculations.Perimeter(5,4);
            Assert.AreEqual(18,result);
        }

        [TestMethod()]
        public void PerimeterTest_arg()
        {
            var result = Calculations.Perimeter(5, 4);
            Assert.AreEqual(17, result);
        }

        [TestMethod()]
        public void PerimeterTest_error()
        {
            //var result = ;
            Assert.ThrowsException<Exception>(()=> { Calculations.Perimeter(-5, 4); });
        }
    }
}