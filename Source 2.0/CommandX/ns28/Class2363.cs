using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ClipperLib;

namespace ns28
{
	// Token: 0x020000E1 RID: 225
	public sealed class Class2363 : Class2362
	{
		// Token: 0x06000479 RID: 1145 RVA: 0x000606C0 File Offset: 0x0005E8C0
		public Class2363(int InitOptions = 0)
		{
			this.class2358_0 = null;
			this.class2354_0 = null;
			this.class2354_1 = null;
			this.list_2 = new List<Class2355>();
			this.icomparer_0 = new Class2356();
			this.bool_3 = false;
			this.bool_4 = false;
			this.list_1 = new List<Class2359>();
			this.list_3 = new List<Class2361>();
			this.list_4 = new List<Class2361>();
			this.method_16((1 & InitOptions) != 0);
			this.method_18((2 & InitOptions) != 0);
			base.method_1((4 & InitOptions) != 0);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0006075C File Offset: 0x0005E95C
		protected override void vmethod_0()
		{
			base.vmethod_0();
			this.class2358_0 = null;
			this.class2354_0 = null;
			this.class2354_1 = null;
			for (Class2357 class2357_ = this.class2357_0; class2357_ != null; class2357_ = class2357_.class2357_0)
			{
				this.method_19(class2357_.long_0);
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000069B2 File Offset: 0x00004BB2
		[CompilerGenerated]
		public bool method_15()
		{
			return this.bool_5;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x000069BA File Offset: 0x00004BBA
		[CompilerGenerated]
		public void method_16(bool bool_7)
		{
			this.bool_5 = bool_7;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000069C3 File Offset: 0x00004BC3
		[CompilerGenerated]
		public bool method_17()
		{
			return this.bool_6;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x000069CB File Offset: 0x00004BCB
		[CompilerGenerated]
		public void method_18(bool bool_7)
		{
			this.bool_6 = bool_7;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x000607AC File Offset: 0x0005E9AC
		private void method_19(long long_0)
		{
			if (this.class2358_0 == null)
			{
				this.class2358_0 = new Class2358();
				this.class2358_0.class2358_0 = null;
				this.class2358_0.long_0 = long_0;
			}
			else if (long_0 > this.class2358_0.long_0)
			{
				this.class2358_0 = new Class2358
				{
					long_0 = long_0,
					class2358_0 = this.class2358_0
				};
			}
			else
			{
				Class2358 @class = this.class2358_0;
				while (@class.class2358_0 != null && long_0 <= @class.class2358_0.long_0)
				{
					@class = @class.class2358_0;
				}
				if (long_0 != @class.long_0)
				{
					@class.class2358_0 = new Class2358
					{
						long_0 = long_0,
						class2358_0 = @class.class2358_0
					};
				}
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00060884 File Offset: 0x0005EA84
		public bool method_20(Enum162 enum162_1, List<List<IntPoint>> list_5, Enum164 enum164_2, Enum164 enum164_3)
		{
			bool result;
			if (this.bool_3)
			{
				result = false;
			}
			else
			{
				if (this.bool_1)
				{
					throw new Exception29("Error: PolyTree struct is need for open path clipping.");
				}
				this.bool_3 = true;
				list_5.Clear();
				this.enum164_1 = enum164_2;
				this.enum164_0 = enum164_3;
				this.enum162_0 = enum162_1;
				this.bool_4 = false;
				bool flag = false;
				try
				{
					if (flag = this.method_21())
					{
						this.method_74(list_5);
					}
				}
				finally
				{
					this.method_23();
					this.bool_3 = false;
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0006091C File Offset: 0x0005EB1C
		private bool method_21()
		{
			bool flag = false;
			bool result;
			try
			{
				this.vmethod_0();
				if (this.class2357_1 == null)
				{
					flag = false;
				}
				else
				{
					long long_ = this.method_22();
					do
					{
						this.method_28(long_);
						this.list_4.Clear();
						this.method_57(false);
						if (this.class2358_0 == null)
						{
							break;
						}
						long num = this.method_22();
						if (!this.method_65(long_, num))
						{
							goto IL_82;
						}
						this.method_71(num);
						long_ = num;
					}
					while (this.class2358_0 != null || this.class2357_1 != null);
					goto IL_8B;
					IL_82:
					flag = false;
					result = false;
					return result;
					IL_8B:
					for (int i = 0; i < this.list_1.Count; i++)
					{
						Class2359 @class = this.list_1[i];
						if (@class.class2360_0 != null && !@class.bool_1 && (@class.bool_0 ^ this.method_15()) == this.method_87(@class) > 0.0)
						{
							this.method_52(@class.class2360_0);
						}
					}
					this.method_84();
					for (int j = 0; j < this.list_1.Count; j++)
					{
						Class2359 class2 = this.list_1[j];
						if (class2.class2360_0 != null && !class2.bool_1)
						{
							this.method_75(class2);
						}
					}
					if (this.method_17())
					{
						this.method_86();
					}
					flag = true;
				}
			}
			finally
			{
				this.list_3.Clear();
				this.list_4.Clear();
			}
			result = flag;
			return result;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00060AC4 File Offset: 0x0005ECC4
		private long method_22()
		{
			long long_ = this.class2358_0.long_0;
			this.class2358_0 = this.class2358_0.class2358_0;
			return long_;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00060AF4 File Offset: 0x0005ECF4
		private void method_23()
		{
			for (int i = 0; i < this.list_1.Count; i++)
			{
				this.method_24(i);
			}
			this.list_1.Clear();
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00060B2C File Offset: 0x0005ED2C
		private void method_24(int int_0)
		{
			Class2359 @class = this.list_1[int_0];
			if (@class.class2360_0 != null)
			{
				this.method_25(@class.class2360_0);
			}
			this.list_1[int_0] = null;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000069D4 File Offset: 0x00004BD4
		private void method_25(Class2360 class2360_0)
		{
			if (class2360_0 != null)
			{
				class2360_0.class2360_1.class2360_0 = null;
				while (class2360_0 != null)
				{
					class2360_0 = class2360_0.class2360_0;
				}
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00060B6C File Offset: 0x0005ED6C
		private void method_26(Class2360 class2360_0, Class2360 class2360_1, IntPoint intPoint_0)
		{
			Class2361 @class = new Class2361();
			@class.class2360_0 = class2360_0;
			@class.class2360_1 = class2360_1;
			@class.intPoint_0 = intPoint_0;
			this.list_3.Add(@class);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00060BA0 File Offset: 0x0005EDA0
		private void method_27(Class2360 class2360_0, IntPoint intPoint_0)
		{
			Class2361 @class = new Class2361();
			@class.class2360_0 = class2360_0;
			@class.intPoint_0 = intPoint_0;
			this.list_4.Add(@class);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00060BD0 File Offset: 0x0005EDD0
		private void method_28(long long_0)
		{
			while (this.class2357_1 != null && this.class2357_1.long_0 == long_0)
			{
				Class2354 @class = this.class2357_1.class2354_0;
				Class2354 class2 = this.class2357_1.class2354_1;
				base.method_13();
				Class2360 class3 = null;
				if (@class == null)
				{
					this.method_29(class2, null);
					this.method_34(class2);
					if (this.method_33(class2))
					{
						class3 = this.method_42(class2, class2.intPoint_0);
					}
				}
				else if (class2 == null)
				{
					this.method_29(@class, null);
					this.method_34(@class);
					if (this.method_33(@class))
					{
						class3 = this.method_42(@class, @class.intPoint_0);
					}
					this.method_19(@class.intPoint_2.long_1);
				}
				else
				{
					this.method_29(@class, null);
					this.method_29(class2, @class);
					this.method_34(@class);
					class2.int_1 = @class.int_1;
					class2.int_2 = @class.int_2;
					if (this.method_33(@class))
					{
						class3 = this.method_40(@class, class2, @class.intPoint_0);
					}
					this.method_19(@class.intPoint_2.long_1);
				}
				if (class2 != null)
				{
					if (Class2362.smethod_1(class2))
					{
						this.method_35(class2);
					}
					else
					{
						this.method_19(class2.intPoint_2.long_1);
					}
				}
				if (@class != null && class2 != null)
				{
					if (class3 != null && Class2362.smethod_1(class2) && this.list_4.Count > 0 && class2.int_0 != 0)
					{
						for (int i = 0; i < this.list_4.Count; i++)
						{
							Class2361 class4 = this.list_4[i];
							if (this.method_43(class4.class2360_0.intPoint_0, class4.intPoint_0, class2.intPoint_0, class2.intPoint_2))
							{
								this.method_26(class4.class2360_0, class3, class4.intPoint_0);
							}
						}
					}
					if (@class.int_3 >= 0 && @class.class2354_4 != null && @class.class2354_4.intPoint_1.long_0 == @class.intPoint_0.long_0 && @class.class2354_4.int_3 >= 0 && Class2362.smethod_2(@class.class2354_4, @class, this.bool_0) && @class.int_0 != 0 && @class.class2354_4.int_0 != 0)
					{
						Class2360 class2360_ = this.method_42(@class.class2354_4, @class.intPoint_0);
						this.method_26(class3, class2360_, @class.intPoint_2);
					}
					if (@class.class2354_3 != class2)
					{
						if (class2.int_3 >= 0 && class2.class2354_4.int_3 >= 0 && Class2362.smethod_2(class2.class2354_4, class2, this.bool_0) && class2.int_0 != 0 && class2.class2354_4.int_0 != 0)
						{
							Class2360 class2360_2 = this.method_42(class2.class2354_4, class2.intPoint_0);
							this.method_26(class3, class2360_2, class2.intPoint_2);
						}
						Class2354 class2354_ = @class.class2354_3;
						if (class2354_ != null)
						{
							while (class2354_ != class2)
							{
								this.method_53(class2, class2354_, @class.intPoint_1, false);
								class2354_ = class2354_.class2354_3;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00060F00 File Offset: 0x0005F100
		private void method_29(Class2354 class2354_2, Class2354 class2354_3)
		{
			if (this.class2354_0 == null)
			{
				class2354_2.class2354_4 = null;
				class2354_2.class2354_3 = null;
				this.class2354_0 = class2354_2;
			}
			else if (class2354_3 == null && this.method_30(this.class2354_0, class2354_2))
			{
				class2354_2.class2354_4 = null;
				class2354_2.class2354_3 = this.class2354_0;
				this.class2354_0.class2354_4 = class2354_2;
				this.class2354_0 = class2354_2;
			}
			else
			{
				if (class2354_3 == null)
				{
					class2354_3 = this.class2354_0;
				}
				while (class2354_3.class2354_3 != null && !this.method_30(class2354_3.class2354_3, class2354_2))
				{
					class2354_3 = class2354_3.class2354_3;
				}
				class2354_2.class2354_3 = class2354_3.class2354_3;
				if (class2354_3.class2354_3 != null)
				{
					class2354_3.class2354_3.class2354_4 = class2354_2;
				}
				class2354_2.class2354_4 = class2354_3;
				class2354_3.class2354_3 = class2354_2;
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00060FE4 File Offset: 0x0005F1E4
		private bool method_30(Class2354 class2354_2, Class2354 class2354_3)
		{
			bool result;
			if (class2354_3.intPoint_1.long_0 != class2354_2.intPoint_1.long_0)
			{
				result = (class2354_3.intPoint_1.long_0 < class2354_2.intPoint_1.long_0);
			}
			else if (class2354_3.intPoint_2.long_1 > class2354_2.intPoint_2.long_1)
			{
				result = (class2354_3.intPoint_2.long_0 < Class2363.smethod_8(class2354_2, class2354_3.intPoint_2.long_1));
			}
			else
			{
				result = (class2354_2.intPoint_2.long_0 > Class2363.smethod_8(class2354_3, class2354_2.intPoint_2.long_1));
			}
			return result;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00061084 File Offset: 0x0005F284
		private bool method_31(Class2354 class2354_2)
		{
			bool result;
			if (class2354_2.enum163_0 == Enum163.const_0)
			{
				result = (this.enum164_1 == Enum164.const_0);
			}
			else
			{
				result = (this.enum164_0 == Enum164.const_0);
			}
			return result;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000610B8 File Offset: 0x0005F2B8
		private bool method_32(Class2354 class2354_2)
		{
			bool result;
			if (class2354_2.enum163_0 == Enum163.const_0)
			{
				result = (this.enum164_0 == Enum164.const_0);
			}
			else
			{
				result = (this.enum164_1 == Enum164.const_0);
			}
			return result;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000610EC File Offset: 0x0005F2EC
		private bool method_33(Class2354 class2354_2)
		{
			Enum164 @enum;
			Enum164 enum2;
			if (class2354_2.enum163_0 == Enum163.const_0)
			{
				@enum = this.enum164_1;
				enum2 = this.enum164_0;
			}
			else
			{
				@enum = this.enum164_0;
				enum2 = this.enum164_1;
			}
			bool result;
			switch (@enum)
			{
			case Enum164.const_0:
				if (class2354_2.int_0 == 0 && class2354_2.int_1 != 1)
				{
					result = false;
					return result;
				}
				break;
			case Enum164.const_1:
				if (Math.Abs(class2354_2.int_1) != 1)
				{
					result = false;
					return result;
				}
				break;
			case Enum164.const_2:
				if (class2354_2.int_1 != 1)
				{
					result = false;
					return result;
				}
				break;
			default:
				if (class2354_2.int_1 != -1)
				{
					result = false;
					return result;
				}
				break;
			}
			switch (this.enum162_0)
			{
			case Enum162.const_0:
				switch (enum2)
				{
				case Enum164.const_0:
				case Enum164.const_1:
					result = (class2354_2.int_2 != 0);
					break;
				case Enum164.const_2:
					result = (class2354_2.int_2 > 0);
					break;
				default:
					result = (class2354_2.int_2 < 0);
					break;
				}
				break;
			case Enum162.const_1:
				switch (enum2)
				{
				case Enum164.const_0:
				case Enum164.const_1:
					result = (class2354_2.int_2 == 0);
					break;
				case Enum164.const_2:
					result = (class2354_2.int_2 <= 0);
					break;
				default:
					result = (class2354_2.int_2 >= 0);
					break;
				}
				break;
			case Enum162.const_2:
				if (class2354_2.enum163_0 == Enum163.const_0)
				{
					switch (enum2)
					{
					case Enum164.const_0:
					case Enum164.const_1:
						result = (class2354_2.int_2 == 0);
						break;
					case Enum164.const_2:
						result = (class2354_2.int_2 <= 0);
						break;
					default:
						result = (class2354_2.int_2 >= 0);
						break;
					}
				}
				else
				{
					switch (enum2)
					{
					case Enum164.const_0:
					case Enum164.const_1:
						result = (class2354_2.int_2 != 0);
						break;
					case Enum164.const_2:
						result = (class2354_2.int_2 > 0);
						break;
					default:
						result = (class2354_2.int_2 < 0);
						break;
					}
				}
				break;
			case Enum162.const_3:
				if (class2354_2.int_0 != 0)
				{
					result = true;
				}
				else
				{
					switch (enum2)
					{
					case Enum164.const_0:
					case Enum164.const_1:
						result = (class2354_2.int_2 == 0);
						break;
					case Enum164.const_2:
						result = (class2354_2.int_2 <= 0);
						break;
					default:
						result = (class2354_2.int_2 >= 0);
						break;
					}
				}
				break;
			default:
				result = true;
				break;
			}
			return result;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00061320 File Offset: 0x0005F520
		private void method_34(Class2354 class2354_2)
		{
			Class2354 @class = class2354_2.class2354_4;
			while (@class != null && (@class.enum163_0 != class2354_2.enum163_0 || @class.int_0 == 0))
			{
				@class = @class.class2354_4;
			}
			if (@class == null)
			{
				class2354_2.int_1 = ((class2354_2.int_0 == 0) ? 1 : class2354_2.int_0);
				class2354_2.int_2 = 0;
				@class = this.class2354_0;
			}
			else if (class2354_2.int_0 == 0 && this.enum162_0 != Enum162.const_1)
			{
				class2354_2.int_1 = 1;
				class2354_2.int_2 = @class.int_2;
				@class = @class.class2354_3;
			}
			else if (this.method_31(class2354_2))
			{
				if (class2354_2.int_0 == 0)
				{
					bool flag = true;
					for (Class2354 class2354_3 = @class.class2354_4; class2354_3 != null; class2354_3 = class2354_3.class2354_4)
					{
						if (class2354_3.enum163_0 == @class.enum163_0 && class2354_3.int_0 != 0)
						{
							flag = !flag;
						}
					}
					class2354_2.int_1 = (flag ? 0 : 1);
				}
				else
				{
					class2354_2.int_1 = class2354_2.int_0;
				}
				class2354_2.int_2 = @class.int_2;
				@class = @class.class2354_3;
			}
			else
			{
				if (@class.int_1 * @class.int_0 < 0)
				{
					if (Math.Abs(@class.int_1) > 1)
					{
						if (@class.int_0 * class2354_2.int_0 < 0)
						{
							class2354_2.int_1 = @class.int_1;
						}
						else
						{
							class2354_2.int_1 = @class.int_1 + class2354_2.int_0;
						}
					}
					else
					{
						class2354_2.int_1 = ((class2354_2.int_0 == 0) ? 1 : class2354_2.int_0);
					}
				}
				else if (class2354_2.int_0 == 0)
				{
					class2354_2.int_1 = ((@class.int_1 < 0) ? (@class.int_1 - 1) : (@class.int_1 + 1));
				}
				else if (@class.int_0 * class2354_2.int_0 < 0)
				{
					class2354_2.int_1 = @class.int_1;
				}
				else
				{
					class2354_2.int_1 = @class.int_1 + class2354_2.int_0;
				}
				class2354_2.int_2 = @class.int_2;
				@class = @class.class2354_3;
			}
			if (this.method_32(class2354_2))
			{
				while (@class != class2354_2)
				{
					if (@class.int_0 != 0)
					{
						class2354_2.int_2 = ((class2354_2.int_2 == 0) ? 1 : 0);
					}
					@class = @class.class2354_3;
				}
			}
			else
			{
				while (@class != class2354_2)
				{
					class2354_2.int_2 += @class.int_0;
					@class = @class.class2354_3;
				}
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000615B0 File Offset: 0x0005F7B0
		private void method_35(Class2354 class2354_2)
		{
			if (this.class2354_1 == null)
			{
				this.class2354_1 = class2354_2;
				class2354_2.class2354_6 = null;
				class2354_2.class2354_5 = null;
			}
			else
			{
				class2354_2.class2354_5 = this.class2354_1;
				class2354_2.class2354_6 = null;
				this.class2354_1.class2354_6 = class2354_2;
				this.class2354_1 = class2354_2;
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00061608 File Offset: 0x0005F808
		private void method_36()
		{
			Class2354 class2354_ = this.class2354_0;
			this.class2354_1 = class2354_;
			while (class2354_ != null)
			{
				class2354_.class2354_6 = class2354_.class2354_4;
				class2354_.class2354_5 = class2354_.class2354_3;
				class2354_ = class2354_.class2354_3;
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00061650 File Offset: 0x0005F850
		private void method_37(Class2354 class2354_2, Class2354 class2354_3)
		{
			if (class2354_2.class2354_3 != class2354_2.class2354_4 && class2354_3.class2354_3 != class2354_3.class2354_4)
			{
				if (class2354_2.class2354_3 == class2354_3)
				{
					Class2354 class2354_4 = class2354_3.class2354_3;
					if (class2354_4 != null)
					{
						class2354_4.class2354_4 = class2354_2;
					}
					Class2354 class2354_5 = class2354_2.class2354_4;
					if (class2354_5 != null)
					{
						class2354_5.class2354_3 = class2354_3;
					}
					class2354_3.class2354_4 = class2354_5;
					class2354_3.class2354_3 = class2354_2;
					class2354_2.class2354_4 = class2354_3;
					class2354_2.class2354_3 = class2354_4;
				}
				else if (class2354_3.class2354_3 == class2354_2)
				{
					Class2354 class2354_6 = class2354_2.class2354_3;
					if (class2354_6 != null)
					{
						class2354_6.class2354_4 = class2354_3;
					}
					Class2354 class2354_7 = class2354_3.class2354_4;
					if (class2354_7 != null)
					{
						class2354_7.class2354_3 = class2354_2;
					}
					class2354_2.class2354_4 = class2354_7;
					class2354_2.class2354_3 = class2354_3;
					class2354_3.class2354_4 = class2354_2;
					class2354_3.class2354_3 = class2354_6;
				}
				else
				{
					Class2354 class2354_8 = class2354_2.class2354_3;
					Class2354 class2354_9 = class2354_2.class2354_4;
					class2354_2.class2354_3 = class2354_3.class2354_3;
					if (class2354_2.class2354_3 != null)
					{
						class2354_2.class2354_3.class2354_4 = class2354_2;
					}
					class2354_2.class2354_4 = class2354_3.class2354_4;
					if (class2354_2.class2354_4 != null)
					{
						class2354_2.class2354_4.class2354_3 = class2354_2;
					}
					class2354_3.class2354_3 = class2354_8;
					if (class2354_3.class2354_3 != null)
					{
						class2354_3.class2354_3.class2354_4 = class2354_3;
					}
					class2354_3.class2354_4 = class2354_9;
					if (class2354_3.class2354_4 != null)
					{
						class2354_3.class2354_4.class2354_3 = class2354_3;
					}
				}
				if (class2354_2.class2354_4 == null)
				{
					this.class2354_0 = class2354_2;
				}
				else if (class2354_3.class2354_4 == null)
				{
					this.class2354_0 = class2354_3;
				}
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000617F4 File Offset: 0x0005F9F4
		private void method_38(Class2354 class2354_2, Class2354 class2354_3)
		{
			if ((class2354_2.class2354_5 != null || class2354_2.class2354_6 != null) && (class2354_3.class2354_5 != null || class2354_3.class2354_6 != null))
			{
				if (class2354_2.class2354_5 == class2354_3)
				{
					Class2354 class2354_4 = class2354_3.class2354_5;
					if (class2354_4 != null)
					{
						class2354_4.class2354_6 = class2354_2;
					}
					Class2354 class2354_5 = class2354_2.class2354_6;
					if (class2354_5 != null)
					{
						class2354_5.class2354_5 = class2354_3;
					}
					class2354_3.class2354_6 = class2354_5;
					class2354_3.class2354_5 = class2354_2;
					class2354_2.class2354_6 = class2354_3;
					class2354_2.class2354_5 = class2354_4;
				}
				else if (class2354_3.class2354_5 == class2354_2)
				{
					Class2354 class2354_6 = class2354_2.class2354_5;
					if (class2354_6 != null)
					{
						class2354_6.class2354_6 = class2354_3;
					}
					Class2354 class2354_7 = class2354_3.class2354_6;
					if (class2354_7 != null)
					{
						class2354_7.class2354_5 = class2354_2;
					}
					class2354_2.class2354_6 = class2354_7;
					class2354_2.class2354_5 = class2354_3;
					class2354_3.class2354_6 = class2354_2;
					class2354_3.class2354_5 = class2354_6;
				}
				else
				{
					Class2354 class2354_8 = class2354_2.class2354_5;
					Class2354 class2354_9 = class2354_2.class2354_6;
					class2354_2.class2354_5 = class2354_3.class2354_5;
					if (class2354_2.class2354_5 != null)
					{
						class2354_2.class2354_5.class2354_6 = class2354_2;
					}
					class2354_2.class2354_6 = class2354_3.class2354_6;
					if (class2354_2.class2354_6 != null)
					{
						class2354_2.class2354_6.class2354_5 = class2354_2;
					}
					class2354_3.class2354_5 = class2354_8;
					if (class2354_3.class2354_5 != null)
					{
						class2354_3.class2354_5.class2354_6 = class2354_3;
					}
					class2354_3.class2354_6 = class2354_9;
					if (class2354_3.class2354_6 != null)
					{
						class2354_3.class2354_6.class2354_5 = class2354_3;
					}
				}
				if (class2354_2.class2354_6 == null)
				{
					this.class2354_1 = class2354_2;
				}
				else if (class2354_3.class2354_6 == null)
				{
					this.class2354_1 = class2354_3;
				}
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000619A8 File Offset: 0x0005FBA8
		private void method_39(Class2354 class2354_2, Class2354 class2354_3, IntPoint intPoint_0)
		{
			this.method_42(class2354_2, intPoint_0);
			if (class2354_3.int_0 == 0)
			{
				this.method_42(class2354_3, intPoint_0);
			}
			if (class2354_2.int_3 == class2354_3.int_3)
			{
				class2354_2.int_3 = -1;
				class2354_3.int_3 = -1;
			}
			else if (class2354_2.int_3 < class2354_3.int_3)
			{
				this.method_51(class2354_2, class2354_3);
			}
			else
			{
				this.method_51(class2354_3, class2354_2);
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00061A20 File Offset: 0x0005FC20
		private Class2360 method_40(Class2354 class2354_2, Class2354 class2354_3, IntPoint intPoint_0)
		{
			Class2360 @class;
			Class2354 class2;
			Class2354 class2354_4;
			if (!Class2362.smethod_1(class2354_3) && class2354_2.double_0 <= class2354_3.double_0)
			{
				@class = this.method_42(class2354_3, intPoint_0);
				class2354_2.int_3 = class2354_3.int_3;
				class2354_2.enum167_0 = Enum167.const_1;
				class2354_3.enum167_0 = Enum167.const_0;
				class2 = class2354_3;
				if (class2.class2354_4 == class2354_2)
				{
					class2354_4 = class2354_2.class2354_4;
				}
				else
				{
					class2354_4 = class2.class2354_4;
				}
			}
			else
			{
				@class = this.method_42(class2354_2, intPoint_0);
				class2354_3.int_3 = class2354_2.int_3;
				class2354_2.enum167_0 = Enum167.const_0;
				class2354_3.enum167_0 = Enum167.const_1;
				class2 = class2354_2;
				if (class2.class2354_4 == class2354_3)
				{
					class2354_4 = class2354_3.class2354_4;
				}
				else
				{
					class2354_4 = class2.class2354_4;
				}
			}
			if (class2354_4 != null && class2354_4.int_3 >= 0 && Class2363.smethod_8(class2354_4, intPoint_0.long_1) == Class2363.smethod_8(class2, intPoint_0.long_1) && Class2362.smethod_2(class2, class2354_4, this.bool_0) && class2.int_0 != 0 && class2354_4.int_0 != 0)
			{
				Class2360 class2360_ = this.method_42(class2354_4, intPoint_0);
				this.method_26(@class, class2360_, class2.intPoint_2);
			}
			return @class;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00061B3C File Offset: 0x0005FD3C
		private Class2359 method_41()
		{
			Class2359 @class = new Class2359();
			@class.int_0 = -1;
			@class.bool_0 = false;
			@class.bool_1 = false;
			@class.class2359_0 = null;
			@class.class2360_0 = null;
			@class.class2360_1 = null;
			@class.class2353_0 = null;
			this.list_1.Add(@class);
			@class.int_0 = this.list_1.Count - 1;
			return @class;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00061BA4 File Offset: 0x0005FDA4
		private Class2360 method_42(Class2354 class2354_2, IntPoint intPoint_0)
		{
			bool flag = class2354_2.enum167_0 == Enum167.const_0;
			Class2360 result;
			if (class2354_2.int_3 < 0)
			{
				Class2359 @class = this.method_41();
				@class.bool_1 = (class2354_2.int_0 == 0);
				Class2360 class2 = new Class2360();
				@class.class2360_0 = class2;
				class2.int_0 = @class.int_0;
				class2.intPoint_0 = intPoint_0;
				class2.class2360_0 = class2;
				class2.class2360_1 = class2;
				if (!@class.bool_1)
				{
					this.method_44(class2354_2, @class);
				}
				class2354_2.int_3 = @class.int_0;
				result = class2;
			}
			else
			{
				Class2359 class3 = this.list_1[class2354_2.int_3];
				Class2360 class2360_ = class3.class2360_0;
				if (flag && IntPoint.smethod_0(intPoint_0, class2360_.intPoint_0))
				{
					result = class2360_;
				}
				else if (!flag && IntPoint.smethod_0(intPoint_0, class2360_.class2360_1.intPoint_0))
				{
					result = class2360_.class2360_1;
				}
				else
				{
					Class2360 class4 = new Class2360();
					class4.int_0 = class3.int_0;
					class4.intPoint_0 = intPoint_0;
					class4.class2360_0 = class2360_;
					class4.class2360_1 = class2360_.class2360_1;
					class4.class2360_1.class2360_0 = class4;
					class2360_.class2360_1 = class4;
					if (flag)
					{
						class3.class2360_0 = class4;
					}
					result = class4;
				}
			}
			return result;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00061CF4 File Offset: 0x0005FEF4
		private bool method_43(IntPoint intPoint_0, IntPoint intPoint_1, IntPoint intPoint_2, IntPoint intPoint_3)
		{
			return intPoint_0.long_0 > intPoint_2.long_0 == intPoint_0.long_0 < intPoint_3.long_0 || intPoint_1.long_0 > intPoint_2.long_0 == intPoint_1.long_0 < intPoint_3.long_0 || intPoint_2.long_0 > intPoint_0.long_0 == intPoint_2.long_0 < intPoint_1.long_0 || intPoint_3.long_0 > intPoint_0.long_0 == intPoint_3.long_0 < intPoint_1.long_0 || (intPoint_0.long_0 == intPoint_2.long_0 && intPoint_1.long_0 == intPoint_3.long_0) || (intPoint_0.long_0 == intPoint_3.long_0 && intPoint_1.long_0 == intPoint_2.long_0);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00061DD8 File Offset: 0x0005FFD8
		private void method_44(Class2354 class2354_2, Class2359 class2359_0)
		{
			bool flag = false;
			for (Class2354 class2354_3 = class2354_2.class2354_4; class2354_3 != null; class2354_3 = class2354_3.class2354_4)
			{
				if (class2354_3.int_3 >= 0 && class2354_3.int_0 != 0)
				{
					flag = !flag;
					if (class2359_0.class2359_0 == null)
					{
						class2359_0.class2359_0 = this.list_1[class2354_3.int_3];
					}
				}
			}
			if (flag)
			{
				class2359_0.bool_0 = true;
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00061E50 File Offset: 0x00060050
		private double method_45(IntPoint intPoint_0, IntPoint intPoint_1)
		{
			double result;
			if (intPoint_0.long_1 == intPoint_1.long_1)
			{
				result = -3.4E+38;
			}
			else
			{
				result = (double)(intPoint_1.long_0 - intPoint_0.long_0) / (double)(intPoint_1.long_1 - intPoint_0.long_1);
			}
			return result;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00061EA4 File Offset: 0x000600A4
		private bool method_46(Class2360 class2360_0, Class2360 class2360_1)
		{
			Class2360 @class = class2360_0.class2360_1;
			while (IntPoint.smethod_0(@class.intPoint_0, class2360_0.intPoint_0) && @class != class2360_0)
			{
				@class = @class.class2360_1;
			}
			double num = Math.Abs(this.method_45(class2360_0.intPoint_0, @class.intPoint_0));
			@class = class2360_0.class2360_0;
			while (IntPoint.smethod_0(@class.intPoint_0, class2360_0.intPoint_0) && @class != class2360_0)
			{
				@class = @class.class2360_0;
			}
			double num2 = Math.Abs(this.method_45(class2360_0.intPoint_0, @class.intPoint_0));
			@class = class2360_1.class2360_1;
			while (IntPoint.smethod_0(@class.intPoint_0, class2360_1.intPoint_0) && @class != class2360_1)
			{
				@class = @class.class2360_1;
			}
			double num3 = Math.Abs(this.method_45(class2360_1.intPoint_0, @class.intPoint_0));
			@class = class2360_1.class2360_0;
			while (IntPoint.smethod_0(@class.intPoint_0, class2360_1.intPoint_0) && @class != class2360_1)
			{
				@class = @class.class2360_0;
			}
			double num4 = Math.Abs(this.method_45(class2360_1.intPoint_0, @class.intPoint_0));
			return (num >= num3 && num >= num4) || (num2 >= num3 && num2 >= num4);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00061FE0 File Offset: 0x000601E0
		private Class2360 method_47(Class2360 class2360_0)
		{
			Class2360 @class = null;
			Class2360 class2360_;
			for (class2360_ = class2360_0.class2360_0; class2360_ != class2360_0; class2360_ = class2360_.class2360_0)
			{
				if (class2360_.intPoint_0.long_1 > class2360_0.intPoint_0.long_1)
				{
					class2360_0 = class2360_;
					@class = null;
				}
				else if (class2360_.intPoint_0.long_1 == class2360_0.intPoint_0.long_1 && class2360_.intPoint_0.long_0 <= class2360_0.intPoint_0.long_0)
				{
					if (class2360_.intPoint_0.long_0 < class2360_0.intPoint_0.long_0)
					{
						@class = null;
						class2360_0 = class2360_;
					}
					else if (class2360_.class2360_0 != class2360_0 && class2360_.class2360_1 != class2360_0)
					{
						@class = class2360_;
					}
				}
			}
			if (@class != null)
			{
				while (@class != class2360_)
				{
					if (!this.method_46(class2360_, @class))
					{
						class2360_0 = @class;
					}
					@class = @class.class2360_0;
					while (IntPoint.smethod_1(@class.intPoint_0, class2360_0.intPoint_0))
					{
						@class = @class.class2360_0;
					}
				}
			}
			return class2360_0;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000620E8 File Offset: 0x000602E8
		private Class2359 method_48(Class2359 class2359_0, Class2359 class2359_1)
		{
			if (class2359_0.class2360_1 == null)
			{
				class2359_0.class2360_1 = this.method_47(class2359_0.class2360_0);
			}
			if (class2359_1.class2360_1 == null)
			{
				class2359_1.class2360_1 = this.method_47(class2359_1.class2360_0);
			}
			Class2360 class2360_ = class2359_0.class2360_1;
			Class2360 class2360_2 = class2359_1.class2360_1;
			Class2359 result;
			if (class2360_.intPoint_0.long_1 > class2360_2.intPoint_0.long_1)
			{
				result = class2359_0;
			}
			else if (class2360_.intPoint_0.long_1 < class2360_2.intPoint_0.long_1)
			{
				result = class2359_1;
			}
			else if (class2360_.intPoint_0.long_0 < class2360_2.intPoint_0.long_0)
			{
				result = class2359_0;
			}
			else if (class2360_.intPoint_0.long_0 > class2360_2.intPoint_0.long_0)
			{
				result = class2359_1;
			}
			else if (class2360_.class2360_0 == class2360_)
			{
				result = class2359_1;
			}
			else if (class2360_2.class2360_0 == class2360_2)
			{
				result = class2359_0;
			}
			else if (this.method_46(class2360_, class2360_2))
			{
				result = class2359_0;
			}
			else
			{
				result = class2359_1;
			}
			return result;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00062204 File Offset: 0x00060404
		private bool method_49(Class2359 class2359_0, Class2359 class2359_1)
		{
			while (true)
			{
				class2359_0 = class2359_0.class2359_0;
				if (class2359_0 == class2359_1)
				{
					break;
				}
				if (class2359_0 == null)
				{
					goto IL_21;
				}
			}
			bool result = true;
			return result;
			IL_21:
			result = false;
			return result;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00062238 File Offset: 0x00060438
		private Class2359 method_50(int int_0)
		{
			Class2359 @class;
			for (@class = this.list_1[int_0]; @class != this.list_1[@class.int_0]; @class = this.list_1[@class.int_0])
			{
			}
			return @class;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00062284 File Offset: 0x00060484
		private void method_51(Class2354 class2354_2, Class2354 class2354_3)
		{
			Class2359 @class = this.list_1[class2354_2.int_3];
			Class2359 class2 = this.list_1[class2354_3.int_3];
			Class2359 class3;
			if (this.method_49(@class, class2))
			{
				class3 = class2;
			}
			else if (this.method_49(class2, @class))
			{
				class3 = @class;
			}
			else
			{
				class3 = this.method_48(@class, class2);
			}
			Class2360 class2360_ = @class.class2360_0;
			Class2360 class2360_2 = class2360_.class2360_1;
			Class2360 class2360_3 = class2.class2360_0;
			Class2360 class2360_4 = class2360_3.class2360_1;
			Enum167 enum167_;
			if (class2354_2.enum167_0 == Enum167.const_0)
			{
				if (class2354_3.enum167_0 == Enum167.const_0)
				{
					this.method_52(class2360_3);
					class2360_3.class2360_0 = class2360_;
					class2360_.class2360_1 = class2360_3;
					class2360_2.class2360_0 = class2360_4;
					class2360_4.class2360_1 = class2360_2;
					@class.class2360_0 = class2360_4;
				}
				else
				{
					class2360_4.class2360_0 = class2360_;
					class2360_.class2360_1 = class2360_4;
					class2360_3.class2360_1 = class2360_2;
					class2360_2.class2360_0 = class2360_3;
					@class.class2360_0 = class2360_3;
				}
				enum167_ = Enum167.const_0;
			}
			else
			{
				if (class2354_3.enum167_0 == Enum167.const_1)
				{
					this.method_52(class2360_3);
					class2360_2.class2360_0 = class2360_4;
					class2360_4.class2360_1 = class2360_2;
					class2360_3.class2360_0 = class2360_;
					class2360_.class2360_1 = class2360_3;
				}
				else
				{
					class2360_2.class2360_0 = class2360_3;
					class2360_3.class2360_1 = class2360_2;
					class2360_.class2360_1 = class2360_4;
					class2360_4.class2360_0 = class2360_;
				}
				enum167_ = Enum167.const_1;
			}
			@class.class2360_1 = null;
			if (class3 == class2)
			{
				if (class2.class2359_0 != @class)
				{
					@class.class2359_0 = class2.class2359_0;
				}
				@class.bool_0 = class2.bool_0;
			}
			class2.class2360_0 = null;
			class2.class2360_1 = null;
			class2.class2359_0 = @class;
			int int_ = class2354_2.int_3;
			int int_2 = class2354_3.int_3;
			class2354_2.int_3 = -1;
			class2354_3.int_3 = -1;
			for (Class2354 class2354_4 = this.class2354_0; class2354_4 != null; class2354_4 = class2354_4.class2354_3)
			{
				if (class2354_4.int_3 == int_2)
				{
					class2354_4.int_3 = int_;
					class2354_4.enum167_0 = enum167_;
					class2.int_0 = @class.int_0;
					return;
				}
			}
			class2.int_0 = @class.int_0;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000624A0 File Offset: 0x000606A0
		private void method_52(Class2360 class2360_0)
		{
			if (class2360_0 != null)
			{
				Class2360 @class = class2360_0;
				do
				{
					Class2360 class2360_ = @class.class2360_0;
					@class.class2360_0 = @class.class2360_1;
					@class.class2360_1 = class2360_;
					@class = class2360_;
				}
				while (@class != class2360_0);
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x000624E0 File Offset: 0x000606E0
		private static void smethod_5(Class2354 class2354_2, Class2354 class2354_3)
		{
			Enum167 enum167_ = class2354_2.enum167_0;
			class2354_2.enum167_0 = class2354_3.enum167_0;
			class2354_3.enum167_0 = enum167_;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00062508 File Offset: 0x00060708
		private static void smethod_6(Class2354 class2354_2, Class2354 class2354_3)
		{
			int int_ = class2354_2.int_3;
			class2354_2.int_3 = class2354_3.int_3;
			class2354_3.int_3 = int_;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00062530 File Offset: 0x00060730
		private void method_53(Class2354 e1, Class2354 e2, IntPoint pt, bool protect = false)
		{
			bool flag = !protect && e1.class2354_2 == null && e1.intPoint_2.long_0 == pt.long_0 && e1.intPoint_2.long_1 == pt.long_1;
			bool flag2 = !protect && e2.class2354_2 == null && e2.intPoint_2.long_0 == pt.long_0 && e2.intPoint_2.long_1 == pt.long_1;
			bool flag3 = e1.int_3 >= 0;
			bool flag4 = e2.int_3 >= 0;
			if (e1.enum163_0 == e2.enum163_0)
			{
				if (this.method_31(e1))
				{
					int int_ = e1.int_1;
					e1.int_1 = e2.int_1;
					e2.int_1 = int_;
				}
				else
				{
					if (e1.int_1 + e2.int_0 == 0)
					{
						e1.int_1 = -e1.int_1;
					}
					else
					{
						e1.int_1 += e2.int_0;
					}
					if (e2.int_1 - e1.int_0 == 0)
					{
						e2.int_1 = -e2.int_1;
					}
					else
					{
						e2.int_1 -= e1.int_0;
					}
				}
			}
			else
			{
				if (!this.method_31(e2))
				{
					e1.int_2 += e2.int_0;
				}
				else
				{
					e1.int_2 = ((e1.int_2 == 0) ? 1 : 0);
				}
				if (!this.method_31(e1))
				{
					e2.int_2 -= e1.int_0;
				}
				else
				{
					e2.int_2 = ((e2.int_2 == 0) ? 1 : 0);
				}
			}
			Enum164 @enum;
			Enum164 enum2;
			if (e1.enum163_0 == Enum163.const_0)
			{
				@enum = this.enum164_1;
				enum2 = this.enum164_0;
			}
			else
			{
				@enum = this.enum164_0;
				enum2 = this.enum164_1;
			}
			Enum164 enum3;
			Enum164 enum4;
			if (e2.enum163_0 == Enum163.const_0)
			{
				enum3 = this.enum164_1;
				enum4 = this.enum164_0;
			}
			else
			{
				enum3 = this.enum164_0;
				enum4 = this.enum164_1;
			}
			int num;
			if (@enum != Enum164.const_2)
			{
				if (@enum != Enum164.const_3)
				{
					num = Math.Abs(e1.int_1);
				}
				else
				{
					num = -e1.int_1;
				}
			}
			else
			{
				num = e1.int_1;
			}
			int num2;
			if (enum3 != Enum164.const_2)
			{
				if (enum3 != Enum164.const_3)
				{
					num2 = Math.Abs(e2.int_1);
				}
				else
				{
					num2 = -e2.int_1;
				}
			}
			else
			{
				num2 = e2.int_1;
			}
			if (flag3 & flag4)
			{
				if (!(flag | flag2) && (num == 0 || num == 1) && (num2 == 0 || num2 == 1) && (e1.enum163_0 == e2.enum163_0 || this.enum162_0 == Enum162.const_3))
				{
					this.method_42(e1, pt);
					this.method_42(e2, pt);
					Class2363.smethod_5(e1, e2);
					Class2363.smethod_6(e1, e2);
				}
				else
				{
					this.method_39(e1, e2, pt);
				}
			}
			else if (flag3)
			{
				if (num2 == 0 || num2 == 1)
				{
					this.method_42(e1, pt);
					Class2363.smethod_5(e1, e2);
					Class2363.smethod_6(e1, e2);
				}
			}
			else if (flag4)
			{
				if (num == 0 || num == 1)
				{
					this.method_42(e2, pt);
					Class2363.smethod_5(e1, e2);
					Class2363.smethod_6(e1, e2);
				}
			}
			else if ((num == 0 || num == 1) && (num2 == 0 || num2 == 1) && !flag && !flag2)
			{
				long num3;
				if (enum2 != Enum164.const_2)
				{
					if (enum2 != Enum164.const_3)
					{
						num3 = (long)Math.Abs(e1.int_2);
					}
					else
					{
						num3 = -(long)e1.int_2;
					}
				}
				else
				{
					num3 = (long)e1.int_2;
				}
				long num4;
				if (enum4 != Enum164.const_2)
				{
					if (enum4 != Enum164.const_3)
					{
						num4 = (long)Math.Abs(e2.int_2);
					}
					else
					{
						num4 = -(long)e2.int_2;
					}
				}
				else
				{
					num4 = (long)e2.int_2;
				}
				if (e1.enum163_0 != e2.enum163_0)
				{
					this.method_40(e1, e2, pt);
				}
				else if (num == 1 && num2 == 1)
				{
					switch (this.enum162_0)
					{
					case Enum162.const_0:
						if (num3 > 0L && num4 > 0L)
						{
							this.method_40(e1, e2, pt);
						}
						break;
					case Enum162.const_1:
						if (num3 <= 0L && num4 <= 0L)
						{
							this.method_40(e1, e2, pt);
						}
						break;
					case Enum162.const_2:
						if ((e1.enum163_0 == Enum163.const_1 && num3 > 0L && num4 > 0L) || (e1.enum163_0 == Enum163.const_0 && num3 <= 0L && num4 <= 0L))
						{
							this.method_40(e1, e2, pt);
						}
						break;
					case Enum162.const_3:
						this.method_40(e1, e2, pt);
						break;
					}
				}
				else
				{
					Class2363.smethod_5(e1, e2);
				}
			}
			if (flag != flag2 && ((flag && e1.int_3 >= 0) || (flag2 && e2.int_3 >= 0)))
			{
				Class2363.smethod_5(e1, e2);
				Class2363.smethod_6(e1, e2);
			}
			if (flag)
			{
				this.method_54(e1);
			}
			if (flag2)
			{
				this.method_54(e2);
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00062A80 File Offset: 0x00060C80
		private void method_54(Class2354 class2354_2)
		{
			Class2354 class2354_3 = class2354_2.class2354_4;
			Class2354 class2354_4 = class2354_2.class2354_3;
			if (class2354_3 != null || class2354_4 != null || class2354_2 == this.class2354_0)
			{
				if (class2354_3 != null)
				{
					class2354_3.class2354_3 = class2354_4;
				}
				else
				{
					this.class2354_0 = class2354_4;
				}
				if (class2354_4 != null)
				{
					class2354_4.class2354_4 = class2354_3;
				}
				class2354_2.class2354_3 = null;
				class2354_2.class2354_4 = null;
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00062AE0 File Offset: 0x00060CE0
		private void method_55(Class2354 class2354_2)
		{
			Class2354 class2354_3 = class2354_2.class2354_6;
			Class2354 class2354_4 = class2354_2.class2354_5;
			if (class2354_3 != null || class2354_4 != null || class2354_2 == this.class2354_1)
			{
				if (class2354_3 != null)
				{
					class2354_3.class2354_5 = class2354_4;
				}
				else
				{
					this.class2354_1 = class2354_4;
				}
				if (class2354_4 != null)
				{
					class2354_4.class2354_6 = class2354_3;
				}
				class2354_2.class2354_5 = null;
				class2354_2.class2354_6 = null;
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00062B40 File Offset: 0x00060D40
		private void method_56(ref Class2354 class2354_2)
		{
			if (class2354_2.class2354_2 == null)
			{
				throw new Exception29("UpdateEdgeIntoAEL: invalid call");
			}
			Class2354 class2354_3 = class2354_2.class2354_4;
			Class2354 class2354_4 = class2354_2.class2354_3;
			class2354_2.class2354_2.int_3 = class2354_2.int_3;
			if (class2354_3 != null)
			{
				class2354_3.class2354_3 = class2354_2.class2354_2;
			}
			else
			{
				this.class2354_0 = class2354_2.class2354_2;
			}
			if (class2354_4 != null)
			{
				class2354_4.class2354_4 = class2354_2.class2354_2;
			}
			class2354_2.class2354_2.enum167_0 = class2354_2.enum167_0;
			class2354_2.class2354_2.int_0 = class2354_2.int_0;
			class2354_2.class2354_2.int_1 = class2354_2.int_1;
			class2354_2.class2354_2.int_2 = class2354_2.int_2;
			class2354_2 = class2354_2.class2354_2;
			class2354_2.intPoint_1 = class2354_2.intPoint_0;
			class2354_2.class2354_4 = class2354_3;
			class2354_2.class2354_3 = class2354_4;
			if (!Class2362.smethod_1(class2354_2))
			{
				this.method_19(class2354_2.intPoint_2.long_1);
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00062C50 File Offset: 0x00060E50
		private void method_57(bool bool_7)
		{
			for (Class2354 @class = this.class2354_1; @class != null; @class = this.class2354_1)
			{
				this.method_55(@class);
				this.method_60(@class, bool_7);
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00062C88 File Offset: 0x00060E88
		private void method_58(Class2354 HorzEdge, out Enum168 Dir, out long Left, out long Right)
		{
			if (HorzEdge.intPoint_0.long_0 < HorzEdge.intPoint_2.long_0)
			{
				Left = HorzEdge.intPoint_0.long_0;
				Right = HorzEdge.intPoint_2.long_0;
				Dir = Enum168.const_1;
			}
			else
			{
				Left = HorzEdge.intPoint_2.long_0;
				Right = HorzEdge.intPoint_0.long_0;
				Dir = Enum168.const_0;
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00062CF0 File Offset: 0x00060EF0
		private void method_59(Class2354 class2354_2, bool bool_7)
		{
			Class2360 @class = this.list_1[class2354_2.int_3].class2360_0;
			if (class2354_2.enum167_0 != Enum167.const_0)
			{
				@class = @class.class2360_1;
			}
			if (bool_7)
			{
				if (IntPoint.smethod_0(@class.intPoint_0, class2354_2.intPoint_2))
				{
					this.method_27(@class, class2354_2.intPoint_0);
				}
				else
				{
					this.method_27(@class, class2354_2.intPoint_2);
				}
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00062D60 File Offset: 0x00060F60
		private void method_60(Class2354 class2354_2, bool bool_7)
		{
			Enum168 @enum;
			long num;
			long num2;
			this.method_58(class2354_2, out @enum, out num, out num2);
			Class2354 @class = class2354_2;
			Class2354 class2 = null;
			while (@class.class2354_2 != null && Class2362.smethod_1(@class.class2354_2))
			{
				@class = @class.class2354_2;
			}
			if (@class.class2354_2 == null)
			{
				class2 = this.method_64(@class);
			}
			Class2354 class3;
			while (true)
			{
				bool flag = class2354_2 == @class;
				class3 = this.method_61(class2354_2, @enum);
				while (class3 != null && (class3.intPoint_1.long_0 != class2354_2.intPoint_2.long_0 || class2354_2.class2354_2 == null || class3.double_0 >= class2354_2.class2354_2.double_0))
				{
					Class2354 class4 = this.method_61(class3, @enum);
					if ((@enum == Enum168.const_1 && class3.intPoint_1.long_0 <= num2) || (@enum == Enum168.const_0 && class3.intPoint_1.long_0 >= num))
					{
						if (class2354_2.int_3 >= 0 && class2354_2.int_0 != 0)
						{
							this.method_59(class2354_2, bool_7);
						}
						if (class3 == class2 & flag)
						{
							goto IL_22D;
						}
						if (@enum == Enum168.const_1)
						{
							IntPoint pt = new IntPoint(class3.intPoint_1.long_0, class2354_2.intPoint_1.long_1);
							this.method_53(class2354_2, class3, pt, true);
						}
						else
						{
							IntPoint pt2 = new IntPoint(class3.intPoint_1.long_0, class2354_2.intPoint_1.long_1);
							this.method_53(class3, class2354_2, pt2, true);
						}
						this.method_37(class2354_2, class3);
					}
					else if ((@enum == Enum168.const_1 && class3.intPoint_1.long_0 >= num2) || (@enum == Enum168.const_0 && class3.intPoint_1.long_0 <= num))
					{
						break;
					}
					class3 = class4;
				}
				if (class2354_2.int_3 >= 0 && class2354_2.int_0 != 0)
				{
					this.method_59(class2354_2, bool_7);
				}
				if (class2354_2.class2354_2 == null || !Class2362.smethod_1(class2354_2.class2354_2))
				{
					goto IL_274;
				}
				this.method_56(ref class2354_2);
				if (class2354_2.int_3 >= 0)
				{
					this.method_42(class2354_2, class2354_2.intPoint_0);
				}
				this.method_58(class2354_2, out @enum, out num, out num2);
			}
			IL_22D:
			if (@enum == Enum168.const_1)
			{
				this.method_53(class2354_2, class3, class3.intPoint_2, false);
			}
			else
			{
				this.method_53(class3, class2354_2, class3.intPoint_2, false);
			}
			if (class2.int_3 >= 0)
			{
				throw new Exception29("ProcessHorizontal error");
			}
			return;
			IL_274:
			if (class2354_2.class2354_2 != null)
			{
				if (class2354_2.int_3 < 0)
				{
					this.method_56(ref class2354_2);
				}
				else
				{
					Class2360 class2360_ = this.method_42(class2354_2, class2354_2.intPoint_2);
					this.method_56(ref class2354_2);
					if (class2354_2.int_0 != 0)
					{
						Class2354 class2354_3 = class2354_2.class2354_4;
						Class2354 class2354_4 = class2354_2.class2354_3;
						if (class2354_3 != null && class2354_3.intPoint_1.long_0 == class2354_2.intPoint_0.long_0 && class2354_3.intPoint_1.long_1 == class2354_2.intPoint_0.long_1 && class2354_3.int_0 != 0 && class2354_3.int_3 >= 0 && class2354_3.intPoint_1.long_1 > class2354_3.intPoint_2.long_1 && Class2362.smethod_2(class2354_2, class2354_3, this.bool_0))
						{
							Class2360 class2360_2 = this.method_42(class2354_3, class2354_2.intPoint_0);
							this.method_26(class2360_, class2360_2, class2354_2.intPoint_2);
						}
						else if (class2354_4 != null && class2354_4.intPoint_1.long_0 == class2354_2.intPoint_0.long_0 && class2354_4.intPoint_1.long_1 == class2354_2.intPoint_0.long_1 && class2354_4.int_0 != 0 && class2354_4.int_3 >= 0 && class2354_4.intPoint_1.long_1 > class2354_4.intPoint_2.long_1 && Class2362.smethod_2(class2354_2, class2354_4, this.bool_0))
						{
							Class2360 class2360_3 = this.method_42(class2354_4, class2354_2.intPoint_0);
							this.method_26(class2360_, class2360_3, class2354_2.intPoint_2);
						}
					}
				}
			}
			else if (class2 != null)
			{
				if (class2.int_3 < 0)
				{
					this.method_54(class2354_2);
					this.method_54(class2);
				}
				else
				{
					if (@enum == Enum168.const_1)
					{
						this.method_53(class2354_2, class2, class2354_2.intPoint_2, false);
					}
					else
					{
						this.method_53(class2, class2354_2, class2354_2.intPoint_2, false);
					}
					if (class2.int_3 >= 0)
					{
						throw new Exception29("ProcessHorizontal error");
					}
				}
			}
			else
			{
				if (class2354_2.int_3 >= 0)
				{
					this.method_42(class2354_2, class2354_2.intPoint_2);
				}
				this.method_54(class2354_2);
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0006320C File Offset: 0x0006140C
		private Class2354 method_61(Class2354 class2354_2, Enum168 enum168_0)
		{
			Class2354 result;
			if (enum168_0 != Enum168.const_1)
			{
				result = class2354_2.class2354_4;
			}
			else
			{
				result = class2354_2.class2354_3;
			}
			return result;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000069FE File Offset: 0x00004BFE
		private bool method_62(Class2354 class2354_2, double double_0)
		{
			return class2354_2 != null && (double)class2354_2.intPoint_2.long_1 == double_0 && class2354_2.class2354_2 == null;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00006A1E File Offset: 0x00004C1E
		private bool method_63(Class2354 class2354_2, double double_0)
		{
			return (double)class2354_2.intPoint_2.long_1 == double_0 && class2354_2.class2354_2 != null;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00063230 File Offset: 0x00061430
		private Class2354 method_64(Class2354 class2354_2)
		{
			Class2354 @class = null;
			if (IntPoint.smethod_0(class2354_2.class2354_0.intPoint_2, class2354_2.intPoint_2) && class2354_2.class2354_0.class2354_2 == null)
			{
				@class = class2354_2.class2354_0;
			}
			else if (IntPoint.smethod_0(class2354_2.class2354_1.intPoint_2, class2354_2.intPoint_2) && class2354_2.class2354_1.class2354_2 == null)
			{
				@class = class2354_2.class2354_1;
			}
			Class2354 result;
			if (@class != null && (@class.int_3 == -2 || (@class.class2354_3 == @class.class2354_4 && !Class2362.smethod_1(@class))))
			{
				result = null;
			}
			else
			{
				result = @class;
			}
			return result;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000632E0 File Offset: 0x000614E0
		private bool method_65(long long_0, long long_1)
		{
			bool result;
			if (this.class2354_0 == null)
			{
				result = true;
			}
			else
			{
				try
				{
					this.method_66(long_0, long_1);
					if (this.list_2.Count == 0)
					{
						result = true;
						return result;
					}
					if (this.list_2.Count != 1 && !this.method_68())
					{
						result = false;
						return result;
					}
					this.method_69();
				}
				catch
				{
					this.class2354_1 = null;
					this.list_2.Clear();
					throw new Exception29("ProcessIntersections error");
				}
				this.class2354_1 = null;
				result = true;
			}
			return result;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0006337C File Offset: 0x0006157C
		private void method_66(long long_0, long long_1)
		{
			if (this.class2354_0 != null)
			{
				Class2354 @class = this.class2354_0;
				this.class2354_1 = @class;
				while (@class != null)
				{
					@class.class2354_6 = @class.class2354_4;
					@class.class2354_5 = @class.class2354_3;
					@class.intPoint_1.long_0 = Class2363.smethod_8(@class, long_1);
					@class = @class.class2354_3;
				}
				bool flag = true;
				while (flag && this.class2354_1 != null)
				{
					flag = false;
					@class = this.class2354_1;
					while (@class.class2354_5 != null)
					{
						Class2354 class2354_ = @class.class2354_5;
						if (@class.intPoint_1.long_0 > class2354_.intPoint_1.long_0)
						{
							IntPoint intPoint_;
							if (!this.method_70(@class, class2354_, out intPoint_) && @class.intPoint_1.long_0 > class2354_.intPoint_1.long_0 + 1L)
							{
								throw new Exception29("Intersection error");
							}
							if (intPoint_.long_1 > long_0)
							{
								intPoint_.long_1 = long_0;
								if (Math.Abs(@class.double_0) > Math.Abs(class2354_.double_0))
								{
									intPoint_.long_0 = Class2363.smethod_8(class2354_, long_0);
								}
								else
								{
									intPoint_.long_0 = Class2363.smethod_8(@class, long_0);
								}
							}
							Class2355 class2 = new Class2355();
							class2.class2354_0 = @class;
							class2.class2354_1 = class2354_;
							class2.intPoint_0 = intPoint_;
							this.list_2.Add(class2);
							this.method_38(@class, class2354_);
							flag = true;
						}
						else
						{
							@class = class2354_;
						}
					}
					if (@class.class2354_6 == null)
					{
						break;
					}
					@class.class2354_6.class2354_5 = null;
				}
				this.class2354_1 = null;
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00006A3E File Offset: 0x00004C3E
		private bool method_67(Class2355 class2355_0)
		{
			return class2355_0.class2354_0.class2354_5 == class2355_0.class2354_1 || class2355_0.class2354_0.class2354_6 == class2355_0.class2354_1;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00063548 File Offset: 0x00061748
		private bool method_68()
		{
			this.list_2.Sort(this.icomparer_0);
			this.method_36();
			int count = this.list_2.Count;
			bool result;
			for (int i = 0; i < count; i++)
			{
				if (!this.method_67(this.list_2[i]))
				{
					int num = i + 1;
					while (num < count && !this.method_67(this.list_2[num]))
					{
						num++;
					}
					if (num == count)
					{
						result = false;
						return result;
					}
					Class2355 value = this.list_2[i];
					this.list_2[i] = this.list_2[num];
					this.list_2[num] = value;
				}
				this.method_38(this.list_2[i].class2354_0, this.list_2[i].class2354_1);
			}
			result = true;
			return result;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00063638 File Offset: 0x00061838
		private void method_69()
		{
			for (int i = 0; i < this.list_2.Count; i++)
			{
				Class2355 @class = this.list_2[i];
				this.method_53(@class.class2354_0, @class.class2354_1, @class.intPoint_0, true);
				this.method_37(@class.class2354_0, @class.class2354_1);
			}
			this.list_2.Clear();
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000636A0 File Offset: 0x000618A0
		internal static long smethod_7(double double_0)
		{
			long result;
			if (double_0 >= 0.0)
			{
				result = (long)(double_0 + 0.5);
			}
			else
			{
				result = (long)(double_0 - 0.5);
			}
			return result;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x000636D8 File Offset: 0x000618D8
		private static long smethod_8(Class2354 class2354_2, long long_0)
		{
			long result;
			if (long_0 == class2354_2.intPoint_2.long_1)
			{
				result = class2354_2.intPoint_2.long_0;
			}
			else
			{
				result = class2354_2.intPoint_0.long_0 + Class2363.smethod_7(class2354_2.double_0 * (double)(long_0 - class2354_2.intPoint_0.long_1));
			}
			return result;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00063730 File Offset: 0x00061930
		private bool method_70(Class2354 edge1, Class2354 edge2, out IntPoint ip)
		{
			ip = default(IntPoint);
			bool result;
			if (!Class2362.smethod_2(edge1, edge2, this.bool_0) && edge1.double_0 != edge2.double_0)
			{
				if (edge1.intPoint_3.long_0 == 0L)
				{
					ip.long_0 = edge1.intPoint_0.long_0;
					if (Class2362.smethod_1(edge2))
					{
						ip.long_1 = edge2.intPoint_0.long_1;
					}
					else
					{
						double num = (double)edge2.intPoint_0.long_1 - (double)edge2.intPoint_0.long_0 / edge2.double_0;
						ip.long_1 = Class2363.smethod_7((double)ip.long_0 / edge2.double_0 + num);
					}
				}
				else if (edge2.intPoint_3.long_0 == 0L)
				{
					ip.long_0 = edge2.intPoint_0.long_0;
					if (Class2362.smethod_1(edge1))
					{
						ip.long_1 = edge1.intPoint_0.long_1;
					}
					else
					{
						double num2 = (double)edge1.intPoint_0.long_1 - (double)edge1.intPoint_0.long_0 / edge1.double_0;
						ip.long_1 = Class2363.smethod_7((double)ip.long_0 / edge1.double_0 + num2);
					}
				}
				else
				{
					double num2 = (double)edge1.intPoint_0.long_0 - (double)edge1.intPoint_0.long_1 * edge1.double_0;
					double num = (double)edge2.intPoint_0.long_0 - (double)edge2.intPoint_0.long_1 * edge2.double_0;
					double num3 = (num - num2) / (edge1.double_0 - edge2.double_0);
					ip.long_1 = Class2363.smethod_7(num3);
					if (Math.Abs(edge1.double_0) < Math.Abs(edge2.double_0))
					{
						ip.long_0 = Class2363.smethod_7(edge1.double_0 * num3 + num2);
					}
					else
					{
						ip.long_0 = Class2363.smethod_7(edge2.double_0 * num3 + num);
					}
				}
				if (ip.long_1 < edge1.intPoint_2.long_1 || ip.long_1 < edge2.intPoint_2.long_1)
				{
					if (edge1.intPoint_2.long_1 > edge2.intPoint_2.long_1)
					{
						ip.long_1 = edge1.intPoint_2.long_1;
					}
					else
					{
						ip.long_1 = edge2.intPoint_2.long_1;
					}
					if (Math.Abs(edge1.double_0) < Math.Abs(edge2.double_0))
					{
						ip.long_0 = Class2363.smethod_8(edge1, ip.long_1);
					}
					else
					{
						ip.long_0 = Class2363.smethod_8(edge2, ip.long_1);
					}
				}
				result = true;
			}
			else
			{
				if (edge2.intPoint_0.long_1 > edge1.intPoint_0.long_1)
				{
					ip = edge2.intPoint_0;
				}
				else
				{
					ip = edge1.intPoint_0;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00063A24 File Offset: 0x00061C24
		private void method_71(long long_0)
		{
			Class2354 class2354_ = this.class2354_0;
			while (class2354_ != null)
			{
				bool flag;
				if (flag = this.method_62(class2354_, (double)long_0))
				{
					Class2354 @class = this.method_64(class2354_);
					flag = (@class == null || !Class2362.smethod_1(@class));
				}
				if (flag)
				{
					Class2354 class2354_2 = class2354_.class2354_4;
					this.method_72(class2354_);
					if (class2354_2 == null)
					{
						class2354_ = this.class2354_0;
					}
					else
					{
						class2354_ = class2354_2.class2354_3;
					}
				}
				else
				{
					if (this.method_63(class2354_, (double)long_0) && Class2362.smethod_1(class2354_.class2354_2))
					{
						this.method_56(ref class2354_);
						if (class2354_.int_3 >= 0)
						{
							this.method_42(class2354_, class2354_.intPoint_0);
						}
						this.method_35(class2354_);
					}
					else
					{
						class2354_.intPoint_1.long_0 = Class2363.smethod_8(class2354_, long_0);
						class2354_.intPoint_1.long_1 = long_0;
					}
					if (this.method_17())
					{
						Class2354 class2354_3 = class2354_.class2354_4;
						if (class2354_.int_3 >= 0 && class2354_.int_0 != 0 && class2354_3 != null && class2354_3.int_3 >= 0 && class2354_3.intPoint_1.long_0 == class2354_.intPoint_1.long_0 && class2354_3.int_0 != 0)
						{
							Class2360 class2360_ = this.method_42(class2354_3, class2354_.intPoint_1);
							Class2360 class2360_2 = this.method_42(class2354_, class2354_.intPoint_1);
							this.method_26(class2360_, class2360_2, class2354_.intPoint_1);
						}
					}
					class2354_ = class2354_.class2354_3;
				}
			}
			this.method_57(true);
			for (class2354_ = this.class2354_0; class2354_ != null; class2354_ = class2354_.class2354_3)
			{
				if (this.method_63(class2354_, (double)long_0))
				{
					Class2360 class2 = null;
					if (class2354_.int_3 >= 0)
					{
						class2 = this.method_42(class2354_, class2354_.intPoint_2);
					}
					this.method_56(ref class2354_);
					Class2354 class2354_4 = class2354_.class2354_4;
					Class2354 class2354_5 = class2354_.class2354_3;
					if (class2354_4 != null && class2354_4.intPoint_1.long_0 == class2354_.intPoint_0.long_0 && class2354_4.intPoint_1.long_1 == class2354_.intPoint_0.long_1 && class2 != null && class2354_4.int_3 >= 0 && class2354_4.intPoint_1.long_1 > class2354_4.intPoint_2.long_1 && Class2362.smethod_2(class2354_, class2354_4, this.bool_0) && class2354_.int_0 != 0 && class2354_4.int_0 != 0)
					{
						Class2360 class2360_3 = this.method_42(class2354_4, class2354_.intPoint_0);
						this.method_26(class2, class2360_3, class2354_.intPoint_2);
					}
					else if (class2354_5 != null && class2354_5.intPoint_1.long_0 == class2354_.intPoint_0.long_0 && class2354_5.intPoint_1.long_1 == class2354_.intPoint_0.long_1 && class2 != null && class2354_5.int_3 >= 0 && class2354_5.intPoint_1.long_1 > class2354_5.intPoint_2.long_1 && Class2362.smethod_2(class2354_, class2354_5, this.bool_0) && class2354_.int_0 != 0 && class2354_5.int_0 != 0)
					{
						Class2360 class2360_4 = this.method_42(class2354_5, class2354_.intPoint_0);
						this.method_26(class2, class2360_4, class2354_.intPoint_2);
					}
				}
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00063D5C File Offset: 0x00061F5C
		private void method_72(Class2354 class2354_2)
		{
			Class2354 @class = this.method_64(class2354_2);
			if (@class == null)
			{
				if (class2354_2.int_3 >= 0)
				{
					this.method_42(class2354_2, class2354_2.intPoint_2);
				}
				this.method_54(class2354_2);
			}
			else
			{
				Class2354 class2354_3 = class2354_2.class2354_3;
				while (class2354_3 != null && class2354_3 != @class)
				{
					this.method_53(class2354_2, class2354_3, class2354_2.intPoint_2, true);
					this.method_37(class2354_2, class2354_3);
					class2354_3 = class2354_2.class2354_3;
				}
				if (class2354_2.int_3 == -1 && @class.int_3 == -1)
				{
					this.method_54(class2354_2);
					this.method_54(@class);
				}
				else
				{
					if (class2354_2.int_3 < 0 || @class.int_3 < 0)
					{
						throw new Exception29("DoMaxima error");
					}
					this.method_53(class2354_2, @class, class2354_2.intPoint_2, false);
				}
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00006A69 File Offset: 0x00004C69
		public static bool smethod_9(List<IntPoint> list_5)
		{
			return Class2363.smethod_11(list_5) >= 0.0;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00063E38 File Offset: 0x00062038
		private int method_73(Class2360 class2360_0)
		{
			int result;
			if (class2360_0 == null)
			{
				result = 0;
			}
			else
			{
				int num = 0;
				Class2360 @class = class2360_0;
				do
				{
					num++;
					@class = @class.class2360_0;
				}
				while (@class != class2360_0);
				result = num;
			}
			return result;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00063E70 File Offset: 0x00062070
		private void method_74(List<List<IntPoint>> list_5)
		{
			list_5.Clear();
			list_5.Capacity = this.list_1.Count;
			for (int i = 0; i < this.list_1.Count; i++)
			{
				Class2359 @class = this.list_1[i];
				if (@class.class2360_0 != null)
				{
					Class2360 class2360_ = @class.class2360_0.class2360_1;
					int num = this.method_73(class2360_);
					if (num >= 2)
					{
						List<IntPoint> list = new List<IntPoint>(num);
						for (int j = 0; j < num; j++)
						{
							list.Add(class2360_.intPoint_0);
							class2360_ = class2360_.class2360_1;
						}
						list_5.Add(list);
					}
				}
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00063F14 File Offset: 0x00062114
		private void method_75(Class2359 class2359_0)
		{
			Class2360 @class = null;
			class2359_0.class2360_1 = null;
			Class2360 class2 = class2359_0.class2360_0;
			while (class2.class2360_1 != class2 && class2.class2360_1 != class2.class2360_0)
			{
				if (!IntPoint.smethod_0(class2.intPoint_0, class2.class2360_0.intPoint_0) && !IntPoint.smethod_0(class2.intPoint_0, class2.class2360_1.intPoint_0) && (!Class2362.smethod_3(class2.class2360_1.intPoint_0, class2.intPoint_0, class2.class2360_0.intPoint_0, this.bool_0) || (base.method_0() && base.method_9(class2.class2360_1.intPoint_0, class2.intPoint_0, class2.class2360_0.intPoint_0))))
				{
					if (class2 == @class)
					{
						class2359_0.class2360_0 = class2;
						return;
					}
					if (@class == null)
					{
						@class = class2;
					}
					class2 = class2.class2360_0;
				}
				else
				{
					@class = null;
					class2.class2360_1.class2360_0 = class2.class2360_0;
					class2.class2360_0.class2360_1 = class2.class2360_1;
					class2 = class2.class2360_1;
				}
			}
			this.method_25(class2);
			class2359_0.class2360_0 = null;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00064050 File Offset: 0x00062250
		private Class2360 method_76(Class2360 class2360_0, bool bool_7)
		{
			Class2360 @class = new Class2360();
			@class.intPoint_0 = class2360_0.intPoint_0;
			@class.int_0 = class2360_0.int_0;
			if (bool_7)
			{
				@class.class2360_0 = class2360_0.class2360_0;
				@class.class2360_1 = class2360_0;
				class2360_0.class2360_0.class2360_1 = @class;
				class2360_0.class2360_0 = @class;
			}
			else
			{
				@class.class2360_1 = class2360_0.class2360_1;
				@class.class2360_0 = class2360_0;
				class2360_0.class2360_1.class2360_0 = @class;
				class2360_0.class2360_1 = @class;
			}
			return @class;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000640D4 File Offset: 0x000622D4
		private bool method_77(long a1, long a2, long b1, long b2, out long Left, out long Right)
		{
			if (a1 < a2)
			{
				if (b1 < b2)
				{
					Left = Math.Max(a1, b1);
					Right = Math.Min(a2, b2);
				}
				else
				{
					Left = Math.Max(a1, b2);
					Right = Math.Min(a2, b1);
				}
			}
			else if (b1 < b2)
			{
				Left = Math.Max(a2, b1);
				Right = Math.Min(a1, b2);
			}
			else
			{
				Left = Math.Max(a2, b2);
				Right = Math.Min(a1, b1);
			}
			return Left < Right;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00064160 File Offset: 0x00062360
		private bool method_78(Class2360 class2360_0, Class2360 class2360_1, Class2360 class2360_2, Class2360 class2360_3, IntPoint intPoint_0, bool bool_7)
		{
			Enum168 @enum = (class2360_0.intPoint_0.long_0 > class2360_1.intPoint_0.long_0) ? Enum168.const_0 : Enum168.const_1;
			Enum168 enum2 = (class2360_2.intPoint_0.long_0 > class2360_3.intPoint_0.long_0) ? Enum168.const_0 : Enum168.const_1;
			bool result;
			if (@enum == enum2)
			{
				result = false;
			}
			else
			{
				if (@enum == Enum168.const_1)
				{
					while (class2360_0.class2360_0.intPoint_0.long_0 <= intPoint_0.long_0 && class2360_0.class2360_0.intPoint_0.long_0 >= class2360_0.intPoint_0.long_0 && class2360_0.class2360_0.intPoint_0.long_1 == intPoint_0.long_1)
					{
						class2360_0 = class2360_0.class2360_0;
					}
					if (bool_7 && class2360_0.intPoint_0.long_0 != intPoint_0.long_0)
					{
						class2360_0 = class2360_0.class2360_0;
					}
					class2360_1 = this.method_76(class2360_0, !bool_7);
					if (IntPoint.smethod_1(class2360_1.intPoint_0, intPoint_0))
					{
						class2360_0 = class2360_1;
						class2360_0.intPoint_0 = intPoint_0;
						class2360_1 = this.method_76(class2360_0, !bool_7);
					}
				}
				else
				{
					while (class2360_0.class2360_0.intPoint_0.long_0 >= intPoint_0.long_0 && class2360_0.class2360_0.intPoint_0.long_0 <= class2360_0.intPoint_0.long_0 && class2360_0.class2360_0.intPoint_0.long_1 == intPoint_0.long_1)
					{
						class2360_0 = class2360_0.class2360_0;
					}
					if (!bool_7 && class2360_0.intPoint_0.long_0 != intPoint_0.long_0)
					{
						class2360_0 = class2360_0.class2360_0;
					}
					class2360_1 = this.method_76(class2360_0, bool_7);
					if (IntPoint.smethod_1(class2360_1.intPoint_0, intPoint_0))
					{
						class2360_0 = class2360_1;
						class2360_0.intPoint_0 = intPoint_0;
						class2360_1 = this.method_76(class2360_0, bool_7);
					}
				}
				if (enum2 == Enum168.const_1)
				{
					while (class2360_2.class2360_0.intPoint_0.long_0 <= intPoint_0.long_0 && class2360_2.class2360_0.intPoint_0.long_0 >= class2360_2.intPoint_0.long_0 && class2360_2.class2360_0.intPoint_0.long_1 == intPoint_0.long_1)
					{
						class2360_2 = class2360_2.class2360_0;
					}
					if (bool_7 && class2360_2.intPoint_0.long_0 != intPoint_0.long_0)
					{
						class2360_2 = class2360_2.class2360_0;
					}
					class2360_3 = this.method_76(class2360_2, !bool_7);
					if (IntPoint.smethod_1(class2360_3.intPoint_0, intPoint_0))
					{
						class2360_2 = class2360_3;
						class2360_2.intPoint_0 = intPoint_0;
						class2360_3 = this.method_76(class2360_2, !bool_7);
					}
				}
				else
				{
					while (class2360_2.class2360_0.intPoint_0.long_0 >= intPoint_0.long_0 && class2360_2.class2360_0.intPoint_0.long_0 <= class2360_2.intPoint_0.long_0 && class2360_2.class2360_0.intPoint_0.long_1 == intPoint_0.long_1)
					{
						class2360_2 = class2360_2.class2360_0;
					}
					if (!bool_7 && class2360_2.intPoint_0.long_0 != intPoint_0.long_0)
					{
						class2360_2 = class2360_2.class2360_0;
					}
					class2360_3 = this.method_76(class2360_2, bool_7);
					if (IntPoint.smethod_1(class2360_3.intPoint_0, intPoint_0))
					{
						class2360_2 = class2360_3;
						class2360_2.intPoint_0 = intPoint_0;
						class2360_3 = this.method_76(class2360_2, bool_7);
					}
				}
				if (@enum == Enum168.const_1 == bool_7)
				{
					class2360_0.class2360_1 = class2360_2;
					class2360_2.class2360_0 = class2360_0;
					class2360_1.class2360_0 = class2360_3;
					class2360_3.class2360_1 = class2360_1;
				}
				else
				{
					class2360_0.class2360_0 = class2360_2;
					class2360_2.class2360_1 = class2360_0;
					class2360_1.class2360_1 = class2360_3;
					class2360_3.class2360_0 = class2360_1;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00064538 File Offset: 0x00062738
		private bool method_79(Class2361 class2361_0, Class2359 class2359_0, Class2359 class2359_1)
		{
			Class2360 @class = class2361_0.class2360_0;
			Class2360 class2360_ = class2361_0.class2360_1;
			bool flag;
			bool result;
			if ((flag = (class2361_0.class2360_0.intPoint_0.long_1 == class2361_0.intPoint_0.long_1)) && IntPoint.smethod_0(class2361_0.intPoint_0, class2361_0.class2360_0.intPoint_0) && IntPoint.smethod_0(class2361_0.intPoint_0, class2361_0.class2360_1.intPoint_0))
			{
				Class2360 class2 = class2361_0.class2360_0.class2360_0;
				while (class2 != @class && IntPoint.smethod_0(class2.intPoint_0, class2361_0.intPoint_0))
				{
					class2 = class2.class2360_0;
				}
				bool flag2 = class2.intPoint_0.long_1 > class2361_0.intPoint_0.long_1;
				Class2360 class3 = class2361_0.class2360_1.class2360_0;
				while (class3 != class2360_ && IntPoint.smethod_0(class3.intPoint_0, class2361_0.intPoint_0))
				{
					class3 = class3.class2360_0;
				}
				bool flag3 = class3.intPoint_0.long_1 > class2361_0.intPoint_0.long_1;
				if (flag2 == flag3)
				{
					result = false;
				}
				else if (flag2)
				{
					class2 = this.method_76(@class, false);
					class3 = this.method_76(class2360_, true);
					@class.class2360_1 = class2360_;
					class2360_.class2360_0 = @class;
					class2.class2360_0 = class3;
					class3.class2360_1 = class2;
					class2361_0.class2360_0 = @class;
					class2361_0.class2360_1 = class2;
					result = true;
				}
				else
				{
					class2 = this.method_76(@class, true);
					class3 = this.method_76(class2360_, false);
					@class.class2360_0 = class2360_;
					class2360_.class2360_1 = @class;
					class2.class2360_1 = class3;
					class3.class2360_0 = class2;
					class2361_0.class2360_0 = @class;
					class2361_0.class2360_1 = class2;
					result = true;
				}
			}
			else if (flag)
			{
				Class2360 class2 = @class;
				while (@class.class2360_1.intPoint_0.long_1 == @class.intPoint_0.long_1 && @class.class2360_1 != class2 && @class.class2360_1 != class2360_)
				{
					@class = @class.class2360_1;
				}
				while (class2.class2360_0.intPoint_0.long_1 == class2.intPoint_0.long_1 && class2.class2360_0 != @class && class2.class2360_0 != class2360_)
				{
					class2 = class2.class2360_0;
				}
				if (class2.class2360_0 != @class && class2.class2360_0 != class2360_)
				{
					Class2360 class3 = class2360_;
					while (class2360_.class2360_1.intPoint_0.long_1 == class2360_.intPoint_0.long_1 && class2360_.class2360_1 != class3 && class2360_.class2360_1 != class2)
					{
						class2360_ = class2360_.class2360_1;
					}
					while (class3.class2360_0.intPoint_0.long_1 == class3.intPoint_0.long_1 && class3.class2360_0 != class2360_ && class3.class2360_0 != @class)
					{
						class3 = class3.class2360_0;
					}
					if (class3.class2360_0 != class2360_ && class3.class2360_0 != @class)
					{
						long num;
						long num2;
						if (!this.method_77(@class.intPoint_0.long_0, class2.intPoint_0.long_0, class2360_.intPoint_0.long_0, class3.intPoint_0.long_0, out num, out num2))
						{
							result = false;
						}
						else
						{
							IntPoint intPoint_;
							bool bool_;
							if (@class.intPoint_0.long_0 >= num && @class.intPoint_0.long_0 <= num2)
							{
								intPoint_ = @class.intPoint_0;
								bool_ = (@class.intPoint_0.long_0 > class2.intPoint_0.long_0);
							}
							else if (class2360_.intPoint_0.long_0 >= num && class2360_.intPoint_0.long_0 <= num2)
							{
								intPoint_ = class2360_.intPoint_0;
								bool_ = (class2360_.intPoint_0.long_0 > class3.intPoint_0.long_0);
							}
							else if (class2.intPoint_0.long_0 >= num && class2.intPoint_0.long_0 <= num2)
							{
								intPoint_ = class2.intPoint_0;
								bool_ = (class2.intPoint_0.long_0 > @class.intPoint_0.long_0);
							}
							else
							{
								intPoint_ = class3.intPoint_0;
								bool_ = (class3.intPoint_0.long_0 > class2360_.intPoint_0.long_0);
							}
							class2361_0.class2360_0 = @class;
							class2361_0.class2360_1 = class2360_;
							result = this.method_78(@class, class2, class2360_, class3, intPoint_, bool_);
						}
					}
					else
					{
						result = false;
					}
				}
				else
				{
					result = false;
				}
			}
			else
			{
				Class2360 class2 = @class.class2360_0;
				while (IntPoint.smethod_0(class2.intPoint_0, @class.intPoint_0) && class2 != @class)
				{
					class2 = class2.class2360_0;
				}
				bool flag4;
				if (flag4 = (class2.intPoint_0.long_1 > @class.intPoint_0.long_1 || !Class2362.smethod_3(@class.intPoint_0, class2.intPoint_0, class2361_0.intPoint_0, this.bool_0)))
				{
					class2 = @class.class2360_1;
					while (IntPoint.smethod_0(class2.intPoint_0, @class.intPoint_0) && class2 != @class)
					{
						class2 = class2.class2360_1;
					}
					if (class2.intPoint_0.long_1 > @class.intPoint_0.long_1 || !Class2362.smethod_3(@class.intPoint_0, class2.intPoint_0, class2361_0.intPoint_0, this.bool_0))
					{
						result = false;
						return result;
					}
				}
				Class2360 class3 = class2360_.class2360_0;
				while (IntPoint.smethod_0(class3.intPoint_0, class2360_.intPoint_0) && class3 != class2360_)
				{
					class3 = class3.class2360_0;
				}
				bool flag5;
				if (flag5 = (class3.intPoint_0.long_1 > class2360_.intPoint_0.long_1 || !Class2362.smethod_3(class2360_.intPoint_0, class3.intPoint_0, class2361_0.intPoint_0, this.bool_0)))
				{
					class3 = class2360_.class2360_1;
					while (IntPoint.smethod_0(class3.intPoint_0, class2360_.intPoint_0) && class3 != class2360_)
					{
						class3 = class3.class2360_1;
					}
					if (class3.intPoint_0.long_1 > class2360_.intPoint_0.long_1 || !Class2362.smethod_3(class2360_.intPoint_0, class3.intPoint_0, class2361_0.intPoint_0, this.bool_0))
					{
						result = false;
						return result;
					}
				}
				if (class2 != @class && class3 != class2360_ && class2 != class3 && (class2359_0 != class2359_1 || flag4 != flag5))
				{
					if (flag4)
					{
						class2 = this.method_76(@class, false);
						class3 = this.method_76(class2360_, true);
						@class.class2360_1 = class2360_;
						class2360_.class2360_0 = @class;
						class2.class2360_0 = class3;
						class3.class2360_1 = class2;
						class2361_0.class2360_0 = @class;
						class2361_0.class2360_1 = class2;
						result = true;
					}
					else
					{
						class2 = this.method_76(@class, true);
						class3 = this.method_76(class2360_, false);
						@class.class2360_0 = class2360_;
						class2360_.class2360_1 = @class;
						class2.class2360_1 = class3;
						class3.class2360_0 = class2;
						class2361_0.class2360_0 = @class;
						class2361_0.class2360_1 = class2;
						result = true;
					}
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00064C68 File Offset: 0x00062E68
		private int method_80(IntPoint intPoint_0, Class2360 class2360_0)
		{
			int num = 0;
			Class2360 @class = class2360_0;
			do
			{
				double num2 = (double)class2360_0.intPoint_0.long_0;
				double num3 = (double)class2360_0.intPoint_0.long_1;
				double num4 = (double)class2360_0.class2360_0.intPoint_0.long_0;
				double num5 = (double)class2360_0.class2360_0.intPoint_0.long_1;
				if (num5 == (double)intPoint_0.long_1)
				{
					if (num4 == (double)intPoint_0.long_0)
					{
						goto IL_1DC;
					}
					if (num3 == (double)intPoint_0.long_1 && num4 > (double)intPoint_0.long_0 == num2 < (double)intPoint_0.long_0)
					{
						goto Block_12;
					}
				}
				if (num3 < (double)intPoint_0.long_1 != num5 < (double)intPoint_0.long_1)
				{
					if (num2 >= (double)intPoint_0.long_0)
					{
						if (num4 > (double)intPoint_0.long_0)
						{
							num = 1 - num;
						}
						else
						{
							double num6 = (num2 - (double)intPoint_0.long_0) * (num5 - (double)intPoint_0.long_1) - (num4 - (double)intPoint_0.long_0) * (num3 - (double)intPoint_0.long_1);
							if (num6 == 0.0)
							{
								goto IL_1E4;
							}
							if (num6 > 0.0 == num5 > num3)
							{
								num = 1 - num;
							}
						}
					}
					else if (num4 > (double)intPoint_0.long_0)
					{
						double num7 = (num2 - (double)intPoint_0.long_0) * (num5 - (double)intPoint_0.long_1) - (num4 - (double)intPoint_0.long_0) * (num3 - (double)intPoint_0.long_1);
						if (num7 == 0.0)
						{
							goto IL_1E8;
						}
						if (num7 > 0.0 == num5 > num3)
						{
							num = 1 - num;
						}
					}
				}
				class2360_0 = class2360_0.class2360_0;
			}
			while (@class != class2360_0);
			int result = num;
			return result;
			Block_12:
			result = -1;
			return result;
			IL_1DC:
			result = -1;
			return result;
			IL_1E4:
			result = -1;
			return result;
			IL_1E8:
			result = -1;
			return result;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00064E64 File Offset: 0x00063064
		private bool method_81(Class2360 class2360_0, Class2360 class2360_1)
		{
			Class2360 @class = class2360_0;
			int num;
			while (true)
			{
				num = this.method_80(@class.intPoint_0, class2360_1);
				if (num >= 0)
				{
					break;
				}
				@class = @class.class2360_0;
				if (@class == class2360_0)
				{
					goto IL_34;
				}
			}
			bool result = num != 0;
			return result;
			IL_34:
			result = true;
			return result;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00064EA8 File Offset: 0x000630A8
		private void method_82(Class2359 class2359_0, Class2359 class2359_1)
		{
			for (int i = 0; i < this.list_1.Count; i++)
			{
				Class2359 @class = this.list_1[i];
				if (@class.class2360_0 != null && @class.class2359_0 == class2359_0 && this.method_81(@class.class2360_0, class2359_1.class2360_0))
				{
					@class.class2359_0 = class2359_1;
				}
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00064F0C File Offset: 0x0006310C
		private void method_83(Class2359 class2359_0, Class2359 class2359_1)
		{
			foreach (Class2359 current in this.list_1)
			{
				if (current.class2359_0 == class2359_0)
				{
					current.class2359_0 = class2359_1;
				}
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00064F70 File Offset: 0x00063170
		private static Class2359 smethod_10(Class2359 class2359_0)
		{
			while (class2359_0 != null && class2359_0.class2360_0 == null)
			{
				class2359_0 = class2359_0.class2359_0;
			}
			return class2359_0;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00064FA0 File Offset: 0x000631A0
		private void method_84()
		{
			for (int i = 0; i < this.list_3.Count; i++)
			{
				Class2361 @class = this.list_3[i];
				Class2359 class2 = this.method_50(@class.class2360_0.int_0);
				Class2359 class3 = this.method_50(@class.class2360_1.int_0);
				if (class2.class2360_0 != null && class3.class2360_0 != null)
				{
					Class2359 class4;
					if (class2 == class3)
					{
						class4 = class2;
					}
					else if (this.method_49(class2, class3))
					{
						class4 = class3;
					}
					else if (this.method_49(class3, class2))
					{
						class4 = class2;
					}
					else
					{
						class4 = this.method_48(class2, class3);
					}
					if (this.method_79(@class, class2, class3))
					{
						if (class2 == class3)
						{
							class2.class2360_0 = @class.class2360_0;
							class2.class2360_1 = null;
							class3 = this.method_41();
							class3.class2360_0 = @class.class2360_1;
							this.method_85(class3);
							if (this.bool_4)
							{
								for (int j = 0; j < this.list_1.Count - 1; j++)
								{
									Class2359 class5 = this.list_1[j];
									if (class5.class2360_0 != null && Class2363.smethod_10(class5.class2359_0) == class2 && class5.bool_0 != class2.bool_0 && this.method_81(class5.class2360_0, @class.class2360_1))
									{
										class5.class2359_0 = class3;
									}
								}
							}
							if (this.method_81(class3.class2360_0, class2.class2360_0))
							{
								class3.bool_0 = !class2.bool_0;
								class3.class2359_0 = class2;
								if (this.bool_4)
								{
									this.method_83(class3, class2);
								}
								if ((class3.bool_0 ^ this.method_15()) == this.method_87(class3) > 0.0)
								{
									this.method_52(class3.class2360_0);
								}
							}
							else if (this.method_81(class2.class2360_0, class3.class2360_0))
							{
								class3.bool_0 = class2.bool_0;
								class2.bool_0 = !class3.bool_0;
								class3.class2359_0 = class2.class2359_0;
								class2.class2359_0 = class3;
								if (this.bool_4)
								{
									this.method_83(class2, class3);
								}
								if ((class2.bool_0 ^ this.method_15()) == this.method_87(class2) > 0.0)
								{
									this.method_52(class2.class2360_0);
								}
							}
							else
							{
								class3.bool_0 = class2.bool_0;
								class3.class2359_0 = class2.class2359_0;
								if (this.bool_4)
								{
									this.method_82(class2, class3);
								}
							}
						}
						else
						{
							class3.class2360_0 = null;
							class3.class2360_1 = null;
							class3.int_0 = class2.int_0;
							class2.bool_0 = class4.bool_0;
							if (class4 == class3)
							{
								class2.class2359_0 = class3.class2359_0;
							}
							class3.class2359_0 = class2;
							if (this.bool_4)
							{
								this.method_83(class3, class2);
							}
						}
					}
				}
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000652B0 File Offset: 0x000634B0
		private void method_85(Class2359 class2359_0)
		{
			Class2360 @class = class2359_0.class2360_0;
			do
			{
				@class.int_0 = class2359_0.int_0;
				@class = @class.class2360_1;
			}
			while (@class != class2359_0.class2360_0);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000652E8 File Offset: 0x000634E8
		private void method_86()
		{
			int i = 0;
			while (i < this.list_1.Count)
			{
				Class2359 @class = this.list_1[i++];
				Class2360 class2360_ = @class.class2360_0;
				if (class2360_ != null)
				{
					do
					{
						for (Class2360 class2 = class2360_.class2360_0; class2 != @class.class2360_0; class2 = class2.class2360_0)
						{
							if (IntPoint.smethod_0(class2360_.intPoint_0, class2.intPoint_0) && class2.class2360_0 != class2360_ && class2.class2360_1 != class2360_)
							{
								Class2360 class2360_2 = class2360_.class2360_1;
								Class2360 class2360_3 = class2.class2360_1;
								class2360_.class2360_1 = class2360_3;
								class2360_3.class2360_0 = class2360_;
								class2.class2360_1 = class2360_2;
								class2360_2.class2360_0 = class2;
								@class.class2360_0 = class2360_;
								Class2359 class3 = this.method_41();
								class3.class2360_0 = class2;
								this.method_85(class3);
								if (this.method_81(class3.class2360_0, @class.class2360_0))
								{
									class3.bool_0 = !@class.bool_0;
									class3.class2359_0 = @class;
								}
								else if (this.method_81(@class.class2360_0, class3.class2360_0))
								{
									class3.bool_0 = @class.bool_0;
									@class.bool_0 = !class3.bool_0;
									class3.class2359_0 = @class.class2359_0;
									@class.class2359_0 = class3;
								}
								else
								{
									class3.bool_0 = @class.bool_0;
									class3.class2359_0 = @class.class2359_0;
								}
								class2 = class2360_;
							}
						}
						class2360_ = class2360_.class2360_0;
					}
					while (class2360_ != @class.class2360_0);
				}
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00065484 File Offset: 0x00063684
		public static double smethod_11(List<IntPoint> list_5)
		{
			int count = list_5.Count;
			double result;
			if (count < 3)
			{
				result = 0.0;
			}
			else
			{
				double num = 0.0;
				int i = 0;
				int index = count - 1;
				while (i < count)
				{
					num += ((double)list_5[index].long_0 + (double)list_5[i].long_0) * ((double)list_5[index].long_1 - (double)list_5[i].long_1);
					index = i;
					i++;
				}
				result = -num * 0.5;
			}
			return result;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00065518 File Offset: 0x00063718
		private double method_87(Class2359 class2359_0)
		{
			Class2360 class2360_ = class2359_0.class2360_0;
			double result;
			if (class2360_ == null)
			{
				result = 0.0;
			}
			else
			{
				double num = 0.0;
				do
				{
					num += (double)(class2360_.class2360_1.intPoint_0.long_0 + class2360_.intPoint_0.long_0) * (double)(class2360_.class2360_1.intPoint_0.long_1 - class2360_.intPoint_0.long_1);
					class2360_ = class2360_.class2360_0;
				}
				while (class2360_ != class2359_0.class2360_0);
				result = num * 0.5;
			}
			return result;
		}

		// Token: 0x0400023F RID: 575
		private List<Class2359> list_1;

		// Token: 0x04000240 RID: 576
		private Enum162 enum162_0;

		// Token: 0x04000241 RID: 577
		private Class2358 class2358_0;

		// Token: 0x04000242 RID: 578
		private Class2354 class2354_0;

		// Token: 0x04000243 RID: 579
		private Class2354 class2354_1;

		// Token: 0x04000244 RID: 580
		private List<Class2355> list_2;

		// Token: 0x04000245 RID: 581
		private IComparer<Class2355> icomparer_0;

		// Token: 0x04000246 RID: 582
		private bool bool_3;

		// Token: 0x04000247 RID: 583
		private Enum164 enum164_0;

		// Token: 0x04000248 RID: 584
		private Enum164 enum164_1;

		// Token: 0x04000249 RID: 585
		private List<Class2361> list_3;

		// Token: 0x0400024A RID: 586
		private List<Class2361> list_4;

		// Token: 0x0400024B RID: 587
		private bool bool_4;

		// Token: 0x0400024C RID: 588
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x0400024D RID: 589
		[CompilerGenerated]
		private bool bool_6;
	}
}
