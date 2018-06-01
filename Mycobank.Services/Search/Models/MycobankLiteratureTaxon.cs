using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class MycobankLiteratureTaxon : Taxon
    {
        [XmlElement("creation_date")]
        public string CreationDate { get; set; }

        [XmlElement("last_change_date")]
        public string LastChangeDate { get; set; }

        [XmlElement("usermod")]
        public string UserMod { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("user")]
        public string User { get; set; }

        [XmlElement("title_")]
        public string Title { get; set; }

        [XmlElement("authors_")]
        public string Authors { get; set; }

        [XmlElement("editors_")]
        public object Editors { get; set; }

        [XmlElement("year_")]
        public ushort Year { get; set; }

        [XmlElement("_journal")]
        private RecordItem<TargetRecord> _journal { get; set; }

        [XmlIgnore]
        public TargetRecord Journal => _journal.Record;

        [XmlElement("volume_")]
        public uint Volume { get; set; }

        [XmlElement("issue_")]
        public uint Issue { get; set; }

        [XmlElement("pagefrom_")]
        public uint PageFrom { get; set; }

        [XmlElement("pageto_")]
        public uint PageTo { get; set; }

        [XmlElement("isbn_")]
        public object Isbn { get; set; }

        [XmlElement("publisher_")]
        public object Publisher { get; set; }

        [XmlElement("doi_")]
        public object Doi { get; set; }

        [XmlElement("keywords_")]
        public object Keywords { get; set; }

        [XmlElement("abstract_")]
        public object Abstract { get; set; }

        [XmlElement("hyperlink_")]
        public object Hyperlink { get; set; }

        [XmlElement("doctype_")]
        public string Doctype { get; set; }

        [XmlElement("edition_")]
        public object Edition { get; set; }

        [XmlElement("series_")]
        public object Series { get; set; }

        [XmlElement("titleabbrev_")]
        public object TitleAbbreviated { get; set; }

        [XmlElement("book_pt_")]
        public object Book { get; set; }

        [XmlElement("pubmedid_")]
        public object PubMedId { get; set; }

        [XmlElement("hyperlinkto_")]
        public object HyperlinkTo { get; set; }

        [XmlElement("taxonname_pt_")]
        [XmlArrayItem("TargetRecord", IsNullable = false)]
        public TargetRecord[] Taxonname { get; set; }

        [XmlElement("flink3746")]
        public object Flink3746 { get; set; }

        [XmlElement("e3811")]
        public string E3811 { get; set; }

        [XmlElement("e4332")]
        public string E4332 { get; set; }

        [XmlElement("e4194")]
        public object E4194 { get; set; }

        [XmlElement("e4195")]
        public object E4195 { get; set; }

        [XmlElement("e4196")]
        public object E4196 { get; set; }

        [XmlElement("e4197")]
        public object E4197 { get; set; }

        [XmlElement("e4199")]
        public object E4199 { get; set; }

        [XmlElement("e4204")]
        public object E4204 { get; set; }

        [XmlElement("e4205")]
        public object E4205 { get; set; }

        [XmlElement("e4206")]
        public object E4206 { get; set; }

        [XmlElement("e4207")]
        public object E4207 { get; set; }
    }
}
