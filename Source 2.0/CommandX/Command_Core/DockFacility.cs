using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace Command_Core
{
	// Token: 0x02000AB4 RID: 2740
	public sealed class DockFacility : PlatformComponent
	{
		// Token: 0x060056D7 RID: 22231 RVA: 0x002566E4 File Offset: 0x002548E4
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("DockFacility");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
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
					xmlWriter_0.WriteElementString("DamageSeverity", ((byte)base.GetDamageSeverity()).ToString());
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100664", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x002567E4 File Offset: 0x002549E4
		public static DockFacility Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			DockFacility result;
			try
			{
				XmlNode xmlNode = Misc.smethod_48(xmlNode_0.ChildNodes, "DBID");
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					result = (DockFacility)dictionary_0[innerText];
				}
				else
				{
					int facilityDBID = Conversions.ToInteger(xmlNode.InnerText);
					SQLiteConnection sQLiteConnection = scenario_0.GetSQLiteConnection();
					DockFacility dockFacility = DBFunctions.LoadDockingFacilityDataTable(facilityDBID, ref sQLiteConnection, null);
					if (dictionary_0.ContainsKey(innerText))
					{
						result = (DockFacility)dictionary_0[innerText];
					}
					else
					{
						dockFacility.SetGuid(innerText);
						dictionary_0.Add(dockFacility.GetGuid(), dockFacility);
						IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								XmlNode xmlNode2 = (XmlNode)enumerator.Current;
								string name = xmlNode2.Name;
								if (Operators.CompareString(name, "Status", false) != 0)
								{
									if (Operators.CompareString(name, "DamageSeverity", false) == 0)
									{
										dockFacility.SetDamageSeverity((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode2.InnerText));
									}
								}
								else
								{
									string innerText2 = xmlNode2.InnerText;
									if (Operators.CompareString(innerText2, "Operational", false) != 0)
									{
										if (Operators.CompareString(innerText2, "Damaged", false) != 0)
										{
											if (Operators.CompareString(innerText2, "Destroyed", false) != 0)
											{
												dockFacility.m_ComponentStatus = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode2.InnerText);
											}
											else
											{
												dockFacility.m_ComponentStatus = PlatformComponent._ComponentStatus.Destroyed;
											}
										}
										else
										{
											dockFacility.m_ComponentStatus = PlatformComponent._ComponentStatus.Damaged;
										}
									}
									else
									{
										dockFacility.m_ComponentStatus = PlatformComponent._ComponentStatus.Operational;
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
						result = dockFacility;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100665", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x00027AA3 File Offset: 0x00025CA3
		public DockFacility(ActiveUnit activeUnit_1, string strName, DockFacility._DockFacilityType Type_, DockFacility._DockFacilityPhysicalSizeCode PhysicalSizeCode_, byte Capacity_) : base(activeUnit_1)
		{
			this.LazyDockedUnitsDictionary = new Lazy<ConcurrentDictionary<string, ActiveUnit>>();
			this.Name = strName;
			this.Type = Type_;
			this.PhysicalSizeCode = PhysicalSizeCode_;
			this.Capacity = Capacity_;
		}

		// Token: 0x060056DA RID: 22234 RVA: 0x00256A18 File Offset: 0x00254C18
		public bool method_26()
		{
			DockFacility._DockFacilityType type = this.Type;
			return type != DockFacility._DockFacilityType.DockWell && type != DockFacility._DockFacilityType.DryDockShelter;
		}

		// Token: 0x060056DB RID: 22235 RVA: 0x00256A48 File Offset: 0x00254C48
		public bool IsPier()
		{
			DockFacility._DockFacilityPhysicalSizeCode physicalSizeCode = this.PhysicalSizeCode;
			return physicalSizeCode - DockFacility._DockFacilityPhysicalSizeCode.VerySmallPier <= 5;
		}

		// Token: 0x060056DC RID: 22236 RVA: 0x00256A6C File Offset: 0x00254C6C
		public bool method_28(short platformLength, DockFacility._DockFacilityPhysicalSizeCode PhysicalSizeCode_)
		{
			bool result;
			if (this.IsPier())
			{
				result = this.IsLargeEnoughFor((float)platformLength);
			}
			else
			{
				result = (ActiveUnit_DockingOps.smethod_5(PhysicalSizeCode_) && this.IsLargeEnoughFor((float)platformLength));
			}
			return result;
		}

		// Token: 0x060056DD RID: 22237 RVA: 0x00256AA8 File Offset: 0x00254CA8
		public override void BeDestroyed(Side side_0, bool bool_8, bool bool_9)
		{
			try
			{
				if (!this.LazyDockedUnitsDictionary.Value.IsEmpty)
				{
					foreach (ActiveUnit current in this.LazyDockedUnitsDictionary.Value.Values)
					{
						current.m_Scenario.RemoveUnit(current);
					}
				}
				base.BeDestroyed(side_0, bool_8, bool_9);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100666", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060056DE RID: 22238 RVA: 0x00256B70 File Offset: 0x00254D70
		public override void StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor DamageSeverityFactor_)
		{
			try
			{
				int num = 0;
				if (!this.LazyDockedUnitsDictionary.Value.IsEmpty)
				{
					switch (DamageSeverityFactor_)
					{
					case PlatformComponent._DamageSeverityFactor.Light:
						num = (int)Math.Round((double)this.LazyDockedUnitsDictionary.Value.Count / 3.0);
						break;
					case PlatformComponent._DamageSeverityFactor.Medium:
						num = (int)Math.Round((double)this.LazyDockedUnitsDictionary.Value.Count / 2.0);
						break;
					case PlatformComponent._DamageSeverityFactor.Heavy:
						num = (int)Math.Round((double)(2 * this.LazyDockedUnitsDictionary.Value.Count) / 3.0);
						break;
					}
				}
				int num2 = 0;
				foreach (ActiveUnit current in this.LazyDockedUnitsDictionary.Value.Values)
				{
					string text = "";
					if (Operators.CompareString(current.Name, current.UnitClass, false) != 0)
					{
						text = " (" + current.UnitClass + ")";
					}
					base.GetParentPlatform().LogMessage(string.Concat(new string[]
					{
						current.Name,
						text,
						" was hosted in ",
						this.Name,
						"已被摧毁!"
					}), LoggedMessage.MessageType.UnitLost, 2, false, new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
					current.m_Scenario.RemoveUnit(current);
					num2++;
					if (num2 == num)
					{
						break;
					}
				}
				base.StopIlluminateAndTurnOff(DamageSeverityFactor_);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100667", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060056DF RID: 22239 RVA: 0x00256DA0 File Offset: 0x00254FA0
		private bool IsLargeEnoughFor(float platformLength_)
		{
			int physicalSize = this.GetPhysicalSize();
			return platformLength_ <= (float)physicalSize && (float)this.GetPhysicalSizeAvaible() >= platformLength_;
		}

		// Token: 0x060056E0 RID: 22240 RVA: 0x00256DCC File Offset: 0x00254FCC
		public int GetPhysicalSize()
		{
			DockFacility._DockFacilityPhysicalSizeCode physicalSizeCode = this.PhysicalSizeCode;
			int result;
			if (physicalSizeCode <= DockFacility._DockFacilityPhysicalSizeCode.ExtraLargePier)
			{
				if (physicalSizeCode == DockFacility._DockFacilityPhysicalSizeCode.None)
				{
					result = 0;
					return result;
				}
				switch (physicalSizeCode)
				{
				case DockFacility._DockFacilityPhysicalSizeCode.VerySmallPier:
					result = 11;
					return result;
				case DockFacility._DockFacilityPhysicalSizeCode.MediumPier:
					result = 25;
					return result;
				case DockFacility._DockFacilityPhysicalSizeCode.LargePier:
					result = 45;
					return result;
				case DockFacility._DockFacilityPhysicalSizeCode.VeryLargePier:
					result = 200;
					return result;
				case DockFacility._DockFacilityPhysicalSizeCode.ExtraLargePier:
					result = 500;
					return result;
				}
			}
			else
			{
				switch (physicalSizeCode)
				{
				case DockFacility._DockFacilityPhysicalSizeCode.VerySmallDock_Davit:
					result = 11;
					return result;
				case DockFacility._DockFacilityPhysicalSizeCode.SmallDock_Davit:
					result = 17;
					return result;
				case DockFacility._DockFacilityPhysicalSizeCode.MediumDock:
					result = 25;
					return result;
				case DockFacility._DockFacilityPhysicalSizeCode.LargeDock:
					result = 45;
					return result;
				default:
					if (physicalSizeCode == DockFacility._DockFacilityPhysicalSizeCode.DryDeckShelter)
					{
						result = 20;
						return result;
					}
					if (physicalSizeCode == DockFacility._DockFacilityPhysicalSizeCode.ROV_UUV)
					{
						result = 10;
						return result;
					}
					break;
				}
			}
			result = 0;
			return result;
		}

		// Token: 0x060056E1 RID: 22241 RVA: 0x00256EA0 File Offset: 0x002550A0
		public int GetPhysicalSizeAvaible()
		{
			int result = 0;
			try
			{
				int num = this.GetPhysicalSize() * (int)this.Capacity;
				int num2 = 0;
				foreach (ActiveUnit current in this.LazyDockedUnitsDictionary.Value.Values)
				{
					if (current.IsShip)
					{
						num2 = (int)Math.Round((double)((float)num2 + ((Ship)current).Length));
					}
					else
					{
						if (!current.IsSubmarine)
						{
							throw new NotImplementedException();
						}
						num2 = (int)Math.Round((double)((float)num2 + ((Submarine)current).Length));
					}
				}
				result = num - num2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100668", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04002ABF RID: 10943
		public DockFacility._DockFacilityPhysicalSizeCode PhysicalSizeCode;

		// Token: 0x04002AC0 RID: 10944
		public DockFacility._DockFacilityType Type;

		// Token: 0x04002AC1 RID: 10945
		public byte Capacity;

		// Token: 0x04002AC2 RID: 10946
		public Lazy<ConcurrentDictionary<string, ActiveUnit>> LazyDockedUnitsDictionary;

		// Token: 0x02000AB5 RID: 2741
		public enum _DockFacilityType : short
		{
			// Token: 0x04002AC4 RID: 10948
			None = 1001,
			// Token: 0x04002AC5 RID: 10949
			DockWell = 2001,
			// Token: 0x04002AC6 RID: 10950
			Davit = 3001,
			// Token: 0x04002AC7 RID: 10951
			DryDockShelter = 4001,
			// Token: 0x04002AC8 RID: 10952
			ROV_UUV_Davit_Crane_Shelter = 5001,
			// Token: 0x04002AC9 RID: 10953
			Pier = 9001
		}

		// Token: 0x02000AB6 RID: 2742
		public enum _DockFacilityPhysicalSizeCode : short
		{
			// Token: 0x04002ACB RID: 10955
			None = 1001,
			// Token: 0x04002ACC RID: 10956
			VerySmallPier = 2001,
			// Token: 0x04002ACD RID: 10957
			SmallPier,
			// Token: 0x04002ACE RID: 10958
			MediumPier,
			// Token: 0x04002ACF RID: 10959
			LargePier,
			// Token: 0x04002AD0 RID: 10960
			VeryLargePier,
			// Token: 0x04002AD1 RID: 10961
			ExtraLargePier,
			// Token: 0x04002AD2 RID: 10962
			VerySmallDock_Davit = 3001,
			// Token: 0x04002AD3 RID: 10963
			SmallDock_Davit,
			// Token: 0x04002AD4 RID: 10964
			MediumDock,
			// Token: 0x04002AD5 RID: 10965
			LargeDock,
			// Token: 0x04002AD6 RID: 10966
			DryDeckShelter = 4001,
			// Token: 0x04002AD7 RID: 10967
			ROV_UUV = 5001
		}
	}
}
