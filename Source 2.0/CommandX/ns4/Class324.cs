using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Caching;
using System.Runtime.CompilerServices;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns4
{
	// Token: 0x02000CBD RID: 3261
	public sealed class Class324
	{
		// Token: 0x06006BA5 RID: 27557 RVA: 0x0002E060 File Offset: 0x0002C260
		static Class324()
		{
			Class324.SetGISElevationsLoader(new BackgroundWorker());
			Class324.memoryCache = MemoryCache.Default;
			Class324.queue_0 = new Queue<Class356>();
			Class324.string_0 = "";
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x003BD958 File Offset: 0x003BBB58
		[CompilerGenerated]
		private static BackgroundWorker GetGISElevationsLoader()
		{
			return Class324.GISElevationsLoader;
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x003BD96C File Offset: 0x003BBB6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void SetGISElevationsLoader(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler value = new DoWorkEventHandler(Class324.GISElevationsLoader_DoWork);
			BackgroundWorker gISElevationsLoader = Class324.GISElevationsLoader;
			if (gISElevationsLoader != null)
			{
				gISElevationsLoader.DoWork -= value;
			}
			Class324.GISElevationsLoader = backgroundWorker_1;
			gISElevationsLoader = Class324.GISElevationsLoader;
			if (gISElevationsLoader != null)
			{
				gISElevationsLoader.DoWork += value;
			}
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x0002E08A File Offset: 0x0002C28A
		public static void GISElevationsRunWorker()
		{
			if (!Class324.GetGISElevationsLoader().IsBusy)
			{
				Class324.GetGISElevationsLoader().RunWorkerAsync();
			}
			Class324.interface2_0 = new Class358();
		}

		// Token: 0x06006BA9 RID: 27561 RVA: 0x0002E0AC File Offset: 0x0002C2AC
		private static void GISElevationsLoader_DoWork(object sender, DoWorkEventArgs e)
		{
			Class324._GISElevations = new GISElevations();
		}

		// Token: 0x06006BAA RID: 27562 RVA: 0x0002E0B8 File Offset: 0x0002C2B8
		public static void smethod_4(Class356 class356_0, Scenario scenario_0)
		{
			Class324.queue_0.Enqueue(class356_0);
			if (!Class324.bool_0)
			{
				Class324.smethod_10(ref scenario_0);
			}
		}

		// Token: 0x06006BAB RID: 27563 RVA: 0x003BD9B4 File Offset: 0x003BBBB4
		public static int smethod_5()
		{
			return Class324.queue_0.Count;
		}

		// Token: 0x06006BAC RID: 27564 RVA: 0x003BD9D0 File Offset: 0x003BBBD0
		public static string smethod_6()
		{
			string result;
			if (Class324.bool_0)
			{
				result = Class324.string_0;
			}
			else
			{
				result = "None";
			}
			return result;
		}

		// Token: 0x06006BAD RID: 27565 RVA: 0x003BDA00 File Offset: 0x003BBC00
		public static void smethod_7(ActiveUnit activeUnit_, Mission.Flight Flight_)
		{
			try
			{
				List<Class356> list = null;
				bool flag = false;
				while (!flag)
				{
					try
					{
						if (Class324.queue_0.Count == -1)
						{
							return;
						}
						list = Class324.queue_0.ToList<Class356>();
						flag = true;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				for (int i = list.Count - 1; i >= 0; i += -1)
				{
					Class356 @class = list[i];
					if (!Information.IsNothing(@class))
					{
						if (!Information.IsNothing(activeUnit_) && @class.theUnit == activeUnit_)
						{
							@class.theUnit = null;
						}
						if (!Information.IsNothing(Flight_) && @class.theFlight == Flight_)
						{
							@class.theFlight = null;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200342", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006BAE RID: 27566 RVA: 0x003BDB20 File Offset: 0x003BBD20
		public static bool smethod_8(ActiveUnit activeUnit_, Mission.Flight Flight_, ref Exception exception_0)
		{
			bool flag = false;
			bool result;
			try
			{
				if (Class324.queue_0.Count < 1)
				{
					flag = false;
				}
				else
				{
					List<Class356> list = null;
					bool flag2 = false;
					while (!flag2)
					{
						try
						{
							if (Class324.queue_0.Count < 1)
							{
								flag = false;
								result = false;
								return result;
							}
							list = Class324.queue_0.ToList<Class356>();
							flag2 = true;
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
					for (int i = list.Count - 1; i >= 0; i += -1)
					{
						Class356 @class = list[i];
						if (!Information.IsNothing(@class) && (!Information.IsNothing(@class.theUnit) || !Information.IsNothing(@class.theFlight)))
						{
							if (!Information.IsNothing(@class.theUnit) && @class.theUnit == activeUnit_)
							{
								flag = true;
								result = true;
								return result;
							}
							if (!Information.IsNothing(@class.theFlight) && @class.theFlight == Flight_)
							{
								flag = true;
								result = true;
								return result;
							}
						}
					}
					flag = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200335", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = true;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06006BAF RID: 27567 RVA: 0x0002E0D3 File Offset: 0x0002C2D3
		public static bool smethod_9()
		{
			return Class324.queue_0.Count > 0;
		}

		// Token: 0x06006BB0 RID: 27568 RVA: 0x003BDCB0 File Offset: 0x003BBEB0
		public static void smethod_10(ref Scenario scenario_)
		{
			try
			{
				Class324.bool_0 = true;
				while (Class324.queue_0.Count > 0)
				{
					Class356 @class = Class324.queue_0.Dequeue();
					if (!Information.IsNothing(@class) && ((!Information.IsNothing(@class.theUnit) && !@class.theUnit.IsNotActive()) || !Information.IsNothing(@class.theFlight)))
					{
						try
						{
							if (!Information.IsNothing(@class.theUnit))
							{
								@class.theUnit.GetNavigator().method_13(@class.waypoint_0, @class.theUnit, null, false, @class.float_0, @class.double_0, @class.double_1, scenario_, @class.bool_1);
								if (!Information.IsNothing(@class.theUnit))
								{
									Class324.string_0 = @class.theUnit.Name;
								}
								else
								{
									Class324.string_0 = "Unit has been destroyed";
								}
							}
							else if (!Information.IsNothing(@class.theFlight) && !Information.IsNothing(@class.theFlight.GetReferenceUnit(scenario_)))
							{
								@class.theFlight.GetReferenceUnit(scenario_).GetNavigator().method_13(@class.waypoint_0, null, @class.theFlight, @class.bool_0, @class.float_0, @class.double_0, @class.double_1, scenario_, @class.bool_1);
								Class324.string_0 = "Strike mission flight plan";
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200497", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
					}
				}
				Class324.bool_0 = false;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 101110", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				Class324.bool_0 = false;
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x04003D96 RID: 15766
		[CompilerGenerated]
		private static BackgroundWorker GISElevationsLoader;

		// Token: 0x04003D97 RID: 15767
		internal static GISElevations _GISElevations;

		// Token: 0x04003D98 RID: 15768
		private static MemoryCache memoryCache;

		// Token: 0x04003D99 RID: 15769
		private static Queue<Class356> queue_0;

		// Token: 0x04003D9A RID: 15770
		internal static bool bool_0;

		// Token: 0x04003D9B RID: 15771
		internal static Interface2 interface2_0;

		// Token: 0x04003D9C RID: 15772
		private static string string_0;
	}
}
