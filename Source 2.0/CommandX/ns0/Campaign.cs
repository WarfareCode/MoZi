using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{
	// Token: 0x02000A20 RID: 2592
	public sealed class Campaign
	{
		// Token: 0x060050C0 RID: 20672 RVA: 0x0020D3BC File Offset: 0x0020B5BC
		private void Save(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Campaign");
				xmlWriter_0.WriteElementString("ID", this.ID);
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("Description", this.strDescription);
				xmlWriter_0.WriteElementString("EndingText", this.strEndingText);
				if (this.ScenarioList.Count > 0)
				{
					xmlWriter_0.WriteStartElement("Items");
					foreach (Campaign.Scenario current in this.ScenarioList)
					{
						Type type = current.GetType();
						if (type == typeof(Campaign.ScenarioInfo))
						{
							Campaign.ScenarioInfo scenarioInfo = (Campaign.ScenarioInfo)current;
							xmlWriter_0.WriteStartElement("Scenario");
							xmlWriter_0.WriteElementString("Name", scenarioInfo.strScenarioName);
							xmlWriter_0.WriteElementString("ID", scenarioInfo.strScenarioID);
							xmlWriter_0.WriteElementString("File", scenarioInfo.strScenarioFile);
							xmlWriter_0.WriteElementString("PassScore", Conversions.ToString(scenarioInfo.GetPassScore()));
							xmlWriter_0.WriteEndElement();
						}
						else if (type == typeof(Campaign.ScenarioInstance))
						{
							xmlWriter_0.WriteStartElement("Attachment");
							Campaign.ScenarioInstance scenarioInstance = (Campaign.ScenarioInstance)current;
							xmlWriter_0.WriteElementString("Name", scenarioInstance.strScenarioName);
							xmlWriter_0.WriteElementString("ID", scenarioInstance.strScenarioID);
							xmlWriter_0.WriteEndElement();
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101311", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x0020D5D4 File Offset: 0x0020B7D4
		private static Campaign Load(ref XmlNode xmlNode_0)
		{
			Campaign result = null;
			try
			{
				Campaign campaign = new Campaign();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "Name", false) != 0)
							{
								if (Operators.CompareString(name, "Description", false) != 0)
								{
									if (Operators.CompareString(name, "EndingText", false) != 0)
									{
										if (Operators.CompareString(name, "Items", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator2.MoveNext())
											{
												XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
												string name2 = xmlNode2.Name;
												if (Operators.CompareString(name2, "Scenario", false) != 0)
												{
													if (Operators.CompareString(name2, "Attachment", false) == 0)
													{
														Campaign.ScenarioInstance scenarioInstance = new Campaign.ScenarioInstance();
														IEnumerator enumerator3 = xmlNode2.ChildNodes.GetEnumerator();
														try
														{
															while (enumerator3.MoveNext())
															{
																XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
																string name3 = xmlNode3.Name;
																if (Operators.CompareString(name3, "Name", false) != 0)
																{
																	if (Operators.CompareString(name3, "ID", false) == 0)
																	{
																		scenarioInstance.strScenarioID = xmlNode3.InnerText;
																	}
																}
																else
																{
																	scenarioInstance.strScenarioName = xmlNode3.InnerText;
																}
															}
														}
														finally
														{
															if (enumerator3 is IDisposable)
															{
																(enumerator3 as IDisposable).Dispose();
															}
														}
														campaign.ScenarioList.Add(scenarioInstance);
													}
												}
												else
												{
													Campaign.ScenarioInfo scenarioInfo = new Campaign.ScenarioInfo();
													IEnumerator enumerator4 = xmlNode2.ChildNodes.GetEnumerator();
													try
													{
														while (enumerator4.MoveNext())
														{
															XmlNode xmlNode4 = (XmlNode)enumerator4.Current;
															string name4 = xmlNode4.Name;
															if (Operators.CompareString(name4, "Name", false) != 0)
															{
																if (Operators.CompareString(name4, "ID", false) != 0)
																{
																	if (Operators.CompareString(name4, "File", false) != 0)
																	{
																		if (Operators.CompareString(name4, "PassScore", false) == 0)
																		{
																			scenarioInfo.SetPassScore(Conversions.ToInteger(xmlNode4.InnerText));
																		}
																	}
																	else
																	{
																		scenarioInfo.strScenarioFile = xmlNode4.InnerText;
																	}
																}
																else
																{
																	scenarioInfo.strScenarioID = xmlNode4.InnerText;
																}
															}
															else
															{
																scenarioInfo.strScenarioName = xmlNode4.InnerText;
															}
														}
													}
													finally
													{
														if (enumerator4 is IDisposable)
														{
															(enumerator4 as IDisposable).Dispose();
														}
													}
													campaign.ScenarioList.Add(scenarioInfo);
												}
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
									campaign.strEndingText = xmlNode.InnerText;
								}
								else
								{
									campaign.strDescription = xmlNode.InnerText;
								}
							}
							else
							{
								campaign.Name = xmlNode.InnerText;
							}
						}
						else
						{
							campaign.ID = xmlNode.InnerText;
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
				result = campaign;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101312", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x0020D9C0 File Offset: 0x0020BBC0
		public Campaign()
		{
			this.ScenarioList = new List<Campaign.Scenario>();
			this.ID = Guid.NewGuid().ToString();
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x0020D9F8 File Offset: 0x0020BBF8
		public static Campaign GetCampaign(string string_5)
		{
			FileStream fileStream = new FileStream(string_5, FileMode.Open, FileAccess.Read);
			XmlDocument xmlDocument = new XmlDocument();
			using (fileStream)
			{
				xmlDocument.Load(fileStream);
			}
			XmlNode xmlNode = xmlDocument.ChildNodes[1];
			Campaign campaign = Campaign.Load(ref xmlNode);
			campaign.campaignDir = Path.GetDirectoryName(string_5);
			return campaign;
		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x0020DA68 File Offset: 0x0020BC68
		public void method_1(string string_5)
		{
			FileStream fileStream = new FileStream(string_5, FileMode.Create, FileAccess.Write);
			using (fileStream)
			{
				XmlWriter xmlWriter = XmlWriter.Create(fileStream, new XmlWriterSettings
				{
					Indent = true,
					IndentChars = "    "
				});
				this.Save(ref xmlWriter);
				xmlWriter.Flush();
				fileStream.Flush();
			}
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x0020DAD4 File Offset: 0x0020BCD4
		public static Campaign smethod_2(string string_5, string string_6)
		{
			List<string> list = new List<string>();
			Campaign.smethod_3(string_5, list);
			Campaign campaign2;
			Campaign result;
			using (List<string>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Campaign campaign = Campaign.GetCampaign(enumerator.Current);
					if (Operators.CompareString(campaign.ID, string_6, false) == 0)
					{
						campaign2 = campaign;
						result = campaign2;
						return result;
					}
				}
			}
			campaign2 = null;
			result = campaign2;
			return result;
		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x0020DB50 File Offset: 0x0020BD50
		public static void smethod_3(string string_5, List<string> list_1)
		{
			string[] files = Directory.GetFiles(string_5);
			checked
			{
				for (int i = 0; i < files.Length; i++)
				{
					string text = files[i];
					if (Operators.CompareString(Path.GetExtension(text), ".campaign", false) == 0)
					{
						list_1.Add(text);
					}
				}
				string[] directories = Directory.GetDirectories(string_5);
				for (int j = 0; j < directories.Length; j++)
				{
					Campaign.smethod_3(directories[j], list_1);
				}
			}
		}

		// Token: 0x060050C7 RID: 20679 RVA: 0x0020DBC0 File Offset: 0x0020BDC0
		public Campaign.ScenarioInfo method_2(string string_5)
		{
			Campaign.ScenarioInfo scenarioInfo;
			Campaign.ScenarioInfo result;
			foreach (Campaign.Scenario current in this.ScenarioList)
			{
				if (current.GetType() == typeof(Campaign.ScenarioInfo) && Operators.CompareString(((Campaign.ScenarioInfo)current).strScenarioID, string_5, false) == 0)
				{
					scenarioInfo = (Campaign.ScenarioInfo)current;
					result = scenarioInfo;
					return result;
				}
			}
			scenarioInfo = null;
			result = scenarioInfo;
			return result;
		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x0020DC50 File Offset: 0x0020BE50
		public string method_3(string string_5)
		{
			string text;
			string result;
			foreach (Campaign.Scenario current in this.ScenarioList)
			{
				if (current.GetType() == typeof(Campaign.ScenarioInfo))
				{
					text = Path.GetDirectoryName(string_5) + "\\" + ((Campaign.ScenarioInfo)current).strScenarioFile;
					result = text;
					return result;
				}
			}
			text = null;
			result = text;
			return result;
		}

		// Token: 0x040025EC RID: 9708
		public string ID;

		// Token: 0x040025ED RID: 9709
		public string Name;

		// Token: 0x040025EE RID: 9710
		public string strDescription;

		// Token: 0x040025EF RID: 9711
		public List<Campaign.Scenario> ScenarioList;

		// Token: 0x040025F0 RID: 9712
		public string strEndingText;

		// Token: 0x040025F1 RID: 9713
		public string campaignDir;

		// Token: 0x02000A21 RID: 2593
		public class Scenario
		{
			// Token: 0x040025F2 RID: 9714
			public string strScenarioName;
		}

		// Token: 0x02000A22 RID: 2594
		public sealed class ScenarioInfo : Campaign.Scenario
		{
			// Token: 0x060050CA RID: 20682 RVA: 0x0020DCE0 File Offset: 0x0020BEE0
			public int GetPassScore()
			{
				return this.PassScore;
			}

			// Token: 0x060050CB RID: 20683 RVA: 0x00025C81 File Offset: 0x00023E81
			public void SetPassScore(int int_1)
			{
				this.PassScore = int_1;
			}

			// Token: 0x040025F3 RID: 9715
			public string strScenarioID;

			// Token: 0x040025F4 RID: 9716
			public string strScenarioFile;

			// Token: 0x040025F5 RID: 9717
			private int PassScore;
		}

		// Token: 0x02000A23 RID: 2595
		public sealed class ScenarioInstance : Campaign.Scenario
		{
			// Token: 0x040025F6 RID: 9718
			public string strScenarioID;
		}
	}
}
