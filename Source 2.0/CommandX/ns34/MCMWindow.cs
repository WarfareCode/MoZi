using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x02000A40 RID: 2624
	[DesignerGenerated]
	public sealed partial class MCMWindow : CommandForm
	{
		// Token: 0x0600535C RID: 21340 RVA: 0x00221D84 File Offset: 0x0021FF84
		public MCMWindow()
		{
			base.Load += new EventHandler(this.MCMWindow_Load);
			base.KeyDown += new KeyEventHandler(this.MCMWindow_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.MCMWindow_FormClosing);
			this.dataTable_0 = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x0022211C File Offset: 0x0022031C
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x00222134 File Offset: 0x00220334
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_3);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_4);
			DataGridView dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value;
				dataGridView.CellContentClick -= value2;
			}
			this.dataGridView_0 = dataGridView_1;
			dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value;
				dataGridView.CellContentClick += value2;
			}
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x00222198 File Offset: 0x00220398
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_2()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x00026AD9 File Offset: 0x00024CD9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x002221B0 File Offset: 0x002203B0
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_4()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x00026AE2 File Offset: 0x00024CE2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x00026AEB File Offset: 0x00024CEB
		private void MCMWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.Text = "猎雷/辅助装置";
			this.method_1();
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x002221C8 File Offset: 0x002203C8
		public void method_1()
		{
			this.method_2();
			this.vmethod_0().DataSource = this.dataTable_0;
			this.vmethod_0().Columns["CanBeActive"].Visible = false;
			this.vmethod_0().Columns["Order#"].Visible = false;
			IEnumerator enumerator = ((IEnumerable)this.vmethod_0().Rows).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
					if (!((ActiveUnit)Client.GetHookedUnit()).GetMineCounterMeasures()[Conversions.ToInteger(dataGridViewRow.Cells["Order#"].Value)].IsActiveCapable())
					{
						dataGridViewRow.ReadOnly = true;
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
			IEnumerator enumerator2 = this.vmethod_0().Columns.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					DataGridViewColumn arg_EC_0 = (DataGridViewColumn)enumerator2.Current;
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

		// Token: 0x06005367 RID: 21351 RVA: 0x00222304 File Offset: 0x00220504
		private void method_2()
		{
			this.vmethod_0().DataSource = null;
			this.vmethod_0().Rows.Clear();
			this.dataTable_0.Columns.Clear();
			this.dataTable_0.Rows.Clear();
			this.dataTable_0.Columns.Add("Order#", typeof(int));
			this.dataTable_0.Columns.Add("CanBeActive", typeof(bool));
			this.dataTable_0.Columns.Add("Sensor", typeof(string));
			this.dataTable_0.Columns.Add("SensorType", typeof(string));
			this.dataTable_0.Columns.Add("Active", typeof(bool));
			this.dataTable_0.Columns.Add("Status", typeof(string));
			int num = ((ActiveUnit)Client.GetHookedUnit()).GetMineCounterMeasures().Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Sensor sensor = ((ActiveUnit)Client.GetHookedUnit()).GetMineCounterMeasures()[i];
				DataRow dataRow = this.dataTable_0.NewRow();
				dataRow["Order#"] = i;
				dataRow["CanBeActive"] = sensor.IsActiveCapable();
				dataRow["Sensor"] = Misc.smethod_11(sensor.Name);
				dataRow["SensorType"] = sensor.Description;
				dataRow["Active"] = sensor.IsEmmitting();
				dataRow["Status"] = sensor.GetComponentStatus().ToString();
				this.dataTable_0.Rows.Add(dataRow);
			}
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x002224F0 File Offset: 0x002206F0
		private void method_3(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1)
			{
				DataGridViewRow dataGridViewRow = this.vmethod_0().Rows[e.RowIndex];
				if (((ActiveUnit)Client.GetHookedUnit()).GetMineCounterMeasures()[e.RowIndex].GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
				{
					dataGridViewRow.Selected = false;
				}
			}
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x0022255C File Offset: 0x0022075C
		private void method_4(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				DataGridViewColumn dataGridViewColumn = this.vmethod_0().Columns[e.ColumnIndex];
				if (((ActiveUnit)Client.GetHookedUnit()).GetMineCounterMeasures()[e.RowIndex].GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && Operators.CompareString(dataGridViewColumn.Name, "Active", false) == 0)
				{
					int index = Conversions.ToInteger(this.vmethod_0().Rows[e.RowIndex].Cells["Order#"].Value);
					if (((ActiveUnit)Client.GetHookedUnit()).GetMineCounterMeasures()[index].IsActiveCapable())
					{
						if (!((ActiveUnit)Client.GetHookedUnit()).GetMineCounterMeasures()[index].IsEmmitting())
						{
							((ActiveUnit)Client.GetHookedUnit()).GetMineCounterMeasures()[index].TurnOn();
							this.vmethod_0().Rows[e.RowIndex].Cells["Active"].Value = true;
						}
						else
						{
							((ActiveUnit)Client.GetHookedUnit()).GetMineCounterMeasures()[index].TurnOff();
							this.vmethod_0().Rows[e.RowIndex].Cells["Active"].Value = false;
						}
						CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
						Client.b_Completed = true;
					}
				}
			}
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x000200A8 File Offset: 0x0001E2A8
		private void MCMWindow_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x0600536B RID: 21355 RVA: 0x00004D83 File Offset: 0x00002F83
		private void MCMWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x04002719 RID: 10009
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x0400271A RID: 10010
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x0400271B RID: 10011
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x0400271C RID: 10012
		private DataTable dataTable_0;
	}
}
