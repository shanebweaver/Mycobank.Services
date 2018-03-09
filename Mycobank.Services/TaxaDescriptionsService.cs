namespace Mycobank.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TaxaDescriptionsService : Webservice
    {
        public static TaxaDescriptionsService Instance = new TaxaDescriptionsService();

        public const string TaxaDescriptionsServiceTableName = "Taxa descriptions";
        public const string TaxaDescriptionsServiceKeyNumber = "14682616000000209";

        protected TaxaDescriptionsService() : base(TaxaDescriptionsServiceTableName, TaxaDescriptionsServiceKeyNumber) { }
    }
}
