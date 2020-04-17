using System;
using System.Data.SQLite;
using System.Linq;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Command_Core
{
	// Token: 0x02000BF6 RID: 3062
	public sealed class EmissionContainer
	{
		// Token: 0x060065EB RID: 26091 RVA: 0x0034EE00 File Offset: 0x0034D000
		public Sensor method_0(int int_0, Scenario scenario_)
		{
			if (Information.IsNothing(this.sensor))
			{
				SQLiteConnection sQLiteConnection = scenario_.GetSQLiteConnection();
				this.sensor = DBFunctions.LoadSensorData(int_0, ref sQLiteConnection);
			}
			return this.sensor;
		}

		// Token: 0x060065EC RID: 26092 RVA: 0x0034EE3C File Offset: 0x0034D03C
		public string method_1(int int_0, Scenario scenario_0)
		{
			if (Information.IsNothing(this.sensor))
			{
				SQLiteConnection sQLiteConnection = scenario_0.GetSQLiteConnection();
				this.sensor = DBFunctions.LoadSensorData(int_0, ref sQLiteConnection);
			}
			string result;
			if (this.sensor.IsJammer())
			{
				result = "JAMMER";
			}
			else
			{
				string text = "";
				if (this.bool_1)
				{
					text = this.sensor.Name + " (" + this.sensor.Description + ")";
				}
				else if (this.sensor.IsSonar())
				{
					if (this.sensor.SearchAndTrackFrequencies.Count<Sensor.RadioElectronicFrequency>() > 0)
					{
						Sensor.FrequencyBand frequencyBand = this.sensor.SearchAndTrackFrequencies[0].frequencyBand;
						long num = frequencyBand - Sensor.FrequencyBand.LFSonar;
						if (num <= 3L)
						{
							switch ((uint)num)
							{
							case 0u:
								text = "LF sonar";
								break;
							case 1u:
								text = "MF sonar";
								break;
							case 2u:
								text = "HF sonar";
								break;
							case 3u:
								text = "VLF sonar";
								break;
							}
						}
					}
				}
				else
				{
					text = this.sensor.Description;
				}
				result = text;
			}
			return result;
		}

		// 构造函数
		public EmissionContainer(double double_0, bool bool_2, bool bool_3)
		{
			this.elapsedTime = (float)double_0; // 流逝时间
			this.bool_0 = bool_2;
			this.bool_1 = bool_3;
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x0034EF78 File Offset: 0x0034D178
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				XmlConvert.ToString(this.elapsedTime),
				"-",
				this.bool_0.ToString(),
				"-",
				this.bool_1.ToString()
			});
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x0034EFD0 File Offset: 0x0034D1D0
		public static EmissionContainer smethod_0(ref string string_0)
		{
			string[] array = string_0.Split(new char[]
			{
				'-'
			});
			double double_ = (double)XmlConvert.ToSingle(array[0]);
			bool bool_ = Conversions.ToBoolean(array[1]);
			bool bool_2 = Conversions.ToBoolean(array[2]);
			return new EmissionContainer(double_, bool_, bool_2);
		}

		// Token: 0x040037FD RID: 14333
		public float elapsedTime;

		// Token: 0x040037FE RID: 14334
		public bool bool_0;

		// Token: 0x040037FF RID: 14335
		public bool bool_1;

		// 传感器
		private Sensor sensor;
	}
}
