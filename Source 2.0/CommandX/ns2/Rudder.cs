using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace ns2
{
	// Token: 0x02000B1A RID: 2842
	public sealed class Rudder : PlatformComponent
	{
		// Token: 0x06005B86 RID: 23430 RVA: 0x0028E998 File Offset: 0x0028CB98
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Rudder");
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
					xmlWriter_0.WriteElementString("DamageSeverity", ((byte)base.GetDamageSeverity()).ToString());
					xmlWriter_0.WriteElementString("Name", this.Name);
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100691", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B87 RID: 23431 RVA: 0x0028EA90 File Offset: 0x0028CC90
		public static Rudder Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0)
		{
			Rudder result;
			try
			{
				Rudder rudder = new Rudder();
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
										rudder.SetDamageSeverity((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode.InnerText));
									}
								}
								else
								{
									rudder.Name = xmlNode.InnerText;
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
											rudder.m_ComponentStatus = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode.InnerText);
										}
										else
										{
											rudder.m_ComponentStatus = PlatformComponent._ComponentStatus.Destroyed;
										}
									}
									else
									{
										rudder.m_ComponentStatus = PlatformComponent._ComponentStatus.Damaged;
									}
								}
								else
								{
									rudder.m_ComponentStatus = PlatformComponent._ComponentStatus.Operational;
								}
							}
						}
						else
						{
							rudder.SetGuid(xmlNode.InnerText);
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
				result = rudder;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100692", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Rudder();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005B88 RID: 23432 RVA: 0x00029056 File Offset: 0x00027256
		private Rudder()
		{
			this.Name = "Rudder";
		}

		// Token: 0x06005B89 RID: 23433 RVA: 0x00029069 File Offset: 0x00027269
		public Rudder(ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
			this.Name = "Rudder";
		}
	}
}
