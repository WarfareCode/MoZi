using System;
using System.Diagnostics;
using System.IO;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns4
{
	// Token: 0x02000C34 RID: 3124
	public sealed class Class313
	{
		// Token: 0x06006863 RID: 26723 RVA: 0x003702A4 File Offset: 0x0036E4A4
		public static bool smethod_0(string string_0, Scenario scenario_)
		{
			bool result = false;
			checked
			{
				try
				{
					if (Information.IsNothing(scenario_))
					{
						string[] directories = Directory.GetDirectories(GameGeneral.strAttachmentRepoDir);
						int i = 0;
						while (i < directories.Length)
						{
							string text = directories[i];
							if (Operators.CompareString(Path.GetFileName(text), string_0, false) != 0)
							{
								i++;
							}
							else
							{
								ScenAttachmentObject scenAttachmentObject = ScenAttachmentObject.smethod_1(text);
								if (!Information.IsNothing(scenAttachmentObject))
								{
									scenAttachmentObject.vmethod_3(null);
									break;
								}
								break;
							}
						}
					}
					else
					{
						foreach (ScenAttachmentObject current in scenario_.GetScenAttachments().Values)
						{
							if (Operators.CompareString(current.method_0(), string_0, false) == 0 || Operators.CompareString(current.method_1(), string_0, false) == 0)
							{
								current.vmethod_3(scenario_);
								break;
							}
						}
					}
					result = true;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
				return result;
			}
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x003703B8 File Offset: 0x0036E5B8
		public static bool smethod_1(string string_0, string string_1, Scenario scenario_)
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					Side side_ = null;
					Side[] sides = scenario_.GetSides();
					int i = 0;
					while (i < sides.Length)
					{
						Side side = sides[i];
						if (Operators.CompareString(side.GetSideName(), string_1, false) != 0 && Operators.CompareString(side.GetGuid(), string_1, false) != 0)
						{
							if (i != sides.Length - 1)
							{
								i++;
								continue;
							}
						}
						else
						{
							side_ = side;
						}
						foreach (ScenAttachmentObject current in scenario_.GetScenAttachments().Values)
						{
							if (Operators.CompareString(current.method_0(), string_0, false) == 0 || Operators.CompareString(current.method_1(), string_0, false) == 0)
							{
								current.vmethod_4(scenario_, side_);
							}
						}
						flag = true;
						result = true;
						return result;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
				result = flag;
				return result;
			}
		}
	}
}
