using System;
using ns4;

namespace Command_Core.Lua
{
	// Token: 0x02000C6B RID: 3179
	[Attribute1, Attribute2, Attribute3]
	public sealed class LuaWrapper_Geopoint
	{
		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060069BF RID: 27071 RVA: 0x0038E288 File Offset: 0x0038C488
		// (set) Token: 0x060069C0 RID: 27072 RVA: 0x0002D8C8 File Offset: 0x0002BAC8
		[Attribute2]
		public float altitude
		{
			get
			{
				return this.myGP.GetAltitude();
			}
			set
			{
				this.myGP.SetAltitude(value);
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060069C1 RID: 27073 RVA: 0x0038E2A4 File Offset: 0x0038C4A4
		// (set) Token: 0x060069C2 RID: 27074 RVA: 0x0038E2C0 File Offset: 0x0038C4C0
		[Attribute2]
		public double latitude
		{
			get
			{
				return this.myGP.GetLatitude();
			}
			set
			{
				double? num = LuaUtility.smethod_11(value);
				if (!num.HasValue)
				{
					throw new Exception2("Can't pass nil in as latitude.");
				}
				this.myGP.SetLatitude(num.Value);
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060069C3 RID: 27075 RVA: 0x0038E300 File Offset: 0x0038C500
		// (set) Token: 0x060069C4 RID: 27076 RVA: 0x0038E31C File Offset: 0x0038C51C
		[Attribute2]
		public double longitude
		{
			get
			{
				return this.myGP.GetLongitude();
			}
			set
			{
				double? num = LuaUtility.smethod_13(value);
				if (!num.HasValue)
				{
					throw new Exception2("Can't pass nil in as longitude.");
				}
				this.myGP.SetLongitude(num.Value);
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060069C5 RID: 27077 RVA: 0x0038E35C File Offset: 0x0038C55C
		// (set) Token: 0x060069C6 RID: 27078 RVA: 0x0002D8D6 File Offset: 0x0002BAD6
		[Attribute2]
		public string name
		{
			get
			{
				return this.myGP.Name;
			}
			set
			{
				this.myGP.Name = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060069C7 RID: 27079 RVA: 0x0038E378 File Offset: 0x0038C578
		[Attribute2]
		public string objectid
		{
			get
			{
				return this.myGP.GetGuid();
			}
		}

		// Token: 0x060069C8 RID: 27080 RVA: 0x0002D8E4 File Offset: 0x0002BAE4
		public LuaWrapper_Geopoint(GeoPoint theGeopoint, Scenario theScen)
		{
			this.myGP = theGeopoint;
			this.ScenarioContext = theScen;
		}

		// Token: 0x04003B8D RID: 15245
		private GeoPoint myGP;

		// Token: 0x04003B8E RID: 15246
		private Scenario ScenarioContext;
	}
}
