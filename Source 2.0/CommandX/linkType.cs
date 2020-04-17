using System;
using System.Xml.Serialization;

// Token: 0x0200001B RID: 27
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class linkType
{
	// Token: 0x0400008D RID: 141
	[XmlAttribute(DataType = "anyURI")]
	public string href;
}
