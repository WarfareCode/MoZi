using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns2;

namespace Command_Core
{
	// Token: 0x02000A18 RID: 2584
	public class ScenAttachmentObject
	{
		// Token: 0x0600506C RID: 20588 RVA: 0x00004A21 File Offset: 0x00002C21
		public ScenAttachmentObject()
		{
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x00025A60 File Offset: 0x00023C60
		public ScenAttachmentObject(string string_2)
		{
			this.string_0 = string_2;
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x0020B99C File Offset: 0x00209B9C
		public string method_0()
		{
			if (string.IsNullOrEmpty(this.string_0))
			{
				this.string_0 = Guid.NewGuid().ToString();
			}
			return this.string_0;
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x0020B9DC File Offset: 0x00209BDC
		public string method_1()
		{
			return this.string_1;
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x00025A6F File Offset: 0x00023C6F
		public void method_2(string string_2)
		{
			this.string_1 = string_2;
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x00025A78 File Offset: 0x00023C78
		public virtual void vmethod_0(string string_2)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x00025A78 File Offset: 0x00023C78
		public virtual void Save(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x00025A78 File Offset: 0x00023C78
		public virtual void vmethod_2(string string_2)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x0020B9F4 File Offset: 0x00209BF4
		public static ScenAttachmentObject smethod_0(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			ScenAttachmentObject result;
			try
			{
				string name = xmlNode_0.Name;
				if (Operators.CompareString(name, "SAO_OverlaySingle", false) != 0)
				{
					if (Operators.CompareString(name, "SAO_LuaScript", false) != 0)
					{
						if (Operators.CompareString(name, "SAO_Inst", false) != 0)
						{
							if (Operators.CompareString(name, "SAO_LocalVideo", false) != 0)
							{
								result = null;
							}
							else
							{
								result = SAO_LocalVideo.Load(xmlNode_0, dictionary_0, scenario_0);
							}
						}
						else
						{
							result = SAO_Inst.Load(xmlNode_0, dictionary_0, scenario_0);
						}
					}
					else
					{
						result = SAO_LuaScript.Load(xmlNode_0, dictionary_0, scenario_0);
					}
				}
				else
				{
					result = SAO_OverlaySingle.Load(xmlNode_0, dictionary_0, scenario_0);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101310", "");
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

		// Token: 0x06005075 RID: 20597 RVA: 0x00025A78 File Offset: 0x00023C78
		public virtual bool vmethod_3(Scenario scenario_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x00025A7F File Offset: 0x00023C7F
		public virtual bool vmethod_4(Scenario scenario_0, Side side_0)
		{
			return this.vmethod_3(scenario_0);
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x0020BAD0 File Offset: 0x00209CD0
		public static ScenAttachmentObject smethod_1(string string_2)
		{
			ScenAttachmentObject scenAttachmentObject = null;
			if (Directory.GetFiles(string_2).Contains(Path.Combine(string_2, "desc.xml")))
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(Path.Combine(string_2, "desc.xml"));
				string fileName = Path.GetFileName(string_2);
				ScenAttachmentObject.AttachmentObjectType attachmentObjectType = (ScenAttachmentObject.AttachmentObjectType)Conversions.ToInteger(xmlDocument.SelectSingleNode("/Attachment/Type").InnerText);
				string innerText = xmlDocument.SelectSingleNode("/Attachment/Desc").InnerText;
				switch (attachmentObjectType)
				{
				case ScenAttachmentObject.AttachmentObjectType.MapOverlay_SingleImage:
					scenAttachmentObject = new SAO_OverlaySingle(fileName);
					scenAttachmentObject.method_2(innerText);
					((SAO_OverlaySingle)scenAttachmentObject).ImageFileName = xmlDocument.SelectSingleNode("/Attachment/IFN").InnerText;
					break;
				case ScenAttachmentObject.AttachmentObjectType.LocalVideo:
					scenAttachmentObject = new SAO_LocalVideo(fileName);
					scenAttachmentObject.method_2(innerText);
					((SAO_LocalVideo)scenAttachmentObject).VideoFileName = xmlDocument.SelectSingleNode("/Attachment/VFN").InnerText;
					break;
				case ScenAttachmentObject.AttachmentObjectType.LuaScript:
					scenAttachmentObject = new SAO_LuaScript(fileName);
					scenAttachmentObject.method_2(innerText);
					((SAO_LuaScript)scenAttachmentObject).ScriptFileName = xmlDocument.SelectSingleNode("/Attachment/SFN").InnerText;
					break;
				case ScenAttachmentObject.AttachmentObjectType.Inst:
					scenAttachmentObject = new SAO_Inst(fileName);
					scenAttachmentObject.method_2(innerText);
					((SAO_Inst)scenAttachmentObject).InstFileName = xmlDocument.SelectSingleNode("/Attachment/IFN").InnerText;
					break;
				}
			}
			return scenAttachmentObject;
		}

		// Token: 0x040025D0 RID: 9680
		protected string string_0;

		// Token: 0x040025D1 RID: 9681
		public string string_1;

		// Token: 0x040025D2 RID: 9682
		public ScenAttachmentObject.AttachmentObjectType attachmentObjectType_0;

		// Token: 0x02000A19 RID: 2585
		public enum AttachmentObjectType
		{
			// Token: 0x040025D4 RID: 9684
			MapOverlay_SingleImage,
			// Token: 0x040025D5 RID: 9685
			MapOverlay_Tiles,
			// Token: 0x040025D6 RID: 9686
			Audio,
			// Token: 0x040025D7 RID: 9687
			LocalVideo,
			// Token: 0x040025D8 RID: 9688
			LuaScript,
			// Token: 0x040025D9 RID: 9689
			Inst
		}
	}
}
