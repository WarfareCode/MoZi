using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using ns34;

namespace Command
{
	// Token: 0x02000018 RID: 24
	[DesignerGenerated]
	public sealed partial class LicenseTweaker : Window, IComponentConnector
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x00004D36 File Offset: 0x00002F36
		public LicenseTweaker()
		{
			base.Loaded += new RoutedEventHandler(this.LicenseTweaker_Loaded);
			this.InitializeComponent();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000576B0 File Offset: 0x000558B0
		private void LicenseTweaker_Loaded(object sender, RoutedEventArgs e)
		{
			this.CB_CMANOBase.IsChecked = new bool?(LicenseChecker.HoldLicense(LicenseChecker.License.CMANOBase));
			this.CB_NorthernInferno.IsChecked = new bool?(LicenseChecker.HoldLicense(LicenseChecker.License.NorthernInferno));
			this.CB_ChainsOfWar.IsChecked = new bool?(LicenseChecker.HoldLicense(LicenseChecker.License.ChainsOfWar));
			this.CB_CLIVE1.IsChecked = new bool?(LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE1));
			this.CB_CLIVE2.IsChecked = new bool?(LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE2));
			this.CB_CLIVE3.IsChecked = new bool?(LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE3));
			this.CB_CLIVE4.IsChecked = new bool?(LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE4));
			this.CB_CLIVE5.IsChecked = new bool?(LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE5));
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00057770 File Offset: 0x00055970
		private void CB_CMANOBase_Checked(object sender, RoutedEventArgs e)
		{
			if (this.CB_CMANOBase.IsChecked.GetValueOrDefault())
			{
				LicenseChecker.AddLicense(LicenseChecker.License.CMANOBase);
			}
			else
			{
				LicenseChecker.RemoveLicense(LicenseChecker.License.CMANOBase);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000577A4 File Offset: 0x000559A4
		private void CB_NorthernInferno_Checked(object sender, RoutedEventArgs e)
		{
			if (this.CB_NorthernInferno.IsChecked.GetValueOrDefault())
			{
				LicenseChecker.AddLicense(LicenseChecker.License.NorthernInferno);
			}
			else
			{
				LicenseChecker.RemoveLicense(LicenseChecker.License.NorthernInferno);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000577D8 File Offset: 0x000559D8
		private void CB_ChainsOfWar_Checked(object sender, RoutedEventArgs e)
		{
			if (this.CB_ChainsOfWar.IsChecked.GetValueOrDefault())
			{
				LicenseChecker.AddLicense(LicenseChecker.License.ChainsOfWar);
			}
			else
			{
				LicenseChecker.RemoveLicense(LicenseChecker.License.ChainsOfWar);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0005780C File Offset: 0x00055A0C
		private void CB_CLIVE1_Checked(object sender, RoutedEventArgs e)
		{
			if (this.CB_CLIVE1.IsChecked.GetValueOrDefault())
			{
				LicenseChecker.AddLicense(LicenseChecker.License.CLIVE1);
			}
			else
			{
				LicenseChecker.RemoveLicense(LicenseChecker.License.CLIVE1);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00057840 File Offset: 0x00055A40
		private void CB_CLIVE2_Checked(object sender, RoutedEventArgs e)
		{
			if (this.CB_CLIVE2.IsChecked.GetValueOrDefault())
			{
				LicenseChecker.AddLicense(LicenseChecker.License.CLIVE2);
			}
			else
			{
				LicenseChecker.RemoveLicense(LicenseChecker.License.CLIVE2);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00057874 File Offset: 0x00055A74
		private void CB_CLIVE3_Checked(object sender, RoutedEventArgs e)
		{
			if (this.CB_CLIVE3.IsChecked.GetValueOrDefault())
			{
				LicenseChecker.AddLicense(LicenseChecker.License.CLIVE3);
			}
			else
			{
				LicenseChecker.RemoveLicense(LicenseChecker.License.CLIVE3);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000578A8 File Offset: 0x00055AA8
		private void CB_CLIVE4_Checked(object sender, RoutedEventArgs e)
		{
			if (this.CB_CLIVE4.IsChecked.GetValueOrDefault())
			{
				LicenseChecker.AddLicense(LicenseChecker.License.CLIVE4);
			}
			else
			{
				LicenseChecker.RemoveLicense(LicenseChecker.License.CLIVE4);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000578DC File Offset: 0x00055ADC
		private void CB_CLIVE5_Checked(object sender, RoutedEventArgs e)
		{
			if (this.CB_CLIVE5.IsChecked.GetValueOrDefault())
			{
				LicenseChecker.AddLicense(LicenseChecker.License.CLIVE5);
			}
			else
			{
				LicenseChecker.RemoveLicense(LicenseChecker.License.CLIVE5);
			}
		}

			
		// Token: 0x04000068 RID: 104
		private bool bool_0;

		
	}
}
