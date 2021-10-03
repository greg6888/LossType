using LossType.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestLossType
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUser()
        {
            UserList list = new UserList();
            bool value=list.CheckUsers("bestg", "Georgie");
            Assert.AreEqual(true, value);
        }
        [TestMethod]
        public void TestLossType()
        {
            LosstypeList list = new LosstypeList();
            int sum = list.GetLossType().Count;
            Assert.AreEqual(26, sum);
        }
    }
}
