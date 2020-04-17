using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns0;

namespace ns4
{
	// Token: 0x02000C0A RID: 3082
	public sealed class Class272
	{
		// Token: 0x06006697 RID: 26263 RVA: 0x00354970 File Offset: 0x00352B70
		public static string smethod_0(string string_0, Scenario scenario_0)
		{
			EventAction eventAction = null;
			string right = string_0.ToLower();
			foreach (EventAction current in scenario_0.GetEventActions().Values)
			{
				if (current.eventActionType == EventAction.EventActionType.LuaScript && (Operators.CompareString(current.strDescription.ToLower(), right, false) == 0 || Operators.CompareString(current.GetGuid().ToLower(), right, false) == 0))
				{
					eventAction = current;
					break;
				}
			}
			string result;
			if (eventAction == null)
			{
				result = null;
			}
			else
			{
				result = ((EventAction_LuaScript)eventAction).ScriptText;
			}
			return result;
		}

		// Token: 0x06006698 RID: 26264 RVA: 0x00354A34 File Offset: 0x00352C34
		public static bool smethod_1(string string_0, LuaTable luaTable_0, Scenario scenario_0)
		{
			bool result = false;
			try
			{
				Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
				string right = string_0.ToLower();
				SimEvent simEvent = null;
				foreach (SimEvent current in scenario_0.GetSimEvents().Values)
				{
					if (Operators.CompareString(current.Description.ToLower(), right, false) == 0 || Operators.CompareString(current.GetGuid(), right, false) == 0)
					{
						simEvent = current;
					}
				}
				if (Information.IsNothing(simEvent))
				{
					throw new Exception2("Unable to identify the desired Event!");
				}
				if (objectGeoLocation.ContainsKey("NewName".ToUpper()))
				{
					string name = "";
					try
					{
						name = objectGeoLocation["NewName".ToUpper()].ToString();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						throw new Exception2("Unable to parse value NewName to string!");
					}
					simEvent.Name = name;
				}
				if (objectGeoLocation.ContainsKey("Description".ToUpper()))
				{
					string description = "";
					try
					{
						description = objectGeoLocation["Description".ToUpper()].ToString();
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						throw new Exception2("Unable to parse value Description to string!");
					}
					simEvent.Description = description;
				}
				if (objectGeoLocation.ContainsKey("IsActive".ToUpper()))
				{
					bool isActive = false;
					try
					{
						isActive = Conversions.ToBoolean(objectGeoLocation["IsActive".ToUpper()].ToString());
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						throw new Exception2("Unable to parse value IsActive to true/false!");
					}
					simEvent.IsActive = isActive;
				}
				if (objectGeoLocation.ContainsKey("IsShown".ToUpper()))
				{
					bool isShown = false;
					try
					{
						isShown = Conversions.ToBoolean(objectGeoLocation["IsShown".ToUpper()].ToString());
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						throw new Exception2("Unable to parse value IsShown to true/false!");
					}
					simEvent.IsShown = isShown;
				}
				if (objectGeoLocation.ContainsKey("IsRepeatable".ToUpper()))
				{
					bool isRepeatable;
					try
					{
						isRepeatable = Conversions.ToBoolean(objectGeoLocation["IsRepeatable".ToUpper()].ToString());
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						throw new Exception2("Unable to parse IsRepeatable to true/false!");
					}
					simEvent.IsRepeatable = isRepeatable;
				}
				if (objectGeoLocation.ContainsKey("Probability".ToUpper()))
				{
					short num = 0;
					short.TryParse(objectGeoLocation["Probability".ToUpper()].ToString(), out num);
					if (num >= 0 & num <= 100)
					{
						simEvent.Probability = num;
					}
				}
				result = true;
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x00354D8C File Offset: 0x00352F8C
		public static object smethod_2(string string_0, LuaTable luaTable_0, Scenario scenario_0)
		{
			bool flag = false;
			object result = null;
			try
			{
				Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
				string text = string_0.ToLower();
				SimEvent simEvent = null;
				foreach (SimEvent current in scenario_0.GetSimEvents().Values)
				{
					if (Operators.CompareString(current.Description.ToLower(), text.ToLower(), false) == 0 || Operators.CompareString(current.GetGuid(), text, false) == 0)
					{
						simEvent = current;
					}
				}
				if (Information.IsNothing(simEvent))
				{
					throw new Exception2("Unable to identify the desired Event!");
				}
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				string text2 = null;
				string text3 = null;
				if (objectGeoLocation.ContainsKey("Type".ToUpper()))
				{
					string text4 = null;
					try
					{
						text2 = objectGeoLocation["Type".ToUpper()].ToString();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						throw new Exception2("Unable to parse event Type!");
					}
					string left = text2.ToUpper();
					if (Operators.CompareString(left, "ADD_CONDITION", false) != 0 && Operators.CompareString(left, "REMOVE_CONDITION", false) != 0 && Operators.CompareString(left, "REPLACE_CONDITION", false) != 0)
					{
						if (Operators.CompareString(left, "ADD_ACTION", false) == 0 || Operators.CompareString(left, "REMOVE_ACTION", false) == 0 || Operators.CompareString(left, "REPLACE_ACTION", false) == 0)
						{
							EventAction_LuaScript eventAction_LuaScript = new EventAction_LuaScript();
							string left2 = text2.ToUpper();
							if (Operators.CompareString(left2, "ADD_ACTION", false) != 0)
							{
								if (Operators.CompareString(left2, "REMOVE_ACTION", false) != 0)
								{
									if (Operators.CompareString(left2, "REPLACE_ACTION", false) == 0)
									{
										EventAction eventAction = null;
										if (objectGeoLocation.ContainsKey("Description".ToUpper()))
										{
											try
											{
												text4 = objectGeoLocation["Description".ToUpper()].ToString();
											}
											catch (Exception projectError2)
											{
												ProjectData.SetProjectError(projectError2);
												throw new Exception2("Unable to parse event Description!");
											}
											foreach (EventAction current2 in scenario_0.GetEventActions().Values)
											{
												if ((Operators.CompareString(current2.strDescription.ToUpper(), text4.ToUpper(), false) == 0 || Operators.CompareString(current2.GetGuid().ToUpper(), text4.ToUpper(), false) == 0) && current2 is EventAction_LuaScript)
												{
													eventAction = current2;
													break;
												}
											}
											if (eventAction == null)
											{
												throw new Exception2("Event action not found!");
											}
											if (objectGeoLocation.ContainsKey("Script".ToUpper()))
											{
												try
												{
													text4 = objectGeoLocation["Script".ToUpper()].ToString();
												}
												catch (Exception projectError3)
												{
													ProjectData.SetProjectError(projectError3);
													throw new Exception2("Unable to parse event Script!");
												}
												eventAction_LuaScript = (EventAction_LuaScript)eventAction;
												text3 = ((EventAction_LuaScript)eventAction).ScriptText;
												((EventAction_LuaScript)eventAction).ScriptText = text4;
												flag = true;
											}
										}
									}
								}
								else
								{
									EventAction eventAction2 = null;
									if (objectGeoLocation.ContainsKey("Description".ToUpper()))
									{
										try
										{
											text4 = objectGeoLocation["Description".ToUpper()].ToString();
										}
										catch (Exception projectError4)
										{
											ProjectData.SetProjectError(projectError4);
											throw new Exception2("Unable to parse event Description!");
										}
										foreach (EventAction current3 in scenario_0.GetEventActions().Values)
										{
											if ((Operators.CompareString(current3.strDescription.ToUpper(), text4.ToUpper(), false) == 0 || Operators.CompareString(current3.GetGuid().ToUpper(), text4.ToUpper(), false) == 0) && current3 is EventAction_LuaScript)
											{
												eventAction2 = current3;
												break;
											}
										}
										if (eventAction2 == null)
										{
											throw new Exception2("Event action not found!");
										}
										simEvent.Actions.Remove(eventAction2);
										scenario_0.GetEventActions().Remove(eventAction2.GetGuid());
										eventAction_LuaScript = (EventAction_LuaScript)eventAction2;
										flag = true;
									}
								}
							}
							else
							{
								if (objectGeoLocation.ContainsKey("Description".ToUpper()))
								{
									try
									{
										text4 = objectGeoLocation["Description".ToUpper()].ToString();
									}
									catch (Exception projectError5)
									{
										ProjectData.SetProjectError(projectError5);
										throw new Exception2("Unable to parse event Description!");
									}
									eventAction_LuaScript.strDescription = text4;
								}
								if (objectGeoLocation.ContainsKey("Script".ToUpper()))
								{
									try
									{
										text4 = objectGeoLocation["Script".ToUpper()].ToString();
									}
									catch (Exception projectError6)
									{
										ProjectData.SetProjectError(projectError6);
										throw new Exception2("Unable to parse event Script!");
									}
									eventAction_LuaScript.ScriptText = text4;
								}
								if (eventAction_LuaScript.ScriptText != null)
								{
									simEvent.Actions.Add(eventAction_LuaScript);
									scenario_0.GetEventActions().Add(eventAction_LuaScript.GetGuid(), eventAction_LuaScript);
									flag = true;
								}
							}
							luaTable["type"] = "ACTION";
							luaTable["description"] = eventAction_LuaScript.strDescription;
							luaTable["guid"] = eventAction_LuaScript.GetGuid();
							if (text3 == null)
							{
								luaTable["script"] = eventAction_LuaScript.ScriptText;
							}
							else
							{
								luaTable["script"] = text3;
							}
						}
					}
					else
					{
						EventCondition_LuaScript eventCondition_LuaScript = new EventCondition_LuaScript();
						string left3 = text2.ToUpper();
						if (Operators.CompareString(left3, "ADD_CONDITION", false) != 0)
						{
							if (Operators.CompareString(left3, "REMOVE_CONDITION", false) != 0)
							{
								if (Operators.CompareString(left3, "REPLACE_CONDITION", false) == 0)
								{
									EventCondition eventCondition = null;
									if (objectGeoLocation.ContainsKey("Description".ToUpper()))
									{
										try
										{
											text4 = objectGeoLocation["Description".ToUpper()].ToString();
										}
										catch (Exception projectError7)
										{
											ProjectData.SetProjectError(projectError7);
											throw new Exception2("Unable to parse event Description!");
										}
										foreach (EventCondition current4 in scenario_0.GetEventConditions().Values)
										{
											if ((Operators.CompareString(current4.strDescription.ToUpper(), text4.ToUpper(), false) == 0 || Operators.CompareString(current4.GetGuid().ToUpper(), text4.ToUpper(), false) == 0) && current4 is EventCondition_LuaScript)
											{
												eventCondition = current4;
												break;
											}
										}
										if (eventCondition == null)
										{
											throw new Exception2("Event condition not found!");
										}
										if (objectGeoLocation.ContainsKey("Script".ToUpper()))
										{
											try
											{
												text4 = objectGeoLocation["Script".ToUpper()].ToString();
											}
											catch (Exception projectError8)
											{
												ProjectData.SetProjectError(projectError8);
												throw new Exception2("Unable to parse event Script!");
											}
											eventCondition_LuaScript = (EventCondition_LuaScript)eventCondition;
											text3 = ((EventCondition_LuaScript)eventCondition).ScriptText;
											((EventCondition_LuaScript)eventCondition).ScriptText = text4;
											flag = true;
										}
									}
								}
							}
							else if (objectGeoLocation.ContainsKey("Description".ToUpper()))
							{
								EventCondition eventCondition2 = null;
								try
								{
									text4 = objectGeoLocation["Description".ToUpper()].ToString();
								}
								catch (Exception projectError9)
								{
									ProjectData.SetProjectError(projectError9);
									throw new Exception2("Unable to parse event Description!");
								}
								foreach (EventCondition current5 in scenario_0.GetEventConditions().Values)
								{
									if ((Operators.CompareString(current5.strDescription.ToUpper(), text4.ToUpper(), false) == 0 || Operators.CompareString(current5.GetGuid().ToUpper(), text4.ToUpper(), false) == 0) && current5 is EventCondition_LuaScript)
									{
										eventCondition2 = current5;
										break;
									}
								}
								if (eventCondition2 == null)
								{
									throw new Exception2("Event condition not found!");
								}
								simEvent.Conditions.Remove(eventCondition2);
								scenario_0.GetEventConditions().Remove(eventCondition2.GetGuid());
								eventCondition_LuaScript = (EventCondition_LuaScript)eventCondition2;
								flag = true;
							}
						}
						else
						{
							if (objectGeoLocation.ContainsKey("Description".ToUpper()))
							{
								try
								{
									text4 = objectGeoLocation["Description".ToUpper()].ToString();
								}
								catch (Exception projectError10)
								{
									ProjectData.SetProjectError(projectError10);
									throw new Exception2("Unable to parse event Description!");
								}
								eventCondition_LuaScript.strDescription = text4;
							}
							if (objectGeoLocation.ContainsKey("Script".ToUpper()))
							{
								try
								{
									text4 = objectGeoLocation["Script".ToUpper()].ToString();
								}
								catch (Exception projectError11)
								{
									ProjectData.SetProjectError(projectError11);
									throw new Exception2("Unable to parse event Script!");
								}
								eventCondition_LuaScript.ScriptText = text4;
							}
							if (eventCondition_LuaScript.ScriptText != null)
							{
								simEvent.Conditions.Add(eventCondition_LuaScript);
								scenario_0.GetEventConditions().Add(eventCondition_LuaScript.GetGuid(), eventCondition_LuaScript);
								flag = true;
							}
						}
						luaTable["type"] = "CONDITION";
						luaTable["description"] = eventCondition_LuaScript.strDescription;
						luaTable["guid"] = eventCondition_LuaScript.GetGuid();
						if (text3 == null)
						{
							luaTable["script"] = eventCondition_LuaScript.ScriptText;
						}
						else
						{
							luaTable["script"] = text3;
						}
					}
				}
				if (luaTable.Keys.Count == 0)
				{
					result = flag;
				}
				else
				{
					result = luaTable;
				}
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x003558C4 File Offset: 0x00353AC4
		public static LuaTable smethod_3(string string_0, Scenario scenario_0)
		{
			LuaTable result;
			try
			{
				string right = string_0.ToLower();
				SimEvent simEvent = null;
				foreach (SimEvent current in scenario_0.GetSimEvents().Values)
				{
					if (Operators.CompareString(current.Description.ToLower(), right, false) == 0 || Operators.CompareString(current.GetGuid(), right, false) == 0)
					{
						simEvent = current;
					}
				}
				if (Information.IsNothing(simEvent))
				{
					throw new Exception2("Unable to identify the desired Event!");
				}
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				luaTable["guid"] = simEvent.GetGuid();
				luaTable["description"] = simEvent.Description;
				luaTable["isActive"] = simEvent.IsActive;
				luaTable["isRepeatable"] = simEvent.IsRepeatable;
				luaTable["isShown"] = simEvent.IsShown;
				luaTable["probability"] = simEvent.Probability;
				LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
				foreach (EventTrigger current2 in simEvent.Triggers)
				{
					LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
					luaTable3["type"] = current2.eventTriggerType.ToString();
					luaTable3["description"] = current2.strDescription;
					luaTable3["name"] = current2.Name;
					luaTable2[luaTable2.Keys.Count + 1] = luaTable3;
				}
				luaTable["triggers"] = luaTable2;
				luaTable2 = LuaSandBox.Singleton().CreateTable();
				foreach (EventCondition current3 in simEvent.Conditions)
				{
					LuaTable luaTable4 = LuaSandBox.Singleton().CreateTable();
					luaTable4["type"] = current3.eventConditionType.ToString();
					luaTable4["description"] = current3.strDescription;
					luaTable4["name"] = current3.Name;
					luaTable2[luaTable2.Keys.Count + 1] = luaTable4;
				}
				luaTable["conditions"] = luaTable2;
				luaTable2 = LuaSandBox.Singleton().CreateTable();
				foreach (EventAction current4 in simEvent.Actions)
				{
					LuaTable luaTable5 = LuaSandBox.Singleton().CreateTable();
					luaTable5["type"] = current4.eventActionType.ToString();
					luaTable5["description"] = current4.strDescription;
					luaTable5["name"] = current4.Name;
					luaTable2[luaTable2.Keys.Count + 1] = luaTable5;
				}
				luaTable["actions"] = luaTable2;
				result = luaTable;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x00355CA4 File Offset: 0x00353EA4
		public static bool smethod_4(LuaTable luaTable_0, Scenario scenario_0)
		{
			bool result = false;
			checked
			{
				try
				{
					Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
					if (!objectGeoLocation.ContainsKey("ActionNameOrID".ToUpper()))
					{
						throw new Exception2("Missing mandatory variable 'ActionNameOrID'");
					}
					string right = objectGeoLocation["ActionNameOrID".ToUpper()].ToString().ToLower();
					SpecialAction specialAction = null;
					Side[] sides = scenario_0.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						Dictionary<string, SpecialAction>.ValueCollection.Enumerator enumerator = side.SpecialActions.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								SpecialAction current = enumerator.Current;
								if (Operators.CompareString(current.Name.ToLower(), right, false) == 0 || Operators.CompareString(current.Description.ToLower(), right, false) == 0 || Operators.CompareString(current.GetGuid().ToLower(), right, false) == 0)
								{
									specialAction = current;
								}
							}
						}
						finally
						{
							IDisposable disposable = enumerator;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
					}
					if (Information.IsNothing(specialAction))
					{
						throw new Exception2("Unable to identify the desired Special Action!");
					}
					if (objectGeoLocation.ContainsKey("NewName".ToUpper()))
					{
						string name = "";
						try
						{
							name = objectGeoLocation["NewName".ToUpper()].ToString();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							throw new Exception2("Unable to parse value NewName to string!");
						}
						specialAction.Name = name;
					}
					if (objectGeoLocation.ContainsKey("Description".ToUpper()))
					{
						string description = "";
						try
						{
							description = objectGeoLocation["Description".ToUpper()].ToString();
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							throw new Exception2("Unable to parse value Description to string!");
						}
						specialAction.Description = description;
					}
					if (objectGeoLocation.ContainsKey("IsActive".ToUpper()))
					{
						bool isActive = false;
						try
						{
							isActive = Conversions.ToBoolean(objectGeoLocation["IsActive".ToUpper()].ToString());
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							throw new Exception2("Unable to parse value IsActive to true/false!");
						}
						specialAction.IsActive = isActive;
					}
					if (objectGeoLocation.ContainsKey("IsRepeatable".ToUpper()))
					{
						bool isRepeatable = false;
						try
						{
							isRepeatable = Conversions.ToBoolean(objectGeoLocation["IsRepeatable".ToUpper()].ToString());
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							throw new Exception2("Unable to parse IsRepeatable to true/false!");
						}
						specialAction.IsRepeatable = isRepeatable;
					}
					result = true;
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
				return result;
			}
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x00355FC0 File Offset: 0x003541C0
		public static LuaTable smethod_5(LuaTable luaTable_0, Scenario scenario_0)
		{
			checked
			{
				LuaTable result;
				try
				{
					Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
					if (!objectGeoLocation.ContainsKey("ActionNameOrID".ToUpper()))
					{
						throw new Exception2("Missing mandatory variable 'ActionNameOrID'");
					}
					string text = objectGeoLocation["ActionNameOrID".ToUpper()].ToString().ToUpper();
					SpecialAction specialAction = null;
					Side[] sides = scenario_0.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						Dictionary<string, SpecialAction>.ValueCollection.Enumerator enumerator = side.SpecialActions.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								SpecialAction current = enumerator.Current;
								if (Operators.CompareString(current.Name.ToUpper(), text, false) == 0 || Operators.CompareString(current.Description.ToUpper(), text, false) == 0 || Operators.CompareString(current.GetGuid(), text.ToLower(), false) == 0)
								{
									specialAction = current;
								}
							}
						}
						finally
						{
							IDisposable disposable = enumerator;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
					}
					if (Information.IsNothing(specialAction))
					{
						throw new Exception2("Unable to identify the desired Special Action!");
					}
					LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
					luaTable["guid"] = specialAction.GetGuid();
					luaTable["name"] = specialAction.Name;
					luaTable["description"] = specialAction.Description;
					luaTable["isActive"] = specialAction.IsActive;
					luaTable["IsRepeatable"] = specialAction.IsRepeatable;
					result = luaTable;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
				return result;
			}
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x003561A8 File Offset: 0x003543A8
		public static string smethod_6(string string_0, Scenario scenario_0)
		{
			string right = string_0.ToLower();
			SpecialAction specialAction = null;
			Side[] sides = scenario_0.GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					Dictionary<string, SpecialAction>.ValueCollection.Enumerator enumerator = side.SpecialActions.Values.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							SpecialAction current = enumerator.Current;
							if (Operators.CompareString(current.Name.ToLower(), right, false) == 0 || Operators.CompareString(current.Description.ToLower(), right, false) == 0 || Operators.CompareString(current.GetGuid(), right, false) == 0)
							{
								specialAction = current;
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
				}
				string result;
				if (specialAction == null)
				{
					result = null;
				}
				else
				{
					result = specialAction.ScriptText;
				}
				return result;
			}
		}

		// Token: 0x0600669E RID: 26270 RVA: 0x0035629C File Offset: 0x0035449C
		public static string smethod_7(bool bool_0, Scenario scenario_0)
		{
			StringBuilder sb = new StringBuilder();
			StringWriter stringWriter = new StringWriter(sb);
			XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
			if (!bool_0)
			{
				xmlTextWriter.Formatting = Formatting.Indented;
				xmlTextWriter.Indentation = 4;
			}
			checked
			{
				try
				{
					HashSet<string> hashSet_ = new HashSet<string>();
					using (xmlTextWriter)
					{
						xmlTextWriter.WriteStartElement("EventTriggers");
						using (IEnumerator<EventTrigger> enumerator = scenario_0.GetEventTriggers().Values.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								enumerator.Current.Save(xmlTextWriter, hashSet_, scenario_0);
							}
						}
						xmlTextWriter.WriteEndElement();
						xmlTextWriter.WriteStartElement("EventConditions");
						using (IEnumerator<EventCondition> enumerator2 = scenario_0.GetEventConditions().Values.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								enumerator2.Current.Save(xmlTextWriter, hashSet_, scenario_0);
							}
						}
						xmlTextWriter.WriteEndElement();
						xmlTextWriter.WriteStartElement("EventActions");
						using (IEnumerator<EventAction> enumerator3 = scenario_0.GetEventActions().Values.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.Save(xmlTextWriter, hashSet_, scenario_0);
							}
						}
						xmlTextWriter.WriteEndElement();
						xmlTextWriter.WriteStartElement("SimEvents");
						using (IEnumerator<SimEvent> enumerator4 = scenario_0.GetSimEvents().Values.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.Save(xmlTextWriter, hashSet_, scenario_0);
							}
						}
						xmlTextWriter.WriteEndElement();
						Side[] sides = scenario_0.GetSides();
						for (int i = 0; i < sides.Length; i++)
						{
							Side side = sides[i];
							if (side.SpecialActions.Any<KeyValuePair<string, SpecialAction>>())
							{
								xmlTextWriter.WriteStartElement("SpecialActions");
								using (Dictionary<string, SpecialAction>.ValueCollection.Enumerator enumerator5 = side.SpecialActions.Values.GetEnumerator())
								{
									while (enumerator5.MoveNext())
									{
										enumerator5.Current.Save(xmlTextWriter, hashSet_, scenario_0);
									}
								}
								xmlTextWriter.WriteEndElement();
							}
						}
					}
					hashSet_ = null;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return stringWriter.ToString();
			}
		}
	}
}
