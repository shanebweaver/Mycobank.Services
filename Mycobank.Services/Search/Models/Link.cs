using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    public partial class Link
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Url")]
        public string Url { get; set; }
    }
}
