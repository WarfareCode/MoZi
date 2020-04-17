using System;
using System.Collections.Specialized;
using System.Data;

namespace ns6
{
	// Token: 0x02000C7E RID: 3198
	internal static class Class403
	{
		// Token: 0x06006A19 RID: 27161 RVA: 0x00390120 File Offset: 0x0038E320
		public static Class397 smethod_0(byte[] byte_0, StringDictionary stringDictionary_0, IDataRecord idataRecord_0)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("shapeData");
			}
			if (byte_0.Length < 12)
			{
				throw new ArgumentException("shapeData must be at least 12 bytes long");
			}
			int int_ = Class395.smethod_0(byte_0, 0, Enum118.const_0);
			int num = Class395.smethod_0(byte_0, 4, Enum118.const_0);
			Enum119 @enum = (Enum119)Class395.smethod_0(byte_0, 8, Enum118.const_1);
			if (byte_0.Length != num * 2 + 8)
			{
				throw new InvalidOperationException("Shape data length does not match shape header length");
			}
			Enum119 enum2 = @enum;
			switch (enum2)
			{
			case Enum119.const_0:
			{
				Class397 @class = new Class397(@enum, int_, stringDictionary_0, idataRecord_0);
				Class397 result = @class;
				return result;
			}
			case Enum119.const_1:
			{
				Class397 @class = new Class399(int_, stringDictionary_0, idataRecord_0, byte_0);
				Class397 result = @class;
				return result;
			}
			case (Enum119)2:
			case (Enum119)4:
			case (Enum119)6:
			case (Enum119)7:
				break;
			case Enum119.const_2:
			{
				Class397 @class = new Class401(int_, stringDictionary_0, idataRecord_0, byte_0);
				Class397 result = @class;
				return result;
			}
			case Enum119.const_3:
			{
				Class397 @class = new Class400(int_, stringDictionary_0, idataRecord_0, byte_0);
				Class397 result = @class;
				return result;
			}
			case Enum119.const_4:
			{
				Class397 @class = new Class398(int_, stringDictionary_0, idataRecord_0, byte_0);
				Class397 result = @class;
				return result;
			}
			default:
				if (enum2 == Enum119.const_10)
				{
					Class397 @class = new Class402(int_, stringDictionary_0, idataRecord_0, byte_0);
					Class397 result = @class;
					return result;
				}
				break;
			}
			throw new NotImplementedException(string.Format("Shapetype {0} is not implemented", @enum));
		}
	}
}
