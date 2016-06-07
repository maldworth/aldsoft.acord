namespace Aldsoft.Acord.LA.Builders
{
    using LA;
    using System;

    public abstract class LifeBuilderBase : BuilderBase<Life_Type>,
        Properties_LifeBuilder<Sans_Properties_LifeBuilder>
    {
        protected LifeBuilderBase() : base() { }
        protected LifeBuilderBase(Life_Type baseEntity) : base(baseEntity) { }

        // Non-restricted
        public abstract Sans_Properties_LifeBuilder AddCoverage(Coverage_Type coverage);
        public abstract Sans_Properties_LifeBuilder AddOLifEExtension(OLifEExtension_Type oLifeExtension);
        public abstract Sans_Properties_LifeBuilder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder);

        // Restricted
        public abstract Sans_BaseCoverage_LifeBuilder AddBaseCoverage(Coverage_Type coverage);
        public abstract Sans_BaseCoverage_LifeBuilder AddBaseCoverage(IBuilder<Coverage_Type> builder);
    }

    public abstract class LifeBuilder_Sans_Properties_LifeBuilder : LifeBuilderBase,
        Sans_Properties_LifeBuilder
    {
        protected LifeBuilder_Sans_Properties_LifeBuilder() : base() { }
        protected LifeBuilder_Sans_Properties_LifeBuilder(Life_Type baseEntity) : base(baseEntity) { }
    }

    public abstract class LifeBuilder_Sans_BaseCoverage_LifeBuilder : LifeBuilder_Sans_Properties_LifeBuilder,
        Sans_BaseCoverage_LifeBuilder
    {
        protected LifeBuilder_Sans_BaseCoverage_LifeBuilder() : base() { }
        protected LifeBuilder_Sans_BaseCoverage_LifeBuilder(Life_Type baseEntity) : base(baseEntity) { }

        Sans_BaseCoverage_LifeBuilder Properties_LifeBuilder<Sans_BaseCoverage_LifeBuilder>.AddCoverage(Coverage_Type coverage) { return (Sans_BaseCoverage_LifeBuilder)AddCoverage(coverage); }
        Sans_BaseCoverage_LifeBuilder Properties_LifeBuilder<Sans_BaseCoverage_LifeBuilder>.AddOLifEExtension(IBuilder<OLifEExtension_Type> builder) { return (Sans_BaseCoverage_LifeBuilder)AddOLifEExtension(builder); }
        Sans_BaseCoverage_LifeBuilder Properties_LifeBuilder<Sans_BaseCoverage_LifeBuilder>.AddOLifEExtension(OLifEExtension_Type oLifeExtension) { return (Sans_BaseCoverage_LifeBuilder)AddOLifEExtension(oLifeExtension); }
    }

    public class LifeBuilder : LifeBuilder_Sans_BaseCoverage_LifeBuilder
    {
        public static LifeBuilder CreateBuilder() { return new LifeBuilder(); }
        public static LifeBuilder CreateBuilder(Life_Type baseEntity) { return new LifeBuilder(baseEntity); }

        private bool _hasBaseCoverage = false;

        protected LifeBuilder() : base() { }
        protected LifeBuilder(Life_Type baseEntity) : base(baseEntity)
        {
        }

        protected override void ValidateBaseObject(Life_Type baseEntity)
        {
            if (baseEntity.ShouldSerializeCoverage())
                throw new ArgumentException("The Life_Type.Coverage collections should not be set. This builder will help handle the ACORD rules with setting this property.", "baseEntity");
        }

        protected override void ValidateBuilder()
        {
            if (_hasBaseCoverage == false)
                throw new InvalidOperationException("You cannot build the Life_Type entity without a base coverage.");
        }

        public override Sans_BaseCoverage_LifeBuilder AddBaseCoverage(Coverage_Type coverage)
        {
            SetBaseCoverage(coverage);

            // Make our Base coverage always first in the list. This isn't required, but it's nice to have
            _buildPropertiesActions.AddFirst(n => n.Coverage.Add(coverage));
            _hasBaseCoverage = true;
            return this;
        }

        public override Sans_BaseCoverage_LifeBuilder AddBaseCoverage(IBuilder<Coverage_Type> builder)
        {
            // Make our Base coverage always first in the list. This isn't required, but it's nice to have
            _buildPropertiesActions.AddFirst(n =>
            {
                var coverage = builder.Build();
                SetBaseCoverage(coverage);
                n.Coverage.Add(coverage);
            });
            _hasBaseCoverage = true;
            return this;
        }

        public override Sans_Properties_LifeBuilder AddCoverage(Coverage_Type coverage)
        {
            _buildPropertiesActions.AddLast(n => n.Coverage.Add(coverage));
            return this;
        }

        public override Sans_Properties_LifeBuilder AddOLifEExtension(OLifEExtension_Type oLifeExtension)
        {
            _buildPropertiesActions.AddLast(n => n.OLifEExtension.Add(oLifeExtension));
            return this;
        }

        public override Sans_Properties_LifeBuilder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.OLifEExtension.Add(builder.Build()));
            return this;
        }

        private void SetBaseCoverage(Coverage_Type coverage)
        {
            if (coverage.ShouldSerializeIndicatorCode())
                throw new ArgumentException("The Coverage_Type.IndicatorCode must be null, because this method will set it to the appropriate value", "coverage.IndicatorCode");

            coverage.IndicatorCode = OLI_LU_COVINDCODE.OLI_COVIND_BASE;
        }
    }

    #region Restrictive Interfaces
    public interface BaseCoverage_LifeBuilder<TRemainder> { TRemainder AddBaseCoverage(Coverage_Type coverage); TRemainder AddBaseCoverage(IBuilder<Coverage_Type> builder); }
    #endregion

    #region Non-restrictive Interfaces
    public interface Properties_LifeBuilder<TRemainder>
    {
        TRemainder AddCoverage(Coverage_Type coverage);
        TRemainder AddOLifEExtension(OLifEExtension_Type oLifeExtension);
        TRemainder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder);
    }
    #endregion

    // LifeBuilderBase Interface
    public interface Sans_Properties_LifeBuilder :
        IBuilder<Life_Type>,
        Properties_LifeBuilder<Sans_Properties_LifeBuilder>,
        BaseCoverage_LifeBuilder<Sans_BaseCoverage_LifeBuilder>
    { }


    // level one reductions
    public interface Sans_BaseCoverage_LifeBuilder :
        IBuilder<Life_Type>,
        Properties_LifeBuilder<Sans_BaseCoverage_LifeBuilder>
    { }
}
