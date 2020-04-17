using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace ns1
{
	// Token: 0x02000A6D RID: 2669
	public sealed class CargoMission : Mission
	{
		// Token: 0x06005478 RID: 21624 RVA: 0x0022FEC4 File Offset: 0x0022E0C4
		public CargoMission(Side side_0, Scenario scenario_0, string string_3, List<ReferencePoint> list_10, bool bool_15) : base(side_0, scenario_0)
		{
			this.AreaPoints = new List<ReferencePoint>();
			this.list_6 = new List<ReferencePoint>();
			this.list_7 = new List<ReferencePoint>();
			this.list_8 = new List<ReferencePoint>();
			this.list_9 = new List<ReferencePoint>();
			this.dictionary_MountsToUnload = new Dictionary<int, int>();
			this.MissionClass = Mission._MissionClass.Cargo;
			this.Name = string_3;
			this.AreaPoints = list_10;
			this.TransitAltitude_Aircraft = 609.600037f;
			this.StationAltitude_Aircraft = 304.800018f;
			this.TransitThrottle_Aircraft = ActiveUnit.Throttle.Cruise;
			this.StationThrottle_Aircraft = ActiveUnit.Throttle.Flank;
			this.TransitThrottle_Ship = ActiveUnit.Throttle.Cruise;
			this.StationThrottle_Ship = ActiveUnit.Throttle.Cruise;
			string prompt = "";
			if (bool_15 && !ActiveUnit_Navigator.smethod_6(ref this.AreaPoints, ref prompt, "", "Cargo Mission '" + this.Name + "'"))
			{
				Interaction.MsgBox(prompt, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x0022FFA4 File Offset: 0x0022E1A4
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("CargoMission");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Name", this.Name);
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "TransitThrottle_Aircraft";
				byte b = (byte)this.TransitThrottle_Aircraft;
				xmlWriter.WriteElementString(localName, b.ToString());
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "StationThrottle_Aircraft";
				b = (byte)this.StationThrottle_Aircraft;
				xmlWriter2.WriteElementString(localName2, b.ToString());
				xmlWriter_0.WriteElementString("TransitAltitude_Aircraft", this.TransitAltitude_Aircraft.ToString());
				xmlWriter_0.WriteElementString("StationAltitude_Aircraft", this.StationAltitude_Aircraft.ToString());
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "TransitThrottle_Ship";
				b = (byte)this.TransitThrottle_Ship;
				xmlWriter3.WriteElementString(localName3, b.ToString());
				XmlWriter xmlWriter4 = xmlWriter_0;
				string localName4 = "StationThrottle_Ship";
				b = (byte)this.StationThrottle_Ship;
				xmlWriter4.WriteElementString(localName4, b.ToString());
				this.m_Doctrine.Save(ref xmlWriter_0, ref scenario_0, "Doctrine");
				if (this.AreaPoints.Count > 0)
				{
					xmlWriter_0.WriteStartElement("Area");
					using (List<ReferencePoint>.Enumerator enumerator = this.AreaPoints.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.Flush();
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				xmlWriter_0.WriteElementString("SISIH", this.SISIH.ToString());
				xmlWriter_0.WriteStartElement("MountsToUnload");
				foreach (KeyValuePair<int, int> current in this.dictionary_MountsToUnload)
				{
					xmlWriter_0.WriteStartElement("Mount");
					xmlWriter_0.WriteAttributeString("DBID", current.Key.ToString());
					xmlWriter_0.WriteString(current.Value.ToString());
					xmlWriter_0.WriteEndElement();
				}
				xmlWriter_0.WriteEndElement();
				if (base.GetMissionStatus(scenario_0) != Mission._MissionStatus.Activation)
				{
					xmlWriter_0.WriteElementString("Status", ((byte)base.GetMissionStatus(scenario_0)).ToString());
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200654", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600547A RID: 21626 RVA: 0x00230268 File Offset: 0x0022E468
		private CargoMission(Side side_0, Scenario scenario_0) : base(side_0, scenario_0)
		{
			this.AreaPoints = new List<ReferencePoint>();
			this.list_6 = new List<ReferencePoint>();
			this.list_7 = new List<ReferencePoint>();
			this.list_8 = new List<ReferencePoint>();
			this.list_9 = new List<ReferencePoint>();
			this.dictionary_MountsToUnload = new Dictionary<int, int>();
			this.MissionClass = Mission._MissionClass.Cargo;
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x002302C8 File Offset: 0x0022E4C8
		public static CargoMission smethod_7(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_1, ref Scenario scenario_0)
		{
			CargoMission cargoMission = null;
			CargoMission result;
			try
			{
				CargoMission cargoMission2 = new CargoMission(null, scenario_0);
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1165144998u)
						{
							if (num <= 461095311u)
							{
								if (num != 6222351u)
								{
									if (num != 266367750u)
									{
										if (num == 461095311u && Operators.CompareString(name, "SISIH", false) == 0)
										{
											cargoMission2.SISIH = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Name", false) == 0)
										{
											cargoMission2.Name = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "Status", false) == 0)
									{
										cargoMission2.SetMissionStatus(scenario_0, (Mission._MissionStatus)Conversions.ToByte(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num != 498456164u)
							{
								if (num != 726807327u)
								{
									if (num == 1165144998u && Operators.CompareString(name, "StationThrottle_Ship", false) == 0)
									{
										cargoMission2.StationThrottle_Ship = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TransitThrottle_Ship", false) == 0)
									{
										cargoMission2.TransitThrottle_Ship = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Area", false) != 0)
								{
									continue;
								}
								IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
										cargoMission2.AreaPoints.Add(ReferencePoint.Load(ref xmlNode2, ref dictionary_1));
									}
									continue;
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
						if (num <= 2446123945u)
						{
							if (num != 1422437055u)
							{
								if (num != 1458105184u)
								{
									if (num != 2446123945u || Operators.CompareString(name, "MountsToUnload", false) != 0)
									{
										continue;
									}
									IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator3.MoveNext())
										{
											XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
											cargoMission2.dictionary_MountsToUnload[int.Parse(xmlNode3.Attributes.GetNamedItem("DBID").Value)] = int.Parse(xmlNode3.InnerText);
										}
										continue;
									}
									finally
									{
										if (enumerator3 is IDisposable)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
								}
								if (Operators.CompareString(name, "ID", false) == 0)
								{
									if (dictionary_1.ContainsKey(xmlNode.InnerText))
									{
										cargoMission = (CargoMission)dictionary_1[xmlNode.InnerText];
										result = cargoMission;
										return result;
									}
									cargoMission2.SetGuid(xmlNode.InnerText);
									dictionary_1.Add(cargoMission2.GetGuid(), cargoMission2);
								}
							}
							else if (Operators.CompareString(name, "Doctrine", false) == 0)
							{
								cargoMission2.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode, cargoMission2);
							}
						}
						else if (num <= 3753944794u)
						{
							if (num != 3753185556u)
							{
								if (num == 3753944794u && Operators.CompareString(name, "StationThrottle_Aircraft", false) == 0)
								{
									cargoMission2.StationThrottle_Aircraft = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
								}
							}
							else if (Operators.CompareString(name, "StationAltitude_Aircraft", false) == 0)
							{
								cargoMission2.StationAltitude_Aircraft = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
							}
						}
						else if (num != 3849994837u)
						{
							if (num == 4236299283u && Operators.CompareString(name, "TransitThrottle_Aircraft", false) == 0)
							{
								cargoMission2.TransitThrottle_Aircraft = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
							}
						}
						else if (Operators.CompareString(name, "TransitAltitude_Aircraft", false) == 0)
						{
							cargoMission2.TransitAltitude_Aircraft = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
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
				if (cargoMission2.TransitThrottle_Aircraft == ActiveUnit.Throttle.FullStop)
				{
					cargoMission2.TransitThrottle_Aircraft = ActiveUnit.Throttle.Cruise;
				}
				if (cargoMission2.StationThrottle_Aircraft == ActiveUnit.Throttle.FullStop)
				{
					cargoMission2.StationThrottle_Aircraft = ActiveUnit.Throttle.Cruise;
				}
				if (cargoMission2.TransitThrottle_Ship == ActiveUnit.Throttle.FullStop)
				{
					cargoMission2.TransitThrottle_Ship = ActiveUnit.Throttle.Cruise;
				}
				if (cargoMission2.StationThrottle_Ship == ActiveUnit.Throttle.FullStop)
				{
					cargoMission2.StationThrottle_Ship = ActiveUnit.Throttle.Cruise;
				}
				cargoMission = cargoMission2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200656", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = cargoMission;
			return result;
		}

		// Token: 0x0400289E RID: 10398
		public List<ReferencePoint> AreaPoints;

		// Token: 0x0400289F RID: 10399
		public List<ReferencePoint> list_6;

		// Token: 0x040028A0 RID: 10400
		public List<ReferencePoint> list_7;

		// Token: 0x040028A1 RID: 10401
		public List<ReferencePoint> list_8;

		// Token: 0x040028A2 RID: 10402
		public List<ReferencePoint> list_9;

		// Token: 0x040028A3 RID: 10403
		public Dictionary<int, int> dictionary_MountsToUnload;

		// Token: 0x040028A4 RID: 10404
		public float TransitAltitude_Aircraft;

		// Token: 0x040028A5 RID: 10405
		public float StationAltitude_Aircraft;

		// Token: 0x040028A6 RID: 10406
		public ActiveUnit.Throttle TransitThrottle_Aircraft;

		// Token: 0x040028A7 RID: 10407
		public ActiveUnit.Throttle StationThrottle_Aircraft;

		// Token: 0x040028A8 RID: 10408
		public ActiveUnit.Throttle TransitThrottle_Ship;

		// Token: 0x040028A9 RID: 10409
		public ActiveUnit.Throttle StationThrottle_Ship;
	}
}
