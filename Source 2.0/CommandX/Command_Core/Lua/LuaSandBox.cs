using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using KeraLua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using NLua.Exceptions;
using ns0;
using ns3;
using ns4;

namespace Command_Core.Lua
{
	// Token: 0x02000C30 RID: 3120
	[Attribute1]
	public sealed class LuaSandBox
	{
		// Token: 0x14000026 RID: 38
		// (add) Token: 0x060067FE RID: 26622 RVA: 0x0036CCA8 File Offset: 0x0036AEA8
		// (remove) Token: 0x060067FF RID: 26623 RVA: 0x0036CCE4 File Offset: 0x0036AEE4
		public event LuaSandBox.LuaPrintEventHandler LuaPrint
		{
			[CompilerGenerated]
			add
			{
				LuaSandBox.LuaPrintEventHandler luaPrintEventHandler = this.LuaPrintEvent;
				LuaSandBox.LuaPrintEventHandler luaPrintEventHandler2;
				do
				{
					luaPrintEventHandler2 = luaPrintEventHandler;
					LuaSandBox.LuaPrintEventHandler value2 = (LuaSandBox.LuaPrintEventHandler)Delegate.Combine(luaPrintEventHandler2, value);
					luaPrintEventHandler = Interlocked.CompareExchange<LuaSandBox.LuaPrintEventHandler>(ref this.LuaPrintEvent, value2, luaPrintEventHandler2);
				}
				while (luaPrintEventHandler != luaPrintEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				LuaSandBox.LuaPrintEventHandler luaPrintEventHandler = this.LuaPrintEvent;
				LuaSandBox.LuaPrintEventHandler luaPrintEventHandler2;
				do
				{
					luaPrintEventHandler2 = luaPrintEventHandler;
					LuaSandBox.LuaPrintEventHandler value2 = (LuaSandBox.LuaPrintEventHandler)Delegate.Remove(luaPrintEventHandler2, value);
					luaPrintEventHandler = Interlocked.CompareExchange<LuaSandBox.LuaPrintEventHandler>(ref this.LuaPrintEvent, value2, luaPrintEventHandler2);
				}
				while (luaPrintEventHandler != luaPrintEventHandler2);
			}
		}

		// Token: 0x06006800 RID: 26624 RVA: 0x0036CD20 File Offset: 0x0036AF20
		public static LuaSandBox Singleton()
		{
			return LuaSandBox._LuaSandbox;
		}

		// Token: 0x06006801 RID: 26625 RVA: 0x0036CD34 File Offset: 0x0036AF34
		public LuaTable CreateTable()
		{
			return (LuaTable)this.lua.DoString("return {}", "chunk").First<object>();
		}

		// Token: 0x06006802 RID: 26626 RVA: 0x0036CD64 File Offset: 0x0036AF64
		public int SB_Getinfo(string string_0, ref LuaDebug luaDebug_0)
		{
			LuaDebug luaDebug = default(LuaDebug);
			int result = 0;
			try
			{
				result = this.lua.GetStack(1, ref luaDebug);
				result = this.lua.GetInfo(string_0, ref luaDebug);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			luaDebug_0 = luaDebug;
			return result;
		}

		// Token: 0x06006803 RID: 26627 RVA: 0x0036CDC4 File Offset: 0x0036AFC4
		public NLua.Lua SB_Lua()
		{
			return this.lua;
		}

		// Token: 0x06006804 RID: 26628 RVA: 0x0002CEC0 File Offset: 0x0002B0C0
		public LuaSandBox(Scenario scenario_0)
		{
			this.currentFunction = "";
			this.currentLine = 0;
			this.lastError = "";
			this.Initialize();
			this.ScenarioContext = scenario_0;
		}

		// Token: 0x06006805 RID: 26629 RVA: 0x0036CDDC File Offset: 0x0036AFDC
		public void Initialize()
		{
			LuaSandBox._LuaSandbox = this;
			this.SecurityString = "collectgarbage=nil\r\ndofile=nil\r\nio=nil\r\nload=nil\r\nloadfile=nil\r\nloadstring=nil\r\nrawequal=nil\r\nrawget=nil\r\nrawset=nil\r\nmodule=nil\r\nrequire=nil\r\npackage.loaded=nil\r\npackage.loaders=nil\r\npackage.loadlib=nil\r\npackage.path=nil\r\npackage.cpath=nil\r\npackage.preload=nil\r\npackage.seeall=nil\r\nstring.dump=nil\r\nos.execute=nil\r\nos.exit=nil\r\nos.getenv=nil\r\nos.remove=nil\r\nos.rename=nil\r\nos.tmpname=nil\r\nnewproxy=nil";
			this.lua = new NLua.Lua();
			this.lua.LoadCLRPackage();
			MethodInfo method = base.GetType().GetMethod("LUA_Echo");
			this.lua.RegisterFunction("Echo", this, method);
			LuaSandBox.LuaMethods.Clear();
			this.RegisterFunction("GetScenarioTitle", base.GetType().GetMethod("LUA_GetScenarioTitle"));
			LuaSandBox.LuaMethods.Add("GetScenarioTitle()");
			this.RegisterFunction("VP_GetSide", base.GetType().GetMethod("LUA_VP_GetSide"));
			LuaSandBox.LuaMethods.Add("VP_GetSide(table)");
			this.RegisterFunction("VP_GetUnit", base.GetType().GetMethod("LUA_VP_GetUnit"));
			LuaSandBox.LuaMethods.Add("VP_GetUnit(table)");
			this.RegisterFunction("VP_GetContact", base.GetType().GetMethod("LUA_VP_GetContact"));
			LuaSandBox.LuaMethods.Add("VP_GetContact(table)");
			this.RegisterFunction("ScenEdit_AddAircraft", base.GetType().GetMethod("LUA_ScenEdit_AddAircraft"));
			this.RegisterFunction("ScenEdit_AddShip", base.GetType().GetMethod("LUA_ScenEdit_AddShip"));
			this.RegisterFunction("ScenEdit_AddSubmarine", base.GetType().GetMethod("LUA_ScenEdit_AddSubmarine"));
			this.RegisterFunction("ScenEdit_AddFacility", base.GetType().GetMethod("LUA_ScenEdit_AddFacility"));
			this.RegisterFunction("ScenEdit_AssignUnitToMission", base.GetType().GetMethod("LUA_ScenEdit_AssignUnitToMission"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AssignUnitToMission('AUNameOrID', 'MissionNameOrID')");
			this.RegisterFunction("ScenEdit_SetWeather", base.GetType().GetMethod("LUA_ScenEdit_SetWeather"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetWeather(AvgTemp, RainfallRate, FractionUnderRain, SeaState)");
			this.RegisterFunction("ScenEdit_GetWeather", base.GetType().GetMethod("LUA_ScenEdit_GetWeather"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetWeather( table )");
			this.RegisterFunction("ScenEdit_SetSidePosture", base.GetType().GetMethod("LUA_ScenEdit_SetSidePosture"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetSidePosture('SideANameOrID', 'SideBNameOrID', 'PostureCode')");
			this.RegisterFunction("ScenEdit_GetSidePosture", base.GetType().GetMethod("LUA_ScenEdit_GetSidePosture"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetSidePosture('SideANameOrID', 'SideBNameOrID')");
			this.RegisterFunction("ScenEdit_GetSideIsHuman", base.GetType().GetMethod("LUA_ScenEdit_GetSideIsHuman"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetSideIsHuman('SideANameOrID')");
			this.RegisterFunction("ScenEdit_GetScenHasStarted", base.GetType().GetMethod("LUA_ScenEdit_GetScenHasStarted"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetScenHasStarted()");
			this.RegisterFunction("ScenEdit_SetEMCON", base.GetType().GetMethod("LUA_ScenEdit_SetEMCON"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetEMCON('EMCONSubjectType', 'EMCONSubjectNameOrID', 'EMCONSettings')");
			this.RegisterFunction("ScenEdit_MsgBox", base.GetType().GetMethod("LUA_ScenEdit_MsgBox"));
			LuaSandBox.LuaMethods.Add("ScenEdit_MsgBox('str', style)");
			this.RegisterFunction("ScenEdit_RunScript", base.GetType().GetMethod("LUA_ScenEdit_RunScript"));
			LuaSandBox.LuaMethods.Add("ScenEdit_RunScript('str')");
			this.RegisterFunction("ScenEdit_AddUnit", base.GetType().GetMethod("LUA_ScenEdit_AddUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AddUnit(table)");
			this.RegisterFunction("ScenEdit_UpdateUnit", base.GetType().GetMethod("LUA_ScenEdit_UpdateUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_UpdateUnit(table)");
			this.RegisterFunction("ScenEdit_SetUnit", base.GetType().GetMethod("LUA_ScenEdit_SetUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetUnit(table)");
			this.RegisterFunction("ScenEdit_GetUnit", base.GetType().GetMethod("LUA_ScenEdit_GetUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetUnit(table)");
			this.RegisterFunction("ScenEdit_SetKeyValue", base.GetType().GetMethod("LUA_ScenEdit_SetKeyValue"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetKeyValue('key', 'value')");
			this.RegisterFunction("ScenEdit_GetKeyValue", base.GetType().GetMethod("LUA_ScenEdit_GetKeyValue"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetKeyValue('key')");
			this.RegisterFunction("ScenEdit_DeleteUnit", base.GetType().GetMethod("LUA_ScenEdit_DeleteUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_DeleteUnit(table)");
			this.RegisterFunction("ScenEdit_KillUnit", base.GetType().GetMethod("LUA_ScenEdit_KillUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_KillUnit(table)");
			this.RegisterFunction("ScenEdit_SetSpecialAction", base.GetType().GetMethod("LUA_ScenEdit_SetSpecialAction"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetSpecialAction(table)");
			this.RegisterFunction("ScenEdit_SetUnitSide", base.GetType().GetMethod("LUA_ScenEdit_SetUnitSide"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetUnitSide(table)");
			this.RegisterFunction("ScenEdit_AddReferencePoint", base.GetType().GetMethod("LUA_ScenEdit_AddReferencePoint"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AddReferencePoint(table)");
			this.RegisterFunction("ScenEdit_AddExplosion", base.GetType().GetMethod("LUA_ScenEdit_AddExplosion"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AddExplosion(table)");
			this.RegisterFunction("ScenEdit_SetReferencePoint", base.GetType().GetMethod("LUA_ScenEdit_SetReferencePoint"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetReferencePoint(table)");
			this.RegisterFunction("ScenEdit_GetReferencePoint", base.GetType().GetMethod("LUA_ScenEdit_GetReferencePoint"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetReferencePoint(table)");
			this.RegisterFunction("ScenEdit_GetReferencePoints", base.GetType().GetMethod("LUA_ScenEdit_GetReferencePoints"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetReferencePoints(table)");
			this.RegisterFunction("ScenEdit_DeleteReferencePoint", base.GetType().GetMethod("LUA_ScenEdit_DeleteReferencePoint"));
			LuaSandBox.LuaMethods.Add("ScenEdit_DeleteReferencePoint(table)");
			this.RegisterFunction("print", base.GetType().GetMethod("LUA_ScenEdit_Print"));
			LuaSandBox.LuaMethods.Add("print(obj)");
			this.RegisterFunction("ScenEdit_SetDoctrine", base.GetType().GetMethod("LUA_ScenEdit_SetDoctrine"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetDoctrine(table,doctrine)");
			this.RegisterFunction("ScenEdit_SetDoctrineWRA", base.GetType().GetMethod("LUA_ScenEdit_SetDoctrineWRA"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetDoctrineWRA(table)");
			this.RegisterFunction("ScenEdit_GetDoctrine", base.GetType().GetMethod("LUA_ScenEdit_GetDoctrine"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetDoctrine(table)");
			this.RegisterFunction("ScenEdit_GetDoctrineWRA", base.GetType().GetMethod("LUA_ScenEdit_GetDoctrineWRA"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetDoctrineWRA(table)");
			this.RegisterFunction("ScenEdit_HostUnitToParent", base.GetType().GetMethod("LUA_ScenEdit_HostUnitToParent"));
			LuaSandBox.LuaMethods.Add("ScenEdit_HostUnitToParent(table)");
			this.RegisterFunction("ScenEdit_CurrentTime", base.GetType().GetMethod("LUA_ScenEdit_CurrentTime"));
			LuaSandBox.LuaMethods.Add("ScenEdit_CurrentTime()");
			this.RegisterFunction("ScenEdit_UnitX", base.GetType().GetMethod("LUA_ScenEdit_UnitX"));
			LuaSandBox.LuaMethods.Add("ScenEdit_UnitX()");
			this.RunScript("UnitX = ScenEdit_UnitX", false, "Initializing");
			this.RegisterFunction("ScenEdit_UseAttachment", base.GetType().GetMethod("LUA_ScenEdit_UseAttachment"));
			LuaSandBox.LuaMethods.Add("ScenEdit_UseAttachment('AttachmentNameOrID')");
			this.RegisterFunction("ScenEdit_UseAttachmentOnSide", base.GetType().GetMethod("LUA_ScenEdit_UseAttachmentOnSide"));
			LuaSandBox.LuaMethods.Add("ScenEdit_UseAttachmentOnSide('AttachmentNameOrID', 'SideNameOrID')");
			this.RegisterFunction("ScenEdit_GetScore", base.GetType().GetMethod("LUA_ScenEdit_GetScore"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetScore('SideNameOrID')");
			this.RegisterFunction("ScenEdit_SetLoadout", base.GetType().GetMethod("LUA_ScenEdit_SetLoadout"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetLoadout(table)");
			this.RegisterFunction("ScenEdit_SetScore", base.GetType().GetMethod("LUA_ScenEdit_SetScore"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetScore('SideNameOrID',Score,'ReasonForChange')");
			this.RegisterFunction("ScenEdit_SpecialMessage", base.GetType().GetMethod("LUA_ScenEdit_SpecialMessage"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SpecialMessage('SideNameOrID','Text')");
			this.RegisterFunction("ScenEdit_PlayerSide", base.GetType().GetMethod("LUA_ScenEdit_PlayerSide"));
			LuaSandBox.LuaMethods.Add("ScenEdit_PlayerSide()");
			this.RegisterFunction("ScenEdit_EndScenario", base.GetType().GetMethod("LUA_ScenEdit_EndScenario"));
			LuaSandBox.LuaMethods.Add("ScenEdit_EndScenario()");
			this.RegisterFunction("ScenEdit_ImportInst", base.GetType().GetMethod("LUA_ScenEdit_ImportInst"));
			LuaSandBox.LuaMethods.Add("ScenEdit_ImportInst('SideNameOrID', 'InstFile')");
			this.RegisterFunction("ScenEdit_AddWeaponToUnitMagazine", base.GetType().GetMethod("LUA_ScenEdit_AddWeaponToUnitMagazine"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AddWeaponToUnitMagazine(table)");
			this.RegisterFunction("ScenEdit_AddReloadsToUnit", base.GetType().GetMethod("LUA_ScenEdit_AddReloadsToUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AddReloadsToUnit(table)");
			this.RegisterFunction("ScenEdit_GetSideOptions", base.GetType().GetMethod("LUA_ScenEdit_GetSideOptions"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetSideOptions(table)");
			this.RegisterFunction("ScenEdit_SetSideOptions", base.GetType().GetMethod("LUA_ScenEdit_SetSideOptions"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetSideOptions(table)");
			this.RegisterFunction("ScenEdit_SetUnitDamage", base.GetType().GetMethod("LUA_ScenEdit_SetUnitDamage"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetUnitDamage(table)");
			this.RegisterFunction("ScenEdit_GetMission", base.GetType().GetMethod("LUA_ScenEdit_GetMission"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetMission('SideNameOrID', 'MissionNameOrID')");
			this.RegisterFunction("ScenEdit_SetMission", base.GetType().GetMethod("LUA_ScenEdit_SetMission"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetMission('SideNameOrID', 'MissionNameOrID',table)");
			this.RegisterFunction("ScenEdit_AddMission", base.GetType().GetMethod("LUA_ScenEdit_AddMission"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AddMission('SideNameOrID', 'MissionNameOrID', 'MissionType', table)");
			this.RegisterFunction("ScenEdit_DeleteMission", base.GetType().GetMethod("LUA_ScenEdit_DeleteMission"));
			LuaSandBox.LuaMethods.Add("ScenEdit_DeleteMission('SideNameOrID', 'MissionNameOrID')");
			this.RegisterFunction("ScenEdit_ImportMission", base.GetType().GetMethod("LUA_ScenEdit_ImportMission"));
			LuaSandBox.LuaMethods.Add("ScenEdit_ImportMission('SideNameOrID', 'MissionNameOrID')");
			this.RegisterFunction("ScenEdit_ExportMission", base.GetType().GetMethod("LUA_ScenEdit_ExportMission"));
			LuaSandBox.LuaMethods.Add("ScenEdit_ExportMission('SideNameOrID', 'MissionNameOrID')");
			this.RegisterFunction("ScenEdit_AssignUnitAsTarget", base.GetType().GetMethod("LUA_ScenEdit_AssignUnitAsTarget"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AssignUnitAsTarget('AUNameOrID', 'MissionNameOrID')");
			this.RegisterFunction("ScenEdit_RemoveUnitAsTarget", base.GetType().GetMethod("LUA_ScenEdit_RemoveUnitAsTarget"));
			LuaSandBox.LuaMethods.Add("ScenEdit_RemoveUnitAsTarget('AUNameOrID', 'MissionNameOrID')");
			this.RegisterFunction("ScenEdit_RefuelUnit", base.GetType().GetMethod("LUA_ScenEdit_RefuelUnit"));
			LuaSandBox.LuaMethods.Add("ScenEdit_RefuelUnit(table)");
			this.RegisterFunction("ScenEdit_ExecuteEventAction", base.GetType().GetMethod("LUA_ScenEdit_ExecuteEventAction"));
			LuaSandBox.LuaMethods.Add("ScenEdit_ExecuteEventAction('EventNameOrId')");
			this.RegisterFunction("ScenEdit_SetEvent", base.GetType().GetMethod("LUA_ScenEdit_SetEvent"));
			LuaSandBox.LuaMethods.Add("ScenEdit_SetEvent('EventNameOrId', table)");
			this.RegisterFunction("ScenEdit_GetEvent", base.GetType().GetMethod("LUA_ScenEdit_GetEvent"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetEvent('EventNameOrId')");
			this.RegisterFunction("ScenEdit_UpdateEvent", base.GetType().GetMethod("LUA_ScenEdit_UpdateEvent"));
			LuaSandBox.LuaMethods.Add("ScenEdit_UpdateEvent('EventNameOrId', table)");
			this.RegisterFunction("ScenEdit_GetSpecialAction", base.GetType().GetMethod("LUA_ScenEdit_GetSpecialAction"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetSpecialAction(table)");
			this.RegisterFunction("ScenEdit_ExecuteSpecialAction", base.GetType().GetMethod("LUA_ScenEdit_ExecuteSpecialAction"));
			LuaSandBox.LuaMethods.Add("ScenEdit_ExecuteSpecialAction('EventNameOrId')");
			this.RegisterFunction("ScenEdit_GetContacts", base.GetType().GetMethod("LUA_ScenEdit_GetContacts"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetContacts('SideName')");
			this.RegisterFunction("ScenEdit_FillMagsForLoadout", base.GetType().GetMethod("LUA_ScenEdit_FillMagsForLoadout"));
			LuaSandBox.LuaMethods.Add("ScenEdit_FillMagsForLoadout(table)");
			this.RegisterFunction("ScenEdit_GetContact", base.GetType().GetMethod("LUA_ScenEdit_GetContact"));
			LuaSandBox.LuaMethods.Add("ScenEdit_GetContact(table)");
			this.RegisterFunction("ScenEdit_AttackContact", base.GetType().GetMethod("LUA_ScenEdit_AttackContact"));
			LuaSandBox.LuaMethods.Add("ScenEdit_AttackContact('AttackerNameOrId','ContactNameOrId', table)");
			this.RegisterFunction("World_GetElevation", base.GetType().GetMethod("LUA_World_GetElevation"));
			LuaSandBox.LuaMethods.Add("World_GetElevation(table)");
			this.RegisterFunction("World_GetCircleFromPoint", base.GetType().GetMethod("LUA_World_GetCircleFromPoint"));
			LuaSandBox.LuaMethods.Add("World_GetCircleFromPoint(table)");
			this.RegisterFunction("Tool_DumpEvents", base.GetType().GetMethod("Tool_DumpEvents"));
			LuaSandBox.LuaMethods.Add("Tool_DumpEvents()");
			this.RegisterFunction("Tool_EmulateNoConsole", base.GetType().GetMethod("Tool_EmulateNoConsole"));
			LuaSandBox.LuaMethods.Add("Tool_EmulateNoConsole()");
			this.RegisterFunction("Tool_Range", base.GetType().GetMethod("Tool_Range"));
			LuaSandBox.LuaMethods.Add("Tool_Range(from, to)");
			this.lua.DoString("math.randomseed( os.time() )", "chunk");
			this.lua["_errmsg_"] = "none";
			this.lua["_errfnc_"] = "none";
			this.enumTable = new LuaEnuNames();
			this.lua["_enumTable_"] = this.enumTable;
			this.lua.DoString(this.SecurityString, "chunk");
			string path = Path.Combine(Application.StartupPath, "Defaults", ".startup.lua");
			if (File.Exists(path))
			{
				string str = File.ReadAllText(path);
				this.RunScript(str, false, "Initializing");
			}
		}

		// Token: 0x06006806 RID: 26630 RVA: 0x0036DBE4 File Offset: 0x0036BDE4
		private void ClearLuaErrorCondition(string string_0)
		{
			this.currentFunction = string_0;
			this.lua["_errmsg_"] = "";
			this.lua["_errfnc_"] = "";
			this.lua["_errnum_"] = 0;
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x0036DC38 File Offset: 0x0036BE38
		public void RegisterFunction(string string_0, MethodInfo methodInfo_0)
		{
			this.lua.RegisterFunction(string_0, this, methodInfo_0);
			List<string> list = new List<string>();
			ParameterInfo[] parameters = methodInfo_0.GetParameters();
			checked
			{
				for (int i = 0; i < parameters.Length; i++)
				{
					ParameterInfo parameterInfo = parameters[i];
					if (Operators.CompareString(parameterInfo.Name, "CoordsFormat", false) == 0)
					{
						list.Add("'DEC'/'DEG'");
					}
					else if (parameterInfo.ParameterType == typeof(string))
					{
						list.Add("'" + parameterInfo.Name + "'");
					}
					else
					{
						list.Add(parameterInfo.Name);
					}
				}
			}
		}

		// Token: 0x06006808 RID: 26632 RVA: 0x0036DCE0 File Offset: 0x0036BEE0
		[Attribute2]
		public void LUA_ScenEdit_Print(object object_0)
		{
			LuaSandBox.LuaPrintEventHandler luaPrintEvent = this.LuaPrintEvent;
			if (luaPrintEvent != null)
			{
				luaPrintEvent(RuntimeHelpers.GetObjectValue(object_0));
			}
		}

		// Token: 0x06006809 RID: 26633 RVA: 0x0036DD08 File Offset: 0x0036BF08
		public object[] RunScript(string str, bool RunInteractively, string script = null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string text = str.Split(new char[]
			{
				'('
			})[0];
			this.RunInteractive = RunInteractively;
			if (Operators.CompareString(text, "ScenEdit_SetScore", false) == 0)
			{
				List<string> list = Strings.Left(str.Split(new char[]
				{
					'('
				})[1], Strings.Len(str.Split(new char[]
				{
					'('
				})[1]) - 1).Split(new char[]
				{
					','
				}).ToList<string>();
				if (list.Count == 2)
				{
					list.Add("'No reason given'");
				}
				str = text + "(" + string.Join(",", list) + ")";
			}
			if (!Information.IsNothing(LuaSandBox._LuaSandbox) & !this.RunInteractive)
			{
				stringBuilder.Append(str);
				if (!Information.IsNothing(this.lua))
				{
					string text2 = null;
					try
					{
						text2 = this.lua.GetString("_lua_event");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					if (!Information.IsNothing(text2))
					{
						bool? booleanValue = LuaUtility.GetBooleanValue(text2);
						if ((booleanValue.HasValue ? new bool?(booleanValue.GetValueOrDefault()) : null).GetValueOrDefault())
						{
							LuaSandBox._lua_event = true;
						}
						else
						{
							LuaSandBox._lua_event = false;
						}
					}
				}
				if (LuaSandBox._lua_event)
				{
					string text3 = "Script";
					object obj = stringBuilder.ToString();
					LuaUtility.smethod_30(ref text3, ref obj, true);
				}
			}
			this.currentLine = 0;
			object[] array2;
			object[] result;
			try
			{
				object[] array;
				if (Operators.CompareString(str, "_VERSION", false) == 0)
				{
					array = this.lua.DoString("return _VERSION", "chunk");
				}
				else
				{
					try
					{
						if (this.RunInteractive)
						{
							array = this.lua.DoString(str, "Console");
						}
						else
						{
							array = this.lua.DoString(str, "chunk");
						}
					}
					catch (LuaScriptException ex)
					{
						ProjectData.SetProjectError(ex);
						LuaScriptException ex2 = ex;
						if (ex2.InnerException is Exception2)
						{
							if (this.RunInteractive)
							{
								if (Information.IsNothing(((Exception2)ex2.InnerException).string_1))
								{
									Interaction.MsgBox(((Exception2)ex2.InnerException).string_0, MsgBoxStyle.OkOnly, null);
								}
								else
								{
									Interaction.MsgBox(string.Concat(new string[]
									{
										((Exception2)ex2.InnerException).string_1,
										" ",
										((Exception2)ex2.InnerException).int_0.ToString(),
										" : ",
										((Exception2)ex2.InnerException).string_0
									}), MsgBoxStyle.OkOnly, null);
								}
							}
							array = new object[]
							{
								null,
								((Exception2)ex2.InnerException).string_0
							};
							array[0] = ((Exception2)ex2.InnerException).string_1 + " " + ((Exception2)ex2.InnerException).int_0.ToString() + " : ";
							array2 = array;
							ProjectData.ClearProjectError();
							result = array2;
							return result;
						}
						throw;
					}
				}
				array2 = array;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				if (!this.RunInteractive)
				{
					string text3 = "";
					object obj = ex4;
					LuaUtility.smethod_30(ref text3, ref obj, false);
					throw;
				}
				object[] array = new object[2];
				array[0] = ex4;
				array2 = array;
				ProjectData.ClearProjectError();
			}
			result = array2;
			return result;
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x0036E100 File Offset: 0x0036C300
		[Attribute0, Attribute2]
		public LuaWrapper_ActiveUnit_SE LUA_ScenEdit_UnitX()
		{
			this.ClearLuaErrorCondition("ScenEdit_UnitX");
			LuaWrapper_ActiveUnit_SE result;
			if (this.UnitX == null)
			{
				result = null;
			}
			else
			{
				try
				{
					result = new LuaWrapper_ActiveUnit_SE(this.UnitX, this.ScenarioContext);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (this.RunInteractive)
					{
						throw;
					}
					result = null;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x0036E170 File Offset: 0x0036C370
		[Attribute0, Attribute2]
		public LuaWrapper_Contact LUA_ScenEdit_ContactX(Side side_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_ContactX");
			LuaWrapper_Contact result;
			if (this.ContactX == null)
			{
				result = null;
			}
			else
			{
				try
				{
					result = new LuaWrapper_Contact(this.ContactX, this.ScenarioContext, side_0);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (this.RunInteractive)
					{
						throw;
					}
					result = null;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x0600680C RID: 26636 RVA: 0x0036E1E0 File Offset: 0x0036C3E0
		[Attribute0, Attribute2]
		public double LUA_ScenEdit_CurrentTime()
		{
			this.ClearLuaErrorCondition("ScenEdit_CurrentTime");
			double result = 0.0;
			try
			{
				result = (this.ScenarioContext.GetCurrentTime(false) - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0.0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x0036E268 File Offset: 0x0036C468
		[Attribute0, Attribute2]
		public string LUA_Echo(string string_0)
		{
			return string_0;
		}

		// Token: 0x0600680E RID: 26638 RVA: 0x0036E278 File Offset: 0x0036C478
		[Attribute0, Attribute2]
		public string LUA_GetScenarioTitle()
		{
			this.ClearLuaErrorCondition("GetScenarioTitle");
			return this.ScenarioContext.GetScenarioTitle();
		}

		// Token: 0x0600680F RID: 26639 RVA: 0x0036E2A0 File Offset: 0x0036C4A0
		[Attribute0, Attribute2]
		public LuaWrapper_Side LUA_VP_GetSide(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("VP_GetSide");
			LuaWrapper_Side result;
			try
			{
				result = PrivateMethods.smethod_41(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006810 RID: 26640 RVA: 0x0036E2F8 File Offset: 0x0036C4F8
		[Attribute0, Attribute2]
		public LuaWrapper_ActiveUnit LUA_VP_GetUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("VP_GetUnit");
			LuaWrapper_ActiveUnit result;
			try
			{
				result = PrivateMethods.smethod_39(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006811 RID: 26641 RVA: 0x0036E350 File Offset: 0x0036C550
		[Attribute0, Attribute2]
		public LuaWrapper_Contact LUA_VP_GetContact(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("VP_GetContact");
			LuaWrapper_Contact result;
			try
			{
				result = PrivateMethods.smethod_40(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006812 RID: 26642 RVA: 0x0036E3A8 File Offset: 0x0036C5A8
		[Attribute0, Attribute2]
		public string LUA_ScenEdit_AddAircraft(string string_0, string string_1, int int_0, int int_1, string string_2, string string_3, string string_4)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddAircraft");
			return PrivateMethods.smethod_2(string_0, string_1, int_0, int_1, string_2, string_3, string_4, this.ScenarioContext);
		}

		// Token: 0x06006813 RID: 26643 RVA: 0x0036E3D8 File Offset: 0x0036C5D8
		[Attribute0, Attribute2]
		public string LUA_ScenEdit_AddShip(string string_0, string string_1, int int_0, string string_2, string string_3, string string_4)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddShip");
			return PrivateMethods.smethod_3(string_0, string_1, int_0, string_2, string_3, string_4, this.ScenarioContext);
		}

		// Token: 0x06006814 RID: 26644 RVA: 0x0036E408 File Offset: 0x0036C608
		[Attribute0, Attribute2]
		public string LUA_ScenEdit_AddSubmarine(string string_0, string string_1, int int_0, string string_2, string string_3, string string_4)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddSubmarine");
			return PrivateMethods.smethod_4(string_0, string_1, int_0, string_2, string_3, string_4, this.ScenarioContext);
		}

		// Token: 0x06006815 RID: 26645 RVA: 0x0036E438 File Offset: 0x0036C638
		[Attribute0, Attribute2]
		public string LUA_ScenEdit_AddFacility(string string_0, string string_1, int int_0, int int_1, string string_2, string string_3, string string_4)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddFacility");
			return PrivateMethods.smethod_6(string_0, string_1, int_0, int_1, string_2, string_3, string_4, this.ScenarioContext);
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x0036E468 File Offset: 0x0036C668
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_AssignUnitToMission(string AUNameOrID, string MissionNameOrID, bool Escort = false, bool StrikePlanner = true)
		{
			this.ClearLuaErrorCondition("ScenEdit_AssignUnitToMission");
			bool value = LuaUtility.GetBooleanValue(Escort).Value;
			bool value2 = LuaUtility.GetBooleanValue(false).Value;
			bool result = false;
			try
			{
				result = PrivateMethods.smethod_8(AUNameOrID, MissionNameOrID, this.ScenarioContext, this.UnitX, value, value2);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006817 RID: 26647 RVA: 0x0036E4F4 File Offset: 0x0036C6F4
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_SetWeather(int int_0, int int_1, float float_0, int int_2)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetWeather");
			bool result = false;
			try
			{
				result = PrivateMethods.smethod_10(int_0, int_1, float_0, int_2, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006818 RID: 26648 RVA: 0x0036E550 File Offset: 0x0036C750
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_GetWeather()
		{
			this.ClearLuaErrorCondition("ScenEdit_GetWeather");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_11(this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006819 RID: 26649 RVA: 0x0036E5A8 File Offset: 0x0036C7A8
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_SetSidePosture(string string_0, string string_1, string string_2)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetSidePosture");
			bool result = false;
			try
			{
				result = PrivateMethods.smethod_12(string_0, string_1, string_2, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600681A RID: 26650 RVA: 0x0036E604 File Offset: 0x0036C804
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_SetSideOptions(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetSideOptions");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_13(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600681B RID: 26651 RVA: 0x0036E65C File Offset: 0x0036C85C
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_SetUnitDamage(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetUnitDamage");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_15(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600681C RID: 26652 RVA: 0x0036E6B4 File Offset: 0x0036C8B4
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_SetSpecialAction(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetSpecialAction");
			bool result = false;
			try
			{
				result = Class272.smethod_4(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600681D RID: 26653 RVA: 0x0036E70C File Offset: 0x0036C90C
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_SetEMCON(string string_0, string string_1, string string_2)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetEMCON");
			bool result = false;
			try
			{
				result = PrivateMethods.smethod_16(string_0, string_1, string_2, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600681E RID: 26654 RVA: 0x0036E768 File Offset: 0x0036C968
		[Attribute0, Attribute2]
		public string LUA_ScenEdit_MsgBox(string string_0, int int_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_MsgBox");
			return PrivateMethods.smethod_17(string_0, int_0);
		}

		// Token: 0x0600681F RID: 26655 RVA: 0x0036E78C File Offset: 0x0036C98C
		[Attribute0, Attribute2]
		public string LUA_ScenEdit_RunScript(string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_RunScript");
			string result = "";
			try
			{
				string chunk;
				if (File.Exists(string_0))
				{
					if (!string_0.Contains(GameGeneral.strAttachmentRepoDir))
					{
						throw new Exception2("Path " + Path.GetDirectoryName(string_0) + " not vaild");
					}
					chunk = File.ReadAllText(string_0);
					string text = "Script";
					object obj = this.currentFunction + " executing " + string_0;
					LuaUtility.smethod_30(ref text, ref obj, true);
				}
				else
				{
					chunk = File.ReadAllText("Lua\\" + string_0);
					string text = "Script";
					object obj = this.currentFunction + " executing Lua\\" + string_0;
					LuaUtility.smethod_30(ref text, ref obj, true);
				}
				this.lua.DoString(chunk, string_0);
				result = "";
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006820 RID: 26656 RVA: 0x0036E88C File Offset: 0x0036CA8C
		[Attribute0, Attribute2]
		public string LUA_ScenEdit_SetKeyValue(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetKeyValue");
			if (string.IsNullOrWhiteSpace(this.ScenarioContext.LuaXml))
			{
				this.ScenarioContext.LuaXml = "<KeyValueDatastore></KeyValueDatastore>";
			}
			XElement xElement = XElement.Parse(this.ScenarioContext.LuaXml);
			XElement xElement2 = xElement.Element(string_0);
			if (Information.IsNothing(xElement2))
			{
				xElement2 = new XElement(string_0, string_1);
				xElement.Add(xElement2);
			}
			else
			{
				xElement2.Value = string_1;
			}
			this.ScenarioContext.LuaXml = xElement.ToString();
			return "Saved";
		}

		// Token: 0x06006821 RID: 26657 RVA: 0x0036E928 File Offset: 0x0036CB28
		[Attribute0, Attribute2]
		public string LUA_ScenEdit_GetKeyValue(string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetKeyValue");
			if (string.IsNullOrWhiteSpace(this.ScenarioContext.LuaXml))
			{
				this.ScenarioContext.LuaXml = "<KeyValueDatastore></KeyValueDatastore>";
			}
			XElement xElement = XElement.Parse(this.ScenarioContext.LuaXml).Element(string_0);
			string result;
			if (Information.IsNothing(xElement))
			{
				result = "";
			}
			else
			{
				result = xElement.Value;
			}
			return result;
		}

		// Token: 0x06006822 RID: 26658 RVA: 0x0036E9A4 File Offset: 0x0036CBA4
		[Attribute0, Attribute2]
		public LuaWrapper_ActiveUnit_SE LUA_ScenEdit_AddUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddUnit");
			LuaWrapper_ActiveUnit_SE result;
			try
			{
				result = PrivateMethods.smethod_25(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x0036E9FC File Offset: 0x0036CBFC
		[Attribute0, Attribute2]
		public LuaWrapper_ActiveUnit_SE LUA_ScenEdit_UpdateUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_UpdateUnit");
			LuaWrapper_ActiveUnit_SE result;
			try
			{
				result = PrivateMethods.smethod_26(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006824 RID: 26660 RVA: 0x0036EA54 File Offset: 0x0036CC54
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_AddExplosion(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddExplosion");
			bool result = false;
			try
			{
				result = PrivateMethods.smethod_5(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006825 RID: 26661 RVA: 0x0036EAAC File Offset: 0x0036CCAC
		[Attribute0, Attribute2]
		public LuaWrapper_ActiveUnit_SE LUA_ScenEdit_SetUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetUnit");
			LuaWrapper_ActiveUnit_SE result;
			try
			{
				result = PrivateMethods.smethod_29(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006826 RID: 26662 RVA: 0x0036EB04 File Offset: 0x0036CD04
		[Attribute0, Attribute2]
		public LuaWrapper_ActiveUnit_SE LUA_ScenEdit_GetUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetUnit");
			LuaWrapper_ActiveUnit_SE result;
			try
			{
				result = PrivateMethods.smethod_27(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006827 RID: 26663 RVA: 0x0036EB5C File Offset: 0x0036CD5C
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_DeleteUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_DeleteUnit");
			bool result = false;
			try
			{
				result = PrivateMethods.smethod_30(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x0036EBB4 File Offset: 0x0036CDB4
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_KillUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_KillUnit");
			bool result = false;
			try
			{
				result = PrivateMethods.smethod_31(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006829 RID: 26665 RVA: 0x0036EC0C File Offset: 0x0036CE0C
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_SetUnitSide(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetUnitSide");
			bool result = false;
			try
			{
				result = PrivateMethods.smethod_32(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600682A RID: 26666 RVA: 0x0036EC64 File Offset: 0x0036CE64
		[Attribute0, Attribute2]
		public LuaWrapper_ReferencePoint LUA_ScenEdit_AddReferencePoint(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddReferencePoint");
			LuaWrapper_ReferencePoint result;
			try
			{
				result = Class290.smethod_0(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x0036ECBC File Offset: 0x0036CEBC
		[Attribute0, Attribute2]
		public LuaWrapper_ReferencePoint LUA_ScenEdit_SetReferencePoint(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetReferencePoint");
			LuaWrapper_ReferencePoint result;
			try
			{
				result = Class290.smethod_1(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x0036ED14 File Offset: 0x0036CF14
		[Attribute0, Attribute2]
		public LuaWrapper_ReferencePoint LUA_ScenEdit_GetReferencePoint(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetReferencePoint");
			LuaWrapper_ReferencePoint result;
			try
			{
				result = Class290.smethod_1(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x0036ED6C File Offset: 0x0036CF6C
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_GetReferencePoints(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetReferencePoints");
			LuaTable result;
			try
			{
				result = Class290.smethod_2(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600682E RID: 26670 RVA: 0x0036EDC4 File Offset: 0x0036CFC4
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_DeleteReferencePoint(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_DeleteReferencePoint");
			bool result = false;
			try
			{
				result = Class290.smethod_3(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600682F RID: 26671 RVA: 0x0036EE1C File Offset: 0x0036D01C
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_SetDoctrine(LuaTable luaTable_0, LuaTable luaTable_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetDoctrine");
			LuaTable result;
			try
			{
				result = Class281.smethod_0(luaTable_0, luaTable_1, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006830 RID: 26672 RVA: 0x0036EE74 File Offset: 0x0036D074
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_SetDoctrineWRA(LuaTable luaTable_0, LuaTable luaTable_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetDoctrineWRA");
			LuaTable result;
			try
			{
				result = Class281.smethod_3(luaTable_0, luaTable_1, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x0036EECC File Offset: 0x0036D0CC
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_GetDoctrine(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetDoctrine");
			LuaTable result;
			try
			{
				result = Class281.smethod_1(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x0036EF24 File Offset: 0x0036D124
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_GetDoctrineWRA(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetDoctrineWRA");
			LuaTable result;
			try
			{
				result = Class281.smethod_2(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006833 RID: 26675 RVA: 0x0036EF7C File Offset: 0x0036D17C
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_HostUnitToParent(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_HostUnitToParent");
			bool result = false;
			try
			{
				result = PrivateMethods.smethod_7(luaTable_0, this.ScenarioContext, this.UnitX);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006834 RID: 26676 RVA: 0x0036EFDC File Offset: 0x0036D1DC
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_GetSideOptions(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetSideOptions");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_21(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006835 RID: 26677 RVA: 0x0036F034 File Offset: 0x0036D234
		[Attribute0, Attribute2]
		public string LUA_ScenEdit_GetSidePosture(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetSidePosture");
			string result = "";
			try
			{
				result = PrivateMethods.smethod_20(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006836 RID: 26678 RVA: 0x0036F094 File Offset: 0x0036D294
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_GetSideIsHuman(string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetSideIsHuman");
			bool result = false;
			try
			{
				result = PrivateMethods.smethod_22(string_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006837 RID: 26679 RVA: 0x0036F0EC File Offset: 0x0036D2EC
		[Attribute2]
		public bool LUA_ScenEdit_UseAttachment(string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_UseAttachment");
			bool result = false;
			try
			{
				result = Class313.smethod_0(string_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006838 RID: 26680 RVA: 0x0036F144 File Offset: 0x0036D344
		[Attribute2]
		public bool LUA_ScenEdit_UseAttachmentOnSide(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_UseAttachmentOnSide");
			bool result = false;
			try
			{
				result = Class313.smethod_1(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x0036F19C File Offset: 0x0036D39C
		[Attribute0, Attribute2]
		public int LUA_ScenEdit_GetScore(string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetScore");
			int result = 0;
			try
			{
				result = PrivateMethods.smethod_19(string_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600683A RID: 26682 RVA: 0x0002CEF2 File Offset: 0x0002B0F2
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_GetScenHasStarted()
		{
			this.ClearLuaErrorCondition("ScenEdit_GetScenHasStarted");
			return this.ScenarioContext.HasStarted();
		}

		// Token: 0x0600683B RID: 26683 RVA: 0x0036F1F8 File Offset: 0x0036D3F8
		[Attribute0, Attribute2]
		public int LUA_ScenEdit_SetScore(string string_0, int int_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetScore");
			int result = 0;
			try
			{
				result = PrivateMethods.smethod_23(string_0, int_0, this.ScenarioContext, string_1);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600683C RID: 26684 RVA: 0x0036F254 File Offset: 0x0036D454
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_SetLoadout(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetLoadout");
			bool result = false;
			try
			{
				result = PrivateMethods.smethod_9(luaTable_0, this.ScenarioContext, this.UnitX);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600683D RID: 26685 RVA: 0x0036F2B4 File Offset: 0x0036D4B4
		[Attribute0, Attribute2]
		public int LUA_ScenEdit_SpecialMessage(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_SpecialMessage");
			int result = 0;
			try
			{
				result = PrivateMethods.smethod_24(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600683E RID: 26686 RVA: 0x0036F310 File Offset: 0x0036D510
		[Attribute0, Attribute2]
		public string LUA_ScenEdit_PlayerSide()
		{
			this.ClearLuaErrorCondition("ScenEdit_PlayerSide");
			return this.ScenarioContext.GetCurrentSide().GetSideName();
		}

		// Token: 0x0600683F RID: 26687 RVA: 0x0002CF0A File Offset: 0x0002B10A
		[Attribute0, Attribute2]
		public int LUA_ScenEdit_EndScenario()
		{
			this.ClearLuaErrorCondition("ScenEdit_EndScenario");
			this.ScenarioContext.ScenCompleted();
			return 1;
		}

		// Token: 0x06006840 RID: 26688 RVA: 0x0036F33C File Offset: 0x0036D53C
		[Attribute0, Attribute2]
		public int LUA_ScenEdit_ImportInst(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_ImportInst");
			int result = 0;
			try
			{
				result = Class312.smethod_0(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006841 RID: 26689 RVA: 0x0036F398 File Offset: 0x0036D598
		[Attribute0, Attribute2]
		public int LUA_World_GetElevation(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("World_GetElevation");
			int result = 0;
			try
			{
				result = PrivateMethods.smethod_42(luaTable_0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006842 RID: 26690 RVA: 0x0036F3EC File Offset: 0x0036D5EC
		[Attribute0, Attribute2]
		public LuaTable LUA_World_GetCircleFromPoint(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("World_GetCircleFromPoint");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_43(luaTable_0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x0036F440 File Offset: 0x0036D640
		[Attribute0, Attribute2]
		public int LUA_ScenEdit_AddReloadsToUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddReloadsToUnit");
			int result = 0;
			try
			{
				result = PrivateMethods.smethod_33(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x0036F49C File Offset: 0x0036D69C
		[Attribute0, Attribute2]
		public int LUA_ScenEdit_AddWeaponToUnitMagazine(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddWeaponToUnitMagazine");
			int result = 0;
			try
			{
				result = PrivateMethods.smethod_34(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x0036F4F8 File Offset: 0x0036D6F8
		[Attribute0, Attribute2]
		public string LUA_ScenEdit_RefuelUnit(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_RefuelUnit");
			string result = "";
			try
			{
				result = PrivateMethods.smethod_36(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x0036F558 File Offset: 0x0036D758
		[Attribute0, Attribute2]
		public LuaWrapper_Mission LUA_ScenEdit_AddMission(string string_0, string string_1, string string_2, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AddMission");
			LuaWrapper_Mission result;
			try
			{
				result = Class273.smethod_1(string_0, string_1, string_2, luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x0036F5B4 File Offset: 0x0036D7B4
		[Attribute0, Attribute2]
		public LuaWrapper_Mission LUA_ScenEdit_GetMission(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetMission");
			LuaWrapper_Mission result;
			try
			{
				result = Class273.smethod_0(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x0036F60C File Offset: 0x0036D80C
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_DeleteMission(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_DeleteMission");
			bool result = false;
			try
			{
				result = Class273.smethod_2(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x0036F664 File Offset: 0x0036D864
		[Attribute0, Attribute2]
		public LuaWrapper_Mission LUA_ScenEdit_SetMission(string string_0, string string_1, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetMission");
			LuaWrapper_Mission result;
			try
			{
				result = Class273.smethod_5(string_0, string_1, luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x0036F6C0 File Offset: 0x0036D8C0
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_ImportMission(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_ImportMission");
			LuaTable result;
			try
			{
				result = Class273.smethod_4(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600684B RID: 26699 RVA: 0x0036F718 File Offset: 0x0036D918
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_FillMagsForLoadout(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_FillMagsForLoadout");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_14(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x0036F770 File Offset: 0x0036D970
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_ExportMission(string string_0, string string_1)
		{
			this.ClearLuaErrorCondition("ScenEdit_ExportMission");
			LuaTable result;
			try
			{
				result = Class273.smethod_3(string_0, string_1, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x0036F7C8 File Offset: 0x0036D9C8
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_AssignUnitAsTarget(object object_0, string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_AssignUnitAsTarget");
			LuaTable result;
			try
			{
				result = Class273.smethod_6(RuntimeHelpers.GetObjectValue(object_0), string_0, this.ScenarioContext, this.UnitX);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x0036F82C File Offset: 0x0036DA2C
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_RemoveUnitAsTarget(object object_0, string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_RemoveUnitAsTarget");
			LuaTable result;
			try
			{
				result = Class273.smethod_7(RuntimeHelpers.GetObjectValue(object_0), string_0, this.ScenarioContext, this.UnitX);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x0036F890 File Offset: 0x0036DA90
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_GetContacts(string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetContacts");
			LuaTable result;
			try
			{
				result = PrivateMethods.smethod_37(string_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006850 RID: 26704 RVA: 0x0036F8E8 File Offset: 0x0036DAE8
		[Attribute0, Attribute2]
		public LuaWrapper_Contact LUA_ScenEdit_GetContact(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_Contact");
			LuaWrapper_Contact result;
			try
			{
				result = PrivateMethods.smethod_28(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x0036F940 File Offset: 0x0036DB40
		[Attribute0, Attribute2]
		public string LUA_ScenEdit_ExecuteEventAction(string string_0)
		{
			string text = null;
			this.ClearLuaErrorCondition("ScenEdit_ExecuteEventAction");
			string text2;
			string result;
			try
			{
				text = Class272.smethod_0(string_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				text2 = null;
				ProjectData.ClearProjectError();
				result = text2;
				return result;
			}
			if (text != null && Operators.CompareString(text, "", false) != 0)
			{
				try
				{
					this.lua.DoString(text, string_0);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					if (this.RunInteractive)
					{
						throw;
					}
					text2 = null;
					ProjectData.ClearProjectError();
					result = text2;
					return result;
				}
				text2 = "OK";
			}
			else
			{
				text2 = "";
			}
			result = text2;
			return result;
		}

		// Token: 0x06006852 RID: 26706 RVA: 0x0036FA04 File Offset: 0x0036DC04
		[Attribute0, Attribute2]
		public string LUA_ScenEdit_ExecuteSpecialAction(string string_0)
		{
			string text = null;
			this.ClearLuaErrorCondition("ScenEdit_ExecuteSpecialAction");
			string text2;
			string result;
			try
			{
				text = Class272.smethod_6(string_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				text2 = null;
				ProjectData.ClearProjectError();
				result = text2;
				return result;
			}
			if (text != null && Operators.CompareString(text, "", false) != 0)
			{
				try
				{
					this.lua.DoString(text, string_0);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					if (this.RunInteractive)
					{
						throw;
					}
					text2 = null;
					ProjectData.ClearProjectError();
					result = text2;
					return result;
				}
				text2 = "OK";
			}
			else
			{
				text2 = "";
			}
			result = text2;
			return result;
		}

		// Token: 0x06006853 RID: 26707 RVA: 0x0036FAC8 File Offset: 0x0036DCC8
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_SetEvent(string string_0, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_SetEvent");
			bool result = false;
			try
			{
				result = Class272.smethod_1(string_0, luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006854 RID: 26708 RVA: 0x0036FB20 File Offset: 0x0036DD20
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_GetEvent(string string_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetEvent");
			LuaTable result;
			try
			{
				result = Class272.smethod_3(string_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006855 RID: 26709 RVA: 0x0036FB78 File Offset: 0x0036DD78
		[Attribute0, Attribute2]
		public LuaTable LUA_ScenEdit_GetSpecialAction(LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit_GetSpecialAction");
			LuaTable result;
			try
			{
				result = Class272.smethod_5(luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006856 RID: 26710 RVA: 0x0036FBD0 File Offset: 0x0036DDD0
		[Attribute0, Attribute2]
		public object LUA_ScenEdit_UpdateEvent(string string_0, LuaTable luaTable_0)
		{
			this.ClearLuaErrorCondition("ScenEdit__UpdateEvent");
			object result = null;
			try
			{
				result = Class272.smethod_2(string_0, luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006857 RID: 26711 RVA: 0x0036FC2C File Offset: 0x0036DE2C
		[Attribute0, Attribute2]
		public bool LUA_ScenEdit_AttackContact(string string_0, string string_1, LuaTable luaTable_0)
		{
			bool result = false;
			try
			{
				result = PrivateMethods.smethod_38(string_0, string_1, luaTable_0, this.ScenarioContext);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (this.RunInteractive)
				{
					throw;
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006858 RID: 26712 RVA: 0x0036FC7C File Offset: 0x0036DE7C
		[Attribute0, Attribute2]
		public string Tool_DumpEvents()
		{
			this.ClearLuaErrorCondition("Tool_DumpEvents");
			string text = Class272.smethod_7(true, this.ScenarioContext);
			if (!Directory.Exists(MyTemplate.GetApp().Info.DirectoryPath + "\\Scenarios"))
			{
				Directory.CreateDirectory(MyTemplate.GetApp().Info.DirectoryPath + "\\Scenarios");
			}
			StreamWriter streamWriter = new StreamWriter(MyTemplate.GetApp().Info.DirectoryPath + "\\Scenarios\\" + this.ScenarioContext.FileName + " events.xml");
			using (streamWriter)
			{
				streamWriter.Write(text);
			}
			return text;
		}

		// Token: 0x06006859 RID: 26713 RVA: 0x0002CF23 File Offset: 0x0002B123
		[Attribute0, Attribute2]
		public bool Tool_EmulateNoConsole(bool mode = true)
		{
			this.ClearLuaErrorCondition("Tool_EmulateNoConsole");
			this.RunInteractive = !mode;
			return this.RunInteractive;
		}

		// Token: 0x0600685A RID: 26714 RVA: 0x0036FD3C File Offset: 0x0036DF3C
		[Attribute0, Attribute2]
		public double Tool_Range(object object_0, object object_1)
		{
			this.ClearLuaErrorCondition("Tool_Range");
			GeoPoint geoPoint = null;
			GeoPoint geoPoint2 = null;
			if (object_0 is LuaTable)
			{
				LuaTable luaTable = (LuaTable)object_0;
				Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable.GetEnumerator());
				double? num = LuaUtility.smethod_12(objectGeoLocation);
				double? num2 = LuaUtility.smethod_10(objectGeoLocation);
				if (!num.HasValue | !num.HasValue)
				{
					throw new Exception2("From table object " + LuaUtility.smethod_29(luaTable) + " needs latitude and longitude.");
				}
				geoPoint = new GeoPoint(num.Value, num2.Value);
			}
			if (object_1 is LuaTable)
			{
				LuaTable luaTable2 = (LuaTable)object_1;
				Dictionary<string, object> objectGeoLocation2 = LuaUtility.GetObjectGeoLocation(luaTable2.GetEnumerator());
				double? num3 = LuaUtility.smethod_12(objectGeoLocation2);
				double? num4 = LuaUtility.smethod_10(objectGeoLocation2);
				if (!num3.HasValue | !num3.HasValue)
				{
					throw new Exception2("To table object " + LuaUtility.smethod_29(luaTable2) + " needs latitude and longitude.");
				}
				geoPoint2 = new GeoPoint(num3.Value, num4.Value);
			}
			if (object_0 is string)
			{
				string text = Conversions.ToString(object_0);
				ActiveUnit activeUnit = null;
				Contact contact = null;
				try
				{
					activeUnit = this.ScenarioContext.GetActiveUnits()[text];
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				if (activeUnit == null)
				{
					try
					{
						contact = PrivateMethods.smethod_47(text, this.ScenarioContext);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				if (activeUnit == null & contact == null)
				{
					throw new Exception2("Can't find guid " + text);
				}
				if (activeUnit != null)
				{
					double longitude = activeUnit.GetLongitude(null);
					double latitude = activeUnit.GetLatitude(null);
					geoPoint = new GeoPoint(longitude, latitude);
				}
				else if (contact != null)
				{
					double longitude2 = contact.GetLongitude(null);
					double latitude2 = contact.GetLatitude(null);
					geoPoint = new GeoPoint(longitude2, latitude2);
				}
			}
			if (object_1 is string)
			{
				string text2 = Conversions.ToString(object_1);
				ActiveUnit activeUnit2 = null;
				Contact contact2 = null;
				try
				{
					activeUnit2 = this.ScenarioContext.GetActiveUnits()[text2];
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				if (activeUnit2 == null)
				{
					try
					{
						contact2 = PrivateMethods.smethod_47(text2, this.ScenarioContext);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
				}
				if (activeUnit2 == null & contact2 == null)
				{
					throw new Exception2("Can't find guid " + text2);
				}
				if (activeUnit2 != null)
				{
					double longitude3 = activeUnit2.GetLongitude(null);
					double latitude3 = activeUnit2.GetLatitude(null);
					geoPoint2 = new GeoPoint(longitude3, latitude3);
				}
				else if (contact2 != null)
				{
					double longitude4 = contact2.GetLongitude(null);
					double latitude4 = contact2.GetLatitude(null);
					geoPoint2 = new GeoPoint(longitude4, latitude4);
				}
			}
			if (geoPoint == null || geoPoint2 == null)
			{
				throw new Exception2("No points have been set");
			}
			return RangeCalculator.GetRange(geoPoint.GetLatitude(), geoPoint.GetLongitude(), geoPoint2.GetLatitude(), geoPoint2.GetLongitude());
		}

		// Token: 0x040038C9 RID: 14537
		public static List<string> LuaMethods = new List<string>();

		// Token: 0x040038CA RID: 14538
		[CompilerGenerated]
		private LuaSandBox.LuaPrintEventHandler LuaPrintEvent;

		// Token: 0x040038CB RID: 14539
		private NLua.Lua lua;

		// Token: 0x040038CC RID: 14540
		private string SecurityString;

		// Token: 0x040038CD RID: 14541
		private Scenario ScenarioContext;

		// Token: 0x040038CE RID: 14542
		public ActiveUnit UnitX;

		// Token: 0x040038CF RID: 14543
		public Contact ContactX;

		// Token: 0x040038D0 RID: 14544
		public LuaEnuNames enumTable;

		// Token: 0x040038D1 RID: 14545
		public static bool _lua_event = false;

		// Token: 0x040038D2 RID: 14546
		public static bool _lua_console = true;

		// Token: 0x040038D3 RID: 14547
		public string currentFunction;

		// Token: 0x040038D4 RID: 14548
		public int currentLine;

		// Token: 0x040038D5 RID: 14549
		public string lastError;

		// Token: 0x040038D6 RID: 14550
		public bool RunInteractive;

		// Token: 0x040038D7 RID: 14551
		private static LuaSandBox _LuaSandbox;

		// Token: 0x02000C31 RID: 3121
		// (Invoke) Token: 0x0600685D RID: 26717
		public delegate void LuaPrintEventHandler(object obj);
	}
}
