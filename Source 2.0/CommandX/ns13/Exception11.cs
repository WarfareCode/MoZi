using System;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;

namespace ns13
{
	// Token: 0x02000434 RID: 1076
	public sealed class Exception11 : ApplicationException
	{
		// Token: 0x06001B91 RID: 7057 RVA: 0x000B1668 File Offset: 0x000AF868
		private static string smethod_0(string string_0, ICoordinate icoordinate_1)
		{
			string result;
			if (icoordinate_1 != null)
			{
				result = string.Concat(new object[]
				{
					string_0,
					" [ ",
					icoordinate_1,
					" ]"
				});
			}
			else
			{
				result = string_0;
			}
			return result;
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0001155A File Offset: 0x0000F75A
		public Exception11(string string_0, ICoordinate icoordinate_1) : base(Exception11.smethod_0(string_0, icoordinate_1))
		{
			this.icoordinate_0 = new Coordinate(icoordinate_1);
		}

		// Token: 0x04000BCF RID: 3023
		private ICoordinate icoordinate_0 = null;
	}
}
