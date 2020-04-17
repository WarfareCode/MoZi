using System;
using System.Collections;
using GeoAPI.Geometries;

namespace ns14
{
	// Token: 0x02000455 RID: 1109
	public sealed class Class655 : IEnumerator
	{
		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x000B51C8 File Offset: 0x000B33C8
		public object Current
		{
			get
			{
				object obj;
				object result;
				if (this.bool_0)
				{
					this.bool_0 = false;
					obj = this.igeometryCollection_0;
				}
				else
				{
					if (this.class655_0 != null)
					{
						if (this.class655_0.MoveNext())
						{
							obj = this.class655_0.Current;
							result = obj;
							return result;
						}
						this.class655_0 = null;
					}
					if (this.int_1 >= this.int_0)
					{
						throw new ArgumentOutOfRangeException();
					}
					IGeometry geometry = this.igeometryCollection_0.imethod_9(this.int_1++);
					if (geometry is IGeometryCollection)
					{
						this.class655_0 = new Class655((IGeometryCollection)geometry);
						obj = this.class655_0.Current;
					}
					else
					{
						obj = geometry;
					}
				}
				result = obj;
				return result;
			}
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00011D37 File Offset: 0x0000FF37
		public Class655(IGeometryCollection igeometryCollection_1)
		{
			this.igeometryCollection_0 = igeometryCollection_1;
			this.bool_0 = true;
			this.int_1 = 0;
			this.int_0 = igeometryCollection_1.imethod_2();
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x000B528C File Offset: 0x000B348C
		public bool MoveNext()
		{
			bool flag;
			bool result;
			if (this.bool_0)
			{
				flag = true;
			}
			else
			{
				if (this.class655_0 != null)
				{
					if (this.class655_0.MoveNext())
					{
						result = true;
						return result;
					}
					this.class655_0 = null;
				}
				flag = (this.int_1 < this.int_0);
			}
			result = flag;
			return result;
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x00011D60 File Offset: 0x0000FF60
		public void Reset()
		{
			this.bool_0 = true;
			this.int_1 = 0;
		}

		// Token: 0x04000C6B RID: 3179
		private IGeometryCollection igeometryCollection_0;

		// Token: 0x04000C6C RID: 3180
		private bool bool_0;

		// Token: 0x04000C6D RID: 3181
		private int int_0;

		// Token: 0x04000C6E RID: 3182
		private int int_1;

		// Token: 0x04000C6F RID: 3183
		private Class655 class655_0;
	}
}
