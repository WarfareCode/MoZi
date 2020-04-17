using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using ns34;

namespace Command
{
	// 授权许可对话框
	public sealed class LicenseDialogViewModel : INotifyPropertyChanged
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000001 RID: 1 RVA: 0x000550B0 File Offset: 0x000532B0
		// (remove) Token: 0x06000002 RID: 2 RVA: 0x000550EC File Offset: 0x000532EC
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

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00004878 File Offset: 0x00002A78
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00004880 File Offset: 0x00002A80
		public bool BeginScenarioEnabled
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
					this.vmethod_0("BeginScenarioEnabled");
				}
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00055128 File Offset: 0x00053328
		// (set) Token: 0x06000006 RID: 6 RVA: 0x000048A2 File Offset: 0x00002AA2
		public ObservableCollection<LicenseViewModel> Items
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
					this.vmethod_0("Items");
				}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00055140 File Offset: 0x00053340
		[Obsolete("Used for design time only", true)]
		public LicenseDialogViewModel()
		{
			this.Items = new ObservableCollection<LicenseViewModel>();
			this.Items.Add(new LicenseViewModel
			{
				Title = "Aircraft Damage model",
				Subtitle = "",
				Required = true,
				Owned = false,
				AssociatedLicense = LicenseChecker.License.ChainsOfWar
			});
			this.Items.Add(new LicenseViewModel
			{
				Title = "Cargo Operations",
				Subtitle = "",
				Required = true,
				Owned = false,
				AssociatedLicense = LicenseChecker.License.ChainsOfWar
			});
			this.Items.Add(new LicenseViewModel
			{
				Title = "Communications Disruption",
				Subtitle = "",
				Required = true,
				Owned = false,
				AssociatedLicense = LicenseChecker.License.ChainsOfWar
			});
			this.Items.Add(new LicenseViewModel
			{
				Title = "Tactical EMP (Omnidirectional)",
				Subtitle = "",
				Required = true,
				Owned = false,
				AssociatedLicense = LicenseChecker.License.ChainsOfWar
			});
			this.Items.Add(new LicenseViewModel
			{
				Title = "High-Energy Lasers (Phase 2)",
				Subtitle = "",
				Required = true,
				Owned = false,
				AssociatedLicense = LicenseChecker.License.ChainsOfWar
			});
			this.Items.Add(new LicenseViewModel
			{
				Title = "Railguns / HVPs",
				Subtitle = "",
				Required = true,
				Owned = false,
				AssociatedLicense = LicenseChecker.License.ChainsOfWar
			});
			this.BeginScenarioEnabled = false;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000552E4 File Offset: 0x000534E4
		public LicenseDialogViewModel(List<Scenario.ScenarioFeatureOption> theFeatureList)
		{
			this.Items = new ObservableCollection<LicenseViewModel>();
			using (List<Scenario.ScenarioFeatureOption>.Enumerator enumerator = theFeatureList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					switch (enumerator.Current)
					{
					case Scenario.ScenarioFeatureOption.AircraftDamageModel:
						this.Items.Add(new LicenseViewModel
						{
							Title = "Aircraft Damage model",
							Subtitle = "",
							Required = true,
							Owned = false,
							AssociatedLicense = LicenseChecker.License.ChainsOfWar
						});
						break;
					case Scenario.ScenarioFeatureOption.CargoOps:
						this.Items.Add(new LicenseViewModel
						{
							Title = "Cargo Operations",
							Subtitle = "",
							Required = true,
							Owned = false,
							AssociatedLicense = LicenseChecker.License.ChainsOfWar
						});
						break;
					case Scenario.ScenarioFeatureOption.CommsJamming:
						this.Items.Add(new LicenseViewModel
						{
							Title = "Communications Jamming",
							Subtitle = "",
							Required = true,
							Owned = false,
							AssociatedLicense = LicenseChecker.License.ProfessionalEdition
						});
						break;

                        // 通信干扰
					case Scenario.ScenarioFeatureOption.CommsDisruption:
						this.Items.Add(new LicenseViewModel
						{
							Title = "Communications Disruption，通信干扰",
							Subtitle = "",
							Required = true,
							Owned = false,
							AssociatedLicense = LicenseChecker.License.ChainsOfWar
						});
						break;
					case Scenario.ScenarioFeatureOption.EMP_Omni:
						this.Items.Add(new LicenseViewModel
						{
							Title = "Tactical EMP (Omnidirectional)",
							Subtitle = "",
							Required = true,
							Owned = false,
							AssociatedLicense = LicenseChecker.License.ChainsOfWar
						});
						break;

                        // 定向能
					case Scenario.ScenarioFeatureOption.EMP_Dir:
						this.Items.Add(new LicenseViewModel
						{
							Title = "Tactical EMP (Directional)，定向能",
							Subtitle = "",
							Required = true,
							Owned = false,
							AssociatedLicense = LicenseChecker.License.ProfessionalEdition
						});
						break;
                        
                        // 高能激光
					case Scenario.ScenarioFeatureOption.HighEnergyLasers:
						this.Items.Add(new LicenseViewModel
						{
							Title = "High-Energy Lasers (Phase 2)，高能激光",
							Subtitle = "",
							Required = true,
							Owned = false,
							AssociatedLicense = LicenseChecker.License.ChainsOfWar
						});
						break;

                        // 电磁轨道炮，超高速炮弹
					case Scenario.ScenarioFeatureOption.RailgunOrHVP:
						this.Items.Add(new LicenseViewModel
						{
							Title = "Railguns / HVPs，电磁轨道炮，超高速炮弹",
							Subtitle = "",
							Required = true,
							Owned = false,
							AssociatedLicense = LicenseChecker.License.ChainsOfWar
						});
						break;

                        // 高超声速滑翔器
					case Scenario.ScenarioFeatureOption.HGV:
						this.Items.Add(new LicenseViewModel
						{
							Title = "Hypersonic Glide Vehicles，高超声速滑翔弹",
							Subtitle = "",
							Required = true,
							Owned = false,
							AssociatedLicense = LicenseChecker.License.ProfessionalEdition
						});
						break;
					}
				}
			}
			this.BeginScenarioEnabled = false;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00055600 File Offset: 0x00053800
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000001 RID: 1
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000002 RID: 2
		[CompilerGenerated]
		private ObservableCollection<LicenseViewModel> observableCollection_0;

		// Token: 0x04000003 RID: 3
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
