using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace Command
{
	// Token: 0x0200092F RID: 2351
	[Attribute0, Attribute2, Attribute3]
	public sealed class EditCargoCargoItemViewModel : INotifyPropertyChanged
	{
		// Token: 0x1400001F RID: 31
		// (add) Token: 0x060039AE RID: 14766 RVA: 0x00122268 File Offset: 0x00120468
		// (remove) Token: 0x060039AF RID: 14767 RVA: 0x001222A4 File Offset: 0x001204A4
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

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060039B0 RID: 14768 RVA: 0x001222E0 File Offset: 0x001204E0
		// (set) Token: 0x060039B1 RID: 14769 RVA: 0x0001EA64 File Offset: 0x0001CC64
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
					this.vmethod_0("Cargo");
				}
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060039B2 RID: 14770 RVA: 0x001222F8 File Offset: 0x001204F8
		// (set) Token: 0x060039B3 RID: 14771 RVA: 0x0001EA91 File Offset: 0x0001CC91
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

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060039B4 RID: 14772 RVA: 0x00122310 File Offset: 0x00120510
		public string Name
		{
			get
			{
				return Conversions.ToString(this.Quantity) + "x " + this.Cargo.GetCargoName();
			}
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x00122340 File Offset: 0x00120540
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04001A68 RID: 6760
		[CompilerGenerated]
		private Cargo cargo_0;

		// Token: 0x04001A69 RID: 6761
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04001A6A RID: 6762
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
