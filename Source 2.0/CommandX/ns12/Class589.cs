using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;

namespace ns12
{
	// Token: 0x02000389 RID: 905
	public sealed class Class589 : IEnumerable
	{
		// Token: 0x060015C7 RID: 5575 RVA: 0x0008C810 File Offset: 0x0008AA10
		public Class591 method_0()
		{
			if (this.class591_0 == null)
			{
				FileStream fileStream = new FileStream(this.string_0, FileMode.Open, FileAccess.Read);
				BinaryReader binaryReader = new BinaryReader(fileStream);
				this.class591_0 = new Class591();
				this.class591_0.method_4(binaryReader);
				binaryReader.Close();
				fileStream.Close();
			}
			return this.class591_0;
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0008C86C File Offset: 0x0008AA6C
		public IEnumerator GetEnumerator()
		{
			return new Class589.Class590(this);
		}

		// Token: 0x04000909 RID: 2313
		private Class591 class591_0;

		// Token: 0x0400090A RID: 2314
		private string string_0;

		// Token: 0x0200038A RID: 906
		private sealed class Class590 : IDisposable, IEnumerator
		{
			// Token: 0x170001D0 RID: 464
			// (get) Token: 0x060015CA RID: 5578 RVA: 0x0008C884 File Offset: 0x0008AA84
			public object Current
			{
				get
				{
					return this.arrayList_0;
				}
			}

			// Token: 0x060015CB RID: 5579 RVA: 0x0008C89C File Offset: 0x0008AA9C
			public Class590(Class589 class589_1)
			{
				this.class589_0 = class589_1;
				FileStream input = new FileStream(class589_1.string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
				this.binaryReader_0 = new BinaryReader(input, Encoding.Default);
				this.method_0();
			}

			// Token: 0x060015CC RID: 5580 RVA: 0x0000F12E File Offset: 0x0000D32E
			public void Reset()
			{
				this.binaryReader_0.BaseStream.Seek((long)this.class591_0.method_3(), SeekOrigin.Begin);
				this.int_0 = 0;
			}

			// Token: 0x060015CD RID: 5581 RVA: 0x0008C900 File Offset: 0x0008AB00
			public bool MoveNext()
			{
				this.int_0++;
				if (this.int_0 <= this.class591_0.method_1())
				{
					this.arrayList_0 = this.method_1();
				}
				bool result = true;
				if (this.int_0 > this.class591_0.method_1())
				{
					result = false;
				}
				return result;
			}

			// Token: 0x060015CE RID: 5582 RVA: 0x0000F155 File Offset: 0x0000D355
			protected void method_0()
			{
				this.class591_0 = new Class591();
				this.class591_0.method_4(this.binaryReader_0);
				this.int_1 = this.class591_0.method_3();
			}

			// Token: 0x060015CF RID: 5583 RVA: 0x0008C95C File Offset: 0x0008AB5C
			private ArrayList method_1()
			{
                ArrayList list = null;
                char ch2;
                bool flag = false;
            Label_0004:
                if (flag)
                {
                    return list;
                }
                int capacity = this.class591_0.method_0();
                list = new ArrayList(capacity);
                char ch = this.binaryReader_0.ReadChar();
                int num2 = 1;
                int index = 0;
                while (true)
                {
                    if (index >= capacity)
                    {
                        if (num2 < this.class591_0.method_2())
                        {
                            byte[] buffer1 = new byte[this.class591_0.method_2() - num2];
                            this.binaryReader_0.ReadBytes(this.class591_0.method_2() - num2);
                        }
                        if (ch != '*')
                        {
                            flag = true;
                        }
                        goto Label_0004;
                    }
                    int count = this.class591_0.method_5()[index].method_5();
                    num2 += count;
                    ch2 = this.class591_0.method_5()[index].method_2();
                    object obj2 = null;
                    char ch3 = ch2;
                    string s = "";
                    switch (ch3)
                    {
                        case 'C':
                            {
                                char[] chArray = new char[count];
                                obj2 = new string(this.binaryReader_0.ReadChars(count)).Trim().Replace("\0", string.Empty);
                                break;
                            }
                        case 'D':
                            {
                                char[] chArray2 = new char[8];
                                chArray2 = this.binaryReader_0.ReadChars(8);
                                s = new string(chArray2, 0, 4);
                                int year = int.Parse(s, CultureInfo.InvariantCulture);
                                s = new string(chArray2, 4, 2);
                                int month = int.Parse(s, CultureInfo.InvariantCulture);
                                s = new string(chArray2, 6, 2);
                                int day = int.Parse(s, CultureInfo.InvariantCulture);
                                obj2 = new DateTime(year, month, day);
                                break;
                            }
                        case 'F':
                        case 'N':
                            {
                                char[] chArray3 = new char[count];
                                s = new string(this.binaryReader_0.ReadChars(count));
                                try
                                {
                                    obj2 = double.Parse(s.Trim(), CultureInfo.InvariantCulture);
                                }
                                catch (FormatException)
                                {
                                    obj2 = s;
                                }
                                break;
                            }
                        case 'L':
                            {
                                char ch5 = (char)this.binaryReader_0.ReadByte();
                                if ((((ch5 != 'T') && (ch5 != 't')) && (ch5 != 'Y')) && (ch5 != 'y'))
                                {
                                    obj2 = false;
                                    break;
                                }
                                obj2 = true;
                                break;
                            }
                        default:
                            goto Label_025A;
                    }
                    list.Add(obj2);
                    index++;
                }
            Label_025A:
                throw new NotSupportedException("Do not know how to parse Field type " + ch2);

            }

            // Token: 0x060015D0 RID: 5584 RVA: 0x0000F184 File Offset: 0x0000D384
            public void Dispose()
			{
				this.binaryReader_0.Close();
			}

			// Token: 0x0400090B RID: 2315
			private Class589 class589_0;

			// Token: 0x0400090C RID: 2316
			private ArrayList arrayList_0;

			// Token: 0x0400090D RID: 2317
			private int int_0 = 0;

			// Token: 0x0400090E RID: 2318
			private BinaryReader binaryReader_0 = null;

			// Token: 0x0400090F RID: 2319
			private int int_1 = 0;

			// Token: 0x04000910 RID: 2320
			private Class591 class591_0 = null;

			// Token: 0x04000911 RID: 2321
			protected string[] string_0 = null;
		}
	}
}
