using System;
using System.Diagnostics;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns2
{
	// Token: 0x02000B78 RID: 2936
	public sealed class Ship_Kinematics : ActiveUnit_Kinematics
	{
		// Token: 0x06006121 RID: 24865 RVA: 0x00027D9E File Offset: 0x00025F9E
		public Ship_Kinematics(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06006122 RID: 24866 RVA: 0x002E73C4 File Offset: 0x002E55C4
		public override long GetFuelBurnoutTime(float float_5, float float_6, bool bool_2, bool bool_3)
		{
			long result;
			if (((Ship)this.activeUnit).IsNuclearPowered())
			{
				result = 9223372036854775807L;
			}
			else
			{
				result = base.GetFuelBurnoutTime(float_5, float_6, bool_2, bool_3);
			}
			return result;
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x002E740C File Offset: 0x002E560C
		public override float GetTurnRate()
		{
			int weightEmpty = this.activeUnit.WeightEmpty;
			float num;
			if (weightEmpty < 350)
			{
				num = 20f;
			}
			else if (weightEmpty < 5500)
			{
				num = 5f;
			}
			else if (weightEmpty < 18000)
			{
				num = 3f;
			}
			else if (weightEmpty < 50000)
			{
				num = 1f;
			}
			else
			{
				num = 0.7f;
			}
			if (this.activeUnit.IsMineSweeper())
			{
				num *= 3f;
			}
			return num;
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x002E74A0 File Offset: 0x002E56A0
		public override float vmethod_22()
		{
			float result;
			if (((Ship)this.activeUnit).IsNuclearPowered())
			{
				result = float.PositiveInfinity;
			}
			else if (this.float_2 > 0f)
			{
				result = this.float_2;
			}
			else
			{
				float num = this.vmethod_20(true, null, null);
				this.float_2 = num / 2f;
				result = this.float_2;
			}
			return result;
		}

		// Token: 0x06006125 RID: 24869 RVA: 0x002E751C File Offset: 0x002E571C
		public override float vmethod_20(bool bool_2, float? nullable_2, float? nullable_3)
		{
			float result = 0f;
			try
			{
				if (((Ship)this.activeUnit).IsNuclearPowered())
				{
					result = 3.40282347E+38f;
				}
				else if (this.activeUnit.GetEngines().Count == 0)
				{
					result = 0f;
				}
				else if (this.activeUnit.GetEngines()[0].altBands.Length == 0)
				{
					result = 0f;
				}
				else
				{
					ActiveUnit.Throttle throttle;
					if (!Information.IsNothing(this.activeUnit.GetAssignedMission(false)))
					{
						if (this.activeUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike)
						{
							if (((Strike)this.activeUnit.GetAssignedMission(false)).strikeType == Strike.StrikeType.Air_Intercept)
							{
								throttle = ActiveUnit.Throttle.Full;
							}
							else
							{
								throttle = ActiveUnit.Throttle.Cruise;
							}
						}
						else
						{
							throttle = ActiveUnit.Throttle.Cruise;
						}
					}
					else
					{
						throttle = ActiveUnit.Throttle.Cruise;
					}
					result = (float)(this.method_17(throttle, nullable_2, nullable_3, bool_2, 0f) * (double)this.GetSpeed(this.activeUnit.GetEngines()[0].GetAltBand(throttle).MaxAltitude, throttle) / 3600.0);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100788", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 3.40282347E+38f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x002E769C File Offset: 0x002E589C
		public double method_17(ActiveUnit.Throttle throttle_0, float? nullable_2, float? nullable_3, bool bool_2, float float_5)
		{
			double result = 0.0;
			try
			{
				double num = 0.0;
				foreach (Engine current in this.activeUnit.GetEngines())
				{
					double num2 = 0.0;
					FuelRec[] fuelRecs = this.activeUnit.GetFuelRecs();
					for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
					{
						FuelRec fuelRec = fuelRecs[i];
						if (current.IsFueTypeSuitable(fuelRec.FuelType))
						{
							num2 += (double)(fuelRec.CurrentQuantity / this.activeUnit.GetFuelConsumption(throttle_0, current.GetAltBand(throttle_0), null, null, false, false, false, false));
						}
					}
					if (num2 > num)
					{
						num = num2;
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100789", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 1.7976931348623157E+308;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006127 RID: 24871 RVA: 0x002E77F0 File Offset: 0x002E59F0
		public override float vmethod_25(Doctrine._FuelState? FuelState_)
		{
			float result = 0f;
			try
			{
				FuelRec[] fuelRecs = this.activeUnit.GetFuelRecs();
				float num = 0f;
				for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
				{
					FuelRec fuelRec = fuelRecs[i];
					num += fuelRec.CurrentQuantity;
				}
				AltBand altBand = this.activeUnit.GetEngines()[0].GetAltBand(ActiveUnit.Throttle.Cruise);
				result = (float)((double)(num / this.activeUnit.GetFuelConsumption(ActiveUnit.Throttle.Cruise, altBand, null, null, false, false, false, false)) * ((double)this.GetSpeed(altBand.MaxAltitude, ActiveUnit.Throttle.Cruise) / 3600.0));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100790", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 3.40282347E+38f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x002E78F0 File Offset: 0x002E5AF0
		public override float vmethod_9(ActiveUnit.Throttle throttle_, float altitude_ASL)
		{
			float num;
			if (this.activeUnit.GetCurrentSpeed() < (float)((double)this.GetSpeed(0f, this.activeUnit.GetMaxThrottleAvailable()) / 2.0))
			{
				int weightEmpty = this.activeUnit.WeightEmpty;
				if (weightEmpty < 350)
				{
					num = 0.8888889f;
				}
				else if (weightEmpty < 5500)
				{
					num = 0.5f;
				}
				else if (weightEmpty < 18000)
				{
					num = 0.222222224f;
				}
				else if (weightEmpty < 50000)
				{
					num = 0.13333334f;
				}
				else
				{
					num = 0.08888889f;
				}
			}
			else
			{
				int weightEmpty2 = this.activeUnit.WeightEmpty;
				if (weightEmpty2 < 350)
				{
					num = 0.444444448f;
				}
				else if (weightEmpty2 < 5500)
				{
					num = 0.25f;
				}
				else if (weightEmpty2 < 18000)
				{
					num = 0.111111112f;
				}
				else if (weightEmpty2 < 50000)
				{
					num = 0.06666667f;
				}
				else
				{
					num = 0.0444444455f;
				}
			}
			if (((Ship)this.activeUnit).Category == Ship._ShipCategory.Merchant)
			{
				num /= 2f;
			}
			if (((Ship)this.activeUnit).IsNuclearPowered())
			{
				num = (float)(1.5 * (double)num);
			}
			return num;
		}

		// Token: 0x06006129 RID: 24873 RVA: 0x002E7A58 File Offset: 0x002E5C58
		public override float vmethod_8(ActiveUnit.Throttle throttle_0, float altitude_ASL, float float_6)
		{
			float num = this.vmethod_9(throttle_0, altitude_ASL);
			float result = num;
			if (this.activeUnit.GetThrottle() > ActiveUnit.Throttle.FullStop)
			{
				result = num * (float)this.activeUnit.GetThrottle() / 2f;
			}
			return result;
		}

		// Token: 0x0600612A RID: 24874 RVA: 0x002E7A9C File Offset: 0x002E5C9C
		public override void vmethod_41(double double_0, float t)
		{
			if (this.activeUnit.GetDesiredTurnRate() != ActiveUnit._TurnRate.const_1 && (int)Math.Round((double)Math.Abs(this.activeUnit.GetCurrentHeading() - this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0))) > 5)
			{
				double num = (double)this.GetSpeed(0f, ActiveUnit.Throttle.Flank);
				double num2;
				if (num > 0.0)
				{
					num2 = 0.5 * double_0 * (double)t * (((double)this.activeUnit.GetCurrentSpeed() + 1E-06) / num);
				}
				else
				{
					num2 = 0.5 * double_0 * (double)t;
				}
				this.activeUnit.SetCurrentSpeed((float)((double)this.activeUnit.GetCurrentSpeed() - num2));
				if (this.activeUnit.GetCurrentSpeed() < 0f)
				{
					this.activeUnit.SetCurrentSpeed(0f);
				}
			}
		}

		// Token: 0x0600612B RID: 24875 RVA: 0x000B1010 File Offset: 0x000AF210
		public override float GetMinAltitude()
		{
			return 0f;
		}

		// Token: 0x0600612C RID: 24876 RVA: 0x000B1010 File Offset: 0x000AF210
		public override float GetMaxAltitude()
		{
			return 0f;
		}
	}
}
