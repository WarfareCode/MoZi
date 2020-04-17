using System;
using Microsoft.DirectX;
using ns19;

namespace ns18
{
	// Token: 0x02000352 RID: 850
	public sealed class BoundingBox
	{
		// Token: 0x060013EF RID: 5103 RVA: 0x00085B14 File Offset: 0x00083D14
		public BoundingBox(Vector3 vector3_1, Vector3 vector3_2, Vector3 vector3_3, Vector3 vector3_4, Vector3 vector3_5, Vector3 vector3_6, Vector3 vector3_7, Vector3 vector3_8)
		{
			this.corners = new Vector3[8];
			this.corners[0] = vector3_1;
			this.corners[1] = vector3_2;
			this.corners[2] = vector3_3;
			this.corners[3] = vector3_4;
			this.corners[4] = vector3_5;
			this.corners[5] = vector3_6;
			this.corners[6] = vector3_7;
			this.corners[7] = vector3_8;
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00085BC8 File Offset: 0x00083DC8
		public BoundingBox(float float_0, float float_1, float float_2, float float_3, float float_4, float float_5)
		{
			float scalingFactor = float_5 / float_4;
			this.corners = new Vector3[8];
			this.corners[0] = MathEngine.SphericalToCartesian((double)float_0, (double)float_2, (double)float_4);
			this.corners[1] = Vector3.Scale(this.corners[0], scalingFactor);
			this.corners[2] = MathEngine.SphericalToCartesian((double)float_0, (double)float_3, (double)float_4);
			this.corners[3] = Vector3.Scale(this.corners[2], scalingFactor);
			this.corners[4] = MathEngine.SphericalToCartesian((double)float_1, (double)float_2, (double)float_4);
			this.corners[5] = Vector3.Scale(this.corners[4], scalingFactor);
			this.corners[6] = MathEngine.SphericalToCartesian((double)float_1, (double)float_3, (double)float_4);
			this.corners[7] = Vector3.Scale(this.corners[6], scalingFactor);
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00085D04 File Offset: 0x00083F04
		public float method_0(CameraBase class1987_0)
		{
			Vector3 right = class1987_0.Project(this.corners[0]);
			Vector3 left = class1987_0.Project(this.corners[2]);
			Vector3 left2 = class1987_0.Project(this.corners[6]);
			Vector3 left3 = class1987_0.Project(this.corners[4]);
			Vector3 left4 = Vector3.Subtract(left, right);
			Vector3 right2 = Vector3.Subtract(left2, right);
			Vector3 left5 = Vector3.Subtract(left3, right);
			float num = Vector3.Cross(left4, right2).LengthSq();
			float num2 = Vector3.Cross(left5, right2).LengthSq();
			return num + num2;
		}

		// Token: 0x0400083B RID: 2107
		public Vector3[] corners;
	}
}
