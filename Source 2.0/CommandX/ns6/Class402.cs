using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;

namespace ns6
{
	// Token: 0x02000C84 RID: 3204
	public sealed class Class402 : Class401
	{
		// Token: 0x06006A31 RID: 27185 RVA: 0x0002DB9C File Offset: 0x0002BD9C
		protected internal Class402(int int_1, StringDictionary stringDictionary_1, IDataRecord idataRecord_1, byte[] byte_0) : base(int_1, stringDictionary_1, idataRecord_1)
		{
			this.enum119_0 = Enum119.const_10;
			this.method_6(new List<double>());
			this.method_7(byte_0, out this.struct49_0, out this.list_0);
		}

		// Token: 0x06006A32 RID: 27186 RVA: 0x0002DBCE File Offset: 0x0002BDCE
		[CompilerGenerated]
		protected void method_3(double double_2)
		{
			this.double_0 = double_2;
		}

		// Token: 0x06006A33 RID: 27187 RVA: 0x0002DBD7 File Offset: 0x0002BDD7
		[CompilerGenerated]
		protected void method_4(double double_2)
		{
			this.double_1 = double_2;
		}

		// Token: 0x06006A34 RID: 27188 RVA: 0x003909F8 File Offset: 0x0038EBF8
		[CompilerGenerated]
		public List<double> method_5()
		{
			return this.list_1;
		}

		// Token: 0x06006A35 RID: 27189 RVA: 0x0002DBE0 File Offset: 0x0002BDE0
		[CompilerGenerated]
		protected void method_6(List<double> list_2)
		{
			this.list_1 = list_2;
		}

		// Token: 0x06006A36 RID: 27190 RVA: 0x00390A10 File Offset: 0x0038EC10
		private void method_7(byte[] shapeData, out Struct49 boundingBox, out List<Struct48[]> parts)
		{
			boundingBox = default(Struct49);
			parts = null;
			if (shapeData == null)
			{
				throw new ArgumentNullException("shapeData");
			}
			if (shapeData.Length < 44)
			{
				throw new InvalidOperationException("Invalid shape data");
			}
			boundingBox = base.method_1(shapeData, 12, Enum118.const_1);
			int num = Class395.smethod_0(shapeData, 44, Enum118.const_1);
			int num2 = Class395.smethod_0(shapeData, 48, Enum118.const_1);
			if (shapeData.Length != 52 + 4 * num + 16 + 8 * num2 + 16 * num2)
			{
				throw new InvalidOperationException("Invalid shape data");
			}
			int num3 = 52 + 4 * num;
			parts = new List<Struct48[]>(num);
			for (int i = 0; i < num; i++)
			{
				int num4 = Class395.smethod_0(shapeData, 52 + 4 * i, Enum118.const_1) * 16 + num3;
				int num5;
				if (i == num - 1)
				{
					num5 = shapeData.Length - num4;
					num5 -= num2 * 8 + 16;
				}
				else
				{
					int num6 = Class395.smethod_0(shapeData, 52 + 4 * (i + 1), Enum118.const_1) * 16 + num3;
					num5 = num6 - num4;
				}
				int num7 = num5 / 16;
				Struct48[] array = new Struct48[num7];
				for (int j = 0; j < num7; j++)
				{
					array[j] = new Struct48(Class395.smethod_1(shapeData, num4 + 16 * j, Enum118.const_1), Class395.smethod_1(shapeData, num4 + 8 + 16 * j, Enum118.const_1));
				}
				parts.Add(array);
			}
			this.method_3(Class395.smethod_1(shapeData, 52 + 4 * num + 16 * num2, Enum118.const_1));
			this.method_4(Class395.smethod_1(shapeData, 60 + 4 * num + 16 * num2, Enum118.const_1));
			this.method_5().Clear();
			for (int k = 0; k < num2; k++)
			{
				double item = Class395.smethod_1(shapeData, 68 + 4 * num + 16 * num2 + k * 8, Enum118.const_1);
				this.method_5().Add(item);
			}
		}

		// Token: 0x04003BFA RID: 15354
		[CompilerGenerated]
		private double double_0;

		// Token: 0x04003BFB RID: 15355
		[CompilerGenerated]
		private double double_1;

		// Token: 0x04003BFC RID: 15356
		[CompilerGenerated]
		private List<double> list_1;
	}
}
