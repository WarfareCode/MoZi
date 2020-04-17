using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using ns17;
using ns18;

namespace ns19
{
	// Token: 0x020003FC RID: 1020
	public sealed class AtmosphericScatteringSphere
	{
		// Token: 0x06001971 RID: 6513 RVA: 0x0009AFEC File Offset: 0x000991EC
		public void method_0(float float_23, int int_10, int int_11)
		{
			try
			{
				this.float_0 = float_23;
				this.int_0 = int_10;
				this.int_1 = int_11;
				Point3d point3d = Class1958.smethod_0(TimeKeeper.smethod_0());
				Vector3 left = new Vector3(-(float)point3d.X, -(float)point3d.Y, -(float)point3d.Z);
				this.vector3_3 = left * 1E+08f;
				this.vector3_4 = new Vector3(this.vector3_3.X / this.vector3_3.Length(), this.vector3_3.Y / this.vector3_3.Length(), this.vector3_3.Z / this.vector3_3.Length());
				this.float_10 = 1f / (AtmosphericScatteringSphere.float_2 - AtmosphericScatteringSphere.float_1);
				this.list_0.Clear();
				double num = 180.0 / (double)AtmosphericScatteringSphere.int_2;
				double num2 = 360.0 / (double)AtmosphericScatteringSphere.int_3;
				int num3 = this.int_0 / AtmosphericScatteringSphere.int_2;
				for (int i = 0; i < AtmosphericScatteringSphere.int_2; i++)
				{
					for (int j = 0; j < AtmosphericScatteringSphere.int_3; j++)
					{
						AtmosphericScatteringSphere.MeshSubset meshSubset = new AtmosphericScatteringSphere.MeshSubset();
						double num4 = (double)i * num + num - 90.0;
						double num5 = (double)i * num - 90.0;
						double num6 = (double)j * num2 - 180.0;
						double num7 = (double)j * num2 + num2 - 180.0;
						meshSubset.positionColored_0 = this.method_4(num5, num4, num6, num7, num3);
						meshSubset.positionColored_1 = this.method_4(num5, num4, num6, num7, 2 * num3);
						meshSubset.class1941_0 = new BoundingBox((float)num5, (float)num4, (float)num6, (float)num7, float_23, float_23);
						this.list_0.Add(meshSubset);
					}
				}
				this.short_0 = this.method_5(num3);
				this.short_1 = this.method_5(2 * num3);
				this.int_8 = 4;
				this.float_15 = 0.0025f;
				this.float_16 = this.float_15 * 4f * 3.14159274f;
				this.float_17 = 0.0015f;
				this.float_18 = this.float_17 * 4f * 3.14159274f;
				this.float_19 = 15f;
				this.float_20 = -0.85f;
				this.float_11[0] = 0.65f;
				this.float_11[1] = 0.57f;
				this.float_11[2] = 0.475f;
				this.float_12[0] = (float)Math.Pow((double)this.float_11[0], 4.0);
				this.float_12[1] = (float)Math.Pow((double)this.float_11[1], 4.0);
				this.float_12[2] = (float)Math.Pow((double)this.float_11[2], 4.0);
				this.float_13 = 0.25f;
				this.float_14 = 0.1f;
			}
			catch (Exception exception_)
			{
				Log.smethod_3(exception_);
			}
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00010A32 File Offset: 0x0000EC32
		public void method_1()
		{
			this.bool_0 = false;
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x0009B314 File Offset: 0x00099514
		private void method_2()
		{
			try
			{
				while (this.bool_0)
				{
					if (World.Settings.method_0() && this.list_0.Count > 0)
					{
						DateTime dateTime = TimeKeeper.smethod_0();
						this.method_14();
						if (World.Settings.method_1())
						{
							this.int_8 = 4;
							this.float_15 = 0.0025f;
							this.float_16 = this.float_15 * 4f * 3.14159274f;
							this.float_17 = 0.0015f;
							this.float_18 = this.float_17 * 4f * 3.14159274f;
							this.float_19 = 15f;
							this.float_20 = -0.85f;
							this.float_11[0] = 0.65f;
							this.float_11[1] = 0.57f;
							this.float_11[2] = 0.475f;
							this.float_12[0] = (float)Math.Pow((double)this.float_11[0], 4.0);
							this.float_12[1] = (float)Math.Pow((double)this.float_11[1], 4.0);
							this.float_12[2] = (float)Math.Pow((double)this.float_11[2], 4.0);
							this.float_13 = 0.25f;
							this.float_14 = 0.1f;
							if (dateTime.Subtract(this.dateTime_0) > TimeSpan.FromSeconds(100.0))
							{
								this.method_15(AtmosphericScatteringSphere.float_1, AtmosphericScatteringSphere.float_2, this.float_13, this.float_14);
								this.dateTime_0 = dateTime;
							}
						}
						else
						{
							this.int_8 = 2;
							this.float_15 = 0.0025f;
							this.float_16 = this.float_15 * 4f * 3.14159274f;
							this.float_17 = 0.0015f;
							this.float_18 = this.float_17 * 4f * 3.14159274f;
							this.float_19 = 15f;
							this.float_20 = -0.95f;
							this.float_10 = 1f / (AtmosphericScatteringSphere.float_2 - AtmosphericScatteringSphere.float_1);
							this.float_11[0] = 0.65f;
							this.float_11[1] = 0.57f;
							this.float_11[2] = 0.475f;
							this.float_12[0] = (float)Math.Pow((double)this.float_11[0], 4.0);
							this.float_12[1] = (float)Math.Pow((double)this.float_11[1], 4.0);
							this.float_12[2] = (float)Math.Pow((double)this.float_11[2], 4.0);
							this.float_13 = 0.25f;
							this.float_14 = 0.1f;
						}
					}
					Thread.Sleep(500);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x0009B608 File Offset: 0x00099808
		public void method_3(DrawArgs class1943_0)
		{
			if (this.thread_0 == null)
			{
				if (class1943_0.device_0.DeviceCaps.PixelShaderVersion.Major >= 2)
				{
					this.bool_1 = true;
				}
				else
				{
					this.bool_1 = false;
				}
				this.bool_0 = true;
				this.thread_0 = new Thread(new ThreadStart(this.method_2));
				this.thread_0.Priority = ThreadPriority.Lowest;
				this.thread_0.IsBackground = true;
				this.thread_0.Start();
			}
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x0009B694 File Offset: 0x00099894
		private CustomVertex.PositionColored[] method_4(double double_1, double double_2, double double_3, double double_4, int int_10)
		{
			int num = int_10 - 1;
			float num2 = 1f / (float)num;
			double num3 = Math.Abs(double_2 - double_1);
			double num4;
			if (double_3 < double_4)
			{
				num4 = double_4 - double_3;
			}
			else
			{
				num4 = 360.0 + double_4 - double_3;
			}
			CustomVertex.PositionColored[] array = new CustomVertex.PositionColored[int_10 * int_10];
			for (int i = 0; i < int_10; i++)
			{
				for (int j = 0; j < int_10; j++)
				{
					Vector3 vector = MathEngine.SphericalToCartesian(double_2 - (double)num2 * num3 * (double)i, double_3 + (double)num2 * num4 * (double)j, (double)this.float_0);
					array[i * int_10 + j].X = vector.X;
					array[i * int_10 + j].Y = vector.Y;
					array[i * int_10 + j].Z = vector.Z;
				}
			}
			return array;
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x0009B798 File Offset: 0x00099998
		private short[] method_5(int int_10)
		{
			int num = int_10 - 1;
			short[] array = new short[2 * num * num * 3];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					array[6 * i * num + 6 * j] = (short)(i * int_10 + j);
					array[6 * i * num + 6 * j + 1] = (short)((i + 1) * int_10 + j);
					array[6 * i * num + 6 * j + 2] = (short)(i * int_10 + j + 1);
					array[6 * i * num + 6 * j + 3] = (short)(i * int_10 + j + 1);
					array[6 * i * num + 6 * j + 4] = (short)((i + 1) * int_10 + j);
					array[6 * i * num + 6 * j + 5] = (short)((i + 1) * int_10 + j + 1);
				}
			}
			return array;
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x0009B860 File Offset: 0x00099A60
		public void method_6(ref CustomVertex.PositionColored positionColored_1, DrawArgs class1943_0)
		{
			this.vector3_1.X = positionColored_1.X;
			this.vector3_1.Y = positionColored_1.Y;
			this.vector3_1.Z = positionColored_1.Z;
			this.vector3_2.X = class1943_0.GetWorldCamera().GetPosition().X;
			this.vector3_2.Y = class1943_0.GetWorldCamera().GetPosition().Y;
			this.vector3_2.Z = class1943_0.GetWorldCamera().GetPosition().Z;
			Vector3 vector = this.vector3_1 - this.vector3_2;
			float num = vector.Length();
			vector.Normalize();
			float num2 = 2f * Vector3.Dot(this.vector3_2, vector);
			float num3 = Vector3.Dot(this.vector3_2, this.vector3_2) - AtmosphericScatteringSphere.float_2 * AtmosphericScatteringSphere.float_2;
			float num4 = Math.Max(0f, num2 * num2 - 4f * num3);
			float num5 = 0.5f * (-num2 - (float)Math.Sqrt((double)num4));
			bool flag = true;
			for (int i = 0; i < this.float_3.Length; i++)
			{
				this.float_3[i] = 0f;
			}
			for (int j = 0; j < this.float_4.Length; j++)
			{
				this.float_4[j] = 0f;
			}
			for (int k = 0; k < this.float_5.Length; k++)
			{
				this.float_5[k] = 0f;
			}
			if (num5 <= 0f)
			{
				float num6 = this.vector3_2.Length();
				float float_ = (num6 - AtmosphericScatteringSphere.float_1) * this.float_10;
				float num7 = Vector3.Dot((flag = (num6 >= this.vector3_1.Length())) ? (-vector) : vector, this.vector3_2) / num6;
				this.method_7(ref this.float_3, float_, 0.5f - num7 * 0.5f);
			}
			else
			{
				this.vector3_2 += vector * num5;
				num -= num5;
			}
			if (num <= this.float_9)
			{
				positionColored_1.Color = Color.FromArgb(255, 0, 0, 0).ToArgb();
			}
			else
			{
				for (int l = 0; l < this.float_6.Length; l++)
				{
					this.float_6[l] = 0f;
				}
				for (int m = 0; m < this.float_7.Length; m++)
				{
					this.float_7[m] = 0f;
				}
				float num8 = num / (float)this.int_8;
				float num9 = num8 * this.float_10;
				Vector3 vector2 = vector * num8;
				this.vector3_1 = this.vector3_2 + vector2 * 0.5f;
				for (int n = 0; n < this.int_8; n++)
				{
					float num10 = this.vector3_1.Length();
					float num11 = Vector3.Dot(this.vector3_4, this.vector3_1) / num10;
					float float_2 = (num10 - AtmosphericScatteringSphere.float_1) * this.float_10;
					this.method_7(ref this.float_4, float_2, 0.5f - num11 * 0.5f);
					if (this.float_4[0] >= this.float_9)
					{
						float num12 = num9 * this.float_4[0];
						float num13 = this.float_4[1];
						float num14 = num9 * this.float_4[2];
						float num15 = this.float_4[3];
						if (flag)
						{
							float num16 = Vector3.Dot(-vector, this.vector3_1) / num10;
							this.method_7(ref this.float_5, float_2, 0.5f - num16 * 0.5f);
							num13 += this.float_5[1] - this.float_3[1];
							num15 += this.float_5[3] - this.float_3[3];
						}
						else
						{
							float num17 = Vector3.Dot(vector, this.vector3_1) / num10;
							this.method_7(ref this.float_5, float_2, 0.5f - num17 * 0.5f);
							num13 += this.float_3[1] - this.float_5[1];
							num15 += this.float_3[3] - this.float_5[3];
						}
						num13 *= this.float_16;
						num15 *= this.float_18;
						this.float_8[0] = (float)Math.Exp(-(double)num13 / (double)this.float_12[0] - (double)num15);
						this.float_8[1] = (float)Math.Exp(-(double)num13 / (double)this.float_12[1] - (double)num15);
						this.float_8[2] = (float)Math.Exp(-(double)num13 / (double)this.float_12[2] - (double)num15);
						this.float_6[0] += num12 * this.float_8[0];
						this.float_6[1] += num12 * this.float_8[1];
						this.float_6[2] += num12 * this.float_8[2];
						this.float_7[0] += num14 * this.float_8[0];
						this.float_7[1] += num14 * this.float_8[1];
						this.float_7[2] += num14 * this.float_8[2];
						this.vector3_1 += vector2;
					}
				}
				float num18 = Vector3.Dot(-vector, this.vector3_4);
				float[] array = new float[2];
				float num19 = num18 * num18;
				float num20 = this.float_20 * this.float_20;
				array[0] = 0.75f * (1f + num19);
				array[1] = 1.5f * ((1f - num20) / (2f + num20)) * (1f + num19) / (float)Math.Pow((double)(1f + num20 - 2f * this.float_20 * num18), 1.5);
				array[0] *= this.float_15 * this.float_19;
				array[1] *= this.float_17 * this.float_19;
				float[] array2 = new float[]
				{
					this.float_6[0] * array[0] / this.float_12[0] + this.float_7[0] * array[1],
					this.float_6[1] * array[0] / this.float_12[1] + this.float_7[1] * array[1],
					this.float_6[2] * array[0] / this.float_12[2] + this.float_7[2] * array[1]
				};
				array2[0] = Math.Min(array2[0], 1f);
				array2[1] = Math.Min(array2[1], 1f);
				array2[2] = Math.Min(array2[2], 1f);
				float num21 = (array2[0] + array2[1] + array2[2]) / 3f;
				num21 = (float)Math.Min((double)num21 + 0.5, 1.0);
				positionColored_1.Color = Color.FromArgb((int)((byte)(num21 * 255f)), (int)((byte)(array2[0] * 255f)), (int)((byte)(array2[1] * 255f)), (int)((byte)(array2[2] * 255f))).ToArgb();
			}
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x0009C000 File Offset: 0x0009A200
		private void method_7(ref float[] float_23, float float_24, float float_25)
		{
			float num = float_24 * (float)(AtmosphericScatteringSphere.int_5 - 1);
			float num2 = float_25 * (float)(AtmosphericScatteringSphere.int_6 - 1);
			int num3 = Math.Min(AtmosphericScatteringSphere.int_5 - 2, Math.Max(0, (int)num));
			int num4 = Math.Min(AtmosphericScatteringSphere.int_6 - 2, Math.Max(0, (int)num2));
			float num5 = num - (float)num3;
			float num6 = num2 - (float)num4;
			int num7 = (AtmosphericScatteringSphere.int_5 * num4 + num3) * 4;
			for (int i = 0; i < AtmosphericScatteringSphere.int_4; i++)
			{
				if (this.int_9 == 1)
				{
					float_23[i] = this.float_21[num7] * (1f - num5) * (1f - num6) + this.float_21[num7 + AtmosphericScatteringSphere.int_4] * num5 * (1f - num6) + this.float_21[num7 + AtmosphericScatteringSphere.int_4 * AtmosphericScatteringSphere.int_5] * (1f - num5) * num6 + this.float_21[num7 + AtmosphericScatteringSphere.int_4 * (AtmosphericScatteringSphere.int_5 + 1)] * num5 * num6;
				}
				else
				{
					float_23[i] = this.float_22[num7] * (1f - num5) * (1f - num6) + this.float_22[num7 + AtmosphericScatteringSphere.int_4] * num5 * (1f - num6) + this.float_22[num7 + AtmosphericScatteringSphere.int_4 * AtmosphericScatteringSphere.int_5] * (1f - num5) * num6 + this.float_22[num7 + AtmosphericScatteringSphere.int_4 * (AtmosphericScatteringSphere.int_5 + 1)] * num5 * num6;
				}
				num7++;
			}
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x0009C190 File Offset: 0x0009A390
		private void method_8(DrawArgs class1943_0, double double_1)
		{
			CameraBase worldCamera = class1943_0.GetWorldCamera();
			this.double_0 = (double)this.float_0 - worldCamera.GetWorldRadius();
			double num = worldCamera.GetAltitude() + worldCamera.GetWorldRadius();
			double num2 = Math.Sqrt(num * num - worldCamera.GetWorldRadius() * worldCamera.GetWorldRadius());
			double num3 = num2;
			double double_2 = (-1.5707963267948966 + Math.Acos(num2 / num)) * 180.0 / 3.1415926535897931;
			double double_3 = 90.0;
			if (worldCamera.GetAltitude() >= this.double_0)
			{
				double num4 = Math.Sqrt(num * num - (worldCamera.GetWorldRadius() + this.double_0) * (worldCamera.GetWorldRadius() + this.double_0));
				double_3 = (-1.5707963267948966 + Math.Acos(num4 / num)) * 180.0 / 3.1415926535897931;
			}
			if (worldCamera.GetAltitude() < this.double_0 && worldCamera.GetAltitude() > this.double_0 * 0.8)
			{
				double_3 = (this.double_0 - worldCamera.GetAltitude()) / (this.double_0 - this.double_0 * 0.8) * 90.0;
			}
			if (this.mesh_0 != null)
			{
				this.mesh_0.Dispose();
			}
			int num5 = (double_1 > 180.0) ? 64 : 128;
			this.mesh_0 = this.method_9(class1943_0, (float)num3, double_2, double_3, num5, num5 / 2, double_1, worldCamera.GetHeading().GetDegrees());
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x0009C32C File Offset: 0x0009A52C
		private Mesh method_9(DrawArgs class1943_0, float float_23, double double_1, double double_2, int int_10, int int_11, double double_3, double double_4)
		{
			int_10 = (int)((double)int_10 * double_3 / 360.0);
			int numVertices = (int_10 + 1) * (int_11 + 1);
			int num = int_10 * int_11 * 2;
			int num2 = num * 3;
			Device device_ = class1943_0.device_0;
			CameraBase worldCamera = class1943_0.GetWorldCamera();
			Vector3 position = worldCamera.GetPosition();
			double num3 = worldCamera.GetAltitude() + worldCamera.GetWorldRadius();
			Vector3 vector = MathEngine.CartesianToSpherical(position.X, position.Y, position.Z);
			float y = vector.Y;
			float z = vector.Z;
			Matrix matrix = Matrix.Identity;
			matrix *= Matrix.Translation(0f, 0f, (float)num3);
			matrix *= Matrix.RotationY(-y + 1.57079637f);
			matrix *= Matrix.RotationZ(z);
			double radians = MathEngine.SphericalDistance(Angle.FromRadians((double)y), Angle.FromRadians((double)z), worldCamera.GetLatitude(), worldCamera.GetLongitude()).Radians;
			double num4 = Math.Acos((Math.Sin(worldCamera.GetLatitude().Radians) - Math.Sin((double)y) * Math.Cos(radians)) / (Math.Sin(radians) * Math.Cos((double)y)));
			if (Math.Sign(worldCamera.GetLongitude().Radians - (double)z) < 0)
			{
				num4 = 6.2831853071795862 - num4;
			}
			if (double.IsNaN(num4))
			{
				num4 = 0.0;
			}
			num4 = MathEngine.RadiansToDegrees(num4);
			double num5 = -num4 - 180.0 + double_3 / 2.0;
			Mesh mesh = new Mesh(num, numVertices, MeshFlags.Managed, VertexFormats.Diffuse | VertexFormats.Position, device_);
			int[] array = new int[]
			{
				mesh.NumberVertices
			};
			Array array2 = mesh.VertexBuffer.Lock(0, typeof(CustomVertex.PositionColored), LockFlags.None, array);
			int num6 = 0;
			double num7 = double_1 - (double_2 - double_1) / 10.0;
			if (num7 < double_1 - 1.0)
			{
				num7 = double_1 - 1.0;
			}
			for (int i = 0; i <= int_10; i++)
			{
				CustomVertex.PositionColored positionColored = default(CustomVertex.PositionColored);
				double longitude = num5 - (double)((float)i / (float)int_10) * double_3;
				Vector3 vector2 = MathEngine.SphericalToCartesian(num7, longitude, (double)float_23);
				vector2.TransformCoordinate(matrix);
				positionColored.X = vector2.X;
				positionColored.Y = vector2.Y;
				positionColored.Z = vector2.Z;
				positionColored.Color = Color.FromArgb(0, 0, 0, 0).ToArgb();
				array2.SetValue(positionColored, num6++);
			}
			for (int j = 1; j < int_11; j++)
			{
				double num8 = 1.0 - Math.Cos((double)((float)(j - 1) / ((float)int_11 - 1f)) * 3.1415926535897931 / 2.0);
				num7 = double_1 + num8 * num8 * num8 * (double)((float)(double_2 - double_1));
				for (int k = 0; k <= int_10; k++)
				{
					CustomVertex.PositionColored positionColored = default(CustomVertex.PositionColored);
					double longitude2 = num5 - (double)((float)k / (float)int_10) * double_3;
					Vector3 vector2 = MathEngine.SphericalToCartesian(num7, longitude2, (double)float_23);
					vector2.TransformCoordinate(matrix);
					positionColored.X = vector2.X;
					positionColored.Y = vector2.Y;
					positionColored.Z = vector2.Z;
					positionColored.Color = this.method_10(class1943_0, positionColored);
					array2.SetValue(positionColored, num6++);
				}
			}
			num7 = double_2 + (double_2 - double_1) / 10.0;
			for (int l = 0; l <= int_10; l++)
			{
				CustomVertex.PositionColored positionColored = default(CustomVertex.PositionColored);
				double longitude3 = num5 - (double)((float)l / (float)int_10) * double_3;
				Vector3 vector2 = MathEngine.SphericalToCartesian(num7, longitude3, (double)float_23);
				vector2.TransformCoordinate(matrix);
				positionColored.X = vector2.X;
				positionColored.Y = vector2.Y;
				positionColored.Z = vector2.Z;
				positionColored.Color = Color.FromArgb(0, 0, 0, 0).ToArgb();
				array2.SetValue(positionColored, num6++);
			}
			mesh.VertexBuffer.Unlock();
			array[0] = num2;
			array2 = mesh.LockIndexBuffer(typeof(short), LockFlags.None, array);
			int num9 = 0;
			short num10 = 0;
			while ((int)num10 < int_11)
			{
				short num11 = (short)((int_10 + 1) * (int)num10);
				short num12 = (short)((int)num11 + int_10 + 1);
				for (int m = 0; m < int_10; m++)
				{
					array2.SetValue(num11, num9++);
					array2.SetValue((int)(num12 + 1), num9++);
					array2.SetValue(num12, num9++);
					array2.SetValue(num11, num9++);
					array2.SetValue((int)(num11 + 1), num9++);
					array2.SetValue((int)(num12 + 1), num9++);
					num11 += 1;
					num12 += 1;
				}
				num10 += 1;
			}
			mesh.IndexBuffer.SetData(array2, 0, LockFlags.None);
			return mesh;
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x0009C8B4 File Offset: 0x0009AAB4
		private int method_10(DrawArgs class1943_0, CustomVertex.PositionColored positionColored_1)
		{
			this.vector3_1.X = positionColored_1.X;
			this.vector3_1.Y = positionColored_1.Y;
			this.vector3_1.Z = positionColored_1.Z;
			this.vector3_2.X = class1943_0.GetWorldCamera().GetPosition().X;
			this.vector3_2.Y = class1943_0.GetWorldCamera().GetPosition().Y;
			this.vector3_2.Z = class1943_0.GetWorldCamera().GetPosition().Z;
			Vector3 vector = this.vector3_1 - this.vector3_2;
			vector.Normalize();
			float num = 2f * Vector3.Dot(this.vector3_2, vector);
			float num2 = Vector3.Dot(this.vector3_2, this.vector3_2) - this.float_0 * this.float_0;
			float num3 = num * num - 4f * num2;
			this.positionColored_0.Color = Color.FromArgb(0, 0, 0, 0).ToArgb();
			if (num3 >= 0f)
			{
				float num4 = 0.5f * (-num - (float)Math.Sqrt((double)num3));
				float num5 = 0.5f * (-num + (float)Math.Sqrt((double)num3));
				if (num4 >= 0f || num5 >= 0f)
				{
					float right = Math.Max(num4, num5);
					this.vector3_1 = this.vector3_2 + vector * right;
					this.positionColored_0.X = this.vector3_1.X;
					this.positionColored_0.Y = this.vector3_1.Y;
					this.positionColored_0.Z = this.vector3_1.Z;
					this.method_6(ref this.positionColored_0, class1943_0);
				}
			}
			return this.positionColored_0.Color;
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x0009CA8C File Offset: 0x0009AC8C
		public void method_11(DrawArgs class1943_0)
		{
			try
			{
				if (this.list_0.Count > 0 && ((!World.Settings.method_1() && this.bool_1) || this.float_21 != null))
				{
					double num = this.method_12(class1943_0);
					if (num != 0.0)
					{
						if (AtmosphericScatteringSphere.effect_0 == null)
						{
							class1943_0.device_0.DeviceReset += new EventHandler(this.method_13);
							this.method_13(class1943_0.device_0, null);
						}
						this.vector3_2.X = class1943_0.GetWorldCamera().GetPosition().X;
						this.vector3_2.Y = class1943_0.GetWorldCamera().GetPosition().Y;
						this.vector3_2.Z = class1943_0.GetWorldCamera().GetPosition().Z;
						class1943_0.device_0.VertexFormat = (VertexFormats.Diffuse | VertexFormats.Position);
						class1943_0.device_0.TextureState[0].ColorOperation = TextureOperation.Disable;
						if (class1943_0.device_0.RenderState.Lighting)
						{
							class1943_0.device_0.RenderState.Lighting = false;
						}
						class1943_0.device_0.Transform.World = Matrix.Translation(-(float)class1943_0.GetWorldCamera().ReferenceCenter.X, -(float)class1943_0.GetWorldCamera().ReferenceCenter.Y, -(float)class1943_0.GetWorldCamera().ReferenceCenter.Z);
						bool flag = class1943_0.GetWorldCamera().GetAltitude() < 300000.0;
						Frustum frustum = new Frustum();
						frustum.Update(Matrix.Multiply(class1943_0.device_0.Transform.World, Matrix.Multiply(class1943_0.device_0.Transform.View, class1943_0.device_0.Transform.Projection)));
						if (!World.Settings.method_1() && this.bool_1)
						{
							this.method_14();
							Effect effect;
							if (this.vector3_2.Length() >= AtmosphericScatteringSphere.float_2)
							{
								effect = AtmosphericScatteringSphere.effect_0;
							}
							else
							{
								effect = AtmosphericScatteringSphere.effect_1;
							}
							effect.Technique = "Sky";
							effect.SetValue("v3CameraPos", new Vector4(this.vector3_2.X, this.vector3_2.Y, this.vector3_2.Z, 0f));
							effect.SetValue("v3LightPos", Vector4.Normalize(new Vector4(this.vector3_4.X, this.vector3_4.Y, this.vector3_4.Z, 0f)));
							effect.SetValue("WorldViewProj", Matrix.Multiply(class1943_0.device_0.Transform.World, Matrix.Multiply(class1943_0.device_0.Transform.View, class1943_0.device_0.Transform.Projection)));
							effect.SetValue("v3InvWavelength", new Vector4(1f / this.float_12[0], 1f / this.float_12[1], 1f / this.float_12[2], 0f));
							effect.SetValue("fCameraHeight", this.vector3_2.Length());
							effect.SetValue("fCameraHeight2", this.vector3_2.LengthSq());
							effect.SetValue("fInnerRadius", AtmosphericScatteringSphere.float_1);
							effect.SetValue("fInnerRadius2", AtmosphericScatteringSphere.float_1 * AtmosphericScatteringSphere.float_1);
							effect.SetValue("fOuterRadius", AtmosphericScatteringSphere.float_2);
							effect.SetValue("fOuterRadius2", AtmosphericScatteringSphere.float_2 * AtmosphericScatteringSphere.float_2);
							effect.SetValue("fKrESun", this.float_15 * this.float_19);
							effect.SetValue("fKmESun", this.float_17 * this.float_19);
							effect.SetValue("fKr4PI", this.float_16);
							effect.SetValue("fKm4PI", this.float_18);
							effect.SetValue("fScale", 1f / (AtmosphericScatteringSphere.float_2 - AtmosphericScatteringSphere.float_1));
							effect.SetValue("fScaleDepth", this.float_13);
							effect.SetValue("fScaleOverScaleDepth", 1f / (AtmosphericScatteringSphere.float_2 - AtmosphericScatteringSphere.float_1) / this.float_13);
							effect.SetValue("g", this.float_20);
							effect.SetValue("g2", this.float_20 * this.float_20);
							effect.SetValue("nSamples", this.int_8);
							effect.SetValue("fSamples", this.int_8);
							for (int i = 0; i < this.list_0.Count; i++)
							{
								if (frustum.Contains(this.list_0[i].class1941_0))
								{
									int num2 = effect.Begin(FX.None);
									for (int j = 0; j < num2; j++)
									{
										effect.BeginPass(j);
										if (flag)
										{
											class1943_0.device_0.DrawIndexedUserPrimitives(PrimitiveType.TriangleList, 0, this.list_0[i].positionColored_1.Length, this.short_1.Length / 3, this.short_1, true, this.list_0[i].positionColored_1);
										}
										else
										{
											class1943_0.device_0.DrawIndexedUserPrimitives(PrimitiveType.TriangleList, 0, this.list_0[i].positionColored_0.Length, this.short_0.Length / 3, this.short_0, true, this.list_0[i].positionColored_0);
										}
										effect.EndPass();
									}
									effect.End();
								}
							}
						}
						else
						{
							this.method_14();
							this.method_8(class1943_0, num);
							class1943_0.device_0.RenderState.CullMode = Cull.Clockwise;
							this.mesh_0.DrawSubset(0);
						}
						class1943_0.device_0.Transform.World = class1943_0.GetWorldCamera().GetWorldMatrix();
					}
				}
			}
			catch (Exception exception_)
			{
				Log.smethod_3(exception_);
			}
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x0009D0F4 File Offset: 0x0009B2F4
		private double method_12(DrawArgs class1943_0)
		{
			CameraBase worldCamera = class1943_0.GetWorldCamera();
			Viewport viewport = worldCamera.GetViewport();
			worldCamera.GetPosition().Length();
			worldCamera.GetWorldRadius();
			double num = Math.Abs(Math.Asin(worldCamera.GetWorldRadius() / (worldCamera.GetWorldRadius() + worldCamera.GetAltitude()))) * 2.0;
			int height = viewport.Height;
			int width = viewport.Width;
			double radians = worldCamera.GetFov().Radians;
			double num2 = Math.Abs(Math.Atan(Math.Sqrt((double)(height * height + width * width)) * Math.Tan(radians / 2.0) / (double)height)) * 2.0;
			double num3 = worldCamera.GetTilt().Radians * 2.0;
			if (worldCamera.GetAltitude() > 10000.0)
			{
				double worldRadius = worldCamera.GetWorldRadius();
				double num4 = worldCamera.GetWorldRadius() + worldCamera.GetAltitude();
				double distance = worldCamera.GetDistance();
				num3 = Math.Abs(Math.Acos((worldRadius * worldRadius - distance * distance - num4 * num4) / (-2.0 * distance * num4))) * 2.0;
				if (double.IsNaN(num3))
				{
					num3 = 0.0;
				}
			}
			double num5 = 0.0;
			if (num2 + num3 > num)
			{
				num5 = ((num2 < num) ? (Math.Abs(Math.Asin(Math.Sin(num2 / 2.0) / Math.Sin(num / 2.0))) * 2.0) : 6.2831853071795862);
				num5 *= 57.295779513082323;
			}
			return num5;
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x0009D2B8 File Offset: 0x0009B4B8
		private void method_13(object sender, EventArgs e)
		{
			Device device = (Device)sender;
			try
			{
				string text = "";
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WorldWind.Shaders.SkyFromSpace.fx");
				AtmosphericScatteringSphere.effect_0 = Effect.FromStream(device, manifestResourceStream, null, null, ShaderFlags.None, null, out text);
				if (text != null && text.Length > 0)
				{
					Log.smethod_2(Log.Levels.Error, text);
				}
				Stream manifestResourceStream2 = executingAssembly.GetManifestResourceStream("WorldWind.Shaders.SkyFromAtmosphere.fx");
				AtmosphericScatteringSphere.effect_1 = Effect.FromStream(device, manifestResourceStream2, null, null, ShaderFlags.None, null, out text);
				if (text != null && text.Length > 0)
				{
					Log.smethod_2(Log.Levels.Error, text);
				}
			}
			catch (Exception exception_)
			{
				Log.smethod_3(exception_);
			}
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x0009D374 File Offset: 0x0009B574
		private void method_14()
		{
			Point3d point3d = Class1958.smethod_0(TimeKeeper.smethod_0());
			Vector3 left = new Vector3(-(float)point3d.X, -(float)point3d.Y, -(float)point3d.Z);
			this.vector3_3 = left * 1E+08f;
			this.vector3_4 = new Vector3(this.vector3_3.X / this.vector3_3.Length(), this.vector3_3.Y / this.vector3_3.Length(), this.vector3_3.Z / this.vector3_3.Length());
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x0009D410 File Offset: 0x0009B610
		private void method_15(float float_23, float float_24, float float_25, float float_26)
		{
			int num = 128;
			int num2 = 50;
			float num3 = 1f / (float_24 - float_23);
			if (this.float_21 == null)
			{
				this.float_21 = new float[num * num * 4];
			}
			if (this.float_22 == null)
			{
				this.float_22 = new float[num * num * 4];
			}
			if (this.int_9 == 1)
			{
				for (int i = 0; i < this.float_22.Length; i++)
				{
					this.float_22[i] = 0f;
				}
			}
			else
			{
				for (int j = 0; j < this.float_21.Length; j++)
				{
					this.float_21[j] = 0f;
				}
			}
			AtmosphericScatteringSphere.int_5 = num;
			AtmosphericScatteringSphere.int_6 = num;
			AtmosphericScatteringSphere.int_4 = 4;
			AtmosphericScatteringSphere.int_7 = AtmosphericScatteringSphere.int_4 * 4;
			int num4 = 0;
			for (int k = 0; k < num; k++)
			{
				float num5 = (float)Math.Acos((double)(1f - (float)(k + k) / (float)num));
				Vector3 vector = new Vector3((float)Math.Sin((double)num5), (float)Math.Cos((double)num5), 0f);
				for (int l = 0; l < num; l++)
				{
					float num6 = this.float_9 + float_23 + (float_24 - float_23) * (float)l / (float)num;
					Vector3 vector2 = new Vector3(0f, num6, 0f);
					float num7 = 2f * Vector3.Dot(vector2, vector);
					float num8 = num7 * num7;
					float num9 = Vector3.Dot(vector2, vector2);
					float num10 = num9 - float_23 * float_23;
					float num11 = num8 - 4f * num10;
					float num12;
					float num13;
					if (num11 < 0f || (0.5f * (-num7 - (float)Math.Sqrt((double)num11)) <= 0f && 0.5f * (-num7 + (float)Math.Sqrt((double)num11)) <= 0f))
					{
						num12 = (float)Math.Exp(-(double)(num6 - float_23) * (double)num3 / (double)float_25);
						num13 = (float)Math.Exp(-(double)(num6 - float_23) * (double)num3 / (double)float_26);
					}
					else if (this.int_9 == 1)
					{
						num12 = this.float_22[num4 - num * AtmosphericScatteringSphere.int_4] * 0.75f;
						num13 = this.float_22[num4 + 2 - num * AtmosphericScatteringSphere.int_4] * 0.75f;
					}
					else
					{
						num12 = this.float_21[num4 - num * AtmosphericScatteringSphere.int_4] * 0.75f;
						num13 = this.float_21[num4 + 2 - num * AtmosphericScatteringSphere.int_4] * 0.75f;
					}
					num10 = num9 - float_24 * float_24;
					num11 = num8 - 4f * num10;
					float num14 = 0.5f * (-num7 + (float)Math.Sqrt((double)num11)) / (float)num2;
					float num15 = num14 * num3;
					Vector3 vector3 = vector * num14;
					vector2 += vector3 * 0.5f;
					float num16 = 0f;
					float num17 = 0f;
					for (int m = 0; m < num2; m++)
					{
						num6 = vector2.Length();
						float num18 = (num6 - float_23) * num3;
						num18 = Math.Max(num18, 0f);
						num16 += (float)Math.Exp(-(double)num18 / (double)float_25);
						num17 += (float)Math.Exp(-(double)num18 / (double)float_26);
						vector2 += vector3;
					}
					num16 *= num15;
					num17 *= num15;
					if (this.int_9 == 1)
					{
						this.float_22[num4++] = num12;
						this.float_22[num4++] = num16;
						this.float_22[num4++] = num13;
						this.float_22[num4++] = num17;
					}
					else
					{
						this.float_21[num4++] = num12;
						this.float_21[num4++] = num16;
						this.float_21[num4++] = num13;
						this.float_21[num4++] = num17;
					}
				}
			}
			if (this.int_9 == 1)
			{
				this.int_9 = 2;
			}
			else
			{
				this.int_9 = 1;
			}
		}

		// Token: 0x04000A5C RID: 2652
		public float float_0;

		// Token: 0x04000A5D RID: 2653
		protected int int_0;

		// Token: 0x04000A5E RID: 2654
		protected int int_1;

		// Token: 0x04000A5F RID: 2655
		public static float float_1 = 0f;

		// Token: 0x04000A60 RID: 2656
		public static float float_2 = 0f;

		// Token: 0x04000A61 RID: 2657
		public static int int_2 = 4;

		// Token: 0x04000A62 RID: 2658
		public static int int_3 = 8;

		// Token: 0x04000A63 RID: 2659
		private List<AtmosphericScatteringSphere.MeshSubset> list_0 = new List<AtmosphericScatteringSphere.MeshSubset>();

		// Token: 0x04000A64 RID: 2660
		private Vector3 vector3_0 = Vector3.Empty;

		// Token: 0x04000A65 RID: 2661
		private Thread thread_0;

		// Token: 0x04000A66 RID: 2662
		private bool bool_0;

		// Token: 0x04000A67 RID: 2663
		private DateTime dateTime_0 = DateTime.MinValue;

		// Token: 0x04000A68 RID: 2664
		private bool bool_1;

		// Token: 0x04000A69 RID: 2665
		private short[] short_0;

		// Token: 0x04000A6A RID: 2666
		private short[] short_1;

		// Token: 0x04000A6B RID: 2667
		private float[] float_3 = new float[4];

		// Token: 0x04000A6C RID: 2668
		private float[] float_4 = new float[4];

		// Token: 0x04000A6D RID: 2669
		private float[] float_5 = new float[4];

		// Token: 0x04000A6E RID: 2670
		private float[] float_6 = new float[3];

		// Token: 0x04000A6F RID: 2671
		private float[] float_7 = new float[3];

		// Token: 0x04000A70 RID: 2672
		private Vector3 vector3_1 = new Vector3();

		// Token: 0x04000A71 RID: 2673
		private float[] float_8 = new float[3];

		// Token: 0x04000A72 RID: 2674
		private Vector3 vector3_2 = new Vector3();

		// Token: 0x04000A73 RID: 2675
		private float float_9 = 1E-06f;

		// Token: 0x04000A74 RID: 2676
		private static int int_4 = 4;

		// Token: 0x04000A75 RID: 2677
		private static int int_5;

		// Token: 0x04000A76 RID: 2678
		private static int int_6;

		// Token: 0x04000A77 RID: 2679
		private static int int_7;

		// Token: 0x04000A78 RID: 2680
		private float float_10;

		// Token: 0x04000A79 RID: 2681
		private float[] float_11 = new float[3];

		// Token: 0x04000A7A RID: 2682
		private float[] float_12 = new float[3];

		// Token: 0x04000A7B RID: 2683
		private float float_13;

		// Token: 0x04000A7C RID: 2684
		private float float_14;

		// Token: 0x04000A7D RID: 2685
		private int int_8;

		// Token: 0x04000A7E RID: 2686
		private float float_15;

		// Token: 0x04000A7F RID: 2687
		private float float_16;

		// Token: 0x04000A80 RID: 2688
		private float float_17;

		// Token: 0x04000A81 RID: 2689
		private float float_18;

		// Token: 0x04000A82 RID: 2690
		private float float_19;

		// Token: 0x04000A83 RID: 2691
		private float float_20;

		// Token: 0x04000A84 RID: 2692
		private Vector3 vector3_3;

		// Token: 0x04000A85 RID: 2693
		private Vector3 vector3_4;

		// Token: 0x04000A86 RID: 2694
		private double double_0;

		// Token: 0x04000A87 RID: 2695
		private Mesh mesh_0;

		// Token: 0x04000A88 RID: 2696
		private CustomVertex.PositionColored positionColored_0;

		// Token: 0x04000A89 RID: 2697
		private static Effect effect_0 = null;

		// Token: 0x04000A8A RID: 2698
		private static Effect effect_1 = null;

		// Token: 0x04000A8B RID: 2699
		private int int_9 = 2;

		// Token: 0x04000A8C RID: 2700
		private float[] float_21;

		// Token: 0x04000A8D RID: 2701
		private float[] float_22;

		// Token: 0x020003FD RID: 1021
		private sealed class MeshSubset
		{
			// Token: 0x04000A8E RID: 2702
			public CustomVertex.PositionColored[] positionColored_0;

			// Token: 0x04000A8F RID: 2703
			public CustomVertex.PositionColored[] positionColored_1;

			// Token: 0x04000A90 RID: 2704
			public BoundingBox class1941_0;
		}
	}
}
