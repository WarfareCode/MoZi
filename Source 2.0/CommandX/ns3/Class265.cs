using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3
{
	// Token: 0x02000C05 RID: 3077
	public sealed class Class265<T> : IComparer<string>
	{
		// Token: 0x06006670 RID: 26224 RVA: 0x0002C42E File Offset: 0x0002A62E
		public Class265(bool inAscendingOrder = true)
		{
			this.dictionary_0 = new Dictionary<string, string[]>();
			this.bool_0 = inAscendingOrder;
		}

		// Token: 0x06006671 RID: 26225 RVA: 0x003538DC File Offset: 0x00351ADC
		int IComparer<string>.Compare(string x, string y)
		{
			int num;
			int result;
			if (Operators.CompareString(x, y, false) == 0)
			{
				num = 0;
			}
			else
			{
				string[] array;
				if (!this.dictionary_0.TryGetValue(x, out array))
				{
					array = Regex.Split(x.Replace(" ", ""), "([0-9]+)");
					this.dictionary_0.Add(x, array);
				}
				string[] array2;
				if (!this.dictionary_0.TryGetValue(y, out array2))
				{
					array2 = Regex.Split(y.Replace(" ", ""), "([0-9]+)");
					this.dictionary_0.Add(y, array2);
				}
				int num2 = 0;
				int num3;
				while (num2 < array.Length && num2 < array2.Length)
				{
					if (Operators.CompareString(array[num2], array2[num2], false) != 0)
					{
						num3 = Class265<T>.smethod_0(array[num2], array2[num2]);
						num = (this.bool_0 ? num3 : (-num3));
						result = num;
						return result;
					}
					num2++;
				}
				if (array2.Length > array.Length)
				{
					num3 = 1;
				}
				else if (array.Length > array2.Length)
				{
					num3 = -1;
				}
				else
				{
					num3 = 0;
				}
				num = (this.bool_0 ? num3 : (-num3));
			}
			result = num;
			return result;
		}

		// Token: 0x06006672 RID: 26226 RVA: 0x003539FC File Offset: 0x00351BFC
		private static int smethod_0(string string_0, string string_1)
		{
			int num;
			int result;
			int value;
			if (!int.TryParse(string_0, out num))
			{
				result = string_0.CompareTo(string_1);
			}
			else if (!int.TryParse(string_1, out value))
			{
				result = string_0.CompareTo(string_1);
			}
			else
			{
				result = num.CompareTo(value);
			}
			return result;
		}

		// Token: 0x0400384A RID: 14410
		private bool bool_0;

		// Token: 0x0400384B RID: 14411
		private Dictionary<string, string[]> dictionary_0;
	}
}
