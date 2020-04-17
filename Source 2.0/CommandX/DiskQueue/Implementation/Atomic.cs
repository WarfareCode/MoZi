using System;
using System.IO;
using System.Threading;

namespace DiskQueue.Implementation
{
	// Token: 0x02000004 RID: 4
	public static class Atomic
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00055750 File Offset: 0x00053950
		public static void Read(string path, Action<Stream> action)
		{
			lock (Atomic._lock)
			{
				if (File.Exists(path + ".old_copy") && Atomic.WaitDelete(path))
				{
					File.Move(path + ".old_copy", path);
				}
				using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None, 65536, FileOptions.SequentialScan))
				{
					SetPermissions.TryAllowReadWriteForAll(path);
					action(fileStream);
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000557FC File Offset: 0x000539FC
		public static void Write(string path, Action<Stream> action)
		{
			lock (Atomic._lock)
			{
				if (!File.Exists(path + ".old_copy"))
				{
					File.Move(path, path + ".old_copy");
				}
				using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 65536, FileOptions.WriteThrough | FileOptions.SequentialScan))
				{
					SetPermissions.TryAllowReadWriteForAll(path);
					action(fileStream);
					fileStream.Flush();
				}
				Atomic.WaitDelete(path + ".old_copy");
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000558B0 File Offset: 0x00053AB0
		private static bool WaitDelete(string s)
		{
			bool result;
			for (int i = 0; i < 5; i++)
			{
				try
				{
					File.Delete(s);
					result = true;
					return result;
				}
				catch
				{
					Thread.Sleep(100);
				}
			}
			result = false;
			return result;
		}

		// Token: 0x0400000D RID: 13
		private static readonly object _lock = new object();
	}
}
