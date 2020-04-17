using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x02000026 RID: 38
	public sealed class MyCryptography
	{
		// Token: 0x060000EE RID: 238 RVA: 0x0005893C File Offset: 0x00056B3C
		public MyCryptography()
		{
			try
			{
				Assembly assembly = Assembly.Load("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
				this.type_0 = assembly.GetType("System.Security.Cryptography.AesManaged");
			}
			catch (FileNotFoundException)
			{
				Assembly assembly = Assembly.Load("mscorlib");
				this.type_0 = assembly.GetType("System.Security.Cryptography.RijndaelManaged");
			}
			this.object_0 = Activator.CreateInstance(this.type_0);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000589B0 File Offset: 0x00056BB0
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

		// Token: 0x060000F0 RID: 240 RVA: 0x00004DF5 File Offset: 0x00002FF5
		public void Clear()
		{
			this.type_0.GetMethod("Clear").Invoke(this.object_0, new object[0]);
		}

		// Token: 0x0400009A RID: 154
		private readonly Type type_0;

		// Token: 0x0400009B RID: 155
		private readonly object object_0;
	}
}
