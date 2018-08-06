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
            var result = Program.rotLeft(new int[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 }, 10);

            Assert.IsTrue(result.SequenceEqual(new int[] { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 }));
        }

        [TestMethod()]
        public void checkMagazineTest()
        { 
        }

        [TestMethod()]
        public void BalancedBracketsTest()
        {
            var input = new string[] { "{[()]}", "{[(])}", "{{[[(())]]}}" };
            var results = new string[] { "YES", "NO", "YES" };
            for (int i = 0; i < input.Length; i++)
            { 
                var result = Program.CheckBalancedBrackets(input[i]);
                Assert.AreEqual(result, results[i]);
            }
        }
    }
}