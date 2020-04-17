using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Sharp3D.Math.Core;

namespace Sharp3D.Math.Geometry2D
{
	// Token: 0x020003E0 RID: 992
	[Serializable]
	public struct Circle : ICloneable, ISerializable
	{
		// Token: 0x060018B3 RID: 6323 RVA: 0x000104C6 File Offset: 0x0000E6C6
		public Circle(Vector2F vector2F_0, float float_0)
		{
			this.center = vector2F_0;
			this.radius = float_0;
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x000104D6 File Offset: 0x0000E6D6
		public Circle(Circle circle_0)
		{
			this.center = circle_0.center;
			this.radius = circle_0.radius;
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x000104F2 File Offset: 0x0000E6F2
		private Circle(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this.center = (Vector2F)serializationInfo_0.GetValue("Center", typeof(Vector2F));
			this.radius = serializationInfo_0.GetSingle("Radius");
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x000989FC File Offset: 0x00096BFC
		public Vector2F method_0()
		{
			return this.center;
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00010525 File Offset: 0x0000E725
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Center", this.center, typeof(Vector2F));
			info.AddValue("Radius", this.radius);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00098A14 File Offset: 0x00096C14
		object ICloneable.Clone()
		{
			return new Circle(this);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00098A34 File Offset: 0x00096C34
		public static Circle smethod_0(string string_0)
		{
			Regex regex = new Regex("Circle\\(Center=(?<center>\\([^\\)]*\\)), Radius=(?<radius>.*)\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new Circle(Vector2F.smethod_0(match.Result("${center}")), float.Parse(match.Result("${radius}")));
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00098A90 File Offset: 0x00096C90
		public override int GetHashCode()
		{
			return this.center.GetHashCode() ^ this.radius.GetHashCode();
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00098ABC File Offset: 0x00096CBC
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Circle)
			{
				Circle circle = (Circle)obj;
				result = (Vector2F.smethod_1(this.center, circle.method_0()) && this.radius == circle.radius);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00098B0C File Offset: 0x00096D0C
		public override string ToString()
		{
			return string.Format("Circle(Center={0}, Radius={1})", this.center, this.radius);
		}

		// Token: 0x04000A32 RID: 2610
		private Vector2F center;

		// Token: 0x04000A33 RID: 2611
		private float radius;

		// Token: 0x04000A34 RID: 2612
		public static readonly Circle UnitCircle = new Circle(new Vector2F(0f, 0f), 1f);
	}
}
