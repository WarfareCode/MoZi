using System;
using System.Drawing;
using ns16;

namespace ns18
{
	// Token: 0x02000386 RID: 902
	public sealed class Class1954
	{
		// Token: 0x060015AE RID: 5550 RVA: 0x0008C214 File Offset: 0x0008A414
		public GeographicBoundingBox method_0()
		{
			GeographicBoundingBox result;
			if (this.class1949_0 != null && this.class1949_0.class1953_0 != null && this.class1949_0.class1953_0.Length != 0)
			{
				double x = this.class1949_0.class1953_0[0].X;
				double x2 = this.class1949_0.class1953_0[0].X;
				double y = this.class1949_0.class1953_0[0].Y;
				double y2 = this.class1949_0.class1953_0[0].Y;
				double num = this.class1949_0.class1953_0[0].Z;
				double num2 = this.class1949_0.class1953_0[0].Z;
				for (int i = 1; i < this.class1949_0.class1953_0.Length; i++)
				{
					if (this.class1949_0.class1953_0[i].X < x)
					{
						x = this.class1949_0.class1953_0[i].X;
					}
					if (this.class1949_0.class1953_0[i].X > x2)
					{
						x2 = this.class1949_0.class1953_0[i].X;
					}
					if (this.class1949_0.class1953_0[i].Y < y)
					{
						y = this.class1949_0.class1953_0[i].Y;
					}
					if (this.class1949_0.class1953_0[i].Y > y2)
					{
						y2 = this.class1949_0.class1953_0[i].Y;
					}
					if (this.class1949_0.class1953_0[i].Z < num)
					{
						num = this.class1949_0.class1953_0[i].Y;
					}
					if (this.class1949_0.class1953_0[i].Z > num2)
					{
						num2 = this.class1949_0.class1953_0[i].Y;
					}
				}
				result = new GeographicBoundingBox(y2, y, x, x2, num, num2);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x040008F8 RID: 2296
		public Class1949 class1949_0;

		// Token: 0x040008F9 RID: 2297
		public Class1949[] class1949_1;

		// Token: 0x040008FA RID: 2298
		public Color color_0 = Color.Red;

		// Token: 0x040008FB RID: 2299
		public Color color_1 = Color.Black;

		// Token: 0x040008FC RID: 2300
		public float float_0 = 1f;

		// Token: 0x040008FD RID: 2301
		public bool bool_0 = true;

		// Token: 0x040008FE RID: 2302
		public bool bool_1 = true;

		// Token: 0x040008FF RID: 2303
		public bool bool_2 = true;

		// Token: 0x04000900 RID: 2304
		public bool bool_3;

		// Token: 0x04000901 RID: 2305
		public RenderableObject class1993_0;
	}
}
