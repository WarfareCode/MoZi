namespace Command
{
	// Token: 0x02000A2F RID: 2607
	
	public sealed partial class TankerPlanner : global::ns33.CommandForm
	{
		// Token: 0x0600528C RID: 21132 RVA: 0x0021BE24 File Offset: 0x0021A024
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

		// Token: 0x0600528D RID: 21133 RVA: 0x0021BE68 File Offset: 0x0021A068
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.RadioButton());
			this.vmethod_3(new global::System.Windows.Forms.RadioButton());
			this.vmethod_5(new global::System.Windows.Forms.GroupBox());
			this.vmethod_7(new global::System.Windows.Forms.RadioButton());
			this.vmethod_9(new global::System.Windows.Forms.RadioButton());
			this.vmethod_11(new global::System.Windows.Forms.RadioButton());
			this.vmethod_13(new global::System.Windows.Forms.RadioButton());
			this.vmethod_15(new global::System.Windows.Forms.RadioButton());
			this.vmethod_17(new global::System.Windows.Forms.TextBox());
			this.vmethod_19(new global::System.Windows.Forms.Label());
			this.vmethod_21(new global::System.Windows.Forms.Label());
			this.vmethod_23(new global::System.Windows.Forms.TextBox());
			this.vmethod_25(new global::System.Windows.Forms.Label());
			this.vmethod_27(new global::System.Windows.Forms.TextBox());
			this.vmethod_29(new global::System.Windows.Forms.ListBox());
			this.vmethod_31(new global::System.Windows.Forms.Label());
			this.vmethod_33(new global::System.Windows.Forms.TextBox());
			this.vmethod_35(new global::System.Windows.Forms.CheckBox());
			this.vmethod_37(new global::System.Windows.Forms.GroupBox());
			this.vmethod_39(new global::System.Windows.Forms.GroupBox());
			this.vmethod_41(new global::System.Windows.Forms.Label());
			this.vmethod_43(new global::System.Windows.Forms.TextBox());
			this.vmethod_45(new global::System.Windows.Forms.Label());
			this.vmethod_47(new global::System.Windows.Forms.CheckBox());
			this.vmethod_4().SuspendLayout();
			this.vmethod_36().SuspendLayout();
			this.vmethod_38().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().AutoSize = true;
			this.vmethod_0().Location = new global::System.Drawing.Point(12, 29);
			this.vmethod_0().Name = "RadioButton_Mission";
			this.vmethod_0().Size = new global::System.Drawing.Size(220, 17);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().TabStop = true;
			this.vmethod_0().Text = "使用已分配特定任务的加油机加油";
			this.vmethod_0().UseVisualStyleBackColor = true;
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().Location = new global::System.Drawing.Point(12, 12);
			this.vmethod_2().Name = "RadioButton_Automatic";
			this.vmethod_2().Size = new global::System.Drawing.Size(283, 17);
			this.vmethod_2().TabIndex = 3;
			this.vmethod_2().TabStop = true;
			this.vmethod_2().Text = "使用油量充足的最近加油机加油";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().Controls.Add(this.vmethod_6());
			this.vmethod_4().Controls.Add(this.vmethod_8());
			this.vmethod_4().Controls.Add(this.vmethod_10());
			this.vmethod_4().Controls.Add(this.vmethod_12());
			this.vmethod_4().Controls.Add(this.vmethod_14());
			this.vmethod_4().Location = new global::System.Drawing.Point(352, 190);
			this.vmethod_4().Name = "GroupBox1";
			this.vmethod_4().Size = new global::System.Drawing.Size(423, 105);
			this.vmethod_4().TabIndex = 4;
			this.vmethod_4().TabStop = false;
			this.vmethod_4().Text = "空中受油机多远距离上寻找加油机：";
			this.vmethod_6().AutoSize = true;
			this.vmethod_6().Location = new global::System.Drawing.Point(6, 85);
			this.vmethod_6().Name = "RadioButton_TankerMaxDistance_Airborne_50";
			this.vmethod_6().Size = new global::System.Drawing.Size(54, 17);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_6().TabStop = true;
			this.vmethod_6().Text = "50海里";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_8().AutoSize = true;
			this.vmethod_8().Location = new global::System.Drawing.Point(6, 68);
			this.vmethod_8().Name = "RadioButton_TankerMaxDistance_Airborne_100";
			this.vmethod_8().Size = new global::System.Drawing.Size(60, 17);
			this.vmethod_8().TabIndex = 3;
			this.vmethod_8().TabStop = true;
			this.vmethod_8().Text = "100海里";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Location = new global::System.Drawing.Point(6, 51);
			this.vmethod_10().Name = "RadioButton_TankerMaxDistance_Airborne_250";
			this.vmethod_10().Size = new global::System.Drawing.Size(60, 17);
			this.vmethod_10().TabIndex = 2;
			this.vmethod_10().TabStop = true;
			this.vmethod_10().Text = "250海里";
			this.vmethod_10().UseVisualStyleBackColor = true;
			this.vmethod_12().AutoSize = true;
			this.vmethod_12().Location = new global::System.Drawing.Point(6, 34);
			this.vmethod_12().Name = "RadioButton_TankerMaxDistance_Airborne_500";
			this.vmethod_12().Size = new global::System.Drawing.Size(60, 17);
			this.vmethod_12().TabIndex = 1;
			this.vmethod_12().TabStop = true;
			this.vmethod_12().Text = "500海里";
			this.vmethod_12().UseVisualStyleBackColor = true;
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Location = new global::System.Drawing.Point(6, 17);
			this.vmethod_14().Name = "RadioButton_TankerMaxDistance_Airborne_Tactical";
			this.vmethod_14().Size = new global::System.Drawing.Size(320, 17);
			this.vmethod_14().TabIndex = 0;
			this.vmethod_14().TabStop = true;
			this.vmethod_14().Text = "当前燃油负载和航行剖面下受油机的战术半径";
			this.vmethod_14().UseVisualStyleBackColor = true;
			this.vmethod_16().Location = new global::System.Drawing.Point(249, 14);
			this.vmethod_16().Name = "TextBox_TankerMinimum_Total";
			this.vmethod_16().Size = new global::System.Drawing.Size(100, 20);
			this.vmethod_16().TabIndex = 6;
			this.vmethod_18().Location = new global::System.Drawing.Point(4, 17);
			this.vmethod_18().Name = "Label1";
			this.vmethod_18().Size = new global::System.Drawing.Size(178, 13);
			this.vmethod_18().TabIndex = 7;
			this.vmethod_18().Text = "需要加油机的最小数量";
			this.vmethod_20().Location = new global::System.Drawing.Point(4, 38);
			this.vmethod_20().Name = "Label2";
			this.vmethod_20().Size = new global::System.Drawing.Size(180, 13);
			this.vmethod_20().TabIndex = 9;
			this.vmethod_20().Text = "留空的加油机最小数量";
			this.vmethod_22().Location = new global::System.Drawing.Point(249, 35);
			this.vmethod_22().Name = "TextBox_TankerMinimum_Airborne";
			this.vmethod_22().Size = new global::System.Drawing.Size(100, 20);
			this.vmethod_22().TabIndex = 8;
			this.vmethod_24().Location = new global::System.Drawing.Point(4, 59);
			this.vmethod_24().Name = "Label3";
			this.vmethod_24().Size = new global::System.Drawing.Size(188, 13);
			this.vmethod_24().TabIndex = 11;
			this.vmethod_24().Text = "阵位上加油机最小数量";
			this.vmethod_26().Location = new global::System.Drawing.Point(249, 56);
			this.vmethod_26().Name = "TextBox_TankerMinimum_Station";
			this.vmethod_26().Size = new global::System.Drawing.Size(100, 20);
			this.vmethod_26().TabIndex = 10;
			this.vmethod_28().DisplayMember = "Name";
			this.vmethod_28().FormattingEnabled = true;
			this.vmethod_28().IntegralHeight = false;
			this.vmethod_28().Location = new global::System.Drawing.Point(32, 50);
			this.vmethod_28().Name = "ListBox_Tankers";
			this.vmethod_28().SelectionMode = global::System.Windows.Forms.SelectionMode.MultiSimple;
			this.vmethod_28().Size = new global::System.Drawing.Size(314, 245);
			this.vmethod_28().TabIndex = 15;
			this.vmethod_30().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_30().Name = "Label6";
			this.vmethod_30().Size = new global::System.Drawing.Size(245, 13);
			this.vmethod_30().TabIndex = 18;
			this.vmethod_30().Text = "每架加油机允许加油队列最大长度";
			this.vmethod_32().Location = new global::System.Drawing.Point(249, 19);
			this.vmethod_32().Name = "TextBox_MaxReceiversInQueuePerTanker_Airborne";
			this.vmethod_32().Size = new global::System.Drawing.Size(100, 20);
			this.vmethod_32().TabIndex = 17;
			this.vmethod_34().AutoSize = true;
			this.vmethod_34().Location = new global::System.Drawing.Point(6, 78);
			this.vmethod_34().Name = "CheckBox_LaunchMissionWithoutTankersInPlace";
			this.vmethod_34().Size = new global::System.Drawing.Size(295, 17);
			this.vmethod_34().TabIndex = 19;
			this.vmethod_34().Text = "加油机没到位的情况下启动任务(极端危险!)";
			this.vmethod_34().UseVisualStyleBackColor = true;
			this.vmethod_36().Controls.Add(this.vmethod_18());
			this.vmethod_36().Controls.Add(this.vmethod_16());
			this.vmethod_36().Controls.Add(this.vmethod_34());
			this.vmethod_36().Controls.Add(this.vmethod_22());
			this.vmethod_36().Controls.Add(this.vmethod_20());
			this.vmethod_36().Controls.Add(this.vmethod_26());
			this.vmethod_36().Controls.Add(this.vmethod_24());
			this.vmethod_36().Location = new global::System.Drawing.Point(352, 12);
			this.vmethod_36().Name = "GroupBox3";
			this.vmethod_36().Size = new global::System.Drawing.Size(423, 100);
			this.vmethod_36().TabIndex = 21;
			this.vmethod_36().TabStop = false;
			this.vmethod_36().Text = "任务规划设置";
			this.vmethod_38().Controls.Add(this.vmethod_40());
			this.vmethod_38().Controls.Add(this.vmethod_42());
			this.vmethod_38().Controls.Add(this.vmethod_46());
			this.vmethod_38().Controls.Add(this.vmethod_44());
			this.vmethod_38().Controls.Add(this.vmethod_32());
			this.vmethod_38().Controls.Add(this.vmethod_30());
			this.vmethod_38().Location = new global::System.Drawing.Point(352, 118);
			this.vmethod_38().Name = "GroupBox4";
			this.vmethod_38().Size = new global::System.Drawing.Size(423, 84);
			this.vmethod_38().TabIndex = 22;
			this.vmethod_38().TabStop = false;
			this.vmethod_38().Text = "任务执行设置";
			this.vmethod_40().Location = new global::System.Drawing.Point(272, 43);
			this.vmethod_40().Name = "Label8";
			this.vmethod_40().Size = new global::System.Drawing.Size(115, 13);
			this.vmethod_40().TabIndex = 21;
			this.vmethod_40().Text = "%任务油量";
			this.vmethod_42().Location = new global::System.Drawing.Point(238, 40);
			this.vmethod_42().Name = "TextBox_FuelQtyToStartLookingForTanker";
			this.vmethod_42().Size = new global::System.Drawing.Size(32, 20);
			this.vmethod_42().TabIndex = 19;
			this.vmethod_44().Location = new global::System.Drawing.Point(4, 43);
			this.vmethod_44().Name = "Label7";
			this.vmethod_44().Size = new global::System.Drawing.Size(236, 13);
			this.vmethod_44().TabIndex = 20;
			this.vmethod_44().Text = "受油机寻找加油机的时机条件：";
			this.vmethod_46().AutoSize = true;
			this.vmethod_46().Location = new global::System.Drawing.Point(6, 62);
			this.vmethod_46().Name = "CB_FollowReceivers";
			this.vmethod_46().Size = new global::System.Drawing.Size(188, 17);
			this.vmethod_46().TabIndex = 19;
			this.vmethod_46().Text = "加油机遵循受油机的飞行计划";
			this.vmethod_46().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(789, 307);
			base.Controls.Add(this.vmethod_38());
			base.Controls.Add(this.vmethod_36());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "TankerPlanner";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "空中加油任务设置";
			base.TopMost = true;
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_4().PerformLayout();
			this.vmethod_36().ResumeLayout(false);
			this.vmethod_36().PerformLayout();
			this.vmethod_38().ResumeLayout(false);
			this.vmethod_38().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040026BB RID: 9915
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
