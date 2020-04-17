using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns29
{
	// Token: 0x020001C6 RID: 454
	public sealed class TreeGridViewTextBoxCell : DataGridViewTextBoxCell
	{
		// Token: 0x06000AD0 RID: 2768 RVA: 0x00009A73 File Offset: 0x00007C73
		public TreeGridViewTextBoxCell()
		{
			this.int_0 = 15;
			this.int_1 = 0;
			this.bool_0 = false;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00076E44 File Offset: 0x00075044
		public override object Clone()
		{
			TreeGridViewTextBoxCell treeGridViewTextBoxCell = (TreeGridViewTextBoxCell)base.Clone();
			treeGridViewTextBoxCell.int_0 = this.int_0;
			treeGridViewTextBoxCell.int_1 = this.int_1;
			return treeGridViewTextBoxCell;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00009A9F File Offset: 0x00007C9F
		protected internal void vmethod_0()
		{
			this.bool_0 = false;
			base.Style.Padding = this.padding_0;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00009AB9 File Offset: 0x00007CB9
		protected internal void vmethod_1()
		{
			this.bool_0 = true;
			this.padding_0 = base.Style.Padding;
			this.vmethod_2();
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00076E78 File Offset: 0x00075078
		protected internal void vmethod_2()
		{
			if (this.bool_0)
			{
				int num = this.method_0();
				Padding padding = this.padding_0;
				Size preferredSize;
				using (Graphics graphics = this.method_1().treeGridView_0.CreateGraphics())
				{
					preferredSize = this.GetPreferredSize(graphics, base.InheritedStyle, base.RowIndex, new Size(0, 0));
				}
				Image image = this.method_1().method_3();
				if (image != null)
				{
					this.int_2 = image.Width + 2;
					this.int_3 = image.Height + 2;
				}
				else
				{
					this.int_2 = this.int_0;
					this.int_3 = 0;
				}
				if (preferredSize.Height < this.int_3)
				{
					base.Style.Padding = new Padding(padding.Left + num * 20 + this.int_2 + 5, padding.Top + this.int_3 / 2, padding.Right, padding.Bottom + this.int_3 / 2);
					this.int_4 = 2;
				}
				else
				{
					base.Style.Padding = new Padding(padding.Left + num * 20 + this.int_2 + 5, padding.Top, padding.Right, padding.Bottom);
				}
				this.int_1 = (num - 1) * this.int_0 + this.int_2 + 5;
			}
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00076FEC File Offset: 0x000751EC
		public int method_0()
		{
			TreeGridViewRow treeGridViewRow = this.method_1();
			int result;
			if (treeGridViewRow != null)
			{
				result = treeGridViewRow.method_6();
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00077014 File Offset: 0x00075214
		protected  int vmethod_3()
		{
			return (this.method_0() - 1) * 20 + 5;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00077030 File Offset: 0x00075230
		protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
		{
			TreeGridViewRow treeGridViewRow = this.method_1();
			if (treeGridViewRow != null)
			{
				Image image = treeGridViewRow.method_3();
				if (this.int_3 == 0 && image != null)
				{
					this.vmethod_2();
				}
				base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
				Rectangle rectangle = new Rectangle(cellBounds.X + this.vmethod_3(), cellBounds.Y, 20, cellBounds.Height - 1);
				int arg_7A_0 = rectangle.Width / 2;
				this.method_0();
				if (image != null)
				{
					Point point;
					if (this.int_3 > cellBounds.Height)
					{
						point = new Point(rectangle.X + this.int_0, cellBounds.Y + this.int_4);
					}
					else
					{
						point = new Point(rectangle.X + this.int_0, cellBounds.Height / 2 - this.int_3 / 2 + cellBounds.Y);
					}
					GraphicsContainer container = graphics.BeginContainer();
					graphics.SetClip(cellBounds);
					graphics.DrawImageUnscaled(image, point);
					graphics.EndContainer(container);
				}
				if (treeGridViewRow.treeGridView_0.method_5())
				{
					using (Pen pen = new Pen(SystemBrushes.ControlDark, 1f))
					{
						pen.DashStyle = DashStyle.Dot;
						bool flag = treeGridViewRow.method_10();
						bool flag2 = treeGridViewRow.method_9();
						if (treeGridViewRow.method_6() == 1)
						{
							if (flag2 & flag)
							{
								graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2, rectangle.Right, cellBounds.Top + cellBounds.Height / 2);
							}
							else if (flag)
							{
								graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2, rectangle.Right, cellBounds.Top + cellBounds.Height / 2);
								graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2);
							}
							else if (flag2)
							{
								graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2, rectangle.Right, cellBounds.Top + cellBounds.Height / 2);
								graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2, rectangle.X + 4, cellBounds.Bottom);
							}
							else
							{
								graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2, rectangle.Right, cellBounds.Top + cellBounds.Height / 2);
								graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top, rectangle.X + 4, cellBounds.Bottom);
							}
						}
						else
						{
							if (flag)
							{
								graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2, rectangle.Right, cellBounds.Top + cellBounds.Height / 2);
								graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2);
							}
							else
							{
								graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2, rectangle.Right, cellBounds.Top + cellBounds.Height / 2);
								graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top, rectangle.X + 4, cellBounds.Bottom);
							}
							TreeGridViewRow treeGridViewRow2 = treeGridViewRow.method_7();
							int num = rectangle.X + 4 - 20;
							while (!treeGridViewRow2.bool_1)
							{
								if (treeGridViewRow2.vmethod_2() && !treeGridViewRow2.method_10())
								{
									graphics.DrawLine(pen, num, cellBounds.Top, num, cellBounds.Bottom);
								}
								treeGridViewRow2 = treeGridViewRow2.method_7();
								num -= 20;
							}
						}
					}
				}
				if (treeGridViewRow.vmethod_2() || treeGridViewRow.treeGridView_0.method_3())
				{
					if (treeGridViewRow.bool_0)
					{
						Bitmap image2 = new Bitmap(Application.StartupPath + "\\Symbols\\Menu\\Minus.png");
						graphics.DrawImage(image2, rectangle.X, rectangle.Y + rectangle.Height / 2 - 4, 10, 10);
					}
					else
					{
						Bitmap image2 = new Bitmap(Application.StartupPath + "\\Symbols\\Menu\\Plus.png");
						graphics.DrawImage(image2, rectangle.X, rectangle.Y + rectangle.Height / 2 - 4, 10, 10);
					}
				}
			}
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00077548 File Offset: 0x00075748
		protected override void OnMouseUp(DataGridViewCellMouseEventArgs e)
		{
			base.OnMouseUp(e);
			TreeGridViewRow treeGridViewRow = this.method_1();
			if (treeGridViewRow != null)
			{
				treeGridViewRow.treeGridView_0.bool_2 = false;
			}
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00077578 File Offset: 0x00075778
		protected override void OnMouseDown(DataGridViewCellMouseEventArgs e)
		{
			if (e.Location.X > base.InheritedStyle.Padding.Left)
			{
				base.OnMouseDown(e);
			}
			else
			{
				TreeGridViewRow treeGridViewRow = this.method_1();
				if (treeGridViewRow != null)
				{
					treeGridViewRow.treeGridView_0.bool_2 = true;
					if (treeGridViewRow.bool_0)
					{
						treeGridViewRow.vmethod_3();
					}
					else
					{
						treeGridViewRow.vmethod_4();
					}
				}
			}
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x000775EC File Offset: 0x000757EC
		public TreeGridViewRow method_1()
		{
			return base.OwningRow as TreeGridViewRow;
		}

		// Token: 0x040004CC RID: 1228
		private int int_0;

		// Token: 0x040004CD RID: 1229
		private int int_1;

		// Token: 0x040004CE RID: 1230
		internal bool bool_0;

		// Token: 0x040004CF RID: 1231
		private Padding padding_0;

		// Token: 0x040004D0 RID: 1232
		private int int_2 = 0;

		// Token: 0x040004D1 RID: 1233
		private int int_3 = 0;

		// Token: 0x040004D2 RID: 1234
		private int int_4;
	}
}
