using System;
using System.Reflection;
using System.Reflection.Emit;
using ns0;
using ns1;
using ns2;
using SmartAssembly.Delegates;
using SmartAssembly.StringsEncoding;

namespace SmartAssembly.HouseOfCards
{
	// Token: 0x02001279 RID: 4729
	[Attribute5, Attribute6]
	public static class Strings
	{
		// Token: 0x0600A6D3 RID: 42707 RVA: 0x004DEC14 File Offset: 0x004DCE14
		[Attribute4, Attribute5, Attribute6]
		public static void CreateGetStringDelegate(Type type_0)
		{
			FieldInfo[] fields = type_0.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int i = 0; i < fields.Length; i++)
			{
				FieldInfo fieldInfo = fields[i];
				try
				{
					if (fieldInfo.FieldType == typeof(GetString))
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(string), new Type[]
						{
							typeof(int)
						}, type_0.Module, true);
						ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
						iLGenerator.Emit(OpCodes.Ldarg_0);
						MethodInfo[] methods = typeof(Strings).GetMethods(BindingFlags.Static | BindingFlags.Public);
						for (int j = 0; j < methods.Length; j++)
						{
							MethodInfo methodInfo = methods[j];
							if (methodInfo.ReturnType == typeof(string))
							{
								iLGenerator.Emit(OpCodes.Ldc_I4, fieldInfo.MetadataToken & 16777215);
								iLGenerator.Emit(OpCodes.Sub);
								iLGenerator.Emit(OpCodes.Call, methodInfo);
								IL_EC:
								iLGenerator.Emit(OpCodes.Ret);
								fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeof(GetString)));
								return;
							}
						}
                        iLGenerator.Emit(OpCodes.Ret);
                        fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeof(GetString)));
                        return;
                    }
				}
				catch
				{
				}
			}
		}
	}
}
