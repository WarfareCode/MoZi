namespace ns34
{
	// Token: 0x020009A0 RID: 2464
	
	public sealed partial class LoadGroup : global::ns33.CommandForm
	{
		// Token: 0x06003FD4 RID: 16340 RVA: 0x0015816C File Offset: 0x0015636C
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

		// Token: 0x06003FD5 RID: 16341 RVA: 0x001581B0 File Offset: 0x001563B0
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.TreeView());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.Label());
			this.vmethod_9(new global::System.Windows.Forms.Label());
			this.vmethod_11(new global::System.Windows.Forms.Label());
			this.vmethod_13(new global::System.Windows.Forms.Label());
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.vmethod_17(new global::System.Windows.Forms.FlowLayoutPanel());
			this.vmethod_19(new global::System.Windows.Forms.Label());
			this.vmethod_21(new global::System.Windows.Forms.Label());
			this.vmethod_23(new global::System.Windows.Forms.ListView());
			this.vmethod_25(new global::System.Windows.Forms.Button());
			this.vmethod_27(new global::System.Windows.Forms.Button());
			this.vmethod_29(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_31(new global::System.Windows.Forms.ToolStripLabel());
			this.vmethod_33(new global::System.Windows.Forms.CheckBox());
			this.vmethod_16().SuspendLayout();
			this.vmethod_28().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_0().CheckBoxes = true;
			this.vmethod_0().Location = new global::System.Drawing.Point(12, 36);
			this.vmethod_0().Name = "TV1";
			this.vmethod_0().Size = new global::System.Drawing.Size(268, 523);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().Location = new global::System.Drawing.Point(287, 13);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new global::System.Drawing.Size(70, 13);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "编组名称:";
			this.vmethod_4().AutoSize = true;
			this.vmethod_4().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_4().Location = new global::System.Drawing.Point(384, 13);
			this.vmethod_4().Name = "Label_Name";
			this.vmethod_4().Size = new global::System.Drawing.Size(14, 13);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "";
			this.vmethod_6().Location = new global::System.Drawing.Point(287, 38);
			this.vmethod_6().Name = "Label3";
			this.vmethod_6().Size = new global::System.Drawing.Size(80, 13);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "有效期始于:";
			this.vmethod_8().Location = new global::System.Drawing.Point(286, 61);
			this.vmethod_8().Name = "Label4";
			this.vmethod_8().Size = new global::System.Drawing.Size(80, 13);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_8().Text = "有效期止于:";
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_10().Location = new global::System.Drawing.Point(352, 38);
			this.vmethod_10().Name = "Label_ValidFrom";
			this.vmethod_10().Size = new global::System.Drawing.Size(14, 13);
			this.vmethod_10().TabIndex = 5;
			this.vmethod_10().Text = "";
			this.vmethod_12().AutoSize = true;
			this.vmethod_12().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_12().Location = new global::System.Drawing.Point(352, 61);
			this.vmethod_12().Name = "label_ValidUntil";
			this.vmethod_12().Size = new global::System.Drawing.Size(14, 13);
			this.vmethod_12().TabIndex = 6;
			this.vmethod_12().Text = "";
			this.vmethod_14().Location = new global::System.Drawing.Point(3, 0);
			this.vmethod_14().Name = "Label7";
			this.vmethod_14().Size = new global::System.Drawing.Size(38, 13);
			this.vmethod_14().TabIndex = 7;
			this.vmethod_14().Text = "说明:";
			this.vmethod_16().Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_16().Controls.Add(this.vmethod_14());
			this.vmethod_16().Controls.Add(this.vmethod_18());
			this.vmethod_16().Location = new global::System.Drawing.Point(290, 95);
			this.vmethod_16().Name = "FlowLayoutPanel1";
			this.vmethod_16().Size = new global::System.Drawing.Size(338, 165);
			this.vmethod_16().TabIndex = 8;
			this.vmethod_18().AutoSize = true;
			this.vmethod_18().Location = new global::System.Drawing.Point(47, 0);
			this.vmethod_18().Name = "Label_Notes";
			this.vmethod_18().Size = new global::System.Drawing.Size(13, 13);
			this.vmethod_18().TabIndex = 0;
			this.vmethod_18().Text = "";
			this.vmethod_20().Location = new global::System.Drawing.Point(290, 263);
			this.vmethod_20().Name = "Label9";
			this.vmethod_20().Size = new global::System.Drawing.Size(85, 13);
			this.vmethod_20().TabIndex = 9;
			this.vmethod_20().Text = "编组成员:";
			this.vmethod_22().Location = new global::System.Drawing.Point(293, 280);
			this.vmethod_22().Name = "ListView1";
			this.vmethod_22().Size = new global::System.Drawing.Size(335, 238);
			this.vmethod_22().TabIndex = 10;
			this.vmethod_22().UseCompatibleStateImageBehavior = false;
			this.vmethod_22().View = global::System.Windows.Forms.View.List;
			this.vmethod_24().Location = new global::System.Drawing.Point(293, 534);
			this.vmethod_24().Name = "Button1";
			this.vmethod_24().Size = new global::System.Drawing.Size(146, 23);
			this.vmethod_24().TabIndex = 11;
			this.vmethod_24().Text = "加载选定的战场设施";
			this.vmethod_24().UseVisualStyleBackColor = true;
			this.vmethod_26().DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.vmethod_26().Location = new global::System.Drawing.Point(553, 534);
			this.vmethod_26().Name = "Button2";
			this.vmethod_26().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_26().TabIndex = 12;
			this.vmethod_26().Text = "关闭";
			this.vmethod_26().UseVisualStyleBackColor = true;
			this.vmethod_28().Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.vmethod_28().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_28().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_30()
			});
			this.vmethod_28().Location = new global::System.Drawing.Point(0, 562);
			this.vmethod_28().Name = "ToolStrip1";
			this.vmethod_28().Size = new global::System.Drawing.Size(640, 25);
			this.vmethod_28().TabIndex = 13;
			this.vmethod_28().Text = "ToolStrip1";
			this.vmethod_30().Name = "TSL_Loadingtext";
			this.vmethod_30().Size = new global::System.Drawing.Size(95, 22);
			this.vmethod_30().Text = "TSL_LoadingText";
			this.vmethod_32().AutoSize = true;
			this.vmethod_32().Location = new global::System.Drawing.Point(12, 13);
			this.vmethod_32().Name = "CheckBox_DoNotCheckDBCompatibility";
			this.vmethod_32().Size = new global::System.Drawing.Size(184, 17);
			this.vmethod_32().TabIndex = 14;
			this.vmethod_32().Text = "不检查数据库兼容性";
			this.vmethod_32().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.vmethod_26();
			base.ClientSize = new global::System.Drawing.Size(640, 587);
			base.Controls.Add(this.vmethod_32());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "LoadGroup";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "从文件加载作战编组";
			this.vmethod_16().ResumeLayout(false);
			this.vmethod_16().PerformLayout();
			this.vmethod_28().ResumeLayout(false);
			this.vmethod_28().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001D56 RID: 7510
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
