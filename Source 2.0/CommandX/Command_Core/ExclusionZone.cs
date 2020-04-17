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
	// Token: 0x02000AC2 RID: 2754
	public sealed class ExclusionZone : Zone
	{
		// Token: 0x060057F8 RID: 22520 RVA: 0x0026A6E4 File Offset: 0x002688E4
		public ExclusionZone(string theDescription, List<ReferencePoint> theArea, Misc.PostureStance theMarkViolatorAs, List<GlobalVariables.ActiveUnitType> theAffectedUnitTypes = null)
		{
			this.Description = theDescription;
			this.Area = theArea;
			this.MarkViolatorAs = theMarkViolatorAs;
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
			string prompt = "";
			if (!ActiveUnit_Navigator.smethod_6(ref theArea, ref prompt, "", "Exclusion Zone '" + this.Description + "'"))
			{
				Interaction.MsgBox(prompt, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060057F9 RID: 22521 RVA: 0x00027DA7 File Offset: 0x00025FA7
		private ExclusionZone()
		{
		}

		// Token: 0x060057FA RID: 22522 RVA: 0x0026A784 File Offset: 0x00268984
		public void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("ExclusionZone");
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
				xmlWriter_0.WriteElementString("AffectedUnitTypes", string.Join("_", this.GetAffectedUnitTypes().Select(ExclusionZone.ActiveUnitTypeFunc)));
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "MarkViolatorAs";
				byte markViolatorAs = (byte)this.MarkViolatorAs;
				xmlWriter.WriteElementString(localName, markViolatorAs.ToString());
				xmlWriter_0.WriteElementString("IsActive", this.IsActive.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100991", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060057FB RID: 22523 RVA: 0x0026A8D0 File Offset: 0x00268AD0
		public static ExclusionZone Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			checked
			{
				ExclusionZone exclusionZone2;
				ExclusionZone result;
				try
				{
					ExclusionZone exclusionZone = new ExclusionZone();
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
										if (Operators.CompareString(name, "MarkViolatorAs", false) == 0)
										{
											exclusionZone.MarkViolatorAs = (Misc.PostureStance)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										if (Operators.CompareString(name, "AffectedUnitTypes", false) == 0)
										{
											exclusionZone.SetAffectedUnitTypes(new ObservableCollection<GlobalVariables.ActiveUnitType>());
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
													exclusionZone.GetAffectedUnitTypes().Add(unchecked((GlobalVariables.ActiveUnitType)num));
												}
											}
											continue;
										}
										if (Operators.CompareString(name, "IsActive", false) == 0)
										{
											exclusionZone.IsActive = Conversions.ToBoolean(xmlNode.InnerText);
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
												exclusionZone.Area.Add(ReferencePoint.Load(ref xmlNode2, ref dictionary_0));
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
								exclusionZone.Description = xmlNode.InnerText;
							}
							else
							{
								if (dictionary_0.ContainsKey(xmlNode.InnerText))
								{
									exclusionZone2 = (ExclusionZone)dictionary_0[xmlNode.InnerText];
									result = exclusionZone2;
									return result;
								}
								exclusionZone.SetGuid(xmlNode.InnerText);
								dictionary_0.Add(exclusionZone.GetGuid(), exclusionZone);
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
					if (Information.IsNothing(exclusionZone.GetAffectedUnitTypes()))
					{
						exclusionZone.SetAffectedUnitTypes(new ObservableCollection<GlobalVariables.ActiveUnitType>
						{
							GlobalVariables.ActiveUnitType.Aircraft,
							GlobalVariables.ActiveUnitType.Ship,
							GlobalVariables.ActiveUnitType.Submarine,
							GlobalVariables.ActiveUnitType.Facility
						});
					}
					exclusionZone2 = exclusionZone;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100992", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					exclusionZone2 = new ExclusionZone();
					ProjectData.ClearProjectError();
				}
				result = exclusionZone2;
				return result;
			}
		}

		// Token: 0x04002B46 RID: 11078
		public static Func<GlobalVariables.ActiveUnitType, string> ActiveUnitTypeFunc = delegate(GlobalVariables.ActiveUnitType activeUnitType_0)
		{
			int num = (int)activeUnitType_0;
			return num.ToString();
		};

		// Token: 0x04002B47 RID: 11079
		public Misc.PostureStance MarkViolatorAs;
	}
}
