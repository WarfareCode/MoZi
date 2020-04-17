using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace Command_Core
{
	// Token: 0x02000B38 RID: 2872
	public sealed class Submarine_Kinematics : ActiveUnit_Kinematics
	{
		// Token: 0x06005C70 RID: 23664 RVA: 0x00027D9E File Offset: 0x00025F9E
		public Submarine_Kinematics(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06005C71 RID: 23665 RVA: 0x002A9D24 File Offset: 0x002A7F24
		public override float vmethod_25(Doctrine._FuelState? FuelState_)
		{
			float num = Math.Max(-20f, this.GetMinAltitude());
			return (float)((double)((float)this.vmethod_33(ActiveUnit.Throttle.Cruise, num, true)) * ((double)this.GetSpeed(num, ActiveUnit.Throttle.Cruise) / 3600.0));
		}

		// Token: 0x06005C72 RID: 23666 RVA: 0x002A9D64 File Offset: 0x002A7F64
		public override long vmethod_33(ActiveUnit.Throttle throttle_0, float float_5, bool bool_2)
		{
			long result = 0L;
			try
			{
				if (!((Submarine)this.activeUnit).IsNuclearPropelled() && (!((Submarine)this.activeUnit).IsROV() || this.activeUnit.GetFuelRecs().Count<FuelRec>() != 0))
				{
					FuelRec fuelRec;
					if (this.activeUnit.GetFuelRecs().Count<FuelRec>() == 1)
					{
						fuelRec = this.activeUnit.GetFuelRecs()[0];
					}
					else if (float_5 >= -20f)
					{
						fuelRec = this.activeUnit.GetFuelRecs().Select(Submarine_Kinematics.FuelRecFunc0).Where(new Func<FuelRec, bool>(this.method_18)).ElementAtOrDefault(0);
					}
					else
					{
						fuelRec = this.activeUnit.GetFuelRecs().Select(Submarine_Kinematics.FuelRecFunc1).Where(new Func<FuelRec, bool>(this.method_19)).ElementAtOrDefault(0);
					}
					if (Information.IsNothing(fuelRec))
					{
						result = 0L;
					}
					else
					{
						result = (long)Math.Round((double)fuelRec.CurrentQuantity / (double)this.activeUnit.GetFuelConsumption(throttle_0, null, null, null, false, false, false, false));
					}
				}
				else
				{
					result = 9223372036854775807L;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100833", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005C73 RID: 23667 RVA: 0x002A9F04 File Offset: 0x002A8104
		public override long GetFuelBurnoutTime(float parentSpeed, float parentAltitude_ASL, bool bool_2, bool bool_3)
		{
			long result = 0L;
			if (((Submarine)this.activeUnit).IsBiologics())
			{
				result = 9223372036854775807L;
			}
			else
			{
				try
				{
					if (!((Submarine)this.activeUnit).IsNuclearPropelled() && (!((Submarine)this.activeUnit).IsROV() || this.activeUnit.GetFuelRecs().Count<FuelRec>() != 0))
					{
						if (parentSpeed == 0f)
						{
							result = 9223372036854775807L;
						}
						else
						{
							FuelRec[] fuelRecs = this.activeUnit.GetFuelRecs();
							float num = 0f;
							for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
							{
								FuelRec fuelRec = fuelRecs[i];
								num += fuelRec.CurrentQuantity;
							}
							if (!bool_2)
							{
								num -= this.activeUnit.GetKinematics().GetReserveFuel();
							}
							if (this.activeUnit.GetFuelConsumption(this.vmethod_38(parentAltitude_ASL, (float)((int)Math.Round((double)parentSpeed))), null, new float?((float)((int)Math.Round((double)parentSpeed))), new float?(parentAltitude_ASL), false, false, false, false) == 0f)
							{
								result = 9223372036854775807L;
							}
							else
							{
								result = (long)Math.Round((double)(num / this.activeUnit.GetFuelConsumption(this.vmethod_38(parentAltitude_ASL, (float)((int)Math.Round((double)parentSpeed))), null, new float?((float)((int)Math.Round((double)parentSpeed))), new float?(parentAltitude_ASL), false, false, false, false)));
							}
						}
					}
					else
					{
						result = 9223372036854775807L;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100185", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06005C74 RID: 23668 RVA: 0x002AA0E0 File Offset: 0x002A82E0
		public override void vmethod_41(double double_0, float t)
		{
			if (this.activeUnit.GetDesiredTurnRate() != ActiveUnit._TurnRate.const_1 && (int)Math.Round((double)Math.Abs(this.activeUnit.GetCurrentHeading() - this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0))) > 5)
			{
				float num = 0f;
				if (double_0 > 25.0)
				{
					num = (float)(0.25 * (double)t);
				}
				if (double_0 > 45.0)
				{
					num = 1f * t;
				}
				this.activeUnit.SetCurrentSpeed(this.activeUnit.GetCurrentSpeed() - num);
			}
		}

		// Token: 0x06005C75 RID: 23669 RVA: 0x002AA180 File Offset: 0x002A8380
		public override int GetSpeed(float float_5, ActiveUnit.Throttle throttle_0)
		{
			int result;
			if (((Submarine)this.activeUnit).method_153(throttle_0, null, null, null) == 0L)
			{
				result = 0;
			}
			else
			{
				result = base.GetSpeed(float_5, throttle_0);
			}
			return result;
		}

		// Token: 0x06005C76 RID: 23670 RVA: 0x000E44EC File Offset: 0x000E26EC
		public override float vmethod_20(bool bool_2, float? nullable_2, float? nullable_3)
		{
			return 3.40282347E+38f;
		}

		// Token: 0x06005C77 RID: 23671 RVA: 0x002AA1D4 File Offset: 0x002A83D4
		public override float vmethod_19()
		{
			return (float)((double)this.GetClimbRate() * 1.5);
		}

		// Token: 0x06005C78 RID: 23672 RVA: 0x002AA1F8 File Offset: 0x002A83F8
		public override float GetTurnRate()
		{
			int weightEmpty = this.activeUnit.WeightEmpty;
			float result;
			if (weightEmpty < 350)
			{
				result = 15f;
			}
			else if (weightEmpty < 2500)
			{
				result = 5f;
			}
			else if (weightEmpty < 5000)
			{
				result = 3f;
			}
			else if (weightEmpty < 50000)
			{
				result = 1f;
			}
			else
			{
				result = 0.8f;
			}
			return result;
		}

		// Token: 0x06005C79 RID: 23673 RVA: 0x002AA274 File Offset: 0x002A8474
		public int? method_17(float desiredSpeed_, ActiveUnit.Throttle throttle_)
		{
			Submarine_Kinematics.AlBandMan alBandMan = new Submarine_Kinematics.AlBandMan(null);
			alBandMan._desiredSpeed = desiredSpeed_;
			int? result = null;
			try
			{
				List<AltBand> list = new List<AltBand>();
				IEnumerable<AltBand> source;
				checked
				{
					using (IEnumerator<Engine> enumerator = this.activeUnit.GetEngines().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							AltBand[] altBands = enumerator.Current.altBands;
							for (int i = 0; i < altBands.Length; i++)
							{
								AltBand item = altBands[i];
								list.Add(item);
							}
						}
					}
					source = null;
					switch (throttle_)
					{
					case ActiveUnit.Throttle.Loiter:
						source = list.Where(new Func<AltBand, bool>(alBandMan.IsAltBandLoiterSpeedSufficient)).OrderByDescending(Submarine_Kinematics.AltBandFunc2);
						break;
					case ActiveUnit.Throttle.Cruise:
						source = list.Where(new Func<AltBand, bool>(alBandMan.IsAltBandCruiseSpeedSufficient)).OrderByDescending(Submarine_Kinematics.AltBandFunc3);
						break;
					case ActiveUnit.Throttle.Full:
						source = list.Where(new Func<AltBand, bool>(alBandMan.IsAltBandFullSpeedSufficient)).OrderByDescending(Submarine_Kinematics.AltBandFunc4);
						break;
					case ActiveUnit.Throttle.Flank:
						source = list.Where(new Func<AltBand, bool>(alBandMan.IsAltBandFlankSpeedSufficient)).OrderByDescending(Submarine_Kinematics.AltBandFunc5);
						break;
					}
				}
				if (source.Count<AltBand>() == 0)
				{
					result = null;
				}
				else
				{
					result = new int?((int)Math.Round((double)source.ElementAtOrDefault(0).MaxAltitude));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100834", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005C7A RID: 23674 RVA: 0x002AA448 File Offset: 0x002A8648
		public override AltBand vmethod_39()
		{
			AltBand result = null;
			try
			{
				AltBand altBand = null;
				float currentAltitude_ASL = this.activeUnit.GetCurrentAltitude_ASL(false);
				AltBand[] array = null;
				using (IEnumerator<Engine> enumerator = this.activeUnit.GetEngines().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						array = enumerator.Current.altBands;
						int num = array.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							AltBand altBand2 = array[i];
							if (altBand2.MaxAltitude >= currentAltitude_ASL && currentAltitude_ASL + 1f >= altBand2.MinAltitude)
							{
								altBand = altBand2;
								break;
							}
						}
					}
				}
				if (Information.IsNothing(altBand))
				{
					altBand = array.OrderByDescending(Submarine_Kinematics.AltBandFunc6).ElementAtOrDefault(0);
					this.activeUnit.SetAltitude_ASL(false, altBand.MaxAltitude);
				}
				result = altBand;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100835", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005C7B RID: 23675 RVA: 0x002AA580 File Offset: 0x002A8780
		public override float vmethod_9(ActiveUnit.Throttle throttle, float depth)
		{
			float currentSpeed = this.activeUnit.GetCurrentSpeed();
			float result;
			if (currentSpeed < 7f)
			{
				int weightEmpty = this.activeUnit.WeightEmpty;
				if (weightEmpty < 350)
				{
					result = 0.45f;
				}
				else if (weightEmpty < 3500)
				{
					result = 0.43f;
				}
				else if (weightEmpty < 8100)
				{
					result = 0.41f;
				}
				else if (weightEmpty < 15000)
				{
					result = 0.27f;
				}
				else
				{
					result = 0.2f;
				}
			}
			else if (currentSpeed > 20f)
			{
				int weightEmpty2 = this.activeUnit.WeightEmpty;
				if (weightEmpty2 < 350)
				{
					result = 0.25f;
				}
				else if (weightEmpty2 < 3500)
				{
					result = 0.25f;
				}
				else if (weightEmpty2 < 8100)
				{
					result = 0.55f;
				}
				else if (weightEmpty2 < 15000)
				{
					result = 0.4f;
				}
				else
				{
					result = 0.2f;
				}
			}
			else
			{
				int weightEmpty3 = this.activeUnit.WeightEmpty;
				if (weightEmpty3 < 350)
				{
					result = 0.3f;
				}
				else if (weightEmpty3 < 3500)
				{
					result = 0.3f;
				}
				else if (weightEmpty3 < 8100)
				{
					result = 0.65f;
				}
				else if (weightEmpty3 < 15000)
				{
					result = 0.45f;
				}
				else
				{
					result = 0.25f;
				}
			}
			return result;
		}

		// Token: 0x06005C7C RID: 23676 RVA: 0x00251E7C File Offset: 0x0025007C
		public override float vmethod_8(ActiveUnit.Throttle throttle_, float depth, float float_6)
		{
			return this.vmethod_9(throttle_, depth);
		}

		// Token: 0x06005C7D RID: 23677 RVA: 0x002AA714 File Offset: 0x002A8914
		public override void UpdateUnitPositions(float elapsedTime, bool bool_2, bool bool_3)
		{
			try
			{
				if (!double.IsNaN(this.activeUnit.GetLongitude(null)) && !double.IsNaN(this.activeUnit.GetLatitude(null)) && this.activeUnit.IsOperating())
				{
					if (this.activeUnit.GetDesiredAltitude() > 0f)
					{
						this.activeUnit.SetDesiredAltitude(0f);
					}
					float num = (float)this.activeUnit.GetTerrainElevation(false, false, false);
					if (ArcticSeaIce.IsNearMarginalIceZone(this.activeUnit.GetLongitude(null), this.activeUnit.GetLatitude(null)) && this.activeUnit.GetDesiredAltitude() > -25f)
					{
						this.activeUnit.SetDesiredAltitude(-25f);
					}
					this.SetAltitude_ASL(elapsedTime, this.activeUnit.GetDesiredAltitude(), new float?(num + 1f));
					if (((Submarine)this.activeUnit).IsROV())
					{
						ActiveUnit assignedHostUnit = this.activeUnit.GetDockingOps().GetAssignedHostUnit(false);
						if (!Information.IsNothing(assignedHostUnit) && this.activeUnit.GetHorizontalRange(assignedHostUnit) * 1852f > (float)((Submarine)this.activeUnit).ROVRadius && (Math.Abs(assignedHostUnit.RelativeBearingTo(this.activeUnit, true)) > 90f || assignedHostUnit.GetCurrentSpeed() > this.activeUnit.GetCurrentSpeed()) && assignedHostUnit.GetCurrentSpeed() > 0f)
						{
							float num2 = this.activeUnit.AzimuthTo(assignedHostUnit);
							this.activeUnit.SetCurrentHeading(num2);
							this.activeUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, num2);
							this.activeUnit.SetCurrentSpeed(assignedHostUnit.GetCurrentSpeed());
						}
					}
					base.UpdateUnitPositions(elapsedTime, bool_2, false);
					if (this.activeUnit.GetCommStuff().IsNotOutOfComms())
					{
						this.activeUnit.SetLongitudeLR(new double?(this.activeUnit.GetLongitude(null)));
						this.activeUnit.SetLatitudeLR(new double?(this.activeUnit.GetLatitude(null)));
					}
					else
					{
						if (!this.activeUnit.GetLongitudeLR().HasValue)
						{
							this.activeUnit.SetLongitudeLR(new double?(this.activeUnit.GetLongitude(null)));
						}
						if (!this.activeUnit.GetLatitudeLR().HasValue)
						{
							this.activeUnit.SetLatitudeLR(new double?(this.activeUnit.GetLatitude(null)));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100836", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x000294D0 File Offset: 0x000276D0
		[CompilerGenerated]
		private bool method_18(FuelRec fuelRec_0)
		{
			return this.activeUnit.GetEngines()[0].IsFueTypeSuitable(FuelRec._FuelType.DieselFuel);
		}

		// Token: 0x06005C7F RID: 23679 RVA: 0x000294ED File Offset: 0x000276ED
		[CompilerGenerated]
		private bool method_19(FuelRec fuelRec_0)
		{
			return this.activeUnit.GetEngines()[0].IsFueTypeSuitable(FuelRec._FuelType.Battery);
		}

		// Token: 0x040030B3 RID: 12467
		public static Func<FuelRec, FuelRec> FuelRecFunc0 = (FuelRec fuelRec_0) => fuelRec_0;

		// Token: 0x040030B4 RID: 12468
		public static Func<FuelRec, FuelRec> FuelRecFunc1 = (FuelRec fuelRec_0) => fuelRec_0;

		// Token: 0x040030B5 RID: 12469
		public static Func<AltBand, float> AltBandFunc2 = (AltBand altBand_0) => altBand_0.MaxAltitude;

		// Token: 0x040030B6 RID: 12470
		public static Func<AltBand, float> AltBandFunc3 = (AltBand altBand_0) => altBand_0.MaxAltitude;

		// Token: 0x040030B7 RID: 12471
		public static Func<AltBand, float> AltBandFunc4 = (AltBand altBand_0) => altBand_0.MaxAltitude;

		// Token: 0x040030B8 RID: 12472
		public static Func<AltBand, float> AltBandFunc5 = (AltBand altBand_0) => altBand_0.MaxAltitude;

		// Token: 0x040030B9 RID: 12473
		public static Func<AltBand, float> AltBandFunc6 = (AltBand altBand_0) => altBand_0.MaxAltitude;

		// Token: 0x02000B39 RID: 2873
		[CompilerGenerated]
		public sealed class AlBandMan
		{
			// Token: 0x06005C88 RID: 23688 RVA: 0x0002950A File Offset: 0x0002770A
			public AlBandMan(Submarine_Kinematics.AlBandMan AlBandMan_)
			{
				if (AlBandMan_ != null)
				{
					this._desiredSpeed = AlBandMan_._desiredSpeed;
				}
			}

			// Token: 0x06005C89 RID: 23689 RVA: 0x00029524 File Offset: 0x00027724
			internal bool IsAltBandLoiterSpeedSufficient(AltBand altBand_0)
			{
				return (float)altBand_0.Speed_Loiter >= this._desiredSpeed;
			}

			// Token: 0x06005C8A RID: 23690 RVA: 0x00029538 File Offset: 0x00027738
			internal bool IsAltBandCruiseSpeedSufficient(AltBand altBand_0)
			{
				return (float)altBand_0.Speed_Cruise >= this._desiredSpeed;
			}

			// Token: 0x06005C8B RID: 23691 RVA: 0x002AAB24 File Offset: 0x002A8D24
			internal bool IsAltBandFullSpeedSufficient(AltBand altBand_0)
			{
				long? speed_Full = altBand_0.Speed_Full;
				float? num = speed_Full.HasValue ? new float?((float)speed_Full.GetValueOrDefault()) : null;
				return (num.HasValue ? new bool?(num.GetValueOrDefault() >= this._desiredSpeed) : null).GetValueOrDefault();
			}

			// Token: 0x06005C8C RID: 23692 RVA: 0x002AAB90 File Offset: 0x002A8D90
			internal bool IsAltBandFlankSpeedSufficient(AltBand altBand_0)
			{
				long? speed_Flank = altBand_0.Speed_Flank;
				float? num = speed_Flank.HasValue ? new float?((float)speed_Flank.GetValueOrDefault()) : null;
				return (num.HasValue ? new bool?(num.GetValueOrDefault() >= this._desiredSpeed) : null).GetValueOrDefault();
			}

			// Token: 0x040030C1 RID: 12481
			public float _desiredSpeed;
		}
	}
}
