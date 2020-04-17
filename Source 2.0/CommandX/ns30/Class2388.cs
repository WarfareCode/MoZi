using System;
using System.ComponentModel;
using System.Globalization;
using Sharp3D.Math.Core;

namespace ns30
{
	// Token: 0x0200025C RID: 604
	public sealed class Class2388 : ExpandableObjectConverter
	{
		// Token: 0x06000E11 RID: 3601 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0007AFC8 File Offset: 0x000791C8
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (destinationType == typeof(string) && value is ComplexF)
			{
				result = ((ComplexF)value).ToString();
			}
			else
			{
				result = base.ConvertTo(context, culture, value, destinationType);
			}
			return result;
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0007B020 File Offset: 0x00079220
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object result;
			if (value.GetType() == typeof(string))
			{
				result = ComplexF.smethod_0((string)value);
			}
			else
			{
				result = base.ConvertFrom(context, culture, value);
			}
			return result;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0007B068 File Offset: 0x00079268
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return new TypeConverter.StandardValuesCollection(new object[]
			{
				ComplexF.Zero,
				ComplexF.One
			});
		}
	}
}
