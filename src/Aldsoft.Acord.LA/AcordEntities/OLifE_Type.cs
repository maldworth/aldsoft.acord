namespace Aldsoft.Acord.LA
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class OLifE_Type
    {
        #region Get
        public IEnumerable<Activity_Type> GetActivity()
        {
            return Items.OfType<Activity_Type>();
        }

        public IEnumerable<AuditEntry_Type> GetAuditEntry()
        {
            return Items.OfType<AuditEntry_Type>();
        }

        public IEnumerable<BusinessProcessDef_Type> GetBusinessProcessDef()
        {
            return Items.OfType<BusinessProcessDef_Type>();
        }

        public IEnumerable<Campaign_Type> GetCampaign()
        {
            return Items.OfType<Campaign_Type>();
        }

        public IEnumerable<Case_Type> GetCase()
        {
            return Items.OfType<Case_Type>();
        }

        public IEnumerable<CodeList_Type> GetCodeList()
        {
            return Items.OfType<CodeList_Type>();
        }

        public IEnumerable<CommSchedule_Type> GetCommSchedule()
        {
            return Items.OfType<CommSchedule_Type>();
        }

        public IEnumerable<Criteria_Type> GetCriteria()
        {
            return Items.OfType<Criteria_Type>();
        }

        public IEnumerable<Currency_Type> GetCurrency()
        {
            return Items.OfType<Currency_Type>();
        }

        public IEnumerable<DistributionAgreement_Type> GetDistributionAgreement()
        {
            return Items.OfType<DistributionAgreement_Type>();
        }

        public IEnumerable<FinancialStatement_Type> GetFinancialStatement()
        {
            return Items.OfType<FinancialStatement_Type>();
        }

        public IEnumerable<FormInstance_Type> GetFormInstance()
        {
            return Items.OfType<FormInstance_Type>();
        }

        public IEnumerable<Grouping_Type> GetGrouping()
        {
            return Items.OfType<Grouping_Type>();
        }

        public IEnumerable<Holding_Type> GetHolding()
        {
            return Items.OfType<Holding_Type>();
        }

        public IEnumerable<InvestProduct_Type> GetInvestProduct()
        {
            return Items.OfType<InvestProduct_Type>();
        }

        public IEnumerable<KeyedValue_Type> GetKeyedValue()
        {
            return Items.OfType<KeyedValue_Type>();
        }

        public IEnumerable<OLifEExtension_Type> GetOLifEExtension()
        {
            return Items.OfType<OLifEExtension_Type>();
        }

        public IEnumerable<Party_Type> GetParty()
        {
            return Items.OfType<Party_Type>();
        }

        public IEnumerable<PolicyProduct_Type> GetPolicyProduct()
        {
            return Items.OfType<PolicyProduct_Type>();
        }

        public IEnumerable<Relation_Type> GetRelation()
        {
            return Items.OfType<Relation_Type>();
        }

        public IEnumerable<Scenario_Type> GetScenario()
        {
            return Items.OfType<Scenario_Type>();
        }

        public IEnumerable<SettlementInfo_Type> GetSettlementInfo()
        {
            return Items.OfType<SettlementInfo_Type>();
        }

        public IEnumerable<SystemMessage_Type> GetSystemMessage()
        {
            return Items.OfType<SystemMessage_Type>();
        }

        public IEnumerable<UnderwritingGuidelines_Type> GetUnderwritingGuidelines()
        {
            return Items.OfType<UnderwritingGuidelines_Type>();
        }
        #endregion

        #region AddItem
        public void AddItem(Activity_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(AuditEntry_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(BusinessProcessDef_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(Campaign_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(Case_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(CodeList_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(CommSchedule_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(Criteria_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(Currency_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(DistributionAgreement_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(FinancialStatement_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(FormInstance_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(Grouping_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(Holding_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(InvestProduct_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(KeyedValue_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(OLifEExtension_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(Party_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(PolicyProduct_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(Relation_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(Scenario_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(SettlementInfo_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(SystemMessage_Type item)
        {
            Items.Add(item);
        }

        public void AddItem(UnderwritingGuidelines_Type item)
        {
            Items.Add(item);
        }
        #endregion
    }
}
