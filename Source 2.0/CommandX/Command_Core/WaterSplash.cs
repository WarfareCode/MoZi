using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace Command_Core
{
	// Token: 0x02000AB7 RID: 2743
	public sealed class WaterSplash : Unit
	{
		// Token: 0x060056E2 RID: 22242 RVA: 0x00256FB0 File Offset: 0x002551B0
		public WaterSplash(ref Scenario scenario_0, double double_2, double double_3, float float_9)
		{
			this.SetLongitude(null, double_2);
			this.SetLatitude(null, double_3);
			this.MR = float_9;
			scenario_0.GetWaterSplashes().Add(this);
		}

		// Token: 0x060056E3 RID: 22243 RVA: 0x00256FF8 File Offset: 0x002551F8
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("WaterSplash");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (hashSet_0.Contains(base.GetGuid()))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(base.GetGuid());
					xmlWriter_0.WriteElementString("Lon", XmlConvert.ToString(this.GetLongitude(null)));
					xmlWriter_0.WriteElementString("Lat", XmlConvert.ToString(this.GetLatitude(null)));
					xmlWriter_0.WriteElementString("MR", this.MR.ToString());
					xmlWriter_0.WriteElementString("CR", this.CR.ToString());
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100877", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060056E4 RID: 22244 RVA: 0x000214EC File Offset: 0x0001F6EC
		private WaterSplash()
		{
		}

		// Token: 0x060056E5 RID: 22245 RVA: 0x00257114 File Offset: 0x00255314
		public void ProcessWaterSplash(Scenario scenario_, float elapsedTime_)
		{
			this.CR += elapsedTime_ * Math.Max(this.MR / 50f, (this.MR - this.CR) / 5f);
			if (this.CR > this.MR)
			{
				scenario_.GetWaterSplashes().Remove(this);
			}
		}
		
		public float MR;// Token: 0x04002AD8 RID: 10968		
		public float CR;// Token: 0x04002AD9 RID: 10969
	}
}
