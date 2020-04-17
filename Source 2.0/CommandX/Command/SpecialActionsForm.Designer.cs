namespace Command
{
	// Token: 0x02000990 RID: 2448
	public sealed partial class SpecialActionsForm : global::ns33.CommandForm
	{
		// Token: 0x06003DCB RID: 15819 RVA: 0x001429A0 File Offset: 0x00140BA0
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

		// Token: 0x06003DCC RID: 15820 RVA: 0x001429E4 File Offset: 0x00140BE4
		private void InitializeComponent()
		{
			this.vmethod_3(new global::System.Windows.Forms.Label());
			this.vmethod_1(new global::System.Windows.Forms.DataGridView());
			this.vmethod_5(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_7(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_9(new global::System.Windows.Forms.DataGridViewButtonColumn());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().Location = new global::System.Drawing.Point(0, 367);
			this.vmethod_2().Margin = new global::System.Windows.Forms.Padding(3);
			this.vmethod_2().MaximumSize = new global::System.Drawing.Size(770, 0);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new global::System.Drawing.Size(39, 13);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "Label1";
			this.vmethod_2().TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.vmethod_2().Visible = false;
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_0().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.vmethod_4(),
				this.vmethod_6(),
				this.vmethod_8()
			});
			this.vmethod_0().Location = new global::System.Drawing.Point(1, 1);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DataGridView1";
			this.vmethod_0().Size = new global::System.Drawing.Size(766, 362);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_4().DataPropertyName = "ID";
			this.vmethod_4().HeaderText = "ID";
			this.vmethod_4().Name = "ID";
			this.vmethod_4().ReadOnly = true;
			this.vmethod_4().Visible = false;
			this.vmethod_6().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_6().DataPropertyName = "Name";
			this.vmethod_6().HeaderText = "名称";
			this.vmethod_6().Name = "ActionName";
			this.vmethod_6().ReadOnly = true;
			this.vmethod_8().HeaderText = "";
			this.vmethod_8().Name = "ExecuteAction";
			this.vmethod_8().ReadOnly = true;
			this.vmethod_8().Text = "执行";
			this.vmethod_8().UseColumnTextForButtonValue = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(768, 507);
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SpecialActionsForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "特殊事件控制台";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001C58 RID: 7256
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
