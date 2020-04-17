using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Sharp3D.Math.Core
{
	// Token: 0x0200034E RID: 846
	[Serializable]
	public struct QuaternionD : ICloneable, ISerializable
	{
		// Token: 0x170001B5 RID: 437
		public double this[int int_0]
		{
			get
			{
				double result;
				switch (int_0)
				{
				case 0:
					result = this._w;
					break;
				case 1:
					result = this._x;
					break;
				case 2:
					result = this._y;
					break;
				case 3:
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
					this._w = value;
					break;
				case 1:
					this._x = value;
					break;
				case 2:
					this._y = value;
					break;
				case 3:
					this._z = value;
					break;
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0000E368 File Offset: 0x0000C568
		public QuaternionD(double double_0, double double_1, double double_2, double double_3)
		{
			this._w = double_0;
			this._x = double_1;
			this._y = double_2;
			this._z = double_3;
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0000E387 File Offset: 0x0000C587
		public QuaternionD(QuaternionD quaternionD_0)
		{
			this._w = quaternionD_0.method_0();
			this._x = quaternionD_0.method_1();
			this._y = quaternionD_0.method_2();
			this._z = quaternionD_0.method_3();
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00085478 File Offset: 0x00083678
		private QuaternionD(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._w = (double)serializationInfo_0.GetSingle("W");
			this._x = (double)serializationInfo_0.GetSingle("X");
			this._y = (double)serializationInfo_0.GetSingle("Y");
			this._z = (double)serializationInfo_0.GetSingle("Z");
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x000854D0 File Offset: 0x000836D0
		public double method_0()
		{
			return this._w;
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x000854E8 File Offset: 0x000836E8
		public double method_1()
		{
			return this._x;
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00085500 File Offset: 0x00083700
		public double method_2()
		{
			return this._y;
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x00085518 File Offset: 0x00083718
		public double method_3()
		{
			return this._z;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x00085530 File Offset: 0x00083730
		object ICloneable.Clone()
		{
			return new QuaternionD(this);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00085550 File Offset: 0x00083750
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("W", this._w);
			info.AddValue("X", this._x);
			info.AddValue("Y", this._y);
			info.AddValue("Z", this._z);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x000855A4 File Offset: 0x000837A4
		public static QuaternionD smethod_0(string string_0)
		{
			Regex regex = new Regex("\\((?<w>.*),(?<x>.*),(?<y>.*),(?<z>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new QuaternionD(double.Parse(match.Result("${w}")), double.Parse(match.Result("${x}")), double.Parse(match.Result("${y}")), double.Parse(match.Result("${z}")));
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00085620 File Offset: 0x00083820
		public override int GetHashCode()
		{
			return this._w.GetHashCode() ^ this._x.GetHashCode() ^ this._y.GetHashCode() ^ this._z.GetHashCode();
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x00085660 File Offset: 0x00083860
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is QuaternionD)
			{
				QuaternionD quaternionD = (QuaternionD)obj;
				result = (this._w == quaternionD.method_0() && this._x == quaternionD.method_1() && this._y == quaternionD.method_2() && this._z == quaternionD.method_3());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x000856C8 File Offset: 0x000838C8
		public override string ToString()
		{
			return string.Format("({0}, {1}, {2}, {3})", new object[]
			{
				this._w,
				this._x,
				this._y,
				this._z
			});
		}

		// Token: 0x0400082C RID: 2092
		private double _w;

		// Token: 0x0400082D RID: 2093
		private double _x;

		// Token: 0x0400082E RID: 2094
		private double _y;

		// Token: 0x0400082F RID: 2095
		private double _z;

		// Token: 0x04000830 RID: 2096
		public static readonly QuaternionD Zero = new QuaternionD(0.0, 0.0, 0.0, 0.0);

		// Token: 0x04000831 RID: 2097
		public static readonly QuaternionD Identity = new QuaternionD(1.0, 0.0, 0.0, 0.0);

		// Token: 0x04000832 RID: 2098
		public static readonly QuaternionD XAxis = new QuaternionD(0.0, 1.0, 0.0, 0.0);

		// Token: 0x04000833 RID: 2099
		public static readonly QuaternionD YAxis = new QuaternionD(0.0, 0.0, 1.0, 0.0);

		// Token: 0x04000834 RID: 2100
		public static readonly QuaternionD ZAxis = new QuaternionD(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04000835 RID: 2101
		public static readonly QuaternionD WAxis = new QuaternionD(1.0, 0.0, 0.0, 0.0);
	}
}
