using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using ns17;
using ns18;
using ns19;

namespace ns16
{
	// Token: 0x02000484 RID: 1156
	public sealed class ImageLayer : RenderableObject
	{
		// Token: 0x06001DEC RID: 7660 RVA: 0x000124BE File Offset: 0x000106BE
		public void method_0(int int_5)
		{
			this.int_4 = int_5;
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x000C0AD0 File Offset: 0x000BECD0
		public double method_1()
		{
			return this.double_2;
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x000C0AE8 File Offset: 0x000BECE8
		public float method_2()
		{
			return this.float_2;
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x000124C7 File Offset: 0x000106C7
		public bool method_3()
		{
			return this.bool_4;
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x000C0B00 File Offset: 0x000BED00
		public ImageLayer(string string_4, World class1995_2, double double_5, string string_5, double double_6, double double_7, double double_8, double double_9, byte byte_1, TerrainAccessor class1969_1) : base(string_4, class1995_2.vmethod_15(), class1995_2.vmethod_17())
		{
			this.class1995_1 = class1995_2;
			this.double_0 = (double)((float)class1995_2.GetEquatorialRadius()) + double_5;
			this.string_3 = string_5;
			this.double_1 = double_6;
			this.double_2 = double_7;
			this.double_3 = double_8;
			this.double_4 = double_9;
			this.byte_0 = byte_1;
			this.class1969_0 = class1969_1;
			this.string_3 = string_5;
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x000C0C24 File Offset: 0x000BEE24
		public ImageLayer(string string_4, World class1995_2, double double_5, Stream stream_1, int int_5, double double_6, double double_7, double double_8, double double_9, double double_10, TerrainAccessor class1969_1) : this(string_4, class1995_2, double_5, null, double_6, double_7, double_8, double_9, (byte)(255.0 * double_10), class1969_1)
		{
			this.stream_0 = stream_1;
			this.int_4 = int_5;
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x000C0C64 File Offset: 0x000BEE64
		public ImageLayer(string string_4, World class1995_2, double double_5, string string_5, double double_6, double double_7, double double_8, double double_9, double double_10, TerrainAccessor class1969_1) : this(string_4, class1995_2, double_5, string_5, double_6, double_7, double_8, double_9, (byte)(255.0 * double_10), class1969_1)
		{
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x000C0C94 File Offset: 0x000BEE94
		public override void Initialize(DrawArgs class1943_0)
		{
			try
			{
				this.device_0 = class1943_0.device_0;
				if (this.string_3 == null && this.string_2 != null && this.string_2.ToLower().StartsWith("http://"))
				{
					this.string_3 = ImageLayer.smethod_0(this.string_2);
				}
				FileInfo fileInfo = null;
				if (this.string_3 != null)
				{
					fileInfo = new FileInfo(this.string_3);
				}
				if (this.thread_0 == null || !this.thread_0.IsAlive)
				{
					if (this.string_3 != null && this.timeSpan_0 != TimeSpan.MaxValue && this.timeSpan_0.TotalMilliseconds > 0.0 && this.string_2.ToLower().StartsWith("http://") && fileInfo != null && fileInfo.Exists && fileInfo.LastWriteTime < DateTime.Now - this.timeSpan_0)
					{
						this.thread_0 = Class920.smethod_0(new ThreadStart(this.method_4));
						this.thread_0.Name = "ImageLayer.DownloadImage";
						this.thread_0.IsBackground = true;
						this.thread_0.Start();
					}
					else if (this.stream_0 != null)
					{
						this.method_8(this.stream_0, this.int_4);
						this.float_1 = World.Settings.GetVerticalExaggeration();
						this.vmethod_18();
						this.isInitialized = true;
					}
					else if (fileInfo != null && fileInfo.Exists)
					{
						this.method_7(this.string_3);
						this.float_1 = World.Settings.GetVerticalExaggeration();
						this.vmethod_18();
						this.isInitialized = true;
					}
					else if (this.string_2 != null && this.string_2.ToLower().StartsWith("http://"))
					{
						this.thread_0 = Class920.smethod_0(new ThreadStart(this.method_4));
						this.thread_0.Name = "ImageLayer.DownloadImage";
						this.thread_0.IsBackground = true;
						this.thread_0.Start();
					}
					else
					{
						this.Dispose();
						this.isOn = false;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x000C0EE8 File Offset: 0x000BF0E8
		protected void method_4()
		{
			try
			{
				if (this.string_3 != null)
				{
					Directory.CreateDirectory(Path.GetDirectoryName(this.string_3));
				}
				using (Class1984 @class = new Class1984(this.string_2))
				{
					Class1984 class2 = @class;
					class2.delegate36_0 = (Delegate36)Delegate.Combine(class2.delegate36_0, new Delegate36(this.method_5));
					ImageLayer.smethod_0(this.string_2);
					if (this.string_3 == null)
					{
						@class.method_5();
						this.texture_0 = ImageHelper.smethod_3(@class.stream_0);
					}
					else
					{
						@class.method_6(this.string_3);
						this.method_7(this.string_3);
					}
					this.vmethod_18();
					this.isInitialized = true;
				}
			}
			catch (ThreadAbortException)
			{
			}
			catch (Exception ex)
			{
				if (!this.bool_5)
				{
					MessageBox.Show(string.Format("Image download of file\n\n{1}\n\nfor layer '{0}' failed:\n\n{2}", this.string_1, this.string_2, ex.Message), "Image download failed.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					this.bool_5 = true;
				}
				if (this.string_3 != null)
				{
					if (new FileInfo(this.string_3).Exists)
					{
						this.method_7(this.string_3);
						this.vmethod_18();
						this.isInitialized = true;
					}
				}
				else
				{
					this.isOn = false;
				}
			}
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x000124CF File Offset: 0x000106CF
		protected void method_5(int int_5, int int_6)
		{
			if (int_5 < int_6)
			{
				this.float_0 = (float)int_5 / (float)int_6;
			}
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x000C1058 File Offset: 0x000BF258
		public override bool Update(DrawArgs class1943_0)
		{
			bool flag = false;
			bool result;
			try
			{
				if (!this.isInitialized)
				{
					this.Initialize(class1943_0);
					if (!this.isInitialized)
					{
						result = false;
						return result;
					}
					flag = true;
				}
				if (this.class1959_0 == null && this.isInitialized && Math.Abs(this.float_1 - World.Settings.GetVerticalExaggeration()) > 0.01f)
				{
					this.float_1 = World.Settings.GetVerticalExaggeration();
					this.isInitialized = false;
					this.vmethod_18();
					this.isInitialized = true;
					flag = true;
				}
				if (this.timeSpan_0 != TimeSpan.MaxValue && this.timeSpan_0.TotalMilliseconds > 0.0)
				{
					if (this.timer_0 == null)
					{
						this.timer_0 = new System.Timers.Timer(this.timeSpan_0.TotalMilliseconds);
						this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
						this.timer_0.Start();
					}
					if (this.timer_0.Interval != this.timeSpan_0.TotalMilliseconds)
					{
						this.timer_0.Interval = this.timeSpan_0.TotalMilliseconds;
					}
				}
				else if (this.timer_0 != null && this.timer_0.Enabled)
				{
					this.timer_0.Stop();
				}
			}
			catch
			{
			}
			result = flag;
			return result;
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x000081A2 File Offset: 0x000063A2
		public override bool PerformSelectionAction(DrawArgs class1943_0)
		{
			return false;
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x0008239C File Offset: 0x0008059C
		public override byte GetOpacity()
		{
			return this.byte_0;
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x000124E5 File Offset: 0x000106E5
		public override void SetOpacity(byte byte_1)
		{
			this.byte_0 = byte_1;
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x000C11D4 File Offset: 0x000BF3D4
		protected  void vmethod_18()
		{
			if (!ImageLayer.Class1990.smethod_1(this.double_1, this.method_1(), this.double_3, this.double_4, this.int_0, ref this.positionNormalTextured_0, ref this.short_0))
			{
				int num = this.int_0 - 1;
				float num2 = 1f / (float)num;
				double num3 = Math.Abs(this.double_2 - this.double_1);
				double num4;
				if (this.double_3 < this.double_4)
				{
					num4 = this.double_4 - this.double_3;
				}
				else
				{
					num4 = 360.0 + this.double_4 - this.double_3;
				}
				Color.FromArgb((int)this.byte_0, 0, 0, 0).ToArgb();
				this.positionNormalTextured_0 = new CustomVertex.PositionNormalTextured[this.int_0 * this.int_0];
				for (int i = 0; i < this.int_0; i++)
				{
					for (int j = 0; j < this.int_0; j++)
					{
						double num5 = 0.0;
						if (this.class1969_0 != null)
						{
							num5 = (double)(this.float_1 * this.class1969_0.vmethod_0(this.double_2 - (double)num2 * num3 * (double)i, this.double_3 + (double)num2 * num4 * (double)j, (double)num / num3));
						}
						Vector3 vector = MathEngine.SphericalToCartesian(this.double_2 - (double)num2 * num3 * (double)i, this.double_3 + (double)num2 * num4 * (double)j, this.double_0 + num5);
						this.positionNormalTextured_0[i * this.int_0 + j].X = vector.X;
						this.positionNormalTextured_0[i * this.int_0 + j].Y = vector.Y;
						this.positionNormalTextured_0[i * this.int_0 + j].Z = vector.Z;
						this.positionNormalTextured_0[i * this.int_0 + j].Tu = (float)j * num2;
						this.positionNormalTextured_0[i * this.int_0 + j].Tv = (float)i * num2;
					}
				}
				this.short_0 = new short[2 * num * num * 3];
				for (int k = 0; k < num; k++)
				{
					for (int l = 0; l < num; l++)
					{
						this.short_0[6 * k * num + 6 * l] = (short)(k * this.int_0 + l);
						this.short_0[6 * k * num + 6 * l + 1] = (short)((k + 1) * this.int_0 + l);
						this.short_0[6 * k * num + 6 * l + 2] = (short)(k * this.int_0 + l + 1);
						this.short_0[6 * k * num + 6 * l + 3] = (short)(k * this.int_0 + l + 1);
						this.short_0[6 * k * num + 6 * l + 4] = (short)((k + 1) * this.int_0 + l);
						this.short_0[6 * k * num + 6 * l + 5] = (short)((k + 1) * this.int_0 + l + 1);
					}
				}
				this.method_6(ref this.positionNormalTextured_0, this.short_0);
				ImageLayer.Class1990.smethod_0(this.double_1, this.method_1(), this.double_3, this.double_4, this.int_0, this.positionNormalTextured_0, this.short_0);
			}
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x000C1564 File Offset: 0x000BF764
		private void method_6(ref CustomVertex.PositionNormalTextured[] positionNormalTextured_1, short[] short_1)
		{
			ArrayList[] array = new ArrayList[positionNormalTextured_1.Length];
			for (int i = 0; i < positionNormalTextured_1.Length; i++)
			{
				array[i] = new ArrayList();
			}
			for (int j = 0; j < short_1.Length; j += 3)
			{
				Vector3 position = positionNormalTextured_1[(int)short_1[j]].Position;
				Vector3 position2 = positionNormalTextured_1[(int)short_1[j + 1]].Position;
				Vector3 position3 = positionNormalTextured_1[(int)short_1[j + 2]].Position;
				Vector3 left = position2 - position;
				Vector3 right = position3 - position;
				Vector3 vector = Vector3.Cross(left, right);
				vector.Normalize();
				array[(int)short_1[j]].Add(vector);
				array[(int)short_1[j + 1]].Add(vector);
				array[(int)short_1[j + 2]].Add(vector);
			}
			for (int k = 0; k < positionNormalTextured_1.Length; k++)
			{
				for (int l = 0; l < array[k].Count; l++)
				{
					Vector3 vector2 = (Vector3)array[k][l];
					if (positionNormalTextured_1[k].Normal == Vector3.Empty)
					{
						positionNormalTextured_1[k].Normal = vector2;
					}
					else
					{
						CustomVertex.PositionNormalTextured[] array2 = positionNormalTextured_1;
						int num = k;
						array2[num].Normal = array2[num].Normal + vector2;
					}
				}
				positionNormalTextured_1[k].Normal.Multiply(1f / (float)array[k].Count);
			}
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x000C170C File Offset: 0x000BF90C
		public override void Render(DrawArgs class1943_0)
		{
			if (this.thread_0 != null && this.thread_0.IsAlive)
			{
				this.vmethod_19(class1943_0);
			}
			if (this.isInitialized)
			{
				try
				{
					if (!(this.texture_0 == null) && this.class1959_0 == null)
					{
						class1943_0.device_0.SetTexture(0, this.texture_0);
						if (this.bool_3)
						{
							if (class1943_0.device_0.RenderState.ZBufferEnable)
							{
								class1943_0.device_0.RenderState.ZBufferEnable = false;
							}
						}
						else if (!class1943_0.device_0.RenderState.ZBufferEnable)
						{
							class1943_0.device_0.RenderState.ZBufferEnable = true;
						}
						class1943_0.device_0.RenderState.ZBufferEnable = true;
						class1943_0.device_0.Clear(ClearFlags.ZBuffer, 0, 1f, 0);
						class1943_0.device_0.Transform.World = Matrix.Translation(-(float)class1943_0.GetWorldCamera().ReferenceCenter.X, -(float)class1943_0.GetWorldCamera().ReferenceCenter.Y, -(float)class1943_0.GetWorldCamera().ReferenceCenter.Z);
						this.device_0.VertexFormat = (VertexFormats.PositionNormal | VertexFormats.Texture1);
						if (this.method_3() && this.device_0.DeviceCaps.PixelShaderVersion.Major >= 1)
						{
							if (ImageLayer.effect_0 == null)
							{
								this.device_0.DeviceReset += new EventHandler(this.device_0_DeviceReset);
								this.device_0_DeviceReset(this.device_0, null);
							}
							ImageLayer.effect_0.Technique = "RenderGrayscaleBrightness";
							ImageLayer.effect_0.SetValue("WorldViewProj", Matrix.Multiply(this.device_0.Transform.World, Matrix.Multiply(this.device_0.Transform.View, this.device_0.Transform.Projection)));
							ImageLayer.effect_0.SetValue("Tex0", this.texture_0);
							ImageLayer.effect_0.SetValue("Brightness", this.method_2());
							float f = (float)this.byte_0 / 255f;
							ImageLayer.effect_0.SetValue("Opacity", f);
							int num = ImageLayer.effect_0.Begin(FX.None);
							for (int i = 0; i < num; i++)
							{
								ImageLayer.effect_0.BeginPass(i);
								class1943_0.device_0.DrawIndexedUserPrimitives(PrimitiveType.TriangleList, 0, this.positionNormalTextured_0.Length, this.short_0.Length / 3, this.short_0, true, this.positionNormalTextured_0);
								ImageLayer.effect_0.EndPass();
							}
							ImageLayer.effect_0.End();
						}
						else
						{
							if (World.Settings.IsEnableSunShading())
							{
								Point3d point3d = Class1958.smethod_0(TimeKeeper.smethod_0());
								Vector3 direction = new Vector3((float)point3d.X, (float)point3d.Y, (float)point3d.Z);
								this.device_0.RenderState.Lighting = true;
								Material material = new Material();
								material.Diffuse = Color.White;
								material.Ambient = Color.White;
								this.device_0.Material = material;
								this.device_0.RenderState.AmbientColor = World.Settings.ShadingAmbientColor.ToArgb();
								this.device_0.RenderState.NormalizeNormals = true;
								this.device_0.RenderState.AlphaBlendEnable = true;
								this.device_0.Lights[0].Enabled = true;
								this.device_0.Lights[0].Type = LightType.Directional;
								this.device_0.Lights[0].Diffuse = Color.White;
								this.device_0.Lights[0].Direction = direction;
								this.device_0.TextureState[0].ColorOperation = TextureOperation.Modulate;
								this.device_0.TextureState[0].ColorArgument1 = TextureArgument.Diffuse;
								this.device_0.TextureState[0].ColorArgument2 = TextureArgument.TextureColor;
							}
							else
							{
								this.device_0.RenderState.Lighting = false;
								this.device_0.RenderState.Ambient = World.Settings.StandardAmbientColor;
								class1943_0.device_0.TextureState[0].ColorOperation = TextureOperation.SelectArg1;
								class1943_0.device_0.TextureState[0].ColorArgument1 = TextureArgument.TextureColor;
							}
							this.device_0.RenderState.TextureFactor = Color.FromArgb((int)this.byte_0, 0, 0, 0).ToArgb();
							this.device_0.TextureState[0].AlphaOperation = TextureOperation.BlendFactorAlpha;
							this.device_0.TextureState[0].AlphaArgument1 = TextureArgument.TextureColor;
							this.device_0.TextureState[0].AlphaArgument2 = TextureArgument.TFactor;
							class1943_0.device_0.VertexFormat = (VertexFormats.PositionNormal | VertexFormats.Texture1);
							class1943_0.device_0.DrawIndexedUserPrimitives(PrimitiveType.TriangleList, 0, this.positionNormalTextured_0.Length, this.short_0.Length / 3, this.short_0, true, this.positionNormalTextured_0);
						}
						class1943_0.device_0.Transform.World = class1943_0.GetWorldCamera().GetWorldMatrix();
					}
				}
				finally
				{
					if (this.byte_0 < 255)
					{
						this.device_0.RenderState.SourceBlend = Blend.SourceAlpha;
						this.device_0.RenderState.DestinationBlend = Blend.InvSourceAlpha;
					}
					if (this.bool_3)
					{
						class1943_0.device_0.RenderState.ZBufferEnable = true;
					}
				}
			}
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x000C1CC8 File Offset: 0x000BFEC8
		private void device_0_DeviceReset(object sender, EventArgs e)
		{
			Device device = (Device)sender;
			string text = "";
			ImageLayer.effect_0 = Effect.FromFile(device, "shaders\\grayscale.fx", null, null, ShaderFlags.None, null, out text);
			if (text != null && text.Length > 0)
			{
				Log.smethod_2(Log.Levels.Error, text);
			}
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00004BC2 File Offset: 0x00002DC2
		protected  void vmethod_19(DrawArgs class1943_0)
		{
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x000C1D18 File Offset: 0x000BFF18
		private static string smethod_0(string string_4)
		{
			if (string_4.ToLower().StartsWith("http://"))
			{
				string_4 = string_4.Substring(7);
			}
			char[] invalidPathChars = Path.GetInvalidPathChars();
			for (int i = 0; i < invalidPathChars.Length; i++)
			{
				char c = invalidPathChars[i];
				string_4 = string_4.Replace(c.ToString(), "");
			}
			string_4 = string_4.Replace(":", "").Replace("*", "").Replace("?", "");
			return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), Path.Combine("Cache\\ImageUrls", string_4));
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x000C1DC0 File Offset: 0x000BFFC0
		public void method_7(string string_4)
		{
			try
			{
				if (this.device_0 != null)
				{
					Texture texture = this.texture_0;
					this.string_3 = string_4;
					Texture texture2 = ImageHelper.smethod_0(string_4);
					this.texture_0 = texture2;
					if (texture != null)
					{
						texture.Dispose();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x000C1E24 File Offset: 0x000C0024
		public void method_8(Stream stream_1, int int_5)
		{
			try
			{
				if (this.device_0 != null)
				{
					Texture texture = this.texture_0;
					Texture texture2 = ImageHelper.smethod_3(stream_1);
					this.texture_0 = texture2;
					if (texture != null)
					{
						texture.Dispose();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x000C1E80 File Offset: 0x000C0080
		public override void Dispose()
		{
			this.isInitialized = false;
			if (this.thread_0 != null)
			{
				if (this.thread_0.IsAlive)
				{
					this.thread_0.Abort();
				}
				this.thread_0 = null;
			}
			if (this.class1959_0 != null)
			{
				this.class1995_1.GetWorldSurfaceRenderer().method_6(this.class1959_0.method_5());
				this.class1959_0 = null;
			}
			if (this.texture_0 != null)
			{
				this.texture_0.Dispose();
				this.texture_0 = null;
			}
			if (this.timer_0 != null && this.timer_0.Enabled)
			{
				this.timer_0.Stop();
				this.timer_0 = null;
			}
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x000C1F40 File Offset: 0x000C0140
		private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (!this.bool_6)
			{
				this.bool_6 = true;
			}
			else if (this.string_2 == null && this.string_3 != null)
			{
				this.method_7(this.string_3);
			}
			else if (this.string_2 != null && this.string_2.ToLower().StartsWith("http://"))
			{
				this.string_3 = ImageLayer.smethod_0(this.string_2);
				this.method_4();
			}
		}

		// Token: 0x04000D65 RID: 3429
		protected double double_0;

		// Token: 0x04000D66 RID: 3430
		protected double double_1;

		// Token: 0x04000D67 RID: 3431
		protected double double_2 = 0.0;

		// Token: 0x04000D68 RID: 3432
		protected double double_3 = 0.0;

		// Token: 0x04000D69 RID: 3433
		protected double double_4 = 0.0;

		// Token: 0x04000D6A RID: 3434
		private World class1995_1;

		// Token: 0x04000D6B RID: 3435
		private Stream stream_0;

		// Token: 0x04000D6C RID: 3436
		protected bool bool_3;

		// Token: 0x04000D6D RID: 3437
		protected CustomVertex.PositionNormalTextured[] positionNormalTextured_0;

		// Token: 0x04000D6E RID: 3438
		protected static CustomVertex.TransformedColored[] transformedColored_0 = new CustomVertex.TransformedColored[5];

		// Token: 0x04000D6F RID: 3439
		protected static CustomVertex.TransformedColored[] transformedColored_1 = new CustomVertex.TransformedColored[4];

		// Token: 0x04000D70 RID: 3440
		protected short[] short_0;

		// Token: 0x04000D71 RID: 3441
		protected Texture texture_0;

		// Token: 0x04000D72 RID: 3442
		protected Device device_0;

		// Token: 0x04000D73 RID: 3443
		protected string string_2 = "";

		// Token: 0x04000D74 RID: 3444
		protected string string_3 = "";

		// Token: 0x04000D75 RID: 3445
		private int int_0 = 64;

		// Token: 0x04000D76 RID: 3446
		protected TerrainAccessor class1969_0;

		// Token: 0x04000D77 RID: 3447
		protected int int_1 = Color.FromArgb(100, 255, 255, 255).ToArgb();

		// Token: 0x04000D78 RID: 3448
		protected int int_2 = Color.SlateGray.ToArgb();

		// Token: 0x04000D79 RID: 3449
		protected int int_3 = Color.Black.ToArgb();

		// Token: 0x04000D7A RID: 3450
		protected float float_0;

		// Token: 0x04000D7B RID: 3451
		protected Thread thread_0;

		// Token: 0x04000D7C RID: 3452
		protected float float_1;

		// Token: 0x04000D7D RID: 3453
		private int int_4;

		// Token: 0x04000D7E RID: 3454
		private bool bool_4;

		// Token: 0x04000D7F RID: 3455
		private TimeSpan timeSpan_0 = TimeSpan.MaxValue;

		// Token: 0x04000D80 RID: 3456
		private System.Timers.Timer timer_0;

		// Token: 0x04000D81 RID: 3457
		private float float_2 = 0f;

		// Token: 0x04000D82 RID: 3458
		private bool bool_5;

		// Token: 0x04000D83 RID: 3459
		private Class1959 class1959_0;

		// Token: 0x04000D84 RID: 3460
		private static Effect effect_0 = null;

		// Token: 0x04000D85 RID: 3461
		private bool bool_6;

		// Token: 0x02000485 RID: 1157
		private sealed class Class1990
		{
			// Token: 0x06001E05 RID: 7685 RVA: 0x0001250C File Offset: 0x0001070C
			public static void smethod_0(double double_0, double double_1, double double_2, double double_3, int int_0, CustomVertex.PositionNormalTextured[] positionNormalTextured_0, short[] short_0)
			{
				ImageLayer.Class1990.list_0.Add(new ImageLayer.Class1990.Class1991(double_0, double_1, double_2, double_3, int_0, positionNormalTextured_0, short_0));
			}

			// Token: 0x06001E06 RID: 7686 RVA: 0x000C1FC0 File Offset: 0x000C01C0
			public static bool smethod_1(double double_0, double double_1, double double_2, double double_3, int int_0, ref CustomVertex.PositionNormalTextured[] positionNormalTextured_0, ref short[] short_0)
			{
				bool result = false;
				if (ImageLayer.Class1990.list_0 != null)
				{
					ImageLayer.Class1990.Class1991 class1991_ = new ImageLayer.Class1990.Class1991(double_0, double_1, double_2, double_3, int_0);
					foreach (ImageLayer.Class1990.Class1991 current in ImageLayer.Class1990.list_0)
					{
						if (current.method_2(class1991_))
						{
							result = true;
							positionNormalTextured_0 = current.method_0();
							short_0 = current.method_1();
						}
					}
				}
				return result;
			}

			// Token: 0x04000D86 RID: 3462
			private static List<ImageLayer.Class1990.Class1991> list_0 = new List<ImageLayer.Class1990.Class1991>();

			// Token: 0x02000486 RID: 1158
			private sealed class Class1991
			{
				// Token: 0x06001E09 RID: 7689 RVA: 0x000C2048 File Offset: 0x000C0248
				public CustomVertex.PositionNormalTextured[] method_0()
				{
					return this.positionNormalTextured_0;
				}

				// Token: 0x06001E0A RID: 7690 RVA: 0x000C2060 File Offset: 0x000C0260
				public short[] method_1()
				{
					return this.short_0;
				}

				// Token: 0x06001E0B RID: 7691 RVA: 0x000C2078 File Offset: 0x000C0278
				public Class1991(double double_4, double double_5, double double_6, double double_7, int int_1)
				{
					this.double_0 = double_4;
					this.double_2 = double_6;
					this.double_1 = double_5;
					this.double_3 = double_7;
					this.int_0 = int_1;
				}

				// Token: 0x06001E0C RID: 7692 RVA: 0x00012533 File Offset: 0x00010733
				public Class1991(double double_4, double double_5, double double_6, double double_7, int int_1, CustomVertex.PositionNormalTextured[] positionNormalTextured_1, short[] short_1) : this(double_4, double_5, double_6, double_7, int_1)
				{
					this.positionNormalTextured_0 = positionNormalTextured_1;
					this.short_0 = short_1;
				}

				// Token: 0x06001E0D RID: 7693 RVA: 0x000C20D0 File Offset: 0x000C02D0
				public bool method_2(ImageLayer.Class1990.Class1991 class1991_0)
				{
					return this.int_0 == class1991_0.int_0 && this.double_0 == class1991_0.double_0 && this.double_2 == class1991_0.double_2 && this.double_1 == class1991_0.double_1 && this.double_3 == class1991_0.double_3;
				}

				// Token: 0x04000D87 RID: 3463
				private double double_0;

				// Token: 0x04000D88 RID: 3464
				private double double_1;

				// Token: 0x04000D89 RID: 3465
				private double double_2 = 0.0;

				// Token: 0x04000D8A RID: 3466
				private double double_3 = 0.0;

				// Token: 0x04000D8B RID: 3467
				private int int_0;

				// Token: 0x04000D8C RID: 3468
				private CustomVertex.PositionNormalTextured[] positionNormalTextured_0;

				// Token: 0x04000D8D RID: 3469
				private short[] short_0;
			}
		}
	}
}
