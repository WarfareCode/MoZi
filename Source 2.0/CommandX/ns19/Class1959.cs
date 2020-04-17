using System;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using ns16;

namespace ns19
{
	// Token: 0x020003A6 RID: 934
	public sealed class Class1959 : IComparable
	{
		// Token: 0x060016E3 RID: 5859 RVA: 0x0000F817 File Offset: 0x0000DA17
		public bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x000913EC File Offset: 0x0008F5EC
		public double method_1()
		{
			return this.double_0;
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00091404 File Offset: 0x0008F604
		public double method_2()
		{
			return this.double_1;
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0009141C File Offset: 0x0008F61C
		public double method_3()
		{
			return this.double_2;
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00091434 File Offset: 0x0008F634
		public double method_4()
		{
			return this.double_3;
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x0009144C File Offset: 0x0008F64C
		public string method_5()
		{
			return this.string_0;
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00091464 File Offset: 0x0008F664
		public RenderableObject method_6()
		{
			return this.class1993_0;
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x0009147C File Offset: 0x0008F67C
		public Texture method_7()
		{
			return this.texture_0;
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x0000F81F File Offset: 0x0000DA1F
		public void method_8(Texture texture_1)
		{
			this.texture_0 = texture_1;
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00091494 File Offset: 0x0008F694
		public Vector2 method_9(double double_4, double double_5)
		{
			double num = this.double_0 - double_4;
			double num2 = double_5 - this.double_2;
			double num3 = this.double_0 - this.double_1;
			double num4 = this.double_3 - this.double_2;
			return new Vector2((float)(num / num3), (float)(num2 / num4));
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x000914E0 File Offset: 0x0008F6E0
		private string method_10(RenderableObject class1993_1)
		{
			string result;
			if (class1993_1.ParentList != null)
			{
				result = this.method_10(class1993_1.ParentList) + "." + this.method_11(class1993_1).ToString().PadLeft(5, '0');
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00091530 File Offset: 0x0008F730
		private int method_11(RenderableObject class1993_1)
		{
			int result;
			if (class1993_1.ParentList == null)
			{
				result = -1;
			}
			else
			{
				for (int i = 0; i < class1993_1.ParentList.GetChildObjects().Count; i++)
				{
					if (class1993_1 == class1993_1.ParentList.GetChildObjects()[i])
					{
						result = i;
						return result;
					}
				}
				result = -1;
			}
			return result;
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x0009158C File Offset: 0x0008F78C
		public int CompareTo(object target)
		{
			int result;
			if (!(target is Class1959))
			{
				result = 1;
			}
			else
			{
				Class1959 @class = target as Class1959;
				string text = this.method_10(this.class1993_0);
				string text2 = this.method_10(@class.method_6());
				if (text == text2)
				{
					double num = this.double_0 - this.double_1;
					num = 1.0 / num;
					double num2 = @class.method_1() - @class.method_2();
					num2 = 1.0 / num2;
					result = num.CompareTo(num2);
				}
				else
				{
					result = text.CompareTo(text2);
				}
			}
			return result;
		}

		// Token: 0x0400097A RID: 2426
		private string string_0;

		// Token: 0x0400097B RID: 2427
		private double double_0;

		// Token: 0x0400097C RID: 2428
		private double double_1;

		// Token: 0x0400097D RID: 2429
		private double double_2 = 0.0;

		// Token: 0x0400097E RID: 2430
		private double double_3 = 0.0;

		// Token: 0x0400097F RID: 2431
		private Texture texture_0;

		// Token: 0x04000980 RID: 2432
		private bool bool_0;

		// Token: 0x04000981 RID: 2433
		private RenderableObject class1993_0;

		// Token: 0x04000982 RID: 2434
		public DateTime dateTime_0;

		// Token: 0x04000983 RID: 2435
		public byte byte_0;
	}
}
