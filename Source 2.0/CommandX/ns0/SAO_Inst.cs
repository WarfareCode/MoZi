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
	// Token: 0x02000A1A RID: 2586
	public sealed class SAO_Inst : ScenAttachmentObject
	{
		// Token: 0x06005078 RID: 20600 RVA: 0x00025A88 File Offset: 0x00023C88
		public SAO_Inst(string string_2) : base(string_2)
		{
			this.attachmentObjectType_0 = ScenAttachmentObject.AttachmentObjectType.Inst;
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x00025A98 File Offset: 0x00023C98
		public SAO_Inst()
		{
			this.attachmentObjectType_0 = ScenAttachmentObject.AttachmentObjectType.Inst;
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x0020BC20 File Offset: 0x00209E20
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("SAO_Inst");
				xmlWriter_0.WriteElementString("ID", base.method_0());
				xmlWriter_0.WriteElementString("Desc", this.string_1);
				xmlWriter_0.WriteElementString("IFN", this.InstFileName);
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101302", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600507B RID: 20603 RVA: 0x0020BCC0 File Offset: 0x00209EC0
		public static SAO_Inst Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			SAO_Inst result;
			try
			{
				SAO_Inst sAO_Inst = new SAO_Inst();
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
								if (Operators.CompareString(name, "IFN", false) == 0)
								{
									sAO_Inst.InstFileName = xmlNode.InnerText;
								}
							}
							else
							{
								sAO_Inst.string_1 = xmlNode.InnerText;
							}
						}
						else
						{
							sAO_Inst.string_0 = xmlNode.InnerText;
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
				result = sAO_Inst;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101303", "");
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

		// Token: 0x0600507C RID: 20604 RVA: 0x0020BDE4 File Offset: 0x00209FE4
		public override void vmethod_0(string string_2)
		{
			if (!Directory.Exists(GameGeneral.strAttachmentRepoDir))
			{
				Directory.CreateDirectory(GameGeneral.strAttachmentRepoDir);
			}
			Directory.CreateDirectory(Path.Combine(GameGeneral.strAttachmentRepoDir, base.method_0()));
			File.Copy(string_2, Path.Combine(GameGeneral.strAttachmentRepoDir, base.method_0(), this.InstFileName), true);
		}

		// Token: 0x0600507D RID: 20605 RVA: 0x00025AA7 File Offset: 0x00023CA7
		public override bool vmethod_3(Scenario scenario_0)
		{
			return this.vmethod_4(scenario_0, scenario_0.GetCurrentSide());
		}

		// Token: 0x0600507E RID: 20606 RVA: 0x00025AB6 File Offset: 0x00023CB6
		public override bool vmethod_4(Scenario scenario_, Side side_)
		{
			scenario_.ImportUnits(Path.Combine(GameGeneral.strAttachmentRepoDir, base.method_0(), this.InstFileName), side_);
			return true;
		}

		// Token: 0x0600507F RID: 20607 RVA: 0x0020BE3C File Offset: 0x0020A03C
		public override void vmethod_2(string string_2)
		{
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.Indent = true;
			xmlWriterSettings.IndentChars = "    ";
			XmlWriter xmlWriter = XmlWriter.Create(Path.Combine(string_2, "desc.xml"), xmlWriterSettings);
			xmlWriter.WriteStartElement("Attachment");
			xmlWriter.WriteElementString("Type", Conversions.ToString((int)this.attachmentObjectType_0));
			xmlWriter.WriteElementString("Desc", this.string_1);
			xmlWriter.WriteElementString("IFN", this.InstFileName);
			xmlWriter.WriteEndElement();
			xmlWriter.Close();
		}

		// Token: 0x040025DA RID: 9690
		[Attribute0]
		public string InstFileName;
	}
}
