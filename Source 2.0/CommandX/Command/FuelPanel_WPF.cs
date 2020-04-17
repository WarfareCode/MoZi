using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace Command
{
	// Token: 0x020007F9 RID: 2041
	[DesignerGenerated]
	public sealed partial class FuelPanel_WPF : UserControl, IComponentConnector
	{
		// Token: 0x06003238 RID: 12856 RVA: 0x0001B0BE File Offset: 0x000192BE
		public FuelPanel_WPF()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x0010D910 File Offset: 0x0010BB10
		public void method_0(ActiveUnit activeUnit)
		{
			if (base.DataContext == null)
			{
				base.DataContext = new FuelViewModel(activeUnit);
			}
			else
			{
				FuelViewModel fuelViewModel = (FuelViewModel)base.DataContext;
				if (fuelViewModel.theUnit == activeUnit)
				{
					fuelViewModel.Refresh();
				}
				else
				{
					base.DataContext = new FuelViewModel(activeUnit);
				}
			}
		}

	
	}
}
