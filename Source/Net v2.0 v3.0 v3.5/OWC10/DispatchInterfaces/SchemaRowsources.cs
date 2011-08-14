//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface SchemaRowsources SupportByLibrary OWC10, 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SchemaRowsources : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(SchemaRowsources);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SchemaRowsources(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SchemaRowsources(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SchemaRowsources(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SchemaRowsources()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("OWC10", 1)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OWC10Api.SchemaRowsource this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OWC10Api.SchemaRowsource newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.SchemaRowsource;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="RowsourceType">NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum RowsourceType</param>
		/// <param name="CommandText">optional object CommandText</param>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.SchemaRowsource Add(string name, NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum rowsourceType, object commandText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, rowsourceType, commandText);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OWC10Api.SchemaRowsource newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.SchemaRowsource;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="RowsourceType">NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum RowsourceType</param>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.SchemaRowsource Add(string name, NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum rowsourceType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, rowsourceType);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OWC10Api.SchemaRowsource newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.SchemaRowsource;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="RowsourceType">NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum RowsourceType</param>
		/// <param name="CommandText">optional object CommandText</param>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.SchemaRowsource AddNew(string name, NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum rowsourceType, object commandText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, rowsourceType, commandText);
			object returnItem = Invoker.MethodReturn(this, "AddNew", paramsArray);
			NetOffice.OWC10Api.SchemaRowsource newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.SchemaRowsource;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="RowsourceType">NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum RowsourceType</param>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.SchemaRowsource AddNew(string name, NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum rowsourceType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, rowsourceType);
			object returnItem = Invoker.MethodReturn(this, "AddNew", paramsArray);
			NetOffice.OWC10Api.SchemaRowsource newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.SchemaRowsource;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("OWC10", 1)]
		public void Delete(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("OWC10", 1)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}