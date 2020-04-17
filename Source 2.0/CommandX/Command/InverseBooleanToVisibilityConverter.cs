using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using Microsoft.VisualBasic.CompilerServices;
using ns35;

namespace Command
{
	// Token: 0x02000A81 RID: 2689
	[Attribute11, Attribute12, Attribute13]
	public sealed class InverseBooleanToVisibilityConverter : IValueConverter
	{
		// Token: 0x06005509 RID: 21769 RVA: 0x00237B58 File Offset: 0x00235D58
		private object method_0(object value)
		{
			object result;
			if (!(value is bool))
			{
				result = Visibility.Visible;
			}
			else if (Conversions.ToBoolean(value))
			{
				result = Visibility.Collapsed;
			}
			else
			{
				result = Visibility.Visible;
			}
			return result;
		}

		// Token: 0x0600550A RID: 21770 RVA: 0x00237B9C File Offset: 0x00235D9C
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return this.method_0(RuntimeHelpers.GetObjectValue(value));
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x00025A78 File Offset: 0x00023C78
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
