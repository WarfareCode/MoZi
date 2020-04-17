using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Sharp3D.Math.Core;

namespace Sharp3D.Math.Geometry2D
{
	// Token: 0x020003E4 RID: 996
	[Serializable]
	public struct OrientedBox : ICloneable, ISerializable
	{
		// Token: 0x060018CC RID: 6348 RVA: 0x00010578 File Offset: 0x0000E778
		public OrientedBox(Vector2F vector2F_0, Vector2F vector2F_1, Vector2F vector2F_2, float float_0, float float_1)
		{
			this._center = vector2F_0;
			this._axis1 = vector2F_1;
			this._axis2 = vector2F_2;
			this._extent1 = float_0;
			this._extent2 = float_1;
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00098FEC File Offset: 0x000971EC
		public OrientedBox(OrientedBox orientedBox_0)
		{
			this._center = orientedBox_0.method_0();
			this._axis1 = orientedBox_0.method_1();
			this._axis2 = orientedBox_0.method_2();
			this._extent1 = orientedBox_0.method_3();
			this._extent2 = orientedBox_0.method_4();
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0009903C File Offset: 0x0009723C
		private OrientedBox(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._center = (Vector2F)serializationInfo_0.GetValue("Center", typeof(Vector2F));
			this._axis1 = (Vector2F)serializationInfo_0.GetValue("Axis1", typeof(Vector2F));
			this._axis2 = (Vector2F)serializationInfo_0.GetValue("Axis2", typeof(Vector2F));
			this._extent1 = serializationInfo_0.GetSingle("Extent1");
			this._extent2 = serializationInfo_0.GetSingle("Extent2");
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x000990CC File Offset: 0x000972CC
		public Vector2F method_0()
		{
			return this._center;
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x000990E4 File Offset: 0x000972E4
		public Vector2F method_1()
		{
			return this._axis1;
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x000990FC File Offset: 0x000972FC
		public Vector2F method_2()
		{
			return this._axis2;
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00099114 File Offset: 0x00097314
		public float method_3()
		{
			return this._extent1;
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0009912C File Offset: 0x0009732C
		public float method_4()
		{
			return this._extent2;
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00099144 File Offset: 0x00097344
		object ICloneable.Clone()
		{
			return new OrientedBox(this);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00099164 File Offset: 0x00097364
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Center", this._center, typeof(Vector2F));
			info.AddValue("Axis1", this._axis1, typeof(Vector2F));
			info.AddValue("Axis2", this._axis2, typeof(Vector2F));
			info.AddValue("Extent1", this._extent1, typeof(Vector2F));
			info.AddValue("Extent2", this._extent2, typeof(Vector2F));
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00099214 File Offset: 0x00097414
		public static OrientedBox smethod_0(string string_0)
		{
			Regex regex = new Regex("OrientedBox\\(Center=(?<center>\\([^\\)]*\\)), Axis1=(?<axis1>\\([^\\)]*\\)), Axis2=(?<axis2>\\([^\\)]*\\)), Extent1=(?<extent1>.*), Extent2=(?<extent2>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new OrientedBox(Vector2F.smethod_0(match.Result("${center}")), Vector2F.smethod_0(match.Result("${axis1}")), Vector2F.smethod_0(match.Result("${axis2}")), float.Parse(match.Result("${extent1}")), float.Parse(match.Result("${extent2}")));
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x000992A0 File Offset: 0x000974A0
		public override int GetHashCode()
		{
			return this._center.GetHashCode() ^ this._axis1.GetHashCode() ^ this._axis2.GetHashCode() ^ this._extent1.GetHashCode() ^ this._extent2.GetHashCode();
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x000992FC File Offset: 0x000974FC
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is OrientedBox)
			{
				OrientedBox orientedBox = (OrientedBox)obj;
				result = (Vector2F.smethod_1(this._center, orientedBox.method_0()) && Vector2F.smethod_1(this._axis1, orientedBox.method_1()) && Vector2F.smethod_1(this._axis2, orientedBox.method_2()) && this._extent1 == orientedBox.method_3() && this._extent2 == orientedBox.method_4());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00099384 File Offset: 0x00097584
		public override string ToString()
		{
			return string.Format("OrientedBox(Center={0}, Axis1={1}, Axis2={2}, Extent1={3}, Extent2={4})", new object[]
			{
				this.method_0(),
				this.method_1(),
				this.method_2(),
				this.method_3(),
				this.method_4()
			});
		}

		// Token: 0x04000A35 RID: 2613
		private Vector2F _center;

		// Token: 0x04000A36 RID: 2614
		private Vector2F _axis1;

		// Token: 0x04000A37 RID: 2615
		private Vector2F _axis2;

		// Token: 0x04000A38 RID: 2616
		private float _extent1;

		// Token: 0x04000A39 RID: 2617
		private float _extent2;
	}
}
