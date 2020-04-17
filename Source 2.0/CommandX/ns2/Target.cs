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
	// Token: 0x02000B51 RID: 2897
	public sealed class Target : Subject
	{
		// Token: 0x06005F29 RID: 24361 RVA: 0x002CF760 File Offset: 0x002CD960
		public void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (!string.IsNullOrEmpty(this.TargetSide))
				{
					xmlWriter_0.WriteElementString("TargetSide", this.TargetSide);
				}
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "TargetType";
				int targetType = (int)this.TargetType;
				xmlWriter.WriteElementString(localName, targetType.ToString());
				xmlWriter_0.WriteElementString("TargetSubType", this.TargetSubType.ToString());
				if (this.SpecificUnitClass != 0)
				{
					xmlWriter_0.WriteElementString("SpecificUnitClass", this.SpecificUnitClass.ToString());
				}
				if (!Information.IsNothing(this.SpecificUnit))
				{
					xmlWriter_0.WriteStartElement("SpecificUnit");
					this.SpecificUnit.Save(ref xmlWriter_0, ref hashSet_0);
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101070", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005F2A RID: 24362 RVA: 0x002CF870 File Offset: 0x002CDA70
		public static Target Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			Target result = null;
			try
			{
				Target target = new Target();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "TargetSide", false) != 0)
							{
								if (Operators.CompareString(name, "TargetType", false) != 0)
								{
									if (Operators.CompareString(name, "TargetSubType", false) != 0)
									{
										if (Operators.CompareString(name, "SpecificUnitClass", false) != 0)
										{
											if (Operators.CompareString(name, "SpecificUnit", false) == 0 && xmlNode.HasChildNodes)
											{
												Target target2 = target;
												XmlNode xmlNode2 = xmlNode.ChildNodes[0];
												target2.SpecificUnit = ActiveUnit.Load(ref xmlNode2, ref dictionary_0, ref scenario_0);
											}
										}
										else
										{
											target.SpecificUnitClass = Conversions.ToInteger(xmlNode.InnerText);
										}
									}
									else
									{
										target.TargetSubType = Conversions.ToInteger(xmlNode.InnerText);
									}
								}
								else
								{
									target.TargetType = (GlobalVariables.ActiveUnitType)Conversions.ToByte(xmlNode.InnerText);
								}
							}
							else
							{
								target.TargetSide = xmlNode.InnerText;
							}
						}
						else
						{
							target.SetGuid(xmlNode.InnerText);
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
				result = target;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101071", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Target();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005F2B RID: 24363 RVA: 0x002CFA50 File Offset: 0x002CDC50
		public bool method_12(ActiveUnit activeUnit_1)
		{
			bool result;
			if (!string.IsNullOrEmpty(this.TargetSide))
			{
				if (Information.IsNothing(activeUnit_1.GetSide(false)))
				{
					result = false;
					return result;
				}
				if (string.CompareOrdinal(activeUnit_1.GetSide(false).GetGuid(), this.TargetSide) != 0)
				{
					result = false;
					return result;
				}
			}
			switch (this.TargetType)
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				if (!activeUnit_1.IsAircraft)
				{
					result = false;
					return result;
				}
				break;
			case GlobalVariables.ActiveUnitType.Ship:
				if (!activeUnit_1.IsShip)
				{
					result = false;
					return result;
				}
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				if (!activeUnit_1.IsSubmarine)
				{
					result = false;
					return result;
				}
				break;
			case GlobalVariables.ActiveUnitType.Facility:
				if (!activeUnit_1.IsFacility)
				{
					result = false;
					return result;
				}
				break;
			case GlobalVariables.ActiveUnitType.Aimpoint:
				if (!activeUnit_1.AreAimpoints())
				{
					result = false;
					return result;
				}
				break;
			case GlobalVariables.ActiveUnitType.Weapon:
				if (!activeUnit_1.IsWeapon)
				{
					result = false;
					return result;
				}
				break;
			}
			bool arg_1B8_0;
			if (this.TargetSubType != 0)
			{
				if ((!activeUnit_1.IsAircraft || ((Aircraft)activeUnit_1).Type == (Aircraft._AircraftType)this.TargetSubType) && (!activeUnit_1.IsShip || ((Ship)activeUnit_1).Type == (Ship._ShipType)this.TargetSubType) && (!activeUnit_1.IsSubmarine || ((Submarine)activeUnit_1).Type == (Submarine._SubmarineType)this.TargetSubType) && (!activeUnit_1.IsFacility || (int)((Facility)activeUnit_1).Category == this.TargetSubType) && (!activeUnit_1.AreAimpoints() || (int)((Facility)activeUnit_1).Category == this.TargetSubType))
				{
					if (activeUnit_1.IsWeapon)
					{
						if ((int)((Weapon)activeUnit_1).GetWeaponType() != this.TargetSubType)
						{
							goto IL_17D;
						}
					}
					arg_1B8_0 = (this.SpecificUnitClass == 0 || (this.SpecificUnitClass == activeUnit_1.DBID && (Information.IsNothing(this.SpecificUnit) || this.SpecificUnit == activeUnit_1)));
					goto IL_1B8;
				}
				IL_17D:
				arg_1B8_0 = false;
			}
			else
			{
				arg_1B8_0 = true;
			}
			IL_1B8:
			result = arg_1B8_0;
			return result;
		}

		// Token: 0x04003255 RID: 12885
		public string TargetSide;

		// Token: 0x04003256 RID: 12886
		public GlobalVariables.ActiveUnitType TargetType;

		// Token: 0x04003257 RID: 12887
		public int TargetSubType;

		// Token: 0x04003258 RID: 12888
		public int SpecificUnitClass;

		// Token: 0x04003259 RID: 12889
		public ActiveUnit SpecificUnit;
	}
}
