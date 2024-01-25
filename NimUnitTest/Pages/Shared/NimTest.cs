using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheGameOfNim.Pages.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfNim.Pages.Shared.Tests
{
    [TestClass()]
    public class NimTest
    {
        [DataTestMethod]
        [DataRow(1, 0)]
        public void MatchesAreAbleToBeRemovedFromRow(int numToSubtract, int rowSelected)
        {
            Nin test = new Nin();

            var actual = test.canTake(numToSubtract, rowSelected);

            Assert.IsTrue(actual);
        }

        [DataTestMethod]
        [DataRow(2, 0)]
        public void MatchesAreNotAbleToBeRemovedFromRow(int numToSubtract, int rowSelected)
        {
            Nin test = new Nin();

            var actual = test.canTake(numToSubtract, rowSelected);

            Assert.IsFalse(actual);
        }

        [DataTestMethod]
        [DataRow(0, 1)]
        [DataRow(1, 2)]
        [DataRow(2, 4)]
        [DataRow(3, 6)]
        public void MatchesHaveBeenRemovedAndEqualExpected(int rowSelected, int numToRemove)
        {
            Nin test = new Nin();

            int[] expected = test.rows;
            expected[rowSelected] -= numToRemove;
            
            test.takeFromRows(rowSelected, numToRemove);
            int[] actual = test.rows;

            for(int i = 0; i < expected.Length; i++)
            {
                //Console.WriteLine(expected[i]);
                //Console.WriteLine(actual[i]);
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        
    }
}