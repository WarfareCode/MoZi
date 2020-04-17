using System;
using System.Collections;
using GeoAPI.Geometries;
using ns14;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x0200039E RID: 926
	[Serializable]
	public class GeometryCollection : Geometry, IComparable<IGeometry>, IEquatable<IGeometry>, IEnumerable, IComparable, ICloneable, IGeometry, IGeometryCollection
	{
		// Token: 0x170001D9 RID: 473
		public IGeometry this[int int_0]
		{
			get
			{
				return this.geometries[int_0];
			}
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0000F56C File Offset: 0x0000D76C
		public GeometryCollection(IGeometry[] igeometry_0, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (igeometry_0 == null)
			{
				igeometry_0 = new IGeometry[0];
			}
			if (Geometry.smethod_1(igeometry_0))
			{
				throw new ArgumentException("geometries must not contain null elements");
			}
			this.geometries = igeometry_0;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0008FF10 File Offset: 0x0008E110
		public override ICoordinate imethod_5()
		{
			ICoordinate result;
			if (this.imethod_10())
			{
				result = null;
			}
			else
			{
				result = this.geometries[0].imethod_5();
			}
			return result;
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x0008FF40 File Offset: 0x0008E140
		public override ICoordinate[] imethod_6()
		{
			ICoordinate[] array = new ICoordinate[this.imethod_3()];
			int num = -1;
			for (int i = 0; i < this.geometries.Length; i++)
			{
				ICoordinate[] array2 = this.geometries[i].imethod_6();
				for (int j = 0; j < array2.Length; j++)
				{
					num++;
					array[num] = array2[j];
				}
			}
			return array;
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x0008FFA4 File Offset: 0x0008E1A4
		public override bool imethod_10()
		{
			bool result;
			for (int i = 0; i < this.geometries.Length; i++)
			{
				if (!this.geometries[i].imethod_10())
				{
					result = false;
					return result;
				}
			}
			result = true;
			return result;
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x0008FFDC File Offset: 0x0008E1DC
		public override Dimensions imethod_7()
		{
			Dimensions dimensions = Dimensions.False;
			for (int i = 0; i < this.geometries.Length; i++)
			{
				dimensions = (Dimensions)Math.Max((int)dimensions, (int)this.geometries[i].imethod_7());
			}
			return dimensions;
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00090018 File Offset: 0x0008E218
		public override Dimensions imethod_4()
		{
			Dimensions dimensions = Dimensions.False;
			for (int i = 0; i < this.geometries.Length; i++)
			{
				dimensions = (Dimensions)Math.Max((int)dimensions, (int)this.geometries[i].imethod_4());
			}
			return dimensions;
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00090054 File Offset: 0x0008E254
		public override int imethod_2()
		{
			return this.geometries.Length;
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0008FEF8 File Offset: 0x0008E0F8
		public override IGeometry imethod_9(int int_0)
		{
			return this.geometries[int_0];
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0009006C File Offset: 0x0008E26C
		public IGeometry[] imethod_11()
		{
			return this.geometries;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00090084 File Offset: 0x0008E284
		public override int imethod_3()
		{
			int num = 0;
			for (int i = 0; i < this.geometries.Length; i++)
			{
				num += this.geometries[i].imethod_3();
			}
			return num;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x000900BC File Offset: 0x0008E2BC
		public  object Clone()
		{
			GeometryCollection geometryCollection = (GeometryCollection)base.Clone();
			geometryCollection.geometries = new IGeometry[this.geometries.Length];
			for (int i = 0; i < this.geometries.Length; i++)
			{
				geometryCollection.geometries[i] = (IGeometry)this.geometries[i].Clone();
			}
			return geometryCollection;
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x0009011C File Offset: 0x0008E31C
		protected override IEnvelope vmethod_1()
		{
			IEnvelope envelope = new Envelope();
			for (int i = 0; i < this.geometries.Length; i++)
			{
				envelope.imethod_7(this.geometries[i].imethod_8());
			}
			return envelope;
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x0009015C File Offset: 0x0008E35C
		protected internal override int vmethod_2(object object_0)
		{
			ArrayList arrayList_ = new ArrayList(this.geometries);
			ArrayList arrayList_2 = new ArrayList(((GeometryCollection)object_0).geometries);
			return base.method_3(arrayList_, arrayList_2);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00090190 File Offset: 0x0008E390
		public IEnumerator GetEnumerator()
		{
			return new Class655(this);
		}

		// Token: 0x04000963 RID: 2403
		public static readonly IGeometryCollection Empty = Geometry.DefaultFactory.imethod_11(null);

		// Token: 0x04000964 RID: 2404
		protected IGeometry[] geometries = null;
	}
}
