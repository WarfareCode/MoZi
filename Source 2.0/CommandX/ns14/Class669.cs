using System;
using GeoAPI.Geometries;

namespace ns14
{
	// Token: 0x0200048A RID: 1162
	public sealed class Class669
	{
		// Token: 0x06001E10 RID: 7696 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class669()
		{
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x000C2178 File Offset: 0x000C0378
		public static char smethod_0(Dimensions dimensions_0)
		{
			char result;
			switch (dimensions_0)
			{
			case Dimensions.Dontcare:
				result = '*';
				break;
			case Dimensions.True:
				result = 'T';
				break;
			case Dimensions.False:
				result = 'F';
				break;
			case Dimensions.Point:
				result = '0';
				break;
			case Dimensions.Curve:
				result = '1';
				break;
			case Dimensions.Surface:
				result = '2';
				break;
			default:
				throw new ArgumentOutOfRangeException("Unknown dimension value: " + dimensions_0);
			}
			return result;
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x000C21DC File Offset: 0x000C03DC
		public static Dimensions smethod_1(char char_0)
		{
			char c = char.ToUpper(char_0);
			if (c <= '2')
			{
				if (c == '*')
				{
					Dimensions result = Dimensions.Dontcare;
					return result;
				}
				switch (c)
				{
				case '0':
				{
					Dimensions result = Dimensions.Point;
					return result;
				}
				case '1':
				{
					Dimensions result = Dimensions.Curve;
					return result;
				}
				case '2':
				{
					Dimensions result = Dimensions.Surface;
					return result;
				}
				}
			}
			else
			{
				if (c == 'F')
				{
					Dimensions result = Dimensions.False;
					return result;
				}
				if (c == 'T')
				{
					Dimensions result = Dimensions.True;
					return result;
				}
			}
			throw new ArgumentOutOfRangeException("Unknown dimension symbol: " + char_0);
		}
	}
}
