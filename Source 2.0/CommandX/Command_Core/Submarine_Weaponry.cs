using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace Command_Core
{
	// 潜艇武器
	public sealed class Submarine_Weaponry : ActiveUnit_Weaponry
	{
		// 取父平台
		private Submarine GetParentPlatform()
		{
			if (Information.IsNothing(this.submarine))
			{
				this.submarine = (Submarine)this.ParentPlatform;
			}
			return this.submarine;
		}

		// 保存
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Submarine_Weaponry");
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
				ex2.Data.Add("Error at 100840", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// 读取
		public static Submarine_Weaponry Read(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Submarine_Weaponry result = null;
			try
			{
				Submarine_Weaponry submarine_Weaponry = new Submarine_Weaponry(ref activeUnit_1);
				submarine_Weaponry.ParentPlatform = activeUnit_1;
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
										submarine_Weaponry.GetWeaponAssignments().Add(weaponAssignment);
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
				result = submarine_Weaponry;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100841", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Submarine_Weaponry(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// 构造函数
		public Submarine_Weaponry(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x002AC5EC File Offset: 0x002AA7EC
		public override Weapon vmethod_11()
		{
			List<WeaponRec> list = base.method_0(false);
			List<Weapon> list2 = new List<Weapon>();
			foreach (WeaponRec current in list)
			{
				if (current.DefaultLoad != 0)
				{
					Weapon weapon = current.GetWeapon(this.ParentPlatform.m_Scenario);
					Submarine._SubmarineType type = this.GetParentPlatform().Type;
					if (type - Submarine._SubmarineType.SSB <= 3)
					{
						if (weapon.IsGuidedWeapon_RV_HGV())
						{
							list2.Add(weapon);
						}
					}
					else if (weapon.IsTorpedo())
					{
						list2.Add(weapon);
					}
				}
			}
			Weapon result;
			if (list2.Count > 0)
			{
				result = list2.OrderByDescending(Submarine_Weaponry.WeaponFunc0).ElementAtOrDefault(0);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x002AC6D4 File Offset: 0x002AA8D4
		public override Weapon vmethod_12()
		{
			List<Weapon> list = new List<Weapon>();
			Weapon[] availableWeapons = base.GetAvailableWeapons(false);
			checked
			{
				for (int i = 0; i < availableWeapons.Length; i++)
				{
					Weapon weapon = availableWeapons[i];
					Submarine._SubmarineType type = this.GetParentPlatform().Type;
					if (unchecked(type - Submarine._SubmarineType.SSB) <= 3)
					{
						if (weapon.IsGuidedWeapon_RV_HGV())
						{
							list.Add(weapon);
						}
					}
					else if (weapon.IsTorpedo())
					{
						list.Add(weapon);
					}
				}
				Weapon result;
				if (list.Count > 0)
				{
					result = list.OrderByDescending(Submarine_Weaponry.WeaponFunc1).ElementAtOrDefault(0);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06005C9D RID: 23709 RVA: 0x002AC774 File Offset: 0x002AA974
		public override Weapon GetWeaponWithMaxRange()
		{
			List<Weapon> list = base.GetAvailableWeapons(false).Where(Submarine_Weaponry.TorpedoWeaponFilterFunc2).ToList<Weapon>();
			Weapon result;
			if (list.Count > 0)
			{
				result = list.OrderByDescending(Submarine_Weaponry.WeaponMaxRangeFunc3).ElementAtOrDefault(0);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x040030C3 RID: 12483
		public static Func<Weapon, float> WeaponFunc0 = (Weapon weapon_0) => weapon_0.GetLargestRangeMaxOfAllDomains();

		// Token: 0x040030C4 RID: 12484
		public static Func<Weapon, float> WeaponFunc1 = (Weapon weapon_0) => weapon_0.GetLargestRangeMaxOfAllDomains();

		// Token: 0x040030C5 RID: 12485
		public static Func<Weapon, bool> TorpedoWeaponFilterFunc2 = (Weapon weapon_0) => weapon_0.IsTorpedo();

		// Token: 0x040030C6 RID: 12486
		public static Func<Weapon, float> WeaponMaxRangeFunc3 = (Weapon weapon_0) => weapon_0.GetLargestRangeMaxOfAllDomains();

		// Token: 0x040030C7 RID: 12487
		private Submarine submarine;
	}
}
