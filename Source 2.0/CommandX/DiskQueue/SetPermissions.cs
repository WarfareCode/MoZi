using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using DiskQueue.Implementation.CrossPlatform.Unix;

namespace DiskQueue
{
	// Token: 0x02000017 RID: 23
	public static class SetPermissions
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00057598 File Offset: 0x00055798
		public static bool RunningUnderPosix
		{
			get
			{
				int platform = (int)Environment.OSVersion.Platform;
				return platform == 4 || platform == 6 || platform == 128;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004CF8 File Offset: 0x00002EF8
		public static void AllowReadWriteForAll(string path)
		{
			if (Directory.Exists(path))
			{
				SetPermissions.Directory_RWX_all(path);
			}
			else
			{
				if (!File.Exists(path))
				{
					throw new UnauthorizedAccessException("Can't access the path \"" + path + "\"");
				}
				SetPermissions.File_RWX_all(path);
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000575C4 File Offset: 0x000557C4
		public static void TryAllowReadWriteForAll(string path)
		{
			try
			{
				if (Directory.Exists(path))
				{
					SetPermissions.Directory_RWX_all(path);
				}
				else if (File.Exists(path))
				{
					SetPermissions.File_RWX_all(path);
				}
			}
			catch
			{
				SetPermissions.Ignore();
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private static void Ignore()
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00057610 File Offset: 0x00055810
		private static void File_RWX_all(string path)
		{
			if (SetPermissions.RunningUnderPosix)
			{
				UnsafeNativeMethods.chmod(path, UnixFilePermissions.ACCESSPERMS);
			}
			else
			{
				FileSecurity accessControl = File.GetAccessControl(path);
				SecurityIdentifier identity = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
				accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadData | FileSystemRights.WriteData | FileSystemRights.AppendData | FileSystemRights.ReadExtendedAttributes | FileSystemRights.WriteExtendedAttributes | FileSystemRights.ExecuteFile | FileSystemRights.ReadAttributes | FileSystemRights.WriteAttributes | FileSystemRights.Delete | FileSystemRights.ReadPermissions | FileSystemRights.Synchronize, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow));
				File.SetAccessControl(path, accessControl);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00057660 File Offset: 0x00055860
		private static void Directory_RWX_all(string path)
		{
			if (SetPermissions.RunningUnderPosix)
			{
				UnsafeNativeMethods.chmod(path, UnixFilePermissions.ACCESSPERMS);
			}
			else
			{
				DirectorySecurity accessControl = Directory.GetAccessControl(path);
				SecurityIdentifier identity = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
				accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadData | FileSystemRights.WriteData | FileSystemRights.AppendData | FileSystemRights.ReadExtendedAttributes | FileSystemRights.WriteExtendedAttributes | FileSystemRights.ExecuteFile | FileSystemRights.ReadAttributes | FileSystemRights.WriteAttributes | FileSystemRights.Delete | FileSystemRights.ReadPermissions | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
				Directory.SetAccessControl(path, accessControl);
			}
		}
	}
}
