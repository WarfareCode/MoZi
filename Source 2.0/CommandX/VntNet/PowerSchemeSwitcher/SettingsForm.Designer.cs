namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x02000CE4 RID: 3300
	public sealed partial class SettingsForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06006C36 RID: 27702 RVA: 0x0002E581 File Offset: 0x0002C781
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06006C37 RID: 27703 RVA: 0x003CD5C8 File Offset: 0x003CB7C8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::VntNet.PowerSchemeSwitcher.SettingsForm));
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnOK = new global::System.Windows.Forms.Button();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.enableAutoCheckBox = new global::System.Windows.Forms.CheckBox();
			this.lowBatteryPercComboBox = new global::System.Windows.Forms.ComboBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.lowBatteryComboBox = new global::System.Windows.Forms.ComboBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.batteryComboBox = new global::System.Windows.Forms.ComboBox();
			this.acComboBox = new global::System.Windows.Forms.ComboBox();
			this.lblBattery = new global::System.Windows.Forms.Label();
			this.lblAC = new global::System.Windows.Forms.Label();
			this.picBattery = new global::System.Windows.Forms.PictureBox();
			this.picAC = new global::System.Windows.Forms.PictureBox();
			this.settingsTabControl = new global::System.Windows.Forms.TabControl();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.tabPage1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.picBattery).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.picAC).BeginInit();
			this.settingsTabControl.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnCancel.Location = new global::System.Drawing.Point(283, 337);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnOK.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.btnOK.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.btnOK.Location = new global::System.Drawing.Point(201, 337);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 12;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new global::System.EventHandler(this.btnOK_Click);
			this.tabPage1.Controls.Add(this.enableAutoCheckBox);
			this.tabPage1.Controls.Add(this.lowBatteryPercComboBox);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.lowBatteryComboBox);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.batteryComboBox);
			this.tabPage1.Controls.Add(this.acComboBox);
			this.tabPage1.Controls.Add(this.lblBattery);
			this.tabPage1.Controls.Add(this.lblAC);
			this.tabPage1.Controls.Add(this.picBattery);
			this.tabPage1.Controls.Add(this.picAC);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(362, 293);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Powe Line";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.enableAutoCheckBox.AutoSize = true;
			this.enableAutoCheckBox.Checked = global::VntNet.PowerSchemeSwitcher.Properties.Settings.Default.EnableAutoSwitching;
			this.enableAutoCheckBox.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", global::VntNet.PowerSchemeSwitcher.Properties.Settings.Default, "EnableAutoSwitching", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.enableAutoCheckBox.Location = new global::System.Drawing.Point(12, 20);
			this.enableAutoCheckBox.Name = "enableAutoCheckBox";
			this.enableAutoCheckBox.Size = new global::System.Drawing.Size(158, 17);
			this.enableAutoCheckBox.TabIndex = 30;
			this.enableAutoCheckBox.Text = "Enable Automatic Switching";
			this.enableAutoCheckBox.UseVisualStyleBackColor = true;
			this.lowBatteryPercComboBox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lowBatteryPercComboBox.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::VntNet.PowerSchemeSwitcher.Properties.Settings.Default, "LowBatteryPercentage", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lowBatteryPercComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lowBatteryPercComboBox.FormattingEnabled = true;
			this.lowBatteryPercComboBox.Items.AddRange(new object[]
			{
				"10",
				"20",
				"30",
				"40",
				"50"
			});
			this.lowBatteryPercComboBox.Location = new global::System.Drawing.Point(199, 150);
			this.lowBatteryPercComboBox.Name = "lowBatteryPercComboBox";
			this.lowBatteryPercComboBox.Size = new global::System.Drawing.Size(81, 21);
			this.lowBatteryPercComboBox.Sorted = true;
			this.lowBatteryPercComboBox.TabIndex = 29;
			this.label3.AutoSize = true;
			this.label3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new global::System.Drawing.Point(50, 153);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(143, 13);
			this.label3.TabIndex = 28;
			this.label3.Text = "When battery %  is less then:";
			this.lowBatteryComboBox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lowBatteryComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lowBatteryComboBox.FormattingEnabled = true;
			this.lowBatteryComboBox.Location = new global::System.Drawing.Point(51, 177);
			this.lowBatteryComboBox.Name = "lowBatteryComboBox";
			this.lowBatteryComboBox.Size = new global::System.Drawing.Size(305, 21);
			this.lowBatteryComboBox.Sorted = true;
			this.lowBatteryComboBox.TabIndex = 27;
			this.lowBatteryComboBox.SelectedIndexChanged += new global::System.EventHandler(this.lowBatteryComboBox_SelectedIndexChanged);
			this.pictureBox1.Image = global::VntNet.PowerSchemeSwitcher.Properties.Resources.BatteryImg;
			this.pictureBox1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox1.Location = new global::System.Drawing.Point(12, 153);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 25;
			this.pictureBox1.TabStop = false;
			this.batteryComboBox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.batteryComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.batteryComboBox.FormattingEnabled = true;
			this.batteryComboBox.Location = new global::System.Drawing.Point(50, 118);
			this.batteryComboBox.Name = "batteryComboBox";
			this.batteryComboBox.Size = new global::System.Drawing.Size(305, 21);
			this.batteryComboBox.Sorted = true;
			this.batteryComboBox.TabIndex = 23;
			this.batteryComboBox.SelectedIndexChanged += new global::System.EventHandler(this.batteryComboBox_SelectedIndexChanged);
			this.acComboBox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.acComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.acComboBox.FormattingEnabled = true;
			this.acComboBox.Location = new global::System.Drawing.Point(50, 70);
			this.acComboBox.Name = "acComboBox";
			this.acComboBox.Size = new global::System.Drawing.Size(304, 21);
			this.acComboBox.Sorted = true;
			this.acComboBox.TabIndex = 24;
			this.acComboBox.SelectedIndexChanged += new global::System.EventHandler(this.acComboBox_SelectedIndexChanged);
			this.lblBattery.AutoSize = true;
			this.lblBattery.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.lblBattery.Location = new global::System.Drawing.Point(51, 102);
			this.lblBattery.Name = "lblBattery";
			this.lblBattery.Size = new global::System.Drawing.Size(59, 13);
			this.lblBattery.TabIndex = 21;
			this.lblBattery.Text = "On battery:";
			this.lblAC.AutoSize = true;
			this.lblAC.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.lblAC.Location = new global::System.Drawing.Point(50, 53);
			this.lblAC.Name = "lblAC";
			this.lblAC.Size = new global::System.Drawing.Size(60, 13);
			this.lblAC.TabIndex = 22;
			this.lblAC.Text = "Plugged in:";
			this.picBattery.Image = global::VntNet.PowerSchemeSwitcher.Properties.Resources.BatteryImg;
			this.picBattery.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.picBattery.Location = new global::System.Drawing.Point(12, 102);
			this.picBattery.Name = "picBattery";
			this.picBattery.Size = new global::System.Drawing.Size(32, 32);
			this.picBattery.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picBattery.TabIndex = 18;
			this.picBattery.TabStop = false;
			this.picAC.Image = global::VntNet.PowerSchemeSwitcher.Properties.Resources.PlugImg;
			this.picAC.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.picAC.Location = new global::System.Drawing.Point(11, 53);
			this.picAC.Name = "picAC";
			this.picAC.Size = new global::System.Drawing.Size(32, 32);
			this.picAC.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picAC.TabIndex = 19;
			this.picAC.TabStop = false;
			this.settingsTabControl.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.settingsTabControl.Controls.Add(this.tabPage1);
			this.settingsTabControl.Location = new global::System.Drawing.Point(0, 12);
			this.settingsTabControl.Name = "settingsTabControl";
			this.settingsTabControl.SelectedIndex = 0;
			this.settingsTabControl.Size = new global::System.Drawing.Size(370, 319);
			this.settingsTabControl.TabIndex = 4;
			this.pictureBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox2.Image = global::VntNet.PowerSchemeSwitcher.Properties.Resources.Info;
			this.pictureBox2.Location = new global::System.Drawing.Point(346, 1);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(21, 21);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 31;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
			base.AcceptButton = this.btnOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(370, 372);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.settingsTabControl);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(386, 410);
			base.Name = "SettingsForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Power Configuration Switcher";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.picBattery).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.picAC).EndInit();
			this.settingsTabControl.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04003E4B RID: 15947
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04003E4C RID: 15948
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04003E4D RID: 15949
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x04003E4E RID: 15950
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04003E4F RID: 15951
		private global::System.Windows.Forms.ComboBox lowBatteryPercComboBox;

		// Token: 0x04003E50 RID: 15952
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04003E51 RID: 15953
		private global::System.Windows.Forms.ComboBox lowBatteryComboBox;

		// Token: 0x04003E52 RID: 15954
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04003E53 RID: 15955
		private global::System.Windows.Forms.ComboBox batteryComboBox;

		// Token: 0x04003E54 RID: 15956
		private global::System.Windows.Forms.ComboBox acComboBox;

		// Token: 0x04003E55 RID: 15957
		private global::System.Windows.Forms.Label lblBattery;

		// Token: 0x04003E56 RID: 15958
		private global::System.Windows.Forms.Label lblAC;

		// Token: 0x04003E57 RID: 15959
		private global::System.Windows.Forms.PictureBox picBattery;

		// Token: 0x04003E58 RID: 15960
		private global::System.Windows.Forms.PictureBox picAC;

		// Token: 0x04003E59 RID: 15961
		private global::System.Windows.Forms.TabControl settingsTabControl;

		// Token: 0x04003E5A RID: 15962
		private global::System.Windows.Forms.CheckBox enableAutoCheckBox;

		// Token: 0x04003E5B RID: 15963
		private global::System.Windows.Forms.PictureBox pictureBox2;
	}
}
