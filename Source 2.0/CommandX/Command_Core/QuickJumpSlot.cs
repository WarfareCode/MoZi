using System;
using System.Collections;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace Command_Core
{
	// Token: 0x02000A7E RID: 2686
	public sealed class QuickJumpSlot
	{
		// Token: 0x06005500 RID: 21760 RVA: 0x002378DC File Offset: 0x00235ADC
		public void Save(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("QJS");
				xmlWriter_0.WriteElementString("I", this.I.ToString());
				xmlWriter_0.WriteElementString("LS", this.LS);
				xmlWriter_0.WriteElementString("CA", this.CA.ToString());
				if (this.TR)
				{
					xmlWriter_0.WriteElementString("TR", "True");
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101018", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x002379A8 File Offset: 0x00235BA8
		public static QuickJumpSlot Load(XmlNode xmlNode_0)
		{
			QuickJumpSlot result = null;
			try
			{
				QuickJumpSlot quickJumpSlot = new QuickJumpSlot();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "I", false) != 0)
						{
							if (Operators.CompareString(name, "LS", false) != 0)
							{
								if (Operators.CompareString(name, "CA", false) != 0)
								{
									if (Operators.CompareString(name, "TR", false) == 0)
									{
										quickJumpSlot.TR = true;
									}
								}
								else
								{
									quickJumpSlot.CA = Conversions.ToInteger(xmlNode.InnerText);
								}
							}
							else
							{
								quickJumpSlot.LS = xmlNode.InnerText;
							}
						}
						else
						{
							quickJumpSlot.I = Conversions.ToByte(xmlNode.InnerText);
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
				result = quickJumpSlot;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101019", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04002933 RID: 10547
		public byte I;

		// Token: 0x04002934 RID: 10548
		public string LS;

		// Token: 0x04002935 RID: 10549
		public int CA;

		// Token: 0x04002936 RID: 10550
		public bool TR;
	}
}
