using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using ns32;

namespace Command
{
	// Token: 0x02000019 RID: 25
	public sealed partial class UnlicensedFeaturesWindow : Window, IComponentConnector
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00004D56 File Offset: 0x00002F56
		public UnlicensedFeaturesWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004D64 File Offset: 0x00002F64
		private void CloseButton_Click(object sender, RoutedEventArgs e)
		{
			base.Close();
			CommandFactory.GetCommandMain().GetLoadScenario().Show();
		}

		// Token: 0x04000072 RID: 114
		private bool bool_0;


	}
}
