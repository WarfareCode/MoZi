using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic;
using ns4;

namespace Command
{
	// 武器属性发生变化
	[Attribute0, Attribute2, Attribute3]
	public sealed class UnitWeaponViewModel : INotifyPropertyChanged
	{
		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060035D8 RID: 13784 RVA: 0x0011D528 File Offset: 0x0011B728
		// (remove) Token: 0x060035D9 RID: 13785 RVA: 0x0011D564 File Offset: 0x0011B764
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

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060035DA RID: 13786 RVA: 0x0011D5A0 File Offset: 0x0011B7A0
		// (set) Token: 0x060035DB RID: 13787 RVA: 0x0001CCA2 File Offset: 0x0001AEA2
		public ObservableCollection<UnitWeaponElementViewModel> Weapons
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
					this.vmethod_0("Weapons");
				}
			}
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x0011D5B8 File Offset: 0x0011B7B8
		private void method_0(Weapon Weapon, int Qty)
		{
			UnitWeaponViewModel.Class2478 @class = new UnitWeaponViewModel.Class2478();
			@class.weapon_0 = Weapon;
			UnitWeaponElementViewModel unitWeaponElementViewModel = this.Weapons.FirstOrDefault(new Func<UnitWeaponElementViewModel, bool>(@class.method_0));
			if (unitWeaponElementViewModel == null)
			{
				unitWeaponElementViewModel = new UnitWeaponElementViewModel();
				unitWeaponElementViewModel.WeaponDBID = @class.weapon_0.DBID;
				unitWeaponElementViewModel.Name = @class.weapon_0.Name;
				unitWeaponElementViewModel.Qty = 0;
				this.Weapons.Add(unitWeaponElementViewModel);
			}
			UnitWeaponElementViewModel unitWeaponElementViewModel2;
			(unitWeaponElementViewModel2 = unitWeaponElementViewModel).Qty = unitWeaponElementViewModel2.Qty + Qty;
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x0011D640 File Offset: 0x0011B840
		public void method_1(ActiveUnit theUnit)
		{
			checked
			{
				if (!Information.IsNothing(((Aircraft)theUnit).GetLoadout()))
				{
					WeaponRec[] weaponRecArray = ((Aircraft)theUnit).GetLoadout().WeaponRecArray;
					for (int i = 0; i < weaponRecArray.Length; i++)
					{
						WeaponRec weaponRec = weaponRecArray[i];
						if (weaponRec.GetCurrentLoad() > 0)
						{
							Weapon weapon = weaponRec.GetWeapon(Client.GetClientScenario());
							Weapon._WeaponType weaponType = weapon.GetWeaponType();
							if (weaponType != Weapon._WeaponType.DropTank && weaponType != Weapon._WeaponType.FerryTank && weaponType != Weapon._WeaponType.HeliTowedPackage && weaponType != Weapon._WeaponType.BuddyStore && weaponType != Weapon._WeaponType.TrainingRound)
							{
								if (weaponType == Weapon._WeaponType.SensorPod)
								{
									using (IEnumerator<WeaponRec> enumerator = weapon.GetWeaponRecCollection().GetEnumerator())
									{
										while (enumerator.MoveNext())
										{
											WeaponRec current = enumerator.Current;
											if (current.GetCurrentLoad() > 0)
											{
												Weapon weapon2 = current.GetWeapon(Client.GetClientScenario());
												this.method_0(weapon2, current.GetCurrentLoad());
											}
										}
										goto IL_102;
									}
								}
								this.method_0(weapon, weaponRec.GetCurrentLoad());
							}
						}
						IL_102:;
					}
				}
			}
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x0011D770 File Offset: 0x0011B970
		private void method_2(ActiveUnit theUnit)
		{
			IEnumerable<Magazine> enumerable = theUnit.GetMagazines().OrderBy(UnitWeaponViewModel.MagazineFunc0);
			foreach (Magazine current in enumerable)
			{
				if (!current.bool_8 && current.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
				{
					foreach (WeaponRec current2 in current.GetWeaponRecCollection())
					{
						if (current2.GetCurrentLoad() > 0)
						{
							Weapon weapon = current2.GetWeapon(Client.GetClientScenario());
							if (weapon.GetWeaponType() != Weapon._WeaponType.TrainingRound)
							{
								int currentLoad = current2.GetCurrentLoad();
								this.method_0(weapon, currentLoad);
							}
						}
					}
				}
			}
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x0011D860 File Offset: 0x0011BA60
		private void method_3(ActiveUnit theUnit)
		{
			IEnumerable<Mount> enumerable = theUnit.m_Mounts.OrderBy(UnitWeaponViewModel.MountFunc1);
			foreach (Mount current in enumerable)
			{
				if (current.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
				{
					foreach (WeaponRec current2 in current.GetWeaponRecCollection())
					{
						Weapon weapon = current2.GetWeapon(Client.GetClientScenario());
						if (weapon.GetWeaponType() != Weapon._WeaponType.TrainingRound)
						{
							int num = theUnit.GetWeaponry().method_34(current, current2.WeapID);
							int currentLoad = current2.GetCurrentLoad();
							if (num > 0 || currentLoad > 0)
							{
								this.method_0(weapon, currentLoad + num);
							}
						}
					}
				}
			}
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x0001CCC4 File Offset: 0x0001AEC4
		public UnitWeaponViewModel(ActiveUnit theUnit)
		{
			this.Weapons = new ObservableCollection<UnitWeaponElementViewModel>();
			this.theUnit = theUnit;
			this.method_4();
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x0011D964 File Offset: 0x0011BB64
		public void method_4()
		{
			if (!Information.IsNothing(this.theUnit) && (!this.theUnit.IsShip || !((Ship)this.theUnit).IsDestroyed()))
			{
				if (this.theUnit.IsActiveUnit() && (this.theUnit.IsAircraft || this.theUnit.IsShip || this.theUnit.IsSubmarine || this.theUnit.IsFacility || this.theUnit.IsAirBase() || this.theUnit.IsGroup))
				{
					if (this.theUnit != this.activeUnit_0)
					{
						this.Weapons.Clear();
					}
					else
					{
						using (IEnumerator<UnitWeaponElementViewModel> enumerator = this.Weapons.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								enumerator.Current.Qty = 0;
							}
						}
					}
					if (this.theUnit.IsAircraft)
					{
						this.method_3(this.theUnit);
						this.method_1(this.theUnit);
					}
					else
					{
						if (!this.theUnit.IsShip && !this.theUnit.IsSubmarine && !this.theUnit.IsFacility)
						{
							if (this.theUnit.IsGroup && ((Group)this.theUnit).GetGroupType() == Group.GroupType.AirGroup)
							{
								using (IEnumerator<ActiveUnit> enumerator2 = ((Group)this.theUnit).GetUnitsInGroup().Values.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										ActiveUnit current = enumerator2.Current;
										this.method_3(current);
										this.method_1(current);
									}
									goto IL_229;
								}
							}
							if (!this.theUnit.IsGroup)
							{
								goto IL_229;
							}
							using (IEnumerator<ActiveUnit> enumerator3 = ((Group)this.theUnit).GetUnitsInGroup().Values.GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									ActiveUnit current2 = enumerator3.Current;
									this.method_3(current2);
									this.method_2(current2);
								}
								goto IL_229;
							}
						}
						this.method_3(this.theUnit);
						this.method_2(this.theUnit);
					}
				}
				IL_229:
				this.activeUnit_0 = this.theUnit;
			}
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x0011DBD0 File Offset: 0x0011BDD0
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040018DB RID: 6363
		public static Func<Magazine, string> MagazineFunc0 = (Magazine theM) => theM.Name;

		// Token: 0x040018DC RID: 6364
		public static Func<Mount, string> MountFunc1 = (Mount theM) => theM.Name;

		// Token: 0x040018DD RID: 6365
		[CompilerGenerated]
		private ObservableCollection<UnitWeaponElementViewModel> observableCollection_0;

		// Token: 0x040018DE RID: 6366
		public ActiveUnit theUnit;

		// Token: 0x040018DF RID: 6367
		public ActiveUnit activeUnit_0;

		// Token: 0x040018E0 RID: 6368
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x02000889 RID: 2185
		[CompilerGenerated]
		public sealed class Class2478
		{
			// Token: 0x060035E6 RID: 13798 RVA: 0x0001CCE4 File Offset: 0x0001AEE4
			internal bool method_0(UnitWeaponElementViewModel s)
			{
				return s.WeaponDBID == this.weapon_0.DBID;
			}

			// Token: 0x040018E3 RID: 6371
			public Weapon weapon_0;
		}
	}
}
