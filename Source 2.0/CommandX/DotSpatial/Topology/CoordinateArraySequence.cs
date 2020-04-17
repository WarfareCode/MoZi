using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotSpatial.Topology
{
	// Token: 0x020004E3 RID: 1251
	[Serializable]
	public sealed class CoordinateArraySequence : ICollection<Coordinate>, IEnumerable<Coordinate>, IEnumerable, ICloneable
	{
		// Token: 0x17000251 RID: 593
		public  Coordinate this[int index]
		{
			get
			{
				return this._coordinates[index];
			}
			set
			{
				this._coordinates[index] = value;
				this.IncrementVersion();
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06002098 RID: 8344 RVA: 0x000D4CF4 File Offset: 0x000D2EF4
		public  int Count
		{
			get
			{
				return this._coordinates.Length;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x000081A2 File Offset: 0x000063A2
		public  bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x000139F2 File Offset: 0x00011BF2
		private void IncrementVersion()
		{
			if (this._versionId == 2147483647)
			{
				this._versionId = -2147483648;
			}
			else
			{
				this._versionId++;
			}
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x000D4D0C File Offset: 0x000D2F0C
		public CoordinateArraySequence()
		{
			this.Configure(new Coordinate[]
			{
				new Coordinate()
			});
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x000D4D38 File Offset: 0x000D2F38
		public CoordinateArraySequence(Coordinate[] coordinates)
		{
			Coordinate[] coordinate_ = coordinates ?? new Coordinate[]
			{
				new Coordinate()
			};
			this.Configure(coordinate_);
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x00013A21 File Offset: 0x00011C21
		private void Configure(Coordinate[] coordinate_0)
		{
			this._coordinates = coordinate_0;
			this._versionId = 0;
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x000D4D68 File Offset: 0x000D2F68
		public  void Add(Coordinate item)
		{
			Coordinate[] array = new Coordinate[this._coordinates.Length + 1];
			this._coordinates.CopyTo(array, 0);
			array[this._coordinates.Length] = item;
			this.IncrementVersion();
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x00013A31 File Offset: 0x00011C31
		public  void Clear()
		{
			this._coordinates = new Coordinate[1];
			this._coordinates[0] = new Coordinate();
			this.IncrementVersion();
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x000D4DA4 File Offset: 0x000D2FA4
		public  bool Contains(Coordinate item)
		{
			Coordinate[] coordinates = this._coordinates;
			bool result;
			for (int i = 0; i < coordinates.Length; i++)
			{
				Coordinate coordinate_ = coordinates[i];
				if (Coordinate.Equals(coordinate_, item))
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x000D4DE0 File Offset: 0x000D2FE0
		public  object Clone()
		{
			Coordinate[] array = new Coordinate[this.Count];
			for (int i = 0; i < this._coordinates.Length; i++)
			{
				array[i] = new Coordinate(this._coordinates[i]);
			}
			return new CoordinateArraySequence(array);
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00013A52 File Offset: 0x00011C52
		public  void CopyTo(Coordinate[] array, int arrayIndex)
		{
			this._coordinates.CopyTo(array, arrayIndex);
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x000D4E28 File Offset: 0x000D3028
		public  IEnumerator<Coordinate> GetEnumerator()
		{
			return new CoordinateArraySequence.Enumerator(this._coordinates.GetEnumerator());
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x000D4E48 File Offset: 0x000D3048
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this._coordinates.GetEnumerator();
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x000D4E64 File Offset: 0x000D3064
		public  bool Remove(Coordinate item)
		{
			Coordinate[] array = new Coordinate[this._coordinates.Length - 1];
			bool flag = false;
			for (int i = 0; i < this._coordinates.Length; i++)
			{
				if (Coordinate.Equals(item, this._coordinates[i]) && !flag)
				{
					flag = true;
				}
				else if (flag)
				{
					array[i - 1] = this._coordinates[i];
				}
				else
				{
					array[i] = this._coordinates[i];
				}
			}
			if (flag)
			{
				this._coordinates = array;
			}
			return flag;
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x000D4EE0 File Offset: 0x000D30E0
		public override string ToString()
		{
			string result;
			if (this._coordinates.Length > 0)
			{
				StringBuilder stringBuilder = new StringBuilder(17 * this._coordinates.Length);
				stringBuilder.Append('(');
				stringBuilder.Append(this._coordinates[0]);
				for (int i = 1; i < this._coordinates.Length; i++)
				{
					stringBuilder.Append(", ");
					stringBuilder.Append(this._coordinates[i]);
				}
				stringBuilder.Append(')');
				result = stringBuilder.ToString();
			}
			else
			{
				result = "()";
			}
			return result;
		}

		// Token: 0x04000FD0 RID: 4048
		private Coordinate[] _coordinates;

		// Token: 0x04000FD1 RID: 4049
		private int _versionId;

		// Token: 0x020004E4 RID: 1252
		public sealed class Enumerator : IDisposable, IEnumerator<Coordinate>, IEnumerator
		{
			// Token: 0x17000254 RID: 596
			// (get) Token: 0x060020A7 RID: 8359 RVA: 0x000D4F70 File Offset: 0x000D3170
			public Coordinate Current
			{
				get
				{
					return this._baseEnumerator.Current as Coordinate;
				}
			}

			// Token: 0x17000255 RID: 597
			// (get) Token: 0x060020A8 RID: 8360 RVA: 0x000D4F90 File Offset: 0x000D3190
			object IEnumerator.Current
			{
				get
				{
					return this._baseEnumerator.Current;
				}
			}

			// Token: 0x060020A9 RID: 8361 RVA: 0x00013A61 File Offset: 0x00011C61
			public Enumerator(IEnumerator ienumerator_1)
			{
				this._baseEnumerator = ienumerator_1;
			}

			// Token: 0x060020AA RID: 8362 RVA: 0x00004BC2 File Offset: 0x00002DC2
			public void Dispose()
			{
			}

			// Token: 0x060020AB RID: 8363 RVA: 0x00013A70 File Offset: 0x00011C70
			public bool MoveNext()
			{
				return this._baseEnumerator.MoveNext();
			}

			// Token: 0x060020AC RID: 8364 RVA: 0x00013A7D File Offset: 0x00011C7D
			public void Reset()
			{
				this._baseEnumerator.Reset();
			}

			// Token: 0x04000FD2 RID: 4050
			private readonly IEnumerator _baseEnumerator;
		}
	}
}
