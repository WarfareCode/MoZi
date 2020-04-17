using System;

namespace ns28
{
	// Token: 0x02000803 RID: 2051
	public abstract class Class2352 : IComparable
	{
		// Token: 0x060032B3 RID: 12979
		public abstract double vmethod_0();

		// Token: 0x060032B4 RID: 12980
		protected abstract double vmethod_1();

		// Token: 0x060032B5 RID: 12981 RVA: 0x00118C68 File Offset: 0x00116E68
		public int CompareTo(object target)
		{
			if (!(target is Class2352))
			{
				throw new ArgumentException("obj not VEvent!");
			}
			int num = this.vmethod_0().CompareTo(((Class2352)target).vmethod_0());
			int result;
			if (num == 0)
			{
				result = this.vmethod_1().CompareTo(((Class2352)target).vmethod_1());
			}
			else
			{
				result = num;
			}
			return result;
		}
	}
}
