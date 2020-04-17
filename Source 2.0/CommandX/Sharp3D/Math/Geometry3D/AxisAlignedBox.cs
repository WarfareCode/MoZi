using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Sharp3D.Math.Core;

namespace Sharp3D.Math.Geometry3D
{
	// Token: 0x020003EF RID: 1007
	public struct AxisAlignedBox : ICloneable, ISerializable
	{
		// Token: 0x0600190C RID: 6412 RVA: 0x000106CB File Offset: 0x0000E8CB
		public AxisAlignedBox(Vector3F vector3F_0, Vector3F vector3F_1)
		{
			this._min = vector3F_0;
			this._max = vector3F_1;
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x000106DB File Offset: 0x0000E8DB
		public AxisAlignedBox(AxisAlignedBox axisAlignedBox_0)
		{
			this._min = axisAlignedBox_0.method_0();
			this._max = axisAlignedBox_0.method_1();
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00099AA8 File Offset: 0x00097CA8
		private AxisAlignedBox(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			this._min = (Vector3F)serializationInfo_0.GetValue("Min", typeof(Vector3F));
			this._max = (Vector3F)serializationInfo_0.GetValue("Max", typeof(Vector3F));
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00099AF8 File Offset: 0x00097CF8
		public Vector3F method_0()
		{
			return this._min;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00099B10 File Offset: 0x00097D10
		public Vector3F method_1()
		{
			return this._max;
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00099B28 File Offset: 0x00097D28
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Max", this._max, typeof(Vector3F));
			info.AddValue("Min", this._min, typeof(Vector3F));
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00099B78 File Offset: 0x00097D78
		object ICloneable.Clone()
		{
			return new AxisAlignedBox(this);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00099B98 File Offset: 0x00097D98
		public static AxisAlignedBox smethod_0(string string_0)
		{
			Regex regex = new Regex("AxisAlignedBox\\(Min=(?<min>\\([^\\)]*\\)), Max=(?<max>\\([^\\)]*\\))\\)", RegexOptions.None);
			Match match = regex.Match(string_0);
			if (!match.Success)
			{
				throw new ParseException("Unsuccessful Match.");
			}
			return new AxisAlignedBox(Vector3F.smethod_0(match.Result("${min}")), Vector3F.smethod_0(match.Result("${max}")));
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00099BF4 File Offset: 0x00097DF4
		public override int GetHashCode()
		{
			return this._min.GetHashCode() ^ this._max.GetHashCode();
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00099C28 File Offset: 0x00097E28
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is AxisAlignedBox)
			{
				AxisAlignedBox axisAlignedBox = (AxisAlignedBox)obj;
				result = (Vector3F.smethod_2(this._min, axisAlignedBox.method_0()) && Vector3F.smethod_2(this._max, axisAlignedBox.method_1()));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00099C7C File Offset: 0x00097E7C
		public override string ToString()
		{
			return string.Format("AxisAlignedBox(Min={0}, Max={1})", this._min, this._max);
		}

		// Token: 0x04000A44 RID: 2628
		private Vector3F _min;

		// Token: 0x04000A45 RID: 2629
		private Vector3F _max;
	}
}
