using System;
using System.Text;
using DotSpatial.Topology;
using ns25;
using ns28;

namespace ns24
{
	// Token: 0x02000552 RID: 1362
	public class Class2192 : IComparable
	{
		// Token: 0x06002333 RID: 9011 RVA: 0x0001474D File Offset: 0x0001294D
		protected Class2192(Class2199 class2199_1)
		{
			this.class2199_0 = class2199_1;
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x0001475C File Offset: 0x0001295C
		public Class2192(Class2199 class2199_1, Coordinate coordinate_2, Coordinate coordinate_3, Class2217 class2217_1) : this(class2199_1)
		{
			this.method_0(coordinate_2, coordinate_3);
			this.class2217_0 = class2217_1;
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x000DFA6C File Offset: 0x000DDC6C
		public virtual Class2199 vmethod_0()
		{
			return this.class2199_0;
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x000DFA84 File Offset: 0x000DDC84
		public virtual Class2217 vmethod_1()
		{
			return this.class2217_0;
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x00014775 File Offset: 0x00012975
		protected virtual void vmethod_2(Class2217 class2217_1)
		{
			this.class2217_0 = class2217_1;
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x000DFA9C File Offset: 0x000DDC9C
		public  Coordinate vmethod_3()
		{
			return this.coordinate_0;
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x000DFAB4 File Offset: 0x000DDCB4
		public  Coordinate vmethod_4()
		{
			return this.coordinate_1;
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x000DFACC File Offset: 0x000DDCCC
		public  int vmethod_5()
		{
			return this.int_0;
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x000DFAE4 File Offset: 0x000DDCE4
		public  double vmethod_6()
		{
			return this.double_1;
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x000DFAFC File Offset: 0x000DDCFC
		public virtual Class2200 vmethod_7()
		{
			return this.class2200_0;
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x0001477E File Offset: 0x0001297E
		public  void vmethod_8(Class2200 class2200_1)
		{
			this.class2200_0 = class2200_1;
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x000DFB14 File Offset: 0x000DDD14
		public virtual int CompareTo(object target)
		{
			Class2192 class2192_ = (Class2192)target;
			return this.vmethod_10(class2192_);
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x000DFB34 File Offset: 0x000DDD34
		private void method_0(Coordinate coordinate_2, Coordinate coordinate_3)
		{
			this.coordinate_0 = coordinate_2;
			this.coordinate_1 = coordinate_3;
			this.double_0 = coordinate_3.X - coordinate_2.X;
			this.double_1 = coordinate_3.Y - coordinate_2.Y;
			this.int_0 = Class2223.smethod_0(this.double_0, this.double_1);
			Class2347.smethod_1(this.double_0 != 0.0 || this.double_1 != 0.0, "EdgeEnd with identical endpoints found");
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x00014787 File Offset: 0x00012987
		protected virtual void vmethod_9(Coordinate coordinate_2, Coordinate coordinate_3)
		{
			this.method_0(coordinate_2, coordinate_3);
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x000DFBC0 File Offset: 0x000DDDC0
		public  int vmethod_10(Class2192 class2192_0)
		{
			int result;
			if (this.double_0 == class2192_0.double_0 && this.double_1 == class2192_0.double_1)
			{
				result = 0;
			}
			else if (this.int_0 > class2192_0.int_0)
			{
				result = 1;
			}
			else if (this.int_0 < class2192_0.int_0)
			{
				result = -1;
			}
			else
			{
				result = CgAlgorithms.ComputeOrientation(class2192_0.coordinate_0, class2192_0.coordinate_1, this.coordinate_1);
			}
			return result;
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public  void vmethod_11()
		{
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x000DFC3C File Offset: 0x000DDE3C
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('[');
			stringBuilder.Append(this.coordinate_0.X);
			stringBuilder.Append(' ');
			stringBuilder.Append(this.coordinate_1.Y);
			stringBuilder.Append(']');
			return stringBuilder.ToString();
		}

		// Token: 0x0400110B RID: 4363
		private double double_0;

		// Token: 0x0400110C RID: 4364
		private double double_1;

		// Token: 0x0400110D RID: 4365
		private Class2199 class2199_0;

		// Token: 0x0400110E RID: 4366
		private Class2217 class2217_0;

		// Token: 0x0400110F RID: 4367
		private Class2200 class2200_0;

		// Token: 0x04001110 RID: 4368
		private Coordinate coordinate_0;

		// Token: 0x04001111 RID: 4369
		private Coordinate coordinate_1;

		// Token: 0x04001112 RID: 4370
		private int int_0;
	}
}
