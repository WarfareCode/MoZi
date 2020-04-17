using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using ns16;
using ns17;
using ns18;
using ns19;
using ns6;

namespace ns11
{
	// Token: 0x02000309 RID: 777
	public sealed class Class1994 : RenderableObject
	{
		// Token: 0x06001242 RID: 4674 RVA: 0x000823FC File Offset: 0x000805FC
		public Class1994(string string_3, WorldWindow control0_1) : base(string_3)
		{
			this.string_1 = string_3;
			this.control0_0 = control0_1;
			Class1994.string_2 = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), Class1994.string_2);
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x000824A4 File Offset: 0x000806A4
		public string method_0()
		{
			string result = "r";
			if (this.bool_3)
			{
				result = "r";
			}
			else if (this.bool_4)
			{
				result = "a";
			}
			else if (this.bool_5)
			{
				result = "h";
			}
			else if (this.bool_6)
			{
				result = "t";
			}
			return result;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00082504 File Offset: 0x00080704
		public string method_1()
		{
			string result = "jpeg";
			if (this.bool_3 || this.bool_6)
			{
				result = "png";
			}
			return result;
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00082538 File Offset: 0x00080738
		public override void Initialize(DrawArgs class1943_0)
		{
			if (!this.isInitialized)
			{
				this.sprite_0 = new Sprite(class1943_0.device_0);
				string text = Path.GetDirectoryName(Application.ExecutablePath) + "\\WW\\Cache\\Virtual Earth\\VirtualEarthPushPin.png";
				File.Exists(text);
				this.rectangle_1 = new Rectangle(0, 0, this.int_3, this.int_4);
				this.texture_1 = TextureLoader.FromFile(class1943_0.device_0, text);
				Class1994.double_1 = class1943_0.method_3().GetEquatorialRadius();
				Class1994.double_2 = Class1994.double_1 * 2.0 * Class1994.double_0;
				Class1994.double_3 = Class1994.double_2 / 2.0;
				Class565.smethod_0(class1943_0.method_3().GetTerrainAccessor(), class1943_0.method_3().GetEquatorialRadius());
				this.float_0 = World.Settings.GetVerticalExaggeration();
				this.isInitialized = true;
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0008261C File Offset: 0x0008081C
		public void method_2()
		{
			object syncRoot = this.arrayList_0.SyncRoot;
			lock (syncRoot)
			{
				for (int i = 0; i < this.arrayList_0.Count; i++)
				{
					((Class565)this.arrayList_0[i]).Dispose();
				}
				this.arrayList_0.Clear();
			}
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0000D847 File Offset: 0x0000BA47
		public void method_3()
		{
			this.int_0 = -1;
			this.int_1 = -1;
			this.int_2 = -1;
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x0008269C File Offset: 0x0008089C
		public override bool Update(DrawArgs class1943_0)
		{
			bool result;
			try
			{
				if (!this.isOn)
				{
					result = false;
					return result;
				}
				if (!this.isInitialized)
				{
					this.Initialize(class1943_0);
					result = true;
					return result;
				}
				double degrees = class1943_0.GetWorldCamera().GetLatitude().GetDegrees();
				double degrees2 = class1943_0.GetWorldCamera().GetLongitude().GetDegrees();
				double degrees3 = class1943_0.GetWorldCamera().GetTilt().GetDegrees();
				class1943_0.GetWorldCamera().GetAltitude();
				int num = this.method_7(class1943_0.GetWorldCamera().GetTrueViewRange().GetDegrees());
				if (num < this.int_5)
				{
					this.method_2();
					this.method_3();
					result = true;
					return result;
				}
				int num2 = 1 << num;
				int num3 = (int)((180.0 + degrees2) * (double)num2 / 360.0);
				double num4 = Math.Sin(Class1994.smethod_1(degrees));
				int num5 = (int)((2.0 - Math.Log((1.0 + num4) / (1.0 - num4)) / Class1994.double_0) * (double)num2 / 4.0);
				num3 %= num2;
				object syncRoot;
				if (this.float_0 != World.Settings.GetVerticalExaggeration())
				{
					syncRoot = this.arrayList_0.SyncRoot;
					lock (syncRoot)
					{
						for (int i = 0; i < this.arrayList_0.Count; i++)
						{
							Class565 @class = (Class565)this.arrayList_0[i];
							if (@class.method_7() != World.Settings.GetVerticalExaggeration())
							{
								@class.method_25(this.GetOpacity(), World.Settings.GetVerticalExaggeration());
							}
						}
					}
				}
				this.float_0 = World.Settings.GetVerticalExaggeration();
				if (num5 == this.int_0 && num3 == this.int_1 && num == this.int_2 && degrees3 == this.double_4)
				{
					result = true;
					return result;
				}
				syncRoot = this.arrayList_0.SyncRoot;
				lock (syncRoot)
				{
					for (int j = 0; j < this.arrayList_0.Count; j++)
					{
						((Class565)this.arrayList_0[j]).method_9(false);
					}
				}
				ArrayList arrayList_ = null;
				this.method_5(class1943_0, num5, num3, num, arrayList_);
				this.method_4(class1943_0, num5, num3, num, null, 1);
				this.method_4(class1943_0, num5, num3, num, null, 2);
				this.method_4(class1943_0, num5, num3, num, null, 3);
				this.method_4(class1943_0, num5, num3, num, null, 4);
				if (degrees3 > 40.0)
				{
					this.method_4(class1943_0, num5, num3, num, null, 4);
				}
				if (degrees3 > 50.0)
				{
					this.method_4(class1943_0, num5, num3, num, null, 5);
				}
				if (degrees3 > 60.0)
				{
					this.method_4(class1943_0, num5, num3, num, null, 6);
				}
				syncRoot = this.arrayList_0.SyncRoot;
				lock (syncRoot)
				{
					for (int k = 0; k < this.arrayList_0.Count; k++)
					{
						Class565 class2 = (Class565)this.arrayList_0[k];
						if (!class2.method_8())
						{
							class2.Dispose();
							this.arrayList_0.RemoveAt(k);
							k--;
						}
					}
				}
				this.int_0 = num5;
				this.int_1 = num3;
				this.int_2 = num;
				this.double_4 = degrees3;
			}
			catch (Exception exception_)
			{
				Log.smethod_3(exception_);
			}
			result = true;
			return result;
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00082ADC File Offset: 0x00080CDC
		private void method_4(DrawArgs class1943_0, int int_6, int int_7, int int_8, ArrayList arrayList_2, int int_9)
		{
			int num = int_6 - int_9;
			int num2 = int_6 + int_9;
			int num3 = int_7 - int_9;
			int num4 = int_7 + int_9;
			for (int i = num; i <= num2; i++)
			{
				for (int j = num3; j <= num4; j++)
				{
					if (i == num || i == num2 || j == num3 || j == num4)
					{
						this.method_5(class1943_0, i, j, int_8, arrayList_2);
					}
				}
			}
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00082B54 File Offset: 0x00080D54
		private void method_5(DrawArgs class1943_0, int int_6, int int_7, int int_8, ArrayList arrayList_2)
		{
			bool flag = false;
			int num = 1 << int_8;
			int_7 %= num;
			if (int_7 < 0)
			{
				int_7 += num;
			}
			object syncRoot = this.arrayList_0.SyncRoot;
			lock (syncRoot)
			{
				foreach (Class565 @class in this.arrayList_0)
				{
					if (!@class.method_8() && @class.method_10(int_6, int_7, int_8))
					{
						@class.method_9(true);
						flag = true;
						break;
					}
				}
			}
			if (!flag && int_6 >= 0 && (double)int_6 < Math.Pow(2.0, (double)int_8) && this.method_7(class1943_0.GetWorldCamera().GetTrueViewRange().GetDegrees()) == int_8)
			{
				Class565 class2 = this.method_6(class1943_0, int_6, int_7, int_8, arrayList_2);
				class2.method_9(true);
				syncRoot = this.arrayList_0.SyncRoot;
				lock (syncRoot)
				{
					this.arrayList_0.Add(class2);
				}
			}
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00082CCC File Offset: 0x00080ECC
		private Class565 method_6(DrawArgs class1943_0, int int_6, int int_7, int int_8, ArrayList arrayList_2)
		{
			Class565 @class = new Class565(int_6, int_7, int_8, this);
			if (arrayList_2 != null)
			{
				foreach (string string_ in arrayList_2)
				{
					@class.method_18(string_);
				}
			}
			@class.method_12(class1943_0, 256);
			double num = Class1994.smethod_0(int_8);
			double num2 = Math.Pow(2.0, (double)int_8) * 256.0 * num / 2.0;
			double num3 = (double)int_6 * (256.0 * num);
			double num4 = (double)int_7 * (256.0 * num);
			num3 = num2 - num3;
			num4 -= num2;
			double num5 = num4 + 256.0 * num;
			double num6 = num3 - 256.0 * num;
			@class.method_1(new Struct57(num4, num3));
			@class.method_3(new Struct57(num5, num3));
			@class.method_5(new Struct57(num4, num6));
			@class.method_6(new Struct57(num5, num6));
			byte opacity = this.GetOpacity();
			float verticalExaggeration = World.Settings.GetVerticalExaggeration();
			@class.method_25(opacity, verticalExaggeration);
			@class.method_30(class1943_0, World.Settings.DownloadQueuedColor.ToArgb());
			return @class;
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00082E44 File Offset: 0x00081044
		private static double smethod_0(int int_6)
		{
			return Class1994.double_2 / (double)((1 << int_6) * 256);
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00082E68 File Offset: 0x00081068
		private static double smethod_1(double double_5)
		{
			return double_5 * Class1994.double_0 / 180.0;
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00082E88 File Offset: 0x00081088
		public int method_7(double double_5)
		{
			int num = 3;
			int num2 = 17;
			int result = 3;
			for (int i = 0; i < num2; i++)
			{
				result = i + num;
				double num3 = 180.0;
				for (int j = 0; j < i; j++)
				{
					num3 /= 2.0;
				}
				if (double_5 >= num3)
				{
					break;
				}
			}
			return result;
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00082EE8 File Offset: 0x000810E8
		public override void Render(DrawArgs class1943_0)
		{
			try
			{
				if (this.isOn && this.isInitialized && !(class1943_0.device_0 == null))
				{
					if (this.arrayList_0 != null && this.arrayList_0.Count > 0)
					{
						bool bool_ = false;
						class1943_0.device_0.Transform.World = Matrix.Translation(-(float)class1943_0.GetWorldCamera().ReferenceCenter.X, -(float)class1943_0.GetWorldCamera().ReferenceCenter.Y, -(float)class1943_0.GetWorldCamera().ReferenceCenter.Z);
						class1943_0.device_0.Clear(ClearFlags.ZBuffer, 0, 1f, 0);
						int num = this.method_7(class1943_0.GetWorldCamera().GetTrueViewRange().GetDegrees());
						if (Class565.smethod_3(class1943_0, false, this.arrayList_0, num) == 0)
						{
							Class565.smethod_3(class1943_0, bool_, this.arrayList_0, this.int_2);
						}
						class1943_0.device_0.Transform.World = class1943_0.GetWorldCamera().GetWorldMatrix();
						this.method_8(class1943_0, null, 0);
					}
					if (this.arrayList_1 != null && this.arrayList_1.Count > 0)
					{
						this.method_10(class1943_0);
					}
				}
			}
			catch (Exception exception_)
			{
				Log.smethod_3(exception_);
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0008305C File Offset: 0x0008125C
		public void method_8(DrawArgs class1943_0, Class2003 class2003_0, int int_6)
		{
			int num = 24;
			int num2 = 24;
			Vector3 vector = new Vector3((float)(DrawArgs.control_1.Width - 24 - 10), (float)(DrawArgs.control_1.Height - 34 - 4 * int_6), 0.5f);
			if (Class1994.string_2 != null)
			{
				if (Class1994.texture_0 == null)
				{
					Class1994.texture_0 = ImageHelper.LoadIconTexture(Class1994.string_2);
				}
				if (this.sprite_1 == null)
				{
					using (Surface surfaceLevel = Class1994.texture_0.GetSurfaceLevel(0))
					{
						SurfaceDescription description = surfaceLevel.Description;
						Class1994.rectangle_0 = new Rectangle(0, 0, description.Width, description.Height);
					}
					this.sprite_1 = new Sprite(DrawArgs.device_1);
				}
				float valueX = 2f * (float)num2 / (float)Class1994.rectangle_0.Width;
				float valueY = 2f * (float)num / (float)Class1994.rectangle_0.Height;
				this.sprite_1.Begin(SpriteFlags.AlphaBlend);
				this.sprite_1.Transform = Matrix.Transformation2D(new Vector2(0f, 0f), 0f, new Vector2(valueX, valueY), new Vector2(0f, 0f), 0f, new Vector2(vector.X, vector.Y));
				this.sprite_1.Draw(Class1994.texture_0, Class1994.rectangle_0, new Vector3(63.36f, 63.36f, 0f), new Vector3(0f, 0f, 0f), Color.Crimson);
				this.sprite_1.End();
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00083218 File Offset: 0x00081418
		public void method_9(DrawArgs drawArgs, out double lat1, out double lon1, out double lat2, out double lon2)
		{
			double num = drawArgs.GetWorldCamera().GetTrueViewRange().GetDegrees() / 2.0;
			double degrees = drawArgs.GetWorldCamera().GetLatitude().GetDegrees();
			double degrees2 = drawArgs.GetWorldCamera().GetLongitude().GetDegrees();
			lat1 = degrees + num;
			lon1 = degrees2 + num;
			lat2 = degrees - num;
			lon2 = degrees2 - num;
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x00083284 File Offset: 0x00081484
		public void method_10(DrawArgs class1943_0)
		{
			if (this.arrayList_1 != null && this.arrayList_1.Count > 0)
			{
				double num = 0.0;
				double num2 = 0.0;
				double num3 = 0.0;
				double num4 = 0.0;
				this.method_9(class1943_0, out num, out num2, out num3, out num4);
				object syncRoot = this.arrayList_1.SyncRoot;
				lock (syncRoot)
				{
					foreach (Class566 @class in this.arrayList_1)
					{
						if (@class.double_0 <= num && @class.double_0 >= num3 && @class.double_1 <= num2 && @class.double_1 >= num4)
						{
							Vector3 vector = MathEngine.SphericalToCartesian((double)((float)@class.double_0), (double)((float)@class.double_1), (double)((float)Class1994.double_1 + 100f));
							vector.Project(class1943_0.device_0.Viewport, class1943_0.GetWorldCamera().GetProjectionMatrix(), class1943_0.GetWorldCamera().GetViewMatrix(), class1943_0.GetWorldCamera().GetWorldMatrix());
							this.sprite_0.Begin(SpriteFlags.AlphaBlend);
							this.sprite_0.Transform = Matrix.Transformation2D(new Vector2(0f, 0f), 0f, new Vector2(this.float_1, this.float_2), new Vector2(0f, 0f), 0f, new Vector2(vector.X, vector.Y));
							this.sprite_0.Draw(this.texture_1, this.rectangle_1, new Vector3(0.5f * (float)this.int_3, 0.5f * (float)this.int_4, 0f), new Vector3(0f, 0f, 0f), Color.White);
							this.sprite_0.End();
						}
					}
				}
			}
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x000834E8 File Offset: 0x000816E8
		public override void Dispose()
		{
			this.method_2();
			if (this.sprite_0 != null)
			{
				this.sprite_0.Dispose();
				this.sprite_0 = null;
			}
			if (this.sprite_1 != null)
			{
				this.sprite_1.Dispose();
				this.sprite_1 = null;
			}
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x000081A2 File Offset: 0x000063A2
		public override bool PerformSelectionAction(DrawArgs class1943_0)
		{
			return false;
		}

		// Token: 0x04000788 RID: 1928
		private static double double_0 = 3.1415926535897931;

		// Token: 0x04000789 RID: 1929
		private static double double_1;

		// Token: 0x0400078A RID: 1930
		private static double double_2;

		// Token: 0x0400078B RID: 1931
		private static double double_3;

		// Token: 0x0400078C RID: 1932
		private static string string_2 = "WW\\Cache\\Virtual Earth\\vejewel.png";

		// Token: 0x0400078D RID: 1933
		private static Texture texture_0;

		// Token: 0x0400078E RID: 1934
		private static Rectangle rectangle_0;

		// Token: 0x0400078F RID: 1935
		private int int_0 = -1;

		// Token: 0x04000790 RID: 1936
		private int int_1 = -1;

		// Token: 0x04000791 RID: 1937
		private int int_2 = -1;

		// Token: 0x04000792 RID: 1938
		private float float_0 = -1f;

		// Token: 0x04000793 RID: 1939
		private double double_4;

		// Token: 0x04000794 RID: 1940
		private ArrayList arrayList_0 = new ArrayList();

		// Token: 0x04000795 RID: 1941
		public WorldWindow control0_0;

		// Token: 0x04000796 RID: 1942
		private Sprite sprite_0;

		// Token: 0x04000797 RID: 1943
		private Sprite sprite_1;

		// Token: 0x04000798 RID: 1944
		private Texture texture_1;

		// Token: 0x04000799 RID: 1945
		private float float_1 = 0.25f;

		// Token: 0x0400079A RID: 1946
		private float float_2 = 0.25f;

		// Token: 0x0400079B RID: 1947
		private int int_3 = 128;

		// Token: 0x0400079C RID: 1948
		private int int_4 = 128;

		// Token: 0x0400079D RID: 1949
		private Rectangle rectangle_1;

		// Token: 0x0400079E RID: 1950
		public int int_5 = 7;

		// Token: 0x0400079F RID: 1951
		public bool bool_3;

		// Token: 0x040007A0 RID: 1952
		public bool bool_4 = true;

		// Token: 0x040007A1 RID: 1953
		public bool bool_5;

		// Token: 0x040007A2 RID: 1954
		public bool bool_6;

		// Token: 0x040007A3 RID: 1955
		public bool bool_7 = true;

		// Token: 0x040007A4 RID: 1956
		private ArrayList arrayList_1;
	}
}
