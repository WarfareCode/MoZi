using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace ns2
{
	// Token: 0x02000AEE RID: 2798
	public sealed class Group_AirOps : ActiveUnit_AirOps
	{
		// Token: 0x06005A68 RID: 23144 RVA: 0x00282454 File Offset: 0x00280654
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					xmlWriter_0.WriteStartElement("Group_AirOps");
					xmlWriter_0.WriteStartElement("LandingQueue");
					Aircraft[] landingQueue = this.LandingQueue;
					for (int i = 0; i < landingQueue.Length; i++)
					{
						Aircraft aircraft = landingQueue[i];
						if (!Information.IsNothing(aircraft))
						{
							xmlWriter_0.WriteElementString("ID", aircraft.GetGuid());
						}
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteEndElement();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100608", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005A69 RID: 23145 RVA: 0x0028250C File Offset: 0x0028070C
		public static Group_AirOps smethod_1(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Group_AirOps result = null;
			try
			{
				Group_AirOps group_AirOps = new Group_AirOps();
				group_AirOps.theUnit = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "LandingQueue", false) == 0)
						{
							int num = xmlNode.ChildNodes.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								ScenarioArrayUtil.AddStringToArray(ref group_AirOps.aircraftsToLanding, xmlNode.ChildNodes[i].InnerText);
							}
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
				result = group_AirOps;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100609", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005A6A RID: 23146 RVA: 0x000289F1 File Offset: 0x00026BF1
		private Group_AirOps() : base(ref Group_AirOps.activeUnit)
		{
		}

		// Token: 0x06005A6B RID: 23147 RVA: 0x00282630 File Offset: 0x00280830
		public override List<Aircraft> GetHostedAircrafts()
		{
			List<Aircraft> result = null;
			try
			{
				List<Aircraft> list = new List<Aircraft>();
				foreach (ActiveUnit current in ((Group)this.theUnit).GetUnitsInGroup().Values)
				{
					foreach (Aircraft current2 in current.GetAirOps().GetHostedAircrafts())
					{
						list.Add(current2);
					}
				}
				result = list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100610", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005A6C RID: 23148 RVA: 0x000289FE File Offset: 0x00026BFE
		public Group_AirOps(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x04002CDF RID: 11487
		private static ActiveUnit activeUnit = null;
	}
}
