using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class TargetRecord
    {
        [XmlElement("Id")]
        public ushort Id { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }
    }
}
