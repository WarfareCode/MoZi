using System;
using System.Diagnostics;
using DotSpatial.Topology;
using ns24;

namespace ns25
{
	// Token: 0x0200064B RID: 1611
	public sealed class RobustLineIntersector : LineIntersector
	{
		// Token: 0x06002955 RID: 10581 RVA: 0x000FCF50 File Offset: 0x000FB150
		public override void ComputeIntersection(Coordinate p, Coordinate p1, Coordinate p2)
		{
			this.SetIsProper(false);
			if (Envelope.Intersects(p1, p2, p) && CgAlgorithms.OrientationIndex(p1, p2, p) == 0 && CgAlgorithms.OrientationIndex(p2, p1, p) == 0)
			{
				this.SetIsProper(true);
				if (p.Equals(p1) || p.Equals(p2))
				{
					this.SetIsProper(false);
				}
				base.SetResult(IntersectionType.PointIntersection);
			}
			else
			{
				base.SetResult(IntersectionType.NoIntersection);
			}
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x000FCFC4 File Offset: 0x000FB1C4
		public override IntersectionType ComputeIntersect(Coordinate p1, Coordinate p2, Coordinate q1, Coordinate q2)
		{
			this.SetIsProper(false);
			IntersectionType result;
			if (!Envelope.Intersects(p1, p2, q1, q2))
			{
				result = IntersectionType.NoIntersection;
			}
			else
			{
				int num = CgAlgorithms.OrientationIndex(p1, p2, q1);
				int num2 = CgAlgorithms.OrientationIndex(p1, p2, q2);
				if ((num > 0 && num2 > 0) || (num < 0 && num2 < 0))
				{
					result = IntersectionType.NoIntersection;
				}
				else
				{
					int num3 = CgAlgorithms.OrientationIndex(q1, q2, p1);
					int num4 = CgAlgorithms.OrientationIndex(q1, q2, p2);
					if ((num3 > 0 && num4 > 0) || (num3 < 0 && num4 < 0))
					{
						result = IntersectionType.NoIntersection;
					}
					else if (num == 0 && num2 == 0 && num3 == 0 && num4 == 0)
					{
						result = this.ComputeCollinearIntersection(p1, p2, q1, q2);
					}
					else
					{
						if (num != 0 && num2 != 0 && num3 != 0 && num4 != 0)
						{
							this.SetIsProper(true);
							base.method_0()[0] = this.Intersection(p1, p2, q1, q2);
						}
						else
						{
							this.SetIsProper(false);
							if (num == 0)
							{
								base.method_0()[0] = new Coordinate(q1);
							}
							if (num2 == 0)
							{
								base.method_0()[0] = new Coordinate(q2);
							}
							if (num3 == 0)
							{
								base.method_0()[0] = new Coordinate(p1);
							}
							if (num4 == 0)
							{
								base.method_0()[0] = new Coordinate(p2);
							}
						}
						result = IntersectionType.PointIntersection;
					}
				}
			}
			return result;
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x000FD118 File Offset: 0x000FB318
		private IntersectionType ComputeCollinearIntersection(Coordinate p1, Coordinate p2, Coordinate p3, Coordinate p4)
		{
			bool flag = Envelope.Intersects(p1, p2, p3);
			bool flag2 = Envelope.Intersects(p1, p2, p4);
			bool flag3 = Envelope.Intersects(p3, p4, p1);
			bool flag4 = Envelope.Intersects(p3, p4, p2);
			IntersectionType result;
			if (flag && flag2)
			{
				base.method_0()[0] = p3;
				base.method_0()[1] = p4;
				result = IntersectionType.Collinear;
			}
			else if (flag3 && flag4)
			{
				base.method_0()[0] = p1;
				base.method_0()[1] = p2;
				result = IntersectionType.Collinear;
			}
			else if (flag && flag3)
			{
				base.method_0()[0] = p3;
				base.method_0()[1] = p1;
				if (!p3.Equals(p1))
				{
					result = IntersectionType.Collinear;
				}
				else
				{
					result = IntersectionType.PointIntersection;
				}
			}
			else if (flag && flag4)
			{
				base.method_0()[0] = p3;
				base.method_0()[1] = p2;
				if (!p3.Equals(p2))
				{
					result = IntersectionType.Collinear;
				}
				else
				{
					result = IntersectionType.PointIntersection;
				}
			}
			else if (flag2 && flag3)
			{
				base.method_0()[0] = p4;
				base.method_0()[1] = p1;
				if (!p4.Equals(p1))
				{
					result = IntersectionType.Collinear;
				}
				else
				{
					result = IntersectionType.PointIntersection;
				}
			}
			else if (!flag2 || !flag4)
			{
				result = IntersectionType.NoIntersection;
			}
			else
			{
				base.method_0()[0] = p4;
				base.method_0()[1] = p2;
				if (!p4.Equals(p2))
				{
					result = IntersectionType.Collinear;
				}
				else
				{
					result = IntersectionType.PointIntersection;
				}
			}
			return result;
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x000FD26C File Offset: 0x000FB46C
		private Coordinate Intersection(Coordinate p1, Coordinate p2, Coordinate q1, Coordinate q2)
		{
			Coordinate coordinate = new Coordinate(p1);
			Coordinate coordinate2 = new Coordinate(p2);
			Coordinate coordinate3 = new Coordinate(q1);
			Coordinate coordinate4 = new Coordinate(q2);
			Coordinate coordinate5 = new Coordinate();
			RobustLineIntersector.NormalizeToEnvCentre(coordinate, coordinate2, coordinate3, coordinate4, coordinate5);
			Coordinate coordinate6 = Class2238.smethod_0(coordinate, coordinate2, coordinate3, coordinate4);
			coordinate6.X += coordinate5.X;
			coordinate6.Y += coordinate5.Y;
			if (!this.IsInSegmentEnvelopes(coordinate6))
			{
				Trace.WriteLine("Intersection outside segment envelopes: " + coordinate6);
			}
			if (PrecisionModel.NotEquals(this.GetPrecisionModel(), null))
			{
				this.GetPrecisionModel().MakePrecise(coordinate6);
			}
			return coordinate6;
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x000FD31C File Offset: 0x000FB51C
		private static void NormalizeToEnvCentre(Coordinate n00, Coordinate n01, Coordinate n10, Coordinate n11, Coordinate normPt)
		{
			double num = (n00.X < n01.X) ? n00.X : n01.X;
			double num2 = (n00.Y < n01.Y) ? n00.Y : n01.Y;
			double num3 = (n00.X > n01.X) ? n00.X : n01.X;
			double num4 = (n00.Y > n01.Y) ? n00.Y : n01.Y;
			double num5 = (n10.X < n11.X) ? n10.X : n11.X;
			double num6 = (n10.Y < n11.Y) ? n10.Y : n11.Y;
			double num7 = (n10.X > n11.X) ? n10.X : n11.X;
			double num8 = (n10.Y > n11.Y) ? n10.Y : n11.Y;
			double num9 = (num > num5) ? num : num5;
			double num10 = (num3 < num7) ? num3 : num7;
			double num11 = (num2 > num6) ? num2 : num6;
			double num12 = (num4 < num8) ? num4 : num8;
			double x = (num9 + num10) / 2.0;
			double y = (num11 + num12) / 2.0;
			normPt.X = x;
			normPt.Y = y;
			n00.X -= normPt.X;
			n00.Y -= normPt.Y;
			n01.X -= normPt.X;
			n01.Y -= normPt.Y;
			n10.X -= normPt.X;
			n10.Y -= normPt.Y;
			n11.X -= normPt.X;
			n11.Y -= normPt.Y;
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x000FD51C File Offset: 0x000FB71C
		private bool IsInSegmentEnvelopes(Coordinate intPt)
		{
			Envelope ienvelope_ = new Envelope(base.method_1()[0, 0], base.method_1()[0, 1]);
			Envelope ienvelope_2 = new Envelope(base.method_1()[1, 0], base.method_1()[1, 1]);
			return Class2183.smethod_8(ienvelope_, intPt) && Class2183.smethod_8(ienvelope_2, intPt);
		}
	}
}
