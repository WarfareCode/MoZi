using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ns35;
using ns4;

namespace Command
{
	// Token: 0x02000873 RID: 2163
	[Attribute0, Attribute2, Attribute3]
	public sealed class UnitWeaponElementViewModel : INotifyPropertyChanged
	{
		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06003553 RID: 13651 RVA: 0x0011CBA8 File Offset: 0x0011ADA8
		// (remove) Token: 0x06003554 RID: 13652 RVA: 0x0011CBE4 File Offset: 0x0011ADE4
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

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06003555 RID: 13653 RVA: 0x0011CC20 File Offset: 0x0011AE20
		// (set) Token: 0x06003556 RID: 13654 RVA: 0x0001C8B6 File Offset: 0x0001AAB6
		public int WeaponDBID
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
					this.vmethod_0("WeaponDBID");
				}
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06003557 RID: 13655 RVA: 0x0011CC38 File Offset: 0x0011AE38
		// (set) Token: 0x06003558 RID: 13656 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		public string Name
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
					this.vmethod_0("Name");
				}
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06003559 RID: 13657 RVA: 0x0011CC50 File Offset: 0x0011AE50
		// (set) Token: 0x0600355A RID: 13658 RVA: 0x0001C8FE File Offset: 0x0001AAFE
		public int Qty
		{
			[CompilerGenerated]
			get
			{
				return this.int_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_1 != value)
				{
					this.int_1 = value;
					this.vmethod_0("Qty");
				}
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600355B RID: 13659 RVA: 0x0011CC68 File Offset: 0x0011AE68
		// (set) Token: 0x0600355C RID: 13660 RVA: 0x0001C920 File Offset: 0x0001AB20
		public Class2535 OpenDBViewerCommand
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
					this.vmethod_0("OpenDBViewerCommand");
				}
			}
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x0001C942 File Offset: 0x0001AB42
		public UnitWeaponElementViewModel()
		{
			this.OpenDBViewerCommand = new Class2535(new Action<object>(this.method_1));
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x0001C961 File Offset: 0x0001AB61
		public void method_0()
		{
			Client.ShowDBInfo("武器", this.WeaponDBID);
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x0001C973 File Offset: 0x0001AB73
		[CompilerGenerated]
		private void method_1(object a0)
		{
			this.method_0();
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x0011CC80 File Offset: 0x0011AE80
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040018AD RID: 6317
		[CompilerGenerated]
		private int int_0;

		// Token: 0x040018AE RID: 6318
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040018AF RID: 6319
		[CompilerGenerated]
		private int int_1;

		// Token: 0x040018B0 RID: 6320
		[CompilerGenerated]
		private Class2535 class2535_0;

		// Token: 0x040018B1 RID: 6321
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
