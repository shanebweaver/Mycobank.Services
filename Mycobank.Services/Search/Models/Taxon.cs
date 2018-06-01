﻿using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public abstract class Taxon
    {
        [XmlElement("_id")]
        public byte Id { get; set; }
    }
}
