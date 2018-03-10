using System;

namespace Mycobank.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class MycobankService : Webservice
    {
        public static MycobankService Instance = new Lazy<MycobankService>(() => new MycobankService()).Value;

        public const string MycobankServiceTableName = "Mycobank";
        public const string MycobankServiceKeyNumber = "14682616000000161";

        protected MycobankService() : base(MycobankServiceTableName, MycobankServiceKeyNumber) { }
    }
}
