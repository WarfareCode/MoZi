using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns29;

namespace ns3
{
	// Token: 0x02000BBF RID: 3007
	public sealed class EventExport_XMLFile : IEventExporter
	{
		// Token: 0x060063A8 RID: 25512 RVA: 0x00315584 File Offset: 0x00313784
		[CompilerGenerated]
		public string GetExportDirectory()
		{
			return this.string_0;
		}

		// Token: 0x060063A9 RID: 25513 RVA: 0x0002B9B5 File Offset: 0x00029BB5
		[CompilerGenerated]
		public void SetExportDirectory(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x0031559C File Offset: 0x0031379C
		[CompilerGenerated]
		public _RunMode GetRunMode()
		{
			return this.enum100_0;
		}

		// Token: 0x060063AB RID: 25515 RVA: 0x0002B9BE File Offset: 0x00029BBE
		[CompilerGenerated]
		public void SetRunMode(_RunMode enum100_1)
		{
			this.enum100_0 = enum100_1;
		}

		// Token: 0x060063AC RID: 25516 RVA: 0x0002B9C7 File Offset: 0x00029BC7
		[CompilerGenerated]
		public bool IsUseZeroHour()
		{
			return this.bool_0;
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x0002B9CF File Offset: 0x00029BCF
		[CompilerGenerated]
		public void SetUseZeroHour(bool bool_13)
		{
			this.bool_0 = bool_13;
		}

		// Token: 0x060063AE RID: 25518 RVA: 0x0002B9D8 File Offset: 0x00029BD8
		[CompilerGenerated]
		public bool IsExportSensorDetectionSuccess()
		{
			return this.bool_1;
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x0002B9E0 File Offset: 0x00029BE0
		[CompilerGenerated]
		public void SetExportSensorDetectionSuccess(bool bool_13)
		{
			this.bool_1 = bool_13;
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x0002B9E9 File Offset: 0x00029BE9
		[CompilerGenerated]
		public bool IsExportSensorDetectionFailure()
		{
			return this.bool_2;
		}

		// Token: 0x060063B1 RID: 25521 RVA: 0x0002B9F1 File Offset: 0x00029BF1
		[CompilerGenerated]
		public void SetExportSensorDetectionFailure(bool bool_13)
		{
			this.bool_2 = bool_13;
		}

		// Token: 0x060063B2 RID: 25522 RVA: 0x0002B9FA File Offset: 0x00029BFA
		[CompilerGenerated]
		public bool IsExportWeaponFired()
		{
			return this.bool_3;
		}

		// Token: 0x060063B3 RID: 25523 RVA: 0x0002BA02 File Offset: 0x00029C02
		[CompilerGenerated]
		public void SetExportWeaponFired(bool bool_13)
		{
			this.bool_3 = bool_13;
		}

		// Token: 0x060063B4 RID: 25524 RVA: 0x0002BA0B File Offset: 0x00029C0B
		[CompilerGenerated]
		public bool IsExportWeaponEndgame()
		{
			return this.bool_4;
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x0002BA13 File Offset: 0x00029C13
		[CompilerGenerated]
		public void SetExportWeaponEndgame(bool bool_13)
		{
			this.bool_4 = bool_13;
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x0002BA1C File Offset: 0x00029C1C
		[CompilerGenerated]
		public bool IsExportUnitPositions()
		{
			return this.bool_5;
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x0002BA24 File Offset: 0x00029C24
		[CompilerGenerated]
		public void SetExportUnitPositions(bool bool_13)
		{
			this.bool_5 = bool_13;
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x0002BA2D File Offset: 0x00029C2D
		[CompilerGenerated]
		public bool IsExportEngagementCycle()
		{
			return this.bool_6;
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x0002BA35 File Offset: 0x00029C35
		[CompilerGenerated]
		public void SetExportEngagementCycle(bool bool_13)
		{
			this.bool_6 = bool_13;
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x0002BA3E File Offset: 0x00029C3E
		[CompilerGenerated]
		public bool imethod_24()
		{
			return this.bool_7;
		}

		// Token: 0x060063BB RID: 25531 RVA: 0x0002BA46 File Offset: 0x00029C46
		[CompilerGenerated]
		public void imethod_25(bool bool_13)
		{
			this.bool_7 = bool_13;
		}

		// Token: 0x060063BC RID: 25532 RVA: 0x0002BA4F File Offset: 0x00029C4F
		[CompilerGenerated]
		public bool IsExportFuelConsumed()
		{
			return this.bool_8;
		}

		// Token: 0x060063BD RID: 25533 RVA: 0x0002BA57 File Offset: 0x00029C57
		[CompilerGenerated]
		public void SetExportFuelConsumed(bool bool_13)
		{
			this.bool_8 = bool_13;
		}

		// Token: 0x060063BE RID: 25534 RVA: 0x0002BA60 File Offset: 0x00029C60
		[CompilerGenerated]
		public bool IsExportFuelTransfer()
		{
			return this.bool_9;
		}

		// Token: 0x060063BF RID: 25535 RVA: 0x0002BA68 File Offset: 0x00029C68
		[CompilerGenerated]
		public void SetExportFuelTransfer(bool bool_13)
		{
			this.bool_9 = bool_13;
		}

		// Token: 0x060063C0 RID: 25536 RVA: 0x0002BA71 File Offset: 0x00029C71
		[CompilerGenerated]
		public bool imethod_30()
		{
			return this.bool_10;
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x003155B4 File Offset: 0x003137B4
		public EventExport_XMLFile(_RunMode enum100_1)
		{
			this.concurrentQueue_0 = new ConcurrentQueue<EventExportNotification>();
			this.bool_11 = false;
			this.bool_12 = false;
			this.dictionary_0 = new Dictionary<string, StreamWriter>();
			this.SetRunMode(enum100_1);
			this.SetExportDirectory(MyTemplate.GetApp().Info.DirectoryPath);
			if (File.Exists(Path.Combine(this.GetExportDirectory(), "EventExport.xml")))
			{
				File.Delete(Path.Combine(this.GetExportDirectory(), "EventExport.xml"));
			}
			Class2372 @class = new Class2372(EventExporters.strIniFile);
			this.SetUseZeroHour(@class.GetConfigList()["XML Settings"].GetValueString("UseZeroHour"));
			this.SetExportSensorDetectionSuccess(@class.GetConfigList()["XML Settings"].GetValueString("ExportSensorDetectionSuccess"));
			this.SetExportSensorDetectionFailure(@class.GetConfigList()["XML Settings"].GetValueString("ExportSensorDetectionFailure"));
			this.SetExportWeaponFired(@class.GetConfigList()["XML Settings"].GetValueString("ExportWeaponFired"));
			this.SetExportWeaponEndgame(@class.GetConfigList()["XML Settings"].GetValueString("ExportWeaponEndgame"));
			this.SetExportUnitPositions(@class.GetConfigList()["XML Settings"].GetValueString("ExportUnitPositions"));
			this.SetExportEngagementCycle(@class.GetConfigList()["XML Settings"].GetValueString("ExportEngagementCycle"));
			this.SetExportFuelConsumed(@class.GetConfigList()["XML Settings"].GetValueString("ExportFuelConsumed"));
			this.SetExportFuelTransfer(@class.GetConfigList()["XML Settings"].GetValueString("ExportFuelTransfer"));
			this.StartExport();
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x0002BA79 File Offset: 0x00029C79
		public void StartExport()
		{
			this.thread_0 = new Thread(new ThreadStart(this.method_0));
			this.thread_0.Priority = ThreadPriority.BelowNormal;
			this.thread_0.Start();
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x0002BAA9 File Offset: 0x00029CA9
		private void method_0()
		{
			while (true)
			{
				Thread.Sleep(100);
				if (!this.bool_11)
				{
					this.method_1();
				}
			}
		}

		// Token: 0x060063C4 RID: 25540 RVA: 0x00315770 File Offset: 0x00313970
		public void ExportEvent(ExportedEventType exportedEventType_0, Dictionary<string, Tuple<Type, string>> dictionary_1, Scenario scenario_0)
		{
			if (!this.bool_12)
			{
				if (!Directory.Exists(this.GetExportDirectory()))
				{
					Directory.CreateDirectory(this.GetExportDirectory());
				}
				this.bool_12 = true;
			}
			EventExportNotification eventExportNotification = new EventExportNotification();
			eventExportNotification.EventType = exportedEventType_0;
			eventExportNotification.EventParameters = dictionary_1;
			eventExportNotification.FileExportFolder = this.GetExportDirectory();
			this.concurrentQueue_0.Enqueue(eventExportNotification);
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x003157D4 File Offset: 0x003139D4
		private void method_1()
		{
			this.bool_11 = true;
			try
			{
				EventExportNotification eventExportNotification = null;
				XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
				xmlWriterSettings.Indent = true;
				xmlWriterSettings.IndentChars = "    ";
				xmlWriterSettings.ConformanceLevel = ConformanceLevel.Auto;
				while (this.concurrentQueue_0.Count > 0)
				{
					this.concurrentQueue_0.TryDequeue(out eventExportNotification);
					if (!Information.IsNothing(eventExportNotification))
					{
						string text = Path.Combine(eventExportNotification.FileExportFolder, "EventExport.xml");
						StreamWriter streamWriter;
						if (this.dictionary_0.ContainsKey(text))
						{
							streamWriter = this.dictionary_0[text];
						}
						else
						{
							streamWriter = File.AppendText(text);
							streamWriter.AutoFlush = true;
							this.dictionary_0.Add(text, streamWriter);
						}
						MemoryStream memoryStream = new MemoryStream();
						string value;
						using (memoryStream)
						{
							XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
							using (xmlWriter)
							{
								string localName;
								switch (eventExportNotification.EventType)
								{
								case ExportedEventType.WeaponFired:
									localName = "WeaponFired";
									break;
								case ExportedEventType.WeaponEndgame:
									localName = "WeaponEndgame";
									break;
								case ExportedEventType.FuelConsumed:
									localName = "FuelConsumed";
									break;
								case ExportedEventType.UnitDestroyed:
									localName = "UnitDestroyed";
									break;
								case ExportedEventType.SensorDetectionAttempt:
									localName = "SensorDetectionAttempt";
									break;
								case ExportedEventType.PointDefenceAndDECM:
									localName = "PointDefenceAndDECM";
									break;
								case ExportedEventType.UnitPositions:
									localName = "UnitPositions";
									break;
								case ExportedEventType.EngagementCycle:
									localName = "EngagementCycle";
									break;
								case ExportedEventType.FuelTransfer:
									localName = "FuelTransfer";
									break;
								default:
									localName = eventExportNotification.EventType.ToString();
									break;
								}
								xmlWriter.WriteStartElement(localName);
								foreach (KeyValuePair<string, Tuple<Type, string>> current in eventExportNotification.EventParameters)
								{
									xmlWriter.WriteElementString(current.Key, current.Value.Item2);
								}
								xmlWriter.WriteEndElement();
								xmlWriter.Flush();
							}
							value = Misc.smethod_49(memoryStream);
						}
						value = Misc.smethod_4(value);
						streamWriter.WriteLine(value);
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			finally
			{
				this.bool_11 = false;
			}
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x00315A7C File Offset: 0x00313C7C
		public void StopExport()
		{
			if (!Information.IsNothing(this.thread_0))
			{
				this.thread_0.Abort();
				this.thread_0 = null;
			}
			this.concurrentQueue_0 = new ConcurrentQueue<EventExportNotification>();
			foreach (StreamWriter current in this.dictionary_0.Values)
			{
				if (!Information.IsNothing(current))
				{
					current.Close();
					current.Dispose();
				}
			}
			this.dictionary_0.Clear();
			this.bool_11 = false;
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x00315B1C File Offset: 0x00313D1C
		public int GetEventQueueLength()
		{
			return this.concurrentQueue_0.Count;
		}

		// Token: 0x060063C8 RID: 25544 RVA: 0x00315B38 File Offset: 0x00313D38
		public string GetExporterName()
		{
			return "XMLFile";
		}

		// Token: 0x060063C9 RID: 25545 RVA: 0x0000945D File Offset: 0x0000765D
		public _ExporterType GetExporterType()
		{
			return _ExporterType.XMLFile;
		}

		// Token: 0x0400361B RID: 13851
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400361C RID: 13852
		[CompilerGenerated]
		private _RunMode enum100_0;

		// Token: 0x0400361D RID: 13853
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400361E RID: 13854
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x0400361F RID: 13855
		[CompilerGenerated]
		private bool bool_2 = false;

		// Token: 0x04003620 RID: 13856
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x04003621 RID: 13857
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x04003622 RID: 13858
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x04003623 RID: 13859
		[CompilerGenerated]
		private bool bool_6;

		// Token: 0x04003624 RID: 13860
		[CompilerGenerated]
		private bool bool_7;

		// Token: 0x04003625 RID: 13861
		[CompilerGenerated]
		private bool bool_8;

		// Token: 0x04003626 RID: 13862
		[CompilerGenerated]
		private bool bool_9;

		// Token: 0x04003627 RID: 13863
		[CompilerGenerated]
		private bool bool_10;

		// Token: 0x04003628 RID: 13864
		private ConcurrentQueue<EventExportNotification> concurrentQueue_0;

		// Token: 0x04003629 RID: 13865
		private bool bool_11;

		// Token: 0x0400362A RID: 13866
		private bool bool_12;

		// Token: 0x0400362B RID: 13867
		private Dictionary<string, StreamWriter> dictionary_0;

		// Token: 0x0400362C RID: 13868
		private Thread thread_0;
	}
}
