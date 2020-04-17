using System;
using System.Xml.Serialization;

// Token: 0x02000656 RID: 1622
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class wptType
{
	// Token: 0x040013D7 RID: 5079
	[XmlIgnore]
	public bool eleSpecified;

	// Token: 0x040013D8 RID: 5080
	[XmlIgnore]
	public bool timeSpecified;

	// Token: 0x040013D9 RID: 5081
	[XmlIgnore]
	public bool magvarSpecified;

	// Token: 0x040013DA RID: 5082
	[XmlIgnore]
	public bool geoidheightSpecified;

	// Token: 0x040013DB RID: 5083
	[XmlElement("link")]
	public linkType[] link;

	// Token: 0x040013DC RID: 5084
	[XmlIgnore]
	public bool fixSpecified;

	// Token: 0x040013DD RID: 5085
	[XmlElement(DataType = "nonNegativeInteger")]
	public string sat;

	// Token: 0x040013DE RID: 5086
	[XmlIgnore]
	public bool hdopSpecified;

	// Token: 0x040013DF RID: 5087
	[XmlIgnore]
	public bool vdopSpecified;

	// Token: 0x040013E0 RID: 5088
	[XmlIgnore]
	public bool pdopSpecified;

	// Token: 0x040013E1 RID: 5089
	[XmlIgnore]
	public bool ageofdgpsdataSpecified;

	// Token: 0x040013E2 RID: 5090
	[XmlElement(DataType = "integer")]
	public string dgpsid;

	// Token: 0x040013E3 RID: 5091
	[XmlAttribute]
	public decimal lat;

	// Token: 0x040013E4 RID: 5092
	[XmlAttribute]
	public decimal lon;
}
