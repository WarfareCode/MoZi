using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using GisSharpBlog.NetTopologySuite.IO;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns12;
using ns14;
using ns16;
using ns18;
using ns19;
using ns32;

namespace ns35
{
	// Token: 0x02000A8A RID: 2698
	public sealed class Class2537
	{
		// Token: 0x02000A8B RID: 2699
		public struct Struct87
		{
			// Token: 0x04002949 RID: 10569
			public CustomVertex.PositionColored[] positionColored_0;
		}

		// Token: 0x02000A8C RID: 2700
		public struct Struct88
		{
			// Token: 0x0400294A RID: 10570
			public Class2537.Struct87[] struct87_0;

			// Token: 0x0400294B RID: 10571
			public BoundingBox class1941_0;
		}

		// Token: 0x02000A8D RID: 2701
		public sealed class Class2001 : RenderableObject
		{
			// Token: 0x0600552F RID: 21807 RVA: 0x002383B0 File Offset: 0x002365B0
			public Class2001(string LayerName, World parentWorld, double Altitude, string SHPFilePath, Color lineColor, double MinViewAltitude = 0.0, double MaxViewAltitude = 100000.0) : base(LayerName, parentWorld)
			{
				this.IsLayerBordersShown = true;
				this.linkedList_0 = new LinkedList<Class2537.Struct88>();
				this.bool_4 = true;
				this.color_0 = lineColor;
				this.double_1 = Altitude;
				this.class1995_1 = parentWorld;
				this.string_2 = SHPFilePath;
				this.double_0 = this.class1995_1.GetEquatorialRadius() + this.double_1;
				this.double_3 = MaxViewAltitude + this.class1995_1.GetEquatorialRadius();
				this.double_2 = MinViewAltitude + this.class1995_1.GetEquatorialRadius();
			}

			// Token: 0x06005530 RID: 21808 RVA: 0x000272F0 File Offset: 0x000254F0
			public override void Dispose()
			{
				this.isInitialized = false;
			}

			// Token: 0x06005531 RID: 21809 RVA: 0x00238468 File Offset: 0x00236668
			private void method_0(ILinearRing LR, ref Class2537.Struct87 DXLR, bool IsZ = false)
			{
				int num = LR.imethod_3();
				DXLR = default(Class2537.Struct87);
				DXLR.positionColored_0 = new CustomVertex.PositionColored[LR.imethod_3() + 1];
				ICoordinateSequence coordinateSequence = LR.imethod_11();
				int num2 = num - 1;
				for (int i = 0; i <= num2; i++)
				{
					double latitude = coordinateSequence.imethod_1(i, Enum142.const_1);
					double longitude = coordinateSequence.imethod_1(i, Enum142.const_0);
					double num3;
					if (IsZ)
					{
						num3 = coordinateSequence.imethod_1(i, Enum142.const_2);
					}
					else
					{
						num3 = 0.0;
					}
					DXLR.positionColored_0[i].Position = MathEngine.SphericalToCartesian(latitude, longitude, this.double_0 + num3);
					DXLR.positionColored_0[i].Color = this.color_0.ToArgb();
				}
				DXLR.positionColored_0[DXLR.positionColored_0.Length - 1] = DXLR.positionColored_0[0];
			}

			// Token: 0x06005532 RID: 21810 RVA: 0x0023855C File Offset: 0x0023675C
			private void method_1(ILineString LR, ref Class2537.Struct87 DXLR, bool IsZ = false)
			{
				DXLR = default(Class2537.Struct87);
				DXLR.positionColored_0 = new CustomVertex.PositionColored[LR.imethod_3() + 1];
				ICoordinateSequence coordinateSequence = LR.imethod_11();
				int num = LR.imethod_3() - 1;
				for (int i = 0; i <= num; i++)
				{
					double latitude = coordinateSequence.imethod_1(i, Enum142.const_1);
					double longitude = coordinateSequence.imethod_1(i, Enum142.const_0);
					double num2;
					if (IsZ)
					{
						num2 = coordinateSequence.imethod_1(i, Enum142.const_2);
					}
					else
					{
						num2 = 0.0;
					}
					DXLR.positionColored_0[i].Position = MathEngine.SphericalToCartesian(latitude, longitude, this.double_0 + num2);
					DXLR.positionColored_0[i].Color = this.color_0.ToArgb();
				}
				DXLR.positionColored_0[DXLR.positionColored_0.Length - 1] = DXLR.positionColored_0[0];
			}

