using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;

namespace ns35
{
	// Token: 0x02000A88 RID: 2696
	public sealed class Class2536
	{
		// Token: 0x06005527 RID: 21799 RVA: 0x0023813C File Offset: 0x0023633C
		public static BitmapImage smethod_0(Bitmap bitmap_0)
		{
			BitmapImage result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				bitmap_0.Save(memoryStream, ImageFormat.Png);
				memoryStream.Position = 0L;
				BitmapImage bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.StreamSource = memoryStream;
				bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
				bitmapImage.EndInit();
				result = bitmapImage;
			}
			return result;
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x002381B0 File Offset: 0x002363B0
		public static BitmapImage smethod_1(string s)
		{
			BitmapImage bitmapImage = new BitmapImage();
			bitmapImage.BeginInit();
			bitmapImage.StreamSource = new MemoryStream(Convert.FromBase64String(s));
			bitmapImage.EndInit();
			return bitmapImage;
		}
	}
}
