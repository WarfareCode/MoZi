using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using ns17;
using ns18;
using ns19;

namespace ns16
{
	// Token: 0x02000496 RID: 1174
	public sealed class Class1992 : IDisposable
	{
		// Token: 0x06001E48 RID: 7752 RVA: 0x000C3B74 File Offset: 0x000C1D74
		public Class1992(double double_7, double double_8, double double_9, double double_10, int int_5, Class1998 class1998_1)
		{
			this.double_3 = double_7;
			this.double_2 = double_8;
			this.double_0 = double_9;
			this.double_1 = double_10;
			this.struct63_0 = Angle.FromDegrees(0.5 * (this.double_2 + this.double_3));
			this.struct63_1 = Angle.FromDegrees(0.5 * (this.double_0 + this.double_1));
			this.double_4 = Math.Abs(this.double_2 - this.double_3);
			this.double_5 = Math.Abs(this.double_1 - this.double_0);
			this.int_0 = int_5;
			this.class1998_0 = class1998_1;
			this.class1941_0 = new BoundingBox((float)double_7, (float)double_8, (float)double_9, (float)double_10, (float)class1998_1.method_10(), (float)class1998_1.method_10() + 300000f);
			this.class1953_0 = MathEngine.SphericalToCartesianD(this.struct63_0, this.struct63_1, class1998_1.method_10());
			this.class1953_0.X = (double)((float)(Math.Round(this.class1953_0.X / 10000.0) * 10000.0));
			this.class1953_0.Y = (double)((float)(Math.Round(this.class1953_0.Y / 10000.0) * 10000.0));
			this.class1953_0.Z = (double)((float)(Math.Round(this.class1953_0.Z / 10000.0) * 10000.0));
			this.int_1 = MathEngine.GetRowFromLatitude(this.double_3, this.double_2 - this.double_3);
			this.int_2 = MathEngine.GetColFromLongitude(this.double_0, this.double_2 - this.double_3);
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x000C3DB8 File Offset: 0x000C1FB8
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x000C3DD0 File Offset: 0x000C1FD0
		private Class1992 method_1(double double_7, double double_8, double double_9, double double_10)
		{
			return new Class1992(double_7, double_8, double_9, double_10, this.int_0 + 1, this.class1998_0);
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000C3DF8 File Offset: 0x000C1FF8
		public  void vmethod_0(DrawArgs class1943_0)
		{
			if (this.int_0 + 1 < this.class1998_0.method_21()[0].method_2())
			{
				double num = 0.5 * (this.double_3 + this.double_2);
				double num2 = 0.5 * (this.double_1 + this.double_0);
				if (this.class1992_0 == null)
				{
					this.class1992_0 = this.method_1(num, this.double_2, this.double_0, num2);
				}
				if (this.class1992_2 == null)
				{
					this.class1992_2 = this.method_1(num, this.double_2, num2, this.double_1);
				}
				if (this.class1992_1 == null)
				{
					this.class1992_1 = this.method_1(this.double_3, num, this.double_0, num2);
				}
				if (this.class1992_3 == null)
				{
					this.class1992_3 = this.method_1(this.double_3, num, num2, this.double_1);
				}
			}
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x000C3EF8 File Offset: 0x000C20F8
		public  void Dispose()
		{
			try
			{
				this.bool_0 = false;
				if (this.texture_0 != null)
				{
					Texture[] array = this.texture_0;
					lock (array)
					{
						for (int i = 0; i < this.texture_0.Length; i++)
						{
							if (this.texture_0[i] != null && !this.texture_0[i].Disposed)
							{
								this.texture_0[i].Dispose();
								this.texture_0[i] = null;
							}
						}
					}
				}
				this.texture_0 = null;
				if (this.class1992_0 != null)
				{
					this.class1992_0.Dispose();
					this.class1992_0 = null;
				}
				if (this.class1992_1 != null)
				{
					this.class1992_1.Dispose();
					this.class1992_1 = null;
				}
				if (this.class1992_2 != null)
				{
					this.class1992_2.Dispose();
					this.class1992_2 = null;
				}
				if (this.class1992_3 != null)
				{
					this.class1992_3.Dispose();
					this.class1992_3 = null;
				}
				if (this.class2003_0 != null)
				{
					this.class1998_0.vmethod_21(this.class2003_0);
					this.class2003_0.Dispose();
					this.class2003_0 = null;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x000C406C File Offset: 0x000C226C
		public  void vmethod_1()
		{
			if (!this.bool_1 && this.class2003_0 == null)
			{
				try
				{
					if (this.texture_0 == null)
					{
						this.texture_0 = new Texture[this.class1998_0.method_21().Length];
					}
					Texture[] array = this.texture_0;
					lock (array)
					{
						this.bool_3 = false;
						for (int i = 0; i < this.texture_0.Length; i++)
						{
							Texture texture = this.class1998_0.method_21()[i].method_8(this);
							if (texture == null)
							{
								this.bool_3 = true;
							}
							if (this.texture_0 == null)
							{
								Log.smethod_0("This should never happen!");
							}
							if (this.texture_0[i] != null)
							{
								this.texture_0[i].Dispose();
							}
							this.texture_0[i] = texture;
						}
						if (!this.bool_3)
						{
							this.bool_4 = false;
							this.vmethod_3();
						}
					}
				}
				catch (Exception exception_)
				{
					Log.smethod_3(exception_);
				}
				finally
				{
					this.bool_0 = true;
				}
			}
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x000C41BC File Offset: 0x000C23BC
		public  void vmethod_2(DrawArgs class1943_0)
		{
			if (!this.bool_1)
			{
				try
				{
					double num = this.double_2 - this.double_3;
					if (!this.bool_0)
					{
						if (((this.int_0 == 0 && this.class1998_0.method_11()) || (Angle.IsLittleThan(Angle.Multiply(DrawArgs.class1987_1.GetViewRange(), 0.5), Angle.FromDegrees((double)this.class1998_0.method_15() * num)) && Angle.IsLittleThan(MathEngine.SphericalDistance(this.struct63_0, this.struct63_1, DrawArgs.class1987_1.GetLatitude(), DrawArgs.class1987_1.GetLongitude()), Angle.FromDegrees((double)this.class1998_0.method_13() * num * 1.25)))) && DrawArgs.class1987_1.GetViewFrustum().Contains(this.class1941_0))
						{
							this.vmethod_1();
						}
						this.class1998_0.method_0(true);
					}
					if ((this.bool_0 && World.Settings.GetVerticalExaggeration() != this.float_0) || this.byte_0 != this.class1998_0.GetOpacity() || this.class1998_0.method_3() != this.bool_5)
					{
						this.vmethod_3();
					}
					if (this.bool_0)
					{
						if (Angle.IsLittleThan(DrawArgs.class1987_1.GetViewRange(), Angle.FromDegrees((double)this.class1998_0.method_15() * num)) && Angle.IsLittleThan(MathEngine.SphericalDistance(this.struct63_0, this.struct63_1, DrawArgs.class1987_1.GetLatitude(), DrawArgs.class1987_1.GetLongitude()), Angle.FromDegrees((double)this.class1998_0.method_13() * num)) && DrawArgs.class1987_1.GetViewFrustum().Contains(this.class1941_0))
						{
							if (this.class1992_2 == null || this.class1992_0 == null || this.class1992_3 == null || this.class1992_1 == null)
							{
								this.vmethod_0(class1943_0);
							}
							if (this.class1992_2 != null)
							{
								this.class1992_2.vmethod_2(class1943_0);
							}
							if (this.class1992_0 != null)
							{
								this.class1992_0.vmethod_2(class1943_0);
							}
							if (this.class1992_3 != null)
							{
								this.class1992_3.vmethod_2(class1943_0);
							}
							if (this.class1992_1 != null)
							{
								this.class1992_1.vmethod_2(class1943_0);
							}
						}
						else
						{
							if (this.class1992_0 != null)
							{
								this.class1992_0.Dispose();
								this.class1992_0 = null;
							}
							if (this.class1992_2 != null)
							{
								this.class1992_2.Dispose();
								this.class1992_2 = null;
							}
							if (this.class1992_3 != null)
							{
								this.class1992_3.Dispose();
								this.class1992_3 = null;
							}
							if (this.class1992_1 != null)
							{
								this.class1992_1.Dispose();
								this.class1992_1 = null;
							}
						}
					}
					if (this.bool_0 && (Angle.IsLargerThan(Angle.Divide(DrawArgs.class1987_1.GetViewRange(), 2.0), Angle.FromDegrees((double)this.class1998_0.method_15() * num * 1.5)) || Angle.IsLargerThan(MathEngine.SphericalDistance(this.struct63_0, this.struct63_1, DrawArgs.class1987_1.GetLatitude(), DrawArgs.class1987_1.GetLongitude()), Angle.FromDegrees((double)this.class1998_0.method_13() * num * 1.5))) && (this.int_0 != 0 || (this.int_0 == 0 && !this.class1998_0.method_11())))
					{
						this.Dispose();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x000C4574 File Offset: 0x000C2774
		public  void vmethod_3()
		{
			this.float_0 = World.Settings.GetVerticalExaggeration();
			this.byte_0 = this.class1998_0.GetOpacity();
			this.bool_5 = this.class1998_0.method_3();
			if (this.class1998_0.method_20() && (double)Math.Abs(this.float_0) > 0.001)
			{
				this.vmethod_5();
			}
			else
			{
				this.vmethod_4();
			}
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x000C45F0 File Offset: 0x000C27F0
		protected  void vmethod_4()
		{
			double num = this.class1998_0.method_10();
			double num2 = 1.0 / (double)Class1992.int_3;
			int num3 = Class1992.int_3 / 2 + Class1992.int_3 % 2;
			int num4 = num3 + 1;
			int num5 = num4 * num4;
			this.positionNormalTextured_0 = new CustomVertex.PositionNormalTextured[num5];
			this.positionNormalTextured_1 = new CustomVertex.PositionNormalTextured[num5];
			this.positionNormalTextured_2 = new CustomVertex.PositionNormalTextured[num5];
			this.positionNormalTextured_3 = new CustomVertex.PositionNormalTextured[num5];
			double[] array = new double[num4];
			double[] array2 = new double[num4];
			double num6 = this.double_0 * 0.017453292519943295;
			double num7 = num2 * this.double_5 * 0.017453292519943295;
			for (int i = 0; i < num4; i++)
			{
				num6 = this.double_0 * 0.017453292519943295 + (double)i * num7;
				array[i] = Math.Sin(num6);
				array2[i] = Math.Cos(num6);
			}
			int num8 = 0;
			num6 = this.double_2 * 0.017453292519943295;
			num7 = -num2 * this.double_4 * 0.017453292519943295;
			for (int j = 0; j < num4; j++)
			{
				num6 = this.double_2 * 0.017453292519943295 + (double)j * num7;
				double num9 = Math.Sin(num6);
				double num10 = Math.Cos(num6) * num;
				for (int k = 0; k < num4; k++)
				{
					this.positionNormalTextured_0[num8].X = (float)(num10 * array2[k] - this.class1953_0.X);
					this.positionNormalTextured_0[num8].Y = (float)(num10 * array[k] - this.class1953_0.Y);
					this.positionNormalTextured_0[num8].Z = (float)(num * num9 - this.class1953_0.Z);
					this.positionNormalTextured_0[num8].Tu = (float)((double)k * num2);
					this.positionNormalTextured_0[num8].Tv = (float)((double)j * num2);
					this.positionNormalTextured_0[num8].Normal = new Vector3(this.positionNormalTextured_0[num8].X + (float)this.class1953_0.X, this.positionNormalTextured_0[num8].Y + (float)this.class1953_0.Y, this.positionNormalTextured_0[num8].Z + (float)this.class1953_0.Z);
					this.positionNormalTextured_0[num8].Normal.Normalize();
					num8++;
				}
			}
			num8 = 0;
			num6 = 0.5 * (this.double_2 + this.double_3) * 0.017453292519943295;
			for (int l = 0; l < num4; l++)
			{
				num6 = 0.5 * (this.double_2 + this.double_3) * 0.017453292519943295 + (double)l * num7;
				double num11 = Math.Sin(num6);
				double num12 = Math.Cos(num6) * num;
				for (int m = 0; m < num4; m++)
				{
					this.positionNormalTextured_1[num8].X = (float)(num12 * array2[m] - this.class1953_0.X);
					this.positionNormalTextured_1[num8].Y = (float)(num12 * array[m] - this.class1953_0.Y);
					this.positionNormalTextured_1[num8].Z = (float)(num * num11 - this.class1953_0.Z);
					this.positionNormalTextured_1[num8].Tu = (float)((double)m * num2);
					this.positionNormalTextured_1[num8].Tv = (float)((double)(l + num3) * num2);
					this.positionNormalTextured_1[num8].Normal = new Vector3(this.positionNormalTextured_1[num8].X + (float)this.class1953_0.X, this.positionNormalTextured_1[num8].Y + (float)this.class1953_0.Y, this.positionNormalTextured_1[num8].Z + (float)this.class1953_0.Z);
					this.positionNormalTextured_1[num8].Normal.Normalize();
					num8++;
				}
			}
			num6 = 0.5 * (this.double_0 + this.double_1) * 0.017453292519943295;
			num7 = num2 * this.double_5 * 0.017453292519943295;
			for (int n = 0; n < num4; n++)
			{
				num6 = 0.5 * (this.double_0 + this.double_1) * 0.017453292519943295 + (double)n * num7;
				array[n] = Math.Sin(num6);
				array2[n] = Math.Cos(num6);
			}
			num8 = 0;
			num6 = this.double_2 * 0.017453292519943295;
			num7 = -num2 * this.double_4 * 0.017453292519943295;
			for (int num13 = 0; num13 < num4; num13++)
			{
				num6 = this.double_2 * 0.017453292519943295 + (double)num13 * num7;
				double num14 = Math.Sin(num6);
				double num15 = Math.Cos(num6) * num;
				for (int num16 = 0; num16 < num4; num16++)
				{
					this.positionNormalTextured_2[num8].X = (float)(num15 * array2[num16] - this.class1953_0.X);
					this.positionNormalTextured_2[num8].Y = (float)(num15 * array[num16] - this.class1953_0.Y);
					this.positionNormalTextured_2[num8].Z = (float)(num * num14 - this.class1953_0.Z);
					this.positionNormalTextured_2[num8].Tu = (float)((double)(num16 + num3) * num2);
					this.positionNormalTextured_2[num8].Tv = (float)((double)num13 * num2);
					this.positionNormalTextured_2[num8].Normal = new Vector3(this.positionNormalTextured_2[num8].X + (float)this.class1953_0.X, this.positionNormalTextured_2[num8].Y + (float)this.class1953_0.Y, this.positionNormalTextured_2[num8].Z + (float)this.class1953_0.Z);
					this.positionNormalTextured_2[num8].Normal.Normalize();
					num8++;
				}
			}
			num8 = 0;
			num6 = 0.5 * (this.double_2 + this.double_3) * 0.017453292519943295;
			for (int num17 = 0; num17 < num4; num17++)
			{
				num6 = 0.5 * (this.double_2 + this.double_3) * 0.017453292519943295 + (double)num17 * num7;
				double num18 = Math.Sin(num6);
				double num19 = Math.Cos(num6) * num;
				for (int num20 = 0; num20 < num4; num20++)
				{
					this.positionNormalTextured_3[num8].X = (float)(num19 * array2[num20] - this.class1953_0.X);
					this.positionNormalTextured_3[num8].Y = (float)(num19 * array[num20] - this.class1953_0.Y);
					this.positionNormalTextured_3[num8].Z = (float)(num * num18 - this.class1953_0.Z);
					this.positionNormalTextured_3[num8].Tu = (float)((double)(num20 + num3) * num2);
					this.positionNormalTextured_3[num8].Tv = (float)((double)(num17 + num3) * num2);
					this.positionNormalTextured_3[num8].Normal = new Vector3(this.positionNormalTextured_3[num8].X + (float)this.class1953_0.X, this.positionNormalTextured_3[num8].Y + (float)this.class1953_0.Y, this.positionNormalTextured_3[num8].Z + (float)this.class1953_0.Z);
					this.positionNormalTextured_3[num8].Normal.Normalize();
					num8++;
				}
			}
			this.short_0 = new short[2 * num3 * num3 * 3];
			for (int num21 = 0; num21 < num3; num21++)
			{
				num8 = 6 * num21 * num3;
				for (int num22 = 0; num22 < num3; num22++)
				{
					this.short_0[num8] = (short)(num21 * num4 + num22);
					this.short_0[num8 + 1] = (short)((num21 + 1) * num4 + num22);
					this.short_0[num8 + 2] = (short)(num21 * num4 + num22 + 1);
					this.short_0[num8 + 3] = (short)(num21 * num4 + num22 + 1);
					this.short_0[num8 + 4] = (short)((num21 + 1) * num4 + num22);
					this.short_0[num8 + 5] = (short)((num21 + 1) * num4 + num22 + 1);
					num8 += 6;
				}
			}
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x000C4F50 File Offset: 0x000C3150
		protected  void vmethod_5()
		{
			this.bool_2 = true;
			double num = this.double_4 / (double)Class1992.int_4;
			float[,] array = this.class1998_0.vmethod_4().GetTerrainAccessor().vmethod_2(this.double_2 + num, this.double_3 - num, this.double_0 - num, this.double_1 + num, Class1992.int_4 + 3).float_0;
			int num2 = Class1992.int_4 / 2 + 3;
			int num3 = num2 * num2;
			this.positionNormalTextured_0 = new CustomVertex.PositionNormalTextured[num3];
			this.positionNormalTextured_1 = new CustomVertex.PositionNormalTextured[num3];
			this.positionNormalTextured_2 = new CustomVertex.PositionNormalTextured[num3];
			this.positionNormalTextured_3 = new CustomVertex.PositionNormalTextured[num3];
			double num4 = this.class1998_0.method_10();
			float num5 = 3.40282347E+38f;
			float num6 = -3.40282347E+38f;
			float[,] array2 = array;
			int upperBound = array2.GetUpperBound(0);
			int upperBound2 = array2.GetUpperBound(1);
			for (int i = array2.GetLowerBound(0); i <= upperBound; i++)
			{
				for (int j = array2.GetLowerBound(1); j <= upperBound2; j++)
				{
					float num7 = array2[i, j];
					if (num7 < num5)
					{
						num5 = num7;
					}
					if (num7 > num6)
					{
						num6 = num7;
					}
				}
			}
			num5 *= this.float_0;
			num6 *= this.float_0;
			if (num5 > num6)
			{
				num5 = num6;
			}
			double num8 = (double)(500f * this.float_0);
			this.double_6 = num4 + (double)num5 - num8;
			this.method_2(Class1992.Enum152.const_0, this.positionNormalTextured_0, this.double_6, array);
			this.method_2(Class1992.Enum152.const_1, this.positionNormalTextured_1, this.double_6, array);
			this.method_2(Class1992.Enum152.const_2, this.positionNormalTextured_2, this.double_6, array);
			this.method_2(Class1992.Enum152.const_3, this.positionNormalTextured_3, this.double_6, array);
			this.class1941_0 = new BoundingBox((float)this.double_3, (float)this.double_2, (float)this.double_0, (float)this.double_1, (float)num4, (float)num4 + 10000f * this.float_0);
			this.class1998_0.method_17(false);
			int num9 = Class1992.int_4 / 2 + 2;
			this.short_0 = new short[2 * num9 * num9 * 3];
			int num10 = 0;
			for (int k = 0; k < num9; k++)
			{
				for (int l = 0; l < num9; l++)
				{
					this.short_0[num10++] = (short)(k * num2 + l);
					this.short_0[num10++] = (short)((k + 1) * num2 + l);
					this.short_0[num10++] = (short)(k * num2 + l + 1);
					this.short_0[num10++] = (short)(k * num2 + l + 1);
					this.short_0[num10++] = (short)((k + 1) * num2 + l);
					this.short_0[num10++] = (short)((k + 1) * num2 + l + 1);
				}
			}
			this.method_3(ref this.positionNormalTextured_0, this.short_0);
			this.method_3(ref this.positionNormalTextured_1, this.short_0);
			this.method_3(ref this.positionNormalTextured_2, this.short_0);
			this.method_3(ref this.positionNormalTextured_3, this.short_0);
			this.bool_2 = false;
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x000C5298 File Offset: 0x000C3498
		protected void method_2(Class1992.Enum152 enum152_0, CustomVertex.PositionNormalTextured[] positionNormalTextured_4, double double_7, float[,] float_1)
		{
			double num = MathEngine.DegreesToRadians(this.double_2);
			double num2 = MathEngine.DegreesToRadians(this.double_0);
			float num3 = 0f;
			float num4 = 0f;
			switch (enum152_0)
			{
			case Class1992.Enum152.const_1:
				num = MathEngine.DegreesToRadians(0.5 * (this.double_2 + this.double_3));
				num4 = 0.5f;
				break;
			case Class1992.Enum152.const_2:
				num2 = MathEngine.DegreesToRadians(0.5 * (this.double_0 + this.double_1));
				num3 = 0.5f;
				break;
			case Class1992.Enum152.const_3:
				num = MathEngine.DegreesToRadians(0.5 * (this.double_2 + this.double_3));
				num2 = MathEngine.DegreesToRadians(0.5 * (this.double_0 + this.double_1));
				num3 = 0.5f;
				num4 = 0.5f;
				break;
			}
			double num5 = MathEngine.DegreesToRadians(this.double_4);
			double num6 = MathEngine.DegreesToRadians(this.double_5);
			double num7 = this.class1998_0.method_10();
			double num8 = 1.0 / (double)Class1992.int_4;
			int num9 = (int)(num3 * (float)Class1992.int_4) + 1;
			int num10 = (int)(num4 * (float)Class1992.int_4) + 1;
			int num11 = Class1992.int_4 / 2 + 1;
			int num12 = 0;
			for (int i = -1; i <= num11; i++)
			{
				double num13 = (double)i * num8;
				double num14 = num - num13 * num5;
				double num15 = Math.Cos(num14);
				double num16 = Math.Sin(num14);
				for (int j = -1; j <= num11; j++)
				{
					double num17 = num7 + (double)(float_1[num10 + i, num9 + j] * this.float_0);
					double num18 = (double)j * num8;
					positionNormalTextured_4[num12].Tu = num3 + (float)num18;
					positionNormalTextured_4[num12].Tv = num4 + (float)num13;
					double num19 = num2 + num18 * num6;
					double num20 = num17 * num15;
					positionNormalTextured_4[num12].X = (float)(num20 * Math.Cos(num19) - this.class1953_0.X);
					positionNormalTextured_4[num12].Y = (float)(num20 * Math.Sin(num19) - this.class1953_0.Y);
					positionNormalTextured_4[num12].Z = (float)(num17 * num16 - this.class1953_0.Z);
					num12++;
				}
			}
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x000C54FC File Offset: 0x000C36FC
		private void method_3(ref CustomVertex.PositionNormalTextured[] positionNormalTextured_4, short[] short_1)
		{
			List<Vector3>[] array = new List<Vector3>[positionNormalTextured_4.Length];
			for (int i = 0; i < positionNormalTextured_4.Length; i++)
			{
				array[i] = new List<Vector3>(short_1.Length);
			}
			for (int j = 0; j < short_1.Length; j += 3)
			{
				Vector3 position = positionNormalTextured_4[(int)short_1[j]].Position;
				Vector3 position2 = positionNormalTextured_4[(int)short_1[j + 1]].Position;
				Vector3 position3 = positionNormalTextured_4[(int)short_1[j + 2]].Position;
				Vector3 left = position2 - position;
				Vector3 right = position3 - position;
				Vector3 item = Vector3.Cross(left, right);
				item.Normalize();
				array[(int)short_1[j]].Add(item);
				array[(int)short_1[j + 1]].Add(item);
				array[(int)short_1[j + 2]].Add(item);
			}
			for (int k = 0; k < positionNormalTextured_4.Length; k++)
			{
				for (int l = 0; l < array[k].Count; l++)
				{
					Vector3 vector = array[k][l];
					if (positionNormalTextured_4[k].Normal == Vector3.Empty)
					{
						positionNormalTextured_4[k].Normal = vector;
					}
					else
					{
						CustomVertex.PositionNormalTextured[] array2 = positionNormalTextured_4;
						int num = k;
						array2[num].Normal = array2[num].Normal + vector;
					}
				}
				positionNormalTextured_4[k].Normal.Multiply(1f / (float)array[k].Count);
			}
			short num2 = (short)Math.Sqrt((double)positionNormalTextured_4.Length);
			for (int m = 0; m < (int)num2; m++)
			{
				if (m == 0 || m == (int)(num2 - 1))
				{
					for (int n = 0; n < (int)num2; n++)
					{
						int num3 = (int)((m == 0) ? num2 : (-(int)num2));
						if (n == 0)
						{
							num3++;
						}
						if (n == (int)(num2 - 1))
						{
							num3--;
						}
						Point3d point3d = new Point3d((double)positionNormalTextured_4[m * (int)num2 + n + num3].Position.X, (double)positionNormalTextured_4[m * (int)num2 + n + num3].Position.Y, (double)positionNormalTextured_4[m * (int)num2 + n + num3].Position.Z);
						if (this.bool_5 && this.byte_0 == 255)
						{
							point3d = this.method_4(point3d);
						}
						positionNormalTextured_4[m * (int)num2 + n].Position = new Vector3((float)point3d.X, (float)point3d.Y, (float)point3d.Z);
					}
				}
				else
				{
					Point3d point3d2 = new Point3d((double)positionNormalTextured_4[m * (int)num2 + 1].Position.X, (double)positionNormalTextured_4[m * (int)num2 + 1].Position.Y, (double)positionNormalTextured_4[m * (int)num2 + 1].Position.Z);
					if (this.bool_5 && this.byte_0 == 255)
					{
						point3d2 = this.method_4(point3d2);
					}
					positionNormalTextured_4[m * (int)num2].Position = new Vector3((float)point3d2.X, (float)point3d2.Y, (float)point3d2.Z);
					point3d2 = new Point3d((double)positionNormalTextured_4[m * (int)num2 + (int)num2 - 2].Position.X, (double)positionNormalTextured_4[m * (int)num2 + (int)num2 - 2].Position.Y, (double)positionNormalTextured_4[m * (int)num2 + (int)num2 - 2].Position.Z);
					if (this.bool_5 && this.byte_0 == 255)
					{
						point3d2 = this.method_4(point3d2);
					}
					positionNormalTextured_4[m * (int)num2 + (int)num2 - 1].Position = new Vector3((float)point3d2.X, (float)point3d2.Y, (float)point3d2.Z);
				}
			}
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x000C592C File Offset: 0x000C3B2C
		private Point3d method_4(Point3d class1953_1)
		{
			class1953_1 = Point3d.addition(class1953_1, this.class1953_0);
			class1953_1 = class1953_1.normalize();
			class1953_1 = Point3d.subtraction(Point3d.multiply(class1953_1, this.double_6), this.class1953_0);
			return class1953_1;
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x000C596C File Offset: 0x000C3B6C
		public   bool vmethod_6(DrawArgs class1943_0)
		{
			bool result;
			try
			{
				if (!this.bool_0 || this.positionNormalTextured_0 == null || this.positionNormalTextured_2 == null || this.positionNormalTextured_3 == null || this.positionNormalTextured_1 == null)
				{
					result = false;
					return result;
				}
				if (!DrawArgs.class1987_1.GetViewFrustum().Contains(this.class1941_0))
				{
					result = false;
					return result;
				}
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				if (this.class1992_0 != null && this.class1992_0.vmethod_6(class1943_0))
				{
					flag = true;
				}
				if (this.class1992_1 != null && this.class1992_1.vmethod_6(class1943_0))
				{
					flag3 = true;
				}
				if (this.class1992_2 != null && this.class1992_2.vmethod_6(class1943_0))
				{
					flag2 = true;
				}
				if (this.class1992_3 != null && this.class1992_3.vmethod_6(class1943_0))
				{
					flag4 = true;
				}
				if (this.class1998_0.method_6() && (!flag || !flag2 || !flag3 || !flag4))
				{
					Vector3 vector = new Vector3((float)class1943_0.GetWorldCamera().ReferenceCenter.X, (float)class1943_0.GetWorldCamera().ReferenceCenter.Y, (float)class1943_0.GetWorldCamera().ReferenceCenter.Z);
					this.method_5(class1943_0, Color.FromArgb(255, 0, 0).ToArgb(), vector);
					Vector3 vector2 = MathEngine.SphericalToCartesian(this.struct63_0.GetDegrees(), this.struct63_1.GetDegrees(), class1943_0.GetWorldCamera().GetWorldRadius() + (double)class1943_0.GetWorldCamera().GetTerrainElevation());
					if (this.string_0 != null && class1943_0.GetWorldCamera().GetViewFrustum().ContainsPoint(vector2))
					{
						Vector3 vector3 = class1943_0.GetWorldCamera().Project(vector2 - vector);
						Rectangle rect = new Rectangle((int)vector3.X - 100, (int)vector3.Y, 200, 200);
						class1943_0.font_0.DrawText(null, this.string_0, rect, DrawTextFormat.WordBreak, Color.Red);
					}
				}
				if (flag & flag2 & flag3 & flag4)
				{
					result = true;
					return result;
				}
				Device device_ = DrawArgs.device_1;
				if (this.texture_0 != null)
				{
					for (int i = 0; i < this.texture_0.Length; i++)
					{
						if (this.texture_0[i] == null || this.texture_0[i].Disposed)
						{
							result = false;
							return result;
						}
						device_.SetTexture(i, this.texture_0[i]);
					}
				}
				class1943_0.int_5++;
				int num = 1;
				DrawArgs.device_1.Transform.World = Matrix.Translation((float)(this.class1953_0.X - class1943_0.GetWorldCamera().ReferenceCenter.X), (float)(this.class1953_0.Y - class1943_0.GetWorldCamera().ReferenceCenter.Y), (float)(this.class1953_0.Z - class1943_0.GetWorldCamera().ReferenceCenter.Z));
				for (int j = 0; j < num; j++)
				{
					if (!flag)
					{
						this.method_6(device_, this.positionNormalTextured_0, this.class1992_0);
					}
					if (!flag3)
					{
						this.method_6(device_, this.positionNormalTextured_1, this.class1992_1);
					}
					if (!flag2)
					{
						this.method_6(device_, this.positionNormalTextured_2, this.class1992_2);
					}
					if (!flag4)
					{
						this.method_6(device_, this.positionNormalTextured_3, this.class1992_3);
					}
				}
				DrawArgs.device_1.Transform.World = DrawArgs.class1987_1.GetWorldMatrix();
				result = true;
				return result;
			}
			catch (DirectXException)
			{
			}
			result = false;
			return result;
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x000C5D28 File Offset: 0x000C3F28
		public void method_5(DrawArgs class1943_0, int int_5, Vector3 vector3_0)
		{
			if (World.Settings.method_3())
			{
				Vector3 vector = MathEngine.SphericalToCartesian((double)((float)this.double_2), (double)((float)this.double_0), this.class1998_0.method_10()) - vector3_0;
				Vector3 vector2 = MathEngine.SphericalToCartesian((double)((float)this.double_3), (double)((float)this.double_0), this.class1998_0.method_10()) - vector3_0;
				Vector3 vector3 = MathEngine.SphericalToCartesian((double)((float)this.double_2), (double)((float)this.double_1), this.class1998_0.method_10()) - vector3_0;
				Vector3 vector4 = MathEngine.SphericalToCartesian((double)((float)this.double_3), (double)((float)this.double_1), this.class1998_0.method_10()) - vector3_0;
				this.positionColored_0[0].X = vector.X;
				this.positionColored_0[0].Y = vector.Y;
				this.positionColored_0[0].Z = vector.Z;
				this.positionColored_0[0].Color = int_5;
				this.positionColored_0[1].X = vector2.X;
				this.positionColored_0[1].Y = vector2.Y;
				this.positionColored_0[1].Z = vector2.Z;
				this.positionColored_0[1].Color = int_5;
				this.positionColored_0[2].X = vector4.X;
				this.positionColored_0[2].Y = vector4.Y;
				this.positionColored_0[2].Z = vector4.Z;
				this.positionColored_0[2].Color = int_5;
				this.positionColored_0[3].X = vector3.X;
				this.positionColored_0[3].Y = vector3.Y;
				this.positionColored_0[3].Z = vector3.Z;
				this.positionColored_0[3].Color = int_5;
				this.positionColored_0[4].X = this.positionColored_0[0].X;
				this.positionColored_0[4].Y = this.positionColored_0[0].Y;
				this.positionColored_0[4].Z = this.positionColored_0[0].Z;
				this.positionColored_0[4].Color = int_5;
				class1943_0.device_0.RenderState.ZBufferEnable = false;
				class1943_0.device_0.VertexFormat = (VertexFormats.Diffuse | VertexFormats.Position);
				class1943_0.device_0.TextureState[0].ColorOperation = TextureOperation.Disable;
				class1943_0.device_0.DrawUserPrimitives(PrimitiveType.LineStrip, 4, this.positionColored_0);
				class1943_0.device_0.TextureState[0].ColorOperation = TextureOperation.SelectArg1;
				class1943_0.device_0.VertexFormat = (VertexFormats.PositionNormal | VertexFormats.Texture1);
				class1943_0.device_0.RenderState.ZBufferEnable = true;
			}
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x000C6044 File Offset: 0x000C4244
		private void method_6(Device device_0, CustomVertex.PositionNormalTextured[] positionNormalTextured_4, Class1992 class1992_4)
		{
			bool flag = false;
			if (!World.Settings.IsEnableSunShading() && World.Settings.method_3() && class1992_4 != null)
			{
				if (class1992_4.bool_2)
				{
					device_0.SetTexture(1, Class1998.texture_3);
					flag = true;
				}
				else if (class1992_4.bool_3)
				{
					if (class1992_4.bool_4)
					{
						device_0.SetTexture(1, Class1998.texture_1);
					}
					else
					{
						device_0.SetTexture(1, Class1998.texture_2);
					}
					flag = true;
				}
			}
			if (flag)
			{
				device_0.SetTextureStageState(1, TextureStageStates.ColorOperation, 13);
			}
			if (positionNormalTextured_4 != null && this.short_0 != null)
			{
				if (this.class1998_0.method_24() != null)
				{
					Effect effect = this.class1998_0.method_24();
					effect.Technique = effect.GetTechnique(0);
					effect.SetValue("WorldViewProj", Matrix.Multiply(device_0.Transform.World, Matrix.Multiply(device_0.Transform.View, device_0.Transform.Projection)));
					try
					{
						effect.SetValue("Tex0", this.texture_0[0]);
						effect.SetValue("Tex1", this.texture_0[1]);
						effect.SetValue("Brightness", this.class1998_0.method_1());
						float f = (float)this.class1998_0.GetOpacity() / 255f;
						effect.SetValue("Opacity", f);
					}
					catch
					{
					}
					int num = effect.Begin(FX.None);
					for (int i = 0; i < num; i++)
					{
						effect.BeginPass(i);
						device_0.DrawIndexedUserPrimitives(PrimitiveType.TriangleList, 0, positionNormalTextured_4.Length, this.short_0.Length / 3, this.short_0, true, positionNormalTextured_4);
						effect.EndPass();
					}
					effect.End();
				}
				else if (this.class1998_0.method_2() && device_0.DeviceCaps.PixelShaderVersion.Major >= 1)
				{
					if (Class1992.effect_0 == null)
					{
						device_0.DeviceReset += new EventHandler(this.method_7);
						this.method_7(device_0, null);
					}
					Class1992.effect_0.Technique = "RenderGrayscaleBrightness";
					Class1992.effect_0.SetValue("WorldViewProj", Matrix.Multiply(device_0.Transform.World, Matrix.Multiply(device_0.Transform.View, device_0.Transform.Projection)));
					Class1992.effect_0.SetValue("Tex0", this.texture_0[0]);
					Class1992.effect_0.SetValue("Brightness", this.class1998_0.method_1());
					float f2 = (float)this.class1998_0.GetOpacity() / 255f;
					Class1992.effect_0.SetValue("Opacity", f2);
					int num2 = Class1992.effect_0.Begin(FX.None);
					for (int j = 0; j < num2; j++)
					{
						Class1992.effect_0.BeginPass(j);
						device_0.DrawIndexedUserPrimitives(PrimitiveType.TriangleList, 0, positionNormalTextured_4.Length, this.short_0.Length / 3, this.short_0, true, positionNormalTextured_4);
						Class1992.effect_0.EndPass();
					}
					Class1992.effect_0.End();
				}
				else
				{
					if (World.Settings.IsEnableSunShading() && !this.class1998_0.method_7())
					{
						Point3d point3d = Class1958.smethod_0(TimeKeeper.smethod_0());
						Vector3 direction = new Vector3((float)point3d.X, (float)point3d.Y, (float)point3d.Z);
						device_0.RenderState.Lighting = true;
						device_0.Material = new Material
						{
							Diffuse = Color.White,
							Ambient = Color.White
						};
						device_0.RenderState.AmbientColor = World.Settings.ShadingAmbientColor.ToArgb();
						device_0.RenderState.NormalizeNormals = true;
						device_0.RenderState.AlphaBlendEnable = true;
						device_0.Lights[0].Enabled = true;
						device_0.Lights[0].Type = LightType.Directional;
						device_0.Lights[0].Diffuse = Color.White;
						device_0.Lights[0].Direction = direction;
						device_0.TextureState[0].ColorOperation = TextureOperation.Modulate;
						device_0.TextureState[0].ColorArgument1 = TextureArgument.Diffuse;
						device_0.TextureState[0].ColorArgument2 = TextureArgument.TextureColor;
					}
					else
					{
						device_0.RenderState.Lighting = false;
						device_0.RenderState.Ambient = World.Settings.StandardAmbientColor;
					}
					device_0.RenderState.TextureFactor = Color.FromArgb((int)this.byte_0, 0, 0, 0).ToArgb();
					device_0.TextureState[0].AlphaOperation = TextureOperation.BlendFactorAlpha;
					device_0.TextureState[0].AlphaArgument1 = TextureArgument.TextureColor;
					device_0.TextureState[0].AlphaArgument2 = TextureArgument.TFactor;
					device_0.DrawIndexedUserPrimitives(PrimitiveType.TriangleList, 0, positionNormalTextured_4.Length, this.short_0.Length / 3, this.short_0, true, positionNormalTextured_4);
				}
			}
			if (flag)
			{
				device_0.SetTextureStageState(1, TextureStageStates.ColorOperation, 1);
			}
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x000C6574 File Offset: 0x000C4774
		private void method_7(object sender, EventArgs e)
		{
			Device device = (Device)sender;
			string text = "";
			try
			{
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("WorldWind.Shaders.grayscale.fx");
				Class1992.effect_0 = Effect.FromStream(device, manifestResourceStream, null, null, ShaderFlags.None, null, out text);
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

		// Token: 0x04000DC2 RID: 3522
		public Class1998 class1998_0;

		// Token: 0x04000DC3 RID: 3523
		public double double_0;

		// Token: 0x04000DC4 RID: 3524
		public double double_1;

		// Token: 0x04000DC5 RID: 3525
		public double double_2 = 0.0;

		// Token: 0x04000DC6 RID: 3526
		public double double_3 = 0.0;

		// Token: 0x04000DC7 RID: 3527
		public Angle struct63_0;

		// Token: 0x04000DC8 RID: 3528
		public Angle struct63_1;

		// Token: 0x04000DC9 RID: 3529
		public double double_4 = 0.0;

		// Token: 0x04000DCA RID: 3530
		public double double_5 = 0.0;

		// Token: 0x04000DCB RID: 3531
		public int int_0;

		// Token: 0x04000DCC RID: 3532
		public int int_1;

		// Token: 0x04000DCD RID: 3533
		public int int_2 = 0;

		// Token: 0x04000DCE RID: 3534
		public bool bool_0;

		// Token: 0x04000DCF RID: 3535
		public BoundingBox class1941_0;

		// Token: 0x04000DD0 RID: 3536
		public Class2003 class2003_0;

		// Token: 0x04000DD1 RID: 3537
		protected Texture[] texture_0;

		// Token: 0x04000DD2 RID: 3538
		protected static int int_3 = 40;

		// Token: 0x04000DD3 RID: 3539
		protected static int int_4 = 40;

		// Token: 0x04000DD4 RID: 3540
		protected Class1992 class1992_0;

		// Token: 0x04000DD5 RID: 3541
		protected Class1992 class1992_1;

		// Token: 0x04000DD6 RID: 3542
		protected Class1992 class1992_2;

		// Token: 0x04000DD7 RID: 3543
		protected Class1992 class1992_3;

		// Token: 0x04000DD8 RID: 3544
		protected CustomVertex.PositionNormalTextured[] positionNormalTextured_0;

		// Token: 0x04000DD9 RID: 3545
		protected CustomVertex.PositionNormalTextured[] positionNormalTextured_1;

		// Token: 0x04000DDA RID: 3546
		protected CustomVertex.PositionNormalTextured[] positionNormalTextured_2;

		// Token: 0x04000DDB RID: 3547
		protected CustomVertex.PositionNormalTextured[] positionNormalTextured_3;

		// Token: 0x04000DDC RID: 3548
		protected short[] short_0;

		// Token: 0x04000DDD RID: 3549
		protected Point3d class1953_0;

		// Token: 0x04000DDE RID: 3550
		protected bool bool_1;

		// Token: 0x04000DDF RID: 3551
		protected float float_0;

		// Token: 0x04000DE0 RID: 3552
		protected bool bool_2 = false;

		// Token: 0x04000DE1 RID: 3553
		public bool bool_3;

		// Token: 0x04000DE2 RID: 3554
		public bool bool_4;

		// Token: 0x04000DE3 RID: 3555
		private bool bool_5 = true;

		// Token: 0x04000DE4 RID: 3556
		private double double_6 = 0.0;

		// Token: 0x04000DE5 RID: 3557
		protected byte byte_0 = 255;

		// Token: 0x04000DE6 RID: 3558
		public string string_0;

		// Token: 0x04000DE7 RID: 3559
		protected CustomVertex.PositionColored[] positionColored_0 = new CustomVertex.PositionColored[5];

		// Token: 0x04000DE8 RID: 3560
		private static Effect effect_0 = null;

		// Token: 0x02000497 RID: 1175
		public enum Enum152
		{
			// Token: 0x04000DEA RID: 3562
			const_0,
			// Token: 0x04000DEB RID: 3563
			const_1,
			// Token: 0x04000DEC RID: 3564
			const_2,
			// Token: 0x04000DED RID: 3565
			const_3
		}
	}
}
