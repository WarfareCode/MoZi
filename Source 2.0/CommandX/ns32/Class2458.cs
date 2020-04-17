using System;
using System.IO;
using ns31;

namespace ns32
{
	// Token: 0x020004EC RID: 1260
	public sealed class Class2458
	{
		// Token: 0x060020DE RID: 8414 RVA: 0x00013C2A File Offset: 0x00011E2A
		public Class2458()
		{
			this.class2457_0 = null;
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00013C4E File Offset: 0x00011E4E
		public bool method_0()
		{
			return this.bool_1;
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x00013C56 File Offset: 0x00011E56
		public void method_1(string string_2, string string_3, string string_4)
		{
			this.method_2(string_2, string_3, Class2458.Enum180.const_2, null, string_4, null);
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x000D5484 File Offset: 0x000D3684
		public void method_2(string string_2, string string_3, Class2458.Enum180 enum180_1, Class2458.Delegate46 delegate46_1, string string_4, string string_5)
		{
			if (enum180_1 == Class2458.Enum180.const_0 && delegate46_1 == null)
			{
				throw new ArgumentNullException("confirmDelegate");
			}
			this.enum180_0 = enum180_1;
			this.delegate46_0 = delegate46_1;
			this.string_1 = string_3;
			this.class2456_0 = new Class2456(string_4);
			this.class2456_1 = new Class2456(string_5);
			this.stream3_0 = new Stream3(File.OpenRead(string_2));
			try
			{
				if (this.string_0 != null)
				{
					this.stream3_0.method_3(this.string_0);
				}
				Class2437 @class;
				while ((@class = this.stream3_0.method_4()) != null)
				{
					if (this.class2456_1.method_2(Path.GetDirectoryName(@class.method_9())) && this.class2456_0.method_2(@class.method_9()))
					{
						this.method_5(@class);
					}
				}
			}
			finally
			{
				this.stream3_0.Close();
			}
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x000D5578 File Offset: 0x000D3778
		private void method_3(Class2437 class2437_0, string string_2)
		{
			bool flag = true;
			if (this.enum180_0 == Class2458.Enum180.const_0 && this.delegate46_0 != null && File.Exists(string_2))
			{
				flag = this.delegate46_0(string_2);
			}
			if (flag)
			{
				if (this.class2457_0 != null)
				{
					this.class2457_0.method_0(class2437_0.method_9());
				}
				FileStream fileStream = File.Create(string_2);
				try
				{
					if (this.byte_0 == null)
					{
						this.byte_0 = new byte[4096];
					}
					int num;
					do
					{
						num = this.stream3_0.Read(this.byte_0, 0, this.byte_0.Length);
						fileStream.Write(this.byte_0, 0, num);
					}
					while (num > 0);
				}
				finally
				{
					fileStream.Close();
				}
				if (this.bool_0)
				{
					File.SetLastWriteTime(string_2, class2437_0.method_7());
				}
			}
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00013C64 File Offset: 0x00011E64
		private bool method_4(string string_2)
		{
			return string_2 != null && string_2.Length > 0 && string_2.IndexOfAny(Path.InvalidPathChars) < 0;
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x000D5660 File Offset: 0x000D3860
		private void method_5(Class2437 class2437_0)
		{
			bool flag = this.method_4(class2437_0.method_9());
			string path = null;
			string text = null;
			if (flag)
			{
				string text3;
				if (Path.IsPathRooted(class2437_0.method_9()))
				{
					string text2 = Path.GetPathRoot(class2437_0.method_9());
					text2 = class2437_0.method_9().Substring(text2.Length);
					text3 = Path.Combine(Path.GetDirectoryName(text2), Path.GetFileName(class2437_0.method_9()));
				}
				else
				{
					text3 = class2437_0.method_9();
				}
				text = Path.Combine(this.string_1, text3);
				path = Path.GetDirectoryName(Path.GetFullPath(text));
				flag = (flag && text3.Length > 0);
			}
			if (flag && !Directory.Exists(path))
			{
				if (class2437_0.method_16())
				{
					if (!this.method_0())
					{
						goto IL_C2;
					}
				}
				try
				{
					Directory.CreateDirectory(path);
				}
				catch
				{
					flag = false;
				}
			}
			IL_C2:
			if (flag && class2437_0.method_17())
			{
				this.method_3(class2437_0, text);
			}
		}

		// Token: 0x04000FD7 RID: 4055
		private byte[] byte_0;

		// Token: 0x04000FD8 RID: 4056
		private Stream3 stream3_0;

		// Token: 0x04000FD9 RID: 4057
		private string string_0 = null;

		// Token: 0x04000FDA RID: 4058
		private string string_1;

		// Token: 0x04000FDB RID: 4059
		private Class2456 class2456_0;

		// Token: 0x04000FDC RID: 4060
		private Class2456 class2456_1;

		// Token: 0x04000FDD RID: 4061
		private Class2458.Enum180 enum180_0;

		// Token: 0x04000FDE RID: 4062
		private Class2458.Delegate46 delegate46_0;

		// Token: 0x04000FDF RID: 4063
		private bool bool_0 = false;

		// Token: 0x04000FE0 RID: 4064
		private bool bool_1 = false;

		// Token: 0x04000FE1 RID: 4065
		private Class2457 class2457_0;

		// Token: 0x020004ED RID: 1261
		public enum Enum180
		{
			// Token: 0x04000FE3 RID: 4067
			const_0,
			// Token: 0x04000FE4 RID: 4068
			const_1,
			// Token: 0x04000FE5 RID: 4069
			const_2
		}

		// Token: 0x020004EE RID: 1262
		// (Invoke) Token: 0x060020E6 RID: 8422
		public delegate bool Delegate46(string fileName);
	}
}
