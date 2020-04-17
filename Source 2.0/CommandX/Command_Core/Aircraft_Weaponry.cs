using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns2;
using ns4;

namespace Command_Core
{
	// Token: 0x02000A16 RID: 2582
	public sealed class Aircraft_Weaponry : ActiveUnit_Weaponry
	{
		// Token: 0x0600501F RID: 20511 RVA: 0x0020526C File Offset: 0x0020346C
		private Aircraft GetAircraft()
		{
			if (Information.IsNothing(this.aircraft_0))
			{
				this.aircraft_0 = (Aircraft)this.ParentPlatform;
			}
			return this.aircraft_0;
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x002052A4 File Offset: 0x002034A4
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Weaponry");
				if (this.GetWeaponAssignments().Count > 0)
				{
					xmlWriter_0.WriteStartElement("WeaponAssignments");
					using (IEnumerator<WeaponAssignment> enumerator = this.GetWeaponAssignments().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.Save(ref xmlWriter_0, ref hashSet_1);
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100472", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x00205378 File Offset: 0x00203578
		public static Aircraft_Weaponry smethod_4(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Aircraft_Weaponry result;
			try
			{
				Aircraft_Weaponry aircraft_Weaponry = new Aircraft_Weaponry(ref activeUnit_1);
				aircraft_Weaponry.ParentPlatform = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "WeaponAssignments", false) != 0)
						{
							if (Operators.CompareString(name, "HF", false) == 0 && !Information.IsNothing(activeUnit_1.m_Doctrine) && Conversions.ToBoolean(xmlNode.InnerText))
							{
								activeUnit_1.m_Doctrine.method_63(activeUnit_1.m_Scenario, false, null, false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold));
							}
						}
						else
						{
							IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
									WeaponAssignment weaponAssignment = WeaponAssignment.Load(ref xmlNode2, dictionary_0, ref activeUnit_1.m_Scenario);
									if (!Information.IsNothing(weaponAssignment.m_Target))
									{
										aircraft_Weaponry.GetWeaponAssignments().Add(weaponAssignment);
									}
								}
							}
							finally
							{
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
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
				result = aircraft_Weaponry;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100473", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Aircraft_Weaponry(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005022 RID: 20514 RVA: 0x0002576C File Offset: 0x0002396C
		public Aircraft_Weaponry(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}

		// Token: 0x06005023 RID: 20515 RVA: 0x00205560 File Offset: 0x00203760
		public void JettisonExternalStores()
		{
			checked
			{
				if (this.ParentPlatform.m_Scenario.FifthSecondIsChangingOnThisPulse && !Information.IsNothing(this.GetAircraft().GetLoadout()))
				{
					Dictionary<Weapon, int> dictionary = new Dictionary<Weapon, int>();
					WeaponRec[] weaponRecArray = this.GetAircraft().GetLoadout().WeaponRecArray;
					for (int i = 0; i < weaponRecArray.Length; i++)
					{
						WeaponRec weaponRec = weaponRecArray[i];
						if (!weaponRec.IW && weaponRec.GetCurrentLoad() != 0)
						{
							Weapon weapon = weaponRec.GetWeapon(this.GetAircraft().m_Scenario);
							if (!(weapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() | weapon.GetWeaponType() == Weapon._WeaponType.SensorPod))
							{
								if (dictionary.ContainsKey(weapon))
								{
									Dictionary<Weapon, int> dictionary2;
									Weapon key;
									(dictionary2 = dictionary)[key = weapon] = unchecked(dictionary2[key] + weaponRec.GetCurrentLoad());
								}
								else
								{
									dictionary.Add(weapon, weaponRec.GetCurrentLoad());
								}
								weaponRec.SetCurrentLoad(0);
							}
						}
					}
					if (dictionary.Count > 0)
					{
						List<string> list = new List<string>();
						foreach (KeyValuePair<Weapon, int> current in dictionary)
						{
							this.GetAircraft().GetSide(false).m_AAR.AddToExpenditures(current.Key.DBID, current.Value);
							list.Add(Conversions.ToString(current.Value) + "x " + current.Key.Name);
						}
						this.GetAircraft().LogMessage(string.Concat(new string[]
						{
							this.GetAircraft().Name,
							" (",
							this.GetAircraft().UnitClass,
							") has jettisoned external stores (",
							string.Join(", ", list),
							") "
						}), LoggedMessage.MessageType.UnitAI, 0, false, new GeoPoint(this.GetAircraft().GetLongitude(null), this.GetAircraft().GetLatitude(null)));
						base.method_4();
					}
				}
			}
		}

		// Token: 0x06005024 RID: 20516 RVA: 0x00205790 File Offset: 0x00203990
		public override void SchedulePlannedFire(float float_0)
		{
			try
			{
				base.SchedulePlannedFire(float_0);
				if (this.ParentPlatform.GetType() == typeof(Aircraft) && !Information.IsNothing(this.GetAircraft().GetLoadout()))
				{
					WeaponRec[] weaponRecArray = this.GetAircraft().GetLoadout().WeaponRecArray;
					for (int i = 0; i < weaponRecArray.Length; i = checked(i + 1))
					{
						WeaponRec weaponRec = weaponRecArray[i];
						weaponRec.TimeToFire -= float_0;
						if (weaponRec.TimeToFire < 0f)
						{
							weaponRec.TimeToFire = 0f;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100474", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x00205878 File Offset: 0x00203A78
		public ActiveUnit._ActiveUnitWeaponState method_68(ref List<WeaponRec> list_0, bool bool_7, bool bool_8)
		{
			bool flag = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			float num5 = 0f;
			ActiveUnit._ActiveUnitWeaponState result;
			if (!Information.IsNothing(list_0) && list_0.Count > 0)
			{
				if (!Information.IsNothing(list_0) && list_0.Count > 0)
				{
					foreach (WeaponRec current in list_0)
					{
						if (bool_8 && (!bool_8 || current.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Gun))
						{
							if (bool_7)
							{
								num += current.GetCurrentLoad();
								num3 += current.MaxLoad;
								float largestRangeMaxOfAllDomains = current.GetWeapon(this.ParentPlatform.m_Scenario).GetLargestRangeMaxOfAllDomains();
								if (current.GetCurrentLoad() > 0 && num5 < largestRangeMaxOfAllDomains)
								{
									num5 = largestRangeMaxOfAllDomains;
								}
							}
						}
						else
						{
							num2 += current.GetCurrentLoad();
							num4 += current.MaxLoad;
						}
					}
				}
				if (num == 0 && num2 == 0)
				{
					result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					return result;
				}
				if (num2 == 0)
				{
					flag = true;
				}
			}
			ActiveUnit._ActiveUnitWeaponState activeUnitWeaponState;
			if (flag)
			{
				if (this.ParentPlatform.GetSide(false).GetQuantityToFireForThePlatform(ref this.ParentPlatform) > 0)
				{
					activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
				}
				else
				{
					Contact[] targets = this.ParentPlatform.GetAI().GetTargets();
					float horizontalRange;
					checked
					{
						for (int i = 0; i < targets.Length; i++)
						{
							Contact contact_ = targets[i];
							ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = this.ParentPlatform.GetAI().GetTargetingBehavior(contact_);
							if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted || targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
							{
								result = ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
								return result;
							}
						}
						if (this.ParentPlatform.GetAI().GetTargets().Length == 1)
						{
							horizontalRange = this.ParentPlatform.GetHorizontalRange(this.ParentPlatform.GetAI().GetTargets()[0]);
						}
						else
						{
							IEnumerable<Contact> source = this.ParentPlatform.GetAI().GetTargets().OrderBy(new Func<Contact, double>(this.method_74));
							horizontalRange = this.ParentPlatform.GetHorizontalRange(source.ElementAtOrDefault(0));
						}
						if (num > 0 && num5 < 5f)
						{
							num5 = 5f;
						}
					}
					if (num5 > 0f && (double)horizontalRange > (double)num5 * 1.2)
					{
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
					}
					else if (this.ParentPlatform.IsRTB())
					{
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
					else
					{
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
					}
				}
			}
			else
			{
				activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
			}
			result = activeUnitWeaponState;
			return result;
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x00205B40 File Offset: 0x00203D40
		public ActiveUnit._ActiveUnitWeaponState method_69(ref List<WeaponRec> list_0, ref bool bool_7, bool bool_8, bool bool_9, bool bool_10, bool bool_11, bool bool_12)
		{
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			float num7 = 0f;
			float num8 = 0f;
			ActiveUnit._ActiveUnitWeaponState result;
			if (!Information.IsNothing(list_0) && list_0.Count > 0)
			{
				foreach (WeaponRec current in list_0)
				{
					if (!bool_12 || (bool_12 && current.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun))
					{
						num4 += current.GetCurrentLoad();
						num6 += current.MaxLoad;
					}
					if (bool_7)
					{
						if (!current.GetWeapon(this.ParentPlatform.m_Scenario).IsLongRangeAAWWeapon() && (!bool_9 || !current.GetWeapon(this.ParentPlatform.m_Scenario).IsShortRangeAAWGuideWeapon()))
						{
							if (current.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Gun)
							{
								if (bool_11)
								{
									num3 += current.GetCurrentLoad();
									float largestRangeMaxOfAllDomains = current.GetWeapon(this.ParentPlatform.m_Scenario).GetLargestRangeMaxOfAllDomains();
									if (current.GetCurrentLoad() > 0 && num8 < largestRangeMaxOfAllDomains)
									{
										num8 = largestRangeMaxOfAllDomains;
									}
								}
							}
							else if (bool_10)
							{
								num2 += current.GetCurrentLoad();
								float largestRangeMaxOfAllDomains2 = current.GetWeapon(this.ParentPlatform.m_Scenario).GetLargestRangeMaxOfAllDomains();
								if (current.GetCurrentLoad() > 0 && num8 < largestRangeMaxOfAllDomains2)
								{
									num8 = largestRangeMaxOfAllDomains2;
								}
							}
						}
						else
						{
							if (!bool_8 && current.GetCurrentLoad() > 0)
							{
								result = ActiveUnit._ActiveUnitWeaponState.None;
								return result;
							}
							num += current.GetCurrentLoad();
							num5 += current.MaxLoad;
							float largestRangeMaxOfAllDomains3 = current.GetWeapon(this.ParentPlatform.m_Scenario).GetLargestRangeMaxOfAllDomains();
							if (num7 < largestRangeMaxOfAllDomains3)
							{
								num7 = largestRangeMaxOfAllDomains3;
							}
						}
					}
					else if (!current.GetWeapon(this.ParentPlatform.m_Scenario).method_176() && (!bool_9 || current.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Gun))
					{
						if (bool_10)
						{
							num2 += current.GetCurrentLoad();
							float largestRangeMaxOfAllDomains4 = current.GetWeapon(this.ParentPlatform.m_Scenario).GetLargestRangeMaxOfAllDomains();
							if (current.GetCurrentLoad() > 0 && num8 < largestRangeMaxOfAllDomains4)
							{
								num8 = largestRangeMaxOfAllDomains4;
							}
						}
					}
					else
					{
						if (!bool_8 && current.GetCurrentLoad() > 0)
						{
							result = ActiveUnit._ActiveUnitWeaponState.None;
							return result;
						}
						num += current.GetCurrentLoad();
						num5 += current.MaxLoad;
						float largestRangeMaxOfAllDomains5 = current.GetWeapon(this.ParentPlatform.m_Scenario).GetLargestRangeMaxOfAllDomains();
						if (num7 < largestRangeMaxOfAllDomains5)
						{
							num7 = largestRangeMaxOfAllDomains5;
						}
					}
				}
				if (num3 == 0 && num2 == 0 && num == 0)
				{
					result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					return result;
				}
				if (bool_8)
				{
					if (num < num5)
					{
						flag2 = true;
					}
				}
				else if (num == 0)
				{
					flag2 = true;
				}
				if (num4 == 0)
				{
					flag = true;
				}
			}
			ActiveUnit._ActiveUnitWeaponState activeUnitWeaponState;
			if (!flag && !flag2)
			{
				activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
			}
			else if (this.ParentPlatform.GetAI().GetTargets().Length == 0)
			{
				activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
			}
			else if (this.ParentPlatform.GetSide(false).GetQuantityToFireForThePlatform(ref this.ParentPlatform) > 0)
			{
				activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
			}
			else
			{
				Contact[] targets = this.ParentPlatform.GetAI().GetTargets();
				float horizontalRange;
				checked
				{
					for (int i = 0; i < targets.Length; i++)
					{
						Contact contact_ = targets[i];
						ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = this.ParentPlatform.GetAI().GetTargetingBehavior(contact_);
						if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted || targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
						{
							if (flag)
							{
								result = ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
								return result;
							}
							if (flag2)
							{
								result = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
								return result;
							}
						}
					}
					if (this.ParentPlatform.GetAI().GetTargets().Length == 1)
					{
						horizontalRange = this.ParentPlatform.GetHorizontalRange(this.ParentPlatform.GetAI().GetTargets()[0]);
					}
					else
					{
						IEnumerable<Contact> source = this.ParentPlatform.GetAI().GetTargets().OrderBy(new Func<Contact, double>(this.method_75));
						horizontalRange = this.ParentPlatform.GetHorizontalRange(source.ElementAtOrDefault(0));
					}
					if ((bool_11 || (!bool_9 && bool_10)) && (num2 > 0 || num3 > 0) && num8 < 5f)
					{
						num8 = 5f;
					}
				}
				if (num > 0 && num7 > 0f)
				{
					if ((double)horizontalRange > (double)num7 * 1.2)
					{
						if (flag)
						{
							result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							return result;
						}
						if (flag2)
						{
							result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
							return result;
						}
					}
				}
				else if (num8 > 0f)
				{
					if ((double)horizontalRange > (double)num8 * 1.2)
					{
						if (flag)
						{
							result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							return result;
						}
						if (flag2)
						{
							result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
							return result;
						}
					}
				}
				else
				{
					if (flag)
					{
						result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
						return result;
					}
					result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
					return result;
				}
				if (this.ParentPlatform.IsRTB())
				{
					if (flag)
					{
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
					else
					{
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
					}
				}
				else if (flag)
				{
					activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
				}
				else
				{
					activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
				}
			}
			result = activeUnitWeaponState;
			return result;
		}

		// Token: 0x06005027 RID: 20519 RVA: 0x00206120 File Offset: 0x00204320
		public ActiveUnit._ActiveUnitWeaponState method_70(ref List<WeaponRec> list_0, ref bool bool_7, bool bool_8, bool bool_9, bool bool_10)
		{
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			float num8 = 0f;
			float num9 = 0f;
			ActiveUnit._ActiveUnitWeaponState result;
			if (!Information.IsNothing(list_0) && list_0.Count > 0)
			{
				foreach (WeaponRec current in list_0)
				{
					if (!bool_10 || (bool_10 && current.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun))
					{
						num4 += current.GetCurrentLoad();
						num7 += current.MaxLoad;
					}
					if (bool_7)
					{
						if (current.GetWeapon(this.ParentPlatform.m_Scenario).IsAntiAircraftOrMissileGuidedWeapon())
						{
							if (!bool_8 && current.GetCurrentLoad() > 0)
							{
								result = ActiveUnit._ActiveUnitWeaponState.None;
								return result;
							}
							if (current.GetWeapon(this.ParentPlatform.m_Scenario).IsLongRangeAAWWeapon())
							{
								num += current.GetCurrentLoad();
								num5 += current.MaxLoad;
							}
							else
							{
								num2 += current.GetCurrentLoad();
								num6 += current.MaxLoad;
							}
							float largestRangeMaxOfAllDomains = current.GetWeapon(this.ParentPlatform.m_Scenario).GetLargestRangeMaxOfAllDomains();
							if (num8 < largestRangeMaxOfAllDomains)
							{
								num8 = largestRangeMaxOfAllDomains;
							}
						}
						else if (bool_9)
						{
							num3 += current.GetCurrentLoad();
							float largestRangeMaxOfAllDomains2 = current.GetWeapon(this.ParentPlatform.m_Scenario).GetLargestRangeMaxOfAllDomains();
							if (current.GetCurrentLoad() > 0 && num9 < largestRangeMaxOfAllDomains2)
							{
								num9 = largestRangeMaxOfAllDomains2;
							}
						}
					}
					else
					{
						if (!bool_8 && current.GetCurrentLoad() > 0)
						{
							result = ActiveUnit._ActiveUnitWeaponState.None;
							return result;
						}
						if (current.GetWeapon(this.ParentPlatform.m_Scenario).method_176())
						{
							num += current.GetCurrentLoad();
							num5 += current.MaxLoad;
						}
						else
						{
							num2 += current.GetCurrentLoad();
							num6 += current.MaxLoad;
						}
						float largestRangeMaxOfAllDomains3 = current.GetWeapon(this.ParentPlatform.m_Scenario).GetLargestRangeMaxOfAllDomains();
						if (num8 < largestRangeMaxOfAllDomains3)
						{
							num8 = largestRangeMaxOfAllDomains3;
						}
					}
				}
				if (num3 == 0 && num2 == 0 && num == 0)
				{
					result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					return result;
				}
				if (bool_8)
				{
					if (num2 < num6)
					{
						flag2 = true;
					}
				}
				else if (num2 == 0)
				{
					flag2 = true;
				}
				if (num6 == 0 && num == 0)
				{
					flag = true;
				}
				if (num4 == 0)
				{
					flag = true;
				}
			}
			ActiveUnit._ActiveUnitWeaponState activeUnitWeaponState;
			if (!flag && !flag2)
			{
				activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
			}
			else if (this.ParentPlatform.GetAI().GetTargets().Length == 0)
			{
				activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
			}
			else if (this.ParentPlatform.GetSide(false).GetQuantityToFireForThePlatform(ref this.ParentPlatform) > 0)
			{
				activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
			}
			else
			{
				Contact[] targets = this.ParentPlatform.GetAI().GetTargets();
				float horizontalRange;
				checked
				{
					for (int i = 0; i < targets.Length; i++)
					{
						Contact contact_ = targets[i];
						ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = this.ParentPlatform.GetAI().GetTargetingBehavior(contact_);
						if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted || targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
						{
							if (flag)
							{
								result = ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
								return result;
							}
							if (flag2)
							{
								result = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
								return result;
							}
						}
					}
					if (this.ParentPlatform.GetAI().GetTargets().Length == 1)
					{
						horizontalRange = this.ParentPlatform.GetHorizontalRange(this.ParentPlatform.GetAI().GetTargets()[0]);
					}
					else
					{
						IEnumerable<Contact> source = this.ParentPlatform.GetAI().GetTargets().OrderBy(new Func<Contact, double>(this.method_76));
						horizontalRange = this.ParentPlatform.GetHorizontalRange(source.ElementAtOrDefault(0));
					}
					if (bool_9 && num3 > 0 && num9 < 5f)
					{
						num9 = 5f;
					}
					if (num2 > 0 && num8 < 5f)
					{
						num8 = 5f;
					}
				}
				if ((num6 > 0 || num5 > 0) && num8 > 0f)
				{
					if ((double)horizontalRange > (double)num8 * 1.2)
					{
						if (flag)
						{
							result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							return result;
						}
						if (flag2)
						{
							result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
							return result;
						}
					}
				}
				else if (num9 > 0f && (double)horizontalRange > (double)num9 * 1.2)
				{
					if (flag)
					{
						result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
						return result;
					}
					if (flag2)
					{
						result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
						return result;
					}
				}
				if (this.ParentPlatform.IsRTB())
				{
					if (flag)
					{
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
					else
					{
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
					}
				}
				else if (flag)
				{
					activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
				}
				else
				{
					activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
				}
			}
			result = activeUnitWeaponState;
			return result;
		}

		// Token: 0x06005028 RID: 20520 RVA: 0x0020665C File Offset: 0x0020485C
		public ActiveUnit._ActiveUnitWeaponState method_71(ref List<WeaponRec> list_0, ref bool bool_7, bool bool_8, bool bool_9)
		{
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			float num7 = 0f;
			float num8 = 0f;
			ActiveUnit._ActiveUnitWeaponState result;
			if (!Information.IsNothing(list_0) && list_0.Count > 0)
			{
				foreach (WeaponRec current in list_0)
				{
					if (!bool_9 || (bool_9 && current.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun))
					{
						num3 += current.GetCurrentLoad();
						num6 += current.MaxLoad;
					}
					if (current.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Gun)
					{
						num += current.GetCurrentLoad();
						num4 += current.MaxLoad;
						float largestRangeMaxOfAllDomains = current.GetWeapon(this.ParentPlatform.m_Scenario).GetLargestRangeMaxOfAllDomains();
						if (current.GetCurrentLoad() > 0 && num7 < largestRangeMaxOfAllDomains)
						{
							num7 = largestRangeMaxOfAllDomains;
						}
					}
					else
					{
						num2 += current.GetCurrentLoad();
						num5 += current.MaxLoad;
						float largestRangeMaxOfAllDomains2 = current.GetWeapon(this.ParentPlatform.m_Scenario).GetLargestRangeMaxOfAllDomains();
						if (current.GetCurrentLoad() > 0 && num8 < largestRangeMaxOfAllDomains2)
						{
							num8 = largestRangeMaxOfAllDomains2;
						}
					}
				}
				if (num == 0 && num2 == 0)
				{
					result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					return result;
				}
				if (num < num4)
				{
					flag2 = true;
				}
				if (num4 == 0 && num2 == 0)
				{
					flag = true;
				}
				if (num3 == 0)
				{
					flag = true;
				}
			}
			ActiveUnit._ActiveUnitWeaponState activeUnitWeaponState;
			if (!flag && !flag2)
			{
				activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
			}
			else if (this.ParentPlatform.GetAI().GetTargets().Length == 0)
			{
				activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
			}
			else if (this.ParentPlatform.GetSide(false).GetQuantityToFireForThePlatform(ref this.ParentPlatform) > 0)
			{
				activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
			}
			else
			{
				Contact[] targets = this.ParentPlatform.GetAI().GetTargets();
				float horizontalRange;
				checked
				{
					for (int i = 0; i < targets.Length; i++)
					{
						Contact contact_ = targets[i];
						ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = this.ParentPlatform.GetAI().GetTargetingBehavior(contact_);
						if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted || targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
						{
							if (flag)
							{
								result = ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
								return result;
							}
							if (flag2)
							{
								result = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
								return result;
							}
						}
					}
					if (this.ParentPlatform.GetAI().GetTargets().Length == 1)
					{
						horizontalRange = this.ParentPlatform.GetHorizontalRange(this.ParentPlatform.GetAI().GetTargets()[0]);
					}
					else
					{
						IEnumerable<Contact> source = this.ParentPlatform.GetAI().GetTargets().OrderBy(new Func<Contact, double>(this.method_77));
						horizontalRange = this.ParentPlatform.GetHorizontalRange(source.ElementAtOrDefault(0));
					}
					if (num > 0 && num7 < 5f)
					{
						num7 = 5f;
					}
				}
				if (num8 > 0f)
				{
					if ((double)horizontalRange > (double)num8 * 1.2)
					{
						if (flag)
						{
							result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							return result;
						}
						if (flag2)
						{
							result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
							return result;
						}
					}
				}
				else if (num7 > 0f && (double)horizontalRange > (double)num7 * 1.2)
				{
					if (flag)
					{
						if (bool_9 && !flag2)
						{
							result = ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
							return result;
						}
						result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
						return result;
					}
					else if (flag2)
					{
						result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
						return result;
					}
				}
				if (this.ParentPlatform.IsRTB())
				{
					if (flag)
					{
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
					else
					{
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
					}
				}
				else if (flag)
				{
					activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
				}
				else
				{
					activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
				}
			}
			result = activeUnitWeaponState;
			return result;
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x00206A70 File Offset: 0x00204C70
		public ActiveUnit._ActiveUnitWeaponState method_72(ref List<WeaponRec> list_0, ref bool bool_7, int int_0, bool bool_8, bool bool_9)
		{
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			float num7 = 0f;
			float num8 = 0f;
			ActiveUnit._ActiveUnitWeaponState result;
			if (!Information.IsNothing(list_0) && list_0.Count > 0)
			{
				if (!Information.IsNothing(list_0) && list_0.Count > 0)
				{
					foreach (WeaponRec current in list_0)
					{
						if (!bool_9 || (bool_9 && current.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun))
						{
							num3 += current.GetCurrentLoad();
							num6 += current.MaxLoad;
						}
						if (current.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Gun)
						{
							if (bool_8)
							{
								num += current.GetCurrentLoad();
								num4 += current.MaxLoad;
								float largestRangeMaxOfAllDomains = current.GetWeapon(this.ParentPlatform.m_Scenario).GetLargestRangeMaxOfAllDomains();
								if (current.GetCurrentLoad() > 0 && num7 < largestRangeMaxOfAllDomains)
								{
									num7 = largestRangeMaxOfAllDomains;
								}
							}
						}
						else
						{
							num2 += current.GetCurrentLoad();
							if (bool_8)
							{
								num5 += current.MaxLoad;
								float largestRangeMaxOfAllDomains2 = current.GetWeapon(this.ParentPlatform.m_Scenario).GetLargestRangeMaxOfAllDomains();
								if (current.GetCurrentLoad() > 0 && num8 < largestRangeMaxOfAllDomains2)
								{
									num8 = largestRangeMaxOfAllDomains2;
								}
							}
						}
					}
				}
				if (num == 0 && num2 == 0)
				{
					result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					return result;
				}
				if (bool_9)
				{
					if ((double)num2 <= (double)num5 * (1.0 - (double)int_0 / 100.0))
					{
						flag2 = true;
					}
				}
				else if ((double)(num + num2) <= (double)(num4 + num5) * (1.0 - (double)int_0 / 100.0))
				{
					flag2 = true;
				}
				if (num3 == 0)
				{
					flag = true;
				}
			}
			ActiveUnit._ActiveUnitWeaponState activeUnitWeaponState;
			if (!flag && !flag2)
			{
				activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
			}
			else if (this.ParentPlatform.GetAI().GetTargets().Length == 0)
			{
				activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
			}
			else if (this.ParentPlatform.GetSide(false).GetQuantityToFireForThePlatform(ref this.ParentPlatform) > 0)
			{
				activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
			}
			else
			{
				Contact[] targets = this.ParentPlatform.GetAI().GetTargets();
				float horizontalRange;
				checked
				{
					for (int i = 0; i < targets.Length; i++)
					{
						Contact contact_ = targets[i];
						ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = this.ParentPlatform.GetAI().GetTargetingBehavior(contact_);
						if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted || targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
						{
							if (flag)
							{
								result = ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
								return result;
							}
							if (flag2)
							{
								result = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
								return result;
							}
						}
					}
					if (this.ParentPlatform.GetAI().GetTargets().Length == 1)
					{
						horizontalRange = this.ParentPlatform.GetHorizontalRange(this.ParentPlatform.GetAI().GetTargets()[0]);
					}
					else
					{
						IEnumerable<Contact> source = this.ParentPlatform.GetAI().GetTargets().OrderBy(new Func<Contact, double>(this.method_78));
						horizontalRange = this.ParentPlatform.GetHorizontalRange(source.ElementAtOrDefault(0));
					}
					if (num > 0 && num7 < 5f)
					{
						num7 = 5f;
					}
				}
				if (num8 > 0f)
				{
					if ((double)horizontalRange > (double)num8 * 1.2)
					{
						if (flag)
						{
							result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							return result;
						}
						if (flag2)
						{
							result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
							return result;
						}
					}
				}
				else if (num7 > 0f && (double)horizontalRange > (double)num7 * 1.2)
				{
					if (flag)
					{
						if (bool_9 && !flag2)
						{
							result = ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
							return result;
						}
						result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
						return result;
					}
					else if (flag2)
					{
						result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
						return result;
					}
				}
				if (this.ParentPlatform.IsRTB())
				{
					if (flag)
					{
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
					else
					{
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
					}
				}
				else if (flag)
				{
					activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
				}
				else
				{
					activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
				}
			}
			result = activeUnitWeaponState;
			return result;
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x00206EE8 File Offset: 0x002050E8
		public override ActiveUnit._ActiveUnitWeaponState vmethod_3()
		{
			checked
			{
				ActiveUnit._ActiveUnitWeaponState activeUnitWeaponState;
				ActiveUnit._ActiveUnitWeaponState result;
				if (Information.IsNothing(this.GetAircraft().GetLoadout()))
				{
					activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
				}
				else
				{
					try
					{
						Doctrine._WeaponState? winchesterShotgunDoctrine = this.ParentPlatform.m_Doctrine.GetWinchesterShotgunDoctrine(this.ParentPlatform.m_Scenario, false, true, false, false);
						int? num = winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null;
						bool flag;
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							flag = true;
							if (!Information.IsNothing(this.GetAircraft().GetLoadout()))
							{
								winchesterShotgunDoctrine = new Doctrine._WeaponState?(this.GetAircraft().GetLoadout().WinchesterShotgunWeaponState);
							}
						}
						else
						{
							flag = false;
						}
						Loadout.LoadoutRole loadoutRole = this.GetAircraft().GetLoadout().loadoutRole;
						bool flag2 = false;
						bool flag3 = false;
						if (loadoutRole <= Loadout.LoadoutRole.LandOnly_DEAD)
						{
							if (unchecked(loadoutRole - Loadout.LoadoutRole.Intercept_BVR) > 6)
							{
								switch (loadoutRole)
								{
								case Loadout.LoadoutRole.LandNaval_Strike:
									break;
								case Loadout.LoadoutRole.LandNaval_Standoff:
									goto IL_2A7C;
								case Loadout.LoadoutRole.LandNaval_SEAD_ARM:
								case Loadout.LoadoutRole.LandNaval_DEAD:
									goto IL_33B6;
								case Loadout.LoadoutRole.LandNaval_SEAD_TALD:
									goto IL_3374;
								default:
									switch (loadoutRole)
									{
									case Loadout.LoadoutRole.LandOnly_Strike:
										break;
									case Loadout.LoadoutRole.LandOnly_Standoff:
										goto IL_2A7C;
									case Loadout.LoadoutRole.LandOnly_SEAD_ARM:
									case Loadout.LoadoutRole.LandOnly_DEAD:
										goto IL_33B6;
									case Loadout.LoadoutRole.LandOnly_SEAD_TALD:
										goto IL_3374;
									default:
										goto IL_3D23;
									}
									break;
								}
							}
							else if (!this.GetAircraft().m_Scenario.FeatureCompatibility.get_WeaponAGL_ASL(this.GetAircraft().m_Scenario.GetSQLiteConnection()) && flag)
							{
								switch (this.GetAircraft().GetLoadout().loadoutRole)
								{
								case Loadout.LoadoutRole.Intercept_BVR:
								case Loadout.LoadoutRole.PointDefence_BVR:
									if (Information.IsNothing(this.ParentPlatform.GetAssignedMission(false)))
									{
										if (this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_100)).Count<WeaponRec>() == 0)
										{
											flag2 = true;
										}
										if (this.ParentPlatform.m_Mounts.Where(Aircraft_Weaponry.MountFunc).Count<Mount>() == 0)
										{
											flag3 = true;
										}
										if (flag2 && flag3)
										{
											activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
											result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
											return result;
										}
										activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
										result = ActiveUnit._ActiveUnitWeaponState.None;
										return result;
									}
									else
									{
										bool flag4 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_101)).Count<WeaponRec>() > 0;
										Mission._MissionClass missionClass = this.ParentPlatform.GetAssignedMission(false).MissionClass;
										if (missionClass != Mission._MissionClass.Strike)
										{
											if (missionClass != Mission._MissionClass.Patrol)
											{
												goto IL_3C7C;
											}
											if (!flag4)
											{
												activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
												result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
												return result;
											}
											activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
											result = ActiveUnit._ActiveUnitWeaponState.None;
											return result;
										}
										else
										{
											if (((Strike)this.ParentPlatform.GetAssignedMission(false)).strikeType != Strike.StrikeType.Air_Intercept)
											{
												goto IL_3C7C;
											}
											if (this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_102)).Count<WeaponRec>() == 0)
											{
												flag2 = true;
											}
											if (this.ParentPlatform.m_Mounts.Where(Aircraft_Weaponry.MountFunc).Count<Mount>() == 0)
											{
												flag3 = true;
											}
											if (flag2 && flag3)
											{
												activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
												result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
												return result;
											}
											activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
											result = ActiveUnit._ActiveUnitWeaponState.None;
											return result;
										}
									}
									break;
								case Loadout.LoadoutRole.Intercept_WVR:
								case Loadout.LoadoutRole.AirSuperiority_WVR:
								case Loadout.LoadoutRole.PointDefence_WVR:
									if (this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_103)).Count<WeaponRec>() == 0)
									{
										flag2 = true;
									}
									if (this.ParentPlatform.m_Mounts.Where(Aircraft_Weaponry.MountFunc).Count<Mount>() == 0)
									{
										flag3 = true;
									}
									if (flag2 && flag3)
									{
										activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
										result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
										return result;
									}
									activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
									result = ActiveUnit._ActiveUnitWeaponState.None;
									return result;
								case Loadout.LoadoutRole.AirSuperiority_BVR:
									if (Information.IsNothing(this.ParentPlatform.GetAssignedMission(false)))
									{
										if (this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_97)).Count<WeaponRec>() == 0)
										{
											flag2 = true;
										}
										if (this.ParentPlatform.m_Mounts.Where(Aircraft_Weaponry.MountFunc).Count<Mount>() == 0)
										{
											flag3 = true;
										}
										if (flag2 && flag3)
										{
											activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
											result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
											return result;
										}
										activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
										result = ActiveUnit._ActiveUnitWeaponState.None;
										return result;
									}
									else
									{
										bool flag5 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_98)).Count<WeaponRec>() > 0;
										Mission._MissionClass missionClass2 = this.ParentPlatform.GetAssignedMission(false).MissionClass;
										if (missionClass2 != Mission._MissionClass.Strike)
										{
											if (missionClass2 != Mission._MissionClass.Patrol)
											{
												goto IL_3C7C;
											}
											if (!flag5)
											{
												activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
												result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
												return result;
											}
											activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
											result = ActiveUnit._ActiveUnitWeaponState.None;
											return result;
										}
										else
										{
											if (((Strike)this.ParentPlatform.GetAssignedMission(false)).strikeType != Strike.StrikeType.Air_Intercept)
											{
												goto IL_3C7C;
											}
											if (this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_99)).Count<WeaponRec>() == 0)
											{
												flag2 = true;
											}
											if (this.ParentPlatform.m_Mounts.Where(Aircraft_Weaponry.MountFunc).Count<Mount>() == 0)
											{
												flag3 = true;
											}
											if (flag2 && flag3)
											{
												activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
												result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
												return result;
											}
											activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
											result = ActiveUnit._ActiveUnitWeaponState.None;
											return result;
										}
									}
									break;
								default:
									goto IL_3C7C;
								}
							}
							else
							{
								bool flag6 = false;
								bool flag7 = false;
								if (this.GetAircraft().GetLoadout().loadoutRole == Loadout.LoadoutRole.GunsOnly)
								{
									flag6 = true;
								}
								if (this.GetAircraft().GetLoadout().loadoutRole == Loadout.LoadoutRole.AirSuperiority_WVR || this.GetAircraft().GetLoadout().loadoutRole == Loadout.LoadoutRole.Intercept_WVR || this.GetAircraft().GetLoadout().loadoutRole == Loadout.LoadoutRole.PointDefence_WVR)
								{
									flag7 = true;
								}
								num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
								if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 2001) : null).GetValueOrDefault())
								{
									num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
									if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 2002) : null).GetValueOrDefault())
									{
										num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
										if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 3001) : null).GetValueOrDefault())
										{
											num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
											if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 3002) : null).GetValueOrDefault())
											{
												num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
												if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 3003) : null).GetValueOrDefault())
												{
													num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
													if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5001) : null).GetValueOrDefault())
													{
														num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
														if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5002) : null).GetValueOrDefault())
														{
															num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
															if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5003) : null).GetValueOrDefault())
															{
																num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5005) : null).GetValueOrDefault())
																{
																	num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																	if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5006) : null).GetValueOrDefault())
																	{
																		num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																		if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5011) : null).GetValueOrDefault())
																		{
																			num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																			if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5012) : null).GetValueOrDefault())
																			{
																				num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																				bool flag8;
																				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5021) : null).GetValueOrDefault())
																				{
																					List<WeaponRec> list;
																					if (flag6)
																					{
																						list = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_89)).ToList<WeaponRec>();
																					}
																					else
																					{
																						list = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_90)).ToList<WeaponRec>();
																					}
																					Mount[] mounts = this.ParentPlatform.m_Mounts;
																					for (int i = 0; i < mounts.Length; i++)
																					{
																						Mount mount = mounts[i];
																						List<WeaponRec> list2;
																						if (flag6)
																						{
																							list2 = mount.GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.method_91)).ToList<WeaponRec>();
																						}
																						else
																						{
																							list2 = mount.GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.method_92)).ToList<WeaponRec>();
																						}
																						if (!Information.IsNothing(list2) && list2.Count > 0)
																						{
																							list.AddRange(list2);
																						}
																					}
																					flag8 = true;
																					activeUnitWeaponState = this.method_71(ref list, ref flag8, true, !flag6);
																					result = activeUnitWeaponState;
																					return result;
																				}
																				List<WeaponRec> list3;
																				if (flag6)
																				{
																					list3 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_93)).ToList<WeaponRec>();
																				}
																				else
																				{
																					list3 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_94)).ToList<WeaponRec>();
																				}
																				Mount[] mounts2 = this.ParentPlatform.m_Mounts;
																				for (int j = 0; j < mounts2.Length; j++)
																				{
																					Mount mount2 = mounts2[j];
																					List<WeaponRec> list4;
																					if (flag6)
																					{
																						list4 = mount2.GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.method_95)).ToList<WeaponRec>();
																					}
																					else
																					{
																						list4 = mount2.GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.method_96)).ToList<WeaponRec>();
																					}
																					if (!Information.IsNothing(list4) && list4.Count > 0)
																					{
																						list3.AddRange(list4);
																					}
																				}
																				bool bool_ = false;
																				num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																				int int_;
																				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4001) : null).GetValueOrDefault())
																				{
																					int_ = 25;
																				}
																				else
																				{
																					num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4002) : null).GetValueOrDefault())
																					{
																						int_ = 25;
																						bool_ = true;
																					}
																					else
																					{
																						num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4011) : null).GetValueOrDefault())
																						{
																							int_ = 50;
																						}
																						else
																						{
																							num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4012) : null).GetValueOrDefault())
																							{
																								int_ = 50;
																								bool_ = true;
																							}
																							else
																							{
																								num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4021) : null).GetValueOrDefault())
																								{
																									int_ = 75;
																								}
																								else
																								{
																									int_ = 75;
																									bool_ = true;
																								}
																							}
																						}
																					}
																				}
																				flag8 = true;
																				activeUnitWeaponState = this.method_72(ref list3, ref flag8, int_, bool_, !flag6);
																				result = activeUnitWeaponState;
																				return result;
																			}
																		}
																		if (!flag6)
																		{
																			List<WeaponRec> list5 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_87)).ToList<WeaponRec>();
																			Mount[] mounts3 = this.ParentPlatform.m_Mounts;
																			for (int k = 0; k < mounts3.Length; k++)
																			{
																				List<WeaponRec> list6 = mounts3[k].GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.method_88)).ToList<WeaponRec>();
																				if (!Information.IsNothing(list6) && list6.Count > 0)
																				{
																					list5.AddRange(list6);
																				}
																			}
																			num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																			bool value = (num.HasValue ? new bool?(num.GetValueOrDefault() == 3003) : null).Value;
																			bool flag8 = true;
																			activeUnitWeaponState = this.method_70(ref list5, ref flag8, true, value, true);
																			result = activeUnitWeaponState;
																			return result;
																		}
																		if (this.ParentPlatform.GetWeaponState() != ActiveUnit._ActiveUnitWeaponState.IsWinchester || this.ParentPlatform.m_Scenario.MinuteIsChangingOnThisPulse)
																		{
																			string str = "";
																			if (Operators.CompareString(this.ParentPlatform.Name, this.ParentPlatform.UnitClass, false) != 0)
																			{
																				str = " (" + this.ParentPlatform.UnitClass + ")";
																			}
																			this.ParentPlatform.LogMessage("Shotgun weapon state has been set to Beyond Visual Range (BVR) exhaustion, however aircraft " + this.ParentPlatform.Name + str + " is only armed with guns. The aircraft will therefore return to base immediately. Change the Shotgun weapon state to Guns, or use Winchester weapon state.", LoggedMessage.MessageType.AirOps, 1, false, null);
																		}
																		if (this.ParentPlatform.IsOperating())
																		{
																			activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
																			result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
																			return result;
																		}
																		activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
																		result = ActiveUnit._ActiveUnitWeaponState.None;
																		return result;
																	}
																}
															}
														}
													}
													if (flag6)
													{
														if (this.ParentPlatform.GetWeaponState() != ActiveUnit._ActiveUnitWeaponState.IsWinchester || this.ParentPlatform.m_Scenario.MinuteIsChangingOnThisPulse)
														{
															string str2 = "";
															if (Operators.CompareString(this.ParentPlatform.Name, this.ParentPlatform.UnitClass, false) != 0)
															{
																str2 = " (" + this.ParentPlatform.UnitClass + ")";
															}
															this.ParentPlatform.LogMessage("Shotgun weapon state has been set to one engagement with Beyond Visual Range (BVR) weapons, however aircraft " + this.ParentPlatform.Name + str2 + " is only armed with guns. The aircraft will therefore return to base immediately. Change the Shotgun weapon state to Guns, or use Winchester weapon state.", LoggedMessage.MessageType.AirOps, 1, false, null);
														}
														if (this.ParentPlatform.IsOperating())
														{
															activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
															result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
															return result;
														}
														activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
														result = ActiveUnit._ActiveUnitWeaponState.None;
														return result;
													}
													else
													{
														if (!flag7)
														{
															List<WeaponRec> list7 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_85)).ToList<WeaponRec>();
															Mount[] mounts4 = this.ParentPlatform.m_Mounts;
															for (int l = 0; l < mounts4.Length; l++)
															{
																List<WeaponRec> list8 = mounts4[l].GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.method_86)).ToList<WeaponRec>();
																if (!Information.IsNothing(list8) && list8.Count > 0)
																{
																	list7.AddRange(list8);
																}
															}
															num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
															bool flag9;
															if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5002) : null).Value)
															{
																num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5003) : null).Value)
																{
																	num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																	if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5005) : null).Value)
																	{
																		num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																		flag9 = (num.HasValue ? new bool?(num.GetValueOrDefault() == 5006) : null).Value;
																		goto IL_12A5;
																	}
																}
															}
															flag9 = true;
															IL_12A5:
															bool bool_2 = flag9;
															num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
															bool flag10;
															if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5003) : null).Value)
															{
																num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																flag10 = (num.HasValue ? new bool?(num.GetValueOrDefault() == 5006) : null).Value;
															}
															else
															{
																flag10 = true;
															}
															bool bool_3 = flag10;
															num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
															bool flag11;
															if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5005) : null).Value)
															{
																num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																flag11 = (num.HasValue ? new bool?(num.GetValueOrDefault() == 5006) : null).Value;
															}
															else
															{
																flag11 = true;
															}
															bool bool_4 = flag11;
															bool flag8 = true;
															activeUnitWeaponState = this.method_69(ref list7, ref flag8, true, bool_4, bool_2, bool_3, true);
															result = activeUnitWeaponState;
															return result;
														}
														if (this.ParentPlatform.GetWeaponState() != ActiveUnit._ActiveUnitWeaponState.IsWinchester || this.ParentPlatform.m_Scenario.MinuteIsChangingOnThisPulse)
														{
															string str3 = "";
															if (Operators.CompareString(this.ParentPlatform.Name, this.ParentPlatform.UnitClass, false) != 0)
															{
																str3 = " (" + this.ParentPlatform.UnitClass + ")";
															}
															this.ParentPlatform.LogMessage("Shotgun weapon state has been set to one engagement with Beyond Visual Range (BVR) weapons, however aircraft " + this.ParentPlatform.Name + str3 + " is only armed with Within Visual Range (WVR) weapons. The aircraft will therefore return to base immediately. Change the Shotgun weapon state to Guns or WVR, or use Winchester weapon state.", LoggedMessage.MessageType.AirOps, 1, false, null);
														}
														if (this.ParentPlatform.IsOperating())
														{
															activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
															result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
															return result;
														}
														activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
														result = ActiveUnit._ActiveUnitWeaponState.None;
														return result;
													}
												}
											}
										}
										if (flag6)
										{
											if (this.ParentPlatform.GetWeaponState() != ActiveUnit._ActiveUnitWeaponState.IsWinchester || this.ParentPlatform.m_Scenario.MinuteIsChangingOnThisPulse)
											{
												string str4 = "";
												if (Operators.CompareString(this.ParentPlatform.Name, this.ParentPlatform.UnitClass, false) != 0)
												{
													str4 = " (" + this.ParentPlatform.UnitClass + ")";
												}
												this.ParentPlatform.LogMessage("Shotgun weapon state has been set to Beyond Visual Range (BVR) exhaustion, however aircraft " + this.ParentPlatform.Name + str4 + " is only armed with guns. The aircraft will therefore return to base immediately. Change the Shotgun weapon state to Guns, or use Winchester weapon state.", LoggedMessage.MessageType.AirOps, 1, false, null);
											}
											if (this.ParentPlatform.IsOperating())
											{
												activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
												result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
												return result;
											}
											activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
											result = ActiveUnit._ActiveUnitWeaponState.None;
											return result;
										}
										else
										{
											if (!flag7)
											{
												List<WeaponRec> list9 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_83)).ToList<WeaponRec>();
												Mount[] mounts5 = this.ParentPlatform.m_Mounts;
												for (int m = 0; m < mounts5.Length; m++)
												{
													List<WeaponRec> list10 = mounts5[m].GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.method_84)).ToList<WeaponRec>();
													if (!Information.IsNothing(list10) && list10.Count > 0)
													{
														list9.AddRange(list10);
													}
												}
												num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
												bool flag12;
												if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 3002) : null).Value)
												{
													num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
													flag12 = (num.HasValue ? new bool?(num.GetValueOrDefault() == 3003) : null).Value;
												}
												else
												{
													flag12 = true;
												}
												bool bool_5 = flag12;
												num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
												bool value2 = (num.HasValue ? new bool?(num.GetValueOrDefault() == 3003) : null).Value;
												bool flag8 = true;
												activeUnitWeaponState = this.method_69(ref list9, ref flag8, false, false, bool_5, value2, true);
												result = activeUnitWeaponState;
												return result;
											}
											if (this.ParentPlatform.GetWeaponState() != ActiveUnit._ActiveUnitWeaponState.IsWinchester || this.ParentPlatform.m_Scenario.MinuteIsChangingOnThisPulse)
											{
												string str5 = "";
												if (Operators.CompareString(this.ParentPlatform.Name, this.ParentPlatform.UnitClass, false) != 0)
												{
													str5 = " (" + this.ParentPlatform.UnitClass + ")";
												}
												this.ParentPlatform.LogMessage("Shotgun weapon state has been set to Beyond Visual Range (BVR) exhaustion, however aircraft " + this.ParentPlatform.Name + str5 + " is only armed with Within Visual Range (WVR) weapons. The aircraft will therefore return to base immediately. Change the Shotgun weapon state to Guns or WVR, or use Winchester weapon state.", LoggedMessage.MessageType.AirOps, 1, false, null);
											}
											if (this.ParentPlatform.IsOperating())
											{
												activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
												result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
												return result;
											}
											activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
											result = ActiveUnit._ActiveUnitWeaponState.None;
											return result;
										}
									}
								}
								List<WeaponRec> list11;
								if (flag6)
								{
									list11 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_79)).ToList<WeaponRec>();
								}
								else
								{
									list11 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_80)).ToList<WeaponRec>();
								}
								Mount[] mounts6 = this.ParentPlatform.m_Mounts;
								for (int n = 0; n < mounts6.Length; n++)
								{
									Mount mount3 = mounts6[n];
									List<WeaponRec> list12;
									if (flag6)
									{
										list12 = mount3.GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.method_81)).ToList<WeaponRec>();
									}
									else
									{
										list12 = mount3.GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.method_82)).ToList<WeaponRec>();
									}
									if (!Information.IsNothing(list12) && list12.Count > 0)
									{
										list11.AddRange(list12);
									}
								}
								if (!Information.IsNothing(this.ParentPlatform.GetAssignedMission(false)) && (this.ParentPlatform.GetAssignedMission(false).MissionClass != Mission._MissionClass.Strike || ((Strike)this.ParentPlatform.GetAssignedMission(false)).strikeType != Strike.StrikeType.Air_Intercept) && !flag6)
								{
									num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
									activeUnitWeaponState = this.method_68(ref list11, (num.HasValue ? new bool?(num.GetValueOrDefault() == 2002) : null).Value, !flag6);
									result = activeUnitWeaponState;
									return result;
								}
								activeUnitWeaponState = this.method_68(ref list11, false, false);
								result = activeUnitWeaponState;
								return result;
							}
						}
						else if (loadoutRole <= Loadout.LoadoutRole.BAI_CAS)
						{
							switch (loadoutRole)
							{
							case Loadout.LoadoutRole.NavalOnly_Strike:
								break;
							case Loadout.LoadoutRole.NavalOnly_Standoff:
								goto IL_2A7C;
							case Loadout.LoadoutRole.NavalOnly_SEAD_ARM:
							case Loadout.LoadoutRole.NavalOnly_DEAD:
								goto IL_33B6;
							case Loadout.LoadoutRole.NavalOnly_SEAD_TALD:
								goto IL_3374;
							default:
								if (loadoutRole != Loadout.LoadoutRole.BAI_CAS)
								{
									goto IL_3D23;
								}
								break;
							}
						}
						else if (loadoutRole != Loadout.LoadoutRole.NavalMineLaying)
						{
							if (loadoutRole != Loadout.LoadoutRole.ASW_Patrol)
							{
								goto IL_3D23;
							}
							bool flag13 = true;
							WeaponRec[] weaponRecArray = this.GetAircraft().GetLoadout().WeaponRecArray;
							int num2 = 0;
							while (num2 < weaponRecArray.Length)
							{
								if (weaponRecArray[num2].GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Sonobuoy)
								{
									num2++;
								}
								else
								{
									if (this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_122)).Count<WeaponRec>() == 0)
									{
										activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
										result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
										return result;
									}
									activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
									result = ActiveUnit._ActiveUnitWeaponState.None;
									return result;
								}
							}
							if (flag13)
							{
								if (this.GetAircraft().GetLoadout().WeaponRecArray.Where(Aircraft_Weaponry.WeaponRecFunc).Count<WeaponRec>() == 0)
								{
									activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
									result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
									return result;
								}
								activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
								result = ActiveUnit._ActiveUnitWeaponState.None;
								return result;
							}
							else
							{
								if (this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_122)).Count<WeaponRec>() == 0)
								{
									activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
									result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
									return result;
								}
								activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
								result = ActiveUnit._ActiveUnitWeaponState.None;
								return result;
							}
						}
						else
						{
							if (this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.HasMine)).Count<WeaponRec>() == 0)
							{
								activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
								result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
								return result;
							}
							activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
							result = ActiveUnit._ActiveUnitWeaponState.None;
							return result;
						}
						Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargetsDoctrine;
						byte? b;
						if (this.GetAircraft().m_Scenario.FeatureCompatibility.get_WeaponAGL_ASL(this.GetAircraft().m_Scenario.GetSQLiteConnection()) || !flag)
						{
							gunStrafeGroundTargetsDoctrine = this.ParentPlatform.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
							b = (gunStrafeGroundTargetsDoctrine.HasValue ? new byte?((byte)gunStrafeGroundTargetsDoctrine.GetValueOrDefault()) : null);
							bool value3;
							List<WeaponRec> list13;
							if (value3 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).Value)
							{
								if (this.GetAircraft().GetLoadout().loadoutRole == Loadout.LoadoutRole.LandNaval_Strike)
								{
									list13 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_107)).ToList<WeaponRec>();
								}
								else if (this.GetAircraft().GetLoadout().loadoutRole == Loadout.LoadoutRole.NavalOnly_Strike)
								{
									list13 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_108)).ToList<WeaponRec>();
								}
								else
								{
									list13 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_109)).ToList<WeaponRec>();
								}
								Mount[] mounts7 = this.ParentPlatform.m_Mounts;
								for (int num3 = 0; num3 < mounts7.Length; num3++)
								{
									Mount mount4 = mounts7[num3];
									List<WeaponRec> list14;
									if (this.GetAircraft().GetLoadout().loadoutRole == Loadout.LoadoutRole.LandNaval_Strike)
									{
										list14 = mount4.GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.method_110)).ToList<WeaponRec>();
									}
									else if (this.GetAircraft().GetLoadout().loadoutRole == Loadout.LoadoutRole.NavalOnly_Strike)
									{
										list14 = mount4.GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.method_111)).ToList<WeaponRec>();
									}
									else
									{
										list14 = mount4.GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.method_112)).ToList<WeaponRec>();
									}
									if (!Information.IsNothing(list14) && list14.Count > 0)
									{
										list13.AddRange(list14);
									}
								}
							}
							else if (this.GetAircraft().GetLoadout().loadoutRole == Loadout.LoadoutRole.LandNaval_Strike)
							{
								list13 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_113)).ToList<WeaponRec>();
							}
							else if (this.GetAircraft().GetLoadout().loadoutRole == Loadout.LoadoutRole.NavalOnly_Strike)
							{
								list13 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_114)).ToList<WeaponRec>();
							}
							else
							{
								list13 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_115)).ToList<WeaponRec>();
							}
							num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
							if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 2001) : null).GetValueOrDefault())
							{
								num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
								if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 2002) : null).GetValueOrDefault())
								{
									num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
									if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 3001) : null).GetValueOrDefault())
									{
										num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
										if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 3002) : null).GetValueOrDefault())
										{
											num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
											if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 3003) : null).GetValueOrDefault())
											{
												num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
												if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5001) : null).GetValueOrDefault())
												{
													num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
													if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5002) : null).GetValueOrDefault())
													{
														num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
														if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5003) : null).GetValueOrDefault())
														{
															num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
															bool flag8;
															if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5005) : null).GetValueOrDefault())
															{
																num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5006) : null).GetValueOrDefault())
																{
																	num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																	if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5011) : null).GetValueOrDefault())
																	{
																		num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																		if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5012) : null).GetValueOrDefault())
																		{
																			num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																			if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5021) : null).GetValueOrDefault())
																			{
																				flag8 = false;
																				activeUnitWeaponState = this.method_71(ref list13, ref flag8, true, !value3);
																				result = activeUnitWeaponState;
																				return result;
																			}
																			bool bool_6 = false;
																			num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																			int int_2;
																			if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4001) : null).GetValueOrDefault())
																			{
																				int_2 = 25;
																			}
																			else
																			{
																				num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4002) : null).GetValueOrDefault())
																				{
																					int_2 = 25;
																					bool_6 = true;
																				}
																				else
																				{
																					num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4011) : null).GetValueOrDefault())
																					{
																						int_2 = 50;
																					}
																					else
																					{
																						num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4012) : null).GetValueOrDefault())
																						{
																							int_2 = 50;
																							bool_6 = true;
																						}
																						else
																						{
																							num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4021) : null).GetValueOrDefault())
																							{
																								int_2 = 75;
																							}
																							else
																							{
																								int_2 = 75;
																								bool_6 = true;
																							}
																						}
																					}
																				}
																			}
																			flag8 = false;
																			activeUnitWeaponState = this.method_72(ref list13, ref flag8, int_2, bool_6, !value3);
																			result = activeUnitWeaponState;
																			return result;
																		}
																	}
																	flag8 = false;
																	activeUnitWeaponState = this.method_70(ref list13, ref flag8, true, false, !value3);
																	result = activeUnitWeaponState;
																	return result;
																}
															}
															flag8 = false;
															activeUnitWeaponState = this.method_69(ref list13, ref flag8, true, true, false, false, value3);
															result = activeUnitWeaponState;
															return result;
														}
													}
												}
												if (this.ParentPlatform.GetWeaponState() != ActiveUnit._ActiveUnitWeaponState.IsWinchester || this.ParentPlatform.m_Scenario.MinuteIsChangingOnThisPulse)
												{
													string str6 = "";
													if (Operators.CompareString(this.ParentPlatform.Name, this.ParentPlatform.UnitClass, false) != 0)
													{
														str6 = " (" + this.ParentPlatform.UnitClass + ")";
													}
													this.ParentPlatform.LogMessage("Shotgun weapon state has been set to one engagement with Stand-Off weapons, however aircraft " + this.ParentPlatform.Name + str6 + " is only armed with short-range weapons. The aircraft will therefore return to base immediately. Change the Shotgun weapon state to Short-Range weapons or Guns, or use Winchester weapon state.", LoggedMessage.MessageType.AirOps, 1, false, null);
												}
												if (this.ParentPlatform.IsOperating())
												{
													activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
													result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
													return result;
												}
												activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
												result = ActiveUnit._ActiveUnitWeaponState.None;
												return result;
											}
										}
									}
									if (this.ParentPlatform.GetWeaponState() != ActiveUnit._ActiveUnitWeaponState.IsWinchester || this.ParentPlatform.m_Scenario.MinuteIsChangingOnThisPulse)
									{
										string str7 = "";
										if (Operators.CompareString(this.ParentPlatform.Name, this.ParentPlatform.UnitClass, false) != 0)
										{
											str7 = " (" + this.ParentPlatform.UnitClass + ")";
										}
										this.ParentPlatform.LogMessage("Shotgun weapon state has been set to one engagement with Stand-Off weapons, however aircraft " + this.ParentPlatform.Name + str7 + " is only armed with short-range weapons. The aircraft will therefore return to base immediately. Change the Shotgun weapon state to Short-Range weapons or Guns, or use Winchester weapon state.", LoggedMessage.MessageType.AirOps, 1, false, null);
									}
									if (this.ParentPlatform.IsOperating())
									{
										activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
										result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
										return result;
									}
									activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
									result = ActiveUnit._ActiveUnitWeaponState.None;
									return result;
								}
							}
							activeUnitWeaponState = this.method_68(ref list13, false, !value3);
							result = activeUnitWeaponState;
							return result;
						}
						Loadout.LoadoutRole loadoutRole2 = this.GetAircraft().GetLoadout().loadoutRole;
						if (loadoutRole2 <= Loadout.LoadoutRole.LandOnly_Strike)
						{
							if (loadoutRole2 != Loadout.LoadoutRole.LandNaval_Strike)
							{
								if (loadoutRole2 != Loadout.LoadoutRole.LandOnly_Strike)
								{
									goto IL_3C7C;
								}
							}
							else
							{
								gunStrafeGroundTargetsDoctrine = this.ParentPlatform.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
								b = (gunStrafeGroundTargetsDoctrine.HasValue ? new byte?((byte)gunStrafeGroundTargetsDoctrine.GetValueOrDefault()) : null);
								int num4;
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									num4 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_116)).Count<WeaponRec>();
								}
								else
								{
									num4 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_117)).Count<WeaponRec>();
								}
								if (num4 == 0)
								{
									flag2 = true;
								}
								gunStrafeGroundTargetsDoctrine = this.ParentPlatform.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
								b = (gunStrafeGroundTargetsDoctrine.HasValue ? new byte?((byte)gunStrafeGroundTargetsDoctrine.GetValueOrDefault()) : null);
								int num5 = 0;
								if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									num5 = this.ParentPlatform.m_Mounts.Where(Aircraft_Weaponry.MountFunc).Count<Mount>();
								}
								if (num5 == 0)
								{
									flag3 = true;
								}
								if (flag2 && flag3)
								{
									activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
									result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
									return result;
								}
								activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
								result = ActiveUnit._ActiveUnitWeaponState.None;
								return result;
							}
						}
						else if (loadoutRole2 != Loadout.LoadoutRole.NavalOnly_Strike)
						{
							if (loadoutRole2 != Loadout.LoadoutRole.BAI_CAS)
							{
								goto IL_3C7C;
							}
						}
						else
						{
							gunStrafeGroundTargetsDoctrine = this.ParentPlatform.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
							b = (gunStrafeGroundTargetsDoctrine.HasValue ? new byte?((byte)gunStrafeGroundTargetsDoctrine.GetValueOrDefault()) : null);
							int num6;
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num6 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_120)).Count<WeaponRec>();
							}
							else
							{
								num6 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_121)).Count<WeaponRec>();
							}
							if (num6 == 0)
							{
								flag2 = true;
							}
							gunStrafeGroundTargetsDoctrine = this.ParentPlatform.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
							b = (gunStrafeGroundTargetsDoctrine.HasValue ? new byte?((byte)gunStrafeGroundTargetsDoctrine.GetValueOrDefault()) : null);
							int num7 = 0;
							if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num7 = this.ParentPlatform.m_Mounts.Where(Aircraft_Weaponry.MountFunc).Count<Mount>();
							}
							if (num7 == 0)
							{
								flag3 = true;
							}
							if (flag2 && flag3)
							{
								activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
								result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
								return result;
							}
							activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
							result = ActiveUnit._ActiveUnitWeaponState.None;
							return result;
						}
						gunStrafeGroundTargetsDoctrine = this.ParentPlatform.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
						b = (gunStrafeGroundTargetsDoctrine.HasValue ? new byte?((byte)gunStrafeGroundTargetsDoctrine.GetValueOrDefault()) : null);
						int num8;
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							num8 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_118)).Count<WeaponRec>();
						}
						else
						{
							num8 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_119)).Count<WeaponRec>();
						}
						if (num8 == 0)
						{
							flag2 = true;
						}
						gunStrafeGroundTargetsDoctrine = this.ParentPlatform.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
						b = (gunStrafeGroundTargetsDoctrine.HasValue ? new byte?((byte)gunStrafeGroundTargetsDoctrine.GetValueOrDefault()) : null);
						int num9 = 0;
						if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							num9 = this.ParentPlatform.m_Mounts.Where(Aircraft_Weaponry.MountFunc).Count<Mount>();
						}
						if (num9 == 0)
						{
							flag3 = true;
						}
						if (flag2 && flag3)
						{
							activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							return result;
						}
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
						result = ActiveUnit._ActiveUnitWeaponState.None;
						return result;
						IL_2A7C:
						if (this.GetAircraft().m_Scenario.FeatureCompatibility.get_WeaponAGL_ASL(this.GetAircraft().m_Scenario.GetSQLiteConnection()) || !flag)
						{
							List<WeaponRec> list15 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_104)).ToList<WeaponRec>();
							num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
							if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 2001) : null).GetValueOrDefault())
							{
								num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
								if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 2002) : null).GetValueOrDefault())
								{
									num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
									bool flag8;
									if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 3001) : null).GetValueOrDefault())
									{
										num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
										if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 3002) : null).GetValueOrDefault())
										{
											num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
											if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 3003) : null).GetValueOrDefault())
											{
												num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
												if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5001) : null).GetValueOrDefault())
												{
													num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
													if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5002) : null).GetValueOrDefault())
													{
														num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
														if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5003) : null).GetValueOrDefault())
														{
															num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
															if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5005) : null).GetValueOrDefault())
															{
																num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5006) : null).GetValueOrDefault())
																{
																	num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																	if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5011) : null).GetValueOrDefault())
																	{
																		num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																		if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5012) : null).GetValueOrDefault())
																		{
																			num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																			if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5021) : null).GetValueOrDefault())
																			{
																				flag8 = false;
																				activeUnitWeaponState = this.method_71(ref list15, ref flag8, true, true);
																				result = activeUnitWeaponState;
																				return result;
																			}
																			bool bool_7 = false;
																			num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																			int int_3;
																			if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4001) : null).GetValueOrDefault())
																			{
																				int_3 = 25;
																			}
																			else
																			{
																				num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4002) : null).GetValueOrDefault())
																				{
																					int_3 = 25;
																					bool_7 = true;
																				}
																				else
																				{
																					num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4011) : null).GetValueOrDefault())
																					{
																						int_3 = 50;
																					}
																					else
																					{
																						num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4012) : null).GetValueOrDefault())
																						{
																							int_3 = 50;
																							bool_7 = true;
																						}
																						else
																						{
																							num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4021) : null).GetValueOrDefault())
																							{
																								int_3 = 75;
																							}
																							else
																							{
																								int_3 = 75;
																								bool_7 = true;
																							}
																						}
																					}
																				}
																			}
																			flag8 = false;
																			activeUnitWeaponState = this.method_72(ref list15, ref flag8, int_3, bool_7, true);
																			result = activeUnitWeaponState;
																			return result;
																		}
																	}
																	flag8 = false;
																	activeUnitWeaponState = this.method_70(ref list15, ref flag8, true, false, true);
																	result = activeUnitWeaponState;
																	return result;
																}
															}
															flag8 = false;
															activeUnitWeaponState = this.method_69(ref list15, ref flag8, true, true, false, false, true);
															result = activeUnitWeaponState;
															return result;
														}
													}
												}
												flag8 = false;
												activeUnitWeaponState = this.method_69(ref list15, ref flag8, true, false, true, false, true);
												result = activeUnitWeaponState;
												return result;
											}
										}
									}
									flag8 = false;
									activeUnitWeaponState = this.method_69(ref list15, ref flag8, false, false, false, false, true);
									result = activeUnitWeaponState;
									return result;
								}
							}
							activeUnitWeaponState = this.method_68(ref list15, false, true);
							result = activeUnitWeaponState;
							return result;
						}
						gunStrafeGroundTargetsDoctrine = this.ParentPlatform.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
						b = (gunStrafeGroundTargetsDoctrine.HasValue ? new byte?((byte)gunStrafeGroundTargetsDoctrine.GetValueOrDefault()) : null);
						int num10;
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							num10 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_105)).Count<WeaponRec>();
						}
						else
						{
							num10 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_106)).Count<WeaponRec>();
						}
						if (num10 == 0)
						{
							flag2 = true;
						}
						gunStrafeGroundTargetsDoctrine = this.ParentPlatform.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
						b = (gunStrafeGroundTargetsDoctrine.HasValue ? new byte?((byte)gunStrafeGroundTargetsDoctrine.GetValueOrDefault()) : null);
						int num11 = 0;
						if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							num11 = this.ParentPlatform.m_Mounts.Where(Aircraft_Weaponry.MountFunc).Count<Mount>();
						}
						if (num11 == 0)
						{
							flag3 = true;
						}
						if (flag2 && flag3)
						{
							activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							return result;
						}
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
						result = ActiveUnit._ActiveUnitWeaponState.None;
						return result;
						IL_3374:
						if (this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.HasDecoy)).Count<WeaponRec>() == 0)
						{
							activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							return result;
						}
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
						result = ActiveUnit._ActiveUnitWeaponState.None;
						return result;
						IL_33B6:
						if (this.GetAircraft().m_Scenario.FeatureCompatibility.get_WeaponAGL_ASL(this.GetAircraft().m_Scenario.GetSQLiteConnection()) || !flag)
						{
							Loadout.LoadoutRole loadoutRole3 = this.GetAircraft().GetLoadout().loadoutRole;
							List<WeaponRec> list16 = null;
							if (loadoutRole3 <= Loadout.LoadoutRole.LandOnly_SEAD_ARM)
							{
								if (loadoutRole3 == Loadout.LoadoutRole.LandNaval_SEAD_ARM || loadoutRole3 == Loadout.LoadoutRole.LandNaval_DEAD)
								{
									list16 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_123)).ToList<WeaponRec>();
									goto IL_34CF;
								}
								if (loadoutRole3 != Loadout.LoadoutRole.LandOnly_SEAD_ARM)
								{
									goto IL_34CF;
								}
							}
							else if (loadoutRole3 != Loadout.LoadoutRole.LandOnly_DEAD)
							{
								if (loadoutRole3 == Loadout.LoadoutRole.NavalOnly_SEAD_ARM || loadoutRole3 == Loadout.LoadoutRole.NavalOnly_DEAD)
								{
									list16 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_125)).ToList<WeaponRec>();
									goto IL_34CF;
								}
								goto IL_34CF;
							}
							list16 = this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_124)).ToList<WeaponRec>();
							IL_34CF:
							num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
							if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 2001) : null).GetValueOrDefault())
							{
								num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
								if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 2002) : null).GetValueOrDefault())
								{
									num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
									bool flag8;
									if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 3001) : null).GetValueOrDefault())
									{
										num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
										if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 3002) : null).GetValueOrDefault())
										{
											num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
											if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 3003) : null).GetValueOrDefault())
											{
												num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
												if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5001) : null).GetValueOrDefault())
												{
													num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
													if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5002) : null).GetValueOrDefault())
													{
														num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
														if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5003) : null).GetValueOrDefault())
														{
															num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
															if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5005) : null).GetValueOrDefault())
															{
																num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5006) : null).GetValueOrDefault())
																{
																	num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																	if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5011) : null).GetValueOrDefault())
																	{
																		num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																		if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == 5012) : null).GetValueOrDefault())
																		{
																			num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																			if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 5021) : null).GetValueOrDefault())
																			{
																				flag8 = false;
																				activeUnitWeaponState = this.method_71(ref list16, ref flag8, true, true);
																				result = activeUnitWeaponState;
																				return result;
																			}
																			bool bool_8 = false;
																			num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																			int int_4;
																			if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4001) : null).GetValueOrDefault())
																			{
																				int_4 = 25;
																			}
																			else
																			{
																				num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4002) : null).GetValueOrDefault())
																				{
																					int_4 = 25;
																					bool_8 = true;
																				}
																				else
																				{
																					num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4011) : null).GetValueOrDefault())
																					{
																						int_4 = 50;
																					}
																					else
																					{
																						num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4012) : null).GetValueOrDefault())
																						{
																							int_4 = 50;
																							bool_8 = true;
																						}
																						else
																						{
																							num = (winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null);
																							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4021) : null).GetValueOrDefault())
																							{
																								int_4 = 75;
																							}
																							else
																							{
																								int_4 = 75;
																								bool_8 = true;
																							}
																						}
																					}
																				}
																			}
																			flag8 = false;
																			activeUnitWeaponState = this.method_72(ref list16, ref flag8, int_4, bool_8, true);
																			result = activeUnitWeaponState;
																			return result;
																		}
																	}
																	flag8 = false;
																	activeUnitWeaponState = this.method_70(ref list16, ref flag8, true, false, true);
																	result = activeUnitWeaponState;
																	return result;
																}
															}
															flag8 = false;
															activeUnitWeaponState = this.method_69(ref list16, ref flag8, true, true, false, false, true);
															result = activeUnitWeaponState;
															return result;
														}
													}
												}
												flag8 = false;
												activeUnitWeaponState = this.method_69(ref list16, ref flag8, true, false, true, false, true);
												result = activeUnitWeaponState;
												return result;
											}
										}
									}
									flag8 = false;
									activeUnitWeaponState = this.method_69(ref list16, ref flag8, false, false, false, false, true);
									result = activeUnitWeaponState;
									return result;
								}
							}
							activeUnitWeaponState = this.method_68(ref list16, false, true);
							result = activeUnitWeaponState;
							return result;
						}
						Loadout.LoadoutRole loadoutRole4 = this.GetAircraft().GetLoadout().loadoutRole;
						if (loadoutRole4 <= Loadout.LoadoutRole.LandOnly_SEAD_ARM)
						{
							if (loadoutRole4 != Loadout.LoadoutRole.LandNaval_SEAD_ARM && loadoutRole4 != Loadout.LoadoutRole.LandNaval_DEAD)
							{
								if (loadoutRole4 != Loadout.LoadoutRole.LandOnly_SEAD_ARM)
								{
									goto IL_3C7C;
								}
							}
							else
							{
								if (this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_126)).Count<WeaponRec>() == 0)
								{
									activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
									result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
									return result;
								}
								activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
								result = ActiveUnit._ActiveUnitWeaponState.None;
								return result;
							}
						}
						else if (loadoutRole4 != Loadout.LoadoutRole.LandOnly_DEAD)
						{
							if (loadoutRole4 != Loadout.LoadoutRole.NavalOnly_SEAD_ARM && loadoutRole4 != Loadout.LoadoutRole.NavalOnly_DEAD)
							{
								goto IL_3C7C;
							}
							if (this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_128)).Count<WeaponRec>() == 0)
							{
								activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
								result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
								return result;
							}
							activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
							result = ActiveUnit._ActiveUnitWeaponState.None;
							return result;
						}
						if (this.GetAircraft().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_127)).Count<WeaponRec>() == 0)
						{
							activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							return result;
						}
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
						result = ActiveUnit._ActiveUnitWeaponState.None;
						return result;
						IL_3C7C:
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
						result = ActiveUnit._ActiveUnitWeaponState.None;
						return result;
						IL_3D23:
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200295", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						activeUnitWeaponState = ActiveUnit._ActiveUnitWeaponState.None;
						ProjectData.ClearProjectError();
					}
				}
				result = activeUnitWeaponState;
				return result;
			}
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x0020ADDC File Offset: 0x00208FDC
		public void DropSonobuoys(float elapsedTime, SonarEnvironment._SonobuoyDepthSetting? DepthSetting = null, bool? DropActive = null)
		{
			List<WeaponRec> list = new List<WeaponRec>();
			checked
			{
				try
				{
					Mount[] mounts = this.GetAircraft().m_Mounts;
					for (int i = 0; i < mounts.Length; i++)
					{
						Mount mount = mounts[i];
						foreach (WeaponRec weaponRec in mount.GetWeaponRecCollection())
						{
							weaponRec.myMount = mount;
							if (weaponRec.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Sonobuoy && weaponRec.GetCurrentLoad() != 0 && mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && mount.GetTimeToFire() == 0f && weaponRec.TimeToFire == 0f)
							{
								list.Add(weaponRec);
							}
						}
					}
					if (!Information.IsNothing(this.GetAircraft().GetLoadout()))
					{
						WeaponRec[] weaponRecArray = this.GetAircraft().GetLoadout().WeaponRecArray;
						for (int j = 0; j < weaponRecArray.Length; j++)
						{
							WeaponRec weaponRec = weaponRecArray[j];
							weaponRec.myMount = null;
							if (weaponRec.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Sonobuoy && weaponRec.GetCurrentLoad() != 0 && weaponRec.TimeToFire <= 0f)
							{
								list.Add(weaponRec);
							}
						}
					}
					if (list.Count != 0)
					{
						if (DropActive.HasValue)
						{
							List<WeaponRec> list2 = new List<WeaponRec>();
							if (DropActive.Value)
							{
								using (List<WeaponRec>.Enumerator enumerator2 = list.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										WeaponRec current = enumerator2.Current;
										if (!current.GetWeapon(this.ParentPlatform.m_Scenario).GetNoneMCMSensors()[0].IsActiveModeOnly())
										{
											list2.Add(current);
										}
									}
									goto IL_228;
								}
							}
							foreach (WeaponRec current2 in list)
							{
								if (current2.GetWeapon(this.ParentPlatform.m_Scenario).GetNoneMCMSensors()[0].IsActiveModeOnly())
								{
									list2.Add(current2);
								}
							}
							IL_228:
							foreach (WeaponRec current3 in list2)
							{
								list.Remove(current3);
							}
						}
						if (list.Count != 0)
						{
							WeaponRec weaponRec2;
							if (list.Count == 1)
							{
								weaponRec2 = list[0];
							}
							else
							{
								weaponRec2 = list[GameGeneral.GetRandom().Next(0, list.Count)];
							}
							if (!DepthSetting.HasValue)
							{
								if (GameGeneral.GetRandom().Next(0, 1000) > 500)
								{
									DepthSetting = new SonarEnvironment._SonobuoyDepthSetting?(SonarEnvironment._SonobuoyDepthSetting.Shallow);
								}
								else
								{
									DepthSetting = new SonarEnvironment._SonobuoyDepthSetting?(SonarEnvironment._SonobuoyDepthSetting.Deep);
								}
							}
							Contact theTarget = null;
							int num = 0;
							float initialHeading = 0f;
							Mount firingMount = null;
							SonarEnvironment._SonobuoyDepthSetting value = DepthSetting.Value;
							WeaponSalvo weaponSalvo = null;
							base.FireWeapons(elapsedTime, ref weaponRec2, theTarget, false, ref num, 0, initialHeading, ActiveUnit.Throttle.Flank, firingMount, value, 0L, ref weaponSalvo);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100476", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x0020B1BC File Offset: 0x002093BC
		[CompilerGenerated]
		private double method_74(Contact contact_0)
		{
			return this.ParentPlatform.GetApproxAngularDistanceInDegrees(contact_0);
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x0020B1BC File Offset: 0x002093BC
		[CompilerGenerated]
		private double method_75(Contact contact_0)
		{
			return this.ParentPlatform.GetApproxAngularDistanceInDegrees(contact_0);
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x0020B1BC File Offset: 0x002093BC
		[CompilerGenerated]
		private double method_76(Contact contact_0)
		{
			return this.ParentPlatform.GetApproxAngularDistanceInDegrees(contact_0);
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x0020B1BC File Offset: 0x002093BC
		[CompilerGenerated]
		private double method_77(Contact contact_0)
		{
			return this.ParentPlatform.GetApproxAngularDistanceInDegrees(contact_0);
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x0020B1BC File Offset: 0x002093BC
		[CompilerGenerated]
		private double method_78(Contact contact_0)
		{
			return this.ParentPlatform.GetApproxAngularDistanceInDegrees(contact_0);
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x00025776 File Offset: 0x00023976
		[CompilerGenerated]
		private bool method_79(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Gun;
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x00025795 File Offset: 0x00023995
		[CompilerGenerated]
		private bool method_80(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x00025776 File Offset: 0x00023976
		[CompilerGenerated]
		private bool method_81(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Gun;
		}

		// Token: 0x06005034 RID: 20532 RVA: 0x00025795 File Offset: 0x00023995
		[CompilerGenerated]
		private bool method_82(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();
		}

		// Token: 0x06005035 RID: 20533 RVA: 0x00025795 File Offset: 0x00023995
		[CompilerGenerated]
		private bool method_83(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();
		}

		// Token: 0x06005036 RID: 20534 RVA: 0x00025795 File Offset: 0x00023995
		[CompilerGenerated]
		private bool method_84(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x00025795 File Offset: 0x00023995
		[CompilerGenerated]
		private bool method_85(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x00025795 File Offset: 0x00023995
		[CompilerGenerated]
		private bool method_86(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x00025795 File Offset: 0x00023995
		[CompilerGenerated]
		private bool method_87(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x00025795 File Offset: 0x00023995
		[CompilerGenerated]
		private bool method_88(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();
		}

		// Token: 0x0600503B RID: 20539 RVA: 0x00025776 File Offset: 0x00023976
		[CompilerGenerated]
		private bool method_89(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Gun;
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x00025795 File Offset: 0x00023995
		[CompilerGenerated]
		private bool method_90(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x00025776 File Offset: 0x00023976
		[CompilerGenerated]
		private bool method_91(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Gun;
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x00025795 File Offset: 0x00023995
		[CompilerGenerated]
		private bool method_92(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();
		}

		// Token: 0x0600503F RID: 20543 RVA: 0x00025776 File Offset: 0x00023976
		[CompilerGenerated]
		private bool method_93(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Gun;
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x00025795 File Offset: 0x00023995
		[CompilerGenerated]
		private bool method_94(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();
		}

		// Token: 0x06005041 RID: 20545 RVA: 0x00025776 File Offset: 0x00023976
		[CompilerGenerated]
		private bool method_95(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Gun;
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x00025795 File Offset: 0x00023995
		[CompilerGenerated]
		private bool method_96(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();
		}

		// Token: 0x06005043 RID: 20547 RVA: 0x000257AD File Offset: 0x000239AD
		[CompilerGenerated]
		private bool method_97(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x06005044 RID: 20548 RVA: 0x000257D3 File Offset: 0x000239D3
		[CompilerGenerated]
		private bool method_98(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).IsGuidedWeapon_RV_HGV() && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).IsLongRangeAAWWeapon() && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x06005045 RID: 20549 RVA: 0x000257AD File Offset: 0x000239AD
		[CompilerGenerated]
		private bool method_99(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x06005046 RID: 20550 RVA: 0x000257AD File Offset: 0x000239AD
		[CompilerGenerated]
		private bool method_100(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x00025811 File Offset: 0x00023A11
		[CompilerGenerated]
		private bool method_101(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).IsGuidedWeapon_RV_HGV() && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x000257AD File Offset: 0x000239AD
		[CompilerGenerated]
		private bool method_102(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x000257AD File Offset: 0x000239AD
		[CompilerGenerated]
		private bool method_103(WeaponRec weaponRec_)
		{
			return weaponRec_.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() && weaponRec_.GetCurrentLoad() > 0;
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x00025837 File Offset: 0x00023A37
		[CompilerGenerated]
		private bool method_104(WeaponRec weaponRec_)
		{
			return weaponRec_.GetWeapon(this.ParentPlatform.m_Scenario).method_176();
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x0020B1D8 File Offset: 0x002093D8
		[CompilerGenerated]
		private bool method_105(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).method_176() && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x0002584F File Offset: 0x00023A4F
		[CompilerGenerated]
		private bool method_106(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).method_176() && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x00025875 File Offset: 0x00023A75
		[CompilerGenerated]
		private bool method_107(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsShipOrRadar() || weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsLandFacility();
		}

		// Token: 0x0600504E RID: 20558 RVA: 0x000258A8 File Offset: 0x00023AA8
		[CompilerGenerated]
		private bool method_108(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsShipOrRadar();
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x000258C0 File Offset: 0x00023AC0
		[CompilerGenerated]
		private bool method_109(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsLandFacility();
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x00025875 File Offset: 0x00023A75
		[CompilerGenerated]
		private bool method_110(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsShipOrRadar() || weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsLandFacility();
		}

		// Token: 0x06005051 RID: 20561 RVA: 0x000258A8 File Offset: 0x00023AA8
		[CompilerGenerated]
		private bool method_111(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsShipOrRadar();
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x000258C0 File Offset: 0x00023AC0
		[CompilerGenerated]
		private bool method_112(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsLandFacility();
		}

		// Token: 0x06005053 RID: 20563 RVA: 0x0020B228 File Offset: 0x00209428
		[CompilerGenerated]
		private bool method_113(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsShipOrRadar() || weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsLandFacility()) && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun;
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x000258D8 File Offset: 0x00023AD8
		[CompilerGenerated]
		private bool method_114(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsShipOrRadar() && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun;
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x00025915 File Offset: 0x00023B15
		[CompilerGenerated]
		private bool method_115(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsLandFacility() && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun;
		}

		// Token: 0x06005056 RID: 20566 RVA: 0x0020B288 File Offset: 0x00209488
		[CompilerGenerated]
		private bool method_116(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsShipOrRadar() || weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsLandFacility()) && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x06005057 RID: 20567 RVA: 0x00025952 File Offset: 0x00023B52
		[CompilerGenerated]
		private bool method_117(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsShipOrRadar() || weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsLandFacility()) && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x0020B2F0 File Offset: 0x002094F0
		[CompilerGenerated]
		private bool method_118(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsLandFacility() && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x00025990 File Offset: 0x00023B90
		[CompilerGenerated]
		private bool method_119(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsLandFacility() && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x0020B340 File Offset: 0x00209540
		[CompilerGenerated]
		private bool method_120(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsShipOrRadar() && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x000259B6 File Offset: 0x00023BB6
		[CompilerGenerated]
		private bool method_121(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsShipOrRadar() && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x000259DC File Offset: 0x00023BDC
		[CompilerGenerated]
		private bool method_122(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsSubsurface() && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x0020B390 File Offset: 0x00209590
		[CompilerGenerated]
		private bool method_123(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsShipOrRadar() || weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsLandFacility() || weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsRadar()) && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun;
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x0020B408 File Offset: 0x00209608
		[CompilerGenerated]
		private bool method_124(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsLandFacility() || weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsRadar()) && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun;
		}

		// Token: 0x0600505F RID: 20575 RVA: 0x0020B468 File Offset: 0x00209668
		[CompilerGenerated]
		private bool method_125(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsShipOrRadar() || weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsRadar()) && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun;
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x0020B4C8 File Offset: 0x002096C8
		[CompilerGenerated]
		private bool method_126(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsShipOrRadar() || weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsLandFacility() || weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsRadar()) && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x0020B548 File Offset: 0x00209748
		[CompilerGenerated]
		private bool method_127(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsLandFacility() || weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsRadar()) && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x06005062 RID: 20578 RVA: 0x0020B5B0 File Offset: 0x002097B0
		[CompilerGenerated]
		private bool method_128(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsShipOrRadar() || weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).TargetIsRadar()) && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() != Weapon._WeaponType.Gun && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x06005063 RID: 20579 RVA: 0x00025A02 File Offset: 0x00023C02
		[CompilerGenerated]
		private bool HasDecoy(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetCurrentLoad() > 0 && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).IsDecoy();
		}

		// Token: 0x06005064 RID: 20580 RVA: 0x00025A26 File Offset: 0x00023C26
		[CompilerGenerated]
		private bool HasMine(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetCurrentLoad() > 0 && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).IsMine();
		}

		// Token: 0x040025CA RID: 9674
		public static Func<Mount, bool> MountFunc = (Mount mount_0) => mount_0.HasGun() && !mount_0.IsEmpty();

		// Token: 0x040025CB RID: 9675
		public static Func<WeaponRec, bool> WeaponRecFunc = (WeaponRec weaponRec_0) => weaponRec_0.GetCurrentLoad() > 0;

		// Token: 0x040025CC RID: 9676
		private Aircraft aircraft_0;
	}
}
