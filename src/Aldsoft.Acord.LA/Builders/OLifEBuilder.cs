namespace Aldsoft.Acord.LA.Builders
{
    using LA;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class OLifEBuilderBase : BuilderBase<OLifE_Type>,
        Properties_OLifEBuilder<Sans_Properties_OLifEBuilder>
    {
        protected OLifEBuilderBase() : base() { }
        protected OLifEBuilderBase(OLifE_Type baseEntity) : base(baseEntity) { }

        // Non-restricted
        public abstract Sans_Properties_OLifEBuilder Version(string version);
        public abstract Sans_Properties_OLifEBuilder AddActivity(Activity_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddActivity(IBuilder<Activity_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddAuditEntry(AuditEntry_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddAuditEntry(IBuilder<AuditEntry_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddBusinessProcessDef(BusinessProcessDef_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddBusinessProcessDef(IBuilder<BusinessProcessDef_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddCampaign(Campaign_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddCampaign(IBuilder<Campaign_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddCase(Case_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddCase(IBuilder<Case_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddCodeList(CodeList_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddCodeList(IBuilder<CodeList_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddCommSchedule(CommSchedule_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddCommSchedule(IBuilder<CommSchedule_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddCriteria(Criteria_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddCriteria(IBuilder<Criteria_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddCurrency(Currency_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddCurrency(IBuilder<Currency_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddDistributionAgreement(DistributionAgreement_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddDistributionAgreement(IBuilder<DistributionAgreement_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddFinancialStatement(FinancialStatement_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddFinancialStatement(IBuilder<FinancialStatement_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddFormInstance(FormInstance_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddFormInstance(IBuilder<FormInstance_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddGrouping(Grouping_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddGrouping(IBuilder<Grouping_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddHolding(Holding_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddHolding(IBuilder<Holding_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddInvestProduct(InvestProduct_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddInvestProduct(IBuilder<InvestProduct_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddKeyedValue(KeyedValue_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddKeyedValue(IBuilder<KeyedValue_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddOLifEExtension(OLifEExtension_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddParty(Party_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddParty(IBuilder<Party_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddPolicyProduct(PolicyProduct_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddPolicyProduct(IBuilder<PolicyProduct_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddRelation(Relation_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddRelation(IBuilder<Relation_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddScenario(Scenario_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddScenario(IBuilder<Scenario_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddSettlementInfo(SettlementInfo_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddSettlementInfo(IBuilder<SettlementInfo_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddSystemMessage(SystemMessage_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddSystemMessage(IBuilder<SystemMessage_Type> builder);
        public abstract Sans_Properties_OLifEBuilder AddUnderwritingGuidelines(UnderwritingGuidelines_Type entity);
        public abstract Sans_Properties_OLifEBuilder AddUnderwritingGuidelines(IBuilder<UnderwritingGuidelines_Type> builder);

        // Restricted
        public abstract Sans_BeginRelation_OLifEBuilder BeginRelation(string id);
        public abstract Sans_Relation_IsA_OLifEBuilder IsA(OLI_LU_REL relationRoleCode);
        public abstract Sans_Relation_IsA_For_OLifEBuilder For(string originatingObjectID);
        public abstract Sans_Relation_Where_OLifEBuilder Where(string relatedObjectID);
        public abstract Sans_Relation_Where_IsA_WithDescription_OLifEBuilder WithDescription(OLI_LU_RELDESC relationDescription);
        public abstract Sans_Relation_Where_IsA_Of_OLifEBuilder Of(string originatingObjectID);
        public abstract Sans_Relation_Where_IsA_Of_AndReciprocal_OLifEBuilder AndReciprocal(string id, OLI_LU_REL relationRoleCode);
        public abstract Sans_Properties_OLifEBuilder EndRelation();
        public abstract Sans_Properties_OLifEBuilder EndRelation(Relation_Type entity);
        public abstract Sans_Properties_OLifEBuilder EndRelation(Relation_Type entity, Relation_Type reciprocalEntity);
    }

    public abstract class OLifEBuilder_Sans_Properties_OLifEBuilderBase : OLifEBuilderBase,
        Sans_Properties_OLifEBuilder
    {
        protected OLifEBuilder_Sans_Properties_OLifEBuilderBase() : base() { }
        protected OLifEBuilder_Sans_Properties_OLifEBuilderBase(OLifE_Type baseEntity) : base(baseEntity) { }
    }

    public abstract class OLifEBuilder_Sans_BeginRelation_OLifEBuilder : OLifEBuilder_Sans_Properties_OLifEBuilderBase,
        Sans_BeginRelation_OLifEBuilder
    {
        protected OLifEBuilder_Sans_BeginRelation_OLifEBuilder() : base() { }
        protected OLifEBuilder_Sans_BeginRelation_OLifEBuilder(OLifE_Type baseEntity) : base(baseEntity) { }
    }

    public abstract class OLifEBuilder_Sans_Relation_IsA_OLifEBuilder : OLifEBuilder_Sans_BeginRelation_OLifEBuilder,
        Sans_Relation_IsA_OLifEBuilder
    {
        protected OLifEBuilder_Sans_Relation_IsA_OLifEBuilder() : base() { }
        protected OLifEBuilder_Sans_Relation_IsA_OLifEBuilder(OLifE_Type baseEntity) : base(baseEntity) { }
    }

    public abstract class OLifEBuilder_Sans_Relation_Where_OLifEBuilder : OLifEBuilder_Sans_Relation_IsA_OLifEBuilder,
        Sans_Relation_Where_OLifEBuilder
    {
        protected OLifEBuilder_Sans_Relation_Where_OLifEBuilder() : base() { }
        protected OLifEBuilder_Sans_Relation_Where_OLifEBuilder(OLifE_Type baseEntity) : base(baseEntity) { }

        Sans_Relation_Where_IsA_OLifEBuilder Relation_IsA_OLifEBuilder<Sans_Relation_Where_IsA_OLifEBuilder>.IsA(OLI_LU_REL relationRoleCode) { return (Sans_Relation_Where_IsA_OLifEBuilder)IsA(relationRoleCode); }
    }

    public abstract class OLifEBuilder_Sans_Relation_IsA_For_OLifEBuilder : OLifEBuilder_Sans_Relation_Where_OLifEBuilder,
        Sans_Relation_IsA_For_OLifEBuilder
    {
        protected OLifEBuilder_Sans_Relation_IsA_For_OLifEBuilder() : base() { }
        protected OLifEBuilder_Sans_Relation_IsA_For_OLifEBuilder(OLifE_Type baseEntity) : base(baseEntity) { }
    }

    public abstract class OLifEBuilder_Sans_Relation_Where_IsA_OLifEBuilder : OLifEBuilder_Sans_Relation_IsA_For_OLifEBuilder,
        Sans_Relation_Where_IsA_OLifEBuilder
    {
        protected OLifEBuilder_Sans_Relation_Where_IsA_OLifEBuilder() : base() { }
        protected OLifEBuilder_Sans_Relation_Where_IsA_OLifEBuilder(OLifE_Type baseEntity) : base(baseEntity) { }
    }

    public abstract class OLifEBuilder_Sans_Relation_Where_IsA_WithDescription_OLifEBuilder : OLifEBuilder_Sans_Relation_Where_IsA_OLifEBuilder,
        Sans_Relation_Where_IsA_WithDescription_OLifEBuilder
    {
        protected OLifEBuilder_Sans_Relation_Where_IsA_WithDescription_OLifEBuilder() : base() { }
        protected OLifEBuilder_Sans_Relation_Where_IsA_WithDescription_OLifEBuilder(OLifE_Type baseEntity) : base(baseEntity) { }
    }

    public abstract class OLifEBuilder_Sans_Relation_Where_IsA_Of_OLifEBuilder : OLifEBuilder_Sans_Relation_Where_IsA_WithDescription_OLifEBuilder,
        Sans_Relation_Where_IsA_Of_OLifEBuilder
    {
        protected OLifEBuilder_Sans_Relation_Where_IsA_Of_OLifEBuilder() : base() { }
        protected OLifEBuilder_Sans_Relation_Where_IsA_Of_OLifEBuilder(OLifE_Type baseEntity) : base(baseEntity) { }
    }

    public abstract class OLifEBuilder_Sans_Relation_Where_IsA_Of_AndReciprocal_OLifEBuilder : OLifEBuilder_Sans_Relation_Where_IsA_Of_OLifEBuilder,
        Sans_Relation_Where_IsA_Of_AndReciprocal_OLifEBuilder
    {
        protected OLifEBuilder_Sans_Relation_Where_IsA_Of_AndReciprocal_OLifEBuilder() : base() { }
        protected OLifEBuilder_Sans_Relation_Where_IsA_Of_AndReciprocal_OLifEBuilder(OLifE_Type baseEntity) : base(baseEntity) { }

        Sans_Relation_Where_IsA_Of_AndReciprocal_WithDescription_OLifEBuilder Relation_WithDescription_OLifEBuilder<Sans_Relation_Where_IsA_Of_AndReciprocal_WithDescription_OLifEBuilder>.WithDescription(OLI_LU_RELDESC relationDescription) { return (Sans_Relation_Where_IsA_Of_AndReciprocal_WithDescription_OLifEBuilder)WithDescription(relationDescription); }
    }

    public abstract class OLifEBuilder_Sans_Relation_Where_IsA_Of_AndReciprocal_WithDescription_OLifEBuilder : OLifEBuilder_Sans_Relation_Where_IsA_Of_AndReciprocal_OLifEBuilder,
        Sans_Relation_Where_IsA_Of_AndReciprocal_WithDescription_OLifEBuilder
    {
        protected OLifEBuilder_Sans_Relation_Where_IsA_Of_AndReciprocal_WithDescription_OLifEBuilder() : base() { }
        protected OLifEBuilder_Sans_Relation_Where_IsA_Of_AndReciprocal_WithDescription_OLifEBuilder(OLifE_Type baseEntity) : base(baseEntity) { }
    }

    public class OLifEBuilder : OLifEBuilder_Sans_Relation_Where_IsA_Of_AndReciprocal_WithDescription_OLifEBuilder
    {
        public static OLifEBuilder CreateBuilder() { return new OLifEBuilder(); }
        public static OLifEBuilder CreateBuilder(OLifE_Type oLife) { return new OLifEBuilder(oLife); }

        private readonly Dictionary<Type, OLI_LU_OBJECTTYPE> _typeToOliLuObjectType = new Dictionary<Type, OLI_LU_OBJECTTYPE>()
        {
            // I haven't found a clear list of what types can or cannot be related.
            // So I guessed, and this list can be reduced or expanded as necessary
            { typeof(Activity_Type), OLI_LU_OBJECTTYPE.OLI_ACTIVITY },
            { typeof(Campaign_Type), OLI_LU_OBJECTTYPE.OLI_CAMPAIGN},
            { typeof(Case_Type), OLI_LU_OBJECTTYPE.OLI_CASE},
            { typeof(DistributionAgreement_Type), OLI_LU_OBJECTTYPE.OLI_DISTRIBUTATIONAGREEMENT},
            { typeof(FinancialStatement_Type), OLI_LU_OBJECTTYPE.OLI_FINANCIALSTATEMENT},
            { typeof(FormInstance_Type), OLI_LU_OBJECTTYPE.OLI_FORMINSTANCE},
            { typeof(Grouping_Type), OLI_LU_OBJECTTYPE.OLI_GROUPING},
            { typeof(Holding_Type), OLI_LU_OBJECTTYPE.OLI_HOLDING},
            { typeof(InvestProduct_Type), OLI_LU_OBJECTTYPE.OLI_INVESTPRODUCT},
            { typeof(Party_Type), OLI_LU_OBJECTTYPE.OLI_PARTY},
            { typeof(PolicyProduct_Type), OLI_LU_OBJECTTYPE.OLI_POLICYPRODUCT},
            { typeof(Scenario_Type), OLI_LU_OBJECTTYPE.OLI_SCENARIO},
            { typeof(SettlementInfo_Type), OLI_LU_OBJECTTYPE.OLI_SETTLEMENTINFO}
        };

        private readonly LinkedList<Action<OLifE_Type>> _buildRelationshipsActions = new LinkedList<Action<OLifE_Type>>();

        private Relation_Type _buildRelation;
        private Relation_Type _buildReciprocalRelation;

        protected OLifEBuilder() : base() { }
        protected OLifEBuilder(OLifE_Type baseEntity) : base(baseEntity) { }

        protected override void ValidateBaseObject(OLifE_Type baseEntity)
        {
            if (baseEntity.ShouldSerializeItems())
                throw new ArgumentException("The OLifE_Type.Items collection should be empty. This builder will help handle the ACORD spec logic with setting this property.", "baseEntity");
        }

        public override OLifE_Type Build()
        {
            var resultEntity = base.Build();

            BuildRelationships(resultEntity);

            return resultEntity;
        }

        public override OLifE_Type Build(OLifE_Type baseEntity)
        {
            var resultEntity = base.Build(baseEntity);

            BuildRelationships(resultEntity);

            return resultEntity;
        }

        private void BuildRelationships(OLifE_Type entity)
        {
            // Build the relationships
            // this is done last, so we can check that the ID's we are relating exist.
            var node = _buildRelationshipsActions.First;
            while (node != null)
            {
                node.Value(entity);
                node = node.Next;
            }
        }

        #region Non-restrictive
        public override Sans_Properties_OLifEBuilder Version(string version)
        {
            _buildPropertiesActions.AddLast(n => n.Version = version);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddActivity(Activity_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddActivity(IBuilder<Activity_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddAuditEntry(AuditEntry_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddAuditEntry(IBuilder<AuditEntry_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddBusinessProcessDef(BusinessProcessDef_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddBusinessProcessDef(IBuilder<BusinessProcessDef_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddCampaign(Campaign_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddCampaign(IBuilder<Campaign_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddCase(Case_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddCase(IBuilder<Case_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddCodeList(CodeList_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddCodeList(IBuilder<CodeList_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddCommSchedule(CommSchedule_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddCommSchedule(IBuilder<CommSchedule_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddCriteria(Criteria_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddCriteria(IBuilder<Criteria_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddCurrency(Currency_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddCurrency(IBuilder<Currency_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddDistributionAgreement(DistributionAgreement_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddDistributionAgreement(IBuilder<DistributionAgreement_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddFinancialStatement(FinancialStatement_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddFinancialStatement(IBuilder<FinancialStatement_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddFormInstance(FormInstance_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddFormInstance(IBuilder<FormInstance_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddGrouping(Grouping_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddGrouping(IBuilder<Grouping_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddHolding(Holding_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddHolding(IBuilder<Holding_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddInvestProduct(InvestProduct_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddInvestProduct(IBuilder<InvestProduct_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddKeyedValue(KeyedValue_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddKeyedValue(IBuilder<KeyedValue_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddOLifEExtension(OLifEExtension_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddParty(Party_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddParty(IBuilder<Party_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddPolicyProduct(PolicyProduct_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddPolicyProduct(IBuilder<PolicyProduct_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddScenario(Scenario_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddScenario(IBuilder<Scenario_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddSettlementInfo(SettlementInfo_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddSettlementInfo(IBuilder<SettlementInfo_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddSystemMessage(SystemMessage_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddSystemMessage(IBuilder<SystemMessage_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddUnderwritingGuidelines(UnderwritingGuidelines_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddUnderwritingGuidelines(IBuilder<UnderwritingGuidelines_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddRelation(Relation_Type entity)
        {
            AddItem(entity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder AddRelation(IBuilder<Relation_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }
        #endregion

        #region Restrictive
        public override Sans_BeginRelation_OLifEBuilder BeginRelation(string id)
        {
            _buildRelation = new Relation_Type { id = id };
            return this;
        }

        public override Sans_Relation_IsA_OLifEBuilder IsA(OLI_LU_REL relationRoleCode)
        {
            _buildRelation.RelationRoleCode = relationRoleCode.Clone();
            return this;
        }

        public override Sans_Relation_IsA_For_OLifEBuilder For(string originatingObjectID)
        {
            _buildRelation.OriginatingObjectID = originatingObjectID;
            return this;
        }

        public override Sans_Relation_Where_OLifEBuilder Where(string relatedObjectID)
        {
            _buildRelation.RelatedObjectID = relatedObjectID;
            return this;
        }

        public override Sans_Relation_Where_IsA_WithDescription_OLifEBuilder WithDescription(OLI_LU_RELDESC relationDescription)
        {
            if(_buildReciprocalRelation == null)
                _buildRelation.RelationDescription = relationDescription.Clone();
            else
                _buildReciprocalRelation.RelationDescription = relationDescription.Clone();

            return this;
        }

        public override Sans_Relation_Where_IsA_Of_OLifEBuilder Of(string originatingObjectID)
        {
            _buildRelation.OriginatingObjectID = originatingObjectID;
            return this;
        }

        public override Sans_Relation_Where_IsA_Of_AndReciprocal_OLifEBuilder AndReciprocal(string id, OLI_LU_REL relationRoleCode)
        {
            _buildReciprocalRelation = new Relation_Type {
                id = id,
                RelationRoleCode = relationRoleCode.Clone(),
                RelatedObjectID = _buildRelation.OriginatingObjectID,
                OriginatingObjectID = _buildRelation.RelatedObjectID,
            };

            return this;
        }

        public override Sans_Properties_OLifEBuilder EndRelation()
        {
            AddRelationEntity(_buildRelation.Clone());

            if(_buildReciprocalRelation != null)
                AddRelationEntity(_buildReciprocalRelation.Clone());

            _buildRelation = null;
            _buildReciprocalRelation = null;
            return this;
        }

        public override Sans_Properties_OLifEBuilder EndRelation(Relation_Type entity)
        {
            var clonedEntity = entity.Clone();
            ValidateRelationEntity(clonedEntity);

            clonedEntity.id = _buildRelation.id;
            clonedEntity.OriginatingObjectID = _buildRelation.OriginatingObjectID;
            clonedEntity.RelatedObjectID = _buildRelation.RelatedObjectID;
            clonedEntity.RelationRoleCode = _buildRelation.RelationRoleCode;
            clonedEntity.RelationDescription = _buildRelation.RelationDescription;

            _buildRelation = null;

            AddRelationEntity(clonedEntity);
            return this;
        }

        public override Sans_Properties_OLifEBuilder EndRelation(Relation_Type entity, Relation_Type reciprocalEntity)
        {
            // Relation
            var clonedEntity = entity.Clone();
            ValidateRelationEntity(clonedEntity);

            clonedEntity.id = _buildRelation.id;
            clonedEntity.OriginatingObjectID = _buildRelation.OriginatingObjectID;
            clonedEntity.RelatedObjectID = _buildRelation.RelatedObjectID;
            clonedEntity.RelationRoleCode = _buildRelation.RelationRoleCode;
            clonedEntity.RelationDescription = _buildRelation.RelationDescription;

            AddRelationEntity(clonedEntity);
            _buildRelation = null;

            // Reciprocal Relation
            var clonedReciprocalEntity = reciprocalEntity.Clone();
            ValidateRelationEntity(clonedReciprocalEntity);

            clonedReciprocalEntity.id = _buildReciprocalRelation.id;
            clonedReciprocalEntity.OriginatingObjectID = _buildReciprocalRelation.OriginatingObjectID;
            clonedReciprocalEntity.RelatedObjectID = _buildReciprocalRelation.RelatedObjectID;
            clonedReciprocalEntity.RelationRoleCode = _buildReciprocalRelation.RelationRoleCode;
            clonedReciprocalEntity.RelationDescription = _buildReciprocalRelation.RelationDescription;

            AddRelationEntity(clonedReciprocalEntity);
            _buildReciprocalRelation = null;

            return this;
        }
        #endregion

        private void AddItem<T>(EntityBase<T> entity)
        {
            _buildPropertiesActions.AddLast(n => n.Items.Add(entity));
        }

        private void ValidateRelationEntity(Relation_Type entity)
        {
            if (entity.ShouldSerializeid())
                throw new ArgumentException("You must not fill in the Relation_Type.id, use the fluent api to construct a proper relation.", "entity");

            if (entity.ShouldSerializeOriginatingObjectID() || entity.ShouldSerializeOriginatingObjectType())
                throw new ArgumentException("You must not fill in the Relation_Type.OriginatingObjectType, use the fluent api to construct a proper relation.", "entity");

            if (entity.ShouldSerializeRelatedObjectID() || entity.ShouldSerializeRelatedObjectType())
                throw new ArgumentException("You must not fill in the Relation_Type.RelatedObjectType, use the fluent api to construct a proper relation.", "entity");

            if (entity.ShouldSerializeRelationRoleCode())
                throw new ArgumentException("You must not fill in the Relation_Type.RelationRoleCode, use the fluent api to construct a proper relation.", "entity");

            if (entity.ShouldSerializeRelationDescription())
                throw new ArgumentException("You must not fill in the Relation_Type.RelationDescription, use the fluent api to construct a proper relation.", "entity");
        }

        private void AddRelationEntity(Relation_Type entity)
        {
            _buildRelationshipsActions.AddLast(n =>
            {
                var originatingObject = n.Items.OfType<IRelation>().Single(m => m.id == entity.OriginatingObjectID);

                OLI_LU_OBJECTTYPE temp = null;
                if (!_typeToOliLuObjectType.TryGetValue(originatingObject.GetType(), out temp))
                    throw new ArgumentException("This argument is not allowed to be related.", "originatingObjectID");

                entity.OriginatingObjectType = temp;

                if (!string.IsNullOrWhiteSpace(entity.RelatedObjectID))
                {
                    var relatedObject = n.Items.OfType<IRelation>().Single(m => m.id == entity.RelatedObjectID);

                    temp = null;
                    if (!_typeToOliLuObjectType.TryGetValue(relatedObject.GetType(), out temp))
                        throw new ArgumentException("This argument is not allowed to be related.", "originatingObjectID");

                    entity.RelatedObjectType = temp;
                }

                n.Items.Add(entity);
            });
        }
    }

    #region Restrictive Interfaces
    public interface BeginRelation_OLifEBuilder<TRemainder> { TRemainder BeginRelation(string id); }
    public interface Relation_IsA_OLifEBuilder<TRemainder> { TRemainder IsA(OLI_LU_REL relationRoleCode); }
    public interface Relation_For_OLifEBuilder<TRemainder> { TRemainder For(string originatingObjectID); }
    public interface Relation_Where_OLifEBuilder<TRemainder> { TRemainder Where(string relatedObjectID); }
    public interface Relation_WithDescription_OLifEBuilder<TRemainder> { TRemainder WithDescription(OLI_LU_RELDESC relationDescription); }
    public interface Relation_Of_OLifEBuilder<TRemainder> { TRemainder Of(string originatingObjectID); }
    public interface Relation_AndReciprocal_OLifEBuilder<TRemainder> { TRemainder AndReciprocal(string id, OLI_LU_REL relationRoleCode); }
    public interface EndRelation_OLifEBuilder<TRemainder> { TRemainder EndRelation(); }
    public interface EndRelationWithEntity_OLifEBuilder<TRemainder> { TRemainder EndRelation(Relation_Type entity); }
    public interface EndRelationWithEntityReciprocal_OLifEBuilder<TRemainder> { TRemainder EndRelation(Relation_Type entity, Relation_Type reciprocalEntity); }
    #endregion

    #region Non-restrictive Interfaces
    public interface Properties_OLifEBuilder<TRemainder>
    {
        TRemainder Version(string version);
        TRemainder AddActivity(Activity_Type entity);
        TRemainder AddActivity(IBuilder<Activity_Type> builder);
        TRemainder AddAuditEntry(AuditEntry_Type entity);
        TRemainder AddAuditEntry(IBuilder<AuditEntry_Type> builder);
        TRemainder AddBusinessProcessDef(BusinessProcessDef_Type entity);
        TRemainder AddBusinessProcessDef(IBuilder<BusinessProcessDef_Type> builder);
        TRemainder AddCampaign(Campaign_Type entity);
        TRemainder AddCampaign(IBuilder<Campaign_Type> builder);
        TRemainder AddCase(Case_Type entity);
        TRemainder AddCase(IBuilder<Case_Type> builder);
        TRemainder AddCodeList(CodeList_Type entity);
        TRemainder AddCodeList(IBuilder<CodeList_Type> builder);
        TRemainder AddCommSchedule(CommSchedule_Type entity);
        TRemainder AddCommSchedule(IBuilder<CommSchedule_Type> builder);
        TRemainder AddCriteria(Criteria_Type entity);
        TRemainder AddCriteria(IBuilder<Criteria_Type> builder);
        TRemainder AddCurrency(Currency_Type entity);
        TRemainder AddCurrency(IBuilder<Currency_Type> builder);
        TRemainder AddDistributionAgreement(DistributionAgreement_Type entity);
        TRemainder AddDistributionAgreement(IBuilder<DistributionAgreement_Type> builder);
        TRemainder AddFinancialStatement(FinancialStatement_Type entity);
        TRemainder AddFinancialStatement(IBuilder<FinancialStatement_Type> builder);
        TRemainder AddFormInstance(FormInstance_Type entity);
        TRemainder AddFormInstance(IBuilder<FormInstance_Type> builder);
        TRemainder AddGrouping(Grouping_Type entity);
        TRemainder AddGrouping(IBuilder<Grouping_Type> builder);
        TRemainder AddHolding(Holding_Type entity);
        TRemainder AddHolding(IBuilder<Holding_Type> builder);
        TRemainder AddInvestProduct(InvestProduct_Type entity);
        TRemainder AddInvestProduct(IBuilder<InvestProduct_Type> builder);
        TRemainder AddKeyedValue(KeyedValue_Type entity);
        TRemainder AddKeyedValue(IBuilder<KeyedValue_Type> builder);
        TRemainder AddOLifEExtension(OLifEExtension_Type entity);
        TRemainder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder);
        TRemainder AddParty(Party_Type entity);
        TRemainder AddParty(IBuilder<Party_Type> builder);
        TRemainder AddPolicyProduct(PolicyProduct_Type entity);
        TRemainder AddPolicyProduct(IBuilder<PolicyProduct_Type> builder);
        TRemainder AddRelation(Relation_Type entity);
        TRemainder AddRelation(IBuilder<Relation_Type> builder);
        TRemainder AddScenario(Scenario_Type entity);
        TRemainder AddScenario(IBuilder<Scenario_Type> builder);
        TRemainder AddSettlementInfo(SettlementInfo_Type entity);
        TRemainder AddSettlementInfo(IBuilder<SettlementInfo_Type> builder);
        TRemainder AddSystemMessage(SystemMessage_Type entity);
        TRemainder AddSystemMessage(IBuilder<SystemMessage_Type> builder);
        TRemainder AddUnderwritingGuidelines(UnderwritingGuidelines_Type entity);
        TRemainder AddUnderwritingGuidelines(IBuilder<UnderwritingGuidelines_Type> builder);
    }
    #endregion

    // zero reductions
    public interface Sans_Properties_OLifEBuilder :
        IBuilder<OLifE_Type>,
        Properties_OLifEBuilder<Sans_Properties_OLifEBuilder>,
        BeginRelation_OLifEBuilder<Sans_BeginRelation_OLifEBuilder>
    { }

    // level one reductions
    public interface Sans_BeginRelation_OLifEBuilder :
        Relation_IsA_OLifEBuilder<Sans_Relation_IsA_OLifEBuilder>,
        Relation_Where_OLifEBuilder<Sans_Relation_Where_OLifEBuilder>
        { }

    // level two reductions
    public interface Sans_Relation_IsA_OLifEBuilder :
        Relation_For_OLifEBuilder<Sans_Relation_IsA_For_OLifEBuilder>
    { }

    public interface Sans_Relation_Where_OLifEBuilder :
        Relation_IsA_OLifEBuilder<Sans_Relation_Where_IsA_OLifEBuilder>
    { }

    // level three reductions
    public interface Sans_Relation_IsA_For_OLifEBuilder :
        EndRelation_OLifEBuilder<Sans_Properties_OLifEBuilder>,
        EndRelationWithEntity_OLifEBuilder<Sans_Properties_OLifEBuilder>
    { }

    public interface Sans_Relation_Where_IsA_OLifEBuilder :
        Relation_WithDescription_OLifEBuilder<Sans_Relation_Where_IsA_WithDescription_OLifEBuilder>,
        Relation_Of_OLifEBuilder<Sans_Relation_Where_IsA_Of_OLifEBuilder>
    { }

    // level four reductions
    public interface Sans_Relation_Where_IsA_WithDescription_OLifEBuilder :
        Relation_Of_OLifEBuilder<Sans_Relation_Where_IsA_Of_OLifEBuilder>
    { }

    public interface Sans_Relation_Where_IsA_Of_OLifEBuilder :
        Relation_AndReciprocal_OLifEBuilder<Sans_Relation_Where_IsA_Of_AndReciprocal_OLifEBuilder>,
        EndRelation_OLifEBuilder<Sans_Properties_OLifEBuilder>,
        EndRelationWithEntity_OLifEBuilder<Sans_Properties_OLifEBuilder>
    { }

    // level five reductions
    public interface Sans_Relation_Where_IsA_Of_AndReciprocal_OLifEBuilder :
        Relation_WithDescription_OLifEBuilder<Sans_Relation_Where_IsA_Of_AndReciprocal_WithDescription_OLifEBuilder>,
        EndRelation_OLifEBuilder<Sans_Properties_OLifEBuilder>,
        EndRelationWithEntityReciprocal_OLifEBuilder<Sans_Properties_OLifEBuilder>
    { }

    // level six reductions
    public interface Sans_Relation_Where_IsA_Of_AndReciprocal_WithDescription_OLifEBuilder :
        EndRelation_OLifEBuilder<Sans_Properties_OLifEBuilder>,
        EndRelationWithEntityReciprocal_OLifEBuilder<Sans_Properties_OLifEBuilder>
    { }



}
