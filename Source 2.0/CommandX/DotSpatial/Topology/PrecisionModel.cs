using System;

namespace DotSpatial.Topology
{
	// Token: 0x02000614 RID: 1556
	[Serializable]
	public sealed class PrecisionModel : IComparable
	{
		// Token: 0x0600279A RID: 10138 RVA: 0x00016063 File Offset: 0x00014263
		public PrecisionModel()
		{
			this._modelType = PrecisionModelType.Floating;
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x00016072 File Offset: 0x00014272
		public PrecisionModel(PrecisionModelType precisionModelType_0)
		{
			this._modelType = precisionModelType_0;
			if (precisionModelType_0 == PrecisionModelType.Fixed)
			{
				this._scale = 1.0;
			}
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x00016099 File Offset: 0x00014299
		public PrecisionModel(double double_0)
		{
			this._modelType = PrecisionModelType.Fixed;
			this._scale = double_0;
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x000160AF File Offset: 0x000142AF
		public PrecisionModel(PrecisionModel precisionModel_0)
		{
			this._modelType = precisionModel_0._modelType;
			this._scale = precisionModel_0._scale;
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x000F0EDC File Offset: 0x000EF0DC
		public  int GetMaximumSignificantDigits()
		{
			int result;
			switch (this._modelType)
			{
			case PrecisionModelType.Floating:
				result = 16;
				break;
			case PrecisionModelType.FloatingSingle:
				result = 6;
				break;
			case PrecisionModelType.Fixed:
				result = 1 + (int)Math.Ceiling(Math.Log(this.GetScale()) / Math.Log(10.0));
				break;
			default:
				throw new ArgumentOutOfRangeException(this._modelType.ToString());
			}
			return result;
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x000F0F48 File Offset: 0x000EF148
		public  double GetScale()
		{
			return this._scale;
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x000F0F60 File Offset: 0x000EF160
		public  int CompareTo(object target)
		{
			PrecisionModel precisionModel = (PrecisionModel)target;
			int maximumSignificantDigits = this.GetMaximumSignificantDigits();
			int maximumSignificantDigits2 = precisionModel.GetMaximumSignificantDigits();
			return maximumSignificantDigits.CompareTo(maximumSignificantDigits2);
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x0005CD70 File Offset: 0x0005AF70
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x000F0F8C File Offset: 0x000EF18C
		public  PrecisionModelType GetPrecisionModelType()
		{
			return this._modelType;
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x000F0FA4 File Offset: 0x000EF1A4
		public  double MakePrecise(double val)
		{
			double result;
			if (this._modelType == PrecisionModelType.FloatingSingle)
			{
				float num = (float)val;
				result = (double)num;
			}
			else if (this._modelType == PrecisionModelType.Fixed)
			{
				result = Math.Floor(val * this._scale + 0.5) / this._scale;
			}
			else
			{
				result = val;
			}
			return result;
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x000160CF File Offset: 0x000142CF
		public  void MakePrecise(Coordinate coord)
		{
			if (this._modelType != PrecisionModelType.Floating)
			{
				coord.X = this.MakePrecise(coord.X);
				coord.Y = this.MakePrecise(coord.Y);
			}
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x000F0FFC File Offset: 0x000EF1FC
		public override string ToString()
		{
			string result = "UNKNOWN";
			if (this._modelType == PrecisionModelType.Floating)
			{
				result = "Floating";
			}
			else if (this._modelType == PrecisionModelType.FloatingSingle)
			{
				result = "Floating-Single";
			}
			else if (this._modelType == PrecisionModelType.Fixed)
			{
				result = "Fixed (Scale=" + this.GetScale() + ")";
			}
			return result;
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x000F1068 File Offset: 0x000EF268
		public override bool Equals(object obj)
		{
			bool result;
			if (obj == null)
			{
				result = false;
			}
			else if (!(obj is PrecisionModel))
			{
				result = false;
			}
			else
			{
				PrecisionModel precisionModel = (PrecisionModel)obj;
				result = (this._modelType == precisionModel._modelType && this._scale == precisionModel._scale);
			}
			return result;
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00004A84 File Offset: 0x00002C84
		public static bool Equals(PrecisionModel precisionModel_0, PrecisionModel precisionModel_1)
		{
			return object.Equals(precisionModel_0, precisionModel_1);
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x00016103 File Offset: 0x00014303
		public static bool NotEquals(PrecisionModel precisionModel_0, PrecisionModel precisionModel_1)
		{
			return !PrecisionModel.Equals(precisionModel_0, precisionModel_1);
		}

		// Token: 0x0400130B RID: 4875
		private const int FLOATING_PRECISION_DIGITS = 16;

		// Token: 0x0400130C RID: 4876
		private const int FLOATING_SINGLE_PRECISION_DIGITS = 6;

		// Token: 0x0400130D RID: 4877
		private const int FIXED_PRECISION_DIGITS = 1;

		// Token: 0x0400130E RID: 4878
		public const double MAXIMUM_PRECISE_VALUE = 9007199254740992.0;

		// Token: 0x0400130F RID: 4879
		private readonly PrecisionModelType _modelType;

		// Token: 0x04001310 RID: 4880
		private double _scale;
	}
}
