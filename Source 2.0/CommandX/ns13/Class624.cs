using System;
using System.Collections;
using GeoAPI.Geometries;
using ns12;
using ns14;

namespace ns13
{
	// Token: 0x020003D5 RID: 981
	public abstract class Class624
	{
		// Token: 0x06001844 RID: 6212 RVA: 0x00096E34 File Offset: 0x00095034
		public Class624()
		{
		}

		// Token: 0x06001845 RID: 6213
		public abstract void vmethod_0(Class573 class573_0);

		// Token: 0x06001846 RID: 6214 RVA: 0x000101E1 File Offset: 0x0000E3E1
		protected void method_0(Class573 class573_0, object object_0)
		{
			if (!this.idictionary_0.Contains(class573_0))
			{
				this.idictionary_0.Add(class573_0, object_0);
				this.ilist_0 = null;
			}
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00096E68 File Offset: 0x00095068
		public IEnumerator method_1()
		{
			return this.method_2().GetEnumerator();
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00096E84 File Offset: 0x00095084
		public IList method_2()
		{
			if (this.ilist_0 == null)
			{
				this.ilist_0 = new ArrayList(this.idictionary_0.Values);
			}
			return this.ilist_0;
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00096EC0 File Offset: 0x000950C0
		public  void vmethod_1(Class640[] class640_0)
		{
			this.method_3();
			this.method_5(0);
			this.method_5(1);
			bool[] array = new bool[2];
			bool[] array2 = array;
			IEnumerator enumerator = this.method_1();
			while (enumerator.MoveNext())
			{
				Class573 @class = (Class573)enumerator.Current;
				Class652 class2 = @class.method_2();
				for (int i = 0; i < 2; i++)
				{
					if (class2.method_12(i) && class2.method_2(i) == Enum143.const_1)
					{
						array2[i] = true;
					}
				}
			}
			enumerator = this.method_1();
			while (enumerator.MoveNext())
			{
				Class573 @class = (Class573)enumerator.Current;
				Class652 class2 = @class.method_2();
				for (int i = 0; i < 2; i++)
				{
					if (class2.method_9(i))
					{
						Enum143 @enum;
						if (array2[i])
						{
							@enum = Enum143.const_2;
						}
						else
						{
							ICoordinate icoordinate_ = @class.method_3();
							@enum = this.method_4(i, icoordinate_, class640_0);
						}
						class2.method_6(i, @enum);
					}
				}
			}
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00096FB8 File Offset: 0x000951B8
		private void method_3()
		{
			IEnumerator enumerator = this.method_1();
			while (enumerator.MoveNext())
			{
				Class573 @class = (Class573)enumerator.Current;
				@class.vmethod_0();
			}
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00096FE8 File Offset: 0x000951E8
		public Enum143 method_4(int int_0, ICoordinate icoordinate_0, Class640[] class640_0)
		{
			if (this.enum143_0[int_0] == Enum143.const_3)
			{
				this.enum143_0[int_0] = Class627.smethod_0(icoordinate_0, class640_0[int_0].method_5());
			}
			return this.enum143_0[int_0];
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00097028 File Offset: 0x00095228
		public void method_5(int int_0)
		{
			Enum143 @enum = Enum143.const_3;
			IEnumerator enumerator = this.method_1();
			while (enumerator.MoveNext())
			{
				Class573 @class = (Class573)enumerator.Current;
				Class652 class2 = @class.method_2();
				if (class2.method_11(int_0) && class2.method_1(int_0, Enum140.const_1) != Enum143.const_3)
				{
					@enum = class2.method_1(int_0, Enum140.const_1);
				}
			}
			if (@enum != Enum143.const_3)
			{
				Enum143 enum2 = @enum;
				enumerator = this.method_1();
				while (enumerator.MoveNext())
				{
					Class573 @class = (Class573)enumerator.Current;
					Class652 class2 = @class.method_2();
					if (class2.method_1(int_0, Enum140.const_0) == Enum143.const_3)
					{
						class2.method_3(int_0, Enum140.const_0, enum2);
					}
					if (class2.method_11(int_0))
					{
						Enum143 enum3 = class2.method_1(int_0, Enum140.const_1);
						Enum143 enum4 = class2.method_1(int_0, Enum140.const_2);
						if (enum4 != Enum143.const_3)
						{
							if (enum4 != enum2)
							{
								throw new Exception11("side location conflict", @class.method_3());
							}
							if (enum3 == Enum143.const_3)
							{
								Class570.smethod_2("found single null side (at " + @class.method_3() + ")");
							}
							enum2 = enum3;
						}
						else
						{
							Class570.smethod_0(class2.method_1(int_0, Enum140.const_1) == Enum143.const_3, "found single null side");
							class2.method_3(int_0, Enum140.const_2, enum2);
							class2.method_3(int_0, Enum140.const_1, enum2);
						}
					}
				}
			}
		}

		// Token: 0x04000A0F RID: 2575
		protected IDictionary idictionary_0 = new SortedList();

		// Token: 0x04000A10 RID: 2576
		protected IList ilist_0;

		// Token: 0x04000A11 RID: 2577
		private Enum143[] enum143_0 = new Enum143[]
		{
			Enum143.const_3,
			Enum143.const_3
		};
	}
}
