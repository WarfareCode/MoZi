using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using ns4;

namespace Command
{
	// Token: 0x020008B4 RID: 2228
	[Attribute0, Attribute2, Attribute3]
	public sealed class CargoMissionMothershipUnitViewModel : INotifyPropertyChanged
	{
		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060036C8 RID: 14024 RVA: 0x0011E970 File Offset: 0x0011CB70
		// (remove) Token: 0x060036C9 RID: 14025 RVA: 0x0011E9AC File Offset: 0x0011CBAC
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

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x0011E9E8 File Offset: 0x0011CBE8
		// (set) Token: 0x060036CB RID: 14027 RVA: 0x0001D2B8 File Offset: 0x0001B4B8
		public string Name
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
					this.vmethod_0("Name");
				}
			}
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x0001D2DE File Offset: 0x0001B4DE
		public CargoMissionMothershipUnitViewModel(ActiveUnit theUnit)
		{
			this.theUnit = theUnit;
			this.Name = theUnit.Name;
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x0011EA00 File Offset: 0x0011CC00
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04001935 RID: 6453
		public ActiveUnit theUnit;

		// Token: 0x04001936 RID: 6454
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04001937 RID: 6455
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
