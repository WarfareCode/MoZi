using System;
using System.Collections;
using System.ComponentModel;

namespace ns13
{
	// Token: 0x02000421 RID: 1057
	internal struct Struct58 : ICustomTypeDescriptor
	{
		// Token: 0x06001AC6 RID: 6854 RVA: 0x00011222 File Offset: 0x0000F422
		public Struct58(Class642[] class642_1, ArrayList arrayList_1)
		{
			this.class642_0 = class642_1;
			this.arrayList_0 = arrayList_1;
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x000A14E0 File Offset: 0x0009F6E0
		public ArrayList method_0()
		{
			return this.arrayList_0;
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x000A14F8 File Offset: 0x0009F6F8
		public AttributeCollection GetAttributes()
		{
			return AttributeCollection.Empty;
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x000A150C File Offset: 0x0009F70C
		public string GetClassName()
		{
			return null;
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x000A150C File Offset: 0x0009F70C
		public string GetComponentName()
		{
			return null;
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x000A151C File Offset: 0x0009F71C
		public TypeConverter GetConverter()
		{
			return null;
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x000A152C File Offset: 0x0009F72C
		public object GetEditor(Type editorBaseType)
		{
			return null;
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x000A153C File Offset: 0x0009F73C
		public EventDescriptor GetDefaultEvent()
		{
			return null;
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x000A154C File Offset: 0x0009F74C
		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return this.GetEvents();
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x000A1564 File Offset: 0x0009F764
		public EventDescriptorCollection GetEvents()
		{
			return EventDescriptorCollection.Empty;
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x000A152C File Offset: 0x0009F72C
		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x000A1578 File Offset: 0x0009F778
		public PropertyDescriptor GetDefaultProperty()
		{
			return null;
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x000A1588 File Offset: 0x0009F788
		public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			return this.GetProperties();
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x000A15A0 File Offset: 0x0009F7A0
		public PropertyDescriptorCollection GetProperties()
		{
			PropertyDescriptor[] array = new PropertyDescriptor[this.class642_0.Length];
			for (int i = 0; i < this.class642_0.Length; i++)
			{
				array[i] = new Class617(this.class642_0[i], i);
			}
			return new PropertyDescriptorCollection(array);
		}

		// Token: 0x04000B48 RID: 2888
		private Class642[] class642_0;

		// Token: 0x04000B49 RID: 2889
		private ArrayList arrayList_0;
	}
}
