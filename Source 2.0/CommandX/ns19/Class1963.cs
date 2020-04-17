using System;

namespace ns19
{
	// Token: 0x020003CD RID: 973
	internal static class Class1963
	{
		// Token: 0x06001822 RID: 6178 RVA: 0x00096568 File Offset: 0x00094768
		public static string smethod_0(double double_0)
		{
			string result;
			if (World.Settings.method_51() == Enum150.const_1)
			{
				if (double_0 >= 1000.0)
				{
					result = string.Format("{0:,.0} km", double_0 / 1000.0);
				}
				else
				{
					result = string.Format("{0:f0} m", double_0);
				}
			}
			else
			{
				double num = 3.2808399;
				double num2 = 5280.0;
				double_0 *= num;
				if (double_0 >= num2)
				{
					result = string.Format("{0:,.0} miles", double_0 / num2);
				}
				else
				{
					result = string.Format("{0:f0} ft", double_0);
				}
			}
			return result;
		}
	}
}
