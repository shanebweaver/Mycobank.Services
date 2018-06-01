using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class LatitudeLongitude
    {
        [XmlElement("a")]
        public A A { get; set; }
    }
}
