using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using ns16;
using ns17;
using ns19;

namespace ns18
{
	// Token: 0x0200039A RID: 922
	public sealed class ProjectedVectorTile
	{
		// Token: 0x06001653 RID: 5715 RVA: 0x0008E50C File Offset: 0x0008C70C
		public ProjectedVectorTile(GeographicBoundingBox class1944_1, ProjectedVectorRenderer class1955_1)
		{
			this.m_geographicBoundingBox = class1944_1;
			this.m_parentProjectedLayer = class1955_1;
			this.BoundingBox = new BoundingBox((float)class1944_1.double_1, (float)class1944_1.double_0, (float)class1944_1.double_2, (float)class1944_1.double_3, (float)(class1955_1.class1995_0.GetEquatorialRadius() + class1944_1.double_4), (float)(class1955_1.class1995_0.GetEquatorialRadius() + class1944_1.double_5 + 300000.0));
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0008E5B0 File Offset: 0x0008C7B0
		public void method_0()
		{
			this.bool_0 = false;
			this.bool_2 = true;
			if (this.m_NorthWestChild != null)
			{
				this.m_NorthWestChild.method_0();
			}
			if (this.m_NorthEastChild != null)
			{
				this.m_NorthEastChild.method_0();
			}
			if (this.m_SouthWestChild != null)
			{
				this.m_SouthWestChild.method_0();
			}
			if (this.m_SouthEastChild != null)
			{
				this.m_SouthEastChild.method_0();
			}
			if (this.m_NwImageLayer != null)
			{
				this.m_NwImageLayer.Dispose();
				this.m_NwImageLayer = null;
			}
			if (this.m_NeImageLayer != null)
			{
				this.m_NeImageLayer.Dispose();
				this.m_NeImageLayer = null;
			}
			if (this.m_SwImageLayer != null)
			{
				this.m_SwImageLayer.Dispose();
				this.m_SwImageLayer = null;
			}
			if (this.m_SeImageLayer != null)
			{
				this.m_SeImageLayer.Dispose();
				this.m_SeImageLayer = null;
			}
			if (this.stream_0 != null)
			{
				this.stream_0.Close();
			}
			if (!this.bool_1)
			{
				this.bool_2 = false;
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x0008E6BC File Offset: 0x0008C8BC
		private unsafe ImageLayer method_1(double double_0, double double_1, double double_2, double double_3, DrawArgs class1943_0, string string_1)
		{
			Bitmap bitmap = null;
			Graphics graphics = null;
			ImageLayer result = null;
			GeographicBoundingBox geographicBoundingBox = new GeographicBoundingBox(double_0, double_1, double_2, double_3);
			int num = 0;
			FileInfo fileInfo = new FileInfo(string_1);
			if (!this.m_parentProjectedLayer.bool_0 || !fileInfo.Exists)
			{
				if (this.m_parentProjectedLayer.method_1() != null)
				{
					for (int i = 0; i < this.m_parentProjectedLayer.method_1().Length; i++)
					{
						if (this.m_parentProjectedLayer.method_1()[i].bool_0)
						{
							GeographicBoundingBox geographicBoundingBox2 = this.m_parentProjectedLayer.method_1()[i].method_0();
							if (geographicBoundingBox2 == null || geographicBoundingBox2.method_0(geographicBoundingBox))
							{
								if (bitmap == null)
								{
									bitmap = new Bitmap(this.m_parentProjectedLayer.size_0.Width, this.m_parentProjectedLayer.size_0.Height, PixelFormat.Format32bppArgb);
								}
								if (graphics == null)
								{
									graphics = Graphics.FromImage(bitmap);
								}
								this.method_4(this.m_parentProjectedLayer.method_1()[i], graphics, geographicBoundingBox, bitmap.Size);
								num++;
							}
						}
					}
				}
				if (this.m_parentProjectedLayer.method_0() != null)
				{
					for (int j = 0; j < this.m_parentProjectedLayer.method_0().Length; j++)
					{
						if (this.m_parentProjectedLayer.method_0()[j].bool_2)
						{
							GeographicBoundingBox geographicBoundingBox3 = this.m_parentProjectedLayer.method_0()[j].method_0();
							if (geographicBoundingBox3 == null || geographicBoundingBox3.method_0(geographicBoundingBox))
							{
								if (bitmap == null)
								{
									bitmap = new Bitmap(this.m_parentProjectedLayer.size_0.Width, this.m_parentProjectedLayer.size_0.Height, PixelFormat.Format32bppArgb);
								}
								if (graphics == null)
								{
									graphics = Graphics.FromImage(bitmap);
								}
								this.method_5(this.m_parentProjectedLayer.method_0()[j], graphics, geographicBoundingBox, bitmap.Size);
								num++;
							}
						}
					}
				}
			}
			if (bitmap != null)
			{
				BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
				bool flag = true;
				int* ptr = (int*)((void*)bitmapData.Scan0);
				int k = 0;
				IL_2AD:
				while (k < bitmap.Height)
				{
					for (int l = 0; l < bitmap.Width; l++)
					{
						if ((*(ptr++) >> 24 & 255) > 0)
						{
							flag = false;
							ptr += (bitmapData.Stride >> 2) - bitmap.Width;
							k++;
							goto IL_2AD;
						}
					}
					ptr += (bitmapData.Stride >> 2) - bitmap.Width;
					k++;
				}
				bitmap.UnlockBits(bitmapData);
				if (flag)
				{
					num = 0;
				}
			}
			string string_2 = DateTime.Now.Ticks.ToString();
			if (bitmap != null && num > 0)
			{
				MemoryStream memoryStream = new MemoryStream();
				bitmap.Save(memoryStream, ImageFormat.Png);
				this.stream_0 = new MemoryStream(memoryStream.GetBuffer());
				result = new ImageLayer(string_2, this.m_parentProjectedLayer.class1995_0, 0.0, this.stream_0, Color.Black.ToArgb(), (double)((float)double_1), (double)((float)double_0), (double)((float)double_2), (double)((float)double_3), 1.0, this.m_parentProjectedLayer.class1995_0.GetTerrainAccessor());
				memoryStream.Close();
			}
			if (bitmap != null)
			{
				bitmap.Dispose();
			}
			if (graphics != null)
			{
				graphics.Dispose();
			}
			return result;
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0008EA60 File Offset: 0x0008CC60
		public void method_2(DrawArgs class1943_0)
		{
			try
			{
				this.bool_1 = true;
				this.method_3(class1943_0);
			}
			catch (Exception exception_)
			{
				Log.smethod_3(exception_);
			}
			finally
			{
				this.bool_1 = false;
				if (this.bool_2)
				{
					this.method_0();
					this.bool_0 = false;
				}
				else
				{
					this.bool_0 = true;
				}
			}
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x0008EAD0 File Offset: 0x0008CCD0
		private void method_3(DrawArgs class1943_0)
		{
			try
			{
				this.dateTime_0 = DateTime.Now;
				if (this.m_NwImageLayer != null)
				{
					this.m_NwImageLayer.Dispose();
				}
				if (this.m_NeImageLayer != null)
				{
					this.m_NeImageLayer.Dispose();
				}
				if (this.m_SwImageLayer != null)
				{
					this.m_SwImageLayer.Dispose();
				}
				if (this.m_SeImageLayer != null)
				{
					this.m_SeImageLayer.Dispose();
				}
				double num = 0.5 * (this.m_geographicBoundingBox.double_0 + this.m_geographicBoundingBox.double_1);
				double num2 = 0.5 * (this.m_geographicBoundingBox.double_2 + this.m_geographicBoundingBox.double_3);
				this.m_NwImageLayer = this.method_1(this.m_geographicBoundingBox.double_0, num, this.m_geographicBoundingBox.double_2, num2, class1943_0, string.Format("{0}\\{1}\\{2}\\{3:D4}\\{3:D4}_{4:D4}.dds", new object[]
				{
					null,
					"R",
					this.int_0 + 1,
					2 * this.int_1 + 1,
					2 * this.int_2
				}));
				this.m_NeImageLayer = this.method_1(this.m_geographicBoundingBox.double_0, num, num2, this.m_geographicBoundingBox.double_3, class1943_0, string.Format("{0}\\{1}\\{2}\\{3:D4}\\{3:D4}_{4:D4}.dds", new object[]
				{
					null,
					"R",
					this.int_0 + 1,
					2 * this.int_1 + 1,
					2 * this.int_2 + 1
				}));
				this.m_SwImageLayer = this.method_1(num, this.m_geographicBoundingBox.double_1, this.m_geographicBoundingBox.double_2, num2, class1943_0, string.Format("{0}\\{1}\\{2}\\{3:D4}\\{3:D4}_{4:D4}.dds", new object[]
				{
					null,
					"R",
					this.int_0 + 1,
					2 * this.int_1,
					2 * this.int_2
				}));
				this.m_SeImageLayer = this.method_1(num, this.m_geographicBoundingBox.double_1, num2, this.m_geographicBoundingBox.double_3, class1943_0, string.Format("{0}\\{1}\\{2}\\{3:D4}\\{3:D4}_{4:D4}.dds", new object[]
				{
					null,
					"R",
					this.int_0 + 1,
					2 * this.int_1,
					2 * this.int_2 + 1
				}));
				if (this.m_NwImageLayer != null)
				{
					this.m_NwImageLayer.Initialize(class1943_0);
				}
				if (this.m_NeImageLayer != null)
				{
					this.m_NeImageLayer.Initialize(class1943_0);
				}
				if (this.m_SwImageLayer != null)
				{
					this.m_SwImageLayer.Initialize(class1943_0);
				}
				if (this.m_SeImageLayer != null)
				{
					this.m_SeImageLayer.Initialize(class1943_0);
				}
			}
			catch (Exception exception_)
			{
				Log.smethod_3(exception_);
			}
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0008EDCC File Offset: 0x0008CFCC
		private void method_4(Class1950 class1950_0, Graphics graphics_0, GeographicBoundingBox class1944_1, Size size_0)
		{
			using (Pen pen = new Pen(class1950_0.color_0, class1950_0.float_0))
			{
				graphics_0.DrawLines(pen, this.method_6(class1950_0.class1953_0, 0, class1950_0.class1953_0.Length, class1944_1, size_0));
			}
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x0008EE2C File Offset: 0x0008D02C
		private void method_5(Class1954 class1954_0, Graphics graphics_0, GeographicBoundingBox class1944_1, Size size_0)
		{
			if (class1954_0.class1949_1 != null && class1954_0.class1949_1.Length != 0)
			{
				if (class1954_0.bool_1)
				{
					using (SolidBrush solidBrush = new SolidBrush(class1954_0.color_0))
					{
						graphics_0.FillPolygon(solidBrush, this.method_6(class1954_0.class1949_0.class1953_0, 0, class1954_0.class1949_0.class1953_0.Length, class1944_1, size_0));
					}
				}
				if (class1954_0.bool_0)
				{
					using (Pen pen = new Pen(class1954_0.color_1, class1954_0.float_0))
					{
						graphics_0.DrawPolygon(pen, this.method_6(class1954_0.class1949_0.class1953_0, 0, class1954_0.class1949_0.class1953_0.Length, class1944_1, size_0));
					}
				}
				if (!class1954_0.bool_1)
				{
					return;
				}
				using (SolidBrush solidBrush2 = new SolidBrush(Color.Black))
				{
					for (int i = 0; i < class1954_0.class1949_1.Length; i++)
					{
						graphics_0.FillPolygon(solidBrush2, this.method_6(class1954_0.class1949_1[i].class1953_0, 0, class1954_0.class1949_1[i].class1953_0.Length, class1944_1, size_0));
					}
					return;
				}
			}
			if (class1954_0.bool_1)
			{
				using (SolidBrush solidBrush3 = new SolidBrush(class1954_0.color_0))
				{
					graphics_0.FillPolygon(solidBrush3, this.method_6(class1954_0.class1949_0.class1953_0, 0, class1954_0.class1949_0.class1953_0.Length, class1944_1, size_0));
				}
			}
			if (class1954_0.bool_0)
			{
				using (Pen pen2 = new Pen(class1954_0.color_1, class1954_0.float_0))
				{
					graphics_0.DrawPolygon(pen2, this.method_6(class1954_0.class1949_0.class1953_0, 0, class1954_0.class1949_0.class1953_0.Length, class1944_1, size_0));
				}
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x0008F050 File Offset: 0x0008D250
		private Point[] method_6(Point3d[] class1953_0, int int_3, int int_4, GeographicBoundingBox class1944_1, Size size_0)
		{
			double num = (class1944_1.double_3 - class1944_1.double_2) / (double)size_0.Width;
			double num2 = (class1944_1.double_0 - class1944_1.double_1) / (double)size_0.Height;
			ArrayList arrayList = new ArrayList();
			int i = int_3;
			while (i < int_3 + int_4)
			{
				double num3 = (class1953_0[i].X - class1944_1.double_2) / num;
				double num4 = (class1944_1.double_0 - class1953_0[i].Y) / num2;
				if (arrayList.Count <= 0)
				{
					goto IL_A4;
				}
				Point point = (Point)arrayList[arrayList.Count - 1];
				if (point.X != (int)num3 || point.Y != (int)num4)
				{
					goto IL_A4;
				}
				IL_BB:
				i++;
				continue;
				IL_A4:
				arrayList.Add(new Point((int)num3, (int)num4));
				goto IL_BB;
			}
			Point[] result;
			if (arrayList.Count <= 1)
			{
				result = new Point[]
				{
					new Point(0, 0),
					new Point(0, 0)
				};
			}
			else
			{
				result = (Point[])arrayList.ToArray(typeof(Point));
			}
			return result;
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0008F184 File Offset: 0x0008D384
		private ProjectedVectorTile method_7(DrawArgs class1943_0, double double_0, double double_1, double double_2, double double_3, double double_4)
		{
			return new ProjectedVectorTile(new GeographicBoundingBox(double_1, double_0, double_2, double_3), this.m_parentProjectedLayer);
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0008F1AC File Offset: 0x0008D3AC
		public  void vmethod_0(DrawArgs class1943_0)
		{
			float num = (float)(0.5 * (this.m_geographicBoundingBox.double_0 - this.m_geographicBoundingBox.double_1));
			if ((double)num > 0.0001)
			{
				double num2 = 0.5 * (this.m_geographicBoundingBox.double_0 + this.m_geographicBoundingBox.double_1);
				double num3 = 0.5 * (this.m_geographicBoundingBox.double_3 + this.m_geographicBoundingBox.double_2);
				if (this.m_NorthWestChild == null && this.m_NwImageLayer != null && this.bool_0)
				{
					this.m_NorthWestChild = this.method_7(class1943_0, num2, this.m_geographicBoundingBox.double_0, this.m_geographicBoundingBox.double_2, num3, (double)num);
					ProjectedVectorTile northWestChild = this.m_NorthWestChild;
					int num4 = this.int_0;
					this.int_0 = num4 + 1;
					northWestChild.int_0 = num4;
					this.m_NorthWestChild.int_1 = 2 * this.int_1 + 1;
					this.m_NorthWestChild.int_2 = 2 * this.int_2;
					this.m_NorthWestChild.method_2(class1943_0);
				}
				if (this.m_NorthEastChild == null && this.m_NeImageLayer != null && this.bool_0)
				{
					this.m_NorthEastChild = this.method_7(class1943_0, num2, this.m_geographicBoundingBox.double_0, num3, this.m_geographicBoundingBox.double_3, (double)num);
					ProjectedVectorTile northEastChild = this.m_NorthEastChild;
					int num4 = this.int_0;
					this.int_0 = num4 + 1;
					northEastChild.int_0 = num4;
					this.m_NorthEastChild.int_1 = 2 * this.int_1 + 1;
					this.m_NorthEastChild.int_2 = 2 * this.int_2 + 1;
					this.m_NorthEastChild.method_2(class1943_0);
				}
				if (this.m_SouthWestChild == null && this.m_SwImageLayer != null && this.bool_0)
				{
					this.m_SouthWestChild = this.method_7(class1943_0, this.m_geographicBoundingBox.double_1, num2, this.m_geographicBoundingBox.double_2, num3, (double)num);
					ProjectedVectorTile southWestChild = this.m_SouthWestChild;
					int num4 = this.int_0;
					this.int_0 = num4 + 1;
					southWestChild.int_0 = num4;
					this.m_SouthWestChild.int_1 = 2 * this.int_1;
					this.m_SouthWestChild.int_2 = 2 * this.int_2;
					this.m_SouthWestChild.method_2(class1943_0);
				}
				if (this.m_SouthEastChild == null && this.m_SeImageLayer != null && this.bool_0)
				{
					this.m_SouthEastChild = this.method_7(class1943_0, this.m_geographicBoundingBox.double_1, num2, num3, this.m_geographicBoundingBox.double_3, (double)num);
					ProjectedVectorTile southEastChild = this.m_SouthEastChild;
					int num4 = this.int_0;
					this.int_0 = num4 + 1;
					southEastChild.int_0 = num4;
					this.m_SouthEastChild.int_1 = 2 * this.int_1;
					this.m_SouthEastChild.int_2 = 2 * this.int_2 + 1;
					this.m_SouthEastChild.method_2(class1943_0);
				}
			}
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0008F4A8 File Offset: 0x0008D6A8
		public void method_8(DrawArgs drawArgs)
		{
			try
			{
				double degrees = 0.5 * (this.m_geographicBoundingBox.double_0 + this.m_geographicBoundingBox.double_1);
				double degrees2 = 0.5 * (this.m_geographicBoundingBox.double_2 + this.m_geographicBoundingBox.double_3);
				double num = this.m_geographicBoundingBox.double_0 - this.m_geographicBoundingBox.double_1;
				if (!this.bool_0 && Angle.IsLittleThan(Angle.Multiply(drawArgs.GetWorldCamera().GetViewRange(), 0.5), Angle.FromDegrees((double)Class1957.float_0 * num)) && Angle.IsLittleThan(MathEngine.SphericalDistance(Angle.FromDegrees(degrees), Angle.FromDegrees(degrees2), drawArgs.GetWorldCamera().GetLatitude(), drawArgs.GetWorldCamera().GetLongitude()), Angle.FromDegrees((double)Class1957.float_1 * num * 1.25)) && drawArgs.GetWorldCamera().GetViewFrustum().Contains(this.BoundingBox))
				{
					this.method_2(drawArgs);
				}
				if (this.bool_0)
				{
					if (this.dateTime_0 < this.m_parentProjectedLayer.dateTime_0)
					{
						this.method_3(drawArgs);
					}
					if (this.m_NwImageLayer != null)
					{
						this.m_NwImageLayer.Update(drawArgs);
					}
					if (this.m_NeImageLayer != null)
					{
						this.m_NeImageLayer.Update(drawArgs);
					}
					if (this.m_SwImageLayer != null)
					{
						this.m_SwImageLayer.Update(drawArgs);
					}
					if (this.m_SeImageLayer != null)
					{
						this.m_SeImageLayer.Update(drawArgs);
					}
					if (Angle.IsLittleThan(drawArgs.GetWorldCamera().GetViewRange(), Angle.FromDegrees((double)Class1957.float_0 * num)) && Angle.IsLittleThan(MathEngine.SphericalDistance(Angle.FromDegrees(degrees), Angle.FromDegrees(degrees2), drawArgs.GetWorldCamera().GetLatitude(), drawArgs.GetWorldCamera().GetLongitude()), Angle.FromDegrees((double)Class1957.float_1 * num)) && drawArgs.GetWorldCamera().GetViewFrustum().Contains(this.BoundingBox))
					{
						if (this.m_NorthEastChild == null && this.m_NorthWestChild == null && this.m_SouthEastChild == null && this.m_SouthWestChild == null)
						{
							this.vmethod_0(drawArgs);
						}
						else
						{
							if (this.m_NorthEastChild != null)
							{
								this.m_NorthEastChild.method_8(drawArgs);
							}
							if (this.m_NorthWestChild != null)
							{
								this.m_NorthWestChild.method_8(drawArgs);
							}
							if (this.m_SouthEastChild != null)
							{
								this.m_SouthEastChild.method_8(drawArgs);
							}
							if (this.m_SouthWestChild != null)
							{
								this.m_SouthWestChild.method_8(drawArgs);
							}
						}
					}
					else
					{
						if (this.m_NorthWestChild != null)
						{
							this.m_NorthWestChild.method_0();
							this.m_NorthWestChild = null;
						}
						if (this.m_NorthEastChild != null)
						{
							this.m_NorthEastChild.method_0();
							this.m_NorthEastChild = null;
						}
						if (this.m_SouthEastChild != null)
						{
							this.m_SouthEastChild.method_0();
							this.m_SouthEastChild = null;
						}
						if (this.m_SouthWestChild != null)
						{
							this.m_SouthWestChild.method_0();
							this.m_SouthWestChild = null;
						}
					}
				}
				if (this.bool_0 && (Angle.IsLargerThan(drawArgs.GetWorldCamera().GetViewRange(), Angle.FromDegrees((double)Class1957.float_0 * num * 1.5)) || Angle.IsLargerThan(MathEngine.SphericalDistance(Angle.FromDegrees(degrees), Angle.FromDegrees(degrees2), drawArgs.GetWorldCamera().GetLatitude(), drawArgs.GetWorldCamera().GetLongitude()), Angle.FromDegrees((double)Class1957.float_1 * num * 1.5))) && this.int_0 != 0)
				{
					this.method_0();
				}
			}
			catch (Exception exception_)
			{
				Log.smethod_3(exception_);
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0008F87C File Offset: 0x0008DA7C
		public void method_9(DrawArgs class1943_0)
		{
			try
			{
				if (this.bool_0)
				{
					if (this.m_NorthWestChild != null && this.m_NorthWestChild.bool_0)
					{
						this.m_NorthWestChild.method_9(class1943_0);
					}
					else if (this.m_NwImageLayer != null && this.m_NwImageLayer.vmethod_3())
					{
						this.m_NwImageLayer.Render(class1943_0);
					}
					if (this.m_NorthEastChild != null && this.m_NorthEastChild.bool_0)
					{
						this.m_NorthEastChild.method_9(class1943_0);
					}
					else if (this.m_NeImageLayer != null && this.m_NeImageLayer.vmethod_3())
					{
						this.m_NeImageLayer.Render(class1943_0);
					}
					if (this.m_SouthWestChild != null && this.m_SouthWestChild.bool_0)
					{
						this.m_SouthWestChild.method_9(class1943_0);
					}
					else if (this.m_SwImageLayer != null && this.m_SwImageLayer.vmethod_3())
					{
						this.m_SwImageLayer.Render(class1943_0);
					}
					if (this.m_SouthEastChild != null && this.m_SouthEastChild.bool_0)
					{
						this.m_SouthEastChild.method_9(class1943_0);
					}
					else if (this.m_SeImageLayer != null && this.m_SeImageLayer.vmethod_3())
					{
						this.m_SeImageLayer.Render(class1943_0);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000945 RID: 2373
		public static string string_0 = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Cache");

		// Token: 0x04000946 RID: 2374
		private bool bool_0;

		// Token: 0x04000947 RID: 2375
		private bool bool_1;

		// Token: 0x04000948 RID: 2376
		private bool bool_2 = false;

		// Token: 0x04000949 RID: 2377
		public int int_0;

		// Token: 0x0400094A RID: 2378
		public int int_1;

		// Token: 0x0400094B RID: 2379
		public int int_2 = 0;

		// Token: 0x0400094C RID: 2380
		private ProjectedVectorRenderer m_parentProjectedLayer;

		// Token: 0x0400094D RID: 2381
		private ImageLayer m_NwImageLayer;

		// Token: 0x0400094E RID: 2382
		private ImageLayer m_NeImageLayer;

		// Token: 0x0400094F RID: 2383
		private ImageLayer m_SwImageLayer;

		// Token: 0x04000950 RID: 2384
		private ImageLayer m_SeImageLayer;

		// Token: 0x04000951 RID: 2385
		public GeographicBoundingBox m_geographicBoundingBox;

		// Token: 0x04000952 RID: 2386
		public BoundingBox BoundingBox;

		// Token: 0x04000953 RID: 2387
		private Stream stream_0;

		// Token: 0x04000954 RID: 2388
		private DateTime dateTime_0 = DateTime.Now;

		// Token: 0x04000955 RID: 2389
		private ProjectedVectorTile m_NorthWestChild;

		// Token: 0x04000956 RID: 2390
		private ProjectedVectorTile m_NorthEastChild;

		// Token: 0x04000957 RID: 2391
		private ProjectedVectorTile m_SouthWestChild;

		// Token: 0x04000958 RID: 2392
		private ProjectedVectorTile m_SouthEastChild;

		// Token: 0x04000959 RID: 2393
		private float m_verticalExaggeration = World.Settings.GetVerticalExaggeration();
	}
}
