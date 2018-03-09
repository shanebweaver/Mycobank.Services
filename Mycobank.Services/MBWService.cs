namespace Mycobank.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class MBWService : Webservice
    {
        public static MBWService Instance = new MBWService();

        public const string MBWServiceTableName = "MBWService";
        public const string MBWServiceKeyNumber = "14682616000003562";

        protected MBWService() : base(MBWServiceTableName, MBWServiceKeyNumber) { }
    }
}
