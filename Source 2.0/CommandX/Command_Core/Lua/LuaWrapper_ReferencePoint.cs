using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace Command_Core.Lua
{
	// Token: 0x02000C6A RID: 3178
	[Attribute1, Attribute2, Attribute3]
	public sealed class LuaWrapper_ReferencePoint
	{
		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060069AC RID: 27052 RVA: 0x0038DFC4 File Offset: 0x0038C1C4
		// (set) Token: 0x060069AD RID: 27053 RVA: 0x0038DFE0 File Offset: 0x0038C1E0
		[Attribute2]
		public ReferencePoint.OrientationType bearingtype
		{
			get
			{
				return this.rp.BearingType;
			}
			set
			{
				ReferencePoint.OrientationType orientationType = ReferencePoint.OrientationType.Fixed;
				if (Enum.TryParse<ReferencePoint.OrientationType>(Conversions.ToString((byte)value), out orientationType))
				{
					this.rp.BearingType = value;
				}
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060069AE RID: 27054 RVA: 0x0038E010 File Offset: 0x0038C210
		[Attribute2]
		public string guid
		{
			get
			{
				return this.rp.GetGuid();
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060069AF RID: 27055 RVA: 0x0002D84D File Offset: 0x0002BA4D
		// (set) Token: 0x060069B0 RID: 27056 RVA: 0x0002D85A File Offset: 0x0002BA5A
		[Attribute2]
		public bool highlighted
		{
			get
			{
				return this.rp.IsSelected();
			}
			set
			{
				this.rp.SetIsSelected(value);
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060069B1 RID: 27057 RVA: 0x0038E02C File Offset: 0x0038C22C
		// (set) Token: 0x060069B2 RID: 27058 RVA: 0x0038E04C File Offset: 0x0038C24C
		[Attribute2]
		public object latitude
		{
			get
			{
				return this.rp.GetLatitude();
			}
			set
			{
				double? num = LuaUtility.smethod_11(RuntimeHelpers.GetObjectValue(value));
				if (!num.HasValue)
				{
					throw new Exception2("Can't pass nil in as latitude.");
				}
				this.rp.SetLatitude(num.Value);
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060069B3 RID: 27059 RVA: 0x0002D868 File Offset: 0x0002BA68
		// (set) Token: 0x060069B4 RID: 27060 RVA: 0x0002D875 File Offset: 0x0002BA75
		[Attribute2]
		public bool locked
		{
			get
			{
				return this.rp.IsLocked;
			}
			set
			{
				this.rp.IsLocked = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060069B5 RID: 27061 RVA: 0x0038E08C File Offset: 0x0038C28C
		// (set) Token: 0x060069B6 RID: 27062 RVA: 0x0038E0AC File Offset: 0x0038C2AC
		[Attribute2]
		public object longitude
		{
			get
			{
				return this.rp.GetLongitude();
			}
			set
			{
				double? num = LuaUtility.smethod_13(RuntimeHelpers.GetObjectValue(value));
				if (!num.HasValue)
				{
					throw new Exception2("Can't pass nil in as longitude.");
				}
				this.rp.SetLongitude(num.Value);
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060069B7 RID: 27063 RVA: 0x0038E0EC File Offset: 0x0038C2EC
		// (set) Token: 0x060069B8 RID: 27064 RVA: 0x0002D883 File Offset: 0x0002BA83
		[Attribute2]
		public string name
		{
			get
			{
				return this.rp.Name;
			}
			set
			{
				this.rp.Name = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060069B9 RID: 27065 RVA: 0x0038E108 File Offset: 0x0038C308
		// (set) Token: 0x060069BA RID: 27066 RVA: 0x0002D891 File Offset: 0x0002BA91
		[Attribute2]
		public Unit relativeto
		{
			get
			{
				return this.rp.IsRelativeToUnit;
			}
			set
			{
				this.rp.IsRelativeToUnit = value;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060069BB RID: 27067 RVA: 0x0038E124 File Offset: 0x0038C324
		[Attribute2]
		public string side
		{
			get
			{
				return this.ScenarioContext.GetSides().First((Side s) => s.GetReferencePoints().Contains(this.rp)).GetSideName();
			}
		}

		// Token: 0x060069BC RID: 27068 RVA: 0x0002D89F File Offset: 0x0002BA9F
		public LuaWrapper_ReferencePoint(ReferencePoint r, Scenario s)
		{
			this.rp = r;
			this.ScenarioContext = s;
		}

		// Token: 0x060069BD RID: 27069 RVA: 0x0038E154 File Offset: 0x0038C354
		[Attribute2]
		public override string ToString()
		{
			string[] array = new string[15];
			array[0] = "{\r\n name = '";
			array[1] = this.name;
			array[2] = "', \r\n latitude = '";
			array[3] = this.latitude.ToString();
			array[4] = "', \r\n longitude = '";
			array[5] = this.longitude.ToString();
			array[6] = "', \r\n guid = '";
			array[7] = this.guid.ToString();
			array[8] = "', \r\n side = '";
			array[9] = this.side;
			array[10] = "', \r\n highlighted = '";
			string[] array2 = array;
			array2[11] = this.highlighted.ToString();
			array2[12] = "', \r\n locked = '";
			array2[13] = this.locked.ToString();
			array2[14] = "', \r\n";
			string text = string.Concat(array2);
			if (this.relativeto != null)
			{
				array = new string[6];
				array[0] = text;
				array[1] = " bearingtype = '";
				string[] array3 = array;
				array3[2] = this.bearingtype.ToString();
				array3[3] = "', \r\n relativeto = '";
				array3[4] = this.relativeto.Name;
				array3[5] = "', \r\n";
				text = string.Concat(array3);
			}
			return text + "}";
		}

		// Token: 0x04003B8B RID: 15243
		private ReferencePoint rp;

		// Token: 0x04003B8C RID: 15244
		private Scenario ScenarioContext;
	}
}
