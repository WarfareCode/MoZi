using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Reflection;

namespace System.Data.SQLite
{
	// Token: 0x02001411 RID: 5137
	[DefaultProperty("DataSource"), DefaultMember("Item")]
	public sealed class SQLiteConnectionStringBuilder : DbConnectionStringBuilder
	{
		// Token: 0x0600AFF8 RID: 45048 RVA: 0x00053AB0 File Offset: 0x00051CB0
		public SQLiteConnectionStringBuilder()
		{
			this.Initialize(null);
		}

		// Token: 0x0600AFF9 RID: 45049 RVA: 0x00053ABF File Offset: 0x00051CBF
		public SQLiteConnectionStringBuilder(string connectionString)
		{
			this.Initialize(connectionString);
		}

		// Token: 0x0600AFFA RID: 45050 RVA: 0x004E6C94 File Offset: 0x004E4E94
		private void Initialize(string cnnString)
		{
			this._properties = new Hashtable(StringComparer.OrdinalIgnoreCase);
			try
			{
				base.GetProperties(this._properties);
			}
			catch (NotImplementedException)
			{
				this.FallbackGetProperties(this._properties);
			}
			if (!string.IsNullOrEmpty(cnnString))
			{
				base.ConnectionString = cnnString;
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x0600AFFB RID: 45051 RVA: 0x004E6CF0 File Offset: 0x004E4EF0
		// (set) Token: 0x0600AFFC RID: 45052 RVA: 0x00053ACE File Offset: 0x00051CCE
		[Browsable(true), DefaultValue(3)]
		public int Version
		{
			get
			{
				object value;
				this.TryGetValue("version", out value);
				return Convert.ToInt32(value, CultureInfo.CurrentCulture);
			}
			set
			{
				if (value != 3)
				{
					throw new NotSupportedException();
				}
				this["version"] = value;
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x0600AFFD RID: 45053 RVA: 0x004E6D18 File Offset: 0x004E4F18
		// (set) Token: 0x0600AFFE RID: 45054 RVA: 0x00053AEB File Offset: 0x00051CEB
		[Browsable(true), DefaultValue(SynchronizationModes.Normal), DisplayName("Synchronous")]
		public SynchronizationModes SyncMode
		{
			get
			{
				object obj;
				this.TryGetValue("synchronous", out obj);
				if (obj is string)
				{
					return (SynchronizationModes)TypeDescriptor.GetConverter(typeof(SynchronizationModes)).ConvertFrom(obj);
				}
				return (SynchronizationModes)obj;
			}
			set
			{
				this["synchronous"] = value;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x0600AFFF RID: 45055 RVA: 0x004E6D5C File Offset: 0x004E4F5C
		// (set) Token: 0x0600B000 RID: 45056 RVA: 0x00053AFE File Offset: 0x00051CFE
		[Browsable(true), DefaultValue(false)]
		public bool UseUTF16Encoding
		{
			get
			{
				object source;
				this.TryGetValue("useutf16encoding", out source);
				return SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["useutf16encoding"] = value;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x0600B001 RID: 45057 RVA: 0x004E6D80 File Offset: 0x004E4F80
		// (set) Token: 0x0600B002 RID: 45058 RVA: 0x00053B11 File Offset: 0x00051D11
		[Browsable(true), DefaultValue(false)]
		public bool Pooling
		{
			get
			{
				object source;
				this.TryGetValue("pooling", out source);
				return SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["pooling"] = value;
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x0600B003 RID: 45059 RVA: 0x004E6DA4 File Offset: 0x004E4FA4
		// (set) Token: 0x0600B004 RID: 45060 RVA: 0x00053B24 File Offset: 0x00051D24
		[Browsable(true), DefaultValue(true)]
		public bool BinaryGUID
		{
			get
			{
				object source;
				this.TryGetValue("binaryguid", out source);
				return SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["binaryguid"] = value;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x0600B005 RID: 45061 RVA: 0x004E6DC8 File Offset: 0x004E4FC8
		// (set) Token: 0x0600B006 RID: 45062 RVA: 0x00053B37 File Offset: 0x00051D37
		[Browsable(true), DefaultValue(""), DisplayName("Data Source")]
		public string DataSource
		{
			get
			{
				object obj;
				this.TryGetValue("data source", out obj);
				return obj.ToString();
			}
			set
			{
				this["data source"] = value;
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x0600B007 RID: 45063 RVA: 0x004E6DEC File Offset: 0x004E4FEC
		// (set) Token: 0x0600B008 RID: 45064 RVA: 0x00053B45 File Offset: 0x00051D45
		[Browsable(false)]
		public string Uri
		{
			get
			{
				object obj;
				this.TryGetValue("uri", out obj);
				return obj.ToString();
			}
			set
			{
				this["uri"] = value;
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x0600B009 RID: 45065 RVA: 0x004E6E10 File Offset: 0x004E5010
		// (set) Token: 0x0600B00A RID: 45066 RVA: 0x00053B53 File Offset: 0x00051D53
		[Browsable(true), DefaultValue(30), DisplayName("Default Timeout")]
		public int DefaultTimeout
		{
			get
			{
				object value;
				this.TryGetValue("default timeout", out value);
				return Convert.ToInt32(value, CultureInfo.CurrentCulture);
			}
			set
			{
				this["default timeout"] = value;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x0600B00B RID: 45067 RVA: 0x004E6E38 File Offset: 0x004E5038
		// (set) Token: 0x0600B00C RID: 45068 RVA: 0x00053B66 File Offset: 0x00051D66
		[Browsable(true), DefaultValue(true)]
		public bool Enlist
		{
			get
			{
				object source;
				this.TryGetValue("enlist", out source);
				return SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["enlist"] = value;
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x0600B00D RID: 45069 RVA: 0x004E6E5C File Offset: 0x004E505C
		// (set) Token: 0x0600B00E RID: 45070 RVA: 0x00053B79 File Offset: 0x00051D79
		[Browsable(true), DefaultValue(false)]
		public bool FailIfMissing
		{
			get
			{
				object source;
				this.TryGetValue("failifmissing", out source);
				return SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["failifmissing"] = value;
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x0600B00F RID: 45071 RVA: 0x004E6E80 File Offset: 0x004E5080
		// (set) Token: 0x0600B010 RID: 45072 RVA: 0x00053B8C File Offset: 0x00051D8C
		[Browsable(true), DefaultValue(false), DisplayName("Legacy Format")]
		public bool LegacyFormat
		{
			get
			{
				object source;
				this.TryGetValue("legacy format", out source);
				return SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["legacy format"] = value;
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x0600B011 RID: 45073 RVA: 0x004E6EA4 File Offset: 0x004E50A4
		// (set) Token: 0x0600B012 RID: 45074 RVA: 0x00053B9F File Offset: 0x00051D9F
		[Browsable(true), DefaultValue(false), DisplayName("Read Only")]
		public bool ReadOnly
		{
			get
			{
				object source;
				this.TryGetValue("read only", out source);
				return SQLiteConvert.ToBoolean(source);
			}
			set
			{
				this["read only"] = value;
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x0600B013 RID: 45075 RVA: 0x004E6EC8 File Offset: 0x004E50C8
		// (set) Token: 0x0600B014 RID: 45076 RVA: 0x00053BB2 File Offset: 0x00051DB2
		[Browsable(true), DefaultValue(""), PasswordPropertyText(true)]
		public string Password
		{
			get
			{
				object obj;
				this.TryGetValue("password", out obj);
				return obj.ToString();
			}
			set
			{
				this["password"] = value;
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x0600B015 RID: 45077 RVA: 0x004E6EEC File Offset: 0x004E50EC
		// (set) Token: 0x0600B016 RID: 45078 RVA: 0x00053BC0 File Offset: 0x00051DC0
		[Browsable(true), DefaultValue(1024), DisplayName("Page Size")]
		public int PageSize
		{
			get
			{
				object value;
				this.TryGetValue("page size", out value);
				return Convert.ToInt32(value, CultureInfo.CurrentCulture);
			}
			set
			{
				this["page size"] = value;
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x0600B017 RID: 45079 RVA: 0x004E6F14 File Offset: 0x004E5114
		// (set) Token: 0x0600B018 RID: 45080 RVA: 0x00053BD3 File Offset: 0x00051DD3
		[Browsable(true), DefaultValue(0), DisplayName("Max Page Count")]
		public int MaxPageCount
		{
			get
			{
				object value;
				this.TryGetValue("max page count", out value);
				return Convert.ToInt32(value, CultureInfo.CurrentCulture);
			}
			set
			{
				this["max page count"] = value;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x0600B019 RID: 45081 RVA: 0x004E6F3C File Offset: 0x004E513C
		// (set) Token: 0x0600B01A RID: 45082 RVA: 0x00053BE6 File Offset: 0x00051DE6
		[Browsable(true), DefaultValue(2000), DisplayName("Cache Size")]
		public int CacheSize
		{
			get
			{
				object value;
				this.TryGetValue("cache size", out value);
				return Convert.ToInt32(value, CultureInfo.CurrentCulture);
			}
			set
			{
				this["cache size"] = value;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x0600B01B RID: 45083 RVA: 0x004E6F64 File Offset: 0x004E5164
		// (set) Token: 0x0600B01C RID: 45084 RVA: 0x00053BF9 File Offset: 0x00051DF9
		[Browsable(true), DefaultValue(SQLiteDateFormats.ISO8601)]
		public SQLiteDateFormats DateTimeFormat
		{
			get
			{
				object obj;
				this.TryGetValue("datetimeformat", out obj);
				if (obj is string)
				{
					return (SQLiteDateFormats)TypeDescriptor.GetConverter(typeof(SQLiteDateFormats)).ConvertFrom(obj);
				}
				return (SQLiteDateFormats)obj;
			}
			set
			{
				this["datetimeformat"] = value;
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x0600B01D RID: 45085 RVA: 0x004E6FA8 File Offset: 0x004E51A8
		// (set) Token: 0x0600B01E RID: 45086 RVA: 0x00053C0C File Offset: 0x00051E0C
		[Browsable(true), DefaultValue(SQLiteJournalModeEnum.Delete), DisplayName("Journal Mode")]
		public SQLiteJournalModeEnum JournalMode
		{
			get
			{
				object obj;
				this.TryGetValue("journal mode", out obj);
				if (obj is string)
				{
					return (SQLiteJournalModeEnum)TypeDescriptor.GetConverter(typeof(SQLiteJournalModeEnum)).ConvertFrom(obj);
				}
				return (SQLiteJournalModeEnum)obj;
			}
			set
			{
				this["journal mode"] = value;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x0600B01F RID: 45087 RVA: 0x004E6FEC File Offset: 0x004E51EC
		// (set) Token: 0x0600B020 RID: 45088 RVA: 0x00053C1F File Offset: 0x00051E1F
		[Browsable(true), DefaultValue(IsolationLevel.Serializable), DisplayName("Default Isolation Level")]
		public IsolationLevel DefaultIsolationLevel
		{
			get
			{
				object obj;
				this.TryGetValue("default isolationlevel", out obj);
				if (obj is string)
				{
					return (IsolationLevel)TypeDescriptor.GetConverter(typeof(IsolationLevel)).ConvertFrom(obj);
				}
				return (IsolationLevel)obj;
			}
			set
			{
				this["default isolationlevel"] = value;
			}
		}

		// Token: 0x0600B021 RID: 45089 RVA: 0x004E7030 File Offset: 0x004E5230
		public override bool TryGetValue(string keyword, out object value)
		{
			bool flag = base.TryGetValue(keyword, out value);
			if (!this._properties.ContainsKey(keyword))
			{
				return flag;
			}
			PropertyDescriptor propertyDescriptor = this._properties[keyword] as PropertyDescriptor;
			if (propertyDescriptor == null)
			{
				return flag;
			}
			if (flag)
			{
				if (propertyDescriptor.PropertyType == typeof(bool))
				{
					value = SQLiteConvert.ToBoolean(value);
				}
				else
				{
					value = TypeDescriptor.GetConverter(propertyDescriptor.PropertyType).ConvertFrom(value);
				}
			}
			else
			{
				DefaultValueAttribute defaultValueAttribute = propertyDescriptor.Attributes[typeof(DefaultValueAttribute)] as DefaultValueAttribute;
				if (defaultValueAttribute != null)
				{
					value = defaultValueAttribute.Value;
					flag = true;
				}
			}
			return flag;
		}

		// Token: 0x0600B022 RID: 45090 RVA: 0x004E70D4 File Offset: 0x004E52D4
		private void FallbackGetProperties(Hashtable propertyList)
		{
			foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(this, true))
			{
				if (propertyDescriptor.Name != "ConnectionString" && !propertyList.ContainsKey(propertyDescriptor.DisplayName))
				{
					propertyList.Add(propertyDescriptor.DisplayName, propertyDescriptor);
				}
			}
		}

		// Token: 0x04005D8C RID: 23948
		private Hashtable _properties;
	}
}
