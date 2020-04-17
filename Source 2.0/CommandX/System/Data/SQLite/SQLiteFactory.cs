using System;
using System.Data.Common;
using System.Reflection;
using System.Security.Permissions;

namespace System.Data.SQLite
{
	// Token: 0x0200142D RID: 5165
	public sealed class SQLiteFactory : DbProviderFactory, IServiceProvider
	{
		// Token: 0x0600B12A RID: 45354 RVA: 0x000542F4 File Offset: 0x000524F4
		public override DbCommand CreateCommand()
		{
			return new SQLiteCommand();
		}

		// Token: 0x0600B12B RID: 45355 RVA: 0x000542FB File Offset: 0x000524FB
		public override DbCommandBuilder CreateCommandBuilder()
		{
			return new SQLiteCommandBuilder();
		}

		// Token: 0x0600B12C RID: 45356 RVA: 0x00054302 File Offset: 0x00052502
		public override DbConnection CreateConnection()
		{
			return new SQLiteConnection();
		}

		// Token: 0x0600B12D RID: 45357 RVA: 0x00054309 File Offset: 0x00052509
		public override DbConnectionStringBuilder CreateConnectionStringBuilder()
		{
			return new SQLiteConnectionStringBuilder();
		}

		// Token: 0x0600B12E RID: 45358 RVA: 0x00054310 File Offset: 0x00052510
		public override DbDataAdapter CreateDataAdapter()
		{
			return new SQLiteDataAdapter();
		}

		// Token: 0x0600B12F RID: 45359 RVA: 0x00054317 File Offset: 0x00052517
		public override DbParameter CreateParameter()
		{
			return new SQLiteParameter();
		}

		// Token: 0x0600B131 RID: 45361 RVA: 0x0005433A File Offset: 0x0005253A
		object IServiceProvider.GetService(Type serviceType)
		{
			if (serviceType != typeof(ISQLiteSchemaExtensions))
			{
				if (SQLiteFactory._dbProviderServicesType == null || serviceType != SQLiteFactory._dbProviderServicesType)
				{
					return null;
				}
			}
			return this.GetSQLiteProviderServicesInstance();
		}

		// Token: 0x0600B132 RID: 45362 RVA: 0x004EBE90 File Offset: 0x004EA090
		[ReflectionPermission(SecurityAction.Assert, MemberAccess = true)]
		private object GetSQLiteProviderServicesInstance()
		{
			if (SQLiteFactory._sqliteServices == null)
			{
				Type type = Type.GetType("System.Data.SQLite.SQLiteProviderServices, System.Data.SQLite.Linq, Version=2.0.38.0, Culture=neutral, PublicKeyToken=db937bc2d44ff139", false);
				if (type != null)
				{
					FieldInfo field = type.GetField("Instance", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);
					SQLiteFactory._sqliteServices = field.GetValue(null);
				}
			}
			return SQLiteFactory._sqliteServices;
		}

		// Token: 0x04005DD3 RID: 24019
		public static readonly SQLiteFactory Instance = new SQLiteFactory();

		// Token: 0x04005DD4 RID: 24020
		private static Type _dbProviderServicesType = Type.GetType("System.Data.Common.DbProviderServices, System.Data.Entity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", false);

		// Token: 0x04005DD5 RID: 24021
		private static object _sqliteServices;
	}
}
