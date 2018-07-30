using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hackerrank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void rotLeftTestTest()
        {
            var result = Program.rotLeft(new int[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13);

            Assert.AreSame(result,
            new int[] { 87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60 });
        }
    }
}