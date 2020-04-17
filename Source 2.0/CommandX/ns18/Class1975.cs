using System;
using System.Xml.Serialization;
using ns19;

namespace ns18
{
	// Token: 0x0200034B RID: 843
	public sealed class Class1975 : SettingsBase
	{
		// Token: 0x0200034C RID: 844
		public sealed class Class1939
		{
			// Token: 0x04000827 RID: 2087
			[XmlAttribute]
			public string name;

			// Token: 0x04000828 RID: 2088
			[XmlAttribute]
			public string value;
		}

		// Token: 0x0200034D RID: 845
		public sealed class Class1940
		{
			// Token: 0x04000829 RID: 2089
			[XmlAttribute]
			public string Name;

			// Token: 0x0400082A RID: 2090
			[XmlAttribute]
			public float Lat;

			// Token: 0x0400082B RID: 2091
			[XmlAttribute]
			public float Lon;
		}
	}
}
