using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    public partial class Record
    {
        [XmlElement("Id")]
        public string Id { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }
    }
}
