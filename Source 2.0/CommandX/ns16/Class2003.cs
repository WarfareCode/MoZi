using System;
using System.IO;
using System.Net;
using ns17;
using ns18;
using ns19;

namespace ns16
{
	// Token: 0x020004B2 RID: 1202
	public sealed class Class2003 : IDisposable
	{
		// Token: 0x06001F7B RID: 8059 RVA: 0x00012EAD File Offset: 0x000110AD
		public Class2003(Class1992 class1992_1, Class1947 class1947_1, string string_2, string string_3)
		{
			this.class1992_0 = class1992_1;
			this.string_1 = string_3;
			this.string_0 = string_2;
			this.class1947_0 = class1947_1;
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x00012ED2 File Offset: 0x000110D2
		public void method_0(IWebProxy iwebProxy_1)
		{
			this.iwebProxy_0 = iwebProxy_1;
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x00012EDB File Offset: 0x000110DB
		public bool method_1()
		{
			return this.class1984_0 != null;
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x000CF3E8 File Offset: 0x000CD5E8
		public bool method_2()
		{
			bool result = true;
			if (this.class1984_0 != null)
			{
				result = this.class1984_0.bool_3;
			}
			return result;
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x000CF410 File Offset: 0x000CD610
		public Class1992 method_3()
		{
			return this.class1992_0;
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x000CF428 File Offset: 0x000CD628
		private void method_4(Class1984 class1984_1)
		{
			Log.Write(Log.Levels.int_2 + 1, "GSDR", "Download completed for " + class1984_1.string_4);
			try
			{
				class1984_1.method_11();
				this.class1992_0.class1998_0.method_19(0);
				File.Delete(this.string_0);
				File.Move(class1984_1.string_5, this.string_0);
				this.class1992_0.class2003_0 = null;
				this.class1992_0.vmethod_1();
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
				if (httpWebResponse != null && httpWebResponse.StatusCode == HttpStatusCode.NotFound)
				{
					using (File.Create(this.string_0 + ".txt"))
					{
						goto IL_D8;
					}
				}
				Class1998 class1998_ = this.class1992_0.class1998_0;
				int num = class1998_.method_18();
				class1998_.method_19(num + 1);
				IL_D8:;
			}
			catch
			{
				using (File.Create(this.string_0 + ".txt"))
				{
				}
				if (File.Exists(class1984_1.string_5))
				{
					try
					{
						File.Delete(class1984_1.string_5);
					}
					catch (Exception exception_)
					{
						Log.Write(Log.Levels.Error, "GSDR", "could not delete file " + class1984_1.string_5 + ":");
						Log.smethod_3(exception_);
					}
				}
			}
			finally
			{
				if (this.class1984_0 != null)
				{
					this.class1984_0.bool_3 = true;
				}
				this.class1992_0.class1998_0.vmethod_21(this);
				this.class1992_0.class1998_0.vmethod_22();
			}
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x000CF654 File Offset: 0x000CD854
		public  void vmethod_0()
		{
			Log.Write(Log.Levels.int_2, "GSDR", "Starting download for " + this.string_1);
			this.method_3().bool_4 = true;
			this.class1984_0 = new Class1984(this.string_1);
			this.class1984_0.method_0(this.iwebProxy_0);
			this.class1984_0.enum151_0 = Enum151.const_1;
			this.class1984_0.string_5 = this.string_0 + ".tmp";
			Class1984 @class = this.class1984_0;
			@class.delegate36_0 = (Delegate36)Delegate.Combine(@class.delegate36_0, new Delegate36(this.method_5));
			Class1984 class2 = this.class1984_0;
			class2.delegate37_2 = (Delegate37)Delegate.Combine(class2.delegate37_2, new Delegate37(this.method_4));
			this.class1984_0.method_3(false);
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00012EE9 File Offset: 0x000110E9
		private void method_5(int int_0, int int_1)
		{
			if (int_1 == 0)
			{
				int_1 = 51200;
			}
			int_0 %= int_1 + 1;
			this.float_0 = (float)int_0 / (float)int_1;
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x00012F0D File Offset: 0x0001110D
		public  void vmethod_1()
		{
			if (this.class1984_0 != null)
			{
				this.class1984_0.method_7();
			}
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x000CF734 File Offset: 0x000CD934
		public override string ToString()
		{
			return this.class1947_0.vmethod_1(this.method_3());
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x00012F25 File Offset: 0x00011125
		public  void Dispose()
		{
			if (this.class1984_0 != null)
			{
				this.class1984_0.Dispose();
				this.class1984_0 = null;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000EB8 RID: 3768
		public float float_0;

		// Token: 0x04000EB9 RID: 3769
		private Class1984 class1984_0;

		// Token: 0x04000EBA RID: 3770
		private string string_0;

		// Token: 0x04000EBB RID: 3771
		private string string_1;

		// Token: 0x04000EBC RID: 3772
		private Class1992 class1992_0;

		// Token: 0x04000EBD RID: 3773
		private Class1947 class1947_0;

		// Token: 0x04000EBE RID: 3774
		private IWebProxy iwebProxy_0;
	}
}
