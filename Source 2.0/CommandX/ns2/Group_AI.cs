using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns4;

namespace ns2
{
	// Token: 0x02000AED RID: 2797
	public sealed class Group_AI : ActiveUnit_AI
	{
		// Token: 0x06005A57 RID: 23127 RVA: 0x00281900 File Offset: 0x0027FB00
		public static Group_AI Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_1, ref ActiveUnit activeUnit_1)
		{
			Group_AI result = null;
			try
			{
				Group_AI group_AI = new Group_AI(ref activeUnit_1);
				group_AI.m_ActiveUnit = activeUnit_1;
				if (Operators.CompareString(xmlNode_0.ChildNodes[0].Name, "ActiveUnit_AI", false) == 0)
				{
					xmlNode_0 = xmlNode_0.ChildNodes[0];
				}
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 467450941u)
						{
							if (num != 106934956u)
							{
								if (num != 357111700u)
								{
									if (num == 467450941u && Operators.CompareString(name, "PrimaryThreat", false) == 0)
									{
										group_AI.PrimaryThreat = Contact.GetContact(xmlNode.InnerText, ref dictionary_1);
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "IgnorePlottedCourse", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "PrimaryTarget", false) == 0)
								{
									group_AI.PrimaryTarget = Contact.GetContact(xmlNode.InnerText, ref dictionary_1);
									continue;
								}
								continue;
							}
						}
						else
						{
							if (num <= 1533721748u)
							{
								if (num != 592141878u)
								{
									if (num == 1533721748u && Operators.CompareString(name, "PrimaryTargetOverride", false) == 0)
									{
										group_AI.bPrimaryTargetOverride = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Threats", false) != 0)
									{
										continue;
									}
									IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator2.MoveNext())
										{
											XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
											Contact contact_ = Contact.Load(ref xmlNode2, ref dictionary_1);
											ScenarioArrayUtil.AddContact(ref group_AI.Threats, contact_);
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
							}
							if (num != 2276842832u)
							{
								if (num != 3957045325u || Operators.CompareString(name, "IPC", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "TargetList", false) == 0)
								{
									IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator3.MoveNext())
										{
											XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
											ActiveUnit_AI.TargetingEntry targetingEntry = ActiveUnit_AI.TargetingEntry.Load(ref xmlNode3, ref dictionary_1);
											if (!Information.IsNothing(targetingEntry.Target))
											{
												group_AI.GetTargetList().Add(targetingEntry.Target.GetGuid(), targetingEntry);
											}
										}
									}
									finally
									{
										if (enumerator3 is IDisposable)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
									continue;
								}
								continue;
							}
						}
						if (!Information.IsNothing(activeUnit_1.m_Doctrine))
						{
							activeUnit_1.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(activeUnit_1.m_Scenario, false, null, false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Conversions.ToBoolean(xmlNode.InnerText) ? Doctrine._IgnorePlottedCourseWhenAttacking.const_1 : Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
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
				result = group_AI;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100603", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Group_AI(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005A58 RID: 23128 RVA: 0x00281CD8 File Offset: 0x0027FED8
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			try
			{
				if (!Information.IsNothing(this.GetPrimaryTarget()))
				{
					xmlWriter_0.WriteElementString("PrimaryTarget", this.GetPrimaryTarget().GetGuid());
				}
				if (!Information.IsNothing(this.PrimaryThreat))
				{
					xmlWriter_0.WriteElementString("PrimaryThreat", this.PrimaryThreat.GetGuid());
				}
				xmlWriter_0.WriteElementString("TTNPTE", this.TimeToNextPrimaryTargetEvent.ToString());
				xmlWriter_0.WriteElementString("PTOE", this.bPrimaryTargetOverride.ToString());
				xmlWriter_0.WriteElementString("FCLIO", this.FerryCycleLegIsOutbound.ToString());
				if (this.IsEscort)
				{
					xmlWriter_0.WriteElementString("IE", this.IsEscort.ToString());
				}
				if (!Information.IsNothing(this.LastKnownTargetLocation))
				{
					xmlWriter_0.WriteStartElement("LKTL");
					GeoPoint lastKnownTargetLocation = this.LastKnownTargetLocation;
					HashSet<string> hashSet = null;
					lastKnownTargetLocation.Save(ref xmlWriter_0, ref hashSet);
					xmlWriter_0.WriteEndElement();
				}
				if (this.GetTargetList().Count > 0)
				{
					xmlWriter_0.WriteStartElement("TargetList");
					foreach (ActiveUnit_AI.TargetingEntry current in this.GetTargetList().Values)
					{
						if (!Information.IsNothing(current.Target.ActualUnit))
						{
							current.Save(ref xmlWriter_0, this.m_ActiveUnit.GetSide(false));
							xmlWriter_0.Flush();
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (base.GetThreats().Length > 0)
				{
					xmlWriter_0.WriteStartElement("Threats");
					List<Contact> list = new List<Contact>();
					list.AddRange(this.Threats);
					foreach (Contact current2 in list)
					{
						if (!Information.IsNothing(current2))
						{
							current2.Save(ref xmlWriter_0, ref hashSet_1);
							xmlWriter_0.Flush();
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (!Information.IsNothing(this.SnakeAxis))
				{
					xmlWriter_0.WriteElementString("SnakeAxis", Conversions.ToString(this.SnakeAxis.Value));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100604", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005A59 RID: 23129 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void TargetingContacts(float float_1, bool bool_6, bool bool_7)
		{
		}

		// Token: 0x06005A5A RID: 23130 RVA: 0x00023901 File Offset: 0x00021B01
		public Group_AI(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}

		// Token: 0x06005A5B RID: 23131 RVA: 0x000289B5 File Offset: 0x00026BB5
		public override void SetDesiredAltitude()
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && this.m_ActiveUnit.IsGroup)
			{
				((Group)this.m_ActiveUnit).GetGroupLead().GetAI().SetDesiredAltitude();
			}
		}

		// Token: 0x06005A5C RID: 23132 RVA: 0x00281F84 File Offset: 0x00280184
		public static float smethod_2(ActiveUnit activeUnit_1)
		{
			return (float)(SonarEnvironment.GetLayer(activeUnit_1.GetLatitude(null), activeUnit_1.GetLongitude(null), activeUnit_1.GetTerrainElevation(false, false, false)).Ceiling + 10);
		}

		// Token: 0x06005A5D RID: 23133 RVA: 0x00281FC8 File Offset: 0x002801C8
		public static float smethod_3(ActiveUnit activeUnit_1)
		{
			return (float)(SonarEnvironment.GetLayer(activeUnit_1.GetLatitude(null), activeUnit_1.GetLongitude(null), activeUnit_1.GetTerrainElevation(false, false, false)).Bottom - 10);
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x0028200C File Offset: 0x0028020C
		public override void SetDesiredDepth(bool bool_6)
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && this.m_ActiveUnit.IsGroup)
			{
				GlobalVariables.ActiveUnitType unitType = ((Group)this.m_ActiveUnit).GetGroupLead().GetUnitType();
				if (unitType == GlobalVariables.ActiveUnitType.Aircraft)
				{
					((Group)this.m_ActiveUnit).GetGroupLead().GetAI().SetDesiredAltitude();
				}
				else if (unitType == GlobalVariables.ActiveUnitType.Submarine)
				{
					((Group)this.m_ActiveUnit).GetGroupLead().GetAI().SetDesiredDepth(bool_6);
				}
				else
				{
					if (!Debugger.IsAttached)
					{
						throw new NotImplementedException();
					}
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005A5F RID: 23135 RVA: 0x002820B0 File Offset: 0x002802B0
		public void method_88(ActiveUnit_AI._DepthPreset enum2_0)
		{
			Group group = (Group)this.m_ActiveUnit;
			if (Information.IsNothing(group.GetGroupLead()))
			{
				group.SetGroupLead();
			}
			if (!Information.IsNothing(group.GetGroupLead()))
			{
				((Submarine)group.GetGroupLead()).GetSubmarineAI().SetDepthPreset(enum2_0);
				if (enum2_0 != ActiveUnit_AI._DepthPreset.None)
				{
					group.GetGroupKinematics().SetDesiredAltitudeOverride(true);
				}
			}
		}

		// Token: 0x06005A60 RID: 23136 RVA: 0x00282114 File Offset: 0x00280314
		public void method_89(ActiveUnit_AI._AltitudePreset enum3_0)
		{
			Group group = (Group)this.m_ActiveUnit;
			if (Information.IsNothing(group.GetGroupLead()))
			{
				group.SetGroupLead();
			}
			if (!Information.IsNothing(group.GetGroupLead()))
			{
				((Aircraft)group.GetGroupLead()).GetAircraftAI().SetAltitudePreset(enum3_0);
				if (enum3_0 != ActiveUnit_AI._AltitudePreset.None)
				{
					group.GetGroupKinematics().SetDesiredAltitudeOverride(true);
				}
			}
		}

		// Token: 0x06005A61 RID: 23137 RVA: 0x00282178 File Offset: 0x00280378
		public override void TargetingContact(Contact contact_8, bool LogMessage_, bool bool_7, ActiveUnit_AI.TargetingEntry._TargetingBehavior _TargetingBehavior_0)
		{
			try
			{
				if (contact_8.contactType != Contact_Base.ContactType.Sonobuoy)
				{
					if (contact_8.contactType == Contact_Base.ContactType.Missile)
					{
						Weapon weapon = (Weapon)contact_8.ActualUnit;
						if (weapon.weaponTarget.IsAircraft || weapon.weaponTarget.IsGuidedWeapon)
						{
							if (LogMessage_)
							{
								this.m_ActiveUnit.Message = "Cannot shoot at an AAW weapon!";
							}
							return;
						}
					}
					foreach (ActiveUnit current in ((Group)this.m_ActiveUnit).GetUnitsInGroup().Values)
					{
						if (current.GetCommStuff().IsNotOutOfComms())
						{
							ActiveUnit_Weaponry weaponry = current.GetWeaponry();
							Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
							string text = "";
							int num = 0;
							if (weaponry.HasWeaponsInConditionToAttackTarget(contact_8, true, doctrine, ref text, ref num, null))
							{
								current.GetAI().TargetingContact(contact_8, true, bool_7, _TargetingBehavior_0);
							}
						}
						else if (LogMessage_)
						{
							current.LogMessage(current.Name + " cannot participate in attack (unable to issue orders to unit)", LoggedMessage.MessageType.UnitAI, 0, false, new GeoPoint(current.GetLongitude(null), current.GetLatitude(null)));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100606", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005A62 RID: 23138 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void UpdateUnitStatus(float float_1, bool bool_6, bool bool_7)
		{
		}

		// Token: 0x06005A63 RID: 23139 RVA: 0x0028233C File Offset: 0x0028053C
		public override void DropTargeting(Contact theTarget, bool IgnoreTargetIllumination = true)
		{
			using (IEnumerator<ActiveUnit> enumerator = ((Group)this.m_ActiveUnit).GetUnitsInGroup().Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.GetAI().DropTargeting(theTarget, true);
				}
			}
		}

		// Token: 0x06005A64 RID: 23140 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void Navigate(float elapsedTime_)
		{
		}

		// Token: 0x06005A65 RID: 23141 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void ScheduleNextPrimaryTargetEvent(short short_1, bool bool_6)
		{
		}

		// Token: 0x06005A66 RID: 23142 RVA: 0x002823A0 File Offset: 0x002805A0
		public override Contact GetPrimaryTarget()
		{
			Contact result;
			if (!Information.IsNothing(((Group)this.m_ActiveUnit).GetGroupLead()))
			{
				result = ((Group)this.m_ActiveUnit).GetGroupLead().GetAI().GetPrimaryTarget();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06005A67 RID: 23143 RVA: 0x002823E8 File Offset: 0x002805E8
		public override void SetPrimaryTarget(Contact contact_8)
		{
			if (Information.IsNothing(((Group)this.m_ActiveUnit).GetGroupLead()))
			{
				((Group)this.m_ActiveUnit).SetGroupLead();
			}
			if (!Information.IsNothing(((Group)this.m_ActiveUnit).GetGroupLead()))
			{
				((Group)this.m_ActiveUnit).GetGroupLead().GetAI().SetPrimaryTarget(contact_8);
			}
		}
	}
}
