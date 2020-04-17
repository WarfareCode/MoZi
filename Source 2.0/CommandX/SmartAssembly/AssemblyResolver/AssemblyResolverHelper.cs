using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Zip;

namespace SmartAssembly.AssemblyResolver
{
	// Token: 0x02001271 RID: 4721
	internal sealed class AssemblyResolverHelper
	{
		// Token: 0x0600A6C1 RID: 42689
		[DllImport("kernel32")]
		private static extern bool MoveFileEx(string existingFileName, string newFileName, int flags);

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x0600A6C2 RID: 42690 RVA: 0x004DE44C File Offset: 0x004DC64C
		internal static bool IsWebApplication
		{
			get
			{
				try
				{
					string a = Process.GetCurrentProcess().MainModule.ModuleName.ToLower();
					if (a == "w3wp.exe")
					{
						bool result = true;
						return result;
					}
					if (a == "aspnet_wp.exe")
					{
						bool result = true;
						return result;
					}
				}
				catch
				{
				}
				return false;
			}
		}

		// Token: 0x0600A6C3 RID: 42691 RVA: 0x004DE4A8 File Offset: 0x004DC6A8
		internal static void Attach()
		{
			try
			{
				AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolverHelper.ResolveAssembly);
			}
			catch
			{
			}
		}

