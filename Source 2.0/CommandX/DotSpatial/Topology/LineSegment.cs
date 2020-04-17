using System;
using System.Text;
using ns24;
using ns25;

namespace DotSpatial.Topology
{
	// Token: 0x020005F7 RID: 1527
	[Serializable]
	public class LineSegment : IComparable, ILineSegmentBase, Interface40
	{
		// Token: 0x0600268B RID: 9867 RVA: 0x00015C44 File Offset: 0x00013E44
		public LineSegment(Coordinate coordinate_0, Coordinate coordinate_1)
		{
			this._p0 = coordinate_0;
			this._p1 = coordinate_1;
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x00015C5A File Offset: 0x00013E5A
		public LineSegment(ILineSegmentBase interface39_0) : this(interface39_0.GetP0(), interface39_0.GetP1())
		{
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x00015C6E File Offset: 0x00013E6E
		public LineSegment() : this(new Coordinate(), new Coordinate())
		{
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x000EA508 File Offset: 0x000E8708
		public  Coordinate GetP1()
		{
			return this._p1;
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x00015C80 File Offset: 0x00013E80
		public virtual void SetP1(Coordinate value)
		{
			this._p1 = value;
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x000EA520 File Offset: 0x000E8720
		public  Coordinate GetP0()
		{
			return this._p0;
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00015C89 File Offset: 0x00013E89
		public virtual void SetP0(Coordinate value)
		{
			this._p0 = value;
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x000EA538 File Offset: 0x000E8738
		public virtual void SetCoordinates(Coordinate p0, Coordinate p1)
		{
			this.GetP0().X = p0.X;
			this.GetP0().Y = p0.Y;
			this.GetP1().X = p1.X;
			this.GetP1().Y = p1.Y;
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x00015C92 File Offset: 0x00013E92
		public virtual bool IsHorizontal()
		{
			return this.GetP0().Y == this.GetP1().Y;
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x000EA58C File Offset: 0x000E878C
		public virtual int OrientationIndex(ILineSegmentBase seg)
		{
			int num = CgAlgorithms.OrientationIndex(this.GetP0(), this.GetP1(), seg.GetP0());
			int num2 = CgAlgorithms.OrientationIndex(this.GetP0(), this.GetP1(), seg.GetP1());
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

		// Token: 0x06002695 RID: 9877 RVA: 0x000EA5FC File Offset: 0x000E87FC
		public virtual void Reverse()
		{
			Coordinate p = this.GetP0();
			this.SetP0(this.GetP1());
			this.SetP1(p);
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x000EA624 File Offset: 0x000E8824
		public  double Distance(Coordinate ls)
		{
			return CgAlgorithms.DistancePointLine(new Coordinate(ls), this.GetP0(), this.GetP1());
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x000EA64C File Offset: 0x000E884C
		public  double DistancePerpendicular(Coordinate p)
		{
			return CgAlgorithms.DistancePointLinePerpendicular(new Coordinate(p), this.GetP0(), this.GetP1());
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x000EA674 File Offset: 0x000E8874
		public  double ProjectionFactor(Coordinate p)
		{
			double result;
			if (p.Equals(this.GetP0()))
			{
				result = 0.0;
			}
			else if (p.Equals(this.GetP1()))
			{
				result = 1.0;
			}
			else
			{
				double num = this.GetP1().X - this.GetP0().X;
				double num2 = this.GetP1().Y - this.GetP0().Y;
				double num3 = num * num + num2 * num2;
				result = ((p.X - this.GetP0().X) * num + (p.Y - this.GetP0().Y) * num2) / num3;
			}
			return result;
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x000EA724 File Offset: 0x000E8924
		public  Coordinate Project(Coordinate coordinate_0)
		{
			Coordinate result;
			if (!coordinate_0.Equals(this.GetP0()) && !coordinate_0.Equals(this.GetP1()))
			{
				double num = this.ProjectionFactor(coordinate_0);
				result = new Coordinate
				{
					X = this.GetP0().X + num * (this.GetP1().X - this.GetP0().X),
					Y = this.GetP0().Y + num * (this.GetP1().Y - this.GetP0().Y)
				};
			}
			else
			{
				result = new Coordinate(coordinate_0);
			}
			return result;
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x000EA7C0 File Offset: 0x000E89C0
		public  Coordinate ClosestPoint(Coordinate p)
		{
			double num = this.ProjectionFactor(p);
			Coordinate result;
			if (num > 0.0 && num < 1.0)
			{
				result = this.Project(p);
			}
			else
			{
				double num2 = new Coordinate(this._p0).Distance(p);
				double num3 = new Coordinate(this.GetP1()).Distance(p);
				if (num2 < num3)
				{
					result = new Coordinate(this._p0);
				}
				else
				{
					result = new Coordinate(this._p1);
				}
			}
			return result;
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x000EA848 File Offset: 0x000E8A48
		public  Coordinate[] ClosestPoints(ILineSegmentBase line)
		{
			LineSegment lineSegment = new LineSegment(line);
			Coordinate coordinate = this.Intersection(line);
			Coordinate[] result;
			if (Coordinate.NotEquals(coordinate, null))
			{
				result = new Coordinate[]
				{
					coordinate,
					coordinate
				};
			}
			else
			{
				Coordinate[] array = new Coordinate[2];
				Coordinate coordinate2 = new Coordinate(this.ClosestPoint(line.GetP0()));
				double num = coordinate2.Distance(line.GetP0());
				array[0] = coordinate2;
				array[1] = new Coordinate(line.GetP0());
				Coordinate coordinate3 = new Coordinate(this.ClosestPoint(line.GetP1()));
				double num2 = coordinate3.Distance(line.GetP1());
				if (num2 < num)
				{
					num = num2;
					array[0] = coordinate3;
					array[1] = new Coordinate(line.GetP1());
				}
				Coordinate coordinate4 = new Coordinate(lineSegment.ClosestPoint(this.GetP0()));
				num2 = coordinate4.Distance(this.GetP0());
				if (num2 < num)
				{
					num = num2;
					array[0] = new Coordinate(this.GetP0());
					array[1] = coordinate4;
				}
				Coordinate coordinate5 = new Coordinate(lineSegment.ClosestPoint(this.GetP1()));
				num2 = coordinate5.Distance(this.GetP1());
				if (num2 < num)
				{
					array[0] = new Coordinate(this.GetP1());
					array[1] = coordinate5;
				}
				result = array;
			}
			return result;
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x000EA998 File Offset: 0x000E8B98
		public  Coordinate Intersection(ILineSegmentBase line)
		{
			LineIntersector lineIntersector = new RobustLineIntersector();
			lineIntersector.ComputeIntersection(this.GetP0(), this.GetP1(), new Coordinate(line.GetP0()), new Coordinate(line.GetP1()));
			Coordinate result;
			if (lineIntersector.HasIntersection())
			{
				result = lineIntersector.GetIntersection(0);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x000EA9EC File Offset: 0x000E8BEC
		public virtual int CompareTo(object target)
		{
			ILineSegmentBase lineSegmentBase = (ILineSegmentBase)target;
			int num = new Coordinate(this._p0).CompareTo(lineSegmentBase.GetP0());
			int result;
			if (num != 0)
			{
				result = num;
			}
			else
			{
				result = new Coordinate(this._p1).CompareTo(lineSegmentBase.GetP1());
			}
			return result;
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x000EAA3C File Offset: 0x000E8C3C
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder("LINESTRING( ");
			stringBuilder.Append(this.GetP0().X).Append(" ");
			stringBuilder.Append(this.GetP0().Y).Append(", ");
			stringBuilder.Append(this.GetP1().X).Append(" ");
			stringBuilder.Append(this.GetP1().Y).Append(")");
			return stringBuilder.ToString();
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x000EAACC File Offset: 0x000E8CCC
		public override bool Equals(object obj)
		{
			bool result;
			if (obj == null)
			{
				result = false;
			}
			else if (!(obj is ILineSegmentBase))
			{
				result = false;
			}
			else
			{
				ILineSegmentBase lineSegmentBase = (ILineSegmentBase)obj;
				result = (this._p0.X == lineSegmentBase.GetP0().X && this._p0.Y == lineSegmentBase.GetP0().Y && this._p1.X == lineSegmentBase.GetP1().X && this._p1.Y == lineSegmentBase.GetP1().Y);
			}
			return result;
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x0005CD70 File Offset: 0x0005AF70
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x04001274 RID: 4724
		private Coordinate _p0;

		// Token: 0x04001275 RID: 4725
		private Coordinate _p1;
	}
}
