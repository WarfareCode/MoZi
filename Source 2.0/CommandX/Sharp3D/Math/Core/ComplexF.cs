using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000256 RID: 598
	[Serializable]
	public struct ComplexF : ICloneable, ISerializable
	{
		// Token: 0x06000DEC RID: 3564 RVA: 0x0000B57C File Offset: 0x0000977C
		public ComplexF(float float_0, float float_1)
		{
			this._real = float_0;
			this._image = float_1;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0000B58C File Offset: 0x0000978C
		public ComplexF(ComplexF complexF_0)
		{
			this._real = complexF_0.method_0();
			this._image = complexF_0.method_1();
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0000B5A8 File Offset: 0x000097A8
		private ComplexF(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._real = serializationInfo_0.GetSingle("Real");
			this._image = serializationInfo_0.GetSingle("Imaginary");
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0007ADA0 File Offset: 0x00078FA0
		public float method_0()
		{
			return this._real;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0007ADB8 File Offset: 0x00078FB8
		public float method_1()
		{
			return this._image;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0007ADD0 File Offset: 0x00078FD0
		object ICloneable.Clone()
		{
			return new ComplexF(this);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0000B5CC File Offset: 0x000097CC
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Real", this.method_0());
			info.AddValue("Imaginary", this.method_1());
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0007ADF0 File Offset: 0x00078FF0
		public static ComplexF smethod_0(string string_0)
		{
			Regex regex = new Regex("\\((?<real>.*),(?<imaginary>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new ComplexF(float.Parse(match.Result("${real}")), float.Parse(match.Result("${imaginary}")));
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0007AE4C File Offset: 0x0007904C
		public override int GetHashCode()
		{
			return this._real.GetHashCode() ^ this._image.GetHashCode();
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0007AE74 File Offset: 0x00079074
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is ComplexF)
			{
				ComplexF complexF = (ComplexF)obj;
				result = (this.method_0() == complexF.method_0() && this.method_1() == complexF.method_1());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0007AEC0 File Offset: 0x000790C0
		public override string ToString()
		{
			return string.Format("({0}, {1})", this._real, this._image);
		}

		// Token: 0x040005D3 RID: 1491
		private float _real;

		// Token: 0x040005D4 RID: 1492
		private float _image;

		// Token: 0x040005D5 RID: 1493
		public static readonly ComplexF Zero = new ComplexF(0f, 0f);

		// Token: 0x040005D6 RID: 1494
		public static readonly ComplexF One = new ComplexF(1f, 0f);

		// Token: 0x040005D7 RID: 1495
		public static readonly ComplexF I = new ComplexF(0f, 1f);
	}
}
