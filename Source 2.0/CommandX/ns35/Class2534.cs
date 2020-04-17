using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace ns35
{
	// Token: 0x02000A84 RID: 2692
	public sealed class Class2534 : IValueConverter
	{
		// Token: 0x0600551A RID: 21786 RVA: 0x00237CA4 File Offset: 0x00235EA4
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			double num = Conversions.ToDouble(value);
			Brush result = Brushes.Green;
			if (num >= 90.0)
			{
				result = Brushes.Red;
			}
			else if (num >= 60.0)
			{
				result = Brushes.Yellow;
			}
			return result;
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x00025A78 File Offset: 0x00023C78
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
