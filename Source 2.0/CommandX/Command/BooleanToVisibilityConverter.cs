using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using Microsoft.VisualBasic.CompilerServices;
using ns35;

namespace Command
{
	// Token: 0x02000A7F RID: 2687
	[Attribute11, Attribute12, Attribute13]
	public sealed class BooleanToVisibilityConverter : IValueConverter
	{
		// Token: 0x06005503 RID: 21763 RVA: 0x00237AF8 File Offset: 0x00235CF8
		private object method_0(object value)
		{
			object result;
			if (!(value is bool))
			{
				result = Visibility.Collapsed;
			}
			else if (Conversions.ToBoolean(value))
			{
				result = Visibility.Visible;
			}
			else
			{
				result = Visibility.Collapsed;
			}
			return result;
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x00237B3C File Offset: 0x00235D3C
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return this.method_0(RuntimeHelpers.GetObjectValue(value));
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x00025A78 File Offset: 0x00023C78
		public  object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
