using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns4;

namespace ns33
{
	// Token: 0x02000A2C RID: 2604
	[DesignerGenerated]
	public sealed partial class FlightPlanTime : CommandForm
	{
		// Token: 0x060051F9 RID: 20985 RVA: 0x00217860 File Offset: 0x00215A60
		public FlightPlanTime()
		{
			base.Load += new EventHandler(this.FlightPlanTime_Load);
			base.KeyDown += new KeyEventHandler(this.FlightPlanTime_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.FlightPlanTime_FormClosing);
			this.bool_0 = false;
			this.InitializeComponent();
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x00217CB4 File Offset: 0x00215EB4
		[CompilerGenerated]
		internal  DateTimePicker vmethod_0()
		{
			return this.dateTimePicker_0;
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x00217CCC File Offset: 0x00215ECC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DateTimePicker dateTimePicker_3)
		{
			EventHandler value = new EventHandler(this.method_8);
			EventHandler value2 = new EventHandler(this.method_9);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.method_12);
			DateTimePicker dateTimePicker = this.dateTimePicker_0;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
				dateTimePicker.KeyPress -= value3;
			}
			this.dateTimePicker_0 = dateTimePicker_3;
			dateTimePicker = this.dateTimePicker_0;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
				dateTimePicker.KeyPress += value3;
			}
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x00217D4C File Offset: 0x00215F4C
		[CompilerGenerated]
		internal  DateTimePicker vmethod_2()
		{
			return this.dateTimePicker_1;
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x00217D64 File Offset: 0x00215F64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(DateTimePicker dateTimePicker_3)
		{
			EventHandler value = new EventHandler(this.method_3);
			EventHandler value2 = new EventHandler(this.method_4);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.method_13);
			DateTimePicker dateTimePicker = this.dateTimePicker_1;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
				dateTimePicker.KeyPress -= value3;
			}
			this.dateTimePicker_1 = dateTimePicker_3;
			dateTimePicker = this.dateTimePicker_1;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
				dateTimePicker.KeyPress += value3;
			}
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x00217DE4 File Offset: 0x00215FE4
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_0;
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x000263DE File Offset: 0x000245DE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_3)
		{
			this.label_0 = label_3;
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x00217DFC File Offset: 0x00215FFC
		[CompilerGenerated]
		internal  Label vmethod_6()
		{
			return this.label_1;
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x000263E7 File Offset: 0x000245E7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Label label_3)
		{
			this.label_1 = label_3;
		}

		// Token: 0x06005204 RID: 20996 RVA: 0x00217E14 File Offset: 0x00216014
		[CompilerGenerated]
		internal  DateTimePicker vmethod_8()
		{
			return this.dateTimePicker_2;
		}

		// Token: 0x06005205 RID: 20997 RVA: 0x00217E2C File Offset: 0x0021602C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(DateTimePicker dateTimePicker_3)
		{
			EventHandler value = new EventHandler(this.method_5);
			EventHandler value2 = new EventHandler(this.method_6);
			DateTimePicker dateTimePicker = this.dateTimePicker_2;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
			}
			this.dateTimePicker_2 = dateTimePicker_3;
			dateTimePicker = this.dateTimePicker_2;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
			}
		}

		// Token: 0x06005206 RID: 20998 RVA: 0x00217E90 File Offset: 0x00216090
		[CompilerGenerated]
		internal  Label vmethod_10()
		{
			return this.label_2;
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x000263F0 File Offset: 0x000245F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Label label_3)
		{
			this.label_2 = label_3;
		}

		// Token: 0x06005208 RID: 21000 RVA: 0x00217EA8 File Offset: 0x002160A8
		private void method_1()
		{
			if (this.waypoint_0.ArrivalTime_Zulu.HasValue)
			{
				this.vmethod_4().Text = string.Concat(new string[]
				{
					"作战任务已经启动(开始时间: ",
					this.waypoint_0.ArrivalTime_Zulu.Value.ToShortDateString(),
					" - ",
					this.waypoint_0.ArrivalTime_Zulu.Value.ToLongTimeString(),
					" Zulu)"
				});
			}
			else
			{
				this.vmethod_4().Text = "作战任务已经启动";
			}
		}

		// Token: 0x06005209 RID: 21001 RVA: 0x000263F9 File Offset: 0x000245F9
		private void FlightPlanTime_Load(object sender, EventArgs e)
		{
			this.method_1();
			this.bool_0 = false;
			this.vmethod_0().Enabled = true;
			this.vmethod_2().Enabled = true;
			this.bool_0 = true;
		}

		// Token: 0x0600520A RID: 21002 RVA: 0x00217F44 File Offset: 0x00216144
		public void method_2()
		{
			int i = Client.flightPlanEditor.SelectedFlightPlanWaypoints.vmethod_0().Rows.Count - 1;
			DateTime value = new DateTime(2000, 1, 1, 0, 0, 0);
			while (i >= 0)
			{
				DataGridViewRow dataGridViewRow = Client.flightPlanEditor.SelectedFlightPlanWaypoints.vmethod_0().Rows[i];
				if (dataGridViewRow.Selected)
				{
					this.waypoint_0 = (Waypoint)dataGridViewRow.Tag;
					if (this.waypoint_0.ArrivalTime_Zulu.HasValue)
					{
						this.vmethod_0().Value = this.waypoint_0.ArrivalTime_Zulu.Value;
						this.vmethod_2().Value = this.waypoint_0.ArrivalTime_Zulu.Value;
					}
					else
					{
						this.vmethod_0().Value = Client.GetClientScenario().GetStartTime();
						this.vmethod_2().Value = Client.GetClientScenario().GetStartTime();
					}
					if (this.waypoint_0.waypointType == Waypoint.WaypointType.Assemble && !Information.IsNothing(this.waypoint_0.ArrivalTime_Zulu))
					{
						DateTime dateTime = new DateTime(2000, 1, 1, 0, 0, 1);
						this.vmethod_8().Value = dateTime.AddSeconds((double)(this.waypoint_0.Hold_Time - 1f));
						this.vmethod_8().Enabled = true;
					}
					else
					{
						this.vmethod_8().Value = value;
						this.vmethod_8().Enabled = false;
					}
					return;
				}
				i += -1;
			}
			if (this.waypoint_0.ArrivalTime_Zulu.HasValue)
			{
				this.vmethod_0().Value = this.waypoint_0.ArrivalTime_Zulu.Value;
				this.vmethod_2().Value = this.waypoint_0.ArrivalTime_Zulu.Value;
			}
			else
			{
				this.vmethod_0().Value = Client.GetClientScenario().GetStartTime();
				this.vmethod_2().Value = Client.GetClientScenario().GetStartTime();
			}
			if (this.waypoint_0.waypointType == Waypoint.WaypointType.Assemble && !Information.IsNothing(this.waypoint_0.ArrivalTime_Zulu))
			{
				DateTime dateTime = new DateTime(2000, 1, 1, 0, 0, 1);
				this.vmethod_8().Value = dateTime.AddSeconds((double)(this.waypoint_0.Hold_Time - 1f));
				this.vmethod_8().Enabled = true;
				return;
			}
			this.vmethod_8().Value = value;
			this.vmethod_8().Enabled = false;
		}

		// Token: 0x0600520B RID: 21003 RVA: 0x00026427 File Offset: 0x00024627
		private void method_3(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x0600520C RID: 21004 RVA: 0x00026430 File Offset: 0x00024630
		private void method_4(object sender, EventArgs e)
		{
			this.method_7();
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x00026427 File Offset: 0x00024627
		private void method_5(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x00026430 File Offset: 0x00024630
		private void method_6(object sender, EventArgs e)
		{
			this.method_7();
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x00026438 File Offset: 0x00024638
		private void method_7()
		{
			if (this.bool_0)
			{
				this.method_11();
			}
			this.bool_0 = false;
		}

		// Token: 0x06005210 RID: 21008 RVA: 0x00026427 File Offset: 0x00024627
		private void method_8(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x00026452 File Offset: 0x00024652
		private void method_9(object sender, EventArgs e)
		{
			this.method_10();
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x00026438 File Offset: 0x00024638
		private void method_10()
		{
			if (this.bool_0)
			{
				this.method_11();
			}
			this.bool_0 = false;
		}

		// Token: 0x06005213 RID: 21011 RVA: 0x002181C0 File Offset: 0x002163C0
		private void method_11()
		{
			DateTime dateTime = new DateTime(this.vmethod_0().Value.Year, this.vmethod_0().Value.Month, this.vmethod_0().Value.Day, this.vmethod_2().Value.Hour, this.vmethod_2().Value.Minute, this.vmethod_2().Value.Second);
			DateTime d = new DateTime(2000, 1, 1, 0, 0, 1);
			double num = Math.Abs((this.vmethod_8().Value - d).TotalSeconds + 1.0);
			bool flag = false;
			bool flag2 = false;
			if (!Information.IsNothing(this.waypoint_0.ArrivalTime_Zulu) && Math.Abs(DateTime.Compare(this.waypoint_0.ArrivalTime_Zulu.Value, dateTime)) > 1 && DateTime.Compare(this.vmethod_0().Value, Client.GetClientScenario().GetStartTime()) != 0 && DateTime.Compare(this.vmethod_2().Value, Client.GetClientScenario().GetStartTime()) != 0)
			{
				flag = true;
			}
			if ((double)this.waypoint_0.Hold_Time != num)
			{
				flag2 = true;
			}
			if (flag || flag2)
			{
				if (flag)
				{
					this.waypoint_0.ArrivalTime_Zulu = new DateTime?(dateTime);
					this.waypoint_0.TimeFixed = Waypoint.Enum52.const_1;
					if (Client.flightPlanEditor.SelectedFlightPlanWaypoints.enum70_0 != Mission.Flight._FlightRole.const_1)
					{
						Waypoint[] flightCourse = Client.flightPlanEditor.m_Flight.GetFlightCourse();
						for (int i = 0; i < flightCourse.Length; i = checked(i + 1))
						{
							Waypoint waypoint = flightCourse[i];
							if (!Information.IsNothing(waypoint.WP_LeadElementWingman) && Information.IsNothing(waypoint.ArrivalTime_Zulu) && waypoint.WP_LeadElementWingman == this.waypoint_0)
							{
								if (Client.flightPlanEditor.m_mission.MissionClass == Mission._MissionClass.Strike && (waypoint.waypointType == Waypoint.WaypointType.Target || waypoint.waypointType == Waypoint.WaypointType.WeaponTarget))
								{
									Strike strike = (Strike)Client.flightPlanEditor.m_mission;
									waypoint.ArrivalTime_Zulu = new DateTime?(this.waypoint_0.ArrivalTime_Zulu.Value.AddSeconds(-(double)StrikePlanner.smethod_44(strike.AttackMethod)));
								}
								else
								{
									waypoint.ArrivalTime_Zulu = this.waypoint_0.ArrivalTime_Zulu;
								}
								waypoint.TimeFixed = this.waypoint_0.TimeFixed;
							}
							if (!Information.IsNothing(waypoint.WP_SecondElement) && Information.IsNothing(waypoint.ArrivalTime_Zulu) && waypoint.WP_SecondElement == this.waypoint_0)
							{
								if (Client.flightPlanEditor.m_mission.MissionClass == Mission._MissionClass.Strike && (waypoint.waypointType == Waypoint.WaypointType.Target || waypoint.waypointType == Waypoint.WaypointType.WeaponTarget))
								{
									Strike strike2 = (Strike)Client.flightPlanEditor.m_mission;
									waypoint.ArrivalTime_Zulu = new DateTime?(this.waypoint_0.ArrivalTime_Zulu.Value.AddSeconds(-(double)StrikePlanner.smethod_44(strike2.AttackMethod) * 2.0));
								}
								else
								{
									waypoint.ArrivalTime_Zulu = this.waypoint_0.ArrivalTime_Zulu;
								}
								waypoint.TimeFixed = this.waypoint_0.TimeFixed;
							}
							if (!Information.IsNothing(waypoint.WP_SecondElementWingman) && Information.IsNothing(waypoint.ArrivalTime_Zulu) && waypoint.WP_SecondElementWingman == this.waypoint_0)
							{
								if (Client.flightPlanEditor.m_mission.MissionClass == Mission._MissionClass.Strike && (waypoint.waypointType == Waypoint.WaypointType.Target || waypoint.waypointType == Waypoint.WaypointType.WeaponTarget))
								{
									Strike strike3 = (Strike)Client.flightPlanEditor.m_mission;
									waypoint.ArrivalTime_Zulu = new DateTime?(this.waypoint_0.ArrivalTime_Zulu.Value.AddSeconds(-(double)StrikePlanner.smethod_44(strike3.AttackMethod) * 3.0));
								}
								else
								{
									waypoint.ArrivalTime_Zulu = this.waypoint_0.ArrivalTime_Zulu;
								}
								waypoint.TimeFixed = this.waypoint_0.TimeFixed;
							}
							if (!Information.IsNothing(waypoint.WP_ThirdElement) && Information.IsNothing(waypoint.ArrivalTime_Zulu) && waypoint.WP_ThirdElement == this.waypoint_0)
							{
								if (Client.flightPlanEditor.m_mission.MissionClass == Mission._MissionClass.Strike && (waypoint.waypointType == Waypoint.WaypointType.Target || waypoint.waypointType == Waypoint.WaypointType.WeaponTarget))
								{
									Strike strike4 = (Strike)Client.flightPlanEditor.m_mission;
									waypoint.ArrivalTime_Zulu = new DateTime?(this.waypoint_0.ArrivalTime_Zulu.Value.AddSeconds(-(double)StrikePlanner.smethod_44(strike4.AttackMethod) * 4.0));
								}
								else
								{
									waypoint.ArrivalTime_Zulu = this.waypoint_0.ArrivalTime_Zulu;
								}
								waypoint.TimeFixed = this.waypoint_0.TimeFixed;
							}
							if (!Information.IsNothing(waypoint.WP_ThirdElementWingman) && Information.IsNothing(waypoint.ArrivalTime_Zulu) && waypoint.WP_ThirdElementWingman == this.waypoint_0)
							{
								if (Client.flightPlanEditor.m_mission.MissionClass == Mission._MissionClass.Strike && (waypoint.waypointType == Waypoint.WaypointType.Target || waypoint.waypointType == Waypoint.WaypointType.WeaponTarget))
								{
									Strike strike5 = (Strike)Client.flightPlanEditor.m_mission;
									waypoint.ArrivalTime_Zulu = new DateTime?(this.waypoint_0.ArrivalTime_Zulu.Value.AddSeconds(-(double)StrikePlanner.smethod_44(strike5.AttackMethod) * 5.0));
								}
								else
								{
									waypoint.ArrivalTime_Zulu = this.waypoint_0.ArrivalTime_Zulu;
								}
								waypoint.TimeFixed = this.waypoint_0.TimeFixed;
							}
						}
					}
					if (this.waypoint_0.FlightFormation != Waypoint._FlightFormation.Split)
					{
						if (!Information.IsNothing(this.waypoint_0.WP_LeadElementWingman))
						{
							this.waypoint_0.WP_LeadElementWingman.ArrivalTime_Zulu = this.waypoint_0.ArrivalTime_Zulu;
							this.waypoint_0.WP_LeadElementWingman.TimeFixed = Waypoint.Enum52.const_1;
						}
						if (!Information.IsNothing(this.waypoint_0.WP_SecondElement))
						{
							this.waypoint_0.WP_SecondElement.ArrivalTime_Zulu = this.waypoint_0.ArrivalTime_Zulu;
							this.waypoint_0.WP_SecondElement.TimeFixed = Waypoint.Enum52.const_1;
						}
						if (!Information.IsNothing(this.waypoint_0.WP_SecondElementWingman))
						{
							this.waypoint_0.WP_SecondElementWingman.ArrivalTime_Zulu = this.waypoint_0.ArrivalTime_Zulu;
							this.waypoint_0.WP_SecondElementWingman.TimeFixed = Waypoint.Enum52.const_1;
						}
						if (!Information.IsNothing(this.waypoint_0.WP_ThirdElement))
						{
							this.waypoint_0.WP_ThirdElement.ArrivalTime_Zulu = this.waypoint_0.ArrivalTime_Zulu;
							this.waypoint_0.WP_ThirdElement.TimeFixed = Waypoint.Enum52.const_1;
						}
						if (!Information.IsNothing(this.waypoint_0.WP_ThirdElementWingman))
						{
							this.waypoint_0.WP_ThirdElementWingman.ArrivalTime_Zulu = this.waypoint_0.ArrivalTime_Zulu;
							this.waypoint_0.WP_ThirdElementWingman.TimeFixed = Waypoint.Enum52.const_1;
						}
					}
				}
				if (flag2 && this.waypoint_0.waypointType == Waypoint.WaypointType.Assemble && !Information.IsNothing(this.waypoint_0.ArrivalTime_Zulu))
				{
					this.waypoint_0.Hold_Time = (float)((long)Math.Round(num));
				}
				Scenario clientScenario = Client.GetClientScenario();
				Mission mission = Client.flightPlanEditor.m_mission;
				ActiveUnit referenceUnit = Client.flightPlanEditor.m_Flight.GetReferenceUnit(Client.GetClientScenario());
				Mission.Flight flight = Client.flightPlanEditor.m_Flight;
				Mission.Flight flight2;
				Waypoint[] flightCourse2 = (flight2 = Client.flightPlanEditor.m_Flight).GetFlightCourse();
				Mission.Enum60 bingo = ((Strike)Client.flightPlanEditor.m_mission).Bingo;
				float num2 = 0f;
				StrikePlanner.smethod_8(clientScenario, mission, referenceUnit, flight, ref flightCourse2, bingo, ref num2, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
				flight2.SetFlightCourse(flightCourse2);
				CommandFactory.GetCommandMain().GetMainForm().method_157();
				if (Client.flightPlanEditor.Visible)
				{
					Client.flightPlanEditor.method_5();
					Client.flightPlanEditor.method_6();
				}
			}
		}

		// Token: 0x06005214 RID: 21012 RVA: 0x00025FB9 File Offset: 0x000241B9
		private void method_12(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x06005215 RID: 21013 RVA: 0x00025FB9 File Offset: 0x000241B9
		private void method_13(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x06005216 RID: 21014 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void FlightPlanTime_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06005217 RID: 21015 RVA: 0x00218A64 File Offset: 0x00216C64
		private void FlightPlanTime_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			if (this.vmethod_0().Focused)
			{
				this.method_10();
			}
			if (this.vmethod_2().Focused)
			{
				this.method_7();
			}
			if (this.vmethod_8().Focused)
			{
				this.method_7();
			}
			this.vmethod_4().Select();
			base.Hide();
			if (Client.GetMissionEditor().Visible)
			{
				Client.GetMissionEditor().method_9();
			}
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x04002683 RID: 9859
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_0;

		// Token: 0x04002684 RID: 9860
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_1;

		// Token: 0x04002685 RID: 9861
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04002686 RID: 9862
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04002687 RID: 9863
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_2;

		// Token: 0x04002688 RID: 9864
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04002689 RID: 9865
		public Waypoint waypoint_0;

		// Token: 0x0400268A RID: 9866
		private bool bool_0;
	}
}
