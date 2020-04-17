using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns1
{
	// Token: 0x02000A49 RID: 2633
	public sealed class EventTrigger_UnitDetected : EventTrigger
	{
		// Token: 0x060053AD RID: 21421 RVA: 0x002246A4 File Offset: 0x002228A4
		public bool method_11(ActiveUnit activeUnit_1, Side side_0, bool bool_8, Contact_Base.IdentificationStatus identificationStatus_1, Contact_Base.IdentificationStatus? nullable_0)
		{
			bool result;
			if (identificationStatus_1 < this.identificationStatus)
			{
				result = false;
			}
			else
			{
				bool flag;
				if (Operators.CompareString(this.DetectorSideID, side_0.GetGuid(), false) != 0)
				{
					flag = false;
				}
				else if (!this.m_DetectedUnit.method_12(activeUnit_1))
				{
					flag = false;
				}
				else if (bool_8)
				{
					flag = true;
				}
				else if (this.identificationStatus > Contact_Base.IdentificationStatus.Unknown)
				{
					if (!Information.IsNothing(nullable_0))
					{
						short? num = nullable_0.HasValue ? new short?((short)nullable_0.GetValueOrDefault()) : null;
						if (!(num.HasValue ? new bool?(num.GetValueOrDefault() == (short)identificationStatus_1) : null).GetValueOrDefault())
						{
							num = (nullable_0.HasValue ? new short?((short)nullable_0.GetValueOrDefault()) : null);
							short num2 = (short)this.identificationStatus;
							flag = !(num.HasValue ? new bool?(num.GetValueOrDefault() >= num2) : null).GetValueOrDefault();
							goto IL_133;
						}
					}
					flag = false;
				}
				else
				{
					flag = true;
				}
				IL_133:
				if (flag)
				{
					this.activeUnit_0 = activeUnit_1;
					activeUnit_1.m_Scenario.GetLuaSandBox().UnitX = activeUnit_1;
				}
				else
				{
					this.activeUnit_0 = null;
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060053AE RID: 21422 RVA: 0x00026C22 File Offset: 0x00024E22
		public EventTrigger_UnitDetected()
		{
			this.m_DetectedUnit = new Target();
			this.identificationStatus = Contact_Base.IdentificationStatus.Unknown;
			this.eventTriggerType = EventTrigger.EventTriggerType.UnitDetected;
		}

		// Token: 0x060053AF RID: 21423 RVA: 0x00224810 File Offset: 0x00222A10
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventTrigger_UnitDetected");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteStartElement("TargetFilter");
				this.m_DetectedUnit.Save(xmlWriter_0, hashSet_0, scenario_0);
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteElementString("DetectorSideID", this.DetectorSideID);
				string localName = "MCL";
				short num = (short)this.identificationStatus;
				xmlWriter_0.WriteElementString(localName, num.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100530", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x002248EC File Offset: 0x00222AEC
		public static EventTrigger_UnitDetected Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			EventTrigger_UnitDetected result = null;
			try
			{
				EventTrigger_UnitDetected eventTrigger_UnitDetected = new EventTrigger_UnitDetected();
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
								if (Operators.CompareString(name, "TargetFilter", false) != 0)
								{
									if (Operators.CompareString(name, "DetectorSideID", false) != 0)
									{
										if (Operators.CompareString(name, "MCL", false) == 0)
										{
											eventTrigger_UnitDetected.identificationStatus = (Contact_Base.IdentificationStatus)Conversions.ToShort(xmlNode.InnerText);
										}
									}
									else
									{
										eventTrigger_UnitDetected.DetectorSideID = xmlNode.InnerText;
									}
								}
								else
								{
									eventTrigger_UnitDetected.m_DetectedUnit = Target.Load(xmlNode, dictionary_0, scenario_0);
								}
							}
							else
							{
								eventTrigger_UnitDetected.strDescription = xmlNode.InnerText;
							}
						}
						else
						{
							eventTrigger_UnitDetected.SetGuid(xmlNode.InnerText);
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
				result = eventTrigger_UnitDetected;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100531", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new EventTrigger_UnitDetected();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x00224A7C File Offset: 0x00222C7C
		public override EventTrigger Clone()
		{
			EventTrigger_UnitDetected eventTrigger_UnitDetected = (EventTrigger_UnitDetected)base.MemberwiseClone();
			eventTrigger_UnitDetected.SetGuid(Guid.NewGuid().ToString());
			eventTrigger_UnitDetected.strDescription = "[CLONE] " + this.strDescription;
			eventTrigger_UnitDetected.Name = "[CLONE] " + this.Name;
			return eventTrigger_UnitDetected;
		}

		// Token: 0x04002752 RID: 10066
		public Target m_DetectedUnit;

		// Token: 0x04002753 RID: 10067
		public string DetectorSideID = "";

		// Token: 0x04002754 RID: 10068
		public Contact_Base.IdentificationStatus identificationStatus;

		// Token: 0x04002755 RID: 10069
		public ActiveUnit activeUnit_0;
	}
}
