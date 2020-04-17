using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000361 RID: 865
	[Serializable]
	public struct QuaternionF : ICloneable, ISerializable
	{
		// Token: 0x170001C1 RID: 449
		public float this[int int_0]
		{
			get
			{
				float result;
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

		// Token: 0x06001484 RID: 5252 RVA: 0x0000E8BA File Offset: 0x0000CABA
		public QuaternionF(float float_0, float float_1, float float_2, float float_3)
		{
			this._w = float_0;
			this._x = float_1;
			this._y = float_2;
			this._z = float_3;
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0000E8D9 File Offset: 0x0000CAD9
		public QuaternionF(QuaternionF quaternionF_0)
		{
			this._w = quaternionF_0.method_0();
			this._x = quaternionF_0.method_1();
			this._y = quaternionF_0.method_2();
			this._z = quaternionF_0.method_3();
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x000890A4 File Offset: 0x000872A4
		private QuaternionF(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._w = serializationInfo_0.GetSingle("W");
			this._x = serializationInfo_0.GetSingle("X");
			this._y = serializationInfo_0.GetSingle("Y");
			this._z = serializationInfo_0.GetSingle("Z");
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x000890F8 File Offset: 0x000872F8
		public float method_0()
		{
			return this._w;
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00089110 File Offset: 0x00087310
		public float method_1()
		{
			return this._x;
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00089128 File Offset: 0x00087328
		public float method_2()
		{
			return this._y;
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00089140 File Offset: 0x00087340
		public float method_3()
		{
			return this._z;
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00089158 File Offset: 0x00087358
		object ICloneable.Clone()
		{
			return new QuaternionF(this);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00089178 File Offset: 0x00087378
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("W", this._w);
			info.AddValue("X", this._x);
			info.AddValue("Y", this._y);
			info.AddValue("Z", this._z);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x000891CC File Offset: 0x000873CC
		public static QuaternionF smethod_0(string string_0)
		{
			Regex regex = new Regex("\\((?<w>.*),(?<x>.*),(?<y>.*),(?<z>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new QuaternionF(float.Parse(match.Result("${w}")), float.Parse(match.Result("${x}")), float.Parse(match.Result("${y}")), float.Parse(match.Result("${z}")));
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00089248 File Offset: 0x00087448
		public override int GetHashCode()
		{
			return this._w.GetHashCode() ^ this._x.GetHashCode() ^ this._y.GetHashCode() ^ this._z.GetHashCode();
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00089288 File Offset: 0x00087488
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is QuaternionF)
			{
				QuaternionF quaternionF = (QuaternionF)obj;
				result = (this._w == quaternionF.method_0() && this._x == quaternionF.method_1() && this._y == quaternionF.method_2() && this._z == quaternionF.method_3());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x000892F0 File Offset: 0x000874F0
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

		// Token: 0x040008AC RID: 2220
		private float _w;

		// Token: 0x040008AD RID: 2221
		private float _x;

		// Token: 0x040008AE RID: 2222
		private float _y;

		// Token: 0x040008AF RID: 2223
		private float _z;

		// Token: 0x040008B0 RID: 2224
		public static readonly QuaternionF Zero = new QuaternionF(0f, 0f, 0f, 0f);

		// Token: 0x040008B1 RID: 2225
		public static readonly QuaternionF Identity = new QuaternionF(1f, 0f, 0f, 0f);

		// Token: 0x040008B2 RID: 2226
		public static readonly QuaternionF XAxis = new QuaternionF(0f, 1f, 0f, 0f);

		// Token: 0x040008B3 RID: 2227
		public static readonly QuaternionF YAxis = new QuaternionF(0f, 0f, 1f, 0f);

		// Token: 0x040008B4 RID: 2228
		public static readonly QuaternionF ZAxis = new QuaternionF(0f, 0f, 0f, 1f);

		// Token: 0x040008B5 RID: 2229
		public static readonly QuaternionF WAxis = new QuaternionF(1f, 0f, 0f, 0f);
	}
}
