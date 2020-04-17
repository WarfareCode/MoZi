using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace ns32
{
	// Token: 0x020004E2 RID: 1250
	public sealed class Class2456
	{
		// Token: 0x06002090 RID: 8336 RVA: 0x0001399E File Offset: 0x00011B9E
		public Class2456(string string_1)
		{
			this.string_0 = string_1;
			this.arrayList_0 = new ArrayList();
			this.arrayList_1 = new ArrayList();
			this.method_3();
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x000D4AD4 File Offset: 0x000D2CD4
		public override string ToString()
		{
			return this.string_0;
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x000D4AEC File Offset: 0x000D2CEC
		public bool method_0(string string_1)
		{
			bool result = false;
			if (this.arrayList_0.Count == 0)
			{
				result = true;
			}
			else
			{
				foreach (Regex regex in this.arrayList_0)
				{
					if (regex.IsMatch(string_1))
					{
						result = true;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x000D4B6C File Offset: 0x000D2D6C
		public bool method_1(string string_1)
		{
			bool result = false;
			foreach (Regex regex in this.arrayList_1)
			{
				if (regex.IsMatch(string_1))
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x000139C9 File Offset: 0x00011BC9
		public bool method_2(string string_1)
		{
			return this.method_0(string_1) && !this.method_1(string_1);
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x000D4BD8 File Offset: 0x000D2DD8
		private void method_3()
		{
			if (this.string_0 != null)
			{
				string[] array = this.string_0.Split(new char[]
				{
					';'
				});
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != null && array[i].Length > 0)
					{
						bool flag = array[i][0] != '-';
						string pattern;
						if (array[i][0] == '+')
						{
							pattern = array[i].Substring(1, array[i].Length - 1);
						}
						else if (array[i][0] == '-')
						{
							pattern = array[i].Substring(1, array[i].Length - 1);
						}
						else
						{
							pattern = array[i];
						}
						if (flag)
						{
							this.arrayList_0.Add(new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline));
						}
						else
						{
							this.arrayList_1.Add(new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline));
						}
					}
				}
			}
		}

		// Token: 0x04000FCD RID: 4045
		private string string_0;

		// Token: 0x04000FCE RID: 4046
		private ArrayList arrayList_0;

		// Token: 0x04000FCF RID: 4047
		private ArrayList arrayList_1;
	}
}
