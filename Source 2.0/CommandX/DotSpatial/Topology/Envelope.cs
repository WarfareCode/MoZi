using System;
using System.ComponentModel;
using ns15;
using ns24;

namespace DotSpatial.Topology
{
	// Token: 0x0200050A RID: 1290
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public sealed class Envelope : ICloneable, Interface29, IEnvelope
	{
		// Token: 0x06002193 RID: 8595 RVA: 0x0001406E File Offset: 0x0001226E
		public Envelope()
		{
			this.DoInit();
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x000DBABC File Offset: 0x000D9CBC
		public Envelope(double double_0, double double_1, double double_2, double double_3)
		{
			Coordinate min = new Coordinate(Math.Min(double_0, double_1), Math.Min(double_2, double_3));
			Coordinate max = new Coordinate(Math.Max(double_0, double_1), Math.Max(double_2, double_3));
			this.DoInit(min, max);
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x000DBB04 File Offset: 0x000D9D04
		public Envelope(IEnvelope ienvelope_0)
		{
			Coordinate min = Class835.smethod_0<Coordinate>(ienvelope_0.GetMinimum());
			Coordinate max = Class835.smethod_0<Coordinate>(ienvelope_0.GetMaximum());
			this.DoInit(min, max);
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x000DBB38 File Offset: 0x000D9D38
		public Envelope(Coordinate coordinate_0, Coordinate coordinate_1)
		{
			if (!Coordinate.Equals(coordinate_0, null) && !Coordinate.Equals(coordinate_1, null))
			{
				int num = Math.Min(coordinate_0.GetNumOrdinates(), coordinate_1.GetNumOrdinates());
				this._min = new Coordinate();
				this._max = new Coordinate();
				for (int i = 0; i < num; i++)
				{
					this._min[i] = Math.Min(coordinate_0[i], coordinate_1[i]);
					this._max[i] = Math.Max(coordinate_0[i], coordinate_1[i]);
				}
				this._min.M = Math.Min(coordinate_0.M, coordinate_1.M);
				this._max.M = Math.Min(coordinate_0.M, coordinate_1.M);
			}
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x000DBC10 File Offset: 0x000D9E10
		public  void Init(Coordinate p1, Coordinate p2)
		{
			if (Coordinate.Equals(p1, null) && Coordinate.Equals(p2, null))
			{
				this.Init();
			}
			else if (Coordinate.Equals(p1, null))
			{
				this.Init(p2, p2);
			}
			else if (Coordinate.Equals(p2, null))
			{
				this.Init(p1, p1);
			}
			else
			{
				int num = Math.Min(p1.GetNumOrdinates(), p2.GetNumOrdinates());
				this._min = new Coordinate();
				this._max = new Coordinate();
				for (int i = 0; i < num; i++)
				{
					this._min[i] = Math.Min(p1[i], p2[i]);
					this._max[i] = Math.Max(p1[i], p2[i]);
				}
				this._min.M = Math.Min(p1.M, p2.M);
				this._max.M = Math.Min(p1.M, p2.M);
				this.OnEnvelopeChanged();
			}
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x0001407C File Offset: 0x0001227C
		private void DoInit()
		{
			this._min = new Coordinate(0.0, 0.0);
			this._max = new Coordinate(-1.0, -1.0);
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x000140B8 File Offset: 0x000122B8
		private void DoInit(Coordinate min, Coordinate max)
		{
			this._min = min;
			this._max = max;
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x000140C8 File Offset: 0x000122C8
		public  void Init()
		{
			this.SetToNull();
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x000DBD24 File Offset: 0x000D9F24
		public  object Clone()
		{
			return this.Copy();
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x000DBD3C File Offset: 0x000D9F3C
		public  void SetToNull()
		{
			this._min = new Coordinate();
			this._max = new Coordinate();
			for (int i = 0; i < this.GetNumOrdinates(); i++)
			{
				this._min[i] = 0.0;
				this._max[i] = -1.0;
			}
			this.OnEnvelopeChanged();
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x000DBDA4 File Offset: 0x000D9FA4
		public  Envelope Copy()
		{
			Envelope result;
			if (this.IsNull())
			{
				result = new Envelope();
			}
			else
			{
				result = new Envelope(this._min, this._max);
			}
			return result;
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x000DBDD8 File Offset: 0x000D9FD8
		public static bool Intersects(Coordinate p1, Coordinate p2, Coordinate q)
		{
			Envelope ienvelope_ = new Envelope(p1, p2);
			return Class2183.smethod_14(ienvelope_, q);
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x000DBDF4 File Offset: 0x000D9FF4
		public static bool Intersects(Coordinate p1, Coordinate p2, Coordinate q1, Coordinate q2)
		{
			Envelope ienvelope_ = new Envelope(p1, p2);
			Envelope ienvelope_2 = new Envelope(q1, q2);
			return Class2183.smethod_15(ienvelope_, ienvelope_2);
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x000DBE18 File Offset: 0x000DA018
		public Coordinate GetMinimum()
		{
			return this._min;
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x000DBE30 File Offset: 0x000DA030
		public Coordinate GetMaximum()
		{
			return this._max;
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x000DBE48 File Offset: 0x000DA048
		public int GetNumOrdinates()
		{
			return this._min.GetNumOrdinates();
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x000140D0 File Offset: 0x000122D0
		public  bool IsNull()
		{
			return Coordinate.Equals(this._max, null) || Coordinate.Equals(this._min, null) || this._max.X < this._min.X;
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x000DBE64 File Offset: 0x000DA064
		public  double GetHeight()
		{
			double result;
			if (this.IsNull())
			{
				result = 0.0;
			}
			else
			{
				result = this.GetMaximum().Y - this.GetMinimum().Y;
			}
			return result;
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x000DBEA4 File Offset: 0x000DA0A4
		public  double GetWidth()
		{
			double result;
			if (this.IsNull())
			{
				result = 0.0;
			}
			else
			{
				result = this._max.X - this._min.X;
			}
			return result;
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x000DBEE4 File Offset: 0x000DA0E4
		public  double GetX()
		{
			return this._min.X;
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x000DBF00 File Offset: 0x000DA100
		public  double GetY()
		{
			return this._max.Y;
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x000DBF1C File Offset: 0x000DA11C
		public override string ToString()
		{
			string text = "Env[";
			for (int i = 0; i < this.GetNumOrdinates(); i++)
			{
				if (i > 0)
				{
					text += ", ";
				}
				object obj = text;
				text = string.Concat(new object[]
				{
					obj,
					this.GetMinimum()[i],
					" : ",
					this.GetMaximum()[i]
				});
			}
			return text;
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x00014109 File Offset: 0x00012309
		protected void OnEnvelopeChanged()
		{
			if (this.EnvelopeChanged != null)
			{
				this.EnvelopeChanged(this, new EventArgs());
			}
		}

		// Token: 0x04001048 RID: 4168
		private Coordinate _max;

		// Token: 0x04001049 RID: 4169
		private Coordinate _min;

		// Token: 0x0400104A RID: 4170
		private EventHandler EnvelopeChanged;
	}
}
