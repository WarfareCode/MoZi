using System;
using System.Text;
using ns16;

namespace ns25
{
	// Token: 0x020005CF RID: 1487
	public sealed class Class2224
	{
		// Token: 0x170002B9 RID: 697
		public  LocationType this[Enum158 enum158_0]
		{
			get
			{
				return this.vmethod_2(enum158_0);
			}
			set
			{
				this.vmethod_5(enum158_0, value);
			}
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x00015840 File Offset: 0x00013A40
		public Class2224(LocationType enum157_1, LocationType enum157_2, LocationType enum157_3)
		{
			this.method_0(3);
			this.enum157_0[0] = enum157_1;
			this.enum157_0[1] = enum157_2;
			this.enum157_0[2] = enum157_3;
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x0001586A File Offset: 0x00013A6A
		public Class2224(LocationType enum157_1)
		{
			this.method_0(1);
			this.enum157_0[0] = enum157_1;
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x000E9284 File Offset: 0x000E7484
		public Class2224(Class2224 class2224_0)
		{
			if (class2224_0 != null)
			{
				this.method_0(class2224_0.enum157_0.Length);
				for (int i = 0; i < this.enum157_0.Length; i++)
				{
					this.enum157_0[i] = class2224_0.enum157_0[i];
				}
			}
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x000E92D4 File Offset: 0x000E74D4
		public   bool vmethod_0()
		{
			bool result;
			for (int i = 0; i < this.enum157_0.Length; i++)
			{
				if (this.enum157_0[i] != LocationType.Null)
				{
					result = false;
					return result;
				}
			}
			result = true;
			return result;
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00015882 File Offset: 0x00013A82
		public   bool vmethod_1()
		{
			return this.enum157_0.Length > 1;
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x0001588F File Offset: 0x00013A8F
		private void method_0(int int_0)
		{
			this.enum157_0 = new LocationType[int_0];
			this.vmethod_4(LocationType.Null);
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x000E930C File Offset: 0x000E750C
		public  LocationType vmethod_2(Enum158 enum158_0)
		{
			LocationType result;
			if (enum158_0 < (Enum158)this.enum157_0.Length)
			{
				result = this.enum157_0[(int)enum158_0];
			}
			else
			{
				result = LocationType.Null;
			}
			return result;
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x000E9338 File Offset: 0x000E7538
		public  void vmethod_3()
		{
			if (this.enum157_0.Length > 1)
			{
				LocationType locationType = this.enum157_0[1];
				this.enum157_0[1] = this.enum157_0[2];
				this.enum157_0[2] = locationType;
			}
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x000E9374 File Offset: 0x000E7574
		public  void vmethod_4(LocationType enum157_1)
		{
			for (int i = 0; i < this.enum157_0.Length; i++)
			{
				this.enum157_0[i] = enum157_1;
			}
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x000158A4 File Offset: 0x00013AA4
		public  void vmethod_5(Enum158 enum158_0, LocationType enum157_1)
		{
			this.enum157_0[(int)enum158_0] = enum157_1;
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x000158AF File Offset: 0x00013AAF
		public  void vmethod_6(LocationType enum157_1)
		{
			this.vmethod_5(Enum158.const_0, enum157_1);
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x000158B9 File Offset: 0x00013AB9
		public  void vmethod_7(LocationType enum157_1, LocationType enum157_2, LocationType enum157_3)
		{
			this.enum157_0[0] = enum157_1;
			this.enum157_0[1] = enum157_2;
			this.enum157_0[2] = enum157_3;
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x000E93A0 File Offset: 0x000E75A0
		public  void vmethod_8(Class2224 class2224_0)
		{
			if (class2224_0.enum157_0.Length > this.enum157_0.Length)
			{
				this.enum157_0 = new LocationType[]
				{
					this.enum157_0[0],
					LocationType.Null,
					LocationType.Null
				};
			}
			for (int i = 0; i < this.enum157_0.Length; i++)
			{
				if (this.enum157_0[i] == LocationType.Null && i < class2224_0.enum157_0.Length)
				{
					this.enum157_0[i] = class2224_0.enum157_0[i];
				}
			}
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x000E9428 File Offset: 0x000E7628
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.enum157_0.Length > 1)
			{
				stringBuilder.Append(Class2226.smethod_0(this.enum157_0[1]));
			}
			stringBuilder.Append(Class2226.smethod_0(this.enum157_0[0]));
			if (this.enum157_0.Length > 1)
			{
				stringBuilder.Append(Class2226.smethod_0(this.enum157_0[2]));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04001239 RID: 4665
		private LocationType[] enum157_0;
	}
}
