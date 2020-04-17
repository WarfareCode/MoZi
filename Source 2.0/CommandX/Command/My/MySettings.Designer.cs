using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns32;

namespace Command.My
{
	// Token: 0x02000536 RID: 1334
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), CompilerGenerated]
	public sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x000DE47C File Offset: 0x000DC67C
		public static MySettings Default
		{
			get
			{
				if (!MySettings.bool_0)
				{
					object obj = MySettings.object_0;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.bool_0)
						{
							CommandFactory.GetCommandApp().Shutdown += new ShutdownEventHandler(MySettings.smethod_0);
							MySettings.bool_0 = true;
						}
					}
				}
				return MySettings.mySettings_0;
			}
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x0001437C File Offset: 0x0001257C
		[EditorBrowsable(EditorBrowsableState.Advanced), DebuggerNonUserCode]
		private static void smethod_0(object sender, EventArgs e)
		{
			if (CommandFactory.GetCommandApp().SaveMySettingsOnExit)
			{
				Class2471.smethod_0().Save();
			}
		}

		// Token: 0x040010EA RID: 4330
		private static MySettings mySettings_0 = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x040010EB RID: 4331
		private static bool bool_0;

		// Token: 0x040010EC RID: 4332
		private static object object_0 = RuntimeHelpers.GetObjectValue(new object());
	}
}
