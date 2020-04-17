using System;
using System.Xml.Serialization;

// Token: 0x02000658 RID: 1624
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class trkType
{
	// Token: 0x040013E6 RID: 5094
	[XmlElement("link")]
	public linkType[] link;

	// Token: 0x040013E7 RID: 5095
	[XmlElement(DataType = "nonNegativeInteger")]
	public string number;

	// Token: 0x040013E8 RID: 5096
	[XmlElement("trkseg")]
	public trksegType[] trkseg;
}
