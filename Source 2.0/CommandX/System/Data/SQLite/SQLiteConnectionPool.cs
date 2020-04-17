using System;
using System.Collections.Generic;

namespace System.Data.SQLite
{
	// Token: 0x02001414 RID: 5140
	internal static class SQLiteConnectionPool
	{
		// Token: 0x0600B049 RID: 45129 RVA: 0x004E747C File Offset: 0x004E567C
		internal static SQLiteConnectionHandle Remove(string fileName, int maxPoolSize, out int version)
		{
			SQLiteConnectionHandle result;
			lock (SQLiteConnectionPool._connections)
			{
				version = SQLiteConnectionPool._poolVersion;
				SQLiteConnectionPool.Pool pool;
				if (!SQLiteConnectionPool._connections.TryGetValue(fileName, out pool))
				{
					pool = new SQLiteConnectionPool.Pool(SQLiteConnectionPool._poolVersion, maxPoolSize);
					SQLiteConnectionPool._connections.Add(fileName, pool);
					result = null;
				}
				else
				{
					version = pool.PoolVersion;
					pool.MaxPoolSize = maxPoolSize;
					SQLiteConnectionPool.ResizePool(pool, false);
					while (pool.Queue.Count > 0)
					{
						WeakReference weakReference = pool.Queue.Dequeue();
						SQLiteConnectionHandle sQLiteConnectionHandle = weakReference.Target as SQLiteConnectionHandle;
						if (sQLiteConnectionHandle != null)
						{
							result = sQLiteConnectionHandle;
							return result;
						}
					}
					result = null;
				}
			}
			return result;
		}

		// Token: 0x0600B04A RID: 45130 RVA: 0x004E752C File Offset: 0x004E572C
		internal static void ClearAllPools()
		{
			lock (SQLiteConnectionPool._connections)
			{
				foreach (KeyValuePair<string, SQLiteConnectionPool.Pool> current in SQLiteConnectionPool._connections)
				{
					while (current.Value.Queue.Count > 0)
					{
						WeakReference weakReference = current.Value.Queue.Dequeue();
						SQLiteConnectionHandle sQLiteConnectionHandle = weakReference.Target as SQLiteConnectionHandle;
						if (sQLiteConnectionHandle != null)
						{
							sQLiteConnectionHandle.Dispose();
						}
					}
					if (SQLiteConnectionPool._poolVersion <= current.Value.PoolVersion)
					{
						SQLiteConnectionPool._poolVersion = current.Value.PoolVersion + 1;
					}
				}
				SQLiteConnectionPool._connections.Clear();
			}
		}

		// Token: 0x0600B04B RID: 45131 RVA: 0x004E7604 File Offset: 0x004E5804
		internal static void ClearPool(string fileName)
		{
			lock (SQLiteConnectionPool._connections)
			{
				SQLiteConnectionPool.Pool pool;
				if (SQLiteConnectionPool._connections.TryGetValue(fileName, out pool))
				{
					pool.PoolVersion++;
					while (pool.Queue.Count > 0)
					{
						WeakReference weakReference = pool.Queue.Dequeue();
						SQLiteConnectionHandle sQLiteConnectionHandle = weakReference.Target as SQLiteConnectionHandle;
						if (sQLiteConnectionHandle != null)
						{
							sQLiteConnectionHandle.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x0600B04C RID: 45132 RVA: 0x004E7684 File Offset: 0x004E5884
		internal static void Add(string fileName, SQLiteConnectionHandle hdl, int version)
		{
			lock (SQLiteConnectionPool._connections)
			{
				SQLiteConnectionPool.Pool pool;
				if (SQLiteConnectionPool._connections.TryGetValue(fileName, out pool) && version == pool.PoolVersion)
				{
					SQLiteConnectionPool.ResizePool(pool, true);
					pool.Queue.Enqueue(new WeakReference(hdl, false));
					GC.KeepAlive(hdl);
				}
				else
				{
					hdl.Close();
				}
			}
		}

		// Token: 0x0600B04D RID: 45133 RVA: 0x004E76F8 File Offset: 0x004E58F8
		private static void ResizePool(SQLiteConnectionPool.Pool queue, bool forAdding)
		{
			int num = queue.MaxPoolSize;
			if (forAdding && num > 0)
			{
				num--;
			}
			while (queue.Queue.Count > num)
			{
				WeakReference weakReference = queue.Queue.Dequeue();
				SQLiteConnectionHandle sQLiteConnectionHandle = weakReference.Target as SQLiteConnectionHandle;
				if (sQLiteConnectionHandle != null)
				{
					sQLiteConnectionHandle.Dispose();
				}
			}
		}

		// Token: 0x04005D8F RID: 23951
		private static SortedList<string, SQLiteConnectionPool.Pool> _connections = new SortedList<string, SQLiteConnectionPool.Pool>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x04005D90 RID: 23952
		private static int _poolVersion = 1;

		// Token: 0x02001415 RID: 5141
		internal sealed class Pool
		{
			// Token: 0x0600B04F RID: 45135 RVA: 0x00053DD0 File Offset: 0x00051FD0
			internal Pool(int version, int maxSize)
			{
				this.PoolVersion = version;
				this.MaxPoolSize = maxSize;
			}

			// Token: 0x04005D91 RID: 23953
			internal readonly Queue<WeakReference> Queue = new Queue<WeakReference>();

			// Token: 0x04005D92 RID: 23954
			internal int PoolVersion;

			// Token: 0x04005D93 RID: 23955
			internal int MaxPoolSize;
		}
	}
}
