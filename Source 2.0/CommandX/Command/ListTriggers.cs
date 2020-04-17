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
using ns1;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x0200099B RID: 2459
	[DesignerGenerated]
	public sealed partial class ListTriggers : CommandForm
	{
		// Token: 0x06003EDC RID: 16092 RVA: 0x00151488 File Offset: 0x0014F688
		public ListTriggers()
		{
			base.Shown += new EventHandler(this.ListTriggers_Shown);
			base.KeyDown += new KeyEventHandler(this.ListTriggers_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.ListTriggers_FormClosing);
			base.Load += new EventHandler(this.ListTriggers_Load);
			this.InitializeComponent();
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x00151C1C File Offset: 0x0014FE1C
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x00151C34 File Offset: 0x0014FE34
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

		// Token: 0x06003EE1 RID: 16097 RVA: 0x00151C80 File Offset: 0x0014FE80
		[CompilerGenerated]
		internal  Button vmethod_2()
		{
			return this.button_0;
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x00151C98 File Offset: 0x0014FE98
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

		// Token: 0x06003EE3 RID: 16099 RVA: 0x00151CE4 File Offset: 0x0014FEE4
		[CompilerGenerated]
		internal  Button vmethod_4()
		{
			return this.button_1;
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x00151CFC File Offset: 0x0014FEFC
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

		// Token: 0x06003EE5 RID: 16101 RVA: 0x00151D48 File Offset: 0x0014FF48
		[CompilerGenerated]
		internal  Button vmethod_6()
		{
			return this.button_2;
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x00151D60 File Offset: 0x0014FF60
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

		// Token: 0x06003EE7 RID: 16103 RVA: 0x00151DAC File Offset: 0x0014FFAC
		[CompilerGenerated]
		internal  ComboBox vmethod_8()
		{
			return this.comboBox_0;
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x0002077D File Offset: 0x0001E97D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ComboBox comboBox_1)
		{
			this.comboBox_0 = comboBox_1;
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x00151DC4 File Offset: 0x0014FFC4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_10()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x00020786 File Offset: 0x0001E986
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x00151DDC File Offset: 0x0014FFDC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_12()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x0002078F File Offset: 0x0001E98F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x00151DF4 File Offset: 0x0014FFF4
		[CompilerGenerated]
		internal  Button vmethod_14()
		{
			return this.button_3;
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x00151E0C File Offset: 0x0015000C
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

		// Token: 0x06003EEF RID: 16111 RVA: 0x00151E58 File Offset: 0x00150058
		public void method_1()
		{
			try
			{
				this.bool_0 = true;
				this.vmethod_0().SuspendLayout();
				DataTable dataTable = new DataTable();
				dataTable.Columns.Add("ID", typeof(string));
				dataTable.Columns.Add("Description", typeof(string));
				foreach (EventTrigger current in Client.GetClientScenario().GetEventTriggers().Values.OrderBy(ListTriggers.EventTriggerFunc))
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["ID"] = current.GetGuid();
					dataRow["Description"] = current.strDescription;
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
				this.method_1();
				ex2.Data.Add("Error at 200382", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x001520D4 File Offset: 0x001502D4
		private void method_2(object sender, EventArgs e)
		{
			if (this.vmethod_8().SelectedIndex > -1)
			{
				EventTrigger eventTrigger;
				switch (this.vmethod_8().SelectedIndex)
				{
				case 0:
					eventTrigger = new EventTrigger_UnitDestroyed();
					break;
				case 1:
					eventTrigger = new EventTrigger_UnitDamaged();
					break;
				case 2:
					eventTrigger = new EventTrigger_Points();
					break;
				case 3:
					eventTrigger = new EventTrigger_Time(Client.GetClientScenario().GetCurrentTime(false).AddMinutes(30.0));
					break;
				case 4:
					eventTrigger = new EventTrigger_UnitRemainsInArea();
					break;
				case 5:
					eventTrigger = new EventTrigger_UnitEntersArea();
					((EventTrigger_UnitEntersArea)eventTrigger).ETOA = Client.GetClientScenario().GetCurrentTime(false);
					((EventTrigger_UnitEntersArea)eventTrigger).LTOA = ((EventTrigger_UnitEntersArea)eventTrigger).ETOA.AddYears(1);
					break;
				case 6:
					eventTrigger = new EventTrigger_RandomTime(Client.GetClientScenario().GetCurrentTime(false).AddMinutes(30.0), Client.GetClientScenario().GetCurrentTime(false).AddMinutes(120.0));
					break;
				case 7:
					eventTrigger = new EventTrigger_UnitDetected();
					break;
				case 8:
					eventTrigger = new EventTrigger_ScenLoaded();
					break;
				case 9:
					eventTrigger = new EventTrigger_RegularTime();
					break;
				default:
					throw new NotImplementedException();
				}
				if (this.vmethod_8().SelectedIndex == 8)
				{
					EventTrigger_ScenLoaded eventTrigger_ScenLoaded = new EventTrigger_ScenLoaded();
					eventTrigger_ScenLoaded.strDescription = "Scenario is Loaded";
					Client.GetClientScenario().GetEventTriggers().Add(eventTrigger_ScenLoaded.GetGuid(), eventTrigger_ScenLoaded);
					this.method_1();
				}
				else
				{
					this.editTrigger_0 = new EditTrigger();
					this.editTrigger_0.eventTrigger_0 = eventTrigger;
					this.editTrigger_0.enum187_0 = EditTrigger.Enum187.const_0;
					this.editTrigger_0.Show();
				}
			}
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x0015228C File Offset: 0x0015048C
		private void method_3(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				EventTrigger eventTrigger_ = Client.GetClientScenario().GetEventTriggers()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				this.editTrigger_0 = new EditTrigger();
				this.editTrigger_0.eventTrigger_0 = eventTrigger_;
				this.editTrigger_0.enum187_0 = EditTrigger.Enum187.const_1;
				this.editTrigger_0.Show();
			}
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x00152318 File Offset: 0x00150518
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				EventTrigger eventTrigger = Client.GetClientScenario().GetEventTriggers()[key];
				if (!Information.IsNothing(eventTrigger))
				{
					bool flag = false;
					using (IEnumerator<SimEvent> enumerator = Client.GetClientScenario().GetSimEvents().Values.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.Triggers.Contains(eventTrigger))
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag || Interaction.MsgBox("This trigger is used by at least one event, are you sure you want to delete it?", MsgBoxStyle.YesNo, "Trigger is in use!") != MsgBoxResult.No)
					{
						Client.GetClientScenario().GetEventTriggers().Remove(eventTrigger.GetGuid());
						using (IEnumerator<SimEvent> enumerator2 = Client.GetClientScenario().GetSimEvents().Values.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								enumerator2.Current.Triggers.Remove(eventTrigger);
							}
						}
						this.method_1();
					}
				}
			}
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x00020798 File Offset: 0x0001E998
		private void ListTriggers_Shown(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void ListTriggers_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06003EF5 RID: 16117 RVA: 0x00004D83 File Offset: 0x00002F83
		private void ListTriggers_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x00152468 File Offset: 0x00150668
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				EventTrigger eventTrigger = Client.GetClientScenario().GetEventTriggers()[key].Clone();
				Client.GetClientScenario().GetEventTriggers().Add(eventTrigger.GetGuid(), eventTrigger);
				this.method_1();
			}
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x001524E8 File Offset: 0x001506E8
		private void method_6(object sender, EventArgs e)
		{
			if (!this.bool_0 && this.vmethod_0().SelectedRows.Count != 0)
			{
				this.string_0 = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
			}
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void ListTriggers_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001CEA RID: 7402
		public static Func<EventTrigger, string> EventTriggerFunc = (EventTrigger eventTrigger_0) => eventTrigger_0.strDescription;

		// Token: 0x04001CEC RID: 7404
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04001CED RID: 7405
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001CEE RID: 7406
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001CEF RID: 7407
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04001CF0 RID: 7408
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04001CF1 RID: 7409
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04001CF2 RID: 7410
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04001CF3 RID: 7411
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04001CF4 RID: 7412
		private EditTrigger editTrigger_0;

		// Token: 0x04001CF5 RID: 7413
		private string string_0;

		// Token: 0x04001CF6 RID: 7414
		private bool bool_0;
	}
}
