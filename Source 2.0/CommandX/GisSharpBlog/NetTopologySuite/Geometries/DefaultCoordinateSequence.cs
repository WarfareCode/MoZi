using System;
using System.Text;
using GeoAPI.Geometries;
using ns14;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x020003DF RID: 991
	[Obsolete("No longer used.")]
	[Serializable]
	public sealed class DefaultCoordinateSequence : ICloneable, ICoordinateSequence
	{
		// Token: 0x1700021A RID: 538
		public object this[int int_0]
		{
			get
			{
				return this.coordinates[int_0];
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x0009880C File Offset: 0x00096A0C
		public int Count
		{
			get
			{
				return this.coordinates.Length;
			}
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0001049A File Offset: 0x0000E69A
		public DefaultCoordinateSequence(ICoordinate[] icoordinate_0)
		{
			if (Geometry.smethod_1(icoordinate_0))
			{
				throw new ArgumentException("Null coordinate");
			}
			this.coordinates = icoordinate_0;
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00098824 File Offset: 0x00096A24
		public ICoordinate imethod_0(int int_0)
		{
			return this.coordinates[int_0];
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0009883C File Offset: 0x00096A3C
		public double imethod_1(int int_0, Enum142 enum142_0)
		{
			double result;
			switch (enum142_0)
			{
			case Enum142.const_0:
				result = this.coordinates[int_0].imethod_0();
				break;
			case Enum142.const_1:
				result = this.coordinates[int_0].imethod_2();
				break;
			case Enum142.const_2:
				result = this.coordinates[int_0].imethod_4();
				break;
			default:
				result = double.NaN;
				break;
			}
			return result;
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x000988A4 File Offset: 0x00096AA4
		public void imethod_2(int int_0, Enum142 enum142_0, double double_0)
		{
			switch (enum142_0)
			{
			case Enum142.const_0:
				this.coordinates[int_0].imethod_1(double_0);
				break;
			case Enum142.const_1:
				this.coordinates[int_0].imethod_3(double_0);
				break;
			case Enum142.const_2:
				this.coordinates[int_0].imethod_5(double_0);
				break;
			}
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x000988F8 File Offset: 0x00096AF8
		public object Clone()
		{
			ICoordinate[] array = new ICoordinate[this.coordinates.Length];
			for (int i = 0; i < this.coordinates.Length; i++)
			{
				array[i] = (Coordinate)this.coordinates[i].Clone();
			}
			return new DefaultCoordinateSequence(array);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00098948 File Offset: 0x00096B48
		public ICoordinate[] imethod_3()
		{
			return this.coordinates;
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00098960 File Offset: 0x00096B60
		public override string ToString()
		{
			string result;
			if (this.coordinates.Length > 0)
			{
				StringBuilder stringBuilder = new StringBuilder(17 * this.coordinates.Length);
				stringBuilder.Append('(');
				stringBuilder.Append(this.coordinates[0]);
				for (int i = 1; i < this.coordinates.Length; i++)
				{
					stringBuilder.Append(", ");
					stringBuilder.Append(this.coordinates[i].ToString());
				}
				stringBuilder.Append(')');
				result = stringBuilder.ToString();
			}
			else
			{
				result = "()";
			}
			return result;
		}

		// Token: 0x04000A31 RID: 2609
		private ICoordinate[] coordinates = null;
	}
}
