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
using ns2;
using ns32;
using ns33;

namespace Command
{
	// Token: 单元的传感器窗体
	[DesignerGenerated]
	public sealed partial class UnitSensors : CommandForm
	{
		// Token: 0x06005803 RID: 22531 RVA: 0x0026AFC0 File Offset: 0x002691C0
		public UnitSensors()
		{
			base.FormClosing += new FormClosingEventHandler(this.UnitSensors_FormClosing);
			base.Load += new EventHandler(this.UnitSensors_Load);
			base.Shown += new EventHandler(this.UnitSensors_Shown);
			base.SizeChanged += new EventHandler(this.UnitSensors_SizeChanged);
			base.KeyDown += new KeyEventHandler(this.UnitSensors_KeyDown);
			base.FormClosed += new FormClosedEventHandler(this.UnitSensors_FormClosed);
			this.dataTable_0 = new DataTable();
			this.list_0 = new List<Sensor>();
			this.list_1 = new List<Sensor>();
			this.list_2 = new List<Sensor>();
			this.InitializeComponent();
		}

		// Token: 0x06005806 RID: 22534 RVA: 0x0026B9D8 File Offset: 0x00269BD8
		[CompilerGenerated]
		internal  CheckBox vmethod_0()
		{
			return this.checkBox_0;
		}

		// Token: 0x06005807 RID: 22535 RVA: 0x0026B9F0 File Offset: 0x00269BF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(CheckBox checkBox_4)
		{
			EventHandler value = new EventHandler(this.method_20);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_0 = checkBox_4;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005808 RID: 22536 RVA: 0x0026BA3C File Offset: 0x00269C3C
		[CompilerGenerated]
		internal  CheckBox vmethod_2()
		{
			return this.checkBox_1;
		}

		// Token: 0x06005809 RID: 22537 RVA: 0x0026BA54 File Offset: 0x00269C54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(CheckBox checkBox_4)
		{
			EventHandler value = new EventHandler(this.method_14);
			CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_1 = checkBox_4;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600580A RID: 22538 RVA: 0x0026BAA0 File Offset: 0x00269CA0
		[CompilerGenerated]
		internal  CheckBox vmethod_4()
		{
			return this.checkBox_2;
		}

		// Token: 0x0600580B RID: 22539 RVA: 0x0026BAB8 File Offset: 0x00269CB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(CheckBox checkBox_4)
		{
			EventHandler value = new EventHandler(this.method_12);
			CheckBox checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_2 = checkBox_4;
			checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600580C RID: 22540 RVA: 0x0026BB04 File Offset: 0x00269D04
		[CompilerGenerated]
		internal  CheckBox vmethod_6()
		{
			return this.checkBox_3;
		}

		// Token: 0x0600580D RID: 22541 RVA: 0x0026BB1C File Offset: 0x00269D1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(CheckBox checkBox_4)
		{
			EventHandler value = new EventHandler(this.method_13);
			CheckBox checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_3 = checkBox_4;
			checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600580E RID: 22542 RVA: 0x0026BB68 File Offset: 0x00269D68
		[CompilerGenerated]
		internal  Label vmethod_8()
		{
			return this.label_0;
		}

		// Token: 0x0600580F RID: 22543 RVA: 0x00027E16 File Offset: 0x00026016
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x0026BB80 File Offset: 0x00269D80
		[CompilerGenerated]
		internal  ToolStrip vmethod_10()
		{
			return this.toolStrip_0;
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x00027E1F File Offset: 0x0002601F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStrip toolStrip_1)
		{
			this.toolStrip_0 = toolStrip_1;
		}

		// Token: 0x06005812 RID: 22546 RVA: 0x0026BB98 File Offset: 0x00269D98
		[CompilerGenerated]
		internal  ToolStripButton vmethod_12()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06005813 RID: 22547 RVA: 0x0026BBB0 File Offset: 0x00269DB0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(ToolStripButton toolStripButton_2)
		{
			EventHandler value = new EventHandler(this.method_15);
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

		// Token: 0x06005814 RID: 22548 RVA: 0x0026BBFC File Offset: 0x00269DFC
		[CompilerGenerated]
		internal  ToolStripButton vmethod_14()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06005815 RID: 22549 RVA: 0x0026BC14 File Offset: 0x00269E14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ToolStripButton toolStripButton_2)
		{
			EventHandler value = new EventHandler(this.method_19);
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

		// Token: 0x06005816 RID: 22550 RVA: 0x0026BC60 File Offset: 0x00269E60
		[CompilerGenerated]
		internal  Timer vmethod_16()
		{
			return this.timer_0;
		}

		// Token: 0x06005817 RID: 22551 RVA: 0x0026BC78 File Offset: 0x00269E78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_21);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_0 = timer_1;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06005818 RID: 22552 RVA: 0x0026BCC4 File Offset: 0x00269EC4
		[CompilerGenerated]
		internal  DataGridView vmethod_18()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06005819 RID: 22553 RVA: 0x0026BCDC File Offset: 0x00269EDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(DataGridView dataGridView_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_7);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_8);
			DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.method_9);
			DataGridViewCellPaintingEventHandler value4 = new DataGridViewCellPaintingEventHandler(this.method_16);
			EventHandler value5 = new EventHandler(this.method_17);
			EventHandler value6 = new EventHandler(this.method_18);
			DataGridView dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value;
				dataGridView.CellContentClick -= value2;
				dataGridView.CellContentDoubleClick -= value3;
				dataGridView.CellPainting -= value4;
				dataGridView.ReadOnlyChanged -= value5;
				dataGridView.SelectionChanged -= value6;
			}
			this.dataGridView_0 = dataGridView_1;
			dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value;
				dataGridView.CellContentClick += value2;
				dataGridView.CellContentDoubleClick += value3;
				dataGridView.CellPainting += value4;
				dataGridView.ReadOnlyChanged += value5;
				dataGridView.SelectionChanged += value6;
			}
		}

