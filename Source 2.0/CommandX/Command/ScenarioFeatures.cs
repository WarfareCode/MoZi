using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns32;
using ns34;

namespace Command
{
	// Token: 0x0200001A RID: 26
	[DesignerGenerated]
	public sealed partial class ScenarioFeatures : Window, IComponentConnector
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00057B24 File Offset: 0x00055D24
		public ScenarioFeatures()
		{
			base.Loaded += new RoutedEventHandler(this.ScenarioFeatures_Loaded);
			base.KeyDown += new KeyEventHandler(this.ScenarioFeatures_KeyDown);
			base.Closing += new CancelEventHandler(this.ScenarioFeatures_Closing);
			this.InitializeComponent();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00057B74 File Offset: 0x00055D74
		private void ScenarioFeatures_Loaded(object sender, RoutedEventArgs e)
		{
			if (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit)
			{
				this.Button_OK.Visibility = Visibility.Visible;
				this.Button_Cancel.Visibility = Visibility.Visible;
				this.CB_GunfireControl.IsEnabled = true;
				this.CB_UnlimitedBaseMags.IsEnabled = true;
				if (LicenseChecker.IsFeatureSupported(Scenario.ScenarioFeatureOption.AircraftDamageModel))
				{
					this.Unlock_ACDamage.Visibility = Visibility.Collapsed;
					this.CB_ACDamage.IsEnabled = true;
					this.CB_ACDamage.Foreground = Brushes.White;
				}
				else
				{
					this.Unlock_ACDamage.Visibility = Visibility.Visible;
					this.CB_ACDamage.IsEnabled = false;
					this.CB_ACDamage.Foreground = Brushes.Gray;
				}
				if (LicenseChecker.IsFeatureSupported(Scenario.ScenarioFeatureOption.CargoOps))
				{
					this.Unlock_CargoOps.Visibility = Visibility.Collapsed;
					this.CB_CargoOps.IsEnabled = true;
					this.CB_CargoOps.Foreground = Brushes.White;
				}
				else
				{
					this.Unlock_CargoOps.Visibility = Visibility.Visible;
					this.CB_CargoOps.IsEnabled = false;
					this.CB_CargoOps.Foreground = Brushes.Gray;
				}
				if (LicenseChecker.IsFeatureSupported(Scenario.ScenarioFeatureOption.CommsDisruption))
				{
					this.Unlock_CommsDisruption.Visibility = Visibility.Collapsed;
					this.CB_CommsDisruption.IsEnabled = true;
					this.CB_CommsDisruption.Foreground = Brushes.White;
				}
				else
				{
					this.Unlock_CommsDisruption.Visibility = Visibility.Visible;
					this.CB_CommsDisruption.IsEnabled = false;
					this.CB_CommsDisruption.Foreground = Brushes.Gray;
				}
				if (LicenseChecker.IsFeatureSupported(Scenario.ScenarioFeatureOption.CommsJamming))
				{
					this.Unlock_CommsJam.Visibility = Visibility.Collapsed;
					this.CB_CommsJamming.IsEnabled = true;
					this.CB_CommsJamming.Foreground = Brushes.White;
				}
				else
				{
					this.Unlock_CommsJam.Visibility = Visibility.Visible;
					this.CB_CommsJamming.IsEnabled = false;
					this.CB_CommsJamming.Foreground = Brushes.Gray;
				}
				if (LicenseChecker.IsFeatureSupported(Scenario.ScenarioFeatureOption.EMP_Dir))
				{
					this.Unlock_EMP_Dir.Visibility = Visibility.Collapsed;
					this.CB_EMP_Dir.IsEnabled = true;
					this.CB_EMP_Dir.Foreground = Brushes.White;
				}
				else
				{
					this.Unlock_EMP_Dir.Visibility = Visibility.Visible;
					this.CB_EMP_Dir.IsEnabled = false;
					this.CB_EMP_Dir.Foreground = Brushes.Gray;
				}
				if (LicenseChecker.IsFeatureSupported(Scenario.ScenarioFeatureOption.EMP_Omni))
				{
					this.Unlock_EMP_Omni.Visibility = Visibility.Collapsed;
					this.CB_EMP_Omni.IsEnabled = true;
					this.CB_EMP_Omni.Foreground = Brushes.White;
				}
				else
				{
					this.Unlock_EMP_Omni.Visibility = Visibility.Visible;
					this.CB_EMP_Omni.IsEnabled = false;
					this.CB_EMP_Omni.Foreground = Brushes.Gray;
				}
				if (LicenseChecker.IsFeatureSupported(Scenario.ScenarioFeatureOption.HighEnergyLasers))
				{
					this.Unlock_HEL_Phase2.Visibility = Visibility.Collapsed;
					this.CB_HEL_Phase2.IsEnabled = true;
					this.CB_HEL_Phase2.Foreground = Brushes.White;
				}
				else
				{
					this.Unlock_HEL_Phase2.Visibility = Visibility.Visible;
					this.CB_HEL_Phase2.IsEnabled = false;
					this.CB_HEL_Phase2.Foreground = Brushes.Gray;
				}
				if (LicenseChecker.IsFeatureSupported(Scenario.ScenarioFeatureOption.HGV))
				{
					this.Unlock_HGV.Visibility = Visibility.Collapsed;
					this.CB_HGV.IsEnabled = true;
					this.CB_HGV.Foreground = Brushes.White;
				}
				else
				{
					this.Unlock_HGV.Visibility = Visibility.Visible;
					this.CB_HGV.IsEnabled = false;
					this.CB_HGV.Foreground = Brushes.Gray;
				}
				if (LicenseChecker.IsFeatureSupported(Scenario.ScenarioFeatureOption.RailgunOrHVP))
				{
					this.Unlock_Railgun.Visibility = Visibility.Collapsed;
					this.CB_Railgun.IsEnabled = true;
					this.CB_Railgun.Foreground = Brushes.White;
				}
				else
				{
					this.Unlock_Railgun.Visibility = Visibility.Visible;
					this.CB_Railgun.IsEnabled = false;
					this.CB_Railgun.Foreground = Brushes.Gray;
				}
			}
			else
			{
				this.Button_OK.Visibility = Visibility.Collapsed;
				this.Button_Cancel.Visibility = Visibility.Collapsed;
				this.CB_GunfireControl.IsEnabled = false;
				this.CB_UnlimitedBaseMags.IsEnabled = false;
				this.CB_CommsJamming.IsEnabled = false;
				this.CB_CommsDisruption.IsEnabled = false;
				this.CB_ACDamage.IsEnabled = false;
				this.CB_CargoOps.IsEnabled = false;
				this.CB_EMP_Dir.IsEnabled = false;
				this.CB_EMP_Omni.IsEnabled = false;
				this.CB_HEL_Phase2.IsEnabled = false;
				this.CB_HGV.IsEnabled = false;
				this.CB_Railgun.IsEnabled = false;
			}
			this.CB_GunfireControl.IsChecked = new bool?(Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.DetailedGunFireControl));
			this.CB_UnlimitedBaseMags.IsChecked = new bool?(Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags));
			this.CB_CommsJamming.IsChecked = new bool?(Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CommsJamming));
			this.CB_CommsDisruption.IsChecked = new bool?(Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CommsDisruption));
			this.CB_ACDamage.IsChecked = new bool?(Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.AircraftDamageModel));
			this.CB_CargoOps.IsChecked = new bool?(Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CargoOps));
			this.CB_EMP_Dir.IsChecked = new bool?(Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.EMP_Dir));
			this.CB_EMP_Omni.IsChecked = new bool?(Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.EMP_Omni));
			this.CB_HEL_Phase2.IsChecked = new bool?(Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.HighEnergyLasers));
			this.CB_HGV.IsChecked = new bool?(Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.HGV));
			this.CB_Railgun.IsChecked = new bool?(Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.RailgunOrHVP));
			base.Height = this.StackPanel1.Height;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00058128 File Offset: 0x00056328
		private void Button_OK_Click(object sender, RoutedEventArgs e)
		{
			if (this.CB_GunfireControl.IsChecked.GetValueOrDefault())
			{
				Client.GetClientScenario().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.DetailedGunFireControl);
			}
			else
			{
				Client.GetClientScenario().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.DetailedGunFireControl);
			}
			if (this.CB_UnlimitedBaseMags.IsChecked.GetValueOrDefault())
			{
				Client.GetClientScenario().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags);
			}
			else
			{
				Client.GetClientScenario().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags);
			}
			if (this.CB_CommsJamming.IsChecked.GetValueOrDefault())
			{
				Client.GetClientScenario().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.CommsJamming);
			}
			else
			{
				Client.GetClientScenario().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.CommsJamming);
			}
			if (this.CB_ACDamage.IsChecked.GetValueOrDefault())
			{
				Client.GetClientScenario().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.AircraftDamageModel);
			}
			else
			{
				Client.GetClientScenario().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.AircraftDamageModel);
			}
			if (this.CB_CommsDisruption.IsChecked.GetValueOrDefault())
			{
				Client.GetClientScenario().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.CommsDisruption);
			}
			else
			{
				Client.GetClientScenario().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.CommsDisruption);
			}
			if (this.CB_CargoOps.IsChecked.GetValueOrDefault())
			{
				Client.GetClientScenario().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.CargoOps);
			}
			else
			{
				Client.GetClientScenario().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.CargoOps);
			}
			if (this.CB_EMP_Dir.IsChecked.GetValueOrDefault())
			{
				Client.GetClientScenario().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.EMP_Dir);
			}
			else
			{
				Client.GetClientScenario().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.EMP_Dir);
			}
			if (this.CB_EMP_Omni.IsChecked.GetValueOrDefault())
			{
				Client.GetClientScenario().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.EMP_Omni);
			}
			else
			{
				Client.GetClientScenario().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.EMP_Omni);
			}
			if (this.CB_HEL_Phase2.IsChecked.GetValueOrDefault())
			{
				Client.GetClientScenario().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.HighEnergyLasers);
			}
			else
			{
				Client.GetClientScenario().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.HighEnergyLasers);
			}
			if (this.CB_HGV.IsChecked.GetValueOrDefault())
			{
				Client.GetClientScenario().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.HGV);
			}
			else
			{
				Client.GetClientScenario().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.HGV);
			}
			if (this.CB_Railgun.IsChecked.GetValueOrDefault())
			{
				Client.GetClientScenario().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.RailgunOrHVP);
			}
			else
			{
				Client.GetClientScenario().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.RailgunOrHVP);
			}
			CommandFactory.GetCommandMain().GetMainForm().UpdateScenarioFeatureVisibility();
			base.Close();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00004D7B File Offset: 0x00002F7B
		private void Button_Cancel_Click(object sender, RoutedEventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000583E4 File Offset: 0x000565E4
		private void ScenarioFeatures_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Select && base.Visibility == Visibility.Visible)
			{
				base.Close();
			}
			else if (e.Key == Key.Delete)
			{
				Visibility arg_38_0 = base.Visibility;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00004D83 File Offset: 0x00002F83
		private void ScenarioFeatures_Closing(object sender, CancelEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004D94 File Offset: 0x00002F94
		private void Unlock_ACDamage_Click(object sender, RoutedEventArgs e)
		{
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.ChainsOfWar;
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().Show();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004D94 File Offset: 0x00002F94
		private void Unlock_CargoOps_Click(object sender, RoutedEventArgs e)
		{
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.ChainsOfWar;
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().Show();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004D94 File Offset: 0x00002F94
		private void Unlock_CommsDisruption_Click(object sender, RoutedEventArgs e)
		{
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.ChainsOfWar;
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().Show();
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004DB5 File Offset: 0x00002FB5
		private void Unlock_CommsJam_Click(object sender, RoutedEventArgs e)
		{
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.ProfessionalEdition;
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().Show();
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00004DB5 File Offset: 0x00002FB5
		private void Unlock_HGV_Click(object sender, RoutedEventArgs e)
		{
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.ProfessionalEdition;
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().Show();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004D94 File Offset: 0x00002F94
		private void Unlock_Railgun_Click(object sender, RoutedEventArgs e)
		{
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.ChainsOfWar;
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().Show();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004D94 File Offset: 0x00002F94
		private void Unlock_HEL_Phase2_Click(object sender, RoutedEventArgs e)
		{
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.ChainsOfWar;
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().Show();
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004DB5 File Offset: 0x00002FB5
		private void Unlock_EMP_Dir_Click(object sender, RoutedEventArgs e)
		{
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.ProfessionalEdition;
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().Show();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004D94 File Offset: 0x00002F94
		private void Unlock_EMP_Omni_Click(object sender, RoutedEventArgs e)
		{
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.ChainsOfWar;
			CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().Show();
		}

		

		// Token: 0x04000074 RID: 116
		private bool bool_0;

		
	}
}
