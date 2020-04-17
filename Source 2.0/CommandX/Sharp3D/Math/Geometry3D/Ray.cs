using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Sharp3D.Math.Core;

namespace Sharp3D.Math.Geometry3D
{
	// Token: 0x02000401 RID: 1025
	[Serializable]
	public struct Ray : ICloneable, ISerializable
	{
		// Token: 0x06001997 RID: 6551 RVA: 0x00010AF8 File Offset: 0x0000ECF8
		public Ray(Vector3F vector3F_0, Vector3F vector3F_1)
		{
			this._origin = vector3F_0;
			this._direction = vector3F_1;
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00010B08 File Offset: 0x0000ED08
		public Ray(Ray ray_0)
		{
			this._origin = ray_0.method_0();
			this._direction = ray_0.method_1();
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0009DBC0 File Offset: 0x0009BDC0
		private Ray(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._origin = (Vector3F)serializationInfo_0.GetValue("Origin", typeof(Vector3F));
			this._direction = (Vector3F)serializationInfo_0.GetValue("Direction", typeof(Vector3F));
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0009DC10 File Offset: 0x0009BE10
		public Vector3F method_0()
		{
			return this._origin;
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0009DC28 File Offset: 0x0009BE28
		public Vector3F method_1()
		{
			return this._direction;
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0009DC40 File Offset: 0x0009BE40
		object ICloneable.Clone()
		{
			return new Ray(this);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0009DC60 File Offset: 0x0009BE60
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Origin", this._origin, typeof(Vector3F));
			info.AddValue("Direction", this._direction, typeof(Vector3F));
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0009DCB0 File Offset: 0x0009BEB0
		public static Ray smethod_0(string string_0)
		{
			Regex regex = new Regex("Ray\\(Origin=(?<origin>\\([^\\)]*\\)), Direction=(?<direction>\\([^\\)]*\\))\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new Ray(Vector3F.smethod_0(match.Result("${origin}")), Vector3F.smethod_0(match.Result("${direction}")));
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0009DD0C File Offset: 0x0009BF0C
		public override int GetHashCode()
		{
			return this._origin.GetHashCode() ^ this._direction.GetHashCode();
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x0009DD40 File Offset: 0x0009BF40
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Ray)
			{
				Ray ray = (Ray)obj;
				result = (Vector3F.smethod_2(this._origin, ray.method_0()) && Vector3F.smethod_2(this._direction, ray.method_1()));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x0009DD94 File Offset: 0x0009BF94
		public override string ToString()
		{
			return string.Format("Ray(Origin={0}, Direction={1})", this._origin, this._direction);
		}

		// Token: 0x04000A93 RID: 2707
		private Vector3F _origin;

		// Token: 0x04000A94 RID: 2708
		private Vector3F _direction;
	}
}
