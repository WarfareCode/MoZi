using System;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using ns14;

namespace ns12
{
	// Token: 0x02000394 RID: 916
	public sealed class Class593 : Class592
	{
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x0008DBF4 File Offset: 0x0008BDF4
		public override int Count
		{
			get
			{
				return this.double_0.Length / this.int_0;
			}
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x0000F39D File Offset: 0x0000D59D
		public Class593(double[] double_1, int int_1)
		{
			if (int_1 < 2)
			{
				throw new ArgumentException("Must have at least 2 dimensions");
			}
			if (double_1.Length % int_1 != 0)
			{
				throw new ArgumentException("Packed array does not contain an integral number of coordinates");
			}
			this.int_0 = int_1;
			this.double_0 = double_1;
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x0008DC14 File Offset: 0x0008BE14
		public Class593(ICoordinate[] icoordinate_0, int int_1)
		{
			if (icoordinate_0 == null)
			{
				icoordinate_0 = new ICoordinate[0];
			}
			this.int_0 = int_1;
			this.double_0 = new double[icoordinate_0.Length * this.int_0];
			for (int i = 0; i < icoordinate_0.Length; i++)
			{
				this.double_0[i * this.int_0] = icoordinate_0[i].imethod_0();
				if (this.int_0 >= 2)
				{
					this.double_0[i * this.int_0 + 1] = icoordinate_0[i].imethod_2();
				}
				if (this.int_0 >= 3)
				{
					this.double_0[i * this.int_0 + 2] = icoordinate_0[i].imethod_4();
				}
			}
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0008DCC4 File Offset: 0x0008BEC4
		protected override ICoordinate vmethod_0(int int_1)
		{
			double num = this.double_0[int_1 * this.int_0];
			double double_ = this.double_0[int_1 * this.int_0 + 1];
			double double_2 = (this.int_0 == 2) ? 0.0 : this.double_0[int_1 * this.int_0 + 2];
			return new Coordinate(num, double_, double_2);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0008DD24 File Offset: 0x0008BF24
		public override object Clone()
		{
			double[] array = new double[this.double_0.Length];
			Array.Copy(this.double_0, array, this.double_0.Length);
			return new Class593(array, this.int_0);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x0008DD64 File Offset: 0x0008BF64
		public override double imethod_1(int int_1, Enum142 enum142_0)
		{
			return this.double_0[(int)(int_1 * this.int_0 + enum142_0)];
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x0000F3DC File Offset: 0x0000D5DC
		public override void imethod_2(int int_1, Enum142 enum142_0, double double_1)
		{
			this.weakReference_0 = null;
			this.double_0[(int)(int_1 * this.int_0 + enum142_0)] = double_1;
		}

		// Token: 0x0400093A RID: 2362
		private double[] double_0;
	}
}
