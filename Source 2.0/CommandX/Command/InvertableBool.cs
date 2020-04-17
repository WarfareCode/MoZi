using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ns35;

namespace Command
{
	// Token: 0x02000A83 RID: 2691
	[Attribute11, Attribute12, Attribute13]
	public sealed class InvertableBool : INotifyPropertyChanged
	{
		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06005510 RID: 21776 RVA: 0x00237BEC File Offset: 0x00235DEC
		// (remove) Token: 0x06005511 RID: 21777 RVA: 0x00237C28 File Offset: 0x00235E28
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
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
			[CompilerGenerated]
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

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06005512 RID: 21778 RVA: 0x000271E5 File Offset: 0x000253E5
		// (set) Token: 0x06005513 RID: 21779 RVA: 0x000271ED File Offset: 0x000253ED
		public bool Value
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				if (this.bool_0 != value)
				{
					this.bool_0 = value;
					this.method_0("Value");
					this.method_0("Invert");
				}
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06005514 RID: 21780 RVA: 0x0002721A File Offset: 0x0002541A
		// (set) Token: 0x06005515 RID: 21781 RVA: 0x00027225 File Offset: 0x00025425
		public bool Invert
		{
			get
			{
				return !this.bool_0;
			}
			set
			{
				this.bool_0 = !value;
				this.method_0("Value");
				this.method_0("Invert");
			}
		}

		// Token: 0x06005516 RID: 21782 RVA: 0x00237C64 File Offset: 0x00235E64
		private void method_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x06005517 RID: 21783 RVA: 0x00027247 File Offset: 0x00025447
		public InvertableBool(bool b)
		{
			this.bool_0 = false;
			this.bool_0 = b;
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x00237C8C File Offset: 0x00235E8C
		public static InvertableBool smethod_0(bool b)
		{
			return new InvertableBool(b);
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x0002725D File Offset: 0x0002545D
		public static bool smethod_1(InvertableBool b)
		{
			return b.Value;
		}

		// Token: 0x04002939 RID: 10553
		[CompilerGenerated]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x0400293A RID: 10554
		private bool bool_0;
	}
}
