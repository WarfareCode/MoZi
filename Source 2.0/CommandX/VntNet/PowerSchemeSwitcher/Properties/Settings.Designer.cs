using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VntNet.PowerSchemeSwitcher.Properties
{
	// Token: 0x0200053D RID: 1341
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"), CompilerGenerated]
	public sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x000DF294 File Offset: 0x000DD494
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x0001461D File Offset: 0x0001281D
		// (set) Token: 0x060022ED RID: 8941 RVA: 0x0001462F File Offset: 0x0001282F
		[DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
		public bool EnableAutoSwitching
		{
			get
			{
				return (bool)this["EnableAutoSwitching"];
			}
			set
			{
				this["EnableAutoSwitching"] = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x000DF2A8 File Offset: 0x000DD4A8
		// (set) Token: 0x060022EF RID: 8943 RVA: 0x00014642 File Offset: 0x00012842
		[DefaultSettingValue("30"), UserScopedSetting, DebuggerNonUserCode]
		public int LowBatteryPercentage
		{
			get
			{
				return (int)this["LowBatteryPercentage"];
			}
			set
			{
				this["LowBatteryPercentage"] = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x000DF2C8 File Offset: 0x000DD4C8
		// (set) Token: 0x060022F1 RID: 8945 RVA: 0x00014655 File Offset: 0x00012855
		[DefaultSettingValue("00000000-0000-0000-0000-000000000000"), UserScopedSetting, DebuggerNonUserCode]
		public Guid OnAcScheme
		{
			get
			{
				return (Guid)this["OnAcScheme"];
			}
			set
			{
				this["OnAcScheme"] = value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x000DF2E8 File Offset: 0x000DD4E8
		// (set) Token: 0x060022F3 RID: 8947 RVA: 0x00014668 File Offset: 0x00012868
		[DefaultSettingValue("00000000-0000-0000-0000-000000000000"), UserScopedSetting, DebuggerNonUserCode]
		public Guid OnFullBatteryScheme
		{
			get
			{
				return (Guid)this["OnFullBatteryScheme"];
			}
			set
			{
				this["OnFullBatteryScheme"] = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x000DF308 File Offset: 0x000DD508
		// (set) Token: 0x060022F5 RID: 8949 RVA: 0x0001467B File Offset: 0x0001287B
		[DefaultSettingValue("00000000-0000-0000-0000-000000000000"), UserScopedSetting, DebuggerNonUserCode]
		public Guid OnLowBatteryScheme
		{
			get
			{
				return (Guid)this["OnLowBatteryScheme"];
			}
			set
			{
				this["OnLowBatteryScheme"] = value;
			}
		}

		// Token: 0x04001101 RID: 4353
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
