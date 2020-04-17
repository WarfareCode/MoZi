using System;
using System.Collections.Generic;
using System.Text;
using DotSpatial.Topology;
using ns25;

namespace ns24
{
	// Token: 0x02000568 RID: 1384
	public sealed class Class2199 : Class2198
	{
		// Token: 0x060023C1 RID: 9153 RVA: 0x00014B45 File Offset: 0x00012D45
		public Class2199(IList<Coordinate> ilist_1, Class2217 class2217_1)
		{
			this.class2203_0 = new Class2203(this);
			this.ilist_0 = ilist_1;
			base.vmethod_1(class2217_1);
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x000E0BF0 File Offset: 0x000DEDF0
		public  IList<Coordinate> vmethod_6()
		{
			return this.ilist_0;
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x000E0C08 File Offset: 0x000DEE08
		public  int vmethod_7()
		{
			return this.ilist_0.Count;
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x000E0BF0 File Offset: 0x000DEDF0
		public  IList<Coordinate> vmethod_8()
		{
			return this.ilist_0;
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x000E0C24 File Offset: 0x000DEE24
		public override Coordinate vmethod_5()
		{
			Coordinate result;
			if (this.vmethod_6().Count <= 0)
			{
				result = Coordinate.GetEmpty();
			}
			else
			{
				result = this.vmethod_6()[0];
			}
			return result;
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x000E0C58 File Offset: 0x000DEE58
		public  Envelope vmethod_9()
		{
			if (this.envelope_0 == null)
			{
				this.envelope_0 = new Envelope();
				for (int i = 0; i < this.vmethod_6().Count; i++)
				{
					Class2183.smethod_12(this.envelope_0, this.vmethod_6()[i]);
				}
			}
			return this.envelope_0;
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x000E0CB8 File Offset: 0x000DEEB8
		public  int vmethod_10()
		{
			return this.int_0;
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x00014B79 File Offset: 0x00012D79
		public  void vmethod_11(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x000E0CD0 File Offset: 0x000DEED0
		public  Class2203 vmethod_12()
		{
			return this.class2203_0;
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x000E0CE8 File Offset: 0x000DEEE8
		public  Class2213 vmethod_13()
		{
			if (this.class2213_0 == null)
			{
				this.class2213_0 = new Class2213(this);
			}
			return this.class2213_0;
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x00014B82 File Offset: 0x00012D82
		public   bool vmethod_14()
		{
			return this.vmethod_6()[0].Equals(this.vmethod_6()[this.vmethod_6().Count - 1]);
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x00014BAD File Offset: 0x00012DAD
		public  void vmethod_15(bool bool_3)
		{
			this.bool_2 = bool_3;
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x000E0D18 File Offset: 0x000DEF18
		public  Coordinate vmethod_16(int int_1)
		{
			return this.vmethod_6()[int_1];
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x000E0D34 File Offset: 0x000DEF34
		public  void vmethod_17(LineIntersector class2239_0, int int_1, int int_2)
		{
			for (int i = 0; i < class2239_0.vmethod_11(); i++)
			{
				this.vmethod_18(class2239_0, int_1, int_2, i);
			}
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x000E0D60 File Offset: 0x000DEF60
		public  void vmethod_18(LineIntersector class2239_0, int int_1, int int_2, int int_3)
		{
			Coordinate coordinate = new Coordinate(class2239_0.GetIntersection(int_3));
			int num = int_1;
			double double_ = class2239_0.vmethod_9(int_2, int_3);
			int num2 = num + 1;
			if (num2 < this.vmethod_6().Count)
			{
				Coordinate b = this.vmethod_6()[num2];
				if (coordinate.Equals2D(b))
				{
					num = num2;
					double_ = 0.0;
				}
				this.vmethod_12().vmethod_0(coordinate, num, double_);
			}
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x00014BB6 File Offset: 0x00012DB6
		public override bool Equals(object obj)
		{
			return obj != null && obj is Class2199 && this.vmethod_19(obj as Class2199);
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x000E0DD4 File Offset: 0x000DEFD4
		protected  bool vmethod_19(Class2199 class2199_0)
		{
			bool result;
			if (this.vmethod_6().Count != class2199_0.vmethod_6().Count)
			{
				result = false;
			}
			else
			{
				bool flag = true;
				bool flag2 = true;
				int num = this.vmethod_6().Count;
				for (int i = 0; i < this.vmethod_6().Count; i++)
				{
					if (!this.vmethod_6()[i].Equals2D(class2199_0.vmethod_6()[i]))
					{
						flag = false;
					}
					if (!this.vmethod_6()[i].Equals2D(class2199_0.vmethod_6()[--num]))
					{
						flag2 = false;
					}
					if (!flag && !flag2)
					{
						result = false;
						return result;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x00004A84 File Offset: 0x00002C84
		public static bool smethod_0(Class2199 class2199_0, Class2199 class2199_1)
		{
			return object.Equals(class2199_0, class2199_1);
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00014BD2 File Offset: 0x00012DD2
		public static bool smethod_1(Class2199 class2199_0, Class2199 class2199_1)
		{
			return !Class2199.smethod_0(class2199_0, class2199_1);
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0005CD70 File Offset: 0x0005AF70
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x000E0E88 File Offset: 0x000DF088
		public   bool vmethod_20(Class2199 class2199_0)
		{
			bool result;
			if (this.vmethod_6().Count != class2199_0.vmethod_6().Count)
			{
				result = false;
			}
			else
			{
				for (int i = 0; i < this.vmethod_6().Count; i++)
				{
					if (!this.vmethod_6()[i].Equals2D(class2199_0.vmethod_6()[i]))
					{
						result = false;
						return result;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x000E0EF4 File Offset: 0x000DF0F4
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("edge " + this.string_0 + ": ");
			stringBuilder.Append("LINESTRING (");
			for (int i = 0; i < this.vmethod_6().Count; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(",");
				}
				stringBuilder.Append(this.vmethod_6()[i].X + " " + this.vmethod_6()[i].Y);
			}
			stringBuilder.Append(string.Concat(new object[]
			{
				")  ",
				this.vmethod_0(),
				" ",
				this.int_0
			}));
			return stringBuilder.ToString();
		}

		// Token: 0x04001146 RID: 4422
		private readonly Class2191 class2191_0 = new Class2191();

		// Token: 0x04001147 RID: 4423
		private readonly Class2203 class2203_0;

		// Token: 0x04001148 RID: 4424
		private int int_0;

		// Token: 0x04001149 RID: 4425
		private Envelope envelope_0;

		// Token: 0x0400114A RID: 4426
		private bool bool_2 = true;

		// Token: 0x0400114B RID: 4427
		private Class2213 class2213_0;

		// Token: 0x0400114C RID: 4428
		private string string_0;

		// Token: 0x0400114D RID: 4429
		private IList<Coordinate> ilist_0;
	}
}
