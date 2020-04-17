using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace ns0
{
	// Token: 0x02000A1E RID: 2590
	public sealed class SAO_OverlaySingle : ScenAttachmentObject
	{
		// Token: 0x060050B4 RID: 20660 RVA: 0x0020D068 File Offset: 0x0020B268
		[CompilerGenerated]
		public static void smethod_2(SAO_OverlaySingle.Delegate8 delegate8_1)
		{
			SAO_OverlaySingle.Delegate8 @delegate = SAO_OverlaySingle.delegate8_0;
			SAO_OverlaySingle.Delegate8 delegate2;
			do
			{
				delegate2 = @delegate;
				SAO_OverlaySingle.Delegate8 value = (SAO_OverlaySingle.Delegate8)Delegate.Combine(delegate2, delegate8_1);
				@delegate = Interlocked.CompareExchange<SAO_OverlaySingle.Delegate8>(ref SAO_OverlaySingle.delegate8_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060050B5 RID: 20661 RVA: 0x00025C62 File Offset: 0x00023E62
		public SAO_OverlaySingle(string string_2) : base(string_2)
		{
			this.attachmentObjectType_0 = ScenAttachmentObject.AttachmentObjectType.MapOverlay_SingleImage;
		}

		// Token: 0x060050B6 RID: 20662 RVA: 0x00025C72 File Offset: 0x00023E72
		public SAO_OverlaySingle()
		{
			this.attachmentObjectType_0 = ScenAttachmentObject.AttachmentObjectType.MapOverlay_SingleImage;
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x0020D0A0 File Offset: 0x0020B2A0
		public override void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("SAO_OverlaySingle");
				xmlWriter_0.WriteElementString("ID", base.method_0());
				xmlWriter_0.WriteElementString("Desc", this.string_1);
				xmlWriter_0.WriteElementString("IFN", this.ImageFileName);
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101308", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x0020D140 File Offset: 0x0020B340
		public static SAO_OverlaySingle Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			SAO_OverlaySingle result = null;
			try
			{
				SAO_OverlaySingle sAO_OverlaySingle = new SAO_OverlaySingle();
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
									sAO_OverlaySingle.ImageFileName = xmlNode.InnerText;
								}
							}
							else
							{
								sAO_OverlaySingle.string_1 = xmlNode.InnerText;
							}
						}
						else
						{
							sAO_OverlaySingle.string_0 = xmlNode.InnerText;
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
				result = sAO_OverlaySingle;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101309", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x0020D264 File Offset: 0x0020B464
		public override void vmethod_0(string string_2)
		{
			if (!Directory.Exists(GameGeneral.strAttachmentRepoDir))
			{
				Directory.CreateDirectory(GameGeneral.strAttachmentRepoDir);
			}
			string text = Misc.smethod_1(string_2);
			if (string.IsNullOrEmpty(text))
			{
				Interaction.MsgBox("No suitable geo-reference file found for image!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				Directory.CreateDirectory(Path.Combine(GameGeneral.strAttachmentRepoDir, base.method_0()));
				File.Copy(string_2, Path.Combine(GameGeneral.strAttachmentRepoDir, base.method_0(), this.ImageFileName), true);
				File.Copy(text, Path.Combine(GameGeneral.strAttachmentRepoDir, base.method_0(), Path.GetFileName(text)), true);
			}
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x0020D2FC File Offset: 0x0020B4FC
		public override bool vmethod_3(Scenario scenario_0)
		{
			SAO_OverlaySingle.Delegate8 @delegate = SAO_OverlaySingle.delegate8_0;
			if (@delegate != null)
			{
				@delegate(Path.Combine(GameGeneral.strAttachmentRepoDir, base.method_0(), this.ImageFileName));
			}
			return false;
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x0020D334 File Offset: 0x0020B534
		public override void vmethod_2(string string_2)
		{
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.Indent = true;
			xmlWriterSettings.IndentChars = "    ";
			XmlWriter xmlWriter = XmlWriter.Create(Path.Combine(string_2, "desc.xml"), xmlWriterSettings);
			xmlWriter.WriteStartElement("Attachment");
			xmlWriter.WriteElementString("Type", Conversions.ToString((int)this.attachmentObjectType_0));
			xmlWriter.WriteElementString("Desc", this.string_1);
			xmlWriter.WriteElementString("IFN", this.ImageFileName);
			xmlWriter.WriteEndElement();
			xmlWriter.Close();
		}

		// Token: 0x040025EA RID: 9706
		[Attribute0]
		public string ImageFileName;

		// Token: 0x040025EB RID: 9707
		[CompilerGenerated]
		private static SAO_OverlaySingle.Delegate8 delegate8_0;

		// Token: 0x02000A1F RID: 2591
		// (Invoke) Token: 0x060050BD RID: 20669
		public delegate void Delegate8(string theFullFileName);
	}
}
