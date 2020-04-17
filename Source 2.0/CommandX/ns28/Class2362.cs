using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ClipperLib;

namespace ns28
{
	// Token: 0x0200006D RID: 109
	public class Class2362
	{
		// Token: 0x0600021A RID: 538 RVA: 0x00005708 File Offset: 0x00003908
		internal static bool smethod_0(double double_0)
		{
			return double_0 > -1E-20 && double_0 < 1E-20;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00005725 File Offset: 0x00003925
		[CompilerGenerated]
		public bool method_0()
		{
			return this.bool_2;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000572D File Offset: 0x0000392D
		[CompilerGenerated]
		public void method_1(bool bool_3)
		{
			this.bool_2 = bool_3;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00005736 File Offset: 0x00003936
		internal static bool smethod_1(Class2354 class2354_0)
		{
			return class2354_0.intPoint_3.long_1 == 0L;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00059F1C File Offset: 0x0005811C
		internal static bool smethod_2(Class2354 class2354_0, Class2354 class2354_1, bool bool_3)
		{
			bool result;
			if (bool_3)
			{
				result = Struct69.smethod_0(Struct69.smethod_2(class2354_0.intPoint_3.long_1, class2354_1.intPoint_3.long_0), Struct69.smethod_2(class2354_0.intPoint_3.long_0, class2354_1.intPoint_3.long_1));
			}
			else
			{
				result = (class2354_0.intPoint_3.long_1 * class2354_1.intPoint_3.long_0 == class2354_0.intPoint_3.long_0 * class2354_1.intPoint_3.long_1);
			}
			return result;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00059FA0 File Offset: 0x000581A0
		protected static bool smethod_3(IntPoint intPoint_0, IntPoint intPoint_1, IntPoint intPoint_2, bool bool_3)
		{
			bool result;
			if (bool_3)
			{
				result = Struct69.smethod_0(Struct69.smethod_2(intPoint_0.long_1 - intPoint_1.long_1, intPoint_1.long_0 - intPoint_2.long_0), Struct69.smethod_2(intPoint_0.long_0 - intPoint_1.long_0, intPoint_1.long_1 - intPoint_2.long_1));
			}
			else
			{
				result = ((intPoint_0.long_1 - intPoint_1.long_1) * (intPoint_1.long_0 - intPoint_2.long_0) - (intPoint_0.long_0 - intPoint_1.long_0) * (intPoint_1.long_1 - intPoint_2.long_1) == 0L);
			}
			return result;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000574E File Offset: 0x0000394E
		internal Class2362()
		{
			this.class2357_0 = null;
			this.class2357_1 = null;
			this.bool_0 = false;
			this.bool_1 = false;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0005A050 File Offset: 0x00058250
		private void method_2(IntPoint intPoint_0, ref bool bool_3)
		{
			if (bool_3)
			{
				if (intPoint_0.long_0 > 4611686018427387903L || intPoint_0.long_1 > 4611686018427387903L || -intPoint_0.long_0 > 4611686018427387903L || -intPoint_0.long_1 > 4611686018427387903L)
				{
					throw new Exception29("Coordinate outside allowed range");
				}
			}
			else if (intPoint_0.long_0 > 1073741823L || intPoint_0.long_1 > 1073741823L || -intPoint_0.long_0 > 1073741823L || -intPoint_0.long_1 > 1073741823L)
			{
				bool_3 = true;
				this.method_2(intPoint_0, ref bool_3);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00005784 File Offset: 0x00003984
		private void method_3(Class2354 class2354_0, Class2354 class2354_1, Class2354 class2354_2, IntPoint intPoint_0)
		{
			class2354_0.class2354_0 = class2354_1;
			class2354_0.class2354_1 = class2354_2;
			class2354_0.intPoint_1 = intPoint_0;
			class2354_0.int_3 = -1;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0005A120 File Offset: 0x00058320
		private void method_4(Class2354 class2354_0, Enum163 enum163_0)
		{
			if (class2354_0.intPoint_1.long_1 >= class2354_0.class2354_0.intPoint_1.long_1)
			{
				class2354_0.intPoint_0 = class2354_0.intPoint_1;
				class2354_0.intPoint_2 = class2354_0.class2354_0.intPoint_1;
			}
			else
			{
				class2354_0.intPoint_2 = class2354_0.intPoint_1;
				class2354_0.intPoint_0 = class2354_0.class2354_0.intPoint_1;
			}
			this.method_11(class2354_0);
			class2354_0.enum163_0 = enum163_0;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0005A198 File Offset: 0x00058398
		private Class2354 method_5(Class2354 class2354_0)
		{
			Class2354 @class;
			while (true)
			{
				if (!IntPoint.smethod_1(class2354_0.intPoint_0, class2354_0.class2354_1.intPoint_0) && !IntPoint.smethod_0(class2354_0.intPoint_1, class2354_0.intPoint_2))
				{
					if (class2354_0.double_0 != -3.4E+38 && class2354_0.class2354_1.double_0 != -3.4E+38)
					{
						break;
					}
					while (class2354_0.class2354_1.double_0 == -3.4E+38)
					{
						class2354_0 = class2354_0.class2354_1;
					}
					@class = class2354_0;
					while (class2354_0.double_0 == -3.4E+38)
					{
						class2354_0 = class2354_0.class2354_0;
					}
					if (class2354_0.intPoint_2.long_1 != class2354_0.class2354_1.intPoint_0.long_1)
					{
						goto Block_6;
					}
				}
				else
				{
					class2354_0 = class2354_0.class2354_0;
				}
			}
			Class2354 result = class2354_0;
			return result;
			Block_6:
			if (@class.class2354_1.intPoint_0.long_0 < class2354_0.intPoint_0.long_0)
			{
				class2354_0 = @class;
			}
			result = class2354_0;
			return result;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0005A2AC File Offset: 0x000584AC
		private Class2354 method_6(Class2354 class2354_0, bool bool_3)
		{
			Class2354 @class = class2354_0;
			Class2354 class2 = class2354_0;
			if (class2354_0.double_0 == -3.4E+38)
			{
				long long_;
				if (bool_3)
				{
					long_ = class2354_0.class2354_1.intPoint_0.long_0;
				}
				else
				{
					long_ = class2354_0.class2354_0.intPoint_0.long_0;
				}
				if (class2354_0.intPoint_0.long_0 != long_)
				{
					this.method_14(class2354_0);
				}
			}
			if (class2.int_3 != -2)
			{
				if (bool_3)
				{
					while (class2.intPoint_2.long_1 == class2.class2354_0.intPoint_0.long_1 && class2.class2354_0.int_3 != -2)
					{
						class2 = class2.class2354_0;
					}
					if (class2.double_0 == -3.4E+38 && class2.class2354_0.int_3 != -2)
					{
						Class2354 class3 = class2;
						while (class3.class2354_1.double_0 == -3.4E+38)
						{
							class3 = class3.class2354_1;
						}
						if (class3.class2354_1.intPoint_2.long_0 == class2.class2354_0.intPoint_2.long_0)
						{
							if (!bool_3)
							{
								class2 = class3.class2354_1;
							}
						}
						else if (class3.class2354_1.intPoint_2.long_0 > class2.class2354_0.intPoint_2.long_0)
						{
							class2 = class3.class2354_1;
						}
					}
					while (class2354_0 != class2)
					{
						class2354_0.class2354_2 = class2354_0.class2354_0;
						if (class2354_0.double_0 == -3.4E+38 && class2354_0 != @class && class2354_0.intPoint_0.long_0 != class2354_0.class2354_1.intPoint_2.long_0)
						{
							this.method_14(class2354_0);
						}
						class2354_0 = class2354_0.class2354_0;
					}
					if (class2354_0.double_0 == -3.4E+38 && class2354_0 != @class && class2354_0.intPoint_0.long_0 != class2354_0.class2354_1.intPoint_2.long_0)
					{
						this.method_14(class2354_0);
					}
					class2 = class2.class2354_0;
				}
				else
				{
					while (class2.intPoint_2.long_1 == class2.class2354_1.intPoint_0.long_1 && class2.class2354_1.int_3 != -2)
					{
						class2 = class2.class2354_1;
					}
					if (class2.double_0 == -3.4E+38 && class2.class2354_1.int_3 != -2)
					{
						Class2354 class3 = class2;
						while (class3.class2354_0.double_0 == -3.4E+38)
						{
							class3 = class3.class2354_0;
						}
						if (class3.class2354_0.intPoint_2.long_0 == class2.class2354_1.intPoint_2.long_0)
						{
							if (!bool_3)
							{
								class2 = class3.class2354_0;
							}
						}
						else if (class3.class2354_0.intPoint_2.long_0 > class2.class2354_1.intPoint_2.long_0)
						{
							class2 = class3.class2354_0;
						}
					}
					while (class2354_0 != class2)
					{
						class2354_0.class2354_2 = class2354_0.class2354_1;
						if (class2354_0.double_0 == -3.4E+38 && class2354_0 != @class && class2354_0.intPoint_0.long_0 != class2354_0.class2354_0.intPoint_2.long_0)
						{
							this.method_14(class2354_0);
						}
						class2354_0 = class2354_0.class2354_1;
					}
					if (class2354_0.double_0 == -3.4E+38 && class2354_0 != @class && class2354_0.intPoint_0.long_0 != class2354_0.class2354_0.intPoint_2.long_0)
					{
						this.method_14(class2354_0);
					}
					class2 = class2.class2354_1;
				}
			}
			if (class2.int_3 == -2)
			{
				class2354_0 = class2;
				if (bool_3)
				{
					while (class2354_0.intPoint_2.long_1 == class2354_0.class2354_0.intPoint_0.long_1)
					{
						class2354_0 = class2354_0.class2354_0;
					}
					while (class2354_0 != class2)
					{
						if (class2354_0.double_0 != -3.4E+38)
						{
							break;
						}
						class2354_0 = class2354_0.class2354_1;
					}
				}
				else
				{
					while (class2354_0.intPoint_2.long_1 == class2354_0.class2354_1.intPoint_0.long_1)
					{
						class2354_0 = class2354_0.class2354_1;
					}
					while (class2354_0 != class2 && class2354_0.double_0 == -3.4E+38)
					{
						class2354_0 = class2354_0.class2354_0;
					}
				}
				if (class2354_0 == class2)
				{
					if (bool_3)
					{
						class2 = class2354_0.class2354_0;
					}
					else
					{
						class2 = class2354_0.class2354_1;
					}
				}
				else
				{
					if (bool_3)
					{
						class2354_0 = class2.class2354_0;
					}
					else
					{
						class2354_0 = class2.class2354_1;
					}
					Class2357 class4 = new Class2357();
					class4.class2357_0 = null;
					class4.long_0 = class2354_0.intPoint_0.long_1;
					class4.class2354_0 = null;
					class4.class2354_1 = class2354_0;
					class4.class2354_1.int_0 = 0;
					class2 = this.method_6(class4.class2354_1, bool_3);
					this.method_12(class4);
				}
			}
			return class2;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0005A79C File Offset: 0x0005899C
		public bool method_7(List<IntPoint> list_1, Enum163 enum163_0, bool bool_3)
		{
			if (!bool_3)
			{
				throw new Exception29("AddPath: Open paths have been disabled.");
			}
			int num = list_1.Count - 1;
			if (bool_3)
			{
				while (num > 0 && IntPoint.smethod_0(list_1[num], list_1[0]))
				{
					num--;
				}
			}
			while (num > 0 && IntPoint.smethod_0(list_1[num], list_1[num - 1]))
			{
				num--;
			}
			bool result;
			if ((bool_3 && num < 2) || (!bool_3 && num < 1))
			{
				result = false;
			}
			else
			{
				List<Class2354> list = new List<Class2354>(num + 1);
				for (int i = 0; i <= num; i++)
				{
					list.Add(new Class2354());
				}
				bool flag = true;
				list[1].intPoint_1 = list_1[1];
				this.method_2(list_1[0], ref this.bool_0);
				this.method_2(list_1[num], ref this.bool_0);
				this.method_3(list[0], list[1], list[num], list_1[0]);
				this.method_3(list[num], list[0], list[num - 1], list_1[num]);
				for (int j = num - 1; j >= 1; j--)
				{
					this.method_2(list_1[j], ref this.bool_0);
					this.method_3(list[j], list[j + 1], list[j - 1], list_1[j]);
				}
				Class2354 @class = list[0];
				Class2354 class2 = @class;
				Class2354 class3 = @class;
				while (true)
				{
					if (IntPoint.smethod_0(class2.intPoint_1, class2.class2354_0.intPoint_1))
					{
						if (class2 == class2.class2354_0)
						{
							break;
						}
						if (class2 == @class)
						{
							@class = class2.class2354_0;
						}
						class2 = this.method_10(class2);
						class3 = class2;
					}
					else
					{
						if (class2.class2354_1 == class2.class2354_0)
						{
							break;
						}
						if (bool_3 && Class2362.smethod_3(class2.class2354_1.intPoint_1, class2.intPoint_1, class2.class2354_0.intPoint_1, this.bool_0) && (!this.method_0() || !this.method_9(class2.class2354_1.intPoint_1, class2.intPoint_1, class2.class2354_0.intPoint_1)))
						{
							if (class2 == @class)
							{
								@class = class2.class2354_0;
							}
							class2 = this.method_10(class2);
							class2 = class2.class2354_1;
							class3 = class2;
						}
						else
						{
							class2 = class2.class2354_0;
							if (class2 == class3)
							{
								break;
							}
						}
					}
				}
				bool arg_2DA_0;
				if (!bool_3)
				{
					if (class2 == class2.class2354_0)
					{
						arg_2DA_0 = false;
						goto IL_2DA;
					}
				}
				arg_2DA_0 = (!bool_3 || class2.class2354_1 != class2.class2354_0);
				IL_2DA:
				if (!arg_2DA_0)
				{
					result = false;
				}
				else
				{
					if (!bool_3)
					{
						this.bool_1 = true;
						@class.class2354_1.int_3 = -2;
					}
					class2 = @class;
					do
					{
						this.method_4(class2, enum163_0);
						class2 = class2.class2354_0;
						if (flag && class2.intPoint_1.long_1 != @class.intPoint_1.long_1)
						{
							flag = false;
						}
					}
					while (class2 != @class);
					if (!flag)
					{
						this.list_0.Add(list);
						Class2354 class4 = null;
						while (true)
						{
							class2 = this.method_5(class2);
							if (class2 == class4)
							{
								break;
							}
							if (class4 == null)
							{
								class4 = class2;
							}
							Class2357 class5 = new Class2357();
							class5.class2357_0 = null;
							class5.long_0 = class2.intPoint_0.long_1;
							bool flag2;
							if (class2.double_0 < class2.class2354_1.double_0)
							{
								class5.class2354_0 = class2.class2354_1;
								class5.class2354_1 = class2;
								flag2 = false;
							}
							else
							{
								class5.class2354_0 = class2;
								class5.class2354_1 = class2.class2354_1;
								flag2 = true;
							}
							class5.class2354_0.enum167_0 = Enum167.const_0;
							class5.class2354_1.enum167_0 = Enum167.const_1;
							if (!bool_3)
							{
								class5.class2354_0.int_0 = 0;
							}
							else if (class5.class2354_0.class2354_0 == class5.class2354_1)
							{
								class5.class2354_0.int_0 = -1;
							}
							else
							{
								class5.class2354_0.int_0 = 1;
							}
							class5.class2354_1.int_0 = -class5.class2354_0.int_0;
							class2 = this.method_6(class5.class2354_0, flag2);
							Class2354 class6 = this.method_6(class5.class2354_1, !flag2);
							if (class5.class2354_0.int_3 == -2)
							{
								class5.class2354_0 = null;
							}
							else if (class5.class2354_1.int_3 == -2)
							{
								class5.class2354_1 = null;
							}
							this.method_12(class5);
							if (!flag2)
							{
								class2 = class6;
							}
						}
						result = true;
					}
					else if (bool_3)
					{
						result = false;
					}
					else
					{
						class2.class2354_1.int_3 = -2;
						if (class2.class2354_1.intPoint_0.long_0 < class2.class2354_1.intPoint_2.long_0)
						{
							this.method_14(class2.class2354_1);
						}
						Class2357 class7 = new Class2357();
						class7.class2357_0 = null;
						class7.long_0 = class2.intPoint_0.long_1;
						class7.class2354_0 = null;
						class7.class2354_1 = class2;
						class7.class2354_1.enum167_0 = Enum167.const_1;
						class7.class2354_1.int_0 = 0;
						while (class2.class2354_0.int_3 != -2)
						{
							class2.class2354_2 = class2.class2354_0;
							if (class2.intPoint_0.long_0 != class2.class2354_1.intPoint_2.long_0)
							{
								this.method_14(class2);
							}
							class2 = class2.class2354_0;
						}
						this.method_12(class7);
						this.list_0.Add(list);
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0005ADA8 File Offset: 0x00058FA8
		public bool method_8(List<List<IntPoint>> list_1, Enum163 enum163_0, bool bool_3)
		{
			bool result = false;
			for (int i = 0; i < list_1.Count; i++)
			{
				if (this.method_7(list_1[i], enum163_0, bool_3))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0005ADE4 File Offset: 0x00058FE4
		internal bool method_9(IntPoint intPoint_0, IntPoint intPoint_1, IntPoint intPoint_2)
		{
			bool result;
			if (IntPoint.smethod_0(intPoint_0, intPoint_2) || IntPoint.smethod_0(intPoint_0, intPoint_1) || IntPoint.smethod_0(intPoint_2, intPoint_1))
			{
				result = false;
			}
			else if (intPoint_0.long_0 != intPoint_2.long_0)
			{
				result = (intPoint_1.long_0 > intPoint_0.long_0 == intPoint_1.long_0 < intPoint_2.long_0);
			}
			else
			{
				result = (intPoint_1.long_1 > intPoint_0.long_1 == intPoint_1.long_1 < intPoint_2.long_1);
			}
			return result;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0005AE74 File Offset: 0x00059074
		private Class2354 method_10(Class2354 class2354_0)
		{
			class2354_0.class2354_1.class2354_0 = class2354_0.class2354_0;
			class2354_0.class2354_0.class2354_1 = class2354_0.class2354_1;
			Class2354 class2354_ = class2354_0.class2354_0;
			class2354_0.class2354_1 = null;
			return class2354_;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0005AEB4 File Offset: 0x000590B4
		private void method_11(Class2354 class2354_0)
		{
			class2354_0.intPoint_3.long_0 = class2354_0.intPoint_2.long_0 - class2354_0.intPoint_0.long_0;
			class2354_0.intPoint_3.long_1 = class2354_0.intPoint_2.long_1 - class2354_0.intPoint_0.long_1;
			if (class2354_0.intPoint_3.long_1 == 0L)
			{
				class2354_0.double_0 = -3.4E+38;
			}
			else
			{
				class2354_0.double_0 = (double)class2354_0.intPoint_3.long_0 / (double)class2354_0.intPoint_3.long_1;
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0005AF50 File Offset: 0x00059150
		private void method_12(Class2357 class2357_2)
		{
			if (this.class2357_0 == null)
			{
				this.class2357_0 = class2357_2;
			}
			else if (class2357_2.long_0 >= this.class2357_0.long_0)
			{
				class2357_2.class2357_0 = this.class2357_0;
				this.class2357_0 = class2357_2;
			}
			else
			{
				Class2357 @class = this.class2357_0;
				while (@class.class2357_0 != null && class2357_2.long_0 < @class.class2357_0.long_0)
				{
					@class = @class.class2357_0;
				}
				class2357_2.class2357_0 = @class.class2357_0;
				@class.class2357_0 = class2357_2;
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000057A3 File Offset: 0x000039A3
		protected void method_13()
		{
			if (this.class2357_1 != null)
			{
				this.class2357_1 = this.class2357_1.class2357_0;
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0005AFE8 File Offset: 0x000591E8
		private void method_14(Class2354 class2354_0)
		{
			long long_ = class2354_0.intPoint_2.long_0;
			class2354_0.intPoint_2.long_0 = class2354_0.intPoint_0.long_0;
			class2354_0.intPoint_0.long_0 = long_;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0005B024 File Offset: 0x00059224
		protected virtual void vmethod_0()
		{
			this.class2357_1 = this.class2357_0;
			if (this.class2357_1 != null)
			{
				for (Class2357 @class = this.class2357_0; @class != null; @class = @class.class2357_0)
				{
					Class2354 class2 = @class.class2354_0;
					if (class2 != null)
					{
						class2.intPoint_1 = class2.intPoint_0;
						class2.enum167_0 = Enum167.const_0;
						class2.int_3 = -1;
					}
					class2 = @class.class2354_1;
					if (class2 != null)
					{
						class2.intPoint_1 = class2.intPoint_0;
						class2.enum167_0 = Enum167.const_1;
						class2.int_3 = -1;
					}
				}
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0005B0B4 File Offset: 0x000592B4
		public static Struct70 smethod_4(List<List<IntPoint>> list_1)
		{
			int i = 0;
			int count = list_1.Count;
			while (i < count && list_1[i].Count == 0)
			{
				i++;
			}
			Struct70 result;
			if (i == count)
			{
				result = new Struct70(0L, 0L, 0L, 0L);
			}
			else
			{
				Struct70 @struct = default(Struct70);
				@struct.long_0 = list_1[i][0].long_0;
				@struct.long_2 = @struct.long_0;
				@struct.long_1 = list_1[i][0].long_1;
				@struct.long_3 = @struct.long_1;
				while (i < count)
				{
					for (int j = 0; j < list_1[i].Count; j++)
					{
						if (list_1[i][j].long_0 < @struct.long_0)
						{
							@struct.long_0 = list_1[i][j].long_0;
						}
						else if (list_1[i][j].long_0 > @struct.long_2)
						{
							@struct.long_2 = list_1[i][j].long_0;
						}
						if (list_1[i][j].long_1 < @struct.long_1)
						{
							@struct.long_1 = list_1[i][j].long_1;
						}
						else if (list_1[i][j].long_1 > @struct.long_3)
						{
							@struct.long_3 = list_1[i][j].long_1;
						}
					}
					i++;
				}
				result = @struct;
			}
			return result;
		}

		// Token: 0x04000147 RID: 327
		internal Class2357 class2357_0;

		// Token: 0x04000148 RID: 328
		internal Class2357 class2357_1;

		// Token: 0x04000149 RID: 329
		internal List<List<Class2354>> list_0 = new List<List<Class2354>>();

		// Token: 0x0400014A RID: 330
		internal bool bool_0;

		// Token: 0x0400014B RID: 331
		internal bool bool_1;

		// Token: 0x0400014C RID: 332
		[CompilerGenerated]
		private bool bool_2 = false;
	}
}
