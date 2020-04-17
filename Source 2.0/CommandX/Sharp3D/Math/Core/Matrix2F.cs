using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace Sharp3D.Math.Core
{
	// Token: 0x020002C6 RID: 710
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public struct Matrix2F : ICloneable, ISerializable
	{
		// Token: 0x17000177 RID: 375
		public unsafe float this[int int_0]
		{
			get
			{
				if (int_0 >= 0 && int_0 < 4)
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
				if (int_0 < 0 || int_0 >= 4)
				{
					throw new IndexOutOfRangeException("Invalid matrix index!");
				}
				fixed (float* ptr = &this._m11)
				{
					ptr[int_0] = value;
				}
			}
		}

		// Token: 0x17000178 RID: 376
		public float this[int int_0, int int_1]
		{
			get
			{
				return this[(int_0 - 1) * 2 + (int_1 - 1)];
			}
			set
			{
				this[(int_0 - 1) * 2 + (int_1 - 1)] = value;
			}
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0000CC24 File Offset: 0x0000AE24
		public Matrix2F(float float_0, float float_1, float float_2, float float_3)
		{
			this._m11 = float_0;
			this._m12 = float_1;
			this._m21 = float_2;
			this._m22 = float_3;
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0000CC43 File Offset: 0x0000AE43
		public Matrix2F(Matrix2F matrix2F_0)
		{
			this._m11 = matrix2F_0.method_0();
			this._m12 = matrix2F_0.method_1();
			this._m21 = matrix2F_0.method_2();
			this._m22 = matrix2F_0.method_3();
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0007E6F8 File Offset: 0x0007C8F8
		private Matrix2F(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._m11 = serializationInfo_0.GetSingle("M11");
			this._m12 = serializationInfo_0.GetSingle("M12");
			this._m21 = serializationInfo_0.GetSingle("M21");
			this._m22 = serializationInfo_0.GetSingle("M22");
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0007E74C File Offset: 0x0007C94C
		object ICloneable.Clone()
		{
			return new Matrix2F(this);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0007E76C File Offset: 0x0007C96C
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("M11", this._m11);
			info.AddValue("M12", this._m12);
			info.AddValue("M21", this._m21);
			info.AddValue("M22", this._m22);
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0007E7C0 File Offset: 0x0007C9C0
		public float method_0()
		{
			return this._m11;
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0007E7D8 File Offset: 0x0007C9D8
		public float method_1()
		{
			return this._m12;
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0007E7F0 File Offset: 0x0007C9F0
		public float method_2()
		{
			return this._m21;
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0007E808 File Offset: 0x0007CA08
		public float method_3()
		{
			return this._m22;
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0007E820 File Offset: 0x0007CA20
		public override int GetHashCode()
		{
			return this._m11.GetHashCode() ^ this._m12.GetHashCode() ^ this._m21.GetHashCode() ^ this._m22.GetHashCode();
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0007E860 File Offset: 0x0007CA60
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Matrix2F)
			{
				Matrix2F matrix2F = (Matrix2F)obj;
				result = (this._m11 == matrix2F.method_0() && this._m12 == matrix2F.method_1() && this._m11 == matrix2F.method_2() && this._m12 == matrix2F.method_3());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0007E8C8 File Offset: 0x0007CAC8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format("|{0}, {1}|\n", this.method_0(), this.method_1()));
			stringBuilder.Append(string.Format("|{0}, {1}|\n", this.method_2(), this.method_3()));
			return stringBuilder.ToString();
		}

		// Token: 0x040006B2 RID: 1714
		private float _m11;

		// Token: 0x040006B3 RID: 1715
		private float _m12;

		// Token: 0x040006B4 RID: 1716
		private float _m21;

		// Token: 0x040006B5 RID: 1717
		private float _m22;

		// Token: 0x040006B6 RID: 1718
		public static readonly Matrix2F Zero = new Matrix2F(0f, 0f, 0f, 0f);

		// Token: 0x040006B7 RID: 1719
		public static readonly Matrix2F Identity = new Matrix2F(1f, 0f, 0f, 1f);
	}
}
