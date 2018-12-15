# Berry.Cache.Core
```
使用方式如下：

1、缓存字符串
string key = "dsx";

            bool isSucc = CacheFactory.GetCache().Add(key, "Hello World！");
            Assert.IsTrue(isSucc);

            bool exist = CacheFactory.GetCache().Exists(key);
            Assert.IsTrue(exist);

            string data = CacheFactory.GetCache().Get<string>(key);
            Console.WriteLine(data);

```
