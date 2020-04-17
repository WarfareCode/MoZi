using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns1
{
	// Token: 0x02000A46 RID: 2630
	public sealed class EventTrigger_RandomTime : EventTrigger
	{
		// Token: 0x060053A1 RID: 21409 RVA: 0x00224038 File Offset: 0x00222238
		public DateTime method_11()
		{
			if (!this.nullable_0.HasValue)
			{
				if (this.LatestTime.Ticks < this.EarliestTime.Ticks)
				{
					double totalSeconds = new TimeSpan(this.EarliestTime.Ticks - this.LatestTime.Ticks).TotalSeconds;
					this.nullable_0 = new DateTime?(this.LatestTime.AddSeconds((double)GameGeneral.GetRandom().Next(0, (int)Math.Round(totalSeconds))));
				}
				else
				{
					double totalSeconds = new TimeSpan(this.LatestTime.Ticks - this.EarliestTime.Ticks).TotalSeconds;
					this.nullable_0 = new DateTime?(this.EarliestTime.AddSeconds((double)GameGeneral.GetRandom().Next(0, (int)Math.Round(totalSeconds))));
				}
			}
			return this.nullable_0.Value;
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x00224120 File Offset: 0x00222320
		public bool method_12(DateTime dateTime_2)
		{
			return this.method_11().CompareTo(dateTime_2) <= 0;
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x00026BE6 File Offset: 0x00024DE6
		public EventTrigger_RandomTime(DateTime dateTime_2, DateTime dateTime_3)
		{
			this.eventTriggerType = EventTrigger.EventTriggerType.RandomTime;
			this.EarliestTime = dateTime_2;
			this.LatestTime = dateTime_3;
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x00026C03 File Offset: 0x00024E03
		private EventTrigger_RandomTime()
		{
			this.eventTriggerType = EventTrigger.EventTriggerType.RandomTime;
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x00224144 File Offset: 0x00222344
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventTrigger_RandomTime");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteElementString("EarliestTime", this.EarliestTime.ToBinary().ToString());
				xmlWriter_0.WriteElementString("LatestTime", this.LatestTime.ToBinary().ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100522", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x00224210 File Offset: 0x00222410
		public static EventTrigger_RandomTime Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventTrigger_RandomTime result;
			try
			{
				EventTrigger_RandomTime eventTrigger_RandomTime = new EventTrigger_RandomTime();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "Description", false) != 0)
							{
								if (Operators.CompareString(name, "EarliestTime", false) != 0)
								{
									if (Operators.CompareString(name, "LatestTime", false) == 0)
									{
										eventTrigger_RandomTime.LatestTime = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
									}
								}
								else
								{
									eventTrigger_RandomTime.EarliestTime = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
								}
							}
							else
							{
								eventTrigger_RandomTime.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventTrigger_RandomTime.SetGuid(xmlNode.InnerText);
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
				result = eventTrigger_RandomTime;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100523", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new EventTrigger_RandomTime();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060053A7 RID: 21415 RVA: 0x00224370 File Offset: 0x00222570
		public override EventTrigger Clone()
		{
			EventTrigger_RandomTime eventTrigger_RandomTime = (EventTrigger_RandomTime)base.MemberwiseClone();
			eventTrigger_RandomTime.SetGuid(Guid.NewGuid().ToString());
			eventTrigger_RandomTime.strDescription = "[CLONE] " + this.strDescription;
			eventTrigger_RandomTime.Name = "[CLONE] " + this.Name;
			return eventTrigger_RandomTime;
		}

		// Token: 0x04002744 RID: 10052
		public DateTime EarliestTime;

		// Token: 0x04002745 RID: 10053
		public DateTime LatestTime;

		// Token: 0x04002746 RID: 10054
		private DateTime? nullable_0;
	}
}
