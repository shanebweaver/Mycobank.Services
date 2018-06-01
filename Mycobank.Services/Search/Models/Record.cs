using System;
using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public abstract partial class Record
    {
        [XmlElement("Id")]
        public byte Id { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }
    }
}
