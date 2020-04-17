using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 0x020009FA RID: 2554
	public sealed class Aircraft_Kinematics : ActiveUnit_Kinematics
	{
		// Token: 0x06004CF6 RID: 19702 RVA: 0x001E8908 File Offset: 0x001E6B08
		private Aircraft GetParentPlatform()
		{
			if (Information.IsNothing(this.ParentAircraft))
			{
				this.ParentAircraft = (Aircraft)this.activeUnit;
			}
			return this.ParentAircraft;
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x00024952 File Offset: 0x00022B52
		public Aircraft_Kinematics(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x001E8940 File Offset: 0x001E6B40
		public override void SetBingoJokerFuel()
		{
			try
			{
				FuelRec[] fuelRecs = this.activeUnit.GetFuelRecs();
				float num = 0f;
				for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
				{
					FuelRec fuelRec = fuelRecs[i];
					num += (float)fuelRec.MaxQuantity;
				}
				int num2 = 0;
				int num3 = 0;
				float num4 = 0f;
				if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
				{
					num2 = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.activeUnit.m_Scenario).ReservePercentage;
					num3 = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.activeUnit.m_Scenario).ReserveLoiterTime;
					num4 = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.activeUnit.m_Scenario).ReserveLoiterAltitude;
				}
				float num5 = 0f;
				if (num2 > 0)
				{
					num5 = (float)((double)num * ((double)num2 / 100.0));
				}
				if (num3 > 0 && num4 > 0f)
				{
					num5 += this.activeUnit.GetFuelConsumption(ActiveUnit.Throttle.Loiter, null, new float?((float)this.GetSpeed(num4, ActiveUnit.Throttle.Loiter)), new float?(num4), false, true, false, false) * 60f * (float)num3;
				}
				this.activeUnit.GetKinematics().SetReserveFuel(num5);
				if (!Information.IsNothing(this.activeUnit.GetSide(false)))
				{
					float num6 = num - num5;
					Doctrine._FuelState? bingoJokerDoctrine = this.activeUnit.m_Doctrine.GetBingoJokerDoctrine(this.activeUnit.m_Scenario, false, true, false, false);
					byte? b = bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null;
					float bingoJokerFuel;
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						bingoJokerFuel = 0f;
					}
					else
					{
						b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							bingoJokerFuel = (float)((double)num6 * 0.1);
						}
						else
						{
							b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								bingoJokerFuel = (float)((double)num6 * 0.2);
							}
							else
							{
								b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									bingoJokerFuel = (float)((double)num6 * 0.25);
								}
								else
								{
									b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										bingoJokerFuel = (float)((double)num6 * 0.3);
									}
									else
									{
										b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											bingoJokerFuel = (float)((double)num6 * 0.4);
										}
										else
										{
											b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
											if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 6) : null).GetValueOrDefault())
											{
												bingoJokerFuel = (float)((double)num6 * 0.5);
											}
											else
											{
												b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
												if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 7) : null).GetValueOrDefault())
												{
													bingoJokerFuel = (float)((double)num6 * 0.6);
												}
												else
												{
													b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
													if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 8) : null).GetValueOrDefault())
													{
														bingoJokerFuel = (float)((double)num6 * 0.7);
													}
													else
													{
														b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
														if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 9) : null).GetValueOrDefault())
														{
															bingoJokerFuel = (float)((double)num6 * 0.75);
														}
														else
														{
															b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
															if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 10) : null).GetValueOrDefault())
															{
																bingoJokerFuel = (float)((double)num6 * 0.8);
															}
															else
															{
																b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
																if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 11) : null).GetValueOrDefault())
																{
																	bingoJokerFuel = (float)((double)num6 * 0.9);
																}
																else
																{
																	bingoJokerFuel = 0f;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					this.activeUnit.GetKinematics().SetBingoJokerFuel(bingoJokerFuel);
				}
				else
				{
					this.activeUnit.GetKinematics().SetBingoJokerFuel(0f);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200446", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
				{
					Interaction.MsgBox(string.Concat(new string[]
					{
						"Loadout ",
						this.GetParentPlatform().GetLoadout().Name,
						" for aircraft ",
						this.GetParentPlatform().Name,
						" (",
						this.GetParentPlatform().UnitClass,
						") does not exist in the selected database. Please select a new loadout for this aircraft."
					}), MsgBoxStyle.OkOnly, null);
				}
				else
				{
					Interaction.MsgBox(string.Concat(new string[]
					{
						"The loadout for aircraft ",
						this.GetParentPlatform().Name,
						" (",
						this.GetParentPlatform().UnitClass,
						") is nothing."
					}), MsgBoxStyle.OkOnly, null);
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x001E911C File Offset: 0x001E731C
		public override float vmethod_22()
		{
			float float_;
			if (this.float_2 > 0f)
			{
				float_ = this.float_2;
			}
			else
			{
				this.float_2 = this.vmethod_21();
				float_ = this.float_2;
			}
			return float_;
		}

		// Token: 0x06004CFA RID: 19706 RVA: 0x001E9160 File Offset: 0x001E7360
		public override float vmethod_20(bool bool_2, float? Speed_, float? Altitude_)
		{
			float result = 0f;
			try
			{
				ActiveUnit.Throttle throttle_ = ActiveUnit.Throttle.FullStop;
				if (Information.IsNothing(Speed_))
				{
					if (!Information.IsNothing(this.activeUnit.GetAssignedMission(false)))
					{
						if (this.activeUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike)
						{
							if (((Strike)this.activeUnit.GetAssignedMission(false)).strikeType == Strike.StrikeType.Air_Intercept)
							{
								throttle_ = ActiveUnit.Throttle.Full;
							}
							else
							{
								throttle_ = ActiveUnit.Throttle.Cruise;
							}
						}
						else
						{
							throttle_ = ActiveUnit.Throttle.Cruise;
						}
					}
					else
					{
						throttle_ = ActiveUnit.Throttle.Cruise;
					}
				}
				if (Information.IsNothing(Altitude_))
				{
					Altitude_ = new float?(this.activeUnit.GetEngines()[0].GetAltBand(throttle_).MaxAltitude);
				}
				if (Information.IsNothing(Speed_))
				{
					Speed_ = new float?((float)this.GetSpeed(Altitude_.Value, throttle_));
				}
				double num = this.method_18(throttle_, Speed_, Altitude_, bool_2, 0f);
				double? num2 = Speed_.HasValue ? new double?((double)Speed_.GetValueOrDefault()) : null;
				num2 = (num2.HasValue ? new double?(num * num2.GetValueOrDefault()) : null);
				result = (float)(num2.HasValue ? new double?(num2.GetValueOrDefault() / 3600.0) : null).Value;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100451", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004CFB RID: 19707 RVA: 0x001E9328 File Offset: 0x001E7528
		public override float vmethod_21()
		{
			float result = 0f;
			try
			{
				ActiveUnit.Throttle throttle;
				ActiveUnit.Throttle throttle2;
				if (!Information.IsNothing(this.activeUnit.GetAssignedMission(false)))
				{
					if (this.activeUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike)
					{
						if (((Strike)this.activeUnit.GetAssignedMission(false)).strikeType == Strike.StrikeType.Air_Intercept)
						{
							throttle = ActiveUnit.Throttle.Full;
							throttle2 = ActiveUnit.Throttle.Cruise;
						}
						else
						{
							throttle = ActiveUnit.Throttle.Cruise;
							throttle2 = ActiveUnit.Throttle.Cruise;
						}
					}
					else
					{
						throttle = ActiveUnit.Throttle.Cruise;
						throttle2 = ActiveUnit.Throttle.Cruise;
					}
				}
				else
				{
					throttle = ActiveUnit.Throttle.Cruise;
					throttle2 = ActiveUnit.Throttle.Cruise;
				}
				Aircraft parentPlatform = this.GetParentPlatform();
				float float_ = StrikePlanner.smethod_6(ref parentPlatform);
				double num = this.method_18(throttle, null, null, false, float_);
				double num2 = this.method_18(throttle2, null, null, true, float_);
				double num3 = (num + num2) / 2.0;
				if (throttle == throttle2)
				{
					result = (float)(num3 / 2.0 * (double)this.GetSpeed(this.activeUnit.GetEngines()[0].GetAltBand(throttle).MaxAltitude, throttle) / 3600.0);
				}
				else
				{
					result = (float)(num3 / 2.0 * ((double)this.GetSpeed(this.activeUnit.GetEngines()[0].GetAltBand(throttle).MaxAltitude, throttle) / 3600.0 + (double)this.GetSpeed(this.activeUnit.GetEngines()[0].GetAltBand(throttle2).MaxAltitude, throttle2) / 3600.0)) / 2f;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100451", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x001E951C File Offset: 0x001E771C
		public double method_18(ActiveUnit.Throttle throttle_, float? speed_, float? altitude_, bool bool_2, float float_9)
		{
			double result = 0.0;
			try
			{
				FuelRec[] fuelRecs = this.activeUnit.GetFuelRecs();
				float num = 0f;
				for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
				{
					FuelRec fuelRec = fuelRecs[i];
					num += fuelRec.CurrentQuantity;
				}
				num -= this.activeUnit.GetKinematics().GetReserveFuel();
				num -= float_9;
				if (num < 0f)
				{
					result = 0.0;
				}
				else
				{
					AltBand altBand_ = null;
					if (Information.IsNothing(altitude_))
					{
						altBand_ = this.activeUnit.GetEngines()[0].GetAltBand(throttle_);
					}
					result = (double)(num / this.activeUnit.GetFuelConsumption(throttle_, altBand_, speed_, altitude_, bool_2, false, false, false));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100452", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x001E9634 File Offset: 0x001E7834
		public override float vmethod_25(Doctrine._FuelState? fuelState)
		{
			float num = 0f;
			float result;
			try
			{
				FuelRec[] fuelRecs = this.activeUnit.GetFuelRecs();
				float num2 = 0f;
				for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
				{
					FuelRec fuelRec = fuelRecs[i];
					num2 += fuelRec.CurrentQuantity;
				}
				num2 -= this.activeUnit.GetKinematics().GetReserveFuel();
				float num3 = num2 - this.activeUnit.GetKinematics().GetBingoJokerFuel();
				if (num2 < 0f)
				{
					byte? b = fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null;
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						this.GetParentPlatform().FuelQuantityLeftToBingo = 0f;
						this.GetParentPlatform().FuelQuantityLeftToJoker = 0f;
						num = 0f;
						result = num;
						return result;
					}
				}
				Aircraft_Navigator aircraftNavigator = this.GetParentPlatform().GetAircraftNavigator();
				ActiveUnit.Throttle throttle = aircraftNavigator.method_62();
				ActiveUnit.Throttle maxThrottleAvailable = this.activeUnit.GetMaxThrottleAvailable();
				if (throttle > maxThrottleAvailable)
				{
					throttle = maxThrottleAvailable;
				}
				bool flag = false;
				float num4 = aircraftNavigator.GetTransitAltitude(ref flag);
				float maxAltitude = this.activeUnit.GetKinematics().GetMaxAltitude();
				if (num4 > maxAltitude)
				{
					num4 = maxAltitude;
				}
				int speed = this.GetSpeed(num4, throttle);
				float fuelConsumption = this.activeUnit.GetFuelConsumption(throttle, null, new float?((float)speed), new float?(num4), true, false, false, false);
				float num5 = num2 / fuelConsumption;
				float num6 = num3 / fuelConsumption;
				float num7 = num5 * (float)speed / 3600f;
				float num8 = num6 * (float)speed / 3600f;
				double num9 = (double)(num7 - this.GetParentPlatform().DistanceToA2ARefuelingDestinationAircraft);
				double num10 = (double)(num8 - this.GetParentPlatform().DistanceToA2ARefuelingDestinationAircraft);
				this.GetParentPlatform().FuelQuantityLeftToBingo = Math.Max((float)(num9 / (double)num7) * num2, 0f);
				this.GetParentPlatform().FuelQuantityLeftToJoker = Math.Max((float)(num10 / (double)num8) * num3, 0f);
				byte? b2 = fuelState.HasValue ? new byte?((byte)fuelState.GetValueOrDefault()) : null;
				if ((b2.HasValue ? new bool?(b2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					num = num7;
				}
				else
				{
					num = num8;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100453", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = 0f;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x001E9910 File Offset: 0x001E7B10
		public override void vmethod_23(float elapsedTime, bool UseFormUpAltitude = false, bool UseLandingQueueAltitude = false)
		{
			try
			{
				this.activeUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.Normalize(this.activeUnit.GetCurrentHeading() + 3f * elapsedTime));
				this.activeUnit.SetThrottle(ActiveUnit.Throttle.Loiter, null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100454", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x001E99A4 File Offset: 0x001E7BA4
		public void method_19()
		{
			Aircraft a2ARefuelingDestinationAircraft = this.GetParentPlatform().GetAircraftAirOps().GetA2ARefuelingDestinationAircraft();
			if (!Information.IsNothing(a2ARefuelingDestinationAircraft))
			{
				this.GetParentPlatform().SetLatitude(null, a2ARefuelingDestinationAircraft.GetLatitude(null));
				this.GetParentPlatform().SetLongitude(null, a2ARefuelingDestinationAircraft.GetLongitude(null));
				this.GetParentPlatform().SetAltitude_ASL(false, a2ARefuelingDestinationAircraft.GetCurrentAltitude_ASL(false) - 4.572f);
				this.GetParentPlatform().SetCurrentHeading(a2ARefuelingDestinationAircraft.GetCurrentHeading());
				this.GetParentPlatform().SetCurrentSpeed(a2ARefuelingDestinationAircraft.GetCurrentSpeed());
			}
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x001E9A50 File Offset: 0x001E7C50
		public void method_20(float float_9)
		{
			if (this.GetParentPlatform().GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown)
			{
				double num = (double)this.GetSpeed(this.GetParentPlatform().GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Loiter) * Math.Cos((double)this.GetParentPlatform().GetRoll() * 0.0174532925199433);
				if ((double)this.GetParentPlatform().GetCurrentSpeed() < num)
				{
					Aircraft parentPlatform;
					(parentPlatform = this.GetParentPlatform()).SetAltitude_ASL(false, parentPlatform.GetCurrentAltitude_ASL(false) - (float)(9.81 * (double)float_9 * (1.0 - (double)this.GetParentPlatform().GetCurrentSpeed() / num)));
				}
			}
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x001E9AF8 File Offset: 0x001E7CF8
		public override void UpdateUnitPositions(float elapsedTime, bool bool_2, bool bool_3)
		{
			checked
			{
				if (this.activeUnit.IsOperating())
				{
					try
					{
						if (this.activeUnit.IsAircraft)
						{
							if (float.IsNaN(this.activeUnit.GetCurrentHeading()))
							{
								this.activeUnit.SetCurrentHeading(0f);
							}
							if (float.IsNaN(this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0)))
							{
								this.activeUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.activeUnit.GetCurrentHeading());
							}
						}
						if (this.GetParentPlatform().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling)
						{
							this.method_19();
						}
						else if (this.GetParentPlatform().GetUnitStatus() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || !this.activeUnit.IsNotGroupLead() || Information.IsNothing(this.GetParentPlatform().GetAircraftAirOps().GetA2ARefuelingDestinationAircraft()) || this.activeUnit.GetLatitude(null) != this.GetParentPlatform().GetAircraftAirOps().GetA2ARefuelingDestinationAircraft().GetLatitude(null))
						{
							if (this.GetParentPlatform().IsMineSweeper())
							{
								bool flag = false;
								if (!this.GetParentPlatform().IsRTB() || this.GetParentPlatform().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
								{
									Sensor[] noneMCMSensors = this.activeUnit.GetNoneMCMSensors();
									for (int i = 0; i < noneMCMSensors.Length; i++)
									{
										Sensor sensor = noneMCMSensors[i];
										if ((sensor.IsMineCounterMeasure() || sensor.IsMineObstacleSearchCapable()) && sensor.IsEmmitting())
										{
											flag = true;
											break;
										}
									}
								}
								if (flag && this.activeUnit.GetDesiredAltitude() > 76.2000046f)
								{
									this.activeUnit.SetDesiredAltitude(76.2000046f);
									this.activeUnit.SetDesiredSpeed(30f);
								}
							}
							unchecked
							{
								if (this.activeUnit.GetDesiredSpeed() < 0f)
								{
									this.activeUnit.SetDesiredSpeed(-this.activeUnit.GetDesiredSpeed());
								}
								float num = (float)Math.Max(this.activeUnit.GetAltitude_ASL(true, elapsedTime), this.activeUnit.GetTerrainElevation(true, false, false));
								bool arg_309_0;
								if (this.activeUnit.IsTerrainFollowing(this.activeUnit) || (num <= 0f && (num != 0f || this.activeUnit.GetDesiredAltitude() == this.activeUnit.GetCurrentAltitude_ASL(false))))
								{
									if (this.activeUnit.IsTerrainFollowing(this.activeUnit))
									{
										if (num > 0f)
										{
											goto IL_28F;
										}
										if (num == 0f)
										{
											if (this.activeUnit.GetDesiredAltitude_TerrainFollowing() != this.activeUnit.GetCurrentAltitude_ASL(false))
											{
												goto IL_28F;
											}
										}
									}
									arg_309_0 = (!this.activeUnit.IsNotGroupLead() || Information.IsNothing(this.activeUnit.GetParentGroup(false).GetGroupLead()) || !this.activeUnit.GetParentGroup(false).GetGroupLead().IsTerrainFollowing(this.activeUnit) || (num <= 0f && (num != 0f || this.activeUnit.GetDesiredAltitude_TerrainFollowing() == this.activeUnit.GetCurrentAltitude_ASL(false))));
									goto IL_309;
								}
								IL_28F:
								arg_309_0 = false;
								IL_309:
								if (!arg_309_0)
								{
									bool flag2;
									float desiredAltitude_TerrainFollowing;
									if (this.activeUnit.IsNotGroupLead() && !Information.IsNothing(this.activeUnit.GetParentGroup(false).GetGroupLead()) && !this.activeUnit.GetKinematics().GetDesiredAltitudeOverride())
									{
										flag2 = this.activeUnit.GetParentGroup(false).GetGroupLead().IsTerrainFollowing(this.activeUnit.GetParentGroup(false).GetGroupLead());
										desiredAltitude_TerrainFollowing = this.activeUnit.GetDesiredAltitude_TerrainFollowing();
									}
									else
									{
										flag2 = this.activeUnit.IsTerrainFollowing(this.activeUnit);
										desiredAltitude_TerrainFollowing = this.activeUnit.GetDesiredAltitude_TerrainFollowing();
									}
									float desiredAltitude_;
									if (flag2)
									{
										desiredAltitude_ = desiredAltitude_TerrainFollowing + num;
									}
									else
									{
										desiredAltitude_ = this.activeUnit.GetDesiredAltitude();
									}
									float? allowedMinAltitude_ = null;
									if (this.GetParentPlatform().GetCurrentAltitude_ASL(false) < 8850f)
									{
										allowedMinAltitude_ = new float?(this.GetParentPlatform().GetAllowedMinAltitude());
									}
									this.SetAltitude_ASL(elapsedTime, desiredAltitude_, allowedMinAltitude_);
								}
								base.UpdateUnitPositions(elapsedTime, true, false);
							}
						}
						if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
						{
							WeaponRec[] weaponRecArray = this.GetParentPlatform().GetLoadout().WeaponRecArray;
							for (int j = 0; j < weaponRecArray.Length; j++)
							{
								Weapon weapon = weaponRecArray[j].GetWeapon(this.GetParentPlatform().m_Scenario);
								weapon.SetLongitude(null, this.GetParentPlatform().GetLongitude(null));
								weapon.SetLatitude(null, this.GetParentPlatform().GetLatitude(null));
								weapon.SetAltitude_ASL(false, this.GetParentPlatform().GetCurrentAltitude_ASL(false));
								weapon.SetCurrentHeading(this.GetParentPlatform().GetCurrentHeading());
								weapon.SetCurrentSpeed(this.GetParentPlatform().GetCurrentSpeed());
							}
						}
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
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100455", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x001EA124 File Offset: 0x001E8324
		public override float vmethod_9(ActiveUnit.Throttle throttle_0, float float_9)
		{
			float num = (float)((double)this.GetParentPlatform().Agility * 0.05 * (double)this.GetSpeed(float_9, throttle_0));
			switch (this.activeUnit.GetEngines()[0].PropulsionType)
			{
			case Engine._PropulsionType.Turbojet:
			case Engine._PropulsionType.Turbofan:
				num = (float)(1.2 * (double)num);
				break;
			case Engine._PropulsionType.Turboprop:
			case Engine._PropulsionType.HeloTurboshaft:
				num = (float)(0.8 * (double)num);
				break;
			}
			return num;
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x001EA1B0 File Offset: 0x001E83B0
		public override int GetSpeed(float Altitude_ASL, ActiveUnit.Throttle throttle_)
		{
			Aircraft_Kinematics.AltBandComparator altBandComparator = new Aircraft_Kinematics.AltBandComparator();
			altBandComparator.altBand = null;
			int result = 0;
			try
			{
				if (throttle_ == ActiveUnit.Throttle.FullStop)
				{
					result = 0;
				}
				else
				{
					altBandComparator.altBand = this.GetAltBand(Altitude_ASL, null);
					if (Information.IsNothing(altBandComparator.altBand))
					{
						result = 0;
					}
					else
					{
						IEnumerable<Engine> source = this.activeUnit.GetEngines().Where(Aircraft_Kinematics.IsOperational);
						if (source.Count<Engine>() == 0)
						{
							result = 0;
						}
						else
						{
							Engine engine = source.ElementAtOrDefault(0);
							AltBand[] altBands = engine.altBands;
							if (engine.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
							{
								result = 0;
							}
							else if (altBands.Length == 0)
							{
								result = 0;
							}
							else
							{
								float num = 0f;
								switch (throttle_)
								{
								case ActiveUnit.Throttle.FullStop:
									num = 0f;
									break;
								case ActiveUnit.Throttle.Loiter:
									num = (float)altBandComparator.altBand.Speed_Loiter;
									break;
								case ActiveUnit.Throttle.Cruise:
									if (altBandComparator.altBand.Speed_Cruise > 0)
									{
										num = (float)altBandComparator.altBand.Speed_Cruise;
									}
									else
									{
										num = (float)altBandComparator.altBand.Speed_Loiter;
									}
									break;
								case ActiveUnit.Throttle.Full:
									if (!altBandComparator.altBand.Speed_Full.HasValue)
									{
										num = (float)altBandComparator.altBand.Speed_Cruise;
									}
									else
									{
										num = (float)altBandComparator.altBand.Speed_Full.Value;
									}
									break;
								case ActiveUnit.Throttle.Flank:
									if (!altBandComparator.altBand.Speed_Flank.HasValue)
									{
										if (!altBandComparator.altBand.Speed_Full.HasValue)
										{
											num = (float)altBandComparator.altBand.Speed_Cruise;
										}
										else
										{
											num = (float)altBandComparator.altBand.Speed_Full.Value;
										}
									}
									else
									{
										num = (float)altBandComparator.altBand.Speed_Flank.Value;
									}
									break;
								}
								int num2 = (int)Math.Round((double)num);
								if (altBandComparator.altBand != base.method_11(engine))
								{
									AltBand altBand = altBands.Where(new Func<AltBand, bool>(altBandComparator.IsHigherThanMe)).OrderBy(Aircraft_Kinematics.GetMaxAltitudeOf).ElementAtOrDefault(0);
									if (!Information.IsNothing(altBand))
									{
										float num3 = 0f;
										switch (throttle_)
										{
										case ActiveUnit.Throttle.FullStop:
											num3 = 0f;
											break;
										case ActiveUnit.Throttle.Loiter:
											num3 = (float)altBand.Speed_Loiter;
											break;
										case ActiveUnit.Throttle.Cruise:
											num3 = (float)altBand.Speed_Cruise;
											break;
										case ActiveUnit.Throttle.Full:
											if (!altBand.Speed_Full.HasValue)
											{
												num3 = (float)altBand.Speed_Cruise;
											}
											else
											{
												num3 = (float)altBand.Speed_Full.Value;
											}
											break;
										case ActiveUnit.Throttle.Flank:
											if (!altBand.Speed_Flank.HasValue)
											{
												if (!altBand.Speed_Full.HasValue)
												{
													num3 = (float)altBand.Speed_Cruise;
												}
												else
												{
													num3 = (float)altBand.Speed_Full.Value;
												}
											}
											else
											{
												num3 = (float)altBand.Speed_Flank.Value;
											}
											break;
										}
										num2 = (int)Math.Round((double)(num3 + (Altitude_ASL - altBand.MinAltitude) * (num - num3) / (altBandComparator.altBand.MinAltitude - altBand.MinAltitude)));
									}
								}
								double num4 = (double)this.GetParentPlatform().GetEngines().Where(Aircraft_Kinematics.IsOperational).Count<Engine>() / (double)this.GetParentPlatform().GetEngines().Count;
								if (num4 < 1.0)
								{
									num2 = (int)Math.Round((double)num2 * Math.Sqrt(num4));
								}
								num2 = (int)Math.Round((double)ActiveUnit_Kinematics.smethod_1((float)num2));
								result = num2;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101340", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x001EA590 File Offset: 0x001E8790
		public override float vmethod_8(ActiveUnit.Throttle throttle, float altitude_ASL, float speed)
		{
			float result = 0f;
			try
			{
				float num = this.vmethod_9(throttle, altitude_ASL);
				float num2 = Math.Min(1f, speed / (float)this.GetSpeed(altitude_ASL, throttle));
				float num3 = num * (1f - num2);
				float num4 = altitude_ASL / this.activeUnit.GetKinematics().GetMaxAltitude();
				Engine._PropulsionType propulsionType = this.activeUnit.GetEngines()[0].PropulsionType;
				if (propulsionType != Engine._PropulsionType.Turbojet)
				{
					if (propulsionType == Engine._PropulsionType.Turbofan)
					{
						num3 = (float)((double)num3 * (1.5 - (double)(num4 / 2f)));
					}
				}
				else
				{
					num3 *= 1f + num4 / 2f;
				}
				double num5 = (double)this.GetParentPlatform().GetEngines().Where(Aircraft_Kinematics.IsOperational).Count<Engine>() / (double)this.GetParentPlatform().GetEngines().Count;
				num3 = (float)((double)num3 * num5 * num5);
				num3 = (float)(0.75 * (double)num3 + 0.25 * (double)num3 * (double)(1f - this.GetParentPlatform().GetWeightFraction()));
				result = num3;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100456", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x001EA708 File Offset: 0x001E8908
		public override void vmethod_41(double double_0, float elapsedTime)
		{
			try
			{
				if (this.activeUnit.GetDesiredTurnRate() != ActiveUnit._TurnRate.const_1 && (long)Math.Round((double)Math.Abs(this.activeUnit.GetCurrentHeading() - this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0))) > 5L)
				{
					float num = (float)(0.6 * double_0 * Math.Pow((double)Class263.GetIRCrossSectionModifier((double)this.activeUnit.GetCurrentAltitude_ASL(false), (double)this.activeUnit.GetCurrentSpeed()), 3.0));
					this.activeUnit.SetCurrentSpeed(this.activeUnit.GetCurrentSpeed() - num);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100457", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x001EA800 File Offset: 0x001E8A00
		public override void vmethod_24(float elapsedTime)
		{
			try
			{
				double num;
				if (this.activeUnit.GetDesiredTurnRate() == ActiveUnit._TurnRate.const_1 && this.activeUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.EngagedDefensive && this.activeUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.EngagedDefensive)
				{
					if (!Information.IsNothing(this.activeUnit.GetNavigator().GetFlight()))
					{
						num = (double)(ActiveUnit_Kinematics.smethod_2(this.activeUnit.GetDesiredTurnRate_Navigation(), this.activeUnit.GetCurrentSpeed()) * elapsedTime);
					}
					else
					{
						num = (double)(this.GetTurnRate() * elapsedTime);
					}
				}
				else
				{
					num = (double)(this.GetTurnRate() * elapsedTime);
				}
				Misc.Enum102 @enum = Misc.smethod_63(this.activeUnit.GetCurrentHeading(), this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0));
				if (@enum != Misc.Enum102.const_0)
				{
					if (@enum == Misc.Enum102.const_1)
					{
						this.activeUnit.SetCurrentHeading((float)Math2.Normalize((double)this.activeUnit.GetCurrentHeading() + num));
						if (base.method_5(this.activeUnit.GetCurrentHeading(), this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0)))
						{
							this.activeUnit.SetCurrentHeading(this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0));
						}
					}
				}
				else
				{
					this.activeUnit.SetCurrentHeading((float)Math2.Normalize((double)this.activeUnit.GetCurrentHeading() - num));
					if (base.method_4(this.activeUnit.GetCurrentHeading(), this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0)))
					{
						this.activeUnit.SetCurrentHeading(this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0));
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100456464561", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x001EA9D0 File Offset: 0x001E8BD0
		public int method_21()
		{
			return (int)Math.Round(1.5 * (double)this.activeUnit.GetKinematics().GetSpeed(this.activeUnit.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Loiter));
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x001EAA10 File Offset: 0x001E8C10
		public float GetAgilityAtAltitude()
		{
			float result;
			if (this.GetParentPlatform().GetCurrentAltitude_ASL(false) <= 3000f)
			{
				result = this.GetParentPlatform().Agility;
			}
			else
			{
				float num = 0.75f;
				if (this.GetParentPlatform().Supermanouverability)
				{
					num = 0.5f;
				}
				float num2 = this.GetMaxAltitude() - this.GetParentPlatform().GetCurrentAltitude_ASL(false);
				float num3 = this.GetParentPlatform().GetCurrentAltitude_ASL(false) - 3000f;
				float num4 = this.GetParentPlatform().Agility * num * (num3 / num2);
				result = (float)((double)Math.Max(this.GetParentPlatform().Agility * (1f - num), this.GetParentPlatform().Agility - num4));
			}
			return result;
		}

		// Token: 0x06004D09 RID: 19721 RVA: 0x001EAACC File Offset: 0x001E8CCC
		public override float GetTurnRate()
		{
			float result = 0f;
			try
			{
				Aircraft._AircraftCategory category = this.GetParentPlatform().Category;
				if (category - Aircraft._AircraftCategory.Helicopter > 1)
				{
					if (category != Aircraft._AircraftCategory.Airship)
					{
						if (Math.Abs(this.desiredSpeed - this.activeUnit.GetCurrentSpeed()) > 30f)
						{
							float num = this.GetParentPlatform().Agility * 4f;
							float num2 = (float)this.activeUnit.GetKinematics().GetSpeed(this.activeUnit.GetCurrentAltitude_ASL(false), this.activeUnit.GetMaxThrottleAvailable());
							float num3;
							if (this.activeUnit.GetCurrentSpeed() <= (float)this.method_21())
							{
								num3 = num * Math.Max(3f, 2f * (this.activeUnit.GetCurrentSpeed() / (float)this.method_21()));
							}
							else if ((double)Class263.GetIRCrossSectionModifier((double)this.activeUnit.GetCurrentAltitude_ASL(false), (double)this.activeUnit.GetCurrentSpeed()) <= 1.0)
							{
								num3 = Math.Max(num * (1f - (this.activeUnit.GetCurrentSpeed() - (float)this.method_21()) / (num2 - (float)this.method_21())), 3f);
							}
							else if (this.GetParentPlatform().Supermanouverability)
							{
								num3 = (float)((double)num - 0.25 * (double)num * (double)(this.activeUnit.GetCurrentSpeed() - (float)this.method_21()) / (double)(num2 - (float)this.method_21()));
							}
							else
							{
								num3 = (float)((double)num - 0.5 * (double)num * (double)(this.activeUnit.GetCurrentSpeed() - (float)this.method_21()) / (double)(num2 - (float)this.method_21()));
							}
							GlobalVariables.ProficiencyLevel? proficiencyLevel = this.activeUnit.GetProficiencyLevel();
							int? num4 = proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num3 = (float)((double)num3 * 0.4);
							}
							else
							{
								num4 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									num3 = (float)((double)num3 * 0.6);
								}
								else
								{
									num4 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										num3 = (float)((double)num3 * 0.8);
									}
									else
									{
										num4 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
										if (!(num4.HasValue ? new bool?(num4.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											num4 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
											if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												num3 = (float)((double)num3 * 1.2);
											}
										}
									}
								}
							}
							num3 = Math.Max(num3, 3f);
							this.desiredSpeed = this.activeUnit.GetCurrentSpeed();
							this.turnRate = num3;
						}
						else if (this.turnRate < 3f)
						{
							this.turnRate = 3f;
						}
					}
					else
					{
						this.turnRate = 1f;
					}
				}
				else
				{
					this.turnRate = 45f;
				}
				result = this.turnRate;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100458", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004D0A RID: 19722 RVA: 0x001EAF58 File Offset: 0x001E9158
		public override float GetClimbRate()
		{
			this.ClimbRateAvailable = (float)(0.4 * (double)base.GetClimbRate() + 0.6 * (double)base.GetClimbRate() * (double)(1f - this.GetParentPlatform().GetWeightFraction()));
			double num = (double)this.GetParentPlatform().GetEngines().Where(Aircraft_Kinematics.IsOperational).Count<Engine>() / (double)this.GetParentPlatform().GetEngines().Count;
			this.ClimbRateAvailable = (float)((double)this.ClimbRateAvailable * num);
			return this.ClimbRateAvailable;
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x00024971 File Offset: 0x00022B71
		public override void SetClimbRate(float value)
		{
			base.SetClimbRate(value);
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x001EAFE8 File Offset: 0x001E91E8
		public override float vmethod_19()
		{
			this.float_6 = (float)(0.4 * (double)base.vmethod_19() + 0.6 * (double)base.vmethod_19() * (double)(1f + this.GetParentPlatform().GetWeightFraction()));
			return this.float_6;
		}

		// Token: 0x04002469 RID: 9321
		public static Func<Engine, bool> IsOperational = (Engine engine_0) => engine_0.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational;

		// Token: 0x0400246A RID: 9322
		public static Func<AltBand, float> GetMaxAltitudeOf = (AltBand altBand_0) => altBand_0.MaxAltitude;

		// Token: 0x0400246B RID: 9323
		private Aircraft ParentAircraft;

		// Token: 0x0400246C RID: 9324
		private float ClimbRateAvailable = 0f;

		// Token: 0x0400246D RID: 9325
		private float float_6 = 0f;

		// Token: 0x0400246E RID: 9326
		private float turnRate;

		// Token: 0x0400246F RID: 9327
		private float desiredSpeed;

		// Token: 0x020009FB RID: 2555
		[CompilerGenerated]
		public new sealed class AltBandComparator
		{
			// Token: 0x06004D10 RID: 19728 RVA: 0x0002497A File Offset: 0x00022B7A
			internal bool IsHigherThanMe(AltBand altBand_)
			{
				return altBand_.MinAltitude >= this.altBand.MaxAltitude;
			}

			// Token: 0x04002472 RID: 9330
			public AltBand altBand;
		}
	}
}
