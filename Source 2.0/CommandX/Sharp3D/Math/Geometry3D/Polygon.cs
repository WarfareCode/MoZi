using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Sharp3D.Math.Core;

namespace Sharp3D.Math.Geometry3D
{
	// Token: 0x020003FA RID: 1018
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public sealed class Polygon : ICloneable, ISerializable
	{
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x0009AEEC File Offset: 0x000990EC
		[XmlArrayItem(Type = typeof(Vector3F))]
		public Vector3FArrayList Points
		{
			get
			{
				return this._points;
			}
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x000109A6 File Offset: 0x0000EBA6
		public Polygon()
		{
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000109B9 File Offset: 0x0000EBB9
		public Polygon(Polygon polygon_0)
		{
			this._points = (Vector3FArrayList)polygon_0._points.Clone();
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x000109E2 File Offset: 0x0000EBE2
		protected Polygon(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._points = (Vector3FArrayList)serializationInfo_0.GetValue("Points", typeof(Vector3FArrayList));
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0009AF04 File Offset: 0x00099104
		object ICloneable.Clone()
		{
			return new Polygon(this);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00010A15 File Offset: 0x0000EC15
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Points", this._points, typeof(Vector3FArrayList));
		}

		// Token: 0x04000A5B RID: 2651
		private Vector3FArrayList _points = new Vector3FArrayList();
	}
}
