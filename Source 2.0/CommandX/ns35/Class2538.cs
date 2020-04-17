using System;
using System.ComponentModel;
using System.Drawing;
using Command;
using Microsoft.DirectX.Direct3D;
using ns16;
using ns18;
using ns19;

namespace ns35
{
	// Token: 0x02000A91 RID: 2705
	public sealed class Class2538
	{
		// Token: 0x02000A92 RID: 2706
		public sealed class Class2002 : RenderableObject
		{
			// Token: 0x0600554A RID: 21834 RVA: 0x00239E68 File Offset: 0x00238068
			public Class2002(World class1995_1, DrawArgs class1943_1) : base("Scale")
			{
				this.float_0 = 0.15f;
				this.float_1 = 0.0175f;
				this.string_3 = new string[4];
				this.int_0 = Color.FromArgb(255, 255, 255, 255).ToArgb();
				this.transformedColored_0 = new CustomVertex.TransformedColored[2];
				this.transformedColored_1 = new CustomVertex.TransformedColored[10][];
				this.vmethod_7(RenderPriority.Placenames);
				this.SetIsOn(true);
				Device device = Client.m_WorldWindow.method_1();
				this.class1995_0 = class1995_1;
				this.class1943_0 = class1943_1;
				this.double_2 = (double)class1943_1.font_0.MeasureString(null, "Aj", DrawTextFormat.None, 0).Height;
				int num = this.transformedColored_1.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					this.transformedColored_1[i] = new CustomVertex.TransformedColored[2];
				}
				int num2 = this.transformedColored_0.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					this.transformedColored_0[j].Color = this.int_0;
				}
				int num3 = this.transformedColored_1.Length - 1;
				for (int k = 0; k <= num3; k++)
				{
					int num4 = this.transformedColored_1[k].Length - 1;
					for (int l = 0; l <= num4; l++)
					{
						this.transformedColored_1[k][l].Color = this.int_0;
					}
				}
				device.DeviceResizing += new CancelEventHandler(this.method_0);
				this.method_0(device, new CancelEventArgs());
			}

			// Token: 0x0600554B RID: 21835 RVA: 0x0023A034 File Offset: 0x00238234
			public void method_0(object sender, CancelEventArgs e)
			{
				Device device = (Device)sender;
				int width = device.Viewport.Width;
				int height = device.Viewport.Height;
				this.point_0 = new Point((int)Math.Round((double)((float)width * (1f - this.float_0) / 2f)), (int)Math.Round((double)height / 2.0));
				this.point_1 = new Point((int)Math.Round((double)((float)width * (1f + this.float_0) / 2f)), (int)Math.Round((double)height / 2.0));
				this.point_2 = new Point((int)Math.Round((double)((float)width * (1f - this.float_1 - this.float_0))), (int)Math.Round((double)((float)height * (1f - this.float_1))));
				this.point_3 = new Point((int)Math.Round((double)((float)width * (1f - this.float_1))), (int)Math.Round((double)((float)height * (1f - this.float_1))));
				int num = (int)Math.Round((double)(20f * Client.float_0));
				this.point_2.X = this.point_2.X + -300;
				this.point_3.X = this.point_3.X + -300;
				this.point_2.Y = this.point_2.Y + num;
				this.point_3.Y = this.point_3.Y + num;
				this.transformedColored_0[0].X = (float)this.point_2.X;
				this.transformedColored_0[0].Y = (float)(this.point_2.Y - (int)Math.Round(this.double_2 * 1.1));
				this.transformedColored_0[1].X = (float)this.point_3.X;
				this.transformedColored_0[1].Y = (float)(this.point_3.Y - (int)Math.Round(this.double_2 * 1.1));
				float num2 = (float)(this.point_3.X - this.point_2.X) / (float)(this.transformedColored_1.Length - 1);
				int num3 = this.transformedColored_1.Length - 1;
				for (int i = 0; i <= num3; i++)
				{
					this.transformedColored_1[i][0].X = (float)this.point_2.X + num2 * (float)i;
					this.transformedColored_1[i][1].X = (float)this.point_2.X + num2 * (float)i;
					this.transformedColored_1[i][0].Y = (float)(this.point_2.Y - (int)Math.Round(this.double_2 * 1.1));
					this.transformedColored_1[i][1].Y = (float)(this.point_2.Y - (int)Math.Round(this.double_2 * 1.1)) - this.float_1 * (float)height;
				}
			}

			// Token: 0x0600554C RID: 21836 RVA: 0x00027398 File Offset: 0x00025598
			public override bool IsOn()
			{
				return base.IsOn();
			}

			// Token: 0x0600554D RID: 21837 RVA: 0x000273A0 File Offset: 0x000255A0
			public override void SetIsOn(bool bool_3)
			{
				if (bool_3 != this.IsOn())
				{
					base.SetIsOn(bool_3);
				}
			}

