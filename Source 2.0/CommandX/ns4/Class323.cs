using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns11;
using ns3;

namespace ns4
{
	// Token: 0x02000CBC RID: 3260
	public sealed class Class323 : Interface2
	{
		// Token: 0x06006BA0 RID: 27552 RVA: 0x0035A220 File Offset: 0x00358420
		public float imethod_0()
		{
			return 0.05f;
		}

		// Token: 0x06006BA1 RID: 27553 RVA: 0x0035A234 File Offset: 0x00358434
		public float imethod_1()
		{
			return 0.005f;
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x003BCB38 File Offset: 0x003BAD38
		public List<Waypoint> imethod_3(ActiveUnit activeUnit_0, double double_0, double double_1, double double_2, double double_3, float float_0, float float_1, float float_2, ref List<ActiveUnit> list_0, ref float float_3)
		{
			List<Waypoint> list = null;
			List<Waypoint> result;
			try
			{
				if (activeUnit_0.m_Scenario.ThreadedOpsMustStop)
				{
					list = null;
				}
				else
				{
					bool flag = Math2.smethod_18(double_0, double_1, double_2, double_3);
					float num = Math.Min((float)((short)Math.Round(Math.Max(double_0, double_2))) + float_1, 90f);
					float num2 = Math.Max((float)((short)Math.Round(Math.Min(double_0, double_2))) - float_1, -90f);
					short num3 = (short)Math.Round((double)(Math.Abs(num - num2) / this.imethod_0()));
					float num4;
					float num5;
					short num6;
					if (!flag)
					{
						num4 = (float)((short)Math.Round(Math.Min(double_1, double_3))) - float_1;
						num5 = (float)((short)Math.Round(Math.Max(double_1, double_3))) + float_1;
						num6 = Math.Abs((short)Math.Round((double)(Math.Abs(num5 - num4) / this.imethod_0())));
					}
					else
					{
						num4 = (float)((short)Math.Round(Math.Min(double_1, double_3))) + float_1;
						num5 = (float)((short)Math.Round(Math.Max(double_1, double_3))) - float_1;
						num6 = Math.Abs((short)Math.Round((double)((180f - Math.Abs(num4) + (180f - num5)) / this.imethod_0())));
					}
					long num7 = (long)num6 * (long)num3;
					int num8 = 1;
					while (Math.Pow(2.0, (double)num8) <= (double)num3 || Math.Pow(2.0, (double)num8) <= (double)num6)
					{
						num8++;
					}
					int num9 = (int)Math.Round(Math.Pow(2.0, (double)num8));
					int num10 = (int)Math.Round(Math.Pow(2.0, (double)num8));
					byte[,] array = new byte[num10 - 1 + 1, num9 - 1 + 1];
					int num11 = num10 - 1;
					short? num12 = null;
					short x = 0;
					short? num13 = null;
					short y = 0;
					for (int i = 0; i <= num11; i++)
					{
						double num14;
						if (!flag)
						{
							num14 = Math2.NormalizeLongitude((double)(num4 + (float)i * this.imethod_0()));
						}
						else
						{
							num14 = Math2.NormalizeLongitude((double)(num4 - (float)i * this.imethod_0()));
						}
						int num15 = num9 - 1;
						long num16 = 0L;
						for (int j = 0; j <= num15; j++)
						{
							if (i <= (int)num6 && j <= (int)num3)
							{
								if (activeUnit_0.m_Scenario.ThreadedOpsMustStop)
								{
									list = null;
									result = list;
									return result;
								}
								if (activeUnit_0.IsNotActive())
								{
									list = null;
									result = list;
									return result;
								}
								double num17 = Math2.NormalizeLatitude((double)(num2 + (float)j * this.imethod_0()));
								double lat_ = num17;
								double lon_ = num14;
								bool flag2 = true;
								bool flag3 = true;
								byte b = 0;
								if (activeUnit_0.vmethod_41(lat_, lon_, ref b, true, ref flag2, true, ref flag3, null, null, ref list_0, 0f, false, false))
								{
									array[i, j] = b;
									if (Math.Abs(double_1 - num14) < (double)this.imethod_0() && (!num12.HasValue || Math.Abs(Class263.GetAngleBetween(float_0, Math2.GetAzimuth(double_0, double_1, num17, num14))) < 90f))
									{
										num12 = new short?((short)i);
									}
									if (Math.Abs(double_3 - num14) < (double)this.imethod_0())
									{
										x = (short)i;
									}
									if (Math.Abs(double_0 - num17) < (double)this.imethod_0() && (!num13.HasValue || Math.Abs(Class263.GetAngleBetween(float_0, Math2.GetAzimuth(double_0, double_1, num17, num14))) < 90f))
									{
										num13 = new short?((short)j);
									}
									if (Math.Abs(double_2 - num17) < (double)this.imethod_0())
									{
										y = (short)j;
									}
								}
								else
								{
									array[i, j] = 0;
								}
								num16 += 1L;
							}
							else
							{
								array[i, j] = 0;
							}
						}
						float_3 = (float)((double)num16 / (double)num7);
					}
					if (!num13.HasValue)
					{
						double num18 = 1.7976931348623157E+308;
						float num19 = num2;
						float num20 = num;
						float num21 = this.imethod_0();
						bool flag3 = num21 >= 0f;
						float num22 = num19;
						float num23 = 0f;
						while (flag3 ? (num22 <= num20) : (num22 >= num20))
						{
							double approxAngularDistance = new GeoPoint(double_1, double_0).GetApproxAngularDistance((double)num12.Value, (double)num22);
							if (approxAngularDistance < num18)
							{
								num18 = approxAngularDistance;
								num23 = num22;
							}
							num22 += num21;
						}
						num13 = new short?((short)Math.Round((double)num23));
					}
					if (!num12.HasValue)
					{
						double num24 = 1.7976931348623157E+308;
						GeoPoint geoPoint = new GeoPoint(double_1, double_0);
						float num25 = num4;
						float num26 = num5;
						float num27 = this.imethod_0();
						bool flag2 = num27 >= 0f;
						float num28 = num25;
						float num29 = 0f;
						while (flag2 ? (num28 <= num26) : (num28 >= num26))
						{
							num28 = (float)Math2.NormalizeLongitude((double)num28);
							double approxAngularDistance2 = geoPoint.GetApproxAngularDistance((double)num13.Value, (double)num28);
							if (approxAngularDistance2 < num24)
							{
								num24 = approxAngularDistance2;
								num29 = num28;
							}
							num28 += num27;
						}
						num12 = new short?((short)Math.Round((double)num29));
					}
					Class562 @class = new Class562(array);
					@class.vmethod_0(Enum137.const_3);
					@class.vmethod_1(true);
					@class.vmethod_2(false);
					@class.vmethod_3(false);
					@class.vmethod_5(true);
					@class.vmethod_6(2147483647);
					@class.vmethod_7(false);
					@class.vmethod_4(true);
					List<Struct54> list2 = @class.vmethod_8(new Point((int)num12.Value, (int)num13.Value), new Point((int)x, (int)y));
					if (Information.IsNothing(list2))
					{
						list = null;
					}
					else
					{
						List<Waypoint> list3 = new List<Waypoint>();
						list2.Reverse();
						List<Struct54>.Enumerator enumerator = list2.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Struct54 current = enumerator.Current;
								double num14;
								if (!flag)
								{
									num14 = Math2.NormalizeLongitude((double)(num4 + (float)current.int_3 * this.imethod_0()));
								}
								else
								{
									num14 = Math2.NormalizeLongitude((double)(num4 - (float)current.int_3 * this.imethod_0()));
								}
								double num17 = Math2.NormalizeLatitude((double)(num2 + (float)current.int_4 * this.imethod_0()));
								list3.Add(new Waypoint(num14, num17, Waypoint.WaypointType.PathfindingPoint, Waypoint._Creator.const_0, Waypoint._Category.const_0));
							}
						}
						finally
						{
							IDisposable disposable = enumerator;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
						list = list3;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101333", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = list;
			return result;
		}

		// Token: 0x06006BA3 RID: 27555 RVA: 0x003BD248 File Offset: 0x003BB448
		public List<Waypoint> imethod_2(ActiveUnit activeUnit_0, double double_0, double double_1, double double_2, double double_3, float float_0, float float_1, float float_2, ref List<ActiveUnit> list_0, ref float float_3)
		{
			List<Waypoint> list = null;
			List<Waypoint> result;
			try
			{
				if (activeUnit_0.m_Scenario.ThreadedOpsMustStop)
				{
					list = null;
				}
				else
				{
					bool flag = Math2.smethod_18(double_0, double_1, double_2, double_3);
					float num = Math.Min((float)((short)Math.Round(Math.Max(double_0, double_2))) + float_1, 90f);
					float num2 = Math.Max((float)((short)Math.Round(Math.Min(double_0, double_2))) - float_1, -90f);
					short num3 = (short)Math.Round((double)(Math.Abs(num - num2) / this.imethod_1()));
					float num4;
					float num5;
					short num6;
					if (!flag)
					{
						num4 = (float)((short)Math.Round(Math.Min(double_1, double_3))) - float_1;
						num5 = (float)((short)Math.Round(Math.Max(double_1, double_3))) + float_1;
						num6 = Math.Abs((short)Math.Round((double)(Math.Abs(num5 - num4) / this.imethod_1())));
					}
					else
					{
						num4 = (float)((short)Math.Round(Math.Min(double_1, double_3))) + float_1;
						num5 = (float)((short)Math.Round(Math.Max(double_1, double_3))) - float_1;
						num6 = Math.Abs((short)Math.Round((double)((180f - Math.Abs(num4) + (180f - num5)) / this.imethod_1())));
					}
					long num7 = (long)num6 * (long)num3;
					int num8 = 1;
					while (Math.Pow(2.0, (double)num8) <= (double)num3 || Math.Pow(2.0, (double)num8) <= (double)num6)
					{
						num8++;
					}
					int num9 = (int)Math.Round(Math.Pow(2.0, (double)num8));
					int num10 = (int)Math.Round(Math.Pow(2.0, (double)num8));
					byte[,] array = new byte[num10 - 1 + 1, num9 - 1 + 1];
					int num11 = num10 - 1;
					short? num12 = null;
					short x = 0;
					short? num13 = null;
					short y = 0;
					for (int i = 0; i <= num11; i++)
					{
						double num14;
						if (!flag)
						{
							num14 = Math2.NormalizeLongitude((double)(num4 + (float)i * this.imethod_1()));
						}
						else
						{
							num14 = Math2.NormalizeLongitude((double)(num4 - (float)i * this.imethod_1()));
						}
						int num15 = num9 - 1;
						long num16 = 0L;
						for (int j = 0; j <= num15; j++)
						{
							if (i <= (int)num6 && j <= (int)num3)
							{
								if (activeUnit_0.m_Scenario.ThreadedOpsMustStop)
								{
									list = null;
									result = list;
									return result;
								}
								if (activeUnit_0.IsNotActive())
								{
									list = null;
									result = list;
									return result;
								}
								double num17 = Math2.NormalizeLatitude((double)(num2 + (float)j * this.imethod_1()));
								double lat_ = num17;
								double lon_ = num14;
								bool flag2 = true;
								bool flag3 = true;
								byte b = 0;
								if (activeUnit_0.vmethod_41(lat_, lon_, ref b, true, ref flag2, true, ref flag3, null, null, ref list_0, 0f, false, false))
								{
									array[i, j] = b;
									if (Math.Abs(double_1 - num14) < (double)this.imethod_1() && (!num12.HasValue || Math.Abs(Class263.GetAngleBetween(float_0, Math2.GetAzimuth(double_0, double_1, num17, num14))) < 90f))
									{
										num12 = new short?((short)i);
									}
									if (Math.Abs(double_3 - num14) < (double)this.imethod_1())
									{
										x = (short)i;
									}
									if (Math.Abs(double_0 - num17) < (double)this.imethod_1() && (!num13.HasValue || Math.Abs(Class263.GetAngleBetween(float_0, Math2.GetAzimuth(double_0, double_1, num17, num14))) < 90f))
									{
										num13 = new short?((short)j);
									}
									if (Math.Abs(double_2 - num17) < (double)this.imethod_1())
									{
										y = (short)j;
									}
								}
								else
								{
									array[i, j] = 0;
								}
								num16 += 1L;
							}
							else
							{
								array[i, j] = 0;
							}
						}
						float_3 = (float)((double)num16 / (double)num7);
					}
					if (!num13.HasValue)
					{
						double num18 = 1.7976931348623157E+308;
						float num19 = num2;
						float num20 = num;
						float num21 = this.imethod_1();
						bool flag3 = num21 >= 0f;
						float num22 = num19;
						float num23 = 0f;
						while (flag3 ? (num22 <= num20) : (num22 >= num20))
						{
							double approxAngularDistance = new GeoPoint(double_1, double_0).GetApproxAngularDistance((double)num12.Value, (double)num22);
							if (approxAngularDistance < num18)
							{
								num18 = approxAngularDistance;
								num23 = num22;
							}
							num22 += num21;
						}
						num13 = new short?((short)Math.Round((double)num23));
					}
					if (!num12.HasValue)
					{
						double num24 = 1.7976931348623157E+308;
						GeoPoint geoPoint = new GeoPoint(double_1, double_0);
						float num25 = num4;
						float num26 = num5;
						float num27 = this.imethod_1();
						bool flag2 = num27 >= 0f;
						float num28 = num25;
						float num29 = 0f;
						while (flag2 ? (num28 <= num26) : (num28 >= num26))
						{
							num28 = (float)Math2.NormalizeLongitude((double)num28);
							double approxAngularDistance2 = geoPoint.GetApproxAngularDistance((double)num13.Value, (double)num28);
							if (approxAngularDistance2 < num24)
							{
								num24 = approxAngularDistance2;
								num29 = num28;
							}
							num28 += num27;
						}
						num12 = new short?((short)Math.Round((double)num29));
					}
					Class562 @class = new Class562(array);
					@class.vmethod_0(Enum137.const_0);
					@class.vmethod_1(true);
					@class.vmethod_2(false);
					@class.vmethod_3(false);
					@class.vmethod_5(true);
					@class.vmethod_6(2147483647);
					@class.vmethod_7(false);
					@class.vmethod_4(true);
					List<Struct54> list2 = @class.vmethod_8(new Point((int)num12.Value, (int)num13.Value), new Point((int)x, (int)y));
					if (Information.IsNothing(list2))
					{
						list = null;
					}
					else
					{
						List<Waypoint> list3 = new List<Waypoint>();
						list2.Reverse();
						List<Struct54>.Enumerator enumerator = list2.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Struct54 current = enumerator.Current;
								double num14;
								if (!flag)
								{
									num14 = Math2.NormalizeLongitude((double)(num4 + (float)current.int_3 * this.imethod_1()));
								}
								else
								{
									num14 = Math2.NormalizeLongitude((double)(num4 - (float)current.int_3 * this.imethod_1()));
								}
								double num17 = Math2.NormalizeLatitude((double)(num2 + (float)current.int_4 * this.imethod_1()));
								list3.Add(new Waypoint(num14, num17, Waypoint.WaypointType.PathfindingPoint, Waypoint._Creator.const_0, Waypoint._Category.const_0));
							}
						}
						finally
						{
							IDisposable disposable = enumerator;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
						list = list3;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101334", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = list;
			return result;
		}
	}
}
