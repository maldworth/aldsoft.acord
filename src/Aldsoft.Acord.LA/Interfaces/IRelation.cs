namespace Aldsoft.Acord.LA
{
    /// <summary>
    /// Interface for top level objects that can have a relationship
    /// </summary>
    public interface IRelation
    {
        string id { get; set; }
    }

    #region Top level class types that can have relationships
    public partial class Activity_Type : IRelation { }
    ////public partial class AuditEntry_Type : IRelation { }
    ////public partial class BusinessProcessDef_Type : IRelation { }
    public partial class Campaign_Type : IRelation { }
    public partial class Case_Type : IRelation { }
    ////public partial class CodeList_Type : IRelation { }
    //public partial class CommSchedule_Type : IRelation { }
    //public partial class Criteria_Type : IRelation { }
    //public partial class Currency_Type : IRelation { }
    public partial class DistributionAgreement_Type : IRelation { }
    public partial class FinancialStatement_Type : IRelation { }
    //public partial class FormInstance_Type : IRelation { }
    public partial class Grouping_Type : IRelation { }
    public partial class Holding_Type : IRelation { }
    public partial class InvestProduct_Type : IRelation { }
    //public partial class KeyedValue_Type : IRelation { }
    //public partial class OLifEExtension_Type : IRelation { }
    public partial class Party_Type : IRelation { }
    public partial class PolicyProduct_Type : IRelation { }
    //public partial class Relation_Type : IRelation { }
    public partial class Scenario_Type : IRelation { }
    //public partial class SettlementInfo_Type : IRelation { }
    //public partial class SystemMessage_Type : IRelation { }
    //public partial class UnderwritingGuidelines_Type : IRelation { }
    #endregion
}
