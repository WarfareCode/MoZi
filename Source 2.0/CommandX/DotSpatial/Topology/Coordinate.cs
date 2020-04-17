using System;
using ns24;
using ns25;

namespace DotSpatial.Topology
{
	// Token: 0x020004DD RID: 1245
	[Serializable]
	public class Coordinate : IComparable<Coordinate>, IComparable, ICloneable
	{
		// Token: 0x17000250 RID: 592
		public double this[int int_0]
		{
			get
			{
				double result;
				switch (int_0)
				{
				case 0:
					result = this.X;
					break;
				case 1:
					result = this.Y;
					break;
				case 2:
					result = this.Z;
					break;
				default:
					throw new IndexOutOfRangeException();
				}
				return result;
			}
			set
			{
				switch (int_0)
				{
				case 0:
					this.X = value;
					break;
				case 1:
					this.Y = value;
					break;
				case 2:
					this.Z = value;
					break;
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x000D41D8 File Offset: 0x000D23D8
		public Coordinate()
		{
			this.X = double.NaN;
			this.Y = double.NaN;
			this.Z = double.NaN;
			this.M = double.NaN;
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00013875 File Offset: 0x00011A75
		public Coordinate(double double_0, double double_1)
		{
			this.X = double_0;
			this.Y = double_1;
			this.Z = double.NaN;
			this.M = double.NaN;
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x000D4228 File Offset: 0x000D2428
		public Coordinate(ICoordinate c)
		{
			double[] values = c.GetValues();
			if (values.Length > 0)
			{
				this.X = values[0];
			}
			if (values.Length > 1)
			{
				this.Y = values[1];
			}
			if (values.Length > 2)
			{
				this.Z = values[2];
			}
			this.M = c.GetM();
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x000138A9 File Offset: 0x00011AA9
		public Coordinate(Coordinate coordinate_0)
		{
			this.X = coordinate_0.X;
			this.Y = coordinate_0.Y;
			this.Z = coordinate_0.Z;
			this.M = coordinate_0.M;
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x000138E1 File Offset: 0x00011AE1
		public Coordinate(double double_0, double double_1, double double_2, double double_3)
		{
			this.X = double_0;
			this.Y = double_1;
			this.Z = double_2;
			this.M = double_3;
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x000D428C File Offset: 0x000D248C
		public override bool Equals(object obj)
		{
			bool result;
			if (!(obj is Coordinate))
			{
				ICoordinate coordinate = obj as ICoordinate;
				if (coordinate == null)
				{
					result = false;
				}
				else if (!double.IsNaN(this.Z) && !double.IsNaN(coordinate.GetZ()))
				{
					result = (coordinate.GetX() == this.X && coordinate.GetY() == this.Y && coordinate.GetZ() == this.Z);
				}
				else
				{
					result = (coordinate.GetX() == this.X && coordinate.GetY() == this.Y);
				}
			}
			else
			{
				Coordinate coordinate2 = (Coordinate)obj;
				if (!double.IsNaN(this.Z) && !double.IsNaN(coordinate2.Z))
				{
					result = (coordinate2.X == this.X && coordinate2.Y == this.Y && coordinate2.Z == this.Z);
				}
				else
				{
					result = (coordinate2.X == this.X && coordinate2.Y == this.Y);
				}
			}
			return result;
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x0005CD70 File Offset: 0x0005AF70
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x000D43A8 File Offset: 0x000D25A8
		public double[] ToArray()
		{
			double[] result;
			if (!double.IsNaN(this.Z))
			{
				result = new double[]
				{
					this.X,
					this.Y,
					this.Z
				};
			}
			else
			{
				result = new double[]
				{
					this.X,
					this.Y
				};
			}
			return result;
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x000D4404 File Offset: 0x000D2604
		public double Distance(Coordinate end)
		{
			double num = end.X - this.X;
			double num2 = end.Y - this.Y;
			return Math.Sqrt(num * num + num2 * num2);
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x00013906 File Offset: 0x00011B06
		public bool Equals2D(Coordinate b)
		{
			return this.X == b.X && this.Y == b.Y;
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x000D443C File Offset: 0x000D263C
		public new string ToString()
		{
			string text = "(" + this.X;
			for (int i = 1; i < this.GetNumOrdinates(); i++)
			{
				text = text + ", " + this[i];
			}
			return text + ")";
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x000D4498 File Offset: 0x000D2698
		public static Coordinate GetEmpty()
		{
			return new Coordinate(double.NaN, double.NaN);
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x000D44C0 File Offset: 0x000D26C0
		public int GetNumOrdinates()
		{
			int result;
			if (!double.IsNaN(this.Z))
			{
				result = 3;
			}
			else
			{
				result = 2;
			}
			return result;
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x000D44E4 File Offset: 0x000D26E4
		int IComparable.CompareTo(object obj)
		{
			Coordinate coordinate = obj as Coordinate;
			if (Coordinate.Equals(coordinate, null))
			{
				throw new ArgumentException(TopologyText.GetArgumentCannotBeNegative_S().Replace("%S1", "other").Replace("%S2", "ICoordinate"));
			}
			int result;
			if (this.X < coordinate.X)
			{
				result = -1;
			}
			else if (this.X > coordinate.X)
			{
				result = 1;
			}
			else if (this.Y < coordinate.Y)
			{
				result = -1;
			}
			else if (this.Y > coordinate.Y)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x000D458C File Offset: 0x000D278C
		public virtual int CompareTo(Coordinate other)
		{
			if (Coordinate.Equals(other, null))
			{
				throw new ArgumentException(TopologyText.GetArgumentCannotBeNegative_S().Replace("%S1", "other").Replace("%S2", "ICoordinate"));
			}
			int result;
			if (this.X < other.X)
			{
				result = -1;
			}
			else if (this.X > other.X)
			{
				result = 1;
			}
			else if (this.Y < other.Y)
			{
				result = -1;
			}
			else if (this.Y > other.Y)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x00013927 File Offset: 0x00011B27
		public bool IsEmpty()
		{
			return double.IsNaN(this.X) || double.IsNaN(this.Y);
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x000CA808 File Offset: 0x000C8A08
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00004A84 File Offset: 0x00002C84
		public static bool Equals(Coordinate coordinate_0, Coordinate coordinate_1)
		{
			return object.Equals(coordinate_0, coordinate_1);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00013944 File Offset: 0x00011B44
		public static bool NotEquals(Coordinate coordinate_0, Coordinate coordinate_1)
		{
			return !Coordinate.Equals(coordinate_0, coordinate_1);
		}

		// Token: 0x04000FC4 RID: 4036
		public double M;

		// Token: 0x04000FC5 RID: 4037
		public double X;

		// Token: 0x04000FC6 RID: 4038
		public double Y;

		// Token: 0x04000FC7 RID: 4039
		public double Z;
	}
}
