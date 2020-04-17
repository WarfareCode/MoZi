using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.ObjectModel
{
    // Token: 0x0200108A RID: 4234
    //ZSP 	
    //public class ObservableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, INotifyDictionaryChanged<TKey, TValue>, INotifyDictionaryChanging<TKey, TValue>
    

    public class ObservableDictionary<TKey, TValue> : INotifyDictionaryChanged<TKey, TValue>
    {
		// Token: 0x060095D2 RID: 38354 RVA: 0x004B28C0 File Offset: 0x004B0AC0
		public ObservableDictionary()
		{
			List<WeakReference> _ENCList = ObservableDictionary<TKey, TValue>.__ENCList;
			lock (_ENCList)
			{
				ObservableDictionary<TKey, TValue>.__ENCList.Add(new WeakReference(this));
			}
			this.m_Dictionary = new Dictionary<TKey, TValue>();
		}

		// Token: 0x060095D3 RID: 38355 RVA: 0x000442BC File Offset: 0x000424BC
		public ObservableDictionary(KeyValuePair<TKey, TValue> item) : this(item.Key, item.Value)
		{
		}

		// Token: 0x060095D4 RID: 38356 RVA: 0x004B2914 File Offset: 0x004B0B14
		public ObservableDictionary(IDictionary<TKey, TValue> dictionary)
		{
			List<WeakReference> _ENCList = ObservableDictionary<TKey, TValue>.__ENCList;
			lock (_ENCList)
			{
				ObservableDictionary<TKey, TValue>.__ENCList.Add(new WeakReference(this));
			}
			this.m_Dictionary = (Dictionary<TKey, TValue>)dictionary;
		}

		// Token: 0x060095D5 RID: 38357 RVA: 0x000442D2 File Offset: 0x000424D2
		public ObservableDictionary(TKey key, TValue value) : this()
		{
			this.Add(key, value);
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x060095D6 RID: 38358 RVA: 0x004B2968 File Offset: 0x004B0B68
		public Dictionary<TKey, TValue> Dictionary
		{
			get
			{
				return this.m_Dictionary;
			}
		}

		// Token: 0x060095D7 RID: 38359 RVA: 0x000442E2 File Offset: 0x000424E2
		public void Add(KeyValuePair<TKey, TValue> item)
		{
			this.Add(item.Key, item.Value);
		}

		// Token: 0x060095D8 RID: 38360 RVA: 0x004B2980 File Offset: 0x004B0B80
		public void Clear()
		{
			NotifyDictionaryChangingEventArgs<TKey, TValue> notifyDictionaryChangingEventArgs = new NotifyDictionaryChangingEventArgs<TKey, TValue>(this.Dictionary, NotifyCollectionChangedAction.Reset);
			this.OnDictionaryChanging(notifyDictionaryChangingEventArgs);
			if (!notifyDictionaryChangingEventArgs.Cancel)
			{
				this.Dictionary.Clear();
				this.OnDictionaryChanged(new NotifyDictionaryChangedEventArgs<TKey, TValue>(this.Dictionary, NotifyCollectionChangedAction.Reset));
			}
		}

		// Token: 0x060095D9 RID: 38361 RVA: 0x000442F8 File Offset: 0x000424F8
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return this.Dictionary.ContainsKey(item.Key) && this.Dictionary.ContainsValue(item.Value);
		}

		// Token: 0x060095DA RID: 38362 RVA: 0x0000FBBF File Offset: 0x0000DDBF
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x060095DB RID: 38363 RVA: 0x004B29C8 File Offset: 0x004B0BC8
		public int Count
		{
			get
			{
				return this.Dictionary.Count;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x060095DC RID: 38364 RVA: 0x000081A2 File Offset: 0x000063A2
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060095DD RID: 38365 RVA: 0x00044326 File Offset: 0x00042526
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			this.Remove(item.Key);
			return false;
		}

		// Token: 0x060095DE RID: 38366 RVA: 0x004B29E4 File Offset: 0x004B0BE4
		public void Add(TKey key, TValue value)
		{
			NotifyDictionaryChangingEventArgs<TKey, TValue> notifyDictionaryChangingEventArgs = new NotifyDictionaryChangingEventArgs<TKey, TValue>(key, value, NotifyCollectionChangedAction.Add);
			this.OnDictionaryChanging(notifyDictionaryChangingEventArgs);
			if (!notifyDictionaryChangingEventArgs.Cancel)
			{
				this.Dictionary.Add(key, value);
				this.OnDictionaryChanged(new NotifyDictionaryChangedEventArgs<TKey, TValue>(key, value, NotifyCollectionChangedAction.Add));
			}
		}

		// Token: 0x060095DF RID: 38367 RVA: 0x004B2A24 File Offset: 0x004B0C24
		public void AddRange(IDictionary<TKey, TValue> dictionary)
		{
			NotifyDictionaryChangingEventArgs<TKey, TValue> notifyDictionaryChangingEventArgs = new NotifyDictionaryChangingEventArgs<TKey, TValue>(dictionary, NotifyCollectionChangedAction.Add);
			this.OnDictionaryChanging(notifyDictionaryChangingEventArgs);
			if (!notifyDictionaryChangingEventArgs.Cancel)
			{
                IEnumerator<KeyValuePair<TKey, TValue>> enumerator = dictionary.GetEnumerator();
                try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<TKey, TValue> current = enumerator.Current;
						this.Dictionary.Add(current.Key, current.Value);
					}
				}
				finally
				{
					
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.OnDictionaryChanged(new NotifyDictionaryChangedEventArgs<TKey, TValue>(dictionary, NotifyCollectionChangedAction.Add));
			}
		}

		// Token: 0x060095E0 RID: 38368 RVA: 0x00044337 File Offset: 0x00042537
		public bool ContainsKey(TKey key)
		{
			return this.Dictionary.ContainsKey(key);
		}

		// Token: 0x1700099A RID: 2458
		public TValue this[TKey key]
		{
			get
			{
                //ZSP
                TValue result = default(TValue);
                this.TryGetValue(key, ref result);
                return result;
            }
			set
			{
				KeyValuePair<TKey, TValue> oldItem = new KeyValuePair<TKey, TValue>(key, this[key]);
				KeyValuePair<TKey, TValue> newItem = new KeyValuePair<TKey, TValue>(key, value);
				NotifyDictionaryChangingEventArgs<TKey, TValue> notifyDictionaryChangingEventArgs = new NotifyDictionaryChangingEventArgs<TKey, TValue>(newItem, oldItem, NotifyCollectionChangedAction.Replace);
				this.OnDictionaryChanging(notifyDictionaryChangingEventArgs);
				if (!notifyDictionaryChangingEventArgs.Cancel)
				{
					this.Dictionary[key] = value;
					this.OnDictionaryChanged(new NotifyDictionaryChangedEventArgs<TKey, TValue>(newItem, oldItem, NotifyCollectionChangedAction.Replace));
				}
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x060095E3 RID: 38371 RVA: 0x004B2B20 File Offset: 0x004B0D20
		public ICollection<TKey> Keys
		{
			get
			{
				return this.Dictionary.Keys;
			}
		}

		// Token: 0x060095E4 RID: 38372 RVA: 0x004B2B3C File Offset: 0x004B0D3C
		public bool Remove(TKey key)
		{
            //ZSP result
            bool result = false;
            if (this.Keys.Contains(key))
			{
				TValue value = this[key];
				NotifyDictionaryChangingEventArgs<TKey, TValue> notifyDictionaryChangingEventArgs = new NotifyDictionaryChangingEventArgs<TKey, TValue>(key, value, NotifyCollectionChangedAction.Remove);
				this.OnDictionaryChanging(notifyDictionaryChangingEventArgs);
				if (!notifyDictionaryChangingEventArgs.Cancel)
				{
					this.Dictionary.Remove(key);
					this.OnDictionaryChanged(new NotifyDictionaryChangedEventArgs<TKey, TValue>(key, value, NotifyCollectionChangedAction.Remove));
                    result = true;

                }
			}
			return result;
		}

		// Token: 0x060095E5 RID: 38373 RVA: 0x004B2B98 File Offset: 0x004B0D98
		public void RemoveRange(IDictionary<TKey, TValue> dictionary)
		{
			NotifyDictionaryChangingEventArgs<TKey, TValue> notifyDictionaryChangingEventArgs = new NotifyDictionaryChangingEventArgs<TKey, TValue>(dictionary, NotifyCollectionChangedAction.Remove);
			this.OnDictionaryChanging(notifyDictionaryChangingEventArgs);
			if (!notifyDictionaryChangingEventArgs.Cancel)
			{
                IEnumerator<TKey> enumerator = dictionary.Keys.GetEnumerator();
                try
				{
					
					while (enumerator.MoveNext())
					{
						TKey current = enumerator.Current;
						this.Dictionary.Remove(current);
					}
				}
				finally
				{
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.OnDictionaryChanged(new NotifyDictionaryChangedEventArgs<TKey, TValue>(dictionary, NotifyCollectionChangedAction.Remove));
			}
		}

		// Token: 0x060095E6 RID: 38374 RVA: 0x00044345 File Offset: 0x00042545
		public bool TryGetValue(TKey key, ref TValue value)
		{
			return this.Dictionary.TryGetValue(key, out value);
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x060095E7 RID: 38375 RVA: 0x004B2C18 File Offset: 0x004B0E18
		public ICollection<TValue> Values
		{
			get
			{
				return this.Dictionary.Values;
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x060095E8 RID: 38376 RVA: 0x00044354 File Offset: 0x00042554
		// (remove) Token: 0x060095E9 RID: 38377 RVA: 0x0004436D File Offset: 0x0004256D
		public event INotifyDictionaryChanged<TKey, TValue>.DictionaryChangedEventHandler DictionaryChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DictionaryChangedEvent = (INotifyDictionaryChanged<TKey, TValue>.DictionaryChangedEventHandler)Delegate.Combine(this.DictionaryChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DictionaryChangedEvent = (INotifyDictionaryChanged<TKey, TValue>.DictionaryChangedEventHandler)Delegate.Remove(this.DictionaryChangedEvent, value);
			}
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x060095EA RID: 38378 RVA: 0x00044386 File Offset: 0x00042586
		// (remove) Token: 0x060095EB RID: 38379 RVA: 0x0004439F File Offset: 0x0004259F
		public event INotifyDictionaryChanging<TKey, TValue>.DictionaryChangingEventHandler DictionaryChanging
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.DictionaryChangingEvent = (INotifyDictionaryChanging<TKey, TValue>.DictionaryChangingEventHandler)Delegate.Combine(this.DictionaryChangingEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.DictionaryChangingEvent = (INotifyDictionaryChanging<TKey, TValue>.DictionaryChangingEventHandler)Delegate.Remove(this.DictionaryChangingEvent, value);
			}
		}

		// Token: 0x060095EC RID: 38380 RVA: 0x004B2C34 File Offset: 0x004B0E34
		protected void OnDictionaryChanging(NotifyDictionaryChangingEventArgs<TKey, TValue> e)
		{
			INotifyDictionaryChanging<TKey, TValue>.DictionaryChangingEventHandler dictionaryChangingEvent = this.DictionaryChangingEvent;
			if (dictionaryChangingEvent != null)
			{
				dictionaryChangingEvent(this, e);
			}
		}

		// Token: 0x060095ED RID: 38381 RVA: 0x004B2C5C File Offset: 0x004B0E5C
		protected void OnDictionaryChanged(NotifyDictionaryChangedEventArgs<TKey, TValue> e)
		{
			INotifyDictionaryChanged<TKey, TValue>.DictionaryChangedEventHandler dictionaryChangedEvent = this.DictionaryChangedEvent;
			if (dictionaryChangedEvent != null)
			{
				dictionaryChangedEvent(this, e);
			}
		}

		// Token: 0x060095EE RID: 38382 RVA: 0x004B2C84 File Offset: 0x004B0E84
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return (IEnumerator<KeyValuePair<TKey, TValue>>)((IDictionary)this.Dictionary).GetEnumerator();
		}

        // Token: 0x060095EF RID: 38383 RVA: 0x004B2CA4 File Offset: 0x004B0EA4
        //ZSP
        //IEnumerator IEnumerable.GetEnumerator1()
		//{
		//	return this.GetEnumerator();
		//}

		// Token: 0x04004E8B RID: 20107
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04004E8C RID: 20108
		private Dictionary<TKey, TValue> m_Dictionary;

		// Token: 0x04004E8D RID: 20109
		private INotifyDictionaryChanged<TKey, TValue>.DictionaryChangedEventHandler DictionaryChangedEvent;

		// Token: 0x04004E8E RID: 20110
		private INotifyDictionaryChanging<TKey, TValue>.DictionaryChangingEventHandler DictionaryChangingEvent;
	}
}
