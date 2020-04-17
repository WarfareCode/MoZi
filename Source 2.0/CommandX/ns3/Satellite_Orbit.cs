using System;
using Command_Core;
using Microsoft.VisualBasic;

namespace ns3
{
	// Token: 0x02000BAF RID: 2991
	public sealed class Satellite_Orbit
	{
		// Token: 0x02000BB0 RID: 2992
		public sealed class Ephemeris
		{
			// Token: 0x060062A9 RID: 25257 RVA: 0x003023B0 File Offset: 0x003005B0
			public Ephemeris()
			{
				this.class243_0 = new Class242.Class243();
				this.class243_0.double_4 = 0.0;
				this.method_9("XXXXX");
				this.class243_0.double_7 = 0.0;
				this.class243_0.double_11 = 0.0;
				this.class243_0.double_10 = 0.0;
				this.method_8(0.0);
				this.method_7(0.0);
				this.method_5(DateAndTime.Now);
				this.method_6(63.4);
				this.method_2(300.0, 300.0);
			}

			// Token: 0x060062AA RID: 25258 RVA: 0x0002B731 File Offset: 0x00029931
			public void method_0(double double_0, double double_1, double double_2)
			{
				this.method_6(double_0);
				this.method_2(double_1, double_2);
				this.method_5(new DateTime(1900, 1, 1));
			}

			// Token: 0x060062AB RID: 25259 RVA: 0x0030247C File Offset: 0x0030067C
			public void method_1(DateTime dateTime_0, bool bool_0, ref double double_0, ref double double_1, ref double double_2, ref double double_3)
			{
				Class242.Struct26 @struct;
				@struct.double_0 = new double[4];
				Class242.Struct26 struct2;
				struct2.double_0 = new double[4];
				int hours = 8;
				TimeZone currentTimeZone = TimeZone.CurrentTimeZone;
				DateTime dateTime;
				if (!bool_0)
				{
					currentTimeZone.GetUtcOffset(dateTime_0);
					if (currentTimeZone.IsDaylightSavingTime(dateTime_0))
					{
						hours = 7;
					}
					dateTime = currentTimeZone.ToUniversalTime(dateTime_0);
				}
				else
				{
					dateTime = dateTime_0;
				}
				dateTime = dateTime.Subtract(new TimeSpan(0, hours, 0, 0));
				double num = Class245.smethod_3(ref dateTime);
				Class237.smethod_2(num, ref @struct, ref struct2, this.class243_0);
				Class238.smethod_0(ref @struct, ref struct2);
				Class242.Struct30 struct3 = default(Class242.Struct30);
				Class244.smethod_6(num - this.class243_0.double_1, ref @struct, ref struct3);
				double_0 = Class244.smethod_8(struct3.double_0);
				double_1 = Class244.smethod_2(Class244.smethod_8(struct3.double_1), 360.0);
				double_2 = struct3.double_2;
				double_3 = struct2.double_0[3];
				double_1 = Math2.NormalizeLongitude(double_1);
			}

			// Token: 0x060062AC RID: 25260 RVA: 0x0002B754 File Offset: 0x00029954
			public void method_2(double double_0, double double_1)
			{
				this.class243_0.method_0(double_0, double_1);
				this.class243_0.method_8();
			}

			// Token: 0x060062AD RID: 25261 RVA: 0x00302574 File Offset: 0x00300774
			public double method_3()
			{
				return this.class243_0.method_1();
			}

			// Token: 0x060062AE RID: 25262 RVA: 0x00302590 File Offset: 0x00300790
			public double method_4()
			{
				return this.class243_0.method_2();
			}

			// Token: 0x060062AF RID: 25263 RVA: 0x003025AC File Offset: 0x003007AC
			public void method_5(DateTime dateTime_0)
			{
				int num;
				if (dateTime_0.Year < 2000)
				{
					num = dateTime_0.Year - 1900;
				}
				else
				{
					num = dateTime_0.Year - 2000;
				}
				this.class243_0.double_0 = (double)num * 1000.0 + (double)dateTime_0.DayOfYear + dateTime_0.TimeOfDay.TotalSeconds / 86400.0;
				this.class243_0.double_1 = Class245.smethod_1(ref this.class243_0.double_0);
			}

			// Token: 0x060062B0 RID: 25264 RVA: 0x0002B76E File Offset: 0x0002996E
			public void method_6(double double_0)
			{
				this.class243_0.method_3(double_0);
			}

			// Token: 0x060062B1 RID: 25265 RVA: 0x0002B77C File Offset: 0x0002997C
			public void method_7(double double_0)
			{
				this.class243_0.method_7(double_0);
			}

			// Token: 0x060062B2 RID: 25266 RVA: 0x0002B78A File Offset: 0x0002998A
			public void method_8(double double_0)
			{
				this.class243_0.method_6(double_0);
			}

			// Token: 0x060062B3 RID: 25267 RVA: 0x0002B798 File Offset: 0x00029998
			public void method_9(string string_0)
			{
				this.class243_0.string_0 = string_0;
			}

			// Token: 0x040035D3 RID: 13779
			public Class242.Class243 class243_0;
		}
	}
}
