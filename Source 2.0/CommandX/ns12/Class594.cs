using System;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using ns14;

namespace ns12
{
	// Token: 0x02000396 RID: 918
	public sealed class Class594 : Class592
	{
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x0008DE84 File Offset: 0x0008C084
		public override int Count
		{
			get
			{
				return this.float_0.Length / this.int_0;
			}
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0000F3F7 File Offset: 0x0000D5F7
		public Class594(float[] float_1, int int_1)
		{
			if (int_1 < 2)
			{
				throw new ArgumentException("Must have at least 2 dimensions");
			}
			if (float_1.Length % int_1 != 0)
			{
				throw new ArgumentException("Packed array does not contain an integral number of coordinates");
			}
			this.int_0 = int_1;
			this.float_0 = float_1;
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0008DEA4 File Offset: 0x0008C0A4
		public Class594(ICoordinate[] icoordinate_0, int int_1)
		{
			if (icoordinate_0 == null)
			{
				icoordinate_0 = new ICoordinate[0];
			}
			this.int_0 = int_1;
			this.float_0 = new float[icoordinate_0.Length * this.int_0];
			for (int i = 0; i < icoordinate_0.Length; i++)
			{
				this.float_0[i * this.int_0] = (float)icoordinate_0[i].imethod_0();
				if (this.int_0 >= 2)
				{
					this.float_0[i * this.int_0 + 1] = (float)icoordinate_0[i].imethod_2();
				}
				if (this.int_0 >= 3)
				{
					this.float_0[i * this.int_0 + 2] = (float)icoordinate_0[i].imethod_4();
				}
			}
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x0008DF58 File Offset: 0x0008C158
		protected override ICoordinate vmethod_0(int int_1)
		{
			double double_ = (double)this.float_0[int_1 * this.int_0];
			double double_2 = (double)this.float_0[int_1 * this.int_0 + 1];
			double double_3 = (this.int_0 == 2) ? 0.0 : ((double)this.float_0[int_1 * this.int_0 + 2]);
			return new Coordinate(double_, double_2, double_3);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0008DFBC File Offset: 0x0008C1BC
		public override object Clone()
		{
			float[] array = new float[this.float_0.Length];
			Array.Copy(this.float_0, array, this.float_0.Length);
			return new Class594(array, this.int_0);
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x0008DFFC File Offset: 0x0008C1FC
		public override double imethod_1(int int_1, Enum142 enum142_0)
		{
			return (double)this.float_0[(int)(int_1 * this.int_0 + enum142_0)];
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x0000F436 File Offset: 0x0000D636
		public override void imethod_2(int int_1, Enum142 enum142_0, double double_0)
		{
			this.weakReference_0 = null;
			this.float_0[(int)(int_1 * this.int_0 + enum142_0)] = (float)double_0;
		}

		// Token: 0x0400093B RID: 2363
		private float[] float_0;
	}
}
