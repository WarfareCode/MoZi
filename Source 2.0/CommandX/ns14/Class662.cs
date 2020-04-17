using System;
using System.Collections.Generic;
using GeoAPI.Geometries;

namespace ns14
{
	// Token: 0x02000468 RID: 1128
	public sealed class Class662 : List<ICoordinate>, ICloneable
	{
		// Token: 0x06001D0B RID: 7435 RVA: 0x00011FDA File Offset: 0x000101DA
		public Class662()
		{
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00011FE2 File Offset: 0x000101E2
		public Class662(ICoordinate[] icoordinate_0)
		{
			this.method_1(icoordinate_0, true);
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00011FF3 File Offset: 0x000101F3
		public Class662(ICoordinate[] icoordinate_0, bool bool_0)
		{
			this.method_1(icoordinate_0, bool_0);
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x000B7284 File Offset: 0x000B5484
		public bool method_0(ICoordinate[] icoordinate_0, bool bool_0, bool bool_1)
		{
			if (bool_1)
			{
				for (int i = 0; i < icoordinate_0.Length; i++)
				{
					this.method_2(icoordinate_0[i], bool_0);
				}
			}
			else
			{
				for (int i = icoordinate_0.Length - 1; i >= 0; i--)
				{
					this.method_2(icoordinate_0[i], bool_0);
				}
			}
			return true;
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00012004 File Offset: 0x00010204
		public bool method_1(ICoordinate[] icoordinate_0, bool bool_0)
		{
			return this.method_0(icoordinate_0, bool_0, true);
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x000B72D8 File Offset: 0x000B54D8
		public bool method_2(ICoordinate icoordinate_0, bool bool_0)
		{
			bool result;
			if (!bool_0 && base.Count >= 1)
			{
				ICoordinate coordinate = base[base.Count - 1];
				if (coordinate.imethod_8(icoordinate_0))
				{
					result = false;
					return result;
				}
			}
			base.Add(icoordinate_0);
			result = true;
			return result;
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x000B7320 File Offset: 0x000B5520
		public ICoordinate[] method_3()
		{
			return base.ToArray();
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x000B7338 File Offset: 0x000B5538
		public object Clone()
		{
			Class662 @class = new Class662();
			foreach (ICoordinate current in this)
			{
				@class.Add((ICoordinate)current.Clone());
			}
			return @class;
		}
	}
}
