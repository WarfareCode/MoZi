using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x02000997 RID: 2455
	[DesignerGenerated]
	public sealed partial class ListEvents : CommandForm
	{
		// Token: 0x06003E57 RID: 15959 RVA: 0x0014684C File Offset: 0x00144A4C
		public ListEvents()
		{
			base.Shown += new EventHandler(this.ListEvents_Shown);
			base.KeyDown += new KeyEventHandler(this.ListEvents_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.ListEvents_FormClosing);
			base.Load += new EventHandler(this.ListEvents_Load);
			this.InitializeComponent();
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x00146FF0 File Offset: 0x001451F0
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x00147008 File Offset: 0x00145208
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_1)
		{
			EventHandler value = new EventHandler(this.method_6);
			DataGridView dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.SelectionChanged -= value;
			}
			this.dataGridView_0 = dataGridView_1;
			dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.SelectionChanged += value;
			}
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x00147054 File Offset: 0x00145254
		[CompilerGenerated]
		internal  Button vmethod_2()
		{
			return this.button_0;
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x0014706C File Offset: 0x0014526C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_3);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_4;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x001470B8 File Offset: 0x001452B8
		[CompilerGenerated]
		internal  Button vmethod_4()
		{
			return this.button_1;
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x001470D0 File Offset: 0x001452D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_4);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_4;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x0014711C File Offset: 0x0014531C
		[CompilerGenerated]
		internal  Button vmethod_6()
		{
			return this.button_2;
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x00147134 File Offset: 0x00145334
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_2);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_4;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x00147180 File Offset: 0x00145380
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_8()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x000205FC File Offset: 0x0001E7FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x00147198 File Offset: 0x00145398
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_10()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x00020605 File Offset: 0x0001E805
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x001471B0 File Offset: 0x001453B0
		[CompilerGenerated]
		internal  DataGridViewCheckBoxColumn vmethod_12()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x0002060E File Offset: 0x0001E80E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x001471C8 File Offset: 0x001453C8
		[CompilerGenerated]
		internal  DataGridViewCheckBoxColumn vmethod_14()
		{
			return this.dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x00020617 File Offset: 0x0001E817
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_1 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x001471E0 File Offset: 0x001453E0
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_16()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x00020620 File Offset: 0x0001E820
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x001471F8 File Offset: 0x001453F8
		[CompilerGenerated]
		internal  Button vmethod_18()
		{
			return this.button_3;
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x00147210 File Offset: 0x00145410
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_5);
			Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_4;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x0014725C File Offset: 0x0014545C
		public void method_1()
		{
			try
			{
				this.bool_0 = true;
				this.vmethod_0().SuspendLayout();
				DataTable dataTable = new DataTable();
				dataTable.Columns.Add("ID", typeof(string));
				dataTable.Columns.Add("Description", typeof(string));
				dataTable.Columns.Add("IsRepeatable", typeof(bool));
				dataTable.Columns.Add("IsActive", typeof(bool));
				dataTable.Columns.Add("IsShown", typeof(bool));
				dataTable.Columns.Add("Probability", typeof(short));
				foreach (SimEvent current in Client.GetClientScenario().GetSimEvents().Values.OrderBy(ListEvents.SimEventFunc))
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["ID"] = current.GetGuid();
					dataRow["Description"] = current.Description;
					dataRow["IsRepeatable"] = current.IsRepeatable;
					dataRow["IsActive"] = current.IsActive;
					dataRow["IsShown"] = current.IsShown;
					dataRow["Probability"] = current.Probability;
					dataTable.Rows.Add(dataRow);
				}
				this.vmethod_0().DataSource = dataTable;
				this.vmethod_0().Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				this.vmethod_0().ResumeLayout();
				this.bool_0 = false;
				if (!string.IsNullOrEmpty(this.string_0))
				{
					IEnumerator enumerator2 = ((IEnumerable)this.vmethod_0().Rows).GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							object objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
							if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"ID"
							}, null, null, null), null, "Value", new object[0], null, null, null), this.string_0, false))
							{
								this.vmethod_0().CurrentCell = (DataGridViewCell)NewLateBinding.LateGet(objectValue, null, "cells", new object[]
								{
									1
								}, null, null, null);
								break;
							}
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200102", ex2.Message);
				GameGeneral.LogException(ref ex2);
				this.method_1();
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x001475A0 File Offset: 0x001457A0
		private void method_2(object sender, EventArgs e)
		{
			SimEvent simEvent_ = new SimEvent();
			this.editEvent_0 = new EditEvent();
			this.editEvent_0.method_2(simEvent_);
			this.editEvent_0.enum186_0 = EditEvent.Enum186.const_0;
			this.editEvent_0.Show();
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x001475E4 File Offset: 0x001457E4
		private void method_3(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				SimEvent simEvent_ = Client.GetClientScenario().GetSimEvents()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				this.editEvent_0 = new EditEvent();
				this.editEvent_0.method_2(simEvent_);
				this.editEvent_0.enum186_0 = EditEvent.Enum186.const_1;
				this.editEvent_0.Show();
			}
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x00147670 File Offset: 0x00145870
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				SimEvent simEvent = Client.GetClientScenario().GetSimEvents()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				Client.GetClientScenario().GetSimEvents().Remove(simEvent.GetGuid());
				this.method_1();
			}
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x00020629 File Offset: 0x0001E829
		private void ListEvents_Shown(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void ListEvents_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x00004D83 File Offset: 0x00002F83
		private void ListEvents_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x001476E8 File Offset: 0x001458E8
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				SimEvent simEvent = Client.GetClientScenario().GetSimEvents()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)].Clone();
				Client.GetClientScenario().GetSimEvents().Add(simEvent.GetGuid(), simEvent);
				this.method_1();
			}
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x00147768 File Offset: 0x00145968
		private void method_6(object sender, EventArgs e)
		{
			if (!this.bool_0 && this.vmethod_0().SelectedRows.Count != 0)
			{
				this.string_0 = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
			}
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void ListEvents_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001CA8 RID: 7336
		public static Func<SimEvent, string> SimEventFunc = (SimEvent simEvent_0) => simEvent_0.Description;

		// Token: 0x04001CAA RID: 7338
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04001CAB RID: 7339
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001CAC RID: 7340
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001CAD RID: 7341
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04001CAE RID: 7342
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04001CAF RID: 7343
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04001CB0 RID: 7344
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x04001CB1 RID: 7345
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		// Token: 0x04001CB2 RID: 7346
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04001CB3 RID: 7347
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04001CB4 RID: 7348
		private EditEvent editEvent_0;

		// Token: 0x04001CB5 RID: 7349
		private string string_0;

		// Token: 0x04001CB6 RID: 7350
		private bool bool_0;
	}
}
