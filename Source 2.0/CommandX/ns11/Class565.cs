using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using ns17;
using ns18;
using ns19;

namespace ns11
{
	// Token: 0x02000353 RID: 851
	public sealed class Class565 : IDisposable
	{
		// Token: 0x060013F2 RID: 5106 RVA: 0x00085DC0 File Offset: 0x00083FC0
		public Struct57 method_0()
		{
			return this.struct57_0;
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x0000E459 File Offset: 0x0000C659
		public void method_1(Struct57 struct57_4)
		{
			this.struct57_0 = struct57_4;
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00085DD8 File Offset: 0x00083FD8
		public Struct57 method_2()
		{
			return this.struct57_1;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x0000E462 File Offset: 0x0000C662
		public void method_3(Struct57 struct57_4)
		{
			this.struct57_1 = struct57_4;
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00085DF0 File Offset: 0x00083FF0
		public Struct57 method_4()
		{
			return this.struct57_2;
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0000E46B File Offset: 0x0000C66B
		public void method_5(Struct57 struct57_4)
		{
			this.struct57_2 = struct57_4;
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0000E474 File Offset: 0x0000C674
		public void method_6(Struct57 struct57_4)
		{
			this.struct57_3 = struct57_4;
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00085E08 File Offset: 0x00084008
		public float method_7()
		{
			return this.float_0;
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x0000E47D File Offset: 0x0000C67D
		public static void smethod_0(TerrainAccessor class1969_1, double double_6)
		{
			Class565.class1969_0 = class1969_1;
			Class565.double_1 = double_6;
			Class565.font_0 = new System.Drawing.Font("Verdana", 15f, FontStyle.Bold);
			Class565.brush_0 = new SolidBrush(Color.Green);
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0000E4AF File Offset: 0x0000C6AF
		public bool method_8()
		{
			return this.bool_0;
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0000E4B7 File Offset: 0x0000C6B7
		public void method_9(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00085E20 File Offset: 0x00084020
		public bool method_10(int int_4, int int_5, int int_6)
		{
			bool result = false;
			if (this.int_0 == int_4 && this.int_1 == int_5 && this.int_2 == int_6)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00085E58 File Offset: 0x00084058
		public Class565(int int_4, int int_5, int int_6, Class1994 class1994_1)
		{
			this.int_0 = int_4;
			this.int_1 = int_5;
			this.int_2 = int_6;
			this.class1994_0 = class1994_1;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00085F14 File Offset: 0x00084114
		public Texture method_11()
		{
			return this.texture_0;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00085F2C File Offset: 0x0008412C
		public void method_12(DrawArgs class1943_1, int int_4)
		{
			this.class1943_0 = class1943_1;
			string text = this.class1994_0.method_0();
			string text2 = this.class1994_0.method_1();
			this.string_3 = Class565.smethod_2(this.int_1, this.int_0, this.int_2);
			string string_ = string.Concat(new object[]
			{
				"http://",
				text,
				this.string_3[this.string_3.Length - 1],
				this.string_4,
				text,
				this.string_3,
				".",
				text2,
				"?g=",
				15
			});
			string string_2 = this.method_19(this.int_2, this.class1994_0.control0_0.GetCache().CacheDirectory);
			string string_3 = this.method_20(string_2, text);
			string string_4 = this.method_21(string_3, this.int_0);
			this.string_0 = string.Empty;
			if (!(text == "r") && !(text == "t"))
			{
				this.string_0 = this.method_22(string_4, this.int_0, this.int_1, "jpeg");
			}
			else
			{
				this.string_0 = this.method_22(string_4, this.int_0, this.int_1, "png");
			}
			if (File.Exists(this.string_0 + ".txt"))
			{
				File.Delete(this.string_0 + ".txt");
				if (File.Exists(this.string_0))
				{
					File.Delete(this.string_0);
				}
			}
			else if (File.Exists(this.string_0))
			{
				this.texture_0 = TextureLoader.FromFile(class1943_1.device_0, this.string_0);
			}
			else if (text == "t")
			{
				string_3 = this.method_20(string_2, "a");
				string_4 = this.method_21(string_3, this.int_0);
				this.string_1 = this.method_22(string_4, this.int_0, this.int_1, "jpeg");
				string_3 = this.method_20(string_2, "h");
				string_4 = this.method_21(string_3, this.int_0);
				this.string_2 = this.method_22(string_4, this.int_0, this.int_1, "jpeg");
				if (File.Exists(this.string_1) && File.Exists(this.string_2))
				{
					Class565.smethod_1(this.string_1, this.string_2, this.string_0);
					this.texture_0 = TextureLoader.FromFile(class1943_1.device_0, this.string_0);
				}
				else if (!File.Exists(this.string_1))
				{
					string string_5 = string.Concat(new object[]
					{
						"http://",
						"a",
						this.string_3[this.string_3.Length - 1],
						this.string_4,
						"a",
						this.string_3,
						".",
						"jpg",
						"?g=",
						15
					});
					this.class1984_1 = new Class1984(string_5);
					this.class1984_1.enum151_0 = Enum151.const_0;
					this.class1984_1.string_5 = this.string_1 + ".tmp";
					Class1984 @class = this.class1984_1;
					@class.delegate36_0 = (Delegate36)Delegate.Combine(@class.delegate36_0, new Delegate36(this.method_13));
					Class1984 class2 = this.class1984_1;
					class2.delegate37_2 = (Delegate37)Delegate.Combine(class2.delegate37_2, new Delegate37(this.method_15));
					this.class1984_1.method_3(true);
				}
				else if (!File.Exists(this.string_2))
				{
					string string_6 = string.Concat(new object[]
					{
						"http://",
						"h",
						this.string_3[this.string_3.Length - 1],
						this.string_4,
						"h",
						this.string_3,
						".",
						"jpg",
						"?g=",
						15
					});
					this.class1984_2 = new Class1984(string_6);
					this.class1984_2.enum151_0 = Enum151.const_0;
					this.class1984_2.string_5 = this.string_2 + ".tmp";
					Class1984 class3 = this.class1984_2;
					class3.delegate36_0 = (Delegate36)Delegate.Combine(class3.delegate36_0, new Delegate36(this.method_16));
					Class1984 class4 = this.class1984_2;
					class4.delegate37_2 = (Delegate37)Delegate.Combine(class4.delegate37_2, new Delegate37(this.method_17));
					this.class1984_2.method_3(true);
				}
			}
			else
			{
				this.class1984_0 = new Class1984(string_);
				this.class1984_0.enum151_0 = Enum151.const_0;
				this.class1984_0.string_5 = this.string_0 + ".tmp";
				Class1984 class5 = this.class1984_0;
				class5.delegate36_0 = (Delegate36)Delegate.Combine(class5.delegate36_0, new Delegate36(this.method_13));
				Class1984 class6 = this.class1984_0;
				class6.delegate37_2 = (Delegate37)Delegate.Combine(class6.delegate37_2, new Delegate37(this.method_14));
				this.class1984_0.method_3(true);
			}
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		private void method_13(int int_4, int int_5)
		{
			if (int_5 == 0)
			{
				int_5 = 51200;
			}
			int_4 %= int_5 + 1;
			this.float_1 = (float)int_4 / (float)int_5;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x000864D8 File Offset: 0x000846D8
		private void method_14(Class1984 class1984_3)
		{
			try
			{
				class1984_3.method_11();
				File.Delete(this.string_0);
				File.Move(class1984_3.string_5, this.string_0);
				this.texture_0 = TextureLoader.FromFile(this.class1943_0.device_0, this.string_0);
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
				if (httpWebResponse != null && httpWebResponse.StatusCode == HttpStatusCode.NotFound)
				{
					using (File.Create(this.string_0 + ".txt"))
					{
					}
				}
			}
			catch
			{
				using (File.Create(this.string_0 + ".txt"))
				{
				}
				if (File.Exists(class1984_3.string_5))
				{
					File.Delete(class1984_3.string_5);
				}
			}
			finally
			{
				this.class1984_0.bool_3 = true;
			}
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00086608 File Offset: 0x00084808
		private void method_15(Class1984 class1984_3)
		{
			try
			{
				class1984_3.method_11();
				File.Delete(this.string_1);
				File.Move(class1984_3.string_5, this.string_1);
				if (File.Exists(this.string_1) && File.Exists(this.string_2))
				{
					Class565.smethod_1(this.string_1, this.string_2, this.string_0);
					this.texture_0 = TextureLoader.FromFile(this.class1943_0.device_0, this.string_0);
				}
				else
				{
					string string_ = string.Concat(new object[]
					{
						"http://",
						"h",
						this.string_3[this.string_3.Length - 1],
						this.string_4,
						"h",
						this.string_3,
						".",
						"jpg",
						"?g=",
						15
					});
					this.class1984_2 = new Class1984(string_);
					this.class1984_2.enum151_0 = Enum151.const_0;
					this.class1984_2.string_5 = this.string_2 + ".tmp";
					Class1984 @class = this.class1984_2;
					@class.delegate36_0 = (Delegate36)Delegate.Combine(@class.delegate36_0, new Delegate36(this.method_16));
					Class1984 class2 = this.class1984_2;
					class2.delegate37_2 = (Delegate37)Delegate.Combine(class2.delegate37_2, new Delegate37(this.method_17));
					this.class1984_2.method_3(true);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
				if (httpWebResponse != null && httpWebResponse.StatusCode == HttpStatusCode.NotFound)
				{
					using (File.Create(this.string_1 + ".txt"))
					{
					}
				}
			}
			catch
			{
				using (File.Create(this.string_1 + ".txt"))
				{
				}
				if (File.Exists(class1984_3.string_5))
				{
					File.Delete(class1984_3.string_5);
				}
			}
			finally
			{
				this.class1984_1.bool_3 = true;
			}
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		private void method_16(int int_4, int int_5)
		{
			if (int_5 == 0)
			{
				int_5 = 51200;
			}
			int_4 %= int_5 + 1;
			this.float_1 = (float)int_4 / (float)int_5;
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x000868C8 File Offset: 0x00084AC8
		private void method_17(Class1984 class1984_3)
		{
			try
			{
				class1984_3.method_11();
				File.Delete(this.string_2);
				File.Move(class1984_3.string_5, this.string_2);
				if (File.Exists(this.string_1) && File.Exists(this.string_2))
				{
					Class565.smethod_1(this.string_1, this.string_2, this.string_0);
					this.texture_0 = TextureLoader.FromFile(this.class1943_0.device_0, this.string_0);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
				if (httpWebResponse != null && httpWebResponse.StatusCode == HttpStatusCode.NotFound)
				{
					using (File.Create(this.string_2 + ".txt"))
					{
					}
				}
			}
			catch
			{
				using (File.Create(this.string_2 + ".txt"))
				{
				}
				if (File.Exists(class1984_3.string_5))
				{
					File.Delete(class1984_3.string_5);
				}
			}
			finally
			{
				this.class1984_2.bool_3 = true;
			}
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00086A6C File Offset: 0x00084C6C
		public unsafe static void smethod_1(string string_5, string string_6, string string_7)
		{
			Bitmap bitmap = (Bitmap)Image.FromFile(string_5);
			BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
			Bitmap bitmap2 = (Bitmap)Image.FromFile(string_6);
			BitmapData bitmapData2 = bitmap2.LockBits(new Rectangle(0, 0, bitmap2.Width, bitmap2.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
			new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format32bppArgb);
			Bitmap bitmap3 = new Bitmap(bitmap2.Width, bitmap2.Height, PixelFormat.Format32bppArgb);
			BitmapData bitmapData3 = bitmap3.LockBits(new Rectangle(0, 0, bitmap3.Width, bitmap3.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
			int* ptr = (int*)((void*)bitmapData.Scan0);
			int* ptr2 = (int*)((void*)bitmapData2.Scan0);
			int* ptr3 = (int*)((void*)bitmapData3.Scan0);
			for (int i = 0; i < bitmapData3.Height; i++)
			{
				for (int j = 0; j < bitmapData3.Width; j++)
				{
					int num = *(ptr++);
					int num2 = *(ptr2++);
					int num3 = Math.Abs((num & 255) - (num2 & 255)) + Math.Abs((num >> 8 & 255) - (num >> 8 & 255)) + Math.Abs((num >> 16 & 255) - (num >> 16 & 255));
					num &= 16777215;
					num2 &= 16777215;
					if (num3 < 20)
					{
						num2 = num2;
					}
					else
					{
						num2 |= -16777216;
					}
					*(ptr3++) = num2;
				}
				ptr += (bitmapData2.Stride >> 2) - bitmapData.Width;
				ptr2 += (bitmapData2.Stride >> 2) - bitmapData2.Width;
				ptr3 += (bitmapData2.Stride >> 2) - bitmapData2.Width;
			}
			bitmap3.UnlockBits(bitmapData3);
			bitmap.UnlockBits(bitmapData);
			bitmap2.UnlockBits(bitmapData2);
			bitmap3.Save(string_7, ImageFormat.Png);
			bitmap.Dispose();
			bitmap2.Dispose();
			bitmap3.Dispose();
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0000E4E4 File Offset: 0x0000C6E4
		public void method_18(string string_5)
		{
			this.arrayList_0.Add(string_5);
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x00086CA4 File Offset: 0x00084EA4
		private static string smethod_2(int int_4, int int_5, int int_6)
		{
			string text = "";
			for (int i = int_6; i > 0; i--)
			{
				int num = 1 << i - 1;
				int num2 = 0;
				if ((int_4 & num) != 0)
				{
					num2++;
				}
				if ((int_5 & num) != 0)
				{
					num2 += 2;
				}
				text += num2;
			}
			return text;
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00086CFC File Offset: 0x00084EFC
		public string method_19(int int_4, string string_5)
		{
			string text = string.Format("{0}\\Virtual Earth", string_5);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text2 = text + "\\" + int_4.ToString();
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
			return text2;
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00086D4C File Offset: 0x00084F4C
		public string method_20(string string_5, string string_6)
		{
			string text = string_5 + "\\" + string_6;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			return text;
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x00086D78 File Offset: 0x00084F78
		public string method_21(string string_5, int int_4)
		{
			string text = string_5 + "\\" + int_4.ToString("0000");
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			return text;
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00086DB0 File Offset: 0x00084FB0
		public string method_22(string string_5, int int_4, int int_5, string string_6)
		{
			return string.Concat(new string[]
			{
				string_5,
				"\\",
				int_4.ToString("0000"),
				"_",
				int_5.ToString("0000"),
				".",
				string_6
			});
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00086E0C File Offset: 0x0008500C
		public CustomVertex.PositionNormalTextured[] method_23()
		{
			return this.positionNormalTextured_0;
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00086E24 File Offset: 0x00085024
		public short[] method_24()
		{
			return this.short_0;
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00086E3C File Offset: 0x0008503C
		public void method_25(byte byte_0, float float_2)
		{
			this.float_0 = float_2;
			Color.FromArgb((int)byte_0, 0, 0, 0).ToArgb();
			this.int_3 = 16;
			this.positionNormalTextured_0 = new CustomVertex.PositionNormalTextured[(this.int_3 + 2) * (this.int_3 + 2)];
			int num = this.int_3 - 1;
			float num2 = 1f / (float)num;
			double num3 = (this.method_2().double_0 - this.method_0().double_0) / (double)num;
			double num4 = num3 / Class565.double_1;
			double num5 = (this.method_0().double_1 - this.method_4().double_1) / (double)num;
			Struct57 struct57_ = new Struct57(this.method_0().double_0 - num3, this.method_0().double_1 + num5);
			Struct57 @struct = this.method_26(this.struct57_0);
			Struct57 struct2 = this.method_26(this.struct57_3);
			double num6 = 180.0 / Class565.double_0;
			double num7 = (@struct.double_0 - struct2.double_0) * num6;
			this.double_2 = @struct.double_1;
			this.double_3 = struct2.double_1;
			this.double_4 = @struct.double_0;
			this.double_5 = struct2.double_0;
			float float_3 = (float)Class565.double_1;
			double num8 = 0.0;
			for (int i = 0; i < this.int_3 + 2; i++)
			{
				Struct57 struct3 = this.method_26(struct57_);
				for (int j = 0; j < this.int_3 + 2; j++)
				{
					if (Class565.class1969_0 != null)
					{
						if (this.class1994_0.bool_7 && float_2 != 0f)
						{
							num8 = (double)(float_2 * Class565.class1969_0.vmethod_0(struct3.double_1 * num6, struct3.double_0 * num6, Math.Abs((double)num / num7)));
						}
						else
						{
							num8 = 0.0;
						}
					}
					Vector3 vector = Class565.smethod_4(struct3.double_1, struct3.double_0, Class565.double_1 + num8);
					int num9 = i * (this.int_3 + 2) + j;
					this.positionNormalTextured_0[num9].X = vector.X;
					this.positionNormalTextured_0[num9].Y = vector.Y;
					this.positionNormalTextured_0[num9].Z = vector.Z;
					this.positionNormalTextured_0[num9].Tu = (float)(j - 1) * num2;
					this.positionNormalTextured_0[num9].Tv = (float)(i - 1) * num2;
					struct3.double_0 += num4;
				}
				struct57_.double_0 = this.method_0().double_0 - num3;
				struct57_.double_1 -= num5;
			}
			int num10 = this.int_3 + 1;
			this.short_0 = new short[2 * num10 * num10 * 3];
			for (int k = 0; k < num10; k++)
			{
				for (int l = 0; l < num10; l++)
				{
					this.short_0[6 * k * num10 + 6 * l] = (short)(k * (this.int_3 + 2) + l);
					this.short_0[6 * k * num10 + 6 * l + 1] = (short)((k + 1) * (this.int_3 + 2) + l);
					this.short_0[6 * k * num10 + 6 * l + 2] = (short)(k * (this.int_3 + 2) + l + 1);
					this.short_0[6 * k * num10 + 6 * l + 3] = (short)(k * (this.int_3 + 2) + l + 1);
					this.short_0[6 * k * num10 + 6 * l + 4] = (short)((k + 1) * (this.int_3 + 2) + l);
					this.short_0[6 * k * num10 + 6 * l + 5] = (short)((k + 1) * (this.int_3 + 2) + l + 1);
				}
			}
			this.method_27();
			this.method_28(false, float_3);
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00087248 File Offset: 0x00085448
		private Struct57 method_26(Struct57 struct57_4)
		{
			struct57_4.double_1 = Math.Atan(Math.Sinh(struct57_4.double_1 / Class565.double_1));
			struct57_4.double_0 /= Class565.double_1;
			return struct57_4;
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x0008728C File Offset: 0x0008548C
		private void method_27()
		{
			ArrayList[] array = new ArrayList[this.positionNormalTextured_0.Length];
			for (int i = 0; i < this.positionNormalTextured_0.Length; i++)
			{
				array[i] = new ArrayList();
			}
			for (int j = 0; j < this.short_0.Length; j += 3)
			{
				Vector3 position = this.positionNormalTextured_0[(int)this.short_0[j]].Position;
				Vector3 position2 = this.positionNormalTextured_0[(int)this.short_0[j + 1]].Position;
				Vector3 position3 = this.positionNormalTextured_0[(int)this.short_0[j + 2]].Position;
				Vector3 left = position2 - position;
				Vector3 right = position3 - position;
				Vector3 vector = Vector3.Cross(left, right);
				vector.Normalize();
				array[(int)this.short_0[j]].Add(vector);
				array[(int)this.short_0[j + 1]].Add(vector);
				array[(int)this.short_0[j + 2]].Add(vector);
			}
			for (int k = 0; k < this.positionNormalTextured_0.Length; k++)
			{
				for (int l = 0; l < array[k].Count; l++)
				{
					Vector3 vector2 = (Vector3)array[k][l];
					if (this.positionNormalTextured_0[k].Normal == Vector3.Empty)
					{
						this.positionNormalTextured_0[k].Normal = vector2;
					}
					else
					{
						CustomVertex.PositionNormalTextured[] array2 = this.positionNormalTextured_0;
						int num = k;
						array2[num].Normal = array2[num].Normal + vector2;
					}
				}
				this.positionNormalTextured_0[k].Normal.Multiply(1f / (float)array[k].Count);
			}
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00087480 File Offset: 0x00085680
		private void method_28(bool bool_1, float float_2)
		{
			short num = (short)Math.Sqrt((double)this.positionNormalTextured_0.Length);
			for (int i = 0; i < (int)num; i++)
			{
				if (i == 0 || i == (int)(num - 1))
				{
					for (int j = 0; j < (int)num; j++)
					{
						int num2 = (int)((i == 0) ? num : (-(int)num));
						if (j == 0)
						{
							num2++;
						}
						if (j == (int)(num - 1))
						{
							num2--;
						}
						Point3d point3d = new Point3d((double)this.positionNormalTextured_0[i * (int)num + j + num2].Position.X, (double)this.positionNormalTextured_0[i * (int)num + j + num2].Position.Y, (double)this.positionNormalTextured_0[i * (int)num + j + num2].Position.Z);
						if (bool_1)
						{
							point3d = this.method_29(point3d, float_2);
						}
						this.positionNormalTextured_0[i * (int)num + j].Position = new Vector3((float)point3d.X, (float)point3d.Y, (float)point3d.Z);
					}
				}
				else
				{
					Point3d point3d2 = new Point3d((double)this.positionNormalTextured_0[i * (int)num + 1].Position.X, (double)this.positionNormalTextured_0[i * (int)num + 1].Position.Y, (double)this.positionNormalTextured_0[i * (int)num + 1].Position.Z);
					if (bool_1)
					{
						point3d2 = this.method_29(point3d2, float_2);
					}
					this.positionNormalTextured_0[i * (int)num].Position = new Vector3((float)point3d2.X, (float)point3d2.Y, (float)point3d2.Z);
					point3d2 = new Point3d((double)this.positionNormalTextured_0[i * (int)num + (int)num - 2].Position.X, (double)this.positionNormalTextured_0[i * (int)num + (int)num - 2].Position.Y, (double)this.positionNormalTextured_0[i * (int)num + (int)num - 2].Position.Z);
					if (bool_1)
					{
						point3d2 = this.method_29(point3d2, float_2);
					}
					this.positionNormalTextured_0[i * (int)num + (int)num - 1].Position = new Vector3((float)point3d2.X, (float)point3d2.Y, (float)point3d2.Z);
				}
			}
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x000876E0 File Offset: 0x000858E0
		private Point3d method_29(Point3d class1953_0, float float_2)
		{
			class1953_0 = class1953_0.normalize();
			class1953_0 = Point3d.multiply(class1953_0, (double)float_2);
			return class1953_0;
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00087704 File Offset: 0x00085904
		public void Dispose()
		{
			if (this.texture_0 != null)
			{
				this.texture_0.Dispose();
				this.texture_0 = null;
			}
			if (this.class1984_0 != null)
			{
				this.class1984_0.Dispose();
				this.class1984_0 = null;
			}
			if (this.class1984_1 != null)
			{
				this.class1984_1.Dispose();
				this.class1984_1 = null;
			}
			if (this.class1984_2 != null)
			{
				this.class1984_2.Dispose();
				this.class1984_2 = null;
			}
			if (this.positionNormalTextured_0 != null)
			{
				this.positionNormalTextured_0 = null;
			}
			if (this.short_0 != null)
			{
				this.short_0 = null;
			}
			if (this.positionColored_0 != null)
			{
				this.positionColored_0 = null;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x000877C8 File Offset: 0x000859C8
		public static int smethod_3(DrawArgs class1943_1, bool bool_1, ArrayList arrayList_1, int int_4)
		{
			int num = 0;
			int result;
			try
			{
				if (arrayList_1.Count <= 0)
				{
					result = 0;
					return result;
				}
				object syncRoot = arrayList_1.SyncRoot;
				lock (syncRoot)
				{
					if (bool_1)
					{
						if (class1943_1.device_0.RenderState.ZBufferEnable)
						{
							class1943_1.device_0.RenderState.ZBufferEnable = false;
						}
					}
					else if (!class1943_1.device_0.RenderState.ZBufferEnable)
					{
						class1943_1.device_0.RenderState.ZBufferEnable = true;
					}
					class1943_1.device_0.VertexFormat = (VertexFormats.PositionNormal | VertexFormats.Texture1);
					class1943_1.device_0.TextureState[0].ColorOperation = TextureOperation.SelectArg1;
					class1943_1.device_0.TextureState[0].ColorArgument1 = TextureArgument.TextureColor;
					class1943_1.device_0.TextureState[0].AlphaOperation = TextureOperation.SelectArg1;
					class1943_1.device_0.TextureState[0].AlphaArgument1 = TextureArgument.TextureColor;
					if (World.Settings.IsEnableSunShading())
					{
						class1943_1.device_0.TextureState[0].ColorOperation = TextureOperation.Modulate;
						class1943_1.device_0.TextureState[0].ColorArgument1 = TextureArgument.Diffuse;
						class1943_1.device_0.TextureState[0].ColorArgument2 = TextureArgument.TextureColor;
					}
					int num2 = 0;
					int[] array = new int[arrayList_1.Count];
					for (int i = 0; i < arrayList_1.Count; i++)
					{
						Class565 @class = (Class565)arrayList_1[i];
						if (@class.int_2 == int_4)
						{
							if (@class.method_11() == null)
							{
								array[num2] = i;
								num2++;
							}
							else
							{
								class1943_1.device_0.SetTexture(0, @class.method_11());
								class1943_1.device_0.DrawIndexedUserPrimitives(PrimitiveType.TriangleList, 0, @class.method_23().Length, @class.method_24().Length / 3, @class.method_24(), true, @class.method_23());
								num++;
							}
						}
					}
					if (num2 > 0)
					{
						int color = Color.Yellow.ToArgb();
						string text = "Pending requests :  " + num2.ToString();
						Rectangle rectangle = class1943_1.font_0.MeasureString(null, text, DrawTextFormat.None, 0);
						class1943_1.font_0.DrawText(null, text, class1943_1.int_3 - rectangle.Width - 5, class1943_1.int_4 - rectangle.Height - 5, color);
					}
					class1943_1.device_0.RenderState.ZBufferEnable = false;
					class1943_1.device_0.VertexFormat = (VertexFormats.Diffuse | VertexFormats.Position);
					class1943_1.device_0.TextureState[0].ColorOperation = TextureOperation.Disable;
					for (int j = 0; j < num2; j++)
					{
						int index = array[j];
						Class565 @class = (Class565)arrayList_1[index];
						@class.method_31(class1943_1);
					}
					class1943_1.device_0.TextureState[0].ColorOperation = TextureOperation.SelectArg1;
					class1943_1.device_0.VertexFormat = (VertexFormats.Texture1 | VertexFormats.Position);
					class1943_1.device_0.RenderState.ZBufferEnable = true;
					if (World.Settings.IsEnableSunShading())
					{
						class1943_1.device_0.RenderState.Lighting = true;
					}
				}
			}
			catch (Exception ex)
			{
				ex.ToString();
				Log.smethod_3(ex);
			}
			finally
			{
				if (bool_1)
				{
					class1943_1.device_0.RenderState.ZBufferEnable = true;
				}
			}
			result = num;
			return result;
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x00087B80 File Offset: 0x00085D80
		public void method_30(DrawArgs class1943_1, int int_4)
		{
			Vector3 vector = Class565.smethod_4((double)((float)this.double_2), (double)((float)this.double_4), Class565.double_1);
			Vector3 vector2 = Class565.smethod_4((double)((float)this.double_3), (double)((float)this.double_4), Class565.double_1);
			Vector3 vector3 = Class565.smethod_4((double)((float)this.double_2), (double)((float)this.double_5), Class565.double_1);
			Vector3 vector4 = Class565.smethod_4((double)((float)this.double_3), (double)((float)this.double_5), Class565.double_1);
			this.positionColored_0[0].X = vector.X;
			this.positionColored_0[0].Y = vector.Y;
			this.positionColored_0[0].Z = vector.Z;
			this.positionColored_0[0].Color = int_4;
			this.positionColored_0[1].X = vector2.X;
			this.positionColored_0[1].Y = vector2.Y;
			this.positionColored_0[1].Z = vector2.Z;
			this.positionColored_0[1].Color = int_4;
			this.positionColored_0[2].X = vector4.X;
			this.positionColored_0[2].Y = vector4.Y;
			this.positionColored_0[2].Z = vector4.Z;
			this.positionColored_0[2].Color = int_4;
			this.positionColored_0[3].X = vector3.X;
			this.positionColored_0[3].Y = vector3.Y;
			this.positionColored_0[3].Z = vector3.Z;
			this.positionColored_0[3].Color = int_4;
			this.positionColored_0[4].X = this.positionColored_0[0].X;
			this.positionColored_0[4].Y = this.positionColored_0[0].Y;
			this.positionColored_0[4].Z = this.positionColored_0[0].Z;
			this.positionColored_0[4].Color = int_4;
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00087DDC File Offset: 0x00085FDC
		public void method_31(DrawArgs class1943_1)
		{
			class1943_1.device_0.Transform.World = Matrix.Translation(-(float)class1943_1.GetWorldCamera().ReferenceCenter.X, -(float)class1943_1.GetWorldCamera().ReferenceCenter.Y, -(float)class1943_1.GetWorldCamera().ReferenceCenter.Z);
			class1943_1.device_0.DrawUserPrimitives(PrimitiveType.LineStrip, 4, this.positionColored_0);
			class1943_1.device_0.Transform.World = class1943_1.GetWorldCamera().GetWorldMatrix();
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00087E68 File Offset: 0x00086068
		public static Vector3 smethod_4(double double_6, double double_7, double double_8)
		{
			double num = double_8 * Math.Cos(double_6);
			return new Vector3((float)(num * Math.Cos(double_7)), (float)(num * Math.Sin(double_7)), (float)(double_8 * Math.Sin(double_6)));
		}

		// Token: 0x0400083C RID: 2108
		private static double double_0 = 3.1415926535897931;

		// Token: 0x0400083D RID: 2109
		private Struct57 struct57_0;

		// Token: 0x0400083E RID: 2110
		private Struct57 struct57_1;

		// Token: 0x0400083F RID: 2111
		private Struct57 struct57_2;

		// Token: 0x04000840 RID: 2112
		private Struct57 struct57_3;

		// Token: 0x04000841 RID: 2113
		private float float_0;

		// Token: 0x04000842 RID: 2114
		private static double double_1;

		// Token: 0x04000843 RID: 2115
		private static TerrainAccessor class1969_0;

		// Token: 0x04000844 RID: 2116
		private static System.Drawing.Font font_0;

		// Token: 0x04000845 RID: 2117
		private static Brush brush_0;

		// Token: 0x04000846 RID: 2118
		private Class1994 class1994_0;

		// Token: 0x04000847 RID: 2119
		private bool bool_0 = true;

		// Token: 0x04000848 RID: 2120
		private int int_0;

		// Token: 0x04000849 RID: 2121
		private int int_1;

		// Token: 0x0400084A RID: 2122
		private int int_2 = 0;

		// Token: 0x0400084B RID: 2123
		private Texture texture_0;

		// Token: 0x0400084C RID: 2124
		private ArrayList arrayList_0 = new ArrayList();

		// Token: 0x0400084D RID: 2125
		private Class1984 class1984_0;

		// Token: 0x0400084E RID: 2126
		private Class1984 class1984_1;

		// Token: 0x0400084F RID: 2127
		private Class1984 class1984_2;

		// Token: 0x04000850 RID: 2128
		public float float_1;

		// Token: 0x04000851 RID: 2129
		private string string_0;

		// Token: 0x04000852 RID: 2130
		private string string_1;

		// Token: 0x04000853 RID: 2131
		private string string_2 = "";

		// Token: 0x04000854 RID: 2132
		private string string_3 = "";

		// Token: 0x04000855 RID: 2133
		private string string_4 = ".ortho.tiles.virtualearth.net/tiles/";

		// Token: 0x04000856 RID: 2134
		private DrawArgs class1943_0;

		// Token: 0x04000857 RID: 2135
		protected CustomVertex.PositionNormalTextured[] positionNormalTextured_0;

		// Token: 0x04000858 RID: 2136
		protected short[] short_0;

		// Token: 0x04000859 RID: 2137
		protected int int_3 = 64;

		// Token: 0x0400085A RID: 2138
		private double double_2 = 0.0;

		// Token: 0x0400085B RID: 2139
		private double double_3 = 0.0;

		// Token: 0x0400085C RID: 2140
		private double double_4 = 0.0;

		// Token: 0x0400085D RID: 2141
		private double double_5 = 0.0;

		// Token: 0x0400085E RID: 2142
		private CustomVertex.PositionColored[] positionColored_0 = new CustomVertex.PositionColored[5];
	}
}
