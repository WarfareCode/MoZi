using System;
using System.IO;
using System.Text;

namespace ns29
{
	// Token: 0x0200013F RID: 319
	public sealed class Class2369 : IDisposable
	{
		// Token: 0x060006DE RID: 1758 RVA: 0x00007B12 File Offset: 0x00005D12
		public void method_0(char char_2)
		{
			this.char_0 = char_2;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00007B1B File Offset: 0x00005D1B
		public void method_1(char char_2)
		{
			this.char_1 = char_2;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000695A0 File Offset: 0x000677A0
		public Class2369(TextWriter textWriter_1)
		{
			this.textWriter_0 = textWriter_1;
			StreamWriter streamWriter = textWriter_1 as StreamWriter;
			if (streamWriter != null)
			{
				this.stream_0 = streamWriter.BaseStream;
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00007B24 File Offset: 0x00005D24
		public void method_2()
		{
			this.textWriter_0.Close();
			this.enum172_0 = Enum172.const_3;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00069624 File Offset: 0x00067824
		public override string ToString()
		{
			return this.textWriter_0.ToString();
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00007B38 File Offset: 0x00005D38
		public void method_3(string string_1, string string_2)
		{
			this.method_8();
			this.enum172_0 = Enum172.const_2;
			this.method_11("[" + string_1 + "]" + this.method_9(string_2));
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00069640 File Offset: 0x00067840
		public void method_4(string string_1, string string_2, string string_3)
		{
			this.method_7();
			this.method_11(string.Concat(new object[]
			{
				string_1,
				" ",
				this.char_1,
				" ",
				this.method_6(string_2),
				this.method_9(string_3)
			}));
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0006969C File Offset: 0x0006789C
		public void method_5(string string_1)
		{
			this.method_8();
			if (this.enum172_0 == Enum172.const_0)
			{
				this.enum172_0 = Enum172.const_1;
			}
			if (string_1 == null)
			{
				this.method_11("");
			}
			else
			{
				this.method_11(this.char_0 + " " + string_1);
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00007B64 File Offset: 0x00005D64
		public void Dispose()
		{
			this.vmethod_0(true);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00007B6D File Offset: 0x00005D6D
		protected  void vmethod_0(bool bool_2)
		{
			if (!this.bool_1)
			{
				this.textWriter_0.Close();
				this.stream_0.Close();
				this.bool_1 = true;
				if (bool_2)
				{
					GC.SuppressFinalize(this);
				}
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000696F8 File Offset: 0x000678F8
		~Class2369()
		{
			this.vmethod_0(false);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00069728 File Offset: 0x00067928
		private string method_6(string string_1)
		{
			string result;
			if (this.bool_0)
			{
				result = this.method_12('"' + string_1 + '"');
			}
			else
			{
				result = this.method_12(string_1);
			}
			return result;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00069770 File Offset: 0x00067970
		private void method_7()
		{
			this.method_8();
			switch (this.enum172_0)
			{
			case Enum172.const_0:
			case Enum172.const_1:
				throw new InvalidOperationException("The WriteState is not Section");
			case Enum172.const_3:
				throw new InvalidOperationException("The writer is closed");
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00007BA0 File Offset: 0x00005DA0
		private void method_8()
		{
			if (this.enum172_0 == Enum172.const_3)
			{
				throw new InvalidOperationException("The writer is closed");
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000697B8 File Offset: 0x000679B8
		private string method_9(string string_1)
		{
			return (string_1 == null) ? "" : string.Concat(new object[]
			{
				" ",
				this.char_0,
				" ",
				string_1
			});
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00007BBB File Offset: 0x00005DBB
		private void method_10(string string_1)
		{
			this.textWriter_0.Write(this.stringBuilder_0.ToString() + string_1);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00007BD9 File Offset: 0x00005DD9
		private void method_11(string string_1)
		{
			this.method_10(string_1 + this.string_0);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00069800 File Offset: 0x00067A00
		private string method_12(string string_1)
		{
			return string_1.Replace("\n", "");
		}

		// Token: 0x04000320 RID: 800
		private int int_0 = 0;

		// Token: 0x04000321 RID: 801
		private bool bool_0 = false;

		// Token: 0x04000322 RID: 802
		private Enum172 enum172_0 = Enum172.const_0;

		// Token: 0x04000323 RID: 803
		private char char_0 = ';';

		// Token: 0x04000324 RID: 804
		private char char_1 = '=';

		// Token: 0x04000325 RID: 805
		private TextWriter textWriter_0 = null;

		// Token: 0x04000326 RID: 806
		private string string_0 = "\r\n";

		// Token: 0x04000327 RID: 807
		private StringBuilder stringBuilder_0 = new StringBuilder();

		// Token: 0x04000328 RID: 808
		private Stream stream_0 = null;

		// Token: 0x04000329 RID: 809
		private bool bool_1 = false;
	}
}
