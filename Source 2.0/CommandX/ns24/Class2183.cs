using System;
using DotSpatial.Topology;
using ns16;

namespace ns24
{
	// Token: 0x02000521 RID: 1313
	internal static class Class2183
	{
		// Token: 0x060021CB RID: 8651 RVA: 0x000DC338 File Offset: 0x000DA538
		public static double smethod_0(IEnvelope ienvelope_0)
		{
			return ienvelope_0.GetY() - ienvelope_0.GetHeight();
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x000DC354 File Offset: 0x000DA554
		public static Coordinate smethod_1(IEnvelope ienvelope_0)
		{
			return new Coordinate(Class2183.smethod_3(ienvelope_0), Class2183.smethod_0(ienvelope_0));
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x000DC374 File Offset: 0x000DA574
		public static Coordinate smethod_2(IEnvelope ienvelope_0)
		{
			return new Coordinate(Class2183.smethod_4(ienvelope_0), Class2183.smethod_0(ienvelope_0));
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x000DC394 File Offset: 0x000DA594
		public static double smethod_3(IEnvelope ienvelope_0)
		{
			return ienvelope_0.GetX();
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x000DC3AC File Offset: 0x000DA5AC
		public static double smethod_4(IEnvelope ienvelope_0)
		{
			return ienvelope_0.GetX() + ienvelope_0.GetWidth();
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x000DC3C8 File Offset: 0x000DA5C8
		public static ILinearRing smethod_5(IEnvelope ienvelope_0)
		{
			return new LinearRing(new Class2182
			{
				Class2183.smethod_6(ienvelope_0),
				Class2183.smethod_7(ienvelope_0),
				Class2183.smethod_2(ienvelope_0),
				Class2183.smethod_1(ienvelope_0),
				Class2183.smethod_6(ienvelope_0)
			});
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x000DC420 File Offset: 0x000DA620
		public static Coordinate smethod_6(IEnvelope ienvelope_0)
		{
			return new Coordinate(ienvelope_0.GetMinimum().X, ienvelope_0.GetMaximum().Y);
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x000DC44C File Offset: 0x000DA64C
		public static Coordinate smethod_7(IEnvelope ienvelope_0)
		{
			return new Coordinate(ienvelope_0.GetMaximum().X, ienvelope_0.GetMaximum().Y);
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x000DC478 File Offset: 0x000DA678
		public static bool smethod_8(IEnvelope ienvelope_0, Coordinate coordinate_0)
		{
			bool result;
			if (ienvelope_0 == null)
			{
				result = false;
			}
			else if (ienvelope_0.IsNull())
			{
				result = false;
			}
			else
			{
				int num = Math.Min(ienvelope_0.GetNumOrdinates(), coordinate_0.GetNumOrdinates());
				for (int i = 0; i < num; i++)
				{
					if (coordinate_0[i] < ienvelope_0.GetMinimum()[i] || coordinate_0[i] > ienvelope_0.GetMaximum()[i])
					{
						result = false;
						return result;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x000DC4FC File Offset: 0x000DA6FC
		public static bool smethod_9(IEnvelope ienvelope_0, IEnvelope ienvelope_1)
		{
			bool result;
			if (ienvelope_0 == null || ienvelope_1 == null)
			{
				result = false;
			}
			else if (!ienvelope_0.IsNull() && !ienvelope_1.IsNull())
			{
				int num = Math.Min(ienvelope_0.GetNumOrdinates(), ienvelope_1.GetNumOrdinates());
				for (int i = 0; i < num; i++)
				{
					if (ienvelope_1.GetMinimum()[i] < ienvelope_0.GetMinimum()[i] || ienvelope_1.GetMaximum()[i] > ienvelope_0.GetMaximum()[i])
					{
						result = false;
						return result;
					}
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x000DC598 File Offset: 0x000DA798
		public static double smethod_10(IEnvelope ienvelope_0, IEnvelope ienvelope_1)
		{
			double result;
			if (ienvelope_0 == null)
			{
				result = -1.0;
			}
			else if (ienvelope_1 == null)
			{
				result = -1.0;
			}
			else
			{
				result = Class2183.smethod_11(ienvelope_0, ienvelope_1, Math.Min(ienvelope_0.GetNumOrdinates(), ienvelope_1.GetNumOrdinates()));
			}
			return result;
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x000DC5EC File Offset: 0x000DA7EC
		private static double smethod_11(IEnvelope ienvelope_0, IEnvelope ienvelope_1, int int_0)
		{
			double result;
			if (ienvelope_0 == null || ienvelope_1 == null)
			{
				result = -1.0;
			}
			else if (ienvelope_0.IsNull() || ienvelope_1.IsNull())
			{
				result = -1.0;
			}
			else
			{
				if (ienvelope_0.GetNumOrdinates() < int_0 && ienvelope_1.GetNumOrdinates() < int_0)
				{
					throw new Exception17("both envelopes");
				}
				if (ienvelope_0.GetNumOrdinates() < int_0)
				{
					throw new Exception17("this envelope");
				}
				if (ienvelope_0.GetNumOrdinates() < int_0)
				{
					throw new Exception17("the other envelope");
				}
				if (Class2183.smethod_15(ienvelope_0, ienvelope_1))
				{
					result = 0.0;
				}
				else
				{
					Coordinate coordinate = new Coordinate();
					for (int i = 0; i < coordinate.GetNumOrdinates(); i++)
					{
						if (ienvelope_0.GetMaximum()[i] < ienvelope_1.GetMinimum()[i])
						{
							coordinate[i] = ienvelope_1.GetMinimum().X - ienvelope_0.GetMaximum().X;
						}
						if (ienvelope_0.GetMinimum()[i] > ienvelope_1.GetMaximum()[i])
						{
							coordinate[i] = ienvelope_0.GetMinimum()[i] - ienvelope_1.GetMinimum()[i];
						}
					}
					double num = 0.0;
					for (int j = 0; j < int_0; j++)
					{
						num += coordinate[j] * coordinate[j];
						if (coordinate[j] == 0.0)
						{
							result = 0.0;
							return result;
						}
					}
					result = Math.Sqrt(num);
				}
			}
			return result;
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x000DC7A8 File Offset: 0x000DA9A8
		public static void smethod_12(IEnvelope ienvelope_0, Coordinate coordinate_0)
		{
			if (ienvelope_0 != null)
			{
				if (ienvelope_0.IsNull())
				{
					ienvelope_0.Init(coordinate_0, coordinate_0);
				}
				else
				{
					int num = Math.Min(ienvelope_0.GetNumOrdinates(), coordinate_0.GetNumOrdinates());
					Coordinate minimum = ienvelope_0.GetMinimum();
					Coordinate maximum = ienvelope_0.GetMaximum();
					for (int i = 0; i < num; i++)
					{
						if (coordinate_0[i] < minimum[i])
						{
							minimum[i] = coordinate_0[i];
						}
						if (coordinate_0[i] > maximum[i])
						{
							maximum[i] = coordinate_0[i];
						}
					}
					ienvelope_0.Init(minimum, maximum);
				}
			}
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x000DC854 File Offset: 0x000DAA54
		public static void smethod_13(IEnvelope ienvelope_0, IEnvelope ienvelope_1)
		{
			if (ienvelope_0 != null && ienvelope_1 != null && !ienvelope_1.IsNull())
			{
				if (ienvelope_0.IsNull())
				{
					ienvelope_0.Init(ienvelope_1.GetMinimum(), ienvelope_1.GetMaximum());
				}
				else
				{
					int num = Math.Min(ienvelope_0.GetNumOrdinates(), ienvelope_1.GetNumOrdinates());
					Coordinate minimum = ienvelope_0.GetMinimum();
					Coordinate maximum = ienvelope_0.GetMaximum();
					for (int i = 0; i < num; i++)
					{
						if (ienvelope_1.GetMinimum()[i] < minimum[i])
						{
							minimum[i] = ienvelope_1.GetMinimum()[i];
						}
						if (ienvelope_1.GetMaximum()[i] > maximum[i])
						{
							maximum[i] = ienvelope_1.GetMaximum()[i];
						}
					}
					ienvelope_0.Init(minimum, maximum);
				}
			}
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x000DC93C File Offset: 0x000DAB3C
		public static bool smethod_14(IEnvelope ienvelope_0, Coordinate coordinate_0)
		{
			bool result;
			if (ienvelope_0 == null || Coordinate.Equals(coordinate_0, null))
			{
				result = false;
			}
			else if (ienvelope_0.IsNull())
			{
				result = false;
			}
			else
			{
				int num = Math.Min(ienvelope_0.GetNumOrdinates(), coordinate_0.GetNumOrdinates());
				for (int i = 0; i < num; i++)
				{
					if (coordinate_0[i] < ienvelope_0.GetMinimum()[i] || coordinate_0[i] > ienvelope_0.GetMaximum()[i])
					{
						result = false;
						return result;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x000DC9C8 File Offset: 0x000DABC8
		public static bool smethod_15(IEnvelope ienvelope_0, IEnvelope ienvelope_1)
		{
			bool result;
			if (ienvelope_0 == null || ienvelope_1 == null)
			{
				result = false;
			}
			else if (!ienvelope_0.IsNull() && !ienvelope_1.IsNull())
			{
				int num = Math.Min(ienvelope_0.GetNumOrdinates(), ienvelope_1.GetNumOrdinates());
				for (int i = 0; i < num; i++)
				{
					if (ienvelope_1.GetMinimum()[i] > ienvelope_0.GetMaximum()[i] || ienvelope_1.GetMaximum()[i] < ienvelope_0.GetMinimum()[i])
					{
						result = false;
						return result;
					}
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}
	}
}
