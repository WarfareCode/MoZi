using System;
using System.Collections;

namespace ns14
{
	// Token: 0x02000475 RID: 1141
	public sealed class Class664 : IEnumerable
	{
		// Token: 0x06001D9B RID: 7579 RVA: 0x000BF7F4 File Offset: 0x000BD9F4
		public IEnumerator GetEnumerator()
		{
			return this.idictionary_0.Values.GetEnumerator();
		}

		// Token: 0x04000D2A RID: 3370
		private IDictionary idictionary_0;
	}
}
