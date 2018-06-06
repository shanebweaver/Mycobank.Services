using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    public abstract class Taxon
    {
        [XmlElement("_id")]
        public string Id { get; set; }
    }
}
