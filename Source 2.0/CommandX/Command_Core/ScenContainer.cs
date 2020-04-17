using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns31;
using ns6;
using SevenZip;

namespace Command_Core
{
	// Token: 0x02000B52 RID: 2898
	[Serializable]
	public sealed class ScenContainer
	{
		// Token: 0x06005F2D RID: 24365 RVA: 0x002CFC18 File Offset: 0x002CDE18
		public static ScenContainer GetScenContainer(string strScenarioObject)
		{
			ScenContainer result;
			try
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(ScenContainer));
				StringReader stringReader = new StringReader(strScenarioObject);
				XmlTextReader xmlTextReader = new XmlTextReader(stringReader);
				ScenContainer scenContainer = (ScenContainer)xmlSerializer.Deserialize(xmlTextReader);
				xmlTextReader.Close();
				stringReader.Close();
				result = scenContainer;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101047", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x002CFCBC File Offset: 0x002CDEBC
		public static string smethod_1(string string_0, string string_1)
		{
			XmlTextReader xmlTextReader = new XmlTextReader(string_0);
			string result = "";
			using (xmlTextReader)
			{
				if (xmlTextReader.ReadToDescendant(string_1))
				{
					result = xmlTextReader.ReadElementContentAsString();
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06005F2F RID: 24367 RVA: 0x002CFD14 File Offset: 0x002CDF14
		public string method_0()
		{
			Class391 @class = new Class391();
			byte[] byte_ = new byte[this.Scenario_Compressed.Length + 1];
			byte_ = this.Scenario_Compressed;
			byte[] array = @class.method_9(byte_, 0, 0, 0);
			int num = array.Length - 1;
			while (array[num] == 0)
			{
				num--;
			}
			byte[] array2 = new byte[num + 1 + 1];
			Array.Copy(array, array2, num + 1);
			array = array2;
			array = Misc.smethod_5(array);
			array = Misc.smethod_7(array);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x06005F30 RID: 24368 RVA: 0x002CFD94 File Offset: 0x002CDF94
		public string method_1()
		{
			Stream1 archiveStream = new Stream1(this.Scenario_Compressed);
			Stream1 stream = new Stream1();
			new SevenZipExtractor(archiveStream, GameGeneral.strPassword).ExtractFile(0, stream);
			stream.Seek(0L, SeekOrigin.Begin);
			byte[] array = stream.ToArray();
			array = Misc.smethod_5(array);
			array = Misc.smethod_7(array);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x06005F31 RID: 24369 RVA: 0x002CFDF8 File Offset: 0x002CDFF8
		public void method_2()
		{
			GameGeneral.ForceGarbageCollection();
			MemoryStream scenarioStream = GameGeneral.GetScenarioStream(this.ScenarioObject);
			this.CompressVersion = 1;
			this.Scenario_Compressed = Class256.smethod_1(scenarioStream, Enum117.const_4);
			scenarioStream.Close();
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x0002A485 File Offset: 0x00028685
		public void method_3(Stream stream_)
		{
			GameGeneral.ForceGarbageCollection();
			this.CompressVersion = 1;
			this.Scenario_Compressed = Class256.smethod_1(stream_, Enum117.const_4);
		}

		// Token: 0x06005F33 RID: 24371 RVA: 0x002CFE30 File Offset: 0x002CE030
		public void CompressScenarioStream()
		{
			GameGeneral.ForceGarbageCollection();
			MemoryStream scenarioStream = GameGeneral.GetScenarioStream(this.ScenarioObject);
			this.CompressVersion = 2;
			Stream1 stream = Class256.CompressStream(scenarioStream, CompressionLevel.High);
			this.Scenario_Compressed = stream.ToArray();
			scenarioStream.Close();
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x002CFE70 File Offset: 0x002CE070
		public void CompressScenario(Stream stream_)
		{
			this.CompressVersion = 2;
			try
			{
				Stream1 stream = Class256.CompressStream(stream_, CompressionLevel.High);
				this.Scenario_Compressed = stream.ToArray();
			}
			catch (OutOfMemoryException projectError)
			{
				ProjectData.SetProjectError(projectError);
				GameGeneral.ForceGarbageCollection();
				Stream1 stream2 = Class256.CompressStream(stream_, CompressionLevel.High);
				this.Scenario_Compressed = stream2.ToArray();
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005F35 RID: 24373 RVA: 0x002CFED4 File Offset: 0x002CE0D4
		public void TryToCompressScenario(Stream stream_)
		{
			try
			{
				this.CompressScenario(stream_);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				this.method_3(stream_);
				ex2.Data.Add("Error at 200055", ex2.Message);
				GameGeneral.LogException(ref ex2);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005F36 RID: 24374 RVA: 0x002CFF30 File Offset: 0x002CE130
		public void SaveTempScenarioFile(string strTempScenarioFile)
		{
			if (Information.IsNothing(this.Scenario_Compressed))
			{
				try
				{
					this.CompressScenarioStream();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					bool arg_27_0 = Debugger.IsAttached;
					this.method_2();
					ex2.Data.Add("Error at 200056", ex2.Message);
					GameGeneral.LogException(ref ex2);
					ProjectData.ClearProjectError();
				}
			}
			this.ScenarioObject = null;
			FileStream fileStream = new FileStream(strTempScenarioFile, FileMode.Create);
			new XmlSerializer(base.GetType()).Serialize(fileStream, this);
			fileStream.Close();
		}

		// Token: 0x06005F37 RID: 24375 RVA: 0x002CFFC8 File Offset: 0x002CE1C8
		public override string ToString()
		{
			Stream1 stream = this.method_8();
			string result = Misc.smethod_49(stream);
			stream.Dispose();
			return result;
		}

		// Token: 0x06005F38 RID: 24376 RVA: 0x002CFFEC File Offset: 0x002CE1EC
		private Stream1 method_8()
		{
			if (Information.IsNothing(this.Scenario_Compressed))
			{
				try
				{
					this.CompressScenarioStream();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					this.method_2();
					ex2.Data.Add("Error at 200057", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			this.ScenarioObject = null;
			Stream1 stream = new Stream1();
			new XmlSerializer(typeof(ScenContainer)).Serialize(stream, this);
			return stream;
		}

		// Token: 0x06005F39 RID: 24377 RVA: 0x002D008C File Offset: 0x002CE28C
		public static ScenContainer smethod_2(string string_0)
		{
			new FileInfo(string_0);
			ScenContainer scenContainer = new ScenContainer(null);
			FileStream fileStream = new FileStream(string_0, FileMode.Open);
			scenContainer = (ScenContainer)new XmlSerializer(scenContainer.GetType()).Deserialize(fileStream);
			fileStream.Close();
			return scenContainer;
		}

		// Token: 0x06005F3A RID: 24378 RVA: 0x002D00D0 File Offset: 0x002CE2D0
		public string method_9()
		{
			string result = "";
			switch (this.CompressVersion)
			{
			case 1:
				result = this.method_0();
				break;
			case 2:
				result = this.method_1();
				break;
			case 3:
				result = DBCryptoService.Decrypt(this.method_0(), GameGeneral.strPassword);
				break;
			}
			return result;
		}

		// Token: 0x06005F3B RID: 24379 RVA: 0x002D0128 File Offset: 0x002CE328
		public Scenario LoadScenario(ref string ErrorFeedback, ref double PercentageComplete, bool ForceDeepRebuild)
		{
			return Scenario.LoadScenario(this.method_9(), ref ErrorFeedback, ref PercentageComplete, ForceDeepRebuild);
		}

		// Token: 0x06005F3C RID: 24380 RVA: 0x002D0148 File Offset: 0x002CE348
		public ScenContainer(Scenario scenario_)
		{
			this.CompressVersion = 1;
			this.IsCampaignCheckpoint = false;
			this.ScenarioObject = scenario_;
			if (!Information.IsNothing(scenario_))
			{
				if (!Information.IsNothing(scenario_.GetScenarioTitle()))
				{
					this.ScenTitle = scenario_.GetScenarioTitle().ToString();
				}
				if (!Information.IsNothing(scenario_.GetDescription()))
				{
					this.ScenDescription = scenario_.GetDescription().ToString();
				}
				this.Complexity = scenario_.Meta_Complexity;
				this.Difficulty = scenario_.Meta_Difficulty;
				this.ScenSetting = scenario_.Meta_ScenSetting;
			}
			else
			{
				this.Complexity = 1;
				this.Difficulty = 1;
				this.ScenSetting = "Not set";
			}
		}

		// Token: 0x06005F3D RID: 24381 RVA: 0x0002A4A0 File Offset: 0x000286A0
		public ScenContainer()
		{
			this.CompressVersion = 1;
			this.IsCampaignCheckpoint = false;
		}

		// Token: 0x0400325A RID: 12890
		public string ScenTitle;

		// Token: 0x0400325B RID: 12891
		public string ScenDescription;

		// Token: 0x0400325C RID: 12892
		public string ScenAuthor;

		// Token: 0x0400325D RID: 12893
		public short Complexity;

		// Token: 0x0400325E RID: 12894
		public short Difficulty;

		// Token: 0x0400325F RID: 12895
		public string ScenSetting;

		// Token: 0x04003260 RID: 12896
		public short ScenDate;

		// Token: 0x04003261 RID: 12897
		private Scenario ScenarioObject;

		// Token: 0x04003262 RID: 12898
		public byte[] Scenario_Compressed;

		// Token: 0x04003263 RID: 12899
		public int CompressVersion;

		// Token: 0x04003264 RID: 12900
		public bool IsCampaignCheckpoint;
	}
}
