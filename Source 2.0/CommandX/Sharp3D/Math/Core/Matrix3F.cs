using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace Sharp3D.Math.Core
{
	// Token: 0x020002F2 RID: 754
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public struct Matrix3F : ICloneable, ISerializable
	{
		// Token: 0x17000189 RID: 393
		public unsafe float this[int index]
		{
			get
			{
				if (index >= 0 && index < 16)
				{
                    //return (&this._m11)[index];
                    fixed (float* ptr = &this._m11)
                    {
                        return ptr[index];
                    }
                }
				throw new IndexOutOfRangeException("Invalid matrix index!");
			}
			set
			{
				if (index < 0 || index >= 16)
				{
					throw new IndexOutOfRangeException("Invalid matrix index!");
				}
				fixed (float* ptr = &this._m11)
				{
					ptr[index] = value;
				}
			}
		}

		// Token: 0x1700018A RID: 394
		public float this[int int_0, int int_1]
		{
			get
			{
				return this[(int_0 - 1) * 3 + (int_1 - 1)];
			}
			set
			{
				this[(int_0 - 1) * 3 + (int_1 - 1)] = value;
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00080B14 File Offset: 0x0007ED14
		public Matrix3F(float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, float float_6, float float_7, float float_8)
		{
			this._m11 = float_0;
			this._m12 = float_1;
			this._m13 = float_2;
			this._m21 = float_3;
			this._m22 = float_4;
			this._m23 = float_5;
			this._m31 = float_6;
			this._m32 = float_7;
			this._m33 = float_8;
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00080B68 File Offset: 0x0007ED68
		public Matrix3F(Matrix3F matrix3F_0)
		{
			this._m11 = matrix3F_0.method_0();
			this._m12 = matrix3F_0.method_1();
			this._m13 = matrix3F_0.method_2();
			this._m21 = matrix3F_0.method_3();
			this._m22 = matrix3F_0.method_4();
			this._m23 = matrix3F_0.method_5();
			this._m31 = matrix3F_0.method_6();
			this._m32 = matrix3F_0.method_7();
			this._m33 = matrix3F_0.method_8();
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00080BEC File Offset: 0x0007EDEC
		private Matrix3F(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._m11 = serializationInfo_0.GetSingle("M11");
			this._m12 = serializationInfo_0.GetSingle("M12");
			this._m13 = serializationInfo_0.GetSingle("M13");
			this._m21 = serializationInfo_0.GetSingle("M21");
			this._m22 = serializationInfo_0.GetSingle("M22");
			this._m23 = serializationInfo_0.GetSingle("M23");
			this._m31 = serializationInfo_0.GetSingle("M31");
			this._m32 = serializationInfo_0.GetSingle("M32");
			this._m33 = serializationInfo_0.GetSingle("M33");
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00080C94 File Offset: 0x0007EE94
		object ICloneable.Clone()
		{
			return new Matrix3F(this);
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00080CB4 File Offset: 0x0007EEB4
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("M11", this._m11);
			info.AddValue("M12", this._m12);
			info.AddValue("M13", this._m13);
			info.AddValue("M21", this._m21);
			info.AddValue("M22", this._m22);
			info.AddValue("M23", this._m23);
			info.AddValue("M31", this._m31);
			info.AddValue("M32", this._m32);
			info.AddValue("M33", this._m33);
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00080D5C File Offset: 0x0007EF5C
		public float method_0()
		{
			return this._m11;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00080D74 File Offset: 0x0007EF74
		public float method_1()
		{
			return this._m12;
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00080D8C File Offset: 0x0007EF8C
		public float method_2()
		{
			return this._m13;
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00080DA4 File Offset: 0x0007EFA4
		public float method_3()
		{
			return this._m21;
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00080DBC File Offset: 0x0007EFBC
		public float method_4()
		{
			return this._m22;
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00080DD4 File Offset: 0x0007EFD4
		public float method_5()
		{
			return this._m23;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00080DEC File Offset: 0x0007EFEC
		public float method_6()
		{
			return this._m31;
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00080E04 File Offset: 0x0007F004
		public float method_7()
		{
			return this._m32;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00080E1C File Offset: 0x0007F01C
		public float method_8()
		{
			return this._m33;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00080E34 File Offset: 0x0007F034
		public override int GetHashCode()
		{
			return this._m11.GetHashCode() ^ this._m12.GetHashCode() ^ this._m13.GetHashCode() ^ this._m21.GetHashCode() ^ this._m22.GetHashCode() ^ this._m23.GetHashCode() ^ this._m31.GetHashCode() ^ this._m32.GetHashCode() ^ this._m33.GetHashCode();
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00080EB0 File Offset: 0x0007F0B0
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Matrix3F)
			{
				Matrix3F matrix3F = (Matrix3F)obj;
				result = (this._m11 == matrix3F.method_0() && this._m12 == matrix3F.method_1() && this._m13 == matrix3F.method_2() && this._m21 == matrix3F.method_3() && this._m22 == matrix3F.method_4() && this._m23 == matrix3F.method_5() && this._m31 == matrix3F.method_6() && this._m32 == matrix3F.method_7() && this._m33 == matrix3F.method_8());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00080F68 File Offset: 0x0007F168
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format("|{0}, {1}, {2}|\n", this._m11, this._m12, this._m13));
			stringBuilder.Append(string.Format("|{0}, {1}, {2}|\n", this._m21, this._m22, this._m23));
			stringBuilder.Append(string.Format("|{0}, {1}, {2}|\n", this._m31, this._m32, this._m33));
			return stringBuilder.ToString();
		}

		// Token: 0x0400073B RID: 1851
		private float _m11;

		// Token: 0x0400073C RID: 1852
		private float _m12;

		// Token: 0x0400073D RID: 1853
		private float _m13;

		// Token: 0x0400073E RID: 1854
		private float _m21;

		// Token: 0x0400073F RID: 1855
		private float _m22;

		// Token: 0x04000740 RID: 1856
		private float _m23;

		// Token: 0x04000741 RID: 1857
		private float _m31;

		// Token: 0x04000742 RID: 1858
		private float _m32;

		// Token: 0x04000743 RID: 1859
		private float _m33;

		// Token: 0x04000744 RID: 1860
		public static readonly Matrix3F Zero = new Matrix3F(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);

		// Token: 0x04000745 RID: 1861
		public static readonly Matrix3F Identity = new Matrix3F(1f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 1f);
	}
}
