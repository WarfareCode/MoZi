using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace ns2
{
	// Token: 0x02000AF7 RID: 2807
	public sealed class Group_Sensory : ActiveUnit_Sensory
	{
		// Token: 0x06005AA7 RID: 23207 RVA: 0x00283BFC File Offset: 0x00281DFC
		public override void Save(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Group_Sensory");
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100623", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x00283C6C File Offset: 0x00281E6C
		public static Group_Sensory smethod_8(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_1, ref ActiveUnit activeUnit_1)
		{
			return new Group_Sensory(ref activeUnit_1)
			{
				ParentPlatform = activeUnit_1
			};
		}

		// Token: 0x06005AA9 RID: 23209 RVA: 0x00024AEC File Offset: 0x00022CEC
		public Group_Sensory(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06005AAA RID: 23210 RVA: 0x00028B82 File Offset: 0x00026D82
		public override bool IsObeysEMCON()
		{
			return base.IsObeysEMCON();
		}

		// Token: 0x06005AAB RID: 23211 RVA: 0x00283C8C File Offset: 0x00281E8C
		public override void SetIsObeysEMCON(bool bool_1)
		{
			try
			{
				base.SetIsObeysEMCON(bool_1);
				using (IEnumerator<ActiveUnit> enumerator = ((Group)this.ParentPlatform).GetUnitsInGroup().Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.GetSensory().SetIsObeysEMCON(bool_1);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100624", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}
	}
}
