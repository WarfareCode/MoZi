using System;
using System.Diagnostics;
using System.Reflection;

namespace ns1
{
	// Token: 0x0200127E RID: 4734
	internal sealed class Class1
	{
		// Token: 0x0600A6DB RID: 42715 RVA: 0x004DEE98 File Offset: 0x004DD098
		internal static void smethod_0()
		{
			try
			{
				AppDomain.CurrentDomain.ResourceResolve += new ResolveEventHandler(Class1.smethod_1);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600A6DC RID: 42716 RVA: 0x004DEED0 File Offset: 0x004DD0D0
		private static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			if (Class1.assembly_0 == null)
			{
				lock (Class1.string_0)
				{
					Class1.assembly_0 = Assembly.Load("{729f82e3-b3fb-4c9c-a28b-fac5a29b9306}, PublicKeyToken=3e56350693f7355e");
					if (Class1.assembly_0 != null)
					{
						Class1.string_0 = Class1.assembly_0.GetManifestResourceNames();
					}
				}
			}
			string name = resolveEventArgs_0.Name;
			int i = 0;
			while (i < Class1.string_0.Length)
			{
				if (!(Class1.string_0[i] == name))
				{
					i++;
				}
				else
				{
					if (!Class1.smethod_2())
					{
						return null;
					}
					return Class1.assembly_0;
				}
			}
			return null;
		}

		// Token: 0x0600A6DD RID: 42717 RVA: 0x004DEF68 File Offset: 0x004DD168
		private static bool smethod_2()
		{
			bool result;
			try
			{
				StackFrame[] frames = new StackTrace().GetFrames();
				for (int i = 2; i < frames.Length; i++)
				{
					StackFrame stackFrame = frames[i];
					if (stackFrame.GetMethod().Module.Assembly == Assembly.GetExecutingAssembly())
					{
						result = true;
						return result;
					}
				}
				result = false;
			}
			catch
			{
				result = true;
			}
			return result;
		}

		// Token: 0x04005651 RID: 22097
		private static Assembly assembly_0 = null;

		// Token: 0x04005652 RID: 22098
		private static string[] string_0 = new string[0];
	}
}
