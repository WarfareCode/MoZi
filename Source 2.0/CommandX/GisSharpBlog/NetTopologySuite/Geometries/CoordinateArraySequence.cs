using System;
using System.Text;
using GeoAPI.Geometries;
using ns14;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x0200045D RID: 1117
	[Serializable]
	public class CoordinateArraySequence : ICloneable, ICoordinateSequence
	{
		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x000B54D0 File Offset: 0x000B36D0
		public int Count
		{
			get
			{
				return this.coordinates.Length;
			}
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x00011D82 File Offset: 0x0000FF82
		public CoordinateArraySequence(ICoordinate[] icoordinate_0)
		{
			this.coordinates = icoordinate_0;
			if (icoordinate_0 == null)
			{
				this.coordinates = new ICoordinate[0];
			}
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x000B54E8 File Offset: 0x000B36E8
		public ICoordinate imethod_0(int int_0)
		{
			return this.coordinates[int_0];
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x000B5500 File Offset: 0x000B3700
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

		// Token: 0x06001C8F RID: 7311 RVA: 0x000B5568 File Offset: 0x000B3768
		public  object Clone()
		{
			ICoordinate[] icoordinate_ = this.method_0();
			return new CoordinateArraySequence(icoordinate_);
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x000B5584 File Offset: 0x000B3784
		protected ICoordinate[] method_0()
		{
			ICoordinate[] array = new ICoordinate[this.Count];
			for (int i = 0; i < this.coordinates.Length; i++)
			{
				array[i] = (ICoordinate)this.coordinates[i].Clone();
			}
			return array;
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x000B55CC File Offset: 0x000B37CC
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
			default:
				throw new ArgumentException("invalid ordinate index: " + enum142_0);
			}
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x000B5634 File Offset: 0x000B3834
		public ICoordinate[] imethod_3()
		{
			return this.coordinates;
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x000B564C File Offset: 0x000B384C
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
					stringBuilder.Append(this.coordinates[i]);
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

		// Token: 0x04000C7D RID: 3197
		protected ICoordinate[] coordinates;
	}
}
