using System;
using StackExchange.Redis;

namespace Berry.Cache.Core.Redis
{
    public interface IRedisCacheSerializer
    {
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        T Deserialize<T>(RedisValue value);

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        string Serialize(object value);
    }
}