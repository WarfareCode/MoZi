using System;
using System.Collections;
using DotSpatial.Topology;

namespace ns26
{
	// Token: 0x020007E8 RID: 2024
	public sealed class Class2335
	{
		// Token: 0x0600320B RID: 12811 RVA: 0x0010D2A0 File Offset: 0x0010B4A0
		public  ICollection vmethod_0()
		{
			return this.idictionary_0.Values;
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x0010D2BC File Offset: 0x0010B4BC
		public  Class2318 vmethod_1(Class2318 class2318_0)
		{
			Coordinate key = class2318_0.vmethod_0();
			if (!this.idictionary_0.Contains(key))
			{
				this.idictionary_0.Add(key, class2318_0);
			}
			return class2318_0;
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x0010D2F0 File Offset: 0x0010B4F0
		public  Class2318 vmethod_2(Coordinate coordinate_0)
		{
			return (Class2318)this.idictionary_0[coordinate_0];
		}

		// Token: 0x04001735 RID: 5941
		private readonly IDictionary idictionary_0 = new SortedList();
	}
}
