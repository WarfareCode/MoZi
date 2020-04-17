using System;
using ns17;

namespace ns19
{
	// Token: 0x0200042F RID: 1071
	public class Class1980 : Class1979
	{
		// Token: 0x06001B7C RID: 7036 RVA: 0x000114E9 File Offset: 0x0000F6E9
		public Class1980(object object_1, string string_1) : base(object_1)
		{
			this.class1984_0 = new Class1984(string_1);
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x000B1024 File Offset: 0x000AF224
		public string method_1()
		{
			string result;
			if (this.class1984_0.string_5 == null)
			{
				result = null;
			}
			else
			{
				result = this.class1984_0.string_5.Substring(0, this.class1984_0.string_5.Length - Class1980.string_0.Length);
			}
			return result;
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x000114FE File Offset: 0x0000F6FE
		public void method_2(string string_1)
		{
			this.class1984_0.string_5 = string_1 + Class1980.string_0;
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00011516 File Offset: 0x0000F716
		public override bool vmethod_0()
		{
			return this.class1984_0 != null && this.class1984_0.method_1();
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x000B1078 File Offset: 0x000AF278
		public override void vmethod_1()
		{
			Class1984 @class = this.class1984_0;
			@class.delegate37_2 = (Delegate37)Delegate.Combine(@class.delegate37_2, new Delegate37(this.vmethod_4));
			if (this.class1984_0.string_5 != null && this.class1984_0.string_5.Length > 0)
			{
				this.class1984_0.method_3(false);
			}
			else
			{
				this.class1984_0.method_4();
			}
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x000B1010 File Offset: 0x000AF210
		public override float vmethod_2()
		{
			return 0f;
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x000B10F0 File Offset: 0x000AF2F0
		protected virtual void vmethod_4(Class1984 class1984_1)
		{
			try
			{
				this.vmethod_5();
			}
			catch (Exception ex)
			{
				Log.Write(Log.Levels.Error, "QUEU", class1984_1.string_4 + ": " + ex.Message);
			}
			this.vmethod_3();
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00004BC2 File Offset: 0x00002DC2
		protected virtual void vmethod_5()
		{
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x000B1144 File Offset: 0x000AF344
		public override string ToString()
		{
			return this.class1984_0.string_4;
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x000B1160 File Offset: 0x000AF360
		public override void Dispose()
		{
			try
			{
				if (this.class1984_0 != null)
				{
					this.class1984_0.Dispose();
					this.class1984_0 = null;
				}
			}
			finally
			{
				base.Dispose();
			}
		}

		// Token: 0x04000BC5 RID: 3013
		protected Class1984 class1984_0;

		// Token: 0x04000BC6 RID: 3014
		protected static string string_0 = ".tmp";
	}
}
