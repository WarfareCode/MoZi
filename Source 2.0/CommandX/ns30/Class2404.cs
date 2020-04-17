using System;
using System.ComponentModel;
using System.Globalization;
using Sharp3D.Math.Geometry3D;

namespace ns30
{
	// Token: 0x020003F6 RID: 1014
	public sealed class Class2404 : ExpandableObjectConverter
	{
		// Token: 0x0600195D RID: 6493 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x0009AE08 File Offset: 0x00099008
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (destinationType == typeof(string) && value is Plane)
			{
				result = ((Plane)value).ToString();
			}
			else
			{
				result = base.ConvertTo(context, culture, value, destinationType);
			}
			return result;
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x0009AE60 File Offset: 0x00099060
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object result;
			if (value.GetType() == typeof(string))
			{
				result = Plane.smethod_0((string)value);
			}
			else
			{
				result = base.ConvertFrom(context, culture, value);
			}
			return result;
		}
	}
}
