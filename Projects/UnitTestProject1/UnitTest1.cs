using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsPractice;

namespace BinaryTreeTests
{
    [TestClass]
    public class EnumerationTests
    {
        [TestMethod]
        public void EnumerateTree()
        {
            var btree = new BinaryTree();
            btree.Add(10);
            var cnt = btree.Count;
            Assert.AreEqual(cnt, 1);

            btree.Add(3);
            btree.Add(12);
            btree.Add(34);
            btree.Add(19);

            foreach (Node node in btree)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("node value is: {0}", node.Value));
            }

            //btree.PreOrderTraversal(item => Assert.AreEqual(3, item, "The item enumerated in the wrong order"));
        }
    }
}