using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace Command_Core
{
	// Token: 0x02000B2B RID: 2859
	public sealed class RangeSymbol : Subject
	{
		// Token: 0x06005C19 RID: 23577 RVA: 0x002A0620 File Offset: 0x0029E820
		public void Save(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("RangeSymbol");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.Description);
				xmlWriter_0.WriteElementString("RangeNM", XmlConvert.ToString(this.RangeNM));
				xmlWriter_0.WriteElementString("LeftArc", XmlConvert.ToString(this.LeftArc));
				xmlWriter_0.WriteElementString("RightArc", XmlConvert.ToString(this.RightArc));
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Type";
				int num = (int)this.symbolType;
				xmlWriter.WriteElementString(localName, num.ToString());
				xmlWriter_0.WriteElementString("Color", this.color.ToArgb().ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101020", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005C1A RID: 23578 RVA: 0x002A073C File Offset: 0x0029E93C
		public static RangeSymbol Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0)
		{
			RangeSymbol rangeSymbol2;
			RangeSymbol result;
			try
			{
				RangeSymbol rangeSymbol = new RangeSymbol();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 2959157563u)
						{
							if (num != 1458105184u)
							{
								if (num != 1725856265u)
								{
									if (num == 2959157563u && Operators.CompareString(name, "RightArc", false) == 0)
									{
										rangeSymbol.RightArc = XmlConvert.ToSingle(xmlNode.InnerText);
									}
								}
								else if (Operators.CompareString(name, "Description", false) == 0)
								{
									rangeSymbol.Description = xmlNode.InnerText;
								}
							}
							else if (Operators.CompareString(name, "ID", false) == 0)
							{
								if (dictionary_0.ContainsKey(xmlNode.InnerText))
								{
									rangeSymbol2 = (RangeSymbol)dictionary_0[xmlNode.InnerText];
									result = rangeSymbol2;
									return result;
								}
								rangeSymbol.SetGuid(xmlNode.InnerText);
								dictionary_0.Add(rangeSymbol.GetGuid(), rangeSymbol);
							}
						}
						else if (num <= 3783116160u)
						{
							if (num != 3512062061u)
							{
								if (num == 3783116160u && Operators.CompareString(name, "LeftArc", false) == 0)
								{
									rangeSymbol.LeftArc = XmlConvert.ToSingle(xmlNode.InnerText);
								}
							}
							else if (Operators.CompareString(name, "Type", false) == 0)
							{
								if (Versioned.IsNumeric(xmlNode.InnerText))
								{
									rangeSymbol.symbolType = (RangeSymbol.SymbolType)Conversions.ToByte(xmlNode.InnerText);
								}
								else
								{
									rangeSymbol.symbolType = (RangeSymbol.SymbolType)Enum.Parse(typeof(RangeSymbol.SymbolType), xmlNode.InnerText, true);
								}
							}
						}
						else if (num != 3853794552u)
						{
							if (num == 3858895547u && Operators.CompareString(name, "RangeNM", false) == 0)
							{
								rangeSymbol.RangeNM = XmlConvert.ToDouble(xmlNode.InnerText);
							}
						}
						else if (Operators.CompareString(name, "Color", false) == 0)
						{
							rangeSymbol.color = Color.FromArgb(Conversions.ToInteger(xmlNode.InnerText));
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
				rangeSymbol2 = rangeSymbol;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101021", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				rangeSymbol2 = new RangeSymbol();
				ProjectData.ClearProjectError();
			}
			result = rangeSymbol2;
			return result;
		}

		// Token: 0x06005C1B RID: 23579 RVA: 0x00029311 File Offset: 0x00027511
		public RangeSymbol()
		{
		}

		// Token: 0x06005C1C RID: 23580 RVA: 0x00029324 File Offset: 0x00027524
		public RangeSymbol(RangeSymbol.SymbolType symbolType_1, string string_3, double double_1, float float_2, float float_3, Color color_1)
		{
			this.symbolType = symbolType_1;
			this.Description = string_3;
			this.RangeNM = double_1;
			this.LeftArc = float_2;
			this.RightArc = float_3;
			this.color = color_1;
		}

		// Token: 0x04003071 RID: 12401
		public string Description = "";

		// Token: 0x04003072 RID: 12402
		public double RangeNM;

		// Token: 0x04003073 RID: 12403
		public float LeftArc;

		// Token: 0x04003074 RID: 12404
		public float RightArc;

		// Token: 0x04003075 RID: 12405
		public RangeSymbol.SymbolType symbolType;

		// Token: 0x04003076 RID: 12406
		public Color color;

		// Token: 0x02000B2C RID: 2860
		public enum SymbolType : byte
		{
			// Token: 0x04003078 RID: 12408
			Circle = 1,
			// Token: 0x04003079 RID: 12409
			Wedge
		}
	}
}
