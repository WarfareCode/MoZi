using System;

namespace ns16
{
	// Token: 0x020004C2 RID: 1218
	public abstract class Class2006 : IComparable, ICloneable, Interface28
	{
		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x000D0FC4 File Offset: 0x000CF1C4
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x00013169 File Offset: 0x00011369
		public DateTime Value
		{
			get
			{
				return this.dateTime_0;
			}
			set
			{
				this.dateTime_0 = value;
				this.bool_0 = false;
			}
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x00013179 File Offset: 0x00011379
		public Class2006()
		{
			this.method_2();
			this.bool_0 = true;
			this.bool_1 = false;
			this.enum154_0 = Class2006.Enum154.const_0;
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x000D0FDC File Offset: 0x000CF1DC
		public override bool Equals(object obj)
		{
			bool result;
			if (!(obj is Class2006))
			{
				result = false;
			}
			else
			{
				Class2006 @class = (Class2006)obj;
				result = (this.dateTime_0.CompareTo(@class.dateTime_0) == 0 && this.enum154_0 == @class.enum154_0 && this.int_0 == @class.int_0);
			}
			return result;
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x000D1034 File Offset: 0x000CF234
		public override int GetHashCode()
		{
			return this.dateTime_0.GetHashCode();
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x000D1054 File Offset: 0x000CF254
		public int CompareTo(object target)
		{
			return this.method_0((Class2006)target);
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x000D1070 File Offset: 0x000CF270
		public int method_0(Class2006 class2006_0)
		{
			DateTime dateTime = this.method_1(true);
			DateTime value = class2006_0.method_1(true);
			return dateTime.CompareTo(value);
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x000D1098 File Offset: 0x000CF298
		public DateTime method_1(bool bool_2)
		{
			DateTime result = this.dateTime_0;
			if (bool_2 && this.enum154_0 == Class2006.Enum154.const_2)
			{
				result.AddMinutes((double)this.int_0);
			}
			return result;
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x0001319C File Offset: 0x0001139C
		public void method_2()
		{
			this.dateTime_0 = DateTime.Now;
			this.enum154_0 = Class2006.Enum154.const_0;
			this.int_0 = 0;
		}

		// Token: 0x06001FC5 RID: 8133
		public abstract object Clone();

		// Token: 0x04000F0C RID: 3852
		protected DateTime dateTime_0;

		// Token: 0x04000F0D RID: 3853
		protected Class2006.Enum154 enum154_0;

		// Token: 0x04000F0E RID: 3854
		protected int int_0;

		// Token: 0x04000F0F RID: 3855
		protected bool bool_0;

		// Token: 0x04000F10 RID: 3856
		protected bool bool_1;

		// Token: 0x020004C3 RID: 1219
		public enum Enum154
		{
			// Token: 0x04000F12 RID: 3858
			const_0,
			// Token: 0x04000F13 RID: 3859
			const_1,
			// Token: 0x04000F14 RID: 3860
			const_2
		}
	}
}
