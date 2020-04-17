using System;
using System.ComponentModel;
using System.Threading;
using Command_Core;
using ns4;

namespace Command
{
	// Token: 0x020008CA RID: 2250
	[Attribute0, Attribute2, Attribute3]
	public sealed class CargoMissionAssignedUnitViewModel : INotifyPropertyChanged
	{
		// Token: 0x1400001D RID: 29
		// (add) Token: 0x0600373F RID: 14143 RVA: 0x0011EFF8 File Offset: 0x0011D1F8
		// (remove) Token: 0x06003740 RID: 14144 RVA: 0x0011F034 File Offset: 0x0011D234
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

		// Token: 0x06003741 RID: 14145 RVA: 0x0001D5E7 File Offset: 0x0001B7E7
		public CargoMissionAssignedUnitViewModel(ActiveUnit theUnit)
		{
			this.theUnit = theUnit;
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x0011F070 File Offset: 0x0011D270
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04001960 RID: 6496
		public ActiveUnit theUnit;

		// Token: 0x04001961 RID: 6497
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
