using System;
using System.Collections;
using GeoAPI.Geometries;
using ns12;
using ns13;
using ns14;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x0200039C RID: 924
	[Serializable]
	public abstract class Geometry : IComparable<IGeometry>, IEquatable<IGeometry>, IComparable, ICloneable, IGeometry
	{
		// Token: 0x0600166B RID: 5739 RVA: 0x0008F9FC File Offset: 0x0008DBFC
		public IGeometryFactory imethod_0()
		{
			return this.factory;
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0000F4C2 File Offset: 0x0000D6C2
		public Geometry(IGeometryFactory igeometryFactory_0)
		{
			this.factory = igeometryFactory_0;
			this.srid = igeometryFactory_0.imethod_1();
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x0008FA14 File Offset: 0x0008DC14
		protected static bool smethod_0(IGeometry[] igeometry_0)
		{
			bool result;
			for (int i = 0; i < igeometry_0.Length; i++)
			{
				IGeometry geometry = igeometry_0[i];
				if (!geometry.imethod_10())
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0008FA44 File Offset: 0x0008DC44
		public static bool smethod_1(object[] object_0)
		{
			bool result;
			for (int i = 0; i < object_0.Length; i++)
			{
				object obj = object_0[i];
				if (obj == null)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x0008FA78 File Offset: 0x0008DC78
		public IPrecisionModel imethod_1()
		{
			return this.imethod_0().imethod_2();
		}

		// Token: 0x06001670 RID: 5744
		public abstract ICoordinate imethod_5();

		// Token: 0x06001671 RID: 5745
		public abstract ICoordinate[] imethod_6();

		// Token: 0x06001672 RID: 5746
		public abstract int imethod_3();

		// Token: 0x06001673 RID: 5747 RVA: 0x0000945D File Offset: 0x0000765D
		public virtual int imethod_2()
		{
			return 1;
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x0008FA94 File Offset: 0x0008DC94
		public virtual IGeometry imethod_9(int int_0)
		{
			return this;
		}

		// Token: 0x06001675 RID: 5749
		public abstract bool imethod_10();

		// Token: 0x06001676 RID: 5750 RVA: 0x0008FAA4 File Offset: 0x0008DCA4
		public virtual Dimensions imethod_7()
		{
			return this.dimension;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x0008FABC File Offset: 0x0008DCBC
		public virtual Dimensions imethod_4()
		{
			return this.boundaryDimension;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x0008FAD4 File Offset: 0x0008DCD4
		public IEnvelope imethod_8()
		{
			if (this.envelope == null)
			{
				this.envelope = this.vmethod_1();
			}
			return this.envelope;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x0008FB04 File Offset: 0x0008DD04
		public Class666 vmethod_0(IGeometry igeometry_0)
		{
			this.method_1(this);
			this.method_1(igeometry_0);
			return Class654.smethod_0(this, igeometry_0);
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x0008FB28 File Offset: 0x0008DD28
		public bool Equals(IGeometry other)
		{
			bool result;
			if (this.imethod_10() && other.imethod_10())
			{
				result = true;
			}
			else if (!this.imethod_8().imethod_9(other.imethod_8()))
			{
				result = false;
			}
			else if (this.method_2(this) || this.method_2(other))
			{
				result = Geometry.smethod_2(this, other);
			}
			else
			{
				result = this.vmethod_0(other).method_6(this.imethod_7(), other.imethod_7());
			}
			return result;
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x0008FBA4 File Offset: 0x0008DDA4
		private static bool smethod_2(IGeometry igeometry_0, IGeometry igeometry_1)
		{
			IGeometryCollection geometryCollection = igeometry_0 as IGeometryCollection;
			IGeometryCollection geometryCollection2 = igeometry_1 as IGeometryCollection;
			bool flag;
			bool result;
			if (geometryCollection == null || geometryCollection2 == null)
			{
				flag = false;
			}
			else if (geometryCollection.imethod_2() != geometryCollection2.imethod_2())
			{
				flag = false;
			}
			else
			{
				for (int i = 0; i < geometryCollection.imethod_2(); i++)
				{
					IGeometry geometry = geometryCollection[i];
					IGeometry other = geometryCollection2[i];
					if (!geometry.Equals(other))
					{
						result = false;
						return result;
					}
				}
				flag = true;
			}
			result = flag;
			return result;
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x0000F4EB File Offset: 0x0000D6EB
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType().Namespace != obj.GetType().Namespace) && this.Equals((IGeometry)obj);
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x0008FC28 File Offset: 0x0008DE28
		public override int GetHashCode()
		{
			int num = 17;
			ICoordinate[] array = this.imethod_6();
			for (int i = 0; i < array.Length; i++)
			{
				Coordinate coordinate = (Coordinate)array[i];
				num = 37 * num + coordinate.imethod_0().GetHashCode();
			}
			return num;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x0008FC74 File Offset: 0x0008DE74
		public override string ToString()
		{
			return this.method_0();
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x0008FC8C File Offset: 0x0008DE8C
		public string method_0()
		{
			Class632 @class = new Class632();
			return @class.vmethod_0(this);
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x0008FCA8 File Offset: 0x0008DEA8
		public  object Clone()
		{
			Geometry geometry = (Geometry)base.MemberwiseClone();
			if (geometry.envelope != null)
			{
				geometry.envelope = new Envelope(geometry.envelope);
			}
			return geometry;
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x0008FCE0 File Offset: 0x0008DEE0
		public int CompareTo(object target)
		{
			return this.CompareTo((IGeometry)target);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x0008FCFC File Offset: 0x0008DEFC
		public int CompareTo(IGeometry other)
		{
			Geometry geometry = (Geometry)other;
			int result;
			if (this.method_4() != geometry.method_4())
			{
				result = this.method_4() - geometry.method_4();
			}
			else if (this.imethod_10() && geometry.imethod_10())
			{
				result = 0;
			}
			else if (this.imethod_10())
			{
				result = -1;
			}
			else if (geometry.imethod_10())
			{
				result = 1;
			}
			else
			{
				result = this.vmethod_2(other);
			}
			return result;
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x0000F51C File Offset: 0x0000D71C
		protected void method_1(IGeometry igeometry_0)
		{
			if (this.method_2(igeometry_0))
			{
				throw new ArgumentException("This method does not support GeometryCollection arguments");
			}
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x0000F535 File Offset: 0x0000D735
		private bool method_2(IGeometry igeometry_0)
		{
			return igeometry_0.GetType().Name == "GeometryCollection" && igeometry_0.GetType().Namespace == base.GetType().Namespace;
		}

		// Token: 0x06001685 RID: 5765
		protected abstract IEnvelope vmethod_1();

		// Token: 0x06001686 RID: 5766
		protected internal abstract int vmethod_2(object object_0);

		// Token: 0x06001687 RID: 5767 RVA: 0x0008FD78 File Offset: 0x0008DF78
		protected int method_3(ArrayList arrayList_0, ArrayList arrayList_1)
		{
			IEnumerator enumerator = arrayList_0.GetEnumerator();
			IEnumerator enumerator2 = arrayList_1.GetEnumerator();
			int result;
			while (enumerator.MoveNext() && enumerator2.MoveNext())
			{
				IComparable comparable = (IComparable)enumerator.Current;
				IComparable obj = (IComparable)enumerator2.Current;
				int num = comparable.CompareTo(obj);
				if (num != 0)
				{
					int num2 = num;
					result = num2;
					return result;
				}
			}
			if (enumerator.MoveNext())
			{
				result = 1;
				return result;
			}
			if (enumerator2.MoveNext())
			{
				result = -1;
				return result;
			}
			result = 0;
			return result;
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x0008FE0C File Offset: 0x0008E00C
		private int method_4()
		{
			int result;
			for (int i = 0; i < Geometry.SortedClasses.Length; i++)
			{
				if (base.GetType().Equals(Geometry.SortedClasses[i]))
				{
					int num = i;
					result = num;
					return result;
				}
			}
			Class570.smethod_2(string.Format("Class not supported: {0}", base.GetType().FullName));
			result = -1;
			return result;
		}

		// Token: 0x0400095A RID: 2394
		private static readonly Type[] SortedClasses = new Type[]
		{
			typeof(Point),
			typeof(MultiPoint),
			typeof(LineString),
			typeof(LinearRing),
			typeof(Class595),
			typeof(Polygon),
			typeof(MultiPolygon),
			typeof(GeometryCollection)
		};

		// Token: 0x0400095B RID: 2395
		private IGeometryFactory factory = null;

		// Token: 0x0400095C RID: 2396
		private object userData = null;

		// Token: 0x0400095D RID: 2397
		protected IEnvelope envelope;

		// Token: 0x0400095E RID: 2398
		private int srid;

		// Token: 0x0400095F RID: 2399
		private Dimensions dimension;

		// Token: 0x04000960 RID: 2400
		private IGeometry boundary;

		// Token: 0x04000961 RID: 2401
		private Dimensions boundaryDimension;

		// Token: 0x04000962 RID: 2402
		public static readonly IGeometryFactory DefaultFactory = GeometryFactory.Default;
	}
}
