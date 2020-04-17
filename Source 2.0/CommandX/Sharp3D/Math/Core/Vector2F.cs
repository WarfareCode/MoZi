using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Sharp3D.Math.Core
{
	// Token: 0x0200037A RID: 890
	[Serializable]
	public struct Vector2F : ICloneable, ISerializable
	{
		// Token: 0x170001CE RID: 462
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
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x0000EEEB File Offset: 0x0000D0EB
		public Vector2F(float float_0, float float_1)
		{
			this._x = float_0;
			this._y = float_1;
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x0000EEFB File Offset: 0x0000D0FB
		public Vector2F(Vector2F vector2F_0)
		{
			this._x = vector2F_0.method_0();
			this._y = vector2F_0.method_1();
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x0000EF17 File Offset: 0x0000D117
		private Vector2F(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._x = serializationInfo_0.GetSingle("X");
			this._y = serializationInfo_0.GetSingle("Y");
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x0008B6EC File Offset: 0x000898EC
		public float method_0()
		{
			return this._x;
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x0008B704 File Offset: 0x00089904
		public float method_1()
		{
			return this._y;
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x0008B71C File Offset: 0x0008991C
		object ICloneable.Clone()
		{
			return new Vector2F(this);
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x0000EF3B File Offset: 0x0000D13B
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("X", this._x);
			info.AddValue("Y", this._y);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0008B73C File Offset: 0x0008993C
		public static Vector2F smethod_0(string string_0)
		{
			Regex regex = new Regex("\\((?<x>.*),(?<y>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new Vector2F(float.Parse(match.Result("${x}")), float.Parse(match.Result("${y}")));
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0008B798 File Offset: 0x00089998
		public override int GetHashCode()
		{
			return this._x.GetHashCode() ^ this._y.GetHashCode();
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x0008B7C0 File Offset: 0x000899C0
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Vector2F)
			{
				Vector2F vector2F = (Vector2F)obj;
				result = (this._x == vector2F.method_0() && this._y == vector2F.method_1());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0008B80C File Offset: 0x00089A0C
		public override string ToString()
		{
			return string.Format("({0}, {1})", this._x, this._y);
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0000EF5F File Offset: 0x0000D15F
		public static bool smethod_1(Vector2F vector2F_0, Vector2F vector2F_1)
		{
			return object.Equals(vector2F_0, vector2F_1);
		}

		// Token: 0x040008ED RID: 2285
		private float _x;

		// Token: 0x040008EE RID: 2286
		private float _y;

		// Token: 0x040008EF RID: 2287
		public static readonly Vector2F Zero = new Vector2F(0f, 0f);

		// Token: 0x040008F0 RID: 2288
		public static readonly Vector2F XAxis = new Vector2F(1f, 0f);

		// Token: 0x040008F1 RID: 2289
		public static readonly Vector2F YAxis = new Vector2F(0f, 1f);
	}
}
