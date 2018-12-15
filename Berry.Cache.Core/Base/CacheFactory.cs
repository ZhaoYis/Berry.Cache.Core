using Berry.Cache.Core.Memcached;
using Berry.Cache.Core.Redis;
using Berry.Cache.Core.Runtime;

namespace Berry.Cache.Core.Base
{
    /// <summary>
    /// 缓存工厂类
    /// </summary>
    public class CacheFactory
    {
        /// <summary>
        /// 定义通用访问入口
        /// </summary>
        /// <returns></returns>
        public static ICacheService GetCache()
        {
            //return RuntimeCacheService.GetCacheInstance();
            //return RedisCacheService.GetCacheInstance();
            return MemcachedCacheService.GetCacheInstance();
        }
    }
}