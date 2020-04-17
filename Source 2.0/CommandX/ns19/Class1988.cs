using System;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using ns18;

namespace ns19
{
	// Token: 0x0200046B RID: 1131
	public class Class1988 : CameraBase
	{
		// Token: 0x06001D41 RID: 7489 RVA: 0x000BC780 File Offset: 0x000BA980
		public Class1988(Vector3 vector3_2, double double_7) : base(vector3_2, double_7)
		{
			this.struct64_1 = this.m_Orientation;
			this.double_6 = this._distance;
			this.double_5 = this._altitude;
			this.struct63_14 = this._tilt;
			this.struct63_15 = this._fov;
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x000BC7F0 File Offset: 0x000BA9F0
		public override void SetPosition(double double_7, double double_8, double double_9, double double_10, double double_11, double double_12)
		{
			if (double.IsNaN(double_7))
			{
				double_7 = this._latitude.GetDegrees();
			}
			if (double.IsNaN(double_8))
			{
				double_8 = this._longitude.GetDegrees();
			}
			if (double.IsNaN(double_9))
			{
				double_9 = this._heading.GetDegrees();
			}
			if (double.IsNaN(double_12))
			{
				double_12 = this.struct63_13.GetDegrees();
			}
			this.struct64_1 = Quaternion4d.EulerToQuaternion(MathEngine.DegreesToRadians(double_8), MathEngine.DegreesToRadians(double_7), MathEngine.DegreesToRadians(double_9));
			Point3d point3d = Quaternion4d.QuaternionToEuler(this.struct64_1);
			this.struct63_10.Radians = point3d.Y;
			this.struct63_11.Radians = point3d.X;
			this.struct63_12.Radians = point3d.Z;
			if (!double.IsNaN(double_11))
			{
				this.SetTilt(Angle.FromDegrees(double_11));
			}
			if (!double.IsNaN(double_10))
			{
				this.vmethod_9(double_10);
			}
			this.SetBank(Angle.FromDegrees(double_12));
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x000B5D60 File Offset: 0x000B3F60
		public override Angle GetHeading()
		{
			return this._heading;
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x0001207E File Offset: 0x0001027E
		public override void SetHeading(Angle struct63_17)
		{
			this._heading = struct63_17;
			this.struct63_12 = struct63_17;
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x000BC8F0 File Offset: 0x000BAAF0
		protected void method_8(double double_7)
		{
			double num = Quaternion4d.Dot(this.m_Orientation, this.struct64_1);
			if (num > 1.0)
			{
				num = 1.0;
			}
			else if (num < -1.0)
			{
				num = -1.0;
			}
			this.struct63_16 = Angle.FromRadians(Math.Acos(num));
			this.m_Orientation = Quaternion4d.Slerp(this.m_Orientation, this.struct64_1, double_7);
			this._tilt = Angle.Addition(this._tilt, Angle.Multiply(Angle.Minus(this.struct63_14, this._tilt), double_7));
			this._bank = Angle.Addition(this._bank, Angle.Multiply(Angle.Minus(this.struct63_13, this._bank), double_7));
			this._distance += (this.double_6 - this._distance) * double_7;
			base.ComputeAltitude(this._distance, this._tilt);
			this._fov = Angle.Addition(this._fov, Angle.Multiply(Angle.Minus(this.struct63_15, this._fov), double_7));
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x000BCA18 File Offset: 0x000BAC18
		public  double GetTargetAltitude()
		{
			return this.double_5;
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x000BCA30 File Offset: 0x000BAC30
		public override void SetTargetAltitude(double double_7)
		{
			if (double_7 < (double)((float)this._terrainElevation * World.Settings.GetVerticalExaggeration() + 100f))
			{
				double_7 = (double)((float)this._terrainElevation * World.Settings.GetVerticalExaggeration() + 100f);
			}
			if (double_7 > 7.0 * this._worldRadius)
			{
				double_7 = 7.0 * this._worldRadius;
			}
			this.double_5 = double_7;
			this.method_9(this.double_5, this.struct63_14);
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x000BCABC File Offset: 0x000BACBC
		public override Angle GetFov()
		{
			return this.struct63_15;
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x000BCAD4 File Offset: 0x000BACD4
		public override void SetFov(Angle struct63_17)
		{
			if (Angle.IsLargerThan(struct63_17, World.Settings.cameraFovMax))
			{
				struct63_17 = World.Settings.cameraFovMax;
			}
			if (Angle.IsLittleThan(struct63_17, World.Settings.cameraFovMin))
			{
				struct63_17 = World.Settings.cameraFovMin;
			}
			this.struct63_15 = struct63_17;
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x000BCB2C File Offset: 0x000BAD2C
		public override bool Update(Device device_0)
		{
			if (this._altitude < (double)((float)this._terrainElevation * World.Settings.GetVerticalExaggeration()) + CameraBase.minimumAltitude)
			{
				this.double_5 = (double)((float)this._terrainElevation * World.Settings.GetVerticalExaggeration()) + CameraBase.minimumAltitude;
				this.method_9(this.double_5, this.struct63_14);
			}
			this.method_8((double)World.Settings.float_5);
			return base.Update(device_0);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x000BCBA8 File Offset: 0x000BADA8
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				base.ToString(),
				string.Format("\nTarget: ({0}, {1} @ {2:f0}m)\nTarget Altitude: {3:f0}m", new object[]
				{
					this.struct63_10,
					this.struct63_11,
					this.double_6,
					this.double_5
				}),
				"\nAngle: ",
				this.struct63_16
			});
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x000BCC30 File Offset: 0x000BAE30
		public override void RotationYawPitchRoll(Angle struct63_17, Angle struct63_18, Angle struct63_19)
		{
			this.struct64_1 = Quaternion4d.Plus(Quaternion4d.EulerToQuaternion(struct63_17.Radians, struct63_18.Radians, struct63_19.Radians), this.struct64_1);
			Point3d point3d = Quaternion4d.QuaternionToEuler(this.struct64_1);
			if (!double.IsNaN(point3d.Y))
			{
				this.struct63_10.Radians = point3d.Y;
			}
			if (!double.IsNaN(point3d.X))
			{
				this.struct63_11.Radians = point3d.X;
			}
			if (Math.Abs(struct63_19.Radians) > 4.94065645841247E-324)
			{
				this.struct63_12.Radians = point3d.Z;
			}
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x000BCCE0 File Offset: 0x000BAEE0
		public override Angle GetBank()
		{
			return this.struct63_13;
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x0001208E File Offset: 0x0001028E
		public override void SetBank(Angle struct63_17)
		{
			if (!Angle.IsNaN(struct63_17))
			{
				this.struct63_13 = struct63_17;
				if (!World.Settings.bool_21)
				{
					this._bank = struct63_17;
				}
			}
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x000BCCF8 File Offset: 0x000BAEF8
		public override Angle GetTilt()
		{
			return this.struct63_14;
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x000BCD10 File Offset: 0x000BAF10
		public override void SetTilt(Angle struct63_17)
		{
			if (Angle.IsLargerThan(struct63_17, CameraBase.maxTilt))
			{
				struct63_17 = CameraBase.maxTilt;
			}
			else if (Angle.IsLittleThan(struct63_17, CameraBase.minTilt))
			{
				struct63_17 = CameraBase.minTilt;
			}
			this.struct63_14 = struct63_17;
			this.method_10(this.double_6, this.struct63_14);
			if (!World.Settings.bool_21)
			{
				this._tilt = struct63_17;
			}
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x000BCD7C File Offset: 0x000BAF7C
		public  double GetTargetDistance()
		{
			return this.double_6;
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x000BCD94 File Offset: 0x000BAF94
		public override void SetTargetDistance(double double_7)
		{
			if (double_7 < CameraBase.minimumAltitude + (double)((float)this._terrainElevation * World.Settings.GetVerticalExaggeration()))
			{
				double_7 = CameraBase.minimumAltitude + (double)((float)this.GetTerrainElevation() * World.Settings.GetVerticalExaggeration());
			}
			if (double_7 > CameraBase.maximumAltitude)
			{
				double_7 = CameraBase.maximumAltitude;
			}
			this.double_6 = double_7;
			this.method_10(this.double_6, this.struct63_14);
			if (!World.Settings.bool_21)
			{
				this._distance = this.double_6;
				this._altitude = this.double_5;
			}
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x000BCE30 File Offset: 0x000BB030
		public override void Zoom(float float_2)
		{
			if (float_2 > 0f)
			{
				double num = (double)(1f + float_2);
				this.SetTargetAltitude(this.GetTargetAltitude() / num);
			}
			else
			{
				double num2 = (double)(1f - float_2);
				this.SetTargetAltitude(this.GetTargetAltitude() * num2);
			}
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x000BCE7C File Offset: 0x000BB07C
		protected void method_9(double double_7, Angle struct63_17)
		{
			double num = Math.Cos(3.1415926535897931 - struct63_17.Radians);
			double num2 = this._worldRadius * num;
			double num3 = this._worldRadius + double_7;
			double num4 = Math.Sqrt(this._worldRadius * this._worldRadius * num * num + num3 * num3 - this._worldRadius * this._worldRadius);
			double num5 = num2 - num4;
			if (num5 < 0.0)
			{
				num5 = num2 + num4;
			}
			this.double_6 = num5;
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x000BCF00 File Offset: 0x000BB100
		protected void method_10(double double_7, Angle struct63_17)
		{
			double num = Math.Sqrt(this._worldRadius * this._worldRadius + double_7 * double_7 - 2.0 * this._worldRadius * double_7 * Math.Cos(3.1415926535897931 - struct63_17.Radians)) - this._worldRadius;
			if (num < CameraBase.minimumAltitude + (double)((float)this._terrainElevation * World.Settings.GetVerticalExaggeration()))
			{
				num = CameraBase.minimumAltitude + (double)((float)this._terrainElevation * World.Settings.GetVerticalExaggeration());
			}
			else if (num > CameraBase.maximumAltitude)
			{
				num = CameraBase.maximumAltitude;
			}
			this.double_5 = num;
		}

		// Token: 0x04000CF9 RID: 3321
		protected Angle struct63_10;

		// Token: 0x04000CFA RID: 3322
		protected Angle struct63_11;

		// Token: 0x04000CFB RID: 3323
		protected double double_5 = 0.0;

		// Token: 0x04000CFC RID: 3324
		protected double double_6 = 0.0;

		// Token: 0x04000CFD RID: 3325
		protected Angle struct63_12;

		// Token: 0x04000CFE RID: 3326
		protected Angle struct63_13;

		// Token: 0x04000CFF RID: 3327
		protected Angle struct63_14;

		// Token: 0x04000D00 RID: 3328
		protected Angle struct63_15;

		// Token: 0x04000D01 RID: 3329
		protected Quaternion4d struct64_1;

		// Token: 0x04000D02 RID: 3330
		private Angle struct63_16;
	}
}
