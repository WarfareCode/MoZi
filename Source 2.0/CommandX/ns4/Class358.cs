using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns6;

namespace ns4
{
	// Token: 0x02000C13 RID: 3091
	public sealed class Class358 : Interface2
	{
		// Token: 0x060066E9 RID: 26345 RVA: 0x0035A220 File Offset: 0x00358420
		public float imethod_0()
		{
			return 0.05f;
		}

		// Token: 0x060066EA RID: 26346 RVA: 0x0035A234 File Offset: 0x00358434
		public float imethod_1()
		{
			return 0.005f;
		}

		// Token: 0x060066EB RID: 26347 RVA: 0x0035A248 File Offset: 0x00358448
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
					if (num3 == 0)
					{
						num3 = 1;
					}
					if (num6 == 0)
					{
						num6 = 1;
					}
					long num7 = (long)num6 * (long)num3;
					Class358.Class359[,] array = new Class358.Class359[(int)(num6 - 1 + 1), (int)(num3 - 1 + 1)];
					int num8 = (int)(num6 - 1);
					short? num9 = null;
					short num10 = 0;
					short? num11 = null;
					short num12 = 0;
					for (int i = 0; i <= num8; i++)
					{
						double num13;
						if (!flag)
						{
							num13 = Math2.NormalizeLongitude((double)(num4 + (float)i * this.imethod_0()));
						}
						else
						{
							num13 = Math2.NormalizeLongitude((double)(num4 - (float)i * this.imethod_0()));
						}
						int num14 = (int)(num3 - 1);
						long num15 = 0L;
						for (int j = 0; j <= num14; j++)
						{
							if (activeUnit_0.m_Scenario.ThreadedOpsMustStop)
							{
								list = null;
								result = list;
								return result;
							}
							double num16 = Math2.NormalizeLatitude((double)(num2 + (float)j * this.imethod_0()));
							Class358.Class359 @class = new Class358.Class359(num16, num13);
							@class.method_2(float_2);
							@class.method_4(list_0);
							if (activeUnit_0.IsNotActive())
							{
								list = null;
								result = list;
								return result;
							}
							if (@class.imethod_0(activeUnit_0))
							{
								if (Math.Abs(double_1 - num13) < (double)this.imethod_0() && (!num9.HasValue || Math.Abs(Class263.RelativeBearingTo(float_0, Math2.GetAzimuth(double_0, double_1, num16, num13))) < 90f))
								{
									num9 = new short?((short)i);
								}
								if (Math.Abs(double_3 - num13) < (double)this.imethod_0())
								{
									num10 = (short)i;
								}
								if (Math.Abs(double_0 - num16) < (double)this.imethod_0() && (!num11.HasValue || Math.Abs(Class263.RelativeBearingTo(float_0, Math2.GetAzimuth(double_0, double_1, num16, num13))) < 90f))
								{
									num11 = new short?((short)j);
								}
								if (Math.Abs(double_2 - num16) < (double)this.imethod_0())
								{
									num12 = (short)j;
								}
							}
							array[i, j] = @class;
							num15 += 1L;
						}
						float_3 = (float)((double)num15 / (double)num7);
					}
					if (!num11.HasValue)
					{
						double num17 = 1.7976931348623157E+308;
						if (!num9.HasValue)
						{
							num9 = new short?(0);
						}
						GeoPoint geoPoint = new GeoPoint(double_1, double_0);
						long num15 = 0L;
						float num18 = num2;
						float num19 = num - this.imethod_0();
						float num20 = this.imethod_0();
						bool flag2 = num20 >= 0f;
						float num21 = num18;
						float num22 = 0f;
						while (flag2 ? (num21 <= num19) : (num21 >= num19))
						{
							double approxAngularDistance = geoPoint.GetApproxAngularDistance((double)num9.Value, (double)num15);
							if (approxAngularDistance < num17)
							{
								num17 = approxAngularDistance;
								num22 = (float)num15;
							}
							num15 += 1L;
							num21 += num20;
						}
						num11 = new short?((short)Math.Round((double)num22));
					}
					if (!num9.HasValue)
					{
						double num23 = 1.7976931348623157E+308;
						if (!num11.HasValue)
						{
							num11 = new short?(0);
						}
						GeoPoint geoPoint2 = new GeoPoint(double_1, double_0);
						long num15 = 0L;
						float num24 = num4;
						float num25 = num5 - this.imethod_0();
						float num26 = this.imethod_0();
						bool flag3 = num26 >= 0f;
						float num27 = num24;
						float num28 = 0f;
						while (flag3 ? (num27 <= num25) : (num27 >= num25))
						{
							num27 = (float)Math2.NormalizeLongitude((double)num27);
							double approxAngularDistance2 = geoPoint2.GetApproxAngularDistance((double)num15, (double)num11.Value);
							if (approxAngularDistance2 < num23)
							{
								num23 = approxAngularDistance2;
								num28 = (float)num15;
							}
							num15 += 1L;
							num27 += num26;
						}
						num9 = new short?((short)Math.Round((double)num28));
					}
					this.method_0(ref activeUnit_0, ref num9, ref num11, ref num10, ref num12, ref array, null, num6, num3);
					if (!array[(int)num9.Value, (int)num11.Value].imethod_0(activeUnit_0))
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						list = null;
					}
					else if (!array[(int)num10, (int)num12].imethod_0(activeUnit_0))
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						list = null;
					}
					else
					{
						LinkedList<Class358.Class359> linkedList = new Class406<Class358.Class359, ActiveUnit>(array).method_5(new Point((int)num9.Value, (int)num11.Value), new Point((int)num10, (int)num12), activeUnit_0);
						array = null;
						if (Information.IsNothing(linkedList))
						{
							list = null;
						}
						else
						{
							List<Waypoint> list2 = new List<Waypoint>();
							LinkedList<Class358.Class359>.Enumerator enumerator = linkedList.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									Class358.Class359 current = enumerator.Current;
									list2.Add(new Waypoint(current.Longitude, current.Latitude, Waypoint.WaypointType.PathfindingPoint, Waypoint._Creator.const_0, Waypoint._Category.const_0));
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
							list = list2;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101112", "");
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

		// Token: 0x060066EC RID: 26348 RVA: 0x0035A920 File Offset: 0x00358B20
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
					float num = (float)Math.Min(Math.Max(double_0, double_2) + (double)float_1, 90.0);
					float num2 = (float)Math.Max(Math.Min(double_0, double_2) - (double)float_1, -90.0);
					float num3 = (float)Math.Max(Math.Min(double_1, double_3) - (double)float_1, -180.0);
					float num4 = (float)Math.Min(Math.Max(double_1, double_3) + (double)float_1, 180.0);
					short num5 = (short)Math.Round((double)(Math.Abs(num - num2) / this.imethod_1()));
					short num6 = (short)Math.Round((double)(Math.Abs(num4 - num3) / this.imethod_1()));
					if (num5 == 0)
					{
						num5 = 1;
					}
					if (num6 == 0)
					{
						num6 = 1;
					}
					long num7 = (long)num6 * (long)num5;
					Class358.Class360[,] array = new Class358.Class360[(int)(num6 - 1 + 1), (int)(num5 - 1 + 1)];
					List<Class358.Class360> list2 = new List<Class358.Class360>();
					int num8 = (int)(num6 - 1);
					short? num9 = null;
					short num10 = 0;
					short? num11 = null;
					short num12 = 0;
					for (int i = 0; i <= num8; i++)
					{
						double num13 = Math2.NormalizeLongitude((double)(num3 + (float)i * this.imethod_1()));
						int num14 = (int)(num5 - 1);
						long num15 = 0L;
						for (int j = 0; j <= num14; j++)
						{
							if (activeUnit_0.m_Scenario.ThreadedOpsMustStop)
							{
								list = null;
								result = list;
								return result;
							}
							double num16 = Math2.NormalizeLatitude((double)(num2 + (float)j * this.imethod_1()));
							Class358.Class360 @class = new Class358.Class360(num16, num13);
							@class.method_2(float_2);
							@class.method_4(list_0);
							if (@class.imethod_0(activeUnit_0))
							{
								if (Math.Abs(double_1 - num13) < (double)this.imethod_1() && (!num9.HasValue || Math.Abs(Class263.RelativeBearingTo(float_0, Math2.GetAzimuth(double_0, double_1, num16, num13))) < 90f))
								{
									num9 = new short?((short)i);
								}
								if (Math.Abs(double_3 - num13) < (double)this.imethod_1())
								{
									num10 = (short)i;
								}
								if (Math.Abs(double_0 - num16) < (double)this.imethod_1() && (!num11.HasValue || Math.Abs(Class263.RelativeBearingTo(float_0, Math2.GetAzimuth(double_0, double_1, num16, num13))) < 90f))
								{
									num11 = new short?((short)j);
								}
								if (Math.Abs(double_2 - num16) < (double)this.imethod_1())
								{
									num12 = (short)j;
								}
							}
							array[i, j] = @class;
							list2.Add(@class);
							num15 += 1L;
						}
						float_3 = (float)((double)num15 / (double)num7);
					}
					if (!num11.HasValue)
					{
						double num17 = 1.7976931348623157E+308;
						if (!num9.HasValue)
						{
							num9 = new short?(0);
						}
						GeoPoint geoPoint = new GeoPoint(double_1, double_0);
						long num15 = 0L;
						float num18 = num2;
						float num19 = num - this.imethod_1();
						float num20 = this.imethod_1();
						bool flag = num20 >= 0f;
						float num21 = num18;
						float num22 = 0f;
						while (flag ? (num21 <= num19) : (num21 >= num19))
						{
							double approxAngularDistance = geoPoint.GetApproxAngularDistance((double)num9.Value, (double)num15);
							if (approxAngularDistance < num17)
							{
								num17 = approxAngularDistance;
								num22 = (float)num15;
							}
							num15 += 1L;
							num21 += num20;
						}
						num11 = new short?((short)Math.Round((double)num22));
					}
					if (!num9.HasValue)
					{
						double num23 = 1.7976931348623157E+308;
						if (!num11.HasValue)
						{
							num11 = new short?(0);
						}
						GeoPoint geoPoint2 = new GeoPoint(double_1, double_0);
						long num15 = 0L;
						float num24 = num3;
						float num25 = num4 - this.imethod_1();
						float num26 = this.imethod_1();
						bool flag2 = num26 >= 0f;
						float num27 = num24;
						float num28 = 0f;
						while (flag2 ? (num27 <= num25) : (num27 >= num25))
						{
							num27 = (float)Math2.NormalizeLongitude((double)num27);
							double approxAngularDistance2 = geoPoint2.GetApproxAngularDistance((double)num15, (double)num11.Value);
							if (approxAngularDistance2 < num23)
							{
								num23 = approxAngularDistance2;
								num28 = (float)num15;
							}
							num15 += 1L;
							num27 += num26;
						}
						num9 = new short?((short)Math.Round((double)num28));
					}
					if (!num11.HasValue)
					{
						double num29 = 1.7976931348623157E+308;
						GeoPoint geoPoint3 = new GeoPoint(double_1, double_0);
						long num15 = 0L;
						float num30 = num2;
						float num31 = num;
						float num32 = this.imethod_0();
						bool flag3 = num32 >= 0f;
						float num33 = num30;
						float num34 = 0f;
						while (flag3 ? (num33 <= num31) : (num33 >= num31))
						{
							double approxAngularDistance3 = geoPoint3.GetApproxAngularDistance((double)num9.Value, (double)num15);
							if (approxAngularDistance3 < num29)
							{
								num29 = approxAngularDistance3;
								num34 = (float)num15;
							}
							num15 += 1L;
							num33 += num32;
						}
						num11 = new short?((short)Math.Round((double)num34));
					}
					Class358.Class359[,] array2 = null;
					this.method_0(ref activeUnit_0, ref num9, ref num11, ref num10, ref num12, ref array2, array, num6, num5);
					if (!array[(int)num9.Value, (int)num11.Value].imethod_0(activeUnit_0))
					{
						list = null;
					}
					else if (!array[(int)num10, (int)num12].imethod_0(activeUnit_0))
					{
						list = null;
					}
					else
					{
						Class406<Class358.Class360, ActiveUnit> class2 = new Class406<Class358.Class360, ActiveUnit>(array);
						LinkedList<Class358.Class360> linkedList = null;
						try
						{
							linkedList = class2.method_5(new Point((int)num9.Value, (int)num11.Value), new Point((int)num10, (int)num12), activeUnit_0);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200096", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
						if (Information.IsNothing(linkedList))
						{
							list = null;
						}
						else
						{
							List<Waypoint> list3 = new List<Waypoint>();
							LinkedList<Class358.Class360>.Enumerator enumerator = linkedList.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									Class358.Class360 current = enumerator.Current;
									list3.Add(new Waypoint(current.double_1, current.double_0, Waypoint.WaypointType.PathfindingPoint, Waypoint._Creator.const_0, Waypoint._Category.const_0));
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
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 101111", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = list;
			return result;
		}

		// Token: 0x060066ED RID: 26349 RVA: 0x0035B06C File Offset: 0x0035926C
		private void method_0(ref ActiveUnit activeUnit_0, ref short? nullable_0, ref short? nullable_1, ref short short_0, ref short short_1, ref Class358.Class359[,] class359_0, Class358.Class360[,] class360_0, short short_2, short short_3)
		{
			bool flag = false;
			bool flag2 = false;
			short num = 1;
			short num2 = 1;
			short num3 = nullable_0.Value;
			short num4 = nullable_1.Value;
			short num5 = short_0;
			short num6 = short_1;
			int num7 = 0;
			int num8 = (int)Math.Min(short_2, short_3);
			try
			{
				do
				{
					if (!flag)
					{
						int num9 = 0;
						if (!Information.IsNothing(class359_0) && class359_0[(int)nullable_0.Value, (int)nullable_1.Value].imethod_0(activeUnit_0))
						{
							if (num4 != short_3 - 1 && class359_0[(int)num3, (int)(num4 + 1)].imethod_0(activeUnit_0))
							{
								num9++;
							}
							if (num4 != 0 && class359_0[(int)num3, (int)(num4 - 1)].imethod_0(activeUnit_0))
							{
								num9++;
							}
							if (num3 != 0 && class359_0[(int)(num3 - 1), (int)num4].imethod_0(activeUnit_0))
							{
								num9++;
							}
							if (num3 != short_2 - 1 && class359_0[(int)(num3 + 1), (int)num4].imethod_0(activeUnit_0))
							{
								num9++;
							}
						}
						else if (!Information.IsNothing(class360_0) && class360_0[(int)nullable_0.Value, (int)nullable_1.Value].imethod_0(activeUnit_0))
						{
							if (num4 != short_3 - 1 && class360_0[(int)num3, (int)(num4 + 1)].imethod_0(activeUnit_0))
							{
								num9++;
							}
							if (num4 != 0 && class360_0[(int)num3, (int)(num4 - 1)].imethod_0(activeUnit_0))
							{
								num9++;
							}
							if (num3 != 0 && class360_0[(int)(num3 - 1), (int)num4].imethod_0(activeUnit_0))
							{
								num9++;
							}
							if (num3 != short_2 - 1 && class360_0[(int)(num3 + 1), (int)num4].imethod_0(activeUnit_0))
							{
								num9++;
							}
						}
						if (num9 > 0)
						{
							flag = true;
						}
						else
						{
							if (!Information.IsNothing(class359_0))
							{
								class359_0[(int)num3, (int)num4].method_5();
							}
							if (!Information.IsNothing(class360_0))
							{
								class360_0[(int)num3, (int)num4].method_5();
							}
							double num10 = 1.7976931348623157E+308;
							short num11 =(short)( num * 2 + 1);
							short num12 = 0;
							short num13;
							if (num == 1)
							{
								num13 = 1;
							}
							else
							{
								num13 = (short)Math.Round((double)(num11 + 1) / 2.0);
							}
							short num14 = (short)(nullable_0.Value - num);
							short num15 = (short)(nullable_1.Value - num);
							short num16 = (short)(num11 - 1);
							for (short num17 = 0; num17 <= num16; num17 += 1)
							{
								short num18 = (short)(num14 + num17);
								if (num18 >= 0 && num18 <= short_2 - 1)
								{
									short num19 = (short)(num11 - 1);
									for (short num20 = 0; num20 <= num19; num20 += 1)
									{
										if (activeUnit_0.m_Scenario.ThreadedOpsMustStop)
										{
											goto IL_784;
										}
										short num21 = (short)(num15 + num20);
										if (num21 >= 0 && num21 <= short_3 - 1 && (num17 == 0 || num17 == num11 - 1 || num20 == 0 || num20 == num11 - 1) && ((!Information.IsNothing(class359_0) && class359_0[(int)num18, (int)num21].imethod_0(activeUnit_0)) || (!Information.IsNothing(class360_0) && class360_0[(int)num18, (int)num21].imethod_0(activeUnit_0))))
										{
											double num22 = (double)Math.Min(Math.Abs((int)(num17 - num13)), Math.Abs((int)(num20 - num13)));
											if (num22 < num10)
											{
												num10 = num22;
												num3 = num18;
												num4 = num21;
											}
											num12 += 1;
										}
									}
								}
							}
							nullable_0 = new short?(num3);
							nullable_1 = new short?(num4);
							if (num12 == 0)
							{
								num += 1;
							}
						}
					}
					if (!flag2)
					{
						int num23 = 0;
						if (!Information.IsNothing(class359_0) && class359_0[(int)short_0, (int)short_1].imethod_0(activeUnit_0))
						{
							if (num6 != short_3 - 1 && class359_0[(int)num5, (int)(num6 + 1)].imethod_0(activeUnit_0))
							{
								num23++;
							}
							if (num6 != 0 && class359_0[(int)num5, (int)(num6 - 1)].imethod_0(activeUnit_0))
							{
								num23++;
							}
							if (num5 != 0 && class359_0[(int)(num5 - 1), (int)num6].imethod_0(activeUnit_0))
							{
								num23++;
							}
							if (num5 != short_2 - 1 && class359_0[(int)(num5 + 1), (int)num6].imethod_0(activeUnit_0))
							{
								num23++;
							}
						}
						else if (!Information.IsNothing(class360_0) && class360_0[(int)short_0, (int)short_1].imethod_0(activeUnit_0))
						{
							if (num6 != short_3 - 1 && class360_0[(int)num5, (int)(num6 + 1)].imethod_0(activeUnit_0))
							{
								num23++;
							}
							if (num6 != 0 && class360_0[(int)num5, (int)(num6 - 1)].imethod_0(activeUnit_0))
							{
								num23++;
							}
							if (num5 != 0 && class360_0[(int)(num5 - 1), (int)num6].imethod_0(activeUnit_0))
							{
								num23++;
							}
							if (num5 != short_2 - 1 && class360_0[(int)(num5 + 1), (int)num6].imethod_0(activeUnit_0))
							{
								num23++;
							}
						}
						if (num23 > 0)
						{
							flag2 = true;
						}
						else
						{
							if (!Information.IsNothing(class359_0))
							{
								class359_0[(int)num5, (int)num6].method_5();
							}
							if (!Information.IsNothing(class360_0))
							{
								class360_0[(int)num5, (int)num6].method_5();
							}
							double num24 = 1.7976931348623157E+308;
							short num25 = (short)(num * 2 + 1);
							short num26 = 0;
							short num27;
							if (num2 == 1)
							{
								num27 = 1;
							}
							else
							{
								num27 = (short)Math.Round((double)(num25 + 1) / 2.0);
							}
							short num28 = (short)(short_0 - num2);
							short num29 = (short)(short_1 - num2);
							short num30 = (short)(num25 - 1);
							for (short num31 = 0; num31 <= num30; num31 += 1)
							{
								short num32 = (short)(num28 + num31);
								if (num32 >= 0 && num32 <= short_2 - 1)
								{
									short num33 = (short)(num25 - 1);
									for (short num34 = 0; num34 <= num33; num34 += 1)
									{
										if (activeUnit_0.m_Scenario.ThreadedOpsMustStop)
										{
											goto IL_784;
										}
										short num35 = (short)(num29 + num34);
										if (num35 >= 0 && num35 <= short_3 - 1 && (num31 == 0 || num31 == num25 - 1 || num34 == 0 || num34 == num25 - 1) && ((!Information.IsNothing(class359_0) && class359_0[(int)num32, (int)num35].imethod_0(activeUnit_0)) || (!Information.IsNothing(class360_0) && class360_0[(int)num32, (int)num35].imethod_0(activeUnit_0))))
										{
											double num36 = (double)Math.Min(Math.Abs((int)(num31 - num27)), Math.Abs((int)(num34 - num27)));
											if (num36 < num24)
											{
												num24 = num36;
												num5 = num32;
												num6 = num35;
											}
											num26 += 1;
										}
									}
								}
							}
							short_0 = num5;
							short_1 = num6;
							if (num26 == 0)
							{
								num2 += 1;
							}
						}
					}
					if (flag && flag2)
					{
						break;
					}
					num7++;
				}
				while (num8 != num7);
				IL_784:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101267", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x02000C14 RID: 3092
		private sealed class Class359 : Interface6<ActiveUnit>
		{
			// Token: 0x060066EF RID: 26351 RVA: 0x0035B85C File Offset: 0x00359A5C
			private short GetTerrainElevation()
			{
				if (Information.IsNothing(this.TerrainElevation))
				{
					this.TerrainElevation = new short?(Class324._GISElevations.GetElevation((float)this.Latitude, (float)this.Longitude));
				}
				return this.TerrainElevation.Value;
			}

			// Token: 0x060066F0 RID: 26352 RVA: 0x0035B8B0 File Offset: 0x00359AB0
			public float method_1()
			{
				return this.float_0;
			}

			// Token: 0x060066F1 RID: 26353 RVA: 0x0002C5DE File Offset: 0x0002A7DE
			public void method_2(float float_1)
			{
				this.float_0 = float_1;
			}

			// Token: 0x060066F2 RID: 26354 RVA: 0x0035B8C8 File Offset: 0x00359AC8
			public List<ActiveUnit> method_3()
			{
				return this.list_0;
			}

			// Token: 0x060066F3 RID: 26355 RVA: 0x0002C5E7 File Offset: 0x0002A7E7
			public void method_4(List<ActiveUnit> list_1)
			{
				this.list_0 = list_1;
			}

			// Token: 0x060066F4 RID: 26356 RVA: 0x0035B8E0 File Offset: 0x00359AE0
			public bool imethod_0(ActiveUnit activeUnit_)
			{
				if (!this.nullable_0.HasValue)
				{
					double latitude = this.Latitude;
					double longitude = this.Longitude;
					byte b = 0;
					bool flag = true;
					bool flag2 = true;
					float? nullable_ = null;
					short? nullable_2 = new short?(this.GetTerrainElevation());
					List<ActiveUnit> list_ = this.method_3();
					bool value = activeUnit_.vmethod_41(latitude, longitude, ref b, true, ref flag, true, ref flag2, nullable_, nullable_2, ref list_, this.method_1(), false, false);
					this.method_4(list_);
					this.nullable_0 = new bool?(value);
				}
				return this.nullable_0.Value;
			}

			// Token: 0x060066F5 RID: 26357 RVA: 0x0002C5F0 File Offset: 0x0002A7F0
			public bool method_5()
			{
				this.nullable_0 = new bool?(false);
				return false;
			}

			// Token: 0x060066F6 RID: 26358 RVA: 0x0002C5FF File Offset: 0x0002A7FF
			public Class359(double double_2, double double_3)
			{
				this.float_0 = 0f;
				this.Latitude = double_2;
				this.Longitude = double_3;
			}

			// Token: 0x04003898 RID: 14488
			public double Latitude;

			// Token: 0x04003899 RID: 14489
			public double Longitude;

			// Token: 0x0400389A RID: 14490
			private bool? nullable_0;

			// Token: 0x0400389B RID: 14491
			private short? TerrainElevation;

			// Token: 0x0400389C RID: 14492
			private List<ActiveUnit> list_0;

			// Token: 0x0400389D RID: 14493
			private float float_0;
		}

		// Token: 0x02000C15 RID: 3093
		private sealed class Class360 : Interface6<ActiveUnit>
		{
			// Token: 0x060066F7 RID: 26359 RVA: 0x0035B96C File Offset: 0x00359B6C
			private short method_0()
			{
				if (Information.IsNothing(this.nullable_1))
				{
					this.nullable_1 = new short?(Terrain.GetElevation(this.double_0, this.double_1, false));
				}
				return this.nullable_1.Value;
			}

			// Token: 0x060066F8 RID: 26360 RVA: 0x0035B9B8 File Offset: 0x00359BB8
			public float method_1()
			{
				return this.float_0;
			}

			// Token: 0x060066F9 RID: 26361 RVA: 0x0002C620 File Offset: 0x0002A820
			public void method_2(float float_1)
			{
				this.float_0 = float_1;
			}

			// Token: 0x060066FA RID: 26362 RVA: 0x0035B9D0 File Offset: 0x00359BD0
			public List<ActiveUnit> method_3()
			{
				return this.list_0;
			}

			// Token: 0x060066FB RID: 26363 RVA: 0x0002C629 File Offset: 0x0002A829
			public void method_4(List<ActiveUnit> list_1)
			{
				this.list_0 = list_1;
			}

			// Token: 0x060066FC RID: 26364 RVA: 0x0035B9E8 File Offset: 0x00359BE8
			public bool imethod_0(ActiveUnit activeUnit_0)
			{
				if (Information.IsNothing(this.nullable_0))
				{
					double lat_ = this.double_0;
					double lon_ = this.double_1;
					byte b = 0;
					bool flag = true;
					bool flag2 = true;
					float? nullable_ = null;
					short? nullable_2 = new short?(this.method_0());
					List<ActiveUnit> list_ = this.method_3();
					bool value = activeUnit_0.vmethod_41(lat_, lon_, ref b, true, ref flag, true, ref flag2, nullable_, nullable_2, ref list_, this.method_1(), false, false);
					this.method_4(list_);
					this.nullable_0 = new bool?(value);
				}
				return this.nullable_0.Value;
			}

			// Token: 0x060066FD RID: 26365 RVA: 0x0002C632 File Offset: 0x0002A832
			public Class360(double double_2, double double_3)
			{
				this.float_0 = 0f;
				this.double_0 = double_2;
				this.double_1 = double_3;
			}

			// Token: 0x060066FE RID: 26366 RVA: 0x0002C653 File Offset: 0x0002A853
			public bool method_5()
			{
				this.nullable_0 = new bool?(false);
				return false;
			}

			// Token: 0x0400389E RID: 14494
			public double double_0;

			// Token: 0x0400389F RID: 14495
			public double double_1;

			// Token: 0x040038A0 RID: 14496
			private bool? nullable_0;

			// Token: 0x040038A1 RID: 14497
			private short? nullable_1;

			// Token: 0x040038A2 RID: 14498
			private float float_0;

			// Token: 0x040038A3 RID: 14499
			private List<ActiveUnit> list_0;
		}
	}
}
