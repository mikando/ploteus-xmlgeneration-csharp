#pragma warning disable
namespace Ploteus.Models.Qualify
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Xml;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ec.europa.eu/Qualifications/v0_7_10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ec.europa.eu/Qualifications/v0_7_10", IsNullable=false)]
    public partial class Qualifications
    {
        
        private List<Qualification> _qualification;
        
        private string _key;
        
        private XsdVersionType _xsdVersion;
        
        private XsdTypeType _xsdType;
        
        private string _datasourceComment;
        
        private BooleanType _incremental;
        
        public Qualifications()
        {
            this._qualification = new List<Qualification>();
            this._incremental = BooleanType.@false;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Qualification")]
        public List<Qualification> Qualification
        {
            get
            {
                return this._qualification;
            }
            set
            {
                this._qualification = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Key
        {
            get
            {
                return this._key;
            }
            set
            {
                this._key = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public XsdVersionType XsdVersion
        {
            get
            {
                return this._xsdVersion;
            }
            set
            {
                this._xsdVersion = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public XsdTypeType XsdType
        {
            get
            {
                return this._xsdType;
            }
            set
            {
                this._xsdType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DatasourceComment
        {
            get
            {
                return this._datasourceComment;
            }
            set
            {
                this._datasourceComment = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(BooleanType.@false)]
        public BooleanType Incremental
        {
            get
            {
                return this._incremental;
            }
            set
            {
                this._incremental = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ec.europa.eu/Qualifications/v0_7_10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ec.europa.eu/Qualifications/v0_7_10", IsNullable=false)]
    public partial class Qualification
    {
        
        private string _qualificationId;
        
        private List<i18nNonEmptyString> _title;
        
        private List<i18nString> _nonPreferredTerms;
        
        private List<i18nNonEmptyString> _description;
        
        private List<i18nString> _furtherInfo;
        
        private List<i18nString> _sourceOfFurtherInfo;
        
        private List<i18nUrl> _url;
        
        private EQFLevelType _eQFLevel;
        
        private NQFLevelType _nQFLevel;
        
        private List<ThematicAreasType> _thematicAreas2013;
        
        private LanguageCode _informationLanguage;
        
        private List<i18nString> _awardingBody;
        
        private List<i18nString> _awardingBodyContactInfo;
        
        private List<i18nUrl> _awardingBodyUrl;
        
        private string _sourceOfInformation;
        
        private List<SupplementLink> _supplementLink;
        
        private List<i18nString> _nationalOccupationClassification;
        
        private List<i18nString> _relationshipType;
        
        private List<i18nString> _expiryDate;
        
        private List<i18nString> _accessRequirements;
        
        private List<i18nString> _waysToAcquire;
        
        private CountryCodeType _countryCode;
        
        public Qualification()
        {
            this._waysToAcquire = new List<i18nString>();
            this._accessRequirements = new List<i18nString>();
            this._expiryDate = new List<i18nString>();
            this._relationshipType = new List<i18nString>();
            this._nationalOccupationClassification = new List<i18nString>();
            this._supplementLink = new List<SupplementLink>();
            this._awardingBodyUrl = new List<i18nUrl>();
            this._awardingBodyContactInfo = new List<i18nString>();
            this._awardingBody = new List<i18nString>();
            this._thematicAreas2013 = new List<ThematicAreasType>();
            this._url = new List<i18nUrl>();
            this._sourceOfFurtherInfo = new List<i18nString>();
            this._furtherInfo = new List<i18nString>();
            this._description = new List<i18nNonEmptyString>();
            this._nonPreferredTerms = new List<i18nString>();
            this._title = new List<i18nNonEmptyString>();
        }
        
        public string QualificationId
        {
            get
            {
                return this._qualificationId;
            }
            set
            {
                this._qualificationId = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public List<i18nNonEmptyString> Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("NonPreferredTerms")]
        public List<i18nString> NonPreferredTerms
        {
            get
            {
                return this._nonPreferredTerms;
            }
            set
            {
                this._nonPreferredTerms = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<i18nNonEmptyString> Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FurtherInfo")]
        public List<i18nString> FurtherInfo
        {
            get
            {
                return this._furtherInfo;
            }
            set
            {
                this._furtherInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SourceOfFurtherInfo")]
        public List<i18nString> SourceOfFurtherInfo
        {
            get
            {
                return this._sourceOfFurtherInfo;
            }
            set
            {
                this._sourceOfFurtherInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Url")]
        public List<i18nUrl> Url
        {
            get
            {
                return this._url;
            }
            set
            {
                this._url = value;
            }
        }
        
        public EQFLevelType EQFLevel
        {
            get
            {
                return this._eQFLevel;
            }
            set
            {
                this._eQFLevel = value;
            }
        }
        
        public NQFLevelType NQFLevel
        {
            get
            {
                return this._nQFLevel;
            }
            set
            {
                this._nQFLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ThematicAreas2013")]
        public List<ThematicAreasType> ThematicAreas2013
        {
            get
            {
                return this._thematicAreas2013;
            }
            set
            {
                this._thematicAreas2013 = value;
            }
        }
        
        public LanguageCode InformationLanguage
        {
            get
            {
                return this._informationLanguage;
            }
            set
            {
                this._informationLanguage = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AwardingBody")]
        public List<i18nString> AwardingBody
        {
            get
            {
                return this._awardingBody;
            }
            set
            {
                this._awardingBody = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AwardingBodyContactInfo")]
        public List<i18nString> AwardingBodyContactInfo
        {
            get
            {
                return this._awardingBodyContactInfo;
            }
            set
            {
                this._awardingBodyContactInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AwardingBodyUrl")]
        public List<i18nUrl> AwardingBodyUrl
        {
            get
            {
                return this._awardingBodyUrl;
            }
            set
            {
                this._awardingBodyUrl = value;
            }
        }
        
        public string SourceOfInformation
        {
            get
            {
                return this._sourceOfInformation;
            }
            set
            {
                this._sourceOfInformation = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SupplementLink")]
        public List<SupplementLink> SupplementLink
        {
            get
            {
                return this._supplementLink;
            }
            set
            {
                this._supplementLink = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("NationalOccupationClassification")]
        public List<i18nString> NationalOccupationClassification
        {
            get
            {
                return this._nationalOccupationClassification;
            }
            set
            {
                this._nationalOccupationClassification = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RelationshipType")]
        public List<i18nString> RelationshipType
        {
            get
            {
                return this._relationshipType;
            }
            set
            {
                this._relationshipType = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ExpiryDate")]
        public List<i18nString> ExpiryDate
        {
            get
            {
                return this._expiryDate;
            }
            set
            {
                this._expiryDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AccessRequirements")]
        public List<i18nString> AccessRequirements
        {
            get
            {
                return this._accessRequirements;
            }
            set
            {
                this._accessRequirements = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("WaysToAcquire")]
        public List<i18nString> WaysToAcquire
        {
            get
            {
                return this._waysToAcquire;
            }
            set
            {
                this._waysToAcquire = value;
            }
        }
        
        public CountryCodeType CountryCode
        {
            get
            {
                return this._countryCode;
            }
            set
            {
                this._countryCode = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/Qualifications/v0_7_10")]
    [System.Xml.Serialization.XmlRootAttribute("Title", Namespace="http://ec.europa.eu/Qualifications/v0_7_10", IsNullable=false)]
    public partial class i18nNonEmptyString
    {
        
        private LanguageCode _language;
        
        private string _value;
        
        public i18nNonEmptyString()
        {
            this._language = LanguageCode.en;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(LanguageCode.en)]
        public LanguageCode language
        {
            get
            {
                return this._language;
            }
            set
            {
                this._language = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/Qualifications/v0_7_10")]
    [System.Xml.Serialization.XmlRootAttribute("InformationLanguage", Namespace="http://ec.europa.eu/Qualifications/v0_7_10", IsNullable=false)]
    public enum LanguageCode
    {
        
        /// <remarks/>
        eu,
        
        /// <remarks/>
        bg,
        
        /// <remarks/>
        ca,
        
        /// <remarks/>
        hr,
        
        /// <remarks/>
        cs,
        
        /// <remarks/>
        da,
        
        /// <remarks/>
        nl,
        
        /// <remarks/>
        en,
        
        /// <remarks/>
        et,
        
        /// <remarks/>
        fi,
        
        /// <remarks/>
        fr,
        
        /// <remarks/>
        gl,
        
        /// <remarks/>
        de,
        
        /// <remarks/>
        el,
        
        /// <remarks/>
        hu,
        
        /// <remarks/>
        @is,
        
        /// <remarks/>
        ga,
        
        /// <remarks/>
        it,
        
        /// <remarks/>
        lv,
        
        /// <remarks/>
        lt,
        
        /// <remarks/>
        mt,
        
        /// <remarks/>
        no,
        
        /// <remarks/>
        pl,
        
        /// <remarks/>
        pt,
        
        /// <remarks/>
        ro,
        
        /// <remarks/>
        ru,
        
        /// <remarks/>
        gd,
        
        /// <remarks/>
        sk,
        
        /// <remarks/>
        sl,
        
        /// <remarks/>
        es,
        
        /// <remarks/>
        sv,
        
        /// <remarks/>
        tr,
        
        /// <remarks/>
        cy,
        
        /// <remarks/>
        sr,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/Qualifications/v0_7_10")]
    [System.Xml.Serialization.XmlRootAttribute("Url", Namespace="http://ec.europa.eu/Qualifications/v0_7_10", IsNullable=false)]
    public partial class i18nUrl
    {
        
        private LanguageCode _language;
        
        private string _value;
        
        public i18nUrl()
        {
            this._language = LanguageCode.en;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(LanguageCode.en)]
        public LanguageCode language
        {
            get
            {
                return this._language;
            }
            set
            {
                this._language = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="anyURI")]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/Qualifications/v0_7_10")]
    [System.Xml.Serialization.XmlRootAttribute("NonPreferredTerms", Namespace="http://ec.europa.eu/Qualifications/v0_7_10", IsNullable=false)]
    public partial class i18nString
    {
        
        private LanguageCode _language;
        
        private string _value;
        
        public i18nString()
        {
            this._language = LanguageCode.en;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(LanguageCode.en)]
        public LanguageCode language
        {
            get
            {
                return this._language;
            }
            set
            {
                this._language = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/Qualifications/v0_7_10")]
    [System.Xml.Serialization.XmlRootAttribute("EQFLevel", Namespace="http://ec.europa.eu/Qualifications/v0_7_10", IsNullable=false)]
    public enum EQFLevelType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/Qualifications/v0_7_10")]
    [System.Xml.Serialization.XmlRootAttribute("NQFLevel", Namespace="http://ec.europa.eu/Qualifications/v0_7_10", IsNullable=false)]
    public enum NQFLevelType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("18")]
        Item18,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19")]
        Item19,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("30")]
        Item30,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/Qualifications/v0_7_10")]
    [System.Xml.Serialization.XmlRootAttribute("ThematicAreas2013", Namespace="http://ec.europa.eu/Qualifications/v0_7_10", IsNullable=false)]
    public enum ThematicAreasType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("001")]
        Item001,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0011")]
        Item0011,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("002")]
        Item002,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0021")]
        Item0021,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("003")]
        Item003,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0031")]
        Item0031,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("011")]
        Item011,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0111")]
        Item0111,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0112")]
        Item0112,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0113")]
        Item0113,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0114")]
        Item0114,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("021")]
        Item021,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0211")]
        Item0211,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0212")]
        Item0212,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0213")]
        Item0213,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0214")]
        Item0214,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0215")]
        Item0215,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("022")]
        Item022,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0221")]
        Item0221,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0222")]
        Item0222,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0223")]
        Item0223,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("023")]
        Item023,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0231")]
        Item0231,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0232")]
        Item0232,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("031")]
        Item031,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0311")]
        Item0311,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0312")]
        Item0312,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0313")]
        Item0313,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0314")]
        Item0314,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("032")]
        Item032,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0321")]
        Item0321,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0322")]
        Item0322,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("041")]
        Item041,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0411")]
        Item0411,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0412")]
        Item0412,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0413")]
        Item0413,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0414")]
        Item0414,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0415")]
        Item0415,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0416")]
        Item0416,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0417")]
        Item0417,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("042")]
        Item042,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0421")]
        Item0421,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("051")]
        Item051,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0511")]
        Item0511,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0512")]
        Item0512,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("052")]
        Item052,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0521")]
        Item0521,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0522")]
        Item0522,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("053")]
        Item053,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0531")]
        Item0531,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0532")]
        Item0532,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0533")]
        Item0533,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("054")]
        Item054,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0541")]
        Item0541,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0542")]
        Item0542,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("061")]
        Item061,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0611")]
        Item0611,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0612")]
        Item0612,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0613")]
        Item0613,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("071")]
        Item071,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0711")]
        Item0711,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0712")]
        Item0712,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0713")]
        Item0713,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0714")]
        Item0714,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0715")]
        Item0715,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0716")]
        Item0716,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("072")]
        Item072,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0721")]
        Item0721,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0722")]
        Item0722,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0723")]
        Item0723,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0724")]
        Item0724,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("073")]
        Item073,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0731")]
        Item0731,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0732")]
        Item0732,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("081")]
        Item081,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0811")]
        Item0811,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0812")]
        Item0812,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("082")]
        Item082,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0821")]
        Item0821,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("083")]
        Item083,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0831")]
        Item0831,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("084")]
        Item084,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0841")]
        Item0841,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("091")]
        Item091,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0911")]
        Item0911,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0912")]
        Item0912,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0913")]
        Item0913,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0914")]
        Item0914,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0915")]
        Item0915,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0916")]
        Item0916,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0917")]
        Item0917,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("092")]
        Item092,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0921")]
        Item0921,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0922")]
        Item0922,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0923")]
        Item0923,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("101")]
        Item101,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1011")]
        Item1011,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1012")]
        Item1012,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1013")]
        Item1013,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1014")]
        Item1014,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1015")]
        Item1015,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("102")]
        Item102,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1021")]
        Item1021,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1022")]
        Item1022,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("103")]
        Item103,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1031")]
        Item1031,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1032")]
        Item1032,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("104")]
        Item104,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1041")]
        Item1041,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ec.europa.eu/Qualifications/v0_7_10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ec.europa.eu/Qualifications/v0_7_10", IsNullable=false)]
    public partial class SupplementLink
    {
        
        private LanguageCode _supplementLanguage;
        
        private string _supplementUrl;
        
        public LanguageCode SupplementLanguage
        {
            get
            {
                return this._supplementLanguage;
            }
            set
            {
                this._supplementLanguage = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string SupplementUrl
        {
            get
            {
                return this._supplementUrl;
            }
            set
            {
                this._supplementUrl = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/Qualifications/v0_7_10")]
    [System.Xml.Serialization.XmlRootAttribute("CountryCode", Namespace="http://ec.europa.eu/Qualifications/v0_7_10", IsNullable=false)]
    public enum CountryCodeType
    {
        
        /// <remarks/>
        AT,
        
        /// <remarks/>
        BE,
        
        /// <remarks/>
        BE2,
        
        /// <remarks/>
        BE3,
        
        /// <remarks/>
        BG,
        
        /// <remarks/>
        CH,
        
        /// <remarks/>
        HR,
        
        /// <remarks/>
        CY,
        
        /// <remarks/>
        CZ,
        
        /// <remarks/>
        DK,
        
        /// <remarks/>
        EE,
        
        /// <remarks/>
        FI,
        
        /// <remarks/>
        FR,
        
        /// <remarks/>
        DE,
        
        /// <remarks/>
        EL,
        
        /// <remarks/>
        HU,
        
        /// <remarks/>
        IS,
        
        /// <remarks/>
        IE,
        
        /// <remarks/>
        IT,
        
        /// <remarks/>
        LV,
        
        /// <remarks/>
        LT,
        
        /// <remarks/>
        LU,
        
        /// <remarks/>
        MT,
        
        /// <remarks/>
        NL,
        
        /// <remarks/>
        NO,
        
        /// <remarks/>
        PL,
        
        /// <remarks/>
        PT,
        
        /// <remarks/>
        RO,
        
        /// <remarks/>
        SK,
        
        /// <remarks/>
        SI,
        
        /// <remarks/>
        ES,
        
        /// <remarks/>
        SE,
        
        /// <remarks/>
        RS,
        
        /// <remarks/>
        TR,
        
        /// <remarks/>
        UK,
        
        /// <remarks/>
        UKL,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("UK-ENI")]
        UKENI,
        
        /// <remarks/>
        UKM,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/Qualifications/v0_7_10")]
    public enum XsdVersionType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0.7.10")]
        Item0710,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/Qualifications/v0_7_10")]
    public enum XsdTypeType
    {
        
        /// <remarks/>
        Qualification,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/Qualifications/v0_7_10")]
    public enum BooleanType
    {
        
        /// <remarks/>
        @true,
        
        /// <remarks/>
        @false,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        @null,
    }
}
#pragma warning restore
