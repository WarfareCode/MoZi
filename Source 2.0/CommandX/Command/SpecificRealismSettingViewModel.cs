using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media.Imaging;
using ns32;
using ns4;

namespace Command
{
	// Token: 0x02000930 RID: 2352
	[Attribute0, Attribute2, Attribute3]
	public sealed class SpecificRealismSettingViewModel : INotifyPropertyChanged
	{
		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060039B7 RID: 14775 RVA: 0x00122368 File Offset: 0x00120568
		// (remove) Token: 0x060039B8 RID: 14776 RVA: 0x001223A4 File Offset: 0x001205A4
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

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060039B9 RID: 14777 RVA: 0x001223E0 File Offset: 0x001205E0
		// (set) Token: 0x060039BA RID: 14778 RVA: 0x0001EABE File Offset: 0x0001CCBE
		public string Title
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
					this.vmethod_0("Title");
				}
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060039BB RID: 14779 RVA: 0x001223F8 File Offset: 0x001205F8
		// (set) Token: 0x060039BC RID: 14780 RVA: 0x0001EAE4 File Offset: 0x0001CCE4
		public string Subtitle
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
					this.vmethod_0("Subtitle");
				}
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060039BD RID: 14781 RVA: 0x0001EB0A File Offset: 0x0001CD0A
		// (set) Token: 0x060039BE RID: 14782 RVA: 0x0001EB12 File Offset: 0x0001CD12
		public bool Active
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
					this.vmethod_0("Active");
				}
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060039BF RID: 14783 RVA: 0x00122410 File Offset: 0x00120610
		public static BitmapImage NegativeImageSource
		{
			get
			{
				return SpecificRealismSettingViewModel.bitmapImage_1;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060039C0 RID: 14784 RVA: 0x00122424 File Offset: 0x00120624
		public static BitmapImage PositiveImageSource
		{
			get
			{
				return SpecificRealismSettingViewModel.bitmapImage_0;
			}
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x00122438 File Offset: 0x00120638
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04001A6B RID: 6763
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04001A6C RID: 6764
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04001A6D RID: 6765
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04001A6E RID: 6766
		private static BitmapImage bitmapImage_0 = new BitmapImage(new Uri(CommandFactory.GetCommandApp().Info.DirectoryPath + "/Symbols/Positive.png"));

		// Token: 0x04001A6F RID: 6767
		private static BitmapImage bitmapImage_1 = new BitmapImage(new Uri(CommandFactory.GetCommandApp().Info.DirectoryPath + "/Symbols/Negative.png"));

		// Token: 0x04001A70 RID: 6768
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
