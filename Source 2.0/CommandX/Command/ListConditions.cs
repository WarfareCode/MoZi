using System;
using System.Collections;
using System.Collections.Generic;
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
using ns0;
using ns1;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x02000B6F RID: 2927
	[DesignerGenerated]
	public sealed partial class ListConditions : CommandForm
	{
		// Token: 0x060060D7 RID: 24791 RVA: 0x002E0CC4 File Offset: 0x002DEEC4
		public ListConditions()
		{
			base.Shown += new EventHandler(this.ListConditions_Shown);
			base.KeyDown += new KeyEventHandler(this.ListConditions_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.ListConditions_FormClosing);
			base.Load += new EventHandler(this.ListConditions_Load);
			this.InitializeComponent();
		}

		// Token: 0x060060DA RID: 24794 RVA: 0x002E1414 File Offset: 0x002DF614
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x060060DB RID: 24795 RVA: 0x002E142C File Offset: 0x002DF62C
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

		// Token: 0x060060DC RID: 24796 RVA: 0x002E1478 File Offset: 0x002DF678
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_2()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x0002AF4F File Offset: 0x0002914F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060060DE RID: 24798 RVA: 0x002E1490 File Offset: 0x002DF690
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_4()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060060DF RID: 24799 RVA: 0x0002AF58 File Offset: 0x00029158
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x002E14A8 File Offset: 0x002DF6A8
		[CompilerGenerated]
		internal  ComboBox vmethod_6()
		{
			return this.comboBox_0;
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x0002AF61 File Offset: 0x00029161
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ComboBox comboBox_1)
		{
			this.comboBox_0 = comboBox_1;
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x002E14C0 File Offset: 0x002DF6C0
		[CompilerGenerated]
		internal  Button vmethod_8()
		{
			return this.button_0;
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x002E14D8 File Offset: 0x002DF6D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Button button_4)
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

		// Token: 0x060060E4 RID: 24804 RVA: 0x002E1524 File Offset: 0x002DF724
		[CompilerGenerated]
		internal  Button vmethod_10()
		{
			return this.button_1;
		}

		// Token: 0x060060E5 RID: 24805 RVA: 0x002E153C File Offset: 0x002DF73C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Button button_4)
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

		// Token: 0x060060E6 RID: 24806 RVA: 0x002E1588 File Offset: 0x002DF788
		[CompilerGenerated]
		internal  Button vmethod_12()
		{
			return this.button_2;
		}

		// Token: 0x060060E7 RID: 24807 RVA: 0x002E15A0 File Offset: 0x002DF7A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Button button_4)
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

		// Token: 0x060060E8 RID: 24808 RVA: 0x002E15EC File Offset: 0x002DF7EC
		[CompilerGenerated]
		internal  Button vmethod_14()
		{
			return this.button_3;
		}

		// Token: 0x060060E9 RID: 24809 RVA: 0x002E1604 File Offset: 0x002DF804
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Button button_4)
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

		// Token: 0x060060EA RID: 24810 RVA: 0x002E1650 File Offset: 0x002DF850
		public void ShowListConditions()
		{
			try
			{
				this.bool_0 = true;
				this.vmethod_0().SuspendLayout();
				DataTable dataTable = new DataTable();
				dataTable.Columns.Add("ID", typeof(string));
				dataTable.Columns.Add("Description", typeof(string));
				foreach (EventCondition current in Client.GetClientScenario().GetEventConditions().Values.OrderBy(ListConditions.EventConditionFunc))
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["ID"] = current.GetGuid();
					dataRow["Description"] = current.strDescription;
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
				ex2.Data.Add("Error at 200105", ex2.Message);
				GameGeneral.LogException(ref ex2);
				this.ShowListConditions();
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060060EB RID: 24811 RVA: 0x002E18B0 File Offset: 0x002DFAB0
		private void method_2(object sender, EventArgs e)
		{
			if (this.vmethod_6().SelectedIndex > -1)
			{
				EventCondition eventCondition_;
				switch (this.vmethod_6().SelectedIndex)
				{
				case 0:
					eventCondition_ = new EventCondition_SidePosture();
					break;
				case 1:
					eventCondition_ = new EventCondition_ScenHasStarted();
					break;
				case 2:
					eventCondition_ = new EventCondition_LuaScript();
					break;
				default:
					throw new NotImplementedException();
				}
				this.editCondition_0 = new EditCondition();
				this.editCondition_0.eventCondition_0 = eventCondition_;
				this.editCondition_0.enum185_0 = EditCondition.Enum185.const_0;
				this.editCondition_0.Show();
			}
		}

		// Token: 0x060060EC RID: 24812 RVA: 0x002E1938 File Offset: 0x002DFB38
		private void method_3(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				EventCondition eventCondition_ = Client.GetClientScenario().GetEventConditions()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				this.editCondition_0 = new EditCondition();
				this.editCondition_0.eventCondition_0 = eventCondition_;
				this.editCondition_0.enum185_0 = EditCondition.Enum185.const_1;
				this.editCondition_0.Show();
			}
		}

		// Token: 0x060060ED RID: 24813 RVA: 0x002E19C4 File Offset: 0x002DFBC4
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				EventCondition eventCondition = Client.GetClientScenario().GetEventConditions()[key];
				if (!Information.IsNothing(eventCondition))
				{
					bool flag = false;
					using (IEnumerator<SimEvent> enumerator = Client.GetClientScenario().GetSimEvents().Values.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.Conditions.Contains(eventCondition))
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag || Interaction.MsgBox("至少有一个事件用到了本条件，您确认删除它吗?", MsgBoxStyle.YesNo, "条件有人用!") != MsgBoxResult.No)
					{
						Client.GetClientScenario().GetEventConditions().Remove(eventCondition.GetGuid());
						using (IEnumerator<SimEvent> enumerator2 = Client.GetClientScenario().GetSimEvents().Values.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								enumerator2.Current.Conditions.Remove(eventCondition);
							}
						}
						this.ShowListConditions();
					}
				}
			}
		}

		// Token: 0x060060EE RID: 24814 RVA: 0x0002AF6A File Offset: 0x0002916A
		private void ListConditions_Shown(object sender, EventArgs e)
		{
			this.ShowListConditions();
		}

		// Token: 0x060060EF RID: 24815 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void ListConditions_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x060060F0 RID: 24816 RVA: 0x00004D83 File Offset: 0x00002F83
		private void ListConditions_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x002E1B14 File Offset: 0x002DFD14
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				EventCondition eventCondition = Client.GetClientScenario().GetEventConditions()[key].Clone();
				Client.GetClientScenario().GetEventConditions().Add(eventCondition.GetGuid(), eventCondition);
				this.ShowListConditions();
			}
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x002E1B94 File Offset: 0x002DFD94
		private void method_6(object sender, EventArgs e)
		{
			if (!this.bool_0 && this.vmethod_0().SelectedRows.Count != 0)
			{
				this.string_0 = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
			}
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void ListConditions_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x0400341C RID: 13340
		public static Func<EventCondition, string> EventConditionFunc = (EventCondition eventCondition_0) => eventCondition_0.strDescription;

		// Token: 0x0400341E RID: 13342
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x0400341F RID: 13343
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04003420 RID: 13344
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04003421 RID: 13345
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04003422 RID: 13346
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04003423 RID: 13347
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04003424 RID: 13348
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04003425 RID: 13349
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04003426 RID: 13350
		private EditCondition editCondition_0;

		// Token: 0x04003427 RID: 13351
		private string string_0;

		// Token: 0x04003428 RID: 13352
		private bool bool_0;
	}
}
