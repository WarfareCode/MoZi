using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace Command_Core
{
	// Token: 燃料
	public sealed class FuelRec : Subject
	{
		// Token: 0x060057FE RID: 22526 RVA: 0x0026ABD0 File Offset: 0x00268DD0
		public void Save(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("FuelRec");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (this.DBID.HasValue)
				{
					xmlWriter_0.WriteElementString("DBID", Conversions.ToString(this.DBID.Value));
				}
				xmlWriter_0.WriteElementString("MQ", this.MaxQuantity.ToString());
				xmlWriter_0.WriteElementString("CQ", XmlConvert.ToString(this.CurrentQuantity));
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "ft";
				int fuelType = (int)this.FuelType;
				xmlWriter.WriteElementString(localName, fuelType.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101005", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x0026ACCC File Offset: 0x00268ECC
		public static FuelRec Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0)
		{
			FuelRec result = null;
			try
			{
				FuelRec fuelRec = new FuelRec();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num > 1458105184u)
						{
							if (num <= 2027117207u)
							{
								if (num != 1742338969u)
								{
									if (Operators.CompareString(name, "ft", false) == 0 || Operators.CompareString(name, "FT", false) == 0)
									{
										goto IL_1DC;
									}
									continue;
								}
								else if (Operators.CompareString(name, "CQ", false) != 0)
								{
									continue;
								}
							}
							else if (num != 2187602126u)
							{
								if (num != 2735483603u || Operators.CompareString(name, "CurrentQuantity", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "DBID", false) == 0)
								{
									fuelRec.DBID = new int?(Conversions.ToInteger(xmlNode.InnerText));
									continue;
								}
								continue;
							}
							fuelRec.CurrentQuantity = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
							continue;
						}
						if (num <= 870300139u)
						{
							if (num != 596983820u)
							{
								if (num != 870300139u)
								{
									continue;
								}
								if (Operators.CompareString(name, "MQ", false) != 0)
								{
									continue;
								}
							}
							else if (Operators.CompareString(name, "MaxQuantity", false) != 0)
							{
								continue;
							}
							fuelRec.MaxQuantity = Conversions.ToInteger(xmlNode.InnerText);
							continue;
						}
						if (num != 1398189189u)
						{
							if (num == 1458105184u && Operators.CompareString(name, "ID", false) == 0)
							{
								fuelRec.SetGuid(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						else if (Operators.CompareString(name, "FuelType", false) != 0)
						{
							continue;
						}
						IL_1DC:
						if (Versioned.IsNumeric(xmlNode.InnerText))
						{
							fuelRec.FuelType = (FuelRec._FuelType)Conversions.ToShort(xmlNode.InnerText);
						}
						else
						{
							fuelRec.FuelType = (FuelRec._FuelType)Enum.Parse(typeof(FuelRec._FuelType), xmlNode.InnerText, true);
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
				result = fuelRec;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101006", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x0026AFA0 File Offset: 0x002691A0
		public float GetRatioLeft()
		{
			return this.CurrentQuantity / (float)this.MaxQuantity;
		}

		// Token: 0x06005801 RID: 22529 RVA: 0x0001542D File Offset: 0x0001362D
		private FuelRec()
		{
		}

		// Token: 0x06005802 RID: 22530 RVA: 0x00027DD3 File Offset: 0x00025FD3
		public FuelRec(int int_1, short short_0)
		{
			this.MaxQuantity = int_1;
			this.CurrentQuantity = (float)int_1;
			this.FuelType = (FuelRec._FuelType)short_0;
		}

		// Token: 0x04002B49 RID: 11081
		public int? DBID;

		// Token: 0x04002B4A RID: 11082
		public int MaxQuantity;

		// Token: 0x04002B4B RID: 11083
		public float CurrentQuantity;

		// Token: 0x04002B4C RID: 11084
		public FuelRec._FuelType FuelType;

		// Token: 0x02000AC4 RID: 2756
		public enum _FuelType : short
		{
			// Token: 0x04002B4E RID: 11086
			NoFuel = 1001,
			// Token: 0x04002B4F RID: 11087
			AviationFuel = 2001,
			// Token: 0x04002B50 RID: 11088
			DieselFuel = 3001,
			// Token: 0x04002B51 RID: 11089
			OilFuel,
			// Token: 0x04002B52 RID: 11090
			GasFuel,
			// Token: 0x04002B53 RID: 11091
			Battery = 4001,
			// Token: 0x04002B54 RID: 11092
			AirIndepedent,
			// Token: 0x04002B55 RID: 11093
			RocketFuel = 5001,
			// Token: 0x04002B56 RID: 11094
			TorpedoFuel = 5001,
			// Token: 0x04002B57 RID: 11095
			WeaponCoast = 5003
		}
	}
}
