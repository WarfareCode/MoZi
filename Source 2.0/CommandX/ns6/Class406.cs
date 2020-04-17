using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ns6
{
	// Token: 0x02000C87 RID: 3207
	public sealed class Class406<TPathNode, TUserContext> where TPathNode : Interface6<TUserContext>
	{
		// Token: 0x06006A42 RID: 27202 RVA: 0x0002DC54 File Offset: 0x0002BE54
		[CompilerGenerated]
		private void method_0(TPathNode[,] gparam_1)
		{
			this.gparam_0 = gparam_1;
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x00390ED4 File Offset: 0x0038F0D4
		[CompilerGenerated]
		public short method_1()
		{
			return this.short_0;
		}

		// Token: 0x06006A44 RID: 27204 RVA: 0x0002DC5D File Offset: 0x0002BE5D
		[CompilerGenerated]
		private void method_2(short short_2)
		{
			this.short_0 = short_2;
		}

		// Token: 0x06006A45 RID: 27205 RVA: 0x00390EEC File Offset: 0x0038F0EC
		[CompilerGenerated]
		public short method_3()
		{
			return this.short_1;
		}

		// Token: 0x06006A46 RID: 27206 RVA: 0x0002DC66 File Offset: 0x0002BE66
		[CompilerGenerated]
		private void method_4(short short_2)
		{
			this.short_1 = short_2;
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x00390F04 File Offset: 0x0038F104
		public Class406(TPathNode[,] gparam_1)
		{
			this.method_0(gparam_1);
			this.method_2((short)gparam_1.GetLength(0));
			this.method_4((short)gparam_1.GetLength(1));
			this.class407_1 = new Class406<TPathNode, TUserContext>.Class407[(int)this.method_1(), (int)this.method_3()];
			this.class408_0 = new Class406<TPathNode, TUserContext>.Class408((int)this.method_1(), (int)this.method_3());
			this.class408_1 = new Class406<TPathNode, TUserContext>.Class408((int)this.method_1(), (int)this.method_3());
			this.class407_0 = new Class406<TPathNode, TUserContext>.Class407[(int)this.method_1(), (int)this.method_3()];
			this.class408_2 = new Class406<TPathNode, TUserContext>.Class408((int)this.method_1(), (int)this.method_3());
			this.class405_0 = new Class405<Class406<TPathNode, TUserContext>.Class407>(Class406<TPathNode, TUserContext>.Class407.class407_0);
			for (short num = 0; num < this.method_1(); num += 1)
			{
				for (short num2 = 0; num2 < this.method_3(); num2 += 1)
				{
					if (gparam_1[(int)num, (int)num2] == null)
					{
						throw new ArgumentNullException(string.Concat(new object[]
						{
							"Null exception at grid X:",
							num,
							" - Y: ",
							num2
						}));
					}
					this.class407_1[(int)num, (int)num2] = new Class406<TPathNode, TUserContext>.Class407(num, num2, gparam_1[(int)num, (int)num2]);
				}
			}
		}

		// Token: 0x06006A48 RID: 27208 RVA: 0x00391050 File Offset: 0x0038F250
		protected  double vmethod_0(Class406<TPathNode, TUserContext>.Class407 class407_2, Class406<TPathNode, TUserContext>.Class407 class407_3)
		{
			return Math.Sqrt((double)((class407_2.method_8() - class407_3.method_8()) * (class407_2.method_8() - class407_3.method_8()) + (class407_2.method_10() - class407_3.method_10()) * (class407_2.method_10() - class407_3.method_10())));
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x0039109C File Offset: 0x0038F29C
		protected  double vmethod_1(Class406<TPathNode, TUserContext>.Class407 class407_2, Class406<TPathNode, TUserContext>.Class407 class407_3)
		{
			int num = Math.Abs(class407_2.method_8() - class407_3.method_8());
			int num2 = Math.Abs(class407_2.method_10() - class407_3.method_10());
			double result;
			switch (num + num2)
			{
			case 0:
				result = 0.0;
				break;
			case 1:
				result = 1.0;
				break;
			case 2:
				result = Class406<TPathNode, TUserContext>.double_0;
				break;
			default:
				throw new ApplicationException();
			}
			return result;
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x0039110C File Offset: 0x0038F30C
		public LinkedList<TPathNode> method_5(Point point_0, Point point_1, TUserContext gparam_1)
		{
			Class406<TPathNode, TUserContext>.Class407 @class = this.class407_1[point_0.X, point_0.Y];
			Class406<TPathNode, TUserContext>.Class407 class2 = this.class407_1[point_1.X, point_1.Y];
			LinkedList<TPathNode> result;
			if (@class == class2)
			{
				result = new LinkedList<TPathNode>(new TPathNode[]
				{
					@class.method_0()
				});
			}
			else
			{
				Class406<TPathNode, TUserContext>.Class407[] array = new Class406<TPathNode, TUserContext>.Class407[8];
				this.class408_0.method_10();
				this.class408_1.method_10();
				this.class408_2.method_10();
				this.class405_0.method_4();
				for (int i = 0; i < (int)this.method_1(); i++)
				{
					for (int j = 0; j < (int)this.method_3(); j++)
					{
						this.class407_0[i, j] = null;
					}
				}
				@class.method_3(0f);
				@class.method_5((float)this.vmethod_0(@class, class2));
				@class.method_7(@class.method_4());
				this.class408_1.method_7(@class);
				this.class405_0.method_1(@class);
				this.class408_2.method_7(@class);
				int num = 0;
				while (!this.class408_1.method_6())
				{
					Class406<TPathNode, TUserContext>.Class407 class3 = this.class405_0.method_2();
					if (class3 == class2)
					{
						LinkedList<TPathNode> linkedList = this.method_6(this.class407_0, this.class407_0[class2.method_8(), class2.method_10()]);
						linkedList.AddLast(class2.method_0());
						result = linkedList;
						return result;
					}
					this.class408_1.method_9(class3);
					this.class408_0.method_7(class3);
					this.method_8(class3, array);
					for (int k = 0; k < array.Length; k++)
					{
						Class406<TPathNode, TUserContext>.Class407 class4 = array[k];
						if (class4 != null)
						{
							TPathNode tPathNode = class4.method_0();
							if (tPathNode.imethod_0(gparam_1) && !this.class408_0.method_8(class4))
							{
								num++;
								double num2 = (double)this.class408_2[class3].method_2() + this.vmethod_1(class3, class4);
								bool flag = false;
								bool flag2;
								if (!this.class408_1.method_8(class4))
								{
									this.class408_1.method_7(class4);
									flag2 = true;
									flag = true;
								}
								else
								{
									flag2 = (num2 < (double)this.class408_2[class4].method_2());
								}
								if (flag2)
								{
									this.class407_0[class4.method_8(), class4.method_10()] = class3;
									if (!this.class408_2.method_8(class4))
									{
										this.class408_2.method_7(class4);
									}
									this.class408_2[class4].method_3((float)num2);
									this.class408_2[class4].method_5((float)this.vmethod_0(class4, class2));
									this.class408_2[class4].method_7(this.class408_2[class4].method_2() + this.class408_2[class4].method_4());
									if (flag)
									{
										this.class405_0.method_1(class4);
									}
									else
									{
										this.class405_0.method_3(class4);
									}
								}
							}
						}
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x00391458 File Offset: 0x0038F658
		private LinkedList<TPathNode> method_6(Class406<TPathNode, TUserContext>.Class407[,] class407_2, Class406<TPathNode, TUserContext>.Class407 class407_3)
		{
			LinkedList<TPathNode> linkedList = new LinkedList<TPathNode>();
			this.method_7(class407_2, class407_3, linkedList);
			return linkedList;
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x00391478 File Offset: 0x0038F678
		private void method_7(Class406<TPathNode, TUserContext>.Class407[,] class407_2, Class406<TPathNode, TUserContext>.Class407 class407_3, LinkedList<TPathNode> linkedList_0)
		{
			Class406<TPathNode, TUserContext>.Class407 @class = class407_2[class407_3.method_8(), class407_3.method_10()];
			if (@class != null)
			{
				this.method_7(class407_2, @class, linkedList_0);
				linkedList_0.AddLast(class407_3.method_0());
			}
			else
			{
				linkedList_0.AddLast(class407_3.method_0());
			}
		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x003914C4 File Offset: 0x0038F6C4
		private void method_8(Class406<TPathNode, TUserContext>.Class407 class407_2, Class406<TPathNode, TUserContext>.Class407[] class407_3)
		{
			int num = class407_2.method_8();
			int num2 = class407_2.method_10();
			if (num > 0 && num2 > 0)
			{
				class407_3[0] = this.class407_1[num - 1, num2 - 1];
			}
			else
			{
				class407_3[0] = null;
			}
			if (num2 > 0)
			{
				class407_3[1] = this.class407_1[num, num2 - 1];
			}
			else
			{
				class407_3[1] = null;
			}
			if (num < (int)(this.method_1() - 1) && num2 > 0)
			{
				class407_3[2] = this.class407_1[num + 1, num2 - 1];
			}
			else
			{
				class407_3[2] = null;
			}
			if (num > 0)
			{
				class407_3[3] = this.class407_1[num - 1, num2];
			}
			else
			{
				class407_3[3] = null;
			}
			if (num < (int)(this.method_1() - 1))
			{
				class407_3[4] = this.class407_1[num + 1, num2];
			}
			else
			{
				class407_3[4] = null;
			}
			if (num > 0 && num2 < (int)(this.method_3() - 1))
			{
				class407_3[5] = this.class407_1[num - 1, num2 + 1];
			}
			else
			{
				class407_3[5] = null;
			}
			if (num2 < (int)(this.method_3() - 1))
			{
				class407_3[6] = this.class407_1[num, num2 + 1];
			}
			else
			{
				class407_3[6] = null;
			}
			if (num < (int)(this.method_1() - 1) && num2 < (int)(this.method_3() - 1))
			{
				class407_3[7] = this.class407_1[num + 1, num2 + 1];
			}
			else
			{
				class407_3[7] = null;
			}
		}

		// Token: 0x04003BFF RID: 15359
		private Class406<TPathNode, TUserContext>.Class408 class408_0;

		// Token: 0x04003C00 RID: 15360
		private Class406<TPathNode, TUserContext>.Class408 class408_1;

		// Token: 0x04003C01 RID: 15361
		private Class405<Class406<TPathNode, TUserContext>.Class407> class405_0;

		// Token: 0x04003C02 RID: 15362
		private Class406<TPathNode, TUserContext>.Class407[,] class407_0;

		// Token: 0x04003C03 RID: 15363
		private Class406<TPathNode, TUserContext>.Class408 class408_2;

		// Token: 0x04003C04 RID: 15364
		private Class406<TPathNode, TUserContext>.Class407[,] class407_1;

		// Token: 0x04003C05 RID: 15365
		[CompilerGenerated]
		private TPathNode[,] gparam_0;

		// Token: 0x04003C06 RID: 15366
		[CompilerGenerated]
		private short short_0;

		// Token: 0x04003C07 RID: 15367
		[CompilerGenerated]
		private short short_1;

		// Token: 0x04003C08 RID: 15368
		private static readonly double double_0 = Math.Sqrt(2.0);

		// Token: 0x02000C88 RID: 3208
		protected sealed class Class407 : Interface6<TUserContext>, IComparer<Class406<TPathNode, TUserContext>.Class407>, Interface7
		{
			// Token: 0x06006A4F RID: 27215 RVA: 0x00391638 File Offset: 0x0038F838
			[CompilerGenerated]
			public TPathNode method_0()
			{
				return this.gparam_0;
			}

			// Token: 0x06006A50 RID: 27216 RVA: 0x0002DC84 File Offset: 0x0002BE84
			[CompilerGenerated]
			internal void method_1(TPathNode gparam_1)
			{
				this.gparam_0 = gparam_1;
			}

			// Token: 0x06006A51 RID: 27217 RVA: 0x00391650 File Offset: 0x0038F850
			[CompilerGenerated]
			public float method_2()
			{
				return this.float_0;
			}

			// Token: 0x06006A52 RID: 27218 RVA: 0x0002DC8D File Offset: 0x0002BE8D
			[CompilerGenerated]
			internal void method_3(float float_3)
			{
				this.float_0 = float_3;
			}

			// Token: 0x06006A53 RID: 27219 RVA: 0x00391668 File Offset: 0x0038F868
			[CompilerGenerated]
			public float method_4()
			{
				return this.float_1;
			}

			// Token: 0x06006A54 RID: 27220 RVA: 0x0002DC96 File Offset: 0x0002BE96
			[CompilerGenerated]
			internal void method_5(float float_3)
			{
				this.float_1 = float_3;
			}

			// Token: 0x06006A55 RID: 27221 RVA: 0x00391680 File Offset: 0x0038F880
			[CompilerGenerated]
			public float method_6()
			{
				return this.float_2;
			}

			// Token: 0x06006A56 RID: 27222 RVA: 0x0002DC9F File Offset: 0x0002BE9F
			[CompilerGenerated]
			internal void method_7(float float_3)
			{
				this.float_2 = float_3;
			}

			// Token: 0x06006A57 RID: 27223 RVA: 0x00391698 File Offset: 0x0038F898
			[CompilerGenerated]
			public int imethod_1()
			{
				return this.int_0;
			}

			// Token: 0x06006A58 RID: 27224 RVA: 0x0002DCA8 File Offset: 0x0002BEA8
			[CompilerGenerated]
			public void imethod_2(int int_3)
			{
				this.int_0 = int_3;
			}

			// Token: 0x06006A59 RID: 27225 RVA: 0x003916B0 File Offset: 0x0038F8B0
			public bool imethod_0(TUserContext gparam_1)
			{
				TPathNode tPathNode = this.method_0();
				return tPathNode.imethod_0(gparam_1);
			}

			// Token: 0x06006A5A RID: 27226 RVA: 0x003916D4 File Offset: 0x0038F8D4
			[CompilerGenerated]
			public int method_8()
			{
				return this.int_1;
			}

			// Token: 0x06006A5B RID: 27227 RVA: 0x0002DCB1 File Offset: 0x0002BEB1
			[CompilerGenerated]
			internal void method_9(int int_3)
			{
				this.int_1 = int_3;
			}

			// Token: 0x06006A5C RID: 27228 RVA: 0x003916EC File Offset: 0x0038F8EC
			[CompilerGenerated]
			public int method_10()
			{
				return this.int_2;
			}

			// Token: 0x06006A5D RID: 27229 RVA: 0x0002DCBA File Offset: 0x0002BEBA
			[CompilerGenerated]
			internal void method_11(int int_3)
			{
				this.int_2 = int_3;
			}

			// Token: 0x06006A5E RID: 27230 RVA: 0x00391704 File Offset: 0x0038F904
			public int Compare(Class406<TPathNode, TUserContext>.Class407 x, Class406<TPathNode, TUserContext>.Class407 y)
			{
				int result;
				if (x.method_6() < y.method_6())
				{
					result = -1;
				}
				else if (x.method_6() > y.method_6())
				{
					result = 1;
				}
				else
				{
					result = 0;
				}
				return result;
			}

			// Token: 0x06006A5F RID: 27231 RVA: 0x0002DCC3 File Offset: 0x0002BEC3
			public Class407(short short_0, short short_1, TPathNode gparam_1)
			{
				this.method_9((int)short_0);
				this.method_11((int)short_1);
				this.method_1(gparam_1);
			}

			// Token: 0x04003C09 RID: 15369
			public static readonly Class406<TPathNode, TUserContext>.Class407 class407_0 = new Class406<TPathNode, TUserContext>.Class407(0, 0, default(TPathNode));

			// Token: 0x04003C0A RID: 15370
			[CompilerGenerated]
			private TPathNode gparam_0;

			// Token: 0x04003C0B RID: 15371
			[CompilerGenerated]
			private float float_0;

			// Token: 0x04003C0C RID: 15372
			[CompilerGenerated]
			private float float_1;

			// Token: 0x04003C0D RID: 15373
			[CompilerGenerated]
			private float float_2 = 0f;

			// Token: 0x04003C0E RID: 15374
			[CompilerGenerated]
			private int int_0;

			// Token: 0x04003C0F RID: 15375
			[CompilerGenerated]
			private int int_1;

			// Token: 0x04003C10 RID: 15376
			[CompilerGenerated]
			private int int_2;
		}

		// Token: 0x02000C89 RID: 3209
		private sealed class Class408
		{
			// Token: 0x17000509 RID: 1289
			public Class406<TPathNode, TUserContext>.Class407 this[int int_3, int int_4]
			{
				get
				{
					return this.class407_0[int_3, int_4];
				}
			}

			// Token: 0x1700050A RID: 1290
			public Class406<TPathNode, TUserContext>.Class407 this[Class406<TPathNode, TUserContext>.Class407 class407_1]
			{
				get
				{
					return this.class407_0[class407_1.method_8(), class407_1.method_10()];
				}
			}

			// Token: 0x06006A63 RID: 27235 RVA: 0x003917AC File Offset: 0x0038F9AC
			[CompilerGenerated]
			public int method_0()
			{
				return this.int_0;
			}

			// Token: 0x06006A64 RID: 27236 RVA: 0x0002DCEB File Offset: 0x0002BEEB
			[CompilerGenerated]
			private void method_1(int int_3)
			{
				this.int_0 = int_3;
			}

			// Token: 0x06006A65 RID: 27237 RVA: 0x003917C4 File Offset: 0x0038F9C4
			[CompilerGenerated]
			public int method_2()
			{
				return this.int_1;
			}

			// Token: 0x06006A66 RID: 27238 RVA: 0x0002DCF4 File Offset: 0x0002BEF4
			[CompilerGenerated]
			private void method_3(int int_3)
			{
				this.int_1 = int_3;
			}

			// Token: 0x06006A67 RID: 27239 RVA: 0x003917DC File Offset: 0x0038F9DC
			[CompilerGenerated]
			public int method_4()
			{
				return this.int_2;
			}

			// Token: 0x06006A68 RID: 27240 RVA: 0x0002DCFD File Offset: 0x0002BEFD
			[CompilerGenerated]
			private void method_5(int int_3)
			{
				this.int_2 = int_3;
			}

			// Token: 0x06006A69 RID: 27241 RVA: 0x0002DD06 File Offset: 0x0002BF06
			public bool method_6()
			{
				return this.method_4() == 0;
			}

			// Token: 0x06006A6A RID: 27242 RVA: 0x0002DD11 File Offset: 0x0002BF11
			public Class408(int int_3, int int_4)
			{
				this.class407_0 = new Class406<TPathNode, TUserContext>.Class407[int_3, int_4];
				this.method_1(int_3);
				this.method_3(int_4);
			}

			// Token: 0x06006A6B RID: 27243 RVA: 0x003917F4 File Offset: 0x0038F9F4
			public void method_7(Class406<TPathNode, TUserContext>.Class407 class407_1)
			{
                Class406<TPathNode, TUserContext>.Class407 class1 = this.class407_0[class407_1.method_8(), class407_1.method_10()];
                int num = this.method_4();
                this.method_5(num + 1);
                this.class407_0[class407_1.method_8(), class407_1.method_10()] = class407_1;

            }

            // Token: 0x06006A6C RID: 27244 RVA: 0x0002DD34 File Offset: 0x0002BF34
            public bool method_8(Class406<TPathNode, TUserContext>.Class407 class407_1)
			{
				return this.class407_0[class407_1.method_8(), class407_1.method_10()] != null;
			}

			// Token: 0x06006A6D RID: 27245 RVA: 0x00391844 File Offset: 0x0038FA44
			public void method_9(Class406<TPathNode, TUserContext>.Class407 class407_1)
			{
                Class406<TPathNode, TUserContext>.Class407 class1 = this.class407_0[class407_1.method_8(), class407_1.method_10()];
                int num = this.method_4();
                this.method_5(num - 1);
                this.class407_0[class407_1.method_8(), class407_1.method_10()] = null;
            }

			// Token: 0x06006A6E RID: 27246 RVA: 0x00391894 File Offset: 0x0038FA94
			public void method_10()
			{
				this.method_5(0);
				for (int i = 0; i < this.method_0(); i++)
				{
					for (int j = 0; j < this.method_2(); j++)
					{
						this.class407_0[i, j] = null;
					}
				}
			}

			// Token: 0x04003C11 RID: 15377
			private Class406<TPathNode, TUserContext>.Class407[,] class407_0;

			// Token: 0x04003C12 RID: 15378
			[CompilerGenerated]
			private int int_0;

			// Token: 0x04003C13 RID: 15379
			[CompilerGenerated]
			private int int_1;

			// Token: 0x04003C14 RID: 15380
			[CompilerGenerated]
			private int int_2;
		}
	}
}
