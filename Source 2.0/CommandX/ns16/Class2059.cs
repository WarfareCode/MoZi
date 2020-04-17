using System;
using System.Xml;

namespace ns16
{
	// Token: 0x02000029 RID: 41
	public abstract class Class2059 : IDisposable
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00004E3D File Offset: 0x0000303D
		public Class2059()
		{
			this.xmlNode_0 = Class2058.smethod_1();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004E50 File Offset: 0x00003050
		public Class2059(XmlNode xmlNode_1)
		{
			this.xmlNode_0 = xmlNode_1;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00058B38 File Offset: 0x00056D38
		protected static string smethod_0(XmlNode xmlNode_1)
		{
			return xmlNode_1.InnerText;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004E5F File Offset: 0x0000305F
		protected static void smethod_1(XmlNode xmlNode_1, string string_0)
		{
			xmlNode_1.InnerText = string_0;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00058B50 File Offset: 0x00056D50
		protected int method_0(Class2059.Enum155 enum155_0, string string_0, string string_1)
		{
			int result;
			if (enum155_0 == Class2059.Enum155.const_0)
			{
				foreach (XmlAttribute xmlAttribute in this.xmlNode_0.Attributes)
				{
					if (xmlAttribute.NamespaceURI == string_0 && xmlAttribute.LocalName == string_1)
					{
						result = 1;
						return result;
					}
				}
				result = 0;
			}
			else
			{
				int num = 0;
				foreach (XmlNode xmlNode in this.xmlNode_0.ChildNodes)
				{
					if (xmlNode.NamespaceURI == string_0 && xmlNode.LocalName == string_1)
					{
						num++;
					}
				}
				result = num;
			}
			return result;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00058C64 File Offset: 0x00056E64
		protected XmlNode method_1(Class2059.Enum155 enum155_0, string string_0, string string_1, int int_0)
		{
			XmlNode result;
			if (enum155_0 == Class2059.Enum155.const_0)
			{
				if (int_0 > 0)
				{
					throw new Exception("Index out of range");
				}
				foreach (XmlAttribute xmlAttribute in this.xmlNode_0.Attributes)
				{
					if (xmlAttribute.NamespaceURI == string_0 && xmlAttribute.LocalName == string_1)
					{
						XmlNode xmlNode = xmlAttribute;
						result = xmlNode;
						return result;
					}
				}
				throw new Exception("Not found");
			}
			else
			{
				int num = 0;
				foreach (XmlNode xmlNode2 in this.xmlNode_0.ChildNodes)
				{
					if (xmlNode2.NamespaceURI == string_0 && xmlNode2.LocalName == string_1 && num++ == int_0)
					{
						XmlNode xmlNode = xmlNode2;
						result = xmlNode;
						return result;
					}
				}
				if (num > 0)
				{
					throw new Exception("Index out of range");
				}
				throw new Exception("Not found");
			}
			return result;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00004E68 File Offset: 0x00003068
		public void Dispose()
		{
			if (this.xmlNode_0.ParentNode.NodeType == XmlNodeType.DocumentFragment)
			{
				this.xmlNode_0.ParentNode.RemoveChild(this.xmlNode_0);
			}
		}

		// Token: 0x040000A3 RID: 163
		protected internal XmlNode xmlNode_0;

		// Token: 0x0200002A RID: 42
		public enum Enum155
		{
			// Token: 0x040000A5 RID: 165
			const_0,
			// Token: 0x040000A6 RID: 166
			const_1,
			// Token: 0x040000A7 RID: 167
			const_2,
			// Token: 0x040000A8 RID: 168
			const_3,
			// Token: 0x040000A9 RID: 169
			const_4,
			// Token: 0x040000AA RID: 170
			const_5
		}
	}
}
