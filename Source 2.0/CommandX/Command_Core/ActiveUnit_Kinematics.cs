using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 动力学
	public class ActiveUnit_Kinematics
	{
		// Token: 0x06002525 RID: 9509 RVA: 0x000E3B00 File Offset: 0x000E1D00
		public virtual void Save(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteElementString("AMV", XmlConvert.ToString(this.ActualMovementVector));
				if (this.DesiredSpeedOverride.HasValue)
				{
					xmlWriter_0.WriteElementString("DSO", this.DesiredSpeedOverride.ToString());
				}
				xmlWriter_0.WriteElementString("DAO", this.DesiredAltitudeOverride.ToString());
				xmlWriter_0.WriteElementString("ReserveFuel", this.ReserveFuel.ToString());
				xmlWriter_0.WriteElementString("SP", ((byte)this.GetSpeedPreset()).ToString());
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "SADC";
				short sprintAndDriftControl = (short)this.SprintAndDriftControl;
				xmlWriter.WriteElementString(localName, sprintAndDriftControl.ToString());
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100166", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x000E3C0C File Offset: 0x000E1E0C
		public static void Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, ActiveUnit activeUnit_1)
		{
			IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					XmlNode xmlNode = (XmlNode)enumerator.Current;
					try
					{
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1633936287u)
						{
							if (num <= 316182301u)
							{
								if (num != 154738112u)
								{
									if (num != 316182301u)
									{
										continue;
									}
									if (Operators.CompareString(name, "DSO", false) != 0)
									{
										continue;
									}
								}
								else if (Operators.CompareString(name, "DesiredSpeedOverride", false) != 0)
								{
									continue;
								}
								if (Operators.CompareString(xmlNode.InnerText, true.ToString(), false) == 0)
								{
									activeUnit_1.GetKinematics().DesiredSpeedOverride = new float?(activeUnit_1.GetDesiredSpeed());
									continue;
								}
								if (Operators.CompareString(xmlNode.InnerText, false.ToString(), false) == 0)
								{
									activeUnit_1.GetKinematics().DesiredSpeedOverride = null;
									continue;
								}
								activeUnit_1.GetKinematics().DesiredSpeedOverride = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
								continue;
							}
							else if (num != 856023323u)
							{
								if (num != 1633936287u)
								{
									continue;
								}
								if (Operators.CompareString(name, "AMV", false) != 0)
								{
									continue;
								}
								goto IL_2A8;
							}
							else if (Operators.CompareString(name, "DAO", false) != 0)
							{
								continue;
							}
						}
						else if (num <= 2609190255u)
						{
							if (num != 1728224374u)
							{
								if (num != 2609190255u)
								{
									continue;
								}
								if (Operators.CompareString(name, "ReserveFuel", false) == 0)
								{
									activeUnit_1.GetKinematics().ReserveFuel = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "SP", false) == 0)
								{
									activeUnit_1.GetKinematics().SetSpeedPreset((ActiveUnit_Kinematics._SpeedPreset)Conversions.ToByte(xmlNode.InnerText));
									continue;
								}
								continue;
							}
						}
						else if (num != 2788980997u)
						{
							if (num != 3126726711u)
							{
								if (num != 3765802604u)
								{
									continue;
								}
								if (Operators.CompareString(name, "SADC", false) == 0)
								{
									activeUnit_1.GetKinematics().SprintAndDriftControl = (ActiveUnit_Kinematics._SprintAndDriftControl)Conversions.ToShort(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "DesiredAltitudeOverride", false) != 0)
							{
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "ActualMovementVector", false) == 0)
							{
								goto IL_2A8;
							}
							continue;
						}
						activeUnit_1.GetKinematics().DesiredAltitudeOverride = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_2A8:
						activeUnit_1.GetKinematics().ActualMovementVector = XmlConvert.ToSingle(xmlNode.InnerText);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100167", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			try
			{
				if (activeUnit_1.GetKinematics().GetReserveFuel() == 0f && activeUnit_1.IsAircraft)
				{
					activeUnit_1.GetKinematics().SetBingoJokerFuel();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100168", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x000E3FFC File Offset: 0x000E21FC
		public virtual ActiveUnit_Kinematics._SpeedPreset GetSpeedPreset()
		{
			return this.SpeedPreset;
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x000E4014 File Offset: 0x000E2214
		public virtual void SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset SP_)
		{
			this.SpeedPreset = SP_;
			try
			{
				if (this.activeUnit.IsAircraft && this.activeUnit.GetKinematics().GetSpeedPreset() == ActiveUnit_Kinematics._SpeedPreset.FullStop && !((Aircraft)this.activeUnit).IsRotaryWing(false))
				{
					this.activeUnit.GetKinematics().SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset.None);
				}
				if (SP_ != ActiveUnit_Kinematics._SpeedPreset.None)
				{
					this.activeUnit.GetKinematics().SetDesiredSpeedOverride(new float?(this.activeUnit.GetDesiredSpeed()));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100169", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x000E40E4 File Offset: 0x000E22E4
		public void SetThrottle()
		{
			if (!Information.IsNothing(this.activeUnit) && this.activeUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
			{
				switch (this.GetSpeedPreset())
				{
				case ActiveUnit_Kinematics._SpeedPreset.FullStop:
					this.activeUnit.SetThrottle(ActiveUnit.Throttle.FullStop, null);
					break;
				case ActiveUnit_Kinematics._SpeedPreset.Loiter:
					this.activeUnit.SetThrottle(ActiveUnit.Throttle.Loiter, null);
					break;
				case ActiveUnit_Kinematics._SpeedPreset.Cruise:
					this.activeUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
					break;
				case ActiveUnit_Kinematics._SpeedPreset.Full:
					this.activeUnit.SetThrottle(ActiveUnit.Throttle.Full, null);
					break;
				case ActiveUnit_Kinematics._SpeedPreset.Flank:
					this.activeUnit.SetThrottle(ActiveUnit.Throttle.Flank, null);
					break;
				}
				this.activeUnit.GetKinematics().SetDesiredSpeedOverride(new float?((float)this.activeUnit.GetKinematics().GetSpeed(this.activeUnit.GetCurrentAltitude_ASL(false), (ActiveUnit.Throttle)this.GetSpeedPreset())));
			}
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x00015376 File Offset: 0x00013576
		public virtual void SetReserveFuel(float float_5)
		{
			this.ReserveFuel = float_5;
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x000E41F0 File Offset: 0x000E23F0
		public virtual float GetReserveFuel()
		{
			return this.ReserveFuel;
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x0001537F File Offset: 0x0001357F
		public virtual void SetBingoJokerFuel(float float_5)
		{
			this.BingoJokerFuel = float_5;
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x000E4208 File Offset: 0x000E2408
		public virtual float GetBingoJokerFuel()
		{
			return this.BingoJokerFuel;
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x00015388 File Offset: 0x00013588
		public virtual void SetBingoJokerFuel()
		{
			this.SetReserveFuel(0f);
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x000097CF File Offset: 0x000079CF
		public virtual float vmethod_8(ActiveUnit.Throttle throttle, float altitude_ASL, float speed)
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x000097CF File Offset: 0x000079CF
		public virtual float vmethod_9(ActiveUnit.Throttle throttle_0, float float_5)
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x000E4220 File Offset: 0x000E2420
		public virtual float? GetDesiredSpeedOverride()
		{
			return this.DesiredSpeedOverride;
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x000E4238 File Offset: 0x000E2438
		public virtual void SetDesiredSpeedOverride(float? value)
		{
			try
			{
				this.DesiredSpeedOverride = value;
				if (Information.IsNothing(value))
				{
					this.activeUnit.GetKinematics().SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset.None);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100170", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00015395 File Offset: 0x00013595
		public virtual bool GetDesiredAltitudeOverride()
		{
			return this.DesiredAltitudeOverride;
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x000E42BC File Offset: 0x000E24BC
		public virtual void SetDesiredAltitudeOverride(bool value)
		{
			try
			{
				this.DesiredAltitudeOverride = value;
				if (!value)
				{
					if (this.activeUnit.IsSubmarine)
					{
						((Submarine)this.activeUnit).GetSubmarineAI().SetDepthPreset(ActiveUnit_AI._DepthPreset.None);
					}
					if (this.activeUnit.IsAircraft)
					{
						((Aircraft)this.activeUnit).GetAircraftAI().SetAltitudePreset(ActiveUnit_AI._AltitudePreset.None);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100171", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x000E4370 File Offset: 0x000E2570
		public virtual float GetClimbRate()
		{
			return this.ClimbRate;
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x0001539D File Offset: 0x0001359D
		public virtual void SetClimbRate(float value)
		{
			this.ClimbRate = value;
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000E4388 File Offset: 0x000E2588
		public float method_1()
		{
			float result;
			if (this.activeUnit.IsOfAirLaunchedGuidedWeapon())
			{
				if (this.activeUnit.GetPitch() <= 0f)
				{
					result = 0f;
				}
				else
				{
					result = (float)Math.Min((double)this.GetClimbRate(), (double)this.activeUnit.GetCurrentSpeed() * 0.514444 * Math2.Sin_D((double)this.activeUnit.GetPitch()));
				}
			}
			else
			{
				result = this.GetClimbRate();
			}
			return result;
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x000B1010 File Offset: 0x000AF210
		public virtual float vmethod_16()
		{
			return 0f;
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x000B1010 File Offset: 0x000AF210
		public virtual float vmethod_17()
		{
			return 0f;
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x000B1010 File Offset: 0x000AF210
		public virtual float vmethod_18()
		{
			return 0f;
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x000E440C File Offset: 0x000E260C
		public virtual float vmethod_19()
		{
			float result;
			if (this.activeUnit.IsAircraft && ((Aircraft)this.activeUnit).IsRotaryWingAircraft())
			{
				result = this.ClimbRate * 10f;
			}
			else
			{
				result = this.ClimbRate * 3f;
			}
			return result;
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x000E4464 File Offset: 0x000E2664
		public float method_2()
		{
			float result;
			if (this.activeUnit.IsOfAirLaunchedGuidedWeapon())
			{
				if (this.activeUnit.GetPitch() >= 0f)
				{
					result = 0f;
				}
				else
				{
					result = (float)Math.Min((double)this.vmethod_19(), (double)this.activeUnit.GetCurrentSpeed() * 0.514444 * Math2.Sin_D((double)Math.Abs(this.activeUnit.GetPitch())));
				}
			}
			else
			{
				result = this.vmethod_19();
			}
			return result;
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x000E44EC File Offset: 0x000E26EC
		public virtual float vmethod_20(bool bool_2, float? nullable_2, float? nullable_3)
		{
			return 3.40282347E+38f;
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x000E44EC File Offset: 0x000E26EC
		public virtual float vmethod_21()
		{
			return 3.40282347E+38f;
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x000E44EC File Offset: 0x000E26EC
		public virtual float vmethod_22()
		{
			return 3.40282347E+38f;
		}

		// 构造函数
		public ActiveUnit_Kinematics(ref ActiveUnit activeUnit_1)
		{
			this.ReserveFuel = 0f;
			this.BingoJokerFuel = 0f;
			this.SpeedPreset = ActiveUnit_Kinematics._SpeedPreset.None;
			this.activeUnit = activeUnit_1;
		}

		// 重置最大速度
		public void ResetMaxSpeed()
		{
			this.MaxSpeed = null;
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x000E4550 File Offset: 0x000E2750
		public virtual void vmethod_23(float elapsedTime, bool UseFormUpAltitude = false, bool UseLandingQueueAltitude = false)
		{
			this.activeUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_1, Math2.Normalize(this.activeUnit.GetCurrentHeading() + 3f * elapsedTime));
			this.activeUnit.SetThrottle(ActiveUnit.Throttle.Loiter, null);
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x000E4598 File Offset: 0x000E2798
		public virtual void vmethod_24(float elapsedTime)
		{
			try
			{
				float num = this.activeUnit.GetKinematics().GetTurnRate() * elapsedTime;
				Misc.Enum102 @enum = Misc.smethod_63(this.activeUnit.GetCurrentHeading(), this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0));
				if (@enum != Misc.Enum102.const_0)
				{
					if (@enum == Misc.Enum102.const_1)
					{
						this.activeUnit.SetCurrentHeading(Math2.Normalize(this.activeUnit.GetCurrentHeading() + num));
						if (this.method_5(this.activeUnit.GetCurrentHeading(), this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0)))
						{
							this.activeUnit.SetCurrentHeading(this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0));
						}
					}
				}
				else
				{
					this.activeUnit.SetCurrentHeading(Math2.Normalize(this.activeUnit.GetCurrentHeading() - num));
					if (this.method_4(this.activeUnit.GetCurrentHeading(), this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0)))
					{
						this.activeUnit.SetCurrentHeading(this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0));
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100172", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x000153B4 File Offset: 0x000135B4
		protected bool method_4(float float_5, float float_6)
		{
			return Math2.Normalize(float_5 - float_6) > 180f;
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x000153C5 File Offset: 0x000135C5
		protected bool method_5(float float_5, float float_6)
		{
			return Math2.Normalize(float_5 - float_6) <= 180f;
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x000E46E4 File Offset: 0x000E28E4
		public virtual float vmethod_25(Doctrine._FuelState? FuelState_)
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
				ex2.Data.Add("Error at 100175", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x000E47E0 File Offset: 0x000E29E0
		public float method_6(float float_5, ActiveUnit.Throttle throttle_0, float float_6, float? nullable_2, bool bool_2, bool bool_3)
		{
			float result = 0f;
			try
			{
				if (float_5 == 0f)
				{
					result = 0f;
				}
				else
				{
					float? num = nullable_2;
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0f) : null).GetValueOrDefault())
					{
						result = 0f;
					}
					else if (this.activeUnit.GetEngines().Count == 0)
					{
						result = 0f;
					}
					else
					{
						float fuelConsumption = this.activeUnit.GetFuelConsumption(throttle_0, null, nullable_2, new float?(float_6), false, false, bool_2, bool_3);
						float? num2 = nullable_2;
						num2 = (num2.HasValue ? new float?(float_5 / num2.GetValueOrDefault()) : null);
						result = (float)((long)Math.Round((double)(num2.HasValue ? new float?(num2.GetValueOrDefault() * 3600f) : null).Value)) * fuelConsumption;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100176", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x000E495C File Offset: 0x000E2B5C
		public float method_7(int int_0, ActiveUnit.Throttle throttle_0, float float_5, float? nullable_2, bool bool_2)
		{
			float result = 0f;
			try
			{
				if (int_0 == 0)
				{
					result = 0f;
				}
				else if (this.activeUnit.GetEngines().Count == 0)
				{
					result = 0f;
				}
				else
				{
					float fuelConsumption = this.activeUnit.GetFuelConsumption(throttle_0, null, nullable_2, new float?(float_5), false, false, bool_2, false);
					result = (float)int_0 * fuelConsumption;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101248", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x000E4A14 File Offset: 0x000E2C14
		public int method_8(float altitude_ASL)
		{
			int result = 0;
			if (altitude_ASL < -500f)
			{
				result = 2147483647;
			}
			else
			{
				switch (this.activeUnit.method_88())
				{
				case GlobalVariables.Enum104.const_0:
					if (altitude_ASL > -200f)
					{
						result = 8;
					}
					else if (altitude_ASL > -300f)
					{
						result = 13;
					}
					else if (altitude_ASL > -400f)
					{
						result = 25;
					}
					else
					{
						result = 2147483647;
					}
					break;
				case GlobalVariables.Enum104.const_1:
					if (altitude_ASL > -100f)
					{
						result = 8;
					}
					else if (altitude_ASL > -200f)
					{
						result = 13;
					}
					else if (altitude_ASL > -300f)
					{
						result = 25;
					}
					else
					{
						result = 2147483647;
					}
					break;
				case GlobalVariables.Enum104.const_2:
					if (altitude_ASL > -50f)
					{
						result = 8;
					}
					else if (altitude_ASL > -100f)
					{
						result = 13;
					}
					else if (altitude_ASL > -200f)
					{
						result = 25;
					}
					else
					{
						result = 2147483647;
					}
					break;
				case GlobalVariables.Enum104.const_3:
					if (altitude_ASL > -50f)
					{
						result = 13;
					}
					else if (altitude_ASL > -100f)
					{
						result = 25;
					}
					else
					{
						result = 2147483647;
					}
					break;
				case GlobalVariables.Enum104.const_4:
					if (altitude_ASL > -50f)
					{
						result = 25;
					}
					else
					{
						result = 2147483647;
					}
					break;
				}
			}
			return result;
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x000E4B7C File Offset: 0x000E2D7C
		public virtual float GetMaxAltitude()
		{
			float result = 0f;
			try
			{
				float num = 0f;
				using (IEnumerator<Engine> enumerator = this.activeUnit.GetEngines().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						AltBand[] altBands = enumerator.Current.altBands;
						int num2 = altBands.Length - 1;
						for (int i = 0; i <= num2; i++)
						{
							AltBand altBand = altBands[i];
							if (altBand.MaxAltitude > num)
							{
								num = altBand.MaxAltitude;
							}
						}
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100177", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x000E4C6C File Offset: 0x000E2E6C
		public virtual float GetMinAltitude()
		{
			float num = 0f;
			float result;
			try
			{
				float num2 = 9999999f;
				foreach (Engine current in this.activeUnit.GetEngines())
				{
					if (current.altBands.Length == 0)
					{
						num = 0f;
						result = num;
						return result;
					}
					AltBand[] altBands = current.altBands;
					int num3 = altBands.Length - 1;
					for (int i = 0; i <= num3; i++)
					{
						AltBand altBand = altBands[i];
						if (altBand.MinAltitude <= num2)
						{
							num2 = altBand.MinAltitude;
						}
					}
				}
				num = num2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100178", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x000E4D78 File Offset: 0x000E2F78
		public virtual float GetMinSpeed(float float_5)
		{
			float result = 0f;
			try
			{
				if (!this.activeUnit.IsFacility && !this.activeUnit.IsShip && !this.activeUnit.IsSubmarine)
				{
					if (this.activeUnit.IsAircraft && ((Aircraft)this.activeUnit).IsRotaryWingAircraft())
					{
						result = 0f;
					}
					else if (this.activeUnit.GetEngines().Count == 0)
					{
						result = 0f;
					}
					else if (this.activeUnit.GetEngines()[0].GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
					{
						result = 0f;
					}
					else if (this.activeUnit.GetEngines()[0].altBands.Length == 0)
					{
						result = 0f;
					}
					else
					{
						AltBand altBand = this.vmethod_39();
						if (Information.IsNothing(altBand))
						{
							altBand = this.activeUnit.GetEngines()[0].altBands.OrderByDescending(ActiveUnit_Kinematics.GetAltBandMaxAltitude).ElementAtOrDefault(0);
							this.activeUnit.SetAltitude_ASL(false, altBand.MaxAltitude);
						}
						result = (float)altBand.Speed_Loiter;
					}
				}
				else
				{
					result = 0f;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100179", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x000E4F18 File Offset: 0x000E3118
		public  int vmethod_29(float single, ActiveUnit.Throttle throttle)
		{
			int result = 0;
			float num = 0f;
			float num2 = 0f;
			try
			{
				AltBand altBand = null;
				if (this.activeUnit.IsFacility || this.activeUnit.IsShip || this.activeUnit.IsSubmarine)
				{
					result = 0;
				}
				else if (this.activeUnit.IsAircraft && ((Aircraft)this.activeUnit).IsRotaryWingAircraft())
				{
					result = 0;
				}
				else if (throttle != ActiveUnit.Throttle.FullStop)
				{
					ActiveUnit.Throttle throttle2 = (ActiveUnit.Throttle)(throttle - ActiveUnit.Throttle.Loiter);
					if (this.activeUnit.IsAircraft && throttle2 == ActiveUnit.Throttle.FullStop)
					{
						throttle2 = ActiveUnit.Throttle.Loiter;
					}
					if (this.activeUnit.GetEngines().Count == 0)
					{
						result = 0;
					}
					else if (this.activeUnit.GetEngines()[0].GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
					{
						result = 0;
					}
					else if (this.activeUnit.GetEngines()[0].altBands.Length != 0)
					{
						AltBand[] altBands = this.activeUnit.GetEngines()[0].altBands;
						if (altBands.Length != 0)
						{
							altBand = this.vmethod_39();
							if (!Information.IsNothing(altBand))
							{
								switch (throttle2)
								{
								case ActiveUnit.Throttle.FullStop:
									num = 0f;
									break;
								case ActiveUnit.Throttle.Loiter:
									num = (float)altBand.Speed_Loiter;
									break;
								case ActiveUnit.Throttle.Cruise:
									if (altBand.Speed_Cruise <= 0)
									{
										num = (float)altBand.Speed_Loiter;
									}
									else
									{
										num = (float)altBand.Speed_Cruise;
									}
									break;
								case ActiveUnit.Throttle.Full:
									if (altBand.Speed_Full.HasValue)
									{
										num = (float)altBand.Speed_Full.Value;
									}
									else
									{
										num = (float)altBand.Speed_Cruise;
									}
									break;
								case ActiveUnit.Throttle.Flank:
									if (altBand.Speed_Flank.HasValue)
									{
										num = (float)altBand.Speed_Flank.Value;
									}
									else if (altBand.Speed_Full.HasValue)
									{
										num = (float)altBand.Speed_Full.Value;
									}
									else
									{
										num = (float)altBand.Speed_Cruise;
									}
									break;
								}
								int num3 = (int)Math.Round((double)num);
								if (!this.activeUnit.IsShip && !this.activeUnit.IsSubmarine && !this.activeUnit.IsFacility && altBand != this.method_11(this.activeUnit.GetEngines()[0]))
								{
									Func<AltBand, bool> predicate = (AltBand altBand_0) => altBand_0.MinAltitude >= altBand.MaxAltitude;
									AltBand altBand2 = altBands.Where(predicate).OrderBy(ActiveUnit_Kinematics.GetAltBandMaxAltitude).ElementAtOrDefault(0);
									switch (throttle2)
									{
									case ActiveUnit.Throttle.FullStop:
										num2 = 0f;
										break;
									case ActiveUnit.Throttle.Loiter:
										num2 = (float)altBand2.Speed_Loiter;
										break;
									case ActiveUnit.Throttle.Cruise:
										num2 = (float)altBand2.Speed_Cruise;
										break;
									case ActiveUnit.Throttle.Full:
										if (altBand2.Speed_Full.HasValue)
										{
											num2 = (float)altBand2.Speed_Full.Value;
										}
										else
										{
											num2 = (float)altBand2.Speed_Cruise;
										}
										break;
									case ActiveUnit.Throttle.Flank:
										if (altBand2.Speed_Flank.HasValue)
										{
											num2 = (float)altBand2.Speed_Flank.Value;
										}
										else if (altBand2.Speed_Full.HasValue)
										{
											num2 = (float)altBand2.Speed_Full.Value;
										}
										else
										{
											num2 = (float)altBand2.Speed_Cruise;
										}
										break;
									}
									num3 = (int)Math.Round((double)(num2 + (single - altBand2.MinAltitude) * (num - num2) / (altBand.MinAltitude - altBand2.MinAltitude)));
								}
								if (!this.activeUnit.IsAircraft)
								{
									result = num3 + 1;
								}
								else
								{
									num3 = (int)Math.Round((double)ActiveUnit_Kinematics.smethod_1((float)num3));
									result = num3;
								}
							}
							else
							{
								result = 0;
							}
						}
						else
						{
							result = 0;
						}
					}
					else
					{
						result = 0;
					}
				}
				else
				{
					result = 0;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100180", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x000E53A0 File Offset: 0x000E35A0
		public bool method_9()
		{
			AltBand altBand = this.vmethod_39();
			return !Information.IsNothing(altBand) && altBand.Consumption_Loiter < 0f && altBand.Speed_Loiter < 0;
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x000E53D8 File Offset: 0x000E35D8
		public bool HasFullAltBand()
		{
			bool result = false;
			try
			{
				AltBand altBand = this.vmethod_39();
				result = (!Information.IsNothing(altBand) && (altBand.Consumption_Full.HasValue && altBand.Speed_Full.HasValue));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100181", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x000E5474 File Offset: 0x000E3674
		public virtual bool HasFlankAltBand()
		{
			bool result = false;
			try
			{
				AltBand altBand = this.vmethod_39();
				result = (!Information.IsNothing(altBand) && (altBand.Consumption_Flank.HasValue && altBand.Speed_Flank.HasValue));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100182", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x000E5510 File Offset: 0x000E3710
		public virtual long GetTimeToBingoFuel(bool TotalRemainingEndurance = false)
		{
			long result = 0L;
			try
			{
				FuelRec[] fuelRecs = this.activeUnit.GetFuelRecs();
				float num = 0f;
				for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
				{
					FuelRec fuelRec = fuelRecs[i];
					num += fuelRec.CurrentQuantity;
				}
				if (!TotalRemainingEndurance)
				{
					num -= this.activeUnit.GetKinematics().GetReserveFuel();
				}
				result = (long)Math.Round((double)(num / this.activeUnit.GetFuelConsumption(this.activeUnit.GetThrottle(), null, null, null, false, false, false, false)));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100184", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x000E5600 File Offset: 0x000E3800
		public virtual long GetFuelBurnoutTime(float float_5, float float_6, bool bool_2, bool bool_3)
		{
			long result = 0L;
			try
			{
				if (float_5 == 0f)
				{
					result = 9223372036854775807L;
				}
				else
				{
					float num = 0f;
					if (bool_3 && this.activeUnit.IsAircraft && !Information.IsNothing(((Aircraft)this.activeUnit).GetAircraftAirOps().GetAssignedHostUnit(false)))
					{
						num = ((Aircraft)this.activeUnit).FuelQuantityLeftToBingo;
					}
					else
					{
						FuelRec[] fuelRecs = this.activeUnit.GetFuelRecs();
						for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
						{
							FuelRec fuelRec = fuelRecs[i];
							num += fuelRec.CurrentQuantity;
						}
						if (!bool_2)
						{
							num -= this.activeUnit.GetKinematics().GetReserveFuel();
						}
					}
					result = (long)Math.Round((double)(num / this.activeUnit.GetFuelConsumption(this.vmethod_38(float_6, (float)((int)Math.Round((double)float_5))), null, new float?((float)((int)Math.Round((double)float_5))), new float?(float_6), false, false, false, false)));
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
			return result;
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x000E5754 File Offset: 0x000E3954
		public virtual long vmethod_33(ActiveUnit.Throttle throttle_0, float float_5, bool bool_2)
		{
			long result = 0L;
			try
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
				result = (long)Math.Round((double)(num / this.activeUnit.GetFuelConsumption(throttle_0, null, null, null, false, false, false, false)));
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

		// 取最大速度
		public virtual int GetMaxSpeed()
		{
			int num = 0;
			checked
			{
				int result;
				try
				{
					if (!this.MaxSpeed.HasValue)
					{
						if (this.activeUnit.GetEngines().Count == 0)
						{
							num = 0;
							result = 0;
							return result;
						}
						HashSet<int> hashSet = new HashSet<int>();
						using (IEnumerator<Engine> enumerator = this.activeUnit.GetEngines().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								AltBand[] altBands = enumerator.Current.altBands;
								for (int i = 0; i < altBands.Length; i++)
								{
									AltBand altBand = altBands[i];
									hashSet.Add(altBand.GetMaxSpeed());
								}
							}
						}
						if (hashSet.Count == 0)
						{
							this.MaxSpeed = new int?(0);
						}
						else
						{
							this.MaxSpeed = new int?(hashSet.Max());
						}
					}
					num = this.MaxSpeed.Value;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100186", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				result = num;
				return result;
			}
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x000E597C File Offset: 0x000E3B7C
		public virtual int GetSpeed(float Altitude_ASL)
		{
			ActiveUnit_Kinematics.AltBandComparator altBandComparator = new ActiveUnit_Kinematics.AltBandComparator();
			int result = 0;
			try
			{
				if (this.activeUnit.GetEngines().Count == 0)
				{
					result = 0;
				}
				else
				{
					AltBand[] altBands = this.activeUnit.GetEngines()[0].altBands;
					if (this.activeUnit.GetEngines()[0].GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
					{
						result = 0;
					}
					else if (altBands.Length == 0)
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
							int maxSpeed = altBandComparator.altBand.GetMaxSpeed();
							int num = maxSpeed;
							if (!this.activeUnit.IsShip && !this.activeUnit.IsSubmarine && !this.activeUnit.IsFacility && altBandComparator.altBand != this.method_11(this.activeUnit.GetEngines()[0]))
							{
								AltBand altBand = altBands.Where(new Func<AltBand, bool>(altBandComparator.IsHigherThanMe)).OrderBy(ActiveUnit_Kinematics.GetAltBandMaxAltitude).ElementAtOrDefault(0);
								float num2 = (float)altBand.GetMaxSpeed();
								num = (int)Math.Round((double)(num2 + (Altitude_ASL - altBand.MinAltitude) * ((float)maxSpeed - num2) / (altBandComparator.altBand.MinAltitude - altBand.MinAltitude)));
							}
							if (this.activeUnit.IsAircraft)
							{
								num = (int)Math.Round((double)ActiveUnit_Kinematics.smethod_1((float)num));
							}
							result = num;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100187", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x000E5B6C File Offset: 0x000E3D6C
		public virtual AltBand GetAltBand(float altitude, int? nullable_2)
		{
			AltBand altBand = null;
			AltBand result = null;
			try
			{
				if (this.activeUnit.IsTorpedo())
				{
					result = this.activeUnit.GetEngines()[0].altBands[0];
				}
				else if (this.activeUnit.IsShip)
				{
					if (this.activeUnit.GetEngines()[0].altBands.Length == 0)
					{
						result = null;
					}
					else
					{
						result = this.activeUnit.GetEngines()[0].altBands[0];
					}
				}
				else
				{
					if (Information.IsNothing(nullable_2) && this.activeUnit.IsSubmarine && this.activeUnit.GetEngines().Count > 1 && altitude == this.activeUnit.GetCurrentAltitude_ASL(false))
					{
						Submarine submarine = (Submarine)this.activeUnit;
						if (Information.IsNothing(submarine.GetEngine()))
						{
							submarine.GetSubmarineAI().method_93();
						}
						if (!Information.IsNothing(submarine.GetEngine()))
						{
							nullable_2 = new int?(submarine.method_133());
						}
					}
					AltBand[] array = null;
					if (Information.IsNothing(nullable_2))
					{
						nullable_2 = new int?(0);
						int num = this.activeUnit.GetEngines().Count - 1;
						int i = 0;
						IL_240:
						while (i <= num)
						{
							nullable_2 = new int?(i);
							array = this.activeUnit.GetEngines()[nullable_2.Value].altBands;
							int num2 = array.Length;
							int j = num2 - 1;
							while (j >= 0)
							{
								AltBand altBand2 = array[j];
								bool arg_1D3_0;
								if (num2 >= 2)
								{
									if (j >= 1)
									{
										if (array[j].MinAltitude - array[j - 1].MaxAltitude != 0f)
										{
											arg_1D3_0 = false;
											goto IL_1D3;
										}
									}
									arg_1D3_0 = (j != 0 || array[j].MaxAltitude - array[j + 1].MinAltitude == 0f);
								}
								else
								{
									arg_1D3_0 = true;
								}
								IL_1D3:
								if (!arg_1D3_0)
								{
									if (altBand2.MaxAltitude >= altitude && altitude + 1f >= altBand2.MinAltitude)
									{
										altBand = altBand2;
										break;
									}
								}
								else if (altBand2.MaxAltitude >= altitude && altitude >= altBand2.MinAltitude)
								{
									altBand = altBand2;
									break;
								}
								j += -1;
								continue;
								IL_22C:
								if (Information.IsNothing(altBand))
								{
									i++;
									goto IL_240;
								}
								goto IL_333;
							}
                            if (Information.IsNothing(altBand))
                            {
                                i++;
                                goto IL_240;
                            }
                            goto IL_333; 
						}
					}
					else
					{
						array = this.activeUnit.GetEngines()[nullable_2.Value].altBands;
						int num3 = array.Count<AltBand>();
						for (int k = num3 - 1; k >= 0; k += -1)
						{
							AltBand altBand2 = array[k];
							bool arg_2DA_0;
							if (num3 >= 2)
							{
								if (k >= 1)
								{
									if (array[k].MinAltitude - array[k - 1].MaxAltitude != 0f)
									{
										arg_2DA_0 = false;
										goto IL_2DA;
									}
								}
								arg_2DA_0 = (k != 0 || array[k].MaxAltitude - array[k + 1].MinAltitude == 0f);
							}
							else
							{
								arg_2DA_0 = true;
							}
							IL_2DA:
							if (!arg_2DA_0)
							{
								if (altBand2.MaxAltitude >= altitude && altitude + 1f >= altBand2.MinAltitude)
								{
									altBand = altBand2;
									break;
								}
							}
							else if (altBand2.MaxAltitude >= altitude && altitude >= altBand2.MinAltitude)
							{
								altBand = altBand2;
								break;
							}
						}
					}
					IL_333:
					if (Information.IsNothing(altBand))
					{
						altBand = array.OrderByDescending(ActiveUnit_Kinematics.GetAltBandMaxAltitude).ElementAtOrDefault(0);
						this.activeUnit.SetAltitude_ASL(false, altBand.MaxAltitude);
					}
					result = altBand;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100188", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x000E5F40 File Offset: 0x000E4140
		public virtual int GetSpeed(float Altitude_ASL_, ActiveUnit.Throttle throttle_)
		{
			int result = 0;
			try
			{
				if (throttle_ == ActiveUnit.Throttle.FullStop)
				{
					result = 0;
				}
				else if (this.activeUnit.GetEngines().Count == 0)
				{
					if (this.activeUnit.IsFixedFacility())
					{
						result = 0;
					}
					else
					{
						result = 30;
					}
				}
				else
				{
					AltBand altBand = this.GetAltBand(Altitude_ASL_, null);
					if (Information.IsNothing(altBand))
					{
						result = 0;
					}
					else
					{
						Engine engine;
						if (this.activeUnit.IsSubmarine)
						{
							engine = this.method_12(altBand);
						}
						else
						{
							engine = this.activeUnit.GetEngines()[0];
						}
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
								num = (float)altBand.Speed_Loiter;
								break;
							case ActiveUnit.Throttle.Cruise:
								if (altBand.Speed_Cruise > 0)
								{
									num = (float)altBand.Speed_Cruise;
								}
								else
								{
									num = (float)altBand.Speed_Loiter;
								}
								break;
							case ActiveUnit.Throttle.Full:
								if (!altBand.Speed_Full.HasValue)
								{
									num = (float)altBand.Speed_Cruise;
								}
								else
								{
									num = (float)altBand.Speed_Full.Value;
								}
								break;
							case ActiveUnit.Throttle.Flank:
								if (!altBand.Speed_Flank.HasValue)
								{
									if (!altBand.Speed_Full.HasValue)
									{
										num = (float)altBand.Speed_Cruise;
									}
									else
									{
										num = (float)altBand.Speed_Full.Value;
									}
								}
								else
								{
									num = (float)altBand.Speed_Flank.Value;
								}
								break;
							}
							int num2 = (int)Math.Round((double)num);
							float val = Math.Max((float)num2 * (100f - this.activeUnit.GetDamage().GetDamagePts()) / 100f, 0f);
							float val2 = 0f;
							switch (engine.GetComponentStatus())
							{
							case PlatformComponent._ComponentStatus.Operational:
								val2 = (float)num2;
								break;
							case PlatformComponent._ComponentStatus.Damaged:
								val2 = (float)((double)num2 / 2.0);
								break;
							case PlatformComponent._ComponentStatus.Destroyed:
								val2 = 0f;
								break;
							}
							num2 = (int)Math.Round((double)Math.Min(val, val2));
							if (this.activeUnit.IsShip && this.activeUnit.IsOnLand())
							{
								float num3 = Terrain.smethod_5(this.activeUnit.GetLatitude(null), this.activeUnit.GetLongitude(null), false);
								if ((double)num3 > 0.5)
								{
									num2 = (int)Math.Round(Math.Max(1.0, (double)num2 / 10.0));
								}
								else
								{
									num2 = (int)Math.Round(Math.Max((double)num2 / 10.0, (double)((float)num2 * (1f - num3))));
								}
							}
							result = num2;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100189", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x000E6290 File Offset: 0x000E4490
		public static float smethod_1(float float_5)
		{
			float result;
			if (float_5 > 160f)
			{
				result = (float)(Math.Round((double)(float_5 / 10f)) * 10.0);
			}
			else
			{
				result = (float)(Math.Round((double)(float_5 / 5f)) * 5.0);
			}
			return result;
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x000E62E8 File Offset: 0x000E44E8
		public AltBand method_11(Engine engine_0)
		{
			AltBand result = null;
			checked
			{
				try
				{
					if (Information.IsNothing(engine_0))
					{
						result = null;
					}
					else if (engine_0.altBands.Length == 0)
					{
						result = null;
					}
					else if (this.activeUnit.IsWeapon && engine_0 != this.activeUnit.GetEngines()[0])
					{
						AltBand altBand = null;
						float num = -3.40282347E+38f;
						AltBand[] altBands = engine_0.altBands;
						for (int i = 0; i < altBands.Length; i++)
						{
							AltBand altBand2 = altBands[i];
							if (altBand2.MinAltitude > num)
							{
								altBand = altBand2;
								num = altBand2.MinAltitude;
							}
						}
						result = altBand;
					}
					else
					{
						if (Information.IsNothing(this.altBand_0) || Operators.CompareString(this.string_0, engine_0.GetGuid(), false) != 0)
						{
							AltBand altBand3 = null;
							float num2 = -3.40282347E+38f;
							AltBand[] altBands2 = engine_0.altBands;
							for (int j = 0; j < altBands2.Length; j++)
							{
								AltBand altBand4 = altBands2[j];
								if (altBand4.MinAltitude > num2)
								{
									altBand3 = altBand4;
									num2 = altBand4.MinAltitude;
								}
							}
							this.altBand_0 = altBand3;
							this.string_0 = engine_0.GetGuid();
						}
						result = this.altBand_0;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100190", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x000E6480 File Offset: 0x000E4680
		private Engine method_12(AltBand altBand_1)
		{
			Engine engine = null;
			Engine result;
			try
			{
				foreach (Engine current in this.activeUnit.GetEngines())
				{
					if (current.altBands.Contains(altBand_1))
					{
						engine = current;
						result = engine;
						return result;
					}
				}
				engine = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100191", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = engine;
			return result;
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x000E653C File Offset: 0x000E473C
		public void method_13()
		{
			try
			{
				int num = this.activeUnit.GetKinematics().method_8(this.activeUnit.GetCurrentAltitude_ASL(false));
				if (this.activeUnit.GetDesiredSpeed() >= (float)num)
				{
					if (num == 1)
					{
						this.activeUnit.SetDesiredSpeed(1f);
					}
					else
					{
						this.activeUnit.SetDesiredSpeed((float)(num - 1));
					}
					this.activeUnit.SetThrottle(this.activeUnit.GetKinematics().vmethod_38(this.activeUnit.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.activeUnit.GetDesiredSpeed()))), new float?((float)((int)Math.Round((double)this.activeUnit.GetDesiredSpeed()))));
					this.activeUnit.GetKinematics().bool_1 = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100192", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x000E6658 File Offset: 0x000E4858
		public virtual ActiveUnit.Throttle vmethod_38(float float_5, float float_6)
		{
			ActiveUnit.Throttle result = ActiveUnit.Throttle.FullStop;
			try
			{
				ActiveUnit_Kinematics.AltBandComparator altBandComparator = new ActiveUnit_Kinematics.AltBandComparator();
				if (this.activeUnit.GetEngines().Count == 0)
				{
					result = ActiveUnit.Throttle.FullStop;
				}
				else
				{
					altBandComparator.altBand = this.vmethod_39();
					if (Information.IsNothing(altBandComparator.altBand))
					{
						result = ActiveUnit.Throttle.FullStop;
					}
					else
					{
						AltBand[] altBands = this.activeUnit.GetEngines()[0].altBands;
						int num = altBandComparator.altBand.Speed_Loiter;
						int num2 = altBandComparator.altBand.Speed_Cruise;
						int num3 = 0;
						if (altBandComparator.altBand.Consumption_Full.HasValue)
						{
							num3 = (int)altBandComparator.altBand.Speed_Full.Value;
						}
						if (altBandComparator.altBand.Consumption_Flank.HasValue)
						{
							int num4 = (int)altBandComparator.altBand.Speed_Flank.Value;
						}
						if (!this.activeUnit.IsShip && !this.activeUnit.IsSubmarine && !this.activeUnit.IsFacility && altBandComparator.altBand != this.method_11(this.activeUnit.GetEngines()[0]))
						{
							AltBand altBand = altBands.Where(new Func<AltBand, bool>(altBandComparator.IsHigherThanMe)).OrderBy(ActiveUnit_Kinematics.GetAltBandMaxAltitude).ElementAtOrDefault(0);
							if (altBandComparator.altBand.Speed_Loiter != altBand.Speed_Loiter)
							{
								num = (int)Math.Round((double)((float)altBand.Speed_Loiter + (float_5 - altBand.MinAltitude) * (float)(altBandComparator.altBand.Speed_Loiter - altBand.Speed_Loiter) / (altBandComparator.altBand.MinAltitude - altBand.MinAltitude)));
								if (this.activeUnit.IsAircraft)
								{
									num = (int)Math.Round((double)ActiveUnit_Kinematics.smethod_1((float)num));
								}
							}
							if (altBandComparator.altBand.Speed_Cruise != altBand.Speed_Cruise)
							{
								num2 = (int)Math.Round((double)((float)altBand.Speed_Cruise + (float_5 - altBand.MinAltitude) * (float)(altBandComparator.altBand.Speed_Cruise - altBand.Speed_Cruise) / (altBandComparator.altBand.MinAltitude - altBand.MinAltitude)));
								if (this.activeUnit.IsAircraft)
								{
									num2 = (int)Math.Round((double)ActiveUnit_Kinematics.smethod_1((float)num2));
								}
							}
							if (altBandComparator.altBand.Consumption_Full.HasValue)
							{
								long? speed_Full = altBandComparator.altBand.Speed_Full;
								long? num5 = altBand.Speed_Full;
								if (((speed_Full.HasValue & num5.HasValue) ? new bool?(speed_Full.GetValueOrDefault() != num5.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									num5 = altBand.Speed_Full;
									float? num6 = num5.HasValue ? new float?((float)num5.GetValueOrDefault()) : null;
									float num7 = float_5 - altBand.MinAltitude;
									num5 = altBandComparator.altBand.Speed_Full - altBand.Speed_Full;
									float? num8 = num6;
									float num9 = num7;
									float? num10 = num5.HasValue ? new float?((float)num5.GetValueOrDefault()) : null;
									num10 = (num10.HasValue ? new float?(num9 * num10.GetValueOrDefault()) : null);
									num9 = altBandComparator.altBand.MinAltitude - altBand.MinAltitude;
									num10 = (num10.HasValue ? new float?(num10.GetValueOrDefault() / num9) : null);
									num3 = (int)Math.Round((double)((num8.HasValue & num10.HasValue) ? new float?(num8.GetValueOrDefault() + num10.GetValueOrDefault()) : null).Value);
									if (this.activeUnit.IsAircraft)
									{
										num3 = (int)Math.Round((double)ActiveUnit_Kinematics.smethod_1((float)num3));
									}
								}
							}
							if (altBandComparator.altBand.Consumption_Full.HasValue)
							{
								long? num5 = altBandComparator.altBand.Speed_Flank;
								long? num11 = altBand.Speed_Flank;
								if (((num5.HasValue & num11.HasValue) ? new bool?(num5.GetValueOrDefault() != num11.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									num11 = altBand.Speed_Flank;
									float? num12 = num11.HasValue ? new float?((float)num11.GetValueOrDefault()) : null;
									float num7 = float_5 - altBand.MinAltitude;
									num11 = altBandComparator.altBand.Speed_Flank - altBand.Speed_Flank;
									float? num8 = num12;
									float num9 = num7;
									float? num10 = num11.HasValue ? new float?((float)num11.GetValueOrDefault()) : null;
									num10 = (num10.HasValue ? new float?(num9 * num10.GetValueOrDefault()) : null);
									num9 = altBandComparator.altBand.MinAltitude - altBand.MinAltitude;
									num10 = (num10.HasValue ? new float?(num10.GetValueOrDefault() / num9) : null);
									int num4 = (int)Math.Round((double)((num8.HasValue & num10.HasValue) ? new float?(num8.GetValueOrDefault() + num10.GetValueOrDefault()) : null).Value);
									if (this.activeUnit.IsAircraft)
									{
										num4 = (int)Math.Round((double)ActiveUnit_Kinematics.smethod_1((float)num4));
									}
								}
							}
						}
						if (float_6 == 0f)
						{
							result = ActiveUnit.Throttle.FullStop;
						}
						else if (float_6 <= (float)num)
						{
							result = ActiveUnit.Throttle.Loiter;
						}
						else if (float_6 <= (float)num2)
						{
							result = ActiveUnit.Throttle.Cruise;
						}
						else if (float_6 <= (float)num3)
						{
							if (altBandComparator.altBand.Consumption_Full.HasValue)
							{
								result = ActiveUnit.Throttle.Full;
							}
							else
							{
								result = ActiveUnit.Throttle.Cruise;
							}
						}
						else if (altBandComparator.altBand.Consumption_Flank.HasValue)
						{
							result = ActiveUnit.Throttle.Flank;
						}
						else
						{
							result = ActiveUnit.Throttle.Full;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100193", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x000E6D38 File Offset: 0x000E4F38
		public virtual AltBand vmethod_39()
		{
			AltBand result = null;
			try
			{
				AltBand altBand = null;
				if (this.activeUnit.IsTorpedo())
				{
					result = this.activeUnit.GetEngines()[0].altBands[0];
				}
				else if (this.activeUnit.IsShip)
				{
					if (this.activeUnit.GetEngines()[0].altBands.Length == 0)
					{
						result = null;
					}
					else
					{
						result = this.activeUnit.GetEngines()[0].altBands[0];
					}
				}
				else
				{
					AltBand[] altBands = this.activeUnit.GetEngines()[0].altBands;
					int num = altBands.Length;
					float currentAltitude_ASL = this.activeUnit.GetCurrentAltitude_ASL(false);
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						AltBand altBand2 = altBands[i];
						if (altBand2.MaxAltitude >= currentAltitude_ASL && (currentAltitude_ASL + 1f > altBand2.MinAltitude || currentAltitude_ASL + 1f == altBand2.MinAltitude))
						{
							altBand = altBand2;
						}
					}
					if (Information.IsNothing(altBand))
					{
						altBand = altBands.OrderByDescending(ActiveUnit_Kinematics.GetAltBandMaxAltitude).ElementAtOrDefault(0);
						this.activeUnit.SetAltitude_ASL(false, altBand.MaxAltitude);
					}
					result = altBand;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100194", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x000E6EE8 File Offset: 0x000E50E8
		public void method_14(float float_5)
		{
			if (this.activeUnit.vmethod_19() != this.activeUnit.GetPitch())
			{
				if (this.activeUnit.vmethod_19() > this.activeUnit.GetPitch())
				{
					if (this.activeUnit.vmethod_19() - this.activeUnit.GetPitch() > this.vmethod_17() * float_5)
					{
						ActiveUnit activeUnit;
						(activeUnit = this.activeUnit).SetPitch(activeUnit.GetPitch() + this.vmethod_17() * float_5);
					}
					else
					{
						this.activeUnit.SetPitch(this.activeUnit.vmethod_19());
					}
				}
				else if (this.activeUnit.GetPitch() - this.activeUnit.vmethod_19() > this.vmethod_18() * float_5)
				{
					ActiveUnit activeUnit;
					(activeUnit = this.activeUnit).SetPitch(activeUnit.GetPitch() - this.vmethod_18() * float_5);
				}
				else
				{
					this.activeUnit.SetPitch(this.activeUnit.vmethod_19());
				}
			}
			if (this.activeUnit.float_6 != this.activeUnit.GetRoll())
			{
				if (this.activeUnit.float_6 > this.activeUnit.GetRoll())
				{
					if (this.activeUnit.float_6 - this.activeUnit.GetRoll() > this.vmethod_16() * float_5)
					{
						ActiveUnit activeUnit;
						(activeUnit = this.activeUnit).SetRoll(activeUnit.GetRoll() + this.vmethod_16() * float_5);
					}
					else
					{
						this.activeUnit.SetRoll(this.activeUnit.float_6);
					}
				}
				else if (this.activeUnit.GetRoll() - this.activeUnit.float_6 > this.vmethod_16() * float_5)
				{
					ActiveUnit activeUnit;
					(activeUnit = this.activeUnit).SetRoll(activeUnit.GetRoll() - this.vmethod_16() * float_5);
				}
				else
				{
					this.activeUnit.SetRoll(this.activeUnit.float_6);
				}
			}
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x000E70E0 File Offset: 0x000E52E0
		public virtual void vmethod_40(float float_5, float float_6)
		{
			try
			{
				if (this.activeUnit.GetCurrentSpeed() < 1f && this.activeUnit.GetDesiredSpeed() == 0f)
				{
					this.activeUnit.SetCurrentSpeed(0f);
				}
				if ((double)Math.Abs(this.activeUnit.GetDesiredSpeed() - this.activeUnit.GetCurrentSpeed()) < 0.5)
				{
					this.activeUnit.SetCurrentSpeed(this.activeUnit.GetDesiredSpeed());
				}
				float num = (float)((double)(this.vmethod_8(this.activeUnit.GetThrottle(), this.activeUnit.GetCurrentAltitude_ASL(false), this.activeUnit.GetCurrentSpeed()) * float_5) * (1.0 - 0.8 * (double)(float_6 / this.GetTurnRate())));
				if (this.activeUnit.GetCurrentSpeed() < this.activeUnit.GetDesiredSpeed())
				{
					this.activeUnit.SetCurrentSpeed(this.activeUnit.GetCurrentSpeed() + num);
					if ((int)Math.Round((double)this.activeUnit.GetCurrentSpeed()) > (int)Math.Round((double)this.activeUnit.GetDesiredSpeed()))
					{
						this.activeUnit.SetCurrentSpeed(this.activeUnit.GetDesiredSpeed());
					}
				}
				if (this.activeUnit.GetCurrentSpeed() > this.activeUnit.GetDesiredSpeed())
				{
					double num2 = 1.5 * (double)this.vmethod_9(ActiveUnit.Throttle.Full, this.activeUnit.GetCurrentAltitude_ASL(false)) * (double)(this.activeUnit.GetCurrentSpeed() / (float)this.activeUnit.GetKinematics().GetMaxSpeed()) * (double)float_5;
					this.activeUnit.SetCurrentSpeed((float)((double)this.activeUnit.GetCurrentSpeed() - num2));
					if ((int)Math.Round((double)this.activeUnit.GetCurrentSpeed()) < (int)Math.Round((double)this.activeUnit.GetDesiredSpeed()))
					{
						this.activeUnit.SetCurrentSpeed(this.activeUnit.GetDesiredSpeed());
					}
				}
				if (this.activeUnit.GetCurrentSpeed() < 0f)
				{
					this.activeUnit.SetCurrentSpeed(0f);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100195", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public virtual void vmethod_41(double double_0, float t)
		{
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x000E736C File Offset: 0x000E556C
		public virtual void SetAltitude_ASL(float elapsedTime, float desiredAltitude_, float? allowedMinAltitude_)
		{
			try
			{
				this.activeUnit.SetPreviousAltitude_ASL(this.activeUnit.GetCurrentAltitude_ASL(false));
				if (this.activeUnit.IsWeapon && ((Weapon)this.activeUnit).IsRVorHGV())
				{
					this.activeUnit.SetDesiredAltitude(Math.Min(this.activeUnit.GetCurrentAltitude_ASL(false) - 1f, this.activeUnit.GetDesiredAltitude()));
				}
				if (this.activeUnit.IsWeapon && ((Weapon)this.activeUnit).GetWeaponType() == Weapon._WeaponType.GuidedWeapon && ((Weapon)this.activeUnit).weaponCode.BallisticMissile && ((Weapon)this.activeUnit).method_258())
				{
					this.activeUnit.SetDesiredAltitude(Math.Max(this.activeUnit.GetCurrentAltitude_ASL(false) + 1f, this.activeUnit.GetDesiredAltitude()));
				}
				double num = (double)((this.activeUnit.GetCurrentAltitude_ASL(false) - this.activeUnit.GetPreviousAltitude_ASL()) / elapsedTime);
				if (this.activeUnit.IsAircraft)
				{
					((Aircraft)this.activeUnit).GetAircraftKinematics().method_20(elapsedTime);
				}
				float num2 = this.method_1() * elapsedTime;
				float num3 = this.method_2() * elapsedTime;
				float num4;
				if (this.activeUnit.GetCurrentAltitude_ASL(false) < desiredAltitude_)
				{
					if (num < 0.0)
					{
						num2 = (float)((double)num2 - num);
					}
					if (this.activeUnit.IsOfAirLaunchedGuidedWeapon())
					{
						num4 = this.activeUnit.GetCurrentAltitude_ASL(false) + num2;
					}
					else if (desiredAltitude_ - this.activeUnit.GetCurrentAltitude_ASL(false) <= num2)
					{
						num4 = desiredAltitude_;
					}
					else
					{
						num4 = this.activeUnit.GetCurrentAltitude_ASL(false) + num2;
					}
				}
				else if (this.activeUnit.GetCurrentAltitude_ASL(false) > desiredAltitude_)
				{
					if (num > 0.0)
					{
						num3 = (float)((double)num3 - Math.Abs(num));
					}
					if (this.activeUnit.IsOfAirLaunchedGuidedWeapon())
					{
						num4 = this.activeUnit.GetCurrentAltitude_ASL(false) - num3;
					}
					else if (this.activeUnit.GetCurrentAltitude_ASL(false) - desiredAltitude_ <= num3)
					{
						num4 = desiredAltitude_;
					}
					else
					{
						num4 = this.activeUnit.GetCurrentAltitude_ASL(false) - num3;
					}
				}
				else
				{
					this.activeUnit.vmethod_20(0f);
					num4 = desiredAltitude_;
				}
				float maxAltitude = this.GetMaxAltitude();
				float minAltitude = this.GetMinAltitude();
				if (this.activeUnit.GetCurrentAltitude_ASL(false) > maxAltitude)
				{
					num4 = maxAltitude - 10f;
					this.activeUnit.SetPitch(0f);
				}
				if (this.activeUnit.GetCurrentAltitude_ASL(false) < minAltitude)
				{
					num4 = minAltitude;
					this.activeUnit.SetPitch(0f);
				}
				if (allowedMinAltitude_.HasValue && (allowedMinAltitude_.HasValue ? new bool?(num4 <= allowedMinAltitude_.GetValueOrDefault()) : null).GetValueOrDefault())
				{
					num4 = allowedMinAltitude_.Value;
					this.activeUnit.SetPitch(0f);
				}
				this.activeUnit.SetAltitude_ASL(true, num4);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100196", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x000E76F0 File Offset: 0x000E58F0
		public static void ExportUnitPositions(ActiveUnit activeUnit_)
		{
			foreach (IEventExporter current in activeUnit_.m_Scenario.GetEventExporters())
			{
				if (current.IsExportUnitPositions() && !Information.IsNothing(activeUnit_.GetSide(false)))
				{
					Dictionary<string, Tuple<Type, string>> dictionary = new Dictionary<string, Tuple<Type, string>>(13);
					dictionary.Add("TimelineID", new Tuple<Type, string>(typeof(string), activeUnit_.m_Scenario.TimelineID));
					if (current.IsUseZeroHour())
					{
						TimeSpan timeSpan = activeUnit_.m_Scenario.GetCurrentTime(false).Subtract(activeUnit_.m_Scenario.ZeroHour);
						dictionary.Add("Time", new Tuple<Type, string>(typeof(TimeSpan), timeSpan.ToString("c")));
					}
					else
					{
						dictionary.Add("Time", new Tuple<Type, string>(typeof(DateTime), activeUnit_.m_Scenario.GetCurrentTime(false).ToString("MM/dd/yyyy HH:mm:ss") + "." + activeUnit_.m_Scenario.GetCurrentTime(false).Millisecond.ToString("D3")));
					}
					dictionary.Add("UnitID", new Tuple<Type, string>(typeof(string), activeUnit_.GetGuid()));
					dictionary.Add("UnitName", new Tuple<Type, string>(typeof(string), activeUnit_.Name));
					dictionary.Add("UnitClass", new Tuple<Type, string>(typeof(string), activeUnit_.UnitClass));
					dictionary.Add("UnitSide", new Tuple<Type, string>(typeof(string), activeUnit_.GetSide(false).GetSideName()));
					dictionary.Add("UnitLongitude", new Tuple<Type, string>(typeof(double), activeUnit_.GetLongitude(null).ToString()));
					dictionary.Add("UnitLatitude", new Tuple<Type, string>(typeof(double), activeUnit_.GetLatitude(null).ToString()));
					dictionary.Add("UnitCourse", new Tuple<Type, string>(typeof(float), activeUnit_.GetCurrentHeading().ToString()));
					dictionary.Add("UnitSpeed_kts", new Tuple<Type, string>(typeof(float), activeUnit_.GetCurrentSpeed().ToString()));
					dictionary.Add("UnitAltitude_m", new Tuple<Type, string>(typeof(float), activeUnit_.GetCurrentAltitude_ASL(false).ToString()));
					dictionary.Add("UnitAttitude_Pitch", new Tuple<Type, string>(typeof(float), activeUnit_.GetPitch().ToString()));
					dictionary.Add("UnitAttitude_Roll", new Tuple<Type, string>(typeof(float), activeUnit_.GetRoll().ToString()));
					current.ExportEvent(ExportedEventType.UnitPositions, dictionary, activeUnit_.m_Scenario);
				}
			}
		}

		// 更新实体位置
		public virtual void UpdateUnitPositions(float elapsedTime, bool bool_2, bool bNotExportUnitPositions)
		{
			try
			{
				if (this.activeUnit.GetKinematics().DesiredSpeedOverride.HasValue)
				{
					if (this.activeUnit.GetKinematics().GetSpeedPreset() != ActiveUnit_Kinematics._SpeedPreset.None)
					{
						if (this.activeUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.Unassigned && this.activeUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
						{
							if (this.activeUnit.IsAircraft)
							{
								Aircraft_AirOps aircraft_AirOps = (Aircraft_AirOps)this.activeUnit.GetAirOps();
								if (aircraft_AirOps.GetRefuellingQueue().Count + aircraft_AirOps.GetA2ARCDictionary().Count == 0)
								{
									this.activeUnit.SetThrottle((ActiveUnit.Throttle)this.activeUnit.GetKinematics().GetSpeedPreset(), new float?((float)((int)Math.Round((double)this.activeUnit.GetDesiredSpeed()))));
								}
							}
							else if (this.activeUnit.IsShip)
							{
								ActiveUnit_DockingOps dockingOps = this.activeUnit.GetDockingOps();
								if (dockingOps.GetUNREPQueue().Count == 0 && string.IsNullOrEmpty(dockingOps.UNREP_Starboard) && string.IsNullOrEmpty(dockingOps.UNREP_Port) && string.IsNullOrEmpty(dockingOps.UNREP_Astern))
								{
									this.activeUnit.SetThrottle((ActiveUnit.Throttle)this.activeUnit.GetKinematics().GetSpeedPreset(), new float?((float)((int)Math.Round((double)this.activeUnit.GetDesiredSpeed()))));
								}
							}
							else if (this.activeUnit.IsSubmarine)
							{
								ActiveUnit_DockingOps dockingOps2 = this.activeUnit.GetDockingOps();
								if (dockingOps2.GetUNREPQueue().Count == 0 && string.IsNullOrEmpty(dockingOps2.UNREP_Starboard) && string.IsNullOrEmpty(dockingOps2.UNREP_Port) && string.IsNullOrEmpty(dockingOps2.UNREP_Astern))
								{
									this.activeUnit.SetThrottle((ActiveUnit.Throttle)this.activeUnit.GetKinematics().GetSpeedPreset(), new float?((float)((int)Math.Round((double)this.activeUnit.GetDesiredSpeed()))));
								}
							}
							else
							{
								this.activeUnit.SetThrottle((ActiveUnit.Throttle)this.activeUnit.GetKinematics().GetSpeedPreset(), new float?((float)((int)Math.Round((double)this.activeUnit.GetDesiredSpeed()))));
							}
						}
					}
					else
					{
						this.activeUnit.SetThrottle(this.vmethod_38(this.activeUnit.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.activeUnit.GetDesiredSpeed()))), new float?((float)((int)Math.Round((double)this.activeUnit.GetDesiredSpeed()))));
					}
				}
				float num = (float)this.GetSpeed(this.activeUnit.GetCurrentAltitude_ASL(false), this.activeUnit.GetThrottle());
				if ((this.activeUnit.IsShip || this.activeUnit.IsSubmarine) && GeoPoint.smethod_7(this.activeUnit.GetLatitude(null), this.activeUnit.GetLongitude(null)))
				{
					num = 8f;
				}
				if (this.activeUnit.IsRunOutOfFuel())
				{
					if (this.activeUnit.IsWeapon && this.activeUnit.IsOfAirLaunchedGuidedWeapon())
					{
						if (this.activeUnit.GetPitch() > ((Weapon)this.activeUnit).method_127())
						{
							num = 0f;
						}
					}
					else
					{
						num = 0f;
					}
				}
				if (this.activeUnit.GetDesiredSpeed() > num)
				{
					this.activeUnit.SetDesiredSpeed(num);
				}
				double num2 = (double)this.activeUnit.GetCurrentHeading();
				if (this.activeUnit.GetCurrentHeading() != this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0))
				{
					this.vmethod_24(elapsedTime);
				}
				else
				{
					this.ActualMovementVector = this.activeUnit.GetCurrentHeading();
				}
				if (this.activeUnit.GetCurrentSpeed() != 0f)
				{
					this.activeUnit.Move(elapsedTime, bNotExportUnitPositions);
				}
				double num3 = (double)Math.Abs(Class263.RelativeBearingTo((float)num2, this.activeUnit.GetCurrentHeading())) * (double)(1f / elapsedTime);
				this.vmethod_41(num3, elapsedTime);
				bool flag = false;
				if (this.activeUnit.GetDesiredTurnRate() == ActiveUnit._TurnRate.const_1 && this.activeUnit.GetNavigator().HasFlightCourse() && (int)Math.Round(num2) != (int)Math.Round((double)this.activeUnit.GetCurrentHeading()))
				{
					flag = true;
				}
				if (!flag && this.activeUnit.GetCurrentSpeed() != this.activeUnit.GetDesiredSpeed())
				{
					this.vmethod_40(elapsedTime, (float)num3);
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
				if (!bNotExportUnitPositions)
				{
					ActiveUnit_Kinematics.ExportUnitPositions(this.activeUnit);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100197", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x000E7FD4 File Offset: 0x000E61D4
		public float GetHorizontalDistanceMoved(float t)
		{
			return this.activeUnit.GetHorizontalSpeed() / 3600f * t;
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x000E7FF8 File Offset: 0x000E61F8
		public float method_16(ActiveUnit myUnit, float DesiredAltitude, float ClosureSpeed = 0f)
		{
			float num = 0f;
			float result;
			try
			{
				if (!myUnit.IsAircraft && !myUnit.IsSatellite() && !myUnit.IsWeapon)
				{
					num = 0f;
				}
				else if (myUnit.GetEngines().Count == 0)
				{
					num = 0f;
				}
				else if (myUnit.GetThrottle() == ActiveUnit.Throttle.FullStop)
				{
					num = 0f;
				}
				else if (myUnit.GetCurrentAltitude_ASL(false) == DesiredAltitude)
				{
					num = 0f;
				}
				else
				{
					Engine engine;
					if (myUnit.IsGuidedWeapon() && ((Weapon)myUnit).weaponCode.BallisticMissile)
					{
						Weapon weapon = (Weapon)myUnit;
						if (weapon.m_Warheads.Length == 0)
						{
							num = 0f;
							result = num;
							return result;
						}
						Weapon weaponFromDP = weapon.m_Warheads[0].GetWeaponFromDP(myUnit.m_Scenario);
						if (Information.IsNothing(weaponFromDP))
						{
							engine = myUnit.GetEngines()[0];
						}
						else
						{
							if (weaponFromDP.GetEngines().Count == 0)
							{
								num = 0f;
								result = num;
								return result;
							}
							engine = weaponFromDP.GetEngines()[0];
						}
					}
					else
					{
						engine = myUnit.GetEngines()[0];
					}
					float currentAltitude_ASL = myUnit.GetCurrentAltitude_ASL(false);
					List<AltBand> list = new List<AltBand>();
					AltBand[] altBands = engine.altBands;
					if (altBands.Length == 0)
					{
						num = 0f;
					}
					else if (engine.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
					{
						num = 0f;
					}
					else
					{
						float num2 = 0f;
						float num3 = 0f;
						float num4 = 0f;
						checked
						{
							if (myUnit.GetCurrentAltitude_ASL(false) > DesiredAltitude)
							{
								AltBand[] array = altBands;
								for (int i = 0; i < array.Length; i++)
								{
									AltBand altBand = array[i];
									if (altBand.MinAltitude <= currentAltitude_ASL && altBand.MaxAltitude >= DesiredAltitude)
									{
										list.Add(altBand);
									}
								}
								if (list.Count > 1)
								{
									list.Sort(new ActiveUnit_Kinematics.AltBandComparer());
								}
								num2 = myUnit.GetCurrentAltitude_ASL(false);
								num3 = DesiredAltitude;
								num4 = myUnit.GetKinematics().vmethod_19();
							}
							else
							{
								if (myUnit.GetCurrentAltitude_ASL(false) >= DesiredAltitude)
								{
									num = 0f;
									result = num;
									return result;
								}
								AltBand[] array2 = altBands;
								for (int j = 0; j < array2.Length; j++)
								{
									AltBand altBand2 = array2[j];
									if (altBand2.MinAltitude >= currentAltitude_ASL && altBand2.MaxAltitude <= DesiredAltitude)
									{
										list.Add(altBand2);
									}
								}
								if (list.Count > 1)
								{
									list.Sort(new ActiveUnit_Kinematics.AltBandComparer());
								}
								num2 = DesiredAltitude;
								num3 = myUnit.GetCurrentAltitude_ASL(false);
								num4 = myUnit.GetKinematics().GetClimbRate();
							}
						}
						if (list.Count == 0)
						{
							num = 0f;
						}
						else
						{
							float num5 = 0f;
							foreach (AltBand current in list)
							{
								try
								{
									float num6 = 0f;
									switch (myUnit.GetThrottle())
									{
									case ActiveUnit.Throttle.FullStop:
										num = 0f;
										result = num;
										return result;
									case ActiveUnit.Throttle.Loiter:
										num6 = (float)current.Speed_Loiter;
										break;
									case ActiveUnit.Throttle.Cruise:
										if (current.Speed_Cruise > 0)
										{
											num6 = (float)current.Speed_Cruise;
										}
										else
										{
											num6 = (float)current.Speed_Loiter;
										}
										break;
									case ActiveUnit.Throttle.Full:
										if (!current.Speed_Full.HasValue)
										{
											num6 = (float)current.Speed_Cruise;
										}
										else
										{
											num6 = (float)current.Speed_Full.Value;
										}
										break;
									case ActiveUnit.Throttle.Flank:
										if (!current.Speed_Flank.HasValue)
										{
											if (!current.Speed_Full.HasValue)
											{
												num6 = (float)current.Speed_Cruise;
											}
											else
											{
												num6 = (float)current.Speed_Full.Value;
											}
										}
										else
										{
											num6 = (float)current.Speed_Flank.Value;
										}
										break;
									}
									float num7;
									float num8;
									int num9;
									if (current == this.method_11(engine))
									{
										num7 = current.MinAltitude;
										num8 = myUnit.GetCurrentAltitude_ASL(false);
										num9 = (int)Math.Round((double)num6);
									}
									else
									{
										AltBand altBand3 = altBands[Array.IndexOf<AltBand>(altBands, current) + 1];
										float num10 = 0f;
										switch (myUnit.GetThrottle())
										{
										case ActiveUnit.Throttle.FullStop:
											num10 = 0f;
											break;
										case ActiveUnit.Throttle.Loiter:
											num10 = (float)altBand3.Speed_Loiter;
											break;
										case ActiveUnit.Throttle.Cruise:
											num10 = (float)altBand3.Speed_Cruise;
											break;
										case ActiveUnit.Throttle.Full:
											if (!altBand3.Speed_Full.HasValue)
											{
												num10 = (float)altBand3.Speed_Cruise;
											}
											else
											{
												num10 = (float)altBand3.Speed_Full.Value;
											}
											break;
										case ActiveUnit.Throttle.Flank:
											if (!altBand3.Speed_Flank.HasValue)
											{
												if (!altBand3.Speed_Full.HasValue)
												{
													num10 = (float)altBand3.Speed_Cruise;
												}
												else
												{
													num10 = (float)altBand3.Speed_Full.Value;
												}
											}
											else
											{
												num10 = (float)altBand3.Speed_Flank.Value;
											}
											break;
										}
										int num11;
										if (num3 > current.MinAltitude)
										{
											num7 = num3;
											num11 = this.GetSpeed(num3, myUnit.GetThrottle());
										}
										else
										{
											num7 = current.MinAltitude;
											num11 = (int)Math.Round((double)num6);
										}
										int num12;
										if (num2 < current.MaxAltitude)
										{
											num8 = num2;
											num12 = this.GetSpeed(num2, myUnit.GetThrottle());
										}
										else
										{
											num8 = altBand3.MinAltitude;
											num12 = (int)Math.Round((double)num10);
										}
										num9 = (int)Math.Round((double)(num12 + num11) / 2.0 + (double)ClosureSpeed);
									}
									float num13 = (num8 - num7) / num4;
									num5 += num13 / 3600f * (float)num9;
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ex2.Data.Add("Error at 101165", "");
									GameGeneral.LogException(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
								}
							}
							num = num5;
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100198", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x000097CF File Offset: 0x000079CF
		public virtual float GetTurnRate()
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x000E868C File Offset: 0x000E688C
		public static float smethod_2(Waypoint._TurnRate TurnRate_, float speed_)
		{
			float result;
			switch (TurnRate_)
			{
			case Waypoint._TurnRate.Standard:
				result = 3f;
				break;
			case Waypoint._TurnRate.Half:
				result = 1.5f;
				break;
			case Waypoint._TurnRate.Double:
				result = 6f;
				break;
			case Waypoint._TurnRate.const_4:
				result = ActiveUnit_Kinematics.smethod_3(speed_, 70f);
				break;
			case Waypoint._TurnRate.const_5:
				result = ActiveUnit_Kinematics.smethod_3(speed_, 75f);
				break;
			default:
				result = 3f;
				break;
			}
			return result;
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x000E86F4 File Offset: 0x000E68F4
		public static float smethod_3(float num, float num2)
		{
			return (float)(1091.0 * Math.Tan((double)num2 * 0.0174532925199433) / (double)num);
		}

		// Token: 0x040011E0 RID: 4576
		public static Func<AltBand, float> GetAltBandMaxAltitude = (AltBand altBand_0) => altBand_0.MaxAltitude;

		// Token: 0x040011E1 RID: 4577
		protected ActiveUnit activeUnit;

		// Token: 0x040011E2 RID: 4578
		private float ClimbRate;

		// Token: 0x040011E3 RID: 4579
		protected float ActualMovementVector;

		// Token: 0x040011E4 RID: 4580
		private float? DesiredSpeedOverride;

		// Token: 0x040011E5 RID: 4581
		private bool DesiredAltitudeOverride;

		// Token: 0x040011E6 RID: 4582
		protected float float_2 = 0f;

		// Token: 0x040011E7 RID: 4583
		protected int? MaxSpeed;

		// Token: 0x040011E8 RID: 4584
		private AltBand altBand_0;

		// Token: 0x040011E9 RID: 4585
		private string string_0;

		// Token: 0x040011EA RID: 4586
		protected float ReserveFuel;

		// Token: 0x040011EB RID: 4587
		protected float BingoJokerFuel = 0f;

		// Token: 0x040011EC RID: 4588
		public ActiveUnit_Kinematics._SprintAndDriftControl SprintAndDriftControl;

		// Token: 0x040011ED RID: 4589
		public bool bool_1;

		// Token: 0x040011EE RID: 4590
		protected ActiveUnit_Kinematics._SpeedPreset SpeedPreset;

		// Token: 0x020005B0 RID: 1456
		public enum _SpeedPreset : byte
		{
			// Token: 0x040011F1 RID: 4593
			FullStop,
			// Token: 0x040011F2 RID: 4594
			Loiter,
			// Token: 0x040011F3 RID: 4595
			Cruise,
			// Token: 0x040011F4 RID: 4596
			Full,
			// Token: 0x040011F5 RID: 4597
			Flank,
			// Token: 0x040011F6 RID: 4598
			None
		}

		// Token: 0x020005B1 RID: 1457
		private sealed class AltBandComparer : IComparer<AltBand>
		{
			// Token: 0x0600256B RID: 9579 RVA: 0x000E873C File Offset: 0x000E693C
			public int Compare(AltBand x, AltBand y)
			{
				return x.MaxAltitude.CompareTo(y.MaxAltitude);
			}
		}

		// Token: 0x020005B2 RID: 1458
		public enum _SprintAndDriftControl : short
		{
			// Token: 0x040011F8 RID: 4600
			Sprinting,
			// Token: 0x040011F9 RID: 4601
			Drifting
		}

		// Token: 0x020005B3 RID: 1459
		[CompilerGenerated]
		public sealed class AltBandComparator
		{
			// Token: 0x0600256D RID: 9581 RVA: 0x000153FD File Offset: 0x000135FD
			internal bool IsHigherThanMe(AltBand altBand_)
			{
				return altBand_.MinAltitude >= this.altBand.MaxAltitude;
			}

			// Token: 0x040011FA RID: 4602
			public AltBand altBand;
		}
	}
}
