using System;
using System.IO;
using System.Text;
using ns28;

namespace Nini.Ini
{
	// Token: 0x02000101 RID: 257
	public sealed class IniReader : IDisposable
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0006762C File Offset: 0x0006582C
		public string Value
		{
			get
			{
				return this.value.ToString();
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00067648 File Offset: 0x00065848
		public string method_0()
		{
			return this.stringBuilder_0.ToString();
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00067664 File Offset: 0x00065864
		public Enum171 method_1()
		{
			return this.enum171_0;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0006767C File Offset: 0x0006587C
		public string method_2()
		{
			return this.bool_1 ? this.stringBuilder_1.ToString() : null;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000676A4 File Offset: 0x000658A4
		public int method_3()
		{
			return this.int_0;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000676BC File Offset: 0x000658BC
		public int method_4()
		{
			return this.int_1;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0000700D File Offset: 0x0000520D
		public void method_5(bool bool_7)
		{
			this.bool_0 = bool_7;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00007016 File Offset: 0x00005216
		public void method_6(bool bool_7)
		{
			this.bool_3 = bool_7;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0000701F File Offset: 0x0000521F
		public void method_7(bool bool_7)
		{
			this.bool_4 = bool_7;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00007028 File Offset: 0x00005228
		public void method_8(bool bool_7)
		{
			this.bool_5 = bool_7;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00007031 File Offset: 0x00005231
		public bool method_9()
		{
			return this.bool_6;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00007039 File Offset: 0x00005239
		public void method_10(bool bool_7)
		{
			this.bool_6 = bool_7;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000676D4 File Offset: 0x000658D4
		public IniReader(TextReader textReader_1)
		{
			this.textReader_0 = textReader_1;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0006778C File Offset: 0x0006598C
		public bool method_11()
		{
			bool result = false;
			if (this.enum170_0 != Enum170.const_1 || this.enum170_0 != Enum170.const_0)
			{
				this.enum170_0 = Enum170.const_4;
				result = this.method_16();
			}
			return result;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00007042 File Offset: 0x00005242
		public void method_12()
		{
			this.method_15();
			this.enum170_0 = Enum170.const_0;
			if (this.textReader_0 != null)
			{
				this.textReader_0.Close();
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00007067 File Offset: 0x00005267
		public void Dispose()
		{
			this.vmethod_0(true);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00007070 File Offset: 0x00005270
		public void method_13(char[] char_2)
		{
			if (char_2.Length < 1)
			{
				throw new ArgumentException("Must supply at least one delimiter");
			}
			this.char_0 = char_2;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0000708F File Offset: 0x0000528F
		public void method_14(char[] char_2)
		{
			if (char_2.Length < 1)
			{
				throw new ArgumentException("Must supply at least one delimiter");
			}
			this.char_1 = char_2;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000070AE File Offset: 0x000052AE
		protected  void vmethod_0(bool bool_7)
		{
			if (!this.bool_2)
			{
				this.textReader_0.Close();
				this.bool_2 = true;
				if (bool_7)
				{
					GC.SuppressFinalize(this);
				}
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000677C4 File Offset: 0x000659C4
		~IniReader()
		{
			this.vmethod_0(false);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000677F4 File Offset: 0x000659F4
		private void method_15()
		{
			this.stringBuilder_0.Remove(0, this.stringBuilder_0.Length);
			this.value.Remove(0, this.value.Length);
			this.stringBuilder_1.Remove(0, this.stringBuilder_1.Length);
			this.enum171_0 = Enum171.const_2;
			this.bool_1 = false;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00067858 File Offset: 0x00065A58
		private bool method_16()
		{
			bool flag = true;
			int num = this.method_25();
			this.method_15();
			bool result;
			if (this.method_26(num))
			{
				this.enum171_0 = Enum171.const_2;
				this.method_24();
				this.method_17();
				result = flag;
			}
			else
			{
				int num2 = num;
				if (num2 <= 13)
				{
					if (num2 == -1)
					{
						this.enum170_0 = Enum170.const_1;
						flag = false;
						goto IL_AF;
					}
					switch (num2)
					{
					case 9:
					case 13:
						break;
					case 10:
						this.method_24();
						goto IL_AF;
					case 11:
					case 12:
						goto IL_A9;
					default:
						goto IL_A9;
					}
				}
				else if (num2 != 32)
				{
					if (num2 == 91)
					{
						this.method_21();
						goto IL_AF;
					}
					goto IL_A9;
				}
				this.method_30();
				this.method_16();
				goto IL_AF;
				IL_A9:
				this.method_19();
				IL_AF:
				result = flag;
			}
			return result;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00067918 File Offset: 0x00065B18
		private void method_17()
		{
			this.method_30();
			this.bool_1 = true;
			int num;
			do
			{
				num = this.method_24();
				this.stringBuilder_1.Append((char)num);
			}
			while (!this.method_31(num));
			this.method_18(this.stringBuilder_1);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00067964 File Offset: 0x00065B64
		private void method_18(StringBuilder stringBuilder_2)
		{
			string text = stringBuilder_2.ToString();
			stringBuilder_2.Remove(0, stringBuilder_2.Length);
			stringBuilder_2.Append(text.TrimEnd(null));
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00067994 File Offset: 0x00065B94
		private void method_19()
		{
			this.enum171_0 = Enum171.const_1;
			while (true)
			{
				int int_ = this.method_25();
				if (this.method_27(int_))
				{
					break;
				}
				if (this.method_31(int_))
				{
					goto IL_44;
				}
				this.stringBuilder_0.Append((char)this.method_24());
			}
			this.method_24();
			goto IL_6A;
			IL_44:
			if (!this.bool_5)
			{
				throw new IniException(this, string.Format("Expected assignment operator ({0})", this.char_1[0]));
			}
			IL_6A:
			this.method_20();
			this.method_22();
			this.method_18(this.stringBuilder_0);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00067A24 File Offset: 0x00065C24
		private void method_20()
		{
			bool flag = false;
			int num = 0;
			this.method_30();
			while (true)
			{
				int num2 = this.method_25();
				if (!this.method_29(num2))
				{
					num++;
				}
				if (!this.method_9() && num2 == 34)
				{
					this.method_24();
					if (flag || num != 1)
					{
						goto IL_15A;
					}
					flag = true;
				}
				else
				{
					if (flag && this.method_31(num2))
					{
						break;
					}
					if (this.bool_3 && num2 == 92)
					{
						StringBuilder stringBuilder = new StringBuilder();
						stringBuilder.Append((char)this.method_24());
						while (this.method_25() != 10 && this.method_29(this.method_25()))
						{
							if (this.method_25() != 13)
							{
								stringBuilder.Append((char)this.method_24());
							}
							else
							{
								this.method_24();
							}
						}
						if (this.method_25() == 10)
						{
							this.method_24();
							continue;
						}
						this.value.Append(stringBuilder.ToString());
					}
					if ((!this.method_9() && this.bool_4 && this.method_26(num2) && !flag) || this.method_31(num2))
					{
						goto IL_15A;
					}
					this.value.Append((char)this.method_24());
				}
			}
			throw new IniException(this, "Expected closing quote (\")");
			IL_15A:
			if (!flag)
			{
				this.method_18(this.value);
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00067B9C File Offset: 0x00065D9C
		private void method_21()
		{
			this.enum171_0 = Enum171.const_0;
			int num = this.method_24();
			while (true)
			{
				num = this.method_25();
				if (num == 93)
				{
					break;
				}
				if (this.method_31(num))
				{
					goto IL_42;
				}
				this.stringBuilder_0.Append((char)this.method_24());
			}
			this.method_23();
			this.method_18(this.stringBuilder_0);
			return;
			IL_42:
			throw new IniException(this, "Expected section end (])");
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00067C0C File Offset: 0x00065E0C
		private void method_22()
		{
			int int_ = this.method_24();
			while (!this.method_31(int_))
			{
				if (this.method_26(int_))
				{
					if (this.bool_0)
					{
						this.method_23();
					}
					else
					{
						this.method_17();
					}
					return;
				}
				int_ = this.method_24();
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00067C5C File Offset: 0x00065E5C
		private void method_23()
		{
			int int_;
			do
			{
				int_ = this.method_24();
			}
			while (!this.method_31(int_));
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00067C80 File Offset: 0x00065E80
		private int method_24()
		{
			int num = this.textReader_0.Read();
			if (num == 10)
			{
				this.int_0++;
				this.int_1 = 1;
			}
			else
			{
				this.int_1++;
			}
			return num;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00067CCC File Offset: 0x00065ECC
		private int method_25()
		{
			return this.textReader_0.Peek();
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000070D6 File Offset: 0x000052D6
		private bool method_26(int int_2)
		{
			return this.method_28(this.char_0, int_2);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x000070E5 File Offset: 0x000052E5
		private bool method_27(int int_2)
		{
			return this.method_28(this.char_1, int_2);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00067CE8 File Offset: 0x00065EE8
		private bool method_28(char[] char_2, int int_2)
		{
			bool flag = false;
			bool result;
			for (int i = 0; i < char_2.Length; i++)
			{
				if (int_2 == (int)char_2[i])
				{
					result = true;
					return result;
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000070F4 File Offset: 0x000052F4
		private bool method_29(int int_2)
		{
			return int_2 == 32 || int_2 == 9 || int_2 == 13 || int_2 == 10;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000710D File Offset: 0x0000530D
		private void method_30()
		{
			while (this.method_29(this.method_25()) && !this.method_31(this.method_25()))
			{
				this.method_24();
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0000713F File Offset: 0x0000533F
		private bool method_31(int int_2)
		{
			return int_2 == 10 || int_2 == -1;
		}

		// Token: 0x04000295 RID: 661
		private int int_0 = 1;

		// Token: 0x04000296 RID: 662
		private int int_1 = 1;

		// Token: 0x04000297 RID: 663
		private Enum171 enum171_0 = Enum171.const_2;

		// Token: 0x04000298 RID: 664
		private TextReader textReader_0 = null;

		// Token: 0x04000299 RID: 665
		private bool bool_0 = false;

		// Token: 0x0400029A RID: 666
		private StringBuilder stringBuilder_0 = new StringBuilder();

		// Token: 0x0400029B RID: 667
		private StringBuilder value = new StringBuilder();

		// Token: 0x0400029C RID: 668
		private StringBuilder stringBuilder_1 = new StringBuilder();

		// Token: 0x0400029D RID: 669
		private Enum170 enum170_0 = Enum170.const_3;

		// Token: 0x0400029E RID: 670
		private bool bool_1 = false;

		// Token: 0x0400029F RID: 671
		private bool bool_2 = false;

		// Token: 0x040002A0 RID: 672
		private bool bool_3 = false;

		// Token: 0x040002A1 RID: 673
		private bool bool_4 = true;

		// Token: 0x040002A2 RID: 674
		private bool bool_5 = false;

		// Token: 0x040002A3 RID: 675
		private bool bool_6 = false;

		// Token: 0x040002A4 RID: 676
		private char[] char_0 = new char[]
		{
			';'
		};

		// Token: 0x040002A5 RID: 677
		private char[] char_1 = new char[]
		{
			'='
		};
	}
}
