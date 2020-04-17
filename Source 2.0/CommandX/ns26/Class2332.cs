using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns23;
using ns24;
using ns25;
using ns28;

namespace ns26
{
	// Token: 0x020007D7 RID: 2007
	public sealed class Class2332
	{
		// Token: 0x060031BC RID: 12732 RVA: 0x0001ABFC File Offset: 0x00018DFC
		public Class2332(GeometryGraph class2209_1)
		{
			this.class2209_0 = class2209_1;
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x0010CA9C File Offset: 0x0010AC9C
		public  Coordinate vmethod_0()
		{
			return this.coordinate_0;
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x0001AC21 File Offset: 0x00018E21
		public  void vmethod_1(LinearRing linearRing_0)
		{
			this.ilist_0.Add(linearRing_0);
			Class2183.smethod_13(this.envelope_0, linearRing_0.GetEnvelopeInternal());
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x0010CAB4 File Offset: 0x0010ACB4
		public  bool vmethod_2()
		{
			this.method_0();
			bool result;
			for (int i = 0; i < this.ilist_0.Count; i++)
			{
				LinearRing linearRing = (LinearRing)this.ilist_0[i];
				IList<Coordinate> coordinates = linearRing.GetCoordinates();
				IList list = this.class2268_0.Query(linearRing.GetEnvelopeInternal());
				for (int j = 0; j < list.Count; j++)
				{
					LinearRing linearRing2 = (LinearRing)list[j];
					IList<Coordinate> coordinates2 = linearRing2.GetCoordinates();
					if (linearRing != linearRing2 && Class2183.smethod_15(linearRing.GetEnvelopeInternal(), linearRing2.GetEnvelopeInternal()))
					{
						Coordinate p = IsValidOp.FindPointNotNode(coordinates, linearRing2, this.class2209_0);
						Class2347.smethod_1(Coordinate.NotEquals(p, null), "Unable to find a ring point not a node of the search ring");
						if (CgAlgorithms.IsPointInRing(p, coordinates2))
						{
							this.coordinate_0 = p;
							result = false;
							return result;
						}
					}
				}
			}
			result = true;
			return result;
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x0010CBA0 File Offset: 0x0010ADA0
		private void method_0()
		{
			this.class2268_0 = new Quadtree();
			for (int i = 0; i < this.ilist_0.Count; i++)
			{
				LinearRing linearRing = (LinearRing)this.ilist_0[i];
				IEnvelope envelopeInternal = linearRing.GetEnvelopeInternal();
				this.class2268_0.Insert(envelopeInternal, linearRing);
			}
		}

		// Token: 0x04001707 RID: 5895
		private readonly GeometryGraph class2209_0;

		// Token: 0x04001708 RID: 5896
		private readonly IList ilist_0 = new ArrayList();

		// Token: 0x04001709 RID: 5897
		private readonly Envelope envelope_0 = new Envelope();

		// Token: 0x0400170A RID: 5898
		private Coordinate coordinate_0;

		// Token: 0x0400170B RID: 5899
		private Quadtree class2268_0;
	}
}
