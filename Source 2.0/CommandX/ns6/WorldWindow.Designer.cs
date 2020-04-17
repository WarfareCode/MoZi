using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Security.Permissions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using ns16;
using ns17;
using ns18;
using ns19;

namespace ns6
{
	// Token: 0x02000C8A RID: 3210
	public sealed class WorldWindow : Control
	{
		// Token: 0x06006A6F RID: 27247 RVA: 0x0002DD53 File Offset: 0x0002BF53
		public void method_0(bool bool_8)
		{
			this.bool_5 = bool_8;
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x003918DC File Offset: 0x0038FADC
		public Device method_1()
		{
			return this.m_Device3d;
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x003918F4 File Offset: 0x0038FAF4
		public WorldWindow()
		{
			base.SetStyle(ControlStyles.Opaque | ControlStyles.AllPaintingInWmPaint, true);
			base.Size = new Size(1, 1);
			try
			{
				if (!WorldWindow.smethod_0())
				{
					this.method_20();
				}
				this.drawArgs = new DrawArgs(this.m_Device3d, this);
				this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
				this.timer_0.Start();
				TimeKeeper.smethod_4();
				base.MouseEnter += new EventHandler(this.Control0_MouseEnter);
				base.MouseLeave += new EventHandler(this.Control0_MouseLeave);
				base.MouseMove += new MouseEventHandler(this.Control0_MouseMove);
				this.timer_1 = new System.Timers.Timer();
				this.timer_1.Interval = 2500.0;
			}
			catch (InvalidCallException inner)
			{
				throw new InvalidCallException("Unable to locate a compatible graphics adapter. Make sure you are running the latest version of DirectX.", inner);
			}
			catch (NotAvailableException inner2)
			{
				throw new NotAvailableException("Unable to locate a compatible graphics adapter. Make sure you are running the latest version of DirectX.", inner2);
			}
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x0002DD5C File Offset: 0x0002BF5C
		private void Control0_MouseMove(object sender, MouseEventArgs e)
		{
			this.timer_1.Start();
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x0002DD69 File Offset: 0x0002BF69
		private void Control0_MouseLeave(object sender, EventArgs e)
		{
			this.timer_1.Stop();
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x0002DD5C File Offset: 0x0002BF5C
		private void Control0_MouseEnter(object sender, EventArgs e)
		{
			this.timer_1.Start();
		}

		// Token: 0x06006A75 RID: 27253 RVA: 0x00391A64 File Offset: 0x0038FC64
		public World method_2()
		{
			return this.m_World;
		}

		// Token: 0x06006A76 RID: 27254 RVA: 0x00391A7C File Offset: 0x0038FC7C
		public void method_3(World class1995_1)
		{
			this.m_World = class1995_1;
			if (this.m_World != null)
			{
				Class1989 @class = new Class1989(this.m_World.vmethod_15(), this.m_World.GetEquatorialRadius());
				if (!World.Settings.method_20())
				{
					@class.SetPosition(World.Settings.method_21().GetDegrees(), World.Settings.method_22().GetDegrees(), World.Settings.method_24().GetDegrees(), World.Settings.method_23(), World.Settings.method_25().GetDegrees(), 0.0);
				}
				this.drawArgs.method_2(@class);
				this.drawArgs.method_4(class1995_1);
				this.m_World.GetRenderableObjectList().Add(new LatLongGrid(this.m_World));
			}
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x0002DD76 File Offset: 0x0002BF76
		public void method_4(string string_2)
		{
			this._caption = string_2;
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x00391B5C File Offset: 0x0038FD5C
		public DrawArgs GetDrawArgs()
		{
			return this.drawArgs;
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x00391B74 File Offset: 0x0038FD74
		public Cache GetCache()
		{
			return this.m_Cache;
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x0002DD7F File Offset: 0x0002BF7F
		public void SetCache(Cache cache_)
		{
			this.m_Cache = cache_;
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x0002DD88 File Offset: 0x0002BF88
		public bool method_8()
		{
			return this.bool_2;
		}

		// Token: 0x06006A7C RID: 27260 RVA: 0x0002DD90 File Offset: 0x0002BF90
		public void method_9(bool bool_8)
		{
			this.bool_2 = bool_8;
		}

		// Token: 0x06006A7D RID: 27261 RVA: 0x00391B8C File Offset: 0x0038FD8C
		public void method_10(double double_0, double double_1)
		{
			this.drawArgs.GetWorldCamera().SetPosition(double_0, double_1, this.drawArgs.GetWorldCamera().GetHeading().GetDegrees(), this.drawArgs.GetWorldCamera().GetAltitude(), this.drawArgs.GetWorldCamera().GetTilt().GetDegrees());
		}

		// Token: 0x06006A7E RID: 27262 RVA: 0x00391BEC File Offset: 0x0038FDEC
		protected override void OnPaint(PaintEventArgs e)
		{
			bool flag = false;
			try
			{
				if (this.m_Device3d == null)
				{
					e.Graphics.Clear(SystemColors.Control);
					return;
				}
				this.drawArgs.method_12(true);
				this.method_11();
				this.m_Device3d.Present();
			}
			catch (DriverInternalErrorException)
			{
				flag = true;
			}
			catch (DeviceLostException)
			{
				flag = true;
			}
			catch (InvalidCallException)
			{
				flag = true;
			}
			if (flag)
			{
				try
				{
					this.method_16();
					this.method_11();
					this.m_Device3d.Present();
				}
				catch (DirectXException)
				{
				}
			}
		}

		// Token: 0x06006A7F RID: 27263 RVA: 0x00391CA4 File Offset: 0x0038FEA4
		public void method_11()
		{
			if (!this.method_8())
			{
				long num = 0L;
				Class1952.QueryPerformanceCounter(ref num);
				try
				{
					this.drawArgs.method_5();
					if (World.Settings.method_12())
					{
						this.drawArgs.device_0.SetRenderState(RenderStates.MultisampleAntiAlias, true);
					}
					Color black = Color.Black;
					if (this.m_World == null)
					{
						this.m_Device3d.BeginScene();
						this.m_Device3d.EndScene();
						this.m_Device3d.Present();
						Thread.Sleep(25);
						return;
					}
					if (this.m_WorkerThread == null)
					{
						this.m_WorkerThreadRunning = true;
						this.m_WorkerThread = Class920.smethod_0(new ThreadStart(this.method_21));
						this.m_WorkerThread.Name = "m_WorkerThread";
						this.m_WorkerThread.IsBackground = true;
						if (World.Settings.method_46())
						{
							this.m_WorkerThread.Priority = ThreadPriority.BelowNormal;
						}
						else
						{
							this.m_WorkerThread.Priority = ThreadPriority.Normal;
						}
						this.m_WorkerThread.Start();
					}
					if (this.drawArgs.GetWorldCamera().Update(this.m_Device3d))
					{
						this.drawArgs.method_12(true);
					}
					this.m_Device3d.BeginScene();
					if (this.bool_4)
					{
						this.m_Device3d.RenderState.FillMode = FillMode.WireFrame;
					}
					else
					{
						this.m_Device3d.RenderState.FillMode = FillMode.Solid;
					}
					this.drawArgs.bool_2 = this.bool_4;
					if (this.drawArgs.method_11())
					{
						this.m_Device3d.Clear(ClearFlags.Target | ClearFlags.ZBuffer, black, 1f, 0);
						this.m_World.Render(this.drawArgs);
					}
					if (World.Settings.method_5())
					{
						this.method_15();
					}
					this.frameCounter++;
					if (this.frameCounter == 30)
					{
						this.fps = (float)this.frameCounter / (float)(DrawArgs.long_0 - this.lastFpsUpdateTime) * (float)Class1952.long_0;
						this.frameCounter = 0;
						this.lastFpsUpdateTime = DrawArgs.long_0;
					}
					if (this.saveScreenShotFilePath != null)
					{
						this.method_19();
					}
					this.drawArgs.device_0.RenderState.ZBufferEnable = false;
					if (this.bool_4)
					{
						this.m_Device3d.RenderState.FillMode = FillMode.Solid;
					}
					this.m_Device3d.RenderState.FogEnable = false;
					if (World.Settings.method_18())
					{
						this.method_14();
					}
					if (this.method_13())
					{
						this.drawArgs.method_12(true);
					}
					if (this.m_World.method_0() != null)
					{
						try
						{
							foreach (Class1945 @class in this.m_World.method_0())
							{
								int x = (int)Math.Round(@class.method_1() * (double)base.Width);
								int y = (int)Math.Round(@class.method_2() * (double)base.Height);
								Rectangle rect = new Rectangle(x, y, base.Width, base.Height);
								this.drawArgs.font_0.DrawText(null, @class.method_0(), rect, (DrawTextFormat)272, Color.White);
							}
						}
						catch (Exception)
						{
						}
					}
					this.method_12(this.m_Device3d);
					this.m_Device3d.EndScene();
				}
				catch (Exception exception_)
				{
					Log.smethod_3(exception_);
				}
				finally
				{
					if (World.Settings.method_15())
					{
						long num2 = 0L;
						Class1952.QueryPerformanceCounter(ref num2);
						float num3 = 1000f / (1000f * (float)(num2 - num) / (float)Class1952.long_0);
						this.arrayList_0.Add(num3);
					}
					this.drawArgs.method_6();
				}
				this.drawArgs.method_10(this);
			}
		}

		// Token: 0x06006A80 RID: 27264 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_12(Device device_1)
		{
		}

		// Token: 0x06006A81 RID: 27265 RVA: 0x003920FC File Offset: 0x003902FC
		public bool method_13()
		{
			bool result = false;
			List<Interface26> list = this.list_0;
			lock (list)
			{
				using (List<Interface26>.Enumerator enumerator = this.list_0.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.imethod_0(this.drawArgs);
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06006A82 RID: 27266 RVA: 0x00392188 File Offset: 0x00390388
		protected void method_14()
		{
			string text = this._caption;
			text = text + "\n" + this.drawArgs.string_0;
			if (World.Settings.method_18())
			{
				double altitudeAboveTerrain = this.drawArgs.GetWorldCamera().GetAltitudeAboveTerrain();
				string text2 = Class1963.smethod_0(altitudeAboveTerrain);
				string text3 = Class1963.smethod_0(this.drawArgs.GetWorldCamera().GetDistance());
				double num = this.drawArgs.GetWorldCamera().GetHeading().GetDegrees();
				if (num < 0.0)
				{
					num += 360.0;
				}
				text += string.Format("Latitude: {0}\nLongitude: {1}\nHeading: {2:f2}°\nTilt: {3}\nAltitude: {4}\nDistance: {5}\nFOV: {6}", new object[]
				{
					this.drawArgs.GetWorldCamera().GetLatitude(),
					this.drawArgs.GetWorldCamera().GetLongitude(),
					num,
					this.drawArgs.GetWorldCamera().GetTilt(),
					text2,
					text3,
					this.drawArgs.GetWorldCamera().GetFov()
				});
				if (altitudeAboveTerrain < 300000.0)
				{
					text += string.Format("\nTerrain Elevation: {0:n} meters\n", this.drawArgs.GetWorldCamera().GetTerrainElevation());
				}
			}
			if (this.showDiagnosticInfo)
			{
				text = string.Concat(new object[]
				{
					text,
					"\nAvailable Texture Memory: ",
					(this.m_Device3d.AvailableTextureMemory / 1024).ToString("N0"),
					" kB\nBoundary Points: ",
					this.drawArgs.int_1.ToString(),
					" / ",
					this.drawArgs.int_0.ToString(),
					" : ",
					this.drawArgs.int_2.ToString(),
					"\nTiles Drawn: ",
					((float)this.drawArgs.int_5 * 0.25f).ToString(),
					"\n",
					this.drawArgs.GetWorldCamera(),
					"\nFPS: ",
					this.fps.ToString("f1"),
					"\nRO: ",
					this.m_World.GetRenderableObjectList().vmethod_20().ToString("f0"),
					"\nmLat: ",
					this.struct63_0.GetDegrees().ToString(),
					"\nmLon: ",
					this.struct63_1.GetDegrees().ToString(),
					"\n",
					TimeKeeper.smethod_0().ToLocalTime().ToLongTimeString()
				});
			}
			text = text.Trim();
			DrawTextFormat format = (DrawTextFormat)274;
			Rectangle rect = Rectangle.FromLTRB(7, 7, base.Width - 8, base.Height - 8);
			this.int_1 += 20;
			if (this.int_1 > this.int_3)
			{
				this.int_1 = this.int_3;
			}
			int color = this.int_1 << 24;
			int color2 = (this.int_1 << 24) + 16777215;
			this.drawArgs.font_0.DrawText(null, text, rect, format, color);
			rect.Offset(-1, -1);
			this.drawArgs.font_0.DrawText(null, text, rect, format, color2);
		}

		// Token: 0x06006A83 RID: 27267 RVA: 0x00392548 File Offset: 0x00390748
		protected void method_15()
		{
			int num = 10;
			if (this.line_0 == null)
			{
				this.line_0 = new Line(this.m_Device3d);
			}
			Vector2[] array = new Vector2[2];
			Vector2[] array2 = new Vector2[2];
			array2[0].X = (float)(base.Width / 2 - num);
			array2[0].Y = (float)(base.Height / 2);
			array2[1].X = (float)(base.Width / 2 + num);
			array2[1].Y = (float)(base.Height / 2);
			array[0].X = (float)(base.Width / 2);
			array[0].Y = (float)(base.Height / 2 - num);
			array[1].X = (float)(base.Width / 2);
			array[1].Y = (float)(base.Height / 2 + num);
			this.line_0.Begin();
			this.line_0.Draw(array2, this.int_4);
			this.line_0.Draw(array, this.int_4);
			this.line_0.End();
		}

		// Token: 0x06006A84 RID: 27268 RVA: 0x00392674 File Offset: 0x00390874
		protected void method_16()
		{
			try
			{
				this.m_Device3d.TestCooperativeLevel();
			}
			catch (DeviceLostException)
			{
			}
			catch (DeviceNotResetException)
			{
				try
				{
					this.m_Device3d.Reset(new PresentParameters[]
					{
						this.m_presentParams
					});
				}
				catch (DeviceLostException)
				{
				}
			}
		}

		// Token: 0x06006A85 RID: 27269 RVA: 0x003926E0 File Offset: 0x003908E0
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			try
			{
				this.drawArgs.GetWorldCamera().ZoomStepped((float)e.Delta / 120f);
			}
			finally
			{
				base.OnMouseWheel(e);
			}
		}

		// Token: 0x06006A86 RID: 27270 RVA: 0x00392728 File Offset: 0x00390928
		protected override void OnKeyDown(KeyEventArgs e)
		{
			try
			{
				e.Handled = this.method_17(e);
				base.OnKeyDown(e);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06006A87 RID: 27271 RVA: 0x00392774 File Offset: 0x00390974
		protected override void OnKeyUp(KeyEventArgs e)
		{
			try
			{
				e.Handled = this.method_18(e);
				base.OnKeyUp(e);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06006A88 RID: 27272 RVA: 0x0002DD99 File Offset: 0x0002BF99
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x003927C0 File Offset: 0x003909C0
		[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true), SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
		public override bool PreProcessMessage(ref Message msg)
		{
			bool result;
			if (msg.Msg == 256)
			{
				Keys keys = (Keys)msg.WParam.ToInt32();
				if (keys - Keys.Left <= 3)
				{
					this.OnKeyDown(new KeyEventArgs(keys));
					msg.Result = (IntPtr)1;
					result = true;
					return result;
				}
			}
			result = base.PreProcessMessage(ref msg);
			return result;
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x0039281C File Offset: 0x00390A1C
		public bool method_17(KeyEventArgs keyEventArgs_0)
		{
			bool result;
			if (keyEventArgs_0.Alt)
			{
				Keys keyCode = keyEventArgs_0.KeyCode;
				if (keyCode <= Keys.NumPad1)
				{
					if (keyCode <= Keys.Home)
					{
						if (keyCode != Keys.End)
						{
							if (keyCode != Keys.Home)
							{
								result = false;
								return result;
							}
							goto IL_EB;
						}
					}
					else
					{
						if (keyCode == Keys.C)
						{
							World.Settings.method_6(!World.Settings.method_5());
							result = true;
							return result;
						}
						if (keyCode != Keys.NumPad1)
						{
							result = false;
							return result;
						}
					}
				}
				else if (keyCode <= Keys.Add)
				{
					if (keyCode != Keys.NumPad7 && keyCode != Keys.Add)
					{
						result = false;
						return result;
					}
					goto IL_EB;
				}
				else if (keyCode != Keys.Subtract)
				{
					if (keyCode == Keys.Oemplus)
					{
						goto IL_EB;
					}
					if (keyCode != Keys.OemMinus)
					{
						result = false;
						return result;
					}
				}
				CameraBase worldCamera = this.drawArgs.GetWorldCamera();
				worldCamera.SetFov(Angle.Addition(worldCamera.GetFov(), Angle.FromDegrees(5.0)));
				result = true;
				return result;
				IL_EB:
				CameraBase worldCamera2 = this.drawArgs.GetWorldCamera();
				worldCamera2.SetFov(Angle.Minus(worldCamera2.GetFov(), Angle.FromDegrees(5.0)));
				result = true;
			}
			else if (!keyEventArgs_0.Control)
			{
				Keys keyCode = keyEventArgs_0.KeyCode;
				if (keyCode <= Keys.K)
				{
					if (keyCode <= Keys.A)
					{
						switch (keyCode)
						{
						case Keys.End:
							goto IL_516;
						case Keys.Home:
							goto IL_4EA;
						case Keys.Left:
							goto IL_334;
						case Keys.Up:
							goto IL_440;
						case Keys.Right:
							goto IL_398;
						case Keys.Down:
							break;
						default:
							if (keyCode != Keys.A)
							{
								result = false;
								return result;
							}
							if (!keyEventArgs_0.Shift)
							{
								Angle angle = Angle.FromRadians(0.0099999997764825821);
								CameraBase worldCamera3 = this.drawArgs.GetWorldCamera();
								worldCamera3.SetHeading(Angle.Addition(worldCamera3.GetHeading(), angle));
								this.drawArgs.GetWorldCamera().RotationYawPitchRoll(Angle.Zero, Angle.Zero, angle);
							}
							result = true;
							return result;
						}
					}
					else
					{
						if (keyCode == Keys.D)
						{
							Angle angle2 = Angle.FromRadians(-0.0099999997764825821);
							CameraBase worldCamera4 = this.drawArgs.GetWorldCamera();
							worldCamera4.SetHeading(Angle.Addition(worldCamera4.GetHeading(), angle2));
							this.drawArgs.GetWorldCamera().RotationYawPitchRoll(Angle.Zero, Angle.Zero, angle2);
							result = true;
							return result;
						}
						switch (keyCode)
						{
						case Keys.H:
							goto IL_334;
						case Keys.I:
							result = false;
							return result;
						case Keys.J:
							break;
						case Keys.K:
							goto IL_398;
						default:
							result = false;
							return result;
						}
					}
				}
				else if (keyCode <= Keys.Subtract)
				{
					switch (keyCode)
					{
					case Keys.S:
						if (!keyEventArgs_0.Shift)
						{
							CameraBase worldCamera5 = this.drawArgs.GetWorldCamera();
							worldCamera5.SetTilt(Angle.Addition(worldCamera5.GetTilt(), Angle.FromDegrees(1.0)));
						}
						result = true;
						return result;
					case Keys.T:
					case Keys.V:
						result = false;
						return result;
					case Keys.U:
						goto IL_440;
					case Keys.W:
					{
						CameraBase worldCamera6 = this.drawArgs.GetWorldCamera();
						worldCamera6.SetTilt(Angle.Addition(worldCamera6.GetTilt(), Angle.FromDegrees(-1.0)));
						result = true;
						return result;
					}
					default:
						switch (keyCode)
						{
						case Keys.NumPad1:
						case Keys.Subtract:
							goto IL_516;
						case Keys.NumPad2:
							break;
						case Keys.NumPad3:
						case Keys.NumPad5:
						case Keys.NumPad9:
						case Keys.Multiply:
						case Keys.Separator:
							result = false;
							return result;
						case Keys.NumPad4:
							goto IL_334;
						case Keys.NumPad6:
							goto IL_398;
						case Keys.NumPad7:
						case Keys.Add:
							goto IL_4EA;
						case Keys.NumPad8:
							goto IL_440;
						default:
							result = false;
							return result;
						}
						break;
					}
				}
				else
				{
					if (keyCode == Keys.Oemplus)
					{
						goto IL_4EA;
					}
					if (keyCode != Keys.OemMinus)
					{
						result = false;
						return result;
					}
					goto IL_516;
				}
				Angle pitch = Angle.FromRadians(-1.0 * this.drawArgs.GetWorldCamera().GetAltitude() * (1.0 / (300.0 * this.method_2().GetEquatorialRadius())));
				this.drawArgs.GetWorldCamera().RotationYawPitchRoll(Angle.Zero, pitch, Angle.Zero);
				result = true;
				return result;
				IL_334:
				Angle yaw = Angle.FromRadians(-1.0 * this.drawArgs.GetWorldCamera().GetAltitude() * (1.0 / (300.0 * this.method_2().GetEquatorialRadius())));
				this.drawArgs.GetWorldCamera().RotationYawPitchRoll(yaw, Angle.Zero, Angle.Zero);
				result = true;
				return result;
				IL_398:
				Angle yaw2 = Angle.FromRadians(1.0 * this.drawArgs.GetWorldCamera().GetAltitude() * (1.0 / (300.0 * this.method_2().GetEquatorialRadius())));
				this.drawArgs.GetWorldCamera().RotationYawPitchRoll(yaw2, Angle.Zero, Angle.Zero);
				result = true;
				return result;
				IL_440:
				Angle pitch2 = Angle.FromRadians(1.0 * this.drawArgs.GetWorldCamera().GetAltitude() * (1.0 / (300.0 * this.method_2().GetEquatorialRadius())));
				this.drawArgs.GetWorldCamera().RotationYawPitchRoll(Angle.Zero, pitch2, Angle.Zero);
				result = true;
				return result;
				IL_4EA:
				this.drawArgs.GetWorldCamera().ZoomStepped(World.Settings.method_34());
				result = true;
				return result;
				IL_516:
				this.drawArgs.GetWorldCamera().ZoomStepped(-World.Settings.method_34());
				result = true;
			}
			else
			{
				this.bool_5 = true;
				result = false;
			}
			return result;
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x00392D68 File Offset: 0x00390F68
		public bool method_18(KeyEventArgs keyEventArgs_0)
		{
			if (this.bool_5 && !keyEventArgs_0.Control)
			{
				this.bool_5 = false;
			}
			bool result;
			if (!keyEventArgs_0.Alt)
			{
				if (keyEventArgs_0.Control)
				{
					Keys keyCode = keyEventArgs_0.KeyCode;
					if (keyCode == Keys.D)
					{
						this.showDiagnosticInfo = !this.showDiagnosticInfo;
						result = true;
						return result;
					}
					if (keyCode == Keys.W)
					{
						this.bool_4 = !this.bool_4;
						result = true;
						return result;
					}
					this.bool_5 = false;
				}
				else
				{
					Keys keyCode = keyEventArgs_0.KeyCode;
					if (keyCode == Keys.Clear || keyCode == Keys.Space)
					{
						this.drawArgs.GetWorldCamera().Reset();
						result = true;
						return result;
					}
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06006A8C RID: 27276 RVA: 0x00392E20 File Offset: 0x00391020
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.Focus();
			DrawArgs.point_0.X = e.X;
			DrawArgs.point_0.Y = e.Y;
			this.point_0.X = e.X;
			this.point_0.Y = e.Y;
			try
			{
			}
			finally
			{
				if (e.Button == MouseButtons.Left)
				{
					DrawArgs.bool_0 = true;
				}
				if (e.Button == MouseButtons.Right)
				{
					DrawArgs.bool_1 = true;
				}
				base.OnMouseDown(e);
			}
		}

		// Token: 0x06006A8D RID: 27277 RVA: 0x0002DDA2 File Offset: 0x0002BFA2
		protected override void OnMouseDoubleClick(MouseEventArgs e)
		{
			this.bool_6 = true;
			base.OnMouseDoubleClick(e);
		}

		// Token: 0x06006A8E RID: 27278 RVA: 0x00392EC0 File Offset: 0x003910C0
		protected override void OnMouseUp(MouseEventArgs e)
		{
			DrawArgs.point_0.X = e.X;
			DrawArgs.point_0.Y = e.Y;
			try
			{
				if (!(this.point_0 == Point.Empty))
				{
					this.point_0 = Point.Empty;
					if (this.m_World != null)
					{
						if (this.bool_6)
						{
							this.bool_6 = false;
							if (e.Button == MouseButtons.Left)
							{
								this.drawArgs.GetWorldCamera().Zoom(World.Settings.method_35());
							}
							else if (e.Button == MouseButtons.Right)
							{
								this.drawArgs.GetWorldCamera().Zoom(-World.Settings.method_35());
							}
						}
						else if (e.Button == MouseButtons.Left)
						{
							if (this.bool_3)
							{
								this.bool_3 = false;
							}
							else if (!this.m_World.PerformSelectionAction(this.drawArgs))
							{
							}
						}
						else if (e.Button == MouseButtons.Right && this.bool_3)
						{
							this.bool_3 = false;
						}
					}
				}
			}
			finally
			{
				if (e.Button == MouseButtons.Left)
				{
					DrawArgs.bool_0 = false;
				}
				if (e.Button == MouseButtons.Right)
				{
					DrawArgs.bool_1 = false;
				}
				base.OnMouseUp(e);
			}
		}

		// Token: 0x06006A8F RID: 27279 RVA: 0x00393034 File Offset: 0x00391234
		protected override void OnMouseMove(MouseEventArgs e)
		{
			DrawArgs.smethod_0(Enum149.const_0);
			try
			{
				int num = e.X - DrawArgs.point_0.X;
				int num2 = e.Y - DrawArgs.point_0.Y;
				float num3 = (float)num / (float)this.drawArgs.int_3;
				float num4 = (float)num2 / (float)this.drawArgs.int_4;
				if (!(this.point_0 == Point.Empty))
				{
					bool flag = (e.Button & MouseButtons.Left) > MouseButtons.None;
					bool flag2 = (e.Button & MouseButtons.Right) > MouseButtons.None;
					if (flag | flag2)
					{
						int num5 = this.point_0.X - e.X;
						int num6 = this.point_0.Y - e.Y;
						if (num5 * num5 + num6 * num6 > 9)
						{
							this.bool_3 = true;
						}
					}
					if (flag && !flag2)
					{
						Angle a;
						Angle a2;
						this.drawArgs.GetWorldCamera().PickingRayIntersection(DrawArgs.point_0.X, DrawArgs.point_0.Y, out a, out a2);
						Angle angle;
						Angle b;
						this.drawArgs.GetWorldCamera().PickingRayIntersection(e.X, e.Y, out angle, out b);
						if (World.Settings.method_29())
						{
							if (!Angle.IsNaN(angle) && !Angle.IsNaN(a))
							{
								Angle lat = Angle.Minus(a, angle);
								Angle lon = Angle.Minus(a2, b);
								this.drawArgs.GetWorldCamera().Pan(lat, lon);
							}
							else
							{
								Angle lat2 = Angle.FromRadians((double)num2 * this.drawArgs.GetWorldCamera().GetAltitude() / (800.0 * this.method_2().GetEquatorialRadius()));
								Angle lon2 = Angle.FromRadians(-(double)num * this.drawArgs.GetWorldCamera().GetAltitude() / (800.0 * this.method_2().GetEquatorialRadius()));
								this.drawArgs.GetWorldCamera().Pan(lat2, lon2);
							}
						}
						else
						{
							double times = this.drawArgs.GetWorldCamera().GetAltitude() / (1500.0 * this.method_2().GetEquatorialRadius());
							this.drawArgs.GetWorldCamera().RotationYawPitchRoll(Angle.Multiply(Angle.FromRadians((double)(DrawArgs.point_0.X - e.X)), times), Angle.Multiply(Angle.FromRadians((double)(e.Y - DrawArgs.point_0.Y)), times), Angle.Zero);
						}
					}
					else if ((!flag & flag2) && !this.bool_5)
					{
						Angle roll = Angle.FromRadians(-(double)num3 * (double)World.Settings.method_36());
						this.drawArgs.GetWorldCamera().RotationYawPitchRoll(Angle.Zero, Angle.Zero, roll);
						CameraBase worldCamera = this.drawArgs.GetWorldCamera();
						worldCamera.SetTilt(Angle.Addition(worldCamera.GetTilt(), Angle.FromRadians((double)(num4 * World.Settings.method_36()))));
					}
					else if (flag & flag2)
					{
						if (Math.Abs(num4) > 1.401298E-45f)
						{
							this.drawArgs.GetWorldCamera().Zoom(-num4 * World.Settings.method_33());
						}
						if (!World.Settings.method_30())
						{
							CameraBase worldCamera2 = this.drawArgs.GetWorldCamera();
							worldCamera2.SetBank(Angle.Minus(worldCamera2.GetBank(), Angle.FromRadians((double)(num3 * World.Settings.method_36()))));
						}
					}
				}
			}
			catch
			{
			}
			finally
			{
				this.drawArgs.GetWorldCamera().PickingRayIntersection(e.X, e.Y, out this.struct63_0, out this.struct63_1);
				DrawArgs.point_0.X = e.X;
				DrawArgs.point_0.Y = e.Y;
				base.OnMouseMove(e);
			}
		}

		// Token: 0x06006A90 RID: 27280 RVA: 0x0002DDB2 File Offset: 0x0002BFB2
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
		}

		// Token: 0x06006A91 RID: 27281 RVA: 0x00393434 File Offset: 0x00391634
		protected void method_19()
		{
			try
			{
				using (Surface backBuffer = this.m_Device3d.GetBackBuffer(0, 0, BackBufferType.Mono))
				{
					SurfaceLoader.Save(this.saveScreenShotFilePath, this.saveScreenShotImageFileFormat, backBuffer);
				}
				this.saveScreenShotFilePath = null;
			}
			catch (InvalidCallException ex)
			{
				MessageBox.Show(ex.Message, "Screenshot save failed.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06006A92 RID: 27282 RVA: 0x003934B0 File Offset: 0x003916B0
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.m_WorkerThread != null && this.m_WorkerThread.IsAlive)
				{
					this.m_WorkerThreadRunning = false;
					this.m_WorkerThread.Abort();
				}
				this.timer_0.Stop();
				if (this.m_World != null)
				{
					this.m_World.Dispose();
					this.m_World = null;
				}
				if (this.drawArgs != null)
				{
					this.drawArgs.Dispose();
					this.drawArgs = null;
				}
				this.m_Device3d.Dispose();
			}
			base.Dispose(disposing);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06006A93 RID: 27283 RVA: 0x00393550 File Offset: 0x00391750
		private void device_0_DeviceResizing(object sender, CancelEventArgs e)
		{
			if (base.Size.Width != 0 && base.Size.Height != 0)
			{
				this.drawArgs.int_4 = base.Height;
				this.drawArgs.int_3 = base.Width;
			}
			else
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06006A94 RID: 27284 RVA: 0x0002DDBB File Offset: 0x0002BFBB
		private static bool smethod_0()
		{
			return Application.ExecutablePath.ToUpper(CultureInfo.InvariantCulture).EndsWith("DEVENV.EXE");
		}

		// Token: 0x06006A95 RID: 27285 RVA: 0x003935B0 File Offset: 0x003917B0
		private void method_20()
		{
			this.m_presentParams = new PresentParameters();
			this.m_presentParams.Windowed = true;
			this.m_presentParams.SwapEffect = SwapEffect.Discard;
			this.m_presentParams.AutoDepthStencilFormat = DepthFormat.D16;
			this.m_presentParams.EnableAutoDepthStencil = true;
			this.m_presentParams.PresentFlag = PresentFlag.LockableBackBuffer;
			if (!World.Settings.method_14())
			{
				this.m_presentParams.PresentationInterval = PresentInterval.Immediate;
			}
			int adapter = 0;
			try
			{
				adapter = Manager.Adapters.Default.Adapter;
			}
			catch
			{
				throw new NotAvailableException();
			}
			DeviceType deviceType = DeviceType.Hardware;
			CreateFlags createFlags = CreateFlags.SoftwareVertexProcessing;
			if (Manager.GetDeviceCaps(adapter, DeviceType.Hardware).DeviceCaps.SupportsHardwareTransformAndLight)
			{
				createFlags = CreateFlags.HardwareVertexProcessing;
			}
			createFlags |= (CreateFlags.MultiThreaded | CreateFlags.FpuPreserve);
			try
			{
				this.m_Device3d = new Device(adapter, deviceType, this, createFlags, new PresentParameters[]
				{
					this.m_presentParams
				});
			}
			catch (Exception)
			{
				throw;
			}
			this.m_Device3d.DeviceReset += new EventHandler(this.device_0_DeviceReset);
			this.m_Device3d.DeviceResizing += new CancelEventHandler(this.device_0_DeviceResizing);
			this.device_0_DeviceReset(this.m_Device3d, null);
		}

		// Token: 0x06006A96 RID: 27286 RVA: 0x003936E4 File Offset: 0x003918E4
		private void device_0_DeviceReset(object sender, EventArgs e)
		{
			if (this.m_Device3d.DeviceCaps.TextureFilterCaps.SupportsMinifyAnisotropic)
			{
				this.m_Device3d.SamplerState[0].MinFilter = TextureFilter.Anisotropic;
			}
			else if (this.m_Device3d.DeviceCaps.TextureFilterCaps.SupportsMinifyLinear)
			{
				this.m_Device3d.SamplerState[0].MinFilter = TextureFilter.Linear;
			}
			if (this.m_Device3d.DeviceCaps.TextureFilterCaps.SupportsMagnifyAnisotropic)
			{
				this.m_Device3d.SamplerState[0].MagFilter = TextureFilter.Anisotropic;
			}
			else if (this.m_Device3d.DeviceCaps.TextureFilterCaps.SupportsMagnifyLinear)
			{
				this.m_Device3d.SamplerState[0].MagFilter = TextureFilter.Linear;
			}
			this.m_Device3d.SamplerState[0].AddressU = TextureAddress.Clamp;
			this.m_Device3d.SamplerState[0].AddressV = TextureAddress.Clamp;
			this.m_Device3d.RenderState.Clipping = true;
			this.m_Device3d.RenderState.CullMode = Cull.Clockwise;
			this.m_Device3d.RenderState.Lighting = false;
			this.m_Device3d.RenderState.Ambient = World.Settings.StandardAmbientColor;
			this.m_Device3d.RenderState.ZBufferEnable = true;
			this.m_Device3d.RenderState.AlphaBlendEnable = true;
			this.m_Device3d.RenderState.SourceBlend = Blend.SourceAlpha;
			this.m_Device3d.RenderState.DestinationBlend = Blend.InvSourceAlpha;
		}

		// Token: 0x06006A97 RID: 27287 RVA: 0x00393890 File Offset: 0x00391A90
		private void method_21()
		{
			while (this.m_WorkerThreadRunning)
			{
				try
				{
					if (World.Settings.method_46() && this.m_WorkerThread.Priority == ThreadPriority.Normal)
					{
						this.m_WorkerThread.Priority = ThreadPriority.BelowNormal;
					}
					else if (!World.Settings.method_46() && this.m_WorkerThread.Priority == ThreadPriority.BelowNormal)
					{
						this.m_WorkerThread.Priority = ThreadPriority.Normal;
					}
					long num = 0L;
					Class1952.QueryPerformanceCounter(ref num);
					if (!this.method_8())
					{
						this.m_World.Update(this.drawArgs);
					}
					long num2 = 0L;
					Class1952.QueryPerformanceCounter(ref num2);
					float num3 = 1000f * (float)(num2 - num) / (float)Class1952.long_0;
					float num4 = 5000f - num3;
					if (num4 > 0f)
					{
						Thread.Sleep((int)num4);
					}
				}
				catch (Exception exception_)
				{
					Log.smethod_3(exception_);
				}
			}
		}

		// Token: 0x06006A98 RID: 27288 RVA: 0x0002DDD6 File Offset: 0x0002BFD6
		public void vmethod_0(bool bool_8)
		{
			World.Settings.method_17(bool_8);
		}

		// Token: 0x06006A99 RID: 27289 RVA: 0x00393998 File Offset: 0x00391B98
		private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (!this.bool_7)
			{
				this.bool_7 = true;
				try
				{
					if (World.Settings.method_15() && this.arrayList_0.Count > World.Settings.method_16())
					{
						this.arrayList_0.RemoveRange(0, this.arrayList_0.Count - World.Settings.method_16());
					}
				}
				catch (Exception exception_)
				{
					Log.smethod_3(exception_);
				}
				this.bool_7 = false;
			}
		}

		// Token: 0x04003C15 RID: 15381
		private Device m_Device3d;

		// Token: 0x04003C16 RID: 15382
		private PresentParameters m_presentParams;

		// Token: 0x04003C17 RID: 15383
		private DrawArgs drawArgs;

		// Token: 0x04003C18 RID: 15384
		private World m_World;

		// Token: 0x04003C19 RID: 15385
		private Cache m_Cache;

		// Token: 0x04003C1A RID: 15386
		private Thread m_WorkerThread;

		// Token: 0x04003C1B RID: 15387
		private bool showDiagnosticInfo;

		// Token: 0x04003C1C RID: 15388
		private string _caption = "";

		// Token: 0x04003C1D RID: 15389
		private long lastFpsUpdateTime;

		// Token: 0x04003C1E RID: 15390
		private int frameCounter;

		// Token: 0x04003C1F RID: 15391
		private float fps;

		// Token: 0x04003C20 RID: 15392
		private string saveScreenShotFilePath;

		// Token: 0x04003C21 RID: 15393
		private ImageFileFormat saveScreenShotImageFileFormat;

		// Token: 0x04003C22 RID: 15394
		private bool m_WorkerThreadRunning;

		// Token: 0x04003C23 RID: 15395
		private bool bool_2;

		// Token: 0x04003C24 RID: 15396
		private bool bool_3;

		// Token: 0x04003C25 RID: 15397
		private Point point_0 = Point.Empty;

		// Token: 0x04003C26 RID: 15398
		private bool bool_4;

		// Token: 0x04003C27 RID: 15399
		private System.Timers.Timer timer_0 = new System.Timers.Timer(250.0);

		// Token: 0x04003C28 RID: 15400
		private System.Timers.Timer timer_1;

		// Token: 0x04003C29 RID: 15401
		private bool bool_5;

		// Token: 0x04003C2A RID: 15402
		private List<Interface26> list_0 = new List<Interface26>();

		// Token: 0x04003C2B RID: 15403
		private ArrayList arrayList_0 = new ArrayList();

		// Token: 0x04003C2C RID: 15404
		private int int_1 = 255;

		// Token: 0x04003C2D RID: 15405
		private int int_2 = 40;

		// Token: 0x04003C2E RID: 15406
		private int int_3 = 205;

		// Token: 0x04003C2F RID: 15407
		private Line line_0;

		// Token: 0x04003C30 RID: 15408
		private int int_4 = Color.GhostWhite.ToArgb();

		// Token: 0x04003C31 RID: 15409
		private bool bool_6;

		// Token: 0x04003C32 RID: 15410
		private Angle struct63_0;

		// Token: 0x04003C33 RID: 15411
		private Angle struct63_1;

		// Token: 0x04003C34 RID: 15412
		private bool bool_7;
	}
}
