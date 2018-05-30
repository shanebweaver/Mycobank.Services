namespace Mycobank.Services.Search.Models
{
    public class MycobankTaxon : Taxon
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Taxon
        {

            /// <remarks/>
            public byte _id { get; set; }

            /// <remarks/>
            public string creation_date { get; set; }

            /// <remarks/>
            public string last_change_date { get; set; }

            /// <remarks/>
            public string name { get; set; }

            /// <remarks/>
            public string e3787 { get; set; }

            /// <remarks/>
            public object e4060 { get; set; }

            /// <remarks/>
            public uint mycobanknr_ { get; set; }

            /// <remarks/>
            public string epithet_ { get; set; }

            /// <remarks/>
            public TaxonRank_pt_ rank_pt_ { get; set; }

            /// <remarks/>
            public object orthvariantof_pt_ { get; set; }

            /// <remarks/>
            public string authors_ { get; set; }

            /// <remarks/>
            public string authorsabbrev_ { get; set; }

            /// <remarks/>
            public object ethymology_ { get; set; }

            /// <remarks/>
            public TaxonLiterature_pt_ literature_pt_ { get; set; }

            /// <remarks/>
            public byte literaturepagenr_ { get; set; }

            /// <remarks/>
            public object literaturejournalbook_ { get; set; }

            /// <remarks/>
            public ushort nameyear_ { get; set; }

            /// <remarks/>
            public string nametype_ { get; set; }

            /// <remarks/>
            public string gender_ { get; set; }

            /// <remarks/>
            public object datepublic_ { get; set; }

            /// <remarks/>
            public string namestatus_ { get; set; }

            /// <remarks/>
            public object namestatusexplanation_ { get; set; }

            /// <remarks/>
            public object remarks_ { get; set; }

            /// <remarks/>
            public object sanctioningref_ { get; set; }

            /// <remarks/>
            public string sanctionedby_ { get; set; }

            /// <remarks/>
            public object sanctioningname_pt_ { get; set; }

            /// <remarks/>
            public object validatedby_pt_ { get; set; }

            /// <remarks/>
            public TaxonSpecimen_pt_ specimen_pt_ { get; set; }

            /// <remarks/>
            public object rlink4703 { get; set; }

            /// <remarks/>
            public string humanpathogenicitycode_ { get; set; }

            /// <remarks/>
            public string plantpathogenicitycode_ { get; set; }

            /// <remarks/>
            public string codetoxicity_ { get; set; }

            /// <remarks/>
            public TaxonCurrentname_pt_ currentname_pt_ { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("ChildrenRecord", IsNullable = false)]
            public TaxonChildrenRecord[] classification_ { get; set; }

            /// <remarks/>
            public object typename_pt_ { get; set; }

            /// <remarks/>
            public object basedon_pt_ { get; set; }

            /// <remarks/>
            public object obligatesynonyms_pt_ { get; set; }

            /// <remarks/>
            public object anamorph_pt_ { get; set; }

            /// <remarks/>
            public object teleomorph_pt_ { get; set; }

            /// <remarks/>
            public object facultativesynonyms_pt_ { get; set; }

            /// <remarks/>
            public object v4912 { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("TargetRecord", IsNullable = false)]
            public TaxonTargetRecord[] description_pt_ { get; set; }

            /// <remarks/>
            public object protolog_pt_ { get; set; }

            /// <remarks/>
            public object externallinks_ { get; set; }

            /// <remarks/>
            public object u3732 { get; set; }

            /// <remarks/>
            public object u3733 { get; set; }

            /// <remarks/>
            public object u3734 { get; set; }

            /// <remarks/>
            public object u3735 { get; set; }

            /// <remarks/>
            public object files_pt_ { get; set; }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TaxonRank_pt_
        {

            /// <remarks/>
            public TaxonRank_pt_TargetRecord TargetRecord { get; set; }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TaxonRank_pt_TargetRecord
        {

            private byte idField;

            private string nameField;

            /// <remarks/>
            public byte Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string Name
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TaxonLiterature_pt_
        {

            private TaxonLiterature_pt_TargetRecord targetRecordField;

            /// <remarks/>
            public TaxonLiterature_pt_TargetRecord TargetRecord
            {
                get
                {
                    return this.targetRecordField;
                }
                set
                {
                    this.targetRecordField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TaxonLiterature_pt_TargetRecord
        {

            /// <remarks/>
            public byte Id { get; set; }

            /// <remarks/>
            public string Name { get; set; }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TaxonSpecimen_pt_
        {

            private TaxonSpecimen_pt_TargetRecord targetRecordField;

            /// <remarks/>
            public TaxonSpecimen_pt_TargetRecord TargetRecord
            {
                get
                {
                    return this.targetRecordField;
                }
                set
                {
                    this.targetRecordField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TaxonSpecimen_pt_TargetRecord
        {

            /// <remarks/>
            public byte Id { get; set; }

            /// <remarks/>
            public string Name { get; set; }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TaxonCurrentname_pt_
        {

            private TaxonCurrentname_pt_TargetRecord targetRecordField;

            /// <remarks/>
            public TaxonCurrentname_pt_TargetRecord TargetRecord
            {
                get
                {
                    return this.targetRecordField;
                }
                set
                {
                    this.targetRecordField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TaxonCurrentname_pt_TargetRecord
        {

            private byte idField;

            private string nameField;

            /// <remarks/>
            public byte Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string Name
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TaxonChildrenRecord
        {

            private uint idField;

            private string nameField;

            /// <remarks/>
            public uint Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string Name
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TaxonTargetRecord
        {

            private ushort idField;

            private string nameField;

            /// <remarks/>
            public ushort Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string Name
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
        }


    }
}
