using System;
using ns24;

namespace DotSpatial.Topology
{
	// Token: 0x02000527 RID: 1319
	public interface IGeometry : IComparable, ICloneable, IBasicGeometry
	{
		// Token: 0x060021ED RID: 8685
		void Apply(ICoordinateFilter filter);

		// Token: 0x060021EE RID: 8686
		void Apply(IGeometryFilter filter);

		// Token: 0x060021EF RID: 8687
		void Apply(IGeometryComponentFilter interface31_0);

		// Token: 0x060021F0 RID: 8688
		IGeometry Buffer(double distance);

		// Token: 0x060021F1 RID: 8689
		int CompareToSameClass(object object_0);

		// Token: 0x060021F2 RID: 8690
		void GeometryChangedAction();

		// Token: 0x060021F3 RID: 8691
		IGeometry GetGeometryN(int n);

		// Token: 0x060021F4 RID: 8692
		double GetArea();

		// Token: 0x060021F5 RID: 8693
		Coordinate GetCoordinate();

		// Token: 0x060021F6 RID: 8694
		IEnvelope GetEnvelopeInternal();

		// Token: 0x060021F7 RID: 8695
		IGeometryFactory GetFactory();

		// Token: 0x060021F8 RID: 8696
		bool IsEmpty();

		// Token: 0x060021F9 RID: 8697
		PrecisionModelType GetPrecisionModel();
	}
}
