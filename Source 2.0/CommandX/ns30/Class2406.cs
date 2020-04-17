using System;
using System.ComponentModel;
using System.Globalization;
using Sharp3D.Math.Geometry3D;

namespace ns30
{
	// Token: 0x02000409 RID: 1033
	public sealed class Class2406 : ExpandableObjectConverter
	{
		// Token: 0x060019C4 RID: 6596 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x0009E228 File Offset: 0x0009C428
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (destinationType == typeof(string) && value is Segment)
			{
				result = ((Segment)value).ToString();
			}
			else
			{
				result = base.ConvertTo(context, culture, value, destinationType);
			}
			return result;
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x0009E280 File Offset: 0x0009C480
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object result;
			if (value.GetType() == typeof(string))
			{
				result = Segment.smethod_0((string)value);
			}
			else
			{
				result = base.ConvertFrom(context, culture, value);
			}
			return result;
		}
	}
}
