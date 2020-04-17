using System;

namespace ns28
{
	// Token: 0x020007FD RID: 2045
	public sealed class HexConverter
	{
		// Token: 0x06003245 RID: 12869 RVA: 0x00004A21 File Offset: 0x00002C21
		private HexConverter()
		{
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x0010DA58 File Offset: 0x0010BC58
		public static string ConvertAny2Any(string valueIn, int baseIn, int baseOut)
		{
			string text = "Error";
			valueIn = valueIn.ToUpper();
			string result;
			if (baseIn < 2 || baseIn > 36 || baseOut < 2 || baseOut > 36)
			{
				result = text;
			}
			else if (valueIn.Trim().Length == 0)
			{
				result = text;
			}
			else if (baseIn == baseOut)
			{
				result = valueIn;
			}
			else
			{
				double num = 0.0;
				try
				{
					if (baseIn == 10)
					{
						num = double.Parse(valueIn);
					}
					else
					{
						char[] array = valueIn.ToCharArray();
						int num2 = array.Length;
						for (int i = 0; i < array.Length; i++)
						{
							int num3 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(array[i]);
							if (num3 < 0 || num3 > baseIn - 1)
							{
								result = text;
								return result;
							}
							num2--;
							num += (double)num3 * Math.Pow((double)baseIn, (double)num2);
						}
					}
					if (baseOut == 10)
					{
						text = num.ToString();
					}
					else
					{
						text = string.Empty;
						while (num > 0.0)
						{
							int num4 = (int)(num % (double)baseOut);
							num = (num - (double)num4) / (double)baseOut;
							text = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring(num4, 1) + text;
						}
					}
				}
				catch (Exception ex)
				{
					text = ex.Message;
				}
				result = text;
			}
			return result;
		}
	}
}
