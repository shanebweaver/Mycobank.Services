using System.Collections.Generic;
using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    [XmlRoot("Results", Namespace = "", IsNullable = false)]
    public partial class Results<T> where T : Taxon
    {
        [XmlElement("Taxon")]
        public List<T> Taxon { get; set; }
    }
}
