using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    public partial class LatitudeLongitude
    {
        [XmlElement("a")]
        public A A { get; set; }
    }
}
