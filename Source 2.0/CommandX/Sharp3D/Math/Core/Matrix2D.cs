using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace Sharp3D.Math.Core
{
	// Token: 0x020002BB RID: 699
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public struct Matrix2D : ICloneable, ISerializable
	{
		// Token: 0x17000170 RID: 368
		public unsafe double this[int int_0]
		{
			get
			{
                if (int_0 >= 0 && int_0 < 4)
				{
					//return (&this._m11)[int_0];

                    //ZSP return (&this._m11)[int_0];
                    fixed (double* ptr = &this._m11)
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
				fixed (double* ptr = &this._m11)
				{
					ptr[int_0] = value;
				}
			}
		}

		// Token: 0x17000171 RID: 369
		public double this[int int_0, int int_1]
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

		// Token: 0x0600105B RID: 4187 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		public Matrix2D(double double_0, double double_1, double double_2, double double_3)
		{
			this._m11 = double_0;
			this._m12 = double_1;
			this._m21 = double_2;
			this._m22 = double_3;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0000C9F3 File Offset: 0x0000ABF3
		public Matrix2D(Matrix2D matrix2D_0)
		{
			this._m11 = matrix2D_0.method_0();
			this._m12 = matrix2D_0.method_1();
			this._m21 = matrix2D_0.method_2();
			this._m22 = matrix2D_0.method_3();
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0007E19C File Offset: 0x0007C39C
		private Matrix2D(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._m11 = (double)serializationInfo_0.GetSingle("M11");
			this._m12 = (double)serializationInfo_0.GetSingle("M12");
			this._m21 = (double)serializationInfo_0.GetSingle("M21");
			this._m22 = (double)serializationInfo_0.GetSingle("M22");
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0007E1F4 File Offset: 0x0007C3F4
		object ICloneable.Clone()
		{
			return new Matrix2D(this);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0007E214 File Offset: 0x0007C414
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("M11", this._m11);
			info.AddValue("M12", this._m12);
			info.AddValue("M21", this._m21);
			info.AddValue("M22", this._m22);
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0007E268 File Offset: 0x0007C468
		public double method_0()
		{
			return this._m11;
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0007E280 File Offset: 0x0007C480
		public double method_1()
		{
			return this._m12;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0007E298 File Offset: 0x0007C498
		public double method_2()
		{
			return this._m21;
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0007E2B0 File Offset: 0x0007C4B0
		public double method_3()
		{
			return this._m22;
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0007E2C8 File Offset: 0x0007C4C8
		public override int GetHashCode()
		{
			return this._m11.GetHashCode() ^ this._m12.GetHashCode() ^ this._m21.GetHashCode() ^ this._m22.GetHashCode();
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0007E308 File Offset: 0x0007C508
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Matrix2D)
			{
				Matrix2D matrix2D = (Matrix2D)obj;
				result = (this._m11 == matrix2D.method_0() && this._m12 == matrix2D.method_1() && this._m11 == matrix2D.method_2() && this._m12 == matrix2D.method_3());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0007E370 File Offset: 0x0007C570
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format("|{0}, {1}|\n", this.method_0(), this.method_1()));
			stringBuilder.Append(string.Format("|{0}, {1}|\n", this.method_2(), this.method_3()));
			return stringBuilder.ToString();
		}

		// Token: 0x0400069B RID: 1691
		private double _m11;

		// Token: 0x0400069C RID: 1692
		private double _m12;

		// Token: 0x0400069D RID: 1693
		private double _m21;

		// Token: 0x0400069E RID: 1694
		private double _m22;

		// Token: 0x0400069F RID: 1695
		public static readonly Matrix2D Zero = new Matrix2D(0.0, 0.0, 0.0, 0.0);

		// Token: 0x040006A0 RID: 1696
		public static readonly Matrix2D Identity = new Matrix2D(1.0, 0.0, 0.0, 1.0);
	}
}
