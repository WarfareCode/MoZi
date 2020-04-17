using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Sharp3D.Math.Core;

namespace Sharp3D.Math.Geometry3D
{
	// Token: 0x02000407 RID: 1031
	[Serializable]
	public struct Segment : ICloneable, ISerializable
	{
		// Token: 0x060019B7 RID: 6583 RVA: 0x00010C3B File Offset: 0x0000EE3B
		public Segment(Vector3F vector3F_0, Vector3F vector3F_1)
		{
			this._p0 = vector3F_0;
			this._p1 = vector3F_1;
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00010C4B File Offset: 0x0000EE4B
		public Segment(Segment segment_0)
		{
			this._p0 = segment_0.method_0();
			this._p1 = segment_0.method_1();
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x0009DF6C File Offset: 0x0009C16C
		private Segment(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._p0 = (Vector3F)serializationInfo_0.GetValue("P0", typeof(Vector3F));
			this._p1 = (Vector3F)serializationInfo_0.GetValue("P1", typeof(Vector3F));
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0009DFBC File Offset: 0x0009C1BC
		public Vector3F method_0()
		{
			return this._p0;
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0009DFD4 File Offset: 0x0009C1D4
		public Vector3F method_1()
		{
			return this._p1;
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0009DFEC File Offset: 0x0009C1EC
		object ICloneable.Clone()
		{
			return new Segment(this);
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0009E00C File Offset: 0x0009C20C
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("P0", this._p0, typeof(Vector3F));
			info.AddValue("P1", this._p1, typeof(Vector3F));
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0009E05C File Offset: 0x0009C25C
		public static Segment smethod_0(string string_0)
		{
			Regex regex = new Regex("Segment\\(P0=(?<p0>\\([^\\)]*\\)), P1=(?<p1>\\([^\\)]*\\))\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new Segment(Vector3F.smethod_0(match.Result("${p0}")), Vector3F.smethod_0(match.Result("${p1}")));
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0009E0B8 File Offset: 0x0009C2B8
		public override int GetHashCode()
		{
			return this._p0.GetHashCode() ^ this._p1.GetHashCode();
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0009E0EC File Offset: 0x0009C2EC
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Segment)
			{
				Segment segment = (Segment)obj;
				result = (Vector3F.smethod_2(this._p0, segment.method_0()) && Vector3F.smethod_2(this._p1, segment.method_1()));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x0009E140 File Offset: 0x0009C340
		public override string ToString()
		{
			return string.Format("Segment(P0={0}, P1={1})", this._p0, this._p1);
		}

		// Token: 0x04000A9E RID: 2718
		private Vector3F _p0;

		// Token: 0x04000A9F RID: 2719
		private Vector3F _p1;
	}
}
