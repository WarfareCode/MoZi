using System;
using System.ComponentModel;
using System.Globalization;
using Sharp3D.Math.Core;

namespace ns30
{
	// Token: 0x02000395 RID: 917
	public sealed class Class2396 : ExpandableObjectConverter
	{
		// Token: 0x0600162E RID: 5678 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x0008DD84 File Offset: 0x0008BF84
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (destinationType == typeof(string) && value is Vector4D)
			{
				result = ((Vector4D)value).ToString();
			}
			else
			{
				result = base.ConvertTo(context, culture, value, destinationType);
			}
			return result;
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x0008DDDC File Offset: 0x0008BFDC
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object result;
			if (value.GetType() == typeof(string))
			{
				result = Vector4D.smethod_0((string)value);
			}
			else
			{
				result = base.ConvertFrom(context, culture, value);
			}
			return result;
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x0008DE24 File Offset: 0x0008C024
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return new TypeConverter.StandardValuesCollection(new object[]
			{
				Vector4D.Zero,
				Vector4D.XAxis,
				Vector4D.YAxis,
				Vector4D.ZAxis,
				Vector4D.WAxis
			});
		}
	}
}
