using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace Command_Core
{
	// Token: 0x02000A89 RID: 2697
	public sealed class GroundImpact : Unit
	{
		// Token: 0x0600552A RID: 21802 RVA: 0x002381E4 File Offset: 0x002363E4
		public GroundImpact(ref Scenario scenario_, double Lon_, double Lat_, float MR_, bool bool_9)
		{
			this.SetLongitude(null, Lon_);
			this.SetLatitude(null, Lat_);
			this.MR = MR_;
			this.bool_8 = bool_9;
			scenario_.GetGroundImpacts().Add(this);
		}

		// Token: 保存
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("GroundImpact");
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
				ex2.Data.Add("Error at 101337", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x000214EC File Offset: 0x0001F6EC
		private GroundImpact()
		{
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x00238350 File Offset: 0x00236550
		public void ProcessGroundImpact(Scenario scenario_, float elapsedTime_)
		{
			this.CR += elapsedTime_ * Math.Max(this.MR / 50f, (this.MR - this.CR) / 5f);
			if (this.CR > this.MR)
			{
				scenario_.GetGroundImpacts().Remove(this);
			}
		}

		// Token: 0x04002946 RID: 10566
		public float MR;

		// Token: 0x04002947 RID: 10567
		public float CR;

		// Token: 0x04002948 RID: 10568
		public bool bool_8;
	}
}
