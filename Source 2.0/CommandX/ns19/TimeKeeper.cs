using System;
using System.Runtime.CompilerServices;
using System.Timers;

namespace ns19
{
	// Token: 0x020003CA RID: 970
	public sealed class TimeKeeper
	{
		// Token: 0x06001811 RID: 6161 RVA: 0x00096450 File Offset: 0x00094650
		public static DateTime smethod_0()
		{
			return TimeKeeper.dateTime_0;
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x000100A9 File Offset: 0x0000E2A9
		public static void smethod_1(DateTime dateTime_1)
		{
			TimeKeeper.dateTime_0 = dateTime_1;
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00096464 File Offset: 0x00094664
		public static float smethod_2()
		{
			return TimeKeeper.float_0;
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x000100B1 File Offset: 0x0000E2B1
		public static void smethod_3(float float_2)
		{
			TimeKeeper.float_0 = float_2;
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00096478 File Offset: 0x00094678
		public static void smethod_4()
		{
			TimeKeeper.bool_0 = true;
			if (TimeKeeper.timer_0 == null)
			{
				TimeKeeper.timer_0 = new Timer((double)TimeKeeper.float_1);
				TimeKeeper.timer_0.Elapsed += new ElapsedEventHandler(TimeKeeper.smethod_5);
			}
			TimeKeeper.timer_0.Start();
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x000100B9 File Offset: 0x0000E2B9
		private static void smethod_5(object sender, ElapsedEventArgs e)
		{
			TimeKeeper.dateTime_0 += TimeSpan.FromMilliseconds((double)(TimeKeeper.float_1 * TimeKeeper.float_0));
			if (TimeKeeper.elapsedEventHandler_0 != null)
			{
				TimeKeeper.elapsedEventHandler_0(sender, e);
			}
		}

		// Token: 0x040009E2 RID: 2530
		private static DateTime dateTime_0 = DateTime.Now.ToUniversalTime();

		// Token: 0x040009E3 RID: 2531
		private static float float_0 = 1f;

		// Token: 0x040009E4 RID: 2532
		private static bool bool_0 = false;

		// Token: 0x040009E5 RID: 2533
		private static Timer timer_0 = null;

		// Token: 0x040009E6 RID: 2534
		private static float float_1 = 15f;

		// Token: 0x040009E7 RID: 2535
		[CompilerGenerated]
		private static ElapsedEventHandler elapsedEventHandler_0;
	}
}
