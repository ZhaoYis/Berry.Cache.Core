using Newtonsoft.Json;

namespace Berry.Cache.Core.Memcached
{
    public class DefaultMemcachedSerializer
    {
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public T Deserialize<T>(string value)
        {
            if (!string.IsNullOrEmpty(value))
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