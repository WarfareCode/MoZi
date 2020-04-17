using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns14;

namespace ns15
{
	// Token: 0x02000490 RID: 1168
	public sealed class Class670 : Panel
	{
		// Token: 0x06001E25 RID: 7717 RVA: 0x00012583 File Offset: 0x00010783
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void method_0(Delegate34 delegate34_1)
		{
			this.delegate34_0 = (Delegate34)Delegate.Combine(this.delegate34_0, delegate34_1);
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x000C2E30 File Offset: 0x000C1030
		private void method_1()
		{
			this.icontainer_0 = new Container();
			ResourceManager resourceManager = new ResourceManager(typeof(Class670));
			this.labelTitle = new Label();
			this.imageList_0 = new ImageList(this.icontainer_0);
			base.SuspendLayout();
			this.labelTitle.Cursor = Cursors.Default;
			this.labelTitle.Dock = DockStyle.Top;
			this.labelTitle.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.labelTitle.ForeColor = Color.Navy;
			this.labelTitle.Location = new Point(114, 17);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new Size(200, 24);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Title";
			this.labelTitle.TextAlign = ContentAlignment.MiddleLeft;
			this.labelTitle.Paint += new PaintEventHandler(this.labelTitle_Paint);
			this.labelTitle.MouseUp += new MouseEventHandler(this.labelTitle_MouseUp);
			this.labelTitle.MouseMove += new MouseEventHandler(this.labelTitle_MouseMove);
			this.imageList_0.ColorDepth = ColorDepth.Depth32Bit;
			this.imageList_0.ImageSize = new Size(16, 16);
			this.imageList_0.ImageStream = (ImageListStreamer)resourceManager.GetObject("imageList.ImageStream", CultureInfo.InvariantCulture);
			this.imageList_0.TransparentColor = Color.Transparent;
			base.Controls.AddRange(new Control[]
			{
				this.labelTitle
			});
			base.ResumeLayout(false);
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x000C2FE0 File Offset: 0x000C11E0
		public Class670()
		{
			this.icontainer_0 = new Container();
			this.method_1();
			this.BackColor = Color.AliceBlue;
			this.int_0 = base.Height;
			this.colorMatrix_0 = new ColorMatrix();
			this.colorMatrix_0.Matrix00 = 0.333333343f;
			this.colorMatrix_0.Matrix01 = 0.333333343f;
			this.colorMatrix_0.Matrix02 = 0.333333343f;
			this.colorMatrix_0.Matrix10 = 0.333333343f;
			this.colorMatrix_0.Matrix11 = 0.333333343f;
			this.colorMatrix_0.Matrix12 = 0.333333343f;
			this.colorMatrix_0.Matrix20 = 0.333333343f;
			this.colorMatrix_0.Matrix21 = 0.333333343f;
			this.colorMatrix_0.Matrix22 = 0.333333343f;
			this.imageAttributes_0 = new ImageAttributes();
			this.imageAttributes_0.SetColorMatrix(this.colorMatrix_0, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x000C3108 File Offset: 0x000C1308
		public Enum144 method_2()
		{
			return this.enum144_0;
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x000C3120 File Offset: 0x000C1320
		public Color method_3()
		{
			return this.labelTitle.ForeColor;
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x000C313C File Offset: 0x000C133C
		public ImageList method_4()
		{
			return this.imageList_0;
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x000C3154 File Offset: 0x000C1354
		private bool method_5(int int_2, int int_3)
		{
			return this.labelTitle.Bounds.Contains(int_2, int_3);
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x000C3178 File Offset: 0x000C1378
		private void method_6()
		{
			switch (this.enum144_0)
			{
			case Enum144.const_0:
				base.Height = this.int_0;
				this.int_1 = 0;
				break;
			case Enum144.const_1:
				this.int_0 = base.Height;
				base.Height = this.labelTitle.Height;
				this.int_1 = 1;
				break;
			}
			this.labelTitle.Invalidate();
			this.vmethod_0(new EventArgs2(this));
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0001259C File Offset: 0x0001079C
		protected  void vmethod_0(EventArgs2 eventArgs2_0)
		{
			if (this.delegate34_0 != null)
			{
				this.delegate34_0(this, eventArgs2_0);
			}
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x000C31EC File Offset: 0x000C13EC
		private void labelTitle_Paint(object sender, PaintEventArgs e)
		{
			int num = 7;
			Rectangle bounds = this.labelTitle.Bounds;
			int num2 = 0;
			if (this.image_0 != null)
			{
				num2 = this.labelTitle.Height - 24;
				if (num2 < 0)
				{
					num2 = 0;
				}
				bounds.Offset(0, num2);
				bounds.Height -= num2;
			}
			e.Graphics.Clear(base.Parent.BackColor);
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddLine(bounds.Left + num, bounds.Top, bounds.Right - 14 - 1, bounds.Top);
			graphicsPath.AddArc(bounds.Right - 14 - 1, bounds.Top, 14, 14, 270f, 90f);
			graphicsPath.AddLine(bounds.Right, bounds.Top + num, bounds.Right, bounds.Bottom);
			graphicsPath.AddLine(bounds.Right, bounds.Bottom, bounds.Left - 1, bounds.Bottom);
			graphicsPath.AddArc(bounds.Left, bounds.Top, 14, 14, 180f, 90f);
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			if (base.Enabled)
			{
				LinearGradientBrush brush = new LinearGradientBrush(bounds, this.color_0, this.color_1, LinearGradientMode.Horizontal);
				e.Graphics.FillPath(brush, graphicsPath);
			}
			else
			{
				Class673 @class = new Class673();
				@class.method_1(this.color_0);
				@class.method_2(0f);
				Class673 class2 = new Class673();
				class2.method_1(this.color_1);
				class2.method_2(0f);
				LinearGradientBrush brush2 = new LinearGradientBrush(bounds, @class.method_0(), class2.method_0(), LinearGradientMode.Horizontal);
				e.Graphics.FillPath(brush2, graphicsPath);
			}
			GraphicsUnit srcUnit = GraphicsUnit.Display;
			int num3 = 2;
			if (this.image_0 != null)
			{
				num3 += this.image_0.Width + 2;
				RectangleF bounds2 = this.image_0.GetBounds(ref srcUnit);
				Rectangle destRect = new Rectangle(2, 2, this.image_0.Width, this.image_0.Height);
				if (base.Enabled)
				{
					e.Graphics.DrawImage(this.image_0, destRect, (int)bounds2.Left, (int)bounds2.Top, (int)bounds2.Width, (int)bounds2.Height, srcUnit);
				}
				else
				{
					e.Graphics.DrawImage(this.image_0, destRect, (int)bounds2.Left, (int)bounds2.Top, (int)bounds2.Width, (int)bounds2.Height, srcUnit, this.imageAttributes_0);
				}
			}
			SolidBrush brush3 = new SolidBrush(this.method_3());
			float num4 = (float)num3;
			float y = (float)num2 + 4f;
			float width = (float)this.labelTitle.Width - num4 - (float)this.imageList_0.ImageSize.Width - 4f;
			float height = 16f;
			RectangleF layoutRectangle = new RectangleF(num4, y, width, height);
			StringFormat stringFormat = new StringFormat();
			stringFormat.Trimming = StringTrimming.EllipsisWord;
			if (base.Enabled)
			{
				e.Graphics.DrawString(this.labelTitle.Text, this.labelTitle.Font, brush3, layoutRectangle, stringFormat);
			}
			else
			{
				Color grayText = SystemColors.GrayText;
				ControlPaint.DrawStringDisabled(e.Graphics, this.labelTitle.Text, this.labelTitle.Font, grayText, layoutRectangle, stringFormat);
			}
			SolidBrush brush4 = new SolidBrush(Color.White);
			Pen pen = new Pen(brush4, 1f);
			graphicsPath.Reset();
			graphicsPath.AddLine(bounds.Left, bounds.Bottom - 1, bounds.Right, bounds.Bottom - 1);
			e.Graphics.DrawPath(pen, graphicsPath);
			int x = bounds.Right - this.imageList_0.ImageSize.Width - 4;
			int y2 = bounds.Top + 4;
			RectangleF bounds3 = this.method_4().Images[(int)this.enum144_0].GetBounds(ref srcUnit);
			Rectangle destRect2 = new Rectangle(x, y2, this.imageList_0.ImageSize.Width, this.imageList_0.ImageSize.Height);
			if (base.Enabled)
			{
				e.Graphics.DrawImage(this.method_4().Images[(int)this.enum144_0], destRect2, (int)bounds3.Left, (int)bounds3.Top, (int)bounds3.Width, (int)bounds3.Height, srcUnit);
			}
			else
			{
				e.Graphics.DrawImage(this.method_4().Images[(int)this.enum144_0], destRect2, (int)bounds3.Left, (int)bounds3.Top, (int)bounds3.Width, (int)bounds3.Height, srcUnit, this.imageAttributes_0);
			}
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x000C36CC File Offset: 0x000C18CC
		private void labelTitle_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && this.method_5(e.X, e.Y) && this.imageList_0 != null && this.imageList_0.Images.Count >= 2)
			{
				if (this.int_1 == 0)
				{
					this.enum144_0 = Enum144.const_1;
				}
				else
				{
					this.enum144_0 = Enum144.const_0;
				}
				this.method_6();
			}
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x000C3740 File Offset: 0x000C1940
		private void labelTitle_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.None && this.method_5(e.X, e.Y))
			{
				this.labelTitle.Cursor = Cursors.Hand;
			}
			else
			{
				this.labelTitle.Cursor = Cursors.Default;
			}
		}

		// Token: 0x04000DAA RID: 3498
		private Delegate34 delegate34_0;

		// Token: 0x04000DAB RID: 3499
		private ColorMatrix colorMatrix_0;

		// Token: 0x04000DAC RID: 3500
		private ImageAttributes imageAttributes_0;

		// Token: 0x04000DAD RID: 3501
		private Enum144 enum144_0 = Enum144.const_0;

		// Token: 0x04000DAE RID: 3502
		private int int_0;

		// Token: 0x04000DAF RID: 3503
		private int int_1 = 0;

		// Token: 0x04000DB0 RID: 3504
		private Color color_0 = Color.White;

		// Token: 0x04000DB1 RID: 3505
		private Color color_1 = Color.FromArgb(199, 212, 247);

		// Token: 0x04000DB2 RID: 3506
		private IContainer icontainer_0;

		// Token: 0x04000DB3 RID: 3507
		private Label labelTitle;

		// Token: 0x04000DB4 RID: 3508
		private Image image_0;

		// Token: 0x04000DB5 RID: 3509
		private ImageList imageList_0;
	}
}
