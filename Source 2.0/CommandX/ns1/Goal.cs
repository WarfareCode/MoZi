using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns1
{
	// Token: 目标
	public abstract class Goal : Subject
	{
		// Token: 0x0600551D RID: 21789 RVA: 0x00027265 File Offset: 0x00025465
		protected Goal()
		{
			this.NeedsToBeChecked = true;
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x00237CEC File Offset: 0x00235EEC
		public static Goal Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			try
			{
				string name = xmlNode_0.Name;
				if (Operators.CompareString(name, "DestroyGoal", false) == 0)
				{
					return DestroyGoal.Load(xmlNode_0, dictionary_0, scenario_0);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100760", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			throw new NotImplementedException();
		}

		// Token: 0x0400293B RID: 10555
		public string TargetSideName = "";

		// Token: 0x0400293C RID: 10556
		public GlobalVariables.ActiveUnitType TargetType;

		// Token: 0x0400293D RID: 10557
		public int TargetSubType;

		// Token: 0x0400293E RID: 10558
		public int SpecificUnitClass;

		// Token: 0x0400293F RID: 10559
		public ActiveUnit SpecificUnit;

		// Token: 0x04002940 RID: 10560
		public string Description = "";

		// Token: 0x04002941 RID: 10561
		public bool NeedsToBeChecked;

		// Token: 0x04002942 RID: 10562
		public bool IsRepeatable;

		// Token: 0x04002943 RID: 10563
		public int GoalPoints = 0;
	}
}
