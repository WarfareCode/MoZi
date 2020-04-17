using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 战斗部
	public sealed class Warhead : Subject
	{
		// 构造函数
		public Warhead()
		{
		}

		// 清除GUID
		public override void ClearGuid()
		{
			base.ClearGuid();
			if (!Information.IsNothing(this.weapon))
			{
				this.weapon.ClearGuid();
			}
		}

		// 保存
		public void Save(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Warhead");
				xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("DP", XmlConvert.ToString(this.DP));
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Type";
				int num = (int)this.warheadType;
				xmlWriter.WriteElementString(localName, num.ToString());
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "ExpType";
				num = (int)this.ExplosivesType;
				xmlWriter2.WriteElementString(localName2, num.ToString());
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "Cal";
				num = (int)this.Caliber;
				xmlWriter3.WriteElementString(localName3, num.ToString());
				xmlWriter_0.WriteElementString("NOW", this.NumberOfWarheads.ToString());
				xmlWriter_0.WriteElementString("CBDAL", this.ClusterBombDispersionAreaLength.ToString());
				xmlWriter_0.WriteElementString("CBDAW", this.ClusterBombDispersionAreaWidth.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100746", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// 载入
		public static Warhead Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0)
		{
			Warhead warhead = null;
			Warhead result;
			try
			{
				Warhead warhead2 = new Warhead();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1458105184u)
						{
							if (num <= 684613497u)
							{
								if (num != 593902289u)
								{
									if (num != 677790384u)
									{
										if (num == 684613497u && Operators.CompareString(name, "DP", false) == 0)
										{
											warhead2.DP = XmlConvert.ToSingle(xmlNode.InnerText);
										}
									}
									else if (Operators.CompareString(name, "CBDAW", false) == 0)
									{
										warhead2.ClusterBombDispersionAreaWidth = Conversions.ToShort(xmlNode.InnerText);
									}
								}
								else if (Operators.CompareString(name, "CBDAL", false) == 0)
								{
									warhead2.ClusterBombDispersionAreaLength = Conversions.ToShort(xmlNode.InnerText);
								}
							}
							else
							{
								if (num != 904230039u)
								{
									if (num != 1358876127u)
									{
										if (num != 1458105184u || Operators.CompareString(name, "ID", false) != 0)
										{
											continue;
										}
										if (!dictionary_0.ContainsKey(xmlNode.InnerText))
										{
											warhead2.SetGuid(xmlNode.InnerText);
											dictionary_0.Add(warhead2.GetGuid(), warhead2);
											continue;
										}
										warhead = (Warhead)dictionary_0[xmlNode.InnerText];
										result = warhead;
										return result;
									}
									else if (Operators.CompareString(name, "Cal", false) != 0)
									{
										continue;
									}
								}
								else if (Operators.CompareString(name, "Caliber", false) != 0)
								{
									continue;
								}
								if (Versioned.IsNumeric(xmlNode.InnerText))
								{
									warhead2.Caliber = (Warhead.WarheadCaliber)Conversions.ToShort(xmlNode.InnerText);
								}
								else
								{
									warhead2.Caliber = (Warhead.WarheadCaliber)Enum.Parse(typeof(Warhead.WarheadCaliber), xmlNode.InnerText, true);
								}
							}
						}
						else if (num <= 2374875597u)
						{
							if (num != 1905141184u)
							{
								if (num != 2187602126u)
								{
									if (num != 2374875597u)
									{
										continue;
									}
									if (Operators.CompareString(name, "ExplosivesType", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "DBID", false) == 0)
									{
										warhead2.DBID = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (Operators.CompareString(name, "ExpType", false) != 0)
							{
								continue;
							}
							warhead2.ExplosivesType = (Warhead._ExplosivesType)Conversions.ToShort(xmlNode.InnerText);
						}
						else
						{
							if (num != 2867742231u)
							{
								if (num != 2938901124u)
								{
									if (num != 3512062061u || Operators.CompareString(name, "Type", false) != 0)
									{
										continue;
									}
									if (Versioned.IsNumeric(xmlNode.InnerText))
									{
										warhead2.warheadType = (Warhead.WarheadType)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									warhead2.warheadType = (Warhead.WarheadType)Enum.Parse(typeof(Warhead.WarheadType), xmlNode.InnerText, true);
									continue;
								}
								else if (Operators.CompareString(name, "NumberOfWarheads", false) != 0)
								{
									continue;
								}
							}
							else if (Operators.CompareString(name, "NOW", false) != 0)
							{
								continue;
							}
							warhead2.NumberOfWarheads = (short)Conversions.ToInteger(xmlNode.InnerText);
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
				warhead = warhead2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100747", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = warhead;
			return result;
		}

		// Token: 0x06006199 RID: 24985 RVA: 0x002F35A8 File Offset: 0x002F17A8
		public bool method_12()
		{
			Warhead.WarheadType warheadType = this.warheadType;
			if (warheadType <= Warhead.WarheadType.Chemical)
			{
				if (warheadType <= Warhead.WarheadType.SuperFrag)
				{
					if (warheadType != Warhead.WarheadType.Fragmentation && warheadType - Warhead.WarheadType.FAE > 1)
					{
						goto IL_8F;
					}
				}
				else if (warheadType != Warhead.WarheadType.Nuclear && warheadType != Warhead.WarheadType.Chemical)
				{
					goto IL_8F;
				}
			}
			else if (warheadType <= Warhead.WarheadType.Cluster_Penetrator)
			{
				if (warheadType != Warhead.WarheadType.Biological && warheadType - Warhead.WarheadType.Cluster_AP > 2)
				{
					goto IL_8F;
				}
			}
			else if (warheadType != Warhead.WarheadType.Cluster_SmartSubs && warheadType != Warhead.WarheadType.AntiElectrical)
			{
				goto IL_8F;
			}
			bool result = true;
			return result;
			IL_8F:
			result = false;
			return result;
		}

		// Token: 0x0600619A RID: 24986 RVA: 0x002F3648 File Offset: 0x002F1848
		public bool method_13()
		{
			Warhead.WarheadType warheadType = this.warheadType;
			if (warheadType <= Warhead.WarheadType.DepthCharge)
			{
				switch (warheadType)
				{
				case Warhead.WarheadType.HE_BlastFrag:
				case Warhead.WarheadType.HEAT:
				case Warhead.WarheadType.Fragmentation:
				case Warhead.WarheadType.SemiAP:
				case Warhead.WarheadType.HESH:
				case Warhead.WarheadType.ContinuousRod:
				case Warhead.WarheadType.HardTargetPenetrator:
				case Warhead.WarheadType.FAE:
				case Warhead.WarheadType.DirectionalContinousRod:
					break;
				case Warhead.WarheadType.ArmorPiercing:
				case Warhead.WarheadType.Incendiary:
				case Warhead.WarheadType.SuperFrag:
					goto IL_78;
				default:
					if (warheadType - Warhead.WarheadType.Torpedo > 1)
					{
						goto IL_78;
					}
					break;
				}
			}
			else if (warheadType != Warhead.WarheadType.Nuclear && warheadType - Warhead.WarheadType.Landmine_AP > 1)
			{
				goto IL_78;
			}
			bool result = true;
			return result;
			IL_78:
			result = false;
			return result;
		}

		// Token: 0x0600619B RID: 24987 RVA: 0x002F36D0 File Offset: 0x002F18D0
		public bool IsIncendiary()
		{
			Warhead.WarheadType warheadType = this.warheadType;
			return warheadType == Warhead.WarheadType.Incendiary;
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x002F36EC File Offset: 0x002F18EC
		public bool method_15()
		{
			Warhead.WarheadType warheadType = this.warheadType;
			return warheadType == Warhead.WarheadType.SuperFrag || warheadType - Warhead.WarheadType.Cluster_AP <= 2 || warheadType == Warhead.WarheadType.Cluster_SmartSubs;
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x002F372C File Offset: 0x002F192C
		public bool HasNuclearWarhead(Scenario scenario_0)
		{
			bool result = false;
			if (this.warheadType == Warhead.WarheadType.Nuclear)
			{
				result = true;
			}
			else if (this.warheadType == Warhead.WarheadType.Weapon)
			{
				if (Information.IsNothing(this.weapon))
				{
					this.weapon = scenario_0.GetWeapon((int)Math.Round((double)this.DP));
				}
				if (this.weapon.HasNuclearWarhead())
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600619E RID: 24990 RVA: 0x0002B286 File Offset: 0x00029486
		public bool IsEMP()
		{
			return this.warheadType == Warhead.WarheadType.EMP_Directed || this.warheadType == Warhead.WarheadType.EMP_Omni;
		}

		// Token: 0x0600619F RID: 24991 RVA: 0x002F37A0 File Offset: 0x002F19A0
		public bool method_18(Weapon weapon_1, ActiveUnit activeUnit_0)
		{
			bool flag;
			bool result;
			if (this.method_15())
			{
				flag = true;
			}
			else if (Information.IsNothing(activeUnit_0))
			{
				flag = false;
			}
			else if (weapon_1.IsGuidedWeapon_RV_HGV() && weapon_1.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() && !Information.IsNothing(activeUnit_0) && (activeUnit_0.IsShip || activeUnit_0.IsFacility) && activeUnit_0.GetTargetVisualSizeClass() > GlobalVariables.TargetVisualSizeClass.VSmall)
			{
				flag = false;
			}
			else
			{
				Warhead.WarheadType warheadType = this.warheadType;
				if (warheadType <= Warhead.WarheadType.SuperFrag)
				{
					if (warheadType != Warhead.WarheadType.Fragmentation && warheadType - Warhead.WarheadType.FAE > 1)
					{
						goto IL_BA;
					}
				}
				else if (warheadType - Warhead.WarheadType.Cluster_AP > 2 && warheadType != Warhead.WarheadType.Cluster_SmartSubs && warheadType != Warhead.WarheadType.EMP_Omni)
				{
					goto IL_BA;
				}
				flag = true;
				goto IL_B6;
				IL_BA:
				if (this.HasNuclearWarhead(weapon_1.m_Scenario))
				{
					result = !activeUnit_0.method_61();
					return result;
				}
				if (weapon_1.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
				{
					Warhead.WarheadType warheadType2 = this.warheadType;
					if (warheadType2 == Warhead.WarheadType.Fragmentation || warheadType2 == Warhead.WarheadType.ContinuousRod || warheadType2 == Warhead.WarheadType.DirectionalContinousRod)
					{
						result = true;
						return result;
					}
				}
				result = false;
				return result;
			}
			IL_B6:
			result = flag;
			return result;
		}

		// Token: 0x060061A0 RID: 24992 RVA: 0x002F38C4 File Offset: 0x002F1AC4
		public Weapon GetWeaponFromDP(Scenario scenario_)
		{
			Weapon result = null;
			if (this.warheadType == Warhead.WarheadType.Weapon)
			{
				if (Information.IsNothing(this.weapon))
				{
					this.weapon = scenario_.GetWeapon((int)Math.Round((double)this.DP));
				}
				result = this.weapon;
			}
			return result;
		}

		// Token: 0x060061A1 RID: 24993 RVA: 0x002F3918 File Offset: 0x002F1B18
		public Warhead.Enum86 method_20()
		{
			Warhead.WarheadType warheadType = this.warheadType;
			Warhead.Enum86 result;
			if (warheadType - Warhead.WarheadType.Laser_COIL > 1)
			{
				if (warheadType - Warhead.WarheadType.Laser_DeuteriumFluoride > 1)
				{
					result = Warhead.Enum86.const_0;
				}
				else
				{
					result = Warhead.Enum86.const_2;
				}
			}
			else
			{
				result = Warhead.Enum86.const_1;
			}
			return result;
		}

		// Token: 0x060061A2 RID: 24994 RVA: 0x002F3958 File Offset: 0x002F1B58
		public Warhead(string theName, float theDP, Warhead.WarheadType theType, Warhead._ExplosivesType theExplosivesType, Warhead.WarheadCaliber theCaliber, string theNumberOfWarheads = "")
		{
			try
			{
				this.Name = theName;
				this.DP = theDP;
				this.warheadType = theType;
				this.ExplosivesType = theExplosivesType;
				if (this.warheadType == Warhead.WarheadType.Nuclear)
				{
					this.DP = 1000000f * this.DP;
				}
				this.Caliber = theCaliber;
				if (string.IsNullOrEmpty(theNumberOfWarheads))
				{
					this.NumberOfWarheads = 1;
				}
				else
				{
					this.NumberOfWarheads = (short)Conversions.ToInteger(theNumberOfWarheads);
				}
				if (this.warheadType == Warhead.WarheadType.Cluster_AP || this.warheadType == Warhead.WarheadType.Cluster_AT || this.warheadType == Warhead.WarheadType.Cluster_Penetrator || this.warheadType == Warhead.WarheadType.Cluster_SmartSubs || this.warheadType == Warhead.WarheadType.SuperFrag)
				{
					this.DP *= (float)this.NumberOfWarheads;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100748", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x002F3A84 File Offset: 0x002F1C84
		public static double GetYieldSuffered(Platform Platform_, double Yield_, double ClusterCoverageArea_, float Heading_)
		{
			double result = 0.0;
			try
			{
				Platform_.GetTargetVisualSizeClass();
				if (Platform_.IsFacility && Platform_.GetAirFacilities().Length > 0 && Platform_.GetAirFacilities()[0].IsTakeOffOrLandingFacility())
				{
					float angleBetween = Class263.GetAngleBetween(Platform_.GetCurrentHeading(), Heading_);
					result = Yield_ * 0.1 + Yield_ * 0.9 * (1.0 - Math.Abs(Math.Sin((double)angleBetween * 3.14159265358979 / 180.0)));
				}
				else
				{
					float num = (float)((double)Platform_.GetArea() / ClusterCoverageArea_);
					if (num > 1f)
					{
						num = 1f;
					}
					result = Yield_ * (double)num;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100749", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060061A4 RID: 24996 RVA: 0x002F3B94 File Offset: 0x002F1D94
		public static float smethod_2(Mount mount_0, double double_0, int int_0, float float_1, double double_1, Warhead.WarheadType warheadType_1, Warhead._ExplosivesType enum87_1)
		{
			float result = 0f;
			try
			{
				int maxValue = (int)Math.Round(double_1 / 10.0);
				bool flag;
				if (warheadType_1 == Warhead.WarheadType.Cluster_SmartSubs)
				{
					flag = (GameGeneral.GetRandom().Next(1, 101) > 30);
				}
				else
				{
					flag = (GameGeneral.GetRandom().Next(1, maxValue) <= int_0);
				}
				float num;
				if (flag)
				{
					num = float_1;
				}
				else
				{
					num = (float)(double_0 / double_1);
				}
				switch (enum87_1)
				{
				case Warhead._ExplosivesType.const_37:
					num = (float)((double)num * 1.5);
					break;
				case Warhead._ExplosivesType.const_38:
					num *= 2f;
					break;
				case Warhead._ExplosivesType.const_39:
					num *= 3f;
					break;
				case Warhead._ExplosivesType.const_40:
					num *= 4f;
					break;
				default:
					if (enum87_1 != Warhead._ExplosivesType.const_41)
					{
						if (enum87_1 != Warhead._ExplosivesType.const_42)
						{
						}
					}
					else
					{
						num *= 5f;
					}
					break;
				}
				num = (float)((double)num * ((double)GameGeneral.GetRandom().Next(8, 13) / 10.0));
				result = (float)Math.Min((double)(num * 100f), double_0);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100750", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x002F3CFC File Offset: 0x002F1EFC
		public static float smethod_3(double double_0, Warhead.WarheadType warheadType_1, double Yield_, Weapon._DetonationMedium enum90_0)
		{
			float num = 0f;
			float result;
			try
			{
				if (warheadType_1 != Warhead.WarheadType.HE_BlastFrag)
				{
					if (warheadType_1 != Warhead.WarheadType.Fragmentation)
					{
						if (warheadType_1 != Warhead.WarheadType.DirectionalContinousRod)
						{
							num = 0f;
							result = num;
							return result;
						}
						Yield_ *= 2.0;
					}
				}
				else
				{
					Yield_ = Yield_;
				}
				float num2 = Explosion.smethod_2(Yield_, Weapon._DetonationMedium.Air);
				if (double_0 > (double)num2)
				{
					num = 0f;
				}
				else
				{
					double num3 = Math.Pow((double)((float)(((double)num2 - double_0) / (double)num2)), 2.0);
					double num4 = Yield_ * num3;
					if (num4 > Yield_)
					{
						num4 = Yield_;
					}
					num = (float)num4;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100751", "");
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

		// Token: 0x060061A6 RID: 24998 RVA: 0x002F3DEC File Offset: 0x002F1FEC
		public static float smethod_4(double double_0, double InitialDP_, Warhead.WarheadType warheadType_, double yield_, Weapon._DetonationMedium DetonationMedium_)
		{
			double num = 0.0;
			float result = 0f;
			try
			{
				double num2;
				if (warheadType_ <= Warhead.WarheadType.HardTargetPenetrator)
				{
					switch (warheadType_)
					{
					case Warhead.WarheadType.HE_BlastFrag:
						num2 = yield_;
						goto IL_A4;
					case Warhead.WarheadType.ArmorPiercing:
					case Warhead.WarheadType.Incendiary:
						break;
					case Warhead.WarheadType.HEAT:
						num2 = yield_ / 5.0;
						goto IL_A4;
					case Warhead.WarheadType.Fragmentation:
						num2 = yield_ / 3.0;
						goto IL_A4;
					default:
						if (warheadType_ == Warhead.WarheadType.HardTargetPenetrator)
						{
							num2 = yield_;
							goto IL_A4;
						}
						break;
					}
				}
				else
				{
					if (warheadType_ - Warhead.WarheadType.Torpedo <= 1)
					{
						num2 = yield_;
						goto IL_A4;
					}
					if (warheadType_ == Warhead.WarheadType.Nuclear)
					{
						num2 = yield_ / 2.0;
						goto IL_A4;
					}
				}
				num2 = yield_;
				IL_A4:
				num += num2;
				if (num == 0.0)
				{
					result = 0f;
				}
				else if (double_0 <= 0.00053995680345572358)
				{
					result = (float)num;
				}
				else
				{
					double num3 = (double)Explosion.smethod_1(num, DetonationMedium_);
					if (double_0 > num3)
					{
						result = 0f;
					}
					else
					{
						double x = 1.0 - double_0 / num3;
						double num4;
						if (DetonationMedium_ == Weapon._DetonationMedium.Underwater)
						{
							num4 = Math.Pow(x, 3.0);
						}
						else
						{
							num4 = Math.Pow(x, 2.0);
						}
						result = (float)Math.Min(num * num4, yield_);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100752", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0400348D RID: 13453
		public int DBID;

        // DamagePoints，毁伤点数
        public float DP;

		// 战斗部类型
		public Warhead.WarheadType warheadType;

		// Token: 0x04003490 RID: 13456
		public Warhead._ExplosivesType ExplosivesType;

		// Token: 0x04003491 RID: 13457
		public Warhead.WarheadCaliber Caliber;

		// Token: 0x04003492 RID: 13458
		public short NumberOfWarheads;

		// Token: 0x04003493 RID: 13459
		public short ClusterBombDispersionAreaLength;

		// Token: 0x04003494 RID: 13460
		public short ClusterBombDispersionAreaWidth;

		// Token: 0x04003495 RID: 13461
		public bool Hypothetical;

		// Token: 0x04003496 RID: 13462
		private Weapon weapon;

		// 战斗部类型
		public enum WarheadType
		{			
			None = 1001, // 无            
            HE_BlastFrag = 2001, // 高爆(HE)冲击弹/榴弹           
            ArmorPiercing, // 穿甲弹(AP)            
            HEAT, // 高爆反坦克(HEAT)聚能战斗部            
            Incendiary, // 燃烧弹 (凝固汽油，可湿性粉剂)            
            Fragmentation, // 破片战斗部            
            SemiAP, // 半穿甲战斗部(SAP)            
            HESH, // 高爆碎甲战斗部(HESH)           
            ContinuousRod, // 连杆战斗部            
            HardTargetPenetrator, // 重型钻地战斗部(HTP)			
			FAE,// 云爆弹战斗部(燃料空气炸药 / Thermobaric)			
            SuperFrag,// Token: 0x040034A3 RID: 13475			
			DirectionalContinousRod,// Token: 0x040034A4 RID: 13476			
			Torpedo = 3001,// Token: 0x040034A5 RID: 13477			
			DepthCharge,// Token: 0x040034A6 RID: 13478			
            Nuclear = 4001,// Token: 0x040034A7 RID: 13479			
			Chemical = 4011,// Token: 0x040034A8 RID: 13480			
			Biological = 4021,// Token: 0x040034A9 RID: 13481			
			Weapon = 5002,// Token: 0x040034AA RID: 13482			
			Cluster_AP = 6001,// Token: 0x040034AB RID: 13483			
			Cluster_AT,// Token: 0x040034AC RID: 13484			
			Cluster_Penetrator,// Token: 0x040034AD RID: 13485			
			Cluster_SmartSubs = 6012,// Token: 0x040034AE RID: 13486			
			Landmine_AP = 7001,// Token: 0x040034AF RID: 13487			
			Landmine_AT,// Token: 0x040034B0 RID: 13488			
			LongRodPenetrator = 8001,// Token: 0x040034B1 RID: 13489			
			AntiElectrical = 9001,// Token: 0x040034B2 RID: 13490			
			Leaflet,// Token: 0x040034B3 RID: 13491			
			Laser_COIL = 9101,// Token: 0x040034B4 RID: 13492			
			Laser_CarbonDioxide,// Token: 0x040034B5 RID: 13493			
			Laser_DeuteriumFluoride,// Token: 0x040034B6 RID: 13494			
			Laser_SolidStateFiber,// Token: 0x040034B7 RID: 13495			
			EMP_Directed = 9201,// 定向能			
			EMP_Omni,// Token: 0x040034B9 RID: 13497			
			Kinetic = 9801// Token: 0x040034BA RID: 13498
		}

		// Token: 0x02000B90 RID: 2960
		public enum Enum86
		{
			// Token: 0x040034BC RID: 13500
			const_0,
			// Token: 0x040034BD RID: 13501
			const_1,
			// Token: 0x040034BE RID: 13502
			const_2
		}

		// Token: 0x02000B91 RID: 2961
		public enum _ExplosivesType : short
		{
			// Token: 0x040034C0 RID: 13504
			const_0 = 1001,
			// Token: 0x040034C1 RID: 13505
			const_1 = 2001,
			// Token: 0x040034C2 RID: 13506
			const_2,
			// Token: 0x040034C3 RID: 13507
			const_3,
			// Token: 0x040034C4 RID: 13508
			const_4,
			// Token: 0x040034C5 RID: 13509
			const_5,
			// Token: 0x040034C6 RID: 13510
			const_6,
			// Token: 0x040034C7 RID: 13511
			const_7,
			// Token: 0x040034C8 RID: 13512
			const_8,
			// Token: 0x040034C9 RID: 13513
			const_9,
			// Token: 0x040034CA RID: 13514
			const_10,
			// Token: 0x040034CB RID: 13515
			const_11,
			// Token: 0x040034CC RID: 13516
			const_12,
			// Token: 0x040034CD RID: 13517
			const_13,
			// Token: 0x040034CE RID: 13518
			const_14,
			// Token: 0x040034CF RID: 13519
			const_15,
			// Token: 0x040034D0 RID: 13520
			const_16,
			// Token: 0x040034D1 RID: 13521
			const_17,
			// Token: 0x040034D2 RID: 13522
			const_18,
			// Token: 0x040034D3 RID: 13523
			const_19,
			// Token: 0x040034D4 RID: 13524
			const_20,
			// Token: 0x040034D5 RID: 13525
			const_21,
			// Token: 0x040034D6 RID: 13526
			const_22,
			// Token: 0x040034D7 RID: 13527
			const_23,
			// Token: 0x040034D8 RID: 13528
			const_24 = 2101,
			// Token: 0x040034D9 RID: 13529
			const_25,
			// Token: 0x040034DA RID: 13530
			const_26,
			// Token: 0x040034DB RID: 13531
			const_27 = 2201,
			// Token: 0x040034DC RID: 13532
			const_28,
			// Token: 0x040034DD RID: 13533
			const_29,
			// Token: 0x040034DE RID: 13534
			const_30,
			// Token: 0x040034DF RID: 13535
			const_31 = 2301,
			// Token: 0x040034E0 RID: 13536
			const_32 = 2401,
			// Token: 0x040034E1 RID: 13537
			const_33 = 4001,
			// Token: 0x040034E2 RID: 13538
			const_34 = 4011,
			// Token: 0x040034E3 RID: 13539
			const_35,
			// Token: 0x040034E4 RID: 13540
			const_36 = 6001,
			// Token: 0x040034E5 RID: 13541
			const_37,
			// Token: 0x040034E6 RID: 13542
			const_38,
			// Token: 0x040034E7 RID: 13543
			const_39,
			// Token: 0x040034E8 RID: 13544
			const_40,
			// Token: 0x040034E9 RID: 13545
			const_41 = 6011,
			// Token: 0x040034EA RID: 13546
			const_42 = 7011,
			// Token: 0x040034EB RID: 13547
			const_43,
			// Token: 0x040034EC RID: 13548
			const_44,
			// Token: 0x040034ED RID: 13549
			const_45,
			// Token: 0x040034EE RID: 13550
			const_46,
			// Token: 0x040034EF RID: 13551
			const_47 = 8001,
			// Token: 0x040034F0 RID: 13552
			const_48,
			// Token: 0x040034F1 RID: 13553
			const_49,
			// Token: 0x040034F2 RID: 13554
			const_50,
			// Token: 0x040034F3 RID: 13555
			const_51 = 9001,
			// Token: 0x040034F4 RID: 13556
			const_52,
			// Token: 0x040034F5 RID: 13557
			const_53 = 9101,
			// Token: 0x040034F6 RID: 13558
			const_54 = 9801,
			// Token: 0x040034F7 RID: 13559
			const_55 = 9998
		}

		// 弹头口径
		public enum WarheadCaliber : short
		{
			// Token: 0x040034F9 RID: 13561
			None = 1001,
			// Token: 0x040034FA RID: 13562
			Gun_6_15mm = 2001,
			// Token: 0x040034FB RID: 13563
			Gun_16_24mm,
			// Token: 0x040034FC RID: 13564
			Gun_25_60mm,
			// Token: 0x040034FD RID: 13565
			Gun_61_80mm,
			// Token: 0x040034FE RID: 13566
			Gun_81_150mm,
			// Token: 0x040034FF RID: 13567
			Gun_151_200mm,
			// Token: 0x04003500 RID: 13568
			Gun_201_350mm,
			// Token: 0x04003501 RID: 13569
			Gun_351_450mm,
			// Token: 0x04003502 RID: 13570
			Rocket_6_15mm = 3001,
			// Token: 0x04003503 RID: 13571
			Rocket_16_24mm,
			// Token: 0x04003504 RID: 13572
			Rocket_25_60mm,
			// Token: 0x04003505 RID: 13573
			Rocket_61_80mm,
			// Token: 0x04003506 RID: 13574
			Rocket_81_150mm,
			// Token: 0x04003507 RID: 13575
			Rocket_151_200mm,
			// Token: 0x04003508 RID: 13576
			Rocket_201_350mm,
			// Token: 0x04003509 RID: 13577
			Rocket_351_450mm
		}
	}
}
