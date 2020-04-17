using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns35
{
	// Token: 0x02000AF0 RID: 2800
	public sealed class Class2524
	{
		// Token: 0x06005A70 RID: 23152 RVA: 0x00028A0F File Offset: 0x00026C0F
		static Class2524()
		{
			Class2524.smethod_1(new Timer());
		}

		// Token: 0x06005A71 RID: 23153 RVA: 0x0028287C File Offset: 0x00280A7C
		[CompilerGenerated]
		private static Timer smethod_0()
		{
			return Class2524.timer_0;
		}

		// Token: 0x06005A72 RID: 23154 RVA: 0x00282890 File Offset: 0x00280A90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void smethod_1(Timer timer_1)
		{
			EventHandler value = new EventHandler(Class2524.smethod_5);
			Timer timer = Class2524.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			Class2524.timer_0 = timer_1;
			timer = Class2524.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x00028A25 File Offset: 0x00026C25
		public static void smethod_2()
		{
			PrivateMethods.smethod_0(new PrivateMethods.Delegate27(Class2524.smethod_3));
			PrivateMethods.smethod_1(new PrivateMethods.Delegate28(Class2524.smethod_4));
			Class2524.smethod_0().Interval = 100;
			Class2524.smethod_0().Start();
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x002828D8 File Offset: 0x00280AD8
		private static void smethod_3(string string_0, int int_0, ref string string_1)
		{
			bool flag;
			if (flag = (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Run))
			{
				Client.GetConfiguration().SetSimStopMode();
			}
			string_1 = Interaction.MsgBox(string_0, (MsgBoxStyle)Conversions.ToInteger(Enum.ToObject(typeof(MsgBoxStyle), int_0)), null).ToString();
			if (flag)
			{
				Client.GetConfiguration().SetSimRunMode();
			}
		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x00028A5F File Offset: 0x00026C5F
		private static void smethod_4(string string_0, bool bool_0, int int_0)
		{
			Class2524.concurrentQueue_0.Enqueue(new Tuple<string, bool, int>(string_0, bool_0, int_0));
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x0028293C File Offset: 0x00280B3C
		private static void smethod_5(object sender, EventArgs e)
		{
			if (Class2524.concurrentQueue_0.Count > 0 && !Client.videoWindow.bool_0)
			{
				Tuple<string, bool, int> tuple;
				Class2524.concurrentQueue_0.TryDequeue(out tuple);
				if (!Information.IsNothing(tuple))
				{
					try
					{
						Client.videoWindow.tuple_0 = tuple;
						Client.videoWindow.Show();
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200418", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		// Token: 0x04002CE0 RID: 11488
		private static ConcurrentQueue<Tuple<string, bool, int>> concurrentQueue_0 = new ConcurrentQueue<Tuple<string, bool, int>>();

		// Token: 0x04002CE1 RID: 11489
		[CompilerGenerated]
		private static Timer timer_0;
	}
}
