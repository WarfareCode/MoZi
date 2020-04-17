using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ClipperLib;
using DotSpatial.Topology;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns18;
using ns19;
using ns26;
using ns28;
using ns3;

namespace Command_Core
{
	// Token: 0x02000BCC RID: 3020
	public sealed class Math2
	{
		// Token: 0x06006426 RID: 25638 RVA: 0x00317E6C File Offset: 0x0031606C
		public static double Tan_D(double degrees)
		{
			return Math.Tan(0.0174532925199433 * degrees);
		}

		// Token: 0x06006427 RID: 25639 RVA: 0x00317E8C File Offset: 0x0031608C
		public static double Sin_D(double degrees)
		{
			return Math.Sin(0.0174532925199433 * degrees);
		}

		// Token: 0x06006428 RID: 25640 RVA: 0x00317EAC File Offset: 0x003160AC
		public static double Cos_D(double degrees)
		{
			return Math.Cos(0.0174532925199433 * degrees);
		}

		// Token: 0x06006429 RID: 25641 RVA: 0x00317ECC File Offset: 0x003160CC
		public static double smethod_3(double a)
		{
			double result;
			if (a == 1.0)
			{
				result = 0.0;
			}
			else if (a == -1.0)
			{
				result = 180.0;
			}
			else
			{
				result = 57.2957795130823 * Math.Atan2(-a, Math.Sqrt(1.0 - a * a)) + 90.0;
			}
			return result;
		}

		// Token: 0x0600642A RID: 25642 RVA: 0x00317F50 File Offset: 0x00316150
		public static double Normalize(double Angle)
		{
			double result = Angle;
			if (Angle < 0.0)
			{
				result = Angle + 360.0;
			}
			if (Angle > 360.0)
			{
				result = Angle - 360.0;
			}
			if (Angle == 360.0)
			{
				result = 0.0;
			}
			return result;
		}

