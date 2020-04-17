using System;
using System.ComponentModel;
using System.Globalization;
using Sharp3D.Math.Core;

namespace ns30
{
	// Token: 0x02000398 RID: 920
	public sealed class Class2397 : ExpandableObjectConverter
	{
		// Token: 0x0600164C RID: 5708 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0008E40C File Offset: 0x0008C60C
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (destinationType == typeof(string) && value is Vector4F)
			{
				result = ((Vector4F)value).ToString();
			}
			else
			{
				result = base.ConvertTo(context, culture, value, destinationType);
			}
			return result;
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0008E464 File Offset: 0x0008C664
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object result;
			if (value.GetType() == typeof(string))
			{
				result = Vector4F.smethod_0((string)value);
			}
			else
			{
				result = base.ConvertFrom(context, culture, value);
			}
			return result;
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0008E4AC File Offset: 0x0008C6AC
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return new TypeConverter.StandardValuesCollection(new object[]
			{
				Vector4F.Zero,
				Vector4F.XAxis,
				Vector4F.YAxis,
				Vector4F.ZAxis,
				Vector4F.WAxis
			});
		}
	}
}
