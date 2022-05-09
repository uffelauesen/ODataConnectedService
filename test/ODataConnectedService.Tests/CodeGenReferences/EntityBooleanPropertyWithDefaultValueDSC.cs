//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 08.03.2021 22:49:19
namespace Namespace1.DSC
{
    /// <summary>
    /// There are no comments for EntityContainer in the schema.
    /// </summary>
    public partial class EntityContainer : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new EntityContainer object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public EntityContainer(global::System.Uri serviceRoot) :
                this(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
        }
        /// <summary>
        /// Initialize a new EntityContainer object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public EntityContainer(global::System.Uri serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion protocolVersion) :
                base(serviceRoot, protocolVersion)
        {
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Set1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<EntityType> Set1
        {
            get
            {
                if ((this._Set1 == null))
                {
                    this._Set1 = base.CreateQuery<EntityType>("Set1");
                }
                return this._Set1;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<EntityType> _Set1;
        /// <summary>
        /// There are no comments for Set1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public virtual void AddToSet1(EntityType entityType)
        {
            base.AddObject("Set1", entityType);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private const string Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1.DSC"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""EntityType"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""TestBoolean"" Type=""Edm.Boolean"" Nullable=""false"" DefaultValue=""False"" />
      </EntityType>
      <EntityContainer Name=""EntityContainer"">
        <EntitySet Name=""Set1"" EntityType=""Namespace1.DSC.EntityType"" />
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader(Edmx);
                try
                {
                    global::System.Collections.Generic.IEnumerable<global::Microsoft.OData.Edm.Validation.EdmError> errors;
                    global::Microsoft.OData.Edm.IEdmModel edmModel;

                    if (!global::Microsoft.OData.Edm.Csdl.CsdlReader.TryParse(reader, false, out edmModel, out errors))
                    {
                        global::System.Text.StringBuilder errorMessages = new global::System.Text.StringBuilder();
                        foreach (var error in errors)
                        {
                            errorMessages.Append(error.ErrorMessage);
                            errorMessages.Append("; ");
                        }
                        throw new global::System.InvalidOperationException(errorMessages.ToString());
                    }

                    return edmModel;
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }

        }
    }
    /// <summary>
    /// There are no comments for EntityTypeSingle in the schema.
    /// </summary>
    public partial class EntityTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EntityType>
    {
        /// <summary>
        /// Initialize a new EntityTypeSingle object.
        /// </summary>
        public EntityTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) { }

        /// <summary>
        /// Initialize a new EntityTypeSingle object.
        /// </summary>
        public EntityTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) { }

        /// <summary>
        /// Initialize a new EntityTypeSingle object.
        /// </summary>
        public EntityTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EntityType> query)
            : base(query) { }

    }
    /// <summary>
    /// There are no comments for EntityType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("Set1")]
    public partial class EntityType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EntityType object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static EntityType CreateEntityType(int ID)
        {
            EntityType entityType = new EntityType();
            entityType.Id = ID;
            return entityType;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Id is required.")]
        public virtual int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property TestBoolean in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TestBoolean is required.")]
        public virtual bool TestBoolean
        {
            get
            {
                return this._TestBoolean;
            }
            set
            {
                this.OnTestBooleanChanging(value);
                this._TestBoolean = value;
                this.OnTestBooleanChanged();
                this.OnPropertyChanged("TestBoolean");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private bool _TestBoolean = false;
        partial void OnTestBooleanChanging(bool value);
        partial void OnTestBooleanChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::Namespace1.DSC.EntityType as global::Namespace1.DSC.EntityTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="_keys">dictionary with the names and values of keys</param>
        public static global::Namespace1.DSC.EntityTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Namespace1.DSC.EntityType> _source, global::System.Collections.Generic.IDictionary<string, object> _keys)
        {
            return new global::Namespace1.DSC.EntityTypeSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::Namespace1.DSC.EntityType as global::Namespace1.DSC.EntityTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Namespace1.DSC.EntityTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Namespace1.DSC.EntityType> _source,
            int id)
        {
            global::System.Collections.Generic.IDictionary<string, object> _keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Namespace1.DSC.EntityTypeSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
    }
}