		// Token: 0x0600581A RID: 22554 RVA: 0x0026BDC4 File Offset: 0x00269FC4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_20()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x0600581B RID: 22555 RVA: 0x00027E28 File Offset: 0x00026028
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x0600581C RID: 22556 RVA: 0x0026BDDC File Offset: 0x00269FDC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_22()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x0600581D RID: 22557 RVA: 0x00027E31 File Offset: 0x00026031
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x0600581E RID: 22558 RVA: 0x0026BDF4 File Offset: 0x00269FF4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_24()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x00027E3A File Offset: 0x0002603A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x0026BE0C File Offset: 0x0026A00C
		[CompilerGenerated]
		internal  DataGridViewCheckBoxColumn vmethod_26()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x06005821 RID: 22561 RVA: 0x00027E43 File Offset: 0x00026043
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x06005822 RID: 22562 RVA: 0x0026BE24 File Offset: 0x0026A024
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_28()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x00027E4C File Offset: 0x0002604C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x0026BE3C File Offset: 0x0026A03C
		private void method_1(Subject class137_0, bool? nullable_0, bool bool_1, bool bool_2, bool bool_3, bool bool_4)
		{
			if (!bool_4 && !Information.IsNothing(class137_0) && class137_0.IsActiveUnit() && (!bool_1 || class137_0 == Client.GetHookedUnit()) && !Information.IsNothing(nullable_0) && base.Visible && class137_0.IsActiveUnit() && class137_0 == this.activeUnit_0)
			{
				this.method_3();
			}
		}

