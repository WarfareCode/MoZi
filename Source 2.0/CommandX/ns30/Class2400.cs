using System;
using System.ComponentModel;
using System.Globalization;
using Sharp3D.Math.Geometry2D;

namespace ns30
{
	// Token: 0x020003E8 RID: 1000
	public sealed class Class2400 : ExpandableObjectConverter
	{
		// Token: 0x060018E8 RID: 6376 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x000994E0 File Offset: 0x000976E0
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (destinationType == typeof(string) && value is OrientedBox)
			{
				result = ((OrientedBox)value).ToString();
			}
			else
			{
				result = base.ConvertTo(context, culture, value, destinationType);
			}
			return result;
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00099538 File Offset: 0x00097738
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object result;
			if (value.GetType() == typeof(string))
			{
				result = OrientedBox.smethod_0((string)value);
			}
			else
			{
				result = base.ConvertFrom(context, culture, value);
			}
			return result;
		}
	}
}
