using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000307 RID: 775
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public struct Matrix4D : ICloneable, ISerializable
	{
		// Token: 0x17000194 RID: 404
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

		// Token: 0x17000195 RID: 405
		public double this[int int_0, int int_1]
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

		// Token: 0x06001211 RID: 4625 RVA: 0x000818C0 File Offset: 0x0007FAC0
		public Matrix4D(double double_0, double double_1, double double_2, double double_3, double double_4, double double_5, double double_6, double double_7, double double_8, double double_9, double double_10, double double_11, double double_12, double double_13, double double_14, double double_15)
		{
			this._m11 = double_0;
			this._m12 = double_1;
			this._m13 = double_2;
			this._m14 = double_3;
			this._m21 = double_4;
			this._m22 = double_5;
			this._m23 = double_6;
			this._m24 = double_7;
			this._m31 = double_8;
			this._m32 = double_9;
			this._m33 = double_10;
			this._m34 = double_11;
			this._m41 = double_12;
			this._m42 = double_13;
			this._m43 = double_14;
			this._m44 = double_15;
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x0008194C File Offset: 0x0007FB4C
		public Matrix4D(Matrix4D matrix4D_0)
		{
			this._m11 = matrix4D_0.method_0();
			this._m12 = matrix4D_0.method_1();
			this._m13 = matrix4D_0.method_2();
			this._m14 = matrix4D_0.method_3();
			this._m21 = matrix4D_0.method_4();
			this._m22 = matrix4D_0.method_5();
			this._m23 = matrix4D_0.method_6();
			this._m24 = matrix4D_0.method_7();
			this._m31 = matrix4D_0.method_8();
			this._m32 = matrix4D_0.method_9();
			this._m33 = matrix4D_0.method_10();
			this._m34 = matrix4D_0.method_11();
			this._m41 = matrix4D_0.method_12();
			this._m42 = matrix4D_0.method_13();
			this._m43 = matrix4D_0.method_14();
			this._m44 = matrix4D_0.method_15();
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00081A2C File Offset: 0x0007FC2C
		private Matrix4D(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._m11 = (double)serializationInfo_0.GetSingle("M11");
			this._m12 = (double)serializationInfo_0.GetSingle("M12");
			this._m13 = (double)serializationInfo_0.GetSingle("M13");
			this._m14 = (double)serializationInfo_0.GetSingle("M14");
			this._m21 = (double)serializationInfo_0.GetSingle("M21");
			this._m22 = (double)serializationInfo_0.GetSingle("M22");
			this._m23 = (double)serializationInfo_0.GetSingle("M23");
			this._m24 = (double)serializationInfo_0.GetSingle("M24");
			this._m31 = (double)serializationInfo_0.GetSingle("M31");
			this._m32 = (double)serializationInfo_0.GetSingle("M32");
			this._m33 = (double)serializationInfo_0.GetSingle("M33");
			this._m34 = (double)serializationInfo_0.GetSingle("M34");
			this._m41 = (double)serializationInfo_0.GetSingle("M41");
			this._m42 = (double)serializationInfo_0.GetSingle("M42");
			this._m43 = (double)serializationInfo_0.GetSingle("M43");
			this._m44 = (double)serializationInfo_0.GetSingle("M44");
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00081B5C File Offset: 0x0007FD5C
		object ICloneable.Clone()
		{
			return new Matrix4D(this);
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00081B7C File Offset: 0x0007FD7C
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

		// Token: 0x06001216 RID: 4630 RVA: 0x00081C9C File Offset: 0x0007FE9C
		public double method_0()
		{
			return this._m11;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00081CB4 File Offset: 0x0007FEB4
		public double method_1()
		{
			return this._m12;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00081CCC File Offset: 0x0007FECC
		public double method_2()
		{
			return this._m13;
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00081CE4 File Offset: 0x0007FEE4
		public double method_3()
		{
			return this._m14;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00081CFC File Offset: 0x0007FEFC
		public double method_4()
		{
			return this._m21;
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x00081D14 File Offset: 0x0007FF14
		public double method_5()
		{
			return this._m22;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00081D2C File Offset: 0x0007FF2C
		public double method_6()
		{
			return this._m23;
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00081D44 File Offset: 0x0007FF44
		public double method_7()
		{
			return this._m24;
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00081D5C File Offset: 0x0007FF5C
		public double method_8()
		{
			return this._m31;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00081D74 File Offset: 0x0007FF74
		public double method_9()
		{
			return this._m32;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x00081D8C File Offset: 0x0007FF8C
		public double method_10()
		{
			return this._m33;
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00081DA4 File Offset: 0x0007FFA4
		public double method_11()
		{
			return this._m34;
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00081DBC File Offset: 0x0007FFBC
		public double method_12()
		{
			return this._m41;
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00081DD4 File Offset: 0x0007FFD4
		public double method_13()
		{
			return this._m42;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00081DEC File Offset: 0x0007FFEC
		public double method_14()
		{
			return this._m43;
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00081E04 File Offset: 0x00080004
		public double method_15()
		{
			return this._m44;
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00081E1C File Offset: 0x0008001C
		public override int GetHashCode()
		{
			return this._m11.GetHashCode() ^ this._m12.GetHashCode() ^ this._m13.GetHashCode() ^ this._m14.GetHashCode() ^ this._m21.GetHashCode() ^ this._m22.GetHashCode() ^ this._m23.GetHashCode() ^ this._m24.GetHashCode() ^ this._m31.GetHashCode() ^ this._m32.GetHashCode() ^ this._m33.GetHashCode() ^ this._m34.GetHashCode() ^ this._m41.GetHashCode() ^ this._m42.GetHashCode() ^ this._m43.GetHashCode() ^ this._m44.GetHashCode();
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00081EEC File Offset: 0x000800EC
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Matrix4D)
			{
				Matrix4D matrix4D = (Matrix4D)obj;
				result = (this._m11 == matrix4D.method_0() && this._m12 == matrix4D.method_1() && this._m13 == matrix4D.method_2() && this._m14 == matrix4D.method_3() && this._m21 == matrix4D.method_4() && this._m22 == matrix4D.method_5() && this._m23 == matrix4D.method_6() && this._m24 == matrix4D.method_7() && this._m31 == matrix4D.method_8() && this._m32 == matrix4D.method_9() && this._m33 == matrix4D.method_10() && this._m34 == matrix4D.method_11() && this._m41 == matrix4D.method_12() && this._m42 == matrix4D.method_13() && this._m43 == matrix4D.method_14() && this._m44 == matrix4D.method_15());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00082020 File Offset: 0x00080220
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

		// Token: 0x0400076A RID: 1898
		private double _m11;

		// Token: 0x0400076B RID: 1899
		private double _m12;

		// Token: 0x0400076C RID: 1900
		private double _m13;

		// Token: 0x0400076D RID: 1901
		private double _m14;

		// Token: 0x0400076E RID: 1902
		private double _m21;

		// Token: 0x0400076F RID: 1903
		private double _m22;

		// Token: 0x04000770 RID: 1904
		private double _m23;

		// Token: 0x04000771 RID: 1905
		private double _m24;

		// Token: 0x04000772 RID: 1906
		private double _m31;

		// Token: 0x04000773 RID: 1907
		private double _m32;

		// Token: 0x04000774 RID: 1908
		private double _m33;

		// Token: 0x04000775 RID: 1909
		private double _m34;

		// Token: 0x04000776 RID: 1910
		private double _m41;

		// Token: 0x04000777 RID: 1911
		private double _m42;

		// Token: 0x04000778 RID: 1912
		private double _m43;

		// Token: 0x04000779 RID: 1913
		private double _m44;

		// Token: 0x0400077A RID: 1914
		public static readonly Matrix4D Zero = new Matrix4D(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);

		// Token: 0x0400077B RID: 1915
		public static readonly Matrix4D Identity = new Matrix4D(1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0);
	}
}
