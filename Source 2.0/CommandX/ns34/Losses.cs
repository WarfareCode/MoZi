using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x02000A0E RID: 2574
	[DesignerGenerated]
	public sealed partial class Losses : CommandForm
	{
		// Token: 0x06004F19 RID: 20249 RVA: 0x001FD608 File Offset: 0x001FB808
		public Losses()
		{
			base.Load += new EventHandler(this.Losses_Load);
			base.KeyDown += new KeyEventHandler(this.Losses_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.Losses_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x001FD988 File Offset: 0x001FBB88
		[CompilerGenerated]
		internal  TextBox vmethod_0()
		{
			return this.textBox_0;
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x0002528A File Offset: 0x0002348A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TextBox textBox_1)
		{
			this.textBox_0 = textBox_1;
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x001FD9A0 File Offset: 0x001FBBA0
		[CompilerGenerated]
		internal  ToolStrip vmethod_2()
		{
			return this.toolStrip_0;
		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x00025293 File Offset: 0x00023493
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStrip toolStrip_1)
		{
			this.toolStrip_0 = toolStrip_1;
		}

		// Token: 0x06004F20 RID: 20256 RVA: 0x001FD9B8 File Offset: 0x001FBBB8
		[CompilerGenerated]
		internal  ToolStripButton vmethod_4()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x001FD9D0 File Offset: 0x001FBBD0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripButton toolStripButton_2)
		{
			EventHandler value = new EventHandler(this.method_2);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_2;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x001FDA1C File Offset: 0x001FBC1C
		[CompilerGenerated]
		internal  ToolStripButton vmethod_6()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x001FDA34 File Offset: 0x001FBC34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripButton toolStripButton_2)
		{
			EventHandler value = new EventHandler(this.method_3);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_2;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x001FDA80 File Offset: 0x001FBC80
		private void Losses_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_2().Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.vmethod_0().Clear();
			Side[] sides = Client.GetClientScenario().GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side_ = sides[i];
					this.method_1(side_);
				}
			}
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x001FDAF0 File Offset: 0x001FBCF0
		private static string smethod_0(Scenario scenario_0, KeyValuePair<string, HashSet<string>> keyValuePair_0)
		{
			string[] array = keyValuePair_0.Key.ToString().Split(new char[]
			{
				'_'
			});
			string result = "";
			string left = array[0].ToString();
			if (Operators.CompareString(left, "Aircraft", false) != 0)
			{
				if (Operators.CompareString(left, "Ship", false) != 0)
				{
					if (Operators.CompareString(left, "Submarine", false) != 0)
					{
						if (Operators.CompareString(left, "Facility", false) != 0)
						{
							if (Operators.CompareString(left, "FacilityAimpoint", false) == 0)
							{
								if (Operators.CompareString(array[1], "0", false) == 0)
								{
									result = "Non-identifiable land aimpoint - sorry!";
								}
								else
								{
									int iD_ = Conversions.ToInteger(array[1]);
									SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
									result = Misc.smethod_11(DBFunctions.GetMountName(iD_, ref sQLiteConnection));
								}
							}
						}
						else
						{
							result = Misc.smethod_11(scenario_0.Cache_Facilities_DT.Select("ID=" + array[1])[0]["Name"].ToString());
						}
					}
					else
					{
						result = Misc.smethod_11(scenario_0.Cache_Subs_DT.Select("ID=" + array[1])[0]["Name"].ToString());
					}
				}
				else
				{
					result = Misc.smethod_11(scenario_0.Cache_Ships_DT.Select("ID=" + array[1])[0]["Name"].ToString());
				}
			}
			else
			{
				result = Misc.smethod_11(scenario_0.Cache_Aircraft_DT.Select("ID=" + array[1])[0]["Name"].ToString());
			}
			return result;
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x001FDCA4 File Offset: 0x001FBEA4
		private static string smethod_1(Scenario scenario_0, KeyValuePair<int, int> keyValuePair_0)
		{
			return Misc.smethod_11(scenario_0.Cache_Weapons_DT.Select("ID=" + Conversions.ToString(keyValuePair_0.Key))[0]["Name"].ToString());
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x0002529C File Offset: 0x0002349C
		private void method_1(Side side_0)
		{
			this.vmethod_0().Text = this.vmethod_0().Text + Losses.GetLossesAndExpendituresStatistics(side_0, Client.GetClientScenario());
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x001FDCEC File Offset: 0x001FBEEC
		public static string GetLossesAndExpendituresStatistics(Side side_0, Scenario scenario_0)
		{
			Losses.Class2522 @class = new Losses.Class2522(null);
			@class.scenario_0 = scenario_0;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SIDE: " + side_0.GetSideName() + "\r\n===========================================================\r\n\r\n");
			stringBuilder.Append("LOSSES:\r\n-------------------------------\r\n");
			List<KeyValuePair<string, HashSet<string>>> list = side_0.m_AAR.Losses.OrderBy(new Func<KeyValuePair<string, HashSet<string>>, string>(@class.method_0)).ToList<KeyValuePair<string, HashSet<string>>>();
			List<KeyValuePair<string, HashSet<string>>>.Enumerator enumerator = list.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, HashSet<string>> current = enumerator.Current;
					stringBuilder.Append(Conversions.ToString(current.Value.Count) + "x " + Losses.smethod_0(@class.scenario_0, current) + "\r\n");
				}
			}
			finally
			{
				IDisposable disposable = enumerator;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			stringBuilder.Append("\r\n\r\nEXPENDITURES:\r\n------------------\r\n");
			List<KeyValuePair<int, int>> list2 = side_0.m_AAR.Expenditures.OrderBy(new Func<KeyValuePair<int, int>, string>(@class.method_1)).ToList<KeyValuePair<int, int>>();
			foreach (KeyValuePair<int, int> current2 in list2)
			{
				stringBuilder.Append(current2.Value.ToString() + "x " + Losses.smethod_1(@class.scenario_0, current2) + "\r\n");
			}
			stringBuilder.Append("\r\n\r\n\r\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x001FDE84 File Offset: 0x001FC084
		private void method_2(object sender, EventArgs e)
		{
			Side[] sides = Client.GetClientScenario().GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					side.m_AAR.Losses.Clear();
					side.m_AAR.Expenditures.Clear();
				}
				this.vmethod_0().Clear();
				Side[] sides2 = Client.GetClientScenario().GetSides();
				for (int j = 0; j < sides2.Length; j++)
				{
					Side side_ = sides2[j];
					this.method_1(side_);
				}
			}
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x001FDF08 File Offset: 0x001FC108
		private void Losses_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (!base.Visible || (e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.End && e.KeyCode != Keys.Home && (e.KeyCode != Keys.C || e.Modifiers != Keys.Control) && (e.KeyCode != Keys.X || e.Modifiers != Keys.Control) && (e.KeyCode != Keys.V || e.Modifiers != Keys.Control)))
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x00004D83 File Offset: 0x00002F83
		private void Losses_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004F2C RID: 20268 RVA: 0x001FDFD0 File Offset: 0x001FC1D0
		private void method_3(object sender, EventArgs e)
		{
			Side[] sides = Client.GetClientScenario().GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					side.ChangeScore(Client.GetClientScenario(), null, 0);
					side.ScoringLogs.Clear();
				}
				Interaction.MsgBox("Score points for all sides have been reset to 0.", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x04002552 RID: 9554
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04002553 RID: 9555
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x04002554 RID: 9556
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04002555 RID: 9557
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x02000A0F RID: 2575
		[CompilerGenerated]
		public sealed class Class2522
		{
			// Token: 0x06004F2D RID: 20269 RVA: 0x000252C4 File Offset: 0x000234C4
			public Class2522(Losses.Class2522 class2522_0)
			{
				if (class2522_0 != null)
				{
					this.scenario_0 = class2522_0.scenario_0;
				}
			}

			// Token: 0x06004F2E RID: 20270 RVA: 0x001FE024 File Offset: 0x001FC224
			internal string method_0(KeyValuePair<string, HashSet<string>> keyValuePair_0)
			{
				return Losses.smethod_0(this.scenario_0, keyValuePair_0);
			}

			// Token: 0x06004F2F RID: 20271 RVA: 0x001FE040 File Offset: 0x001FC240
			internal string method_1(KeyValuePair<int, int> keyValuePair_0)
			{
				return Losses.smethod_1(this.scenario_0, keyValuePair_0);
			}

			// Token: 0x04002556 RID: 9558
			public Scenario scenario_0;
		}
	}
}