		// Token: 0x0600A6C4 RID: 42692 RVA: 0x004DE4E0 File Offset: 0x004DC6E0
		internal static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
		{
            AssemblyInfo info = new AssemblyInfo(e.Name);
            string assemblyFullName = info.GetAssemblyFullName(false);
            string str2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(assemblyFullName));
            string[] strArray = "ezcyOWY4MmUzLWIzZmItNGM5Yy1hMjhiLWZhYzVhMjliOTMwNn0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{bae19801-eb81-4bce-9df1-8513ca079daf},ezcyOWY4MmUzLWIzZmItNGM5Yy1hMjhiLWZhYzVhMjliOTMwNn0=,[z]{bae19801-eb81-4bce-9df1-8513ca079daf},S2VyYUx1YSwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj0wNGQwNDU4Njc4NmM2ZjM0,{6fce71d0-964e-42c7-90ac-8b513d47fccf},S2VyYUx1YQ==,{6fce71d0-964e-42c7-90ac-8b513d47fccf},TmV3dG9uc29mdC5Kc29uLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPTMwYWQ0ZmU2YjJhNmFlZWQ=,[z]{cfba50cd-fb13-4a21-89f9-73deee94d2fe},TmV3dG9uc29mdC5Kc29u,[z]{cfba50cd-fb13-4a21-89f9-73deee94d2fe},Tkx1YSwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj04ZGYyYWI1MTgwMzBlYTk1,{eaa1d04d-4891-4ba3-a369-6a26ed9c5c3e},Tkx1YQ==,{eaa1d04d-4891-4ba3-a369-6a26ed9c5c3e}".Split(new char[] { ',' });
            string key = string.Empty;
            bool flag = false;
            bool flag2 = false;
            for (int i = 0; i < (strArray.Length - 1); i += 2)
            {
                if (strArray[i] == str2)
                {
                    key = strArray[i + 1];
                    break;
                }
            }
            if ((key.Length == 0) && (info.PublicKeyToken.Length == 0))
            {
                str2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(info.Name));
                for (int j = 0; j < (strArray.Length - 1); j += 2)
                {
                    if (strArray[j] == str2)
                    {
                        key = strArray[j + 1];
                        break;
                    }
                }
            }
            if (key.Length > 0)
            {
                if (key[0] == '[')
                {
                    int index = key.IndexOf(']');
                    string str4 = key.Substring(1, index - 1);
                    flag = str4.IndexOf('z') >= 0;
                    flag2 = str4.IndexOf('t') >= 0;
                    key = key.Substring(index + 1);
                }
                lock (hashtable)
                {
                    if (hashtable.ContainsKey(key))
                    {
                        return (Assembly)hashtable[key];
                    }
                    Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(key);
                    if (manifestResourceStream != null)
                    {
                        int length = (int)manifestResourceStream.Length;
                        byte[] buffer = new byte[length];
                        manifestResourceStream.Read(buffer, 0, length);
                        if (flag)
                        {
                            buffer = SimpleZip.Unzip(buffer);
                        }
                        Assembly assembly = null;
                        if (!flag2)
                        {
                            try
                            {
                                assembly = Assembly.Load(buffer);
                            }
                            catch (FileLoadException)
                            {
                                flag2 = true;
                            }
                            catch (BadImageFormatException)
                            {
                                flag2 = true;
                            }
                        }
                        if (flag2)
                        {
                            try
                            {
                                string path = string.Format(@"{0}{1}\", Path.GetTempPath(), key);
                                Directory.CreateDirectory(path);
                                string str6 = path + info.Name + ".dll";
                                if (!File.Exists(str6))
                                {
                                    FileStream stream2 = File.OpenWrite(str6);
                                    stream2.Write(buffer, 0, buffer.Length);
                                    stream2.Close();
                                    MoveFileEx(str6, null, 4);
                                    MoveFileEx(path, null, 4);
                                }
                                assembly = Assembly.LoadFile(str6);
                            }
                            catch
                            {
                            }
                        }
                        hashtable[key] = assembly;
                        return assembly;
                    }
                }
            }
            return null;
        }

		// Token: 0x04005645 RID: 22085
		internal const string BindList = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

		// Token: 0x04005646 RID: 22086
		private const int MOVEFILE_DELAY_UNTIL_REBOOT = 4;

		// Token: 0x04005647 RID: 22087
		private static Hashtable hashtable = new Hashtable();

		// Token: 0x02001272 RID: 4722
		internal struct AssemblyInfo
		{
			// Token: 0x0600A6C7 RID: 42695 RVA: 0x004DE7B8 File Offset: 0x004DC9B8
			public string GetAssemblyFullName(bool includeVersion)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(this.Name);
				if (includeVersion && this.Version != null)
				{
					stringBuilder.Append(", Version=");
					stringBuilder.Append(this.Version);
				}
				stringBuilder.Append(", Culture=");
				stringBuilder.Append((this.Culture.Length == 0) ? "neutral" : this.Culture);
				stringBuilder.Append(", PublicKeyToken=");
				stringBuilder.Append((this.PublicKeyToken.Length == 0) ? "null" : this.PublicKeyToken);
				return stringBuilder.ToString();
			}

			// Token: 0x0600A6C8 RID: 42696 RVA: 0x004DE864 File Offset: 0x004DCA64
			public AssemblyInfo(string assemblyFullName)
			{
				this.Version = null;
				this.Culture = string.Empty;
				this.PublicKeyToken = string.Empty;
				this.Name = string.Empty;
				string[] array = assemblyFullName.Split(new char[]
				{
					','
				});
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					string text2 = text.Trim();
					if (text2.StartsWith("Version="))
					{
						this.Version = new Version(text2.Substring(8));
					}
					else if (text2.StartsWith("Culture="))
					{
						this.Culture = text2.Substring(8);
						if (this.Culture == "neutral")
						{
							this.Culture = string.Empty;
						}
					}
					else if (text2.StartsWith("PublicKeyToken="))
					{
						this.PublicKeyToken = text2.Substring(15);
						if (this.PublicKeyToken == "null")
						{
							this.PublicKeyToken = string.Empty;
						}
					}
					else
					{
						this.Name = text2;
					}
				}
			}

			// Token: 0x04005648 RID: 22088
			public string Name;

			// Token: 0x04005649 RID: 22089
			public Version Version;

			// Token: 0x0400564A RID: 22090
			public string Culture;

			// Token: 0x0400564B RID: 22091
			public string PublicKeyToken;
		}
	}
}
