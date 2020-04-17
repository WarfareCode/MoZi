using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Collections.Specialized
{
	// Token: 0x02001088 RID: 4232
	public sealed class NotifyDictionaryChangedEventArgs<TKey, TValue> : EventArgs
	{
		// Token: 0x060095BD RID: 38333 RVA: 0x00044176 File Offset: 0x00042376
		public NotifyDictionaryChangedEventArgs(KeyValuePair<TKey, TValue> newItem, KeyValuePair<TKey, TValue> oldItem, NotifyCollectionChangedAction action)
		{
			this.m_Action = action;
			this.m_NewItems = new Dictionary<TKey, TValue>(1);
			this.m_NewItems.Add(newItem);
			this.m_OldItems = new Dictionary<TKey, TValue>(1);
			this.m_OldItems.Add(oldItem);
		}

		// Token: 0x060095BE RID: 38334 RVA: 0x000441B5 File Offset: 0x000423B5
		public NotifyDictionaryChangedEventArgs(IDictionary<TKey, TValue> newItems, IDictionary<TKey, TValue> oldItems, NotifyCollectionChangedAction action)
		{
			this.m_Action = action;
			this.m_OldItems = oldItems;
			this.m_NewItems = newItems;
		}

		// Token: 0x060095BF RID: 38335 RVA: 0x000441D2 File Offset: 0x000423D2
		public NotifyDictionaryChangedEventArgs(IDictionary<TKey, TValue> items, NotifyCollectionChangedAction action)
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

		// Token: 0x060095C0 RID: 38336 RVA: 0x000441FC File Offset: 0x000423FC
		public NotifyDictionaryChangedEventArgs(KeyValuePair<TKey, TValue> item, NotifyCollectionChangedAction action) : this(item.Key, item.Value, action)
		{
		}

		// Token: 0x060095C1 RID: 38337 RVA: 0x004B26A8 File Offset: 0x004B08A8
		public NotifyDictionaryChangedEventArgs(TKey key, TValue value, NotifyCollectionChangedAction action) : this(new Dictionary<TKey, TValue>(1), action)
		{
			IDictionary<TKey, TValue> dictionary = (action == NotifyCollectionChangedAction.Reset | action == NotifyCollectionChangedAction.Remove) ? this.OldItems : this.NewItems;
			dictionary[key] = value;
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x060095C2 RID: 38338 RVA: 0x004B26E4 File Offset: 0x004B08E4
		public NotifyCollectionChangedAction Action
		{
			get
			{
				return this.m_Action;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x060095C3 RID: 38339 RVA: 0x004B26FC File Offset: 0x004B08FC
		public IDictionary<TKey, TValue> OldItems
		{
			get
			{
				return this.m_OldItems;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x060095C4 RID: 38340 RVA: 0x004B2714 File Offset: 0x004B0914
		public IDictionary<TKey, TValue> NewItems
		{
			get
			{
				return this.m_NewItems;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x060095C5 RID: 38341 RVA: 0x004B272C File Offset: 0x004B092C
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

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x060095C6 RID: 38342 RVA: 0x004B2770 File Offset: 0x004B0970
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

		// Token: 0x04004E85 RID: 20101
		private NotifyCollectionChangedAction m_Action;

		// Token: 0x04004E86 RID: 20102
		private IDictionary<TKey, TValue> m_OldItems;

		// Token: 0x04004E87 RID: 20103
		private IDictionary<TKey, TValue> m_NewItems;
	}
}
