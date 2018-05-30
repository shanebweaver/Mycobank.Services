using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class Link
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Url")]
        public string Url { get; set; }
    }
}
