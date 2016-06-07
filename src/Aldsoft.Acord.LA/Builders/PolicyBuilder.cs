namespace Aldsoft.Acord.LA.Builders
{
    using System;

    public abstract class PolicyBuilderBase : BuilderBase<Policy_Type>,
        Properties_PolicyBuilder<Sans_Properties_PolicyBuilder>
    {
        protected PolicyBuilderBase() : base() { }
        protected PolicyBuilderBase(Policy_Type baseEntity) : base(baseEntity) { }

        // Non-restricted
        public abstract Sans_Properties_PolicyBuilder AddOLifEExtension(OLifEExtension_Type oLifeExtension);
        public abstract Sans_Properties_PolicyBuilder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder);

        // Restricted
        public abstract Sans_Item1_PolicyBuilder WithLife(Life_Type life);
        public abstract Sans_Item1_PolicyBuilder WithLife(IBuilder<Life_Type> builder);
        public abstract Sans_Item1_PolicyBuilder WithAnnuity(Annuity_Type annuity);
        public abstract Sans_Item1_PolicyBuilder WithAnnuity(IBuilder<Annuity_Type> builder);
        public abstract Sans_Item1_PolicyBuilder WithDisabilityHealth(DisabilityHealth_Type disabilityHealth);
        public abstract Sans_Item1_PolicyBuilder WithDisabilityHealth(IBuilder<DisabilityHealth_Type> builder);
        public abstract Sans_Item1_PolicyBuilder WithPropertyandCasualty(PropertyandCasualty_Type propertyAndCasualty);
        public abstract Sans_Item1_PolicyBuilder WithPropertyandCasualty(IBuilder<PropertyandCasualty_Type> builder);
    }

    public abstract class PolicyBuilder_Sans_Properties_PolicyBuilder : PolicyBuilderBase,
        Sans_Properties_PolicyBuilder
    {
        protected PolicyBuilder_Sans_Properties_PolicyBuilder() : base() { }
        protected PolicyBuilder_Sans_Properties_PolicyBuilder(Policy_Type baseEntity) : base(baseEntity) { }
    }

    public abstract class PolicyBuilder_Sans_Item1_PolicyBuilder : PolicyBuilder_Sans_Properties_PolicyBuilder,
        Sans_Item1_PolicyBuilder
    {
        protected PolicyBuilder_Sans_Item1_PolicyBuilder() : base() { }
        protected PolicyBuilder_Sans_Item1_PolicyBuilder(Policy_Type baseEntity) : base(baseEntity) { }

        Sans_Item1_PolicyBuilder Properties_PolicyBuilder<Sans_Item1_PolicyBuilder>.AddOLifEExtension(IBuilder<OLifEExtension_Type> builder) { return (Sans_Item1_PolicyBuilder)AddOLifEExtension(builder); }
        Sans_Item1_PolicyBuilder Properties_PolicyBuilder<Sans_Item1_PolicyBuilder>.AddOLifEExtension(OLifEExtension_Type oLifeExtension) { return (Sans_Item1_PolicyBuilder)AddOLifEExtension(oLifeExtension); }
    }

    public class PolicyBuilder : PolicyBuilder_Sans_Item1_PolicyBuilder
    {
        public static PolicyBuilder CreateBuilder() { return new PolicyBuilder(); }
        public static PolicyBuilder CreateBuilder(Policy_Type baseEntity) { return new PolicyBuilder(baseEntity); }

        protected PolicyBuilder() : base() { }
        protected PolicyBuilder(Policy_Type baseEntity) : base(baseEntity) { }

        protected override void ValidateBaseObject(Policy_Type baseEntity)
        {
            if (baseEntity.ShouldSerializeItem1())
                throw new ArgumentException("The Policy_Type.Item1 value should not be set. This builder will help handle the ACORD spec logic with setting this property.", "baseEntity");
        }

        public override Sans_Properties_PolicyBuilder AddOLifEExtension(OLifEExtension_Type oLifeExtension)
        {
            _buildPropertiesActions.AddLast(n => n.OLifEExtension.Add(oLifeExtension));
            return this;
        }

        public override Sans_Properties_PolicyBuilder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.OLifEExtension.Add(builder.Build()));
            return this;
        }

        public override Sans_Item1_PolicyBuilder WithLife(Life_Type life)
        {
            _buildPropertiesActions.AddLast(n => n.Item1 = life);
            return this;
        }

        public override Sans_Item1_PolicyBuilder WithLife(IBuilder<Life_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Item1 = builder.Build());
            return this;
        }

        public override Sans_Item1_PolicyBuilder WithAnnuity(Annuity_Type annuity)
        {
            _buildPropertiesActions.AddLast(n => n.Item1 = annuity);
            return this;
        }

        public override Sans_Item1_PolicyBuilder WithAnnuity(IBuilder<Annuity_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Item1 = builder.Build());
            return this;
        }

        public override Sans_Item1_PolicyBuilder WithDisabilityHealth(DisabilityHealth_Type disabilityHealth)
        {
            _buildPropertiesActions.AddLast(n => n.Item1 = disabilityHealth);
            return this;
        }

        public override Sans_Item1_PolicyBuilder WithDisabilityHealth(IBuilder<DisabilityHealth_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Item1 = builder.Build());
            return this;
        }

        public override Sans_Item1_PolicyBuilder WithPropertyandCasualty(PropertyandCasualty_Type propertyAndCasualty)
        {
            _buildPropertiesActions.AddLast(n => n.Item1 = propertyAndCasualty);
            return this;
        }

        public override Sans_Item1_PolicyBuilder WithPropertyandCasualty(IBuilder<PropertyandCasualty_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Item1 = builder.Build());
            return this;
        }
    }

    #region Restrictive Interfaces
    public interface Item1_PolicyBuilder<TRemainder>
    {
        TRemainder WithLife(Life_Type life);
        TRemainder WithLife(IBuilder<Life_Type> builder);
        TRemainder WithAnnuity(Annuity_Type annuity);
        TRemainder WithAnnuity(IBuilder<Annuity_Type> builder);
        TRemainder WithDisabilityHealth(DisabilityHealth_Type disabilityHealth);
        TRemainder WithDisabilityHealth(IBuilder<DisabilityHealth_Type> builder);
        TRemainder WithPropertyandCasualty(PropertyandCasualty_Type propertyAndCasualty);
        TRemainder WithPropertyandCasualty(IBuilder<PropertyandCasualty_Type> builder);
    }
    #endregion

    #region Non-restrictive Interfaces
    public interface Properties_PolicyBuilder<TRemainder>
    {
        TRemainder AddOLifEExtension(OLifEExtension_Type oLifeExtension);
        TRemainder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder);
    }
    #endregion

    // level zero reductions
    public interface Sans_Properties_PolicyBuilder :
        IBuilder<Policy_Type>,
        Properties_PolicyBuilder<Sans_Properties_PolicyBuilder>,
        Item1_PolicyBuilder<Sans_Item1_PolicyBuilder>
    { }

    // level one reductions
    public interface Sans_Item1_PolicyBuilder :
        IBuilder<Policy_Type>,
        Properties_PolicyBuilder<Sans_Item1_PolicyBuilder>
    { }
}
