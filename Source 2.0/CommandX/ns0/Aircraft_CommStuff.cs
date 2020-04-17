using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns0
{
	// Token: 0x020009F4 RID: 2548
	public sealed class Aircraft_CommStuff : ActiveUnit_CommStuff
	{
		// Token: 0x06004C54 RID: 19540 RVA: 0x001E3E1C File Offset: 0x001E201C
		public static Aircraft_CommStuff Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Aircraft_CommStuff result;
			try
			{
				Aircraft_CommStuff aircraft_CommStuff = new Aircraft_CommStuff(ref activeUnit_1);
				aircraft_CommStuff.ParentPlatform = activeUnit_1;
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
								aircraft_CommStuff.bNotOutOfComms = new bool?(!Conversions.ToBoolean(xmlNode.InnerText));
							}
						}
						else
						{
							aircraft_CommStuff.CommLinksEstablished = new ActiveUnit_CommLink[xmlNode.ChildNodes.Count - 1 + 1];
							int num = xmlNode.ChildNodes.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								XmlNode xmlNode2 = xmlNode.ChildNodes[i];
								ActiveUnit_CommLink activeUnit_CommLink = ActiveUnit_CommLink.Load(ref xmlNode2, ref dictionary_0, ref activeUnit_1);
								aircraft_CommStuff.CommLinksEstablished[i] = activeUnit_CommLink;
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
				result = aircraft_CommStuff;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101192", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Aircraft_CommStuff(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004C55 RID: 19541 RVA: 0x000246DA File Offset: 0x000228DA
		public Aircraft_CommStuff(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}
	}
}
