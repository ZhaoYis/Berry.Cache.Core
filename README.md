# Berry.Cache.Core
```
使用方式如下：

##1、缓存字符串
string key = "dsx";

bool isSucc = CacheFactory.GetCache().Add(key, "Hello World！");
Assert.IsTrue(isSucc);

bool exist = CacheFactory.GetCache().Exists(key);
Assert.IsTrue(exist);

string data = CacheFactory.GetCache().Get<string>(key);
Console.WriteLine(data);

2、缓存对象
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

3、缓存集合
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

```
