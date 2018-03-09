namespace Mycobank.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class MycobankSpecimensService : Webservice
    {
        public static MycobankSpecimensService Instance = new MycobankSpecimensService();

        public const string MycobankSpecimensServiceTableName = "Mycobank specimens";
        public const string MycobankSpecimensServiceKeyNumber = "14682616000000205";

        protected MycobankSpecimensService() : base(MycobankSpecimensServiceTableName, MycobankSpecimensServiceKeyNumber) { }
    }
}
