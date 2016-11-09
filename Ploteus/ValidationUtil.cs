using Ploteus.Models;
using Ploteus.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Ploteus
{
    public static class ValidationUtil
    {
        public const string Qualifications_Namespace = "http://ec.europa.eu/Qualifications/v0_7_10";
        public const string LearningOppornuties_Namespace = "http://ec.europa.eu/LearningOpportunities/v0_5_10";
        public const string Deletion_Namespace = "http://ec.europa.eu/delete/v0_1_1";
        /// <summary>
        /// Validates xml document by using ploteus schemas
        /// </summary>
        /// <param name="xml">xml document to validate</param>
        /// <param name="error">Provides validation error for invalid xml documents</param>
        /// <returns>Returns true for valid xml documents</returns>
        public static bool ValidateXml(string xml, out ValidationError error)
        {
            try
            {
                var xdoc = XDocument.Parse(xml);
                if (xdoc.Root.Name.Namespace.NamespaceName != Qualifications_Namespace
                    && xdoc.Root.Name.Namespace.NamespaceName != LearningOppornuties_Namespace
                    && xdoc.Root.Name.Namespace.NamespaceName != Deletion_Namespace)
                {
                    error = new ValidationError { Type = EnmValidationErrorType.XmlSchemaValidation, Message = "Invalid xml schema" };
                    return false;
                }
                var schemas = new XmlSchemaSet();
                using (TextReader qualificationsTr = new StringReader(Resources.qualifications_v0_7_10))
                {
                    using (TextReader learningOpportunitiesTR = new StringReader(Resources.learningOpportunities_v0_5_10))
                    {
                        using (TextReader deletionTR = new StringReader(Resources.delete_v0_1_1))
                        {
                            using (var qualificationsXmlR = XmlReader.Create(qualificationsTr))
                            {
                                using (var learningOpportunitiesXmlR = XmlReader.Create(learningOpportunitiesTR))
                                {
                                    using (var deletionXmlR = XmlReader.Create(deletionTR))
                                    {
                                        schemas.Add(Qualifications_Namespace, qualificationsXmlR);
                                        schemas.Add(LearningOppornuties_Namespace, learningOpportunitiesXmlR);
                                        schemas.Add(Deletion_Namespace, deletionXmlR);

                                        xdoc.Validate(schemas, null);
                                    }
                                }
                            }
                        }
                    }
                }
                error = null;
            }
            catch (XmlException ex)
            {
                error = new ValidationError { Type = EnmValidationErrorType.XmlParsing, Message = ex.Message };
                return false;
            }
            catch (XmlSchemaValidationException ex)
            {
                error = new ValidationError { Type = EnmValidationErrorType.XmlSchemaValidation, Message = ex.Message };
                return false;
            }
            return true;
        }
    }
}
