using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x02000A4A RID: 2634
	[DesignerGenerated]
	public sealed partial class MinefieldForm : CommandForm
	{
		// Token: 0x060053B2 RID: 21426 RVA: 0x00224AE0 File Offset: 0x00222CE0
		public MinefieldForm()
		{
			base.Load += new EventHandler(this.MinefieldForm_Load);
			base.KeyDown += new KeyEventHandler(this.MinefieldForm_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.MinefieldForm_FormClosing);
			this.list_0 = new List<ReferencePoint>();
			this.dataTable_0 = new DataTable();
			this.vmethod_13(new BackgroundWorker());
			this.InitializeComponent();
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x00224F4C File Offset: 0x0022314C
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x00026C4E File Offset: 0x00024E4E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_2)
		{
			this.label_0 = label_2;
		}

		// Token: 0x060053B7 RID: 21431 RVA: 0x00224F64 File Offset: 0x00223164
		[CompilerGenerated]
		internal  ComboBox vmethod_2()
		{
			return this.comboBox_0;
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x00026C57 File Offset: 0x00024E57
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ComboBox comboBox_1)
		{
			this.comboBox_0 = comboBox_1;
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x00224F7C File Offset: 0x0022317C
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_1;
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x00026C60 File Offset: 0x00024E60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_2)
		{
			this.label_1 = label_2;
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x00224F94 File Offset: 0x00223194
		[CompilerGenerated]
		internal  NumericUpDown vmethod_6()
		{
			return this.numericUpDown_0;
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x00026C69 File Offset: 0x00024E69
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(NumericUpDown numericUpDown_1)
		{
			this.numericUpDown_0 = numericUpDown_1;
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x00224FAC File Offset: 0x002231AC
		[CompilerGenerated]
		internal  Button vmethod_8()
		{
			return this.button_0;
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x00224FC4 File Offset: 0x002231C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Button button_1)
		{
			EventHandler value = new EventHandler(this.method_1);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_1;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x00225010 File Offset: 0x00223210
		[CompilerGenerated]
		internal  ProgressBar vmethod_10()
		{
			return this.progressBar_0;
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x00026C72 File Offset: 0x00024E72
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ProgressBar progressBar_1)
		{
			this.progressBar_0 = progressBar_1;
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x00225028 File Offset: 0x00223228
		[CompilerGenerated]
		internal  BackgroundWorker vmethod_12()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x00225040 File Offset: 0x00223240
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler value = new DoWorkEventHandler(this.method_2);
			RunWorkerCompletedEventHandler value2 = new RunWorkerCompletedEventHandler(this.method_3);
			BackgroundWorker backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value;
				backgroundWorker.RunWorkerCompleted -= value2;
			}
			this.backgroundWorker_0 = backgroundWorker_1;
			backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value;
				backgroundWorker.RunWorkerCompleted += value2;
			}
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x002250A4 File Offset: 0x002232A4
		private void MinefieldForm_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			Scenario clientScenario = Client.GetClientScenario();
			SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
			this.dataTable_0 = DBFunctions.smethod_70(true, ref clientScenario, ref sQLiteConnection);
			if (!this.dataTable_0.Columns.Contains("FullName"))
			{
				this.dataTable_0.Columns.Add("FullName", typeof(string));
			}
			IEnumerator enumerator = this.dataTable_0.Rows.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					if (Client.GetClientScenario().FeatureCompatibility.get_WeaponAGL_ASL(Client.GetClientScenario().GetSQLiteConnection()))
					{
						DataRow dataRow2 = dataRow;
						string columnName = "FullName";
						object left = Strings.Trim(Conversions.ToString(dataRow["Name"])) + " [";
						DataRow dataRow3;
						object[] array;
						bool[] array2;
						object right = NewLateBinding.LateGet(null, typeof(Math), "Abs", array = new object[]
						{
							(dataRow3 = dataRow)["TargetAltitudeMax_ASL"]
						}, null, null, array2 = new bool[]
						{
							true
						});
						if (array2[0])
						{
							dataRow3["TargetAltitudeMax_ASL"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
						}
						object left2 = Operators.ConcatenateObject(Operators.ConcatenateObject(left, right), "m - ");
						object right2 = NewLateBinding.LateGet(null, typeof(Math), "Abs", array = new object[]
						{
							(dataRow3 = dataRow)["TargetAltitudeMin_ASL"]
						}, null, null, array2 = new bool[]
						{
							true
						});
						if (array2[0])
						{
							dataRow3["TargetAltitudeMin_ASL"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
						}
						dataRow2[columnName] = Operators.ConcatenateObject(Operators.ConcatenateObject(left2, right2), "m]");
					}
					else
					{
						DataRow dataRow4 = dataRow;
						string columnName2 = "FullName";
						object left3 = Strings.Trim(Conversions.ToString(dataRow["Name"])) + " [";
						DataRow dataRow3;
						object[] array;
						bool[] array2;
						object right3 = NewLateBinding.LateGet(null, typeof(Math), "Abs", array = new object[]
						{
							(dataRow3 = dataRow)["TargetAltitudeMax"]
						}, null, null, array2 = new bool[]
						{
							true
						});
						if (array2[0])
						{
							dataRow3["TargetAltitudeMax"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
						}
						object left4 = Operators.ConcatenateObject(Operators.ConcatenateObject(left3, right3), "m - ");
						object right4 = NewLateBinding.LateGet(null, typeof(Math), "Abs", array = new object[]
						{
							(dataRow3 = dataRow)["TargetAltitudeMin"]
						}, null, null, array2 = new bool[]
						{
							true
						});
						if (array2[0])
						{
							dataRow3["TargetAltitudeMin"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
						}
						dataRow4[columnName2] = Operators.ConcatenateObject(Operators.ConcatenateObject(left4, right4), "m]");
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.dataView_0 = new DataView(this.dataTable_0);
			this.dataView_0.Sort = "FULLNAME ASC";
			this.dataView_0.RowFilter = "TYPE IN (4004, 4005, 4006, 4007, 4008)";
			this.vmethod_2().DataSource = this.dataView_0;
			this.vmethod_2().DisplayMember = "FullName";
			this.vmethod_2().ValueMember = "ID";
			this.vmethod_10().Visible = false;
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x00225488 File Offset: 0x00223688
		private void method_1(object sender, EventArgs e)
		{
			this.vmethod_8().Text = "正在工作...";
			this.vmethod_8().Enabled = false;
			this.vmethod_10().Visible = true;
			this.int_0 = Conversions.ToInteger(this.vmethod_2().SelectedValue);
			this.vmethod_12().RunWorkerAsync();
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x002254E0 File Offset: 0x002236E0
		private void method_2(object sender, DoWorkEventArgs e)
		{
			this.int_1 = Convert.ToInt32(this.vmethod_6().Value);
			this.int_2 = 0;
			int num = this.int_1;
			for (int i = 0; i <= num; i++)
			{
				i++;
				if (!Information.IsNothing(Client.GetClientScenario().AddUnguidedWeapon(Client.GetClientSide(), this.int_0, this.list_0)))
				{
					this.int_2++;
				}
			}
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x00225558 File Offset: 0x00223758
		private void method_3(object sender, RunWorkerCompletedEventArgs e)
		{
			this.vmethod_8().Text = "添加";
			this.vmethod_8().Enabled = true;
			this.vmethod_10().Visible = false;
			Client.b_Completed = true;
			string prompt;
			if (this.int_1 == this.int_2)
			{
				prompt = "所有水雷均成功布撒完成.";
			}
			else
			{
				prompt = "只有" + Conversions.ToString(this.int_2) + "枚水雷成功布撒.";
			}
			Interaction.MsgBox(prompt, MsgBoxStyle.OkOnly, "布雷完成!");
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x000200A8 File Offset: 0x0001E2A8
		private void MinefieldForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x00004D83 File Offset: 0x00002F83
		private void MinefieldForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x04002757 RID: 10071
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04002758 RID: 10072
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04002759 RID: 10073
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x0400275A RID: 10074
		[CompilerGenerated]
		private NumericUpDown numericUpDown_0;

		// Token: 0x0400275B RID: 10075
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x0400275C RID: 10076
		[CompilerGenerated]
		private ProgressBar progressBar_0;

		// Token: 0x0400275D RID: 10077
		public List<ReferencePoint> list_0;

		// Token: 0x0400275E RID: 10078
		private DataTable dataTable_0;

		// Token: 0x0400275F RID: 10079
		private DataView dataView_0;

		// Token: 0x04002760 RID: 10080
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04002761 RID: 10081
		private int int_0;

		// Token: 0x04002762 RID: 10082
		private int int_1;

		// Token: 0x04002763 RID: 10083
		private int int_2;
	}
}
