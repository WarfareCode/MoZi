using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns4
{
	// Token: 0x02000BFF RID: 3071
	public sealed class Class270
	{
		// Token: 0x06006622 RID: 26146 RVA: 0x00350A80 File Offset: 0x0034EC80
		public static void smethod_0()
		{
			Class270.dictionary_0 = new Dictionary<int, Dictionary<int, Class270.Class271>>();
			Dictionary<string, List<Class372.Class373>>.ValueCollection.Enumerator enumerator = Terrain.dictionary_0.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Class372.Class373 @class = enumerator.Current[0];
					FileStream fileStream = new FileStream(MyTemplate.GetApp().Info.DirectoryPath + "\\GIS\\Terrain\\SRTM30Plus\\" + @class.string_0 + "_MaxMin", FileMode.Open, FileAccess.Read);
					XmlDocument xmlDocument = new XmlDocument();
					using (fileStream)
					{
						xmlDocument.Load(fileStream);
					}
					XmlNode xmlNode = xmlDocument.ChildNodes[1];
					IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
							IEnumerator enumerator3 = xmlNode2.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator3.MoveNext())
								{
									XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
									string name = xmlNode3.Name;
									if (Operators.CompareString(name, "Lon_Lat", false) != 0)
									{
										if (Operators.CompareString(name, "Max", false) != 0)
										{
											if (Operators.CompareString(name, "Min", false) == 0)
											{
												Class270.Class271 class2 = new Class270.Class271();
												class2.short_1 = Conversions.ToShort(xmlNode3.InnerText);
											}
										}
										else
										{
											Class270.Class271 class2 = new Class270.Class271();
											class2.short_0 = Conversions.ToShort(xmlNode3.InnerText);
										}
									}
									else
									{
										int key = Conversions.ToInteger(xmlNode3.InnerText.Split(new char[]
										{
											'_'
										})[0]);
										int key2 = Conversions.ToInteger(xmlNode3.InnerText.Split(new char[]
										{
											'_'
										})[1]);
										if (!Class270.dictionary_0.ContainsKey(key))
										{
											Class270.dictionary_0.Add(key, new Dictionary<int, Class270.Class271>());
										}
										Dictionary<int, Class270.Class271> dictionary = Class270.dictionary_0[key];
										if (!dictionary.ContainsKey(key2))
										{
											Class270.Class271 class2 = new Class270.Class271();
											dictionary.Add(key2, class2);
										}
										else
										{
											Class270.Class271 class2 = dictionary[key2];
										}
									}
								}
							}
							finally
							{
								if (enumerator3 is IDisposable)
								{
									(enumerator3 as IDisposable).Dispose();
								}
							}
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
			}
			finally
			{
				IDisposable disposable = enumerator;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			Class270.bool_0 = true;
		}

		// Token: 0x06006623 RID: 26147 RVA: 0x00350D64 File Offset: 0x0034EF64
		public static short smethod_1(double double_0, double double_1)
		{
			while (!Class270.bool_0)
			{
				Thread.Sleep(50);
			}
			int key = (int)Math.Round(Math.Floor(double_1));
			int key2 = (int)Math.Round(Math.Floor(double_0));
			return Class270.dictionary_0[key][key2].short_0;
		}

		// Token: 0x04003833 RID: 14387
		private static Dictionary<int, Dictionary<int, Class270.Class271>> dictionary_0;

		// Token: 0x04003834 RID: 14388
		private static bool bool_0 = false;

		// Token: 0x02000C00 RID: 3072
		private sealed class Class271
		{
			// Token: 0x06006626 RID: 26150 RVA: 0x0002C350 File Offset: 0x0002A550
			public Class271()
			{
				this.hashSet_0 = new HashSet<int>();
				this.short_0 = 0;
				this.short_1 = 0;
			}

			// Token: 0x04003835 RID: 14389
			public short short_0;

			// Token: 0x04003836 RID: 14390
			public short short_1;

			// Token: 0x04003837 RID: 14391
			public HashSet<int> hashSet_0;
		}
	}
}
