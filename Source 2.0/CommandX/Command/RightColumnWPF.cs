using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using Odyssey.Controls;

namespace Command
{
	// Token: 0x02000828 RID: 2088
	[DesignerGenerated]
	public sealed partial class RightColumnWPF : UserControl, IComponentConnector
	{
		// Token: 0x06003377 RID: 13175 RVA: 0x0001B8FE File Offset: 0x00019AFE
		public RightColumnWPF()
		{
			this.bool_0 = true;
			this.bool_1 = false;
			this.bool_2 = false;
			this.InitializeComponent();
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x0001B921 File Offset: 0x00019B21
		public void method_0()
		{
			this.bool_0 = false;
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x0001B92A File Offset: 0x00019B2A
		public void method_1()
		{
			this.bool_0 = true;
			this.method_2(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit());
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00119BC8 File Offset: 0x00117DC8
		public void method_2(Scenario scenario_0, Side side_0, Unit unit_)
		{
			if (this.bool_0)
			{
				try
				{
					this.bool_1 = true;
					this.Expander_UnitStatus.IsEnabled = !Information.IsNothing(unit_);
					if (!Information.IsNothing(scenario_0) && !Information.IsNothing(side_0) && !Information.IsNothing(unit_))
					{
						if (unit_.IsActiveUnit() && (unit_.GetSide(false) == Client.GetClientSide() || Client.GetMap().IsGodsEyeView()))
						{
							if (unit_.IsGroup)
							{
								this.Expander_UnitStatus.Header = "作战编队状态";
								this.Expander_UnitWeapons.Header = "作战编队武器";
								this.Expander_UnitFuel.Header = "作战编队燃油";
								this.Expander_UnitEMCON.Header = "作战编队电磁管控";
							}
							else
							{
								this.Expander_UnitStatus.Header = "作战单元状态";
								this.Expander_UnitWeapons.Header = "作战单元武器";
								this.Expander_UnitFuel.Header = "作战单元燃油";
								this.Expander_UnitEMCON.Header = "作战单元电磁管控";
							}
							this.Expander_UnitWeapons.Visibility = Visibility.Visible;
							this.Expander_UnitFuel.Visibility = Visibility.Visible;
							this.Expander_UnitEMCON.Visibility = Visibility.Visible;
							this.Expander_UnitDoctrine.Visibility = Visibility.Visible;
							this.WPFControl_FuelPanel.method_0((ActiveUnit)unit_);
							this.WPFControl_UnitWeapons.method_0((ActiveUnit)unit_);
							this.WPFControl_UnitEMCON.method_0((ActiveUnit)unit_);
							this.WPFControl_UnitDoctrine.method_1((ActiveUnit)unit_);
						}
						else if (unit_.IsContact())
						{
							this.Expander_UnitStatus.Header = "探测目标状态";
							this.Expander_UnitWeapons.Visibility = Visibility.Collapsed;
							this.Expander_UnitFuel.Visibility = Visibility.Collapsed;
							this.Expander_UnitEMCON.Visibility = Visibility.Collapsed;
							this.Expander_UnitDoctrine.Visibility = Visibility.Collapsed;
						}
						else
						{
							this.WPFControl_FuelPanel.method_0(null);
							this.WPFControl_UnitWeapons.method_0(null);
							this.WPFControl_UnitEMCON.method_0(null);
							this.WPFControl_UnitDoctrine.method_1(null);
						}
						if (this.Expander_UnitStatus.IsExpanded)
						{
							this.WPFControl_UnitStatus.ShowUnitStatus(scenario_0, side_0, unit_);
						}
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				finally
				{
					this.bool_1 = false;
				}
			}
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x00119E48 File Offset: 0x00118048
		public double method_3(UIElement uielement_0)
		{
			PresentationSource presentationSource = PresentationSource.FromVisual(uielement_0);
			Matrix transformToDevice;
			if (presentationSource != null)
			{
				transformToDevice = presentationSource.CompositionTarget.TransformToDevice;
			}
			else
			{
				using (HwndSource hwndSource = new HwndSource(default(HwndSourceParameters)))
				{
					transformToDevice = hwndSource.CompositionTarget.TransformToDevice;
				}
			}
			return transformToDevice.M11;
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x00119EB8 File Offset: 0x001180B8
		public void method_4()
		{
			double num = this.method_3(this);
			try
			{
				this.MyScrollViewer.MaxHeight = (double)(CommandFactory.GetCommandMain().GetMainForm().GetMapBox().Height - 30) / num;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (!this.bool_2)
			{
				this.bool_2 = true;
				Client.elementHost.Width = (int)Math.Round(270.0 * num);
			}
			MainForm mainForm = (MainForm)Client.elementHost.Parent;
			int width = mainForm.Size.Width;
			int width2 = Client.elementHost.Width;
			Client.elementHost.Left = width - width2 - 14;
			Client.elementHost.Top = mainForm.vmethod_875().Top + mainForm.vmethod_875().Height;
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x00119F9C File Offset: 0x0011819C
		private void StackPanel_Main_LayoutUpdated(object sender, EventArgs e)
		{
			double actualHeight = this.StackPanel_Main.ActualHeight;
			if (Client.elementHost != null)
			{
				if (actualHeight > (double)(CommandFactory.GetCommandMain().GetMainForm().GetMapBox().Height - 75))
				{
					this.MyScrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
				}
				if (actualHeight < (double)(CommandFactory.GetCommandMain().GetMainForm().GetMapBox().Height - 75) * 0.9)
				{
					this.MyScrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
				}
			}
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x0001B948 File Offset: 0x00019B48
		private void Expander_UnitStatus_Expanded(object sender, RoutedEventArgs e)
		{
			this.method_2(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit());
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x0001B948 File Offset: 0x00019B48
		private void Expander_UnitWeapons_Expanded(object sender, RoutedEventArgs e)
		{
			this.method_2(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit());
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x0001B948 File Offset: 0x00019B48
		private void Expander_UnitFuel_Expanded(object sender, RoutedEventArgs e)
		{
			this.method_2(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit());
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x0001B948 File Offset: 0x00019B48
		private void Expander_UnitEMCON_Expanded(object sender, RoutedEventArgs e)
		{
			this.method_2(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit());
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x0001B948 File Offset: 0x00019B48
		private void Expander_UnitDoctrine_Expanded(object sender, RoutedEventArgs e)
		{
			this.method_2(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit());
		}

		
		
		// Token: 0x040017DF RID: 6111
		private bool bool_0;

		// Token: 0x040017E0 RID: 6112
		public bool bool_1;

		// Token: 0x040017E1 RID: 6113
		private bool bool_2;

		// Token: 0x040017E2 RID: 6114
		private bool bool_3;

	}
}
