using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Command_Core
{
	// 固定的地理多边形
	public abstract class FixedGeoPolygon
	{
		// Token: 0x060065FF RID: 26111
		public abstract List<GeoPoint> vmethod_0();

		// Token: 0x06006600 RID: 26112 RVA: 0x0034FE28 File Offset: 0x0034E028
		public bool method_0(double double_2, double double_3, bool bool_0)
		{
			bool result = false;
			try
			{
				if (double_2 > (double)this.method_3())
				{
					result = false;
				}
				else if (double_2 < (double)this.method_4())
				{
					result = false;
				}
				else if (double_3 > (double)this.method_5())
				{
					result = false;
				}
				else if (double_3 < (double)this.method_6())
				{
					result = false;
				}
				else
				{
					double[] array = this.method_1();
					double[] array2 = this.method_2();
					result = GeoPoint.smethod_3(ref double_2, ref double_3, ref array, ref array2);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200095", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x0034FEF4 File Offset: 0x0034E0F4
		public double[] method_1()
		{
			if (Information.IsNothing(this.double_0))
			{
				double[] array = this.vmethod_0().Select(FixedGeoPolygon.GeoPointFunc0).ToArray<double>();
				this.double_0 = array;
			}
			return this.double_0;
		}

		// Token: 0x06006602 RID: 26114 RVA: 0x0034FF38 File Offset: 0x0034E138
		public double[] method_2()
		{
			if (Information.IsNothing(this.double_1))
			{
				double[] array = this.vmethod_0().Select(FixedGeoPolygon.GeoPointFunc1).ToArray<double>();
				this.double_1 = array;
			}
			return this.double_1;
		}

		// Token: 0x06006603 RID: 26115 RVA: 0x0034FF7C File Offset: 0x0034E17C
		protected float method_3()
		{
			if (!this.Latitude.HasValue)
			{
				this.Latitude = new float?((float)this.vmethod_0().Select(FixedGeoPolygon.GeoPointFunc2).OrderByDescending(FixedGeoPolygon.GeoPointFunc3).ElementAtOrDefault(0).GetLatitude());
			}
			return this.Latitude.Value;
		}

		// Token: 0x06006604 RID: 26116 RVA: 0x0034FFD4 File Offset: 0x0034E1D4
		protected float method_4()
		{
			if (!this.nullable_1.HasValue)
			{
				this.nullable_1 = new float?((float)this.vmethod_0().Select(FixedGeoPolygon.GeoPointFunc4).OrderBy(FixedGeoPolygon.GeoPointFunc5).ElementAtOrDefault(0).GetLatitude());
			}
			return this.nullable_1.Value;
		}

		// Token: 0x06006605 RID: 26117 RVA: 0x0035002C File Offset: 0x0034E22C
		protected float method_5()
		{
			if (!this.nullable_2.HasValue)
			{
				this.nullable_2 = new float?((float)this.vmethod_0().Select(FixedGeoPolygon.GeoPointFunc6).OrderByDescending(FixedGeoPolygon.GeoPointFunc7).ElementAtOrDefault(0).GetLongitude());
			}
			return this.nullable_2.Value;
		}

		// Token: 0x06006606 RID: 26118 RVA: 0x00350084 File Offset: 0x0034E284
		protected float method_6()
		{
			if (!this.nullable_3.HasValue)
			{
				this.nullable_3 = new float?((float)this.vmethod_0().Select(FixedGeoPolygon.GeoPointFunc8).OrderBy(FixedGeoPolygon.GeoPointFunc9).ElementAtOrDefault(0).GetLongitude());
			}
			return this.nullable_3.Value;
		}

		// Token: 0x0400380D RID: 14349
		public static Func<GeoPoint, double> GeoPointFunc0 = (GeoPoint geoPoint_0) => geoPoint_0.GetLongitude();

		// Token: 0x0400380E RID: 14350
		public static Func<GeoPoint, double> GeoPointFunc1 = (GeoPoint geoPoint_0) => geoPoint_0.GetLatitude();

		// Token: 0x0400380F RID: 14351
		public static Func<GeoPoint, GeoPoint> GeoPointFunc2 = (GeoPoint geoPoint_0) => geoPoint_0;

		// Token: 0x04003810 RID: 14352
		public static Func<GeoPoint, double> GeoPointFunc3 = (GeoPoint geoPoint_0) => geoPoint_0.GetLatitude();

		// Token: 0x04003811 RID: 14353
		public static Func<GeoPoint, GeoPoint> GeoPointFunc4 = (GeoPoint geoPoint_0) => geoPoint_0;

		// Token: 0x04003812 RID: 14354
		public static Func<GeoPoint, double> GeoPointFunc5 = (GeoPoint geoPoint_0) => geoPoint_0.GetLatitude();

		// Token: 0x04003813 RID: 14355
		public static Func<GeoPoint, GeoPoint> GeoPointFunc6 = (GeoPoint geoPoint_0) => geoPoint_0;

		// Token: 0x04003814 RID: 14356
		public static Func<GeoPoint, double> GeoPointFunc7 = (GeoPoint geoPoint_0) => geoPoint_0.GetLongitude();

		// Token: 0x04003815 RID: 14357
		public static Func<GeoPoint, GeoPoint> GeoPointFunc8 = (GeoPoint geoPoint_0) => geoPoint_0;

		// Token: 0x04003816 RID: 14358
		public static Func<GeoPoint, double> GeoPointFunc9 = (GeoPoint geoPoint_0) => geoPoint_0.GetLongitude();

		// Token: 0x04003817 RID: 14359
		protected float? Latitude;

		// Token: 0x04003818 RID: 14360
		protected float? nullable_1;

		// Token: 0x04003819 RID: 14361
		protected float? nullable_2;

		// Token: 0x0400381A RID: 14362
		protected float? nullable_3;

		// Token: 0x0400381B RID: 14363
		private double[] double_0;

		// Token: 0x0400381C RID: 14364
		private double[] double_1;
	}
}
