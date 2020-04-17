using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns18;
using ns19;
using ns2;
using ns4;

namespace Command_Core
{
	// Token: GIS点
	public class GeoPoint : Subject, IGeoPoint
	{
		// 保存
		public virtual void Save(ref XmlWriter theWriter, ref HashSet<string> ObjectsAlreadySerialized)
		{
			try
			{
				theWriter.WriteStartElement("GPoint");
				theWriter.WriteElementString("ID", base.GetGuid());
				if (!Information.IsNothing(ObjectsAlreadySerialized))
				{
					if (ObjectsAlreadySerialized.Contains(base.GetGuid()))
					{
						theWriter.WriteEndElement();
						return;
					}
					ObjectsAlreadySerialized.Add(base.GetGuid());
				}
				theWriter.WriteElementString("Lon", XmlConvert.ToString(this.Longitude));
				theWriter.WriteElementString("Lat", XmlConvert.ToString(this.Latitude));
				theWriter.WriteElementString("Alt", XmlConvert.ToString(this.Altitude));
				theWriter.WriteElementString("Name", this.Name.ToString());
				theWriter.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100572", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x0026D97C File Offset: 0x0026BB7C
		public static GeoPoint Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0)
		{
			GeoPoint geoPoint = new GeoPoint();
			GeoPoint geoPoint2 = null;
			GeoPoint result;
			try
			{
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1836990821u)
						{
							if (num <= 1458105184u)
							{
								if (num != 266367750u)
								{
									if (num != 1458105184u || Operators.CompareString(name, "ID", false) != 0)
									{
										continue;
									}
									if (!dictionary_0.ContainsKey(xmlNode.InnerText))
									{
										geoPoint.SetGuid(xmlNode.InnerText);
										dictionary_0.Add(geoPoint.GetGuid(), geoPoint);
										continue;
									}
									geoPoint2 = (GeoPoint)dictionary_0[xmlNode.InnerText];
									result = geoPoint2;
									return result;
								}
								else
								{
									if (Operators.CompareString(name, "Name", false) == 0)
									{
										geoPoint.Name = xmlNode.InnerText;
										continue;
									}
									continue;
								}
							}
							else if (num != 1729717486u)
							{
								if (num != 1836990821u)
								{
									continue;
								}
								if (Operators.CompareString(name, "Latitude", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Longitude", false) != 0)
								{
									continue;
								}
								goto IL_1FA;
							}
						}
						else
						{
							if (num <= 2108682236u)
							{
								if (num != 2022647575u)
								{
									if (num != 2108682236u)
									{
										continue;
									}
									if (Operators.CompareString(name, "Alt", false) != 0)
									{
										continue;
									}
								}
								else if (Operators.CompareString(name, "Altitude", false) != 0)
								{
									continue;
								}
								geoPoint.Altitude = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
								continue;
							}
							if (num != 2564648390u)
							{
								if (num != 3001749054u || Operators.CompareString(name, "Lat", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Lon", false) == 0)
								{
									goto IL_1FA;
								}
								continue;
							}
						}
						geoPoint.Latitude = XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", "."));
						continue;
						IL_1FA:
						geoPoint.Longitude = XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", "."));
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				geoPoint2 = geoPoint;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100573", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = geoPoint2;
			return result;
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x0026DC60 File Offset: 0x0026BE60
		public float GetHeightAboveElevation()
		{
			return this.GetAltitude() - (float)Terrain.GetElevation(this.GetLatitude(), this.GetLongitude(), false);
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x000280E9 File Offset: 0x000262E9
		public GeoPoint()
		{
			this.Name = "";
		}

		// Token: 0x06005897 RID: 22679 RVA: 0x000280FC File Offset: 0x000262FC
		public GeoPoint(double double_2, double double_3)
		{
			this.Longitude = double_2;
			this.Latitude = double_3;
			this.Name = "";
		}

		// Token: 0x06005898 RID: 22680 RVA: 0x0002811D File Offset: 0x0002631D
		public GeoPoint(double double_2, double double_3, float float_1)
		{
			this.Longitude = double_2;
			this.Latitude = double_3;
			this.Altitude = float_1;
			this.Name = "";
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x00028145 File Offset: 0x00026345
		public bool IsAboveSurface()
		{
			return Terrain.GetElevation(this.Latitude, this.Longitude, false) >= 0;
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x0002815F File Offset: 0x0002635F
		public bool IsUnderSurface()
		{
			return Terrain.GetElevation(this.Latitude, this.Longitude, false) < 0;
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x0026DC8C File Offset: 0x0026BE8C
		public float GetDistance(double lon_, double lat_)
		{
			return Math2.GetDistance(this.Latitude, this.Longitude, lat_, lon_);
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x0026DCB0 File Offset: 0x0026BEB0
		public float GetSlantDistance(GeoPoint geoPoint_0)
		{
			float distance = Math2.GetDistance(this.GetLatitude(), this.GetLongitude(), geoPoint_0.GetLatitude(), geoPoint_0.GetLongitude());
			float num = (float)((double)Math.Abs(this.GetAltitude() - geoPoint_0.GetAltitude()) / 1852.0);
			return (float)Math.Sqrt((double)(distance * distance + num * num));
		}

		// Token: 0x0600589D RID: 22685 RVA: 0x0026DD0C File Offset: 0x0026BF0C
		public double GetApproxAngularDistance(double lon_, double lat_)
		{
			double result = 0.0;
			try
			{
				Angle latA = default(Angle);
				Angle lonA = default(Angle);
				Angle latB = default(Angle);
				Angle lonB = default(Angle);
				latA.SetDegrees(this.GetLatitude());
				lonA.SetDegrees(this.GetLongitude());
				latB.SetDegrees(lat_);
				lonB.SetDegrees(lon_);
				result = World.ApproxAngularDistance(latA, lonA, latB, lonB).GetDegrees();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100574", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600589E RID: 22686 RVA: 0x0026DDD8 File Offset: 0x0026BFD8
		public ReferencePoint ToReferencePoint()
		{
			return new ReferencePoint(this.GetLongitude(), this.GetLatitude());
		}

		// Token: 0x0600589F RID: 22687 RVA: 0x0026DDF8 File Offset: 0x0026BFF8
		public bool method_18(List<GeoPoint> list_0, List<GeoPoint> list_1)
		{
			bool flag = false;
			bool result;
			try
			{
				if (Information.IsNothing(list_1))
				{
					flag = true;
				}
				else if (list_0.Count != list_1.Count)
				{
					flag = true;
				}
				else
				{
					int num = list_0.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (list_0[i].GetLatitude() != list_1[i].GetLatitude() || list_0[i].GetLongitude() != list_1[i].GetLongitude())
						{
							flag = true;
							result = true;
							return result;
						}
					}
					flag = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200565", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x060058A0 RID: 22688 RVA: 0x0026DEE4 File Offset: 0x0026C0E4
		public float RelativeBearingTo(Unit unit_0)
		{
			float result = 0f;
			try
			{
				float currentHeading = unit_0.GetCurrentHeading();
				float num = Math2.GetAzimuth(unit_0.GetLatitude(null), unit_0.GetLongitude(null), this.GetLatitude(), this.GetLongitude());
				num = Math2.Normalize(num - currentHeading);
				if (num > 180f)
				{
					result = -(360f - num);
				}
				else
				{
					result = num;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100575", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060058A1 RID: 22689 RVA: 0x0026DFA8 File Offset: 0x0026C1A8
		public bool method_20(ref List<GeoPoint> list_0, ref List<GeoPoint> list_1, ref List<GeoPoint> list_2, float float_1)
		{
			bool flag = false;
			bool result;
			if (Information.IsNothing(list_0))
			{
				flag = false;
			}
			else if (list_0.Count == 0)
			{
				flag = false;
			}
			else
			{
				try
				{
					List<GeoPoint> list;
					if (!Information.IsNothing(list_1) && !Information.IsNothing(list_2) && float_1 != 0f)
					{
						if (list_1.Count == 0 || this.method_18(list_0, list_2))
						{
							ActiveUnit_Navigator.smethod_0(float_1, ref list_0, ref list_1, ref list_2);
						}
						list = list_1.ToList<GeoPoint>();
						flag = (result = this.method_21(ref list, true));
						return result;
					}
					list = list_0.ToList<GeoPoint>();
					flag = this.method_21(ref list, true);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101261", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x060058A2 RID: 22690 RVA: 0x0026E0A0 File Offset: 0x0026C2A0
		public bool method_21(ref List<GeoPoint> theArea, bool HaveToCheckAntimeridian = true)
		{
			bool result = false;
			try
			{
				if (Information.IsNothing(theArea))
				{
					result = false;
				}
				else if (theArea.Count < 3)
				{
					result = false;
				}
				else if (HaveToCheckAntimeridian)
				{
					if (Math2.smethod_19(theArea))
					{
						GeoPoint geoPoint_ = new GeoPoint(Math2.NormalizeLongitude(this.GetLongitude() + 180.0), this.GetLatitude());
						List<GeoPoint> list = new List<GeoPoint>();
						foreach (GeoPoint current in theArea)
						{
							list.Add(new GeoPoint(Math2.NormalizeLongitude(current.GetLongitude() + 180.0), current.GetLatitude()));
						}
						result = GeoPoint.smethod_2(geoPoint_, list);
					}
					else
					{
						result = GeoPoint.smethod_2(this, theArea);
					}
				}
				else
				{
					result = GeoPoint.smethod_2(this, theArea);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100576", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060058A3 RID: 22691 RVA: 0x0026E1E8 File Offset: 0x0026C3E8
		public bool method_22(ref List<ReferencePoint> theArea, bool HaveToCheckAntimeridian = true)
		{
			bool result = false;
			try
			{
				if (Information.IsNothing(theArea))
				{
					result = false;
				}
				else if (theArea.Count < 3)
				{
					result = false;
				}
				else if (HaveToCheckAntimeridian)
				{
					if (Math2.smethod_20(ref theArea))
					{
						GeoPoint geoPoint_ = new GeoPoint(Math2.NormalizeLongitude(this.GetLongitude() + 180.0), this.GetLatitude());
						List<GeoPoint> list = new List<GeoPoint>();
						foreach (GeoPoint current in theArea)
						{
							list.Add(new GeoPoint(Math2.NormalizeLongitude(current.GetLongitude() + 180.0), current.GetLatitude()));
						}
						result = GeoPoint.smethod_2(geoPoint_, list);
					}
					else
					{
						result = GeoPoint.smethod_1(this, theArea);
					}
				}
				else
				{
					result = GeoPoint.smethod_1(this, theArea);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100577", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060058A4 RID: 22692 RVA: 0x0026E330 File Offset: 0x0026C530
		public static bool smethod_1(GeoPoint geoPoint_0, List<ReferencePoint> ReferencePoints)
		{
			bool result = false;
			try
			{
				double num = -90.0;
				double num2 = 90.0;
				double num3 = 180.0;
				double num4 = -180.0;
				int count = ReferencePoints.Count;
				int num5 = count - 1;
				for (int i = 0; i <= num5; i++)
				{
					ReferencePoint referencePoint = ReferencePoints[i];
					double latitude = referencePoint.GetLatitude();
					double longitude = referencePoint.GetLongitude();
					if (latitude > num)
					{
						num = latitude;
					}
					if (latitude < num2)
					{
						num2 = latitude;
					}
					if (longitude > num4)
					{
						num4 = longitude;
					}
					if (longitude < num3)
					{
						num3 = longitude;
					}
				}
				if (geoPoint_0.GetLatitude() > num)
				{
					result = false;
				}
				else if (geoPoint_0.GetLatitude() < num2)
				{
					result = false;
				}
				else if (geoPoint_0.GetLongitude() > num4)
				{
					result = false;
				}
				else if (geoPoint_0.GetLongitude() < num3)
				{
					result = false;
				}
				else
				{
					int num6 = count;
					double latitude2 = geoPoint_0.GetLatitude();
					GeoPoint geoPoint = ReferencePoints[num6 - 1];
					int num7 = 0;
					int num8 = num6 - 1;
					for (int j = 0; j <= num8; j++)
					{
						GeoPoint geoPoint2 = ReferencePoints[j];
						GeoPoint geoPoint3;
						if (geoPoint2 != geoPoint)
						{
							geoPoint3 = ReferencePoints[j + 1];
						}
						else
						{
							geoPoint3 = ReferencePoints[0];
						}
						double latitude3 = geoPoint2.GetLatitude();
						double latitude4 = geoPoint3.GetLatitude();
						if (latitude3 <= latitude2)
						{
							if (latitude4 > latitude2 && GeoPoint.smethod_5(geoPoint2, geoPoint3, geoPoint_0) > 0)
							{
								num7++;
							}
						}
						else if (latitude4 <= latitude2 && GeoPoint.smethod_5(geoPoint2, geoPoint3, geoPoint_0) < 0)
						{
							num7--;
						}
					}
					result = (num7 != 0);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100578", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060058A5 RID: 22693 RVA: 0x0026E564 File Offset: 0x0026C764
		public static bool smethod_2(GeoPoint geoPoint_0, List<GeoPoint> list_0)
		{
			bool result = false;
			try
			{
				double latitude = geoPoint_0.GetLatitude();
				double longitude = geoPoint_0.GetLongitude();
				int count = list_0.Count;
				int num = count - 1;
				double num2 = 0.0;
				double num3 = 0.0;
				double num4 = 0.0;
				double num5 = 0.0;
				for (int i = 0; i <= num; i++)
				{
					GeoPoint geoPoint = list_0[i];
					double latitude2 = geoPoint.GetLatitude();
					double longitude2 = geoPoint.GetLongitude();
					if (latitude2 > num2)
					{
						num2 = latitude2;
					}
					if (latitude2 < num3)
					{
						num3 = latitude2;
					}
					if (longitude2 > num4)
					{
						num4 = longitude2;
					}
					if (longitude2 < num5)
					{
						num5 = longitude2;
					}
				}
				if (latitude > num2)
				{
					result = false;
				}
				else if (latitude < num3)
				{
					result = false;
				}
				else if (longitude > num4)
				{
					result = false;
				}
				else if (longitude < num5)
				{
					result = false;
				}
				else
				{
					GeoPoint geoPoint2 = list_0[count - 1];
					int num6 = 0;
					int num7 = count - 1;
					for (int j = 0; j <= num7; j++)
					{
						GeoPoint geoPoint3 = list_0[j];
						GeoPoint geoPoint4;
						if (geoPoint3 != geoPoint2)
						{
							geoPoint4 = list_0[j + 1];
						}
						else
						{
							geoPoint4 = list_0[0];
						}
						double latitude3 = geoPoint3.GetLatitude();
						double latitude4 = geoPoint4.GetLatitude();
						if (latitude3 <= latitude)
						{
							if (latitude4 > latitude && GeoPoint.smethod_5(geoPoint3, geoPoint4, geoPoint_0) > 0)
							{
								num6++;
							}
						}
						else if (latitude4 <= latitude && GeoPoint.smethod_5(geoPoint3, geoPoint4, geoPoint_0) < 0)
						{
							num6--;
						}
					}
					result = (num6 != 0);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100579", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x0026E78C File Offset: 0x0026C98C
		public static bool smethod_3(ref double double_2, ref double double_3, ref double[] double_4, ref double[] double_5)
		{
			bool result = false;
			try
			{
				int num = double_4.Length;
				double num2 = double_2;
				double double_6 = double_3;
				int num3 = 0;
				int num4 = num - 1;
				for (int i = 0; i <= num4; i++)
				{
					double num5 = double_5[i];
					double double_7 = double_4[i];
					double num6;
					double double_8;
					if (i != num - 1)
					{
						num6 = double_5[i + 1];
						double_8 = double_4[i + 1];
					}
					else
					{
						num6 = double_5[0];
						double_8 = double_4[0];
					}
					if (num5 <= num2)
					{
						if (num6 > num2 && GeoPoint.smethod_4(double_7, num5, double_8, num6, double_6, num2) > 0)
						{
							num3++;
						}
					}
					else if (num6 <= num2 && GeoPoint.smethod_4(double_7, num5, double_8, num6, double_6, num2) < 0)
					{
						num3--;
					}
				}
				result = (num3 != 0);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100580", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060058A7 RID: 22695 RVA: 0x0026E8C0 File Offset: 0x0026CAC0
		private static int smethod_4(double double_2, double double_3, double double_4, double double_5, double double_6, double double_7)
		{
			int result = 0;
			try
			{
				double num = (double_4 - double_2) * (double_7 - double_3) - (double_6 - double_2) * (double_5 - double_3);
				if (num > 0.0)
				{
					result = 1;
				}
				else if (num < 0.0)
				{
					result = -1;
				}
				else
				{
					result = 0;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100581", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x0026E960 File Offset: 0x0026CB60
		private static int smethod_5(GeoPoint geoPoint_0, GeoPoint geoPoint_1, GeoPoint geoPoint_2)
		{
			int result = 0;
			try
			{
				double longitude = geoPoint_0.GetLongitude();
				double latitude = geoPoint_0.GetLatitude();
				double longitude2 = geoPoint_1.GetLongitude();
				double latitude2 = geoPoint_1.GetLatitude();
				double longitude3 = geoPoint_2.GetLongitude();
				double latitude3 = geoPoint_2.GetLatitude();
				double num = (longitude2 - longitude) * (latitude3 - latitude) - (longitude3 - longitude) * (latitude2 - latitude);
				if (num > 0.0)
				{
					result = 1;
				}
				else if (num < 0.0)
				{
					result = -1;
				}
				else
				{
					result = 0;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100582", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060058A9 RID: 22697 RVA: 0x0026EA38 File Offset: 0x0026CC38
		public static bool smethod_6(double double_2, double double_3, Scenario scenario_0, ref List<ActiveUnit> list_0)
		{
			bool flag = false;
			bool result;
			try
			{
				for (int i = scenario_0.Cache_FacilitiesWithPiers.Count - 1; i >= 0; i += -1)
				{
					ActiveUnit activeUnit = scenario_0.Cache_FacilitiesWithPiers[i];
					GeoPoint geoPoint = new GeoPoint(double_3, double_2);
					List<GeoPoint> list = activeUnit.GetDockingOps().method_5();
					if (geoPoint.method_21(ref list, false))
					{
						flag = true;
						result = true;
						return result;
					}
				}
				flag = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200462", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x060058AA RID: 22698 RVA: 0x0026EAF8 File Offset: 0x0026CCF8
		public static bool smethod_7(double double_2, double double_3)
		{
			bool result = false;
			try
			{
				result = (Class380.smethod_1().method_0(double_2, double_3, false) || Class380.smethod_0().method_0(double_2, double_3, false) || Class380.smethod_2().method_0(double_2, double_3, false) || Class380.smethod_3().method_0(double_2, double_3, false));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100583", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060058AB RID: 22699 RVA: 0x0026EBB0 File Offset: 0x0026CDB0
		public double GetLongitude()
		{
			return this.Longitude;
		}

		// Token: 0x060058AC RID: 22700 RVA: 0x0026EBC8 File Offset: 0x0026CDC8
		public void SetLongitude(double double_2)
		{
			if (double_2 > 180.0 || double_2 < -180.0)
			{
				double_2 = Math2.NormalizeLongitude(double_2);
			}
			if (double.IsNaN(double_2))
			{
				bool arg_38_0 = Debugger.IsAttached;
				double_2 = 0.0;
			}
			this.Longitude = double_2;
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x0026EC20 File Offset: 0x0026CE20
		public double GetLatitude()
		{
			return this.Latitude;
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x0026EC38 File Offset: 0x0026CE38
		public void SetLatitude(double value)
		{
			if (value > 90.0 || value < -90.0)
			{
				value = Math2.NormalizeLatitude(value);
			}
			if (double.IsNaN(value))
			{
				bool arg_38_0 = Debugger.IsAttached;
				value = 0.0;
			}
			this.Latitude = value;
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x0026EC90 File Offset: 0x0026CE90
		public float GetAltitude()
		{
			return this.Altitude;
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x00028176 File Offset: 0x00026376
		public void SetAltitude(float value)
		{
			this.Altitude = value;
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x0026ECA8 File Offset: 0x0026CEA8
		public static GeoPoint smethod_8(double double_2, double double_3, float float_1, float float_2)
		{
			GeoPoint geoPoint = new GeoPoint();
			GeoPoint geoPoint2;
			double longitude = (geoPoint2 = geoPoint).GetLongitude();
			GeoPoint geoPoint3;
			double latitude = (geoPoint3 = geoPoint).GetLatitude();
			Math2.GetAnotherGeopoint(double_3, double_2, ref longitude, ref latitude, float_2, float_1);
			geoPoint3.SetLatitude(latitude);
			geoPoint2.SetLongitude(longitude);
			return geoPoint;
		}

		// Token: 0x04002BC8 RID: 11208
		private double Longitude;

		// Token: 0x04002BC9 RID: 11209
		private double Latitude;

		// Token: 0x04002BCA RID: 11210
		private float Altitude;
	}
}
