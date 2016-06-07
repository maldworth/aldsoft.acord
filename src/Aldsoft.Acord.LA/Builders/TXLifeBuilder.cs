namespace Aldsoft.Acord.LA.Builders
{
    using LA;
    using System;
    using System.Collections.Generic;

    public abstract class TXLifeBuilderBase : BuilderBase<TXLife_Type>,
        Properties_TXLifeBuilder<Sans_Properties_TXLifeBuilder>
    {
        protected TXLifeBuilderBase() : base() { }
        //protected TXLifeBuilderBase(TXLife_Type baseEntity) : base(baseEntity) { }

        // Non-restricted
        public abstract Sans_Properties_TXLifeBuilder Version(string version);
        public abstract Sans_Properties_TXLifeBuilder AddOLifEExtension(OLifEExtension_Type oLifeExtension);
        public abstract Sans_Properties_TXLifeBuilder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder);

        // Restricted
        public abstract Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder AddTXLifeNotify(TXLifeNotify_Type notify);
        public abstract Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder AddTXLifeNotify(IBuilder<TXLifeNotify_Type> builder);
        public abstract Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder AddTXLifeRequest(TXLifeRequest_Type request);
        public abstract Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder AddTXLifeRequest(IBuilder<TXLifeRequest_Type> builder);
        public abstract Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder AddTXLifeResponse(TXLifeResponse_Type response);
        public abstract Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder AddTXLifeResponse(IBuilder<TXLifeResponse_Type> builder);
        public abstract Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder AddUserAuthRequest(UserAuthRequest_Type request);
        public abstract Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder AddUserAuthRequest(IBuilder<UserAuthRequest_Type> builder);
        public abstract Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder AddUserAuthResponse(UserAuthResponse_Type response);
        public abstract Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder AddUserAuthResponse(IBuilder<UserAuthResponse_Type> builder);
    }

    public abstract class TXLifeBuilder_Sans_Properties_TXLifeBuilder : TXLifeBuilderBase,
        Sans_Properties_TXLifeBuilder
    {
        protected TXLifeBuilder_Sans_Properties_TXLifeBuilder() : base() { }
        //protected TXLifeBuilder_Sans_Properties_TXLifeBuilder(TXLife_Type baseEntity) : base(baseEntity) { }
    }

    public abstract class TXLifeBuilder_Sans_TXLifeResponse_UserAuthResponse : TXLifeBuilder_Sans_Properties_TXLifeBuilder,
        Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder
    {
        protected TXLifeBuilder_Sans_TXLifeResponse_UserAuthResponse() : base() { }
        //protected TXLifeBuilder_Sans_TXLifeResponse_UserAuthResponse(TXLife_Type baseEntity) : base(baseEntity) { }

        Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder Properties_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder>.AddOLifEExtension(IBuilder<OLifEExtension_Type> builder) { return (Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder)AddOLifEExtension(builder); }
        Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder Properties_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder>.AddOLifEExtension(OLifEExtension_Type oLifeExtension) { return (Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder)AddOLifEExtension(oLifeExtension); }
        Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder Properties_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder>.Version(string version) { return (Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder)Version(version); }
    }

    public abstract class TXLifeBuilder_Sans_TXLifeRequest_UserAuthRequest : TXLifeBuilder_Sans_TXLifeResponse_UserAuthResponse,
        Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder
    {
        protected TXLifeBuilder_Sans_TXLifeRequest_UserAuthRequest() : base() { }
        //protected TXLifeBuilder_Sans_TXLifeRequest_UserAuthRequest(TXLife_Type baseEntity) : base(baseEntity) { }

        Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder Properties_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder>.AddOLifEExtension(IBuilder<OLifEExtension_Type> builder) { return (Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder)AddOLifEExtension(builder); }
        Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder Properties_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder>.AddOLifEExtension(OLifEExtension_Type oLifeExtension) { return (Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder)AddOLifEExtension(oLifeExtension); }
        Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder Properties_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder>.Version(string version) { return (Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder)Version(version); }
    }

    public abstract class TXLifeBuilder_Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest : TXLifeBuilder_Sans_TXLifeRequest_UserAuthRequest,
        Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder
    {
        protected TXLifeBuilder_Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest() : base() { }
        //protected TXLifeBuilder_Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest(TXLife_Type baseEntity) : base(baseEntity) { }

        Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder Properties_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder>.AddOLifEExtension(IBuilder<OLifEExtension_Type> builder) { return (Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder)AddOLifEExtension(builder); }
        Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder Properties_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder>.AddOLifEExtension(OLifEExtension_Type oLifeExtension) { return (Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder)AddOLifEExtension(oLifeExtension); }
        Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder TXLifeRequest_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder>.AddTXLifeRequest(IBuilder<TXLifeRequest_Type> builder) { return (Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder)AddTXLifeRequest(builder); }
        Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder TXLifeRequest_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder>.AddTXLifeRequest(TXLifeRequest_Type request) { return (Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder)AddTXLifeRequest(request); }
        Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder Properties_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder>.Version(string version) { return (Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder)Version(version); }
    }

    public abstract class TXLifeBuilder_Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse : TXLifeBuilder_Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest,
        Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder
    {
        protected TXLifeBuilder_Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse() : base() { }
        //protected TXLifeBuilder_Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse(TXLife_Type baseEntity) : base(baseEntity) { }

        Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder Properties_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder>.AddOLifEExtension(IBuilder<OLifEExtension_Type> builder) { return (Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder)AddOLifEExtension(builder); }
        Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder Properties_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder>.AddOLifEExtension(OLifEExtension_Type oLifeExtension) { return (Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder)AddOLifEExtension(oLifeExtension); }
        Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder TXLifeResponse_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder>.AddTXLifeNotify(IBuilder<TXLifeNotify_Type> builder) { return (Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder)AddTXLifeNotify(builder); }
        Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder TXLifeResponse_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder>.AddTXLifeNotify(TXLifeNotify_Type notify) { return (Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder)AddTXLifeNotify(notify); }
        Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder TXLifeResponse_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder>.AddTXLifeResponse(IBuilder<TXLifeResponse_Type> builder) { return (Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder)AddTXLifeResponse(builder); }
        Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder TXLifeResponse_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder>.AddTXLifeResponse(TXLifeResponse_Type response) { return (Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder)AddTXLifeResponse(response); }
        Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder Properties_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder>.Version(string version) { return (Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder)Version(version); }
    }

    public class TXLifeBuilder : TXLifeBuilder_Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse
    {
        public static TXLifeBuilder CreateBuilder() { return new TXLifeBuilder(); }
        //public static TXLifeBuilder CreateBuilder(TXLife_Type txLife) { return new TXLifeBuilder(txLife); }

        private bool _isVersionSet = false;

        private readonly Type[] _xmlSequenceOrder = {
            typeof(UserAuthRequest_Type),
            typeof(UserAuthResponse_Type),
            typeof(TXLifeRequest_Type),
            typeof(TXLifeResponse_Type),
            typeof(TXLifeNotify_Type),
            typeof(OLifEExtension_Type)
        };

        private readonly Dictionary<Type, LinkedList<Action<TXLife_Type>>> _buildActions = new Dictionary<Type, LinkedList<Action<TXLife_Type>>>();

        private TXLifeBuilder()
            : base()
        {
            foreach (var type in _xmlSequenceOrder)
            {
                _buildActions[type] = new LinkedList<Action<TXLife_Type>>();
            }
        }

        //private TXLifeBuilder(TXLife_Type baseEntity) : base(baseEntity) { }

        protected override void ValidateBaseObject(TXLife_Type baseEntity)
        {
            if (baseEntity.ShouldSerializeItems())
                throw new ArgumentException("The TXLife_Type.Items collection should be empty. This builder will help handle the ACORD spec logic with setting this property.", "baseEntity");
        }

        protected override void ValidateBuilder()
        {
            if(_isVersionSet == false)
                throw new InvalidOperationException("You cannot build the TXLife_Type entity without first setting the Version.");
        }

        public override TXLife_Type Build()
        {
            var resultEntity = base.Build();

            BuildItemsProperty(resultEntity);

            return resultEntity;
        }

        public override TXLife_Type Build(TXLife_Type baseEntity)
        {
            var resultEntity = base.Build(baseEntity);

            BuildItemsProperty(resultEntity);

            return resultEntity;
        }

        private void BuildItemsProperty(TXLife_Type entity)
        {
            foreach (var type in _xmlSequenceOrder)
            {
                var currentNode = _buildActions[type].First;
                while (currentNode != null)
                {
                    currentNode.Value(entity);
                    currentNode = currentNode.Next;
                }
            }
        }

        public override Sans_Properties_TXLifeBuilder Version(string version)
        {
            _buildPropertiesActions.AddLast(n => n.Version = version);
            _isVersionSet = true;
            return this;
        }

        public override Sans_Properties_TXLifeBuilder AddOLifEExtension(OLifEExtension_Type oLifeExtension)
        {
            _buildPropertiesActions.AddLast(n => n.OLifEExtension.Add(oLifeExtension));
            return this;
        }

        public override Sans_Properties_TXLifeBuilder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder)
        {
            _buildPropertiesActions.AddLast(n => n.OLifEExtension.Add(builder.Build()));
            return this;
        }

        public override Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder AddTXLifeNotify(TXLifeNotify_Type notify)
        {
            _buildActions[typeof(TXLifeNotify_Type)].AddLast(n => n.Items.Add(notify));
            return this;
        }

        public override Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder AddTXLifeNotify(IBuilder<TXLifeNotify_Type> builder)
        {
            _buildActions[typeof(TXLifeNotify_Type)].AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder AddTXLifeRequest(TXLifeRequest_Type request)
        {
            _buildActions[typeof(TXLifeRequest_Type)].AddLast(n => n.Items.Add(request));
            return this;
        }

        public override Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder AddTXLifeRequest(IBuilder<TXLifeRequest_Type> builder)
        {
            _buildActions[typeof(TXLifeRequest_Type)].AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder AddTXLifeResponse(TXLifeResponse_Type response)
        {
            _buildActions[typeof(TXLifeResponse_Type)].AddLast(n => n.Items.Add(response));
            return this;
        }

        public override Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder AddTXLifeResponse(IBuilder<TXLifeResponse_Type> builder)
        {
            _buildActions[typeof(TXLifeResponse_Type)].AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder AddUserAuthRequest(UserAuthRequest_Type request)
        {
            _buildActions[typeof(UserAuthRequest_Type)].AddLast(n => n.Items.Add(request));
            return this;
        }

        public override Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder AddUserAuthRequest(IBuilder<UserAuthRequest_Type> builder)
        {
            _buildActions[typeof(UserAuthRequest_Type)].AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }

        public override Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder AddUserAuthResponse(UserAuthResponse_Type response)
        {
            _buildActions[typeof(UserAuthResponse_Type)].AddLast(n => n.Items.Add(response));
            return this;
        }

        public override Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder AddUserAuthResponse(IBuilder<UserAuthResponse_Type> builder)
        {
            _buildActions[typeof(UserAuthResponse_Type)].AddLast(n => n.Items.Add(builder.Build()));
            return this;
        }
    }

    #region Restrictive Interfaces
    public interface TXLifeRequest_TXLifeBuilder<TRemainder> { TRemainder AddTXLifeRequest(TXLifeRequest_Type request); TRemainder AddTXLifeRequest(IBuilder<TXLifeRequest_Type> builder); }
    public interface TXLifeResponse_TXLifeBuilder<TRemainder> { TRemainder AddTXLifeResponse(TXLifeResponse_Type response); TRemainder AddTXLifeResponse(IBuilder<TXLifeResponse_Type> builder); TRemainder AddTXLifeNotify(TXLifeNotify_Type notify); TRemainder AddTXLifeNotify(IBuilder<TXLifeNotify_Type> builder); }
    public interface UserAuthRequest_TXLifeBuilder<TRemainder> { TRemainder AddUserAuthRequest(UserAuthRequest_Type request); TRemainder AddUserAuthRequest(IBuilder<UserAuthRequest_Type> builder); }
    public interface UserAuthResponse_TXLifeBuilder<TRemainder> { TRemainder AddUserAuthResponse(UserAuthResponse_Type response); TRemainder AddUserAuthResponse(IBuilder<UserAuthResponse_Type> builder); }
    #endregion

    #region Non-restrictive Interfaces
    public interface Properties_TXLifeBuilder<TRemainder>
    {
        TRemainder Version(string version);
        TRemainder AddOLifEExtension(OLifEExtension_Type oLifeExtension);
        TRemainder AddOLifEExtension(IBuilder<OLifEExtension_Type> builder);
    }
    #endregion

    // zero reductions (properties)
    public interface Sans_Properties_TXLifeBuilder :
        IBuild<TXLife_Type>,
        Properties_TXLifeBuilder<Sans_Properties_TXLifeBuilder>,
        TXLifeRequest_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder>,
        TXLifeResponse_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder>,
        UserAuthRequest_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder>,
        UserAuthResponse_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder>
    { }

    // level one reductions
    // These reduce the selections down to Request or Response transactions.

    // if we chose TXLifeResponse, then we don't have liferequest and authrequest
    public interface Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder :
        IBuild<TXLife_Type>,
        Properties_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder>,
        TXLifeResponse_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_TXLifeBuilder>,
        UserAuthResponse_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder>
    { }
    
    // chose TXLifeRequest, then no liferesponse and auth response
    public interface Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder :
        IBuild<TXLife_Type>,
        Properties_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder>,
        TXLifeRequest_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_TXLifeBuilder>,
        UserAuthRequest_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder>
    { }

    // level two reductions
    // These level 2 reductions remove the User[Request|Response] elements because they are zero or one
    // where all others are zero or more
    public interface Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder :
        IBuild<TXLife_Type>,
        Properties_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder>,
        TXLifeResponse_TXLifeBuilder<Sans_TXLifeRequest_UserAuthRequest_UserAuthResponse_TXLifeBuilder>
    { }

    public interface Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder :
        IBuild<TXLife_Type>,
        Properties_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder>,
        TXLifeRequest_TXLifeBuilder<Sans_TXLifeResponse_UserAuthResponse_UserAuthRequest_TXLifeBuilder>
    { }

}
