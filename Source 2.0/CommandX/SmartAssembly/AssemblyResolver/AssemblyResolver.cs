using System;

namespace SmartAssembly.AssemblyResolver
{
	// Token: 0x02001270 RID: 4720
	public sealed class AssemblyResolver
	{
		// Token: 0x0600A6BF RID: 42687 RVA: 0x004DE424 File Offset: 0x004DC624
		public static void AttachApp()
		{
			try
			{
				AssemblyResolverHelper.Attach();
			}
			catch (Exception)
			{
			}
		}
	}
}
