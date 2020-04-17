using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000397 RID: 919
	[Serializable]
	public struct Vector4F : ICloneable, ISerializable
	{
		// Token: 0x170001D7 RID: 471
		public float this[int int_0]
		{
			get
			{
				float result;
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

		// Token: 0x0600163E RID: 5694 RVA: 0x0000F452 File Offset: 0x0000D652
		public Vector4F(float float_0, float float_1, float float_2, float float_3)
		{
			this._x = float_0;
			this._y = float_1;
			this._z = float_2;
			this._w = float_3;
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0000F471 File Offset: 0x0000D671
		public Vector4F(Vector4F vector4F_0)
		{
			this._x = vector4F_0.method_0();
			this._y = vector4F_0.method_1();
			this._z = vector4F_0.method_2();
			this._w = vector4F_0.method_3();
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0008E0C0 File Offset: 0x0008C2C0
		private Vector4F(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._x = serializationInfo_0.GetSingle("X");
			this._y = serializationInfo_0.GetSingle("Y");
			this._z = serializationInfo_0.GetSingle("Z");
			this._w = serializationInfo_0.GetSingle("W");
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0008E114 File Offset: 0x0008C314
		public float method_0()
		{
			return this._x;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0008E12C File Offset: 0x0008C32C
		public float method_1()
		{
			return this._y;
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0008E144 File Offset: 0x0008C344
		public float method_2()
		{
			return this._z;
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0008E15C File Offset: 0x0008C35C
		public float method_3()
		{
			return this._w;
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0008E174 File Offset: 0x0008C374
		object ICloneable.Clone()
		{
			return new Vector4F(this);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0008E194 File Offset: 0x0008C394
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("X", this._x);
			info.AddValue("Y", this._y);
			info.AddValue("Z", this._z);
			info.AddValue("W", this._w);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x0008E1E8 File Offset: 0x0008C3E8
		public static Vector4F smethod_0(string string_0)
		{
			Regex regex = new Regex("\\((?<x>.*),(?<y>.*),(?<z>.*),(?<w>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new Vector4F(float.Parse(match.Result("${x}")), float.Parse(match.Result("${y}")), float.Parse(match.Result("${z}")), float.Parse(match.Result("${w}")));
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0008E264 File Offset: 0x0008C464
		public override int GetHashCode()
		{
			return this._x.GetHashCode() ^ this._y.GetHashCode() ^ this._z.GetHashCode() ^ this._w.GetHashCode();
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x0008E2A4 File Offset: 0x0008C4A4
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Vector4F)
			{
				Vector4F vector4F = (Vector4F)obj;
				result = (this._x == vector4F.method_0() && this._y == vector4F.method_1() && this._z == vector4F.method_2() && this._w == vector4F.method_3());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0008E30C File Offset: 0x0008C50C
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

		// Token: 0x0400093C RID: 2364
		private float _x;

		// Token: 0x0400093D RID: 2365
		private float _y;

		// Token: 0x0400093E RID: 2366
		private float _z;

		// Token: 0x0400093F RID: 2367
		private float _w;

		// Token: 0x04000940 RID: 2368
		public static readonly Vector4F Zero = new Vector4F(0f, 0f, 0f, 0f);

		// Token: 0x04000941 RID: 2369
		public static readonly Vector4F XAxis = new Vector4F(1f, 0f, 0f, 0f);

		// Token: 0x04000942 RID: 2370
		public static readonly Vector4F YAxis = new Vector4F(0f, 1f, 0f, 0f);

		// Token: 0x04000943 RID: 2371
		public static readonly Vector4F ZAxis = new Vector4F(0f, 0f, 1f, 0f);

		// Token: 0x04000944 RID: 2372
		public static readonly Vector4F WAxis = new Vector4F(0f, 0f, 0f, 1f);
	}
}
