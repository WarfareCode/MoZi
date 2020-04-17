using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;

namespace Sharp3D.Math.Core
{
	// Token: 0x0200032E RID: 814
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public sealed class MatrixD : ICloneable, ISerializable
	{
		// Token: 0x170001A8 RID: 424
		public double this[int int_0, int int_1]
		{
			get
			{
				return this._data[int_0][int_1];
			}
			set
			{
				this._data[int_0][int_1] = value;
			}
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x0000DDAA File Offset: 0x0000BFAA
		public MatrixD(MatrixD matrixD_0)
		{
			this._rows = matrixD_0._rows;
			this._columns = matrixD_0._columns;
			this._data = (double[][])matrixD_0._data.Clone();
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00084A4C File Offset: 0x00082C4C
		protected MatrixD(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._rows = serializationInfo_0.GetInt32("Rows");
			this._columns = serializationInfo_0.GetInt32("Columns");
			this._data = (double[][])serializationInfo_0.GetValue("Data", typeof(double[][]));
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0000DDE0 File Offset: 0x0000BFE0
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\n               version=\"1\">\r\n   <IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\n                version=\"1\"\r\n                Flags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Rows", this._rows);
			info.AddValue("Columns", this._columns);
			info.AddValue("Data", this._data);
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00084AA4 File Offset: 0x00082CA4
		object ICloneable.Clone()
		{
			return new MatrixD(this);
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00084ABC File Offset: 0x00082CBC
		public int method_0()
		{
			return this._rows;
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00084AD4 File Offset: 0x00082CD4
		public int method_1()
		{
			return this._columns;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00084AEC File Offset: 0x00082CEC
		public override int GetHashCode()
		{
			return this._rows.GetHashCode() ^ this._columns.GetHashCode() ^ this._data.GetHashCode();
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00084B20 File Offset: 0x00082D20
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is MatrixD)
			{
				MatrixD matrixD = (MatrixD)obj;
				for (int i = 0; i < matrixD.method_0(); i++)
				{
					for (int j = 0; j < matrixD.method_1(); j++)
					{
						if (this._data[i][j] != matrixD._data[i][j])
						{
							result = false;
							return result;
						}
					}
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00084B8C File Offset: 0x00082D8C
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < this._rows; i++)
			{
				for (int j = 0; j < this._columns; j++)
				{
					stringBuilder.Append(this._data[i][j] + " ");
				}
				stringBuilder.Append(Environment.NewLine);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040007F7 RID: 2039
		private double[][] _data;

		// Token: 0x040007F8 RID: 2040
		private int _rows;

		// Token: 0x040007F9 RID: 2041
		private int _columns;
	}
}
