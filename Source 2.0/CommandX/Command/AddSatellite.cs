using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace Command
{
	// 添加卫星窗体
	[DesignerGenerated]
	public sealed partial class AddSatellite : CommandForm
	{
		// Token: 0x06005157 RID: 20823 RVA: 0x00213348 File Offset: 0x00211548
		public AddSatellite()
		{
			base.Load += new EventHandler(this.AddSatellite_Load);
			base.KeyDown += new KeyEventHandler(this.AddSatellite_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.AddSatellite_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x00004D83 File Offset: 0x00002F83
		private void AddSatellite_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x00213398 File Offset: 0x00211598
		private void AddSatellite_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (!base.Visible || (e.KeyCode != Keys.Space && e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract))
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x0021340C File Offset: 0x0021160C
		private void AddSatellite_Load(object sender, EventArgs e)
		{
			List<string>.Enumerator enumerator = default(List<string>.Enumerator);
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.treeView_0.Nodes.Clear();
			IEnumerable<object> source = Client.GetClientScenario().Cache_Satellites_DT.Rows.Cast<object>();
			List<string> list = source.Select(AddSatellite.objectFunc0).Distinct<string>().ToList<string>();
			try
			{
				enumerator = list.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					TreeNode treeNode = new TreeNode(current)
					{
						Tag = "Country_" + current
					};
					this.treeView_0.Nodes.Add(treeNode);
					this.addTreeNode(treeNode);
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
		}

		// Token: 0x0600515D RID: 20829 RVA: 0x00213764 File Offset: 0x00211964
//		[CompilerGenerated]
//		internal  TreeView vmethod_0()
//		{
//			return this.treeView_0;
//		}

		// Token: 0x0600515E RID: 20830 RVA: 0x0021377C File Offset: 0x0021197C
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_1(TreeView treeView_1)
//		{
//			TreeViewCancelEventHandler value = new TreeViewCancelEventHandler(this.method_2);
//			TreeNodeMouseClickEventHandler value2 = new TreeNodeMouseClickEventHandler(this.method_5);
//			TreeView treeView = this.treeView_0;
//			if (treeView != null)
//			{
//				treeView.BeforeExpand -= value;
//				treeView.NodeMouseClick -= value2;
//			}
//			this.treeView_0 = treeView_1;
//			treeView = this.treeView_0;
//			if (treeView != null)
//			{
//				treeView.BeforeExpand += value;
//				treeView.NodeMouseClick += value2;
//			}
//		}

		// Token: 0x0600515F RID: 20831 RVA: 0x002137E0 File Offset: 0x002119E0
//		[CompilerGenerated]
//		internal  Button vmethod_2()
//		{
//			return this.button_0;
//		}

		// Token: 0x06005160 RID: 20832 RVA: 0x002137F8 File Offset: 0x002119F8
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_3(Button button_1)
//		{
//			EventHandler value = new EventHandler(this.method_3);
//			Button button = this.button_0;
//			if (button != null)
//			{
//				button.Click -= value;
//			}
//			this.button_0 = button_1;
//			button = this.button_0;
//			if (button != null)
//			{
//				button.Click += value;
//			}
//		}

		// Token: 0x06005161 RID: 20833 RVA: 0x00213844 File Offset: 0x00211A44
//		[CompilerGenerated]
//		internal  Label vmethod_4()
//		{
//			return this.label_0;
//		}

		// Token: 0x06005162 RID: 20834 RVA: 0x00026036 File Offset: 0x00024236
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_5(Label label_1)
//		{
//			this.label_0 = label_1;
//		}

        // Token: 0x06005163 RID: 20835 RVA: 0x0021385C File Offset: 0x00211A5C
        public void addTreeNode(TreeNode treeNode_0)
        {
            string text = Conversions.ToString(treeNode_0.Tag);
            string left = text.Split(new char[]
            {
                '_'
            })[0];

            if (Operators.CompareString(left, "Country", false) != 0)
            {
                if (Operators.CompareString(left, "Type", false) != 0)
                {
                    if (Operators.CompareString(left, "SatClass", false) != 0)
                    {
                        return;
                    }
                    DataTable satelliteOrbitsDataTable = DBFunctions.GetSatelliteOrbitsDataTable(Conversions.ToInteger(text.Split(new char[]
                    {
                        '_'
                    })[1]), Client.GetClientScenario().GetSQLiteConnection());
                    IEnumerator enumerator = satelliteOrbitsDataTable.Rows.GetEnumerator();

                    try
                    {
                        while (enumerator.MoveNext())
                        {
                            DataRow dataRow = (DataRow)enumerator.Current;
                            TreeNode treeNode = new TreeNode(Conversions.ToString(dataRow["MissonName"]));
                            DateTime dateTime = Conversions.ToDate(dataRow["LaunchDate"]);
                            DateTime t = Conversions.ToDate(dataRow["DeOrbitingDate"]);
                            if (DateTime.Compare(t, Client.GetClientScenario().GetCurrentTime(false)) < 0 && DateTime.Compare(t, new DateTime(1900, 1, 1)) > 0)
                            {
                                treeNode.ForeColor = Color.Gray;
                                treeNode.Text = Conversions.ToString(Operators.ConcatenateObject(dataRow["MissonName"], " (unavailable - already de-orbited)"));
                            }
                            else if (DateTime.Compare(dateTime, Client.GetClientScenario().GetCurrentTime(false)) < 0)
                            {
                                treeNode.Text = Conversions.ToString(Operators.ConcatenateObject(dataRow["MissonName"], " (in orbit)"));
                            }
                            else
                            {
                                TimeSpan timeSpan = dateTime - Client.GetClientScenario().GetCurrentTime(false);
                                treeNode.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["MissonName"], " (will launch in "), Misc.GetTimeString((long)Math.Round(timeSpan.TotalSeconds), Aircraft_AirOps._Maintenance.const_0, false, false)), ")"));
                            }
                            treeNode.Tag = "Spacecraft_" + dataRow["ID"].ToString() + "_" + dataRow["ComponentNumber"].ToString();
                            treeNode_0.Nodes.Add(treeNode);
                            this.addTreeNode(treeNode);
                        }
                        return;
                    }
                    finally
                    {
                        if (enumerator is IDisposable)
                        {
                            (enumerator as IDisposable).Dispose();
                        }
                    }
                }

                this.string_1 = text.Split(new char[]
                 {
                    '_'
                 })[1];

                IEnumerable<object> sourcex = Client.GetClientScenario().Cache_Satellites_DT.Rows.Cast<object>();

                List<string> listName = sourcex.Where(new Func<object, bool>(this.method_8)).Select(AddSatellite.objectFuncName).Distinct<string>().ToList<string>();
                List<string> listID = sourcex.Where(new Func<object, bool>(this.method_8)).Select(AddSatellite.objectFuncID).Distinct<string>().ToList<string>();



                for (int i = 0; i < listName.Count; i++)
                {
                    TreeNode treeNode2 = new TreeNode(listName[i]);
                    treeNode2.Tag = "SatClass_" + listID[i];
                    treeNode_0.Nodes.Add(treeNode2);
                    this.addTreeNode(treeNode2);

                }

                 
            }

            if (Operators.CompareString(left, "Country", false) == 0)
            {
                this.string_0 = text.Split(new char[]
                {
                    '_'
                })[1];

                IEnumerable<object> source = Client.GetClientScenario().Cache_Satellites_DT.Rows.Cast<object>();

                List<string> list = source.Where(new Func<object, bool>(this.method_CountryString)).Select(AddSatellite.objectFunc1).OrderBy(AddSatellite.stringFunc2).Distinct<string>().ToList<string>();
                foreach (string current in list)
                {
                    TreeNode treeNode2 = new TreeNode(current);
                    treeNode2.Tag = "Type_" + current;
                    treeNode_0.Nodes.Add(treeNode2);
                    this.addTreeNode(treeNode2);
                }
            }
        }

		// Token: 0x06005164 RID: 20836 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_2(object sender, TreeViewCancelEventArgs e)
		{
		}

		// Token: 0x06005165 RID: 20837 RVA: 0x00213BD8 File Offset: 0x00211DD8
		private void method_3(object sender, EventArgs e)
		{
			List<TreeNode>.Enumerator enumerator = default(List<TreeNode>.Enumerator);
			bool flag = false;
			List<ActiveUnit>.Enumerator enumerator2 = default(List<ActiveUnit>.Enumerator);
			List<TreeNode> list = new List<TreeNode>();
			this.method_4(this.treeView_0.Nodes, ref list);
			int num = 0;
			try
			{
				enumerator = list.GetEnumerator();
				while (enumerator.MoveNext())
				{
					TreeNode current = enumerator.Current;
					string text = Conversions.ToString(current.Tag);
					if (!Information.IsNothing(text) && (Operators.CompareString(text.Split(new char[]
					{
						'_'
					})[0], "Spacecraft", false) == 0 && !(current.ForeColor == Color.Gray)))
					{
						string text2 = text.Split(new char[]
						{
							'_'
						})[1] + "_" + text.Split(new char[]
						{
							'_'
						})[2];
						try
						{
							enumerator2 = Client.GetClientScenario().GetActiveUnitList().GetEnumerator();
							while (enumerator2.MoveNext())
							{
								ActiveUnit current2 = enumerator2.Current;
								if (current2.IsSatellite() && string.CompareOrdinal(((Satellite)current2).SID, text2) == 0)
								{
									flag = true;
									break;
								}
							}
							goto IL_19E;
						}
						finally
						{
							((IDisposable)enumerator2).Dispose();
						}
						IL_13B:
						Client.GetClientScenario().AddSatellite(Client.GetClientSide(), "", Conversions.ToInteger(text.Split(new char[]
						{
							'_'
						})[1]), Conversions.ToInteger(text.Split(new char[]
						{
							'_'
						})[2]), null).SID = text2;
						num++;
						continue;
						IL_19E:
						if (!flag)
						{
							goto IL_13B;
						}
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
			if (num > 0)
			{
				this.label_0.Visible = true;
				this.label_0.Text = Conversions.ToString(num) + " satellites were added to the scenario.";
				Client.b_Completed = true;
			}
		}

		// Token: 0x06005166 RID: 20838 RVA: 0x00213E14 File Offset: 0x00212014
		private void method_4(TreeNodeCollection treeNodeCollections, ref List<TreeNode> listPointers)
		{
			IEnumerator enumerator = null;
			try
			{
				enumerator = treeNodeCollections.GetEnumerator();
				while (enumerator.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator.Current;
					if (treeNode.Checked)
					{
						listPointers.Add(treeNode);
					}
					this.method_4(treeNode.Nodes, ref listPointers);
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

		// Token: 0x06005167 RID: 20839 RVA: 0x0002603F File Offset: 0x0002423F
		private void method_5(object sender, TreeNodeMouseClickEventArgs e)
		{
			this.method_6(e.Node);
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x00213E8C File Offset: 0x0021208C
		public void method_6(TreeNode treeNode)
		{
			IEnumerator enumerator = null;
			try
			{
				enumerator = treeNode.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					TreeNode treeNode2 = (TreeNode)enumerator.Current;
					treeNode2.Checked = treeNode.Checked;
					this.method_6(treeNode2);
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

		// Token: 0x06005169 RID: 20841 RVA: 0x00213EFC File Offset: 0x002120FC
		[CompilerGenerated]
		private bool method_CountryString(object object_0)
		{
			return Operators.CompareString(Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
			{
				"CountryString"
			}, null)), this.string_0, false) == 0;
		}

        private bool method_TypeString(object object_0)
        {
            return Operators.CompareString(Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
            {
                "TypeString"
            }, null)), this.string_1, false) == 0;
        }

        // Token: 0x0600516A RID: 20842 RVA: 0x00213F34 File Offset: 0x00212134
        [CompilerGenerated]
		private bool method_8(object object_0)
		{
			return Operators.CompareString(Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
			{
				"TypeString"
			}, null)), this.string_1, false) == 0 & Operators.CompareString(Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
			{
				"CountryString"
			}, null)), this.string_0, false) == 0;
		}

		// Token: 0x0400263A RID: 9786
		public static Func<object, string> objectFunc0 = (object object_0) => Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
		{
			"CountryString"
		}, null));

		// Token: 0x0400263B RID: 9787
		public static Func<object, string> objectFunc1 = (object object_0) => Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
		{
			"TypeString"
		}, null));

        // Token: 0x0400263B RID: 9787
        public static Func<object, string> objectFuncName = (object object_0) => Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
        {
            "Name"
        }, null));

        // Token: 0x0400263B RID: 9787
        public static Func<object, string> objectFuncID = (object object_0) =>  Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
        {
            "ID"
        }, null));

        // Token: 0x0400263B RID: 9787

        public static Dictionary<string, int> method_GetDictionary(object object_0)
        {
            string str = Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[] { "Name" }, null));
            int intstr = Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[] { "ID" }, null));
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add(str, intstr);
            //dictionary.Keys = str;
            return dictionary;
        }

       

        // Token: 0x0400263C RID: 9788
        public static Func<string, string> stringFunc2 = (string string_0) => string_0;

		// Token: 0x0400263E RID: 9790
		[CompilerGenerated]
		private TreeView treeView_0;

		// Token: 0x0400263F RID: 9791
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04002640 RID: 9792
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04002641 RID: 9793
		private string string_0;

		// Token: 0x04002642 RID: 9794
		private string string_1;

        private void InitializeComponent()
        {
            this.treeView_0 = new TreeView();this.treeView_0.BeforeExpand += new TreeViewCancelEventHandler(this.method_2);this.treeView_0.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.method_5);
            this.button_0 = new Button();this.button_0.Click += new EventHandler(this.method_3);
            this.label_0 = new Label();
            base.SuspendLayout();
            this.treeView_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.treeView_0.CheckBoxes = true;
            this.treeView_0.Location = new Point(3, 3);
            this.treeView_0.Name = "TreeView1";
            this.treeView_0.Size = new Size(361, 458);
            this.treeView_0.TabIndex = 0;
            this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.button_0.Location = new Point(3, 467);
            this.button_0.Name = "Button1";
            this.button_0.Size = new Size(114, 23);
            this.button_0.TabIndex = 1;
            this.button_0.Text = "添加选择卫星";
            this.button_0.UseVisualStyleBackColor = true;
            this.label_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(123, 474);
            this.label_0.Name = "Label1";
            this.label_0.Size = new Size(39, 13);
            this.label_0.TabIndex = 2;
            this.label_0.Text = "Label1";
            this.label_0.Visible = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(367, 496);
            base.Controls.Add(this.label_0);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.treeView_0);
            base.KeyPreview = true;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "AddSatellite";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "添加卫星";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}
