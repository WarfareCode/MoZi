using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Command
{
	// 卫星预测窗口
	[DesignerGenerated]
	public sealed partial class SatPredictionForm : Form
	{
		// Token: 0x06006CE3 RID: 27875 RVA: 0x003D1B98 File Offset: 0x003CFD98
		public SatPredictionForm()
		{
			base.Shown += new EventHandler(this.SatPredictionForm_Shown);
			base.FormClosing += new FormClosingEventHandler(this.SatPredictionForm_FormClosing);
			base.Load += new EventHandler(this.SatPredictionForm_Load);
			this.bool_0 = false;
			this.InitializeComponent();
		}

		// Token: 0x06006CE6 RID: 27878 RVA: 0x003D219C File Offset: 0x003D039C
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06006CE7 RID: 27879 RVA: 0x0002E99B File Offset: 0x0002CB9B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_1)
		{
			this.dataGridView_0 = dataGridView_1;
		}

		// Token: 0x06006CE8 RID: 27880 RVA: 0x003D21B4 File Offset: 0x003D03B4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_2()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06006CE9 RID: 27881 RVA: 0x0002E9A4 File Offset: 0x0002CBA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06006CEA RID: 27882 RVA: 0x003D21CC File Offset: 0x003D03CC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_4()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06006CEB RID: 27883 RVA: 0x0002E9AD File Offset: 0x0002CBAD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x003D21E4 File Offset: 0x003D03E4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_6()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06006CED RID: 27885 RVA: 0x0002E9B6 File Offset: 0x0002CBB6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06006CEE RID: 27886 RVA: 0x003D21FC File Offset: 0x003D03FC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_8()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06006CEF RID: 27887 RVA: 0x0002E9BF File Offset: 0x0002CBBF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06006CF0 RID: 27888 RVA: 0x003D2214 File Offset: 0x003D0414
		[CompilerGenerated]
		internal  Label vmethod_10()
		{
			return this.label_0;
		}

		// Token: 0x06006CF1 RID: 27889 RVA: 0x0002E9C8 File Offset: 0x0002CBC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Label label_2)
		{
			this.label_0 = label_2;
		}

		// Token: 0x06006CF2 RID: 27890 RVA: 0x003D222C File Offset: 0x003D042C
		[CompilerGenerated]
		internal  NumericUpDown vmethod_12()
		{
			return this.numericUpDown_0;
		}

		// Token: 0x06006CF3 RID: 27891 RVA: 0x003D2244 File Offset: 0x003D0444
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(NumericUpDown numericUpDown_1)
		{
			EventHandler value = new EventHandler(this.method_1);
			NumericUpDown numericUpDown = this.numericUpDown_0;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged -= value;
			}
			this.numericUpDown_0 = numericUpDown_1;
			numericUpDown = this.numericUpDown_0;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged += value;
			}
		}

		// Token: 0x06006CF4 RID: 27892 RVA: 0x003D2290 File Offset: 0x003D0490
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_1;
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x0002E9D1 File Offset: 0x0002CBD1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_2)
		{
			this.label_1 = label_2;
		}

		// Token: 0x06006CF6 RID: 27894 RVA: 0x003D22A8 File Offset: 0x003D04A8
		[CompilerGenerated]
		internal  Button vmethod_16()
		{
			return this.button_0;
		}

		// Token: 0x06006CF7 RID: 27895 RVA: 0x003D22C0 File Offset: 0x003D04C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Button button_1)
		{
			EventHandler value = new EventHandler(this.method_2);
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

		// Token: 0x06006CF8 RID: 27896 RVA: 0x003D230C File Offset: 0x003D050C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_18()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06006CF9 RID: 27897 RVA: 0x0002E9DA File Offset: 0x0002CBDA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06006CFA RID: 27898 RVA: 0x003D2324 File Offset: 0x003D0524
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_20()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06006CFB RID: 27899 RVA: 0x0002E9E3 File Offset: 0x0002CBE3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06006CFC RID: 27900 RVA: 0x003D233C File Offset: 0x003D053C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_22()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06006CFD RID: 27901 RVA: 0x0002E9EC File Offset: 0x0002CBEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06006CFE RID: 27902 RVA: 0x003D2354 File Offset: 0x003D0554
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_24()
		{
			return this.dataGridViewTextBoxColumn_7;
		}

		// Token: 0x06006CFF RID: 27903 RVA: 0x0002E9F5 File Offset: 0x0002CBF5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_7 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06006D00 RID: 27904 RVA: 0x003D236C File Offset: 0x003D056C
		[CompilerGenerated]
		internal  BackgroundWorker vmethod_26()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x06006D01 RID: 27905 RVA: 0x003D2384 File Offset: 0x003D0584
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler value = new DoWorkEventHandler(this.method_3);
			RunWorkerCompletedEventHandler value2 = new RunWorkerCompletedEventHandler(this.method_4);
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

		// Token: 0x06006D02 RID: 27906 RVA: 0x003D23E8 File Offset: 0x003D05E8
		public void method_0()
		{
			this.vmethod_16().Text = "计算...";
			this.vmethod_16().Enabled = false;
			this.vmethod_12().Enabled = false;
			if (!this.bool_0)
			{
				this.vmethod_27(new BackgroundWorker());
				this.vmethod_26().WorkerSupportsCancellation = true;
				this.vmethod_26().RunWorkerAsync();
			}
		}

		// Token: 0x06006D03 RID: 27907 RVA: 0x0002E9FE File Offset: 0x0002CBFE
		private void method_1(object sender, EventArgs e)
		{
			this.int_0 = Convert.ToInt32(this.vmethod_12().Value);
		}

		// Token: 0x06006D04 RID: 27908 RVA: 0x0002EA16 File Offset: 0x0002CC16
		private void method_2(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06006D05 RID: 27909 RVA: 0x0002EA1E File Offset: 0x0002CC1E
		private void SatPredictionForm_Shown(object sender, EventArgs e)
		{
			this.int_0 = 3;
			this.vmethod_12().Value = new decimal(this.int_0);
			this.method_0();
		}

		// Token: 0x06006D06 RID: 27910 RVA: 0x003D2448 File Offset: 0x003D0648
		private void method_3(object sender, DoWorkEventArgs e)
		{
			try
			{
				this.bool_0 = true;
				GeoPoint geoPoint_ = new GeoPoint(this.double_0, this.double_1);
				Unit unit = new Unit();
				bool flag = false;
				this.list_0 = new List<SatPredictionForm.Class2501>();
				foreach (ActiveUnit current in Client.GetClientScenario().GetActiveUnitList())
				{
					if (current.IsSatellite())
					{
						Satellite satellite = (Satellite)current;
						float num = satellite.GetAllNoneMCMSensors().Select(SatPredictionForm.SensorFunc).Max();
						int num2 = this.int_0 * 24 * 3600;
						for (int i = 15; i <= num2; i++)
						{
							if (this.vmethod_26().CancellationPending)
							{
								return;
							}
							DateTime dateTime = Client.GetClientScenario().GetCurrentTime(false).AddSeconds((double)i);
							Satellite_Kinematics satelliteKinematics = satellite.GetSatelliteKinematics();
							DateTime dateTime_ = dateTime;
							Unit unit3;
							Unit unit2 = unit3 = unit;
							bool? hintIsOperating = null;
							double latitude = unit3.GetLatitude(hintIsOperating);
							Unit unit5;
							Unit unit4 = unit5 = unit;
							bool? hintIsOperating2 = null;
							double longitude = unit5.GetLongitude(hintIsOperating2);
							double num3 = (double)0f;
							double num4 = 0.0;
							satelliteKinematics.CalculateOrbit(dateTime_, ref latitude, ref longitude, ref num4, ref num3);
							unit4.SetLongitude(hintIsOperating2, longitude);
							unit2.SetLatitude(hintIsOperating, latitude);
							unit.SetAltitude_ASL(false, (float)(num4 * 1000.0));

                            SatPredictionForm.Class2501 @class = new SatPredictionForm.Class2501();
                            if (unit.SlantRangeTo(geoPoint_) < num)
							{
								if (!flag)
								{
									
									@class.satellite_0 = satellite;
									@class.dateTime_0 = dateTime;
									@class.long_0 = 0L;
									flag = true;
								}
								else
								{
                                    //SatPredictionForm.Class2501 @class ;
                                    @class.satellite_0 = satellite;
                                    @class.dateTime_0 = dateTime;
                                    @class.long_0 += 15L;
								}
							}
							else if (flag)
							{
                                //SatPredictionForm.Class2501 @class ;
                                @class.satellite_0 = satellite;
                                @class.dateTime_0 = dateTime;
                                @class.long_0 += 15L;
								this.list_0.Add(@class);
								flag = false;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200403", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				this.bool_0 = false;
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006D07 RID: 27911 RVA: 0x003D26E8 File Offset: 0x003D08E8
		private void method_4(object sender, RunWorkerCompletedEventArgs e)
		{
			try
			{
				this.vmethod_0().SuspendLayout();
				this.vmethod_0().Rows.Clear();
				foreach (SatPredictionForm.Class2501 current in this.list_0)
				{
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					dataGridViewRow.CreateCells(this.vmethod_0());
					dataGridViewRow.Cells[0].Value = current.satellite_0.Name + " (" + current.satellite_0.UnitClass + ")";
					dataGridViewRow.Cells[1].Value = current.satellite_0.GetSide(false).GetSideName();
					dataGridViewRow.Cells[2].Value = Strings.Format(current.dateTime_0, "yyyy/MM/dd HH:mm:ss") + " (" + Misc.GetTimeString((long)Math.Round((current.dateTime_0 - Client.GetClientScenario().GetCurrentTime(false)).TotalSeconds), Aircraft_AirOps._Maintenance.const_0, false, false) + " from now)";
					dataGridViewRow.Cells[3].Value = Misc.GetTimeString(current.long_0, Aircraft_AirOps._Maintenance.const_0, false, false);
					this.vmethod_0().Rows.Add(dataGridViewRow);
				}
				this.vmethod_0().ResumeLayout();
				this.vmethod_16().Text = "重新计算";
				this.vmethod_16().Enabled = true;
				this.vmethod_12().Enabled = true;
				this.bool_0 = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200404", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				this.bool_0 = false;
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006D08 RID: 27912 RVA: 0x0002EA43 File Offset: 0x0002CC43
		private void SatPredictionForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.vmethod_26().CancelAsync();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06006D09 RID: 27913 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void SatPredictionForm_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04003EC3 RID: 16067
		public static Func<Sensor, float> SensorFunc = (Sensor sensor_0) => sensor_0.MaxRange;

		// Token: 0x04003EC5 RID: 16069
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04003EC6 RID: 16070
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04003EC7 RID: 16071
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04003EC8 RID: 16072
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04003EC9 RID: 16073
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04003ECA RID: 16074
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04003ECB RID: 16075
		[CompilerGenerated]
		private NumericUpDown numericUpDown_0;

		// Token: 0x04003ECC RID: 16076
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04003ECD RID: 16077
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04003ECE RID: 16078
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04003ECF RID: 16079
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x04003ED0 RID: 16080
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x04003ED1 RID: 16081
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		// Token: 0x04003ED2 RID: 16082
		public double double_0;

		// Token: 0x04003ED3 RID: 16083
		public double double_1;

		// Token: 0x04003ED4 RID: 16084
		private int int_0;

		// Token: 0x04003ED5 RID: 16085
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04003ED6 RID: 16086
		private List<SatPredictionForm.Class2501> list_0;

		// Token: 0x04003ED7 RID: 16087
		private bool bool_0;

		// Token: 0x02000CEF RID: 3311
		private sealed class Class2501
		{
			// Token: 0x04003ED9 RID: 16089
			public Satellite satellite_0;

			// Token: 0x04003EDA RID: 16090
			public DateTime dateTime_0;

			// Token: 0x04003EDB RID: 16091
			public long long_0;
		}
	}
}
