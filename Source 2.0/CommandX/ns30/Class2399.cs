using System;
using System.ComponentModel;
using System.Globalization;
using Sharp3D.Math.Geometry2D;

namespace ns30
{
	// Token: 0x020003E2 RID: 994
	public sealed class Class2399 : ExpandableObjectConverter
	{
		// Token: 0x060018C2 RID: 6338 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00098C70 File Offset: 0x00096E70
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (destinationType == typeof(string) && value is Circle)
			{
				result = ((Circle)value).ToString();
			}
			else
			{
				result = base.ConvertTo(context, culture, value, destinationType);
			}
			return result;
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00098CC8 File Offset: 0x00096EC8
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object result;
			if (value.GetType() == typeof(string))
			{
				result = Circle.smethod_0((string)value);
			}
			else
			{
				result = base.ConvertFrom(context, culture, value);
			}
			return result;
		}
	}
}
