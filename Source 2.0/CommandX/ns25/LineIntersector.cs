using System;
using System.Text;
using DotSpatial.Topology;
using ns28;

namespace ns25
{
	// Token: 0x02000637 RID: 1591
	public abstract class LineIntersector
	{
		// Token: 0x06002859 RID: 10329 RVA: 0x000F3568 File Offset: 0x000F1768
		protected LineIntersector()
		{
			this._intPt[0] = new Coordinate();
			this._intPt[1] = new Coordinate();
			this._result = IntersectionType.NoIntersection;
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x000F35B8 File Offset: 0x000F17B8
		public virtual PrecisionModel GetPrecisionModel()
		{
			return this._precisionModel;
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x000165AC File Offset: 0x000147AC
		public virtual void SetPrecisionModel(PrecisionModel value)
		{
			this._precisionModel = value;
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x000F35D0 File Offset: 0x000F17D0
		public static double ComputeEdgeDistance(Coordinate p, Coordinate p0, Coordinate p1)
		{
			double num = Math.Abs(p1.X - p0.X);
			double num2 = Math.Abs(p1.Y - p0.Y);
			double num3;
			if (p.Equals(p0))
			{
				num3 = 0.0;
			}
			else if (p.Equals(p1))
			{
				num3 = ((num > num2) ? num : num2);
			}
			else
			{
				double num4 = Math.Abs(p.X - p0.X);
				double num5 = Math.Abs(p.Y - p0.Y);
				if (num > num2)
				{
					num3 = num4;
				}
				else
				{
					num3 = num5;
				}
				if (num3 == 0.0 && !p.Equals(p0))
				{
					num3 = Math.Max(num4, num5);
				}
			}
			Class2347.smethod_1(num3 != 0.0 || p.Equals(p0), "Bad distance calculation");
			return num3;
		}

		// Token: 0x0600285D RID: 10333
		public abstract void ComputeIntersection(Coordinate coordinate_2, Coordinate coordinate_3, Coordinate coordinate_4);

		// Token: 0x0600285E RID: 10334 RVA: 0x000F36BC File Offset: 0x000F18BC
		public virtual void ComputeIntersection(Coordinate coordinate_2, Coordinate coordinate_3, Coordinate coordinate_4, Coordinate coordinate_5)
		{
			this._inputLines[0, 0] = new Coordinate(coordinate_2);
			this._inputLines[0, 1] = new Coordinate(coordinate_3);
			this._inputLines[1, 0] = new Coordinate(coordinate_4);
			this._inputLines[1, 1] = new Coordinate(coordinate_5);
			this._result = this.ComputeIntersect(coordinate_2, coordinate_3, coordinate_4, coordinate_5);
		}

		// Token: 0x0600285F RID: 10335
		public abstract IntersectionType ComputeIntersect(Coordinate coordinate_2, Coordinate coordinate_3, Coordinate coordinate_4, Coordinate coordinate_5);

		// Token: 0x06002860 RID: 10336 RVA: 0x000F3728 File Offset: 0x000F1928
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this._inputLines[0, 0]).Append("-");
			stringBuilder.Append(this._inputLines[0, 1]).Append(" ");
			stringBuilder.Append(this._inputLines[1, 0]).Append("-");
			stringBuilder.Append(this._inputLines[1, 1]).Append(" : ");
			if (this.vmethod_13())
			{
				stringBuilder.Append(" endpoint");
			}
			if (this._isProper)
			{
				stringBuilder.Append(" proper");
			}
			if (this.vmethod_12())
			{
				stringBuilder.Append(" collinear");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x000F3800 File Offset: 0x000F1A00
		public  Coordinate GetIntersection(int int_0)
		{
			return new Coordinate(this._intPt[int_0]);
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x000F381C File Offset: 0x000F1A1C
		public   bool vmethod_6(Coordinate coordinate_2)
		{
			bool result;
			for (int i = 0; i < (int)this._result; i++)
			{
				if (new Coordinate(this._intPt[i]).Equals2D(coordinate_2))
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x000165B5 File Offset: 0x000147B5
		public   bool vmethod_7()
		{
			return this.vmethod_8(0) || this.vmethod_8(1);
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x000F385C File Offset: 0x000F1A5C
		public   bool vmethod_8(int int_0)
		{
			bool result;
			for (int i = 0; i < (int)this._result; i++)
			{
				Coordinate coordinate = new Coordinate(this._intPt[i]);
				if (!coordinate.Equals2D(this._inputLines[int_0, 0]) && !coordinate.Equals2D(this._inputLines[int_0, 1]))
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x000F38C0 File Offset: 0x000F1AC0
		public  double vmethod_9(int int_0, int int_1)
		{
			return LineIntersector.ComputeEdgeDistance(this._intPt[int_1], this._inputLines[int_0, 0], this._inputLines[int_0, 1]);
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x000165CA File Offset: 0x000147CA
		public virtual bool HasIntersection()
		{
			return this._result != IntersectionType.NoIntersection;
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x000F38F8 File Offset: 0x000F1AF8
		public  int vmethod_11()
		{
			return (int)this._result;
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x000F3910 File Offset: 0x000F1B10
		public Coordinate[] method_0()
		{
			return this._intPt;
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x000F3928 File Offset: 0x000F1B28
		protected Coordinate[,] method_1()
		{
			return this._inputLines;
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x000165D8 File Offset: 0x000147D8
		protected virtual bool vmethod_12()
		{
			return this._result == IntersectionType.Collinear;
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x000165E3 File Offset: 0x000147E3
		protected virtual bool vmethod_13()
		{
			return this.HasIntersection() && !this._isProper;
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x000165F9 File Offset: 0x000147F9
		public   bool vmethod_14()
		{
			return this.HasIntersection() && this._isProper;
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x0001660C File Offset: 0x0001480C
		protected virtual void SetIsProper(bool bool_1)
		{
			this._isProper = bool_1;
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x00016615 File Offset: 0x00014815
		protected void SetResult(IntersectionType enum159_1)
		{
			this._result = enum159_1;
		}

		// Token: 0x04001351 RID: 4945
		private Coordinate[,] _inputLines = new Coordinate[2, 2];

		// Token: 0x04001352 RID: 4946
		private Coordinate[] _intPt = new Coordinate[2];

		// Token: 0x04001353 RID: 4947
		private bool _isProper;

		// Token: 0x04001354 RID: 4948
		private PrecisionModel _precisionModel;

		// Token: 0x04001355 RID: 4949
		private IntersectionType _result;
	}
}
