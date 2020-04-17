using System;
using System.Globalization;
using ns18;

namespace ns19
{
	// Token: 0x02000436 RID: 1078
	public sealed class Class1971 : IDisposable
	{
		// Token: 0x06001B97 RID: 7063 RVA: 0x000B16DC File Offset: 0x000AF8DC
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x000B16F4 File Offset: 0x000AF8F4
		public string method_1()
		{
			return this.string_1;
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x000B170C File Offset: 0x000AF90C
		public double method_2()
		{
			return this.double_0;
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x000B1724 File Offset: 0x000AF924
		public int method_3()
		{
			return this.int_0;
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x000B173C File Offset: 0x000AF93C
		public TimeSpan method_4()
		{
			return this.timeSpan_0;
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x000B1754 File Offset: 0x000AF954
		public string method_5()
		{
			return this.string_4;
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x000B176C File Offset: 0x000AF96C
		public Class1972 method_6(double double_1, double double_2, double double_3)
		{
			Class1972 @class = new Class1972(this);
			@class.int_3 = this.int_1 - 1;
			Class1972 result;
			for (int i = 0; i < this.int_1; i++)
			{
				if (double_3 <= (double)this.int_0 / (this.double_0 * Math.Pow(0.5, (double)i)))
				{
					@class.int_3 = i;
					@class.int_1 = Class1971.smethod_1(double_1, this.double_0 * Math.Pow(0.5, (double)@class.int_3));
					@class.int_2 = Class1971.smethod_0(double_2, this.double_0 * Math.Pow(0.5, (double)@class.int_3));
					@class.string_0 = string.Format(CultureInfo.InvariantCulture, "{0}\\{4}\\{1:D4}\\{1:D4}_{2:D4}.{3}", new object[]
					{
						this.string_3,
						@class.int_1,
						@class.int_2,
						this.string_2,
						@class.int_3
					});
					@class.int_0 = this.int_0;
					@class.double_0 = this.double_0 * Math.Pow(0.5, (double)@class.int_3);
					@class.double_2 = -90.0 + (double)@class.int_1 * @class.double_0 + @class.double_0;
					@class.double_1 = -90.0 + (double)@class.int_1 * @class.double_0;
					@class.double_3 = -180.0 + (double)@class.int_2 * @class.double_0;
					@class.double_4 = -180.0 + (double)@class.int_2 * @class.double_0 + @class.double_0;
					result = @class;
					return result;
				}
			}
			@class.int_1 = Class1971.smethod_1(double_1, this.double_0 * Math.Pow(0.5, (double)@class.int_3));
			@class.int_2 = Class1971.smethod_0(double_2, this.double_0 * Math.Pow(0.5, (double)@class.int_3));
			@class.string_0 = string.Format(CultureInfo.InvariantCulture, "{0}\\{4}\\{1:D4}\\{1:D4}_{2:D4}.{3}", new object[]
			{
				this.string_3,
				@class.int_1,
				@class.int_2,
				this.string_2,
				@class.int_3
			});
			@class.int_0 = this.int_0;
			@class.double_0 = this.double_0 * Math.Pow(0.5, (double)@class.int_3);
			@class.double_2 = -90.0 + (double)@class.int_1 * @class.double_0 + @class.double_0;
			@class.double_1 = -90.0 + (double)@class.int_1 * @class.double_0;
			@class.double_3 = -180.0 + (double)@class.int_2 * @class.double_0;
			@class.double_4 = -180.0 + (double)@class.int_2 * @class.double_0 + @class.double_0;
			result = @class;
			return result;
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x000B1A94 File Offset: 0x000AFC94
		public static int smethod_0(double double_1, double double_2)
		{
			return (int)Math.Floor(Math.Abs(-180.0 - double_1) % 360.0 / double_2);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x000B1AC8 File Offset: 0x000AFCC8
		public static int smethod_1(double double_1, double double_2)
		{
			return (int)Math.Floor(Math.Abs(-90.0 - double_1) % 180.0 / double_2);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00011588 File Offset: 0x0000F788
		public void Dispose()
		{
			if (DrawArgs.class1978_0 != null)
			{
				DrawArgs.class1978_0.vmethod_0(this);
			}
		}

		// Token: 0x04000BD1 RID: 3025
		private string string_0;

		// Token: 0x04000BD2 RID: 3026
		private string string_1;

		// Token: 0x04000BD3 RID: 3027
		private double double_0;

		// Token: 0x04000BD4 RID: 3028
		private int int_0;

		// Token: 0x04000BD5 RID: 3029
		private int int_1;

		// Token: 0x04000BD6 RID: 3030
		private string string_2 = "";

		// Token: 0x04000BD7 RID: 3031
		private string string_3 = "";

		// Token: 0x04000BD8 RID: 3032
		private TimeSpan timeSpan_0;

		// Token: 0x04000BD9 RID: 3033
		private string string_4 = "";
	}
}
