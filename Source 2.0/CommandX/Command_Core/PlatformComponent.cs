using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace Command_Core
{
	// Token: 平台组件
	public abstract class PlatformComponent : Subject
	{
		// Token: 0x060056B3 RID: 22195 RVA: 0x00255494 File Offset: 0x00253694
		[CompilerGenerated]
		public static void smethod_0(PlatformComponent.Delegate21 delegate21_1)
		{
			PlatformComponent.Delegate21 @delegate = PlatformComponent.delegate21_0;
			PlatformComponent.Delegate21 delegate2;
			do
			{
				delegate2 = @delegate;
				PlatformComponent.Delegate21 value = (PlatformComponent.Delegate21)Delegate.Combine(delegate2, delegate21_1);
				@delegate = Interlocked.CompareExchange<PlatformComponent.Delegate21>(ref PlatformComponent.delegate21_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x002554CC File Offset: 0x002536CC
		[CompilerGenerated]
		public static void smethod_1(PlatformComponent.Delegate21 delegate21_1)
		{
			PlatformComponent.Delegate21 @delegate = PlatformComponent.delegate21_0;
			PlatformComponent.Delegate21 delegate2;
			do
			{
				delegate2 = @delegate;
				PlatformComponent.Delegate21 value = (PlatformComponent.Delegate21)Delegate.Remove(delegate2, delegate21_1);
				@delegate = Interlocked.CompareExchange<PlatformComponent.Delegate21>(ref PlatformComponent.delegate21_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x00255504 File Offset: 0x00253704
		public virtual void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("PlatformComponent");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (hashSet_0.Contains(base.GetGuid()))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(base.GetGuid());
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Status";
					byte componentStatus = (byte)this.m_ComponentStatus;
					xmlWriter.WriteElementString(localName, componentStatus.ToString());
					xmlWriter_0.WriteElementString("Name", this.Name);
					xmlWriter_0.WriteElementString("ParentPlatform", this.m_ParentPlatform.GetGuid());
					xmlWriter_0.WriteElementString("DS", Conversions.ToString((int)this.GetDamageSeverity()));
					if (this.GetDamageSeverity() != PlatformComponent._DamageSeverityFactor.Light)
					{
						xmlWriter_0.WriteElementString("DamageSeverity", ((byte)this.GetDamageSeverity()).ToString());
					}
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100684", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060056B6 RID: 22198 RVA: 0x00027970 File Offset: 0x00025B70
		protected PlatformComponent()
		{
			this.coverageArc = default(PlatformComponent._CoverageArc);
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x00027984 File Offset: 0x00025B84
		public bool IsMount()
		{
			return base.GetType() == typeof(Mount);
		}

		// Token: 0x060056B8 RID: 22200 RVA: 0x0002799B File Offset: 0x00025B9B
		public bool IsMagazine()
		{
			return base.GetType() == typeof(Magazine);
		}

		// Token: 0x060056B9 RID: 22201 RVA: 0x000279B2 File Offset: 0x00025BB2
		public bool IsSensor()
		{
			return base.GetType() == typeof(Sensor);
		}

		// Token: 0x060056BA RID: 22202 RVA: 0x000279C9 File Offset: 0x00025BC9
		public bool IsAirFacility()
		{
			return base.GetType() == typeof(AirFacility);
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x000279E0 File Offset: 0x00025BE0
		public bool IsCommDevice()
		{
			return base.GetType() == typeof(CommDevice);
		}

		// Token: 0x060056BC RID: 22204 RVA: 0x000279F7 File Offset: 0x00025BF7
		public bool IsEngine()
		{
			return base.GetType() == typeof(Engine);
		}

		// Token: 0x060056BD RID: 22205 RVA: 0x00027A0E File Offset: 0x00025C0E
		public bool IsCargo()
		{
			return base.GetType() == typeof(Cargo);
		}

		// Token: 0x060056BE RID: 22206 RVA: 0x00027A25 File Offset: 0x00025C25
		public bool IsCIC()
		{
			return base.GetType() == typeof(CIC);
		}

		// Token: 0x060056BF RID: 22207 RVA: 0x00255638 File Offset: 0x00253838
		public PlatformComponent._DamageSeverityFactor GetDamageSeverity()
		{
			return this.DamageSeverity;
		}

		// Token: 0x060056C0 RID: 22208 RVA: 0x00027A3C File Offset: 0x00025C3C
		public void SetDamageSeverity(PlatformComponent._DamageSeverityFactor _DamageSeverityFactor_1)
		{
			this.DamageSeverity = _DamageSeverityFactor_1;
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x00255650 File Offset: 0x00253850
		public ActiveUnit GetParentPlatform()
		{
			return this.m_ParentPlatform;
		}

		// Token: 0x060056C2 RID: 22210 RVA: 0x00027A45 File Offset: 0x00025C45
		public void SetParentPlatform(ActiveUnit activeUnit_1)
		{
			this.m_ParentPlatform = activeUnit_1;
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x00255668 File Offset: 0x00253868
		public virtual string CheckPlatformStatus()
		{
			return "None";
		}

		// Token: 0x060056C4 RID: 22212 RVA: 0x0025567C File Offset: 0x0025387C
		public bool IsTargetInCoverageArc(Unit theTarget, float? CustomParentHeading = null)
		{
			bool result = false;
			try
			{
				if (Information.IsNothing(this.GetParentPlatform()))
				{
					result = false;
				}
				else
				{
					double num;
					if (Information.IsNothing(CustomParentHeading))
					{
						num = (double)this.GetParentPlatform().GetCurrentHeading();
					}
					else
					{
						num = (double)CustomParentHeading.Value;
					}
					double num2 = Math2.Normalize((double)Math2.GetAzimuth(this.GetParentPlatform().GetLatitude(null), this.GetParentPlatform().GetLongitude(null), theTarget.GetLatitude(null), theTarget.GetLongitude(null)) - num);
					if (num2 <= 22.5)
					{
						result = this.coverageArc.SB1;
					}
					else if (num2 <= 45.0)
					{
						result = this.coverageArc.SB2;
					}
					else if (num2 <= 67.5)
					{
						result = this.coverageArc.SMF1;
					}
					else if (num2 <= 90.0)
					{
						result = this.coverageArc.SMF2;
					}
					else if (num2 <= 112.5)
					{
						result = this.coverageArc.SMA1;
					}
					else if (num2 <= 135.0)
					{
						result = this.coverageArc.SMA2;
					}
					else if (num2 <= 157.5)
					{
						result = this.coverageArc.SS1;
					}
					else if (num2 <= 180.0)
					{
						result = this.coverageArc.SS2;
					}
					else if (num2 <= 202.5)
					{
						result = this.coverageArc.PS1;
					}
					else if (num2 <= 225.0)
					{
						result = this.coverageArc.PS2;
					}
					else if (num2 <= 247.5)
					{
						result = this.coverageArc.PMA1;
					}
					else if (num2 <= 270.0)
					{
						result = this.coverageArc.PMA2;
					}
					else if (num2 <= 292.5)
					{
						result = this.coverageArc.PMF1;
					}
					else if (num2 <= 315.0)
					{
						result = this.coverageArc.PMF2;
					}
					else if (num2 <= 337.5)
					{
						result = this.coverageArc.PB1;
					}
					else
					{
						result = this.coverageArc.PB2;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100685", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x00255958 File Offset: 0x00253B58
		public virtual PlatformComponent._ComponentStatus GetComponentStatus()
		{
			return this.m_ComponentStatus;
		}

		// Token: 0x060056C6 RID: 22214 RVA: 0x00027A4E File Offset: 0x00025C4E
		public PlatformComponent(ActiveUnit activeUnit_1)
		{
			this.coverageArc = default(PlatformComponent._CoverageArc);
			this.SetParentPlatform(activeUnit_1);
		}

		// Token: 0x060056C7 RID: 22215 RVA: 0x00255970 File Offset: 0x00253B70
		public void method_24()
		{
			PlatformComponent.Delegate21 @delegate = PlatformComponent.delegate21_0;
			if (@delegate != null)
			{
				@delegate(this);
			}
		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x00255990 File Offset: 0x00253B90
		public virtual void BeDestroyed(Side side_, bool bool_8, bool bool_9)
		{
			try
			{
				this.m_ComponentStatus = PlatformComponent._ComponentStatus.Destroyed;
				if (!Information.IsNothing(this.GetParentPlatform()) && this.GetParentPlatform().IsFacility && !this.GetParentPlatform().IsNotActive() && ((Facility)this.GetParentPlatform()).MountsAreAimpoints && !bool_8 && !Information.IsNothing(this.GetParentPlatform().m_Mounts) && this.GetParentPlatform().m_Mounts.Where(PlatformComponent.DestroyedMountFilterFunc).Count<Mount>() == this.GetParentPlatform().m_Mounts.Length && !Information.IsNothing(this.GetParentPlatform().m_Scenario))
				{
					this.GetParentPlatform().m_Scenario.RemoveUnit(this.GetParentPlatform());
				}
				PlatformComponent.Delegate21 @delegate = PlatformComponent.delegate21_0;
				if (@delegate != null)
				{
					@delegate(this);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100686", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060056C9 RID: 22217 RVA: 0x00255AA8 File Offset: 0x00253CA8
		public virtual void vmethod_8()
		{
			this.m_ComponentStatus = PlatformComponent._ComponentStatus.Operational;
			PlatformComponent.Delegate21 @delegate = PlatformComponent.delegate21_0;
			if (@delegate != null)
			{
				@delegate(this);
			}
		}

		// Token: 0x060056CA RID: 22218 RVA: 0x00255AD0 File Offset: 0x00253CD0
		public virtual void StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor _DamageSeverityFactor_1)
		{
			this.m_ComponentStatus = PlatformComponent._ComponentStatus.Damaged;
			this.DamageSeverity = _DamageSeverityFactor_1;
			PlatformComponent.Delegate21 @delegate = PlatformComponent.delegate21_0;
			if (@delegate != null)
			{
				@delegate(this);
			}
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x00255B00 File Offset: 0x00253D00
		public void method_25(bool bool_8)
		{
			this.m_ComponentStatus = PlatformComponent._ComponentStatus.Operational;
			if (bool_8 && base.GetType() == typeof(AirFacility))
			{
				Interaction.MsgBox("A runway or pad's effective ability to host aircraft depends on its parent platform's integrity, i.e. the amount of damage sustained. Setting the component operational will not improve the aircraft capacity.", MsgBoxStyle.OkOnly, null);
			}
			PlatformComponent.Delegate21 @delegate = PlatformComponent.delegate21_0;
			if (@delegate != null)
			{
				@delegate(this);
			}
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public virtual void DamageAssessment(float float_0)
		{
		}

		// Token: 0x04002A9F RID: 10911
		public static Func<Mount, bool> DestroyedMountFilterFunc = (Mount mount_0) => !Information.IsNothing(mount_0) && mount_0.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x04002AA0 RID: 10912
		protected PlatformComponent._ComponentStatus m_ComponentStatus;

		// Token: 0x04002AA1 RID: 10913
		protected ActiveUnit m_ParentPlatform;

		// Token: 0x04002AA2 RID: 10914
		private PlatformComponent._DamageSeverityFactor DamageSeverity;

		// Token: 0x04002AA3 RID: 10915
		public PlatformComponent._CoverageArc coverageArc;

		// Token: 0x04002AA4 RID: 10916
		public int DBID;

		// Token: 0x04002AA5 RID: 10917
		[CompilerGenerated]
		private static PlatformComponent.Delegate21 delegate21_0;

		// Token: 0x02000AB0 RID: 2736
		// (Invoke) Token: 0x060056D0 RID: 22224
		public delegate void Delegate21(PlatformComponent theComponent);

		// Token: 0x02000AB1 RID: 2737
		public enum _ComponentStatus : byte
		{
			// Token: 0x04002AA8 RID: 10920
			Operational,
			// Token: 0x04002AA9 RID: 10921
			Damaged,
			// Token: 0x04002AAA RID: 10922
			Destroyed
		}

		// Token: 0x02000AB2 RID: 2738
		public enum _DamageSeverityFactor : byte
		{
			// Token: 0x04002AAC RID: 10924
			Light,
			// Token: 0x04002AAD RID: 10925
			Medium,
			// Token: 0x04002AAE RID: 10926
			Heavy
		}

		// Token: 0x02000AB3 RID: 2739
		public struct _CoverageArc
		{
			// Token: 0x060056D3 RID: 22227 RVA: 0x00255B54 File Offset: 0x00253D54
			public void Save(XmlWriter xmlWriter_0, bool Cov_Ill)
			{
				try
				{
					if (Cov_Ill)
					{
						xmlWriter_0.WriteStartElement("Cov_Ill");
					}
					else
					{
						xmlWriter_0.WriteStartElement("Cov");
					}
					if (this.Is360Coverage())
					{
						xmlWriter_0.WriteElementString("Seg", "360");
					}
					else
					{
						StringBuilder stringBuilder = new StringBuilder();
						if (this.PB1)
						{
							stringBuilder.Append("PB1,");
						}
						if (this.PB2)
						{
							stringBuilder.Append("PB2,");
						}
						if (this.PMA1)
						{
							stringBuilder.Append("PMA1,");
						}
						if (this.PMA2)
						{
							stringBuilder.Append("PMA2,");
						}
						if (this.PMF1)
						{
							stringBuilder.Append("PMF1,");
						}
						if (this.PMF2)
						{
							stringBuilder.Append("PMF2,");
						}
						if (this.PS1)
						{
							stringBuilder.Append("PS1,");
						}
						if (this.PS2)
						{
							stringBuilder.Append("PS2,");
						}
						if (this.SB1)
						{
							stringBuilder.Append("SB1,");
						}
						if (this.SB2)
						{
							stringBuilder.Append("SB2,");
						}
						if (this.SMA1)
						{
							stringBuilder.Append("SMA1,");
						}
						if (this.SMA2)
						{
							stringBuilder.Append("SMA2,");
						}
						if (this.SMF1)
						{
							stringBuilder.Append("SMF1,");
						}
						if (this.SMF2)
						{
							stringBuilder.Append("SMF2,");
						}
						if (this.SS1)
						{
							stringBuilder.Append("SS1,");
						}
						if (this.SS2)
						{
							stringBuilder.Append("SS2,");
						}
						xmlWriter_0.WriteElementString("Seg", stringBuilder.ToString());
					}
					xmlWriter_0.WriteEndElement();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100687", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}

			// Token: 0x060056D4 RID: 22228 RVA: 0x00255D88 File Offset: 0x00253F88
			public static PlatformComponent._CoverageArc SetCoverageIlluminate(ref XmlNode xmlNode_0)
			{
				PlatformComponent._CoverageArc result = default(PlatformComponent._CoverageArc);
				checked
				{
					try
					{
						PlatformComponent._CoverageArc coverageArc = default(PlatformComponent._CoverageArc);
						IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								XmlNode xmlNode = (XmlNode)enumerator.Current;
								string name = xmlNode.Name;
								uint num = Class382.smethod_0(name);
								if (num <= 3867991516u)
								{
									if (num <= 555814959u)
									{
										if (num != 431064838u)
										{
											if (num == 555814959u && Operators.CompareString(name, "StarboardMiddleForward", false) == 0)
											{
												coverageArc.SMF1 = Conversions.ToBoolean(xmlNode.InnerText);
												coverageArc.SMF2 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name, "Seg", false) != 0)
										{
											continue;
										}
									}
									else if (num != 2500017163u)
									{
										if (num != 2865575288u)
										{
											if (num == 3867991516u && Operators.CompareString(name, "PortStern", false) == 0)
											{
												coverageArc.PS1 = Conversions.ToBoolean(xmlNode.InnerText);
												coverageArc.PS2 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "PortMiddleForward", false) == 0)
											{
												coverageArc.PMF1 = Conversions.ToBoolean(xmlNode.InnerText);
												coverageArc.PMF2 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "StarboardStern", false) == 0)
										{
											coverageArc.SS1 = Conversions.ToBoolean(xmlNode.InnerText);
											coverageArc.SS2 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num <= 4068245167u)
								{
									if (num != 3997954474u)
									{
										if (num != 4068245167u || Operators.CompareString(name, "Segments", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "PortBow", false) == 0)
										{
											coverageArc.PB1 = Conversions.ToBoolean(xmlNode.InnerText);
											coverageArc.PB2 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 4096566348u)
								{
									if (num != 4117168363u)
									{
										if (num == 4155129661u && Operators.CompareString(name, "StarboardBow", false) == 0)
										{
											coverageArc.SB1 = Conversions.ToBoolean(xmlNode.InnerText);
											coverageArc.SB2 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "StarboardMiddleAft", false) == 0)
										{
											coverageArc.SMA1 = Conversions.ToBoolean(xmlNode.InnerText);
											coverageArc.SMA2 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "PortMiddleAft", false) == 0)
									{
										coverageArc.PMA1 = Conversions.ToBoolean(xmlNode.InnerText);
										coverageArc.PMA2 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								string[] array = xmlNode.InnerText.Split(new char[]
								{
									','
								});
								for (int i = 0; i < array.Length; i++)
								{
									string text = array[i];
									if (!string.IsNullOrEmpty(text))
									{
										string text2 = text.Trim();
										num = Class382.smethod_0(text2);
										if (num <= 2181607519u)
										{
											if (num <= 1604558652u)
											{
												if (num <= 1469204867u)
												{
													if (num != 3032978u)
													{
														if (num == 1469204867u && Operators.CompareString(text2, "PMF1", false) == 0)
														{
															coverageArc.PMF1 = true;
														}
													}
													else if (Operators.CompareString(text2, "PS2", false) == 0)
													{
														coverageArc.PS2 = true;
													}
												}
												else if (num != 1485982486u)
												{
													if (num == 1604558652u && Operators.CompareString(text2, "PMA1", false) == 0)
													{
														coverageArc.PMA1 = true;
													}
												}
												else if (Operators.CompareString(text2, "PMF2", false) == 0)
												{
													coverageArc.PMF2 = true;
												}
											}
											else if (num <= 1729738499u)
											{
												if (num != 1654891509u)
												{
													if (num == 1729738499u && Operators.CompareString(text2, "SS2", false) == 0)
													{
														coverageArc.SS2 = true;
													}
												}
												else if (Operators.CompareString(text2, "PMA2", false) == 0)
												{
													coverageArc.PMA2 = true;
												}
											}
											else if (num != 1746516118u)
											{
												if (num == 2181607519u && Operators.CompareString(text2, "PB2", false) == 0)
												{
													coverageArc.PB2 = true;
												}
											}
											else if (Operators.CompareString(text2, "SS1", false) == 0)
											{
												coverageArc.SS1 = true;
											}
										}
										else if (num <= 2859869279u)
										{
											if (num <= 2725501232u)
											{
												if (num != 2198385138u)
												{
													if (num == 2725501232u && Operators.CompareString(text2, "SMF1", false) == 0)
													{
														coverageArc.SMF1 = true;
													}
												}
												else if (Operators.CompareString(text2, "PB1", false) == 0)
												{
													coverageArc.PB1 = true;
												}
											}
											else if (num != 2775834089u)
											{
												if (num == 2859869279u && Operators.CompareString(text2, "SMA1", false) == 0)
												{
													coverageArc.SMA1 = true;
												}
											}
											else if (Operators.CompareString(text2, "SMF2", false) == 0)
											{
												coverageArc.SMF2 = true;
											}
										}
										else if (num <= 3512027844u)
										{
											if (num != 2876646898u)
											{
												if (num == 3512027844u && Operators.CompareString(text2, "360", false) == 0)
												{
													coverageArc.PB1 = true;
													coverageArc.PMA1 = true;
													coverageArc.PMF1 = true;
													coverageArc.PS1 = true;
													coverageArc.SB1 = true;
													coverageArc.SMA1 = true;
													coverageArc.SMF1 = true;
													coverageArc.SS1 = true;
													coverageArc.PB2 = true;
													coverageArc.PMA2 = true;
													coverageArc.PMF2 = true;
													coverageArc.PS2 = true;
													coverageArc.SB2 = true;
													coverageArc.SMA2 = true;
													coverageArc.SMF2 = true;
													coverageArc.SS2 = true;
													break;
												}
											}
											else if (Operators.CompareString(text2, "SMA2", false) == 0)
											{
												coverageArc.SMA2 = true;
											}
										}
										else if (num != 3824130755u)
										{
											if (num != 3840908374u)
											{
												if (num == 4281222655u && Operators.CompareString(text2, "PS1", false) == 0)
												{
													coverageArc.PS1 = true;
												}
											}
											else if (Operators.CompareString(text2, "SB2", false) == 0)
											{
												coverageArc.SB2 = true;
											}
										}
										else if (Operators.CompareString(text2, "SB1", false) == 0)
										{
											coverageArc.SB1 = true;
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
						result = coverageArc;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100688", "");
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

			// Token: 0x060056D5 RID: 22229 RVA: 0x002565C4 File Offset: 0x002547C4
			public bool Is360Coverage()
			{
				return this.PB1 && this.PB2 && this.PMA1 && this.PMA2 && this.PMF1 && this.PMF2 && this.PS1 && this.PS2 && this.SB1 && this.SB2 && this.SMA1 && this.SMA2 && this.SMF1 && this.SMF2 && this.SS1 && this.SS2;
			}

			// Token: 0x060056D6 RID: 22230 RVA: 0x00256654 File Offset: 0x00254854
			public bool HasSomeCoverage()
			{
				return this.PB1 || this.PB2 || this.PMA1 || this.PMA2 || this.PMF1 || this.PMF2 || this.PS1 || this.PS2 || this.SB1 || this.SB2 || this.SMA1 || this.SMA2 || this.SMF1 || this.SMF2 || this.SS1 || this.SS2;
			}

			// Token: 0x04002AAF RID: 10927
			public bool PS1;

			// Token: 0x04002AB0 RID: 10928
			public bool PMA1;

			// Token: 0x04002AB1 RID: 10929
			public bool PMF1;

			// Token: 0x04002AB2 RID: 10930
			public bool PB1;

			// Token: 0x04002AB3 RID: 10931
			public bool SS1;

			// Token: 0x04002AB4 RID: 10932
			public bool SMA1;

			// Token: 0x04002AB5 RID: 10933
			public bool SMF1;

			// Token: 0x04002AB6 RID: 10934
			public bool SB1;

			// Token: 0x04002AB7 RID: 10935
			public bool PS2;

			// Token: 0x04002AB8 RID: 10936
			public bool PMA2;

			// Token: 0x04002AB9 RID: 10937
			public bool PMF2;

			// Token: 0x04002ABA RID: 10938
			public bool PB2;

			// Token: 0x04002ABB RID: 10939
			public bool SS2;

			// Token: 0x04002ABC RID: 10940
			public bool SMA2;

			// Token: 0x04002ABD RID: 10941
			public bool SMF2;

			// Token: 0x04002ABE RID: 10942
			public bool SB2;
		}
	}
}
