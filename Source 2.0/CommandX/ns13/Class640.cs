using System;
using System.Collections;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using ns12;
using ns14;

namespace ns13
{
	// Token: 0x02000411 RID: 1041
	public sealed class Class640 : Class639
	{
		// Token: 0x06001A43 RID: 6723 RVA: 0x00010F26 File Offset: 0x0000F126
		public static bool smethod_0(int int_1)
		{
			return int_1 % 2 == 1;
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0009F5C8 File Offset: 0x0009D7C8
		public static Enum143 smethod_1(int int_1)
		{
			return Class640.smethod_0(int_1) ? Enum143.const_1 : Enum143.const_0;
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0009F5E4 File Offset: 0x0009D7E4
		private Class619 method_4()
		{
			return new Class620();
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0009F5F8 File Offset: 0x0009D7F8
		public Class640(int int_1, IGeometry igeometry_1)
		{
			this.int_0 = int_1;
			this.igeometry_0 = igeometry_1;
			if (igeometry_1 != null)
			{
				this.method_7(igeometry_1);
			}
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0009F648 File Offset: 0x0009D848
		public IGeometry method_5()
		{
			return this.igeometry_0;
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0009F660 File Offset: 0x0009D860
		public ICollection method_6()
		{
			if (this.icollection_0 == null)
			{
				this.icollection_0 = this.nodes.method_5(this.int_0);
			}
			return this.icollection_0;
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0009F69C File Offset: 0x0009D89C
		private void method_7(IGeometry igeometry_1)
		{
			if (!igeometry_1.imethod_10())
			{
				if (igeometry_1 is IGeometryCollection && !(igeometry_1 is IMultiPolygon))
				{
					this.bool_0 = true;
				}
				if (igeometry_1 is IPolygon)
				{
					this.method_11((IPolygon)igeometry_1);
				}
				else if (igeometry_1 is ILineString)
				{
					this.method_12((ILineString)igeometry_1);
				}
				else if (igeometry_1 is IPoint)
				{
					this.method_9((IPoint)igeometry_1);
				}
				else if (igeometry_1 is IMultiPoint)
				{
					this.method_8((IMultiPoint)igeometry_1);
				}
				else if (igeometry_1 is Interface25)
				{
					this.method_8((Interface25)igeometry_1);
				}
				else if (igeometry_1 is IMultiPolygon)
				{
					this.method_8((IMultiPolygon)igeometry_1);
				}
				else
				{
					if (!(igeometry_1 is IGeometryCollection))
					{
						throw new NotSupportedException(igeometry_1.GetType().FullName);
					}
					this.method_8((IGeometryCollection)igeometry_1);
				}
			}
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0009F7A8 File Offset: 0x0009D9A8
		private void method_8(IGeometryCollection igeometryCollection_0)
		{
			for (int i = 0; i < igeometryCollection_0.imethod_2(); i++)
			{
				IGeometry igeometry_ = igeometryCollection_0.imethod_9(i);
				this.method_7(igeometry_);
			}
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0009F7D8 File Offset: 0x0009D9D8
		private void method_9(IPoint ipoint_0)
		{
			ICoordinate icoordinate_ = ipoint_0.imethod_5();
			this.method_15(this.int_0, icoordinate_, Enum143.const_0);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0009F7FC File Offset: 0x0009D9FC
		private void method_10(ILinearRing ilinearRing_0, Enum143 enum143_0, Enum143 enum143_1)
		{
			ICoordinate[] array = Class585.smethod_3(ilinearRing_0.imethod_6());
			if (array.Length < 4)
			{
				this.bool_1 = true;
				this.icoordinate_0 = array[0];
			}
			else
			{
				Enum143 enum143_2 = enum143_0;
				Enum143 enum143_3 = enum143_1;
				if (Class628.smethod_3(array))
				{
					enum143_2 = enum143_1;
					enum143_3 = enum143_0;
				}
				Class581 @class = new Class581(array, new Class652(this.int_0, Enum143.const_1, enum143_2, enum143_3));
				if (this.idictionary_0.Contains(ilinearRing_0))
				{
					this.idictionary_0.Remove(ilinearRing_0);
				}
				this.idictionary_0.Add(ilinearRing_0, @class);
				base.method_2(@class);
				this.method_15(this.int_0, array[0], Enum143.const_1);
			}
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0009F89C File Offset: 0x0009DA9C
		private void method_11(IPolygon ipolygon_0)
		{
			this.method_10(ipolygon_0.imethod_12(), Enum143.const_2, Enum143.const_0);
			for (int i = 0; i < ipolygon_0.imethod_13(); i++)
			{
				this.method_10(ipolygon_0.imethod_16()[i], Enum143.const_0, Enum143.const_2);
			}
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0009F8DC File Offset: 0x0009DADC
		private void method_12(ILineString ilineString_0)
		{
			ICoordinate[] array = Class585.smethod_3(ilineString_0.imethod_6());
			if (array.Length < 2)
			{
				this.bool_1 = true;
				this.icoordinate_0 = array[0];
			}
			else
			{
				Class581 @class = new Class581(array, new Class652(this.int_0, Enum143.const_0));
				if (this.idictionary_0.Contains(ilineString_0))
				{
					this.idictionary_0.Remove(ilineString_0);
				}
				this.idictionary_0.Add(ilineString_0, @class);
				base.method_2(@class);
				Class570.smethod_0(array.Length >= 2, "found LineString with single point");
				this.method_16(this.int_0, array[0]);
				this.method_16(this.int_0, array[array.Length - 1]);
			}
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0009F98C File Offset: 0x0009DB8C
		public Class647 method_13(Class596 class596_0, bool bool_2)
		{
			Class647 @class = new Class647(class596_0, true, false);
			Class619 class2 = this.method_4();
			if (!bool_2 && (this.igeometry_0 is ILinearRing || this.igeometry_0 is IPolygon || this.igeometry_0 is IMultiPolygon))
			{
				class2.vmethod_0(this.ilist_0, @class, false);
			}
			else
			{
				class2.vmethod_0(this.ilist_0, @class, true);
			}
			this.method_17(this.int_0);
			return @class;
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0009FA0C File Offset: 0x0009DC0C
		public Class647 method_14(Class640 class640_0, Class596 class596_0, bool bool_2)
		{
			Class647 @class = new Class647(class596_0, bool_2, true);
			@class.method_0(this.method_6(), class640_0.method_6());
			Class619 class2 = this.method_4();
			class2.vmethod_1(this.ilist_0, class640_0.ilist_0, @class);
			return @class;
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0009FA54 File Offset: 0x0009DC54
		private void method_15(int int_1, ICoordinate icoordinate_1, Enum143 enum143_0)
		{
			Class579 @class = this.nodes.method_0((Coordinate)icoordinate_1);
			Class652 class2 = @class.method_0();
			if (class2 == null)
			{
				@class.method_1(new Class652(int_1, enum143_0));
			}
			else
			{
				class2.method_4(int_1, enum143_0);
			}
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x0009FA9C File Offset: 0x0009DC9C
		private void method_16(int int_1, ICoordinate icoordinate_1)
		{
			Class579 @class = this.nodes.method_0((Coordinate)icoordinate_1);
			Class652 class2 = @class.method_0();
			int num = 1;
			Enum143 @enum = Enum143.const_3;
			if (class2 != null)
			{
				@enum = class2.method_1(int_1, Enum140.const_0);
			}
			if (@enum == Enum143.const_1)
			{
				num++;
			}
			Enum143 enum143_ = Class640.smethod_1(num);
			class2.method_4(int_1, enum143_);
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x0009FAF4 File Offset: 0x0009DCF4
		private void method_17(int int_1)
		{
			IEnumerator enumerator = this.ilist_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class581 @class = (Class581)enumerator.Current;
				Enum143 enum143_ = @class.method_0().method_2(int_1);
				IEnumerator enumerator2 = @class.method_7().method_1();
				while (enumerator2.MoveNext())
				{
					Class649 class2 = (Class649)enumerator2.Current;
					this.method_18(int_1, class2.method_0(), enum143_);
				}
			}
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00010F2E File Offset: 0x0000F12E
		private void method_18(int int_1, ICoordinate icoordinate_1, Enum143 enum143_0)
		{
			if (!base.method_1(int_1, icoordinate_1))
			{
				if (enum143_0 == Enum143.const_1 && this.bool_0)
				{
					this.method_16(int_1, icoordinate_1);
				}
				else
				{
					this.method_15(int_1, icoordinate_1, enum143_0);
				}
			}
		}

		// Token: 0x04000B0F RID: 2831
		private IGeometry igeometry_0;

		// Token: 0x04000B10 RID: 2832
		private IDictionary idictionary_0 = new Hashtable();

		// Token: 0x04000B11 RID: 2833
		private bool bool_0 = false;

		// Token: 0x04000B12 RID: 2834
		private int int_0;

		// Token: 0x04000B13 RID: 2835
		private ICollection icollection_0;

		// Token: 0x04000B14 RID: 2836
		private bool bool_1 = false;

		// Token: 0x04000B15 RID: 2837
		private ICoordinate icoordinate_0 = null;
	}
}
