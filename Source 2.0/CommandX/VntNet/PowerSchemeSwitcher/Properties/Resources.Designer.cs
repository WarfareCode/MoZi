using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace VntNet.PowerSchemeSwitcher.Properties
{
	// Token: 0x0200053C RID: 1340
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	public sealed class Resources
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x000DF100 File Offset: 0x000DD300
		internal static Icon BatteryIcon
		{
			get
			{
				return (Icon)Resources.ResourceManager.GetObject("BatteryIcon", Resources.resourceCulture);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x000DF128 File Offset: 0x000DD328
		internal static Bitmap BatteryImg
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("BatteryImg", Resources.resourceCulture);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x000DF150 File Offset: 0x000DD350
		// (set) Token: 0x060022E2 RID: 8930 RVA: 0x00014615 File Offset: 0x00012815
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x000DF164 File Offset: 0x000DD364
		internal static Bitmap Info
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Info", Resources.resourceCulture);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x000DF18C File Offset: 0x000DD38C
		internal static Icon MaxPowerIcon
		{
			get
			{
				return (Icon)Resources.ResourceManager.GetObject("MaxPowerIcon", Resources.resourceCulture);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x000DF1B4 File Offset: 0x000DD3B4
		internal static Icon MaxSavingIcon
		{
			get
			{
				return (Icon)Resources.ResourceManager.GetObject("MaxSavingIcon", Resources.resourceCulture);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x000DF1DC File Offset: 0x000DD3DC
		internal static Icon PlugIcon
		{
			get
			{
				return (Icon)Resources.ResourceManager.GetObject("PlugIcon", Resources.resourceCulture);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x000DF204 File Offset: 0x000DD404
		internal static Bitmap PlugImg
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("PlugImg", Resources.resourceCulture);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x000DF22C File Offset: 0x000DD42C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("VntNet.PowerSchemeSwitcher.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x000DF26C File Offset: 0x000DD46C
		internal static Icon TypicalPowerIcon
		{
			get
			{
				return (Icon)Resources.ResourceManager.GetObject("TypicalPowerIcon", Resources.resourceCulture);
			}
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00004A21 File Offset: 0x00002C21
		internal Resources()
		{
		}

		// Token: 0x040010FF RID: 4351
		private static ResourceManager resourceMan;

		// Token: 0x04001100 RID: 4352
		private static CultureInfo resourceCulture;
	}
}
