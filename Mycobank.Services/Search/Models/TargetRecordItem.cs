using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    public partial class TargetRecordItem
    {
        [XmlElement("TargetRecord")]
        public TargetRecord TargetRecord { get; set; }
    }
}