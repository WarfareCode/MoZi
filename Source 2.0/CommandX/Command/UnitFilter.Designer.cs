using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace Command
{
	// 单元过滤
	[DesignerGenerated]
	public sealed class UnitFilter : System.Windows.Forms.UserControl
	{
		// Token: 0x06004CA7 RID: 19623 RVA: 0x00024803 File Offset: 0x00022A03
		public UnitFilter()
		{
			base.Load += new EventHandler(this.UnitFilter_Load);
			this.InitializeComponent();
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x001E68AC File Offset: 0x001E4AAC
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

		// Token: 0x06004CA9 RID: 19625 RVA: 0x001E68F0 File Offset: 0x001E4AF0
		private void InitializeComponent()
		{
			this.vmethod_1(new System.Windows.Forms.Label());
			this.vmethod_3(new System.Windows.Forms.ComboBox());
			this.vmethod_5(new System.Windows.Forms.Label());
			this.vmethod_7(new System.Windows.Forms.Label());
			this.vmethod_9(new System.Windows.Forms.Label());
			this.vmethod_11(new System.Windows.Forms.Label());
			this.vmethod_13(new System.Windows.Forms.ComboBox());
			this.vmethod_15(new System.Windows.Forms.ComboBox());
			this.vmethod_17(new System.Windows.Forms.ComboBox());
			this.vmethod_19(new System.Windows.Forms.ComboBox());
			base.SuspendLayout();
			this.vmethod_0().Location = new Point(13, 13);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new Size(63, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Target side:";
			this.vmethod_2().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_2().FormattingEnabled = true;
			this.vmethod_2().Location = new Point(102, 10);
			this.vmethod_2().Name = "CB_TargetSide";
			this.vmethod_2().Size = new Size(196, 21);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().Location = new Point(13, 46);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new Size(64, 13);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "Target type:";
			this.vmethod_6().Location = new Point(13, 79);
			this.vmethod_6().Name = "Label3";
			this.vmethod_6().Size = new Size(81, 13);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "Target subtype:";
			this.vmethod_8().Location = new Point(13, 111);
			this.vmethod_8().Name = "Label4";
			this.vmethod_8().Size = new Size(68, 13);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_8().Text = "Target class:";
			this.vmethod_10().Location = new Point(13, 146);
			this.vmethod_10().Name = "Label5";
			this.vmethod_10().Size = new Size(68, 13);
			this.vmethod_10().TabIndex = 5;
			this.vmethod_10().Text = "Specific unit:";
			this.vmethod_12().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_12().FormattingEnabled = true;
			this.vmethod_12().Items.AddRange(new object[]
			{
				"None",
				"Aircraft",
				"Surface Ship",
				"Submarine",
				"Land facility",
				"Aimpoint / mobile unit [INOPERATIVE]",
				"Weapon"
			});
			this.vmethod_12().Location = new Point(102, 43);
			this.vmethod_12().Name = "CB_TargetType";
			this.vmethod_12().Size = new Size(196, 21);
			this.vmethod_12().TabIndex = 6;
			this.vmethod_14().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_14().FormattingEnabled = true;
			this.vmethod_14().Location = new Point(102, 76);
			this.vmethod_14().Name = "CB_TargetSubtype";
			this.vmethod_14().Size = new Size(196, 21);
			this.vmethod_14().TabIndex = 7;
			this.vmethod_16().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_16().FormattingEnabled = true;
			this.vmethod_16().Location = new Point(102, 108);
			this.vmethod_16().Name = "CB_TargetUnitClass";
			this.vmethod_16().Size = new Size(196, 21);
			this.vmethod_16().TabIndex = 8;
			this.vmethod_18().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_18().FormattingEnabled = true;
			this.vmethod_18().Location = new Point(102, 143);
			this.vmethod_18().Name = "CB_SpecificUnit";
			this.vmethod_18().Size = new Size(196, 21);
			this.vmethod_18().TabIndex = 9;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.Name = "UnitFilter";
			base.Size = new Size(311, 177);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x001E6E3C File Offset: 0x001E503C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x00024823 File Offset: 0x00022A23
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(System.Windows.Forms.Label label_5)
		{
			this.label_0 = label_5;
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x001E6E54 File Offset: 0x001E5054
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_2()
		{
			return this.comboBox_0;
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x001E6E6C File Offset: 0x001E506C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(System.Windows.Forms.ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.method_8);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_5;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x001E6EB8 File Offset: 0x001E50B8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_4()
		{
			return this.label_1;
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x0002482C File Offset: 0x00022A2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(System.Windows.Forms.Label label_5)
		{
			this.label_1 = label_5;
		}

		// Token: 0x06004CB0 RID: 19632 RVA: 0x001E6ED0 File Offset: 0x001E50D0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_6()
		{
			return this.label_2;
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x00024835 File Offset: 0x00022A35
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(System.Windows.Forms.Label label_5)
		{
			this.label_2 = label_5;
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x001E6EE8 File Offset: 0x001E50E8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_8()
		{
			return this.label_3;
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x0002483E File Offset: 0x00022A3E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(System.Windows.Forms.Label label_5)
		{
			this.label_3 = label_5;
		}

		// Token: 0x06004CB4 RID: 19636 RVA: 0x001E6F00 File Offset: 0x001E5100
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_10()
		{
			return this.label_4;
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x00024847 File Offset: 0x00022A47
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(System.Windows.Forms.Label label_5)
		{
			this.label_4 = label_5;
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x001E6F18 File Offset: 0x001E5118
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_12()
		{
			return this.comboBox_1;
		}

		// Token: 0x06004CB7 RID: 19639 RVA: 0x001E6F30 File Offset: 0x001E5130
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(System.Windows.Forms.ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.method_5);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_1 = comboBox_5;
			comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x001E6F7C File Offset: 0x001E517C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_14()
		{
			return this.comboBox_2;
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x001E6F94 File Offset: 0x001E5194
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(System.Windows.Forms.ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.method_6);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_2 = comboBox_5;
			comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x001E6FE0 File Offset: 0x001E51E0
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_16()
		{
			return this.comboBox_3;
		}

		// Token: 0x06004CBB RID: 19643 RVA: 0x001E6FF8 File Offset: 0x001E51F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(System.Windows.Forms.ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.method_7);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_3;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_3 = comboBox_5;
			comboBox = this.comboBox_3;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004CBC RID: 19644 RVA: 0x001E7044 File Offset: 0x001E5244
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_18()
		{
			return this.comboBox_4;
		}

		// Token: 0x06004CBD RID: 19645 RVA: 0x001E705C File Offset: 0x001E525C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(System.Windows.Forms.ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.method_9);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_4;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_4 = comboBox_5;
			comboBox = this.comboBox_4;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004CBE RID: 19646 RVA: 0x001E70A8 File Offset: 0x001E52A8
		public void method_0(Target class173_1)
		{
			bool flag = class173_1 != this.class173_0;
			this.class173_0 = class173_1;
			if (flag)
			{
				this.method_1();
			}
		}

		// Token: 0x06004CBF RID: 19647 RVA: 0x001E70D8 File Offset: 0x001E52D8
		private void method_1()
		{
			checked
			{
				if (!Information.IsNothing(Client.GetClientScenario()) && !Information.IsNothing(this.class173_0))
				{
					this.vmethod_2().Items.Clear();
					this.vmethod_2().DisplayMember = "Content";
					Side[] sides = Client.GetClientScenario().GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						ComboBoxItem comboBoxItem = new ComboBoxItem();
						comboBoxItem.Content = side.GetSideName();
						comboBoxItem.Tag = side.GetGuid();
						this.vmethod_2().Items.Add(comboBoxItem);
					}
					if (string.IsNullOrEmpty(this.class173_0.TargetSide))
					{
						this.vmethod_2().SelectedIndex = -1;
					}
					else
					{
						IEnumerator enumerator = this.vmethod_2().Items.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								ComboBoxItem comboBoxItem2 = (ComboBoxItem)enumerator.Current;
								if (Operators.CompareString(Conversions.ToString(comboBoxItem2.Tag), this.class173_0.TargetSide, false) == 0)
								{
									this.vmethod_2().SelectedItem = comboBoxItem2;
									break;
								}
							}
						}
						finally
						{
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
					}
					this.vmethod_12().SelectedIndex = (int)this.class173_0.TargetType;
					this.method_2();
					IEnumerator enumerator2 = this.vmethod_14().Items.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							ComboBoxItem comboBoxItem3 = (ComboBoxItem)enumerator2.Current;
							if (this.class173_0.TargetSubType == Conversions.ToInteger(comboBoxItem3.Tag))
							{
								this.vmethod_14().SelectedItem = comboBoxItem3;
								break;
							}
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					this.method_3();
					IEnumerator enumerator3 = this.vmethod_16().Items.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							ComboBoxItem comboBoxItem4 = (ComboBoxItem)enumerator3.Current;
							if (this.class173_0.SpecificUnitClass == Conversions.ToInteger(comboBoxItem4.Tag))
							{
								this.vmethod_16().SelectedItem = comboBoxItem4;
								break;
							}
						}
					}
					finally
					{
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					this.method_4();
					bool flag = false;
					if (!Information.IsNothing(this.class173_0.SpecificUnit))
					{
						IEnumerator enumerator4 = this.vmethod_18().Items.GetEnumerator();
						try
						{
							while (enumerator4.MoveNext())
							{
								ComboBoxItem comboBoxItem5 = (ComboBoxItem)enumerator4.Current;
								if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(comboBoxItem5.Tag)) && Operators.CompareString(this.class173_0.SpecificUnit.GetGuid(), ((Subject)comboBoxItem5.Tag).GetGuid(), false) == 0)
								{
									this.vmethod_18().SelectedItem = comboBoxItem5;
									flag = true;
									break;
								}
							}
						}
						finally
						{
							if (enumerator4 is IDisposable)
							{
								(enumerator4 as IDisposable).Dispose();
							}
						}
					}
					if (!flag & !Information.IsNothing(this.class173_0.SpecificUnit))
					{
						ComboBoxItem comboBoxItem6 = new ComboBoxItem();
						comboBoxItem6.Content = this.class173_0.SpecificUnit.Name + " [NOT FOUND!]";
						comboBoxItem6.Tag = this.class173_0.SpecificUnit;
						this.vmethod_18().Items.Add(comboBoxItem6);
						this.vmethod_18().SelectedItem = comboBoxItem6;
						Interaction.MsgBox("The specific unit " + this.class173_0.SpecificUnit.Name + " does not exist in this scenario. Please select another unit.", MsgBoxStyle.OkOnly, null);
					}
				}
			}
		}

		// Token: 0x06004CC0 RID: 19648 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void UnitFilter_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x001E74BC File Offset: 0x001E56BC
		private void method_2()
		{
			this.vmethod_14().Items.Clear();
			this.vmethod_14().DisplayMember = "Content";
			ComboBoxItem comboBoxItem = new ComboBoxItem();
			comboBoxItem.Content = "None";
			this.vmethod_14().Items.Add(comboBoxItem);
			switch (this.class173_0.TargetType)
			{
			case GlobalVariables.ActiveUnitType.None:
			case GlobalVariables.ActiveUnitType.Aimpoint:
				goto IL_49D;
			case GlobalVariables.ActiveUnitType.Aircraft:
			{
				IEnumerable<ActiveUnit> source = Client.GetClientScenario().GetActiveUnits().Values.Where(UnitFilter.ActiveUnitFunc0).Select(UnitFilter.ActiveUnitFunc1);
				if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_2().SelectedItem)))
				{
					goto IL_49D;
				}
				source = source.Where(new Func<ActiveUnit, bool>(this.method_10));
				IEnumerable<Aircraft._AircraftType> enumerable = source.Select(UnitFilter.ActiveUnitFunc2).Distinct<Aircraft._AircraftType>();
				using (IEnumerator<Aircraft._AircraftType> enumerator = enumerable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Aircraft._AircraftType current = enumerator.Current;
						ComboBoxItem comboBoxItem2 = new ComboBoxItem();
						comboBoxItem2.Content = current.ToString();
						comboBoxItem2.Tag = current;
						this.vmethod_14().Items.Add(comboBoxItem2);
					}
					goto IL_49D;
				}
				break;
			}
			case GlobalVariables.ActiveUnitType.Ship:
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				goto IL_21E;
			case GlobalVariables.ActiveUnitType.Facility:
				goto IL_2F5;
			case GlobalVariables.ActiveUnitType.Weapon:
				goto IL_3CC;
			default:
				goto IL_49D;
			}
			IEnumerable<ActiveUnit> source2 = Client.GetClientScenario().GetActiveUnits().Values.Where(UnitFilter.ActiveUnitFunc3).Select(UnitFilter.ActiveUnitFunc4);
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_2().SelectedItem)))
			{
				goto IL_49D;
			}
			source2 = source2.Where(new Func<ActiveUnit, bool>(this.method_11));
			IEnumerable<Ship._ShipType> enumerable2 = source2.Select(UnitFilter.ActiveUnitFunc5).Distinct<Ship._ShipType>();
			using (IEnumerator<Ship._ShipType> enumerator2 = enumerable2.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					Ship._ShipType current2 = enumerator2.Current;
					ComboBoxItem comboBoxItem3 = new ComboBoxItem();
					comboBoxItem3.Content = current2.ToString();
					comboBoxItem3.Tag = current2;
					this.vmethod_14().Items.Add(comboBoxItem3);
				}
				goto IL_49D;
			}
			IL_21E:
			IEnumerable<ActiveUnit> source3 = Client.GetClientScenario().GetActiveUnits().Values.Where(UnitFilter.ActiveUnitFunc6).Select(UnitFilter.ActiveUnitFunc7);
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_2().SelectedItem)))
			{
				goto IL_49D;
			}
			source3 = source3.Where(new Func<ActiveUnit, bool>(this.method_12));
			IEnumerable<Submarine._SubmarineType> enumerable3 = source3.Select(UnitFilter.ActiveUnitFunc8).Distinct<Submarine._SubmarineType>();
			using (IEnumerator<Submarine._SubmarineType> enumerator3 = enumerable3.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					Submarine._SubmarineType current3 = enumerator3.Current;
					ComboBoxItem comboBoxItem4 = new ComboBoxItem();
					comboBoxItem4.Content = current3.ToString();
					comboBoxItem4.Tag = current3;
					this.vmethod_14().Items.Add(comboBoxItem4);
				}
				goto IL_49D;
			}
			IL_2F5:
			IEnumerable<ActiveUnit> source4 = Client.GetClientScenario().GetActiveUnits().Values.Where(UnitFilter.ActiveUnitFunc9).Select(UnitFilter.ActiveUnitFunc10);
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_2().SelectedItem)))
			{
				goto IL_49D;
			}
			source4 = source4.Where(new Func<ActiveUnit, bool>(this.method_13));
			IEnumerable<Facility._FacilityCategory> enumerable4 = source4.Select(UnitFilter.ActiveUnitFunc11).Distinct<Facility._FacilityCategory>();
			using (IEnumerator<Facility._FacilityCategory> enumerator4 = enumerable4.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					Facility._FacilityCategory current4 = enumerator4.Current;
					ComboBoxItem comboBoxItem5 = new ComboBoxItem();
					comboBoxItem5.Content = current4.ToString();
					comboBoxItem5.Tag = current4;
					this.vmethod_14().Items.Add(comboBoxItem5);
				}
				goto IL_49D;
			}
			IL_3CC:
			IEnumerable<ActiveUnit> source5 = Client.GetClientScenario().GetActiveUnits().Values.Where(UnitFilter.ActiveUnitFunc12).Select(UnitFilter.ActiveUnitFunc13);
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_2().SelectedItem)))
			{
				source5 = source5.Where(new Func<ActiveUnit, bool>(this.method_14));
				IEnumerable<Weapon._WeaponType> enumerable5 = source5.Select(UnitFilter.ActiveUnitFunc14).Distinct<Weapon._WeaponType>();
				foreach (Weapon._WeaponType current5 in enumerable5)
				{
					ComboBoxItem comboBoxItem6 = new ComboBoxItem();
					comboBoxItem6.Content = current5.ToString();
					comboBoxItem6.Tag = current5;
					this.vmethod_14().Items.Add(comboBoxItem6);
				}
			}
			IL_49D:
			this.vmethod_14().SelectedIndex = 0;
		}

		// Token: 0x06004CC2 RID: 19650 RVA: 0x001E79B4 File Offset: 0x001E5BB4
		private void method_3()
		{
			this.vmethod_16().Items.Clear();
			this.vmethod_16().DisplayMember = "Content";
			ComboBoxItem comboBoxItem = new ComboBoxItem();
			comboBoxItem.Content = "None";
			this.vmethod_16().Items.Add(comboBoxItem);
			HashSet<int> hashSet = new HashSet<int>();
			switch (this.vmethod_12().SelectedIndex)
			{
			case 0:
			case 5:
				goto IL_647;
			case 1:
			{
				IEnumerable<ActiveUnit> enumerable = Client.GetClientScenario().GetActiveUnits().Values.Where(UnitFilter.ActiveUnitFunc15).Select(UnitFilter.ActiveUnitFunc16);
				if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null))))
				{
					enumerable = enumerable.Where(new Func<ActiveUnit, bool>(this.method_15));
				}
				using (IEnumerator<ActiveUnit> enumerator = enumerable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
						if (((Aircraft)current).Type == (Aircraft._AircraftType)Conversions.ToInteger(NewLateBinding.LateGet(this.vmethod_14().SelectedItem, null, "Tag", new object[0], null, null, null)) && !hashSet.Contains(current.DBID))
						{
							hashSet.Add(current.DBID);
							ComboBoxItem comboBoxItem2 = new ComboBoxItem();
							comboBoxItem2.Content = current.UnitClass;
							comboBoxItem2.Tag = current.DBID;
							this.vmethod_16().Items.Add(comboBoxItem2);
						}
					}
					goto IL_647;
				}
				break;
			}
			case 2:
				break;
			case 3:
				goto IL_2CC;
			case 4:
				goto IL_3F6;
			case 6:
				goto IL_520;
			default:
				goto IL_647;
			}
			IEnumerable<ActiveUnit> enumerable2 = Client.GetClientScenario().GetActiveUnits().Values.Where(UnitFilter.ActiveUnitFunc17).Select(UnitFilter.ActiveUnitFunc18);
			if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null))))
			{
				enumerable2 = enumerable2.Where(new Func<ActiveUnit, bool>(this.method_16));
			}
			using (IEnumerator<ActiveUnit> enumerator2 = enumerable2.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					ActiveUnit current2 = enumerator2.Current;
					if (((Ship)current2).Type == (Ship._ShipType)Conversions.ToInteger(NewLateBinding.LateGet(this.vmethod_14().SelectedItem, null, "Tag", new object[0], null, null, null)) && !hashSet.Contains(current2.DBID))
					{
						hashSet.Add(current2.DBID);
						ComboBoxItem comboBoxItem3 = new ComboBoxItem();
						comboBoxItem3.Content = current2.UnitClass;
						comboBoxItem3.Tag = current2.DBID;
						this.vmethod_16().Items.Add(comboBoxItem3);
					}
				}
				goto IL_647;
			}
			IL_2CC:
			IEnumerable<ActiveUnit> enumerable3 = Client.GetClientScenario().GetActiveUnits().Values.Where(UnitFilter.ActiveUnitFunc19).Select(UnitFilter.ActiveUnitFunc20);
			if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null))))
			{
				enumerable3 = enumerable3.Where(new Func<ActiveUnit, bool>(this.method_17));
			}
			using (IEnumerator<ActiveUnit> enumerator3 = enumerable3.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					ActiveUnit current3 = enumerator3.Current;
					if (((Submarine)current3).Type == (Submarine._SubmarineType)Conversions.ToInteger(NewLateBinding.LateGet(this.vmethod_14().SelectedItem, null, "Tag", new object[0], null, null, null)) && !hashSet.Contains(current3.DBID))
					{
						hashSet.Add(current3.DBID);
						ComboBoxItem comboBoxItem4 = new ComboBoxItem();
						comboBoxItem4.Content = current3.UnitClass;
						comboBoxItem4.Tag = current3.DBID;
						this.vmethod_16().Items.Add(comboBoxItem4);
					}
				}
				goto IL_647;
			}
			IL_3F6:
			IEnumerable<ActiveUnit> enumerable4 = Client.GetClientScenario().GetActiveUnits().Values.Where(UnitFilter.ActiveUnitFunc21).Select(UnitFilter.ActiveUnitFunc22);
			if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null))))
			{
				enumerable4 = enumerable4.Where(new Func<ActiveUnit, bool>(this.method_18));
			}
			using (IEnumerator<ActiveUnit> enumerator4 = enumerable4.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					ActiveUnit current4 = enumerator4.Current;
					if (((Facility)current4).Category == (Facility._FacilityCategory)Conversions.ToShort(NewLateBinding.LateGet(this.vmethod_14().SelectedItem, null, "Tag", new object[0], null, null, null)) && !hashSet.Contains(current4.DBID))
					{
						hashSet.Add(current4.DBID);
						ComboBoxItem comboBoxItem5 = new ComboBoxItem();
						comboBoxItem5.Content = current4.UnitClass;
						comboBoxItem5.Tag = current4.DBID;
						this.vmethod_16().Items.Add(comboBoxItem5);
					}
				}
				goto IL_647;
			}
			IL_520:
			IEnumerable<ActiveUnit> enumerable5 = Client.GetClientScenario().GetActiveUnits().Values.Where(UnitFilter.ActiveUnitFunc23).Select(UnitFilter.ActiveUnitFunc24);
			if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null))))
			{
				enumerable5 = enumerable5.Where(new Func<ActiveUnit, bool>(this.method_19));
			}
			foreach (ActiveUnit current5 in enumerable5)
			{
				if (((Weapon)current5).GetWeaponType() == (Weapon._WeaponType)Conversions.ToShort(NewLateBinding.LateGet(this.vmethod_14().SelectedItem, null, "Tag", new object[0], null, null, null)) && !hashSet.Contains(current5.DBID))
				{
					hashSet.Add(current5.DBID);
					ComboBoxItem comboBoxItem6 = new ComboBoxItem();
					comboBoxItem6.Content = current5.UnitClass;
					comboBoxItem6.Tag = current5.DBID;
					this.vmethod_16().Items.Add(comboBoxItem6);
				}
			}
			IL_647:
			this.vmethod_16().SelectedIndex = 0;
		}

		// Token: 0x06004CC3 RID: 19651 RVA: 0x001E8054 File Offset: 0x001E6254
		private void method_4()
		{
			UnitFilter.Class2519 @class = new UnitFilter.Class2519(null);
			this.vmethod_18().Items.Clear();
			this.vmethod_18().DisplayMember = "Content";
			ComboBoxItem comboBoxItem = new ComboBoxItem();
			comboBoxItem.Content = "None";
			this.vmethod_18().Items.Add(comboBoxItem);
			@class.string_0 = "";
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_2().SelectedItem)) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null))))
			{
				@class.string_0 = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null));
			}
			@class.int_0 = 0;
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_16().SelectedItem)) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.vmethod_16().SelectedItem, null, "Tag", new object[0], null, null, null))))
			{
				@class.int_0 = Conversions.ToInteger(NewLateBinding.LateGet(this.vmethod_16().SelectedItem, null, "Tag", new object[0], null, null, null));
			}
			GlobalVariables.ActiveUnitType targetType = this.class173_0.TargetType;
			if (targetType == GlobalVariables.ActiveUnitType.Aimpoint)
			{
				IEnumerable<ActiveUnit> enumerable = Client.GetClientScenario().GetActiveUnits().Values.Where(new Func<ActiveUnit, bool>(@class.method_0)).Select(UnitFilter.ActiveUnitFunc25).OrderBy(UnitFilter.ActiveUnitFunc26);
				if (!string.IsNullOrEmpty(@class.string_0))
				{
					enumerable = enumerable.Where(new Func<ActiveUnit, bool>(@class.method_1));
				}
				using (IEnumerator<ActiveUnit> enumerator = enumerable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
						ComboBoxItem comboBoxItem2 = new ComboBoxItem();
						comboBoxItem2.Content = current.Name;
						comboBoxItem2.Tag = current;
						this.vmethod_18().Items.Add(comboBoxItem2);
					}
					goto IL_2C1;
				}
			}
			IEnumerable<ActiveUnit> enumerable2 = Client.GetClientScenario().GetActiveUnits().Values.Where(new Func<ActiveUnit, bool>(@class.method_2)).Select(UnitFilter.ActiveUnitFunc27).OrderBy(UnitFilter.ActiveUnitFunc28);
			if (!string.IsNullOrEmpty(@class.string_0))
			{
				enumerable2 = enumerable2.Where(new Func<ActiveUnit, bool>(@class.method_3));
			}
			foreach (ActiveUnit current2 in enumerable2)
			{
				ComboBoxItem comboBoxItem3 = new ComboBoxItem();
				comboBoxItem3.Content = current2.Name;
				comboBoxItem3.Tag = current2;
				this.vmethod_18().Items.Add(comboBoxItem3);
			}
			IL_2C1:
			this.vmethod_18().SelectedIndex = 0;
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x001E834C File Offset: 0x001E654C
		private void method_5(object sender, EventArgs e)
		{
			switch (this.vmethod_12().SelectedIndex)
			{
			case 0:
				this.class173_0.TargetType = GlobalVariables.ActiveUnitType.None;
				break;
			case 1:
				this.class173_0.TargetType = GlobalVariables.ActiveUnitType.Aircraft;
				break;
			case 2:
				this.class173_0.TargetType = GlobalVariables.ActiveUnitType.Ship;
				break;
			case 3:
				this.class173_0.TargetType = GlobalVariables.ActiveUnitType.Submarine;
				break;
			case 4:
				this.class173_0.TargetType = GlobalVariables.ActiveUnitType.Facility;
				break;
			case 6:
				this.class173_0.TargetType = GlobalVariables.ActiveUnitType.Weapon;
				break;
			}
			this.method_2();
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x001E83E4 File Offset: 0x001E65E4
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_14().Items.Count != 0)
			{
				this.class173_0.TargetSubType = Conversions.ToInteger(NewLateBinding.LateGet(this.vmethod_14().SelectedItem, null, "tag", new object[0], null, null, null));
				this.method_3();
			}
		}

		// Token: 0x06004CC6 RID: 19654 RVA: 0x001E843C File Offset: 0x001E663C
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_16().Items.Count != 0)
			{
				this.class173_0.SpecificUnitClass = Conversions.ToInteger(NewLateBinding.LateGet(this.vmethod_16().SelectedItem, null, "Tag", new object[0], null, null, null));
				this.method_4();
			}
		}

		// Token: 0x06004CC7 RID: 19655 RVA: 0x00024850 File Offset: 0x00022A50
		private void method_8(object sender, EventArgs e)
		{
			this.class173_0.TargetSide = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "tag", new object[0], null, null, null));
		}

		// Token: 0x06004CC8 RID: 19656 RVA: 0x00024881 File Offset: 0x00022A81
		private void method_9(object sender, EventArgs e)
		{
			this.class173_0.SpecificUnit = (ActiveUnit)NewLateBinding.LateGet(this.vmethod_18().SelectedItem, null, "tag", new object[0], null, null, null);
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x000248B2 File Offset: 0x00022AB2
		[CompilerGenerated]
		private bool method_10(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.GetSide(false).GetGuid(), NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x06004CCA RID: 19658 RVA: 0x000248B2 File Offset: 0x00022AB2
		[CompilerGenerated]
		private bool method_11(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.GetSide(false).GetGuid(), NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x06004CCB RID: 19659 RVA: 0x000248B2 File Offset: 0x00022AB2
		[CompilerGenerated]
		private bool method_12(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.GetSide(false).GetGuid(), NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x000248B2 File Offset: 0x00022AB2
		[CompilerGenerated]
		private bool method_13(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.GetSide(false).GetGuid(), NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x06004CCD RID: 19661 RVA: 0x000248B2 File Offset: 0x00022AB2
		[CompilerGenerated]
		private bool method_14(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.GetSide(false).GetGuid(), NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x06004CCE RID: 19662 RVA: 0x000248B2 File Offset: 0x00022AB2
		[CompilerGenerated]
		private bool method_15(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.GetSide(false).GetGuid(), NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x06004CCF RID: 19663 RVA: 0x000248B2 File Offset: 0x00022AB2
		[CompilerGenerated]
		private bool method_16(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.GetSide(false).GetGuid(), NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x06004CD0 RID: 19664 RVA: 0x000248B2 File Offset: 0x00022AB2
		[CompilerGenerated]
		private bool method_17(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.GetSide(false).GetGuid(), NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x06004CD1 RID: 19665 RVA: 0x000248B2 File Offset: 0x00022AB2
		[CompilerGenerated]
		private bool method_18(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.GetSide(false).GetGuid(), NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x06004CD2 RID: 19666 RVA: 0x000248B2 File Offset: 0x00022AB2
		[CompilerGenerated]
		private bool method_19(ActiveUnit activeUnit_0)
		{
			return Operators.ConditionalCompareObjectEqual(activeUnit_0.GetSide(false).GetGuid(), NewLateBinding.LateGet(this.vmethod_2().SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x04002421 RID: 9249
		public static Func<ActiveUnit, bool> ActiveUnitFunc0 = (ActiveUnit activeUnit_0) => activeUnit_0.IsAircraft;

		// Token: 0x04002422 RID: 9250
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc1 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04002423 RID: 9251
		public static Func<ActiveUnit, Aircraft._AircraftType> ActiveUnitFunc2 = (ActiveUnit activeUnit_0) => ((Aircraft)activeUnit_0).Type;

		// Token: 0x04002424 RID: 9252
		public static Func<ActiveUnit, bool> ActiveUnitFunc3 = (ActiveUnit activeUnit_0) => activeUnit_0.IsShip;

		// Token: 0x04002425 RID: 9253
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc4 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04002426 RID: 9254
		public static Func<ActiveUnit, Ship._ShipType> ActiveUnitFunc5 = (ActiveUnit activeUnit_0) => ((Ship)activeUnit_0).Type;

		// Token: 0x04002427 RID: 9255
		public static Func<ActiveUnit, bool> ActiveUnitFunc6 = (ActiveUnit activeUnit_0) => activeUnit_0.IsSubmarine;

		// Token: 0x04002428 RID: 9256
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc7 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04002429 RID: 9257
		public static Func<ActiveUnit, Submarine._SubmarineType> ActiveUnitFunc8 = (ActiveUnit activeUnit_0) => ((Submarine)activeUnit_0).Type;

		// Token: 0x0400242A RID: 9258
		public static Func<ActiveUnit, bool> ActiveUnitFunc9 = (ActiveUnit activeUnit_0) => activeUnit_0.IsFacility;

		// Token: 0x0400242B RID: 9259
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc10 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x0400242C RID: 9260
		public static Func<ActiveUnit, Facility._FacilityCategory> ActiveUnitFunc11 = (ActiveUnit activeUnit_0) => ((Facility)activeUnit_0).Category;

		// Token: 0x0400242D RID: 9261
		public static Func<ActiveUnit, bool> ActiveUnitFunc12 = (ActiveUnit activeUnit_0) => activeUnit_0.IsWeapon;

		// Token: 0x0400242E RID: 9262
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc13 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x0400242F RID: 9263
		public static Func<ActiveUnit, Weapon._WeaponType> ActiveUnitFunc14 = (ActiveUnit activeUnit_0) => ((Weapon)activeUnit_0).GetWeaponType();

		// Token: 0x04002430 RID: 9264
		public static Func<ActiveUnit, bool> ActiveUnitFunc15 = (ActiveUnit activeUnit_0) => activeUnit_0.IsAircraft;

		// Token: 0x04002431 RID: 9265
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc16 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04002432 RID: 9266
		public static Func<ActiveUnit, bool> ActiveUnitFunc17 = (ActiveUnit activeUnit_0) => activeUnit_0.IsShip;

		// Token: 0x04002433 RID: 9267
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc18 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04002434 RID: 9268
		public static Func<ActiveUnit, bool> ActiveUnitFunc19 = (ActiveUnit activeUnit_0) => activeUnit_0.IsSubmarine;

		// Token: 0x04002435 RID: 9269
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc20 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04002436 RID: 9270
		public static Func<ActiveUnit, bool> ActiveUnitFunc21 = (ActiveUnit activeUnit_0) => activeUnit_0.IsFacility;

		// Token: 0x04002437 RID: 9271
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc22 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04002438 RID: 9272
		public static Func<ActiveUnit, bool> ActiveUnitFunc23 = (ActiveUnit activeUnit_0) => activeUnit_0.IsWeapon;

		// Token: 0x04002439 RID: 9273
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc24 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x0400243A RID: 9274
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc25 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x0400243B RID: 9275
		public static Func<ActiveUnit, string> ActiveUnitFunc26 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x0400243C RID: 9276
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc27 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x0400243D RID: 9277
		public static Func<ActiveUnit, string> ActiveUnitFunc28 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x0400243E RID: 9278
		private IContainer icontainer_0;

		// Token: 0x0400243F RID: 9279
		[CompilerGenerated]
		private System.Windows.Forms.Label label_0;

		// Token: 0x04002440 RID: 9280
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_0;

		// Token: 0x04002441 RID: 9281
		[CompilerGenerated]
		private System.Windows.Forms.Label label_1;

		// Token: 0x04002442 RID: 9282
		[CompilerGenerated]
		private System.Windows.Forms.Label label_2;

		// Token: 0x04002443 RID: 9283
		[CompilerGenerated]
		private System.Windows.Forms.Label label_3;

		// Token: 0x04002444 RID: 9284
		[CompilerGenerated]
		private System.Windows.Forms.Label label_4;

		// Token: 0x04002445 RID: 9285
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_1;

		// Token: 0x04002446 RID: 9286
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_2;

		// Token: 0x04002447 RID: 9287
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_3;

		// Token: 0x04002448 RID: 9288
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_4;

		// Token: 0x04002449 RID: 9289
		private Target class173_0;

		// Token: 0x020009F9 RID: 2553
		[CompilerGenerated]
		public sealed class Class2519
		{
			// Token: 0x06004CF1 RID: 19697 RVA: 0x000248F5 File Offset: 0x00022AF5
			public Class2519(UnitFilter.Class2519 class2519_0)
			{
				if (class2519_0 != null)
				{
					this.int_0 = class2519_0.int_0;
					this.string_0 = class2519_0.string_0;
				}
			}

			// Token: 0x06004CF2 RID: 19698 RVA: 0x0002491B File Offset: 0x00022B1B
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return !activeUnit_0.IsGroup & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x06004CF3 RID: 19699 RVA: 0x00024935 File Offset: 0x00022B35
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.GetSide(false).GetGuid(), this.string_0, false) == 0;
			}

			// Token: 0x06004CF4 RID: 19700 RVA: 0x0002491B File Offset: 0x00022B1B
			internal bool method_2(ActiveUnit activeUnit_0)
			{
				return !activeUnit_0.IsGroup & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x06004CF5 RID: 19701 RVA: 0x00024935 File Offset: 0x00022B35
			internal bool method_3(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.GetSide(false).GetGuid(), this.string_0, false) == 0;
			}

			// Token: 0x04002467 RID: 9319
			public int int_0;

			// Token: 0x04002468 RID: 9320
			public string string_0;
		}
	}
}
