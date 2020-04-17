using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns3
{
	// 武器的传感器
	public sealed class Weapon_Sensory : ActiveUnit_Sensory
	{
		// 取所在的武器
		private Weapon GetParentWeapon()
		{
			if (Information.IsNothing(this.ParentWeapon))
			{
				this.ParentWeapon = (Weapon)this.ParentPlatform;
			}
			return this.ParentWeapon;
		}

		// 保存
		public override void Save(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Weapon_Sensory");
				xmlWriter_0.WriteElementString("ObE", this.IsObeysEMCON().ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100988", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// 调度探测交互
		public override void ScheduleDetectionInteraction(Sensor[] sensor_0, ActiveUnit[] activeUnit_1, float elapsedTime_)
		{
			if (!this.GetParentWeapon().IsGuidedWeapon_RV_HGV() || !this.GetParentWeapon().GetWeaponNavigator().HasPlottedCourse())
			{
				base.ScheduleDetectionInteraction(sensor_0, activeUnit_1, elapsedTime_);
			}
		}

		// 载入
		public static Weapon_Sensory Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_1, ref ActiveUnit activeUnit_1)
		{
			Weapon_Sensory result = null;
			try
			{
				Weapon_Sensory weapon_Sensory = new Weapon_Sensory(ref activeUnit_1);
				weapon_Sensory.ParentPlatform = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ObeysEMCON", false) == 0 || Operators.CompareString(name, "ObE", false) == 0)
						{
							weapon_Sensory.SetIsObeysEMCON(Conversions.ToBoolean(xmlNode.InnerText));
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
				result = weapon_Sensory;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100990", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Weapon_Sensory(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006181 RID: 24961 RVA: 0x0002B203 File Offset: 0x00029403
		public Weapon_Sensory(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
			this.SetIsObeysEMCON(false);
		}

		// Token: 0x06006182 RID: 24962 RVA: 0x002F1A4C File Offset: 0x002EFC4C
		protected override void vmethod_9(Contact theTarget, Unit unit_0, List<Sensor> list_2, float float_5, ActiveUnit_Sensory.Enum8 enum8_0)
		{
			try
			{
				if (!((Weapon_CommStuff)this.ParentPlatform.GetCommStuff()).CanCommToDataLinkParent())
				{
					Contact contact = null;
					Contact[] targets = this.ParentPlatform.GetAI().GetTargets();
					Weapon weapon = (Weapon)this.ParentPlatform;
					ObservableDictionary<int, EmissionContainer> emissionContainerObDictionary = theTarget.GetEmissionContainerObDictionary();
					bool flag = false;
					using (List<Sensor>.Enumerator enumerator = list_2.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.IsPreciselyLocatedEnable())
							{
								flag = true;
								break;
							}
						}
					}
					int i = targets.Count<Contact>();
					if (i == 0)
					{
						goto IL_49D;
					}
					while (i >= 0)
					{
						if (targets[i].ActualUnit != unit_0)
						{
							i += -1;
						}
						else
						{
							bool flag2 = true;
							if (flag || targets[i].GetRCTTP() > 0f)
							{
								targets[i].SetIsPreciselyLocatedOnThisPulse(true);
							}
							ActiveUnit_Sensory.smethod_2(ref targets[i], (ActiveUnit)unit_0, false, null);
							ActiveUnit_Sensory.smethod_3(targets[i], emissionContainerObDictionary);
							contact = targets[i];
							if (!flag2)
							{
								contact = new Contact((ActiveUnit)unit_0, 0);
								if (flag)
								{
									contact.SetIsPreciselyLocatedOnThisPulse(true);
								}
								ActiveUnit_Sensory.smethod_2(ref contact, (ActiveUnit)unit_0, true, null);
								if (emissionContainerObDictionary.Count > 0)
								{
									contact.SetEmissionContainerObDictionary(emissionContainerObDictionary);
								}
							}
							foreach (Sensor current in list_2)
							{
								contact.SetRCTT(Math.Max(contact.GetRCTT(), (float)current.GetScanInterval()));
							}
							Contact primaryTarget = this.ParentPlatform.GetAI().GetPrimaryTarget();
							if (!Information.IsNothing(primaryTarget) && !Information.IsNothing(primaryTarget.ActualUnit) && Operators.CompareString(primaryTarget.ActualUnit.GetGuid(), contact.ActualUnit.GetGuid(), false) == 0)
							{
								foreach (Sensor current2 in list_2)
								{
									primaryTarget.SetRCTT(Math.Max(primaryTarget.GetRCTT(), (float)current2.GetScanInterval()));
									if (current2.IsPreciselyLocatedEnable())
									{
										primaryTarget.SetRCTTP(Math.Max(primaryTarget.GetRCTTP(), (float)current2.GetScanInterval()));
									}
								}
							}
							if (list_2.Count != 0)
							{
								foreach (Sensor current3 in list_2)
								{
									if (current3.sensorCapability.HeadingInformation)
									{
										contact.Heading_Known = true;
									}
									if (current3.sensorCapability.SpeedInformation)
									{
										contact.Speed_Known = true;
									}
									if (current3.sensorCapability.AltitudeInformation || (current3.IsSonar() && current3.IsEmmitting()))
									{
										contact.Altitude_Known = true;
									}
								}
							}
							if (!Information.IsNothing(primaryTarget) && (Information.IsNothing(primaryTarget.ActualUnit) || Operators.CompareString(primaryTarget.ActualUnit.GetGuid(), contact.ActualUnit.GetGuid(), false) == 0) && this.ParentPlatform.GetNavigator().HasPlottedCourse())
							{
								this.ParentPlatform.GetNavigator().ClearPlottedCourse();
							}
							if (weapon.weaponTarget.IsRadar)
							{
								if (!weapon.ARM_SpecifiedEmissionIsMandatory)
								{
									this.ParentPlatform.GetAI().TargetingContact(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
									Weapon weapon2 = weapon;
									ObservableDictionary<int, EmissionContainer> emissionContainerObDictionary2 = theTarget.GetEmissionContainerObDictionary();
									Side side = weapon.GetSide(false);
									Random random = GameGeneral.GetRandom();
									if (weapon2.HasARM_SpecifiedEmission(emissionContainerObDictionary2, side, theTarget, false, ref random))
									{
										weapon.ARM_SpecifiedEmissionIsMandatory = true;
									}
									return;
								}
								bool flag3 = false;
								foreach (int current4 in contact.GetEmissionContainerObDictionary().Keys)
								{
									if (current4 == weapon.ARM_SpecifiedEmission.Key)
									{
										flag3 = true;
										weapon.ARM_SpecifiedEmission.Value.elapsedTime = 0f;
										weapon.ARM_SpecifiedEmission.Value.bool_0 = contact.GetEmissionContainerObDictionary()[current4].bool_0;
									}
								}
								if (flag3)
								{
									this.ParentPlatform.GetAI().TargetingContact(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
									goto IL_49D;
								}
								goto IL_49D;
							}
							else
							{
								if (((Weapon)this.ParentPlatform).IsSuitableForTarget(this.ParentPlatform.m_Scenario, ref contact))
								{
									this.ParentPlatform.GetAI().TargetingContact(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
									goto IL_49D;
								}
								goto IL_49D;
							}
						}
					}
				}
				base.vmethod_9(theTarget, unit_0, list_2, float_5, ActiveUnit_Sensory.Enum8.const_0);
				IL_49D:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100989", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006183 RID: 24963 RVA: 0x002F1FCC File Offset: 0x002F01CC
		public override void ScheduleDetectInterationOnGrid()
		{
			bool flag = false;
			ActiveUnit activeUnit = null;
			if (this.ParentPlatform.IsWeapon)
			{
				activeUnit = ((Weapon)this.ParentPlatform).GetDataLinkParent();
				if (!Information.IsNothing(activeUnit) && !activeUnit.GetCommStuff().IsNotOutOfComms())
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (!Information.IsNothing(this.concurrentBag_0) && this.concurrentBag_0.Count > 0)
				{
					if (Information.IsNothing(activeUnit.GetSensory().concurrentBag_0))
					{
						activeUnit.GetSensory().concurrentBag_0 = new ConcurrentBag<Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum8>>();
					}
					foreach (Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum8> current in this.concurrentBag_0)
					{
						if (!Information.IsNothing(current))
						{
							activeUnit.GetSensory().concurrentBag_0.Add(current);
						}
					}
				}
				if (!Information.IsNothing(this.DetectedMinesBag) && this.DetectedMinesBag.Count > 0)
				{
					if (Information.IsNothing(activeUnit.GetSensory().DetectedMinesBag))
					{
						activeUnit.GetSensory().DetectedMinesBag = new ConcurrentBag<string>();
					}
					foreach (string current2 in this.DetectedMinesBag)
					{
						if (!Information.IsNothing(current2))
						{
							activeUnit.GetSensory().DetectedMinesBag.Add(current2);
						}
					}
				}
				if (!Information.IsNothing(this.lazy_0) && !Misc.smethod_18(this.lazy_0.Value))
				{
					if (Information.IsNothing(activeUnit.GetSensory().lazy_0))
					{
						activeUnit.GetSensory().lazy_0 = new Lazy<ConcurrentDictionary<long, LoggedMessage>>();
					}
					foreach (KeyValuePair<long, LoggedMessage> current3 in this.lazy_0.Value)
					{
						activeUnit.GetSensory().lazy_0.Value.TryAdd(current3.Key, current3.Value);
					}
					this.lazy_0.Value.Clear();
				}
				activeUnit.GetSensory().ScheduleDetectInterationOffGrid();
			}
			else
			{
				base.ScheduleDetectInterationOnGrid();
			}
		}

		// Token: 0x0400346F RID: 13423
		private Weapon ParentWeapon;
	}
}
