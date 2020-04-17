using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media.Imaging;
using Command_Core;
using ns32;
using ns33;
using ns35;
using ns4;

namespace Command
{
	// Token: 0x0200094B RID: 2379
	[Attribute0, Attribute2, Attribute3]
	public sealed class RealismDialogViewModel : INotifyPropertyChanged
	{
		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06003A70 RID: 14960 RVA: 0x001237FC File Offset: 0x001219FC
		// (remove) Token: 0x06003A71 RID: 14961 RVA: 0x00123838 File Offset: 0x00121A38
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

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x00123874 File Offset: 0x00121A74
		// (set) Token: 0x06003A73 RID: 14963 RVA: 0x0001F0AC File Offset: 0x0001D2AC
		public string ScenarioLength
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
					this.vmethod_0("ScenarioLength");
				}
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06003A74 RID: 14964 RVA: 0x0012388C File Offset: 0x00121A8C
		// (set) Token: 0x06003A75 RID: 14965 RVA: 0x0001F0D2 File Offset: 0x0001D2D2
		public ObservableCollection<SpecificRealismSettingViewModel> Items
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

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06003A76 RID: 14966 RVA: 0x001238A4 File Offset: 0x00121AA4
		// (set) Token: 0x06003A77 RID: 14967 RVA: 0x0001F0F4 File Offset: 0x0001D2F4
		public Class2535 OKCommand
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
					this.vmethod_0("OKCommand");
				}
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06003A78 RID: 14968 RVA: 0x001238BC File Offset: 0x00121ABC
		// (set) Token: 0x06003A79 RID: 14969 RVA: 0x0001F116 File Offset: 0x0001D316
		public BitmapImage YesIcon
		{
			[CompilerGenerated]
			get
			{
				return this.bitmapImage_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.bitmapImage_0 != value)
				{
					this.bitmapImage_0 = value;
					this.vmethod_0("YesIcon");
				}
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06003A7A RID: 14970 RVA: 0x001238D4 File Offset: 0x00121AD4
		// (set) Token: 0x06003A7B RID: 14971 RVA: 0x0001F138 File Offset: 0x0001D338
		public BitmapImage NoIcon
		{
			[CompilerGenerated]
			get
			{
				return this.bitmapImage_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.bitmapImage_1 != value)
				{
					this.bitmapImage_1 = value;
					this.vmethod_0("NoIcon");
				}
			}
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x001238EC File Offset: 0x00121AEC
		[Obsolete("Used for design time only", true)]
		public RealismDialogViewModel()
		{
			this.Items = new ObservableCollection<SpecificRealismSettingViewModel>();
            this.OKCommand = new Class2535(new Action<object>(this.method_1));
            //ZSP ERR this.YesIcon = Class2536.smethod_0(Class2470.smethod_7());
            //ZSP ERR this.NoIcon = Class2536.smethod_0(Class2470.smethod_5());
            this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "高精度武器火控算法",
				Subtitle = "枪炮和其他非制导武器的精度受多种因素影响(常为负面影响).",
				Active = true
			});
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "弹药库资源不受限",
				Subtitle = "海、空军弹药可用性不设限",
				Active = false
			});
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "通信干扰",
				Subtitle = "武器和平台之间的通信可以受到干扰.",
				Active = true
			});
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "气象条件影响空中作战行动",
				Subtitle = "气象条件影响作战飞机出动、武器效能等.",
				Active = true
			});
			this.ScenarioLength = "想定持续时间: " + Misc.GetTimeString((long)Math.Round(new TimeSpan(6, 0, 0).TotalSeconds), Aircraft_AirOps._Maintenance.const_0, false, false);
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x00123A2C File Offset: 0x00121C2C
		public RealismDialogViewModel(RealismDialog form, Scenario myScenario)
		{
			this.Items = new ObservableCollection<SpecificRealismSettingViewModel>();
            //ZSP ERR Class2535 中事件属性问题
            this.OKCommand = new Class2535(new Action<object>(this.method_2));
            //ZSP ERR this.YesIcon = Class2536.smethod_0(Class2470.smethod_7());
            //ZSP ERR this.NoIcon = Class2536.smethod_0(Class2470.smethod_5());
            this.realismDialog_0 = form;
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "高精度武器火控算法",
				Subtitle = "枪炮和其他非制导武器的精度受多种因素影响(常为负面影响).",
				Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.DetailedGunFireControl)
			});
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "弹药库资源不受限",
				Subtitle = "海、空军弹药可用性不设限.",
				Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags)
			});
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "飞机毁伤模型",
				Subtitle = "高精度飞机战斗毁伤建模",
				Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.AircraftDamageModel)
			});

            if (GameGeneral.bProfessionEdition)
            {
                this.Items.Add(new SpecificRealismSettingViewModel
                {
                    Title = "投送行动",
                    Subtitle = "考虑武器装备、作战物资等投送.",
                    Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CargoOps)
                });
            }

            if (GameGeneral.bProfessionEdition)
			{
				this.Items.Add(new SpecificRealismSettingViewModel
				{
					Title = "通信干扰",
					Subtitle = "武器和平台之间的通信可以受到干扰.",
					Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CommsJamming)
				});
			}
            if (GameGeneral.bProfessionEdition)
            {
                this.Items.Add(new SpecificRealismSettingViewModel
                {
                    Title = "通信摧毁",
                    Subtitle = "武器和平台之间的通信可以受到摧毁.",
                    Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CommsDisruption)
                });
            }
            //this.Items.Add(new SpecificRealismSettingViewModel
            //{
            //	Title = "夜间与气象影响空中作战行动",
            //	Subtitle = "夜间和气象条件影响作战飞机出动、武器效能等.",
            //	Active = false
            //});
            if (GameGeneral.bProfessionEdition)
            {
                this.Items.Add(new SpecificRealismSettingViewModel
                {
                    Title = "战术电磁脉冲武器(全向)",
                    Subtitle = "可以使用战术电磁脉冲武器(全向).",
                    Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.EMP_Omni)
                });
            }
            if (GameGeneral.bProfessionEdition)
            {
                this.Items.Add(new SpecificRealismSettingViewModel
                {
                    Title = "战术电磁脉冲武器(有向)",
                    Subtitle = "可以使用战术电磁脉冲武器(有向).",
                    Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.EMP_Dir)
                });
            }
            if (GameGeneral.bProfessionEdition)
            {
                this.Items.Add(new SpecificRealismSettingViewModel
                {
                    Title = "高能激光器(阶段2)",
                    Subtitle = "可以使用高能激光器.",
                    Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.HighEnergyLasers)
                });
            }
            if (GameGeneral.bProfessionEdition)
            {
                this.Items.Add(new SpecificRealismSettingViewModel
                {
                    Title = "电磁轨道炮+超高速弹",
                    Subtitle = "可以使用电磁轨道炮+超高速弹.",
                    Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.RailgunOrHVP)
                });
            }
            if (GameGeneral.bProfessionEdition)
            {
                this.Items.Add(new SpecificRealismSettingViewModel
                {
                    Title = "高超声速临近空间滑翔弹",
                    Subtitle = "可以使用高超声速临近空间滑翔弹.",
                    Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.HGV)
                });
            }
            this.ScenarioLength = "想定持续时间: " + Misc.GetTimeString((long)Math.Round(myScenario.GetDuration().TotalSeconds), Aircraft_AirOps._Maintenance.const_0, false, false);
		}

		// Token: 0x06003A7E RID: 14974 RVA: 0x0001F15A File Offset: 0x0001D35A
		public void method_0()
		{
			this.realismDialog_0.Close();
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x0001F167 File Offset: 0x0001D367
		[CompilerGenerated]
		private void method_1(object a0)
		{
			this.method_0();
		}

		// Token: 0x06003A80 RID: 14976 RVA: 0x0001F167 File Offset: 0x0001D367
		[CompilerGenerated]
		private void method_2(object a0)
		{
			this.method_0();
		}

		// Token: 0x06003A81 RID: 14977 RVA: 0x00123BDC File Offset: 0x00121DDC
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04001AB7 RID: 6839
		private RealismDialog realismDialog_0;

		// Token: 0x04001AB8 RID: 6840
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04001AB9 RID: 6841
		[CompilerGenerated]
		private ObservableCollection<SpecificRealismSettingViewModel> observableCollection_0;

		// Token: 0x04001ABA RID: 6842
		[CompilerGenerated]
		private Class2535 class2535_0;

		// Token: 0x04001ABB RID: 6843
		[CompilerGenerated]
		private BitmapImage bitmapImage_0;

		// Token: 0x04001ABC RID: 6844
		[CompilerGenerated]
		private BitmapImage bitmapImage_1;

		// Token: 0x04001ABD RID: 6845
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
