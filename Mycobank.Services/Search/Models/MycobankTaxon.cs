using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class MycobankTaxon : Taxon
    {
        [XmlElement("_id")]
        public byte Id { get; set; }

        [XmlElement("creation_date")]
        private string _creationDate { get; set; }

        [XmlIgnore]
        public DateTime CreationDate => DateTime.Parse(_creationDate);

        [XmlElement("last_change_date")]
        private string _lastChangeDate { get; set; }

        [XmlIgnore]
        public DateTime LastChangeDate => DateTime.Parse(_lastChangeDate);

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("e3787")]
        public string E3787 { get; set; }

        [XmlElement("e4060")]
        public object E4060 { get; set; }

        [XmlElement("mycobanknr_")]
        public uint MycobankNumber { get; set; }

        [XmlElement("epithet_")]
        public string Epithet { get; set; }

        [XmlElement("rank_pt_")]
        private RecordItem<TargetRecord> _rank { get; set; }

        [XmlIgnore]
        public TargetRecord Rank => _rank.Record;

        [XmlElement("orthvariantof_pt_")]
        private RecordItem<TargetRecord> _orthvariantOf { get; set; }

        [XmlIgnore]
        public TargetRecord OrthvariantOf => _orthvariantOf.Record;

        [XmlElement("authors_")]
        public string Authors { get; set; }

        [XmlElement("authorsabbrev_")]
        public string AuthorsAbbreviated { get; set; }

        [XmlElement("ethymology_")]
        public object Ethymology { get; set; }

        [XmlElement("literature_pt_")]
        private RecordItem<TargetRecord> _literature { get; set; }

        [XmlIgnore]
        public TargetRecord Literature => _literature.Record;

        [XmlElement("literaturepagenr_")]
        public byte LiteraturePageNumber { get; set; }

        [XmlElement("literaturejournalbook_")]
        public object LiteratureJournalBook { get; set; }

        [XmlElement("nameyear_")]
        public ushort NameYear { get; set; }

        [XmlElement("nametype_")]
        public string NameType { get; set; }

        [XmlElement("gender_")]
        public string Gender { get; set; }

        [XmlElement("datepublic_")]
        public object DatePublic { get; set; }

        [XmlElement("namestatus_")]
        public string NameStatus { get; set; }

        [XmlElement("namestatusexplanation_")]
        public object NameStatusExplanation { get; set; }

        [XmlElement("remarks_")]
        public object Remarks { get; set; }

        [XmlElement("sanctioningref_")]
        public object SanctioningReference { get; set; }

        [XmlElement("sanctionedby_")]
        public string SanctionedBy { get; set; }

        [XmlElement("sanctioningname_pt_")]
        public object SanctioningName { get; set; }

        [XmlElement("validatedby_pt_")]
        public object ValidatedBy { get; set; }

        [XmlElement("specimen_pt_")]
        private RecordItem<TargetRecord> _specimen { get; set; }

        [XmlIgnore]
        public TargetRecord Specimen => _specimen.Record;

        [XmlElement("rlink4703")]
        public object Rlink4703 { get; set; }

        [XmlElement("humanpathogenicitycode_")]
        public string HumanPathogenicityCode { get; set; }

        [XmlElement("plantpathogenicitycode_")]
        public string PlantPathogenicityCode { get; set; }

        [XmlElement("codetoxicity_")]
        public string CodeToxicity { get; set; }

        [XmlElement("currentname_pt_")]
        private RecordItem<TargetRecord> _currentName { get; set; }

        [XmlIgnore]
        public string CurrentName => _currentName.Record.Name;

        [XmlElement("classification_")]
        [XmlArrayItem("ChildrenRecord", IsNullable = false)]
        public ChildrenRecord[] Classification { get; set; }

        [XmlElement("typename_pt_")]
        public object TypeName { get; set; }

        [XmlElement("basedon_pt_")]
        public object BasedOn { get; set; }

        [XmlElement("obligatesynonyms_pt_")]
        public object ObligateSynonyms { get; set; }

        [XmlElement("anamorph_pt_")]
        public object Anamorph { get; set; }

        [XmlElement("teleomorph_pt_")]
        public object Teleomorph { get; set; }

        [XmlElement("facultativesynonyms_pt_")]
        public object FacultativeSynonyms { get; set; }

        [XmlElement("v4912")]
        public object V4912 { get; set; }

        [XmlElement("description_pt_")]
        [XmlArrayItem("TargetRecord", IsNullable = false)]
        public TargetRecord[] Description { get; set; }

        [XmlElement("protolog_pt_")]
        public object Protolog { get; set; }

        [XmlElement("externallinks_")]
        public Link[] ExternalLinks { get; set; }

        [XmlElement("u3732")]
        public Link[] U3732 { get; set; }

        [XmlElement("u3733")]
        public Link[] U3733 { get; set; }

        [XmlElement("u3734")]
        public Link[] U3734 { get; set; }

        [XmlElement("u3735")]
        public Link[] U3735 { get; set; }

        [XmlElement("files_pt_")]
        public object Files { get; set; }
    }
}