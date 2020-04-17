using System;
using Microsoft.DirectX;
using ns18;

namespace ns19
{
	// Token: 0x020003D1 RID: 977
	public sealed class Frustum
	{
		// Token: 0x06001835 RID: 6197 RVA: 0x00096900 File Offset: 0x00094B00
		public void Update(Matrix m)
		{
			this.planes[0] = new Plane(m.M14 + m.M12, m.M24 + m.M22, m.M34 + m.M32, m.M44 + m.M42);
			this.planes[1] = new Plane(m.M14 - m.M13, m.M24 - m.M23, m.M34 - m.M33, m.M44 - m.M43);
			this.planes[2] = new Plane(m.M14 - m.M11, m.M24 - m.M21, m.M34 - m.M31, m.M44 - m.M41);
			this.planes[3] = new Plane(m.M14 + m.M11, m.M24 + m.M21, m.M34 + m.M31, m.M44 + m.M41);
			this.planes[4] = new Plane(m.M13, m.M23, m.M33, m.M43);
			this.planes[5] = new Plane(m.M14 - m.M12, m.M24 - m.M22, m.M34 - m.M32, m.M44 - m.M42);
			Plane[] array = this.planes;
			for (int i = 0; i < array.Length; i++)
			{
				Plane plane = array[i];
				plane.Normalize();
			}
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00096B04 File Offset: 0x00094D04
		public bool ContainsPoint(Vector3 v)
		{
			Plane[] array = this.planes;
			bool result;
			for (int i = 0; i < array.Length; i++)
			{
				Plane plane = array[i];
				if (Vector3.Dot(new Vector3(plane.A, plane.B, plane.C), v) + plane.D < 0f)
				{
					result = false;
					return result;
				}
			}
			result = true;
			return result;
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00096B70 File Offset: 0x00094D70
		public bool Contains(BoundingBox bb)
		{
			Plane[] array = this.planes;
			int i = 0;
			IL_89:
			bool result;
			while (i < array.Length)
			{
				Plane plane = array[i];
				Vector3 left = new Vector3(plane.A, plane.B, plane.C);
				bool flag = false;
				for (int j = 0; j < 8; j++)
				{
					if (Vector3.Dot(left, bb.corners[j]) + plane.D >= 0f)
					{
						i++;
						goto IL_89;
					}
				}
				if (!flag)
				{
					result = false;
					return result;
				}
				i++;
			}
			result = true;
			return result;
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00096C1C File Offset: 0x00094E1C
		public override string ToString()
		{
			return string.Format("Near:\n{0}Far:\n{1}", this.planes[4], this.planes[1]);
		}

		// Token: 0x040009F8 RID: 2552
		public Plane[] planes = new Plane[6];
	}
}
