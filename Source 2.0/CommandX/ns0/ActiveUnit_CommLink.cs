using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns0
{
	// Token: 0x02000A25 RID: 2597
	public sealed class ActiveUnit_CommLink : Subject
	{
		// Token: 0x060050CE RID: 20686 RVA: 0x0020DCF8 File Offset: 0x0020BEF8
		public void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				if (!Information.IsNothing(this.CommPartner))
				{
					xmlWriter_0.WriteStartElement("CommLink");
					xmlWriter_0.WriteElementString("ID", base.GetGuid());
					xmlWriter_0.WriteElementString("CommPartner", this.CommPartner.GetGuid());
					xmlWriter_0.WriteStartElement("DeviceUsed");
					this.DeviceUsed.Save(ref xmlWriter_0, ref hashSet_0, scenario_0);
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100997", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060050CF RID: 20687 RVA: 0x0020DDC0 File Offset: 0x0020BFC0
		public static ActiveUnit_CommLink Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			ActiveUnit_CommLink result;
			try
			{
				ActiveUnit_CommLink activeUnit_CommLink = new ActiveUnit_CommLink();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "CommPartner", false) != 0)
							{
								if (Operators.CompareString(name, "DeviceUsed", false) == 0)
								{
									ActiveUnit_CommLink activeUnit_CommLink2 = activeUnit_CommLink;
									XmlNode xmlNode2 = xmlNode.ChildNodes[0];
									activeUnit_CommLink2.DeviceUsed = CommDevice.Load(ref xmlNode2, ref dictionary_0, activeUnit_1);
								}
							}
							else
							{
								activeUnit_CommLink.CommPartnerName = xmlNode.InnerText;
							}
						}
						else
						{
							activeUnit_CommLink.SetGuid(xmlNode.InnerText);
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
				result = activeUnit_CommLink;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100998", "");
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

		// Token: 0x060050D0 RID: 20688 RVA: 0x00025C92 File Offset: 0x00023E92
		private ActiveUnit_CommLink()
		{
		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x00025CA5 File Offset: 0x00023EA5
		public ActiveUnit_CommLink(ref ActiveUnit activeUnit_1, ref CommDevice commDevice_1)
		{
			this.CommPartner = activeUnit_1;
			this.DeviceUsed = commDevice_1;
		}

		// Token: 0x060050D2 RID: 20690 RVA: 0x00025CC8 File Offset: 0x00023EC8
		public void SetCommPartner(ref Dictionary<string, Subject> dictionary_0)
		{
			this.CommPartner = (ActiveUnit)dictionary_0[this.CommPartnerName];
		}

		// Token: 0x040025FE RID: 9726
		public ActiveUnit CommPartner;

		// Token: 0x040025FF RID: 9727
		public string CommPartnerName = "";

		// Token: 0x04002600 RID: 9728
		public CommDevice DeviceUsed;
	}
}
