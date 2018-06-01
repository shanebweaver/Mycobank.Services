using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class MycobankSpecimensTaxon : Taxon
    {
        [XmlElement("_id")]
        public byte Id { get; set; }

        [XmlElement("last_change_date")]
        public string LastChangeDate { get; set; }

        [XmlElement("usermod")]
        public string Usermod { get; set; }

        [XmlElement("name")]
        public decimal Name { get; set; }

        [XmlElement("d5033")]
        public byte D5033 { get; set; }

        [XmlElement("status_")]
        public string Status { get; set; }

        [XmlElement("identifiedas_")]
        [XmlArrayItem("TargetRecord", IsNullable = false)]
        public TargetRecord[] IdentifiedAs { get; set; }

        [XmlElement("identifiedby_")]
        public object IdentifiedBy { get; set; }

        [XmlElement("rlink4703")]
        public object Rlink4703 { get; set; }

        [XmlElement("description_pt_")]
        public object Description_pt { get; set; }

        [XmlElement("strainnumbers_")]
        public object StrainNumbers { get; set; }

        [XmlElement("herbarium_pt_back_")]
        public object HerbariumBack { get; set; }

        [XmlElement("remarksspecimen_")]
        public object RemarksSpecimen { get; set; }

        [XmlElement("literature_pt_")]
        public object Literature { get; set; }

        [XmlElement("collectedby_")]
        public string CollectedBy { get; set; }

        [XmlElement("collectorsnumber_")]
        public string CollectorsNumber { get; set; }

        [XmlElement("collectiondate_")]
        [XmlElement(DataType = "date")]
        public DateTime CollectionDate { get; set; }

        [XmlElement("locationdetails_")]
        public string LocationDetails { get; set; }

        [XmlElement("locality_pt_")]
        private RecordItem<TargetRecord> _locality { get; set; }

        [XmlIgnore]
        public TargetRecord Locality => _locality.Record;

        [XmlElement("latitude_longitude_")]
        private LatitudeLongitude LatitudeLongitude { get; set; }

        [XmlElement("host_")]
        public string Host { get; set; }

        [XmlElement("substratedetails_")]
        public string SubstrateDetails { get; set; }

        [XmlElement("habitat_")]
        public object Habitat { get; set; }

        [XmlElement("relatedwebsite_")]
        public object RelatedWebsite { get; set; }

        [XmlElement("isolatedby_")]
        public object IsolatedBy { get; set; }

        [XmlElement("isolationmethod_")]
        public object IsolationMethod { get; set; }

        [XmlElement("sexualstate_")]
        public object SexualState { get; set; }

        [XmlElement("conditionsforgrowth_")]
        public object ConditionsForGrowth { get; set; }

        [XmlElement("conditionsforsporulation_")]
        public object ConditionsForSporulation { get; set; }

        [XmlElement("pathogenicity_")]
        public object Pathogenicity { get; set; }

        [XmlElement("literatureremarks_")]
        public object LiteratureRemarks { get; set; }

        [XmlElement("literaturereferencetype_")]
        public object LiteratureReferenceType { get; set; }

        [XmlElement("literaturepagenr_")]
        public object LiteraturePageNumber { get; set; }

        [XmlElement("literaturejournalbook_")]
        public object LiteratureJournalBook { get; set; }

        [XmlElement("identificationdate_")]
        public object IdentificationDate { get; set; }

        [XmlElement("dnasequence28srdna_")]
        public object DnaSequence28sRdna { get; set; }

        [XmlElement("dnasequence18srdna_")]
        public object DnaSequence18sRdna { get; set; }

        [XmlElement("dnasequenceitsrdna_")]
        public object DnaSequenceItsRdna { get; set; }

        [XmlElement("dnasequencebetatubuline_")]
        public object DnaSequenceBetatubuline { get; set; }

        [XmlElement("dnasequenceactingene_")]
        public object DnaSequenceActingene { get; set; }

        [XmlElement("dnasequenceelongationfactor_")]
        public object DnaSequenceElongationFactor { get; set; }

        [XmlElement("otherdnasequences_")]
        public object OtherDnaSequences { get; set; }

        [XmlElement("rpb1sequence_")]
        public object Rpb1Sequence { get; set; }

        [XmlElement("rpb2sequence_")]
        public object Rpb2Sequence { get; set; }

        [XmlElement("atp6sequence_")]
        public object Atp6Sequence { get; set; }

        [XmlElement("chitinesynthetase_")]
        public object ChitineSynthetase { get; set; }

        [XmlElement("files_pt_")]
        public object Files { get; set; }
    }
}
