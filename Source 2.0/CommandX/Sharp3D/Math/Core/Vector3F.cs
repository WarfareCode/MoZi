using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Sharp3D.Math.Core
{
	// Token: 0x0200038C RID: 908
	[Serializable]
	[StructLayout(LayoutKind.Auto)]
	public struct Vector3F : ICloneable, ISerializable
	{
		// Token: 0x170001D1 RID: 465
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

		// Token: 0x060015DA RID: 5594 RVA: 0x0000F1B4 File Offset: 0x0000D3B4
		public Vector3F(float float_0, float float_1, float float_2)
		{
			this._x = float_0;
			this._y = float_1;
			this._z = float_2;
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x0000F1CB File Offset: 0x0000D3CB
		public Vector3F(Vector3F vector3F_0)
		{
			this._x = vector3F_0.method_0();
			this._y = vector3F_0.method_1();
			this._z = vector3F_0.method_2();
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0000F1F4 File Offset: 0x0000D3F4
		private Vector3F(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._x = serializationInfo_0.GetSingle("X");
			this._y = serializationInfo_0.GetSingle("Y");
			this._z = serializationInfo_0.GetSingle("Z");
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x0008CFD8 File Offset: 0x0008B1D8
		public float method_0()
		{
			return this._x;
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x0008CFF0 File Offset: 0x0008B1F0
		public float method_1()
		{
			return this._y;
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x0008D008 File Offset: 0x0008B208
		public float method_2()
		{
			return this._z;
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x0008D020 File Offset: 0x0008B220
		object ICloneable.Clone()
		{
			return new Vector3F(this);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x0000F229 File Offset: 0x0000D429
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("X", this._x);
			info.AddValue("Y", this._y);
			info.AddValue("Z", this._z);
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x0008D040 File Offset: 0x0008B240
		public static Vector3F smethod_0(string string_0)
		{
			Regex regex = new Regex("\\((?<x>.*),(?<y>.*),(?<z>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new Vector3F(float.Parse(match.Result("${x}")), float.Parse(match.Result("${y}")), float.Parse(match.Result("${z}")));
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x0008D0AC File Offset: 0x0008B2AC
		public static float smethod_1(Vector3F vector3F_0, Vector3F vector3F_1)
		{
			return vector3F_0.method_0() * vector3F_1.method_0() + vector3F_0.method_1() * vector3F_1.method_1() + vector3F_0.method_2() * vector3F_1.method_2();
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x0008D0EC File Offset: 0x0008B2EC
		public override int GetHashCode()
		{
			return this._x.GetHashCode() ^ this._y.GetHashCode() ^ this._z.GetHashCode();
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0008D120 File Offset: 0x0008B320
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Vector3F)
			{
				Vector3F vector3F = (Vector3F)obj;
				result = (this._x == vector3F.method_0() && this._y == vector3F.method_1() && this._z == vector3F.method_2());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x0008D178 File Offset: 0x0008B378
		public override string ToString()
		{
			return string.Format("({0}, {1}, {2})", this._x, this._y, this._z);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x0000F25E File Offset: 0x0000D45E
		public static bool smethod_2(Vector3F vector3F_0, Vector3F vector3F_1)
		{
			return object.Equals(vector3F_0, vector3F_1);
		}

		// Token: 0x0400091A RID: 2330
		private float _x;

		// Token: 0x0400091B RID: 2331
		private float _y;

		// Token: 0x0400091C RID: 2332
		private float _z;

		// Token: 0x0400091D RID: 2333
		public static readonly Vector3F Zero = new Vector3F(0f, 0f, 0f);

		// Token: 0x0400091E RID: 2334
		public static readonly Vector3F XAxis = new Vector3F(1f, 0f, 0f);

		// Token: 0x0400091F RID: 2335
		public static readonly Vector3F YAxis = new Vector3F(0f, 1f, 0f);

		// Token: 0x04000920 RID: 2336
		public static readonly Vector3F ZAxis = new Vector3F(0f, 0f, 1f);
	}
}
