using System;
using System.Globalization;

namespace ns16
{
	// Token: 0x020004CD RID: 1229
	public sealed class Class2019 : IComparable, ICloneable, Interface28
	{
		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x000D17F4 File Offset: 0x000CF9F4
		// (set) Token: 0x06002009 RID: 8201 RVA: 0x000134D5 File Offset: 0x000116D5
		public double Value
		{
			get
			{
				return this.double_0;
			}
			set
			{
				this.double_0 = value;
				this.bool_0 = false;
				this.bool_1 = false;
			}
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x000134EC File Offset: 0x000116EC
		public Class2019()
		{
			this.bool_1 = false;
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x00013509 File Offset: 0x00011709
		public Class2019(double double_1)
		{
			this.double_0 = double_1;
			this.bool_0 = false;
			this.bool_1 = false;
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x000D180C File Offset: 0x000CFA0C
		public override string ToString()
		{
			string result;
			if (this.bool_0)
			{
				result = "";
			}
			else
			{
				result = this.double_0.ToString(Class2008.string_0, CultureInfo.InvariantCulture);
			}
			return result;
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x000D1844 File Offset: 0x000CFA44
		public override int GetHashCode()
		{
			return this.double_0.GetHashCode();
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00013534 File Offset: 0x00011734
		public override bool Equals(object obj)
		{
			return obj != null && obj is Class2019 && this.Value == ((Class2019)obj).Value;
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x000D1860 File Offset: 0x000CFA60
		public int CompareTo(object target)
		{
			return this.Value.CompareTo(((Class2019)target).Value);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x000D1888 File Offset: 0x000CFA88
		public object Clone()
		{
			return new Class2019(this.Value);
		}

		// Token: 0x04000F33 RID: 3891
		protected double double_0;

		// Token: 0x04000F34 RID: 3892
		protected bool bool_0 = true;

		// Token: 0x04000F35 RID: 3893
		protected bool bool_1 = true;
	}
}
