using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;

namespace ns16
{
	// Token: 0x020004EF RID: 1263
	public sealed class Class2182 : ICollection<Coordinate>, IEnumerable<Coordinate>, IEnumerable, ICloneable
	{
		// Token: 0x1700025B RID: 603
		public  Coordinate this[int int_1]
		{
			get
			{
				return this.list_0[int_1];
			}
			set
			{
				this.list_0[int_1] = value;
				this.method_1();
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x000D5774 File Offset: 0x000D3974
		public int Count
		{
			get
			{
				return this.list_0.Count;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060020EC RID: 8428 RVA: 0x000081A2 File Offset: 0x000063A2
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x00013C98 File Offset: 0x00011E98
		public Class2182()
		{
			this.method_0(new List<Coordinate>());
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000D5790 File Offset: 0x000D3990
		public Class2182(IEnumerable<Coordinate> ienumerable_0)
		{
			List<Coordinate> list = ienumerable_0 as List<Coordinate>;
			if (list == null)
			{
				list = new List<Coordinate>();
				foreach (Coordinate current in ienumerable_0)
				{
					list.Add(current);
				}
			}
			this.method_0(list);
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x00013CAB File Offset: 0x00011EAB
		private void method_0(List<Coordinate> list_1)
		{
			this.list_0 = list_1;
			this.int_0 = 0;
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00013CBB File Offset: 0x00011EBB
		public void Add(Coordinate item)
		{
			this.list_0.Add(item);
			this.method_1();
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00013CCF File Offset: 0x00011ECF
		public void Clear()
		{
			this.list_0 = new List<Coordinate>();
			this.method_1();
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x000D5800 File Offset: 0x000D3A00
		public object Clone()
		{
			return new Class2182(this.list_0);
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00013CE2 File Offset: 0x00011EE2
		public bool Contains(Coordinate item)
		{
			return this.list_0.Contains(item);
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00013CF0 File Offset: 0x00011EF0
		public void CopyTo(Coordinate[] array, int arrayIndex)
		{
			this.list_0.CopyTo(array, arrayIndex);
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x000D581C File Offset: 0x000D3A1C
		public IEnumerator<Coordinate> GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x000D583C File Offset: 0x000D3A3C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00013CFF File Offset: 0x00011EFF
		public bool Remove(Coordinate item)
		{
			this.method_1();
			return this.list_0.Remove(item);
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00013D13 File Offset: 0x00011F13
		private void method_1()
		{
			if (this.int_0 == 2147483647)
			{
				this.int_0 = -2147483648;
			}
			else
			{
				this.int_0++;
			}
		}

		// Token: 0x04000FE6 RID: 4070
		private List<Coordinate> list_0;

		// Token: 0x04000FE7 RID: 4071
		private int int_0;
	}
}
