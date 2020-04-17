using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace Command
{
	// 燃料查看
	[Attribute0, Attribute2, Attribute3]
	public sealed class FuelViewModel : INotifyPropertyChanged
	{
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060031C6 RID: 12742 RVA: 0x0010CCB4 File Offset: 0x0010AEB4
		// (remove) Token: 0x060031C7 RID: 12743 RVA: 0x0010CCF0 File Offset: 0x0010AEF0
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

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060031C8 RID: 12744 RVA: 0x0010CD2C File Offset: 0x0010AF2C
		// (set) Token: 0x060031C9 RID: 12745 RVA: 0x0001AC7A File Offset: 0x00018E7A
		public ObservableCollection<object> Items
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

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x0010CD44 File Offset: 0x0010AF44
		// (set) Token: 0x060031CB RID: 12747 RVA: 0x0001AC9C File Offset: 0x00018E9C
		public object SelectedItem
		{
			[CompilerGenerated]
			get
			{
				return this.object_0;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.object_0, value))
				{
					this.object_0 = RuntimeHelpers.GetObjectValue(value);
					this.vmethod_0("SelectedItem");
				}
			}
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x0010CD5C File Offset: 0x0010AF5C
		[Obsolete("Used for design time only", true)]
		public FuelViewModel()
		{
			this.Items = new ObservableCollection<object>();
			AircraftFuelViewModel aircraftFuelViewModel = new AircraftFuelViewModel();
			aircraftFuelViewModel.Percentage = 50.0;
			aircraftFuelViewModel.Text = "Test Text";
			aircraftFuelViewModel.UnitName = "Aircraft Unit";
			this.Items.Add(aircraftFuelViewModel);
			ShipFuelViewModel shipFuelViewModel = new ShipFuelViewModel();
			shipFuelViewModel.Percentage = 25.0;
			shipFuelViewModel.Text = "Test Text";
			shipFuelViewModel.UnitName = "Ship Unit";
			this.Items.Add(shipFuelViewModel);
			SubmarineFuelViewModel submarineFuelViewModel = new SubmarineFuelViewModel();
			submarineFuelViewModel.Percentage = 50.0;
			submarineFuelViewModel.EnduranceText = "Test Text";
			submarineFuelViewModel.UnitName = "Submarine Unit";
			this.Items.Add(submarineFuelViewModel);
			this.SelectedItem = RuntimeHelpers.GetObjectValue(this.Items.First<object>());
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x0010CE38 File Offset: 0x0010B038
		private void method_0(ActiveUnit theUnit)
		{
			FuelViewModel.Class2477 @class = new FuelViewModel.Class2477();
			@class.activeUnit_0 = theUnit;
			object obj = RuntimeHelpers.GetObjectValue(this.Items.FirstOrDefault(new Func<object, bool>(@class.method_0)));
			if (obj == null)
			{
				if (@class.activeUnit_0 is Aircraft)
				{
					obj = new AircraftFuelViewModel((Aircraft)@class.activeUnit_0);
					this.Items.Add(RuntimeHelpers.GetObjectValue(obj));
				}
				else if (@class.activeUnit_0 is Submarine)
				{
					obj = new SubmarineFuelViewModel((Submarine)@class.activeUnit_0);
					this.Items.Add(RuntimeHelpers.GetObjectValue(obj));
				}
				else if (@class.activeUnit_0 is Ship)
				{
					obj = new ShipFuelViewModel((Ship)@class.activeUnit_0);
					this.Items.Add(RuntimeHelpers.GetObjectValue(obj));
				}
			}
			else if (obj is AircraftFuelViewModel)
			{
				((AircraftFuelViewModel)obj).Refresh();
			}
			else if (obj is SubmarineFuelViewModel)
			{
				((SubmarineFuelViewModel)obj).Refresh();
			}
			else if (obj is ShipFuelViewModel)
			{
				((ShipFuelViewModel)obj).Refresh();
			}
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x0010CF78 File Offset: 0x0010B178
		[Attribute0, Attribute2]
		public void Refresh()
		{
			if (this.theUnit is Group)
			{
				using (IEnumerator<KeyValuePair<string, ActiveUnit>> enumerator = ((Group)this.theUnit).GetUnitsInGroup().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, ActiveUnit> current = enumerator.Current;
						this.method_0(current.Value);
					}
					goto IL_63;
				}
			}
			this.method_0(this.theUnit);
			IL_63:
			if (this.SelectedItem == null & this.Items.Count != 0)
			{
				this.SelectedItem = RuntimeHelpers.GetObjectValue(this.Items.First<object>());
			}
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x0001ACC6 File Offset: 0x00018EC6
		public FuelViewModel(ActiveUnit theUnit)
		{
			this.Items = new ObservableCollection<object>();
			this.theUnit = theUnit;
			this.Refresh();
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x0010D030 File Offset: 0x0010B230
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400170F RID: 5903
		[CompilerGenerated]
		private ObservableCollection<object> observableCollection_0;

		// Token: 0x04001710 RID: 5904
		[CompilerGenerated]
		private object object_0;

		// Token: 0x04001711 RID: 5905
		public ActiveUnit theUnit;

		// Token: 0x04001712 RID: 5906
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x020007DB RID: 2011
		[CompilerGenerated]
		public sealed class Class2477
		{
			// Token: 0x060031D1 RID: 12753 RVA: 0x0001ACE6 File Offset: 0x00018EE6
			internal bool method_0(object s)
			{
				return NewLateBinding.LateGet(s, null, "theUnit", new object[0], null, null, null) == this.activeUnit_0;
			}

			// Token: 0x04001713 RID: 5907
			public ActiveUnit activeUnit_0;
		}
	}
}
