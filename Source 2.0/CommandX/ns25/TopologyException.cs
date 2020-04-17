using System;
using DotSpatial.Topology;

namespace ns25
{
	// Token: 0x02000615 RID: 1557
	public sealed class TopologyException : ApplicationException
	{
		// Token: 0x060027A9 RID: 10153 RVA: 0x0000DF8E File Offset: 0x0000C18E
		public TopologyException(string string_0) : base(string_0)
		{
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x0001610F File Offset: 0x0001430F
		public TopologyException(string string_0, Coordinate coordinate_1) : base(TopologyException.MsgWithCoord(string_0, coordinate_1))
		{
			this._pt = new Coordinate(coordinate_1);
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x000F10BC File Offset: 0x000EF2BC
		private static string MsgWithCoord(string string_0, Coordinate coordinate_1)
		{
			string result;
			if (Coordinate.NotEquals(coordinate_1, null))
			{
				result = string.Concat(new object[]
				{
					string_0,
					" [ ",
					coordinate_1,
					" ]"
				});
			}
			else
			{
				result = string_0;
			}
			return result;
		}

		// Token: 0x04001311 RID: 4881
		private readonly Coordinate _pt;
	}
}
