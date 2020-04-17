using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns2
{
	// Token: 0x02000AF8 RID: 2808
	public sealed class Group_Weaponry : ActiveUnit_Weaponry
	{
		// Token: 0x06005AAC RID: 23212 RVA: 0x00283D40 File Offset: 0x00281F40
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Group_Weaponry");
				xmlWriter_0.WriteStartElement("WeaponAssignments");
				using (IEnumerator<WeaponAssignment> enumerator = this.GetWeaponAssignments().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.Save(ref xmlWriter_0, ref hashSet_1);
					}
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100625", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005AAD RID: 23213 RVA: 0x00283E00 File Offset: 0x00282000
		public static Group_Weaponry Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Group_Weaponry result = null;
			try
			{
				Group_Weaponry group_Weaponry = new Group_Weaponry(ref activeUnit_1);
				group_Weaponry.ParentPlatform = activeUnit_1;
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
										group_Weaponry.GetWeaponAssignments().Add(weaponAssignment);
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
				result = group_Weaponry;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100626", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Group_Weaponry(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005AAE RID: 23214 RVA: 0x0002576C File Offset: 0x0002396C
		public Group_Weaponry(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}

		// Token: 0x06005AAF RID: 23215 RVA: 0x00283FE8 File Offset: 0x002821E8
		public override int GetWeaponLoadsInMagazines(int int_0)
		{
			int num = 0;
			int result = 0;
			try
			{
				using (IEnumerator<ActiveUnit> enumerator = ((Group)this.ParentPlatform).GetUnitsInGroup().Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Magazine[] magazines = ((Platform)enumerator.Current).m_Magazines;
						for (int i = 0; i < magazines.Length; i = checked(i + 1))
						{
							Magazine magazine = magazines[i];
							foreach (WeaponRec current in magazine.GetWeaponRecCollection())
							{
								if (current.GetWeapon(this.ParentPlatform.m_Scenario).DBID == int_0)
								{
									num += current.GetCurrentLoad();
								}
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
				ex2.Data.Add("Error at 100628", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005AB0 RID: 23216 RVA: 0x00284130 File Offset: 0x00282330
		public override string vmethod_10(int int_0, bool bool_7, ref float float_0)
		{
			string text = "";
			checked
			{
				string result;
				if (Information.IsNothing(this.ParentPlatform))
				{
					text = "Error";
				}
				else if (Information.IsNothing(this.ParentPlatform.m_Scenario))
				{
					text = "Error";
				}
				else
				{
					try
					{
						if (bool_7 && this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags))
						{
							text = "OK";
						}
						else
						{
							if (!Information.IsNothing(((Group)this.ParentPlatform).GetMagazines()))
							{
								Magazine[] magazines = ((Group)this.ParentPlatform).GetMagazines();
								for (int i = 0; i < magazines.Length; i++)
								{
									Magazine magazine = magazines[i];
									if (!Information.IsNothing(magazine) && Operators.CompareString(magazine.method_30(int_0, bool_7, ref float_0), "OK", false) == 0)
									{
										text = "OK";
										result = text;
										return result;
									}
								}
							}
							text = "Weapon not found in magazines";
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100629", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						text = "Error";
						ProjectData.ClearProjectError();
					}
				}
				result = text;
				return result;
			}
		}

		// Token: 0x06005AB1 RID: 23217 RVA: 0x0028427C File Offset: 0x0028247C
		public override string AddToMagazineWeaponLoad(int int_0, bool bool_7, bool bool_8)
		{
			string text = "";
			checked
			{
				string result;
				try
				{
					if (Information.IsNothing(((Group)this.ParentPlatform).GetMagazines()))
					{
						text = "Failure";
					}
					else
					{
						Magazine[] magazines = ((Group)this.ParentPlatform).GetMagazines();
						for (int i = 0; i < magazines.Length; i++)
						{
							if (Operators.CompareString(magazines[i].AddToCurrentLoad(int_0), "OK", false) == 0)
							{
								text = "OK";
								result = text;
								return result;
							}
						}
						if (((Group)this.ParentPlatform).GetMagazines().Length > 0)
						{
							((Group)this.ParentPlatform).GetMagazines()[0].GetWeaponRecCollection().Add(new WeaponRec(ref this.ParentPlatform.m_Scenario, int_0, 1, 99999, 1, 1, false, false));
							text = "OK";
						}
						else
						{
							text = "Failure";
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100630", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					text = "Failure";
					ProjectData.ClearProjectError();
				}
				result = text;
				return result;
			}
		}
	}
}
