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
	// Token: 0x02000B6E RID: 2926
	[DesignerGenerated]
	public sealed partial class ListActions : CommandForm
	{
		// Token: 0x060060B8 RID: 24760 RVA: 0x002DFD54 File Offset: 0x002DDF54
		public ListActions()
		{
			base.Shown += new EventHandler(this.ListActions_Shown);
			base.KeyDown += new KeyEventHandler(this.ListActions_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.ListActions_FormClosing);
			base.Load += new EventHandler(this.ListActions_Load);
			this.InitializeComponent();
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x002E04BC File Offset: 0x002DE6BC
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x060060BC RID: 24764 RVA: 0x002E04D4 File Offset: 0x002DE6D4
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

		// Token: 0x060060BD RID: 24765 RVA: 0x002E0520 File Offset: 0x002DE720
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_2()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x0002AF08 File Offset: 0x00029108
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x002E0538 File Offset: 0x002DE738
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_4()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060060C0 RID: 24768 RVA: 0x0002AF11 File Offset: 0x00029111
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x002E0550 File Offset: 0x002DE750
		[CompilerGenerated]
		internal  ComboBox vmethod_6()
		{
			return this.comboBox_0;
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x0002AF1A File Offset: 0x0002911A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ComboBox comboBox_1)
		{
			this.comboBox_0 = comboBox_1;
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x002E0568 File Offset: 0x002DE768
		[CompilerGenerated]
		internal  Button vmethod_8()
		{
			return this.button_0;
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x002E0580 File Offset: 0x002DE780
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

		// Token: 0x060060C5 RID: 24773 RVA: 0x002E05CC File Offset: 0x002DE7CC
		[CompilerGenerated]
		internal  Button vmethod_10()
		{
			return this.button_1;
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x002E05E4 File Offset: 0x002DE7E4
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

		// Token: 0x060060C7 RID: 24775 RVA: 0x002E0630 File Offset: 0x002DE830
		[CompilerGenerated]
		internal  Button vmethod_12()
		{
			return this.button_2;
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x002E0648 File Offset: 0x002DE848
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

		// Token: 0x060060C9 RID: 24777 RVA: 0x002E0694 File Offset: 0x002DE894
		[CompilerGenerated]
		internal  Button vmethod_14()
		{
			return this.button_3;
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x002E06AC File Offset: 0x002DE8AC
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

		// Token: 0x060060CB RID: 24779 RVA: 0x002E06F8 File Offset: 0x002DE8F8
		public void method_1()
		{
			try
			{
				this.bool_0 = true;
				this.vmethod_0().SuspendLayout();
				DataTable dataTable = new DataTable();
				dataTable.Columns.Add("ID", typeof(string));
				dataTable.Columns.Add("Description", typeof(string));
				foreach (EventAction current in Client.GetClientScenario().GetEventActions().Values.OrderBy(ListActions.EventActionFunc))
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
				this.method_1();
				ex2.Data.Add("Error at 200380", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x002E0958 File Offset: 0x002DEB58
		private void method_2(object sender, EventArgs e)
		{
			if (this.vmethod_6().SelectedIndex > -1)
			{
				EventAction eventAction_;
				switch (this.vmethod_6().SelectedIndex)
				{
				case 0:
					eventAction_ = new EventAction_Points();
					break;
				case 1:
					eventAction_ = new EventAction_EndScenario();
					break;
				case 2:
					eventAction_ = new EventAction_TeleportInArea();
					break;
				case 3:
					eventAction_ = new EventAction_Message();
					break;
				case 4:
					eventAction_ = new EventAction_ChangeMissionStatus();
					break;
				case 5:
					eventAction_ = new EventAction_LuaScript();
					break;
				default:
					throw new NotImplementedException();
				}
				this.editAction_0 = new EditAction();
				this.editAction_0.eventAction_0 = eventAction_;
				this.editAction_0.enum184_0 = EditAction.Enum184.const_0;
				this.editAction_0.Show();
			}
		}

		// Token: 0x060060CD RID: 24781 RVA: 0x002E0A08 File Offset: 0x002DEC08
		private void method_3(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				EventAction eventAction_ = Client.GetClientScenario().GetEventActions()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				this.editAction_0 = new EditAction();
				this.editAction_0.eventAction_0 = eventAction_;
				this.editAction_0.enum184_0 = EditAction.Enum184.const_1;
				this.editAction_0.Show();
			}
		}

		// Token: 0x060060CE RID: 24782 RVA: 0x002E0A94 File Offset: 0x002DEC94
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				EventAction eventAction = Client.GetClientScenario().GetEventActions()[key];
				if (!Information.IsNothing(eventAction))
				{
					bool flag = false;
					using (IEnumerator<SimEvent> enumerator = Client.GetClientScenario().GetSimEvents().Values.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.Actions.Contains(eventAction))
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag || Interaction.MsgBox("This action is used by at least one event, are you sure you want to delete it?", MsgBoxStyle.YesNo, "Action is in use!") != MsgBoxResult.No)
					{
						Client.GetClientScenario().GetEventActions().Remove(eventAction.GetGuid());
						using (IEnumerator<SimEvent> enumerator2 = Client.GetClientScenario().GetSimEvents().Values.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								enumerator2.Current.Actions.Remove(eventAction);
							}
						}
						this.method_1();
					}
				}
			}
		}

		// Token: 0x060060CF RID: 24783 RVA: 0x0002AF23 File Offset: 0x00029123
		private void ListActions_Shown(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x060060D0 RID: 24784 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void ListActions_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x060060D1 RID: 24785 RVA: 0x00004D83 File Offset: 0x00002F83
		private void ListActions_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x060060D2 RID: 24786 RVA: 0x002E0BE4 File Offset: 0x002DEDE4
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				EventAction eventAction = Client.GetClientScenario().GetEventActions()[key].Clone();
				Client.GetClientScenario().GetEventActions().Add(eventAction.GetGuid(), eventAction);
				this.method_1();
			}
		}

		// Token: 0x060060D3 RID: 24787 RVA: 0x002E0C64 File Offset: 0x002DEE64
		private void method_6(object sender, EventArgs e)
		{
			if (!this.bool_0 && this.vmethod_0().SelectedRows.Count != 0)
			{
				this.string_0 = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
			}
		}

		// Token: 0x060060D4 RID: 24788 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void ListActions_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x0400340E RID: 13326
		public static Func<EventAction, string> EventActionFunc = (EventAction eventAction_0) => eventAction_0.strDescription;

		// Token: 0x04003410 RID: 13328
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04003411 RID: 13329
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04003412 RID: 13330
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04003413 RID: 13331
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04003414 RID: 13332
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04003415 RID: 13333
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04003416 RID: 13334
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04003417 RID: 13335
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04003418 RID: 13336
		private EditAction editAction_0;

		// Token: 0x04003419 RID: 13337
		private string string_0;

		// Token: 0x0400341A RID: 13338
		private bool bool_0;
	}
}
