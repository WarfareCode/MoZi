using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ns19
{
	// Token: 0x0200034A RID: 842
	public class SettingsBase
	{
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x000853C0 File Offset: 0x000835C0
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x0000E344 File Offset: 0x0000C544
		[XmlIgnore]
		public string FileName
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0000E34D File Offset: 0x0000C54D
		public SettingsBase()
		{
			this.string_1 = Application.ProductVersion;
		}

		// Token: 0x04000825 RID: 2085
		private string string_0;

		// Token: 0x04000826 RID: 2086
		private string string_1;
	}
}
