using System;
using System.Collections;
using System.Drawing;
using System.IO;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using ns16;
using ns17;
using ns18;

namespace ns19
{
	// Token: 0x020003DC RID: 988
	public sealed class World : RenderableObject
	{
		// Token: 0x06001887 RID: 6279 RVA: 0x0009793C File Offset: 0x00095B3C
		public IList method_0()
		{
			return this.onScreenMessages;
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x00097954 File Offset: 0x00095B54
		public WorldSurfaceRenderer GetWorldSurfaceRenderer()
		{
			return this.m_WorldSurfaceRenderer;
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x0001042F File Offset: 0x0000E62F
		public bool IsEarth()
		{
			return this.GetName() == "Earth";
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0009796C File Offset: 0x00095B6C
		public World(string string_2, Vector3 vector3_1, Quaternion quaternion_1, double double_1, string string_3, TerrainAccessor class1969_1) : base(string_2, vector3_1, quaternion_1)
		{
			this.equatorialRadius = double_1;
			this._terrainAccessor = class1969_1;
			this._renderableObjects = new RenderableObjectList(this.GetName());
			this.vmethod_10().Add("CacheDirectory", string_3);
			this.m_ProjectedVectorRenderer = new ProjectedVectorRenderer(this);
			this.m_AtmosphericScatteringSphere = new AtmosphericScatteringSphere();
			AtmosphericScatteringSphere.float_1 = (float)double_1;
			AtmosphericScatteringSphere.float_2 = (float)double_1 * 1.025f;
			this.m_AtmosphericScatteringSphere.method_0((float)double_1 * 1.025f, 75, 75);
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00097A20 File Offset: 0x00095C20
		private static string smethod_0(RenderableObject ro)
		{
			string result;
			if (ro.ParentList == null)
			{
				result = ro.GetName();
			}
			else
			{
				result = World.smethod_0(ro.ParentList) + Path.DirectorySeparatorChar.ToString() + ro.GetName();
			}
			return result;
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00097A6C File Offset: 0x00095C6C
		public TerrainAccessor GetTerrainAccessor()
		{
			return this._terrainAccessor;
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00097A84 File Offset: 0x00095C84
		public double GetEquatorialRadius()
		{
			return this.equatorialRadius;
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x00097A9C File Offset: 0x00095C9C
		public RenderableObjectList GetRenderableObjectList()
		{
			return this._renderableObjects;
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0001044D File Offset: 0x0000E64D
		public void SetRenderableObjectList(RenderableObjectList value)
		{
			this._renderableObjects = value;
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x00097AB4 File Offset: 0x00095CB4
		public override void Initialize(DrawArgs drawArgs)
		{
			try
			{
				if (!this.isInitialized)
				{
					this.GetRenderableObjectList().Initialize(drawArgs);
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				this.isInitialized = true;
			}
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00097B04 File Offset: 0x00095D04
		private void method_7(DrawArgs drawArgs)
		{
			CustomVertex.PositionColored[] array = new CustomVertex.PositionColored[2];
			Vector3 vector = MathEngine.SphericalToCartesian(90.0, 0.0, this.GetEquatorialRadius() + 0.15000000596046448 * this.GetEquatorialRadius());
			array[0].X = vector.X;
			array[0].Y = vector.Y;
			array[0].Z = vector.Z;
			array[0].Color = Color.Pink.ToArgb();
			Vector3 vector2 = MathEngine.SphericalToCartesian(-90.0, 0.0, this.GetEquatorialRadius() + 0.15000000596046448 * this.GetEquatorialRadius());
			array[1].X = vector2.X;
			array[1].Y = vector2.Y;
			array[1].Z = vector2.Z;
			array[1].Color = Color.Pink.ToArgb();
			drawArgs.device_0.VertexFormat = (VertexFormats.Diffuse | VertexFormats.Position);
			drawArgs.device_0.TextureState[0].ColorOperation = TextureOperation.Disable;
			drawArgs.device_0.Transform.World = Matrix.Translation(-(float)drawArgs.GetWorldCamera().ReferenceCenter.X, -(float)drawArgs.GetWorldCamera().ReferenceCenter.Y, -(float)drawArgs.GetWorldCamera().ReferenceCenter.Z);
			drawArgs.device_0.DrawUserPrimitives(PrimitiveType.LineStrip, 1, array);
			drawArgs.device_0.Transform.World = drawArgs.GetWorldCamera().GetWorldMatrix();
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00097CB8 File Offset: 0x00095EB8
		public override bool Update(DrawArgs drawArgs)
		{
			bool flag = false;
			if (!this.bool_3)
			{
				if (!this.isInitialized)
				{
					this.Initialize(drawArgs);
					flag = true;
				}
				if (this.GetRenderableObjectList() != null && this.GetRenderableObjectList().Update(drawArgs))
				{
					flag = true;
				}
				if (this.m_WorldSurfaceRenderer != null)
				{
					this.m_WorldSurfaceRenderer.method_9(drawArgs);
					flag = true;
				}
				if (this.m_ProjectedVectorRenderer != null)
				{
					this.m_ProjectedVectorRenderer.method_3(drawArgs);
					flag = true;
				}
				if (this.GetTerrainAccessor() != null)
				{
					if (drawArgs.GetWorldCamera().GetAltitude() < 300000.0)
					{
						if (DateTime.Now - this.lastElevationUpdate > TimeSpan.FromMilliseconds(500.0))
						{
							drawArgs.GetWorldCamera().SetTerrainElevation((short)this.GetTerrainAccessor().vmethod_0(drawArgs.GetWorldCamera().GetLatitude().GetDegrees(), drawArgs.GetWorldCamera().GetLongitude().GetDegrees(), 100.0 / drawArgs.GetWorldCamera().GetViewRange().GetDegrees()));
							this.lastElevationUpdate = DateTime.Now;
							flag = true;
						}
					}
					else
					{
						drawArgs.GetWorldCamera().SetTerrainElevation(0);
					}
				}
				else
				{
					drawArgs.GetWorldCamera().SetTerrainElevation(0);
				}
				if (World.Settings.method_0() && this.m_AtmosphericScatteringSphere != null)
				{
					this.m_AtmosphericScatteringSphere.method_3(drawArgs);
					flag = true;
				}
			}
			if (flag)
			{
				drawArgs.method_12(true);
			}
			return flag;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00010456 File Offset: 0x0000E656
		public override bool PerformSelectionAction(DrawArgs DrawArgs_)
		{
			return this._renderableObjects.PerformSelectionAction(DrawArgs_);
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00097E44 File Offset: 0x00096044
		public override void Render(DrawArgs drawArgs)
		{
			if (drawArgs.method_11())
			{
				int availableTextureMemory = drawArgs.device_0.AvailableTextureMemory;
				if (this.int_2 - availableTextureMemory > 10000)
				{
					this.int_2 = availableTextureMemory;
					Log.smethod_0(string.Format("TX MEM == {0}", this.int_2));
				}
				try
				{
					object syncRoot = this.GetRenderableObjectList().GetChildObjects().SyncRoot;
					lock (syncRoot)
					{
						if (this.m_WorldSurfaceRenderer != null && World.Settings.method_48())
						{
							this.m_WorldSurfaceRenderer.method_10(drawArgs);
						}
						this.method_8(this.GetRenderableObjectList(), RenderPriority.const_8, drawArgs);
						if (drawArgs.method_3().IsEarth() && World.Settings.method_0())
						{
							float aspectRatio = (float)drawArgs.GetWorldCamera().GetViewport().Width / (float)drawArgs.GetWorldCamera().GetViewport().Height;
							float znearPlane = (float)drawArgs.GetWorldCamera().GetAltitude() * 0.1f;
							double num = drawArgs.GetWorldCamera().GetAltitude() + this.equatorialRadius;
							double num2 = Math.Sqrt(num * num - this.equatorialRadius * this.equatorialRadius);
							double num3 = Math.Sqrt((double)(this.m_AtmosphericScatteringSphere.float_0 * this.m_AtmosphericScatteringSphere.float_0) + this.equatorialRadius * this.equatorialRadius);
							Matrix projection = drawArgs.device_0.Transform.Projection;
							drawArgs.device_0.Transform.Projection = Matrix.PerspectiveFovRH((float)drawArgs.GetWorldCamera().GetFov().Radians, aspectRatio, znearPlane, (float)(num2 + num3));
							drawArgs.device_0.RenderState.ZBufferEnable = false;
							drawArgs.device_0.RenderState.CullMode = Cull.CounterClockwise;
							this.m_AtmosphericScatteringSphere.method_11(drawArgs);
							drawArgs.device_0.RenderState.CullMode = Cull.Clockwise;
							drawArgs.device_0.RenderState.ZBufferEnable = true;
							drawArgs.device_0.Transform.Projection = projection;
						}
						this.method_8(this.GetRenderableObjectList(), RenderPriority.const_1, drawArgs);
						if (this.m_ProjectedVectorRenderer != null)
						{
							this.m_ProjectedVectorRenderer.method_4(drawArgs);
						}
						this.method_8(this.GetRenderableObjectList(), RenderPriority.const_2, drawArgs);
						this.method_8(this.GetRenderableObjectList(), RenderPriority.const_3, drawArgs);
						this.method_8(this.GetRenderableObjectList(), RenderPriority.Placenames, drawArgs);
						this.method_8(this.GetRenderableObjectList(), RenderPriority.const_4, drawArgs);
						this.method_8(this.GetRenderableObjectList(), RenderPriority.const_6, drawArgs);
						this.method_8(this.GetRenderableObjectList(), RenderPriority.const_7, drawArgs);
						if (World.Settings.bool_14)
						{
							this.method_7(drawArgs);
						}
					}
				}
				catch (Exception exception_)
				{
					Log.smethod_3(exception_);
				}
				drawArgs.method_12(false);
			}
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00098158 File Offset: 0x00096358
		private void method_8(RenderableObject ro, RenderPriority renderPriority, DrawArgs drawArgs)
		{
			drawArgs.method_0(renderPriority);
			if (ro.IsOn())
			{
				this.bool_3 = false;
				try
				{
					if (ro is RenderableObjectList)
					{
                        IEnumerator enumerator = ((RenderableObjectList)ro).GetChildObjects().GetEnumerator();
						{
							while (enumerator.MoveNext())
							{
								RenderableObject ro2 = (RenderableObject)enumerator.Current;
								this.method_8(ro2, renderPriority, drawArgs);
							}
							goto IL_B3;
						}
					}
					if (renderPriority == RenderPriority.const_1)
					{
						if (ro.vmethod_6() == RenderPriority.const_0 || ro.vmethod_6() == RenderPriority.const_1)
						{
							ro.Render(drawArgs);
						}
					}
					else if (ro.vmethod_6() == renderPriority)
					{
						ro.Render(drawArgs);
					}
					IL_B3:;
				}
				catch (Exception exception_)
				{
					Log.smethod_3(exception_);
				}
				this.bool_3 = false;
			}
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00098248 File Offset: 0x00096448
		private void saveRenderableState(RenderableObject ro)
		{
			string value = World.smethod_0(ro);
			bool flag = false;
			for (int i = 0; i < World.Settings.arrayList_0.Count; i++)
			{
				if (((string)World.Settings.arrayList_0[i]).Equals(value))
				{
					if (!ro.IsOn())
					{
						World.Settings.arrayList_0.RemoveAt(i);
						if (!flag && ro.IsOn())
						{
							World.Settings.arrayList_0.Add(value);
						}
						return;
					}
					flag = true;
				}
			}
			if (!flag && ro.IsOn())
			{
				World.Settings.arrayList_0.Add(value);
				return;
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x000982FC File Offset: 0x000964FC
		private void saveRenderableStates(RenderableObjectList rol)
		{
			this.saveRenderableState(rol);
			foreach (RenderableObject renderableObject in rol.GetChildObjects())
			{
				if (renderableObject is RenderableObjectList)
				{
					RenderableObjectList rol2 = (RenderableObjectList)renderableObject;
					this.saveRenderableStates(rol2);
				}
				else
				{
					this.saveRenderableState(renderableObject);
				}
			}
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00098380 File Offset: 0x00096580
		public override void Dispose()
		{
			this.saveRenderableStates(this.GetRenderableObjectList());
			if (this.GetRenderableObjectList() != null)
			{
				this.GetRenderableObjectList().Dispose();
				this.SetRenderableObjectList(null);
			}
			if (this.m_WorldSurfaceRenderer != null)
			{
				this.m_WorldSurfaceRenderer.method_7();
			}
			if (this.m_AtmosphericScatteringSphere != null)
			{
				this.m_AtmosphericScatteringSphere.method_1();
			}
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x000983E4 File Offset: 0x000965E4
		public static Angle ApproxAngularDistance(Angle latA, Angle lonA, Angle latB, Angle lonB)
		{
			Angle angle = Angle.Minus(lonB, lonA);
			double num = Math.Sin(Angle.Minus(latB, latA).Radians * 0.5);
			double num2 = Math.Sin(angle.Radians * 0.5);
			double d = num * num + Math.Cos(latA.Radians) * Math.Cos(latB.Radians) * num2 * num2;
			return Angle.FromRadians(2.0 * Math.Asin(Math.Min(1.0, Math.Sqrt(d))));
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0009847C File Offset: 0x0009667C
		public static void IntermediateGCPoint(float f, Angle lat1, Angle lon1, Angle lat2, Angle lon2, Angle d, out Angle lat, out Angle lon)
		{
			double num = Math.Sin(d.Radians);
			double num2 = Math.Cos(lat1.Radians);
			double num3 = Math.Cos(lat2.Radians);
			double num4 = Math.Sin((double)(1f - f) * d.Radians) / num;
			double num5 = Math.Sin((double)f * d.Radians) / num;
			double num6 = num4 * num2 * Math.Cos(lon1.Radians) + num5 * num3 * Math.Cos(lon2.Radians);
			double num7 = num4 * num2 * Math.Sin(lon1.Radians) + num5 * num3 * Math.Sin(lon2.Radians);
			double y = num4 * Math.Sin(lat1.Radians) + num5 * Math.Sin(lat2.Radians);
			lat = Angle.FromRadians(Math.Atan2(y, Math.Sqrt(num6 * num6 + num7 * num7)));
			lon = Angle.FromRadians(Math.Atan2(num7, num6));
		}

		// Token: 0x04000A22 RID: 2594
		public static WorldSettings Settings = new WorldSettings();

		// Token: 0x04000A23 RID: 2595
		private double equatorialRadius;

		// Token: 0x04000A24 RID: 2596
		private TerrainAccessor _terrainAccessor;

		// Token: 0x04000A25 RID: 2597
		private RenderableObjectList _renderableObjects;

		// Token: 0x04000A26 RID: 2598
		private IList onScreenMessages;

		// Token: 0x04000A27 RID: 2599
		private DateTime lastElevationUpdate = DateTime.Now;

		// Token: 0x04000A28 RID: 2600
		private WorldSurfaceRenderer m_WorldSurfaceRenderer;

		// Token: 0x04000A29 RID: 2601
		private bool bool_3;

		// Token: 0x04000A2A RID: 2602
		private ProjectedVectorRenderer m_ProjectedVectorRenderer;

		// Token: 0x04000A2B RID: 2603
		public AtmosphericScatteringSphere m_AtmosphericScatteringSphere;

		// Token: 0x04000A2C RID: 2604
		private int int_0 = 72;

		// Token: 0x04000A2D RID: 2605
		private int int_1 = 72;

		// Token: 0x04000A2E RID: 2606
		private int int_2 = 2147483647;
	}
}
