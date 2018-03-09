namespace Mycobank.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class MycobankLiteratureService : Webservice
    {
        public static MycobankLiteratureService Instance = new MycobankLiteratureService();

        public const string MycobankLiteratureServiceTableName = "Mycobank literature";
        public const string MycobankLiteratureServiceKeyNumber = "14682616000000163";

        protected MycobankLiteratureService() : base(MycobankLiteratureServiceTableName, MycobankLiteratureServiceKeyNumber) { }
    }
}
