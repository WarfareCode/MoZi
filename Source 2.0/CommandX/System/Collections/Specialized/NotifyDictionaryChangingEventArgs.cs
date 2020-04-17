using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace System.Collections.Specialized
{
	// Token: 0x02001089 RID: 4233
	public sealed class NotifyDictionaryChangingEventArgs<TKey, TValue> : CancelEventArgs
	{
		// Token: 0x060095C7 RID: 38343 RVA: 0x00044213 File Offset: 0x00042413
		public NotifyDictionaryChangingEventArgs(KeyValuePair<TKey, TValue> newItem, KeyValuePair<TKey, TValue> oldItem, NotifyCollectionChangedAction action)
		{
			this.m_Action = action;
			this.m_NewItems = new Dictionary<TKey, TValue>(1);
			this.m_NewItems.Add(newItem);
			this.m_OldItems = new Dictionary<TKey, TValue>(1);
			this.m_OldItems.Add(oldItem);
		}

		// Token: 0x060095C8 RID: 38344 RVA: 0x00044252 File Offset: 0x00042452
		public NotifyDictionaryChangingEventArgs(IDictionary<TKey, TValue> newItems, IDictionary<TKey, TValue> oldItems, NotifyCollectionChangedAction action)
		{
			this.m_Action = action;
			this.m_OldItems = oldItems;
			this.m_NewItems = newItems;
		}

		// Token: 0x060095C9 RID: 38345 RVA: 0x0004426F File Offset: 0x0004246F
		public NotifyDictionaryChangingEventArgs(IDictionary<TKey, TValue> items, NotifyCollectionChangedAction action)
		{
			this.m_Action = action;
			if (action == NotifyCollectionChangedAction.Reset | action == NotifyCollectionChangedAction.Remove)
			{
				this.m_OldItems = items;
			}
			else
			{
				this.m_NewItems = items;
			}
		}

		// Token: 0x060095CA RID: 38346 RVA: 0x00044299 File Offset: 0x00042499
		public NotifyDictionaryChangingEventArgs(KeyValuePair<TKey, TValue> item, NotifyCollectionChangedAction action) : this(item.Key, item.Value, action)
		{
		}

		// Token: 0x060095CB RID: 38347 RVA: 0x004B27B4 File Offset: 0x004B09B4
		public NotifyDictionaryChangingEventArgs(TKey key, TValue value, NotifyCollectionChangedAction action) : this(new Dictionary<TKey, TValue>(1), action)
		{
			IDictionary<TKey, TValue> dictionary = (action == NotifyCollectionChangedAction.Reset | action == NotifyCollectionChangedAction.Remove) ? this.OldItems : this.NewItems;
			dictionary[key] = value;
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x060095CC RID: 38348 RVA: 0x004B27F0 File Offset: 0x004B09F0
		public NotifyCollectionChangedAction Action
		{
			get
			{
				return this.m_Action;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x060095CD RID: 38349 RVA: 0x004B2808 File Offset: 0x004B0A08
		public IDictionary<TKey, TValue> OldItems
		{
			get
			{
				return this.m_OldItems;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x060095CE RID: 38350 RVA: 0x004B2820 File Offset: 0x004B0A20
		public IDictionary<TKey, TValue> NewItems
		{
			get
			{
				return this.m_NewItems;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060095CF RID: 38351 RVA: 0x004B2838 File Offset: 0x004B0A38
		public KeyValuePair<TKey, TValue> OldItem
		{
			get
			{
				KeyValuePair<TKey, TValue> result;
				if (this.OldItems == null)
				{
					KeyValuePair<TKey, TValue> keyValuePair = new KeyValuePair<TKey, TValue>(default(TKey), default(TValue));
					result = keyValuePair;
				}
				else
				{
					result = this.OldItems.ElementAtOrDefault(0);
				}
				return result;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x060095D0 RID: 38352 RVA: 0x004B287C File Offset: 0x004B0A7C
		public KeyValuePair<TKey, TValue> NewItem
		{
			get
			{
				KeyValuePair<TKey, TValue> result;
				if (this.NewItems == null)
				{
					KeyValuePair<TKey, TValue> keyValuePair = new KeyValuePair<TKey, TValue>(default(TKey), default(TValue));
					result = keyValuePair;
				}
				else
				{
					result = this.NewItems.ElementAtOrDefault(0);
				}
				return result;
			}
		}

		// Token: 0x04004E88 RID: 20104
		private NotifyCollectionChangedAction m_Action;

		// Token: 0x04004E89 RID: 20105
		private IDictionary<TKey, TValue> m_OldItems;

		// Token: 0x04004E8A RID: 20106
		private IDictionary<TKey, TValue> m_NewItems;
	}
}
