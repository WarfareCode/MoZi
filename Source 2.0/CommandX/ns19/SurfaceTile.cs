using System;
using System.Drawing;
using System.Threading;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using ns17;
using ns18;

namespace ns19
{
	// Token: 0x020003C4 RID: 964
	public sealed class SurfaceTile : IDisposable
	{
		// Token: 0x060017D8 RID: 6104 RVA: 0x00093428 File Offset: 0x00091628
		public SurfaceTile(double double_4, double double_5, double double_6, double double_7, int int_3, WorldSurfaceRenderer class1967_1)
		{
			this.double_0 = double_4;
			this.double_1 = double_5;
			this.double_2 = double_6;
			this.double_3 = double_7;
			this.int_0 = int_3;
			this.m_ParentWorldSurfaceRenderer = class1967_1;
			float scalingFactor = 1.1f;
			Vector3 vector = MathEngine.SphericalToCartesian(Angle.FromDegrees(double_5), Angle.FromDegrees(double_6), this.m_ParentWorldSurfaceRenderer.method_3().GetEquatorialRadius() + this.m_ParentWorldSurfaceRenderer.method_1());
			Vector3 vector2 = new Vector3(vector.X, vector.Y, vector.Z);
			Vector3 vector3_ = Vector3.Scale(vector2, scalingFactor);
			vector = MathEngine.SphericalToCartesian(Angle.FromDegrees(double_5), Angle.FromDegrees(double_7), this.m_ParentWorldSurfaceRenderer.method_3().GetEquatorialRadius() + this.m_ParentWorldSurfaceRenderer.method_1());
			Vector3 vector3 = new Vector3(vector.X, vector.Y, vector.Z);
			Vector3 vector3_2 = Vector3.Scale(vector3, scalingFactor);
			vector = MathEngine.SphericalToCartesian(Angle.FromDegrees(double_4), Angle.FromDegrees(double_6), this.m_ParentWorldSurfaceRenderer.method_3().GetEquatorialRadius() + this.m_ParentWorldSurfaceRenderer.method_1());
			Vector3 vector4 = new Vector3(vector.X, vector.Y, vector.Z);
			Vector3 vector3_3 = Vector3.Scale(vector4, scalingFactor);
			vector = MathEngine.SphericalToCartesian(Angle.FromDegrees(double_4), Angle.FromDegrees(double_7), this.m_ParentWorldSurfaceRenderer.method_3().GetEquatorialRadius() + this.m_ParentWorldSurfaceRenderer.method_1());
			Vector3 vector5 = new Vector3(vector.X, vector.Y, vector.Z);
			Vector3 vector3_4 = Vector3.Scale(vector5, scalingFactor);
			this.m_BoundingBox = new BoundingBox(vector2, vector3_, vector3, vector3_2, vector4, vector3_3, vector5, vector3_4);
			int num = (int)(this.m_ParentWorldSurfaceRenderer.method_2() / 2u + 2u);
			this.m_IndicesElevated = new short[2 * num * num * 3];
			for (int i = 0; i < num; i++)
			{
				int num2 = 6 * i * num;
				for (int j = 0; j < num; j++)
				{
					this.m_IndicesElevated[num2] = (short)(i * (num + 1) + j);
					this.m_IndicesElevated[num2 + 1] = (short)((i + 1) * (num + 1) + j);
					this.m_IndicesElevated[num2 + 2] = (short)(i * (num + 1) + j + 1);
					this.m_IndicesElevated[num2 + 3] = (short)(i * (num + 1) + j + 1);
					this.m_IndicesElevated[num2 + 4] = (short)((i + 1) * (num + 1) + j);
					this.m_IndicesElevated[num2 + 5] = (short)((i + 1) * (num + 1) + j + 1);
					num2 += 6;
				}
			}
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x0009370C File Offset: 0x0009190C
		public Texture method_0()
		{
			return this.texture_0;
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00093724 File Offset: 0x00091924
		private void method_1(object sender, EventArgs e)
		{
			Device device = (Device)sender;
			this.device_0 = device;
			this.texture_0 = new Texture(device, 256, 256, 1, Usage.RenderTarget, Format.X8R8G8B8, Pool.Default);
			this.bool_1 = true;
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x0000FEF2 File Offset: 0x0000E0F2
		private void method_2(object sender, EventArgs e)
		{
			if (this.texture_0 != null && !this.texture_0.Disposed)
			{
				this.texture_0.Dispose();
			}
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00093764 File Offset: 0x00091964
		public void method_3(DrawArgs class1943_0)
		{
			try
			{
				if (this.m_HeightData == null)
				{
					if (this.int_0 > 2)
					{
						Class1972 @class = this.m_ParentWorldSurfaceRenderer.method_3().GetTerrainAccessor().vmethod_2(this.double_0, this.double_1, this.double_2, this.double_3, (int)(this.m_ParentWorldSurfaceRenderer.method_2() + 1u));
						if (@class.float_0 != null)
						{
							this.m_HeightData = @class.float_0;
						}
						else
						{
							this.m_HeightData = new float[(int)(this.m_ParentWorldSurfaceRenderer.method_2() + 1u), (int)(this.m_ParentWorldSurfaceRenderer.method_2() + 1u)];
						}
					}
					else
					{
						this.m_HeightData = new float[(int)(this.m_ParentWorldSurfaceRenderer.method_2() + 1u), (int)(this.m_ParentWorldSurfaceRenderer.method_2() + 1u)];
					}
				}
				if (this.m_DynamicTexture == null)
				{
					this.m_DynamicTexture = new DynamicTexture();
					this.method_6();
				}
			}
			catch (Exception exception_)
			{
				Log.smethod_3(exception_);
			}
			this.bool_0 = true;
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00093874 File Offset: 0x00091A74
		public void method_4(DrawArgs class1943_0)
		{
			if (this.texture_0 == null)
			{
				class1943_0.device_0.DeviceReset += new EventHandler(this.method_1);
				this.method_1(class1943_0.device_0, null);
			}
			Viewport viewport = new Viewport();
			viewport.Width = 256;
			viewport.Height = 256;
			if (class1943_0.bool_2)
			{
				class1943_0.device_0.RenderState.FillMode = FillMode.Solid;
			}
			using (Surface surfaceLevel = this.texture_0.GetSurfaceLevel(0))
			{
				this.m_ParentWorldSurfaceRenderer.method_4().BeginScene(surfaceLevel, viewport);
				class1943_0.device_0.Clear(ClearFlags.Target | ClearFlags.ZBuffer, Color.Black, 1f, 0);
				class1943_0.device_0.VertexFormat = (VertexFormats.Texture1 | VertexFormats.Diffuse | VertexFormats.Transformed);
				class1943_0.device_0.RenderState.ZBufferEnable = false;
				object syncRoot = this.m_ParentWorldSurfaceRenderer.method_0().SyncRoot;
				lock (syncRoot)
				{
					for (int i = 0; i < this.m_ParentWorldSurfaceRenderer.method_0().Count; i++)
					{
						Class1959 @class = this.m_ParentWorldSurfaceRenderer.method_0()[i] as Class1959;
						if (@class != null && !(@class.method_7() == null) && !@class.method_7().Disposed && @class.method_0() && (@class.method_1() <= this.double_0 || @class.method_2() < this.double_0) && (@class.method_1() > this.double_1 || @class.method_2() >= this.double_1) && (@class.method_3() >= this.double_2 || @class.method_4() > this.double_2) && (@class.method_3() < this.double_3 || @class.method_4() <= this.double_3))
						{
							@class.byte_0 = @class.method_6().GetOpacity();
							Vector2 vector = @class.method_9(this.double_0, this.double_2);
							this.m_RenderToTextureVertices[0].X = 0f;
							this.m_RenderToTextureVertices[0].Y = 0f;
							this.m_RenderToTextureVertices[0].Z = 0f;
							this.m_RenderToTextureVertices[0].Tu = vector.Y;
							this.m_RenderToTextureVertices[0].Tv = vector.X;
							this.m_RenderToTextureVertices[0].Color = Color.FromArgb((int)@class.method_6().GetOpacity(), 0, 0, 0).ToArgb();
							vector = @class.method_9(this.double_1, this.double_2);
							this.m_RenderToTextureVertices[1].X = 0f;
							this.m_RenderToTextureVertices[1].Y = 256f;
							this.m_RenderToTextureVertices[1].Z = 0f;
							this.m_RenderToTextureVertices[1].Tu = vector.Y;
							this.m_RenderToTextureVertices[1].Tv = vector.X;
							this.m_RenderToTextureVertices[1].Color = Color.FromArgb((int)@class.method_6().GetOpacity(), 0, 0, 0).ToArgb();
							vector = @class.method_9(this.double_0, this.double_3);
							this.m_RenderToTextureVertices[2].X = 256f;
							this.m_RenderToTextureVertices[2].Y = 0f;
							this.m_RenderToTextureVertices[2].Z = 0f;
							this.m_RenderToTextureVertices[2].Tu = vector.Y;
							this.m_RenderToTextureVertices[2].Tv = vector.X;
							this.m_RenderToTextureVertices[2].Color = Color.FromArgb((int)@class.method_6().GetOpacity(), 0, 0, 0).ToArgb();
							vector = @class.method_9(this.double_1, this.double_3);
							this.m_RenderToTextureVertices[3].X = 256f;
							this.m_RenderToTextureVertices[3].Y = 256f;
							this.m_RenderToTextureVertices[3].Z = 0f;
							this.m_RenderToTextureVertices[3].Tu = vector.Y;
							this.m_RenderToTextureVertices[3].Tv = vector.X;
							this.m_RenderToTextureVertices[3].Color = Color.FromArgb((int)@class.method_6().GetOpacity(), 0, 0, 0).ToArgb();
							class1943_0.device_0.RenderState.AlphaBlendEnable = true;
							class1943_0.device_0.RenderState.SourceBlend = Blend.SourceAlpha;
							class1943_0.device_0.RenderState.DestinationBlend = Blend.InvSourceAlpha;
							class1943_0.device_0.SamplerState[0].BorderColor = Color.FromArgb(0, 0, 0, 0);
							class1943_0.device_0.SamplerState[1].BorderColor = Color.FromArgb(0, 0, 0, 0);
							class1943_0.device_0.SetTexture(0, @class.method_7());
							class1943_0.device_0.SetTexture(1, @class.method_7());
							class1943_0.device_0.TextureState[1].TextureCoordinateIndex = 0;
							class1943_0.device_0.SamplerState[0].MinFilter = TextureFilter.Linear;
							class1943_0.device_0.SamplerState[0].MagFilter = TextureFilter.Linear;
							class1943_0.device_0.SamplerState[0].AddressU = TextureAddress.Clamp;
							class1943_0.device_0.SamplerState[0].AddressV = TextureAddress.Clamp;
							class1943_0.device_0.SamplerState[1].MinFilter = TextureFilter.Point;
							class1943_0.device_0.SamplerState[1].MagFilter = TextureFilter.Point;
							class1943_0.device_0.SamplerState[1].AddressU = TextureAddress.Border;
							class1943_0.device_0.SamplerState[1].AddressV = TextureAddress.Border;
							class1943_0.device_0.TextureState[0].ColorOperation = TextureOperation.SelectArg1;
							class1943_0.device_0.TextureState[0].ColorArgument1 = TextureArgument.TextureColor;
							class1943_0.device_0.TextureState[0].ColorArgument2 = TextureArgument.Diffuse;
							class1943_0.device_0.TextureState[0].AlphaOperation = TextureOperation.Modulate;
							class1943_0.device_0.TextureState[0].AlphaArgument1 = TextureArgument.Diffuse;
							class1943_0.device_0.TextureState[0].AlphaArgument2 = TextureArgument.TextureColor;
							class1943_0.device_0.TextureState[1].ColorOperation = TextureOperation.SelectArg1;
							class1943_0.device_0.TextureState[1].ColorArgument1 = TextureArgument.Current;
							class1943_0.device_0.TextureState[1].AlphaOperation = TextureOperation.Modulate;
							class1943_0.device_0.TextureState[1].AlphaArgument1 = TextureArgument.TextureColor;
							class1943_0.device_0.TextureState[1].AlphaArgument2 = TextureArgument.Diffuse;
							class1943_0.device_0.TextureState[2].ColorOperation = TextureOperation.Disable;
							class1943_0.device_0.TextureState[2].AlphaOperation = TextureOperation.Disable;
							class1943_0.device_0.DrawUserPrimitives(PrimitiveType.TriangleStrip, 2, this.m_RenderToTextureVertices);
							class1943_0.device_0.SetTexture(0, null);
							class1943_0.device_0.SetTexture(1, null);
							class1943_0.device_0.SetTextureStageState(1, TextureStageStates.TextureCoordinateIndex, 1);
						}
					}
					this.m_ParentWorldSurfaceRenderer.method_4().EndScene(Filter.Box);
					class1943_0.device_0.RenderState.ZBufferEnable = true;
				}
			}
			if (class1943_0.bool_2)
			{
				class1943_0.device_0.RenderState.FillMode = FillMode.WireFrame;
			}
			this.m_LastUpdate = DateTime.Now;
			this.bool_1 = false;
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x000940B4 File Offset: 0x000922B4
		private void method_5(DrawArgs class1943_0)
		{
			if (this.m_NorthWestChild == null)
			{
				SurfaceTile surfaceTile = new SurfaceTile(this.double_0, 0.5 * (this.double_1 + this.double_0), this.double_2, 0.5 * (this.double_2 + this.double_3), this.int_0 + 1, this.m_ParentWorldSurfaceRenderer);
				surfaceTile.method_3(class1943_0);
				this.m_NorthWestChild = surfaceTile;
			}
			if (this.m_NorthEastChild == null)
			{
				SurfaceTile surfaceTile2 = new SurfaceTile(this.double_0, 0.5 * (this.double_1 + this.double_0), 0.5 * (this.double_2 + this.double_3), this.double_3, this.int_0 + 1, this.m_ParentWorldSurfaceRenderer);
				surfaceTile2.method_3(class1943_0);
				this.m_NorthEastChild = surfaceTile2;
			}
			if (this.m_SouthWestChild == null)
			{
				SurfaceTile surfaceTile3 = new SurfaceTile(0.5 * (this.double_1 + this.double_0), this.double_1, this.double_2, 0.5 * (this.double_2 + this.double_3), this.int_0 + 1, this.m_ParentWorldSurfaceRenderer);
				surfaceTile3.method_3(class1943_0);
				this.m_SouthWestChild = surfaceTile3;
			}
			if (this.m_SouthEastChild == null)
			{
				SurfaceTile surfaceTile4 = new SurfaceTile(0.5 * (this.double_1 + this.double_0), this.double_1, 0.5 * (this.double_2 + this.double_3), this.double_3, this.int_0 + 1, this.m_ParentWorldSurfaceRenderer);
				surfaceTile4.method_3(class1943_0);
				this.m_SouthEastChild = surfaceTile4;
			}
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x0009426C File Offset: 0x0009246C
		private void method_6()
		{
			int num = (int)(this.m_ParentWorldSurfaceRenderer.method_2() / 2u + 3u);
			double num2 = (double)(1f / this.m_ParentWorldSurfaceRenderer.method_2());
			double num3 = (double)((float)Math.Abs(this.double_0 - this.double_1));
			double num4 = (double)((float)Math.Abs(this.double_3 - this.double_2));
			this.m_DynamicTexture.nwVerts = new CustomVertex.PositionNormalTextured[num * num];
			this.m_DynamicTexture.neVerts = new CustomVertex.PositionNormalTextured[num * num];
			this.m_DynamicTexture.swVerts = new CustomVertex.PositionNormalTextured[num * num];
			this.m_DynamicTexture.seVerts = new CustomVertex.PositionNormalTextured[num * num];
			for (int i = 0; i < num; i++)
			{
				int num5 = i * num;
				for (int j = 0; j < num; j++)
				{
					float num6 = -30000f;
					if (i == 0 || j == 0 || i == num - 1 || j == num - 1)
					{
						double degrees;
						float tu;
						if (j == 0)
						{
							degrees = this.double_2;
							tu = 0f;
						}
						else if (j == num - 1)
						{
							degrees = 0.5 * (this.double_2 + this.double_3);
							tu = 0.5f;
						}
						else
						{
							degrees = this.double_2 + (double)((float)num2) * num4 * (double)(j - 1);
							tu = (float)(num2 * (double)(j - 1));
						}
						double degrees2;
						float tv;
						if (i == 0)
						{
							degrees2 = this.double_0;
							tv = 0f;
						}
						else if (i == num - 1)
						{
							degrees2 = 0.5 * (this.double_0 + this.double_1);
							tv = 0.5f;
						}
						else
						{
							degrees2 = this.double_0 - num2 * num3 * (double)(i - 1);
							tv = (float)(num2 * (double)(i - 1));
						}
						Vector3 vector = MathEngine.SphericalToCartesian(Angle.FromDegrees(degrees2), Angle.FromDegrees(degrees), this.m_ParentWorldSurfaceRenderer.method_3().GetEquatorialRadius() + this.m_ParentWorldSurfaceRenderer.method_1() + (double)num6);
						this.m_DynamicTexture.nwVerts[num5].X = vector.X;
						this.m_DynamicTexture.nwVerts[num5].Y = vector.Y;
						this.m_DynamicTexture.nwVerts[num5].Z = vector.Z;
						this.m_DynamicTexture.nwVerts[num5].Tu = tu;
						this.m_DynamicTexture.nwVerts[num5].Tv = tv;
					}
					else
					{
						num6 = this.m_HeightData[i - 1, j - 1];
						num6 *= World.Settings.GetVerticalExaggeration();
						Vector3 vector2 = MathEngine.SphericalToCartesian(Angle.FromDegrees(this.double_0 - num2 * num3 * (double)(i - 1)), Angle.FromDegrees(this.double_2 + num2 * num4 * (double)(j - 1)), this.m_ParentWorldSurfaceRenderer.method_3().GetEquatorialRadius() + this.m_ParentWorldSurfaceRenderer.method_1() + (double)num6);
						this.m_DynamicTexture.nwVerts[num5].X = vector2.X;
						this.m_DynamicTexture.nwVerts[num5].Y = vector2.Y;
						this.m_DynamicTexture.nwVerts[num5].Z = vector2.Z;
						this.m_DynamicTexture.nwVerts[num5].Tu = (float)(num2 * (double)(j - 1));
						this.m_DynamicTexture.nwVerts[num5].Tv = (float)(num2 * (double)(i - 1));
					}
					num5++;
				}
			}
			for (int k = 0; k < num; k++)
			{
				int num5 = k * num;
				for (int l = 0; l < num; l++)
				{
					float num7 = -30000f;
					if (k == 0 || l == 0 || k == num - 1 || l == num - 1)
					{
						double degrees3;
						float tu2;
						if (l == 0)
						{
							degrees3 = 0.5 * (this.double_2 + this.double_3);
							tu2 = 0.5f;
						}
						else if (l == num - 1)
						{
							degrees3 = this.double_3;
							tu2 = 1f;
						}
						else
						{
							degrees3 = 0.5 * (this.double_2 + this.double_3) + (double)((float)num2) * num4 * (double)(l - 1);
							tu2 = (float)(0.5 + num2 * (double)(l - 1));
						}
						double degrees4;
						float tv2;
						if (k == 0)
						{
							degrees4 = this.double_0;
							tv2 = 0f;
						}
						else if (k == num - 1)
						{
							degrees4 = 0.5 * (this.double_0 + this.double_1);
							tv2 = 0.5f;
						}
						else
						{
							degrees4 = this.double_0 - num2 * num3 * (double)(k - 1);
							tv2 = (float)(num2 * (double)(k - 1));
						}
						Vector3 vector3 = MathEngine.SphericalToCartesian(Angle.FromDegrees(degrees4), Angle.FromDegrees(degrees3), this.m_ParentWorldSurfaceRenderer.method_3().GetEquatorialRadius() + this.m_ParentWorldSurfaceRenderer.method_1() + (double)num7);
						this.m_DynamicTexture.neVerts[num5].X = vector3.X;
						this.m_DynamicTexture.neVerts[num5].Y = vector3.Y;
						this.m_DynamicTexture.neVerts[num5].Z = vector3.Z;
						this.m_DynamicTexture.neVerts[num5].Tu = tu2;
						this.m_DynamicTexture.neVerts[num5].Tv = tv2;
					}
					else
					{
						num7 = this.m_HeightData[k - 1, (int)((IntPtr)((long)(l - 1) + (long)((ulong)(this.m_ParentWorldSurfaceRenderer.method_2() / 2u))))];
						num7 *= World.Settings.GetVerticalExaggeration();
						Vector3 vector4 = MathEngine.SphericalToCartesian(Angle.FromDegrees(this.double_0 - num2 * num3 * (double)(k - 1)), Angle.FromDegrees(0.5 * (this.double_2 + this.double_3) + (double)((float)num2) * num4 * (double)(l - 1)), this.m_ParentWorldSurfaceRenderer.method_3().GetEquatorialRadius() + this.m_ParentWorldSurfaceRenderer.method_1() + (double)num7);
						this.m_DynamicTexture.neVerts[num5].X = vector4.X;
						this.m_DynamicTexture.neVerts[num5].Y = vector4.Y;
						this.m_DynamicTexture.neVerts[num5].Z = vector4.Z;
						this.m_DynamicTexture.neVerts[num5].Tu = (float)(0.5 + num2 * (double)(l - 1));
						this.m_DynamicTexture.neVerts[num5].Tv = (float)(num2 * (double)(k - 1));
					}
					num5++;
				}
			}
			for (int m = 0; m < num; m++)
			{
				int num5 = m * num;
				for (int n = 0; n < num; n++)
				{
					float num8 = -30000f;
					if (m == 0 || n == 0 || m == num - 1 || n == num - 1)
					{
						double degrees5;
						float tu3;
						if (n == 0)
						{
							degrees5 = this.double_2;
							tu3 = 0f;
						}
						else if (n == num - 1)
						{
							degrees5 = 0.5 * (this.double_2 + this.double_3);
							tu3 = 0.5f;
						}
						else
						{
							degrees5 = this.double_2 + (double)((float)num2) * num4 * (double)(n - 1);
							tu3 = (float)(num2 * (double)(n - 1));
						}
						double degrees6;
						float tv3;
						if (m == 0)
						{
							degrees6 = 0.5 * (this.double_0 + this.double_1);
							tv3 = 0.5f;
						}
						else if (m == num - 1)
						{
							degrees6 = this.double_1;
							tv3 = 1f;
						}
						else
						{
							degrees6 = 0.5 * (this.double_0 + this.double_1) - num2 * num3 * (double)(m - 1);
							tv3 = (float)(0.5 * num2 * (double)(m - 1));
						}
						Vector3 vector5 = MathEngine.SphericalToCartesian(Angle.FromDegrees(degrees6), Angle.FromDegrees(degrees5), this.m_ParentWorldSurfaceRenderer.method_3().GetEquatorialRadius() + this.m_ParentWorldSurfaceRenderer.method_1() + (double)num8);
						this.m_DynamicTexture.swVerts[num5].X = vector5.X;
						this.m_DynamicTexture.swVerts[num5].Y = vector5.Y;
						this.m_DynamicTexture.swVerts[num5].Z = vector5.Z;
						this.m_DynamicTexture.swVerts[num5].Tu = tu3;
						this.m_DynamicTexture.swVerts[num5].Tv = tv3;
					}
					else
					{
						num8 = this.m_HeightData[(int)((IntPtr)(checked((long)(unchecked((ulong)(this.m_ParentWorldSurfaceRenderer.method_2() / 2u) + (ulong)((long)(m - 1))))))), n - 1];
						num8 *= World.Settings.GetVerticalExaggeration();
						Vector3 vector6 = MathEngine.SphericalToCartesian(Angle.FromDegrees(0.5 * (this.double_0 + this.double_1) - num2 * num3 * (double)(m - 1)), Angle.FromDegrees(this.double_2 + (double)((float)num2) * num4 * (double)(n - 1)), this.m_ParentWorldSurfaceRenderer.method_3().GetEquatorialRadius() + this.m_ParentWorldSurfaceRenderer.method_1() + (double)num8);
						this.m_DynamicTexture.swVerts[num5].X = vector6.X;
						this.m_DynamicTexture.swVerts[num5].Y = vector6.Y;
						this.m_DynamicTexture.swVerts[num5].Z = vector6.Z;
						this.m_DynamicTexture.swVerts[num5].Tu = (float)(num2 * (double)(n - 1));
						this.m_DynamicTexture.swVerts[num5].Tv = (float)(0.5 + num2 * (double)(m - 1));
					}
					num5++;
				}
			}
			for (int num9 = 0; num9 < num; num9++)
			{
				int num5 = num9 * num;
				for (int num10 = 0; num10 < num; num10++)
				{
					float num11 = -30000f;
					if (num9 == 0 || num10 == 0 || num9 == num - 1 || num10 == num - 1)
					{
						double degrees7;
						float tu4;
						if (num10 == 0)
						{
							degrees7 = 0.5 * (this.double_2 + this.double_3);
							tu4 = 0.5f;
						}
						else if (num10 == num - 1)
						{
							degrees7 = this.double_3;
							tu4 = 1f;
						}
						else
						{
							degrees7 = 0.5 * (this.double_2 + this.double_3) + (double)((float)num2) * num4 * (double)(num10 - 1);
							tu4 = (float)(0.5 + num2 * (double)(num10 - 1));
						}
						double degrees8;
						float tv4;
						if (num9 == 0)
						{
							degrees8 = 0.5 * (this.double_0 + this.double_1);
							tv4 = 0.5f;
						}
						else if (num9 == num - 1)
						{
							degrees8 = this.double_1;
							tv4 = 1f;
						}
						else
						{
							degrees8 = 0.5 * (this.double_0 + this.double_1) - num2 * num3 * (double)(num9 - 1);
							tv4 = (float)(0.5 + num2 * (double)(num9 - 1));
						}
						Vector3 vector7 = MathEngine.SphericalToCartesian(Angle.FromDegrees(degrees8), Angle.FromDegrees(degrees7), this.m_ParentWorldSurfaceRenderer.method_3().GetEquatorialRadius() + this.m_ParentWorldSurfaceRenderer.method_1() + (double)num11);
						this.m_DynamicTexture.seVerts[num5].X = vector7.X;
						this.m_DynamicTexture.seVerts[num5].Y = vector7.Y;
						this.m_DynamicTexture.seVerts[num5].Z = vector7.Z;
						this.m_DynamicTexture.seVerts[num5].Tu = tu4;
						this.m_DynamicTexture.seVerts[num5].Tv = tv4;
					}
					else
					{
						num11 = this.m_HeightData[(int)((IntPtr)(checked((long)(unchecked((ulong)(this.m_ParentWorldSurfaceRenderer.method_2() / 2u) + (ulong)((long)(num9 - 1))))))), (int)((IntPtr)((long)(num10 - 1) + (long)((ulong)(this.m_ParentWorldSurfaceRenderer.method_2() / 2u))))];
						num11 *= World.Settings.GetVerticalExaggeration();
						Vector3 vector8 = MathEngine.SphericalToCartesian(Angle.FromDegrees(0.5 * (this.double_0 + this.double_1) - num2 * num3 * (double)(num9 - 1)), Angle.FromDegrees(0.5 * (this.double_2 + this.double_3) + (double)((float)num2) * num4 * (double)(num10 - 1)), this.m_ParentWorldSurfaceRenderer.method_3().GetEquatorialRadius() + this.m_ParentWorldSurfaceRenderer.method_1() + (double)num11);
						this.m_DynamicTexture.seVerts[num5].X = vector8.X;
						this.m_DynamicTexture.seVerts[num5].Y = vector8.Y;
						this.m_DynamicTexture.seVerts[num5].Z = vector8.Z;
						this.m_DynamicTexture.seVerts[num5].Tu = (float)(0.5 + num2 * (double)(num10 - 1));
						this.m_DynamicTexture.seVerts[num5].Tv = (float)(0.5 + num2 * (double)(num9 - 1));
					}
					num5++;
				}
			}
			this.m_ParentWorldSurfaceRenderer.method_3().GetEquatorialRadius();
			try
			{
				if (this.float_1 != World.Settings.GetVerticalExaggeration())
				{
					this.float_1 = World.Settings.GetVerticalExaggeration();
				}
			}
			catch (Exception exception_)
			{
				Log.smethod_3(exception_);
			}
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00095110 File Offset: 0x00093310
		public void method_7(DrawArgs class1943_0)
		{
			try
			{
				if (!this.bool_0)
				{
					this.method_3(class1943_0);
				}
				float arg_23_0 = 1f / this.m_ParentWorldSurfaceRenderer.method_2();
				Math.Abs(this.double_0 - this.double_1);
				Math.Abs(this.double_3 - this.double_2);
				uint arg_57_0 = this.m_ParentWorldSurfaceRenderer.method_2() / 2u;
				float arg_6B_0 = 1f / this.m_ParentWorldSurfaceRenderer.method_2();
				Math.Abs(this.double_0 - this.double_1);
				Math.Abs(this.double_3 - this.double_2);
				double degrees = 0.5 * (this.double_0 + this.double_1);
				double degrees2 = 0.5 * (this.double_3 + this.double_2);
				double num = this.double_0 - this.double_1;
				World.Settings.GetVerticalExaggeration();
				if (Angle.IsLittleThan(class1943_0.GetWorldCamera().GetTrueViewRange(), Angle.FromDegrees(3.0 * num)) && Angle.IsLittleThan(MathEngine.SphericalDistance(Angle.FromDegrees(degrees), Angle.FromDegrees(degrees2), class1943_0.GetWorldCamera().GetLatitude(), class1943_0.GetWorldCamera().GetLongitude()), Angle.FromDegrees(2.9000000953674316 * num)) && class1943_0.GetWorldCamera().GetViewFrustum().Contains(this.m_BoundingBox))
				{
					if (this.m_NorthWestChild != null && this.m_NorthEastChild != null && this.m_SouthWestChild != null && this.m_SouthEastChild != null)
					{
						if (this.m_NorthEastChild != null)
						{
							this.m_NorthEastChild.method_7(class1943_0);
						}
						if (this.m_NorthWestChild != null)
						{
							this.m_NorthWestChild.method_7(class1943_0);
						}
						if (this.m_SouthEastChild != null)
						{
							this.m_SouthEastChild.method_7(class1943_0);
						}
						if (this.m_SouthWestChild != null)
						{
							this.m_SouthWestChild.method_7(class1943_0);
						}
					}
					else
					{
						this.method_5(class1943_0);
					}
				}
				else
				{
					if (this.m_NorthWestChild != null)
					{
						this.m_NorthWestChild.Dispose();
						this.m_NorthWestChild = null;
					}
					if (this.m_NorthEastChild != null)
					{
						this.m_NorthEastChild.Dispose();
						this.m_NorthEastChild = null;
					}
					if (this.m_SouthEastChild != null)
					{
						this.m_SouthEastChild.Dispose();
						this.m_SouthEastChild = null;
					}
					if (this.m_SouthWestChild != null)
					{
						this.m_SouthWestChild.Dispose();
						this.m_SouthWestChild = null;
					}
				}
			}
			catch (ThreadAbortException)
			{
			}
			catch (Exception exception_)
			{
				Log.smethod_3(exception_);
			}
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x000953C0 File Offset: 0x000935C0
		public void Dispose()
		{
			this.bool_0 = false;
			this.m_BoundingBox = null;
			if (this.device_0 != null)
			{
				this.device_0.DeviceReset -= new EventHandler(this.method_1);
				this.device_0.Disposing -= new EventHandler(this.method_2);
				this.method_2(this.device_0, null);
			}
			if (this.m_NorthWestChild != null)
			{
				this.m_NorthWestChild.Dispose();
				this.m_NorthWestChild = null;
			}
			if (this.m_NorthEastChild != null)
			{
				this.m_NorthEastChild.Dispose();
				this.m_NorthEastChild = null;
			}
			if (this.m_SouthWestChild != null)
			{
				this.m_SouthWestChild.Dispose();
				this.m_SouthWestChild = null;
			}
			if (this.m_SouthEastChild != null)
			{
				this.m_SouthEastChild.Dispose();
				this.m_SouthEastChild = null;
			}
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0009549C File Offset: 0x0009369C
		public bool method_8(DrawArgs class1943_0)
		{
			double degrees = 0.5 * (this.double_0 + this.double_1);
			double degrees2 = 0.5 * (this.double_3 + this.double_2);
			double num = this.double_0 - this.double_1;
			return this.bool_0 && !Angle.IsLargerThan(Angle.Divide(class1943_0.GetWorldCamera().GetTrueViewRange(), 2.0), Angle.FromDegrees(3.0 * num * 1.5)) && !Angle.IsLargerThan(MathEngine.SphericalDistance(Angle.FromDegrees(degrees), Angle.FromDegrees(degrees2), class1943_0.GetWorldCamera().GetLatitude(), class1943_0.GetWorldCamera().GetLongitude()), Angle.FromDegrees(3.0 * num * 1.5)) && this.m_BoundingBox != null && class1943_0.GetWorldCamera().GetViewFrustum().Contains(this.m_BoundingBox) && this.m_DynamicTexture != null;
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x000955A4 File Offset: 0x000937A4
		private bool method_9()
		{
			bool result;
			if (this.m_ParentWorldSurfaceRenderer.dateTime_0 > this.m_LastUpdate)
			{
				result = true;
			}
			else
			{
				object syncRoot = this.m_ParentWorldSurfaceRenderer.method_0().SyncRoot;
				lock (syncRoot)
				{
					for (int i = 0; i < this.m_ParentWorldSurfaceRenderer.method_0().Count; i++)
					{
						Class1959 @class = this.m_ParentWorldSurfaceRenderer.method_0()[i] as Class1959;
						if ((@class.dateTime_0 > this.m_LastUpdate || @class.byte_0 != @class.method_6().GetOpacity()) && @class != null && !(@class.method_7() == null) && !@class.method_7().Disposed && @class.method_0() && (@class.method_1() <= this.double_0 || @class.method_2() < this.double_0) && (@class.method_1() > this.double_1 || @class.method_2() >= this.double_1) && (@class.method_3() >= this.double_2 || @class.method_4() > this.double_2) && (@class.method_3() < this.double_3 || @class.method_4() <= this.double_3))
						{
							result = true;
							return result;
						}
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00095744 File Offset: 0x00093944
		public void method_10(DrawArgs class1943_0)
		{
			try
			{
				if (this.method_8(class1943_0) || !(this.texture_0 != null))
				{
					bool flag = false;
					bool flag2 = false;
					bool flag3 = false;
					bool flag4 = false;
					if (this.m_NorthWestChild != null && this.m_NorthWestChild.bool_0 && this.m_NorthWestChild.method_8(class1943_0) && (this.m_NorthWestChild.method_0() != null || (this.m_NorthWestChild.method_0() == null && this.m_ParentWorldSurfaceRenderer.int_0 < 2)))
					{
						this.m_NorthWestChild.method_10(class1943_0);
						flag = true;
					}
					if (this.m_NorthEastChild != null && this.m_NorthEastChild.bool_0 && this.m_NorthEastChild.method_8(class1943_0) && (this.m_NorthEastChild.method_0() != null || (this.m_NorthEastChild.method_0() == null && this.m_ParentWorldSurfaceRenderer.int_0 < 2)))
					{
						this.m_NorthEastChild.method_10(class1943_0);
						flag2 = true;
					}
					if (this.m_SouthWestChild != null && this.m_SouthWestChild.bool_0 && this.m_SouthWestChild.method_8(class1943_0) && (this.m_SouthWestChild.method_0() != null || (this.m_SouthWestChild.method_0() == null && this.m_ParentWorldSurfaceRenderer.int_0 < 2)))
					{
						this.m_SouthWestChild.method_10(class1943_0);
						flag3 = true;
					}
					if (this.m_SouthEastChild != null && this.m_SouthEastChild.bool_0 && this.m_SouthEastChild.method_8(class1943_0) && (this.m_SouthEastChild.method_0() != null || (this.m_SouthEastChild.method_0() == null && this.m_ParentWorldSurfaceRenderer.int_0 < 2)))
					{
						this.m_SouthEastChild.method_10(class1943_0);
						flag4 = true;
					}
					if (!(flag & flag2 & flag3 & flag4))
					{
						if (!(this.texture_0 == null) && !this.bool_1 && !this.method_9())
						{
							int framesSinceLastUpdate = this.m_FramesSinceLastUpdate;
							this.m_FramesSinceLastUpdate = framesSinceLastUpdate + 1;
							if (framesSinceLastUpdate <= SurfaceTile.SurfaceTileRefreshHz)
							{
								goto IL_273;
							}
						}
						class1943_0.device_0.EndScene();
						this.method_4(class1943_0);
						class1943_0.device_0.BeginScene();
						this.m_FramesSinceLastUpdate = 0;
						this.m_ParentWorldSurfaceRenderer.int_0++;
						IL_273:
						if (!(this.texture_0 == null))
						{
							class1943_0.device_0.VertexFormat = (VertexFormats.PositionNormal | VertexFormats.Texture1);
							class1943_0.device_0.TextureState[0].AlphaOperation = TextureOperation.SelectArg1;
							class1943_0.device_0.TextureState[0].AlphaArgument1 = TextureArgument.TextureColor;
							class1943_0.device_0.TextureState[0].ColorOperation = TextureOperation.SelectArg1;
							class1943_0.device_0.TextureState[1].ColorOperation = TextureOperation.Disable;
							class1943_0.device_0.TextureState[1].AlphaOperation = TextureOperation.Disable;
							class1943_0.device_0.RenderState.ZBufferEnable = true;
							class1943_0.device_0.SetTexture(0, this.texture_0);
							class1943_0.device_0.SamplerState[0].MinFilter = TextureFilter.Linear;
							class1943_0.device_0.SamplerState[0].MagFilter = TextureFilter.Linear;
							class1943_0.device_0.SamplerState[0].AddressU = TextureAddress.Clamp;
							class1943_0.device_0.SamplerState[0].AddressV = TextureAddress.Clamp;
							if (!flag && this.m_DynamicTexture.nwVerts != null)
							{
								class1943_0.device_0.DrawIndexedUserPrimitives(PrimitiveType.TriangleList, 0, this.m_DynamicTexture.nwVerts.Length, (this.m_NwIndices != null) ? (this.m_NwIndices.Length / 3) : (this.m_IndicesElevated.Length / 3), (this.m_NwIndices != null) ? this.m_NwIndices : this.m_IndicesElevated, true, this.m_DynamicTexture.nwVerts);
							}
							if (!flag2 && this.m_DynamicTexture.neVerts != null)
							{
								class1943_0.device_0.DrawIndexedUserPrimitives(PrimitiveType.TriangleList, 0, this.m_DynamicTexture.neVerts.Length, (this.m_NeIndices != null) ? (this.m_NeIndices.Length / 3) : (this.m_IndicesElevated.Length / 3), (this.m_NeIndices != null) ? this.m_NeIndices : this.m_IndicesElevated, true, this.m_DynamicTexture.neVerts);
							}
							if (!flag3 && this.m_DynamicTexture.swVerts != null)
							{
								class1943_0.device_0.DrawIndexedUserPrimitives(PrimitiveType.TriangleList, 0, this.m_DynamicTexture.nwVerts.Length, (this.m_SwIndices != null) ? (this.m_SwIndices.Length / 3) : (this.m_IndicesElevated.Length / 3), (this.m_SwIndices != null) ? this.m_SwIndices : this.m_IndicesElevated, true, this.m_DynamicTexture.swVerts);
							}
							if (!flag4 && this.m_DynamicTexture.seVerts != null)
							{
								class1943_0.device_0.DrawIndexedUserPrimitives(PrimitiveType.TriangleList, 0, this.m_DynamicTexture.seVerts.Length, (this.m_SeIndices != null) ? (this.m_SeIndices.Length / 3) : (this.m_IndicesElevated.Length / 3), (this.m_SeIndices != null) ? this.m_SeIndices : this.m_IndicesElevated, true, this.m_DynamicTexture.seVerts);
							}
						}
					}
				}
			}
			catch (ThreadAbortException)
			{
			}
			catch (Exception exception_)
			{
				Log.smethod_3(exception_);
			}
		}

		// Token: 0x040009BC RID: 2492
		private int int_0;

		// Token: 0x040009BD RID: 2493
		private double double_0;

		// Token: 0x040009BE RID: 2494
		private double double_1;

		// Token: 0x040009BF RID: 2495
		private double double_2 = 0.0;

		// Token: 0x040009C0 RID: 2496
		private double double_3 = 0.0;

		// Token: 0x040009C1 RID: 2497
		private bool bool_0;

		// Token: 0x040009C2 RID: 2498
		private Device device_0;

		// Token: 0x040009C3 RID: 2499
		private Texture texture_0;

		// Token: 0x040009C4 RID: 2500
		private float[,] m_HeightData;

		// Token: 0x040009C5 RID: 2501
		private CustomVertex.TransformedColoredTextured[] m_RenderToTextureVertices = new CustomVertex.TransformedColoredTextured[4];

		// Token: 0x040009C6 RID: 2502
		private DynamicTexture m_DynamicTexture;

		// Token: 0x040009C7 RID: 2503
		private bool bool_1;

		// Token: 0x040009C8 RID: 2504
		private float float_1 = float.NaN;

		// Token: 0x040009C9 RID: 2505
		private DateTime m_LastUpdate = DateTime.Now;

		// Token: 0x040009CA RID: 2506
		private WorldSurfaceRenderer m_ParentWorldSurfaceRenderer;

		// Token: 0x040009CB RID: 2507
		private BoundingBox m_BoundingBox;

		// Token: 0x040009CC RID: 2508
		private short[] m_NwIndices;

		// Token: 0x040009CD RID: 2509
		private short[] m_NeIndices;

		// Token: 0x040009CE RID: 2510
		private short[] m_SwIndices;

		// Token: 0x040009CF RID: 2511
		private short[] m_SeIndices;

		// Token: 0x040009D0 RID: 2512
		private SurfaceTile m_NorthWestChild;

		// Token: 0x040009D1 RID: 2513
		private SurfaceTile m_NorthEastChild;

		// Token: 0x040009D2 RID: 2514
		private SurfaceTile m_SouthWestChild;

		// Token: 0x040009D3 RID: 2515
		private SurfaceTile m_SouthEastChild;

		// Token: 0x040009D4 RID: 2516
		private short[] m_IndicesElevated;

		// Token: 0x040009D5 RID: 2517
		private int m_FramesSinceLastUpdate;

		// Token: 0x040009D6 RID: 2518
		public static int SurfaceTileRefreshHz = 35;
	}
}
