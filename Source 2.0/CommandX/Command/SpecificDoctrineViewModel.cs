using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Command_Core;
using ns35;
using ns4;

namespace Command
{
	// Token: 0x02000840 RID: 2112
	[Attribute0, Attribute2, Attribute3]
	public sealed class SpecificDoctrineViewModel : INotifyPropertyChanged
	{
		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06003401 RID: 13313 RVA: 0x0011A9CC File Offset: 0x00118BCC
		// (remove) Token: 0x06003402 RID: 13314 RVA: 0x0011AA08 File Offset: 0x00118C08
		public event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06003403 RID: 13315 RVA: 0x0011AA44 File Offset: 0x00118C44
		// (set) Token: 0x06003404 RID: 13316 RVA: 0x0001BC98 File Offset: 0x00019E98
		public Class2535 SelectionChangedCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2535_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2535_0 != value)
				{
					this.class2535_0 = value;
					this.vmethod_0("SelectionChangedCommand");
				}
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06003405 RID: 13317 RVA: 0x0011AA5C File Offset: 0x00118C5C
		// (set) Token: 0x06003406 RID: 13318 RVA: 0x0001BCBA File Offset: 0x00019EBA
		public DataTable DataTable
		{
			[CompilerGenerated]
			get
			{
				return this.dataTable_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTable_0 != value)
				{
					this.dataTable_0 = value;
					this.vmethod_0("DataTable");
				}
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06003407 RID: 13319 RVA: 0x0011AA74 File Offset: 0x00118C74
		// (set) Token: 0x06003408 RID: 13320 RVA: 0x0001BCDC File Offset: 0x00019EDC
		public int SelectedIndex
		{
			[CompilerGenerated]
			get
			{
				return this.int_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_0 != value)
				{
					this.int_0 = value;
					this.vmethod_0("SelectedIndex");
				}
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06003409 RID: 13321 RVA: 0x0001BCFE File Offset: 0x00019EFE
		// (set) Token: 0x0600340A RID: 13322 RVA: 0x0001BD06 File Offset: 0x00019F06
		public bool IsEnabled
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.bool_0 != value)
				{
					this.bool_0 = value;
					this.vmethod_0("IsEnabled");
				}
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x0600340B RID: 13323 RVA: 0x0011AA8C File Offset: 0x00118C8C
		// (set) Token: 0x0600340C RID: 13324 RVA: 0x0001BD28 File Offset: 0x00019F28
		public string DoctrineName
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.string_0, value, StringComparison.Ordinal))
				{
					this.string_0 = value;
					this.vmethod_0("DoctrineName");
				}
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x0600340D RID: 13325 RVA: 0x0011AAA4 File Offset: 0x00118CA4
		// (set) Token: 0x0600340E RID: 13326 RVA: 0x0001BD4E File Offset: 0x00019F4E
		public string DoctrineGroup
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.string_1, value, StringComparison.Ordinal))
				{
					this.string_1 = value;
					this.vmethod_0("DoctrineGroup");
				}
			}
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x0011AABC File Offset: 0x00118CBC
		public SpecificDoctrineViewModel(string doctrineName, string doctrineGroup, Action<Doctrine, ComboBox, Scenario> PopulateAction, Action<Doctrine, ComboBox, Scenario> SelectionChangedAction, Func<Doctrine, Scenario, bool> PlayerEditableFunc)
		{
			this.SelectionChangedCommand = new Class2535(new Action<object>(this.method_0));
			this.DoctrineName = doctrineName;
			this.DoctrineGroup = doctrineGroup;
			this.action_0 = PopulateAction;
			this.action_1 = SelectionChangedAction;
			this.func_0 = PlayerEditableFunc;
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x0011AB0C File Offset: 0x00118D0C
		[Attribute0, Attribute2]
		public void SelectionChanged()
		{
			if (this.theUnit != null && this.comboBox_0 != null && Client.GetClientScenario() != null && this.theUnit.m_Doctrine != null)
			{
				this.comboBox_0.SelectedIndex = this.SelectedIndex;
				this.action_1(this.theUnit.m_Doctrine, this.comboBox_0, Client.GetClientScenario());
			}
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x0011AB78 File Offset: 0x00118D78
		[Attribute0, Attribute2]
		public void Refresh()
		{
			if (this.theUnit != null)
			{
				if (this.comboBox_0 == null)
				{
					this.comboBox_0 = new ComboBox();
					int num = 1;
					do
					{
						this.comboBox_0.Items.Add("Dummy");
						num++;
					}
					while (num <= 25);
				}
				int num2 = 5;
				do
				{
					num2--;
					if (num2 < 0)
					{
						break;
					}
					this.action_0(this.theUnit.m_Doctrine, this.comboBox_0, Client.GetClientScenario());
					this.DataTable = (DataTable)this.comboBox_0.DataSource;
					this.SelectedIndex = this.comboBox_0.SelectedIndex;
				}
				while (this.SelectedIndex == -1);
				this.IsEnabled = this.func_0(this.theUnit.m_Doctrine, Client.GetClientScenario());
			}
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x0001BD74 File Offset: 0x00019F74
		[CompilerGenerated]
		private void method_0(object a0)
		{
			this.SelectionChanged();
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x0011AC58 File Offset: 0x00118E58
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04001820 RID: 6176
		[CompilerGenerated]
		private Class2535 class2535_0;

		// Token: 0x04001821 RID: 6177
		public ActiveUnit theUnit;

		// Token: 0x04001822 RID: 6178
		[CompilerGenerated]
		private DataTable dataTable_0;

		// Token: 0x04001823 RID: 6179
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04001824 RID: 6180
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04001825 RID: 6181
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04001826 RID: 6182
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04001827 RID: 6183
		private ComboBox comboBox_0;

		// Token: 0x04001828 RID: 6184
		private Action<Doctrine, ComboBox, Scenario> action_0;

		// Token: 0x04001829 RID: 6185
		private Action<Doctrine, ComboBox, Scenario> action_1;

		// Token: 0x0400182A RID: 6186
		private Func<Doctrine, Scenario, bool> func_0;

		// Token: 0x0400182B RID: 6187
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