			// Token: 0x06005533 RID: 21811 RVA: 0x0023864C File Offset: 0x0023684C
			private void method_2(ILineString LR, ref Class2537.Struct87 DXLR, bool IsZ = false)
			{
				DXLR = default(Class2537.Struct87);
				DXLR.positionColored_0 = new CustomVertex.PositionColored[LR.imethod_3() - 1 + 1];
				ICoordinateSequence coordinateSequence = LR.imethod_11();
				int num = LR.imethod_3() - 1;
				for (int i = 0; i <= num; i++)
				{
					double latitude = coordinateSequence.imethod_1(i, Enum142.const_1);
					double longitude = coordinateSequence.imethod_1(i, Enum142.const_0);
					double num2;
					if (IsZ)
					{
						num2 = coordinateSequence.imethod_1(i, Enum142.const_2);
					}
					else
					{
						num2 = 0.0;
					}
					DXLR.positionColored_0[i].Position = MathEngine.SphericalToCartesian(latitude, longitude, this.double_0 + num2);
					DXLR.positionColored_0[i].Color = this.color_0.ToArgb();
				}
			}

			// Token: 0x06005534 RID: 21812 RVA: 0x00238714 File Offset: 0x00236914
			public override void Initialize(DrawArgs class1943_1)
			{
				try
				{
					this.class1943_0 = class1943_1;
					this.device_0 = Client.m_WorldWindow.method_1();
					this.linkedList_0.Clear();
					bool isZ = false;
					int num = 0;
					int num2 = 0;
					Class598 @class = new Class598(this.string_2);
					ShapeGeometryType shapeGeometryType = @class.method_0().method_1();
					if (shapeGeometryType == ShapeGeometryType.LineStringZ | shapeGeometryType == ShapeGeometryType.LineStringZM | shapeGeometryType == ShapeGeometryType.MultiPointZ | shapeGeometryType == ShapeGeometryType.MultiPointZM | shapeGeometryType == ShapeGeometryType.PointZ | shapeGeometryType == ShapeGeometryType.PointZM | shapeGeometryType == ShapeGeometryType.PolygonZ | shapeGeometryType == ShapeGeometryType.PolygonZM)
					{
						isZ = true;
					}
					if (shapeGeometryType != ShapeGeometryType.NullShape)
					{
						Class2537.Struct88 value = default(Class2537.Struct88);
						if (shapeGeometryType <= ShapeGeometryType.LineStringZ)
						{
							switch (shapeGeometryType)
							{
							case ShapeGeometryType.Point:
							case ShapeGeometryType.LineString:
								break;
							case (ShapeGeometryType)2:
							case (ShapeGeometryType)4:
								goto IL_5C6;
							case ShapeGeometryType.Polygon:
								goto IL_2B6;
							default:
								if (shapeGeometryType - ShapeGeometryType.PointZ > 1)
								{
									goto IL_5C6;
								}
								break;
							}
						}
						else
						{
							if (shapeGeometryType == ShapeGeometryType.PolygonZM)
							{
								goto IL_2B6;
							}
							switch (shapeGeometryType)
							{
							case ShapeGeometryType.PolygonZ:
							case ShapeGeometryType.PolygonM:
								goto IL_2B6;
							case ShapeGeometryType.MultiPointZ:
							case (ShapeGeometryType)22:
							case (ShapeGeometryType)24:
								goto IL_5C6;
							case ShapeGeometryType.PointM:
							case ShapeGeometryType.LineStringM:
								break;
							default:
								goto IL_5C6;
							}
						}
						IEnumerator enumerator = @class.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								IGeometry geometry = (IGeometry)enumerator.Current;
								if (geometry.GetType() == typeof(LineString))
								{
									LineString lineString = (LineString)geometry;
									num2 += lineString.imethod_2();
									value.struct87_0 = new Class2537.Struct87[1];
									this.method_2(lineString, ref value.struct87_0[0], isZ);
									float float_ = (float)Math.Max(-90.0, @class.method_0().method_0().imethod_4());
									float float_2 = (float)Math.Min(90.0, @class.method_0().method_0().imethod_2());
									float num3 = (float)@class.method_0().method_0().imethod_1();
									if (num3 > 180f)
									{
										num3 -= 360f;
									}
									float num4 = (float)@class.method_0().method_0().imethod_3();
									if (num4 > 180f)
									{
										num4 -= 360f;
									}
									if (num4 > num3)
									{
										float num5 = num4;
										num4 = num3;
										num3 = num5;
									}
									value.class1941_0 = new BoundingBox(float_, float_2, num4, num3, (float)this.vmethod_4().GetEquatorialRadius(), (float)this.double_3);
									this.linkedList_0.AddLast(value);
								}
							}
						}
						finally
						{
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						if (shapeGeometryType == ShapeGeometryType.Point || shapeGeometryType == ShapeGeometryType.PointM || shapeGeometryType == ShapeGeometryType.PointZ || shapeGeometryType == ShapeGeometryType.PointZM)
						{
							this.bool_4 = false;
							goto IL_5C6;
						}
						goto IL_5C6;
						IL_2B6:
						IEnumerator enumerator2 = @class.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								IGeometry geometry2 = (IGeometry)enumerator2.Current;
								if (geometry2.GetType() == typeof(MultiPolygon))
								{
									MultiPolygon multiPolygon = (MultiPolygon)geometry2;
									num += multiPolygon.imethod_2();
									int num6 = multiPolygon.imethod_2() - 1;
									for (int i = 0; i <= num6; i++)
									{
										Polygon polygon = (Polygon)multiPolygon.imethod_9(i);
										num2 += polygon.imethod_2();
										if (polygon.imethod_13() > 0)
										{
											value.struct87_0 = new Class2537.Struct87[polygon.imethod_13() + 1];
											this.method_0(polygon.imethod_12(), ref value.struct87_0[0], isZ);
											int num7 = 1;
											ILineString[] array = polygon.imethod_14();
											for (int j = 0; j < array.Length; j = checked(j + 1))
											{
												ILineString lR = array[j];
												this.method_1(lR, ref value.struct87_0[num7], isZ);
												num7++;
											}
										}
										else
										{
											value.struct87_0 = new Class2537.Struct87[1];
											this.method_0(polygon.imethod_12(), ref value.struct87_0[0], isZ);
										}
									}
								}
								else
								{
									Polygon polygon2 = (Polygon)geometry2;
									num2 += polygon2.imethod_2();
									if (polygon2.imethod_13() > 0)
									{
										value.struct87_0 = new Class2537.Struct87[polygon2.imethod_13() + 1];
										this.method_0(polygon2.imethod_12(), ref value.struct87_0[0], isZ);
										int num7 = 1;
										ILineString[] array2 = polygon2.imethod_14();
										for (int k = 0; k < array2.Length; k = checked(k + 1))
										{
											ILineString lR2 = array2[k];
											this.method_1(lR2, ref value.struct87_0[num7], isZ);
											num7++;
										}
									}
									else
									{
										value.struct87_0 = new Class2537.Struct87[1];
										this.method_0(polygon2.imethod_12(), ref value.struct87_0[0], isZ);
									}
								}
								float float_3 = (float)Math.Max(-90.0, @class.method_0().method_0().imethod_4());
								float float_4 = (float)Math.Min(90.0, @class.method_0().method_0().imethod_2());
								float num8 = (float)@class.method_0().method_0().imethod_1();
								if (num8 > 180f)
								{
									num8 -= 360f;
								}
								float num9 = (float)@class.method_0().method_0().imethod_3();
								if (num9 > 180f)
								{
									num9 -= 360f;
								}
								if (num9 > num8)
								{
									float num10 = num9;
									num9 = num8;
									num8 = num10;
								}
								value.class1941_0 = new BoundingBox(float_3, float_4, num9, num8, (float)this.vmethod_4().GetEquatorialRadius(), (float)this.double_3);
								this.linkedList_0.AddLast(value);
							}
						}
						finally
						{
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
					IL_5C6:
					this.isInitialized = true;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					else
					{
						Interaction.MsgBox("Exception: " + ex2.Message + "\r\nStackTrace: " + ex2.StackTrace, MsgBoxStyle.OkOnly, null);
					}
					ProjectData.ClearProjectError();
				}
			}