			// Token: 0x0600554E RID: 21838 RVA: 0x0023A384 File Offset: 0x00238584
			public override void Render(DrawArgs class1943_1)
			{
				if (this.IsOn())
				{
					Device device = Client.m_WorldWindow.method_1();
					device.TextureState[0].ColorOperation = TextureOperation.Disable;
					device.VertexFormat = (VertexFormats.Diffuse | VertexFormats.Transformed);
					if (class1943_1.GetWorldCamera().GetTilt().GetDegrees() <= 70.0)
					{
						class1943_1.GetWorldCamera().PickingRayIntersection(this.point_0.X, this.point_0.Y, out this.struct63_0, out this.struct63_1);
						if (!Angle.IsNaN(this.struct63_0) && !Angle.IsNaN(this.struct63_1))
						{
							class1943_1.GetWorldCamera().PickingRayIntersection(this.point_1.X, this.point_1.Y, out this.struct63_2, out this.struct63_3);
							if (!Angle.IsNaN(this.struct63_2) && !Angle.IsNaN(this.struct63_3))
							{
								this.double_0 = World.ApproxAngularDistance(this.struct63_0, this.struct63_1, this.struct63_2, this.struct63_3).Radians * this.class1995_0.GetEquatorialRadius();
								if (this.double_0 > 5556.0)
								{
									this.double_1 = 1852.0;
									this.string_2 = "海里";
								}
								else
								{
									this.double_1 = 1.0;
									this.string_2 = "米";
								}
								device.DrawUserPrimitives(PrimitiveType.LineStrip, this.transformedColored_0.GetLength(0) - 1, this.transformedColored_0);
								int num = this.transformedColored_1.Length - 1;
								for (int i = 0; i <= num; i++)
								{
									device.DrawUserPrimitives(PrimitiveType.LineStrip, this.transformedColored_1[i].GetLength(0) - 1, this.transformedColored_1[i]);
								}
								Rectangle rectangle = class1943_1.font_0.MeasureString(null, this.string_2, DrawTextFormat.None, 0);
								class1943_1.font_0.DrawText(null, this.string_2, (int)Math.Round((double)(this.point_2.X + this.point_3.X - rectangle.Width) / 2.0), this.point_2.Y - rectangle.Height - 10, this.int_0);
								float num2 = (float)(this.point_3.X - this.point_2.X) / (float)(this.string_3.Length - 1);
								this.string_3[0] = "0";
								int num3 = this.string_3.Length - 1;
								for (int j = 0; j <= num3; j++)
								{
									if (j > 0)
									{
										double num4 = this.double_0 / this.double_1 * ((double)j / (double)(this.string_3.Length - 1));
										if (num4 == 0.0)
										{
											this.string_3[j] = "n/a";
										}
										else
										{
											this.string_3[j] = this.method_1(num4, 2).ToString();
										}
									}
									Rectangle rectangle2 = class1943_1.font_0.MeasureString(null, this.string_3[j], DrawTextFormat.None, 0);
									class1943_1.font_0.DrawText(null, this.string_3[j], (int)Math.Round((double)((float)this.point_2.X + num2 * (float)j) - (double)rectangle2.Width / 2.0), (int)Math.Round((double)(this.transformedColored_1[j][1].Y - (float)rectangle2.Height) - (double)(this.transformedColored_1[j][0].Y - this.transformedColored_1[j][1].Y) * 0.1), this.int_0);
								}
							}
						}
					}
				}
			}

			// Token: 0x0600554F RID: 21839 RVA: 0x0023A754 File Offset: 0x00238954
			public int method_1(double double_3, int int_1)
			{
				if (double_3 == 0.0)
				{
					throw new ArgumentException("Precise is ZERO!");
				}
				int num = (int)Math.Round(Math.Log10(double_3) + 1.0);
				int result;
				if (num <= int_1)
				{
					result = (int)Math.Round(double_3);
				}
				else
				{
					int num2 = (int)Math.Round(Math.Pow(10.0, (double)(num - int_1)));
					result = (int)Math.Round(Math.Round(double_3 / (double)num2) * (double)num2);
				}
				return result;
			}

			// Token: 0x06005550 RID: 21840 RVA: 0x00012561 File Offset: 0x00010761
			public override void Initialize(DrawArgs class1943_1)
			{
				this.isInitialized = true;
			}

			// Token: 0x06005551 RID: 21841 RVA: 0x000273B4 File Offset: 0x000255B4
			public override bool Update(DrawArgs class1943_1)
			{
				if (!this.isInitialized)
				{
					this.Initialize(class1943_1);
				}
				return true;
			}

			// Token: 0x06005552 RID: 21842 RVA: 0x000272F0 File Offset: 0x000254F0
			public override void Dispose()
			{
				this.isInitialized = false;
			}

			// Token: 0x06005553 RID: 21843 RVA: 0x000081A2 File Offset: 0x000063A2
			public override bool PerformSelectionAction(DrawArgs class1943_1)
			{
				return false;
			}

			// Token: 0x04002974 RID: 10612
			public Angle struct63_0;

			// Token: 0x04002975 RID: 10613
			public Angle struct63_1;

			// Token: 0x04002976 RID: 10614
			public Point point_0;

			// Token: 0x04002977 RID: 10615
			public Angle struct63_2;

			// Token: 0x04002978 RID: 10616
			public Angle struct63_3;

			// Token: 0x04002979 RID: 10617
			public Point point_1;

			// Token: 0x0400297A RID: 10618
			public Point point_2;

			// Token: 0x0400297B RID: 10619
			public Point point_3;

			// Token: 0x0400297C RID: 10620
			public double double_0;

			// Token: 0x0400297D RID: 10621
			private DrawArgs class1943_0;

			// Token: 0x0400297E RID: 10622
			private string string_2 = "";

			// Token: 0x0400297F RID: 10623
			private double double_1;

			// Token: 0x04002980 RID: 10624
			private double double_2 = 0.0;

			// Token: 0x04002981 RID: 10625
			private float float_0;

			// Token: 0x04002982 RID: 10626
			private float float_1;

			// Token: 0x04002983 RID: 10627
			private string[] string_3;

			// Token: 0x04002984 RID: 10628
			private int int_0;

			// Token: 0x04002985 RID: 10629
			private CustomVertex.TransformedColored[] transformedColored_0;

			// Token: 0x04002986 RID: 10630
			private CustomVertex.TransformedColored[][] transformedColored_1;
		}
	}
}
