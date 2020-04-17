using System;
using System.Globalization;
using System.IO;
using System.Text;
using GeoAPI.Geometries;
using ns12;
using ns14;

namespace ns13
{
	// Token: 0x020003F5 RID: 1013
	public sealed class Class632
	{
		// Token: 0x06001945 RID: 6469 RVA: 0x0009A788 File Offset: 0x00098988
		private static NumberFormatInfo smethod_0(IPrecisionModel iprecisionModel_0)
		{
			int numberDecimalDigits = iprecisionModel_0.imethod_1();
			return new NumberFormatInfo
			{
				NumberDecimalSeparator = ".",
				NumberDecimalDigits = numberDecimalDigits,
				NumberGroupSeparator = string.Empty,
				NumberGroupSizes = new int[0]
			};
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0009A7D0 File Offset: 0x000989D0
		public static string smethod_1(char char_0, int int_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < int_0; i++)
			{
				stringBuilder.Append(char_0);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0009A804 File Offset: 0x00098A04
		public  string vmethod_0(IGeometry igeometry_0)
		{
			TextWriter textWriter = new StringWriter();
			try
			{
				this.method_0(igeometry_0, false, textWriter);
			}
			catch (IOException)
			{
				Class570.smethod_1();
			}
			return textWriter.ToString();
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0009A844 File Offset: 0x00098A44
		private void method_0(IGeometry igeometry_0, bool bool_2, TextWriter textWriter_0)
		{
			if (igeometry_0 == null)
			{
				throw new ArgumentNullException("geometry");
			}
			this.bool_1 = (igeometry_0.imethod_0().imethod_2().imethod_0() == PrecisionModels.Floating);
			this.bool_0 = bool_2;
			this.numberFormatInfo_0 = Class632.smethod_0(igeometry_0.imethod_1());
			this.string_1 = "0." + Class632.smethod_1('#', this.numberFormatInfo_0.NumberDecimalDigits);
			this.method_1(igeometry_0, 0, textWriter_0);
			this.bool_1 = false;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x0009A8C8 File Offset: 0x00098AC8
		private void method_1(IGeometry igeometry_0, int int_0, TextWriter textWriter_0)
		{
			this.method_19(int_0, textWriter_0);
			if (igeometry_0 is IPoint)
			{
				IPoint point = (IPoint)igeometry_0;
				this.method_2(point.imethod_5(), int_0, textWriter_0, point.imethod_1());
			}
			else if (igeometry_0 is ILinearRing)
			{
				this.method_4((ILinearRing)igeometry_0, int_0, textWriter_0);
			}
			else if (igeometry_0 is ILineString)
			{
				this.method_3((ILineString)igeometry_0, int_0, textWriter_0);
			}
			else if (igeometry_0 is IPolygon)
			{
				this.method_5((IPolygon)igeometry_0, int_0, textWriter_0);
			}
			else if (igeometry_0 is IMultiPoint)
			{
				this.method_6((IMultiPoint)igeometry_0, int_0, textWriter_0);
			}
			else if (igeometry_0 is Interface25)
			{
				this.method_7((Interface25)igeometry_0, int_0, textWriter_0);
			}
			else if (igeometry_0 is IMultiPolygon)
			{
				this.method_8((IMultiPolygon)igeometry_0, int_0, textWriter_0);
			}
			else if (igeometry_0 is IGeometryCollection)
			{
				this.method_9((IGeometryCollection)igeometry_0, int_0, textWriter_0);
			}
			else
			{
				Class570.smethod_2("Unsupported Geometry implementation:" + igeometry_0.GetType());
			}
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0001083D File Offset: 0x0000EA3D
		private void method_2(ICoordinate icoordinate_0, int int_0, TextWriter textWriter_0, IPrecisionModel iprecisionModel_0)
		{
			textWriter_0.Write("POINT");
			this.method_10(icoordinate_0, int_0, textWriter_0, iprecisionModel_0);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00010855 File Offset: 0x0000EA55
		private void method_3(ILineString ilineString_0, int int_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("LINESTRING");
			this.method_13(ilineString_0, int_0, false, textWriter_0);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x0001086C File Offset: 0x0000EA6C
		private void method_4(ILinearRing ilinearRing_0, int int_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("LINEARRING");
			this.method_13(ilinearRing_0, int_0, false, textWriter_0);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00010883 File Offset: 0x0000EA83
		private void method_5(IPolygon ipolygon_0, int int_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("POLYGON");
			this.method_14(ipolygon_0, int_0, false, textWriter_0);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x0001089A File Offset: 0x0000EA9A
		private void method_6(IMultiPoint imultiPoint_0, int int_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("MULTIPOINT");
			this.method_15(imultiPoint_0, int_0, textWriter_0);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x000108B0 File Offset: 0x0000EAB0
		private void method_7(Interface25 interface25_0, int int_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("MULTILINESTRING");
			this.method_16(interface25_0, int_0, false, textWriter_0);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x000108C7 File Offset: 0x0000EAC7
		private void method_8(IMultiPolygon imultiPolygon_0, int int_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("MULTIPOLYGON");
			this.method_17(imultiPolygon_0, int_0, textWriter_0);
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x000108DD File Offset: 0x0000EADD
		private void method_9(IGeometryCollection igeometryCollection_0, int int_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("GEOMETRYCOLLECTION");
			this.method_18(igeometryCollection_0, int_0, textWriter_0);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x000108F3 File Offset: 0x0000EAF3
		private void method_10(ICoordinate icoordinate_0, int int_0, TextWriter textWriter_0, IPrecisionModel iprecisionModel_0)
		{
			if (icoordinate_0 == null)
			{
				textWriter_0.Write(" EMPTY");
			}
			else
			{
				textWriter_0.Write("(");
				this.method_11(icoordinate_0, textWriter_0, iprecisionModel_0);
				textWriter_0.Write(")");
			}
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x0009A9FC File Offset: 0x00098BFC
		private void method_11(ICoordinate icoordinate_0, TextWriter textWriter_0, IPrecisionModel iprecisionModel_0)
		{
			textWriter_0.Write(this.method_12(icoordinate_0.imethod_0()) + " " + this.method_12(icoordinate_0.imethod_2()));
			if (!double.IsNaN(icoordinate_0.imethod_4()))
			{
				textWriter_0.Write(" " + this.method_12(icoordinate_0.imethod_4()));
			}
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0009AA5C File Offset: 0x00098C5C
		private string method_12(double double_0)
		{
			string text = double_0.ToString(this.string_1, this.numberFormatInfo_0);
			string result;
			if (!this.bool_1)
			{
				result = text;
			}
			else
			{
				double num = Convert.ToDouble(text, this.numberFormatInfo_0);
				if (num != double_0)
				{
					result = string.Format(this.numberFormatInfo_0, this.string_0, new object[]
					{
						double_0
					});
				}
				else
				{
					result = text;
				}
			}
			return result;
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0009AAD0 File Offset: 0x00098CD0
		private void method_13(ILineString ilineString_0, int int_0, bool bool_2, TextWriter textWriter_0)
		{
			if (ilineString_0.imethod_10())
			{
				textWriter_0.Write(" EMPTY");
			}
			else
			{
				if (bool_2)
				{
					this.method_19(int_0, textWriter_0);
				}
				textWriter_0.Write("(");
				for (int i = 0; i < ilineString_0.imethod_3(); i++)
				{
					if (i > 0)
					{
						textWriter_0.Write(",");
						if (i % 10 == 0)
						{
							this.method_19(int_0 + 2, textWriter_0);
						}
					}
					this.method_11(ilineString_0.imethod_13(i), textWriter_0, ilineString_0.imethod_1());
				}
				textWriter_0.Write(")");
			}
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x0009AB74 File Offset: 0x00098D74
		private void method_14(IPolygon ipolygon_0, int int_0, bool bool_2, TextWriter textWriter_0)
		{
			if (ipolygon_0.imethod_10())
			{
				textWriter_0.Write(" EMPTY");
			}
			else
			{
				if (bool_2)
				{
					this.method_19(int_0, textWriter_0);
				}
				textWriter_0.Write("(");
				this.method_13(ipolygon_0.imethod_11(), int_0, false, textWriter_0);
				for (int i = 0; i < ipolygon_0.imethod_13(); i++)
				{
					textWriter_0.Write(",");
					this.method_13(ipolygon_0.imethod_15(i), int_0 + 1, true, textWriter_0);
				}
				textWriter_0.Write(")");
			}
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x0009AC04 File Offset: 0x00098E04
		private void method_15(IMultiPoint imultiPoint_0, int int_0, TextWriter textWriter_0)
		{
			if (imultiPoint_0.imethod_10())
			{
				textWriter_0.Write(" EMPTY");
			}
			else
			{
				textWriter_0.Write("(");
				for (int i = 0; i < imultiPoint_0.imethod_2(); i++)
				{
					if (i > 0)
					{
						textWriter_0.Write(",");
					}
					this.method_11(((IPoint)imultiPoint_0.imethod_9(i)).imethod_5(), textWriter_0, imultiPoint_0.imethod_1());
				}
				textWriter_0.Write(")");
			}
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x0009AC84 File Offset: 0x00098E84
		private void method_16(Interface25 interface25_0, int int_0, bool bool_2, TextWriter textWriter_0)
		{
			if (interface25_0.imethod_10())
			{
				textWriter_0.Write(" EMPTY");
			}
			else
			{
				int int_ = int_0;
				bool bool_3 = bool_2;
				textWriter_0.Write("(");
				for (int i = 0; i < interface25_0.imethod_2(); i++)
				{
					if (i > 0)
					{
						textWriter_0.Write(",");
						int_ = int_0 + 1;
						bool_3 = true;
					}
					this.method_13((ILineString)interface25_0.imethod_9(i), int_, bool_3, textWriter_0);
				}
				textWriter_0.Write(")");
			}
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0009AD0C File Offset: 0x00098F0C
		private void method_17(IMultiPolygon imultiPolygon_0, int int_0, TextWriter textWriter_0)
		{
			if (imultiPolygon_0.imethod_10())
			{
				textWriter_0.Write(" EMPTY");
			}
			else
			{
				int int_ = int_0;
				bool bool_ = false;
				textWriter_0.Write("(");
				for (int i = 0; i < imultiPolygon_0.imethod_2(); i++)
				{
					if (i > 0)
					{
						textWriter_0.Write(",");
						int_ = int_0 + 1;
						bool_ = true;
					}
					this.method_14((IPolygon)imultiPolygon_0.imethod_9(i), int_, bool_, textWriter_0);
				}
				textWriter_0.Write(")");
			}
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x0009AD90 File Offset: 0x00098F90
		private void method_18(IGeometryCollection igeometryCollection_0, int int_0, TextWriter textWriter_0)
		{
			if (igeometryCollection_0.imethod_10())
			{
				textWriter_0.Write(" EMPTY");
			}
			else
			{
				int int_ = int_0;
				textWriter_0.Write("(");
				for (int i = 0; i < igeometryCollection_0.imethod_2(); i++)
				{
					if (i > 0)
					{
						textWriter_0.Write(",");
						int_ = int_0 + 1;
					}
					this.method_1(igeometryCollection_0.imethod_9(i), int_, textWriter_0);
				}
				textWriter_0.Write(")");
			}
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x0001092B File Offset: 0x0000EB2B
		private void method_19(int int_0, TextWriter textWriter_0)
		{
			if (this.bool_0 && int_0 > 0)
			{
				textWriter_0.Write("\n");
				textWriter_0.Write(Class632.smethod_1(' ', 2 * int_0));
			}
		}

		// Token: 0x04000A54 RID: 2644
		private readonly string string_0 = "{0:R}";

		// Token: 0x04000A55 RID: 2645
		private NumberFormatInfo numberFormatInfo_0;

		// Token: 0x04000A56 RID: 2646
		private string string_1;

		// Token: 0x04000A57 RID: 2647
		private bool bool_0 = false;

		// Token: 0x04000A58 RID: 2648
		private bool bool_1 = false;
	}
}
