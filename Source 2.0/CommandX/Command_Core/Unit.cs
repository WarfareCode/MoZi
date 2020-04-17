using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns18;
using ns19;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 单元
	public class Unit : Subject
	{
		// Token: 0x060009BC RID: 2492 RVA: 0x0006CBF0 File Offset: 0x0006ADF0
		public virtual void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Unit");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (hashSet_0.Contains(base.GetGuid()))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(base.GetGuid());
					xmlWriter_0.WriteElementString("Name", this.Name);
					xmlWriter_0.WriteElementString("CurrentHeading", XmlConvert.ToString(this.GetCurrentHeading()));
					xmlWriter_0.WriteElementString("CurrentSpeed", XmlConvert.ToString(this.GetCurrentSpeed()));
					xmlWriter_0.WriteElementString("CurrentAltitude", XmlConvert.ToString(this.GetCurrentAltitude_ASL(false)));
					xmlWriter_0.WriteElementString("Longitude", XmlConvert.ToString(this.longitude));
					xmlWriter_0.WriteElementString("Latitude", XmlConvert.ToString(this.latitude));
					xmlWriter_0.WriteElementString("UnitClass", this.UnitClass);
					if (this.GetRangeSymbols().Count > 0)
					{
						xmlWriter_0.WriteStartElement("RangeSymbols");
						using (List<RangeSymbol>.Enumerator enumerator = this.GetRangeSymbols().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								enumerator.Current.Save(ref xmlWriter_0);
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteElementString("Side", this.m_Side.GetSideName());
					if (!string.IsNullOrEmpty(this.Message))
					{
						xmlWriter_0.WriteElementString("Message", this.Message);
					}
					if (this.GetLongitude_UnitEntersAreaCheck().HasValue)
					{
						xmlWriter_0.WriteElementString("Longitude_UnitEntersAreaCheck", XmlConvert.ToString(this.GetLongitude_UnitEntersAreaCheck().Value));
					}
					if (this.GetLatitude_UnitEntersAreaCheck().HasValue)
					{
						xmlWriter_0.WriteElementString("Latitude_UnitEntersAreaCheck", XmlConvert.ToString(this.GetLatitude_UnitEntersAreaCheck().Value));
					}
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100864", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public  void vmethod_5()
		{
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual bool IsOfAirLaunchedGuidedWeapon()
		{
			return false;
		}

		// 取所属方
		public virtual Side GetSide(bool SetSideOnly = false)
		{
			return this.m_Side;
		}

		// 设置所属方
		public virtual void SetSide(bool SetSideOnly, Side value)
		{
			this.m_Side = value;
		}

		// 取航向
		public virtual float GetCurrentHeading()
		{
			return this.currentHeading;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00009306 File Offset: 0x00007506
		public virtual void SetCurrentHeading(float float_7)
		{
			if (float.IsNaN(float_7))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			else
			{
				this.currentHeading = float_7;
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual int GetMastHeight()
		{
			return 0;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual  int GetTargetVisualSize()
		{
			return 0;
		}

		// 取地形高度
		public int GetTerrainElevation(bool bool_8, bool bool_9, bool bool_10)
		{
			int num = 0;
			int result;
			try
			{
				if (!this.IsGroup)
				{
					if (bool_10 || !this.Elevation.HasValue)
					{
						this.Elevation = new int?((int)Terrain.GetElevation(this.GetLatitude(null), this.GetLongitude(null), bool_9));
					}
				}
				else
				{
					Group group = (Group)this;
					if (group.GetGroupType() == Group.GroupType.AirGroup)
					{
						if (Information.IsNothing(group.GetGroupLead()))
						{
							num = 0;
							result = 0;
							return result;
						}
						Aircraft aircraft = (Aircraft)group.GetGroupLead();
						this.Elevation = new int?(aircraft.GetTerrainElevation(false, bool_9, bool_10));
					}
					else if (group.GetGroupType() == Group.GroupType.SubGroup)
					{
						if (Information.IsNothing(group.GetGroupLead()))
						{
							num = 0;
							result = 0;
							return result;
						}
						Submarine submarine = (Submarine)group.GetGroupLead();
						this.Elevation = new int?(submarine.GetTerrainElevation(false, bool_9, bool_10));
					}
					else
					{
						this.Elevation = new int?((int)Terrain.GetElevation(this.GetLatitude(null), this.GetLongitude(null), bool_9));
					}
				}
				if (bool_8)
				{
					int? elevation = this.Elevation;
					if ((elevation.HasValue ? new bool?(elevation.GetValueOrDefault() < 0) : null).GetValueOrDefault())
					{
						num = 0;
						result = 0;
						return result;
					}
				}
				if (!this.Elevation.HasValue)
				{
					int elevation2 = (int)Terrain.GetElevation(this.GetLatitude(null), this.GetLongitude(null), bool_9);
					this.Elevation = new int?(elevation2);
				}
				num = this.Elevation.Value;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200295", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = 0;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// 取海拔高
		public int GetAltitude_ASL(bool bool_8, float elapsedTime)
		{
			if (Information.IsNothing(this.Altitude_ASL))
			{
				this.Move(elapsedTime);
			}
			int result;
			if (bool_8)
			{
				int? altitude_ASL = this.Altitude_ASL;
				if ((altitude_ASL.HasValue ? new bool?(altitude_ASL.GetValueOrDefault() < 0) : null).GetValueOrDefault())
				{
					result = 0;
					return result;
				}
			}
			int value = this.Altitude_ASL.Value;
			result = value;
			return result;
		}

		// 取经度
		public  double GetLongitude(float elapsedTime)
		{
			if (Information.IsNothing(this.Longitude))
			{
				this.Move(elapsedTime);
			}
			return this.Longitude.Value;
		}

		// 取纬度
		public  double GetLatitude(float elapsedTime)
		{
			if (Information.IsNothing(this.Latitude))
			{
				this.Move(elapsedTime);
			}
			return this.Latitude.Value;
		}

		// 运动
		private void Move(float elapsedTime)
		{
			if (this.GetCurrentSpeed() > 0f)
			{
				float moveDistance = this.GetMoveDistance(elapsedTime);
				double num = 0.0;
				double num2 = 0.0;
				GeoPointGenerator.GetOtherGeoPoint(this.GetLongitude(null), this.GetLatitude(null), ref num, ref num2, (double)moveDistance, (double)this.GetCurrentHeading());
				this.Altitude_ASL = new int?((int)Terrain.GetElevation(num2, num, false));
				this.Longitude = new double?(num);
				this.Latitude = new double?(num2);
			}
			else
			{
				if (Information.IsNothing(this.Elevation))
				{
					this.Elevation = new int?(this.GetTerrainElevation(true, false, false));
				}
				this.Altitude_ASL = this.Elevation;
				this.Longitude = new double?(this.longitude);
				this.Latitude = new double?(this.latitude);
			}
		}

		// 取地面高
		public float GetAltitude_AGL()
		{
			float num = 0f;
			float result;
			try
			{
				if (!this.IsGroup)
				{
					if (this.IsAircraft)
					{
						if (this.IsOnLand())
						{
							this.Altitude_AGL = new float?(this.GetCurrentAltitude_ASL(false) - (float)Terrain.GetElevation(this.GetLatitude(null), this.GetLongitude(null), false));
						}
						else
						{
							this.Altitude_AGL = new float?(this.GetCurrentAltitude_ASL(false));
						}
					}
					else if (this.IsWeapon)
					{
						if (this.IsOnLand())
						{
							this.Altitude_AGL = new float?(this.GetCurrentAltitude_ASL(false) - (float)Terrain.GetElevation(this.GetLatitude(null), this.GetLongitude(null), false));
						}
						else if (this.IsTorpedo())
						{
							this.Altitude_AGL = new float?(this.GetCurrentAltitude_ASL(false) - (float)Terrain.GetElevation(this.GetLatitude(null), this.GetLongitude(null), false));
						}
						else
						{
							this.Altitude_AGL = new float?(this.GetCurrentAltitude_ASL(false));
						}
					}
					else
					{
						if (this.GetCurrentAltitude_ASL(false) < -11000f)
						{
							this.SetAltitude_ASL(false, 0f);
						}
						this.Altitude_AGL = new float?(this.GetCurrentAltitude_ASL(false) - (float)Terrain.GetElevation(this.GetLatitude(null), this.GetLongitude(null), false));
					}
				}
				else
				{
					Group group = (Group)this;
					if (group.GetGroupType() == Group.GroupType.AirGroup)
					{
						if (Information.IsNothing(group.GetGroupLead()))
						{
							num = 0f;
							result = num;
							return result;
						}
						Aircraft aircraft = (Aircraft)group.GetGroupLead();
						this.Altitude_AGL = new float?(aircraft.GetAltitude_AGL());
					}
					else if (group.GetGroupType() == Group.GroupType.SubGroup)
					{
						if (Information.IsNothing(group.GetGroupLead()))
						{
							num = 0f;
							result = num;
							return result;
						}
						Submarine submarine = (Submarine)group.GetGroupLead();
						this.Altitude_AGL = new float?(submarine.GetAltitude_AGL());
					}
					else
					{
						this.Altitude_AGL = new float?(0f);
					}
				}
				if (!this.Altitude_AGL.HasValue)
				{
					this.Altitude_AGL = new float?(this.GetCurrentAltitude_ASL(false) - (float)Terrain.GetElevation(this.GetLatitude(null), this.GetLongitude(null), false));
				}
				num = this.Altitude_AGL.Value;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200320", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = this.currentAltitude_ASL;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0006D588 File Offset: 0x0006B788
		public virtual float GetCurrentAltitude_ASL(bool DoSanityCheck = false)
		{
			return this.currentAltitude_ASL;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0000932B File Offset: 0x0000752B
		public virtual void SetAltitude_ASL(bool DoSanityCheck, float value)
		{
			this.currentAltitude_ASL = value;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0006D5A0 File Offset: 0x0006B7A0
		public virtual float GetPitch()
		{
			return this.Pitch;
		}

		// 设置俯仰角
		public virtual void SetPitch(float float_7)
		{
			this.Pitch = float_7;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0006D5B8 File Offset: 0x0006B7B8
		public virtual float GetRoll()
		{
			return this.Roll;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0000933D File Offset: 0x0000753D
		public virtual void SetRoll(float value)
		{
			this.Roll = value;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0006D5D0 File Offset: 0x0006B7D0
		public virtual float vmethod_19()
		{
			return this.float_5;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00009346 File Offset: 0x00007546
		public virtual void vmethod_20(float float_7)
		{
			this.float_5 = float_7;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0000934F File Offset: 0x0000754F
		public bool IsContact()
		{
			return base.GetType() == typeof(Contact);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00009366 File Offset: 0x00007566
		public bool IsOnLand()
		{
			return this.GetTerrainElevation(false, false, false) > 0;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00009374 File Offset: 0x00007574
		public bool IsAboveSeaLevel(float t)
		{
			return this.GetAltitude_ASL(false, t) > 0;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00009381 File Offset: 0x00007581
		public virtual bool IsUnderGround()
		{
			return this.GetAltitude_AGL() < 0f;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00009390 File Offset: 0x00007590
		public virtual bool IsUnderWater()
		{
			return this.GetCurrentAltitude_ASL(false) < 0f && this.GetCurrentAltitude_ASL(false) >= (float)this.GetTerrainElevation(false, false, false);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000093B9 File Offset: 0x000075B9
		public Unit()
		{
			this.lazy_1 = new Lazy<ConcurrentDictionary<int, bool>>();
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0006D5E8 File Offset: 0x0006B7E8
		public List<RangeSymbol> GetRangeSymbols()
		{
			if (Information.IsNothing(this.rangeSymbols))
			{
				this.rangeSymbols = new List<RangeSymbol>();
			}
			return this.rangeSymbols;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0006D618 File Offset: 0x0006B818
		public virtual double GetLongitude(bool? _HintIsOperating = null)
		{
			return this.longitude;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0006D630 File Offset: 0x0006B830
		public virtual void SetLongitude(bool? _HintIsOperating, double value)
		{
			if (value > 180.0 || value < -180.0)
			{
				value = Math2.NormalizeLongitude(value);
			}
			if (double.IsNaN(value))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			else
			{
				this.longitude = value;
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0006D688 File Offset: 0x0006B888
		public virtual double GetLatitude(bool? _HintIsOperating = null)
		{
			return this.latitude;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0006D6A0 File Offset: 0x0006B8A0
		public virtual void SetLatitude(bool? _HintIsOperating, double value)
		{
			if (value > 90.0 || value < -90.0)
			{
				value = Math2.NormalizeLatitude(value);
			}
			if (double.IsNaN(value))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			else
			{
				this.latitude = value;
			}
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0006D6F8 File Offset: 0x0006B8F8
		public  double GetPreviousLongitude()
		{
			if (Information.IsNothing(this.PreviousLongitude))
			{
				this.PreviousLongitude = new double?(this.longitude);
			}
			return this.PreviousLongitude.Value;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0006D738 File Offset: 0x0006B938
		public virtual void SetPreviousLongitude(double value)
		{
			if (value > 180.0 || value < -180.0)
			{
				value = Math2.NormalizeLongitude(value);
			}
			if (double.IsNaN(value))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			else
			{
				this.PreviousLongitude = new double?(value);
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0006D798 File Offset: 0x0006B998
		public  double GetPreviousLatitude()
		{
			if (Information.IsNothing(this.PreviousLatitude))
			{
				this.PreviousLatitude = new double?(this.latitude);
			}
			return this.PreviousLatitude.Value;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0006D7D8 File Offset: 0x0006B9D8
		public virtual void SetPreviousLatitude(double value)
		{
			if (value > 90.0 || value < -90.0)
			{
				value = Math2.NormalizeLatitude(value);
			}
			if (double.IsNaN(value))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			else
			{
				this.PreviousLatitude = new double?(value);
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0006D838 File Offset: 0x0006BA38
		public  double? GetLongitude_UnitEntersAreaCheck()
		{
			double? longitude_UnitEntersAreaCheck;
			if (Information.IsNothing(this.Longitude_UnitEntersAreaCheck))
			{
				longitude_UnitEntersAreaCheck = this.Longitude_UnitEntersAreaCheck;
			}
			else
			{
				longitude_UnitEntersAreaCheck = new double?(this.Longitude_UnitEntersAreaCheck.Value);
			}
			return longitude_UnitEntersAreaCheck;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0006D878 File Offset: 0x0006BA78
		public virtual void SetLongitude_UnitEntersAreaCheck(double? nullable_10)
		{
			if (!nullable_10.HasValue)
			{
				this.Longitude_UnitEntersAreaCheck = null;
			}
			else
			{
				double? num = nullable_10;
				if (!(num.HasValue ? new bool?(num.GetValueOrDefault() > 180.0) : null).GetValueOrDefault())
				{
					num = nullable_10;
					if (!(num.HasValue ? new bool?(num.GetValueOrDefault() < -180.0) : null).GetValueOrDefault())
					{
						goto IL_9B;
					}
				}
				nullable_10 = new double?(Math2.NormalizeLongitude(nullable_10.Value));
				IL_9B:
				if (double.IsNaN(nullable_10.Value))
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				else
				{
					this.Longitude_UnitEntersAreaCheck = nullable_10;
				}
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0006D94C File Offset: 0x0006BB4C
		public  double? GetLatitude_UnitEntersAreaCheck()
		{
			double? result;
			if (Information.IsNothing(this.Latitude_UnitEntersAreaCheck))
			{
				result = null;
			}
			else
			{
				result = new double?(this.Latitude_UnitEntersAreaCheck.Value);
			}
			return result;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0006D990 File Offset: 0x0006BB90
		public virtual void SetLatitude_UnitEntersAreaCheck(double? nullable_10)
		{
			if (!nullable_10.HasValue)
			{
				this.Latitude_UnitEntersAreaCheck = null;
			}
			else
			{
				double? num = nullable_10;
				if (!(num.HasValue ? new bool?(num.GetValueOrDefault() > 90.0) : null).GetValueOrDefault())
				{
					num = nullable_10;
					if (!(num.HasValue ? new bool?(num.GetValueOrDefault() < -90.0) : null).GetValueOrDefault())
					{
						goto IL_9B;
					}
				}
				nullable_10 = new double?(Math2.NormalizeLatitude(nullable_10.Value));
				IL_9B:
				if (double.IsNaN(nullable_10.Value))
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				else
				{
					this.Latitude_UnitEntersAreaCheck = nullable_10;
				}
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0006DA64 File Offset: 0x0006BC64
		public float GetPreviousAltitude_ASL()
		{
			if (!this.PreviousAltitude_ASL.HasValue)
			{
				this.PreviousAltitude_ASL = new float?(this.GetCurrentAltitude_ASL(false));
			}
			return this.PreviousAltitude_ASL.Value;
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x000093CC File Offset: 0x000075CC
		public void SetPreviousAltitude_ASL(float value)
		{
			this.PreviousAltitude_ASL = new float?(value);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0006DAA0 File Offset: 0x0006BCA0
		public float GetHorizontalSpeed()
		{
			float result;
			if (this.IsOfAirLaunchedGuidedWeapon())
			{
				result = (float)(Math2.Cos_D((double)this.GetPitch()) * (double)this.GetCurrentSpeed());
			}
			else
			{
				result = this.GetCurrentSpeed();
			}
			return result;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0006DAE0 File Offset: 0x0006BCE0
		public virtual float GetCurrentSpeed()
		{
			return this.currentSpeed;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000093DA File Offset: 0x000075DA
		public virtual void SetCurrentSpeed(float value)
		{
			if (float.IsNaN(value) || float.IsInfinity(value))
			{
				value = 0f;
			}
			this.currentSpeed = value;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00009400 File Offset: 0x00007600
		public bool IsAirBase()
		{
			return !this.IsGroup && this.IsFacility && ((Facility)this).Category == Facility._FacilityCategory.AirBase;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0006DAF8 File Offset: 0x0006BCF8
		public float HorizontalRangeTo(GeoPoint point)
		{
			return Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), point.GetLatitude(), point.GetLongitude());
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0006DB38 File Offset: 0x0006BD38
		public float HorizontalRangeTo(double lat, double lon)
		{
			return Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), lat, lon);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0006DB6C File Offset: 0x0006BD6C
		public float SlantRangeTo(GeoPoint geoPoint_)
		{
			float distance = Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), geoPoint_.GetLatitude(), geoPoint_.GetLongitude());
			float num = (float)((double)Math.Abs(this.GetCurrentAltitude_ASL(false) - geoPoint_.GetAltitude()) / 1852.0);
			return (float)Math.Sqrt((double)(distance * distance + num * num));
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0006DBDC File Offset: 0x0006BDDC
		public double GetApproxAngularDistanceInDegrees(GeoPoint geoPoint_0)
		{
			Angle latA = default(Angle);
			Angle lonA = default(Angle);
			Angle latB = default(Angle);
			Angle lonB = default(Angle);
			latA.SetDegrees(this.GetLatitude(null));
			lonA.SetDegrees(this.GetLongitude(null));
			latB.SetDegrees(geoPoint_0.GetLatitude());
			lonB.SetDegrees(geoPoint_0.GetLongitude());
			return World.ApproxAngularDistance(latA, lonA, latB, lonB).GetDegrees();
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0006DC68 File Offset: 0x0006BE68
		public double GetApproxAngularDistanceInDegrees(ref double lat_, ref double lon_)
		{
			Angle latA = default(Angle);
			Angle lonA = default(Angle);
			Angle latB = default(Angle);
			Angle lonB = default(Angle);
			latA.SetDegrees(this.GetLatitude(null));
			lonA.SetDegrees(this.GetLongitude(null));
			latB.SetDegrees(lat_);
			lonB.SetDegrees(lon_);
			return World.ApproxAngularDistance(latA, lonA, latB, lonB).GetDegrees();
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0006DCEC File Offset: 0x0006BEEC
		public double GetApproxAngularDistanceInDegrees(Unit unit_0)
		{
			Angle latA = default(Angle);
			Angle lonA = default(Angle);
			Angle latB = default(Angle);
			Angle lonB = default(Angle);
			latA.SetDegrees(this.GetLatitude(null));
			lonA.SetDegrees(this.GetLongitude(null));
			latB.SetDegrees(unit_0.GetLatitude(null));
			lonB.SetDegrees(unit_0.GetLongitude(null));
			return World.ApproxAngularDistance(latA, lonA, latB, lonB).GetDegrees();
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0006DD8C File Offset: 0x0006BF8C
		public float AzimuthTo(Unit unit_)
		{
			return Math2.GetAzimuth(this.GetLatitude(null), this.GetLongitude(null), unit_.GetLatitude(null), unit_.GetLongitude(null));
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0006DDDC File Offset: 0x0006BFDC
		public float RelativeBearingTo(Unit unit_0)
		{
			float azimuth = Math2.GetAzimuth(this.GetLatitude(null), this.GetLongitude(null), unit_0.GetLatitude(null), unit_0.GetLongitude(null));
			return Math2.Normalize(Class263.RelativeBearingTo(this.GetCurrentHeading(), azimuth));
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0006DE40 File Offset: 0x0006C040
		public float AzimuthTo(double lat, double lon)
		{
			return Math2.GetAzimuth(this.GetLatitude(null), this.GetLongitude(null), lat, lon);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0006DE74 File Offset: 0x0006C074
		public float GetHorizontalRange(Unit unit_0)
		{
			float result;
			if (Information.IsNothing(unit_0))
			{
				result = 3.40282347E+38f;
			}
			else
			{
				result = Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), unit_0.GetLatitude(null), unit_0.GetLongitude(null));
			}
			return result;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0006DEE0 File Offset: 0x0006C0E0
		public float GetSlantRange(Unit theTarget, float HorizRangeProvided = 0f)
		{
			float result;
			if (Information.IsNothing(theTarget))
			{
				result = 3.40282347E+38f;
			}
			else
			{
				float num;
				if (HorizRangeProvided == 0f)
				{
					num = this.GetHorizontalRange(theTarget);
				}
				else
				{
					num = HorizRangeProvided;
				}
				float num2 = (float)((double)Math.Abs(this.GetCurrentAltitude_ASL(false) - theTarget.GetCurrentAltitude_ASL(false)) * 0.000539957);
				if (num2 == 0f)
				{
					result = num;
				}
				else
				{
					result = (float)Math.Sqrt((double)(num * num + num2 * num2));
				}
			}
			return result;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0006DF6C File Offset: 0x0006C16C
		public float GetDesiredSpeed(double targetLat, double targetLon, float targetHeading, float targetSpeed, float parentSpeed, float parentHeading)
		{
			float result = 0f;
			try
			{
				if (targetSpeed == 0f && Math.Abs(Math.Round((double)Class263.RelativeBearingTo(this.AzimuthTo(targetLat, targetLon), parentHeading), 1)) <= 0.1)
				{
					result = parentSpeed;
				}
				else if (RangeCalculator.GetRange(this.GetLatitude(null), this.GetLongitude(null), targetLat, targetLon) < 50.0)
				{
					result = (float)Class258.smethod_1(this.GetLatitude(null), this.GetLongitude(null), (double)parentSpeed, (double)parentHeading, targetLat, targetLon, (double)targetSpeed, (double)targetHeading);
				}
				else
				{
					float num = parentSpeed / 3600f;
					double lon = 0.0;
					double lat = 0.0;
					GeoPointGenerator.GetOtherGeoPoint(this.GetLongitude(null), this.GetLatitude(null), ref lon, ref lat, (double)num, (double)parentHeading);
					num = targetSpeed / 3600f;
					double lat2 = 0.0;
					double lon2 = 0.0;
					GeoPointGenerator.GetOtherGeoPoint(targetLon, targetLat, ref lon2, ref lat2, (double)num, (double)targetHeading);
					float distance = Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), targetLat, targetLon);
					float distance2 = Math2.GetDistance(lat, lon, lat2, lon2);
					result = (distance - distance2) * 3600f;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200045", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0006E14C File Offset: 0x0006C34C
		public float GetDesiredSpeed(Unit theTargetUnit, float Speed, float Heading)
		{
			return this.GetDesiredSpeed(theTargetUnit.GetLatitude(null), theTargetUnit.GetLongitude(null), theTargetUnit.GetCurrentHeading(), theTargetUnit.GetCurrentSpeed(), Speed, Heading);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0006E190 File Offset: 0x0006C390
		public float GetAntennaAltitude_ASL(Unit unit_)
		{
			float result = 0f;
			try
			{
				if (unit_.IsSubmarine)
				{
					if (((Submarine)unit_).IsAtPeriscopeDepth())
					{
						result = 2f;
					}
					else if (((Submarine)unit_).IsShallowerThanPeriscopeDepth())
					{
						result = 8f;
					}
					else
					{
						result = 0f;
					}
				}
				else if (!unit_.IsShip && !unit_.IsFacility)
				{
					result = unit_.GetCurrentAltitude_ASL(false);
				}
				else if (unit_.GetCurrentAltitude_ASL(false) < 0f)
				{
					result = 0f;
				}
				else
				{
					result = unit_.GetCurrentAltitude_ASL(false) + (float)unit_.GetMastHeight();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100868", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0006E284 File Offset: 0x0006C484
		public float GetAntennaHeight(Unit unit_0)
		{
			float result;
			if (unit_0.IsSubmarine)
			{
				if (unit_0.GetCurrentAltitude_ASL(false) < -20f)
				{
					result = 0f;
				}
				else if (unit_0.GetCurrentAltitude_ASL(false) == -20f)
				{
					result = 2f;
				}
				else
				{
					result = 2f + ((float)Math.Abs(-20) - Math.Abs(unit_0.GetCurrentAltitude_ASL(false)));
				}
			}
			else if (!this.IsShip && !this.IsFacility)
			{
				result = this.GetCurrentAltitude_ASL(false);
			}
			else if (this.GetCurrentAltitude_ASL(false) < 0f)
			{
				result = 0f;
			}
			else
			{
				result = this.GetCurrentAltitude_ASL(false) + (float)this.GetMastHeight();
			}
			return result;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0006E344 File Offset: 0x0006C544
		public bool IsLOS_Exists_Radar(Unit theUnit, ref Scenario theScen, bool IgnoreRadarHorizon = false)
		{
			bool result = false;
			try
			{
				if (((this.IsAircraft || base.IsGuidedWeapon_RV_HGV()) | base.IsSatellite()) && (theUnit.IsShip || theUnit.IsFacility || theUnit.IsSubmarine))
				{
					result = theUnit.IsLOS_Exists_Radar(this, ref theScen, IgnoreRadarHorizon);
				}
				else if (!IgnoreRadarHorizon && Class363.smethod_1(this, theUnit) < Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), theUnit.GetLatitude(null), theUnit.GetLongitude(null)))
				{
					result = false;
				}
				else
				{
					float antennaAltitude_ASL = this.GetAntennaAltitude_ASL(theUnit);
					float antennaHeight = this.GetAntennaHeight(this);
					if (this.IsSubmarine && this.GetCurrentAltitude_ASL(false) < -20f && theUnit.GetCurrentAltitude_ASL(false) > 0f)
					{
						result = false;
					}
					else
					{
						bool flag = false;
						try
						{
							Scenario scenario = theScen;
							Unit unit = this;
							bool? hintIsOperating = null;
							double value = this.GetLatitude(hintIsOperating);
							bool? hintIsOperating2 = null;
							double value2 = this.GetLongitude(hintIsOperating2);
							Unit unit3;
							Unit unit2 = unit3 = theUnit;
							bool? hintIsOperating3 = null;
							double value3 = unit3.GetLatitude(hintIsOperating3);
							Unit unit5;
							Unit unit4 = unit5 = theUnit;
							bool? hintIsOperating4 = null;
							double value4 = unit5.GetLongitude(hintIsOperating4);
							bool flag2 = scenario.IsLOSExistedBetweenTwoUnits(ref theScen, ref unit, ref value, ref value2, ref antennaHeight, ref theUnit, ref value3, ref value4, ref antennaAltitude_ASL, true, false, 0, IgnoreRadarHorizon);
							unit4.SetLongitude(hintIsOperating4, value4);
							unit2.SetLatitude(hintIsOperating3, value3);
							this.SetLongitude(hintIsOperating2, value2);
							this.SetLatitude(hintIsOperating, value);
							flag = flag2;
						}
						catch (OutOfMemoryException projectError)
						{
							ProjectData.SetProjectError(projectError);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							GameGeneral.ForceGarbageCollection();
							Scenario scenario = theScen;
							Unit unit4 = this;
							bool? hintIsOperating4 = null;
							double value4 = this.GetLatitude(hintIsOperating4);
							bool? hintIsOperating3 = null;
							double value3 = this.GetLongitude(hintIsOperating3);
							Unit unit6;
							Unit unit2 = unit6 = theUnit;
							bool? hintIsOperating2 = null;
							double value2 = unit6.GetLatitude(hintIsOperating2);
							Unit unit7;
							Unit unit = unit7 = theUnit;
							bool? hintIsOperating = null;
							double value = unit7.GetLongitude(hintIsOperating);
							bool flag3 = scenario.IsLOSExistedBetweenTwoUnits(ref theScen, ref unit4, ref value4, ref value3, ref antennaHeight, ref theUnit, ref value2, ref value, ref antennaAltitude_ASL, true, false, 0, IgnoreRadarHorizon);
							unit.SetLongitude(hintIsOperating, value);
							unit2.SetLatitude(hintIsOperating2, value2);
							this.SetLongitude(hintIsOperating3, value3);
							this.SetLatitude(hintIsOperating4, value4);
							flag = flag3;
							ProjectData.ClearProjectError();
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 101175", "");
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
						result = flag;
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100869", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0006E690 File Offset: 0x0006C890
		public Unit._LOS_Exists_Visual IsLOS_Exists_Visual(Unit Target, ref Scenario scenario_, bool bool_8)
		{
			Unit._LOS_Exists_Visual result = Unit._LOS_Exists_Visual.Unknown;
			try
			{
				if (this.IsSubmarine && this.GetCurrentAltitude_ASL(false) < -20f && Target.GetCurrentAltitude_ASL(false) > 0f)
				{
					result = Unit._LOS_Exists_Visual.CannotLookThroughWater;
				}
				else
				{
					float num = 0f;
					if (Target.IsSubmarine)
					{
						if (((Submarine)Target).IsAtPeriscopeDepth())
						{
							num = 2f;
						}
						else if (((Submarine)Target).IsShallowerThanPeriscopeDepth())
						{
							num = 8f;
						}
					}
					else if (!Target.IsShip && !Target.IsFacility)
					{
						num = Target.GetCurrentAltitude_ASL(false);
					}
					else
					{
						num = Target.GetCurrentAltitude_ASL(false) + (float)Target.GetTargetVisualSize();
					}
					float num2 = 0f;
					if (!this.IsShip && !this.IsFacility)
					{
						if (this.IsWeapon && ((Weapon)this).GetWeaponType() == Weapon._WeaponType.Sonobuoy && !Target.IsSubmarine)
						{
							num2 = 1f;
						}
						else if (this.IsSubmarine && this.GetCurrentAltitude_ASL(false) <= -20f)
						{
							num2 = (float)(Math.Abs(-20) + 2) + this.GetCurrentAltitude_ASL(false);
						}
						else
						{
							num2 = this.GetCurrentAltitude_ASL(false);
						}
					}
					else
					{
						num2 = this.GetCurrentAltitude_ASL(false) + (float)this.GetTargetVisualSize();
					}
					bool flag = true;
					bool flag2 = num2 < 0f;
					bool flag3 = num < 0f;
					if (flag2 && num > 0f)
					{
						result = Unit._LOS_Exists_Visual.CannotLookThroughWater;
					}
					else if (this.GetCurrentAltitude_ASL(false) > 0f && flag3)
					{
						result = Unit._LOS_Exists_Visual.CannotLookThroughWater;
					}
					else
					{
						if (flag2 && num == 0f)
						{
							flag = false;
						}
						if (this.GetCurrentAltitude_ASL(false) == 0f && flag3)
						{
							flag = false;
						}
						if (flag2 && flag3)
						{
							flag = false;
						}
						if (flag && Class363.smethod_4(num2, num) < Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), Target.GetLatitude(null), Target.GetLongitude(null)))
						{
							result = Unit._LOS_Exists_Visual.const_2;
						}
						else if (bool_8 && !Weather.CanLookThroughCloud(this, Target, ref scenario_))
						{
							result = Unit._LOS_Exists_Visual.CannotLookThroughCloud;
						}
						else if (base.IsSatellite())
						{
							result = Unit._LOS_Exists_Visual.Yes;
						}
						else if (Target.IsSatellite())
						{
							result = Target.IsLOS_Exists_Visual(this, ref scenario_, bool_8);
						}
						else
						{
							bool flag4 = false;
							try
							{
								Scenario scenario = scenario_;
								Unit unit = this;
								bool? hintIsOperating = null;
								double value = this.GetLatitude(hintIsOperating);
								bool? hintIsOperating2 = null;
								double value2 = this.GetLongitude(hintIsOperating2);
								Unit unit3;
								Unit unit2 = unit3 = Target;
								bool? hintIsOperating3 = null;
								double value3 = unit3.GetLatitude(hintIsOperating3);
								Unit unit5;
								Unit unit4 = unit5 = Target;
								bool? hintIsOperating4 = null;
								double value4 = unit5.GetLongitude(hintIsOperating4);
								bool flag5 = scenario.IsLOSExistedBetweenTwoUnits(ref scenario_, ref unit, ref value, ref value2, ref num2, ref Target, ref value3, ref value4, ref num, true, false, 0, false);
								unit4.SetLongitude(hintIsOperating4, value4);
								unit2.SetLatitude(hintIsOperating3, value3);
								this.SetLongitude(hintIsOperating2, value2);
								this.SetLatitude(hintIsOperating, value);
								flag4 = flag5;
							}
							catch (OutOfMemoryException projectError)
							{
								ProjectData.SetProjectError(projectError);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								GameGeneral.ForceGarbageCollection();
								Scenario scenario = scenario_;
								Unit unit4 = this;
								bool? hintIsOperating4 = null;
								double value4 = this.GetLatitude(hintIsOperating4);
								bool? hintIsOperating3 = null;
								double value3 = this.GetLongitude(hintIsOperating3);
								Unit unit6;
								Unit unit2 = unit6 = Target;
								bool? hintIsOperating2 = null;
								double value2 = unit6.GetLatitude(hintIsOperating2);
								Unit unit7;
								Unit unit = unit7 = Target;
								bool? hintIsOperating = null;
								double value = unit7.GetLongitude(hintIsOperating);
								bool flag6 = scenario.IsLOSExistedBetweenTwoUnits(ref scenario_, ref unit4, ref value4, ref value3, ref num2, ref Target, ref value2, ref value, ref num, true, false, 0, false);
								unit.SetLongitude(hintIsOperating, value);
								unit2.SetLatitude(hintIsOperating2, value2);
								this.SetLongitude(hintIsOperating3, value3);
								this.SetLatitude(hintIsOperating4, value4);
								flag4 = flag6;
								ProjectData.ClearProjectError();
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ex2.Data.Add("Error at 101176", "");
								GameGeneral.LogException(ref ex2);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								ProjectData.ClearProjectError();
							}
							if (flag4)
							{
								result = Unit._LOS_Exists_Visual.Yes;
							}
							else
							{
								result = Unit._LOS_Exists_Visual.No;
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100870", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Unit._LOS_Exists_Visual.CannotLookThroughWater;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0006EB74 File Offset: 0x0006CD74
		public bool IsLOS_Exists_Sonar(Unit theUnit, ref Scenario theScen, ref bool LandmassCheckIsNeeded, float? ExplicitSensorDepth = null)
		{
			bool result = false;
			try
			{
				float num = 0f;
				if (ExplicitSensorDepth.HasValue)
				{
					num = ExplicitSensorDepth.Value;
				}
				else
				{
					num = this.GetCurrentAltitude_ASL(false);
				}
				if (num <= 0f && theUnit.GetCurrentAltitude_ASL(false) <= 0f)
				{
					float num2 = theUnit.GetCurrentAltitude_ASL(false);
					bool flag = false;
					try
					{
						Scenario scenario = theScen;
						Unit unit = this;
						bool? hintIsOperating = null;
						double value = this.GetLatitude(hintIsOperating);
						bool? hintIsOperating2 = null;
						double value2 = this.GetLongitude(hintIsOperating2);
						Unit unit3;
						Unit unit2 = unit3 = theUnit;
						bool? hintIsOperating3 = null;
						double value3 = unit3.GetLatitude(hintIsOperating3);
						Unit unit5;
						Unit unit4 = unit5 = theUnit;
						bool? hintIsOperating4 = null;
						double value4 = unit5.GetLongitude(hintIsOperating4);
						bool flag2 = scenario.IsLOSExistedBetweenTwoUnits(ref theScen, ref unit, ref value, ref value2, ref num, ref theUnit, ref value3, ref value4, ref num2, true, LandmassCheckIsNeeded, 0, false);
						unit4.SetLongitude(hintIsOperating4, value4);
						unit2.SetLatitude(hintIsOperating3, value3);
						this.SetLongitude(hintIsOperating2, value2);
						this.SetLatitude(hintIsOperating, value);
						flag = flag2;
					}
					catch (OutOfMemoryException projectError)
					{
						ProjectData.SetProjectError(projectError);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						GameGeneral.ForceGarbageCollection();
						Scenario scenario2 = theScen;
						Unit unit4 = this;
						bool? hintIsOperating4 = null;
						double value4 = this.GetLatitude(hintIsOperating4);
						bool? hintIsOperating3 = null;
						double value3 = this.GetLongitude(hintIsOperating3);
						Unit unit6;
						Unit unit2 = unit6 = theUnit;
						bool? hintIsOperating2 = null;
						double value2 = unit6.GetLatitude(hintIsOperating2);
						Unit unit7;
						Unit unit = unit7 = theUnit;
						bool? hintIsOperating = null;
						double value = unit7.GetLongitude(hintIsOperating);
						bool flag3 = scenario2.IsLOSExistedBetweenTwoUnits(ref theScen, ref unit4, ref value4, ref value3, ref num, ref theUnit, ref value2, ref value, ref num2, true, LandmassCheckIsNeeded, 0, false);
						unit.SetLongitude(hintIsOperating, value);
						unit2.SetLatitude(hintIsOperating2, value2);
						this.SetLongitude(hintIsOperating3, value3);
						this.SetLatitude(hintIsOperating4, value4);
						flag = flag3;
						ProjectData.ClearProjectError();
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 101178", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
					result = flag;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100871", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0006EE24 File Offset: 0x0006D024
		public virtual void SetGeoLocation(ref Scenario scenario_, double Longitude_, double Latitude_)
		{
			this.SetLongitude(null, Longitude_);
			this.SetLatitude(null, Latitude_);
			if (this.IsActiveUnit())
			{
				ActiveUnit activeUnit = (ActiveUnit)this;
				activeUnit.GetNavigator().short_0 = 0;
				activeUnit.GetNavigator().short_1 = 0;
				activeUnit.GetNavigator().short_2 = 0;
				activeUnit.GetNavigator().short_3 = 0;
				activeUnit.GetNavigator().short_4 = 0;
				activeUnit.GetNavigator().short_5 = 0;
				activeUnit.GetNavigator().short_6 = 0;
				activeUnit.GetNavigator().short_7 = 0;
				activeUnit.GetNavigator().TimeToCheckNoNavZoneViolation = 0;
			}
			checked
			{
				if (this.IsActiveUnit() && this.IsAircraft)
				{
					Aircraft aircraft = (Aircraft)this;
					if (!Information.IsNothing(aircraft.GetLoadout()))
					{
						WeaponRec[] weaponRecArray = aircraft.GetLoadout().WeaponRecArray;
						for (int i = 0; i < weaponRecArray.Length; i++)
						{
							Weapon weapon = weaponRecArray[i].GetWeapon(aircraft.m_Scenario);
							weapon.SetLongitude(null, aircraft.GetLongitude(null));
							weapon.SetLatitude(null, aircraft.GetLatitude(null));
							weapon.SetAltitude_ASL(false, aircraft.GetCurrentAltitude_ASL(false));
							weapon.SetCurrentHeading(aircraft.GetCurrentHeading());
							weapon.SetCurrentSpeed(aircraft.GetCurrentSpeed());
						}
					}
				}
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00009427 File Offset: 0x00007627
		public virtual bool IsPlatform()
		{
			return base.GetType().BaseType == typeof(Platform) || base.GetType() == typeof(Platform);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0006EF9C File Offset: 0x0006D19C
		public virtual bool vmethod_39(List<GeoPoint> list_1, Scenario scenario_0, bool bool_8)
		{
			bool result = false;
			try
			{
				if (Information.IsNothing(list_1))
				{
					result = false;
				}
				else if (list_1.Count < 3)
				{
					result = false;
				}
				else
				{
					bool flag;
					if (bool_8 && (this.IsActiveUnit() || this.IsContact()))
					{
						int hashCode = list_1.GetHashCode();
						if (this.lazy_1.Value.ContainsKey(hashCode))
						{
							flag = this.lazy_1.Value[hashCode];
						}
						else
						{
							flag = new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)).method_21(ref list_1, true);
							if (!this.lazy_1.Value.ContainsKey(hashCode))
							{
								this.lazy_1.Value.TryAdd(hashCode, flag);
							}
						}
					}
					else
					{
						flag = new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)).method_21(ref list_1, true);
					}
					result = flag;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100873", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0006F10C File Offset: 0x0006D30C
		public virtual bool vmethod_40(List<ReferencePoint> theArea, Scenario scenario, bool bool_8)
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
				else
				{
					bool flag = false;
					if (bool_8 && (this.IsActiveUnit() || this.IsContact()))
					{
						int hashCode = theArea.GetHashCode();
						if (this.lazy_1.Value.ContainsKey(hashCode))
						{
							try
							{
								flag = this.lazy_1.Value[hashCode];
								goto IL_168;
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								flag = new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)).method_22(ref theArea, true);
								if (!this.lazy_1.Value.ContainsKey(hashCode))
								{
									this.lazy_1.Value.TryAdd(hashCode, flag);
								}
								ProjectData.ClearProjectError();
								goto IL_168;
							}
						}
						flag = new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)).method_22(ref theArea, true);
						if (!this.lazy_1.Value.ContainsKey(hashCode))
						{
							this.lazy_1.Value.TryAdd(hashCode, flag);
						}
					}
					else
					{
						flag = new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)).method_22(ref theArea, true);
					}
					IL_168:
					result = flag;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100873", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0006F2FC File Offset: 0x0006D4FC
		public float RelativeBearingTo(Unit unit_0, bool bool_8)
		{
			float num = unit_0.currentHeading;
			float num2 = Math2.GetAzimuth(unit_0.GetLatitude(null), unit_0.GetLongitude(null), this.GetLatitude(null), this.GetLongitude(null));
			num2 = Math2.Normalize(num2 - num);
			float result;
			if (bool_8 && num2 > 180f)
			{
				result = -(360f - num2);
			}
			else
			{
				result = num2;
			}
			return result;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0000945D File Offset: 0x0000765D
		public virtual bool vmethod_41(double Lat_, double Lon_, ref byte byte_0, bool bool_8, ref bool bool_9, bool bool_10, ref bool bool_11, float? nullable_10, short? nullable_11, ref List<ActiveUnit> list_1, float float_7, bool bool_12, bool bool_13)
		{
			return true;
		}

		// 在一个时间段内的移动距离
		public float GetMoveDistance(float elapsedTime)
		{
			float result;
			if (this.IsOfAirLaunchedGuidedWeapon())
			{
				result = (float)(Math2.Cos_D((double)this.GetPitch()) * (double)(this.GetCurrentSpeed() / 3600f)) * elapsedTime;
			}
			else
			{
				result = this.GetCurrentSpeed() / 3600f * elapsedTime;
			}
			return result;
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0006F3D8 File Offset: 0x0006D5D8
		public void Move(float elapsedTime, bool bNotExportUnitPositions)
		{
			if (this.GetCurrentSpeed() != 0f)
			{
				this.SetPreviousLongitude(this.GetLongitude(null));
				this.SetPreviousLatitude(this.GetLatitude(null));
				try
				{
					float num;
					if (this.IsActiveUnit())
					{
						num = ((ActiveUnit)this).GetKinematics().GetHorizontalDistanceMoved(elapsedTime);
					}
					else
					{
						num = this.GetMoveDistance(elapsedTime);
					}
					double num2 = 0.0;
					double num3 = 0.0;
					if (bNotExportUnitPositions | !this.IsActiveUnit())
					{
						GeoPointGenerator.GetOtherGeoPoint(this.GetPreviousLongitude(), this.GetPreviousLatitude(), ref num2, ref num3, (double)num, (double)this.GetCurrentHeading());
					}
					else
					{
						Math2.GetAnotherGeopoint(this.GetPreviousLongitude(), this.GetPreviousLatitude(), ref num2, ref num3, num, this.GetCurrentHeading());
					}
					if (double.IsNaN(num3))
					{
						num3 = this.GetPreviousLatitude();
					}
					if (double.IsNaN(num2))
					{
						num2 = this.GetPreviousLongitude();
					}
					if (this.IsPlatform())
					{
						bool flag = false;
						bool flag2 = true;
						double lat_ = num3;
						double lon_ = num2;
						byte b = 0;
						List<ActiveUnit> list = null;
						if (this.vmethod_41(lat_, lon_, ref b, false, ref flag2, true, ref flag, null, null, ref list, 0f, false, true))
						{
							this.SetLatitude(null, num3);
							this.SetLongitude(null, num2);
						}
						else if (!flag && !flag2)
						{
							this.SetCurrentHeading(this.method_48(this.currentHeading, num, false));
							Math2.GetAnotherGeopoint(this.GetLongitude(null), this.GetLatitude(null), ref num2, ref num3, num, this.GetCurrentHeading());
							ActiveUnit activeUnit = (ActiveUnit)this;
							if (activeUnit.m_Scenario.MinuteIsChangingOnThisPulse)
							{
								double lat_2 = num3;
								double lon_2 = num2;
								b = 0;
								bool flag3 = false;
								double num4 = 0.0;
								double num5 = 0.0;
								if (!this.vmethod_41(lat_2, lon_2, ref b, false, ref flag3, true, ref flag, null, null, ref list, 0f, false, false) && activeUnit.GetNavigator().method_7(num3, num2, ref num4, ref num5, 0f, ref list, false))
								{
									num3 = num4;
									num2 = num5;
									if (activeUnit.GetNavigator().NextUpdateTime > 2f)
									{
										activeUnit.GetNavigator().NextUpdateTime = 2f;
									}
								}
							}
						}
						else
						{
							ActiveUnit activeUnit2 = (ActiveUnit)this;
							if (activeUnit2.m_Scenario.MinuteIsChangingOnThisPulse)
							{
								double lat = 0.0;
								double lon = 0.0;
								if (activeUnit2.GetNavigator().method_7(num3, num2, ref lat, ref lon, 0f, ref list, false))
								{
									activeUnit2.GetNavigator().float_2 = Math2.GetAzimuth(this.GetLatitude(null), this.GetLongitude(null), lat, lon);
									activeUnit2.SetCurrentHeading(activeUnit2.GetNavigator().float_2);
									if (activeUnit2.GetNavigator().NextUpdateTime > 2f)
									{
										activeUnit2.GetNavigator().NextUpdateTime = 2f;
									}
								}
							}
							else
							{
								activeUnit2.SetCurrentHeading(activeUnit2.GetNavigator().float_2);
							}
							this.SetLatitude(null, num3);
							this.SetLongitude(null, num2);
						}
					}
					this.SetLatitude(null, num3);
					this.SetLongitude(null, num2);
					if (double.IsNaN(this.GetLatitude(null)))
					{
						this.SetLatitude(null, this.GetPreviousLatitude());
					}
					if (double.IsNaN(this.GetLongitude(null)))
					{
						this.SetLongitude(null, this.GetPreviousLongitude());
					}
					if (!bNotExportUnitPositions)
					{
						if (this.GetPreviousLongitude() != this.GetLongitude(null) || this.GetPreviousLatitude() != this.GetLatitude(null))
						{
							this.Altitude_AGL = null;
							this.Elevation = null;
						}
						if (this.GetLongitude(elapsedTime) != this.GetLongitude(null) || this.GetLatitude(elapsedTime) != this.GetLatitude(null))
						{
							this.Altitude_ASL = null;
							this.Longitude = null;
							this.Latitude = null;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100875", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0006F8E4 File Offset: 0x0006DAE4
		public void RecordPreviousLocation()
		{
			if (this.GetPreviousLongitude() != this.GetLongitude(null) || this.GetPreviousLatitude() != this.GetLatitude(null))
			{
				this.ClearAltitudeData();
			}
			this.SetPreviousLongitude(this.GetLongitude(null));
			this.SetPreviousLatitude(this.GetLatitude(null));
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00009460 File Offset: 0x00007660
		public void ClearAltitudeData()
		{
			this.Altitude_AGL = null;
			this.Elevation = null;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0006F954 File Offset: 0x0006DB54
		public float method_48(float currentHeading_, float distance_, bool bool_8)
		{
			float num = 0f;
			float result;
			try
			{
				int num2 = 3;
				float num3;
				while (true)
				{
					num3 = Math2.Normalize(currentHeading_ + (float)num2);
					double num4 = 0.0;
					double num5 = 0.0;
					Math2.GetAnotherGeopoint(this.GetLongitude(null), this.GetLatitude(null), ref num4, ref num5, distance_, num3);
					double lat_ = num5;
					double lon_ = num4;
					byte b = 0;
					bool flag = true;
					bool flag2 = true;
					List<ActiveUnit> list = null;
					if (this.vmethod_41(lat_, lon_, ref b, bool_8, ref flag, true, ref flag2, null, null, ref list, 0f, false, false))
					{
						break;
					}
					num3 = Math2.Normalize(currentHeading_ - (float)num2);
					Math2.GetAnotherGeopoint(this.GetLongitude(null), this.GetLatitude(null), ref num4, ref num5, distance_, num3);
					double lat_2 = num5;
					double lon_2 = num4;
					b = 0;
					flag2 = true;
					flag = true;
					if (this.vmethod_41(lat_2, lon_2, ref b, bool_8, ref flag2, true, ref flag, null, null, ref list, 0f, false, false))
					{
						goto IL_140;
					}
					num2 += 3;
					if (num2 > 177)
					{
						goto IL_146;
					}
				}
				num = num3;
				result = num;
				return result;
				IL_140:
				num = num3;
				result = num;
				return result;
				IL_146:
				num = currentHeading_;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100876", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = currentHeading_;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0006FB0C File Offset: 0x0006DD0C
		public float method_49(float float_7, float float_8)
		{
			float result;
			if (float_7 <= 0f)
			{
				result = 3.40282347E+38f;
			}
			else
			{
				result = (float)Math.Round((double)(float_8 / (float_7 / 3600f)), 2);
			}
			return result;
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x0006FB48 File Offset: 0x0006DD48
		public float GetEstimatedTimeOfArrivalToTarget(Unit targetUnit_)
		{
			float horizontalRange = this.GetHorizontalRange(targetUnit_);
			float desiredSpeed = this.GetDesiredSpeed(targetUnit_, this.GetCurrentSpeed(), this.GetCurrentHeading());
			return horizontalRange / desiredSpeed * 3600f;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0006FB7C File Offset: 0x0006DD7C
		public string GetStarboardOrPort(Unit unit_)
		{
			float azimuth = Math2.GetAzimuth(this.GetLatitude(null), this.GetLongitude(null), unit_.GetLatitude(null), unit_.GetLongitude(null));
			string result;
			if (Math2.Normalize(this.GetCurrentHeading() - azimuth) > 180f)
			{
				result = "Starboard";
			}
			else
			{
				result = "Port";
			}
			return result;
		}

		// 朝向
		private float currentHeading;

		// 当前速度
		private float currentSpeed;

		// Token: 0x04000410 RID: 1040
		private float currentAltitude_ASL;

		// Token: 0x04000411 RID: 1041
		protected float Pitch;

		// Token: 0x04000412 RID: 1042
		private float Roll;

		// Token: 0x04000413 RID: 1043
		protected float float_5;

		// Token: 0x04000414 RID: 1044
		public float float_6;

		// Token: 0x04000415 RID: 1045
		protected double latitude;

		// Token: 0x04000416 RID: 1046
		protected double longitude;

		// Token: 0x04000417 RID: 1047
		private double? PreviousLongitude;

		// 上一次纬度
		private double? PreviousLatitude;

		// Token: 0x04000419 RID: 1049
		private float? PreviousAltitude_ASL;

		// Token: 0x0400041A RID: 1050
		private double? Longitude;

		// Token: 0x0400041B RID: 1051
		private double? Latitude;

		// Token: 0x0400041C RID: 1052
		private double? Longitude_UnitEntersAreaCheck;

		// Token: 0x0400041D RID: 1053
		private double? Latitude_UnitEntersAreaCheck;

		// Token: 0x0400041E RID: 1054
		public string UnitClass;

		// Token: 0x0400041F RID: 1055
		private List<RangeSymbol> rangeSymbols;

		// 所属方
		protected Side m_Side;

		// Token: 0x04000421 RID: 1057
		public string Message;

		// Token: 0x04000422 RID: 1058
		public Lazy<ConcurrentDictionary<int, bool>> lazy_1;

		// Token: 0x04000423 RID: 1059
		private int? Elevation;

		// Token: 0x04000424 RID: 1060
		private int? Altitude_ASL;

		// Token: 0x04000425 RID: 1061
		private float? Altitude_AGL;

		// Token: 通视性
		public enum _LOS_Exists_Visual
		{
			// Token: 0x04000427 RID: 1063
			Unknown,
			// Token: 0x04000428 RID: 1064
			Yes,
			// Token: 0x04000429 RID: 1065
			const_2,
			// Token: 0x0400042A RID: 1066
			No,
			// Token: 0x0400042B RID: 1067
			CannotLookThroughCloud,
			// Token: 0x0400042C RID: 1068
			CannotLookThroughWater = 9999
		}
	}
}
