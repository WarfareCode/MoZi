using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using ns0;
using ns1;
using ns35;
using ns4;

namespace Command
{
	// Token: 0x0200085B RID: 2139
	[Attribute0, Attribute2, Attribute3]
	public sealed class CargoMissionViewModel : INotifyPropertyChanged
	{
		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060034BA RID: 13498 RVA: 0x0011BA58 File Offset: 0x00119C58
		// (remove) Token: 0x060034BB RID: 13499 RVA: 0x0011BA94 File Offset: 0x00119C94
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

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060034BC RID: 13500 RVA: 0x0011BAD0 File Offset: 0x00119CD0
		// (set) Token: 0x060034BD RID: 13501 RVA: 0x0001C221 File Offset: 0x0001A421
		public ObservableCollection<CargoMissionAssignedUnitViewModel> AssignedUnits
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_0 != value)
				{
					this.observableCollection_0 = value;
					this.vmethod_0("AssignedUnits");
				}
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060034BE RID: 13502 RVA: 0x0011BAE8 File Offset: 0x00119CE8
		// (set) Token: 0x060034BF RID: 13503 RVA: 0x0001C243 File Offset: 0x0001A443
		public ObservableCollection<CargoMissionMothershipUnitViewModel> Motherships
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_1 != value)
				{
					this.observableCollection_1 = value;
					this.vmethod_0("Motherships");
				}
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060034C0 RID: 13504 RVA: 0x0011BB00 File Offset: 0x00119D00
		// (set) Token: 0x060034C1 RID: 13505 RVA: 0x0001C265 File Offset: 0x0001A465
		public ObservableCollection<string> Issues
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_2 != value)
				{
					this.observableCollection_2 = value;
					this.vmethod_0("Issues");
				}
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x0011BB18 File Offset: 0x00119D18
		// (set) Token: 0x060034C3 RID: 13507 RVA: 0x0001C287 File Offset: 0x0001A487
		public ObservableCollection<CargoMissionMothershipCargoMountViewModel> Mounts
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_3 != value)
				{
					this.observableCollection_3 = value;
					this.vmethod_0("Mounts");
				}
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x0011BB30 File Offset: 0x00119D30
		// (set) Token: 0x060034C5 RID: 13509 RVA: 0x0001C2A9 File Offset: 0x0001A4A9
		public CargoMissionMothershipCargoMountViewModel SelectedMount
		{
			[CompilerGenerated]
			get
			{
				return this.cargoMissionMothershipCargoMountViewModel_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.cargoMissionMothershipCargoMountViewModel_0 != value)
				{
					this.cargoMissionMothershipCargoMountViewModel_0 = value;
					this.vmethod_0("SelectedMount");
				}
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060034C6 RID: 13510 RVA: 0x0011BB48 File Offset: 0x00119D48
		// (set) Token: 0x060034C7 RID: 13511 RVA: 0x0001C2CB File Offset: 0x0001A4CB
		public float TransitAltitude_Aircraft
		{
			get
			{
				return this.cargoMission.TransitAltitude_Aircraft;
			}
			set
			{
				if (this.TransitAltitude_Aircraft != value)
				{
					this.cargoMission.TransitAltitude_Aircraft = value;
					this.vmethod_0("TransitAltitude_Aircraft");
				}
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060034C8 RID: 13512 RVA: 0x0011BB64 File Offset: 0x00119D64
		// (set) Token: 0x060034C9 RID: 13513 RVA: 0x0001C2F2 File Offset: 0x0001A4F2
		public float StationAltitude_Aircraft
		{
			get
			{
				return this.cargoMission.StationAltitude_Aircraft;
			}
			set
			{
				if (this.StationAltitude_Aircraft != value)
				{
					this.cargoMission.StationAltitude_Aircraft = value;
					this.vmethod_0("StationAltitude_Aircraft");
				}
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060034CA RID: 13514 RVA: 0x0011BB80 File Offset: 0x00119D80
		// (set) Token: 0x060034CB RID: 13515 RVA: 0x0001C319 File Offset: 0x0001A519
		public int TransitThrottle_Aircraft
		{
			get
			{
				return (int)(this.cargoMission.TransitThrottle_Aircraft - ActiveUnit.Throttle.Loiter);
			}
			set
			{
				if (this.TransitThrottle_Aircraft != value)
				{
					this.cargoMission.TransitThrottle_Aircraft = (ActiveUnit.Throttle)(value + 1);
					this.vmethod_0("TransitThrottle_Aircraft");
				}
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060034CC RID: 13516 RVA: 0x0011BBA0 File Offset: 0x00119DA0
		// (set) Token: 0x060034CD RID: 13517 RVA: 0x0001C343 File Offset: 0x0001A543
		public int StationThrottle_Aircraft
		{
			get
			{
				return (int)(this.cargoMission.StationThrottle_Aircraft - ActiveUnit.Throttle.Loiter);
			}
			set
			{
				if (this.StationThrottle_Aircraft != value)
				{
					this.cargoMission.StationThrottle_Aircraft = (ActiveUnit.Throttle)(value + 1);
					this.vmethod_0("StationThrottle_Aircraft");
				}
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060034CE RID: 13518 RVA: 0x0011BBC0 File Offset: 0x00119DC0
		// (set) Token: 0x060034CF RID: 13519 RVA: 0x0001C36D File Offset: 0x0001A56D
		public int TransitThrottle_Ship
		{
			get
			{
				return (int)(this.cargoMission.TransitThrottle_Ship - ActiveUnit.Throttle.Loiter);
			}
			set
			{
				if (this.TransitThrottle_Ship != value)
				{
					this.cargoMission.TransitThrottle_Ship = (ActiveUnit.Throttle)(value + 1);
					this.vmethod_0("TransitThrottle_Ship");
				}
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060034D0 RID: 13520 RVA: 0x0011BBE0 File Offset: 0x00119DE0
		// (set) Token: 0x060034D1 RID: 13521 RVA: 0x0001C397 File Offset: 0x0001A597
		public int StationThrottle_Ship
		{
			get
			{
				return (int)(this.cargoMission.StationThrottle_Ship - ActiveUnit.Throttle.Loiter);
			}
			set
			{
				if (this.StationThrottle_Ship != value)
				{
					this.cargoMission.StationThrottle_Ship = (ActiveUnit.Throttle)(value + 1);
					this.vmethod_0("StationThrottle_Ship");
				}
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060034D2 RID: 13522 RVA: 0x0011BC00 File Offset: 0x00119E00
		// (set) Token: 0x060034D3 RID: 13523 RVA: 0x0001C3C1 File Offset: 0x0001A5C1
		public Class2535 MountUnloadAllCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2535_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2535_0 != value)
				{
					this.class2535_0 = value;
					this.vmethod_0("MountUnloadAllCommand");
				}
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060034D4 RID: 13524 RVA: 0x0011BC18 File Offset: 0x00119E18
		// (set) Token: 0x060034D5 RID: 13525 RVA: 0x0001C3E3 File Offset: 0x0001A5E3
		public Class2535 MountUnloadOneCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2535_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2535_1 != value)
				{
					this.class2535_1 = value;
					this.vmethod_0("MountUnloadOneCommand");
				}
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060034D6 RID: 13526 RVA: 0x0011BC30 File Offset: 0x00119E30
		// (set) Token: 0x060034D7 RID: 13527 RVA: 0x0001C405 File Offset: 0x0001A605
		public Class2535 MountLoadOneCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2535_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2535_2 != value)
				{
					this.class2535_2 = value;
					this.vmethod_0("MountLoadOneCommand");
				}
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060034D8 RID: 13528 RVA: 0x0011BC48 File Offset: 0x00119E48
		// (set) Token: 0x060034D9 RID: 13529 RVA: 0x0001C427 File Offset: 0x0001A627
		public Class2535 MountLoadAllCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2535_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2535_3 != value)
				{
					this.class2535_3 = value;
					this.vmethod_0("MountLoadAllCommand");
				}
			}
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x0011BC60 File Offset: 0x00119E60
		public CargoMissionViewModel(CargoMission theMission)
		{
			this.AssignedUnits = new ObservableCollection<CargoMissionAssignedUnitViewModel>();
			this.Motherships = new ObservableCollection<CargoMissionMothershipUnitViewModel>();
			this.Issues = new ObservableCollection<string>();
			this.Mounts = new ObservableCollection<CargoMissionMothershipCargoMountViewModel>();
			this.MountUnloadAllCommand = new Class2535(new Action<object>(this.method_8));
			this.MountUnloadOneCommand = new Class2535(new Action<object>(this.method_9));
			this.MountLoadOneCommand = new Class2535(new Action<object>(this.method_10));
			this.MountLoadAllCommand = new Class2535(new Action<object>(this.method_11));
			this.cargoMission = theMission;
			foreach (KeyValuePair<int, int> current in theMission.dictionary_MountsToUnload)
			{
				CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel = new CargoMissionMothershipCargoMountViewModel(current.Key);
				cargoMissionMothershipCargoMountViewModel.ToUnload = current.Value;
				this.Mounts.Add(cargoMissionMothershipCargoMountViewModel);
			}
			foreach (ActiveUnit current2 in theMission.GetUnitsAssignedToMe(Client.GetClientScenario()))
			{
				this.method_2(current2);
			}
			this.method_0();
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x0011BDB4 File Offset: 0x00119FB4
		private void method_0()
		{
			this.Issues.Clear();
			if (this.AssignedUnits.Count == 0)
			{
				this.Issues.Add("Zero units in mission");
			}
			if (this.AssignedUnits.Select(CargoMissionViewModel.CargoMissionAssignedUnitViewModelFunc0).OfType<Ship>().Any(CargoMissionViewModel.ShipFunc1))
			{
				this.Issues.Add("A ship has been added that is unable to take cargo. Please only add cargo carrying ships to this mission.");
			}
			if (this.AssignedUnits.Select(CargoMissionViewModel.CargoMissionAssignedUnitViewModelFunc2).OfType<Aircraft>().Any(CargoMissionViewModel.AircraftFunc3))
			{
				this.Issues.Add("A aircraft has been added that is unable to take cargo with its current loadout.");
			}
			if (!this.cargoMission.IsActive())
			{
				this.Issues.Add("The mission is currently inactive.");
			}
			this.Motherships.Clear();
			foreach (Ship current in this.AssignedUnits.Select(CargoMissionViewModel.CargoMissionAssignedUnitViewModelFunc4).OfType<Ship>().Where(CargoMissionViewModel.shipFunc5))
			{
				CargoMissionViewModel.Class2479 @class = new CargoMissionViewModel.Class2479(null);
				@class.activeUnit_0 = current.GetDockingOps().GetAssignedHostUnit(false);
				if (@class.activeUnit_0 != null && !this.Motherships.Any(new Func<CargoMissionMothershipUnitViewModel, bool>(@class.method_0)))
				{
					this.Motherships.Add(new CargoMissionMothershipUnitViewModel(@class.activeUnit_0));
				}
			}
			foreach (Aircraft current2 in this.AssignedUnits.Select(CargoMissionViewModel.CargoMissionAssignedUnitViewModelFunc6).OfType<Aircraft>().Where(CargoMissionViewModel.AircraftFunc7))
			{
				CargoMissionViewModel.Class2480 class2 = new CargoMissionViewModel.Class2480(null);
				class2.activeUnit_0 = current2.GetAircraftAirOps().GetAssignedHostUnit(false);
				if (class2.activeUnit_0 != null && !this.Motherships.Any(new Func<CargoMissionMothershipUnitViewModel, bool>(class2.method_0)))
				{
					this.Motherships.Add(new CargoMissionMothershipUnitViewModel(class2.activeUnit_0));
				}
			}
			using (IEnumerator<CargoMissionMothershipCargoMountViewModel> enumerator3 = this.Mounts.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					enumerator3.Current.Available = 0;
				}
			}
			foreach (CargoMissionMothershipUnitViewModel current3 in this.Motherships)
			{
				if (current3.theUnit is Group)
				{
					using (IEnumerator<KeyValuePair<string, ActiveUnit>> enumerator5 = ((Group)current3.theUnit).GetUnitsInGroup().GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							KeyValuePair<string, ActiveUnit> current4 = enumerator5.Current;
							foreach (Cargo current5 in current4.Value.m_OnboardCargos.Where(CargoMissionViewModel.CargoFunc8))
							{
								CargoMissionViewModel.Class2481 class3 = new CargoMissionViewModel.Class2481(null);
								class3.mount_0 = (Mount)current5.GetCargo();
								CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel = this.Mounts.FirstOrDefault(new Func<CargoMissionMothershipCargoMountViewModel, bool>(class3.method_0));
								if (cargoMissionMothershipCargoMountViewModel == null)
								{
									cargoMissionMothershipCargoMountViewModel = new CargoMissionMothershipCargoMountViewModel(class3.mount_0.DBID);
									this.Mounts.Add(cargoMissionMothershipCargoMountViewModel);
								}
								CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel2;
								(cargoMissionMothershipCargoMountViewModel2 = cargoMissionMothershipCargoMountViewModel).Available = cargoMissionMothershipCargoMountViewModel2.Available + 1;
							}
						}
						continue;
					}
				}
				foreach (Cargo current6 in current3.theUnit.m_OnboardCargos.Where(CargoMissionViewModel.CargoFunc9))
				{
					CargoMissionViewModel.Class2482 class4 = new CargoMissionViewModel.Class2482(null);
					class4.mount_0 = (Mount)current6.GetCargo();
					CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel3 = this.Mounts.FirstOrDefault(new Func<CargoMissionMothershipCargoMountViewModel, bool>(class4.method_0));
					if (cargoMissionMothershipCargoMountViewModel3 == null)
					{
						cargoMissionMothershipCargoMountViewModel3 = new CargoMissionMothershipCargoMountViewModel(class4.mount_0.DBID);
						this.Mounts.Add(cargoMissionMothershipCargoMountViewModel3);
					}
					CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel2;
					(cargoMissionMothershipCargoMountViewModel2 = cargoMissionMothershipCargoMountViewModel3).Available = cargoMissionMothershipCargoMountViewModel2.Available + 1;
				}
			}
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x0011C2A4 File Offset: 0x0011A4A4
		public void method_1(ActiveUnit theUnit)
		{
			CargoMissionViewModel.Class2483 @class = new CargoMissionViewModel.Class2483(null);
			@class.activeUnit_0 = theUnit;
			bool flag = false;
			CargoMissionAssignedUnitViewModel[] array = this.AssignedUnits.Where((@class.func_0 == null) ? (@class.func_0 = new Func<CargoMissionAssignedUnitViewModel, bool>(@class.method_0)) : @class.func_0).ToArray<CargoMissionAssignedUnitViewModel>();
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					CargoMissionAssignedUnitViewModel item = array[i];
					this.AssignedUnits.Remove(item);
					flag = true;
				}
				if (flag)
				{
					this.method_0();
				}
			}
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x0011C330 File Offset: 0x0011A530
		public void method_2(ActiveUnit theUnit)
		{
			CargoMissionViewModel.Class2484 @class = new CargoMissionViewModel.Class2484();
			@class.activeUnit_0 = theUnit;
			bool flag = false;
			if (!this.AssignedUnits.Any(new Func<CargoMissionAssignedUnitViewModel, bool>(@class.method_0)))
			{
				this.AssignedUnits.Add(new CargoMissionAssignedUnitViewModel(@class.activeUnit_0));
				flag = true;
			}
			if (flag)
			{
				this.method_0();
			}
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x0001C449 File Offset: 0x0001A649
		public void method_3()
		{
			if (this.SelectedMount != null)
			{
				this.SelectedMount.ToUnload = 0;
				this.method_7();
			}
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x0011C38C File Offset: 0x0011A58C
		public void method_4()
		{
			if (this.SelectedMount != null)
			{
				CargoMissionMothershipCargoMountViewModel selectedMount;
				(selectedMount = this.SelectedMount).ToUnload = selectedMount.ToUnload - 1;
				if (this.SelectedMount.ToUnload < 0)
				{
					this.SelectedMount.ToUnload = 0;
				}
				this.method_7();
			}
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x0011C3E0 File Offset: 0x0011A5E0
		public void method_5()
		{
			if (this.SelectedMount != null)
			{
				CargoMissionMothershipCargoMountViewModel selectedMount;
				(selectedMount = this.SelectedMount).ToUnload = selectedMount.ToUnload + 1;
				if (this.SelectedMount.ToUnload > this.SelectedMount.Available)
				{
					this.SelectedMount.ToUnload = this.SelectedMount.Available;
				}
				this.method_7();
			}
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x0001C468 File Offset: 0x0001A668
		public void method_6()
		{
			if (this.SelectedMount != null)
			{
				this.SelectedMount.ToUnload = this.SelectedMount.Available;
				this.method_7();
			}
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x0011C448 File Offset: 0x0011A648
		private void method_7()
		{
			this.cargoMission.dictionary_MountsToUnload.Clear();
			foreach (CargoMissionMothershipCargoMountViewModel current in this.Mounts)
			{
				this.cargoMission.dictionary_MountsToUnload[current.DBID] = current.ToUnload;
			}
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x0001C491 File Offset: 0x0001A691
		[CompilerGenerated]
		private void method_8(object a0)
		{
			this.method_3();
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x0001C499 File Offset: 0x0001A699
		[CompilerGenerated]
		private void method_9(object a0)
		{
			this.method_4();
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x0001C4A1 File Offset: 0x0001A6A1
		[CompilerGenerated]
		private void method_10(object a0)
		{
			this.method_5();
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x0001C4A9 File Offset: 0x0001A6A9
		[CompilerGenerated]
		private void method_11(object a0)
		{
			this.method_6();
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x0011C4C0 File Offset: 0x0011A6C0
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04001867 RID: 6247
		public static Func<CargoMissionAssignedUnitViewModel, ActiveUnit> CargoMissionAssignedUnitViewModelFunc0 = (CargoMissionAssignedUnitViewModel s) => s.theUnit;

		// Token: 0x04001868 RID: 6248
		public static Func<Ship, bool> ShipFunc1 = (Ship s) => s.Cargo_Type == _CargoType.NoCargo;

		// Token: 0x04001869 RID: 6249
		public static Func<CargoMissionAssignedUnitViewModel, ActiveUnit> CargoMissionAssignedUnitViewModelFunc2 = (CargoMissionAssignedUnitViewModel s) => s.theUnit;

		// Token: 0x0400186A RID: 6250
		public static Func<Aircraft, bool> AircraftFunc3 = (Aircraft s) => s.GetLoadout().Cargo_Type == _CargoType.NoCargo;

		// Token: 0x0400186B RID: 6251
		public static Func<CargoMissionAssignedUnitViewModel, ActiveUnit> CargoMissionAssignedUnitViewModelFunc4 = (CargoMissionAssignedUnitViewModel s) => s.theUnit;

		// Token: 0x0400186C RID: 6252
		public static Func<Ship, bool> shipFunc5 = (Ship s) => s.Cargo_Type > _CargoType.NoCargo;

		// Token: 0x0400186D RID: 6253
		public static Func<CargoMissionAssignedUnitViewModel, ActiveUnit> CargoMissionAssignedUnitViewModelFunc6 = (CargoMissionAssignedUnitViewModel s) => s.theUnit;

		// Token: 0x0400186E RID: 6254
		public static Func<Aircraft, bool> AircraftFunc7 = (Aircraft s) => s.GetLoadout().Cargo_Type > _CargoType.NoCargo;

		// Token: 0x0400186F RID: 6255
		public static Func<Cargo, bool> CargoFunc8 = (Cargo s) => s.GetCurrentType() == Cargo._CargoType.const_1;

		// Token: 0x04001870 RID: 6256
		public static Func<Cargo, bool> CargoFunc9 = (Cargo s) => s.GetCurrentType() == Cargo._CargoType.const_1;

		// Token: 0x04001871 RID: 6257
		public CargoMission cargoMission;

		// Token: 0x04001872 RID: 6258
		[CompilerGenerated]
		private ObservableCollection<CargoMissionAssignedUnitViewModel> observableCollection_0;

		// Token: 0x04001873 RID: 6259
		[CompilerGenerated]
		private ObservableCollection<CargoMissionMothershipUnitViewModel> observableCollection_1;

		// Token: 0x04001874 RID: 6260
		[CompilerGenerated]
		private ObservableCollection<string> observableCollection_2;

		// Token: 0x04001875 RID: 6261
		[CompilerGenerated]
		private ObservableCollection<CargoMissionMothershipCargoMountViewModel> observableCollection_3;

		// Token: 0x04001876 RID: 6262
		[CompilerGenerated]
		private CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel_0;

		// Token: 0x04001877 RID: 6263
		[CompilerGenerated]
		private Class2535 class2535_0;

		// Token: 0x04001878 RID: 6264
		[CompilerGenerated]
		private Class2535 class2535_1;

		// Token: 0x04001879 RID: 6265
		[CompilerGenerated]
		private Class2535 class2535_2;

		// Token: 0x0400187A RID: 6266
		[CompilerGenerated]
		private Class2535 class2535_3;

		// Token: 0x0400187B RID: 6267
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x0200085C RID: 2140
		[CompilerGenerated]
		public sealed class Class2479
		{
			// Token: 0x060034F3 RID: 13555 RVA: 0x0001C4F2 File Offset: 0x0001A6F2
			public Class2479(CargoMissionViewModel.Class2479 arg0)
			{
				if (arg0 != null)
				{
					this.activeUnit_0 = arg0.activeUnit_0;
				}
			}

			// Token: 0x060034F4 RID: 13556 RVA: 0x0001C50C File Offset: 0x0001A70C
			internal bool method_0(CargoMissionMothershipUnitViewModel s)
			{
				return s.theUnit == this.activeUnit_0;
			}

			// Token: 0x04001886 RID: 6278
			public ActiveUnit activeUnit_0;
		}

		// Token: 0x0200085D RID: 2141
		[CompilerGenerated]
		public sealed class Class2480
		{
			// Token: 0x060034F5 RID: 13557 RVA: 0x0001C51C File Offset: 0x0001A71C
			public Class2480(CargoMissionViewModel.Class2480 arg0)
			{
				if (arg0 != null)
				{
					this.activeUnit_0 = arg0.activeUnit_0;
				}
			}

			// Token: 0x060034F6 RID: 13558 RVA: 0x0001C536 File Offset: 0x0001A736
			internal bool method_0(CargoMissionMothershipUnitViewModel s)
			{
				return s.theUnit == this.activeUnit_0;
			}

			// Token: 0x04001887 RID: 6279
			public ActiveUnit activeUnit_0;
		}

		// Token: 0x0200085E RID: 2142
		[CompilerGenerated]
		public sealed class Class2481
		{
			// Token: 0x060034F7 RID: 13559 RVA: 0x0001C546 File Offset: 0x0001A746
			public Class2481(CargoMissionViewModel.Class2481 arg0)
			{
				if (arg0 != null)
				{
					this.mount_0 = arg0.mount_0;
				}
			}

			// Token: 0x060034F8 RID: 13560 RVA: 0x0001C560 File Offset: 0x0001A760
			internal bool method_0(CargoMissionMothershipCargoMountViewModel s)
			{
				return s.DBID == this.mount_0.DBID;
			}

			// Token: 0x04001888 RID: 6280
			public Mount mount_0;
		}

		// Token: 0x0200085F RID: 2143
		[CompilerGenerated]
		public sealed class Class2482
		{
			// Token: 0x060034F9 RID: 13561 RVA: 0x0001C575 File Offset: 0x0001A775
			public Class2482(CargoMissionViewModel.Class2482 arg0)
			{
				if (arg0 != null)
				{
					this.mount_0 = arg0.mount_0;
				}
			}

			// Token: 0x060034FA RID: 13562 RVA: 0x0001C58F File Offset: 0x0001A78F
			internal bool method_0(CargoMissionMothershipCargoMountViewModel s)
			{
				return s.DBID == this.mount_0.DBID;
			}

			// Token: 0x04001889 RID: 6281
			public Mount mount_0;
		}

		// Token: 0x02000860 RID: 2144
		[CompilerGenerated]
		public sealed class Class2483
		{
			// Token: 0x060034FB RID: 13563 RVA: 0x0001C5A4 File Offset: 0x0001A7A4
			public Class2483(CargoMissionViewModel.Class2483 arg0)
			{
				if (arg0 != null)
				{
					this.activeUnit_0 = arg0.activeUnit_0;
				}
			}

			// Token: 0x060034FC RID: 13564 RVA: 0x0001C5BE File Offset: 0x0001A7BE
			internal bool method_0(CargoMissionAssignedUnitViewModel s)
			{
				return s.theUnit == this.activeUnit_0;
			}

			// Token: 0x0400188A RID: 6282
			public ActiveUnit activeUnit_0;

			// Token: 0x0400188B RID: 6283
			public Func<CargoMissionAssignedUnitViewModel, bool> func_0;
		}

		// Token: 0x02000861 RID: 2145
		[CompilerGenerated]
		public sealed class Class2484
		{
			// Token: 0x060034FD RID: 13565 RVA: 0x0001C5CE File Offset: 0x0001A7CE
			internal bool method_0(CargoMissionAssignedUnitViewModel s)
			{
				return s.theUnit == this.activeUnit_0;
			}

			// Token: 0x0400188C RID: 6284
			public ActiveUnit activeUnit_0;
		}
	}
}
