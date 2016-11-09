using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploteus.Tests.Properties;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using Ploteus.Models;

namespace Ploteus.Tests
{
    [TestClass]
    public class XmlGenerationTests
    {
        [TestMethod]
        public void Generate_And_Validate_Qualification_Xml()
        {
            var qualTxt = Resources.qual_full_sample;
            var qualTxtLines = qualTxt.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            var qualifications = new Ploteus.Models.Qualify.Qualifications
            {
                Incremental = Models.Qualify.BooleanType.@false,
                DatasourceComment = "This is the datasource comment",
                XsdType = Models.Qualify.XsdTypeType.Qualification,
                XsdVersion = Models.Qualify.XsdVersionType.Item0710,
                Key = "Do_Not_Touch_Here_System_Will_Generate_This_Property",
            };

            foreach (var qualTxtLine in qualTxtLines)
            {
                var qualification = new Ploteus.Models.Qualify.Qualification();
                var qualTxtColumns = qualTxtLine.Split(new string[] { "|-|" }, StringSplitOptions.None);
                qualification.QualificationId = qualTxtColumns[0];
                qualification.Title.Add(new Models.Qualify.i18nNonEmptyString { Value = qualTxtColumns[1], language = Models.Qualify.LanguageCode.en });
                qualification.NonPreferredTerms.Add(new Models.Qualify.i18nString { Value = qualTxtColumns[2], language = Models.Qualify.LanguageCode.en });
                qualification.Description.Add(new Models.Qualify.i18nNonEmptyString { Value = qualTxtColumns[3], language = Models.Qualify.LanguageCode.en });
                qualification.FurtherInfo.Add(new Models.Qualify.i18nString { Value = qualTxtColumns[4], language = Models.Qualify.LanguageCode.en });
                qualification.SourceOfFurtherInfo.Add(new Models.Qualify.i18nString { Value = qualTxtColumns[5], language = Models.Qualify.LanguageCode.en });
                qualification.Url.Add(new Models.Qualify.i18nUrl { Value = qualTxtColumns[6], language = Models.Qualify.LanguageCode.en });
                qualification.EQFLevel = getEnumValWithItem<Models.Qualify.EQFLevelType>(qualTxtColumns[7]);
                qualification.NQFLevel = getEnumValWithItem<Models.Qualify.NQFLevelType>(qualTxtColumns[8]);
                qualification.ThematicAreas2013.Add(getEnumValWithItem<Models.Qualify.ThematicAreasType>(qualTxtColumns[9]));
                qualification.InformationLanguage = getEnumVal<Models.Qualify.LanguageCode>(qualTxtColumns[10]);
                qualification.AwardingBody.Add(new Models.Qualify.i18nString { Value = qualTxtColumns[11], language = Models.Qualify.LanguageCode.en });
                qualification.AwardingBodyContactInfo.Add(new Models.Qualify.i18nString { Value = qualTxtColumns[12], language = Models.Qualify.LanguageCode.en });
                qualification.AwardingBodyUrl.Add(new Models.Qualify.i18nUrl { Value = qualTxtColumns[13], language = Models.Qualify.LanguageCode.en });
                qualification.SourceOfInformation = qualTxtColumns[14];
                qualification.SupplementLink = new System.Collections.Generic.List<Models.Qualify.SupplementLink>
                {
                    new Models.Qualify.SupplementLink
                    {
                        SupplementLanguage= getEnumVal<Models.Qualify.LanguageCode>(qualTxtColumns[15]),
                        SupplementUrl = qualTxtColumns[16]
                    }
                };
                qualification.NationalOccupationClassification.Add(new Models.Qualify.i18nString { Value = qualTxtColumns[17], language = Models.Qualify.LanguageCode.en });
                qualification.RelationshipType.Add(new Models.Qualify.i18nString { Value = qualTxtColumns[18], language = Models.Qualify.LanguageCode.en });
                qualification.ExpiryDate.Add(new Models.Qualify.i18nString { Value = qualTxtColumns[19], language = Models.Qualify.LanguageCode.en });
                qualification.AccessRequirements.Add(new Models.Qualify.i18nString { Value = qualTxtColumns[20], language = Models.Qualify.LanguageCode.en });
                qualification.WaysToAcquire.Add(new Models.Qualify.i18nString { Value = qualTxtColumns[21], language = Models.Qualify.LanguageCode.en });
                qualification.CountryCode = getEnumVal<Models.Qualify.CountryCodeType>(qualTxtColumns[22]);
                qualifications.Qualification.Add(qualification);
            }
            var xmlData = serializeToXml<Models.Qualify.Qualifications>(qualifications);

            ValidationError error = null;
            var isValidXml = ValidationUtil.ValidateXml(xmlData, out error);
            Assert.IsTrue(isValidXml);
        }

