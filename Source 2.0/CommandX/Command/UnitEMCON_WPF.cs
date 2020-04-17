using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace Command
{
	// Token: 0x02000870 RID: 2160
	[DesignerGenerated, Attribute0, Attribute2, Attribute3]
	public sealed partial  class UnitEMCON_WPF : UserControl, INotifyPropertyChanged, IComponentConnector
	{
		// Token: 0x06003546 RID: 13638 RVA: 0x0001C87A File Offset: 0x0001AA7A
		public UnitEMCON_WPF()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x0011C9D0 File Offset: 0x0011ABD0
		public void method_0(ActiveUnit theUnit)
		{
			if (Information.IsNothing(theUnit))
			{
				base.IsEnabled = false;
			}
			else
			{
				base.IsEnabled = true;
				if (base.DataContext == null)
				{
					base.DataContext = new UnitEMCONViewModel(theUnit);
				}
				else
				{
					UnitEMCONViewModel unitEMCONViewModel = (UnitEMCONViewModel)base.DataContext;
					if (unitEMCONViewModel.theUnit == theUnit)
					{
						unitEMCONViewModel.method_3();
					}
					else
					{
						unitEMCONViewModel.theUnit = theUnit;
						unitEMCONViewModel.method_3();
					}
				}
			}
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x0011CA44 File Offset: 0x0011AC44
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06003549 RID: 13641 RVA: 0x0011CA6C File Offset: 0x0011AC6C
		// (remove) Token: 0x0600354A RID: 13642 RVA: 0x0011CAA8 File Offset: 0x0011ACA8
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

		
		// Token: 0x040018A5 RID: 6309
		private bool bool_0;

		// Token: 0x040018A6 RID: 6310
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

	}
}
