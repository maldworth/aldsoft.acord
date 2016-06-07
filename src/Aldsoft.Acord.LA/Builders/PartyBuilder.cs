namespace Aldsoft.Acord.LA.Builders
{
    using LA;
    using System;

    public abstract class PartyBuilderBase : BuilderBase<Party_Type>,
        Properties_PartyBuilder<Sans_Properties_PartyBuilder>
    {
        protected PartyBuilderBase() : base() { }
        protected PartyBuilderBase(Party_Type baseEntity) : base(baseEntity) { }

        // Non-restricted
        public abstract Sans_Properties_PartyBuilder AddOLifEExtension(OLifEExtension_Type oLifeExtension);
        public abstract Sans_Properties_PartyBuilder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder);

        // Restricted
        public abstract Sans_PartyTypeCode_PartyBuilder WithUnknown();
        public abstract Sans_PartyTypeCode_PartyBuilder WithPerson(Person_Type person);
        public abstract Sans_PartyTypeCode_PartyBuilder WithPerson(IBuilder<Person_Type> builder);
        public abstract Sans_PartyTypeCode_PartyBuilder WithOrganization(Organization_Type organization);
        public abstract Sans_PartyTypeCode_PartyBuilder WithOrganization(IBuilder<Organization_Type> builder);
    }

    public abstract class PartyBuilder_Sans_Properties_PartyBuilder : PartyBuilderBase,
        Sans_Properties_PartyBuilder
    {
        protected PartyBuilder_Sans_Properties_PartyBuilder() : base() { }
        protected PartyBuilder_Sans_Properties_PartyBuilder(Party_Type baseEntity) : base(baseEntity) { }
    }

    public abstract class PartyBuilder_Sans_PartyTypeCode_PartyBuilder : PartyBuilder_Sans_Properties_PartyBuilder,
        Sans_PartyTypeCode_PartyBuilder
    {
        protected PartyBuilder_Sans_PartyTypeCode_PartyBuilder() : base() { }
        protected PartyBuilder_Sans_PartyTypeCode_PartyBuilder(Party_Type baseEntity) : base(baseEntity) { }

        Sans_PartyTypeCode_PartyBuilder Properties_PartyBuilder<Sans_PartyTypeCode_PartyBuilder>.AddOLifEExtension(IBuilder<OLifEExtension_Type> builder) { return (Sans_PartyTypeCode_PartyBuilder)AddOLifEExtension(builder); }
        Sans_PartyTypeCode_PartyBuilder Properties_PartyBuilder<Sans_PartyTypeCode_PartyBuilder>.AddOLifEExtension(OLifEExtension_Type oLifeExtension) { return (Sans_PartyTypeCode_PartyBuilder)AddOLifEExtension(oLifeExtension); }
    }

    public class PartyBuilder : PartyBuilder_Sans_PartyTypeCode_PartyBuilder
    {
        public static PartyBuilder CreateBuilder() { return new PartyBuilder(); }
        public static PartyBuilder CreateBuilder(Party_Type baseEntity) { return new PartyBuilder(baseEntity); }

        private OLI_LU_PARTY _partyTypeCode = null;

        protected PartyBuilder() : base() { }
        protected PartyBuilder(Party_Type baseEntity) : base(baseEntity)
        {
        }

        protected override void ValidateBaseObject(Party_Type baseEntity)
        {
            if (baseEntity.ShouldSerializeItem())
                throw new ArgumentException("The Party_Type.Item value should not be set. This builder will help handle the ACORD spec logic with setting this property.", "baseEntity");

            if (baseEntity.ShouldSerializePartyTypeCode())
                throw new ArgumentException("The Party_Type.PartyTypeCode value should not be set. This builder will help handle the ACORD spec logic with setting this property.", "baseEntity");
        }

        protected override void ValidateBuilder()
        {
            if (_partyTypeCode == null)
                throw new InvalidOperationException("You cannot build the Party_Type entity without first setting the PartyTypeCode.");
        }

        public override Sans_PartyTypeCode_PartyBuilder WithUnknown()
        {
            _buildPropertiesActions.AddLast(n => n.PartyTypeCode = OLI_LU_PARTY.OLI_UNKNOWN);
            _partyTypeCode = OLI_LU_PARTY.OLI_UNKNOWN;
            return this;
        }

        public override Sans_PartyTypeCode_PartyBuilder WithPerson(Person_Type person)
        {
            _buildPropertiesActions.AddLast(n => n.PartyTypeCode = OLI_LU_PARTY.OLI_PT_PERSON);
            _buildPropertiesActions.AddLast(n => n.Item = person);
            _partyTypeCode = OLI_LU_PARTY.OLI_PT_PERSON;
            return this;
        }

        public override Sans_PartyTypeCode_PartyBuilder WithPerson(IBuilder<Person_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.PartyTypeCode = OLI_LU_PARTY.OLI_PT_PERSON);
            _buildPropertiesActions.AddLast(n => n.Item = builder.Build());
            _partyTypeCode = OLI_LU_PARTY.OLI_PT_PERSON;
            return this;
        }

        public override Sans_PartyTypeCode_PartyBuilder WithOrganization(Organization_Type organization)
        {
            _buildPropertiesActions.AddLast(n => n.PartyTypeCode = OLI_LU_PARTY.OLI_PT_ORG);
            _buildPropertiesActions.AddLast(n => n.Item = organization);
            _partyTypeCode = OLI_LU_PARTY.OLI_PT_ORG;
            return this;
        }

        public override Sans_PartyTypeCode_PartyBuilder WithOrganization(IBuilder<Organization_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.PartyTypeCode = OLI_LU_PARTY.OLI_PT_ORG);
            _buildPropertiesActions.AddLast(n => n.Item = builder.Build());
            _partyTypeCode = OLI_LU_PARTY.OLI_PT_ORG;
            return this;
        }

        public override Sans_Properties_PartyBuilder AddOLifEExtension(OLifEExtension_Type oLifeExtension)
        {
            _buildPropertiesActions.AddLast(n => n.OLifEExtension.Add(oLifeExtension));
            return this;
        }

        public override Sans_Properties_PartyBuilder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.OLifEExtension.Add(builder.Build()));
            return this;
        }
    }

    #region Restrictive Interfaces
    public interface Unknown_PartyBuilder<TRemainder> { TRemainder WithUnknown(); }
    public interface Person_PartyBuilder<TRemainder> { TRemainder WithPerson(Person_Type person); TRemainder WithPerson(IBuilder<Person_Type> builder); }
    public interface Organization_PartyBuilder<TRemainder> { TRemainder WithOrganization(Organization_Type organization); TRemainder WithOrganization(IBuilder<Organization_Type> builder); }
    #endregion

    #region Non-restrictive Interfaces
    public interface Properties_PartyBuilder<TRemainder>
    {
        TRemainder AddOLifEExtension(OLifEExtension_Type oLifeExtension);
        TRemainder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder);
    }
    #endregion

    // PartyBuilderBase Interface
    public interface Sans_Properties_PartyBuilder :
        IBuilder<Party_Type>,
        Properties_PartyBuilder<Sans_Properties_PartyBuilder>,
        Unknown_PartyBuilder<Sans_PartyTypeCode_PartyBuilder>,
        Person_PartyBuilder<Sans_PartyTypeCode_PartyBuilder>,
        Organization_PartyBuilder<Sans_PartyTypeCode_PartyBuilder>
    { }


    // level one reductions
    public interface Sans_PartyTypeCode_PartyBuilder :
        IBuilder<Party_Type>,
        Properties_PartyBuilder<Sans_PartyTypeCode_PartyBuilder>
    { }
}
