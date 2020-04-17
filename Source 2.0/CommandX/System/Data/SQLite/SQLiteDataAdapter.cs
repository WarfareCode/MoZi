using System;
using System.ComponentModel;
using System.Data.Common;

namespace System.Data.SQLite
{
	// Token: 0x0200143C RID: 5180
	[DefaultEvent("RowUpdated"), Designer("Microsoft.VSDesigner.Data.VS.SqlDataAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), ToolboxItem("SQLite.Designer.SQLiteDataAdapterToolboxItem, SQLite.Designer, Version=1.0.37.0, Culture=neutral, PublicKeyToken=db937bc2d44ff139")]
	public sealed class SQLiteDataAdapter : DbDataAdapter
	{
		// Token: 0x0600B1DB RID: 45531 RVA: 0x0005476C File Offset: 0x0005296C
		public SQLiteDataAdapter()
		{
		}

		// Token: 0x0600B1DC RID: 45532 RVA: 0x00054774 File Offset: 0x00052974
		public SQLiteDataAdapter(SQLiteCommand cmd)
		{
			this.SelectCommand = cmd;
		}

		// Token: 0x0600B1DD RID: 45533 RVA: 0x00054783 File Offset: 0x00052983
		public SQLiteDataAdapter(string commandText, SQLiteConnection connection)
		{
			this.SelectCommand = new SQLiteCommand(commandText, connection);
		}

		// Token: 0x0600B1DE RID: 45534 RVA: 0x004EEC24 File Offset: 0x004ECE24
		public SQLiteDataAdapter(string commandText, string connectionString)
		{
			SQLiteConnection connection = new SQLiteConnection(connectionString);
			this.SelectCommand = new SQLiteCommand(commandText, connection);
		}

        // Token: 0x14000113 RID: 275
        // (add) Token: 0x0600B1DF RID: 45535 RVA: 0x004EEC4C File Offset: 0x004ECE4C
        // (remove) Token: 0x0600B1E0 RID: 45536 RVA: 0x00054798 File Offset: 0x00052998
        public event EventHandler<RowUpdatingEventArgs> RowUpdating;
		//{
		//	add
		//	{
		//		EventHandler<RowUpdatingEventArgs> eventHandler = (EventHandler<RowUpdatingEventArgs>)base.Events[SQLiteDataAdapter._updatingEventPH];
		//		if (eventHandler != null && value.Target is DbCommandBuilder)
		//		{
		//			EventHandler<RowUpdatingEventArgs> eventHandler2 = (EventHandler<RowUpdatingEventArgs>)SQLiteDataAdapter.FindBuilder(eventHandler);
		//			if (eventHandler2 != null)
		//			{
		//				base.Events.RemoveHandler(SQLiteDataAdapter._updatingEventPH, eventHandler2);
		//			}
		//		}
		//		base.Events.AddHandler(SQLiteDataAdapter._updatingEventPH, value);
		//	}
		//	remove
		//	{
		//		base.Events.RemoveHandler(SQLiteDataAdapter._updatingEventPH, value);
		//	}
		//}

		// Token: 0x0600B1E1 RID: 45537 RVA: 0x004EECB0 File Offset: 0x004ECEB0
		internal static Delegate FindBuilder(MulticastDelegate mcd)
		{
			if (mcd != null)
			{
				Delegate[] invocationList = mcd.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					if (invocationList[i].Target is DbCommandBuilder)
					{
						return invocationList[i];
					}
				}
			}
			return null;
		}

        // Token: 0x14000114 RID: 276
        // (add) Token: 0x0600B1E2 RID: 45538 RVA: 0x000547AB File Offset: 0x000529AB
        // (remove) Token: 0x0600B1E3 RID: 45539 RVA: 0x000547BE File Offset: 0x000529BE
        public event EventHandler<RowUpdatedEventArgs> RowUpdated;
		//{
		//	add
		//	{
		//		base.Events.AddHandler(SQLiteDataAdapter._updatedEventPH, value);
		//	}
		//	remove
		//	{
		//		base.Events.RemoveHandler(SQLiteDataAdapter._updatedEventPH, value);
		//	}
		//}

		// Token: 0x0600B1E4 RID: 45540 RVA: 0x004EECEC File Offset: 0x004ECEEC
		protected override void OnRowUpdating(RowUpdatingEventArgs value)
		{
			EventHandler<RowUpdatingEventArgs> eventHandler = base.Events[SQLiteDataAdapter._updatingEventPH] as EventHandler<RowUpdatingEventArgs>;
			if (eventHandler != null)
			{
				eventHandler(this, value);
			}
		}

		// Token: 0x0600B1E5 RID: 45541 RVA: 0x004EED1C File Offset: 0x004ECF1C
		protected override void OnRowUpdated(RowUpdatedEventArgs value)
		{
			EventHandler<RowUpdatedEventArgs> eventHandler = base.Events[SQLiteDataAdapter._updatedEventPH] as EventHandler<RowUpdatedEventArgs>;
			if (eventHandler != null)
			{
				eventHandler(this, value);
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x0600B1E6 RID: 45542 RVA: 0x000547D1 File Offset: 0x000529D1
		// (set) Token: 0x0600B1E7 RID: 45543 RVA: 0x000547DE File Offset: 0x000529DE
		[DefaultValue(null), Editor("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public new SQLiteCommand SelectCommand
		{
			get
			{
				return (SQLiteCommand)base.SelectCommand;
			}
			set
			{
				base.SelectCommand = value;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x0600B1E8 RID: 45544 RVA: 0x000547E7 File Offset: 0x000529E7
		// (set) Token: 0x0600B1E9 RID: 45545 RVA: 0x000547F4 File Offset: 0x000529F4
		[DefaultValue(null), Editor("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public new SQLiteCommand InsertCommand
		{
			get
			{
				return (SQLiteCommand)base.InsertCommand;
			}
			set
			{
				base.InsertCommand = value;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x0600B1EA RID: 45546 RVA: 0x000547FD File Offset: 0x000529FD
		// (set) Token: 0x0600B1EB RID: 45547 RVA: 0x0005480A File Offset: 0x00052A0A
		[DefaultValue(null), Editor("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public new SQLiteCommand UpdateCommand
		{
			get
			{
				return (SQLiteCommand)base.UpdateCommand;
			}
			set
			{
				base.UpdateCommand = value;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x0600B1EC RID: 45548 RVA: 0x00054813 File Offset: 0x00052A13
		// (set) Token: 0x0600B1ED RID: 45549 RVA: 0x00054820 File Offset: 0x00052A20
		[DefaultValue(null), Editor("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public new SQLiteCommand DeleteCommand
		{
			get
			{
				return (SQLiteCommand)base.DeleteCommand;
			}
			set
			{
				base.DeleteCommand = value;
			}
		}

		// Token: 0x04005E35 RID: 24117
		private static object _updatingEventPH = new object();

		// Token: 0x04005E36 RID: 24118
		private static object _updatedEventPH = new object();
	}
}
