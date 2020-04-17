using System;
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
	// Token: 0x02000990 RID: 2448
	[DesignerGenerated]
	public sealed partial class SpecialActionsForm : CommandForm
	{
		// Token: 0x06003DCA RID: 15818 RVA: 0x00020255 File Offset: 0x0001E455
		public SpecialActionsForm()
		{
			base.Shown += new EventHandler(this.SpecialActionsForm_Shown);
			base.Load += new EventHandler(this.SpecialActionsForm_Load);
			this.InitializeComponent();
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x00142D14 File Offset: 0x00140F14
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x00142D2C File Offset: 0x00140F2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_2);
			DataGridView dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value;
			}
			this.dataGridView_0 = dataGridView_1;
			dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value;
			}
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x00142D78 File Offset: 0x00140F78
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x00020287 File Offset: 0x0001E487
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x00142D90 File Offset: 0x00140F90
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_4()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x00020290 File Offset: 0x0001E490
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x00142DA8 File Offset: 0x00140FA8
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_6()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x00020299 File Offset: 0x0001E499
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x00142DC0 File Offset: 0x00140FC0
		[CompilerGenerated]
		internal  DataGridViewButtonColumn vmethod_8()
		{
			return this.dataGridViewButtonColumn_0;
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x000202A2 File Offset: 0x0001E4A2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(DataGridViewButtonColumn dataGridViewButtonColumn_1)
		{
			this.dataGridViewButtonColumn_0 = dataGridViewButtonColumn_1;
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x000202AB File Offset: 0x0001E4AB
		private void SpecialActionsForm_Shown(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00142DD8 File Offset: 0x00140FD8
		public void method_1()
		{
			if (!Information.IsNothing(Client.GetClientSide()))
			{
				try
				{
					this.vmethod_0().SuspendLayout();
					DataTable dataTable = new DataTable();
					dataTable.Columns.Add("ID", typeof(string));
					dataTable.Columns.Add("Name", typeof(string));
					foreach (SpecialAction current in Client.GetClientSide().SpecialActions.Values.Where(SpecialActionsForm.SpecialActionFunc0).OrderBy(SpecialActionsForm.SpecialActionFunc1))
					{
						DataRow dataRow = dataTable.NewRow();
						dataRow["ID"] = current.GetGuid();
						dataRow["Name"] = current.Name;
						dataTable.Rows.Add(dataRow);
					}
					this.vmethod_0().AutoGenerateColumns = false;
					this.vmethod_0().DataSource = dataTable;
					this.vmethod_0().ResumeLayout();
					if (this.vmethod_0().Rows.Count > 0)
					{
						this.vmethod_0().Rows[0].Selected = true;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200406", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					this.method_1();
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x00142F8C File Offset: 0x0014118C
		private void method_2(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1 && e.RowIndex <= this.vmethod_0().Rows.Count - 1)
			{
				DataGridViewColumn dataGridViewColumn = this.vmethod_0().Columns[e.ColumnIndex];
				string key = Conversions.ToString(this.vmethod_0().Rows[e.RowIndex].Cells["ID"].Value);
				SpecialAction specialAction = Client.GetClientSide().SpecialActions[key];
				this.vmethod_2().Visible = true;
				this.vmethod_2().Text = specialAction.Description;
				if (Operators.CompareString(dataGridViewColumn.Name, "ExecuteAction", false) == 0)
				{
					string text = specialAction.Execute(Client.GetClientScenario());
					if (text != null && Operators.CompareString(text, "", false) != 0)
					{
						Interaction.MsgBox(text, MsgBoxStyle.OkOnly, null);
					}
					else
					{
						Interaction.MsgBox("特殊事件执行失败!!", MsgBoxStyle.OkOnly, null);
					}
					this.method_1();
					CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
				}
			}
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void SpecialActionsForm_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001C56 RID: 7254
		public static Func<SpecialAction, bool> SpecialActionFunc0 = (SpecialAction specialAction_0) => specialAction_0.IsActive;

		// Token: 0x04001C57 RID: 7255
		public static Func<SpecialAction, string> SpecialActionFunc1 = (SpecialAction specialAction_0) => specialAction_0.Name;

		// Token: 0x04001C59 RID: 7257
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04001C5A RID: 7258
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001C5B RID: 7259
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04001C5C RID: 7260
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04001C5D RID: 7261
		[CompilerGenerated]
		private DataGridViewButtonColumn dataGridViewButtonColumn_0;
	}
}
