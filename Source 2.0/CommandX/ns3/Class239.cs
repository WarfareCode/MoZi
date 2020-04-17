using System;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3
{
	// Token: 0x02000C3A RID: 3130
	public sealed class Class239
	{
		// Token: 0x06006896 RID: 26774 RVA: 0x0037262C File Offset: 0x0037082C
		public static void smethod_0(ref Class242.Struct27 struct27_0, ref Class242.Class243 class243_0)
		{
			Class239.double_0 = struct27_0.double_0;
			Class239.double_1 = struct27_0.double_1;
			Class239.double_2 = struct27_0.double_2;
			Class239.double_3 = struct27_0.double_3;
			Class239.double_4 = struct27_0.double_4;
			Class239.double_5 = struct27_0.double_5;
			Class239.double_6 = struct27_0.double_6;
			Class239.double_7 = struct27_0.double_7;
			Class239.double_8 = struct27_0.double_8;
			Class239.double_9 = struct27_0.double_9;
			Class239.double_10 = struct27_0.double_10;
			Class239.double_11 = struct27_0.double_11;
			Class239.double_12 = struct27_0.double_12;
			int num = 1;
			Class239.smethod_3(ref num, ref class243_0);
			struct27_0.double_0 = Class239.double_0;
			struct27_0.double_1 = Class239.double_1;
			struct27_0.double_2 = Class239.double_2;
			struct27_0.double_3 = Class239.double_3;
			struct27_0.double_4 = Class239.double_4;
			struct27_0.double_5 = Class239.double_5;
			struct27_0.double_6 = Class239.double_6;
			struct27_0.double_7 = Class239.double_7;
			struct27_0.double_8 = Class239.double_8;
			struct27_0.double_9 = Class239.double_9;
			struct27_0.double_10 = Class239.double_10;
			struct27_0.double_11 = Class239.double_11;
			struct27_0.double_12 = Class239.double_12;
		}

		// Token: 0x06006897 RID: 26775 RVA: 0x00372764 File Offset: 0x00370964
		public static void smethod_1(ref Class242.Struct28 struct28_0, ref Class242.Class243 class243_0)
		{
			Class239.double_13 = struct28_0.double_0;
			Class239.double_14 = struct28_0.double_1;
			Class239.double_15 = struct28_0.double_2;
			Class239.double_16 = struct28_0.double_3;
			Class239.double_17 = struct28_0.double_4;
			Class239.double_18 = struct28_0.double_5;
			Class239.double_19 = struct28_0.double_6;
			int num = 2;
			Class239.smethod_3(ref num, ref class243_0);
			struct28_0.double_0 = Class239.double_13;
			struct28_0.double_1 = Class239.double_14;
			struct28_0.double_2 = Class239.double_15;
			struct28_0.double_3 = Class239.double_16;
			struct28_0.double_4 = Class239.double_17;
			struct28_0.double_5 = Class239.double_18;
			struct28_0.double_6 = Class239.double_19;
		}

		// Token: 0x06006898 RID: 26776 RVA: 0x00372818 File Offset: 0x00370A18
		public static void smethod_2(ref Class242.Struct29 struct29_0, ref Class242.Class243 class243_0)
		{
			Class239.double_16 = struct29_0.double_0;
			Class239.double_17 = struct29_0.double_1;
			Class239.double_14 = struct29_0.double_2;
			Class239.double_15 = struct29_0.double_3;
			Class239.double_13 = struct29_0.double_4;
			int num = 3;
			Class239.smethod_3(ref num, ref class243_0);
			struct29_0.double_0 = Class239.double_16;
			struct29_0.double_1 = Class239.double_17;
			struct29_0.double_2 = Class239.double_14;
			struct29_0.double_3 = Class239.double_15;
			struct29_0.double_4 = Class239.double_13;
		}

		// Token: 0x06006899 RID: 26777 RVA: 0x003728A0 File Offset: 0x00370AA0
		public static void smethod_3(ref int int_7, ref Class242.Class243 class243_0)
		{
			if (Class239.staticLocalInitFlag_0 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_0, new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_0, ref flag);
				if (Class239.staticLocalInitFlag_0.State == 0)
				{
					Class239.staticLocalInitFlag_0.State = 2;
					Class239.int_0 = 0;
				}
				else if (Class239.staticLocalInitFlag_0.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_0.State = 1;
				if (flag)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_0);
				}
			}
			if (Class239.staticLocalInitFlag_1 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_1, new StaticLocalInitFlag(), null);
			}
			bool flag2 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_1, ref flag2);
				if (Class239.staticLocalInitFlag_1.State == 0)
				{
					Class239.staticLocalInitFlag_1.State = 2;
					Class239.int_1 = 0;
				}
				else if (Class239.staticLocalInitFlag_1.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_1.State = 1;
				if (flag2)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_1);
				}
			}
			if (Class239.staticLocalInitFlag_2 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_2, new StaticLocalInitFlag(), null);
			}
			bool flag3 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_2, ref flag3);
				if (Class239.staticLocalInitFlag_2.State == 0)
				{
					Class239.staticLocalInitFlag_2.State = 2;
					Class239.int_2 = 0;
				}
				else if (Class239.staticLocalInitFlag_2.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_2.State = 1;
				if (flag3)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_2);
				}
			}
			if (Class239.staticLocalInitFlag_3 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_3, new StaticLocalInitFlag(), null);
			}
			bool flag4 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_3, ref flag4);
				if (Class239.staticLocalInitFlag_3.State == 0)
				{
					Class239.staticLocalInitFlag_3.State = 2;
					Class239.int_3 = 0;
				}
				else if (Class239.staticLocalInitFlag_3.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_3.State = 1;
				if (flag4)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_3);
				}
			}
			if (Class239.staticLocalInitFlag_4 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_4, new StaticLocalInitFlag(), null);
			}
			bool flag5 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_4, ref flag5);
				if (Class239.staticLocalInitFlag_4.State == 0)
				{
					Class239.staticLocalInitFlag_4.State = 2;
					Class239.int_4 = 0;
				}
				else if (Class239.staticLocalInitFlag_4.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_4.State = 1;
				if (flag5)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_4);
				}
			}
			if (Class239.staticLocalInitFlag_5 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_5, new StaticLocalInitFlag(), null);
			}
			bool flag6 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_5, ref flag6);
				if (Class239.staticLocalInitFlag_5.State == 0)
				{
					Class239.staticLocalInitFlag_5.State = 2;
					Class239.int_5 = 0;
				}
				else if (Class239.staticLocalInitFlag_5.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_5.State = 1;
				if (flag6)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_5);
				}
			}
			if (Class239.staticLocalInitFlag_6 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_6, new StaticLocalInitFlag(), null);
			}
			bool flag7 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_6, ref flag7);
				if (Class239.staticLocalInitFlag_6.State == 0)
				{
					Class239.staticLocalInitFlag_6.State = 2;
					Class239.int_6 = 0;
				}
				else if (Class239.staticLocalInitFlag_6.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_6.State = 1;
				if (flag7)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_6);
				}
			}
			if (Class239.staticLocalInitFlag_7 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_7, new StaticLocalInitFlag(), null);
			}
			bool flag8 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_7, ref flag8);
				if (Class239.staticLocalInitFlag_7.State == 0)
				{
					Class239.staticLocalInitFlag_7.State = 2;
					Class239.double_20 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_7.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_7.State = 1;
				if (flag8)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_7);
				}
			}
			if (Class239.staticLocalInitFlag_8 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_8, new StaticLocalInitFlag(), null);
			}
			bool flag9 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_8, ref flag9);
				if (Class239.staticLocalInitFlag_8.State == 0)
				{
					Class239.staticLocalInitFlag_8.State = 2;
					Class239.double_21 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_8.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_8.State = 1;
				if (flag9)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_8);
				}
			}
			if (Class239.staticLocalInitFlag_9 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_9, new StaticLocalInitFlag(), null);
			}
			bool flag10 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_9, ref flag10);
				if (Class239.staticLocalInitFlag_9.State == 0)
				{
					Class239.staticLocalInitFlag_9.State = 2;
					Class239.double_22 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_9.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_9.State = 1;
				if (flag10)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_9);
				}
			}
			if (Class239.staticLocalInitFlag_10 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_10, new StaticLocalInitFlag(), null);
			}
			bool flag11 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_10, ref flag11);
				if (Class239.staticLocalInitFlag_10.State == 0)
				{
					Class239.staticLocalInitFlag_10.State = 2;
					Class239.double_23 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_10.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_10.State = 1;
				if (flag11)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_10);
				}
			}
			if (Class239.staticLocalInitFlag_11 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_11, new StaticLocalInitFlag(), null);
			}
			bool flag12 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_11, ref flag12);
				if (Class239.staticLocalInitFlag_11.State == 0)
				{
					Class239.staticLocalInitFlag_11.State = 2;
					Class239.double_24 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_11.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_11.State = 1;
				if (flag12)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_11);
				}
			}
			if (Class239.staticLocalInitFlag_12 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_12, new StaticLocalInitFlag(), null);
			}
			bool flag13 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_12, ref flag13);
				if (Class239.staticLocalInitFlag_12.State == 0)
				{
					Class239.staticLocalInitFlag_12.State = 2;
					Class239.double_25 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_12.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_12.State = 1;
				if (flag13)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_12);
				}
			}
			if (Class239.staticLocalInitFlag_13 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_13, new StaticLocalInitFlag(), null);
			}
			bool flag14 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_13, ref flag14);
				if (Class239.staticLocalInitFlag_13.State == 0)
				{
					Class239.staticLocalInitFlag_13.State = 2;
					Class239.double_26 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_13.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_13.State = 1;
				if (flag14)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_13);
				}
			}
			if (Class239.staticLocalInitFlag_14 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_14, new StaticLocalInitFlag(), null);
			}
			bool flag15 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_14, ref flag15);
				if (Class239.staticLocalInitFlag_14.State == 0)
				{
					Class239.staticLocalInitFlag_14.State = 2;
					Class239.double_27 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_14.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_14.State = 1;
				if (flag15)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_14);
				}
			}
			if (Class239.staticLocalInitFlag_15 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_15, new StaticLocalInitFlag(), null);
			}
			bool flag16 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_15, ref flag16);
				if (Class239.staticLocalInitFlag_15.State == 0)
				{
					Class239.staticLocalInitFlag_15.State = 2;
					Class239.double_28 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_15.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_15.State = 1;
				if (flag16)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_15);
				}
			}
			if (Class239.staticLocalInitFlag_16 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_16, new StaticLocalInitFlag(), null);
			}
			bool flag17 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_16, ref flag17);
				if (Class239.staticLocalInitFlag_16.State == 0)
				{
					Class239.staticLocalInitFlag_16.State = 2;
					Class239.double_29 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_16.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_16.State = 1;
				if (flag17)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_16);
				}
			}
			if (Class239.staticLocalInitFlag_17 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_17, new StaticLocalInitFlag(), null);
			}
			bool flag18 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_17, ref flag18);
				if (Class239.staticLocalInitFlag_17.State == 0)
				{
					Class239.staticLocalInitFlag_17.State = 2;
					Class239.double_30 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_17.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_17.State = 1;
				if (flag18)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_17);
				}
			}
			if (Class239.staticLocalInitFlag_18 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_18, new StaticLocalInitFlag(), null);
			}
			bool flag19 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_18, ref flag19);
				if (Class239.staticLocalInitFlag_18.State == 0)
				{
					Class239.staticLocalInitFlag_18.State = 2;
					Class239.double_31 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_18.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_18.State = 1;
				if (flag19)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_18);
				}
			}
			if (Class239.staticLocalInitFlag_19 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_19, new StaticLocalInitFlag(), null);
			}
			bool flag20 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_19, ref flag20);
				if (Class239.staticLocalInitFlag_19.State == 0)
				{
					Class239.staticLocalInitFlag_19.State = 2;
					Class239.double_32 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_19.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_19.State = 1;
				if (flag20)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_19);
				}
			}
			if (Class239.staticLocalInitFlag_20 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_20, new StaticLocalInitFlag(), null);
			}
			bool flag21 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_20, ref flag21);
				if (Class239.staticLocalInitFlag_20.State == 0)
				{
					Class239.staticLocalInitFlag_20.State = 2;
					Class239.double_33 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_20.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_20.State = 1;
				if (flag21)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_20);
				}
			}
			if (Class239.staticLocalInitFlag_21 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_21, new StaticLocalInitFlag(), null);
			}
			bool flag22 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_21, ref flag22);
				if (Class239.staticLocalInitFlag_21.State == 0)
				{
					Class239.staticLocalInitFlag_21.State = 2;
					Class239.double_34 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_21.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_21.State = 1;
				if (flag22)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_21);
				}
			}
			if (Class239.staticLocalInitFlag_22 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_22, new StaticLocalInitFlag(), null);
			}
			bool flag23 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_22, ref flag23);
				if (Class239.staticLocalInitFlag_22.State == 0)
				{
					Class239.staticLocalInitFlag_22.State = 2;
					Class239.double_35 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_22.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_22.State = 1;
				if (flag23)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_22);
				}
			}
			if (Class239.staticLocalInitFlag_23 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_23, new StaticLocalInitFlag(), null);
			}
			bool flag24 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_23, ref flag24);
				if (Class239.staticLocalInitFlag_23.State == 0)
				{
					Class239.staticLocalInitFlag_23.State = 2;
					Class239.double_36 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_23.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_23.State = 1;
				if (flag24)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_23);
				}
			}
			if (Class239.staticLocalInitFlag_24 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_24, new StaticLocalInitFlag(), null);
			}
			bool flag25 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_24, ref flag25);
				if (Class239.staticLocalInitFlag_24.State == 0)
				{
					Class239.staticLocalInitFlag_24.State = 2;
					Class239.double_37 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_24.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_24.State = 1;
				if (flag25)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_24);
				}
			}
			if (Class239.staticLocalInitFlag_25 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_25, new StaticLocalInitFlag(), null);
			}
			bool flag26 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_25, ref flag26);
				if (Class239.staticLocalInitFlag_25.State == 0)
				{
					Class239.staticLocalInitFlag_25.State = 2;
					Class239.double_38 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_25.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_25.State = 1;
				if (flag26)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_25);
				}
			}
			if (Class239.staticLocalInitFlag_26 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_26, new StaticLocalInitFlag(), null);
			}
			bool flag27 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_26, ref flag27);
				if (Class239.staticLocalInitFlag_26.State == 0)
				{
					Class239.staticLocalInitFlag_26.State = 2;
					Class239.double_39 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_26.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_26.State = 1;
				if (flag27)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_26);
				}
			}
			if (Class239.staticLocalInitFlag_27 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_27, new StaticLocalInitFlag(), null);
			}
			bool flag28 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_27, ref flag28);
				if (Class239.staticLocalInitFlag_27.State == 0)
				{
					Class239.staticLocalInitFlag_27.State = 2;
					Class239.double_40 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_27.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_27.State = 1;
				if (flag28)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_27);
				}
			}
			if (Class239.staticLocalInitFlag_28 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_28, new StaticLocalInitFlag(), null);
			}
			bool flag29 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_28, ref flag29);
				if (Class239.staticLocalInitFlag_28.State == 0)
				{
					Class239.staticLocalInitFlag_28.State = 2;
					Class239.double_41 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_28.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_28.State = 1;
				if (flag29)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_28);
				}
			}
			if (Class239.staticLocalInitFlag_29 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_29, new StaticLocalInitFlag(), null);
			}
			bool flag30 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_29, ref flag30);
				if (Class239.staticLocalInitFlag_29.State == 0)
				{
					Class239.staticLocalInitFlag_29.State = 2;
					Class239.double_42 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_29.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_29.State = 1;
				if (flag30)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_29);
				}
			}
			if (Class239.staticLocalInitFlag_30 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_30, new StaticLocalInitFlag(), null);
			}
			bool flag31 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_30, ref flag31);
				if (Class239.staticLocalInitFlag_30.State == 0)
				{
					Class239.staticLocalInitFlag_30.State = 2;
					Class239.double_43 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_30.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_30.State = 1;
				if (flag31)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_30);
				}
			}
			if (Class239.staticLocalInitFlag_31 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_31, new StaticLocalInitFlag(), null);
			}
			bool flag32 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_31, ref flag32);
				if (Class239.staticLocalInitFlag_31.State == 0)
				{
					Class239.staticLocalInitFlag_31.State = 2;
					Class239.double_44 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_31.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_31.State = 1;
				if (flag32)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_31);
				}
			}
			if (Class239.staticLocalInitFlag_32 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_32, new StaticLocalInitFlag(), null);
			}
			bool flag33 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_32, ref flag33);
				if (Class239.staticLocalInitFlag_32.State == 0)
				{
					Class239.staticLocalInitFlag_32.State = 2;
					Class239.double_45 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_32.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_32.State = 1;
				if (flag33)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_32);
				}
			}
			if (Class239.staticLocalInitFlag_33 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_33, new StaticLocalInitFlag(), null);
			}
			bool flag34 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_33, ref flag34);
				if (Class239.staticLocalInitFlag_33.State == 0)
				{
					Class239.staticLocalInitFlag_33.State = 2;
					Class239.double_46 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_33.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_33.State = 1;
				if (flag34)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_33);
				}
			}
			if (Class239.staticLocalInitFlag_34 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_34, new StaticLocalInitFlag(), null);
			}
			bool flag35 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_34, ref flag35);
				if (Class239.staticLocalInitFlag_34.State == 0)
				{
					Class239.staticLocalInitFlag_34.State = 2;
					Class239.double_47 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_34.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_34.State = 1;
				if (flag35)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_34);
				}
			}
			if (Class239.staticLocalInitFlag_35 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_35, new StaticLocalInitFlag(), null);
			}
			bool flag36 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_35, ref flag36);
				if (Class239.staticLocalInitFlag_35.State == 0)
				{
					Class239.staticLocalInitFlag_35.State = 2;
					Class239.double_48 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_35.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_35.State = 1;
				if (flag36)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_35);
				}
			}
			if (Class239.staticLocalInitFlag_36 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_36, new StaticLocalInitFlag(), null);
			}
			bool flag37 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_36, ref flag37);
				if (Class239.staticLocalInitFlag_36.State == 0)
				{
					Class239.staticLocalInitFlag_36.State = 2;
					Class239.double_49 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_36.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_36.State = 1;
				if (flag37)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_36);
				}
			}
			if (Class239.staticLocalInitFlag_37 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_37, new StaticLocalInitFlag(), null);
			}
			bool flag38 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_37, ref flag38);
				if (Class239.staticLocalInitFlag_37.State == 0)
				{
					Class239.staticLocalInitFlag_37.State = 2;
					Class239.double_50 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_37.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_37.State = 1;
				if (flag38)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_37);
				}
			}
			if (Class239.staticLocalInitFlag_38 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_38, new StaticLocalInitFlag(), null);
			}
			bool flag39 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_38, ref flag39);
				if (Class239.staticLocalInitFlag_38.State == 0)
				{
					Class239.staticLocalInitFlag_38.State = 2;
					Class239.double_51 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_38.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_38.State = 1;
				if (flag39)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_38);
				}
			}
			if (Class239.staticLocalInitFlag_39 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_39, new StaticLocalInitFlag(), null);
			}
			bool flag40 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_39, ref flag40);
				if (Class239.staticLocalInitFlag_39.State == 0)
				{
					Class239.staticLocalInitFlag_39.State = 2;
					Class239.double_52 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_39.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_39.State = 1;
				if (flag40)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_39);
				}
			}
			if (Class239.staticLocalInitFlag_40 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_40, new StaticLocalInitFlag(), null);
			}
			bool flag41 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_40, ref flag41);
				if (Class239.staticLocalInitFlag_40.State == 0)
				{
					Class239.staticLocalInitFlag_40.State = 2;
					Class239.double_53 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_40.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_40.State = 1;
				if (flag41)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_40);
				}
			}
			if (Class239.staticLocalInitFlag_41 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_41, new StaticLocalInitFlag(), null);
			}
			bool flag42 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_41, ref flag42);
				if (Class239.staticLocalInitFlag_41.State == 0)
				{
					Class239.staticLocalInitFlag_41.State = 2;
					Class239.double_54 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_41.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_41.State = 1;
				if (flag42)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_41);
				}
			}
			if (Class239.staticLocalInitFlag_42 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_42, new StaticLocalInitFlag(), null);
			}
			bool flag43 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_42, ref flag43);
				if (Class239.staticLocalInitFlag_42.State == 0)
				{
					Class239.staticLocalInitFlag_42.State = 2;
					Class239.double_55 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_42.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_42.State = 1;
				if (flag43)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_42);
				}
			}
			if (Class239.staticLocalInitFlag_43 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_43, new StaticLocalInitFlag(), null);
			}
			bool flag44 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_43, ref flag44);
				if (Class239.staticLocalInitFlag_43.State == 0)
				{
					Class239.staticLocalInitFlag_43.State = 2;
					Class239.double_56 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_43.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_43.State = 1;
				if (flag44)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_43);
				}
			}
			if (Class239.staticLocalInitFlag_44 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_44, new StaticLocalInitFlag(), null);
			}
			bool flag45 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_44, ref flag45);
				if (Class239.staticLocalInitFlag_44.State == 0)
				{
					Class239.staticLocalInitFlag_44.State = 2;
					Class239.double_57 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_44.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_44.State = 1;
				if (flag45)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_44);
				}
			}
			if (Class239.staticLocalInitFlag_45 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_45, new StaticLocalInitFlag(), null);
			}
			bool flag46 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_45, ref flag46);
				if (Class239.staticLocalInitFlag_45.State == 0)
				{
					Class239.staticLocalInitFlag_45.State = 2;
					Class239.double_58 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_45.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_45.State = 1;
				if (flag46)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_45);
				}
			}
			if (Class239.staticLocalInitFlag_46 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_46, new StaticLocalInitFlag(), null);
			}
			bool flag47 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_46, ref flag47);
				if (Class239.staticLocalInitFlag_46.State == 0)
				{
					Class239.staticLocalInitFlag_46.State = 2;
					Class239.double_59 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_46.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_46.State = 1;
				if (flag47)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_46);
				}
			}
			if (Class239.staticLocalInitFlag_47 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_47, new StaticLocalInitFlag(), null);
			}
			bool flag48 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_47, ref flag48);
				if (Class239.staticLocalInitFlag_47.State == 0)
				{
					Class239.staticLocalInitFlag_47.State = 2;
					Class239.double_60 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_47.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_47.State = 1;
				if (flag48)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_47);
				}
			}
			if (Class239.staticLocalInitFlag_48 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_48, new StaticLocalInitFlag(), null);
			}
			bool flag49 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_48, ref flag49);
				if (Class239.staticLocalInitFlag_48.State == 0)
				{
					Class239.staticLocalInitFlag_48.State = 2;
					Class239.double_61 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_48.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_48.State = 1;
				if (flag49)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_48);
				}
			}
			if (Class239.staticLocalInitFlag_49 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_49, new StaticLocalInitFlag(), null);
			}
			bool flag50 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_49, ref flag50);
				if (Class239.staticLocalInitFlag_49.State == 0)
				{
					Class239.staticLocalInitFlag_49.State = 2;
					Class239.double_62 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_49.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_49.State = 1;
				if (flag50)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_49);
				}
			}
			if (Class239.staticLocalInitFlag_50 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_50, new StaticLocalInitFlag(), null);
			}
			bool flag51 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_50, ref flag51);
				if (Class239.staticLocalInitFlag_50.State == 0)
				{
					Class239.staticLocalInitFlag_50.State = 2;
					Class239.double_63 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_50.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_50.State = 1;
				if (flag51)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_50);
				}
			}
			if (Class239.staticLocalInitFlag_51 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_51, new StaticLocalInitFlag(), null);
			}
			bool flag52 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_51, ref flag52);
				if (Class239.staticLocalInitFlag_51.State == 0)
				{
					Class239.staticLocalInitFlag_51.State = 2;
					Class239.double_64 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_51.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_51.State = 1;
				if (flag52)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_51);
				}
			}
			if (Class239.staticLocalInitFlag_52 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_52, new StaticLocalInitFlag(), null);
			}
			bool flag53 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_52, ref flag53);
				if (Class239.staticLocalInitFlag_52.State == 0)
				{
					Class239.staticLocalInitFlag_52.State = 2;
					Class239.double_65 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_52.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_52.State = 1;
				if (flag53)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_52);
				}
			}
			if (Class239.staticLocalInitFlag_53 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_53, new StaticLocalInitFlag(), null);
			}
			bool flag54 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_53, ref flag54);
				if (Class239.staticLocalInitFlag_53.State == 0)
				{
					Class239.staticLocalInitFlag_53.State = 2;
					Class239.double_66 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_53.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_53.State = 1;
				if (flag54)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_53);
				}
			}
			if (Class239.staticLocalInitFlag_54 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_54, new StaticLocalInitFlag(), null);
			}
			bool flag55 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_54, ref flag55);
				if (Class239.staticLocalInitFlag_54.State == 0)
				{
					Class239.staticLocalInitFlag_54.State = 2;
					Class239.double_67 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_54.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_54.State = 1;
				if (flag55)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_54);
				}
			}
			if (Class239.staticLocalInitFlag_55 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_55, new StaticLocalInitFlag(), null);
			}
			bool flag56 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_55, ref flag56);
				if (Class239.staticLocalInitFlag_55.State == 0)
				{
					Class239.staticLocalInitFlag_55.State = 2;
					Class239.double_68 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_55.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_55.State = 1;
				if (flag56)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_55);
				}
			}
			if (Class239.staticLocalInitFlag_56 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_56, new StaticLocalInitFlag(), null);
			}
			bool flag57 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_56, ref flag57);
				if (Class239.staticLocalInitFlag_56.State == 0)
				{
					Class239.staticLocalInitFlag_56.State = 2;
					Class239.double_69 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_56.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_56.State = 1;
				if (flag57)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_56);
				}
			}
			if (Class239.staticLocalInitFlag_57 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_57, new StaticLocalInitFlag(), null);
			}
			bool flag58 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_57, ref flag58);
				if (Class239.staticLocalInitFlag_57.State == 0)
				{
					Class239.staticLocalInitFlag_57.State = 2;
					Class239.double_70 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_57.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_57.State = 1;
				if (flag58)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_57);
				}
			}
			if (Class239.staticLocalInitFlag_58 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_58, new StaticLocalInitFlag(), null);
			}
			bool flag59 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_58, ref flag59);
				if (Class239.staticLocalInitFlag_58.State == 0)
				{
					Class239.staticLocalInitFlag_58.State = 2;
					Class239.double_71 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_58.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_58.State = 1;
				if (flag59)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_58);
				}
			}
			if (Class239.staticLocalInitFlag_59 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_59, new StaticLocalInitFlag(), null);
			}
			bool flag60 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_59, ref flag60);
				if (Class239.staticLocalInitFlag_59.State == 0)
				{
					Class239.staticLocalInitFlag_59.State = 2;
					Class239.double_72 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_59.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_59.State = 1;
				if (flag60)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_59);
				}
			}
			if (Class239.staticLocalInitFlag_60 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_60, new StaticLocalInitFlag(), null);
			}
			bool flag61 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_60, ref flag61);
				if (Class239.staticLocalInitFlag_60.State == 0)
				{
					Class239.staticLocalInitFlag_60.State = 2;
					Class239.double_73 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_60.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_60.State = 1;
				if (flag61)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_60);
				}
			}
			if (Class239.staticLocalInitFlag_61 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_61, new StaticLocalInitFlag(), null);
			}
			bool flag62 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_61, ref flag62);
				if (Class239.staticLocalInitFlag_61.State == 0)
				{
					Class239.staticLocalInitFlag_61.State = 2;
					Class239.double_74 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_61.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_61.State = 1;
				if (flag62)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_61);
				}
			}
			if (Class239.staticLocalInitFlag_62 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_62, new StaticLocalInitFlag(), null);
			}
			bool flag63 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_62, ref flag63);
				if (Class239.staticLocalInitFlag_62.State == 0)
				{
					Class239.staticLocalInitFlag_62.State = 2;
					Class239.double_75 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_62.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_62.State = 1;
				if (flag63)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_62);
				}
			}
			if (Class239.staticLocalInitFlag_63 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_63, new StaticLocalInitFlag(), null);
			}
			bool flag64 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_63, ref flag64);
				if (Class239.staticLocalInitFlag_63.State == 0)
				{
					Class239.staticLocalInitFlag_63.State = 2;
					Class239.double_76 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_63.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_63.State = 1;
				if (flag64)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_63);
				}
			}
			if (Class239.staticLocalInitFlag_64 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_64, new StaticLocalInitFlag(), null);
			}
			bool flag65 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_64, ref flag65);
				if (Class239.staticLocalInitFlag_64.State == 0)
				{
					Class239.staticLocalInitFlag_64.State = 2;
					Class239.double_77 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_64.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_64.State = 1;
				if (flag65)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_64);
				}
			}
			if (Class239.staticLocalInitFlag_65 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_65, new StaticLocalInitFlag(), null);
			}
			bool flag66 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_65, ref flag66);
				if (Class239.staticLocalInitFlag_65.State == 0)
				{
					Class239.staticLocalInitFlag_65.State = 2;
					Class239.double_78 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_65.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_65.State = 1;
				if (flag66)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_65);
				}
			}
			if (Class239.staticLocalInitFlag_66 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_66, new StaticLocalInitFlag(), null);
			}
			bool flag67 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_66, ref flag67);
				if (Class239.staticLocalInitFlag_66.State == 0)
				{
					Class239.staticLocalInitFlag_66.State = 2;
					Class239.double_79 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_66.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_66.State = 1;
				if (flag67)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_66);
				}
			}
			if (Class239.staticLocalInitFlag_67 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_67, new StaticLocalInitFlag(), null);
			}
			bool flag68 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_67, ref flag68);
				if (Class239.staticLocalInitFlag_67.State == 0)
				{
					Class239.staticLocalInitFlag_67.State = 2;
					Class239.double_80 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_67.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_67.State = 1;
				if (flag68)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_67);
				}
			}
			if (Class239.staticLocalInitFlag_68 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_68, new StaticLocalInitFlag(), null);
			}
			bool flag69 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_68, ref flag69);
				if (Class239.staticLocalInitFlag_68.State == 0)
				{
					Class239.staticLocalInitFlag_68.State = 2;
					Class239.double_81 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_68.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_68.State = 1;
				if (flag69)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_68);
				}
			}
			if (Class239.staticLocalInitFlag_69 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_69, new StaticLocalInitFlag(), null);
			}
			bool flag70 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_69, ref flag70);
				if (Class239.staticLocalInitFlag_69.State == 0)
				{
					Class239.staticLocalInitFlag_69.State = 2;
					Class239.double_82 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_69.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_69.State = 1;
				if (flag70)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_69);
				}
			}
			if (Class239.staticLocalInitFlag_70 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_70, new StaticLocalInitFlag(), null);
			}
			bool flag71 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_70, ref flag71);
				if (Class239.staticLocalInitFlag_70.State == 0)
				{
					Class239.staticLocalInitFlag_70.State = 2;
					Class239.double_83 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_70.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_70.State = 1;
				if (flag71)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_70);
				}
			}
			if (Class239.staticLocalInitFlag_71 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_71, new StaticLocalInitFlag(), null);
			}
			bool flag72 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_71, ref flag72);
				if (Class239.staticLocalInitFlag_71.State == 0)
				{
					Class239.staticLocalInitFlag_71.State = 2;
					Class239.double_84 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_71.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_71.State = 1;
				if (flag72)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_71);
				}
			}
			if (Class239.staticLocalInitFlag_72 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_72, new StaticLocalInitFlag(), null);
			}
			bool flag73 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_72, ref flag73);
				if (Class239.staticLocalInitFlag_72.State == 0)
				{
					Class239.staticLocalInitFlag_72.State = 2;
					Class239.double_85 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_72.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_72.State = 1;
				if (flag73)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_72);
				}
			}
			if (Class239.staticLocalInitFlag_73 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_73, new StaticLocalInitFlag(), null);
			}
			bool flag74 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_73, ref flag74);
				if (Class239.staticLocalInitFlag_73.State == 0)
				{
					Class239.staticLocalInitFlag_73.State = 2;
					Class239.double_86 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_73.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_73.State = 1;
				if (flag74)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_73);
				}
			}
			if (Class239.staticLocalInitFlag_74 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_74, new StaticLocalInitFlag(), null);
			}
			bool flag75 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_74, ref flag75);
				if (Class239.staticLocalInitFlag_74.State == 0)
				{
					Class239.staticLocalInitFlag_74.State = 2;
					Class239.double_87 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_74.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_74.State = 1;
				if (flag75)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_74);
				}
			}
			if (Class239.staticLocalInitFlag_75 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_75, new StaticLocalInitFlag(), null);
			}
			bool flag76 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_75, ref flag76);
				if (Class239.staticLocalInitFlag_75.State == 0)
				{
					Class239.staticLocalInitFlag_75.State = 2;
					Class239.double_88 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_75.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_75.State = 1;
				if (flag76)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_75);
				}
			}
			if (Class239.staticLocalInitFlag_76 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_76, new StaticLocalInitFlag(), null);
			}
			bool flag77 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_76, ref flag77);
				if (Class239.staticLocalInitFlag_76.State == 0)
				{
					Class239.staticLocalInitFlag_76.State = 2;
					Class239.double_89 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_76.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_76.State = 1;
				if (flag77)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_76);
				}
			}
			if (Class239.staticLocalInitFlag_77 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_77, new StaticLocalInitFlag(), null);
			}
			bool flag78 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_77, ref flag78);
				if (Class239.staticLocalInitFlag_77.State == 0)
				{
					Class239.staticLocalInitFlag_77.State = 2;
					Class239.double_90 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_77.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_77.State = 1;
				if (flag78)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_77);
				}
			}
			if (Class239.staticLocalInitFlag_78 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_78, new StaticLocalInitFlag(), null);
			}
			bool flag79 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_78, ref flag79);
				if (Class239.staticLocalInitFlag_78.State == 0)
				{
					Class239.staticLocalInitFlag_78.State = 2;
					Class239.double_91 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_78.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_78.State = 1;
				if (flag79)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_78);
				}
			}
			if (Class239.staticLocalInitFlag_79 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_79, new StaticLocalInitFlag(), null);
			}
			bool flag80 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_79, ref flag80);
				if (Class239.staticLocalInitFlag_79.State == 0)
				{
					Class239.staticLocalInitFlag_79.State = 2;
					Class239.double_92 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_79.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_79.State = 1;
				if (flag80)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_79);
				}
			}
			if (Class239.staticLocalInitFlag_80 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_80, new StaticLocalInitFlag(), null);
			}
			bool flag81 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_80, ref flag81);
				if (Class239.staticLocalInitFlag_80.State == 0)
				{
					Class239.staticLocalInitFlag_80.State = 2;
					Class239.double_93 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_80.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_80.State = 1;
				if (flag81)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_80);
				}
			}
			if (Class239.staticLocalInitFlag_81 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_81, new StaticLocalInitFlag(), null);
			}
			bool flag82 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_81, ref flag82);
				if (Class239.staticLocalInitFlag_81.State == 0)
				{
					Class239.staticLocalInitFlag_81.State = 2;
					Class239.double_94 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_81.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_81.State = 1;
				if (flag82)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_81);
				}
			}
			if (Class239.staticLocalInitFlag_82 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_82, new StaticLocalInitFlag(), null);
			}
			bool flag83 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_82, ref flag83);
				if (Class239.staticLocalInitFlag_82.State == 0)
				{
					Class239.staticLocalInitFlag_82.State = 2;
					Class239.double_95 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_82.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_82.State = 1;
				if (flag83)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_82);
				}
			}
			if (Class239.staticLocalInitFlag_83 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_83, new StaticLocalInitFlag(), null);
			}
			bool flag84 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_83, ref flag84);
				if (Class239.staticLocalInitFlag_83.State == 0)
				{
					Class239.staticLocalInitFlag_83.State = 2;
					Class239.double_96 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_83.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_83.State = 1;
				if (flag84)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_83);
				}
			}
			if (Class239.staticLocalInitFlag_84 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_84, new StaticLocalInitFlag(), null);
			}
			bool flag85 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_84, ref flag85);
				if (Class239.staticLocalInitFlag_84.State == 0)
				{
					Class239.staticLocalInitFlag_84.State = 2;
					Class239.double_97 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_84.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_84.State = 1;
				if (flag85)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_84);
				}
			}
			if (Class239.staticLocalInitFlag_85 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_85, new StaticLocalInitFlag(), null);
			}
			bool flag86 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_85, ref flag86);
				if (Class239.staticLocalInitFlag_85.State == 0)
				{
					Class239.staticLocalInitFlag_85.State = 2;
					Class239.double_98 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_85.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_85.State = 1;
				if (flag86)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_85);
				}
			}
			if (Class239.staticLocalInitFlag_86 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_86, new StaticLocalInitFlag(), null);
			}
			bool flag87 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_86, ref flag87);
				if (Class239.staticLocalInitFlag_86.State == 0)
				{
					Class239.staticLocalInitFlag_86.State = 2;
					Class239.double_99 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_86.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_86.State = 1;
				if (flag87)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_86);
				}
			}
			if (Class239.staticLocalInitFlag_87 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_87, new StaticLocalInitFlag(), null);
			}
			bool flag88 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_87, ref flag88);
				if (Class239.staticLocalInitFlag_87.State == 0)
				{
					Class239.staticLocalInitFlag_87.State = 2;
					Class239.double_100 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_87.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_87.State = 1;
				if (flag88)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_87);
				}
			}
			if (Class239.staticLocalInitFlag_88 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_88, new StaticLocalInitFlag(), null);
			}
			bool flag89 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_88, ref flag89);
				if (Class239.staticLocalInitFlag_88.State == 0)
				{
					Class239.staticLocalInitFlag_88.State = 2;
					Class239.double_101 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_88.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_88.State = 1;
				if (flag89)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_88);
				}
			}
			if (Class239.staticLocalInitFlag_89 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_89, new StaticLocalInitFlag(), null);
			}
			bool flag90 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_89, ref flag90);
				if (Class239.staticLocalInitFlag_89.State == 0)
				{
					Class239.staticLocalInitFlag_89.State = 2;
					Class239.double_102 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_89.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_89.State = 1;
				if (flag90)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_89);
				}
			}
			if (Class239.staticLocalInitFlag_90 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_90, new StaticLocalInitFlag(), null);
			}
			bool flag91 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_90, ref flag91);
				if (Class239.staticLocalInitFlag_90.State == 0)
				{
					Class239.staticLocalInitFlag_90.State = 2;
					Class239.double_103 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_90.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_90.State = 1;
				if (flag91)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_90);
				}
			}
			if (Class239.staticLocalInitFlag_91 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_91, new StaticLocalInitFlag(), null);
			}
			bool flag92 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_91, ref flag92);
				if (Class239.staticLocalInitFlag_91.State == 0)
				{
					Class239.staticLocalInitFlag_91.State = 2;
					Class239.double_104 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_91.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_91.State = 1;
				if (flag92)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_91);
				}
			}
			if (Class239.staticLocalInitFlag_92 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_92, new StaticLocalInitFlag(), null);
			}
			bool flag93 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_92, ref flag93);
				if (Class239.staticLocalInitFlag_92.State == 0)
				{
					Class239.staticLocalInitFlag_92.State = 2;
					Class239.double_105 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_92.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_92.State = 1;
				if (flag93)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_92);
				}
			}
			if (Class239.staticLocalInitFlag_93 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_93, new StaticLocalInitFlag(), null);
			}
			bool flag94 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_93, ref flag94);
				if (Class239.staticLocalInitFlag_93.State == 0)
				{
					Class239.staticLocalInitFlag_93.State = 2;
					Class239.double_106 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_93.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_93.State = 1;
				if (flag94)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_93);
				}
			}
			if (Class239.staticLocalInitFlag_94 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_94, new StaticLocalInitFlag(), null);
			}
			bool flag95 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_94, ref flag95);
				if (Class239.staticLocalInitFlag_94.State == 0)
				{
					Class239.staticLocalInitFlag_94.State = 2;
					Class239.double_107 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_94.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_94.State = 1;
				if (flag95)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_94);
				}
			}
			if (Class239.staticLocalInitFlag_95 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_95, new StaticLocalInitFlag(), null);
			}
			bool flag96 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_95, ref flag96);
				if (Class239.staticLocalInitFlag_95.State == 0)
				{
					Class239.staticLocalInitFlag_95.State = 2;
					Class239.double_108 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_95.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_95.State = 1;
				if (flag96)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_95);
				}
			}
			if (Class239.staticLocalInitFlag_96 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_96, new StaticLocalInitFlag(), null);
			}
			bool flag97 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_96, ref flag97);
				if (Class239.staticLocalInitFlag_96.State == 0)
				{
					Class239.staticLocalInitFlag_96.State = 2;
					Class239.double_109 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_96.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_96.State = 1;
				if (flag97)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_96);
				}
			}
			if (Class239.staticLocalInitFlag_97 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_97, new StaticLocalInitFlag(), null);
			}
			bool flag98 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_97, ref flag98);
				if (Class239.staticLocalInitFlag_97.State == 0)
				{
					Class239.staticLocalInitFlag_97.State = 2;
					Class239.double_110 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_97.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_97.State = 1;
				if (flag98)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_97);
				}
			}
			if (Class239.staticLocalInitFlag_98 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_98, new StaticLocalInitFlag(), null);
			}
			bool flag99 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_98, ref flag99);
				if (Class239.staticLocalInitFlag_98.State == 0)
				{
					Class239.staticLocalInitFlag_98.State = 2;
					Class239.double_111 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_98.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_98.State = 1;
				if (flag99)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_98);
				}
			}
			if (Class239.staticLocalInitFlag_99 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_99, new StaticLocalInitFlag(), null);
			}
			bool flag100 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_99, ref flag100);
				if (Class239.staticLocalInitFlag_99.State == 0)
				{
					Class239.staticLocalInitFlag_99.State = 2;
					Class239.double_112 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_99.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_99.State = 1;
				if (flag100)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_99);
				}
			}
			if (Class239.staticLocalInitFlag_100 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_100, new StaticLocalInitFlag(), null);
			}
			bool flag101 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_100, ref flag101);
				if (Class239.staticLocalInitFlag_100.State == 0)
				{
					Class239.staticLocalInitFlag_100.State = 2;
					Class239.double_113 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_100.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_100.State = 1;
				if (flag101)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_100);
				}
			}
			if (Class239.staticLocalInitFlag_101 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_101, new StaticLocalInitFlag(), null);
			}
			bool flag102 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_101, ref flag102);
				if (Class239.staticLocalInitFlag_101.State == 0)
				{
					Class239.staticLocalInitFlag_101.State = 2;
					Class239.double_114 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_101.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_101.State = 1;
				if (flag102)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_101);
				}
			}
			if (Class239.staticLocalInitFlag_102 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_102, new StaticLocalInitFlag(), null);
			}
			bool flag103 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_102, ref flag103);
				if (Class239.staticLocalInitFlag_102.State == 0)
				{
					Class239.staticLocalInitFlag_102.State = 2;
					Class239.double_115 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_102.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_102.State = 1;
				if (flag103)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_102);
				}
			}
			if (Class239.staticLocalInitFlag_103 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_103, new StaticLocalInitFlag(), null);
			}
			bool flag104 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_103, ref flag104);
				if (Class239.staticLocalInitFlag_103.State == 0)
				{
					Class239.staticLocalInitFlag_103.State = 2;
					Class239.double_116 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_103.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_103.State = 1;
				if (flag104)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_103);
				}
			}
			if (Class239.staticLocalInitFlag_104 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_104, new StaticLocalInitFlag(), null);
			}
			bool flag105 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_104, ref flag105);
				if (Class239.staticLocalInitFlag_104.State == 0)
				{
					Class239.staticLocalInitFlag_104.State = 2;
					Class239.double_117 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_104.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_104.State = 1;
				if (flag105)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_104);
				}
			}
			if (Class239.staticLocalInitFlag_105 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_105, new StaticLocalInitFlag(), null);
			}
			bool flag106 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_105, ref flag106);
				if (Class239.staticLocalInitFlag_105.State == 0)
				{
					Class239.staticLocalInitFlag_105.State = 2;
					Class239.double_118 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_105.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_105.State = 1;
				if (flag106)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_105);
				}
			}
			if (Class239.staticLocalInitFlag_106 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_106, new StaticLocalInitFlag(), null);
			}
			bool flag107 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_106, ref flag107);
				if (Class239.staticLocalInitFlag_106.State == 0)
				{
					Class239.staticLocalInitFlag_106.State = 2;
					Class239.double_119 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_106.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_106.State = 1;
				if (flag107)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_106);
				}
			}
			if (Class239.staticLocalInitFlag_107 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_107, new StaticLocalInitFlag(), null);
			}
			bool flag108 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_107, ref flag108);
				if (Class239.staticLocalInitFlag_107.State == 0)
				{
					Class239.staticLocalInitFlag_107.State = 2;
					Class239.double_120 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_107.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_107.State = 1;
				if (flag108)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_107);
				}
			}
			if (Class239.staticLocalInitFlag_108 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_108, new StaticLocalInitFlag(), null);
			}
			bool flag109 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_108, ref flag109);
				if (Class239.staticLocalInitFlag_108.State == 0)
				{
					Class239.staticLocalInitFlag_108.State = 2;
					Class239.double_121 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_108.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_108.State = 1;
				if (flag109)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_108);
				}
			}
			if (Class239.staticLocalInitFlag_109 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_109, new StaticLocalInitFlag(), null);
			}
			bool flag110 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_109, ref flag110);
				if (Class239.staticLocalInitFlag_109.State == 0)
				{
					Class239.staticLocalInitFlag_109.State = 2;
					Class239.double_122 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_109.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_109.State = 1;
				if (flag110)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_109);
				}
			}
			if (Class239.staticLocalInitFlag_110 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_110, new StaticLocalInitFlag(), null);
			}
			bool flag111 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_110, ref flag111);
				if (Class239.staticLocalInitFlag_110.State == 0)
				{
					Class239.staticLocalInitFlag_110.State = 2;
					Class239.double_123 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_110.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_110.State = 1;
				if (flag111)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_110);
				}
			}
			if (Class239.staticLocalInitFlag_111 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_111, new StaticLocalInitFlag(), null);
			}
			bool flag112 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_111, ref flag112);
				if (Class239.staticLocalInitFlag_111.State == 0)
				{
					Class239.staticLocalInitFlag_111.State = 2;
					Class239.double_124 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_111.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_111.State = 1;
				if (flag112)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_111);
				}
			}
			if (Class239.staticLocalInitFlag_112 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_112, new StaticLocalInitFlag(), null);
			}
			bool flag113 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_112, ref flag113);
				if (Class239.staticLocalInitFlag_112.State == 0)
				{
					Class239.staticLocalInitFlag_112.State = 2;
					Class239.double_125 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_112.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_112.State = 1;
				if (flag113)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_112);
				}
			}
			if (Class239.staticLocalInitFlag_113 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_113, new StaticLocalInitFlag(), null);
			}
			bool flag114 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_113, ref flag114);
				if (Class239.staticLocalInitFlag_113.State == 0)
				{
					Class239.staticLocalInitFlag_113.State = 2;
					Class239.double_126 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_113.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_113.State = 1;
				if (flag114)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_113);
				}
			}
			if (Class239.staticLocalInitFlag_114 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_114, new StaticLocalInitFlag(), null);
			}
			bool flag115 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_114, ref flag115);
				if (Class239.staticLocalInitFlag_114.State == 0)
				{
					Class239.staticLocalInitFlag_114.State = 2;
					Class239.double_127 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_114.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_114.State = 1;
				if (flag115)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_114);
				}
			}
			if (Class239.staticLocalInitFlag_115 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_115, new StaticLocalInitFlag(), null);
			}
			bool flag116 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_115, ref flag116);
				if (Class239.staticLocalInitFlag_115.State == 0)
				{
					Class239.staticLocalInitFlag_115.State = 2;
					Class239.double_128 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_115.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_115.State = 1;
				if (flag116)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_115);
				}
			}
			if (Class239.staticLocalInitFlag_116 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_116, new StaticLocalInitFlag(), null);
			}
			bool flag117 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_116, ref flag117);
				if (Class239.staticLocalInitFlag_116.State == 0)
				{
					Class239.staticLocalInitFlag_116.State = 2;
					Class239.double_129 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_116.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_116.State = 1;
				if (flag117)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_116);
				}
			}
			if (Class239.staticLocalInitFlag_117 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_117, new StaticLocalInitFlag(), null);
			}
			bool flag118 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_117, ref flag118);
				if (Class239.staticLocalInitFlag_117.State == 0)
				{
					Class239.staticLocalInitFlag_117.State = 2;
					Class239.double_130 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_117.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_117.State = 1;
				if (flag118)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_117);
				}
			}
			if (Class239.staticLocalInitFlag_118 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_118, new StaticLocalInitFlag(), null);
			}
			bool flag119 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_118, ref flag119);
				if (Class239.staticLocalInitFlag_118.State == 0)
				{
					Class239.staticLocalInitFlag_118.State = 2;
					Class239.double_131 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_118.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_118.State = 1;
				if (flag119)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_118);
				}
			}
			if (Class239.staticLocalInitFlag_119 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_119, new StaticLocalInitFlag(), null);
			}
			bool flag120 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_119, ref flag120);
				if (Class239.staticLocalInitFlag_119.State == 0)
				{
					Class239.staticLocalInitFlag_119.State = 2;
					Class239.double_132 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_119.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_119.State = 1;
				if (flag120)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_119);
				}
			}
			if (Class239.staticLocalInitFlag_120 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_120, new StaticLocalInitFlag(), null);
			}
			bool flag121 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_120, ref flag121);
				if (Class239.staticLocalInitFlag_120.State == 0)
				{
					Class239.staticLocalInitFlag_120.State = 2;
					Class239.double_133 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_120.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_120.State = 1;
				if (flag121)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_120);
				}
			}
			if (Class239.staticLocalInitFlag_121 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_121, new StaticLocalInitFlag(), null);
			}
			bool flag122 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_121, ref flag122);
				if (Class239.staticLocalInitFlag_121.State == 0)
				{
					Class239.staticLocalInitFlag_121.State = 2;
					Class239.double_134 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_121.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_121.State = 1;
				if (flag122)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_121);
				}
			}
			if (Class239.staticLocalInitFlag_122 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_122, new StaticLocalInitFlag(), null);
			}
			bool flag123 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_122, ref flag123);
				if (Class239.staticLocalInitFlag_122.State == 0)
				{
					Class239.staticLocalInitFlag_122.State = 2;
					Class239.double_135 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_122.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_122.State = 1;
				if (flag123)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_122);
				}
			}
			if (Class239.staticLocalInitFlag_123 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_123, new StaticLocalInitFlag(), null);
			}
			bool flag124 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_123, ref flag124);
				if (Class239.staticLocalInitFlag_123.State == 0)
				{
					Class239.staticLocalInitFlag_123.State = 2;
					Class239.double_136 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_123.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_123.State = 1;
				if (flag124)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_123);
				}
			}
			if (Class239.staticLocalInitFlag_124 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_124, new StaticLocalInitFlag(), null);
			}
			bool flag125 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_124, ref flag125);
				if (Class239.staticLocalInitFlag_124.State == 0)
				{
					Class239.staticLocalInitFlag_124.State = 2;
					Class239.double_137 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_124.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_124.State = 1;
				if (flag125)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_124);
				}
			}
			if (Class239.staticLocalInitFlag_125 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_125, new StaticLocalInitFlag(), null);
			}
			bool flag126 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_125, ref flag126);
				if (Class239.staticLocalInitFlag_125.State == 0)
				{
					Class239.staticLocalInitFlag_125.State = 2;
					Class239.double_138 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_125.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_125.State = 1;
				if (flag126)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_125);
				}
			}
			if (Class239.staticLocalInitFlag_126 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_126, new StaticLocalInitFlag(), null);
			}
			bool flag127 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_126, ref flag127);
				if (Class239.staticLocalInitFlag_126.State == 0)
				{
					Class239.staticLocalInitFlag_126.State = 2;
					Class239.double_139 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_126.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_126.State = 1;
				if (flag127)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_126);
				}
			}
			if (Class239.staticLocalInitFlag_127 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_127, new StaticLocalInitFlag(), null);
			}
			bool flag128 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_127, ref flag128);
				if (Class239.staticLocalInitFlag_127.State == 0)
				{
					Class239.staticLocalInitFlag_127.State = 2;
					Class239.double_140 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_127.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_127.State = 1;
				if (flag128)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_127);
				}
			}
			if (Class239.staticLocalInitFlag_128 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_128, new StaticLocalInitFlag(), null);
			}
			bool flag129 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_128, ref flag129);
				if (Class239.staticLocalInitFlag_128.State == 0)
				{
					Class239.staticLocalInitFlag_128.State = 2;
					Class239.double_141 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_128.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_128.State = 1;
				if (flag129)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_128);
				}
			}
			if (Class239.staticLocalInitFlag_129 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_129, new StaticLocalInitFlag(), null);
			}
			bool flag130 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_129, ref flag130);
				if (Class239.staticLocalInitFlag_129.State == 0)
				{
					Class239.staticLocalInitFlag_129.State = 2;
					Class239.double_142 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_129.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_129.State = 1;
				if (flag130)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_129);
				}
			}
			if (Class239.staticLocalInitFlag_130 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_130, new StaticLocalInitFlag(), null);
			}
			bool flag131 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_130, ref flag131);
				if (Class239.staticLocalInitFlag_130.State == 0)
				{
					Class239.staticLocalInitFlag_130.State = 2;
					Class239.double_143 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_130.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_130.State = 1;
				if (flag131)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_130);
				}
			}
			if (Class239.staticLocalInitFlag_131 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_131, new StaticLocalInitFlag(), null);
			}
			bool flag132 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_131, ref flag132);
				if (Class239.staticLocalInitFlag_131.State == 0)
				{
					Class239.staticLocalInitFlag_131.State = 2;
					Class239.double_144 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_131.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_131.State = 1;
				if (flag132)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_131);
				}
			}
			if (Class239.staticLocalInitFlag_132 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_132, new StaticLocalInitFlag(), null);
			}
			bool flag133 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_132, ref flag133);
				if (Class239.staticLocalInitFlag_132.State == 0)
				{
					Class239.staticLocalInitFlag_132.State = 2;
					Class239.double_145 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_132.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_132.State = 1;
				if (flag133)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_132);
				}
			}
			if (Class239.staticLocalInitFlag_133 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_133, new StaticLocalInitFlag(), null);
			}
			bool flag134 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_133, ref flag134);
				if (Class239.staticLocalInitFlag_133.State == 0)
				{
					Class239.staticLocalInitFlag_133.State = 2;
					Class239.double_146 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_133.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_133.State = 1;
				if (flag134)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_133);
				}
			}
			if (Class239.staticLocalInitFlag_134 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_134, new StaticLocalInitFlag(), null);
			}
			bool flag135 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_134, ref flag135);
				if (Class239.staticLocalInitFlag_134.State == 0)
				{
					Class239.staticLocalInitFlag_134.State = 2;
					Class239.double_147 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_134.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_134.State = 1;
				if (flag135)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_134);
				}
			}
			if (Class239.staticLocalInitFlag_135 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_135, new StaticLocalInitFlag(), null);
			}
			bool flag136 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_135, ref flag136);
				if (Class239.staticLocalInitFlag_135.State == 0)
				{
					Class239.staticLocalInitFlag_135.State = 2;
					Class239.double_148 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_135.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_135.State = 1;
				if (flag136)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_135);
				}
			}
			if (Class239.staticLocalInitFlag_136 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_136, new StaticLocalInitFlag(), null);
			}
			bool flag137 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_136, ref flag137);
				if (Class239.staticLocalInitFlag_136.State == 0)
				{
					Class239.staticLocalInitFlag_136.State = 2;
					Class239.double_149 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_136.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_136.State = 1;
				if (flag137)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_136);
				}
			}
			if (Class239.staticLocalInitFlag_137 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_137, new StaticLocalInitFlag(), null);
			}
			bool flag138 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_137, ref flag138);
				if (Class239.staticLocalInitFlag_137.State == 0)
				{
					Class239.staticLocalInitFlag_137.State = 2;
					Class239.double_150 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_137.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_137.State = 1;
				if (flag138)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_137);
				}
			}
			if (Class239.staticLocalInitFlag_138 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_138, new StaticLocalInitFlag(), null);
			}
			bool flag139 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_138, ref flag139);
				if (Class239.staticLocalInitFlag_138.State == 0)
				{
					Class239.staticLocalInitFlag_138.State = 2;
					Class239.double_151 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_138.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_138.State = 1;
				if (flag139)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_138);
				}
			}
			if (Class239.staticLocalInitFlag_139 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_139, new StaticLocalInitFlag(), null);
			}
			bool flag140 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_139, ref flag140);
				if (Class239.staticLocalInitFlag_139.State == 0)
				{
					Class239.staticLocalInitFlag_139.State = 2;
					Class239.double_152 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_139.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_139.State = 1;
				if (flag140)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_139);
				}
			}
			if (Class239.staticLocalInitFlag_140 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_140, new StaticLocalInitFlag(), null);
			}
			bool flag141 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_140, ref flag141);
				if (Class239.staticLocalInitFlag_140.State == 0)
				{
					Class239.staticLocalInitFlag_140.State = 2;
					Class239.double_153 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_140.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_140.State = 1;
				if (flag141)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_140);
				}
			}
			if (Class239.staticLocalInitFlag_141 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_141, new StaticLocalInitFlag(), null);
			}
			bool flag142 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_141, ref flag142);
				if (Class239.staticLocalInitFlag_141.State == 0)
				{
					Class239.staticLocalInitFlag_141.State = 2;
					Class239.double_154 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_141.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_141.State = 1;
				if (flag142)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_141);
				}
			}
			if (Class239.staticLocalInitFlag_142 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_142, new StaticLocalInitFlag(), null);
			}
			bool flag143 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_142, ref flag143);
				if (Class239.staticLocalInitFlag_142.State == 0)
				{
					Class239.staticLocalInitFlag_142.State = 2;
					Class239.double_155 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_142.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_142.State = 1;
				if (flag143)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_142);
				}
			}
			if (Class239.staticLocalInitFlag_143 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_143, new StaticLocalInitFlag(), null);
			}
			bool flag144 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_143, ref flag144);
				if (Class239.staticLocalInitFlag_143.State == 0)
				{
					Class239.staticLocalInitFlag_143.State = 2;
					Class239.double_156 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_143.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_143.State = 1;
				if (flag144)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_143);
				}
			}
			if (Class239.staticLocalInitFlag_144 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_144, new StaticLocalInitFlag(), null);
			}
			bool flag145 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_144, ref flag145);
				if (Class239.staticLocalInitFlag_144.State == 0)
				{
					Class239.staticLocalInitFlag_144.State = 2;
					Class239.double_157 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_144.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_144.State = 1;
				if (flag145)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_144);
				}
			}
			if (Class239.staticLocalInitFlag_145 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_145, new StaticLocalInitFlag(), null);
			}
			bool flag146 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_145, ref flag146);
				if (Class239.staticLocalInitFlag_145.State == 0)
				{
					Class239.staticLocalInitFlag_145.State = 2;
					Class239.double_158 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_145.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_145.State = 1;
				if (flag146)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_145);
				}
			}
			if (Class239.staticLocalInitFlag_146 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_146, new StaticLocalInitFlag(), null);
			}
			bool flag147 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_146, ref flag147);
				if (Class239.staticLocalInitFlag_146.State == 0)
				{
					Class239.staticLocalInitFlag_146.State = 2;
					Class239.double_159 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_146.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_146.State = 1;
				if (flag147)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_146);
				}
			}
			if (Class239.staticLocalInitFlag_147 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_147, new StaticLocalInitFlag(), null);
			}
			bool flag148 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_147, ref flag148);
				if (Class239.staticLocalInitFlag_147.State == 0)
				{
					Class239.staticLocalInitFlag_147.State = 2;
					Class239.double_160 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_147.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_147.State = 1;
				if (flag148)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_147);
				}
			}
			if (Class239.staticLocalInitFlag_148 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_148, new StaticLocalInitFlag(), null);
			}
			bool flag149 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_148, ref flag149);
				if (Class239.staticLocalInitFlag_148.State == 0)
				{
					Class239.staticLocalInitFlag_148.State = 2;
					Class239.double_161 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_148.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_148.State = 1;
				if (flag149)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_148);
				}
			}
			if (Class239.staticLocalInitFlag_149 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_149, new StaticLocalInitFlag(), null);
			}
			bool flag150 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_149, ref flag150);
				if (Class239.staticLocalInitFlag_149.State == 0)
				{
					Class239.staticLocalInitFlag_149.State = 2;
					Class239.double_162 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_149.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_149.State = 1;
				if (flag150)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_149);
				}
			}
			if (Class239.staticLocalInitFlag_150 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_150, new StaticLocalInitFlag(), null);
			}
			bool flag151 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_150, ref flag151);
				if (Class239.staticLocalInitFlag_150.State == 0)
				{
					Class239.staticLocalInitFlag_150.State = 2;
					Class239.double_163 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_150.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_150.State = 1;
				if (flag151)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_150);
				}
			}
			if (Class239.staticLocalInitFlag_151 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_151, new StaticLocalInitFlag(), null);
			}
			bool flag152 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_151, ref flag152);
				if (Class239.staticLocalInitFlag_151.State == 0)
				{
					Class239.staticLocalInitFlag_151.State = 2;
					Class239.double_164 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_151.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_151.State = 1;
				if (flag152)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_151);
				}
			}
			if (Class239.staticLocalInitFlag_152 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_152, new StaticLocalInitFlag(), null);
			}
			bool flag153 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_152, ref flag153);
				if (Class239.staticLocalInitFlag_152.State == 0)
				{
					Class239.staticLocalInitFlag_152.State = 2;
					Class239.double_165 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_152.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_152.State = 1;
				if (flag153)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_152);
				}
			}
			if (Class239.staticLocalInitFlag_153 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_153, new StaticLocalInitFlag(), null);
			}
			bool flag154 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_153, ref flag154);
				if (Class239.staticLocalInitFlag_153.State == 0)
				{
					Class239.staticLocalInitFlag_153.State = 2;
					Class239.double_166 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_153.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_153.State = 1;
				if (flag154)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_153);
				}
			}
			if (Class239.staticLocalInitFlag_154 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_154, new StaticLocalInitFlag(), null);
			}
			bool flag155 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_154, ref flag155);
				if (Class239.staticLocalInitFlag_154.State == 0)
				{
					Class239.staticLocalInitFlag_154.State = 2;
					Class239.double_167 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_154.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_154.State = 1;
				if (flag155)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_154);
				}
			}
			if (Class239.staticLocalInitFlag_155 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_155, new StaticLocalInitFlag(), null);
			}
			bool flag156 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_155, ref flag156);
				if (Class239.staticLocalInitFlag_155.State == 0)
				{
					Class239.staticLocalInitFlag_155.State = 2;
					Class239.double_168 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_155.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_155.State = 1;
				if (flag156)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_155);
				}
			}
			if (Class239.staticLocalInitFlag_156 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_156, new StaticLocalInitFlag(), null);
			}
			bool flag157 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_156, ref flag157);
				if (Class239.staticLocalInitFlag_156.State == 0)
				{
					Class239.staticLocalInitFlag_156.State = 2;
					Class239.double_169 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_156.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_156.State = 1;
				if (flag157)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_156);
				}
			}
			if (Class239.staticLocalInitFlag_157 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_157, new StaticLocalInitFlag(), null);
			}
			bool flag158 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_157, ref flag158);
				if (Class239.staticLocalInitFlag_157.State == 0)
				{
					Class239.staticLocalInitFlag_157.State = 2;
					Class239.double_170 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_157.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_157.State = 1;
				if (flag158)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_157);
				}
			}
			if (Class239.staticLocalInitFlag_158 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_158, new StaticLocalInitFlag(), null);
			}
			bool flag159 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_158, ref flag159);
				if (Class239.staticLocalInitFlag_158.State == 0)
				{
					Class239.staticLocalInitFlag_158.State = 2;
					Class239.double_171 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_158.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_158.State = 1;
				if (flag159)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_158);
				}
			}
			if (Class239.staticLocalInitFlag_159 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_159, new StaticLocalInitFlag(), null);
			}
			bool flag160 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_159, ref flag160);
				if (Class239.staticLocalInitFlag_159.State == 0)
				{
					Class239.staticLocalInitFlag_159.State = 2;
					Class239.double_172 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_159.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_159.State = 1;
				if (flag160)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_159);
				}
			}
			if (Class239.staticLocalInitFlag_160 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_160, new StaticLocalInitFlag(), null);
			}
			bool flag161 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_160, ref flag161);
				if (Class239.staticLocalInitFlag_160.State == 0)
				{
					Class239.staticLocalInitFlag_160.State = 2;
					Class239.double_173 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_160.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_160.State = 1;
				if (flag161)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_160);
				}
			}
			if (Class239.staticLocalInitFlag_161 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_161, new StaticLocalInitFlag(), null);
			}
			bool flag162 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_161, ref flag162);
				if (Class239.staticLocalInitFlag_161.State == 0)
				{
					Class239.staticLocalInitFlag_161.State = 2;
					Class239.double_174 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_161.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_161.State = 1;
				if (flag162)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_161);
				}
			}
			if (Class239.staticLocalInitFlag_162 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_162, new StaticLocalInitFlag(), null);
			}
			bool flag163 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_162, ref flag163);
				if (Class239.staticLocalInitFlag_162.State == 0)
				{
					Class239.staticLocalInitFlag_162.State = 2;
					Class239.double_175 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_162.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_162.State = 1;
				if (flag163)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_162);
				}
			}
			if (Class239.staticLocalInitFlag_163 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_163, new StaticLocalInitFlag(), null);
			}
			bool flag164 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_163, ref flag164);
				if (Class239.staticLocalInitFlag_163.State == 0)
				{
					Class239.staticLocalInitFlag_163.State = 2;
					Class239.double_176 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_163.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_163.State = 1;
				if (flag164)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_163);
				}
			}
			if (Class239.staticLocalInitFlag_164 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_164, new StaticLocalInitFlag(), null);
			}
			bool flag165 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_164, ref flag165);
				if (Class239.staticLocalInitFlag_164.State == 0)
				{
					Class239.staticLocalInitFlag_164.State = 2;
					Class239.double_177 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_164.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_164.State = 1;
				if (flag165)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_164);
				}
			}
			if (Class239.staticLocalInitFlag_165 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_165, new StaticLocalInitFlag(), null);
			}
			bool flag166 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_165, ref flag166);
				if (Class239.staticLocalInitFlag_165.State == 0)
				{
					Class239.staticLocalInitFlag_165.State = 2;
					Class239.double_178 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_165.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_165.State = 1;
				if (flag166)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_165);
				}
			}
			if (Class239.staticLocalInitFlag_166 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_166, new StaticLocalInitFlag(), null);
			}
			bool flag167 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_166, ref flag167);
				if (Class239.staticLocalInitFlag_166.State == 0)
				{
					Class239.staticLocalInitFlag_166.State = 2;
					Class239.double_179 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_166.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_166.State = 1;
				if (flag167)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_166);
				}
			}
			if (Class239.staticLocalInitFlag_167 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_167, new StaticLocalInitFlag(), null);
			}
			bool flag168 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_167, ref flag168);
				if (Class239.staticLocalInitFlag_167.State == 0)
				{
					Class239.staticLocalInitFlag_167.State = 2;
					Class239.double_180 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_167.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_167.State = 1;
				if (flag168)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_167);
				}
			}
			if (Class239.staticLocalInitFlag_168 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_168, new StaticLocalInitFlag(), null);
			}
			bool flag169 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_168, ref flag169);
				if (Class239.staticLocalInitFlag_168.State == 0)
				{
					Class239.staticLocalInitFlag_168.State = 2;
					Class239.double_181 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_168.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_168.State = 1;
				if (flag169)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_168);
				}
			}
			if (Class239.staticLocalInitFlag_169 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_169, new StaticLocalInitFlag(), null);
			}
			bool flag170 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_169, ref flag170);
				if (Class239.staticLocalInitFlag_169.State == 0)
				{
					Class239.staticLocalInitFlag_169.State = 2;
					Class239.double_182 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_169.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_169.State = 1;
				if (flag170)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_169);
				}
			}
			if (Class239.staticLocalInitFlag_170 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_170, new StaticLocalInitFlag(), null);
			}
			bool flag171 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_170, ref flag171);
				if (Class239.staticLocalInitFlag_170.State == 0)
				{
					Class239.staticLocalInitFlag_170.State = 2;
					Class239.double_183 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_170.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_170.State = 1;
				if (flag171)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_170);
				}
			}
			if (Class239.staticLocalInitFlag_171 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_171, new StaticLocalInitFlag(), null);
			}
			bool flag172 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_171, ref flag172);
				if (Class239.staticLocalInitFlag_171.State == 0)
				{
					Class239.staticLocalInitFlag_171.State = 2;
					Class239.double_184 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_171.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_171.State = 1;
				if (flag172)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_171);
				}
			}
			if (Class239.staticLocalInitFlag_172 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_172, new StaticLocalInitFlag(), null);
			}
			bool flag173 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_172, ref flag173);
				if (Class239.staticLocalInitFlag_172.State == 0)
				{
					Class239.staticLocalInitFlag_172.State = 2;
					Class239.double_185 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_172.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_172.State = 1;
				if (flag173)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_172);
				}
			}
			if (Class239.staticLocalInitFlag_173 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_173, new StaticLocalInitFlag(), null);
			}
			bool flag174 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_173, ref flag174);
				if (Class239.staticLocalInitFlag_173.State == 0)
				{
					Class239.staticLocalInitFlag_173.State = 2;
					Class239.double_186 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_173.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_173.State = 1;
				if (flag174)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_173);
				}
			}
			if (Class239.staticLocalInitFlag_174 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_174, new StaticLocalInitFlag(), null);
			}
			bool flag175 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_174, ref flag175);
				if (Class239.staticLocalInitFlag_174.State == 0)
				{
					Class239.staticLocalInitFlag_174.State = 2;
					Class239.double_187 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_174.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_174.State = 1;
				if (flag175)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_174);
				}
			}
			if (Class239.staticLocalInitFlag_175 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_175, new StaticLocalInitFlag(), null);
			}
			bool flag176 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_175, ref flag176);
				if (Class239.staticLocalInitFlag_175.State == 0)
				{
					Class239.staticLocalInitFlag_175.State = 2;
					Class239.double_188 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_175.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_175.State = 1;
				if (flag176)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_175);
				}
			}
			if (Class239.staticLocalInitFlag_176 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_176, new StaticLocalInitFlag(), null);
			}
			bool flag177 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_176, ref flag177);
				if (Class239.staticLocalInitFlag_176.State == 0)
				{
					Class239.staticLocalInitFlag_176.State = 2;
					Class239.double_189 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_176.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_176.State = 1;
				if (flag177)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_176);
				}
			}
			if (Class239.staticLocalInitFlag_177 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_177, new StaticLocalInitFlag(), null);
			}
			bool flag178 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_177, ref flag178);
				if (Class239.staticLocalInitFlag_177.State == 0)
				{
					Class239.staticLocalInitFlag_177.State = 2;
					Class239.double_190 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_177.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_177.State = 1;
				if (flag178)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_177);
				}
			}
			if (Class239.staticLocalInitFlag_178 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_178, new StaticLocalInitFlag(), null);
			}
			bool flag179 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_178, ref flag179);
				if (Class239.staticLocalInitFlag_178.State == 0)
				{
					Class239.staticLocalInitFlag_178.State = 2;
					Class239.double_191 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_178.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_178.State = 1;
				if (flag179)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_178);
				}
			}
			if (Class239.staticLocalInitFlag_179 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_179, new StaticLocalInitFlag(), null);
			}
			bool flag180 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_179, ref flag180);
				if (Class239.staticLocalInitFlag_179.State == 0)
				{
					Class239.staticLocalInitFlag_179.State = 2;
					Class239.double_192 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_179.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_179.State = 1;
				if (flag180)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_179);
				}
			}
			if (Class239.staticLocalInitFlag_180 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_180, new StaticLocalInitFlag(), null);
			}
			bool flag181 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_180, ref flag181);
				if (Class239.staticLocalInitFlag_180.State == 0)
				{
					Class239.staticLocalInitFlag_180.State = 2;
					Class239.double_193 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_180.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_180.State = 1;
				if (flag181)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_180);
				}
			}
			if (Class239.staticLocalInitFlag_181 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_181, new StaticLocalInitFlag(), null);
			}
			bool flag182 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_181, ref flag182);
				if (Class239.staticLocalInitFlag_181.State == 0)
				{
					Class239.staticLocalInitFlag_181.State = 2;
					Class239.double_194 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_181.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_181.State = 1;
				if (flag182)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_181);
				}
			}
			if (Class239.staticLocalInitFlag_182 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_182, new StaticLocalInitFlag(), null);
			}
			bool flag183 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_182, ref flag183);
				if (Class239.staticLocalInitFlag_182.State == 0)
				{
					Class239.staticLocalInitFlag_182.State = 2;
					Class239.double_195 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_182.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_182.State = 1;
				if (flag183)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_182);
				}
			}
			if (Class239.staticLocalInitFlag_183 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_183, new StaticLocalInitFlag(), null);
			}
			bool flag184 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_183, ref flag184);
				if (Class239.staticLocalInitFlag_183.State == 0)
				{
					Class239.staticLocalInitFlag_183.State = 2;
					Class239.double_196 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_183.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_183.State = 1;
				if (flag184)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_183);
				}
			}
			if (Class239.staticLocalInitFlag_184 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_184, new StaticLocalInitFlag(), null);
			}
			bool flag185 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_184, ref flag185);
				if (Class239.staticLocalInitFlag_184.State == 0)
				{
					Class239.staticLocalInitFlag_184.State = 2;
					Class239.double_197 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_184.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_184.State = 1;
				if (flag185)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_184);
				}
			}
			if (Class239.staticLocalInitFlag_185 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_185, new StaticLocalInitFlag(), null);
			}
			bool flag186 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_185, ref flag186);
				if (Class239.staticLocalInitFlag_185.State == 0)
				{
					Class239.staticLocalInitFlag_185.State = 2;
					Class239.double_198 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_185.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_185.State = 1;
				if (flag186)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_185);
				}
			}
			if (Class239.staticLocalInitFlag_186 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_186, new StaticLocalInitFlag(), null);
			}
			bool flag187 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_186, ref flag187);
				if (Class239.staticLocalInitFlag_186.State == 0)
				{
					Class239.staticLocalInitFlag_186.State = 2;
					Class239.double_199 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_186.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_186.State = 1;
				if (flag187)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_186);
				}
			}
			if (Class239.staticLocalInitFlag_187 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_187, new StaticLocalInitFlag(), null);
			}
			bool flag188 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_187, ref flag188);
				if (Class239.staticLocalInitFlag_187.State == 0)
				{
					Class239.staticLocalInitFlag_187.State = 2;
					Class239.double_200 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_187.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_187.State = 1;
				if (flag188)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_187);
				}
			}
			if (Class239.staticLocalInitFlag_188 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_188, new StaticLocalInitFlag(), null);
			}
			bool flag189 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_188, ref flag189);
				if (Class239.staticLocalInitFlag_188.State == 0)
				{
					Class239.staticLocalInitFlag_188.State = 2;
					Class239.double_201 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_188.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_188.State = 1;
				if (flag189)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_188);
				}
			}
			if (Class239.staticLocalInitFlag_189 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_189, new StaticLocalInitFlag(), null);
			}
			bool flag190 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_189, ref flag190);
				if (Class239.staticLocalInitFlag_189.State == 0)
				{
					Class239.staticLocalInitFlag_189.State = 2;
					Class239.double_202 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_189.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_189.State = 1;
				if (flag190)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_189);
				}
			}
			if (Class239.staticLocalInitFlag_190 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_190, new StaticLocalInitFlag(), null);
			}
			bool flag191 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_190, ref flag191);
				if (Class239.staticLocalInitFlag_190.State == 0)
				{
					Class239.staticLocalInitFlag_190.State = 2;
					Class239.double_203 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_190.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_190.State = 1;
				if (flag191)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_190);
				}
			}
			if (Class239.staticLocalInitFlag_191 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_191, new StaticLocalInitFlag(), null);
			}
			bool flag192 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_191, ref flag192);
				if (Class239.staticLocalInitFlag_191.State == 0)
				{
					Class239.staticLocalInitFlag_191.State = 2;
					Class239.double_204 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_191.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_191.State = 1;
				if (flag192)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_191);
				}
			}
			if (Class239.staticLocalInitFlag_192 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_192, new StaticLocalInitFlag(), null);
			}
			bool flag193 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_192, ref flag193);
				if (Class239.staticLocalInitFlag_192.State == 0)
				{
					Class239.staticLocalInitFlag_192.State = 2;
					Class239.double_205 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_192.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_192.State = 1;
				if (flag193)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_192);
				}
			}
			if (Class239.staticLocalInitFlag_193 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_193, new StaticLocalInitFlag(), null);
			}
			bool flag194 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_193, ref flag194);
				if (Class239.staticLocalInitFlag_193.State == 0)
				{
					Class239.staticLocalInitFlag_193.State = 2;
					Class239.double_206 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_193.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_193.State = 1;
				if (flag194)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_193);
				}
			}
			if (Class239.staticLocalInitFlag_194 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_194, new StaticLocalInitFlag(), null);
			}
			bool flag195 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_194, ref flag195);
				if (Class239.staticLocalInitFlag_194.State == 0)
				{
					Class239.staticLocalInitFlag_194.State = 2;
					Class239.double_207 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_194.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_194.State = 1;
				if (flag195)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_194);
				}
			}
			if (Class239.staticLocalInitFlag_195 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_195, new StaticLocalInitFlag(), null);
			}
			bool flag196 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_195, ref flag196);
				if (Class239.staticLocalInitFlag_195.State == 0)
				{
					Class239.staticLocalInitFlag_195.State = 2;
					Class239.double_208 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_195.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_195.State = 1;
				if (flag196)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_195);
				}
			}
			if (Class239.staticLocalInitFlag_196 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_196, new StaticLocalInitFlag(), null);
			}
			bool flag197 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_196, ref flag197);
				if (Class239.staticLocalInitFlag_196.State == 0)
				{
					Class239.staticLocalInitFlag_196.State = 2;
					Class239.double_209 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_196.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_196.State = 1;
				if (flag197)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_196);
				}
			}
			if (Class239.staticLocalInitFlag_197 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_197, new StaticLocalInitFlag(), null);
			}
			bool flag198 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_197, ref flag198);
				if (Class239.staticLocalInitFlag_197.State == 0)
				{
					Class239.staticLocalInitFlag_197.State = 2;
					Class239.double_210 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_197.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_197.State = 1;
				if (flag198)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_197);
				}
			}
			if (Class239.staticLocalInitFlag_198 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_198, new StaticLocalInitFlag(), null);
			}
			bool flag199 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_198, ref flag199);
				if (Class239.staticLocalInitFlag_198.State == 0)
				{
					Class239.staticLocalInitFlag_198.State = 2;
					Class239.double_211 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_198.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_198.State = 1;
				if (flag199)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_198);
				}
			}
			if (Class239.staticLocalInitFlag_199 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_199, new StaticLocalInitFlag(), null);
			}
			bool flag200 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_199, ref flag200);
				if (Class239.staticLocalInitFlag_199.State == 0)
				{
					Class239.staticLocalInitFlag_199.State = 2;
					Class239.double_212 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_199.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_199.State = 1;
				if (flag200)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_199);
				}
			}
			if (Class239.staticLocalInitFlag_200 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_200, new StaticLocalInitFlag(), null);
			}
			bool flag201 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_200, ref flag201);
				if (Class239.staticLocalInitFlag_200.State == 0)
				{
					Class239.staticLocalInitFlag_200.State = 2;
					Class239.double_213 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_200.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_200.State = 1;
				if (flag201)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_200);
				}
			}
			if (Class239.staticLocalInitFlag_201 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_201, new StaticLocalInitFlag(), null);
			}
			bool flag202 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_201, ref flag202);
				if (Class239.staticLocalInitFlag_201.State == 0)
				{
					Class239.staticLocalInitFlag_201.State = 2;
					Class239.double_214 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_201.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_201.State = 1;
				if (flag202)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_201);
				}
			}
			if (Class239.staticLocalInitFlag_202 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_202, new StaticLocalInitFlag(), null);
			}
			bool flag203 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_202, ref flag203);
				if (Class239.staticLocalInitFlag_202.State == 0)
				{
					Class239.staticLocalInitFlag_202.State = 2;
					Class239.double_215 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_202.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_202.State = 1;
				if (flag203)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_202);
				}
			}
			if (Class239.staticLocalInitFlag_203 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_203, new StaticLocalInitFlag(), null);
			}
			bool flag204 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_203, ref flag204);
				if (Class239.staticLocalInitFlag_203.State == 0)
				{
					Class239.staticLocalInitFlag_203.State = 2;
					Class239.double_216 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_203.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_203.State = 1;
				if (flag204)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_203);
				}
			}
			if (Class239.staticLocalInitFlag_204 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_204, new StaticLocalInitFlag(), null);
			}
			bool flag205 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_204, ref flag205);
				if (Class239.staticLocalInitFlag_204.State == 0)
				{
					Class239.staticLocalInitFlag_204.State = 2;
					Class239.double_217 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_204.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_204.State = 1;
				if (flag205)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_204);
				}
			}
			if (Class239.staticLocalInitFlag_205 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_205, new StaticLocalInitFlag(), null);
			}
			bool flag206 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_205, ref flag206);
				if (Class239.staticLocalInitFlag_205.State == 0)
				{
					Class239.staticLocalInitFlag_205.State = 2;
					Class239.double_218 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_205.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_205.State = 1;
				if (flag206)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_205);
				}
			}
			if (Class239.staticLocalInitFlag_206 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_206, new StaticLocalInitFlag(), null);
			}
			bool flag207 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_206, ref flag207);
				if (Class239.staticLocalInitFlag_206.State == 0)
				{
					Class239.staticLocalInitFlag_206.State = 2;
					Class239.double_219 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_206.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_206.State = 1;
				if (flag207)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_206);
				}
			}
			if (Class239.staticLocalInitFlag_207 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_207, new StaticLocalInitFlag(), null);
			}
			bool flag208 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_207, ref flag208);
				if (Class239.staticLocalInitFlag_207.State == 0)
				{
					Class239.staticLocalInitFlag_207.State = 2;
					Class239.double_220 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_207.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_207.State = 1;
				if (flag208)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_207);
				}
			}
			if (Class239.staticLocalInitFlag_208 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_208, new StaticLocalInitFlag(), null);
			}
			bool flag209 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_208, ref flag209);
				if (Class239.staticLocalInitFlag_208.State == 0)
				{
					Class239.staticLocalInitFlag_208.State = 2;
					Class239.double_221 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_208.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_208.State = 1;
				if (flag209)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_208);
				}
			}
			if (Class239.staticLocalInitFlag_209 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_209, new StaticLocalInitFlag(), null);
			}
			bool flag210 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_209, ref flag210);
				if (Class239.staticLocalInitFlag_209.State == 0)
				{
					Class239.staticLocalInitFlag_209.State = 2;
					Class239.double_222 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_209.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_209.State = 1;
				if (flag210)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_209);
				}
			}
			if (Class239.staticLocalInitFlag_210 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_210, new StaticLocalInitFlag(), null);
			}
			bool flag211 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_210, ref flag211);
				if (Class239.staticLocalInitFlag_210.State == 0)
				{
					Class239.staticLocalInitFlag_210.State = 2;
					Class239.double_223 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_210.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_210.State = 1;
				if (flag211)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_210);
				}
			}
			if (Class239.staticLocalInitFlag_211 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class239.staticLocalInitFlag_211, new StaticLocalInitFlag(), null);
			}
			bool flag212 = false;
			try
			{
				Monitor.Enter(Class239.staticLocalInitFlag_211, ref flag212);
				if (Class239.staticLocalInitFlag_211.State == 0)
				{
					Class239.staticLocalInitFlag_211.State = 2;
					Class239.double_224 = 0.0;
				}
				else if (Class239.staticLocalInitFlag_211.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Class239.staticLocalInitFlag_211.State = 1;
				if (flag212)
				{
					Monitor.Exit(Class239.staticLocalInitFlag_211);
				}
			}
			switch (int_7)
			{
			case 1:
				Class239.double_153 = Class245.smethod_2(ref class243_0.double_0, ref Class239.double_224);
				Class239.double_63 = class243_0.double_6;
				Class239.double_187 = Class239.double_12;
				Class239.double_32 = 1.0 / Class239.double_4;
				Class239.double_190 = class243_0.double_5;
				Class239.double_180 = class243_0.double_7;
				Class239.double_189 = Class239.double_10 + Class239.double_11;
				Class239.double_133 = Math.Sin(class243_0.double_9);
				Class239.double_40 = Math.Cos(class243_0.double_9);
				Class239.double_95 = class243_0.double_8;
				Class239.double_53 = Class239.double_224 + 18261.5;
				if (Class239.double_53 != Class239.double_101)
				{
					Class239.double_101 = Class239.double_53;
					Class239.double_185 = 4.523602 - 0.00092422029 * Class239.double_53;
					Class239.double_147 = Math.Sin(Class239.double_185);
					Class239.double_41 = Math.Cos(Class239.double_185);
					Class239.double_208 = 0.91375164 - 0.03568096 * Class239.double_41;
					Class239.double_221 = Math.Sqrt(1.0 - Class239.double_208 * Class239.double_208);
					Class239.double_219 = 0.089683511 * Class239.double_147 / Class239.double_221;
					Class239.double_206 = Math.Sqrt(1.0 - Class239.double_219 * Class239.double_219);
					Class239.double_36 = 4.7199672 + 0.2299715 * Class239.double_53;
					Class239.double_94 = 5.8351514 + 0.001944368 * Class239.double_53;
					double num = Class239.double_36 - Class239.double_94;
					Class239.double_213 = Class244.smethod_3(ref num);
					Class239.double_222 = 0.39785416 * Class239.double_147 / Class239.double_221;
					Class239.double_223 = Class239.double_206 * Class239.double_41 + 0.91744867 * Class239.double_219 * Class239.double_147;
					Class239.double_222 = Class244.smethod_5(ref Class239.double_222, ref Class239.double_223);
					Class239.double_222 = Class239.double_94 + Class239.double_222 - Class239.double_185;
					Class239.double_204 = Math.Cos(Class239.double_222);
					Class239.double_217 = Math.Sin(Class239.double_222);
					Class239.double_214 = 6.2565837 + 0.017201977 * Class239.double_53;
					Class239.double_214 = Class244.smethod_3(ref Class239.double_214);
				}
				Class239.double_109 = 1E+20;
				Class239.double_203 = 0.1945905;
				Class239.double_216 = -0.98088458;
				Class239.double_207 = 0.91744867;
				Class239.double_220 = 0.39785416;
				Class239.double_205 = Class239.double_40;
				Class239.double_218 = Class239.double_133;
				Class239.double_37 = 2.9864797E-06;
				Class239.double_215 = 1.19459E-05;
				Class239.double_209 = 0.01675;
				Class239.double_212 = Class239.double_214;
				Class239.double_186 = 1.0 / Class239.double_187;
				Class239.int_5 = 30;
				Class239.int_6 = 0;
				while (Class239.int_6 < 2)
				{
					Class239.double_20 = Class239.double_203 * Class239.double_205 + Class239.double_216 * Class239.double_207 * Class239.double_218;
					Class239.double_22 = -Class239.double_216 * Class239.double_205 + Class239.double_203 * Class239.double_207 * Class239.double_218;
					Class239.double_26 = -Class239.double_203 * Class239.double_218 + Class239.double_216 * Class239.double_207 * Class239.double_205;
					Class239.double_27 = Class239.double_216 * Class239.double_220;
					Class239.double_28 = Class239.double_216 * Class239.double_218 + Class239.double_203 * Class239.double_207 * Class239.double_205;
					Class239.double_29 = Class239.double_203 * Class239.double_220;
					Class239.double_21 = Class239.double_2 * Class239.double_26 + Class239.double_1 * Class239.double_27;
					Class239.double_23 = Class239.double_2 * Class239.double_28 + Class239.double_1 * Class239.double_29;
					Class239.double_24 = -Class239.double_1 * Class239.double_26 + Class239.double_2 * Class239.double_27;
					Class239.double_25 = -Class239.double_1 * Class239.double_28 + Class239.double_2 * Class239.double_29;
					Class239.double_154 = Class239.double_20 * Class239.double_7 + Class239.double_21 * Class239.double_6;
					Class239.double_155 = Class239.double_22 * Class239.double_7 + Class239.double_23 * Class239.double_6;
					Class239.double_158 = -Class239.double_20 * Class239.double_6 + Class239.double_21 * Class239.double_7;
					Class239.double_159 = -Class239.double_22 * Class239.double_6 + Class239.double_23 * Class239.double_7;
					Class239.double_160 = Class239.double_24 * Class239.double_6;
					Class239.double_161 = Class239.double_25 * Class239.double_6;
					Class239.double_162 = Class239.double_24 * Class239.double_7;
					Class239.double_163 = Class239.double_25 * Class239.double_7;
					Class239.double_200 = 12.0 * Class239.double_154 * Class239.double_154 - 3.0 * Class239.double_158 * Class239.double_158;
					Class239.double_201 = 24.0 * Class239.double_154 * Class239.double_155 - 6.0 * Class239.double_158 * Class239.double_159;
					Class239.double_202 = 12.0 * Class239.double_155 * Class239.double_155 - 3.0 * Class239.double_159 * Class239.double_159;
					Class239.double_191 = 3.0 * (Class244.smethod_1(Class239.double_20) + Class244.smethod_1(Class239.double_21)) + Class239.double_200 * Class239.double_0;
					Class239.double_195 = 6.0 * (Class239.double_20 * Class239.double_22 + Class239.double_21 * Class239.double_23) + Class239.double_201 * Class239.double_0;
					Class239.double_199 = 3.0 * (Class239.double_22 * Class239.double_22 + Class239.double_23 * Class239.double_23) + Class239.double_202 * Class239.double_0;
					Class239.double_192 = -6.0 * Class239.double_20 * Class239.double_24 + Class239.double_0 * (-24.0 * Class239.double_154 * Class239.double_162 - 6.0 * Class239.double_158 * Class239.double_160);
					Class239.double_193 = -6.0 * (Class239.double_20 * Class239.double_25 + Class239.double_22 * Class239.double_24) + Class239.double_0 * (-24.0 * (Class239.double_155 * Class239.double_162 + Class239.double_154 * Class239.double_163) - 6.0 * (Class239.double_158 * Class239.double_161 + Class239.double_159 * Class239.double_160));
					Class239.double_194 = -6.0 * Class239.double_22 * Class239.double_25 + Class239.double_0 * (-24.0 * Class239.double_155 * Class239.double_163 - 6.0 * Class239.double_159 * Class239.double_161);
					Class239.double_196 = 6.0 * Class239.double_21 * Class239.double_24 + Class239.double_0 * (24.0 * Class239.double_154 * Class239.double_160 - 6.0 * Class239.double_158 * Class239.double_162);
					Class239.double_197 = 6.0 * (Class239.double_23 * Class239.double_24 + Class239.double_21 * Class239.double_25) + Class239.double_0 * (24.0 * (Class239.double_155 * Class239.double_160 + Class239.double_154 * Class239.double_161) - 6.0 * (Class239.double_159 * Class239.double_162 + Class239.double_158 * Class239.double_163));
					Class239.double_198 = 6.0 * Class239.double_23 * Class239.double_25 + Class239.double_0 * (24.0 * Class239.double_155 * Class239.double_161 - 6.0 * Class239.double_159 * Class239.double_163);
					Class239.double_191 = Class239.double_191 + Class239.double_191 + Class239.double_8 * Class239.double_200;
					Class239.double_195 = Class239.double_195 + Class239.double_195 + Class239.double_8 * Class239.double_201;
					Class239.double_199 = Class239.double_199 + Class239.double_199 + Class239.double_8 * Class239.double_202;
					Class239.double_104 = Class239.double_37 * Class239.double_186;
					Class239.double_103 = -0.5 * Class239.double_104 / Class239.double_3;
					Class239.double_105 = Class239.double_104 * Class239.double_3;
					Class239.double_102 = -15.0 * Class239.double_63 * Class239.double_105;
					Class239.double_106 = Class239.double_154 * Class239.double_158 + Class239.double_155 * Class239.double_159;
					Class239.double_107 = Class239.double_155 * Class239.double_158 + Class239.double_154 * Class239.double_159;
					Class239.double_108 = Class239.double_155 * Class239.double_159 - Class239.double_154 * Class239.double_158;
					Class239.double_110 = Class239.double_102 * Class239.double_215 * Class239.double_106;
					Class239.double_126 = Class239.double_103 * Class239.double_215 * (Class239.double_192 + Class239.double_194);
					Class239.double_136 = -Class239.double_215 * Class239.double_104 * (Class239.double_191 + Class239.double_199 - 14.0 - 6.0 * Class239.double_0);
					Class239.double_115 = Class239.double_105 * Class239.double_215 * (Class239.double_200 + Class239.double_202 - 6.0);
					Class239.double_121 = -Class239.double_215 * Class239.double_103 * (Class239.double_196 + Class239.double_198);
					if (Class239.double_190 < 0.052359877)
					{
						Class239.double_121 = 0.0;
					}
					Class239.double_61 = 2.0 * Class239.double_102 * Class239.double_107;
					Class239.double_60 = 2.0 * Class239.double_102 * Class239.double_108;
					Class239.double_170 = 2.0 * Class239.double_103 * Class239.double_193;
					Class239.double_171 = 2.0 * Class239.double_103 * (Class239.double_194 - Class239.double_192);
					Class239.double_173 = -2.0 * Class239.double_104 * Class239.double_195;
					Class239.double_174 = -2.0 * Class239.double_104 * (Class239.double_199 - Class239.double_191);
					Class239.double_175 = -2.0 * Class239.double_104 * (-21.0 - 9.0 * Class239.double_0) * Class239.double_209;
					Class239.double_165 = 2.0 * Class239.double_105 * Class239.double_201;
					Class239.double_166 = 2.0 * Class239.double_105 * (Class239.double_202 - Class239.double_200);
					Class239.double_167 = -18.0 * Class239.double_105 * Class239.double_209;
					Class239.double_168 = -2.0 * Class239.double_103 * Class239.double_197;
					Class239.double_169 = -2.0 * Class239.double_103 * (Class239.double_198 - Class239.double_196);
					if (Class239.int_5 == 30)
					{
						Class239.double_142 = Class239.double_110;
						Class239.double_145 = Class239.double_126;
						Class239.double_146 = Class239.double_136;
						Class239.double_144 = Class239.double_121 / Class239.double_1;
						Class239.double_143 = Class239.double_115 - Class239.double_2 * Class239.double_144;
						Class239.double_111 = Class239.double_61;
						Class239.double_127 = Class239.double_170;
						Class239.double_137 = Class239.double_173;
						Class239.double_116 = Class239.double_165;
						Class239.double_122 = Class239.double_168;
						Class239.double_112 = Class239.double_60;
						Class239.double_128 = Class239.double_171;
						Class239.double_138 = Class239.double_174;
						Class239.double_117 = Class239.double_166;
						Class239.double_123 = Class239.double_169;
						Class239.double_139 = Class239.double_175;
						Class239.double_118 = Class239.double_167;
						Class239.double_203 = Class239.double_204;
						Class239.double_216 = Class239.double_217;
						Class239.double_207 = Class239.double_208;
						Class239.double_220 = Class239.double_221;
						Class239.double_205 = Class239.double_206 * Class239.double_40 + Class239.double_219 * Class239.double_133;
						Class239.double_218 = Class239.double_133 * Class239.double_206 - Class239.double_40 * Class239.double_219;
						Class239.double_215 = 0.00015835218;
						Class239.double_37 = 4.7968065E-07;
						Class239.double_209 = 0.0549;
						Class239.double_212 = Class239.double_213;
						Class239.int_5 = 40;
					}
					Class239.int_6++;
				}
				Class239.double_142 += Class239.double_110;
				Class239.double_145 += Class239.double_126;
				Class239.double_146 += Class239.double_136;
				Class239.double_143 = Class239.double_143 + Class239.double_115 - Class239.double_2 / Class239.double_1 * Class239.double_121;
				Class239.double_144 += Class239.double_121 / Class239.double_1;
				Class239.int_0 = 0;
				Class239.int_2 = 0;
				if (Class239.double_187 < 0.0052359877 & Class239.double_187 > 0.0034906585)
				{
					Class239.int_0 = 1;
					Class239.int_2 = 1;
					Class239.double_82 = 1.0 + Class239.double_0 * (-2.5 + 0.8125 * Class239.double_0);
					Class239.double_86 = 1.0 + 2.0 * Class239.double_0;
					Class239.double_85 = 1.0 + Class239.double_0 * (-6.0 + 6.60937 * Class239.double_0);
					Class239.double_65 = 0.75 * (1.0 + Class239.double_2) * (1.0 + Class239.double_2);
					Class239.double_68 = 0.9375 * Class239.double_1 * Class239.double_1 * (1.0 + 3.0 * Class239.double_2) - 0.75 * (1.0 + Class239.double_2);
					Class239.double_71 = 1.0 + Class239.double_2;
					Class239.double_71 = 1.875 * Class239.double_71 * Class239.double_71 * Class239.double_71;
					Class239.double_55 = 3.0 * Class239.double_187 * Class239.double_187 * Class239.double_32 * Class239.double_32;
					Class239.double_56 = 2.0 * Class239.double_55 * Class239.double_65 * Class239.double_82 * 1.7891679E-06;
					Class239.double_57 = 3.0 * Class239.double_55 * Class239.double_71 * Class239.double_85 * 2.2123015E-07 * Class239.double_32;
					Class239.double_55 = Class239.double_55 * Class239.double_68 * Class239.double_86 * 2.1460748E-06 * Class239.double_32;
					Class239.double_78 = 0.13130908;
					Class239.double_79 = 2.8843198;
					Class239.double_80 = 0.37448087;
					Class239.double_176 = Class239.double_180 + class243_0.double_9 + class243_0.double_8 - Class239.double_153;
					Class239.double_35 = Class239.double_9 + Class239.double_189 - 0.0043752691;
					Class239.double_35 = Class239.double_35 + Class239.double_146 + Class239.double_143 + Class239.double_144;
				}
				else if (!(Class239.double_187 < 0.00826 | Class239.double_187 > 0.00924 | Class239.double_63 < 0.5))
				{
					Class239.int_0 = 1;
					Class239.double_62 = Class239.double_63 * Class239.double_0;
					Class239.double_83 = -0.306 - (Class239.double_63 - 0.64) * 0.44;
					if (Class239.double_63 < 0.65)
					{
						Class239.double_84 = 3.616 - 13.247 * Class239.double_63 + 16.29 * Class239.double_0;
						Class239.double_86 = -19.302 + 117.39 * Class239.double_63 - 228.419 * Class239.double_0 + 156.591 * Class239.double_62;
						Class239.double_87 = -18.9068 + 109.7927 * Class239.double_63 - 214.6334 * Class239.double_0 + 146.5816 * Class239.double_62;
						Class239.double_88 = -41.122 + 242.694 * Class239.double_63 - 471.094 * Class239.double_0 + 313.953 * Class239.double_62;
						Class239.double_89 = -146.407 + 841.88 * Class239.double_63 - 1629.014 * Class239.double_0 + 1083.435 * Class239.double_62;
						Class239.double_90 = -532.114 + 3017.977 * Class239.double_63 - 5740.0 * Class239.double_0 + 3708.276 * Class239.double_62;
					}
					else
					{
						Class239.double_84 = -72.099 + 331.819 * Class239.double_63 - 508.738 * Class239.double_0 + 266.724 * Class239.double_62;
						Class239.double_86 = -346.844 + 1582.851 * Class239.double_63 - 2415.925 * Class239.double_0 + 1246.113 * Class239.double_62;
						Class239.double_87 = -342.585 + 1554.908 * Class239.double_63 - 2366.899 * Class239.double_0 + 1215.972 * Class239.double_62;
						Class239.double_88 = -1052.797 + 4758.686 * Class239.double_63 - 7193.992 * Class239.double_0 + 3651.957 * Class239.double_62;
						Class239.double_89 = -3581.69 + 16178.11 * Class239.double_63 - 24462.77 * Class239.double_0 + 12422.52 * Class239.double_62;
						if (Class239.double_63 > 0.715)
						{
							Class239.double_90 = -5149.66 + 29936.92 * Class239.double_63 - 54087.36 * Class239.double_0 + 31324.56 * Class239.double_62;
						}
						else
						{
							Class239.double_90 = 1464.74 - 4664.75 * Class239.double_63 + 3763.64 * Class239.double_0;
						}
					}
					if (Class239.double_63 < 0.7)
					{
						Class239.double_93 = -919.2277 + 4988.61 * Class239.double_63 - 9064.77 * Class239.double_0 + 5542.21 * Class239.double_62;
						Class239.double_91 = -822.71072 + 4568.6173 * Class239.double_63 - 8491.4146 * Class239.double_0 + 5337.524 * Class239.double_62;
						Class239.double_92 = -853.666 + 4690.25 * Class239.double_63 - 8624.77 * Class239.double_0 + 5341.4 * Class239.double_62;
					}
					else
					{
						Class239.double_93 = -37995.78 + 161616.52 * Class239.double_63 - 229838.2 * Class239.double_0 + 109377.94 * Class239.double_62;
						Class239.double_91 = -51752.104 + 218913.95 * Class239.double_63 - 309468.16 * Class239.double_0 + 146349.42 * Class239.double_62;
						Class239.double_92 = -40023.88 + 170470.89 * Class239.double_63 - 242699.48 * Class239.double_0 + 115605.82 * Class239.double_62;
					}
					Class239.double_130 = Class239.double_1 * Class239.double_1;
					Class239.double_65 = 0.75 * (1.0 + 2.0 * Class239.double_2 + Class239.double_5);
					Class239.double_66 = 1.5 * Class239.double_130;
					Class239.double_69 = 1.875 * Class239.double_1 * (1.0 - 2.0 * Class239.double_2 - 3.0 * Class239.double_5);
					Class239.double_70 = -1.875 * Class239.double_1 * (1.0 + 2.0 * Class239.double_2 - 3.0 * Class239.double_5);
					Class239.double_72 = 35.0 * Class239.double_130 * Class239.double_65;
					Class239.double_73 = 39.375 * Class239.double_130 * Class239.double_130;
					Class239.double_74 = 9.84375 * Class239.double_1 * (Class239.double_130 * (1.0 - 2.0 * Class239.double_2 - 5.0 * Class239.double_5) + 0.33333333 * (-2.0 + 4.0 * Class239.double_2 + 6.0 * Class239.double_5));
					Class239.double_75 = Class239.double_1 * (4.92187512 * Class239.double_130 * (-2.0 - 4.0 * Class239.double_2 + 10.0 * Class239.double_5) + 6.56250012 * (1.0 + 2.0 * Class239.double_2 - 3.0 * Class239.double_5));
					Class239.double_76 = 29.53125 * Class239.double_1 * (2.0 - 8.0 * Class239.double_2 + Class239.double_5 * (-12.0 + 8.0 * Class239.double_2 + 10.0 * Class239.double_5));
					Class239.double_77 = 29.53125 * Class239.double_1 * (-2.0 - 8.0 * Class239.double_2 + Class239.double_5 * (12.0 + 8.0 * Class239.double_2 - 10.0 * Class239.double_5));
					Class239.double_184 = Class239.double_187 * Class239.double_187;
					Class239.double_30 = Class239.double_32 * Class239.double_32;
					Class239.double_152 = 3.0 * Class239.double_184 * Class239.double_30;
					Class239.double_151 = Class239.double_152 * 1.7891679E-06;
					Class239.double_42 = Class239.double_151 * Class239.double_65 * Class239.double_83;
					Class239.double_43 = Class239.double_151 * Class239.double_66 * Class239.double_84;
					Class239.double_152 *= Class239.double_32;
					Class239.double_151 = Class239.double_152 * 3.7393792E-07;
					Class239.double_44 = Class239.double_151 * Class239.double_69 * Class239.double_86;
					Class239.double_45 = Class239.double_151 * Class239.double_70 * Class239.double_87;
					Class239.double_152 *= Class239.double_32;
					Class239.double_151 = 2.0 * Class239.double_152 * 7.3636953E-09;
					Class239.double_46 = Class239.double_151 * Class239.double_72 * Class239.double_88;
					Class239.double_47 = Class239.double_151 * Class239.double_73 * Class239.double_89;
					Class239.double_152 *= Class239.double_32;
					Class239.double_151 = Class239.double_152 * 1.1428639E-07;
					Class239.double_48 = Class239.double_151 * Class239.double_74 * Class239.double_90;
					Class239.double_49 = Class239.double_151 * Class239.double_75 * Class239.double_92;
					Class239.double_151 = 2.0 * Class239.double_152 * 2.1765803E-09;
					Class239.double_50 = Class239.double_151 * Class239.double_76 * Class239.double_91;
					Class239.double_51 = Class239.double_151 * Class239.double_77 * Class239.double_93;
					Class239.double_176 = Class239.double_180 + 2.0 * class243_0.double_9 - Class239.double_153 - Class239.double_153;
					Class239.double_35 = Class239.double_9 + Class239.double_11 + Class239.double_11 - 0.0043752691 - 0.0043752691;
					Class239.double_35 = Class239.double_35 + Class239.double_146 + Class239.double_144 + Class239.double_144;
				}
				Class239.double_164 = Class239.double_35 - Class239.double_187;
				Class239.double_178 = Class239.double_176;
				Class239.double_183 = Class239.double_187;
				Class239.double_33 = 0.0;
				Class239.double_150 = 720.0;
				Class239.double_149 = -720.0;
				Class239.double_148 = 259200.0;
				break;
			case 2:
				Class239.double_13 += Class239.double_146 * Class239.double_19;
				Class239.double_14 += Class239.double_143 * Class239.double_19;
				Class239.double_15 += Class239.double_144 * Class239.double_19;
				Class239.double_16 = class243_0.double_6 + Class239.double_142 * Class239.double_19;
				Class239.double_17 = class243_0.double_5 + Class239.double_145 * Class239.double_19;
				if (Class239.double_17 < 0.0)
				{
					Class239.double_17 = -Class239.double_17;
					Class239.double_15 += 3.14159265358979;
					Class239.double_14 -= 3.14159265358979;
				}
				if (Class239.int_0 != 0)
				{
					Class239.int_6 = 0;
					Class239.int_1 = 0;
					int num2 = 0;
					do
					{
						if (Class239.int_1 == 0)
						{
							if (Class239.double_33 == 0.0)
							{
								if (Class239.double_19 >= 0.0)
								{
									Class239.double_58 = Class239.double_150;
								}
								else
								{
									Class239.double_58 = Class239.double_149;
								}
								Class239.double_33 = 0.0;
								Class239.double_183 = Class239.double_187;
								Class239.double_178 = Class239.double_176;
								Class239.int_1 = 1;
							}
							else if (Math.Abs(Class239.double_19) < Math.Abs(Class239.double_33))
							{
								Class239.double_58 = Class239.double_150;
								if (Class239.double_19 >= 0.0)
								{
									Class239.double_58 = Class239.double_149;
								}
								Class239.int_3 = 100;
								Class239.int_1 = 0;
							}
							else
							{
								Class239.double_58 = Class239.double_149;
								if (Class239.double_19 > 0.0)
								{
									Class239.double_58 = Class239.double_150;
								}
								Class239.int_1 = 1;
							}
						}
						if (Class239.int_1 == 1)
						{
							if (Math.Abs(Class239.double_19 - Class239.double_33) > Class239.double_150)
							{
								Class239.int_3 = 125;
								Class239.int_1 = 0;
							}
							else
							{
								Class239.double_81 = Class239.double_19 - Class239.double_33;
								Class239.int_4 = 140;
								Class239.int_1 = 1;
							}
						}
						if (Class239.int_1 == 0)
						{
							Class239.int_4 = 165;
						}
						Class239.int_1 = 0;
						if (Class239.int_2 != 0)
						{
							Class239.double_182 = Class239.double_55 * Math.Sin(Class239.double_178 - Class239.double_78) + Class239.double_56 * Math.Sin(2.0 * (Class239.double_178 - Class239.double_79)) + Class239.double_57 * Math.Sin(3.0 * (Class239.double_178 - Class239.double_80));
							Class239.double_181 = Class239.double_55 * Math.Cos(Class239.double_178 - Class239.double_78) + 2.0 * Class239.double_56 * Math.Cos(2.0 * (Class239.double_178 - Class239.double_79)) + 3.0 * Class239.double_57 * Math.Cos(3.0 * (Class239.double_178 - Class239.double_80));
						}
						else
						{
							Class239.double_188 = Class239.double_95 + Class239.double_10 * Class239.double_33;
							Class239.double_157 = Class239.double_188 + Class239.double_188;
							Class239.double_156 = Class239.double_178 + Class239.double_178;
							Class239.double_182 = Class239.double_42 * Math.Sin(Class239.double_157 + Class239.double_178 - 5.7686396) + Class239.double_43 * Math.Sin(Class239.double_178 - 5.7686396) + Class239.double_44 * Math.Sin(Class239.double_188 + Class239.double_178 - 0.95240898) + Class239.double_45 * Math.Sin(-Class239.double_188 + Class239.double_178 - 0.95240898) + Class239.double_46 * Math.Sin(Class239.double_157 + Class239.double_156 - 1.8014998) + Class239.double_47 * Math.Sin(Class239.double_156 - 1.8014998) + Class239.double_48 * Math.Sin(Class239.double_188 + Class239.double_178 - 1.050833) + Class239.double_49 * Math.Sin(-Class239.double_188 + Class239.double_178 - 1.050833) + Class239.double_50 * Math.Sin(Class239.double_188 + Class239.double_156 - 4.4108898) + Class239.double_51 * Math.Sin(-Class239.double_188 + Class239.double_156 - 4.4108898);
							Class239.double_181 = Class239.double_42 * Math.Cos(Class239.double_157 + Class239.double_178 - 5.7686396) + Class239.double_43 * Math.Cos(Class239.double_178 - 5.7686396) + Class239.double_44 * Math.Cos(Class239.double_188 + Class239.double_178 - 0.95240898) + Class239.double_45 * Math.Cos(-Class239.double_188 + Class239.double_178 - 0.95240898) + Class239.double_48 * Math.Cos(Class239.double_188 + Class239.double_178 - 1.050833) + Class239.double_49 * Math.Cos(-Class239.double_188 + Class239.double_178 - 1.050833) + 2.0 * (Class239.double_46 * Math.Cos(Class239.double_157 + Class239.double_156 - 1.8014998) + Class239.double_47 * Math.Cos(Class239.double_156 - 1.8014998) + Class239.double_50 * Math.Cos(Class239.double_188 + Class239.double_156 - 4.4108898) + Class239.double_51 * Math.Cos(-Class239.double_188 + Class239.double_156 - 4.4108898));
						}
						Class239.double_177 = Class239.double_183 + Class239.double_164;
						Class239.double_181 *= Class239.double_177;
						int num3 = Class239.int_4;
						if (num3 != 140)
						{
							if (num3 == 165)
							{
								Class239.int_1 = 0;
							}
						}
						else
						{
							Class239.double_18 = Class239.double_183 + Class239.double_182 * Class239.double_81 + Class239.double_181 * Class239.double_81 * Class239.double_81 * 0.5;
							Class239.double_172 = Class239.double_178 + Class239.double_177 * Class239.double_81 + Class239.double_182 * Class239.double_81 * Class239.double_81 * 0.5;
							Class239.double_151 = -Class239.double_15 + Class239.double_153 + Class239.double_19 * 0.0043752691;
							Class239.double_13 = Class239.double_172 - Class239.double_14 + Class239.double_151;
							if (Class239.int_2 == 0)
							{
								Class239.double_13 = Class239.double_172 + Class239.double_151 + Class239.double_151;
							}
							Class239.int_1 = 1;
							Class239.int_6 = 1;
						}
						if (Class239.int_1 == 0)
						{
							Class239.double_178 = Class239.double_178 + Class239.double_177 * Class239.double_58 + Class239.double_182 * Class239.double_148;
							Class239.double_183 = Class239.double_183 + Class239.double_182 * Class239.double_58 + Class239.double_181 * Class239.double_148;
							Class239.double_33 += Class239.double_58;
							int num4 = Class239.int_3;
							if (num4 != 100)
							{
								if (num4 == 125)
								{
									Class239.int_1 = 1;
								}
							}
							else
							{
								Class239.int_1 = 0;
							}
						}
						num2++;
					}
					while (!(Class239.int_6 == 0 | num2 >= 150));
				}
				break;
			case 3:
				Class239.double_131 = Math.Sin(Class239.double_17);
				Class239.double_38 = Math.Cos(Class239.double_17);
				if (Math.Abs(Class239.double_109 - Class239.double_19) > 30.0)
				{
					Class239.double_109 = Class239.double_19;
					Class239.double_211 = Class239.double_214 + 1.19459E-05 * Class239.double_19;
					Class239.double_210 = Class239.double_211 + 0.0335 * Math.Sin(Class239.double_211);
					Class239.double_134 = Math.Sin(Class239.double_210);
					Class239.double_64 = 0.5 * Class239.double_134 * Class239.double_134 - 0.25;
					Class239.double_67 = -0.5 * Class239.double_134 * Math.Cos(Class239.double_210);
					Class239.double_114 = Class239.double_111 * Class239.double_64 + Class239.double_112 * Class239.double_67;
					Class239.double_135 = Class239.double_127 * Class239.double_64 + Class239.double_128 * Class239.double_67;
					Class239.double_141 = Class239.double_137 * Class239.double_64 + Class239.double_138 * Class239.double_67 + Class239.double_139 * Class239.double_134;
					Class239.double_120 = Class239.double_116 * Class239.double_64 + Class239.double_117 * Class239.double_67 + Class239.double_118 * Class239.double_134;
					Class239.double_125 = Class239.double_122 * Class239.double_64 + Class239.double_123 * Class239.double_67;
					Class239.double_211 = Class239.double_213 + 0.00015835218 * Class239.double_19;
					Class239.double_210 = Class239.double_211 + 0.1098 * Math.Sin(Class239.double_211);
					Class239.double_134 = Math.Sin(Class239.double_210);
					Class239.double_64 = 0.5 * Class239.double_134 * Class239.double_134 - 0.25;
					Class239.double_67 = -0.5 * Class239.double_134 * Math.Cos(Class239.double_210);
					Class239.double_113 = Class239.double_61 * Class239.double_64 + Class239.double_60 * Class239.double_67;
					Class239.double_129 = Class239.double_170 * Class239.double_64 + Class239.double_171 * Class239.double_67;
					Class239.double_140 = Class239.double_173 * Class239.double_64 + Class239.double_174 * Class239.double_67 + Class239.double_175 * Class239.double_134;
					Class239.double_119 = Class239.double_165 * Class239.double_64 + Class239.double_166 * Class239.double_67 + Class239.double_167 * Class239.double_134;
					Class239.double_124 = Class239.double_168 * Class239.double_64 + Class239.double_169 * Class239.double_67;
					Class239.double_96 = Class239.double_114 + Class239.double_113;
					Class239.double_99 = Class239.double_135 + Class239.double_129;
					Class239.double_100 = Class239.double_141 + Class239.double_140;
				}
				Class239.double_97 = Class239.double_120 + Class239.double_119;
				Class239.double_98 = Class239.double_125 + Class239.double_124;
				Class239.double_17 += Class239.double_99;
				Class239.double_16 += Class239.double_96;
				if (Class239.double_190 > 0.2)
				{
					Class239.double_98 /= Class239.double_1;
					Class239.double_97 -= Class239.double_2 * Class239.double_98;
					Class239.double_14 += Class239.double_97;
					Class239.double_15 += Class239.double_98;
					Class239.double_13 += Class239.double_100;
				}
				else
				{
					Class239.double_132 = Math.Sin(Class239.double_15);
					Class239.double_39 = Math.Cos(Class239.double_15);
					Class239.double_31 = Class239.double_131 * Class239.double_132;
					Class239.double_34 = Class239.double_131 * Class239.double_39;
					Class239.double_52 = Class239.double_98 * Class239.double_39 + Class239.double_99 * Class239.double_38 * Class239.double_132;
					Class239.double_54 = -Class239.double_98 * Class239.double_132 + Class239.double_99 * Class239.double_38 * Class239.double_39;
					Class239.double_31 += Class239.double_52;
					Class239.double_34 += Class239.double_54;
					Class239.double_179 = Class239.double_13 + Class239.double_14 + Class239.double_38 * Class239.double_15;
					Class239.double_59 = Class239.double_100 + Class239.double_97 - Class239.double_99 * Class239.double_15 * Class239.double_131;
					Class239.double_179 += Class239.double_59;
					Class239.double_15 = Class244.smethod_5(ref Class239.double_31, ref Class239.double_34);
					Class239.double_13 += Class239.double_100;
					Class239.double_14 = Class239.double_179 - Class239.double_13 - Math.Cos(Class239.double_17) * Class239.double_15;
				}
				break;
			}
		}

		// Token: 0x040038EC RID: 14572
		public static double double_0;

		// Token: 0x040038ED RID: 14573
		public static double double_1;

		// Token: 0x040038EE RID: 14574
		public static double double_2 = 0.0;

		// Token: 0x040038EF RID: 14575
		public static double double_3 = 0.0;

		// Token: 0x040038F0 RID: 14576
		public static double double_4 = 0.0;

		// Token: 0x040038F1 RID: 14577
		public static double double_5 = 0.0;

		// Token: 0x040038F2 RID: 14578
		public static double double_6 = 0.0;

		// Token: 0x040038F3 RID: 14579
		public static double double_7 = 0.0;

		// Token: 0x040038F4 RID: 14580
		public static double double_8;

		// Token: 0x040038F5 RID: 14581
		public static double double_9;

		// Token: 0x040038F6 RID: 14582
		public static double double_10;

		// Token: 0x040038F7 RID: 14583
		public static double double_11;

		// Token: 0x040038F8 RID: 14584
		public static double double_12;

		// Token: 0x040038F9 RID: 14585
		public static double double_13;

		// Token: 0x040038FA RID: 14586
		public static double double_14;

		// Token: 0x040038FB RID: 14587
		public static double double_15;

		// Token: 0x040038FC RID: 14588
		public static double double_16;

		// Token: 0x040038FD RID: 14589
		public static double double_17;

		// Token: 0x040038FE RID: 14590
		public static double double_18;

		// Token: 0x040038FF RID: 14591
		public static double double_19;

		// Token: 0x04003900 RID: 14592
		private static int int_0;

		// Token: 0x04003901 RID: 14593
		private static StaticLocalInitFlag staticLocalInitFlag_0;

		// Token: 0x04003902 RID: 14594
		private static int int_1;

		// Token: 0x04003903 RID: 14595
		private static StaticLocalInitFlag staticLocalInitFlag_1;

		// Token: 0x04003904 RID: 14596
		private static int int_2 = 0;

		// Token: 0x04003905 RID: 14597
		private static StaticLocalInitFlag staticLocalInitFlag_2;

		// Token: 0x04003906 RID: 14598
		private static int int_3 = 0;

		// Token: 0x04003907 RID: 14599
		private static StaticLocalInitFlag staticLocalInitFlag_3;

		// Token: 0x04003908 RID: 14600
		private static int int_4;

		// Token: 0x04003909 RID: 14601
		private static StaticLocalInitFlag staticLocalInitFlag_4;

		// Token: 0x0400390A RID: 14602
		private static int int_5;

		// Token: 0x0400390B RID: 14603
		private static StaticLocalInitFlag staticLocalInitFlag_5;

		// Token: 0x0400390C RID: 14604
		private static int int_6;

		// Token: 0x0400390D RID: 14605
		private static StaticLocalInitFlag staticLocalInitFlag_6;

		// Token: 0x0400390E RID: 14606
		private static double double_20;

		// Token: 0x0400390F RID: 14607
		private static StaticLocalInitFlag staticLocalInitFlag_7;

		// Token: 0x04003910 RID: 14608
		private static double double_21;

		// Token: 0x04003911 RID: 14609
		private static StaticLocalInitFlag staticLocalInitFlag_8;

		// Token: 0x04003912 RID: 14610
		private static double double_22;

		// Token: 0x04003913 RID: 14611
		private static StaticLocalInitFlag staticLocalInitFlag_9;

		// Token: 0x04003914 RID: 14612
		private static double double_23;

		// Token: 0x04003915 RID: 14613
		private static StaticLocalInitFlag staticLocalInitFlag_10;

		// Token: 0x04003916 RID: 14614
		private static double double_24;

		// Token: 0x04003917 RID: 14615
		private static StaticLocalInitFlag staticLocalInitFlag_11;

		// Token: 0x04003918 RID: 14616
		private static double double_25;

		// Token: 0x04003919 RID: 14617
		private static StaticLocalInitFlag staticLocalInitFlag_12;

		// Token: 0x0400391A RID: 14618
		private static double double_26;

		// Token: 0x0400391B RID: 14619
		private static StaticLocalInitFlag staticLocalInitFlag_13;

		// Token: 0x0400391C RID: 14620
		private static double double_27;

		// Token: 0x0400391D RID: 14621
		private static StaticLocalInitFlag staticLocalInitFlag_14;

		// Token: 0x0400391E RID: 14622
		private static double double_28;

		// Token: 0x0400391F RID: 14623
		private static StaticLocalInitFlag staticLocalInitFlag_15;

		// Token: 0x04003920 RID: 14624
		private static double double_29;

		// Token: 0x04003921 RID: 14625
		private static StaticLocalInitFlag staticLocalInitFlag_16;

		// Token: 0x04003922 RID: 14626
		private static double double_30;

		// Token: 0x04003923 RID: 14627
		private static StaticLocalInitFlag staticLocalInitFlag_17;

		// Token: 0x04003924 RID: 14628
		private static double double_31;

		// Token: 0x04003925 RID: 14629
		private static StaticLocalInitFlag staticLocalInitFlag_18;

		// Token: 0x04003926 RID: 14630
		private static double double_32;

		// Token: 0x04003927 RID: 14631
		private static StaticLocalInitFlag staticLocalInitFlag_19;

		// Token: 0x04003928 RID: 14632
		private static double double_33;

		// Token: 0x04003929 RID: 14633
		private static StaticLocalInitFlag staticLocalInitFlag_20;

		// Token: 0x0400392A RID: 14634
		private static double double_34;

		// Token: 0x0400392B RID: 14635
		private static StaticLocalInitFlag staticLocalInitFlag_21;

		// Token: 0x0400392C RID: 14636
		private static double double_35;

		// Token: 0x0400392D RID: 14637
		private static StaticLocalInitFlag staticLocalInitFlag_22;

		// Token: 0x0400392E RID: 14638
		private static double double_36;

		// Token: 0x0400392F RID: 14639
		private static StaticLocalInitFlag staticLocalInitFlag_23;

		// Token: 0x04003930 RID: 14640
		private static double double_37;

		// Token: 0x04003931 RID: 14641
		private static StaticLocalInitFlag staticLocalInitFlag_24;

		// Token: 0x04003932 RID: 14642
		private static double double_38;

		// Token: 0x04003933 RID: 14643
		private static StaticLocalInitFlag staticLocalInitFlag_25;

		// Token: 0x04003934 RID: 14644
		private static double double_39;

		// Token: 0x04003935 RID: 14645
		private static StaticLocalInitFlag staticLocalInitFlag_26;

		// Token: 0x04003936 RID: 14646
		private static double double_40;

		// Token: 0x04003937 RID: 14647
		private static StaticLocalInitFlag staticLocalInitFlag_27;

		// Token: 0x04003938 RID: 14648
		private static double double_41;

		// Token: 0x04003939 RID: 14649
		private static StaticLocalInitFlag staticLocalInitFlag_28;

		// Token: 0x0400393A RID: 14650
		private static double double_42;

		// Token: 0x0400393B RID: 14651
		private static StaticLocalInitFlag staticLocalInitFlag_29;

		// Token: 0x0400393C RID: 14652
		private static double double_43;

		// Token: 0x0400393D RID: 14653
		private static StaticLocalInitFlag staticLocalInitFlag_30;

		// Token: 0x0400393E RID: 14654
		private static double double_44;

		// Token: 0x0400393F RID: 14655
		private static StaticLocalInitFlag staticLocalInitFlag_31;

		// Token: 0x04003940 RID: 14656
		private static double double_45;

		// Token: 0x04003941 RID: 14657
		private static StaticLocalInitFlag staticLocalInitFlag_32;

		// Token: 0x04003942 RID: 14658
		private static double double_46;

		// Token: 0x04003943 RID: 14659
		private static StaticLocalInitFlag staticLocalInitFlag_33;

		// Token: 0x04003944 RID: 14660
		private static double double_47;

		// Token: 0x04003945 RID: 14661
		private static StaticLocalInitFlag staticLocalInitFlag_34;

		// Token: 0x04003946 RID: 14662
		private static double double_48;

		// Token: 0x04003947 RID: 14663
		private static StaticLocalInitFlag staticLocalInitFlag_35;

		// Token: 0x04003948 RID: 14664
		private static double double_49;

		// Token: 0x04003949 RID: 14665
		private static StaticLocalInitFlag staticLocalInitFlag_36;

		// Token: 0x0400394A RID: 14666
		private static double double_50;

		// Token: 0x0400394B RID: 14667
		private static StaticLocalInitFlag staticLocalInitFlag_37;

		// Token: 0x0400394C RID: 14668
		private static double double_51;

		// Token: 0x0400394D RID: 14669
		private static StaticLocalInitFlag staticLocalInitFlag_38;

		// Token: 0x0400394E RID: 14670
		private static double double_52;

		// Token: 0x0400394F RID: 14671
		private static StaticLocalInitFlag staticLocalInitFlag_39;

		// Token: 0x04003950 RID: 14672
		private static double double_53;

		// Token: 0x04003951 RID: 14673
		private static StaticLocalInitFlag staticLocalInitFlag_40;

		// Token: 0x04003952 RID: 14674
		private static double double_54;

		// Token: 0x04003953 RID: 14675
		private static StaticLocalInitFlag staticLocalInitFlag_41;

		// Token: 0x04003954 RID: 14676
		private static double double_55;

		// Token: 0x04003955 RID: 14677
		private static StaticLocalInitFlag staticLocalInitFlag_42;

		// Token: 0x04003956 RID: 14678
		private static double double_56;

		// Token: 0x04003957 RID: 14679
		private static StaticLocalInitFlag staticLocalInitFlag_43;

		// Token: 0x04003958 RID: 14680
		private static double double_57;

		// Token: 0x04003959 RID: 14681
		private static StaticLocalInitFlag staticLocalInitFlag_44;

		// Token: 0x0400395A RID: 14682
		private static double double_58;

		// Token: 0x0400395B RID: 14683
		private static StaticLocalInitFlag staticLocalInitFlag_45;

		// Token: 0x0400395C RID: 14684
		private static double double_59;

		// Token: 0x0400395D RID: 14685
		private static StaticLocalInitFlag staticLocalInitFlag_46;

		// Token: 0x0400395E RID: 14686
		private static double double_60;

		// Token: 0x0400395F RID: 14687
		private static StaticLocalInitFlag staticLocalInitFlag_47;

		// Token: 0x04003960 RID: 14688
		private static double double_61;

		// Token: 0x04003961 RID: 14689
		private static StaticLocalInitFlag staticLocalInitFlag_48;

		// Token: 0x04003962 RID: 14690
		private static double double_62;

		// Token: 0x04003963 RID: 14691
		private static StaticLocalInitFlag staticLocalInitFlag_49;

		// Token: 0x04003964 RID: 14692
		private static double double_63;

		// Token: 0x04003965 RID: 14693
		private static StaticLocalInitFlag staticLocalInitFlag_50;

		// Token: 0x04003966 RID: 14694
		private static double double_64;

		// Token: 0x04003967 RID: 14695
		private static StaticLocalInitFlag staticLocalInitFlag_51;

		// Token: 0x04003968 RID: 14696
		private static double double_65;

		// Token: 0x04003969 RID: 14697
		private static StaticLocalInitFlag staticLocalInitFlag_52;

		// Token: 0x0400396A RID: 14698
		private static double double_66;

		// Token: 0x0400396B RID: 14699
		private static StaticLocalInitFlag staticLocalInitFlag_53;

		// Token: 0x0400396C RID: 14700
		private static double double_67;

		// Token: 0x0400396D RID: 14701
		private static StaticLocalInitFlag staticLocalInitFlag_54;

		// Token: 0x0400396E RID: 14702
		private static double double_68;

		// Token: 0x0400396F RID: 14703
		private static StaticLocalInitFlag staticLocalInitFlag_55;

		// Token: 0x04003970 RID: 14704
		private static double double_69;

		// Token: 0x04003971 RID: 14705
		private static StaticLocalInitFlag staticLocalInitFlag_56;

		// Token: 0x04003972 RID: 14706
		private static double double_70;

		// Token: 0x04003973 RID: 14707
		private static StaticLocalInitFlag staticLocalInitFlag_57;

		// Token: 0x04003974 RID: 14708
		private static double double_71;

		// Token: 0x04003975 RID: 14709
		private static StaticLocalInitFlag staticLocalInitFlag_58;

		// Token: 0x04003976 RID: 14710
		private static double double_72;

		// Token: 0x04003977 RID: 14711
		private static StaticLocalInitFlag staticLocalInitFlag_59;

		// Token: 0x04003978 RID: 14712
		private static double double_73;

		// Token: 0x04003979 RID: 14713
		private static StaticLocalInitFlag staticLocalInitFlag_60;

		// Token: 0x0400397A RID: 14714
		private static double double_74;

		// Token: 0x0400397B RID: 14715
		private static StaticLocalInitFlag staticLocalInitFlag_61;

		// Token: 0x0400397C RID: 14716
		private static double double_75;

		// Token: 0x0400397D RID: 14717
		private static StaticLocalInitFlag staticLocalInitFlag_62;

		// Token: 0x0400397E RID: 14718
		private static double double_76;

		// Token: 0x0400397F RID: 14719
		private static StaticLocalInitFlag staticLocalInitFlag_63;

		// Token: 0x04003980 RID: 14720
		private static double double_77;

		// Token: 0x04003981 RID: 14721
		private static StaticLocalInitFlag staticLocalInitFlag_64;

		// Token: 0x04003982 RID: 14722
		private static double double_78;

		// Token: 0x04003983 RID: 14723
		private static StaticLocalInitFlag staticLocalInitFlag_65;

		// Token: 0x04003984 RID: 14724
		private static double double_79;

		// Token: 0x04003985 RID: 14725
		private static StaticLocalInitFlag staticLocalInitFlag_66;

		// Token: 0x04003986 RID: 14726
		private static double double_80;

		// Token: 0x04003987 RID: 14727
		private static StaticLocalInitFlag staticLocalInitFlag_67;

		// Token: 0x04003988 RID: 14728
		private static double double_81;

		// Token: 0x04003989 RID: 14729
		private static StaticLocalInitFlag staticLocalInitFlag_68;

		// Token: 0x0400398A RID: 14730
		private static double double_82;

		// Token: 0x0400398B RID: 14731
		private static StaticLocalInitFlag staticLocalInitFlag_69;

		// Token: 0x0400398C RID: 14732
		private static double double_83;

		// Token: 0x0400398D RID: 14733
		private static StaticLocalInitFlag staticLocalInitFlag_70;

		// Token: 0x0400398E RID: 14734
		private static double double_84;

		// Token: 0x0400398F RID: 14735
		private static StaticLocalInitFlag staticLocalInitFlag_71;

		// Token: 0x04003990 RID: 14736
		private static double double_85;

		// Token: 0x04003991 RID: 14737
		private static StaticLocalInitFlag staticLocalInitFlag_72;

		// Token: 0x04003992 RID: 14738
		private static double double_86;

		// Token: 0x04003993 RID: 14739
		private static StaticLocalInitFlag staticLocalInitFlag_73;

		// Token: 0x04003994 RID: 14740
		private static double double_87;

		// Token: 0x04003995 RID: 14741
		private static StaticLocalInitFlag staticLocalInitFlag_74;

		// Token: 0x04003996 RID: 14742
		private static double double_88;

		// Token: 0x04003997 RID: 14743
		private static StaticLocalInitFlag staticLocalInitFlag_75;

		// Token: 0x04003998 RID: 14744
		private static double double_89;

		// Token: 0x04003999 RID: 14745
		private static StaticLocalInitFlag staticLocalInitFlag_76;

		// Token: 0x0400399A RID: 14746
		private static double double_90;

		// Token: 0x0400399B RID: 14747
		private static StaticLocalInitFlag staticLocalInitFlag_77;

		// Token: 0x0400399C RID: 14748
		private static double double_91;

		// Token: 0x0400399D RID: 14749
		private static StaticLocalInitFlag staticLocalInitFlag_78;

		// Token: 0x0400399E RID: 14750
		private static double double_92;

		// Token: 0x0400399F RID: 14751
		private static StaticLocalInitFlag staticLocalInitFlag_79;

		// Token: 0x040039A0 RID: 14752
		private static double double_93;

		// Token: 0x040039A1 RID: 14753
		private static StaticLocalInitFlag staticLocalInitFlag_80;

		// Token: 0x040039A2 RID: 14754
		private static double double_94;

		// Token: 0x040039A3 RID: 14755
		private static StaticLocalInitFlag staticLocalInitFlag_81;

		// Token: 0x040039A4 RID: 14756
		private static double double_95;

		// Token: 0x040039A5 RID: 14757
		private static StaticLocalInitFlag staticLocalInitFlag_82;

		// Token: 0x040039A6 RID: 14758
		private static double double_96;

		// Token: 0x040039A7 RID: 14759
		private static StaticLocalInitFlag staticLocalInitFlag_83;

		// Token: 0x040039A8 RID: 14760
		private static double double_97;

		// Token: 0x040039A9 RID: 14761
		private static StaticLocalInitFlag staticLocalInitFlag_84;

		// Token: 0x040039AA RID: 14762
		private static double double_98;

		// Token: 0x040039AB RID: 14763
		private static StaticLocalInitFlag staticLocalInitFlag_85;

		// Token: 0x040039AC RID: 14764
		private static double double_99;

		// Token: 0x040039AD RID: 14765
		private static StaticLocalInitFlag staticLocalInitFlag_86;

		// Token: 0x040039AE RID: 14766
		private static double double_100;

		// Token: 0x040039AF RID: 14767
		private static StaticLocalInitFlag staticLocalInitFlag_87;

		// Token: 0x040039B0 RID: 14768
		private static double double_101;

		// Token: 0x040039B1 RID: 14769
		private static StaticLocalInitFlag staticLocalInitFlag_88;

		// Token: 0x040039B2 RID: 14770
		private static double double_102;

		// Token: 0x040039B3 RID: 14771
		private static StaticLocalInitFlag staticLocalInitFlag_89;

		// Token: 0x040039B4 RID: 14772
		private static double double_103;

		// Token: 0x040039B5 RID: 14773
		private static StaticLocalInitFlag staticLocalInitFlag_90;

		// Token: 0x040039B6 RID: 14774
		private static double double_104;

		// Token: 0x040039B7 RID: 14775
		private static StaticLocalInitFlag staticLocalInitFlag_91;

		// Token: 0x040039B8 RID: 14776
		private static double double_105;

		// Token: 0x040039B9 RID: 14777
		private static StaticLocalInitFlag staticLocalInitFlag_92;

		// Token: 0x040039BA RID: 14778
		private static double double_106;

		// Token: 0x040039BB RID: 14779
		private static StaticLocalInitFlag staticLocalInitFlag_93;

		// Token: 0x040039BC RID: 14780
		private static double double_107;

		// Token: 0x040039BD RID: 14781
		private static StaticLocalInitFlag staticLocalInitFlag_94;

		// Token: 0x040039BE RID: 14782
		private static double double_108;

		// Token: 0x040039BF RID: 14783
		private static StaticLocalInitFlag staticLocalInitFlag_95;

		// Token: 0x040039C0 RID: 14784
		private static double double_109;

		// Token: 0x040039C1 RID: 14785
		private static StaticLocalInitFlag staticLocalInitFlag_96;

		// Token: 0x040039C2 RID: 14786
		private static double double_110;

		// Token: 0x040039C3 RID: 14787
		private static StaticLocalInitFlag staticLocalInitFlag_97;

		// Token: 0x040039C4 RID: 14788
		private static double double_111;

		// Token: 0x040039C5 RID: 14789
		private static StaticLocalInitFlag staticLocalInitFlag_98;

		// Token: 0x040039C6 RID: 14790
		private static double double_112;

		// Token: 0x040039C7 RID: 14791
		private static StaticLocalInitFlag staticLocalInitFlag_99;

		// Token: 0x040039C8 RID: 14792
		private static double double_113;

		// Token: 0x040039C9 RID: 14793
		private static StaticLocalInitFlag staticLocalInitFlag_100;

		// Token: 0x040039CA RID: 14794
		private static double double_114;

		// Token: 0x040039CB RID: 14795
		private static StaticLocalInitFlag staticLocalInitFlag_101;

		// Token: 0x040039CC RID: 14796
		private static double double_115;

		// Token: 0x040039CD RID: 14797
		private static StaticLocalInitFlag staticLocalInitFlag_102;

		// Token: 0x040039CE RID: 14798
		private static double double_116;

		// Token: 0x040039CF RID: 14799
		private static StaticLocalInitFlag staticLocalInitFlag_103;

		// Token: 0x040039D0 RID: 14800
		private static double double_117;

		// Token: 0x040039D1 RID: 14801
		private static StaticLocalInitFlag staticLocalInitFlag_104;

		// Token: 0x040039D2 RID: 14802
		private static double double_118;

		// Token: 0x040039D3 RID: 14803
		private static StaticLocalInitFlag staticLocalInitFlag_105;

		// Token: 0x040039D4 RID: 14804
		private static double double_119;

		// Token: 0x040039D5 RID: 14805
		private static StaticLocalInitFlag staticLocalInitFlag_106;

		// Token: 0x040039D6 RID: 14806
		private static double double_120;

		// Token: 0x040039D7 RID: 14807
		private static StaticLocalInitFlag staticLocalInitFlag_107;

		// Token: 0x040039D8 RID: 14808
		private static double double_121;

		// Token: 0x040039D9 RID: 14809
		private static StaticLocalInitFlag staticLocalInitFlag_108;

		// Token: 0x040039DA RID: 14810
		private static double double_122;

		// Token: 0x040039DB RID: 14811
		private static StaticLocalInitFlag staticLocalInitFlag_109;

		// Token: 0x040039DC RID: 14812
		private static double double_123;

		// Token: 0x040039DD RID: 14813
		private static StaticLocalInitFlag staticLocalInitFlag_110;

		// Token: 0x040039DE RID: 14814
		private static double double_124;

		// Token: 0x040039DF RID: 14815
		private static StaticLocalInitFlag staticLocalInitFlag_111;

		// Token: 0x040039E0 RID: 14816
		private static double double_125;

		// Token: 0x040039E1 RID: 14817
		private static StaticLocalInitFlag staticLocalInitFlag_112;

		// Token: 0x040039E2 RID: 14818
		private static double double_126;

		// Token: 0x040039E3 RID: 14819
		private static StaticLocalInitFlag staticLocalInitFlag_113;

		// Token: 0x040039E4 RID: 14820
		private static double double_127;

		// Token: 0x040039E5 RID: 14821
		private static StaticLocalInitFlag staticLocalInitFlag_114;

		// Token: 0x040039E6 RID: 14822
		private static double double_128;

		// Token: 0x040039E7 RID: 14823
		private static StaticLocalInitFlag staticLocalInitFlag_115;

		// Token: 0x040039E8 RID: 14824
		private static double double_129;

		// Token: 0x040039E9 RID: 14825
		private static StaticLocalInitFlag staticLocalInitFlag_116;

		// Token: 0x040039EA RID: 14826
		private static double double_130;

		// Token: 0x040039EB RID: 14827
		private static StaticLocalInitFlag staticLocalInitFlag_117;

		// Token: 0x040039EC RID: 14828
		private static double double_131;

		// Token: 0x040039ED RID: 14829
		private static StaticLocalInitFlag staticLocalInitFlag_118;

		// Token: 0x040039EE RID: 14830
		private static double double_132;

		// Token: 0x040039EF RID: 14831
		private static StaticLocalInitFlag staticLocalInitFlag_119;

		// Token: 0x040039F0 RID: 14832
		private static double double_133;

		// Token: 0x040039F1 RID: 14833
		private static StaticLocalInitFlag staticLocalInitFlag_120;

		// Token: 0x040039F2 RID: 14834
		private static double double_134;

		// Token: 0x040039F3 RID: 14835
		private static StaticLocalInitFlag staticLocalInitFlag_121;

		// Token: 0x040039F4 RID: 14836
		private static double double_135;

		// Token: 0x040039F5 RID: 14837
		private static StaticLocalInitFlag staticLocalInitFlag_122;

		// Token: 0x040039F6 RID: 14838
		private static double double_136;

		// Token: 0x040039F7 RID: 14839
		private static StaticLocalInitFlag staticLocalInitFlag_123;

		// Token: 0x040039F8 RID: 14840
		private static double double_137;

		// Token: 0x040039F9 RID: 14841
		private static StaticLocalInitFlag staticLocalInitFlag_124;

		// Token: 0x040039FA RID: 14842
		private static double double_138;

		// Token: 0x040039FB RID: 14843
		private static StaticLocalInitFlag staticLocalInitFlag_125;

		// Token: 0x040039FC RID: 14844
		private static double double_139;

		// Token: 0x040039FD RID: 14845
		private static StaticLocalInitFlag staticLocalInitFlag_126;

		// Token: 0x040039FE RID: 14846
		private static double double_140;

		// Token: 0x040039FF RID: 14847
		private static StaticLocalInitFlag staticLocalInitFlag_127;

		// Token: 0x04003A00 RID: 14848
		private static double double_141;

		// Token: 0x04003A01 RID: 14849
		private static StaticLocalInitFlag staticLocalInitFlag_128;

		// Token: 0x04003A02 RID: 14850
		private static double double_142;

		// Token: 0x04003A03 RID: 14851
		private static StaticLocalInitFlag staticLocalInitFlag_129;

		// Token: 0x04003A04 RID: 14852
		private static double double_143;

		// Token: 0x04003A05 RID: 14853
		private static StaticLocalInitFlag staticLocalInitFlag_130;

		// Token: 0x04003A06 RID: 14854
		private static double double_144;

		// Token: 0x04003A07 RID: 14855
		private static StaticLocalInitFlag staticLocalInitFlag_131;

		// Token: 0x04003A08 RID: 14856
		private static double double_145;

		// Token: 0x04003A09 RID: 14857
		private static StaticLocalInitFlag staticLocalInitFlag_132;

		// Token: 0x04003A0A RID: 14858
		private static double double_146;

		// Token: 0x04003A0B RID: 14859
		private static StaticLocalInitFlag staticLocalInitFlag_133;

		// Token: 0x04003A0C RID: 14860
		private static double double_147;

		// Token: 0x04003A0D RID: 14861
		private static StaticLocalInitFlag staticLocalInitFlag_134;

		// Token: 0x04003A0E RID: 14862
		private static double double_148;

		// Token: 0x04003A0F RID: 14863
		private static StaticLocalInitFlag staticLocalInitFlag_135;

		// Token: 0x04003A10 RID: 14864
		private static double double_149;

		// Token: 0x04003A11 RID: 14865
		private static StaticLocalInitFlag staticLocalInitFlag_136;

		// Token: 0x04003A12 RID: 14866
		private static double double_150;

		// Token: 0x04003A13 RID: 14867
		private static StaticLocalInitFlag staticLocalInitFlag_137;

		// Token: 0x04003A14 RID: 14868
		private static double double_151;

		// Token: 0x04003A15 RID: 14869
		private static StaticLocalInitFlag staticLocalInitFlag_138;

		// Token: 0x04003A16 RID: 14870
		private static double double_152;

		// Token: 0x04003A17 RID: 14871
		private static StaticLocalInitFlag staticLocalInitFlag_139;

		// Token: 0x04003A18 RID: 14872
		private static double double_153;

		// Token: 0x04003A19 RID: 14873
		private static StaticLocalInitFlag staticLocalInitFlag_140;

		// Token: 0x04003A1A RID: 14874
		private static double double_154;

		// Token: 0x04003A1B RID: 14875
		private static StaticLocalInitFlag staticLocalInitFlag_141;

		// Token: 0x04003A1C RID: 14876
		private static double double_155;

		// Token: 0x04003A1D RID: 14877
		private static StaticLocalInitFlag staticLocalInitFlag_142;

		// Token: 0x04003A1E RID: 14878
		private static double double_156;

		// Token: 0x04003A1F RID: 14879
		private static StaticLocalInitFlag staticLocalInitFlag_143;

		// Token: 0x04003A20 RID: 14880
		private static double double_157;

		// Token: 0x04003A21 RID: 14881
		private static StaticLocalInitFlag staticLocalInitFlag_144;

		// Token: 0x04003A22 RID: 14882
		private static double double_158;

		// Token: 0x04003A23 RID: 14883
		private static StaticLocalInitFlag staticLocalInitFlag_145;

		// Token: 0x04003A24 RID: 14884
		private static double double_159;

		// Token: 0x04003A25 RID: 14885
		private static StaticLocalInitFlag staticLocalInitFlag_146;

		// Token: 0x04003A26 RID: 14886
		private static double double_160;

		// Token: 0x04003A27 RID: 14887
		private static StaticLocalInitFlag staticLocalInitFlag_147;

		// Token: 0x04003A28 RID: 14888
		private static double double_161;

		// Token: 0x04003A29 RID: 14889
		private static StaticLocalInitFlag staticLocalInitFlag_148;

		// Token: 0x04003A2A RID: 14890
		private static double double_162;

		// Token: 0x04003A2B RID: 14891
		private static StaticLocalInitFlag staticLocalInitFlag_149;

		// Token: 0x04003A2C RID: 14892
		private static double double_163;

		// Token: 0x04003A2D RID: 14893
		private static StaticLocalInitFlag staticLocalInitFlag_150;

		// Token: 0x04003A2E RID: 14894
		private static double double_164;

		// Token: 0x04003A2F RID: 14895
		private static StaticLocalInitFlag staticLocalInitFlag_151;

		// Token: 0x04003A30 RID: 14896
		private static double double_165;

		// Token: 0x04003A31 RID: 14897
		private static StaticLocalInitFlag staticLocalInitFlag_152;

		// Token: 0x04003A32 RID: 14898
		private static double double_166;

		// Token: 0x04003A33 RID: 14899
		private static StaticLocalInitFlag staticLocalInitFlag_153;

		// Token: 0x04003A34 RID: 14900
		private static double double_167;

		// Token: 0x04003A35 RID: 14901
		private static StaticLocalInitFlag staticLocalInitFlag_154;

		// Token: 0x04003A36 RID: 14902
		private static double double_168;

		// Token: 0x04003A37 RID: 14903
		private static StaticLocalInitFlag staticLocalInitFlag_155;

		// Token: 0x04003A38 RID: 14904
		private static double double_169;

		// Token: 0x04003A39 RID: 14905
		private static StaticLocalInitFlag staticLocalInitFlag_156;

		// Token: 0x04003A3A RID: 14906
		private static double double_170;

		// Token: 0x04003A3B RID: 14907
		private static StaticLocalInitFlag staticLocalInitFlag_157;

		// Token: 0x04003A3C RID: 14908
		private static double double_171;

		// Token: 0x04003A3D RID: 14909
		private static StaticLocalInitFlag staticLocalInitFlag_158;

		// Token: 0x04003A3E RID: 14910
		private static double double_172;

		// Token: 0x04003A3F RID: 14911
		private static StaticLocalInitFlag staticLocalInitFlag_159;

		// Token: 0x04003A40 RID: 14912
		private static double double_173;

		// Token: 0x04003A41 RID: 14913
		private static StaticLocalInitFlag staticLocalInitFlag_160;

		// Token: 0x04003A42 RID: 14914
		private static double double_174;

		// Token: 0x04003A43 RID: 14915
		private static StaticLocalInitFlag staticLocalInitFlag_161;

		// Token: 0x04003A44 RID: 14916
		private static double double_175;

		// Token: 0x04003A45 RID: 14917
		private static StaticLocalInitFlag staticLocalInitFlag_162;

		// Token: 0x04003A46 RID: 14918
		private static double double_176;

		// Token: 0x04003A47 RID: 14919
		private static StaticLocalInitFlag staticLocalInitFlag_163;

		// Token: 0x04003A48 RID: 14920
		private static double double_177;

		// Token: 0x04003A49 RID: 14921
		private static StaticLocalInitFlag staticLocalInitFlag_164;

		// Token: 0x04003A4A RID: 14922
		private static double double_178;

		// Token: 0x04003A4B RID: 14923
		private static StaticLocalInitFlag staticLocalInitFlag_165;

		// Token: 0x04003A4C RID: 14924
		private static double double_179;

		// Token: 0x04003A4D RID: 14925
		private static StaticLocalInitFlag staticLocalInitFlag_166;

		// Token: 0x04003A4E RID: 14926
		private static double double_180;

		// Token: 0x04003A4F RID: 14927
		private static StaticLocalInitFlag staticLocalInitFlag_167;

		// Token: 0x04003A50 RID: 14928
		private static double double_181;

		// Token: 0x04003A51 RID: 14929
		private static StaticLocalInitFlag staticLocalInitFlag_168;

		// Token: 0x04003A52 RID: 14930
		private static double double_182;

		// Token: 0x04003A53 RID: 14931
		private static StaticLocalInitFlag staticLocalInitFlag_169;

		// Token: 0x04003A54 RID: 14932
		private static double double_183;

		// Token: 0x04003A55 RID: 14933
		private static StaticLocalInitFlag staticLocalInitFlag_170;

		// Token: 0x04003A56 RID: 14934
		private static double double_184;

		// Token: 0x04003A57 RID: 14935
		private static StaticLocalInitFlag staticLocalInitFlag_171;

		// Token: 0x04003A58 RID: 14936
		private static double double_185;

		// Token: 0x04003A59 RID: 14937
		private static StaticLocalInitFlag staticLocalInitFlag_172;

		// Token: 0x04003A5A RID: 14938
		private static double double_186;

		// Token: 0x04003A5B RID: 14939
		private static StaticLocalInitFlag staticLocalInitFlag_173;

		// Token: 0x04003A5C RID: 14940
		private static double double_187;

		// Token: 0x04003A5D RID: 14941
		private static StaticLocalInitFlag staticLocalInitFlag_174;

		// Token: 0x04003A5E RID: 14942
		private static double double_188;

		// Token: 0x04003A5F RID: 14943
		private static StaticLocalInitFlag staticLocalInitFlag_175;

		// Token: 0x04003A60 RID: 14944
		private static double double_189;

		// Token: 0x04003A61 RID: 14945
		private static StaticLocalInitFlag staticLocalInitFlag_176;

		// Token: 0x04003A62 RID: 14946
		private static double double_190;

		// Token: 0x04003A63 RID: 14947
		private static StaticLocalInitFlag staticLocalInitFlag_177;

		// Token: 0x04003A64 RID: 14948
		private static double double_191;

		// Token: 0x04003A65 RID: 14949
		private static StaticLocalInitFlag staticLocalInitFlag_178;

		// Token: 0x04003A66 RID: 14950
		private static double double_192;

		// Token: 0x04003A67 RID: 14951
		private static StaticLocalInitFlag staticLocalInitFlag_179;

		// Token: 0x04003A68 RID: 14952
		private static double double_193;

		// Token: 0x04003A69 RID: 14953
		private static StaticLocalInitFlag staticLocalInitFlag_180;

		// Token: 0x04003A6A RID: 14954
		private static double double_194;

		// Token: 0x04003A6B RID: 14955
		private static StaticLocalInitFlag staticLocalInitFlag_181;

		// Token: 0x04003A6C RID: 14956
		private static double double_195;

		// Token: 0x04003A6D RID: 14957
		private static StaticLocalInitFlag staticLocalInitFlag_182;

		// Token: 0x04003A6E RID: 14958
		private static double double_196;

		// Token: 0x04003A6F RID: 14959
		private static StaticLocalInitFlag staticLocalInitFlag_183;

		// Token: 0x04003A70 RID: 14960
		private static double double_197;

		// Token: 0x04003A71 RID: 14961
		private static StaticLocalInitFlag staticLocalInitFlag_184;

		// Token: 0x04003A72 RID: 14962
		private static double double_198;

		// Token: 0x04003A73 RID: 14963
		private static StaticLocalInitFlag staticLocalInitFlag_185;

		// Token: 0x04003A74 RID: 14964
		private static double double_199;

		// Token: 0x04003A75 RID: 14965
		private static StaticLocalInitFlag staticLocalInitFlag_186;

		// Token: 0x04003A76 RID: 14966
		private static double double_200;

		// Token: 0x04003A77 RID: 14967
		private static StaticLocalInitFlag staticLocalInitFlag_187;

		// Token: 0x04003A78 RID: 14968
		private static double double_201;

		// Token: 0x04003A79 RID: 14969
		private static StaticLocalInitFlag staticLocalInitFlag_188;

		// Token: 0x04003A7A RID: 14970
		private static double double_202;

		// Token: 0x04003A7B RID: 14971
		private static StaticLocalInitFlag staticLocalInitFlag_189;

		// Token: 0x04003A7C RID: 14972
		private static double double_203;

		// Token: 0x04003A7D RID: 14973
		private static StaticLocalInitFlag staticLocalInitFlag_190;

		// Token: 0x04003A7E RID: 14974
		private static double double_204;

		// Token: 0x04003A7F RID: 14975
		private static StaticLocalInitFlag staticLocalInitFlag_191;

		// Token: 0x04003A80 RID: 14976
		private static double double_205;

		// Token: 0x04003A81 RID: 14977
		private static StaticLocalInitFlag staticLocalInitFlag_192;

		// Token: 0x04003A82 RID: 14978
		private static double double_206;

		// Token: 0x04003A83 RID: 14979
		private static StaticLocalInitFlag staticLocalInitFlag_193;

		// Token: 0x04003A84 RID: 14980
		private static double double_207;

		// Token: 0x04003A85 RID: 14981
		private static StaticLocalInitFlag staticLocalInitFlag_194;

		// Token: 0x04003A86 RID: 14982
		private static double double_208;

		// Token: 0x04003A87 RID: 14983
		private static StaticLocalInitFlag staticLocalInitFlag_195;

		// Token: 0x04003A88 RID: 14984
		private static double double_209;

		// Token: 0x04003A89 RID: 14985
		private static StaticLocalInitFlag staticLocalInitFlag_196;

		// Token: 0x04003A8A RID: 14986
		private static double double_210;

		// Token: 0x04003A8B RID: 14987
		private static StaticLocalInitFlag staticLocalInitFlag_197;

		// Token: 0x04003A8C RID: 14988
		private static double double_211;

		// Token: 0x04003A8D RID: 14989
		private static StaticLocalInitFlag staticLocalInitFlag_198;

		// Token: 0x04003A8E RID: 14990
		private static double double_212;

		// Token: 0x04003A8F RID: 14991
		private static StaticLocalInitFlag staticLocalInitFlag_199;

		// Token: 0x04003A90 RID: 14992
		private static double double_213;

		// Token: 0x04003A91 RID: 14993
		private static StaticLocalInitFlag staticLocalInitFlag_200;

		// Token: 0x04003A92 RID: 14994
		private static double double_214;

		// Token: 0x04003A93 RID: 14995
		private static StaticLocalInitFlag staticLocalInitFlag_201;

		// Token: 0x04003A94 RID: 14996
		private static double double_215;

		// Token: 0x04003A95 RID: 14997
		private static StaticLocalInitFlag staticLocalInitFlag_202;

		// Token: 0x04003A96 RID: 14998
		private static double double_216;

		// Token: 0x04003A97 RID: 14999
		private static StaticLocalInitFlag staticLocalInitFlag_203;

		// Token: 0x04003A98 RID: 15000
		private static double double_217;

		// Token: 0x04003A99 RID: 15001
		private static StaticLocalInitFlag staticLocalInitFlag_204;

		// Token: 0x04003A9A RID: 15002
		private static double double_218;

		// Token: 0x04003A9B RID: 15003
		private static StaticLocalInitFlag staticLocalInitFlag_205;

		// Token: 0x04003A9C RID: 15004
		private static double double_219;

		// Token: 0x04003A9D RID: 15005
		private static StaticLocalInitFlag staticLocalInitFlag_206;

		// Token: 0x04003A9E RID: 15006
		private static double double_220;

		// Token: 0x04003A9F RID: 15007
		private static StaticLocalInitFlag staticLocalInitFlag_207;

		// Token: 0x04003AA0 RID: 15008
		private static double double_221;

		// Token: 0x04003AA1 RID: 15009
		private static StaticLocalInitFlag staticLocalInitFlag_208;

		// Token: 0x04003AA2 RID: 15010
		private static double double_222;

		// Token: 0x04003AA3 RID: 15011
		private static StaticLocalInitFlag staticLocalInitFlag_209;

		// Token: 0x04003AA4 RID: 15012
		private static double double_223;

		// Token: 0x04003AA5 RID: 15013
		private static StaticLocalInitFlag staticLocalInitFlag_210;

		// Token: 0x04003AA6 RID: 15014
		private static double double_224;

		// Token: 0x04003AA7 RID: 15015
		private static StaticLocalInitFlag staticLocalInitFlag_211;
	}
}
