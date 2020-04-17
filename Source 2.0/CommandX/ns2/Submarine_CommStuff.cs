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
	// Token: 0x02000B36 RID: 2870
	public sealed class Submarine_CommStuff : ActiveUnit_CommStuff
	{
		// Token: 0x06005C62 RID: 23650 RVA: 0x002A882C File Offset: 0x002A6A2C
		public static Submarine_CommStuff Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Submarine_CommStuff result = null;
			try
			{
				Submarine_CommStuff submarine_CommStuff = new Submarine_CommStuff(ref activeUnit_1);
				submarine_CommStuff.ParentPlatform = activeUnit_1;
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
								submarine_CommStuff.bNotOutOfComms = new bool?(!Conversions.ToBoolean(xmlNode.InnerText));
							}
						}
						else
						{
							submarine_CommStuff.CommLinksEstablished = new ActiveUnit_CommLink[xmlNode.ChildNodes.Count - 1 + 1];
							int num = xmlNode.ChildNodes.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								XmlNode xmlNode2 = xmlNode.ChildNodes[i];
								ActiveUnit_CommLink activeUnit_CommLink = ActiveUnit_CommLink.Load(ref xmlNode2, ref dictionary_0, ref activeUnit_1);
								submarine_CommStuff.CommLinksEstablished[i] = activeUnit_CommLink;
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
				result = submarine_CommStuff;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100827", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Submarine_CommStuff(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005C63 RID: 23651 RVA: 0x000246DA File Offset: 0x000228DA
		public Submarine_CommStuff(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}
	}
}
