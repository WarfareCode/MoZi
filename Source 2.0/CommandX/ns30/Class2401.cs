using System;
using System.ComponentModel;
using System.Globalization;
using Sharp3D.Math.Geometry2D;

namespace ns30
{
	// Token: 0x020003ED RID: 1005
	public sealed class Class2401 : ExpandableObjectConverter
	{
		// Token: 0x06001905 RID: 6405 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00099940 File Offset: 0x00097B40
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

		// Token: 0x06001908 RID: 6408 RVA: 0x00099998 File Offset: 0x00097B98
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
