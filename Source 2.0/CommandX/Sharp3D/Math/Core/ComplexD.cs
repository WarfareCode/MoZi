using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Sharp3D.Math.Core
{
	// Token: 0x0200023D RID: 573
	public struct ComplexD : ICloneable, ISerializable
	{
		// Token: 0x06000D4E RID: 3406 RVA: 0x0000AF61 File Offset: 0x00009161
		public ComplexD(double double_0, double double_1)
		{
			this._real = double_0;
			this._image = double_1;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0000AF71 File Offset: 0x00009171
		public ComplexD(ComplexD complexD_0)
		{
			this._real = complexD_0.method_0();
			this._image = complexD_0.method_1();
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0000AF8D File Offset: 0x0000918D
		private ComplexD(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._real = (double)serializationInfo_0.GetSingle("Real");
			this._image = (double)serializationInfo_0.GetSingle("Imaginary");
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x0007A21C File Offset: 0x0007841C
		public double method_0()
		{
			return this._real;
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0007A234 File Offset: 0x00078434
		public double method_1()
		{
			return this._image;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0007A24C File Offset: 0x0007844C
		object ICloneable.Clone()
		{
			return new ComplexD(this);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0000AFB3 File Offset: 0x000091B3
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Real", this.method_0());
			info.AddValue("Imaginary", this.method_1());
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0007A26C File Offset: 0x0007846C
		public static ComplexD smethod_0(string string_0)
		{
			Regex regex = new Regex("\\((?<real>.*),(?<imaginary>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new ComplexD(double.Parse(match.Result("${real}")), double.Parse(match.Result("${imaginary}")));
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0007A2C8 File Offset: 0x000784C8
		public override int GetHashCode()
		{
			return this._real.GetHashCode() ^ this._image.GetHashCode();
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0007A2F0 File Offset: 0x000784F0
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is ComplexD)
			{
				ComplexD complexD = (ComplexD)obj;
				result = (this.method_0() == complexD.method_0() && this.method_1() == complexD.method_1());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0007A33C File Offset: 0x0007853C
		public override string ToString()
		{
			return string.Format("({0}, {1})", this._real, this._image);
		}

		// Token: 0x040005A7 RID: 1447
		private double _real;

		// Token: 0x040005A8 RID: 1448
		private double _image;

		// Token: 0x040005A9 RID: 1449
		public static readonly ComplexD Zero = new ComplexD(0.0, 0.0);

		// Token: 0x040005AA RID: 1450
		public static readonly ComplexD One = new ComplexD(1.0, 0.0);

		// Token: 0x040005AB RID: 1451
		public static readonly ComplexD I = new ComplexD(0.0, 1.0);
	}
}
