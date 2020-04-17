using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace Command_Core
{
	// Token: 禁飞区？
	public sealed class NoNavZone : Zone
	{
		// Token: 0x06005C1D RID: 23581 RVA: 0x002A0A38 File Offset: 0x0029EC38
		public NoNavZone(string theDescription, List<ReferencePoint> theArea, Scenario theScen, Side CurrentSide, List<GlobalVariables.ActiveUnitType> theAffectedUnitTypes = null)
		{
			this.Description = theDescription;
			this.Area = theArea;
			if (Information.IsNothing(theAffectedUnitTypes))
			{
				this.SetAffectedUnitTypes(new ObservableCollection<GlobalVariables.ActiveUnitType>
				{
					GlobalVariables.ActiveUnitType.Aircraft,
					GlobalVariables.ActiveUnitType.Ship,
					GlobalVariables.ActiveUnitType.Submarine,
					GlobalVariables.ActiveUnitType.Facility
				});
			}
			else
			{
				this.SetAffectedUnitTypes(new ObservableCollection<GlobalVariables.ActiveUnitType>(theAffectedUnitTypes));
			}
			foreach (ActiveUnit current in theScen.GetActiveUnitList())
			{
				if (current.GetSide(false) == CurrentSide)
				{
					current.GetNavigator().short_8 = 0;
				}
			}
			string prompt = "";
			if (!ActiveUnit_Navigator.smethod_6(ref theArea, ref prompt, "", "Exclusion Zone '" + this.Description + "'"))
			{
				Interaction.MsgBox(prompt, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06005C1E RID: 23582 RVA: 0x00027DA7 File Offset: 0x00025FA7
		private NoNavZone()
		{
		}

		// Token: 0x06005C1F RID: 23583 RVA: 0x002A0B2C File Offset: 0x0029ED2C
		public void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("NoNavZone");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Description", this.Description);
				xmlWriter_0.WriteStartElement("Area");
				using (List<ReferencePoint>.Enumerator enumerator = this.Area.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.Save(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.Flush();
					}
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteElementString("AffectedUnitTypes", string.Join("_", this.GetAffectedUnitTypes().Select(NoNavZone.ActiveUnitTypeFunc)));
				xmlWriter_0.WriteElementString("IsLocked", this.IsLocked.ToString());
				xmlWriter_0.WriteElementString("IsActive", this.IsActive.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100993", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005C20 RID: 23584 RVA: 0x002A0C6C File Offset: 0x0029EE6C
		public static NoNavZone Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			NoNavZone noNavZone = null;
			checked
			{
				NoNavZone result;
				try
				{
					NoNavZone noNavZone2 = new NoNavZone();
					IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							XmlNode xmlNode = (XmlNode)enumerator.Current;
							string name = xmlNode.Name;
							if (Operators.CompareString(name, "ID", false) != 0)
							{
								if (Operators.CompareString(name, "Description", false) != 0)
								{
									if (Operators.CompareString(name, "Area", false) != 0)
									{
										if (Operators.CompareString(name, "AffectedUnitTypes", false) == 0)
										{
											noNavZone2.SetAffectedUnitTypes(new ObservableCollection<GlobalVariables.ActiveUnitType>());
											string[] array = xmlNode.InnerText.Split(new char[]
											{
												'_'
											});
											for (int i = 0; i < array.Length; i++)
											{
												string text = array[i];
												if (Versioned.IsNumeric(text))
												{
													int num = Conversions.ToInteger(text);
													noNavZone2.GetAffectedUnitTypes().Add(unchecked((GlobalVariables.ActiveUnitType)num));
												}
											}
											continue;
										}
										if (Operators.CompareString(name, "IsLocked", false) == 0)
										{
											noNavZone2.IsLocked = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										if (Operators.CompareString(name, "IsActive", false) == 0)
										{
											noNavZone2.IsActive = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator2.MoveNext())
											{
												XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
												noNavZone2.Area.Add(ReferencePoint.Load(ref xmlNode2, ref dictionary_0));
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
								}
								noNavZone2.Description = xmlNode.InnerText;
							}
							else
							{
								if (dictionary_0.ContainsKey(xmlNode.InnerText))
								{
									noNavZone = (NoNavZone)dictionary_0[xmlNode.InnerText];
									result = noNavZone;
									return result;
								}
								noNavZone2.SetGuid(xmlNode.InnerText);
								dictionary_0.Add(noNavZone2.GetGuid(), noNavZone2);
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
					if (Information.IsNothing(noNavZone2.GetAffectedUnitTypes()))
					{
						noNavZone2.SetAffectedUnitTypes(new ObservableCollection<GlobalVariables.ActiveUnitType>
						{
							GlobalVariables.ActiveUnitType.Aircraft,
							GlobalVariables.ActiveUnitType.Ship,
							GlobalVariables.ActiveUnitType.Submarine,
							GlobalVariables.ActiveUnitType.Facility
						});
					}
					noNavZone = noNavZone2;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100994", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					noNavZone = new NoNavZone();
					ProjectData.ClearProjectError();
				}
				result = noNavZone;
				return result;
			}
		}

		// Token: 0x0400307A RID: 12410
		public static Func<GlobalVariables.ActiveUnitType, string> ActiveUnitTypeFunc = delegate(GlobalVariables.ActiveUnitType activeUnitType_0)
		{
			int num = (int)activeUnitType_0;
			return num.ToString();
		};

		// Token: 0x0400307B RID: 12411
		public bool IsLocked;
	}
}
