using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Data;
using Command_Core;
using ns4;

namespace Command
{
	// Token: 0x02000841 RID: 2113
	[Attribute0, Attribute2, Attribute3]
	public sealed class DoctrineViewModel : INotifyPropertyChanged
	{
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06003414 RID: 13332 RVA: 0x0011AC80 File Offset: 0x00118E80
		// (remove) Token: 0x06003415 RID: 13333 RVA: 0x0011ACBC File Offset: 0x00118EBC
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

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06003416 RID: 13334 RVA: 0x0011ACF8 File Offset: 0x00118EF8
		// (set) Token: 0x06003417 RID: 13335 RVA: 0x0001BD7C File Offset: 0x00019F7C
		public ObservableCollection<SpecificDoctrineViewModel> SpecificDoctrines
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_0 != value)
				{
					this.observableCollection_0 = value;
					this.vmethod_0("SpecificDoctrines");
				}
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06003418 RID: 13336 RVA: 0x0011AD10 File Offset: 0x00118F10
		// (set) Token: 0x06003419 RID: 13337 RVA: 0x0001BD9E File Offset: 0x00019F9E
		public ListCollectionView GroupedCollection
		{
			[CompilerGenerated]
			get
			{
				return this.listCollectionView_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.listCollectionView_0 != value)
				{
					this.listCollectionView_0 = value;
					this.vmethod_0("GroupedCollection");
				}
			}
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x0011AD28 File Offset: 0x00118F28
		public DoctrineViewModel(ActiveUnit theUnit, List<SpecificDoctrineViewModel> SpecificDoctrineCache)
		{
			this.theUnit = theUnit;
			this.SpecificDoctrines = new ObservableCollection<SpecificDoctrineViewModel>(SpecificDoctrineCache);
			this.GroupedCollection = (ListCollectionView)CollectionViewSource.GetDefaultView(this.SpecificDoctrines);
			this.GroupedCollection.GroupDescriptions.Add(new PropertyGroupDescription("DoctrineGroup"));
			this.Refresh();
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x0011AD84 File Offset: 0x00118F84
		[Attribute0, Attribute2]
		public void Refresh()
		{
			foreach (SpecificDoctrineViewModel current in this.SpecificDoctrines)
			{
				current.theUnit = this.theUnit;
				current.Refresh();
			}
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x0011ADE0 File Offset: 0x00118FE0
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400182C RID: 6188
		public ActiveUnit theUnit;

		// Token: 0x0400182D RID: 6189
		[CompilerGenerated]
		private ObservableCollection<SpecificDoctrineViewModel> observableCollection_0;

		// Token: 0x0400182E RID: 6190
		[CompilerGenerated]
		private ListCollectionView listCollectionView_0;

		// Token: 0x0400182F RID: 6191
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
