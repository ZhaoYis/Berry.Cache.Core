using System;
using Berry.Cache.Core;
using Berry.Cache.Core.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string key = "dsx";

            bool isSucc = CacheFactory.GetCache().Add(key, "Hello World！");
            Assert.IsTrue(isSucc);

            bool exist = CacheFactory.GetCache().Exists(key);
            Assert.IsTrue(exist);

            string data = CacheFactory.GetCache().Get<string>(key);
            Console.WriteLine(data);
        }
    }
}
