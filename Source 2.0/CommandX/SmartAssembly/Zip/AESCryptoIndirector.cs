using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace SmartAssembly.Zip
{
	// Token: 0x02001282 RID: 4738
	public sealed class AESCryptoIndirector : IDisposable
	{
		// Token: 0x0600A6E5 RID: 42725 RVA: 0x004DF1B4 File Offset: 0x004DD3B4
		public AESCryptoIndirector()
		{
			try
			{
				Assembly assembly = Assembly.Load("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
				this.m_AcspType = assembly.GetType("System.Security.Cryptography.AesManaged");
			}
			catch (FileNotFoundException)
			{
				Assembly assembly = Assembly.Load("mscorlib");
				this.m_AcspType = assembly.GetType("System.Security.Cryptography.RijndaelManaged");
			}
			this.m_AESCryptoServiceProvider = Activator.CreateInstance(this.m_AcspType);
		}

		// Token: 0x0600A6E6 RID: 42726 RVA: 0x004DF228 File Offset: 0x004DD428
		public ICryptoTransform GetAESCryptoTransform(byte[] key, byte[] iv, bool decrypt)
		{
			this.m_AcspType.GetProperty("Key").GetSetMethod().Invoke(this.m_AESCryptoServiceProvider, new object[]
			{
				key
			});
			this.m_AcspType.GetProperty("IV").GetSetMethod().Invoke(this.m_AESCryptoServiceProvider, new object[]
			{
				iv
			});
			MethodInfo method = this.m_AcspType.GetMethod(decrypt ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
			return (ICryptoTransform)method.Invoke(this.m_AESCryptoServiceProvider, new object[0]);
		}

		// Token: 0x0600A6E7 RID: 42727 RVA: 0x0004F6BA File Offset: 0x0004D8BA
		public void Clear()
		{
			this.m_AcspType.GetMethod("Clear").Invoke(this.m_AESCryptoServiceProvider, new object[0]);
		}

		// Token: 0x0600A6E8 RID: 42728 RVA: 0x0004F6DE File Offset: 0x0004D8DE
		public void Dispose()
		{
			this.Clear();
		}

		// Token: 0x04005659 RID: 22105
		private readonly Type m_AcspType;

		// Token: 0x0400565A RID: 22106
		private readonly object m_AESCryptoServiceProvider;
	}
}
