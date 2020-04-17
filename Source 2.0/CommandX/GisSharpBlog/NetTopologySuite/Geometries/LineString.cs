using System;
using GeoAPI.Geometries;
using ns14;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000400 RID: 1024
	[Serializable]
	public class LineString : Geometry, IComparable<IGeometry>, IEquatable<IGeometry>, IComparable, ICloneable, IGeometry, Interface24, ILineString
	{
		// Token: 0x17000221 RID: 545
		public ICoordinate this[int int_0]
		{
			get
			{
				return this.points.imethod_0(int_0);
			}
			set
			{
				this.points.imethod_2(int_0, Enum142.const_0, value.imethod_0());
				this.points.imethod_2(int_0, Enum142.const_1, value.imethod_2());
				this.points.imethod_2(int_0, Enum142.const_2, value.imethod_4());
			}
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x0009D8FC File Offset: 0x0009BAFC
		public override ICoordinate[] imethod_6()
		{
			return this.points.imethod_3();
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x0009D918 File Offset: 0x0009BB18
		public ICoordinateSequence imethod_11()
		{
			return this.points;
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0009D930 File Offset: 0x0009BB30
		public LineString(ICoordinateSequence icoordinateSequence_0, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (icoordinateSequence_0 == null)
			{
				icoordinateSequence_0 = igeometryFactory_0.imethod_0().imethod_0(new ICoordinate[0]);
			}
			if (icoordinateSequence_0.Count == 1)
			{
				throw new ArgumentException("point array must contain 0 or >1 elements", "points");
			}
			this.points = icoordinateSequence_0;
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x0009D8E0 File Offset: 0x0009BAE0
		public ICoordinate imethod_13(int int_0)
		{
			return this.points.imethod_0(int_0);
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x0009D988 File Offset: 0x0009BB88
		public override ICoordinate imethod_5()
		{
			ICoordinate result;
			if (this.imethod_10())
			{
				result = null;
			}
			else
			{
				result = this.points.imethod_0(0);
			}
			return result;
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0000945D File Offset: 0x0000765D
		public override Dimensions imethod_7()
		{
			return Dimensions.Curve;
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x0009D9B4 File Offset: 0x0009BBB4
		public override Dimensions imethod_4()
		{
			Dimensions result;
			if (this.imethod_12())
			{
				result = Dimensions.False;
			}
			else
			{
				result = Dimensions.Point;
			}
			return result;
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00010AAA File Offset: 0x0000ECAA
		public override bool imethod_10()
		{
			return this.points.Count == 0;
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0009D9D8 File Offset: 0x0009BBD8
		public override int imethod_3()
		{
			return this.points.Count;
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00010ABA File Offset: 0x0000ECBA
		public virtual bool imethod_12()
		{
			return !this.imethod_10() && this.imethod_13(0).imethod_8(this.imethod_13(this.imethod_3() - 1));
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x0009D9F4 File Offset: 0x0009BBF4
		protected override IEnvelope vmethod_1()
		{
			IEnvelope result;
			if (this.imethod_10())
			{
				result = new Envelope();
			}
			else
			{
				ICoordinate[] array = this.points.imethod_3();
				double num = array[0].imethod_0();
				double num2 = array[0].imethod_2();
				double num3 = array[0].imethod_0();
				double num4 = array[0].imethod_2();
				for (int i = 1; i < array.Length; i++)
				{
					num = ((num < array[i].imethod_0()) ? num : array[i].imethod_0());
					num3 = ((num3 > array[i].imethod_0()) ? num3 : array[i].imethod_0());
					num2 = ((num2 < array[i].imethod_2()) ? num2 : array[i].imethod_2());
					num4 = ((num4 > array[i].imethod_2()) ? num4 : array[i].imethod_2());
				}
				result = new Envelope(num, num3, num2, num4);
			}
			return result;
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
		public  object Clone()
		{
			LineString lineString = (LineString)base.Clone();
			lineString.points = (ICoordinateSequence)this.points.Clone();
			return lineString;
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x0009DB0C File Offset: 0x0009BD0C
		protected internal override int vmethod_2(object object_0)
		{
			LineString lineString = (LineString)object_0;
			int num = 0;
			int num2 = 0;
			int result;
			while (num < this.points.Count && num2 < lineString.points.Count)
			{
				int num3 = this.points.imethod_0(num).CompareTo(lineString.points.imethod_0(num2));
				if (num3 != 0)
				{
					int num4 = num3;
					result = num4;
					return result;
				}
				num++;
				num2++;
			}
			if (num < this.points.Count)
			{
				result = 1;
				return result;
			}
			if (num2 < lineString.points.Count)
			{
				result = -1;
				return result;
			}
			result = 0;
			return result;
		}

		// Token: 0x04000A91 RID: 2705
		public static readonly ILineString Empty = new GeometryFactory().imethod_4(new ICoordinate[0]);

		// Token: 0x04000A92 RID: 2706
		private ICoordinateSequence points;
	}
}
