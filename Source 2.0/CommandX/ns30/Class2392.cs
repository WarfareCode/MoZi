using System;
using System.ComponentModel;
using System.Globalization;
using Sharp3D.Math.Core;

namespace ns30
{
	// Token: 0x02000374 RID: 884
	public sealed class Class2392 : ExpandableObjectConverter
	{
		// Token: 0x06001539 RID: 5433 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0008B33C File Offset: 0x0008953C
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			object result;
			if (destinationType == typeof(string) && value is Vector2D)
			{
				result = ((Vector2D)value).ToString();
			}
			else
			{
				result = base.ConvertTo(context, culture, value, destinationType);
			}
			return result;
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0008B394 File Offset: 0x00089594
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			object result;
			if (value.GetType() == typeof(string))
			{
				result = Vector2D.smethod_0((string)value);
			}
			else
			{
				result = base.ConvertFrom(context, culture, value);
			}
			return result;
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0008B3DC File Offset: 0x000895DC
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return new TypeConverter.StandardValuesCollection(new object[]
			{
				Vector2D.Zero,
				Vector2D.XAxis,
				Vector2D.YAxis
			});
		}
	}
}
