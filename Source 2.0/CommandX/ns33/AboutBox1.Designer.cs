using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns34;

namespace ns33
{
	// Token: 0x0200099C RID: 2460
	public sealed partial class AboutBox1 : global::ns33.CommandForm
	{
		// Token: 0x06003EFC RID: 16124 RVA: 0x000207C4 File Offset: 0x0001E9C4
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

        // Token: 0x06003F0D RID: 16141 RVA: 0x0002081F File Offset: 0x0001EA1F
        [CompilerGenerated]
        [MethodImpl(MethodImplOptions.Synchronized)]
        internal  void vmethod_15(Label label_5)
        {
            this.label_4 = label_5;
        }

        // Token: 0x06003EFD RID: 16125 RVA: 0x001525B0 File Offset: 0x001507B0
        private void InitializeComponent()
		{
			new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns33.AboutBox1));
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.vmethod_13(new global::System.Windows.Forms.TextBox());
			this.vmethod_9(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.Label());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_11(new global::System.Windows.Forms.PictureBox());
			this.vmethod_1(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.Button());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_10()).BeginInit();
			base.SuspendLayout();
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_14().Location = new global::System.Drawing.Point(228, 41);
			this.vmethod_14().MaximumSize = new global::System.Drawing.Size(400, 0);
			this.vmethod_14().Name = "Label_License";
			this.vmethod_14().Size = new global::System.Drawing.Size(44, 13);
			this.vmethod_14().TabIndex = 9;
			this.vmethod_14().Text = "许可证";
			this.vmethod_12().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_12().BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.vmethod_12().Location = new global::System.Drawing.Point(13, 170);
			this.vmethod_12().Multiline = true;
			this.vmethod_12().Name = "TextBox1";
			this.vmethod_12().ReadOnly = true;
			this.vmethod_12().ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.vmethod_12().Size = new global::System.Drawing.Size(620, 240);
			this.vmethod_12().TabIndex = 8;
			this.vmethod_8().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_8().Location = new global::System.Drawing.Point(12, 150);
			this.vmethod_8().Name = "Label3";
			this.vmethod_8().Size = new global::System.Drawing.Size(110, 15);
			this.vmethod_8().TabIndex = 5;
			this.vmethod_8().Text = "thanks :";
			this.vmethod_6().Location = new global::System.Drawing.Point(228, 120);
			this.vmethod_6().Name = "Label2";
			this.vmethod_6().Size = new global::System.Drawing.Size(400, 20);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_6().Text = "  ";
			this.vmethod_4().Location = new global::System.Drawing.Point(228, 98);
			this.vmethod_4().Name = "Label1";
			this.vmethod_4().Size = new global::System.Drawing.Size(405, 27);
			this.vmethod_4().TabIndex = 3;
			this.vmethod_4().Text = "  ";
			this.vmethod_10().Image = global::System.Drawing.Image.FromFile(global::System.IO.Path.Combine(global::ns32.CommandFactory.GetCommandApp().Info.DirectoryPath, "Symbols\\splash.jpg"));
			this.vmethod_10().Location = new global::System.Drawing.Point(13, 13);
			this.vmethod_10().Name = "PictureBox1";
			this.vmethod_10().Size = new global::System.Drawing.Size(200, 130);
			this.vmethod_10().SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.vmethod_10().TabIndex = 2;
			this.vmethod_10().TabStop = false;
			this.vmethod_0().AutoEllipsis = true;
			this.vmethod_0().AutoSize = true;
			this.vmethod_0().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_0().Location = new global::System.Drawing.Point(228, 13);
			this.vmethod_0().MaximumSize = new global::System.Drawing.Size(400, 0);
			this.vmethod_0().Name = "Label_version";
			this.vmethod_0().Size = new global::System.Drawing.Size(280, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "CommandX - v1.12";
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_2().DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.vmethod_2().Location = new global::System.Drawing.Point(558, 415);
			this.vmethod_2().Name = "OKButton";
			this.vmethod_2().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "&OK";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(638, 442);
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AboutBox1";
			base.Padding = new global::System.Windows.Forms.Padding(9);
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "关于CommandX";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_10()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001CF8 RID: 7416
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