		// Token: 0x06005825 RID: 22565 RVA: 0x0026BE9C File Offset: 0x0026A09C
		private void method_10()
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.IsActiveUnit())
			{
				this.vmethod_18().DataSource = null;
				this.vmethod_18().Rows.Clear();
				this.dataTable_0.Columns.Clear();
				this.dataTable_0.Rows.Clear();
				this.dataTable_0.Columns.Add("Sensor", typeof(string));
				this.dataTable_0.Columns.Add("SensorType", typeof(string));
				this.dataTable_0.Columns.Add("Active", typeof(bool));
				this.dataTable_0.Columns.Add("Status", typeof(string));
				this.dataTable_0.Columns.Add("ObjectID", typeof(string));
				this.dataTable_0.Columns.Add("Order#", typeof(int));
				this.dataTable_0.Columns.Add("CanBeActive", typeof(bool));
				Sensor[] noneMCMSensors = this.activeUnit_0.GetNoneMCMSensors();
				int num = noneMCMSensors.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					Sensor sensor = noneMCMSensors[i];
					DataRow dataRow = this.dataTable_0.NewRow();
					dataRow["ObjectID"] = sensor.GetGuid();
					dataRow["Order#"] = i;
					dataRow["CanBeActive"] = sensor.IsActiveCapable();
					dataRow["Sensor"] = Misc.smethod_11(sensor.Name);
					dataRow["SensorType"] = sensor.Description;
					dataRow["Active"] = sensor.IsEmmitting();
					if (sensor.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational || Operators.CompareString(sensor.CheckPlatformStatus(), "None", false) == 0)
					{
						dataRow["Status"] = sensor.GetComponentStatus().ToString();
						if (sensor.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
						{
							dataRow["Status"] = "正常工作";
						}
						if (sensor.GetComponentStatus() == PlatformComponent._ComponentStatus.Damaged)
						{
							dataRow["Status"] = "受到毁伤";
						}
						if (sensor.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
						{
							dataRow["Status"] = "已被摧毁";
						}
					}
					else
					{
						dataRow["Status"] = "没有工作(" + sensor.CheckPlatformStatus() + ")";
					}
					this.dataTable_0.Rows.Add(dataRow);
				}
			}
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x0026C170 File Offset: 0x0026A370
		private void method_11()
		{
			int num = this.vmethod_18().Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataGridViewRow dataGridViewRow = this.vmethod_18().Rows[i];
				Sensor sensor = this.activeUnit_0.GetNoneMCMSensors()[Conversions.ToInteger(dataGridViewRow.Cells["Order#"].Value)];
				if (sensor.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
				{
					dataGridViewRow.DefaultCellStyle.BackColor = base.GetComponentColor(sensor);
					dataGridViewRow.DefaultCellStyle.ForeColor = Color.White;
					dataGridViewRow.ReadOnly = true;
				}
				DataGridViewCell dataGridViewCell = this.vmethod_18().Rows[Conversions.ToInteger(dataGridViewRow.Cells["Order#"].Value)].Cells["Active"];
				if (!sensor.IsActiveCapable())
				{
					dataGridViewCell.ReadOnly = true;
					dataGridViewCell.Value = false;
				}
			}
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x0026C26C File Offset: 0x0026A46C
		private void method_12(object sender, EventArgs e)
		{
			List<Sensor>.Enumerator enumerator = default(List<Sensor>.Enumerator);
			List<Sensor>.Enumerator enumerator2 = default(List<Sensor>.Enumerator);
			bool @checked;
			if (!(@checked = this.vmethod_4().Checked))
			{
                //ZSP  ERR  using (List<Sensor>.Enumerator enumerator2 = this.list_0.GetEnumerator())
                 enumerator2 = this.list_0.GetEnumerator();
				{
					while (enumerator2.MoveNext())
					{
						Sensor current = enumerator2.Current;
						if (!current.NonSearchAndTrackSensorOtherThanMCMAndMAD() && current.IsEmmitting())
						{
							current.TurnOff();
						}
					}
					goto IL_C0;
				}
			}
			if (@checked)
			{
				foreach (Sensor current2 in this.list_0)
				{
					if (!current2.NonSearchAndTrackSensorOtherThanMCMAndMAD() && !current2.IsEmmitting())
					{
						current2.TurnOn();
					}
				}
			}
			IL_C0:
			this.method_5();
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2475_0.method_0(true);
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x0026C384 File Offset: 0x0026A584
		private void method_13(object sender, EventArgs e)
		{
			List<Sensor>.Enumerator enumerator = default(List<Sensor>.Enumerator);
			List<Sensor>.Enumerator enumerator2 = default(List<Sensor>.Enumerator);
			bool @checked;
			if (!(@checked = this.vmethod_6().Checked))
			{
				try
				{
					enumerator2 = this.list_1.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						Sensor current = enumerator2.Current;
						if (!current.NonSearchAndTrackSensorOtherThanMCMAndMAD() && current.IsEmmitting())
						{
							current.TurnOff();
						}
					}
					goto IL_C8;
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
				}
			}
			if (@checked)
			{
				try
				{
					enumerator = this.list_1.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Sensor current2 = enumerator.Current;
						if (!current2.NonSearchAndTrackSensorOtherThanMCMAndMAD() && (!current2.IsEmmitting() & current2.IsActiveCapable()))
						{
							current2.TurnOn();
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			IL_C8:
			this.method_5();
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2475_0.method_0(true);
		}

		// Token: 0x06005829 RID: 22569 RVA: 0x0026C4A4 File Offset: 0x0026A6A4
		private void method_14(object sender, EventArgs e)
		{
			List<Sensor>.Enumerator enumerator = default(List<Sensor>.Enumerator);
			List<Sensor>.Enumerator enumerator2 = default(List<Sensor>.Enumerator);
			bool @checked;
			if (!(@checked = this.vmethod_2().Checked))
			{
				try
				{
					enumerator2 = this.list_2.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						Sensor current = enumerator2.Current;
						if (current.IsEmmitting())
						{
							current.TurnOff();
						}
					}
					goto IL_A8;
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
				}
			}
			if (@checked)
			{
				try
				{
					enumerator = this.list_2.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Sensor current2 = enumerator.Current;
						if (!current2.IsEmmitting())
						{
							current2.TurnOn();
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			IL_A8:
			this.method_5();
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2475_0.method_0(true);
		}

		// Token: 0x0600582A RID: 22570 RVA: 0x00027E55 File Offset: 0x00026055
		private void method_15(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetAddSensor().form_0 = this;
			CommandFactory.GetCommandMain().GetAddSensor().Show();
			Client.b_Completed = true;
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x0026C5A4 File Offset: 0x0026A7A4
		private void method_16(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex > -1 && e.ColumnIndex == this.vmethod_18().Columns.IndexOf(this.vmethod_18().Columns["Active"]))
			{
				if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.vmethod_18().Rows[e.RowIndex].Cells["CanBeActive"].Value, true, false))))
				{
					e.Paint(e.ClipBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);
					e.Handled = true;
				}
				else if (Operators.ConditionalCompareObjectEqual(this.vmethod_18().Rows[e.RowIndex].Cells["Status"].Value, "Damaged", false) || Operators.ConditionalCompareObjectEqual(this.vmethod_18().Rows[e.RowIndex].Cells["Status"].Value, "Destroyed", false))
				{
					e.Paint(e.ClipBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);
					e.Handled = true;
				}
			}
		}

		// Token: 0x0600582C RID: 22572 RVA: 0x0026C6D8 File Offset: 0x0026A8D8
		private void method_17(object sender, EventArgs e)
		{
			if (!this.vmethod_18().ReadOnly)
			{
				this.vmethod_18().ForeColor = Color.Black;
				this.vmethod_18().RowsDefaultCellStyle.SelectionForeColor = Color.Blue;
			}
			else
			{
				this.vmethod_18().ForeColor = Color.Gray;
				this.vmethod_18().RowsDefaultCellStyle.SelectionForeColor = Color.Gray;
			}
		}

		// Token: 0x0600582D RID: 22573 RVA: 0x0026C740 File Offset: 0x0026A940
		private void method_18(object sender, EventArgs e)
		{
			if (!this.vmethod_18().ReadOnly && this.vmethod_18().SelectedRows.Count > 0)
			{
				this.string_0 = Conversions.ToString(this.vmethod_18().SelectedRows[0].Cells["ObjectID"].Value);
			}
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x0026C7A8 File Offset: 0x0026A9A8
		private void method_19(object sender, EventArgs e)
		{
			Sensor sensor = null;
			if (!string.IsNullOrEmpty(this.string_0) && this.activeUnit_0.IsActiveUnit())
			{
				ActiveUnit activeUnit = this.activeUnit_0;
				Sensor[] noneMCMSensors = activeUnit.GetNoneMCMSensors();
				for (int i = 0; i < noneMCMSensors.Length; i++)
				{
					Sensor sensor2 = noneMCMSensors[i];
					if (Operators.CompareString(sensor2.GetGuid(), this.string_0, false) == 0)
					{
						sensor = sensor2;
						break;
					}
				}
				if (!Information.IsNothing(sensor))
				{
					activeUnit.RemoveSensor(sensor);
					this.method_3();
				}
				Client.b_Completed = true;
			}
		}

		// Token: 0x0600582F RID: 22575 RVA: 0x00027E7C File Offset: 0x0002607C
		private void method_2(Unit unit)
		{
			if (base.Visible && !Information.IsNothing(unit) && unit.IsActiveUnit())
			{
				this.activeUnit_0 = (ActiveUnit)unit;
				this.method_3();
			}
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x0026C838 File Offset: 0x0026AA38
		private void method_20(object sender, EventArgs e)
		{
			this.activeUnit_0.GetSensory().SetIsObeysEMCON(this.vmethod_0().Checked);
			this.vmethod_18().ReadOnly = this.activeUnit_0.GetSensory().IsObeysEMCON();
			this.vmethod_4().Enabled = this.vmethod_18().Enabled;
			this.vmethod_6().Enabled = this.vmethod_18().Enabled;
			this.vmethod_2().Enabled = this.vmethod_18().Enabled;
			CommandFactory.GetCommandMain().GetMainForm().method_3().class2475_0.method_0(true);
		}

		// Token: 0x06005831 RID: 22577 RVA: 0x00027EAE File Offset: 0x000260AE
		private void method_21(object sender, EventArgs e)
		{
			this.method_6();
			this.vmethod_16().Stop();
		}

		// Token: 0x06005832 RID: 22578 RVA: 0x00027EC1 File Offset: 0x000260C1
		public void method_3()
		{
			this.method_5();
			this.method_4();
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x0026C8D8 File Offset: 0x0026AAD8
		private void method_4()
		{
			Func<Sensor, bool> predicate = (Sensor argument0) => argument0.IsEmmitting();
			if (!Information.IsNothing(this.activeUnit_0))
			{
				this.list_0.Clear();
				this.list_1.Clear();
				this.list_2.Clear();
				if (this.activeUnit_0.IsActiveUnit())
				{
					ActiveUnit activeUnit = this.activeUnit_0;
					Sensor[] noneMCMSensors = activeUnit.GetNoneMCMSensors();
					for (int i = 0; i < noneMCMSensors.Length; i++)
					{
						Sensor sensor = noneMCMSensors[i];
						if (sensor.sensorType == Sensor.SensorType.Radar)
						{
							this.list_0.Add(sensor);
						}
					}
					List<Sensor> source = this.list_0;
					IEnumerable<Sensor> source2 = source.Where(predicate);
					if (source2.Count<Sensor>() == 0)
					{
						this.vmethod_4().Checked = false;
					}
					else if (source2.Count<Sensor>() != this.list_0.Count)
					{
						this.vmethod_4().CheckState = CheckState.Indeterminate;
					}
					else
					{
						this.vmethod_4().Checked = true;
					}
					Sensor[] noneMCMSensors2 = activeUnit.GetNoneMCMSensors();
					for (int j = 0; j < noneMCMSensors2.Length; j++)
					{
						Sensor sensor2 = noneMCMSensors2[j];
						if (sensor2.IsSonar())
						{
							this.list_1.Add(sensor2);
						}
					}
					List<Sensor> source3 = this.list_1;
					IEnumerable<Sensor> source4 = source3.Where(predicate);
					if (source4.Count<Sensor>() == 0)
					{
						this.vmethod_6().Checked = false;
					}
					else if (source4.Count<Sensor>() != this.list_1.Count)
					{
						this.vmethod_6().CheckState = CheckState.Indeterminate;
					}
					else
					{
						this.vmethod_6().Checked = true;
					}
					Sensor[] noneMCMSensors3 = activeUnit.GetNoneMCMSensors();
					for (int k = 0; k < noneMCMSensors3.Length; k++)
					{
						Sensor sensor3 = noneMCMSensors3[k];
						if (sensor3.IsJammer())
						{
							this.list_2.Add(sensor3);
						}
					}
					List<Sensor> source5 = this.list_2;
					IEnumerable<Sensor> source6 = source5.Where(predicate);
					if (source6.Count<Sensor>() == 0)
					{
						this.vmethod_2().Checked = false;
					}
					else if (source6.Count<Sensor>() == this.list_2.Count)
					{
						this.vmethod_2().Checked = true;
					}
					else
					{
						this.vmethod_2().CheckState = CheckState.Indeterminate;
					}
				}
			}
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x0026CB24 File Offset: 0x0026AD24
		public void method_5()
		{
			IEnumerator enumerator = null;
			IEnumerator enumerator2 = null;
			IEnumerator enumerator3 = null;
			this.vmethod_10().Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.IsActiveUnit())
			{
				this.method_10();
				if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.IsActiveUnit())
				{
					this.Text = "传感器—" + this.activeUnit_0.Name;
					this.vmethod_18().DataSource = this.dataTable_0;
					try
					{
						enumerator = this.vmethod_18().Columns.GetEnumerator();
						while (enumerator.MoveNext())
						{
							((DataGridViewColumn)enumerator.Current).SortMode = DataGridViewColumnSortMode.NotSortable;
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					this.vmethod_18().Columns["CanBeActive"].Visible = false;
					this.vmethod_18().Columns["Order#"].Visible = false;
					this.vmethod_18().Columns["ObjectID"].Visible = false;
					try
					{
						enumerator2 = ((IEnumerable)this.vmethod_18().Rows).GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator2.Current;
							if (!this.activeUnit_0.GetNoneMCMSensors()[Conversions.ToInteger(dataGridViewRow.Cells["Order#"].Value)].IsActiveCapable())
							{
								dataGridViewRow.ReadOnly = true;
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
					try
					{
						enumerator3 = this.vmethod_18().Columns.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DataGridViewColumn arg_1C8_0 = (DataGridViewColumn)enumerator3.Current;
						}
					}
					finally
					{
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					this.vmethod_18().Columns["Active"].Width = 40;
					this.vmethod_18().Columns["SensorType"].HeaderText = "传感器类型";
					this.method_11();
					this.vmethod_0().Checked = this.activeUnit_0.GetSensory().IsObeysEMCON();
					this.vmethod_18().ReadOnly = this.activeUnit_0.GetSensory().IsObeysEMCON();
				}
			}
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x0026CDC0 File Offset: 0x0026AFC0
		private void method_6()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				try
				{
					if (Information.IsNothing(this.activeUnit_0))
					{
						this.vmethod_18().Columns.Clear();
					}
					else if (this.activeUnit_0.GetSide(false) != Client.GetClientSide())
					{
						this.vmethod_18().Columns.Clear();
					}
					this.vmethod_10().Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200107", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				this.bool_0 = false;
			}
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x0026CE94 File Offset: 0x0026B094
		private void method_7(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex != -1 && e.ColumnIndex != -1 && !this.vmethod_18().ReadOnly && this.vmethod_18().Rows.Count != 0)
				{
					DataGridViewRow dataGridViewRow = this.vmethod_18().Rows[e.RowIndex];
					if (this.activeUnit_0.GetNoneMCMSensors()[e.RowIndex].GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
					{
						dataGridViewRow.Selected = false;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200108", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x0026CF68 File Offset: 0x0026B168
		private void method_8(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex != -1 && !this.vmethod_18().ReadOnly && this.vmethod_18().Rows.Count != 0)
				{
					DataGridViewColumn dataGridViewColumn = this.vmethod_18().Columns[e.ColumnIndex];
					if (this.activeUnit_0.GetNoneMCMSensors()[e.RowIndex].GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && Operators.CompareString(dataGridViewColumn.Name, "Active", false) == 0)
					{
						int num = Conversions.ToInteger(this.vmethod_18().Rows[e.RowIndex].Cells["Order#"].Value);
						if (this.activeUnit_0.GetNoneMCMSensors()[num].IsActiveCapable())
						{
							if (Operators.ConditionalCompareObjectEqual(this.vmethod_18().Rows[e.RowIndex].Cells["Active"].Value, false, false) && !this.activeUnit_0.GetNoneMCMSensors()[num].IsEmmitting())
							{
								this.activeUnit_0.GetNoneMCMSensors()[num].TurnOn();
								this.vmethod_18().Rows[e.RowIndex].Cells["Active"].Value = true;
							}
							else if (Operators.ConditionalCompareObjectEqual(this.vmethod_18().Rows[e.RowIndex].Cells["Active"].Value, true, false) && this.activeUnit_0.GetNoneMCMSensors()[num].IsEmmitting())
							{
								this.activeUnit_0.GetNoneMCMSensors()[num].TurnOff();
								this.vmethod_18().Rows[e.RowIndex].Cells["Active"].Value = false;
							}
							if (this.activeUnit_0.IsAircraft)
							{
								Sensor[] noneMCMSensors = this.activeUnit_0.GetNoneMCMSensors();
								string guid = noneMCMSensors[num].GetGuid();
								for (int i = noneMCMSensors.Length - 1; i >= 0; i += -1)
								{
									if (Operators.CompareString(noneMCMSensors[i].GetGuid(), guid, false) == 0)
									{
										this.vmethod_18().Rows[i].Cells["Active"].Value = RuntimeHelpers.GetObjectValue(this.vmethod_18().Rows[e.RowIndex].Cells["Active"].Value);
									}
								}
							}
							this.method_3();
							Client.b_Completed = true;
							CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200109", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x00027ECF File Offset: 0x000260CF
		private void method_9(object sender, DataGridViewCellEventArgs e)
		{
			this.method_3();
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			Client.b_Completed = true;
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x00027EEC File Offset: 0x000260EC
		private void UnitSensors_FormClosed(object sender, FormClosedEventArgs e)
		{
			Client.smethod_16(new Client.Delegate50(this.method_2));
			Doctrine.smethod_3(new Doctrine.Delegate10(this.method_1));
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x00004D83 File Offset: 0x00002F83
		private void UnitSensors_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x00228538 File Offset: 0x00226738
		private void UnitSensors_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F9 && base.Visible)
			{
				base.Close();
			}
			else if (!base.Visible || (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Space))
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x0026D2A4 File Offset: 0x0026B4A4
		private void UnitSensors_Load(object sender, EventArgs e)
		{
			Doctrine.smethod_2(new Doctrine.Delegate10(this.method_1));
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (Client.GetHookedUnit().IsActiveUnit())
			{
				this.activeUnit_0 = (ActiveUnit)Client.GetHookedUnit();
			}
			this.Text = Client.GetHookedUnit().Name + "传感器";
			Client.smethod_15(new Client.Delegate50(this.method_2));
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x0026D324 File Offset: 0x0026B524
		private void UnitSensors_Shown(object sender, EventArgs e)
		{
			if (this.vmethod_18().ReadOnly)
			{
				this.vmethod_18().ForeColor = Color.Gray;
				this.vmethod_18().RowsDefaultCellStyle.SelectionForeColor = Color.Gray;
			}
			else
			{
				this.vmethod_18().ForeColor = Color.Black;
				this.vmethod_18().RowsDefaultCellStyle.SelectionForeColor = Color.Blue;
			}
			this.method_3();
			this.method_3();
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x00027F10 File Offset: 0x00026110
		private void UnitSensors_SizeChanged(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x04002B59 RID: 11097
		private DataTable dataTable_0;

		// Token: 0x04002B5A RID: 11098
		private List<Sensor> list_0;

		// Token: 0x04002B5B RID: 11099
		private List<Sensor> list_1;

		// Token: 0x04002B5C RID: 11100
		private List<Sensor> list_2;

		// Token: 0x04002B5D RID: 11101
		private bool bool_0;

		// Token: 0x04002B5E RID: 11102
		private string string_0;

		// Token: 0x04002B5F RID: 11103
		private ActiveUnit activeUnit_0;

		// Token: 0x04002B60 RID: 11104
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04002B61 RID: 11105
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x04002B62 RID: 11106
		[CompilerGenerated]
		private CheckBox checkBox_2;

		// Token: 0x04002B63 RID: 11107
		[CompilerGenerated]
		private CheckBox checkBox_3;

		// Token: 0x04002B64 RID: 11108
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04002B65 RID: 11109
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x04002B66 RID: 11110
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04002B67 RID: 11111
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x04002B68 RID: 11112
		[CompilerGenerated]
		private Timer timer_0;

		// Token: 0x04002B69 RID: 11113
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04002B6A RID: 11114
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04002B6B RID: 11115
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04002B6C RID: 11116
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04002B6D RID: 11117
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x04002B6E RID: 11118
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
	}
}
