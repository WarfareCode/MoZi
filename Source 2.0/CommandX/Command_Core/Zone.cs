using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DotSpatial.Topology;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns27;
using ns3;

namespace Command_Core
{
	// Token: 区域
	public class Zone : Subject
	{
		// 构造函数
		public Zone()
		{
			this.Area = new List<ReferencePoint>();
			this.list_1 = new List<ReferencePoint>();
			this.list_2 = new List<ReferencePoint>();
			this.list_3 = new List<GeoPoint>();
			this.list_4 = new List<GeoPoint>();
			this.IsActive = true;
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x002549E4 File Offset: 0x00252BE4
		[CompilerGenerated]
		public  ObservableCollection<GlobalVariables.ActiveUnitType> GetAffectedUnitTypes()
		{
			return this.AffectedUnitTypes;
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x002549FC File Offset: 0x00252BFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void SetAffectedUnitTypes(ObservableCollection<GlobalVariables.ActiveUnitType> observableCollection_1)
		{
			NotifyCollectionChangedEventHandler value = new NotifyCollectionChangedEventHandler(this.method_14);
			ObservableCollection<GlobalVariables.ActiveUnitType> affectedUnitTypes = this.AffectedUnitTypes;
			if (affectedUnitTypes != null)
			{
				affectedUnitTypes.CollectionChanged -= value;
			}
			this.AffectedUnitTypes = observableCollection_1;
			affectedUnitTypes = this.AffectedUnitTypes;
			if (affectedUnitTypes != null)
			{
				affectedUnitTypes.CollectionChanged += value;
			}
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x00254A48 File Offset: 0x00252C48
		public bool IsAffected(ActiveUnit activeUnit_)
		{
			bool flag = false;
			bool result;
			if (!this.IsActive)
			{
				flag = false;
			}
			else
			{
				try
				{
					if (activeUnit_.IsGroup)
					{
						flag = (!Information.IsNothing(((Group)activeUnit_).GetGroupLead()) && this.IsAffected(((Group)activeUnit_).GetGroupLead()));
					}
					else
					{
						bool? flag2;
						switch (activeUnit_.GetUnitType())
						{
						case GlobalVariables.ActiveUnitType.Aircraft:
							if (!this.AircraftAffected.HasValue)
							{
								this.InitAffectedUnitType();
							}
							flag2 = this.AircraftAffected;
							goto IL_161;
						case GlobalVariables.ActiveUnitType.Ship:
							if (!this.ShipAffected.HasValue)
							{
								this.InitAffectedUnitType();
							}
							flag2 = this.ShipAffected;
							goto IL_161;
						case GlobalVariables.ActiveUnitType.Submarine:
							if (!this.SubmarineAffected.HasValue)
							{
								this.InitAffectedUnitType();
							}
							flag2 = this.SubmarineAffected;
							goto IL_161;
						case GlobalVariables.ActiveUnitType.Facility:
							if (!this.FacilityAffected.HasValue)
							{
								this.InitAffectedUnitType();
							}
							flag2 = this.FacilityAffected;
							goto IL_161;
						case GlobalVariables.ActiveUnitType.Weapon:
							if (((Weapon)activeUnit_).GetWeaponType() == Weapon._WeaponType.Decoy_Vehicle)
							{
								flag = true;
								result = true;
								return result;
							}
							if (!this.WeaponAffected.HasValue)
							{
								this.InitAffectedUnitType();
							}
							flag2 = this.WeaponAffected;
							goto IL_161;
						case GlobalVariables.ActiveUnitType.Satellite:
							if (!this.SatelliteAffected.HasValue)
							{
								this.InitAffectedUnitType();
							}
							flag2 = this.SatelliteAffected;
							goto IL_161;
						}
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new NotImplementedException();
						IL_161:
						flag = flag2.Value;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100995", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					flag = false;
					ProjectData.ClearProjectError();
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x00254C24 File Offset: 0x00252E24
		public void method_12(float float_0, ref List<GeoPoint> list_5, ref List<ReferencePoint> list_6)
		{
			new List<GeoPoint>();
			new Class258.Class259(0.0, 0.0);
			try
			{
				list_6.Clear();
				list_5.Clear();
				int count = this.Area.Count;
				if (count != 0)
				{
					int num;
					if (count > 2)
					{
						num = count;
					}
					else
					{
						num = count - 1;
					}
					Coordinate[] array = new Coordinate[num + 1];
					int num2 = count - 1;
					for (int i = 0; i <= num2; i++)
					{
						array[i] = new Coordinate(this.Area[i].GetLongitude(), this.Area[i].GetLatitude());
						List<ReferencePoint> list = list_6;
						ReferencePoint referencePoint = this.Area[i];
						List<ReferencePoint> area;
						int num3;
						ReferencePoint value = (area = this.Area)[num3 = i];
						ReferencePoint item = referencePoint.NewReferencePoint(ref value);
						area[num3] = value;
						list.Add(item);
					}
					if (count > 2)
					{
						array[count] = array[0];
					}
					IGeometry geometry = null;
					if (count > 2)
					{
						Polygon polygon = new Polygon(new LinearRing(array));
						try
						{
							geometry = polygon.Buffer((double)float_0, 3);
							goto IL_23B;
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200278", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
							goto IL_23B;
						}
					}
					if (count == 2)
					{
						LineString lineString = new LineString(array);
						try
						{
							geometry = lineString.Buffer((double)float_0, 3);
							goto IL_23B;
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							ex4.Data.Add("Error at 200315", ex4.Message);
							GameGeneral.LogException(ref ex4);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
							return;
						}
					}
					if (count == 1)
					{
						Point point = new Point(array[0]);
						try
						{
							geometry = point.Buffer((double)float_0, 3);
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5);
							Exception ex6 = ex5;
							ex6.Data.Add("Error at 200652", ex6.Message);
							GameGeneral.LogException(ref ex6);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
							return;
						}
					}
					IL_23B:
					if (Debugger.IsAttached && (Information.IsNothing(geometry) || geometry.GetCoordinates().Count == 0))
					{
						Debugger.Break();
					}
					if (!Information.IsNothing(geometry))
					{
						IPolygon polygon2 = (IPolygon)geometry;
						int num3 = polygon2.GetCoordinates().Count - 2;
						for (int j = 0; j <= num3; j++)
						{
							if (polygon2.GetCoordinates()[j].X > 180.0)
							{
								polygon2.GetCoordinates()[j].X = 180.0;
							}
							else if (polygon2.GetCoordinates()[j].X < -180.0)
							{
								polygon2.GetCoordinates()[j].X = -180.0;
							}
							if (polygon2.GetCoordinates()[j].Y > 90.0)
							{
								polygon2.GetCoordinates()[j].Y = 90.0;
							}
							else if (polygon2.GetCoordinates()[j].Y < -90.0)
							{
								polygon2.GetCoordinates()[j].Y = -90.0;
							}
							list_5.Add(new GeoPoint(polygon2.GetCoordinates()[j].X, polygon2.GetCoordinates()[j].Y));
						}
					}
				}
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				ex8.Data.Add("Error at 200277", ex8.Message);
				GameGeneral.LogException(ref ex8);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x002550B8 File Offset: 0x002532B8
		public float method_13(double Latitude, double Longitude, Scenario scenario_0)
		{
			float num;
			float result;
			try
			{
				int count = this.Area.Count;
				if (count == 0)
				{
					num = 3.40282347E+38f;
					result = num;
					return result;
				}
				int num2;
				if (count > 2)
				{
					num2 = count;
				}
				else
				{
					num2 = count - 1;
				}
				Coordinate[] array = new Coordinate[num2 + 1];
				int num3 = count - 1;
				for (int i = 0; i <= num3; i++)
				{
					array[i] = new Coordinate(this.Area[i].GetLongitude(), this.Area[i].GetLatitude());
				}
				if (count > 2)
				{
					array[count] = array[0];
				}
				if (count > 2)
				{
					Polygon igeometry_ = new Polygon(new LinearRing(array));
					try
					{
						Point igeometry_2 = new Point(Longitude, Latitude);
						Coordinate[] array2 = Class2311.smethod_0(igeometry_, igeometry_2);
						num = Math2.GetDistance(array2[0].Y, array2[0].X, array2[1].Y, array2[1].X);
						result = num;
						return result;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200339", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						num = 3.40282347E+38f;
						ProjectData.ClearProjectError();
						result = num;
						return result;
					}
				}
				if (count == 2)
				{
					LineString igeometry_3 = new LineString(array);
					try
					{
						Point igeometry_4 = new Point(Longitude, Latitude);
						Coordinate[] array3 = Class2311.smethod_0(igeometry_3, igeometry_4);
						num = Math2.GetDistance(array3[0].Y, array3[0].X, array3[1].Y, array3[1].X);
						result = num;
						return result;
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ex4.Data.Add("Error at 200338", ex4.Message);
						GameGeneral.LogException(ref ex4);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						num = 3.40282347E+38f;
						ProjectData.ClearProjectError();
						result = num;
						return result;
					}
				}
				if (count == 1)
				{
					num = 3.40282347E+38f;
					result = num;
					return result;
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 200336", ex6.Message);
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			num = 3.40282347E+38f;
			result = num;
			return result;
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x00027968 File Offset: 0x00025B68
		private void method_14(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.InitAffectedUnitType();
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x00255360 File Offset: 0x00253560
		private void InitAffectedUnitType()
		{
			this.AircraftAffected = new bool?(this.GetAffectedUnitTypes().Contains(GlobalVariables.ActiveUnitType.Aircraft));
			this.ShipAffected = new bool?(this.GetAffectedUnitTypes().Contains(GlobalVariables.ActiveUnitType.Ship));
			this.SubmarineAffected = new bool?(this.GetAffectedUnitTypes().Contains(GlobalVariables.ActiveUnitType.Submarine));
			this.FacilityAffected = new bool?(this.GetAffectedUnitTypes().Contains(GlobalVariables.ActiveUnitType.Facility));
			this.WeaponAffected = new bool?(this.GetAffectedUnitTypes().Contains(GlobalVariables.ActiveUnitType.Weapon));
			this.SatelliteAffected = new bool?(this.GetAffectedUnitTypes().Contains(GlobalVariables.ActiveUnitType.Satellite));
		}

		// Token: 0x060056B2 RID: 22194 RVA: 0x002553F8 File Offset: 0x002535F8
		public bool method_16(List<ReferencePoint> list_5)
		{
			bool flag;
			bool result;
			if (this.Area.Count != list_5.Count)
			{
				flag = true;
			}
			else
			{
				int num = this.Area.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (this.Area[i].GetLatitude() != list_5[i].GetLatitude() || this.Area[i].GetLongitude() != list_5[i].GetLongitude())
					{
						result = true;
						return result;
					}
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x04002A91 RID: 10897
		public string Description = "";

		// Token: 0x04002A92 RID: 10898
		public List<ReferencePoint> Area;

		// Token: 0x04002A93 RID: 10899
		public List<ReferencePoint> list_1;

		// Token: 0x04002A94 RID: 10900
		public List<ReferencePoint> list_2;

		// Token: 0x04002A95 RID: 10901
		public List<GeoPoint> list_3;

		// Token: 0x04002A96 RID: 10902
		public List<GeoPoint> list_4;

		// Token: 0x04002A97 RID: 10903
		[CompilerGenerated]
		private ObservableCollection<GlobalVariables.ActiveUnitType> AffectedUnitTypes;

		// Token: 0x04002A98 RID: 10904
		public bool IsActive;

		// Token: 0x04002A99 RID: 10905
		private bool? AircraftAffected;

		// Token: 0x04002A9A RID: 10906
		private bool? ShipAffected;

		// Token: 0x04002A9B RID: 10907
		private bool? SubmarineAffected;

		// Token: 0x04002A9C RID: 10908
		private bool? FacilityAffected;

		// Token: 0x04002A9D RID: 10909
		private bool? WeaponAffected;

		// Token: 0x04002A9E RID: 10910
		private bool? SatelliteAffected;
	}
}
