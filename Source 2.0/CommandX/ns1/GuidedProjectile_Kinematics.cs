using System;
using Command_Core;
using Microsoft.VisualBasic;
using ns3;

namespace ns1
{
	// Token: 0x02000AA8 RID: 2728
	public sealed class GuidedProjectile_Kinematics : Weapon_Kinematics
	{
		// Token: 0x06005680 RID: 22144 RVA: 0x00027908 File Offset: 0x00025B08
		public GuidedProjectile_Kinematics(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06005681 RID: 22145 RVA: 0x00252998 File Offset: 0x00250B98
		public override float vmethod_18()
		{
			return 1f;
		}

		// Token: 0x06005682 RID: 22146 RVA: 0x00252998 File Offset: 0x00250B98
		public override float vmethod_17()
		{
			return 1f;
		}

		// Token: 0x06005683 RID: 22147 RVA: 0x00252080 File Offset: 0x00250280
		public override float vmethod_16()
		{
			return 25f;
		}

		// Token: 0x06005684 RID: 22148 RVA: 0x002529AC File Offset: 0x00250BAC
		public override float GetTurnRate()
		{
			float iRCrossSectionModifier = Class263.GetIRCrossSectionModifier((double)base.GetParentWeapon().GetCurrentAltitude_ASL(false), (double)base.GetParentWeapon().GetCurrentSpeed());
			float result;
			if (iRCrossSectionModifier > 8f)
			{
				result = 2f;
			}
			else if (iRCrossSectionModifier > 7f)
			{
				result = 3f;
			}
			else if (iRCrossSectionModifier > 6f)
			{
				result = 4f;
			}
			else if (iRCrossSectionModifier > 5f)
			{
				result = 5f;
			}
			else if (iRCrossSectionModifier > 4f)
			{
				result = 6f;
			}
			else if (iRCrossSectionModifier > 3f)
			{
				result = 7f;
			}
			else if (iRCrossSectionModifier > 2f)
			{
				result = 8f;
			}
			else if (iRCrossSectionModifier > 1f)
			{
				result = 9f;
			}
			else
			{
				result = 10f;
			}
			return result;
		}

		// Token: 0x06005685 RID: 22149 RVA: 0x00252A98 File Offset: 0x00250C98
		public override int GetSpeed(float float_5, ActiveUnit.Throttle throttle_0)
		{
			return (int)Math.Round(UnguidedWeapon.smethod_4(Contact_Base.ContactType.Air, base.GetParentWeapon().GetLargestRangeMaxOfAllDomains(), this.method_18()) * 1.94384);
		}

		// Token: 0x06005686 RID: 22150 RVA: 0x00252AD0 File Offset: 0x00250CD0
		public override float GetMaxAltitude()
		{
			if (!this.MaxAltitude.HasValue)
			{
				float value = (float)(Math.Pow(UnguidedWeapon.smethod_4(Contact_Base.ContactType.Air, base.GetParentWeapon().GetLargestRangeMaxOfAllDomains(), this.method_18()), 2.0) * Math.Pow(Math.Sin(1.570796326794897), 2.0) / 19.62);
				this.MaxAltitude = new float?(value);
			}
			return this.MaxAltitude.Value;
		}

		// Token: 0x06005687 RID: 22151 RVA: 0x000B1010 File Offset: 0x000AF210
		public override float GetMinAltitude()
		{
			return 0f;
		}

		// Token: 0x06005688 RID: 22152 RVA: 0x00252B54 File Offset: 0x00250D54
		private bool method_18()
		{
			bool result;
			if (!this.nullable_3.HasValue)
			{
				if (Information.IsNothing(base.GetParentWeapon().GetWeaponAI().GetPrimaryTarget()))
				{
					result = false;
					return result;
				}
				this.nullable_3 = new bool?(!base.GetParentWeapon().GetFiringParent().IsAircraft && !(base.GetParentWeapon().GetWeaponAI().GetPrimaryTarget().IsAir() | base.GetParentWeapon().GetWeaponAI().GetPrimaryTarget().IsMissileOrTorpedo()));
			}
			result = this.nullable_3.Value;
			return result;
		}

		// Token: 0x06005689 RID: 22153 RVA: 0x00252BE8 File Offset: 0x00250DE8
		public override void UpdateUnitPositions(float t, bool bool_2, bool bool_3)
		{
			double latitude = base.GetParentWeapon().GetLatitude(null);
			double longitude = base.GetParentWeapon().GetLongitude(null);
			Contact primaryTarget = base.GetParentWeapon().GetWeaponAI().GetPrimaryTarget();
			double num;
			double num2;
			float num3;
			if (Information.IsNothing(primaryTarget))
			{
				num = base.GetParentWeapon().GetWeaponAI().GetPrimaryTarget_LastKnown_Lat();
				num2 = base.GetParentWeapon().GetWeaponAI().GetPrimaryTarget_LastKnown_Lon();
				num3 = base.GetParentWeapon().GetWeaponAI().GetPrimaryTarget_LastKnown_Alt();
			}
			else
			{
				num = primaryTarget.GetLatitude(null);
				num2 = primaryTarget.GetLongitude(null);
				num3 = primaryTarget.GetCurrentAltitude_ASL(false);
			}
			double num4 = (double)base.GetParentWeapon().LaunchPoint.GetDistance(num2, num);
			double num5 = UnguidedWeapon.smethod_4(primaryTarget.contactType, base.GetParentWeapon().GetLargestRangeMaxOfAllDomains(), this.method_18());
			if (this.method_18())
			{
				double num6 = num4 / (double)base.GetParentWeapon().GetLargestRangeMaxOfAllDomains();
				double degrees = 35.0 * num6;
				double num7 = Math.Pow(num5, 2.0) * Math.Pow(Math2.Sin_D(degrees), 2.0) / 19.62;
				double num8 = num5 * 1.94384 * Math2.Cos_D(degrees);
				double value = 0.0;
				double value2 = 0.0;
				GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref value, ref value2, num8 * (double)t / 3600.0, (double)base.GetParentWeapon().GetCurrentHeading());
				base.GetParentWeapon().SetLongitude(null, value);
				base.GetParentWeapon().SetLatitude(null, value2);
				double num9 = num4 * 1852.0 / 2.0;
				double num10 = num7 / Math.Pow(num9, 2.0);
				double x = Math.Abs((double)(base.GetParentWeapon().HorizontalRangeTo(base.GetParentWeapon().LaunchPoint) * 1852f) - num9);
				double num11 = -(num10 * Math.Pow(x, 2.0)) + num7;
				base.GetParentWeapon().SetAltitude_ASL(false, Math.Max(1f, (float)(num11 + (double)base.GetParentWeapon().LaunchPoint.GetAltitude())));
			}
			else
			{
				base.GetParentWeapon().Move(t, false);
				float num12 = Math.Abs(base.GetParentWeapon().LaunchPoint.GetAltitude() - num3);
				double num13 = (double)base.GetParentWeapon().HorizontalRangeTo(num, num2) / num4;
				if (num3 > base.GetParentWeapon().LaunchPoint.GetAltitude())
				{
					base.GetParentWeapon().SetAltitude_ASL(false, (float)((double)num3 - (double)num12 * num13));
				}
				else
				{
					base.GetParentWeapon().SetAltitude_ASL(false, (float)((double)num3 + (double)num12 * num13));
				}
			}
			this.vmethod_24(t);
			double num14 = (double)(base.GetParentWeapon().SlantRangeTo(base.GetParentWeapon().LaunchPoint) / base.GetParentWeapon().GetLargestRangeMaxOfAllDomains());
			double num15 = num5 * 1.94384;
			base.GetParentWeapon().SetCurrentSpeed((float)(num15 * (0.34 + 0.67 * (1.0 - num14))));
			ActiveUnit_Kinematics.ExportUnitPositions(base.GetParentWeapon());
		}

		// Token: 0x04002A8B RID: 10891
		private float? MaxAltitude;

		// Token: 0x04002A8C RID: 10892
		private bool? nullable_3;
	}
}
