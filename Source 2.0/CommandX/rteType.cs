using System;
using System.Xml.Serialization;

// Token: 0x02000659 RID: 1625
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class rteType
{
	// Token: 0x040013E9 RID: 5097
	[XmlElement("link")]
	public linkType[] link;

	// Token: 0x040013EA RID: 5098
	[XmlElement(DataType = "nonNegativeInteger")]
	public string number;

	// Token: 0x040013EB RID: 5099
	[XmlElement("rtept")]
	public wptType[] rtept;
}
