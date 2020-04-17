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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x02000985 RID: 2437
	[DesignerGenerated]
	public sealed partial class ListSpecialActions : CommandForm
	{
		// Token: 0x06003D23 RID: 15651 RVA: 0x0013AE58 File Offset: 0x00139058
		public ListSpecialActions()
		{
			base.Shown += new EventHandler(this.ListSpecialActions_Shown);
			base.KeyDown += new KeyEventHandler(this.ListSpecialActions_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.ListSpecialActions_FormClosing);
			base.Load += new EventHandler(this.ListSpecialActions_Load);
			this.InitializeComponent();
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x0013B640 File Offset: 0x00139840
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x0013B658 File Offset: 0x00139858
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_1)
		{
			EventHandler value = new EventHandler(this.method_6);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_7);
			DataGridView dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.SelectionChanged -= value;
				dataGridView.CellClick -= value2;
			}
			this.dataGridView_0 = dataGridView_1;
			dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.SelectionChanged += value;
				dataGridView.CellClick += value2;
			}
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x0013B6BC File Offset: 0x001398BC
		[CompilerGenerated]
		internal  Button GetButton_EditSelected()
		{
			return this.button_0;
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x0013B6D4 File Offset: 0x001398D4
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

		// Token: 0x06003D2A RID: 15658 RVA: 0x0013B720 File Offset: 0x00139920
		[CompilerGenerated]
		internal  Button GetButton_DeleteSelected()
		{
			return this.button_1;
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x0013B738 File Offset: 0x00139938
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

		// Token: 0x06003D2C RID: 15660 RVA: 0x0013B784 File Offset: 0x00139984
		[CompilerGenerated]
		internal  Button vmethod_6()
		{
			return this.button_2;
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x0013B79C File Offset: 0x0013999C
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

		// Token: 0x06003D2E RID: 15662 RVA: 0x0013B7E8 File Offset: 0x001399E8
		[CompilerGenerated]
		internal  Button GetButton_CloneSelected()
		{
			return this.button_3;
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x0013B800 File Offset: 0x00139A00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Button button_4)
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

		// Token: 0x06003D30 RID: 15664 RVA: 0x0013B84C File Offset: 0x00139A4C
		[CompilerGenerated]
		internal  Label vmethod_10()
		{
			return this.label_0;
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x0001FFD1 File Offset: 0x0001E1D1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x0013B864 File Offset: 0x00139A64
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_12()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x0001FFDA File Offset: 0x0001E1DA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x0013B87C File Offset: 0x00139A7C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_14()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x0001FFE3 File Offset: 0x0001E1E3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x0013B894 File Offset: 0x00139A94
		[CompilerGenerated]
		internal  DataGridViewCheckBoxColumn vmethod_16()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x0001FFEC File Offset: 0x0001E1EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x0013B8AC File Offset: 0x00139AAC
		[CompilerGenerated]
		internal  DataGridViewCheckBoxColumn vmethod_18()
		{
			return this.dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x0001FFF5 File Offset: 0x0001E1F5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_1 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x0013B8C4 File Offset: 0x00139AC4
		public void ShowListSpecialActions()
		{
			if (!Information.IsNothing(Client.GetClientSide()))
			{
				try
				{
					this.bool_0 = true;
					this.vmethod_0().SuspendLayout();
					DataTable dataTable = new DataTable();
					dataTable.Columns.Add("ID", typeof(string));
					dataTable.Columns.Add("Name", typeof(string));
					dataTable.Columns.Add("IsActive", typeof(string));
					dataTable.Columns.Add("IsRepeatable", typeof(string));
					foreach (SpecialAction current in Client.GetClientSide().SpecialActions.Values.OrderBy(ListSpecialActions.SpecialActionFunc))
					{
						DataRow dataRow = dataTable.NewRow();
						dataRow["ID"] = current.GetGuid();
						dataRow["Name"] = current.Name;
						dataRow["IsActive"] = current.IsActive;
						dataRow["IsRepeatable"] = current.IsRepeatable;
						dataTable.Rows.Add(dataRow);
					}
					this.vmethod_0().DataSource = dataTable;
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
					this.ShowListSpecialActions();
					ex2.Data.Add("Error at 200381", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x0013BB94 File Offset: 0x00139D94
		private void method_2(object sender, EventArgs e)
		{
			SpecialAction specialAction_ = new SpecialAction();
			this.editSpecialAction_0 = new EditSpecialAction();
			this.editSpecialAction_0.specialAction_0 = specialAction_;
			this.editSpecialAction_0.enum183_0 = EditSpecialAction.Enum183.const_0;
			this.editSpecialAction_0.Show();
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x0013BBD8 File Offset: 0x00139DD8
		private void method_3(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				SpecialAction specialAction_ = Client.GetClientSide().SpecialActions[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				this.editSpecialAction_0 = new EditSpecialAction();
				this.editSpecialAction_0.specialAction_0 = specialAction_;
				this.editSpecialAction_0.enum183_0 = EditSpecialAction.Enum183.const_1;
				this.editSpecialAction_0.Show();
			}
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x0013BC64 File Offset: 0x00139E64
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				SpecialAction specialAction = Client.GetClientSide().SpecialActions[key];
				if (!Information.IsNothing(specialAction))
				{
					Client.GetClientSide().SpecialActions.Remove(specialAction.GetGuid());
					this.ShowListSpecialActions();
				}
			}
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x0001FFFE File Offset: 0x0001E1FE
		private void ListSpecialActions_Shown(object sender, EventArgs e)
		{
			this.ShowListSpecialActions();
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void ListSpecialActions_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06003D40 RID: 15680 RVA: 0x00004D83 File Offset: 0x00002F83
		private void ListSpecialActions_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x0013BCE8 File Offset: 0x00139EE8
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				SpecialAction specialAction = Client.GetClientSide().SpecialActions[key].Clone();
				Client.GetClientSide().SpecialActions.Add(specialAction.GetGuid(), specialAction);
				this.ShowListSpecialActions();
			}
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x0013BD68 File Offset: 0x00139F68
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count == 0)
			{
				this.vmethod_10().Visible = false;
			}
			else
			{
				this.vmethod_10().Visible = true;
				if (this.vmethod_0().SelectedRows.Count != 0)
				{
					string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
					SpecialAction specialAction = Client.GetClientSide().SpecialActions[key];
					this.vmethod_10().Text = specialAction.Description;
					if (!this.bool_0)
					{
						this.string_0 = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
					}
				}
			}
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x0013BE48 File Offset: 0x0013A048
		private void method_7(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1)
			{
				DataGridViewColumn dataGridViewColumn = this.vmethod_0().Columns[e.ColumnIndex];
				if (Operators.CompareString(dataGridViewColumn.Name, "IsActive", false) == 0 | Operators.CompareString(dataGridViewColumn.Name, "IsRepeatable", false) == 0)
				{
					DataGridViewCheckBoxCell dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)this.vmethod_0()[e.ColumnIndex, e.RowIndex];
					string key = Conversions.ToString(this.vmethod_0().Rows[e.RowIndex].Cells["ID"].Value);
					SpecialAction specialAction = Client.GetClientSide().SpecialActions[key];
					dataGridViewCheckBoxCell.Value = !Conversions.ToBoolean(dataGridViewCheckBoxCell.Value);
					if (Operators.CompareString(dataGridViewColumn.Name, "IsActive", false) == 0)
					{
						specialAction.IsActive = Conversions.ToBoolean(dataGridViewCheckBoxCell.Value);
					}
					else if (Operators.CompareString(dataGridViewColumn.Name, "IsRepeatable", false) == 0)
					{
						specialAction.IsRepeatable = Conversions.ToBoolean(dataGridViewCheckBoxCell.Value);
					}
				}
			}
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void ListSpecialActions_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001BDB RID: 7131
		public static Func<SpecialAction, string> SpecialActionFunc = (SpecialAction specialAction_0) => specialAction_0.Name;

		// Token: 0x04001BDD RID: 7133
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04001BDE RID: 7134
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001BDF RID: 7135
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001BE0 RID: 7136
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04001BE1 RID: 7137
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04001BE2 RID: 7138
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001BE3 RID: 7139
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04001BE4 RID: 7140
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04001BE5 RID: 7141
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x04001BE6 RID: 7142
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		// Token: 0x04001BE7 RID: 7143
		private EditSpecialAction editSpecialAction_0;

		// Token: 0x04001BE8 RID: 7144
		private string string_0;

		// Token: 0x04001BE9 RID: 7145
		private bool bool_0;
	}
}
