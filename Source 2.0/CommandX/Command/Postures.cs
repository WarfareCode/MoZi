using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace Command
{
	// 敌我立场设置对话框
	[DesignerGenerated]
	public sealed partial class Postures : CommandForm
	{
		// Token: 0x06004FC4 RID: 20420 RVA: 0x00202EE0 File Offset: 0x002010E0
		public Postures()
		{
			base.Load += new EventHandler(this.Postures_Load);
			base.KeyDown += new KeyEventHandler(this.Postures_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.Postures_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06004FC7 RID: 20423 RVA: 0x00203238 File Offset: 0x00201438
		[CompilerGenerated]
		internal  ListBox vmethod_0()
		{
			return this.listBox_0;
		}

		// Token: 0x06004FC8 RID: 20424 RVA: 0x00203250 File Offset: 0x00201450
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ListBox listBox_1)
		{
			EventHandler value = new EventHandler(this.method_1);
			ListBox listBox = this.listBox_0;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value;
			}
			this.listBox_0 = listBox_1;
			listBox = this.listBox_0;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x0020329C File Offset: 0x0020149C
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x00025523 File Offset: 0x00023723
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_2)
		{
			this.label_0 = label_2;
		}

		// Token: 0x06004FCB RID: 20427 RVA: 0x002032B4 File Offset: 0x002014B4
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_1;
		}

		// Token: 0x06004FCC RID: 20428 RVA: 0x0002552C File Offset: 0x0002372C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_2)
		{
			this.label_1 = label_2;
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x002032CC File Offset: 0x002014CC
		[CompilerGenerated]
		internal  ComboBox vmethod_6()
		{
			return this.comboBox_0;
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x002032E4 File Offset: 0x002014E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ComboBox comboBox_1)
		{
			EventHandler value = new EventHandler(this.method_2);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_1;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004FCF RID: 20431 RVA: 0x00203330 File Offset: 0x00201530
		private void Postures_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.Text = "推演方: " + this.side_0.GetSideName() + "的关系属性(本方如何看到其它推演方)";
			foreach (Side current in Client.GetClientScenario().GetSides().OrderBy(Postures.SideFunc))
			{
				if (current != this.side_0)
				{
					this.vmethod_0().Items.Add(current.GetSideName());
				}
			}
			if (this.vmethod_0().Items.Count > 0)
			{
				this.vmethod_0().SelectedIndex = 0;
			}
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x00203408 File Offset: 0x00201608
		private void method_1(object sender, EventArgs e)
		{
			checked
			{
				if (this.vmethod_0().SelectedIndex != -1)
				{
					Side[] sides = Client.GetClientScenario().GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						if (Operators.CompareString(side.GetSideName(), this.vmethod_0().SelectedItem.ToString(), false) == 0)
						{
							this.side_1 = side;
							this.vmethod_6().SelectedIndex = (int)this.side_0.GetPostureStance(this.side_1);
							return;
						}
					}
					this.vmethod_6().SelectedIndex = (int)this.side_0.GetPostureStance(this.side_1);
				}
			}
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x002034AC File Offset: 0x002016AC
		private void method_2(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.side_1))
			{
				Interaction.MsgBox("首先，请选择一个推演方作为应用敌我关系属性的目标方.", MsgBoxStyle.OkOnly, "没有选择目标推演方!");
			}
			else
			{
				this.side_0.SetPostureStance(this.side_1, (Misc.PostureStance)this.vmethod_6().SelectedIndex);
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			}
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		private void Postures_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x00004D83 File Offset: 0x00002F83
		private void Postures_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x040025A5 RID: 9637
		public static Func<Side, string> SideFunc = (Side side_0) => side_0.GetSideName();

		// Token: 0x040025A7 RID: 9639
		[CompilerGenerated]
		private ListBox listBox_0;

		// Token: 0x040025A8 RID: 9640
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x040025A9 RID: 9641
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x040025AA RID: 9642
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x040025AB RID: 9643
		public Side side_0;

		// Token: 0x040025AC RID: 9644
		public Side side_1;
	}
}
