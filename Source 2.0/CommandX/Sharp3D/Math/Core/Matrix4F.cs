using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000320 RID: 800
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public struct Matrix4F : ICloneable, ISerializable
	{
		// Token: 0x170001A0 RID: 416
		public unsafe float this[int int_0]
		{
			get
			{
				if (int_0 >= 0 && int_0 < 16)
				{
                    //return (&this._m11)[int_0];
                    fixed (float* ptr = &this._m11)
                    {
                        return ptr[int_0];
                    }
                }
				throw new IndexOutOfRangeException("Invalid matrix index!");
			}
			set
			{
				if (int_0 < 0 || int_0 >= 16)
				{
					throw new IndexOutOfRangeException("Invalid matrix index!");
				}
				fixed (float* ptr = &this._m11)
				{
					ptr[int_0] = value;
				}
			}
		}

		// Token: 0x170001A1 RID: 417
		public float this[int int_0, int int_1]
		{
			get
			{
				return this[(int_0 - 1) * 4 + (int_1 - 1)];
			}
			set
			{
				this[(int_0 - 1) * 4 + (int_1 - 1)] = value;
			}
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00083C4C File Offset: 0x00081E4C
		public Matrix4F(float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, float float_6, float float_7, float float_8, float float_9, float float_10, float float_11, float float_12, float float_13, float float_14, float float_15)
		{
			this._m11 = float_0;
			this._m12 = float_1;
			this._m13 = float_2;
			this._m14 = float_3;
			this._m21 = float_4;
			this._m22 = float_5;
			this._m23 = float_6;
			this._m24 = float_7;
			this._m31 = float_8;
			this._m32 = float_9;
			this._m33 = float_10;
			this._m34 = float_11;
			this._m41 = float_12;
			this._m42 = float_13;
			this._m43 = float_14;
			this._m44 = float_15;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00083CD8 File Offset: 0x00081ED8
		public Matrix4F(Matrix4F matrix4F_0)
		{
			this._m11 = matrix4F_0.method_0();
			this._m12 = matrix4F_0.method_1();
			this._m13 = matrix4F_0.method_2();
			this._m14 = matrix4F_0.method_3();
			this._m21 = matrix4F_0.method_4();
			this._m22 = matrix4F_0.method_5();
			this._m23 = matrix4F_0.method_6();
			this._m24 = matrix4F_0.method_7();
			this._m31 = matrix4F_0.method_8();
			this._m32 = matrix4F_0.method_9();
			this._m33 = matrix4F_0.method_10();
			this._m34 = matrix4F_0.method_11();
			this._m41 = matrix4F_0.method_12();
			this._m42 = matrix4F_0.method_13();
			this._m43 = matrix4F_0.method_14();
			this._m44 = matrix4F_0.method_15();
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00083DB8 File Offset: 0x00081FB8
		private Matrix4F(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._m11 = serializationInfo_0.GetSingle("M11");
			this._m12 = serializationInfo_0.GetSingle("M12");
			this._m13 = serializationInfo_0.GetSingle("M13");
			this._m14 = serializationInfo_0.GetSingle("M14");
			this._m21 = serializationInfo_0.GetSingle("M21");
			this._m22 = serializationInfo_0.GetSingle("M22");
			this._m23 = serializationInfo_0.GetSingle("M23");
			this._m24 = serializationInfo_0.GetSingle("M24");
			this._m31 = serializationInfo_0.GetSingle("M31");
			this._m32 = serializationInfo_0.GetSingle("M32");
			this._m33 = serializationInfo_0.GetSingle("M33");
			this._m34 = serializationInfo_0.GetSingle("M34");
			this._m41 = serializationInfo_0.GetSingle("M41");
			this._m42 = serializationInfo_0.GetSingle("M42");
			this._m43 = serializationInfo_0.GetSingle("M43");
			this._m44 = serializationInfo_0.GetSingle("M44");
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00083ED8 File Offset: 0x000820D8
		object ICloneable.Clone()
		{
			return new Matrix4F(this);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00083EF8 File Offset: 0x000820F8
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("M11", this._m11);
			info.AddValue("M12", this._m12);
			info.AddValue("M13", this._m13);
			info.AddValue("M14", this._m14);
			info.AddValue("M21", this._m21);
			info.AddValue("M22", this._m22);
			info.AddValue("M23", this._m23);
			info.AddValue("M24", this._m24);
			info.AddValue("M31", this._m31);
			info.AddValue("M32", this._m32);
			info.AddValue("M33", this._m33);
			info.AddValue("M34", this._m34);
			info.AddValue("M41", this._m41);
			info.AddValue("M42", this._m42);
			info.AddValue("M43", this._m43);
			info.AddValue("M44", this._m44);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00084018 File Offset: 0x00082218
		public float method_0()
		{
			return this._m11;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00084030 File Offset: 0x00082230
		public float method_1()
		{
			return this._m12;
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00084048 File Offset: 0x00082248
		public float method_2()
		{
			return this._m13;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00084060 File Offset: 0x00082260
		public float method_3()
		{
			return this._m14;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00084078 File Offset: 0x00082278
		public float method_4()
		{
			return this._m21;
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00084090 File Offset: 0x00082290
		public float method_5()
		{
			return this._m22;
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000840A8 File Offset: 0x000822A8
		public float method_6()
		{
			return this._m23;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x000840C0 File Offset: 0x000822C0
		public float method_7()
		{
			return this._m24;
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x000840D8 File Offset: 0x000822D8
		public float method_8()
		{
			return this._m31;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x000840F0 File Offset: 0x000822F0
		public float method_9()
		{
			return this._m32;
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00084108 File Offset: 0x00082308
		public float method_10()
		{
			return this._m33;
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00084120 File Offset: 0x00082320
		public float method_11()
		{
			return this._m34;
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00084138 File Offset: 0x00082338
		public float method_12()
		{
			return this._m41;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00084150 File Offset: 0x00082350
		public float method_13()
		{
			return this._m42;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00084168 File Offset: 0x00082368
		public float method_14()
		{
			return this._m43;
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00084180 File Offset: 0x00082380
		public float method_15()
		{
			return this._m44;
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00084198 File Offset: 0x00082398
		public override int GetHashCode()
		{
			return this._m11.GetHashCode() ^ this._m12.GetHashCode() ^ this._m13.GetHashCode() ^ this._m14.GetHashCode() ^ this._m21.GetHashCode() ^ this._m22.GetHashCode() ^ this._m23.GetHashCode() ^ this._m24.GetHashCode() ^ this._m31.GetHashCode() ^ this._m32.GetHashCode() ^ this._m33.GetHashCode() ^ this._m34.GetHashCode() ^ this._m41.GetHashCode() ^ this._m42.GetHashCode() ^ this._m43.GetHashCode() ^ this._m44.GetHashCode();
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00084268 File Offset: 0x00082468
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Matrix4F)
			{
				Matrix4F matrix4F = (Matrix4F)obj;
				result = (this._m11 == matrix4F.method_0() && this._m12 == matrix4F.method_1() && this._m13 == matrix4F.method_2() && this._m14 == matrix4F.method_3() && this._m21 == matrix4F.method_4() && this._m22 == matrix4F.method_5() && this._m23 == matrix4F.method_6() && this._m24 == matrix4F.method_7() && this._m31 == matrix4F.method_8() && this._m32 == matrix4F.method_9() && this._m33 == matrix4F.method_10() && this._m34 == matrix4F.method_11() && this._m41 == matrix4F.method_12() && this._m42 == matrix4F.method_13() && this._m43 == matrix4F.method_14() && this._m44 == matrix4F.method_15());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0008439C File Offset: 0x0008259C
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format("|{0}, {1}, {2}, {3}|\n", new object[]
			{
				this._m11,
				this._m12,
				this._m13,
				this._m14
			}));
			stringBuilder.Append(string.Format("|{0}, {1}, {2}, {3}|\n", new object[]
			{
				this._m21,
				this._m22,
				this._m23,
				this._m24
			}));
			stringBuilder.Append(string.Format("|{0}, {1}, {2}, {3}|\n", new object[]
			{
				this._m31,
				this._m32,
				this._m33,
				this._m34
			}));
			stringBuilder.Append(string.Format("|{0}, {1}, {2}, {3}|\n", new object[]
			{
				this._m41,
				this._m42,
				this._m43,
				this._m44
			}));
			return stringBuilder.ToString();
		}

		// Token: 0x040007CD RID: 1997
		private float _m11;

		// Token: 0x040007CE RID: 1998
		private float _m12;

		// Token: 0x040007CF RID: 1999
		private float _m13;

		// Token: 0x040007D0 RID: 2000
		private float _m14;

		// Token: 0x040007D1 RID: 2001
		private float _m21;

		// Token: 0x040007D2 RID: 2002
		private float _m22;

		// Token: 0x040007D3 RID: 2003
		private float _m23;

		// Token: 0x040007D4 RID: 2004
		private float _m24;

		// Token: 0x040007D5 RID: 2005
		private float _m31;

		// Token: 0x040007D6 RID: 2006
		private float _m32;

		// Token: 0x040007D7 RID: 2007
		private float _m33;

		// Token: 0x040007D8 RID: 2008
		private float _m34;

		// Token: 0x040007D9 RID: 2009
		private float _m41;

		// Token: 0x040007DA RID: 2010
		private float _m42;

		// Token: 0x040007DB RID: 2011
		private float _m43;

		// Token: 0x040007DC RID: 2012
		private float _m44;

		// Token: 0x040007DD RID: 2013
		public static readonly Matrix4F Zero = new Matrix4F(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);

		// Token: 0x040007DE RID: 2014
		public static readonly Matrix4F Identity = new Matrix4F(1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f);
	}
}
