using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns25
{
	// Token: 0x02000630 RID: 1584
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	public sealed class TopologyText
	{
		// Token: 0x0600282A RID: 10282 RVA: 0x00004A21 File Offset: 0x00002C21
		internal TopologyText()
		{
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x000F22BC File Offset: 0x000F04BC
		internal static ResourceManager GetResourceManager()
		{
			if (object.ReferenceEquals(TopologyText.resourceMan, null))
			{
				TopologyText.resourceMan = new ResourceManager("ns25.TopologyText", typeof(TopologyText).Assembly);
			}
			return TopologyText.resourceMan;
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x000F2300 File Offset: 0x000F0500
		internal static string GetArgumentCannotBeNegative_S()
		{
			return TopologyText.GetResourceManager().GetString("ArgumentCouldNotBeCast_S1_S2", TopologyText.resourceCulture);
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x000F2324 File Offset: 0x000F0524
		internal static string GetShouldNeverReachHereException()
		{
			return TopologyText.GetResourceManager().GetString("ShouldNeverReachHereException", TopologyText.resourceCulture);
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x000F2348 File Offset: 0x000F0548
		internal static string GetTopologyException_Depth()
		{
			return TopologyText.GetResourceManager().GetString("TopologyException_Depth", TopologyText.resourceCulture);
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x000F236C File Offset: 0x000F056C
		internal static string GetTwoHorizontalEdgesException()
		{
			return TopologyText.GetResourceManager().GetString("TwoHorizontalEdgesException", TopologyText.resourceCulture);
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x000F2390 File Offset: 0x000F0590
		internal static string GetUnsupportedGeometryException()
		{
			return TopologyText.GetResourceManager().GetString("UnsupportedGeometryException", TopologyText.resourceCulture);
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x000F23B4 File Offset: 0x000F05B4
		internal static string GetClassNotSupportedException_S()
		{
			return TopologyText.GetResourceManager().GetString("ClassNotSupportedException_S", TopologyText.resourceCulture);
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x000F23D8 File Offset: 0x000F05D8
		internal static string GetInsufficientDimensions()
		{
			return TopologyText.GetResourceManager().GetString("InsufficientDimensions", TopologyText.resourceCulture);
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x000F23FC File Offset: 0x000F05FC
		internal static string GetInsufficientDimensions_S()
		{
			return TopologyText.GetResourceManager().GetString("InsufficientDimensions_S", TopologyText.resourceCulture);
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x000F2420 File Offset: 0x000F0620
		internal static string GetInvalidOctantException_S()
		{
			return TopologyText.GetResourceManager().GetString("InvalidOctantException_S", TopologyText.resourceCulture);
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x000F2444 File Offset: 0x000F0644
		internal static string GetNullEdgeException()
		{
			return TopologyText.GetResourceManager().GetString("NullEdgeException", TopologyText.resourceCulture);
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x000F2468 File Offset: 0x000F0668
		internal static string GetPolygonException_HoleElementNull()
		{
			return TopologyText.GetResourceManager().GetString("PolygonException_HoleElementNull", TopologyText.resourceCulture);
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x000F248C File Offset: 0x000F068C
		internal static string GetPolygonException_ShellEmptyButHolesNot()
		{
			return TopologyText.GetResourceManager().GetString("PolygonException_ShellEmptyButHolesNot", TopologyText.resourceCulture);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x000F24B0 File Offset: 0x000F06B0
		internal static string GetShellHoleIdentityException()
		{
			return TopologyText.GetResourceManager().GetString("ShellHoleIdentityException", TopologyText.resourceCulture);
		}

		// Token: 0x04001345 RID: 4933
		private static ResourceManager resourceMan;

		// Token: 0x04001346 RID: 4934
		private static CultureInfo resourceCulture;
	}
}
