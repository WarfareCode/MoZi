using System;
using System.Drawing;
using ns16;

namespace ns18
{
	// Token: 0x02000370 RID: 880
	public sealed class Class1950
	{
		// Token: 0x060014FF RID: 5375 RVA: 0x0008A930 File Offset: 0x00088B30
		public GeographicBoundingBox method_0()
		{
			GeographicBoundingBox result;
			if (this.class1953_0 != null && this.class1953_0.Length != 0)
			{
				double x = this.class1953_0[0].X;
				double x2 = this.class1953_0[0].X;
				double y = this.class1953_0[0].Y;
				double y2 = this.class1953_0[0].Y;
				double z = this.class1953_0[0].Z;
				double z2 = this.class1953_0[0].Z;
				for (int i = 1; i < this.class1953_0.Length; i++)
				{
					if (this.class1953_0[i].X < x)
					{
						x = this.class1953_0[i].X;
					}
					if (this.class1953_0[i].X > x2)
					{
						x2 = this.class1953_0[i].X;
					}
					if (this.class1953_0[i].Y < y)
					{
						y = this.class1953_0[i].Y;
					}
					if (this.class1953_0[i].Y > y2)
					{
						y2 = this.class1953_0[i].Y;
					}
					if (this.class1953_0[i].Z < z)
					{
						z = this.class1953_0[i].Z;
					}
					if (this.class1953_0[i].Z > z2)
					{
						z2 = this.class1953_0[i].Z;
					}
				}
				result = new GeographicBoundingBox(y2, y, x, x2, z, z2);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x040008DB RID: 2267
		public Point3d[] class1953_0;

		// Token: 0x040008DC RID: 2268
		public Color color_0 = Color.Yellow;

		// Token: 0x040008DD RID: 2269
		public float float_0 = 1f;

		// Token: 0x040008DE RID: 2270
		public bool bool_0 = true;

		// Token: 0x040008DF RID: 2271
		public bool bool_1;

		// Token: 0x040008E0 RID: 2272
		public RenderableObject class1993_0;
	}
}
