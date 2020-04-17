using System;
using System.Collections.Generic;
using System.Diagnostics;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3
{
	// 武器动力学
	public class Weapon_Kinematics : ActiveUnit_Kinematics
	{
		// 取父实体
		protected Weapon GetParentWeapon()
		{
			if (Information.IsNothing(this.weapon))
			{
				this.weapon = (Weapon)this.activeUnit;
			}
			return this.weapon;
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x000278D3 File Offset: 0x00025AD3
		public Weapon_Kinematics(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
			this.dictionary_0 = new Dictionary<int, float>();
			this.dictionary_1 = new Dictionary<int, float>();
			this.dictionary_2 = new Dictionary<int, float>();
			this.dictionary_3 = new Dictionary<int, float>();
		}

		// 取转弯角速度
		public override float GetTurnRate()
		{
			Weapon._WeaponType weaponType = ((Weapon)this.activeUnit).GetWeaponType();
			float result;
			if (weaponType != Weapon._WeaponType.GuidedWeapon)
			{
				if (weaponType == Weapon._WeaponType.Torpedo)
				{
					result = 10f;
				}
				else
				{
					float iRCrossSectionModifier = Class263.GetIRCrossSectionModifier((double)this.activeUnit.GetCurrentAltitude_ASL(false), (double)this.activeUnit.GetCurrentSpeed());
					if (iRCrossSectionModifier < 1f)
					{
						result = 60f;
					}
					else
					{
						if (iRCrossSectionModifier <= 1f)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw new NotImplementedException();
						}
						result = 30f;
					}
				}
			}
			else if (((Weapon)this.activeUnit).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
			{
				result = 60f;
			}
			else
			{
				result = 30f;
			}
			return result;
		}

		// Token: 0x06005671 RID: 22129 RVA: 0x00251E1C File Offset: 0x0025001C
		public override float vmethod_9(ActiveUnit.Throttle throttle, float altitude_ASL)
		{
			float result;
			if (this.activeUnit.IsGuidedWeapon_RV_HGV())
			{
				result = (float)((double)this.GetSpeed(this.activeUnit.GetCurrentAltitude_ASL(false)) / 5.0);
			}
			else
			{
				result = (float)(0.065 * (double)this.activeUnit.GetDesiredSpeed());
			}
			return result;
		}

		// Token: 0x06005672 RID: 22130 RVA: 0x00251E7C File Offset: 0x0025007C
		public override float vmethod_8(ActiveUnit.Throttle throttle, float altitude_ASL, float speed)
		{
			return this.vmethod_9(throttle, altitude_ASL);
		}

		// Token: 0x06005673 RID: 22131 RVA: 0x00251E94 File Offset: 0x00250094
		public override void vmethod_40(float float_5, float float_6)
		{
			try
			{
				float num = this.vmethod_8(this.activeUnit.GetThrottle(), this.activeUnit.GetCurrentAltitude_ASL(false), this.activeUnit.GetCurrentSpeed()) * float_5;
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
					float num2 = 2f * this.vmethod_9(this.activeUnit.GetThrottle(), this.activeUnit.GetCurrentAltitude_ASL(false)) * (this.activeUnit.GetCurrentSpeed() / (float)this.activeUnit.GetKinematics().GetMaxSpeed());
					this.activeUnit.SetCurrentSpeed(this.activeUnit.GetCurrentSpeed() - num2);
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
				ex2.Data.Add("Error at 100980", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x000BA5A8 File Offset: 0x000B87A8
		public override float vmethod_18()
		{
			return 10f;
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x000BA5A8 File Offset: 0x000B87A8
		public override float vmethod_17()
		{
			return 10f;
		}

		// Token: 0x06005676 RID: 22134 RVA: 0x00252080 File Offset: 0x00250280
		public override float vmethod_16()
		{
			return 25f;
		}

		// 更新单元位置
		public override void UpdateUnitPositions(float elapsedTime, bool bool_2, bool bool_3)
		{
			try
			{
				Weapon weapon = (Weapon)this.activeUnit;
				float num = 0f;
				if (!bool_3)
				{
					num = weapon.GetAltitude_AGL();
				}
				if (weapon.IsOfAirLaunchedGuidedWeapon())
				{
					base.method_14(elapsedTime);
				}
				if (weapon.GetWeaponType() != Weapon._WeaponType.Sonobuoy)
				{
					if ((weapon.IsRVorHGV() & !weapon.IsHypersonicGlideVehicle()) || (weapon.weaponCode.BallisticMissile & !weapon.IsHypersonicGlideVehicle()))
					{
						bool_2 = false;
					}
					if (this.activeUnit.GetDesiredSpeed() < 0f)
					{
						this.activeUnit.SetDesiredSpeed(-this.activeUnit.GetDesiredSpeed());
					}
					bool arg_D5_0;
					if (weapon.GetWeaponType() != Weapon._WeaponType.GuidedWeapon)
					{
						if (weapon.GetWeaponType() != Weapon._WeaponType.Decoy_Vehicle)
						{
							arg_D5_0 = true;
							goto IL_D5;
						}
					}
					arg_D5_0 = (this.activeUnit.GetDesiredAltitude() >= 9.144f);
					IL_D5:
					if (!arg_D5_0)
					{
						this.activeUnit.SetDesiredAltitude(9.144f);
					}
					if (weapon.GetWeaponType() == Weapon._WeaponType.Torpedo)
					{
						if (this.activeUnit.GetDesiredAltitude() > 0f)
						{
							this.activeUnit.SetDesiredAltitude(0f);
						}
						if (this.activeUnit.GetCurrentAltitude_ASL(false) > 0f)
						{
							this.activeUnit.SetAltitude_ASL(false, 0f);
						}
					}
					this.SetAltitude_ASL(elapsedTime, this.activeUnit.GetDesiredAltitude(), null);
					if (weapon.GetWeaponType() == Weapon._WeaponType.Torpedo && !Information.IsNothing(this.activeUnit.GetAltitude_AGL()) && this.activeUnit.GetCurrentAltitude_ASL(false) < (float)this.activeUnit.GetTerrainElevation(false, false, false))
					{
						if (this.activeUnit.GetTerrainElevation(false, false, false) < -1)
						{
							this.activeUnit.SetAltitude_ASL(false, (float)(this.activeUnit.GetTerrainElevation(false, false, false) + 1));
						}
						else
						{
							this.activeUnit.SetAltitude_ASL(false, -1f);
						}
					}
					if (!this.activeUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
					{
						this.activeUnit.SetDesiredSpeed((float)this.GetSpeed(this.activeUnit.GetCurrentAltitude_ASL(false), this.activeUnit.GetThrottle()));
					}
					else
					{
						this.activeUnit.SetDesiredSpeed(this.activeUnit.GetKinematics().GetDesiredSpeedOverride().Value);
					}
					base.UpdateUnitPositions(elapsedTime, bool_2, bool_3);
					if (weapon.IsTorpedo() && this.activeUnit.GetTerrainElevation(false, false, false) > 0)
					{
						Weapon weapon2 = weapon;
						double latitude = this.activeUnit.GetLatitude(null);
						double longitude = this.activeUnit.GetLongitude(null);
						float alt_asl = -1f;
						Random random = GameGeneral.GetRandom();
						weapon2.Detonation(latitude, longitude, alt_asl, ref random);
					}
					if (bool_2 && (weapon.IsGuidedWeapon_RV_HGV() || weapon.IsDecoy()) && weapon.GetCurrentAltitude_ASL(false) < 9000f && (!weapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() || !weapon.TargetIsSatellite()))
					{
						if (weapon.IsOfAirLaunchedGuidedWeapon() && Information.IsNothing(weapon.GetWeaponAI().GetPrimaryTarget()) && weapon.GetPitch() < -10f)
						{
							if (weapon.GetAltitude_AGL() <= 0f)
							{
								Weapon weapon3 = weapon;
								double latitude = weapon.GetLatitude(null);
								double longitude = weapon.GetLongitude(null);
								float currentAltitude_ASL = weapon.GetCurrentAltitude_ASL(false);
								Random random = weapon.GetRandom();
								weapon3.Detonation(latitude, longitude, currentAltitude_ASL, ref random);
							}
						}
						else
						{
							float num2 = weapon.method_189();
							if (this.activeUnit.GetCurrentAltitude_ASL(false) < num2)
							{
								this.activeUnit.SetAltitude_ASL(false, num2);
							}
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
					if (!bool_3 && weapon.GetAltitude_AGL() == 0f && num > 0f && (weapon.weaponCode.BallisticMissile || weapon.IsRVorHGV()))
					{
						Weapon weapon4 = weapon;
						double latitude2 = weapon.GetLatitude(null);
						double longitude2 = weapon.GetLongitude(null);
						float alt_asl2 = (float)Math.Max(0, (int)Terrain.GetElevation(this.activeUnit.GetLatitude(null), this.activeUnit.GetLongitude(null), false));
						Random random = GameGeneral.GetRandom();
						weapon4.Detonation(latitude2, longitude2, alt_asl2, ref random);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100981", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005678 RID: 22136 RVA: 0x00252640 File Offset: 0x00250840
		public override void vmethod_41(double double_0, float elapsedTime)
		{
			try
			{
				if ((int)Math.Round((double)Math.Abs(this.activeUnit.GetCurrentHeading() - this.activeUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0))) > 5)
				{
					Weapon._WeaponType weaponType = ((Weapon)this.activeUnit).GetWeaponType();
					double num = 0.0;
					if (weaponType != Weapon._WeaponType.GuidedWeapon)
					{
						if (weaponType == Weapon._WeaponType.Torpedo)
						{
							if (double_0 > 25.0)
							{
								num = (double)(1f * elapsedTime);
							}
							if (double_0 > 45.0)
							{
								num = (double)(2f * elapsedTime);
							}
						}
					}
					else
					{
						if (double_0 > 25.0)
						{
							num = (double)(5f * elapsedTime);
						}
						if (double_0 > 45.0)
						{
							num = (double)(10f * elapsedTime);
						}
					}
					this.activeUnit.SetCurrentSpeed((float)Math.Max((double)this.activeUnit.GetCurrentSpeed() - num, 0.0));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101330", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005679 RID: 22137 RVA: 0x00252790 File Offset: 0x00250990
		public override float vmethod_19()
		{
			Weapon._WeaponType weaponType = ((Weapon)this.activeUnit).GetWeaponType();
			float result;
			if (weaponType == Weapon._WeaponType.GuidedWeapon)
			{
				result = Math.Max(100f, this.GetClimbRate());
			}
			else
			{
				result = this.GetClimbRate();
			}
			return result;
		}

		// Token: 0x0600567A RID: 22138 RVA: 0x002527E0 File Offset: 0x002509E0
		public override int GetSpeed(float altitude_asl, ActiveUnit.Throttle throttle_)
		{
			int num = 0;
			int result;
			try
			{
				if (float.IsNaN(altitude_asl))
				{
					num = 0;
				}
				else
				{
					Dictionary<int, float> dictionary;
					switch (throttle_)
					{
					case ActiveUnit.Throttle.FullStop:
						num = 0;
						result = 0;
						return result;
					case ActiveUnit.Throttle.Loiter:
						dictionary = this.dictionary_0;
						break;
					case ActiveUnit.Throttle.Cruise:
						dictionary = this.dictionary_1;
						break;
					case ActiveUnit.Throttle.Full:
						dictionary = this.dictionary_2;
						break;
					case ActiveUnit.Throttle.Flank:
						dictionary = this.dictionary_3;
						break;
					default:
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new NotImplementedException();
					}
					float num2 = 0f;
					if (dictionary.TryGetValue((int)Math.Round((double)altitude_asl), out num2))
					{
						num = (int)Math.Round((double)num2);
					}
					else
					{
						num2 = (float)base.GetSpeed(altitude_asl, throttle_);
						dictionary.Add((int)Math.Round((double)altitude_asl), num2);
						num = (int)Math.Round((double)num2);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100982", "");
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

		// Token: 0x04002A86 RID: 10886
		private Dictionary<int, float> dictionary_0;

		// Token: 0x04002A87 RID: 10887
		private Dictionary<int, float> dictionary_1;

		// Token: 0x04002A88 RID: 10888
		private Dictionary<int, float> dictionary_2;

		// Token: 0x04002A89 RID: 10889
		private Dictionary<int, float> dictionary_3;

		// Token: 0x04002A8A RID: 10890
		private Weapon weapon;
	}
}
