using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace ns34
{
	// 目标报告窗体
	[DesignerGenerated]
	public sealed partial class ContactReport : CommandForm
	{
		// Token: 0x060052DF RID: 21215 RVA: 0x0021DF9C File Offset: 0x0021C19C
		public ContactReport()
		{
			base.Shown += new EventHandler(this.ContactReport_Shown);
			base.KeyDown += new KeyEventHandler(this.ContactReport_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.ContactReport_FormClosing);
			base.Load += new EventHandler(this.ContactReport_Load);
			this.InitializeComponent();
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x0021E7C0 File Offset: 0x0021C9C0
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x00026867 File Offset: 0x00024A67
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_5)
		{
			this.label_0 = label_5;
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x0021E7D8 File Offset: 0x0021C9D8
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_1;
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x00026870 File Offset: 0x00024A70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_5)
		{
			this.label_1 = label_5;
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x0021E7F0 File Offset: 0x0021C9F0
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_2;
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x00026879 File Offset: 0x00024A79
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_5)
		{
			this.label_2 = label_5;
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x0021E808 File Offset: 0x0021CA08
		[CompilerGenerated]
		internal  ListBox vmethod_6()
		{
			return this.listBox_0;
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x00026882 File Offset: 0x00024A82
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ListBox listBox_2)
		{
			this.listBox_0 = listBox_2;
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x0021E820 File Offset: 0x0021CA20
		[CompilerGenerated]
		internal  ListBox vmethod_8()
		{
			return this.listBox_1;
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x0021E838 File Offset: 0x0021CA38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ListBox listBox_2)
		{
			EventHandler value = new EventHandler(this.method_1);
			ListBox listBox = this.listBox_1;
			if (listBox != null)
			{
				listBox.DoubleClick -= value;
			}
			this.listBox_1 = listBox_2;
			listBox = this.listBox_1;
			if (listBox != null)
			{
				listBox.DoubleClick += value;
			}
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x0021E884 File Offset: 0x0021CA84
		[CompilerGenerated]
		internal  Label vmethod_10()
		{
			return this.label_3;
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x0002688B File Offset: 0x00024A8B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Label label_5)
		{
			this.label_3 = label_5;
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x0021E89C File Offset: 0x0021CA9C
		[CompilerGenerated]
		internal  TabControl vmethod_12()
		{
			return this.tabControl_0;
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x0021E8B4 File Offset: 0x0021CAB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(TabControl tabControl_1)
		{
			EventHandler value = new EventHandler(this.method_4);
			TabControl tabControl = this.tabControl_0;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged -= value;
			}
			this.tabControl_0 = tabControl_1;
			tabControl = this.tabControl_0;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged += value;
			}
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x0021E900 File Offset: 0x0021CB00
		[CompilerGenerated]
		internal  TabPage vmethod_14()
		{
			return this.tabPage_0;
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x00026894 File Offset: 0x00024A94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(TabPage tabPage_2)
		{
			this.tabPage_0 = tabPage_2;
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x0021E918 File Offset: 0x0021CB18
		[CompilerGenerated]
		internal  TabPage vmethod_16()
		{
			return this.tabPage_1;
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x0002689D File Offset: 0x00024A9D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(TabPage tabPage_2)
		{
			this.tabPage_1 = tabPage_2;
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x0021E930 File Offset: 0x0021CB30
		[CompilerGenerated]
		internal  Label vmethod_18()
		{
			return this.label_4;
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x000268A6 File Offset: 0x00024AA6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_5)
		{
			this.label_4 = label_5;
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x0021E948 File Offset: 0x0021CB48
		[CompilerGenerated]
		internal  SplitContainer vmethod_20()
		{
			return this.splitContainer_0;
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x000268AF File Offset: 0x00024AAF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(SplitContainer splitContainer_1)
		{
			this.splitContainer_0 = splitContainer_1;
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x0021E960 File Offset: 0x0021CB60
		private void method_1(object sender, EventArgs e)
		{
			string activeUnitTypeString = Misc.GetActiveUnitTypeString(this.activeUnitType);
			int dBID = Conversions.ToInteger(this.vmethod_8().SelectedValue);
			Client.ShowDBInfo(activeUnitTypeString, dBID);
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x0021E994 File Offset: 0x0021CB94
		private void method_2()
		{
			this.Text = "探测目标报告: " + this.contact.Name;
			if (!Information.IsNothing(this.contact.ActualUnit))
			{
				switch (this.contact.GetIdentificationStatus())
				{
				case Contact_Base.IdentificationStatus.Unknown:
				case Contact_Base.IdentificationStatus.KnownDomain:
					this.vmethod_0().Text = "类型: 不明";
					break;
				case Contact_Base.IdentificationStatus.KnownType:
					this.vmethod_0().Text = "类型: " + this.contact.ActualUnit.GetUnitTypeDescription();
					break;
				case Contact_Base.IdentificationStatus.KnownClass:
					this.vmethod_0().Text = "型号: " + this.contact.ActualUnit.UnitClass;
					break;
				case Contact_Base.IdentificationStatus.PreciseID:
					this.vmethod_0().Text = "识别结果: " + this.contact.ActualUnit.Name;
					break;
				}
			}
			this.vmethod_6().Items.Clear();
			this.vmethod_8().Items.Clear();
			if (!this.contact.HasEmissionContainer())
			{
				this.vmethod_6().Enabled = false;
				this.vmethod_2().Text = "没有探测到电磁辐射";
			}
			else
			{
				List<int> list = this.contact.GetEmissionContainerObDictionary().Keys.ToList<int>();
				int num = 0;
				if (this.contact.GetEmissionContainerObDictionary().Count > 0)
				{
					this.vmethod_6().Enabled = true;
					List<int>.Enumerator enumerator = list.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current = enumerator.Current;
							EmissionContainer emissionContainer = this.contact.GetEmissionContainerObDictionary()[current];
							string str = emissionContainer.method_1(current, Client.GetClientScenario());
							this.vmethod_6().Items.Add(str + " (Last: " + Misc.GetTimeString((long)Math.Round((double)emissionContainer.elapsedTime), Aircraft_AirOps._Maintenance.const_0, false, true) + " ago)");
							if (emissionContainer.bool_1)
							{
								num++;
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
					this.vmethod_2().Text = "探测到电磁辐射(辐射源：" + Conversions.ToString(num) + "):";
				}
				else
				{
					this.vmethod_6().Enabled = false;
					this.vmethod_2().Text = "没有探测到电磁辐射";
				}
				if (num == 0)
				{
					this.vmethod_8().Enabled = false;
					this.vmethod_4().Text = "没法确定辐射源 - 不能缩小可能匹配结果";
				}
				else
				{
					this.vmethod_4().Text = "可能匹配结果:";
					DataTable table = null;
					switch (this.contact.contactType)
					{
					case Contact_Base.ContactType.Air:
						this.activeUnitType = GlobalVariables.ActiveUnitType.Aircraft;
						table = DBFunctions.GetAircraftDataTable(Client.GetClientScenario().GetSQLiteConnection());
						break;
					case Contact_Base.ContactType.Missile:
					case Contact_Base.ContactType.Torpedo:
						this.activeUnitType = GlobalVariables.ActiveUnitType.Weapon;
						table = DBFunctions.GetWeaponsDataTable(Client.GetClientScenario().GetSQLiteConnection());
						break;
					case Contact_Base.ContactType.Surface:
						this.activeUnitType = GlobalVariables.ActiveUnitType.Ship;
						table = DBFunctions.GetShipDataTable(Client.GetClientScenario().GetSQLiteConnection());
						break;
					case Contact_Base.ContactType.Submarine:
						this.activeUnitType = GlobalVariables.ActiveUnitType.Submarine;
						table = DBFunctions.GetSubmarineDataTable(Client.GetClientScenario().GetSQLiteConnection());
						break;
					case Contact_Base.ContactType.Orbital:
						this.activeUnitType = GlobalVariables.ActiveUnitType.Satellite;
						table = DBFunctions.GetSatelliteDataTable(Client.GetClientScenario().GetSQLiteConnection());
						break;
					case Contact_Base.ContactType.Facility_Fixed:
					case Contact_Base.ContactType.Facility_Mobile:
						this.activeUnitType = GlobalVariables.ActiveUnitType.Facility;
						table = DBFunctions.GetFacilityDataTable(Client.GetClientScenario().GetSQLiteConnection());
						break;
					}
					List<int> list2 = this.contact.method_62();
					if (list2.Count > 0)
					{
						StringBuilder stringBuilder = new StringBuilder();
						int arg_394_0 = list2.Count;
						stringBuilder.Append("(" + string.Join<int>(",", list2) + ")");
						DataView dataView = new DataView(table);
						dataView.RowFilter = "ID IN " + stringBuilder.ToString();
						dataView.Sort = "LongName ASC";
						this.vmethod_8().Enabled = true;
						this.vmethod_8().DisplayMember = "LongName";
						this.vmethod_8().ValueMember = "ID";
						this.vmethod_8().DataSource = dataView;
						this.vmethod_8().Refresh();
					}
					else
					{
						this.vmethod_8().Enabled = false;
					}
				}
			}
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x0021EDE8 File Offset: 0x0021CFE8
		private void method_3()
		{
            List<string> list;
            if (this.contact.GetRadiationHostUnits(Client.GetClientSide()).Count <= 0)
            {
                this.vmethod_18().Text = "无法识别出辐射源平台.";
                return;
            }
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            List<Contact.HostUnitOfRadarRadiation>.Enumerator enumerator = this.contact.GetRadiationHostUnits(Client.GetClientSide()).GetEnumerator();
            try
            {
                Dictionary<string, int> dictionary2;
                string str2;
            Label_003D:
                if (!enumerator.MoveNext())
                {
                    goto Label_0304;
                }
                Contact.HostUnitOfRadarRadiation current = enumerator.Current;
                string key = "";
                switch (current.identificationStatus)
                {
                    case Contact_Base.IdentificationStatus.Unknown:
                        key = "不明作战单元";
                        goto Label_028E;

                    case Contact_Base.IdentificationStatus.KnownDomain:
                        try
                        {
                            ActiveUnit unit = Client.GetClientScenario().GetActiveUnits()[current.UID];
                            key = Misc.GetTargetVisualSizeClassString(unit.GetTargetVisualSizeClass()) + " " + unit.GetUnitTypeName();
                        }
                        catch (Exception exception)
                        {
                            ProjectData.SetProjectError(exception);
                            Exception exception2 = exception;
                            exception2.Data.Add("Error at 2004309864397687", exception2.Message);
                            GameGeneral.LogException(ref exception2);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            key = "不明作战单元";
                            ProjectData.ClearProjectError();
                        }
                        goto Label_028E;

                    case Contact_Base.IdentificationStatus.KnownType:
                        try
                        {
                            ActiveUnit unit2 = Client.GetClientScenario().GetActiveUnits()[current.UID];
                            key = Misc.GetTargetVisualSizeClassString(unit2.GetTargetVisualSizeClass()) + " " + unit2.GetUnitTypeDescription();
                        }
                        catch (Exception exception3)
                        {
                            ProjectData.SetProjectError(exception3);
                            Exception exception4 = exception3;
                            exception4.Data.Add("Error at 200409", exception4.Message);
                            GameGeneral.LogException(ref exception4);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            key = "不明作战单元";
                            ProjectData.ClearProjectError();
                        }
                        goto Label_028E;

                    case Contact_Base.IdentificationStatus.KnownClass:
                        try
                        {
                            key = Client.GetClientScenario().GetActiveUnits()[current.UID].UnitClass;
                        }
                        catch (Exception exception5)
                        {
                            ProjectData.SetProjectError(exception5);
                            Exception exception6 = exception5;
                            exception6.Data.Add("Error at 200410", exception6.Message);
                            GameGeneral.LogException(ref exception6);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            key = "不明作战单元";
                            ProjectData.ClearProjectError();
                        }
                        goto Label_028E;

                    case Contact_Base.IdentificationStatus.PreciseID:
                        try
                        {
                            key = Client.GetClientScenario().GetActiveUnits()[current.UID].Name;
                        }
                        catch (Exception exception7)
                        {
                            ProjectData.SetProjectError(exception7);
                            Exception exception8 = exception7;
                            exception8.Data.Add("Error at 200411", exception8.Message);
                            GameGeneral.LogException(ref exception8);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            key = "不明作战单元";
                            ProjectData.ClearProjectError();
                        }
                        goto Label_028E;

                    default:
                        goto Label_028E;
                }
            Label_0264:
                (dictionary2 = dictionary)[str2 = key] = dictionary2[str2] + 1;
                goto Label_003D;
            Label_0281:
                dictionary.Add(key, 1);
                goto Label_003D;
            Label_028E:
                key = Conversions.ToString(Operators.ConcatenateObject(key + " (最后侦察: ", Interaction.IIf(current.RA > 0f, Misc.GetTimeString((long)Math.Round((double)current.RA), Aircraft_AirOps._Maintenance.const_0, false, true) + " ago)", "Now)")));
                if (!dictionary.ContainsKey(key))
                {
                    goto Label_0281;
                }
                goto Label_0264;
            }
            finally
            {
                IDisposable disposable = enumerator;
                if (disposable != null)
                {
                    disposable.Dispose();
                }
            }
        Label_0304:
            list = new List<string>();
            foreach (KeyValuePair<string, int> pair in dictionary)
            {
                list.Add(Conversions.ToString(pair.Value) + "x " + pair.Key);
            }
            this.vmethod_18().Text = string.Join("\r\n", list);

        }

        // Token: 0x060052FB RID: 21243 RVA: 0x000268B8 File Offset: 0x00024AB8
        private void ContactReport_Shown(object sender, EventArgs e)
		{
			this.method_2();
			this.method_3();
			this.vmethod_12().SelectedIndex = Client.int_3;
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x000200A8 File Offset: 0x0001E2A8
		private void ContactReport_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x00004D83 File Offset: 0x00002F83
		private void ContactReport_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x000268D6 File Offset: 0x00024AD6
		private void method_4(object sender, EventArgs e)
		{
			Client.int_3 = this.vmethod_12().SelectedIndex;
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void ContactReport_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x040026DD RID: 9949
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x040026DE RID: 9950
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x040026DF RID: 9951
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x040026E0 RID: 9952
		[CompilerGenerated]
		private ListBox listBox_0;

		// Token: 0x040026E1 RID: 9953
		[CompilerGenerated]
		private ListBox listBox_1;

		// Token: 0x040026E2 RID: 9954
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x040026E3 RID: 9955
		[CompilerGenerated]
		private TabControl tabControl_0;

		// Token: 0x040026E4 RID: 9956
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x040026E5 RID: 9957
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x040026E6 RID: 9958
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x040026E7 RID: 9959
		[CompilerGenerated]
		private SplitContainer splitContainer_0;

		// Token: 0x040026E8 RID: 9960
		public Contact contact;

		// Token: 0x040026E9 RID: 9961
		private GlobalVariables.ActiveUnitType activeUnitType;
	}
}
