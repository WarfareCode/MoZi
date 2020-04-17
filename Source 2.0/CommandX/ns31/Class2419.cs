using System;
using System.Collections.Generic;
using System.Globalization;

namespace ns31
{
	// Token: 0x02000477 RID: 1143
	public sealed class Class2419
	{
		// Token: 0x06001DA2 RID: 7586 RVA: 0x000BF8E4 File Offset: 0x000BDAE4
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x000BF8FC File Offset: 0x000BDAFC
		public string method_1()
		{
			return this.method_6(Class2419.Enum174.const_0, false);
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x000BF914 File Offset: 0x000BDB14
		public Class2413 method_2()
		{
			int num = (int)this.method_4(Class2419.Enum174.const_3);
			double double_ = this.method_4(Class2419.Enum174.const_4);
			if (num < 57)
			{
				num += 2000;
			}
			else
			{
				num += 1900;
			}
			return new Class2413(num, double_);
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x0001224D File Offset: 0x0001044D
		public Class2419(string string_3, string string_4, string string_5)
		{
			this.string_0 = string_3;
			this.string_1 = string_4;
			this.string_2 = string_5;
			this.method_3();
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x000BF958 File Offset: 0x000BDB58
		private void method_3()
		{
			this.dictionary_0 = new Dictionary<Class2419.Enum174, string>();
			this.dictionary_1 = new Dictionary<int, double>();
			this.dictionary_0[Class2419.Enum174.const_0] = this.string_1.Substring(2, 5);
			this.dictionary_0[Class2419.Enum174.const_1] = this.string_1.Substring(9, 8);
			this.dictionary_0[Class2419.Enum174.const_3] = this.string_1.Substring(18, 2);
			this.dictionary_0[Class2419.Enum174.const_4] = this.string_1.Substring(20, 12);
			if (this.string_1[33] == '-')
			{
				this.dictionary_0[Class2419.Enum174.const_12] = "-0";
			}
			else
			{
				this.dictionary_0[Class2419.Enum174.const_12] = "0";
			}
			Dictionary<Class2419.Enum174, string> dictionary = this.dictionary_0;
			dictionary[Class2419.Enum174.const_12] = dictionary[Class2419.Enum174.const_12] + this.string_1.Substring(34, 10);
			this.dictionary_0[Class2419.Enum174.const_13] = Class2419.smethod_3(this.string_1.Substring(44, 8));
			this.dictionary_0[Class2419.Enum174.const_14] = Class2419.smethod_3(this.string_1.Substring(53, 8));
			this.dictionary_0[Class2419.Enum174.const_2] = this.string_1.Substring(64, 4).TrimStart(new char[0]);
			this.dictionary_0[Class2419.Enum174.const_6] = this.string_2.Substring(8, 8).TrimStart(new char[0]);
			this.dictionary_0[Class2419.Enum174.const_7] = this.string_2.Substring(17, 8).TrimStart(new char[0]);
			this.dictionary_0[Class2419.Enum174.const_8] = "0." + this.string_2.Substring(26, 7);
			this.dictionary_0[Class2419.Enum174.const_9] = this.string_2.Substring(34, 8).TrimStart(new char[0]);
			this.dictionary_0[Class2419.Enum174.const_10] = this.string_2.Substring(43, 8).TrimStart(new char[0]);
			this.dictionary_0[Class2419.Enum174.const_11] = this.string_2.Substring(52, 11).TrimStart(new char[0]);
			this.dictionary_0[Class2419.Enum174.const_5] = this.string_2.Substring(63, 5).TrimStart(new char[0]);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x000BFBB4 File Offset: 0x000BDDB4
		public double method_4(Class2419.Enum174 enum174_0)
		{
			return this.method_5(enum174_0, Class2419.Enum175.const_2);
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x000BFBCC File Offset: 0x000BDDCC
		public double method_5(Class2419.Enum174 enum174_0, Class2419.Enum175 enum175_0)
		{
			int key = Class2419.smethod_0(enum175_0, enum174_0);
			double result;
			if (this.dictionary_1.ContainsKey(key))
			{
				result = this.dictionary_1[key];
			}
			else
			{
				double num = Class2419.smethod_1(double.Parse(this.dictionary_0[enum174_0].ToString(), CultureInfo.InvariantCulture), enum174_0, enum175_0);
				this.dictionary_1[key] = num;
				result = num;
			}
			return result;
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x000BFC34 File Offset: 0x000BDE34
		public string method_6(Class2419.Enum174 enum174_0, bool bool_0)
		{
			string text = this.dictionary_0[enum174_0].ToString();
			if (bool_0)
			{
				text += Class2419.smethod_2(enum174_0);
			}
			return text.Trim();
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x000BFC70 File Offset: 0x000BDE70
		private static int smethod_0(Class2419.Enum175 enum175_0, Class2419.Enum174 enum174_0)
		{
            //ZSP ERR return (int)(enum175_0 * (Class2419.Enum175)100 + (int)enum174_0);
            return (int)((int)enum175_0 * 100 + (int)enum174_0);
        }

        // Token: 0x06001DAB RID: 7595 RVA: 0x000BFC88 File Offset: 0x000BDE88
        protected static double smethod_1(double double_0, Class2419.Enum174 enum174_0, Class2419.Enum175 enum175_0)
		{
			bool arg_1E_0;
			if (enum174_0 != Class2419.Enum174.const_6 && enum174_0 != Class2419.Enum174.const_7 && enum174_0 != Class2419.Enum174.const_9)
			{
				if (enum174_0 != Class2419.Enum174.const_10)
				{
					arg_1E_0 = true;
					goto IL_1E;
				}
			}
			arg_1E_0 = (enum175_0 != Class2419.Enum175.const_0);
			IL_1E:
			double result;
			if (!arg_1E_0)
			{
				result = Class2412.smethod_4(double_0);
			}
			else
			{
				result = double_0;
			}
			return result;
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x000BFCC4 File Offset: 0x000BDEC4
		protected static string smethod_2(Class2419.Enum174 enum174_0)
		{
			string result;
			switch (enum174_0)
			{
			case Class2419.Enum174.const_6:
			case Class2419.Enum174.const_7:
			case Class2419.Enum174.const_9:
			case Class2419.Enum174.const_10:
				result = " degrees";
				break;
			case Class2419.Enum174.const_8:
				result = string.Empty;
				break;
			case Class2419.Enum174.const_11:
				result = " revs / day";
				break;
			default:
				result = string.Empty;
				break;
			}
			return result;
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x000BFD14 File Offset: 0x000BDF14
		protected static string smethod_3(string string_3)
		{
			string text = string_3.Substring(0, 1);
			string text2 = string_3.Substring(1, 5);
			string text3 = string_3.Substring(6, 2).TrimStart(new char[0]);
			double num = double.Parse(string.Concat(new string[]
			{
				text,
				"0.",
				text2,
				"e",
				text3
			}), CultureInfo.InvariantCulture);
			int num2 = text2.Length + Math.Abs(int.Parse(text3, CultureInfo.InvariantCulture));
			return num.ToString("F" + num2, CultureInfo.InvariantCulture);
		}

		// Token: 0x04000D2F RID: 3375
		private string string_0;

		// Token: 0x04000D30 RID: 3376
		private string string_1;

		// Token: 0x04000D31 RID: 3377
		private string string_2 = "";

		// Token: 0x04000D32 RID: 3378
		private Dictionary<Class2419.Enum174, string> dictionary_0;

		// Token: 0x04000D33 RID: 3379
		private Dictionary<int, double> dictionary_1;

		// Token: 0x02000478 RID: 1144
		public enum Enum174
		{
			// Token: 0x04000D35 RID: 3381
			const_0,
			// Token: 0x04000D36 RID: 3382
			const_1,
			// Token: 0x04000D37 RID: 3383
			const_2,
			// Token: 0x04000D38 RID: 3384
			const_3,
			// Token: 0x04000D39 RID: 3385
			const_4,
			// Token: 0x04000D3A RID: 3386
			const_5,
			// Token: 0x04000D3B RID: 3387
			const_6,
			// Token: 0x04000D3C RID: 3388
			const_7,
			// Token: 0x04000D3D RID: 3389
			const_8,
			// Token: 0x04000D3E RID: 3390
			const_9,
			// Token: 0x04000D3F RID: 3391
			const_10,
			// Token: 0x04000D40 RID: 3392
			const_11,
			// Token: 0x04000D41 RID: 3393
			const_12,
			// Token: 0x04000D42 RID: 3394
			const_13,
			// Token: 0x04000D43 RID: 3395
			const_14
		}

		// Token: 0x02000479 RID: 1145
		public enum Enum175
		{
			// Token: 0x04000D45 RID: 3397
			const_0,
			// Token: 0x04000D46 RID: 3398
			const_1,
			// Token: 0x04000D47 RID: 3399
			const_2
		}
	}
}
