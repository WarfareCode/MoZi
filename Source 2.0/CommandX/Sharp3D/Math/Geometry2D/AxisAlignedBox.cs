using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Sharp3D.Math.Core;

namespace Sharp3D.Math.Geometry2D
{
	// Token: 0x020003DB RID: 987
	[Serializable]
	public struct AxisAlignedBox : ICloneable, ISerializable
	{
		// Token: 0x0600187C RID: 6268 RVA: 0x00010403 File Offset: 0x0000E603
		public AxisAlignedBox(Vector2F vector2F_0, Vector2F vector2F_1)
		{
			this._min = vector2F_0;
			this._max = vector2F_1;
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00010413 File Offset: 0x0000E613
		public AxisAlignedBox(AxisAlignedBox axisAlignedBox_0)
		{
			this._min = axisAlignedBox_0.method_0();
			this._max = axisAlignedBox_0.method_1();
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00097738 File Offset: 0x00095938
		private AxisAlignedBox(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._min = (Vector2F)serializationInfo_0.GetValue("Min", typeof(Vector2F));
			this._max = (Vector2F)serializationInfo_0.GetValue("Max", typeof(Vector2F));
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00097788 File Offset: 0x00095988
		public Vector2F method_0()
		{
			return this._min;
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000977A0 File Offset: 0x000959A0
		public Vector2F method_1()
		{
			return this._max;
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x000977B8 File Offset: 0x000959B8
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Max", this._max, typeof(Vector2F));
			info.AddValue("Min", this._min, typeof(Vector2F));
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00097808 File Offset: 0x00095A08
		object ICloneable.Clone()
		{
			return new AxisAlignedBox(this);
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00097828 File Offset: 0x00095A28
		public static AxisAlignedBox smethod_0(string string_0)
		{
			Regex regex = new Regex("AxisAlignedBox\\(Min=(?<min>\\([^\\)]*\\)), Max=(?<max>\\([^\\)]*\\))\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new AxisAlignedBox(Vector2F.smethod_0(match.Result("${min}")), Vector2F.smethod_0(match.Result("${max}")));
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00097884 File Offset: 0x00095A84
		public override int GetHashCode()
		{
			return this._min.GetHashCode() ^ this._max.GetHashCode();
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x000978B8 File Offset: 0x00095AB8
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is AxisAlignedBox)
			{
				AxisAlignedBox axisAlignedBox = (AxisAlignedBox)obj;
				result = (Vector2F.smethod_1(this._min, axisAlignedBox.method_0()) && Vector2F.smethod_1(this._max, axisAlignedBox.method_1()));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0009790C File Offset: 0x00095B0C
		public override string ToString()
		{
			return string.Format("AxisAlignedBox(Min={0}, Max={1})", this._min, this._max);
		}

		// Token: 0x04000A20 RID: 2592
		private Vector2F _min;

		// Token: 0x04000A21 RID: 2593
		private Vector2F _max;
	}
}
