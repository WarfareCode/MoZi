using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Sharp3D.Math.Core;

namespace Sharp3D.Math.Geometry3D
{
	// Token: 0x020003F4 RID: 1012
	[Serializable]
	public struct Plane : ICloneable, ISerializable
	{
		// Token: 0x06001938 RID: 6456 RVA: 0x00010757 File Offset: 0x0000E957
		public Plane(Vector3F vector3F_0, float float_0)
		{
			this._normal = vector3F_0;
			this._const = float_0;
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00010767 File Offset: 0x0000E967
		public Plane(Vector3F vector3F_0, Vector3F vector3F_1)
		{
			this._normal = vector3F_0;
			this._const = Vector3F.smethod_1(vector3F_0, vector3F_1);
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0001077D File Offset: 0x0000E97D
		public Plane(Plane plane_0)
		{
			this._normal = plane_0.method_0();
			this._const = plane_0.method_1();
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00010799 File Offset: 0x0000E999
		private Plane(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._normal = (Vector3F)serializationInfo_0.GetValue("Normal", typeof(Vector3F));
			this._const = serializationInfo_0.GetSingle("Constant");
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x0009A630 File Offset: 0x00098830
		public Vector3F method_0()
		{
			return this._normal;
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x0009A648 File Offset: 0x00098848
		public float method_1()
		{
			return this._const;
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x0009A660 File Offset: 0x00098860
		object ICloneable.Clone()
		{
			return new Plane(this);
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x000107CC File Offset: 0x0000E9CC
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Normal", this._normal, typeof(Vector3F));
			info.AddValue("Constant", this._const);
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0009A680 File Offset: 0x00098880
		public static Plane smethod_0(string string_0)
		{
			Regex regex = new Regex("Plane\\(n=(?<normal>\\([^\\)]*\\)), c=(?<const>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new Plane(Vector3F.smethod_0(match.Result("${normal}")), float.Parse(match.Result("${const}")));
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x0009A6DC File Offset: 0x000988DC
		public override int GetHashCode()
		{
			return this._normal.GetHashCode() ^ this._const.GetHashCode();
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0009A708 File Offset: 0x00098908
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Plane)
			{
				Plane plane = (Plane)obj;
				result = (Vector3F.smethod_2(this._normal, plane.method_0()) && this._const == plane.method_1());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x0009A758 File Offset: 0x00098958
		public override string ToString()
		{
			return string.Format("Plane[n={0}, c={1}]", this._normal, this._const);
		}

		// Token: 0x04000A4F RID: 2639
		private Vector3F _normal;

		// Token: 0x04000A50 RID: 2640
		private float _const;

		// Token: 0x04000A51 RID: 2641
		public static readonly Plane XPlane = new Plane(Vector3F.XAxis, Vector3F.Zero);

		// Token: 0x04000A52 RID: 2642
		public static readonly Plane YPlane = new Plane(Vector3F.YAxis, Vector3F.Zero);

		// Token: 0x04000A53 RID: 2643
		public static readonly Plane ZPlane = new Plane(Vector3F.ZAxis, Vector3F.Zero);
	}
}
