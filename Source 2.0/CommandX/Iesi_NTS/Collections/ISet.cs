using System;
using System.Collections;

namespace Iesi_NTS.Collections
{
	// Token: 0x02000375 RID: 885
	public interface ISet : IEnumerable, ICloneable, ICollection
	{
		// Token: 0x06001540 RID: 5440
		bool Contains(object object_0);

		// Token: 0x06001541 RID: 5441
		bool Add(object object_0);

		// Token: 0x06001542 RID: 5442
		bool imethod_0(object object_0);

		// Token: 0x06001543 RID: 5443
		void Clear();
	}
}
