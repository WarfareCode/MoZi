using System;
using System.Collections;
using Microsoft.DirectX;
using ns18;
using ns19;

namespace ns16
{
	// Token: 0x02000308 RID: 776
	public abstract class RenderableObject : IDisposable, IComparable
	{
		// Token: 0x0600122A RID: 4650 RVA: 0x0000D73F File Offset: 0x0000B93F
		protected RenderableObject(string string_2)
		{
			this.string_1 = string_2;
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0000D776 File Offset: 0x0000B976
		protected RenderableObject(string string_2, World class1995_1)
		{
			this.string_1 = string_2;
			this.class1995_0 = class1995_1;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x000822C4 File Offset: 0x000804C4
		protected RenderableObject(string string_2, Vector3 vector3_1, Quaternion quaternion_1)
		{
			this.string_1 = string_2;
			this.vector3_0 = vector3_1;
			this.quaternion_0 = quaternion_1;
		}

		// Token: 0x0600122D RID: 4653
		public abstract void Initialize(DrawArgs class1943_0);

		// Token: 0x0600122E RID: 4654
		public abstract bool Update(DrawArgs class1943_0);

		// Token: 0x0600122F RID: 4655
		public abstract void Render(DrawArgs class1943_0);

		// Token: 0x06001230 RID: 4656 RVA: 0x0000D7B4 File Offset: 0x0000B9B4
		public bool vmethod_3()
		{
			return this.isInitialized;
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00082314 File Offset: 0x00080514
		public virtual World vmethod_4()
		{
			return this.class1995_0;
		}

		// Token: 0x06001232 RID: 4658
		public abstract void Dispose();

		// Token: 0x06001233 RID: 4659
		public abstract bool PerformSelectionAction(DrawArgs class1943_0);

		// Token: 0x06001234 RID: 4660 RVA: 0x0008232C File Offset: 0x0008052C
		public int CompareTo(object target)
		{
			RenderableObject renderableObject = target as RenderableObject;
			int result;
			if (target == null)
			{
				result = 1;
			}
			else
			{
				result = this.m_renderPriority.CompareTo(renderableObject.vmethod_6());
			}
			return result;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0008236C File Offset: 0x0008056C
		public override string ToString()
		{
			return this.string_1;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00082384 File Offset: 0x00080584
		public virtual RenderPriority vmethod_6()
		{
			return this.m_renderPriority;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0000D7BC File Offset: 0x0000B9BC
		public  void vmethod_7(RenderPriority enum153_1)
		{
			this.m_renderPriority = enum153_1;
			if (this.ParentList != null)
			{
				this.ParentList.vmethod_23();
			}
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0008239C File Offset: 0x0008059C
		public virtual byte GetOpacity()
		{
			return this.byte_0;
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0000D7DB File Offset: 0x0000B9DB
		public virtual void SetOpacity(byte byte_1)
		{
			this.byte_0 = byte_1;
			if (byte_1 == 0)
			{
				if (this.isOn)
				{
					this.SetIsOn(false);
				}
			}
			else if (!this.isOn)
			{
				this.SetIsOn(true);
			}
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x000823B4 File Offset: 0x000805B4
		public virtual Hashtable vmethod_10()
		{
			return this.hashtable_0;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0000D810 File Offset: 0x0000BA10
		public virtual bool IsOn()
		{
			return this.isOn;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0000D818 File Offset: 0x0000BA18
		public virtual void SetIsOn(bool bool_3)
		{
			if (this.isOn && !bool_3)
			{
				this.Dispose();
			}
			this.isOn = bool_3;
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0008236C File Offset: 0x0008056C
		public virtual string GetName()
		{
			return this.string_1;
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0000D835 File Offset: 0x0000BA35
		public  void vmethod_14(string string_2)
		{
			this.string_1 = string_2;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x000823CC File Offset: 0x000805CC
		public virtual Vector3 vmethod_15()
		{
			return this.vector3_0;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x0000D83E File Offset: 0x0000BA3E
		public  void vmethod_16(Vector3 vector3_1)
		{
			this.vector3_0 = vector3_1;
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x000823E4 File Offset: 0x000805E4
		public virtual Quaternion vmethod_17()
		{
			return this.quaternion_0;
		}

		// Token: 0x0400077C RID: 1916
		public bool isInitialized;

		// Token: 0x0400077D RID: 1917
		public bool isSelectable;

		// Token: 0x0400077E RID: 1918
		public RenderableObjectList ParentList;

		// Token: 0x0400077F RID: 1919
		public string string_0 = "";

		// Token: 0x04000780 RID: 1920
		protected string string_1;

		// Token: 0x04000781 RID: 1921
		protected Hashtable hashtable_0 = new Hashtable();

		// Token: 0x04000782 RID: 1922
		protected Vector3 vector3_0;

		// Token: 0x04000783 RID: 1923
		protected Quaternion quaternion_0;

		// Token: 0x04000784 RID: 1924
		protected bool isOn = true;

		// Token: 0x04000785 RID: 1925
		protected byte byte_0 = 255;

		// Token: 0x04000786 RID: 1926
		protected RenderPriority m_renderPriority;

		// Token: 0x04000787 RID: 1927
		protected World class1995_0;
	}
}
