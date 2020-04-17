using System;
using System.Collections;
using Command_Core;
using Microsoft.DirectX.Direct3D;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns32;

namespace ns33
{
	// Token: 0x0200098F RID: 2447
	public sealed class UnhandledExceptionHandler
	{
		// Token: 0x06003DC8 RID: 15816 RVA: 0x001426FC File Offset: 0x001408FC
		public void HandleException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
		{
			Interaction.MsgBox("OnThreadException", MsgBoxStyle.OkOnly, null);
			Exception exception = e.Exception;
			if (exception == null)
			{
				Interaction.MsgBox("theEx == null", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				Interaction.MsgBox("theEx != null", MsgBoxStyle.OkOnly, null);
			}
			if (e.Exception.GetType() == typeof(Direct3DXException))
			{
				try
				{
					Device device_ = CommandFactory.GetCommandMain().GetMainForm().device_0;
					device_.Reset(new PresentParameters[]
					{
						device_.PresentationParameters
					});
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			Interaction.MsgBox("e.Exception.GetType().Name: " + e.Exception.GetType().Name, MsgBoxStyle.OkOnly, null);
			Interaction.MsgBox("theEx.Message: " + exception.Message, MsgBoxStyle.OkOnly, null);
			Interaction.MsgBox("theEx.StackTrace: " + exception.StackTrace, MsgBoxStyle.OkOnly, null);
			if (!Information.IsNothing(exception.InnerException))
			{
				Interaction.MsgBox("theEx.InnerException.GetType().Name: " + exception.InnerException.GetType().Name, MsgBoxStyle.OkOnly, null);
			}
			if (!Information.IsNothing(GameGeneral.exception_0))
			{
				string text = string.Concat(new string[]
				{
					"This is probably a bug. Please save a screenshot of this and submit it, along with the autosave files, for investigation.\r\n\r\nException: ",
					exception.Message,
					"\r\n\r\nStack Trace: ",
					exception.StackTrace,
					"\r\n\r\n"
				});
				if (!Information.IsNothing(exception.InnerException))
				{
					text = string.Concat(new string[]
					{
						text,
						"Inner Exception: ",
						exception.InnerException.Message,
						"\r\n\r\nInner StackTrace: ",
						exception.InnerException.StackTrace,
						"\r\n\r\n"
					});
				}
				if (exception.Data.Count > 0)
				{
					text += "Call Stack & Error details: ";
					IDictionaryEnumerator enumerator = exception.Data.GetEnumerator();
					while (enumerator.MoveNext())
					{
						object current = enumerator.Current;
						DictionaryEntry dictionaryEntry = (current != null) ? ((DictionaryEntry)current) : default(DictionaryEntry);
						text = string.Concat(new string[]
						{
							text,
							"\r\n",
							Conversions.ToString(dictionaryEntry.Key),
							", ",
							Conversions.ToString(dictionaryEntry.Value)
						});
					}
				}
				Interaction.MsgBox(text, MsgBoxStyle.OkOnly, "An error has occurred!");
				e.ExitApplication = true;
			}
			else
			{
				e.ExitApplication = false;
			}
		}
	}
}
