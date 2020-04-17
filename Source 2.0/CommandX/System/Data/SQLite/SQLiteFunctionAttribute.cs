using System;

namespace System.Data.SQLite
{
	// Token: 0x02001443 RID: 5187
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
	public sealed class SQLiteFunctionAttribute : Attribute
	{
		// Token: 0x0600B264 RID: 45668 RVA: 0x00054BB2 File Offset: 0x00052DB2
		public SQLiteFunctionAttribute()
		{
			this.Name = "";
			this.Arguments = -1;
			this.FuncType = FunctionType.Scalar;
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x0600B265 RID: 45669 RVA: 0x00054BD3 File Offset: 0x00052DD3
		// (set) Token: 0x0600B266 RID: 45670 RVA: 0x00054BDB File Offset: 0x00052DDB
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x0600B267 RID: 45671 RVA: 0x00054BE4 File Offset: 0x00052DE4
		// (set) Token: 0x0600B268 RID: 45672 RVA: 0x00054BEC File Offset: 0x00052DEC
		public int Arguments
		{
			get
			{
				return this._arguments;
			}
			set
			{
				this._arguments = value;
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x0600B269 RID: 45673 RVA: 0x00054BF5 File Offset: 0x00052DF5
		// (set) Token: 0x0600B26A RID: 45674 RVA: 0x00054BFD File Offset: 0x00052DFD
		public FunctionType FuncType
		{
			get
			{
				return this._functionType;
			}
			set
			{
				this._functionType = value;
			}
		}

		// Token: 0x04005E55 RID: 24149
		private string _name;

		// Token: 0x04005E56 RID: 24150
		private int _arguments;

		// Token: 0x04005E57 RID: 24151
		private FunctionType _functionType;

		// Token: 0x04005E58 RID: 24152
		internal Type _instanceType;
	}
}
