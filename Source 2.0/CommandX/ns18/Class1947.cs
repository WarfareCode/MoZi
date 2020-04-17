using System;
using System.IO;
using System.Net;
using Microsoft.DirectX.Direct3D;
using ns16;
using ns17;
using ns19;

namespace ns18
{
	// Token: 0x0200036E RID: 878
	public class Class1947
	{
		// Token: 0x060014EF RID: 5359 RVA: 0x0008A500 File Offset: 0x00088700
		public double method_0()
		{
			return this.double_0;
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0000EC24 File Offset: 0x0000CE24
		public void method_1(double double_1)
		{
			this.double_0 = double_1;
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0008A518 File Offset: 0x00088718
		public int method_2()
		{
			return this.int_0;
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0000EC2D File Offset: 0x0000CE2D
		public void method_3(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0000EC36 File Offset: 0x0000CE36
		public void method_4(string string_4)
		{
			this.string_1 = string_4.Replace(".", "");
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0000EC4E File Offset: 0x0000CE4E
		public void method_5(string string_4)
		{
			this.string_2 = string_4;
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0000EC57 File Offset: 0x0000CE57
		public void method_6(string string_4)
		{
			this.string_0 = string_4;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0008A530 File Offset: 0x00088730
		public string method_7()
		{
			return this.string_3;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000081A2 File Offset: 0x000063A2
		public   bool vmethod_0()
		{
			return false;
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0008A548 File Offset: 0x00088748
		public virtual string vmethod_1(Class1992 class1992_0)
		{
			if (class1992_0.int_0 >= this.int_0)
			{
				throw new ArgumentException(string.Format("Level {0} not available.", class1992_0.int_0));
			}
			string text = string.Format("{0}\\{1:D4}\\{1:D4}_{2:D4}.{3}", new object[]
			{
				class1992_0.int_0,
				class1992_0.int_1,
				class1992_0.int_2,
				this.string_1
			});
			string result;
			if (this.string_0 != null)
			{
				string text2 = Path.Combine(this.string_0, text);
				if (File.Exists(text2))
				{
					result = text2;
					return result;
				}
			}
			if (this.string_2 == null)
			{
				if (this.string_3 == null)
				{
					Log.smethod_2(Log.Levels.int_1, string.Format("Unable to locate tile texture {0}", text));
				}
				result = this.string_3;
			}
			else
			{
				string text3 = Path.Combine(this.string_2, text);
				if (File.Exists(text3))
				{
					result = text3;
				}
				else
				{
					string directoryName = Path.GetDirectoryName(text3);
					if (Directory.Exists(directoryName))
					{
						string[] files = Directory.GetFiles(directoryName, Path.GetFileNameWithoutExtension(text3) + ".*");
						for (int i = 0; i < files.Length; i++)
						{
							string text4 = files[i];
							string value = Path.GetExtension(text4).ToLower();
							if (".bmp.dds.dib.hdr.jpg.jpeg.pfm.png.ppm.tga.gif.tif".IndexOf(value) >= 0)
							{
								result = text4;
								return result;
							}
						}
					}
					result = text3;
				}
			}
			return result;
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0008A6C4 File Offset: 0x000888C4
		protected virtual string vmethod_2(Class1992 class1992_0)
		{
			string result;
			if (this.string_3 != null && File.Exists(this.string_3))
			{
				result = this.string_3;
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0008A6FC File Offset: 0x000888FC
		protected virtual void vmethod_3(Texture texture_0, string string_4)
		{
			if (!string_4.ToLower().EndsWith(".dds"))
			{
				TextureLoader.Save(Path.Combine(Path.GetDirectoryName(string_4), Path.GetFileNameWithoutExtension(string_4) + ".dds"), ImageFileFormat.Dds, texture_0);
				try
				{
					File.Delete(string_4);
				}
				catch
				{
				}
			}
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0008A758 File Offset: 0x00088958
		public Texture method_8(Class1992 class1992_0)
		{
			string text = this.vmethod_1(class1992_0);
			class1992_0.string_0 = text;
			Texture result;
			if (!File.Exists(text))
			{
				string text2 = text + ".txt";
				if (File.Exists(text2))
				{
					FileInfo fileInfo = new FileInfo(text2);
					if (DateTime.Now - fileInfo.LastWriteTime < TimeSpan.FromDays(1.0))
					{
						result = null;
						return result;
					}
					File.Delete(text2);
				}
				if (this.vmethod_0())
				{
					this.method_9(class1992_0, text);
					result = null;
					return result;
				}
				if (this.method_7() == null)
				{
					result = null;
					return result;
				}
				text = this.method_7();
			}
			Texture texture;
			if (class1992_0.class1998_0.vmethod_19())
			{
				texture = ImageHelper.smethod_2(text, class1992_0.class1998_0.int_1, class1992_0.class1998_0.int_2);
			}
			else
			{
				texture = ImageHelper.smethod_1(text, class1992_0.class1998_0.int_1);
			}
			if (class1992_0.class1998_0.method_4() != TimeSpan.MaxValue)
			{
				DateTime t = new FileInfo(text).LastWriteTimeUtc.Add(class1992_0.class1998_0.method_4());
				if (DateTime.UtcNow > t)
				{
					this.method_9(class1992_0, text);
				}
			}
			if (World.Settings.method_37() && this.vmethod_0())
			{
				this.vmethod_3(texture, text);
			}
			result = texture;
			return result;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0008A8C8 File Offset: 0x00088AC8
		private void method_9(Class1992 class1992_0, string string_4)
		{
			string string_5 = this.vmethod_2(class1992_0);
			Class2003 @class = new Class2003(class1992_0, this, string_4, string_5);
			if (this.iwebProxy_0 == null && !this.bool_0)
			{
				this.iwebProxy_0 = Class1984.smethod_2(string_5);
				this.bool_0 = true;
			}
			@class.method_0(this.iwebProxy_0);
			class1992_0.class1998_0.vmethod_20(class1992_0.class1998_0.method_22(), @class);
		}

		// Token: 0x040008D2 RID: 2258
		protected string string_0;

		// Token: 0x040008D3 RID: 2259
		protected double double_0 = 36.0;

		// Token: 0x040008D4 RID: 2260
		protected int int_0 = 1;

		// Token: 0x040008D5 RID: 2261
		protected string string_1;

		// Token: 0x040008D6 RID: 2262
		protected string string_2 = "";

		// Token: 0x040008D7 RID: 2263
		protected string string_3 = "";

		// Token: 0x040008D8 RID: 2264
		protected IWebProxy iwebProxy_0;

		// Token: 0x040008D9 RID: 2265
		protected bool bool_0;
	}
}