			// Token: 0x06005535 RID: 21813 RVA: 0x00238D88 File Offset: 0x00236F88
			public override bool PerformSelectionAction(DrawArgs class1943_1)
			{
				bool result;
				if (DrawArgs.bool_1)
				{
					Class2537.Class2001.Delegate65 @delegate = this.delegate65_0;
					if (@delegate != null)
					{
						@delegate(new MouseEventArgs(MouseButtons.Right, 1, DrawArgs.point_0.X, DrawArgs.point_0.Y, 1));
					}
					result = true;
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x06005536 RID: 21814 RVA: 0x00238DDC File Offset: 0x00236FDC
			private void method_3(DrawArgs class1943_1)
			{
				LinkedListNode<Class2537.Struct88> linkedListNode = this.linkedList_0.First;
				bool alphaBlendEnable = this.device_0.RenderState.AlphaBlendEnable;
				Blend sourceBlend = this.device_0.RenderState.SourceBlend;
				Blend destinationBlend = this.device_0.RenderState.DestinationBlend;
				BlendOperation blendOperation = this.device_0.RenderState.BlendOperation;
				Cull cullMode = this.device_0.RenderState.CullMode;
				this.device_0.RenderState.CullMode = Cull.None;
				this.device_0.VertexFormat = (VertexFormats.Diffuse | VertexFormats.Position);
				this.device_0.Transform.World = Matrix.Translation(-(float)class1943_1.GetWorldCamera().ReferenceCenter.X, -(float)class1943_1.GetWorldCamera().ReferenceCenter.Y, -(float)class1943_1.GetWorldCamera().ReferenceCenter.Z);
				this.device_0.TextureState[0].ColorArgument0 = TextureArgument.Constant;
				this.device_0.TextureState[0].ColorArgument1 = TextureArgument.Constant;
				this.device_0.TextureState[0].ColorArgument2 = TextureArgument.Constant;
				this.device_0.TextureState[0].ConstantColor = Color.Yellow;
				this.device_0.TextureState[0].ColorOperation = TextureOperation.SelectArg1;
				this.device_0.RenderState.SourceBlend = Blend.BlendFactor;
				this.device_0.RenderState.DestinationBlend = Blend.InvBlendFactor;
				int num;
				if (CommandFactory.GetCommandMain().GetMainForm().method_15())
				{
					num = 255;
				}
				else
				{
					num = (int)Math.Round(class1943_1.GetWorldCamera().GetAltitude() / 2500.0);
				}
				if (num > 255)
				{
					num = 255;
				}
				if (num <= 0)
				{
					num = 0;
				}
				this.device_0.RenderState.BlendFactor = Color.FromArgb(num, num, num, 0);
				Class2537.Struct88 @struct;
				while (linkedListNode != null)
				{
					@struct = linkedListNode.Value;
					if (@struct.struct87_0 != null && @struct.struct87_0.Length != 0)
					{
						int num2 = @struct.struct87_0.Length - 1;
						for (int i = 0; i <= num2; i++)
						{
							if (@struct.struct87_0[i].positionColored_0.Length != 0)
							{
								if (this.bool_4)
								{
									this.device_0.DrawUserPrimitives(PrimitiveType.LineStrip, @struct.struct87_0[i].positionColored_0.Length - 1, @struct.struct87_0[i].positionColored_0);
								}
								else
								{
									this.device_0.DrawUserPrimitives(PrimitiveType.PointList, @struct.struct87_0[i].positionColored_0.Length, @struct.struct87_0[i].positionColored_0);
								}
							}
						}
						linkedListNode = linkedListNode.Next;
					}
				}
				this.device_0.RenderState.CullMode = cullMode;
				@struct = default(Class2537.Struct88);
				this.device_0.RenderState.AlphaBlendEnable = alphaBlendEnable;
				this.device_0.RenderState.SourceBlend = sourceBlend;
				this.device_0.RenderState.DestinationBlend = destinationBlend;
				this.device_0.RenderState.BlendOperation = blendOperation;
			}

			// Token: 0x06005537 RID: 21815 RVA: 0x000272F9 File Offset: 0x000254F9
			public override void Render(DrawArgs class1943_1)
			{
				if (this.isInitialized && this.IsLayerBordersShown)
				{
					this.method_3(class1943_1);
				}
			}

			// Token: 0x06005538 RID: 21816 RVA: 0x00027318 File Offset: 0x00025518
			public override RenderPriority vmethod_6()
			{
				return RenderPriority.const_3;
			}

			// Token: 0x06005539 RID: 21817 RVA: 0x0002731F File Offset: 0x0002551F
			public  void vmethod_7(RenderPriority enum153_1)
			{
				base.vmethod_7(enum153_1);
			}

			// Token: 0x0600553A RID: 21818 RVA: 0x0000945D File Offset: 0x0000765D
			public override bool Update(DrawArgs class1943_1)
			{
				return true;
			}

			// Token: 0x0400294C RID: 10572
			public bool IsLayerBordersShown;

			// Token: 0x0400294D RID: 10573
			protected DrawArgs class1943_0;

			// Token: 0x0400294E RID: 10574
			protected Device device_0;

			// Token: 0x0400294F RID: 10575
			protected double double_0;

			// Token: 0x04002950 RID: 10576
			protected World class1995_1;

			// Token: 0x04002951 RID: 10577
			public LinkedList<Class2537.Struct88> linkedList_0;

			// Token: 0x04002952 RID: 10578
			protected bool bool_4;

			// Token: 0x04002953 RID: 10579
			protected double double_1;

			// Token: 0x04002954 RID: 10580
			protected Color color_0;

			// Token: 0x04002955 RID: 10581
			protected string string_2 = "";

			// Token: 0x04002956 RID: 10582
			protected double double_2 = 0.0;

			// Token: 0x04002957 RID: 10583
			protected double double_3 = 0.0;

			// Token: 0x04002958 RID: 10584
			[CompilerGenerated]
			private Class2537.Class2001.Delegate65 delegate65_0;

			// Token: 0x02000A8E RID: 2702
			// (Invoke) Token: 0x0600553C RID: 21820
			public delegate void Delegate65(MouseEventArgs e);
		}
	}
}
