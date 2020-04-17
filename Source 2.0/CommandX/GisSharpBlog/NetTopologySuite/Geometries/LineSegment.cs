using System;
using System.Text;
using GeoAPI.Geometries;
using ns13;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x020003DD RID: 989
	[Serializable]
	public sealed class LineSegment : IComparable
	{
		// Token: 0x0600189C RID: 6300 RVA: 0x0009857C File Offset: 0x0009677C
		public ICoordinate method_0()
		{
			return this.p1;
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00098594 File Offset: 0x00096794
		public ICoordinate method_1()
		{
			return this.p0;
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00010464 File Offset: 0x0000E664
		public LineSegment(ICoordinate icoordinate_0, ICoordinate icoordinate_1)
		{
			this.p0 = icoordinate_0;
			this.p1 = icoordinate_1;
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00010488 File Offset: 0x0000E688
		public LineSegment() : this(new Coordinate(), new Coordinate())
		{
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x000985AC File Offset: 0x000967AC
		public int method_2(LineSegment lineSegment_0)
		{
			int num = Class628.smethod_0(this.method_1(), this.method_0(), lineSegment_0.method_1());
			int num2 = Class628.smethod_0(this.method_1(), this.method_0(), lineSegment_0.method_0());
			int result;
			if (num >= 0 && num2 >= 0)
			{
				result = Math.Max(num, num2);
			}
			else if (num <= 0 && num2 <= 0)
			{
				result = Math.Max(num, num2);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00098620 File Offset: 0x00096820
		public override bool Equals(object obj)
		{
			bool result;
			if (obj == null)
			{
				result = false;
			}
			else if (!(obj is LineSegment))
			{
				result = false;
			}
			else
			{
				LineSegment lineSegment = (LineSegment)obj;
				result = (this.p0.Equals(lineSegment.p0) && this.p1.Equals(lineSegment.p1));
			}
			return result;
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0009867C File Offset: 0x0009687C
		public int CompareTo(object target)
		{
			LineSegment lineSegment = (LineSegment)target;
			int num = this.method_1().CompareTo(lineSegment.method_1());
			int result;
			if (num != 0)
			{
				result = num;
			}
			else
			{
				result = this.method_0().CompareTo(lineSegment.method_0());
			}
			return result;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x000986C4 File Offset: 0x000968C4
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder("LINESTRING( ");
			stringBuilder.Append(this.method_1().imethod_0()).Append(" ");
			stringBuilder.Append(this.method_1().imethod_2()).Append(", ");
			stringBuilder.Append(this.method_0().imethod_0()).Append(" ");
			stringBuilder.Append(this.method_0().imethod_2()).Append(")");
			return stringBuilder.ToString();
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0005CD70 File Offset: 0x0005AF70
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x04000A2F RID: 2607
		private ICoordinate p0 = null;

		// Token: 0x04000A30 RID: 2608
		private ICoordinate p1 = null;
	}
}
