using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.Specialized
{
    // Token: 0x02001083 RID: 4227
    //ZSP
    public abstract class INotifyDictionaryChanging<TKey, TValue> 
	{
		// Token: 0x1400002C RID: 44
		// (add) Token: 0x060095B0 RID: 38320
		// (remove) Token: 0x060095B1 RID: 38321
		event INotifyDictionaryChanging<TKey, TValue>.DictionaryChangingEventHandler DictionaryChanging;

		// Token: 0x02001084 RID: 4228
		// (Invoke) Token: 0x060095B5 RID: 38325
		public delegate void DictionaryChangingEventHandler(object sender, NotifyDictionaryChangingEventArgs<TKey, TValue> e);
	}
}
