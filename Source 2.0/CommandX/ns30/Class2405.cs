using System;
using System.ComponentModel;
using System.Globalization;
using Sharp3D.Math.Geometry3D;

namespace ns30
{
	// Token: 0x02000404 RID: 1028
	public sealed class Class2405 : ExpandableObjectConverter
	{
		// Token: 0x060019A5 RID: 6565 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x0009DE1C File Offset: 0x0009C01C
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (destinationType == typeof(string) && value is Ray)
			{
				result = ((Ray)value).ToString();
			}
			else
			{
				result = base.ConvertTo(context, culture, value, destinationType);
			}
			return result;
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x0009DE74 File Offset: 0x0009C074
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object result;
			if (value.GetType() == typeof(string))
			{
				result = Ray.smethod_0((string)value);
			}
			else
			{
				result = base.ConvertFrom(context, culture, value);
			}
			return result;
		}
	}
}
