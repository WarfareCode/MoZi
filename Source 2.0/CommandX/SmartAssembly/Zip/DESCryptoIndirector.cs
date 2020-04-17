using System;
using System.Reflection;
using System.Security.Cryptography;

namespace SmartAssembly.Zip
{
	// Token: 0x02001283 RID: 4739
	public sealed class DESCryptoIndirector : IDisposable
	{
		// Token: 0x0600A6E9 RID: 42729 RVA: 0x004DF2C8 File Offset: 0x004DD4C8
		public DESCryptoIndirector()
		{
			Assembly assembly = Assembly.Load("mscorlib");
			this.m_DcspType = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
			this.m_DESCryptoServiceProvider = Activator.CreateInstance(this.m_DcspType);
		}

		// Token: 0x0600A6EA RID: 42730 RVA: 0x004DF308 File Offset: 0x004DD508
		public ICryptoTransform GetDESCryptoTransform(byte[] key, byte[] iv, bool decrypt)
		{
			this.m_DcspType.GetProperty("Key").GetSetMethod().Invoke(this.m_DESCryptoServiceProvider, new object[]
			{
				key
			});
			this.m_DcspType.GetProperty("IV").GetSetMethod().Invoke(this.m_DESCryptoServiceProvider, new object[]
			{
				iv
			});
			MethodInfo method = this.m_DcspType.GetMethod(decrypt ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
			return (ICryptoTransform)method.Invoke(this.m_DESCryptoServiceProvider, new object[0]);
		}

		// Token: 0x0600A6EB RID: 42731 RVA: 0x0004F6E6 File Offset: 0x0004D8E6
		public void Clear()
		{
			this.m_DcspType.GetMethod("Clear").Invoke(this.m_DESCryptoServiceProvider, new object[0]);
		}

		// Token: 0x0600A6EC RID: 42732 RVA: 0x0004F70A File Offset: 0x0004D90A
		public void Dispose()
		{
			this.Clear();
		}

		// Token: 0x0400565B RID: 22107
		private readonly Type m_DcspType;

		// Token: 0x0400565C RID: 22108
		private readonly object m_DESCryptoServiceProvider;
	}
}
