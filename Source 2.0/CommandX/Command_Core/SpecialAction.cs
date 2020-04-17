using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace Command_Core
{
	// 特别行动
	public sealed class SpecialAction : Subject
	{
		// Token: 0x0600536C RID: 21356 RVA: 0x002226E8 File Offset: 0x002208E8
		public void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("SpecialAction");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("Description", this.Description);
				xmlWriter_0.WriteElementString("IsRepeatable", this.IsRepeatable.ToString());
				xmlWriter_0.WriteElementString("IsActive", this.IsActive.ToString());
				xmlWriter_0.WriteElementString("ScriptText", this.ScriptText);
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

		// Token: 0x0600536D RID: 21357 RVA: 0x002227C4 File Offset: 0x002209C4
		public static SpecialAction Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			SpecialAction result = null;
			try
			{
				SpecialAction specialAction = new SpecialAction();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "Name", false) != 0)
							{
								if (Operators.CompareString(name, "Description", false) != 0)
								{
									if (Operators.CompareString(name, "IsRepeatable", false) != 0)
									{
										if (Operators.CompareString(name, "IsActive", false) != 0)
										{
											if (Operators.CompareString(name, "ScriptText", false) == 0)
											{
												specialAction.ScriptText = xmlNode.InnerText;
											}
										}
										else
										{
											specialAction.IsActive = Conversions.ToBoolean(xmlNode.InnerText);
										}
									}
									else
									{
										specialAction.IsRepeatable = Conversions.ToBoolean(xmlNode.InnerText);
									}
								}
								else
								{
									specialAction.Description = xmlNode.InnerText;
								}
							}
							else
							{
								specialAction.Name = xmlNode.InnerText;
							}
						}
						else
						{
							specialAction.SetGuid(xmlNode.InnerText);
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
				result = specialAction;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101324", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x00026B16 File Offset: 0x00024D16
		public SpecialAction()
		{
			this.IsActive = true;
			this.IsRepeatable = false;
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x00222974 File Offset: 0x00220B74
		public string Execute(Scenario scenario)
		{
			string result = "";
			try
			{
				if (!this.IsRepeatable)
				{
					this.IsActive = false;
				}
				object[] array = scenario.GetLuaSandBox().RunScript(this.ScriptText, false, this.Name);
				if (Information.IsNothing(array))
				{
					result = "特殊事件 '" + this.Name + "'已被执行。";
				}
				else
				{
					result = array[0].ToString();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101325", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005370 RID: 21360 RVA: 0x00222A30 File Offset: 0x00220C30
		public SpecialAction Clone()
		{
			SpecialAction specialAction = (SpecialAction)base.MemberwiseClone();
			specialAction.SetGuid(Guid.NewGuid().ToString());
			specialAction.Description = "[CLONE] " + this.Description;
			specialAction.Name = "[CLONE] " + this.Name;
			return specialAction;
		}

		// Token: 0x0400271D RID: 10013
		public string Description = "";

		// Token: 0x0400271E RID: 10014
		public bool IsActive;

		// Token: 0x0400271F RID: 10015
		public bool IsRepeatable;

		// Token: 0x04002720 RID: 10016
		public string ScriptText = "";
	}
}
