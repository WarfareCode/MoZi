using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace Command
{
	// Token: 0x020007BC RID: 1980
	[Attribute0, Attribute2, Attribute3]
	public sealed class SubmarineFuelViewModel : INotifyPropertyChanged
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060030F6 RID: 12534 RVA: 0x0010B46C File Offset: 0x0010966C
		// (remove) Token: 0x060030F7 RID: 12535 RVA: 0x0010B4A8 File Offset: 0x001096A8
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

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060030F8 RID: 12536 RVA: 0x0010B4E4 File Offset: 0x001096E4
		// (set) Token: 0x060030F9 RID: 12537 RVA: 0x0001A40F File Offset: 0x0001860F
		public Visibility VisibilityDiesel
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_0 != value)
				{
					this.visibility_0 = value;
					this.vmethod_0("VisibilityDiesel");
				}
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060030FA RID: 12538 RVA: 0x0010B4FC File Offset: 0x001096FC
		// (set) Token: 0x060030FB RID: 12539 RVA: 0x0001A431 File Offset: 0x00018631
		public double PercentageDiesel
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
					this.vmethod_0("PercentageDiesel");
				}
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060030FC RID: 12540 RVA: 0x0010B514 File Offset: 0x00109714
		// (set) Token: 0x060030FD RID: 12541 RVA: 0x0001A453 File Offset: 0x00018653
		public string PercentageDieselText
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
					this.vmethod_0("PercentageDieselText");
				}
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060030FE RID: 12542 RVA: 0x0010B52C File Offset: 0x0010972C
		// (set) Token: 0x060030FF RID: 12543 RVA: 0x0001A479 File Offset: 0x00018679
		public FontWeight FontWeightDiesel
		{
			[CompilerGenerated]
			get
			{
				return this.fontWeight_0;
			}
			[CompilerGenerated]
			set
			{
				if (!(this.fontWeight_0 == value))
				{
					this.fontWeight_0 = value;
					this.vmethod_0("FontWeightDiesel");
				}
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06003100 RID: 12544 RVA: 0x0010B544 File Offset: 0x00109744
		// (set) Token: 0x06003101 RID: 12545 RVA: 0x0001A49E File Offset: 0x0001869E
		public Visibility VisibilityBattery
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_1 != value)
				{
					this.visibility_1 = value;
					this.vmethod_0("VisibilityBattery");
				}
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x0010B55C File Offset: 0x0010975C
		// (set) Token: 0x06003103 RID: 12547 RVA: 0x0001A4C0 File Offset: 0x000186C0
		public double PercentageBattery
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
					this.vmethod_0("PercentageBattery");
				}
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x0010B574 File Offset: 0x00109774
		// (set) Token: 0x06003105 RID: 12549 RVA: 0x0001A4E2 File Offset: 0x000186E2
		public string PercentageBatteryText
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
					this.vmethod_0("PercentageBatteryText");
				}
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x0010B58C File Offset: 0x0010978C
		// (set) Token: 0x06003107 RID: 12551 RVA: 0x0001A508 File Offset: 0x00018708
		public FontWeight FontWeightBattery
		{
			[CompilerGenerated]
			get
			{
				return this.fontWeight_1;
			}
			[CompilerGenerated]
			set
			{
				if (!(this.fontWeight_1 == value))
				{
					this.fontWeight_1 = value;
					this.vmethod_0("FontWeightBattery");
				}
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x0010B5A4 File Offset: 0x001097A4
		// (set) Token: 0x06003109 RID: 12553 RVA: 0x0001A52D File Offset: 0x0001872D
		public Visibility VisibilityAIP
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_2 != value)
				{
					this.visibility_2 = value;
					this.vmethod_0("VisibilityAIP");
				}
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x0010B5BC File Offset: 0x001097BC
		// (set) Token: 0x0600310B RID: 12555 RVA: 0x0001A54F File Offset: 0x0001874F
		public double PercentageAIP
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
					this.vmethod_0("PercentageAIP");
				}
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x0010B5D4 File Offset: 0x001097D4
		// (set) Token: 0x0600310D RID: 12557 RVA: 0x0001A571 File Offset: 0x00018771
		public string PercentageAIPText
		{
			[CompilerGenerated]
			get
			{
				return this.string_2;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.string_2, value, StringComparison.Ordinal))
				{
					this.string_2 = value;
					this.vmethod_0("PercentageAIPText");
				}
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x0010B5EC File Offset: 0x001097EC
		// (set) Token: 0x0600310F RID: 12559 RVA: 0x0001A597 File Offset: 0x00018797
		public FontWeight FontWeightAIP
		{
			[CompilerGenerated]
			get
			{
				return this.fontWeight_2;
			}
			[CompilerGenerated]
			set
			{
				if (!(this.fontWeight_2 == value))
				{
					this.fontWeight_2 = value;
					this.vmethod_0("FontWeightAIP");
				}
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x0010B604 File Offset: 0x00109804
		// (set) Token: 0x06003111 RID: 12561 RVA: 0x0001A5BC File Offset: 0x000187BC
		public string EnduranceText
		{
			[CompilerGenerated]
			get
			{
				return this.string_3;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.string_3, value, StringComparison.Ordinal))
				{
					this.string_3 = value;
					this.vmethod_0("EnduranceText");
				}
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06003112 RID: 12562 RVA: 0x0010B61C File Offset: 0x0010981C
		// (set) Token: 0x06003113 RID: 12563 RVA: 0x0001A5E2 File Offset: 0x000187E2
		public double Percentage
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
					this.vmethod_0("Percentage");
				}
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06003114 RID: 12564 RVA: 0x0010B634 File Offset: 0x00109834
		// (set) Token: 0x06003115 RID: 12565 RVA: 0x0001A604 File Offset: 0x00018804
		public string UnitName
		{
			[CompilerGenerated]
			get
			{
				return this.string_4;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.string_4, value, StringComparison.Ordinal))
				{
					this.string_4 = value;
					this.vmethod_0("UnitName");
				}
			}
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x0010B64C File Offset: 0x0010984C
		[Obsolete("Used for design time only", true)]
		public SubmarineFuelViewModel()
		{
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x0010B6A0 File Offset: 0x001098A0
		[Attribute0, Attribute2]
		public void Refresh()
		{
			this.UnitName = this.theUnit.Name;
			if (this.theUnit.GetFuelRecs().Count<FuelRec>() != 0)
			{
				Submarine submarine = this.theUnit;
				if (submarine.IsNuclearPropelled())
				{
					this.VisibilityDiesel = Visibility.Collapsed;
					this.VisibilityBattery = Visibility.Collapsed;
					this.VisibilityAIP = Visibility.Collapsed;
				}
				else
				{
					this.VisibilityDiesel = Visibility.Visible;
					FuelRec fuelRec = this.theUnit.GetFuelRecs().Where(SubmarineFuelViewModel.FuelRecFunc0).ElementAtOrDefault(0);
					if (!Information.IsNothing(fuelRec))
					{
						this.PercentageDiesel = (double)((int)Math.Round((double)(fuelRec.GetRatioLeft() * 100f)));
						this.PercentageDieselText = Conversions.ToString(Math.Round((double)fuelRec.CurrentQuantity, 0)) + "燃油单元剩余";
					}
					this.VisibilityBattery = Visibility.Visible;
					FuelRec fuelRec2 = this.theUnit.GetFuelRecs().Where(SubmarineFuelViewModel.FuelRecFunc1).ElementAtOrDefault(0);
					if (!Information.IsNothing(fuelRec2))
					{
						this.PercentageBattery = (double)((int)Math.Round((double)(fuelRec2.GetRatioLeft() * 100f)));
						this.PercentageBatteryText = Conversions.ToString(Math.Round((double)fuelRec2.CurrentQuantity, 0)) + "燃油单元剩余";
					}
					if (submarine.method_155())
					{
						this.VisibilityAIP = Visibility.Visible;
						FuelRec fuelRec3 = this.theUnit.GetFuelRecs().Where(SubmarineFuelViewModel.FuelRecFunc2).ElementAtOrDefault(0);
						this.PercentageAIP = (double)((int)Math.Round((double)(fuelRec3.GetRatioLeft() * 100f)));
						this.PercentageAIPText = Conversions.ToString(Math.Round((double)fuelRec3.CurrentQuantity, 0)) + "燃油单元剩余";
					}
					else
					{
						this.VisibilityAIP = Visibility.Collapsed;
					}
					FuelRec._FuelType fuelType = submarine.GetSubmarineAI().GetFuelType(submarine.GetEngine());
					this.FontWeightDiesel = FontWeights.Normal;
					this.FontWeightAIP = FontWeights.Normal;
					this.FontWeightBattery = FontWeights.Normal;
					if (fuelType != FuelRec._FuelType.DieselFuel)
					{
						if (fuelType != FuelRec._FuelType.Battery)
						{
							if (fuelType == FuelRec._FuelType.AirIndepedent)
							{
								this.FontWeightAIP = FontWeights.Bold;
								this.Percentage = this.PercentageAIP;
							}
						}
						else
						{
							this.FontWeightBattery = FontWeights.Bold;
							this.Percentage = this.PercentageBattery;
						}
					}
					else
					{
						this.FontWeightDiesel = FontWeights.Bold;
						this.Percentage = this.PercentageDiesel;
					}
					long num = submarine.method_154(this.theUnit.GetThrottle(), null, new float?((float)((int)Math.Round((double)this.theUnit.GetDesiredSpeed()))), new float?(this.theUnit.GetCurrentAltitude_ASL(false)), submarine.GetEngine(), submarine.method_133());
					string str;
					if (this.theUnit.GetThrottle() == ActiveUnit.Throttle.FullStop)
					{
						str = "作战单元处于停车状态";
					}
					else
					{
						str = Misc.GetTimeString(num, Aircraft_AirOps._Maintenance.const_0, false, true) + ", " + Conversions.ToString(Math.Round((double)((float)num * this.theUnit.GetCurrentSpeed() / 3600f), 0)) + "海里";
					}
					this.EnduranceText = "续航力: " + str;
				}
			}
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x0010B998 File Offset: 0x00109B98
		public SubmarineFuelViewModel(Submarine theUnit)
		{
			this.theUnit = theUnit;
			this.Refresh();
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x0010B9F8 File Offset: 0x00109BF8
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040016C0 RID: 5824
		public static Func<FuelRec, bool> FuelRecFunc0 = (FuelRec theRec) => theRec.FuelType == FuelRec._FuelType.DieselFuel;

		// Token: 0x040016C1 RID: 5825
		public static Func<FuelRec, bool> FuelRecFunc1 = (FuelRec theRec) => theRec.FuelType == FuelRec._FuelType.Battery;

		// Token: 0x040016C2 RID: 5826
		public static Func<FuelRec, bool> FuelRecFunc2 = (FuelRec theRec) => theRec.FuelType == FuelRec._FuelType.AirIndepedent;

		// Token: 0x040016C3 RID: 5827
		[CompilerGenerated]
		private Visibility visibility_0;

		// Token: 0x040016C4 RID: 5828
		[CompilerGenerated]
		private double double_0;

		// Token: 0x040016C5 RID: 5829
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040016C6 RID: 5830
		[CompilerGenerated]
		private FontWeight fontWeight_0;

		// Token: 0x040016C7 RID: 5831
		[CompilerGenerated]
		private Visibility visibility_1;

		// Token: 0x040016C8 RID: 5832
		[CompilerGenerated]
		private double double_1;

		// Token: 0x040016C9 RID: 5833
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040016CA RID: 5834
		[CompilerGenerated]
		private FontWeight fontWeight_1;

		// Token: 0x040016CB RID: 5835
		[CompilerGenerated]
		private Visibility visibility_2;

		// Token: 0x040016CC RID: 5836
		[CompilerGenerated]
		private double double_2 = 0.0;

		// Token: 0x040016CD RID: 5837
		[CompilerGenerated]
		private string string_2 = "";

		// Token: 0x040016CE RID: 5838
		[CompilerGenerated]
		private FontWeight fontWeight_2;

		// Token: 0x040016CF RID: 5839
		[CompilerGenerated]
		private string string_3 = "";

		// Token: 0x040016D0 RID: 5840
		[CompilerGenerated]
		private double double_3 = 0.0;

		// Token: 0x040016D1 RID: 5841
		[CompilerGenerated]
		private string string_4 = "";

		// Token: 0x040016D2 RID: 5842
		public Submarine theUnit;

		// Token: 0x040016D3 RID: 5843
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
