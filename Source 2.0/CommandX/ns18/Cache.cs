using System;
using System.Collections;
using System.IO;
using System.Threading;
using ns17;

namespace ns18
{
	// Token: 0x02000357 RID: 855
	public sealed class Cache : IDisposable
	{
		// Token: 0x06001421 RID: 5153 RVA: 0x00087F44 File Offset: 0x00086144
		public Cache(string string_1, TimeSpan timeSpan_1, TimeSpan timeSpan_2)
		{
			this.CleanupFrequency = timeSpan_1;
			this.CacheDirectory = string_1;
			Directory.CreateDirectory(this.CacheDirectory);
			double num = timeSpan_1.TotalSeconds - timeSpan_2.TotalSeconds % timeSpan_1.TotalSeconds;
			this.m_timer = new Timer(new TimerCallback(this.method_0), null, (long)(num * 1000.0), (long)timeSpan_1.TotalMilliseconds);
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00087FD4 File Offset: 0x000861D4
		private void method_0(object object_0)
		{
			try
			{
				Thread.CurrentThread.Priority = ThreadPriority.BelowNormal;
				long num = Cache.smethod_1(new DirectoryInfo(this.CacheDirectory));
				if (num >= this.CacheUpperLimit)
				{
					ArrayList arrayList = Cache.smethod_0(new DirectoryInfo(this.CacheDirectory));
					while (true)
					{
						if (num > this.CacheLowerLimit)
						{
							goto IL_F6;
						}
						bool arg_42_0 = false;
						IL_42:
						if (!arg_42_0)
						{
							break;
						}
						FileInfo fileInfo = null;
						foreach (FileInfo fileInfo2 in arrayList)
						{
							if (fileInfo == null)
							{
								fileInfo = fileInfo2;
							}
							else if (fileInfo2.LastAccessTimeUtc < fileInfo.LastAccessTimeUtc)
							{
								fileInfo = fileInfo2;
							}
						}
						arrayList.Remove(fileInfo);
						num -= fileInfo.Length;
						try
						{
							File.Delete(fileInfo.FullName);
							string path = fileInfo.Directory.FullName;
							while (Directory.GetFileSystemEntries(path).Length == 0)
							{
								Directory.Delete(path);
								path = Path.GetDirectoryName(path);
							}
							continue;
						}
						catch (IOException)
						{
							continue;
						}
						IL_F6:
						arg_42_0 = (arrayList.Count > 100);
						goto IL_42;
					}
				}
			}
			catch (Exception ex)
			{
				Log.Write(Log.Levels.Error, "CACH", ex.Message);
			}
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0008815C File Offset: 0x0008635C
		public static ArrayList smethod_0(DirectoryInfo directoryInfo_0)
		{
			ArrayList arrayList = new ArrayList();
			DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
			for (int i = 0; i < directories.Length; i++)
			{
				DirectoryInfo directoryInfo_ = directories[i];
				arrayList.AddRange(Cache.smethod_0(directoryInfo_));
			}
			FileInfo[] files = directoryInfo_0.GetFiles();
			for (int i = 0; i < files.Length; i++)
			{
				FileInfo value = files[i];
				arrayList.Add(value);
			}
			return arrayList;
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x000881C4 File Offset: 0x000863C4
		public static long smethod_1(DirectoryInfo directoryInfo_0)
		{
			long num = 0L;
			DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
			for (int i = 0; i < directories.Length; i++)
			{
				DirectoryInfo directoryInfo_ = directories[i];
				num += Cache.smethod_1(directoryInfo_);
			}
			FileInfo[] files = directoryInfo_0.GetFiles();
			for (int i = 0; i < files.Length; i++)
			{
				FileInfo fileInfo = files[i];
				try
				{
					num += fileInfo.Length;
				}
				catch (IOException)
				{
				}
			}
			return num;
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00088244 File Offset: 0x00086444
		public override string ToString()
		{
			return this.CacheDirectory;
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0000E522 File Offset: 0x0000C722
		public void Dispose()
		{
			if (this.m_timer != null)
			{
				this.m_timer.Dispose();
				this.m_timer = null;
			}
		}

		// Token: 0x04000864 RID: 2148
		public long CacheUpperLimit = -2147483648L;

		// Token: 0x04000865 RID: 2149
		public long CacheLowerLimit = 1610612736L;

		// Token: 0x04000866 RID: 2150
		public string CacheDirectory;

		// Token: 0x04000867 RID: 2151
		public TimeSpan CleanupFrequency;

		// Token: 0x04000868 RID: 2152
		private Timer m_timer;
	}
}
