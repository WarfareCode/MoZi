using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns2;
using ns4;

namespace Command_Core
{
	// Token: 0x02000A42 RID: 2626
	public abstract class EventTrigger : Subject
	{
		// Token: 0x06005371 RID: 21361 RVA: 0x00025A78 File Offset: 0x00023C78
		public virtual void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x00222A94 File Offset: 0x00220C94
		public static EventTrigger smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			EventTrigger eventTrigger = null;
			EventTrigger result;
			try
			{
				string name = xmlNode_0.Name;
				uint num = Class382.smethod_0(name);
				if (num > 1544518477u)
				{
					if (num <= 3034757310u)
					{
						if (num != 2127696415u)
						{
							if (num != 2658299510u)
							{
								if (num != 3034757310u)
								{
									goto IL_24D;
								}
								if (Operators.CompareString(name, "EventTrigger_UnitInArea", false) != 0)
								{
									goto IL_24D;
								}
							}
							else
							{
								if (Operators.CompareString(name, "EventTrigger_UnitEntersArea", false) == 0)
								{
									eventTrigger = EventTrigger_UnitEntersArea.Load(xmlNode_0, dictionary_0, scenario_0);
									result = eventTrigger;
									return result;
								}
								goto IL_24D;
							}
						}
						else
						{
							if (Operators.CompareString(name, "EventTrigger_UnitDestroyed", false) == 0)
							{
								eventTrigger = EventTrigger_UnitDestroyed.Load(xmlNode_0, dictionary_0, scenario_0);
								result = eventTrigger;
								return result;
							}
							goto IL_24D;
						}
					}
					else if (num != 3358481364u)
					{
						if (num != 3763229247u)
						{
							if (num == 3992631867u && Operators.CompareString(name, "EventTrigger_Time", false) == 0)
							{
								eventTrigger = EventTrigger_Time.Load(xmlNode_0, dictionary_0, scenario_0);
								result = eventTrigger;
								return result;
							}
							goto IL_24D;
						}
						else if (Operators.CompareString(name, "EventTrigger_UnitRemainsInArea", false) != 0)
						{
							goto IL_24D;
						}
					}
					else
					{
						if (Operators.CompareString(name, "EventTrigger_RandomTime", false) == 0)
						{
							eventTrigger = EventTrigger_RandomTime.Load(xmlNode_0, dictionary_0, scenario_0);
							result = eventTrigger;
							return result;
						}
						goto IL_24D;
					}
					eventTrigger = EventTrigger_UnitRemainsInArea.Load(xmlNode_0, dictionary_0, scenario_0);
					result = eventTrigger;
					return result;
				}
				if (num <= 340731739u)
				{
					if (num != 284250354u)
					{
						if (num == 340731739u && Operators.CompareString(name, "EventTrigger_UnitDamaged", false) == 0)
						{
							eventTrigger = EventTrigger_UnitDamaged.Load(xmlNode_0, dictionary_0, scenario_0);
							result = eventTrigger;
							return result;
						}
					}
					else if (Operators.CompareString(name, "EventTrigger_UnitDetected", false) == 0)
					{
						eventTrigger = EventTrigger_UnitDetected.Load(xmlNode_0, dictionary_0, scenario_0);
						result = eventTrigger;
						return result;
					}
				}
				else if (num != 884716714u)
				{
					if (num != 1510924423u)
					{
						if (num == 1544518477u && Operators.CompareString(name, "EventTrigger_Points", false) == 0)
						{
							eventTrigger = EventTrigger_Points.Load(xmlNode_0, dictionary_0, scenario_0);
							result = eventTrigger;
							return result;
						}
					}
					else if (Operators.CompareString(name, "EventTrigger_RegularTime", false) == 0)
					{
						eventTrigger = EventTrigger_RegularTime.Load(xmlNode_0, dictionary_0, scenario_0);
						result = eventTrigger;
						return result;
					}
				}
				else if (Operators.CompareString(name, "EventTrigger_ScenLoaded", false) == 0)
				{
					eventTrigger = EventTrigger_ScenLoaded.Load(xmlNode_0, dictionary_0, scenario_0);
					result = eventTrigger;
					return result;
				}
				IL_24D:
				throw new NotImplementedException();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100519", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				eventTrigger = null;
				ProjectData.ClearProjectError();
			}
			result = eventTrigger;
			return result;
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x00025A78 File Offset: 0x00023C78
		public virtual EventTrigger Clone()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04002721 RID: 10017
		public string strDescription = "";

		// Token: 0x04002722 RID: 10018
		public EventTrigger.EventTriggerType eventTriggerType;

		// Token: 0x02000A43 RID: 2627
		public enum EventTriggerType : byte
		{
			// Token: 0x04002724 RID: 10020
			UnitDestroyed,
			// Token: 0x04002725 RID: 10021
			Points,
			// Token: 0x04002726 RID: 10022
			Time,
			// Token: 0x04002727 RID: 10023
			UnitDamaged,
			// Token: 0x04002728 RID: 10024
			UnitRemainsInArea,
			// Token: 0x04002729 RID: 10025
			UnitEntersArea,
			// Token: 0x0400272A RID: 10026
			RandomTime,
			// Token: 0x0400272B RID: 10027
			UnitDetected,
			// Token: 0x0400272C RID: 10028
			ScenLoaded,
			// Token: 0x0400272D RID: 10029
			RegularTime
		}
	}
}
