using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace ns17
{
	// Token: 0x020006E8 RID: 1768
	public sealed class Log
	{
		// Token: 0x06002C45 RID: 11333 RVA: 0x00004A21 File Offset: 0x00002C21
		private Log()
		{
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x00018020 File Offset: 0x00016220
		public static void smethod_0(string string_1)
		{
			Log.smethod_2(Log.Levels.Error, string_1);
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x00101A44 File Offset: 0x000FFC44
		public static void Write(int int_1, string string_1, string string_2)
		{
			if (Log.streamWriter_0 != null && int_1 <= Log.int_0)
			{
				try
				{
					StreamWriter streamWriter = Log.streamWriter_0;
					lock (streamWriter)
					{
						string value = string.Format("{0} {1} {2} {3}", new object[]
						{
							DateTime.Now.ToString("u"),
							int_1,
							string_1.PadRight(4, ' ').Substring(0, 4),
							string_2
						});
						Log.streamWriter_0.WriteLine(value);
					}
				}
				catch (Exception innerException)
				{
					throw new ApplicationException(string.Format("Unexpected logging error on write(1)", new object[0]), innerException);
				}
			}
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x0001802D File Offset: 0x0001622D
		public static void smethod_2(int int_1, string string_1)
		{
			Log.Write(int_1, "", string_1);
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x00101B18 File Offset: 0x000FFD18
		public static void smethod_3(Exception exception_0)
		{
			if (Log.streamWriter_0 != null && !(exception_0 is ThreadAbortException))
			{
				try
				{
					StreamWriter streamWriter = Log.streamWriter_0;
					lock (streamWriter)
					{
						string[] array = null;
						if (exception_0.StackTrace != null)
						{
							array = exception_0.StackTrace.Split(new char[]
							{
								'\n'
							});
							string arg_6D_0 = array[0].Trim().Split(" (".ToCharArray())[1];
						}
						if (Log.string_0 != null)
						{
							string path = string.Format("DEBUG_{0}.txt", DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ffff"));
							using (StreamWriter streamWriter2 = new StreamWriter(Path.Combine(Log.string_0, path), false))
							{
								streamWriter2.WriteLine(exception_0.ToString());
							}
						}
						Log.smethod_2(Log.Levels.Error, "caught exception: ");
						Log.smethod_2(Log.Levels.Error, exception_0.ToString());
						string[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							string string_ = array2[i];
							Log.smethod_2(Log.Levels.int_2, string_);
						}
					}
				}
				catch (Exception innerException)
				{
					throw new ApplicationException(string.Format("{0}\nUnexpected logging error on write(2)", exception_0.Message), innerException);
				}
			}
		}

		// Token: 0x040014EA RID: 5354
		private static StreamWriter streamWriter_0;

		// Token: 0x040014EB RID: 5355
		private static string string_0;

		// Token: 0x040014EC RID: 5356
		public static int int_0;

		// Token: 0x020006E9 RID: 1769
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		internal struct Levels
		{
			// Token: 0x040014ED RID: 5357
			public static readonly int Error = 0;

			// Token: 0x040014EE RID: 5358
			public static readonly int int_1 = 2;

			// Token: 0x040014EF RID: 5359
			public static readonly int int_2 = 5;

			// Token: 0x040014F0 RID: 5360
			public static readonly int int_3 = 7;
		}
	}
}
