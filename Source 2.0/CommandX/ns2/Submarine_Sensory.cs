using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns2
{
	// Token: 0x02000B3B RID: 2875
	public sealed class Submarine_Sensory : ActiveUnit_Sensory
	{
		// Token: 0x06005C95 RID: 23701 RVA: 0x002AC098 File Offset: 0x002AA298
		public static Submarine_Sensory Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_1, ref ActiveUnit activeUnit_1)
		{
			Submarine_Sensory result = null;
			try
			{
				Submarine_Sensory submarine_Sensory = new Submarine_Sensory(ref activeUnit_1);
				submarine_Sensory.ParentPlatform = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ObE", false) != 0)
						{
							if (Operators.CompareString(name, "ContactList", false) != 0 && Operators.CompareString(name, "ContactList_Local", false) != 0)
							{
								if (Operators.CompareString(name, "ContactList_OffGrid", false) != 0)
								{
									continue;
								}
								IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
										Contact contact = Contact.Load(ref xmlNode2, ref dictionary_1);
										submarine_Sensory.ContactList_OffGrid.Add(contact.string_6, contact);
									}
									continue;
								}
								finally
								{
									if (enumerator2 is IDisposable)
									{
										(enumerator2 as IDisposable).Dispose();
									}
								}
							}
							IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator3.MoveNext())
								{
									XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
									string text = "";
									ActiveUnit_Sensory.ContactEntry value = ActiveUnit_Sensory.ContactEntry.Load(ref xmlNode3, ref dictionary_1, ref text);
									if (!Information.IsNothing(text) && !submarine_Sensory.GetContactEntryDictionary().ContainsKey(text))
									{
										submarine_Sensory.GetContactEntryDictionary().Add(text, value);
									}
								}
								continue;
							}
							finally
							{
								if (enumerator3 is IDisposable)
								{
									(enumerator3 as IDisposable).Dispose();
								}
							}
						}
						submarine_Sensory.bObeysEMCON = Conversions.ToBoolean(xmlNode.InnerText);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = submarine_Sensory;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100839", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005C96 RID: 23702 RVA: 0x00024AEC File Offset: 0x00022CEC
		public Submarine_Sensory(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}
	}
}
