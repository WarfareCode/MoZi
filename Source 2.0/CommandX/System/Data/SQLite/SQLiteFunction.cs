using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Data.SQLite
{
	// Token: 0x02001423 RID: 5155
	public abstract class SQLiteFunction : IDisposable
	{
		// Token: 0x0600B107 RID: 45319 RVA: 0x00054207 File Offset: 0x00052407
		protected SQLiteFunction()
		{
			this._contextDataList = new Dictionary<long, SQLiteFunction.AggregateData>();
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x0600B108 RID: 45320 RVA: 0x0005421A File Offset: 0x0005241A
		public SQLiteConvert SQLiteConvert
		{
			get
			{
				return this._base;
			}
		}

		// Token: 0x0600B109 RID: 45321 RVA: 0x00041676 File Offset: 0x0003F876
		public virtual object Invoke(object[] args)
		{
			return null;
		}

		// Token: 0x0600B10A RID: 45322 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public virtual void Step(object[] args, int stepNumber, ref object contextData)
		{
		}

		// Token: 0x0600B10B RID: 45323 RVA: 0x00041676 File Offset: 0x0003F876
		public virtual object Final(object contextData)
		{
			return null;
		}

		// Token: 0x0600B10C RID: 45324 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual int Compare(string param1, string param2)
		{
			return 0;
		}

		// Token: 0x0600B10D RID: 45325 RVA: 0x004EB784 File Offset: 0x004E9984
		internal object[] ConvertParams(int nArgs, IntPtr argsptr)
		{
			object[] array = new object[nArgs];
			IntPtr[] array2 = new IntPtr[nArgs];
			Marshal.Copy(argsptr, array2, 0, nArgs);
			for (int i = 0; i < nArgs; i++)
			{
				switch (this._base.GetParamValueType(array2[i]))
				{
				case TypeAffinity.Int64:
					array[i] = this._base.GetParamValueInt64(array2[i]);
					break;
				case TypeAffinity.Double:
					array[i] = this._base.GetParamValueDouble(array2[i]);
					break;
				case TypeAffinity.Text:
					array[i] = this._base.GetParamValueText(array2[i]);
					break;
				case TypeAffinity.Blob:
				{
					int num = (int)this._base.GetParamValueBytes(array2[i], 0, null, 0, 0);
					byte[] array3 = new byte[num];
					this._base.GetParamValueBytes(array2[i], 0, array3, 0, num);
					array[i] = array3;
					break;
				}
				case TypeAffinity.Null:
					array[i] = DBNull.Value;
					break;
				case TypeAffinity.DateTime:
					array[i] = this._base.ToDateTime(this._base.GetParamValueText(array2[i]));
					break;
				}
			}
			return array;
		}

		// Token: 0x0600B10E RID: 45326 RVA: 0x004EB8EC File Offset: 0x004E9AEC
		private void SetReturnValue(IntPtr context, object returnValue)
		{
			if (returnValue != null)
			{
				if (returnValue != DBNull.Value)
				{
					Type type = returnValue.GetType();
					if (type == typeof(DateTime))
					{
						this._base.ReturnText(context, this._base.ToString((DateTime)returnValue));
						return;
					}
					Exception ex = returnValue as Exception;
					if (ex != null)
					{
						this._base.ReturnError(context, ex.Message);
						return;
					}
					switch (SQLiteConvert.TypeToAffinity(type))
					{
					case TypeAffinity.Int64:
						this._base.ReturnInt64(context, Convert.ToInt64(returnValue, CultureInfo.CurrentCulture));
						return;
					case TypeAffinity.Double:
						this._base.ReturnDouble(context, Convert.ToDouble(returnValue, CultureInfo.CurrentCulture));
						return;
					case TypeAffinity.Text:
						this._base.ReturnText(context, returnValue.ToString());
						return;
					case TypeAffinity.Blob:
						this._base.ReturnBlob(context, (byte[])returnValue);
						return;
					case TypeAffinity.Null:
						this._base.ReturnNull(context);
						return;
					default:
						return;
					}
				}
			}
			this._base.ReturnNull(context);
		}

		// Token: 0x0600B10F RID: 45327 RVA: 0x00054222 File Offset: 0x00052422
		internal void ScalarCallback(IntPtr context, int nArgs, IntPtr argsptr)
		{
			this._context = context;
			this.SetReturnValue(context, this.Invoke(this.ConvertParams(nArgs, argsptr)));
		}

		// Token: 0x0600B110 RID: 45328 RVA: 0x00054240 File Offset: 0x00052440
		internal int CompareCallback(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2)
		{
			return this.Compare(SQLiteConvert.UTF8ToString(ptr1, len1), SQLiteConvert.UTF8ToString(ptr2, len2));
		}

		// Token: 0x0600B111 RID: 45329 RVA: 0x00054258 File Offset: 0x00052458
		internal int CompareCallback16(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2)
		{
			return this.Compare(SQLite3_UTF16.UTF16ToString(ptr1, len1), SQLite3_UTF16.UTF16ToString(ptr2, len2));
		}

		// Token: 0x0600B112 RID: 45330 RVA: 0x004EB9F0 File Offset: 0x004E9BF0
		internal void StepCallback(IntPtr context, int nArgs, IntPtr argsptr)
		{
			long key = (long)this._base.AggregateContext(context);
			SQLiteFunction.AggregateData aggregateData;
			if (!this._contextDataList.TryGetValue(key, out aggregateData))
			{
				aggregateData = new SQLiteFunction.AggregateData();
				this._contextDataList[key] = aggregateData;
			}
			try
			{
				this._context = context;
				this.Step(this.ConvertParams(nArgs, argsptr), aggregateData._count, ref aggregateData._data);
			}
			finally
			{
				aggregateData._count++;
			}
		}

		// Token: 0x0600B113 RID: 45331 RVA: 0x004EBA78 File Offset: 0x004E9C78
		internal void FinalCallback(IntPtr context)
		{
			long key = (long)this._base.AggregateContext(context);
			object obj = null;
			if (this._contextDataList.ContainsKey(key))
			{
				obj = this._contextDataList[key]._data;
				this._contextDataList.Remove(key);
			}
			this._context = context;
			this.SetReturnValue(context, this.Final(obj));
			IDisposable disposable = obj as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}

		// Token: 0x0600B114 RID: 45332 RVA: 0x004EBAEC File Offset: 0x004E9CEC
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				foreach (KeyValuePair<long, SQLiteFunction.AggregateData> current in this._contextDataList)
				{
					IDisposable disposable = current.Value._data as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				this._contextDataList.Clear();
				this._InvokeFunc = null;
				this._StepFunc = null;
				this._FinalFunc = null;
				this._CompareFunc = null;
				this._base = null;
				this._contextDataList = null;
			}
		}

		// Token: 0x0600B115 RID: 45333 RVA: 0x00054270 File Offset: 0x00052470
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600B116 RID: 45334 RVA: 0x004EBB90 File Offset: 0x004E9D90
		[FileIOPermission(SecurityAction.Assert, AllFiles = FileIOPermissionAccess.PathDiscovery)]
		static SQLiteFunction()
		{
			try
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				int num = assemblies.Length;
				AssemblyName name = Assembly.GetCallingAssembly().GetName();
				int i = 0;
                Type[] types;
                while (i < num)
				{
					bool flag = false;
					
					try
					{
						AssemblyName[] referencedAssemblies = assemblies[i].GetReferencedAssemblies();
						int num2 = referencedAssemblies.Length;
						int j = 0;
						while (j < num2)
						{
							if (!(referencedAssemblies[j].Name == name.Name))
							{
								j++;
							}
							else
							{
								flag = true;
								IL_74:
								if (!flag)
								{
									goto IL_ED;
								}
								types = assemblies[i].GetTypes();
								goto IL_F6;
							}
						}
                        if (!flag)
                        {
                            goto IL_ED;
                        }
                        types = assemblies[i].GetTypes();
                        goto IL_F6; 
					}
					catch (ReflectionTypeLoadException ex)
					{
						types = ex.Types;
						goto IL_F6;
					}
					goto IL_92;
					IL_ED:
					i++;
					continue;
					IL_E8:
					int num3 = 0;
					int num4 = 0;
					if (num3 >= num4)
					{
						goto IL_ED;
					}
					goto IL_92;
					IL_F6:
					num4 = types.Length;
					num3 = 0;
					goto IL_E8;
					IL_92:
					if (types[num3] != null)
					{
						object[] customAttributes = types[num3].GetCustomAttributes(typeof(SQLiteFunctionAttribute), false);
						int num5 = customAttributes.Length;
						for (int k = 0; k < num5; k++)
						{
							SQLiteFunctionAttribute sQLiteFunctionAttribute = customAttributes[k] as SQLiteFunctionAttribute;
							if (sQLiteFunctionAttribute != null)
							{
								sQLiteFunctionAttribute._instanceType = types[num3];
								SQLiteFunction._registeredFunctions.Add(sQLiteFunctionAttribute);
							}
						}
					}
					num3++;
					goto IL_E8;
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600B117 RID: 45335 RVA: 0x004EBCC0 File Offset: 0x004E9EC0
		public static void RegisterFunction(Type typ)
		{
			object[] customAttributes = typ.GetCustomAttributes(typeof(SQLiteFunctionAttribute), false);
			int num = customAttributes.Length;
			for (int i = 0; i < num; i++)
			{
				SQLiteFunctionAttribute sQLiteFunctionAttribute = customAttributes[i] as SQLiteFunctionAttribute;
				if (sQLiteFunctionAttribute != null)
				{
					sQLiteFunctionAttribute._instanceType = typ;
					SQLiteFunction._registeredFunctions.Add(sQLiteFunctionAttribute);
				}
			}
		}

		// Token: 0x0600B118 RID: 45336 RVA: 0x004EBD10 File Offset: 0x004E9F10
		internal static SQLiteFunction[] BindFunctions(SQLiteBase sqlbase)
		{
			List<SQLiteFunction> list = new List<SQLiteFunction>();
			foreach (SQLiteFunctionAttribute current in SQLiteFunction._registeredFunctions)
			{
				SQLiteFunction sQLiteFunction = (SQLiteFunction)Activator.CreateInstance(current._instanceType);
				sQLiteFunction._base = sqlbase;
				sQLiteFunction._InvokeFunc = ((current.FuncType == FunctionType.Scalar) ? new SQLiteCallback(sQLiteFunction.ScalarCallback) : null);
				sQLiteFunction._StepFunc = ((current.FuncType == FunctionType.Aggregate) ? new SQLiteCallback(sQLiteFunction.StepCallback) : null);
				sQLiteFunction._FinalFunc = ((current.FuncType == FunctionType.Aggregate) ? new SQLiteFinalCallback(sQLiteFunction.FinalCallback) : null);
				sQLiteFunction._CompareFunc = ((current.FuncType == FunctionType.Collation) ? new SQLiteCollation(sQLiteFunction.CompareCallback) : null);
				sQLiteFunction._CompareFunc16 = ((current.FuncType == FunctionType.Collation) ? new SQLiteCollation(sQLiteFunction.CompareCallback16) : null);
				if (current.FuncType != FunctionType.Collation)
				{
					sqlbase.CreateFunction(current.Name, current.Arguments, sQLiteFunction is SQLiteFunctionEx, sQLiteFunction._InvokeFunc, sQLiteFunction._StepFunc, sQLiteFunction._FinalFunc);
				}
				else
				{
					sqlbase.CreateCollation(current.Name, sQLiteFunction._CompareFunc, sQLiteFunction._CompareFunc16);
				}
				list.Add(sQLiteFunction);
			}
			SQLiteFunction[] array = new SQLiteFunction[list.Count];
			list.CopyTo(array, 0);
			return array;
		}

		// Token: 0x04005DB7 RID: 23991
		internal SQLiteBase _base;

		// Token: 0x04005DB8 RID: 23992
		private Dictionary<long, SQLiteFunction.AggregateData> _contextDataList;

		// Token: 0x04005DB9 RID: 23993
		private SQLiteCallback _InvokeFunc;

		// Token: 0x04005DBA RID: 23994
		private SQLiteCallback _StepFunc;

		// Token: 0x04005DBB RID: 23995
		private SQLiteFinalCallback _FinalFunc;

		// Token: 0x04005DBC RID: 23996
		private SQLiteCollation _CompareFunc;

		// Token: 0x04005DBD RID: 23997
		private SQLiteCollation _CompareFunc16;

		// Token: 0x04005DBE RID: 23998
		internal IntPtr _context;

		// Token: 0x04005DBF RID: 23999
		private static List<SQLiteFunctionAttribute> _registeredFunctions = new List<SQLiteFunctionAttribute>();

		// Token: 0x02001424 RID: 5156
		private sealed class AggregateData
		{
			// Token: 0x04005DC0 RID: 24000
			internal int _count = 1;

			// Token: 0x04005DC1 RID: 24001
			internal object _data;
		}
	}
}