		// Token: 0x0600642B RID: 25643 RVA: 0x00317FB8 File Offset: 0x003161B8
		public static float Normalize(float angle)
		{
			float result = angle;
			if (angle < 0f)
			{
				result = angle + 360f;
			}
			if (angle > 360f)
			{
				result = angle - 360f;
			}
			if (angle == 360f)
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x0600642C RID: 25644 RVA: 0x00318008 File Offset: 0x00316208
		public static int Normalize(int angle)
		{
			int result = angle;
			if (angle < 0)
			{
				result = angle + 360;
			}
			if (angle > 360)
			{
				result = angle - 360;
			}
			if (angle == 360)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600642D RID: 25645 RVA: 0x00318050 File Offset: 0x00316250
		public static double NormalizeLatitude(double double_0)
		{
			double result;
			if (double_0 > 90.0)
			{
				result = 180.0 - double_0;
			}
			else if (double_0 < -90.0)
			{
				result = -180.0 - double_0;
			}
			else
			{
				result = double_0;
			}
			return result;
		}

		// Token: 0x0600642E RID: 25646 RVA: 0x003180AC File Offset: 0x003162AC
		public static double NormalizeLongitude(double Degree)
		{
			double result;
			if (Degree == -180.0)
			{
				result = 0.0;
			}
			else if (Degree > 180.0)
			{
				result = Degree - 360.0;
			}
			else if (Degree < -180.0)
			{
				result = Degree + 360.0;
			}
			else
			{
				result = Degree;
			}
			return result;
		}

		// Token: 0x0600642F RID: 25647 RVA: 0x00318124 File Offset: 0x00316324
		public static double ApproxAngularDistance(double distance_nm)
		{
			return Angle.FromRadians(distance_nm / 3441.6865234375).GetDegrees();
		}

		// Token: 0x06006430 RID: 25648 RVA: 0x0031814C File Offset: 0x0031634C
		public static double ApproxAngularDistance(double latA_, double lonA_, double latB_, double lonB_)
		{
			Angle latA = default(Angle);
			Angle lonA = default(Angle);
			Angle latB = default(Angle);
			Angle lonB = default(Angle);
			latA.SetDegrees(latA_);
			lonA.SetDegrees(lonA_);
			latB.SetDegrees(latB_);
			lonB.SetDegrees(lonB_);
			return World.ApproxAngularDistance(latA, lonA, latB, lonB).GetDegrees();
		}

		// Token: 0x06006431 RID: 25649 RVA: 0x003181B0 File Offset: 0x003163B0
		public static float GetDistance(double lat1, double lon1, double lat2, double lon2)
		{
			float num = (float)Math.Abs(Math2.smethod_3(Math2.Sin_D(lat1) * Math2.Sin_D(lat2) + Math2.Cos_D(lat1) * Math2.Cos_D(lat2) * Math2.Cos_D(lon2 - lon1)) * 60.0);
			if (float.IsNaN(num))
			{
				num = 0f;
			}
			return num;
		}

		// Token: 0x06006432 RID: 25650 RVA: 0x0031820C File Offset: 0x0031640C
		public static float GetAzimuth(double lat1, double lon1, double lat2, double lon2)
		{
			return (float)Math2.Normalize(57.2957795130823 * Math.Atan2(Math2.Sin_D(lon2 - lon1), Math2.Tan_D(lat2) * Math2.Cos_D(lat1) - Math2.Sin_D(lat1) * Math2.Cos_D(lon2 - lon1)));
		}

		// Token: 0x06006433 RID: 25651 RVA: 0x0002BF0A File Offset: 0x0002A10A
		public static void GetAnotherGeopoint(double longitude, double latitude, ref double longitude1, ref double latitude1, float distance_nm, float azimuth)
		{
			Class258.smethod_7(latitude, longitude, ref latitude1, ref longitude1, (double)azimuth, (double)distance_nm);
		}

		// Token: 0x06006434 RID: 25652 RVA: 0x00318258 File Offset: 0x00316458
		public static GeoPoint smethod_14(IEnumerable<GeoPoint> GeoPoints, double lat_, double lon_, bool bool_0)
		{
			Math2.DistanceMeasurer distanceMeasurer = new Math2.DistanceMeasurer();
			distanceMeasurer.latitude = lat_;
			distanceMeasurer.longitude = lon_;
			int num = GeoPoints.Count<GeoPoint>();
			GeoPoint result;
			if (!bool_0)
			{
				result = GeoPoints.ElementAtOrDefault(GameGeneral.GetRandom().Next(0, num));
			}
			else
			{
				IEnumerable<GeoPoint> source = GeoPoints.Select(Math2.GeoPointFunc0).OrderBy(new Func<GeoPoint, float>(distanceMeasurer.GetDistance));
				if (GameGeneral.GetRandom().Next(0, 1001) > 250)
				{
					int num2 = (int)Math.Round(Math.Ceiling((double)GeoPoints.Count<GeoPoint>() / 2.0));
					result = source.Skip(num - num2).ElementAtOrDefault(GameGeneral.GetRandom().Next(0, num2));
				}
				else
				{
					int num3 = (int)Math.Round(Math.Ceiling((double)GeoPoints.Count<GeoPoint>() / 2.0));
					result = source.Take(num3).ElementAtOrDefault(GameGeneral.GetRandom().Next(0, num3));
				}
			}
			return result;
		}

		// Token: 0x06006435 RID: 25653 RVA: 0x00318354 File Offset: 0x00316554
		public static List<GeoPoint> smethod_15(List<GeoPoint> list_0)
		{
			GeoPoint geoPoint = Misc.smethod_50(list_0);
			Class258.Class259 @class = new Class258.Class259(geoPoint.GetLatitude(), geoPoint.GetLongitude());
			int count = list_0.Count;
			Coordinate[] array = new Coordinate[count + 1];
			int num = count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				try
				{
					double double_ = 0.0;
					double double_2 = 0.0;
					if (@class.method_1(list_0[num2].GetLatitude(), list_0[num2].GetLongitude(), ref double_, ref double_2, false))
					{
						array[num2] = new Coordinate(double_, double_2);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200088", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			List<GeoPoint> list;
			List<GeoPoint> result;
			if (array.Count<Coordinate>() == 0)
			{
				list = new List<GeoPoint>();
			}
			else
			{
				array[count] = array[0];
				Polygon polygon = new Polygon(new LinearRing(array));
				try
				{
					if (count > 0 & polygon.GetArea() == 0.0)
					{
						list = new List<GeoPoint>
						{
							list_0[0]
						};
						result = list;
						return result;
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 200089", ex4.Message);
					GameGeneral.LogException(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
					result = list_0;
					return result;
				}
				Geometry geometry = (Geometry)Math2.smethod_16(polygon, 100);
				List<GeoPoint> list2 = new List<GeoPoint>();
				foreach (Coordinate current in geometry.GetCoordinates())
				{
					try
					{
						double double_3 = 0.0;
						double double_4 = 0.0;
						if (@class.method_6(current.X, current.Y, ref double_3, ref double_4))
						{
							list2.Add(new GeoPoint(double_4, double_3));
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						ex6.Data.Add("Error at 200289", "");
						GameGeneral.LogException(ref ex6);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
				list = list2;
			}
			result = list;
			return result;
		}

		// Token: 0x06006436 RID: 25654 RVA: 0x00318610 File Offset: 0x00316810
		public static IGeometry smethod_16(IGeometry igeometry_0, int int_0)
		{
			Math2.Class262 @class = new Math2.Class262();
			@class.igeometry_0 = igeometry_0;
			@class.int_0 = int_0;
			@class.igeometry_1 = null;
			Parallel.For(1, 500, new Action<int, ParallelLoopState>(@class.method_0));
			IGeometry result;
			if (Information.IsNothing(@class.igeometry_1))
			{
				result = @class.igeometry_0;
			}
			else
			{
				result = @class.igeometry_1;
			}
			return result;
		}

		// Token: 0x06006437 RID: 25655 RVA: 0x00318678 File Offset: 0x00316878
		public static GeoPoint PickSuitablePointInsideArea(IEnumerable<GeoPoint> GeoPoints)
		{
			GeoPoint geoPoint;
			GeoPoint result;
			if (GeoPoints.Count<GeoPoint>() < 3)
			{
				geoPoint = null;
			}
			else
			{
				Random random = GameGeneral.GetRandom();
				List<GeoPoint> source = GeoPoints.OrderBy(Math2.GeoPointLatFunc).ToList<GeoPoint>();
				double latitude = source.Last<GeoPoint>().GetLatitude();
				double latitude2 = source.First<GeoPoint>().GetLatitude();
				double double_ = 0.0;
				double double_2 = 0.0;
				if (!Math2.smethod_19(GeoPoints.ToList<GeoPoint>()))
				{
					List<GeoPoint> source2 = GeoPoints.OrderBy(Math2.GeoPointLonFunc).ToList<GeoPoint>();
					double longitude = source2.Last<GeoPoint>().GetLongitude();
					double longitude2 = source2.First<GeoPoint>().GetLongitude();
					short num = 0;
					bool flag = false;
					while (!flag)
					{
						if (num == 32767)
						{
							geoPoint = null;
							result = geoPoint;
							return result;
						}
						num += 1;
						double num2 = random.NextDouble();
						double num3 = random.NextDouble();
						if (num2 == 0.0 || num3 == 0.0)
						{
							geoPoint = null;
							result = geoPoint;
							return result;
						}
						double_ = longitude2 + num2 * (longitude - longitude2);
						double_2 = latitude2 + num3 * (latitude - latitude2);
						GeoPoint geoPoint2 = new GeoPoint(double_, double_2);
						List<GeoPoint> list = GeoPoints.ToList<GeoPoint>();
						flag = geoPoint2.method_21(ref list, true);
					}
				}
				else
				{
					List<GeoPoint> source3 = GeoPoints.OrderBy(Math2.GeoPointFunc3).ToList<GeoPoint>();
					GeoPoint geoPoint3 = source3.First<GeoPoint>();
					GeoPoint geoPoint4 = source3.Last<GeoPoint>();
					double num4 = 180.0 - Math.Abs(geoPoint4.GetLongitude()) + (180.0 - Math.Abs(geoPoint3.GetLongitude()));
					short num5 = 0;
					bool flag = false;
					while (!flag)
					{
						if (num5 == 32767)
						{
							geoPoint = null;
							result = geoPoint;
							return result;
						}
						num5 += 1;
						double num2 = GameGeneral.GetRandom().NextDouble();
						double num3 = GameGeneral.GetRandom().NextDouble();
						if (num2 == 0.0 || num3 == 0.0)
						{
							geoPoint = null;
							result = geoPoint;
							return result;
						}
						double_ = Math2.NormalizeLongitude(geoPoint4.GetLongitude() + num2 * num4);
						double_2 = latitude2 + num3 * (latitude - latitude2);
						GeoPoint geoPoint5 = new GeoPoint(double_, double_2);
						List<GeoPoint> list = GeoPoints.ToList<GeoPoint>();
						flag = geoPoint5.method_21(ref list, true);
					}
				}
				geoPoint = new GeoPoint(double_, double_2);
			}
			result = geoPoint;
			return result;
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x003188D8 File Offset: 0x00316AD8
		public static bool smethod_18(double double_0, double double_1, double double_2, double double_3)
		{
			bool result;
			if (double_1 >= 0.0 && double_3 >= 0.0)
			{
				result = false;
			}
			else if (double_1 < 0.0 && double_3 < 0.0)
			{
				result = false;
			}
			else
			{
				double value = Math.Min(double_1, double_3);
				result = (Math.Abs(Math.Max(double_1, double_3)) + Math.Abs(value) > 180.0);
			}
			return result;
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x00318954 File Offset: 0x00316B54
		public static bool smethod_19(IEnumerable<GeoPoint> ienumerable_0)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			double num = 0.0;
			double num2 = 0.0;
			using (IEnumerator<GeoPoint> enumerator = ienumerable_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					double longitude = enumerator.Current.GetLongitude();
					if (longitude < num)
					{
						num = longitude;
					}
					if (longitude > num2)
					{
						num2 = longitude;
					}
					if (longitude > 0.0)
					{
						flag2 = true;
						if (flag3)
						{
							flag = true;
						}
					}
					if (longitude < 0.0)
					{
						flag3 = true;
						if (flag2)
						{
							flag = true;
						}
					}
				}
			}
			return flag && Math.Abs(num2) + Math.Abs(num) > 180.0;
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x00318A34 File Offset: 0x00316C34
		public static bool smethod_20(ref List<ReferencePoint> list_0)
		{
			bool result = false;
			try
			{
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				int num = list_0.Count - 1;
				double num2 = 0.0;
				double num3 = 0.0;
				while (num >= 0)
				{
					ReferencePoint referencePoint;
					try
					{
						if (Information.IsNothing(list_0[num]))
						{
							list_0.Remove(list_0[num]);
							goto IL_10B;
						}
						referencePoint = list_0[num];
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200485", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
						goto IL_10B;
					}
					goto IL_AF;
					IL_10B:
					num += -1;
					continue;
					IL_AF:
					double longitude = referencePoint.GetLongitude();
					if (longitude < num2)
					{
						num2 = longitude;
					}
					if (longitude > num3)
					{
						num3 = longitude;
					}
					if (longitude > 0.0)
					{
						flag2 = true;
						if (flag3)
						{
							flag = true;
						}
					}
					if (longitude >= 0.0)
					{
						goto IL_10B;
					}
					flag3 = true;
					if (flag2)
					{
						flag = true;
						goto IL_10B;
					}
					goto IL_10B;
				}
				result = (flag && Math.Abs(num3) + Math.Abs(num2) > 180.0);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 200486", ex4.Message);
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600643B RID: 25659 RVA: 0x00318BF4 File Offset: 0x00316DF4
		public static List<GeoPoint> smethod_21(List<GeoPoint> list_0, List<GeoPoint> list_1)
		{
			List<GeoPoint> result = null;
			try
			{
				List<GeoPoint> list = new List<GeoPoint>();
				List<GeoPoint> list2 = new List<GeoPoint>();
				foreach (GeoPoint geoPoint in list_0)
				{
					//GeoPoint geoPoint;
					GeoPoint item = new GeoPoint(geoPoint.GetLongitude() * 100000000000000.0, geoPoint.GetLatitude() * 100000000000000.0);
					list.Add(item);
				}
				foreach (GeoPoint geoPoint in list_1)
				{
					//GeoPoint geoPoint;
					GeoPoint item = new GeoPoint(geoPoint.GetLongitude() * 100000000000000.0, geoPoint.GetLatitude() * 100000000000000.0);
					list2.Add(item);
				}
				List<IntPoint> list3 = new List<IntPoint>();
				foreach (GeoPoint geoPoint in list)
				{
					//GeoPoint geoPoint;
					if (!double.IsNaN(geoPoint.GetLatitude()) && !double.IsNaN(geoPoint.GetLongitude()) && geoPoint.GetLongitude() <= 9.2233720368547758E+18 && geoPoint.GetLatitude() <= 9.2233720368547758E+18)
					{
						list3.Add(new IntPoint((long)Math.Round(geoPoint.GetLongitude()), (long)Math.Round(geoPoint.GetLatitude())));
					}
				}
				List<IntPoint> list4 = new List<IntPoint>();
				foreach (GeoPoint geoPoint in list2)
				{
					//GeoPoint geoPoint;
					if (!double.IsNaN(geoPoint.GetLatitude()) && !double.IsNaN(geoPoint.GetLongitude()) && geoPoint.GetLongitude() <= 9.2233720368547758E+18 && geoPoint.GetLatitude() <= 9.2233720368547758E+18)
					{
						list4.Add(new IntPoint((long)Math.Round(geoPoint.GetLongitude()), (long)Math.Round(geoPoint.GetLatitude())));
					}
				}
				Class2363 @class = new Class2363(0);
				@class.method_7(list3, Enum163.const_0, true);
				@class.method_7(list4, Enum163.const_1, true);
				List<List<IntPoint>> list5 = new List<List<IntPoint>>();
				if (@class.method_20(Enum162.const_0, list5, Enum164.const_1, Enum164.const_1))
				{
					List<GeoPoint> list6 = new List<GeoPoint>();
					if (list5.Count > 0)
					{
						foreach (IntPoint current in list5[0])
						{
							GeoPoint geoPoint = new GeoPoint();
							geoPoint.SetLatitude((double)current.long_1 / 100000000000000.0);
							geoPoint.SetLongitude((double)current.long_0 / 100000000000000.0);
							list6.Add(geoPoint);
						}
						result = list6;
					}
					else
					{
						result = new List<GeoPoint>();
					}
				}
				else
				{
					result = new List<GeoPoint>();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200016", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = list_1;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600643C RID: 25660 RVA: 0x00318FBC File Offset: 0x003171BC
		public static List<List<GeoPoint>> smethod_22(List<List<GeoPoint>> list_0)
		{
			List<List<GeoPoint>> result = null;
			try
			{
				Class2363 @class = new Class2363(0);
				foreach (List<GeoPoint> current in list_0)
				{
					List<IntPoint> list = new List<IntPoint>();
					foreach (GeoPoint geoPoint in current)
					{
						GeoPoint geoPoint2 = new GeoPoint(geoPoint.GetLongitude() * 100000000000000.0, geoPoint.GetLatitude() * 100000000000000.0);
						if (!double.IsNaN(geoPoint2.GetLatitude()) && !double.IsNaN(geoPoint2.GetLongitude()) && geoPoint2.GetLongitude() <= 9.2233720368547758E+18 && geoPoint2.GetLatitude() <= 9.2233720368547758E+18)
						{
							list.Add(new IntPoint((long)Math.Round(geoPoint2.GetLongitude()), (long)Math.Round(geoPoint2.GetLatitude())));
						}
					}
					@class.method_7(list, Enum163.const_0, true);
				}
				List<List<IntPoint>> list2 = new List<List<IntPoint>>();
				if (@class.method_20(Enum162.const_1, list2, Enum164.const_1, Enum164.const_1))
				{
					List<List<GeoPoint>> list3 = new List<List<GeoPoint>>();
					if (list2.Count > 0)
					{
						foreach (List<IntPoint> arg_159_0 in list2)
						{
							List<GeoPoint> list4 = new List<GeoPoint>();
							foreach (IntPoint current2 in list2[0])
							{
								GeoPoint geoPoint = new GeoPoint();
								geoPoint.SetLatitude((double)current2.long_1 / 100000000000000.0);
								geoPoint.SetLongitude((double)current2.long_0 / 100000000000000.0);
								list4.Add(geoPoint);
							}
							list3.Add(list4);
						}
						result = list3;
					}
					else
					{
						result = new List<List<GeoPoint>>();
					}
				}
				else
				{
					result = new List<List<GeoPoint>>();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200234524656666", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<List<GeoPoint>>();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600643D RID: 25661 RVA: 0x003192A4 File Offset: 0x003174A4
		public static double smethod_23(string string_0)
		{
			string numberGroupSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
			double num = 0.0;
			if (string_0.LastIndexOf(numberGroupSeparator) + 4 == string_0.Count<char>())
			{
				num = (double.TryParse(string_0, NumberStyles.Any, CultureInfo.CurrentCulture, out num) ? num : 0.0);
			}
			else
			{
				string text = string_0.Trim().Replace(" ", string.Empty).Replace(",", ".");
				string[] source = text.Split(new char[]
				{
					'.'
				});
				if (source.Count<string>() > 1)
				{
					text = string.Join(string.Empty, source.Take(source.Count<string>() - 1).ToArray<string>());
					text = string.Format("{0}.{1}", text, source.Last<string>());
				}
				num = double.Parse(text, CultureInfo.InvariantCulture);
			}
			return num;
		}

		// Token: 0x0600643E RID: 25662 RVA: 0x00319394 File Offset: 0x00317594
		public static double smethod_24(Tuple<double, double> tuple_0, Tuple<double, double> tuple_1)
		{
			double item = tuple_0.Item1;
			double item2 = tuple_1.Item1;
			double num = tuple_1.Item2 - tuple_0.Item2;
			double y = Math.Sin(num) * Math.Cos(item2);
			double x = Math.Cos(item) * Math.Sin(item2) - Math.Sin(item) * Math.Cos(item2) * Math.Cos(num);
			return Math.Atan2(y, x);
		}

		// Token: 0x0600643F RID: 25663 RVA: 0x003193FC File Offset: 0x003175FC
		public static Tuple<double, double> smethod_25(Tuple<double, double> tuple_0, Tuple<double, double> tuple_1, Tuple<double, double> tuple_2, Tuple<double, double> tuple_3)
		{
			double item = tuple_0.Item1;
			double item2 = tuple_0.Item2;
			double item3 = tuple_2.Item1;
			double item4 = tuple_2.Item2;
			double num = Math2.smethod_24(tuple_0, tuple_1);
			double num2 = Math2.smethod_24(tuple_2, tuple_3);
			double num3 = item3 - item;
			double num4 = item4 - item2;
			double num5 = 2.0 * Math.Asin(Math.Sqrt(Math.Sin(num3 / 2.0) * Math.Sin(num3 / 2.0) + Math.Cos(item) * Math.Cos(item3) * Math.Sin(num4 / 2.0) * Math.Sin(num4 / 2.0)));
			Tuple<double, double> result;
			if (num5 == 0.0)
			{
				result = null;
			}
			else
			{
				double num6 = Math.Acos((Math.Sin(item3) - Math.Sin(item) * Math.Cos(num5)) / (Math.Sin(num5) * Math.Cos(item)));
				if (double.IsNaN(num6))
				{
					num6 = 0.0;
				}
				double num7 = Math.Acos((Math.Sin(item) - Math.Sin(item3) * Math.Cos(num5)) / (Math.Sin(num5) * Math.Cos(item3)));
				double num8;
				double num9;
				if (Math.Sin(item4 - item2) > 0.0)
				{
					num8 = num6;
					num9 = 6.2831853071795862 - num7;
				}
				else
				{
					num8 = 6.2831853071795862 - num6;
					num9 = num7;
				}
				double num10 = (num - num8 + 3.1415926535897931) % 6.2831853071795862 - 3.1415926535897931;
				double num11 = (num9 - num2 + 3.1415926535897931) % 6.2831853071795862 - 3.1415926535897931;
				if (Math.Sin(num10) == 0.0 && Math.Sin(num11) == 0.0)
				{
					result = null;
				}
				else if (Math.Sin(num10) * Math.Sin(num11) < 0.0)
				{
					result = null;
				}
				else
				{
					double d = Math.Acos(-Math.Cos(num10) * Math.Cos(num11) + Math.Sin(num10) * Math.Sin(num11) * Math.Cos(num5));
					double num12 = Math.Atan2(Math.Sin(num5) * Math.Sin(num10) * Math.Sin(num11), Math.Cos(num11) + Math.Cos(num10) * Math.Cos(d));
					double num13 = Math.Asin(Math.Sin(item) * Math.Cos(num12) + Math.Cos(item) * Math.Sin(num12) * Math.Cos(num));
					double num14 = Math.Atan2(Math.Sin(num) * Math.Sin(num12) * Math.Cos(item), Math.Cos(num12) - Math.Sin(item) * Math.Sin(num13));
					double num15 = item2 + num14;
					num15 = (num15 + 9.42477796076938) % 6.2831853071795862 - 3.1415926535897931;
					result = new Tuple<double, double>(num13, num15);
				}
			}
			return result;
		}

		// Token: 0x04003665 RID: 13925
		public static Func<GeoPoint, GeoPoint> GeoPointFunc0 = (GeoPoint geoPoint_0) => geoPoint_0;

		// Token: 0x04003666 RID: 13926
		public static Func<GeoPoint, double> GeoPointLatFunc = (GeoPoint geoPoint_0) => geoPoint_0.GetLatitude();

		// Token: 0x04003667 RID: 13927
		public static Func<GeoPoint, double> GeoPointLonFunc = (GeoPoint geoPoint_0) => geoPoint_0.GetLongitude();

		// Token: 0x04003668 RID: 13928
		public static Func<GeoPoint, double> GeoPointFunc3 = (GeoPoint geoPoint_0) => geoPoint_0.GetLongitude();

		// Token: 0x02000BCD RID: 3021
		[CompilerGenerated]
		public sealed class DistanceMeasurer
		{
			// Token: 0x06006446 RID: 25670 RVA: 0x003197F0 File Offset: 0x003179F0
			internal float GetDistance(GeoPoint location)
			{
				return location.GetDistance(this.longitude, this.latitude);
			}

			// Token: 0x0400366D RID: 13933
			public double longitude;

			// Token: 0x0400366E RID: 13934
			public double latitude;
		}

		// Token: 0x02000BCE RID: 3022
		[CompilerGenerated]
		public sealed class Class262
		{
			// Token: 0x06006448 RID: 25672 RVA: 0x00319814 File Offset: 0x00317A14
			internal void method_0(int int_1, ParallelLoopState parallelLoopState)
			{
				int num = int_1 * 10;
				IGeometry geometry = DouglasPeuckerSimplifier.Simplify((Geometry)this.igeometry_0, (double)num);
				int count = geometry.GetCoordinates().Count;
				if (count < this.int_0 & count > 0)
				{
					this.igeometry_1 = geometry;
					parallelLoopState.Stop();
				}
			}

			// Token: 0x0400366F RID: 13935
			public IGeometry igeometry_0;

			// Token: 0x04003670 RID: 13936
			public int int_0;

			// Token: 0x04003671 RID: 13937
			public IGeometry igeometry_1;
		}
	}
}
