using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Sharp3D.Math.Core;

namespace Sharp3D.Math.Geometry3D
{
	// Token: 0x020003F2 RID: 1010
	[Serializable]
	public struct OrientedBox : ICloneable, ISerializable
	{
		// Token: 0x06001923 RID: 6435 RVA: 0x00010720 File Offset: 0x0000E920
		public OrientedBox(Vector3F vector3F_0, Vector3F vector3F_1, Vector3F vector3F_2, Vector3F vector3F_3, float float_0, float float_1, float float_2)
		{
			this._center = vector3F_0;
			this._axis1 = vector3F_1;
			this._axis2 = vector3F_2;
			this._axis3 = vector3F_3;
			this._extent1 = float_0;
			this._extent2 = float_1;
			this._extent3 = float_2;
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x0009A058 File Offset: 0x00098258
		public OrientedBox(OrientedBox orientedBox_0)
		{
			this._center = orientedBox_0.method_0();
			this._axis1 = orientedBox_0.method_1();
			this._axis2 = orientedBox_0.method_2();
			this._axis3 = orientedBox_0.method_3();
			this._extent1 = orientedBox_0.method_4();
			this._extent2 = orientedBox_0.method_5();
			this._extent3 = orientedBox_0.method_6();
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x0009A0C0 File Offset: 0x000982C0
		private OrientedBox(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._center = (Vector3F)serializationInfo_0.GetValue("Center", typeof(Vector3F));
			this._axis1 = (Vector3F)serializationInfo_0.GetValue("Axis1", typeof(Vector3F));
			this._axis2 = (Vector3F)serializationInfo_0.GetValue("Axis2", typeof(Vector3F));
			this._axis3 = (Vector3F)serializationInfo_0.GetValue("Axis3", typeof(Vector3F));
			this._extent1 = serializationInfo_0.GetSingle("Extent1");
			this._extent2 = serializationInfo_0.GetSingle("Extent2");
			this._extent3 = serializationInfo_0.GetSingle("Extent3");
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x0009A180 File Offset: 0x00098380
		public Vector3F method_0()
		{
			return this._center;
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x0009A198 File Offset: 0x00098398
		public Vector3F method_1()
		{
			return this._axis1;
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x0009A1B0 File Offset: 0x000983B0
		public Vector3F method_2()
		{
			return this._axis2;
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x0009A1C8 File Offset: 0x000983C8
		public Vector3F method_3()
		{
			return this._axis3;
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x0009A1E0 File Offset: 0x000983E0
		public float method_4()
		{
			return this._extent1;
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x0009A1F8 File Offset: 0x000983F8
		public float method_5()
		{
			return this._extent2;
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0009A210 File Offset: 0x00098410
		public float method_6()
		{
			return this._extent3;
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0009A228 File Offset: 0x00098428
		object ICloneable.Clone()
		{
			return new OrientedBox(this);
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x0009A248 File Offset: 0x00098448
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Center", this._center, typeof(Vector3F));
			info.AddValue("Axis1", this._axis1, typeof(Vector3F));
			info.AddValue("Axis2", this._axis2, typeof(Vector3F));
			info.AddValue("Axis3", this._axis3, typeof(Vector3F));
			info.AddValue("Extent1", this._extent1, typeof(Vector3F));
			info.AddValue("Extent2", this._extent2, typeof(Vector3F));
			info.AddValue("Extent3", this._extent3, typeof(Vector3F));
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0009A338 File Offset: 0x00098538
		public static OrientedBox smethod_0(string string_0)
		{
			Regex regex = new Regex("OrientedBox\\(Center=(?<center>\\([^\\)]*\\)), Axis1=(?<axis1>\\([^\\)]*\\)), Axis2=(?<axis2>\\([^\\)]*\\)), Axis3=(?<axis3>\\([^\\)]*\\)), Extent1=(?<extent1>.*), Extent2=(?<extent2>.*), Extent3=(?<extent3>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new OrientedBox(Vector3F.smethod_0(match.Result("${center}")), Vector3F.smethod_0(match.Result("${axis1}")), Vector3F.smethod_0(match.Result("${axis2}")), Vector3F.smethod_0(match.Result("${axis3}")), float.Parse(match.Result("${extent1}")), float.Parse(match.Result("${extent2}")), float.Parse(match.Result("${extent3}")));
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x0009A3E4 File Offset: 0x000985E4
		public override int GetHashCode()
		{
			return this._center.GetHashCode() ^ this._axis1.GetHashCode() ^ this._axis2.GetHashCode() ^ this._axis3.GetHashCode() ^ this._extent1.GetHashCode() ^ this._extent2.GetHashCode() ^ this._extent3.GetHashCode();
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x0009A460 File Offset: 0x00098660
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is OrientedBox)
			{
				OrientedBox orientedBox = (OrientedBox)obj;
				result = (Vector3F.smethod_2(this._center, orientedBox.method_0()) && Vector3F.smethod_2(this._axis1, orientedBox.method_1()) && Vector3F.smethod_2(this._axis2, orientedBox.method_2()) && Vector3F.smethod_2(this._axis3, orientedBox.method_3()) && this._extent1 == orientedBox.method_4() && this._extent2 == orientedBox.method_5() && this._extent3 == orientedBox.method_6());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0009A50C File Offset: 0x0009870C
		public override string ToString()
		{
			return string.Format("OrientedBox(Center={0}, Axis1={1}, Axis2={2}, Axis3={3}, Extent1={4}, Extent2={5}, Extent3={6})", new object[]
			{
				this.method_0(),
				this.method_1(),
				this.method_2(),
				this.method_3(),
				this.method_4(),
				this.method_5(),
				this.method_6()
			});
		}

		// Token: 0x04000A48 RID: 2632
		private Vector3F _center;

		// Token: 0x04000A49 RID: 2633
		private Vector3F _axis1;

		// Token: 0x04000A4A RID: 2634
		private Vector3F _axis2;

		// Token: 0x04000A4B RID: 2635
		private Vector3F _axis3;

		// Token: 0x04000A4C RID: 2636
		private float _extent1;

		// Token: 0x04000A4D RID: 2637
		private float _extent2;

		// Token: 0x04000A4E RID: 2638
		private float _extent3;
	}
}
