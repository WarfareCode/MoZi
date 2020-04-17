using System;
using System.Reflection;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x02000027 RID: 39
	public sealed class MyDESCryptoServiceProvider
	{
		// Token: 0x060000F1 RID: 241 RVA: 0x00058A54 File Offset: 0x00056C54
		public MyDESCryptoServiceProvider()
		{
			Assembly assembly = Assembly.Load("mscorlib");
			this.type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
			this.object_0 = Activator.CreateInstance(this.type_0);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00058A94 File Offset: 0x00056C94
		public ICryptoTransform CreateCryptoTransform(byte[] byte_0, byte[] byte_1, bool bool_0)
		{
			this.type_0.GetProperty("Key").GetSetMethod().Invoke(this.object_0, new object[]
			{
				byte_0
			});
			this.type_0.GetProperty("IV").GetSetMethod().Invoke(this.object_0, new object[]
			{
				byte_1
			});
			MethodInfo method = this.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
			return (ICryptoTransform)method.Invoke(this.object_0, new object[0]);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00004E19 File Offset: 0x00003019
		public void Clear()
		{
			this.type_0.GetMethod("Clear").Invoke(this.object_0, new object[0]);
		}

		// Token: 0x0400009C RID: 156
		private readonly Type type_0;

		// Token: 0x0400009D RID: 157
		private readonly object object_0;
	}
}
