using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core.DAL;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace Command
{
	// Token: 0x02000827 RID: 2087
	[Attribute0, Attribute2, Attribute3]
	public sealed class CargoMissionMothershipCargoMountViewModel : INotifyPropertyChanged
	{
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600336A RID: 13162 RVA: 0x00119A38 File Offset: 0x00117C38
		// (remove) Token: 0x0600336B RID: 13163 RVA: 0x00119A74 File Offset: 0x00117C74
		public event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600336C RID: 13164 RVA: 0x00119AB0 File Offset: 0x00117CB0
		public string Status
		{
			get
			{
				return string.Concat(new string[]
				{
					this.Name,
					" ",
					Conversions.ToString(this.ToUnload),
					" / ",
					Conversions.ToString(this.Available)
				});
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600336D RID: 13165 RVA: 0x00119B04 File Offset: 0x00117D04
		// (set) Token: 0x0600336E RID: 13166 RVA: 0x0001B851 File Offset: 0x00019A51
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.string_0, value, StringComparison.Ordinal))
				{
					this.string_0 = value;
					this.vmethod_0("Status");
					this.vmethod_0("Name");
				}
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600336F RID: 13167 RVA: 0x00119B1C File Offset: 0x00117D1C
		// (set) Token: 0x06003370 RID: 13168 RVA: 0x0001B882 File Offset: 0x00019A82
		public int Available
		{
			[CompilerGenerated]
			get
			{
				return this.int_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_0 != value)
				{
					this.int_0 = value;
					this.vmethod_0("Status");
					this.vmethod_0("Available");
				}
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06003371 RID: 13169 RVA: 0x00119B34 File Offset: 0x00117D34
		// (set) Token: 0x06003372 RID: 13170 RVA: 0x0001B8AF File Offset: 0x00019AAF
		public int ToUnload
		{
			[CompilerGenerated]
			get
			{
				return this.int_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_1 != value)
				{
					this.int_1 = value;
					this.vmethod_0("Status");
					this.vmethod_0("ToUnload");
				}
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06003373 RID: 13171 RVA: 0x00119B4C File Offset: 0x00117D4C
		// (set) Token: 0x06003374 RID: 13172 RVA: 0x0001B8DC File Offset: 0x00019ADC
		public int DBID
		{
			[CompilerGenerated]
			get
			{
				return this.int_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_2 != value)
				{
					this.int_2 = value;
					this.vmethod_0("DBID");
				}
			}
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x00119B64 File Offset: 0x00117D64
		public CargoMissionMothershipCargoMountViewModel(int theMountDBID)
		{
			SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
			this.Name = DBFunctions.GetMountName(theMountDBID, ref sQLiteConnection);
			this.DBID = theMountDBID;
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x00119BA0 File Offset: 0x00117DA0
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040017DA RID: 6106
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040017DB RID: 6107
		[CompilerGenerated]
		private int int_0;

		// Token: 0x040017DC RID: 6108
		[CompilerGenerated]
		private int int_1;

		// Token: 0x040017DD RID: 6109
		[CompilerGenerated]
		private int int_2 = 0;

		// Token: 0x040017DE RID: 6110
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
