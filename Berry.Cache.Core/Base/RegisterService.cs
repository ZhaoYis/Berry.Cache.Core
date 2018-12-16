namespace Berry.Cache.Core.Base
{
    /// <summary>
    /// 注册服务
    /// </summary>
    public class RegisterService : IRegisterService
    {
        private RegisterService()
        {
        }

        /// <summary>
        /// 开始注册
        /// </summary>
        /// <returns></returns>
        public static RegisterService Start()
        {
            return new RegisterService();
        }
    }
}