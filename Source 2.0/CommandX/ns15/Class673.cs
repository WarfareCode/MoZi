using System;
using System.Drawing;

namespace ns15
{
	// Token: 0x02000493 RID: 1171
	public sealed class Class673
	{
		// Token: 0x06001E3F RID: 7743 RVA: 0x000C3A2C File Offset: 0x000C1C2C
		public Color method_0()
		{
			return this.color_0;
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00012655 File Offset: 0x00010855
		public void method_1(Color color_1)
		{
			this.color_0 = color_1;
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x0001265E File Offset: 0x0001085E
		public void method_2(float float_0)
		{
			this.color_0 = Class673.smethod_0((int)this.color_0.GetHue(), float_0, this.color_0.GetBrightness());
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x000C3A44 File Offset: 0x000C1C44
		public static Color smethod_0(int int_0, float float_0, float float_1)
		{
			int blue;
			int green;
			int red;
			if (float_0 == 0f)
			{
				red = (green = (blue = (int)(float_1 * 255f)));
			}
			else
			{
				float num = 0.0166666675f * (float)int_0;
				float num2 = (float)Math.Floor((double)num);
				float num3 = num - num2;
				float num4 = float_1 * 255f;
				byte b = (byte)(0.5f + num4 * (1f - float_0));
				byte b2 = (byte)(0.5f + num4 * (1f - float_0 * num3));
				byte b3 = (byte)(0.5f + num4 * (1f - float_0 * (1f - num3)));
				switch ((int)num2)
				{
				case 0:
					red = (int)(float_1 * 255f);
					green = (int)b3;
					blue = (int)b;
					break;
				case 1:
					red = (int)b2;
					green = (int)(float_1 * 255f);
					blue = (int)b;
					break;
				case 2:
					red = (int)b;
					green = (int)(float_1 * 255f);
					blue = (int)b3;
					break;
				case 3:
					red = (int)b;
					green = (int)b2;
					blue = (int)(float_1 * 255f);
					break;
				case 4:
					red = (int)b3;
					green = (int)b;
					blue = (int)(float_1 * 255f);
					break;
				case 5:
					red = (int)(float_1 * 255f);
					green = (int)b;
					blue = (int)b2;
					break;
				default:
					red = 0;
					green = 0;
					blue = 0;
					break;
				}
			}
			return Color.FromArgb(red, green, blue);
		}

		// Token: 0x04000DBA RID: 3514
		private Color color_0 = Color.Red;
	}
}
