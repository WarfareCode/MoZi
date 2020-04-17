using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;

namespace ns6
{
	// Token: 0x02000C7D RID: 3197
	public class Class397
	{
		// Token: 0x06006A15 RID: 27157 RVA: 0x0002DABF File Offset: 0x0002BCBF
		protected internal Class397(Enum119 enum119_1, int int_1, StringDictionary stringDictionary_1, IDataRecord idataRecord_1)
		{
			this.enum119_0 = enum119_1;
			this.stringDictionary_0 = stringDictionary_1;
			this.int_0 = int_1;
			this.idataRecord_0 = idataRecord_1;
		}

		// Token: 0x06006A16 RID: 27158 RVA: 0x0038FF7C File Offset: 0x0038E17C
		public Enum119 method_0()
		{
			return this.enum119_0;
		}

		// Token: 0x06006A17 RID: 27159 RVA: 0x0038FF94 File Offset: 0x0038E194
		protected Struct49 method_1(byte[] byte_0, int int_1, Enum118 enum118_0)
		{
			return new Struct49(Class395.smethod_1(byte_0, int_1, enum118_0), Class395.smethod_1(byte_0, int_1 + 8, enum118_0), Class395.smethod_1(byte_0, int_1 + 16, enum118_0), Class395.smethod_1(byte_0, int_1 + 24, enum118_0));
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x0038FFD0 File Offset: 0x0038E1D0
		protected void method_2(byte[] shapeData, out Struct49 boundingBox, out List<Struct48[]> parts)
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
			boundingBox = this.method_1(shapeData, 12, Enum118.const_1);
			int num = Class395.smethod_0(shapeData, 44, Enum118.const_1);
			int num2 = Class395.smethod_0(shapeData, 48, Enum118.const_1);
			if (shapeData.Length != 52 + 4 * num + 16 * num2)
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
		}

		// Token: 0x04003BDC RID: 15324
		internal Enum119 enum119_0;

		// Token: 0x04003BDD RID: 15325
		private int int_0;

		// Token: 0x04003BDE RID: 15326
		private StringDictionary stringDictionary_0;

		// Token: 0x04003BDF RID: 15327
		private IDataRecord idataRecord_0;
	}
}
