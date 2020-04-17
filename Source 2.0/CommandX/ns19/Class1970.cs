using System;
using System.Collections;

namespace ns19
{
	// Token: 0x0200041D RID: 1053
	public sealed class Class1970 : TerrainAccessor
	{
		// Token: 0x17000230 RID: 560
		public TerrainAccessor this[int int_1]
		{
			get
			{
				return this.class1969_0[int_1];
			}
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x000A0734 File Offset: 0x0009E934
		public override float vmethod_0(double double_4, double double_5, double double_6)
		{
			float result;
			try
			{
				float num;
				if (this.class1971_0 != null && double_6 >= (double)World.Settings.method_47())
				{
					if (this.class1969_0 != null)
					{
						TerrainAccessor[] array = this.class1969_0;
						for (int i = 0; i < array.Length; i++)
						{
							TerrainAccessor terrainAccessor = array[i];
							if (double_4 > terrainAccessor.method_1() && double_4 < terrainAccessor.method_0() && double_5 > terrainAccessor.method_2() && double_5 < terrainAccessor.method_3())
							{
								num = terrainAccessor.vmethod_0(double_4, double_5, double_6);
								result = num;
								return result;
							}
						}
					}
					Class1972 @class = this.class1971_0.method_6(double_4, double_5, double_6);
					Class1970.Class1968 class2 = (Class1970.Class1968)this.hashtable_0[@class.string_0];
					if (class2 == null)
					{
						class2 = new Class1970.Class1968(@class);
						this.method_4(class2);
					}
					if (!class2.method_0().bool_0)
					{
						class2.method_0().method_0();
					}
					class2.method_2(DateTime.Now);
					num = class2.method_0().method_1(double_4, double_5);
					result = num;
					return result;
				}
				num = 0f;
				result = num;
				return result;
			}
			catch (Exception)
			{
			}
			result = 0f;
			return result;
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x000A0880 File Offset: 0x0009EA80
		public override float vmethod_1(double double_4, double double_5)
		{
			return this.vmethod_0(double_4, double_5, (double)this.class1971_0.method_3() / this.class1971_0.method_2());
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x000A08B0 File Offset: 0x0009EAB0
		public override Class1972 vmethod_2(double double_4, double double_5, double double_6, double double_7, int int_1)
		{
			Class1972 result;
			if (this.class1969_0 != null)
			{
				TerrainAccessor[] array = this.class1969_0;
				for (int i = 0; i < array.Length; i++)
				{
					TerrainAccessor terrainAccessor = array[i];
					if (double_4 <= terrainAccessor.method_0() && double_5 >= terrainAccessor.method_1() && double_6 >= terrainAccessor.method_2() && double_7 <= terrainAccessor.method_3())
					{
						result = terrainAccessor.vmethod_2(double_4, double_5, double_6, double_7, int_1);
						return result;
					}
				}
			}
			Class1972 @class = new Class1972(this.class1971_0);
			@class.double_2 = double_4;
			@class.double_1 = double_5;
			@class.double_3 = double_6;
			@class.double_4 = double_7;
			@class.int_0 = int_1;
			@class.bool_0 = true;
			@class.bool_1 = true;
			double num = (double)int_1 / (double_4 - double_5);
			double num2 = Math.Abs(double_4 - double_5);
			double num3 = Math.Abs(double_7 - double_6);
			Class1970.Class1968 class2 = null;
			float[,] array2 = new float[int_1, int_1];
			if (num < (double)World.Settings.method_47())
			{
				@class.float_0 = array2;
				result = @class;
			}
			else
			{
				double num4 = 1.0 / (double)(int_1 - 1);
				for (int j = 0; j < int_1; j++)
				{
					for (int k = 0; k < int_1; k++)
					{
						double num5 = double_4 - num4 * num2 * (double)j;
						double num6 = double_6 + num4 * num3 * (double)k;
						if (num5 > 90.0)
						{
							num5 = 90.0 - (num5 - 90.0);
							num6 += 180.0;
						}
						if (num5 < -90.0)
						{
							num5 = -90.0 - (num5 + 90.0);
							num6 += 180.0;
						}
						if (num6 > 180.0)
						{
							num6 -= 360.0;
						}
						if (num6 < -180.0)
						{
							num6 += 360.0;
						}
						if (class2 == null || num5 < class2.method_0().double_1 || num5 > class2.method_0().double_2 || num6 < class2.method_0().double_3 || num6 > class2.method_0().double_4)
						{
							Class1972 class3 = this.class1971_0.method_6(num5, num6, num);
							class2 = (Class1970.Class1968)this.hashtable_0[class3.string_0];
							if (class2 == null)
							{
								class2 = new Class1970.Class1968(class3);
								this.method_4(class2);
							}
							if (!class2.method_0().bool_0)
							{
								class2.method_0().method_0();
							}
							class2.method_2(DateTime.Now);
							if (!class3.bool_1)
							{
								@class.bool_1 = false;
							}
						}
						array2[j, k] = class2.method_0().method_1(num5, num6);
					}
				}
				@class.float_0 = array2;
				result = @class;
			}
			return result;
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x000A0BBC File Offset: 0x0009EDBC
		protected void method_4(Class1970.Class1968 class1968_0)
		{
			if (!this.hashtable_0.ContainsKey(class1968_0.method_0().string_0))
			{
				if (this.hashtable_0.Count >= Class1970.int_0)
				{
					Class1970.Class1968 @class = null;
					foreach (Class1970.Class1968 class2 in this.hashtable_0.Values)
					{
						if (@class == null)
						{
							@class = class2;
						}
						else if (class2.method_1() < @class.method_1())
						{
							@class = class2;
						}
					}
					this.hashtable_0.Remove(@class);
				}
				this.hashtable_0.Add(class1968_0.method_0().string_0, class1968_0);
			}
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0001117F File Offset: 0x0000F37F
		public override void Dispose()
		{
			if (this.class1971_0 != null)
			{
				this.class1971_0.Dispose();
				this.class1971_0 = null;
			}
		}

		// Token: 0x04000B3A RID: 2874
		public static int int_0 = 100;

		// Token: 0x04000B3B RID: 2875
		protected Class1971 class1971_0;

		// Token: 0x04000B3C RID: 2876
		protected TerrainAccessor[] class1969_0;

		// Token: 0x04000B3D RID: 2877
		protected Hashtable hashtable_0;

		// Token: 0x0200041E RID: 1054
		public sealed class Class1968
		{
			// Token: 0x06001AAE RID: 6830 RVA: 0x000111AF File Offset: 0x0000F3AF
			public Class1968(Class1972 class1972_1)
			{
				this.class1972_0 = class1972_1;
			}

			// Token: 0x06001AAF RID: 6831 RVA: 0x000A0C90 File Offset: 0x0009EE90
			public Class1972 method_0()
			{
				return this.class1972_0;
			}

			// Token: 0x06001AB0 RID: 6832 RVA: 0x000A0CA8 File Offset: 0x0009EEA8
			public DateTime method_1()
			{
				return this.dateTime_0;
			}

			// Token: 0x06001AB1 RID: 6833 RVA: 0x000111C9 File Offset: 0x0000F3C9
			public void method_2(DateTime dateTime_1)
			{
				this.dateTime_0 = dateTime_1;
			}

			// Token: 0x04000B3E RID: 2878
			private DateTime dateTime_0 = DateTime.Now;

			// Token: 0x04000B3F RID: 2879
			private Class1972 class1972_0;
		}
	}
}
