using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns3
{
	// Token: 0x02000B8A RID: 2954
	public sealed class Class227<T> : HashSet<T>, INotifyCollectionChanged
	{
		// Token: 0x14000025 RID: 37
		// (add) Token: 0x0600618F RID: 24975 RVA: 0x002F2F80 File Offset: 0x002F1180
		// (remove) Token: 0x06006190 RID: 24976 RVA: 0x002F2FBC File Offset: 0x002F11BC
		public event NotifyCollectionChangedEventHandler CollectionChanged
		{
			[CompilerGenerated]
			add
			{
				NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = this.notifyCollectionChangedEventHandler_0;
				NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
				do
				{
					notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
					NotifyCollectionChangedEventHandler value2 = (NotifyCollectionChangedEventHandler)Delegate.Combine(notifyCollectionChangedEventHandler2, value);
					notifyCollectionChangedEventHandler = Interlocked.CompareExchange<NotifyCollectionChangedEventHandler>(ref this.notifyCollectionChangedEventHandler_0, value2, notifyCollectionChangedEventHandler2);
				}
				while (notifyCollectionChangedEventHandler != notifyCollectionChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = this.notifyCollectionChangedEventHandler_0;
				NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
				do
				{
					notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
					NotifyCollectionChangedEventHandler value2 = (NotifyCollectionChangedEventHandler)Delegate.Remove(notifyCollectionChangedEventHandler2, value);
					notifyCollectionChangedEventHandler = Interlocked.CompareExchange<NotifyCollectionChangedEventHandler>(ref this.notifyCollectionChangedEventHandler_0, value2, notifyCollectionChangedEventHandler2);
				}
				while (notifyCollectionChangedEventHandler != notifyCollectionChangedEventHandler2);
			}
		}

		// Token: 0x04003487 RID: 13447
		[CompilerGenerated]
		private NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler_0;
	}
}
