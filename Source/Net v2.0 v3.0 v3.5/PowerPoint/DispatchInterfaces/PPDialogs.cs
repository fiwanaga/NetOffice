//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface PPDialogs SupportByLibrary PowerPoint, 9
	///</summary>
	[SupportByLibrary("PowerPoint", 9)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PPDialogs : Collection
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(PPDialogs);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPDialogs(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPDialogs(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPDialogs(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPDialogs()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.Tags Tags
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Tags", paramsArray);
				NetOffice.PowerPointApi.Tags newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Tags;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByLibrary("PowerPoint", 9)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.PowerPointApi.PPDialog this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PowerPointApi.PPDialog newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.PPDialog;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		/// <param name="Modal">NetOffice.OfficeApi.Enums.MsoTriState Modal</param>
		/// <param name="ParentWindow">object ParentWindow</param>
		/// <param name="Position">NetOffice.PowerPointApi.Enums.PpDialogPositioning Position</param>
		/// <param name="DisplayHelp">NetOffice.OfficeApi.Enums.MsoTriState DisplayHelp</param>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.PPDialog AddDialog(Single left, Single top, Single width, Single height, NetOffice.OfficeApi.Enums.MsoTriState modal, object parentWindow, NetOffice.PowerPointApi.Enums.PpDialogPositioning position, NetOffice.OfficeApi.Enums.MsoTriState displayHelp)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height, modal, parentWindow, position, displayHelp);
			object returnItem = Invoker.MethodReturn(this, "AddDialog", paramsArray);
			NetOffice.PowerPointApi.PPDialog newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.PPDialog;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		/// <param name="Modal">NetOffice.OfficeApi.Enums.MsoTriState Modal</param>
		/// <param name="ParentWindow">object ParentWindow</param>
		/// <param name="Position">NetOffice.PowerPointApi.Enums.PpDialogPositioning Position</param>
		/// <param name="DisplayHelp">NetOffice.OfficeApi.Enums.MsoTriState DisplayHelp</param>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.PPDialog AddTabDialog(Single left, Single top, Single width, Single height, NetOffice.OfficeApi.Enums.MsoTriState modal, object parentWindow, NetOffice.PowerPointApi.Enums.PpDialogPositioning position, NetOffice.OfficeApi.Enums.MsoTriState displayHelp)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height, modal, parentWindow, position, displayHelp);
			object returnItem = Invoker.MethodReturn(this, "AddTabDialog", paramsArray);
			NetOffice.PowerPointApi.PPDialog newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.PPDialog;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		/// <param name="resourceDLL">string resourceDLL</param>
		/// <param name="nResID">Int32 nResID</param>
		/// <param name="bModal">NetOffice.OfficeApi.Enums.MsoTriState bModal</param>
		/// <param name="ParentWindow">object ParentWindow</param>
		/// <param name="Position">NetOffice.PowerPointApi.Enums.PpDialogPositioning Position</param>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.PPDialog LoadDialog(string resourceDLL, Int32 nResID, NetOffice.OfficeApi.Enums.MsoTriState bModal, object parentWindow, NetOffice.PowerPointApi.Enums.PpDialogPositioning position)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(resourceDLL, nResID, bModal, parentWindow, position);
			object returnItem = Invoker.MethodReturn(this, "LoadDialog", paramsArray);
			NetOffice.PowerPointApi.PPDialog newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.PPDialog;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.PPAlert AddAlert()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddAlert", paramsArray);
			NetOffice.PowerPointApi.PPAlert newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.PPAlert;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		/// <param name="Text">string Text</param>
		/// <param name="Type">NetOffice.PowerPointApi.Enums.PpAlertType Type</param>
		/// <param name="icon">NetOffice.PowerPointApi.Enums.PpAlertIcon icon</param>
		/// <param name="ParentWindow">object ParentWindow</param>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.Enums.PpAlertButton RunCharacterAlert(string text, NetOffice.PowerPointApi.Enums.PpAlertType type, NetOffice.PowerPointApi.Enums.PpAlertIcon icon, object parentWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text, type, icon, parentWindow);
			object returnItem = Invoker.MethodReturn(this, "RunCharacterAlert", paramsArray);
			return (NetOffice.PowerPointApi.Enums.PpAlertButton)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}