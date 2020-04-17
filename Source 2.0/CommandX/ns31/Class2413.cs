using System;

namespace ns31
{
	// Token: 0x02000420 RID: 1056
	public sealed class Class2413
	{
		// Token: 0x06001ABF RID: 6847 RVA: 0x000A1294 File Offset: 0x0009F494
		public Class2413(DateTime dateTime_0)
		{
			double double_ = (double)dateTime_0.DayOfYear + ((double)dateTime_0.Hour + ((double)dateTime_0.Minute + ((double)dateTime_0.Second + (double)dateTime_0.Millisecond / 1000.0) / 60.0) / 60.0) / 24.0;
			this.method_2(dateTime_0.Year, double_);
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x00011212 File Offset: 0x0000F412
		public Class2413(int int_1, double double_2)
		{
			this.method_2(int_1, double_2);
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x000A130C File Offset: 0x0009F50C
		public double method_0()
		{
			return this.double_0 - 2415020.0;
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x000A132C File Offset: 0x0009F52C
		public double method_1()
		{
			return this.double_0 - 2451545.0;
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x000A134C File Offset: 0x0009F54C
		protected void method_2(int int_1, double double_2)
		{
			if (int_1 < 1900 || int_1 > 2100)
			{
				throw new ArgumentOutOfRangeException("year");
			}
			if (double_2 < 1.0 || double_2 >= 367.0)
			{
				throw new ArgumentOutOfRangeException("doy");
			}
			this.int_0 = int_1;
			this.double_1 = double_2;
			int_1--;
			int num = int_1 / 100;
			int num2 = 2 - num + num / 4;
			double num3 = (double)((int)(365.25 * (double)int_1) + 428) + 1720994.5 + (double)num2;
			this.double_0 = num3 + double_2;
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x000A13F0 File Offset: 0x0009F5F0
		public double method_3()
		{
			double num = (this.double_0 + 0.5) % 1.0;
			double num2 = (this.method_1() - num) / 36525.0;
			double num3 = 24110.54841 + num2 * (8640184.812866 + num2 * (0.093104 - num2 * 6.2E-06));
			num3 = (num3 + 86636.555366976 * num) % 86400.0;
			if (num3 < 0.0)
			{
				num3 += 86400.0;
			}
			return 6.2831853071795862 * (num3 / 86400.0);
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x000A14A8 File Offset: 0x0009F6A8
		public DateTime method_4()
		{
			DateTime result = new DateTime(this.int_0, 1, 1);
			result = result.AddDays(this.double_1 - 1.0);
			return result;
		}

		// Token: 0x04000B45 RID: 2885
		private double double_0;

		// Token: 0x04000B46 RID: 2886
		private int int_0;

		// Token: 0x04000B47 RID: 2887
		private double double_1;
	}
}
