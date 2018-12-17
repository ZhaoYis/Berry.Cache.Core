using System;
using System.Collections.Generic;
using Berry.Cache.Core.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            IRegisterService service = RegisterService.Start().UseRedisCache();
        }

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

        [TestMethod]
        public void TestMethod2()
        {
            string key = "test";

            TestModel test = new TestModel
            {
                Id = 1,
                Name = "dsx",
                Phone = "13588886666",
                AddTime = DateTime.Now
            };
            bool isSucc = CacheFactory.GetCache().Add(key, test);
            Assert.IsTrue(isSucc);

            bool exist = CacheFactory.GetCache().Exists(key);
            Assert.IsTrue(exist);

            string data = CacheFactory.GetCache().Get(key).ToString();
            Console.WriteLine(data);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string key = "test_list";

            List<TestModel> list = new List<TestModel>
            {
                new TestModel
                {
                    Id = 1,
                    Name = "dsx1",
                    Phone = "13588886666",
                    AddTime = DateTime.Now
                },
                new TestModel
                {
                    Id = 2,
                    Name = "dsx2",
                    Phone = "13588886666",
                    AddTime = DateTime.Now
                }
            };

            bool isSucc = CacheFactory.GetCache().Add(key, list);
            Assert.IsTrue(isSucc);

            bool exist = CacheFactory.GetCache().Exists(key);
            Assert.IsTrue(exist);

            List<TestModel> data = CacheFactory.GetCache().Get<List<TestModel>>(key);
            Assert.IsTrue(data.Count > 0);
        }


        private class TestModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public DateTime AddTime { get; set; }
        }
    }
}
