using System;
using System.Collections;
using System.Collections.Generic;
using GeoAPI.Geometries;

namespace ns13
{
	// Token: 0x02000405 RID: 1029
	public sealed class Class636 : IDisposable, IEnumerator<Class636.Class637>, IEnumerable<Class636.Class637>, IEnumerable, IEnumerator
	{
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x0009DEBC File Offset: 0x0009C0BC
		public Class636.Class637 Current
		{
			get
			{
				return this.class637_0;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x0009DED4 File Offset: 0x0009C0D4
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00010B34 File Offset: 0x0000ED34
		private void method_0()
		{
			if (this.int_1 >= this.int_0)
			{
				this.ilineString_0 = null;
			}
			else
			{
				this.ilineString_0 = (ILineString)this.igeometry_0.imethod_9(this.int_1);
			}
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00010B6B File Offset: 0x0000ED6B
		protected bool method_1()
		{
			return this.int_1 < this.int_0 && (this.int_1 != this.int_0 - 1 || this.int_2 < this.ilineString_0.imethod_3());
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x0009DEEC File Offset: 0x0009C0EC
		protected void method_2()
		{
			if (this.method_1())
			{
				this.int_2++;
				if (this.int_2 >= this.ilineString_0.imethod_3())
				{
					this.int_1++;
					this.method_0();
					this.int_2 = 0;
				}
			}
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00010BA4 File Offset: 0x0000EDA4
		public bool MoveNext()
		{
			if (this.method_1())
			{
				if (this.bool_0)
				{
					this.bool_0 = false;
				}
				else
				{
					this.method_2();
				}
			}
			return this.method_1();
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00010BD1 File Offset: 0x0000EDD1
		public void Reset()
		{
			this.int_0 = this.igeometry_0.imethod_2();
			this.int_1 = this.int_3;
			this.int_2 = this.int_4;
			this.method_0();
			this.bool_0 = true;
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00010C09 File Offset: 0x0000EE09
		public void Dispose()
		{
			this.method_3(false);
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00010C12 File Offset: 0x0000EE12
		protected void method_3(bool bool_1)
		{
			if (bool_1)
			{
			}
			this.class637_0 = null;
			this.ilineString_0 = null;
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0009DF44 File Offset: 0x0009C144
		public IEnumerator<Class636.Class637> GetEnumerator()
		{
			return this;
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x0009DF54 File Offset: 0x0009C154
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000A95 RID: 2709
		private IGeometry igeometry_0;

		// Token: 0x04000A96 RID: 2710
		private int int_0;

		// Token: 0x04000A97 RID: 2711
		private ILineString ilineString_0;

		// Token: 0x04000A98 RID: 2712
		private int int_1;

		// Token: 0x04000A99 RID: 2713
		private int int_2 = 0;

		// Token: 0x04000A9A RID: 2714
		private bool bool_0;

		// Token: 0x04000A9B RID: 2715
		private Class636.Class637 class637_0;

		// Token: 0x04000A9C RID: 2716
		private readonly int int_3 = 0;

		// Token: 0x04000A9D RID: 2717
		private readonly int int_4;

		// Token: 0x02000406 RID: 1030
		public sealed class Class637
		{
		}
	}
}
