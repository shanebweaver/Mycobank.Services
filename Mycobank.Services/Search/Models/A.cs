using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class A
    {
        [XmlAttribute("href")]
        public string Href { get; set; }

        [XmlText()]
        public string Value { get; set; }
    }
}
