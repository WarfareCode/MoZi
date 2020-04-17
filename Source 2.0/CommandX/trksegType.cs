using System;
using System.Xml.Serialization;

// Token: 0x02000655 RID: 1621
[XmlType(Namespace = "http://www.topografix.com/GPX/1/1")]
public sealed class trksegType
{
	// Token: 0x040013D6 RID: 5078
	[XmlElement("trkpt")]
	public wptType[] trkpt;
}
