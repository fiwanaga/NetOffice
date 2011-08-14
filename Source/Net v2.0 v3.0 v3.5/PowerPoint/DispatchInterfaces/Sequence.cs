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
	/// DispatchInterface Sequence SupportByLibrary PowerPoint, 10,11,12,14
	///</summary>
	[SupportByLibrary("PowerPoint", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Sequence : Collection
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Sequence);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Sequence(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Sequence(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Sequence(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Sequence()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
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
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.PowerPointApi.Effect this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PowerPointApi.Effect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Effect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="Shape">NetOffice.PowerPointApi.Shape Shape</param>
		/// <param name="effectId">NetOffice.PowerPointApi.Enums.MsoAnimEffect effectId</param>
		/// <param name="Level">NetOffice.PowerPointApi.Enums.MsoAnimateByLevel Level</param>
		/// <param name="trigger">NetOffice.PowerPointApi.Enums.MsoAnimTriggerType trigger</param>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Effect AddEffect(NetOffice.PowerPointApi.Shape shape, NetOffice.PowerPointApi.Enums.MsoAnimEffect effectId, NetOffice.PowerPointApi.Enums.MsoAnimateByLevel level, NetOffice.PowerPointApi.Enums.MsoAnimTriggerType trigger, Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(shape, effectId, level, trigger, index);
			object returnItem = Invoker.MethodReturn(this, "AddEffect", paramsArray);
			NetOffice.PowerPointApi.Effect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Effect;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="Effect">NetOffice.PowerPointApi.Effect Effect</param>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Effect Clone(NetOffice.PowerPointApi.Effect effect, Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(effect, index);
			object returnItem = Invoker.MethodReturn(this, "Clone", paramsArray);
			NetOffice.PowerPointApi.Effect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Effect;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="Shape">NetOffice.PowerPointApi.Shape Shape</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Effect FindFirstAnimationFor(NetOffice.PowerPointApi.Shape shape)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(shape);
			object returnItem = Invoker.MethodReturn(this, "FindFirstAnimationFor", paramsArray);
			NetOffice.PowerPointApi.Effect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Effect;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="click">Int32 click</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Effect FindFirstAnimationForClick(Int32 click)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(click);
			object returnItem = Invoker.MethodReturn(this, "FindFirstAnimationForClick", paramsArray);
			NetOffice.PowerPointApi.Effect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Effect;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="Effect">NetOffice.PowerPointApi.Effect Effect</param>
		/// <param name="Level">NetOffice.PowerPointApi.Enums.MsoAnimateByLevel Level</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Effect ConvertToBuildLevel(NetOffice.PowerPointApi.Effect effect, NetOffice.PowerPointApi.Enums.MsoAnimateByLevel level)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(effect, level);
			object returnItem = Invoker.MethodReturn(this, "ConvertToBuildLevel", paramsArray);
			NetOffice.PowerPointApi.Effect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Effect;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="Effect">NetOffice.PowerPointApi.Effect Effect</param>
		/// <param name="After">NetOffice.PowerPointApi.Enums.MsoAnimAfterEffect After</param>
		/// <param name="DimColor">Int32 DimColor</param>
		/// <param name="DimSchemeColor">NetOffice.PowerPointApi.Enums.PpColorSchemeIndex DimSchemeColor</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Effect ConvertToAfterEffect(NetOffice.PowerPointApi.Effect effect, NetOffice.PowerPointApi.Enums.MsoAnimAfterEffect after, Int32 dimColor, NetOffice.PowerPointApi.Enums.PpColorSchemeIndex dimSchemeColor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(effect, after, dimColor, dimSchemeColor);
			object returnItem = Invoker.MethodReturn(this, "ConvertToAfterEffect", paramsArray);
			NetOffice.PowerPointApi.Effect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Effect;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="Effect">NetOffice.PowerPointApi.Effect Effect</param>
		/// <param name="AnimateBackground">NetOffice.OfficeApi.Enums.MsoTriState AnimateBackground</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Effect ConvertToAnimateBackground(NetOffice.PowerPointApi.Effect effect, NetOffice.OfficeApi.Enums.MsoTriState animateBackground)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(effect, animateBackground);
			object returnItem = Invoker.MethodReturn(this, "ConvertToAnimateBackground", paramsArray);
			NetOffice.PowerPointApi.Effect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Effect;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="Effect">NetOffice.PowerPointApi.Effect Effect</param>
		/// <param name="animateInReverse">NetOffice.OfficeApi.Enums.MsoTriState animateInReverse</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Effect ConvertToAnimateInReverse(NetOffice.PowerPointApi.Effect effect, NetOffice.OfficeApi.Enums.MsoTriState animateInReverse)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(effect, animateInReverse);
			object returnItem = Invoker.MethodReturn(this, "ConvertToAnimateInReverse", paramsArray);
			NetOffice.PowerPointApi.Effect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Effect;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="Effect">NetOffice.PowerPointApi.Effect Effect</param>
		/// <param name="unitEffect">NetOffice.PowerPointApi.Enums.MsoAnimTextUnitEffect unitEffect</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Effect ConvertToTextUnitEffect(NetOffice.PowerPointApi.Effect effect, NetOffice.PowerPointApi.Enums.MsoAnimTextUnitEffect unitEffect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(effect, unitEffect);
			object returnItem = Invoker.MethodReturn(this, "ConvertToTextUnitEffect", paramsArray);
			NetOffice.PowerPointApi.Effect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Effect;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		/// <param name="pShape">NetOffice.PowerPointApi.Shape pShape</param>
		/// <param name="effectId">NetOffice.PowerPointApi.Enums.MsoAnimEffect effectId</param>
		/// <param name="trigger">NetOffice.PowerPointApi.Enums.MsoAnimTriggerType trigger</param>
		/// <param name="pTriggerShape">NetOffice.PowerPointApi.Shape pTriggerShape</param>
		/// <param name="bookmark">string bookmark</param>
		/// <param name="Level">NetOffice.PowerPointApi.Enums.MsoAnimateByLevel Level</param>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Effect AddTriggerEffect(NetOffice.PowerPointApi.Shape pShape, NetOffice.PowerPointApi.Enums.MsoAnimEffect effectId, NetOffice.PowerPointApi.Enums.MsoAnimTriggerType trigger, NetOffice.PowerPointApi.Shape pTriggerShape, string bookmark, NetOffice.PowerPointApi.Enums.MsoAnimateByLevel level)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pShape, effectId, trigger, pTriggerShape, bookmark, level);
			object returnItem = Invoker.MethodReturn(this, "AddTriggerEffect", paramsArray);
			NetOffice.PowerPointApi.Effect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Effect;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}