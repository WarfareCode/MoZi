using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.Specialized
{
	// Token: 0x02001081 RID: 4225
    //ZSP
	public abstract class INotifyDictionaryChanged<TKey, TValue> : INotifyDictionaryChanging<TKey, TValue>
	{
		// Token: 0x1400002B RID: 43
		// (add) Token: 0x060095AA RID: 38314
		// (remove) Token: 0x060095AB RID: 38315
		event INotifyDictionaryChanged<TKey, TValue>.DictionaryChangedEventHandler DictionaryChanged;

		// Token: 0x02001082 RID: 4226
		// (Invoke) Token: 0x060095AF RID: 38319
		public delegate void DictionaryChangedEventHandler(object sender, NotifyDictionaryChangedEventArgs<TKey, TValue> e);
	}
}
