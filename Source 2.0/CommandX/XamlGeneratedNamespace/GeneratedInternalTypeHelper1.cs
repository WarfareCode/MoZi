using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Windows.Markup;

namespace XamlGeneratedNamespace
{
	// Token: 0x0200108C RID: 4236
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
	public sealed class GeneratedInternalTypeHelper1 : InternalTypeHelper
	{
		// Token: 0x060095F6 RID: 38390 RVA: 0x000443DA File Offset: 0x000425DA
		protected override object CreateInstance(Type type, CultureInfo culture)
		{
			return Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, null, culture);
		}

		// Token: 0x060095F7 RID: 38391 RVA: 0x000443EA File Offset: 0x000425EA
		protected override object GetPropertyValue(PropertyInfo propertyInfo, object target, CultureInfo culture)
		{
			return propertyInfo.GetValue(target, BindingFlags.Default, null, null, culture);
		}

		// Token: 0x060095F8 RID: 38392 RVA: 0x00030375 File Offset: 0x0002E575
		protected override void SetPropertyValue(PropertyInfo propertyInfo, object target, object value, CultureInfo culture)
		{
			propertyInfo.SetValue(target, value, BindingFlags.Default, null, null, culture);
		}

		// Token: 0x060095F9 RID: 38393 RVA: 0x004B2DEC File Offset: 0x004B0FEC
		protected override Delegate CreateDelegate(Type delegateType, object target, string handler)
		{
			return (Delegate)target.GetType().InvokeMember("_CreateDelegate", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, target, new object[]
			{
				delegateType,
				handler
			}, null);
		}

		// Token: 0x060095FA RID: 38394 RVA: 0x00030384 File Offset: 0x0002E584
		protected override void AddEventHandler(EventInfo eventInfo, object target, Delegate handler)
		{
			eventInfo.AddEventHandler(target, handler);
		}
	}
}
