using System;
using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class RecordItem<T> where T : Record
    {
        public T Record { get; set; }
    }
}
