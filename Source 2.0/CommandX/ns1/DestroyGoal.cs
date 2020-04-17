using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace ns1
{
	// Token: 0x02000A86 RID: 2694
	public sealed class DestroyGoal : Goal
	{
		// Token: 0x0600551F RID: 21791 RVA: 0x00237D74 File Offset: 0x00235F74
		public new static DestroyGoal Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			DestroyGoal result = null;
			try
			{
				DestroyGoal destroyGoal = new DestroyGoal();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1758605701u)
						{
							if (num <= 1016973537u)
							{
								if (num != 642834266u)
								{
									if (num == 1016973537u && Operators.CompareString(name, "GoalPoints", false) == 0)
									{
										destroyGoal.GoalPoints = Conversions.ToInteger(xmlNode.InnerText);
									}
								}
								else if (Operators.CompareString(name, "TargetSubType", false) == 0)
								{
									destroyGoal.TargetSubType = Conversions.ToInteger(xmlNode.InnerText);
								}
							}
							else if (num != 1458105184u)
							{
								if (num != 1725856265u)
								{
									if (num == 1758605701u && Operators.CompareString(name, "SpecificUnitClass", false) == 0)
									{
										if (Versioned.IsNumeric(xmlNode.InnerText))
										{
											destroyGoal.SpecificUnitClass = Conversions.ToInteger(xmlNode.InnerText);
										}
										else
										{
											destroyGoal.SpecificUnitClass = DBFunctions.smethod_12(xmlNode.InnerText, destroyGoal.TargetType, scenario_0.GetSQLiteConnection());
										}
									}
								}
								else if (Operators.CompareString(name, "Description", false) == 0)
								{
									destroyGoal.Description = xmlNode.InnerText;
								}
							}
							else if (Operators.CompareString(name, "ID", false) == 0)
							{
								destroyGoal.SetGuid(xmlNode.InnerText);
							}
						}
						else if (num <= 2106073694u)
						{
							if (num != 2007869216u)
							{
								if (num == 2106073694u && Operators.CompareString(name, "IsRepeatable", false) == 0)
								{
									destroyGoal.IsRepeatable = Conversions.ToBoolean(xmlNode.InnerText);
								}
							}
							else if (Operators.CompareString(name, "TargetType", false) == 0)
							{
								destroyGoal.TargetType = (GlobalVariables.ActiveUnitType)Conversions.ToByte(xmlNode.InnerText);
							}
						}
						else if (num != 3433798791u)
						{
							if (num != 3559666563u)
							{
								if (num == 4231673843u && Operators.CompareString(name, "SpecificUnit", false) == 0 && xmlNode.HasChildNodes)
								{
									Goal goal = destroyGoal;
									XmlNode xmlNode2 = xmlNode.ChildNodes[0];
									goal.SpecificUnit = ActiveUnit.Load(ref xmlNode2, ref dictionary_0, ref scenario_0);
								}
							}
							else if (Operators.CompareString(name, "TargetSide", false) == 0)
							{
								destroyGoal.TargetSideName = xmlNode.InnerText;
							}
						}
						else if (Operators.CompareString(name, "NeedsToBeChecked", false) == 0)
						{
							destroyGoal.NeedsToBeChecked = Conversions.ToBoolean(xmlNode.InnerText);
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
				result = destroyGoal;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100757", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new DestroyGoal();
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}
}
