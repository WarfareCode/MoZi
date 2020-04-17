using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace ns0
{
	// Token: 0x02000A1B RID: 2587
	public sealed class SAO_LocalVideo : ScenAttachmentObject
	{
		// Token: 0x06005080 RID: 20608 RVA: 0x00025AD7 File Offset: 0x00023CD7
		public SAO_LocalVideo(string string_2) : base(string_2)
		{
			this.bool_0 = true;
			this.attachmentObjectType_0 = ScenAttachmentObject.AttachmentObjectType.LocalVideo;
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x00025AEE File Offset: 0x00023CEE
		public SAO_LocalVideo()
		{
			this.bool_0 = true;
			this.attachmentObjectType_0 = ScenAttachmentObject.AttachmentObjectType.LocalVideo;
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x00025B04 File Offset: 0x00023D04
		public bool method_3()
		{
			return this.bool_0;
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x00025B0C File Offset: 0x00023D0C
		public void method_4(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x0020BEC4 File Offset: 0x0020A0C4
		public int method_5()
		{
			return this.int_0;
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x00025B15 File Offset: 0x00023D15
		public void method_6(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x0020BEDC File Offset: 0x0020A0DC
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("SAO_LocalVideo");
				xmlWriter_0.WriteElementString("ID", base.method_0());
				xmlWriter_0.WriteElementString("Desc", this.string_1);
				xmlWriter_0.WriteElementString("VFN", this.VideoFileName);
				if (this.method_3())
				{
					xmlWriter_0.WriteElementString("FS", this.method_3().ToString());
				}
				if (this.method_5() > 0)
				{
					xmlWriter_0.WriteElementString("Delay", this.method_5().ToString());
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101304", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x0020BFC8 File Offset: 0x0020A1C8
		public static SAO_LocalVideo Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			SAO_LocalVideo result;
			try
			{
				SAO_LocalVideo sAO_LocalVideo = new SAO_LocalVideo();
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
								if (Operators.CompareString(name, "VFN", false) != 0)
								{
									if (Operators.CompareString(name, "FS", false) != 0)
									{
										if (Operators.CompareString(name, "Delay", false) == 0)
										{
											sAO_LocalVideo.method_6(Conversions.ToInteger(xmlNode.InnerText));
										}
									}
									else
									{
										sAO_LocalVideo.method_4(Conversions.ToBoolean(xmlNode.InnerText));
									}
								}
								else
								{
									sAO_LocalVideo.VideoFileName = xmlNode.InnerText;
								}
							}
							else
							{
								sAO_LocalVideo.string_1 = xmlNode.InnerText;
							}
						}
						else
						{
							sAO_LocalVideo.string_0 = xmlNode.InnerText;
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
				result = sAO_LocalVideo;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101305", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new SAO_LocalVideo();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x0020C158 File Offset: 0x0020A358
		public  void vmethod_0(string string_2)
		{
			if (!Directory.Exists(GameGeneral.strAttachmentRepoDir))
			{
				Directory.CreateDirectory(GameGeneral.strAttachmentRepoDir);
			}
			Directory.CreateDirectory(Path.Combine(GameGeneral.strAttachmentRepoDir, base.method_0()));
			File.Copy(string_2, Path.Combine(GameGeneral.strAttachmentRepoDir, base.method_0(), this.VideoFileName), true);
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x00025B1E File Offset: 0x00023D1E
		public  bool vmethod_3(Scenario scenario_0)
		{
			PrivateMethods.smethod_18(Path.Combine(GameGeneral.strAttachmentRepoDir, base.method_0(), this.VideoFileName), this.method_3(), this.method_5());
			return true;
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x0020C1B0 File Offset: 0x0020A3B0
		public  void vmethod_2(string string_2)
		{
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.Indent = true;
			xmlWriterSettings.IndentChars = "    ";
			XmlWriter xmlWriter = XmlWriter.Create(Path.Combine(string_2, "desc.xml"), xmlWriterSettings);
			xmlWriter.WriteStartElement("Attachment");
			xmlWriter.WriteElementString("Type", Conversions.ToString((int)this.attachmentObjectType_0));
			xmlWriter.WriteElementString("Desc", this.string_1);
			xmlWriter.WriteElementString("VFN", this.VideoFileName);
			xmlWriter.WriteEndElement();
			xmlWriter.Close();
		}

		// Token: 0x040025DB RID: 9691
		[Attribute0]
		public string VideoFileName;

		// Token: 0x040025DC RID: 9692
		private bool bool_0;

		// Token: 0x040025DD RID: 9693
		private int int_0;
	}
}
