using System;
using System.Collections;
using System.Drawing;
using Microsoft.DirectX.Direct3D;
using ns16;
using ns19;

namespace ns18
{
	// Token: 0x0200038B RID: 907
	public sealed class ProjectedVectorRenderer
	{
		// Token: 0x060015D1 RID: 5585 RVA: 0x0008CBF0 File Offset: 0x0008ADF0
		public Class1954[] method_0()
		{
			return (Class1954[])this.arrayList_0.ToArray(typeof(Class1954));
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0008CC1C File Offset: 0x0008AE1C
		public Class1950[] method_1()
		{
			return (Class1950[])this.arrayList_1.ToArray(typeof(Class1950));
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x0008CC48 File Offset: 0x0008AE48
		public ProjectedVectorRenderer(World class1995_1)
		{
			this.class1995_0 = class1995_1;
			this.method_2();
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x0008CCB0 File Offset: 0x0008AEB0
		private void method_2()
		{
			int num = (int)(180.0 / this.double_0);
			ArrayList arrayList = new ArrayList();
			int num2 = num;
			int num3 = 0;
			int num4 = num * 2;
			for (int i = 0; i < num2; i++)
			{
				for (int j = num3; j < num4; j++)
				{
					double double_ = (double)(i + 1) * this.double_0 - 90.0;
					double double_2 = (double)i * this.double_0 - 90.0;
					double double_3 = (double)j * this.double_0 - 180.0;
					double double_4 = (double)(j + 1) * this.double_0 - 180.0;
					arrayList.Add(new ProjectedVectorTile(new GeographicBoundingBox(double_, double_2, double_3, double_4), this)
					{
						int_0 = 0,
						int_1 = i,
						int_2 = j
					});
				}
			}
			this.class1956_0 = (ProjectedVectorTile[])arrayList.ToArray(typeof(ProjectedVectorTile));
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0008CDC0 File Offset: 0x0008AFC0
		public void method_3(DrawArgs class1943_0)
		{
			for (int i = 0; i < this.arrayList_1.Count; i++)
			{
				Class1950 @class = (Class1950)this.arrayList_1[i];
				bool flag = false;
				if (@class.bool_1)
				{
					this.arrayList_1.RemoveAt(i);
					this.dateTime_0 = DateTime.Now;
					i--;
				}
				else if (@class.class1993_0 != null && (flag = ProjectedVectorRenderer.smethod_0(@class.class1993_0)) != @class.bool_0)
				{
					@class.bool_0 = flag;
					this.dateTime_0 = DateTime.Now;
				}
			}
			for (int j = 0; j < this.arrayList_0.Count; j++)
			{
				Class1954 class2 = (Class1954)this.arrayList_0[j];
				bool bool_ = false;
				if (class2.bool_3)
				{
					this.arrayList_0.RemoveAt(j);
					this.dateTime_0 = DateTime.Now;
					j--;
				}
				else if (class2.class1993_0 != null && (bool_ = ProjectedVectorRenderer.smethod_0(class2.class1993_0)) != class2.bool_2)
				{
					class2.bool_2 = bool_;
					this.dateTime_0 = DateTime.Now;
				}
			}
			ProjectedVectorTile[] array = this.class1956_0;
			for (int k = 0; k < array.Length; k++)
			{
				array[k].method_8(class1943_0);
			}
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x0000F191 File Offset: 0x0000D391
		private static bool smethod_0(RenderableObject class1993_0)
		{
			return class1993_0.IsOn() && (class1993_0.ParentList == null || ProjectedVectorRenderer.smethod_0(class1993_0.ParentList));
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x0008CF14 File Offset: 0x0008B114
		public void method_4(DrawArgs class1943_0)
		{
			class1943_0.device_0.Clear(ClearFlags.ZBuffer, 0, 1f, 0);
			ProjectedVectorTile[] array = this.class1956_0;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].method_9(class1943_0);
			}
		}

		// Token: 0x04000912 RID: 2322
		private ProjectedVectorTile[] class1956_0;

		// Token: 0x04000913 RID: 2323
		private double double_0 = 36.0;

		// Token: 0x04000914 RID: 2324
		public bool bool_0;

		// Token: 0x04000915 RID: 2325
		public World class1995_0;

		// Token: 0x04000916 RID: 2326
		public Size size_0 = new Size(256, 256);

		// Token: 0x04000917 RID: 2327
		private ArrayList arrayList_0 = new ArrayList();

		// Token: 0x04000918 RID: 2328
		private ArrayList arrayList_1 = new ArrayList();

		// Token: 0x04000919 RID: 2329
		public DateTime dateTime_0 = DateTime.Now;
	}
}
