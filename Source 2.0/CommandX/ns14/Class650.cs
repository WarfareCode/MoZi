using System;
using System.Collections;
using GeoAPI.Geometries;

namespace ns14
{
	// Token: 0x02000450 RID: 1104
	public sealed class Class650 : IComparer
	{
		// Token: 0x06001C5D RID: 7261 RVA: 0x000B4EC0 File Offset: 0x000B30C0
		public int Compare(object x, object y)
		{
			if (x is ICoordinate && y is ICoordinate)
			{
				ICoordinate coordinate = (ICoordinate)x;
				ICoordinate coordinate2 = (ICoordinate)y;
				int result;
				if (coordinate.imethod_0() < coordinate2.imethod_0())
				{
					result = -1;
				}
				else if (coordinate.imethod_0() > coordinate2.imethod_0())
				{
					result = 1;
				}
				else if (coordinate.imethod_2() < coordinate2.imethod_2())
				{
					result = -1;
				}
				else if (coordinate.imethod_2() > coordinate2.imethod_2())
				{
					result = 1;
				}
				else
				{
					result = 0;
				}
				return result;
			}
			throw new ArgumentException("Wrong arguments type: ICoordinate expected");
		}
	}
}
