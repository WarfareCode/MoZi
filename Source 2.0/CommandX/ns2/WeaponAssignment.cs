using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns4;

namespace ns2
{
	// Token: 0x02000B93 RID: 2963
	public sealed class WeaponAssignment : Subject
	{
		// Token: 0x060061A7 RID: 24999 RVA: 0x002F3FA8 File Offset: 0x002F21A8
		public void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("WeaponAssignment");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (hashSet_0.Contains(base.GetGuid()))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(base.GetGuid());
					xmlWriter_0.WriteElementString("Weapon", this.m_Weapon.DBID.ToString());
					xmlWriter_0.WriteElementString("Quantity", this.Quantity.ToString());
					xmlWriter_0.WriteElementString("Target", this.m_Target.GetGuid());
					xmlWriter_0.WriteElementString("ScheduledFireTime", this.ScheduledFireTime.ToBinary().ToString());
					xmlWriter_0.WriteStartElement("PlottedCourse");
					using (IEnumerator<Waypoint> enumerator = this.PlottedCourse.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.Save(ref xmlWriter_0, ref hashSet_0);
						}
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteElementString("ManualFire", this.ManualFire.ToString());
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101072", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x002F4140 File Offset: 0x002F2340
		public static WeaponAssignment Load(ref XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			WeaponAssignment result = null;
			try
			{
				WeaponAssignment weaponAssignment = new WeaponAssignment();
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
							if (num != 737620728u)
							{
								if (num != 1437471919u)
								{
									if (num == 1458105184u && Operators.CompareString(name, "ID", false) == 0)
									{
										weaponAssignment.SetGuid(xmlNode.InnerText);
									}
								}
								else if (Operators.CompareString(name, "ManualFire", false) == 0)
								{
									weaponAssignment.ManualFire = Conversions.ToBoolean(xmlNode.InnerText);
								}
							}
							else if (Operators.CompareString(name, "Quantity", false) == 0)
							{
								weaponAssignment.Quantity = Conversions.ToInteger(xmlNode.InnerText);
							}
						}
						else if (num <= 3082879841u)
						{
							if (num != 2338845032u)
							{
								if (num == 3082879841u && Operators.CompareString(name, "Weapon", false) == 0)
								{
									weaponAssignment.m_Weapon = scenario_0.GetWeapon(Conversions.ToInteger(xmlNode.InnerText));
								}
							}
							else if (Operators.CompareString(name, "Target", false) == 0)
							{
								if (xmlNode.InnerText.StartsWith("Aimpoint_"))
								{
									weaponAssignment.m_Target = Aimpoint.GetAimpoint(xmlNode.InnerText);
								}
								else
								{
									weaponAssignment.m_Target = Contact.GetContact(xmlNode.InnerText, ref dictionary_0);
								}
							}
						}
						else if (num != 3750830438u)
						{
							if (num == 4249887469u && Operators.CompareString(name, "ScheduledFireTime", false) == 0)
							{
								weaponAssignment.ScheduledFireTime = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
							}
						}
						else if (Operators.CompareString(name, "PlottedCourse", false) == 0)
						{
							IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
									Waypoint item = Waypoint.smethod_9(ref xmlNode2, ref dictionary_0);
									weaponAssignment.PlottedCourse.Add(item);
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
				result = weaponAssignment;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101073", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new WeaponAssignment();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x0002B2A5 File Offset: 0x000294A5
		private WeaponAssignment()
		{
			this.PlottedCourse = new Collection<Waypoint>();
		}

		// Token: 0x0400350A RID: 13578
		public Weapon m_Weapon;

		// Token: 0x0400350B RID: 13579
		public int Quantity;

		// Token: 0x0400350C RID: 13580
		public Contact m_Target;

		// Token: 0x0400350D RID: 13581
		public DateTime ScheduledFireTime;

		// Token: 0x0400350E RID: 13582
		public Collection<Waypoint> PlottedCourse;

		// Token: 0x0400350F RID: 13583
		public bool ManualFire;
	}
}
