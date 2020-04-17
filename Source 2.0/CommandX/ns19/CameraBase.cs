using System;
using System.Globalization;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using ns18;

namespace ns19
{
	// Token: 0x02000466 RID: 1126
	public class CameraBase
	{
		// Token: 0x06001CD8 RID: 7384 RVA: 0x000B5AF0 File Offset: 0x000B3CF0
		public CameraBase(Vector3 targetPosition, double radius)
		{
			this._worldRadius = radius;
			this._distance = 2.0 * this._worldRadius;
			this._altitude = this._distance;
			CameraBase.maximumAltitude = 20.0 * this._worldRadius;
			this.m_Orientation = Quaternion4d.EulerToQuaternion(0.0, 0.0, 0.0);
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x000B5BF0 File Offset: 0x000B3DF0
		public Viewport GetViewport()
		{
			return this.viewPort;
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x000B5C08 File Offset: 0x000B3E08
		public Matrix GetViewMatrix()
		{
			return this.m_ViewMatrix;
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x000B5C20 File Offset: 0x000B3E20
		public Matrix GetProjectionMatrix()
		{
			return this.m_ProjectionMatrix;
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x000B5C38 File Offset: 0x000B3E38
		public Matrix GetWorldMatrix()
		{
			return this.m_WorldMatrix;
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x000B5C50 File Offset: 0x000B3E50
		public virtual Angle GetLatitude()
		{
			return this._latitude;
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x000B5C68 File Offset: 0x000B3E68
		public virtual Angle GetLongitude()
		{
			return this._longitude;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x000B5C80 File Offset: 0x000B3E80
		public virtual Angle GetTilt()
		{
			return this._tilt;
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x000B5C98 File Offset: 0x000B3E98
		public virtual void SetTilt(Angle value)
		{
			if (Angle.IsLargerThan(value, CameraBase.maxTilt))
			{
				value = CameraBase.maxTilt;
			}
			else if (Angle.IsLittleThan(value, CameraBase.minTilt))
			{
				value = CameraBase.minTilt;
			}
			this._tilt = value;
			this.ComputeAltitude(this._distance, this._tilt);
			if (this._altitude < (double)((float)this._terrainElevation * World.Settings.GetVerticalExaggeration()) + CameraBase.minimumAltitude)
			{
				this._altitude = (double)((float)this._terrainElevation * World.Settings.GetVerticalExaggeration()) + CameraBase.minimumAltitude;
				this.ComputeTilt(this._altitude, this._distance);
			}
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x000B5D48 File Offset: 0x000B3F48
		public virtual Angle GetBank()
		{
			return this._bank;
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00011F4C File Offset: 0x0001014C
		public virtual void SetBank(Angle value)
		{
			if (!Angle.IsNaN(value))
			{
				this._bank = value;
			}
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x000B5D60 File Offset: 0x000B3F60
		public virtual Angle GetHeading()
		{
			return this._heading;
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00011F60 File Offset: 0x00010160
		public virtual void SetHeading(Angle value)
		{
			this._heading = value;
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x000B5D78 File Offset: 0x000B3F78
		public  double GetAltitude()
		{
			return this._altitude;
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00011F69 File Offset: 0x00010169
		public  void vmethod_9(double double_5)
		{
			this.SetTargetAltitude(double_5);
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x000B5D90 File Offset: 0x000B3F90
		public  double GetAltitudeAboveTerrain()
		{
			return this._altitude - (double)this._terrainElevation;
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x000B5D78 File Offset: 0x000B3F78
		public  double GetTargetAltitude()
		{
			return this._altitude;
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x000B5DB0 File Offset: 0x000B3FB0
		public virtual void SetTargetAltitude(double value)
		{
			if (value < (double)((float)this._terrainElevation * World.Settings.GetVerticalExaggeration()) + CameraBase.minimumAltitude)
			{
				value = (double)((float)this._terrainElevation * World.Settings.GetVerticalExaggeration()) + CameraBase.minimumAltitude;
			}
			if (value > CameraBase.maximumAltitude)
			{
				value = CameraBase.maximumAltitude;
			}
			this._altitude = value;
			this.ComputeDistance(this._altitude, this._tilt);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x000B5E28 File Offset: 0x000B4028
		public virtual short GetTerrainElevation()
		{
			return this._terrainElevation;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00011F72 File Offset: 0x00010172
		public virtual void SetTerrainElevation(short value)
		{
			this._terrainElevation = value;
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x000B5E40 File Offset: 0x000B4040
		public virtual Angle GetViewRange()
		{
			return this.viewRange;
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x000B5E58 File Offset: 0x000B4058
		public virtual Angle GetTrueViewRange()
		{
			return this.trueViewRange;
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x000B5E70 File Offset: 0x000B4070
		public virtual Vector3 GetPosition()
		{
			return this._position;
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x000B5E88 File Offset: 0x000B4088
		public  double GetWorldRadius()
		{
			return this._worldRadius;
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x000B5EA0 File Offset: 0x000B40A0
		public virtual void ComputeAbsoluteMatrices()
		{
			this.m_absoluteWorldMatrix = Matrix.Identity;
			float aspectRatio = (float)this.viewPort.Width / (float)this.viewPort.Height;
			float znearPlane = (float)this._altitude * 0.1f;
			double num = this._altitude + this.GetWorldRadius();
			double num2 = Math.Sqrt(num * num - this._worldRadius * this._worldRadius);
			this.m_absoluteProjectionMatrix = Matrix.PerspectiveFovRH((float)this._fov.Radians, aspectRatio, znearPlane, (float)num2);
			this.m_absoluteViewMatrix = Matrix.LookAtRH(MathEngine.SphericalToCartesian(this._latitude.GetDegrees(), this._longitude.GetDegrees(), this.GetWorldRadius()), Vector3.Empty, new Vector3(0f, 0f, 1f));
			this.m_absoluteViewMatrix *= Matrix.RotationYawPitchRoll(0f, -(float)this._tilt.Radians, (float)this._heading.Radians);
			this.m_absoluteViewMatrix *= Matrix.Translation(0f, 0f, (float)((double)(-(double)((float)this._distance)) - (double)this.curCameraElevation));
			this.m_absoluteViewMatrix *= Matrix.RotationZ((float)this._bank.Radians);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x000B5FF0 File Offset: 0x000B41F0
		public virtual void ComputeViewMatrix()
		{
			this.ComputeAbsoluteMatrices();
			if (World.Settings.GetElevateCameraLookatPoint())
			{
				int num = 10;
				this.targetCameraElevation = (float)this.GetTerrainElevation() * World.Settings.GetVerticalExaggeration();
				float num2 = this.targetCameraElevation - this.curCameraElevation;
				if (Math.Abs(num2) > 10f)
				{
					float num3 = 0.05f * num2;
					if (Math.Abs(num3) < (float)num)
					{
						num3 = ((num3 > 0f) ? ((float)num) : (-(float)num));
					}
					this.curCameraElevation += num3;
				}
				else
				{
					this.curCameraElevation = this.targetCameraElevation;
				}
			}
			else
			{
				this.curCameraElevation = 0f;
			}
			double num4 = this.GetWorldRadius() + (double)this.curCameraElevation;
			double num5 = num4 * Math.Cos(this._latitude.Radians);
			CameraBase.LookFrom = new Point3d(num5 * Math.Cos(this._longitude.Radians), num5 * Math.Sin(this._longitude.Radians), num4 * Math.Sin(this._latitude.Radians));
			Point3d point3d = CameraBase.LookFrom.normalize();
			Point3d point3d2 = Point3d.Mult(CameraBase.cameraUpVector, point3d).normalize();
			Point3d point3d3 = Point3d.Mult(point3d, point3d2);
			this.ReferenceCenter = MathEngine.SphericalToCartesianD(Angle.FromRadians((double)Convert.ToSingle(this._latitude.Radians)), Angle.FromRadians((double)Convert.ToSingle(this._longitude.Radians)), this.GetWorldRadius());
			CameraBase.relCameraPos = Point3d.subtraction(CameraBase.LookFrom, this.ReferenceCenter);
			this.m_ViewMatrix.M11 = (float)point3d2.X;
			this.m_ViewMatrix.M21 = (float)point3d2.Y;
			this.m_ViewMatrix.M31 = (float)point3d2.Z;
			this.m_ViewMatrix.M12 = (float)point3d3.X;
			this.m_ViewMatrix.M22 = (float)point3d3.Y;
			this.m_ViewMatrix.M32 = (float)point3d3.Z;
			this.m_ViewMatrix.M13 = (float)point3d.X;
			this.m_ViewMatrix.M23 = (float)point3d.Y;
			this.m_ViewMatrix.M33 = (float)point3d.Z;
			this.m_ViewMatrix.M41 = -(float)(point3d2.X * CameraBase.relCameraPos.X + point3d2.Y * CameraBase.relCameraPos.Y + point3d2.Z * CameraBase.relCameraPos.Z);
			this.m_ViewMatrix.M42 = -(float)(point3d3.X * CameraBase.relCameraPos.X + point3d3.Y * CameraBase.relCameraPos.Y + point3d3.Z * CameraBase.relCameraPos.Z);
			this.m_ViewMatrix.M43 = -(float)(point3d.X * CameraBase.relCameraPos.X + point3d.Y * CameraBase.relCameraPos.Y + point3d.Z * CameraBase.relCameraPos.Z);
			this.m_ViewMatrix.M14 = 0f;
			this.m_ViewMatrix.M24 = 0f;
			this.m_ViewMatrix.M34 = 0f;
			this.m_ViewMatrix.M44 = 1f;
			double num6 = this._distance;
			if (num6 < (double)this.targetCameraElevation + CameraBase.minimumAltitude)
			{
				num6 = (double)this.targetCameraElevation + CameraBase.minimumAltitude;
			}
			this.m_ViewMatrix *= Matrix.RotationYawPitchRoll(0f, -(float)this._tilt.Radians, (float)this._heading.Radians);
			this.m_ViewMatrix *= Matrix.Translation(0f, 0f, (float)((double)(-(double)((float)num6)) + (double)this.curCameraElevation));
			this.m_ViewMatrix *= Matrix.RotationZ((float)this._bank.Radians);
			Matrix matrix = Matrix.Invert(this.m_absoluteViewMatrix);
			this._position = new Vector3(matrix.M41, matrix.M42, matrix.M43);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x000B641C File Offset: 0x000B461C
		public virtual Angle GetFov()
		{
			return this._fov;
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x000B6434 File Offset: 0x000B4634
		public virtual void SetFov(Angle value)
		{
			if (Angle.IsLargerThan(value, World.Settings.cameraFovMax))
			{
				value = World.Settings.cameraFovMax;
			}
			if (Angle.IsLittleThan(value, World.Settings.cameraFovMin))
			{
				value = World.Settings.cameraFovMin;
			}
			this._fov = value;
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000B648C File Offset: 0x000B468C
		public  double GetDistance()
		{
			return this._distance - (double)this._terrainElevation;
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x000B64AC File Offset: 0x000B46AC
		public  double GetTargetDistance()
		{
			return this._distance;
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x000B64C4 File Offset: 0x000B46C4
		public virtual void SetTargetDistance(double value)
		{
			if (value < CameraBase.minimumAltitude)
			{
				value = CameraBase.minimumAltitude;
			}
			if (value > CameraBase.maximumAltitude)
			{
				value = CameraBase.maximumAltitude;
			}
			this._distance = value;
			this.ComputeAltitude(this._distance, this._tilt);
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x000B6514 File Offset: 0x000B4714
		public virtual Frustum GetViewFrustum()
		{
			return this._viewFrustum;
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x000B652C File Offset: 0x000B472C
		public virtual bool Update(Device device)
		{
			bool result = false;
			this.viewPort = device.Viewport;
			Point3d point3d = Quaternion4d.QuaternionToEuler(this.m_Orientation);
			if (!double.IsNaN(point3d.Y))
			{
				this._latitude.Radians = point3d.Y;
			}
			if (!double.IsNaN(point3d.X))
			{
				this._longitude.Radians = point3d.X;
			}
			if (!double.IsNaN(point3d.Z))
			{
				this._heading.Radians = point3d.Z;
			}
			this.ComputeProjectionMatrix(this.viewPort);
			this.ComputeViewMatrix();
			device.Transform.Projection = this.m_ProjectionMatrix;
			device.Transform.View = this.m_ViewMatrix;
			device.Transform.World = this.m_WorldMatrix;
			this.GetViewFrustum().Update(Matrix.Multiply(this.m_absoluteWorldMatrix, Matrix.Multiply(this.m_absoluteViewMatrix, this.m_absoluteProjectionMatrix)));
			double num = this._altitude / this._worldRadius;
			if (num > 1.0)
			{
				this.viewRange = Angle.FromRadians(3.1415926535897931);
			}
			else
			{
				this.viewRange = Angle.FromRadians(Math.Abs(Math.Asin(this._altitude / this._worldRadius)) * 2.0);
			}
			if (num < 1.0)
			{
				this.trueViewRange = Angle.FromRadians(Math.Abs(Math.Asin(this._distance / this._worldRadius)) * 2.0);
			}
			else
			{
				this.trueViewRange = Angle.FromRadians(3.1415926535897931);
			}
			if (World.Settings.double_0 != this.GetAltitude())
			{
				World.Settings.double_0 = this.GetAltitude();
				result = true;
			}
			if (Angle.NotEqual(World.Settings.struct63_0, this._latitude))
			{
				World.Settings.struct63_0 = this._latitude;
				result = true;
			}
			if (Angle.NotEqual(World.Settings.struct63_1, this._longitude))
			{
				World.Settings.struct63_1 = this._longitude;
				result = true;
			}
			if (Angle.NotEqual(World.Settings.struct63_2, this._heading))
			{
				World.Settings.struct63_2 = this._heading;
				result = true;
			}
			if (Angle.NotEqual(World.Settings.struct63_3, this._tilt))
			{
				World.Settings.struct63_3 = this._tilt;
				result = true;
			}
			return result;
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x000B67A4 File Offset: 0x000B49A4
		public virtual void Reset()
		{
			this.SetFov(World.Settings.cameraFov);
			int tickCount = Environment.TickCount;
			if (tickCount - CameraBase.lastResetTime < 3000)
			{
				if (Angle.IsNaN(this._tilt))
				{
					this._tilt.Radians = 0.0;
				}
				if (Angle.IsNaN(this._heading))
				{
					this._heading.Radians = 0.0;
				}
				if (Angle.IsNaN(this._bank))
				{
					this._bank.Radians = 0.0;
				}
				this.SetPosition(double.NaN, double.NaN, 0.0, 2.0 * this._worldRadius, 0.0, 0.0);
			}
			else
			{
				this.SetPosition(double.NaN, double.NaN, 0.0, double.NaN, 0.0, 0.0);
			}
			CameraBase.lastResetTime = tickCount;
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00011F7B File Offset: 0x0001017B
		public virtual void SetPosition(double lat, double lon, double heading, double _altitude, double tilt)
		{
			this.SetPosition(lat, lon, heading, _altitude, tilt, 0.0);
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x000B68D0 File Offset: 0x000B4AD0
		public virtual void SetPosition(double double_5, double double_6, double double_7, double double_8, double double_9, double double_10)
		{
			if (double.IsNaN(double_5))
			{
				double_5 = this._latitude.GetDegrees();
			}
			if (double.IsNaN(double_6))
			{
				double_6 = this._longitude.GetDegrees();
			}
			if (double.IsNaN(double_7))
			{
				double_7 = this._heading.GetDegrees();
			}
			if (double.IsNaN(double_10))
			{
				double_10 = this._bank.GetDegrees();
			}
			this.m_Orientation = Quaternion4d.EulerToQuaternion(MathEngine.DegreesToRadians(double_6), MathEngine.DegreesToRadians(double_5), MathEngine.DegreesToRadians(double_7));
			Point3d point3d = Quaternion4d.QuaternionToEuler(this.m_Orientation);
			this._latitude.Radians = point3d.Y;
			this._longitude.Radians = point3d.X;
			this._heading.Radians = point3d.Z;
			if (!double.IsNaN(double_9))
			{
				this.SetTilt(Angle.FromDegrees(double_9));
			}
			if (!double.IsNaN(double_8))
			{
				this.vmethod_9(double_8);
			}
			this.SetBank(Angle.FromDegrees(double_10));
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x000B69D0 File Offset: 0x000B4BD0
		public virtual void PickingRayIntersection(int screenX, int screenY, out Angle latitude, out Angle longitude)
		{
			Vector3 vector = new Vector3();
			vector.X = (float)screenX;
			vector.Y = (float)screenY;
			vector.Z = this.viewPort.MinZ;
			vector.Unproject(this.viewPort, this.m_absoluteProjectionMatrix, this.m_absoluteViewMatrix, this.m_absoluteWorldMatrix);
			Vector3 vector2 = new Vector3();
			vector2.X = (float)screenX;
			vector2.Y = (float)screenY;
			vector2.Z = this.viewPort.MaxZ;
			vector2.Unproject(this.viewPort, this.m_absoluteProjectionMatrix, this.m_absoluteViewMatrix, this.m_absoluteWorldMatrix);
			Point3d point3d = new Point3d((double)vector.X, (double)vector.Y, (double)vector.Z);
			Point3d point3d2 = new Point3d((double)vector2.X, (double)vector2.Y, (double)vector2.Z);
			double num = (point3d2.X - point3d.X) * (point3d2.X - point3d.X) + (point3d2.Y - point3d.Y) * (point3d2.Y - point3d.Y) + (point3d2.Z - point3d.Z) * (point3d2.Z - point3d.Z);
			double num2 = 2.0 * ((point3d2.X - point3d.X) * point3d.X + (point3d2.Y - point3d.Y) * point3d.Y + (point3d2.Z - point3d.Z) * point3d.Z);
			double num3 = point3d.X * point3d.X + point3d.Y * point3d.Y + point3d.Z * point3d.Z - this._worldRadius * this._worldRadius;
			if (num2 * num2 - 4.0 * num * num3 <= 0.0)
			{
				latitude = Angle.NaN;
				longitude = Angle.NaN;
			}
			else
			{
				double num4 = (-1.0 * num2 - Math.Sqrt(num2 * num2 - 4.0 * num * num3)) / (2.0 * num);
				Point3d point3d3 = new Point3d(point3d.X + num4 * (point3d2.X - point3d.X), point3d.Y + num4 * (point3d2.Y - point3d.Y), point3d.Z + num4 * (point3d2.Z - point3d.Z));
				Point3d point3d4 = MathEngine.CartesianToSphericalD(point3d3.X, point3d3.Y, point3d3.Z);
				latitude = Angle.FromRadians(point3d4.Y);
				longitude = Angle.FromRadians(point3d4.Z);
			}
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x000B6C90 File Offset: 0x000B4E90
		protected virtual void ComputeProjectionMatrix(Viewport viewport_1)
		{
			float aspectRatio = (float)viewport_1.Width / (float)viewport_1.Height;
			float znearPlane = (float)this._altitude * 0.1f;
			double num = this._altitude + this.GetWorldRadius();
			double num2 = Math.Sqrt(num * num - this._worldRadius * this._worldRadius);
			if (num2 < 1000000.0)
			{
				num2 = 1000000.0;
			}
			this.m_ProjectionMatrix = Matrix.PerspectiveFovRH((float)this._fov.Radians, aspectRatio, znearPlane, (float)num2);
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x000B6D18 File Offset: 0x000B4F18
		public virtual void RotationYawPitchRoll(Angle yaw, Angle pitch, Angle roll)
		{
			this.m_Orientation = Quaternion4d.Plus(Quaternion4d.EulerToQuaternion(yaw.Radians, pitch.Radians, roll.Radians), this.m_Orientation);
			Point3d point3d = Quaternion4d.QuaternionToEuler(this.m_Orientation);
			if (!double.IsNaN(point3d.Y))
			{
				this._latitude.Radians = point3d.Y;
			}
			if (!double.IsNaN(point3d.X))
			{
				this._longitude.Radians = point3d.X;
			}
			if (Math.Abs(roll.Radians) > 4.94065645841247E-324)
			{
				this._heading.Radians = point3d.Z;
			}
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x000B6DC8 File Offset: 0x000B4FC8
		public virtual void ZoomStepped(float ticks)
		{
			int tickCount = Environment.TickCount;
			double num = (double)World.Settings.cameraZoomStepFactor;
			if (num < 0.0)
			{
				num = 0.0;
			}
			if (num > 1.0)
			{
				num = 1.0;
			}
			double num2 = 50.0;
			double num3 = 250.0;
			double num4 = (double)(tickCount - this.lastStepZoomTickCount);
			if (num4 < num2)
			{
				num4 = num2;
			}
			double num5 = 1.0 - Math.Abs((num4 - num2) / num3);
			if (num5 < 0.0)
			{
				num5 = 0.0;
			}
			num5 *= (double)World.Settings.float_7;
			double num6 = Math.Pow(1.0 - num, num5 + 1.0);
			num6 = Math.Pow(num6, (double)Math.Abs(ticks));
			if (ticks > 0f)
			{
				this.SetTargetDistance(this.GetTargetDistance() * num6);
			}
			else
			{
				this.SetTargetDistance(this.GetTargetDistance() / num6);
			}
			this.lastStepZoomTickCount = tickCount;
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x00011F93 File Offset: 0x00010193
		public virtual void Zoom(float percent)
		{
			if (percent > 0f)
			{
				this.SetTargetDistance(this.GetTargetDistance() / (double)(1f + percent));
			}
			else
			{
				this.SetTargetDistance(this.GetTargetDistance() * (double)(1f - percent));
			}
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x000B6EF0 File Offset: 0x000B50F0
		public virtual void Pan(Angle lat, Angle lon)
		{
			if (Angle.IsNaN(lat))
			{
				lat = this._latitude;
			}
			if (Angle.IsNaN(lon))
			{
				lon = this._longitude;
			}
			lat = Angle.Addition(lat, this._latitude);
			lon = Angle.Addition(lon, this._longitude);
			this.m_Orientation = Quaternion4d.EulerToQuaternion(lon.Radians, lat.Radians, this._heading.Radians);
			Point3d point3d = Quaternion4d.QuaternionToEuler(this.m_Orientation);
			if (!double.IsNaN(point3d.Y))
			{
				this._latitude.Radians = point3d.Y;
				this._longitude.Radians = point3d.X;
			}
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x000B6FA0 File Offset: 0x000B51A0
		protected void ComputeDistance(double double_5, Angle struct63_10)
		{
			double num = Math.Cos(3.1415926535897931 - struct63_10.Radians);
			double num2 = this._worldRadius * num;
			double num3 = this._worldRadius + double_5;
			double num4 = Math.Sqrt(this._worldRadius * this._worldRadius * num * num + num3 * num3 - this._worldRadius * this._worldRadius);
			double num5 = num2 - num4;
			if (num5 < 0.0)
			{
				num5 = num2 + num4;
			}
			this._distance = num5;
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x000B7024 File Offset: 0x000B5224
		protected void ComputeAltitude(double double_5, Angle struct63_10)
		{
			double num = Math.Sqrt(this._worldRadius * this._worldRadius + double_5 * double_5 - 2.0 * this._worldRadius * double_5 * Math.Cos(3.1415926535897931 - struct63_10.Radians)) - this._worldRadius;
			if (num < CameraBase.minimumAltitude + (double)((float)this._terrainElevation * World.Settings.GetVerticalExaggeration()))
			{
				num = CameraBase.minimumAltitude + (double)((float)this._terrainElevation * World.Settings.GetVerticalExaggeration());
			}
			else if (num > CameraBase.maximumAltitude)
			{
				num = CameraBase.maximumAltitude;
			}
			this._altitude = num;
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x000B70D0 File Offset: 0x000B52D0
		protected void ComputeTilt(double double_5, double double_6)
		{
			double num = this._worldRadius + double_5;
			double worldRadius = this._worldRadius;
			this._tilt.Radians = Math.Acos((num * num + double_6 * double_6 - worldRadius * worldRadius) / (2.0 * num * double_6));
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x000B7118 File Offset: 0x000B5318
		public Vector3 Project(Vector3 point)
		{
			point.Project(this.viewPort, this.m_ProjectionMatrix, this.m_ViewMatrix, this.m_WorldMatrix);
			return point;
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x000B714C File Offset: 0x000B534C
		public override string ToString()
		{
			return string.Format(CultureInfo.InvariantCulture, "Altitude: {6:f0}m\nView Range: {0}\nHeading: {1}\nTilt: {2}\nFOV: {7}\nPosition: ({3}, {4} @ {5:f0}m)", new object[]
			{
				this.GetViewRange(),
				this._heading,
				this._tilt,
				this._latitude,
				this._longitude,
				this._distance,
				this._altitude,
				this._fov
			});
		}

		// Token: 0x04000C8B RID: 3211
		protected short _terrainElevation;

		// Token: 0x04000C8C RID: 3212
		protected double _worldRadius;

		// Token: 0x04000C8D RID: 3213
		protected Angle _latitude;

		// Token: 0x04000C8E RID: 3214
		protected Angle _longitude;

		// Token: 0x04000C8F RID: 3215
		protected Angle _heading;

		// Token: 0x04000C90 RID: 3216
		protected Angle _tilt;

		// Token: 0x04000C91 RID: 3217
		protected Angle _bank;

		// Token: 0x04000C92 RID: 3218
		protected double _distance;

		// Token: 0x04000C93 RID: 3219
		protected double _altitude = 0.0;

		// Token: 0x04000C94 RID: 3220
		protected Quaternion4d m_Orientation;

		// Token: 0x04000C95 RID: 3221
		protected Frustum _viewFrustum = new Frustum();

		// Token: 0x04000C96 RID: 3222
		protected Angle _fov = World.Settings.cameraFov;

		// Token: 0x04000C97 RID: 3223
		protected Vector3 _position;

		// Token: 0x04000C98 RID: 3224
		protected static readonly Angle minTilt = Angle.FromDegrees(0.0);

		// Token: 0x04000C99 RID: 3225
		protected static readonly Angle maxTilt = Angle.FromDegrees(85.0);

		// Token: 0x04000C9A RID: 3226
		protected static readonly double minimumAltitude = 10.0;

		// Token: 0x04000C9B RID: 3227
		protected static double maximumAltitude = 1.7976931348623157E+308;

		// Token: 0x04000C9C RID: 3228
		protected Matrix m_ProjectionMatrix;

		// Token: 0x04000C9D RID: 3229
		protected Matrix m_ViewMatrix;

		// Token: 0x04000C9E RID: 3230
		protected Matrix m_WorldMatrix = Matrix.Identity;

		// Token: 0x04000C9F RID: 3231
		protected Angle viewRange;

		// Token: 0x04000CA0 RID: 3232
		protected Angle trueViewRange;

		// Token: 0x04000CA1 RID: 3233
		protected Viewport viewPort;

		// Token: 0x04000CA2 RID: 3234
		protected int lastStepZoomTickCount;

		// Token: 0x04000CA3 RID: 3235
		private static Point3d cameraUpVector = new Point3d(0.0, 0.0, 1.0);

		// Token: 0x04000CA4 RID: 3236
		public Point3d ReferenceCenter = new Point3d(0.0, 0.0, 0.0);

		// Token: 0x04000CA5 RID: 3237
		private static int lastResetTime;

		// Token: 0x04000CA6 RID: 3238
		public Vector3 EyeDiff = new Vector3();

		// Token: 0x04000CA7 RID: 3239
		private float curCameraElevation;

		// Token: 0x04000CA8 RID: 3240
		private float targetCameraElevation;

		// Token: 0x04000CA9 RID: 3241
		public static Point3d LookFrom = new Point3d();

		// Token: 0x04000CAA RID: 3242
		public static Point3d relCameraPos = new Point3d();

		// Token: 0x04000CAB RID: 3243
		private Matrix m_absoluteViewMatrix = Matrix.Identity;

		// Token: 0x04000CAC RID: 3244
		private Matrix m_absoluteWorldMatrix = Matrix.Identity;

		// Token: 0x04000CAD RID: 3245
		private Matrix m_absoluteProjectionMatrix = Matrix.Identity;
	}
}
