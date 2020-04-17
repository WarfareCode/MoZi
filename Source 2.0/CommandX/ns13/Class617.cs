using System;
using System.ComponentModel;

namespace ns13
{
	// Token: 0x020003CB RID: 971
	public sealed class Class617 : PropertyDescriptor
	{
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x00096508 File Offset: 0x00094708
		public override Type ComponentType
		{
			get
			{
				return typeof(Struct58);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00096524 File Offset: 0x00094724
		public override Type PropertyType
		{
			get
			{
				return this.class642_0.method_8();
			}
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x000100F1 File Offset: 0x0000E2F1
		public Class617(Class642 class642_1, int int_1) : base(class642_1.method_0(), null)
		{
			this.class642_0 = class642_1;
			this.int_0 = int_1;
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x000081A2 File Offset: 0x000063A2
		public override bool CanResetValue(object component)
		{
			return false;
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void ResetValue(object component)
		{
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x000081A2 File Offset: 0x000063A2
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void SetValue(object component, object value)
		{
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00096540 File Offset: 0x00094740
		public override object GetValue(object component)
		{
			return ((Struct58)component).method_0()[this.int_0];
		}

		// Token: 0x040009E8 RID: 2536
		private Class642 class642_0;

		// Token: 0x040009E9 RID: 2537
		private int int_0;
	}
}
