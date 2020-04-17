using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AdvancedDataGridView;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns29;
using ns32;
using ns35;

namespace ns33
{
	// Token: 0x02000996 RID: 2454
	[DesignerGenerated]
	public sealed partial class DamageControlWindow : CommandForm
	{
		// Token: 0x06003E2C RID: 15916 RVA: 0x00144CF8 File Offset: 0x00142EF8
		public DamageControlWindow()
		{
			base.Load += new EventHandler(this.DamageControlWindow_Load);
			base.KeyDown += new KeyEventHandler(this.DamageControlWindow_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.DamageControlWindow_FormClosing);
			base.FormClosed += new FormClosedEventHandler(this.DamageControlWindow_FormClosed);
			this.InitializeComponent();
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x00145474 File Offset: 0x00143674
		[CompilerGenerated]
		public  TreeGridView vmethod_0()
		{
			return this.treeGridView_0;
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x0014548C File Offset: 0x0014368C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void vmethod_1(TreeGridView treeGridView_1)
		{
			DataGridViewCellMouseEventHandler value = new DataGridViewCellMouseEventHandler(this.method_4);
			TreeGridView treeGridView = this.treeGridView_0;
			if (treeGridView != null)
			{
				treeGridView.CellMouseClick -= value;
			}
			this.treeGridView_0 = treeGridView_1;
			treeGridView = this.treeGridView_0;
			if (treeGridView != null)
			{
				treeGridView.CellMouseClick += value;
			}
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x001454D8 File Offset: 0x001436D8
		[CompilerGenerated]
		internal  ToolStrip vmethod_2()
		{
			return this.toolStrip_0;
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x0002051F File Offset: 0x0001E71F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStrip toolStrip_2)
		{
			this.toolStrip_0 = toolStrip_2;
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x001454F0 File Offset: 0x001436F0
		[CompilerGenerated]
		internal  ToolStripLabel vmethod_4()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00020528 File Offset: 0x0001E728
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripLabel toolStripLabel_3)
		{
			this.toolStripLabel_0 = toolStripLabel_3;
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x00145508 File Offset: 0x00143708
		[CompilerGenerated]
		internal  TreeGridViewTextBoxColumn vmethod_6()
		{
			return this.class2383_0;
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x00020531 File Offset: 0x0001E731
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TreeGridViewTextBoxColumn class2383_3)
		{
			this.class2383_0 = class2383_3;
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x00145520 File Offset: 0x00143720
		[CompilerGenerated]
		internal  ToolStrip vmethod_8()
		{
			return this.toolStrip_1;
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x0002053A File Offset: 0x0001E73A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStrip toolStrip_2)
		{
			this.toolStrip_1 = toolStrip_2;
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x00145538 File Offset: 0x00143738
		[CompilerGenerated]
		internal  ToolStripLabel vmethod_10()
		{
			return this.toolStripLabel_1;
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x00020543 File Offset: 0x0001E743
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStripLabel toolStripLabel_3)
		{
			this.toolStripLabel_1 = toolStripLabel_3;
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x00145550 File Offset: 0x00143750
		[CompilerGenerated]
		internal  ToolStripComboBox vmethod_12()
		{
			return this.toolStripComboBox_0;
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x0002054C File Offset: 0x0001E74C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(ToolStripComboBox toolStripComboBox_1)
		{
			this.toolStripComboBox_0 = toolStripComboBox_1;
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x00145568 File Offset: 0x00143768
		[CompilerGenerated]
		internal  ToolStripLabel vmethod_14()
		{
			return this.toolStripLabel_2;
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x00020555 File Offset: 0x0001E755
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ToolStripLabel toolStripLabel_3)
		{
			this.toolStripLabel_2 = toolStripLabel_3;
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x00145580 File Offset: 0x00143780
		[CompilerGenerated]
		internal  ToolStripTextBox vmethod_16()
		{
			return this.toolStripTextBox_0;
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x00145598 File Offset: 0x00143798
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(ToolStripTextBox toolStripTextBox_1)
		{
			EventHandler value = new EventHandler(this.method_7);
			EventHandler value2 = new EventHandler(this.method_9);
			EventHandler value3 = new EventHandler(this.method_10);
			ToolStripTextBox toolStripTextBox = this.toolStripTextBox_0;
			if (toolStripTextBox != null)
			{
				toolStripTextBox.TextChanged -= value;
				toolStripTextBox.Enter -= value2;
				toolStripTextBox.Leave -= value3;
			}
			this.toolStripTextBox_0 = toolStripTextBox_1;
			toolStripTextBox = this.toolStripTextBox_0;
			if (toolStripTextBox != null)
			{
				toolStripTextBox.TextChanged += value;
				toolStripTextBox.Enter += value2;
				toolStripTextBox.Leave += value3;
			}
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x00145618 File Offset: 0x00143818
		[CompilerGenerated]
		internal  Timer vmethod_18()
		{
			return this.timer_0;
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x00145630 File Offset: 0x00143830
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_8);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_0 = timer_1;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x0014567C File Offset: 0x0014387C
		[CompilerGenerated]
		internal  TreeGridViewTextBoxColumn vmethod_20()
		{
			return this.class2383_1;
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x0002055E File Offset: 0x0001E75E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(TreeGridViewTextBoxColumn class2383_3)
		{
			this.class2383_1 = class2383_3;
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x00145694 File Offset: 0x00143894
		[CompilerGenerated]
		internal  TreeGridViewTextBoxColumn vmethod_22()
		{
			return this.class2383_2;
		}

		// Token: 0x06003E46 RID: 15942 RVA: 0x00020567 File Offset: 0x0001E767
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(TreeGridViewTextBoxColumn class2383_3)
		{
			this.class2383_2 = class2383_3;
		}

		// Token: 0x06003E47 RID: 15943 RVA: 0x001456AC File Offset: 0x001438AC
		[CompilerGenerated]
		public  ComboBox vmethod_24()
		{
			return this.comboBox_0;
		}

		// Token: 0x06003E48 RID: 15944 RVA: 0x001456C4 File Offset: 0x001438C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void vmethod_25(ComboBox comboBox_1)
		{
			EventHandler value = new EventHandler(this.method_5);
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

		// Token: 0x06003E49 RID: 15945 RVA: 0x00145710 File Offset: 0x00143910
		private void DamageControlWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (!Information.IsNothing(this.configuration))
			{
				this.vmethod_8().Visible = (this.configuration.GetGameMode() == Configuration._GameMode.Edit);
			}
			this.vmethod_25(this.vmethod_12().ComboBox);
			this.vmethod_18().Start();
			this.method_1();
			this.platformComponent_0 = (PlatformComponent)this.vmethod_0().method_4().Tag;
			PlatformComponent.smethod_0(new PlatformComponent.Delegate21(this.method_6));
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x001457AC File Offset: 0x001439AC
		private void DamageControlWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F10 && base.Visible)
			{
				base.Close();
			}
			else
			{
				if (this.bool_1 && (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12))
				{
					CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
				if (!this.bool_1)
				{
					CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x001458C4 File Offset: 0x00143AC4
		private void method_1()
		{
			this.vmethod_0().GetRows().Clear();
			this.vmethod_0().Nodes.Clear();
			this.vmethod_4().Text = "毁伤: " + Conversions.ToString(Math.Round((double)this.activeUnit_0.GetDamage().GetDamagePts(), 1)) + "%";
			this.Text = "毁伤状态—" + Misc.smethod_11(this.activeUnit_0.Name);
			checked
			{
				if (this.activeUnit_0.m_Mounts.Length > 0)
				{
					TreeGridViewRow treeGridViewRow = new TreeGridViewRow();
					new TreeGridViewRow();
					treeGridViewRow = this.vmethod_0().Nodes.method_0("挂架");
					Mount[] mounts = this.activeUnit_0.m_Mounts;
					for (int i = 0; i < mounts.Length; i++)
					{
						Mount mount = mounts[i];
						PlatformComponent._ComponentStatus componentStatus = mount.GetComponentStatus();
						string text = "";
						if (componentStatus == PlatformComponent._ComponentStatus.Operational)
						{
							text = "正常工作";
						}
						if (componentStatus == PlatformComponent._ComponentStatus.Damaged)
						{
							text = "受到毁伤";
						}
						if (componentStatus == PlatformComponent._ComponentStatus.Destroyed)
						{
							text = "已被摧毁";
						}
						TreeGridViewRow treeGridViewRow2 = treeGridViewRow.Nodes.method_1(new object[]
						{
							Misc.smethod_11(mount.Name),
							text
						});
						treeGridViewRow2.Tag = mount;
						treeGridViewRow2.DefaultCellStyle.BackColor = base.GetComponentColor(mount);
					}
					treeGridViewRow.vmethod_4();
				}
				if (((Platform)this.activeUnit_0).m_Magazines.Count<Magazine>() > 0)
				{
					TreeGridViewRow treeGridViewRow3 = new TreeGridViewRow();
					new TreeGridViewRow();
					treeGridViewRow3 = this.vmethod_0().Nodes.method_0("弹药库");
					Magazine[] magazines = ((Platform)this.activeUnit_0).m_Magazines;
					for (int j = 0; j < magazines.Length; j++)
					{
						Magazine magazine = magazines[j];
						PlatformComponent._ComponentStatus componentStatus = magazine.GetComponentStatus();
						string text = "";
						if (componentStatus == PlatformComponent._ComponentStatus.Operational)
						{
							text = "正常工作";
						}
						if (componentStatus == PlatformComponent._ComponentStatus.Damaged)
						{
							text = "受到毁伤";
						}
						if (componentStatus == PlatformComponent._ComponentStatus.Destroyed)
						{
							text = "已被摧毁";
						}
						TreeGridViewRow treeGridViewRow4 = treeGridViewRow3.Nodes.method_1(new object[]
						{
							Misc.smethod_11(magazine.Name),
							text
						});
						treeGridViewRow4.Tag = magazine;
						treeGridViewRow4.DefaultCellStyle.BackColor = base.GetComponentColor(magazine);
					}
					treeGridViewRow3.vmethod_4();
				}
				if (this.activeUnit_0.GetNoneMCMSensors().Length > 0)
				{
					TreeGridViewRow treeGridViewRow5 = new TreeGridViewRow();
					new TreeGridViewRow();
					treeGridViewRow5 = this.vmethod_0().Nodes.method_0("传感器");
					Sensor[] noneMCMSensors = this.activeUnit_0.GetNoneMCMSensors();
					for (int k = 0; k < noneMCMSensors.Length; k++)
					{
						Sensor sensor = noneMCMSensors[k];
						PlatformComponent._ComponentStatus componentStatus = sensor.GetComponentStatus();
						string text = "";
						if (componentStatus == PlatformComponent._ComponentStatus.Operational)
						{
							text = "正常工作";
						}
						if (componentStatus == PlatformComponent._ComponentStatus.Damaged)
						{
							text = "受到毁伤";
						}
						if (componentStatus == PlatformComponent._ComponentStatus.Destroyed)
						{
							text = "已被摧毁";
						}
						TreeGridViewRow treeGridViewRow6 = treeGridViewRow5.Nodes.method_1(new object[]
						{
							Misc.smethod_11(sensor.Name),
							text
						});
						treeGridViewRow6.Tag = sensor;
						treeGridViewRow6.DefaultCellStyle.BackColor = base.GetComponentColor(sensor);
					}
					treeGridViewRow5.vmethod_4();
				}
				if (this.activeUnit_0.GetCommDevices().Count<CommDevice>() > 0)
				{
					TreeGridViewRow treeGridViewRow7 = new TreeGridViewRow();
					TreeGridViewRow treeGridViewRow8 = new TreeGridViewRow();
					treeGridViewRow7 = this.vmethod_0().Nodes.method_0("通信与数据链");
					CommDevice[] commDevices = this.activeUnit_0.GetCommDevices();
					for (int l = 0; l < commDevices.Length; l++)
					{
						CommDevice commDevice = commDevices[l];
						PlatformComponent._ComponentStatus componentStatus = commDevice.GetComponentStatus();
						string text = "";
						if (componentStatus == PlatformComponent._ComponentStatus.Operational)
						{
							text = "正常工作";
						}
						if (componentStatus == PlatformComponent._ComponentStatus.Damaged)
						{
							text = "受到毁伤";
						}
						if (componentStatus == PlatformComponent._ComponentStatus.Destroyed)
						{
							text = "已被摧毁";
						}
						string text2 = text;
						if (commDevice.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && commDevice.IsJammed)
						{
							text2 += "-被干扰";
						}
						treeGridViewRow8 = treeGridViewRow7.Nodes.method_1(new object[]
						{
							Misc.smethod_11(commDevice.Name),
							text2
						});
						treeGridViewRow8.Tag = commDevice;
						treeGridViewRow8.DefaultCellStyle.BackColor = base.GetComponentColor(commDevice);
						if (commDevice.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && commDevice.IsJammed)
						{
							treeGridViewRow8.DefaultCellStyle.ForeColor = Color.Blue;
						}
					}
					treeGridViewRow7.vmethod_4();
				}
				if (this.activeUnit_0.GetDockFacilities().Length > 0)
				{
					TreeGridViewRow treeGridViewRow9 = new TreeGridViewRow();
					new TreeGridViewRow();
					treeGridViewRow9 = this.vmethod_0().Nodes.method_0("停靠设施");
					DockFacility[] dockFacilities = this.activeUnit_0.GetDockFacilities();
					for (int m = 0; m < dockFacilities.Length; m++)
					{
						DockFacility dockFacility = dockFacilities[m];
						PlatformComponent._ComponentStatus componentStatus = dockFacility.GetComponentStatus();
						string text = "";
						if (componentStatus == PlatformComponent._ComponentStatus.Operational)
						{
							text = "正常工作";
						}
						if (componentStatus == PlatformComponent._ComponentStatus.Damaged)
						{
							text = "受到毁伤";
						}
						if (componentStatus == PlatformComponent._ComponentStatus.Destroyed)
						{
							text = "已被摧毁";
						}
						TreeGridViewRow treeGridViewRow10 = treeGridViewRow9.Nodes.method_1(new object[]
						{
							Misc.smethod_11(dockFacility.Name),
							text
						});
						treeGridViewRow10.Tag = dockFacility;
						treeGridViewRow10.DefaultCellStyle.BackColor = base.GetComponentColor(dockFacility);
					}
					treeGridViewRow9.vmethod_4();
				}
			}
			if (this.activeUnit_0.GetAirFacilities().Length > 0)
			{
				TreeGridViewRow treeGridViewRow11 = new TreeGridViewRow();
				new TreeGridViewRow();
				treeGridViewRow11 = this.vmethod_0().Nodes.method_0("航空设施");
				for (int n = this.activeUnit_0.GetAirFacilities().Length - 1; n >= 0; n += -1)
				{
					AirFacility airFacility = this.activeUnit_0.GetAirFacilities()[n];
					PlatformComponent._ComponentStatus componentStatus = airFacility.GetComponentStatus();
					string text = "";
					if (componentStatus == PlatformComponent._ComponentStatus.Operational)
					{
						text = "正常工作";
					}
					if (componentStatus == PlatformComponent._ComponentStatus.Damaged)
					{
						text = "受到毁伤";
					}
					if (componentStatus == PlatformComponent._ComponentStatus.Destroyed)
					{
						text = "已被摧毁";
					}
					string text3;
					if (airFacility.GetAircraftSizeClass() > airFacility.GetAircraftSizeAfterDamage())
					{
						text3 = "正常运行, 能力下降";
					}
					else
					{
						text3 = text;
					}
					TreeGridViewRow treeGridViewRow12 = treeGridViewRow11.Nodes.method_1(new object[]
					{
						Misc.smethod_11(airFacility.Name),
						text3
					});
					treeGridViewRow12.Tag = airFacility;
					treeGridViewRow12.DefaultCellStyle.BackColor = base.GetComponentColor(airFacility);
				}
				treeGridViewRow11.vmethod_4();
			}
			if (((Platform)this.activeUnit_0).GetEngines().Count > 0)
			{
				TreeGridViewRow treeGridViewRow13 = new TreeGridViewRow();
				new TreeGridViewRow();
				treeGridViewRow13 = this.vmethod_0().Nodes.method_0("工程/推进系统");
				foreach (Engine current in this.activeUnit_0.GetEngines())
				{
					PlatformComponent._ComponentStatus componentStatus = current.GetComponentStatus();
					string text = "";
					if (componentStatus == PlatformComponent._ComponentStatus.Operational)
					{
						text = "正常工作";
					}
					if (componentStatus == PlatformComponent._ComponentStatus.Damaged)
					{
						text = "受到毁伤";
					}
					if (componentStatus == PlatformComponent._ComponentStatus.Destroyed)
					{
						text = "已被摧毁";
					}
					TreeGridViewRow treeGridViewRow14 = treeGridViewRow13.Nodes.method_1(new object[]
					{
						Misc.smethod_11(current.Name),
						text
					});
					treeGridViewRow14.Tag = current;
					treeGridViewRow14.DefaultCellStyle.BackColor = base.GetComponentColor(current);
				}
				treeGridViewRow13.vmethod_4();
			}
			switch (this.activeUnit_0.GetUnitType())
			{
			case GlobalVariables.ActiveUnitType.Ship:
			{
				TreeGridViewRow treeGridViewRow15 = this.vmethod_0().Nodes.method_1(new object[]
				{
					((Ship)this.activeUnit_0).m_CommandPost.Name,
					((Ship)this.activeUnit_0).m_CommandPost.GetComponentStatus().ToString()
				});
				treeGridViewRow15.Tag = ((Ship)this.activeUnit_0).m_CommandPost;
				treeGridViewRow15.DefaultCellStyle.BackColor = base.GetComponentColor(((Ship)this.activeUnit_0).m_CommandPost);
				TreeGridViewRow treeGridViewRow16 = this.vmethod_0().Nodes.method_1(new object[]
				{
					((Ship)this.activeUnit_0).m_Rudder.Name,
					((Ship)this.activeUnit_0).m_Rudder.GetComponentStatus().ToString()
				});
				treeGridViewRow16.Tag = ((Ship)this.activeUnit_0).m_Rudder;
				treeGridViewRow16.DefaultCellStyle.BackColor = base.GetComponentColor(((Ship)this.activeUnit_0).m_Rudder);
				break;
			}
			case GlobalVariables.ActiveUnitType.Submarine:
			{
				TreeGridViewRow treeGridViewRow17 = this.vmethod_0().Nodes.method_1(new object[]
				{
					((Submarine)this.activeUnit_0).m_CIC.Name,
					((Submarine)this.activeUnit_0).m_CIC.GetComponentStatus().ToString()
				});
				treeGridViewRow17.Tag = ((Submarine)this.activeUnit_0).m_CIC;
				treeGridViewRow17.DefaultCellStyle.BackColor = base.GetComponentColor(((Submarine)this.activeUnit_0).m_CIC);
				TreeGridViewRow treeGridViewRow18 = this.vmethod_0().Nodes.method_1(new object[]
				{
					((Submarine)this.activeUnit_0).m_Rudder.Name,
					((Submarine)this.activeUnit_0).m_Rudder.GetComponentStatus().ToString()
				});
				treeGridViewRow18.Tag = ((Submarine)this.activeUnit_0).m_Rudder;
				treeGridViewRow18.DefaultCellStyle.BackColor = base.GetComponentColor(((Submarine)this.activeUnit_0).m_Rudder);
				break;
			}
			case GlobalVariables.ActiveUnitType.Facility:
			{
				TreeGridViewRow treeGridViewRow19 = this.vmethod_0().Nodes.method_1(new object[]
				{
					((Facility)this.activeUnit_0).m_CommandPost.Name,
					((Facility)this.activeUnit_0).m_CommandPost.GetComponentStatus().ToString()
				});
				treeGridViewRow19.Tag = ((Facility)this.activeUnit_0).m_CommandPost;
				treeGridViewRow19.DefaultCellStyle.BackColor = base.GetComponentColor(((Facility)this.activeUnit_0).m_CommandPost);
				break;
			}
			}
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x001463FC File Offset: 0x001445FC
		private void method_2()
		{
			foreach (TreeGridViewRow current in this.vmethod_0().Nodes)
			{
				this.method_3(current);
			}
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x00146454 File Offset: 0x00144654
		private void method_3(TreeGridViewRow class2384_0)
		{
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(class2384_0.Tag)))
			{
				PlatformComponent platformComponent = (PlatformComponent)class2384_0.Tag;
				string text = platformComponent.GetComponentStatus().ToString();
				if (platformComponent.GetType() == typeof(CommDevice) && platformComponent.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && ((CommDevice)platformComponent).IsJammed)
				{
					text += " -被干扰";
					class2384_0.DefaultCellStyle.ForeColor = Color.Blue;
				}
				class2384_0.SetValues(new object[]
				{
					platformComponent.Name,
					text
				});
				class2384_0.DefaultCellStyle.BackColor = base.GetComponentColor(platformComponent);
			}
			foreach (TreeGridViewRow current in class2384_0.Nodes)
			{
				this.method_3(current);
			}
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x00146558 File Offset: 0x00144758
		private void method_4(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_0().method_4().Tag)))
			{
				this.platformComponent_0 = (PlatformComponent)this.vmethod_0().method_4().Tag;
				switch (this.platformComponent_0.GetComponentStatus())
				{
				case PlatformComponent._ComponentStatus.Operational:
					this.vmethod_12().SelectedIndex = 0;
					break;
				case PlatformComponent._ComponentStatus.Damaged:
					switch (this.platformComponent_0.GetDamageSeverity())
					{
					case PlatformComponent._DamageSeverityFactor.Light:
						this.vmethod_12().SelectedIndex = 1;
						break;
					case PlatformComponent._DamageSeverityFactor.Medium:
						this.vmethod_12().SelectedIndex = 2;
						break;
					case PlatformComponent._DamageSeverityFactor.Heavy:
						this.vmethod_12().SelectedIndex = 3;
						break;
					}
					break;
				case PlatformComponent._ComponentStatus.Destroyed:
					this.vmethod_12().SelectedIndex = 4;
					break;
				}
			}
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x00146624 File Offset: 0x00144824
		private void method_5(object sender, EventArgs e)
		{
			foreach (TreeGridViewRow current in Class2529.smethod_10(this.vmethod_0()))
			{
				if (current.Selected && !Information.IsNothing(RuntimeHelpers.GetObjectValue(current.Tag)))
				{
					this.platformComponent_0 = (PlatformComponent)current.Tag;
					if (!Information.IsNothing(this.platformComponent_0))
					{
						switch (this.vmethod_24().SelectedIndex)
						{
						case 0:
							this.platformComponent_0.method_25(true);
							break;
						case 1:
							this.platformComponent_0.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Light);
							break;
						case 2:
							this.platformComponent_0.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Medium);
							break;
						case 3:
							this.platformComponent_0.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Heavy);
							break;
						case 4:
							this.platformComponent_0.BeDestroyed(this.activeUnit_0.GetSide(false), true, false);
							break;
						}
					}
				}
			}
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x00020570 File Offset: 0x0001E770
		private void method_6(PlatformComponent platformComponent_1)
		{
			if (platformComponent_1.GetParentPlatform() == this.activeUnit_0)
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x00146730 File Offset: 0x00144930
		private void method_7(object sender, EventArgs e)
		{
			if (!(Operators.CompareString(this.vmethod_16().Text, "", false) == 0 | !Versioned.IsNumeric(this.vmethod_16().Text)))
			{
				if (Conversions.ToDouble(this.vmethod_16().Text) < 0.0)
				{
					this.vmethod_16().Text = 0.ToString();
				}
				if (Conversions.ToDouble(this.vmethod_16().Text) > 100.0)
				{
					this.vmethod_16().Text = 100.ToString();
				}
				this.activeUnit_0.SetDamagePts(false, (float)((double)this.activeUnit_0.GetInitialDP() * ((100.0 - Conversions.ToDouble(this.vmethod_16().Text)) / 100.0)));
				this.vmethod_4().Text = "Damage: " + Conversions.ToString(Math.Round((double)this.activeUnit_0.GetDamage().GetDamagePts(), 2)) + "%";
			}
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x0002058C File Offset: 0x0001E78C
		private void method_8(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				this.method_2();
				this.bool_0 = false;
			}
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x000205A6 File Offset: 0x0001E7A6
		private void DamageControlWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
			Client.b_Completed = true;
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x000205CC File Offset: 0x0001E7CC
		private void DamageControlWindow_FormClosed(object sender, FormClosedEventArgs e)
		{
			PlatformComponent.smethod_1(new PlatformComponent.Delegate21(this.method_6));
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x000205DF File Offset: 0x0001E7DF
		private void method_9(object sender, EventArgs e)
		{
			this.bool_1 = true;
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x000205E8 File Offset: 0x0001E7E8
		private void method_10(object sender, EventArgs e)
		{
			this.bool_1 = false;
			this.vmethod_10().Select();
		}

		// Token: 0x04001C96 RID: 7318
		[CompilerGenerated]
		private TreeGridView treeGridView_0;

		// Token: 0x04001C97 RID: 7319
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x04001C98 RID: 7320
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x04001C99 RID: 7321
		[CompilerGenerated]
		private TreeGridViewTextBoxColumn class2383_0;

		// Token: 0x04001C9A RID: 7322
		[CompilerGenerated]
		private ToolStrip toolStrip_1;

		// Token: 0x04001C9B RID: 7323
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_1;

		// Token: 0x04001C9C RID: 7324
		[CompilerGenerated]
		private ToolStripComboBox toolStripComboBox_0;

		// Token: 0x04001C9D RID: 7325
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_2;

		// Token: 0x04001C9E RID: 7326
		[CompilerGenerated]
		private ToolStripTextBox toolStripTextBox_0;

		// Token: 0x04001C9F RID: 7327
		[CompilerGenerated]
		private Timer timer_0;

		// Token: 0x04001CA0 RID: 7328
		[CompilerGenerated]
		private TreeGridViewTextBoxColumn class2383_1;

		// Token: 0x04001CA1 RID: 7329
		[CompilerGenerated]
		private TreeGridViewTextBoxColumn class2383_2;

		// Token: 0x04001CA2 RID: 7330
		public ActiveUnit activeUnit_0;

		// Token: 0x04001CA3 RID: 7331
		public Configuration configuration;

		// Token: 0x04001CA4 RID: 7332
		private PlatformComponent platformComponent_0;

		// Token: 0x04001CA5 RID: 7333
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04001CA6 RID: 7334
		private bool bool_0;

		// Token: 0x04001CA7 RID: 7335
		private bool bool_1;
	}
}
