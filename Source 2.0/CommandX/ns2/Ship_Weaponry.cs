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
	// Token: 0x02000B7B RID: 2939
	public sealed class Ship_Weaponry : ActiveUnit_Weaponry
	{
		// Token: 0x06006135 RID: 24885 RVA: 0x002E862C File Offset: 0x002E682C
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Ship_Weaponry");
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
				ex2.Data.Add("Error at 100797", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x002E8700 File Offset: 0x002E6900
		public static Ship_Weaponry smethod_4(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Ship_Weaponry result = null;
			try
			{
				Ship_Weaponry ship_Weaponry = new Ship_Weaponry(ref activeUnit_1);
				ship_Weaponry.ParentPlatform = activeUnit_1;
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
										ship_Weaponry.GetWeaponAssignments().Add(weaponAssignment);
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
				result = ship_Weaponry;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100798", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Ship_Weaponry(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x0002576C File Offset: 0x0002396C
		public Ship_Weaponry(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}
	}
}
