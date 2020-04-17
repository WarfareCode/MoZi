using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace Command_Core
{
	// 武器碰撞
	public sealed class WeaponImpact : Unit
	{
		// 构造函数
		public WeaponImpact(ref Scenario scenario_0, double double_2, double double_3, float float_7, WeaponImpact._WeaponImpactType enum85_1)
		{
			this.SetLongitude(null, double_2);
			this.SetLatitude(null, double_3);
			this.SetAltitude_ASL(false, float_7);
			this.ImpactType = enum85_1;
			scenario_0.GetWeaponImpacts().Add(this);
		}

		// 保存
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("WeaponImpact");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (hashSet_0.Contains(base.GetGuid()))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(base.GetGuid());
					xmlWriter_0.WriteElementString("Name", this.Name);
					xmlWriter_0.WriteElementString("CurrentHeading", XmlConvert.ToString(this.GetCurrentHeading()));
					xmlWriter_0.WriteElementString("CurrentSpeed", XmlConvert.ToString(this.GetCurrentSpeed()));
					xmlWriter_0.WriteElementString("CurrentAltitude", XmlConvert.ToString(this.GetCurrentAltitude_ASL(false)));
					xmlWriter_0.WriteElementString("Longitude", XmlConvert.ToString(this.GetLongitude(null)));
					xmlWriter_0.WriteElementString("Latitude", XmlConvert.ToString(this.GetLatitude(null)));
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Type";
					short impactType = (short)this.ImpactType;
					xmlWriter.WriteElementString(localName, impactType.ToString());
					xmlWriter_0.WriteStartElement("RangeSymbols");
					using (List<RangeSymbol>.Enumerator enumerator = base.GetRangeSymbols().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.Save(ref xmlWriter_0);
						}
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteElementString("Message", this.Message);
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101328", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x000214EC File Offset: 0x0001F6EC
		private WeaponImpact()
		{
		}

		// Token: 0x0600617B RID: 24955 RVA: 0x002F1234 File Offset: 0x002EF434
		public static WeaponImpact smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0)
		{
			WeaponImpact weaponImpact = null;
			WeaponImpact result;
			try
			{
				WeaponImpact weaponImpact2 = new WeaponImpact();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1836990821u)
						{
							if (num <= 441941816u)
							{
								if (num != 266367750u)
								{
									if (num == 441941816u && Operators.CompareString(name, "CurrentAltitude", false) == 0)
									{
										weaponImpact2.SetAltitude_ASL(false, XmlConvert.ToSingle(xmlNode.InnerText));
									}
								}
								else if (Operators.CompareString(name, "Name", false) == 0)
								{
									weaponImpact2.Name = xmlNode.InnerText;
								}
							}
							else if (num != 1458105184u)
							{
								if (num != 1729717486u)
								{
									if (num == 1836990821u && Operators.CompareString(name, "Latitude", false) == 0)
									{
										weaponImpact2.SetLatitude(null, XmlConvert.ToDouble(xmlNode.InnerText));
									}
								}
								else if (Operators.CompareString(name, "Longitude", false) == 0)
								{
									weaponImpact2.SetLongitude(null, XmlConvert.ToDouble(xmlNode.InnerText));
								}
							}
							else if (Operators.CompareString(name, "ID", false) == 0)
							{
								if (dictionary_0.ContainsKey(xmlNode.InnerText))
								{
									weaponImpact = (WeaponImpact)dictionary_0[xmlNode.InnerText];
									result = weaponImpact;
									return result;
								}
								weaponImpact2.SetGuid(xmlNode.InnerText);
								dictionary_0.Add(weaponImpact2.GetGuid(), weaponImpact2);
							}
						}
						else
						{
							if (num <= 2920208772u)
							{
								if (num != 2496321123u)
								{
									if (num == 2920208772u && Operators.CompareString(name, "Message", false) == 0)
									{
										weaponImpact2.Message = xmlNode.InnerText;
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "RangeSymbols", false) != 0)
									{
										continue;
									}
									IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator2.MoveNext())
										{
											RangeSymbol item = RangeSymbol.Load((XmlNode)enumerator2.Current, dictionary_0);
											weaponImpact2.GetRangeSymbols().Add(item);
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
							if (num != 3283119613u)
							{
								if (num != 3512062061u)
								{
									if (num == 4152621540u && Operators.CompareString(name, "CurrentHeading", false) == 0)
									{
										weaponImpact2.SetCurrentHeading((float)XmlConvert.ToDouble(xmlNode.InnerText));
									}
								}
								else if (Operators.CompareString(name, "Type", false) == 0)
								{
									if (xmlNode.InnerText.Contains("Kinetic"))
									{
										weaponImpact2.ImpactType = WeaponImpact._WeaponImpactType.Airburst;
									}
									else
									{
										weaponImpact2.ImpactType = (WeaponImpact._WeaponImpactType)Conversions.ToShort(xmlNode.InnerText);
									}
								}
							}
							else if (Operators.CompareString(name, "CurrentSpeed", false) == 0)
							{
								weaponImpact2.SetCurrentSpeed((float)XmlConvert.ToDouble(xmlNode.InnerText));
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
				weaponImpact = weaponImpact2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100880", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = weaponImpact;
			return result;
		}

		// Token: 0x0600617C RID: 24956 RVA: 0x002F1644 File Offset: 0x002EF844
		public static void ExportWeaponImpact(Unit unit_0, Scenario scenario_0)
		{
			foreach (IEventExporter current in scenario_0.GetEventExporters())
			{
				if (current.imethod_30())
				{
					Dictionary<string, Tuple<Type, string>> dictionary = new Dictionary<string, Tuple<Type, string>>();
					dictionary.Add("TimelineID", new Tuple<Type, string>(typeof(string), scenario_0.TimelineID));
					if (current.IsUseZeroHour())
					{
						TimeSpan timeSpan = scenario_0.GetCurrentTime(false).Subtract(scenario_0.ZeroHour);
						dictionary.Add("Time", new Tuple<Type, string>(typeof(TimeSpan), timeSpan.ToString("c")));
					}
					else
					{
						dictionary.Add("Time", new Tuple<Type, string>(typeof(DateTime), scenario_0.GetCurrentTime(false).ToString("MM/dd/yyyy HH:mm:ss") + "." + scenario_0.GetCurrentTime(false).Millisecond.ToString("D3")));
					}
					dictionary.Add("UnitID", new Tuple<Type, string>(typeof(string), unit_0.GetGuid()));
					dictionary.Add("UnitLongitude", new Tuple<Type, string>(typeof(double), unit_0.GetLongitude(null).ToString()));
					dictionary.Add("UnitLatitude", new Tuple<Type, string>(typeof(double), unit_0.GetLatitude(null).ToString()));
					dictionary.Add("UnitCourse", new Tuple<Type, string>(typeof(float), unit_0.GetCurrentHeading().ToString()));
					dictionary.Add("UnitSpeed_kts", new Tuple<Type, string>(typeof(float), unit_0.GetCurrentSpeed().ToString()));
					dictionary.Add("UnitAltitude_m", new Tuple<Type, string>(typeof(float), unit_0.GetCurrentAltitude_ASL(false).ToString()));
					current.ExportEvent(ExportedEventType.WeaponImpact, dictionary, scenario_0);
				}
			}
		}

		// Token: 0x0400346B RID: 13419
		public WeaponImpact._WeaponImpactType ImpactType;

		// Token: 0x02000B83 RID: 2947
		public enum _WeaponImpactType : short
		{			
			Airburst,// 空爆                    
            const_1 // Token: 0x0400346E RID: 13422
		}
	}
}
