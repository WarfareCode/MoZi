using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace DotSpatial.Serialization.Properties
{
	// Token: 0x02000651 RID: 1617
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"), CompilerGenerated]
	public sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600296B RID: 10603 RVA: 0x000FD700 File Offset: 0x000FB900
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x040013D5 RID: 5077
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
