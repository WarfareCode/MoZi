using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace System.Collections.ObjectModel
{
	// Token: 0x0200108B RID: 4235
	public sealed class ObservableStringDictionary : ObservableDictionary<string, string>
	{
		// Token: 0x060095F1 RID: 38385 RVA: 0x004B2CBC File Offset: 0x004B0EBC
		public ObservableStringDictionary()
		{
			List<WeakReference> _ENCList = ObservableStringDictionary.__ENCList;
			lock (_ENCList)
			{
				ObservableStringDictionary.__ENCList.Add(new WeakReference(this));
			}
		}

		// Token: 0x060095F2 RID: 38386 RVA: 0x004B2D04 File Offset: 0x004B0F04
		public ObservableStringDictionary(string key, string value) : base(key, value)
		{
			List<WeakReference> _ENCList = ObservableStringDictionary.__ENCList;
			lock (_ENCList)
			{
				ObservableStringDictionary.__ENCList.Add(new WeakReference(this));
			}
		}

		// Token: 0x060095F3 RID: 38387 RVA: 0x004B2D50 File Offset: 0x004B0F50
		public ObservableStringDictionary(IDictionary<string, string> dictionary) : base(dictionary)
		{
			List<WeakReference> _ENCList = ObservableStringDictionary.__ENCList;
			lock (_ENCList)
			{
				ObservableStringDictionary.__ENCList.Add(new WeakReference(this));
			}
		}

		// Token: 0x060095F4 RID: 38388 RVA: 0x004B2D9C File Offset: 0x004B0F9C
		public ObservableStringDictionary(StringDictionary dictionary) : base((IDictionary<string, string>)dictionary)
		{
			List<WeakReference> _ENCList = ObservableStringDictionary.__ENCList;
			lock (_ENCList)
			{
				ObservableStringDictionary.__ENCList.Add(new WeakReference(this));
			}
		}

		// Token: 0x060095F5 RID: 38389 RVA: 0x000443C4 File Offset: 0x000425C4
		public ObservableStringDictionary(KeyValuePair<string, string> item) : this(item.Key, item.Value)
		{
		}

		// Token: 0x04004E8F RID: 20111
		private static List<WeakReference> __ENCList = new List<WeakReference>();
	}
}
