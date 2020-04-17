using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x02000CE3 RID: 3299
	public sealed partial class AboutDialog : Form
	{
		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06006C1E RID: 27678 RVA: 0x003CC9F0 File Offset: 0x003CABF0
		private static string AssemblyTitle
		{
			get
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				object[] customAttributes = executingAssembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				string result;
				if (customAttributes.Length != 0)
				{
					result = ((AssemblyTitleAttribute)customAttributes[0]).Title;
				}
				else
				{
					result = executingAssembly.GetName().Name;
				}
				return result;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06006C1F RID: 27679 RVA: 0x003CCA3C File Offset: 0x003CAC3C
		private static string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06006C20 RID: 27680 RVA: 0x003CCA60 File Offset: 0x003CAC60
		private static string FileVersion
		{
			get
			{
				return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06006C21 RID: 27681 RVA: 0x003CCA84 File Offset: 0x003CAC84
		private static string AssemblyDescription
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
				string result;
				if (customAttributes.Length != 0)
				{
					result = ((AssemblyDescriptionAttribute)customAttributes[0]).Description;
				}
				else
				{
					result = string.Empty;
				}
				return result;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06006C22 RID: 27682 RVA: 0x003CCAC8 File Offset: 0x003CACC8
		private static string AssemblyProduct
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				string result;
				if (customAttributes.Length != 0)
				{
					result = ((AssemblyProductAttribute)customAttributes[0]).Product;
				}
				else
				{
					result = string.Empty;
				}
				return result;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06006C23 RID: 27683 RVA: 0x003CCB0C File Offset: 0x003CAD0C
		private static string AssemblyCopyright
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				string result;
				if (customAttributes.Length != 0)
				{
					result = ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
				}
				else
				{
					result = string.Empty;
				}
				return result;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06006C24 RID: 27684 RVA: 0x003CCB50 File Offset: 0x003CAD50
		private static string AssemblyCompany
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				string result;
				if (customAttributes.Length != 0)
				{
					result = ((AssemblyCompanyAttribute)customAttributes[0]).Company;
				}
				else
				{
					result = string.Empty;
				}
				return result;
			}
		}

		// Token: 0x06006C25 RID: 27685 RVA: 0x003CCB94 File Offset: 0x003CAD94
		public AboutDialog()
		{
			this.InitializeComponent();
			this.Text = string.Format(this.Text, AboutDialog.AssemblyTitle);
			this.labelProductName.Text = AboutDialog.AssemblyProduct;
			this.labelVersion.Text = string.Format(this.labelVersion.Text, AboutDialog.AssemblyVersion, AboutDialog.FileVersion);
			this.labelCompanyName.Text = AboutDialog.AssemblyCompany;
			this.textBoxDescription.Text = AboutDialog.AssemblyDescription;
			this.labelCompanyName.Visible = false;
			this.textBoxDescription.Visible = false;
			this.linkLabel1.Links.Remove(this.linkLabel1.Links[0]);
			this.linkLabel1.Links.Add(0, this.linkLabel1.Text.Length, "http://powerschemeswitcher.codeplex.com");
		}

		// Token: 0x06006C26 RID: 27686 RVA: 0x0002E48B File Offset: 0x0002C68B
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()));
		}
	}
}
