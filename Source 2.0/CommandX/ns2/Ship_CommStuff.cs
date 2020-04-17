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
	// Token: 0x02000B74 RID: 2932
	public sealed class Ship_CommStuff : ActiveUnit_CommStuff
	{
		// Token: 0x06006112 RID: 24850 RVA: 0x000246DA File Offset: 0x000228DA
		public Ship_CommStuff(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06006113 RID: 24851 RVA: 0x002E6144 File Offset: 0x002E4344
		public static Ship_CommStuff Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Ship_CommStuff result = null;
			try
			{
				Ship_CommStuff ship_CommStuff = new Ship_CommStuff(ref activeUnit_1);
				ship_CommStuff.ParentPlatform = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "CLE", false) != 0)
						{
							if (Operators.CompareString(name, "OOC", false) == 0)
							{
								ship_CommStuff.bNotOutOfComms = new bool?(!Conversions.ToBoolean(xmlNode.InnerText));
							}
						}
						else
						{
							ship_CommStuff.CommLinksEstablished = new ActiveUnit_CommLink[xmlNode.ChildNodes.Count - 1 + 1];
							int num = xmlNode.ChildNodes.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								XmlNode xmlNode2 = xmlNode.ChildNodes[i];
								ActiveUnit_CommLink activeUnit_CommLink = ActiveUnit_CommLink.Load(ref xmlNode2, ref dictionary_0, ref activeUnit_1);
								ship_CommStuff.CommLinksEstablished[i] = activeUnit_CommLink;
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
				result = ship_CommStuff;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100782", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Ship_CommStuff(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}
}
