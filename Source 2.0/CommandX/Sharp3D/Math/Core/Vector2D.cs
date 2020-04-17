using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000371 RID: 881
	[Serializable]
	public struct Vector2D : ICloneable, ISerializable
	{
		// Token: 0x170001CA RID: 458
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

		// Token: 0x06001503 RID: 5379 RVA: 0x0000ECB9 File Offset: 0x0000CEB9
		public Vector2D(double double_0, double double_1)
		{
			this._x = double_0;
			this._y = double_1;
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x0000ECC9 File Offset: 0x0000CEC9
		public Vector2D(Vector2D vector2D_0)
		{
			this._x = vector2D_0.method_0();
			this._y = vector2D_0.method_1();
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x0000ECE5 File Offset: 0x0000CEE5
		private Vector2D(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._x = (double)serializationInfo_0.GetSingle("X");
			this._y = (double)serializationInfo_0.GetSingle("Y");
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x0008AB30 File Offset: 0x00088D30
		public double method_0()
		{
			return this._x;
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0008AB48 File Offset: 0x00088D48
		public double method_1()
		{
			return this._y;
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x0008AB60 File Offset: 0x00088D60
		object ICloneable.Clone()
		{
			return new Vector2D(this);
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0000ED0B File Offset: 0x0000CF0B
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("X", this._x);
			info.AddValue("Y", this._y);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0008AB80 File Offset: 0x00088D80
		public static Vector2D smethod_0(string string_0)
		{
			Regex regex = new Regex("\\((?<x>.*),(?<y>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new Vector2D(double.Parse(match.Result("${x}")), double.Parse(match.Result("${y}")));
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0008ABDC File Offset: 0x00088DDC
		public override int GetHashCode()
		{
			return this._x.GetHashCode() ^ this._y.GetHashCode();
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0008AC04 File Offset: 0x00088E04
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Vector2D)
			{
				Vector2D vector2D = (Vector2D)obj;
				result = (this._x == vector2D.method_0() && this._y == vector2D.method_1());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0008AC50 File Offset: 0x00088E50
		public override string ToString()
		{
			return string.Format("({0}, {1})", this._x, this._y);
		}

		// Token: 0x040008E1 RID: 2273
		private double _x;

		// Token: 0x040008E2 RID: 2274
		private double _y;

		// Token: 0x040008E3 RID: 2275
		public static readonly Vector2D Zero = new Vector2D(0.0, 0.0);

		// Token: 0x040008E4 RID: 2276
		public static readonly Vector2D XAxis = new Vector2D(1.0, 0.0);

		// Token: 0x040008E5 RID: 2277
		public static readonly Vector2D YAxis = new Vector2D(0.0, 1.0);
	}
}
