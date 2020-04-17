using System;
using GeoAPI.Geometries;
using ns14;

namespace ns12
{
	// Token: 0x02000392 RID: 914
	public abstract class Class592 : ICloneable, ICoordinateSequence
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600160E RID: 5646
		public abstract int Count
		{
			get;
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x0008D6EC File Offset: 0x0008B8EC
		public ICoordinate imethod_0(int int_1)
		{
			ICoordinate[] array = this.method_0();
			ICoordinate result;
			if (array != null)
			{
				result = array[int_1];
			}
			else
			{
				result = this.vmethod_0(int_1);
			}
			return result;
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x0008D718 File Offset: 0x0008B918
		public ICoordinate[] imethod_3()
		{
			ICoordinate[] array = this.method_0();
			ICoordinate[] result;
			if (array != null)
			{
				result = array;
			}
			else
			{
				array = new ICoordinate[this.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = this.vmethod_0(i);
				}
				this.weakReference_0 = new WeakReference(array);
				result = array;
			}
			return result;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x0008D770 File Offset: 0x0008B970
		private ICoordinate[] method_0()
		{
			ICoordinate[] result;
			if (this.weakReference_0 != null)
			{
				ICoordinate[] array = (ICoordinate[])this.weakReference_0.Target;
				if (array != null)
				{
					result = array;
				}
				else
				{
					this.weakReference_0 = null;
					result = null;
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001612 RID: 5650
		public abstract double imethod_1(int int_1, Enum142 enum142_0);

		// Token: 0x06001613 RID: 5651
		public abstract void imethod_2(int int_1, Enum142 enum142_0, double double_0);

		// Token: 0x06001614 RID: 5652
		protected abstract ICoordinate vmethod_0(int int_1);

		// Token: 0x06001615 RID: 5653
		public abstract object Clone();

		// Token: 0x0400092F RID: 2351
		protected WeakReference weakReference_0;

		// Token: 0x04000930 RID: 2352
		protected int int_0;
	}
}
