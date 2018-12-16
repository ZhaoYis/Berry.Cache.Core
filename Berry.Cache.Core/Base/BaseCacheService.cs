using System;
using System.Threading.Tasks;

namespace Berry.Cache.Core.Base
{
    /// <summary>
    /// 基类
    /// </summary>
    public abstract class BaseCacheService
    {
        #region 字段
        /// <summary>
        /// 默认缓存过期时间
        /// </summary>
        protected virtual TimeSpan DefaultExpireTime
        {
            get
            {
                return TimeSpan.FromSeconds(1 * 60 * 30);
            }
        }

        /// <summary>
        /// 默认缓存Key前缀
        /// </summary>
        protected virtual string DefaultCacheKeyPrefix
        {
            get { return "Cache_Key"; }
        }

        /// <summary>
        /// TaskFalse
        /// </summary>
        protected readonly Task<bool> TaskFalse = Task.Factory.StartNew(() => false);

        /// <summary>
        /// TaskTrue
        /// </summary>
        protected readonly Task<bool> TaskTrue = Task.Factory.StartNew(() => true);

        #endregion

        #region 默认方法

        /// <summary>
        /// 组装带前缀的缓存Key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        protected virtual string GetCacheKey(string key)
        {
            return string.Format("{0}_{1}", this.DefaultCacheKeyPrefix, key);
        }

        #endregion

    }
}