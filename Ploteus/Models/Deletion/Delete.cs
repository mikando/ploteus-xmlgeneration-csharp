#pragma warning disable
namespace Ploteus.Models.Deletion
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ec.europa.eu/delete/v0_1_1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ec.europa.eu/delete/v0_1_1", IsNullable=false)]
    public partial class Delete
    {
        
        private EntityTypeType _entityType;
        
        private List<string> _id;
        
        private string _key;
        
        private XsdVersionType _xsdVersion;
        
        private XsdTypeType _xsdType;
        
        public Delete()
        {
            this._id = new List<string>();
        }
        
        public EntityTypeType EntityType
        {
            get
            {
                return this._entityType;
            }
            set
            {
                this._entityType = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public List<string> Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/delete/v0_1_1")]
    [System.Xml.Serialization.XmlRootAttribute("EntityType", Namespace="http://ec.europa.eu/delete/v0_1_1", IsNullable=false)]
    public enum EntityTypeType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Learning Opportunity")]
        LearningOpportunity,
        
        /// <remarks/>
        Qualification,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/delete/v0_1_1")]
    public enum XsdVersionType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0.1.1")]
        Item011,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.europa.eu/delete/v0_1_1")]
    public enum XsdTypeType
    {
        
        /// <remarks/>
        Delete,
    }
}
#pragma warning restore
