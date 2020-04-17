using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns30;
using ns31;

namespace ns2
{
	// Token: 0x02000B31 RID: 2865
	public sealed class Satellite_Kinematics : ActiveUnit_Kinematics
	{
		// Token: 0x06005C2E RID: 23598 RVA: 0x00027D9E File Offset: 0x00025F9E
		public Satellite_Kinematics(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x002A1E9C File Offset: 0x002A009C
		public long method_17()
		{
			long result;
			if (Information.IsNothing(this.m_Ephemeris))
			{
				result = (long)Math.Round(this.m_Satellite.method_1().method_10() * 1000.0);
			}
			else
			{
				result = (long)Math.Round(this.m_Ephemeris.method_3() * 1000.0);
			}
			return result;
		}

		// Token: 0x06005C30 RID: 23600 RVA: 0x002A1F08 File Offset: 0x002A0108
		public long method_18()
		{
			long result;
			if (Information.IsNothing(this.m_Ephemeris))
			{
				result = (long)Math.Round(this.m_Satellite.method_1().method_9() * 1000.0);
			}
			else
			{
				result = (long)Math.Round(this.m_Ephemeris.method_4() * 1000.0);
			}
			return result;
		}

		// Token: 0x06005C31 RID: 23601 RVA: 0x002A1F74 File Offset: 0x002A0174
		public void method_19(float float_5, long long_0, long long_1)
		{
			this.m_Satellite = null;
			this.m_Ephemeris = new Satellite_Orbit.Ephemeris();
			this.m_Ephemeris.method_0((double)float_5, (double)long_0 / 1000.0, (double)long_1 / 1000.0);
			this.UpdateUnitPositions(0f, false, false);
		}

		// Token: 0x06005C32 RID: 23602 RVA: 0x002A1FC8 File Offset: 0x002A01C8
		public void method_20(string[] string_1)
		{
			this.m_Ephemeris = null;
			if (string_1.Length == 2)
			{
				List<string> list = string_1.ToList<string>();
				list.Insert(0, "Mysat");
				string_1 = list.ToArray();
			}
			Class2419 tle = new Class2419(string_1[0], string_1[1], string_1[2]);
			this.m_Satellite = new Class2418(tle, "");
			this.UpdateUnitPositions(0f, false, false);
		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x002A2030 File Offset: 0x002A0230
		public void CalculateOrbit(DateTime dateTime_0, ref double double_0, ref double double_1, ref double double_2, ref double double_3)
		{
			if (Information.IsNothing(this.m_Ephemeris))
			{
				Class2411 @class = this.m_Satellite.method_3(dateTime_0.ToUniversalTime());
				Class2409 class2 = new Class2409(@class, new Class2413(dateTime_0.ToUniversalTime()));
				double_0 = class2.method_4();
				double_1 = class2.method_5();
				double_2 = class2.method_6();
				double num = @class.method_2().method_0() * 1000.0;
				double_3 = num * 1.94384;
			}
			else
			{
				double num2 = 0.0;
				this.m_Ephemeris.method_1(dateTime_0, true, ref double_0, ref double_1, ref double_2, ref num2);
				double_3 = num2 * 1000.0 * 1.94384;
			}
		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x002A20E8 File Offset: 0x002A02E8
		public override void UpdateUnitPositions(float float_5, bool bool_2, bool bool_3)
		{
			try
			{
				double num = 0.0;
				double num2 = 0.0;
				double num3 = 0.0;
				double num4 = 0.0;
				this.CalculateOrbit(this.activeUnit.m_Scenario.GetCurrentTime(false), ref num, ref num2, ref num3, ref num4);
				double lat = 0.0;
				double lon = 0.0;
				double num5 = 0.0;
				double num6 = 0.0;
				this.CalculateOrbit(this.activeUnit.m_Scenario.GetCurrentTime(false).AddSeconds(1.0), ref lat, ref lon, ref num5, ref num6);
				this.activeUnit.SetCurrentHeading(Math2.GetAzimuth(num, num2, lat, lon));
				if (this.activeUnit.m_Scenario.GetTimeCompression() > 1)
				{
					this.activeUnit.SetLatitude(null, num);
					this.activeUnit.SetLongitude(null, num2);
					this.activeUnit.SetAltitude_ASL(false, (float)(num3 * 1000.0));
					this.activeUnit.SetCurrentSpeed((float)num4);
				}
				else
				{
					float num7 = (float)((double)this.activeUnit.m_Scenario.GetCurrentTime(false).Millisecond / 1000.0);
					float distance = Math2.GetDistance(num, num2, lat, lon);
					float num8 = num7 * distance;
					double lng = num2;
					double lat2 = num;
					ActiveUnit activeUnit2;
					ActiveUnit activeUnit = activeUnit2 = this.activeUnit;
					bool? hintIsOperating = null;
					double longitude = activeUnit2.GetLongitude(hintIsOperating);
					ActiveUnit activeUnit4;
					ActiveUnit activeUnit3 = activeUnit4 = this.activeUnit;
					bool? hintIsOperating2 = null;
					double latitude = activeUnit4.GetLatitude(hintIsOperating2);
					GeoPointGenerator.GetOtherGeoPoint(lng, lat2, ref longitude, ref latitude, (double)num8, (double)this.activeUnit.GetCurrentHeading());
					activeUnit3.SetLatitude(hintIsOperating2, latitude);
					activeUnit.SetLongitude(hintIsOperating, longitude);
					this.activeUnit.SetAltitude_ASL(false, (float)((num3 + (num5 - num3) * (double)num7) * 1000.0));
					this.activeUnit.SetCurrentSpeed((float)(num4 + (num6 - num4) * (double)num7));
				}
				this.activeUnit.SetLongitudeLR(new double?(this.activeUnit.GetLongitude(null)));
				this.activeUnit.SetLatitudeLR(new double?(this.activeUnit.GetLatitude(null)));
				ActiveUnit_Kinematics.ExportUnitPositions(this.activeUnit);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100755", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x04003098 RID: 12440
		private Class2418 m_Satellite;

		// Token: 0x04003099 RID: 12441
		private Satellite_Orbit.Ephemeris m_Ephemeris;
	}
}
