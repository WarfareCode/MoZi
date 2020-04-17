using System;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using GisSharpBlog.NetTopologySuite.IO;
using ns14;

namespace ns12
{
	// Token: 0x020003AC RID: 940
	public sealed class Class600
	{
		// Token: 0x06001721 RID: 5921 RVA: 0x00091D8C File Offset: 0x0008FF8C
		public Class600(Class661 class661_0)
		{
			if (class661_0 == null)
			{
				throw new ArgumentNullException("shpBinaryReader");
			}
			this.int_0 = class661_0.method_0();
			if (this.int_0 != 9994)
			{
				throw new Exception8("The first four bytes of this file indicate this is not a shape file.");
			}
			class661_0.method_0();
			class661_0.method_0();
			class661_0.method_0();
			class661_0.method_0();
			class661_0.method_0();
			this.int_1 = class661_0.method_0();
			this.int_2 = class661_0.ReadInt32();
			int num = class661_0.ReadInt32();
			this.shapeGeometryType_0 = (ShapeGeometryType)Enum.Parse(typeof(ShapeGeometryType), num.ToString());
			double[] array = new double[4];
			for (int i = 0; i < 4; i++)
			{
				array[i] = class661_0.ReadDouble();
			}
			this.ienvelope_0 = new Envelope(array[0], array[2], array[1], array[3]);
			for (int i = 0; i < 4; i++)
			{
				class661_0.ReadDouble();
			}
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0000FA01 File Offset: 0x0000DC01
		public Class600()
		{
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00091EAC File Offset: 0x000900AC
		public IEnvelope method_0()
		{
			return this.ienvelope_0;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00091EC4 File Offset: 0x000900C4
		public ShapeGeometryType method_1()
		{
			return this.shapeGeometryType_0;
		}

		// Token: 0x04000992 RID: 2450
		private int int_0 = 9994;

		// Token: 0x04000993 RID: 2451
		private int int_1 = -1;

		// Token: 0x04000994 RID: 2452
		private int int_2 = 1000;

		// Token: 0x04000995 RID: 2453
		private ShapeGeometryType shapeGeometryType_0 = ShapeGeometryType.NullShape;

		// Token: 0x04000996 RID: 2454
		private IEnvelope ienvelope_0;
	}
}
