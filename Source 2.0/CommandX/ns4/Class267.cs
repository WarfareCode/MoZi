using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace ns4
{
	// Token: 0x02000C07 RID: 3079
	public sealed class Class267
	{
		// Token: 0x06006676 RID: 26230 RVA: 0x0002C45A File Offset: 0x0002A65A
		public static void smethod_0(string string_0, int int_0, int int_1, int int_2, int int_3)
		{
			if (Class267.dictionary_0.ContainsKey(string_0))
			{
				Class267.dictionary_0[string_0] = new Tuple<int, int, int, int>(int_0, int_1, int_2, int_3);
			}
			else
			{
				Class267.dictionary_0.Add(string_0, new Tuple<int, int, int, int>(int_0, int_1, int_2, int_3));
			}
		}

		// Token: 0x06006677 RID: 26231 RVA: 0x00353A70 File Offset: 0x00351C70
		public static void smethod_1(Form form_0)
		{
			if (!Class267.dictionary_0.ContainsKey(form_0.Name))
			{
				try
				{
					form_0.Location = new Point
					{
						X = (int)Math.Round((double)Screen.AllScreens[0].Bounds.Width / 2.0 - (double)form_0.Width / 2.0),
						Y = (int)Math.Round((double)Screen.AllScreens[0].Bounds.Height / 2.0 - (double)form_0.Height / 2.0)
					};
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200488", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			Tuple<int, int, int, int> tuple = Class267.dictionary_0[form_0.Name];
			form_0.Location = new Point(tuple.Item1, tuple.Item2);
			if (form_0.MinimumSize.Width > tuple.Item3)
			{
				form_0.Width = form_0.MinimumSize.Width;
			}
			else
			{
				form_0.Width = tuple.Item3;
			}
			if (form_0.MinimumSize.Height > tuple.Item4)
			{
				form_0.Height = form_0.MinimumSize.Height;
			}
			else
			{
				form_0.Height = tuple.Item4;
			}
		}

		// Token: 0x0400384D RID: 14413
		public static Dictionary<string, Tuple<int, int, int, int>> dictionary_0 = new Dictionary<string, Tuple<int, int, int, int>>();
	}
}