        [TestMethod]
        public void Generate_And_Validate_LearningOpportunities_Xml()
        {
            var qualTxt = Resources.lo_full_sample;
            var qualTxtLines = qualTxt.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            var learningOpportunities = new Models.Learning.LearningOpportunities
            {
                Incremental = Models.Learning.BooleanType.@false,
                DatasourceComment = "This is the datasource comment",
                XsdType = Models.Learning.XsdTypeType.LearningOpportunity,
                XsdVersion = Models.Learning.XsdVersionType.Item0510,
                Key = "Do_Not_Touch_Here_System_Will_Generate_This_Property",
            };

            foreach (var qualTxtLine in qualTxtLines)
            {
                var learningOpportunity = new Ploteus.Models.Learning.LearningOpportunity();
                var loTxtColumns = qualTxtLine.Split(new string[] { "|-|" }, StringSplitOptions.None);
                learningOpportunity.LearningOpportunityId = loTxtColumns[0];
                learningOpportunity.CountryCode = getEnumVal<Models.Learning.CountryCode>(loTxtColumns[1]);
                learningOpportunity.Title.Add(new Models.Learning.i18nNonEmptyString { Value = loTxtColumns[2], language = Models.Learning.LanguageCode.en });
                learningOpportunity.NonPreferredTerm.Add(new Models.Learning.i18nNonEmptyString { Value = loTxtColumns[3], language = Models.Learning.LanguageCode.en });
                learningOpportunity.MoreInfo.Add(new Models.Learning.i18nNonEmptyString { Value = loTxtColumns[4], language = Models.Learning.LanguageCode.en });
                learningOpportunity.Description.Add(new Models.Learning.i18nNonEmptyString { Value = loTxtColumns[5], language = Models.Learning.LanguageCode.en });
                learningOpportunity.Url.Add(new Models.Learning.i18nUrl { Value = loTxtColumns[6], language = Models.Learning.LanguageCode.en });
                learningOpportunity.EducationLevel = getEnumValWithItem<Models.Learning.EducationLevelType>(loTxtColumns[7]);
                learningOpportunity.ThematicAreas.Add(getEnumValWithItem<Models.Learning.ThematicAreasType1997>(loTxtColumns[8]));
                learningOpportunity.ThematicAreas.Add(getEnumValWithItem<Models.Learning.ThematicAreasType2013>(loTxtColumns[9]));
                learningOpportunity.InformationLanguage = getEnumVal<Models.Learning.LanguageCode>(loTxtColumns[10]);
                learningOpportunity.EqfLevel = getEnumValWithItem<Models.Learning.EqfLevelType>(loTxtColumns[11]);
                learningOpportunity.NqfLevel = loTxtColumns[12];
                learningOpportunity.SpecialTargetGroup.Add(getEnumVal<Models.Learning.SpecialTargetGroupType>(loTxtColumns[13]));
                learningOpportunity.TeachingLanguage.Add(getEnumVal<Models.Learning.LanguageCode>(loTxtColumns[14]));
                learningOpportunity.StudyType.Add(getEnumVal< Models.Learning.StudyTypeType>(loTxtColumns[15]));
                learningOpportunity.DurationCode = getEnumValWithItem<Models.Learning.DurationCodeType>(loTxtColumns[16]);
                learningOpportunity.DurationInformation.Add(new Models.Learning.i18nString { Value = loTxtColumns[17], language = Models.Learning.LanguageCode.en });
                learningOpportunity.StartDate.Add(new Models.Learning.i18nString { Value = loTxtColumns[18], language = Models.Learning.LanguageCode.en });

                var opportunityList = loTxtColumns[19].Split(new string[] { "|s|" }, StringSplitOptions.None);
                foreach (var opportunity in opportunityList)
                {
                    var oppoTxtColumns = opportunity.Split(new string[] { "|q|" }, StringSplitOptions.None);

                    var qualification = new Models.Learning.Qualifications();
                    qualification.QualificationAwarded.Add(new Models.Learning.i18nString { Value = oppoTxtColumns[0], language = Models.Learning.LanguageCode.en });
                    qualification.OtherQualificationAwardedTerm.Add(new Models.Learning.i18nString { Value = oppoTxtColumns[1], language = Models.Learning.LanguageCode.en });
                    qualification.QualificationAwardedURL.Add(new Models.Learning.i18nUrl { Value = oppoTxtColumns[2], language = Models.Learning.LanguageCode.en });
                    qualification.QualificationAwardedDescription.Add(new Models.Learning.i18nString { Value = oppoTxtColumns[3], language = Models.Learning.LanguageCode.en });
                    qualification.AwardingBody.Add(new Models.Learning.i18nString { Value = oppoTxtColumns[4], language = Models.Learning.LanguageCode.en });
                    qualification.AwardingBodyContactInfo.Add(new Models.Learning.i18nString { Value = oppoTxtColumns[5], language = Models.Learning.LanguageCode.en });
                    qualification.AwardingBodyUrl.Add(new Models.Learning.i18nUrl { Value = oppoTxtColumns[6], language = Models.Learning.LanguageCode.en });

                    learningOpportunity.Qualifications.Add(qualification);
                }

                learningOpportunity.AccessRequirements.Add(new Models.Learning.i18nString { Value = loTxtColumns[20], language = Models.Learning.LanguageCode.en });
                learningOpportunity.AdmissionProcedure.Add(new Models.Learning.i18nString { Value = loTxtColumns[21], language = Models.Learning.LanguageCode.en });
                learningOpportunity.Costs.Add(new Models.Learning.i18nString { Value = loTxtColumns[22], language = Models.Learning.LanguageCode.en });
                learningOpportunity.Grants.Add(new Models.Learning.i18nString { Value = loTxtColumns[23], language = Models.Learning.LanguageCode.en });
                learningOpportunity.Credits.Add(new Models.Learning.i18nString { Value = loTxtColumns[24], language = Models.Learning.LanguageCode.en });
                learningOpportunity.ProviderName.Add(new Models.Learning.i18nNonEmptyString { Value = loTxtColumns[25], language = Models.Learning.LanguageCode.en });
                learningOpportunity.ProviderContactInfo.Add(new Models.Learning.i18nString { Value = loTxtColumns[26], language = Models.Learning.LanguageCode.en });
                learningOpportunity.ProviderType.Add(new Models.Learning.i18nString { Value = loTxtColumns[27], language = Models.Learning.LanguageCode.en });

                var courseLocationList = loTxtColumns[28].Split(new string[] { "|s|" }, StringSplitOptions.None);
                foreach (var courseLocation in courseLocationList)
                {
                    var clTxtColumns = courseLocation.Split(new string[] { "|q|" }, StringSplitOptions.None);
                }

                learningOpportunities.LearningOpportunity.Add(learningOpportunity);
            }
            var xmlData = serializeToXml<Models.Learning.LearningOpportunities>(learningOpportunities);

            ValidationError error = null;
            var isValidXml = ValidationUtil.ValidateXml(xmlData, out error);
            Assert.IsTrue(isValidXml);
        }

