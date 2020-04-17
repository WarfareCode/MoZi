using System;
using System.Reflection;
using System.Reflection.Emit;
using ns0;
using ns1;
using ns2;

namespace SmartAssembly.HouseOfCards
{
	// Token: 0x02001278 RID: 4728
	[Attribute5, Attribute6]
	public static class MemberRefsProxy
	{
		// Token: 0x0600A6D1 RID: 42705 RVA: 0x004DE96C File Offset: 0x004DCB6C
		[Attribute4, Attribute5, Attribute6]
		public static void CreateMemberRefsDelegates(int int_0)
		{
            Type typeFromHandle;
            MethodInfo methodFromHandle;
            Delegate delegate2;
            try
            {
                typeFromHandle = Type.GetTypeFromHandle(moduleHandle_0.ResolveTypeHandle(0x2000001 + int_0));
            }
            catch
            {
                return;
            }
            FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.Static);
            int index = 0;
        Label_002F:
            if (index >= fields.Length)
            {
                return;
            }
            FieldInfo info = fields[index];
            string name = info.Name;
            bool flag = false;
            int num = 0;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                char ch = name[i];
                if (ch == '~')
                {
                    flag = true;
                    break;
                }
                int num3 = 0;
                while (num3 < 0x3a)
                {
                    if (char_0[num3] == ch)
                    {
                        goto Label_008B;
                    }
                    num3++;
                }
                continue;
            Label_008B:
                num = (num * 0x3a) + num3;
            }
            try
            {
                methodFromHandle = (MethodInfo)MethodBase.GetMethodFromHandle(moduleHandle_0.ResolveMethodHandle(num + 0xa000001));
            }
            catch
            {
                goto Label_0207;
            }
            if (methodFromHandle.IsStatic)
            {
                try
                {
                    delegate2 = Delegate.CreateDelegate(info.FieldType, methodFromHandle);
                    goto Label_01F9;
                }
                catch (Exception)
                {
                    goto Label_0207;
                }
            }
            ParameterInfo[] parameters = methodFromHandle.GetParameters();
            int num4 = parameters.Length + 1;
            Type[] parameterTypes = new Type[num4];
            parameterTypes[0] = typeof(object);
            for (int j = 1; j < num4; j++)
            {
                parameterTypes[j] = parameters[j - 1].ParameterType;
            }
            DynamicMethod method = new DynamicMethod(string.Empty, methodFromHandle.ReturnType, parameterTypes, typeFromHandle, true);
            ILGenerator iLGenerator = method.GetILGenerator();
            iLGenerator.Emit(OpCodes.Ldarg_0);
            if (num4 > 1)
            {
                iLGenerator.Emit(OpCodes.Ldarg_1);
            }
            if (num4 > 2)
            {
                iLGenerator.Emit(OpCodes.Ldarg_2);
            }
            if (num4 > 3)
            {
                iLGenerator.Emit(OpCodes.Ldarg_3);
            }
            if (num4 > 4)
            {
                for (int k = 4; k < num4; k++)
                {
                    iLGenerator.Emit(OpCodes.Ldarg_S, k);
                }
            }
            iLGenerator.Emit(OpCodes.Tailcall);
            iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodFromHandle);
            iLGenerator.Emit(OpCodes.Ret);
            try
            {
                delegate2 = method.CreateDelegate(typeFromHandle);
            }
            catch
            {
                goto Label_0207;
            }
        Label_01F9:
            try
            {
                info.SetValue(null, delegate2);
            }
            catch
            {
            }
        Label_0207:
            index++;
            goto Label_002F;

        }

        // Token: 0x0600A6D2 RID: 42706 RVA: 0x004DEBCC File Offset: 0x004DCDCC
        static MemberRefsProxy()
		{
			Type typeFromHandle = typeof(MulticastDelegate);
			if (typeFromHandle != null)
			{
				MemberRefsProxy.moduleHandle_0 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			}
		}

		// Token: 0x0400564C RID: 22092
		private static ModuleHandle moduleHandle_0;

		// Token: 0x0400564D RID: 22093
		private static char[] char_0 = new char[]
		{
			'\u0001',
			'\u0002',
			'\u0003',
			'\u0004',
			'\u0005',
			'\u0006',
			'\a',
			'\b',
			'\u000e',
			'\u000f',
			'\u0010',
			'\u0011',
			'\u0012',
			'\u0013',
			'\u0014',
			'\u0015',
			'\u0016',
			'\u0017',
			'\u0018',
			'\u0019',
			'\u001a',
			'\u001b',
			'\u001c',
			'\u001d',
			'\u001e',
			'\u001f',
			'\u007f',
			'\u0080',
			'\u0081',
			'\u0082',
			'\u0083',
			'\u0084',
			'\u0086',
			'\u0087',
			'\u0088',
			'\u0089',
			'\u008a',
			'\u008b',
			'\u008c',
			'\u008d',
			'\u008e',
			'\u008f',
			'\u0090',
			'\u0091',
			'\u0092',
			'\u0093',
			'\u0094',
			'\u0095',
			'\u0096',
			'\u0097',
			'\u0098',
			'\u0099',
			'\u009a',
			'\u009b',
			'\u009c',
			'\u009d',
			'\u009e',
			'\u009f'
		};
	}
}
