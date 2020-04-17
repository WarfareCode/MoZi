using System;

namespace ns26
{
	// Token: 0x020007DC RID: 2012
	public enum TopologyValidationErrorType
	{
		// Token: 0x04001715 RID: 5909
		[Obsolete("Not used")]
		Error,
		// Token: 0x04001716 RID: 5910
		[Obsolete("No longer used: repeated points are considered valid as per the SFS")]
		RepeatedPoint,
		// Token: 0x04001717 RID: 5911
		HoleOutsideShell,
		// Token: 0x04001718 RID: 5912
		NestedHoles,
		// Token: 0x04001719 RID: 5913
		DisconnectedInteriors,
		// Token: 0x0400171A RID: 5914
		SelfIntersection,
		// Token: 0x0400171B RID: 5915
		RingSelfIntersection,
		// Token: 0x0400171C RID: 5916
		NestedShells,
		// Token: 0x0400171D RID: 5917
		DuplicateRings,
		// Token: 0x0400171E RID: 5918
		TooFewPoints,
		// Token: 0x0400171F RID: 5919
		InvalidCoordinate,
		// Token: 0x04001720 RID: 5920
		RingNotClosed
	}
}
