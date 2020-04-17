using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000393 RID: 915
	[Serializable]
	public struct Vector4D : ICloneable, ISerializable
	{
		// Token: 0x170001D4 RID: 468
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
				case 3:
					result = this._w;
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
				case 3:
					this._w = value;
					break;
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x0000F348 File Offset: 0x0000D548
		public Vector4D(double double_0, double double_1, double double_2, double double_3)
		{
			this._x = double_0;
			this._y = double_1;
			this._z = double_2;
			this._w = double_3;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0000F367 File Offset: 0x0000D567
		public Vector4D(Vector4D vector4D_0)
		{
			this._x = vector4D_0.method_0();
			this._y = vector4D_0.method_1();
			this._z = vector4D_0.method_2();
			this._w = vector4D_0.method_3();
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x0008D854 File Offset: 0x0008BA54
		private Vector4D(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._x = (double)serializationInfo_0.GetSingle("X");
			this._y = (double)serializationInfo_0.GetSingle("Y");
			this._z = (double)serializationInfo_0.GetSingle("Z");
			this._w = (double)serializationInfo_0.GetSingle("W");
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x0008D8AC File Offset: 0x0008BAAC
		public double method_0()
		{
			return this._x;
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x0008D8C4 File Offset: 0x0008BAC4
		public double method_1()
		{
			return this._y;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x0008D8DC File Offset: 0x0008BADC
		public double method_2()
		{
			return this._z;
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x0008D8F4 File Offset: 0x0008BAF4
		public double method_3()
		{
			return this._w;
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x0008D90C File Offset: 0x0008BB0C
		object ICloneable.Clone()
		{
			return new Vector4D(this);
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0008D92C File Offset: 0x0008BB2C
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("X", this._x);
			info.AddValue("Y", this._y);
			info.AddValue("Z", this._z);
			info.AddValue("W", this._w);
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0008D980 File Offset: 0x0008BB80
		public static Vector4D smethod_0(string string_0)
		{
			Regex regex = new Regex("\\((?<x>.*),(?<y>.*),(?<z>.*),(?<w>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new Vector4D(double.Parse(match.Result("${x}")), double.Parse(match.Result("${y}")), double.Parse(match.Result("${z}")), double.Parse(match.Result("${w}")));
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0008D9FC File Offset: 0x0008BBFC
		public override int GetHashCode()
		{
			return this._x.GetHashCode() ^ this._y.GetHashCode() ^ this._z.GetHashCode() ^ this._w.GetHashCode();
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x0008DA3C File Offset: 0x0008BC3C
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Vector4D)
			{
				Vector4D vector4D = (Vector4D)obj;
				result = (this._x == vector4D.method_0() && this._y == vector4D.method_1() && this._z == vector4D.method_2() && this._w == vector4D.method_3());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x0008DAA4 File Offset: 0x0008BCA4
		public override string ToString()
		{
			return string.Format("({0}, {1}, {2}, {3})", new object[]
			{
				this._x,
				this._y,
				this._z,
				this._w
			});
		}

		// Token: 0x04000931 RID: 2353
		private double _x;

		// Token: 0x04000932 RID: 2354
		private double _y;

		// Token: 0x04000933 RID: 2355
		private double _z;

		// Token: 0x04000934 RID: 2356
		private double _w;

		// Token: 0x04000935 RID: 2357
		public static readonly Vector4D Zero = new Vector4D(0.0, 0.0, 0.0, 0.0);

		// Token: 0x04000936 RID: 2358
		public static readonly Vector4D XAxis = new Vector4D(1.0, 0.0, 0.0, 0.0);

		// Token: 0x04000937 RID: 2359
		public static readonly Vector4D YAxis = new Vector4D(0.0, 1.0, 0.0, 0.0);

		// Token: 0x04000938 RID: 2360
		public static readonly Vector4D ZAxis = new Vector4D(0.0, 0.0, 1.0, 0.0);

		// Token: 0x04000939 RID: 2361
		public static readonly Vector4D WAxis = new Vector4D(0.0, 0.0, 0.0, 1.0);
	}
}
