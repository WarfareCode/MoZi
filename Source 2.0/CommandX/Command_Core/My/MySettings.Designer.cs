using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Command_Core.My
{
	// Token: 0x02000087 RID: 135
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), CompilerGenerated]
	public sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0005CDDC File Offset: 0x0005AFDC
		public static MySettings Default
		{
			get
			{
				return MySettings.mySettings_0;
			}
		}

		// Token: 0x0400019F RID: 415
		private static MySettings mySettings_0 = (MySettings)SettingsBase.Synchronized(new MySettings());
	}
}
