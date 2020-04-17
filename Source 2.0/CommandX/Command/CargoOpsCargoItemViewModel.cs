using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns4;

namespace Command
{
	// Token: 0x02000887 RID: 2183
	[Attribute0, Attribute2, Attribute3]
	public sealed class CargoOpsCargoItemViewModel : INotifyPropertyChanged
	{
		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060035C6 RID: 13766 RVA: 0x0011D2E4 File Offset: 0x0011B4E4
		// (remove) Token: 0x060035C7 RID: 13767 RVA: 0x0011D320 File Offset: 0x0011B520
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

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060035C8 RID: 13768 RVA: 0x0011D35C File Offset: 0x0011B55C
		// (set) Token: 0x060035C9 RID: 13769 RVA: 0x0011D374 File Offset: 0x0011B574
		public Cargo Cargo
		{
			[CompilerGenerated]
			get
			{
				return this.cargo_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.cargo_0 != value)
				{
					this.cargo_0 = value;
					this.vmethod_0("Name");
					this.vmethod_0("CargoType");
					this.vmethod_0("MassPerUnit");
					this.vmethod_0("AreaPerUnit");
					this.vmethod_0("CrewPerUnit");
					this.vmethod_0("Cargo");
				}
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060035CA RID: 13770 RVA: 0x0011D3D8 File Offset: 0x0011B5D8
		// (set) Token: 0x060035CB RID: 13771 RVA: 0x0001CC1E File Offset: 0x0001AE1E
		public int Quantity
		{
			[CompilerGenerated]
			get
			{
				return this.int_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_0 != value)
				{
					this.int_0 = value;
					this.vmethod_0("Name");
					this.vmethod_0("Quantity");
				}
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060035CC RID: 13772 RVA: 0x0011D3F0 File Offset: 0x0011B5F0
		// (set) Token: 0x060035CD RID: 13773 RVA: 0x0001CC4B File Offset: 0x0001AE4B
		public int InitialQuantity
		{
			[CompilerGenerated]
			get
			{
				return this.int_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_1 != value)
				{
					this.int_1 = value;
					this.vmethod_0("InitialQuantity");
				}
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060035CE RID: 13774 RVA: 0x0001CC6D File Offset: 0x0001AE6D
		// (set) Token: 0x060035CF RID: 13775 RVA: 0x0001CC75 File Offset: 0x0001AE75
		public bool CargoTypeLimited
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
					this.vmethod_0("CargoTypeLimitedBrush");
					this.vmethod_0("CargoTypeLimited");
				}
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060035D0 RID: 13776 RVA: 0x0011D408 File Offset: 0x0011B608
		public Brush CargoTypeLimitedBrush
		{
			get
			{
				Brush result;
				if (this.CargoTypeLimited)
				{
					result = Brushes.Black;
				}
				else
				{
					result = Brushes.Red;
				}
				return result;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x0011D434 File Offset: 0x0011B634
		public string Name
		{
			get
			{
				return Conversions.ToString(this.Quantity) + "x " + this.Cargo.GetCargoName();
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060035D2 RID: 13778 RVA: 0x0011D464 File Offset: 0x0011B664
		public _CargoType CargoType
		{
			get
			{
				return ((Mount)this.Cargo.GetCargo()).Cargo_Type;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060035D3 RID: 13779 RVA: 0x0011D488 File Offset: 0x0011B688
		public double MassPerUnit
		{
			get
			{
				return (double)((Mount)this.Cargo.GetCargo()).Cargo_Mass;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060035D4 RID: 13780 RVA: 0x0011D4B0 File Offset: 0x0011B6B0
		public double AreaPerUnit
		{
			get
			{
				return (double)((Mount)this.Cargo.GetCargo()).Cargo_Area;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x0011D4D8 File Offset: 0x0011B6D8
		public double CrewPerUnit
		{
			get
			{
				return (double)((Mount)this.Cargo.GetCargo()).Cargo_Crew;
			}
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x0011D500 File Offset: 0x0011B700
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040018D6 RID: 6358
		[CompilerGenerated]
		private Cargo cargo_0;

		// Token: 0x040018D7 RID: 6359
		[CompilerGenerated]
		private int int_0;

		// Token: 0x040018D8 RID: 6360
		[CompilerGenerated]
		private int int_1;

		// Token: 0x040018D9 RID: 6361
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040018DA RID: 6362
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
