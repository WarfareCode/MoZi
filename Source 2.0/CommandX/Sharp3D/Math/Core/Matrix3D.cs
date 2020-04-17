using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace Sharp3D.Math.Core
{
	// Token: 0x020002DF RID: 735
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public struct Matrix3D : ICloneable, ISerializable
	{
		// Token: 0x17000181 RID: 385
		public unsafe double this[int int_0]
		{
			get
			{
				if (int_0 >= 0 && int_0 < 16)
				{
                    //return (&this._m11)[int_0];
                    fixed (double* ptr = &this._m11)
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
				fixed (double* ptr = &this._m11)
				{
					ptr[int_0] = value;
				}
			}
		}

		// Token: 0x17000182 RID: 386
		public double this[int int_0, int int_1]
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

		// Token: 0x0600111A RID: 4378 RVA: 0x0007EFA0 File Offset: 0x0007D1A0
		public Matrix3D(double double_0, double double_1, double double_2, double double_3, double double_4, double double_5, double double_6, double double_7, double double_8)
		{
			this._m11 = double_0;
			this._m12 = double_1;
			this._m13 = double_2;
			this._m21 = double_3;
			this._m22 = double_4;
			this._m23 = double_5;
			this._m31 = double_6;
			this._m32 = double_7;
			this._m33 = double_8;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0007EFF4 File Offset: 0x0007D1F4
		public Matrix3D(Matrix3D matrix3D_0)
		{
			this._m11 = matrix3D_0.method_0();
			this._m12 = matrix3D_0.method_2();
			this._m13 = matrix3D_0.method_3();
			this._m21 = matrix3D_0.method_5();
			this._m22 = matrix3D_0.method_6();
			this._m23 = matrix3D_0.method_8();
			this._m31 = matrix3D_0.method_10();
			this._m32 = matrix3D_0.method_12();
			this._m33 = matrix3D_0.method_14();
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0007F078 File Offset: 0x0007D278
		private Matrix3D(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._m11 = (double)serializationInfo_0.GetSingle("M11");
			this._m12 = (double)serializationInfo_0.GetSingle("M12");
			this._m13 = (double)serializationInfo_0.GetSingle("M13");
			this._m21 = (double)serializationInfo_0.GetSingle("M21");
			this._m22 = (double)serializationInfo_0.GetSingle("M22");
			this._m23 = (double)serializationInfo_0.GetSingle("M23");
			this._m31 = (double)serializationInfo_0.GetSingle("M31");
			this._m32 = (double)serializationInfo_0.GetSingle("M32");
			this._m33 = (double)serializationInfo_0.GetSingle("M33");
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0007F128 File Offset: 0x0007D328
		object ICloneable.Clone()
		{
			return new Matrix3D(this);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0007F148 File Offset: 0x0007D348
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

		// Token: 0x0600111F RID: 4383 RVA: 0x0007F1F0 File Offset: 0x0007D3F0
		public static Matrix3D smethod_0(Matrix3D matrix3D_0, Matrix3D matrix3D_1)
		{
			return new Matrix3D(matrix3D_0.method_0() * matrix3D_1.method_0() + matrix3D_0.method_2() * matrix3D_1.method_5() + matrix3D_0.method_3() * matrix3D_1.method_10(), matrix3D_0.method_0() * matrix3D_1.method_2() + matrix3D_0.method_2() * matrix3D_1.method_6() + matrix3D_0.method_3() * matrix3D_1.method_12(), matrix3D_0.method_0() * matrix3D_1.method_3() + matrix3D_0.method_2() * matrix3D_1.method_8() + matrix3D_0.method_3() * matrix3D_1.method_14(), matrix3D_0.method_5() * matrix3D_1.method_0() + matrix3D_0.method_6() * matrix3D_1.method_5() + matrix3D_0.method_8() * matrix3D_1.method_10(), matrix3D_0.method_5() * matrix3D_1.method_2() + matrix3D_0.method_6() * matrix3D_1.method_6() + matrix3D_0.method_8() * matrix3D_1.method_12(), matrix3D_0.method_5() * matrix3D_1.method_3() + matrix3D_0.method_6() * matrix3D_1.method_8() + matrix3D_0.method_8() * matrix3D_1.method_14(), matrix3D_0.method_10() * matrix3D_1.method_0() + matrix3D_0.method_12() * matrix3D_1.method_5() + matrix3D_0.method_14() * matrix3D_1.method_10(), matrix3D_0.method_10() * matrix3D_1.method_2() + matrix3D_0.method_12() * matrix3D_1.method_6() + matrix3D_0.method_14() * matrix3D_1.method_12(), matrix3D_0.method_10() * matrix3D_1.method_3() + matrix3D_0.method_12() * matrix3D_1.method_8() + matrix3D_0.method_14() * matrix3D_1.method_14());
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0007F3AC File Offset: 0x0007D5AC
		public static Vector3D smethod_1(Matrix3D matrix3D_0, Vector3D vector3D_0)
		{
			return new Vector3D(matrix3D_0.method_0() * vector3D_0.method_0() + matrix3D_0.method_2() * vector3D_0.method_1() + matrix3D_0.method_3() * vector3D_0.method_2(), matrix3D_0.method_5() * vector3D_0.method_0() + matrix3D_0.method_6() * vector3D_0.method_1() + matrix3D_0.method_8() * vector3D_0.method_2(), matrix3D_0.method_10() * vector3D_0.method_0() + matrix3D_0.method_12() * vector3D_0.method_1() + matrix3D_0.method_14() * vector3D_0.method_2());
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0007F450 File Offset: 0x0007D650
		public double method_0()
		{
			return this._m11;
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0000D09D File Offset: 0x0000B29D
		public void method_1(double double_0)
		{
			this._m11 = double_0;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0007F468 File Offset: 0x0007D668
		public double method_2()
		{
			return this._m12;
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0007F480 File Offset: 0x0007D680
		public double method_3()
		{
			return this._m13;
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0000D0A6 File Offset: 0x0000B2A6
		public void method_4(double double_0)
		{
			this._m13 = double_0;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0007F498 File Offset: 0x0007D698
		public double method_5()
		{
			return this._m21;
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0007F4B0 File Offset: 0x0007D6B0
		public double method_6()
		{
			return this._m22;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0000D0AF File Offset: 0x0000B2AF
		public void method_7(double double_0)
		{
			this._m22 = double_0;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0007F4C8 File Offset: 0x0007D6C8
		public double method_8()
		{
			return this._m23;
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0000D0B8 File Offset: 0x0000B2B8
		public void method_9(double double_0)
		{
			this._m23 = double_0;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0007F4E0 File Offset: 0x0007D6E0
		public double method_10()
		{
			return this._m31;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public void method_11(double double_0)
		{
			this._m31 = double_0;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0007F4F8 File Offset: 0x0007D6F8
		public double method_12()
		{
			return this._m32;
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0000D0CA File Offset: 0x0000B2CA
		public void method_13(double double_0)
		{
			this._m32 = double_0;
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0007F510 File Offset: 0x0007D710
		public double method_14()
		{
			return this._m33;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x0000D0D3 File Offset: 0x0000B2D3
		public void method_15(double double_0)
		{
			this._m33 = double_0;
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0007F528 File Offset: 0x0007D728
		public override int GetHashCode()
		{
			return this._m11.GetHashCode() ^ this._m12.GetHashCode() ^ this._m13.GetHashCode() ^ this._m21.GetHashCode() ^ this._m22.GetHashCode() ^ this._m23.GetHashCode() ^ this._m31.GetHashCode() ^ this._m32.GetHashCode() ^ this._m33.GetHashCode();
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0007F5A4 File Offset: 0x0007D7A4
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Matrix3D)
			{
				Matrix3D matrix3D = (Matrix3D)obj;
				result = (this._m11 == matrix3D.method_0() && this._m12 == matrix3D.method_2() && this._m13 == matrix3D.method_3() && this._m21 == matrix3D.method_5() && this._m22 == matrix3D.method_6() && this._m23 == matrix3D.method_8() && this._m31 == matrix3D.method_10() && this._m32 == matrix3D.method_12() && this._m33 == matrix3D.method_14());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x0007F65C File Offset: 0x0007D85C
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format("|{0}, {1}, {2}|\n", this._m11, this._m12, this._m13));
			stringBuilder.Append(string.Format("|{0}, {1}, {2}|\n", this._m21, this._m22, this._m23));
			stringBuilder.Append(string.Format("|{0}, {1}, {2}|\n", this._m31, this._m32, this._m33));
			return stringBuilder.ToString();
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0007F710 File Offset: 0x0007D910
		public static Matrix3D smethod_2(Matrix3D matrix3D_0, Matrix3D matrix3D_1)
		{
			return Matrix3D.smethod_0(matrix3D_0, matrix3D_1);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0007F728 File Offset: 0x0007D928
		public static Vector3D smethod_3(Matrix3D matrix3D_0, Vector3D vector3D_0)
		{
			return Matrix3D.smethod_1(matrix3D_0, vector3D_0);
		}

		// Token: 0x040006ED RID: 1773
		private double _m11;

		// Token: 0x040006EE RID: 1774
		private double _m12;

		// Token: 0x040006EF RID: 1775
		private double _m13;

		// Token: 0x040006F0 RID: 1776
		private double _m21;

		// Token: 0x040006F1 RID: 1777
		private double _m22;

		// Token: 0x040006F2 RID: 1778
		private double _m23;

		// Token: 0x040006F3 RID: 1779
		private double _m31;

		// Token: 0x040006F4 RID: 1780
		private double _m32;

		// Token: 0x040006F5 RID: 1781
		private double _m33;

		// Token: 0x040006F6 RID: 1782
		public static readonly Matrix3D Zero = new Matrix3D(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);

		// Token: 0x040006F7 RID: 1783
		public static readonly Matrix3D Identity = new Matrix3D(1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0);
	}
}
