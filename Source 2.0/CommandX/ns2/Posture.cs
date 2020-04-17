using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace ns2
{
	// Token: 0x02000B2A RID: 2858
	public sealed class Posture : Subject
	{
		// Token: 0x06005C17 RID: 23575 RVA: 0x0001542D File Offset: 0x0001362D
		private Posture()
		{
		}

		// Token: 0x06005C18 RID: 23576 RVA: 0x002A0444 File Offset: 0x0029E644
		public static Posture Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0)
		{
			Posture posture = null;
			Posture result;
			try
			{
				Posture posture2 = new Posture();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "PostureType", false) != 0)
							{
								if (Operators.CompareString(name, "PostureTargetName", false) != 0)
								{
									if (Operators.CompareString(name, "PostureTarget", false) == 0)
									{
										posture2.PostureTarget = xmlNode.InnerText;
									}
								}
								else
								{
									posture2.PostureTargetName = xmlNode.InnerText;
								}
							}
							else if (Versioned.IsNumeric(xmlNode.InnerText))
							{
								posture2.m_PostureStance = (Misc.PostureStance)Conversions.ToByte(xmlNode.InnerText);
							}
							else
							{
								posture2.m_PostureStance = (Misc.PostureStance)Enum.Parse(typeof(Misc.PostureStance), xmlNode.InnerText, true);
							}
						}
						else
						{
							if (dictionary_0.ContainsKey(xmlNode.InnerText))
							{
								posture = (Posture)dictionary_0[xmlNode.InnerText];
								result = posture;
								return result;
							}
							posture2.SetGuid(xmlNode.InnerText);
							dictionary_0.Add(posture2.GetGuid(), posture2);
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
				posture = posture2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101016", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = posture;
			return result;
		}

		// Token: 0x0400306E RID: 12398
		public Misc.PostureStance m_PostureStance;

		// Token: 0x0400306F RID: 12399
		private string PostureTarget;

		// Token: 0x04003070 RID: 12400
		private string PostureTargetName;
	}
}
