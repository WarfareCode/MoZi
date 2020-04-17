using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace Command
{
	// Token: 0x02000799 RID: 1945
	[Attribute0, Attribute2, Attribute3]
	public sealed class AircraftFuelViewModel : INotifyPropertyChanged
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06003031 RID: 12337 RVA: 0x00109C48 File Offset: 0x00107E48
		// (remove) Token: 0x06003032 RID: 12338 RVA: 0x00109C84 File Offset: 0x00107E84
		public event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06003033 RID: 12339 RVA: 0x00109CC0 File Offset: 0x00107EC0
		// (set) Token: 0x06003034 RID: 12340 RVA: 0x00019E7C File Offset: 0x0001807C
		public double Percentage
		{
			[CompilerGenerated]
			get
			{
				return this.double_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_0 != value)
				{
					this.double_0 = value;
					this.vmethod_0("Percentage");
				}
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06003035 RID: 12341 RVA: 0x00109CD8 File Offset: 0x00107ED8
		// (set) Token: 0x06003036 RID: 12342 RVA: 0x00019E9E File Offset: 0x0001809E
		public string Text
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.string_0, value, StringComparison.Ordinal))
				{
					this.string_0 = value;
					this.vmethod_0("Text");
				}
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06003037 RID: 12343 RVA: 0x00109CF0 File Offset: 0x00107EF0
		// (set) Token: 0x06003038 RID: 12344 RVA: 0x00019EC4 File Offset: 0x000180C4
		public string UnitName
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.string_1, value, StringComparison.Ordinal))
				{
					this.string_1 = value;
					this.vmethod_0("UnitName");
				}
			}
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x00004A21 File Offset: 0x00002C21
		[Obsolete("Used for design time only", true)]
		public AircraftFuelViewModel()
		{
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x00109D08 File Offset: 0x00107F08
		[Attribute0, Attribute2]
		public void Refresh()
		{
			this.UnitName = this.theUnit.Name;
			Aircraft aircraft = this.theUnit;
			Aircraft_AirOps aircraftAirOps = aircraft.GetAircraftAirOps();
			ActiveUnit._ActiveUnitFuelState fuelState = this.theUnit.GetFuelState(null);
			ActiveUnit activeUnit = this.theUnit;
			double num = 0.0;
			double num2 = 0.0;
			this.Percentage = (double)((int)Math.Round(activeUnit.GetFuelLeft(ref num2, ref num, false) * 100.0));
			ActiveUnit.Throttle throttle_;
			if (aircraft.IsRotaryWing(false) && this.theUnit.GetDesiredSpeed() < (float)this.theUnit.GetAircraftKinematics().GetSpeed(this.theUnit.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Loiter))
			{
				if (this.theUnit.GetAircraftKinematics().HasFlankAltBand())
				{
					throttle_ = ActiveUnit.Throttle.Flank;
				}
				else
				{
					throttle_ = ActiveUnit.Throttle.Full;
				}
			}
			else
			{
				throttle_ = this.theUnit.GetThrottle();
			}
			float fuelConsumption = aircraft.GetFuelConsumption(this.theUnit.GetThrottle(), null, new float?((float)((int)Math.Round((double)this.theUnit.GetDesiredSpeed()))), new float?(this.theUnit.GetCurrentAltitude_ASL(false)), false, false, false, false);
			long timeToBurnOut = aircraft.GetTimeToBurnOut(throttle_, null, new float?(this.theUnit.GetCurrentSpeed()), new float?(this.theUnit.GetCurrentAltitude_ASL(false)));
			long num3;
			if (fuelConsumption == 0f)
			{
				num3 = 9223372036854775807L;
			}
			else
			{
				num3 = (long)Math.Round((double)(aircraft.FuelQuantityLeftToBingo / fuelConsumption));
			}
			long num4;
			if (fuelConsumption == 0f)
			{
				num4 = 9223372036854775807L;
			}
			else
			{
				num4 = (long)Math.Round((double)(aircraft.FuelQuantityLeftToJoker / fuelConsumption));
			}
			double num5 = Math.Round(num2 - (double)this.theUnit.GetAircraftKinematics().GetReserveFuel(), 0);
			string text = string.Concat(new string[]
			{
				Conversions.ToString(Math.Round(num2, 0)),
				"公斤总油量, ",
				Misc.GetTimeString(timeToBurnOut, Aircraft_AirOps._Maintenance.const_0, true, false),
				", ",
				Conversions.ToString(Math.Round((double)((float)timeToBurnOut * this.theUnit.GetCurrentSpeed() / 3600f), 0)),
				" 海里"
			});
			string text2;
			if (num5 > 0.0)
			{
				text2 = Conversions.ToString(num5) + "公斤任务油量, " + Conversions.ToString(Math.Round((double)this.theUnit.GetAircraftKinematics().GetReserveFuel(), 0)) + "公斤储备燃油";
			}
			else
			{
				text2 = "任务油量已耗光，使用储备油量.";
			}
			string text3 = Conversions.ToString(Math.Round((double)(fuelConsumption * 60f), 1)) + "公斤/分钟耗油率";
			Doctrine._FuelState? bingoJokerDoctrine = aircraft.m_Doctrine.GetBingoJokerDoctrine(aircraft.m_Scenario, false, true, false, false);
			string text4;
			if (Information.IsNothing(aircraftAirOps.GetAssignedHostUnit(false)))
			{
				text4 = "飞机没有选择起降机场!";
			}
			else
			{
				byte? b = bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault() && fuelState != ActiveUnit._ActiveUnitFuelState.IsBingo && num3 > 0L)
				{
					text4 = string.Concat(new string[]
					{
						Conversions.ToString(Math.Round((double)aircraft.FuelQuantityLeftToBingo, 0)),
						"公斤到Bingo油量, ",
						Misc.GetTimeString(num3, Aircraft_AirOps._Maintenance.const_0, false, true),
						", ",
						Conversions.ToString(Math.Round((double)((float)num3 * this.theUnit.GetCurrentSpeed() / 3600f), 0)),
						"海里"
					});
				}
				else if (fuelState != ActiveUnit._ActiveUnitFuelState.IsBingo && fuelState != ActiveUnit._ActiveUnitFuelState.IsJoker && num4 > 0L)
				{
					text4 = string.Concat(new string[]
					{
						Conversions.ToString(Math.Round((double)aircraft.FuelQuantityLeftToJoker, 0)),
						"公斤到Joker油量, ",
						Misc.GetTimeString(num4, Aircraft_AirOps._Maintenance.const_0, false, true),
						", ",
						Conversions.ToString(Math.Round((double)((float)num4 * this.theUnit.GetCurrentSpeed() / 3600f), 0)),
						"海里"
					});
				}
				else
				{
					b = (bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						text4 = "已到BINGO油量!";
					}
					else
					{
						text4 = "已到JOKER油量! " + Conversions.ToString(Math.Round((double)aircraft.FuelQuantityLeftToBingo, 0)) + "公斤到Bingo油量";
					}
				}
			}
			string text5 = "";
			if (Information.IsNothing(aircraftAirOps.GetAssignedHostUnit(false)))
			{
				text5 = "";
			}
			else if (!Information.IsNothing(aircraftAirOps.GetA2ARefuelingDestinationAircraft()))
			{
				text5 = "距离加油机: " + aircraftAirOps.GetA2ARefuelingDestinationAircraft().Name + Conversions.ToString(Math.Round((double)aircraft.DistanceToA2ARefuelingDestinationAircraft, 0)) + "海里";
			}
			else if (aircraft.IsNotGroupLead())
			{
				if (!Information.IsNothing(aircraft.GetParentGroup(false).GetGroupLead()))
				{
					Aircraft_AirOps aircraftAirOps2 = ((Aircraft)aircraft.GetParentGroup(false).GetGroupLead()).GetAircraftAirOps();
					if (!Information.IsNothing(aircraftAirOps2.GetA2ARefuelingDestinationAircraft()))
					{
						text5 = "距离加油机: " + aircraftAirOps2.GetA2ARefuelingDestinationAircraft().Name + Conversions.ToString(Math.Round((double)aircraft.DistanceToA2ARefuelingDestinationAircraft, 0)) + "海里";
					}
					else if (!Information.IsNothing(aircraft.A2ARefuelingDestinationAircraft))
					{
						if (aircraft.A2ARefuelingDestinationAircraft.IsAircraft)
						{
							text5 = "距离加油机: " + aircraft.A2ARefuelingDestinationAircraft.Name + Conversions.ToString(Math.Round((double)aircraft.DistanceToA2ARefuelingDestinationAircraft, 0)) + " 海里";
						}
						else
						{
							text5 = "距离加油基地: " + aircraft.A2ARefuelingDestinationAircraft.Name + Conversions.ToString(Math.Round((double)aircraft.DistanceToA2ARefuelingDestinationAircraft, 0)) + " 海里";
						}
					}
					else
					{
						text5 = "没有选择Bingo油量加油地点";
					}
				}
			}
			else if (!Information.IsNothing(aircraft.A2ARefuelingDestinationAircraft))
			{
				if (aircraft.A2ARefuelingDestinationAircraft.IsAircraft)
				{
					text5 = string.Concat(new string[]
					{
						"距离加油机: ",
						aircraft.A2ARefuelingDestinationAircraft.Name,
						" ",
						Conversions.ToString(Math.Round((double)aircraft.DistanceToA2ARefuelingDestinationAircraft, 0)),
						"海里"
					});
				}
				else
				{
					text5 = string.Concat(new string[]
					{
						"距离加油基地: ",
						aircraft.A2ARefuelingDestinationAircraft.Name,
						" ",
						Conversions.ToString(Math.Round((double)aircraft.DistanceToA2ARefuelingDestinationAircraft, 0)),
						"海里"
					});
				}
			}
			else
			{
				text5 = "没有选择Bingo油量加油地点";
			}
			string text6;
			if (aircraft.AbnTime <= 0f)
			{
				text6 = "";
			}
			else
			{
				text6 = Misc.GetTimeString((long)Math.Round((double)aircraft.AbnTime), Aircraft_AirOps._Maintenance.const_0, false, true) + "飞行时间";
			}
			this.Text = string.Concat(new string[]
			{
				text,
				"\r\n",
				text2,
				"\r\n",
				text3,
				"\r\n",
				text4,
				"\r\n",
				text5,
				"\r\n",
				text6
			});
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x00019EEA File Offset: 0x000180EA
		public AircraftFuelViewModel(Aircraft theUnit)
		{
			this.theUnit = theUnit;
			this.Refresh();
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x0010A4BC File Offset: 0x001086BC
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04001678 RID: 5752
		[CompilerGenerated]
		private double double_0;

		// Token: 0x04001679 RID: 5753
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400167A RID: 5754
		[CompilerGenerated]
		private string string_1;

		// Token: 0x0400167B RID: 5755
		public Aircraft theUnit;

		// Token: 0x0400167C RID: 5756
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
