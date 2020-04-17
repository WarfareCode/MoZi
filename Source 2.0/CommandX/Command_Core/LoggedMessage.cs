using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace Command_Core
{
	// Token: 日志消息
	public sealed class LoggedMessage : Subject
	{
		// Token: 0x06005AD8 RID: 23256 RVA: 0x002860B8 File Offset: 0x002842B8
		public Color method_11()
		{
			Color color;
			Color result;
			switch (this.messageType)
			{
			case LoggedMessage.MessageType.NewContact:
			case LoggedMessage.MessageType.NewAirContact:
			case LoggedMessage.MessageType.NewSurfaceContact:
			case LoggedMessage.MessageType.NewUnderwaterContact:
			case LoggedMessage.MessageType.NewGroundContact:
				color = Color.Yellow;
				result = color;
				return result;
			case LoggedMessage.MessageType.ContactChange:
				color = Color.Yellow;
				result = color;
				return result;
			case LoggedMessage.MessageType.WeaponEndgame:
			case LoggedMessage.MessageType.WeaponDamage:
			case LoggedMessage.MessageType.WeaponLogic:
			case LoggedMessage.MessageType.UnguidedWeaponModifiers:
				color = Color.LightGray;
				result = color;
				return result;
			case LoggedMessage.MessageType.AirOps:
			case LoggedMessage.MessageType.DockingOps:
				color = Color.LimeGreen;
				result = color;
				return result;
			case LoggedMessage.MessageType.UnitLost:
				color = Color.Red;
				result = color;
				return result;
			case LoggedMessage.MessageType.UnitDamage:
				color = Color.OrangeRed;
				result = color;
				return result;
			case LoggedMessage.MessageType.PointDefence:
				color = Color.Gray;
				result = color;
				return result;
			case LoggedMessage.MessageType.UnitAI:
				color = Color.Gray;
				result = color;
				return result;
			case LoggedMessage.MessageType.EventEngine:
				color = Color.LightBlue;
				result = color;
				return result;
			case LoggedMessage.MessageType.NewWeaponContact:
			case LoggedMessage.MessageType.NewMineContact:
				color = Color.Red;
				result = color;
				return result;
			case LoggedMessage.MessageType.CommsIsolatedMessage:
				color = Color.Gray;
				result = color;
				return result;
			}
			color = Color.White;
			result = color;
			return result;
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x002861AC File Offset: 0x002843AC
		public Font method_12(Font font_0)
		{
			LoggedMessage.MessageType messageType = this.messageType;
			switch (messageType)
			{
			case LoggedMessage.MessageType.WeaponEndgame:
			case LoggedMessage.MessageType.WeaponDamage:
			case LoggedMessage.MessageType.PointDefence:
			case LoggedMessage.MessageType.WeaponLogic:
			case LoggedMessage.MessageType.UnitAI:
				goto IL_55;
			case LoggedMessage.MessageType.AirOps:
			case LoggedMessage.MessageType.UnitLost:
			case LoggedMessage.MessageType.UnitDamage:
			case LoggedMessage.MessageType.UI:
				break;
			default:
				if (messageType == LoggedMessage.MessageType.CommsIsolatedMessage || messageType == LoggedMessage.MessageType.UnguidedWeaponModifiers)
				{
					goto IL_55;
				}
				break;
			}
			Font font = new Font(font_0, FontStyle.Regular);
			Font result = font;
			return result;
			IL_55:
			font = new Font(font_0, FontStyle.Italic);
			result = font;
			return result;
		}

		// Token: 0x06005ADA RID: 23258 RVA: 0x0028621C File Offset: 0x0028441C
		public void Save(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("LM");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Inc", this.Increment.ToString());
				xmlWriter_0.WriteElementString("Text", this.Text);
				xmlWriter_0.WriteElementString("TStamp", this.TStamp.ToBinary().ToString());
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Level";
				int level = (int)this.Level;
				xmlWriter.WriteElementString(localName, level.ToString());
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "Type";
				level = (int)this.messageType;
				xmlWriter2.WriteElementString(localName2, level.ToString());
				xmlWriter_0.WriteElementString("R_ID", this.ReporterID);
				if (!Information.IsNothing(this.side))
				{
					xmlWriter_0.WriteElementString("Side", this.side.GetGuid());
				}
				if (!Information.IsNothing(this.Location) && (this.Location.GetLatitude() != 0.0 | this.Location.GetLongitude() != 0.0))
				{
					xmlWriter_0.WriteElementString("Loc", XmlConvert.ToString(this.Location.GetLongitude()) + "_" + XmlConvert.ToString(this.Location.GetLatitude()));
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101011", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x00028C6F File Offset: 0x00026E6F
		private LoggedMessage()
		{
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x002863EC File Offset: 0x002845EC
		public static LoggedMessage Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0)
		{
			LoggedMessage loggedMessage2;
			LoggedMessage result;
			try
			{
				LoggedMessage loggedMessage = new LoggedMessage();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num > 1539345862u)
						{
							if (num <= 2595629539u)
							{
								if (num != 1719845082u)
								{
									if (num != 2590053246u)
									{
										if (num != 2595629539u)
										{
											continue;
										}
										if (Operators.CompareString(name, "R_ID", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "Side", false) != 0)
										{
											continue;
										}
										if (dictionary_0.ContainsKey(xmlNode.InnerText))
										{
											loggedMessage.side = (Side)dictionary_0[xmlNode.InnerText];
											continue;
										}
										loggedMessage2 = null;
										result = loggedMessage2;
										return result;
									}
								}
								else
								{
									if (Operators.CompareString(name, "TStamp", false) != 0)
									{
										continue;
									}
									goto IL_1E5;
								}
							}
							else if (num <= 2782757437u)
							{
								if (num != 2653670837u)
								{
									if (num == 2782757437u && Operators.CompareString(name, "Loc", false) == 0)
									{
										goto IL_2D5;
									}
									continue;
								}
								else if (Operators.CompareString(name, "ReporterID", false) != 0)
								{
									continue;
								}
							}
							else if (num != 3055432035u)
							{
								if (num != 3512062061u || Operators.CompareString(name, "Type", false) != 0)
								{
									continue;
								}
								if (Versioned.IsNumeric(xmlNode.InnerText))
								{
									loggedMessage.messageType = (LoggedMessage.MessageType)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								loggedMessage.messageType = (LoggedMessage.MessageType)Enum.Parse(typeof(LoggedMessage.MessageType), xmlNode.InnerText, true);
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "TimeStamp", false) == 0)
								{
									goto IL_1E5;
								}
								continue;
							}
							loggedMessage.ReporterID = xmlNode.InnerText;
							continue;
							IL_1E5:
							loggedMessage.TStamp = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
							continue;
						}
						if (num <= 1041509726u)
						{
							if (num != 65639134u)
							{
								if (num != 192164839u)
								{
									if (num == 1041509726u && Operators.CompareString(name, "Text", false) == 0)
									{
										loggedMessage.Text = xmlNode.InnerText;
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "Inc", false) != 0)
								{
									continue;
								}
							}
							else if (Operators.CompareString(name, "Increment", false) != 0)
							{
								continue;
							}
							loggedMessage.Increment = Conversions.ToLong(xmlNode.InnerText);
							continue;
						}
						if (num != 1096112509u)
						{
							if (num != 1458105184u)
							{
								if (num != 1539345862u || Operators.CompareString(name, "Location", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "ID", false) == 0)
								{
									loggedMessage.SetGuid(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "Level", false) == 0)
							{
								loggedMessage.Level = Conversions.ToByte(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						IL_2D5:
						if (xmlNode.HasChildNodes)
						{
							loggedMessage.Location = GeoPoint.Load(ref xmlNode, ref dictionary_0);
						}
						else
						{
							string[] array = xmlNode.InnerText.Split(new char[]
							{
								'_'
							});
							loggedMessage.Location = new GeoPoint(XmlConvert.ToDouble(array[0]), XmlConvert.ToDouble(array[1]));
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
				loggedMessage2 = loggedMessage;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101012", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				loggedMessage2 = new LoggedMessage();
				ProjectData.ClearProjectError();
			}
			result = loggedMessage2;
			return result;
		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x00286828 File Offset: 0x00284A28
		public LoggedMessage(long theIncrement, string theText, LoggedMessage.MessageType theType, DateTime theTimestamp, string theReporterID, byte theLevel, Side theSide = null, GeoPoint theLocation = null)
		{
			this.Increment = theIncrement;
			this.Text = theText;
			this.TStamp = theTimestamp;
			this.Level = theLevel;
			this.messageType = theType;
			this.ReporterID = theReporterID;
			this.side = theSide;
			this.Location = theLocation;
		}

		// Token: 0x04002D7E RID: 11646
		public long Increment;

		// Token: 0x04002D7F RID: 11647
		public string Text = "";

		// Token: 0x04002D80 RID: 11648
		public DateTime TStamp;

		// Token: 0x04002D81 RID: 11649
		public byte Level;

		// Token: 0x04002D82 RID: 11650
		public LoggedMessage.MessageType messageType;

		// Token: 0x04002D83 RID: 11651
		public string ReporterID = "";

		// Token: 0x04002D84 RID: 11652
		public Side side;

		// Token: 0x04002D85 RID: 11653
		public GeoPoint Location;

		// Token: 0x04002D86 RID: 11654
		public bool bool_8;

		// Token: 0x02000B03 RID: 2819
		public enum MessageType : byte
		{
			// Token: 0x04002D88 RID: 11656
			None,
			// Token: 0x04002D89 RID: 11657
			NewContact,
			// Token: 0x04002D8A RID: 11658
			ContactChange,
			// Token: 0x04002D8B RID: 11659
			WeaponEndgame,
			// Token: 0x04002D8C RID: 11660
			WeaponDamage,
			// Token: 0x04002D8D RID: 11661
			AirOps,
			// Token: 0x04002D8E RID: 11662
			UnitLost,
			// Token: 0x04002D8F RID: 11663
			UnitDamage,
			// Token: 0x04002D90 RID: 11664
			PointDefence,
			// Token: 0x04002D91 RID: 11665
			UI,
			// Token: 0x04002D92 RID: 11666
			WeaponLogic,
			// Token: 0x04002D93 RID: 11667
			UnitAI,
			// Token: 0x04002D94 RID: 11668
			EventEngine = 13,
			// Token: 0x04002D95 RID: 11669
			NewWeaponContact,
			// Token: 0x04002D96 RID: 11670
			DockingOps,
			// Token: 0x04002D97 RID: 11671
			SpecialMessage,
			// Token: 0x04002D98 RID: 11672
			NewMineContact,
			// Token: 0x04002D99 RID: 11673
			CommsIsolatedMessage,
			// Token: 0x04002D9A RID: 11674
			NewAirContact,
			// Token: 0x04002D9B RID: 11675
			NewSurfaceContact,
			// Token: 0x04002D9C RID: 11676
			NewUnderwaterContact,
			// Token: 0x04002D9D RID: 11677
			NewGroundContact,
			// Token: 0x04002D9E RID: 11678
			UnguidedWeaponModifiers
		}

		// Token: 0x02000B04 RID: 2820
		public sealed class MessageShowOptions
		{
			// Token: 0x06005ADE RID: 23262 RVA: 0x00028C8D File Offset: 0x00026E8D
			public MessageShowOptions(bool bool_2, bool bool_3)
			{
				this.bool_0 = bool_2;
				this.bool_1 = bool_3;
			}

			// Token: 0x04002D9F RID: 11679
			public bool bool_0;

			// Token: 0x04002DA0 RID: 11680
			public bool bool_1;
		}
	}
}
