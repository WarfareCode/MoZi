using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns4
{
	// Token: 0x02000CAD RID: 3245
	public sealed class Class372
	{
		// Token: 0x02000CAE RID: 3246
		public sealed class Class373
		{
			// Token: 0x06006B2E RID: 27438 RVA: 0x003A5244 File Offset: 0x003A3444
			public Class373()
			{
				this.int_2 = -1;
				this.byte_0 = new byte[255];
				this.byte_1 = new byte[255];
				this.object_0 = RuntimeHelpers.GetObjectValue(new object());
			}

			// Token: 0x06006B2F RID: 27439 RVA: 0x003A52CC File Offset: 0x003A34CC
			public Tuple<int, int> method_0(double double_5, double double_6)
			{
				Tuple<int, int> result;
				try
				{
					int num = (int)Math.Round((double_5 - this.double_2) / this.double_0);
					int num2 = (int)Math.Round((double)this.int_1 - (double_6 - this.double_3) / this.double_1 - 1.0);
					if (num2 == -1)
					{
						num2 = 0;
					}
					bool arg_4F_0 = Debugger.IsAttached;
					if (num2 >= this.int_1)
					{
						num2 = this.int_1;
					}
					if (num2 == -1)
					{
						num2 = 0;
					}
					if (num >= this.int_0)
					{
						num = this.int_0;
					}
					if (num == -1)
					{
						num = 0;
					}
					result = new Tuple<int, int>(num2, num);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200300", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new Tuple<int, int>(0, 0);
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x06006B30 RID: 27440 RVA: 0x003A53CC File Offset: 0x003A35CC
			public void method_1()
			{
				try
				{
					if (!Information.IsNothing(this.binaryReader_0))
					{
						this.binaryReader_0.Close();
						this.binaryReader_0 = null;
					}
					if (!Information.IsNothing(this.fileStream_0))
					{
						this.fileStream_0 = null;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}

			// Token: 0x06006B31 RID: 27441 RVA: 0x003A5430 File Offset: 0x003A3630
			public short method_2(double double_5, double double_6, bool bool_1)
			{
				short num = 0;
				short result;
				try
				{
					this.bool_0 = true;
					if (this.fileStream_0 == null || double.IsNaN(this.double_2) || double.IsNaN(this.double_3) || this.double_2 == 0.0 || this.double_3 == 0.0 || this.double_2 < -180.0 || this.double_2 > 180.0 || this.double_3 < -90.0 || this.double_3 > 90.0 || (this.double_2 < 1.0 && this.double_2 > -1.0) || (this.double_3 < 1.0 && this.double_3 > -1.0) || double.IsNaN(this.double_2) || double.IsNaN(this.double_3))
					{
						object obj = this.object_0;
						ObjectFlowControl.CheckForSyncLockOnValueType(obj);
						lock (obj)
						{
							this.method_4(MyTemplate.GetApp().Info.DirectoryPath + "\\GIS\\Terrain\\SRTM30Plus\\" + this.string_0);
						}
					}
					if (Information.IsNothing(this.class374_0))
					{
						this.class374_0 = new Class372.Class373.Class374();
						this.class374_0.method_0((short)this.int_1, (short)this.int_0);
					}
					double_5 = Math2.NormalizeLongitude(double_5);
					double_6 = Math2.NormalizeLatitude(double_6);
					int num2 = 0;
					int num3 = 0;
					try
					{
						Tuple<int, int> tuple = this.method_0(double_5, double_6);
						num2 = tuple.Item1;
						num3 = tuple.Item2;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200030", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						num = 0;
						ProjectData.ClearProjectError();
						result = 0;
						return result;
					}
					if (num2 > this.int_1 - 1)
					{
						bool arg_220_0 = Debugger.IsAttached;
						num2 = this.int_1 - 1;
					}
					if (num3 > this.int_0 - 1)
					{
						bool arg_241_0 = Debugger.IsAttached;
						num3 = this.int_0 - 1;
					}
					short? num4 = this.class374_0.method_1((short)num2, (short)num3);
					bool? flag2;
					if (!Information.IsNothing(num4))
					{
						int? num5 = num4.HasValue ? new int?((int)num4.GetValueOrDefault()) : null;
						flag2 = (num5.HasValue ? new bool?(num5.GetValueOrDefault() == 0) : null);
					}
					else
					{
						flag2 = new bool?(true);
					}
					bool? flag3 = flag2;
					if (flag3.GetValueOrDefault())
					{
						int num6 = 0;
						this.method_3(num2, num3, ref num6);
						num4 = new short?((short)num6);
						if (!(num2 < 0 | num3 < 0))
						{
							this.class374_0.method_2((short)num2, (short)num3, num4.Value);
						}
					}
					short value = num4.Value;
					Terrain.smethod_2(ref value);
					this.bool_0 = false;
					num = num4.Value;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 101294", "");
					GameGeneral.LogException(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					num = 0;
					ProjectData.ClearProjectError();
				}
				result = num;
				return result;
			}

			// Token: 0x06006B32 RID: 27442 RVA: 0x003A5800 File Offset: 0x003A3A00
			public void method_3(int int_4, int int_5, ref int int_6)
			{
				try
				{
					object obj = this.object_0;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (this.fileStream_0 == null)
						{
							this.method_4(MyTemplate.GetApp().Info.DirectoryPath + "\\GIS\\Terrain\\SRTM30Plus\\" + this.string_0);
						}
						try
						{
							if (this.int_2 != 1)
							{
								throw new Exception("invalid data type");
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200244", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw;
						}
						this.fileStream_0.Seek(558L, SeekOrigin.Begin);
						this.fileStream_0.Seek((long)(int_4 * this.int_0 * 4), SeekOrigin.Current);
						this.fileStream_0.Seek((long)(int_5 * 4), SeekOrigin.Current);
						int_6 = this.binaryReader_0.ReadInt32();
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 200245", ex4.Message);
					GameGeneral.LogException(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					int_6 = 0;
					ProjectData.ClearProjectError();
				}
			}

			// Token: 0x06006B33 RID: 27443 RVA: 0x003A5978 File Offset: 0x003A3B78
			public bool method_4(string string_1)
			{
				this.fileStream_0 = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read, 65536, FileOptions.RandomAccess);
				this.binaryReader_0 = new BinaryReader(this.fileStream_0, new ASCIIEncoding());
				bool result;
				try
				{
					int num = this.binaryReader_0.ReadInt32();
					int num2 = this.binaryReader_0.ReadInt32();
					this.double_0 = this.binaryReader_0.ReadDouble();
					this.double_1 = this.binaryReader_0.ReadDouble();
					this.double_2 = this.binaryReader_0.ReadDouble();
					this.double_3 = this.binaryReader_0.ReadDouble();
					int num3 = this.binaryReader_0.ReadInt32();
					this.int_2 = num3;
					switch (this.int_2)
					{
					case 0:
						break;
					case 1:
						if (num != this.int_0 || num2 != this.int_1)
						{
							this.int_0 = num;
							this.int_1 = num2;
						}
						this.int_3 = this.binaryReader_0.ReadInt32();
						this.byte_0 = this.binaryReader_0.ReadBytes(255);
						this.byte_1 = this.binaryReader_0.ReadBytes(255);
						goto IL_2E9;
					case 2:
						if (num != this.int_0 || num2 != this.int_1)
						{
							this.int_0 = num;
							this.int_1 = num2;
						}
						this.float_0 = this.binaryReader_0.ReadSingle();
						this.byte_0 = this.binaryReader_0.ReadBytes(255);
						this.byte_1 = this.binaryReader_0.ReadBytes(255);
						goto IL_2E9;
					case 3:
						if (num != this.int_0 || num2 != this.int_1)
						{
							this.int_0 = num;
							this.int_1 = num2;
						}
						this.double_4 = this.binaryReader_0.ReadDouble();
						this.byte_0 = this.binaryReader_0.ReadBytes(255);
						this.byte_1 = this.binaryReader_0.ReadBytes(255);
						goto IL_2E9;
					case 4:
						try
						{
							throw new Exception("unknown datatype");
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200248", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw;
						}
						goto IL_2E9;
					default:
						try
						{
							throw new Exception("invalid datatype");
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							ex4.Data.Add("Error at 200249", ex4.Message);
							GameGeneral.LogException(ref ex4);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw;
						}
						break;
					}
					if (num != this.int_0 || num2 != this.int_1)
					{
						this.int_0 = num;
						this.int_1 = num2;
					}
					this.short_0 = this.binaryReader_0.ReadInt16();
					this.byte_0 = this.binaryReader_0.ReadBytes(255);
					this.byte_1 = this.binaryReader_0.ReadBytes(255);
					IL_2E9:;
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ex6.Data.Add("Error at 200250", ex6.Message);
					GameGeneral.LogException(ref ex6);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
					result = false;
					return result;
				}
				result = true;
				return result;
			}

			// Token: 0x04003CFD RID: 15613
			public double double_0;

			// Token: 0x04003CFE RID: 15614
			public double double_1;

			// Token: 0x04003CFF RID: 15615
			public double double_2 = 0.0;

			// Token: 0x04003D00 RID: 15616
			public double double_3 = 0.0;

			// Token: 0x04003D01 RID: 15617
			public int int_0;

			// Token: 0x04003D02 RID: 15618
			public int int_1;

			// Token: 0x04003D03 RID: 15619
			public int int_2 = 0;

			// Token: 0x04003D04 RID: 15620
			public int int_3 = 0;

			// Token: 0x04003D05 RID: 15621
			public short short_0;

			// Token: 0x04003D06 RID: 15622
			public double double_4 = 0.0;

			// Token: 0x04003D07 RID: 15623
			public float float_0;

			// Token: 0x04003D08 RID: 15624
			public byte[] byte_0;

			// Token: 0x04003D09 RID: 15625
			public byte[] byte_1;

			// Token: 0x04003D0A RID: 15626
			public string string_0;

			// Token: 0x04003D0B RID: 15627
			internal Class372.Class373.Class374 class374_0;

			// Token: 0x04003D0C RID: 15628
			private object object_0;

			// Token: 0x04003D0D RID: 15629
			public bool bool_0;

			// Token: 0x04003D0E RID: 15630
			protected FileStream fileStream_0;

			// Token: 0x04003D0F RID: 15631
			protected BinaryReader binaryReader_0;

			// Token: 0x02000CAF RID: 3247
			public sealed class Class374
			{
				// Token: 0x06006B34 RID: 27444 RVA: 0x0002DF80 File Offset: 0x0002C180
				public Class374()
				{
					this.int_1 = 1000000;
				}

				// Token: 0x06006B35 RID: 27445 RVA: 0x0002DF93 File Offset: 0x0002C193
				public void method_0(short short_3, short short_4)
				{
					this.short_1 = short_3;
					this.short_2 = short_4;
					this.short_0 = new short[(int)(this.short_1 + 1)][];
				}

				// Token: 0x06006B36 RID: 27446 RVA: 0x003A5D08 File Offset: 0x003A3F08
				public short? method_1(short short_3, short short_4)
				{
					short? result;
					try
					{
						if (short_3 >= 0 && short_4 >= 0)
						{
							if (Information.IsNothing(this.short_0[(int)short_3]))
							{
								result = null;
							}
							else
							{
								short[] array = this.short_0[(int)short_3];
								if (!Information.IsNothing(array))
								{
									result = new short?(array[(int)short_4]);
								}
								else
								{
									result = null;
								}
							}
						}
						else
						{
							result = null;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200494", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						result = null;
						ProjectData.ClearProjectError();
					}
					return result;
				}

				// Token: 0x06006B37 RID: 27447 RVA: 0x003A5DC8 File Offset: 0x003A3FC8
				public void method_2(short short_3, short short_4, short short_5)
				{
					if (this.int_0 >= this.int_1)
					{
						this.short_0 = new short[(int)(this.short_1 + 1)][];
					}
					try
					{
						if (Information.IsNothing(this.short_0[(int)short_3]))
						{
							short[] array = new short[(int)(this.short_2 + 1)];
							array[(int)short_4] = short_5;
							this.short_0[(int)short_3] = array;
							this.int_0++;
						}
						else
						{
							short[] array2 = this.short_0[(int)short_3];
							if (Information.IsNothing(array2[(int)short_4]))
							{
								array2[(int)short_4] = short_5;
								this.int_0++;
							}
							array2[(int)short_4] = short_5;
						}
					}
					catch (OutOfMemoryException projectError)
					{
						ProjectData.SetProjectError(projectError);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						GameGeneral.ForceGarbageCollection();
						ProjectData.ClearProjectError();
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200496", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}

				// Token: 0x04003D10 RID: 15632
				private int int_0;

				// Token: 0x04003D11 RID: 15633
				private int int_1;

				// Token: 0x04003D12 RID: 15634
				private short[][] short_0;

				// Token: 0x04003D13 RID: 15635
				private short short_1;

				// Token: 0x04003D14 RID: 15636
				private short short_2;
			}
		}
	}
}
