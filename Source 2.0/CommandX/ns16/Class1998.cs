using System;
using System.Collections;
using System.Drawing;
using System.Threading;
using Microsoft.DirectX.Direct3D;
using ns17;
using ns18;
using ns19;

namespace ns16
{
	// Token: 0x020004A4 RID: 1188
	public sealed class Class1998 : RenderableObject
	{
		// Token: 0x06001EF5 RID: 7925 RVA: 0x00012BBD File Offset: 0x00010DBD
		public void method_0(bool bool_12)
		{
			this.bool_9 = bool_12;
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x000CC2C0 File Offset: 0x000CA4C0
		public float method_1()
		{
			return this.float_2;
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00012BC6 File Offset: 0x00010DC6
		public bool method_2()
		{
			return this.bool_10;
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x00012BCE File Offset: 0x00010DCE
		public bool method_3()
		{
			return this.bool_3;
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x000CC2D8 File Offset: 0x000CA4D8
		public Class1998(string string_4, World class1995_1, double double_5, double double_6, double double_7, double double_8, double double_9, bool bool_12, Class1947[] class1947_1) : base(string_4, class1995_1)
		{
			float num = (float)(class1995_1.GetEquatorialRadius() + double_5);
			this.double_0 = double_6;
			this.double_1 = double_7;
			this.double_2 = double_8;
			this.double_3 = double_9;
			this.vmethod_16(MathEngine.SphericalToCartesian((double_6 + double_7) * 0.5, (double_8 + double_9) * 0.5, (double)num));
			this.double_4 = (double)num;
			this.float_1 = 3.5f;
			this.float_0 = 2.9f;
			this.class1947_0 = class1947_1;
			this.bool_7 = bool_12;
			if (bool_12)
			{
				this.m_renderPriority = RenderPriority.const_1;
			}
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x000CC450 File Offset: 0x000CA650
		public TimeSpan method_4()
		{
			return this.timeSpan_1;
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00012BD6 File Offset: 0x00010DD6
		public void method_5(TimeSpan timeSpan_2)
		{
			this.timeSpan_1 = timeSpan_2;
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00012BDF File Offset: 0x00010DDF
		public  void vmethod_18(string string_4)
		{
			this.string_2 = string_4;
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00012BE8 File Offset: 0x00010DE8
		public bool method_6()
		{
			return this.bool_4 | World.Settings.method_2();
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x00012BFB File Offset: 0x00010DFB
		public bool method_7()
		{
			return this.bool_11;
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00012C03 File Offset: 0x00010E03
		public   bool vmethod_19()
		{
			return this.int_2 != 0;
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x000CC468 File Offset: 0x000CA668
		public DateTime method_8()
		{
			return this.dateTime_1;
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00012C11 File Offset: 0x00010E11
		public bool method_9()
		{
			return this.bool_8;
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x000CC480 File Offset: 0x000CA680
		public double method_10()
		{
			return this.double_4;
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00012C19 File Offset: 0x00010E19
		public bool method_11()
		{
			return this.bool_5;
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00012C21 File Offset: 0x00010E21
		public void method_12(bool bool_12)
		{
			this.bool_5 = bool_12;
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x000CC498 File Offset: 0x000CA698
		public float method_13()
		{
			return this.float_0;
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00012C2A File Offset: 0x00010E2A
		public void method_14(float float_3)
		{
			this.float_0 = float_3;
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x000CC4B0 File Offset: 0x000CA6B0
		public float method_15()
		{
			return this.float_1;
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x00012C33 File Offset: 0x00010E33
		public void method_16(float float_3)
		{
			this.float_1 = float_3;
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x00012C3C File Offset: 0x00010E3C
		public void method_17(bool bool_12)
		{
			this.bool_6 = bool_12;
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x000CC4C8 File Offset: 0x000CA6C8
		public int method_18()
		{
			return this.int_0;
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00012C45 File Offset: 0x00010E45
		public void method_19(int int_3)
		{
			this.int_0 = int_3;
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x00012C4E File Offset: 0x00010E4E
		public bool method_20()
		{
			return this.bool_7;
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x000CC4E0 File Offset: 0x000CA6E0
		public Class1947[] method_21()
		{
			return this.class1947_0;
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x000CC4F8 File Offset: 0x000CA6F8
		public CameraBase method_22()
		{
			return this.class1987_0;
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00012C56 File Offset: 0x00010E56
		public void method_23(CameraBase class1987_1)
		{
			this.class1987_0 = class1987_1;
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x000CC510 File Offset: 0x000CA710
		public Effect method_24()
		{
			return this.effect_0;
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x000CC528 File Offset: 0x000CA728
		public override void Initialize(DrawArgs class1943_0)
		{
			this.method_23(DrawArgs.class1987_1);
			if (Class1998.texture_2 == null)
			{
				Class1998.texture_2 = Class1998.smethod_0(DrawArgs.device_1, World.Settings.DownloadQueuedColor, 0);
			}
			try
			{
				object syncRoot = this.hashtable_1.SyncRoot;
				lock (syncRoot)
				{
                    //using (IEnumerator enumerator = this.hashtable_1.Values.GetEnumerator())
                    IEnumerator enumerator = this.hashtable_1.Values.GetEnumerator();
					{
						while (enumerator.MoveNext())
						{
							((Class1992)enumerator.Current).vmethod_1();
						}
					}
				}
			}
			catch
			{
			}
			this.isInitialized = true;
			if (this.vmethod_10().ContainsKey("EffectPath"))
			{
				this.string_3 = (this.vmethod_10()["EffectPath"] as string);
			}
			else
			{
				this.string_3 = null;
			}
			this.effect_0 = null;
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x000081A2 File Offset: 0x000063A2
		public override bool PerformSelectionAction(DrawArgs class1943_0)
		{
			return false;
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x000CC64C File Offset: 0x000CA84C
		public override bool Update(DrawArgs class1943_0)
		{
			bool result = this.bool_9;
			this.bool_9 = false;
			if (this.thread_0 == null)
			{
				object obj = this.object_0;
				lock (obj)
				{
					if (this.thread_0 == null)
					{
						this.thread_0 = Class920.smethod_1(new ParameterizedThreadStart(this.method_25));
						this.thread_0.Start();
					}
				}
			}
			return result;
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x000CC6D8 File Offset: 0x000CA8D8
		private void method_25(object object_1)
		{
			bool flag = true;
			DrawArgs class1943_ = object_1 as DrawArgs;
			if (!this.isInitialized)
			{
				this.Initialize(class1943_);
			}
			if (this.string_3 != null && this.effect_0 == null)
			{
				string empty = string.Empty;
				this.effect_0 = Effect.FromFile(DrawArgs.device_1, this.string_3, null, "", ShaderFlags.None, Class1998.effectPool_0, out empty);
				if (empty != null && empty != string.Empty)
				{
					Log.smethod_2(Log.Levels.int_1, "Could not load effect " + this.string_3 + ": " + empty);
					Log.smethod_2(Log.Levels.int_1, "Effect has been disabled.");
					this.string_3 = null;
					this.effect_0 = null;
				}
			}
			if (this.method_21()[0].method_0() < 180.0)
			{
				double degrees = DrawArgs.class1987_1.GetViewRange().GetDegrees();
				double num = DrawArgs.class1987_1.GetLatitude().GetDegrees() + degrees;
				double num2 = DrawArgs.class1987_1.GetLatitude().GetDegrees() - degrees;
				double num3 = DrawArgs.class1987_1.GetLongitude().GetDegrees() + degrees;
				double num4 = DrawArgs.class1987_1.GetLongitude().GetDegrees() - degrees;
				if (num < this.double_1 || num2 > this.double_0 || num3 < this.double_2 || num4 > this.double_3)
				{
					flag = false;
				}
				if (flag)
				{
					if (!this.bool_5 && Angle.IsLargerThan(Angle.Multiply(DrawArgs.class1987_1.GetViewRange(), 0.5), Angle.FromDegrees((double)this.method_15() * this.method_21()[0].method_0())))
					{
						object syncRoot = this.hashtable_1.SyncRoot;
						lock (syncRoot)
						{
                            IEnumerator enumerator = this.hashtable_1.Values.GetEnumerator();
							{
								while (enumerator.MoveNext())
								{
									((Class1992)enumerator.Current).Dispose();
								}
							}
							this.hashtable_1.Clear();
							this.method_27();
						}
						flag = false;
					}
					if (flag)
					{
						this.method_26(DrawArgs.class1987_1);
						try
						{
							int rowFromLatitude = MathEngine.GetRowFromLatitude(DrawArgs.class1987_1.GetLatitude(), this.method_21()[0].method_0());
							int colFromLongitude = MathEngine.GetColFromLongitude(DrawArgs.class1987_1.GetLongitude(), this.method_21()[0].method_0());
							double num5 = -90.0 + (double)rowFromLatitude * this.method_21()[0].method_0();
							double num6 = -90.0 + (double)rowFromLatitude * this.method_21()[0].method_0() + this.method_21()[0].method_0();
							double num7 = -180.0 + (double)colFromLongitude * this.method_21()[0].method_0();
							double num8 = -180.0 + (double)colFromLongitude * this.method_21()[0].method_0() + this.method_21()[0].method_0();
							double num9 = 0.5 * (num6 + num5);
							double num10 = 0.5 * (num7 + num8);
							int num11 = 4;
							for (int i = 0; i < num11; i++)
							{
								for (double num12 = num9 - (double)i * this.method_21()[0].method_0(); num12 < num9 + (double)i * this.method_21()[0].method_0(); num12 += this.method_21()[0].method_0())
								{
									for (double num13 = num10 - (double)i * this.method_21()[0].method_0(); num13 < num10 + (double)i * this.method_21()[0].method_0(); num13 += this.method_21()[0].method_0())
									{
										int rowFromLatitude2 = MathEngine.GetRowFromLatitude(Angle.FromDegrees(num12), this.method_21()[0].method_0());
										int colFromLongitude2 = MathEngine.GetColFromLongitude(Angle.FromDegrees(num13), this.method_21()[0].method_0());
										long num14 = ((long)rowFromLatitude2 << 32) + (long)colFromLongitude2;
										Class1992 @class = (Class1992)this.hashtable_1[num14];
										if (@class != null)
										{
											@class.vmethod_2(class1943_);
										}
										else
										{
											double num15 = -180.0 + (double)colFromLongitude2 * this.method_21()[0].method_0();
											if (num15 <= this.double_3)
											{
												double num16 = num15 + this.method_21()[0].method_0();
												if (num16 >= this.double_2)
												{
													double num17 = -90.0 + (double)rowFromLatitude2 * this.method_21()[0].method_0();
													if (num17 <= this.double_0)
													{
														double num18 = num17 + this.method_21()[0].method_0();
														if (num18 >= this.double_1)
														{
															@class = new Class1992(num17, num18, num15, num16, 0, this);
															if (DrawArgs.class1987_1.GetViewFrustum().Contains(@class.class1941_0))
															{
																object syncRoot = this.hashtable_1.SyncRoot;
																lock (syncRoot)
																{
																	this.hashtable_1.Add(num14, @class);
																}
																@class.vmethod_2(class1943_);
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
						catch (ThreadAbortException)
						{
						}
						catch (Exception exception_)
						{
							Log.smethod_3(exception_);
						}
					}
				}
			}
			this.thread_0 = null;
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x000CCCF4 File Offset: 0x000CAEF4
		protected void method_26(CameraBase class1987_1)
		{
			ArrayList arrayList = new ArrayList();
			object syncRoot = this.hashtable_1.SyncRoot;
			lock (syncRoot)
			{
				foreach (long num in this.hashtable_1.Keys)
				{
					Class1992 @class = (Class1992)this.hashtable_1[num];
					if (!class1987_1.GetViewFrustum().Contains(@class.class1941_0))
					{
						arrayList.Add(num);
					}
				}
				foreach (long num2 in arrayList)
				{
					Class1992 class2 = (Class1992)this.hashtable_1[num2];
					if (class2 != null)
					{
						this.hashtable_1.Remove(num2);
						class2.Dispose();
					}
				}
			}
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x000CCE70 File Offset: 0x000CB070
		public override void Render(DrawArgs class1943_0)
		{
			try
			{
				object syncRoot = this.hashtable_1.SyncRoot;
				lock (syncRoot)
				{
					if (this.hashtable_1.Count > 0)
					{
						Device device_ = DrawArgs.device_1;
						device_.Clear(ClearFlags.ZBuffer, 0, 1f, 0);
						device_.RenderState.ZBufferEnable = true;
						Class1998.long_0 = DrawArgs.long_0;
						device_.RenderState.Lighting = false;
						if (!World.Settings.IsEnableSunShading())
						{
							device_.VertexFormat = (VertexFormats.PositionNormal | VertexFormats.Texture1);
							device_.SetTextureStageState(0, TextureStageStates.ColorOperation, 2);
							device_.SetTextureStageState(0, TextureStageStates.ColorArgument1, 2);
							device_.SetTextureStageState(0, TextureStageStates.AlphaArgument1, 2);
							device_.SetTextureStageState(0, TextureStageStates.AlphaOperation, 2);
							device_.SetTextureStageState(1, TextureStageStates.ColorArgument2, 1);
							device_.SetTextureStageState(1, TextureStageStates.ColorArgument1, 2);
							device_.SetTextureStageState(1, TextureStageStates.TextureCoordinateIndex, 0);
						}
						device_.VertexFormat = (VertexFormats.PositionNormal | VertexFormats.Texture1);
                        IEnumerator enumerator = this.hashtable_1.Values.GetEnumerator();
						{
							while (enumerator.MoveNext())
							{
								((Class1992)enumerator.Current).vmethod_6(class1943_0);
							}
						}
						device_.SetTextureStageState(1, TextureStageStates.TextureCoordinateIndex, 1);
						if (this.m_renderPriority < RenderPriority.const_1)
						{
							device_.RenderState.ZBufferEnable = true;
						}
					}
				}
			}
			catch
			{
			}
			finally
			{
				if (this.method_9() && DateTime.Now.Subtract(TimeSpan.FromSeconds(15.0)) < this.method_8())
				{
					string str = "Problem connecting to server... Trying again in 2 minutes.\n";
					class1943_0.string_0 += str;
				}
			}
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x000CD080 File Offset: 0x000CB280
		public override void Dispose()
		{
			try
			{
				this.isInitialized = false;
				this.readerWriterLock_0.AcquireWriterLock(-1);
				for (int i = 0; i < 10; i++)
				{
					if (this.class2003_0[i] != null)
					{
						this.class2003_0[i].vmethod_1();
						this.class2003_0[i].Dispose();
						this.class2003_0[i] = null;
					}
				}
				 IEnumerator enumerator = this.hashtable_1.Values.GetEnumerator();
				{
					while (enumerator.MoveNext())
					{
						((Class1992)enumerator.Current).Dispose();
					}
				}
				if (this.texture_0 != null)
				{
					this.texture_0.Dispose();
					this.texture_0 = null;
				}
				if (this.sprite_0 != null)
				{
					this.sprite_0.Dispose();
					this.sprite_0 = null;
				}
			}
			finally
			{
				if (this.readerWriterLock_0.IsWriterLockHeld)
				{
					this.readerWriterLock_0.ReleaseWriterLock();
				}
			}
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x000CD1A4 File Offset: 0x000CB3A4
		public void method_27()
		{
			try
			{
				this.readerWriterLock_0.AcquireWriterLock(-1);
				this.hashtable_2.Clear();
			}
			finally
			{
				if (this.readerWriterLock_0.IsWriterLockHeld)
				{
					this.readerWriterLock_0.ReleaseWriterLock();
				}
			}
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x000CD1F8 File Offset: 0x000CB3F8
		public  void vmethod_20(CameraBase class1987_1, Class2003 class2003_1)
		{
			Class1992 @class = class2003_1.method_3();
			@class.bool_3 = true;
			try
			{
				this.readerWriterLock_0.AcquireReaderLock(-1);
				if (this.hashtable_2.Contains(@class.method_0()))
				{
					return;
				}
				LockCookie lockCookie = this.readerWriterLock_0.UpgradeToWriterLock(-1);
				this.hashtable_2.Add(@class.method_0(), class2003_1);
				this.readerWriterLock_0.DowngradeFromWriterLock(ref lockCookie);
				if (this.hashtable_2.Count >= 200)
				{
					Class2003 class2 = null;
					Angle angle = Angle.Zero;
					Angle b = Angle.Zero;
					foreach (Class2003 class3 in this.hashtable_2.Values)
					{
						angle = MathEngine.SphericalDistance(class3.method_3().struct63_0, class3.method_3().struct63_1, class1987_1.GetLatitude(), class1987_1.GetLongitude());
						if (Angle.IsLargerThan(angle, b))
						{
							class2 = class3;
							b = angle;
						}
					}
					lockCookie = this.readerWriterLock_0.UpgradeToWriterLock(-1);
					class2.Dispose();
					class2.method_3().class2003_0 = null;
					this.hashtable_2.Remove(class2.method_3().method_0());
					this.readerWriterLock_0.DowngradeFromWriterLock(ref lockCookie);
				}
			}
			finally
			{
				if (this.readerWriterLock_0.IsWriterLockHeld)
				{
					this.readerWriterLock_0.ReleaseWriterLock();
				}
				if (this.readerWriterLock_0.IsReaderLockHeld)
				{
					this.readerWriterLock_0.ReleaseReaderLock();
				}
			}
			this.vmethod_22();
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x000CD3C4 File Offset: 0x000CB5C4
		public  void vmethod_21(Class2003 class2003_1)
		{
			try
			{
				this.readerWriterLock_0.AcquireWriterLock(-1);
				Class1992 @class = class2003_1.method_3();
				Class2003 class2 = (Class2003)this.hashtable_2[@class.method_0()];
				if (class2 != null)
				{
					this.hashtable_2.Remove(@class.method_0());
					class2.method_3().class2003_0 = null;
				}
			}
			finally
			{
				if (this.readerWriterLock_0.IsWriterLockHeld)
				{
					this.readerWriterLock_0.ReleaseWriterLock();
				}
			}
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x000CD450 File Offset: 0x000CB650
		public  void vmethod_22()
		{
			Log.Write(Log.Levels.int_3, "QTS", "ServiceDownloadQueue: " + this.hashtable_2.Count + " requests waiting");
			try
			{
				this.readerWriterLock_0.AcquireWriterLock(-1);
				for (int i = 0; i < 10; i++)
				{
					if (this.class2003_0[i] != null && this.class2003_0[i].method_2())
					{
						this.class2003_0[i].vmethod_1();
						this.class2003_0[i].Dispose();
						this.class2003_0[i] = null;
					}
				}
				this.readerWriterLock_0.ReleaseWriterLock();
				this.readerWriterLock_0.AcquireReaderLock(-1);
				if (this.method_18() < 5 && !this.bool_8)
				{
					for (int j = 0; j < 10; j++)
					{
						if (this.class2003_0[j] == null && this.hashtable_2.Count > 0)
						{
							LockCookie lockCookie = this.readerWriterLock_0.UpgradeToWriterLock(-1);
							this.class2003_0[j] = this.vmethod_23();
							if (this.class2003_0[j] != null)
							{
								this.dateTime_0[j] = DateTime.Now;
								this.class2003_0[j].vmethod_0();
							}
							this.readerWriterLock_0.DowngradeFromWriterLock(ref lockCookie);
						}
					}
				}
				else
				{
					if (!this.bool_8)
					{
						this.dateTime_1 = DateTime.Now;
						this.bool_8 = true;
					}
					if (DateTime.Now.Subtract(this.timeSpan_0) > this.dateTime_1)
					{
						this.method_19(0);
						this.bool_8 = false;
					}
				}
			}
			finally
			{
				if (this.readerWriterLock_0.IsReaderLockHeld)
				{
					this.readerWriterLock_0.ReleaseReaderLock();
				}
				if (this.readerWriterLock_0.IsWriterLockHeld)
				{
					this.readerWriterLock_0.ReleaseWriterLock();
				}
			}
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x000CD644 File Offset: 0x000CB844
		public  Class2003 vmethod_23()
		{
			Class2003 result = null;
			float num = -3.40282347E+38f;
			try
			{
				this.readerWriterLock_0.AcquireReaderLock(-1);
				foreach (Class2003 @class in this.hashtable_2.Values)
				{
					if (!@class.method_1())
					{
						Class1992 class2 = @class.method_3();
						if (this.class1987_0.GetViewFrustum().Contains(class2.class1941_0))
						{
							float num2 = class2.class1941_0.method_0(this.class1987_0);
							if (num2 > num)
							{
								num = num2;
								result = @class;
							}
						}
					}
				}
			}
			finally
			{
				if (this.readerWriterLock_0.IsReaderLockHeld)
				{
					this.readerWriterLock_0.ReleaseReaderLock();
				}
			}
			return result;
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x000CD734 File Offset: 0x000CB934
		protected static Texture smethod_0(Device device_0, Color color_0, int int_3)
		{
			int num = 128;
			Texture result;
			using (Bitmap bitmap = new Bitmap(256, 256))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					using (Pen pen = new Pen(color_0))
					{
						int num2 = num - 1 - 2 * int_3;
						graphics.DrawRectangle(pen, int_3, int_3, num2, num2);
						graphics.DrawRectangle(pen, num + int_3, int_3, num2, num2);
						graphics.DrawRectangle(pen, int_3, num + int_3, num2, num2);
						graphics.DrawRectangle(pen, num + int_3, num + int_3, num2, num2);
						result = new Texture(device_0, bitmap, Usage.None, Pool.Managed);
					}
				}
			}
			return result;
		}

		// Token: 0x04000E3D RID: 3645
		private bool bool_3 = true;

		// Token: 0x04000E3E RID: 3646
		protected string string_2 = "";

		// Token: 0x04000E3F RID: 3647
		protected Hashtable hashtable_1 = new Hashtable();

		// Token: 0x04000E40 RID: 3648
		protected double double_0;

		// Token: 0x04000E41 RID: 3649
		protected double double_1;

		// Token: 0x04000E42 RID: 3650
		protected double double_2 = 0.0;

		// Token: 0x04000E43 RID: 3651
		protected double double_3 = 0.0;

		// Token: 0x04000E44 RID: 3652
		private bool bool_4;

		// Token: 0x04000E45 RID: 3653
		protected Texture texture_0;

		// Token: 0x04000E46 RID: 3654
		protected Sprite sprite_0;

		// Token: 0x04000E47 RID: 3655
		protected Blend blend_0 = Blend.BlendFactor;

		// Token: 0x04000E48 RID: 3656
		protected Blend blend_1 = Blend.InvBlendFactor;

		// Token: 0x04000E49 RID: 3657
		protected static long long_0;

		// Token: 0x04000E4A RID: 3658
		protected double double_4 = 0.0;

		// Token: 0x04000E4B RID: 3659
		protected bool bool_5;

		// Token: 0x04000E4C RID: 3660
		protected float float_0;

		// Token: 0x04000E4D RID: 3661
		protected float float_1;

		// Token: 0x04000E4E RID: 3662
		protected bool bool_6;

		// Token: 0x04000E4F RID: 3663
		protected int int_0;

		// Token: 0x04000E50 RID: 3664
		protected Hashtable hashtable_2 = new Hashtable();

		// Token: 0x04000E51 RID: 3665
		protected ReaderWriterLock readerWriterLock_0 = new ReaderWriterLock();

		// Token: 0x04000E52 RID: 3666
		protected bool bool_7;

		// Token: 0x04000E53 RID: 3667
		protected Class1947[] class1947_0;

		// Token: 0x04000E54 RID: 3668
		protected CameraBase class1987_0;

		// Token: 0x04000E55 RID: 3669
		protected Class2003[] class2003_0 = new Class2003[10];

		// Token: 0x04000E56 RID: 3670
		protected DateTime[] dateTime_0 = new DateTime[10];

		// Token: 0x04000E57 RID: 3671
		protected TimeSpan timeSpan_0 = TimeSpan.FromMinutes(2.0);

		// Token: 0x04000E58 RID: 3672
		protected DateTime dateTime_1;

		// Token: 0x04000E59 RID: 3673
		protected bool bool_8;

		// Token: 0x04000E5A RID: 3674
		protected Effect effect_0;

		// Token: 0x04000E5B RID: 3675
		protected string string_3 = "";

		// Token: 0x04000E5C RID: 3676
		protected static EffectPool effectPool_0 = new EffectPool();

		// Token: 0x04000E5D RID: 3677
		protected object object_0 = new object();

		// Token: 0x04000E5E RID: 3678
		private bool bool_9;

		// Token: 0x04000E5F RID: 3679
		protected TimeSpan timeSpan_1 = TimeSpan.MaxValue;

		// Token: 0x04000E60 RID: 3680
		public static Texture texture_1;

		// Token: 0x04000E61 RID: 3681
		public static Texture texture_2;

		// Token: 0x04000E62 RID: 3682
		public static Texture texture_3;

		// Token: 0x04000E63 RID: 3683
		public int int_1;

		// Token: 0x04000E64 RID: 3684
		public int int_2 = 0;

		// Token: 0x04000E65 RID: 3685
		private bool bool_10;

		// Token: 0x04000E66 RID: 3686
		private float float_2 = 0f;

		// Token: 0x04000E67 RID: 3687
		private bool bool_11;

		// Token: 0x04000E68 RID: 3688
		private Thread thread_0;
	}
}
