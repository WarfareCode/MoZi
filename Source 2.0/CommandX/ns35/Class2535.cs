using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ns35
{
	// Token: 0x02000A87 RID: 2695
	public sealed class Class2535 : ICommand
	{
		// Token: 0x06005521 RID: 21793 RVA: 0x00027299 File Offset: 0x00025499
		public Class2535(Action<object> action) : this(action, null)
		{
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x000272A3 File Offset: 0x000254A3
		public Class2535(Action<object> action, Predicate<object> predicate)
		{
			if (action == null)
			{
				throw new ArgumentNullException("execute");
			}
			this.action_0 = action;
			this.predicate_0 = predicate;
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x00238108 File Offset: 0x00236308
		public bool CanExecute(object obj)
		{
			return this.predicate_0 == null || this.predicate_0(RuntimeHelpers.GetObjectValue(obj));
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x000272CD File Offset: 0x000254CD
		public void Execute(object obj)
		{
			this.action_0(RuntimeHelpers.GetObjectValue(obj));
		}

        // Token: 0x14000024 RID: 36
        // (add) Token: 0x06005525 RID: 21797 RVA: 0x000272E0 File Offset: 0x000254E0
        // (remove) Token: 0x06005526 RID: 21798 RVA: 0x000272E8 File Offset: 0x000254E8
        public event EventHandler CanExecuteChanged;
		

		// Token: 0x04002944 RID: 10564
		private readonly Action<object> action_0;

		// Token: 0x04002945 RID: 10565
		private readonly Predicate<object> predicate_0;
	}
}
