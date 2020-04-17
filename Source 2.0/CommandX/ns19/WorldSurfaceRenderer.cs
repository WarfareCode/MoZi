using System;
using System.Collections;
using System.Threading;
using Microsoft.DirectX.Direct3D;
using ns17;
using ns18;

namespace ns19
{
	// Token: 0x0200040F RID: 1039
	public sealed class WorldSurfaceRenderer
	{
		// Token: 0x06001A29 RID: 6697 RVA: 0x0009EEA4 File Offset: 0x0009D0A4
		public ArrayList method_0()
		{
			return this.arrayList_0;
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x0009EEBC File Offset: 0x0009D0BC
		public double method_1()
		{
			return this.m_DistanceAboveSeaLevel;
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0009EED4 File Offset: 0x0009D0D4
		public uint method_2()
		{
			return this.m_SamplesPerTile;
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0009EEEC File Offset: 0x0009D0EC
		public World method_3()
		{
			return this.m_ParentWorld;
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0009EF04 File Offset: 0x0009D104
		public RenderToSurface method_4()
		{
			return this.m_Rts;
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0009EF1C File Offset: 0x0009D11C
		private void method_5(object sender, EventArgs e)
		{
			Device device = (Device)sender;
			this.device_0 = device;
			this.m_Rts = new RenderToSurface(device, 256, 256, Format.X8R8G8B8, true, DepthFormat.D16);
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0009EF54 File Offset: 0x0009D154
		public void method_6(string string_0)
		{
			try
			{
				object syncRoot = this.arrayList_0.SyncRoot;
				lock (syncRoot)
				{
					for (int i = 0; i < this.arrayList_0.Count; i++)
					{
						Class1959 @class = this.arrayList_0[i] as Class1959;
						if (@class != null && @class.method_5() == string_0)
						{
							this.arrayList_0.RemoveAt(i);
							this.arrayList_0.Sort();
							goto IL_90;
						}
					}
					this.arrayList_0.Sort();
				}
				IL_90:
				this.dateTime_0 = DateTime.Now;
			}
			catch (ThreadAbortException)
			{
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0009F02C File Offset: 0x0009D22C
		public void method_7()
		{
			this.m_Initialized = false;
			if (this.device_0 != null)
			{
				this.device_0.DeviceReset -= new EventHandler(this.method_5);
			}
			if (this.m_Rts != null && !this.m_Rts.Disposed)
			{
				this.m_Rts.Dispose();
			}
			object syncRoot = this.m_RootSurfaceTiles.SyncRoot;
			lock (syncRoot)
			{
				SurfaceTile[] rootSurfaceTiles = this.m_RootSurfaceTiles;
				for (int i = 0; i < rootSurfaceTiles.Length; i++)
				{
					rootSurfaceTiles[i].Dispose();
				}
			}
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x0009F0EC File Offset: 0x0009D2EC
		public void method_8(DrawArgs class1943_0)
		{
			SurfaceTile[] rootSurfaceTiles = this.m_RootSurfaceTiles;
			for (int i = 0; i < rootSurfaceTiles.Length; i++)
			{
				rootSurfaceTiles[i].method_3(class1943_0);
			}
			this.m_Initialized = true;
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x0009F120 File Offset: 0x0009D320
		public void method_9(DrawArgs class1943_0)
		{
			try
			{
				if (!this.m_Initialized)
				{
					this.method_8(class1943_0);
				}
				SurfaceTile[] rootSurfaceTiles = this.m_RootSurfaceTiles;
				for (int i = 0; i < rootSurfaceTiles.Length; i++)
				{
					rootSurfaceTiles[i].method_7(class1943_0);
				}
			}
			catch (ThreadAbortException)
			{
			}
			catch (Exception exception_)
			{
				Log.smethod_3(exception_);
			}
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0009F188 File Offset: 0x0009D388
		public void method_10(DrawArgs class1943_0)
		{
			if (this.m_Rts == null)
			{
				class1943_0.device_0.DeviceReset += new EventHandler(this.method_5);
				this.method_5(class1943_0.device_0, null);
			}
			if (this.m_Initialized)
			{
				if (this.queue_0.Count > 0)
				{
					Class1959 @class = this.queue_0.Dequeue() as Class1959;
					if (@class != null)
					{
						@class.method_8(ImageHelper.smethod_0(@class.method_5()));
						object syncRoot = this.arrayList_0.SyncRoot;
						lock (syncRoot)
						{
							this.arrayList_0.Add(@class);
							this.arrayList_0.Sort();
						}
					}
					class1943_0.int_6++;
				}
				this.int_0 = 0;
				SurfaceTile[] rootSurfaceTiles = this.m_RootSurfaceTiles;
				for (int i = 0; i < rootSurfaceTiles.Length; i++)
				{
					SurfaceTile surfaceTile = rootSurfaceTiles[i];
					if (surfaceTile != null)
					{
						surfaceTile.method_10(class1943_0);
					}
				}
			}
		}

		// Token: 0x04000B01 RID: 2817
		private RenderToSurface m_Rts;

		// Token: 0x04000B02 RID: 2818
		private uint m_SamplesPerTile;

		// Token: 0x04000B03 RID: 2819
		private World m_ParentWorld;

		// Token: 0x04000B04 RID: 2820
		private SurfaceTile[] m_RootSurfaceTiles;

		// Token: 0x04000B05 RID: 2821
		private double m_DistanceAboveSeaLevel;

		// Token: 0x04000B06 RID: 2822
		private bool m_Initialized;

		// Token: 0x04000B07 RID: 2823
		private ArrayList arrayList_0;

		// Token: 0x04000B08 RID: 2824
		private Queue queue_0;

		// Token: 0x04000B09 RID: 2825
		public DateTime dateTime_0;

		// Token: 0x04000B0A RID: 2826
		private Device device_0;

		// Token: 0x04000B0B RID: 2827
		public int int_0;
	}
}
