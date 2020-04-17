using System;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns16;
using ns28;

namespace ns25
{
	// Token: 0x02000632 RID: 1586
	public sealed class Class2236
	{
		// Token: 0x06002842 RID: 10306 RVA: 0x0001652A File Offset: 0x0001472A
		public Class2236(IGeometry igeometry_0) : this(Class2236.smethod_0(igeometry_0), igeometry_0.GetFactory())
		{
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x0001653E File Offset: 0x0001473E
		public Class2236(Coordinate[] coordinate_1, IGeometryFactory igeometryFactory_1)
		{
			this.coordinate_0 = coordinate_1;
			this.igeometryFactory_0 = igeometryFactory_1;
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x000F2D00 File Offset: 0x000F0F00
		private static Coordinate[] smethod_0(IGeometry igeometry_0)
		{
			Class2350 @class = new Class2350();
			igeometry_0.Apply(@class);
			return @class.vmethod_0();
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x000F2D24 File Offset: 0x000F0F24
		public  IGeometry vmethod_0()
		{
			IGeometry result;
			if (this.coordinate_0.Length == 0)
			{
				result = this.igeometryFactory_0.CreateGeometryCollection(null);
			}
			else if (this.coordinate_0.Length == 1)
			{
				result = this.igeometryFactory_0.CreatePoint(this.coordinate_0[0]);
			}
			else if (this.coordinate_0.Length == 2)
			{
				result = this.igeometryFactory_0.CreateLineString(this.coordinate_0);
			}
			else
			{
				Coordinate[] coordinate_ = this.coordinate_0;
				if (this.coordinate_0.Length > 50)
				{
					coordinate_ = Class2236.smethod_1(this.coordinate_0);
				}
				Coordinate[] coordinate_2 = Class2236.smethod_2(coordinate_);
				Stack<Coordinate> stack = Class2236.smethod_3(coordinate_2);
				Coordinate[] coordinate_3 = stack.ToArray();
				result = this.method_0(coordinate_3);
			}
			return result;
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x000F2DE4 File Offset: 0x000F0FE4
		private static Coordinate[] smethod_1(Coordinate[] coordinate_1)
		{
			Coordinate[] array = Class2236.smethod_5(coordinate_1);
			Coordinate[] result;
			if (array == null)
			{
				result = coordinate_1;
			}
			else
			{
				SortedSet<Coordinate> sortedSet = new SortedSet<Coordinate>();
				for (int i = 0; i < array.Length; i++)
				{
					sortedSet.Add(array[i]);
				}
				for (int j = 0; j < coordinate_1.Length; j++)
				{
					if (!CgAlgorithms.IsPointInRing(coordinate_1[j], array))
					{
						sortedSet.Add(coordinate_1[j]);
					}
				}
				Coordinate[] array2 = new Coordinate[sortedSet.Count];
				sortedSet.CopyTo(array2, 0);
				result = array2;
			}
			return result;
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x000F2E6C File Offset: 0x000F106C
		private static Coordinate[] smethod_2(Coordinate[] coordinate_1)
		{
			for (int i = 1; i < coordinate_1.Length; i++)
			{
				if (coordinate_1[i].Y < coordinate_1[0].Y || (coordinate_1[i].Y == coordinate_1[0].Y && coordinate_1[i].X < coordinate_1[0].X))
				{
					Coordinate coordinate = coordinate_1[0];
					coordinate_1[0] = coordinate_1[i];
					coordinate_1[i] = coordinate;
				}
			}
			Array.Sort<Coordinate>(coordinate_1, 1, coordinate_1.Length - 1, new Class2236.Class2237(coordinate_1[0]));
			return coordinate_1;
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x000F2EF0 File Offset: 0x000F10F0
		private static Stack<Coordinate> smethod_3(Coordinate[] coordinate_1)
		{
			Stack<Coordinate> stack = new Stack<Coordinate>(coordinate_1.Length);
			stack.Push(coordinate_1[0]);
			stack.Push(coordinate_1[1]);
			stack.Push(coordinate_1[2]);
			for (int i = 3; i < coordinate_1.Length; i++)
			{
				Coordinate coordinate = stack.Pop();
				while (CgAlgorithms.ComputeOrientation(stack.Peek(), coordinate, coordinate_1[i]) > 0)
				{
					coordinate = stack.Pop();
				}
				stack.Push(coordinate);
				stack.Push(coordinate_1[i]);
			}
			stack.Push(coordinate_1[0]);
			return stack;
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x000F2F74 File Offset: 0x000F1174
		private static bool smethod_4(Coordinate coordinate_1, Coordinate coordinate_2, Coordinate coordinate_3)
		{
			bool result;
			if (CgAlgorithms.ComputeOrientation(coordinate_1, coordinate_2, coordinate_3) != 0)
			{
				result = false;
			}
			else
			{
				if (coordinate_1.X != coordinate_3.X)
				{
					if (coordinate_1.X <= coordinate_2.X && coordinate_2.X <= coordinate_3.X)
					{
						result = true;
						return result;
					}
					if (coordinate_3.X <= coordinate_2.X && coordinate_2.X <= coordinate_1.X)
					{
						result = true;
						return result;
					}
				}
				if (coordinate_1.Y != coordinate_3.Y)
				{
					if (coordinate_1.Y <= coordinate_2.Y && coordinate_2.Y <= coordinate_3.Y)
					{
						result = true;
						return result;
					}
					if (coordinate_3.Y <= coordinate_2.Y && coordinate_2.Y <= coordinate_1.Y)
					{
						result = true;
						return result;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x000F3050 File Offset: 0x000F1250
		private static Coordinate[] smethod_5(Coordinate[] coordinate_1)
		{
			Coordinate[] ienumerable_ = Class2236.smethod_6(coordinate_1);
			Class833 @class = new Class833();
			@class.vmethod_9(ienumerable_, false);
			Class833 class2 = @class;
			Coordinate[] result;
			if (class2.Count < 3)
			{
				result = null;
			}
			else
			{
				class2.vmethod_11();
				result = class2.vmethod_12();
			}
			return result;
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x000F3094 File Offset: 0x000F1294
		private static Coordinate[] smethod_6(Coordinate[] coordinate_1)
		{
			Coordinate[] array = new Coordinate[8];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = coordinate_1[0];
			}
			for (int j = 1; j < coordinate_1.Length; j++)
			{
				if (coordinate_1[j].X < array[0].X)
				{
					array[0] = coordinate_1[j];
				}
				if (coordinate_1[j].X - coordinate_1[j].Y < array[1].X - array[1].Y)
				{
					array[1] = coordinate_1[j];
				}
				if (coordinate_1[j].Y > array[2].Y)
				{
					array[2] = coordinate_1[j];
				}
				if (coordinate_1[j].X + coordinate_1[j].Y > array[3].X + array[3].Y)
				{
					array[3] = coordinate_1[j];
				}
				if (coordinate_1[j].X > array[4].X)
				{
					array[4] = coordinate_1[j];
				}
				if (coordinate_1[j].X - coordinate_1[j].Y > array[5].X - array[5].Y)
				{
					array[5] = coordinate_1[j];
				}
				if (coordinate_1[j].Y < array[6].Y)
				{
					array[6] = coordinate_1[j];
				}
				if (coordinate_1[j].X + coordinate_1[j].Y < array[7].X + array[7].Y)
				{
					array[7] = coordinate_1[j];
				}
			}
			return array;
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x000F3208 File Offset: 0x000F1408
		private IGeometry method_0(Coordinate[] coordinate_1)
		{
			coordinate_1 = Class2236.smethod_7(coordinate_1);
			IGeometry result;
			if (coordinate_1.Length == 3)
			{
				result = this.igeometryFactory_0.CreateLineString(new Coordinate[]
				{
					coordinate_1[0],
					coordinate_1[1]
				});
			}
			else
			{
				ILinearRing ilinearRing_ = this.igeometryFactory_0.CreateLinearRing(coordinate_1);
				result = this.igeometryFactory_0.CreatePolygon(ilinearRing_, null);
			}
			return result;
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x000F3268 File Offset: 0x000F1468
		private static Coordinate[] smethod_7(Coordinate[] coordinate_1)
		{
			object.Equals(coordinate_1[0], coordinate_1[coordinate_1.Length - 1]);
			List<Coordinate> list = new List<Coordinate>();
			Coordinate coordinate = Coordinate.GetEmpty();
			for (int i = 0; i <= coordinate_1.Length - 2; i++)
			{
				Coordinate coordinate2 = coordinate_1[i];
				Coordinate coordinate3 = coordinate_1[i + 1];
				if (!coordinate2.Equals(coordinate3) && (coordinate.IsEmpty() || !Class2236.smethod_4(coordinate, coordinate2, coordinate3)))
				{
					list.Add(coordinate2);
					coordinate = coordinate2;
				}
			}
			list.Add(coordinate_1[coordinate_1.Length - 1]);
			return list.ToArray();
		}

		// Token: 0x04001347 RID: 4935
		private readonly IGeometryFactory igeometryFactory_0;

		// Token: 0x04001348 RID: 4936
		private readonly Coordinate[] coordinate_0;

		// Token: 0x02000633 RID: 1587
		private sealed class Class2237 : IComparer<Coordinate>
		{
			// Token: 0x0600284E RID: 10318 RVA: 0x00016554 File Offset: 0x00014754
			public Class2237(Coordinate coordinate_1)
			{
				this.coordinate_0 = coordinate_1;
			}

			// Token: 0x0600284F RID: 10319 RVA: 0x000F32F4 File Offset: 0x000F14F4
			public int Compare(Coordinate x, Coordinate y)
			{
				return Class2236.Class2237.smethod_0(this.coordinate_0, x, y);
			}

			// Token: 0x06002850 RID: 10320 RVA: 0x000F3310 File Offset: 0x000F1510
			private static int smethod_0(Coordinate coordinate_1, Coordinate coordinate_2, Coordinate coordinate_3)
			{
				double num = coordinate_2.X - coordinate_1.X;
				double num2 = coordinate_2.Y - coordinate_1.Y;
				double num3 = coordinate_3.X - coordinate_1.X;
				double num4 = coordinate_3.Y - coordinate_1.Y;
				int num5 = CgAlgorithms.ComputeOrientation(coordinate_1, coordinate_2, coordinate_3);
				int result;
				if (num5 == 1)
				{
					result = 1;
				}
				else if (num5 == -1)
				{
					result = -1;
				}
				else
				{
					double num6 = num * num + num2 * num2;
					double num7 = num3 * num3 + num4 * num4;
					if (num6 < num7)
					{
						result = -1;
					}
					else if (num6 > num7)
					{
						result = 1;
					}
					else
					{
						result = 0;
					}
				}
				return result;
			}

			// Token: 0x04001349 RID: 4937
			private readonly Coordinate coordinate_0 = Coordinate.GetEmpty();
		}
	}
}
