using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Microsoft.DirectX.Direct3D;
using ns16;
using ns17;
using ns19;

namespace ns18
{
	// Token: 0x0200035F RID: 863
	public sealed class DrawArgs : IDisposable
	{
		// Token: 0x06001471 RID: 5233 RVA: 0x0000E800 File Offset: 0x0000CA00
		public void method_0(RenderPriority enum153_1)
		{
			this.enum153_0 = enum153_1;
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00088B60 File Offset: 0x00086D60
		public CameraBase GetWorldCamera()
		{
			return this.class1987_0;
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0000E809 File Offset: 0x0000CA09
		public void method_2(CameraBase class1987_2)
		{
			this.class1987_0 = class1987_2;
			DrawArgs.class1987_1 = class1987_2;
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00088B78 File Offset: 0x00086D78
		public World method_3()
		{
			return this.class1995_0;
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x0000E818 File Offset: 0x0000CA18
		public void method_4(World class1995_2)
		{
			this.class1995_0 = class1995_2;
			DrawArgs.class1995_1 = class1995_2;
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00088B90 File Offset: 0x00086D90
		public DrawArgs(Device device_2, Control control_2)
		{
			this.control_0 = control_2;
			DrawArgs.control_1 = control_2;
			DrawArgs.device_1 = device_2;
			this.device_0 = device_2;
			this.font_0 = this.method_7(World.Settings.string_2, World.Settings.float_0);
			if (this.font_0 == null)
			{
				this.font_0 = this.method_7("", 10f);
			}
			this.font_1 = this.method_7("Arial", 8f);
			if (this.font_1 == null)
			{
				this.font_1 = this.method_7("", 8f);
			}
			this.font_2 = this.method_8(World.Settings.method_7(), World.Settings.method_8(), World.Settings.method_9());
			DrawArgs.bitmap_0 = new Bitmap(256, 256, PixelFormat.Format32bppArgb);
			DrawArgs.graphics_0 = Graphics.FromImage(DrawArgs.bitmap_0);
			this.sprite_0 = new Sprite(device_2);
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0000E827 File Offset: 0x0000CA27
		public void method_5()
		{
			this.int_5 = 0;
			this.int_6 = 0;
			this.string_0 = "";
			this.int_1 = 0;
			this.int_0 = 0;
			this.int_2 = 0;
			this.bool_4 = true;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0000E85E File Offset: 0x0000CA5E
		public void method_6()
		{
			this.bool_4 = false;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00088CD4 File Offset: 0x00086ED4
		public Microsoft.DirectX.Direct3D.Font method_7(string string_1, float float_0)
		{
			return this.method_8(string_1, float_0, FontStyle.Regular);
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x00088CEC File Offset: 0x00086EEC
		public Microsoft.DirectX.Direct3D.Font method_8(string string_1, float float_0, FontStyle fontStyle_0)
		{
			Microsoft.DirectX.Direct3D.Font result;
			try
			{
				FontDescription fontDescription_ = new FontDescription();
				fontDescription_.FaceName = string_1;
				fontDescription_.Height = (int)(1.9 * (double)float_0);
				if (fontStyle_0 == FontStyle.Regular)
				{
					result = this.CreateFont(fontDescription_);
				}
				else
				{
					if ((fontStyle_0 & FontStyle.Italic) != FontStyle.Regular)
					{
						fontDescription_.IsItalic = true;
					}
					if ((fontStyle_0 & FontStyle.Bold) != FontStyle.Regular)
					{
						fontDescription_.Weight = FontWeight.Black;
					}
					fontDescription_.Quality = FontQuality.AntiAliased;
					result = this.CreateFont(fontDescription_);
				}
			}
			catch
			{
				Log.Write(Log.Levels.Error, "FONT", string.Format("Unable to load '{0}' {2} ({1}em)", string_1, float_0, fontStyle_0));
				result = this.font_0;
			}
			return result;
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x00088DAC File Offset: 0x00086FAC
		public Microsoft.DirectX.Direct3D.Font CreateFont(FontDescription fontDescription_0)
		{
			Microsoft.DirectX.Direct3D.Font result;
			try
			{
				if (World.Settings.method_10())
				{
					fontDescription_0.Quality = FontQuality.ClearTypeNatural;
				}
				else
				{
					fontDescription_0.Quality = FontQuality.Default;
				}
				string key = fontDescription_0.ToString();
				Microsoft.DirectX.Direct3D.Font font = (Microsoft.DirectX.Direct3D.Font)this.hashtable_1[key];
				if (font != null)
				{
					result = font;
				}
				else
				{
					font = new Microsoft.DirectX.Direct3D.Font(this.device_0, fontDescription_0);
					this.hashtable_1.Add(key, font);
					result = font;
				}
			}
			catch
			{
				Log.Write(Log.Levels.Error, "FONT", string.Format("Unable to load '{0}' (Height: {1})", fontDescription_0.FaceName, fontDescription_0.Height));
				result = this.font_0;
			}
			return result;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0000E867 File Offset: 0x0000CA67
		public static void smethod_0(Enum149 enum149_2)
		{
			DrawArgs.enum149_0 = enum149_2;
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00088E6C File Offset: 0x0008706C
		public void method_10(Control control_2)
		{
			if (DrawArgs.enum149_1 != DrawArgs.enum149_0)
			{
				switch (DrawArgs.enum149_0)
				{
				case Enum149.const_1:
					control_2.Cursor = Cursors.Hand;
					break;
				case Enum149.const_2:
					control_2.Cursor = Cursors.Cross;
					break;
				case Enum149.const_3:
					if (this.cursor_0 == null)
					{
						this.cursor_0 = ImageHelper.smethod_5("measure.cur");
					}
					control_2.Cursor = this.cursor_0;
					break;
				case Enum149.const_4:
					control_2.Cursor = Cursors.SizeWE;
					break;
				case Enum149.const_5:
					control_2.Cursor = Cursors.SizeNS;
					break;
				case Enum149.const_6:
					control_2.Cursor = Cursors.SizeNESW;
					break;
				case Enum149.const_7:
					control_2.Cursor = Cursors.SizeNWSE;
					break;
				default:
					control_2.Cursor = Cursors.Arrow;
					break;
				}
				DrawArgs.enum149_1 = DrawArgs.enum149_0;
			}
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x0000E86F File Offset: 0x0000CA6F
		public bool method_11()
		{
			return this.bool_3;
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0000E877 File Offset: 0x0000CA77
		public void method_12(bool bool_5)
		{
			this.bool_3 = bool_5;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00088F4C File Offset: 0x0008714C
		public void Dispose()
		{
			foreach (IDisposable disposable in this.hashtable_1.Values)
			{
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			this.hashtable_1.Clear();
			if (this.cursor_0 != null)
			{
				this.cursor_0.Dispose();
				this.cursor_0 = null;
			}
			if (DrawArgs.class1978_0 != null)
			{
				DrawArgs.class1978_0.Dispose();
				DrawArgs.class1978_0 = null;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x0400087F RID: 2175
		public Device device_0;

		// Token: 0x04000880 RID: 2176
		public Control control_0;

		// Token: 0x04000881 RID: 2177
		public static Control control_1 = null;

		// Token: 0x04000882 RID: 2178
		public int int_0;

		// Token: 0x04000883 RID: 2179
		public int int_1;

		// Token: 0x04000884 RID: 2180
		public int int_2 = 0;

		// Token: 0x04000885 RID: 2181
		public Microsoft.DirectX.Direct3D.Font font_0;

		// Token: 0x04000886 RID: 2182
		public Microsoft.DirectX.Direct3D.Font font_1;

		// Token: 0x04000887 RID: 2183
		public Microsoft.DirectX.Direct3D.Font font_2;

		// Token: 0x04000888 RID: 2184
		public int int_3 = 0;

		// Token: 0x04000889 RID: 2185
		public int int_4;

		// Token: 0x0400088A RID: 2186
		public static Point point_0;

		// Token: 0x0400088B RID: 2187
		public int int_5;

		// Token: 0x0400088C RID: 2188
		public string string_0 = "";

		// Token: 0x0400088D RID: 2189
		private CameraBase class1987_0;

		// Token: 0x0400088E RID: 2190
		public World class1995_0;

		// Token: 0x0400088F RID: 2191
		public static World class1995_1;

		// Token: 0x04000890 RID: 2192
		public static bool bool_0 = false;

		// Token: 0x04000891 RID: 2193
		public static bool bool_1 = false;

		// Token: 0x04000892 RID: 2194
		public static Class1978 class1978_0 = new Class1978();

		// Token: 0x04000893 RID: 2195
		public int int_6;

		// Token: 0x04000894 RID: 2196
		private static Bitmap bitmap_0;

		// Token: 0x04000895 RID: 2197
		public static Graphics graphics_0 = null;

		// Token: 0x04000896 RID: 2198
		private RenderPriority enum153_0;

		// Token: 0x04000897 RID: 2199
		public Sprite sprite_0;

		// Token: 0x04000898 RID: 2200
		public bool bool_2 = false;

		// Token: 0x04000899 RID: 2201
		protected static Hashtable hashtable_0 = new Hashtable();

		// Token: 0x0400089A RID: 2202
		public static CameraBase class1987_1 = null;

		// Token: 0x0400089B RID: 2203
		public static long long_0;

		// Token: 0x0400089C RID: 2204
		private static Enum149 enum149_0;

		// Token: 0x0400089D RID: 2205
		private static Enum149 enum149_1;

		// Token: 0x0400089E RID: 2206
		private bool bool_3 = true;

		// Token: 0x0400089F RID: 2207
		private bool bool_4;

		// Token: 0x040008A0 RID: 2208
		private Hashtable hashtable_1 = new Hashtable();

		// Token: 0x040008A1 RID: 2209
		public static Device device_1 = null;

		// Token: 0x040008A2 RID: 2210
		private Cursor cursor_0;
	}
}
