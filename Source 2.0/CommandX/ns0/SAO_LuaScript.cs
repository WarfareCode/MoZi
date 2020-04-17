using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace ns0
{
	// Token: 0x02000A1C RID: 2588
	public sealed class SAO_LuaScript : ScenAttachmentObject
	{
		// Token: 0x0600508B RID: 20619 RVA: 0x00025B49 File Offset: 0x00023D49
		public SAO_LuaScript(string string_2) : base(string_2)
		{
			this.attachmentObjectType_0 = ScenAttachmentObject.AttachmentObjectType.LuaScript;
		}

		// Token: 0x0600508C RID: 20620 RVA: 0x00025B59 File Offset: 0x00023D59
		public SAO_LuaScript()
		{
			this.attachmentObjectType_0 = ScenAttachmentObject.AttachmentObjectType.LuaScript;
		}

		// Token: 0x0600508D RID: 20621 RVA: 0x0020C238 File Offset: 0x0020A438
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("SAO_LuaScript");
				xmlWriter_0.WriteElementString("ID", base.method_0());
				xmlWriter_0.WriteElementString("Desc", this.string_1);
				xmlWriter_0.WriteElementString("SFN", this.ScriptFileName);
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101306", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x0020C2D8 File Offset: 0x0020A4D8
		public static SAO_LuaScript Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			SAO_LuaScript result = null;
			try
			{
				SAO_LuaScript sAO_LuaScript = new SAO_LuaScript();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "Desc", false) != 0)
							{
								if (Operators.CompareString(name, "SFN", false) == 0)
								{
									sAO_LuaScript.ScriptFileName = xmlNode.InnerText;
								}
							}
							else
							{
								sAO_LuaScript.string_1 = xmlNode.InnerText;
							}
						}
						else
						{
							sAO_LuaScript.string_0 = xmlNode.InnerText;
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
				result = sAO_LuaScript;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101307", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600508F RID: 20623 RVA: 0x0020C3FC File Offset: 0x0020A5FC
		public override void vmethod_0(string string_2)
		{
			if (!Directory.Exists(GameGeneral.strAttachmentRepoDir))
			{
				Directory.CreateDirectory(GameGeneral.strAttachmentRepoDir);
			}
			Directory.CreateDirectory(Path.Combine(GameGeneral.strAttachmentRepoDir, base.method_0()));
			File.Copy(string_2, Path.Combine(GameGeneral.strAttachmentRepoDir, base.method_0(), this.ScriptFileName), true);
		}

		// Token: 0x06005090 RID: 20624 RVA: 0x00025B68 File Offset: 0x00023D68
		public override bool vmethod_3(Scenario scenario_0)
		{
			scenario_0.GetLuaSandBox().LUA_ScenEdit_RunScript(Path.Combine(GameGeneral.strAttachmentRepoDir, base.method_0(), this.ScriptFileName));
			return true;
		}

		// Token: 0x06005091 RID: 20625 RVA: 0x0020C454 File Offset: 0x0020A654
		public override void vmethod_2(string string_2)
		{
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.Indent = true;
			xmlWriterSettings.IndentChars = "    ";
			XmlWriter xmlWriter = XmlWriter.Create(Path.Combine(string_2, "desc.xml"), xmlWriterSettings);
			xmlWriter.WriteStartElement("Attachment");
			xmlWriter.WriteElementString("Type", Conversions.ToString((int)this.attachmentObjectType_0));
			xmlWriter.WriteElementString("Desc", this.string_1);
			xmlWriter.WriteElementString("SFN", this.ScriptFileName);
			xmlWriter.WriteEndElement();
			xmlWriter.Close();
		}

		// Token: 0x040025DE RID: 9694
		[Attribute0]
		public string ScriptFileName;
	}
}
