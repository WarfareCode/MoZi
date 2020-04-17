using System;
using System.ComponentModel;
using System.Globalization;
using Sharp3D.Math.Core;

namespace ns30
{
	// Token: 0x02000350 RID: 848
	public sealed class Class2390 : ExpandableObjectConverter
	{
		// Token: 0x060013E8 RID: 5096 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00085A08 File Offset: 0x00083C08
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (destinationType == typeof(string) && value is QuaternionD)
			{
				result = ((QuaternionD)value).ToString();
			}
			else
			{
				result = base.ConvertTo(context, culture, value, destinationType);
			}
			return result;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00085A60 File Offset: 0x00083C60
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object result;
			if (value.GetType() == typeof(string))
			{
				result = QuaternionD.smethod_0((string)value);
			}
			else
			{
				result = base.ConvertFrom(context, culture, value);
			}
			return result;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00085AA8 File Offset: 0x00083CA8
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return new TypeConverter.StandardValuesCollection(new object[]
			{
				QuaternionD.Zero,
				QuaternionD.Identity,
				QuaternionD.XAxis,
				QuaternionD.YAxis,
				QuaternionD.ZAxis,
				QuaternionD.WAxis
			});
		}
	}
}
