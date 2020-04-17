using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace ns2
{
	// Token: 0x02000B07 RID: 2823
	public sealed class CIC : PlatformComponent
	{
		// Token: 0x06005AEA RID: 23274 RVA: 0x00286DB0 File Offset: 0x00284FB0
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("CIC");
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
					xmlWriter_0.WriteElementString("DamageSeverity", ((byte)base.GetDamageSeverity()).ToString());
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100660", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005AEB RID: 23275 RVA: 0x00286EA8 File Offset: 0x002850A8
		public static CIC Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0)
		{
			CIC cIC = null;
			CIC result;
			try
			{
				CIC cIC2 = new CIC("");
				IEnumerator enumerator = xmlNode_0.ChildNodes[0].ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "Status", false) != 0)
							{
								if (Operators.CompareString(name, "Name", false) != 0)
								{
									if (Operators.CompareString(name, "DamageSeverity", false) == 0)
									{
										cIC2.SetDamageSeverity((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode.InnerText));
									}
								}
								else
								{
									cIC2.Name = xmlNode.InnerText;
								}
							}
							else
							{
								string innerText = xmlNode.InnerText;
								if (Operators.CompareString(innerText, "Operational", false) != 0)
								{
									if (Operators.CompareString(innerText, "Damaged", false) != 0)
									{
										if (Operators.CompareString(innerText, "Destroyed", false) != 0)
										{
											cIC2.m_ComponentStatus = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode.InnerText);
										}
										else
										{
											cIC2.m_ComponentStatus = PlatformComponent._ComponentStatus.Destroyed;
										}
									}
									else
									{
										cIC2.m_ComponentStatus = PlatformComponent._ComponentStatus.Damaged;
									}
								}
								else
								{
									cIC2.m_ComponentStatus = PlatformComponent._ComponentStatus.Operational;
								}
							}
						}
						else
						{
							if (dictionary_0.ContainsKey(xmlNode.InnerText))
							{
								cIC = (CIC)dictionary_0[xmlNode.InnerText];
								result = cIC;
								return result;
							}
							cIC2.SetGuid(xmlNode.InnerText);
							dictionary_0.Add(cIC2.GetGuid(), cIC2);
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
				cIC = cIC2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100661", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = cIC;
			return result;
		}

		// Token: 0x06005AEC RID: 23276 RVA: 0x00028CD5 File Offset: 0x00026ED5
		private CIC(string string_2)
		{
		}

		// Token: 0x06005AED RID: 23277 RVA: 0x00028CDD File Offset: 0x00026EDD
		public CIC(ActiveUnit activeUnit_1, string string_2) : base(activeUnit_1)
		{
			this.Name = string_2;
		}
	}
}
