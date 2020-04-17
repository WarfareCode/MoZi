using System;

namespace SmartAssembly.Zip
{
	// Token: 0x02001284 RID: 4740
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method)]
	public sealed class DoNotEncodeStringsAttribute : Attribute
	{
	}
}
