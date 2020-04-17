using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace PathFinderApp.Properties
{
	// Token: 0x020002C5 RID: 709
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0"), CompilerGenerated]
	public sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x0007E650 File Offset: 0x0007C850
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x040006B1 RID: 1713
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
