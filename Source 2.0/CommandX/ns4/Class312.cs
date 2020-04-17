using System;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace ns4
{
	// Token: 0x02000C32 RID: 3122
	public sealed class Class312
	{
		// Token: 0x06006860 RID: 26720 RVA: 0x003700C8 File Offset: 0x0036E2C8
		public static int smethod_0(string string_0, string string_1, Scenario scenario_)
		{
			Side side_ = null;
			Side[] sides = scenario_.GetSides();
			checked
			{
				int count;
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					if (Operators.CompareString(side.GetSideName(), string_0, false) == 0 || Operators.CompareString(side.GetGuid(), string_0, false) == 0)
					{
						side_ = side;
						string_1 = string_1.Replace("..", "");
						count = scenario_.ImportUnits("ImportExport\\" + string_1, side_).Count;
						return count;
					}
				}
				string_1 = string_1.Replace("..", "");
				count = scenario_.ImportUnits("ImportExport\\" + string_1, side_).Count;
				return count;
			}
		}
	}
}
