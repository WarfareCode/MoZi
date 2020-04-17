using System;
using DotSpatial.Topology;

namespace ns26
{
	// Token: 0x020007D9 RID: 2009
	public sealed class TopologyValidationError
	{
		// Token: 0x060031C2 RID: 12738 RVA: 0x0001AC4E File Offset: 0x00018E4E
		public TopologyValidationError(TopologyValidationErrorType errorType, Coordinate coordinate_1)
		{
			this._errorType = errorType;
			if (Coordinate.NotEquals(coordinate_1, null))
			{
				this._pt = (Coordinate)coordinate_1.Clone();
			}
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x0010CBF8 File Offset: 0x0010ADF8
		public  string GetMessage()
		{
			return TopologyValidationError.ErrMsg[(int)this._errorType];
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x0010CC14 File Offset: 0x0010AE14
		public override string ToString()
		{
			return this.GetMessage() + " at or near point " + this._pt;
		}

		// Token: 0x0400170C RID: 5900
		private static readonly string[] ErrMsg = new string[]
		{
			"Topology Validation Error",
			"Repeated Point",
			"Hole lies outside shell",
			"Holes are nested",
			"Interior is disconnected",
			"Self-intersection",
			"Ring Self-intersection",
			"Nested shells",
			"Duplicate Rings",
			"Too few points in geometry component",
			"Invalid Coordinate"
		};

		// Token: 0x0400170D RID: 5901
		private readonly TopologyValidationErrorType _errorType;

		// Token: 0x0400170E RID: 5902
		private readonly Coordinate _pt;
	}
}
