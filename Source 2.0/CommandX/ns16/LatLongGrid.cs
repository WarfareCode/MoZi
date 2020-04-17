using System;
using System.Drawing;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using ns18;
using ns19;

namespace ns16
{
	// Token: 0x0200048E RID: 1166
	public sealed class LatLongGrid : RenderableObject
	{
		// Token: 0x06001E19 RID: 7705 RVA: 0x000C2278 File Offset: 0x000C0478
		public LatLongGrid(World world) : base("Grid lines")
		{
			this.WorldRadius = world.GetEquatorialRadius();
			this.IsEarth = (world.GetName() == "Earth");
			this.m_renderPriority = RenderPriority.const_3;
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x000C22CC File Offset: 0x000C04CC
		public override void Render(DrawArgs drawArgs)
		{
			if (World.Settings.bool_12)
			{
				this.ComputeGridValues(drawArgs);
				float num = (float)drawArgs.GetWorldCamera().GetTrueViewRange().GetDegrees() / 6f;
				drawArgs.device_0.RenderState.ZBufferEnable = this.useZBuffer;
				drawArgs.device_0.TextureState[0].ColorOperation = TextureOperation.Disable;
				drawArgs.device_0.VertexFormat = (VertexFormats.Diffuse | VertexFormats.Position);
				drawArgs.device_0.Transform.World = Matrix.Translation(-(float)drawArgs.GetWorldCamera().ReferenceCenter.X, -(float)drawArgs.GetWorldCamera().ReferenceCenter.Y, -(float)drawArgs.GetWorldCamera().ReferenceCenter.Z);
				Vector3 right = new Vector3((float)drawArgs.GetWorldCamera().ReferenceCenter.X, (float)drawArgs.GetWorldCamera().ReferenceCenter.Y, (float)drawArgs.GetWorldCamera().ReferenceCenter.Z);
				if (World.Settings.IsEnableSunShading())
				{
					drawArgs.device_0.RenderState.Lighting = false;
				}
				for (float num2 = (float)this.MinVisibleLongitude; num2 < (float)this.MaxVisibleLongitude; num2 += (float)this.LongitudeInterval)
				{
					int num3 = 0;
					for (float num4 = (float)this.MinVisibleLatitude; num4 <= (float)this.MaxVisibleLatitude; num4 += (float)this.LatitudeInterval)
					{
						Vector3 vector = MathEngine.SphericalToCartesian((double)num4, (double)num2, this.radius);
						this.lineVertices[num3].X = vector.X;
						this.lineVertices[num3].Y = vector.Y;
						this.lineVertices[num3].Z = vector.Z;
						this.lineVertices[num3].Color = World.Settings.int_15;
						num3++;
					}
					drawArgs.device_0.DrawUserPrimitives(PrimitiveType.LineStrip, this.LatitudePointCount - 1, this.lineVertices);
					float num5 = (float)drawArgs.GetWorldCamera().GetLatitude().GetDegrees();
					if (num5 > 70f)
					{
						num5 = 70f;
					}
					Vector3 vector2 = MathEngine.SphericalToCartesian((double)num5, (double)num2, this.radius);
					if (drawArgs.GetWorldCamera().GetViewFrustum().ContainsPoint(vector2))
					{
						int num6 = (int)num2;
						if (num6 <= -180)
						{
							num6 += 360;
						}
						else if (num6 > 180)
						{
							num6 -= 360;
						}
						string text = Math.Abs(num6).ToString();
						if (num6 < 0)
						{
							text += "W";
						}
						else if (num6 > 0 && num6 < 180)
						{
							text += "E";
						}
						vector2 = drawArgs.GetWorldCamera().Project(vector2 - right);
						Rectangle rectangle = new Rectangle((int)vector2.X + 2, (int)vector2.Y, 10, 10);
						drawArgs.font_0.DrawText(null, text, rectangle.Left, rectangle.Top, World.Settings.int_15);
					}
				}
				for (float num7 = (float)this.MinVisibleLatitude; num7 <= (float)this.MaxVisibleLatitude; num7 += (float)this.LatitudeInterval)
				{
					float num8 = (float)drawArgs.GetWorldCamera().GetLongitude().GetDegrees() + num;
					Vector3 vector3 = MathEngine.SphericalToCartesian((double)num7, (double)num8, this.radius);
					if (drawArgs.GetWorldCamera().GetViewFrustum().ContainsPoint(vector3))
					{
						vector3 = drawArgs.GetWorldCamera().Project(vector3 - right);
						float num9 = num7;
						if (num9 > 90f)
						{
							num9 = 180f - num9;
						}
						else if (num9 < -90f)
						{
							num9 = -180f - num9;
						}
						string text2 = ((int)Math.Abs(num9)).ToString();
						if (num9 > 0f)
						{
							text2 += "N";
						}
						else if (num9 < 0f)
						{
							text2 += "S";
						}
						Rectangle rectangle2 = new Rectangle((int)vector3.X, (int)vector3.Y, 10, 10);
						drawArgs.font_0.DrawText(null, text2, rectangle2.Left, rectangle2.Top, World.Settings.int_15);
					}
					int num10 = 0;
					for (num8 = (float)this.MinVisibleLongitude; num8 <= (float)this.MaxVisibleLongitude; num8 += (float)this.LongitudeInterval)
					{
						Vector3 vector4 = MathEngine.SphericalToCartesian((double)num7, (double)num8, this.radius);
						this.lineVertices[num10].X = vector4.X;
						this.lineVertices[num10].Y = vector4.Y;
						this.lineVertices[num10].Z = vector4.Z;
						if (num7 == 0f)
						{
							this.lineVertices[num10].Color = World.Settings.int_16;
						}
						else
						{
							this.lineVertices[num10].Color = World.Settings.int_15;
						}
						num10++;
					}
					drawArgs.device_0.DrawUserPrimitives(PrimitiveType.LineStrip, this.LongitudePointCount - 1, this.lineVertices);
				}
				if (World.Settings.bool_13 && this.IsEarth)
				{
					this.RenderTropicLines(drawArgs);
				}
				drawArgs.device_0.Transform.World = drawArgs.GetWorldCamera().GetWorldMatrix();
				if (!this.useZBuffer)
				{
					drawArgs.device_0.RenderState.ZBufferEnable = true;
				}
				if (World.Settings.IsEnableSunShading())
				{
					drawArgs.device_0.RenderState.Lighting = true;
				}
			}
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00012561 File Offset: 0x00010761
		public override void Initialize(DrawArgs class1943_0)
		{
			this.isInitialized = true;
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void Dispose()
		{
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x000081A2 File Offset: 0x000063A2
		public override bool PerformSelectionAction(DrawArgs class1943_0)
		{
			return false;
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x000081A2 File Offset: 0x000063A2
		public override bool Update(DrawArgs class1943_0)
		{
			return false;
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0001256A File Offset: 0x0001076A
		public override bool IsOn()
		{
			return World.Settings.bool_12;
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00012576 File Offset: 0x00010776
		public override void SetIsOn(bool bool_5)
		{
			World.Settings.bool_12 = bool_5;
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x000C28C8 File Offset: 0x000C0AC8
		private void RenderTropicLines(DrawArgs DrawArgs_)
		{
			this.RenderTropicLine(DrawArgs_, 23.4394436f, "北回归线");
			this.RenderTropicLine(DrawArgs_, -23.4394436f, "南回归线");
			this.RenderTropicLine(DrawArgs_, 66.5605545f, "北极圈");
			this.RenderTropicLine(DrawArgs_, -66.5605545f, "南极圈");
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x000C291C File Offset: 0x000C0B1C
		private void RenderTropicLine(DrawArgs drawArgs, float float_0, string string_2)
		{
			int num = 0;
			Vector3 right = new Vector3((float)drawArgs.GetWorldCamera().ReferenceCenter.X, (float)drawArgs.GetWorldCamera().ReferenceCenter.Y, (float)drawArgs.GetWorldCamera().ReferenceCenter.Z);
			for (float num2 = (float)this.MinVisibleLongitude; num2 <= (float)this.MaxVisibleLongitude; num2 += (float)this.LongitudeInterval)
			{
				Vector3 vector = MathEngine.SphericalToCartesian((double)float_0, (double)num2, this.radius);
				this.lineVertices[num].X = vector.X;
				this.lineVertices[num].Y = vector.Y;
				this.lineVertices[num].Z = vector.Z;
				this.lineVertices[num].Color = World.Settings.int_17;
				num++;
			}
			drawArgs.device_0.DrawUserPrimitives(PrimitiveType.LineStrip, this.LongitudePointCount - 1, this.lineVertices);
			Vector3 vector2 = MathEngine.SphericalToCartesian(Angle.FromDegrees((double)float_0), Angle.Minus(drawArgs.GetWorldCamera().GetLongitude(), Angle.Multiply(Angle.Multiply(drawArgs.GetWorldCamera().GetTrueViewRange(), 0.30000001192092896), 0.5)), this.radius);
			if (drawArgs.GetWorldCamera().GetViewFrustum().ContainsPoint(vector2))
			{
				vector2 = drawArgs.GetWorldCamera().Project(vector2 - right);
				drawArgs.font_0.DrawText(null, string_2, new Rectangle((int)vector2.X, (int)vector2.Y, drawArgs.int_3, drawArgs.int_4), DrawTextFormat.NoClip, World.Settings.int_17);
			}
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x000C2AD4 File Offset: 0x000C0CD4
		public void ComputeGridValues(DrawArgs drawArgs)
		{
			double num = drawArgs.GetWorldCamera().GetTrueViewRange().Radians;
			num *= 1.0 + Math.Abs(Math.Sin(drawArgs.GetWorldCamera().GetLatitude().Radians));
			if (num < 0.17)
			{
				this.LatitudeInterval = 1;
			}
			else if (num < 0.6)
			{
				this.LatitudeInterval = 2;
			}
			else if (num < 1.0)
			{
				this.LatitudeInterval = 5;
			}
			else
			{
				this.LatitudeInterval = 10;
			}
			this.LongitudeInterval = this.LatitudeInterval;
			if (drawArgs.GetWorldCamera().GetViewFrustum().ContainsPoint(MathEngine.SphericalToCartesian(90.0, 0.0, this.radius)) || drawArgs.GetWorldCamera().GetViewFrustum().ContainsPoint(MathEngine.SphericalToCartesian(-90.0, 0.0, this.radius)))
			{
				this.LongitudeInterval = 10;
			}
			this.MinVisibleLongitude = ((this.LongitudeInterval >= 10) ? -180 : ((int)drawArgs.GetWorldCamera().GetLongitude().GetDegrees() / this.LongitudeInterval * this.LongitudeInterval - 18 * this.LongitudeInterval));
			this.MaxVisibleLongitude = ((this.LongitudeInterval >= 10) ? 180 : ((int)drawArgs.GetWorldCamera().GetLongitude().GetDegrees() / this.LongitudeInterval * this.LongitudeInterval + 18 * this.LongitudeInterval));
			this.MinVisibleLatitude = (int)drawArgs.GetWorldCamera().GetLatitude().GetDegrees() / this.LatitudeInterval * this.LatitudeInterval - 9 * this.LatitudeInterval;
			this.MaxVisibleLatitude = (int)drawArgs.GetWorldCamera().GetLatitude().GetDegrees() / this.LatitudeInterval * this.LatitudeInterval + 9 * this.LatitudeInterval;
			if (this.MaxVisibleLatitude - this.MinVisibleLatitude >= 180 || this.LongitudeInterval == 10)
			{
				this.MinVisibleLatitude = -90;
				this.MaxVisibleLatitude = 90;
			}
			this.LongitudePointCount = (this.MaxVisibleLongitude - this.MinVisibleLongitude) / this.LongitudeInterval + 1;
			this.LatitudePointCount = (this.MaxVisibleLatitude - this.MinVisibleLatitude) / this.LatitudeInterval + 1;
			int num2 = Math.Max(this.LatitudePointCount, this.LongitudePointCount);
			if (this.lineVertices == null || num2 > this.lineVertices.Length)
			{
				this.lineVertices = new CustomVertex.PositionColored[Math.Max(this.LatitudePointCount, this.LongitudePointCount)];
			}
			this.radius = this.WorldRadius;
			if (drawArgs.GetWorldCamera().GetAltitude() < 0.10000000149011612 * this.WorldRadius)
			{
				this.useZBuffer = false;
			}
			else
			{
				this.useZBuffer = true;
				double val = this.WorldRadius * 1.0099999904632568;
				double val2 = this.WorldRadius + 0.014999999664723873 * drawArgs.GetWorldCamera().GetAltitude();
				this.radius = Math.Min(val2, val);
			}
		}

		// Token: 0x04000D9D RID: 3485
		public double WorldRadius;

		// Token: 0x04000D9E RID: 3486
		protected double radius;

		// Token: 0x04000D9F RID: 3487
		public bool IsEarth;

		// Token: 0x04000DA0 RID: 3488
		public int MinVisibleLongitude;

		// Token: 0x04000DA1 RID: 3489
		public int MaxVisibleLongitude;

		// Token: 0x04000DA2 RID: 3490
		public int MinVisibleLatitude = 0;

		// Token: 0x04000DA3 RID: 3491
		public int MaxVisibleLatitude = 0;

		// Token: 0x04000DA4 RID: 3492
		public int LongitudeInterval;

		// Token: 0x04000DA5 RID: 3493
		public int LatitudeInterval;

		// Token: 0x04000DA6 RID: 3494
		public int LongitudePointCount;

		// Token: 0x04000DA7 RID: 3495
		public int LatitudePointCount;

		// Token: 0x04000DA8 RID: 3496
		protected CustomVertex.PositionColored[] lineVertices;

		// Token: 0x04000DA9 RID: 3497
		protected bool useZBuffer;
	}
}
