using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;

namespace System.Data.SQLite
{
	// Token: 0x0200143E RID: 5182
	[Editor("Microsoft.VSDesigner.Data.Design.DBParametersEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), ListBindable(false)]
	public sealed class SQLiteParameterCollection : DbParameterCollection
	{
		// Token: 0x0600B1F8 RID: 45560 RVA: 0x00054882 File Offset: 0x00052A82
		internal SQLiteParameterCollection(SQLiteCommand cmd)
		{
			this._command = cmd;
			this._parameterList = new List<SQLiteParameter>();
			this._unboundFlag = true;
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x0600B1F9 RID: 45561 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool IsSynchronized
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x0600B1FA RID: 45562 RVA: 0x000081A2 File Offset: 0x000063A2
		public override bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x0600B1FB RID: 45563 RVA: 0x000081A2 File Offset: 0x000063A2
		public override bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x0600B1FC RID: 45564 RVA: 0x00041676 File Offset: 0x0003F876
		public override object SyncRoot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600B1FD RID: 45565 RVA: 0x000548A3 File Offset: 0x00052AA3
		public override IEnumerator GetEnumerator()
		{
			return this._parameterList.GetEnumerator();
		}

		// Token: 0x0600B1FE RID: 45566 RVA: 0x004EEF98 File Offset: 0x004ED198
		public SQLiteParameter Add(string parameterName, DbType parameterType, int parameterSize, string sourceColumn)
		{
			SQLiteParameter sQLiteParameter = new SQLiteParameter(parameterName, parameterType, parameterSize, sourceColumn);
			this.Add(sQLiteParameter);
			return sQLiteParameter;
		}

		// Token: 0x0600B1FF RID: 45567 RVA: 0x004EEFBC File Offset: 0x004ED1BC
		public SQLiteParameter Add(string parameterName, DbType parameterType, int parameterSize)
		{
			SQLiteParameter sQLiteParameter = new SQLiteParameter(parameterName, parameterType, parameterSize);
			this.Add(sQLiteParameter);
			return sQLiteParameter;
		}

		// Token: 0x0600B200 RID: 45568 RVA: 0x004EEFDC File Offset: 0x004ED1DC
		public SQLiteParameter Add(string parameterName, DbType parameterType)
		{
			SQLiteParameter sQLiteParameter = new SQLiteParameter(parameterName, parameterType);
			this.Add(sQLiteParameter);
			return sQLiteParameter;
		}

		// Token: 0x0600B201 RID: 45569 RVA: 0x004EEFFC File Offset: 0x004ED1FC
		public int Add(SQLiteParameter parameter)
		{
			int num = -1;
			if (!string.IsNullOrEmpty(parameter.ParameterName))
			{
				num = this.IndexOf(parameter.ParameterName);
			}
			if (num == -1)
			{
				num = this._parameterList.Count;
				this._parameterList.Add(parameter);
			}
			this.SetParameter(num, parameter);
			return num;
		}

		// Token: 0x0600B202 RID: 45570 RVA: 0x000548B5 File Offset: 0x00052AB5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Add(object value)
		{
			return this.Add((SQLiteParameter)value);
		}

		// Token: 0x0600B203 RID: 45571 RVA: 0x004EF04C File Offset: 0x004ED24C
		public SQLiteParameter AddWithValue(string parameterName, object value)
		{
			SQLiteParameter sQLiteParameter = new SQLiteParameter(parameterName, value);
			this.Add(sQLiteParameter);
			return sQLiteParameter;
		}

		// Token: 0x0600B204 RID: 45572 RVA: 0x004EF06C File Offset: 0x004ED26C
		public void AddRange(SQLiteParameter[] values)
		{
			int num = values.Length;
			for (int i = 0; i < num; i++)
			{
				this.Add(values[i]);
			}
		}

		// Token: 0x0600B205 RID: 45573 RVA: 0x004EF094 File Offset: 0x004ED294
		public override void AddRange(Array values)
		{
			int length = values.Length;
			for (int i = 0; i < length; i++)
			{
				this.Add((SQLiteParameter)values.GetValue(i));
			}
		}

		// Token: 0x0600B206 RID: 45574 RVA: 0x000548C3 File Offset: 0x00052AC3
		public override void Clear()
		{
			this._unboundFlag = true;
			this._parameterList.Clear();
		}

		// Token: 0x0600B207 RID: 45575 RVA: 0x000548D7 File Offset: 0x00052AD7
		public override bool Contains(string parameterName)
		{
			return this.IndexOf(parameterName) != -1;
		}

		// Token: 0x0600B208 RID: 45576 RVA: 0x000548E6 File Offset: 0x00052AE6
		public override bool Contains(object value)
		{
			return this._parameterList.Contains((SQLiteParameter)value);
		}

		// Token: 0x0600B209 RID: 45577 RVA: 0x00025A78 File Offset: 0x00023C78
		public override void CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x0600B20A RID: 45578 RVA: 0x000548F9 File Offset: 0x00052AF9
		public override int Count
		{
			get
			{
				return this._parameterList.Count;
			}
		}

		// Token: 0x17000D50 RID: 3408
		public new SQLiteParameter this[string parameterName]
		{
			get
			{
				return (SQLiteParameter)this.GetParameter(parameterName);
			}
			set
			{
				this.SetParameter(parameterName, value);
			}
		}

		// Token: 0x17000D51 RID: 3409
		public new SQLiteParameter this[int index]
		{
			get
			{
				return (SQLiteParameter)this.GetParameter(index);
			}
			set
			{
				this.SetParameter(index, value);
			}
		}

		// Token: 0x0600B20F RID: 45583 RVA: 0x00054936 File Offset: 0x00052B36
		protected override DbParameter GetParameter(string parameterName)
		{
			return this.GetParameter(this.IndexOf(parameterName));
		}

		// Token: 0x0600B210 RID: 45584 RVA: 0x00054945 File Offset: 0x00052B45
		protected override DbParameter GetParameter(int index)
		{
			return this._parameterList[index];
		}

		// Token: 0x0600B211 RID: 45585 RVA: 0x004EF0C8 File Offset: 0x004ED2C8
		public override int IndexOf(string parameterName)
		{
			int count = this._parameterList.Count;
			for (int i = 0; i < count; i++)
			{
				if (string.Compare(parameterName, this._parameterList[i].ParameterName, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600B212 RID: 45586 RVA: 0x00054953 File Offset: 0x00052B53
		public override int IndexOf(object value)
		{
			return this._parameterList.IndexOf((SQLiteParameter)value);
		}

		// Token: 0x0600B213 RID: 45587 RVA: 0x00054966 File Offset: 0x00052B66
		public override void Insert(int index, object value)
		{
			this._unboundFlag = true;
			this._parameterList.Insert(index, (SQLiteParameter)value);
		}

		// Token: 0x0600B214 RID: 45588 RVA: 0x00054981 File Offset: 0x00052B81
		public override void Remove(object value)
		{
			this._unboundFlag = true;
			this._parameterList.Remove((SQLiteParameter)value);
		}

		// Token: 0x0600B215 RID: 45589 RVA: 0x0005499C File Offset: 0x00052B9C
		public override void RemoveAt(string parameterName)
		{
			this.RemoveAt(this.IndexOf(parameterName));
		}

		// Token: 0x0600B216 RID: 45590 RVA: 0x000549AB File Offset: 0x00052BAB
		public override void RemoveAt(int index)
		{
			this._unboundFlag = true;
			this._parameterList.RemoveAt(index);
		}

		// Token: 0x0600B217 RID: 45591 RVA: 0x000549C0 File Offset: 0x00052BC0
		protected override void SetParameter(string parameterName, DbParameter value)
		{
			this.SetParameter(this.IndexOf(parameterName), value);
		}

		// Token: 0x0600B218 RID: 45592 RVA: 0x000549D0 File Offset: 0x00052BD0
		protected override void SetParameter(int index, DbParameter value)
		{
			this._unboundFlag = true;
			this._parameterList[index] = (SQLiteParameter)value;
		}

		// Token: 0x0600B219 RID: 45593 RVA: 0x000549EB File Offset: 0x00052BEB
		internal void Unbind()
		{
			this._unboundFlag = true;
		}

		// Token: 0x0600B21A RID: 45594 RVA: 0x004EF10C File Offset: 0x004ED30C
		internal void MapParameters(SQLiteStatement activeStatement)
		{
			if (this._unboundFlag && this._parameterList.Count != 0 && this._command._statementList != null)
			{
				int num = 0;
				int num2 = -1;
				foreach (SQLiteParameter current in this._parameterList)
				{
					num2++;
					string text = current.ParameterName;
					if (text == null)
					{
						text = string.Format(CultureInfo.InvariantCulture, ";{0}", new object[]
						{
							num
						});
						num++;
					}
					bool flag = false;
					int num3;
					if (activeStatement == null)
					{
						num3 = this._command._statementList.Count;
					}
					else
					{
						num3 = 1;
					}
					SQLiteStatement sQLiteStatement = activeStatement;
					for (int i = 0; i < num3; i++)
					{
						flag = false;
						if (sQLiteStatement == null)
						{
							sQLiteStatement = this._command._statementList[i];
						}
						if (sQLiteStatement._paramNames != null && sQLiteStatement.MapParameter(text, current))
						{
							flag = true;
						}
						sQLiteStatement = null;
					}
					if (!flag)
					{
						text = string.Format(CultureInfo.InvariantCulture, ";{0}", new object[]
						{
							num2
						});
						sQLiteStatement = activeStatement;
						for (int i = 0; i < num3; i++)
						{
							if (sQLiteStatement == null)
							{
								sQLiteStatement = this._command._statementList[i];
							}
							if (sQLiteStatement._paramNames == null || sQLiteStatement.MapParameter(text, current))
							{
							}
							sQLiteStatement = null;
						}
					}
				}
				if (activeStatement == null)
				{
					this._unboundFlag = false;
				}
				return;
			}
		}

		// Token: 0x04005E3A RID: 24122
		private SQLiteCommand _command;

		// Token: 0x04005E3B RID: 24123
		private List<SQLiteParameter> _parameterList;

		// Token: 0x04005E3C RID: 24124
		private bool _unboundFlag;
	}
}
