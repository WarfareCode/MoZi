using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns16;
using ns19;
using ns2;
using ns3;
using ns31;
using ns4;
using SevenZip;

namespace Command_Core
{
	// Token: 总经理
	public sealed class GameGeneral
	{
		// Token: 生成随机数
		public static Random GetRandom()
		{
			Random result = null;
			try
			{
				if (GameGeneral.RandomStream == 2147483647)
				{
					GameGeneral.RandomStream = 0;
				}
				else
				{
					GameGeneral.RandomStream++;
				}
				if (GameGeneral.int_1 == 9)
				{
					GameGeneral.int_1 = 0;
				}
				else
				{
					GameGeneral.int_1++;
				}
				if (Information.IsNothing(GameGeneral.RandomArray[GameGeneral.int_1]))
				{
					GameGeneral.RandomArray[GameGeneral.int_1] = new Random((int)Math.Round(Math.Pow((double)GameGeneral.RandomStream, 3.0)));
				}
				result = GameGeneral.RandomArray[GameGeneral.int_1];
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				GameGeneral.RandomStream = MyTemplate.GetComputer().Clock.TickCount;
				result = new Random(GameGeneral.RandomStream);
				ex2.Data.Add("Error at 200573", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// 强制垃圾收集
		public static void ForceGarbageCollection()
		{
			GC.Collect(2, GCCollectionMode.Forced);
			GC.WaitForPendingFinalizers();
		}

		// Token: 0x06006BDB RID: 27611 RVA: 0x003BE508 File Offset: 0x003BC708
		public static MemoryStream GetScenarioStream(Scenario scenario_)
		{
			MemoryStream memoryStream = new MemoryStream();
			if (!GameGeneral.ScenarioStreamDictionary.ContainsKey(scenario_))
			{
				GameGeneral.SerializeScenario(scenario_);
			}
			try
			{
				GameGeneral.ScenarioStreamDictionary[scenario_].Copy(memoryStream);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200490", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				GameGeneral.ForceGarbageCollection();
				GameGeneral.ScenarioStreamDictionary[scenario_].Copy(memoryStream);
				ProjectData.ClearProjectError();
			}
			return memoryStream;
		}

		// Token: 0x06006BDC RID: 27612 RVA: 0x0002E16C File Offset: 0x0002C36C
		public static void ClearScenarioStreamDictionary()
		{
			GameGeneral.ScenarioStreamDictionary.Clear();
		}

		// Token: 0x06006BDD RID: 27613 RVA: 0x003BE5A8 File Offset: 0x003BC7A8
		public static void ClearActiveUnits(ref Scenario scenario_)
		{
			List<ActiveUnit> list = scenario_.GetActiveUnitList().ToList<ActiveUnit>();
            ActiveUnit currentX;
            foreach (ActiveUnit current in list)
			{
                currentX = current;
                GameGeneral.ClearActiveUnit(ref currentX);
			}
			Side[] sides = scenario_.GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					List<Contact> contactList = sides[i].GetContactList();
                    Contact current2X;

                    foreach (Contact current2 in contactList)
					{
                        current2X = current2;
                        GameGeneral.MakeTargetUnitInfoUnknown(ref current2X);
					}
				}
			}
		}

		// 清除活动单元
		public static void ClearActiveUnit(ref ActiveUnit activeUnit_)
		{
			checked
			{
				try
				{
					if (!Information.IsNothing(activeUnit_.m_Mounts))
					{
						Mount[] mounts = activeUnit_.m_Mounts;
						for (int i = 0; i < mounts.Length; i++)
						{
							Mount mount = mounts[i];
							using (IEnumerator<WeaponRec> enumerator = mount.GetWeaponRecCollection().GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									enumerator.Current.Clear();
								}
							}
							using (IEnumerator<WeaponRec> enumerator2 = mount.GetMagazineForMount().GetWeaponRecCollection().GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									enumerator2.Current.Clear();
								}
							}
						}
					}
					if (!Information.IsNothing(activeUnit_.GetMagazines()))
					{
						Magazine[] magazines = activeUnit_.GetMagazines();
						for (int j = 0; j < magazines.Length; j++)
						{
							Magazine magazine = magazines[j];
							using (IEnumerator<WeaponRec> enumerator3 = magazine.GetWeaponRecCollection().GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									enumerator3.Current.Clear();
								}
							}
						}
					}
					if (activeUnit_.IsAircraft)
					{
						Aircraft aircraft = (Aircraft)activeUnit_;
						if (!Information.IsNothing(aircraft.GetLoadout()))
						{
							WeaponRec[] weaponRecArray = aircraft.GetLoadout().WeaponRecArray;
							for (int k = 0; k < weaponRecArray.Length; k++)
							{
								weaponRecArray[k].Clear();
							}
						}
					}
					if (!Information.IsNothing(activeUnit_.GetAirFacilities()) && activeUnit_.GetAirFacilities().Length > 0)
					{
						AirFacility[] airFacilities = activeUnit_.GetAirFacilities();
						for (int l = 0; l < airFacilities.Length; l++)
						{
							airFacilities[l].GetHostedAircrafts().Clear();
						}
					}
					if (!Information.IsNothing(activeUnit_.GetDockFacilities()) && activeUnit_.GetDockFacilities().Length > 0)
					{
						DockFacility[] dockFacilities = activeUnit_.GetDockFacilities();
						for (int m = 0; m < dockFacilities.Length; m++)
						{
							dockFacilities[m].LazyDockedUnitsDictionary.Value.Clear();
						}
					}
					foreach (PlatformComponent current in activeUnit_.GetAllPlatformComponents())
					{
						if (!Information.IsNothing(current.GetParentPlatform()))
						{
							current.SetParentPlatform(null);
						}
					}
					activeUnit_.GetSensory().ClearContactsEntries();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101226", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x0002E178 File Offset: 0x0002C378
		public static void MakeTargetUnitInfoUnknown(ref Contact theTarget)
		{
			if (!Information.IsNothing(theTarget.ActualUnit))
			{
				theTarget.ActualUnit = null;
			}
		}

		// Token: 仿真内核初始化
		public static void InitializeSimCore(bool bool_1, bool bSupportUnregisteredDB_)
		{
			try
			{
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "开始初始化CommandX仿真引擎.";
					GameGeneral.Log(ref text);
				}
				Misc.ClearTemp(GameGeneral.strTempDir);
				try
				{
					if (Information.IsNothing(SimConfiguration.gameOptions))
					{
						SimConfiguration.LoadSimConfiguration();
						if (SimConfiguration.gameOptions.LogDebugInfoToFile())
						{
							string text = "成功加载仿真配置.";
							GameGeneral.Log(ref text);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200000", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					if (SimConfiguration.gameOptions.LogDebugInfoToFile())
					{
						string text = "加载仿真配置失败!";
						GameGeneral.Log(ref text);
					}
					SimConfiguration.LoadDefault();
					SimConfiguration.LoadSimConfiguration();
					ProjectData.ClearProjectError();
				}
				Class324.GISElevationsRunWorker();
				DBOps.bSupportUnregisteredDB = bSupportUnregisteredDB_;
				Task.Factory.StartNew(new Action(DBOps.ScanDatabase));
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "启动数据库扫描成功.";
					GameGeneral.Log(ref text);
				}
				Terrain.LoadTerrainGrids();
				Task.Factory.StartNew(new Action(Class270.smethod_0));
				ArcticSeaIce.smethod_0();
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "加载地形网格数据成功.";
					GameGeneral.Log(ref text);
				}
				if (!Directory.Exists(GameGeneral.strAttachmentRepoDir))
				{
					Directory.CreateDirectory(GameGeneral.strAttachmentRepoDir);
				}
				SevenZipBase.SetLibraryPath(MyTemplate.GetApp().Info.DirectoryPath + "\\7z.dll");
				GameGeneral.world = Earth.CreateEarth();
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "创建仿真世界成功.";
					GameGeneral.Log(ref text);
				}
				Misc.double_0 = Math2.ApproxAngularDistance(5.0);
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "仿真引擎初始化完成.";
					GameGeneral.Log(ref text);
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 200577", ex4.Message);
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 仿真推进
		public static void AdvanceTimeStep(ref Scenario scenario_, float elapsedTime_, bool bSave_)
		{
			try
			{
				scenario_.ExecutionInProgress = true;
				GameGeneral.exception_0 = null;
				scenario_.AdvanceSimTime(false, scenario_.GetCurrentTime(false).AddSeconds((double)elapsedTime_));
				GameGeneral.ScheduleSimEvent(ref scenario_, elapsedTime_);
				scenario_.ExecutionInProgress = false;
				if (bSave_)
				{
					try
					{
						GameGeneral.SerializeScenario(scenario_);
					}
					catch (OutOfMemoryException projectError)
					{
						ProjectData.SetProjectError(projectError);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						GameGeneral.ForceGarbageCollection();
						GameGeneral.SerializeScenario(scenario_);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				scenario_.ExecutionInProgress = false;
				GameGeneral.exception_0 = ex2;
				ex2.Data.Add("Error at 300000", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 仿真实体的行为模型
		private static void ExecuteSimEntityBehaviorLogic(ActiveUnit theUnit, ActiveUnit[] activeUnits, float elapsedTime_)
		{
			if (!Information.IsNothing(theUnit))
			{
				try
				{
					if (theUnit.IsOperating())
					{
						try
						{
							if (!Information.IsNothing(theUnit.GetNavigator()))
							{
								theUnit.GetNavigator().ScheduleNextUpdate(elapsedTime_);
							}
                            //!IsMineCounterMeasure MCM
                            Sensor[] allNoneMCMSensors = theUnit.GetAllNoneMCMSensors();
							if (!Information.IsNothing(theUnit.GetSensory()) && !Information.IsNothing(theUnit.m_Scenario) && theUnit.m_Scenario.SecondIsChangingOnThisPulse && allNoneMCMSensors.Length > 0)
							{
								ActiveUnit_Sensory sensory = theUnit.GetSensory();
								sensory.ScheduleEMCONEvent(allNoneMCMSensors);
								sensory.ScheduleDetectionInteraction(
                                    allNoneMCMSensors, 
                                    activeUnits,
                                    elapsedTime_);
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 101263", "");
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
						try
						{
							if (!Information.IsNothing(theUnit.GetAI()))
							{
								theUnit.GetAI().ClearPostureStanceDictionary();
								theUnit.GetAI().ThreatAssessment();
								theUnit.GetAI().TargetingContacts(elapsedTime_, false, false);
							}
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							ex4.Data.Add("Error at 101264", "");
							GameGeneral.LogException(ref ex4);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
						try
						{
							if (!Information.IsNothing(theUnit.GetAI()))
							{
								if (!theUnit.IsFacility && !theUnit.IsShip && !theUnit.IsSubmarine)
								{
									theUnit.GetAI().Navigate(elapsedTime_);
								}
								else if (!Information.IsNothing(theUnit.m_Scenario) && theUnit.m_Scenario.SecondIsChangingOnThisPulse)
								{
									theUnit.GetAI().Navigate(elapsedTime_);
								}
							}
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5);
							Exception ex6 = ex5;
							ex6.Data.Add("Error at 101265", "");
							GameGeneral.LogException(ref ex6);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
						try
						{
							if (!Information.IsNothing(theUnit.GetWeaponry()) && !theUnit.IsGroup && theUnit.m_Scenario.SecondIsChangingOnThisPulse)
							{
								theUnit.GetWeaponry().method_23();
								theUnit.GetWeaponry().SchedulePlannedFire(1f);
								theUnit.GetWeaponry().ScheduleWeaponSalvo();
							}
							if (!Information.IsNothing(theUnit.GetDamage()) && theUnit.IsOperating())
							{
								theUnit.GetDamage().vmethod_15(elapsedTime_);
							}
							if (theUnit.GetNavigator().short_0 != -32768)
							{
								ActiveUnit_Navigator navigator = theUnit.GetNavigator();
								ActiveUnit_Navigator expr_271 = navigator;
								expr_271.short_0 -= (short)Math.Round((double)elapsedTime_);
							}
							if (theUnit.GetNavigator().short_1 != -32768)
							{
								ActiveUnit_Navigator navigator = theUnit.GetNavigator();
								ActiveUnit_Navigator expr_2A4 = navigator;
								expr_2A4.short_1 -= (short)Math.Round((double)elapsedTime_);
							}
							if (theUnit.GetNavigator().short_2 != -32768)
							{
								ActiveUnit_Navigator navigator = theUnit.GetNavigator();
								ActiveUnit_Navigator expr_2D7 = navigator;
								expr_2D7.short_2 -= (short)Math.Round((double)elapsedTime_);
							}
							if (theUnit.GetNavigator().short_3 != -32768)
							{
								ActiveUnit_Navigator navigator = theUnit.GetNavigator();
								ActiveUnit_Navigator expr_30A = navigator;
								expr_30A.short_3 -= (short)Math.Round((double)elapsedTime_);
							}
							if (theUnit.GetNavigator().short_4 != -32768)
							{
								ActiveUnit_Navigator navigator = theUnit.GetNavigator();
								ActiveUnit_Navigator expr_33D = navigator;
								expr_33D.short_4 -= (short)Math.Round((double)elapsedTime_);
							}
							if (theUnit.GetNavigator().short_5 != -32768)
							{
								ActiveUnit_Navigator navigator = theUnit.GetNavigator();
								ActiveUnit_Navigator expr_370 = navigator;
								expr_370.short_5 -= (short)Math.Round((double)elapsedTime_);
							}
							if (theUnit.GetNavigator().short_6 != -32768)
							{
								ActiveUnit_Navigator navigator = theUnit.GetNavigator();
								ActiveUnit_Navigator expr_3A3 = navigator;
								expr_3A3.short_6 -= (short)Math.Round((double)elapsedTime_);
							}
							if (theUnit.GetNavigator().short_7 != -32768)
							{
								ActiveUnit_Navigator navigator = theUnit.GetNavigator();
								ActiveUnit_Navigator expr_3D6 = navigator;
								expr_3D6.short_7 -= (short)Math.Round((double)elapsedTime_);
							}
							if (theUnit.GetNavigator().short_8 != -32768)
							{
								ActiveUnit_Navigator navigator = theUnit.GetNavigator();
								ActiveUnit_Navigator expr_409 = navigator;
								expr_409.short_8 -= (short)Math.Round((double)elapsedTime_);
							}
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7);
							Exception ex8 = ex7;
							ex8.Data.Add("Error at 101266", "");
							GameGeneral.LogException(ref ex8);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception ex9)
				{
					ProjectData.SetProjectError(ex9);
					Exception ex10 = ex9;
					ex10.Data.Add("Error at 300001", "");
					GameGeneral.LogException(ref ex10);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006BE3 RID: 27619 RVA: 0x003BF1DC File Offset: 0x003BD3DC
        // 仿真调度核心算法,包括实体行为调度等
		public static void ScheduleSimEvent(ref Scenario scenario_, float elapsedTime_)
		{
			GameGeneral.SimEngineEntityState simEngineEntityState = new GameGeneral.SimEngineEntityState(null);
			simEngineEntityState.elapsedTime = elapsedTime_;
			GameGeneral.ScenarioStateKeeperSchedule(scenario_, simEngineEntityState.elapsedTime);
			simEngineEntityState.ActiveUnits = scenario_.GetActiveUnitList().ToList<ActiveUnit>();
			Random random = GameGeneral.GetRandom();
			try
			{
				if (simEngineEntityState.ActiveUnits.Count > 0)
				{
					try
					{
						GameGeneral.SimEntityLogicSheduler simEntityLogicSheduler = new GameGeneral.SimEntityLogicSheduler(null);
						simEntityLogicSheduler.m_SimEngineEntityState = simEngineEntityState;
						simEntityLogicSheduler.ActiveUnits = new ActiveUnit[0];
						foreach (ActiveUnit current in simEntityLogicSheduler.m_SimEngineEntityState.ActiveUnits)
						{
							if (current.IsOperating() && !current.GetCommStuff().IsNotOutOfComms())
							{
								ScenarioArrayUtil.AddActiveUnit(ref simEntityLogicSheduler.ActiveUnits, current);
							}
						}
                        //多线程调度实体行为模型
						Parallel.For(0, simEntityLogicSheduler.m_SimEngineEntityState.ActiveUnits.Count, new Action<int>(simEntityLogicSheduler.ScheduleSimEntityBehaviorLogic));

                        //调式用串行
                        //for (int i = 0; i < simEntityLogicSheduler.m_SimEngineEntityState.ActiveUnits.Count; i++)
                        //{
                        //    simEntityLogicSheduler.ScheduleSimEntityBehaviorLogic(i);
                        //}

                    }
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200492", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						if (typeof(Exception) == typeof(AggregateException))
						{
							ex2.Data.Add("Error at 300020 ", ((AggregateException)ex2).InnerExceptions[0].Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
						else
						{
							ex2.Data.Add("Error at 300002", "");
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
						ProjectData.ClearProjectError();
					}
					try
					{
						foreach (ActiveUnit current2 in simEngineEntityState.ActiveUnits)
						{
							try
							{
								if (!Information.IsNothing(current2) && !Information.IsNothing(current2.GetSide(false)) && !scenario_.GetUnitRemovals().Contains(current2))
								{
									if (current2.IsShip && ((Ship)current2).IsDestroyed())
									{
										current2.SetDamagePts(false, (float)((double)current2.GetDamagePts(false) - (double)current2.GetInitialDP() / (double)(300 * GameGeneral.GetRandom().Next(1, 7)) * (double)simEngineEntityState.elapsedTime));
										if (current2.GetDamagePts(false) <= -(float)current2.GetInitialDP())
										{
											scenario_.RemoveUnit(current2);
										}
									}
									else
									{
										if (!current2.IsGroup && !current2.IsOperating())
										{
											current2.AddThreats();
											current2.GetWeaponry().SchedulePlannedFire(simEngineEntityState.elapsedTime);
										}
										current2.ScheduleLifeCycleActivities(simEngineEntityState.elapsedTime, ref random);
										if (scenario_.FifteenthSecondIsChangingOnThisPulse && scenario_.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CommsJamming) && scenario_.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CommsJamming) && current2.IsOperating())
										{
                                            // 调用通信干扰计算
											current2.GetCommStuff().UpdateCommsJamming();
										}
										if (scenario_.SecondIsChangingOnThisPulse && !current2.IsGroup && current2.IsOperating())
										{
											if (current2.GetAllNoneMCMSensors().Length > 0)
											{
												ActiveUnit_Sensory sensory = current2.GetSensory();
												if (current2.GetCommStuff().IsNotOutOfComms())
												{
													sensory.ScheduleDetectInterationOnGrid();
												}
												else
												{
													sensory.ScheduleDetectInterationOffGrid();
												}
												sensory.ScheduleTrackInteration();
											}
											else
											{
												current2.GetSensory().method_68();
											}
										}
										if (current2.IsOperating())
										{
											if (scenario_.SecondIsChangingOnThisPulse)
											{
												current2.GetAI().PickPrimaryThreat();
												current2.GetAI().ScheduleNextPrimaryTargetEvent(1, false);
											}
											current2.GetAI().UpdateUnitStatus(simEngineEntityState.elapsedTime, false, false);
										}
										if (scenario_.FifthSecondIsChangingOnThisPulse && current2.IsOperating())
										{
											current2.GetAirOps().UpdateLandingQueue();
											current2.GetAirOps().ScheduleEmergencyLandingEvent();
										}
										if (!current2.IsGroup && current2.IsOperating() && scenario_.SecondIsChangingOnThisPulse)
										{
											current2.GetDamage().UpdateDamageStatus(simEngineEntityState.elapsedTime);
										}
										if (scenario_.SecondIsChangingOnThisPulse && !current2.IsWeapon && !current2.IsGroup && current2.IsOperating())
										{
											current2.GetWeaponry().HandleWeaponSalvos(simEngineEntityState.elapsedTime);
											if (Information.IsNothing(current2.GetAI().m_ActiveUnit))
											{
												current2.GetAI().m_ActiveUnit = current2;
											}
											current2.GetAI().UpdateMissionStatus(simEngineEntityState.elapsedTime);
										}
									}
									if (current2.IsOperating())
									{
										current2.GetKinematics().UpdateUnitPositions(simEngineEntityState.elapsedTime, true, false);
										if (!current2.IsGroup)
										{
											current2.UpdatePropulsionState(simEngineEntityState.elapsedTime);
										}
									}
								}
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								ex4.Data.Add("Error at 300003", "");
								GameGeneral.LogException(ref ex4);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								ProjectData.ClearProjectError();
							}
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						ex6.Data.Add("Error at 300004", "");
						GameGeneral.LogException(ref ex6);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					GameGeneral.ProcessEffects(ref scenario_, simEngineEntityState.elapsedTime, ref random);
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ex8.Data.Add("Error at 300005", "");
					GameGeneral.LogException(ref ex8);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				try
				{
					GameGeneral.EvaluateSidesProcess(scenario_, simEngineEntityState.elapsedTime);
				}
				catch (Exception ex9)
				{
					ProjectData.SetProjectError(ex9);
					Exception ex10 = ex9;
					ex10.Data.Add("Error at 300006", "");
					GameGeneral.LogException(ref ex10);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				try
				{
					if (scenario_.SecondIsChangingOnThisPulse)
					{
						bool flag = false;
						if (GameGeneral.SecondsSinceLastPulse <= 3.40282347E+38f)
						{
							GameGeneral.SecondsSinceLastPulse += 1f;
						}
						if (scenario_.GetTimeCompression() == 1)
						{
							if (GameGeneral.SecondsSinceLastPulse >= 1f)
							{
								flag = true;
							}
						}
						else if (scenario_.GetTimeCompression() == 5)
						{
							if (GameGeneral.SecondsSinceLastPulse >= 5f)
							{
								flag = true;
							}
						}
						else if (scenario_.GetTimeCompression() == 15)
						{
							if (GameGeneral.SecondsSinceLastPulse >= 15f)
							{
								flag = true;
							}
						}
						else if (scenario_.GetTimeCompression() == 30)
						{
							if (GameGeneral.SecondsSinceLastPulse >= 30f)
							{
								flag = true;
							}
						}
						else if (GameGeneral.SecondsSinceLastPulse >= 60f)
						{
							flag = true;
						}
						if (flag)
						{
							List<EventTrigger> list = new List<EventTrigger>();
							foreach (EventTrigger current3 in scenario_.GetEventTriggers().Values)
							{
								if (current3.eventTriggerType == EventTrigger.EventTriggerType.UnitRemainsInArea && ((EventTrigger_UnitRemainsInArea)current3).method_11(scenario_, GameGeneral.SecondsSinceLastPulse))
								{
									list.Add(current3);
								}
							}
							scenario_.TriggerEvents(list);
							GameGeneral.SecondsSinceLastPulse = 0f;
						}
					}
				}
				catch (Exception ex11)
				{
					ProjectData.SetProjectError(ex11);
					Exception ex12 = ex11;
					ex12.Data.Add("Error at 300007", "");
					GameGeneral.LogException(ref ex12);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex13)
			{
				ProjectData.SetProjectError(ex13);
				Exception ex14 = ex13;
				ex14.Data.Add("Error at 300009", "");
				GameGeneral.LogException(ref ex14);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006BE4 RID: 27620 RVA: 0x003BFAB8 File Offset: 0x003BDCB8
		private static void ScenarioStateKeeperSchedule(Scenario scenario_0, float elapsedTime_)
		{
			GameGeneral.ScenarioStateKeeper scenarioStateKeeper = new GameGeneral.ScenarioStateKeeper(null);
			scenarioStateKeeper.scenario = scenario_0;
			scenarioStateKeeper.elapsedTime = elapsedTime_;
			try
			{
				scenarioStateKeeper.scenario.SetGuidedWeaponsInAir(null);
				scenarioStateKeeper.scenario.SetSonobuoysInWater(null);
				scenarioStateKeeper.scenario.SetAllWeaponsAlive(null);
				scenarioStateKeeper.scenario.GetGuidedWeaponsInAir();
				GameGeneral.SideFriendsDictionary = new Dictionary<Side, List<Side>>();
				Side[] sides = scenarioStateKeeper.scenario.GetSides();
				checked
				{
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						side.GetObservableContactList();
						List<Side> list = new List<Side>();
						side.EvaluateSides(scenarioStateKeeper.scenario, list, null);
						list.Remove(side);
						GameGeneral.SideFriendsDictionary.Add(side, list);
					}
				}
				if (scenarioStateKeeper.scenario.GetUnguidedWeapons().Count > 0)
				{
					int count = scenarioStateKeeper.scenario.GetUnguidedWeapons().Count;
					List<UnguidedWeapon> list2 = scenarioStateKeeper.scenario.GetUnguidedWeapons().Values.ToList<UnguidedWeapon>();
					for (int j = count - 1; j >= 0; j += -1)
					{
						UnguidedWeapon arg_F3_0 = list2[j];
					}
				}
				scenarioStateKeeper.scenario.Cache_FacilitiesWithPiers = scenarioStateKeeper.scenario.GetActiveUnitList().Where(GameGeneral.HasPier).ToList<ActiveUnit>();
				scenarioStateKeeper.scenario.SetActiveUnitList(null);
				Side[] sides2 = scenarioStateKeeper.scenario.GetSides();
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				ActiveUnit activeUnit = null;
				Side[] sides3;
				int l;
				checked
				{
					for (int k = 0; k < sides2.Length; k++)
					{
						Side side2 = sides2[k];
						using (List<Contact>.Enumerator enumerator = side2.GetContactList().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								enumerator.Current.method_53(scenarioStateKeeper.elapsedTime, scenarioStateKeeper.scenario);
							}
						}
					}
					foreach (ActiveUnit current in scenarioStateKeeper.scenario.GetActiveUnitList())
					{
						if (current.IsOperating() && scenarioStateKeeper.scenario.SecondIsChangingOnThisPulse && !current.IsGroup)
						{
							Sensor[] allNoneMCMSensors = current.GetAllNoneMCMSensors();
							current.GetSensory().DoScanningAndDetecting(allNoneMCMSensors);
						}
						current.CheckNoNavZone(scenarioStateKeeper.elapsedTime);
						current.GetSensory().method_70(scenarioStateKeeper.elapsedTime);
						current.GetWeaponry().method_3();
						if (!current.IsGroup && !Misc.smethod_16(current.GetWeaponry().lazy_0.Value))
						{
							current.GetWeaponry().lazy_0.Value.Clear();
						}
						if (current.IsWeapon)
						{
							Weapon weapon = (Weapon)current;
							weapon.bPrimaryTargetAttackable = weapon.IsPrimaryTargetAttackable(scenarioStateKeeper.elapsedTime);
						}
						current.m_Doctrine.Init();
						Doctrine doctrine = current.m_Doctrine;
						Scenario scenario = scenarioStateKeeper.scenario;
						bool flag = true;
						doctrine.GetDoctrine(scenario, ref flag);
					}
					GameGeneral.UpdateGroups(ref scenarioStateKeeper.scenario);
					sides3 = scenarioStateKeeper.scenario.GetSides();
					l = 0;
				}
				while (l < sides3.Length)
				{
					Side side3 = sides3[l];
					if (Information.IsNothing(side3.GetActiveUnitCollection0()))
					{
						side3.SetActiveUnitCollectionEvent0(new ObservableCollection<ActiveUnit>());
					}
					if (Information.IsNothing(side3.GetActiveUnitCollection1()))
					{
						side3.SetActiveUnitCollectionEvent1(new ObservableCollection<ActiveUnit>());
					}
					side3.GetActiveUnitCollection0().Clear();
					side3.GetActiveUnitCollection1().Clear();
					List<ActiveUnit> list3 = new List<ActiveUnit>();
					try
					{
						list3.AddRange(scenarioStateKeeper.scenario.GetActiveUnits().Values);
						num3 = list3.Count;
						num2 = num3 - 1;
						num = 0;
						goto IL_634;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200002", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						list3.AddRange(scenarioStateKeeper.scenario.GetActiveUnits().Values);
						ProjectData.ClearProjectError();
						num3 = list3.Count;
						num2 = num3 - 1;
						num = 0;
						goto IL_634;
					}
					goto IL_3FC;
					IL_634:
					if (num > num2)
					{
						if (scenarioStateKeeper.scenario.SecondIsChangingOnThisPulse)
						{
							int num4 = num3 - 1;
							for (int m = 0; m <= num4; m++)
							{
								activeUnit = list3[m];
								if (!activeUnit.IsGroup && activeUnit.IsOperating())
								{
									activeUnit.GetCommStuff().vmethod_1(scenarioStateKeeper.elapsedTime);
								}
							}
						}
						side3.SetActiveUnitList0(null);
						side3.GetActiveUnitList0();
						side3.SetActiveUnitList1(null);
						side3.GetActiveUnitList1();
						if (scenarioStateKeeper.scenario.MinuteIsChangingOnThisPulse)
						{
							GameGeneral.ScenarioStateKeeper scenarioStateKeeper2 = scenarioStateKeeper;
							Mission mission = null;
							GameGeneral.smethod_24(ref scenarioStateKeeper2.scenario, ref side3, ref mission, false, true, true);
						}
						if (scenarioStateKeeper.scenario.FifteenthSecondIsChangingOnThisPulse)
						{
							GameGeneral.ScenarioStateKeeper scenarioStateKeeper3 = scenarioStateKeeper;
							ActiveUnit activeUnit2 = null;
							StrikePlanner.smethod_35(ref scenarioStateKeeper3.scenario, ref side3, ref activeUnit2);
						}
						checked
						{
							l++;
							continue;
						}
					}
					IL_3FC:
					activeUnit = list3[num];
					if (activeUnit.GetSide(false) != side3)
					{
						if (activeUnit.IsGroup)
						{
							Group group = (Group)activeUnit;
							if (group.GetGroupType() == Group.GroupType.AirBase || group.GetGroupType() == Group.GroupType.Installation || group.GetGroupType() == Group.GroupType.NavalBase)
							{
								goto IL_494;
							}
							if (group.GetGroupType() == Group.GroupType.MobileGroup)
							{
								goto IL_494;
							}
							bool arg_4AD_0 = true;
							IL_4AD:
							if (arg_4AD_0)
							{
								goto IL_51D;
							}
							bool flag2 = false;
							foreach (Unit current2 in group.GetUnitsInGroup().Values)
							{
								if (side3.GetContactObservableDictionary().ContainsKey(current2.GetGuid()))
								{
									flag2 = true;
									break;
								}
							}
							if (flag2)
							{
								side3.GetActiveUnitCollection1().Add(activeUnit);
								goto IL_51D;
							}
							goto IL_51D;
							IL_494:
							arg_4AD_0 = GameGeneral.SideFriendsDictionary[activeUnit.GetSide(false)].Contains(side3);
							goto IL_4AD;
						}
						if (activeUnit.IsOperating() && !GameGeneral.SideFriendsDictionary[activeUnit.GetSide(false)].Contains(side3))
						{
							side3.GetActiveUnitCollection0().Add(activeUnit);
						}
					}
					IL_51D:
					if (scenarioStateKeeper.scenario.SecondIsChangingOnThisPulse && !activeUnit.IsGroup && activeUnit.IsOperating())
					{
						activeUnit.GetCommStuff().ClearOccupiedChannels();
					}
					num++;
					goto IL_634;
				}
				GameGeneral.UpdateContactsOffGridInfo(scenarioStateKeeper.scenario, scenarioStateKeeper.elapsedTime);
				Parallel.ForEach<Side>(scenarioStateKeeper.scenario.GetSides(), new Action<Side>(scenarioStateKeeper.UpdateSensoryState));
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 300010", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

        // Token: 0x06006BE5 RID: 27621 RVA: 0x003C01F8 File Offset: 0x003BE3F8
        //private static void smethod_12(Scenario scenario_, float elapsedTime)
        private static void EvaluateSidesProcess(Scenario scenario_, float elapsedTime)
        {
            try
            {
                scenario_.UpdateActiveUnits();
                try
                {
                    foreach (ActiveUnit unit in scenario_.GetUnitRemovals().ToList<ActiveUnit>())
                    {
                        Side[] sides = scenario_.GetSides();
                        for (int i = 0; i < sides.Length; i++)
                        {
                            ScenarioArrayUtil.RemoveActiveUnit(ref sides[i].ActiveUnitArray, unit);
                        }
                    }
                    Dictionary<Side, List<Side>> dictionary = new Dictionary<Side, List<Side>>();
                    foreach (Side side in scenario_.GetSides())
                    {
                        List<Side> friendsList = new List<Side>();
                        side.EvaluateSides(scenario_, friendsList, null);
                        friendsList.Remove(side);
                        dictionary.Add(side, friendsList);
                    }
                }
                catch (Exception exception)
                {
                    ProjectData.SetProjectError(exception);
                    Exception exception2 = exception;
                    exception2.Data.Add("Error at 101255", "");
                    LogException(ref exception2);
                    if (Debugger.IsAttached)
                    {
                        Debugger.Break();
                    }
                    ProjectData.ClearProjectError();
                }
                smethod_21(scenario_, SideFriendsDictionary);
                try
                {
                    Side[] sideArray3 = scenario_.GetSides();
                    int index = 0;
                Label_0110:
                    if (index < sideArray3.Length)
                    {
                        Side side2 = sideArray3[index];
                        side2.SetNoneWeaponFriendlyUnits(scenario_, null);
                        side2.LazyContactListOnGridClear(scenario_);
                        side2.LazyNewContactDictionaryClear(scenario_);
                        bool flag = side2.ExclusionZoneList.Count > 0;
                        List<Contact> list3 = null;
                        List<Contact> list4 = null;
                        try
                        {
                            using (List<Contact>.Enumerator enumerator2 = side2.GetContactList().GetEnumerator())
                            {
                                while (enumerator2.MoveNext())
                                {
                                    enumerator2.Current.method_54(elapsedTime, side2, scenario_);
                                }
                            }
                            list4 = new List<Contact>();
                            list3 = new List<Contact>();
                        }
                        catch (Exception exception3)
                        {
                            ProjectData.SetProjectError(exception3);
                            Exception exception4 = exception3;
                            exception4.Data.Add("Error at 200291", "");
                            LogException(ref exception4);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                            list4 = new List<Contact>();
                            list3 = new List<Contact>();
                        }
                        while (true)
                        {
                            bool? nullable3;
                            try
                            {
                                list3.AddRange(side2.GetContactList());
                            }
                            catch (Exception exception5)
                            {
                                ProjectData.SetProjectError(exception5);
                                Exception exception6 = exception5;
                                exception6.Data.Add("Error at 200003", "");
                                LogException(ref exception6);
                                if (Debugger.IsAttached)
                                {
                                    Debugger.Break();
                                }
                                list3.AddRange(side2.GetContactList());
                                ProjectData.ClearProjectError();
                            }
                            ActiveUnit[] expression = null;
                            Contact contactX;
                            foreach (Contact contact in list3)
                            {
                                if (!Information.IsNothing(contact.ActualUnit))
                                {
                                    if ((contact.ActualUnit.IsFixedFacility() && (contact.GetIdentificationStatus() < Contact_Base.IdentificationStatus.PreciseID)) && contact.ActualUnit.IsAutoDetectable(side2))
                                    {
                                        float? distance = null;
                                        contact.TargetIdentification(scenario_, side2, null, distance, false, true, Contact_Base.IdentificationStatus.PreciseID);
                                    }
                                    if (((!Information.IsNothing(contact) && !Information.IsNothing(contact.OriginalDetectorSide)) && (contact.OriginalDetectorSide != side2)) && ((contact.OriginalDetectorSide.ActiveUnitArray.Length == 0) || !SideFriendsDictionary[contact.OriginalDetectorSide].Contains(side2)))
                                    {
                                        list4.Add(contact);
                                    }
                                    else
                                    {
                                        if (scenario_.SecondIsChangingOnThisPulse)
                                        {
                                            contactX = contact;
                                            smethod_13(ref scenario_, ref side2, ref contactX);
                                        }
                                        if (scenario_.FifthSecondIsChangingOnThisPulse && flag)
                                        {
                                            if (contact.SZC)
                                            {
                                                continue;
                                            }
                                            if ((Information.IsNothing(contact.ActualUnit) || !contact.ActualUnit.IsShip) || !((Ship)contact.ActualUnit).IsDestroyed())
                                            {
                                                Misc.PostureStance postureStance = contact.GetPostureStance(side2);
                                                if ((postureStance != Misc.PostureStance.Hostile) && (postureStance != Misc.PostureStance.Friendly))
                                                {
                                                    foreach (ExclusionZone zone in side2.ExclusionZoneList)
                                                    {
                                                        Misc.PostureStance markViolatorAs;
                                                        bool flag2;
                                                        if (((((postureStance != Misc.PostureStance.Hostile) && (zone.Area.Count != 0)) && (!Information.IsNothing(contact.ActualUnit) && zone.IsAffected(contact.ActualUnit))) && contact.ActualUnit.vmethod_40(zone.Area, scenario_, true)) && contact.vmethod_40(zone.Area, scenario_, true))
                                                        {
                                                            markViolatorAs = zone.MarkViolatorAs;
                                                            if (postureStance != markViolatorAs)
                                                            {
                                                                if (markViolatorAs == Misc.PostureStance.Unfriendly)
                                                                {
                                                                    goto Label_0707;
                                                                }
                                                                if (markViolatorAs == Misc.PostureStance.Hostile)
                                                                {
                                                                    if (Information.IsNothing(expression))
                                                                    {
                                                                        expression = new ActiveUnit[0];
                                                                        foreach (Side side3 in scenario_.GetSides())
                                                                        {
                                                                            if ((side3 == side2) | (side3.GetPostureStance(side2) == Misc.PostureStance.Friendly))
                                                                            {
                                                                                foreach (ActiveUnit unit2 in side3.ActiveUnitArray)
                                                                                {
                                                                                    if (!unit2.GetCommStuff().IsNotOutOfComms())
                                                                                    {
                                                                                        expression = (ActiveUnit[])Utils.CopyArray(expression, new ActiveUnit[expression.Length + 1]);
                                                                                        expression[expression.Length - 1] = unit2;
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                    if (expression.Length <= 0)
                                                                    {
                                                                        goto Label_0687;
                                                                    }
                                                                    flag2 = false;
                                                                    foreach (ActiveUnit unit3 in expression)
                                                                    {
                                                                        bool isAttached = Debugger.IsAttached;
                                                                        if (((((unit3.IsAircraft && contact.IsAir()) || (unit3.IsShip && contact.IsSurface())) || ((unit3.IsSubmarine && contact.IsSubSurface()) || (unit3.IsFacility && (contact.contactType == Contact_Base.ContactType.Facility_Mobile)))) && (contact.HorizontalRangeTo(unit3.GetLatitudeLR().Value, unit3.GetLongitudeLR().Value) < 10f)) && (postureStance != Misc.PostureStance.Unfriendly))
                                                                        {
                                                                            nullable3 = null;
                                                                            nullable3 = null;
                                                                            scenario_.LogMessage("目标: " + contact.Name + "闯入封锁区: " + zone.Description + "但是接近我方平台：" + unit3.Name + "上次报告的位置,现视为非友方，等待进一步查证", LoggedMessage.MessageType.ContactChange, 0, null, side2, new GeoPoint(contact.GetLongitude(nullable3), contact.GetLatitude(nullable3)));
                                                                            flag2 = true;
                                                                            contact.MarkAs(side2, false, Misc.PostureStance.Unfriendly);
                                                                            contact.SZC = true;
                                                                        }
                                                                    }
                                                                    if (!flag2)
                                                                    {
                                                                        goto Label_0687;
                                                                    }
                                                                    contact.MarkAs(side2, false, Misc.PostureStance.Unfriendly);
                                                                    contact.SZC = true;
                                                                }
                                                            }
                                                        }
                                                        continue;
                                                                                                               
                                                    Label_0687:;
                                                        nullable3 = null;
                                                        nullable3 = null;
                                                        scenario_.LogMessage("目标: " + contact.Name + "闯入封锁区: " + zone.Description + "，被视为敌对方", LoggedMessage.MessageType.ContactChange, 0, null, side2, new GeoPoint(contact.GetLongitude(nullable3), contact.GetLatitude(nullable3)));
                                                        contact.MarkAs(side2, false, markViolatorAs);
                                                        continue;
                                                    Label_0707:;
                                                        nullable3 = null;
                                                        nullable3 = null;
                                                        scenario_.LogMessage("目标: " + contact.Name + "闯入封锁区: " + zone.Description + "，被视为非友方", LoggedMessage.MessageType.ContactChange, 0, null, side2, new GeoPoint(contact.GetLongitude(nullable3), contact.GetLatitude(nullable3)));
                                                        contact.MarkAs(side2, false, markViolatorAs);
                                                    }
                                                }
                                            }
                                        }
                                        if (!(Information.IsNothing(contact.ActualUnit) || scenario_.GetActiveUnits().ContainsKey(contact.ActualUnit.GetGuid())))
                                        {
                                            side2.Lazy3DictionaryTryAdd(contact, ref scenario_, true);
                                        }
                                        if (Information.IsNothing(contact.ActualUnit))
                                        {
                                            side2.Lazy3DictionaryTryAdd(contact, ref scenario_, true);
                                        }
                                        if (!Information.IsNothing(contact.ActualUnit))
                                        {
                                            if (contact.ActualUnit.IsAutoDetectable(side2))
                                            {
                                                contactX = contact;
                                                ActiveUnit_Sensory.smethod_2(ref contactX, contact.ActualUnit, false, null);
                                            }
                                            if (!contact.ActualUnit.IsOperating())
                                            {
                                                
                                                side2.Lazy3DictionaryTryAdd(contact, ref scenario_, true);
                                            }
                                        }
                                        if (contact.Age == 0f)
                                        {
                                            contact.HeldFor += elapsedTime;
                                        }
                                    }
                                }
                            }
                            foreach (Contact contact2 in side2.GetBaseContacts())
                            {
                                if (Information.IsNothing(contact2.ActualUnit))
                                {
                                    continue;
                                }
                                if (!(Information.IsNothing(contact2.ActualUnit) || scenario_.GetActiveUnits().ContainsKey(contact2.ActualUnit.GetGuid())))
                                {
                                    side2.Lazy4DictionaryTryAdd(contact2, ref scenario_, true);
                                }
                                if (Information.IsNothing(contact2.ActualUnit))
                                {
                                    side2.Lazy4DictionaryTryAdd(contact2, ref scenario_, true);
                                    continue;
                                }
                                if (contact2.contactType != Contact_Base.ContactType.MobileGroup)
                                {
                                    continue;
                                }
                                bool flag3 = false;
                                using (IEnumerator<ActiveUnit> enumerator6 = ((Group)contact2.ActualUnit).GetUnitsInGroup().Values.GetEnumerator())
                                {
                                    while (enumerator6.MoveNext())
                                    {
                                        Unit current = enumerator6.Current;
                                        if (side2.GetContactObservableDictionary().ContainsKey(current.GetGuid()))
                                        {
                                            goto Label_0960;
                                        }
                                    }
                                    goto Label_0974;
                                Label_0960:
                                    flag3 = true;
                                }
                            Label_0974:
                                if (!flag3)
                                {
                                    side2.Lazy4DictionaryTryAdd(contact2, ref scenario_, true);
                                }
                            }
                            List<ReferencePoint> list5 = new List<ReferencePoint>();
                            list5.AddRange(side2.GetReferencePoints());
                            foreach (ExclusionZone zone2 in side2.ExclusionZoneList)
                            {
                                foreach (ReferencePoint point in zone2.Area)
                                {
                                    if (!(Information.IsNothing(point.IsRelativeToUnit) || side2.GetReferencePoints().Contains(point)))
                                    {
                                        list5.Add(point);
                                    }
                                }
                            }
                            foreach (NoNavZone zone3 in side2.NoNavZoneList)
                            {
                                foreach (ReferencePoint point2 in zone3.Area)
                                {
                                    if (!(Information.IsNothing(point2.IsRelativeToUnit) || side2.GetReferencePoints().Contains(point2)))
                                    {
                                        list5.Add(point2);
                                    }
                                }
                            }
                            foreach (ReferencePoint point3 in list5)
                            {
                                if (!Information.IsNothing(point3) && !Information.IsNothing(point3.IsRelativeToUnit))
                                {
                                    if (!(!point3.IsRelativeToUnit.IsActiveUnit() || scenario_.GetActiveUnits().ContainsKey(point3.IsRelativeToUnit.GetGuid())))
                                    {
                                        point3.IsRelativeToUnit = null;
                                    }
                                    else if (!(!point3.IsRelativeToUnit.IsContact() || side2.GetContactObservableDictionary().ContainsKey(point3.IsRelativeToUnit.GetGuid())))
                                    {
                                        point3.IsRelativeToUnit = null;
                                    }
                                    else
                                    {
                                        ReferencePoint point4;
                                        ReferencePoint point5;
                                        ReferencePoint.OrientationType bearingType = point3.BearingType;
                                        float relativeDistance = 0f;
                                        switch (bearingType)
                                        {
                                            case ReferencePoint.OrientationType.Fixed:
                                                relativeDistance = point3.RelativeDistance;
                                                break;

                                            case ReferencePoint.OrientationType.Rotating:
                                                relativeDistance = Math2.Normalize((float)(point3.IsRelativeToUnit.GetCurrentHeading() + point3.RelativeDistance));
                                                break;
                                        }
                                        nullable3 = null;
                                        double longitude = point3.IsRelativeToUnit.GetLongitude(nullable3);
                                        nullable3 = null;
                                        double latitude = point3.IsRelativeToUnit.GetLatitude(nullable3);
                                        double num10 = (point4 = point3).GetLongitude();
                                        double num11 = (point5 = point3).GetLatitude();
                                        GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref num10, ref num11, (double)point3.RelativeDistance, (double)relativeDistance);
                                        point5.SetLatitude(num11);
                                        point4.SetLongitude(num10);
                                    }
                                }
                            }
                            foreach (Contact contact3 in list4)
                            {
                                side2.Lazy3DictionaryTryAdd(contact3, ref scenario_, true);
                            }
                            foreach (ActiveUnit unit5 in side2.ActiveUnitArray.ToList<ActiveUnit>())
                            {
                                unit5.vmethod_5();
                                unit5.GetSensory().method_71(elapsedTime);
                                if (!unit5.IsGroup)
                                {
                                    if (scenario_.SecondIsChangingOnThisPulse)
                                    {
                                        unit5.GetSensory().ScheduleNextDetectionCycle(unit5.GetAllNoneMCMSensors());
                                        if (unit5.IsSubmarine)
                                        {
                                            unit5.float_19++;
                                        }
                                    }
                                    unit5.SetAllNoneMCMSensors(null);
                                }
                                if (!(unit5.IsGroup || Misc.smethod_16(unit5.GetWeaponry().lazy_0.Value)))
                                {
                                    unit5.GetWeaponry().lazy_0.Value.Clear();
                                }
                                if (unit5.IsWeapon)
                                {
                                    Contact primaryTarget = unit5.GetAI().GetPrimaryTarget();
                                    if ((!Information.IsNothing(primaryTarget) && !Information.IsNothing(primaryTarget.ActualUnit)) && (primaryTarget.GetRCTT() > 0f))
                                    {
                                        primaryTarget.Age = 0f;
                                        ActiveUnit_Sensory.smethod_2(ref primaryTarget, primaryTarget.ActualUnit, false, null);
                                    }
                                }
                            }
                            index++;
                            goto Label_0110;
                        }
                    }
                }
                catch (Exception exception7)
                {
                    ProjectData.SetProjectError(exception7);
                    Exception exception8 = exception7;
                    exception8.Data.Add("Error at 101254", "");
                    LogException(ref exception8);
                    if (Debugger.IsAttached)
                    {
                        Debugger.Break();
                    }
                    ProjectData.ClearProjectError();
                }
                scenario_.SetActiveUnitList(null);
                scenario_.SetGuidedWeaponsInAir(null);
                scenario_.SetSonobuoysInWater(null);
                scenario_.SetAllWeaponsAlive(null);
                scenario_.UpdateExplosionList();
            }
            catch (Exception exception9)
            {
                ProjectData.SetProjectError(exception9);
                Exception exception10 = exception9;
                exception10.Data.Add("Error at 300012", "");
                LogException(ref exception10);
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }
                ProjectData.ClearProjectError();
            }

        }

        // Token: 0x06006BE6 RID: 27622 RVA: 0x003C1234 File Offset: 0x003BF434
        public static void smethod_13(ref Scenario scenario_, ref Side side_, ref Contact target_)
		{
			checked
			{
				if (side_.ActiveUnitArray.Length > 0)
				{
					Side[] sides = scenario_.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						if (side != side_ && GameGeneral.SideFriendsDictionary[side_].Contains(side) && !Information.IsNothing(target_.ActualUnit))
						{
							Contact contact = null;
							if (!side.GetContactObservableDictionary().TryGetValue(target_.ActualUnit.GetGuid(), ref contact))
							{
								if (!target_.ActualUnit.GetSide(false).IsFriendlyToSide(side) && target_.ActualUnit.GetSide(false) != side && side.ActiveUnitArray.Length > 0)
								{
									side.AddToContactList_OnGrid(target_);
								}
							}
							else
							{
								target_.method_121(ref target_, ref contact);
								if (target_ != contact)
								{
									side_.ContactUpdateToContact(target_, contact, null, scenario_, true);
									side.ContactUpdateToContact(contact, target_, null, scenario_, false);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06006BE7 RID: 27623 RVA: 0x003C1330 File Offset: 0x003BF530
		private static void UpdateGroups(ref Scenario scenario_)
		{
			try
			{
				scenario_.Groups.Clear();
				IEnumerable<ActiveUnit> enumerable = scenario_.GetActiveUnits().Values.Where(GameGeneral.IsGroupFilter).ToList<ActiveUnit>();
				using (IEnumerator<ActiveUnit> enumerator = enumerable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Group item = (Group)enumerator.Current;
						if (!scenario_.Groups.Contains(item))
						{
							scenario_.Groups.Add(item);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 300013", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006BE8 RID: 27624 RVA: 0x003C140C File Offset: 0x003BF60C
		private static void UpdateContactsOffGridInfo(Scenario scenario, float elapsedTime)
		{
			checked
			{
				try
				{
					Side[] sides = scenario.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						using (IEnumerator<Contact> enumerator = side.GetContactObservableDictionary().Values.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								enumerator.Current.UpdateContactOffGridInfo(side, elapsedTime, scenario);
							}
						}
						List<ActiveUnit> list = side.ActiveUnitArray.ToList<ActiveUnit>();
						using (List<ActiveUnit>.Enumerator enumerator2 = list.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								enumerator2.Current.GetSensory().UpdateContactsOffGridInfo(elapsedTime);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 300014", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006BE9 RID: 27625 RVA: 0x0002E190 File Offset: 0x0002C390
		public static void AddActiveUnit(ref ActiveUnit activeUnit, ref Scenario scenario_)
		{
			scenario_.GetActiveUnits().Add(activeUnit.GetGuid(), activeUnit);
		}

		// Token: 0x06006BEA RID: 27626 RVA: 0x0002E1A7 File Offset: 0x0002C3A7
		public static void ClearWeaponImpacts(ref Scenario scenario_0)
		{
			scenario_0.GetWeaponImpacts().Clear();
		}

		// Token: 0x06006BEB RID: 27627 RVA: 0x003C1524 File Offset: 0x003BF724
        //处理特效
		private static void ProcessEffects(ref Scenario scenario_, float elapsedTime_, ref Random random_)
		{
			try
			{
				if (scenario_.GetExplosions().Count > 0)
				{
					for (int i = scenario_.GetExplosions().Count - 1; i >= 0; i += -1)
					{
						scenario_.GetExplosions()[i].ProcessExplosion(ref scenario_, elapsedTime_);
					}
				}
				if (scenario_.GetWaterSplashes().Count > 0)
				{
					for (int j = scenario_.GetWaterSplashes().Count - 1; j >= 0; j += -1)
					{
						scenario_.GetWaterSplashes()[j].ProcessWaterSplash(scenario_, elapsedTime_);
					}
				}
				if (scenario_.GetGroundImpacts().Count > 0)
				{
					for (int k = scenario_.GetGroundImpacts().Count - 1; k >= 0; k += -1)
					{
						scenario_.GetGroundImpacts()[k].ProcessGroundImpact(scenario_, elapsedTime_);
					}
				}
				scenario_.CandidatesForDetectionByMines = new ActiveUnit[0];
				List<ActiveUnit> activeUnitList = scenario_.GetActiveUnitList();
				foreach (ActiveUnit current in activeUnitList)
				{
					if ((current.IsShip || current.IsSubmarine || current.IsMineSweeper()) && current.IsOperating())
					{
						ScenarioArrayUtil.AddActiveUnit(ref scenario_.CandidatesForDetectionByMines, current);
					}
				}
				if (scenario_.GetUnguidedWeapons().Count > 0)
				{
					int count = scenario_.GetUnguidedWeapons().Count;
					List<UnguidedWeapon> list = scenario_.GetUnguidedWeapons().Values.ToList<UnguidedWeapon>();
					for (int l = count - 1; l >= 0; l += -1)
					{
						list[l].method_67(ref scenario_, elapsedTime_, ref random_);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 300016", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006BEC RID: 27628 RVA: 0x003C1754 File Offset: 0x003BF954
		public static void RemoveUnit(ref Scenario scenario_, string UnitGuid)
		{
			ActiveUnit activeUnit = null;
			try
			{
				if (scenario_.GetActiveUnits().TryGetValue(UnitGuid, ref activeUnit))
				{
					activeUnit.DestroyUnit(true, false, false);
					scenario_.GetActiveUnits().Remove(UnitGuid);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 300018", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006BED RID: 27629 RVA: 0x003C17DC File Offset: 0x003BF9DC
		public static void SerializeScenario(Scenario scenario_)
		{
			try
			{
				while (scenario_.ExecutionInProgress)
				{
					Thread.Sleep(10);
				}
				scenario_.SerializationInProgress = true;
				Stream1 stream = new Stream1();
				scenario_.Serialize(stream, true);
				if (GameGeneral.ScenarioStreamDictionary.ContainsKey(scenario_))
				{
					GameGeneral.ScenarioStreamDictionary[scenario_] = stream;
				}
				else
				{
					GameGeneral.ScenarioStreamDictionary.TryAdd(scenario_, stream);
				}
				scenario_.SerializationInProgress = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200581", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006BEE RID: 27630 RVA: 0x003C1894 File Offset: 0x003BFA94
		public static void smethod_21(Scenario scenario_0, Dictionary<Side, List<Side>> dictionary_1)
		{
            try
            {
                List<Contact> list2;
                List<Contact>.Enumerator enumerator;
                Side[] sides = scenario_0.GetSides();
                int index = 0;
            Label_000A:
                if (index >= sides.Length)
                {
                    return;
                }
                Side side = sides[index];
                List<Contact> list = new List<Contact>();
                try
                {
                    list.AddRange(side.GetContactList());
                    list2 = new List<Contact>();
                }
                catch (Exception exception)
                {
                    ProjectData.SetProjectError(exception);
                    list.AddRange(side.GetContactList());
                    ProjectData.ClearProjectError();
                    list2 = new List<Contact>();
                }
                goto Label_0112;
            Label_005D:
                try
                {
                    while (enumerator.MoveNext())
                    {
                        Contact current = enumerator.Current;
                        if (((current.SideIsKnown && !Information.IsNothing(current.ActualUnit)) && !current.ActualUnit.IsDetected(side)) && dictionary_1[current.ActualUnit.GetSide(false)].Contains(side))
                        {
                            list2.Add(current);
                        }
                    }
                }
                finally
                {
                    enumerator.Dispose();
                }
                foreach (Contact contact2 in list2)
                {
                    side.Lazy3DictionaryTryAdd(contact2, ref scenario_0, false);
                }
                index++;
                goto Label_000A;
            Label_0112:
                enumerator = list.GetEnumerator();
                goto Label_005D;
            }
            catch (Exception exception2)
            {
                ProjectData.SetProjectError(exception2);
                Exception exception3 = exception2;
                exception3.Data.Add("Error at 300019", "");
                LogException(ref exception3);
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }
                ProjectData.ClearProjectError();
            }

        }

        // Token: 0x06006BEF RID: 27631 RVA: 0x003C1A68 File Offset: 0x003BFC68
        public static void LogException(ref Exception exception_1)
		{
			try
			{
				if (Information.IsNothing(SimConfiguration.gameOptions) || SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append(DateAndTime.Now).Append(" -- B").Append("906.21").Append(" -- ").Append(exception_1.Message).Append("\r\n").Append("Exception: ").Append(exception_1.Message).Append("\r\n").Append("Stack Trace: ").Append(exception_1.StackTrace).Append("\r\n");
					if (!Information.IsNothing(exception_1.InnerException))
					{
						stringBuilder.Append("Inner Exception: ").Append(exception_1.InnerException.Message).Append("\r\n").Append("Inner StackTrace: ").Append(exception_1.InnerException.StackTrace).Append("\r\n");
					}
					if (exception_1.Data.Count > 0)
					{
						stringBuilder.Append("Call Stack & Error details: ");
						IDictionaryEnumerator enumerator = exception_1.Data.GetEnumerator();
						while (enumerator.MoveNext())
						{
							object current = enumerator.Current;
							DictionaryEntry dictionaryEntry = (current != null) ? ((DictionaryEntry)current) : default(DictionaryEntry);
							stringBuilder.Append("\r\n").Append(Conversions.ToString(dictionaryEntry.Key)).Append(", ").Append(Conversions.ToString(dictionaryEntry.Value));
						}
					}
					try
					{
						StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\ExceptionLog.txt");
						streamWriter.Write("\r\n\r\n" + stringBuilder.ToString());
						streamWriter.Close();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					stringBuilder.Clear();
					stringBuilder = null;
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006BF0 RID: 27632 RVA: 0x003C1CB8 File Offset: 0x003BFEB8
		public static void Log(ref string string_9)
		{
			try
			{
				if (Information.IsNothing(SimConfiguration.gameOptions) || SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					try
					{
						StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\ExceptionLog.txt");
						streamWriter.Write("\r\n\r\n" + string_9);
						streamWriter.Close();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x003C1D68 File Offset: 0x003BFF68
		public static void smethod_24(ref Scenario scenario_, ref Side side_0, ref Mission mission_, bool bool_1, bool bool_2, bool bool_3)
		{
			try
			{
				if (!Information.IsNothing(side_0.GetMissionCollection()))
				{
					using (IEnumerator<Mission> enumerator = side_0.GetPatrolMissionCollection(scenario_).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							GameGeneral.MissionContainer missionContainer = new GameGeneral.MissionContainer(null);
							missionContainer.mission = enumerator.Current;
							if (!Information.IsNothing(missionContainer.mission))
							{
								bool flag = false;
								if (Information.IsNothing(mission_) || missionContainer.mission == mission_)
								{
									if (missionContainer.mission.GetMissionStatus(scenario_) == Mission._MissionStatus.DeActivation)
									{
										if (missionContainer.mission.GetStartTime().HasValue)
										{
											DateTime? dateTime = missionContainer.mission.GetStartTime();
											DateTime currentTime = scenario_.GetCurrentTime(false);
											if ((dateTime.HasValue ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), currentTime) <= 0) : null).GetValueOrDefault() && (!missionContainer.mission.GetEndTime().HasValue || (missionContainer.mission.GetEndTime().HasValue && DateTime.Compare(missionContainer.mission.GetEndTime().Value, scenario_.GetCurrentTime(false)) > 0)))
											{
												missionContainer.mission.SetMissionStatus(scenario_, Mission._MissionStatus.Activation);
												scenario_.LogMessage("任务：" + missionContainer.mission.Name + "开始启用。", LoggedMessage.MessageType.UnitAI, 0, null, side_0, null);
											}
										}
									}
									else if (missionContainer.mission.GetEndTime().HasValue)
									{
										DateTime? dateTime = missionContainer.mission.GetEndTime();
										DateTime currentTime = scenario_.GetCurrentTime(false);
										if ((dateTime.HasValue ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), currentTime) <= 0) : null).GetValueOrDefault())
										{
											missionContainer.mission.SetMissionStatus(scenario_, Mission._MissionStatus.DeActivation);
											flag = true;
											scenario_.LogMessage("任务：" + missionContainer.mission.Name + "已经停止启用。", LoggedMessage.MessageType.UnitAI, 0, null, side_0, null);
										}
									}
									if (flag)
									{
										using (List<ActiveUnit>.Enumerator enumerator2 = scenario_.GetActiveUnitList().GetEnumerator())
										{
											while (enumerator2.MoveNext())
											{
												ActiveUnit current = enumerator2.Current;
												if (!current.IsGroup && current.IsOperating() && current.GetAssignedMission(false) == missionContainer.mission)
												{
													if (current.IsAircraft)
													{
														if (current.GetAirOps().vmethod_6(true, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, false, true))
														{
															string str = "";
															if (Operators.CompareString(current.Name, current.UnitClass, false) != 0)
															{
																str = " (" + current.UnitClass + ")";
															}
															string str2 = "";
															ActiveUnit assignedHostUnit = ((Aircraft)current).GetAircraftAirOps().GetAssignedHostUnit();
															if (!Information.IsNothing(assignedHostUnit))
															{
																str2 = " (" + assignedHostUnit.Name + ")";
															}
															current.m_Scenario.LogMessage(current.Name + str + "正在返回基地：" + str2, LoggedMessage.MessageType.AirOps, 5, current.GetGuid(), current.GetSide(false), null);
														}
													}
													else if ((current.IsShip || current.IsSubmarine) && current.GetDockingOps().method_7(true, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, false, true))
													{
														string str3 = "";
														ActiveUnit assignedHostUnit2 = current.GetDockingOps().GetAssignedHostUnit();
														if (!Information.IsNothing(assignedHostUnit2))
														{
															str3 = " (" + assignedHostUnit2.Name + ")";
														}
														current.m_Scenario.LogMessage(current.Name + "正在返回停靠平台：" + str3, LoggedMessage.MessageType.DockingOps, 5, current.GetGuid(), current.GetSide(false), null);
													}
												}
											}
											continue;
										}
									}
									List<Group> list = new List<Group>();
									List<Aircraft> list2 = new List<Aircraft>();
									List<Aircraft> list3 = new List<Aircraft>();
									List<Aircraft> list4 = new List<Aircraft>();
									double num = 120.0;
									if (missionContainer.mission.GetMissionStatus(scenario_) == Mission._MissionStatus.Activation || !bool_2)
									{
										if (bool_3 && missionContainer.mission.HasFlights())
										{
											Mission mission = missionContainer.mission;
											GameGeneral.MissionContainer missionContainer2 = missionContainer;
											bool flag2 = false;
											mission.method_21(ref scenario_, ref side_0, ref missionContainer2.mission, ref flag2);
											int count = missionContainer.mission.FlightList.Count;
											list.Clear();
											list2.Clear();
											list3.Clear();
											list4.Clear();
											for (int i = count - 1; i >= 0; i += -1)
											{
												Mission.Flight flight = missionContainer.mission.FlightList[i];
												if (!Information.IsNothing(flight.GetFlightCourse()) && flight.GetFlightCourse().Count<Waypoint>() > 0)
												{
													Waypoint waypoint = flight.GetFlightCourse()[0];
													double num2;
													if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
													{
														num2 = -1.0;
													}
													else
													{
														if (DateTime.Compare(scenario_.GetCurrentTime(false), waypoint.ArrivalTime_Zulu.Value) > 0)
														{
															goto IL_7EC;
														}
														num2 = (waypoint.ArrivalTime_Zulu.Value - scenario_.GetCurrentTime(false)).TotalSeconds - num - 60.0;
													}
													if (num2 < 0.0)
													{
														List<ActiveUnit> list5 = new List<ActiveUnit>();
														ActiveUnit[] activeUnitArray = side_0.ActiveUnitArray;
														checked
														{
															for (int j = 0; j < activeUnitArray.Length; j++)
															{
																ActiveUnit activeUnit = activeUnitArray[j];
																if (!Information.IsNothing(activeUnit.GetAssignedMission(false)) && !Information.IsNothing(activeUnit.GetNavigator().GetFlight()) && flight == activeUnit.GetNavigator().GetFlight() && activeUnit.IsAircraft && !activeUnit.IsOperating())
																{
																	Aircraft aircraft = (Aircraft)activeUnit;
																	Aircraft aircraft2 = aircraft;
																	string text = null;
																	if (aircraft2.GetMaintenanceLevel(ref text) == Aircraft_AirOps._Maintenance.const_0 && aircraft.IsParkedInPlace())
																	{
																		list5.Add(activeUnit);
																		list2.Add((Aircraft)activeUnit);
																	}
																}
															}
														}
														if (list5.Count > 1)
														{
															if (list5.Count < (int)flight.MinimumAircraftQty)
															{
																foreach (ActiveUnit current2 in list5)
																{
																	list2.Remove((Aircraft)current2);
																}
																if (missionContainer.mission.int_0 == 1)
																{
																	scenario_.LogMessage(string.Concat(new string[]
																	{
																		"飞行编队",
																		flight.Callsign,
																		"最少需要",
																		Conversions.ToString((int)flight.MinimumAircraftQty),
																		"架飞机，但是只有",
																		Conversions.ToString(list5.Count),
																		"架飞机完成了出动准备！飞行编队不能出动！"
																	}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
																}
															}
															else
															{
																Mission.Flight flight2 = list5[0].GetNavigator().GetFlight();
																Group group = new Group(ref scenario_, ref side_0, list5, true, null, missionContainer.mission);
																list.Add(group);
																int num3 = 2;
																foreach (ActiveUnit current3 in group.GetUnitsInGroup().Values)
																{
																	if (current3.IsGroupLead())
																	{
																		current3.method_114(flight2, 1);
																		group.Name = "Flight " + flight2.Callsign;
																	}
																	else
																	{
																		current3.method_114(flight2, num3);
																		num3++;
																	}
																}
															}
														}
													}
												}
												IL_7EC:;
											}
											missionContainer.mission.PreparingToLaunch(list, list2, list3, list4);
										}
										List<Aircraft> list6 = new List<Aircraft>();
										List<Aircraft> list7 = new List<Aircraft>();
										List<Aircraft> list8 = new List<Aircraft>();
										List<Aircraft> list9 = new List<Aircraft>();
										List<ActiveUnit> source = new List<ActiveUnit>();
										List<ActiveUnit> list10 = new List<ActiveUnit>();
										List<ActiveUnit> list11 = new List<ActiveUnit>();
										List<ActiveUnit> list12 = new List<ActiveUnit>();
										List<int> list13 = new List<int>();
										List<int> list14 = new List<int>();
										List<int> list15 = new List<int>();
										int num4 = 0;
										int num5 = 0;
										int num6 = 0;
										int num7 = 0;
										int num8 = 0;
										int num9 = 0;
										List<Mission.Flight> list16 = new List<Mission.Flight>();
										List<Mission.Flight> list17 = new List<Mission.Flight>();
										List<Mission.Flight> list18 = new List<Mission.Flight>();
										if (missionContainer.mission.int_0 >= 30)
										{
											missionContainer.mission.int_0 = 1;
										}
										else
										{
											missionContainer.mission.int_0++;
										}
										List<Aircraft> list19 = new List<Aircraft>();
										List<Aircraft> list20 = new List<Aircraft>();
										List<Aircraft> list21 = new List<Aircraft>();
										int num10 = 0;
										int num11 = 0;
										int num12 = 0;
										if (bool_1 && !Information.IsNothing(missionContainer.mission.EmptySlotsList) && missionContainer.mission.EmptySlotsList.Count > 0)
										{
											int num13 = 1;
											foreach (Mission.EmptySlot current4 in missionContainer.mission.EmptySlotsList)
											{
												Mission mission2 = missionContainer.mission;
												int aircraftDBID = current4.aircraftDBID;
												int loadoutDBID = current4.LoadoutDBID;
												Mission.EmptySlot emptySlot;
												Scenario scenario;
												ActiveUnit hostUnit = (emptySlot = current4).GetHostUnit(scenario = scenario_);
												Mission.EmptySlot emptySlot2;
												Scenario scenario_2;
												Mission.Flight flight_ = (emptySlot2 = current4).GetFlight(scenario_2 = scenario);
												Aircraft referenceUnit = mission2.GetReferenceUnit(ref scenario, ref side_0, aircraftDBID, loadoutDBID, ref hostUnit, ref flight_, current4.IsEscort, num13);
												emptySlot2.SetFlight(scenario_2, flight_);
												emptySlot.SetHostUnit(scenario, hostUnit);
												Aircraft aircraft3 = referenceUnit;
												current4.method_1(scenario, null, aircraft3);
												list19.Add(aircraft3);
												num13++;
											}
										}
										missionContainer.mission.method_20(scenario_, ref list13, ref list14, ref list6, ref list7, ref list8, ref list9, ref list11, ref num4, ref num5, ref num6, ref num7, ref num8, ref num9, ref list15, ref source, ref list10, list12, ref list19, ref list20, ref list21, ref num10, ref num11, ref num12, ref list16, ref list17, ref list18, bool_2, bool_1);
										if (num7 > 0 || (bool_1 && num10 > 0))
										{
											GameGeneral.AIFeedback aIFeedback = new GameGeneral.AIFeedback(null);
											aIFeedback._MissionContainer = missionContainer;
											List<Aircraft> list22 = new List<Aircraft>();
											List<Aircraft> list23 = new List<Aircraft>();
											List<Aircraft> list24 = new List<Aircraft>();
											int? num14 = null;
											int? num15 = null;
											int? num16 = null;
											int? num17 = null;
											int? num18 = null;
											int? num19 = null;
											Doctrine._UseRefuel? useRefuelDoctrine = aIFeedback._MissionContainer.mission.m_Doctrine.GetUseRefuelDoctrine(scenario_, false, false, false, false);
											aIFeedback.Feedback = "";
											aIFeedback.FeedbackType = 0;
											aIFeedback.FeedbackSeverity = 0;
											list.Clear();
											list2.Clear();
											list3.Clear();
											list4.Clear();
											bool? flag3;
											bool? flag4;
											if (Information.IsNothing(mission_) && !Information.IsNothing(useRefuelDoctrine))
											{
												byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
												flag3 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null);
												flag4 = (flag3.HasValue ? new bool?(!flag3.GetValueOrDefault()) : flag3);
											}
											else
											{
												flag4 = new bool?(false);
											}
											flag3 = flag4;
											if (flag3.GetValueOrDefault() && aIFeedback._MissionContainer.mission.TankerUsage == Mission.TankerMethod.Mission)
											{
												if (Information.IsNothing(aIFeedback._MissionContainer.mission.TankerMissionList) || aIFeedback._MissionContainer.mission.TankerMissionList.Count == 0)
												{
													scenario_.LogMessage("任务 " + aIFeedback._MissionContainer.mission.Name + "需要来自特定任务的加油机，但是没有选择相应的加油机任务! 打击任务不能启动!", LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
													continue;
												}
												if (aIFeedback._MissionContainer.mission.TankerMinNumber_Total > 0 || aIFeedback._MissionContainer.mission.TankerMinNumber_Airborne > 0 || aIFeedback._MissionContainer.mission.TankerMinNumber_Station > 0)
												{
													int num20 = 0;
													int num21 = 0;
													int num22 = 0;
													foreach (Mission current5 in aIFeedback._MissionContainer.mission.TankerMissionList)
													{
														foreach (ActiveUnit current6 in current5.GetUnitsAssignedToMe(scenario_))
														{
															if (current6.IsAircraft)
															{
																Aircraft aircraft4 = (Aircraft)current6;
																if (aircraft4.IsAirRefuelingCapable() && (aircraft4.GetSide(false) == side_0 || aircraft4.GetSide(false).IsFriendlyToSide(side_0)))
																{
																	if (aircraft4.GetSide(false) != side_0)
																	{
																		Doctrine._RefuelAlliedUnits? refuelAlliedUnitsDoctrine = aircraft4.m_Doctrine.GetRefuelAlliedUnitsDoctrine(scenario_, false, false, false);
																		byte? b = refuelAlliedUnitsDoctrine.HasValue ? new byte?((byte)refuelAlliedUnitsDoctrine.GetValueOrDefault()) : null;
																		if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
																		{
																			continue;
																		}
																		b = (refuelAlliedUnitsDoctrine.HasValue ? new byte?((byte)refuelAlliedUnitsDoctrine.GetValueOrDefault()) : null);
																		if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
																		{
																			continue;
																		}
																	}
																	num20++;
																	if (aircraft4.IsOperating())
																	{
																		num21++;
																		if (current5.MissionClass == Mission._MissionClass.Support && !aircraft4.GetAircraftNavigator().method_11())
																		{
																			num22++;
																		}
																	}
																}
															}
														}
													}
													if (aIFeedback._MissionContainer.mission.TankerMinNumber_Total > 0)
													{
														if (num20 == 0)
														{
															if (aIFeedback._MissionContainer.mission.int_0 == 1)
															{
																scenario_.LogMessage(string.Concat(new string[]
																{
																	"任务：",
																	aIFeedback._MissionContainer.mission.Name,
																	"总共需要",
																	Conversions.ToString(aIFeedback._MissionContainer.mission.TankerMinNumber_Total),
																	"架加油机，但是没有可用的加油机！任务飞机不能出动！"
																}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
																continue;
															}
															continue;
														}
														else if (num20 < aIFeedback._MissionContainer.mission.TankerMinNumber_Total)
														{
															if (aIFeedback._MissionContainer.mission.int_0 == 1)
															{
																scenario_.LogMessage(string.Concat(new string[]
																{
																	"任务：",
																	aIFeedback._MissionContainer.mission.Name,
																	"总共需要",
																	Conversions.ToString(aIFeedback._MissionContainer.mission.TankerMinNumber_Total),
																	"架加油机，但是只有",
																	Conversions.ToString(num20),
																	"架加油机可用！任务飞机不能出动！"
																}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
																continue;
															}
															continue;
														}
													}
													if (aIFeedback._MissionContainer.mission.TankerMinNumber_Airborne > 0)
													{
														if (num21 == 0)
														{
															if (aIFeedback._MissionContainer.mission.int_0 == 1)
															{
																scenario_.LogMessage(string.Concat(new string[]
																{
																	"任务：",
																	aIFeedback._MissionContainer.mission.Name,
																	"需要",
																	Conversions.ToString(aIFeedback._MissionContainer.mission.TankerMinNumber_Airborne),
																	"架在空加油机，但是当前没有在空加油机！任务飞机不能出动!"
																}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
																continue;
															}
															continue;
														}
														else if (num21 < aIFeedback._MissionContainer.mission.TankerMinNumber_Airborne)
														{
															if (aIFeedback._MissionContainer.mission.int_0 == 1)
															{
																scenario_.LogMessage(string.Concat(new string[]
																{
																	"任务：",
																	aIFeedback._MissionContainer.mission.Name,
																	"需要",
																	Conversions.ToString(aIFeedback._MissionContainer.mission.TankerMinNumber_Airborne),
																	"架留空加油机，但是只有",
																	Conversions.ToString(num21),
																	"架加油机在空！任务飞机不能出动!"
																}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
																continue;
															}
															continue;
														}
													}
													if (aIFeedback._MissionContainer.mission.TankerMinNumber_Station > 0)
													{
														if (num22 == 0)
														{
															if (aIFeedback._MissionContainer.mission.int_0 == 1)
															{
																scenario_.LogMessage(string.Concat(new string[]
																{
																	"任务：",
																	aIFeedback._MissionContainer.mission.Name,
																	"需要",
																	Conversions.ToString(aIFeedback._MissionContainer.mission.TankerMinNumber_Station),
																	"架加油机处于阵位保障，但是当前阵位上没有加油机！任务飞机不能出动!"
																}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
																continue;
															}
															continue;
														}
														else if (num22 < aIFeedback._MissionContainer.mission.TankerMinNumber_Station)
														{
															if (aIFeedback._MissionContainer.mission.int_0 == 1)
															{
																scenario_.LogMessage(string.Concat(new string[]
																{
																	"任务：",
																	aIFeedback._MissionContainer.mission.Name,
																	"需要",
																	Conversions.ToString(aIFeedback._MissionContainer.mission.TankerMinNumber_Station),
																	"架加油机在阵位保障，但是只有",
																	Conversions.ToString(num22),
																	"架加油机当前处于阵位！任务飞机不能出动!"
																}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
																continue;
															}
															continue;
														}
													}
												}
											}
											using (List<Aircraft>.Enumerator enumerator8 = list7.GetEnumerator())
											{
												while (enumerator8.MoveNext())
												{
													enumerator8.Current.GetAircraftKinematics().SetBingoJokerFuel();
												}
											}
											Strike strike = null;
											Mission._FlightSize flightSize = Mission._FlightSize.None;
											Mission._FlightSize flightSize2 = Mission._FlightSize.None;
											Mission._FlightSize flightSize3 = Mission._FlightSize.None;
											bool flag5 = false;
											bool flag6 = false;
											Strike.StrikeType strikeType = Strike.StrikeType.Air_Intercept;
											switch (aIFeedback._MissionContainer.mission.MissionClass)
											{
											case Mission._MissionClass.Strike:
												strike = (Strike)aIFeedback._MissionContainer.mission;
												if (strike.OneTimeOnly && strike.OneTimeOnlyFlown)
												{
													if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
													{
														scenario_.LogMessage("***警告*** 任务 " + aIFeedback._MissionContainer.mission.Name + "只允许执行一次。任务已执行过一次，不能再次起飞。将飞机从任务中删除。", LoggedMessage.MessageType.SpecialMessage, 0, null, side_0, null);
													}
													if (!Information.IsNothing(mission_))
													{
														Interaction.MsgBox("***警告*** 任务 " + aIFeedback._MissionContainer.mission.Name + "只允许执行一次。 任务已执行过一次，不能再次起飞。 将飞机从任务中删除。", MsgBoxStyle.OkOnly, null);
													}
													using (List<Aircraft>.Enumerator enumerator9 = list6.GetEnumerator())
													{
														while (enumerator9.MoveNext())
														{
															Aircraft current7 = enumerator9.Current;
															if (!current7.IsOperating() && !current7.GetAircraftAirOps().method_24())
															{
																current7.DeleteMission(false, null);
															}
														}
														continue;
													}
												}
												if (strike.PrePlannedOnly && strike.SpecificTargets.Count == 0)
												{
													if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
													{
														scenario_.LogMessage("作战任务[" + aIFeedback._MissionContainer.mission.Name + "]只允许攻击目标清单中的目标，但目标清单为空。因此，任务行动不能展开。要么添加目标，要么去掉只允许攻击预先规划目标的限制", LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
													}
													if (!Information.IsNothing(mission_))
													{
														Interaction.MsgBox("作战任务[" + aIFeedback._MissionContainer.mission.Name + "]只允许攻击目标清单中的目标，但目标清单为空。因此，任务行动不能展开。要么添加目标，要么去掉只允许攻击预先规划目标的限制", MsgBoxStyle.OkOnly, null);
														continue;
													}
													continue;
												}
												else
												{
													List<Mission.Flight> list25 = new List<Mission.Flight>();
													foreach (Mission.Flight current8 in aIFeedback._MissionContainer.mission.list_0)
													{
														if (Information.IsNothing(current8))
														{
															list25.Add(current8);
														}
														else
														{
															Mission.Flight flight3 = current8;
															Waypoint[] array = flight3.GetFlightCourse();
															ScenarioArrayUtil.ClearWaypoints(ref array);
															flight3.SetFlightCourse(array);
															current8.UsedByFlight = false;
															if (Information.IsNothing(current8.PrimaryTarget))
															{
																Mission.Flight flight4 = current8;
																array = flight4.GetWaypoint1();
																ScenarioArrayUtil.ClearWaypoints(ref array);
																flight4.SetWaypoint1(array);
															}
															if (current8.Age > 120)
															{
																current8.Age = 0;
																Mission.Flight flight5 = current8;
																array = flight5.GetWaypoint1();
																ScenarioArrayUtil.ClearWaypoints(ref array);
																flight5.SetWaypoint1(array);
																current8.bool_11 = false;
															}
															else if (current8.Age > 10 && !current8.bool_11)
															{
																current8.Age = 0;
																Mission.Flight flight5 = current8;
																array = flight5.GetWaypoint1();
																ScenarioArrayUtil.ClearWaypoints(ref array);
																flight5.SetWaypoint1(array);
															}
															else
															{
																current8.Age++;
															}
															if (current8.GetFlightCourse().Count<Waypoint>() == 0 && current8.GetWaypoint1().Count<Waypoint>() == 0 && !current8.bool_11 && !current8.bool_13)
															{
																list25.Add(current8);
															}
															current8.bool_13 = false;
														}
													}
													foreach (Mission.Flight current9 in list25)
													{
														aIFeedback._MissionContainer.mission.list_0.Remove(current9);
													}
													flightSize = aIFeedback._MissionContainer.mission.m_FlightSize;
													flightSize2 = strike.Escort_FlightSize_Shooter;
													flightSize3 = strike.Escort_FlightSize_NonShooter;
													num14 = aIFeedback._MissionContainer.mission.GetFlightQty(ref flightSize, ref strike.MinAircraftReq_Strikers);
													num15 = aIFeedback._MissionContainer.mission.GetFlightQty(ref flightSize, ref strike.MaxAircraftToFly_Strikers);
													num16 = aIFeedback._MissionContainer.mission.GetFlightQty(ref flightSize2, ref strike.MinAircraftReq_Escorts_Shooter);
													num17 = aIFeedback._MissionContainer.mission.GetFlightQty(ref flightSize2, ref strike.MaxAircraftToFly_Escort_Shooter);
													num18 = aIFeedback._MissionContainer.mission.GetFlightQty(ref flightSize3, ref strike.MinAircraftReq_Escorts_NonShooter);
													num19 = aIFeedback._MissionContainer.mission.GetFlightQty(ref flightSize3, ref strike.MaxAircraftToFly_Escort_NonShooter);
													flag5 = strike.UseFlightSizeHardLimit;
													flag6 = strike.UseFlightSizeHardLimit_Escort;
													if (GameGeneral.smethod_25(ref scenario_, ref side_0, ref aIFeedback._MissionContainer.mission, ref list6, ref list7, num14, flightSize) && (Information.IsNothing(num15) || num4 <= 0) && (Information.IsNothing(num17) || num5 <= 0) && (flightSize3 == Mission._FlightSize.None || Information.IsNothing(num19) || num6 <= 0))
													{
														strikeType = strike.strikeType;
														switch (strikeType)
														{
														case Strike.StrikeType.Air_Intercept:
														{
															List<Mission.Class131> list26 = new List<Mission.Class131>();
															foreach (Aircraft current10 in list7)
															{
																if (list26.Count > 0)
																{
																	bool flag7 = false;
																	foreach (Mission.Class131 current11 in list26)
																	{
																		if (Operators.CompareString(current11.string_0, current10.GetAircraftAirOps().GetCurrentHostUnit().GetGuid(), false) == 0 && current11.int_0 == current10.DBID && current11.int_1 == current10.GetLoadout().DBID)
																		{
																			flag7 = true;
																		}
																	}
																	if (flag7)
																	{
																		continue;
																	}
																}
																bool flag8 = true;
																if (current10.GetAircraftAI().IsEscort)
																{
																	if (current10.GetLoadout().method_15() && flightSize3 != Mission._FlightSize.None)
																	{
																		list24.Add(current10);
																	}
																	else
																	{
																		list23.Add(current10);
																	}
																}
																else
																{
																	Doctrine._ShootTourists? shootTouristsDoctrine = current10.m_Doctrine.GetShootTouristsDoctrine(scenario_, false, false, false);
																	foreach (Contact current12 in side_0.GetContactList())
																	{
																		if (current10.GetAircraftAI().IsTargetForMission(current12, aIFeedback._MissionContainer.mission, shootTouristsDoctrine, false, false, true, ref aIFeedback.Feedback, ref aIFeedback.FeedbackType) && current10.GetAircraftAI().method_23(ref strike, current12.GetPostureStance(current10.GetSide(false))) && current10.GetAircraftAI().method_20(current10, current12, strike.MinResponseRadius, strike.MaxResponseRadius, useRefuelDoctrine, aIFeedback._MissionContainer.mission.LaunchMissionWithoutTankersInPlace, ref aIFeedback.Feedback) && current12.method_112(scenario_, side_0, null).Count < (int)flightSize)
																		{
																			current10.GetAircraftAI().SetPrimaryTarget(current12);
																			list22.Add(current10);
																			flag8 = false;
																			break;
																		}
																	}
																	if (flag8)
																	{
																		Aircraft_AirOps aircraftAirOps = current10.GetAircraftAirOps();
																		Mission.Class131 item = new Mission.Class131(aircraftAirOps.GetCurrentHostUnit().GetGuid(), aircraftAirOps.GetCurrentHostUnit().Name, current10.DBID, current10.UnitClass, current10.GetLoadout().DBID, current10.GetLoadout().Name);
																		list26.Add(item);
																	}
																}
															}
															if (list26.Count > 0)
															{
																using (List<Mission.Class131>.Enumerator enumerator15 = list26.GetEnumerator())
																{
																	while (enumerator15.MoveNext())
																	{
																		Mission.Class131 current13 = enumerator15.Current;
																		if (!string.IsNullOrEmpty(aIFeedback.Feedback))
																		{
																			if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
																			{
																				scenario_.LogMessage(string.Concat(new string[]
																				{
																					"任务：",
																					strike.Name,
																					", 飞机型号：",
																					current13.strAircraftType,
																					" 挂载方案： ",
																					current13.strLoadoutName,
																					" 起降机场： ",
																					current13.TakeOffLocation_HostUnitObjectName,
																					"不能出动！原因: ",
																					aIFeedback.Feedback
																				}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
																			}
																			if (!Information.IsNothing(mission_))
																			{
																				Interaction.MsgBox(string.Concat(new string[]
																				{
																					"任务：",
																					strike.Name,
																					", 飞机型号：",
																					current13.strAircraftType,
																					" 挂载方案： ",
																					current13.strLoadoutName,
																					" 起降机场： ",
																					current13.TakeOffLocation_HostUnitObjectName,
																					"不能出动！原因: ",
																					aIFeedback.Feedback
																				}), MsgBoxStyle.OkOnly, null);
																			}
																		}
																	}
																	break;
																}
																goto IL_1BCD;
															}
															break;
														}
														case Strike.StrikeType.Land_Strike:
															goto IL_1BCD;
														case Strike.StrikeType.Maritime_Strike:
															goto IL_24B2;
														case Strike.StrikeType.Sub_Strike:
															goto IL_2D97;
														}
														IL_3679:
														if (aIFeedback._MissionContainer.mission.list_0.Count > 0)
														{
															using (List<Mission.Flight>.Enumerator enumerator16 = aIFeedback._MissionContainer.mission.list_0.GetEnumerator())
															{
																while (enumerator16.MoveNext())
																{
																	Mission.Flight current14 = enumerator16.Current;
																	if (current14.bool_14 && !Information.IsNothing(current14.GetReferenceUnit(scenario_)) && !string.IsNullOrEmpty(current14.Reason))
																	{
																		if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
																		{
																			scenario_.LogMessage(string.Concat(new string[]
																			{
																				"任务：",
																				strike.Name,
																				", 飞机型号：",
																				current14.GetReferenceUnit(scenario_).UnitClass,
																				" 挂载方案： ",
																				((Aircraft)current14.GetReferenceUnit(scenario_)).GetLoadoutName(),
																				" 起降机场： ",
																				current14.TakeOffLocation_HostUnitObjectName,
																				"不能出动！原因: ",
																				current14.Reason
																			}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
																		}
																		if (!Information.IsNothing(mission_))
																		{
																			Interaction.MsgBox(string.Concat(new string[]
																			{
																				"任务：",
																				strike.Name,
																				", 飞机型号：",
																				current14.GetReferenceUnit(scenario_).UnitClass,
																				" 挂载方案： ",
																				((Aircraft)current14.GetReferenceUnit(scenario_)).GetLoadoutName(),
																				" 起降机场： ",
																				current14.TakeOffLocation_HostUnitObjectName,
																				"不能出动！原因: ",
																				current14.Reason
																			}), MsgBoxStyle.OkOnly, null);
																		}
																	}
																}
																goto IL_4ADA;
															}
															break;
														}
														goto IL_4ADA;
														IL_2D97:
														using (List<Aircraft>.Enumerator enumerator17 = list7.GetEnumerator())
														{
															while (enumerator17.MoveNext())
															{
																GameGeneral.AircraftAIFeedback aircraftAIFeedback = new GameGeneral.AircraftAIFeedback(null);
																aircraftAIFeedback._AIFeedback = aIFeedback;
																aircraftAIFeedback.aircraft = enumerator17.Current;
																GameGeneral.AircraftAIFeedbackForShootTouristDoctrine aircraftAIFeedbackForShootTouristDoctrine = new GameGeneral.AircraftAIFeedbackForShootTouristDoctrine(null);
																aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback = aircraftAIFeedback;
																if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().IsEscort)
																{
																	if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadout().method_15() && flightSize3 != Mission._FlightSize.None)
																	{
																		list24.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																	}
																	else
																	{
																		list23.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																	}
																}
																else
																{
																	Mission.Flight flight6 = null;
																	if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Count != 0)
																	{
																		bool flag9 = false;
																		foreach (Mission.Flight current15 in aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0)
																		{
																			if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadoutDBID() == current15.LoadoutDBID && Operators.CompareString(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAirOps().GetCurrentHostUnit().GetGuid(), current15.TakeOffLocation_HostUnitObjectID, false) == 0)
																			{
																				if (current15.bool_13)
																				{
																					flag9 = true;
																				}
																				else if (current15.bool_14)
																				{
																					flag9 = true;
																				}
																				else if (current15.GetFlightCourse().Count<Waypoint>() > 0)
																				{
																					list22.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																					Contact primaryTarget = null;
																					aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().SetPrimaryTarget(primaryTarget);
																					flag9 = true;
																				}
																				else if (current15.GetWaypoint1().Count<Waypoint>() > 0)
																				{
																					if (current15.GetWaypoint1()[0].waypointType == Waypoint.WaypointType.PathfindingPoint)
																					{
																						flight6 = current15;
																					}
																					else
																					{
																						list22.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																						Contact primaryTarget = null;
																						aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().SetPrimaryTarget(primaryTarget);
																						flag9 = true;
																					}
																				}
																				else if (current15.bool_11)
																				{
																					flag9 = true;
																				}
																				break;
																			}
																		}
																		if (flag9)
																		{
																			continue;
																		}
																	}
																	bool flag10 = true;
																	aircraftAIFeedbackForShootTouristDoctrine.shootTouristsDoctrine = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.m_Doctrine.GetShootTouristsDoctrine(scenario_, false, false, false);
																	if (strike.SpecificTargets.Count > 0)
																	{
																		using (List<Contact>.Enumerator enumerator19 = side_0.GetContactList().GetEnumerator())
																		{
																			while (enumerator19.MoveNext())
																			{
																				Contact current16 = enumerator19.Current;
																				if (current16.IsSpecificTargetForStikeMission(strike) && aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().method_23(ref strike, current16.GetPostureStance(side_0)) && aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftWeaponry().HasWeaponsInConditionToAttackTarget(current16, true, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.m_Doctrine, ref aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback, ref aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.FeedbackSeverity, null))
																				{
																					if (Information.IsNothing(flight6))
																					{
																						Aircraft_AirOps aircraftAirOps2 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAirOps();
																						GameGeneral.MissionContainer missionContainer3 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer;
																						Mission.Flight flight_ = null;
																						flight6 = new Mission.Flight(ref scenario_, ref missionContainer3.mission, ref flight_, "Master Flight Plan", aircraftAirOps2.GetCurrentHostUnit().GetGuid(), aircraftAirOps2.GetCurrentHostUnit().Name, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadout().DBID, current16, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																					}
																					ActiveUnit_AI aircraftAI = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI();
																					GameGeneral.AircraftAIFeedback aircraftAIFeedback2 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback;
																					Strike.StrikeType strikeType2 = Strike.StrikeType.Sub_Strike;
																					int minResponseRadius = strike.MinResponseRadius;
																					int maxResponseRadius = strike.MaxResponseRadius;
																					Doctrine._UseRefuel? useRefuel_ = useRefuelDoctrine;
																					bool launchMissionWithoutTankersInPlace = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.LaunchMissionWithoutTankersInPlace;
																					Mission._RadarBehaviour radarBehaviour = strike.RadarBehaviour;
																					bool useAutoPlanner = strike.UseAutoPlanner;
																					float num23 = 0f;
																					if (aircraftAI.method_22(ref flight6, ref aircraftAIFeedback2.aircraft, ref current16, ref strikeType2, minResponseRadius, maxResponseRadius, useRefuel_, launchMissionWithoutTankersInPlace, radarBehaviour, true, false, false, useAutoPlanner, ref num23, ref aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback, ref mission_))
																					{
																						flag10 = false;
																						flight6.bool_14 = false;
																						flight6.Reason = "";
																						if (!aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Contains(flight6))
																						{
																							aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Add(flight6);
																						}
																					}
																					if (flight6.GetFlightCourse().Count<Waypoint>() <= 0 && flight6.GetWaypoint1().Count<Waypoint>() <= 0)
																					{
																						if (flag10)
																						{
																							continue;
																						}
																					}
																					else
																					{
																						list22.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																						Contact primaryTarget = current16;
																						aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().SetPrimaryTarget(primaryTarget);
																					}
																					break;
																				}
																			}
																			goto IL_365B;
																		}
																		goto IL_32E1;
																	}
																	goto IL_32E1;
																	IL_3549:
																	if (Information.IsNothing(flight6))
																	{
																		Aircraft_AirOps aircraftAirOps3 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAirOps();
																		GameGeneral.MissionContainer missionContainer4 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer;
																		Mission.Flight flight_ = null;
																		flight6 = new Mission.Flight(ref scenario_, ref missionContainer4.mission, ref flight_, "Master Flight Plan", aircraftAirOps3.GetCurrentHostUnit().GetGuid(), aircraftAirOps3.GetCurrentHostUnit().Name, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadout().DBID, null, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																	}
																	if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Contains(flight6))
																	{
																		continue;
																	}
																	aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Add(flight6);
																	flight6.bool_14 = true;
																	if (!string.IsNullOrEmpty(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback))
																	{
																		flight6.Reason = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback;
																		continue;
																	}
																	continue;
																	IL_32E1:
																	List<Contact> list27 = side_0.GetContactList().Where(new Func<Contact, bool>(aircraftAIFeedbackForShootTouristDoctrine.IsTargetForMyMission)).ToList<Contact>();
																	using (List<Contact>.Enumerator enumerator20 = list27.GetEnumerator())
																	{
																		while (enumerator20.MoveNext())
																		{
																			Contact current17 = enumerator20.Current;
																			if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().method_23(ref strike, current17.GetPostureStance(side_0)))
																			{
																				if (Information.IsNothing(flight6))
																				{
																					Aircraft_AirOps aircraftAirOps4 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAirOps();
																					GameGeneral.MissionContainer missionContainer5 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer;
																					Mission.Flight flight7 = null;
																					flight6 = new Mission.Flight(ref scenario_, ref missionContainer5.mission, ref flight7, "Master Flight Plan", aircraftAirOps4.GetCurrentHostUnit().GetGuid(), aircraftAirOps4.GetCurrentHostUnit().Name, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadout().DBID, current17, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																				}
																				ActiveUnit_AI aircraftAI2 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI();
																				GameGeneral.AircraftAIFeedback aircraftAIFeedback3 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback;
																				Strike.StrikeType strikeType2 = Strike.StrikeType.Sub_Strike;
																				int minResponseRadius2 = strike.MinResponseRadius;
																				int maxResponseRadius2 = strike.MaxResponseRadius;
																				Doctrine._UseRefuel? useRefuel_2 = useRefuelDoctrine;
																				bool launchMissionWithoutTankersInPlace2 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.LaunchMissionWithoutTankersInPlace;
																				Mission._RadarBehaviour radarBehaviour2 = strike.RadarBehaviour;
																				bool useAutoPlanner2 = strike.UseAutoPlanner;
																				float num23 = 0f;
																				if (aircraftAI2.method_22(ref flight6, ref aircraftAIFeedback3.aircraft, ref current17, ref strikeType2, minResponseRadius2, maxResponseRadius2, useRefuel_2, launchMissionWithoutTankersInPlace2, radarBehaviour2, true, false, false, useAutoPlanner2, ref num23, ref aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback, ref mission_))
																				{
																					flag10 = false;
																					flight6.bool_14 = false;
																					flight6.Reason = "";
																					if (!aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Contains(flight6))
																					{
																						aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Add(flight6);
																					}
																				}
																				if (flight6.GetFlightCourse().Count<Waypoint>() <= 0 && flight6.GetWaypoint1().Count<Waypoint>() <= 0)
																				{
																					if (flag10)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					list22.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																					Contact primaryTarget = current17;
																					aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().SetPrimaryTarget(primaryTarget);
																				}
																				break;
																			}
																		}
																		goto IL_365B;
																	}
																	goto IL_3549;
																	IL_365B:
																	if (flag10)
																	{
																		goto IL_3549;
																	}
																}
															}
														}
														goto IL_3679;
														IL_24B2:
														using (List<Aircraft>.Enumerator enumerator21 = list7.GetEnumerator())
														{
															while (enumerator21.MoveNext())
															{
																GameGeneral.AircraftAIFeedback aircraftAIFeedback = new GameGeneral.AircraftAIFeedback(null);
																aircraftAIFeedback._AIFeedback = aIFeedback;
																aircraftAIFeedback.aircraft = enumerator21.Current;
																GameGeneral.AircraftAIFeedbackForShootTouristDoctrine aircraftAIFeedbackForShootTouristDoctrine = new GameGeneral.AircraftAIFeedbackForShootTouristDoctrine(null);
																aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback = aircraftAIFeedback;
																if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().IsEscort)
																{
																	if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadout().method_15() && flightSize3 != Mission._FlightSize.None)
																	{
																		list24.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																	}
																	else
																	{
																		list23.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																	}
																}
																else
																{
																	Mission.Flight flight8 = null;
																	if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Count != 0)
																	{
																		bool flag11 = false;
																		foreach (Mission.Flight current18 in aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0)
																		{
																			if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadoutDBID() == current18.LoadoutDBID && Operators.CompareString(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAirOps().GetCurrentHostUnit().GetGuid(), current18.TakeOffLocation_HostUnitObjectID, false) == 0)
																			{
																				if (current18.bool_13)
																				{
																					flag11 = true;
																				}
																				else if (current18.bool_14)
																				{
																					flag11 = true;
																				}
																				else if (current18.GetFlightCourse().Count<Waypoint>() > 0)
																				{
																					list22.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																					Contact primaryTarget = null;
																					aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().SetPrimaryTarget(primaryTarget);
																					flag11 = true;
																				}
																				else if (current18.GetWaypoint1().Count<Waypoint>() > 0)
																				{
																					if (current18.GetWaypoint1()[0].waypointType == Waypoint.WaypointType.PathfindingPoint)
																					{
																						flight8 = current18;
																					}
																					else
																					{
																						list22.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																						Contact primaryTarget = null;
																						aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().SetPrimaryTarget(primaryTarget);
																						flag11 = true;
																					}
																				}
																				else if (current18.bool_11)
																				{
																					flag11 = true;
																				}
																				break;
																			}
																		}
																		if (flag11)
																		{
																			continue;
																		}
																	}
																	bool flag12 = true;
																	aircraftAIFeedbackForShootTouristDoctrine.shootTouristsDoctrine = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.m_Doctrine.GetShootTouristsDoctrine(scenario_, false, false, false);
																	if (strike.SpecificTargets.Count > 0)
																	{
																		using (List<Contact>.Enumerator enumerator23 = side_0.GetContactList().GetEnumerator())
																		{
																			while (enumerator23.MoveNext())
																			{
																				Contact current19 = enumerator23.Current;
																				if (current19.IsSpecificTargetForStikeMission(strike) && aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().method_23(ref strike, current19.GetPostureStance(side_0)) && aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftWeaponry().HasWeaponsInConditionToAttackTarget(current19, true, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.m_Doctrine, ref aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback, ref aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.FeedbackSeverity, null))
																				{
																					if (Information.IsNothing(flight8))
																					{
																						Aircraft_AirOps aircraftAirOps5 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAirOps();
																						GameGeneral.MissionContainer missionContainer6 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer;
																						Mission.Flight flight_ = null;
																						flight8 = new Mission.Flight(ref scenario_, ref missionContainer6.mission, ref flight_, "Master Flight Plan", aircraftAirOps5.GetCurrentHostUnit().GetGuid(), aircraftAirOps5.GetCurrentHostUnit().Name, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadout().DBID, current19, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																					}
																					ActiveUnit_AI aircraftAI3 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI();
																					GameGeneral.AircraftAIFeedback aircraftAIFeedback4 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback;
																					Strike.StrikeType strikeType2 = Strike.StrikeType.Maritime_Strike;
																					int minResponseRadius3 = strike.MinResponseRadius;
																					int maxResponseRadius3 = strike.MaxResponseRadius;
																					Doctrine._UseRefuel? useRefuel_3 = useRefuelDoctrine;
																					bool launchMissionWithoutTankersInPlace3 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.LaunchMissionWithoutTankersInPlace;
																					Mission._RadarBehaviour radarBehaviour3 = strike.RadarBehaviour;
																					bool useAutoPlanner3 = strike.UseAutoPlanner;
																					float num23 = 0f;
																					if (aircraftAI3.method_22(ref flight8, ref aircraftAIFeedback4.aircraft, ref current19, ref strikeType2, minResponseRadius3, maxResponseRadius3, useRefuel_3, launchMissionWithoutTankersInPlace3, radarBehaviour3, true, false, false, useAutoPlanner3, ref num23, ref aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback, ref mission_))
																					{
																						flag12 = false;
																						flight8.bool_14 = false;
																						flight8.Reason = "";
																						if (!aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Contains(flight8))
																						{
																							aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Add(flight8);
																						}
																					}
																					if (flight8.GetFlightCourse().Count<Waypoint>() <= 0 && flight8.GetWaypoint1().Count<Waypoint>() <= 0)
																					{
																						if (flag12)
																						{
																							continue;
																						}
																					}
																					else
																					{
																						list22.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																						Contact primaryTarget = current19;
																						aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().SetPrimaryTarget(primaryTarget);
																					}
																					break;
																				}
																			}
																			goto IL_2D76;
																		}
																		goto IL_29FC;
																	}
																	goto IL_29FC;
																	IL_2C64:
																	if (Information.IsNothing(flight8))
																	{
																		Aircraft_AirOps aircraftAirOps6 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAirOps();
																		GameGeneral.MissionContainer missionContainer7 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer;
																		Mission.Flight flight_ = null;
																		flight8 = new Mission.Flight(ref scenario_, ref missionContainer7.mission, ref flight_, "Master Flight Plan", aircraftAirOps6.GetCurrentHostUnit().GetGuid(), aircraftAirOps6.GetCurrentHostUnit().Name, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadout().DBID, null, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																	}
																	if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Contains(flight8))
																	{
																		continue;
																	}
																	aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Add(flight8);
																	flight8.bool_14 = true;
																	if (!string.IsNullOrEmpty(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback))
																	{
																		flight8.Reason = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback;
																		continue;
																	}
																	continue;
																	IL_29FC:
																	List<Contact> list28 = side_0.GetContactList().Where(new Func<Contact, bool>(aircraftAIFeedbackForShootTouristDoctrine.IsTargetForMyMission)).ToList<Contact>();
																	using (List<Contact>.Enumerator enumerator24 = list28.GetEnumerator())
																	{
																		while (enumerator24.MoveNext())
																		{
																			Contact current20 = enumerator24.Current;
																			if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().method_23(ref strike, current20.GetPostureStance(side_0)))
																			{
																				if (Information.IsNothing(flight8))
																				{
																					Aircraft_AirOps aircraftAirOps7 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAirOps();
																					GameGeneral.MissionContainer missionContainer8 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer;
																					Mission.Flight flight_ = null;
																					flight8 = new Mission.Flight(ref scenario_, ref missionContainer8.mission, ref flight_, "Master Flight Plan", aircraftAirOps7.GetCurrentHostUnit().GetGuid(), aircraftAirOps7.GetCurrentHostUnit().Name, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadout().DBID, current20, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																				}
																				ActiveUnit_AI aircraftAI4 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI();
																				GameGeneral.AircraftAIFeedback aircraftAIFeedback5 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback;
																				Strike.StrikeType strikeType2 = Strike.StrikeType.Maritime_Strike;
																				int minResponseRadius4 = strike.MinResponseRadius;
																				int maxResponseRadius4 = strike.MaxResponseRadius;
																				Doctrine._UseRefuel? useRefuel_4 = useRefuelDoctrine;
																				bool launchMissionWithoutTankersInPlace4 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.LaunchMissionWithoutTankersInPlace;
																				Mission._RadarBehaviour radarBehaviour4 = strike.RadarBehaviour;
																				bool useAutoPlanner4 = strike.UseAutoPlanner;
																				float num23 = 0f;
																				if (aircraftAI4.method_22(ref flight8, ref aircraftAIFeedback5.aircraft, ref current20, ref strikeType2, minResponseRadius4, maxResponseRadius4, useRefuel_4, launchMissionWithoutTankersInPlace4, radarBehaviour4, true, false, false, useAutoPlanner4, ref num23, ref aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback, ref mission_))
																				{
																					flag12 = false;
																					flight8.bool_14 = false;
																					flight8.Reason = "";
																					if (!aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Contains(flight8))
																					{
																						aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Add(flight8);
																					}
																				}
																				if (flight8.GetFlightCourse().Count<Waypoint>() <= 0 && flight8.GetWaypoint1().Count<Waypoint>() <= 0)
																				{
																					if (flag12)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					list22.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																					Contact primaryTarget = current20;
																					aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().SetPrimaryTarget(primaryTarget);
																				}
																				break;
																			}
																		}
																		goto IL_2D76;
																	}
																	goto IL_2C64;
																	IL_2D76:
																	if (flag12)
																	{
																		goto IL_2C64;
																	}
																}
															}
															goto IL_3679;
														}
														goto IL_2D97;
														IL_1BCD:
														using (List<Aircraft>.Enumerator enumerator25 = list7.GetEnumerator())
														{
															while (enumerator25.MoveNext())
															{
																GameGeneral.AircraftAIFeedback aircraftAIFeedback = new GameGeneral.AircraftAIFeedback(null);
																aircraftAIFeedback._AIFeedback = aIFeedback;
																aircraftAIFeedback.aircraft = enumerator25.Current;
																GameGeneral.AircraftAIFeedbackForShootTouristDoctrine aircraftAIFeedbackForShootTouristDoctrine = new GameGeneral.AircraftAIFeedbackForShootTouristDoctrine(null);
																aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback = aircraftAIFeedback;
																if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().IsEscort)
																{
																	if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadout().method_15() && flightSize3 != Mission._FlightSize.None)
																	{
																		list24.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																	}
																	else
																	{
																		list23.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																	}
																}
																else
																{
																	Mission.Flight flight9 = null;
																	if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Count != 0)
																	{
																		bool flag13 = false;
																		foreach (Mission.Flight current21 in aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0)
																		{
																			if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadoutDBID() == current21.LoadoutDBID && Operators.CompareString(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAirOps().GetCurrentHostUnit().GetGuid(), current21.TakeOffLocation_HostUnitObjectID, false) == 0)
																			{
																				if (current21.bool_13)
																				{
																					flag13 = true;
																				}
																				else if (current21.bool_14)
																				{
																					flag13 = true;
																				}
																				else if (current21.GetFlightCourse().Count<Waypoint>() > 0)
																				{
																					list22.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																					Contact primaryTarget = null;
																					aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().SetPrimaryTarget(primaryTarget);
																					flag13 = true;
																				}
																				else if (current21.GetWaypoint1().Count<Waypoint>() > 0)
																				{
																					if (current21.GetWaypoint1()[0].waypointType == Waypoint.WaypointType.PathfindingPoint)
																					{
																						flight9 = current21;
																					}
																					else
																					{
																						list22.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																						Contact primaryTarget = null;
																						aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().SetPrimaryTarget(primaryTarget);
																						flag13 = true;
																					}
																				}
																				else if (current21.bool_11)
																				{
																					flag13 = true;
																				}
																				break;
																			}
																		}
																		if (flag13)
																		{
																			continue;
																		}
																	}
																	bool flag14 = true;
																	aircraftAIFeedbackForShootTouristDoctrine.shootTouristsDoctrine = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.m_Doctrine.GetShootTouristsDoctrine(scenario_, false, false, false);
																	if (strike.SpecificTargets.Count > 0)
																	{
																		using (List<Contact>.Enumerator enumerator27 = side_0.GetContactList().GetEnumerator())
																		{
																			while (enumerator27.MoveNext())
																			{
																				Contact current22 = enumerator27.Current;
																				if (current22.IsSpecificTargetForStikeMission(strike) && aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().method_23(ref strike, current22.GetPostureStance(side_0)) && aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftWeaponry().HasWeaponsInConditionToAttackTarget(current22, true, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.m_Doctrine, ref aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback, ref aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.FeedbackSeverity, null))
																				{
																					if (Information.IsNothing(flight9))
																					{
																						Aircraft_AirOps aircraftAirOps8 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAirOps();
																						GameGeneral.MissionContainer missionContainer9 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer;
																						Mission.Flight flight_ = null;
																						flight9 = new Mission.Flight(ref scenario_, ref missionContainer9.mission, ref flight_, "Master Flight Plan", aircraftAirOps8.GetCurrentHostUnit().GetGuid(), aircraftAirOps8.GetCurrentHostUnit().Name, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadout().DBID, current22, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																					}
																					ActiveUnit_AI aircraftAI5 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI();
																					GameGeneral.AircraftAIFeedback aircraftAIFeedback6 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback;
																					Strike.StrikeType strikeType2 = Strike.StrikeType.Land_Strike;
																					int minResponseRadius5 = strike.MinResponseRadius;
																					int maxResponseRadius5 = strike.MaxResponseRadius;
																					Doctrine._UseRefuel? useRefuel_5 = useRefuelDoctrine;
																					bool launchMissionWithoutTankersInPlace5 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.LaunchMissionWithoutTankersInPlace;
																					Mission._RadarBehaviour radarBehaviour5 = strike.RadarBehaviour;
																					bool useAutoPlanner5 = strike.UseAutoPlanner;
																					float num23 = 0f;
																					if (aircraftAI5.method_22(ref flight9, ref aircraftAIFeedback6.aircraft, ref current22, ref strikeType2, minResponseRadius5, maxResponseRadius5, useRefuel_5, launchMissionWithoutTankersInPlace5, radarBehaviour5, true, false, false, useAutoPlanner5, ref num23, ref aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback, ref mission_))
																					{
																						flag14 = false;
																						flight9.bool_14 = false;
																						flight9.Reason = "";
																						if (!aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Contains(flight9))
																						{
																							aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Add(flight9);
																						}
																					}
																					if (flight9.GetFlightCourse().Count<Waypoint>() <= 0 && flight9.GetWaypoint1().Count<Waypoint>() <= 0)
																					{
																						if (flag14)
																						{
																							continue;
																						}
																					}
																					else
																					{
																						list22.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																						Contact primaryTarget = current22;
																						aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().SetPrimaryTarget(primaryTarget);
																					}
																					break;
																				}
																			}
																			goto IL_2491;
																		}
																		goto IL_2117;
																	}
																	goto IL_2117;
																	IL_237F:
																	if (Information.IsNothing(flight9))
																	{
																		Aircraft_AirOps aircraftAirOps9 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAirOps();
																		GameGeneral.MissionContainer missionContainer10 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer;
																		Mission.Flight flight_ = null;
																		flight9 = new Mission.Flight(ref scenario_, ref missionContainer10.mission, ref flight_, "Master Flight Plan", aircraftAirOps9.GetCurrentHostUnit().GetGuid(), aircraftAirOps9.GetCurrentHostUnit().Name, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadout().DBID, null, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																	}
																	if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Contains(flight9))
																	{
																		continue;
																	}
																	aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Add(flight9);
																	flight9.bool_14 = true;
																	if (!string.IsNullOrEmpty(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback))
																	{
																		flight9.Reason = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback;
																		continue;
																	}
																	continue;
																	IL_2117:
																	List<Contact> list29 = side_0.GetContactList().Where(new Func<Contact, bool>(aircraftAIFeedbackForShootTouristDoctrine.IsTargetForMyMission)).ToList<Contact>();
																	using (List<Contact>.Enumerator enumerator28 = list29.GetEnumerator())
																	{
																		while (enumerator28.MoveNext())
																		{
																			Contact current23 = enumerator28.Current;
																			if (aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().method_23(ref strike, current23.GetPostureStance(side_0)))
																			{
																				if (Information.IsNothing(flight9))
																				{
																					Aircraft_AirOps aircraftAirOps10 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAirOps();
																					GameGeneral.MissionContainer missionContainer11 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer;
																					Mission.Flight flight_ = null;
																					flight9 = new Mission.Flight(ref scenario_, ref missionContainer11.mission, ref flight_, "Master Flight Plan", aircraftAirOps10.GetCurrentHostUnit().GetGuid(), aircraftAirOps10.GetCurrentHostUnit().Name, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetLoadout().DBID, current23, aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																				}
																				ActiveUnit_AI aircraftAI6 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI();
																				GameGeneral.AircraftAIFeedback aircraftAIFeedback7 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback;
																				Strike.StrikeType strikeType2 = Strike.StrikeType.Land_Strike;
																				int minResponseRadius6 = strike.MinResponseRadius;
																				int maxResponseRadius6 = strike.MaxResponseRadius;
																				Doctrine._UseRefuel? useRefuel_6 = useRefuelDoctrine;
																				bool launchMissionWithoutTankersInPlace6 = aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.LaunchMissionWithoutTankersInPlace;
																				Mission._RadarBehaviour radarBehaviour6 = strike.RadarBehaviour;
																				bool useAutoPlanner6 = strike.UseAutoPlanner;
																				float num23 = 0f;
																				if (aircraftAI6.method_22(ref flight9, ref aircraftAIFeedback7.aircraft, ref current23, ref strikeType2, minResponseRadius6, maxResponseRadius6, useRefuel_6, launchMissionWithoutTankersInPlace6, radarBehaviour6, true, false, false, useAutoPlanner6, ref num23, ref aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback.Feedback, ref mission_))
																				{
																					flag14 = false;
																					flight9.bool_14 = false;
																					flight9.Reason = "";
																					if (!aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Contains(flight9))
																					{
																						aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback._AIFeedback._MissionContainer.mission.list_0.Add(flight9);
																					}
																				}
																				if (flight9.GetFlightCourse().Count<Waypoint>() <= 0 && flight9.GetWaypoint1().Count<Waypoint>() <= 0)
																				{
																					if (flag14)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					list22.Add(aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft);
																					Contact primaryTarget = current23;
																					aircraftAIFeedbackForShootTouristDoctrine.aircraftAIFeedback.aircraft.GetAircraftAI().SetPrimaryTarget(primaryTarget);
																				}
																				break;
																			}
																		}
																		goto IL_2491;
																	}
																	goto IL_237F;
																	IL_2491:
																	if (flag14)
																	{
																		goto IL_237F;
																	}
																}
															}
															goto IL_3679;
														}
														goto IL_24B2;
													}
													continue;
												}
												break;
											case Mission._MissionClass.Patrol:
												break;
											case Mission._MissionClass.Support:
												goto IL_3CCE;
											case Mission._MissionClass.Ferry:
												goto IL_413C;
											case Mission._MissionClass.Mining:
												goto IL_431D;
											case Mission._MissionClass.MineClearing:
												goto IL_46EF;
											case Mission._MissionClass.Escort:
												goto IL_4AB4;
											default:
												goto IL_4ADA;
											}
											Patrol patrol = (Patrol)aIFeedback._MissionContainer.mission;
											flightSize = aIFeedback._MissionContainer.mission.m_FlightSize;
											flag5 = aIFeedback._MissionContainer.mission.UseFlightSizeHardLimit;
											num14 = patrol.GetFlightQty(ref flightSize, ref patrol.MinAircraftReq);
											if (!GameGeneral.smethod_25(ref scenario_, ref side_0, ref aIFeedback._MissionContainer.mission, ref list6, ref list7, num14, flightSize))
											{
												continue;
											}
											if (!Information.IsNothing(num14))
											{
												int num24 = list6.Count;
												if ((num14.HasValue ? new bool?(num24 < num14.GetValueOrDefault()) : null).GetValueOrDefault())
												{
													if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
													{
														scenario_.LogMessage(string.Concat(new string[]
														{
															"任务：",
															aIFeedback._MissionContainer.mission.Name,
															"最少需要",
															num14.HasValue ? Conversions.ToString(num14.GetValueOrDefault()) : null,
															"架飞机，但是只有",
															Conversions.ToString(list6.Count),
															"架飞机可用。"
														}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
													}
													if (!Information.IsNothing(mission_))
													{
														Interaction.MsgBox(string.Concat(new string[]
														{
															"任务：",
															aIFeedback._MissionContainer.mission.Name,
															"最少需要",
															num14.HasValue ? Conversions.ToString(num14.GetValueOrDefault()) : null,
															"架飞机，但是只有",
															Conversions.ToString(list6.Count),
															"架飞机可用。"
														}), MsgBoxStyle.OkOnly, null);
														continue;
													}
													continue;
												}
											}
											int num25 = ((Patrol)aIFeedback._MissionContainer.mission).MNOS;
											bool flag15;
											if (!(flag15 = ((Patrol)aIFeedback._MissionContainer.mission).OTR) && num25 <= 0)
											{
												using (List<Aircraft>.Enumerator enumerator29 = list7.GetEnumerator())
												{
													while (enumerator29.MoveNext())
													{
														Aircraft current24 = enumerator29.Current;
														list22.Add(current24);
													}
													goto IL_4ADA;
												}
											}
											using (List<int>.Enumerator enumerator30 = list14.GetEnumerator())
											{
												while (enumerator30.MoveNext())
												{
													GameGeneral.AircraftDBIDHolder aircraftDBIDHolder = new GameGeneral.AircraftDBIDHolder(null);
													aircraftDBIDHolder.DBID = enumerator30.Current;
													List<Aircraft> list30 = list6.Where(new Func<Aircraft, bool>(aircraftDBIDHolder.HasSameDBIDWith)).ToList<Aircraft>();
													List<Aircraft> list31 = list7.Where(new Func<Aircraft, bool>(aircraftDBIDHolder.HasSameDBIDWith1)).ToList<Aircraft>();
													if (list31.Count > 0)
													{
														if (flag15 && num25 > 0)
														{
															num25 = (int)Math.Round(Math.Ceiling(Math.Max((double)list30.Count / (double)flightSize / 3.0, (double)num25 / (double)flightSize)) * (double)flightSize);
														}
														else if (flag15 && num25 == 0)
														{
															num25 = (int)Math.Round(Math.Ceiling((double)list30.Count / (double)flightSize / 3.0) * (double)flightSize);
														}
														else if (!flag15 && num25 > 0)
														{
															num25 = (int)Math.Round(Math.Ceiling((double)num25 / (double)flightSize) * (double)flightSize);
														}
														List<Aircraft> list32 = list30.Where(GameGeneral.AircraftFunc4).ToList<Aircraft>();
														num15 = new int?(num25 - list32.Count);
														int? num26 = num15;
														if ((num26.HasValue ? new bool?(num26.GetValueOrDefault() > 0) : null).GetValueOrDefault())
														{
															foreach (Aircraft current25 in list31)
															{
																list22.Add(current25);
															}
														}
													}
												}
												goto IL_4ADA;
											}
											IL_3CCE:
											SupportMission supportMission = (SupportMission)aIFeedback._MissionContainer.mission;
											flightSize = aIFeedback._MissionContainer.mission.m_FlightSize;
											flag5 = aIFeedback._MissionContainer.mission.UseFlightSizeHardLimit;
											num14 = supportMission.GetFlightQty(ref flightSize, ref supportMission.MinAircraftReq);
											if (!GameGeneral.smethod_25(ref scenario_, ref side_0, ref aIFeedback._MissionContainer.mission, ref list6, ref list7, num14, flightSize))
											{
												continue;
											}
											if (!Information.IsNothing(num14))
											{
												int num24 = list6.Count;
												if ((num14.HasValue ? new bool?(num24 < num14.GetValueOrDefault()) : null).GetValueOrDefault())
												{
													if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
													{
														scenario_.LogMessage(string.Concat(new string[]
														{
															"任务：",
															aIFeedback._MissionContainer.mission.Name,
															"最少需要",
															num14.HasValue ? Conversions.ToString(num14.GetValueOrDefault()) : null,
															"架飞机，但是只有",
															Conversions.ToString(list6.Count),
															"架飞机可用。"
														}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
													}
													if (!Information.IsNothing(mission_))
													{
														Interaction.MsgBox(string.Concat(new string[]
														{
															"任务：",
															aIFeedback._MissionContainer.mission.Name,
															"最少需要",
															num14.HasValue ? Conversions.ToString(num14.GetValueOrDefault()) : null,
															"架飞机，但是只有",
															Conversions.ToString(list6.Count),
															"架飞机可用。"
														}), MsgBoxStyle.OkOnly, null);
														continue;
													}
													continue;
												}
											}
											num25 = ((SupportMission)aIFeedback._MissionContainer.mission).MNOS;
											if (!(flag15 = ((SupportMission)aIFeedback._MissionContainer.mission).OTR) && num25 <= 0)
											{
												using (List<Aircraft>.Enumerator enumerator32 = list7.GetEnumerator())
												{
													while (enumerator32.MoveNext())
													{
														Aircraft current26 = enumerator32.Current;
														list22.Add(current26);
													}
													goto IL_4ADA;
												}
											}
											using (List<int>.Enumerator enumerator33 = list14.GetEnumerator())
											{
												while (enumerator33.MoveNext())
												{
													GameGeneral.AircraftDBIDHolder aircraftDBIDHolder = new GameGeneral.AircraftDBIDHolder(null);
													aircraftDBIDHolder.DBID = enumerator33.Current;
													List<Aircraft> list33 = list6.Where(new Func<Aircraft, bool>(aircraftDBIDHolder.HasSameDBIDWith)).ToList<Aircraft>();
													List<Aircraft> list34 = list7.Where(new Func<Aircraft, bool>(aircraftDBIDHolder.HasSameDBIDWith1)).ToList<Aircraft>();
													if (list34.Count > 0)
													{
														if (flag15 && num25 > 0)
														{
															num25 = (int)Math.Round(Math.Ceiling(Math.Max((double)list33.Count / (double)flightSize / 3.0, (double)num25 / (double)flightSize)) * (double)flightSize);
														}
														else if (flag15 && num25 == 0)
														{
															num25 = (int)Math.Round(Math.Ceiling((double)list33.Count / (double)flightSize / 3.0) * (double)flightSize);
														}
														else if (!flag15 && num25 > 0)
														{
															num25 = (int)Math.Round(Math.Ceiling((double)num25 / (double)flightSize) * (double)flightSize);
														}
														List<Aircraft> list35 = list33.Where(GameGeneral.AircraftFunc5).ToList<Aircraft>();
														num15 = new int?(num25 - list35.Count);
														int? num26 = num15;
														if ((num26.HasValue ? new bool?(num26.GetValueOrDefault() > 0) : null).GetValueOrDefault())
														{
															foreach (Aircraft current27 in list34)
															{
																list22.Add(current27);
															}
														}
													}
												}
												goto IL_4ADA;
											}
											IL_413C:
											FerryMission ferryMission = (FerryMission)aIFeedback._MissionContainer.mission;
											flightSize = aIFeedback._MissionContainer.mission.m_FlightSize;
											flag5 = aIFeedback._MissionContainer.mission.UseFlightSizeHardLimit;
											num14 = ferryMission.GetFlightQty(ref flightSize, ref ferryMission.MinAircraftReq);
											if (!GameGeneral.smethod_25(ref scenario_, ref side_0, ref aIFeedback._MissionContainer.mission, ref list6, ref list7, num14, flightSize))
											{
												if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
												{
													scenario_.LogMessage(string.Concat(new string[]
													{
														"任务：",
														aIFeedback._MissionContainer.mission.Name,
														"最少需要",
														num14.HasValue ? Conversions.ToString(num14.GetValueOrDefault()) : null,
														"架飞机，但是只有",
														Conversions.ToString(list6.Count),
														"架飞机可用。"
													}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
												}
												if (!Information.IsNothing(mission_))
												{
													Interaction.MsgBox(string.Concat(new string[]
													{
														"任务：",
														aIFeedback._MissionContainer.mission.Name,
														"最少需要",
														num14.HasValue ? Conversions.ToString(num14.GetValueOrDefault()) : null,
														"架飞机，但是只有",
														Conversions.ToString(list6.Count),
														"架飞机可用。"
													}), MsgBoxStyle.OkOnly, null);
													continue;
												}
												continue;
											}
											else
											{
												using (List<Aircraft>.Enumerator enumerator35 = list7.GetEnumerator())
												{
													while (enumerator35.MoveNext())
													{
														Aircraft current28 = enumerator35.Current;
														list22.Add(current28);
													}
													goto IL_4ADA;
												}
											}
											IL_431D:
											MiningMission miningMission = (MiningMission)aIFeedback._MissionContainer.mission;
											flightSize = aIFeedback._MissionContainer.mission.m_FlightSize;
											flag5 = aIFeedback._MissionContainer.mission.UseFlightSizeHardLimit;
											num14 = aIFeedback._MissionContainer.mission.GetFlightQty(ref flightSize, ref miningMission.MinAircraftReq);
											if (!GameGeneral.smethod_25(ref scenario_, ref side_0, ref aIFeedback._MissionContainer.mission, ref list6, ref list7, num14, flightSize))
											{
												continue;
											}
											if (!Information.IsNothing(num14))
											{
												int num24 = list6.Count;
												if ((num14.HasValue ? new bool?(num24 < num14.GetValueOrDefault()) : null).GetValueOrDefault())
												{
													if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
													{
														scenario_.LogMessage(string.Concat(new string[]
														{
															"任务：",
															aIFeedback._MissionContainer.mission.Name,
															"最少需要",
															num14.HasValue ? Conversions.ToString(num14.GetValueOrDefault()) : null,
															"架飞机，但是只有",
															Conversions.ToString(list6.Count),
															"架飞机可用。"
														}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
													}
													if (!Information.IsNothing(mission_))
													{
														Interaction.MsgBox(string.Concat(new string[]
														{
															"任务：",
															aIFeedback._MissionContainer.mission.Name,
															"最少需要",
															num14.HasValue ? Conversions.ToString(num14.GetValueOrDefault()) : null,
															"架飞机，但是只有",
															Conversions.ToString(list6.Count),
															"架飞机可用。"
														}), MsgBoxStyle.OkOnly, null);
														continue;
													}
													continue;
												}
											}
											if (flag15 = ((MiningMission)aIFeedback._MissionContainer.mission).bOTR)
											{
												using (List<int>.Enumerator enumerator36 = list14.GetEnumerator())
												{
													while (enumerator36.MoveNext())
													{
														GameGeneral.AircraftDBIDHolder aircraftDBIDHolder = new GameGeneral.AircraftDBIDHolder(null);
														aircraftDBIDHolder.DBID = enumerator36.Current;
														List<Aircraft> list36 = list6.Where(new Func<Aircraft, bool>(aircraftDBIDHolder.HasSameDBIDWith)).ToList<Aircraft>();
														List<Aircraft> list37 = list7.Where(new Func<Aircraft, bool>(aircraftDBIDHolder.HasSameDBIDWith1)).ToList<Aircraft>();
														if (list37.Count > 0)
														{
															num25 = (int)Math.Round(Math.Ceiling((double)list36.Count / (double)flightSize / 3.0) * (double)flightSize);
															List<Aircraft> list38 = list36.Where(GameGeneral.AircraftFunc2).ToList<Aircraft>();
															num15 = new int?(num25 - list38.Count);
															int? num26 = num15;
															if ((num26.HasValue ? new bool?(num26.GetValueOrDefault() > 0) : null).GetValueOrDefault())
															{
																foreach (Aircraft current29 in list37)
																{
																	list22.Add(current29);
																}
															}
														}
													}
													goto IL_4ADA;
												}
											}
											using (List<Aircraft>.Enumerator enumerator38 = list7.GetEnumerator())
											{
												while (enumerator38.MoveNext())
												{
													Aircraft current30 = enumerator38.Current;
													list22.Add(current30);
												}
												goto IL_4ADA;
											}
											IL_46EF:
											MineClearingMission mineClearingMission = (MineClearingMission)aIFeedback._MissionContainer.mission;
											flightSize = aIFeedback._MissionContainer.mission.m_FlightSize;
											flag5 = aIFeedback._MissionContainer.mission.UseFlightSizeHardLimit;
											num14 = mineClearingMission.GetFlightQty(ref flightSize, ref mineClearingMission.MinAircraftReq);
											if (GameGeneral.smethod_25(ref scenario_, ref side_0, ref aIFeedback._MissionContainer.mission, ref list6, ref list7, num14, flightSize))
											{
												if (!Information.IsNothing(num14))
												{
													int num24 = list6.Count;
													if ((num14.HasValue ? new bool?(num24 < num14.GetValueOrDefault()) : null).GetValueOrDefault())
													{
														if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
														{
															scenario_.LogMessage(string.Concat(new string[]
															{
																"任务：",
																aIFeedback._MissionContainer.mission.Name,
																"最少需要",
																num14.HasValue ? Conversions.ToString(num14.GetValueOrDefault()) : null,
																"架飞机，但是只有",
																Conversions.ToString(list6.Count),
																"架飞机可用。"
															}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
														}
														if (!Information.IsNothing(mission_))
														{
															Interaction.MsgBox(string.Concat(new string[]
															{
																"任务： ",
																aIFeedback._MissionContainer.mission.Name,
																"最少需要",
																num14.HasValue ? Conversions.ToString(num14.GetValueOrDefault()) : null,
																"架飞机，但是只有",
																Conversions.ToString(list6.Count),
																"架飞机可用。"
															}), MsgBoxStyle.OkOnly, null);
															continue;
														}
														continue;
													}
												}
												if (flag15 = ((MineClearingMission)aIFeedback._MissionContainer.mission).OTR)
												{
													using (List<int>.Enumerator enumerator39 = list14.GetEnumerator())
													{
														while (enumerator39.MoveNext())
														{
															GameGeneral.AircraftDBIDHolder aircraftDBIDHolder = new GameGeneral.AircraftDBIDHolder(null);
															aircraftDBIDHolder.DBID = enumerator39.Current;
															List<Aircraft> list39 = list6.Where(new Func<Aircraft, bool>(aircraftDBIDHolder.HasSameDBIDWith)).ToList<Aircraft>();
															List<Aircraft> list40 = list7.Where(new Func<Aircraft, bool>(aircraftDBIDHolder.HasSameDBIDWith1)).ToList<Aircraft>();
															if (list40.Count > 0)
															{
																num25 = (int)Math.Round(Math.Ceiling((double)list39.Count / (double)flightSize / 3.0) * (double)flightSize);
																List<Aircraft> list41 = list39.Where(GameGeneral.AircraftFunc3).ToList<Aircraft>();
																num15 = new int?(num25 - list41.Count);
																int? num26 = num15;
																if ((num26.HasValue ? new bool?(num26.GetValueOrDefault() > 0) : null).GetValueOrDefault())
																{
																	foreach (Aircraft current31 in list40)
																	{
																		list22.Add(current31);
																	}
																}
															}
														}
														goto IL_4ADA;
													}
												}
												using (List<Aircraft>.Enumerator enumerator41 = list7.GetEnumerator())
												{
													while (enumerator41.MoveNext())
													{
														Aircraft current32 = enumerator41.Current;
														list22.Add(current32);
													}
													goto IL_4ADA;
												}
												goto IL_4AB4;
											}
											continue;
											IL_4ADA:
											if (list22.Count <= 0)
											{
												goto IL_79F6;
											}
											if (aIFeedback._MissionContainer.mission.MissionClass == Mission._MissionClass.Strike)
											{
												if (!Information.IsNothing(num14))
												{
													int num24 = list22.Count;
													if ((num14.HasValue ? new bool?(num24 < num14.GetValueOrDefault()) : null).GetValueOrDefault())
													{
														if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
														{
															scenario_.LogMessage(string.Concat(new string[]
															{
																"任务：",
																aIFeedback._MissionContainer.mission.Name,
																"最少需要",
																num14.HasValue ? Conversions.ToString(num14.GetValueOrDefault()) : null,
																"架飞机，但是只有",
																Conversions.ToString(list6.Count),
																"架飞机可用。任务飞机不能出动。"
															}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
														}
														if (!Information.IsNothing(mission_))
														{
															Interaction.MsgBox(string.Concat(new string[]
															{
																"任务：",
																aIFeedback._MissionContainer.mission.Name,
																"最少需要",
																num14.HasValue ? Conversions.ToString(num14.GetValueOrDefault()) : null,
																"架飞机，但是只有",
																Conversions.ToString(list6.Count),
																"架飞机可用。任务飞机不能出动。"
															}), MsgBoxStyle.OkOnly, null);
															continue;
														}
														continue;
													}
												}
												if (!Information.IsNothing(num16))
												{
													int num24 = list23.Count;
													if ((num16.HasValue ? new bool?(num24 < num16.GetValueOrDefault()) : null).GetValueOrDefault())
													{
														if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
														{
															scenario_.LogMessage(string.Concat(new string[]
															{
																"任务： ",
																aIFeedback._MissionContainer.mission.Name,
																"最少需要",
																num16.HasValue ? Conversions.ToString(num16.GetValueOrDefault()) : null,
																"架可以开火的护航飞机（带弹药），但是只有 ",
																Conversions.ToString(list23.Count),
																"架飞机可用。任务飞机不能出动。"
															}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
														}
														if (!Information.IsNothing(mission_))
														{
															Interaction.MsgBox(string.Concat(new string[]
															{
																"任务： ",
																aIFeedback._MissionContainer.mission.Name,
																"最少需要",
																num16.HasValue ? Conversions.ToString(num16.GetValueOrDefault()) : null,
																"架可以开火的护航飞机（带弹药），但是只有",
																Conversions.ToString(list23.Count),
																"架飞机可用。任务飞机不能出动。"
															}), MsgBoxStyle.OkOnly, null);
															continue;
														}
														continue;
													}
												}
												if (!Information.IsNothing(num18))
												{
													int num24 = list24.Count;
													if ((num18.HasValue ? new bool?(num24 < num18.GetValueOrDefault()) : null).GetValueOrDefault() && flightSize3 != Mission._FlightSize.None)
													{
														if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
														{
															scenario_.LogMessage(string.Concat(new string[]
															{
																"任务： ",
																aIFeedback._MissionContainer.mission.Name,
																"最少需要",
																num18.HasValue ? Conversions.ToString(num18.GetValueOrDefault()) : null,
																"架护航飞机（不带弹药），但是只有",
																Conversions.ToString(list24.Count),
																"架飞机可用。任务飞机不能出动。"
															}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
														}
														if (!Information.IsNothing(mission_))
														{
															Interaction.MsgBox(string.Concat(new string[]
															{
																"任务：",
																aIFeedback._MissionContainer.mission.Name,
																"最少需要",
																num18.HasValue ? Conversions.ToString(num18.GetValueOrDefault()) : null,
																"架护航飞机（不带弹药），但是只有",
																Conversions.ToString(list24.Count),
																"架飞机可用。任务飞机不能出动。"
															}), MsgBoxStyle.OkOnly, null);
															continue;
														}
														continue;
													}
												}
											}
											else if (!Information.IsNothing(num14))
											{
												int num24 = list6.Count;
												if ((num14.HasValue ? new bool?(num24 < num14.GetValueOrDefault()) : null).GetValueOrDefault())
												{
													if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
													{
														scenario_.LogMessage(string.Concat(new string[]
														{
															"任务：",
															aIFeedback._MissionContainer.mission.Name,
															" 最少需要",
															num14.HasValue ? Conversions.ToString(num14.GetValueOrDefault()) : null,
															"架飞机，但是只有",
															Conversions.ToString(list6.Count),
															"架飞机可用。任务飞机不能出动。"
														}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
													}
													if (!Information.IsNothing(mission_))
													{
														Interaction.MsgBox(string.Concat(new string[]
														{
															"任务：",
															aIFeedback._MissionContainer.mission.Name,
															" 最少需要",
															num14.HasValue ? Conversions.ToString(num14.GetValueOrDefault()) : null,
															"架飞机，但是只有",
															Conversions.ToString(list6.Count),
															"架飞机可用。任务飞机不能出动。"
														}), MsgBoxStyle.OkOnly, null);
														continue;
													}
													continue;
												}
											}
											int num27 = 0;
											int num28 = 0;
											int num29 = 0;
											bool flag16 = false;
											bool flag17 = false;
											bool flag18 = false;
											using (List<ActiveUnit>.Enumerator enumerator42 = list11.GetEnumerator())
											{
												while (enumerator42.MoveNext())
												{
													GameGeneral.ActiveUnitHost activeUnitHost = new GameGeneral.ActiveUnitHost(null);
													activeUnitHost.HostUnit = enumerator42.Current;
													if (flag16 && flag17 && flag18)
													{
														break;
													}
													using (List<int>.Enumerator enumerator43 = list13.GetEnumerator())
													{
														while (enumerator43.MoveNext())
														{
															GameGeneral.AircraftHostManager aircraftHostManager = new GameGeneral.AircraftHostManager(null);
															aircraftHostManager.aircraftHost = activeUnitHost;
															aircraftHostManager.LoadoutDBID = enumerator43.Current;
															if (flag16 && flag17 && flag18)
															{
																break;
															}
															int num30 = 0;
															int num31 = 0;
															IEnumerable<Aircraft> enumerable = list22.Where(new Func<Aircraft, bool>(aircraftHostManager.CanHost));
															IEnumerable<Aircraft> enumerable2;
															IEnumerable<Aircraft> enumerable3;
															if (flightSize3 == Mission._FlightSize.None)
															{
																enumerable2 = list23.Where(new Func<Aircraft, bool>(aircraftHostManager.CanHost1));
																enumerable3 = null;
															}
															else
															{
																enumerable2 = list23.Where(new Func<Aircraft, bool>(aircraftHostManager.method_2));
																enumerable3 = list24.Where(new Func<Aircraft, bool>(aircraftHostManager.method_3));
															}
															int num32;
															if (enumerable.Count<Aircraft>() > 0)
															{
																if ((enumerable.Count<Aircraft>() >= (int)flightSize || !flag5) && !flag16)
																{
																	if (flightSize > Mission._FlightSize.SingleAircraft)
																	{
																		num32 = enumerable.Count<Aircraft>();
																		goto IL_52A2;
																	}
																	using (IEnumerator<Aircraft> enumerator44 = enumerable.GetEnumerator())
																	{
																		while (enumerator44.MoveNext())
																		{
																			Aircraft current33 = enumerator44.Current;
																			if (bool_2)
																			{
																				list2.Add(current33);
																				checked
																				{
																					if (aIFeedback._MissionContainer.mission.list_0.Count > 0)
																					{
                                                                                        Mission.Flight current34X;
                                                                                        foreach (Mission.Flight current34 in aIFeedback._MissionContainer.mission.list_0)
																						{
																							if (current33.GetLoadoutDBID() == current34.LoadoutDBID && Operators.CompareString(current33.GetAircraftAirOps().GetCurrentHostUnit().GetGuid(), current34.TakeOffLocation_HostUnitObjectID, false) == 0)
																							{
																								if (current34.GetWaypoint1().Count<Waypoint>() == 0 && !current34.UsedByFlight)
																								{
																									Mission.Flight flight10 = new Mission.Flight();
																									Mission.Flight flight11 = flight10;
																									GameGeneral.MissionContainer missionContainer12 = aIFeedback._MissionContainer;
																									int k = 0;
																									int l = 0;
                                                                                                    current34X = current34;

                                                                                                    flight11.SetFlight0ToFlight1(ref scenario_, ref current34X, ref flight10, false, ref missionContainer12.mission, ref k, ref l);
																									aIFeedback._MissionContainer.mission.FlightList.Add(flight10);
																									current33.method_114(flight10, 0);
																									current34.UsedByFlight = true;
																								}
																								else if (current34.GetWaypoint1().Count<Waypoint>() > 0)
																								{
																									Mission.Flight flight12 = new Mission.Flight();
																									Mission.Flight flight13 = flight12;
																									GameGeneral.MissionContainer missionContainer13 = aIFeedback._MissionContainer;
																									int l = 0;
																									int k = 0;
                                                                                                    current34X = current34;
                                                                                                    flight13.SetFlight0ToFlight1(ref scenario_, ref current34X, ref flight12, false, ref missionContainer13.mission, ref l, ref k);
																									aIFeedback._MissionContainer.mission.FlightList.Add(flight12);
																									current33.method_114(flight12, 0);
																								}
																								else
																								{
																									Aircraft_AirOps aircraftAirOps11 = current33.GetAircraftAirOps();
																									GameGeneral.MissionContainer missionContainer14 = aIFeedback._MissionContainer;
																									Mission.Flight flight_ = null;
																									Mission.Flight flight14 = new Mission.Flight(ref scenario_, ref missionContainer14.mission, ref flight_, CallsignGenerator.GenerateCallsignString(ref aIFeedback._MissionContainer.mission), aircraftAirOps11.GetCurrentHostUnit().GetGuid(), aircraftAirOps11.GetCurrentHostUnit().Name, current33.GetLoadout().DBID, current34.PrimaryTarget, current33);
																									ActiveUnit_AI aircraftAI7 = current33.GetAircraftAI();
																									Mission.Flight flight15 = current34;
																									int minResponseRadius7 = strike.MinResponseRadius;
																									int maxResponseRadius7 = strike.MaxResponseRadius;
																									Doctrine._UseRefuel? useRefuel_7 = useRefuelDoctrine;
																									bool launchMissionWithoutTankersInPlace7 = aIFeedback._MissionContainer.mission.LaunchMissionWithoutTankersInPlace;
																									Mission._RadarBehaviour radarBehaviour7 = strike.RadarBehaviour;
																									bool useAutoPlanner7 = strike.UseAutoPlanner;
																									float num23 = 0f;
																									aircraftAI7.method_22(ref flight14, ref current33, ref flight15.PrimaryTarget, ref strikeType, minResponseRadius7, maxResponseRadius7, useRefuel_7, launchMissionWithoutTankersInPlace7, radarBehaviour7, false, false, false, useAutoPlanner7, ref num23, ref aIFeedback.Feedback, ref mission_);
																									if (flight14.GetFlightCourse().Count<Waypoint>() == 0)
																									{
																										Waypoint[] flightCourse = current34.GetFlightCourse();
																										for (int k = 0; k < flightCourse.Length; k++)
																										{
																											Waypoint waypoint2 = flightCourse[k];
																											Mission.Flight flight16 = flight14;
																											Waypoint[] flightCourse2 = flight16.GetFlightCourse();
																											ScenarioArrayUtil.AddWaypoint(ref flightCourse2, waypoint2.method_23(ref scenario_, ref waypoint2, true, true));
																											flight16.SetFlightCourse(flightCourse2);
																										}
																									}
																									aIFeedback._MissionContainer.mission.FlightList.Add(flight14);
																									current33.method_114(flight14, 0);
																								}
																								break;
																							}
																						}
																					}
																				}
																				num27++;
																				if (Information.IsNothing(num15) || !(num15.HasValue ? new bool?(num27 >= num15.GetValueOrDefault()) : null).GetValueOrDefault())
																				{
																					continue;
																				}
																				flag16 = true;
																			}
																			else
																			{
																				checked
																				{
																					if (aIFeedback._MissionContainer.mission.list_0.Count > 0)
																					{
                                                                                        Mission.Flight current35X;
                                                                                        foreach (Mission.Flight current35 in aIFeedback._MissionContainer.mission.list_0)
																						{
																							if (current33.GetLoadoutDBID() == current35.LoadoutDBID && Operators.CompareString(current33.GetAircraftAirOps().GetCurrentHostUnit().GetGuid(), current35.TakeOffLocation_HostUnitObjectID, false) == 0)
																							{
																								if (current35.GetWaypoint1().Count<Waypoint>() == 0 && !current35.UsedByFlight)
																								{
																									Mission.Flight flight17 = new Mission.Flight();
																									Mission.Flight flight18 = flight17;
																									GameGeneral.MissionContainer missionContainer15 = aIFeedback._MissionContainer;
																									int l = 0;
																									int num33 = 0;
                                                                                                    current35X = current35;

                                                                                                    flight18.SetFlight0ToFlight1(ref scenario_, ref current35X, ref flight17, false, ref missionContainer15.mission, ref l, ref num33);
																									aIFeedback._MissionContainer.mission.FlightList.Add(flight17);
																									if (list19.Contains(current33))
																									{
																										if (Information.IsNothing(aIFeedback._MissionContainer.mission.EmptySlotsList))
																										{
																											goto IL_68AD;
																										}
																										using (List<Mission.EmptySlot>.Enumerator enumerator47 = aIFeedback._MissionContainer.mission.EmptySlotsList.GetEnumerator())
																										{
																											while (enumerator47.MoveNext())
																											{
																												Mission.EmptySlot current36 = enumerator47.Current;
																												if (!Information.IsNothing(current36.method_0(scenario_, null)) && current36.method_0(scenario_, null) == current33)
																												{
																													current36.method_6(scenario_, flight17, 0, 0);
																													break;
																												}
																											}
																											goto IL_68AD;
																										}
																									}
																									current33.method_114(flight17, 0);
																									IL_68AD:
																									current35.UsedByFlight = true;
																								}
																								else if (current35.GetWaypoint1().Count<Waypoint>() > 0)
																								{
																									Mission.Flight flight19 = new Mission.Flight();
																									Mission.Flight flight20 = flight19;
																									GameGeneral.MissionContainer missionContainer16 = aIFeedback._MissionContainer;
																									int num33 = 0;
																									int l = 0;
                                                                                                    current35X = current35;

                                                                                                    flight20.SetFlight0ToFlight1(ref scenario_, ref current35X, ref flight19, false, ref missionContainer16.mission, ref num33, ref l);
																									aIFeedback._MissionContainer.mission.FlightList.Add(flight19);
																									if (list19.Contains(current33))
																									{
																										if (Information.IsNothing(aIFeedback._MissionContainer.mission.EmptySlotsList))
																										{
																											break;
																										}
																										using (List<Mission.EmptySlot>.Enumerator enumerator48 = aIFeedback._MissionContainer.mission.EmptySlotsList.GetEnumerator())
																										{
																											while (enumerator48.MoveNext())
																											{
																												Mission.EmptySlot current37 = enumerator48.Current;
																												if (!Information.IsNothing(current37.method_0(scenario_, null)) && current37.method_0(scenario_, null) == current33)
																												{
																													current37.method_6(scenario_, flight19, 0, 0);
																													break;
																												}
																											}
																											break;
																										}
																									}
																									current33.method_114(flight19, 0);
																								}
																								else
																								{
																									Aircraft_AirOps aircraftAirOps12 = current33.GetAircraftAirOps();
																									GameGeneral.MissionContainer missionContainer17 = aIFeedback._MissionContainer;
																									Mission.Flight flight_ = null;
																									Mission.Flight flight7 = new Mission.Flight(ref scenario_, ref missionContainer17.mission, ref flight_, CallsignGenerator.GenerateCallsignString(ref aIFeedback._MissionContainer.mission), aircraftAirOps12.GetCurrentHostUnit().GetGuid(), aircraftAirOps12.GetCurrentHostUnit().Name, current33.GetLoadout().DBID, current35.PrimaryTarget, current33);
																									ActiveUnit_AI aircraftAI8 = current33.GetAircraftAI();
																									Mission.Flight flight21 = current35;
																									int minResponseRadius = strike.MinResponseRadius;
																									int maxResponseRadius = strike.MaxResponseRadius;
																									Doctrine._UseRefuel? useRefuel_8 = useRefuelDoctrine;
																									bool launchMissionWithoutTankersInPlace8 = aIFeedback._MissionContainer.mission.LaunchMissionWithoutTankersInPlace;
																									Mission._RadarBehaviour radarBehaviour8 = strike.RadarBehaviour;
																									bool useAutoPlanner8 = strike.UseAutoPlanner;
																									float num23 = 0f;
																									aircraftAI8.method_22(ref flight7, ref current33, ref flight21.PrimaryTarget, ref strikeType, minResponseRadius, maxResponseRadius, useRefuel_8, launchMissionWithoutTankersInPlace8, radarBehaviour8, false, false, false, useAutoPlanner8, ref num23, ref aIFeedback.Feedback, ref mission_);
																									if (flight7.GetFlightCourse().Count<Waypoint>() == 0)
																									{
																										Waypoint[] flightCourse2 = current35.GetFlightCourse();
																										for (int l = 0; l < flightCourse2.Length; l++)
																										{
																											Waypoint waypoint3 = flightCourse2[l];
																											Mission.Flight flight22 = flight7;
																											Waypoint[] flightCourse3 = flight22.GetFlightCourse();
																											ScenarioArrayUtil.AddWaypoint(ref flightCourse3, waypoint3.method_23(ref scenario_, ref waypoint3, true, true));
																											flight22.SetFlightCourse(flightCourse3);
																										}
																									}
																									aIFeedback._MissionContainer.mission.FlightList.Add(flight7);
																									if (list19.Contains(current33))
																									{
																										if (Information.IsNothing(aIFeedback._MissionContainer.mission.EmptySlotsList))
																										{
																											break;
																										}
																										using (List<Mission.EmptySlot>.Enumerator enumerator49 = aIFeedback._MissionContainer.mission.EmptySlotsList.GetEnumerator())
																										{
																											while (enumerator49.MoveNext())
																											{
																												Mission.EmptySlot current38 = enumerator49.Current;
																												if (!Information.IsNothing(current38.method_0(scenario_, null)) && current38.method_0(scenario_, null) == current33)
																												{
																													current38.method_6(scenario_, flight7, 0, 0);
																													break;
																												}
																											}
																											break;
																										}
																									}
																									current33.method_114(flight7, 0);
																								}
																								break;
																							}
																						}
																					}
																				}
																				num27++;
																				if (Information.IsNothing(num15) || !(num15.HasValue ? new bool?(num27 >= num15.GetValueOrDefault()) : null).GetValueOrDefault())
																				{
																					continue;
																				}
																				flag16 = true;
																			}
																			break;
																		}
																		goto IL_6FEA;
																	}
																}
																if (enumerable.Count<Aircraft>() < (int)flightSize && !flag16)
																{
																	if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
																	{
																		if (aIFeedback._MissionContainer.mission.category == Mission.MissionCategory.Mission)
																		{
																			scenario_.LogMessage(string.Concat(new string[]
																			{
																				"任务：",
																				aIFeedback._MissionContainer.mission.Name,
																				", 飞机型号：",
																				enumerable.ElementAtOrDefault(0).UnitClass,
																				" 挂载方案：",
																				enumerable.ElementAtOrDefault(0).GetLoadoutName(),
																				" 起降机场：",
																				aircraftHostManager.aircraftHost.HostUnit.Name,
																				" 不能出动。 当根据机场/母舰平台、飞机型号或者挂载进行区分时，没有足够的飞机满足飞行编队的最低规模要求。可能解决方案：添加更多的突击飞机或者护航飞机，飞机采用相同挂载，或者使用来自同一机场/母舰的飞机。 您还可以修改任务配置，减少突击/护航飞机所需最小数，或者减少编队规模要求。"
																			}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
																		}
																		else
																		{
																			scenario_.LogMessage(string.Concat(new string[]
																			{
																				aIFeedback._MissionContainer.mission.Name,
																				", 飞机型号：",
																				enumerable.ElementAtOrDefault(0).UnitClass,
																				" 挂载方案：",
																				enumerable.ElementAtOrDefault(0).GetLoadoutName(),
																				" 起降机场：",
																				aircraftHostManager.aircraftHost.HostUnit.Name,
																				"发生问题。某些飞机没有分配给飞行编队，飞机不能出动。可能解决方案：将飞机从任务（Task）包中删除，改变编队规模，或者手动创建飞行计划。"
																			}), LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
																		}
																	}
																	if (!Information.IsNothing(mission_))
																	{
																		if (aIFeedback._MissionContainer.mission.category == Mission.MissionCategory.Mission)
																		{
																			Interaction.MsgBox(string.Concat(new string[]
																			{
																				"任务 ",
																				aIFeedback._MissionContainer.mission.Name,
																				", 飞机型号：",
																				enumerable.ElementAtOrDefault(0).UnitClass,
																				" 挂载方案： ",
																				enumerable.ElementAtOrDefault(0).GetLoadoutName(),
																				" 起降机场：",
																				aircraftHostManager.aircraftHost.HostUnit.Name,
																				" 不能出动。当根据机场/母舰平台、飞机型号或者挂载进行区分时，没有足够的飞机满足飞行编队的最低规模要求。可能解决方案：添加更多的突击飞机或者护航飞机，飞机采用相同挂载，或者使用来自同一机场/母舰的飞机。 您还可以修改任务配置，减少突击/护航飞机所需最小数，或者减少编队规模要求。"
																			}), MsgBoxStyle.OkOnly, null);
																		}
																		else
																		{
																			Interaction.MsgBox(string.Concat(new string[]
																			{
																				aIFeedback._MissionContainer.mission.Name,
																				", 飞机型号：",
																				enumerable.ElementAtOrDefault(0).UnitClass,
																				" 挂载方案：",
																				enumerable.ElementAtOrDefault(0).GetLoadoutName(),
																				" 起降机场：",
																				aircraftHostManager.aircraftHost.HostUnit.Name,
																				"发生问题。某些飞机没有分配给飞行编队，飞机不能出动。可能解决方案：将飞机从任务（Task）包中删除，改变编队规模，或者手动创建飞行计划。"
																			}), MsgBoxStyle.OkOnly, null);
																		}
																	}
																}
															}
															IL_6FEA:
															if (!Information.IsNothing(enumerable2) && enumerable2.Count<Aircraft>() > 0 && (!flag6 || enumerable2.Count<Aircraft>() >= (int)flightSize2) && !flag17)
															{
																if (flightSize2 > Mission._FlightSize.SingleAircraft)
																{
																	int num34 = enumerable2.Count<Aircraft>();
																	do
																	{
																		if (flag6)
																		{
																			if (num34 < (int)flightSize2)
																			{
																				goto Block_615;
																			}
																		}
																		else if (num34 == 0)
																		{
																			goto IL_7229;
																		}
																		List<ActiveUnit> list42 = new List<ActiveUnit>();
																		int num33 = (int)flightSize2;
																		int num35 = 1;
																		while (num35 <= num33 && num31 < enumerable2.Count<Aircraft>())
																		{
																			if (!Information.IsNothing(enumerable2.ElementAtOrDefault(num31)))
																			{
																				list42.Add(enumerable2.ElementAtOrDefault(num31));
																				list3.Add(enumerable2.ElementAtOrDefault(num31));
																				num28++;
																				num34--;
																				num31++;
																			}
																			num35++;
																		}
																		Group item2 = new Group(ref scenario_, ref side_0, list42, false, null, aIFeedback._MissionContainer.mission);
																		list.Add(item2);
																	}
																	while (Information.IsNothing(num17) || !(num17.HasValue ? new bool?(num28 >= num17.GetValueOrDefault()) : null).GetValueOrDefault());
																	flag17 = true;
																	Block_615:;
																}
																else
																{
																	foreach (Aircraft current39 in enumerable2)
																	{
																		list3.Add(current39);
																		num27++;
																		if (!Information.IsNothing(num17) && (num17.HasValue ? new bool?(num28 >= num17.GetValueOrDefault()) : null).GetValueOrDefault())
																		{
																			break;
																		}
																	}
																}
															}
															IL_7229:
															if (!Information.IsNothing(enumerable3) && enumerable3.Count<Aircraft>() > 0 && (!flag6 || enumerable3.Count<Aircraft>() >= (int)flightSize3) && !flag18 && flightSize3 <= Mission._FlightSize.SingleAircraft)
															{
																using (IEnumerator<Aircraft> enumerator51 = enumerable3.GetEnumerator())
																{
																	while (enumerator51.MoveNext())
																	{
																		Aircraft current40 = enumerator51.Current;
																		list4.Add(current40);
																		num27++;
																		if (!Information.IsNothing(num19) && (num19.HasValue ? new bool?(num29 >= num19.GetValueOrDefault()) : null).GetValueOrDefault())
																		{
																			break;
																		}
																	}
																	continue;
																}
																goto IL_7302;
															}
															continue;
															IL_52A2:
															if (flag5)
															{
																if (num32 < (int)flightSize)
																{
																	goto IL_6FEA;
																}
															}
															else if (num32 == 0)
															{
																goto IL_6FEA;
															}
															List<ActiveUnit> list43 = new List<ActiveUnit>();
															int num24 = (int)flightSize;
															int num36 = 1;
															while (num36 <= num24 && num30 < enumerable.Count<Aircraft>())
															{
																if (!Information.IsNothing(enumerable.ElementAtOrDefault(num30)))
																{
																	list43.Add(enumerable.ElementAtOrDefault(num30));
																	if (bool_2)
																	{
																		list2.Add(enumerable.ElementAtOrDefault(num30));
																		num27++;
																	}
																	num32--;
																	num30++;
																}
																num36++;
															}
															if (!bool_2)
															{
																if (aIFeedback._MissionContainer.mission.list_0.Count <= 0 || list43.Count <= 0)
																{
																	goto IL_7302;
																}
																Aircraft aircraft5 = (Aircraft)list43[0];
																using (List<Mission.Flight>.Enumerator enumerator52 = aIFeedback._MissionContainer.mission.list_0.GetEnumerator())
																{
																	while (enumerator52.MoveNext())
																	{
																		Mission.Flight current41 = enumerator52.Current;
																		if (aircraft5.GetLoadoutDBID() == current41.LoadoutDBID && Operators.CompareString(aircraft5.GetAircraftAirOps().GetCurrentHostUnit().GetGuid(), current41.TakeOffLocation_HostUnitObjectID, false) == 0)
																		{
																			if (current41.GetWaypoint1().Count<Waypoint>() == 0 && !current41.UsedByFlight)
																			{
																				Mission.Flight flight23 = new Mission.Flight();
																				Mission.Flight flight24 = flight23;
																				GameGeneral.MissionContainer missionContainer18 = aIFeedback._MissionContainer;
																				int m = 0;
																				int n = 0;
																				flight24.SetFlight0ToFlight1(ref scenario_, ref current41, ref flight23, false, ref missionContainer18.mission, ref m, ref n);
																				aIFeedback._MissionContainer.mission.FlightList.Add(flight23);
																				current41.UsedByFlight = true;
																				int num37 = 1;
																				using (List<ActiveUnit>.Enumerator enumerator53 = list43.GetEnumerator())
																				{
																					while (enumerator53.MoveNext())
																					{
																						ActiveUnit current42 = enumerator53.Current;
																						if (list19.Contains((Aircraft)current42))
																						{
																							if (Information.IsNothing(aIFeedback._MissionContainer.mission.EmptySlotsList))
																							{
																								continue;
																							}
																							using (List<Mission.EmptySlot>.Enumerator enumerator54 = aIFeedback._MissionContainer.mission.EmptySlotsList.GetEnumerator())
																							{
																								while (enumerator54.MoveNext())
																								{
																									Mission.EmptySlot current43 = enumerator54.Current;
																									if (!Information.IsNothing(current43.method_0(scenario_, null)) && current43.method_0(scenario_, null) == current42)
																									{
																										current43.method_6(scenario_, flight23, num37, list43.Count);
																										num37++;
																										break;
																									}
																								}
																								continue;
																							}
																						}
																						current42.method_114(flight23, num37);
																						num37++;
																					}
																					break;
																				}
																			}
																			if (current41.GetWaypoint1().Count<Waypoint>() > 0)
																			{
																				Mission.Flight flight25 = new Mission.Flight();
																				Mission.Flight flight26 = flight25;
																				GameGeneral.MissionContainer missionContainer19 = aIFeedback._MissionContainer;
																				int n = 0;
																				int m = 0;
																				flight26.SetFlight0ToFlight1(ref scenario_, ref current41, ref flight25, false, ref missionContainer19.mission, ref n, ref m);
																				aIFeedback._MissionContainer.mission.FlightList.Add(flight25);
																				int num38;
																				checked
																				{
																					if (flight25.GetWaypoint1().Count<Waypoint>() > 0 && flight25.GetFlightCourse().Count<Waypoint>() == 0)
																					{
																						Waypoint[] array2 = flight25.GetWaypoint1();
																						Waypoint[] array3;
																						for (m = 0; m < array2.Length; m++)
																						{
																							Waypoint waypoint4 = array2[m];
																							Mission.Flight flight27 = flight25;
																							array3 = flight27.GetFlightCourse();
																							ScenarioArrayUtil.AddWaypoint(ref array3, waypoint4.method_23(ref scenario_, ref waypoint4, true, true));
																							flight27.SetFlightCourse(array3);
																						}
																						Mission.Flight flight28 = flight25;
																						array3 = flight28.GetWaypoint1();
																						ScenarioArrayUtil.ClearWaypoints(ref array3);
																						flight28.SetWaypoint1(array3);
																						Mission.Flight flight29 = flight25;
																						array3 = flight29.GetWaypoint2();
																						ScenarioArrayUtil.ClearWaypoints(ref array3);
																						flight29.SetWaypoint2(array3);
																					}
																					num38 = 1;
																				}
																				foreach (ActiveUnit current44 in list43)
																				{
																					if (list19.Contains((Aircraft)current44))
																					{
																						if (Information.IsNothing(aIFeedback._MissionContainer.mission.EmptySlotsList))
																						{
																							continue;
																						}
																						using (List<Mission.EmptySlot>.Enumerator enumerator56 = aIFeedback._MissionContainer.mission.EmptySlotsList.GetEnumerator())
																						{
																							while (enumerator56.MoveNext())
																							{
																								Mission.EmptySlot current45 = enumerator56.Current;
																								if (!Information.IsNothing(current45.method_0(scenario_, null)) && current45.method_0(scenario_, null) == current44)
																								{
																									current45.method_6(scenario_, flight25, num38, list43.Count);
																									num38++;
																									break;
																								}
																							}
																							continue;
																						}
																					}
																					current44.method_114(flight25, num38);
																					num38++;
																				}
																			}
																			else
																			{
																				Aircraft_AirOps aircraftAirOps13 = aircraft5.GetAircraftAirOps();
																				GameGeneral.MissionContainer missionContainer20 = aIFeedback._MissionContainer;
																				Mission.Flight flight_ = null;
																				Mission.Flight flight30 = new Mission.Flight(ref scenario_, ref missionContainer20.mission, ref flight_, CallsignGenerator.GenerateCallsignString(ref aIFeedback._MissionContainer.mission), aircraftAirOps13.GetCurrentHostUnit().GetGuid(), aircraftAirOps13.GetCurrentHostUnit().Name, aircraft5.GetLoadout().DBID, current41.PrimaryTarget, aircraft5);
																				ActiveUnit_AI aircraftAI9 = aircraft5.GetAircraftAI();
																				Mission.Flight flight31 = current41;
																				int minResponseRadius8 = strike.MinResponseRadius;
																				int maxResponseRadius8 = strike.MaxResponseRadius;
																				Doctrine._UseRefuel? useRefuel_9 = useRefuelDoctrine;
																				bool launchMissionWithoutTankersInPlace9 = aIFeedback._MissionContainer.mission.LaunchMissionWithoutTankersInPlace;
																				Mission._RadarBehaviour radarBehaviour9 = strike.RadarBehaviour;
																				bool useAutoPlanner9 = strike.UseAutoPlanner;
																				float num23 = 0f;
																				aircraftAI9.method_22(ref flight30, ref aircraft5, ref flight31.PrimaryTarget, ref strikeType, minResponseRadius8, maxResponseRadius8, useRefuel_9, launchMissionWithoutTankersInPlace9, radarBehaviour9, false, false, false, useAutoPlanner9, ref num23, ref aIFeedback.Feedback, ref mission_);
																				int num39;
																				checked
																				{
																					if (flight30.GetFlightCourse().Count<Waypoint>() == 0)
																					{
																						Waypoint[] array3 = current41.GetFlightCourse();
																						for (int n = 0; n < array3.Length; n++)
																						{
																							Waypoint waypoint5 = array3[n];
																							Mission.Flight flight32 = flight30;
																							Waypoint[] flightCourse = flight32.GetFlightCourse();
																							ScenarioArrayUtil.AddWaypoint(ref flightCourse, waypoint5.method_23(ref scenario_, ref waypoint5, true, true));
																							flight32.SetFlightCourse(flightCourse);
																						}
																					}
																					aIFeedback._MissionContainer.mission.FlightList.Add(flight30);
																					num39 = 1;
																				}
																				foreach (ActiveUnit current46 in list43)
																				{
																					if (list19.Contains((Aircraft)current46))
																					{
																						if (Information.IsNothing(aIFeedback._MissionContainer.mission.EmptySlotsList))
																						{
																							continue;
																						}
																						using (List<Mission.EmptySlot>.Enumerator enumerator58 = aIFeedback._MissionContainer.mission.EmptySlotsList.GetEnumerator())
																						{
																							while (enumerator58.MoveNext())
																							{
																								Mission.EmptySlot current47 = enumerator58.Current;
																								if (!Information.IsNothing(current47.method_0(scenario_, null)) && current47.method_0(scenario_, null) == current46)
																								{
																									current47.method_6(scenario_, flight30, num39, list43.Count);
																									num39++;
																									break;
																								}
																							}
																							continue;
																						}
																					}
																					current46.method_114(flight30, num39);
																					num39++;
																				}
																			}
																			IL_5891:
																			goto IL_7302;
																		}
																	}
																	goto IL_7302;
																}
															}
															Group group2 = new Group(ref scenario_, ref side_0, list43, false, null, aIFeedback._MissionContainer.mission);
															list.Add(group2);
															if (aIFeedback._MissionContainer.mission.list_0.Count > 0)
															{
																Aircraft aircraft6 = (Aircraft)group2.GetGroupLead();
																using (List<Mission.Flight>.Enumerator enumerator59 = aIFeedback._MissionContainer.mission.list_0.GetEnumerator())
																{
																	while (enumerator59.MoveNext())
																	{
																		Mission.Flight current48 = enumerator59.Current;
																		if (aircraft6.GetLoadoutDBID() == current48.LoadoutDBID && Operators.CompareString(aircraft6.GetAircraftAirOps().GetCurrentHostUnit().GetGuid(), current48.TakeOffLocation_HostUnitObjectID, false) == 0)
																		{
																			if (current48.GetWaypoint1().Count<Waypoint>() == 0 && !current48.UsedByFlight)
																			{
																				Mission.Flight flight33 = new Mission.Flight();
																				Mission.Flight flight34 = flight33;
																				GameGeneral.MissionContainer missionContainer21 = aIFeedback._MissionContainer;
																				int num40 = 0;
																				int num41 = 0;
																				flight34.SetFlight0ToFlight1(ref scenario_, ref current48, ref flight33, false, ref missionContainer21.mission, ref num40, ref num41);
																				aIFeedback._MissionContainer.mission.FlightList.Add(flight33);
																				current48.UsedByFlight = true;
																				int num42 = 2;
																				using (IEnumerator<ActiveUnit> enumerator60 = group2.GetUnitsInGroup().Values.GetEnumerator())
																				{
																					while (enumerator60.MoveNext())
																					{
																						ActiveUnit current49 = enumerator60.Current;
																						if (current49.IsGroupLead())
																						{
																							current49.method_114(flight33, 1);
																							group2.Name = "Flight " + flight33.Callsign;
																						}
																						else
																						{
																							current49.method_114(flight33, num42);
																							num42++;
																						}
																					}
																					break;
																				}
																			}
																			if (current48.GetWaypoint1().Count<Waypoint>() > 0)
																			{
																				Mission.Flight flight35 = new Mission.Flight();
																				Mission.Flight flight36 = flight35;
																				GameGeneral.MissionContainer missionContainer22 = aIFeedback._MissionContainer;
																				int num41 = 0;
																				int num40 = 0;
																				flight36.SetFlight0ToFlight1(ref scenario_, ref current48, ref flight35, false, ref missionContainer22.mission, ref num41, ref num40);
																				aIFeedback._MissionContainer.mission.FlightList.Add(flight35);
																				int num43;
																				checked
																				{
																					if (flight35.GetWaypoint1().Count<Waypoint>() > 0 && flight35.GetFlightCourse().Count<Waypoint>() == 0)
																					{
																						Waypoint[] array4 = flight35.GetWaypoint1();
																						Waypoint[] array5;
																						for (num40 = 0; num40 < array4.Length; num40++)
																						{
																							Waypoint waypoint6 = array4[num40];
																							Mission.Flight flight37 = flight35;
																							array5 = flight37.GetFlightCourse();
																							ScenarioArrayUtil.AddWaypoint(ref array5, waypoint6.method_23(ref scenario_, ref waypoint6, true, true));
																							flight37.SetFlightCourse(array5);
																						}
																						Mission.Flight flight38 = flight35;
																						array5 = flight38.GetWaypoint1();
																						ScenarioArrayUtil.ClearWaypoints(ref array5);
																						flight38.SetWaypoint1(array5);
																						Mission.Flight flight39 = flight35;
																						array5 = flight39.GetWaypoint2();
																						ScenarioArrayUtil.ClearWaypoints(ref array5);
																						flight39.SetWaypoint2(array5);
																					}
																					num43 = 2;
																				}
																				foreach (ActiveUnit current50 in group2.GetUnitsInGroup().Values)
																				{
																					if (current50.IsGroupLead())
																					{
																						current50.method_114(flight35, 1);
																						group2.Name = "Flight " + flight35.Callsign;
																					}
																					else
																					{
																						current50.method_114(flight35, num43);
																						num43++;
																					}
																				}
																			}
																			else
																			{
																				Aircraft_AirOps aircraftAirOps14 = aircraft6.GetAircraftAirOps();
																				GameGeneral.MissionContainer missionContainer23 = aIFeedback._MissionContainer;
																				Mission.Flight flight_ = null;
																				Mission.Flight flight40 = new Mission.Flight(ref scenario_, ref missionContainer23.mission, ref flight_, CallsignGenerator.GenerateCallsignString(ref aIFeedback._MissionContainer.mission), aircraftAirOps14.GetCurrentHostUnit().GetGuid(), aircraftAirOps14.GetCurrentHostUnit().Name, aircraft6.GetLoadout().DBID, current48.PrimaryTarget, aircraft6);
																				ActiveUnit_AI aircraftAI10 = aircraft6.GetAircraftAI();
																				Mission.Flight flight41 = current48;
																				int minResponseRadius9 = strike.MinResponseRadius;
																				int maxResponseRadius9 = strike.MaxResponseRadius;
																				Doctrine._UseRefuel? useRefuel_10 = useRefuelDoctrine;
																				bool launchMissionWithoutTankersInPlace10 = aIFeedback._MissionContainer.mission.LaunchMissionWithoutTankersInPlace;
																				Mission._RadarBehaviour radarBehaviour10 = strike.RadarBehaviour;
																				bool useAutoPlanner10 = strike.UseAutoPlanner;
																				float num23 = 0f;
																				aircraftAI10.method_22(ref flight40, ref aircraft6, ref flight41.PrimaryTarget, ref strikeType, minResponseRadius9, maxResponseRadius9, useRefuel_10, launchMissionWithoutTankersInPlace10, radarBehaviour10, false, false, false, useAutoPlanner10, ref num23, ref aIFeedback.Feedback, ref mission_);
																				int num44;
																				checked
																				{
																					if (flight40.GetFlightCourse().Count<Waypoint>() == 0)
																					{
																						Waypoint[] array5 = current48.GetFlightCourse();
																						for (int num41 = 0; num41 < array5.Length; num41++)
																						{
																							Waypoint waypoint7 = array5[num41];
																							Mission.Flight flight42 = flight40;
																							Waypoint[] array2 = flight42.GetFlightCourse();
																							ScenarioArrayUtil.AddWaypoint(ref array2, waypoint7.method_23(ref scenario_, ref waypoint7, true, true));
																							flight42.SetFlightCourse(array2);
																						}
																					}
																					aIFeedback._MissionContainer.mission.FlightList.Add(flight40);
																					num44 = 2;
																				}
																				foreach (ActiveUnit current51 in group2.GetUnitsInGroup().Values)
																				{
																					if (current51.IsGroupLead())
																					{
																						current51.method_114(flight40, 1);
																						group2.Name = "Flight " + flight40.Callsign;
																					}
																					else
																					{
																						current51.method_114(flight40, num44);
																						num44++;
																					}
																				}
																			}
																			IL_5FB9:
																			goto IL_7302;
																		}
																	}
																	goto IL_7302;
																}
																goto IL_6234;
															}
															IL_7302:
															if (Information.IsNothing(num15))
															{
																goto IL_52A2;
															}
															IL_6234:
															if ((num15.HasValue ? new bool?(num27 >= num15.GetValueOrDefault()) : null).GetValueOrDefault())
															{
																flag16 = true;
																goto IL_6FEA;
															}
															goto IL_52A2;
														}
													}
												}
											}
											bool? flag19;
											bool? flag27;
											if (aIFeedback._MissionContainer.mission.MissionClass != Mission._MissionClass.Strike)
											{
												flag19 = new bool?(false);
											}
											else
											{
												bool? flag20;
												if (Information.IsNothing(num14))
												{
													flag20 = new bool?(false);
												}
												else
												{
													int num45 = list2.Count;
													flag20 = (num14.HasValue ? new bool?(num45 < num14.GetValueOrDefault()) : null);
												}
												bool? flag22;
												bool? flag21 = flag22 = flag20;
												bool? flag23;
												bool? flag25;
												if (flag21.HasValue && flag22.GetValueOrDefault())
												{
													flag23 = new bool?(true);
												}
												else
												{
													bool? flag24;
													if (Information.IsNothing(num16))
													{
														flag24 = new bool?(false);
													}
													else
													{
														int num45 = list3.Count;
														flag24 = (num16.HasValue ? new bool?(num45 < num16.GetValueOrDefault()) : null);
													}
													flag21 = (flag25 = flag24);
													flag23 = (flag21.HasValue ? (flag22 | flag25.GetValueOrDefault()) : null);
												}
												flag25 = (flag3 = flag23);
												if (flag25.HasValue && flag3.GetValueOrDefault())
												{
													flag19 = new bool?(true);
												}
												else
												{
													bool? flag26;
													if (flightSize3 != Mission._FlightSize.None && !Information.IsNothing(num18))
													{
														int num45 = list4.Count;
														flag26 = (num18.HasValue ? new bool?(num45 < num18.GetValueOrDefault()) : null);
													}
													else
													{
														flag26 = new bool?(false);
													}
													flag25 = (flag27 = flag26);
													flag19 = (flag25.HasValue ? (flag3 | flag27.GetValueOrDefault()) : null);
												}
											}
											flag27 = flag19;
											if (flag27.GetValueOrDefault())
											{
												using (List<Group>.Enumerator enumerator63 = list.GetEnumerator())
												{
													while (enumerator63.MoveNext())
													{
														enumerator63.Current.DestroyUnit(false, false, true);
													}
												}
												if (aIFeedback._MissionContainer.mission.int_0 == 1 || !Information.IsNothing(mission_))
												{
													if (aIFeedback._MissionContainer.mission.category == Mission.MissionCategory.Mission)
													{
														scenario_.LogMessage("任务：" + aIFeedback._MissionContainer.mission.Name + "不能满足最少飞机数量要求。任务不能启动。当根据机场/母舰平台、飞机型号或者挂载进行区分时，没有足够的飞机满足飞行编队的最低规模要求。可能解决方案：添加更多的突击飞机或者护航飞机，飞机采用相同挂载，或者使用来自同一机场/母舰的飞机。 您还可以修改任务配置，减少突击/护航飞机所需最小数，或者减少编队规模要求。", LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
													}
													else
													{
														scenario_.LogMessage(aIFeedback._MissionContainer.mission.Name + "不能满足最少飞机数量要求。可能解决方案：将飞机从任务（Task）包中删除，改变编队规模，或者手动创建飞行计划。", LoggedMessage.MessageType.AirOps, 0, null, side_0, null);
													}
												}
												if (Information.IsNothing(mission_))
												{
													goto IL_79F6;
												}
												if (aIFeedback._MissionContainer.mission.category == Mission.MissionCategory.Mission)
												{
													Interaction.MsgBox("Mission " + aIFeedback._MissionContainer.mission.Name + " does not fulfill the minimum aircraft requirements. The mission will not launch. When divided by base/ship, aircraft type and loadout, there isn't enough aircraft to create the minimum number of flights. Possible solutions would be to add more strike aircraft and/or escorts, load aircraft with identical loadouts, or use aircraft from the same base/ship. Alternatively, re-configure the mission and reduce the minimum number of required strike aircraft and/or escorts, or reduce the flight size.", MsgBoxStyle.OkOnly, null);
													goto IL_79F6;
												}
												Interaction.MsgBox(aIFeedback._MissionContainer.mission.Name + " does not fulfill the minimum aircraft requirements. Possible solutions would be to remove the aircraft from the package, change the flight size, or manually create the flight.", MsgBoxStyle.OkOnly, null);
												goto IL_79F6;
											}
											else
											{
												if (bool_2)
												{
													for (int num46 = list.Count - 1; num46 >= 0; num46 += -1)
													{
														Group group3 = list[num46];
														if (!Information.IsNothing(group3.GetUnitsInGroup().Values) && group3.GetUnitsInGroup().Values.Count > 0)
														{
															ActiveUnit activeUnit2 = group3.GetUnitsInGroup().Values.ElementAtOrDefault(0);
															if (activeUnit2.GetNavigator().HasFlightCourse())
															{
																Waypoint waypoint8 = activeUnit2.GetNavigator().GetFlight().GetFlightCourse()[0];
																if (Information.IsNothing(waypoint8.ArrivalTime_Zulu))
																{
																	break;
																}
																if ((waypoint8.ArrivalTime_Zulu.Value - scenario_.GetCurrentTime(false)).TotalSeconds - num - 60.0 >= 0.0)
																{
																	using (IEnumerator<ActiveUnit> enumerator64 = group3.GetUnitsInGroup().Values.GetEnumerator())
																	{
																		while (enumerator64.MoveNext())
																		{
																			Aircraft item3 = (Aircraft)enumerator64.Current;
																			if (list2.Contains(item3))
																			{
																				list2.Remove(item3);
																			}
																			else if (list3.Contains(item3))
																			{
																				list3.Remove(item3);
																			}
																			else if (list4.Contains(item3))
																			{
																				list4.Remove(item3);
																			}
																		}
																	}
																	list.Remove(group3);
																	group3.DestroyUnit(false, false, true);
																}
															}
														}
													}
													List<Aircraft> list44 = new List<Aircraft>();
													list44.AddRange(list2);
													list44.AddRange(list3);
													list44.AddRange(list4);
													foreach (Aircraft current52 in list44)
													{
														if (current52.GetAircraftNavigator().HasFlightCourse())
														{
															Waypoint waypoint9 = current52.GetAircraftNavigator().GetFlight().GetFlightCourse()[0];
															if (Information.IsNothing(waypoint9.ArrivalTime_Zulu))
															{
																break;
															}
															if ((waypoint9.ArrivalTime_Zulu.Value - scenario_.GetCurrentTime(false)).TotalSeconds - num - 60.0 >= 0.0)
															{
																if (list2.Contains(current52))
																{
																	list2.Remove(current52);
																}
																else if (list3.Contains(current52))
																{
																	list3.Remove(current52);
																}
																else if (list4.Contains(current52))
																{
																	list4.Remove(current52);
																}
															}
														}
													}
													aIFeedback._MissionContainer.mission.PreparingToLaunch(list, list2, list3, list4);
													goto IL_79F6;
												}
												goto IL_79F6;
											}
											IL_4AB4:
											flightSize = aIFeedback._MissionContainer.mission.m_FlightSize;
											flag5 = aIFeedback._MissionContainer.mission.UseFlightSizeHardLimit;
											goto IL_4ADA;
										}
										IL_79F6:
										if (list10.Count > 0)
										{
											GameGeneral.UnitMissionPair unitMissionPair = new GameGeneral.UnitMissionPair(null);
											unitMissionPair.missionContainer = missionContainer;
											List<ActiveUnit> list45 = new List<ActiveUnit>();
											List<ActiveUnit> list46 = new List<ActiveUnit>();
											List<ActiveUnit> list47 = new List<ActiveUnit>();
											List<ActiveUnit> list48 = new List<ActiveUnit>();
											Mission._GroupSize groupSize = Mission._GroupSize.const_0;
											Mission._GroupSize groupSize2 = Mission._GroupSize.const_0;
											bool flag28 = false;
											bool flag29 = false;
											switch (unitMissionPair.missionContainer.mission.MissionClass)
											{
											case Mission._MissionClass.Strike:
											{
												Strike strike = (Strike)unitMissionPair.missionContainer.mission;
												bool flag30 = strike.SpecificTargets.Count > 0;
												groupSize = strike.m_GroupSize;
												groupSize2 = strike.Escort_GroupSize;
												flag28 = strike.UseGroupSizeHardLimit;
												flag29 = strike.UseGroupSizeHardLimit_Escort;
												Strike.StrikeType strikeType2 = strike.strikeType;
												switch (strikeType2)
												{
												case Strike.StrikeType.Air_Intercept:
													using (List<ActiveUnit>.Enumerator enumerator66 = list10.GetEnumerator())
													{
														while (enumerator66.MoveNext())
														{
															unitMissionPair.theUnit = enumerator66.Current;
															if (unitMissionPair.theUnit.GetAI().NotRedeploy())
															{
																if (unitMissionPair.theUnit.GetAI().IsEscort)
																{
																	list46.Add(unitMissionPair.theUnit);
																}
																else
																{
																	double num47 = (double)unitMissionPair.theUnit.GetKinematics().vmethod_22();
																	Weapon aAWWeapon_RangeMax = unitMissionPair.theUnit.GetWeaponry().GetAAWWeapon_RangeMax();
																	if (!Information.IsNothing(aAWWeapon_RangeMax))
																	{
																		num47 += (double)aAWWeapon_RangeMax.RangeAAWMax;
																	}
																	Doctrine._ShootTourists? shootTouristsDoctrine2 = unitMissionPair.theUnit.m_Doctrine.GetShootTouristsDoctrine(scenario_, false, false, false);
																	foreach (Contact current53 in side_0.GetContactList())
																	{
																		ActiveUnit_AI aI = unitMissionPair.theUnit.GetAI();
																		Contact theContact = current53;
																		Mission mission3 = unitMissionPair.missionContainer.mission;
																		Doctrine._ShootTourists? shootTouristsDoc_ = shootTouristsDoctrine2;
																		string text = "";
																		int num45 = 0;
																		if (aI.IsTargetForMission(theContact, mission3, shootTouristsDoc_, false, false, true, ref text, ref num45) && unitMissionPair.theUnit.GetAI().method_23(ref strike, current53.GetPostureStance(unitMissionPair.theUnit.GetSide(false))) && (double)unitMissionPair.theUnit.GetHorizontalRange(current53) <= num47 && current53.method_112(scenario_, side_0, null).Count < 2)
																		{
																			unitMissionPair.theUnit.GetAI().SetPrimaryTarget(current53);
																			list45.Add(unitMissionPair.theUnit);
																			break;
																		}
																	}
																}
															}
														}
														goto IL_99CE;
													}
													goto IL_7D37;
												case Strike.StrikeType.Land_Strike:
													goto IL_7D37;
												case Strike.StrikeType.Maritime_Strike:
													goto IL_7FE5;
												case Strike.StrikeType.Sub_Strike:
													break;
												default:
													goto IL_99CE;
												}
												IL_8293:
												using (List<ActiveUnit>.Enumerator enumerator68 = list10.GetEnumerator())
												{
													while (enumerator68.MoveNext())
													{
														unitMissionPair.theUnit = enumerator68.Current;
														GameGeneral.UnitMissionAIForShootTouristDoctrine unitMissionAIForShootTouristDoctrine = new GameGeneral.UnitMissionAIForShootTouristDoctrine(null);
														unitMissionAIForShootTouristDoctrine.unitMissionPair = unitMissionPair;
														if (unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetAI().NotRedeploy())
														{
															if (unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetAI().IsEscort)
															{
																list46.Add(unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit);
															}
															else
															{
																double num48 = (double)unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetKinematics().vmethod_22();
																Weapon aSWWeapon_RangeMax = unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetWeaponry().GetASWWeapon_RangeMax();
																if (!Information.IsNothing(aSWWeapon_RangeMax))
																{
																	num48 += (double)aSWWeapon_RangeMax.RangeASWMax;
																}
																unitMissionAIForShootTouristDoctrine.shootTouristsDoctrine = unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.m_Doctrine.GetShootTouristsDoctrine(scenario_, false, false, false);
																if (flag30)
																{
																	using (List<Contact>.Enumerator enumerator69 = side_0.GetContactList().GetEnumerator())
																	{
																		while (enumerator69.MoveNext())
																		{
																			Contact current54 = enumerator69.Current;
																			if (!current54.IsBiologics() && current54.IsSpecificTargetForStikeMission(strike) && unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetAI().method_23(ref strike, current54.GetPostureStance(side_0)) && (double)unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetHorizontalRange(current54) <= num48)
																			{
																				list45.Add(unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit);
																				break;
																			}
																		}
																		continue;
																	}
																}
																List<Contact> list49 = side_0.GetContactList().Where(new Func<Contact, bool>(unitMissionAIForShootTouristDoctrine.IsTargetForMyMission)).ToList<Contact>();
																foreach (Contact current55 in list49)
																{
																	if (!current55.IsBiologics() && unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetAI().method_23(ref strike, current55.GetPostureStance(side_0)) && (double)unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetHorizontalRange(current55) <= num48)
																	{
																		list45.Add(unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit);
																		break;
																	}
																}
															}
														}
													}
													goto IL_99CE;
												}
												goto IL_8556;
												IL_7FE5:
												using (List<ActiveUnit>.Enumerator enumerator71 = list10.GetEnumerator())
												{
													while (enumerator71.MoveNext())
													{
														unitMissionPair.theUnit = enumerator71.Current;
														GameGeneral.UnitMissionAIForShootTouristDoctrine unitMissionAIForShootTouristDoctrine = new GameGeneral.UnitMissionAIForShootTouristDoctrine(null);
														unitMissionAIForShootTouristDoctrine.unitMissionPair = unitMissionPair;
														if (unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetAI().NotRedeploy())
														{
															if (unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetAI().IsEscort)
															{
																list46.Add(unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit);
															}
															else
															{
																double num49 = (double)unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetKinematics().vmethod_22();
																Weapon aSUWWeapon_RangeMax = unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetWeaponry().GetASUWWeapon_RangeMax(false);
																if (!Information.IsNothing(aSUWWeapon_RangeMax))
																{
																	num49 += (double)aSUWWeapon_RangeMax.RangeASUWMax;
																}
																unitMissionAIForShootTouristDoctrine.shootTouristsDoctrine = unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.m_Doctrine.GetShootTouristsDoctrine(scenario_, false, false, false);
																if (flag30)
																{
																	using (List<Contact>.Enumerator enumerator72 = side_0.GetContactList().GetEnumerator())
																	{
																		while (enumerator72.MoveNext())
																		{
																			Contact current56 = enumerator72.Current;
																			if (current56.IsSpecificTargetForStikeMission(strike) && unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetAI().method_23(ref strike, current56.GetPostureStance(side_0)) && (double)unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetHorizontalRange(current56) <= num49)
																			{
																				list45.Add(unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit);
																				break;
																			}
																		}
																		continue;
																	}
																}
																List<Contact> list50 = side_0.GetContactList().Where(new Func<Contact, bool>(unitMissionAIForShootTouristDoctrine.IsTargetForMyMission)).ToList<Contact>();
																foreach (Contact current57 in list50)
																{
																	if (unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetAI().method_23(ref strike, current57.GetPostureStance(side_0)) && (double)unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetHorizontalRange(current57) <= num49)
																	{
																		list45.Add(unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit);
																		break;
																	}
																}
															}
														}
													}
													goto IL_99CE;
												}
												goto IL_8293;
												IL_7D37:
												using (List<ActiveUnit>.Enumerator enumerator74 = list10.GetEnumerator())
												{
													while (enumerator74.MoveNext())
													{
														unitMissionPair.theUnit = enumerator74.Current;
														GameGeneral.UnitMissionAIForShootTouristDoctrine unitMissionAIForShootTouristDoctrine = new GameGeneral.UnitMissionAIForShootTouristDoctrine(null);
														unitMissionAIForShootTouristDoctrine.unitMissionPair = unitMissionPair;
														if (unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetAI().NotRedeploy())
														{
															if (unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetAI().IsEscort)
															{
																list46.Add(unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit);
															}
															else
															{
																double num50 = (double)unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetKinematics().vmethod_22();
																Weapon landWeapon_RangeMax = unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetWeaponry().GetLandWeapon_RangeMax(false);
																if (!Information.IsNothing(landWeapon_RangeMax))
																{
																	num50 += (double)landWeapon_RangeMax.RangeLandMax;
																}
																unitMissionAIForShootTouristDoctrine.shootTouristsDoctrine = unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.m_Doctrine.GetShootTouristsDoctrine(scenario_, false, false, false);
																if (flag30)
																{
																	using (List<Contact>.Enumerator enumerator75 = side_0.GetContactList().GetEnumerator())
																	{
																		while (enumerator75.MoveNext())
																		{
																			Contact current58 = enumerator75.Current;
																			if (current58.IsSpecificTargetForStikeMission(strike) && unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetAI().method_23(ref strike, current58.GetPostureStance(side_0)) && (double)unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetHorizontalRange(current58) <= num50)
																			{
																				list45.Add(unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit);
																				break;
																			}
																		}
																		continue;
																	}
																}
																List<Contact> list51 = side_0.GetContactList().Where(new Func<Contact, bool>(unitMissionAIForShootTouristDoctrine.IsTargetForMyMission)).ToList<Contact>();
																foreach (Contact current59 in list51)
																{
																	if (unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetAI().method_23(ref strike, current59.GetPostureStance(side_0)) && (double)unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit.GetHorizontalRange(current59) <= num50)
																	{
																		list45.Add(unitMissionAIForShootTouristDoctrine.unitMissionPair.theUnit);
																		break;
																	}
																}
															}
														}
													}
													goto IL_99CE;
												}
												goto IL_7FE5;
											}
											case Mission._MissionClass.Patrol:
												goto IL_8556;
											case Mission._MissionClass.Support:
												goto IL_8841;
											case Mission._MissionClass.Ferry:
												goto IL_8B2C;
											case Mission._MissionClass.Mining:
												goto IL_8BA8;
											case Mission._MissionClass.MineClearing:
												goto IL_8DE9;
											default:
												goto IL_99CE;
											}
											IL_9370:
											int num51 = 0;
											List<Group> list52 = new List<Group>();
											using (List<ActiveUnit>.Enumerator enumerator77 = list12.GetEnumerator())
											{
												while (enumerator77.MoveNext())
												{
													GameGeneral.HostUnitHolder hostUnitHolder = new GameGeneral.HostUnitHolder(null);
													hostUnitHolder.HostUnit = enumerator77.Current;
													int num52 = 0;
													int num53 = 0;
													IEnumerable<ActiveUnit> enumerable4 = list45.Where(new Func<ActiveUnit, bool>(hostUnitHolder.CanHost));
													IEnumerable<ActiveUnit> enumerable5 = list46.Where(new Func<ActiveUnit, bool>(hostUnitHolder.CanHost1));
													if (enumerable4.Count<ActiveUnit>() > 0)
													{
														if (enumerable4.Count<ActiveUnit>() < (int)groupSize && flag28)
														{
															if (enumerable4.Count<ActiveUnit>() < (int)groupSize && unitMissionPair.missionContainer.mission.int_0 == 1)
															{
																scenario_.LogMessage(string.Concat(new string[]
																{
																	"执行任务：",
																	unitMissionPair.missionContainer.mission.Name,
																	"的水面舰艇/潜艇[基地：",
																	hostUnitHolder.HostUnit.Name,
																	"]不能部署。当根据基地/母舰平台区分时，没有足够的舰船满足编组规模要求。可能的解决方案是添加更多的舰船，您也可以修改任务配置，，减少需要舰艇的最少数量要求，或者缩减编组规模。"
																}), LoggedMessage.MessageType.DockingOps, 0, null, side_0, null);
															}
														}
														else if (groupSize > Mission._GroupSize.const_1)
														{
															int num54 = enumerable4.Count<ActiveUnit>();
															while (true)
															{
																if (flag28)
																{
																	if (num54 < (int)groupSize)
																	{
																		break;
																	}
																}
																else if (num54 == 0)
																{
																	break;
																}
																List<ActiveUnit> list53 = new List<ActiveUnit>();
																int num45 = (int)groupSize;
																int num55 = 1;
																while (num55 <= num45 && num52 < enumerable4.Count<ActiveUnit>())
																{
																	if (!Information.IsNothing(enumerable4.ElementAtOrDefault(num52)))
																	{
																		list53.Add(enumerable4.ElementAtOrDefault(num52));
																		list47.Add(enumerable4.ElementAtOrDefault(num52));
																		num51++;
																		num54--;
																		num52++;
																	}
																	num55++;
																}
																Group item4 = new Group(ref scenario_, ref side_0, list53, false, null, unitMissionPair.missionContainer.mission);
																list52.Add(item4);
															}
														}
														else
														{
															foreach (ActiveUnit current60 in enumerable4)
															{
																list47.Add(current60);
															}
														}
													}
													if (!Information.IsNothing(enumerable5) && enumerable5.Count<ActiveUnit>() > 0)
													{
														if (enumerable5.Count<ActiveUnit>() < (int)groupSize2 && flag29)
														{
															if (enumerable5.Count<ActiveUnit>() < (int)groupSize2 && unitMissionPair.missionContainer.mission.int_0 == 1)
															{
																scenario_.LogMessage(string.Concat(new string[]
																{
																	"执行任务：",
																	unitMissionPair.missionContainer.mission.Name,
																	"的水面舰艇/潜艇[基地：",
																	hostUnitHolder.HostUnit.Name,
																	"]不能部署。当根据基地/母舰平台区分时，没有足够的舰船满足编组规模要求。可能的解决方案是添加更多的舰船，您也可以修改任务配置，，减少需要舰艇的最少数量要求，或者缩减编组规模。"
																}), LoggedMessage.MessageType.DockingOps, 0, null, side_0, null);
															}
														}
														else if (groupSize2 > Mission._GroupSize.const_1)
														{
															int num56 = enumerable5.Count<ActiveUnit>();
															while (true)
															{
																if (flag29)
																{
																	if (num56 < (int)groupSize2)
																	{
																		break;
																	}
																}
																else if (num56 == 0)
																{
																	break;
																}
																List<ActiveUnit> list54 = new List<ActiveUnit>();
																int num57 = (int)groupSize2;
																int num58 = 1;
																while (num58 <= num57 && num53 < enumerable5.Count<ActiveUnit>())
																{
																	if (!Information.IsNothing(enumerable5.ElementAtOrDefault(num53)))
																	{
																		list54.Add(enumerable5.ElementAtOrDefault(num53));
																		list48.Add(enumerable5.ElementAtOrDefault(num53));
																		num51++;
																		num56--;
																		num53++;
																	}
																	num58++;
																}
																Group item5 = new Group(ref scenario_, ref side_0, list54, false, null, unitMissionPair.missionContainer.mission);
																list52.Add(item5);
															}
														}
														else
														{
															foreach (ActiveUnit current61 in enumerable5)
															{
																list48.Add(current61);
															}
														}
													}
												}
											}
											foreach (Group current62 in list52)
											{
												if (current62.GetUnitsInGroup().Values.Count == 1)
												{
													current62.GetUnitsInGroup().Values.ElementAtOrDefault(0).SetParentGroup(true, null);
													current62.DestroyUnit(false, false, true);
												}
											}
											foreach (ActiveUnit current63 in list48)
											{
												if (current63.GetDockingOps().GetDockingOpsCondition() == ActiveUnit_DockingOps._DockingOpsCondition.Docked)
												{
													current63.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
												}
											}
											using (List<ActiveUnit>.Enumerator enumerator82 = list47.GetEnumerator())
											{
												while (enumerator82.MoveNext())
												{
													ActiveUnit current64 = enumerator82.Current;
													if (current64.GetDockingOps().GetDockingOpsCondition() == ActiveUnit_DockingOps._DockingOpsCondition.Docked)
													{
														current64.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
													}
												}
												continue;
											}
											goto IL_99CE;
											IL_8DE9:
											MineClearingMission mineClearingMission2 = (MineClearingMission)unitMissionPair.missionContainer.mission;
											bool flag15 = ((MineClearingMission)unitMissionPair.missionContainer.mission).OTR;
											groupSize = mineClearingMission2.m_GroupSize;
											flag28 = mineClearingMission2.UseGroupSizeHardLimit;
											int num25;
											if (flag15)
											{
												using (List<int>.Enumerator enumerator83 = list15.GetEnumerator())
												{
													while (enumerator83.MoveNext())
													{
														GameGeneral.UnitDBIDComparer unitDBIDComparer = new GameGeneral.UnitDBIDComparer(null);
														unitDBIDComparer.DBID = enumerator83.Current;
														List<ActiveUnit> list55 = source.Where(new Func<ActiveUnit, bool>(unitDBIDComparer.HasSameDBIDWith)).ToList<ActiveUnit>();
														List<ActiveUnit> list56 = list10.Where(new Func<ActiveUnit, bool>(unitDBIDComparer.HasSameDBIDWith1)).ToList<ActiveUnit>();
														if (list56.Count > 0)
														{
															num25 = (int)Math.Round(Math.Ceiling((double)list55.Count / 3.0));
															List<ActiveUnit> list57 = list55.Where(GameGeneral.ActiveUnitFunc7).ToList<ActiveUnit>();
															int num59 = num25 - list57.Count;
															if (num59 > 0)
															{
																int num60 = 0;
																while (num59 > 0 && num60 < list56.Count)
																{
																	unitMissionPair.theUnit = list56[num60];
																	if (!Information.IsNothing(unitMissionPair.theUnit))
																	{
																		if (unitMissionPair.theUnit.IsSubmarine && (((Submarine)unitMissionPair.theUnit).Type == Submarine._SubmarineType.ROV || ((Submarine)unitMissionPair.theUnit).Type == Submarine._SubmarineType.UUV))
																		{
																			try
																			{
																				if (unitMissionPair.theUnit.GetDockingOps().GetCurrentHostUnit().GetNavigator().IsOnStation(ref mineClearingMission2.AreaVertices, ref mineClearingMission2.AreaVertices, ref mineClearingMission2.AreaVertices, 1, false, false))
																				{
																					list45.Add(unitMissionPair.theUnit);
																					num59--;
																				}
																				goto IL_90BD;
																			}
																			catch (Exception ex)
																			{
																				ProjectData.SetProjectError(ex);
																				Exception ex2 = ex;
																				ex2.Data.Add("Error at 200493", ex2.Message);
																				GameGeneral.LogException(ref ex2);
																				if (Debugger.IsAttached)
																				{
																					Debugger.Break();
																				}
																				ProjectData.ClearProjectError();
																				goto IL_90BD;
																			}
																		}
																		if (!Information.IsNothing(unitMissionPair.theUnit) && unitMissionPair.theUnit.GetAI().NotRedeploy())
																		{
																			list45.Add(unitMissionPair.theUnit);
																			num59--;
																		}
																	}
																	IL_90BD:
																	num60++;
																}
															}
														}
													}
													goto IL_99CE;
												}
											}
											List<ActiveUnit> list58 = new List<ActiveUnit>();
											List<int> list59 = new List<int>();
											foreach (ActiveUnit current65 in list10)
											{
												if (current65.IsSubmarine && (((Submarine)current65).Type == Submarine._SubmarineType.ROV || ((Submarine)current65).Type == Submarine._SubmarineType.UUV))
												{
													list58.Add(current65);
													if (!list59.Contains(current65.DBID))
													{
														list59.Add(current65.DBID);
													}
												}
												else if (!Information.IsNothing(unitMissionPair.theUnit) && unitMissionPair.theUnit.GetAI().NotRedeploy())
												{
													list45.Add(unitMissionPair.theUnit);
												}
											}
											if (list58.Count > 0)
											{
												using (List<int>.Enumerator enumerator85 = list59.GetEnumerator())
												{
													while (enumerator85.MoveNext())
													{
														GameGeneral.UnitDBIDComparer unitDBIDComparer = new GameGeneral.UnitDBIDComparer(null);
														unitDBIDComparer.DBID = enumerator85.Current;
														List<ActiveUnit> source2 = source.Where(new Func<ActiveUnit, bool>(unitDBIDComparer.HasSameDBIDWith)).ToList<ActiveUnit>();
														IEnumerable<ActiveUnit> source3 = source2.Where(GameGeneral.ActiveUnitFunc8).ToList<ActiveUnit>();
														num25 = (int)Math.Round(Math.Ceiling((double)source2.Count<ActiveUnit>() / 3.0));
														int num61 = num25 - source3.Count<ActiveUnit>();
														if (num61 > 0)
														{
															int num62 = 0;
															while (num61 > 0 && num62 < list58.Count)
															{
																if (list58[num62].GetDockingOps().GetCurrentHostUnit().GetNavigator().IsOnStation(ref mineClearingMission2.AreaVertices, ref mineClearingMission2.AreaVertices, ref mineClearingMission2.AreaVertices, 1, false, false))
																{
																	if (!Information.IsNothing(list58[num62]))
																	{
																		list45.Add(list58[num62]);
																	}
																	num61--;
																}
																num62++;
															}
														}
													}
													goto IL_99CE;
												}
												goto IL_9370;
											}
											goto IL_99CE;
											IL_8BA8:
											MiningMission miningMission2 = (MiningMission)unitMissionPair.missionContainer.mission;
											flag15 = ((MiningMission)unitMissionPair.missionContainer.mission).bOTR;
											groupSize = miningMission2.m_GroupSize;
											flag28 = miningMission2.UseGroupSizeHardLimit;
											if (flag15)
											{
												using (List<int>.Enumerator enumerator86 = list15.GetEnumerator())
												{
													while (enumerator86.MoveNext())
													{
														GameGeneral.UnitDBIDComparer unitDBIDComparer = new GameGeneral.UnitDBIDComparer(null);
														unitDBIDComparer.DBID = enumerator86.Current;
														List<ActiveUnit> list60 = source.Where(new Func<ActiveUnit, bool>(unitDBIDComparer.HasSameDBIDWith)).ToList<ActiveUnit>();
														List<ActiveUnit> list61 = list10.Where(new Func<ActiveUnit, bool>(unitDBIDComparer.HasSameDBIDWith1)).ToList<ActiveUnit>();
														if (list61.Count > 0)
														{
															num25 = (int)Math.Round(Math.Ceiling((double)list60.Count / 3.0));
															List<ActiveUnit> list62 = list60.Where(GameGeneral.ActiveUnitFunc6).ToList<ActiveUnit>();
															int num63 = num25 - list62.Count;
															if (num63 > 0)
															{
																int num64 = 0;
																while (num63 > 0 && num64 < list61.Count)
																{
																	unitMissionPair.theUnit = list61[num64];
																	if (!Information.IsNothing(unitMissionPair.theUnit) && unitMissionPair.theUnit.GetAI().NotRedeploy())
																	{
																		list45.Add(unitMissionPair.theUnit);
																		num63--;
																	}
																	num64++;
																}
															}
														}
													}
													goto IL_99CE;
												}
											}
											using (List<ActiveUnit>.Enumerator enumerator87 = list10.GetEnumerator())
											{
												while (enumerator87.MoveNext())
												{
													ActiveUnit current66 = enumerator87.Current;
													if (current66.GetAI().NotRedeploy())
													{
														list45.Add(current66);
													}
												}
												goto IL_99CE;
											}
											goto IL_8DE9;
											IL_8B2C:
											using (List<ActiveUnit>.Enumerator enumerator88 = list10.GetEnumerator())
											{
												while (enumerator88.MoveNext())
												{
													unitMissionPair.theUnit = enumerator88.Current;
													if (!Information.IsNothing(unitMissionPair.theUnit) && unitMissionPair.theUnit.GetAI().NotRedeploy())
													{
														list45.Add(unitMissionPair.theUnit);
													}
												}
												goto IL_99CE;
											}
											goto IL_8BA8;
											IL_8841:
											SupportMission supportMission2 = (SupportMission)unitMissionPair.missionContainer.mission;
											num25 = ((SupportMission)unitMissionPair.missionContainer.mission).MNOS;
											flag15 = ((SupportMission)unitMissionPair.missionContainer.mission).OTR;
											groupSize = supportMission2.m_GroupSize;
											flag28 = supportMission2.UseGroupSizeHardLimit;
											if (!flag15 && num25 <= 0)
											{
												using (List<ActiveUnit>.Enumerator enumerator89 = list10.GetEnumerator())
												{
													while (enumerator89.MoveNext())
													{
														unitMissionPair.theUnit = enumerator89.Current;
														if (!Information.IsNothing(unitMissionPair.theUnit) && unitMissionPair.theUnit.GetAI().NotRedeploy())
														{
															list45.Add(unitMissionPair.theUnit);
														}
													}
													goto IL_99CE;
												}
											}
											using (List<int>.Enumerator enumerator90 = list15.GetEnumerator())
											{
												while (enumerator90.MoveNext())
												{
													GameGeneral.UnitDBIDComparer unitDBIDComparer = new GameGeneral.UnitDBIDComparer(null);
													unitDBIDComparer.DBID = enumerator90.Current;
													List<ActiveUnit> list63 = source.Where(new Func<ActiveUnit, bool>(unitDBIDComparer.HasSameDBIDWith)).ToList<ActiveUnit>();
													if (flag15 && num25 > 0)
													{
														num25 = (int)Math.Round(Math.Max(Math.Ceiling((double)list63.Count / 3.0), (double)num25));
													}
													else if (flag15 && num25 == 0)
													{
														num25 = (int)Math.Round(Math.Ceiling((double)list63.Count / 3.0));
													}
													else if (!flag15 && num25 > 0)
													{
														num25 = num25;
													}
													List<ActiveUnit> list64 = list63.Where(GameGeneral.ActiveUnitFunc10).ToList<ActiveUnit>();
													List<ActiveUnit> list65 = list10.Where(new Func<ActiveUnit, bool>(unitDBIDComparer.HasSameDBIDWith1)).ToList<ActiveUnit>();
													if (list65.Count > 0)
													{
														int num65 = num25 - list64.Count;
														if (num65 > 0)
														{
															int num66 = 0;
															while (num65 > 0 && num66 < list65.Count)
															{
																unitMissionPair.theUnit = list65[num66];
																if (!Information.IsNothing(unitMissionPair.theUnit) && unitMissionPair.theUnit.GetAI().NotRedeploy())
																{
																	list45.Add(unitMissionPair.theUnit);
																	num65--;
																}
																num66++;
															}
														}
													}
												}
												goto IL_99CE;
											}
											goto IL_8B2C;
											IL_8556:
											Patrol patrol2 = (Patrol)unitMissionPair.missionContainer.mission;
											num25 = ((Patrol)unitMissionPair.missionContainer.mission).MNOS;
											flag15 = ((Patrol)unitMissionPair.missionContainer.mission).OTR;
											groupSize = patrol2.m_GroupSize;
											flag28 = patrol2.UseGroupSizeHardLimit;
											if (!flag15 && num25 <= 0)
											{
												using (List<ActiveUnit>.Enumerator enumerator91 = list10.GetEnumerator())
												{
													while (enumerator91.MoveNext())
													{
														unitMissionPair.theUnit = enumerator91.Current;
														if (!Information.IsNothing(unitMissionPair.theUnit) && unitMissionPair.theUnit.GetAI().NotRedeploy())
														{
															list45.Add(unitMissionPair.theUnit);
														}
													}
													goto IL_99CE;
												}
											}
											using (List<int>.Enumerator enumerator92 = list15.GetEnumerator())
											{
												while (enumerator92.MoveNext())
												{
													GameGeneral.UnitDBIDComparer unitDBIDComparer = new GameGeneral.UnitDBIDComparer(null);
													unitDBIDComparer.DBID = enumerator92.Current;
													List<ActiveUnit> list66 = source.Where(new Func<ActiveUnit, bool>(unitDBIDComparer.HasSameDBIDWith)).ToList<ActiveUnit>();
													if (flag15 && num25 > 0)
													{
														num25 = (int)Math.Round(Math.Max(Math.Ceiling((double)list66.Count / 3.0), (double)num25));
													}
													else if (flag15 && num25 == 0)
													{
														num25 = (int)Math.Round(Math.Ceiling((double)list66.Count / 3.0));
													}
													else if (!flag15 && num25 > 0)
													{
														num25 = num25;
													}
													List<ActiveUnit> list67 = list66.Where(GameGeneral.ActiveUnitFunc9).ToList<ActiveUnit>();
													List<ActiveUnit> list68 = list10.Where(new Func<ActiveUnit, bool>(unitDBIDComparer.HasSameDBIDWith1)).ToList<ActiveUnit>();
													if (list68.Count > 0)
													{
														int num67 = num25 - list67.Count;
														if (num67 > 0)
														{
															int num68 = 0;
															while (num67 > 0 && num68 < list68.Count)
															{
																unitMissionPair.theUnit = list68[num68];
																if (!Information.IsNothing(unitMissionPair.theUnit) && unitMissionPair.theUnit.GetAI().NotRedeploy())
																{
																	list45.Add(unitMissionPair.theUnit);
																	num67--;
																}
																num68++;
															}
														}
													}
												}
												goto IL_99CE;
											}
											goto IL_8841;
											IL_99CE:
											if (list45.Count > 0)
											{
												goto IL_9370;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 101246", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x003CC090 File Offset: 0x003CA290
		private static bool smethod_25(ref Scenario scenario_0, ref Side side_0, ref Mission mission_0, ref List<Aircraft> list_0, ref List<Aircraft> list_1, int? nullable_0, Mission._FlightSize _FlightSize_0)
		{
			bool result;
			if (list_0.Count == list_1.Count)
			{
				if (!Information.IsNothing(nullable_0))
				{
					int count = list_0.Count;
					if ((nullable_0.HasValue ? new bool?(count < nullable_0.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						scenario_0.LogMessage(string.Concat(new string[]
						{
							"***警告*** 任务: ",
							mission_0.Name,
							" (",
							Conversions.ToString(list_0.Count),
							")可用飞机总数小于触发任务执行所需的最低飞机数(",
							nullable_0.HasValue ? Conversions.ToString(nullable_0.GetValueOrDefault()) : null,
							"). 任务飞机不满足起飞条件。请将飞机从任务中删除。"
						}), LoggedMessage.MessageType.SpecialMessage, 0, null, side_0, null);
						using (List<Aircraft>.Enumerator enumerator = list_0.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								enumerator.Current.DeleteMission(false, null);
							}
						}
						result = false;
						return result;
					}
				}
				if (Information.IsNothing(nullable_0) && list_0.Count < (int)_FlightSize_0 && mission_0.UseFlightSizeHardLimit)
				{
					scenario_0.LogMessage(string.Concat(new string[]
					{
						"***警告*** 任务: ",
						mission_0.Name,
						" (",
						Conversions.ToString(list_0.Count),
						")可用飞机总数小于指定的规模规模要求(",
						Conversions.ToString((int)_FlightSize_0),
						")或者低于触发任务执行所需的最少飞机数。 任务飞机不满足起飞条件。请将飞机从任务中删除。"
					}), LoggedMessage.MessageType.SpecialMessage, 0, null, side_0, null);
					using (List<Aircraft>.Enumerator enumerator2 = list_0.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.DeleteMission(false, null);
						}
					}
					result = false;
					return result;
				}
			}
			result = true;
			return result;
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x003CC28C File Offset: 0x003CA48C
		public static bool CanIssueOrdersToUnit(Side side_0, Unit unit_0, bool bool_1, ref string string_9)
		{
			bool flag = false;
			bool result;
			try
			{
				if (!unit_0.IsActiveUnit())
				{
					flag = false;
				}
				else if (!((ActiveUnit)unit_0).GetCommStuff().IsNotOutOfComms())
				{
					string_9 = "Unit is out of comms";
					flag = false;
				}
				else if (unit_0.IsGroup)
				{
					foreach (ActiveUnit current in ((Group)unit_0).GetUnitsInGroup().Values)
					{
						Unit unit_ = current;
						string text = null;
						if (GameGeneral.CanIssueOrdersToUnit(side_0, unit_, bool_1, ref text))
						{
							flag = true;
							result = true;
							return result;
						}
					}
					string_9 = "Cannot issue orders to any member of this group";
					flag = false;
				}
				else
				{
					if (unit_0.IsWeapon)
					{
						Weapon weapon = (Weapon)unit_0;
						if (Information.IsNothing(weapon.GetDataLinkParent()))
						{
							flag = false;
							result = false;
							return result;
						}
						if (!bool_1 && weapon.GetWeaponType() == Weapon._WeaponType.Sonobuoy)
						{
							flag = false;
							result = false;
							return result;
						}
						if (weapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
						{
							flag = false;
							result = false;
							return result;
						}
					}
					flag = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200361", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x04003DA8 RID: 15784
		public static Func<ActiveUnit, bool> HasPier = (ActiveUnit activeUnit_0) => activeUnit_0.IsFacility && activeUnit_0.GetDockingOps().HasPier();

		// Token: 0x04003DA9 RID: 15785
		public static Func<ActiveUnit, bool> IsGroupFilter = (ActiveUnit activeUnit_0) => activeUnit_0.IsGroup;

		// Token: 0x04003DAA RID: 15786
		public static Func<Aircraft, bool> AircraftFunc2 = (Aircraft aircraft_0) => aircraft_0.GetAircraftAirOps().method_24() || (aircraft_0.IsOperating() && !aircraft_0.IsRTB());

		// Token: 0x04003DAB RID: 15787
		public static Func<Aircraft, bool> AircraftFunc3 = (Aircraft aircraft_0) => aircraft_0.GetAircraftAirOps().method_24() || (aircraft_0.IsOperating() && !aircraft_0.IsRTB());

		// Token: 0x04003DAC RID: 15788
		public static Func<Aircraft, bool> AircraftFunc4 = (Aircraft aircraft_0) => aircraft_0.GetAircraftAirOps().method_24() || (aircraft_0.IsOperating() && !aircraft_0.IsRTB());

		// Token: 0x04003DAD RID: 15789
		public static Func<Aircraft, bool> AircraftFunc5 = (Aircraft aircraft_0) => aircraft_0.GetAircraftAirOps().method_24() || (aircraft_0.IsOperating() && !aircraft_0.IsRTB());

		// Token: 0x04003DAE RID: 15790
		public static Func<ActiveUnit, bool> ActiveUnitFunc6 = (ActiveUnit activeUnit_0) => !activeUnit_0.IsParkedInPlace() && !activeUnit_0.IsRTB();

		// Token: 0x04003DAF RID: 15791
		public static Func<ActiveUnit, bool> ActiveUnitFunc7 = (ActiveUnit activeUnit_0) => !activeUnit_0.IsParkedInPlace() && !activeUnit_0.IsRTB();

		// Token: 0x04003DB0 RID: 15792
		public static Func<ActiveUnit, bool> ActiveUnitFunc8 = (ActiveUnit activeUnit_0) => !activeUnit_0.IsParkedInPlace() && !activeUnit_0.IsRTB();

		// Token: 0x04003DB1 RID: 15793
		public static Func<ActiveUnit, bool> ActiveUnitFunc9 = (ActiveUnit activeUnit_0) => !activeUnit_0.IsParkedInPlace() && !activeUnit_0.IsRTB();

		// Token: 0x04003DB2 RID: 15794
		public static Func<ActiveUnit, bool> ActiveUnitFunc10 = (ActiveUnit activeUnit_0) => !activeUnit_0.IsParkedInPlace() && !activeUnit_0.IsRTB();

		// 发布日期
		public static DateTime ReleaseDate = new DateTime(2017, 5, 5);

		// 版本
		public static string strVersion = "CommandX v1.12";

		// 是否专业版
		public static bool bProfessionEdition = false;

		// Token: 0x04003DB6 RID: 15798
		public static bool bUsePitchForWeapons = false;

		// Token: 0x04003DB7 RID: 15799
		public static Exception exception_0;

		// Token: 0x04003DB8 RID: 15800
		public static World world;

		// Token: 0x04003DB9 RID: 15801
		internal static Dictionary<Side, List<Side>> SideFriendsDictionary;

		// Token: 0x04003DBA RID: 15802
		private static string string_1 = "sellAr";

		// Token: 0x04003DBB RID: 15803
		private static string string_2 = "ebUnag";

		// Token: 0x04003DBC RID: 15804
		private static string string_3 = "oolaB";

		// Token: 0x04003DBD RID: 15805
		internal static string strPassword = GameGeneral.string_1 + GameGeneral.string_2 + GameGeneral.string_3;

		// Token: 0x04003DBE RID: 15806
		public static string strScenariosDir = Path.Combine(MyTemplate.GetApp().Info.DirectoryPath, "Scenarios");

		// Token: 0x04003DBF RID: 15807
		public static string strTempDir = Path.Combine(MyTemplate.GetApp().Info.DirectoryPath, "Temp");

		// Token: 0x04003DC0 RID: 15808
		public static string strAttachmentRepoDir = Path.Combine(MyTemplate.GetApp().Info.DirectoryPath, "AttachmentRepo");

		// Token: 0x04003DC1 RID: 15809
		internal static string strDBDir = Path.Combine(MyTemplate.GetApp().Info.DirectoryPath, "DB");

		// Token: 0x04003DC2 RID: 15810
		private static ConcurrentDictionary<Scenario, Stream1> ScenarioStreamDictionary = new ConcurrentDictionary<Scenario, Stream1>();

		// Token: 0x04003DC3 RID: 15811
		private static float SecondsSinceLastPulse = 0f;

		// Token: 0x04003DC4 RID: 15812
		private static int RandomStream;

		// Token: 0x04003DC5 RID: 15813
		private static Random[] RandomArray = new Random[10];

		// Token: 0x04003DC6 RID: 15814
		private static int int_1;

		// Token: 0x02000CCB RID: 3275
		[CompilerGenerated]
		public sealed class SimEngineEntityState
		{
			// Token: 0x06006C01 RID: 27649 RVA: 0x0002E211 File Offset: 0x0002C411
			public SimEngineEntityState(GameGeneral.SimEngineEntityState SimEntityState_)
			{
				if (SimEntityState_ != null)
				{
					this.ActiveUnits = SimEntityState_.ActiveUnits;
					this.elapsedTime = SimEntityState_.elapsedTime;
				}
			}

			// Token: 0x04003DD2 RID: 15826
			public List<ActiveUnit> ActiveUnits;

			// Token: 0x04003DD3 RID: 15827
			public float elapsedTime;
		}

		// Token: 0x02000CCC RID: 3276
		[CompilerGenerated]
		public sealed class SimEntityLogicSheduler
		{
			// Token: 0x06006C02 RID: 27650 RVA: 0x0002E237 File Offset: 0x0002C437
			public SimEntityLogicSheduler(GameGeneral.SimEntityLogicSheduler SimSheduler_)
			{
				if (SimSheduler_ != null)
				{
					this.ActiveUnits = SimSheduler_.ActiveUnits;
				}
			}

			// Token: 0x06006C03 RID: 27651 RVA: 0x003CC678 File Offset: 0x003CA878
			internal void ScheduleSimEntityBehaviorLogic(int index)
			{
				if (!Information.IsNothing(this.m_SimEngineEntityState.ActiveUnits[index]))
				{
					GameGeneral.ExecuteSimEntityBehaviorLogic(this.m_SimEngineEntityState.ActiveUnits[index], this.ActiveUnits, this.m_SimEngineEntityState.elapsedTime);
				}
			}

			// Token: 0x04003DD4 RID: 15828
			public ActiveUnit[] ActiveUnits;

			// Token: 0x04003DD5 RID: 15829
			public GameGeneral.SimEngineEntityState m_SimEngineEntityState;
		}

		// Token: 0x02000CCD RID: 3277
		[CompilerGenerated]
		public sealed class ScenarioStateKeeper
		{
			// Token: 0x06006C04 RID: 27652 RVA: 0x0002E251 File Offset: 0x0002C451
			public ScenarioStateKeeper(GameGeneral.ScenarioStateKeeper EmissionContainerTimeKeeper_)
			{
				if (EmissionContainerTimeKeeper_ != null)
				{
					this.scenario = EmissionContainerTimeKeeper_.scenario;
					this.elapsedTime = EmissionContainerTimeKeeper_.elapsedTime;
				}
			}

			// Token: 0x06006C05 RID: 27653 RVA: 0x003CC6C4 File Offset: 0x003CA8C4
			internal void UpdateSensoryState(Side side_)
			{
				try
				{
					side_.OutdatedContact(this.scenario);
					int num = side_.ActiveUnitArray.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						ActiveUnit activeUnit = null;
						try
						{
							if (i >= side_.ActiveUnitArray.Length)
							{
								i++;
								continue;
							}
							activeUnit = side_.ActiveUnitArray[i];
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
							i++;
							continue;
						}
						if (activeUnit.IsNotActive())
						{
							ScenarioArrayUtil.RemoveActiveUnit(ref side_.ActiveUnitArray, activeUnit);
						}
					}
					foreach (Contact current in side_.GetContactObservableDictionary().Values)
					{
						if (Information.IsNothing(current.GetEmissionContainerObDictionary()))
						{
							current.SetEmissionContainerObDictionary(new ObservableDictionary<int, EmissionContainer>());
						}
						current.SetIsPreciselyLocatedOnThisPulse(false);
						current.SetHasUncertaintyArea(false);
						List<int> list = new List<int>();
						list.AddRange(current.GetEmissionContainerObDictionary().Keys);
						foreach (int current2 in list)
						{
							current.GetEmissionContainerObDictionary()[current2].elapsedTime = current.GetEmissionContainerObDictionary()[current2].elapsedTime + this.elapsedTime;
						}
					}
					side_.UpdateContactsState(ref this.scenario);
					side_.ProcessContact(this.scenario, this.elapsedTime);
					side_.GetJammerPlatforms(true);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101293", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}

			// Token: 0x04003DD6 RID: 15830
			public Scenario scenario;

			// Token: 0x04003DD7 RID: 15831
			public float elapsedTime;
		}

		// Token: 0x02000CCE RID: 3278
		[CompilerGenerated]
		public sealed class AircraftAIFeedback
		{
			// Token: 0x06006C06 RID: 27654 RVA: 0x0002E277 File Offset: 0x0002C477
			public AircraftAIFeedback(GameGeneral.AircraftAIFeedback AircraftAIFeedback_)
			{
				if (AircraftAIFeedback_ != null)
				{
					this.aircraft = AircraftAIFeedback_.aircraft;
				}
			}

			// Token: 0x04003DD8 RID: 15832
			public Aircraft aircraft;

			// Token: 0x04003DD9 RID: 15833
			public GameGeneral.AIFeedback _AIFeedback;
		}

		// Token: 0x02000CCF RID: 3279
		[CompilerGenerated]
		public sealed class MissionContainer
		{
			// Token: 0x06006C07 RID: 27655 RVA: 0x0002E291 File Offset: 0x0002C491
			public MissionContainer(GameGeneral.MissionContainer MissionContainer_)
			{
				if (MissionContainer_ != null)
				{
					this.mission = MissionContainer_.mission;
				}
			}

			// Token: 0x04003DDA RID: 15834
			public Mission mission;
		}

		// Token: 0x02000CD0 RID: 3280
		[CompilerGenerated]
		public sealed class AircraftAIFeedbackForShootTouristDoctrine
		{
			// Token: 0x06006C08 RID: 27656 RVA: 0x0002E2AB File Offset: 0x0002C4AB
			public AircraftAIFeedbackForShootTouristDoctrine(GameGeneral.AircraftAIFeedbackForShootTouristDoctrine AircraftAIFeedbackForShootTouristDoctrine_)
			{
				if (AircraftAIFeedbackForShootTouristDoctrine_ != null)
				{
					this.shootTouristsDoctrine = AircraftAIFeedbackForShootTouristDoctrine_.shootTouristsDoctrine;
				}
			}

			// Token: 0x06006C09 RID: 27657 RVA: 0x003CC8F0 File Offset: 0x003CAAF0
			internal bool IsTargetForMyMission(Contact theTarget)
			{
				return this.aircraftAIFeedback.aircraft.GetAircraftAI().IsTargetForMission(theTarget, this.aircraftAIFeedback._AIFeedback._MissionContainer.mission, this.shootTouristsDoctrine, false, false, true, ref this.aircraftAIFeedback._AIFeedback.Feedback, ref this.aircraftAIFeedback._AIFeedback.FeedbackType) && this.aircraftAIFeedback.aircraft.GetAircraftWeaponry().HasWeaponsInConditionToAttackTarget(theTarget, true, this.aircraftAIFeedback.aircraft.m_Doctrine, ref this.aircraftAIFeedback._AIFeedback.Feedback, ref this.aircraftAIFeedback._AIFeedback.FeedbackSeverity, null);
			}

			// Token: 0x04003DDB RID: 15835
			public Doctrine._ShootTourists? shootTouristsDoctrine;

			// Token: 0x04003DDC RID: 15836
			public GameGeneral.AircraftAIFeedback aircraftAIFeedback;
		}

		// Token: 0x02000CD1 RID: 3281
		[CompilerGenerated]
		public sealed class AIFeedback
		{
			// Token: 0x06006C0A RID: 27658 RVA: 0x0002E2C5 File Offset: 0x0002C4C5
			public AIFeedback(GameGeneral.AIFeedback AIFeedback_)
			{
				if (AIFeedback_ != null)
				{
					this.Feedback = AIFeedback_.Feedback;
					this.FeedbackType = AIFeedback_.FeedbackType;
					this.FeedbackSeverity = AIFeedback_.FeedbackSeverity;
				}
			}

			// Token: 0x04003DDD RID: 15837
			public string Feedback;

			// Token: 0x04003DDE RID: 15838
			public int FeedbackType;

			// Token: 0x04003DDF RID: 15839
			public int FeedbackSeverity;

			// Token: 0x04003DE0 RID: 15840
			public GameGeneral.MissionContainer _MissionContainer;
		}

		// Token: 0x02000CD2 RID: 3282
		[CompilerGenerated]
		public sealed class AircraftDBIDHolder
		{
			// Token: 0x06006C0B RID: 27659 RVA: 0x0002E2F7 File Offset: 0x0002C4F7
			public AircraftDBIDHolder(GameGeneral.AircraftDBIDHolder AircraftDBIDHolder_)
			{
				if (AircraftDBIDHolder_ != null)
				{
					this.DBID = AircraftDBIDHolder_.DBID;
				}
			}

			// Token: 0x06006C0C RID: 27660 RVA: 0x0002E311 File Offset: 0x0002C511
			internal bool HasSameDBIDWith(Aircraft aircraft_)
			{
				return aircraft_.DBID == this.DBID;
			}

			// Token: 0x06006C0D RID: 27661 RVA: 0x0002E311 File Offset: 0x0002C511
			internal bool HasSameDBIDWith1(Aircraft aircraft_)
			{
				return aircraft_.DBID == this.DBID;
			}

			// Token: 0x04003DE1 RID: 15841
			public int DBID;
		}

		// Token: 0x02000CD3 RID: 3283
		[CompilerGenerated]
		public sealed class AircraftHostManager
		{
			// Token: 0x06006C0E RID: 27662 RVA: 0x0002E321 File Offset: 0x0002C521
			public AircraftHostManager(GameGeneral.AircraftHostManager AircraftHostManager_)
			{
				if (AircraftHostManager_ != null)
				{
					this.LoadoutDBID = AircraftHostManager_.LoadoutDBID;
				}
			}

			// Token: 0x06006C0F RID: 27663 RVA: 0x0002E33B File Offset: 0x0002C53B
			internal bool CanHost(Aircraft aircraft_)
			{
				return aircraft_.GetLoadout().DBID == this.LoadoutDBID && aircraft_.GetAircraftAirOps().GetCurrentHostUnit() == this.aircraftHost.HostUnit;
			}

			// Token: 0x06006C10 RID: 27664 RVA: 0x0002E33B File Offset: 0x0002C53B
			internal bool CanHost1(Aircraft aircraft_)
			{
				return aircraft_.GetLoadout().DBID == this.LoadoutDBID && aircraft_.GetAircraftAirOps().GetCurrentHostUnit() == this.aircraftHost.HostUnit;
			}

			// Token: 0x06006C11 RID: 27665 RVA: 0x0002E36B File Offset: 0x0002C56B
			internal bool method_2(Aircraft aircraft_)
			{
				return aircraft_.GetLoadout().DBID == this.LoadoutDBID && aircraft_.GetAircraftAirOps().GetCurrentHostUnit() == this.aircraftHost.HostUnit && !aircraft_.GetLoadout().method_15();
			}

			// Token: 0x06006C12 RID: 27666 RVA: 0x0002E3A9 File Offset: 0x0002C5A9
			internal bool method_3(Aircraft aircraft_)
			{
				return aircraft_.GetLoadout().DBID == this.LoadoutDBID && aircraft_.GetAircraftAirOps().GetCurrentHostUnit() == this.aircraftHost.HostUnit && aircraft_.GetLoadout().method_15();
			}

			// Token: 0x04003DE2 RID: 15842
			public int LoadoutDBID;

			// Token: 0x04003DE3 RID: 15843
			public GameGeneral.ActiveUnitHost aircraftHost;
		}

		// Token: 0x02000CD4 RID: 3284
		[CompilerGenerated]
		public sealed class ActiveUnitHost
		{
			// Token: 0x06006C13 RID: 27667 RVA: 0x0002E3E4 File Offset: 0x0002C5E4
			public ActiveUnitHost(GameGeneral.ActiveUnitHost ActiveUnitHolder_)
			{
				if (ActiveUnitHolder_ != null)
				{
					this.HostUnit = ActiveUnitHolder_.HostUnit;
				}
			}

			// Token: 0x04003DE4 RID: 15844
			public ActiveUnit HostUnit;
		}

		// Token: 0x02000CD5 RID: 3285
		[CompilerGenerated]
		public sealed class UnitMissionPair
		{
			// Token: 0x06006C14 RID: 27668 RVA: 0x0002E3FE File Offset: 0x0002C5FE
			public UnitMissionPair(GameGeneral.UnitMissionPair UnitMissionPair_)
			{
				if (UnitMissionPair_ != null)
				{
					this.theUnit = UnitMissionPair_.theUnit;
				}
			}

			// Token: 0x04003DE5 RID: 15845
			public ActiveUnit theUnit;

			// Token: 0x04003DE6 RID: 15846
			public GameGeneral.MissionContainer missionContainer;
		}

		// Token: 0x02000CD6 RID: 3286
		[CompilerGenerated]
		public sealed class UnitMissionAIForShootTouristDoctrine
		{
			// Token: 0x06006C15 RID: 27669 RVA: 0x0002E418 File Offset: 0x0002C618
			public UnitMissionAIForShootTouristDoctrine(GameGeneral.UnitMissionAIForShootTouristDoctrine UnitMissionAIForShootTouristDoctrine_)
			{
				if (UnitMissionAIForShootTouristDoctrine_ != null)
				{
					this.shootTouristsDoctrine = UnitMissionAIForShootTouristDoctrine_.shootTouristsDoctrine;
				}
			}

			// Token: 0x06006C16 RID: 27670 RVA: 0x003CC9A0 File Offset: 0x003CABA0
			internal bool IsTargetForMyMission(Contact theTarget)
			{
				ActiveUnit_AI aI = this.unitMissionPair.theUnit.GetAI();
				Mission mission = this.unitMissionPair.missionContainer.mission;
				Doctrine._ShootTourists? shootTouristsDoc_ = this.shootTouristsDoctrine;
				string text = "";
				int num = 0;
				return aI.IsTargetForMission(theTarget, mission, shootTouristsDoc_, false, false, true, ref text, ref num);
			}

			// Token: 0x04003DE7 RID: 15847
			public Doctrine._ShootTourists? shootTouristsDoctrine;

			// Token: 0x04003DE8 RID: 15848
			public GameGeneral.UnitMissionPair unitMissionPair;
		}

		// Token: 0x02000CD7 RID: 3287
		[CompilerGenerated]
		public sealed class UnitDBIDComparer
		{
			// Token: 0x06006C17 RID: 27671 RVA: 0x0002E432 File Offset: 0x0002C632
			public UnitDBIDComparer(GameGeneral.UnitDBIDComparer UnitDBIDComparer_)
			{
				if (UnitDBIDComparer_ != null)
				{
					this.DBID = UnitDBIDComparer_.DBID;
				}
			}

			// Token: 0x06006C18 RID: 27672 RVA: 0x0002E44C File Offset: 0x0002C64C
			internal bool HasSameDBIDWith(ActiveUnit activeUnit_)
			{
				return activeUnit_.DBID == this.DBID;
			}

			// Token: 0x06006C19 RID: 27673 RVA: 0x0002E44C File Offset: 0x0002C64C
			internal bool HasSameDBIDWith1(ActiveUnit activeUnit_)
			{
				return activeUnit_.DBID == this.DBID;
			}

			// Token: 0x04003DE9 RID: 15849
			public int DBID;
		}

		// Token: 0x02000CD8 RID: 3288
		[CompilerGenerated]
		public sealed class HostUnitHolder
		{
			// Token: 0x06006C1A RID: 27674 RVA: 0x0002E45C File Offset: 0x0002C65C
			public HostUnitHolder(GameGeneral.HostUnitHolder HostUnitHolder_)
			{
				if (HostUnitHolder_ != null)
				{
					this.HostUnit = HostUnitHolder_.HostUnit;
				}
			}

			// Token: 0x06006C1B RID: 27675 RVA: 0x0002E476 File Offset: 0x0002C676
			internal bool CanHost(ActiveUnit activeUnit_)
			{
				return activeUnit_.GetDockingOps().GetCurrentHostUnit() == this.HostUnit;
			}

			// Token: 0x06006C1C RID: 27676 RVA: 0x0002E476 File Offset: 0x0002C676
			internal bool CanHost1(ActiveUnit activeUnit_)
			{
				return activeUnit_.GetDockingOps().GetCurrentHostUnit() == this.HostUnit;
			}

			// Token: 0x04003DEA RID: 15850
			public ActiveUnit HostUnit;
		}
	}
}
