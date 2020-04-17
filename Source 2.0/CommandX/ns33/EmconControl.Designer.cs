using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns15;
using ns2;
using ns32;

namespace ns33
{
	// Token: 0x02000978 RID: 2424
	[DesignerGenerated]
	public sealed class EmconControl : UserControl
	{
		// Token: 0x06003BD8 RID: 15320 RVA: 0x00128950 File Offset: 0x00126B50
		public EmconControl()
		{
			base.Load += new EventHandler(this.EmconControl_Load);
			base.VisibleChanged += new EventHandler(this.EmconControl_VisibleChanged);
			this.bool_0 = true;
			this.bool_1 = true;
			this.bool_2 = false;
			this.InitializeComponent();
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x001289A4 File Offset: 0x00126BA4
		[DebuggerNonUserCode]
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

		// Token: 0x06003BDA RID: 15322 RVA: 0x001289E8 File Offset: 0x00126BE8
		private void InitializeComponent()
		{
			this.vmethod_1(new Button());
			this.vmethod_3(new Button());
			this.vmethod_5(new CheckBox());
			this.vmethod_7(new ComboBox());
			this.vmethod_9(new TableLayoutPanel());
			this.vmethod_11(new ComboBox());
			this.vmethod_13(new ComboBox());
			this.vmethod_15(new Label());
			this.vmethod_17(new Label());
			this.vmethod_19(new Label());
			this.vmethod_8().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "Button1";
			this.vmethod_0().Size = new Size(231, 21);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "EMCON Window (Ctrl + F9)";
			this.vmethod_0().UseVisualStyleBackColor = true;
			this.vmethod_2().Location = new Point(0, 21);
			this.vmethod_2().Name = "Button2";
			this.vmethod_2().Size = new Size(231, 21);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "传感啊窗口(F9)";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().AutoSize = true;
			this.vmethod_4().Location = new Point(3, 43);
			this.vmethod_4().Name = "CB_EMCON_Inherits";
			this.vmethod_4().Size = new Size(111, 17);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "与上级保持一致";
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.vmethod_6().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_6().FormattingEnabled = true;
			this.vmethod_6().Location = new Point(111, 0);
			this.vmethod_6().Margin = new Padding(0, 0, 3, 3);
			this.vmethod_6().Name = "CB_EMCON_Radar";
			this.vmethod_6().Size = new Size(118, 21);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_8().ColumnCount = 2;
			this.vmethod_8().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111f));
			this.vmethod_8().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121f));
			this.vmethod_8().Controls.Add(this.vmethod_6(), 1, 0);
			this.vmethod_8().Controls.Add(this.vmethod_10(), 1, 1);
			this.vmethod_8().Controls.Add(this.vmethod_12(), 1, 2);
			this.vmethod_8().Controls.Add(this.vmethod_14(), 0, 0);
			this.vmethod_8().Controls.Add(this.vmethod_16(), 0, 1);
			this.vmethod_8().Controls.Add(this.vmethod_18(), 0, 2);
			this.vmethod_8().Location = new Point(0, 62);
			this.vmethod_8().Margin = new Padding(0);
			this.vmethod_8().Name = "TableLayoutPanel1";
			this.vmethod_8().RowCount = 4;
			this.vmethod_8().RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
			this.vmethod_8().RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
			this.vmethod_8().RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
			this.vmethod_8().RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
			this.vmethod_8().Size = new Size(232, 67);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_10().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_10().FormattingEnabled = true;
			this.vmethod_10().Location = new Point(111, 22);
			this.vmethod_10().Margin = new Padding(0, 0, 3, 3);
			this.vmethod_10().Name = "CB_EMCON_OECM";
			this.vmethod_10().Size = new Size(118, 21);
			this.vmethod_10().TabIndex = 4;
			this.vmethod_12().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_12().FormattingEnabled = true;
			this.vmethod_12().Location = new Point(111, 44);
			this.vmethod_12().Margin = new Padding(0, 0, 3, 3);
			this.vmethod_12().Name = "CB_EMCON_Sonar";
			this.vmethod_12().Size = new Size(118, 21);
			this.vmethod_12().TabIndex = 5;
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Location = new Point(0, 0);
			this.vmethod_14().Margin = new Padding(0, 0, 3, 0);
			this.vmethod_14().Name = "Label1";
			this.vmethod_14().Padding = new Padding(0, 6, 0, 0);
			this.vmethod_14().Size = new Size(39, 19);
			this.vmethod_14().TabIndex = 6;
			this.vmethod_14().Text = "雷达:";
			this.vmethod_16().AutoSize = true;
			this.vmethod_16().Location = new Point(0, 22);
			this.vmethod_16().Margin = new Padding(0, 0, 3, 0);
			this.vmethod_16().Name = "Label2";
			this.vmethod_16().Padding = new Padding(0, 6, 0, 0);
			this.vmethod_16().Size = new Size(41, 19);
			this.vmethod_16().TabIndex = 7;
			this.vmethod_16().Text = "电子干扰:";
			this.vmethod_18().AutoSize = true;
			this.vmethod_18().Location = new Point(0, 44);
			this.vmethod_18().Margin = new Padding(0, 0, 3, 0);
			this.vmethod_18().Name = "Label3";
			this.vmethod_18().Padding = new Padding(0, 6, 0, 0);
			this.vmethod_18().Size = new Size(38, 19);
			this.vmethod_18().TabIndex = 8;
			this.vmethod_18().Text = "声纳:";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.Margin = new Padding(0);
			base.Name = "EmconControl";
			base.Size = new Size(232, 142);
			this.vmethod_8().ResumeLayout(false);
			this.vmethod_8().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x001290DC File Offset: 0x001272DC
		[CompilerGenerated]
		internal  Button vmethod_0()
		{
			return this.button_0;
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x001290F4 File Offset: 0x001272F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_4);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_2;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x00129140 File Offset: 0x00127340
		[CompilerGenerated]
		internal  Button vmethod_2()
		{
			return this.button_1;
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x00129158 File Offset: 0x00127358
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_5);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_2;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x001291A4 File Offset: 0x001273A4
		[CompilerGenerated]
		internal  CheckBox vmethod_4()
		{
			return this.checkBox_0;
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x001291BC File Offset: 0x001273BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(CheckBox checkBox_1)
		{
			EventHandler value = new EventHandler(this.method_9);
			MouseEventHandler value2 = new MouseEventHandler(this.method_10);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
				checkBox.MouseUp -= value2;
			}
			this.checkBox_0 = checkBox_1;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
				checkBox.MouseUp += value2;
			}
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x00129220 File Offset: 0x00127420
		[CompilerGenerated]
		internal  ComboBox vmethod_6()
		{
			return this.comboBox_0;
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x00129238 File Offset: 0x00127438
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ComboBox comboBox_3)
		{
			EventHandler value = new EventHandler(this.method_6);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_3;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x00129284 File Offset: 0x00127484
		[CompilerGenerated]
		internal  TableLayoutPanel vmethod_8()
		{
			return this.tableLayoutPanel_0;
		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x0001F993 File Offset: 0x0001DB93
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TableLayoutPanel tableLayoutPanel_1)
		{
			this.tableLayoutPanel_0 = tableLayoutPanel_1;
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x0012929C File Offset: 0x0012749C
		[CompilerGenerated]
		internal  ComboBox vmethod_10()
		{
			return this.comboBox_1;
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x001292B4 File Offset: 0x001274B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ComboBox comboBox_3)
		{
			EventHandler value = new EventHandler(this.method_7);
			ComboBox comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_1 = comboBox_3;
			comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x00129300 File Offset: 0x00127500
		[CompilerGenerated]
		internal  ComboBox vmethod_12()
		{
			return this.comboBox_2;
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x00129318 File Offset: 0x00127518
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(ComboBox comboBox_3)
		{
			EventHandler value = new EventHandler(this.method_8);
			ComboBox comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_2 = comboBox_3;
			comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x00129364 File Offset: 0x00127564
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_0;
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x0001F99C File Offset: 0x0001DB9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_3)
		{
			this.label_0 = label_3;
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x0012937C File Offset: 0x0012757C
		[CompilerGenerated]
		internal  Label vmethod_16()
		{
			return this.label_1;
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x0001F9A5 File Offset: 0x0001DBA5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Label label_3)
		{
			this.label_1 = label_3;
		}

		// Token: 0x06003BED RID: 15341 RVA: 0x00129394 File Offset: 0x00127594
		[CompilerGenerated]
		internal  Label vmethod_18()
		{
			return this.label_2;
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x0001F9AE File Offset: 0x0001DBAE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_3)
		{
			this.label_2 = label_3;
		}

		// Token: 0x06003BEF RID: 15343 RVA: 0x001293AC File Offset: 0x001275AC
		[CompilerGenerated]
		public static void smethod_0(EmconControl.Delegate58 delegate58_1)
		{
			EmconControl.Delegate58 @delegate = EmconControl.delegate58_0;
			EmconControl.Delegate58 delegate2;
			do
			{
				delegate2 = @delegate;
				EmconControl.Delegate58 value = (EmconControl.Delegate58)Delegate.Combine(delegate2, delegate58_1);
				@delegate = Interlocked.CompareExchange<EmconControl.Delegate58>(ref EmconControl.delegate58_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06003BF0 RID: 15344 RVA: 0x0001F9B7 File Offset: 0x0001DBB7
		private void EmconControl_Load(object sender, EventArgs e)
		{
			Doctrine.smethod_2(new Doctrine.Delegate10(this.method_0));
			Client.smethod_15(new Client.Delegate50(this.method_1));
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x001293E4 File Offset: 0x001275E4
		private void method_0(Subject class137_1, bool? nullable_0, bool bool_3, bool bool_4, bool bool_5, bool bool_6)
		{
			checked
			{
				if (!bool_5 && !bool_6 && !Information.IsNothing(class137_1) && class137_1.IsActiveUnit() && (!bool_3 || class137_1 == Client.GetHookedUnit()) && this.bool_1 && !Information.IsNothing(nullable_0) && base.Parent.GetType() == typeof(Class670) && ((Class670)base.Parent).method_2() == Enum144.const_0)
				{
					Form[] ownedForms = CommandFactory.GetCommandMain().GetMainForm().OwnedForms;
					for (int i = 0; i < ownedForms.Length; i++)
					{
						if (ownedForms[i].GetType() == typeof(DoctrineForm))
						{
							CommandFactory.GetCommandMain().GetMainForm().method_3().method_3(Client.GetHookedUnit(), Client.GetHookedUnit());
							break;
						}
					}
				}
			}
		}

		// Token: 0x06003BF2 RID: 15346 RVA: 0x0001F9F3 File Offset: 0x0001DBF3
		private void method_1(Unit unit_0)
		{
			this.class137_0 = unit_0;
			this.bool_0 = true;
		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x001294BC File Offset: 0x001276BC
		private Doctrine method_2()
		{
			Doctrine doctrine;
			Doctrine result;
			if (Information.IsNothing(this.class137_0))
			{
				this.class137_0 = Client.GetHookedUnit();
				if (Information.IsNothing(this.class137_0))
				{
					this.bool_2 = false;
					doctrine = null;
					result = doctrine;
					return result;
				}
			}
			if (this.class137_0.GetType() == typeof(Side))
			{
				this.bool_2 = false;
				doctrine = ((Side)this.class137_0).m_Doctrine;
			}
			else if (this.class137_0.IsMission)
			{
				this.bool_2 = false;
				doctrine = ((Mission)this.class137_0).m_Doctrine;
			}
			else if (this.class137_0.IsGroup)
			{
				Group group = (Group)Client.GetHookedUnit();
				if (!Information.IsNothing(group.GetGroupLead()))
				{
					this.bool_2 = group.GetGroupLead().GetAI().IsEscort;
				}
				else
				{
					this.bool_2 = false;
				}
				doctrine = ((Group)this.class137_0).m_Doctrine;
			}
			else if (this.class137_0.IsActiveUnit())
			{
				this.bool_2 = ((ActiveUnit)Client.GetHookedUnit()).GetAI().IsEscort;
				doctrine = ((ActiveUnit)this.class137_0).m_Doctrine;
			}
			else
			{
				this.bool_2 = false;
				doctrine = null;
			}
			result = doctrine;
			return result;
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x00129610 File Offset: 0x00127810
		public void method_3(bool bool_3)
		{
			if (!Information.IsNothing(Client.GetHookedUnit()) && !Information.IsNothing(this.method_2()))
			{
				if (Client.float_0 != 1f)
				{
					if (this.int_0 == 0)
					{
						this.int_0 = base.Width;
					}
					if (this.int_0 == base.Width)
					{
						base.Width = (int)Math.Round((double)((float)base.Width * Client.float_0));
					}
				}
				base.Enabled = (Client.GetHookedUnit().GetSide(false) == Client.GetClientSide());
				this.vmethod_0().Visible = !Information.IsNothing(this.class137_0);
				this.vmethod_2().Visible = !Information.IsNothing(this.class137_0);
				if (bool_3)
				{
					Doctrine doctrine = this.method_2();
					CheckBox checkBox_ = this.vmethod_4();
					Doctrine doctrine2 = this.method_2();
					doctrine.method_312(ref checkBox_, ref this.class137_0, ref doctrine2);
					this.vmethod_5(checkBox_);
					Doctrine doctrine3 = this.method_2();
					ComboBox comboBox_ = this.vmethod_6();
					Scenario clientScenario = Client.GetClientScenario();
					doctrine2 = this.method_2();
					doctrine3.method_309(ref comboBox_, ref clientScenario, ref doctrine2);
					this.vmethod_7(comboBox_);
					Doctrine doctrine4 = this.method_2();
					comboBox_ = this.vmethod_10();
					clientScenario = Client.GetClientScenario();
					doctrine2 = this.method_2();
					doctrine4.method_310(ref comboBox_, ref clientScenario, ref doctrine2);
					this.vmethod_11(comboBox_);
					Doctrine doctrine5 = this.method_2();
					comboBox_ = this.vmethod_12();
					clientScenario = Client.GetClientScenario();
					doctrine2 = this.method_2();
					doctrine5.method_311(ref comboBox_, ref clientScenario, ref doctrine2);
					this.vmethod_13(comboBox_);
				}
				this.bool_0 = false;
			}
		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x0001FA03 File Offset: 0x0001DC03
		private void EmconControl_VisibleChanged(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				this.method_3(false);
			}
			Class2498.smethod_0();
		}

		// Token: 0x06003BF6 RID: 15350 RVA: 0x001297B0 File Offset: 0x001279B0
		private void method_4(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.class137_0))
			{
				DoctrineForm doctrineForm = new DoctrineForm();
				doctrineForm.subject = this.class137_0;
				doctrineForm.bool_5 = this.bool_2;
				doctrineForm.Show();
				doctrineForm.vmethod_0().SelectedIndex = 1;
			}
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x001297FC File Offset: 0x001279FC
		private void method_5(object sender, EventArgs e)
		{
			EmconControl.Delegate58 @delegate = EmconControl.delegate58_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x0012981C File Offset: 0x00127A1C
		private void method_6(object sender, EventArgs e)
		{
			Doctrine doctrine = this.method_2();
			ComboBox comboBox_ = this.vmethod_6();
			Scenario clientScenario = Client.GetClientScenario();
			Doctrine doctrine2 = this.method_2();
			bool flag = true;
			doctrine.method_314(ref comboBox_, ref clientScenario, ref doctrine2, false, ref flag, ref this.bool_2, false, true);
			this.vmethod_7(comboBox_);
			CommandFactory.GetCommandMain().GetMainForm().GetMapBox().Focus();
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x0012988C File Offset: 0x00127A8C
		private void method_7(object sender, EventArgs e)
		{
			Doctrine doctrine = this.method_2();
			ComboBox comboBox_ = this.vmethod_10();
			Scenario clientScenario = Client.GetClientScenario();
			Doctrine doctrine2 = this.method_2();
			bool flag = true;
			doctrine.method_315(ref comboBox_, ref clientScenario, ref doctrine2, false, ref flag, ref this.bool_2, false, true);
			this.vmethod_11(comboBox_);
			CommandFactory.GetCommandMain().GetMainForm().GetMapBox().Focus();
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x001298FC File Offset: 0x00127AFC
		private void method_8(object sender, EventArgs e)
		{
			Doctrine doctrine = this.method_2();
			ComboBox comboBox_ = this.vmethod_12();
			Scenario clientScenario = Client.GetClientScenario();
			Doctrine doctrine2 = this.method_2();
			bool flag = true;
			doctrine.method_316(ref comboBox_, ref clientScenario, ref doctrine2, false, ref flag, ref this.bool_2, false, true);
			this.vmethod_13(comboBox_);
			CommandFactory.GetCommandMain().GetMainForm().GetMapBox().Focus();
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x0012996C File Offset: 0x00127B6C
		private void method_9(object sender, EventArgs e)
		{
			Doctrine doctrine = this.method_2();
			CheckBox checkBox_ = this.vmethod_4();
			ComboBox comboBox_ = this.vmethod_6();
			ComboBox comboBox_2 = this.vmethod_10();
			ComboBox comboBox_3 = this.vmethod_12();
			Doctrine doctrine2 = this.method_2();
			doctrine.method_313(ref checkBox_, ref comboBox_, ref comboBox_2, ref comboBox_3, ref doctrine2, Client.GetClientScenario(), false, true);
			this.vmethod_13(comboBox_3);
			this.vmethod_11(comboBox_2);
			this.vmethod_7(comboBox_);
			this.vmethod_5(checkBox_);
			Doctrine doctrine3 = this.method_2();
			comboBox_3 = this.vmethod_6();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine2 = this.method_2();
			doctrine3.method_309(ref comboBox_3, ref clientScenario, ref doctrine2);
			this.vmethod_7(comboBox_3);
			Doctrine doctrine4 = this.method_2();
			comboBox_3 = this.vmethod_10();
			clientScenario = Client.GetClientScenario();
			doctrine2 = this.method_2();
			doctrine4.method_310(ref comboBox_3, ref clientScenario, ref doctrine2);
			this.vmethod_11(comboBox_3);
			Doctrine doctrine5 = this.method_2();
			comboBox_3 = this.vmethod_12();
			clientScenario = Client.GetClientScenario();
			doctrine2 = this.method_2();
			doctrine5.method_311(ref comboBox_3, ref clientScenario, ref doctrine2);
			this.vmethod_13(comboBox_3);
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x00129A78 File Offset: 0x00127C78
		private void method_10(object sender, MouseEventArgs e)
		{
			Doctrine doctrine = this.method_2();
			Side clientSide = Client.GetClientSide();
			Scenario clientScenario = Client.GetClientScenario();
			doctrine.method_318(ref clientSide, ref clientScenario, ref this.bool_2);
			Client.SetClientSide(clientSide);
			this.bool_1 = false;
			this.method_2().method_2(this.class137_0, new bool?(false), false, false, true, false);
			this.bool_1 = true;
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

		// Token: 0x04001B51 RID: 6993
		private IContainer icontainer_0;

		// Token: 0x04001B52 RID: 6994
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001B53 RID: 6995
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001B54 RID: 6996
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04001B55 RID: 6997
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04001B56 RID: 6998
		[CompilerGenerated]
		private TableLayoutPanel tableLayoutPanel_0;

		// Token: 0x04001B57 RID: 6999
		[CompilerGenerated]
		private ComboBox comboBox_1;

		// Token: 0x04001B58 RID: 7000
		[CompilerGenerated]
		private ComboBox comboBox_2;

		// Token: 0x04001B59 RID: 7001
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001B5A RID: 7002
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04001B5B RID: 7003
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04001B5C RID: 7004
		private Subject class137_0;

		// Token: 0x04001B5D RID: 7005
		private bool bool_0;

		// Token: 0x04001B5E RID: 7006
		private bool bool_1;

		// Token: 0x04001B5F RID: 7007
		private bool bool_2;

		// Token: 0x04001B60 RID: 7008
		private int int_0;

		// Token: 0x04001B61 RID: 7009
		[CompilerGenerated]
		private static EmconControl.Delegate58 delegate58_0;

		// Token: 0x02000979 RID: 2425
		// (Invoke) Token: 0x06003BFE RID: 15358
		public delegate void Delegate58();
	}
}
