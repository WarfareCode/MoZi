using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns3;
using ns33;
using ns35;
using ns4;

namespace Command
{
	// Token: 0x020008D9 RID: 2265
	[Attribute0, Attribute2, Attribute3]
	public sealed class CargoOpsViewModel : INotifyPropertyChanged
	{
		// Token: 0x1400001E RID: 30
		// (add) Token: 0x0600378A RID: 14218 RVA: 0x0011F488 File Offset: 0x0011D688
		// (remove) Token: 0x0600378B RID: 14219 RVA: 0x0011F4C4 File Offset: 0x0011D6C4
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

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600378C RID: 14220 RVA: 0x0011F500 File Offset: 0x0011D700
		// (set) Token: 0x0600378D RID: 14221 RVA: 0x0001D892 File Offset: 0x0001BA92
		public CargoOps Form
		{
			[CompilerGenerated]
			get
			{
				return this.cargoOps_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.cargoOps_0 != value)
				{
					this.cargoOps_0 = value;
					this.vmethod_0("Form");
				}
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600378E RID: 14222 RVA: 0x0011F518 File Offset: 0x0011D718
		// (set) Token: 0x0600378F RID: 14223 RVA: 0x0001D8B4 File Offset: 0x0001BAB4
		public ActiveUnit Host
		{
			[CompilerGenerated]
			get
			{
				return this.activeUnit_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.activeUnit_0 != value)
				{
					this.activeUnit_0 = value;
					this.vmethod_0("Host");
				}
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06003790 RID: 14224 RVA: 0x0011F530 File Offset: 0x0011D730
		// (set) Token: 0x06003791 RID: 14225 RVA: 0x0001D8D6 File Offset: 0x0001BAD6
		public ActiveUnit Target
		{
			[CompilerGenerated]
			get
			{
				return this.activeUnit_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.activeUnit_1 != value)
				{
					this.activeUnit_1 = value;
					this.vmethod_0("Target");
				}
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06003792 RID: 14226 RVA: 0x0011F548 File Offset: 0x0011D748
		// (set) Token: 0x06003793 RID: 14227 RVA: 0x0001D8F8 File Offset: 0x0001BAF8
		public ObservableCollection<CargoOpsCargoItemViewModel> HostInventory
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
					this.vmethod_0("HostInventory");
				}
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06003794 RID: 14228 RVA: 0x0011F560 File Offset: 0x0011D760
		// (set) Token: 0x06003795 RID: 14229 RVA: 0x0001D91A File Offset: 0x0001BB1A
		public CargoOpsCargoItemViewModel HostSelectedItem
		{
			[CompilerGenerated]
			get
			{
				return this.cargoOpsCargoItemViewModel_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.cargoOpsCargoItemViewModel_0 != value)
				{
					this.cargoOpsCargoItemViewModel_0 = value;
					this.vmethod_0("HostSelectedItem");
				}
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06003796 RID: 14230 RVA: 0x0011F578 File Offset: 0x0011D778
		// (set) Token: 0x06003797 RID: 14231 RVA: 0x0001D93C File Offset: 0x0001BB3C
		public double HostRequiredMass
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
					this.vmethod_0("HostRequiredMass");
				}
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06003798 RID: 14232 RVA: 0x0011F590 File Offset: 0x0011D790
		// (set) Token: 0x06003799 RID: 14233 RVA: 0x0001D95E File Offset: 0x0001BB5E
		public double HostRequiredArea
		{
			[CompilerGenerated]
			get
			{
				return this.double_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_1 != value)
				{
					this.double_1 = value;
					this.vmethod_0("HostRequiredArea");
				}
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600379A RID: 14234 RVA: 0x0011F5A8 File Offset: 0x0011D7A8
		// (set) Token: 0x0600379B RID: 14235 RVA: 0x0001D980 File Offset: 0x0001BB80
		public double HostRequiredCrew
		{
			[CompilerGenerated]
			get
			{
				return this.double_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_2 != value)
				{
					this.double_2 = value;
					this.vmethod_0("HostRequiredCrew");
				}
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x0600379C RID: 14236 RVA: 0x0011F5C0 File Offset: 0x0011D7C0
		// (set) Token: 0x0600379D RID: 14237 RVA: 0x0001D9A2 File Offset: 0x0001BBA2
		public double HostTotalMass
		{
			[CompilerGenerated]
			get
			{
				return this.double_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_3 != value)
				{
					this.double_3 = value;
					this.vmethod_0("HostTotalMass");
				}
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x0600379E RID: 14238 RVA: 0x0011F5D8 File Offset: 0x0011D7D8
		// (set) Token: 0x0600379F RID: 14239 RVA: 0x0001D9C4 File Offset: 0x0001BBC4
		public double HostTotalArea
		{
			[CompilerGenerated]
			get
			{
				return this.double_4;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_4 != value)
				{
					this.double_4 = value;
					this.vmethod_0("HostTotalArea");
				}
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060037A0 RID: 14240 RVA: 0x0011F5F0 File Offset: 0x0011D7F0
		// (set) Token: 0x060037A1 RID: 14241 RVA: 0x0001D9E6 File Offset: 0x0001BBE6
		public double HostTotalCrew
		{
			[CompilerGenerated]
			get
			{
				return this.double_5;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_5 != value)
				{
					this.double_5 = value;
					this.vmethod_0("HostTotalCrew");
				}
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060037A2 RID: 14242 RVA: 0x0011F608 File Offset: 0x0011D808
		// (set) Token: 0x060037A3 RID: 14243 RVA: 0x0001DA08 File Offset: 0x0001BC08
		public _CargoType HostType
		{
			[CompilerGenerated]
			get
			{
				return this.enum16_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.enum16_0 != value)
				{
					this.enum16_0 = value;
					this.vmethod_0("HostType");
				}
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060037A4 RID: 14244 RVA: 0x0011F620 File Offset: 0x0011D820
		// (set) Token: 0x060037A5 RID: 14245 RVA: 0x0001DA2A File Offset: 0x0001BC2A
		public string HostName
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
					this.vmethod_0("HostName");
				}
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060037A6 RID: 14246 RVA: 0x0001DA50 File Offset: 0x0001BC50
		// (set) Token: 0x060037A7 RID: 14247 RVA: 0x0001DA58 File Offset: 0x0001BC58
		public bool HostIsGroup
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.bool_0 != value)
				{
					this.bool_0 = value;
					this.vmethod_0("HostIsGroup");
				}
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060037A8 RID: 14248 RVA: 0x0011F638 File Offset: 0x0011D838
		// (set) Token: 0x060037A9 RID: 14249 RVA: 0x0001DA7A File Offset: 0x0001BC7A
		public ObservableCollection<CargoOpsCargoItemViewModel> TargetInventory
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
					this.vmethod_0("TargetInventory");
				}
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060037AA RID: 14250 RVA: 0x0011F650 File Offset: 0x0011D850
		// (set) Token: 0x060037AB RID: 14251 RVA: 0x0001DA9C File Offset: 0x0001BC9C
		public CargoOpsCargoItemViewModel TargetSelectedItem
		{
			[CompilerGenerated]
			get
			{
				return this.cargoOpsCargoItemViewModel_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.cargoOpsCargoItemViewModel_1 != value)
				{
					this.cargoOpsCargoItemViewModel_1 = value;
					this.vmethod_0("TargetSelectedItem");
				}
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060037AC RID: 14252 RVA: 0x0011F668 File Offset: 0x0011D868
		// (set) Token: 0x060037AD RID: 14253 RVA: 0x0001DABE File Offset: 0x0001BCBE
		public double TargetRequiredMass
		{
			[CompilerGenerated]
			get
			{
				return this.double_6;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_6 != value)
				{
					this.double_6 = value;
					this.vmethod_0("TargetRequiredMass");
				}
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060037AE RID: 14254 RVA: 0x0011F680 File Offset: 0x0011D880
		// (set) Token: 0x060037AF RID: 14255 RVA: 0x0001DAE0 File Offset: 0x0001BCE0
		public double TargetRequiredArea
		{
			[CompilerGenerated]
			get
			{
				return this.double_7;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_7 != value)
				{
					this.double_7 = value;
					this.vmethod_0("TargetRequiredArea");
				}
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060037B0 RID: 14256 RVA: 0x0011F698 File Offset: 0x0011D898
		// (set) Token: 0x060037B1 RID: 14257 RVA: 0x0001DB02 File Offset: 0x0001BD02
		public double TargetRequiredCrew
		{
			[CompilerGenerated]
			get
			{
				return this.double_8;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_8 != value)
				{
					this.double_8 = value;
					this.vmethod_0("TargetRequiredCrew");
				}
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060037B2 RID: 14258 RVA: 0x0011F6B0 File Offset: 0x0011D8B0
		// (set) Token: 0x060037B3 RID: 14259 RVA: 0x0001DB24 File Offset: 0x0001BD24
		public double TargetTotalMass
		{
			[CompilerGenerated]
			get
			{
				return this.double_9;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_9 != value)
				{
					this.double_9 = value;
					this.vmethod_0("TargetTotalMass");
				}
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060037B4 RID: 14260 RVA: 0x0011F6C8 File Offset: 0x0011D8C8
		// (set) Token: 0x060037B5 RID: 14261 RVA: 0x0001DB46 File Offset: 0x0001BD46
		public double TargetTotalArea
		{
			[CompilerGenerated]
			get
			{
				return this.double_10;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_10 != value)
				{
					this.double_10 = value;
					this.vmethod_0("TargetTotalArea");
				}
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060037B6 RID: 14262 RVA: 0x0011F6E0 File Offset: 0x0011D8E0
		// (set) Token: 0x060037B7 RID: 14263 RVA: 0x0001DB68 File Offset: 0x0001BD68
		public double TargetTotalCrew
		{
			[CompilerGenerated]
			get
			{
				return this.double_11;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_11 != value)
				{
					this.double_11 = value;
					this.vmethod_0("TargetTotalCrew");
				}
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060037B8 RID: 14264 RVA: 0x0011F6F8 File Offset: 0x0011D8F8
		// (set) Token: 0x060037B9 RID: 14265 RVA: 0x0001DB8A File Offset: 0x0001BD8A
		public _CargoType TargetType
		{
			[CompilerGenerated]
			get
			{
				return this.enum16_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.enum16_1 != value)
				{
					this.enum16_1 = value;
					this.vmethod_0("TargetType");
				}
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060037BA RID: 14266 RVA: 0x0011F710 File Offset: 0x0011D910
		// (set) Token: 0x060037BB RID: 14267 RVA: 0x0001DBAC File Offset: 0x0001BDAC
		public string TargetName
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
					this.vmethod_0("TargetName");
				}
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x0001DBD2 File Offset: 0x0001BDD2
		// (set) Token: 0x060037BD RID: 14269 RVA: 0x0001DBDA File Offset: 0x0001BDDA
		public bool Exchange
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.bool_1 != value)
				{
					this.bool_1 = value;
					this.vmethod_0("ExchangeVisibility");
					this.vmethod_0("ExchangeVisibilityInverse");
					this.vmethod_0("Exchange");
				}
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x0011F728 File Offset: 0x0011D928
		public Visibility ExchangeVisibility
		{
			get
			{
				Visibility result;
				if (this.Exchange)
				{
					result = Visibility.Visible;
				}
				else
				{
					result = Visibility.Collapsed;
				}
				return result;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060037BF RID: 14271 RVA: 0x0011F74C File Offset: 0x0011D94C
		public Visibility ExchangeVisibilityInverse
		{
			get
			{
				Visibility result;
				if (!this.Exchange)
				{
					result = Visibility.Visible;
				}
				else
				{
					result = Visibility.Collapsed;
				}
				return result;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060037C0 RID: 14272 RVA: 0x0011F76C File Offset: 0x0011D96C
		// (set) Token: 0x060037C1 RID: 14273 RVA: 0x0001DC12 File Offset: 0x0001BE12
		public DataTable AllMounts
		{
			[CompilerGenerated]
			get
			{
				return this.dataTable_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTable_0 != value)
				{
					this.dataTable_0 = value;
					this.vmethod_0("AllMounts");
				}
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060037C2 RID: 14274 RVA: 0x0011F784 File Offset: 0x0011D984
		// (set) Token: 0x060037C3 RID: 14275 RVA: 0x0001DC34 File Offset: 0x0001BE34
		public Class2535 UnloadAllCommand
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
					this.vmethod_0("UnloadAllCommand");
				}
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060037C4 RID: 14276 RVA: 0x0011F79C File Offset: 0x0011D99C
		// (set) Token: 0x060037C5 RID: 14277 RVA: 0x0001DC56 File Offset: 0x0001BE56
		public Class2535 UnloadOneCommand
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
					this.vmethod_0("UnloadOneCommand");
				}
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060037C6 RID: 14278 RVA: 0x0011F7B4 File Offset: 0x0011D9B4
		// (set) Token: 0x060037C7 RID: 14279 RVA: 0x0001DC78 File Offset: 0x0001BE78
		public Class2535 LoadOneCommand
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
					this.vmethod_0("LoadOneCommand");
				}
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060037C8 RID: 14280 RVA: 0x0011F7CC File Offset: 0x0011D9CC
		// (set) Token: 0x060037C9 RID: 14281 RVA: 0x0001DC9A File Offset: 0x0001BE9A
		public Class2535 LoadAllCommand
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
					this.vmethod_0("LoadAllCommand");
				}
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060037CA RID: 14282 RVA: 0x0011F7E4 File Offset: 0x0011D9E4
		// (set) Token: 0x060037CB RID: 14283 RVA: 0x0001DCBC File Offset: 0x0001BEBC
		public Class2535 OKCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2535_4;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2535_4 != value)
				{
					this.class2535_4 = value;
					this.vmethod_0("OKCommand");
				}
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060037CC RID: 14284 RVA: 0x0011F7FC File Offset: 0x0011D9FC
		// (set) Token: 0x060037CD RID: 14285 RVA: 0x0001DCDE File Offset: 0x0001BEDE
		public Class2535 CancelCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2535_5;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2535_5 != value)
				{
					this.class2535_5 = value;
					this.vmethod_0("CancelCommand");
				}
			}
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x0011F814 File Offset: 0x0011DA14
		private void method_0()
		{
			this.HostRequiredMass = (double)this.HostInventory.Where(CargoOpsViewModel.CargoOpsCargoItemViewModelFunc0).Select(CargoOpsViewModel.CargoOpsCargoItemViewModelFunc1).Sum(CargoOpsViewModel.intFunc2);
			this.HostRequiredArea = (double)this.HostInventory.Where(CargoOpsViewModel.CargoOpsCargoItemViewModelFunc3).Select(CargoOpsViewModel.CargoOpsCargoItemViewModelFunc4).Sum(CargoOpsViewModel.intFunc5);
			this.HostRequiredCrew = (double)this.HostInventory.Where(CargoOpsViewModel.CargoOpsCargoItemViewModelFunc6).Select(CargoOpsViewModel.CargoOpsCargoItemViewModelFunc7).Sum(CargoOpsViewModel.intFunc8);
			foreach (CargoOpsCargoItemViewModel current in this.HostInventory)
			{
				if (current.CargoType > this.HostType | current.CargoType > this.TargetType)
				{
					current.CargoTypeLimited = true;
				}
			}
			if (this.Target != null)
			{
				this.TargetRequiredMass = (double)this.TargetInventory.Where(CargoOpsViewModel.CargoOpsCargoItemViewModelFunc9).Select(CargoOpsViewModel.CargoOpsCargoItemViewModelFunc10).Sum(CargoOpsViewModel.intFunc11);
				this.TargetRequiredArea = (double)this.TargetInventory.Where(CargoOpsViewModel.CargoOpsCargoItemViewModelFunc12).Select(CargoOpsViewModel.CargoOpsCargoItemViewModelFunc13).Sum(CargoOpsViewModel.intFunc14);
				this.TargetRequiredCrew = (double)this.TargetInventory.Where(CargoOpsViewModel.CargoOpsCargoItemViewModelFunc15).Select(CargoOpsViewModel.CargoOpsCargoItemViewModelFunc16).Sum(CargoOpsViewModel.intFunc17);
				foreach (CargoOpsCargoItemViewModel current2 in this.TargetInventory)
				{
					if (current2.CargoType > this.HostType | current2.CargoType > this.TargetType)
					{
						current2.CargoTypeLimited = true;
					}
				}
			}
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x0011F9FC File Offset: 0x0011DBFC
		public CargoOpsViewModel(CargoOps Form, ActiveUnit selectedHost, ActiveUnit selectedTarget)
		{
			this.HostInventory = new ObservableCollection<CargoOpsCargoItemViewModel>();
			this.cargo_0 = new Cargo[0];
			this.collection_0 = new Collection<ActiveUnit>();
			this.TargetInventory = new ObservableCollection<CargoOpsCargoItemViewModel>();
			this.UnloadAllCommand = new Class2535(new Action<object>(this.method_8));
			this.UnloadOneCommand = new Class2535(new Action<object>(this.method_9));
			this.LoadOneCommand = new Class2535(new Action<object>(this.method_10));
			this.LoadAllCommand = new Class2535(new Action<object>(this.method_11));
			this.OKCommand = new Class2535(new Action<object>(this.method_12));
			this.CancelCommand = new Class2535(new Action<object>(this.method_13));
			this.Form = Form;
			SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
			this.AllMounts = DBFunctions.smethod_66(ref sQLiteConnection);
			this.Host = selectedHost;
			this.Target = selectedTarget;
			if (this.Target == null)
			{
				this.Exchange = false;
			}
			else
			{
				this.Exchange = true;
			}
			if (this.Host == null)
			{
				if (this.Target is Aircraft)
				{
					Aircraft_AirOps aircraftAirOps = ((Aircraft)this.Target).GetAircraftAirOps();
					this.Host = aircraftAirOps.GetCurrentHostUnit();
				}
				else if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			Form.Text = string.Format("Cargo {0}", this.Host.Name);
			this.HostName = this.Host.Name;
			if (!(this.Host is Group))
			{
				ICargo cargo = (ICargo)this.Host;
				this.HostTotalMass = (double)cargo.GetCargoMass();
				this.HostTotalArea = (double)cargo.GetCargoArea();
				this.HostTotalCrew = (double)cargo.GetCargoCrew();
				this.HostType = cargo.GetCargoType();
				this.cargo_0 = this.Host.m_OnboardCargos;
			}
			else
			{
				Group group = (Group)this.Host;
				this.cargo_0 = new Cargo[0];
				this.HostTotalMass = 0.0;
				this.HostTotalArea = 0.0;
				this.HostTotalCrew = 0.0;
				this.HostType = _CargoType.VeryLargeCargo;
				this.HostIsGroup = true;
				foreach (KeyValuePair<string, ActiveUnit> current in group.GetUnitsInGroup())
				{
					ICargo cargo = (ICargo)current.Value;
					this.HostTotalMass += (double)cargo.GetCargoMass();
					this.HostTotalArea += (double)cargo.GetCargoArea();
					this.HostTotalCrew += (double)cargo.GetCargoCrew();
					Cargo[] onboardCargos = current.Value.m_OnboardCargos;
					checked
					{
						for (int i = 0; i < onboardCargos.Length; i++)
						{
							Cargo cargo_ = onboardCargos[i];
							ScenarioArrayUtil.AddCargo(ref this.cargo_0, cargo_);
						}
						this.collection_0.Add(current.Value);
					}
				}
			}
			this.method_0();
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x0011FD84 File Offset: 0x0011DF84
		private void method_1(CargoOpsCargoItemViewModel Item, ActiveUnit DestActiveUnit, ref ObservableCollection<CargoOpsCargoItemViewModel> Source, ref ObservableCollection<CargoOpsCargoItemViewModel> Dest, int Quantity, double DestRequiredMass, double DestTotalMass, double DestRequiredArea, double DestTotalArea, double DestRequiredCrew, double DestTotalCrew)
		{
			CargoOpsViewModel.Class2485 @class = new CargoOpsViewModel.Class2485();
			@class.cargoOpsCargoItemViewModel_0 = Item;
			if (@class.cargoOpsCargoItemViewModel_0 != null && @class.cargoOpsCargoItemViewModel_0.Quantity > 0 && !@class.cargoOpsCargoItemViewModel_0.CargoTypeLimited)
			{
				double massPerUnit = @class.cargoOpsCargoItemViewModel_0.MassPerUnit;
				double areaPerUnit = @class.cargoOpsCargoItemViewModel_0.AreaPerUnit;
				double crewPerUnit = @class.cargoOpsCargoItemViewModel_0.CrewPerUnit;
				double num = (DestTotalMass - DestRequiredMass) / massPerUnit;
				double num2 = (DestTotalArea - DestRequiredArea) / areaPerUnit;
				double num3 = (DestTotalCrew - DestRequiredCrew) / crewPerUnit;
				CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel = Source.First(new Func<CargoOpsCargoItemViewModel, bool>(@class.method_0));
				int num4 = (int)Math.Round(Math.Floor(new double[]
				{
					(double)Quantity,
					num,
					num2,
					num3,
					(double)cargoOpsCargoItemViewModel.Quantity
				}.Where(CargoOpsViewModel.doubleFunc24).ToArray<double>().Min()));
				if (num4 != 0)
				{
					CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel2 = Dest.FirstOrDefault(new Func<CargoOpsCargoItemViewModel, bool>(@class.method_1));
					if (cargoOpsCargoItemViewModel2 == null)
					{
						cargoOpsCargoItemViewModel2 = new CargoOpsCargoItemViewModel
						{
							Cargo = new Cargo(DestActiveUnit, DBFunctions.LoadMountData(Conversions.ToInteger(NewLateBinding.LateGet(@class.cargoOpsCargoItemViewModel_0.Cargo.GetCargo(), null, "DBID", new object[0], null, null, null)), ref DestActiveUnit.m_Scenario, true)),
							Quantity = 0,
							InitialQuantity = 0
						};
						Dest.Add(cargoOpsCargoItemViewModel2);
					}
					CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel3;
					(cargoOpsCargoItemViewModel3 = cargoOpsCargoItemViewModel2).Quantity = cargoOpsCargoItemViewModel3.Quantity + num4;
					(cargoOpsCargoItemViewModel3 = cargoOpsCargoItemViewModel).Quantity = cargoOpsCargoItemViewModel3.Quantity - num4;
					this.method_0();
				}
			}
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x0011FF2C File Offset: 0x0011E12C
		public void method_2()
		{
			if (this.TargetSelectedItem != null)
			{
				CargoOpsCargoItemViewModel targetSelectedItem = this.TargetSelectedItem;
				ActiveUnit host = this.Host;
				ObservableCollection<CargoOpsCargoItemViewModel> targetInventory = this.TargetInventory;
				ObservableCollection<CargoOpsCargoItemViewModel> hostInventory = this.HostInventory;
				this.method_1(targetSelectedItem, host, ref targetInventory, ref hostInventory, this.TargetSelectedItem.Quantity, this.HostRequiredMass, this.HostTotalMass, this.HostRequiredArea, this.HostTotalArea, this.HostRequiredCrew, this.HostTotalCrew);
				this.HostInventory = hostInventory;
				this.TargetInventory = targetInventory;
			}
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x0011FFAC File Offset: 0x0011E1AC
		public void method_3()
		{
			CargoOpsCargoItemViewModel targetSelectedItem = this.TargetSelectedItem;
			ActiveUnit host = this.Host;
			ObservableCollection<CargoOpsCargoItemViewModel> targetInventory = this.TargetInventory;
			ObservableCollection<CargoOpsCargoItemViewModel> hostInventory = this.HostInventory;
			this.method_1(targetSelectedItem, host, ref targetInventory, ref hostInventory, 1, this.HostRequiredMass, this.HostTotalMass, this.HostRequiredArea, this.HostTotalArea, this.HostRequiredCrew, this.HostTotalCrew);
			this.HostInventory = hostInventory;
			this.TargetInventory = targetInventory;
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x00120014 File Offset: 0x0011E214
		public void method_4()
		{
			CargoOpsCargoItemViewModel hostSelectedItem = this.HostSelectedItem;
			ActiveUnit target = this.Target;
			ObservableCollection<CargoOpsCargoItemViewModel> hostInventory = this.HostInventory;
			ObservableCollection<CargoOpsCargoItemViewModel> targetInventory = this.TargetInventory;
			this.method_1(hostSelectedItem, target, ref hostInventory, ref targetInventory, 1, this.TargetRequiredMass, this.TargetTotalMass, this.TargetRequiredArea, this.TargetTotalArea, this.TargetRequiredCrew, this.TargetTotalCrew);
			this.TargetInventory = targetInventory;
			this.HostInventory = hostInventory;
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x0012007C File Offset: 0x0011E27C
		public void method_5()
		{
			if (this.HostSelectedItem != null)
			{
				CargoOpsCargoItemViewModel hostSelectedItem = this.HostSelectedItem;
				ActiveUnit target = this.Target;
				ObservableCollection<CargoOpsCargoItemViewModel> hostInventory = this.HostInventory;
				ObservableCollection<CargoOpsCargoItemViewModel> targetInventory = this.TargetInventory;
				this.method_1(hostSelectedItem, target, ref hostInventory, ref targetInventory, this.HostSelectedItem.Quantity, this.TargetRequiredMass, this.TargetTotalMass, this.TargetRequiredArea, this.TargetTotalArea, this.TargetRequiredCrew, this.TargetTotalCrew);
				this.TargetInventory = targetInventory;
				this.HostInventory = hostInventory;
			}
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x001200FC File Offset: 0x0011E2FC
		public void method_6()
		{
			if (!this.HostIsGroup)
			{
				List<Cargo> list = new List<Cargo>();
				using (IEnumerator<CargoOpsCargoItemViewModel> enumerator = this.HostInventory.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						CargoOpsViewModel.Class2486 @class = new CargoOpsViewModel.Class2486(null);
						@class.cargoOpsCargoItemViewModel_0 = enumerator.Current;
						if (@class.cargoOpsCargoItemViewModel_0.Quantity < @class.cargoOpsCargoItemViewModel_0.InitialQuantity)
						{
							int count = @class.cargoOpsCargoItemViewModel_0.InitialQuantity - @class.cargoOpsCargoItemViewModel_0.Quantity;
							list.AddRange(this.Host.m_OnboardCargos.Where(new Func<Cargo, bool>(@class.method_0)).Take(count));
						}
					}
				}
				using (IEnumerator<CargoOpsCargoItemViewModel> enumerator2 = this.TargetInventory.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						CargoOpsViewModel.Class2487 class2 = new CargoOpsViewModel.Class2487(null);
						class2.cargoOpsCargoItemViewModel_0 = enumerator2.Current;
						if (class2.cargoOpsCargoItemViewModel_0.Quantity < class2.cargoOpsCargoItemViewModel_0.InitialQuantity)
						{
							int count2 = class2.cargoOpsCargoItemViewModel_0.InitialQuantity - class2.cargoOpsCargoItemViewModel_0.Quantity;
							list.AddRange(this.Target.m_OnboardCargos.Where(new Func<Cargo, bool>(class2.method_0)).Take(count2));
						}
					}
				}
				this.Host.GetDockingOps().method_53(this.Host, this.Target, list);
			}
			else
			{
				Dictionary<int, int> dictionary = new Dictionary<int, int>();
				Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
				foreach (CargoOpsCargoItemViewModel current in this.HostInventory)
				{
					if (current.Quantity < current.InitialQuantity)
					{
						int value = current.InitialQuantity - current.Quantity;
						dictionary[Conversions.ToInteger(NewLateBinding.LateGet(current.Cargo.GetCargo(), null, "DBID", new object[0], null, null, null))] = value;
					}
				}
				foreach (CargoOpsCargoItemViewModel current2 in this.TargetInventory)
				{
					if (current2.Quantity < current2.InitialQuantity)
					{
						int value2 = current2.InitialQuantity - current2.Quantity;
						dictionary2[Conversions.ToInteger(NewLateBinding.LateGet(current2.Cargo.GetCargo(), null, "DBID", new object[0], null, null, null))] = value2;
					}
				}
				checked
				{
					foreach (ActiveUnit current3 in this.collection_0)
					{
						List<Cargo> list2 = new List<Cargo>();
						KeyValuePair<int, int>[] array = dictionary.ToArray<KeyValuePair<int, int>>();
						for (int i = 0; i < array.Length; i++)
						{
							CargoOpsViewModel.Class2488 class3 = new CargoOpsViewModel.Class2488(null);
							class3.keyValuePair_0 = array[i];
							IEnumerable<Cargo> source = current3.m_OnboardCargos.Where(new Func<Cargo, bool>(class3.method_0));
							int value3 = class3.keyValuePair_0.Value;
							int num = Math.Min(source.Count<Cargo>(), value3);
							list2.AddRange(current3.m_OnboardCargos.Where(new Func<Cargo, bool>(class3.method_1)).Take(num));
							dictionary[class3.keyValuePair_0.Key] = unchecked(dictionary[class3.keyValuePair_0.Key] - num);
						}
						this.Host.GetDockingOps().method_53(current3, this.Target, list2);
					}
					List<Cargo> list3 = new List<Cargo>();
					using (Dictionary<int, int>.Enumerator enumerator6 = dictionary2.GetEnumerator())
					{
						while (enumerator6.MoveNext())
						{
							CargoOpsViewModel.Class2489 class4 = new CargoOpsViewModel.Class2489(null);
							class4.keyValuePair_0 = enumerator6.Current;
							list3.AddRange(this.Target.m_OnboardCargos.Where(new Func<Cargo, bool>(class4.method_0)).Take(class4.keyValuePair_0.Value));
						}
					}
					this.Host.GetDockingOps().method_53(this.Target, ((Group)this.Host).GetUnitsInGroup().Dictionary.First<KeyValuePair<string, ActiveUnit>>().Value, list3);
				}
			}
			this.AllMounts.Dispose();
			this.Form.Close();
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x0001DD00 File Offset: 0x0001BF00
		public void method_7()
		{
			this.AllMounts.Dispose();
			this.Form.Close();
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x0001DD18 File Offset: 0x0001BF18
		[CompilerGenerated]
		private void method_8(object a0)
		{
			this.method_2();
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x0001DD20 File Offset: 0x0001BF20
		[CompilerGenerated]
		private void method_9(object a0)
		{
			this.method_3();
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x0001DD28 File Offset: 0x0001BF28
		[CompilerGenerated]
		private void method_10(object a0)
		{
			this.method_4();
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x0001DD30 File Offset: 0x0001BF30
		[CompilerGenerated]
		private void method_11(object a0)
		{
			this.method_5();
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x0001DD38 File Offset: 0x0001BF38
		[CompilerGenerated]
		private void method_12(object a0)
		{
			this.method_6();
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x0001DD40 File Offset: 0x0001BF40
		[CompilerGenerated]
		private void method_13(object a0)
		{
			this.method_7();
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x00120610 File Offset: 0x0011E810
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400197A RID: 6522
		public static Func<CargoOpsCargoItemViewModel, bool> CargoOpsCargoItemViewModelFunc0 = (CargoOpsCargoItemViewModel C) => C.Cargo.GetCurrentType() == Cargo._CargoType.const_1;

		// Token: 0x0400197B RID: 6523
		public static Func<CargoOpsCargoItemViewModel, int> CargoOpsCargoItemViewModelFunc1 = (CargoOpsCargoItemViewModel C) => (int)((Mount)C.Cargo.GetCargo()).Cargo_Mass * C.Quantity;

		// Token: 0x0400197C RID: 6524
		public static Func<int, int> intFunc2 = (int x) => x;

		// Token: 0x0400197D RID: 6525
		public static Func<CargoOpsCargoItemViewModel, bool> CargoOpsCargoItemViewModelFunc3 = (CargoOpsCargoItemViewModel C) => C.Cargo.GetCurrentType() == Cargo._CargoType.const_1;

		// Token: 0x0400197E RID: 6526
		public static Func<CargoOpsCargoItemViewModel, int> CargoOpsCargoItemViewModelFunc4 = (CargoOpsCargoItemViewModel C) => (int)((Mount)C.Cargo.GetCargo()).Cargo_Area * C.Quantity;

		// Token: 0x0400197F RID: 6527
		public static Func<int, int> intFunc5 = (int x) => x;

		// Token: 0x04001980 RID: 6528
		public static Func<CargoOpsCargoItemViewModel, bool> CargoOpsCargoItemViewModelFunc6 = (CargoOpsCargoItemViewModel C) => C.Cargo.GetCurrentType() == Cargo._CargoType.const_1;

		// Token: 0x04001981 RID: 6529
		public static Func<CargoOpsCargoItemViewModel, int> CargoOpsCargoItemViewModelFunc7 = (CargoOpsCargoItemViewModel C) => (int)((Mount)C.Cargo.GetCargo()).Cargo_Crew * C.Quantity;

		// Token: 0x04001982 RID: 6530
		public static Func<int, int> intFunc8 = (int x) => x;

		// Token: 0x04001983 RID: 6531
		public static Func<CargoOpsCargoItemViewModel, bool> CargoOpsCargoItemViewModelFunc9 = (CargoOpsCargoItemViewModel C) => C.Cargo.GetCurrentType() == Cargo._CargoType.const_1;

		// Token: 0x04001984 RID: 6532
		public static Func<CargoOpsCargoItemViewModel, int> CargoOpsCargoItemViewModelFunc10 = (CargoOpsCargoItemViewModel C) => (int)((Mount)C.Cargo.GetCargo()).Cargo_Mass * C.Quantity;

		// Token: 0x04001985 RID: 6533
		public static Func<int, int> intFunc11 = (int x) => x;

		// Token: 0x04001986 RID: 6534
		public static Func<CargoOpsCargoItemViewModel, bool> CargoOpsCargoItemViewModelFunc12 = (CargoOpsCargoItemViewModel C) => C.Cargo.GetCurrentType() == Cargo._CargoType.const_1;

		// Token: 0x04001987 RID: 6535
		public static Func<CargoOpsCargoItemViewModel, int> CargoOpsCargoItemViewModelFunc13 = (CargoOpsCargoItemViewModel C) => (int)((Mount)C.Cargo.GetCargo()).Cargo_Area * C.Quantity;

		// Token: 0x04001988 RID: 6536
		public static Func<int, int> intFunc14 = (int x) => x;

		// Token: 0x04001989 RID: 6537
		public static Func<CargoOpsCargoItemViewModel, bool> CargoOpsCargoItemViewModelFunc15 = (CargoOpsCargoItemViewModel C) => C.Cargo.GetCurrentType() == Cargo._CargoType.const_1;

		// Token: 0x0400198A RID: 6538
		public static Func<CargoOpsCargoItemViewModel, int> CargoOpsCargoItemViewModelFunc16 = (CargoOpsCargoItemViewModel C) => (int)((Mount)C.Cargo.GetCargo()).Cargo_Crew * C.Quantity;

		// Token: 0x0400198B RID: 6539
		public static Func<int, int> intFunc17 = (int x) => x;

		// Token: 0x0400198C RID: 6540
		public static Func<Cargo, bool> CargoFunc18 = (Cargo C) => C.GetCurrentType() == Cargo._CargoType.const_1;

		// Token: 0x0400198D RID: 6541
		public static Func<Cargo, int> CargoFunc19 = (Cargo C) => ((Mount)C.GetCargo()).DBID;

		// Token: 0x0400198E RID: 6542
		public static Func<Cargo, bool> CargoFunc21 = (Cargo C) => C.GetCurrentType() == Cargo._CargoType.const_1;

		// Token: 0x0400198F RID: 6543
		public static Func<Cargo, int> CargoFunc22 = (Cargo C) => ((Mount)C.GetCargo()).DBID;

		// Token: 0x04001990 RID: 6544
		public static Func<double, bool> doubleFunc24 = (double s) => !double.IsNaN(s);

		// Token: 0x04001991 RID: 6545
		[CompilerGenerated]
		private CargoOps cargoOps_0;

		// Token: 0x04001992 RID: 6546
		[CompilerGenerated]
		private ActiveUnit activeUnit_0;

		// Token: 0x04001993 RID: 6547
		[CompilerGenerated]
		private ActiveUnit activeUnit_1;

		// Token: 0x04001994 RID: 6548
		[CompilerGenerated]
		private ObservableCollection<CargoOpsCargoItemViewModel> observableCollection_0;

		// Token: 0x04001995 RID: 6549
		[CompilerGenerated]
		private CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel_0;

		// Token: 0x04001996 RID: 6550
		[CompilerGenerated]
		private double double_0;

		// Token: 0x04001997 RID: 6551
		[CompilerGenerated]
		private double double_1;

		// Token: 0x04001998 RID: 6552
		[CompilerGenerated]
		private double double_2 = 0.0;

		// Token: 0x04001999 RID: 6553
		[CompilerGenerated]
		private double double_3 = 0.0;

		// Token: 0x0400199A RID: 6554
		[CompilerGenerated]
		private double double_4 = 0.0;

		// Token: 0x0400199B RID: 6555
		[CompilerGenerated]
		private double double_5 = 0.0;

		// Token: 0x0400199C RID: 6556
		[CompilerGenerated]
		private _CargoType enum16_0;

		// Token: 0x0400199D RID: 6557
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400199E RID: 6558
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400199F RID: 6559
		private Cargo[] cargo_0;

		// Token: 0x040019A0 RID: 6560
		private Collection<ActiveUnit> collection_0;

		// Token: 0x040019A1 RID: 6561
		[CompilerGenerated]
		private ObservableCollection<CargoOpsCargoItemViewModel> observableCollection_1;

		// Token: 0x040019A2 RID: 6562
		[CompilerGenerated]
		private CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel_1;

		// Token: 0x040019A3 RID: 6563
		[CompilerGenerated]
		private double double_6 = 0.0;

		// Token: 0x040019A4 RID: 6564
		[CompilerGenerated]
		private double double_7 = 0.0;

		// Token: 0x040019A5 RID: 6565
		[CompilerGenerated]
		private double double_8;

		// Token: 0x040019A6 RID: 6566
		[CompilerGenerated]
		private double double_9;

		// Token: 0x040019A7 RID: 6567
		[CompilerGenerated]
		private double double_10;

		// Token: 0x040019A8 RID: 6568
		[CompilerGenerated]
		private double double_11;

		// Token: 0x040019A9 RID: 6569
		[CompilerGenerated]
		private _CargoType enum16_1;

		// Token: 0x040019AA RID: 6570
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040019AB RID: 6571
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040019AC RID: 6572
		[CompilerGenerated]
		private DataTable dataTable_0;

		// Token: 0x040019AD RID: 6573
		[CompilerGenerated]
		private Class2535 class2535_0;

		// Token: 0x040019AE RID: 6574
		[CompilerGenerated]
		private Class2535 class2535_1;

		// Token: 0x040019AF RID: 6575
		[CompilerGenerated]
		private Class2535 class2535_2;

		// Token: 0x040019B0 RID: 6576
		[CompilerGenerated]
		private Class2535 class2535_3;

		// Token: 0x040019B1 RID: 6577
		[CompilerGenerated]
		private Class2535 class2535_4;

		// Token: 0x040019B2 RID: 6578
		[CompilerGenerated]
		private Class2535 class2535_5;

		// Token: 0x040019B3 RID: 6579
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x020008DA RID: 2266
		[CompilerGenerated]
		public sealed class Class2485
		{
			// Token: 0x060037F6 RID: 14326 RVA: 0x00120A08 File Offset: 0x0011EC08
			internal bool method_0(CargoOpsCargoItemViewModel I)
			{
				return Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(I.Cargo.GetCargo(), null, "DBID", new object[0], null, null, null), NewLateBinding.LateGet(this.cargoOpsCargoItemViewModel_0.Cargo.GetCargo(), null, "DBID", new object[0], null, null, null), false);
			}

			// Token: 0x060037F7 RID: 14327 RVA: 0x00120A08 File Offset: 0x0011EC08
			internal bool method_1(CargoOpsCargoItemViewModel I)
			{
				return Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(I.Cargo.GetCargo(), null, "DBID", new object[0], null, null, null), NewLateBinding.LateGet(this.cargoOpsCargoItemViewModel_0.Cargo.GetCargo(), null, "DBID", new object[0], null, null, null), false);
			}

			// Token: 0x040019CB RID: 6603
			public CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel_0;
		}

		// Token: 0x020008DB RID: 2267
		[CompilerGenerated]
		public sealed class Class2486
		{
			// Token: 0x060037F9 RID: 14329 RVA: 0x0001DD63 File Offset: 0x0001BF63
			public Class2486(CargoOpsViewModel.Class2486 arg0)
			{
				if (arg0 != null)
				{
					this.cargoOpsCargoItemViewModel_0 = arg0.cargoOpsCargoItemViewModel_0;
				}
			}

			// Token: 0x060037FA RID: 14330 RVA: 0x00120A60 File Offset: 0x0011EC60
			internal bool method_0(Cargo OC)
			{
				return Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(OC.GetCargo(), null, "DBID", new object[0], null, null, null), NewLateBinding.LateGet(this.cargoOpsCargoItemViewModel_0.Cargo.GetCargo(), null, "DBID", new object[0], null, null, null), false);
			}

			// Token: 0x040019CC RID: 6604
			public CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel_0;
		}

		// Token: 0x020008DC RID: 2268
		[CompilerGenerated]
		public sealed class Class2487
		{
			// Token: 0x060037FB RID: 14331 RVA: 0x0001DD7D File Offset: 0x0001BF7D
			public Class2487(CargoOpsViewModel.Class2487 arg0)
			{
				if (arg0 != null)
				{
					this.cargoOpsCargoItemViewModel_0 = arg0.cargoOpsCargoItemViewModel_0;
				}
			}

			// Token: 0x060037FC RID: 14332 RVA: 0x00120AB4 File Offset: 0x0011ECB4
			internal bool method_0(Cargo OC)
			{
				return Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(OC.GetCargo(), null, "DBID", new object[0], null, null, null), NewLateBinding.LateGet(this.cargoOpsCargoItemViewModel_0.Cargo.GetCargo(), null, "DBID", new object[0], null, null, null), false);
			}

			// Token: 0x040019CD RID: 6605
			public CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel_0;
		}

		// Token: 0x020008DD RID: 2269
		[CompilerGenerated]
		public sealed class Class2488
		{
			// Token: 0x060037FD RID: 14333 RVA: 0x0001DD97 File Offset: 0x0001BF97
			public Class2488(CargoOpsViewModel.Class2488 arg0)
			{
				if (arg0 != null)
				{
					this.keyValuePair_0 = arg0.keyValuePair_0;
				}
			}

			// Token: 0x060037FE RID: 14334 RVA: 0x0001DDB1 File Offset: 0x0001BFB1
			internal bool method_0(Cargo OC)
			{
				return Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(OC.GetCargo(), null, "DBID", new object[0], null, null, null), this.keyValuePair_0.Key, false);
			}

			// Token: 0x060037FF RID: 14335 RVA: 0x0001DDB1 File Offset: 0x0001BFB1
			internal bool method_1(Cargo OC)
			{
				return Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(OC.GetCargo(), null, "DBID", new object[0], null, null, null), this.keyValuePair_0.Key, false);
			}

			// Token: 0x040019CE RID: 6606
			public KeyValuePair<int, int> keyValuePair_0;
		}

		// Token: 0x020008DE RID: 2270
		[CompilerGenerated]
		public sealed class Class2489
		{
			// Token: 0x06003800 RID: 14336 RVA: 0x0001DDE3 File Offset: 0x0001BFE3
			public Class2489(CargoOpsViewModel.Class2489 arg0)
			{
				if (arg0 != null)
				{
					this.keyValuePair_0 = arg0.keyValuePair_0;
				}
			}

			// Token: 0x06003801 RID: 14337 RVA: 0x0001DDFD File Offset: 0x0001BFFD
			internal bool method_0(Cargo OC)
			{
				return Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(OC.GetCargo(), null, "DBID", new object[0], null, null, null), this.keyValuePair_0.Key, false);
			}

			// Token: 0x040019CF RID: 6607
			public KeyValuePair<int, int> keyValuePair_0;
		}
	}
}
