using System;
using System.Globalization;
using System.IO;
using System.Text;
using DotSpatial.Topology;
using ns24;

namespace ns25
{
	// Token: 0x0200062F RID: 1583
	public sealed class WktWriter
	{
		// Token: 0x06002812 RID: 10258 RVA: 0x000F1DE0 File Offset: 0x000EFFE0
		private static NumberFormatInfo CreateFormatter(PrecisionModel precisionModel_0)
		{
			int maximumSignificantDigits = precisionModel_0.GetMaximumSignificantDigits();
			return new NumberFormatInfo
			{
				NumberDecimalSeparator = ".",
				NumberDecimalDigits = maximumSignificantDigits,
				NumberGroupSeparator = string.Empty,
				NumberGroupSizes = new int[0]
			};
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x0009A7D0 File Offset: 0x000989D0
		public static string StringOfChar(char char_0, int int_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < int_0; i++)
			{
				stringBuilder.Append(char_0);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x000F1E28 File Offset: 0x000F0028
		public  string Write(Geometry geometry_0)
		{
			TextWriter textWriter = new StringWriter();
			this.WriteFormatted(geometry_0, false, textWriter);
			return textWriter.ToString();
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x000163BC File Offset: 0x000145BC
		private void WriteFormatted(IGeometry igeometry_0, bool bool_1, TextWriter textWriter_0)
		{
			this._isFormatted = bool_1;
			this._formatter = WktWriter.CreateFormatter(new PrecisionModel(igeometry_0.GetPrecisionModel()));
			this.AppendGeometryTaggedText(igeometry_0, 0, textWriter_0);
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x000F1E4C File Offset: 0x000F004C
		private void AppendGeometryTaggedText(IGeometry geometry, int level, TextWriter textWriter_0)
		{
			this.Indent(level, textWriter_0);
			if (geometry is Point)
			{
				Point point = (Point)geometry;
				this.AppendPointTaggedText(point.GetCoordinate(), textWriter_0);
			}
			else if (geometry is ILinearRing)
			{
				this.AppendLinearRingTaggedText((ILinearRing)geometry, level, textWriter_0);
			}
			else if (geometry is ILineString)
			{
				this.AppendLineStringTaggedText((ILineString)geometry, level, textWriter_0);
			}
			else if (geometry is IPolygon)
			{
				this.AppendPolygonTaggedText((IPolygon)geometry, level, textWriter_0);
			}
			else if (geometry is IMultiPoint)
			{
				this.AppendMultiPointTaggedText((IMultiPoint)geometry, textWriter_0);
			}
			else if (geometry is IMultiLineString)
			{
				this.AppendMultiLineStringTaggedText((IMultiLineString)geometry, level, textWriter_0);
			}
			else if (geometry is IMultiPolygon)
			{
				this.AppendMultiPolygonTaggedText((IMultiPolygon)geometry, level, textWriter_0);
			}
			else
			{
				if (!(geometry is IGeometryCollection))
				{
					throw new Exception21();
				}
				this.AppendGeometryCollectionTaggedText((IGeometryCollection)geometry, level, textWriter_0);
			}
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x000163E4 File Offset: 0x000145E4
		private void AppendPointTaggedText(Coordinate coordinate_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("POINT ");
			this.AppendPointText(coordinate_0, textWriter_0);
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x000163F9 File Offset: 0x000145F9
		private void AppendLineStringTaggedText(IBasicLineString interface33_0, int int_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("LINESTRING ");
			this.AppendLineStringText(interface33_0, int_0, false, textWriter_0);
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x00016410 File Offset: 0x00014610
		private void AppendLinearRingTaggedText(ILinearRing ilinearRing_0, int int_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("LINEARRING ");
			this.AppendLineStringText(ilinearRing_0, int_0, false, textWriter_0);
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00016427 File Offset: 0x00014627
		private void AppendPolygonTaggedText(IPolygon ipolygon_0, int int_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("POLYGON ");
			this.AppendPolygonText(ipolygon_0, int_0, false, textWriter_0);
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x0001643E File Offset: 0x0001463E
		private void AppendMultiPointTaggedText(IMultiPoint imultiPoint_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("MULTIPOINT ");
			this.AppendMultiPointText(imultiPoint_0, textWriter_0);
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x00016453 File Offset: 0x00014653
		private void AppendMultiLineStringTaggedText(IMultiLineString interface41_0, int int_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("MULTILINESTRING ");
			this.AppendMultiLineStringText(interface41_0, int_0, false, textWriter_0);
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x0001646A File Offset: 0x0001466A
		private void AppendMultiPolygonTaggedText(IMultiPolygon imultiPolygon_0, int int_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("MULTIPOLYGON ");
			this.AppendMultiPolygonText(imultiPolygon_0, int_0, textWriter_0);
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x00016480 File Offset: 0x00014680
		private void AppendGeometryCollectionTaggedText(IGeometryCollection igeometryCollection_0, int int_0, TextWriter textWriter_0)
		{
			textWriter_0.Write("GEOMETRYCOLLECTION ");
			this.AppendGeometryCollectionText(igeometryCollection_0, int_0, textWriter_0);
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00016496 File Offset: 0x00014696
		private void AppendPointText(Coordinate coordinate_0, TextWriter textWriter_0)
		{
			if (Coordinate.Equals(coordinate_0, null))
			{
				textWriter_0.Write("EMPTY");
			}
			else
			{
				textWriter_0.Write("(");
				this.AppendCoordinate(coordinate_0, textWriter_0);
				textWriter_0.Write(")");
			}
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x000164CF File Offset: 0x000146CF
		private void AppendCoordinate(Coordinate coordinate_0, TextWriter textWriter_0)
		{
			textWriter_0.Write(this.WriteNumber(coordinate_0.X) + " " + this.WriteNumber(coordinate_0.Y));
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x000F1F60 File Offset: 0x000F0160
		private string WriteNumber(double double_0)
		{
			return double_0.ToString("N", this._formatter);
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x000F1F84 File Offset: 0x000F0184
		private void AppendLineStringText(IBasicLineString lineString, int level, bool doIndent, TextWriter textWriter_0)
		{
			if (lineString.GetCoordinates().Count == 0)
			{
				textWriter_0.Write("EMPTY");
			}
			else
			{
				if (doIndent)
				{
					this.Indent(level, textWriter_0);
				}
				textWriter_0.Write("(");
				for (int i = 0; i < lineString.GetNumPoints(); i++)
				{
					if (i > 0)
					{
						textWriter_0.Write(", ");
						if (i % 10 == 0)
						{
							this.Indent(level + 2, textWriter_0);
						}
					}
					this.AppendCoordinate(lineString.GetCoordinates()[i], textWriter_0);
				}
				textWriter_0.Write(")");
			}
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x000F202C File Offset: 0x000F022C
		private void AppendPolygonText(IPolygon ipolygon_0, int int_0, bool bool_1, TextWriter textWriter_0)
		{
			if (ipolygon_0.IsEmpty())
			{
				textWriter_0.Write("EMPTY");
			}
			else
			{
				if (bool_1)
				{
					this.Indent(int_0, textWriter_0);
				}
				textWriter_0.Write("(");
				this.AppendLineStringText(ipolygon_0.GetShell(), int_0, false, textWriter_0);
				for (int i = 0; i < ipolygon_0.GetNumHoles(); i++)
				{
					textWriter_0.Write(", ");
					this.AppendLineStringText(ipolygon_0.GetInteriorRingN(i), int_0 + 1, true, textWriter_0);
				}
				textWriter_0.Write(")");
			}
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x000F20BC File Offset: 0x000F02BC
		private void AppendMultiPointText(IGeometry igeometry_0, TextWriter textWriter_0)
		{
			if (igeometry_0.IsEmpty())
			{
				textWriter_0.Write("EMPTY");
			}
			else
			{
				textWriter_0.Write("(");
				for (int i = 0; i < igeometry_0.GetNumGeometries(); i++)
				{
					if (i > 0)
					{
						textWriter_0.Write(", ");
					}
					this.AppendCoordinate(((Point)igeometry_0.GetGeometryN(i)).GetCoordinate(), textWriter_0);
				}
				textWriter_0.Write(")");
			}
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x000F2138 File Offset: 0x000F0338
		private void AppendMultiLineStringText(IMultiLineString multiLineString, int int_0, bool bool_1, TextWriter textWriter_0)
		{
			if (multiLineString.IsEmpty())
			{
				textWriter_0.Write("EMPTY");
			}
			else
			{
				int level = int_0;
				bool doIndent = bool_1;
				textWriter_0.Write("(");
				for (int i = 0; i < multiLineString.GetNumGeometries(); i++)
				{
					if (i > 0)
					{
						textWriter_0.Write(", ");
						level = int_0 + 1;
						doIndent = true;
					}
					this.AppendLineStringText((LineString)multiLineString.GetGeometryN(i), level, doIndent, textWriter_0);
				}
				textWriter_0.Write(")");
			}
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x000F21C0 File Offset: 0x000F03C0
		private void AppendMultiPolygonText(IMultiPolygon multiPolygon, int level, TextWriter textWriter_0)
		{
			if (multiPolygon.IsEmpty())
			{
				textWriter_0.Write("EMPTY");
			}
			else
			{
				int int_ = level;
				bool bool_ = false;
				textWriter_0.Write("(");
				for (int i = 0; i < multiPolygon.GetNumGeometries(); i++)
				{
					if (i > 0)
					{
						textWriter_0.Write(", ");
						int_ = level + 1;
						bool_ = true;
					}
					this.AppendPolygonText((Polygon)multiPolygon.GetGeometryN(i), int_, bool_, textWriter_0);
				}
				textWriter_0.Write(")");
			}
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x000F2244 File Offset: 0x000F0444
		private void AppendGeometryCollectionText(IGeometryCollection geometryCollection, int level, TextWriter textWriter_0)
		{
			if (geometryCollection.IsEmpty())
			{
				textWriter_0.Write("EMPTY");
			}
			else
			{
				int level2 = level;
				textWriter_0.Write("(");
				for (int i = 0; i < geometryCollection.GetNumGeometries(); i++)
				{
					if (i > 0)
					{
						textWriter_0.Write(", ");
						level2 = level + 1;
					}
					this.AppendGeometryTaggedText(geometryCollection.GetGeometryN(i), level2, textWriter_0);
				}
				textWriter_0.Write(")");
			}
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x000164F9 File Offset: 0x000146F9
		private void Indent(int int_0, TextWriter textWriter_0)
		{
			if (this._isFormatted && int_0 > 0)
			{
				textWriter_0.Write("\n");
				textWriter_0.Write(WktWriter.StringOfChar(' ', 2 * int_0));
			}
		}

		// Token: 0x04001343 RID: 4931
		private NumberFormatInfo _formatter;

		// Token: 0x04001344 RID: 4932
		private bool _isFormatted;
	}
}
