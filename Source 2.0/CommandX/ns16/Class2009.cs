using System;

namespace ns16
{
	// Token: 0x020004C7 RID: 1223
	public sealed class Class2009 : IComparable, ICloneable, Interface28
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x0001323A File Offset: 0x0001143A
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x00013242 File Offset: 0x00011442
		public bool Value
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
				this.bool_1 = false;
				this.bool_2 = false;
			}
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00013259 File Offset: 0x00011459
		public Class2009()
		{
			this.bool_2 = false;
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00013276 File Offset: 0x00011476
		public Class2009(bool bool_3)
		{
			this.bool_0 = bool_3;
			this.bool_1 = false;
			this.bool_2 = false;
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x000132A1 File Offset: 0x000114A1
		public Class2009(string string_0)
		{
			this.method_0(string_0);
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x000D1320 File Offset: 0x000CF520
		public void method_0(string string_0)
		{
			if (string_0 == null)
			{
				this.bool_1 = true;
				this.bool_0 = false;
				this.bool_2 = true;
			}
			else if (string_0.Length > 0)
			{
				this.bool_0 = new Class2050(string_0).vmethod_0();
				this.bool_1 = false;
				this.bool_2 = false;
			}
			else
			{
				this.bool_1 = true;
				this.bool_2 = false;
			}
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x000D138C File Offset: 0x000CF58C
		public override string ToString()
		{
			string result;
			if (this.bool_1)
			{
				result = "";
			}
			else if (!this.Value)
			{
				result = "false";
			}
			else
			{
				result = "true";
			}
			return result;
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x000D13C4 File Offset: 0x000CF5C4
		public override int GetHashCode()
		{
			int result;
			if (!this.Value)
			{
				result = 1237;
			}
			else
			{
				result = 1231;
			}
			return result;
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x000132BE File Offset: 0x000114BE
		public override bool Equals(object obj)
		{
			return obj != null && obj is Class2009 && this.Value == ((Class2009)obj).Value;
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x000D13E8 File Offset: 0x000CF5E8
		public int CompareTo(object target)
		{
			return this.Value.CompareTo(((Class2009)target).Value);
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x000D1410 File Offset: 0x000CF610
		public object Clone()
		{
			return new Class2009(this.Value);
		}

		// Token: 0x04000F1B RID: 3867
		protected bool bool_0;

		// Token: 0x04000F1C RID: 3868
		protected bool bool_1 = true;

		// Token: 0x04000F1D RID: 3869
		protected bool bool_2 = true;
	}
}
