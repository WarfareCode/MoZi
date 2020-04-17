using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns29
{
	// Token: 0x020001D0 RID: 464
	public sealed class TreeGridViewTextBoxColumn : DataGridViewTextBoxColumn
	{
		// Token: 0x06000B09 RID: 2825 RVA: 0x00009C71 File Offset: 0x00007E71
		public TreeGridViewTextBoxColumn()
		{
			this.CellTemplate = new TreeGridViewTextBoxCell();
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x000778E0 File Offset: 0x00075AE0
		public override object Clone()
		{
			TreeGridViewTextBoxColumn treeGridViewTextBoxColumn = (TreeGridViewTextBoxColumn)base.Clone();
			treeGridViewTextBoxColumn._image = this._image;
			return treeGridViewTextBoxColumn;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00009C84 File Offset: 0x00007E84
		public void SetImage(Image image_1)
		{
			this._image = image_1;
		}

		// Token: 0x040004E3 RID: 1251
		internal Image _image;
	}
}
