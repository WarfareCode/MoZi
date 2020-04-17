using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 非制导武器
	public sealed class UnguidedWeapon : Unit
	{
		// 保存
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("UnguidedWeapon");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (hashSet_0.Contains(base.GetGuid()))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(base.GetGuid());
					xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
					xmlWriter_0.WriteElementString("Name", this.Name);
					xmlWriter_0.WriteElementString("CurrentHeading", XmlConvert.ToString(this.GetCurrentHeading()));
					xmlWriter_0.WriteElementString("CurrentSpeed", XmlConvert.ToString(this.GetCurrentSpeed()));
					xmlWriter_0.WriteElementString("CurrentAltitude", XmlConvert.ToString(this.GetCurrentAltitude_ASL(false)));
					xmlWriter_0.WriteElementString("Longitude", XmlConvert.ToString(this.GetLongitude(null)));
					xmlWriter_0.WriteElementString("Latitude", XmlConvert.ToString(this.GetLatitude(null)));
					if (!Information.IsNothing(this.GetSide(false)))
					{
						xmlWriter_0.WriteElementString("Side", this.GetSide(false).GetSideName());
					}
					xmlWriter_0.WriteElementString("CEP_Surface", XmlConvert.ToString(this.CEP_Surface));
					xmlWriter_0.WriteElementString("CEP_Land", XmlConvert.ToString(this.CEP_Land));
					if (!Information.IsNothing(this.Target))
					{
						xmlWriter_0.WriteElementString("Target", this.Target.GetGuid());
					}
					xmlWriter_0.WriteElementString("TimeToLive", XmlConvert.ToString(this.TimeToLive));
					xmlWriter_0.WriteStartElement("LaunchPoint");
					this.LaunchPoint.Save(ref xmlWriter_0, ref hashSet_0);
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteElementString("TimeToDetonate", XmlConvert.ToString(this.TimeToDetonate));
					if (!Information.IsNothing(this.GetFiringParent()))
					{
						xmlWriter_0.WriteElementString("FiringParent", this.GetFiringParent().GetGuid());
					}
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100852", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// 包含爆炸
		public static bool ContainsBurst(string string_5)
		{
			return string_5.ToLower().Contains("burst");
		}

		// 包含齐射
		public static bool ContainsSalvo(string string_5)
		{
			return string_5.ToLower().Contains("salvo");
		}

		// Token: 0x0600613B RID: 24891 RVA: 0x002E8B3C File Offset: 0x002E6D3C
		public ActiveUnit GetFiringParent()
		{
			ActiveUnit result;
			if (Information.IsNothing(this.FiringParent))
			{
				result = null;
			}
			else if (this.FiringParent.IsNotActive())
			{
				result = null;
			}
			else
			{
				result = this.FiringParent;
			}
			return result;
		}

		// Token: 0x0600613C RID: 24892 RVA: 0x0002B0C5 File Offset: 0x000292C5
		public void SetFiringParent(ActiveUnit activeUnit_1)
		{
			this.FiringParent = activeUnit_1;
		}

		// Token: 0x0600613D RID: 24893 RVA: 0x002E8B80 File Offset: 0x002E6D80
		public void method_54(ref Scenario scenario_0)
		{
			try
			{
				if (!Information.IsNothing(this.FiringParentName))
				{
					scenario_0.GetActiveUnits().TryGetValue(this.FiringParentName, ref this.FiringParent);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101295", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600613E RID: 24894 RVA: 0x002E8C04 File Offset: 0x002E6E04
		public static UnguidedWeapon smethod_2(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			UnguidedWeapon unguidedWeapon = null;
			UnguidedWeapon result;
			try
			{
				int weaponDBID;
				if (Information.IsNothing(Misc.smethod_48(xmlNode_0.ChildNodes, "DBID")))
				{
					weaponDBID = DBFunctions.smethod_12(Misc.smethod_48(xmlNode_0.ChildNodes, "Name").InnerText, GlobalVariables.ActiveUnitType.Weapon, scenario_0.GetSQLiteConnection());
				}
				else
				{
					weaponDBID = Conversions.ToInteger(Misc.smethod_48(xmlNode_0.ChildNodes, "DBID").InnerText);
				}
				Weapon theReferenceWeapon = scenario_0.GetWeapon(weaponDBID);
				UnguidedWeapon unguidedWeapon2 = new UnguidedWeapon(theReferenceWeapon, null, null, 0.0, 0.0, 0L);
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 2532358002u)
						{
							if (num <= 1458105184u)
							{
								if (num <= 441941816u)
								{
									if (num != 266367750u)
									{
										if (num == 441941816u && Operators.CompareString(name, "CurrentAltitude", false) == 0)
										{
											unguidedWeapon2.SetAltitude_ASL(false, XmlConvert.ToSingle(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Name", false) == 0)
										{
											unguidedWeapon2.Name = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num != 1029238175u)
								{
									if (num != 1458105184u || Operators.CompareString(name, "ID", false) != 0)
									{
										continue;
									}
									if (!dictionary_0.ContainsKey(xmlNode.InnerText))
									{
										unguidedWeapon2.SetGuid(xmlNode.InnerText);
										dictionary_0.Add(unguidedWeapon2.GetGuid(), unguidedWeapon2);
										continue;
									}
									unguidedWeapon = (UnguidedWeapon)dictionary_0[xmlNode.InnerText];
									result = unguidedWeapon;
									return result;
								}
								else if (Operators.CompareString(name, "CEP", false) != 0)
								{
									continue;
								}
							}
							else if (num <= 1836990821u)
							{
								if (num != 1729717486u)
								{
									if (num == 1836990821u && Operators.CompareString(name, "Latitude", false) == 0)
									{
										unguidedWeapon2.SetLatitude(null, (double)XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Longitude", false) == 0)
									{
										unguidedWeapon2.SetLongitude(null, (double)XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num != 2338845032u)
							{
								if (num == 2532358002u && Operators.CompareString(name, "FiringParent", false) == 0)
								{
									unguidedWeapon2.FiringParentName = xmlNode.InnerText;
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Target", false) == 0)
								{
									unguidedWeapon2.Target = Contact.GetContact(xmlNode.InnerText, ref dictionary_0);
									continue;
								}
								continue;
							}
						}
						else if (num <= 2883730117u)
						{
							if (num <= 2590053246u)
							{
								if (num != 2545405656u)
								{
									if (num == 2590053246u && Operators.CompareString(name, "Side", false) == 0)
									{
										unguidedWeapon2.SetSide(false, Side.GetSideByName(xmlNode.InnerText, ref dictionary_0));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "LaunchPoint", false) == 0)
									{
										UnguidedWeapon unguidedWeapon3 = unguidedWeapon2;
										XmlNode xmlNode2 = xmlNode.ChildNodes[0];
										unguidedWeapon3.LaunchPoint = GeoPoint.Load(ref xmlNode2, ref dictionary_0);
										continue;
									}
									continue;
								}
							}
							else if (num != 2698398137u)
							{
								if (num == 2883730117u && Operators.CompareString(name, "CEP_Land", false) == 0)
								{
									unguidedWeapon2.CEP_Land = XmlConvert.ToSingle(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "TimeToDetonate", false) == 0)
								{
									unguidedWeapon2.TimeToDetonate = XmlConvert.ToSingle(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 3089922411u)
						{
							if (num != 3041073015u)
							{
								if (num != 3089922411u || Operators.CompareString(name, "CEP_Surface", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "TimeToLive", false) == 0)
								{
									unguidedWeapon2.TimeToLive = XmlConvert.ToSingle(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num != 3283119613u)
						{
							if (num == 4152621540u && Operators.CompareString(name, "CurrentHeading", false) == 0)
							{
								unguidedWeapon2.SetCurrentHeading(XmlConvert.ToSingle(xmlNode.InnerText));
								continue;
							}
							continue;
						}
						else
						{
							if (Operators.CompareString(name, "CurrentSpeed", false) == 0)
							{
								unguidedWeapon2.SetCurrentSpeed(XmlConvert.ToSingle(xmlNode.InnerText));
								continue;
							}
							continue;
						}
						unguidedWeapon2.CEP_Surface = XmlConvert.ToSingle(xmlNode.InnerText);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				unguidedWeapon = unguidedWeapon2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100853", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = unguidedWeapon;
			return result;
		}

		// Token: 0x0600613F RID: 24895 RVA: 0x0002B0CE File Offset: 0x000292CE
		private UnguidedWeapon()
		{
			this.WarheadArray = new Warhead[0];
			this.weaponCode = default(Weapon.WeaponCode);
		}

		// Token: 0x06006140 RID: 24896 RVA: 0x002E91B0 File Offset: 0x002E73B0
		public Weapon GetWeapon()
		{
			return this.weapon;
		}

		// Token: 0x06006141 RID: 24897 RVA: 0x002E91C8 File Offset: 0x002E73C8
		public float GetTimeToDetonate()
		{
			return this.TimeToDetonate;
		}

		// Token: 0x06006142 RID: 24898 RVA: 0x002E91E0 File Offset: 0x002E73E0
		public Weapon._WeaponType GetWeaponType()
		{
			return this.weaponType;
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x0002B0F9 File Offset: 0x000292F9
		public bool IsMineOrDepthCharge()
		{
			return this.IsMine() || this.GetWeaponType() == Weapon._WeaponType.DepthCharge;
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x002E91F8 File Offset: 0x002E73F8
		public bool IsMine()
		{
			bool result;
			switch (this.GetWeaponType())
			{
			case Weapon._WeaponType.BottomMine:
			case Weapon._WeaponType.MooredMine:
			case Weapon._WeaponType.FloatingMine:
			case Weapon._WeaponType.MovingMine:
			case Weapon._WeaponType.RisingMine:
				result = true;
				break;
			default:
				result = false;
				break;
			}
			return result;
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x002E9238 File Offset: 0x002E7438
		public WeaponSalvo GetWeaponSalvoForTheWeapon(Scenario scenario_0)
		{
			Side[] sides = scenario_0.GetSides();
			checked
			{
				WeaponSalvo weaponSalvo2;
				WeaponSalvo result;
				for (int i = 0; i < sides.Length; i++)
				{
					WeaponSalvo[] weaponSalvos = sides[i].WeaponSalvos;
					for (int j = 0; j < weaponSalvos.Length; j++)
					{
						WeaponSalvo weaponSalvo = weaponSalvos[j];
						if (weaponSalvo.WeaponObjectIDArray.Contains(base.GetGuid()))
						{
							weaponSalvo2 = weaponSalvo;
							result = weaponSalvo2;
							return result;
						}
					}
				}
				weaponSalvo2 = null;
				result = weaponSalvo2;
				return result;
			}
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x002E92A4 File Offset: 0x002E74A4
		public WeaponSalvo.Shooter GetShooterForTheWeapon(Scenario scenario_0)
		{
			checked
			{
				WeaponSalvo.Shooter shooter2;
				WeaponSalvo.Shooter result;
				if (!Information.IsNothing(this.FiringParent))
				{
					Side[] sides = scenario_0.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						WeaponSalvo[] weaponSalvos = sides[i].WeaponSalvos;
						for (int j = 0; j < weaponSalvos.Length; j++)
						{
							WeaponSalvo weaponSalvo = weaponSalvos[j];
							if (weaponSalvo.WeaponObjectIDArray.Contains(base.GetGuid()))
							{
								WeaponSalvo.Shooter[] shooters = weaponSalvo.m_Shooters;
								for (int k = 0; k < shooters.Length; k++)
								{
									WeaponSalvo.Shooter shooter = shooters[k];
									if (Operators.CompareString(shooter.ShooterObjectID, this.FiringParent.GetGuid(), false) == 0)
									{
										shooter2 = shooter;
										result = shooter2;
										return result;
									}
								}
							}
						}
					}
				}
				shooter2 = null;
				result = shooter2;
				return result;
			}
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x002E936C File Offset: 0x002E756C
		public UnguidedWeapon(Weapon theReferenceWeapon, Contact theTarget, ActiveUnit FiringUnit, double theLatitude, double theLongitude, long ArmDelay_Sec = 0L)
		{
			this.WarheadArray = new Warhead[0];
			this.weaponCode = default(Weapon.WeaponCode);
			try
			{
				this.DBID = theReferenceWeapon.DBID;
				this.weapon = theReferenceWeapon;
				this.UnitClass = theReferenceWeapon.UnitClass;
				this.Name = theReferenceWeapon.Name;
				this.weaponType = theReferenceWeapon.GetWeaponType();
				this.CruiseAltitude = theReferenceWeapon.CruiseAltitude;
				this.CruiseAltitude_ASL = theReferenceWeapon.GetCruiseAltitude_ASL();
				this.SurfacePOK = (float)theReferenceWeapon.SurfacePOK;
				this.LandPOK = (float)theReferenceWeapon.LandPOK;
				this.SubsurfacePOK = (float)theReferenceWeapon.SubsurfacePOK;
				this.AirPOK = (float)theReferenceWeapon.AirPOK;
				this.AirRangeMax = theReferenceWeapon.RangeAAWMax;
				this.AirRangeMin = theReferenceWeapon.RangeAAWMin;
				this.SurfaceRangeMax = theReferenceWeapon.RangeASUWMax;
				this.SurfaceRangeMin = theReferenceWeapon.RangeASUWMin;
				this.LandRangeMax = theReferenceWeapon.RangeLandMax;
				this.LandRangeMin = theReferenceWeapon.RangeLandMin;
				this.SubsurfaceRangeMax = theReferenceWeapon.RangeASWMax;
				this.SubsurfaceRangeMin = theReferenceWeapon.RangeASWMin;
				this.LaunchAltitudeMax = theReferenceWeapon.LaunchAltitudeMax;
				this.LaunchAltitudeMin = theReferenceWeapon.LaunchAltitudeMin;
				this.LaunchAltitudeMax_ASL = theReferenceWeapon.LaunchAltitudeMax_ASL;
				this.LaunchAltitudeMin_ASL = theReferenceWeapon.LaunchAltitudeMin_ASL;
				this.TargetAltitudeMax = theReferenceWeapon.TargetAltitudeMax;
				this.TargetAltitudeMin = theReferenceWeapon.TargetAltitudeMin;
				this.TargetAltitudeMax_ASL = theReferenceWeapon.TargetAltitudeMax_ASL;
				this.TargetAltitudeMin_ASL = theReferenceWeapon.TargetAltitudeMin_ASL;
				this.CEP_Land = (float)theReferenceWeapon.GetCEP_Land();
				this.CEP_Surface = (float)theReferenceWeapon.GetCEP_Surface();
				if (ArmDelay_Sec == 0L)
				{
					this.TimeToDetonate = theReferenceWeapon.DetonationDelay;
				}
				else
				{
					this.TimeToDetonate = (float)ArmDelay_Sec;
				}
				if (!Information.IsNothing(FiringUnit))
				{
					this.FiringParentName = FiringUnit.GetGuid();
				}
				if (this.weaponType == Weapon._WeaponType.Laser)
				{
					this.TimeToDetonate = 2f;
				}
				DBFunctions.LoadWeaponCodesData(ref theReferenceWeapon, ref this.weaponCode);
				DBFunctions.LoadWeaponWarheadsData(ref this.WarheadArray, ref theReferenceWeapon);
				this.Target = theTarget;
				if (!Information.IsNothing(FiringUnit) && !Information.IsNothing(theTarget))
				{
					float currentSpeed = FiringUnit.GetCurrentSpeed();
					double num = (double)GameGeneral.GetRandom().Next(95, 106) / 100.0;
					Weapon._WeaponType weaponType = this.weaponType;
					switch (weaponType)
					{
					case Weapon._WeaponType.Rocket:
						switch (theTarget.contactType)
						{
						case Contact_Base.ContactType.Air:
						case Contact_Base.ContactType.Missile:
						case Contact_Base.ContactType.Orbital:
							this.SetCurrentSpeed((float)((double)(currentSpeed + this.AirRangeMax * 100f) * num));
							break;
						case Contact_Base.ContactType.Surface:
						case Contact_Base.ContactType.Facility_Fixed:
						case Contact_Base.ContactType.Facility_Mobile:
							this.SetCurrentSpeed((float)((double)(currentSpeed + this.SurfaceRangeMax * 100f) * num));
							break;
						case Contact_Base.ContactType.Submarine:
						case Contact_Base.ContactType.UndeterminedNaval:
						case Contact_Base.ContactType.Aimpoint:
							this.SetCurrentSpeed((float)((double)(currentSpeed + this.SubsurfaceRangeMax * 100f) * num));
							break;
						default:
							this.SetCurrentSpeed((float)((double)(currentSpeed + this.SubsurfaceRangeMax * 100f) * num));
							break;
						}
						break;
					case Weapon._WeaponType.IronBomb:
						if (this.weaponCode.IsRetardedMunition)
						{
							this.SetCurrentSpeed((float)((double)currentSpeed * 0.4 * num));
						}
						else
						{
							this.SetCurrentSpeed((float)((double)currentSpeed * 0.9 * num));
						}
						break;
					case Weapon._WeaponType.Gun:
					{
						double num2 = UnguidedWeapon.smethod_4(theTarget.contactType, this.GetWeapon().GetLargestRangeMaxOfAllDomains(), this.method_65()) * 1.94384;
						this.SetCurrentSpeed((float)((double)currentSpeed + num2 * num));
						Warhead.WarheadType warheadType = this.WarheadArray[0].warheadType;
						if (warheadType == Warhead.WarheadType.ArmorPiercing || warheadType == Warhead.WarheadType.LongRodPenetrator)
						{
							this.SetCurrentSpeed((float)((double)(this.GetCurrentSpeed() * 2f) * num));
						}
						break;
					}
					default:
						if (weaponType == Weapon._WeaponType.DepthCharge)
						{
							this.SetCurrentSpeed((float)((double)(currentSpeed / 2f) + (double)(this.SubsurfaceRangeMax * 5f) * num));
						}
						break;
					}
				}
				if (Information.IsNothing(FiringUnit))
				{
					this.LaunchPoint = new GeoPoint(theLongitude, theLatitude, 0f);
				}
				else
				{
					this.LaunchPoint = new GeoPoint(theLongitude, theLatitude, FiringUnit.GetCurrentAltitude_ASL(false));
				}
				this.SetLatitude(null, theLatitude);
				this.SetLongitude(null, theLongitude);
				if (this.GetWeaponType() == Weapon._WeaponType.IronBomb && !Information.IsNothing(FiringUnit) && !Information.IsNothing(theTarget))
				{
					float num3 = Math.Abs(FiringUnit.GetCurrentAltitude_ASL(false) - theTarget.GetCurrentAltitude_ASL(false));
					float num4;
					if (num3 > 5000f)
					{
						num4 = 33f + (num3 - 5000f) / 300f;
					}
					else
					{
						num4 = (float)Math.Sqrt((double)num3 / 4.5);
					}
					this.TimeToDetonate = Math.Max(num4, this.TimeToDetonate);
					if (num4 > 0f)
					{
						this.SetCurrentSpeed(Math.Min(FiringUnit.GetCurrentSpeed() - 10f, 3600f * FiringUnit.GetHorizontalRange(theTarget) / num4));
					}
					this.TimeToLive = this.TimeToDetonate + 1f;
				}
				else
				{
					double val = 3600.0 * this.GetRangeMax() / (double)this.GetCurrentSpeed();
					this.TimeToLive = (float)Math.Max(val, (double)(this.GetTimeToDetonate() + 1f));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100854", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x002E9928 File Offset: 0x002E7B28
		public float method_62()
		{
			float result;
			if (this.WarheadArray.Length == 0)
			{
				result = 0f;
			}
			else if (this.WarheadArray[0].method_15())
			{
				result = 800f;
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x002E9978 File Offset: 0x002E7B78
		private double GetRangeMax()
		{
			return (double)Math.Max(this.AirRangeMax, Math.Max(this.SurfaceRangeMax, Math.Max(this.LandRangeMax, this.SubsurfaceRangeMax)));
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x002E99B0 File Offset: 0x002E7BB0
		public static string LayMine(ref UnguidedWeapon unguidedWeapon_0, double double_2, double double_3, float depth, Scenario scenario_0)
		{
			string text = "";
			string result;
			try
			{
				if (depth > 0f)
				{
					text = "Cannot lay naval mines over land!";
				}
				else
				{
					switch (unguidedWeapon_0.GetWeaponType())
					{
					case Weapon._WeaponType.BottomMine:
						if (scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(scenario_0.GetSQLiteConnection()))
						{
							if (depth < unguidedWeapon_0.TargetAltitudeMin_ASL)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									text = string.Concat(new string[]
									{
										"Water is too deep. Maximum mine depth is ",
										Conversions.ToString((int)Math.Round((double)(unguidedWeapon_0.TargetAltitudeMin_ASL * 3.28084f))),
										" ft while water depth is ",
										Conversions.ToString((int)Math.Round((double)(depth * 3.28084f))),
										" ft."
									});
									result = text;
									return result;
								}
								text = string.Concat(new string[]
								{
									"Water is too deep. Maximum mine depth is ",
									Conversions.ToString((int)Math.Round((double)unguidedWeapon_0.TargetAltitudeMin_ASL)),
									" m while water depth is ",
									Conversions.ToString((int)Math.Round((double)depth)),
									" m."
								});
								result = text;
								return result;
							}
							else if (depth > -5f)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									text = string.Concat(new string[]
									{
										"Water is too shallow. Minimum mine depth is ",
										Conversions.ToString(16),
										" ft while sea depth is ",
										Conversions.ToString((int)Math.Round((double)(depth * 3.28084f))),
										" ft."
									});
									result = text;
									return result;
								}
								text = string.Concat(new string[]
								{
									"Water is too shallow. Minimum mine depth is ",
									Conversions.ToString(5),
									" m while sea depth is ",
									Conversions.ToString((int)Math.Round((double)depth)),
									" m."
								});
								result = text;
								return result;
							}
						}
						else if (depth < unguidedWeapon_0.TargetAltitudeMin)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								text = string.Concat(new string[]
								{
									"Water is too deep. Maximum mine depth is ",
									Conversions.ToString((int)Math.Round((double)(unguidedWeapon_0.TargetAltitudeMin * 3.28084f))),
									" ft while water depth is ",
									Conversions.ToString((int)Math.Round((double)(depth * 3.28084f))),
									" ft."
								});
								result = text;
								return result;
							}
							text = string.Concat(new string[]
							{
								"Water is too deep. Maximum mine depth is ",
								Conversions.ToString((int)Math.Round((double)unguidedWeapon_0.TargetAltitudeMin)),
								" m while water depth is ",
								Conversions.ToString((int)Math.Round((double)depth)),
								" m."
							});
							result = text;
							return result;
						}
						else if (depth > -5f)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								text = string.Concat(new string[]
								{
									"Water is too shallow. Minimum mine depth is ",
									Conversions.ToString(16),
									" ft while sea depth is ",
									Conversions.ToString((int)Math.Round((double)(depth * 3.28084f))),
									" ft."
								});
								result = text;
								return result;
							}
							text = string.Concat(new string[]
							{
								"Water is too shallow. Minimum mine depth is ",
								Conversions.ToString(5),
								" m while sea depth is ",
								Conversions.ToString((int)Math.Round((double)depth)),
								" m."
							});
							result = text;
							return result;
						}
						unguidedWeapon_0.SetAltitude_ASL(false, depth);
						break;
					case Weapon._WeaponType.MooredMine:
					case Weapon._WeaponType.MovingMine:
					case Weapon._WeaponType.RisingMine:
						if (scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(scenario_0.GetSQLiteConnection()))
						{
							if (depth < unguidedWeapon_0.TargetAltitudeMin_ASL)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									text = string.Concat(new string[]
									{
										"Water is too deep. Maximum mine depth is ",
										Conversions.ToString((int)Math.Round((double)(unguidedWeapon_0.TargetAltitudeMin_ASL * 3.28084f))),
										" ft while water depth is ",
										Conversions.ToString((int)Math.Round((double)(depth * 3.28084f))),
										" ft."
									});
									result = text;
									return result;
								}
								text = string.Concat(new string[]
								{
									"Water is too deep. Maximum mine depth is ",
									Conversions.ToString((int)Math.Round((double)unguidedWeapon_0.TargetAltitudeMin_ASL)),
									" m while water depth is ",
									Conversions.ToString((int)Math.Round((double)depth)),
									" m."
								});
								result = text;
								return result;
							}
							else if (depth > unguidedWeapon_0.TargetAltitudeMax_ASL)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									text = string.Concat(new string[]
									{
										"Water is too shallow. Minimum mine depth is ",
										Conversions.ToString((int)Math.Round((double)(unguidedWeapon_0.TargetAltitudeMax_ASL * 3.28084f))),
										" ft while sea depth is ",
										Conversions.ToString((int)Math.Round((double)(depth * 3.28084f))),
										" ft."
									});
									result = text;
									return result;
								}
								text = string.Concat(new string[]
								{
									"Water is too shallow. Minimum mine depth is ",
									Conversions.ToString((int)Math.Round((double)unguidedWeapon_0.TargetAltitudeMax_ASL)),
									" m while sea depth is ",
									Conversions.ToString((int)Math.Round((double)depth)),
									" m."
								});
								result = text;
								return result;
							}
						}
						else if (depth < unguidedWeapon_0.TargetAltitudeMin)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								text = string.Concat(new string[]
								{
									"Water is too deep. Maximum mine depth is ",
									Conversions.ToString((int)Math.Round((double)(unguidedWeapon_0.TargetAltitudeMin * 3.28084f))),
									" ft while water depth is ",
									Conversions.ToString((int)Math.Round((double)(depth * 3.28084f))),
									" ft."
								});
								result = text;
								return result;
							}
							text = string.Concat(new string[]
							{
								"Water is too deep. Maximum mine depth is ",
								Conversions.ToString((int)Math.Round((double)unguidedWeapon_0.TargetAltitudeMin)),
								" m while water depth is ",
								Conversions.ToString((int)Math.Round((double)depth)),
								" m."
							});
							result = text;
							return result;
						}
						else if (depth > unguidedWeapon_0.TargetAltitudeMax)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								text = string.Concat(new string[]
								{
									"Water is too shallow. Minimum mine depth is ",
									Conversions.ToString((int)Math.Round((double)(unguidedWeapon_0.TargetAltitudeMax * 3.28084f))),
									" ft while sea depth is ",
									Conversions.ToString((int)Math.Round((double)(depth * 3.28084f))),
									" ft."
								});
								result = text;
								return result;
							}
							text = string.Concat(new string[]
							{
								"Water is too shallow. Minimum mine depth is ",
								Conversions.ToString((int)Math.Round((double)unguidedWeapon_0.TargetAltitudeMax_ASL)),
								" m while sea depth is ",
								Conversions.ToString((int)Math.Round((double)depth)),
								" m."
							});
							result = text;
							return result;
						}
						unguidedWeapon_0.SetAltitude_ASL(false, (float)((double)depth + GameGeneral.GetRandom().NextDouble() * -(double)depth - 5.0));
						break;
					case Weapon._WeaponType.FloatingMine:
						unguidedWeapon_0.SetAltitude_ASL(false, 0f);
						break;
					}
					unguidedWeapon_0.SetLatitude(null, double_2);
					unguidedWeapon_0.SetLongitude(null, double_3);
					text = "OK";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100855", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = text;
			return result;
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x002EA164 File Offset: 0x002E8364
		public void Detonation(Scenario scenario_)
		{
			try
			{
				float theAltitude;
				if (this.GetWeapon().HasNuclearWarhead())
				{
					if (this.GetWeaponType() == Weapon._WeaponType.DepthCharge)
					{
						if (!Information.IsNothing(this.GetWeapon().GetWeaponAI().GetPrimaryTarget()) && (this.GetWeapon().GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.ActivationPoint || this.GetWeapon().GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.Aimpoint))
						{
							theAltitude = (float)Math.Max(base.GetTerrainElevation(false, false, false), -300);
						}
						else if (!Information.IsNothing(this.Target) && (this.Target.contactType == Contact_Base.ContactType.ActivationPoint || this.Target.contactType == Contact_Base.ContactType.Aimpoint))
						{
							theAltitude = (float)Math.Max(base.GetTerrainElevation(false, false, false), -300);
						}
						else
						{
							theAltitude = this.GetCurrentAltitude_ASL(false);
						}
					}
					else
					{
						theAltitude = this.method_62() + (float)Math.Max(0, base.GetTerrainElevation(false, false, false));
					}
				}
				else
				{
					theAltitude = this.GetCurrentAltitude_ASL(false);
				}
				new Explosion(ref scenario_, this.GetLongitude(null), this.GetLatitude(null), this.GetLongitude(null), this.GetLatitude(null), this.GetCurrentHeading(), theAltitude, this.WarheadArray[0].DP, this.WarheadArray[0].DP, this.WarheadArray[0].warheadType, this.WarheadArray[0].ExplosivesType, null, null, this.GetFiringParent(), null, null, 0, 0, 0, 0f, 0);
				this.ExportUnitDestroyed(ref scenario_);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100856", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600614C RID: 24908 RVA: 0x002EA37C File Offset: 0x002E857C
		private bool method_65()
		{
			bool result;
			if (!this.nullable_10.HasValue)
			{
				if (Information.IsNothing(this.GetFiringParent()) || Information.IsNothing(this.Target))
				{
					result = false;
					return result;
				}
				this.nullable_10 = new bool?((this.GetWeaponType() == Weapon._WeaponType.Gun || this.GetWeaponType() == Weapon._WeaponType.Rocket) && !this.GetFiringParent().IsAircraft && !(this.Target.IsAir() | this.Target.IsMissileOrTorpedo()));
			}
			result = this.nullable_10.Value;
			return result;
		}

		// Token: 0x0600614D RID: 24909 RVA: 0x002EA418 File Offset: 0x002E8618
		private void method_66(Scenario scenario_, float t)
		{
			this.method_77();
			this.GetLatitude(null);
			this.GetLongitude(null);
			double num = UnguidedWeapon.smethod_4(this.Target.contactType, this.GetWeapon().GetLargestRangeMaxOfAllDomains(), this.method_65());
			if (this.method_65())
			{
				this.TimeToLive = 3.40282347E+38f;
				double num2 = (double)this.LaunchPoint.GetDistance(this.Target.GetLongitude(null), this.Target.GetLatitude(null));
				double num3 = num2 / (double)this.GetWeapon().GetLargestRangeMaxOfAllDomains();
				double degrees = 35.0 * num3;
				double num4 = Math.Pow(num, 2.0) * Math.Pow(Math2.Sin_D(degrees), 2.0) / 19.62;
				double num5 = (double)this.GetCurrentSpeed() * Math2.Cos_D(degrees);
				double value = 0.0;
				double value2 = 0.0;
				GeoPointGenerator.GetOtherGeoPoint(this.GetLongitude(null), this.GetLatitude(null), ref value, ref value2, num5 * (double)t / 3600.0, (double)this.GetCurrentHeading());
				this.SetLongitude(null, value);
				this.SetLatitude(null, value2);
				double num6 = num2 * 1852.0 / 2.0;
				double num7 = num4 / Math.Pow(num6, 2.0);
				double x = Math.Abs((double)(base.HorizontalRangeTo(this.LaunchPoint) * 1852f) - num6);
				double num8 = -(num7 * Math.Pow(x, 2.0)) + num4;
				this.SetAltitude_ASL(false, (float)(num8 + (double)this.LaunchPoint.GetAltitude()));
			}
			else
			{
				base.Move(t, false);
				float num9 = Math.Abs(this.LaunchPoint.GetAltitude() - this.Target.GetCurrentAltitude_ASL(false));
				double num10 = (double)this.LaunchPoint.GetDistance(this.Target.GetLongitude(null), this.Target.GetLatitude(null));
				double num11 = (double)base.GetHorizontalRange(this.Target) / num10;
				if (this.Target.GetCurrentAltitude_ASL(false) > this.LaunchPoint.GetAltitude())
				{
					this.SetAltitude_ASL(false, (float)((double)this.Target.GetCurrentAltitude_ASL(false) - (double)num9 * num11));
				}
				else
				{
					this.SetAltitude_ASL(false, (float)((double)this.Target.GetCurrentAltitude_ASL(false) + (double)num9 * num11));
				}
			}
			if (this.GetWeaponType() == Weapon._WeaponType.Gun)
			{
				double num12 = (double)(base.SlantRangeTo(this.LaunchPoint) / this.GetWeapon().GetLargestRangeMaxOfAllDomains());
				double num13 = num * 1.94384;
				this.SetCurrentSpeed((float)(num13 * (0.34 + 0.67 * (1.0 - num12))));
			}
			this.ExportUnitPositions(scenario_);
		}

		// Token: 0x0600614E RID: 24910 RVA: 0x002EA740 File Offset: 0x002E8940
		public void method_67(ref Scenario scenario_, float elapsedTime_, ref Random random_)
		{
			try
			{
				if (this.IsMine())
				{
					this.method_69(scenario_, elapsedTime_, ref random_);
				}
				else
				{
					if (this.TimeToDetonate > 0f)
					{
						this.TimeToDetonate -= elapsedTime_;
					}
					if (!Information.IsNothing(this.Target))
					{
						if ((this.GetWeaponType() != Weapon._WeaponType.IronBomb && base.HorizontalRangeTo(this.Target.GetLatitude(null), this.Target.GetLongitude(null)) * 2f < this.GetCurrentSpeed() / 3600f) || (this.GetWeaponType() == Weapon._WeaponType.IronBomb && this.TimeToDetonate <= 0f))
						{
							try
							{
								if (base.GetAltitude_AGL() < 0f)
								{
									this.SetAltitude_ASL(false, (float)base.GetTerrainElevation(false, false, false));
								}
								if (this.GetCurrentAltitude_ASL(false) < 0f)
								{
									this.SetAltitude_ASL(false, this.Target.GetCurrentAltitude_ASL(false));
								}
								this.method_72(this.Target.ActualUnit, this.Target, ref scenario_, ref random_);
								this.ExportUnitDestroyed(ref scenario_);
								goto IL_171;
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ex2.Data.Add("Error at 200042", ex2.Message);
								GameGeneral.LogException(ref ex2);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								ProjectData.ClearProjectError();
								goto IL_171;
							}
						}
						this.method_66(scenario_, elapsedTime_);
						IL_171:
						if (this.weaponType == Weapon._WeaponType.Laser && this.TimeToDetonate <= 0f)
						{
							this.method_72(this.Target.ActualUnit, this.Target, ref scenario_, ref random_);
							this.ExportUnitDestroyed(ref scenario_);
						}
					}
					this.TimeToLive -= elapsedTime_;
					if (this.TimeToLive <= 0f)
					{
						this.ExportUnitDestroyed(ref scenario_);
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100857", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600614F RID: 24911 RVA: 0x002EA998 File Offset: 0x002E8B98
		private void ExportUnitPositions(Scenario scenario_0)
		{
			foreach (IEventExporter current in scenario_0.GetEventExporters())
			{
				if (current.IsExportUnitPositions() && !Information.IsNothing(this.GetFiringParent()) && !Information.IsNothing(this.GetFiringParent().GetSide(false)))
				{
					Dictionary<string, Tuple<Type, string>> dictionary = new Dictionary<string, Tuple<Type, string>>(11);
					dictionary.Add("TimelineID", new Tuple<Type, string>(typeof(string), scenario_0.TimelineID));
					if (current.IsUseZeroHour())
					{
						TimeSpan timeSpan = scenario_0.GetCurrentTime(false).Subtract(scenario_0.ZeroHour);
						dictionary.Add("Time", new Tuple<Type, string>(typeof(TimeSpan), timeSpan.ToString("c")));
					}
					else
					{
						dictionary.Add("Time", new Tuple<Type, string>(typeof(DateTime), scenario_0.GetCurrentTime(false).ToString("MM/dd/yyyy HH:mm:ss") + "." + scenario_0.GetCurrentTime(false).Millisecond.ToString("D3")));
					}
					dictionary.Add("UnitID", new Tuple<Type, string>(typeof(string), base.GetGuid()));
					dictionary.Add("UnitName", new Tuple<Type, string>(typeof(string), this.GetWeapon().Name));
					dictionary.Add("UnitClass", new Tuple<Type, string>(typeof(string), this.GetWeapon().UnitClass));
					dictionary.Add("UnitSide", new Tuple<Type, string>(typeof(string), this.GetFiringParent().GetSide(false).GetSideName()));
					dictionary.Add("UnitLongitude", new Tuple<Type, string>(typeof(double), this.GetLongitude(null).ToString()));
					dictionary.Add("UnitLatitude", new Tuple<Type, string>(typeof(double), this.GetLatitude(null).ToString()));
					dictionary.Add("UnitCourse", new Tuple<Type, string>(typeof(float), this.GetCurrentHeading().ToString()));
					dictionary.Add("UnitSpeed_kts", new Tuple<Type, string>(typeof(float), this.GetCurrentSpeed().ToString()));
					dictionary.Add("UnitAltitude_m", new Tuple<Type, string>(typeof(float), this.GetCurrentAltitude_ASL(false).ToString()));
					current.ExportEvent(ExportedEventType.UnitPositions, dictionary, scenario_0);
				}
			}
		}

		// Token: 0x06006150 RID: 24912 RVA: 0x002EAC6C File Offset: 0x002E8E6C
		private void method_69(Scenario scenario_, float float_34, ref Random random_0)
		{
			try
			{
				if (this.TimeToDetonate > 0f)
				{
					this.TimeToDetonate = Math.Max(0f, this.TimeToDetonate - float_34);
				}
				if (this.TimeToDetonate <= 0f)
				{
					this.float_33 -= float_34;
					ActiveUnit activeUnit = null;
					if (this.float_33 <= 0f)
					{
						bool flag = false;
						bool flag2 = false;
						if (scenario_.CandidatesForDetectionByMines.Length != 0)
						{
							int maxMineRange = scenario_.CandidatesForDetectionByMines[0].GetMaxMineRange();
							List<ActiveUnit> unitsInRange = RangeCalculator.GetUnitsInRange(scenario_.CandidatesForDetectionByMines, true, this.GetLatitude(null), this.GetLongitude(null), (double)maxMineRange / 1852.0);
							int value = 0;
							List<ActiveUnit>.Enumerator enumerator = unitsInRange.GetEnumerator();
							int value2 = 0;
							try
							{
								while (enumerator.MoveNext())
								{
									ActiveUnit current = enumerator.Current;
									try
									{
										double num = Math2.ApproxAngularDistance((double)((float)((double)current.GetMaxMineRange(this.GetWeaponType()) / 1852.0)));
										if (this.GetWeaponType() == Weapon._WeaponType.RisingMine && !current.IsMineSweeper())
										{
											Weapon weaponFromDP = this.WarheadArray[0].GetWeaponFromDP(current.m_Scenario);
											if (!Information.IsNothing(weaponFromDP))
											{
												num = Math2.ApproxAngularDistance((double)weaponFromDP.GetLargestRangeMaxOfAllDomains());
											}
										}
										int num2;
										if (current.IsMineSweeper())
										{
											num2 = 5;
										}
										else
										{
											num2 = 1;
										}
										if (!current.IsAircraft && base.GetApproxAngularDistanceInDegrees(current) <= num && (float)num2 < current.GetCurrentSpeed() && (this.GetWeaponType() == Weapon._WeaponType.RisingMine || base.GetDesiredSpeed(current, this.GetCurrentSpeed(), this.GetCurrentHeading()) < 0f))
										{
											flag = true;
											activeUnit = current;
											value = (int)Math.Round((double)(base.GetHorizontalRange(activeUnit) * 1852f));
											value2 = (int)Math.Round((double)Math2.GetAzimuth(activeUnit.GetLatitude(null), activeUnit.GetLongitude(null), this.GetLatitude(null), this.GetLongitude(null)));
											break;
										}
										foreach (Sensor current2 in current.GetMineCounterMeasures())
										{
											if (current2.IsSuitableMineCounterMeasureForWeapon(this) && this.vmethod_39(current2.GetMineSweepingAreaVertices(), scenario_, false))
											{
												flag = true;
												flag2 = true;
												activeUnit = current;
												value = (int)Math.Round((double)(base.GetHorizontalRange(activeUnit) * 1852f));
												value2 = (int)Math.Round((double)Math2.GetAzimuth(activeUnit.GetLatitude(null), activeUnit.GetLongitude(null), this.GetLatitude(null), this.GetLongitude(null)));
												break;
											}
										}
									}
									catch (Exception ex)
									{
										ProjectData.SetProjectError(ex);
										Exception ex2 = ex;
										ex2.Data.Add("Error at 200043", ex2.Message);
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
								((IDisposable)enumerator).Dispose();
							}
							if (flag)
							{
								if (!Information.IsNothing(this.WarheadArray[0].GetWeaponFromDP(activeUnit.m_Scenario)))
								{
									try
									{
										Contact contact = new Contact(activeUnit, 0);
										contact.SetLatitude(null, activeUnit.GetLatitude(null));
										contact.SetLongitude(null, activeUnit.GetLongitude(null));
										contact.contactType = Contact_Base.ContactType.Aimpoint;
										Weapon weapon = Weapon.GetWeapon(ref activeUnit.m_Scenario, this.WarheadArray[0].GetWeaponFromDP(activeUnit.m_Scenario).DBID, null);
										if (weapon.IsTorpedo())
										{
											this.method_71(ref weapon, weapon.DBID, ref contact, ActiveUnit.Throttle.Flank);
										}
										if (weapon.GetWeaponType() == Weapon._WeaponType.Rocket)
										{
											GlobalVariables.ActiveUnitType unitType = activeUnit.GetUnitType();
											if (unitType != GlobalVariables.ActiveUnitType.Aircraft)
											{
												if (unitType - GlobalVariables.ActiveUnitType.Ship > 1)
												{
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
												}
												else if (flag2)
												{
													weapon.SetAltitude_ASL(false, -1f);
													scenario_.LogMessage(string.Concat(new string[]
													{
														"Underwater detonation! Bearing ",
														Conversions.ToString(value2),
														" - Range ",
														Conversions.ToString(value),
														"m from ",
														activeUnit.Name
													}), LoggedMessage.MessageType.WeaponEndgame, 0, activeUnit.GetGuid(), activeUnit.GetSide(false), new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
													weapon.Detonation(weapon.GetLatitude(null), weapon.GetLongitude(null), 0f, ref random_0);
												}
												else
												{
													weapon.SetLongitude(null, activeUnit.GetLongitude(null));
													weapon.SetLatitude(null, activeUnit.GetLatitude(null));
													weapon.SetAltitude_ASL(false, activeUnit.GetCurrentAltitude_ASL(false) - 1f);
													scenario_.LogMessage("Underwater detonation! Right underneath " + activeUnit.Name, LoggedMessage.MessageType.WeaponEndgame, 0, activeUnit.GetGuid(), activeUnit.GetSide(false), new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
													weapon.CalculateDamageEffect(activeUnit, null);
												}
											}
											else
											{
												weapon.SetAltitude_ASL(false, -1f);
												scenario_.LogMessage(string.Concat(new string[]
												{
													"Underwater detonation! Bearing ",
													Conversions.ToString(value2),
													" - Range ",
													Conversions.ToString(value),
													"m from ",
													activeUnit.Name
												}), LoggedMessage.MessageType.WeaponEndgame, 0, activeUnit.GetGuid(), activeUnit.GetSide(false), new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
												weapon.Detonation(weapon.GetLatitude(null), weapon.GetLongitude(null), 0f, ref random_0);
											}
										}
										this.ExportUnitDestroyed(ref activeUnit.m_Scenario);
										goto IL_761;
									}
									catch (Exception ex3)
									{
										ProjectData.SetProjectError(ex3);
										Exception ex4 = ex3;
										ex4.Data.Add("Error at 200044", ex4.Message);
										GameGeneral.LogException(ref ex4);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
										ProjectData.ClearProjectError();
										goto IL_761;
									}
								}
								scenario_.LogMessage(string.Concat(new string[]
								{
									"Underwater detonation! Bearing ",
									Conversions.ToString(value2),
									" - Range ",
									Conversions.ToString(value),
									"m from ",
									activeUnit.Name
								}), LoggedMessage.MessageType.WeaponEndgame, 0, activeUnit.GetGuid(), activeUnit.GetSide(false), new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
								this.Detonation(scenario_);
							}
							IL_761:
							this.float_33 = (float)(random_0.NextDouble() * 10.0);
						}
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 100858", "");
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x002EB4B0 File Offset: 0x002E96B0
		public void ExportUnitDestroyed(ref Scenario scenario_)
		{
			scenario_.GetUnguidedWeapons().Remove(base.GetGuid());
			Side side = this.GetSide(false);
			string guid = base.GetGuid();
			side.RemoveWeaponSalvoByID(ref guid);
			foreach (IEventExporter current in scenario_.GetEventExporters())
			{
				if (current.imethod_24())
				{
					Dictionary<string, Tuple<Type, string>> dictionary = new Dictionary<string, Tuple<Type, string>>();
					dictionary.Add("TimelineID", new Tuple<Type, string>(typeof(string), scenario_.TimelineID));
					if (current.IsUseZeroHour())
					{
						TimeSpan timeSpan = scenario_.GetCurrentTime(false).Subtract(scenario_.ZeroHour);
						dictionary.Add("Time", new Tuple<Type, string>(typeof(TimeSpan), timeSpan.ToString("c")));
					}
					else
					{
						dictionary.Add("Time", new Tuple<Type, string>(typeof(DateTime), scenario_.GetCurrentTime(false).ToString("MM/dd/yyyy HH:mm:ss") + "." + scenario_.GetCurrentTime(false).Millisecond.ToString("D3")));
					}
					dictionary.Add("UnitID", new Tuple<Type, string>(typeof(string), base.GetGuid()));
					dictionary.Add("UnitName", new Tuple<Type, string>(typeof(string), this.Name));
					dictionary.Add("UnitClass", new Tuple<Type, string>(typeof(string), this.UnitClass));
					dictionary.Add("UnitSide", new Tuple<Type, string>(typeof(string), this.GetSide(false).GetSideName()));
					dictionary.Add("MiscInfo", new Tuple<Type, string>(typeof(string), ""));
					current.ExportEvent(ExportedEventType.UnitDestroyed, dictionary, scenario_);
				}
			}
		}

		// Token: 0x06006152 RID: 24914 RVA: 0x002EB6CC File Offset: 0x002E98CC
		private void method_71(ref Weapon theWeapon, int WeaponID, ref Contact theTarget, ActiveUnit.Throttle ThrottleSetting = ActiveUnit.Throttle.Cruise)
		{
			if (!Information.IsNothing(theTarget.ActualUnit))
			{
				try
				{
					Scenario scenario = theTarget.ActualUnit.m_Scenario;
					scenario.UnitsAutoIncrement++;
					theWeapon.Name = theWeapon.Name + " #" + Conversions.ToString(scenario.UnitsAutoIncrement);
					theWeapon.SetSide(false, this.GetSide(false));
					theWeapon.GetWeaponAI().SetPrimaryTarget(theTarget);
					theWeapon.GetWeaponAI().SetPrimaryTargetType(theTarget.contactType);
					theWeapon.SetLongitude(null, this.GetLongitude(null));
					theWeapon.SetLatitude(null, this.GetLatitude(null));
					theWeapon.SetAltitude_ASL(true, this.GetCurrentAltitude_ASL(false));
					theWeapon.SetThrottle(ThrottleSetting, null);
					float arg_F6_0 = (float)theWeapon.GetWeaponKinematics().GetSpeed(theWeapon.GetCurrentAltitude_ASL(false), ThrottleSetting);
					theWeapon.SetDesiredSpeed((float)theWeapon.GetWeaponKinematics().GetSpeed(theWeapon.GetCurrentAltitude_ASL(false), ThrottleSetting));
					theWeapon.SetCurrentHeading(Math2.GetAzimuth(this.GetLatitude(null), this.GetLongitude(null), theWeapon.GetWeaponAI().GetPrimaryTarget().GetLatitude(null), theWeapon.GetWeaponAI().GetPrimaryTarget().GetLongitude(null)));
					theWeapon.SetDesiredHeading(ActiveUnit._TurnRate.const_0, theWeapon.GetCurrentHeading());
					checked
					{
						if (theWeapon.IsTorpedo())
						{
							Sensor[] noneMCMSensors = theWeapon.GetNoneMCMSensors();
							for (int i = 0; i < noneMCMSensors.Length; i++)
							{
								Sensor sensor = noneMCMSensors[i];
								if (sensor.IsActiveCapable())
								{
									sensor.TurnOn();
								}
							}
						}
						theWeapon.LaunchPoint = new GeoPoint(this.GetLongitude(null), this.GetLatitude(null), this.GetCurrentAltitude_ASL(false));
						scenario.AddUnit(theWeapon);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100859", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006153 RID: 24915 RVA: 0x002EB934 File Offset: 0x002E9B34
		private bool method_72(ActiveUnit activeUnit_1, Contact theTarget, ref Scenario scenario_0, ref Random random_0)
		{
			bool flag = false;
			bool result;
			if (Information.IsNothing(activeUnit_1))
			{
				flag = false;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				bool flag2 = false;
				try
				{
					this.SetAltitude_ASL(false, this.method_62() + (float)Math.Max(base.GetTerrainElevation(false, false, false), 0));
					float num;
					if (!activeUnit_1.IsWeapon && !activeUnit_1.IsAircraft)
					{
						if (!activeUnit_1.IsSubmarine)
						{
							flag = (result = this.method_75(activeUnit_1, theTarget, ref scenario_0, ref random_0));
							return result;
						}
						if (!this.IsTorpedo())
						{
							flag = (result = this.method_75(activeUnit_1, theTarget, ref scenario_0, ref random_0));
							return result;
						}
						num = this.SubsurfacePOK;
						if (num == 0f && activeUnit_1.GetCurrentAltitude_ASL(false) == 0f)
						{
							num = this.SurfacePOK;
						}
					}
					else
					{
						num = this.AirPOK;
					}
					Weapon._WeaponType weaponType = this.GetWeapon().GetWeaponType();
					if (weaponType == Weapon._WeaponType.Gun)
					{
						stringBuilder.Append(string.Concat(new string[]
						{
							"火炮(",
							this.UnitClass,
							")正在攻击目标：",
							activeUnit_1.Name,
							" 基准命中概率：",
							Conversions.ToString(Math.Round((double)num, 1)),
							"%. "
						}));
					}
					else
					{
						stringBuilder.Append(string.Concat(new string[]
						{
							"武器: ",
							this.Name,
							"正在攻击目标",
							activeUnit_1.Name,
							"，基准命中概率：",
							Conversions.ToString(Math.Round((double)num, 1)),
							"%. "
						}));
					}
					float num7;
					if (this.GetWeapon().GetWeaponType() != Weapon._WeaponType.Laser)
					{
						double num2 = (double)base.SlantRangeTo(this.LaunchPoint);
						if (num2 > this.GetRangeMax(activeUnit_1) / 2.0)
						{
							double num3 = Math.Min(1.0, num2 / 2.0 / this.GetRangeMax(activeUnit_1));
							num -= (float)((double)(num / 2f) * num3);
						}
						stringBuilder.Append("，命中概率(距离修正): " + Conversions.ToString(Math.Round((double)num, 1)) + "%. ");
						if (activeUnit_1.IsAircraft)
						{
							if (activeUnit_1.isDestroyed | activeUnit_1.IsNotActive())
							{
								flag = true;
								result = true;
								return result;
							}
							if (((Aircraft)activeUnit_1).Crew > 0 && ((Aircraft)activeUnit_1).Agility > 0f)
							{
								stringBuilder.Append(activeUnit_1.Name).Append("基准机动系数: ").Append(((Aircraft)activeUnit_1).Agility).Append(", ");
								float num4 = (float)Math.Round((double)((Aircraft)activeUnit_1).GetAircraftKinematics().GetAgilityAtAltitude(), 1);
								stringBuilder.Append("机动系数(经高度修正): ").Append(num4).Append(". ");
								GlobalVariables.ProficiencyLevel? proficiencyLevel = activeUnit_1.GetProficiencyLevel();
								int? num5 = proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
								if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									num4 = (float)((double)num4 * 0.3);
								}
								else
								{
									num5 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 1) : null).GetValueOrDefault())
									{
										num4 = (float)((double)num4 * 0.5);
									}
									else
									{
										num5 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
										if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 2) : null).GetValueOrDefault())
										{
											num4 = (float)((double)num4 * 0.8);
										}
										else
										{
											num5 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
											if (!(num5.HasValue ? new bool?(num5.GetValueOrDefault() == 3) : null).GetValueOrDefault())
											{
												num5 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
												if ((num5.HasValue ? new bool?(num5.GetValueOrDefault() == 4) : null).GetValueOrDefault())
												{
													num4 = (float)((double)num4 * 1.2);
												}
											}
										}
									}
								}
								stringBuilder.Append(string.Concat(new string[]
								{
									" 机动系数(经训练水平修正)(",
									Misc.GetProficiencyLevelString(activeUnit_1.GetProficiencyLevel().Value),
									"): ",
									Conversions.ToString(num4),
									". "
								}));
								float weightFraction = ((Aircraft)activeUnit_1).GetWeightFraction();
								num4 = (float)(0.4 * (double)num4 + 0.6 * (double)num4 * (double)(1f - weightFraction));
								stringBuilder.Append(string.Concat(new string[]
								{
									" 飞机重量分数为",
									Conversions.ToString(Math.Round((double)weightFraction, 2)),
									" - 机动系数(经重量分数修正)：",
									Conversions.ToString(Math.Round((double)num4, 2)),
									". "
								}));
								if (((Aircraft)activeUnit_1).GetAircraftDamage().GetDamagePts() > 0f)
								{
									num4 = num4 * (100f - ((Aircraft)activeUnit_1).GetAircraftDamage().GetDamagePts()) / 100f;
									stringBuilder.Append(string.Concat(new string[]
									{
										"飞机遭受",
										Conversions.ToString(((Aircraft)activeUnit_1).GetAircraftDamage().GetDamagePts()),
										"% 机身/结构性毁伤 -机动系数(经毁伤效应修正)",
										Conversions.ToString(Math.Round((double)num4, 2)),
										". "
									}));
								}
								float num6 = base.RelativeBearingTo(activeUnit_1, false);
								if (num6 < 345f && num6 > 15f)
								{
									if ((num6 >= 15f && num6 <= 60f) || (num6 <= 345f && num6 >= 300f))
									{
										num4 = (float)((double)num4 * 0.7);
										stringBuilder.Append("机动系数(经前向攻击效应修正): " + Conversions.ToString(Math.Round((double)num4, 1)) + ". ");
									}
									else if ((num6 >= 60f && num6 <= 110f) || (num6 <= 300f && num6 >= 250f))
									{
										num4 = num4;
										stringBuilder.Append("强转向攻击(对机动性没影响). ");
									}
									else if ((num6 >= 110f && num6 <= 165f) || (num6 <= 250f && num6 >= 195f))
									{
										num4 = (float)((double)num4 * 0.85);
										stringBuilder.Append("机动系数(经后向攻击修正): " + Conversions.ToString(Math.Round((double)num4, 1)) + ". ");
									}
									else
									{
										num4 = (float)((double)num4 * 0.5);
										stringBuilder.Append("机动系数(经尾追攻击效应修正): " + Conversions.ToString(Math.Round((double)num4, 1)) + ". ");
									}
								}
								else
								{
									num4 = (float)((double)num4 * 0.6);
									stringBuilder.Append("机动系数(经迎头攻击效应修正): " + Conversions.ToString(Math.Round((double)num4, 1)) + ". ");
								}
								num4 = (float)Math.Round((double)num4, 1);
								stringBuilder.Append("命中概率(目标机动系数修正量): -" + Conversions.ToString((int)Math.Round((double)(num4 * 10f))) + "%. ");
								num7 = num - num4 * 10f;
							}
							else
							{
								num7 = num;
							}
						}
						else
						{
							num7 = num;
						}
						if (activeUnit_1.GetCurrentAltitude_ASL(false) > 0f && (activeUnit_1.IsWeapon || activeUnit_1.IsAircraft) && !this.weaponCode.CapableVsSeaskimmer)
						{
							double num8 = Math.Round((double)this.GetWeapon().GetSeaSkimmerModifier(activeUnit_1.GetCurrentAltitude_ASL(false)), 2);
							if (num8 > 0.0)
							{
								num7 = (float)((double)num7 - num8);
								stringBuilder.Append("命中概率(目标掠海效应修正量): -" + Conversions.ToString(num8) + "%. ");
							}
						}
						if (activeUnit_1.IsGuidedWeapon_RV_HGV())
						{
							GlobalVariables.TargetVisualSizeClass targetVisualSizeClass = this.Target.GetTargetVisualSizeClass(scenario_0);
							num7 = this.method_73((int)Math.Round((double)num7), activeUnit_1.GetCurrentSpeed(), targetVisualSizeClass, stringBuilder);
							if (base.HorizontalRangeTo(this.LaunchPoint) <= 2f)
							{
								Weapon weapon = (Weapon)activeUnit_1;
								if (weapon.weaponCode.TerminalManeuver_Popup)
								{
									stringBuilder.Append("目标导弹末端采用跃升俯冲机动 - 命中概率缩减25%. ");
									num7 = (float)((double)num7 * 0.75);
								}
								else if (weapon.weaponCode.TerminalManeuver_Zigzag)
								{
									stringBuilder.Append("目标导弹末端采用蛇形机动 - 命中概率缩减33%. ");
									num7 = (float)((double)num7 * 0.66);
								}
								else if (weapon.weaponCode.TerminalManeuver_Random)
								{
									stringBuilder.Append("目标导弹末端采用随机机动 - 命中概率缩减50%.");
									num7 = (float)((double)num7 * 0.5);
								}
							}
						}
					}
					else
					{
						num7 = num;
					}
					if (num7 < 0f)
					{
						num7 = 1f;
					}
					if (num7 > 99f)
					{
						num7 = 99f;
					}
					if (!float.IsNaN(num7))
					{
						stringBuilder.Append("最终命中概率: " + Conversions.ToString((int)Math.Round((double)num7)) + "%. ");
					}
					float num9 = 0f;
					float num10 = 0f;
					int num11 = GameGeneral.GetRandom().Next(1, 101);
					if ((float)num11 <= num7)
					{
						stringBuilder.Append("结果: " + Conversions.ToString(num11) + " - 命中");
						flag2 = true;
					}
					else
					{
						stringBuilder.Append("结果: " + Conversions.ToString(num11) + " - 脱靶");
						if (this.WarheadArray.Length > 0 && activeUnit_1.IsFacility && this.WarheadArray[0].method_13())
						{
							num9 = (float)GameGeneral.GetRandom().Next(0, 359);
							num10 = (float)GameGeneral.GetRandom().Next(1, 50);
							stringBuilder.Append(" (脱靶量: " + Conversions.ToString(num10) + "米)");
							if (!string.IsNullOrEmpty(this.FiringParentName) && Information.IsNothing(this.GetFiringParent()))
							{
								ObservableDictionary<string, ActiveUnit> activeUnits = this.GetWeapon().m_Scenario.GetActiveUnits();
								string firingParentName = this.FiringParentName;
								ActiveUnit firingParent = this.GetFiringParent();
								activeUnits.TryGetValue(firingParentName, ref firingParent);
								this.SetFiringParent(firingParent);
							}
							ActiveUnit_Damage damage = activeUnit_1.GetDamage();
							Weapon theAntiRadiationMissile_ = this.GetWeapon();
							GeoPoint launchPoint = this.LaunchPoint;
							float missDistance_ = num10;
							float missAzimuth_ = num9;
							ActiveUnit firingParent2 = this.GetFiringParent();
							double? nullable_ = null;
							double? nullable_2 = null;
							float? nullable_3 = null;
							string text = "";
							damage.vmethod_11(theAntiRadiationMissile_, launchPoint, missDistance_, missAzimuth_, firingParent2, nullable_, nullable_2, nullable_3, ref text);
						}
					}
					activeUnit_1.m_Scenario.LogMessage(stringBuilder.ToString(), LoggedMessage.MessageType.WeaponEndgame, 10, base.GetGuid(), null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
					if (flag2)
					{
						ActiveUnit firingParent;
						if (!string.IsNullOrEmpty(this.FiringParentName) && Information.IsNothing(this.GetFiringParent()))
						{
							ObservableDictionary<string, ActiveUnit> activeUnits2 = this.GetWeapon().m_Scenario.GetActiveUnits();
							string firingParentName2 = this.FiringParentName;
							firingParent = this.GetFiringParent();
							activeUnits2.TryGetValue(firingParentName2, ref firingParent);
							this.SetFiringParent(firingParent);
						}
						float float_ = num10;
						float float_2 = num9;
						firingParent = this.GetFiringParent();
						double? nullable_4 = null;
						double? nullable_5 = null;
						float? nullable_6 = null;
						string text = "";
						this.method_76(activeUnit_1, float_, float_2, ref firingParent, nullable_4, nullable_5, nullable_6, ref text);
						this.SetFiringParent(firingParent);
					}
					this.ExportWeaponEndgame(activeUnit_1, flag2, activeUnit_1.IsNotActive(), stringBuilder, scenario_0);
					flag = flag2;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100860", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					flag = false;
					ProjectData.ClearProjectError();
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x06006154 RID: 24916 RVA: 0x002EC63C File Offset: 0x002EA83C
		private float method_73(int int_1, float float_34, GlobalVariables.TargetVisualSizeClass targetVisualSizeClass_0, StringBuilder stringBuilder_0)
		{
			int num = 510;
			float result = 0f;
			try
			{
				float num2 = Math.Abs(30f * ((float_34 - (float)num) / (float)(this.GetWeapon().TargetSpeedMax - num)));
				num2 = Math.Min(30f, num2);
				stringBuilder_0.Append(" 目标速度修正因子: " + Conversions.ToString(-(int)Math.Round((double)num2)) + "%. ");
				float num3 = 0f;
				if (targetVisualSizeClass_0 != GlobalVariables.TargetVisualSizeClass.VLarge)
				{
					switch (targetVisualSizeClass_0)
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
						num3 = 30f;
						break;
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						num3 = 21f;
						break;
					case GlobalVariables.TargetVisualSizeClass.Small:
						num3 = 15f;
						break;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						num3 = 9f;
						break;
					case GlobalVariables.TargetVisualSizeClass.Large:
						num3 = 3f;
						break;
					}
					stringBuilder_0.Append(" Target size modifier: " + Conversions.ToString(-(int)Math.Round((double)num3)) + "%. ");
				}
				result = Math.Max(1f, (float)int_1 - num2 - num3);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100861", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006155 RID: 24917 RVA: 0x002EC784 File Offset: 0x002EA984
		public static double smethod_4(Contact_Base.ContactType contactType_0, float float_34, bool bool_8)
		{
			double num = Math.Sqrt((double)(float_34 * 1852f) * 9.81 / Math.Sin(1.570796326794897));
			if (!bool_8)
			{
				num *= 3.0;
			}
			if (!Information.IsNothing(contactType_0) && contactType_0 <= Contact_Base.ContactType.Missile)
			{
				num = Math.Max(990.0, num);
			}
			return num;
		}

		// Token: 0x06006156 RID: 24918 RVA: 0x002EC7F0 File Offset: 0x002EA9F0
		public double GetRangeMax(ActiveUnit activeUnit_)
		{
			double result;
			if (!activeUnit_.IsAircraft && !activeUnit_.IsGuidedWeapon_RV_HGV() && !activeUnit_.IsDecoyVehicle())
			{
				if (!activeUnit_.IsShip && !activeUnit_.IsFacility)
				{
					if (!activeUnit_.IsSubmarine && !activeUnit_.IsTorpedo())
					{
						throw new NotImplementedException();
					}
					result = (double)this.SubsurfaceRangeMax;
				}
				else
				{
					result = (double)this.SurfaceRangeMax;
				}
			}
			else
			{
				result = (double)this.AirRangeMax;
			}
			return result;
		}

		// Token: 0x06006157 RID: 24919 RVA: 0x002EC870 File Offset: 0x002EAA70
		public bool method_75(ActiveUnit activeUnit_1, Contact contact_1, ref Scenario scenario_0, ref Random random_0)
		{
			bool result = false;
			try
			{
				UnguidedWeapon.SalvoParticipation salvoParticipation = new UnguidedWeapon.SalvoParticipation();
				salvoParticipation.unguidedWeapon = this;
				double num = 0.0;
				if (!activeUnit_1.IsShip && (!activeUnit_1.IsSubmarine || !((Submarine)activeUnit_1).IsShallowerThanPeriscopeDepth()))
				{
					if (activeUnit_1.IsFacility)
					{
						num = (double)this.LandPOK;
					}
					else if ((activeUnit_1.IsSubmarine && !((Submarine)activeUnit_1).IsShallowerThanPeriscopeDepth()) || activeUnit_1.IsTorpedo())
					{
						num = (double)this.SubsurfacePOK;
					}
				}
				else
				{
					num = (double)this.SurfacePOK;
				}
				if (this.GetWeaponType() == Weapon._WeaponType.DepthCharge || (this.WarheadArray[0].warheadType == Warhead.WarheadType.Weapon && this.WarheadArray[0].GetWeaponFromDP(scenario_0).GetWeaponType() == Weapon._WeaponType.DepthCharge))
				{
					if (this.CEP_Surface == 0f)
					{
						num = 99.0;
						this.CEP_Surface = 200f;
					}
					if (num < 85.0)
					{
						num = 85.0;
					}
				}
				bool flag = (double)random_0.Next(1, 101) < num;
				float num2;
				if (activeUnit_1.IsFacility)
				{
					num2 = this.CEP_Land;
				}
				else
				{
					num2 = this.CEP_Surface;
				}
				float num3 = 0f;
				if (activeUnit_1.GetCurrentSpeed() > 0f && contact_1.Age > 0f)
				{
					if (activeUnit_1.IsFacility)
					{
						num3 = this.CEP_Land + contact_1.Age * activeUnit_1.GetCurrentSpeed();
					}
					else
					{
						num3 = this.CEP_Surface + contact_1.Age * activeUnit_1.GetCurrentSpeed();
					}
				}
				float num4 = (float)random_0.Next(0, 360);
				float num5;
				if (random_0.Next(1, 101) > 50)
				{
					num5 = Math.Abs(num3 - (float)((double)random_0.Next(0, 101) / 100.0 * (double)num2));
				}
				else
				{
					num5 = num3 + (float)((double)random_0.Next(10, 24) / 10.0 * (double)num2);
				}
				double num6 = 0.0;
				double num7 = 0.0;
				if (activeUnit_1.MountsAreAimpoints())
				{
					Mount mount = ((Facility)activeUnit_1).method_138();
					if (!Information.IsNothing(mount))
					{
						GeoPointGenerator.GetOtherGeoPoint(activeUnit_1.GetLongitude(null), activeUnit_1.GetLatitude(null), ref num6, ref num7, (double)(mount.GetAimpointOffset_Distance() / 1852f), (double)mount.GetAimpointOffset_Bearing());
					}
					else
					{
						num7 = contact_1.GetLatitude(null);
						num6 = contact_1.GetLongitude(null);
					}
				}
				else
				{
					num7 = contact_1.GetLatitude(null);
					num6 = contact_1.GetLongitude(null);
				}
				salvoParticipation.weaponSalvo = this.GetWeaponSalvoForTheWeapon(scenario_0);
				WeaponSalvo.Shooter shooterForTheWeapon = this.GetShooterForTheWeapon(scenario_0);
				string text = "";
				if (Information.IsNothing(shooterForTheWeapon))
				{
					text = "";
				}
				else
				{
					text = shooterForTheWeapon.string_2;
				}
				if (!Information.IsNothing(salvoParticipation.weaponSalvo) && !Information.IsNothing(shooterForTheWeapon) && (this.GetWeaponType() == Weapon._WeaponType.IronBomb || this.GetWeaponType() == Weapon._WeaponType.Rocket))
				{
					if (Information.IsNothing(shooterForTheWeapon.NumOfWeapons))
					{
						shooterForTheWeapon.NumOfWeapons = new int?(scenario_0.GetUnguidedWeapons().Values.Where(new Func<UnguidedWeapon, bool>(salvoParticipation.IsPartOfThisSalvo)).Count<UnguidedWeapon>());
						if (Information.IsNothing(shooterForTheWeapon.NumOfWeapons))
						{
							shooterForTheWeapon.NumOfWeapons = new int?(1);
						}
					}
					int? num8 = shooterForTheWeapon.NumOfWeapons;
					if ((num8.HasValue ? new bool?(num8.GetValueOrDefault() < 2) : null).GetValueOrDefault())
					{
						double num9 = num7;
						double num10 = num6;
						double lng = num10;
						double lat = num9;
						bool? hintIsOperating = null;
						double num11 = this.GetLongitude(hintIsOperating);
						bool? hintIsOperating2 = null;
						double num12 = this.GetLatitude(hintIsOperating2);
						GeoPointGenerator.GetOtherGeoPoint(lng, lat, ref num11, ref num12, (double)(num5 / 1852f), (double)num4);
						this.SetLatitude(hintIsOperating2, num12);
						this.SetLongitude(hintIsOperating, num11);
					}
					else
					{
						if (Information.IsNothing(shooterForTheWeapon.nullable_3))
						{
							shooterForTheWeapon.nullable_3 = new int?(ECM.smethod_7((double)shooterForTheWeapon.NumOfWeapons.Value / 2.0));
						}
						if (Information.IsNothing(shooterForTheWeapon.nullable_1))
						{
							shooterForTheWeapon.nullable_1 = new float?(this.GetCurrentHeading());
						}
						if (Information.IsNothing(shooterForTheWeapon.nullable_2))
						{
							Weapon._WeaponType weaponType = this.GetWeaponType();
							switch (weaponType)
							{
							case Weapon._WeaponType.Rocket:
							case Weapon._WeaponType.IronBomb:
							case Weapon._WeaponType.Gun:
								break;
							default:
								if (weaponType == Weapon._WeaponType.DepthCharge)
								{
								}
								break;
							}
							if (!string.IsNullOrEmpty(this.FiringParentName) && Information.IsNothing(this.GetFiringParent()))
							{
								ObservableDictionary<string, ActiveUnit> activeUnits = this.GetWeapon().m_Scenario.GetActiveUnits();
								string firingParentName = this.FiringParentName;
								ActiveUnit firingParent = this.GetFiringParent();
								activeUnits.TryGetValue(firingParentName, ref firingParent);
								this.SetFiringParent(firingParent);
							}
							if (!Information.IsNothing(this.GetFiringParent()) && this.GetFiringParent().IsAircraft)
							{
								Aircraft._AircraftType type = ((Aircraft)this.GetFiringParent()).Type;
								Weapon._WeaponType weaponType2 = this.GetWeaponType();
								float num13;
								if (weaponType2 != Weapon._WeaponType.IronBomb && weaponType2 != Weapon._WeaponType.DepthCharge)
								{
									num13 = 9.144f;
								}
								else if (type == Aircraft._AircraftType.Bomber)
								{
									num13 = 22.86f;
								}
								else
								{
									num13 = 15.24f;
								}
								if (this.GetWeaponType() != Weapon._WeaponType.IronBomb && this.GetWeaponType() != Weapon._WeaponType.DepthCharge)
								{
									if (shooterForTheWeapon.NumOfWeapons.Value < 40)
									{
										shooterForTheWeapon.nullable_2 = new float?(30.48f);
									}
									else if (shooterForTheWeapon.NumOfWeapons.Value < 80)
									{
										shooterForTheWeapon.nullable_2 = new float?(60.96f);
									}
									else
									{
										shooterForTheWeapon.nullable_2 = new float?(91.44f);
									}
								}
								else if (type == Aircraft._AircraftType.Bomber)
								{
									if (shooterForTheWeapon.NumOfWeapons.Value < 28)
									{
										shooterForTheWeapon.nullable_2 = new float?((float)shooterForTheWeapon.NumOfWeapons.Value * num13);
									}
									else
									{
										shooterForTheWeapon.nullable_2 = new float?(609.600037f);
									}
								}
								else if (shooterForTheWeapon.NumOfWeapons.Value < 8)
								{
									shooterForTheWeapon.nullable_2 = new float?((float)shooterForTheWeapon.NumOfWeapons.Value * num13);
								}
								else if (shooterForTheWeapon.NumOfWeapons.Value < 25)
								{
									shooterForTheWeapon.nullable_2 = new float?(91.44f);
								}
								else
								{
									shooterForTheWeapon.nullable_2 = new float?(182.88f);
								}
							}
							else
							{
								shooterForTheWeapon.nullable_2 = new float?(91.44f);
							}
						}
						if (Information.IsNothing(shooterForTheWeapon.FirstWeaponDPI))
						{
							shooterForTheWeapon.FirstWeaponDPI = new GeoPoint();
							shooterForTheWeapon.FirstWeaponDPI.SetLatitude(num7);
							shooterForTheWeapon.FirstWeaponDPI.SetLongitude(num6);
						}
						if (Information.IsNothing(shooterForTheWeapon.geoPoint_1))
						{
							shooterForTheWeapon.geoPoint_1 = new GeoPoint();
							double longitude = shooterForTheWeapon.FirstWeaponDPI.GetLongitude();
							double latitude = shooterForTheWeapon.FirstWeaponDPI.GetLatitude();
							GeoPoint geoPoint_;
							double num12 = (geoPoint_ = shooterForTheWeapon.geoPoint_1).GetLongitude();
							GeoPoint geoPoint_2;
							double num11 = (geoPoint_2 = shooterForTheWeapon.geoPoint_1).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref num12, ref num11, (double)(num5 / 1852f), (double)num4);
							geoPoint_2.SetLatitude(num11);
							geoPoint_.SetLongitude(num12);
						}
						double num14 = 0.0;
						double num15 = 0.0;
						if (this.GetWeaponType() != Weapon._WeaponType.IronBomb && this.GetWeaponType() != Weapon._WeaponType.DepthCharge)
						{
							int num16 = shooterForTheWeapon.NumOfWeapons.Value - shooterForTheWeapon.int_4;
							shooterForTheWeapon.int_4++;
							num8 = shooterForTheWeapon.nullable_3;
							if ((num8.HasValue ? new bool?(num8.GetValueOrDefault() == num16) : null).GetValueOrDefault())
							{
								num14 = shooterForTheWeapon.geoPoint_1.GetLatitude();
								num15 = shooterForTheWeapon.geoPoint_1.GetLongitude();
							}
							else
							{
								int num17 = num16;
								num8 = shooterForTheWeapon.nullable_3;
								if ((num8.HasValue ? new bool?(num17 > num8.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									float num18 = (float)(num16 - shooterForTheWeapon.nullable_3.Value);
									float? num19 = shooterForTheWeapon.nullable_2;
									float? num20 = num19.HasValue ? new float?(num19.GetValueOrDefault() / 2f) : null;
									num8 = shooterForTheWeapon.nullable_3;
									num19 = num20;
									float? num21 = num8.HasValue ? new float?((float)num8.GetValueOrDefault()) : null;
									float value = ((num19.HasValue & num21.HasValue) ? new float?(num19.GetValueOrDefault() / num21.GetValueOrDefault()) : null).Value;
									float num22 = num18 * value;
									GeoPointGenerator.GetOtherGeoPoint(shooterForTheWeapon.geoPoint_1.GetLongitude(), shooterForTheWeapon.geoPoint_1.GetLatitude(), ref num15, ref num14, (double)(num22 / 1852f), (double)Math2.Normalize(shooterForTheWeapon.nullable_1.Value + 180f));
								}
								else
								{
									float num23 = (float)(shooterForTheWeapon.NumOfWeapons.Value - (num16 + shooterForTheWeapon.nullable_3.Value));
									float? num19 = shooterForTheWeapon.nullable_2;
									float? num24 = num19.HasValue ? new float?(num19.GetValueOrDefault() / 2f) : null;
									num8 = shooterForTheWeapon.NumOfWeapons.Value - 1 - shooterForTheWeapon.nullable_3;
									num19 = num24;
									float? num21 = num8.HasValue ? new float?((float)num8.GetValueOrDefault()) : null;
									float value2 = ((num19.HasValue & num21.HasValue) ? new float?(num19.GetValueOrDefault() / num21.GetValueOrDefault()) : null).Value;
									float num25 = num23 * value2;
									GeoPointGenerator.GetOtherGeoPoint(shooterForTheWeapon.geoPoint_1.GetLongitude(), shooterForTheWeapon.geoPoint_1.GetLatitude(), ref num15, ref num14, (double)(num25 / 1852f), (double)Math2.Normalize(shooterForTheWeapon.nullable_1.Value));
								}
							}
							if (random_0.Next(1, 4) > 1)
							{
								float num26 = (float)random_0.Next(0, 8);
								double lng2 = num15;
								double lat2 = num14;
								bool? hintIsOperating2 = null;
								double num11 = this.GetLongitude(hintIsOperating2);
								bool? hintIsOperating = null;
								double num12 = this.GetLatitude(hintIsOperating);
								GeoPointGenerator.GetOtherGeoPoint(lng2, lat2, ref num11, ref num12, (double)(num26 / 1852f), (double)num4);
								this.SetLatitude(hintIsOperating, num12);
								this.SetLongitude(hintIsOperating2, num11);
							}
							else
							{
								float num27 = (float)random_0.Next(7, 16);
								double lng3 = num15;
								double lat3 = num14;
								bool? hintIsOperating = null;
								double num12 = this.GetLongitude(hintIsOperating);
								bool? hintIsOperating2 = null;
								double num11 = this.GetLatitude(hintIsOperating2);
								GeoPointGenerator.GetOtherGeoPoint(lng3, lat3, ref num12, ref num11, (double)(num27 / 1852f), (double)num4);
								this.SetLatitude(hintIsOperating2, num11);
								this.SetLongitude(hintIsOperating, num12);
							}
							num5 = shooterForTheWeapon.FirstWeaponDPI.GetDistance(this.GetLongitude(null), this.GetLatitude(null)) * 1852f;
						}
						else
						{
							int num28 = shooterForTheWeapon.NumOfWeapons.Value - shooterForTheWeapon.int_4;
							shooterForTheWeapon.int_4++;
							num8 = shooterForTheWeapon.nullable_3;
							if ((num8.HasValue ? new bool?(num8.GetValueOrDefault() == num28) : null).GetValueOrDefault())
							{
								this.SetLatitude(null, shooterForTheWeapon.geoPoint_1.GetLatitude());
								this.SetLongitude(null, shooterForTheWeapon.geoPoint_1.GetLongitude());
								num5 = shooterForTheWeapon.FirstWeaponDPI.GetDistance(this.GetLongitude(null), this.GetLatitude(null)) * 1852f;
							}
							else
							{
								int num17 = num28;
								num8 = shooterForTheWeapon.nullable_3;
								if ((num8.HasValue ? new bool?(num17 > num8.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									float num29 = (float)(num28 - shooterForTheWeapon.nullable_3.Value);
									float? num19 = shooterForTheWeapon.nullable_2;
									float? num20 = num19.HasValue ? new float?(num19.GetValueOrDefault() / 2f) : null;
									num8 = shooterForTheWeapon.nullable_3;
									num19 = num20;
									float? num21 = num8.HasValue ? new float?((float)num8.GetValueOrDefault()) : null;
									float value3 = ((num19.HasValue & num21.HasValue) ? new float?(num19.GetValueOrDefault() / num21.GetValueOrDefault()) : null).Value;
									float num30 = num29 * value3;
									GeoPointGenerator.GetOtherGeoPoint(shooterForTheWeapon.geoPoint_1.GetLongitude(), shooterForTheWeapon.geoPoint_1.GetLatitude(), ref num15, ref num14, (double)(num30 / 1852f), (double)Math2.Normalize(shooterForTheWeapon.nullable_1.Value + 180f));
									float num31 = (float)random_0.Next(0, (int)Math.Round((double)value3));
									double lng4 = num15;
									double lat4 = num14;
									bool? hintIsOperating2 = null;
									double num11 = this.GetLongitude(hintIsOperating2);
									bool? hintIsOperating = null;
									double num12 = this.GetLatitude(hintIsOperating);
									GeoPointGenerator.GetOtherGeoPoint(lng4, lat4, ref num11, ref num12, (double)(num31 / 1852f), (double)num4);
									this.SetLatitude(hintIsOperating, num12);
									this.SetLongitude(hintIsOperating2, num11);
									num5 = shooterForTheWeapon.FirstWeaponDPI.GetDistance(this.GetLongitude(null), this.GetLatitude(null)) * 1852f;
								}
								else
								{
									float num32 = (float)(shooterForTheWeapon.NumOfWeapons.Value - (num28 + shooterForTheWeapon.nullable_3.Value));
									float? num19 = shooterForTheWeapon.nullable_2;
									float? num24 = num19.HasValue ? new float?(num19.GetValueOrDefault() / 2f) : null;
									num8 = shooterForTheWeapon.NumOfWeapons.Value - 1 - shooterForTheWeapon.nullable_3;
									num19 = num24;
									float? num21 = num8.HasValue ? new float?((float)num8.GetValueOrDefault()) : null;
									float value4 = ((num19.HasValue & num21.HasValue) ? new float?(num19.GetValueOrDefault() / num21.GetValueOrDefault()) : null).Value;
									float num33 = num32 * value4;
									GeoPointGenerator.GetOtherGeoPoint(shooterForTheWeapon.geoPoint_1.GetLongitude(), shooterForTheWeapon.geoPoint_1.GetLatitude(), ref num15, ref num14, (double)(num33 / 1852f), (double)Math2.Normalize(shooterForTheWeapon.nullable_1.Value));
									float num34 = (float)random_0.Next(0, (int)Math.Round((double)value4));
									double lng5 = num15;
									double lat5 = num14;
									bool? hintIsOperating = null;
									double num12 = this.GetLongitude(hintIsOperating);
									bool? hintIsOperating2 = null;
									double num11 = this.GetLatitude(hintIsOperating2);
									GeoPointGenerator.GetOtherGeoPoint(lng5, lat5, ref num12, ref num11, (double)(num34 / 1852f), (double)num4);
									this.SetLatitude(hintIsOperating2, num11);
									this.SetLongitude(hintIsOperating, num12);
									num5 = shooterForTheWeapon.FirstWeaponDPI.GetDistance(this.GetLongitude(null), this.GetLatitude(null)) * 1852f;
								}
							}
						}
					}
				}
				else if (num2 > 0f)
				{
					double lng6 = num6;
					double lat6 = num7;
					bool? hintIsOperating2 = null;
					double num11 = this.GetLongitude(hintIsOperating2);
					bool? hintIsOperating = null;
					double num12 = this.GetLatitude(hintIsOperating);
					GeoPointGenerator.GetOtherGeoPoint(lng6, lat6, ref num11, ref num12, (double)(num5 / 1852f), (double)num4);
					this.SetLatitude(hintIsOperating, num12);
					this.SetLongitude(hintIsOperating2, num11);
				}
				else
				{
					this.SetLatitude(null, num7);
					this.SetLongitude(null, num6);
				}
				base.ClearAltitudeData();
				if (!this.IsTorpedo())
				{
					if (this.GetWeaponType() != Weapon._WeaponType.DepthCharge && (this.WarheadArray[0].warheadType != Warhead.WarheadType.Weapon || this.WarheadArray[0].GetWeaponFromDP(scenario_0).GetWeaponType() != Weapon._WeaponType.DepthCharge))
					{
						this.SetAltitude_ASL(false, (float)Math.Max(0, (int)Terrain.GetElevation(this.GetLatitude(null), this.GetLongitude(null), false)));
					}
					else
					{
						this.SetAltitude_ASL(false, (float)Math.Max(-100.0, (double)Terrain.GetElevation(this.GetLatitude(null), this.GetLongitude(null), false) / 2.0));
					}
				}
				bool flag2;
				if (flag2 = Weapon.IsHit(activeUnit_1, num5, this.LaunchPoint, this.GetWeapon().GetLargestRangeMaxOfAllDomains(), true))
				{
					Weapon.smethod_14(this.GetWeapon().m_Scenario, this.GetWeapon(), contact_1, false);
					num5 = 0f;
				}
				if (this.WarheadArray.Length > 0 && this.WarheadArray[0].method_15())
				{
					if (flag)
					{
						short clusterBombDispersionAreaLength = this.WarheadArray[0].ClusterBombDispersionAreaLength;
						short clusterBombDispersionAreaWidth = this.WarheadArray[0].ClusterBombDispersionAreaWidth;
						int numberOfWarheads = (int)this.WarheadArray[0].NumberOfWarheads;
						new Explosion(ref scenario_0, this.GetLongitude(null), this.GetLatitude(null), this.GetLongitude(null), this.GetLatitude(null), this.GetCurrentHeading(), this.GetCurrentAltitude_ASL(false), this.WarheadArray[0].DP, this.WarheadArray[0].DP, this.WarheadArray[0].warheadType, this.WarheadArray[0].ExplosivesType, null, null, null, null, null, clusterBombDispersionAreaLength, clusterBombDispersionAreaWidth, numberOfWarheads, 0f, 0).SetCurrentHeading(this.GetCurrentHeading());
					}
					else
					{
						scenario_0.LogMessage("武器: " + this.Name + "发生故障.", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
					}
					flag2 = true;
				}
				if (!this.WarheadArray[0].method_13() && (this.WarheadArray[0].warheadType != Warhead.WarheadType.Weapon || !this.WarheadArray[0].GetWeaponFromDP(scenario_0).m_Warheads[0].method_13()) && !this.WarheadArray[0].IsIncendiary() && (this.WarheadArray[0].warheadType != Warhead.WarheadType.Weapon || !this.WarheadArray[0].GetWeaponFromDP(scenario_0).m_Warheads[0].IsIncendiary()))
				{
					if (flag2)
					{
						ActiveUnit firingParent2;
						if (!string.IsNullOrEmpty(this.FiringParentName) && Information.IsNothing(this.GetFiringParent()))
						{
							ObservableDictionary<string, ActiveUnit> activeUnits2 = this.GetWeapon().m_Scenario.GetActiveUnits();
							string firingParentName2 = this.FiringParentName;
							firingParent2 = this.GetFiringParent();
							activeUnits2.TryGetValue(firingParentName2, ref firingParent2);
							this.SetFiringParent(firingParent2);
						}
						float float_ = num5;
						float float_2 = num4;
						firingParent2 = this.GetFiringParent();
						this.method_76(activeUnit_1, float_, float_2, ref firingParent2, null, null, null, ref text);
						this.SetFiringParent(firingParent2);
						if (!Information.IsNothing(shooterForTheWeapon) && !Information.IsNothing(shooterForTheWeapon.NumOfWeapons) && !Information.IsNothing(shooterForTheWeapon.int_4) && !string.IsNullOrEmpty(text) && !Information.IsNothing(shooterForTheWeapon))
						{
							shooterForTheWeapon.string_2 = text;
						}
					}
					else if (num5 < 926f)
					{
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							scenario_0.LogMessage(string.Concat(new string[]
							{
								"武器: ",
								this.Name,
								"没有命中目标：",
								activeUnit_1.Name,
								" 脱靶量：",
								Conversions.ToString(Math.Max(1, (int)Math.Round((double)(num5 * 3.28084f)))),
								"英尺"
							}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						}
						else
						{
							scenario_0.LogMessage(string.Concat(new string[]
							{
								"武器: ",
								this.Name,
								"没有命中目标目标：",
								activeUnit_1.Name,
								" 脱靶量：",
								Conversions.ToString(Math.Max(1, (int)Math.Round((double)num5))),
								"米"
							}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						}
					}
					else
					{
						scenario_0.LogMessage(string.Concat(new string[]
						{
							"武器: ",
							this.Name,
							" 没有命中目标：",
							activeUnit_1.Name,
							" 脱靶量 ",
							Conversions.ToString(Math.Round((double)(num5 / 1852f), 1)),
							"海里"
						}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
					}
				}
				else if (!flag)
				{
					scenario_0.LogMessage("武器: " + this.Name + "发生故障.", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
				}
				else
				{
					if (flag2)
					{
						ActiveUnit firingParent;
						if (!string.IsNullOrEmpty(this.FiringParentName) && Information.IsNothing(this.GetFiringParent()))
						{
							ObservableDictionary<string, ActiveUnit> activeUnits3 = this.GetWeapon().m_Scenario.GetActiveUnits();
							string firingParentName3 = this.FiringParentName;
							firingParent = this.GetFiringParent();
							activeUnits3.TryGetValue(firingParentName3, ref firingParent);
							this.SetFiringParent(firingParent);
						}
						float float_3 = num5;
						float float_4 = num4;
						firingParent = this.GetFiringParent();
						this.method_76(activeUnit_1, float_3, float_4, ref firingParent, new double?(this.GetLatitude(null)), new double?(this.GetLongitude(null)), null, ref text);
						this.SetFiringParent(firingParent);
					}
					else
					{
						if (!activeUnit_1.MountsAreAimpoints())
						{
							if (this.WarheadArray[0].method_18(this.GetWeapon(), activeUnit_1))
							{
								double num35 = Math.Sqrt(Math.Pow((double)Math.Abs(this.GetCurrentAltitude_ASL(false) - activeUnit_1.GetCurrentAltitude_ASL(false)), 2.0) + Math.Pow((double)num5, 2.0));
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									scenario_0.LogMessage(string.Concat(new string[]
									{
										"武器: ",
										this.Name,
										" airbursted off ",
										activeUnit_1.Name,
										" 脱靶量：",
										Conversions.ToString(Math.Max(1, (int)Math.Round(num35 * 3.2808399200439453))),
										"英尺"
									}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
								}
								else
								{
									scenario_0.LogMessage(string.Concat(new string[]
									{
										"武器: ",
										this.Name,
										" airbursted off ",
										activeUnit_1.Name,
										" 脱靶量：",
										Conversions.ToString(Math.Max(1, (int)Math.Round(num35))),
										"米"
									}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
								}
							}
							else if (num5 < 926f)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									scenario_0.LogMessage(string.Concat(new string[]
									{
										"武器: ",
										this.Name,
										" 没有命中目标：",
										activeUnit_1.Name,
										" 脱靶量：",
										Conversions.ToString(Math.Max(1, (int)Math.Round((double)(num5 * 3.28084f)))),
										"英尺"
									}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
								}
								else
								{
									scenario_0.LogMessage(string.Concat(new string[]
									{
										"武器: ",
										this.Name,
										" 没有命中目标 ",
										activeUnit_1.Name,
										" 脱靶量：",
										Conversions.ToString(Math.Max(1, (int)Math.Round((double)num5))),
										"米"
									}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
								}
							}
							else
							{
								scenario_0.LogMessage(string.Concat(new string[]
								{
									"武器: ",
									this.Name,
									" 没有命中目标 ",
									activeUnit_1.Name,
									" 脱靶量：",
									Conversions.ToString(Math.Round((double)(num5 / 1852f), 1)),
									"海里"
								}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
							}
						}
						if ((this.GetCurrentAltitude_ASL(false) >= 0f && (base.IsOnLand() || this.GetWeaponType() == Weapon._WeaponType.IronBomb || this.GetWeaponType() == Weapon._WeaponType.GuidedWeapon || this.GetWeaponType() == Weapon._WeaponType.Gun || this.GetWeaponType() == Weapon._WeaponType.Rocket)) || this.WarheadArray[0].HasNuclearWarhead(scenario_0) || this.IsTorpedo() || this.GetWeaponType() == Weapon._WeaponType.DepthCharge || (this.WarheadArray[0].warheadType == Warhead.WarheadType.Weapon && this.WarheadArray[0].GetWeaponFromDP(scenario_0).GetWeaponType() == Weapon._WeaponType.DepthCharge) || this.WarheadArray[0].method_18(this.GetWeapon(), activeUnit_1))
						{
							if (!string.IsNullOrEmpty(this.FiringParentName) && Information.IsNothing(this.GetFiringParent()))
							{
								ObservableDictionary<string, ActiveUnit> activeUnits4 = this.GetWeapon().m_Scenario.GetActiveUnits();
								string firingParentName4 = this.FiringParentName;
								ActiveUnit firingParent = this.GetFiringParent();
								activeUnits4.TryGetValue(firingParentName4, ref firingParent);
								this.SetFiringParent(firingParent);
							}
							activeUnit_1.GetDamage().vmethod_11(this.GetWeapon(), this.LaunchPoint, num5, num4, this.GetFiringParent(), new double?(this.GetLatitude(null)), new double?(this.GetLongitude(null)), new float?(this.GetCurrentAltitude_ASL(false)), ref text);
						}
					}
					if (!Information.IsNothing(shooterForTheWeapon) && !Information.IsNothing(shooterForTheWeapon.NumOfWeapons) && !Information.IsNothing(shooterForTheWeapon.int_4) && !string.IsNullOrEmpty(text) && !Information.IsNothing(shooterForTheWeapon))
					{
						shooterForTheWeapon.string_2 = text;
					}
				}
				this.ExportWeaponEndgame(activeUnit_1, flag2, activeUnit_1.IsNotActive(), null, scenario_0);
				result = flag2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100862", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006158 RID: 24920 RVA: 0x002EE690 File Offset: 0x002EC890
		private void method_76(ActiveUnit activeUnit_1, float float_34, float float_35, ref ActiveUnit activeUnit_2, double? nullable_11, double? nullable_12, float? nullable_13, ref string string_5)
		{
			try
			{
				if (!this.GetWeapon().IsDecoy())
				{
					Weapon.smethod_14(this.GetWeapon().m_Scenario, this.GetWeapon(), activeUnit_1, true);
					new WeaponImpact(ref activeUnit_1.m_Scenario, activeUnit_1.GetLongitude(null), activeUnit_1.GetLatitude(null), activeUnit_1.GetCurrentAltitude_ASL(false), WeaponImpact._WeaponImpactType.Airburst);
				}
				if (!activeUnit_1.IsAircraft && !activeUnit_1.IsWeapon)
				{
					if (activeUnit_1.IsFacility)
					{
						if (!((Facility)activeUnit_1).MountsAreAimpoints)
						{
							activeUnit_1.m_Scenario.LogMessage("武器: " + this.UnitClass + "命中" + activeUnit_1.Name, LoggedMessage.MessageType.WeaponDamage, 10, base.GetGuid(), null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						}
					}
					else
					{
						activeUnit_1.m_Scenario.LogMessage("武器: " + this.UnitClass + "命中" + activeUnit_1.Name, LoggedMessage.MessageType.WeaponDamage, 10, base.GetGuid(), null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
					}
				}
				if (!string.IsNullOrEmpty(this.FiringParentName) && Information.IsNothing(activeUnit_2))
				{
					this.GetWeapon().m_Scenario.GetActiveUnits().TryGetValue(this.FiringParentName, ref activeUnit_2);
				}
				activeUnit_1.GetDamage().vmethod_11(this.GetWeapon(), this.LaunchPoint, float_34, float_35, activeUnit_2, nullable_11, nullable_12, nullable_13, ref string_5);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100863", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006159 RID: 24921 RVA: 0x002EE888 File Offset: 0x002ECA88
		private void method_77()
		{
			double? num = ActiveUnit_Navigator.smethod_4(this.GetLatitude(null), this.GetLongitude(null), (double)this.GetCurrentHeading(), this.Target, this.GetCurrentSpeed());
			if (num.HasValue)
			{
				this.SetCurrentHeading((float)num.Value);
			}
			else
			{
				this.SetCurrentHeading(Math2.GetAzimuth(this.GetLatitude(null), this.GetLongitude(null), this.Target.GetLatitude(null), this.Target.GetLongitude(null)));
			}
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x002EE93C File Offset: 0x002ECB3C
		private void ExportWeaponEndgame(ActiveUnit activeUnit_1, bool bool_8, bool bool_9, StringBuilder stringBuilder_0, Scenario scenario_0)
		{
			try
			{
				foreach (IEventExporter current in scenario_0.GetEventExporters())
				{
					if (current.IsExportWeaponEndgame())
					{
						Dictionary<string, Tuple<Type, string>> dictionary = new Dictionary<string, Tuple<Type, string>>();
						dictionary.Add("TimelineID", new Tuple<Type, string>(typeof(string), scenario_0.TimelineID));
						if (current.IsUseZeroHour())
						{
							TimeSpan timeSpan = scenario_0.GetCurrentTime(false).Subtract(scenario_0.ZeroHour);
							dictionary.Add("Time", new Tuple<Type, string>(typeof(TimeSpan), timeSpan.ToString("c")));
						}
						else
						{
							dictionary.Add("Time", new Tuple<Type, string>(typeof(DateTime), scenario_0.GetCurrentTime(false).ToString("MM/dd/yyyy HH:mm:ss") + "." + scenario_0.GetCurrentTime(false).Millisecond.ToString("D3")));
						}
						dictionary.Add("WeaponID", new Tuple<Type, string>(typeof(string), base.GetGuid()));
						dictionary.Add("WeaponName", new Tuple<Type, string>(typeof(string), this.Name));
						dictionary.Add("WeaponSide", new Tuple<Type, string>(typeof(string), this.GetSide(false).GetSideName()));
						if (!Information.IsNothing(this.GetFiringParent()))
						{
							dictionary.Add("ParentFiringUnitID", new Tuple<Type, string>(typeof(string), this.GetFiringParent().GetGuid()));
							dictionary.Add("ParentFiringUnitName", new Tuple<Type, string>(typeof(string), this.GetFiringParent().Name));
						}
						else
						{
							dictionary.Add("ParentFiringUnitID", new Tuple<Type, string>(typeof(string), "-"));
							dictionary.Add("ParentFiringUnitName", new Tuple<Type, string>(typeof(string), "-"));
						}
						dictionary.Add("TargetID", new Tuple<Type, string>(typeof(string), activeUnit_1.GetGuid()));
						dictionary.Add("TargetName", new Tuple<Type, string>(typeof(string), activeUnit_1.Name));
						dictionary.Add("TargetSide", new Tuple<Type, string>(typeof(string), activeUnit_1.GetSide(false).GetSideName()));
						dictionary.Add("TargetLongitude", new Tuple<Type, string>(typeof(double), Conversions.ToString(activeUnit_1.GetLongitude(null))));
						dictionary.Add("TargetLatitude", new Tuple<Type, string>(typeof(double), Conversions.ToString(activeUnit_1.GetLatitude(null))));
						dictionary.Add("TargetAltitude_ASL_m", new Tuple<Type, string>(typeof(float), Conversions.ToString(activeUnit_1.GetCurrentAltitude_ASL(false))));
						dictionary.Add("TargetAltitude_AGL_m", new Tuple<Type, string>(typeof(float), Conversions.ToString(activeUnit_1.GetAltitude_AGL())));
						dictionary.Add("DistanceFromFiringUnit_Horiz", new Tuple<Type, string>(typeof(float), Conversions.ToString(Interaction.IIf(!Information.IsNothing(this.GetFiringParent()), base.GetHorizontalRange(this.GetFiringParent()), "UNKNOWN"))));
						if (bool_8)
						{
							if (bool_9)
							{
								dictionary.Add("Result", new Tuple<Type, string>(typeof(string), "KILL"));
							}
							else
							{
								dictionary.Add("Result", new Tuple<Type, string>(typeof(string), "HIT"));
							}
						}
						else
						{
							dictionary.Add("Result", new Tuple<Type, string>(typeof(string), "MISS"));
						}
						if (Information.IsNothing(stringBuilder_0))
						{
							dictionary.Add("EndgameMessage", new Tuple<Type, string>(typeof(string), "-"));
						}
						else
						{
							dictionary.Add("EndgameMessage", new Tuple<Type, string>(typeof(string), stringBuilder_0.ToString()));
						}
						current.ExportEvent(ExportedEventType.WeaponEndgame, dictionary, activeUnit_1.m_Scenario);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101329", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0400343D RID: 13373
		private int DBID;

		// Token: 0x0400343E RID: 13374
		private Weapon weapon;

		// Token: 0x0400343F RID: 13375
		private Weapon._WeaponType weaponType;

		// Token: 0x04003440 RID: 13376
		public float CEP_Surface;

		// Token: 0x04003441 RID: 13377
		public float CEP_Land;

		// Token: 0x04003442 RID: 13378
		public float CruiseAltitude;

		// Token: 0x04003443 RID: 13379
		public float CruiseAltitude_ASL;

		// Token: 0x04003444 RID: 13380
		public float AirPOK;

		// Token: 0x04003445 RID: 13381
		public float SurfacePOK;

		// Token: 0x04003446 RID: 13382
		public float LandPOK;

		// Token: 0x04003447 RID: 13383
		public float SubsurfacePOK;

		// Token: 0x04003448 RID: 13384
		public float AirRangeMax;

		// Token: 0x04003449 RID: 13385
		public float AirRangeMin;

		// Token: 0x0400344A RID: 13386
		public float SurfaceRangeMax;

		// Token: 0x0400344B RID: 13387
		public float SurfaceRangeMin;

		// Token: 0x0400344C RID: 13388
		public float LandRangeMax;

		// Token: 0x0400344D RID: 13389
		public float LandRangeMin;

		// Token: 0x0400344E RID: 13390
		public float SubsurfaceRangeMax;

		// Token: 0x0400344F RID: 13391
		public float SubsurfaceRangeMin;

		// Token: 0x04003450 RID: 13392
		public float LaunchAltitudeMin;

		// Token: 0x04003451 RID: 13393
		public float LaunchAltitudeMax;

		// Token: 0x04003452 RID: 13394
		public float TargetAltitudeMin;

		// Token: 0x04003453 RID: 13395
		public float TargetAltitudeMax;

		// Token: 0x04003454 RID: 13396
		public float LaunchAltitudeMin_ASL;

		// Token: 0x04003455 RID: 13397
		public float LaunchAltitudeMax_ASL;

		// Token: 0x04003456 RID: 13398
		public float TargetAltitudeMin_ASL;

		// Token: 0x04003457 RID: 13399
		public float TargetAltitudeMax_ASL;

		// Token: 0x04003458 RID: 13400
		public Warhead[] WarheadArray;

		// Token: 0x04003459 RID: 13401
		public Weapon.WeaponCode weaponCode;

		// Token: 0x0400345A RID: 13402
		public Contact Target;

		// Token: 0x0400345B RID: 13403
		private float TimeToLive;

		// Token: 0x0400345C RID: 13404
		public GeoPoint LaunchPoint;

		// Token: 0x0400345D RID: 13405
		private float TimeToDetonate;

		// Token: 0x0400345E RID: 13406
		private ActiveUnit FiringParent;

		// Token: 0x0400345F RID: 13407
		public string FiringParentName = "";

		// Token: 0x04003460 RID: 13408
		private float float_33;

		// Token: 0x04003461 RID: 13409
		private bool? nullable_10;

		// Token: 0x02000B7D RID: 2941
		[CompilerGenerated]
		public sealed class SalvoParticipation
		{
			// Token: 0x0600615B RID: 24923 RVA: 0x0002B113 File Offset: 0x00029313
			internal bool IsPartOfThisSalvo(UnguidedWeapon unguidedWeapon_)
			{
				return Operators.CompareString(unguidedWeapon_.FiringParentName, this.unguidedWeapon.FiringParentName, false) == 0 && this.weaponSalvo.WeaponObjectIDArray.Contains(unguidedWeapon_.GetGuid());
			}

			// Token: 0x04003462 RID: 13410
			public WeaponSalvo weaponSalvo;

			// Token: 0x04003463 RID: 13411
			public UnguidedWeapon unguidedWeapon;
		}
	}
}
