using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace System.Data.SQLite
{
	// Token: 0x02001413 RID: 5139
	[DebuggerNonUserCode]
	internal sealed class SR
	{
		// Token: 0x0600B042 RID: 45122 RVA: 0x00004A21 File Offset: 0x00002C21
		internal SR()
		{
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x0600B043 RID: 45123 RVA: 0x004E743C File Offset: 0x004E563C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(SR.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("System.Data.SQLite.SR", typeof(SR).Assembly);
					SR.resourceMan = resourceManager;
				}
				return SR.resourceMan;
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x0600B044 RID: 45124 RVA: 0x00053D68 File Offset: 0x00051F68
		// (set) Token: 0x0600B045 RID: 45125 RVA: 0x00053D6F File Offset: 0x00051F6F
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return SR.resourceCulture;
			}
			set
			{
				SR.resourceCulture = value;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x0600B046 RID: 45126 RVA: 0x00053D77 File Offset: 0x00051F77
		internal static string DataTypes
		{
			get
			{
				return SR.ResourceManager.GetString("DataTypes", SR.resourceCulture);
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x0600B047 RID: 45127 RVA: 0x00053D8D File Offset: 0x00051F8D
		internal static string Keywords
		{
			get
			{
				return SR.ResourceManager.GetString("Keywords", SR.resourceCulture);
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x0600B048 RID: 45128 RVA: 0x00053DA3 File Offset: 0x00051FA3
		internal static string MetaDataCollections
		{
			get
			{
				return SR.ResourceManager.GetString("MetaDataCollections", SR.resourceCulture);
			}
		}

		// Token: 0x04005D8D RID: 23949
		private static ResourceManager resourceMan;

		// Token: 0x04005D8E RID: 23950
		private static CultureInfo resourceCulture;
	}
}
