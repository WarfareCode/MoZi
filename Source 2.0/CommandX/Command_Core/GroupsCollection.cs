using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Command_Core
{
	// Token: 0x02000AE2 RID: 2786
	public sealed class GroupsCollection : KeyedCollection<string, Group>
	{
		// Token: 0x06005932 RID: 22834 RVA: 0x002766F4 File Offset: 0x002748F4
		protected override string GetKeyForItem(Group item)
		{
			return item.GetGuid();
		}

		// Token: 0x06005933 RID: 22835 RVA: 0x0027670C File Offset: 0x0027490C
		protected override void InsertItem(int index, Group item)
		{
			base.InsertItem(index, item);
			GroupsCollection.Delegate13 @delegate = GroupsCollection.delegate13_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x00276734 File Offset: 0x00274934
		protected override void SetItem(int index, Group item)
		{
			base.SetItem(index, item);
			GroupsCollection.Delegate13 @delegate = GroupsCollection.delegate13_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x0027675C File Offset: 0x0027495C
		protected override void RemoveItem(int index)
		{
			base.RemoveItem(index);
			GroupsCollection.Delegate13 @delegate = GroupsCollection.delegate13_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x00276784 File Offset: 0x00274984
		protected override void ClearItems()
		{
			base.ClearItems();
			GroupsCollection.Delegate13 @delegate = GroupsCollection.delegate13_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x002767AC File Offset: 0x002749AC
		public Group method_0(string string_0)
		{
			GroupsCollection.Class127 @class = new GroupsCollection.Class127();
			@class.string_0 = string_0;
			return this.Select(GroupsCollection.GroupFunc).Where(new Func<Group, bool>(@class.method_0)).ElementAtOrDefault(0);
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x002767EC File Offset: 0x002749EC
		public bool method_1(string string_0)
		{
			GroupsCollection.Class128 @class = new GroupsCollection.Class128();
			@class.string_0 = string_0;
			return this.Select(GroupsCollection.GroupFunc).Where(new Func<Group, bool>(@class.method_0)).Count<Group>() > 0;
		}

		// Token: 0x04002C70 RID: 11376
		public static Func<Group, Group> GroupFunc = (Group group_0) => group_0;

		// Token: 0x04002C71 RID: 11377
		[CompilerGenerated]
		private static GroupsCollection.Delegate13 delegate13_0;

		// Token: 0x02000AE3 RID: 2787
		// (Invoke) Token: 0x0600593D RID: 22845
		public delegate void Delegate13();

		// Token: 0x02000AE4 RID: 2788
		[CompilerGenerated]
		public sealed class Class127
		{
			// Token: 0x06005940 RID: 22848 RVA: 0x000284D4 File Offset: 0x000266D4
			internal bool method_0(Group group_0)
			{
				return Operators.CompareString(group_0.Name, this.string_0, false) == 0;
			}

			// Token: 0x04002C73 RID: 11379
			public string string_0;
		}

		// Token: 0x02000AE5 RID: 2789
		[CompilerGenerated]
		public sealed class Class128
		{
			// Token: 0x06005942 RID: 22850 RVA: 0x000284EB File Offset: 0x000266EB
			internal bool method_0(Group group_0)
			{
				return Operators.CompareString(group_0.Name, this.string_0, false) == 0;
			}

			// Token: 0x04002C74 RID: 11380
			public string string_0;
		}
	}
}
