using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ns15
{
	// Token: 0x0200063F RID: 1599
	public sealed class Control1 : TabControl
	{
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600288B RID: 10379 RVA: 0x000F4548 File Offset: 0x000F2748
		public override Rectangle DisplayRectangle
		{
			get
			{
				int num = 0;
				if (this.method_1() == TabAppearance.Normal)
				{
					num = 4;
				}
				int num2;
				if (base.Alignment <= TabAlignment.Bottom)
				{
					num2 = base.ItemSize.Height;
				}
				else
				{
					num2 = base.ItemSize.Width;
				}
				int num3;
				if (this.method_1() == TabAppearance.Normal)
				{
					num3 = 5 + num2 * base.RowCount;
				}
				else
				{
					num3 = (3 + num2) * base.RowCount;
				}
				Rectangle result;
				switch (base.Alignment)
				{
				case TabAlignment.Bottom:
					result = new Rectangle(num, num, base.Width - num * 2, base.Height - num3 - num);
					break;
				case TabAlignment.Left:
					result = new Rectangle(num3, num, base.Width - num3 - num, base.Height - num * 2);
					break;
				case TabAlignment.Right:
					result = new Rectangle(num, num, base.Width - num3 - num, base.Height - num * 2);
					break;
				default:
					result = new Rectangle(num, num3, base.Width - num * 2, base.Height - num3 - num);
					break;
				}
				return result;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x000F465C File Offset: 0x000F285C
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x000166DE File Offset: 0x000148DE
		public override Color BackColor
		{
			get
			{
				Color backColor;
				if (this.color_0.Equals(Color.Empty))
				{
					backColor = base.BackColor;
				}
				else
				{
					backColor = this.color_0;
				}
				return backColor;
			}
			set
			{
				this.color_0 = value;
				this.OnBackColorChanged(EventArgs.Empty);
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x000F469C File Offset: 0x000F289C
		// (set) Token: 0x0600288F RID: 10383 RVA: 0x000166F2 File Offset: 0x000148F2
		public override Color ForeColor
		{
			get
			{
				return base.ForeColor;
			}
			set
			{
				base.ForeColor = value;
			}
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x000F46B4 File Offset: 0x000F28B4
		public Control1()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.Opaque, false);
			this.DoubleBuffered = false;
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x000F471C File Offset: 0x000F291C
		public TabDrawMode method_0()
		{
			return this.tabDrawMode_0;
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x000F4734 File Offset: 0x000F2934
		public TabAppearance method_1()
		{
			return base.Appearance;
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x000F474C File Offset: 0x000F294C
		public Color method_2()
		{
			return this.color_1;
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x000F4764 File Offset: 0x000F2964
		public Color method_3()
		{
			return this.color_2;
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x000F477C File Offset: 0x000F297C
		public Color method_4()
		{
			return this.color_3;
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x000166FB File Offset: 0x000148FB
		public bool method_5()
		{
			return this.bool_3;
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x00016703 File Offset: 0x00014903
		public bool method_6()
		{
			return this.bool_1;
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x000F4794 File Offset: 0x000F2994
		private TabPage method_7()
		{
			Point point_ = base.PointToClient(Control.MousePosition);
			return this.method_23(point_);
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x000F47B8 File Offset: 0x000F29B8
		private TabPage method_8()
		{
			TabPage result;
			if (this.method_1() == TabAppearance.Normal)
			{
				result = base.SelectedTab;
			}
			else
			{
				int num = Class831.SendMessage(base.Handle, 4911, IntPtr.Zero, IntPtr.Zero).ToInt32();
				if (num != -1)
				{
					result = base.TabPages[num];
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x000F4818 File Offset: 0x000F2A18
		private int method_9()
		{
			return this.int_0;
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x0001670B File Offset: 0x0001490B
		private void method_10(int int_1)
		{
			if (this.int_0 != int_1)
			{
				this.int_0 = int_1;
				base.Invalidate();
			}
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x000F4830 File Offset: 0x000F2A30
		private bool method_11()
		{
			bool result;
			if (this.method_1() != TabAppearance.Normal || !Application.RenderWithVisualStyles)
			{
				result = false;
			}
			else if (base.DesignMode)
			{
				result = VisualStyleRenderer.IsSupported;
			}
			else
			{
				result = (Class831.GetWindowTheme(base.Handle) != IntPtr.Zero);
			}
			return result;
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x000F4880 File Offset: 0x000F2A80
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			if (base.Width > 0 && base.Height > 0)
			{
				pevent.Graphics.Flush(FlushIntention.Sync);
				using (Bitmap bitmap = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppPArgb))
				{
					using (Graphics graphics = Graphics.FromImage(bitmap))
					{
						if (this.bitmap_0 != null)
						{
							graphics.DrawImage(this.bitmap_0, Point.Empty);
						}
						Rectangle rect = base.ClientRectangle;
						if (!this.bool_3)
						{
							rect = this.DisplayRectangle;
						}
						using (SolidBrush solidBrush = new SolidBrush(this.BackColor))
						{
							graphics.FillRectangle(solidBrush, rect);
						}
						this.method_16(graphics);
						for (int i = 0; i < base.TabCount; i++)
						{
							if (i != base.SelectedIndex)
							{
								this.method_12(graphics, i);
							}
						}
						if (base.SelectedIndex != -1)
						{
							this.method_12(graphics, base.SelectedIndex);
						}
						IntPtr hbitmap = bitmap.GetHbitmap();
						IntPtr hdc = graphics.GetHdc();
						IntPtr intPtr = Class831.CreateCompatibleDC(hdc);
						IntPtr intptr_ = Class831.SelectObject(intPtr, hbitmap);
						IntPtr hdc2 = pevent.Graphics.GetHdc();
						Class831.BitBlt(hdc2, 0, 0, base.Width, base.Height, intPtr, 0, 0, 13369376);
						pevent.Graphics.ReleaseHdc(hdc2);
						Class831.SelectObject(intptr_, hbitmap);
						Class831.DeleteDC(intPtr);
						graphics.ReleaseHdc(hdc);
						Class831.DeleteObject(hbitmap);
					}
				}
			}
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x00016728 File Offset: 0x00014928
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			this.OnFontChanged(EventArgs.Empty);
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x0001673B File Offset: 0x0001493B
		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			Class831.SendMessage(base.Handle, 794, IntPtr.Zero, IntPtr.Zero);
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x000F4A60 File Offset: 0x000F2C60
		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
			if (base.Visible && !this.bool_0)
			{
				this.bool_0 = true;
				if (base.SelectedIndex != -1)
				{
					base.SelectedTab = this.method_20();
				}
				if (Application.RenderWithVisualStyles && this.method_1() == TabAppearance.Normal)
				{
					Class831.SetWindowTheme(base.Handle, "", "");
					Class831.SetWindowTheme(base.Handle, null, null);
				}
			}
			this.method_19();
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x000F4AE8 File Offset: 0x000F2CE8
		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			IntPtr intptr_ = this.Font.ToHfont();
			Class831.SendMessage(base.Handle, 48, intptr_, (IntPtr)(-1));
			Class831.SendMessage(base.Handle, 29, IntPtr.Zero, IntPtr.Zero);
			base.UpdateStyles();
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x0001675F File Offset: 0x0001495F
		protected override void OnBackColorChanged(EventArgs e)
		{
			base.OnBackColorChanged(e);
			base.Invalidate();
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x0001676E File Offset: 0x0001496E
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.method_19();
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x000F4B3C File Offset: 0x000F2D3C
		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			if (this.method_0() == TabDrawMode.OwnerDrawFixed)
			{
				base.OnDrawItem(e);
			}
			else
			{
				TabPage tabPage = base.TabPages[e.Index];
				Rectangle bounds = e.Bounds;
				bool flag = this.RightToLeft == RightToLeft.Yes && this.RightToLeftLayout;
				bool flag2 = this.method_11();
				bool flag3 = (tabPage.ImageIndex >= 0 || !string.IsNullOrEmpty(tabPage.ImageKey)) && base.ImageList != null;
				bool flag4 = e.Index == base.SelectedIndex;
				Class831.Struct61 @struct = default(Class831.Struct61);
				IntPtr hdc = e.Graphics.GetHdc();
				IntPtr intPtr = this.Font.ToHfont();
				IntPtr intptr_ = Class831.SelectObject(hdc, intPtr);
				Class831.DrawText(hdc, tabPage.Text, tabPage.Text.Length, ref @struct, Class831.Enum148.flag_12 | Class831.Enum148.flag_15);
				Class831.SelectObject(hdc, intptr_);
				Class831.DeleteObject(intPtr);
				e.Graphics.ReleaseHdc(hdc);
				Rectangle rectangle = new Rectangle(Point.Empty, @struct.method_2());
				Rectangle empty = Rectangle.Empty;
				Rectangle rectangle2 = rectangle;
				if (flag3)
				{
					empty.Size = base.ImageList.ImageSize;
					rectangle2.Width += empty.Width + base.Padding.X;
					rectangle2.Height = Math.Max(rectangle.Height, empty.Height);
				}
				rectangle2.Offset((bounds.Width - rectangle2.Width) / 2, (bounds.Height - rectangle2.Height) / 2);
				empty.X = (flag ? (rectangle2.Right - empty.Width) : rectangle2.Left);
				rectangle.X = rectangle2.Right - rectangle.Width;
				empty.Offset(0, (bounds.Height - empty.Height) / 2);
				rectangle.Offset(0, (bounds.Height - @struct.method_2().Height) / 2);
				if (flag4)
				{
					if (this.method_1() == TabAppearance.Normal)
					{
						empty.Offset(0, (base.Alignment == TabAlignment.Bottom) ? 2 : -2);
						rectangle.Offset(0, (base.Alignment == TabAlignment.Bottom) ? 2 : -2);
					}
					else
					{
						empty.Offset(1, 1);
						rectangle.Offset(flag ? -1 : 1, 1);
					}
				}
				if (base.Alignment != TabAlignment.Bottom)
				{
					empty.Offset(0, 1);
					rectangle.Offset(0, 1);
				}
				if (flag3)
				{
					Bitmap bitmap;
					if (tabPage.ImageIndex == -1)
					{
						bitmap = (Bitmap)base.ImageList.Images[tabPage.ImageKey];
					}
					else
					{
						bitmap = (Bitmap)base.ImageList.Images[tabPage.ImageIndex];
					}
					if (!this.method_6())
					{
						switch (base.Alignment)
						{
						case TabAlignment.Left:
							bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
							break;
						case TabAlignment.Right:
							bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
							break;
						}
					}
					if (tabPage.Enabled)
					{
						e.Graphics.DrawImage(bitmap, empty);
					}
					else
					{
						ControlPaint.DrawImageDisabled(e.Graphics, bitmap, empty.X, empty.Y, Color.Empty);
					}
					bitmap.Dispose();
				}
				Class831.Enum147 @enum = Class831.Enum147.flag_2;
				Color color_ = (e.Index != this.method_9() || !base.HotTrack || this.method_1() == TabAppearance.FlatButtons || flag2) ? this.ForeColor : this.method_4();
				if (!tabPage.Enabled)
				{
					if (flag2)
					{
						color_ = SystemColors.GrayText;
					}
					else
					{
						@enum |= Class831.Enum147.flag_5;
					}
				}
				if (!this.ShowKeyboardCues)
				{
					@enum |= Class831.Enum147.flag_6;
				}
				if (this.RightToLeft == RightToLeft.Yes)
				{
					@enum |= (Class831.Enum147.flag_7 | Class831.Enum147.flag_8);
				}
				IntPtr hdc2 = e.Graphics.GetHdc();
				if (flag)
				{
					Class831.SetLayout(hdc2, 9);
				}
				Control1.smethod_0(hdc2, tabPage.Text, this.Font, color_, rectangle, (int)@enum);
				e.Graphics.ReleaseHdc(hdc2);
				e.Graphics.Flush(FlushIntention.Sync);
			}
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x000F4F5C File Offset: 0x000F315C
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (!base.DesignMode)
			{
				TabPage tabPage = this.method_7();
				this.method_10((tabPage == null) ? -1 : base.TabPages.IndexOf(tabPage));
			}
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x0001677D File Offset: 0x0001497D
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			if (!base.DesignMode)
			{
				this.method_10(-1);
			}
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x00016798 File Offset: 0x00014998
		protected override void OnSelectedIndexChanged(EventArgs e)
		{
			base.OnSelectedIndexChanged(e);
			if (base.SelectedIndex != -1)
			{
				this.method_25(base.SelectedTab);
			}
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x000167B8 File Offset: 0x000149B8
		protected override void OnDeselected(TabControlEventArgs e)
		{
			base.OnDeselected(e);
			base.Invalidate();
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x000F4F9C File Offset: 0x000F319C
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag;
			bool result;
			if (!(flag = base.ProcessCmdKey(ref msg, keyData)))
			{
				if (keyData != (Keys.LButton | Keys.Back | Keys.Control) && keyData != (Keys.LButton | Keys.Back | Keys.Shift | Keys.Control))
				{
					if (keyData == (Keys.LButton | Keys.Space | Keys.Control) || keyData == (Keys.RButton | Keys.Space | Keys.Control))
					{
						base.SelectedTab = this.method_22((keyData & Keys.Next) == Keys.Next, true);
						base.Focus();
						result = true;
					}
					else
					{
						result = flag;
					}
				}
				else
				{
					base.SelectedTab = this.method_22((keyData & Keys.Shift) == Keys.None, true);
					base.Focus();
					result = true;
				}
			}
			else
			{
				result = flag;
			}
			return result;
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x000F502C File Offset: 0x000F322C
		protected override bool ProcessMnemonic(char charCode)
		{
			bool result;
			foreach (TabPage tabPage in base.TabPages)
			{
				if (tabPage.Enabled && Control.IsMnemonic(charCode, tabPage.Text))
				{
					base.SelectedTab = tabPage;
					result = true;
					return result;
				}
			}
			result = base.ProcessMnemonic(charCode);
			return result;
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x000F50B4 File Offset: 0x000F32B4
		protected override void OnKeyDown(KeyEventArgs e)
		{
			if (this.Focused)
			{
				Keys keyCode = e.KeyCode;
				if (keyCode != Keys.Return)
				{
					switch (keyCode)
					{
					case Keys.Space:
						break;
					case Keys.Prior:
					case Keys.Next:
						goto IL_FC;
					case Keys.End:
					{
						e.Handled = true;
						TabPage tabPage = this.method_21();
						if (tabPage != null)
						{
							base.SelectedTab = tabPage;
						}
						base.Focus();
						goto IL_FC;
					}
					case Keys.Home:
					{
						e.Handled = true;
						TabPage tabPage = this.method_20();
						if (tabPage != null)
						{
							base.SelectedTab = tabPage;
						}
						base.Focus();
						goto IL_FC;
					}
					case Keys.Left:
					case Keys.Up:
					case Keys.Right:
					case Keys.Down:
						if (this.method_1() == TabAppearance.Normal)
						{
							e.Handled = this.method_26(e.KeyCode);
							goto IL_FC;
						}
						goto IL_FC;
					default:
						goto IL_FC;
					}
				}
				if (this.method_1() != TabAppearance.Normal)
				{
					TabPage tabPage2 = this.method_8();
					if (tabPage2 != null)
					{
						e.Handled = !tabPage2.Enabled;
						if (e.Handled)
						{
							SystemSounds.Beep.Play();
						}
					}
				}
			}
			IL_FC:
			base.OnKeyDown(e);
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x000F51C4 File Offset: 0x000F33C4
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		protected override void WndProc(ref Message m)
		{
			int msg = m.Msg;
			if (msg <= 276)
			{
				if (msg != 20)
				{
					if (msg == 276)
					{
						base.Invalidate();
					}
				}
				else
				{
					m.Msg = 0;
					m.Result = IntPtr.Zero;
				}
			}
			else if (msg != 513)
			{
				if (msg == 794)
				{
					base.Invalidate(true);
				}
			}
			else
			{
				TabPage tabPage = this.method_7();
				if (tabPage != null && !tabPage.Enabled)
				{
					m.Msg = 0;
				}
			}
			base.WndProc(ref m);
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x000F5258 File Offset: 0x000F3458
		private void method_12(Graphics graphics_0, int int_1)
		{
			if (int_1 != -1)
			{
				TabAlignment arg_12_0 = base.Alignment;
				Bitmap bitmap = this.method_18(int_1);
				Rectangle rect = new Rectangle(Point.Empty, bitmap.Size);
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					IntPtr hdc = graphics.GetHdc();
					IntPtr hbitmap = bitmap.GetHbitmap();
					IntPtr intPtr = Class831.CreateCompatibleDC(hdc);
					IntPtr intptr_ = Class831.SelectObject(intPtr, hbitmap);
					if (this.method_0() == TabDrawMode.Normal)
					{
						using (Graphics graphics2 = Graphics.FromHdc(intPtr))
						{
							DrawItemEventArgs e = new DrawItemEventArgs(graphics2, this.Font, rect, int_1, DrawItemState.Default);
							this.OnDrawItem(e);
						}
					}
					Class831.BitBlt(hdc, 0, 0, rect.Width, rect.Height, intPtr, 0, 0, 13369376);
					Class831.SelectObject(intptr_, hbitmap);
					Class831.DeleteDC(intPtr);
					Class831.DeleteObject(hbitmap);
					graphics.ReleaseHdc(hdc);
					graphics.Flush(FlushIntention.Sync);
				}
				switch (base.Alignment)
				{
				case TabAlignment.Left:
					bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
					break;
				case TabAlignment.Right:
					bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
					break;
				}
				Rectangle tabRect = base.GetTabRect(int_1);
				if (int_1 == base.SelectedIndex && this.method_1() == TabAppearance.Normal)
				{
					tabRect.Inflate(2, 2);
				}
				if (this.method_0() == TabDrawMode.OwnerDrawFixed)
				{
					bool flag = false;
					if (flag = (this.RightToLeft == RightToLeft.Yes && this.RightToLeftLayout))
					{
						bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
					}
					IntPtr hbitmap2 = bitmap.GetHbitmap();
					using (Graphics graphics3 = Graphics.FromImage(bitmap))
					{
						IntPtr hdc2 = graphics3.GetHdc();
						IntPtr intPtr2 = Class831.CreateCompatibleDC(hdc2);
						IntPtr intptr_2 = Class831.SelectObject(intPtr2, hbitmap2);
						Graphics graphics4 = Graphics.FromHdc(intPtr2);
						graphics4.TranslateTransform(-(float)tabRect.Left, -(float)tabRect.Top);
						DrawItemEventArgs e2 = new DrawItemEventArgs(graphics4, this.Font, tabRect, int_1, DrawItemState.Default);
						this.OnDrawItem(e2);
						Class831.BitBlt(hdc2, 0, 0, tabRect.Width, tabRect.Height, intPtr2, 0, 0, 13369376);
						graphics4.ResetTransform();
						Class831.SelectObject(intptr_2, hbitmap2);
						graphics4.Dispose();
						Class831.DeleteObject(intPtr2);
						graphics3.ReleaseHdc(hdc2);
					}
					Class831.DeleteObject(hbitmap2);
					if (flag)
					{
						bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
					}
				}
				graphics_0.DrawImage(bitmap, tabRect);
				bitmap.Dispose();
				if (this.method_1() == TabAppearance.FlatButtons)
				{
					using (Pen pen = new Pen(Control1.smethod_1(this.BackColor, 25)))
					{
						graphics_0.DrawLine(pen, tabRect.Right + 4, tabRect.Top, tabRect.Right + 4, tabRect.Bottom);
						pen.Color = Control1.smethod_2(this.BackColor, 80);
						graphics_0.DrawLine(pen, tabRect.Right + 5, tabRect.Top, tabRect.Right + 5, tabRect.Bottom);
					}
				}
				tabRect.Inflate(-2, -2);
				if (this.Focused && this.ShowFocusCues && int_1 == base.SelectedIndex)
				{
					ControlPaint.DrawFocusRectangle(graphics_0, tabRect);
				}
				graphics_0.Flush(FlushIntention.Sync);
			}
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000F55D8 File Offset: 0x000F37D8
		private void method_13(Graphics graphics_0, Rectangle rectangle_0, int int_1)
		{
			if (int_1 != -1)
			{
				if (this.method_11())
				{
					VisualStyleElement element = this.method_17(int_1);
					VisualStyleRenderer visualStyleRenderer = new VisualStyleRenderer(element);
					visualStyleRenderer.DrawBackground(graphics_0, rectangle_0);
				}
				else
				{
					Color color = this.method_2();
					if (base.SelectedIndex == int_1)
					{
						color = this.method_3();
					}
					Color color2 = Control1.smethod_2(color, 40);
					Color color3 = Control1.smethod_2(color, 80);
					Color color4 = Control1.smethod_1(color, 25);
					Color color5 = Control1.smethod_1(color, 40);
					if (color.A != 0)
					{
						Rectangle rect = rectangle_0;
						rect.Inflate(-2, -2);
						rect.Height += 2;
						using (SolidBrush solidBrush = new SolidBrush(color))
						{
							graphics_0.FillRectangle(solidBrush, rect);
						}
					}
					using (Pen pen = new Pen(color3))
					{
						switch (base.Alignment)
						{
						case TabAlignment.Top:
						case TabAlignment.Left:
							graphics_0.DrawLines(pen, new Point[]
							{
								new Point(rectangle_0.Left, rectangle_0.Bottom),
								new Point(rectangle_0.Left, rectangle_0.Top + 2),
								new Point(rectangle_0.Left + 2, rectangle_0.Top),
								new Point(rectangle_0.Right - 3, rectangle_0.Top)
							});
							pen.Color = color2;
							graphics_0.DrawLines(pen, new Point[]
							{
								new Point(rectangle_0.Left + 1, rectangle_0.Bottom),
								new Point(rectangle_0.Left + 1, rectangle_0.Top + 2),
								new Point(rectangle_0.Left + 2, rectangle_0.Top + 1),
								new Point(rectangle_0.Right - 3, rectangle_0.Top + 1)
							});
							pen.Color = color4;
							graphics_0.DrawLines(pen, new Point[]
							{
								new Point(rectangle_0.Right - 2, rectangle_0.Top + 1),
								new Point(rectangle_0.Right - 2, rectangle_0.Bottom)
							});
							pen.Color = color5;
							graphics_0.DrawLines(pen, new Point[]
							{
								new Point(rectangle_0.Right - 1, rectangle_0.Top + 2),
								new Point(rectangle_0.Right - 1, rectangle_0.Bottom)
							});
							break;
						case TabAlignment.Bottom:
						case TabAlignment.Right:
							graphics_0.DrawLines(pen, new Point[]
							{
								new Point(rectangle_0.Left, rectangle_0.Bottom),
								new Point(rectangle_0.Left, rectangle_0.Top + 2)
							});
							pen.Color = color2;
							graphics_0.DrawLines(pen, new Point[]
							{
								new Point(rectangle_0.Left + 1, rectangle_0.Bottom),
								new Point(rectangle_0.Left + 1, rectangle_0.Top + 1)
							});
							pen.Color = color5;
							graphics_0.DrawLines(pen, new Point[]
							{
								new Point(rectangle_0.Left + 2, rectangle_0.Top),
								new Point(rectangle_0.Right - 3, rectangle_0.Top),
								new Point(rectangle_0.Right - 1, rectangle_0.Top + 2),
								new Point(rectangle_0.Right - 1, rectangle_0.Bottom)
							});
							pen.Color = color4;
							graphics_0.DrawLines(pen, new Point[]
							{
								new Point(rectangle_0.Left + 2, rectangle_0.Top + 1),
								new Point(rectangle_0.Right - 3, rectangle_0.Top + 1),
								new Point(rectangle_0.Right - 2, rectangle_0.Top + 2),
								new Point(rectangle_0.Right - 2, rectangle_0.Bottom)
							});
							break;
						}
					}
				}
				graphics_0.Flush(FlushIntention.Sync);
			}
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x000F5B2C File Offset: 0x000F3D2C
		private void method_14(Graphics graphics_0, Rectangle rectangle_0, int int_1)
		{
			Color color = this.method_2();
			TabPage tabPage = base.TabPages[int_1];
			if (base.SelectedIndex == int_1)
			{
				color = this.method_3();
			}
			bool flag;
			Color color2 = (flag = (int_1 == base.SelectedIndex || tabPage == this.method_8())) ? Control1.smethod_1(color, 25) : Control1.smethod_2(color, 40);
			Color color3 = flag ? Control1.smethod_1(color, 40) : Control1.smethod_2(color, 80);
			Color color4 = flag ? Control1.smethod_2(color, 40) : Control1.smethod_1(color, 25);
			Color color5 = flag ? Control1.smethod_2(color, 80) : Control1.smethod_1(color, 40);
			using (SolidBrush solidBrush = new SolidBrush(color))
			{
				graphics_0.FillRectangle(solidBrush, rectangle_0);
			}
			using (Pen pen = new Pen(color3))
			{
				switch (base.Alignment)
				{
				case TabAlignment.Top:
				case TabAlignment.Left:
					graphics_0.DrawLines(pen, new Point[]
					{
						new Point(rectangle_0.Left, rectangle_0.Bottom - 1),
						new Point(rectangle_0.Left, rectangle_0.Top),
						new Point(rectangle_0.Right - 1, rectangle_0.Top)
					});
					pen.Color = color5;
					graphics_0.DrawLines(pen, new Point[]
					{
						new Point(rectangle_0.Right - 1, rectangle_0.Top),
						new Point(rectangle_0.Right - 1, rectangle_0.Bottom - 1),
						new Point(rectangle_0.Left, rectangle_0.Bottom - 1)
					});
					pen.Color = color2;
					graphics_0.DrawLines(pen, new Point[]
					{
						new Point(rectangle_0.Left + 1, rectangle_0.Bottom - 2),
						new Point(rectangle_0.Left + 1, rectangle_0.Top + 1),
						new Point(rectangle_0.Right - 2, rectangle_0.Top + 1)
					});
					pen.Color = color4;
					graphics_0.DrawLines(pen, new Point[]
					{
						new Point(rectangle_0.Right - 2, rectangle_0.Top + 1),
						new Point(rectangle_0.Right - 2, rectangle_0.Bottom - 2),
						new Point(rectangle_0.Left + 1, rectangle_0.Bottom - 2)
					});
					break;
				case TabAlignment.Bottom:
				case TabAlignment.Right:
					graphics_0.DrawLines(pen, new Point[]
					{
						new Point(rectangle_0.Left, rectangle_0.Top),
						new Point(rectangle_0.Left, rectangle_0.Bottom - 1),
						new Point(rectangle_0.Right - 1, rectangle_0.Bottom - 1)
					});
					pen.Color = color5;
					graphics_0.DrawLines(pen, new Point[]
					{
						new Point(rectangle_0.Right - 1, rectangle_0.Bottom - 1),
						new Point(rectangle_0.Right - 1, rectangle_0.Top),
						new Point(rectangle_0.Left, rectangle_0.Top)
					});
					pen.Color = color2;
					graphics_0.DrawLines(pen, new Point[]
					{
						new Point(rectangle_0.Left + 1, rectangle_0.Top + 1),
						new Point(rectangle_0.Left + 1, rectangle_0.Bottom - 2),
						new Point(rectangle_0.Right - 2, rectangle_0.Bottom - 2)
					});
					pen.Color = color4;
					graphics_0.DrawLines(pen, new Point[]
					{
						new Point(rectangle_0.Right - 2, rectangle_0.Bottom - 2),
						new Point(rectangle_0.Right - 2, rectangle_0.Top + 1),
						new Point(rectangle_0.Left + 1, rectangle_0.Top + 1)
					});
					break;
				}
			}
			graphics_0.Flush(FlushIntention.Sync);
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x000F6084 File Offset: 0x000F4284
		private void method_15(Graphics graphics_0, Rectangle rectangle_0, int int_1)
		{
			Color color = this.method_2();
			TabPage tabPage = base.TabPages[int_1];
			if (base.SelectedIndex == int_1)
			{
				color = this.method_3();
			}
			bool flag = false;
			Color color2 = (flag = (int_1 == base.SelectedIndex)) ? Control1.smethod_1(color, 25) : Control1.smethod_2(color, 40);
			Color color3 = flag ? Control1.smethod_1(color, 40) : Control1.smethod_2(color, 80);
			Color color4 = flag ? Control1.smethod_2(color, 40) : Control1.smethod_1(color, 25);
			Color color5 = flag ? Control1.smethod_2(color, 80) : Control1.smethod_1(color, 25);
			using (SolidBrush solidBrush = new SolidBrush(color))
			{
				graphics_0.FillRectangle(solidBrush, rectangle_0);
			}
			if (tabPage == this.method_8() || int_1 == base.SelectedIndex || (int_1 == this.method_9() && base.HotTrack))
			{
				using (Pen pen = new Pen(color3))
				{
					switch (base.Alignment)
					{
					case TabAlignment.Top:
					case TabAlignment.Left:
						graphics_0.DrawLines(pen, new Point[]
						{
							new Point(rectangle_0.Left, rectangle_0.Bottom - 1),
							new Point(rectangle_0.Left, rectangle_0.Top),
							new Point(rectangle_0.Right - 1, rectangle_0.Top)
						});
						pen.Color = color5;
						graphics_0.DrawLines(pen, new Point[]
						{
							new Point(rectangle_0.Right - 1, rectangle_0.Top),
							new Point(rectangle_0.Right - 1, rectangle_0.Bottom - 1),
							new Point(rectangle_0.Left, rectangle_0.Bottom - 1)
						});
						if (flag)
						{
							pen.Color = color2;
							graphics_0.DrawLines(pen, new Point[]
							{
								new Point(rectangle_0.Left + 1, rectangle_0.Bottom - 2),
								new Point(rectangle_0.Left + 1, rectangle_0.Top + 1),
								new Point(rectangle_0.Right - 2, rectangle_0.Top + 1)
							});
							pen.Color = color4;
							graphics_0.DrawLines(pen, new Point[]
							{
								new Point(rectangle_0.Right - 2, rectangle_0.Top + 1),
								new Point(rectangle_0.Right - 2, rectangle_0.Bottom - 2),
								new Point(rectangle_0.Left + 1, rectangle_0.Bottom - 2)
							});
						}
						break;
					case TabAlignment.Bottom:
					case TabAlignment.Right:
						graphics_0.DrawLines(pen, new Point[]
						{
							new Point(rectangle_0.Left, rectangle_0.Top),
							new Point(rectangle_0.Left, rectangle_0.Bottom - 1),
							new Point(rectangle_0.Right - 1, rectangle_0.Bottom - 1)
						});
						pen.Color = color5;
						graphics_0.DrawLines(pen, new Point[]
						{
							new Point(rectangle_0.Right - 1, rectangle_0.Bottom - 1),
							new Point(rectangle_0.Right - 1, rectangle_0.Top),
							new Point(rectangle_0.Left, rectangle_0.Top)
						});
						if (flag)
						{
							pen.Color = color2;
							graphics_0.DrawLines(pen, new Point[]
							{
								new Point(rectangle_0.Left + 1, rectangle_0.Top + 1),
								new Point(rectangle_0.Left + 1, rectangle_0.Bottom - 2),
								new Point(rectangle_0.Right - 2, rectangle_0.Bottom - 2)
							});
							pen.Color = color4;
							graphics_0.DrawLines(pen, new Point[]
							{
								new Point(rectangle_0.Right - 2, rectangle_0.Bottom - 2),
								new Point(rectangle_0.Right - 2, rectangle_0.Top + 1),
								new Point(rectangle_0.Left + 1, rectangle_0.Top + 1)
							});
						}
						break;
					}
				}
			}
			graphics_0.Flush(FlushIntention.Sync);
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x000F6610 File Offset: 0x000F4810
		private void method_16(Graphics graphics_0)
		{
			if (this.method_1() == TabAppearance.Normal)
			{
				Rectangle displayRectangle = this.DisplayRectangle;
				displayRectangle.Inflate(4, 4);
				switch (base.Alignment)
				{
				case TabAlignment.Top:
					displayRectangle.Y++;
					displayRectangle.Height--;
					break;
				case TabAlignment.Bottom:
					displayRectangle.Height++;
					break;
				case TabAlignment.Left:
					displayRectangle.X++;
					displayRectangle.Width--;
					break;
				case TabAlignment.Right:
					displayRectangle.Width++;
					break;
				}
				if (this.method_11())
				{
					VisualStyleElement normal = VisualStyleElement.Tab.Pane.Normal;
					VisualStyleRenderer visualStyleRenderer = new VisualStyleRenderer(normal);
					visualStyleRenderer.DrawBackground(graphics_0, displayRectangle);
				}
				else
				{
					Rectangle rect = Rectangle.Empty;
					if (base.SelectedIndex != -1)
					{
						rect = base.GetTabRect(base.SelectedIndex);
						rect.Inflate(2, 2);
					}
					graphics_0.SetClip(rect, CombineMode.Exclude);
					Rectangle displayRectangle2 = this.DisplayRectangle;
					displayRectangle2.Inflate(4, 4);
					if (base.Alignment <= TabAlignment.Bottom)
					{
						displayRectangle2.Height--;
						if (base.Alignment == TabAlignment.Top)
						{
							displayRectangle2.Y++;
						}
					}
					else
					{
						displayRectangle2.Width--;
						if (base.Alignment == TabAlignment.Left)
						{
							displayRectangle2.X++;
						}
					}
					Color color = (base.SelectedIndex == -1) ? this.BackColor : (base.SelectedTab.UseVisualStyleBackColor ? Control.DefaultBackColor : base.SelectedTab.BackColor);
					using (SolidBrush solidBrush = new SolidBrush(color))
					{
						graphics_0.FillRectangle(solidBrush, displayRectangle2);
					}
					Color color2 = Control1.smethod_2(color, 40);
					Color color3 = Control1.smethod_2(color, 80);
					Color color4 = Control1.smethod_1(color, 25);
					Color color5 = Control1.smethod_1(color, 40);
					using (Pen pen = new Pen(color3))
					{
						graphics_0.DrawLines(pen, new Point[]
						{
							new Point(displayRectangle2.Left, displayRectangle2.Bottom - 2),
							new Point(displayRectangle2.Left, displayRectangle2.Top),
							new Point(displayRectangle2.Right - 2, displayRectangle2.Top)
						});
						pen.Color = color2;
						graphics_0.DrawLines(pen, new Point[]
						{
							new Point(displayRectangle2.Left + 1, displayRectangle2.Bottom - 3),
							new Point(displayRectangle2.Left + 1, displayRectangle2.Top + 1),
							new Point(displayRectangle2.Right - 3, displayRectangle2.Top + 1)
						});
						pen.Color = color5;
						graphics_0.DrawLines(pen, new Point[]
						{
							new Point(displayRectangle2.Right - 1, displayRectangle2.Top),
							new Point(displayRectangle2.Right - 1, displayRectangle2.Bottom - 1),
							new Point(displayRectangle2.Left, displayRectangle2.Bottom - 1)
						});
						pen.Color = color4;
						graphics_0.DrawLines(pen, new Point[]
						{
							new Point(displayRectangle2.Right - 2, displayRectangle2.Top + 1),
							new Point(displayRectangle2.Right - 2, displayRectangle2.Bottom - 2),
							new Point(displayRectangle2.Left + 1, displayRectangle2.Bottom - 2)
						});
					}
					graphics_0.ResetClip();
				}
			}
			graphics_0.Flush(FlushIntention.Sync);
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x000F6A70 File Offset: 0x000F4C70
		private VisualStyleElement method_17(int int_1)
		{
			bool flag = base.Alignment >= TabAlignment.Left;
			Rectangle tabRect = base.GetTabRect(int_1);
			bool flag2 = flag ? (tabRect.Top <= 3) : (tabRect.Left <= 3);
			bool flag3 = flag ? (tabRect.Bottom >= base.Height - 4) : (tabRect.Right >= base.Width - 4);
			bool flag4 = flag ? ((base.Alignment == TabAlignment.Left) ? (tabRect.Left <= 3) : (tabRect.Right >= base.Width - 3)) : (tabRect.Top <= 3);
			int num = 1;
			TabItemState state = TabItemState.Normal;
			if (flag2)
			{
				num++;
			}
			if (flag3)
			{
				num += 2;
			}
			if (flag4)
			{
				num += 4;
			}
			if (int_1 == base.SelectedIndex)
			{
				state = TabItemState.Selected;
			}
			else
			{
				TabPage tabPage = base.TabPages[int_1];
				if (tabPage.Enabled)
				{
					if (base.TabPages[int_1] == this.method_7() && base.HotTrack && !base.DesignMode)
					{
						state = TabItemState.Hot;
					}
				}
				else
				{
					state = TabItemState.Disabled;
				}
			}
			return VisualStyleElement.CreateElement("TAB", num, (int)state);
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x000F6BBC File Offset: 0x000F4DBC
		private Bitmap method_18(int int_1)
		{
			Rectangle tabRect = base.GetTabRect(int_1);
			if (this.method_1() == TabAppearance.Normal && int_1 == base.SelectedIndex)
			{
				tabRect.Inflate(2, 2);
			}
			Bitmap bitmap = new Bitmap(tabRect.Width, tabRect.Height, PixelFormat.Format32bppPArgb);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				GraphicsContainer container = graphics.BeginContainer();
				if (this.method_24(int_1) && (this.BackColor.A < 255 || !this.method_5()))
				{
					if (this.bitmap_0 == null)
					{
						this.method_19();
					}
					if (this.bitmap_0 != null)
					{
						graphics.DrawImage(this.bitmap_0, 0, 0, tabRect, GraphicsUnit.Pixel);
					}
				}
				else
				{
					graphics.Clear(this.BackColor);
				}
				graphics.EndContainer(container);
				graphics.Flush(FlushIntention.Sync);
			}
			switch (base.Alignment)
			{
			case TabAlignment.Bottom:
				bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
				break;
			case TabAlignment.Left:
				bitmap.RotateFlip(RotateFlipType.Rotate90FlipX);
				break;
			case TabAlignment.Right:
				bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
				break;
			}
			bitmap = new Bitmap(bitmap);
			using (Graphics graphics2 = Graphics.FromImage(bitmap))
			{
				GraphicsContainer container2 = graphics2.BeginContainer();
				switch (this.method_1())
				{
				case TabAppearance.Buttons:
					this.method_14(graphics2, new Rectangle(Point.Empty, bitmap.Size), int_1);
					break;
				case TabAppearance.FlatButtons:
					this.method_15(graphics2, new Rectangle(Point.Empty, bitmap.Size), int_1);
					break;
				default:
					this.method_13(graphics2, new Rectangle(Point.Empty, bitmap.Size), int_1);
					break;
				}
				graphics2.EndContainer(container2);
				graphics2.Flush(FlushIntention.Sync);
			}
			if (base.Alignment == TabAlignment.Bottom)
			{
				bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
			}
			else if (base.Alignment == TabAlignment.Left)
			{
				bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
			}
			if (this.RightToLeftLayout && this.RightToLeft == RightToLeft.Yes && this.method_0() == TabDrawMode.Normal)
			{
				bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
			}
			return bitmap;
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x000F6DF4 File Offset: 0x000F4FF4
		private void method_19()
		{
			if (base.Parent != null && base.Created && base.Width > 0 && base.Height > 0)
			{
				if (this.bitmap_0 == null || !this.bitmap_0.Size.Equals(base.Size))
				{
					this.bitmap_0 = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppPArgb);
				}
				using (Graphics graphics = Graphics.FromImage(this.bitmap_0))
				{
					GraphicsContainer container = graphics.BeginContainer();
					Rectangle bounds = base.Bounds;
					graphics.TranslateTransform(-(float)base.Left, -(float)base.Top);
					PaintEventArgs e = new PaintEventArgs(graphics, bounds);
					base.InvokePaintBackground(base.Parent, e);
					base.InvokePaint(base.Parent, e);
					graphics.ResetTransform();
					graphics.EndContainer(container);
					graphics.Flush(FlushIntention.Sync);
				}
				if (this.RightToLeft == RightToLeft.Yes && this.RightToLeftLayout)
				{
					this.bitmap_0.RotateFlip(RotateFlipType.RotateNoneFlipX);
				}
			}
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x000F6F30 File Offset: 0x000F5130
		private TabPage method_20()
		{
			TabPage result;
			if (base.TabCount > 0)
			{
				for (int i = 0; i < base.TabCount; i++)
				{
					TabPage tabPage = base.TabPages[i];
					if (tabPage.Enabled)
					{
						result = tabPage;
						return result;
					}
				}
			}
			result = null;
			return result;
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x000F6F80 File Offset: 0x000F5180
		private TabPage method_21()
		{
			TabPage result;
			if (base.TabCount > 0)
			{
				for (int i = base.TabCount - 1; i >= 0; i--)
				{
					TabPage tabPage = base.TabPages[i];
					if (tabPage.Enabled)
					{
						result = tabPage;
						return result;
					}
				}
			}
			result = null;
			return result;
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x000F6FD4 File Offset: 0x000F51D4
		private TabPage method_22(bool bool_4, bool bool_5)
		{
			TabPage result;
			if (bool_4)
			{
				for (int i = base.SelectedIndex + 1; i <= base.TabCount - 1; i++)
				{
					if (base.TabPages[i].Enabled)
					{
						result = base.TabPages[i];
						return result;
					}
				}
				if (bool_5)
				{
					for (int j = 0; j <= base.SelectedIndex; j++)
					{
						if (base.TabPages[j].Enabled)
						{
							result = base.TabPages[j];
							return result;
						}
					}
				}
			}
			else
			{
				for (int k = base.SelectedIndex - 1; k >= 0; k--)
				{
					if (base.TabPages[k].Enabled)
					{
						result = base.TabPages[k];
						return result;
					}
				}
				if (bool_5)
				{
					for (int l = base.TabCount - 1; l > base.SelectedIndex; l--)
					{
						if (base.TabPages[l].Enabled)
						{
							result = base.TabPages[l];
							return result;
						}
					}
				}
			}
			result = null;
			return result;
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000F710C File Offset: 0x000F530C
		private TabPage method_23(Point point_0)
		{
			Class831.Struct60 @struct = new Class831.Struct60(point_0.X, point_0.Y);
			int num = Class831.SendMessage_1(base.Handle, 4877, IntPtr.Zero, ref @struct).ToInt32();
			TabPage result;
			if (num >= 0 && num < base.TabCount)
			{
				result = base.TabPages[num];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x000F717C File Offset: 0x000F537C
		private bool method_24(int int_1)
		{
			bool result;
			if (this.method_11())
			{
				VisualStyleElement element = this.method_17(int_1);
				VisualStyleRenderer visualStyleRenderer = new VisualStyleRenderer(element);
				result = visualStyleRenderer.IsBackgroundPartiallyTransparent();
			}
			else if (this.method_1() == TabAppearance.Normal)
			{
				result = true;
			}
			else if (int_1 == base.SelectedIndex)
			{
				result = (this.method_3().A < 255);
			}
			else
			{
				result = (this.method_2().A < 255);
			}
			return result;
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x000F71FC File Offset: 0x000F53FC
		private static void smethod_0(IntPtr intptr_0, string string_0, Font font_0, Color color_4, Rectangle rectangle_0, int int_1)
		{
			IntPtr intPtr = font_0.ToHfont();
			IntPtr intptr_ = Class831.SelectObject(intptr_0, intPtr);
			int num = Class831.SetBkMode(intptr_0, 1);
			int num2 = Class831.SetTextColor(intptr_0, ColorTranslator.ToWin32(color_4));
			Class831.DrawState(intptr_0, IntPtr.Zero, IntPtr.Zero, Marshal.StringToHGlobalAnsi(string_0), new IntPtr(string_0.Length), rectangle_0.Left, rectangle_0.Top, rectangle_0.Width, rectangle_0.Height, int_1);
			Class831.SetTextColor(intptr_0, num2);
			Class831.SetBkMode(intptr_0, num);
			Class831.SelectObject(intptr_0, intptr_);
			Class831.DeleteObject(intPtr);
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x000F728C File Offset: 0x000F548C
		private static Color smethod_1(Color color_4, int int_1)
		{
			if (int_1 < 0 || int_1 > 100)
			{
				throw new ArgumentOutOfRangeException("percent");
			}
			int red = (int)color_4.R - (int)(color_4.R / 100) * int_1;
			int green = (int)color_4.G - (int)(color_4.G / 100) * int_1;
			int blue = (int)color_4.B - (int)(color_4.B / 100) * int_1;
			return Color.FromArgb(255, red, green, blue);
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x000F7304 File Offset: 0x000F5504
		private static Color smethod_2(Color color_4, int int_1)
		{
			if (int_1 < 0 || int_1 > 100)
			{
				throw new ArgumentOutOfRangeException("percent");
			}
			int red = (int)color_4.R + (int)((255f - (float)color_4.R) / 100f * (float)int_1);
			int green = (int)color_4.G + (int)((255f - (float)color_4.G) / 100f * (float)int_1);
			int blue = (int)color_4.B + (int)((255f - (float)color_4.B) / 100f * (float)int_1);
			return Color.FromArgb(255, red, green, blue);
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x000F73A0 File Offset: 0x000F55A0
		private void method_25(TabPage tabPage_0)
		{
			PropertyInfo property = tabPage_0.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			if (!(property == null))
			{
				property.SetValue(tabPage_0, this.bool_2, null);
			}
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000F73E0 File Offset: 0x000F55E0
		private bool method_26(Keys keys_0)
		{
			bool result;
			if (this.method_1() == TabAppearance.Normal)
			{
				if (base.SelectedIndex == -1)
				{
					base.SelectedTab = this.method_20();
					result = true;
					return result;
				}
				Rectangle tabRect = base.GetTabRect(base.SelectedIndex);
				bool flag = base.Alignment >= TabAlignment.Left;
				if (this.RightToLeft == RightToLeft.Yes && this.RightToLeftLayout)
				{
					if (keys_0 == Keys.Left)
					{
						keys_0 = Keys.Right;
					}
					else if (keys_0 == Keys.Right)
					{
						keys_0 = Keys.Left;
					}
				}
				Point point;
				Point p;
				switch (keys_0)
				{
				case Keys.Left:
					if (!flag)
					{
						TabPage tabPage = this.method_22(false, false);
						if (tabPage != null)
						{
							base.SelectedTab = tabPage;
						}
						result = true;
						return result;
					}
					point = new Point(tabRect.Left - 3, tabRect.Top + tabRect.Height / 2);
					p = (flag ? new Point(0, -3) : Point.Empty);
					break;
				case Keys.Up:
					if (flag)
					{
						TabPage tabPage = this.method_22(false, false);
						if (tabPage != null)
						{
							base.SelectedTab = tabPage;
						}
						result = true;
						return result;
					}
					point = new Point(tabRect.Left + tabRect.Width / 2, tabRect.Top - 3);
					p = (flag ? Point.Empty : new Point(-3, 0));
					break;
				case Keys.Right:
					if (!flag)
					{
						TabPage tabPage = this.method_22(true, false);
						if (tabPage != null)
						{
							base.SelectedTab = tabPage;
						}
						result = true;
						return result;
					}
					point = new Point(tabRect.Right + 3, tabRect.Top + tabRect.Height / 2);
					p = (flag ? new Point(0, -3) : Point.Empty);
					break;
				case Keys.Down:
					if (flag)
					{
						TabPage tabPage = this.method_22(true, false);
						if (tabPage != null)
						{
							base.SelectedTab = tabPage;
						}
						result = true;
						return result;
					}
					point = new Point(tabRect.Left + tabRect.Width / 2, tabRect.Bottom + 3);
					p = (flag ? Point.Empty : new Point(-3, 0));
					break;
				default:
					result = false;
					return result;
				}
				while (base.ClientRectangle.Contains(point) && !this.DisplayRectangle.Contains(point))
				{
					TabPage tabPage = this.method_23(point);
					if (tabPage != null && tabPage.Enabled)
					{
						base.SelectedTab = tabPage;
						result = true;
						return result;
					}
					if (p.IsEmpty)
					{
						result = true;
						return result;
					}
					point.Offset(p);
				}
			}
			result = true;
			return result;
		}

		// Token: 0x04001366 RID: 4966
		private TabDrawMode tabDrawMode_0;

		// Token: 0x04001367 RID: 4967
		private Color color_0 = Color.Empty;

		// Token: 0x04001368 RID: 4968
		private bool bool_0;

		// Token: 0x04001369 RID: 4969
		private int int_0 = -1;

		// Token: 0x0400136A RID: 4970
		private bool bool_1;

		// Token: 0x0400136B RID: 4971
		private Color color_1 = SystemColors.Control;

		// Token: 0x0400136C RID: 4972
		private Color color_2 = SystemColors.Control;

		// Token: 0x0400136D RID: 4973
		private Color color_3 = SystemColors.HotTrack;

		// Token: 0x0400136E RID: 4974
		private Bitmap bitmap_0;

		// Token: 0x0400136F RID: 4975
		private bool bool_2 = false;

		// Token: 0x04001370 RID: 4976
		private bool bool_3;
	}
}
