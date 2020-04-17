using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.OleDb;
using System.IO;

namespace ns6
{
	// Token: 0x02000C7F RID: 3199
	public sealed class Class404 : IDisposable, IEnumerable, IEnumerator, IEnumerator<Class397>, IEnumerable<Class397>
	{
		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06006A1A RID: 27162 RVA: 0x00390240 File Offset: 0x0038E440
		public Class397 Current
		{
			get
			{
				if (this.bool_0)
				{
					throw new ObjectDisposedException("Shapefile");
				}
				if (!this.bool_1)
				{
					throw new InvalidOperationException("Shapefile not open.");
				}
				StringDictionary stringDictionary = null;
				if (!this.method_3())
				{
					stringDictionary = new StringDictionary();
					for (int i = 0; i < this.oleDbDataReader_0.FieldCount; i++)
					{
						stringDictionary.Add(this.oleDbDataReader_0.GetName(i), this.oleDbDataReader_0.GetValue(i).ToString());
					}
				}
				byte[] array = new byte[8];
				this.fileStream_1.Seek((long)(100 + this.int_0 * 8), SeekOrigin.Begin);
				this.fileStream_1.Read(array, 0, array.Length);
				int num = Class395.smethod_0(array, 0, Enum118.const_0);
				int num2 = Class395.smethod_0(array, 4, Enum118.const_0);
				int num3 = num2 * 2 + 8;
				byte[] array2 = new byte[num3];
				this.fileStream_0.Seek((long)(num * 2), SeekOrigin.Begin);
				this.fileStream_0.Read(array2, 0, num3);
				return Class403.smethod_0(array2, stringDictionary, this.oleDbDataReader_0);
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06006A1B RID: 27163 RVA: 0x0039034C File Offset: 0x0038E54C
		object IEnumerator.Current
		{
			get
			{
				if (this.bool_0)
				{
					throw new ObjectDisposedException("Shapefile");
				}
				if (!this.bool_1)
				{
					throw new InvalidOperationException("Shapefile not open.");
				}
				return this.Current;
			}
		}

		// Token: 0x06006A1C RID: 27164 RVA: 0x0002DAE4 File Offset: 0x0002BCE4
		public Class404() : this(null, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBase IV")
		{
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x0039038C File Offset: 0x0038E58C
		public Class404(string string_5, string string_6)
		{
			if (string_6 == null)
			{
				throw new ArgumentNullException("connectionStringTemplate");
			}
			this.method_2(string_6);
			if (string_5 != null)
			{
				this.method_0(string_5);
			}
		}

		// Token: 0x06006A1E RID: 27166 RVA: 0x003903F8 File Offset: 0x0038E5F8
		public void method_0(string string_5)
		{
			if (this.bool_0)
			{
				throw new ObjectDisposedException("Shapefile");
			}
			if (string_5 == null)
			{
				throw new ArgumentNullException("path");
			}
			if (string_5.Length <= 0)
			{
				throw new ArgumentException("path parameter is empty", "path");
			}
			this.string_0 = Path.ChangeExtension(string_5, "shp");
			this.string_1 = Path.ChangeExtension(string_5, "shx");
			this.string_2 = Path.ChangeExtension(string_5, "dbf");
			if (!File.Exists(this.string_0))
			{
				throw new FileNotFoundException("Shapefile main file not found", this.string_0);
			}
			if (!File.Exists(this.string_1))
			{
				throw new FileNotFoundException("Shapefile index file not found", this.string_1);
			}
			if (!File.Exists(this.string_2))
			{
				throw new FileNotFoundException("Shapefile dBase file not found", this.string_2);
			}
			this.fileStream_0 = File.Open(this.string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
			this.fileStream_1 = File.Open(this.string_1, FileMode.Open, FileAccess.Read, FileShare.Read);
			if (this.fileStream_0.Length < 100L)
			{
				throw new InvalidOperationException("Shapefile main file does not contain a valid header");
			}
			if (this.fileStream_1.Length < 100L)
			{
				throw new InvalidOperationException("Shapefile index file does not contain a valid header");
			}
			byte[] array = new byte[100];
			this.fileStream_0.Read(array, 0, 100);
			this.class396_0 = new Class396(array);
			this.fileStream_1.Read(array, 0, 100);
			this.class396_1 = new Class396(array);
			this.enum119_0 = this.class396_0.method_1();
			this.struct49_0 = new Struct49(this.class396_0.method_2(), this.class396_0.method_3(), this.class396_0.method_4(), this.class396_0.method_5());
			this.int_1 = (this.class396_1.method_0() - 50) / 4;
			this.method_4();
			this.bool_1 = true;
		}

		// Token: 0x06006A1F RID: 27167 RVA: 0x003905F8 File Offset: 0x0038E7F8
		public string method_1()
		{
			return this.string_4;
		}

		// Token: 0x06006A20 RID: 27168 RVA: 0x0002DAF2 File Offset: 0x0002BCF2
		public void method_2(string string_5)
		{
			this.string_4 = string_5;
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x0002DAFB File Offset: 0x0002BCFB
		public bool method_3()
		{
			return this.bool_2;
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x00390610 File Offset: 0x0038E810
		private void method_4()
		{
			string path = this.string_2;
			if (Path.GetFileNameWithoutExtension(path).Length > 8)
			{
				string tempFileName = Path.GetTempFileName();
				try
				{
					File.Delete(tempFileName);
				}
				catch
				{
				}
				this.string_3 = Path.ChangeExtension(tempFileName, "dbf");
				File.Copy(this.string_2, this.string_3, true);
				path = this.string_3;
			}
			string connectionString = string.Format(this.method_1(), Path.GetDirectoryName(path));
			string cmdText = string.Format("SELECT * FROM [{0}]", Path.GetFileNameWithoutExtension(path));
			this.oleDbConnection_0 = new OleDbConnection(connectionString);
			this.oleDbConnection_0.Open();
			this.oleDbCommand_0 = new OleDbCommand(cmdText, this.oleDbConnection_0);
			this.oleDbDataReader_0 = this.oleDbCommand_0.ExecuteReader();
		}

		// Token: 0x06006A23 RID: 27171 RVA: 0x003906E0 File Offset: 0x0038E8E0
		private void method_5()
		{
			if (this.oleDbDataReader_0 != null)
			{
				this.oleDbDataReader_0.Close();
				this.oleDbDataReader_0 = null;
			}
			if (this.oleDbCommand_0 != null)
			{
				this.oleDbCommand_0.Dispose();
				this.oleDbCommand_0 = null;
			}
			if (this.oleDbConnection_0 != null)
			{
				this.oleDbConnection_0.Close();
				this.oleDbConnection_0 = null;
			}
			if (this.string_3 != null)
			{
				if (File.Exists(this.string_3))
				{
					try
					{
						File.Delete(this.string_3);
					}
					catch
					{
					}
				}
				this.string_3 = null;
			}
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x00390788 File Offset: 0x0038E988
		~Class404()
		{
			this.method_6(false);
		}

		// Token: 0x06006A25 RID: 27173 RVA: 0x0002DB03 File Offset: 0x0002BD03
		public void Dispose()
		{
			this.method_6(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06006A26 RID: 27174 RVA: 0x003907B8 File Offset: 0x0038E9B8
		private void method_6(bool bool_3)
		{
			if (!this.bool_0)
			{
				if (bool_3)
				{
					if (this.fileStream_0 != null)
					{
						this.fileStream_0.Close();
						this.fileStream_0 = null;
					}
					if (this.fileStream_1 != null)
					{
						this.fileStream_1.Close();
						this.fileStream_1 = null;
					}
					this.method_5();
				}
				this.bool_0 = true;
				this.bool_1 = false;
			}
		}

		// Token: 0x06006A27 RID: 27175 RVA: 0x00390824 File Offset: 0x0038EA24
		public bool MoveNext()
		{
			if (this.bool_0)
			{
				throw new ObjectDisposedException("Shapefile");
			}
			if (!this.bool_1)
			{
				throw new InvalidOperationException("Shapefile not open.");
			}
			bool result;
			if (this.int_0++ >= this.int_1 - 1)
			{
				result = false;
			}
			else
			{
				if (!this.oleDbDataReader_0.Read())
				{
					throw new InvalidOperationException("Metadata database does not contain a record for the next shape");
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x0002DB12 File Offset: 0x0002BD12
		public void Reset()
		{
			if (this.bool_0)
			{
				throw new ObjectDisposedException("Shapefile");
			}
			if (!this.bool_1)
			{
				throw new InvalidOperationException("Shapefile not open.");
			}
			this.method_5();
			this.method_4();
			this.int_0 = -1;
		}

		// Token: 0x06006A29 RID: 27177 RVA: 0x00390898 File Offset: 0x0038EA98
		public IEnumerator<Class397> GetEnumerator()
		{
			return this;
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x003908A8 File Offset: 0x0038EAA8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this;
		}

		// Token: 0x04003BE0 RID: 15328
		private bool bool_0;

		// Token: 0x04003BE1 RID: 15329
		private bool bool_1;

		// Token: 0x04003BE2 RID: 15330
		private bool bool_2 = false;

		// Token: 0x04003BE3 RID: 15331
		private int int_0 = -1;

		// Token: 0x04003BE4 RID: 15332
		private int int_1;

		// Token: 0x04003BE5 RID: 15333
		private Struct49 struct49_0;

		// Token: 0x04003BE6 RID: 15334
		private Enum119 enum119_0;

		// Token: 0x04003BE7 RID: 15335
		private string string_0;

		// Token: 0x04003BE8 RID: 15336
		private string string_1;

		// Token: 0x04003BE9 RID: 15337
		private string string_2 = "";

		// Token: 0x04003BEA RID: 15338
		private string string_3 = "";

		// Token: 0x04003BEB RID: 15339
		private FileStream fileStream_0;

		// Token: 0x04003BEC RID: 15340
		private FileStream fileStream_1;

		// Token: 0x04003BED RID: 15341
		private Class396 class396_0;

		// Token: 0x04003BEE RID: 15342
		private Class396 class396_1;

		// Token: 0x04003BEF RID: 15343
		private OleDbConnection oleDbConnection_0;

		// Token: 0x04003BF0 RID: 15344
		private OleDbCommand oleDbCommand_0;

		// Token: 0x04003BF1 RID: 15345
		private OleDbDataReader oleDbDataReader_0;

		// Token: 0x04003BF2 RID: 15346
		private string string_4 = "";
	}
}
