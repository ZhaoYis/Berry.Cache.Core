using System;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace Berry.Cache.Core.Redis
{
    public class DefaultRedisCacheSerializer
    {
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public T Deserialize<T>(RedisValue value)
        {
            if (!value.IsNullOrEmpty)
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            return default(T);
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string Serialize(object value)
        {
            JsonSerializerSettings jsetting = new JsonSerializerSettings();

            JsonConvert.DefaultSettings = () =>
            {
                //日期类型默认格式化处理
                //不做转换，在属性上添加：[JsonConverter(typeof(IsoDateTimeConverter))]
                jsetting.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;
                jsetting.DateFormatString = "yyyy-MM-dd HH:mm:ss";

                jsetting.NullValueHandling = NullValueHandling.Include;

                return jsetting;
            };

            string res = JsonConvert.SerializeObject(value, Formatting.None, jsetting);
            return res;
        }
    }
}