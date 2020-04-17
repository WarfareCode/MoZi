using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using ClipperLib;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns28;
using ns3;
using ns4;

namespace Command_Core
{
	// 目标
	public class Contact : Contact_Base
	{
		// Token: 0x060041C3 RID: 16835 RVA: 0x00179DD8 File Offset: 0x00177FD8
		[CompilerGenerated]
		internal  ObservableDictionary<int, EmissionContainer> GetEmissionContainerDictionary()
		{
			return this.EmissionContainerDictionary;
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x00179DF0 File Offset: 0x00177FF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetEmissionContainerDictionary(ObservableDictionary<int, EmissionContainer> observableDictionary_1)
		{
			INotifyDictionaryChanged<int, EmissionContainer>.DictionaryChangedEventHandler value = new INotifyDictionaryChanged<int, EmissionContainer>.DictionaryChangedEventHandler(this.EmissionContainerDictionary_DictionaryChanged);
			ObservableDictionary<int, EmissionContainer> emissionContainerDictionary = this.EmissionContainerDictionary;
			if (emissionContainerDictionary != null)
			{
				emissionContainerDictionary.DictionaryChanged -= value;
			}
			this.EmissionContainerDictionary = observableDictionary_1;
			emissionContainerDictionary = this.EmissionContainerDictionary;
			if (emissionContainerDictionary != null)
			{
				emissionContainerDictionary.DictionaryChanged += value;
			}
		}

		// 保存
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Contact");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (!Information.IsNothing(hashSet_0))
				{
					if (hashSet_0.Contains(base.GetGuid()))
					{
						xmlWriter_0.WriteEndElement();
						return;
					}
					hashSet_0.Add(base.GetGuid());
				}
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("CH", XmlConvert.ToString(this.GetCurrentHeading()));
				xmlWriter_0.WriteElementString("CS", XmlConvert.ToString(this.GetCurrentSpeed()));
				xmlWriter_0.WriteElementString("CA", XmlConvert.ToString(this.GetCurrentAltitude_ASL(false)));
				xmlWriter_0.WriteElementString("Lon", XmlConvert.ToString(this.GetLongitude(null)));
				xmlWriter_0.WriteElementString("Lat", XmlConvert.ToString(this.GetLatitude(null)));
				if (!string.IsNullOrEmpty(this.UnitClass))
				{
					xmlWriter_0.WriteElementString("UnitClass", this.UnitClass);
				}
				if (base.GetRangeSymbols().Count > 0)
				{
					xmlWriter_0.WriteStartElement("RangeSymbols");
					using (List<RangeSymbol>.Enumerator enumerator = base.GetRangeSymbols().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.Save(ref xmlWriter_0);
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (!Information.IsNothing(this.m_Side))
				{
					xmlWriter_0.WriteElementString("Side", this.m_Side.GetSideName());
				}
				if (!string.IsNullOrEmpty(this.Message))
				{
					xmlWriter_0.WriteElementString("Message", this.Message);
				}
				if (!Information.IsNothing(this.ActualUnit))
				{
					xmlWriter_0.WriteElementString("ActualUnitID", this.ActualUnit.GetGuid());
				}
				if (this.GetIsPreciselyLocatedOnThisPulse())
				{
					xmlWriter_0.WriteElementString("IPLOTP", this.GetIsPreciselyLocatedOnThisPulse().ToString());
				}
				xmlWriter_0.WriteElementString("RCTT", XmlConvert.ToString(this.GetRCTT()));
				xmlWriter_0.WriteElementString("RCTTP", XmlConvert.ToString(this.GetRCTTP()));
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "IDStatus";
				int num = (int)this.identificationStatus;
				xmlWriter.WriteElementString(localName, num.ToString());
				xmlWriter_0.WriteElementString("TSD", ((int)Math.Round((double)this.TSD)).ToString());
				xmlWriter_0.WriteElementString("TS_BDA", ((int)Math.Round((double)this.TS_BDA)).ToString());
				xmlWriter_0.WriteElementString("TS_Recon", ((int)Math.Round((double)this.TS_Recon)).ToString());
				if (this.SideIsKnown)
				{
					xmlWriter_0.WriteElementString("SIK", this.SideIsKnown.ToString());
				}
				if (this.InheritsSideStance)
				{
					xmlWriter_0.WriteElementString("ISS", this.InheritsSideStance.ToString());
				}
				if (this.SidePostureStanceDictionary.Count > 0)
				{
					xmlWriter_0.WriteStartElement("Stance");
					foreach (KeyValuePair<Side, Misc.PostureStance> current in this.SidePostureStanceDictionary)
					{
						xmlWriter_0.WriteElementString("Stance_" + current.Key.GetGuid(), ((int)current.Value).ToString());
						xmlWriter_0.Flush();
					}
					xmlWriter_0.WriteEndElement();
				}
				if (!Information.IsNothing(this.contactType))
				{
					XmlWriter xmlWriter2 = xmlWriter_0;
					string localName2 = "Type";
					num = (int)this.contactType;
					xmlWriter2.WriteElementString(localName2, num.ToString());
				}
				if (this.IsFilterOut)
				{
					xmlWriter_0.WriteElementString("IFO", this.IsFilterOut.ToString());
				}
				if (this.BattleDamageAssessment.HasValue)
				{
					xmlWriter_0.WriteElementString("BDA_Struct", ((byte)this.BattleDamageAssessment.Value).ToString());
				}
				if (this.BDA_Fire.HasValue)
				{
					xmlWriter_0.WriteElementString("BDA_Fire", ((byte)this.BDA_Fire.Value).ToString());
				}
				if (this.BDA_Flood.HasValue)
				{
					xmlWriter_0.WriteElementString("BDA_Flood", ((byte)this.BDA_Flood.Value).ToString());
				}
				if (this.Heading_Known)
				{
					xmlWriter_0.WriteElementString("H_Known", this.Heading_Known.ToString());
				}
				if (this.Speed_Known)
				{
					xmlWriter_0.WriteElementString("S_Known", this.Speed_Known.ToString());
				}
				if (this.Altitude_Known)
				{
					xmlWriter_0.WriteElementString("A_Known", this.Altitude_Known.ToString());
				}
				if (!Information.IsNothing(this.UncertaintyArea) && !Information.IsNothing(this.UncertaintyArea))
				{
					xmlWriter_0.WriteStartElement("UA");
					using (List<GeoPoint>.Enumerator enumerator3 = this.UncertaintyArea.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							enumerator3.Current.Save(ref xmlWriter_0, ref hashSet_0);
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				xmlWriter_0.WriteElementString("Age", XmlConvert.ToString(this.Age));
				xmlWriter_0.WriteElementString("HeldFor", XmlConvert.ToString(this.HeldFor));
				xmlWriter_0.WriteElementString("AInc", this.AInc.ToString());
				if (!Information.IsNothing(this.OriginalDetectorSide))
				{
					xmlWriter_0.WriteElementString("ODS", this.OriginalDetectorSide.GetSideName());
				}
				if (!Information.IsNothing(this.GetEmissionContainerObDictionary()) && this.HasEmissionContainer())
				{
					xmlWriter_0.WriteStartElement("DEm");
					foreach (KeyValuePair<int, EmissionContainer> current2 in this.GetEmissionContainerObDictionary())
					{
						xmlWriter_0.WriteElementString("Emission" + Conversions.ToString(current2.Key), current2.Value.ToString());
					}
					xmlWriter_0.WriteEndElement();
				}
				if (this.RadiationHostUnits.Count > 0)
				{
					xmlWriter_0.WriteStartElement("RHU");
					using (List<Contact.HostUnitOfRadarRadiation>.Enumerator enumerator5 = this.RadiationHostUnits.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.Save(ref xmlWriter_0);
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (!Information.IsNothing(this.TimeSinceDetection_Radar))
				{
					xmlWriter_0.WriteElementString("TimeSinceDetection_Radar", this.TimeSinceDetection_Radar.ToString());
				}
				if (!Information.IsNothing(this.TimeSinceDetection_ESM))
				{
					xmlWriter_0.WriteElementString("TimeSinceDetection_ESM", this.TimeSinceDetection_ESM.ToString());
				}
				if (!Information.IsNothing(this.TimeSinceDetection_Visual))
				{
					xmlWriter_0.WriteElementString("TimeSinceDetection_Visual", this.TimeSinceDetection_Visual.ToString());
				}
				if (!Information.IsNothing(this.TimeSinceDetection_Infrared))
				{
					xmlWriter_0.WriteElementString("TimeSinceDetection_Infrared", this.TimeSinceDetection_Infrared.ToString());
				}
				if (!Information.IsNothing(this.TimeSinceDetection_SonarActive))
				{
					xmlWriter_0.WriteElementString("TimeSinceDetection_SonarActive", this.TimeSinceDetection_SonarActive.ToString());
				}
				if (!Information.IsNothing(this.TimeSinceDetection_SonarPassive))
				{
					xmlWriter_0.WriteElementString("TimeSinceDetection_SonarPassive", this.TimeSinceDetection_SonarPassive.ToString());
				}
				if (this.SZC)
				{
					xmlWriter_0.WriteElementString("SZC", this.SZC.ToString());
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100477", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x0017A6D8 File Offset: 0x001788D8
		public static Contact GetContact(string string_7, ref Dictionary<string, Subject> dictionary_2)
		{
			Contact result = null;
			try
			{
				if (dictionary_2.ContainsKey(string_7))
				{
					result = (Contact)dictionary_2[string_7];
				}
				else
				{
					result = null;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100478", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// 载入
		public static Contact Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_2)
		{
			Contact contact = new Contact();
			Contact contact2 = null;
			Contact result;
			try
			{
				string arg_1E_0 = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num > 1938016866u)
						{
							if (num <= 2815008834u)
							{
								if (num <= 2395726140u)
								{
									if (num <= 2028919382u)
									{
										if (num != 1945347683u)
										{
											if (num != 2010780873u)
											{
												if (num != 2028919382u || Operators.CompareString(name, "RHU", false) != 0)
												{
													continue;
												}
												IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
												try
												{
													while (enumerator2.MoveNext())
													{
														Contact.HostUnitOfRadarRadiation item = Contact.HostUnitOfRadarRadiation.Load((XmlNode)enumerator2.Current);
														contact.RadiationHostUnits.Add(item);
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
											if (Operators.CompareString(name, "CA", false) == 0)
											{
												goto IL_873;
											}
											continue;
										}
										else if (Operators.CompareString(name, "UA", false) != 0)
										{
											continue;
										}
									}
									else if (num > 2128224206u)
									{
										if (num != 2183398782u)
										{
											if (num == 2395726140u && Operators.CompareString(name, "Age", false) == 0)
											{
												contact.Age = XmlConvert.ToSingle(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "TimeSinceDetection_SonarPassive", false) == 0)
											{
												contact.TimeSinceDetection_SonarPassive = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
												continue;
											}
											continue;
										}
									}
									else if (num != 2106523062u)
									{
										if (num != 2128224206u)
										{
											continue;
										}
										if (Operators.CompareString(name, "CH", false) != 0)
										{
											continue;
										}
										goto IL_7DD;
									}
									else if (Operators.CompareString(name, "UncertaintyArea", false) != 0)
									{
										continue;
									}
									if (xmlNode.ChildNodes.Count <= 0)
									{
										continue;
									}
									contact.SetUncertaintyArea(new List<GeoPoint>());
									IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator3.MoveNext())
										{
											XmlNode xmlNode2 = (XmlNode)enumerator3.Current;
											GeoPoint item2 = GeoPoint.Load(ref xmlNode2, ref dictionary_2);
											contact.GetUncertaintyArea().Add(item2);
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
								if (num <= 2564648390u)
								{
									if (num != 2461521368u)
									{
										if (num != 2496321123u)
										{
											if (num == 2564648390u && Operators.CompareString(name, "Lon", false) == 0)
											{
												goto IL_102D;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "RangeSymbols", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator4 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator4.MoveNext())
												{
													RangeSymbol item3 = RangeSymbol.Load((XmlNode)enumerator4.Current, dictionary_2);
													contact.GetRangeSymbols().Add(item3);
												}
												continue;
											}
											finally
											{
												if (enumerator4 is IDisposable)
												{
													(enumerator4 as IDisposable).Dispose();
												}
											}
										}
									}
									if (Operators.CompareString(name, "A_Known", false) == 0)
									{
										contact.Altitude_Known = true;
										continue;
									}
									continue;
								}
								else if (num <= 2690417586u)
								{
									if (num != 2590053246u)
									{
										if (num == 2690417586u && Operators.CompareString(name, "BDA_Struct", false) == 0)
										{
											contact.BattleDamageAssessment = new Contact._BattleDamageAssessment?((Contact._BattleDamageAssessment)Conversions.ToByte(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Side", false) == 0)
										{
											contact.strSideName = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num != 2704016193u)
								{
									if (num == 2815008834u && Operators.CompareString(name, "RCTT", false) == 0)
									{
										contact.SetRCTT(XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "BDA_Flood", false) == 0)
									{
										contact.BDA_Flood = new ActiveUnit_Damage.FloodingIntensityLevel?((ActiveUnit_Damage.FloodingIntensityLevel)Conversions.ToByte(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num <= 3215976043u)
							{
								if (num <= 2905192438u)
								{
									if (num != 2847628961u)
									{
										if (num != 2885753020u)
										{
											if (num == 2905192438u && Operators.CompareString(name, "S_Known", false) == 0)
											{
												contact.Speed_Known = true;
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "TS_Recon", false) == 0)
											{
												contact.TS_Recon = (float)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "SideIsKnown", false) == 0)
										{
											goto IL_EE6;
										}
										continue;
									}
								}
								else if (num <= 3001749054u)
								{
									if (num != 2920208772u)
									{
										if (num == 3001749054u && Operators.CompareString(name, "Lat", false) == 0)
										{
											goto IL_FE9;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Message", false) == 0)
										{
											contact.Message = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num != 3093760719u)
								{
									if (num == 3215976043u && Operators.CompareString(name, "IFO", false) == 0)
									{
										contact.IsFilterOut = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TimeSinceDetection_SonarActive", false) == 0)
									{
										contact.TimeSinceDetection_SonarActive = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									continue;
								}
							}
							else if (num <= 3429113205u)
							{
								if (num <= 3337381568u)
								{
									if (num != 3283119613u)
									{
										if (num == 3337381568u && Operators.CompareString(name, "AInc", false) == 0)
										{
											goto IL_EBB;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "CurrentSpeed", false) == 0)
										{
											goto IL_F43;
										}
										continue;
									}
								}
								else if (num != 3420705970u)
								{
									if (num == 3429113205u && Operators.CompareString(name, "IsPreciselyLocatedOnThisPulse", false) == 0)
									{
										goto IL_99C;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "ISS", false) == 0)
									{
										goto IL_F97;
									}
									continue;
								}
							}
							else if (num <= 3527340789u)
							{
								if (num != 3512062061u)
								{
									if (num == 3527340789u && Operators.CompareString(name, "HeldFor", false) == 0)
									{
										contact.HeldFor = XmlConvert.ToSingle(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Type", false) != 0)
									{
										continue;
									}
									if (Versioned.IsNumeric(xmlNode.InnerText))
									{
										contact.contactType = (Contact_Base.ContactType)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									contact.contactType = (Contact_Base.ContactType)Enum.Parse(typeof(Contact_Base.ContactType), xmlNode.InnerText, true);
									continue;
								}
							}
							else if (num != 3586924095u)
							{
								if (num != 4152621540u || Operators.CompareString(name, "CurrentHeading", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "OriginalDetectorSide", false) == 0)
								{
									goto IL_8C8;
								}
								continue;
							}
							IL_7DD:
							contact.SetCurrentHeading(XmlConvert.ToSingle(xmlNode.InnerText));
							continue;
						}
						if (num <= 998171479u)
						{
							if (num <= 687476049u)
							{
								if (num <= 441941816u)
								{
									if (num != 52089447u)
									{
										if (num != 266367750u)
										{
											if (num == 441941816u && Operators.CompareString(name, "CurrentAltitude", false) == 0)
											{
												goto IL_873;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Name", false) == 0)
											{
												contact.Name = xmlNode.InnerText;
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "ODS", false) == 0)
										{
											goto IL_8C8;
										}
										continue;
									}
								}
								else if (num <= 605605343u)
								{
									if (num != 585602087u)
									{
										if (num == 605605343u && Operators.CompareString(name, "H_Known", false) == 0)
										{
											contact.Heading_Known = true;
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "BDA_Fire", false) == 0)
										{
											contact.BDA_Fire = new ActiveUnit_Damage.FireIntensityLevel?((ActiveUnit_Damage.FireIntensityLevel)Conversions.ToByte(xmlNode.InnerText));
											continue;
										}
										continue;
									}
								}
								else if (num != 612623857u)
								{
									if (num != 687476049u)
									{
										continue;
									}
									if (Operators.CompareString(name, "TimeSinceDetection", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "IPLOTP", false) == 0)
									{
										goto IL_99C;
									}
									continue;
								}
							}
							else if (num <= 777780549u)
							{
								if (num != 755333778u)
								{
									if (num != 770528374u)
									{
										if (num != 777780549u || Operators.CompareString(name, "Stance", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator5 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator5.MoveNext())
											{
												XmlNode xmlNode3 = (XmlNode)enumerator5.Current;
												if (Operators.CompareString(xmlNode3.Name, "#text", false) == 0)
												{
													if (Versioned.IsNumeric(xmlNode.InnerText))
													{
														contact.m_PostureStance = new Misc.PostureStance?((Misc.PostureStance)Conversions.ToByte(xmlNode.InnerText));
													}
													else
													{
														contact.m_PostureStance = new Misc.PostureStance?((Misc.PostureStance)Enum.Parse(typeof(Misc.PostureStance), xmlNode.InnerText, true));
													}
												}
												else
												{
													string key = xmlNode3.Name.Split(new char[]
													{
														'_'
													})[1];
													Misc.PostureStance value = (Misc.PostureStance)Conversions.ToByte(xmlNode3.InnerText);
													contact.SideNamePostureStanceDictionary.Add(key, value);
												}
											}
											continue;
										}
										finally
										{
											if (enumerator5 is IDisposable)
											{
												(enumerator5 as IDisposable).Dispose();
											}
										}
									}
									if (Operators.CompareString(name, "TimeSinceDetection_Visual", false) == 0)
									{
										contact.TimeSinceDetection_Visual = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TimeSinceDetection_Radar", false) == 0)
									{
										contact.TimeSinceDetection_Radar = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									continue;
								}
							}
							else if (num <= 890166941u)
							{
								if (num != 879164502u)
								{
									if (num != 890166941u)
									{
										continue;
									}
									if (Operators.CompareString(name, "DEm", false) != 0)
									{
										continue;
									}
									goto IL_CF4;
								}
								else
								{
									if (Operators.CompareString(name, "RCTTP", false) == 0)
									{
										contact.SetRCTTP(XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num != 894866588u)
							{
								if (num == 998171479u && Operators.CompareString(name, "TimeSinceDetection_Infrared", false) == 0)
								{
									contact.TimeSinceDetection_Infrared = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "TSD", false) != 0)
							{
								continue;
							}
							contact.TSD = (float)Conversions.ToInteger(xmlNode.InnerText);
							continue;
						}
						if (num <= 1585573543u)
						{
							if (num <= 1397923717u)
							{
								if (num == 1130593022u)
								{
									goto IL_D95;
								}
								if (num == 1177209905u)
								{
									if (Operators.CompareString(name, "SZC", false) == 0)
									{
										contact.SZC = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else if (num != 1397923717u || Operators.CompareString(name, "DetectedEmissions", false) != 0)
								{
									continue;
								}
							}
							else if (num <= 1458105184u)
							{
								if (num != 1453604037u)
								{
									if (num != 1458105184u || Operators.CompareString(name, "ID", false) != 0)
									{
										continue;
									}
									if (dictionary_2.ContainsKey(xmlNode.InnerText))
									{
										contact2 = (Contact)dictionary_2[xmlNode.InnerText];
										result = contact2;
										return result;
									}
									if (xmlNode_0.ChildNodes.Count != 1)
									{
										contact.SetGuid(xmlNode.InnerText);
										dictionary_2.Add(contact.GetGuid(), contact);
										continue;
									}
									contact2 = null;
									result = contact2;
									return result;
								}
								else
								{
									if (Operators.CompareString(name, "TimeSinceDetection_ESM", false) == 0)
									{
										contact.TimeSinceDetection_ESM = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									continue;
								}
							}
							else if (num != 1577754190u)
							{
								if (num == 1585573543u && Operators.CompareString(name, "AutoIncrement", false) == 0)
								{
									goto IL_EBB;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "SIK", false) == 0)
								{
									goto IL_EE6;
								}
								continue;
							}
						}
						else if (num <= 1708783731u)
						{
							if (num != 1641540478u)
							{
								if (num != 1694424656u)
								{
									if (num == 1708783731u && Operators.CompareString(name, "CS", false) == 0)
									{
										goto IL_F43;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "ActualUnitID", false) == 0)
									{
										contact.string_6 = xmlNode.InnerText;
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "InheritsSideStance", false) == 0)
								{
									goto IL_F97;
								}
								continue;
							}
						}
						else if (num <= 1836990821u)
						{
							if (num != 1729717486u)
							{
								if (num == 1836990821u && Operators.CompareString(name, "Latitude", false) == 0)
								{
									goto IL_FE9;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Longitude", false) == 0)
								{
									goto IL_102D;
								}
								continue;
							}
						}
						else if (num != 1848783177u)
						{
							if (num != 1938016866u || Operators.CompareString(name, "IDStatus", false) != 0)
							{
								continue;
							}
							if (Versioned.IsNumeric(xmlNode.InnerText))
							{
								contact.identificationStatus = (Contact_Base.IdentificationStatus)Conversions.ToShort(xmlNode.InnerText);
								continue;
							}
							contact.identificationStatus = (Contact_Base.IdentificationStatus)Enum.Parse(typeof(Contact_Base.IdentificationStatus), xmlNode.InnerText, true);
							continue;
						}
						else
						{
							if (Operators.CompareString(name, "UnitClass", false) == 0)
							{
								contact.UnitClass = xmlNode.InnerText;
								continue;
							}
							continue;
						}
						IL_CF4:
						IEnumerator enumerator6 = xmlNode.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator6.MoveNext())
							{
								XmlNode xmlNode4 = (XmlNode)enumerator6.Current;
								int num2 = Conversions.ToInteger(xmlNode4.Name.Remove(0, 8));
								if (!contact.GetEmissionContainerObDictionary().ContainsKey(num2))
								{
									ObservableDictionary<int, EmissionContainer> emissionContainerObDictionary = contact.GetEmissionContainerObDictionary();
									int key2 = num2;
									XmlNode xmlNode5;
									string innerText = (xmlNode5 = xmlNode4).InnerText;
									EmissionContainer value2 = EmissionContainer.smethod_0(ref innerText);
									xmlNode5.InnerText = innerText;
									emissionContainerObDictionary.Add(key2, value2);
								}
							}
							continue;
						}
						finally
						{
							if (enumerator6 is IDisposable)
							{
								(enumerator6 as IDisposable).Dispose();
							}
						}
						IL_D95:
						if (Operators.CompareString(name, "TS_BDA", false) == 0)
						{
							contact.TS_BDA = (float)Conversions.ToInteger(xmlNode.InnerText);
							continue;
						}
						continue;
						IL_873:
						contact.SetAltitude_ASL(false, XmlConvert.ToSingle(xmlNode.InnerText));
						continue;
						IL_8C8:
						contact.OriginalDetectorSideName = xmlNode.InnerText;
						continue;
						IL_99C:
						contact.SetIsPreciselyLocatedOnThisPulse(Conversions.ToBoolean(xmlNode.InnerText));
						continue;
						IL_EBB:
						contact.AInc = Conversions.ToInteger(xmlNode.InnerText);
						continue;
						IL_EE6:
						contact.SideIsKnown = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_F43:
						contact.SetCurrentSpeed(XmlConvert.ToSingle(xmlNode.InnerText));
						continue;
						IL_F97:
						contact.InheritsSideStance = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_FE9:
						contact.SetLatitude(null, XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", ".")));
						continue;
						IL_102D:
						contact.SetLongitude(null, XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", ".")));
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				contact2 = contact;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100479", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = contact2;
			return result;
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x0017B98C File Offset: 0x00179B8C
		public void method_53(float elapsedTime, Scenario scenario_)
		{
			if (!Misc.smethod_15(this.lazy_1.Value))
			{
				this.lazy_1.Value.Clear();
			}
			if (!Information.IsNothing(this.ActualUnit))
			{
				this.LazyGuidedWeaponsInAirForMe = new Lazy<Weapon[]>(new Func<Weapon[]>(this.GetGuidedWeaponsInAirForMe));
				if (this.ActualUnit.m_Scenario.FifthMinuteIsChangingOnThisPulse)
				{
					this.bool_11 = false;
				}
			}
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x0017B9FC File Offset: 0x00179BFC
		public void method_54(float elapsedTime, Side side_, Scenario scenario_)
		{
			try
			{
				if (!Information.IsNothing(this.GetUncertaintyArea()))
				{
					List<GeoPoint> list = this.GetUncertaintyArea().ToList<GeoPoint>();
					foreach (GeoPoint current in list)
					{
						if (double.IsNaN(current.GetLatitude()) || double.IsNaN(current.GetLongitude()))
						{
							this.GetUncertaintyArea().Remove(current);
						}
					}
				}
				if (!Information.IsNothing(this.ActualUnit) && this.ActualUnit.IsFixedFacility() && this.GetIdentificationStatus() < Contact_Base.IdentificationStatus.PreciseID)
				{
					this.TargetIdentification(scenario_, side_, null, null, false, false, Contact_Base.IdentificationStatus.PreciseID);
				}
				if (scenario_.SecondIsChangingOnThisPulse)
				{
					this.SetUncertaintyArea(elapsedTime, side_, scenario_);
				}
				if (this.GetRCTT() > 0f && !Information.IsNothing(this.ActualUnit))
				{
					this.Age = 0f;
					Contact contact = this;
					ActiveUnit_Sensory.smethod_2(ref contact, this.ActualUnit, false, null);
				}
				if (this.Age == 0f)
				{
					this.HeldFor += elapsedTime;
				}
				this.LazyGuidedWeaponsInAirForMe = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200641", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x0017BBA8 File Offset: 0x00179DA8
		public void SetUncertaintyArea(float elapsedTime_, Side side_, Scenario scenario_)
		{
			if (!Information.IsNothing(this.ActualUnit))
			{
				if (!Information.IsNothing(this.GetUncertaintyArea()) && this.ActualUnit.IsAutoDetectable(side_))
				{
					this.SetUncertaintyArea(null);
				}
				else if (!Information.IsNothing(this.GetUncertaintyArea()))
				{
					this.float_12 -= elapsedTime_;
					if (this.float_12 <= 0f)
					{
						this.method_133((double)this.float_11, ref scenario_);
					}
					if (this.GetUncertaintyArea().Count == 0)
					{
						this.SetUncertaintyArea(null);
					}
				}
				else if (!this.GetIsPreciselyLocatedOnThisPulse() & this.GetRCTT() <= 0f)
				{
					this.method_133(1.0, ref scenario_);
				}
			}
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x0017BC78 File Offset: 0x00179E78
		public bool method_56(ref Scenario scenario_0, ref Dictionary<string, Subject> dictionary_2, ref Side side_2)
		{
			bool result = false;
			checked
			{
				try
				{
					if (!dictionary_2.ContainsKey(this.string_6))
					{
						result = false;
					}
					else
					{
						this.ActualUnit = (ActiveUnit)dictionary_2[this.string_6];
						Side[] sides = scenario_0.GetSides();
						for (int i = 0; i < sides.Length; i++)
						{
							Side side = sides[i];
							if (Operators.CompareString(side.GetSideName(), this.strSideName, false) == 0)
							{
								this.m_Side = side;
							}
							if (Operators.CompareString(side.GetSideName(), this.OriginalDetectorSideName, false) == 0)
							{
								this.OriginalDetectorSide = side;
							}
						}
						if (Information.IsNothing(this.m_PostureStance))
						{
							Misc.PostureStance value;
							if (!this.SideNamePostureStanceDictionary.TryGetValue(side_2.GetGuid(), out value))
							{
								goto IL_101;
							}
							Side key = Side.GetSideByContainsKey(side_2.GetGuid(), ref dictionary_2);
							try
							{
								this.SidePostureStanceDictionary.Add(key, value);
								goto IL_101;
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
								goto IL_101;
							}
						}
						this.SidePostureStanceDictionary.Add(side_2, this.m_PostureStance.Value);
						IL_101:
						result = true;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200023", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x0017BE04 File Offset: 0x0017A004
		private Contact()
		{
			this.SidePostureStanceDictionary = new Dictionary<Side, Misc.PostureStance>();
			this.SideNamePostureStanceDictionary = new Dictionary<string, Misc.PostureStance>();
			this.m_PostureStance = null;
			this.TSD = 0f;
			this.TS_BDA = 0f;
			this.TS_Recon = 0f;
			this.float_10 = 0f;
			this.LazyGuidedWeaponsInAirForMe = new Lazy<Weapon[]>();
			this.RadiationHostUnits = new List<Contact.HostUnitOfRadarRadiation>();
			this.list_3 = new List<GeoPoint>();
			this.list_4 = new List<GeoPoint>();
			this.list_5 = new List<GeoPoint>();
			this.InheritsSideStance = true;
			this.object_0 = RuntimeHelpers.GetObjectValue(new object());
			this.object_1 = RuntimeHelpers.GetObjectValue(new object());
			checked
			{
				if (!Information.IsNothing(this.ActualUnit))
				{
					Side[] sides = this.ActualUnit.m_Scenario.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						if (!Information.IsNothing(side) && side.GetContactList().Contains(this))
						{
							this.SidePostureStanceDictionary.Add(side, Misc.PostureStance.Unknown);
						}
					}
				}
			}
		}

		// Token: 0x060041CD RID: 16845 RVA: 0x0017BF20 File Offset: 0x0017A120
		public void UpdateContactOffGridInfo(Side side_, float elapsedTime_, Scenario scenario_)
		{
			if (!Information.IsNothing(this.OriginalDetectorSide) && Operators.CompareString(this.OriginalDetectorSide.GetGuid(), side_.GetGuid(), false) == 0)
			{
				this.SetRCTT(this.GetRCTT() - elapsedTime_);
				this.SetRCTTP(this.GetRCTTP() - elapsedTime_);
				this.TSD += elapsedTime_;
				if (!this.IsDestroyed(scenario_))
				{
					if (!Information.IsNothing(this.ActualUnit))
					{
						if (!this.ActualUnit.IsAutoDetectable(side_) && this.GetRCTT() <= 0f)
						{
							this.Age += elapsedTime_;
						}
						if (this.ActualUnit.IsAutoDetectable(side_))
						{
							this.TS_BDA += elapsedTime_;
						}
						if (this.GetEmissionContainerObDictionary().Count > 0)
						{
							this.float_10 += elapsedTime_;
						}
					}
					if (!Information.IsNothing(this.TimeSinceDetection_Radar))
					{
						float? num = this.TimeSinceDetection_Radar;
						this.TimeSinceDetection_Radar = (num.HasValue ? new float?(num.GetValueOrDefault() + elapsedTime_) : null);
					}
					if (!Information.IsNothing(this.TimeSinceDetection_ESM))
					{
						float? num = this.TimeSinceDetection_ESM;
						this.TimeSinceDetection_ESM = (num.HasValue ? new float?(num.GetValueOrDefault() + elapsedTime_) : null);
					}
					if (!Information.IsNothing(this.TimeSinceDetection_Visual))
					{
						float? num = this.TimeSinceDetection_Visual;
						this.TimeSinceDetection_Visual = (num.HasValue ? new float?(num.GetValueOrDefault() + elapsedTime_) : null);
					}
					if (!Information.IsNothing(this.TimeSinceDetection_Infrared))
					{
						float? num = this.TimeSinceDetection_Infrared;
						this.TimeSinceDetection_Infrared = (num.HasValue ? new float?(num.GetValueOrDefault() + elapsedTime_) : null);
					}
					if (!Information.IsNothing(this.TimeSinceDetection_SonarActive))
					{
						float? num = this.TimeSinceDetection_SonarActive;
						this.TimeSinceDetection_SonarActive = (num.HasValue ? new float?(num.GetValueOrDefault() + elapsedTime_) : null);
					}
					if (!Information.IsNothing(this.TimeSinceDetection_SonarPassive))
					{
						float? num = this.TimeSinceDetection_SonarPassive;
						this.TimeSinceDetection_SonarPassive = (num.HasValue ? new float?(num.GetValueOrDefault() + elapsedTime_) : null);
					}
					using (List<Contact.HostUnitOfRadarRadiation>.Enumerator enumerator = this.GetRadiationHostUnits(this.OriginalDetectorSide).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.RA += elapsedTime_;
						}
					}
				}
			}
		}

		// Token: 0x060041CE RID: 16846 RVA: 0x0017C1F8 File Offset: 0x0017A3F8
		public void method_58(ref Scenario scenario_)
		{
			if (this.Age < 60f)
			{
				this.float_12 = (float)GameGeneral.GetRandom().Next(5, 16);
			}
			else if (this.Age < 300f)
			{
				this.float_12 = 60f;
			}
			else if (this.Age < 7200f)
			{
				this.float_12 = 300f;
			}
			else
			{
				this.float_12 = 3600f;
			}
			if (scenario_.GetTimeCompression() > 0 && this.float_12 < (float)scenario_.GetTimeCompression())
			{
				this.float_12 = (float)scenario_.GetTimeCompression();
				if (scenario_.GetTimeCompression() < 5)
				{
					this.float_12 *= (float)GameGeneral.GetRandom().Next(2, 6);
				}
			}
			this.float_11 = this.float_12;
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x000214F4 File Offset: 0x0001F6F4
		public bool HasEmissionContainer()
		{
			return !Information.IsNothing(this.GetEmissionContainerDictionary()) && this.GetEmissionContainerDictionary().Count > 0;
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x0017C2DC File Offset: 0x0017A4DC
		public ObservableDictionary<int, EmissionContainer> GetEmissionContainerObDictionary()
		{
			if (Information.IsNothing(this.GetEmissionContainerDictionary()))
			{
				this.SetEmissionContainerDictionary(new ObservableDictionary<int, EmissionContainer>());
			}
			return this.GetEmissionContainerDictionary();
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x00021514 File Offset: 0x0001F714
		public void SetEmissionContainerObDictionary(ObservableDictionary<int, EmissionContainer> observableDictionary_1)
		{
			this.SetEmissionContainerDictionary(observableDictionary_1);
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x0017C30C File Offset: 0x0017A50C
		public List<int> method_62()
		{
			List<int> list;
			List<int> result;
			if (Information.IsNothing(this.ActualUnit))
			{
				list = new List<int>();
			}
			else
			{
				GlobalVariables.ActiveUnitType activeUnitType_;
				switch (this.contactType)
				{
				case Contact_Base.ContactType.Air:
					activeUnitType_ = GlobalVariables.ActiveUnitType.Aircraft;
					goto IL_75;
				case Contact_Base.ContactType.Missile:
				case Contact_Base.ContactType.Torpedo:
					activeUnitType_ = GlobalVariables.ActiveUnitType.Weapon;
					goto IL_75;
				case Contact_Base.ContactType.Surface:
					activeUnitType_ = GlobalVariables.ActiveUnitType.Ship;
					goto IL_75;
				case Contact_Base.ContactType.Submarine:
					activeUnitType_ = GlobalVariables.ActiveUnitType.Submarine;
					goto IL_75;
				case Contact_Base.ContactType.Orbital:
					activeUnitType_ = GlobalVariables.ActiveUnitType.Satellite;
					goto IL_75;
				case Contact_Base.ContactType.Facility_Fixed:
				case Contact_Base.ContactType.Facility_Mobile:
					activeUnitType_ = GlobalVariables.ActiveUnitType.Facility;
					goto IL_75;
				}
				list = new List<int>();
				result = list;
				return result;
				IL_75:
				List<int> list2 = new List<int>();
				foreach (int current in this.GetEmissionContainerObDictionary().Keys)
				{
					if (this.GetEmissionContainerObDictionary()[current].bool_1)
					{
						list2.Add(current);
					}
				}
				list = DBFunctions.smethod_10(list2, activeUnitType_, this.ActualUnit.m_Scenario, this.ActualUnit.m_Scenario.GetSQLiteConnection());
			}
			result = list;
			return result;
		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x0017C424 File Offset: 0x0017A624
		public bool IsBiologics()
		{
			bool flag;
			bool result;
			if (this.GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownType)
			{
				flag = false;
			}
			else if (Information.IsNothing(this.ActualUnit))
			{
				flag = false;
			}
			else
			{
				Contact_Base.ContactType contactType = this.contactType;
				if (contactType == Contact_Base.ContactType.Submarine && ((Submarine)this.ActualUnit).Type - Submarine._SubmarineType.Biologics <= 1)
				{
					result = true;
					return result;
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x0017C490 File Offset: 0x0017A690
		public List<Contact.HostUnitOfRadarRadiation> GetRadiationHostUnits(Side side_)
		{
			List<Contact.HostUnitOfRadarRadiation> result;
			if (!Information.IsNothing(this.ActualUnit) && this.ActualUnit.IsGroup)
			{
				Lazy<List<Contact.HostUnitOfRadarRadiation>> lazy = new Lazy<List<Contact.HostUnitOfRadarRadiation>>();
				foreach (Contact current in side_.GetContactList())
				{
					if (!Information.IsNothing(current.ActualUnit) && current.ActualUnit.HasParentGroup() && current.ActualUnit.GetParentGroup(false) == this.ActualUnit && current.GetRadiationHostUnits(side_).Count > 0)
					{
						lazy.Value.AddRange(current.GetRadiationHostUnits(side_));
					}
				}
				result = lazy.Value;
			}
			else
			{
				result = this.RadiationHostUnits;
			}
			return result;
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x0017C570 File Offset: 0x0017A770
		public Contact._BattleDamageAssessment? GetBattleDamageAssessment(Side side_2)
		{
			return this.BattleDamageAssessment;
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x0002151D File Offset: 0x0001F71D
		public void SetBattleDamageAssessment(Side side_2, Contact._BattleDamageAssessment? bda)
		{
			this.BattleDamageAssessment = bda;
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x0017C588 File Offset: 0x0017A788
		public ActiveUnit_Damage.FireIntensityLevel? GetBDA_Fire(Side side_2)
		{
			return this.BDA_Fire;
		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x00021526 File Offset: 0x0001F726
		public void SetBDA_Fire(Side side_2, ActiveUnit_Damage.FireIntensityLevel? fireIntensity)
		{
			this.BDA_Fire = fireIntensity;
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x0017C5A0 File Offset: 0x0017A7A0
		public ActiveUnit_Damage.FloodingIntensityLevel? GetBDA_Flood(Side side_2)
		{
			return this.BDA_Flood;
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x0002152F File Offset: 0x0001F72F
		public void SetBDA_Flood(Side side_2, ActiveUnit_Damage.FloodingIntensityLevel? floodingIntensity)
		{
			this.BDA_Flood = floodingIntensity;
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x0017C5B8 File Offset: 0x0017A7B8
		public float? GetRangeMax(Contact_Base.ContactType contactType)
		{
			float? num = null;
			float? result;
			switch (contactType)
			{
			case Contact_Base.ContactType.Air:
			case Contact_Base.ContactType.Missile:
				num = new float?(this.GetAirRangeMax().GetValueOrDefault());
				result = num;
				return result;
			case Contact_Base.ContactType.Surface:
				num = new float?(this.GetSurfaceRangeMax().GetValueOrDefault());
				result = num;
				return result;
			case Contact_Base.ContactType.Submarine:
				num = new float?(this.GetSubsurfaceRangeMax().GetValueOrDefault());
				result = num;
				return result;
			case Contact_Base.ContactType.UndeterminedNaval:
			case Contact_Base.ContactType.Orbital:
				result = num;
				return result;
			case Contact_Base.ContactType.Aimpoint:
				break;
			case Contact_Base.ContactType.Facility_Fixed:
			case Contact_Base.ContactType.Facility_Mobile:
				num = new float?(this.GetLandRangeMax().GetValueOrDefault());
				result = num;
				return result;
			default:
				if (contactType != Contact_Base.ContactType.ActivationPoint)
				{
					result = num;
					return result;
				}
				break;
			}
			result = null;
			return result;
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x0017C678 File Offset: 0x0017A878
		public short method_72()
		{
			short result;
			if (!this.IsBallisticMissileOrReEntryVehicles() && !this.IsOrbital())
			{
				this.method_97();
				result = 2;
			}
			else
			{
				result = 10;
			}
			return result;
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x0017C6AC File Offset: 0x0017A8AC
		public float? GetAirRangeMax()
		{
			float? result = null;
			try
			{
				if (this.GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownClass)
				{
					result = null;
				}
				else if (Information.IsNothing(this.ActualUnit))
				{
					result = null;
				}
				else
				{
					if (!this.AirRangeMax.HasValue)
					{
						List<Weapon> list = new List<Weapon>();
						GlobalVariables.ActiveUnitType unitType = this.ActualUnit.GetUnitType();
						if (unitType == GlobalVariables.ActiveUnitType.Aircraft)
						{
							int dBID = this.ActualUnit.DBID;
							SQLiteConnection sQLiteConnection = this.ActualUnit.m_Scenario.GetSQLiteConnection();
							using (IEnumerator<int> enumerator = DBFunctions.smethod_43(dBID, ref sQLiteConnection).GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									int current = enumerator.Current;
									Weapon weapon = this.ActualUnit.m_Scenario.GetWeapon(current);
									if (weapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
									{
										list.Add(weapon);
									}
								}
								goto IL_111;
							}
						}
						list = this.ActualUnit.GetWeaponry().GetWeaponsDictionary(false).Values.ToList<Weapon>().Where(Contact.WeaponFunc0).ToList<Weapon>();
						IL_111:
						if (list.Count == 0)
						{
							this.AirRangeMax = new float?(0f);
						}
						else
						{
							this.AirRangeMax = new float?(list.OrderByDescending(Contact.WeaponFunc1).ElementAtOrDefault(0).RangeAAWMax);
						}
					}
					result = this.AirRangeMax;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100480", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x0017C890 File Offset: 0x0017AA90
		public float? GetSurfaceRangeMax()
		{
			float? result = null;
			try
			{
				if (this.GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownClass)
				{
					result = null;
				}
				else if (Information.IsNothing(this.ActualUnit))
				{
					result = null;
				}
				else
				{
					if (!this.SurfaceRangeMax.HasValue)
					{
						List<Weapon> list = new List<Weapon>();
						GlobalVariables.ActiveUnitType unitType = this.ActualUnit.GetUnitType();
						if (unitType == GlobalVariables.ActiveUnitType.Aircraft)
						{
							int dBID = this.ActualUnit.DBID;
							SQLiteConnection sQLiteConnection = this.ActualUnit.m_Scenario.GetSQLiteConnection();
							using (IEnumerator<int> enumerator = DBFunctions.smethod_43(dBID, ref sQLiteConnection).GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									int current = enumerator.Current;
									Weapon weapon = this.ActualUnit.m_Scenario.GetWeapon(current);
									if (weapon.TargetIsShipOrRadar())
									{
										list.Add(weapon);
									}
								}
								goto IL_111;
							}
						}
						list = this.ActualUnit.GetWeaponry().GetWeaponsDictionary(false).Values.ToList<Weapon>().Where(Contact.WeaponFunc2).ToList<Weapon>();
						IL_111:
						if (list.Count == 0)
						{
							this.SurfaceRangeMax = new float?(0f);
						}
						else
						{
							this.SurfaceRangeMax = new float?(list.OrderByDescending(Contact.WeaponFunc3).ElementAtOrDefault(0).RangeASUWMax);
						}
					}
					result = this.SurfaceRangeMax;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100481", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x0017CA74 File Offset: 0x0017AC74
		public float? GetLandRangeMax()
		{
			float? result = null;
			try
			{
				if (this.GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownClass)
				{
					result = null;
				}
				else if (Information.IsNothing(this.ActualUnit))
				{
					result = null;
				}
				else
				{
					if (!this.LandRangeMax.HasValue)
					{
						List<Weapon> list = new List<Weapon>();
						GlobalVariables.ActiveUnitType unitType = this.ActualUnit.GetUnitType();
						if (unitType == GlobalVariables.ActiveUnitType.Aircraft)
						{
							int dBID = this.ActualUnit.DBID;
							SQLiteConnection sQLiteConnection = this.ActualUnit.m_Scenario.GetSQLiteConnection();
							using (IEnumerator<int> enumerator = DBFunctions.smethod_43(dBID, ref sQLiteConnection).GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									int current = enumerator.Current;
									Weapon weapon = this.ActualUnit.m_Scenario.GetWeapon(current);
									if (weapon.TargetIsLandFacility())
									{
										list.Add(weapon);
									}
								}
								goto IL_111;
							}
						}
						list = this.ActualUnit.GetWeaponry().GetWeaponsDictionary(false).Values.ToList<Weapon>().Where(Contact.WeaponFunc4).ToList<Weapon>();
						IL_111:
						if (list.Count == 0)
						{
							this.LandRangeMax = new float?(0f);
						}
						else
						{
							this.LandRangeMax = new float?(list.OrderByDescending(Contact.WeaponFunc5).ElementAtOrDefault(0).RangeLandMax);
						}
					}
					result = this.LandRangeMax;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101215", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x0017CC58 File Offset: 0x0017AE58
		public float? GetSubsurfaceRangeMax()
		{
			float? result = null;
			try
			{
				if (this.GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownClass)
				{
					result = null;
				}
				else if (Information.IsNothing(this.ActualUnit))
				{
					result = null;
				}
				else
				{
					if (!this.SubsurfaceRangeMax.HasValue)
					{
						List<Weapon> list = new List<Weapon>();
						GlobalVariables.ActiveUnitType unitType = this.ActualUnit.GetUnitType();
						if (unitType == GlobalVariables.ActiveUnitType.Aircraft)
						{
							int dBID = this.ActualUnit.DBID;
							SQLiteConnection sQLiteConnection = this.ActualUnit.m_Scenario.GetSQLiteConnection();
							using (IEnumerator<int> enumerator = DBFunctions.smethod_43(dBID, ref sQLiteConnection).GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									int current = enumerator.Current;
									Weapon weapon = this.ActualUnit.m_Scenario.GetWeapon(current);
									if (weapon.TargetIsSubsurface())
									{
										list.Add(weapon);
									}
								}
								goto IL_111;
							}
						}
						list = this.ActualUnit.GetWeaponry().GetWeaponsDictionary(false).Values.ToList<Weapon>().Where(Contact.TargetIsSubsurfaceFilter).ToList<Weapon>();
						IL_111:
						if (list.Count == 0)
						{
							this.SubsurfaceRangeMax = new float?(0f);
						}
						else
						{
							this.SubsurfaceRangeMax = new float?(list.OrderByDescending(Contact.WeaponFunc7).ElementAtOrDefault(0).RangeASWMax);
						}
					}
					result = this.SubsurfaceRangeMax;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100482", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x0017CE3C File Offset: 0x0017B03C
		public float? GetMaxRange()
		{
			float? result = null;
			if (Information.IsNothing(this.ActualUnit))
			{
				result = null;
			}
			else
			{
				try
				{
					if (!this.MaxRange.HasValue || this.identificationStatus_1 != this.GetIdentificationStatus())
					{
						this.identificationStatus_1 = this.GetIdentificationStatus();
						if (this.GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownClass)
						{
							if (!this.HasEmissionContainer())
							{
								this.MaxRange = new float?(0f);
							}
							else
							{
								IEnumerable<Sensor> source = this.GetEmissionContainerObDictionary().Dictionary.Where(Contact.KeyValuePairFunc8).Select(new Func<KeyValuePair<int, EmissionContainer>, Sensor>(this.method_136)).Where(Contact.SensorFunc9).OrderByDescending(Contact.SensorFunc10);
								if (source.Count<Sensor>() == 0)
								{
									this.MaxRange = new float?(0f);
								}
								else
								{
									this.MaxRange = new float?(source.ElementAtOrDefault(0).MaxRange);
								}
							}
						}
						else
						{
							ActiveUnit_Sensory sensory = this.ActualUnit.GetSensory();
							Sensor[] array = null;
							List<Sensor> maxRangeCoverageAirSpaceSensorList = sensory.GetMaxRangeCoverageAirSpaceSensorList(true, false, false, false, ref array);
							if (maxRangeCoverageAirSpaceSensorList.Count == 0)
							{
								this.MaxRange = new float?(0f);
							}
							else
							{
								this.MaxRange = new float?(maxRangeCoverageAirSpaceSensorList[0].MaxRange);
							}
						}
					}
					result = this.MaxRange;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200547", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new float?(0f);
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x0017D008 File Offset: 0x0017B208
		public float? method_78()
		{
			float? result = null;
			if (Information.IsNothing(this.ActualUnit))
			{
				result = null;
			}
			else
			{
				try
				{
					if (!this.nullable_25.HasValue || this.identificationStatus_2 != this.GetIdentificationStatus())
					{
						this.identificationStatus_2 = this.GetIdentificationStatus();
						if (this.GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownClass)
						{
							if (!this.HasEmissionContainer())
							{
								this.nullable_25 = new float?(0f);
							}
							else
							{
								List<Sensor> list = this.GetEmissionContainerObDictionary().Dictionary.Where(Contact.KeyValuePairFunc11).Select(new Func<KeyValuePair<int, EmissionContainer>, Sensor>(this.method_137)).Where(Contact.SensorFunc12).OrderByDescending(Contact.SensorFunc13).ToList<Sensor>();
								if (list.Count == 0)
								{
									this.nullable_25 = new float?(0f);
								}
								else
								{
									this.nullable_25 = new float?(list[0].MaxRange);
								}
							}
						}
						else
						{
							ActiveUnit_Sensory sensory = this.ActualUnit.GetSensory();
							Sensor[] array = null;
							List<Sensor> maxRangeCoverageSurfaceAndLandSensorList = sensory.GetMaxRangeCoverageSurfaceAndLandSensorList(true, false, false, false, ref array);
							if (maxRangeCoverageSurfaceAndLandSensorList.Count == 0)
							{
								this.nullable_25 = new float?(0f);
							}
							else
							{
								this.nullable_25 = new float?(maxRangeCoverageSurfaceAndLandSensorList[0].MaxRange);
							}
						}
					}
					result = this.nullable_25;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200548", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new float?(0f);
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x0017D1DC File Offset: 0x0017B3DC
		public float? method_79()
		{
			float? result = null;
			if (Information.IsNothing(this.ActualUnit))
			{
				result = null;
			}
			else
			{
				try
				{
					if (!this.nullable_26.HasValue || this.identificationStatus_3 != this.GetIdentificationStatus())
					{
						this.identificationStatus_3 = this.GetIdentificationStatus();
						if (this.GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownClass)
						{
							if (!this.HasEmissionContainer())
							{
								this.nullable_26 = new float?(0f);
							}
							else
							{
								IEnumerable<Sensor> source = this.GetEmissionContainerObDictionary().Dictionary.Where(Contact.KeyValuePairFunc14).Select(new Func<KeyValuePair<int, EmissionContainer>, Sensor>(this.method_138)).Where(Contact.SensorFunc15).OrderByDescending(Contact.SensorFunc16);
								if (source.Count<Sensor>() == 0)
								{
									this.nullable_26 = new float?(0f);
								}
								else
								{
									this.nullable_26 = new float?(source.ElementAtOrDefault(0).MaxRange);
								}
							}
						}
						else
						{
							ActiveUnit_Sensory sensory = this.ActualUnit.GetSensory();
							Sensor[] array = null;
							List<Sensor> maxRangeCoverageSubsurfaceSensorList = sensory.GetMaxRangeCoverageSubsurfaceSensorList(true, false, false, false, ref array, false);
							if (maxRangeCoverageSubsurfaceSensorList.Count == 0)
							{
								this.nullable_26 = new float?(0f);
							}
							else
							{
								this.nullable_26 = new float?(maxRangeCoverageSubsurfaceSensorList[0].MaxRange);
							}
						}
					}
					result = this.nullable_26;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100485", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x0017D39C File Offset: 0x0017B59C
		public string method_80()
		{
			string result;
			if (this.Heading_Known)
			{
				result = Conversions.ToString(Math.Round((double)this.GetCurrentHeading(), 0)) + "度";
			}
			else
			{
				result = "XXX";
			}
			return result;
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x0017D3E4 File Offset: 0x0017B5E4
		public string method_81()
		{
			string result;
			if (this.Speed_Known)
			{
				result = Conversions.ToString(Math.Round((double)this.GetCurrentSpeed(), 0)) + " kts";
			}
			else
			{
				result = "XXX";
			}
			return result;
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x0017D42C File Offset: 0x0017B62C
		public string method_82(bool bool_18)
		{
			string result;
			if (this.Altitude_Known)
			{
				if (bool_18)
				{
					if (this.GetCurrentAltitude_ASL(false) > 45720f)
					{
						result = Conversions.ToString(Math.Round((double)(this.GetCurrentAltitude_ASL(false) / 1000f), 1)) + " km";
					}
					else if (this.GetCurrentAltitude_ASL(false) > 3048f)
					{
						result = Conversions.ToString(Math.Round((double)(this.GetCurrentAltitude_ASL(false) * 3.28084f), 0)) + " ft";
					}
					else if (this.IsAirSpace() && base.IsOnLand())
					{
						result = Conversions.ToString(Math.Round((double)(this.GetCurrentAltitude_ASL(false) * 3.28084f), 0)) + " ft (" + Conversions.ToString(Math.Round((double)(base.GetAltitude_AGL() * 3.28084f), 0)) + "英尺(真高))";
					}
					else
					{
						result = Conversions.ToString(Math.Round((double)(this.GetCurrentAltitude_ASL(false) * 3.28084f), 0)) + " ft";
					}
				}
				else if (this.GetCurrentAltitude_ASL(false) > 45720f)
				{
					result = Conversions.ToString(Math.Round((double)(this.GetCurrentAltitude_ASL(false) / 1000f), 1)) + " km";
				}
				else if (this.GetCurrentAltitude_ASL(false) > 3048f)
				{
					result = Conversions.ToString(Math.Round((double)this.GetCurrentAltitude_ASL(false), 0)) + " m";
				}
				else if (this.IsAirSpace() && base.IsOnLand())
				{
					result = Conversions.ToString(Math.Round((double)this.GetCurrentAltitude_ASL(false), 0)) + " m (" + Conversions.ToString((int)Math.Round((double)base.GetAltitude_AGL())) + "米(真高))";
				}
				else
				{
					result = Conversions.ToString(Math.Round((double)this.GetCurrentAltitude_ASL(false), 0)) + " m";
				}
			}
			else
			{
				result = "XXX";
			}
			return result;
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x0017D638 File Offset: 0x0017B838
		public bool IsBallisticMissileOrReEntryVehicles()
		{
			bool result = false;
			try
			{
				result = (!Information.IsNothing(this.ActualUnit) && this.ActualUnit.IsWeapon && (((Weapon)this.ActualUnit).weaponCode.Warhead_MultipleIndependentReEntryVehicles || ((Weapon)this.ActualUnit).weaponCode.Warhead_MultipleReEntryVehicles || ((Weapon)this.ActualUnit).weaponCode.Warhead_SingleReEntryVehicle || ((Weapon)this.ActualUnit).weaponCode.BallisticMissile));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100486", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x0017D720 File Offset: 0x0017B920
		public bool IsSpecificTargetForStikeMission(Strike strike_)
		{
			return !Information.IsNothing(this.ActualUnit) && strike_.SpecificTargets.Count != 0 && (strike_.SpecificTargets.Contains(this) || strike_.SpecificTargets.Contains(this.ActualUnit));
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x0017D76C File Offset: 0x0017B96C
		public float GetCrossRangeAmbiguity(double AttackerLat_, double AttackerLon_)
		{
			Contact.GeoLocation geoLocation = new Contact.GeoLocation();
			geoLocation.Latitude = AttackerLat_;
			geoLocation.Longitude = AttackerLon_;
			float result = 0f;
			try
			{
				Contact.Attacker attacker = new Contact.Attacker();
				attacker.Location = geoLocation;
				if (Information.IsNothing(this.GetUncertaintyArea()))
				{
					result = 0f;
				}
				else if (this.GetUncertaintyArea().Count == 0)
				{
					result = 0f;
				}
				else
				{
					attacker.TargetAzimuth = Math2.GetAzimuth(attacker.Location.Latitude, attacker.Location.Longitude, this.GetLatitude(null), this.GetLongitude(null));
					IOrderedEnumerable<GeoPoint> source = this.GetUncertaintyArea().Select(Contact.GeoPointFunc17).OrderBy(new Func<GeoPoint, float>(attacker.BearingRelativeToTarget));
					GeoPoint geoPoint = source.ElementAtOrDefault(0);
					GeoPoint geoPoint2 = source.ElementAtOrDefault(source.Count<GeoPoint>() - 1);
					float num = Class263.smethod_13(new GeoPoint(attacker.Location.Longitude, attacker.Location.Latitude), new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)), new GeoPoint(geoPoint.GetLongitude(), geoPoint.GetLatitude()));
					float num2 = Class263.smethod_13(new GeoPoint(attacker.Location.Longitude, attacker.Location.Latitude), new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)), new GeoPoint(geoPoint2.GetLongitude(), geoPoint2.GetLatitude()));
					result = num + num2;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100487", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x0017D970 File Offset: 0x0017BB70
		public float GetDownRangeAmbiguity(Unit unit_)
		{
			Contact.AngularDistanceToUnit angularDistanceToUnit = new Contact.AngularDistanceToUnit();
			angularDistanceToUnit.unit = unit_;
			float result = 0f;
			try
			{
				if (Information.IsNothing(this.GetUncertaintyArea()))
				{
					result = 0f;
				}
				else if (this.GetUncertaintyArea().Count == 0)
				{
					result = 0f;
				}
				else
				{
					List<GeoPoint> list = this.GetUncertaintyArea().OrderBy(new Func<GeoPoint, double>(angularDistanceToUnit.GetAngularDistance)).ToList<GeoPoint>();
					GeoPoint geoPoint = list[0];
					GeoPoint geoPoint2 = list[list.Count - 1];
					result = angularDistanceToUnit.unit.HorizontalRangeTo(geoPoint2.GetLatitude(), geoPoint2.GetLongitude()) - angularDistanceToUnit.unit.HorizontalRangeTo(geoPoint.GetLatitude(), geoPoint.GetLongitude());
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100488", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x0017DA84 File Offset: 0x0017BC84
		public override  bool vmethod_39(List<GeoPoint> list_7, Scenario scenario_0, bool bool_18)
		{
			bool flag = false;
			bool result;
			try
			{
				if (Information.IsNothing(this.GetUncertaintyArea()))
				{
					flag = base.vmethod_39(list_7, scenario_0, bool_18);
				}
				else
				{
					foreach (GeoPoint current in this.GetUncertaintyArea())
					{
						List<GeoPoint> list = list_7.ToList<GeoPoint>();
						if (!current.method_21(ref list, bool_18))
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
				ex2.Data.Add("Error at 100489", "");
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

		// Token: 0x060041EC RID: 16876 RVA: 0x0017DB5C File Offset: 0x0017BD5C
		public bool IsTargetOutOfUnitInterceptRange(ActiveUnit activeUnit_)
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					float slantRange = activeUnit_.GetSlantRange(this, 0f);
					List<Weapon> list = new List<Weapon>();
					Mount[] mounts = activeUnit_.m_Mounts;
					for (int i = 0; i < mounts.Length; i++)
					{
						Mount mount = mounts[i];
						foreach (WeaponRec current in mount.GetWeaponRecCollection())
						{
							Weapon._WeaponType weaponType = current.GetWeapon(activeUnit_.m_Scenario).GetWeaponType();
							if (unchecked(weaponType - Weapon._WeaponType.Rocket) <= 2)
							{
								list.Add(current.GetWeapon(activeUnit_.m_Scenario));
							}
						}
					}
					using (List<Weapon>.Enumerator enumerator2 = list.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current.GetMaxRangeToTarget(activeUnit_, this, true, activeUnit_.m_Doctrine, false) > slantRange)
							{
								flag = false;
								result = false;
								return result;
							}
						}
					}
					flag = true;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100490", "");
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

		// Token: 0x060041ED RID: 16877 RVA: 0x0017DCC4 File Offset: 0x0017BEC4
		public float GetRCTT()
		{
			return this.RCTT;
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x00021538 File Offset: 0x0001F738
		public void SetRCTT(float value)
		{
			this.RCTT = Math.Max(0f, value);
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x0017DCDC File Offset: 0x0017BEDC
		public float GetRCTTP()
		{
			return this.RCTTP;
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x0002154B File Offset: 0x0001F74B
		public void SetRCTTP(float value)
		{
			this.RCTTP = Math.Max(0f, value);
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x0017DCF4 File Offset: 0x0017BEF4
		public Weapon[] method_92()
		{
			Weapon[] result;
			try
			{
				Weapon[] array = new Weapon[0];
				if (Information.IsNothing(this.ActualUnit))
				{
					result = array;
				}
				else
				{
					this.LazyGuidedWeaponsInAirForMe = new Lazy<Weapon[]>(new Func<Weapon[]>(this.GetGuidedWeaponsInAirForMe));
					result = this.LazyGuidedWeaponsInAirForMe.Value;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = new Weapon[0];
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x0017DD6C File Offset: 0x0017BF6C
		private Weapon[] GetGuidedWeaponsInAirForMe()
		{
			return Contact.GetWeaponsInAirAimingAtTheTarget(this, this.ActualUnit.m_Scenario);
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x0017DD8C File Offset: 0x0017BF8C
		public static Weapon[] GetWeaponsInAirAimingAtTheTarget(Contact theTarget_, Scenario scenario_)
		{
			Weapon[] array = new Weapon[0];
			Weapon[] result;
			try
			{
				if (!Information.IsNothing(scenario_.GetGuidedWeaponsInAir()) && scenario_.GetGuidedWeaponsInAir().Count != 0)
				{
					List<Weapon> guidedWeaponsInAir = scenario_.GetGuidedWeaponsInAir();
					if (Information.IsNothing(guidedWeaponsInAir))
					{
						result = array;
					}
					else if (Information.IsNothing(theTarget_.ActualUnit))
					{
						result = array;
					}
					else
					{
						Side side = theTarget_.ActualUnit.GetSide(false);
						if (guidedWeaponsInAir.Count > 0)
						{
							string guid = theTarget_.GetGuid();
							for (int i = guidedWeaponsInAir.Count - 1; i >= 0; i += -1)
							{
								Weapon weapon = guidedWeaponsInAir[i];
								if (!Information.IsNothing(weapon))
								{
									Weapon_AI weaponAI = weapon.GetWeaponAI();
									Misc.PostureStance postureStance = side.GetPostureStance(weapon.GetSide(false));
									if (Information.IsNothing(postureStance))
									{
										goto IL_D6;
									}
									if (postureStance != Misc.PostureStance.Friendly)
									{
										goto IL_D6;
									}
									bool arg_FB_0 = true;
									IL_FB:
									if (arg_FB_0)
									{
										goto IL_210;
									}
									if (!Information.IsNothing(weaponAI) && !Information.IsNothing(weaponAI.GetPrimaryTarget()))
									{
										if (weaponAI.GetPrimaryTarget() == theTarget_ || Operators.CompareString(weaponAI.GetPrimaryTarget().GetGuid(), guid, false) == 0)
										{
											ScenarioArrayUtil.AddWeapon(ref array, weapon);
											goto IL_210;
										}
										if (!Information.IsNothing(weaponAI.GetPrimaryTarget().ActualUnit) && !Information.IsNothing(theTarget_.ActualUnit) && weaponAI.GetPrimaryTarget().ActualUnit == theTarget_.ActualUnit)
										{
											ScenarioArrayUtil.AddWeapon(ref array, weapon);
											goto IL_210;
										}
									}
									if (weapon.IsMREV_GuidedBallisticMissile() && weaponAI.GetTargets().Contains(theTarget_))
									{
										ScenarioArrayUtil.AddWeapon(ref array, weapon);
										goto IL_210;
									}
									if (weapon.GetGuidanceMethod() == Weapon._GuidanceMethod.InertiallyGuided && weapon.GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.Aimpoint && weapon.GetWeaponAI().GetPrimaryTarget().GetHorizontalRange(theTarget_) * 1852f < 20f)
									{
										ScenarioArrayUtil.AddWeapon(ref array, weapon);
										goto IL_210;
									}
									goto IL_210;
									IL_D6:
									arg_FB_0 = (!Information.IsNothing(weapon.GetFiringParent()) && !weapon.GetFiringParent().GetCommStuff().IsNotOutOfComms());
									goto IL_FB;
								}
								IL_210:;
							}
						}
						for (int j = scenario_.GetUnitAdditions().Count - 1; j >= 0; j += -1)
						{
							ActiveUnit activeUnit = scenario_.GetUnitAdditions()[j];
							if (!Information.IsNothing(activeUnit) && activeUnit.IsWeapon)
							{
								Misc.PostureStance postureStance2 = side.GetPostureStance(activeUnit.GetSide(false));
								if (Information.IsNothing(postureStance2))
								{
									goto IL_289;
								}
								if (postureStance2 != Misc.PostureStance.Friendly)
								{
									goto IL_289;
								}
								bool arg_29A_0 = true;
								IL_29A:
								if (arg_29A_0)
								{
									goto IL_314;
								}
								if (activeUnit.GetAI().GetPrimaryTarget() == theTarget_)
								{
									ScenarioArrayUtil.AddWeapon(ref array, (Weapon)activeUnit);
									goto IL_314;
								}
								if (!Information.IsNothing(activeUnit.GetAI().GetPrimaryTarget().ActualUnit) && !Information.IsNothing(theTarget_.ActualUnit) && activeUnit.GetAI().GetPrimaryTarget().ActualUnit == theTarget_.ActualUnit)
								{
									ScenarioArrayUtil.AddWeapon(ref array, (Weapon)activeUnit);
									goto IL_314;
								}
								goto IL_314;
								IL_289:
								arg_29A_0 = Information.IsNothing(activeUnit.GetAI().GetPrimaryTarget());
								goto IL_29A;
							}
							IL_314:;
						}
						result = array;
					}
				}
				else
				{
					result = array;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200024", ex2.Message);
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

		// Token: 0x060041F4 RID: 16884 RVA: 0x0017E130 File Offset: 0x0017C330
		public override Side GetSide(bool SetSideOnly = false)
		{
			if (this.SideIsKnown && !Information.IsNothing(this.ActualUnit))
			{
				this.m_Side = this.ActualUnit.GetSide(false);
			}
			return this.m_Side;
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x000092FD File Offset: 0x000074FD
		public override void SetSide(bool SetSideOnly, Side value)
		{
			this.m_Side = value;
		}

		// Token: 0x060041F6 RID: 16886 RVA: 0x0017E170 File Offset: 0x0017C370
		public GlobalVariables.TargetVisualSizeClass GetTargetVisualSizeClass(Scenario scenario_0)
		{
			ActiveUnit actualUnit = this.ActualUnit;
			Contact_Base.IdentificationStatus identificationStatus = this.GetIdentificationStatus();
			GlobalVariables.TargetVisualSizeClass result = GlobalVariables.TargetVisualSizeClass.Stealthy;
			if (identificationStatus > Contact_Base.IdentificationStatus.KnownType)
			{
				if (identificationStatus - Contact_Base.IdentificationStatus.KnownClass <= 1)
				{
					result = actualUnit.GetTargetVisualSizeClass();
				}
			}
			else
			{
				result = actualUnit.GetTargetVisualSizeClass();
			}
			return result;
		}

		// Token: 0x060041F7 RID: 16887 RVA: 0x0002155E File Offset: 0x0001F75E
		public bool IsAirSpace()
		{
			return this.contactType == Contact_Base.ContactType.Air || this.contactType == Contact_Base.ContactType.Missile || this.contactType == Contact_Base.ContactType.Orbital;
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x0002157D File Offset: 0x0001F77D
		public bool IsAir()
		{
			return this.contactType == Contact_Base.ContactType.Air;
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x00021588 File Offset: 0x0001F788
		public bool method_97()
		{
			return this.contactType == Contact_Base.ContactType.Air || (this.contactType == Contact_Base.ContactType.Missile && !this.IsBallisticMissileOrReEntryVehicles());
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x000215AA File Offset: 0x0001F7AA
		public bool method_98()
		{
			return this.contactType == Contact_Base.ContactType.Air || this.contactType == Contact_Base.ContactType.Missile || this.contactType == Contact_Base.ContactType.Submarine;
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x000215C9 File Offset: 0x0001F7C9
		public bool IsFacilityType()
		{
			return this.contactType == Contact_Base.ContactType.Facility_Fixed || this.contactType == Contact_Base.ContactType.Facility_Mobile;
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x000215E0 File Offset: 0x0001F7E0
		public bool IsSurface()
		{
			return this.contactType == Contact_Base.ContactType.Surface;
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x000215EB File Offset: 0x0001F7EB
		public bool IsOrbital()
		{
			return this.contactType == Contact_Base.ContactType.Orbital;
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x0017E1B4 File Offset: 0x0017C3B4
		public bool IsMissileOrTorpedo()
		{
			Contact_Base.ContactType contactType = this.contactType;
			return contactType == Contact_Base.ContactType.Missile || contactType - Contact_Base.ContactType.Torpedo <= 1;
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x0017E1DC File Offset: 0x0017C3DC
		public bool IsMissile()
		{
			Contact_Base.ContactType contactType = this.contactType;
			return contactType == Contact_Base.ContactType.Missile;
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x0017E1F4 File Offset: 0x0017C3F4
		public List<GeoPoint> GetUncertaintyArea()
		{
			return this.UncertaintyArea;
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x000215F6 File Offset: 0x0001F7F6
		public void SetUncertaintyArea(List<GeoPoint> value)
		{
			this.UncertaintyArea = value;
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x0017E20C File Offset: 0x0017C40C
		public List<GeoPoint> method_106()
		{
			return this.list_4;
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x000215FF File Offset: 0x0001F7FF
		public void method_107(List<GeoPoint> list_7)
		{
			this.list_4 = list_7;
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x0017E224 File Offset: 0x0017C424
		public List<GeoPoint> method_108()
		{
			return this.list_5;
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x00021608 File Offset: 0x0001F808
		public void method_109(List<GeoPoint> list_7)
		{
			this.list_5 = list_7;
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x0017E23C File Offset: 0x0017C43C
		public List<GeoPoint> method_110()
		{
			return this.list_3;
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x00021611 File Offset: 0x0001F811
		public void method_111(List<GeoPoint> list_7)
		{
			this.list_3 = list_7;
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x0017E254 File Offset: 0x0017C454
		public ConcurrentDictionary<string, ActiveUnit> method_112(Scenario theScen, Side theSide, ActiveUnit ExcludeThisUnit = null)
		{
			ConcurrentDictionary<string, ActiveUnit> concurrentDictionary = null;
			ConcurrentDictionary<string, ActiveUnit> result;
			try
			{
				if (Information.IsNothing(this.concurrentDictionary_0))
				{
					ConcurrentDictionary<string, ActiveUnit> concurrentDictionary2 = new ConcurrentDictionary<string, ActiveUnit>();
					if (Information.IsNothing(theSide))
					{
						concurrentDictionary = concurrentDictionary2;
						result = concurrentDictionary;
						return result;
					}
					if (theSide.ActiveUnitArray.Length == 0)
					{
						concurrentDictionary = concurrentDictionary2;
						result = concurrentDictionary;
						return result;
					}
					List<ActiveUnit> list = new List<ActiveUnit>();
					list.AddRange(theSide.ActiveUnitArray);
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						ActiveUnit activeUnit = list[i];
						if (activeUnit.IsPlatform() && activeUnit.IsOperating() && !Information.IsNothing(activeUnit.GetAI().GetPrimaryTarget()) && activeUnit.GetAI().GetPrimaryTarget() == this)
						{
							concurrentDictionary2.TryAdd(activeUnit.GetGuid(), activeUnit);
						}
					}
					this.concurrentDictionary_0 = concurrentDictionary2;
				}
				if (Information.IsNothing(ExcludeThisUnit))
				{
					concurrentDictionary = this.concurrentDictionary_0;
				}
				else
				{
					ConcurrentDictionary<string, ActiveUnit> concurrentDictionary3 = new ConcurrentDictionary<string, ActiveUnit>(this.concurrentDictionary_0);
					concurrentDictionary3.TryRemove(ExcludeThisUnit.GetGuid(), out ExcludeThisUnit);
					concurrentDictionary = concurrentDictionary3;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100491", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = concurrentDictionary;
			return result;
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x0002161A File Offset: 0x0001F81A
		public bool GetIsPreciselyLocatedOnThisPulse()
		{
			return this.IsPreciselyLocatedOnThisPulse;
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x00021622 File Offset: 0x0001F822
		public void SetIsPreciselyLocatedOnThisPulse(bool value)
		{
			if (value)
			{
				this.SetUncertaintyArea(null);
			}
			this.IsPreciselyLocatedOnThisPulse = value;
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x00021638 File Offset: 0x0001F838
		public void SetHasUncertaintyArea(bool value)
		{
			this.HasUncertaintyArea = value;
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x0017E3D0 File Offset: 0x0017C5D0
		public bool IsDestroyed(Scenario scenario_)
		{
			bool result;
			if (this.contactType != Contact_Base.ContactType.Aimpoint && this.contactType != Contact_Base.ContactType.ActivationPoint)
			{
				if (Information.IsNothing(this.ActualUnit))
				{
					result = true;
					return result;
				}
				if (this.ActualUnit.isDestroyed)
				{
					result = true;
					return result;
				}
				try
				{
					result = (!scenario_.GetActiveUnits().ContainsKey(this.ActualUnit.GetGuid()) && !scenario_.GetUnitAdditions().Contains(this.ActualUnit));
					return result;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200025", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x0017E4A8 File Offset: 0x0017C6A8
		private string GetContactTypeString()
		{
			string text = "";
			string result;
			try
			{
				if (Information.IsNothing(this.ActualUnit))
				{
					text = "";
				}
				else if (this.contactType == Contact_Base.ContactType.Air)
				{
					if (this.ActualUnit.IsAircraft)
					{
						text = ((Aircraft)this.ActualUnit).Type.ToString();
					}
					else if (this.ActualUnit.IsWeapon)
					{
						if (((Weapon)this.ActualUnit).IsDecoy())
						{
							text = "诱饵";
						}
						else
						{
							text = "不明";
						}
					}
					else
					{
						text = "不明";
					}
				}
				else if (this.contactType != Contact_Base.ContactType.Decoy_Air && this.contactType != Contact_Base.ContactType.Decoy_Surface && this.contactType != Contact_Base.ContactType.Decoy_Land && this.contactType != Contact_Base.ContactType.Decoy_Sub)
				{
					if (this.contactType == Contact_Base.ContactType.Missile || this.contactType == Contact_Base.ContactType.Torpedo)
					{
						text = ((Weapon)this.ActualUnit).GetWeaponType().ToString();
						result = text;
						return result;
					}
					if (this.contactType == Contact_Base.ContactType.Surface)
					{
						text = ((Ship)this.ActualUnit).Type.ToString();
						result = text;
						return result;
					}
					if (this.contactType == Contact_Base.ContactType.Submarine)
					{
						text = ((Submarine)this.ActualUnit).Type.ToString();
						result = text;
						return result;
					}
					if (this.contactType == Contact_Base.ContactType.Facility_Fixed)
					{
						text = ((Facility)this.ActualUnit).Category.ToString();
						result = text;
						return result;
					}
					if (this.contactType == Contact_Base.ContactType.Facility_Mobile)
					{
						text = ((Facility)this.ActualUnit).GetMobileUnitCategoryString();
						result = text;
						return result;
					}
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw new NotImplementedException();
				}
				else
				{
					text = "诱饵";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100492", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = text;
			return result;
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x0017E6F8 File Offset: 0x0017C8F8
		public Contact_Base.IdentificationStatus GetIdentificationStatus()
		{
			return this.identificationStatus;
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x0017E710 File Offset: 0x0017C910
		public void TargetIdentification(Scenario scenario_, Side theDetectingSide, Sensor sensor_, float? distance, bool bool_18, bool bool_19, Contact_Base.IdentificationStatus identificationStatus_)
		{
			try
			{
				if (identificationStatus_ > this.identificationStatus)
				{
					this.identificationStatus = identificationStatus_;
					this.AirRangeMax = null;
					this.SurfaceRangeMax = null;
					this.SubsurfaceRangeMax = null;
					string str = "";
					if (distance.HasValue)
					{
						if (Information.IsNothing(this.GetUncertaintyArea()))
						{
							str = Math.Round((double)distance.Value, 1).ToString();
						}
						else
						{
							str = "预测距离 " + Math.Round((double)distance.Value, 0).ToString();
						}
					}
					LoggedMessage.MessageType messageType;
					if (bool_19)
					{
						messageType = LoggedMessage.MessageType.ContactChange;
					}
					else
					{
						messageType = LoggedMessage.MessageType.CommsIsolatedMessage;
					}
					switch (this.identificationStatus)
					{
					case Contact_Base.IdentificationStatus.KnownDomain:
					{
						Contact_Base.ContactType contactType = this.contactType;
						switch (contactType)
						{
						case Contact_Base.ContactType.Air:
							this.Name = "不明空中目标#" + Conversions.ToString(this.AInc);
							goto IL_C9D;
						case Contact_Base.ContactType.Missile:
						{
							if (Information.IsNothing(this.ActualUnit))
							{
								this.Name = "导弹#" + Conversions.ToString(this.AInc);
								goto IL_C9D;
							}
							if (Information.IsNothing(this.ActualUnit.GetAI().GetPrimaryTarget()))
							{
								this.Name = "导弹#" + Conversions.ToString(this.AInc);
								goto IL_C9D;
							}
							Contact primaryTarget = this.ActualUnit.GetAI().GetPrimaryTarget();
							if (primaryTarget.IsAirSpace())
							{
								Weapon weapon = (Weapon)this.ActualUnit;
								if (Information.IsNothing(weapon.GetFiringParent()))
								{
									this.Name = "导弹#" + Conversions.ToString(this.AInc);
									goto IL_C9D;
								}
								if (weapon.GetFiringParent().IsAircraft)
								{
									this.Name = "导弹#" + Conversions.ToString(this.AInc);
									goto IL_C9D;
								}
								this.Name = "防空导弹#" + Conversions.ToString(this.AInc);
								goto IL_C9D;
							}
							else
							{
								if ((primaryTarget.IsSurfaceOrLandTarget() || primaryTarget.IsSubSurface()) && !this.ActualUnit.IsAirDecoy())
								{
									this.Name = "VAMPIRE #" + Conversions.ToString(this.AInc);
									goto IL_C9D;
								}
								this.Name = "导弹#" + Conversions.ToString(this.AInc);
								goto IL_C9D;
							}
							break;
						}
						case Contact_Base.ContactType.Surface:
							this.Name = "不明水面目标#" + Conversions.ToString(this.AInc);
							goto IL_C9D;
						case Contact_Base.ContactType.Submarine:
							this.Name = "不明水下目标#" + Conversions.ToString(this.AInc);
							goto IL_C9D;
						case Contact_Base.ContactType.UndeterminedNaval:
						case Contact_Base.ContactType.Aimpoint:
						case Contact_Base.ContactType.Orbital:
							break;
						case Contact_Base.ContactType.Facility_Fixed:
							if (this.ActualUnit.IsAutoDetectable(null))
							{
								this.Name = this.ActualUnit.Name;
								this.SideIsKnown = true;
								goto IL_C9D;
							}
							this.Name = "固定#" + Conversions.ToString(this.AInc);
							goto IL_C9D;
						case Contact_Base.ContactType.Facility_Mobile:
							this.Name = "机动#" + Conversions.ToString(this.AInc);
							goto IL_C9D;
						case Contact_Base.ContactType.Torpedo:
							this.Name = "鱼雷#" + Conversions.ToString(this.AInc);
							goto IL_C9D;
						case Contact_Base.ContactType.Mine:
							this.Name = "水雷#" + Conversions.ToString(this.AInc);
							goto IL_C9D;
						default:
							if (contactType == Contact_Base.ContactType.Sonobuoy)
							{
								this.Name = "声纳浮标#" + Conversions.ToString(this.AInc);
								goto IL_C9D;
							}
							break;
						}
						this.Name = "目标#" + Conversions.ToString(this.AInc);
						break;
					}
					case Contact_Base.IdentificationStatus.KnownType:
						if (!Information.IsNothing(sensor_) && (sensor_.sensorType == Sensor.SensorType.Visual || sensor_.sensorType == Sensor.SensorType.Infrared) && this.contactType == Contact_Base.ContactType.Air && !Information.IsNothing(this.ActualUnit) && this.ActualUnit.IsAirDecoy())
						{
							this.contactType = Contact_Base.ContactType.Decoy_Air;
							string text = "目标: " + this.Name + " 识别为诱饵!";
							string text2 = "";
							if (!Information.IsNothing(sensor_))
							{
								if (!Information.IsNothing(sensor_.GetParentPlatform()))
								{
									ActiveUnit parentPlatform = sensor_.GetParentPlatform();
									string text3 = "";
									if (parentPlatform.IsAircraft && Operators.CompareString(parentPlatform.Name, parentPlatform.UnitClass, false) != 0)
									{
										text3 = " (" + parentPlatform.UnitClass + ")";
									}
									text2 = string.Concat(new string[]
									{
										" (识别平台: ",
										sensor_.GetParentPlatform().Name,
										text3,
										" [传感器: ",
										Misc.smethod_11(sensor_.Name),
										"]"
									});
								}
								else
								{
									text2 = " (识别传感器: " + Misc.smethod_11(sensor_.Name);
								}
								text2 += ")";
							}
							text += text2;
							scenario_.LogMessage(text, LoggedMessage.MessageType.ContactChange, 1, null, theDetectingSide, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						}
						else
						{
							string text4 = "目标: " + this.Name;
							this.Name = this.GetContactTypeString() + " #" + Conversions.ToString(this.AInc);
							text4 = text4 + " 类型确定为: " + this.GetContactTypeString();
							string text5 = "";
							if (!Information.IsNothing(sensor_))
							{
								if (!Information.IsNothing(sensor_.GetParentPlatform()))
								{
									ActiveUnit parentPlatform2 = sensor_.GetParentPlatform();
									string text6 = "";
									if (parentPlatform2.IsAircraft && Operators.CompareString(parentPlatform2.Name, parentPlatform2.UnitClass, false) == 0)
									{
										text6 = " (" + parentPlatform2.UnitClass + ")";
									}
									text5 = string.Concat(new string[]
									{
										" (识别平台: ",
										sensor_.GetParentPlatform().Name,
										text6,
										" [传感器: ",
										Misc.smethod_11(sensor_.Name),
										"]"
									});
								}
								else
								{
									text5 = " (识别传感器: " + Misc.smethod_11(sensor_.Name);
								}
								if (bool_18)
								{
									text5 += " [NCTR模式]";
								}
								if (!Information.IsNothing(distance))
								{
									text5 = text5 + " " + str + "海里)";
								}
								else
								{
									text5 += ")";
								}
							}
							text4 += text5;
							scenario_.LogMessage(text4, messageType, 1, null, theDetectingSide, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
							Contact_Base.ContactType contactType2 = this.contactType;
							if (contactType2 == Contact_Base.ContactType.Submarine)
							{
								Submarine._SubmarineType type = ((Submarine)this.ActualUnit).Type;
								if (type - Submarine._SubmarineType.Biologics <= 1)
								{
									this.SideIsKnown = true;
									if (!Information.IsNothing(this.ActualUnit) && !Information.IsNothing(this.ActualUnit.GetSide(false)))
									{
										this.MarkAs(theDetectingSide, false, theDetectingSide.GetPostureStance(this.ActualUnit.GetSide(false)));
										Contact contact = this;
										this.method_120(ref scenario_, ref theDetectingSide, ref contact);
										this.bool_11 = false;
									}
								}
							}
						}
						break;
					case Contact_Base.IdentificationStatus.KnownClass:
					{
						this.SideIsKnown = true;
						if (!Information.IsNothing(this.ActualUnit) && !Information.IsNothing(this.ActualUnit.GetSide(false)))
						{
							this.MarkAs(theDetectingSide, false, theDetectingSide.GetPostureStance(this.ActualUnit.GetSide(false)));
						}
						string text7 = "目标: " + this.Name;
						this.Name = Misc.smethod_11(this.ActualUnit.UnitClass) + " #" + Conversions.ToString(this.AInc);
						text7 = text7 + " 被识别为: " + Misc.smethod_11(this.ActualUnit.UnitClass);
						text7 = text7 + " - 确定为: " + Misc.GetPostureStanceString(this.GetPostureStance(theDetectingSide));
						string text8 = "";
						if (!Information.IsNothing(sensor_))
						{
							if (!Information.IsNothing(sensor_.GetParentPlatform()))
							{
								ActiveUnit parentPlatform3 = sensor_.GetParentPlatform();
								string text9 = "";
								if (parentPlatform3.IsAircraft && Operators.CompareString(parentPlatform3.Name, parentPlatform3.UnitClass, false) != 0)
								{
									text9 = " (" + parentPlatform3.UnitClass + ")";
								}
								text8 = string.Concat(new string[]
								{
									" (识别平台: ",
									sensor_.GetParentPlatform().Name,
									text9,
									" [传感器: ",
									Misc.smethod_11(sensor_.Name),
									"]"
								});
							}
							else
							{
								text8 = " (识别传感器: " + Misc.smethod_11(sensor_.Name);
							}
							if (bool_18)
							{
								text8 += " [NCTR模式]";
							}
							if (!Information.IsNothing(distance))
							{
								text8 = text8 + " " + str + "海里)";
							}
							else
							{
								text8 += ")";
							}
						}
						text7 += text8;
						scenario_.LogMessage(text7, messageType, 1, null, theDetectingSide, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						if (Information.IsNothing(sensor_) || sensor_.sensorType != Sensor.SensorType.Visual || sensor_.sensorType != Sensor.SensorType.Infrared)
						{
							if (this.ActualUnit.IsAirDecoy())
							{
								this.contactType = Contact_Base.ContactType.Air;
							}
							else if (this.ActualUnit.IsSurfaceDecoy())
							{
								this.contactType = Contact_Base.ContactType.Surface;
							}
							else if (this.ActualUnit.IsSubsurfaceDecoy())
							{
								this.contactType = Contact_Base.ContactType.Submarine;
							}
						}
						Contact contact = this;
						this.method_120(ref scenario_, ref theDetectingSide, ref contact);
						this.bool_11 = false;
						break;
					}
					case Contact_Base.IdentificationStatus.PreciseID:
					{
						this.SideIsKnown = true;
						if (!Information.IsNothing(this.ActualUnit) && !Information.IsNothing(this.ActualUnit.GetSide(false)))
						{
							this.MarkAs(theDetectingSide, false, theDetectingSide.GetPostureStance(this.ActualUnit.GetSide(false)));
						}
						if (string.IsNullOrEmpty(this.Name))
						{
							this.Name = this.ActualUnit.Name;
						}
						string text10 = "目标: " + this.Name;
						this.Name = this.ActualUnit.Name;
						text10 = text10 + "识别为: " + Misc.smethod_11(this.Name);
						text10 = text10 + " - 确定为: " + Misc.GetPostureStanceString(this.GetPostureStance(theDetectingSide));
						string text11 = "";
						if (!Information.IsNothing(sensor_))
						{
							if (!Information.IsNothing(sensor_.GetParentPlatform()))
							{
								ActiveUnit parentPlatform4 = sensor_.GetParentPlatform();
								string text12 = "";
								if (parentPlatform4.IsAircraft && Operators.CompareString(parentPlatform4.Name, parentPlatform4.UnitClass, false) != 0)
								{
									text12 = " (" + parentPlatform4.UnitClass + ")";
								}
								text11 = string.Concat(new string[]
								{
									" (识别平台: ",
									sensor_.GetParentPlatform().Name,
									text12,
									" [传感器: ",
									Misc.smethod_11(sensor_.Name),
									"]"
								});
							}
							else
							{
								text11 = " (识别传感器: " + Misc.smethod_11(sensor_.Name);
							}
							if (!Information.IsNothing(distance))
							{
								text11 = text11 + " " + str + "海里)";
							}
							else
							{
								text11 += ")";
							}
						}
						text10 += text11;
						if (this.contactType != Contact_Base.ContactType.Facility_Fixed && this.contactType != Contact_Base.ContactType.Installation && this.contactType != Contact_Base.ContactType.AirBase && this.contactType != Contact_Base.ContactType.NavalBase && this.contactType != Contact_Base.ContactType.MobileGroup)
						{
							scenario_.LogMessage(text10, messageType, 1, null, theDetectingSide, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						}
						Contact contact = this;
						this.method_120(ref scenario_, ref theDetectingSide, ref contact);
						this.bool_11 = false;
						break;
					}
					}
				}
				IL_C9D:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100493", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x0017F418 File Offset: 0x0017D618
		private void method_120(ref Scenario scenario_, ref Side side_, ref Contact contact_)
		{
			Side[] sides = scenario_.GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					Contact contact = null;
					if (side != side_ && GameGeneral.SideFriendsDictionary[side_].Contains(side) && !Information.IsNothing(contact_.ActualUnit) && side.GetContactObservableDictionary().TryGetValue(contact_.ActualUnit.GetGuid(), ref contact))
					{
						this.method_121(ref contact_, ref contact);
					}
				}
			}
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x0017F494 File Offset: 0x0017D694
		public void method_121(ref Contact contact_, ref Contact target_)
		{
			if (Operators.CompareString(target_.GetGuid(), contact_.GetGuid(), false) != 0 && contact_.GetIdentificationStatus() > target_.GetIdentificationStatus())
			{
				target_.identificationStatus = contact_.identificationStatus;
				target_.Name = contact_.Name;
				target_.bool_11 = false;
			}
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x00021641 File Offset: 0x0001F841
		public bool method_122(Side side_)
		{
			if (!this.nullable_27.HasValue)
			{
				this.nullable_27 = new bool?(!side_.GetContactObservableDictionary().ContainsKey(this.ActualUnit.GetGuid()));
			}
			return this.nullable_27.Value;
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x0002167F File Offset: 0x0001F87F
		public void method_123(Side side_2, bool bool_18)
		{
			this.nullable_27 = new bool?(bool_18);
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x0017F4F4 File Offset: 0x0017D6F4
		public Misc.PostureStance GetPostureStance(Side side_)
		{
			checked
			{
				Misc.PostureStance postureStance;
				Misc.PostureStance result;
				try
				{
					if (Information.IsNothing(this.ActualUnit))
					{
						postureStance = Misc.PostureStance.Unknown;
					}
					else
					{
						if (!this.method_122(side_) && !this.bool_11)
						{
							object obj = this.object_1;
							ObjectFlowControl.CheckForSyncLockOnValueType(obj);
							lock (obj)
							{
								if (!this.bool_11)
								{
									if (Information.IsNothing(this.ActualUnit) || this.ActualUnit.IsNotActive())
									{
										postureStance = Misc.PostureStance.Unknown;
										result = Misc.PostureStance.Unknown;
										return result;
									}
									Information.IsNothing(side_);
									Information.IsNothing(this.ActualUnit.GetSide(false));
									if (!(this.contactType == Contact_Base.ContactType.Missile | this.contactType == Contact_Base.ContactType.Torpedo))
									{
										if (this.SideIsKnown && this.InheritsSideStance)
										{
											Dictionary<Side, Misc.PostureStance> dictionary = new Dictionary<Side, Misc.PostureStance>();
											Side[] sides = this.ActualUnit.m_Scenario.GetSides();
											for (int i = 0; i < sides.Length; i++)
											{
												Side side = sides[i];
												if (!Information.IsNothing(side))
												{
													Contact_Base.ContactType contactType = this.contactType;
													if (unchecked(contactType - Contact_Base.ContactType.Installation) <= 3)
													{
														if (side.GetBaseContacts().Contains(this) || this.ActualUnit.IsDetected(side))
														{
															dictionary.Add(side, side.GetPostureStance(this.ActualUnit.GetSide(false)));
														}
													}
													else if (side.GetContactList().Contains(this) || this.ActualUnit.IsDetected(side))
													{
														dictionary.Add(side, side.GetPostureStance(this.ActualUnit.GetSide(false)));
													}
												}
											}
											this.SidePostureStanceDictionary = dictionary;
										}
									}
									else
									{
										Dictionary<Side, Misc.PostureStance> dictionary2 = new Dictionary<Side, Misc.PostureStance>();
										Side[] sides2 = this.ActualUnit.m_Scenario.GetSides();
										for (int j = 0; j < sides2.Length; j++)
										{
											Side side2 = sides2[j];
											if (!Information.IsNothing(side2) && side2.GetContactList().Contains(this))
											{
												Misc.PostureStance postureStance2 = side2.GetPostureStance(this.ActualUnit.GetSide(false));
												if (postureStance2 == Misc.PostureStance.Friendly)
												{
													dictionary2.Add(side2, postureStance2);
												}
												else
												{
													dictionary2.Add(side2, Misc.PostureStance.Hostile);
												}
											}
										}
										this.SidePostureStanceDictionary = dictionary2;
									}
									this.bool_11 = true;
								}
							}
						}
						Misc.PostureStance postureStance3;
						if (this.SidePostureStanceDictionary.TryGetValue(side_, out postureStance3))
						{
							postureStance = postureStance3;
						}
						else
						{
							postureStance = Misc.PostureStance.Unknown;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200572", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					postureStance = Misc.PostureStance.Unknown;
					ProjectData.ClearProjectError();
				}
				result = postureStance;
				return result;
			}
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x0017F7F0 File Offset: 0x0017D9F0
		public void MarkAs(Side side_, bool bool_18, Misc.PostureStance postureStance_)
		{
			try
			{
				if (!this.SideIsKnown || !side_.IsFriendlyToSide(this.ActualUnit.GetSide(false)))
				{
					if (bool_18)
					{
						this.InheritsSideStance = false;
					}
					else
					{
						this.InheritsSideStance = true;
					}
					Misc.PostureStance postureStance;
					if (!this.SidePostureStanceDictionary.TryGetValue(side_, out postureStance))
					{
						this.SidePostureStanceDictionary.Add(side_, postureStance);
					}
					bool? flag = new bool?(postureStance != postureStance_);
					if (this.SidePostureStanceDictionary.ContainsKey(side_))
					{
						this.SidePostureStanceDictionary[side_] = postureStance_;
					}
					if (flag.GetValueOrDefault() && this.SideIsKnown && this.GetSide(false).CollectiveResponsibility && (postureStance_ == Misc.PostureStance.Unfriendly || postureStance_ == Misc.PostureStance.Hostile) && !Information.IsNothing(this.ActualUnit))
					{
						side_.SetPostureStance(this.ActualUnit.GetSide(false), postureStance_);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100494", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004216 RID: 16918 RVA: 0x0017F918 File Offset: 0x0017DB18
		public bool IsOutdated()
		{
			bool result;
			switch (this.contactType)
			{
			case Contact_Base.ContactType.Air:
			case Contact_Base.ContactType.Missile:
			case Contact_Base.ContactType.Orbital:
				result = (this.Age > 300f);
				return result;
			case Contact_Base.ContactType.Surface:
			case Contact_Base.ContactType.Facility_Mobile:
				result = (this.Age > 7200f);
				return result;
			case Contact_Base.ContactType.Submarine:
				result = (this.Age > 21600f);
				return result;
			case Contact_Base.ContactType.Torpedo:
				result = (this.Age > 600f);
				return result;
			}
			result = false;
			return result;
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x0002168D File Offset: 0x0001F88D
		public bool IsPreciselyLocatedNewTarget()
		{
			return Information.IsNothing(this.GetUncertaintyArea()) && this.Age <= 1f;
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x0017F9A0 File Offset: 0x0017DBA0
		public bool IsSurfaceOrLandTarget()
		{
			Contact_Base.ContactType contactType = this.contactType;
			return this.contactType == Contact_Base.ContactType.Surface || contactType == Contact_Base.ContactType.Facility_Fixed || contactType == Contact_Base.ContactType.Facility_Mobile || this.contactType == Contact_Base.ContactType.ActivationPoint;
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x0017F9D4 File Offset: 0x0017DBD4
		public bool IsFixed()
		{
			Contact_Base.ContactType contactType = this.contactType;
			return contactType == Contact_Base.ContactType.Aimpoint || contactType == Contact_Base.ContactType.Facility_Fixed || contactType == Contact_Base.ContactType.Facility_Mobile;
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x0017F9F8 File Offset: 0x0017DBF8
		public bool IsSubSurface()
		{
			Contact_Base.ContactType contactType = this.contactType;
			return contactType == Contact_Base.ContactType.Submarine || contactType == Contact_Base.ContactType.Torpedo || contactType == Contact_Base.ContactType.Mine;
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x0017FA20 File Offset: 0x0017DC20
		public void SetDetectedLocation(ActiveUnit theDetectedUnit)
		{
			if (!Information.IsNothing(this.GetUncertaintyArea()) && this.GetUncertaintyArea().Count != 0)
			{
				List<GeoPoint> list = new List<GeoPoint>();
				foreach (GeoPoint current in this.GetUncertaintyArea())
				{
					if (double.IsNaN(current.GetLongitude()) || double.IsNaN(current.GetLatitude()))
					{
						list.Add(current);
					}
				}
				foreach (GeoPoint current2 in list)
				{
					this.GetUncertaintyArea().Remove(current2);
				}
				GeoPoint geoPoint = Misc.smethod_50(this.GetUncertaintyArea());
				this.SetLongitude(null, geoPoint.GetLongitude());
				this.SetLatitude(null, geoPoint.GetLatitude());
			}
			else
			{
				this.SetLongitude(null, theDetectedUnit.GetLongitude(null));
				this.SetLatitude(null, theDetectedUnit.GetLatitude(null));
			}
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x0017FB7C File Offset: 0x0017DD7C
		public Contact(ActiveUnit DetectedUnit, int AutoIncrement = 0)
		{
			this.SidePostureStanceDictionary = new Dictionary<Side, Misc.PostureStance>();
			this.SideNamePostureStanceDictionary = new Dictionary<string, Misc.PostureStance>();
			this.m_PostureStance = null;
			this.TSD = 0f;
			this.TS_BDA = 0f;
			this.TS_Recon = 0f;
			this.float_10 = 0f;
			this.LazyGuidedWeaponsInAirForMe = new Lazy<Weapon[]>();
			this.RadiationHostUnits = new List<Contact.HostUnitOfRadarRadiation>();
			this.list_3 = new List<GeoPoint>();
			this.list_4 = new List<GeoPoint>();
			this.list_5 = new List<GeoPoint>();
			this.InheritsSideStance = true;
			this.object_0 = RuntimeHelpers.GetObjectValue(new object());
			this.object_1 = RuntimeHelpers.GetObjectValue(new object());
			this.SideIsKnown = false;
			if (!Information.IsNothing(AutoIncrement))
			{
				this.AInc = AutoIncrement;
			}
			else
			{
				this.AInc = 0;
			}
			checked
			{
				if (!Information.IsNothing(DetectedUnit))
				{
					try
					{
						this.ActualUnit = DetectedUnit;
						if (DetectedUnit.IsAircraft)
						{
							this.contactType = Contact_Base.ContactType.Air;
						}
						else
						{
							if (DetectedUnit.IsWeapon)
							{
								Weapon._WeaponType weaponType = ((Weapon)DetectedUnit).GetWeaponType();
								if (weaponType <= Weapon._WeaponType.Torpedo)
								{
									if (weaponType != Weapon._WeaponType.GuidedWeapon)
									{
										if (weaponType != Weapon._WeaponType.Decoy_Vehicle)
										{
											if (weaponType == Weapon._WeaponType.Torpedo)
											{
												this.contactType = Contact_Base.ContactType.Torpedo;
												goto IL_2FB;
											}
											goto IL_1E3;
										}
										else
										{
											if (DetectedUnit.IsAirDecoy())
											{
												this.contactType = Contact_Base.ContactType.Air;
												goto IL_2FB;
											}
											if (DetectedUnit.IsSurfaceDecoy())
											{
												this.contactType = Contact_Base.ContactType.Surface;
												goto IL_2FB;
											}
											if (DetectedUnit.IsSubsurfaceDecoy())
											{
												this.contactType = Contact_Base.ContactType.Submarine;
												goto IL_2FB;
											}
											goto IL_2FB;
										}
									}
								}
								else
								{
									if (weaponType == Weapon._WeaponType.Sonobuoy)
									{
										this.contactType = Contact_Base.ContactType.Sonobuoy;
										goto IL_2FB;
									}
									if (weaponType != Weapon._WeaponType.RV && weaponType != Weapon._WeaponType.HGV)
									{
										goto IL_1E3;
									}
								}
								this.contactType = Contact_Base.ContactType.Missile;
								goto IL_2FB;
								IL_1E3:
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								throw new NotImplementedException();
							}
							if (DetectedUnit.IsFacility)
							{
								if (((Facility)DetectedUnit).IsMobile())
								{
									this.contactType = Contact_Base.ContactType.Facility_Mobile;
								}
								else
								{
									this.contactType = Contact_Base.ContactType.Facility_Fixed;
								}
							}
							else if (DetectedUnit.IsShip)
							{
								this.contactType = Contact_Base.ContactType.Surface;
							}
							else if (DetectedUnit.IsSubmarine)
							{
								this.contactType = Contact_Base.ContactType.Submarine;
							}
							else if (DetectedUnit.IsSatellite())
							{
								this.contactType = Contact_Base.ContactType.Orbital;
							}
							else
							{
								if (!DetectedUnit.IsGroup)
								{
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									throw new NotImplementedException();
								}
								if (((Group)this.ActualUnit).GetGroupType() == Group.GroupType.AirBase)
								{
									this.contactType = Contact_Base.ContactType.AirBase;
								}
								else if (((Group)this.ActualUnit).GetGroupType() == Group.GroupType.MobileGroup)
								{
									this.contactType = Contact_Base.ContactType.MobileGroup;
								}
								else if (((Group)this.ActualUnit).GetGroupType() == Group.GroupType.NavalBase)
								{
									this.contactType = Contact_Base.ContactType.NavalBase;
								}
								else
								{
									this.contactType = Contact_Base.ContactType.Installation;
								}
							}
						}
						IL_2FB:
						if (!Information.IsNothing(this.ActualUnit))
						{
							Side[] sides = this.ActualUnit.m_Scenario.GetSides();
							for (int i = 0; i < sides.Length; i++)
							{
								Side side = sides[i];
								if (!Information.IsNothing(side) && side.GetContactObservableDictionary().ContainsKey(this.ActualUnit.GetGuid()))
								{
									this.SidePostureStanceDictionary.Add(side, Misc.PostureStance.Unknown);
								}
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100495", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x0017FF48 File Offset: 0x0017E148
		public float method_132(Unit unit_)
		{
			float result = 0f;
			try
			{
				float num = this.GetCurrentSpeed() / 3600f;
				double lon = 0.0;
				double lat = 0.0;
				GeoPointGenerator.GetOtherGeoPoint(this.GetLongitude(null), this.GetLatitude(null), ref lon, ref lat, (double)num, (double)this.GetCurrentHeading());
				float azimuth = Math2.GetAzimuth(unit_.GetLatitude(null), unit_.GetLongitude(null), this.GetLatitude(null), this.GetLongitude(null));
				float num2 = Math2.GetAzimuth(unit_.GetLatitude(null), unit_.GetLongitude(null), lat, lon);
				num2 = Math2.Normalize(num2 - azimuth);
				if (num2 > 180f)
				{
					result = 360f - num2;
				}
				else
				{
					result = num2;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100496", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x001800A0 File Offset: 0x0017E2A0
		public void method_133(double double_2, ref Scenario scenario_0)
		{
			if (!Information.IsNothing(this.GetUncertaintyArea()) || this.Age != 0f)
			{
				try
				{
					if (Information.IsNothing(this.GetUncertaintyArea()) || !Misc.smethod_52(this.GetUncertaintyArea()))
					{
						double num = 0.0;
						if (this.Speed_Known)
						{
							num = (double)this.GetCurrentSpeed();
						}
						else
						{
							switch (this.contactType)
							{
							case Contact_Base.ContactType.Air:
								num = 660.0;
								break;
							case Contact_Base.ContactType.Missile:
								num = 1000.0;
								break;
							case Contact_Base.ContactType.Surface:
							case Contact_Base.ContactType.Submarine:
								num = 20.0;
								break;
							case Contact_Base.ContactType.Orbital:
								num = 6000.0;
								break;
							case Contact_Base.ContactType.Facility_Mobile:
								num = 20.0;
								break;
							case Contact_Base.ContactType.Torpedo:
								num = 45.0;
								break;
							}
						}
						if (num != 0.0)
						{
							double num2 = num / 3600.0 * double_2;
							double num3 = num2 * 1852.0;
							if (Information.IsNothing(this.GetUncertaintyArea()))
							{
								Class258.Location[] array = new Class258.Location[46];
								GeoPointGenerator.GetOtherPointsAroundAGeoPoint(this.GetLatitude(null), this.GetLongitude(null), num2, 45, ref array);
								List<GeoPoint> list = new List<GeoPoint>();
								Class258.Location[] array2 = array;
								checked
								{
									for (int i = 0; i < array2.Length; i++)
									{
										Class258.Location location = array2[i];
										list.Add(new GeoPoint(location.longitude, location.latitude));
									}
									this.SetUncertaintyArea(list);
								}
							}
							else
							{
								if (num3 > 0.0)
								{
									try
									{
										Class258.Class259 @class = new Class258.Class259(this.GetLatitude(null), this.GetLongitude(null));
										List<IntPoint> list2 = new List<IntPoint>();
										foreach (GeoPoint current in this.GetUncertaintyArea())
										{
											double num4 = current.GetLatitude();
											double num5 = current.GetLongitude();
											while (num5 > 180.0 || num5 < -180.0)
											{
												num5 = Math2.NormalizeLongitude(num5);
											}
											if (num4 > 90.0)
											{
												num4 = 90.0;
											}
											if (num4 < -90.0)
											{
												num4 = -90.0;
											}
											try
											{
												double a = 0.0;
												double a2 = 0.0;
												if (@class.method_1(num4, num5, ref a, ref a2, false))
												{
													list2.Add(new IntPoint((long)Math.Round(a), (long)Math.Round(a2)));
												}
											}
											catch (Exception ex)
											{
												ProjectData.SetProjectError(ex);
												Exception ex2 = ex;
												ex2.Data.Add("Error at 200026", ex2.Message);
												GameGeneral.LogException(ref ex2);
												if (Debugger.IsAttached)
												{
													Debugger.Break();
												}
												ProjectData.ClearProjectError();
											}
										}
										List<List<IntPoint>> list3 = new List<List<IntPoint>>();
										list3.Add(list2);
										Class2364 class2 = new Class2364(2.0, 0.25);
										class2.method_5(list3, Enum165.const_0, Enum166.const_0);
										List<List<IntPoint>> list4 = new List<List<IntPoint>>();
										class2.method_8(ref list4, num3);
										List<List<IntPoint>> list5 = list4;
										List<GeoPoint> list6 = new List<GeoPoint>();
										if (list5.Count == 0)
										{
											return;
										}
										foreach (IntPoint current2 in list5[0])
										{
											try
											{
												double double_3 = 0.0;
												double double_4 = 0.0;
												if (@class.method_6((double)current2.long_0, (double)current2.long_1, ref double_3, ref double_4))
												{
													list6.Add(new GeoPoint(double_4, double_3));
												}
											}
											catch (Exception ex3)
											{
												ProjectData.SetProjectError(ex3);
												Exception ex4 = ex3;
												ex4.Data.Add("Error at 200002", "");
												GameGeneral.LogException(ref ex4);
												if (Debugger.IsAttached)
												{
													Debugger.Break();
												}
												ProjectData.ClearProjectError();
											}
										}
										if (list6.Count > 100)
										{
											list6 = Math2.smethod_15(list6);
										}
										this.SetUncertaintyArea(list6);
									}
									catch (Exception ex5)
									{
										ProjectData.SetProjectError(ex5);
										Exception ex6 = ex5;
										ex6.Data.Add("Error at 200287", ex6.Message);
										GameGeneral.LogException(ref ex6);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
										ProjectData.ClearProjectError();
									}
								}
								this.method_58(ref scenario_0);
							}
						}
					}
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ex8.Data.Add("Error at 100498", "");
					GameGeneral.LogException(ref ex8);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x000216AF File Offset: 0x0001F8AF
		public override void SetGeoLocation(ref Scenario scenario_, double Longitude_, double Latitude_)
		{
			base.SetGeoLocation(ref scenario_, Longitude_, Latitude_);
			this.ActualUnit.SetGeoLocation(ref scenario_, Longitude_, Latitude_);
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x000216C8 File Offset: 0x0001F8C8
		private void EmissionContainerDictionary_DictionaryChanged(object sender, NotifyDictionaryChangedEventArgs<int, EmissionContainer> e)
		{
			this.list_6 = null;
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x0018063C File Offset: 0x0017E83C
		public Contact method_135()
		{
			Contact contact = (Contact)base.MemberwiseClone();
			Contact result = null;
			try
			{
				contact.SetGuid(Guid.NewGuid().ToString());
				contact.SetEmissionContainerDictionary(new ObservableDictionary<int, EmissionContainer>());
				if (!Information.IsNothing(this.GetEmissionContainerDictionary()))
				{
					contact.GetEmissionContainerDictionary().AddRange(this.GetEmissionContainerDictionary().Dictionary);
				}
				contact.LazyGuidedWeaponsInAirForMe = new Lazy<Weapon[]>();
				contact.concurrentDictionary_0 = new ConcurrentDictionary<string, ActiveUnit>();
				contact.RadiationHostUnits = new List<Contact.HostUnitOfRadarRadiation>();
				if (!Information.IsNothing(this.RadiationHostUnits))
				{
					contact.RadiationHostUnits.AddRange(this.RadiationHostUnits);
				}
				contact.UncertaintyArea = new List<GeoPoint>();
				if (!Information.IsNothing(this.UncertaintyArea))
				{
					contact.UncertaintyArea.AddRange(this.UncertaintyArea);
				}
				contact.list_6 = new List<int>();
				if (!Information.IsNothing(this.list_6))
				{
					contact.list_6.AddRange(this.list_6);
				}
				result = contact;
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
			return result;
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x00180760 File Offset: 0x0017E960
		[CompilerGenerated]
		private Sensor method_136(KeyValuePair<int, EmissionContainer> keyValuePair_0)
		{
			return keyValuePair_0.Value.method_0(keyValuePair_0.Key, this.ActualUnit.m_Scenario);
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x00180760 File Offset: 0x0017E960
		[CompilerGenerated]
		private Sensor method_137(KeyValuePair<int, EmissionContainer> keyValuePair_0)
		{
			return keyValuePair_0.Value.method_0(keyValuePair_0.Key, this.ActualUnit.m_Scenario);
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x00180760 File Offset: 0x0017E960
		[CompilerGenerated]
		private Sensor method_138(KeyValuePair<int, EmissionContainer> keyValuePair_0)
		{
			return keyValuePair_0.Value.method_0(keyValuePair_0.Key, this.ActualUnit.m_Scenario);
		}

		// Token: 0x04001E6B RID: 7787
		public static Func<Weapon, bool> WeaponFunc0 = (Weapon weapon_0) => weapon_0.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();

		// Token: 0x04001E6C RID: 7788
		public static Func<Weapon, float> WeaponFunc1 = (Weapon weapon_0) => weapon_0.RangeAAWMax;

		// Token: 0x04001E6D RID: 7789
		public static Func<Weapon, bool> WeaponFunc2 = (Weapon weapon_0) => weapon_0.TargetIsShipOrRadar();

		// Token: 0x04001E6E RID: 7790
		public static Func<Weapon, float> WeaponFunc3 = (Weapon weapon_0) => weapon_0.RangeASUWMax;

		// Token: 0x04001E6F RID: 7791
		public static Func<Weapon, bool> WeaponFunc4 = (Weapon weapon_0) => weapon_0.TargetIsLandFacility();

		// Token: 0x04001E70 RID: 7792
		public static Func<Weapon, float> WeaponFunc5 = (Weapon weapon_0) => weapon_0.RangeLandMax;

		// Token: 0x04001E71 RID: 7793
		public static Func<Weapon, bool> TargetIsSubsurfaceFilter = (Weapon weapon_0) => weapon_0.TargetIsSubsurface();

		// Token: 0x04001E72 RID: 7794
		public static Func<Weapon, float> WeaponFunc7 = (Weapon weapon_0) => weapon_0.RangeASWMax;

		// Token: 0x04001E73 RID: 7795
		public static Func<KeyValuePair<int, EmissionContainer>, bool> KeyValuePairFunc8 = (KeyValuePair<int, EmissionContainer> keyValuePair_0) => keyValuePair_0.Value.bool_1;

		// Token: 0x04001E74 RID: 7796
		public static Func<Sensor, bool> SensorFunc9 = (Sensor sensor_0) => sensor_0.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Aircraft) || sensor_0.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Satellite);

		// Token: 0x04001E75 RID: 7797
		public static Func<Sensor, float> SensorFunc10 = (Sensor sensor_0) => sensor_0.MaxRange;

		// Token: 0x04001E76 RID: 7798
		public static Func<KeyValuePair<int, EmissionContainer>, bool> KeyValuePairFunc11 = (KeyValuePair<int, EmissionContainer> keyValuePair_0) => keyValuePair_0.Value.bool_1;

		// Token: 0x04001E77 RID: 7799
		public static Func<Sensor, bool> SensorFunc12 = (Sensor sensor_0) => sensor_0.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Facility) || sensor_0.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Ship);

		// Token: 0x04001E78 RID: 7800
		public static Func<Sensor, float> SensorFunc13 = (Sensor sensor_0) => sensor_0.MaxRange;

		// Token: 0x04001E79 RID: 7801
		public static Func<KeyValuePair<int, EmissionContainer>, bool> KeyValuePairFunc14 = (KeyValuePair<int, EmissionContainer> keyValuePair_0) => keyValuePair_0.Value.bool_1;

		// Token: 0x04001E7A RID: 7802
		public static Func<Sensor, bool> SensorFunc15 = (Sensor sensor_0) => sensor_0.IsCapableOfDetect(GlobalVariables.ActiveUnitType.Submarine);

		// Token: 0x04001E7B RID: 7803
		public static Func<Sensor, float> SensorFunc16 = (Sensor sensor_0) => sensor_0.MaxRange;

		// Token: 0x04001E7C RID: 7804
		public static Func<GeoPoint, GeoPoint> GeoPointFunc17 = (GeoPoint geoPoint_0) => geoPoint_0;

		// Token: 0x04001E7D RID: 7805
		private string strSideName;

		// Token: 0x04001E7E RID: 7806
		public ActiveUnit ActualUnit;

		// Token: 0x04001E7F RID: 7807
		public string string_6;

		// Token: 0x04001E80 RID: 7808
		private bool IsPreciselyLocatedOnThisPulse;

		// Token: 0x04001E81 RID: 7809
		private bool HasUncertaintyArea;

		// Token: 0x04001E82 RID: 7810
		private Dictionary<Side, Misc.PostureStance> SidePostureStanceDictionary;

		// Token: 0x04001E83 RID: 7811
		private Dictionary<string, Misc.PostureStance> SideNamePostureStanceDictionary;

		// Token: 0x04001E84 RID: 7812
		private Misc.PostureStance? m_PostureStance;

		// Token: 0x04001E85 RID: 7813
		public bool bool_11;

		// Token: 0x04001E86 RID: 7814
		public float TSD;

		// Token: 0x04001E87 RID: 7815
		public float TS_BDA;

		// Token: 0x04001E88 RID: 7816
		public float TS_Recon;

		// Token: 0x04001E89 RID: 7817
		public float float_10;

		// Token: 0x04001E8A RID: 7818
		public bool IsFilterOut;

		// Token: 0x04001E8B RID: 7819
		private Lazy<Weapon[]> LazyGuidedWeaponsInAirForMe;

		// Token: 0x04001E8C RID: 7820
		private Contact._BattleDamageAssessment? BattleDamageAssessment;

		// Token: 0x04001E8D RID: 7821
		private ActiveUnit_Damage.FireIntensityLevel? BDA_Fire;

		// Token: 0x04001E8E RID: 7822
		private ActiveUnit_Damage.FloodingIntensityLevel? BDA_Flood;

		// Token: 0x04001E8F RID: 7823
		private List<Contact.HostUnitOfRadarRadiation> RadiationHostUnits;

		// Token: 0x04001E90 RID: 7824
		public bool Speed_Known;

		// Token: 0x04001E91 RID: 7825
		public bool Heading_Known;

		// Token: 0x04001E92 RID: 7826
		public bool Altitude_Known;

		// Token: 0x04001E93 RID: 7827
		private List<GeoPoint> UncertaintyArea;

		// Token: 0x04001E94 RID: 7828
		private List<GeoPoint> list_3;

		// Token: 0x04001E95 RID: 7829
		private List<GeoPoint> list_4;

		// Token: 0x04001E96 RID: 7830
		private List<GeoPoint> list_5;

		// Token: 0x04001E97 RID: 7831
		internal float float_11;

		// Token: 0x04001E98 RID: 7832
		internal float float_12;

		// Token: 0x04001E99 RID: 7833
		public float Age;

		// Token: 0x04001E9A RID: 7834
		public float HeldFor;

		// Token: 0x04001E9B RID: 7835
		private bool InheritsSideStance;

		// Token: 0x04001E9C RID: 7836
		private float RCTT;

		// Token: 0x04001E9D RID: 7837
		private float RCTTP;

		// Token: 0x04001E9E RID: 7838
		[CompilerGenerated]
		private ObservableDictionary<int, EmissionContainer> EmissionContainerDictionary;

		// Token: 0x04001E9F RID: 7839
		public List<int> list_6;

		// Token: 0x04001EA0 RID: 7840
		private object object_0;

		// Token: 0x04001EA1 RID: 7841
		internal float? TimeSinceDetection_Radar;

		// Token: 0x04001EA2 RID: 7842
		internal float? TimeSinceDetection_ESM;

		// Token: 0x04001EA3 RID: 7843
		internal float? TimeSinceDetection_Visual;

		// Token: 0x04001EA4 RID: 7844
		internal float? TimeSinceDetection_Infrared;

		// Token: 0x04001EA5 RID: 7845
		internal float? TimeSinceDetection_SonarActive;

		// Token: 0x04001EA6 RID: 7846
		internal float? TimeSinceDetection_SonarPassive;

		// Token: 0x04001EA7 RID: 7847
		internal bool SZC;

		// Token: 0x04001EA8 RID: 7848
		private float? AirRangeMax;

		// Token: 0x04001EA9 RID: 7849
		private float? SurfaceRangeMax;

		// Token: 0x04001EAA RID: 7850
		private float? LandRangeMax;

		// Token: 0x04001EAB RID: 7851
		private float? SubsurfaceRangeMax;

		// Token: 0x04001EAC RID: 7852
		private float? MaxRange;

		// Token: 0x04001EAD RID: 7853
		private Contact_Base.IdentificationStatus identificationStatus_1;

		// Token: 0x04001EAE RID: 7854
		private float? nullable_25;

		// Token: 0x04001EAF RID: 7855
		private Contact_Base.IdentificationStatus identificationStatus_2;

		// Token: 0x04001EB0 RID: 7856
		private float? nullable_26;

		// Token: 0x04001EB1 RID: 7857
		private Contact_Base.IdentificationStatus identificationStatus_3;

		// Token: 0x04001EB2 RID: 7858
		private object object_1;

		// Token: 0x04001EB3 RID: 7859
		private bool? nullable_27;

		// Token: 0x020009B6 RID: 2486
		public enum _BattleDamageAssessment : byte
		{
			// Token: 0x04001EC7 RID: 7879
			NoDamage,
			// Token: 0x04001EC8 RID: 7880
			LightDamage,
			// Token: 0x04001EC9 RID: 7881
			MediumDamage,
			// Token: 0x04001ECA RID: 7882
			HeavyDamage,
			// Token: 0x04001ECB RID: 7883
			Destroyed
		}

		// Token: 0x020009B7 RID: 2487
		public sealed class HostUnitOfRadarRadiation
		{
			// Token: 0x06004238 RID: 16952 RVA: 0x00180A8C File Offset: 0x0017EC8C
			public void Save(ref XmlWriter xmlWriter_0)
			{
				try
				{
					xmlWriter_0.WriteStartElement("HURR");
					xmlWriter_0.WriteElementString("UID", this.UID);
					xmlWriter_0.WriteElementString("IDS", Conversions.ToString((int)this.identificationStatus));
					xmlWriter_0.WriteElementString("RA", XmlConvert.ToString(this.RA));
					xmlWriter_0.WriteEndElement();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101313", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}

			// Token: 0x06004239 RID: 16953 RVA: 0x00180B3C File Offset: 0x0017ED3C
			public static Contact.HostUnitOfRadarRadiation Load(XmlNode xmlNode_0)
			{
				Contact.HostUnitOfRadarRadiation result = null;
				try
				{
					Contact.HostUnitOfRadarRadiation hostUnitOfRadarRadiation = new Contact.HostUnitOfRadarRadiation();
					IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							XmlNode xmlNode = (XmlNode)enumerator.Current;
							string name = xmlNode.Name;
							if (Operators.CompareString(name, "UID", false) != 0)
							{
								if (Operators.CompareString(name, "IDS", false) != 0)
								{
									if (Operators.CompareString(name, "RA", false) == 0)
									{
										hostUnitOfRadarRadiation.RA = XmlConvert.ToSingle(xmlNode.InnerText);
									}
								}
								else
								{
									hostUnitOfRadarRadiation.identificationStatus = (Contact_Base.IdentificationStatus)Conversions.ToShort(xmlNode.InnerText);
								}
							}
							else
							{
								hostUnitOfRadarRadiation.UID = xmlNode.InnerText;
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
					result = hostUnitOfRadarRadiation;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101314", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x04001ECC RID: 7884
			public string UID;

			// Token: 0x04001ECD RID: 7885
			public Contact_Base.IdentificationStatus identificationStatus;

			// Token: 0x04001ECE RID: 7886
			public float RA;
		}

		// Token: 0x020009B8 RID: 2488
		[CompilerGenerated]
		public sealed class Attacker
		{
			// Token: 0x0600423B RID: 16955 RVA: 0x00180C6C File Offset: 0x0017EE6C
			internal float BearingRelativeToTarget(GeoPoint geoPoint_)
			{
				return Class263.RelativeBearingTo(this.TargetAzimuth, Math2.GetAzimuth(this.Location.Latitude, this.Location.Longitude, geoPoint_.GetLatitude(), geoPoint_.GetLongitude()));
			}

			// Token: 0x04001ECF RID: 7887
			public float TargetAzimuth;

			// Token: 0x04001ED0 RID: 7888
			public Contact.GeoLocation Location;
		}

		// Token: 0x020009B9 RID: 2489
		[CompilerGenerated]
		public sealed class GeoLocation
		{
			// Token: 0x04001ED1 RID: 7889
			public double Latitude;

			// Token: 0x04001ED2 RID: 7890
			public double Longitude;
		}

		// Token: 0x020009BA RID: 2490
		[CompilerGenerated]
		public sealed class AngularDistanceToUnit
		{
			// Token: 0x0600423E RID: 16958 RVA: 0x00180CB0 File Offset: 0x0017EEB0
			internal double GetAngularDistance(GeoPoint position)
			{
				Unit unit = this.unit;
				double latitude = position.GetLatitude();
				double longitude = position.GetLongitude();
				double approxAngularDistanceInDegrees = unit.GetApproxAngularDistanceInDegrees(ref latitude, ref longitude);
				position.SetLongitude(longitude);
				position.SetLatitude(latitude);
				return approxAngularDistanceInDegrees;
			}

			// Token: 0x04001ED3 RID: 7891
			public Unit unit;
		}
	}
}
