using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Microsoft.DirectX.Direct3D;
using ns17;
using ns19;

namespace ns18
{
	// Token: 0x0200036B RID: 875
	public sealed class ImageHelper
	{
		// Token: 0x060014BE RID: 5310 RVA: 0x00004A21 File Offset: 0x00002C21
		private ImageHelper()
		{
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00089A8C File Offset: 0x00087C8C
		public static Texture smethod_0(string string_0)
		{
			return ImageHelper.smethod_1(string_0, 0);
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00089AA4 File Offset: 0x00087CA4
		public static Texture smethod_1(string string_0, int int_0)
		{
			Texture result;
			try
			{
				using (Stream stream = File.OpenRead(string_0))
				{
					result = ImageHelper.smethod_4(stream, int_0);
				}
			}
			catch
			{
				throw new Microsoft.DirectX.Direct3D.InvalidDataException(string.Format("Error reading image file '{0}'.", string_0));
			}
			return result;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00089B04 File Offset: 0x00087D04
		public unsafe static Texture smethod_2(string string_0, int int_0, int int_1)
		{
			Bitmap bitmap = (Bitmap)Image.FromFile(string_0);
			BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
			Bitmap bitmap2 = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format32bppArgb);
			BitmapData bitmapData2 = bitmap2.LockBits(new Rectangle(0, 0, bitmap2.Width, bitmap2.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
			int num = 3 * (int_1 & 255);
			int num2 = 3 * (int_0 & 255);
			int* ptr = (int*)((void*)bitmapData.Scan0);
			int* ptr2 = (int*)((void*)bitmapData2.Scan0);
			for (int i = 0; i < bitmapData2.Height; i++)
			{
				for (int j = 0; j < bitmapData2.Width; j++)
				{
					int num3 = *(ptr++);
					int num4 = (num3 & 255) + (num3 >> 8 & 255) + (num3 >> 16 & 255);
					if (num4 <= num && num4 >= num2)
					{
						num3 &= 16777215;
						num3 |= 255 * (num4 - num2) / (num - num2) << 24;
					}
					*(ptr2++) = num3;
				}
				ptr += (bitmapData.Stride >> 2) - bitmapData.Width;
				ptr2 += (bitmapData.Stride >> 2) - bitmapData.Width;
			}
			bitmap2.UnlockBits(bitmapData2);
			bitmap.UnlockBits(bitmapData);
			return new Texture(DrawArgs.device_1, bitmap2, Usage.None, Pool.Managed);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00089C90 File Offset: 0x00087E90
		public static Texture smethod_3(Stream stream_0)
		{
			return ImageHelper.smethod_4(stream_0, 0);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00089CA8 File Offset: 0x00087EA8
		public static Texture smethod_4(Stream stream_0, int int_0)
		{
			Texture texture;
			Texture result;
			try
			{
				texture = TextureLoader.FromStream(DrawArgs.device_1, stream_0, 0, 0, 1, Usage.None, World.Settings.method_39(), Pool.Managed, Filter.Box, Filter.Box, int_0);
				result = texture;
				return result;
			}
			catch (Microsoft.DirectX.Direct3D.InvalidDataException)
			{
			}
			try
			{
				using (Bitmap bitmap = (Bitmap)Image.FromStream(stream_0))
				{
					texture = new Texture(DrawArgs.device_1, bitmap, Usage.None, Pool.Managed);
				}
			}
			catch
			{
				throw new Microsoft.DirectX.Direct3D.InvalidDataException("Error reading image stream.");
			}
			result = texture;
			return result;
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00089D40 File Offset: 0x00087F40
		public static Cursor smethod_5(string string_0)
		{
			string fileName = Path.Combine("Data\\Icons\\Interface", string_0);
			Cursor result;
			try
			{
				result = new Cursor(fileName);
			}
			catch (Exception ex)
			{
				Log.Write(Log.Levels.Error, "IMAG", "Unable to load cursor '" + string_0 + "': " + ex.Message);
				result = Cursors.Default;
			}
			return result;
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00089DA4 File Offset: 0x00087FA4
		public static Texture LoadIconTexture(string string_0)
		{
			Texture texture;
			Texture result;
			try
			{
				string text = ImageHelper.smethod_7(string_0);
				if (File.Exists(text))
				{
					texture = TextureLoader.FromFile(DrawArgs.device_1, text, 0, 0, 1, Usage.None, Format.Dxt5, Pool.Managed, Filter.Box, Filter.Box, 0);
					result = texture;
					return result;
				}
			}
			catch
			{
				Log.Write(Log.Levels.Error, "IMAG", "Error loading texture '" + string_0 + "'.");
			}
			using (Bitmap bitmap = ImageHelper.smethod_8())
			{
				texture = new Texture(DrawArgs.device_1, bitmap, Usage.None, Pool.Managed);
			}
			result = texture;
			return result;
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00089E48 File Offset: 0x00088048
		public static string smethod_7(string string_0)
		{
			string result;
			if (File.Exists(string_0))
			{
				result = string_0;
			}
			else
			{
				FileInfo fileInfo = new FileInfo(Application.ExecutablePath);
				string text = Path.Combine(Path.Combine(fileInfo.Directory.FullName, "Data"), string_0);
				if (File.Exists(text))
				{
					result = text;
				}
				else
				{
					text = Path.Combine(fileInfo.Directory.FullName, string_0);
					if (File.Exists(text))
					{
						result = text;
					}
					else
					{
						result = Path.Combine(Path.Combine(fileInfo.Directory.FullName, "Data\\Icons"), string_0);
					}
				}
			}
			return result;
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00089ED8 File Offset: 0x000880D8
		private static Bitmap smethod_8()
		{
			Bitmap bitmap = new Bitmap(32, 32);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.Clear(Color.FromArgb(88, 255, 255, 255));
				graphics.DrawLine(Pens.Red, 0, 0, bitmap.Width, bitmap.Height);
				graphics.DrawLine(Pens.Red, 0, bitmap.Height, bitmap.Width, 0);
			}
			return bitmap;
		}
	}
}
