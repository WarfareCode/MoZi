using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace Command
{
	// Token: 0x0200089D RID: 2205
	[DesignerGenerated, Attribute0, Attribute2, Attribute3]
	public sealed partial class UnitWeapons_WPF : UserControl, INotifyPropertyChanged, IComponentConnector
	{
		// Token: 0x0600364E RID: 13902 RVA: 0x0001CF9C File Offset: 0x0001B19C
		public UnitWeapons_WPF()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x0011E1E8 File Offset: 0x0011C3E8
		public void method_0(ActiveUnit theUnit)
		{
			if (base.DataContext == null)
			{
				base.DataContext = new UnitWeaponViewModel(theUnit);
			}
			else
			{
				UnitWeaponViewModel unitWeaponViewModel = (UnitWeaponViewModel)base.DataContext;
				if (unitWeaponViewModel.theUnit == theUnit)
				{
					unitWeaponViewModel.method_4();
				}
				else
				{
					base.DataContext = new UnitWeaponViewModel(theUnit);
				}
			}
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x0011E240 File Offset: 0x0011C440
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06003651 RID: 13905 RVA: 0x0011E268 File Offset: 0x0011C468
		// (remove) Token: 0x06003652 RID: 13906 RVA: 0x0011E2A4 File Offset: 0x0011C4A4
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


		// Token: 0x04001908 RID: 6408
		private bool bool_0;

		// Token: 0x04001909 RID: 6409
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

	}
}
