/// http://www.mycobank.org/Services/Generic/Help.aspx?s=searchservice
/// 
/// <Results>
///   <Taxon>
///     <Authors_>(Bulliard) Singer</Authors_>
///     <DatePublic_/>
///     <Epithet_>biennis</Epithet_>
///     <Rank_Pt_>
///       <TargetRecord>
///         <MainRank_>No</MainRank_>
///         <RankEnglish_>species</RankEnglish_>
///        <RankLatin_>species</RankLatin_>
///       </TargetRecord>
///     </Rank_Pt_>
///   </Taxon>
/// …
/// </Results>
/// 
namespace Mycobank.Services.Models
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Results
    {

        private ResultsTaxon[] taxonField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Taxon")]
        public ResultsTaxon[] Taxon
        {
            get
            {
                return this.taxonField;
            }
            set
            {
                this.taxonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResultsTaxon
    {

        private uint _idField;

        private string creation_dateField;

        private string last_change_dateField;

        private string nameField;

        private string e3787Field;

        private string e4060Field;

        private uint mycobanknr_Field;

        private string epithet_Field;

        private string rank_pt_Field;

        private object orthvariantof_pt_Field;

        private string authors_Field;

        private string authorsabbrev_Field;

        private string literature_pt_Field;

        private string literaturepagenr_Field;

        private string literaturejournalbook_Field;

        private string nameyear_Field;

        private string nametype_Field;

        private string gender_Field;

        private object datepublic_Field;

        private string namestatus_Field;

        private string namestatusexplanation_Field;

        private string remarks_Field;

        private object sanctioningref_Field;

        private string sanctionedby_Field;

        private string sanctioningname_pt_Field;

        private string validatedby_pt_Field;

        private string specimen_pt_Field;

        private string rlink4703Field;

        private string humanpathogenicitycode_Field;

        private string plantpathogenicitycode_Field;

        private string codetoxicity_Field;

        private string currentname_pt_Field;

        private string classification_Field;

        private string typename_pt_Field;

        private string basedon_pt_Field;

        private string obligatesynonyms_pt_Field;

        private object anamorph_pt_Field;

        private string teleomorph_pt_Field;

        private string facultativesynonyms_pt_Field;

        private object v4912Field;

        private string description_pt_Field;

        private string protolog_pt_Field;

        private string externallinks_Field;

        private string u3732Field;

        private string u3733Field;

        private string u3734Field;

        private string u3735Field;

        private object files_pt_Field;

        /// <remarks/>
        public uint _id
        {
            get
            {
                return this._idField;
            }
            set
            {
                this._idField = value;
            }
        }

        /// <remarks/>
        public string creation_date
        {
            get
            {
                return this.creation_dateField;
            }
            set
            {
                this.creation_dateField = value;
            }
        }

        /// <remarks/>
        public string last_change_date
        {
            get
            {
                return this.last_change_dateField;
            }
            set
            {
                this.last_change_dateField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string e3787
        {
            get
            {
                return this.e3787Field;
            }
            set
            {
                this.e3787Field = value;
            }
        }

        /// <remarks/>
        public string e4060
        {
            get
            {
                return this.e4060Field;
            }
            set
            {
                this.e4060Field = value;
            }
        }

        /// <remarks/>
        public uint mycobanknr_
        {
            get
            {
                return this.mycobanknr_Field;
            }
            set
            {
                this.mycobanknr_Field = value;
            }
        }

        /// <remarks/>
        public string epithet_
        {
            get
            {
                return this.epithet_Field;
            }
            set
            {
                this.epithet_Field = value;
            }
        }

        /// <remarks/>
        public string rank_pt_
        {
            get
            {
                return this.rank_pt_Field;
            }
            set
            {
                this.rank_pt_Field = value;
            }
        }

        /// <remarks/>
        public object orthvariantof_pt_
        {
            get
            {
                return this.orthvariantof_pt_Field;
            }
            set
            {
                this.orthvariantof_pt_Field = value;
            }
        }

        /// <remarks/>
        public string authors_
        {
            get
            {
                return this.authors_Field;
            }
            set
            {
                this.authors_Field = value;
            }
        }

        /// <remarks/>
        public string authorsabbrev_
        {
            get
            {
                return this.authorsabbrev_Field;
            }
            set
            {
                this.authorsabbrev_Field = value;
            }
        }

        /// <remarks/>
        public string literature_pt_
        {
            get
            {
                return this.literature_pt_Field;
            }
            set
            {
                this.literature_pt_Field = value;
            }
        }

        /// <remarks/>
        public string literaturepagenr_
        {
            get
            {
                return this.literaturepagenr_Field;
            }
            set
            {
                this.literaturepagenr_Field = value;
            }
        }

        /// <remarks/>
        public string literaturejournalbook_
        {
            get
            {
                return this.literaturejournalbook_Field;
            }
            set
            {
                this.literaturejournalbook_Field = value;
            }
        }

        /// <remarks/>
        public string nameyear_
        {
            get
            {
                return this.nameyear_Field;
            }
            set
            {
                this.nameyear_Field = value;
            }
        }

        /// <remarks/>
        public string nametype_
        {
            get
            {
                return this.nametype_Field;
            }
            set
            {
                this.nametype_Field = value;
            }
        }

        /// <remarks/>
        public string gender_
        {
            get
            {
                return this.gender_Field;
            }
            set
            {
                this.gender_Field = value;
            }
        }

        /// <remarks/>
        public object datepublic_
        {
            get
            {
                return this.datepublic_Field;
            }
            set
            {
                this.datepublic_Field = value;
            }
        }

        /// <remarks/>
        public string namestatus_
        {
            get
            {
                return this.namestatus_Field;
            }
            set
            {
                this.namestatus_Field = value;
            }
        }

        /// <remarks/>
        public string namestatusexplanation_
        {
            get
            {
                return this.namestatusexplanation_Field;
            }
            set
            {
                this.namestatusexplanation_Field = value;
            }
        }

        /// <remarks/>
        public string remarks_
        {
            get
            {
                return this.remarks_Field;
            }
            set
            {
                this.remarks_Field = value;
            }
        }

        /// <remarks/>
        public object sanctioningref_
        {
            get
            {
                return this.sanctioningref_Field;
            }
            set
            {
                this.sanctioningref_Field = value;
            }
        }

        /// <remarks/>
        public string sanctionedby_
        {
            get
            {
                return this.sanctionedby_Field;
            }
            set
            {
                this.sanctionedby_Field = value;
            }
        }

        /// <remarks/>
        public string sanctioningname_pt_
        {
            get
            {
                return this.sanctioningname_pt_Field;
            }
            set
            {
                this.sanctioningname_pt_Field = value;
            }
        }

        /// <remarks/>
        public string validatedby_pt_
        {
            get
            {
                return this.validatedby_pt_Field;
            }
            set
            {
                this.validatedby_pt_Field = value;
            }
        }

        /// <remarks/>
        public string specimen_pt_
        {
            get
            {
                return this.specimen_pt_Field;
            }
            set
            {
                this.specimen_pt_Field = value;
            }
        }

        /// <remarks/>
        public string rlink4703
        {
            get
            {
                return this.rlink4703Field;
            }
            set
            {
                this.rlink4703Field = value;
            }
        }

        /// <remarks/>
        public string humanpathogenicitycode_
        {
            get
            {
                return this.humanpathogenicitycode_Field;
            }
            set
            {
                this.humanpathogenicitycode_Field = value;
            }
        }

        /// <remarks/>
        public string plantpathogenicitycode_
        {
            get
            {
                return this.plantpathogenicitycode_Field;
            }
            set
            {
                this.plantpathogenicitycode_Field = value;
            }
        }

        /// <remarks/>
        public string codetoxicity_
        {
            get
            {
                return this.codetoxicity_Field;
            }
            set
            {
                this.codetoxicity_Field = value;
            }
        }

        /// <remarks/>
        public string currentname_pt_
        {
            get
            {
                return this.currentname_pt_Field;
            }
            set
            {
                this.currentname_pt_Field = value;
            }
        }

        /// <remarks/>
        public string classification_
        {
            get
            {
                return this.classification_Field;
            }
            set
            {
                this.classification_Field = value;
            }
        }

        /// <remarks/>
        public string typename_pt_
        {
            get
            {
                return this.typename_pt_Field;
            }
            set
            {
                this.typename_pt_Field = value;
            }
        }

        /// <remarks/>
        public string basedon_pt_
        {
            get
            {
                return this.basedon_pt_Field;
            }
            set
            {
                this.basedon_pt_Field = value;
            }
        }

        /// <remarks/>
        public string obligatesynonyms_pt_
        {
            get
            {
                return this.obligatesynonyms_pt_Field;
            }
            set
            {
                this.obligatesynonyms_pt_Field = value;
            }
        }

        /// <remarks/>
        public object anamorph_pt_
        {
            get
            {
                return this.anamorph_pt_Field;
            }
            set
            {
                this.anamorph_pt_Field = value;
            }
        }

        /// <remarks/>
        public string teleomorph_pt_
        {
            get
            {
                return this.teleomorph_pt_Field;
            }
            set
            {
                this.teleomorph_pt_Field = value;
            }
        }

        /// <remarks/>
        public string facultativesynonyms_pt_
        {
            get
            {
                return this.facultativesynonyms_pt_Field;
            }
            set
            {
                this.facultativesynonyms_pt_Field = value;
            }
        }

        /// <remarks/>
        public object v4912
        {
            get
            {
                return this.v4912Field;
            }
            set
            {
                this.v4912Field = value;
            }
        }

        /// <remarks/>
        public string description_pt_
        {
            get
            {
                return this.description_pt_Field;
            }
            set
            {
                this.description_pt_Field = value;
            }
        }

        /// <remarks/>
        public string protolog_pt_
        {
            get
            {
                return this.protolog_pt_Field;
            }
            set
            {
                this.protolog_pt_Field = value;
            }
        }

        /// <remarks/>
        public string externallinks_
        {
            get
            {
                return this.externallinks_Field;
            }
            set
            {
                this.externallinks_Field = value;
            }
        }

        /// <remarks/>
        public string u3732
        {
            get
            {
                return this.u3732Field;
            }
            set
            {
                this.u3732Field = value;
            }
        }

        /// <remarks/>
        public string u3733
        {
            get
            {
                return this.u3733Field;
            }
            set
            {
                this.u3733Field = value;
            }
        }

        /// <remarks/>
        public string u3734
        {
            get
            {
                return this.u3734Field;
            }
            set
            {
                this.u3734Field = value;
            }
        }

        /// <remarks/>
        public string u3735
        {
            get
            {
                return this.u3735Field;
            }
            set
            {
                this.u3735Field = value;
            }
        }

        /// <remarks/>
        public object files_pt_
        {
            get
            {
                return this.files_pt_Field;
            }
            set
            {
                this.files_pt_Field = value;
            }
        }
    }
}
