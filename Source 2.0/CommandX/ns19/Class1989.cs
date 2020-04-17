using System;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using ns18;

namespace ns19
{
	// Token: 0x0200046D RID: 1133
	public sealed class Class1989 : Class1988
	{
		// Token: 0x06001D58 RID: 7512 RVA: 0x000120B5 File Offset: 0x000102B5
		public Class1989(Vector3 vector3_2, double double_7) : base(vector3_2, double_7)
		{
			this.struct64_1 = this.m_Orientation;
			this.double_6 = this._distance;
			this.double_5 = this._altitude;
			this.struct63_14 = this._tilt;
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x000BD430 File Offset: 0x000BB630
		public override void RotationYawPitchRoll(Angle struct63_20, Angle struct63_21, Angle struct63_22)
		{
			if (World.Settings.bool_22)
			{
				this.struct63_17 = Angle.Addition(this.struct63_17, Angle.Divide(struct63_21, 100.0));
				this.struct63_18 = Angle.Addition(this.struct63_18, Angle.Divide(struct63_20, 100.0));
				this.struct63_19 = Angle.Addition(this.struct63_19, Angle.Divide(struct63_22, 100.0));
			}
			this.struct64_1 = Quaternion4d.Plus(Quaternion4d.EulerToQuaternion(struct63_20.Radians, struct63_21.Radians, struct63_22.Radians), this.struct64_1);
			Point3d point3d = Quaternion4d.QuaternionToEuler(this.struct64_1);
			if (!double.IsNaN(point3d.Y))
			{
				this.struct63_10.Radians = point3d.Y;
				this.struct63_11.Radians = point3d.X;
				if (!World.Settings.bool_23)
				{
					this.struct63_12.Radians = point3d.Z;
				}
			}
			base.RotationYawPitchRoll(struct63_20, struct63_21, struct63_22);
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x000BD538 File Offset: 0x000BB738
		public override void Pan(Angle struct63_20, Angle struct63_21)
		{
			if (World.Settings.bool_22)
			{
				this.struct63_17 = Angle.Addition(this.struct63_17, Angle.Divide(struct63_20, 100.0));
				this.struct63_18 = Angle.Addition(this.struct63_18, Angle.Divide(struct63_21, 100.0));
			}
			if (Angle.IsNaN(struct63_20))
			{
				struct63_20 = this.struct63_10;
			}
			if (Angle.IsNaN(struct63_21))
			{
				struct63_21 = this.struct63_11;
			}
			struct63_20 = Angle.Addition(struct63_20, this.struct63_10);
			struct63_21 = Angle.Addition(struct63_21, this.struct63_11);
			if (Math.Abs(struct63_20.Radians) > 1.5697963267948967)
			{
				struct63_20.Radians = (double)Math.Sign(struct63_20.Radians) * 1.5697963267948967;
			}
			this.struct64_1 = Quaternion4d.EulerToQuaternion(struct63_21.Radians, struct63_20.Radians, this.struct63_12.Radians);
			Point3d point3d = Quaternion4d.QuaternionToEuler(this.struct64_1);
			if (!double.IsNaN(point3d.Y))
			{
				this.struct63_10.Radians = point3d.Y;
				this.struct63_11.Radians = point3d.X;
				this.struct63_12.Radians = point3d.Z;
				if (!World.Settings.bool_21)
				{
					this._latitude = this.struct63_10;
					this._longitude = this.struct63_11;
					this._heading = this.struct63_12;
					this.m_Orientation = this.struct64_1;
				}
			}
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x000120EF File Offset: 0x000102EF
		public override bool Update(Device device_0)
		{
			if (World.Settings.bool_22)
			{
				base.RotationYawPitchRoll(this.struct63_18, this.struct63_17, this.struct63_19);
			}
			return base.Update(device_0);
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x000BD6BC File Offset: 0x000BB8BC
		public override void SetPosition(double double_7, double double_8, double double_9, double double_10, double double_11, double double_12)
		{
			this.struct63_17.Radians = 0.0;
			this.struct63_18.Radians = 0.0;
			this.struct63_19.Radians = 0.0;
			base.SetPosition(double_7, double_8, double_9, double_10, double_11, double_12);
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x000BD714 File Offset: 0x000BB914
		public override string ToString()
		{
			return base.ToString() + string.Format("\nMomentum: {0}, {1}, {2}", this.struct63_17, this.struct63_18, this.struct63_19);
		}

		// Token: 0x04000D08 RID: 3336
		protected Angle struct63_17;

		// Token: 0x04000D09 RID: 3337
		protected Angle struct63_18;

		// Token: 0x04000D0A RID: 3338
		protected Angle struct63_19;
	}
}
