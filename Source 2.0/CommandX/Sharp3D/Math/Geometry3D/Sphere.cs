using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Sharp3D.Math.Core;

namespace Sharp3D.Math.Geometry3D
{
	// Token: 0x0200040C RID: 1036
	[Serializable]
	public struct Sphere : ICloneable, ISerializable
	{
		// Token: 0x060019D6 RID: 6614 RVA: 0x00010CC5 File Offset: 0x0000EEC5
		public Sphere(Vector3F vector3F_0, float float_0)
		{
			this._center = vector3F_0;
			this._radius = float_0;
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00010CD5 File Offset: 0x0000EED5
		public Sphere(Sphere sphere_0)
		{
			this._center = sphere_0.method_0();
			this._radius = sphere_0.method_1();
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00010CF1 File Offset: 0x0000EEF1
		private Sphere(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._center = (Vector3F)serializationInfo_0.GetValue("Center", typeof(Vector3F));
			this._radius = serializationInfo_0.GetSingle("Radius");
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x0009E480 File Offset: 0x0009C680
		public Vector3F method_0()
		{
			return this._center;
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x0009E498 File Offset: 0x0009C698
		public float method_1()
		{
			return this._radius;
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00010D24 File Offset: 0x0000EF24
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Center", this._center, typeof(Vector3F));
			info.AddValue("Radius", this._radius);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0009E4B0 File Offset: 0x0009C6B0
		object ICloneable.Clone()
		{
			return new Sphere(this);
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0009E4D0 File Offset: 0x0009C6D0
		public static Sphere smethod_0(string string_0)
		{
			Regex regex = new Regex("Sphere\\(Center=(?<center>\\([^\\)]*\\)), Radius=(?<radius>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new Sphere(Vector3F.smethod_0(match.Result("${center}")), float.Parse(match.Result("${radius}")));
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x0009E52C File Offset: 0x0009C72C
		public override int GetHashCode()
		{
			return this._center.GetHashCode() ^ this._radius.GetHashCode();
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0009E558 File Offset: 0x0009C758
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Sphere)
			{
				Sphere sphere = (Sphere)obj;
				result = (Vector3F.smethod_2(this._center, sphere.method_0()) && this._radius == sphere.method_1());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0009E5A8 File Offset: 0x0009C7A8
		public override string ToString()
		{
			return string.Format("Sphere(Center={0}, Radius={1})", this._center, this._radius);
		}

		// Token: 0x04000AA5 RID: 2725
		private Vector3F _center;

		// Token: 0x04000AA6 RID: 2726
		private float _radius;
	}
}
