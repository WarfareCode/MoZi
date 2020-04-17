using System;
using System.Collections.ObjectModel;

namespace Command_Core
{
	// Token: 0x02000AF9 RID: 2809
	[Serializable]
	public sealed class ImportExportRecord
	{
		// Token: 0x06005AB2 RID: 23218 RVA: 0x00028B8A File Offset: 0x00026D8A
		public ImportExportRecord()
		{
			this.MemberRecords = new Collection<ImportExportRecord.MemberRecord>();
		}

		// Token: 0x04002CF6 RID: 11510
		public int DB_ID;

		// Token: 0x04002CF7 RID: 11511
		public int FormatVersion;

		// Token: 0x04002CF8 RID: 11512
		public Collection<ImportExportRecord.MemberRecord> MemberRecords;

		// Token: 0x04002CF9 RID: 11513
		public string ValidFrom;

		// Token: 0x04002CFA RID: 11514
		public string ValidUntil;

		// Token: 0x04002CFB RID: 11515
		public string Name;

		// Token: 0x04002CFC RID: 11516
		public string Comments;

		// Token: 0x02000AFA RID: 2810
		[Serializable]
		public sealed class MemberRecord
		{
			// Token: 0x06005AB3 RID: 23219 RVA: 0x00028B9D File Offset: 0x00026D9D
			public MemberRecord()
			{
				this.HostedAircraftRecords = new Collection<ImportExportRecord.HostedAircraftRecord>();
			}

			// Token: 0x04002CFD RID: 11517
			public int Member_DBID;

			// Token: 0x04002CFE RID: 11518
			public string Member_GUID;

			// Token: 0x04002CFF RID: 11519
			public string MemberType;

			// Token: 0x04002D00 RID: 11520
			public string MemberName;

			// Token: 0x04002D01 RID: 11521
			public string ParentGroupName;

			// Token: 0x04002D02 RID: 11522
			public double Longitude;

			// Token: 0x04002D03 RID: 11523
			public double Latitude;

			// Token: 0x04002D04 RID: 11524
			public double Altitude;

			// Token: 0x04002D05 RID: 11525
			public int LoadoutID;

			// Token: 0x04002D06 RID: 11526
			public float Orientation;

			// Token: 0x04002D07 RID: 11527
			public Collection<ImportExportRecord.HostedAircraftRecord> HostedAircraftRecords;
		}

		// Token: 0x02000AFB RID: 2811
		[Serializable]
		public sealed class HostedAircraftRecord
		{
			// Token: 0x06005AB4 RID: 23220 RVA: 0x00028BB0 File Offset: 0x00026DB0
			public HostedAircraftRecord(string string_0, int int_0, int int_1, int int_2)
			{
				this.Name = string_0;
				this.AC_DBID = int_0;
				this.Loadout_ID = int_1;
				this.ReadyTime_Mins = int_2;
			}

			// Token: 0x06005AB5 RID: 23221 RVA: 0x00004A21 File Offset: 0x00002C21
			public HostedAircraftRecord()
			{
			}

			// Token: 0x04002D08 RID: 11528
			public string Name;

			// Token: 0x04002D09 RID: 11529
			public int AC_DBID;

			// Token: 0x04002D0A RID: 11530
			public int Loadout_ID;

			// Token: 0x04002D0B RID: 11531
			public int ReadyTime_Mins;
		}
	}
}
