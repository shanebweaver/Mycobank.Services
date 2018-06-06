using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    public partial class A
    {
        [XmlAttribute("href")]
        public string Href { get; set; }

        [XmlText()]
        public string Value { get; set; }
    }
}
