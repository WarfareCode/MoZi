using System;
using System.Collections;
using System.IO;
using System.Text;
using ns16;
using ns21;

namespace ns6
{
	// Token: 0x02000C8E RID: 3214
	public sealed class Class388
	{
		// Token: 0x06006A9D RID: 27293 RVA: 0x00393A60 File Offset: 0x00391C60
		private static BinaryReader smethod_0(string string_2)
		{
			return new BinaryReader(File.Open(string_2, FileMode.Open, FileAccess.Read, FileShare.Read), Encoding.Default);
		}

		// Token: 0x06006A9E RID: 27294 RVA: 0x00393A84 File Offset: 0x00391C84
		private BinaryReader method_0(int int_0)
		{
			return Class388.smethod_0(Path.Combine(this.string_0, this.string_1[int_0]));
		}

		// Token: 0x06006A9F RID: 27295 RVA: 0x00393AAC File Offset: 0x00391CAC
		private Class386 method_1(Struct44 struct44_1, Class388.Enum116 enum116_0)
		{
			Class386 result;
			using (BinaryReader binaryReader = this.method_0((int)struct44_1.short_0))
			{
				binaryReader.BaseStream.Seek((long)struct44_1.int_0, SeekOrigin.Begin);
				Class386 @class = new Class386();
				@class.struct67_0 = default(WorldWindPlacename);
				@class.class2102_0 = this.class2102_0;
				Class388.smethod_1(binaryReader, ref @class.struct67_0, enum116_0);
				result = @class;
			}
			return result;
		}

		// Token: 0x06006AA0 RID: 27296 RVA: 0x00393B2C File Offset: 0x00391D2C
		public static void smethod_1(BinaryReader binaryReader_0, ref WorldWindPlacename struct67_0, Class388.Enum116 enum116_0)
		{
			struct67_0.Name = binaryReader_0.ReadString();
			struct67_0.Lat = binaryReader_0.ReadSingle();
			struct67_0.Lon = binaryReader_0.ReadSingle();
			int num = binaryReader_0.ReadInt32();
			if (enum116_0 == Class388.Enum116.const_0)
			{
				struct67_0.metaData = new Hashtable();
			}
			else
			{
				struct67_0.metaData = null;
			}
			if (enum116_0 != Class388.Enum116.const_2)
			{
				for (int i = 0; i < num; i++)
				{
					string key = binaryReader_0.ReadString();
					string value = binaryReader_0.ReadString();
					if (enum116_0 == Class388.Enum116.const_0)
					{
						struct67_0.metaData.Add(key, value);
					}
				}
			}
		}

		// Token: 0x04003C39 RID: 15417
		private Class2102 class2102_0;

		// Token: 0x04003C3A RID: 15418
		private string string_0;

		// Token: 0x04003C3B RID: 15419
		private string[] string_1;

		// Token: 0x04003C3C RID: 15420
		private Struct44[] struct44_0;

		// Token: 0x02000C8F RID: 3215
		public sealed class Class389 : IComparer
		{
			// Token: 0x06006AA2 RID: 27298 RVA: 0x00393BBC File Offset: 0x00391DBC
			public int Compare(object x, object y)
			{
				Struct44 struct44_;
				if (x.GetType() == typeof(int))
				{
					struct44_ = this.class388_0.struct44_0[(int)x];
				}
				else
				{
					struct44_ = (Struct44)x;
				}
				Class386 @class = this.class388_0.method_1(struct44_, Class388.Enum116.const_2);
				int result;
				if (!this.bool_0)
				{
					result = string.Compare(@class.struct67_0.Name, (string)y, true);
				}
				else
				{
					string text = (string)y;
					result = string.Compare(@class.struct67_0.Name, 0, text, 0, text.Length, true);
				}
				return result;
			}

			// Token: 0x04003C3D RID: 15421
			private Class388 class388_0;

			// Token: 0x04003C3E RID: 15422
			private bool bool_0;
		}

		// Token: 0x02000C90 RID: 3216
		public enum Enum116
		{
			// Token: 0x04003C40 RID: 15424
			const_0,
			// Token: 0x04003C41 RID: 15425
			const_1,
			// Token: 0x04003C42 RID: 15426
			const_2
		}
	}
}
