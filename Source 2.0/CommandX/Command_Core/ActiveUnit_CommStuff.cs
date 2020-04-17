using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns3;
using ns4;

namespace Command_Core
{
	// 通信设备
	public class ActiveUnit_CommStuff
	{
		// 保存
		public virtual void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					if (this.CommLinksEstablished.Count<ActiveUnit_CommLink>() > 0)
					{
						xmlWriter_0.WriteStartElement("CLE");
						ActiveUnit_CommLink[] array = this.CommLinksEstablished.ToArray<ActiveUnit_CommLink>();
						for (int i = 0; i < array.Length; i++)
						{
							array[i].Save(ref xmlWriter_0, ref hashSet_0, this.ParentPlatform.m_Scenario);
							xmlWriter_0.Flush();
						}
						xmlWriter_0.WriteEndElement();
					}
					bool? flag = this.bNotOutOfComms;
					if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						xmlWriter_0.WriteElementString("OOC", "True");
					}
					if (!this.IsCommSpoofed)
					{
						xmlWriter_0.WriteElementString("ICS", "False");
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100100", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x00012192 File Offset: 0x00010392
		private ActiveUnit_CommStuff()
		{
			this.CommLinksEstablished = new ActiveUnit_CommLink[0];
			this.IsCommSpoofed = true;
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x000BE4C4 File Offset: 0x000BC6C4
		public ActiveUnit_CommStuff(ref ActiveUnit activeUnit_1)
		{
			this.CommLinksEstablished = new ActiveUnit_CommLink[0];
			this.IsCommSpoofed = true;
			this.ParentPlatform = activeUnit_1;
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x000BE518 File Offset: 0x000BC718
		public ActiveUnit_CommStuff._OOCReason GetReasonOfOffGrid()
		{
			ActiveUnit_CommStuff._OOCReason result;
			if (this.IsCommSpoofed)
			{
				result = ActiveUnit_CommStuff._OOCReason.CommSpoofed;
			}
			else
			{
				result = ActiveUnit_CommStuff._OOCReason.NetworkAttackOrActOfGod;
			}
			return result;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x000121D0 File Offset: 0x000103D0
		public bool IsNotOutOfComms()
		{
			if (!this.bNotOutOfComms.HasValue)
			{
				this.bNotOutOfComms = new bool?(true);
			}
			return this.bNotOutOfComms.Value;
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x000BE53C File Offset: 0x000BC73C
		public void SetIsNotOutOfComms(ActiveUnit_CommStuff._OOCReason reason, bool Value)
		{
			bool? flag = this.bNotOutOfComms;
			bool flag2 = flag.HasValue && flag.Value != Value;
			this.bNotOutOfComms = new bool?(Value);
			if (flag2)
			{
				if (!Value)
				{
					if (reason == ActiveUnit_CommStuff._OOCReason.NetworkAttackOrActOfGod)
					{
						this.IsCommSpoofed = false;
					}
					this.ParentPlatform.GetSensory().ContactEntryDictionaryClear();
					this.ParentPlatform.GetSensory().ContactList_OffGridAdd();
					if (reason == ActiveUnit_CommStuff._OOCReason.NetworkAttackOrActOfGod)
					{
						this.ParentPlatform.LogMessage(this.ParentPlatform.Name + " has dropped off the communications network! (Network attack or act of God)", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
					}
					else if (reason == ActiveUnit_CommStuff._OOCReason.CommSpoofed)
					{
						this.ParentPlatform.LogMessage(this.ParentPlatform.Name + " has dropped off the communications network! (All comm devices incapacitated)", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
					}
				}
				else
				{
					this.IsCommSpoofed = true;
					this.ParentPlatform.GetSensory().RejoinedComNetwork();
				}
			}
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x000BE680 File Offset: 0x000BC880
		public ActiveUnit_CommLink[] GetCommLinksEstablished()
		{
			return this.CommLinksEstablished;
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x000121F6 File Offset: 0x000103F6
		public void RemoveCommLink(ActiveUnit_CommLink link)
		{
			ScenarioArrayUtil.RemoveActiveUnit_CommLink(ref this.CommLinksEstablished, link);
		}

		// 通信干扰
		public void UpdateCommsJamming()
		{
            // 取父平台的所有通信设备
			CommDevice[] commDevices = this.ParentPlatform.GetCommDevices();
			checked
			{
				if (commDevices.Count<CommDevice>() != 0 && commDevices.Where(this.CommDeviceFunc).Count<CommDevice>() != 0)
				{
					ActiveUnit[] unitsUnderJamming = this.GetUnitsUnderJamming();
					if (unitsUnderJamming.Length > 0)
					{
						HashSet<CommDevice> hashSet = new HashSet<CommDevice>();
						ActiveUnit[] array = unitsUnderJamming;
						for (int i = 0; i < array.Length; i++)
						{
							ActiveUnit activeUnit = array[i];
							bool? flag = null;
							float? num = null;
							Sensor[] noneMCMSensors = activeUnit.GetNoneMCMSensors();
							for (int j = 0; j < noneMCMSensors.Length; j++)
							{
								Sensor sensor = noneMCMSensors[j];
								if (sensor.IsEmmitting() && sensor.IsCommunicationsJammer())
								{
									CommDevice[] array2 = commDevices;
									for (int k = 0; k < array2.Length; k++)
									{
										CommDevice commDevice = array2[k];
										if (commDevice.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && commDevice.commLinkType != CommDevice.CommLinkType.Land_Line)
										{
											if (!num.HasValue)
											{
												num = new float?(this.ParentPlatform.GetSlantRange(activeUnit, 0f));
											}
											if (!ECM.IsComDeviceNotSpoofed(commDevice, sensor, num.Value))
											{
												if (!sensor.IsOTH() && !flag.HasValue)
												{
													flag = new bool?(this.ParentPlatform.IsLOS_Exists_Radar(activeUnit, ref this.ParentPlatform.m_Scenario, false));
												}
												if ((flag | sensor.IsOTH()).GetValueOrDefault())
												{
													hashSet.Add(commDevice);
												}
											}
										}
									}
								}
							}
						}
						CommDevice[] array3 = commDevices;
						for (int l = 0; l < array3.Length; l++)
						{
							CommDevice commDevice2 = array3[l];
							if (commDevice2.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && commDevice2.commLinkType != CommDevice.CommLinkType.Land_Line)
							{
								if (hashSet.Contains(commDevice2))
								{
									commDevice2.IsJammed = true;
								}
								else
								{
									commDevice2.IsJammed = false;
								}
							}
						}
					}
					else
					{
						CommDevice[] array4 = commDevices;
						for (int m = 0; m < array4.Length; m++)
						{
							CommDevice commDevice3 = array4[m];
							if (commDevice3.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && commDevice3.commLinkType != CommDevice.CommLinkType.Land_Line)
							{
								commDevice3.IsJammed = false;
							}
						}
					}
					bool flag2 = false;
					CommDevice[] array5 = commDevices;
					int n = 0;
					while (n < array5.Length)
					{
						CommDevice commDevice4 = array5[n];
						if (commDevice4.method_29() || commDevice4.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational || commDevice4.IsJammed)
						{
							n++;
						}
						else
						{
							if (this.IsCommSpoofed)
							{
								this.SetIsNotOutOfComms(ActiveUnit_CommStuff._OOCReason.const_0, true);
								return;
							}
							return;
						}
					}
					if (!flag2)
					{
						if (this.IsCommSpoofed)
						{
							this.SetIsNotOutOfComms(ActiveUnit_CommStuff._OOCReason.CommSpoofed, false);
						}
					}
					else if (this.IsCommSpoofed)
					{
						this.SetIsNotOutOfComms(ActiveUnit_CommStuff._OOCReason.const_0, true);
					}
				}
			}
		}

		// 取被干扰的单元
		private ActiveUnit[] GetUnitsUnderJamming()
		{
			ActiveUnit[] array = new ActiveUnit[0];
			ActiveUnit[] result;
			try
			{
				if (!this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CommsJamming))
				{
					result = array;
				}
				else if (this.ParentPlatform.IsWeapon && ((Weapon)this.ParentPlatform).weaponCode.HomeOnJam)
				{
					result = array;
				}
				else
				{
					Side[] sides = this.ParentPlatform.m_Scenario.GetSides();
					for (int i = 0; i < sides.Length; i = checked(i + 1))
					{
						Side side = sides[i];
						if (!Information.IsNothing(side) && !Information.IsNothing(this.ParentPlatform.GetSide(false)) && side != this.ParentPlatform.GetSide(false) && !this.ParentPlatform.GetSide(false).IsFriendlyToSide(side))
						{
							for (int j = side.GetJammerPlatforms(false).Count - 1; j >= 0; j += -1)
							{
								ActiveUnit activeUnit = side.GetJammerPlatforms(false)[j];
								if (this.IsJammedBy(activeUnit))
								{
									ScenarioArrayUtil.AddActiveUnit(ref array, activeUnit);
								}
							}
						}
					}
					result = array;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100240", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = array;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// 是否被干扰
		public bool IsJammed()
		{
			bool flag = false;
			bool result;
			try
			{
				if (!this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CommsJamming))
				{
					flag = false;
				}
				else if (this.ParentPlatform.IsWeapon && ((Weapon)this.ParentPlatform).weaponCode.HomeOnJam)
				{
					flag = false;
				}
				else
				{
					Side[] sides = this.ParentPlatform.m_Scenario.GetSides();
					for (int i = 0; i < sides.Length; i = checked(i + 1))
					{
						Side side = sides[i];
						if (!Information.IsNothing(side) && !Information.IsNothing(this.ParentPlatform.GetSide(false)) && side != this.ParentPlatform.GetSide(false) && !this.ParentPlatform.GetSide(false).IsFriendlyToSide(side))
						{
							for (int j = side.GetJammerPlatforms(false).Count - 1; j >= 0; j += -1)
							{
								ActiveUnit jammer_ = side.GetJammerPlatforms(false)[j];
								if (this.IsJammedBy(jammer_))
								{
									flag = true;
									result = true;
									return result;
								}
							}
						}
					}
					flag = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100240", "");
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

		// 是否被某个单元干扰了
		private bool IsJammedBy(ActiveUnit Jammer_)
		{
			bool result = false;
			if (Information.IsNothing(Jammer_))
			{
				result = false;
			}
			else
			{
				try
				{
					bool flag = false;
					Sensor[] allNoneMCMSensors = Jammer_.GetAllNoneMCMSensors();
					bool flag2 = false;
					for (int i = allNoneMCMSensors.Length - 1; i >= 0; i += -1)
					{
						Sensor sensor = allNoneMCMSensors[i];
						if (sensor.IsCommunicationsJammer())
						{
							if (sensor.IsOTH())
							{
								flag2 = true;
							}
							if (sensor.IsEmmitting() && sensor.IsTargetInCoverageArc(this.ParentPlatform, null))
							{
								int j = this.ParentPlatform.GetCommDevices().Count<CommDevice>() - 1;
								while (j >= 0)
								{
									CommDevice commDevice_ = this.ParentPlatform.GetCommDevices()[j];
									if (!sensor.HasJammingCondition(commDevice_))
									{
										j += -1;
									}
									else
									{
										flag = true;
										result = (flag2 || this.ParentPlatform.IsLOS_Exists_Radar(Jammer_, ref this.ParentPlatform.m_Scenario, false));
									}
								}
								if (flag)
								{
									result = (flag2 || this.ParentPlatform.IsLOS_Exists_Radar(Jammer_, ref this.ParentPlatform.m_Scenario, false));
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200352", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

        // Token: 0x06001D92 RID: 7570 RVA: 0x00004BC2 File Offset: 0x00002DC2
        public virtual void vmethod_1(float float_1)
		{
		}

		// 清除被占用的通道
		public virtual void ClearOccupiedChannels()
		{
			checked
			{
				try
				{
					this.CommLinksEstablished = new ActiveUnit_CommLink[0];
					CommDevice[] commDevices = this.ParentPlatform.GetCommDevices();
					for (int i = 0; i < commDevices.Length; i++)
					{
						commDevices[i].SetOccupiedChannels(0);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100103", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x000BEE8C File Offset: 0x000BD08C
		public virtual  bool vmethod_3(CommDevice commDevice_0, ActiveUnit activeUnit_1, bool bool_1)
		{
			if (Information.IsNothing(commDevice_0))
			{
				commDevice_0 = this.method_7(null, activeUnit_1);
			}
			bool flag = false;
			bool result;
			if (Information.IsNothing(commDevice_0))
			{
				flag = false;
			}
			else
			{
				try
				{
					ScenarioArrayUtil.AddActiveUnit_CommLink(ref this.CommLinksEstablished, new ActiveUnit_CommLink(ref activeUnit_1, ref commDevice_0));
					ScenarioArrayUtil.AddActiveUnit_CommLink(ref activeUnit_1.GetCommStuff().CommLinksEstablished, new ActiveUnit_CommLink(ref this.ParentPlatform, ref commDevice_0));
					commDevice_0.SetOccupiedChannels(commDevice_0.GetOccupiedChannels() + 1);
					CommDevice[] commDevices = activeUnit_1.GetCommDevices();
					checked
					{
						for (int i = 0; i < commDevices.Length; i++)
						{
							CommDevice commDevice = commDevices[i];
							if ((!bool_1 || !commDevice.ParentSpecific) && commDevice.commLinkType == commDevice_0.commLinkType && commDevice.MaxChannels > commDevice.GetOccupiedChannels())
							{
								commDevice.SetOccupiedChannels(unchecked(commDevice.GetOccupiedChannels() + 1));
								flag = true;
								result = true;
								return result;
							}
						}
						flag = false;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100106", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x000BEFBC File Offset: 0x000BD1BC
		public CommDevice method_7(CommDevice[] commDevice_0, ActiveUnit activeUnit_1)
		{
			Collection<CommDevice> collection = new Collection<CommDevice>();
			CommDevice result = null;
			checked
			{
				try
				{
					if (!activeUnit_1.IsOperating())
					{
						result = null;
					}
					else if (activeUnit_1.isDestroyed)
					{
						result = null;
					}
					else
					{
						if (Information.IsNothing(commDevice_0))
						{
							commDevice_0 = this.ParentPlatform.GetCommDevices();
						}
						double num = this.ParentPlatform.GetApproxAngularDistanceInDegrees(activeUnit_1);
						if (double.IsNaN(num))
						{
							num = 0.0;
						}
						if (this.ParentPlatform.IsWeapon && activeUnit_1.IsWeapon)
						{
							result = null;
						}
						else
						{
							CommDevice[] array = commDevice_0;
							for (int i = 0; i < array.Length; i++)
							{
								CommDevice commDevice = array[i];
								if (commDevice.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && !commDevice.IsJammed && (activeUnit_1.IsWeapon || this.ParentPlatform.IsWeapon || !commDevice.method_29()) && (activeUnit_1.IsSatellite() || this.ParentPlatform.IsSatellite() || !commDevice.IsSATCOM()) && commDevice.GetOccupiedChannels() < commDevice.MaxChannels)
								{
									CommDevice[] commDevices = activeUnit_1.GetCommDevices();
									for (int j = 0; j < commDevices.Length; j++)
									{
										CommDevice commDevice2 = commDevices[j];
										if (commDevice2.commLinkType == commDevice.commLinkType && !commDevice2.IsJammed && commDevice2.MaxChannels > commDevice2.GetOccupiedChannels())
										{
											double num2 = Math2.ApproxAngularDistance((double)((float)commDevice.Range));
											if (num <= num2)
											{
												if (commDevice.commCapability.LOS_Limited)
												{
													bool value;
													if (this.ParentPlatform.IsTorpedo())
													{
														bool? flag = null;
														if (!flag.HasValue)
														{
															Unit parentPlatform = this.ParentPlatform;
															ActiveUnit parentPlatform2 = this.ParentPlatform;
															bool flag2 = false;
															flag = new bool?(parentPlatform.IsLOS_Exists_Sonar(activeUnit_1, ref parentPlatform2.m_Scenario, ref flag2, null));
														}
														value = flag.Value;
													}
													else
													{
														bool? flag3 = null;
														if (!flag3.HasValue)
														{
															flag3 = new bool?(this.ParentPlatform.IsLOS_Exists_Radar(activeUnit_1, ref this.ParentPlatform.m_Scenario, false));
														}
														value = flag3.Value;
													}
													if (!value)
													{
														goto IL_220;
													}
												}
												collection.Add(commDevice);
											}
										}
										IL_220:;
									}
								}
							}
							int count = collection.Count;
							if (count != 0)
							{
								if (count != 1)
								{
									double num3 = 20000.0;
									CommDevice commDevice3 = null;
									foreach (CommDevice current in collection)
									{
										if (current.Range < num3)
										{
											num3 = current.Range;
											commDevice3 = current;
										}
									}
									result = commDevice3;
								}
								else
								{
									result = collection[0];
								}
							}
							else
							{
								result = null;
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100107", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x000BF30C File Offset: 0x000BD50C
		protected bool HaveFreeChannelAvaible()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					CommDevice[] commDevices = this.ParentPlatform.GetCommDevices();
					for (int i = 0; i < commDevices.Length; i++)
					{
						CommDevice commDevice = commDevices[i];
						if (commDevice.GetOccupiedChannels() < commDevice.MaxChannels)
						{
							flag = true;
							result = true;
							return result;
						}
					}
					flag = false;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100108", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x04000D1E RID: 3358
		private Func<CommDevice, bool> CommDeviceFunc = (CommDevice commDevice) => !commDevice.method_29();

		// Token: 0x04000D1F RID: 3359
		protected ActiveUnit ParentPlatform;

		// Token: 0x04000D20 RID: 3360
		protected ActiveUnit_CommLink[] CommLinksEstablished;

		// Token: 0x04000D21 RID: 3361
		public float float_0;

		// Token: 0x04000D22 RID: 3362
		protected bool? bNotOutOfComms;

		// Token: 0x04000D23 RID: 3363
		private bool IsCommSpoofed;

		// Token: 0x02000473 RID: 1139
		public enum _OOCReason
		{
			// Token: 0x04000D27 RID: 3367
			const_0,
			// Token: 0x04000D28 RID: 3368
			NetworkAttackOrActOfGod,
			// Token: 0x04000D29 RID: 3369
			CommSpoofed
		}
	}
}
