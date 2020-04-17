using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;
using ns25;

namespace ns26
{
	// Token: 0x02000779 RID: 1913
	public sealed class Class2206 : Class2205
	{
		// Token: 0x06002F46 RID: 12102 RVA: 0x00019A20 File Offset: 0x00017C20
		public Class2206(Class2193 class2193_1, IGeometryFactory igeometryFactory_1) : base(class2193_1, igeometryFactory_1)
		{
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x001073C8 File Offset: 0x001055C8
		public override Class2193 vmethod_8(Class2193 class2193_1)
		{
			return class2193_1.vmethod_25();
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x00019A2A File Offset: 0x00017C2A
		public override void vmethod_9(Class2193 class2193_1, Class2205 class2205_1)
		{
			class2193_1.vmethod_16(class2205_1);
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x001073E0 File Offset: 0x001055E0
		public  void vmethod_14()
		{
			Class2193 @class = base.method_1();
			do
			{
				Class2200 class2 = @class.vmethod_7();
				((Class2196)class2.vmethod_6()).vmethod_9(this);
				@class = @class.vmethod_25();
			}
			while (@class != base.method_1());
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00107424 File Offset: 0x00105624
		public  IList vmethod_15()
		{
			IList list = new ArrayList();
			Class2193 @class = base.method_1();
			do
			{
				if (@class.vmethod_23() == null)
				{
					Class2205 value = new Class2207(@class, base.method_0());
					list.Add(value);
				}
				@class = @class.vmethod_25();
			}
			while (@class != base.method_1());
			return list;
		}
	}
}
