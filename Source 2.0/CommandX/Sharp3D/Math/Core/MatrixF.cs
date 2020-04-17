using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;

namespace Sharp3D.Math.Core
{
	// Token: 0x02000334 RID: 820
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public sealed class MatrixF : ICloneable, ISerializable
	{
		// Token: 0x170001AB RID: 427
		public float this[int int_0, int int_1]
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

		// Token: 0x06001352 RID: 4946 RVA: 0x0000DF1B File Offset: 0x0000C11B
		public MatrixF(MatrixF matrixF_0)
		{
			this._rows = matrixF_0._rows;
			this._columns = matrixF_0._columns;
			this._data = (float[][])matrixF_0._data.Clone();
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00084CF0 File Offset: 0x00082EF0
		protected MatrixF(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._rows = serializationInfo_0.GetInt32("Rows");
			this._columns = serializationInfo_0.GetInt32("Columns");
			this._data = (float[][])serializationInfo_0.GetValue("Data", typeof(float[][]));
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0000DF51 File Offset: 0x0000C151
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\n               version=\"1\">\r\n   <IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\n                version=\"1\"\r\n                Flags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Rows", this._rows);
			info.AddValue("Columns", this._columns);
			info.AddValue("Data", this._data);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00084D48 File Offset: 0x00082F48
		object ICloneable.Clone()
		{
			return new MatrixF(this);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00084D60 File Offset: 0x00082F60
		public int method_0()
		{
			return this._rows;
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00084D78 File Offset: 0x00082F78
		public int method_1()
		{
			return this._columns;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00084D90 File Offset: 0x00082F90
		public override int GetHashCode()
		{
			return this._rows.GetHashCode() ^ this._columns.GetHashCode() ^ this._data.GetHashCode();
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00084DC4 File Offset: 0x00082FC4
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is MatrixF)
			{
				MatrixF matrixF = (MatrixF)obj;
				for (int i = 0; i < matrixF.method_0(); i++)
				{
					for (int j = 0; j < matrixF.method_1(); j++)
					{
						if (this._data[i][j] != matrixF._data[i][j])
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

		// Token: 0x0600135A RID: 4954 RVA: 0x00084E30 File Offset: 0x00083030
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

		// Token: 0x04000802 RID: 2050
		private float[][] _data;

		// Token: 0x04000803 RID: 2051
		private int _rows;

		// Token: 0x04000804 RID: 2052
		private int _columns;
	}
}
