using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;


namespace Sharp3D.Math.Core
{
	// Token: 0x02000387 RID: 903
	[Serializable]
	public struct Vector3D : ICloneable, ISerializable
	{
		// Token: 0x170001CF RID: 463
		public double this[int int_0]
		{
			get
			{
				double result;
				switch (int_0)
				{
				case 0:
					result = this._x;
					break;
				case 1:
					result = this._y;
					break;
				case 2:
					result = this._z;
					break;
				default:
					throw new IndexOutOfRangeException();
				}
				return result;
			}
			set
			{
				switch (int_0)
				{
				case 0:
					this._x = value;
					break;
				case 1:
					this._y = value;
					break;
				case 2:
					this._z = value;
					break;
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x0000F081 File Offset: 0x0000D281
		public Vector3D(double double_0, double double_1, double double_2)
		{
			this._x = double_0;
			this._y = double_1;
			this._z = double_2;
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0000F098 File Offset: 0x0000D298
		public Vector3D(Vector3D vector3D_0)
		{
			this._x = vector3D_0.method_0();
			this._y = vector3D_0.method_1();
			this._z = vector3D_0.method_2();
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x0000F0C1 File Offset: 0x0000D2C1
		private Vector3D(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._x = (double)serializationInfo_0.GetSingle("X");
			this._y = (double)serializationInfo_0.GetSingle("Y");
			this._z = (double)serializationInfo_0.GetSingle("Z");
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x0008C4A0 File Offset: 0x0008A6A0
		public double method_0()
		{
			return this._x;
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0008C4B8 File Offset: 0x0008A6B8
		public double method_1()
		{
			return this._y;
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0008C4D0 File Offset: 0x0008A6D0
		public double method_2()
		{
			return this._z;
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x0008C4E8 File Offset: 0x0008A6E8
		object ICloneable.Clone()
		{
			return new Vector3D(this);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x0000F0F9 File Offset: 0x0000D2F9
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("X", this._x);
			info.AddValue("Y", this._y);
			info.AddValue("Z", this._z);
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x0008C508 File Offset: 0x0008A708
		public static Vector3D smethod_0(string string_0)
		{
			Regex regex = new Regex("\\((?<x>.*),(?<y>.*),(?<z>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new Vector3D(double.Parse(match.Result("${x}")), double.Parse(match.Result("${y}")), double.Parse(match.Result("${z}")));
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x0008C574 File Offset: 0x0008A774
		public double method_3()
		{
			return System.Math.Sqrt(this._x * this._x + this._y * this._y + this._z * this._z);
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x0008C5B4 File Offset: 0x0008A7B4
		public override int GetHashCode()
		{
			return this._x.GetHashCode() ^ this._y.GetHashCode() ^ this._z.GetHashCode();
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x0008C5E8 File Offset: 0x0008A7E8
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Vector3D)
			{
				Vector3D vector3D = (Vector3D)obj;
				result = (this._x == vector3D.method_0() && this._y == vector3D.method_1() && this._z == vector3D.method_2());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x0008C640 File Offset: 0x0008A840
		public override string ToString()
		{
			return string.Format("({0}, {1}, {2})", this._x, this._y, this._z);
		}

		// Token: 0x04000902 RID: 2306
		private double _x;

		// Token: 0x04000903 RID: 2307
		private double _y;

		// Token: 0x04000904 RID: 2308
		private double _z;

		// Token: 0x04000905 RID: 2309
		public static readonly Vector3D Zero = new Vector3D(0.0, 0.0, 0.0);

		// Token: 0x04000906 RID: 2310
		public static readonly Vector3D XAxis = new Vector3D(1.0, 0.0, 0.0);

		// Token: 0x04000907 RID: 2311
		public static readonly Vector3D YAxis = new Vector3D(0.0, 1.0, 0.0);

		// Token: 0x04000908 RID: 2312
		public static readonly Vector3D ZAxis = new Vector3D(0.0, 0.0, 1.0);
	}
}
