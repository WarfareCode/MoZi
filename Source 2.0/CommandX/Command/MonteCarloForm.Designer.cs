namespace Command
{
	// Token: 0x02000CE9 RID: 3305
	public sealed partial class MonteCarloForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06006C57 RID: 27735 RVA: 0x003CE78C File Offset: 0x003CC98C
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x003CE7D0 File Offset: 0x003CC9D0
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			this.vmethod_1(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.TextBox());
			this.vmethod_5(new global::System.Windows.Forms.Button());
			this.vmethod_7(new global::System.Windows.Forms.Label());
			this.vmethod_9(new global::System.Windows.Forms.TextBox());
			this.vmethod_11(new global::System.Windows.Forms.Button());
			this.vmethod_13(new global::System.Windows.Forms.Label());
			this.SetRunTimesNumeric(new global::System.Windows.Forms.NumericUpDown());
			this.SetRunButton(new global::System.Windows.Forms.Button());
			this.vmethod_19(new global::System.Windows.Forms.OpenFileDialog());
			this.vmethod_21(new global::System.Windows.Forms.FolderBrowserDialog());
			this.SetSimulator(new global::System.ComponentModel.BackgroundWorker());
			this.vmethod_25(new global::System.Windows.Forms.Label());
			this.vmethod_27(new global::System.Windows.Forms.Timer(this.icontainer_0));
			this.vmethod_29(new global::System.Windows.Forms.Label());
			this.vmethod_31(new global::System.Windows.Forms.TabControl());
			this.vmethod_33(new global::System.Windows.Forms.TabPage());
			this.vmethod_35(new global::System.Windows.Forms.TabPage());
			this.vmethod_47(new global::System.Windows.Forms.CheckBox());
			this.vmethod_49(new global::System.Windows.Forms.CheckBox());
			this.vmethod_51(new global::System.Windows.Forms.CheckBox());
			this.vmethod_45(new global::System.Windows.Forms.CheckBox());
			this.vmethod_37(new global::System.Windows.Forms.Label());
			this.SetElapsedTimeNumeric(new global::System.Windows.Forms.NumericUpDown());
			this.vmethod_41(new global::System.Windows.Forms.Label());
			this.vmethod_43(new global::System.Windows.Forms.CheckBox());
			this.vmethod_53(new global::System.Windows.Forms.Label());
			this.vmethod_55(new global::System.Windows.Forms.Button());
			((global::System.ComponentModel.ISupportInitialize)this.GetRunTimesNumeric()).BeginInit();
			this.vmethod_30().SuspendLayout();
			this.vmethod_32().SuspendLayout();
			this.vmethod_34().SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetElapsedTimeNumeric()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().AutoSize = true;
			this.vmethod_0().Location = new global::System.Drawing.Point(10, 12);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new global::System.Drawing.Size(91, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "仿真想定:";
			this.vmethod_2().Location = new global::System.Drawing.Point(90, 9);
			this.vmethod_2().Name = "TextBox1";
			this.vmethod_2().Size = new global::System.Drawing.Size(452, 20);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().Location = new global::System.Drawing.Point(548, 9);
			this.vmethod_4().Name = "Button_ScenarioFile";
			this.vmethod_4().Size = new global::System.Drawing.Size(75, 25);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "选择...";
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.vmethod_6().AutoSize = true;
			this.vmethod_6().Location = new global::System.Drawing.Point(10, 39);
			this.vmethod_6().Name = "Label2";
			this.vmethod_6().Size = new global::System.Drawing.Size(80, 13);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "仿真结果:";
			this.vmethod_8().Location = new global::System.Drawing.Point(90, 36);
			this.vmethod_8().Name = "TextBox_ResultsFolder";
			this.vmethod_8().Size = new global::System.Drawing.Size(452, 20);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_10().Location = new global::System.Drawing.Point(548, 36);
			this.vmethod_10().Name = "Button_ResultsPath";
			this.vmethod_10().Size = new global::System.Drawing.Size(75, 25);
			this.vmethod_10().TabIndex = 5;
			this.vmethod_10().Text = "选择...";
			this.vmethod_10().UseVisualStyleBackColor = true;
			this.vmethod_12().AutoSize = true;
			this.vmethod_12().Location = new global::System.Drawing.Point(10, 66);
			this.vmethod_12().Name = "Label3";
			this.vmethod_12().Size = new global::System.Drawing.Size(53, 13);
			this.vmethod_12().TabIndex = 6;
			this.vmethod_12().Text = "仿真次数:";
			this.GetRunTimesNumeric().Location = new global::System.Drawing.Point(90, 64);
			global::System.Windows.Forms.NumericUpDown runTimesNumeric = this.GetRunTimesNumeric();
			int[] array = new int[4];
			array[0] = 10000;
			runTimesNumeric.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown runTimesNumeric2 = this.GetRunTimesNumeric();
			int[] array2 = new int[4];
			array2[0] = 1;
			runTimesNumeric2.Minimum = new decimal(array2);
			this.GetRunTimesNumeric().Name = "NumericUpDown1";
			this.GetRunTimesNumeric().Size = new global::System.Drawing.Size(60, 20);
			this.GetRunTimesNumeric().TabIndex = 7;
			global::System.Windows.Forms.NumericUpDown runTimesNumeric3 = this.GetRunTimesNumeric();
			int[] array3 = new int[4];
			array3[0] = 10;
			runTimesNumeric3.Value = new decimal(array3);
			this.GetRunButton().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.GetRunButton().ForeColor = global::System.Drawing.Color.Green;
			this.GetRunButton().Location = new global::System.Drawing.Point(344, 185);
			this.GetRunButton().Name = "Button_Run";
			this.GetRunButton().Size = new global::System.Drawing.Size(157, 54);
			this.GetRunButton().TabIndex = 8;
			this.GetRunButton().Text = "开始";
			this.GetRunButton().UseVisualStyleBackColor = true;
			this.vmethod_18().DefaultExt = "scen";
			this.vmethod_18().FileName = "OpenFileDialog1";
			this.vmethod_24().AutoSize = true;
			this.vmethod_24().Location = new global::System.Drawing.Point(10, 193);
			this.vmethod_24().Name = "Label4";
			this.vmethod_24().Size = new global::System.Drawing.Size(64, 13);
			this.vmethod_24().TabIndex = 9;
			this.vmethod_24().Text = "仿真时间: ";
			this.vmethod_26().Interval = 50;
			this.vmethod_28().AutoSize = true;
			this.vmethod_28().Location = new global::System.Drawing.Point(10, 177);
			this.vmethod_28().Name = "Label5";
			this.vmethod_28().Size = new global::System.Drawing.Size(51, 13);
			this.vmethod_28().TabIndex = 10;
			this.vmethod_28().Text = "当前次数: ";
			this.vmethod_30().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_30().Controls.Add(this.vmethod_32());
			this.vmethod_30().Controls.Add(this.vmethod_34());
			this.vmethod_30().Location = new global::System.Drawing.Point(3, 3);
			this.vmethod_30().Name = "TabControl1";
			this.vmethod_30().SelectedIndex = 0;
			this.vmethod_30().Size = new global::System.Drawing.Size(676, 171);
			this.vmethod_30().TabIndex = 11;
			this.vmethod_32().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_32().Controls.Add(this.vmethod_0());
			this.vmethod_32().Controls.Add(this.vmethod_2());
			this.vmethod_32().Controls.Add(this.vmethod_4());
			this.vmethod_32().Controls.Add(this.vmethod_6());
			this.vmethod_32().Controls.Add(this.GetRunTimesNumeric());
			this.vmethod_32().Controls.Add(this.vmethod_8());
			this.vmethod_32().Controls.Add(this.vmethod_12());
			this.vmethod_32().Controls.Add(this.vmethod_10());
			this.vmethod_32().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_32().Name = "TabPage1";
			this.vmethod_32().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_32().Size = new global::System.Drawing.Size(668, 145);
			this.vmethod_32().TabIndex = 0;
			this.vmethod_32().Text = "通用设置";
			this.vmethod_34().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_34().Controls.Add(this.vmethod_46());
			this.vmethod_34().Controls.Add(this.vmethod_48());
			this.vmethod_34().Controls.Add(this.vmethod_50());
			this.vmethod_34().Controls.Add(this.vmethod_44());
			this.vmethod_34().Controls.Add(this.vmethod_36());
			this.vmethod_34().Controls.Add(this.GetElapsedTimeNumeric());
			this.vmethod_34().Controls.Add(this.vmethod_40());
			this.vmethod_34().Controls.Add(this.GetCB_Record());
			this.vmethod_34().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_34().Name = "TabPage2";
			this.vmethod_34().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_34().Size = new global::System.Drawing.Size(668, 145);
			this.vmethod_34().TabIndex = 1;
			this.vmethod_34().Text = "输出设置";
			this.vmethod_46().AutoSize = true;
			this.vmethod_46().Location = new global::System.Drawing.Point(10, 104);
			this.vmethod_46().Name = "CB_ExportMSAccess";
			this.vmethod_46().Size = new global::System.Drawing.Size(141, 17);
			this.vmethod_46().TabIndex = 7;
			this.vmethod_46().Text = "导出到MS Access数据库";
			this.vmethod_46().UseVisualStyleBackColor = true;
			this.vmethod_48().AutoSize = true;
			this.vmethod_48().Location = new global::System.Drawing.Point(10, 81);
			this.vmethod_48().Name = "CB_ExportTacview1x";
			this.vmethod_48().Size = new global::System.Drawing.Size(174, 17);
			this.vmethod_48().TabIndex = 6;
			this.vmethod_48().Text = "导出到Tacview 1.x ACMI文件";
			this.vmethod_48().UseVisualStyleBackColor = true;
			this.vmethod_50().AutoSize = true;
			this.vmethod_50().Location = new global::System.Drawing.Point(10, 58);
			this.vmethod_50().Name = "CB_ExportCSV";
			this.vmethod_50().Size = new global::System.Drawing.Size(108, 17);
			this.vmethod_50().TabIndex = 5;
			this.vmethod_50().Text = "导出到CSV文件";
			this.vmethod_50().UseVisualStyleBackColor = true;
			this.vmethod_44().AutoSize = true;
			this.vmethod_44().Location = new global::System.Drawing.Point(10, 35);
			this.vmethod_44().Name = "CB_ExportXML";
			this.vmethod_44().Size = new global::System.Drawing.Size(109, 17);
			this.vmethod_44().TabIndex = 4;
			this.vmethod_44().Text = "导出到XML文件";
			this.vmethod_44().UseVisualStyleBackColor = true;
			this.vmethod_36().AutoSize = true;
			this.vmethod_36().Location = new global::System.Drawing.Point(159, 13);
			this.vmethod_36().Name = "Label7";
			this.vmethod_36().Size = new global::System.Drawing.Size(47, 13);
			this.vmethod_36().TabIndex = 3;
			this.vmethod_36().Text = "秒";
			this.GetElapsedTimeNumeric().Location = new global::System.Drawing.Point(104, 10);
			global::System.Windows.Forms.NumericUpDown elapsedTimeNumeric = this.GetElapsedTimeNumeric();
			int[] array4 = new int[4];
			array4[0] = 60;
			elapsedTimeNumeric.Maximum = new decimal(array4);
			global::System.Windows.Forms.NumericUpDown elapsedTimeNumeric2 = this.GetElapsedTimeNumeric();
			int[] array5 = new int[4];
			array5[0] = 1;
			elapsedTimeNumeric2.Minimum = new decimal(array5);
			this.GetElapsedTimeNumeric().Name = "NumericUpDown2";
			this.GetElapsedTimeNumeric().Size = new global::System.Drawing.Size(53, 20);
			this.GetElapsedTimeNumeric().TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown elapsedTimeNumeric3 = this.GetElapsedTimeNumeric();
			int[] array6 = new int[4];
			array6[0] = 1;
			elapsedTimeNumeric3.Value = new decimal(array6);
			this.vmethod_40().AutoSize = true;
			this.vmethod_40().Location = new global::System.Drawing.Point(67, 12);
			this.vmethod_40().Name = "Label6";
			this.vmethod_40().Size = new global::System.Drawing.Size(36, 13);
			this.vmethod_40().TabIndex = 1;
			this.vmethod_40().Text = "每:";
			this.GetCB_Record().AutoSize = true;
			this.GetCB_Record().Location = new global::System.Drawing.Point(10, 11);
			this.GetCB_Record().Name = "CB_Record";
			this.GetCB_Record().Size = new global::System.Drawing.Size(61, 17);
			this.GetCB_Record().TabIndex = 0;
			this.GetCB_Record().Text = "录像";
			this.GetCB_Record().UseVisualStyleBackColor = true;
			this.vmethod_52().AutoSize = true;
			this.vmethod_52().Location = new global::System.Drawing.Point(10, 209);
			this.vmethod_52().MaximumSize = new global::System.Drawing.Size(300, 0);
			this.vmethod_52().Name = "Label_EventQueues";
			this.vmethod_52().Size = new global::System.Drawing.Size(78, 13);
			this.vmethod_52().TabIndex = 12;
			this.vmethod_52().Text = "事件队列:";
			this.vmethod_54().Enabled = false;
			this.vmethod_54().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_54().ForeColor = global::System.Drawing.Color.Red;
			this.vmethod_54().Location = new global::System.Drawing.Point(507, 185);
			this.vmethod_54().Name = "Button_Abort";
			this.vmethod_54().Size = new global::System.Drawing.Size(157, 54);
			this.vmethod_54().TabIndex = 13;
			this.vmethod_54().Text = "终止";
			this.vmethod_54().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(676, 249);
			base.Controls.Add(this.vmethod_54());
			base.Controls.Add(this.vmethod_52());
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.GetRunButton());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MonteCarloForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "蒙特卡洛仿真";
			base.TopMost = true;
			((global::System.ComponentModel.ISupportInitialize)this.GetRunTimesNumeric()).EndInit();
			this.vmethod_30().ResumeLayout(false);
			this.vmethod_32().ResumeLayout(false);
			this.vmethod_32().PerformLayout();
			this.vmethod_34().ResumeLayout(false);
			this.vmethod_34().PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetElapsedTimeNumeric()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04003E79 RID: 15993
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
