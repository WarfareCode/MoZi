using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000224 RID: 548
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class ColorF : ICloneable, ISerializable
	{
		// Token: 0x06000CD0 RID: 3280 RVA: 0x0000AAA4 File Offset: 0x00008CA4
		public ColorF()
		{
			this._red = 0f;
			this._green = 0f;
			this._blue = 0f;
			this._alpha = 1f;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0000AAD8 File Offset: 0x00008CD8
		public ColorF(ColorF colorF_0)
		{
			this._red = colorF_0.method_0();
			this._green = colorF_0.method_1();
			this._blue = colorF_0.method_2();
			this._alpha = colorF_0.method_3();
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00079BC4 File Offset: 0x00077DC4
		protected ColorF(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._red = serializationInfo_0.GetSingle("Red");
			this._green = serializationInfo_0.GetSingle("Green");
			this._blue = serializationInfo_0.GetSingle("Blue");
			this._alpha = serializationInfo_0.GetSingle("Alpha");
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00079C1C File Offset: 0x00077E1C
		public float method_0()
		{
			return this._red;
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00079C34 File Offset: 0x00077E34
		public float method_1()
		{
			return this._green;
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00079C4C File Offset: 0x00077E4C
		public float method_2()
		{
			return this._blue;
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00079C64 File Offset: 0x00077E64
		public float method_3()
		{
			return this._alpha;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00079C7C File Offset: 0x00077E7C
		object ICloneable.Clone()
		{
			return new ColorF(this);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00079C94 File Offset: 0x00077E94
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Red", this._red);
			info.AddValue("Green", this._green);
			info.AddValue("Blue", this._blue);
			info.AddValue("Alpha", this._alpha);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00079CE8 File Offset: 0x00077EE8
		public override int GetHashCode()
		{
			return this._red.GetHashCode() ^ this._green.GetHashCode() ^ this._blue.GetHashCode() ^ this._alpha.GetHashCode();
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00079D28 File Offset: 0x00077F28
		public override bool Equals(object obj)
		{
			ColorF colorF = obj as ColorF;
			return ColorF.smethod_0(colorF, null) && this._red == colorF.method_0() && this._green == colorF.method_1() && this._blue == colorF.method_2() && this._alpha == colorF.method_3();
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00079D80 File Offset: 0x00077F80
		public override string ToString()
		{
			return string.Format("ColorF({0}, {1}, {2}, {3})", new object[]
			{
				this._red,
				this._green,
				this._blue,
				this._alpha
			});
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00004A8D File Offset: 0x00002C8D
		public static bool smethod_0(ColorF colorF_0, ColorF colorF_1)
		{
			return !object.Equals(colorF_0, colorF_1);
		}

		// Token: 0x0400057F RID: 1407
		private float _red;

		// Token: 0x04000580 RID: 1408
		private float _green;

		// Token: 0x04000581 RID: 1409
		private float _blue;

		// Token: 0x04000582 RID: 1410
		private float _alpha;
	}
}
