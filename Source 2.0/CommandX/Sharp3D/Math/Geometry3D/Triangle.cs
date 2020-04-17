using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Sharp3D.Math.Core;

namespace Sharp3D.Math.Geometry3D
{
	// Token: 0x02000410 RID: 1040
	[Serializable]
	public struct Triangle : ICloneable, ISerializable
	{
		// Token: 0x1700022B RID: 555
		public Vector3F this[int int_0]
		{
			get
			{
				Vector3F result;
				switch (int_0)
				{
				case 0:
					result = this._p0;
					break;
				case 1:
					result = this._p1;
					break;
				case 2:
					result = this._p2;
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
					this._p0 = value;
					break;
				case 1:
					this._p1 = value;
					break;
				case 2:
					this._p2 = value;
					break;
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00010EE6 File Offset: 0x0000F0E6
		public Triangle(Vector3F vector3F_0, Vector3F vector3F_1, Vector3F vector3F_2)
		{
			this._p0 = vector3F_0;
			this._p1 = vector3F_1;
			this._p2 = vector3F_2;
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00010EFD File Offset: 0x0000F0FD
		public Triangle(Triangle triangle_0)
		{
			this._p0 = triangle_0._p0;
			this._p1 = triangle_0._p1;
			this._p2 = triangle_0._p2;
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0009F32C File Offset: 0x0009D52C
		private Triangle(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._p0 = (Vector3F)serializationInfo_0.GetValue("P0", typeof(Vector3F));
			this._p1 = (Vector3F)serializationInfo_0.GetValue("P1", typeof(Vector3F));
			this._p2 = (Vector3F)serializationInfo_0.GetValue("P2", typeof(Vector3F));
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0009F39C File Offset: 0x0009D59C
		object ICloneable.Clone()
		{
			return new Triangle(this);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0009F3BC File Offset: 0x0009D5BC
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("P0", this._p0, typeof(Vector3F));
			info.AddValue("P1", this._p1, typeof(Vector3F));
			info.AddValue("P2", this._p2, typeof(Vector3F));
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0009F42C File Offset: 0x0009D62C
		public static Triangle smethod_0(string string_0)
		{
			Regex regex = new Regex("Triangle\\((?<p1>\\([^\\)]*\\)), (?<p2>\\([^\\)]*\\)), (?<p3>\\([^\\)]*\\))\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new Triangle(Vector3F.smethod_0(match.Result("${p1}")), Vector3F.smethod_0(match.Result("${p2}")), Vector3F.smethod_0(match.Result("${p3}")));
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0009F498 File Offset: 0x0009D698
		public override int GetHashCode()
		{
			return this._p0.GetHashCode() ^ this._p1.GetHashCode() ^ this._p2.GetHashCode();
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0009F4DC File Offset: 0x0009D6DC
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Triangle)
			{
				Triangle triangle = (Triangle)obj;
				result = (Vector3F.smethod_2(this._p0, triangle.method_0()) && Vector3F.smethod_2(this._p1, triangle.method_1()) && Vector3F.smethod_2(this._p2, triangle.method_2()));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0009F544 File Offset: 0x0009D744
		public override string ToString()
		{
			return string.Format("Triangle({0}, {1}, {2})", this._p0, this._p1, this._p2);
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0009F580 File Offset: 0x0009D780
		public Vector3F method_0()
		{
			return this._p0;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0009F598 File Offset: 0x0009D798
		public Vector3F method_1()
		{
			return this._p1;
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0009F5B0 File Offset: 0x0009D7B0
		public Vector3F method_2()
		{
			return this._p2;
		}

		// Token: 0x04000B0C RID: 2828
		private Vector3F _p0;

		// Token: 0x04000B0D RID: 2829
		private Vector3F _p1;

		// Token: 0x04000B0E RID: 2830
		private Vector3F _p2;
	}
}
