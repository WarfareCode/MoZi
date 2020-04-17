using System;
using System.IO;

namespace ns19
{
	// Token: 0x02000437 RID: 1079
	public sealed class Class1972 : IDisposable
	{
		// Token: 0x06001BA2 RID: 7074 RVA: 0x000B1AFC File Offset: 0x000AFCFC
		public Class1972(Class1971 class1971_1)
		{
			this.class1971_0 = class1971_1;
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x000B1B54 File Offset: 0x000AFD54
		public void method_0()
		{
			if (!this.bool_0)
			{
				if (World.Settings.method_52() > 0 && !File.Exists(this.string_0) && !string.IsNullOrEmpty(this.class1971_0.method_0()) && this.class1982_0 == null)
				{
					using (this.class1982_0 = new Class1982(this, this.class1971_0, this.int_1, this.int_2, this.int_3))
					{
						this.class1982_0.method_2(this.string_0);
						this.class1982_0.method_4();
					}
				}
				if (this.float_0 == null)
				{
					this.float_0 = new float[this.int_0, this.int_0];
				}
				if (File.Exists(this.string_0))
				{
					try
					{
						try
						{
							FileInfo fileInfo = new FileInfo(this.string_0);
							if (fileInfo.Length == 0L)
							{
								if (DateTime.Now.Subtract(fileInfo.LastWriteTime) < this.class1971_0.method_4())
								{
									this.bool_0 = true;
								}
								else
								{
									File.Delete(this.string_0);
								}
								return;
							}
						}
						catch
						{
						}
						using (Stream stream = File.OpenRead(this.string_0))
						{
							BinaryReader binaryReader = new BinaryReader(stream);
							if (this.class1971_0.method_5() == "Int16")
							{
								for (int i = 0; i < this.int_0; i++)
								{
									for (int j = 0; j < this.int_0; j++)
									{
										this.float_0[j, i] = (float)binaryReader.ReadInt16();
									}
								}
							}
							if (this.class1971_0.method_5() == "Float32")
							{
								for (int k = 0; k < this.int_0; k++)
								{
									for (int l = 0; l < this.int_0; l++)
									{
										this.float_0[l, k] = binaryReader.ReadSingle();
									}
								}
							}
							this.bool_0 = true;
							this.bool_1 = true;
						}
					}
					catch (IOException)
					{
						try
						{
							File.Delete(this.string_0);
						}
						catch (Exception innerException)
						{
							throw new ApplicationException(string.Format("Error while trying to delete corrupt terrain tile {0}", this.string_0), innerException);
						}
					}
					catch (Exception innerException2)
					{
						throw new ApplicationException(string.Format("Error while trying to read terrain tile {0}", this.string_0), innerException2);
					}
				}
			}
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x000B1E70 File Offset: 0x000B0070
		public float method_1(double double_5, double double_6)
		{
			float result;
			try
			{
				float num = (float)(this.double_2 - double_5);
				double num2 = double_6 - this.double_3;
				double num3 = (double)(this.int_0 - 1) / this.double_0;
				float num4 = (float)((double)num * num3);
				float num5 = (float)(num2 * num3);
				int num6 = (int)num4;
				int num7 = (int)Math.Ceiling((double)num4);
				int num8 = (int)num5;
				int num9 = (int)Math.Ceiling((double)num5);
				if (num6 >= this.int_0)
				{
					num6 = this.int_0 - 1;
				}
				if (num7 >= this.int_0)
				{
					num7 = this.int_0 - 1;
				}
				if (num8 >= this.int_0)
				{
					num8 = this.int_0 - 1;
				}
				if (num9 >= this.int_0)
				{
					num9 = this.int_0 - 1;
				}
				if (num6 < 0)
				{
					num6 = 0;
				}
				if (num7 < 0)
				{
					num7 = 0;
				}
				if (num8 < 0)
				{
					num8 = 0;
				}
				if (num9 < 0)
				{
					num9 = 0;
				}
				float num10 = num4 - (float)num6;
				float num11 = this.float_0[num8, num6] * (1f - num10) + this.float_0[num8, num7] * num10;
				float num12 = this.float_0[num9, num6] * (1f - num10) + this.float_0[num9, num7] * num10;
				num10 = num5 - (float)num8;
				result = num11 * (1f - num10) + num12 * num10;
				return result;
			}
			catch
			{
			}
			result = 0f;
			return result;
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x000115C8 File Offset: 0x0000F7C8
		public void Dispose()
		{
			if (this.class1982_0 != null)
			{
				this.class1982_0.Dispose();
				this.class1982_0 = null;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000BDA RID: 3034
		public string string_0;

		// Token: 0x04000BDB RID: 3035
		public double double_0;

		// Token: 0x04000BDC RID: 3036
		public int int_0;

		// Token: 0x04000BDD RID: 3037
		public double double_1;

		// Token: 0x04000BDE RID: 3038
		public double double_2 = 0.0;

		// Token: 0x04000BDF RID: 3039
		public double double_3 = 0.0;

		// Token: 0x04000BE0 RID: 3040
		public double double_4 = 0.0;

		// Token: 0x04000BE1 RID: 3041
		public int int_1;

		// Token: 0x04000BE2 RID: 3042
		public int int_2 = 0;

		// Token: 0x04000BE3 RID: 3043
		public int int_3 = 0;

		// Token: 0x04000BE4 RID: 3044
		public Class1971 class1971_0;

		// Token: 0x04000BE5 RID: 3045
		public bool bool_0;

		// Token: 0x04000BE6 RID: 3046
		public bool bool_1;

		// Token: 0x04000BE7 RID: 3047
		public float[,] float_0;

		// Token: 0x04000BE8 RID: 3048
		protected Class1982 class1982_0;
	}
}
