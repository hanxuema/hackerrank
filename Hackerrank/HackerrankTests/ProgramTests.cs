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
        public void FibonacciShouldReturn0IfInputIs0()
        {
            var result = Program.Fibonacci(0);
            Assert.AreEqual(result, 0);
        }

        [TestMethod()]
        public void FibonacciShouldReturn1IfInputIs1()
        {
            var result = Program.Fibonacci(1);
            Assert.AreEqual(result, 1);
        }

        [TestMethod()]
        public void FibonacciShouldReturn1IfInputIs2()
        {
            var result = Program.Fibonacci(2);
            Assert.AreEqual(result, 1);
        }
        [TestMethod()]
        public void FibonacciShouldReturn2IfInputIs3()
        {
            var result = Program.Fibonacci(3);
            Assert.AreEqual(result, 2);
        }
        [TestMethod()]
        public void FibonacciShouldReturn8IfInputIs6()
        {
            var result = Program.Fibonacci(6);
            Assert.AreEqual(result, 8);
        }

        [TestMethod()]
        public void CalcWhatFlavorsTest()
        {
            var result = Program.CalcWhatFlavors(new int[] { 1, 4, 5, 3, 2 }, 5);
            var expect = new Dictionary<int, int>();
            expect.Add(1, 2);
            expect.Add(4, 5);
            Assert.IsTrue(result.SequenceEqual(expect));
        }

        [TestMethod()]
        public void CheckIfItemInArrayTest()
        {
            var result = Program.CheckIfItemInArray(new int[] { 1, 4, 5, 3, 2 }, 5);
            Assert.IsTrue(result);

            result = Program.CheckIfItemInArray(new int[] { 2, 2, 4, 3 }, 4);
            Assert.IsTrue(result);

            result = Program.CheckIfItemInArray(new int[] { 2, 2, 4, 3 }, 7);
            Assert.IsFalse(result);
      
        }

        [TestMethod()]
        public void CheckIfItemInArrayAndReturnIndexTest()
        {
            var result = Program.CheckIfItemInArrayAndReturnIndex(new int[] { 1, 4, 5, 3, 2 }, 5, -1);
            Assert.AreEqual(result, 2);

            result = Program.CheckIfItemInArrayAndReturnIndex(new int[] { 2, 2, 4, 3 }, 4, -1);
            Assert.AreEqual(result, 2);

            result = Program.CheckIfItemInArrayAndReturnIndex(new int[] { 2, 2, 4, 3 }, 7, -2);
            Assert.AreEqual(result, -1);
        }

        [TestMethod()]
        public void BalancedBracketsTest()
        {
            var input = new string[] { "[{" };
            var results = new string[] { "NO" };
            for (int i = 0; i < input.Length; i++)
            { 
                var result = Program.CheckBalancedBrackets(input[i]);
                Assert.AreEqual(result, results[i]);
            }
        }
    }
}