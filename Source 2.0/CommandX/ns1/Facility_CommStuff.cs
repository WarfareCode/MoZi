using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns2;

namespace ns1
{
	// Token: 0x02000AB9 RID: 2745
	public sealed class Facility_CommStuff : ActiveUnit_CommStuff
	{
		// Token: 0x060056F1 RID: 22257 RVA: 0x0025922C File Offset: 0x0025742C
		public static Facility_CommStuff Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Facility_CommStuff result = null;
			try
			{
				Facility_CommStuff facility_CommStuff = new Facility_CommStuff(ref activeUnit_1);
				facility_CommStuff.ParentPlatform = activeUnit_1;
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
								facility_CommStuff.bNotOutOfComms = new bool?(!Conversions.ToBoolean(xmlNode.InnerText));
							}
						}
						else
						{
							facility_CommStuff.CommLinksEstablished = new ActiveUnit_CommLink[xmlNode.ChildNodes.Count - 1 + 1];
							int num = xmlNode.ChildNodes.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								XmlNode xmlNode2 = xmlNode.ChildNodes[i];
								ActiveUnit_CommLink activeUnit_CommLink = ActiveUnit_CommLink.Load(ref xmlNode2, ref dictionary_0, ref activeUnit_1);
								facility_CommStuff.CommLinksEstablished[i] = activeUnit_CommLink;
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
				result = facility_CommStuff;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100552", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x000246DA File Offset: 0x000228DA
		public Facility_CommStuff(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}
	}
}
