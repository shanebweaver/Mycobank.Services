using System;

namespace Mycobank.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class MycobankLiteratureService : Webservice
    {
        public static MycobankLiteratureService Instance = new Lazy<MycobankLiteratureService>(() => new MycobankLiteratureService()).Value;

        public const string MycobankLiteratureServiceTableName = "Mycobank literature";
        public const string MycobankLiteratureServiceKeyNumber = "14682616000000163";

        protected MycobankLiteratureService() : base(MycobankLiteratureServiceTableName, MycobankLiteratureServiceKeyNumber) { }
    }
}
