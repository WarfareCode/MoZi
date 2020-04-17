using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x020009A1 RID: 2465
	[DesignerGenerated]
	public sealed partial class SaveGroup : CommandForm
	{
		// Token: 0x06004002 RID: 16386 RVA: 0x00159440 File Offset: 0x00157640
		public SaveGroup()
		{
			base.Load += new EventHandler(this.SaveGroup_Load);
			base.KeyDown += new KeyEventHandler(this.SaveGroup_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.SaveGroup_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x00159A68 File Offset: 0x00157C68
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x00020CE0 File Offset: 0x0001EEE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_4)
		{
			this.label_0 = label_4;
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x00159A80 File Offset: 0x00157C80
		[CompilerGenerated]
		internal  TextBox vmethod_2()
		{
			return this.textBox_0;
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x00020CE9 File Offset: 0x0001EEE9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TextBox textBox_4)
		{
			this.textBox_0 = textBox_4;
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x00159A98 File Offset: 0x00157C98
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_1;
		}

		// Token: 0x0600400A RID: 16394 RVA: 0x00020CF2 File Offset: 0x0001EEF2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_4)
		{
			this.label_1 = label_4;
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x00159AB0 File Offset: 0x00157CB0
		[CompilerGenerated]
		internal  TextBox vmethod_6()
		{
			return this.textBox_1;
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x00020CFB File Offset: 0x0001EEFB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TextBox textBox_4)
		{
			this.textBox_1 = textBox_4;
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x00159AC8 File Offset: 0x00157CC8
		[CompilerGenerated]
		internal  Label vmethod_8()
		{
			return this.label_2;
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x00020D04 File Offset: 0x0001EF04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Label label_4)
		{
			this.label_2 = label_4;
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x00159AE0 File Offset: 0x00157CE0
		[CompilerGenerated]
		internal  TextBox vmethod_10()
		{
			return this.textBox_2;
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x00020D0D File Offset: 0x0001EF0D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(TextBox textBox_4)
		{
			this.textBox_2 = textBox_4;
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x00159AF8 File Offset: 0x00157CF8
		[CompilerGenerated]
		internal  TextBox vmethod_12()
		{
			return this.textBox_3;
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x00020D16 File Offset: 0x0001EF16
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(TextBox textBox_4)
		{
			this.textBox_3 = textBox_4;
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x00159B10 File Offset: 0x00157D10
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_3;
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x00020D1F File Offset: 0x0001EF1F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_4)
		{
			this.label_3 = label_4;
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x00159B28 File Offset: 0x00157D28
		[CompilerGenerated]
		internal  Button vmethod_16()
		{
			return this.button_0;
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x00159B40 File Offset: 0x00157D40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_2);
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

		// Token: 0x06004017 RID: 16407 RVA: 0x00159B8C File Offset: 0x00157D8C
		[CompilerGenerated]
		internal  Button vmethod_18()
		{
			return this.button_1;
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x00159BA4 File Offset: 0x00157DA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_1);
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

		// Token: 0x06004019 RID: 16409 RVA: 0x00159BF0 File Offset: 0x00157DF0
		[CompilerGenerated]
		internal  SaveFileDialog vmethod_20()
		{
			return this.saveFileDialog_0;
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x00020D28 File Offset: 0x0001EF28
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(SaveFileDialog saveFileDialog_1)
		{
			this.saveFileDialog_0 = saveFileDialog_1;
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x00020D31 File Offset: 0x0001EF31
		private void SaveGroup_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.readOnlyCollection_0 = Client.GetClientSide().GetUnitReadOnlyCollection();
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x00159C08 File Offset: 0x00157E08
		private void method_2(object sender, EventArgs e)
		{
			ImportExportRecord importExportRecord = new ImportExportRecord();
			importExportRecord.Name = this.vmethod_2().Text;
			importExportRecord.ValidFrom = this.vmethod_6().Text;
			importExportRecord.ValidUntil = this.vmethod_10().Text;
			importExportRecord.Comments = this.vmethod_12().Text;
			importExportRecord.DB_ID = Client.GetDBRecord().DBID;
			using (List<Unit>.Enumerator enumerator = this.readOnlyCollection_0.Where(SaveGroup.UnitFunc).ToList<Unit>().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ActiveUnit activeUnit = (ActiveUnit)enumerator.Current;
					ImportExportRecord.MemberRecord memberRecord;
					if (activeUnit.IsGroup)
					{
						using (IEnumerator<ActiveUnit> enumerator2 = ((Group)activeUnit).GetUnitsInGroup().Values.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								ActiveUnit current = enumerator2.Current;
								memberRecord = new ImportExportRecord.MemberRecord();
								memberRecord.Member_DBID = current.DBID;
								memberRecord.Member_GUID = current.GetGuid();
								switch (current.GetUnitType())
								{
								case GlobalVariables.ActiveUnitType.Aircraft:
									memberRecord.MemberType = "Aircraft";
									break;
								case GlobalVariables.ActiveUnitType.Ship:
									memberRecord.MemberType = "Ship";
									break;
								case GlobalVariables.ActiveUnitType.Submarine:
									memberRecord.MemberType = "Submarine";
									break;
								case GlobalVariables.ActiveUnitType.Facility:
									memberRecord.MemberType = "Facility";
									break;
								case GlobalVariables.ActiveUnitType.Weapon:
									memberRecord.MemberType = "Weapon";
									break;
								}
								memberRecord.Orientation = current.GetCurrentHeading();
								memberRecord.Latitude = current.GetLatitude(null);
								memberRecord.Longitude = current.GetLongitude(null);
								memberRecord.MemberName = current.Name;
								memberRecord.ParentGroupName = current.GetParentGroup(false).Name;
								this.method_3(ref current, ref memberRecord);
								importExportRecord.MemberRecords.Add(memberRecord);
							}
							continue;
						}
					}
					memberRecord = new ImportExportRecord.MemberRecord();
					memberRecord.Member_DBID = activeUnit.DBID;
					memberRecord.Member_GUID = activeUnit.GetGuid();
					switch (activeUnit.GetUnitType())
					{
					case GlobalVariables.ActiveUnitType.Aircraft:
						memberRecord.MemberType = "Aircraft";
						break;
					case GlobalVariables.ActiveUnitType.Ship:
						memberRecord.MemberType = "Ship";
						break;
					case GlobalVariables.ActiveUnitType.Submarine:
						memberRecord.MemberType = "Submarine";
						break;
					case GlobalVariables.ActiveUnitType.Facility:
						memberRecord.MemberType = "Facility";
						break;
					case GlobalVariables.ActiveUnitType.Weapon:
						memberRecord.MemberType = "Weapon";
						break;
					}
					memberRecord.Orientation = activeUnit.GetCurrentHeading();
					memberRecord.Latitude = activeUnit.GetLatitude(null);
					memberRecord.Longitude = activeUnit.GetLongitude(null);
					memberRecord.MemberName = activeUnit.Name;
					if (activeUnit.HasParentGroup())
					{
						memberRecord.ParentGroupName = activeUnit.GetParentGroup(false).Name;
					}
					if (activeUnit.GetType() == typeof(Aircraft))
					{
						if (!Information.IsNothing(((Aircraft)activeUnit).GetLoadout()))
						{
							memberRecord.LoadoutID = ((Aircraft)activeUnit).GetLoadout().DBID;
						}
						else
						{
							memberRecord.LoadoutID = 0;
						}
					}
					this.method_3(ref activeUnit, ref memberRecord);
					importExportRecord.MemberRecords.Add(memberRecord);
				}
			}
			this.vmethod_20().InitialDirectory = Application.StartupPath + "\\ImportExport";
			if (this.vmethod_20().ShowDialog() == DialogResult.OK)
			{
				StreamWriter streamWriter = new StreamWriter(this.vmethod_20().FileName);
				JsonSerializer jsonSerializer = new JsonSerializer();
				using (streamWriter)
				{
					JsonTextWriter jsonTextWriter = new JsonTextWriter(streamWriter);
					jsonTextWriter.Formatting = Formatting.Indented;
					using (jsonTextWriter)
					{
						jsonSerializer.Serialize(jsonTextWriter, importExportRecord);
					}
				}
				base.Close();
			}
			else
			{
				Interaction.MsgBox(this.vmethod_20().ShowDialog().ToString(), MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x0015A080 File Offset: 0x00158280
		private void method_3(ref ActiveUnit activeUnit_0, ref ImportExportRecord.MemberRecord memberRecord_0)
		{
			if (activeUnit_0.GetAirOps().GetHostedAircrafts().Count > 0)
			{
				foreach (Aircraft current in activeUnit_0.GetAirOps().GetHostedAircrafts())
				{
					int int_;
					if (Information.IsNothing(current.GetLoadout()))
					{
						int_ = 0;
					}
					else
					{
						int_ = current.GetLoadout().DBID;
					}
					ImportExportRecord.HostedAircraftRecord item = new ImportExportRecord.HostedAircraftRecord(current.Name, current.DBID, int_, (int)Math.Round((double)(current.GetAircraftAirOps().GetConditionTimer() / 60f)));
					memberRecord_0.HostedAircraftRecords.Add(item);
				}
			}
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void SaveGroup_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06004020 RID: 16416 RVA: 0x00004D83 File Offset: 0x00002F83
		private void SaveGroup_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x04001D69 RID: 7529
		public static Func<Unit, bool> UnitFunc = (Unit unit_0) => unit_0.IsActiveUnit();

		// Token: 0x04001D6B RID: 7531
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001D6C RID: 7532
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04001D6D RID: 7533
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04001D6E RID: 7534
		[CompilerGenerated]
		private TextBox textBox_1;

		// Token: 0x04001D6F RID: 7535
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04001D70 RID: 7536
		[CompilerGenerated]
		private TextBox textBox_2;

		// Token: 0x04001D71 RID: 7537
		[CompilerGenerated]
		private TextBox textBox_3;

		// Token: 0x04001D72 RID: 7538
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04001D73 RID: 7539
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001D74 RID: 7540
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001D75 RID: 7541
		[CompilerGenerated]
		private SaveFileDialog saveFileDialog_0;

		// Token: 0x04001D76 RID: 7542
		private ReadOnlyCollection<Unit> readOnlyCollection_0;
	}
}
