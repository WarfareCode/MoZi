using System;
using System.Collections;
using System.IO;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using GisSharpBlog.NetTopologySuite.IO;
using ns13;
using ns14;

namespace ns12
{
	// Token: 0x020003A7 RID: 935
	public sealed class Class598 : IEnumerable
	{
		// Token: 0x060016F1 RID: 5873 RVA: 0x00091624 File Offset: 0x0008F824
		public Class598(string string_1, IGeometryFactory igeometryFactory_1)
		{
			if (string_1 == null)
			{
				throw new ArgumentNullException("filename");
			}
			if (igeometryFactory_1 == null)
			{
				throw new ArgumentNullException("geometryFactory");
			}
			this.string_0 = string_1;
			this.igeometryFactory_0 = igeometryFactory_1;
			FileStream stream_ = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read);
			Class661 @class = new Class661(stream_);
			this.class600_0 = new Class600(@class);
			@class.Close();
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x0000F84E File Offset: 0x0000DA4E
		public Class598(string string_1) : this(string_1, new GeometryFactory())
		{
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x000916A0 File Offset: 0x0008F8A0
		public Class600 method_0()
		{
			return this.class600_0;
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x000916B8 File Offset: 0x0008F8B8
		public IEnumerator GetEnumerator()
		{
			return new Class598.Class599(this);
		}

		// Token: 0x04000984 RID: 2436
		private Class600 class600_0 = null;

		// Token: 0x04000985 RID: 2437
		private IGeometryFactory igeometryFactory_0 = null;

		// Token: 0x04000986 RID: 2438
		private string string_0;

		// Token: 0x020003A8 RID: 936
		private sealed class Class599 : IDisposable, IEnumerator
		{
			// Token: 0x170001E2 RID: 482
			// (get) Token: 0x060016F5 RID: 5877 RVA: 0x000916D0 File Offset: 0x0008F8D0
			public object Current
			{
				get
				{
					return this.igeometry_0;
				}
			}

			// Token: 0x060016F6 RID: 5878 RVA: 0x000916E8 File Offset: 0x0008F8E8
			public Class599(Class598 class598_1)
			{
				this.class598_0 = class598_1;
				FileStream stream_ = new FileStream(this.class598_0.string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
				this.class661_0 = new Class661(stream_);
				this.class661_0.ReadBytes(100);
				ShapeGeometryType shapeGeometryType = this.class598_0.class600_0.method_1();
				this.class612_0 = Class638.smethod_0(shapeGeometryType);
				if (this.class612_0 == null)
				{
					throw new NotSupportedException("Unsuported shape type:" + shapeGeometryType);
				}
			}

			// Token: 0x060016F7 RID: 5879 RVA: 0x0000F85C File Offset: 0x0000DA5C
			public void Reset()
			{
				this.class661_0.BaseStream.Seek(100L, SeekOrigin.Begin);
			}

			// Token: 0x060016F8 RID: 5880 RVA: 0x00091778 File Offset: 0x0008F978
			public bool MoveNext()
			{
				bool result;
				bool flag;
				if (this.class661_0.PeekChar() != -1)
				{
					try
					{
						this.class661_0.method_0();
						this.class661_0.method_0();
						this.igeometry_0 = this.class612_0.vmethod_0(this.class661_0, this.class598_0.igeometryFactory_0);
					}
					catch (Exception)
					{
						result = false;
						return result;
					}
					flag = true;
				}
				else
				{
					flag = false;
				}
				result = flag;
				return result;
			}

			// Token: 0x060016F9 RID: 5881 RVA: 0x0000F879 File Offset: 0x0000DA79
			public void Dispose()
			{
				this.class661_0.Close();
			}

			// Token: 0x04000987 RID: 2439
			private Class598 class598_0;

			// Token: 0x04000988 RID: 2440
			private IGeometry igeometry_0;

			// Token: 0x04000989 RID: 2441
			private Class612 class612_0;

			// Token: 0x0400098A RID: 2442
			private Class661 class661_0 = null;
		}
	}
}
