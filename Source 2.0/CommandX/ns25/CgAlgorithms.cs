using System;
using System.Collections.Generic;
using DotSpatial.Topology;

namespace ns25
{
	// Token: 0x02000631 RID: 1585
	internal static class CgAlgorithms
	{
		// Token: 0x06002839 RID: 10297 RVA: 0x000F24D4 File Offset: 0x000F06D4
		public static int OrientationIndex(Coordinate p1, Coordinate p2, Coordinate q)
		{
			double x = p2.X - p1.X;
			double y = p2.Y - p1.Y;
			double x2 = q.X - p2.X;
			double y2 = q.Y - p2.Y;
			return RobustDeterminant.SignOfDet2X2(x, y, x2, y2);
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x000F2528 File Offset: 0x000F0728
		public static bool IsPointInRing(Coordinate p, IList<Coordinate> ring)
		{
			int num = 0;
			int count = ring.Count;
			for (int i = 1; i < count; i++)
			{
				int index = i - 1;
				Coordinate coordinate = ring[i];
				Coordinate coordinate2 = ring[index];
				double x = coordinate.X - p.X;
				double num2 = coordinate.Y - p.Y;
				double x2 = coordinate2.X - p.X;
				double num3 = coordinate2.Y - p.Y;
				if ((num2 > 0.0 && num3 <= 0.0) || (num3 > 0.0 && num2 <= 0.0))
				{
					double num4 = (double)RobustDeterminant.SignOfDet2X2(x, num2, x2, num3) / (num3 - num2);
					if (0.0 < num4)
					{
						num++;
					}
				}
			}
			return num % 2 == 1;
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x000F2618 File Offset: 0x000F0818
		public static bool IsOnLine(Coordinate p, IList<Coordinate> pt)
		{
			LineIntersector lineIntersector = new RobustLineIntersector();
			bool result;
			for (int i = 1; i < pt.Count; i++)
			{
				Coordinate coordinate_ = pt[i - 1];
				Coordinate coordinate_2 = pt[i];
				lineIntersector.ComputeIntersection(p, coordinate_, coordinate_2);
				if (lineIntersector.HasIntersection())
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x000F2670 File Offset: 0x000F0870
		public static bool IsCounterClockwise(IList<Coordinate> ring)
		{
			int num = ring.Count - 1;
			Coordinate coordinate = ring[0];
			int num2 = 0;
			for (int i = 1; i <= num; i++)
			{
				Coordinate coordinate2 = ring[i];
				if (coordinate2.Y > coordinate.Y)
				{
					coordinate = coordinate2;
					num2 = i;
				}
			}
			int num3 = num2;
			do
			{
				num3--;
				if (num3 < 0)
				{
					num3 = num;
				}
				if (!ring[num3].Equals2D(coordinate))
				{
					break;
				}
			}
			while (num3 != num2);
			int num4 = num2;
			do
			{
				num4 = (num4 + 1) % num;
			}
			while (ring[num4].Equals2D(coordinate) && num4 != num2);
			Coordinate coordinate3 = new Coordinate(ring[num3]);
			Coordinate coordinate4 = new Coordinate(ring[num4]);
			bool result;
			if (!coordinate3.Equals2D(coordinate) && !coordinate4.Equals2D(coordinate) && !coordinate3.Equals2D(coordinate4))
			{
				int num5 = CgAlgorithms.ComputeOrientation(coordinate3, new Coordinate(coordinate), coordinate4);
				bool flag;
				if (num5 == 0)
				{
					flag = (coordinate3.X > coordinate4.X);
				}
				else
				{
					flag = (num5 > 0);
				}
				result = flag;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x000F27A8 File Offset: 0x000F09A8
		public static int ComputeOrientation(Coordinate p1, Coordinate p2, Coordinate q)
		{
			return CgAlgorithms.OrientationIndex(p1, p2, q);
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x000F27C0 File Offset: 0x000F09C0
		public static double DistancePointLine(Coordinate p, Coordinate a, Coordinate b)
		{
			double result;
			if (a.Equals(b))
			{
				result = p.Distance(a);
			}
			else
			{
				double num = ((p.X - a.X) * (b.X - a.X) + (p.Y - a.Y) * (b.Y - a.Y)) / ((b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y));
				if (num <= 0.0)
				{
					result = p.Distance(a);
				}
				else if (num >= 1.0)
				{
					result = p.Distance(b);
				}
				else
				{
					double value = ((a.Y - p.Y) * (b.X - a.X) - (a.X - p.X) * (b.Y - a.Y)) / ((b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y));
					result = Math.Abs(value) * Math.Sqrt((b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y));
				}
			}
			return result;
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x000F2944 File Offset: 0x000F0B44
		public static double DistancePointLinePerpendicular(Coordinate p, Coordinate a, Coordinate b)
		{
			double value = ((a.Y - p.Y) * (b.X - a.X) - (a.X - p.X) * (b.Y - a.Y)) / ((b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y));
			return Math.Abs(value) * Math.Sqrt((b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y));
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x000F2A08 File Offset: 0x000F0C08
		public static double DistanceLineLine(Coordinate a, Coordinate b, Coordinate c, Coordinate d)
		{
			double result;
			if (a.Equals(b))
			{
				result = CgAlgorithms.DistancePointLine(a, c, d);
			}
			else if (c.Equals(d))
			{
				result = CgAlgorithms.DistancePointLine(d, a, b);
			}
			else
			{
				double num = (a.Y - c.Y) * (d.X - c.X) - (a.X - c.X) * (d.Y - c.Y);
				double num2 = (b.X - a.X) * (d.Y - c.Y) - (b.Y - a.Y) * (d.X - c.X);
				double num3 = (a.Y - c.Y) * (b.X - a.X) - (a.X - c.X) * (b.Y - a.Y);
				double num4 = (b.X - a.X) * (d.Y - c.Y) - (b.Y - a.Y) * (d.X - c.X);
				if (num2 != 0.0 && num4 != 0.0)
				{
					double num5 = num3 / num4;
					double num6 = num / num2;
					if (num6 >= 0.0 && num6 <= 1.0 && num5 >= 0.0 && num5 <= 1.0)
					{
						result = 0.0;
					}
					else
					{
						result = Math.Min(CgAlgorithms.DistancePointLine(a, c, d), Math.Min(CgAlgorithms.DistancePointLine(b, c, d), Math.Min(CgAlgorithms.DistancePointLine(c, a, b), CgAlgorithms.DistancePointLine(d, a, b))));
					}
				}
				else
				{
					result = Math.Min(CgAlgorithms.DistancePointLine(a, c, d), Math.Min(CgAlgorithms.DistancePointLine(b, c, d), Math.Min(CgAlgorithms.DistancePointLine(c, a, b), CgAlgorithms.DistancePointLine(d, a, b))));
				}
			}
			return result;
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x000F2C00 File Offset: 0x000F0E00
		public static double SignedArea(IList<Coordinate> ring)
		{
			double result;
			if (ring.Count < 3)
			{
				result = 0.0;
			}
			else
			{
				double num = 0.0;
				for (int i = 0; i < ring.Count - 1; i++)
				{
					double x = ring[i].X;
					double y = ring[i].Y;
					double x2 = ring[i + 1].X;
					double y2 = ring[i + 1].Y;
					num += (x + x2) * (y2 - y);
				}
				Coordinate coordinate = ring[ring.Count - 1];
				Coordinate coordinate2 = ring[0];
				if (coordinate2.X != coordinate.X && coordinate2.Y != coordinate.Y)
				{
					num += (coordinate.X + coordinate2.X) * (coordinate2.Y - coordinate.Y);
				}
				result = -num / 2.0;
			}
			return result;
		}
	}
}
