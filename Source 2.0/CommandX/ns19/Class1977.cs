using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ns19
{
	// Token: 0x02000413 RID: 1043
	public sealed class Class1977 : SettingsBase
	{
		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x0009FC04 File Offset: 0x0009DE04
		// (set) Token: 0x06001A5B RID: 6747 RVA: 0x0009FC1C File Offset: 0x0009DE1C
		[XmlIgnore]
		public TimeSpan CacheCleanupInterval
		{
			get
			{
				return this.timeSpan_0;
			}
			set
			{
				TimeSpan timeSpan = TimeSpan.FromMinutes(1.0);
				if (value < timeSpan)
				{
					value = timeSpan;
				}
				this.timeSpan_0 = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0009FC50 File Offset: 0x0009DE50
		// (set) Token: 0x06001A5D RID: 6749 RVA: 0x00010F5F File Offset: 0x0000F15F
		[XmlElement("CacheCleanupInterval", DataType = "duration")]
		public string CacheCleanupIntervalXml
		{
			get
			{
				string result;
				if (this.timeSpan_0 < TimeSpan.FromSeconds(1.0))
				{
					result = null;
				}
				else
				{
					result = XmlConvert.ToString(this.timeSpan_0);
				}
				return result;
			}
			set
			{
				if (value != null && !(value == string.Empty))
				{
					this.timeSpan_0 = XmlConvert.ToTimeSpan(value);
				}
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x0009FC8C File Offset: 0x0009DE8C
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x00010F80 File Offset: 0x0000F180
		[XmlIgnore]
		public TimeSpan TotalRunTime
		{
			get
			{
				return this.timeSpan_1 + DateTime.Now.Subtract(Class1977.dateTime_0);
			}
			set
			{
				value = this.timeSpan_1;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x0009FCB8 File Offset: 0x0009DEB8
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x00010F8A File Offset: 0x0000F18A
		[XmlElement("TotalRunTime", DataType = "duration")]
		public string TotalRunTimeXml
		{
			get
			{
				string result;
				if (this.TotalRunTime < TimeSpan.FromSeconds(1.0))
				{
					result = null;
				}
				else
				{
					result = XmlConvert.ToString(this.TotalRunTime);
				}
				return result;
			}
			set
			{
				if (value != null && !(value == string.Empty))
				{
					this.timeSpan_1 = XmlConvert.ToTimeSpan(value);
				}
			}
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x0009FCF4 File Offset: 0x0009DEF4
		public override string ToString()
		{
			return "WorldWind";
		}

		// Token: 0x04000B16 RID: 2838
		private bool bool_0 = true;

		// Token: 0x04000B17 RID: 2839
		private string string_2 = "";

		// Token: 0x04000B18 RID: 2840
		private string string_3 = "";

		// Token: 0x04000B19 RID: 2841
		private string string_4 = "";

		// Token: 0x04000B1A RID: 2842
		private string string_5 = "Cache";

		// Token: 0x04000B1B RID: 2843
		private int int_0 = 10000;

		// Token: 0x04000B1C RID: 2844
		private TimeSpan timeSpan_0 = TimeSpan.FromMinutes(60.0);

		// Token: 0x04000B1D RID: 2845
		public static readonly DateTime dateTime_0 = DateTime.Now;

		// Token: 0x04000B1E RID: 2846
		private TimeSpan timeSpan_1 = TimeSpan.Zero;

		// Token: 0x04000B1F RID: 2847
		private ArrayList arrayList_0 = new ArrayList();

		// Token: 0x04000B20 RID: 2848
		private string string_6 = "Earth";

		// Token: 0x04000B21 RID: 2849
		private bool bool_1 = true;

		// Token: 0x04000B22 RID: 2850
		private string string_7 = "Config";

		// Token: 0x04000B23 RID: 2851
		private string string_8 = "Data";

		// Token: 0x04000B24 RID: 2852
		private bool bool_2 = true;

		// Token: 0x04000B25 RID: 2853
		public readonly string string_9 = Path.GetDirectoryName(Application.ExecutablePath);

		// Token: 0x04000B26 RID: 2854
		private static Class1977 class1977_0 = new Class1977();
	}
}
