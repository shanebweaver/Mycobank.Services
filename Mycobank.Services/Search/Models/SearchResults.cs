using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class SearchResults<T> where T : Taxon
    {
        [XmlElement("Results")]
        [XmlArrayItem("Taxon", IsNullable = false)]
        public List<T> Results { get; set; }
    }
}
