using System;
using System.Text;
using System.Xml;

namespace ns16
{
	// Token: 0x020004D4 RID: 1236
	public abstract class Class2058
	{
		// Token: 0x06002038 RID: 8248 RVA: 0x000D3010 File Offset: 0x000D1210
		protected static XmlDocument smethod_0()
		{
			if (Class2058.xmlDocument_0 == null)
			{
				Class2058.xmlDocument_0 = new XmlDocument();
			}
			return Class2058.xmlDocument_0;
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x000D303C File Offset: 0x000D123C
		public static XmlNode smethod_1()
		{
			string name = "tmp";
			if (Class2058.xmlDocumentFragment_0 == null)
			{
				Class2058.xmlDocumentFragment_0 = Class2058.smethod_0().CreateDocumentFragment();
				Class2058.xmlDocument_0.AppendChild(Class2058.xmlDocumentFragment_0);
			}
			XmlNode xmlNode = Class2058.smethod_0().CreateElement(name);
			Class2058.xmlDocumentFragment_0.AppendChild(xmlNode);
			return xmlNode;
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00013694 File Offset: 0x00011894
		public Class2058()
		{
		}

		// Token: 0x04000F77 RID: 3959
		protected static XmlDocument xmlDocument_0;

		// Token: 0x04000F78 RID: 3960
		protected static XmlDocumentFragment xmlDocumentFragment_0;

		// Token: 0x04000F79 RID: 3961
		protected Encoding encoding_0 = Encoding.UTF8;
	}
}
