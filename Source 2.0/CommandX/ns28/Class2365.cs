using System;
using System.Collections;
using System.IO;
using Nini.Ini;
using ns29;

namespace ns28
{
	// Token: 0x020000FC RID: 252
	public sealed class Class2365
	{
		// Token: 0x0600054F RID: 1359 RVA: 0x00006F0B File Offset: 0x0000510B
		public Class2365(TextReader textReader_0)
		{
			this.enum169_0 = Enum169.const_0;
			this.method_0(textReader_0);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00006F3E File Offset: 0x0000513E
		public Class2365()
		{
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00006F63 File Offset: 0x00005163
		public void method_0(TextReader textReader_0)
		{
			this.method_1(this.method_6(textReader_0, this.enum169_0));
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00006F78 File Offset: 0x00005178
		public void method_1(IniReader iniReader_0)
		{
			this.method_5(iniReader_0);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x000670E0 File Offset: 0x000652E0
		public Class2368 method_2()
		{
			return this.class2368_0;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x000670F8 File Offset: 0x000652F8
		public void method_3(TextWriter textWriter_0)
		{
			Class2369 @class = this.method_7(textWriter_0, this.enum169_0);
			foreach (string string_ in this.arrayList_0)
			{
				@class.method_5(string_);
			}
			for (int i = 0; i < this.class2368_0.Count; i++)
			{
				Class2367 class2 = this.class2368_0[i];
				@class.method_3(class2.method_0(), class2.method_1());
				for (int j = 0; j < class2.method_2(); j++)
				{
					Class2366 class3 = class2.method_4(j);
					switch (class3.method_0())
					{
					case Enum171.const_1:
						@class.method_4(class3.method_1(), class3.Value, class3.method_2());
						break;
					case Enum171.const_2:
						@class.method_5(class3.method_2());
						break;
					}
				}
			}
			@class.method_2();
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00067218 File Offset: 0x00065418
		public void method_4(string string_0)
		{
			StreamWriter streamWriter = new StreamWriter(string_0);
			this.method_3(streamWriter);
			streamWriter.Close();
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0006723C File Offset: 0x0006543C
		private void method_5(IniReader iniReader_0)
		{
			iniReader_0.method_5(false);
			bool flag = false;
			Class2367 @class = null;
			try
			{
				while (iniReader_0.method_11())
				{
					switch (iniReader_0.method_1())
					{
					case Enum171.const_0:
						flag = true;
						if (this.class2368_0[iniReader_0.method_0()] != null)
						{
							this.class2368_0.method_1(iniReader_0.method_0());
						}
						@class = new Class2367(iniReader_0.method_0(), iniReader_0.method_2());
						this.class2368_0.method_0(@class);
						break;
					case Enum171.const_1:
						if (@class.method_3(iniReader_0.method_0()) == null)
						{
							@class.method_7(iniReader_0.method_0(), iniReader_0.Value, iniReader_0.method_2());
						}
						break;
					case Enum171.const_2:
						if (!flag)
						{
							this.arrayList_0.Add(iniReader_0.method_2());
						}
						else
						{
							@class.method_9(iniReader_0.method_2());
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				iniReader_0.method_12();
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00067348 File Offset: 0x00065548
		private IniReader method_6(TextReader textReader_0, Enum169 enum169_1)
		{
			IniReader iniReader = new IniReader(textReader_0);
			switch (enum169_1)
			{
			case Enum169.const_1:
				iniReader.method_7(false);
				iniReader.method_13(new char[]
				{
					';',
					'#'
				});
				iniReader.method_14(new char[]
				{
					':'
				});
				break;
			case Enum169.const_2:
				iniReader.method_7(false);
				iniReader.method_13(new char[]
				{
					';',
					'#'
				});
				iniReader.method_6(true);
				break;
			case Enum169.const_3:
				iniReader.method_7(false);
				iniReader.method_8(true);
				iniReader.method_13(new char[]
				{
					'#'
				});
				iniReader.method_14(new char[]
				{
					':',
					'='
				});
				break;
			case Enum169.const_4:
				iniReader.method_10(true);
				break;
			}
			return iniReader;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0006741C File Offset: 0x0006561C
		private Class2369 method_7(TextWriter textWriter_0, Enum169 enum169_1)
		{
			Class2369 @class = new Class2369(textWriter_0);
			switch (enum169_1)
			{
			case Enum169.const_1:
				@class.method_1(':');
				@class.method_0('#');
				break;
			case Enum169.const_2:
			case Enum169.const_3:
				@class.method_1('=');
				@class.method_0('#');
				break;
			}
			return @class;
		}

		// Token: 0x04000282 RID: 642
		private Class2368 class2368_0 = new Class2368();

		// Token: 0x04000283 RID: 643
		private ArrayList arrayList_0 = new ArrayList();

		// Token: 0x04000284 RID: 644
		private Enum169 enum169_0 = Enum169.const_0;
	}
}
