using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.MyServices.Internal;

namespace ns0
{
	// Token: 0x02000084 RID: 132
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	public sealed class MyTemplate
	{
		// Token: 0x06000297 RID: 663 RVA: 0x0005CD38 File Offset: 0x0005AF38
		internal static MyComputer GetComputer()
		{
			return MyTemplate.class14_0.method_0();
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0005CD54 File Offset: 0x0005AF54
		internal static AppBase GetApp()
		{
			return MyTemplate.class14_1.method_0();
		}

		// Token: 0x0400019A RID: 410
		private static readonly MyTemplate.Class14<MyComputer> class14_0 = new MyTemplate.Class14<MyComputer>();

		// Token: 0x0400019B RID: 411
		private static readonly MyTemplate.Class14<AppBase> class14_1 = new MyTemplate.Class14<AppBase>();

		// Token: 0x0400019C RID: 412
		private static readonly MyTemplate.Class14<User> class14_2 = new MyTemplate.Class14<User>();

		// Token: 0x0400019D RID: 413
		private static readonly MyTemplate.Class14<MyTemplate.Class13> class14_3 = new MyTemplate.Class14<MyTemplate.Class13>();

		// Token: 0x02000085 RID: 133
		[EditorBrowsable(EditorBrowsableState.Never)]
		public sealed class Class13
		{
			// Token: 0x0600029B RID: 667 RVA: 0x00005B7F File Offset: 0x00003D7F
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object obj)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(obj));
			}

			// Token: 0x0600029C RID: 668 RVA: 0x0005CD70 File Offset: 0x0005AF70
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600029D RID: 669 RVA: 0x0005CD88 File Offset: 0x0005AF88
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x0600029E RID: 670 RVA: 0x00004A21 File Offset: 0x00002C21
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Class13()
			{
			}
		}

		// Token: 0x02000086 RID: 134
		[EditorBrowsable(EditorBrowsableState.Never), ComVisible(false)]
		public sealed class Class14<T> where T : new()
		{
			// Token: 0x0600029F RID: 671 RVA: 0x0005CDA0 File Offset: 0x0005AFA0
			internal T method_0()
			{
				T t = this.contextValue_0.Value;
				if (t == null)
				{
					t = Activator.CreateInstance<T>();
					this.contextValue_0.Value = t;
				}
				return t;
			}

			// Token: 0x060002A0 RID: 672 RVA: 0x00005B8D File Offset: 0x00003D8D
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Class14()
			{
				this.contextValue_0 = new ContextValue<T>();
			}

			// Token: 0x0400019E RID: 414
			private readonly ContextValue<T> contextValue_0;
		}
	}
}
