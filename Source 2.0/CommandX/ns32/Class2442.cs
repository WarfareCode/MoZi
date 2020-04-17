using System;

namespace ns32
{
	// Token: 0x020004AF RID: 1199
	public sealed class Class2442 : ICloneable
	{
		// Token: 0x06001F43 RID: 8003 RVA: 0x000CE3A0 File Offset: 0x000CC5A0
		public string method_0()
		{
			return this.string_2;
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x00012D2D File Offset: 0x00010F2D
		public void method_1(string string_12)
		{
			if (string_12 == null)
			{
				throw new ArgumentNullException();
			}
			this.string_2 = string_12;
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x000CE3B8 File Offset: 0x000CC5B8
		public int method_2()
		{
			return this.int_12;
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x00012D45 File Offset: 0x00010F45
		public void method_3(int int_22)
		{
			this.int_12 = int_22;
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x000CE3D0 File Offset: 0x000CC5D0
		public int method_4()
		{
			return this.int_13;
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00012D4E File Offset: 0x00010F4E
		public void method_5(int int_22)
		{
			this.int_13 = int_22;
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x000CE3E8 File Offset: 0x000CC5E8
		public int method_6()
		{
			return this.int_14;
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x00012D57 File Offset: 0x00010F57
		public void method_7(int int_22)
		{
			this.int_14 = int_22;
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x000CE400 File Offset: 0x000CC600
		public long method_8()
		{
			return this.long_0;
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x00012D60 File Offset: 0x00010F60
		public void method_9(long long_2)
		{
			if (long_2 < 0L)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.long_0 = long_2;
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x000CE418 File Offset: 0x000CC618
		public DateTime method_10()
		{
			return this.dateTime_0;
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x000CE430 File Offset: 0x000CC630
		public void method_11(DateTime dateTime_2)
		{
			if (dateTime_2 < Class2442.dateTime_1)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.dateTime_0 = new DateTime(dateTime_2.Year, dateTime_2.Month, dateTime_2.Day, dateTime_2.Hour, dateTime_2.Minute, dateTime_2.Second);
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x000CE488 File Offset: 0x000CC688
		public int method_12()
		{
			return this.int_15;
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x000CE4A0 File Offset: 0x000CC6A0
		public byte method_13()
		{
			return this.byte_1;
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x00012D80 File Offset: 0x00010F80
		public void method_14(byte byte_2)
		{
			this.byte_1 = byte_2;
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x000CE4B8 File Offset: 0x000CC6B8
		public string method_15()
		{
			return this.string_3;
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x00012D89 File Offset: 0x00010F89
		public void method_16(string string_12)
		{
			if (string_12 == null)
			{
				throw new ArgumentNullException();
			}
			this.string_3 = string_12;
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x000CE4D0 File Offset: 0x000CC6D0
		public string method_17()
		{
			return this.string_4;
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00012DA1 File Offset: 0x00010FA1
		public void method_18(string string_12)
		{
			if (string_12 == null)
			{
				throw new ArgumentNullException();
			}
			this.string_4 = string_12;
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x000CE4E8 File Offset: 0x000CC6E8
		public string method_19()
		{
			return this.string_5;
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x00012DB9 File Offset: 0x00010FB9
		public void method_20(string string_12)
		{
			if (string_12 == null)
			{
				throw new ArgumentNullException();
			}
			this.string_5 = string_12;
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x000CE500 File Offset: 0x000CC700
		public string method_21()
		{
			return this.string_6;
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x000CE518 File Offset: 0x000CC718
		public void method_22(string string_12)
		{
			if (string_12 != null)
			{
				this.string_6 = string_12.Substring(0, Math.Min(Class2442.int_9, string_12.Length));
			}
			else
			{
				string text = Environment.UserName;
				if (text.Length > Class2442.int_9)
				{
					text = text.Substring(0, Class2442.int_9);
				}
				this.string_6 = text;
			}
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x000CE578 File Offset: 0x000CC778
		public string method_23()
		{
			return this.string_7;
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00012DD1 File Offset: 0x00010FD1
		public void method_24(string string_12)
		{
			if (string_12 == null)
			{
				this.string_7 = "None";
			}
			else
			{
				this.string_7 = string_12;
			}
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x000CE590 File Offset: 0x000CC790
		public int method_25()
		{
			return this.int_16;
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00012DF0 File Offset: 0x00010FF0
		public void method_26(int int_22)
		{
			this.int_16 = int_22;
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x000CE5A8 File Offset: 0x000CC7A8
		public int method_27()
		{
			return this.int_17;
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x00012DF9 File Offset: 0x00010FF9
		public void method_28(int int_22)
		{
			this.int_17 = int_22;
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x000CE5C0 File Offset: 0x000CC7C0
		public Class2442()
		{
			this.method_18(Class2442.string_0);
			this.method_20(" ");
			this.method_1("");
			this.method_16("");
			this.method_5(Class2442.int_20);
			this.method_7(Class2442.int_21);
			this.method_22(Class2442.string_11);
			this.method_24(Class2442.string_10);
			this.method_9(0L);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x000CE65C File Offset: 0x000CC85C
		public object Clone()
		{
			Class2442 @class = new Class2442();
			@class.method_1(this.method_0());
			@class.method_3(this.method_2());
			@class.method_5(this.method_4());
			@class.method_7(this.method_6());
			@class.method_9(this.method_8());
			@class.method_11(this.method_10());
			@class.method_14(this.method_13());
			@class.method_16(this.method_15());
			@class.method_18(this.method_17());
			@class.method_20(this.method_19());
			@class.method_22(this.method_21());
			@class.method_24(this.method_23());
			@class.method_26(this.method_25());
			@class.method_28(this.method_27());
			return @class;
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x000CE71C File Offset: 0x000CC91C
		public override int GetHashCode()
		{
			return this.method_0().GetHashCode();
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x000CE738 File Offset: 0x000CC938
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Class2442)
			{
				Class2442 @class = obj as Class2442;
				result = (this.string_2 == @class.string_2 && this.int_12 == @class.int_12 && this.method_4() == @class.method_4() && this.method_6() == @class.method_6() && this.method_8() == @class.method_8() && this.method_10() == @class.method_10() && this.method_12() == @class.method_12() && this.method_13() == @class.method_13() && this.method_15() == @class.method_15() && this.method_17() == @class.method_17() && this.method_19() == @class.method_19() && this.method_21() == @class.method_21() && this.method_23() == @class.method_23() && this.method_25() == @class.method_25() && this.method_27() == @class.method_27());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04000E86 RID: 3718
		public static readonly int int_0 = 100;

		// Token: 0x04000E87 RID: 3719
		public static readonly int int_1 = 8;

		// Token: 0x04000E88 RID: 3720
		public static readonly int int_2 = 8;

		// Token: 0x04000E89 RID: 3721
		public static readonly int int_3 = 8;

		// Token: 0x04000E8A RID: 3722
		public static readonly int int_4 = 8;

		// Token: 0x04000E8B RID: 3723
		public static readonly int int_5 = 12;

		// Token: 0x04000E8C RID: 3724
		public static readonly int int_6 = 6;

		// Token: 0x04000E8D RID: 3725
		public static readonly int int_7 = 2;

		// Token: 0x04000E8E RID: 3726
		public static readonly int int_8 = 12;

		// Token: 0x04000E8F RID: 3727
		public static readonly int int_9 = 32;

		// Token: 0x04000E90 RID: 3728
		public static readonly int int_10 = 32;

		// Token: 0x04000E91 RID: 3729
		public static readonly int int_11 = 8;

		// Token: 0x04000E92 RID: 3730
		public static readonly byte byte_0 = 120;

		// Token: 0x04000E93 RID: 3731
		public static readonly string string_0 = "ustar ";

		// Token: 0x04000E94 RID: 3732
		public static readonly string string_1 = "ustar  ";

		// Token: 0x04000E95 RID: 3733
		private string string_2 = "";

		// Token: 0x04000E96 RID: 3734
		private int int_12;

		// Token: 0x04000E97 RID: 3735
		private int int_13;

		// Token: 0x04000E98 RID: 3736
		private int int_14;

		// Token: 0x04000E99 RID: 3737
		private long long_0;

		// Token: 0x04000E9A RID: 3738
		private DateTime dateTime_0;

		// Token: 0x04000E9B RID: 3739
		private int int_15;

		// Token: 0x04000E9C RID: 3740
		private byte byte_1;

		// Token: 0x04000E9D RID: 3741
		private string string_3 = "";

		// Token: 0x04000E9E RID: 3742
		private string string_4 = "";

		// Token: 0x04000E9F RID: 3743
		private string string_5;

		// Token: 0x04000EA0 RID: 3744
		private string string_6;

		// Token: 0x04000EA1 RID: 3745
		private string string_7;

		// Token: 0x04000EA2 RID: 3746
		private int int_16;

		// Token: 0x04000EA3 RID: 3747
		private int int_17;

		// Token: 0x04000EA4 RID: 3748
		internal static int int_18 = 0;

		// Token: 0x04000EA5 RID: 3749
		internal static int int_19 = 0;

		// Token: 0x04000EA6 RID: 3750
		internal static string string_8 = null;

		// Token: 0x04000EA7 RID: 3751
		internal static string string_9 = "None";

		// Token: 0x04000EA8 RID: 3752
		internal static int int_20 = 0;

		// Token: 0x04000EA9 RID: 3753
		internal static int int_21 = 0;

		// Token: 0x04000EAA RID: 3754
		internal static string string_10 = "None";

		// Token: 0x04000EAB RID: 3755
		internal static string string_11 = null;

		// Token: 0x04000EAC RID: 3756
		private static readonly long long_1 = 10000000L;

		// Token: 0x04000EAD RID: 3757
		private static readonly DateTime dateTime_1 = new DateTime(1970, 1, 1, 0, 0, 0, 0);
	}
}
