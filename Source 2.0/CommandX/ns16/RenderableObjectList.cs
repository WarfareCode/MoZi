using System;
using System.Collections;
using System.Timers;
using Microsoft.DirectX;
using ns17;
using ns18;

namespace ns16
{
	// Token: 0x020004B0 RID: 1200
	public sealed class RenderableObjectList : RenderableObject
	{
		// Token: 0x06001F65 RID: 8037 RVA: 0x00012E02 File Offset: 0x00011002
		public void method_0(bool bool_5)
		{
			this.bool_4 = bool_5;
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00012E0B File Offset: 0x0001100B
		public RenderableObjectList(string string_2) : base(string_2, new Vector3(0f, 0f, 0f), new Quaternion())
		{
			this.isSelectable = true;
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x000CE940 File Offset: 0x000CCB40
		public  RenderableObject vmethod_18(string string_2)
		{
			RenderableObject result = null;
			try
			{
				foreach (RenderableObject renderableObject in this.m_children)
				{
					if (renderableObject.GetName().Equals(string_2))
					{
						result = renderableObject;
						break;
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x000CE9C4 File Offset: 0x000CCBC4
		public  ArrayList GetChildObjects()
		{
			return this.m_children;
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x000CE9DC File Offset: 0x000CCBDC
		public  int vmethod_20()
		{
			return this.m_children.Count;
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x000CE9F8 File Offset: 0x000CCBF8
		public override void Initialize(DrawArgs class1943_0)
		{
			if (this.IsOn())
			{
				try
				{
					object syncRoot = this.m_children.SyncRoot;
					lock (syncRoot)
					{
						foreach (RenderableObject renderableObject in this.m_children)
						{
							try
							{
								if (renderableObject.IsOn())
								{
									renderableObject.Initialize(class1943_0);
								}
							}
							catch (Exception ex)
							{
								Log.Write(Log.Levels.Error, "ROBJ", string.Format("{0}: {1} ({2})", this.GetName(), ex.Message, renderableObject.GetName()));
							}
						}
					}
				}
				catch
				{
				}
				this.isInitialized = true;
			}
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x0008239C File Offset: 0x0008059C
		public override byte GetOpacity()
		{
			return this.byte_0;
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x000CEAFC File Offset: 0x000CCCFC
		public override void SetOpacity(byte byte_1)
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
			object syncRoot = this.m_children.SyncRoot;
			lock (syncRoot)
			{
                IEnumerator enumerator = this.m_children.GetEnumerator();
				{
					while (enumerator.MoveNext())
					{
						((RenderableObject)enumerator.Current).SetOpacity(byte_1);
					}
				}
			}
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x000CEBC0 File Offset: 0x000CCDC0
		public override bool Update(DrawArgs drawArgs)
		{
			bool result = false;
			try
			{
				if (this.IsOn())
				{
					if (!this.isInitialized)
					{
						this.Initialize(drawArgs);
						result = true;
					}
					object syncRoot = this.m_children.SyncRoot;
					lock (syncRoot)
					{
						foreach (RenderableObject renderableObject in this.m_children)
						{
							if (renderableObject.ParentList == null)
							{
								renderableObject.ParentList = this;
							}
							if (renderableObject.IsOn() && renderableObject.Update(drawArgs))
							{
								result = true;
							}
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x000CECB8 File Offset: 0x000CCEB8
		public override bool PerformSelectionAction(DrawArgs drawArgs)
		{
			bool result = false;
			try
			{
				if (this.IsOn())
				{
					foreach (RenderableObject renderableObject in this.m_children)
					{
						if (renderableObject.IsOn() && renderableObject.isSelectable && renderableObject.PerformSelectionAction(drawArgs))
						{
							result = true;
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x000CED50 File Offset: 0x000CCF50
		public override void Render(DrawArgs drawArgs)
		{
			try
			{
				if (this.IsOn())
				{
					object syncRoot = this.m_children.SyncRoot;
					lock (syncRoot)
					{
						foreach (RenderableObject renderableObject in this.m_children)
						{
							if (renderableObject.IsOn())
							{
								renderableObject.Render(drawArgs);
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x000CEE10 File Offset: 0x000CD010
		public override void Dispose()
		{
			try
			{
				this.isInitialized = false;
                IEnumerator enumerator = this.m_children.GetEnumerator();
				{
					while (enumerator.MoveNext())
					{
						((RenderableObject)enumerator.Current).Dispose();
					}
				}
				if (this.timer_0 != null && this.timer_0.Enabled)
				{
					this.timer_0.Stop();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x000CEEAC File Offset: 0x000CD0AC
		public  void Add(RenderableObject ro)
		{
			try
			{
				object syncRoot = this.m_children.SyncRoot;
				lock (syncRoot)
				{
					RenderableObjectList renderableObjectList = null;
					RenderableObject renderableObject = null;
					ro.ParentList = this;
					foreach (RenderableObject renderableObject2 in this.m_children)
					{
						if (!(renderableObject2 is RenderableObjectList) || !(renderableObject2.GetName() == ro.GetName()))
						{
							if (!(renderableObject2.GetName() == ro.GetName()))
							{
								continue;
							}
							renderableObject = renderableObject2;
						}
						else
						{
							renderableObjectList = (RenderableObjectList)renderableObject2;
						}
						break;
					}
					if (renderableObjectList != null)
					{
						RenderableObjectList renderableObjectList2 = (RenderableObjectList)ro;
						ArrayList childObjects = renderableObjectList2.GetChildObjects();
						lock (childObjects)
						{
							foreach (RenderableObject ro2 in renderableObjectList2.GetChildObjects())
							{
								renderableObjectList.Add(ro2);
							}
							goto IL_1E6;
						}
					}
					if (renderableObject != null)
					{
						for (int i = 1; i < 100; i++)
						{
							ro.vmethod_14(string.Format("{0} [{1}]", renderableObject.GetName(), i));
							bool flag3 = false;
                            IEnumerator enumerator2 = this.m_children.GetEnumerator();
							{
								while (enumerator2.MoveNext())
								{
									if (((RenderableObject)enumerator2.Current).GetName() == ro.GetName())
									{
										flag3 = true;
										break;
									}
								}
							}
							if (!flag3)
							{
								break;
							}
						}
					}
					this.m_children.Add(ro);
					IL_1E6:
					this.vmethod_23();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x000CF150 File Offset: 0x000CD350
		public  void Remove(string objectName)
		{
			object syncRoot = this.m_children.SyncRoot;
			lock (syncRoot)
			{
				for (int i = 0; i < this.m_children.Count; i++)
				{
					RenderableObject renderableObject = (RenderableObject)this.m_children[i];
					if (renderableObject.GetName().Equals(objectName))
					{
						this.m_children.RemoveAt(i);
						renderableObject.Dispose();
						renderableObject.ParentList = null;
						break;
					}
					if (renderableObject is RenderableObjectList)
					{
						(renderableObject as RenderableObjectList).Remove(objectName);
					}
				}
			}
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x000CF20C File Offset: 0x000CD40C
		public  void vmethod_23()
		{
			int num = 0;
			while (num + 1 < this.m_children.Count)
			{
				RenderableObject renderableObject = (RenderableObject)this.m_children[num];
				RenderableObject renderableObject2 = (RenderableObject)this.m_children[num + 1];
				if (renderableObject.vmethod_6() > renderableObject2.vmethod_6())
				{
					this.m_children[num] = renderableObject2;
					this.m_children[num + 1] = renderableObject;
					num = 0;
				}
				else
				{
					num++;
				}
			}
		}

		// Token: 0x04000EAE RID: 3758
		protected ArrayList m_children = new ArrayList();

		// Token: 0x04000EAF RID: 3759
		private TimeSpan timeSpan_0 = TimeSpan.MaxValue;

		// Token: 0x04000EB0 RID: 3760
		private Timer timer_0;

		// Token: 0x04000EB1 RID: 3761
		public bool bool_3;

		// Token: 0x04000EB2 RID: 3762
		private bool bool_4;
	}
}
