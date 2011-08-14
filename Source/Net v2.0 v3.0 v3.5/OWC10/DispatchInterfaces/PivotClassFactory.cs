//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface PivotClassFactory SupportByLibrary OWC10, 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PivotClassFactory : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(PivotClassFactory);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotClassFactory(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotClassFactory(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotClassFactory(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotClassFactory()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="DetailCell">NetOffice.OWC10Api.PivotDetailCell DetailCell</param>
		[SupportByLibrary("OWC10", 1)]
		public COMObject get_NewDetailCell(NetOffice.OWC10Api.PivotDetailCell detailCell)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(detailCell);
			object returnItem = Invoker.PropertyGet(this, "NewDetailCell", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Aggregate">NetOffice.OWC10Api.PivotAggregate Aggregate</param>
		[SupportByLibrary("OWC10", 1)]
		public COMObject get_NewAggregate(NetOffice.OWC10Api.PivotAggregate aggregate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(aggregate);
			object returnItem = Invoker.PropertyGet(this, "NewAggregate", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="RowMember">NetOffice.OWC10Api.PivotRowMember RowMember</param>
		[SupportByLibrary("OWC10", 1)]
		public COMObject get_NewRowMember(NetOffice.OWC10Api.PivotRowMember rowMember)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowMember);
			object returnItem = Invoker.PropertyGet(this, "NewRowMember", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="ColumnMember">NetOffice.OWC10Api.PivotColumnMember ColumnMember</param>
		[SupportByLibrary("OWC10", 1)]
		public COMObject get_NewColumnMember(NetOffice.OWC10Api.PivotColumnMember columnMember)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(columnMember);
			object returnItem = Invoker.PropertyGet(this, "NewColumnMember", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Cell">NetOffice.OWC10Api.PivotCell Cell</param>
		[SupportByLibrary("OWC10", 1)]
		public COMObject get_NewCell(NetOffice.OWC10Api.PivotCell cell)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cell);
			object returnItem = Invoker.PropertyGet(this, "NewCell", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}