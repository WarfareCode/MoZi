using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns2
{
	// Token: 0x02000AEF RID: 2799
	public sealed class Group_CommStuff : ActiveUnit_CommStuff
	{
		// Token: 0x06005A6E RID: 23150 RVA: 0x00282730 File Offset: 0x00280930
		public static Group_CommStuff Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Group_CommStuff result = null;
			try
			{
				Group_CommStuff group_CommStuff = new Group_CommStuff(ref activeUnit_1);
				group_CommStuff.ParentPlatform = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "CommLinksEstablished", false) == 0)
						{
							group_CommStuff.CommLinksEstablished = new ActiveUnit_CommLink[xmlNode.ChildNodes.Count - 1 + 1];
							int num = xmlNode.ChildNodes.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								XmlNode xmlNode2 = xmlNode.ChildNodes[i];
								ActiveUnit_CommLink activeUnit_CommLink = ActiveUnit_CommLink.Load(ref xmlNode2, ref dictionary_0, ref activeUnit_1);
								group_CommStuff.CommLinksEstablished[i] = activeUnit_CommLink;
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
				result = group_CommStuff;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100611", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x000246DA File Offset: 0x000228DA
		public Group_CommStuff(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}
	}
}
