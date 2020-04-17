using System;
using System.Windows.Forms;

namespace ns34
{
	// Token: 0x02000A1D RID: 2589
	
	public sealed partial class StartGame : global::ns33.CommandForm
	{
		// Token: 0x06005093 RID: 20627 RVA: 0x0020C540 File Offset: 0x0020A740
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

		// Token: 0x06005094 RID: 20628 RVA: 0x0020C584 File Offset: 0x0020A784
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns34.StartGame));
			this.groupBox_0=new global::System.Windows.Forms.GroupBox();

            //this.vmethod_19(new global::System.Windows.Forms.Button());
            //EventHandler value_19 = new EventHandler(this.method_7);
            //if (button_6 != null)
            //{
            //    button_6.Click -= value_19;
            //}
            this.button_6 = new global::System.Windows.Forms.Button();
            button_6.Click += new EventHandler(this.method_7);
            //if (button_6 != null)
            //{
            //    button_6.Click += new EventHandler(this.method_7);
            //}



            //this.vmethod_17();
            //EventHandler value_v17 = new EventHandler(this.method_6);
            //if (button_5 != null)
            //{
            //    button_5.Click -= value_v17;
            //}
            this.button_5 = new global::System.Windows.Forms.Button();
            button_5.Click+= new EventHandler(this.method_6);
            //if (button_5 != null)
            //{
            //    button_5.Click += value_v17;
            //}


            //this.vmethod_11(new global::System.Windows.Forms.Button());
            //EventHandler value_v11 = new EventHandler(this.method_3);
            //if (button_3 != null)
            //{
            //    button_3.Click -= value_v11;
            //}
            this.button_3 = new Button();
            button_3.Click += new EventHandler(this.method_3);
            //if (button_3 != null)
            //{
            //    button_3.Click += value_v11;
            //}

            //this.vmethod_3(new global::System.Windows.Forms.Button());
            //EventHandler value_V3 = new EventHandler(this.StartScenarioButton_Click);
            //System.Windows.Forms.Button startScenarioButton = this.StartScenarioButton;
            //if (startScenarioButton != null)
            //{
            //    startScenarioButton.Click -= value_V3;
            //}
            this.StartScenarioButton = new global::System.Windows.Forms.Button();
            this.StartScenarioButton.Click += new EventHandler(this.StartScenarioButton_Click);
            //if (startScenarioButton != null)
            //{
            //    startScenarioButton.Click += value_V3;
            //}


            //this.vmethod_5(new global::System.Windows.Forms.GroupBox());
            this.groupBox_1 = new global::System.Windows.Forms.GroupBox();

			//this.vmethod_7(new global::System.Windows.Forms.Button());
            //EventHandler value_v7 = new EventHandler(this.method_4);
            //Button button_v7 = this.button_1;
            //if (button_v7 != null)
            //{
            //    button_v7.Click -= value_v7;
            //}
            this.button_1 = new Button();
            this.button_1.Click+= new EventHandler(this.method_4);
            //if (button_v7 != null)
            //{
            //    button_v7.Click += value_v7;
            //}

            //this.vmethod_9(new global::System.Windows.Forms.Button());
            //EventHandler value_v9 = new EventHandler(this.method_1);
            //Button button_v9 = this.button_2;
            //if (button_v9 != null)
            //{
            //    button_v9.Click -= value_v9;
            //}
            this.button_2 = new Button();
            button_2.Click += new EventHandler(this.method_1);
            //button_v9 = this.button_2;
            //if (button_v9 != null)
            //{
            //    button_v9.Click += value_v9;
            //}

            //this.vmethod_13(new global::System.Windows.Forms.Button());
            //EventHandler value_v13 = new EventHandler(this.method_5);
            //Button button_v13 = this.button_4;
            //if (button_v13 != null)
            //{
            //    button_v13.Click -= value_v13;
            //}
            this.button_4 = new Button();
            button_4.Click+= new EventHandler(this.method_5);
            //button_v13 = this.button_4;
            //if (button_v13 != null)
            //{
            //    button_v13.Click += value_v13;
            //}

            //this.vmethod_15(new global::System.Windows.Forms.PictureBox());
            this.pictureBox_0 = new global::System.Windows.Forms.PictureBox();

            this.groupBox_0.SuspendLayout();

			this.groupBox_1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_0).BeginInit();
			base.SuspendLayout();

			this.groupBox_0.Controls.Add(this.button_6);
			this.groupBox_0.Controls.Add(this.button_5);
			this.groupBox_0.Controls.Add(this.button_3);
			this.groupBox_0.Controls.Add(this.StartScenarioButton);
			this.groupBox_0.Location = new global::System.Drawing.Point(491, 3);
			this.groupBox_0.Name = "GroupBox1";
			this.groupBox_0.Size = new global::System.Drawing.Size(211, 138);
			this.groupBox_0.TabIndex = 0;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "推演模式";

            //vmethod_18()
            this.button_6.Location = new global::System.Drawing.Point(6, 21);
			this.button_6.Name = "Button_Campaign";
			this.button_6.Size = new global::System.Drawing.Size(200, 23);
			this.button_6.TabIndex = 5;
			this.button_6.Text = "战役推演";
			this.button_6.UseVisualStyleBackColor = true;

            //vmethod_16()
            this.button_5.Location = new global::System.Drawing.Point(6, 107);
			this.button_5.Name = "Button6";
			this.button_5.Size = new global::System.Drawing.Size(199, 25);
			this.button_5.TabIndex = 4;
			this.button_5.Text = "恢复最近保存推演";
			this.button_5.UseVisualStyleBackColor = true;

            //vmethod_10()
            this.button_3.Location = new global::System.Drawing.Point(6, 77);
			this.button_3.Name = "Button4";
			this.button_3.Size = new global::System.Drawing.Size(199, 25);
			this.button_3.TabIndex = 3;
			this.button_3.Text = "加载保存推演";
			this.button_3.UseVisualStyleBackColor = true;

            //GetStartScenarioButton()
            this.StartScenarioButton.Location = new global::System.Drawing.Point(6, 50);
			this.StartScenarioButton.Name = "Button3";
			this.StartScenarioButton.Size = new global::System.Drawing.Size(199, 23);
			this.StartScenarioButton.TabIndex = 2;
			this.StartScenarioButton.Text = "加载新想定";
			this.StartScenarioButton.UseVisualStyleBackColor = true;

			this.groupBox_1.Controls.Add(this.button_1);
			this.groupBox_1.Controls.Add(this.button_2);
			this.groupBox_1.Location = new global::System.Drawing.Point(491, 147);
			this.groupBox_1.Name = "GroupBox2";
			this.groupBox_1.Size = new global::System.Drawing.Size(211, 81);
			this.groupBox_1.TabIndex = 1;
			this.groupBox_1.TabStop = false;
			this.groupBox_1.Text = "编辑模式";

            //vmethod_6
            this.button_1.Location = new global::System.Drawing.Point(5, 50);
			this.button_1.Name = "Button2";
			this.button_1.Size = new global::System.Drawing.Size(200, 25);
			this.button_1.TabIndex = 2;
			this.button_1.Text = "加载已有想定";
			this.button_1.UseVisualStyleBackColor = true;

            //vmethod_8()
            this.button_2.Location = new global::System.Drawing.Point(5, 20);
			this.button_2.Name = "Button1";
			this.button_2.Size = new global::System.Drawing.Size(200, 25);
			this.button_2.TabIndex = 0;
			this.button_2.Text = "创建新想定";
			this.button_2.UseVisualStyleBackColor = true;

            //button_4
            this.button_4.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button_4.AutoSize = true;
			this.button_4.Location = new global::System.Drawing.Point(550, 325);
			this.button_4.Name = "Button5";
			this.button_4.Size = new global::System.Drawing.Size(89, 25);
			this.button_4.TabIndex = 2;
			this.button_4.Text = "退出";
			this.button_4.UseVisualStyleBackColor = true;

			this.pictureBox_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
            //ZSP ERR IMG this.pictureBox_0.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
            this.pictureBox_0.Location = new global::System.Drawing.Point(3, 4);
			this.pictureBox_0.Name = "PictureBox1";
			this.pictureBox_0.Size = new global::System.Drawing.Size(480, 350);
			this.pictureBox_0.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_0.TabIndex = 3;
			this.pictureBox_0.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(704, 360);
			base.Controls.Add(this.groupBox_1);
			base.Controls.Add(this.groupBox_0);
			base.Controls.Add(this.pictureBox_0);
			base.Controls.Add(this.button_4);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "StartGame";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "启动";
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040025DF RID: 9695
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
