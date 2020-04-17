using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns2;
using ns3;
using ns4;

namespace ns1
{
	// Token: 0x02000A8F RID: 2703
	public sealed class WeaponSalvo : Subject
	{
		// Token: 0x0600553F RID: 21823 RVA: 0x00239124 File Offset: 0x00237324
		public int GetTotalQuantityAssigned()
		{
			WeaponSalvo.Shooter[] shooters = this.m_Shooters;
			int num = 0;
			int num2;
			int result;
			for (int i = 0; i < shooters.Length; i = checked(i + 1))
			{
				WeaponSalvo.Shooter shooter = shooters[i];
				if (shooter.QuantityAssigned == 2147483647)
				{
					num2 = shooter.QuantityAssigned;
					result = num2;
					return result;
				}
				num += shooter.QuantityAssigned;
			}
			num2 = num;
			result = num2;
			return result;
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x00239184 File Offset: 0x00237384
		public int GetTotalQuantityFired()
		{
			WeaponSalvo.Shooter[] shooters = this.m_Shooters;
			int num = 0;
			for (int i = 0; i < shooters.Length; i = checked(i + 1))
			{
				WeaponSalvo.Shooter shooter = shooters[i];
				num += shooter.QuantityFired;
			}
			return num;
		}

		// Token: 0x06005541 RID: 21825 RVA: 0x002391BC File Offset: 0x002373BC
		public void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					xmlWriter_0.WriteStartElement("WeaponSalvo");
					xmlWriter_0.WriteElementString("ID", base.GetGuid());
					if (hashSet_0.Contains(base.GetGuid()))
					{
						xmlWriter_0.WriteEndElement();
					}
					else
					{
						hashSet_0.Add(base.GetGuid());
						xmlWriter_0.WriteStartElement("Weapons");
						string[] weaponObjectIDArray = this.WeaponObjectIDArray;
						for (int i = 0; i < weaponObjectIDArray.Length; i++)
						{
							string value = weaponObjectIDArray[i];
							xmlWriter_0.WriteElementString("Weapon_ObjectID", value);
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Shooters");
						WeaponSalvo.Shooter[] shooters = this.m_Shooters;
						for (int j = 0; j < shooters.Length; j++)
						{
							WeaponSalvo.Shooter shooter = shooters[j];
							xmlWriter_0.WriteStartElement("Shooter");
							xmlWriter_0.WriteElementString("ShooterObjectID", shooter.ShooterObjectID);
							xmlWriter_0.WriteElementString("PreferredMountObjectID", shooter.PreferredMountObjectID);
							if (shooter.QuantityAssigned > 0)
							{
								xmlWriter_0.WriteElementString("QuantityAssigned", shooter.QuantityAssigned.ToString());
							}
							if (shooter.QuantityFired > 0)
							{
								xmlWriter_0.WriteElementString("QuantityFired", shooter.QuantityFired.ToString());
							}
							xmlWriter_0.WriteElementString("TimeToNextLaunch", shooter.TimeToNextLaunch.ToString());
							xmlWriter_0.WriteElementString("Timeout", shooter.Timeout.ToString());
							if (!Information.IsNothing(shooter.FirstWeaponDPI))
							{
								xmlWriter_0.WriteStartElement("FirstWeaponDPI");
								shooter.FirstWeaponDPI.Save(ref xmlWriter_0, ref hashSet_0);
								xmlWriter_0.WriteEndElement();
							}
							xmlWriter_0.WriteEndElement();
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteElementString("NumberOfShooters", this.NumberOfShooters.ToString());
						xmlWriter_0.WriteElementString("WeaponDBID", this.WeaponDBID.ToString());
						xmlWriter_0.WriteElementString("Quantity_Total", this.Quantity_Total.ToString());
						xmlWriter_0.WriteElementString("Target", this.Target.GetGuid());
						xmlWriter_0.WriteElementString("ScheduledFireTime", this.ScheduledFireTime.ToBinary().ToString());
						if (this.ASMode != Weapon._ASMode.const_0)
						{
							XmlWriter xmlWriter = xmlWriter_0;
							string localName = "ASMode";
							int k = (int)this.ASMode;
							xmlWriter.WriteElementString(localName, k.ToString());
						}
						xmlWriter_0.WriteStartElement("PlottedCourse");
						Waypoint[] plottedCourse = this.PlottedCourse;
						for (int k = 0; k < plottedCourse.Length; k++)
						{
							Waypoint waypoint = plottedCourse[k];
							if (!Information.IsNothing(waypoint))
							{
								waypoint.Save(ref xmlWriter_0, ref hashSet_0);
							}
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteElementString("ManualFire", this.ManualFire.ToString());
						xmlWriter_0.WriteElementString("FireSimultaneouslyFromMultipleMounts", this.FireSimultaneouslyFromMultipleMounts.ToString());
						xmlWriter_0.WriteEndElement();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101206", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005542 RID: 21826 RVA: 0x002394F8 File Offset: 0x002376F8
		public static WeaponSalvo Load(ref XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			WeaponSalvo result = null;
			try
			{
				WeaponSalvo weaponSalvo = new WeaponSalvo();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 2338845032u)
						{
							if (num <= 1456985430u)
							{
								if (num != 660689768u)
								{
									if (num != 1437471919u)
									{
										if (num != 1456985430u || Operators.CompareString(name, "Weapons", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator2.MoveNext())
											{
												string innerText = ((XmlNode)enumerator2.Current).InnerText;
												ScenarioArrayUtil.AddStringToArray(ref weaponSalvo.WeaponObjectIDArray, innerText);
											}
											continue;
										}
										finally
										{
											if (enumerator2 is IDisposable)
											{
												(enumerator2 as IDisposable).Dispose();
											}
										}
									}
									if (Operators.CompareString(name, "ManualFire", false) == 0)
									{
										weaponSalvo.ManualFire = Conversions.ToBoolean(xmlNode.InnerText);
									}
								}
								else if (Operators.CompareString(name, "NumberOfShooters", false) == 0)
								{
									weaponSalvo.NumberOfShooters = Conversions.ToInteger(xmlNode.InnerText);
								}
							}
							else if (num != 1458105184u)
							{
								if (num != 1888467057u)
								{
									if (num == 2338845032u && Operators.CompareString(name, "Target", false) == 0)
									{
										if (xmlNode.InnerText.StartsWith("Aimpoint_"))
										{
											weaponSalvo.Target = Aimpoint.GetAimpoint(xmlNode.InnerText);
										}
										else
										{
											weaponSalvo.Target = Contact.GetContact(xmlNode.InnerText, ref dictionary_0);
										}
									}
								}
								else if (Operators.CompareString(name, "FireSimultaneouslyFromMultipleMounts", false) == 0)
								{
									weaponSalvo.FireSimultaneouslyFromMultipleMounts = Conversions.ToBoolean(xmlNode.InnerText);
								}
							}
							else if (Operators.CompareString(name, "ID", false) == 0)
							{
								weaponSalvo.SetGuid(xmlNode.InnerText);
							}
						}
						else if (num <= 3611682378u)
						{
							if (num != 2560176125u)
							{
								if (num != 3057301722u)
								{
									if (num == 3611682378u && Operators.CompareString(name, "WeaponDBID", false) == 0)
									{
										weaponSalvo.WeaponDBID = Conversions.ToInteger(xmlNode.InnerText);
									}
								}
								else if (Operators.CompareString(name, "ASMode", false) == 0)
								{
									weaponSalvo.ASMode = (Weapon._ASMode)Conversions.ToInteger(xmlNode.InnerText);
								}
							}
							else if (Operators.CompareString(name, "Quantity_Total", false) == 0)
							{
								weaponSalvo.Quantity_Total = Conversions.ToInteger(xmlNode.InnerText);
							}
						}
						else
						{
							if (num != 3750830438u)
							{
								if (num != 3921069436u)
								{
									if (num == 4249887469u && Operators.CompareString(name, "ScheduledFireTime", false) == 0)
									{
										weaponSalvo.ScheduledFireTime = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Shooters", false) != 0)
									{
										continue;
									}
									IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator3.MoveNext())
										{
											XmlNode xmlNode2 = (XmlNode)enumerator3.Current;
											string string_ = "";
											string string_2 = "";
											int int_ = 0;
											GeoPoint firstWeaponDPI = null;
											int int_2 = 0;
											int int_3 = 0;
											IEnumerator enumerator4 = xmlNode2.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator4.MoveNext())
												{
													XmlNode xmlNode3 = (XmlNode)enumerator4.Current;
													string name2 = xmlNode3.Name;
													num = Class382.smethod_0(name2);
													if (num <= 2142617681u)
													{
														if (num != 848378024u)
														{
															if (num != 1420849955u)
															{
																if (num == 2142617681u && Operators.CompareString(name2, "PreferredMountObjectID", false) == 0)
																{
																	string_2 = xmlNode3.InnerText;
																}
															}
															else if (Operators.CompareString(name2, "TimeToNextLaunch", false) == 0)
															{
																int_ = Conversions.ToInteger(xmlNode3.InnerText);
															}
														}
														else if (Operators.CompareString(name2, "FirstWeaponDPI", false) == 0)
														{
															firstWeaponDPI = GeoPoint.Load(ref xmlNode, ref dictionary_0);
														}
													}
													else if (num <= 2328193592u)
													{
														if (num != 2195291688u)
														{
															if (num == 2328193592u && Operators.CompareString(name2, "QuantityFired", false) == 0)
															{
																int_2 = Conversions.ToInteger(xmlNode3.InnerText);
															}
														}
														else if (Operators.CompareString(name2, "Timeout", false) == 0)
														{
															Conversions.ToInteger(xmlNode3.InnerText);
														}
													}
													else if (num != 2750558121u)
													{
														if (num == 3698717248u && Operators.CompareString(name2, "QuantityAssigned", false) == 0)
														{
															int_3 = Conversions.ToInteger(xmlNode3.InnerText);
														}
													}
													else if (Operators.CompareString(name2, "ShooterObjectID", false) == 0)
													{
														string_ = xmlNode3.InnerText;
													}
												}
											}
											finally
											{
												if (enumerator4 is IDisposable)
												{
													(enumerator4 as IDisposable).Dispose();
												}
											}
											ScenarioArrayUtil.AddShooter(ref weaponSalvo.m_Shooters, new WeaponSalvo.Shooter(string_, string_2, int_3, int_2, int_)
											{
												FirstWeaponDPI = firstWeaponDPI
											});
										}
										continue;
									}
									finally
									{
										if (enumerator3 is IDisposable)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
								}
							}
							if (Operators.CompareString(name, "PlottedCourse", false) == 0)
							{
								IEnumerator enumerator5 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator5.MoveNext())
									{
										XmlNode xmlNode4 = (XmlNode)enumerator5.Current;
										Waypoint waypoint_ = Waypoint.smethod_9(ref xmlNode4, ref dictionary_0);
										ScenarioArrayUtil.AddWaypoint(ref weaponSalvo.PlottedCourse, waypoint_);
									}
								}
								finally
								{
									if (enumerator5 is IDisposable)
									{
										(enumerator5 as IDisposable).Dispose();
									}
								}
							}
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
				result = weaponSalvo;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101205", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new WeaponSalvo();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005543 RID: 21827 RVA: 0x00027328 File Offset: 0x00025528
		private WeaponSalvo()
		{
			this.m_Shooters = new WeaponSalvo.Shooter[0];
			this.WeaponObjectIDArray = new string[0];
			this.PlottedCourse = new Waypoint[0];
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x00239C40 File Offset: 0x00237E40
		public WeaponSalvo(ref int theWeaponDBID, int theQuantity_ToFire, int theQuantity_Fired, int theQuantity_Assigned, ref Contact theTarget, ref bool theManualFire, string theShooterObjectID, int theNumberOfShooters, bool theFireSimultaneouslyFromMultipleMounts, [DateTimeConstant(0L)] DateTime theScheduledTime,  List<Waypoint> thePlottedCourse = null)
		{
			this.m_Shooters = new WeaponSalvo.Shooter[0];
			this.WeaponObjectIDArray = new string[0];
			this.PlottedCourse = new Waypoint[0];
			try
			{
				this.WeaponDBID = theWeaponDBID;
				this.Quantity_Total = theQuantity_ToFire;
				this.NumberOfShooters = theNumberOfShooters;
				this.Target = theTarget;
				this.ManualFire = theManualFire;
				this.FireSimultaneouslyFromMultipleMounts = theFireSimultaneouslyFromMultipleMounts;
				WeaponSalvo.Shooter shooter_ = new WeaponSalvo.Shooter(theShooterObjectID, theQuantity_Assigned, theQuantity_Fired);
				ScenarioArrayUtil.AddShooter(ref this.m_Shooters, shooter_);
                if (!Information.IsNothing(theScheduledTime))
                {
                    this.ScheduledFireTime = theScheduledTime;
                }
                else
                {
                    this.ScheduledFireTime = new DateTime();
                }
                if (!Information.IsNothing(thePlottedCourse))
				{
					this.PlottedCourse = thePlottedCourse.ToArray();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101207", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x00239D40 File Offset: 0x00237F40
		public Weapon GetWeapon(Scenario scenario_)
		{
			if (Information.IsNothing(this.weapon))
			{
				if (this.method_15(scenario_))
				{
					this.weapon = scenario_.GetWeapon(this.WeaponDBID);
				}
				else
				{
					this.weapon = Weapon.GetWeapon(ref scenario_, this.WeaponDBID, null);
				}
			}
			return this.weapon;
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x00239D9C File Offset: 0x00237F9C
		public bool method_15(Scenario scenario_0)
		{
			int weaponDBID = this.WeaponDBID;
			SQLiteConnection sQLiteConnection = scenario_0.GetSQLiteConnection();
			Weapon._WeaponType weaponType = DBFunctions.GetWeaponType(weaponDBID, ref sQLiteConnection);
			bool flag = false;
			bool result;
			if (weaponType <= Weapon._WeaponType.DepthCharge)
			{
				if (weaponType - Weapon._WeaponType.Rocket <= 2 || weaponType == Weapon._WeaponType.DepthCharge)
				{
					result = true;
					return result;
				}
			}
			else if (weaponType == Weapon._WeaponType.Laser || weaponType - Weapon._WeaponType.Troops <= 1)
			{
				result = true;
				return result;
			}
			result = flag;
			return result;
		}

		// Token: 0x04002959 RID: 10585
		public int WeaponDBID;

		// Token: 0x0400295A RID: 10586
		public WeaponSalvo.Shooter[] m_Shooters;

		// Token: 0x0400295B RID: 10587
		public string[] WeaponObjectIDArray;

		// Token: 0x0400295C RID: 10588
		public int NumberOfShooters;

		// Token: 0x0400295D RID: 10589
		public int Quantity_Total = 0;

		// Token: 0x0400295E RID: 10590
		public bool FireSimultaneouslyFromMultipleMounts;

		// Token: 0x0400295F RID: 10591
		public Contact Target;

		// Token: 0x04002960 RID: 10592
		public DateTime ScheduledFireTime;

		// Token: 0x04002961 RID: 10593
		public Waypoint[] PlottedCourse;

		// Token: 0x04002962 RID: 10594
		public bool ManualFire;

		// Token: 0x04002963 RID: 10595
		private Weapon weapon;

		// Token: 0x04002964 RID: 10596
		public Weapon._ASMode ASMode;

		// Token: 0x02000A90 RID: 2704
		public sealed class Shooter
		{
			// Token: 0x06005547 RID: 21831 RVA: 0x0002735B File Offset: 0x0002555B
			public Shooter(string string_3, int int_5, int int_6)
			{
				this.ShooterObjectID = string_3;
				this.QuantityAssigned = int_5;
				this.QuantityFired = int_6;
				this.bool_0 = false;
			}

			// Token: 0x06005548 RID: 21832 RVA: 0x00239E14 File Offset: 0x00238014
			public Shooter(string string_3, string string_4, int int_5, int int_6, int int_7)
			{
				this.ShooterObjectID = string_3;
				this.PreferredMountObjectID = string_4;
				this.QuantityAssigned = int_5;
				this.QuantityFired = int_6;
				this.TimeToNextLaunch = int_7;
			}

			// Token: 0x04002965 RID: 10597
			public string ShooterObjectID;

			// Token: 0x04002966 RID: 10598
			public string PreferredMountObjectID;

			// Token: 0x04002967 RID: 10599
			public int QuantityAssigned;

			// Token: 0x04002968 RID: 10600
			public int QuantityFired;

			// Token: 0x04002969 RID: 10601
			public bool bool_0;

			// Token: 0x0400296A RID: 10602
			public int TimeToNextLaunch = 0;

			// Token: 0x0400296B RID: 10603
			public int Timeout = 0;

			// Token: 0x0400296C RID: 10604
			public int? NumOfWeapons;

			// Token: 0x0400296D RID: 10605
			public int int_4;

			// Token: 0x0400296E RID: 10606
			public float? nullable_1;

			// Token: 0x0400296F RID: 10607
			public float? nullable_2;

			// Token: 0x04002970 RID: 10608
			public int? nullable_3;

			// Token: 0x04002971 RID: 10609
			public GeoPoint FirstWeaponDPI;

			// Token: 0x04002972 RID: 10610
			public GeoPoint geoPoint_1;

			// Token: 0x04002973 RID: 10611
			public string string_2 = "";
		}
	}
}
