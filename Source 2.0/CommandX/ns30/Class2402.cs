using System;
using System.ComponentModel;
using System.Globalization;
using Sharp3D.Math.Geometry3D;

namespace ns30
{
	// Token: 0x020003F0 RID: 1008
	public sealed class Class2402 : ExpandableObjectConverter
	{
		// Token: 0x06001917 RID: 6423 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00099CAC File Offset: 0x00097EAC
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

		// Token: 0x0600191A RID: 6426 RVA: 0x00099D04 File Offset: 0x00097F04
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
