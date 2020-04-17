using System;

namespace ns12
{
	// Token: 0x020003B9 RID: 953
	public sealed class Class609
	{
		// Token: 0x06001784 RID: 6020 RVA: 0x00092A10 File Offset: 0x00090C10
		public double method_0()
		{
			return (this.double_0 + this.double_1) / 2.0;
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00092A38 File Offset: 0x00090C38
		public override bool Equals(object obj)
		{
			bool result;
			if (!(obj is Class609))
			{
				result = false;
			}
			else
			{
				Class609 @class = (Class609)obj;
				result = (this.double_0 == @class.double_0 && this.double_1 == @class.double_1);
			}
			return result;
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x0005CD70 File Offset: 0x0005AF70
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x040009AD RID: 2477
		private double double_0;

		// Token: 0x040009AE RID: 2478
		private double double_1;
	}
}
