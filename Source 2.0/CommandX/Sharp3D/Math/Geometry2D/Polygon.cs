using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Sharp3D.Math.Core;

namespace Sharp3D.Math.Geometry2D
{
	// Token: 0x020003E9 RID: 1001
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public sealed class Polygon : ICloneable, ISerializable
	{
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x00099580 File Offset: 0x00097780
		[XmlArrayItem(Type = typeof(Vector2F))]
		public Vector2FArrayList Points
		{
			get
			{
				return this._points;
			}
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x000105E3 File Offset: 0x0000E7E3
		public Polygon()
		{
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x000105F6 File Offset: 0x0000E7F6
		public Polygon(Polygon polygon_0)
		{
			this._points = (Vector2FArrayList)polygon_0._points.Clone();
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0001061F File Offset: 0x0000E81F
		protected Polygon(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._points = (Vector2FArrayList)serializationInfo_0.GetValue("Points", typeof(Vector2FArrayList));
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00099598 File Offset: 0x00097798
		object ICloneable.Clone()
		{
			return new Polygon(this);
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00010652 File Offset: 0x0000E852
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Points", this._points, typeof(Vector2FArrayList));
		}

		// Token: 0x04000A3B RID: 2619
		private Vector2FArrayList _points = new Vector2FArrayList();
	}
}
