namespace Aldsoft.Acord.LA.Builders
{
    using LA;
    using System;
    using System.Collections.Generic;

    public abstract class UserAuthRequestBuilderBase : BuilderBase<UserAuthRequest_Type>,
        Properties_UserAuthRequestBuilder<Sans_Properties_UserAuthRequestBuilder>
    {
        protected UserAuthRequestBuilderBase() : base() { }
        protected UserAuthRequestBuilderBase(UserAuthRequest_Type baseEntity) : base(baseEntity) { }

        // Restricted
        public abstract Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder UserAuthentication(UserAuthentication_Type userAuthentication);
        public abstract Sans_UserLoginName_UserAuthRequestBuilder UserLoginName(string userLoginName);
        public abstract Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder UserPswd(UserPswd_Type userPswd);
        public abstract Sans_RestrictedOptions UserSessionKey(string userSessionKey);

        // Non-restricted
        public abstract Sans_Properties_UserAuthRequestBuilder AddProxyVendor(ProxyVendor_Type proxyVendor);
        public abstract Sans_Properties_UserAuthRequestBuilder AddProxyVendor(IBuilder<ProxyVendor_Type> builder);
        public abstract Sans_Properties_UserAuthRequestBuilder AddOLifEExtension(OLifEExtension_Type oLifeExtension);
        public abstract Sans_Properties_UserAuthRequestBuilder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder);
        public abstract Sans_Properties_UserAuthRequestBuilder UserDate(DateTime userDate);
        public abstract Sans_Properties_UserAuthRequestBuilder UserDomain(string userDomain);
        public abstract Sans_Properties_UserAuthRequestBuilder UserTime(DateTime userTime);
        public abstract Sans_Properties_UserAuthRequestBuilder VendorApp(VendorApp_Type vendorApp);
    }

    public abstract class UserAuthRequestBuilder_Sans_Properties_UserAuthRequestBuilder : UserAuthRequestBuilderBase,
        Sans_Properties_UserAuthRequestBuilder
    {
        protected UserAuthRequestBuilder_Sans_Properties_UserAuthRequestBuilder() : base() { }
        protected UserAuthRequestBuilder_Sans_Properties_UserAuthRequestBuilder(UserAuthRequest_Type baseEntity) : base(baseEntity) { }
    }

    public abstract class UserAuthRequestBuilder_Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder : UserAuthRequestBuilder_Sans_Properties_UserAuthRequestBuilder,
        Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder
    {
        protected UserAuthRequestBuilder_Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder() : base() { }
        protected UserAuthRequestBuilder_Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder(UserAuthRequest_Type baseEntity) : base(baseEntity) { }

        Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder>.AddProxyVendor(ProxyVendor_Type proxyVendor) { return (Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder)AddProxyVendor(proxyVendor); }
        Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder>.AddProxyVendor(IBuilder<ProxyVendor_Type> builder) { return (Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder)AddProxyVendor(builder); }
        Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder>.AddOLifEExtension(OLifEExtension_Type oLifeExtension) { return (Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder)AddOLifEExtension(oLifeExtension); }
        Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder>.AddOLifEExtension(IBuilder<OLifEExtension_Type> builder) { return (Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder)AddOLifEExtension(builder); }
        Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder>.UserDate(DateTime userDate) { return (Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder)UserDate(userDate); }
        Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder>.UserDomain(string userDomain) { return (Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder)UserDomain(userDomain); }
        Sans_RestrictedOptions UserLoginName_UserAuthRequestBuilder<Sans_RestrictedOptions>.UserLoginName(string userLoginName) { return (Sans_RestrictedOptions)UserLoginName(userLoginName); }
        Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder>.UserTime(DateTime userTime) { return (Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder)UserTime(userTime); }
        Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder>.VendorApp(VendorApp_Type vendorApp) { return (Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder)VendorApp(vendorApp); }
    }

    public abstract class UserAuthRequestBuilder_Sans_UserLoginName_UserAuthRequestBuilder : UserAuthRequestBuilder_Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder,
        Sans_UserLoginName_UserAuthRequestBuilder
    {
        protected UserAuthRequestBuilder_Sans_UserLoginName_UserAuthRequestBuilder() : base() { }
        protected UserAuthRequestBuilder_Sans_UserLoginName_UserAuthRequestBuilder(UserAuthRequest_Type baseEntity) : base(baseEntity) { }

        Sans_UserLoginName_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserLoginName_UserAuthRequestBuilder>.AddProxyVendor(ProxyVendor_Type proxyVendor) { return (Sans_UserLoginName_UserAuthRequestBuilder)AddProxyVendor(proxyVendor); }
        Sans_UserLoginName_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserLoginName_UserAuthRequestBuilder>.AddProxyVendor(IBuilder<ProxyVendor_Type> builder) { return (Sans_UserLoginName_UserAuthRequestBuilder)AddProxyVendor(builder); }
        Sans_UserLoginName_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserLoginName_UserAuthRequestBuilder>.AddOLifEExtension(OLifEExtension_Type oLifeExtension) { return (Sans_UserLoginName_UserAuthRequestBuilder)AddOLifEExtension(oLifeExtension); }
        Sans_UserLoginName_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserLoginName_UserAuthRequestBuilder>.AddOLifEExtension(IBuilder<OLifEExtension_Type> builder) { return (Sans_UserLoginName_UserAuthRequestBuilder)AddOLifEExtension(builder); }
        Sans_RestrictedOptions UserAuthentication_UserAuthRequestBuilder<Sans_RestrictedOptions>.UserAuthentication(UserAuthentication_Type userAuthentication) { return (Sans_RestrictedOptions)UserAuthentication(userAuthentication); }
        Sans_UserLoginName_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserLoginName_UserAuthRequestBuilder>.UserDate(DateTime userDate) { return (Sans_UserLoginName_UserAuthRequestBuilder)UserDate(userDate); }
        Sans_UserLoginName_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserLoginName_UserAuthRequestBuilder>.UserDomain(string userDomain) { return (Sans_UserLoginName_UserAuthRequestBuilder)UserDomain(userDomain); }
        Sans_RestrictedOptions UserPswd_UserAuthRequestBuilder<Sans_RestrictedOptions>.UserPswd(UserPswd_Type userPswd) { return (Sans_RestrictedOptions)UserPswd(userPswd); }
        Sans_UserLoginName_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserLoginName_UserAuthRequestBuilder>.UserTime(DateTime userTime) { return (Sans_UserLoginName_UserAuthRequestBuilder)UserTime(userTime); }
        Sans_UserLoginName_UserAuthRequestBuilder Properties_UserAuthRequestBuilder<Sans_UserLoginName_UserAuthRequestBuilder>.VendorApp(VendorApp_Type vendorApp) { return (Sans_UserLoginName_UserAuthRequestBuilder)VendorApp(vendorApp); }
    }

    public abstract class UserAuthRequestBuilder_Sans_RestrictedOptions : UserAuthRequestBuilder_Sans_UserLoginName_UserAuthRequestBuilder,
        Sans_RestrictedOptions
    {
        protected UserAuthRequestBuilder_Sans_RestrictedOptions() : base() { }
        protected UserAuthRequestBuilder_Sans_RestrictedOptions(UserAuthRequest_Type baseEntity) : base(baseEntity) { }

        Sans_RestrictedOptions Properties_UserAuthRequestBuilder<Sans_RestrictedOptions>.AddProxyVendor(ProxyVendor_Type proxyVendor) { return (Sans_RestrictedOptions)AddProxyVendor(proxyVendor); }
        Sans_RestrictedOptions Properties_UserAuthRequestBuilder<Sans_RestrictedOptions>.AddProxyVendor(IBuilder<ProxyVendor_Type> builder) { return (Sans_RestrictedOptions)AddProxyVendor(builder); }
        Sans_RestrictedOptions Properties_UserAuthRequestBuilder<Sans_RestrictedOptions>.AddOLifEExtension(OLifEExtension_Type oLifeExtension) { return (Sans_RestrictedOptions)AddOLifEExtension(oLifeExtension); }
        Sans_RestrictedOptions Properties_UserAuthRequestBuilder<Sans_RestrictedOptions>.AddOLifEExtension(IBuilder<OLifEExtension_Type> builder) { return (Sans_RestrictedOptions)AddOLifEExtension(builder); }
        Sans_RestrictedOptions Properties_UserAuthRequestBuilder<Sans_RestrictedOptions>.UserDate(DateTime userDate) { return (Sans_RestrictedOptions)UserDate(userDate); }
        Sans_RestrictedOptions Properties_UserAuthRequestBuilder<Sans_RestrictedOptions>.UserDomain(string userDomain) { return (Sans_RestrictedOptions)UserDomain(userDomain); }
        Sans_RestrictedOptions Properties_UserAuthRequestBuilder<Sans_RestrictedOptions>.UserTime(DateTime userTime) { return (Sans_RestrictedOptions)UserTime(userTime); }
        Sans_RestrictedOptions Properties_UserAuthRequestBuilder<Sans_RestrictedOptions>.VendorApp(VendorApp_Type vendorApp) { return (Sans_RestrictedOptions)VendorApp(vendorApp); }
    }

    public class UserAuthRequestBuilder : UserAuthRequestBuilder_Sans_RestrictedOptions
    {
        public static UserAuthRequestBuilder CreateBuilder() { return new UserAuthRequestBuilder(); }
        public static UserAuthRequestBuilder CreateBuilder(UserAuthRequest_Type userAuthRequest) { return new UserAuthRequestBuilder(userAuthRequest); }

        private readonly ItemsChoiceType2[] _xmlSequenceOrder = {
            ItemsChoiceType2.UserSessionKey,
            ItemsChoiceType2.UserLoginName,
            ItemsChoiceType2.UserPswd,
            ItemsChoiceType2.UserAuthentication
        };

        private readonly Dictionary<ItemsChoiceType2, LinkedList<Action<List<object>>>> _buildActions = new Dictionary<ItemsChoiceType2, LinkedList<Action<List<object>>>>();

        protected UserAuthRequestBuilder()
            : base()
        {
            // Initialize our Build Actions
            foreach (var type in _xmlSequenceOrder)
            {
                _buildActions[type] = new LinkedList<Action<List<object>>>();
            }
        }

        protected UserAuthRequestBuilder(UserAuthRequest_Type userAuthRequest)
            : base(userAuthRequest)
        {
        }

        protected override void ValidateBaseObject(UserAuthRequest_Type baseEntity)
        {
            if (baseEntity.Items == null || baseEntity.Items.Length != 0)
                throw new ArgumentException("The UserAuthRequest_Type.Items array should be empty. This builder will help handle the ACORD spec logic with setting this property.", "baseEntity");

            if (baseEntity.ItemsElementName == null || baseEntity.ItemsElementName.Length != 0)
                throw new ArgumentException("The UserAuthRequest_Type.ItemsElementName array should be empty. This builder will help handle the ACORD spec logic with setting this property.", "baseEntity");
        }

        public override UserAuthRequest_Type Build()
        {
            var resultEntity = base.Build();

            BuildItemsProperty(resultEntity);

            return resultEntity;
        }

        public override UserAuthRequest_Type Build(UserAuthRequest_Type baseEntity)
        {
            var resultEntity = base.Build(baseEntity);

            BuildItemsProperty(resultEntity);

            return resultEntity;
        }

        private void BuildItemsProperty(UserAuthRequest_Type entity)
        {
            // Ensures proper order of Items as per section 7.568
            var items = new List<object>();
            var itemsElementName = new List<ItemsChoiceType2>();
            foreach (var type in _xmlSequenceOrder)
            {
                LinkedListNode<Action<List<object>>> currentNode = _buildActions[type].First;
                while (currentNode != null)
                {
                    currentNode.Value(items);
                    itemsElementName.Add(type);
                    currentNode = currentNode.Next;
                }
            }

            entity.Items = items.ToArray();
            entity.ItemsElementName = itemsElementName.ToArray();
        }

        public override Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder UserAuthentication(UserAuthentication_Type userAuthentication)
        {
            _buildActions[ItemsChoiceType2.UserAuthentication].AddLast(n => n.Add(userAuthentication));
            return this;
        }

        public override Sans_UserLoginName_UserAuthRequestBuilder UserLoginName(string userLoginName)
        {
            _buildActions[ItemsChoiceType2.UserLoginName].AddLast(n => n.Add(userLoginName));
            return this;
        }

        public override Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder UserPswd(UserPswd_Type userPswd)
        {
            _buildActions[ItemsChoiceType2.UserPswd].AddLast(n => n.Add(userPswd));
            return this;
        }

        public override Sans_RestrictedOptions UserSessionKey(string userSessionKey)
        {
            _buildActions[ItemsChoiceType2.UserSessionKey].AddLast(n => n.Add(userSessionKey));
            return this;
        }

        public override Sans_Properties_UserAuthRequestBuilder AddProxyVendor(ProxyVendor_Type proxyVendor)
        {
            _buildPropertiesActions.AddLast(n => n.ProxyVendor.Add(proxyVendor));
            return this;
        }

        public override Sans_Properties_UserAuthRequestBuilder AddProxyVendor(IBuilder<ProxyVendor_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.ProxyVendor.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_UserAuthRequestBuilder AddOLifEExtension(OLifEExtension_Type oLifeExtension)
        {
            _buildPropertiesActions.AddLast(n => n.OLifEExtension.Add(oLifeExtension));
            return this;
        }

        public override Sans_Properties_UserAuthRequestBuilder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.OLifEExtension.Add(builder.Build()));
            return this;
        }

        public override Sans_Properties_UserAuthRequestBuilder UserDate(DateTime userDate)
        {
            _buildPropertiesActions.AddLast(n => n.UserDate = userDate);
            return this;
        }

        public override Sans_Properties_UserAuthRequestBuilder UserDomain(string userDomain)
        {
            _buildPropertiesActions.AddLast(n => n.UserDomain = userDomain);
            return this;
        }

        public override Sans_Properties_UserAuthRequestBuilder UserTime(DateTime userTime)
        {
            _buildPropertiesActions.AddLast(n => n.UserTime = userTime);
            return this;
        }

        public override Sans_Properties_UserAuthRequestBuilder VendorApp(VendorApp_Type vendorApp)
        {
            _buildPropertiesActions.AddLast(n => n.VendorApp = vendorApp);
            return this;
        }
    }

    #region Restrictive Interfaces
    public interface UserAuthentication_UserAuthRequestBuilder<TRemainder> { TRemainder UserAuthentication(UserAuthentication_Type userAuthentication); }
    public interface UserLoginName_UserAuthRequestBuilder<TRemainder> { TRemainder UserLoginName(string userLoginName); }
    public interface UserPswd_UserAuthRequestBuilder<TRemainder> { TRemainder UserPswd(UserPswd_Type userPswd); }
    public interface UserSessionKey_UserAuthRequestBuilder<TRemainder> { TRemainder UserSessionKey(string userSessionKey); }
    #endregion

    #region Non-restrictive Interfaces
    public interface Properties_UserAuthRequestBuilder<TRemainder>
    {
        TRemainder UserDomain(string userDomain);
        TRemainder UserDate(DateTime userDate);
        TRemainder UserTime(DateTime userTime);
        TRemainder VendorApp(VendorApp_Type vendorApp);
        TRemainder AddProxyVendor(ProxyVendor_Type proxyVendor);
        TRemainder AddProxyVendor(IBuilder<ProxyVendor_Type> builder);
        TRemainder AddOLifEExtension(OLifEExtension_Type oLifeExtension);
        TRemainder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder);
    }
    #endregion

    // level zero reductions
    public interface Sans_Properties_UserAuthRequestBuilder :
        IBuilder<UserAuthRequest_Type>,
        Properties_UserAuthRequestBuilder<Sans_Properties_UserAuthRequestBuilder>,
        UserAuthentication_UserAuthRequestBuilder<Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder>,
        UserLoginName_UserAuthRequestBuilder<Sans_UserLoginName_UserAuthRequestBuilder>,
        UserPswd_UserAuthRequestBuilder<Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder>,
        UserSessionKey_UserAuthRequestBuilder<Sans_RestrictedOptions>
    { }

    // level one reductions
    // if we chose UserAuthentication or UserPswd (mutually exclusive) then we only hace the Login Name to choose from
    public interface Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder :
        IBuilder<UserAuthRequest_Type>,
        Properties_UserAuthRequestBuilder<Sans_UserAuthentication_Or_UserPswd_UserAuthRequestBuilder>,
        UserLoginName_UserAuthRequestBuilder<Sans_RestrictedOptions>
    { }

    public interface Sans_UserLoginName_UserAuthRequestBuilder :
        IBuilder<UserAuthRequest_Type>,
        Properties_UserAuthRequestBuilder<Sans_UserLoginName_UserAuthRequestBuilder>,
        UserAuthentication_UserAuthRequestBuilder<Sans_RestrictedOptions>,
        UserPswd_UserAuthRequestBuilder<Sans_RestrictedOptions>
    { }

    // They cannot choose any more of the restricted options
    public interface Sans_RestrictedOptions :
        IBuilder<UserAuthRequest_Type>,
        Properties_UserAuthRequestBuilder<Sans_RestrictedOptions>
    { }
}
