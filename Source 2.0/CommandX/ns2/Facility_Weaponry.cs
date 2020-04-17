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
	// Token: 0x02000AC1 RID: 2753
	public sealed class Facility_Weaponry : ActiveUnit_Weaponry
	{
		// Token: 0x060057F2 RID: 22514 RVA: 0x0026A1CC File Offset: 0x002683CC
		private Facility GetParentFacility()
		{
			if (Information.IsNothing(this.facility))
			{
				this.facility = (Facility)this.ParentPlatform;
			}
			return this.facility;
		}

		// Token: 0x060057F3 RID: 22515 RVA: 0x0026A204 File Offset: 0x00268404
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
				ex2.Data.Add("Error at 100568", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060057F4 RID: 22516 RVA: 0x0026A2D8 File Offset: 0x002684D8
		public static Facility_Weaponry Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Facility_Weaponry result = null;
			try
			{
				Facility_Weaponry facility_Weaponry = new Facility_Weaponry(ref activeUnit_1);
				facility_Weaponry.ParentPlatform = activeUnit_1;
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
										facility_Weaponry.GetWeaponAssignments().Add(weaponAssignment);
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
				result = facility_Weaponry;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100569", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Facility_Weaponry(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060057F5 RID: 22517 RVA: 0x0026A4C0 File Offset: 0x002686C0
		public override string vmethod_10(int int_0, bool bool_7, ref float float_0)
		{
			string text = "";
			checked
			{
				string result;
				try
				{
					if (bool_7 && this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags))
					{
						text = "OK";
					}
					else
					{
						Magazine[] magazines = ((Platform)this.ParentPlatform).m_Magazines;
						for (int i = 0; i < magazines.Length; i++)
						{
							Magazine magazine = magazines[i];
							if (magazine.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed && Operators.CompareString(magazine.method_30(int_0, bool_7, ref float_0), "OK", false) == 0)
							{
								text = "OK";
								result = text;
								return result;
							}
						}
						if (this.ParentPlatform.HasParentGroup() && !Information.IsNothing(this.ParentPlatform.GetParentGroup(false).GetMagazines()))
						{
							Magazine[] magazines2 = this.ParentPlatform.GetParentGroup(false).GetMagazines();
							for (int j = 0; j < magazines2.Length; j++)
							{
								Magazine magazine2 = magazines2[j];
								if (magazine2.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed && Operators.CompareString(magazine2.method_30(int_0, bool_7, ref float_0), "OK", false) == 0)
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
					ex2.Data.Add("Error at 100570", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					text = "Error!";
					ProjectData.ClearProjectError();
				}
				result = text;
				return result;
			}
		}

		// Token: 0x060057F6 RID: 22518 RVA: 0x0002576C File Offset: 0x0002396C
		public Facility_Weaponry(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}

		// Token: 0x060057F7 RID: 22519 RVA: 0x0026A658 File Offset: 0x00268858
		public override void HandleWeaponSalvos(float float_0)
		{
			try
			{
				if ((int)Math.Round((double)this.GetParentFacility().GetCurrentSpeed()) <= 0 || this.GetParentFacility().method_129())
				{
					base.HandleWeaponSalvos(float_0);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101209", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x04002B45 RID: 11077
		private Facility facility;
	}
}