        [TestMethod]
        public void Generate_And_Validate_LearningOpportunity_Deletion_Xml()
        {
            var deletion = new Models.Deletion.Delete
            {
                XsdType = Models.Deletion.XsdTypeType.Delete,
                XsdVersion = Models.Deletion.XsdVersionType.Item011,
                Key = "Do_Not_Touch_Here_System_Will_Generate_This_Property",
            };

            deletion.EntityType = Models.Deletion.EntityTypeType.LearningOpportunity;
            deletion.Id.Add("LearningOpportunityId_1");
            deletion.Id.Add("LearningOpportunityId_2");

            var xmlData = serializeToXml<Models.Deletion.Delete>(deletion);

            ValidationError error = null;
            var isValidXml = ValidationUtil.ValidateXml(xmlData, out error);
            Assert.IsTrue(isValidXml);
        }

        [TestMethod]
        public void Generate_And_Validate_Qualification_Deletion_Xml()
        {
            var deletion = new Models.Deletion.Delete
            {
                XsdType = Models.Deletion.XsdTypeType.Delete,
                XsdVersion = Models.Deletion.XsdVersionType.Item011,
                Key = "Do_Not_Touch_Here_System_Will_Generate_This_Property",
            };

            deletion.EntityType = Models.Deletion.EntityTypeType.Qualification;
            deletion.Id.Add("QualificationId_1");
            deletion.Id.Add("QualificationId_2");

            var xmlData = serializeToXml<Models.Deletion.Delete>(deletion);

            ValidationError error = null;
            var isValidXml = ValidationUtil.ValidateXml(xmlData, out error);
            Assert.IsTrue(isValidXml);
        }

        private string serializeToXml<T>(T qualifications)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms, qualifications);

                var xmlBytes = ms.ToArray();
                return Encoding.UTF8.GetString(xmlBytes);
            }
        }

        private T getEnumValWithItem<T>(string val)
        {
            return (T)Enum.Parse(typeof(T), $"Item{val}");
        }

        private T getEnumVal<T>(string val)
        {
            return (T)Enum.Parse(typeof(T), val);
        }
    }
}
