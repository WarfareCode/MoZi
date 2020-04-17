using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using GeoAPI.Geometries;
using ns13;

namespace ns12
{
	// Token: 0x020003B0 RID: 944
	public sealed class Class601 : IDisposable, IEnumerable, IDataReader, IDataRecord
	{
		// Token: 0x170001F3 RID: 499
		public object this[string name]
		{
			get
			{
				return this.arrayList_0[this.GetOrdinal(name) + 1];
			}
		}

		// Token: 0x170001F4 RID: 500
		public object this[int i]
		{
			get
			{
				return this.arrayList_0[i];
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x000924B4 File Offset: 0x000906B4
		public int FieldCount
		{
			get
			{
				return this.class642_0.Length;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x000081A2 File Offset: 0x000063A2
		public int Depth
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x0000FBA8 File Offset: 0x0000DDA8
		public bool IsClosed
		{
			get
			{
				return !this.bool_0;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x0000FBB3 File Offset: 0x0000DDB3
		public int RecordsAffected
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x000081A2 File Offset: 0x000063A2
		public bool NextResult()
		{
			return false;
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0000FBB6 File Offset: 0x0000DDB6
		public void Close()
		{
			this.bool_0 = false;
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x000924CC File Offset: 0x000906CC
		public bool Read()
		{
			bool flag = this.ienumerator_0.MoveNext();
			bool flag2 = this.ienumerator_1.MoveNext();
			if (!flag)
			{
			}
			if (!flag2)
			{
			}
			this.bool_1 = (flag && flag2);
			this.igeometry_0 = (IGeometry)this.ienumerator_1.Current;
			this.arrayList_0 = (ArrayList)this.ienumerator_0.Current;
			return this.bool_1;
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x0000FBBF File Offset: 0x0000DDBF
		public DataTable GetSchemaTable()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0000FBC6 File Offset: 0x0000DDC6
		public void Dispose()
		{
			if (!this.IsClosed)
			{
				this.Close();
			}
			((IDisposable)this.ienumerator_1).Dispose();
			((IDisposable)this.ienumerator_0).Dispose();
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x0009253C File Offset: 0x0009073C
		public int GetInt32(int i)
		{
			string s = this.arrayList_0[i].ToString().Trim();
			int result = 0;
			int.TryParse(s, out result);
			return result;
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x00092498 File Offset: 0x00090698
		public object GetValue(int i)
		{
			return this.arrayList_0[i];
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x0000FBF6 File Offset: 0x0000DDF6
		public bool IsDBNull(int i)
		{
			return this.GetValue(i) == null;
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00009661 File Offset: 0x00007861
		public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
		{
			return 0L;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x000081A2 File Offset: 0x000063A2
		public byte GetByte(int i)
		{
			return 0;
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00092570 File Offset: 0x00090770
		public Type GetFieldType(int i)
		{
			return this.class642_0[i].method_8();
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0009258C File Offset: 0x0009078C
		public decimal GetDecimal(int i)
		{
			return 0m;
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x000925A4 File Offset: 0x000907A4
		public int GetValues(object[] values)
		{
			int i;
			for (i = 0; i < values.Length; i++)
			{
				values[i] = this.arrayList_0[i];
			}
			return i;
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x000925D4 File Offset: 0x000907D4
		public string GetName(int i)
		{
			return this.class642_0[i].method_0();
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x000925F0 File Offset: 0x000907F0
		public long GetInt64(int i)
		{
			string s = this.arrayList_0[i].ToString().Trim();
			long result = 0L;
			long.TryParse(s, out result);
			return result;
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x0009262C File Offset: 0x0009082C
		public double GetDouble(int i)
		{
			string s = this.arrayList_0[i].ToString().Trim();
			double result = 0.0;
			double.TryParse(s, out result);
			return result;
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0000FC02 File Offset: 0x0000DE02
		public bool GetBoolean(int i)
		{
			return (bool)this.arrayList_0[i];
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00092668 File Offset: 0x00090868
		public Guid GetGuid(int i)
		{
			Guid result = Guid.Empty;
			try
			{
				string g = this.arrayList_0[i].ToString().Trim();
				result = new Guid(g);
			}
			catch (Exception ex)
			{
				Trace.WriteLine(ex.Message);
			}
			return result;
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x000926BC File Offset: 0x000908BC
		public DateTime GetDateTime(int i)
		{
			string s = this.arrayList_0[i].ToString().Trim();
			DateTime result;
			DateTime.TryParse(s, out result);
			return result;
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x000926EC File Offset: 0x000908EC
		public int GetOrdinal(string name)
		{
			for (int i = 0; i < this.class589_0.method_0().method_0(); i++)
			{
				if (0 == this.method_1(this.class589_0.method_0().method_5()[i].method_0(), name))
				{
					return i;
				}
			}
			throw new IndexOutOfRangeException("Could not find specified column in results.");
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0009274C File Offset: 0x0009094C
		public string GetDataTypeName(int i)
		{
			return this.class642_0[i].method_8().ToString();
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00092770 File Offset: 0x00090970
		public float GetFloat(int i)
		{
			string s = this.arrayList_0[i].ToString().Trim();
			float result = 0f;
			float.TryParse(s, out result);
			return result;
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x0000FC15 File Offset: 0x0000DE15
		public IDataReader GetData(int i)
		{
			throw new NotSupportedException("GetData not supported.");
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x000927A8 File Offset: 0x000909A8
		public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
		{
			string text = this.arrayList_0[i].ToString();
			text.CopyTo((int)fieldoffset, buffer, 0, length);
			return (long)length;
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x000927D8 File Offset: 0x000909D8
		public string GetString(int i)
		{
			return this.arrayList_0[i].ToString().Trim();
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x00092800 File Offset: 0x00090A00
		public char GetChar(int i)
		{
			return (char)this.arrayList_0[i];
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00092820 File Offset: 0x00090A20
		public short GetInt16(int i)
		{
			string s = this.arrayList_0[i].ToString().Trim();
			short result;
			short.TryParse(s, out result);
			return result;
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00092850 File Offset: 0x00090A50
		public IEnumerator GetEnumerator()
		{
			return new Class601.Class602(this);
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0000FC21 File Offset: 0x0000DE21
		public void method_0()
		{
			this.ienumerator_0.Reset();
			this.ienumerator_1.Reset();
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00092868 File Offset: 0x00090A68
		private int method_1(string string_0, string string_1)
		{
			return CultureInfo.CurrentCulture.CompareInfo.Compare(string_0, string_1, CompareOptions.IgnoreCase | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);
		}

		// Token: 0x0400099E RID: 2462
		private bool bool_0;

		// Token: 0x0400099F RID: 2463
		private Class642[] class642_0;

		// Token: 0x040009A0 RID: 2464
		private ArrayList arrayList_0;

		// Token: 0x040009A1 RID: 2465
		private Class589 class589_0;

		// Token: 0x040009A2 RID: 2466
		private IEnumerator ienumerator_0;

		// Token: 0x040009A3 RID: 2467
		private IEnumerator ienumerator_1;

		// Token: 0x040009A4 RID: 2468
		private bool bool_1;

		// Token: 0x040009A5 RID: 2469
		private IGeometry igeometry_0;

		// Token: 0x020003B1 RID: 945
		public sealed class Class602 : IEnumerator
		{
			// Token: 0x170001F9 RID: 505
			// (get) Token: 0x06001771 RID: 6001 RVA: 0x0009288C File Offset: 0x00090A8C
			public object Current
			{
				get
				{
					return new Struct58(this.class601_0.class642_0, this.class601_0.arrayList_0);
				}
			}

			// Token: 0x06001772 RID: 6002 RVA: 0x0000FC39 File Offset: 0x0000DE39
			public Class602(Class601 class601_1)
			{
				this.class601_0 = class601_1;
				this.class601_0.method_0();
			}

			// Token: 0x06001773 RID: 6003 RVA: 0x0000FC53 File Offset: 0x0000DE53
			public void Reset()
			{
				this.class601_0.method_0();
			}

			// Token: 0x06001774 RID: 6004 RVA: 0x0000FC60 File Offset: 0x0000DE60
			public bool MoveNext()
			{
				return this.class601_0.Read();
			}

			// Token: 0x040009A6 RID: 2470
			private Class601 class601_0;
		}
	}
}
