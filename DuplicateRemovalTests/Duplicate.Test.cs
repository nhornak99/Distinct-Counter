using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveDuplicates;

namespace DuplicateRemovalTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DuplicateRemover remover = new DuplicateRemover();

            int result1 = remover.RemoveDuplicates(new int[] { 1, 1, 1 });
            int result2 = remover.RemoveDuplicatesLinq(new int[] { 1, 1, 1 });
            int result3 = remover.RemoveDuplicates(new int[] { 1 });
            int result4 = remover.RemoveDuplicatesLinq(new int[] { 1 });
            int result5 = remover.RemoveDuplicates(new int[] { 1, 2, 3, 4, 4, 5 });
            int result6 = remover.RemoveDuplicatesLinq(new int[] { 1, 2, 3, 4, 4, 5 });
            int result7 = remover.RemoveDuplicates(new int[] { 1, 2, 3, 4, 5 });
            int result8 = remover.RemoveDuplicatesLinq(new int[] { 1, 2, 3, 4, 5 });
            int result9 = remover.RemoveDuplicates(null);
            int result10 = remover.RemoveDuplicatesLinq(null);

            Assert.AreEqual(1, result1);
            Assert.AreEqual(1, result2);
            Assert.AreEqual(1, result3);
            Assert.AreEqual(1, result4);
            Assert.AreEqual(5, result5);
            Assert.AreEqual(5, result6);
            Assert.AreEqual(5, result7);
            Assert.AreEqual(5, result8);
            Assert.AreEqual(0, result9);
            Assert.AreEqual(0, result10);
        }
    }
}
