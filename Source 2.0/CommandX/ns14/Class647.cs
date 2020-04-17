using System;
using System.Collections;
using GeoAPI.Geometries;
using ns12;
using ns13;

namespace ns14
{
	// Token: 0x02000448 RID: 1096
	public sealed class Class647
	{
		// Token: 0x06001C17 RID: 7191 RVA: 0x000119AD File Offset: 0x0000FBAD
		public static bool smethod_0(int int_2, int int_3)
		{
			return Math.Abs(int_2 - int_3) == 1;
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x000B4418 File Offset: 0x000B2618
		public Class647(Class596 class596_1, bool bool_5, bool bool_6)
		{
			this.class596_0 = class596_1;
			this.bool_3 = bool_5;
			this.bool_4 = bool_6;
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x000119BA File Offset: 0x0000FBBA
		public void method_0(ICollection icollection_1, ICollection icollection_2)
		{
			this.icollection_0 = new ICollection[2];
			this.icollection_0[0] = icollection_1;
			this.icollection_0[1] = icollection_2;
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x000119DA File Offset: 0x0000FBDA
		public bool method_1()
		{
			return this.bool_1;
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x000119E2 File Offset: 0x0000FBE2
		public bool method_2()
		{
			return this.bool_2;
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x000B446C File Offset: 0x000B266C
		private bool method_3(Class581 class581_0, int int_2, Class581 class581_1, int int_3)
		{
			bool result;
			if (object.ReferenceEquals(class581_0, class581_1) && this.class596_0.method_5() == 1)
			{
				if (Class647.smethod_0(int_2, int_3))
				{
					result = true;
					return result;
				}
				if (class581_0.method_9())
				{
					int num = class581_0.method_4() - 1;
					if ((int_2 == 0 && int_3 == num) || (int_3 == 0 && int_2 == num))
					{
						result = true;
						return result;
					}
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x000B44F0 File Offset: 0x000B26F0
		public void method_4(Class581 class581_0, int int_2, Class581 class581_1, int int_3)
		{
			if (!object.ReferenceEquals(class581_0, class581_1) || int_2 != int_3)
			{
				this.int_1++;
				ICoordinate icoordinate_ = class581_0.method_5()[int_2];
				ICoordinate icoordinate_2 = class581_0.method_5()[int_2 + 1];
				ICoordinate icoordinate_3 = class581_1.method_5()[int_3];
				ICoordinate icoordinate_4 = class581_1.method_5()[int_3 + 1];
				this.class596_0.method_2(icoordinate_, icoordinate_2, icoordinate_3, icoordinate_4);
				if (this.class596_0.method_4())
				{
					if (this.bool_4)
					{
						class581_0.method_10(false);
						class581_1.method_10(false);
					}
					this.int_0++;
					if (!this.method_3(class581_0, int_2, class581_1, int_3))
					{
						this.bool_0 = true;
						if (this.bool_3 || !this.class596_0.method_8())
						{
							class581_0.method_11(this.class596_0, int_2, 0);
							class581_1.method_11(this.class596_0, int_3, 1);
						}
						if (this.class596_0.method_8())
						{
							this.icoordinate_0 = (ICoordinate)this.class596_0.method_6(0).Clone();
							this.bool_1 = true;
							if (!this.method_5(this.class596_0, this.icollection_0))
							{
								this.bool_2 = true;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x000119EA File Offset: 0x0000FBEA
		private bool method_5(Class596 class596_1, ICollection[] icollection_1)
		{
			return icollection_1 != null && (this.method_6(class596_1, icollection_1[0]) || this.method_6(class596_1, icollection_1[1]));
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x000B4630 File Offset: 0x000B2830
		private bool method_6(Class596 class596_1, ICollection icollection_1)
		{
			IEnumerator enumerator = icollection_1.GetEnumerator();
			bool result;
			while (enumerator.MoveNext())
			{
				Class579 @class = (Class579)enumerator.Current;
				ICoordinate icoordinate_ = @class.vmethod_0();
				if (class596_1.method_7(icoordinate_))
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x04000C41 RID: 3137
		private bool bool_0 = false;

		// Token: 0x04000C42 RID: 3138
		private bool bool_1 = false;

		// Token: 0x04000C43 RID: 3139
		private bool bool_2 = false;

		// Token: 0x04000C44 RID: 3140
		private ICoordinate icoordinate_0 = null;

		// Token: 0x04000C45 RID: 3141
		private Class596 class596_0;

		// Token: 0x04000C46 RID: 3142
		private bool bool_3;

		// Token: 0x04000C47 RID: 3143
		private bool bool_4;

		// Token: 0x04000C48 RID: 3144
		private int int_0 = 0;

		// Token: 0x04000C49 RID: 3145
		public int int_1 = 0;

		// Token: 0x04000C4A RID: 3146
		private ICollection[] icollection_0;
	}
}
