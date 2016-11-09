#pragma warning disable
namespace Ploteus.Models.Learning
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
    public partial class LearningOpportunities
    {
        
        private List<LearningOpportunity> _learningOpportunity;
        
        private string _key;
        
        private XsdVersionType _xsdVersion;
        
        private XsdTypeType _xsdType;
        
        private string _datasourceComment;
        
        private BooleanType _incremental;
        
        public LearningOpportunities()
        {
            this._learningOpportunity = new List<LearningOpportunity>();
            this._incremental = BooleanType.@false;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LearningOpportunity")]
        public List<LearningOpportunity> LearningOpportunity
        {
            get
            {
                return this._learningOpportunity;
            }
            set
            {
                this._learningOpportunity = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
    public partial class LearningOpportunity
    {
        
        private string _learningOpportunityId;
        
        private CountryCode _countryCode;
        
        private List<i18nNonEmptyString> _title;
        
        private List<i18nNonEmptyString> _nonPreferredTerm;
        
        private List<i18nNonEmptyString> _moreInfo;
        
        private List<i18nNonEmptyString> _description;
        
        private List<i18nUrl> _url;
        
        private EducationLevelType _educationLevel;
        
        private List<object> _thematicAreas;
        
        private LanguageCode _informationLanguage;
        
        private EqfLevelType _eqfLevel;
        
        private string _nqfLevel;
        
        private List<SpecialTargetGroupType> _specialTargetGroup;
        
        private List<LanguageCode> _teachingLanguage;
        
        private List<StudyTypeType> _studyType;
        
        private DurationCodeType _durationCode;
        
        private List<i18nString> _durationInformation;
        
        private List<i18nString> _startDate;
        
        private List<Qualifications> _qualifications;
        
        private List<i18nString> _accessRequirements;
        
        private List<i18nString> _admissionProcedure;
        
        private List<i18nString> _costs;
        
        private List<i18nString> _grants;
        
        private List<i18nString> _credits;
        
        private List<i18nNonEmptyString> _providerName;
        
        private List<i18nString> _providerContactInfo;
        
        private List<i18nString> _providerType;
        
        private List<CourseLocation> _courseLocation;
        
        public LearningOpportunity()
        {
            this._courseLocation = new List<CourseLocation>();
            this._providerType = new List<i18nString>();
            this._providerContactInfo = new List<i18nString>();
            this._providerName = new List<i18nNonEmptyString>();
            this._credits = new List<i18nString>();
            this._grants = new List<i18nString>();
            this._costs = new List<i18nString>();
            this._admissionProcedure = new List<i18nString>();
            this._accessRequirements = new List<i18nString>();
            this._qualifications = new List<Qualifications>();
            this._startDate = new List<i18nString>();
            this._durationInformation = new List<i18nString>();
            this._studyType = new List<StudyTypeType>();
            this._teachingLanguage = new List<LanguageCode>();
            this._specialTargetGroup = new List<SpecialTargetGroupType>();
            this._thematicAreas = new List<object>();
            this._url = new List<i18nUrl>();
            this._description = new List<i18nNonEmptyString>();
            this._moreInfo = new List<i18nNonEmptyString>();
            this._nonPreferredTerm = new List<i18nNonEmptyString>();
            this._title = new List<i18nNonEmptyString>();
        }
        
        public string LearningOpportunityId
        {
            get
            {
                return this._learningOpportunityId;
            }
            set
            {
                this._learningOpportunityId = value;
            }
        }
        
        public CountryCode CountryCode
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
        
        [System.Xml.Serialization.XmlElementAttribute("NonPreferredTerm")]
        public List<i18nNonEmptyString> NonPreferredTerm
        {
            get
            {
                return this._nonPreferredTerm;
            }
            set
            {
                this._nonPreferredTerm = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MoreInfo")]
        public List<i18nNonEmptyString> MoreInfo
        {
            get
            {
                return this._moreInfo;
            }
            set
            {
                this._moreInfo = value;
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
        
        public EducationLevelType EducationLevel
        {
            get
            {
                return this._educationLevel;
            }
            set
            {
                this._educationLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ThematicAreas1997", typeof(ThematicAreasType1997), IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ThematicAreas2013", typeof(ThematicAreasType2013), IsNullable=false)]
        public List<object> ThematicAreas
        {
            get
            {
                return this._thematicAreas;
            }
            set
            {
                this._thematicAreas = value;
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
        
        public EqfLevelType EqfLevel
        {
            get
            {
                return this._eqfLevel;
            }
            set
            {
                this._eqfLevel = value;
            }
        }
        
        public string NqfLevel
        {
            get
            {
                return this._nqfLevel;
            }
            set
            {
                this._nqfLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecialTargetGroup")]
        public List<SpecialTargetGroupType> SpecialTargetGroup
        {
            get
            {
                return this._specialTargetGroup;
            }
            set
            {
                this._specialTargetGroup = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TeachingLanguage")]
        public List<LanguageCode> TeachingLanguage
        {
            get
            {
                return this._teachingLanguage;
            }
            set
            {
                this._teachingLanguage = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("StudyType")]
        public List<StudyTypeType> StudyType
        {
            get
            {
                return this._studyType;
            }
            set
            {
                this._studyType = value;
            }
        }
        
        public DurationCodeType DurationCode
        {
            get
            {
                return this._durationCode;
            }
            set
            {
                this._durationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DurationInformation")]
        public List<i18nString> DurationInformation
        {
            get
            {
                return this._durationInformation;
            }
            set
            {
                this._durationInformation = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("StartDate")]
        public List<i18nString> StartDate
        {
            get
            {
                return this._startDate;
            }
            set
            {
                this._startDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Qualifications")]
        public List<Qualifications> Qualifications
        {
            get
            {
                return this._qualifications;
            }
            set
            {
                this._qualifications = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("AdmissionProcedure")]
        public List<i18nString> AdmissionProcedure
        {
            get
            {
                return this._admissionProcedure;
            }
            set
            {
                this._admissionProcedure = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Costs")]
        public List<i18nString> Costs
        {
            get
            {
                return this._costs;
            }
            set
            {
                this._costs = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Grants")]
        public List<i18nString> Grants
        {
            get
            {
                return this._grants;
            }
            set
            {
                this._grants = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Credits")]
        public List<i18nString> Credits
        {
            get
            {
                return this._credits;
            }
            set
            {
                this._credits = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ProviderName")]
        public List<i18nNonEmptyString> ProviderName
        {
            get
            {
                return this._providerName;
            }
            set
            {
                this._providerName = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ProviderContactInfo")]
        public List<i18nString> ProviderContactInfo
        {
            get
            {
                return this._providerContactInfo;
            }
            set
            {
                this._providerContactInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ProviderType")]
        public List<i18nString> ProviderType
        {
            get
            {
                return this._providerType;
            }
            set
            {
                this._providerType = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CourseLocation")]
        public List<CourseLocation> CourseLocation
        {
            get
            {
                return this._courseLocation;
            }
            set
            {
                this._courseLocation = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
    public enum CountryCode
    {
        
        /// <remarks/>
        AT,
        
        /// <remarks/>
        AT11,
        
        /// <remarks/>
        AT12,
        
        /// <remarks/>
        AT13,
        
        /// <remarks/>
        AT21,
        
        /// <remarks/>
        AT22,
        
        /// <remarks/>
        AT31,
        
        /// <remarks/>
        AT32,
        
        /// <remarks/>
        AT33,
        
        /// <remarks/>
        AT34,
        
        /// <remarks/>
        BE,
        
        /// <remarks/>
        BE10,
        
        /// <remarks/>
        BE21,
        
        /// <remarks/>
        BE22,
        
        /// <remarks/>
        BE23,
        
        /// <remarks/>
        BE24,
        
        /// <remarks/>
        BE25,
        
        /// <remarks/>
        BE31,
        
        /// <remarks/>
        BE32,
        
        /// <remarks/>
        BE33,
        
        /// <remarks/>
        BE34,
        
        /// <remarks/>
        BE35,
        
        /// <remarks/>
        BG,
        
        /// <remarks/>
        BG31,
        
        /// <remarks/>
        BG32,
        
        /// <remarks/>
        BG33,
        
        /// <remarks/>
        BG34,
        
        /// <remarks/>
        BG41,
        
        /// <remarks/>
        BG42,
        
        /// <remarks/>
        CH,
        
        /// <remarks/>
        CH01,
        
        /// <remarks/>
        CH02,
        
        /// <remarks/>
        CH03,
        
        /// <remarks/>
        CH04,
        
        /// <remarks/>
        CH05,
        
        /// <remarks/>
        CH06,
        
        /// <remarks/>
        CH07,
        
        /// <remarks/>
        CY,
        
        /// <remarks/>
        CZ,
        
        /// <remarks/>
        CZ01,
        
        /// <remarks/>
        CZ02,
        
        /// <remarks/>
        CZ03,
        
        /// <remarks/>
        CZ04,
        
        /// <remarks/>
        CZ05,
        
        /// <remarks/>
        CZ06,
        
        /// <remarks/>
        CZ07,
        
        /// <remarks/>
        CZ08,
        
        /// <remarks/>
        DE,
        
        /// <remarks/>
        DE1,
        
        /// <remarks/>
        DE2,
        
        /// <remarks/>
        DE3,
        
        /// <remarks/>
        DE4,
        
        /// <remarks/>
        DE5,
        
        /// <remarks/>
        DE6,
        
        /// <remarks/>
        DE7,
        
        /// <remarks/>
        DE8,
        
        /// <remarks/>
        DE9,
        
        /// <remarks/>
        DEA,
        
        /// <remarks/>
        DEB,
        
        /// <remarks/>
        DEC,
        
        /// <remarks/>
        DED,
        
        /// <remarks/>
        DEE,
        
        /// <remarks/>
        DEF,
        
        /// <remarks/>
        DEG,
        
        /// <remarks/>
        DK,
        
        /// <remarks/>
        DK01,
        
        /// <remarks/>
        DK02,
        
        /// <remarks/>
        DK03,
        
        /// <remarks/>
        DK04,
        
        /// <remarks/>
        DK05,
        
        /// <remarks/>
        EE,
        
        /// <remarks/>
        ES,
        
        /// <remarks/>
        ES11,
        
        /// <remarks/>
        ES12,
        
        /// <remarks/>
        ES13,
        
        /// <remarks/>
        ES21,
        
        /// <remarks/>
        ES22,
        
        /// <remarks/>
        ES23,
        
        /// <remarks/>
        ES24,
        
        /// <remarks/>
        ES30,
        
        /// <remarks/>
        ES41,
        
        /// <remarks/>
        ES42,
        
        /// <remarks/>
        ES43,
        
        /// <remarks/>
        ES51,
        
        /// <remarks/>
        ES52,
        
        /// <remarks/>
        ES53,
        
        /// <remarks/>
        ES61,
        
        /// <remarks/>
        ES62,
        
        /// <remarks/>
        ES63,
        
        /// <remarks/>
        ES64,
        
        /// <remarks/>
        ES70,
        
        /// <remarks/>
        FI,
        
        /// <remarks/>
        FI13,
        
        /// <remarks/>
        FI18,
        
        /// <remarks/>
        FI19,
        
        /// <remarks/>
        FI1A,
        
        /// <remarks/>
        FI20,
        
        /// <remarks/>
        FR,
        
        /// <remarks/>
        FR10,
        
        /// <remarks/>
        FR21,
        
        /// <remarks/>
        FR22,
        
        /// <remarks/>
        FR23,
        
        /// <remarks/>
        FR24,
        
        /// <remarks/>
        FR25,
        
        /// <remarks/>
        FR26,
        
        /// <remarks/>
        FR30,
        
        /// <remarks/>
        FR41,
        
        /// <remarks/>
        FR42,
        
        /// <remarks/>
        FR43,
        
        /// <remarks/>
        FR51,
        
        /// <remarks/>
        FR52,
        
        /// <remarks/>
        FR53,
        
        /// <remarks/>
        FR61,
        
        /// <remarks/>
        FR62,
        
        /// <remarks/>
        FR63,
        
        /// <remarks/>
        FR71,
        
        /// <remarks/>
        FR72,
        
        /// <remarks/>
        FR81,
        
        /// <remarks/>
        FR82,
        
        /// <remarks/>
        FR83,
        
        /// <remarks/>
        FR91,
        
        /// <remarks/>
        FR92,
        
        /// <remarks/>
        FR93,
        
        /// <remarks/>
        FR94,
        
        /// <remarks/>
        FRZZ,
        
        /// <remarks/>
        EL,
        
        /// <remarks/>
        EL11,
        
        /// <remarks/>
        EL12,
        
        /// <remarks/>
        EL13,
        
        /// <remarks/>
        EL14,
        
        /// <remarks/>
        EL21,
        
        /// <remarks/>
        EL22,
        
        /// <remarks/>
        EL23,
        
        /// <remarks/>
        EL24,
        
        /// <remarks/>
        EL25,
        
        /// <remarks/>
        EL30,
        
        /// <remarks/>
        EL41,
        
        /// <remarks/>
        EL42,
        
        /// <remarks/>
        EL43,
        
        /// <remarks/>
        HU,
        
        /// <remarks/>
        HU10,
        
        /// <remarks/>
        HU21,
        
        /// <remarks/>
        HU22,
        
        /// <remarks/>
        HU23,
        
        /// <remarks/>
        HU31,
        
        /// <remarks/>
        HU32,
        
        /// <remarks/>
        HU33,
        
        /// <remarks/>
        IE,
        
        /// <remarks/>
        IE01,
        
        /// <remarks/>
        IE02,
        
        /// <remarks/>
        IT,
        
        /// <remarks/>
        ITC1,
        
        /// <remarks/>
        ITC2,
        
        /// <remarks/>
        ITC3,
        
        /// <remarks/>
        ITC4,
        
        /// <remarks/>
        ITD1,
        
        /// <remarks/>
        ITD2,
        
        /// <remarks/>
        ITD3,
        
        /// <remarks/>
        ITD4,
        
        /// <remarks/>
        ITD5,
        
        /// <remarks/>
        ITE1,
        
        /// <remarks/>
        ITE2,
        
        /// <remarks/>
        ITE3,
        
        /// <remarks/>
        ITE4,
        
        /// <remarks/>
        ITF1,
        
        /// <remarks/>
        ITF2,
        
        /// <remarks/>
        ITF3,
        
        /// <remarks/>
        ITF4,
        
        /// <remarks/>
        ITF5,
        
        /// <remarks/>
        ITF6,
        
        /// <remarks/>
        ITG1,
        
        /// <remarks/>
        ITG2,
        
        /// <remarks/>
        LT,
        
        /// <remarks/>
        LU,
        
        /// <remarks/>
        LV,
        
        /// <remarks/>
        MT,
        
        /// <remarks/>
        NL,
        
        /// <remarks/>
        NL11,
        
        /// <remarks/>
        NL12,
        
        /// <remarks/>
        NL13,
        
        /// <remarks/>
        NL21,
        
        /// <remarks/>
        NL22,
        
        /// <remarks/>
        NL23,
        
        /// <remarks/>
        NL31,
        
        /// <remarks/>
        NL32,
        
        /// <remarks/>
        NL33,
        
        /// <remarks/>
        NL34,
        
        /// <remarks/>
        NL41,
        
        /// <remarks/>
        NL42,
        
        /// <remarks/>
        PL,
        
        /// <remarks/>
        PL11,
        
        /// <remarks/>
        PL12,
        
        /// <remarks/>
        PL21,
        
        /// <remarks/>
        PL22,
        
        /// <remarks/>
        PL31,
        
        /// <remarks/>
        PL32,
        
        /// <remarks/>
        PL33,
        
        /// <remarks/>
        PL34,
        
        /// <remarks/>
        PL41,
        
        /// <remarks/>
        PL42,
        
        /// <remarks/>
        PL43,
        
        /// <remarks/>
        PL51,
        
        /// <remarks/>
        PL52,
        
        /// <remarks/>
        PL61,
        
        /// <remarks/>
        PL62,
        
        /// <remarks/>
        PL63,
        
        /// <remarks/>
        PT,
        
        /// <remarks/>
        PT11,
        
        /// <remarks/>
        PT15,
        
        /// <remarks/>
        PT16,
        
        /// <remarks/>
        PT17,
        
        /// <remarks/>
        PT18,
        
        /// <remarks/>
        PT20,
        
        /// <remarks/>
        PT30,
        
        /// <remarks/>
        RO,
        
        /// <remarks/>
        RO11,
        
        /// <remarks/>
        RO12,
        
        /// <remarks/>
        RO21,
        
        /// <remarks/>
        RO22,
        
        /// <remarks/>
        RO31,
        
        /// <remarks/>
        RO32,
        
        /// <remarks/>
        RO41,
        
        /// <remarks/>
        RO42,
        
        /// <remarks/>
        RS,
        
        /// <remarks/>
        RS1,
        
        /// <remarks/>
        RS2,
        
        /// <remarks/>
        RS3,
        
        /// <remarks/>
        RS4,
        
        /// <remarks/>
        RS5,
        
        /// <remarks/>
        SE,
        
        /// <remarks/>
        SE11,
        
        /// <remarks/>
        SE12,
        
        /// <remarks/>
        SE21,
        
        /// <remarks/>
        SE22,
        
        /// <remarks/>
        SE23,
        
        /// <remarks/>
        SE31,
        
        /// <remarks/>
        SE32,
        
        /// <remarks/>
        SE33,
        
        /// <remarks/>
        SI,
        
        /// <remarks/>
        SI01,
        
        /// <remarks/>
        SI02,
        
        /// <remarks/>
        SK,
        
        /// <remarks/>
        SK01,
        
        /// <remarks/>
        SK02,
        
        /// <remarks/>
        SK03,
        
        /// <remarks/>
        SK04,
        
        /// <remarks/>
        UK,
        
        /// <remarks/>
        UKC,
        
        /// <remarks/>
        UKD,
        
        /// <remarks/>
        UKE,
        
        /// <remarks/>
        UKF,
        
        /// <remarks/>
        UKG,
        
        /// <remarks/>
        UKH,
        
        /// <remarks/>
        UKI,
        
        /// <remarks/>
        UKJ,
        
        /// <remarks/>
        UKK,
        
        /// <remarks/>
        UKL,
        
        /// <remarks/>
        UKM,
        
        /// <remarks/>
        UKN,
        
        /// <remarks/>
        HR,
        
        /// <remarks/>
        HR01,
        
        /// <remarks/>
        HR02,
        
        /// <remarks/>
        HR03,
        
        /// <remarks/>
        TR,
        
        /// <remarks/>
        TR1,
        
        /// <remarks/>
        TR2,
        
        /// <remarks/>
        TR3,
        
        /// <remarks/>
        TR4,
        
        /// <remarks/>
        TR5,
        
        /// <remarks/>
        TR6,
        
        /// <remarks/>
        TR7,
        
        /// <remarks/>
        TR8,
        
        /// <remarks/>
        TR9,
        
        /// <remarks/>
        TRA,
        
        /// <remarks/>
        TRB,
        
        /// <remarks/>
        TRC,
        
        /// <remarks/>
        IS,
        
        /// <remarks/>
        LI,
        
        /// <remarks/>
        NO,
        
        /// <remarks/>
        NO01,
        
        /// <remarks/>
        NO02,
        
        /// <remarks/>
        NO03,
        
        /// <remarks/>
        NO04,
        
        /// <remarks/>
        NO05,
        
        /// <remarks/>
        NO06,
        
        /// <remarks/>
        NO07,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute("Title", Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute("InformationLanguage", Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute("ProviderContactInfo", Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute("QualificationAwardedURL", Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute("EducationLevel", Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
    public enum EducationLevelType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("44")]
        Item44,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("45")]
        Item45,
        
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    public enum ThematicAreasType1997
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0101")]
        Item0101,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("080")]
        Item080,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("090")]
        Item090,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("142")]
        Item142,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("143")]
        Item143,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("144")]
        Item144,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("145")]
        Item145,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("146")]
        Item146,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("213")]
        Item213,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("214")]
        Item214,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("211")]
        Item211,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("215")]
        Item215,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("212")]
        Item212,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("221")]
        Item221,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("225")]
        Item225,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("226")]
        Item226,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("222")]
        Item222,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("227")]
        Item227,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("223")]
        Item223,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("314")]
        Item314,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("313")]
        Item313,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("311")]
        Item311,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("312")]
        Item312,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("321")]
        Item321,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("322")]
        Item322,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("34")]
        Item34,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("344")]
        Item344,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("343")]
        Item343,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("345")]
        Item345,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("342")]
        Item342,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("346")]
        Item346,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("341")]
        Item341,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("347")]
        Item347,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("38")]
        Item38,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("380")]
        Item380,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("421")]
        Item421,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("422")]
        Item422,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("852")]
        Item852,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("44")]
        Item44,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("442")]
        Item442,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("443")]
        Item443,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("441")]
        Item441,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("46")]
        Item46,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("461")]
        Item461,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("462")]
        Item462,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48")]
        Item48,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("482")]
        Item482,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("481")]
        Item481,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("524")]
        Item524,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("85")]
        Item85,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("851")]
        Item851,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("522")]
        Item522,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("523")]
        Item523,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("521")]
        Item521,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("525")]
        Item525,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("541")]
        Item541,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("543")]
        Item543,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("542")]
        Item542,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("544")]
        Item544,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("58")]
        Item58,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("581")]
        Item581,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("582")]
        Item582,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("621")]
        Item621,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("622")]
        Item622,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("623")]
        Item623,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("624")]
        Item624,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("641")]
        Item641,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("72")]
        Item72,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("724")]
        Item724,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("721")]
        Item721,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("723")]
        Item723,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("725")]
        Item725,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("726")]
        Item726,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("727")]
        Item727,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("76")]
        Item76,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("761")]
        Item761,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("762")]
        Item762,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("81")]
        Item81,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("814")]
        Item814,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("815")]
        Item815,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("811")]
        Item811,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("813")]
        Item813,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("812")]
        Item812,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("853")]
        Item853,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("862")]
        Item862,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("86")]
        Item86,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("863")]
        Item863,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("861")]
        Item861,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("84")]
        Item84,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("840")]
        Item840,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    public enum ThematicAreasType2013
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute("EqfLevel", Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
    public enum EqfLevelType
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute("SpecialTargetGroup", Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
    public enum SpecialTargetGroupType
    {
        
        /// <remarks/>
        AE,
        
        /// <remarks/>
        SN,
        
        /// <remarks/>
        IP,
        
        /// <remarks/>
        LC,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute("StudyType", Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
    public enum StudyTypeType
    {
        
        /// <remarks/>
        FT,
        
        /// <remarks/>
        PT,
        
        /// <remarks/>
        FF,
        
        /// <remarks/>
        DL,
        
        /// <remarks/>
        ON,
        
        /// <remarks/>
        BL,
        
        /// <remarks/>
        WK,
        
        /// <remarks/>
        AP,
        
        /// <remarks/>
        TR,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute("DurationCode", Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
    public enum DurationCodeType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3M")]
        Item3M,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6M")]
        Item6M,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1Y")]
        Item1Y,
        
        /// <remarks/>
        MY,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
    public partial class Qualifications
    {
        
        private List<i18nString> _qualificationAwarded;
        
        private List<i18nString> _otherQualificationAwardedTerm;
        
        private List<i18nUrl> _qualificationAwardedURL;
        
        private List<i18nString> _qualificationAwardedDescription;
        
        private List<i18nString> _awardingBody;
        
        private List<i18nString> _awardingBodyContactInfo;
        
        private List<i18nUrl> _awardingBodyUrl;
        
        public Qualifications()
        {
            this._awardingBodyUrl = new List<i18nUrl>();
            this._awardingBodyContactInfo = new List<i18nString>();
            this._awardingBody = new List<i18nString>();
            this._qualificationAwardedDescription = new List<i18nString>();
            this._qualificationAwardedURL = new List<i18nUrl>();
            this._otherQualificationAwardedTerm = new List<i18nString>();
            this._qualificationAwarded = new List<i18nString>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("QualificationAwarded")]
        public List<i18nString> QualificationAwarded
        {
            get
            {
                return this._qualificationAwarded;
            }
            set
            {
                this._qualificationAwarded = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OtherQualificationAwardedTerm")]
        public List<i18nString> OtherQualificationAwardedTerm
        {
            get
            {
                return this._otherQualificationAwardedTerm;
            }
            set
            {
                this._otherQualificationAwardedTerm = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("QualificationAwardedURL")]
        public List<i18nUrl> QualificationAwardedURL
        {
            get
            {
                return this._qualificationAwardedURL;
            }
            set
            {
                this._qualificationAwardedURL = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("QualificationAwardedDescription")]
        public List<i18nString> QualificationAwardedDescription
        {
            get
            {
                return this._qualificationAwardedDescription;
            }
            set
            {
                this._qualificationAwardedDescription = value;
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
    public partial class CourseLocation
    {
        
        private List<i18nString> _courseLocationInfo;
        
        private List<i18nString> _courseAddress;
        
        private List<i18nString> _specialArrangements;
        
        public CourseLocation()
        {
            this._specialArrangements = new List<i18nString>();
            this._courseAddress = new List<i18nString>();
            this._courseLocationInfo = new List<i18nString>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CourseLocationInfo")]
        public List<i18nString> CourseLocationInfo
        {
            get
            {
                return this._courseLocationInfo;
            }
            set
            {
                this._courseLocationInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CourseAddress")]
        public List<i18nString> CourseAddress
        {
            get
            {
                return this._courseAddress;
            }
            set
            {
                this._courseAddress = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecialArrangements")]
        public List<i18nString> SpecialArrangements
        {
            get
            {
                return this._specialArrangements;
            }
            set
            {
                this._specialArrangements = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    public enum XsdVersionType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0.5.10")]
        Item0510,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    public enum XsdTypeType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Learning Opportunity")]
        LearningOpportunity,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ec.europa.eu/LearningOpportunities/v0_5_10", IsNullable=false)]
    public partial class ThematicAreas
    {
        
        private List<object> _items;
        
        public ThematicAreas()
        {
            this._items = new List<object>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ThematicAreas1997", typeof(ThematicAreasType1997))]
        [System.Xml.Serialization.XmlElementAttribute("ThematicAreas2013", typeof(ThematicAreasType2013))]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
    }
}
#pragma warning restore
