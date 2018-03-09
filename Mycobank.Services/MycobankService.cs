namespace Mycobank.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class MycobankService : Webservice
    {
        public static MycobankService Instance = new MycobankService();

        public const string MycobankServiceTableName = "Mycobank";
        public const string MycobankServiceKeyNumber = "14682616000000161";

        protected MycobankService() : base(MycobankServiceTableName, MycobankServiceKeyNumber) { }
    }
}
