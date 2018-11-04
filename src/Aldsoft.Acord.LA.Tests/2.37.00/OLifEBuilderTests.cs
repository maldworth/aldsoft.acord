namespace Aldsoft.Acord.LA.Tests.V2_37_00
{
    extern alias V2_37_00;
    using V2_37_00::Aldsoft.Acord.LA;
    using Xunit;
    using System;

    
    public class OLifEBuilderTests
    {
        [Fact]
        public void V2_37_00_Relationship_Test1()
        {
            var builder = TXLife_Type.CreateBuilder()
                .Version("2.38.00")
                .AddTXLifeRequest(new TXLifeRequest_Type
                {
                    TransRefGUID = "ACORD_001_Relation_Samples",
                    TransType = OLI_LU_TRANS_TYPE_CODES._1203,
                    TransSubType = TRANS_SUBTYPE_CODES._20300,
                    TransExeDate = DateTime.Parse("2006-09-28"),
                    TransExeTime = DateTime.Parse("12:35:02"),
                    TransMode = TRANS_MODE_CODES.OLI_TRANS_MODE_ORIGINAL,
                    InquiryLevel = INQUIRY_LEVEL_CODES._3,
                    TestIndicator = OLI_LU_BOOLEAN.OLI_BOOL_TRUE,
                    OLifE = OLifE_Type
                        .CreateBuilder()
                        .AddHolding(new Holding_Type
                        {
                            id = "Holding1",
                            HoldingTypeCode = OLI_LU_HOLDTYPE.OLI_HOLDTYPE_POLICY,
                            HoldingStatus = OLI_LU_HOLDSTAT.OLI_HOLDSTAT_PROPOSED,
                            Policy = Policy_Type
                                .CreateBuilder(new Policy_Type()
                                {
                                    CarrierPartyID = "CarrierParty",
                                    ProductCode = "SPTE",
                                    CarrierCode = "12345",
                                    PlanName = "Special Term",
                                    PolicyStatus = OLI_LU_POLSTAT.OLI_POLSTAT_ACTIVE,
                                })
                                .WithLife(new Life_Type
                                {
                                    FaceAmt = 750000m,
                                    Coverage =
                                    {
                                        new Coverage_Type
                                        {
                                            id = "BaseCoverage",
                                            PlanName = "Special Term",
                                            IndicatorCode = OLI_LU_COVINDCODE.OLI_COVIND_BASE,
                                            LifeParticipant =
                                            {
                                                new LifeParticipant_Type
                                                {
                                                    id = "LifeParticipant1",
                                                    PartyID = "PartyA",
                                                    LifeParticipantRoleCode = OLI_LU_PARTICROLE.OLI_PARTICROLE_PRIMARY
                                                }
                                            }
                                        }
                                    }
                                })
                                .Build(),

                        })
                        .AddParty(new Party_Type
                        {
                            id = "CarrierParty",
                            PartyTypeCode = OLI_LU_PARTY.OLI_PT_ORG,
                            FullName = "ACME Life Insurance",
                            Carrier = new Carrier_Type { CarrierCode = "12345" },
                            Item = new Organization_Type()
                        })
                        .AddParty(
                            Party_Type
                            .CreateBuilder(new Party_Type
                            {
                                id = "PartyA",
                                GovtID = "111111111",
                                GovtIDTC = OLI_LU_GOVTIDTC.OLI_GOVTID_SSN,
                            })
                            .WithPerson(new Person_Type
                            {
                                FirstName = "Joseph",
                                LastName = "Smith",
                                Gender = OLI_LU_GENDER.OLI_GENDER_MALE,
                                BirthDate = DateTime.Parse("1954-03-28"),
                                Citizenship = OLI_LU_NATION.OLI_NATION_USA
                            })
                        )
                        .AddParty(
                            new Party_Type
                            {
                                id = "PartyB",
                                PartyTypeCode = OLI_LU_PARTY.OLI_PT_PERSON,
                                Item = new Person_Type
                                {
                                    FirstName = "Josephine",
                                    LastName = "Smith",
                                    Gender = OLI_LU_GENDER.OLI_GENDER_FEMALE
                                }
                            }
                        )
                        .AddParty(
                            new Party_Type
                            {
                                id = "PartyC",
                                PartyTypeCode = OLI_LU_PARTY.OLI_PT_PERSON,
                                Item = new Person_Type
                                {
                                    FirstName = "Jill",
                                    LastName = "Smith",
                                    Gender = OLI_LU_GENDER.OLI_GENDER_FEMALE
                                }
                            }
                        )
                        .BeginRelation("Relation_Estate")
                            .IsA(OLI_LU_REL.OLI_REL_TERTBENE)
                            .For("Holding1")
                            .EndRelation(new Relation_Type { InterestPercent = 100.0d, BeneficiaryDesignation = OLI_LU_BENEDESIGNATION.OLI_BENEDES_ESTATE })
                        .BeginRelation("Relation1")
                            .Where("PartyA")
                            .IsA(OLI_LU_REL.OLI_REL_PARENT).WithDescription(OLI_LU_RELDESC.OLI_RELDESC_FATHER)
                            .Of("PartyB")
                            .EndRelation()
                        .BeginRelation("Relation2")
                            .Where("PartyB")
                            .IsA(OLI_LU_REL.OLI_REL_CHILD).WithDescription(OLI_LU_RELDESC.OLI_RELDESC_DAUGHTER)
                            .Of("PartyA")
                            .EndRelation()
                        .BeginRelation("Relation4")
                            .IsA(OLI_LU_REL.OLI_REL_INSURED)
                            .For("Holding1")
                            .EndRelation()
                        .BeginRelation("Relation5")
                            .IsA(OLI_LU_REL.OLI_REL_OWNER)
                            .For("Holding1")
                            .EndRelation()
                        .BeginRelation("Relation6")
                            .IsA(OLI_LU_REL.OLI_REL_BENEFICIARY)
                            .For("Holding1")
                            .EndRelation(new Relation_Type { InterestPercent = 100.0d, BeneficiaryDesignation = OLI_LU_BENEDESIGNATION.OLI_BENEDES_NAMED })
                        .BeginRelation("Relation7")
                            .IsA(OLI_LU_REL.OLI_REL_CONTGNTBENE)
                            .For("Holding1")
                            .EndRelation(new Relation_Type { InterestPercent = 100.0d, BeneficiaryDesignation = OLI_LU_BENEDESIGNATION.OLI_BENEDES_NAMED })
                        .BeginRelation("Relation8")
                            .Where("PartyC")
                            .IsA(OLI_LU_REL.OLI_REL_SPOUSE).WithDescription(OLI_LU_RELDESC.OLI_RELDESC_WIFE)
                            .Of("PartyA")
                            .EndRelation()
                        .BeginRelation("Relation9")
                            .Where("PartyA")
                            .IsA(OLI_LU_REL.OLI_REL_SPOUSE).WithDescription(OLI_LU_RELDESC.OLI_RELDESC_HUSBAND)
                            .Of("PartyC")
                            .EndRelation()
                        .Build() // End of olife
                });

            // Arrange
            var txLife = builder.Build();

            // Act
            string xmlString;
            txLife.Serialize(out xmlString);

            // Assert
            Assert.DoesNotContain("<HoldingKey", xmlString);
            Assert.Contains("id=\"Relation9\"", xmlString);
        }
    }
}

