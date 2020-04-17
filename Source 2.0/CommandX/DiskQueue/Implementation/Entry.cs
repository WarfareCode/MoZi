using System;

namespace DiskQueue.Implementation
{
	// Token: 0x02000008 RID: 8
	public sealed class Entry : IEquatable<Entry>
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00004A29 File Offset: 0x00002C29
		public Entry(int fileNumber, int start, int length)
		{
			this.FileNumber = fileNumber;
			this.Start = start;
			this.Length = length;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004A46 File Offset: 0x00002C46
		public Entry(Operation operation) : this(operation.FileNumber, operation.Start, operation.Length)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00055970 File Offset: 0x00053B70
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00004A60 File Offset: 0x00002C60
		public byte[] Data
		{
			get;
			set;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00055988 File Offset: 0x00053B88
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00004A69 File Offset: 0x00002C69
		public int FileNumber
		{
			get;
			set;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000559A0 File Offset: 0x00053BA0
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00004A72 File Offset: 0x00002C72
		public int Start
		{
			get;
			set;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000559B8 File Offset: 0x00053BB8
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00004A7B File Offset: 0x00002C7B
		public int Length
		{
			get;
			set;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000559D0 File Offset: 0x00053BD0
		public bool Equals(Entry obj)
		{
			return !object.ReferenceEquals(null, obj) && (object.ReferenceEquals(this, obj) || (obj.FileNumber == this.FileNumber && obj.Start == this.Start && obj.Length == this.Length));
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00055A2C File Offset: 0x00053C2C
		public override bool Equals(object obj)
		{
			return !object.ReferenceEquals(null, obj) && (object.ReferenceEquals(this, obj) || this.Equals(obj as Entry));
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00055A68 File Offset: 0x00053C68
		public override int GetHashCode()
		{
			int num = this.FileNumber;
			num = (num * 397 ^ this.Start);
			return num * 397 ^ this.Length;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004A84 File Offset: 0x00002C84
		public static bool operator ==(Entry left, Entry right)
		{
			return object.Equals(left, right);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004A8D File Offset: 0x00002C8D
		public static bool operator !=(Entry left, Entry right)
		{
			return !object.Equals(left, right);
		}
	}
}
