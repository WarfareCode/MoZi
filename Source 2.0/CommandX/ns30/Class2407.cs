using System;
using System.ComponentModel;
using System.Globalization;
using Sharp3D.Math.Geometry3D;

namespace ns30
{
	// Token: 0x0200040E RID: 1038
	public sealed class Class2407 : ExpandableObjectConverter
	{
		// Token: 0x06001A24 RID: 6692 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x0009EE04 File Offset: 0x0009D004
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (destinationType == typeof(string) && value is Sphere)
			{
				result = ((Sphere)value).ToString();
			}
			else
			{
				result = base.ConvertTo(context, culture, value, destinationType);
			}
			return result;
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x0009EE5C File Offset: 0x0009D05C
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object result;
			if (value.GetType() == typeof(string))
			{
				result = Sphere.smethod_0((string)value);
			}
			else
			{
				result = base.ConvertFrom(context, culture, value);
			}
			return result;
		}
	}
}
