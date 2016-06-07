namespace Aldsoft.Acord.LA
{
    using Builders;

    public partial class TXLife_Type
    {
        public static TXLifeBuilder CreateBuilder() { return TXLifeBuilder.CreateBuilder(); }
        //public static TXLifeBuilder CreateBuilder(TXLife_Type baseEntity) { return TXLifeBuilder.CreateBuilder(baseEntity); }
    }

    public partial class UserAuthRequest_Type
    {
        public static UserAuthRequestBuilder CreateBuilder() { return UserAuthRequestBuilder.CreateBuilder(); }
        public static UserAuthRequestBuilder CreateBuilder(UserAuthRequest_Type baseEntity) { return UserAuthRequestBuilder.CreateBuilder(baseEntity); }
    }

    public partial class OLifE_Type
    {
        public static OLifEBuilder CreateBuilder() { return OLifEBuilder.CreateBuilder(); }
        public static OLifEBuilder CreateBuilder(OLifE_Type baseEntity) { return OLifEBuilder.CreateBuilder(baseEntity); }
    }

    public partial class Party_Type
    {
        public static PartyBuilder CreateBuilder() { return PartyBuilder.CreateBuilder(); }
        public static PartyBuilder CreateBuilder(Party_Type baseEntity) { return PartyBuilder.CreateBuilder(baseEntity); }
    }

    public partial class Life_Type
    {
        public static LifeBuilder CreateBuilder() { return LifeBuilder.CreateBuilder(); }
        public static LifeBuilder CreateBuilder(Life_Type baseEntity) { return LifeBuilder.CreateBuilder(baseEntity); }
    }

    public partial class Policy_Type
    {
        public static PolicyBuilder CreateBuilder() { return PolicyBuilder.CreateBuilder(); }
        public static PolicyBuilder CreateBuilder(Policy_Type baseEntity) { return PolicyBuilder.CreateBuilder(baseEntity); }
    }
}
