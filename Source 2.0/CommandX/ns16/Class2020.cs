using System;
using System.Globalization;

namespace ns16
{
	// Token: 0x02000068 RID: 104
	public class Class2020 : IComparable, ICloneable, Interface28
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00059D84 File Offset: 0x00057F84
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00005522 File Offset: 0x00003722
		public decimal Value
		{
			get
			{
				return this.decimal_0;
			}
			set
			{
				this.decimal_0 = value;
				this.bool_0 = false;
				this.bool_1 = false;
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00005539 File Offset: 0x00003739
		public Class2020()
		{
			this.bool_1 = false;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00005556 File Offset: 0x00003756
		public Class2020(decimal decimal_1)
		{
			this.decimal_0 = decimal_1;
			this.bool_0 = false;
			this.bool_1 = false;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00005581 File Offset: 0x00003781
		public Class2020(string string_0)
		{
			this.method_0(string_0);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00059D9C File Offset: 0x00057F9C
		public void method_0(string string_0)
		{
			if (string_0 != null && !(string_0 == ""))
			{
				try
				{
					this.decimal_0 = Convert.ToDecimal(string_0, CultureInfo.InvariantCulture);
					this.bool_0 = false;
					this.bool_1 = false;
					return;
				}
				catch (FormatException exception_)
				{
					throw new Exception15(exception_);
				}
			}
			this.decimal_0 = 0m;
			this.bool_0 = true;
			this.bool_1 = true;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00059E10 File Offset: 0x00058010
		public override string ToString()
		{
			string result;
			if (this.bool_0)
			{
				result = "";
			}
			else
			{
				result = this.decimal_0.ToString(Class2008.string_0, CultureInfo.InvariantCulture);
			}
			return result;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00059E48 File Offset: 0x00058048
		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000559E File Offset: 0x0000379E
		public override bool Equals(object obj)
		{
			return obj != null && obj is Class2020 && this.Value == ((Class2020)obj).Value;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00059E68 File Offset: 0x00058068
		public int CompareTo(object target)
		{
			return this.Value.CompareTo(((Class2020)target).Value);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00059E90 File Offset: 0x00058090
		public object Clone()
		{
			return new Class2020(this.Value);
		}

		// Token: 0x04000144 RID: 324
		protected decimal decimal_0;

		// Token: 0x04000145 RID: 325
		protected bool bool_0 = true;

		// Token: 0x04000146 RID: 326
		protected bool bool_1 = true;
	}
}
