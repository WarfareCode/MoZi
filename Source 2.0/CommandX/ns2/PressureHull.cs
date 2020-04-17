using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace ns2
{
	// Token: 0x02000B19 RID: 2841
	public sealed class PressureHull : PlatformComponent
	{
		// Token: 0x06005B82 RID: 23426 RVA: 0x0028E68C File Offset: 0x0028C88C
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("PressureHull");
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
				ex2.Data.Add("Error at 100689", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B83 RID: 23427 RVA: 0x0028E784 File Offset: 0x0028C984
		public static PressureHull Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0)
		{
			PressureHull pressureHull = null;
			PressureHull result;
			try
			{
				PressureHull pressureHull2 = new PressureHull();
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
										pressureHull2.SetDamageSeverity((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode.InnerText));
									}
								}
								else
								{
									pressureHull2.Name = xmlNode.InnerText;
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
											pressureHull2.m_ComponentStatus = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode.InnerText);
										}
										else
										{
											pressureHull2.m_ComponentStatus = PlatformComponent._ComponentStatus.Destroyed;
										}
									}
									else
									{
										pressureHull2.m_ComponentStatus = PlatformComponent._ComponentStatus.Damaged;
									}
								}
								else
								{
									pressureHull2.m_ComponentStatus = PlatformComponent._ComponentStatus.Operational;
								}
							}
						}
						else
						{
							if (dictionary_0.ContainsKey(xmlNode.InnerText))
							{
								pressureHull = (PressureHull)dictionary_0[xmlNode.InnerText];
								result = pressureHull;
								return result;
							}
							pressureHull2.SetGuid(xmlNode.InnerText);
							dictionary_0.Add(pressureHull2.GetGuid(), pressureHull2);
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
				pressureHull = pressureHull2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100690", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = pressureHull;
			return result;
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x00028CD5 File Offset: 0x00026ED5
		private PressureHull()
		{
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x00028CB5 File Offset: 0x00026EB5
		public PressureHull(ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}
	}
}
