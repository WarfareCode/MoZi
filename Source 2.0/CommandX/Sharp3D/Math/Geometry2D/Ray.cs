using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Sharp3D.Math.Core;

namespace Sharp3D.Math.Geometry2D
{
	// Token: 0x020003EB RID: 1003
	[Serializable]
	public struct Ray : ICloneable, ISerializable
	{
		// Token: 0x060018F7 RID: 6391 RVA: 0x0001069F File Offset: 0x0000E89F
		public Ray(Vector2F vector2F_0, Vector2F vector2F_1)
		{
			this._origin = vector2F_0;
			this._direction = vector2F_1;
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x000106AF File Offset: 0x0000E8AF
		public Ray(Ray ray_0)
		{
			this._origin = ray_0.method_0();
			this._direction = ray_0.method_1();
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00099640 File Offset: 0x00097840
		private Ray(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._origin = (Vector2F)serializationInfo_0.GetValue("Origin", typeof(Vector2F));
			this._direction = (Vector2F)serializationInfo_0.GetValue("Direction", typeof(Vector2F));
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00099690 File Offset: 0x00097890
		public Vector2F method_0()
		{
			return this._origin;
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x000996A8 File Offset: 0x000978A8
		public Vector2F method_1()
		{
			return this._direction;
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x000996C0 File Offset: 0x000978C0
		object ICloneable.Clone()
		{
			return new Ray(this);
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x000996E0 File Offset: 0x000978E0
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Origin", this._origin, typeof(Vector2F));
			info.AddValue("Direction", this._direction, typeof(Vector2F));
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00099730 File Offset: 0x00097930
		public static Ray smethod_0(string string_0)
		{
			Regex regex = new Regex("Ray\\(Origin=(?<origin>\\([^\\)]*\\)), Direction=(?<direction>\\([^\\)]*\\))\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new Ray(Vector2F.smethod_0(match.Result("${origin}")), Vector2F.smethod_0(match.Result("${direction}")));
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0009978C File Offset: 0x0009798C
		public override int GetHashCode()
		{
			return this._origin.GetHashCode() ^ this._direction.GetHashCode();
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x000997C0 File Offset: 0x000979C0
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Ray)
			{
				Ray ray = (Ray)obj;
				result = (Vector2F.smethod_1(this._origin, ray.method_0()) && Vector2F.smethod_1(this._direction, ray.method_1()));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00099814 File Offset: 0x00097A14
		public override string ToString()
		{
			return string.Format("Ray(Origin={0}, Direction={1})", this._origin, this._direction);
		}

		// Token: 0x04000A40 RID: 2624
		private Vector2F _origin;

		// Token: 0x04000A41 RID: 2625
		private Vector2F _direction;
	}
}
