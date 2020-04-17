using System;
using System.Collections;
using System.Collections.Generic;
using ns23;
using ns24;
using ns25;
using ns26;
using ns27;

namespace DotSpatial.Topology
{
	// Token: 0x0200052E RID: 1326
	[Serializable]
	public abstract class Geometry : IComparable, ICloneable, IBasicGeometry, IGeometry
	{
		// Token: 0x06002212 RID: 8722 RVA: 0x000DD290 File Offset: 0x000DB490
		protected Geometry()
		{
			if (Geometry.DefaultFactory == null)
			{
				Geometry.DefaultFactory = new GeometryFactory(new PrecisionModel(PrecisionModelType.Floating));
			}
			this._factory = Geometry.DefaultFactory;
			this._srid = this._factory.GetSrid();
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x000142F7 File Offset: 0x000124F7
		protected Geometry(IGeometryFactory igeometryFactory_0)
		{
			this._factory = igeometryFactory_0;
			this._srid = igeometryFactory_0.GetSrid();
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x000DD2DC File Offset: 0x000DB4DC
		private int GetClassSortIndex()
		{
			for (int i = 0; i < Geometry.SortedClasses.Length; i++)
			{
				if (base.GetType().Equals(Geometry.SortedClasses[i]))
				{
					return i;
				}
			}
			throw new ClassNotSupportedException(base.GetType().FullName);
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x000DD328 File Offset: 0x000DB528
		public IGeometryFactory GetFactory()
		{
			return this._factory;
		}

		// Token: 0x06002216 RID: 8726
		public abstract string GetGeometryType();

		// Token: 0x06002217 RID: 8727 RVA: 0x000DD340 File Offset: 0x000DB540
		public virtual PrecisionModelType GetPrecisionModel()
		{
			return this.GetFactory().GetPrecisionModel();
		}

		// Token: 0x06002218 RID: 8728
		public abstract Coordinate GetCoordinate();

		// Token: 0x06002219 RID: 8729
		public abstract IList<Coordinate> GetCoordinates();

		// Token: 0x0600221A RID: 8730
		public abstract void SetCoordinates(IList<Coordinate> value);

		// Token: 0x0600221B RID: 8731
		public abstract int GetNumPoints();

		// Token: 0x0600221C RID: 8732 RVA: 0x0000945D File Offset: 0x0000765D
		public virtual int GetNumGeometries()
		{
			return 1;
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x000DD35C File Offset: 0x000DB55C
		public virtual IGeometry GetGeometryN(int int_0)
		{
			return this;
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x000DD36C File Offset: 0x000DB56C
		public virtual IBasicGeometry GetBasicGeometryN(int int_0)
		{
			return this;
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x000DD37C File Offset: 0x000DB57C
		public virtual bool IsValid()
		{
			IsValidOp isValidOp = new IsValidOp(this);
			return isValidOp.IsValid();
		}

		// Token: 0x06002220 RID: 8736
		public abstract bool IsEmpty();

		// Token: 0x06002221 RID: 8737 RVA: 0x000DD398 File Offset: 0x000DB598
		public  double GetArea()
		{
			return 0.0;
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x000DD3B0 File Offset: 0x000DB5B0
		public virtual IEnvelope GetEnvelopeInternal()
		{
			if (this._envelope == null)
			{
				this._envelope = this.ComputeEnvelopeInternal();
			}
			return this._envelope;
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x00014312 File Offset: 0x00012512
		public virtual void GeometryChangedAction()
		{
			this._envelope = null;
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x000DD3E0 File Offset: 0x000DB5E0
		public override string ToString()
		{
			return this.ToText();
		}

		// Token: 0x06002225 RID: 8741
		public abstract void Apply(ICoordinateFilter filter);

		// Token: 0x06002226 RID: 8742
		public abstract void Apply(IGeometryFilter filter);

		// Token: 0x06002227 RID: 8743
		public abstract void Apply(IGeometryComponentFilter filter);

		// Token: 0x06002228 RID: 8744 RVA: 0x000DD3F8 File Offset: 0x000DB5F8
		object ICloneable.Clone()
		{
			Geometry geometry = (Geometry)base.MemberwiseClone();
			this.OnCopy(geometry);
			return geometry;
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x000DD41C File Offset: 0x000DB61C
		public virtual int CompareTo(object target)
		{
			Geometry geometry = target as Geometry;
			if (geometry == null)
			{
				Coordinate coordinate_ = target as Coordinate;
				if (Coordinate.Equals(coordinate_, null))
				{
					IEnvelope envelope = target as IEnvelope;
					if (envelope == null)
					{
						throw new ApplicationException("the specified object could not be treated like a geometry.");
					}
					geometry = (Class2183.smethod_5(envelope) as Geometry);
				}
				else
				{
					geometry = new Point(coordinate_);
				}
			}
			int result;
			if (geometry != null)
			{
				if (this.GetClassSortIndex() != geometry.GetClassSortIndex())
				{
					result = this.GetClassSortIndex() - geometry.GetClassSortIndex();
					return result;
				}
				if (this.IsEmpty() && geometry.IsEmpty())
				{
					result = 0;
					return result;
				}
			}
			if (this.IsEmpty())
			{
				result = -1;
			}
			else if (geometry == null)
			{
				result = 1;
			}
			else if (!geometry.IsEmpty())
			{
				result = this.CompareToSameClass(geometry);
			}
			else
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x0600222A RID: 8746
		public abstract int CompareToSameClass(object object_0);

		// Token: 0x0600222B RID: 8747 RVA: 0x000DD4F0 File Offset: 0x000DB6F0
		public virtual IGeometry Buffer(double distance, int quadrantSegments)
		{
			return BufferOp.Buffer(this, distance, quadrantSegments);
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x000DD508 File Offset: 0x000DB708
		public virtual IGeometry Buffer(double double_0)
		{
			return BufferOp.Buffer(this, double_0);
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x000DD520 File Offset: 0x000DB720
		public static IGeometry FromBasicGeometry(IBasicGeometry geom)
		{
			IBasicPolygon basicPolygon = geom as IBasicPolygon;
			IGeometry result;
			if (basicPolygon != null)
			{
				result = new Polygon(basicPolygon);
			}
			else
			{
				IBasicLineString basicLineString = geom as IBasicLineString;
				if (basicLineString != null)
				{
					result = new LineString(basicLineString);
				}
				else
				{
					IBasicPoint basicPoint = geom as IBasicPoint;
					if (basicPoint != null)
					{
						result = new Point(basicPoint);
					}
					else
					{
						IBasicGeometry basicGeometryN = geom.GetBasicGeometryN(0);
						basicPolygon = (basicGeometryN as IBasicPolygon);
						if (basicPolygon != null)
						{
							result = new MultiPolygon(geom);
						}
						else
						{
							basicLineString = (basicGeometryN as IBasicLineString);
							if (basicLineString != null)
							{
								result = new MultiLineString(geom);
							}
							else
							{
								basicPoint = (basicGeometryN as IBasicPoint);
								if (basicPoint != null)
								{
									result = new MultiPoint(geom);
								}
								else
								{
									result = null;
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x000DD5C0 File Offset: 0x000DB7C0
		protected static bool HasNonEmptyElements(IGeometry[] geometries)
		{
			bool result;
			for (int i = 0; i < geometries.Length; i++)
			{
				IGeometry geometry = geometries[i];
				if (!geometry.IsEmpty())
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x000DD5F0 File Offset: 0x000DB7F0
		protected static bool HasNullElements(IEnumerable<IBasicGeometry> array)
		{
			bool result;
			foreach (IBasicGeometry current in array)
			{
				if (current == null)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x000DD648 File Offset: 0x000DB848
		public virtual string ToText()
		{
			WktWriter wktWriter = new WktWriter();
			return wktWriter.Write(this);
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00004BC2 File Offset: 0x00002DC2
		protected virtual void OnCopy(Geometry geometry_0)
		{
		}

		// Token: 0x06002232 RID: 8754
		protected abstract IEnvelope ComputeEnvelopeInternal();

		// Token: 0x06002233 RID: 8755 RVA: 0x000DD664 File Offset: 0x000DB864
		protected virtual int Compare(ArrayList a, ArrayList b)
		{
			IEnumerator enumerator = a.GetEnumerator();
			IEnumerator enumerator2 = b.GetEnumerator();
			int result;
			while (enumerator.MoveNext() && enumerator2.MoveNext())
			{
				IComparable comparable = (IComparable)enumerator.Current;
				IComparable obj = (IComparable)enumerator2.Current;
				int num = comparable.CompareTo(obj);
				if (num != 0)
				{
					result = num;
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

		// Token: 0x04001090 RID: 4240
		private readonly IGeometryFactory _factory;

		// Token: 0x04001091 RID: 4241
		private IEnvelope _envelope;

		// Token: 0x04001092 RID: 4242
		private int _srid;

		// Token: 0x04001093 RID: 4243
		private object _userData;

		// Token: 0x04001094 RID: 4244
		private static readonly Type[] SortedClasses = new Type[]
		{
			typeof(Point),
			typeof(MultiPoint),
			typeof(LineString),
			typeof(LinearRing),
			typeof(MultiLineString),
			typeof(Polygon),
			typeof(MultiPolygon),
			typeof(GeometryCollection)
		};

		// Token: 0x04001095 RID: 4245
		public static GeometryFactory DefaultFactory = new GeometryFactory();

		// Token: 0x04001096 RID: 4246
		private IGeometry _boundary;

		// Token: 0x04001097 RID: 4247
		private DimensionType _boundaryDimension;

		// Token: 0x04001098 RID: 4248
		private DimensionType _dimension;

		// Token: 0x0200052F RID: 1327
		private sealed class GeometryChangedFilter : IGeometryComponentFilter
		{
			// Token: 0x06002235 RID: 8757 RVA: 0x0001431B File Offset: 0x0001251B
			public void Filter(IGeometry geom)
			{
				geom.GeometryChangedAction();
			}
		}
	}
}
