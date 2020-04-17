using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000390 RID: 912
	[Serializable]
	public sealed class PrecisionModel : IComparable<IPrecisionModel>, IEquatable<IPrecisionModel>, IComparable, IPrecisionModel
	{
		// Token: 0x060015FB RID: 5627 RVA: 0x0000F296 File Offset: 0x0000D496
		public PrecisionModel()
		{
			this.modelType = PrecisionModels.Floating;
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x0000F2A5 File Offset: 0x0000D4A5
		public PrecisionModel(PrecisionModels precisionModels_0)
		{
			this.modelType = precisionModels_0;
			if (precisionModels_0 == PrecisionModels.Fixed)
			{
				this.method_0(1.0);
			}
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x0005CD70 File Offset: 0x0005AF70
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x0008D538 File Offset: 0x0008B738
		public int imethod_1()
		{
			int result;
			switch (this.modelType)
			{
			case PrecisionModels.Floating:
				result = 16;
				break;
			case PrecisionModels.FloatingSingle:
				result = 6;
				break;
			case PrecisionModels.Fixed:
				result = 1 + (int)Math.Ceiling(Math.Log(this.imethod_2()) / Math.Log(10.0));
				break;
			default:
				throw new ArgumentOutOfRangeException(this.modelType.ToString());
			}
			return result;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0008D5A8 File Offset: 0x0008B7A8
		public double imethod_2()
		{
			return this.scale;
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x0000F2CC File Offset: 0x0000D4CC
		public void method_0(double double_0)
		{
			this.scale = Math.Abs(double_0);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0008D5C0 File Offset: 0x0008B7C0
		public PrecisionModels imethod_0()
		{
			return this.modelType;
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0008D5D8 File Offset: 0x0008B7D8
		public double vmethod_0(double double_0)
		{
			double result;
			if (this.modelType == PrecisionModels.FloatingSingle)
			{
				float num = (float)double_0;
				result = (double)num;
			}
			else if (this.modelType == PrecisionModels.Fixed)
			{
				result = Math.Floor(double_0 * this.scale + 0.5) / this.scale;
			}
			else
			{
				result = double_0;
			}
			return result;
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x0000F2DA File Offset: 0x0000D4DA
		public void imethod_3(ICoordinate icoordinate_0)
		{
			if (this.modelType != PrecisionModels.Floating)
			{
				icoordinate_0.imethod_1(this.vmethod_0(icoordinate_0.imethod_0()));
				icoordinate_0.imethod_3(this.vmethod_0(icoordinate_0.imethod_2()));
			}
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x0008D63C File Offset: 0x0008B83C
		public override string ToString()
		{
			string result = "UNKNOWN";
			if (this.modelType == PrecisionModels.Floating)
			{
				result = "Floating";
			}
			else if (this.modelType == PrecisionModels.FloatingSingle)
			{
				result = "Floating-Single";
			}
			else if (this.modelType == PrecisionModels.Fixed)
			{
				result = "Fixed (Scale=" + this.imethod_2() + ")";
			}
			return result;
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x0000F30B File Offset: 0x0000D50B
		public override bool Equals(object obj)
		{
			return obj != null && obj is IPrecisionModel && this.Equals((IPrecisionModel)obj);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x0000F327 File Offset: 0x0000D527
		public bool Equals(IPrecisionModel other)
		{
			return this.modelType == other.imethod_0() && this.scale == other.imethod_2();
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x0008D6A8 File Offset: 0x0008B8A8
		public int CompareTo(object target)
		{
			return this.CompareTo((IPrecisionModel)target);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0008D6C4 File Offset: 0x0008B8C4
		public int CompareTo(IPrecisionModel other)
		{
			int num = this.imethod_1();
			int value = other.imethod_1();
			return num.CompareTo(value);
		}

		// Token: 0x04000929 RID: 2345
		private const int FloatingPrecisionDigits = 16;

		// Token: 0x0400092A RID: 2346
		private const int FloatingSinglePrecisionDigits = 6;

		// Token: 0x0400092B RID: 2347
		private const int FixedPrecisionDigits = 1;

		// Token: 0x0400092C RID: 2348
		public const double MaximumPreciseValue = 9007199254740992.0;

		// Token: 0x0400092D RID: 2349
		private PrecisionModels modelType;

		// Token: 0x0400092E RID: 2350
		private double scale;
	}
}
