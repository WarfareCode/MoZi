using System;

namespace ns16
{
	// Token: 0x020004C4 RID: 1220
	public abstract class Class2007 : IComparable, ICloneable, Interface28
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x000D10D4 File Offset: 0x000CF2D4
		// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x000131B7 File Offset: 0x000113B7
		public byte[] Value
		{
			get
			{
				return this.byte_0;
			}
			set
			{
				this.byte_0 = value;
				this.bool_0 = false;
			}
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x000131C7 File Offset: 0x000113C7
		public Class2007()
		{
			this.bool_0 = true;
			this.bool_1 = false;
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x000D10EC File Offset: 0x000CF2EC
		public override bool Equals(object obj)
		{
			bool result;
			if (!(obj is Class2007))
			{
				result = false;
			}
			else
			{
				Class2007 @class = (Class2007)obj;
				if (this.byte_0.Length != @class.Value.Length)
				{
					result = false;
				}
				else
				{
					for (long num = 0L; num < (long)this.byte_0.Length; num += 1L)
					{
						if (this.byte_0[(int)((IntPtr)num)] != @class.Value[(int)((IntPtr)num)])
						{
							result = false;
							return result;
						}
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x000D117C File Offset: 0x000CF37C
		public override int GetHashCode()
		{
			int result;
			if (this.byte_0.Length != 0)
			{
				result = this.byte_0[0].GetHashCode();
			}
			else
			{
				result = 1243;
			}
			return result;
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x000D11B4 File Offset: 0x000CF3B4
		public int CompareTo(object target)
		{
			return this.method_0((Class2007)target);
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x000D11D0 File Offset: 0x000CF3D0
		public int method_0(Class2007 class2007_0)
		{
			long num = 0L;
			while (num < (long)this.byte_0.Length && num < (long)class2007_0.Value.Length && this.byte_0[(int)((IntPtr)num)] == class2007_0.Value[(int)((IntPtr)num)])
			{
				num += 1L;
			}
			int result;
			if (num < (long)this.byte_0.Length && num < (long)class2007_0.Value.Length)
			{
				result = this.byte_0[(int)((IntPtr)num)].CompareTo(class2007_0.Value[(int)((IntPtr)num)]);
			}
			else
			{
				result = this.byte_0.Length.CompareTo(class2007_0.Value.Length);
			}
			return result;
		}

		// Token: 0x06001FCD RID: 8141
		public abstract object Clone();

		// Token: 0x04000F15 RID: 3861
		protected byte[] byte_0;

		// Token: 0x04000F16 RID: 3862
		protected bool bool_0;

		// Token: 0x04000F17 RID: 3863
		protected bool bool_1;
	}
}
