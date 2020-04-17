using System;

namespace DiskQueue.Implementation.CrossPlatform.Unix
{
	// Token: 0x02000006 RID: 6
	[Flags]
	public enum UnixFilePermissions : uint
	{
		// Token: 0x04000015 RID: 21
		S_ISUID = 2048u,
		// Token: 0x04000016 RID: 22
		S_ISGID = 1024u,
		// Token: 0x04000017 RID: 23
		S_ISVTX = 512u,
		// Token: 0x04000018 RID: 24
		S_IRUSR = 256u,
		// Token: 0x04000019 RID: 25
		S_IWUSR = 128u,
		// Token: 0x0400001A RID: 26
		S_IXUSR = 64u,
		// Token: 0x0400001B RID: 27
		S_IRGRP = 32u,
		// Token: 0x0400001C RID: 28
		S_IWGRP = 16u,
		// Token: 0x0400001D RID: 29
		S_IXGRP = 8u,
		// Token: 0x0400001E RID: 30
		S_IROTH = 4u,
		// Token: 0x0400001F RID: 31
		S_IWOTH = 2u,
		// Token: 0x04000020 RID: 32
		S_IXOTH = 1u,
		// Token: 0x04000021 RID: 33
		S_IRWXG = 56u,
		// Token: 0x04000022 RID: 34
		S_IRWXU = 448u,
		// Token: 0x04000023 RID: 35
		S_IRWXO = 7u,
		// Token: 0x04000024 RID: 36
		ACCESSPERMS = 511u,
		// Token: 0x04000025 RID: 37
		ALLPERMS = 4095u,
		// Token: 0x04000026 RID: 38
		DEFFILEMODE = 438u,
		// Token: 0x04000027 RID: 39
		S_IFMT = 61440u,
		// Token: 0x04000028 RID: 40
		S_IFDIR = 16384u,
		// Token: 0x04000029 RID: 41
		S_IFCHR = 8192u,
		// Token: 0x0400002A RID: 42
		S_IFBLK = 24576u,
		// Token: 0x0400002B RID: 43
		S_IFREG = 32768u,
		// Token: 0x0400002C RID: 44
		S_IFIFO = 4096u,
		// Token: 0x0400002D RID: 45
		S_IFLNK = 40960u,
		// Token: 0x0400002E RID: 46
		S_IFSOCK = 49152u
	}
}
