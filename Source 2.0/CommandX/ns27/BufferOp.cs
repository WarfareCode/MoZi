using System;
using DotSpatial.Topology;
using ns16;
using ns25;
using ns26;

namespace ns27
{
	// Token: 0x02000718 RID: 1816
	public sealed class BufferOp
	{
		// Token: 0x06002D32 RID: 11570 RVA: 0x00018997 File Offset: 0x00016B97
		public BufferOp(IGeometry g)
		{
			this._argGeom = g;
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x000189B4 File Offset: 0x00016BB4
		public  void SetQuadrantSegments(int value)
		{
			this._quadrantSegments = value;
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x0010353C File Offset: 0x0010173C
		private static double PrecisionScaleFactor(IGeometry g, double distance, int maxPrecisionDigits)
		{
			IEnvelope envelopeInternal = g.GetEnvelopeInternal();
			double num = Math.Max(envelopeInternal.GetHeight(), envelopeInternal.GetWidth());
			double num2 = (distance > 0.0) ? distance : 0.0;
			double d = num + 2.0 * num2;
			int num3 = (int)(Math.Log(d) / Math.Log(10.0) + 1.0);
			int num4 = num3 - maxPrecisionDigits;
			return Math.Pow(10.0, -(double)num4);
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x001035C8 File Offset: 0x001017C8
		public static IGeometry Buffer(IGeometry g, double distance)
		{
			BufferOp bufferOp = new BufferOp(g);
			return bufferOp.GetResultGeometry(distance);
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x001035E8 File Offset: 0x001017E8
		public static IGeometry Buffer(Geometry g, double distance, int quadrantSegments)
		{
			BufferOp bufferOp = new BufferOp(g);
			bufferOp.SetQuadrantSegments(quadrantSegments);
			return bufferOp.GetResultGeometry(distance);
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x0010360C File Offset: 0x0010180C
		public  IGeometry GetResultGeometry(double distance)
		{
			this._distance = distance;
			this.ComputeGeometry();
			return this._resultGeometry;
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x00103630 File Offset: 0x00101830
		private void ComputeGeometry()
		{
			this.BufferOriginalPrecision();
			if (this._resultGeometry == null)
			{
				int num = 12;
				while (num >= 0)
				{
					try
					{
						this.BufferFixedPrecision(num);
						goto IL_37;
					}
					catch (TopologyException saveException)
					{
						this._saveException = saveException;
						goto IL_37;
					}
					IL_31:
					num--;
					continue;
					IL_37:
					if (this._resultGeometry != null)
					{
						return;
					}
					goto IL_31;
				}
				throw this._saveException;
			}
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00103698 File Offset: 0x00101898
		private void BufferOriginalPrecision()
		{
			try
			{
				BufferBuilder bufferBuilder = new BufferBuilder();
				bufferBuilder.vmethod_0(this._quadrantSegments);
				bufferBuilder.vmethod_2(this._endCapStyle);
				this._resultGeometry = bufferBuilder.method_0(this._argGeom, this._distance);
			}
			catch (TopologyException saveException)
			{
				this._saveException = saveException;
			}
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x001036F8 File Offset: 0x001018F8
		private void BufferFixedPrecision(int int_1)
		{
			double double_ = BufferOp.PrecisionScaleFactor(this._argGeom, this._distance, int_1);
			PrecisionModel precisionModel_ = new PrecisionModel(double_);
			Class2340 @class = new Class2340(precisionModel_);
			IGeometry igeometry_ = @class.vmethod_0(this._argGeom);
			BufferBuilder bufferBuilder = new BufferBuilder();
			bufferBuilder.vmethod_1(precisionModel_);
			bufferBuilder.vmethod_0(this._quadrantSegments);
			this._resultGeometry = bufferBuilder.method_0(igeometry_, this._distance);
		}

		// Token: 0x04001528 RID: 5416
		private readonly IGeometry _argGeom;

		// Token: 0x04001529 RID: 5417
		private double _distance;

		// Token: 0x0400152A RID: 5418
		private BufferStyle _endCapStyle = BufferStyle.CapRound;

		// Token: 0x0400152B RID: 5419
		private int _quadrantSegments = 8;

		// Token: 0x0400152C RID: 5420
		private IGeometry _resultGeometry;

		// Token: 0x0400152D RID: 5421
		private TopologyException _saveException;
	}
}
