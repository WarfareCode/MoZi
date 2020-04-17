using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace ns33
{
	// Token: 0x02000CED RID: 3309
	[DesignerGenerated]
	public sealed partial class LoadScenarioAttachment : Form
	{
		// Token: 0x06006CCC RID: 27852 RVA: 0x0002E90C File Offset: 0x0002CB0C
		public LoadScenarioAttachment()
		{
			base.Shown += new EventHandler(this.LoadScenarioAttachment_Shown);
			base.Load += new EventHandler(this.LoadScenarioAttachment_Load);
			this.ScenAttachmentObjects = new List<ScenAttachmentObject>();
			this.method_0();
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x003D1410 File Offset: 0x003CF610
		private void method_0()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LoadScenarioAttachment));
			this.vmethod_1(new ToolStrip());
			this.vmethod_9(new ToolStripButton());
			this.vmethod_3(new TabPage());
			this.vmethod_5(new DataGridView());
			this.vmethod_11(new DataGridViewTextBoxColumn());
			this.vmethod_13(new DataGridViewTextBoxColumn());
			this.vmethod_15(new DataGridViewTextBoxColumn());
			this.vmethod_7(new TabControl());
			this.vmethod_0().SuspendLayout();
			this.vmethod_2().SuspendLayout();
			((ISupportInitialize)this.vmethod_4()).BeginInit();
			this.vmethod_6().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_0().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_8()
			});
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "ToolStrip1";
			this.vmethod_0().Size = new Size(845, 25);
			this.vmethod_0().TabIndex = 2;
			this.vmethod_0().Text = "ToolStrip1";
            //ZSP RUN IMG this.vmethod_8().Image = (Image)componentResourceManager.GetObject("ToolStripButton1.Image");
            this.vmethod_8().ImageTransparentColor = Color.Magenta;
			this.vmethod_8().Name = "ToolStripButton1";
			this.vmethod_8().Size = new Size(176, 22);
			this.vmethod_8().Text = "加载所选附件";
			this.vmethod_2().Controls.Add(this.vmethod_4());
			this.vmethod_2().Location = new Point(4, 22);
			this.vmethod_2().Name = "TabPage1";
			this.vmethod_2().Padding = new Padding(3);
			this.vmethod_2().Size = new Size(837, 296);
			this.vmethod_2().TabIndex = 0;
			this.vmethod_2().Text = "本地资源库";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_4().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_10(),
				this.vmethod_12(),
				this.vmethod_14()
			});
			this.vmethod_4().Dock = DockStyle.Fill;
			this.vmethod_4().Location = new Point(3, 3);
			this.vmethod_4().Name = "DataGridView1";
			this.vmethod_4().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_4().Size = new Size(831, 290);
			this.vmethod_4().TabIndex = 0;
			this.vmethod_10().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_10().HeaderText = "名称";
			this.vmethod_10().Name = "Name";
			this.vmethod_10().ReadOnly = true;
			this.vmethod_10().Width = 58;
			this.vmethod_12().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_12().HeaderText = "类型";
			this.vmethod_12().Name = "Type";
			this.vmethod_12().ReadOnly = true;
			this.vmethod_12().Width = 54;
			this.vmethod_14().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_14().HeaderText = "GUID";
			this.vmethod_14().Name = "GUID";
			this.vmethod_14().ReadOnly = true;
			this.vmethod_6().Controls.Add(this.vmethod_2());
			this.vmethod_6().Location = new Point(0, 28);
			this.vmethod_6().Name = "TabControl1";
			this.vmethod_6().SelectedIndex = 0;
			this.vmethod_6().Size = new Size(845, 322);
			this.vmethod_6().TabIndex = 1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(845, 347);
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_6());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "加载现有想定附件";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_0().PerformLayout();
			this.vmethod_2().ResumeLayout(false);
			((ISupportInitialize)this.vmethod_4()).EndInit();
			this.vmethod_6().ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06006CCF RID: 27855 RVA: 0x003D18B8 File Offset: 0x003CFAB8
		[CompilerGenerated]
		internal  ToolStrip vmethod_0()
		{
			return this.toolStrip_0;
		}

		// Token: 0x06006CD0 RID: 27856 RVA: 0x0002E949 File Offset: 0x0002CB49
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ToolStrip toolStrip_1)
		{
			this.toolStrip_0 = toolStrip_1;
		}

		// Token: 0x06006CD1 RID: 27857 RVA: 0x003D18D0 File Offset: 0x003CFAD0
		[CompilerGenerated]
		internal  TabPage vmethod_2()
		{
			return this.tabPage_0;
		}

		// Token: 0x06006CD2 RID: 27858 RVA: 0x0002E952 File Offset: 0x0002CB52
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TabPage tabPage_1)
		{
			this.tabPage_0 = tabPage_1;
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x003D18E8 File Offset: 0x003CFAE8
		[CompilerGenerated]
		internal  DataGridView vmethod_4()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x0002E95B File Offset: 0x0002CB5B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(DataGridView dataGridView_1)
		{
			this.dataGridView_0 = dataGridView_1;
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x003D1900 File Offset: 0x003CFB00
		[CompilerGenerated]
		internal  TabControl vmethod_6()
		{
			return this.tabControl_0;
		}

		// Token: 0x06006CD6 RID: 27862 RVA: 0x0002E964 File Offset: 0x0002CB64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TabControl tabControl_1)
		{
			this.tabControl_0 = tabControl_1;
		}

		// Token: 0x06006CD7 RID: 27863 RVA: 0x003D1918 File Offset: 0x003CFB18
		[CompilerGenerated]
		internal  ToolStripButton vmethod_8()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x003D1930 File Offset: 0x003CFB30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripButton toolStripButton_1)
		{
			EventHandler value = new EventHandler(this.method_2);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_1;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x003D197C File Offset: 0x003CFB7C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_10()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06006CDA RID: 27866 RVA: 0x0002E96D File Offset: 0x0002CB6D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x003D1994 File Offset: 0x003CFB94
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_12()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x0002E976 File Offset: 0x0002CB76
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06006CDD RID: 27869 RVA: 0x003D19AC File Offset: 0x003CFBAC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_14()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x0002E97F File Offset: 0x0002CB7F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x0002E988 File Offset: 0x0002CB88
		private void LoadScenarioAttachment_Shown(object sender, EventArgs e)
		{
			this.ScenAttachmentObjects.Clear();
			this.method_1();
		}

		// Token: 0x06006CE0 RID: 27872 RVA: 0x003D19C4 File Offset: 0x003CFBC4
		public void method_1()
		{
			List<ScenAttachmentObject> list = new List<ScenAttachmentObject>();
			string[] directories = Directory.GetDirectories(GameGeneral.strAttachmentRepoDir);
			checked
			{
				for (int i = 0; i < directories.Length; i++)
				{
					ScenAttachmentObject item = ScenAttachmentObject.smethod_1(directories[i]);
					list.Add(item);
				}
				this.vmethod_4().SuspendLayout();
				this.vmethod_4().Rows.Clear();
				foreach (ScenAttachmentObject current in list)
				{
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					dataGridViewRow.CreateCells(this.vmethod_4());
					dataGridViewRow.Cells[0].Value = current.method_1();
					dataGridViewRow.Cells[1].Value = current.attachmentObjectType_0.ToString();
					dataGridViewRow.Cells[2].Value = current.method_0();
					dataGridViewRow.Tag = current;
					this.vmethod_4().Rows.Add(dataGridViewRow);
				}
				this.vmethod_4().ResumeLayout();
			}
		}

		// Token: 0x06006CE1 RID: 27873 RVA: 0x003D1AF0 File Offset: 0x003CFCF0
		private void method_2(object sender, EventArgs e)
		{
			if (this.vmethod_4().SelectedRows.Count != 0)
			{
				IEnumerator enumerator = this.vmethod_4().SelectedRows.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ScenAttachmentObject item = (ScenAttachmentObject)NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator.Current), null, "tag", new object[0], null, null, null);
						this.ScenAttachmentObjects.Add(item);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
		}

		// Token: 0x06006CE2 RID: 27874 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void LoadScenarioAttachment_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04003EBA RID: 16058
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x04003EBB RID: 16059
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x04003EBC RID: 16060
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04003EBD RID: 16061
		[CompilerGenerated]
		private TabControl tabControl_0;

		// Token: 0x04003EBE RID: 16062
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04003EBF RID: 16063
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04003EC0 RID: 16064
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04003EC1 RID: 16065
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04003EC2 RID: 16066
		public List<ScenAttachmentObject> ScenAttachmentObjects;
	}
}
