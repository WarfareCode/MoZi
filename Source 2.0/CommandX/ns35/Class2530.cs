using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;

namespace ns35
{
	// Token: 0x02000A75 RID: 2677
	public sealed class Class2530
	{
		// Token: 0x060054D5 RID: 21717 RVA: 0x00027018 File Offset: 0x00025218
		public Class2530()
		{
			this.string_0 = CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Sound\\Music\\";
			this.vmethod_1(new MediaPlayer());
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x00234EF4 File Offset: 0x002330F4
		[CompilerGenerated]
		public  MediaPlayer vmethod_0()
		{
			return this.mediaPlayer_0;
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x00234F0C File Offset: 0x0023310C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void vmethod_1(MediaPlayer mediaPlayer_1)
		{
			EventHandler value = new EventHandler(this.method_4);
			MediaPlayer mediaPlayer = this.mediaPlayer_0;
			if (mediaPlayer != null)
			{
				mediaPlayer.MediaEnded -= value;
			}
			this.mediaPlayer_0 = mediaPlayer_1;
			mediaPlayer = this.mediaPlayer_0;
			if (mediaPlayer != null)
			{
				mediaPlayer.MediaEnded += value;
			}
		}

		// Token: 0x060054D8 RID: 21720 RVA: 0x0002704A File Offset: 0x0002524A
		public void method_0()
		{
			this.bool_0 = false;
			if (File.Exists(this.string_0 + "Title.mp3"))
			{
				this.method_2(this.string_0 + "Title.mp3");
			}
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x00027083 File Offset: 0x00025283
		public void method_1()
		{
			this.bool_0 = true;
			if (!Information.IsNothing(this.vmethod_0()))
			{
				this.vmethod_0().Stop();
			}
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x00234F58 File Offset: 0x00233158
		private void method_2(string string_1)
		{
			try
			{
				this.vmethod_0().Open(new Uri(string_1));
				this.vmethod_0().Play();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200422", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060054DB RID: 21723 RVA: 0x00234FD0 File Offset: 0x002331D0
		private void method_3()
		{
			if (!this.bool_0)
			{
				List<string> list = Directory.GetFiles(this.string_0).ToList<string>();
				if (list.Count != 0)
				{
					Misc.smethod_20<string>(list);
					this.method_2(list[0]);
				}
			}
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x000270A4 File Offset: 0x000252A4
		[CompilerGenerated]
		private void method_4(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x04002900 RID: 10496
		private string string_0;

		// Token: 0x04002901 RID: 10497
		private bool bool_0;

		// Token: 0x04002902 RID: 10498
		[CompilerGenerated]
		private MediaPlayer mediaPlayer_0;
	}
}
