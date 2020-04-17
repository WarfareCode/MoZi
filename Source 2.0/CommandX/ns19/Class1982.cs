using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;
using ns32;

namespace ns19
{
	// Token: 0x02000431 RID: 1073
	public sealed class Class1982 : Class1981
	{
		// Token: 0x06001B89 RID: 7049 RVA: 0x000B11A4 File Offset: 0x000AF3A4
		public Class1982(Class1972 class1972_1, Class1971 class1971_0, int int_0, int int_1, int int_2) : base(class1971_0)
		{
			this.class1972_0 = class1972_1;
			this.class1984_0.string_4 = string.Format(CultureInfo.InvariantCulture, "{0}?T={1}&L={2}&X={3}&Y={4}", new object[]
			{
				class1971_0.method_0(),
				class1971_0.method_1(),
				int_2,
				int_1,
				int_0
			});
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x000B1210 File Offset: 0x000AF410
		protected void method_3()
		{
			if (this.class1984_0.string_6 == "application/zip")
			{
				string text = this.class1984_0.string_5 + ".zip";
				DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(text) + "\\" + DateTime.Now.Ticks.ToString());
				directoryInfo.Create();
				string text2 = Path.Combine(directoryInfo.FullName, Path.GetFileNameWithoutExtension(this.class1984_0.string_5));
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(text2))
				{
					File.Delete(text2);
				}
				if (File.Exists(base.method_1()))
				{
					File.Delete(base.method_1());
				}
				File.Move(this.class1984_0.string_5, text);
				new Class2458().method_1(text, directoryInfo.FullName, "");
				File.Move(text2, base.method_1());
				try
				{
					File.Delete(text);
					directoryInfo.Delete();
					return;
				}
				catch
				{
					return;
				}
			}
			if (this.class1984_0.string_6 == "application/x-7z-compressed" || this.class1984_0.string_6 == "application/x-compressed")
			{
				string text3 = this.class1984_0.string_5 + ".7z";
				string directoryName = Path.GetDirectoryName(Path.GetDirectoryName(this.class1984_0.string_5));
				string text4 = Path.Combine(directoryName, Path.GetFileNameWithoutExtension(this.class1984_0.string_5));
				if (File.Exists(text3))
				{
					File.Delete(text3);
				}
				if (File.Exists(text4))
				{
					File.Delete(text4);
				}
				File.Move(this.class1984_0.string_5, text3);
				using (Process process = Process.Start(new ProcessStartInfo(Path.GetDirectoryName(Application.ExecutablePath) + "\\System\\7za.exe")
				{
					UseShellExecute = false,
					CreateNoWindow = true,
					Arguments = string.Format(CultureInfo.InvariantCulture, " x -y -o\"{1}\" \"{0}\"", new object[]
					{
						text3,
						directoryName
					})
				}))
				{
					process.WaitForExit();
					if (process.ExitCode != 0)
					{
						throw new ApplicationException(string.Format("7z decompression of file '{0}' failed.", text3));
					}
				}
				File.Delete(text3);
				File.Move(text4, base.method_1());
			}
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x000B14A4 File Offset: 0x000AF6A4
		protected override void vmethod_5()
		{
			try
			{
				this.class1984_0.method_11();
				this.method_3();
			}
			catch (FileNotFoundException)
			{
				this.method_5();
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
				if (httpWebResponse != null && httpWebResponse.StatusCode == HttpStatusCode.NotFound)
				{
					this.method_5();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x000B1528 File Offset: 0x000AF728
		public void method_4()
		{
			try
			{
				this.class1984_0.method_6(this.class1984_0.string_5);
				this.method_3();
			}
			catch (FileNotFoundException)
			{
				this.method_5();
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
				if (httpWebResponse != null && httpWebResponse.StatusCode == HttpStatusCode.NotFound)
				{
					this.method_5();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x000B15B8 File Offset: 0x000AF7B8
		private void method_5()
		{
			using (File.Create(base.method_1()))
			{
			}
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x000B1010 File Offset: 0x000AF210
		public override float vmethod_2()
		{
			return 0f;
		}

		// Token: 0x04000BC7 RID: 3015
		public Class1972 class1972_0;
	}
}
