using System;
using System.ComponentModel;
using System.Globalization;
using Sharp3D.Math.Geometry2D;

namespace ns30
{
	// Token: 0x020003DE RID: 990
	public sealed class Class2398 : ExpandableObjectConverter
	{
		// Token: 0x060018A5 RID: 6309 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00098754 File Offset: 0x00096954
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (destinationType == typeof(string) && value is AxisAlignedBox)
			{
				result = ((AxisAlignedBox)value).ToString();
			}
			else
			{
				result = base.ConvertTo(context, culture, value, destinationType);
			}
			return result;
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x000987AC File Offset: 0x000969AC
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object result;
			if (value.GetType() == typeof(string))
			{
				result = AxisAlignedBox.smethod_0((string)value);
			}
			else
			{
				result = base.ConvertFrom(context, culture, value);
			}
			return result;
		}
	}
}
