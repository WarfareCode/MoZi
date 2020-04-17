using System;

namespace ns3
{
	// Token: 0x02000BB9 RID: 3001
	public sealed class Class237
	{
		// Token: 0x06006358 RID: 25432 RVA: 0x003121F0 File Offset: 0x003103F0
		public static void smethod_0(double double_0, ref Class242.Struct26 struct26_0, ref Class242.Struct26 struct26_1, Class242.Class243 class243_0)
		{
			Class242.Struct26 @struct;
			@struct.double_0 = new double[4];
			Class242.Struct26 struct2;
			struct2.double_0 = new double[4];
			Class242.Struct26 struct3;
			struct3.double_0 = new double[4];
			Class242.Struct26 struct4;
			struct4.double_0 = new double[4];
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			double num5 = 0.0;
			double num6 = 0.0;
			double num7 = 1.0122292801892716;
			double num8 = Math.Sqrt(1434962880.0 / Class244.smethod_0(6378.135));
			double num9 = Class244.smethod_1(Class244.smethod_1(0.0065849970249924894));
			double num10 = num8 / class243_0.double_2;
			double num11 = Math.Pow(num10, 0.66666666666666663);
			double num12 = Math.Cos(class243_0.double_5);
			double num13 = Class244.smethod_1(num12);
			double num14 = 3.0 * num13 - 1.0;
			double num15 = Class244.smethod_1(class243_0.double_6);
			double num16 = 1.0 - num15;
			double num17 = Math.Sqrt(num16);
			double num18 = 0.00081196185 * num14 / (Class244.smethod_1(num11) * num17 * num16);
			double num19 = num11 * (1.0 - num18 * (0.33333333333333331 + num18 * (1.0 + 1.654320987654321 * num18)));
			double num20 = 0.00081196185 * num14 / (Class244.smethod_1(num19) * num17 * num16);
			double num21 = class243_0.double_2 / (1.0 + num20);
			double num22 = num19 / (1.0 - num20);
			int num23 = 0;
			if (num22 * (1.0 - class243_0.double_6) / 1.0 < 1.0344928415594841)
			{
				num23 = 1;
			}
			double num24 = num7;
			double num25 = num9;
			double num26 = (num22 * (1.0 - class243_0.double_6) - 1.0) * 6378.135;
			if (num26 < 156.0)
			{
				num24 = num26 - 78.0;
				if (num26 <= 98.0)
				{
					num24 = 20.0;
				}
				num25 = Math.Pow((120.0 - num24) * 1.0 / 6378.135, 4.0);
				num24 = num24 / 6378.135 + 1.0;
			}
			double num27 = 1.0 / (Class244.smethod_1(num22) * Class244.smethod_1(num16));
			double num28 = 1.0 / (num22 - num24);
			double num29 = num22 * class243_0.double_6 * num28;
			double num30 = Class244.smethod_1(num29);
			double num31 = class243_0.double_6 * num29;
			double num32 = Math.Abs(1.0 - num30);
			double num33 = num25 * Math.Pow(num28, 4.0);
			double num34 = num33 / Math.Pow(num32, 3.5);
			double num35 = num34 * num21 * (num22 * (1.0 + 1.5 * num30 + num31 * (4.0 + num30)) + 0.000405980925 * num28 / num32 * num14 * (8.0 + 3.0 * num30 * (8.0 + num30)));
			double num36 = class243_0.double_4 * num35;
			double num37 = Math.Sin(class243_0.double_5);
			double num38 = 0.0046901403064688327 * Math.Pow(1.0, 3.0);
			double num39 = num33 * num28 * num38 * num21 * 1.0 * num37 / class243_0.double_6;
			double num40 = 1.0 - num13;
			double num41 = 2.0 * num21 * num34 * num22 * num16 * (num29 * (2.0 + 0.5 * num30) + class243_0.double_6 * (0.5 + 2.0 * num30) - 0.0010826158 * num28 / (num22 * num32) * (-3.0 * num14 * (1.0 - 2.0 * num31 + num30 * (1.5 - 0.5 * num31)) + 0.75 * num40 * (2.0 * num30 - num31 * (1.0 + num30)) * Math.Cos(2.0 * class243_0.double_8)));
			double num42 = 2.0 * num34 * num22 * num16 * (1.0 + 2.75 * (num30 + num31) + num31 * num30);
			double num43 = Class244.smethod_1(num13);
			double num44 = 0.0016239237 * num27 * num21;
			num10 = num44 * 0.0005413079 * num27;
			double num45 = 7.7623593749999984E-07 * num27 * num27 * num21;
			double num46 = num21 + 0.5 * num44 * num17 * num14 + 0.0625 * num10 * num17 * (13.0 - 78.0 * num13 + 137.0 * num43);
			double num47 = 1.0 - 5.0 * num13;
			double num48 = -0.5 * num44 * num47 + 0.0625 * num10 * (7.0 - 114.0 * num13 + 395.0 * num43) + num45 * (3.0 - 36.0 * num13 + 49.0 * num43);
			double num49 = -num44 * num12;
			double num50 = num49 + (0.5 * num10 * (4.0 - 19.0 * num13) + 2.0 * num45 * (3.0 - 7.0 * num13)) * num12;
			double num51 = class243_0.double_4 * num39 * Math.Cos(class243_0.double_8);
			double num52 = -0.66666666666666663 * num33 * class243_0.double_4 * 1.0 / num31;
			double num53 = 3.5 * num16 * num49 * num36;
			double num54 = 1.5 * num36;
			double num55 = 0.125 * num38 * num37 * (3.0 + 5.0 * num12) / (1.0 + num12);
			double num56 = 0.25 * num38 * num37;
			double num57 = Math.Pow(1.0 + num29 * Math.Cos(class243_0.double_7), 3.0);
			double num58 = Math.Sin(class243_0.double_7);
			double num59 = 7.0 * num13 - 1.0;
			double num61;
			if (num23 == 0)
			{
				double num60 = Class244.smethod_1(num36);
				num = 4.0 * num22 * num28 * num60;
				num61 = num * num28 * num36 / 3.0;
				num2 = (17.0 * num22 + num24) * num61;
				num3 = 0.5 * num61 * num22 * num28 * (221.0 * num22 + 31.0 * num24) * num36;
				num4 = num + 2.0 * num60;
				num5 = 0.25 * (3.0 * num2 + num36 * (12.0 * num + 10.0 * num60));
				num6 = 0.2 * (3.0 * num3 + 12.0 * num36 * num2 + 6.0 * num * num + 15.0 * num60 * (2.0 * num + num60));
			}
			double num62 = class243_0.double_7 + num46 * double_0;
			double num63 = class243_0.double_8 + num48 * double_0;
			double num64 = class243_0.double_9 + num50 * double_0;
			double num65 = num63;
			double num66 = num62;
			double num67 = Class244.smethod_1(double_0);
			double num68 = num64 + num53 * num67;
			double num69 = 1.0 - num36 * double_0;
			double num70 = class243_0.double_4 * num41 * double_0;
			double num71 = num54 * num67;
			if (num23 == 0)
			{
				double num72 = num51 * double_0;
				double num73 = num52 * (Math.Pow(1.0 + num29 * Math.Cos(num62), 3.0) - num57);
				num61 = num72 + num73;
				num66 = num62 + num61;
				num65 = num63 - num61;
				double num74 = num67 * double_0;
				double num75 = double_0 * num74;
				num69 = num69 - num * num67 - num2 * num74 - num3 * num75;
				num70 += class243_0.double_4 * num42 * (Math.Sin(num66) - num58);
				num71 = num71 + num4 * num74 + num75 * (num5 + double_0 * num6);
			}
			double num76 = num22 * Class244.smethod_1(num69);
			double num77 = class243_0.double_6 - num70;
			double num78 = num66 + num65 + num68 + num21 * num71;
			double double_ = Math.Sqrt(1.0 - Class244.smethod_1(num77));
			double num79 = num8 / Math.Pow(num76, 1.5);
			double num80 = num77 * Math.Cos(num65);
			num61 = 1.0 / (num76 * Class244.smethod_1(double_));
			double num81 = num61 * num55 * num80;
			double num82 = num61 * num56;
			double num83 = num78 + num81;
			double num84 = num77 * Math.Sin(num65) + num82;
			double num85 = num83 - num68;
			double num86 = Class244.smethod_3(ref num85);
			num10 = num86;
			int i = 1;
			double num87;
			double num88;
			double num89;
			double num90;
			double num91;
			double num92;
			double num93;
			do
			{
				num87 = Math.Sin(num10);
				num88 = Math.Cos(num10);
				num45 = num80 * num87;
				num89 = num84 * num88;
				num90 = num80 * num88;
				num91 = num84 * num87;
				num92 = (num86 - num89 + num45 - num10) / (1.0 - num90 - num91) + num10;
				num93 = num10;
				num10 = num92;
				i++;
			}
			while (i <= 10 & Math.Abs(num92 - num93) > 1E-06);
			double num94 = num90 + num91;
			double num95 = num45 - num89;
			double num96 = Class244.smethod_1(num80) + Class244.smethod_1(num84);
			num61 = 1.0 - num96;
			double num97 = num76 * num61;
			double num98 = num76 * (1.0 - num94);
			num44 = 1.0 / num98;
			double num99 = num8 * Math.Sqrt(num76) * num95 * num44;
			double num100 = num8 * Math.Sqrt(num97) * num44;
			num10 = num76 * num44;
			double num101 = Math.Sqrt(num61);
			num45 = 1.0 / (1.0 + num101);
			double num102 = num10 * (num88 - num80 + num84 * num95 * num45);
			double num103 = num10 * (num87 - num84 - num80 * num95 * num45);
			double num104 = Class244.smethod_5(ref num103, ref num102);
			double num105 = 2.0 * num103 * num102;
			double num106 = 2.0 * Class244.smethod_1(num102) - 1.0;
			num61 = 1.0 / num97;
			num44 = 0.0005413079 * num61;
			num10 = num44 * num61;
			double num107 = num98 * (1.0 - 1.5 * num10 * num101 * num14) + 0.5 * num44 * num40 * num106;
			double num108 = num104 - 0.25 * num10 * num59 * num105;
			double num109 = num68 + 1.5 * num10 * num12 * num105;
			double num110 = class243_0.double_5 + 1.5 * num10 * num12 * num37 * num106;
			double num111 = num99 - num79 * num44 * num40 * num105;
			double num112 = num100 + num79 * num44 * (num40 * num106 + 1.5 * num14);
			@struct.double_0[0] = -Math.Sin(num109) * Math.Cos(num110);
			@struct.double_0[1] = Math.Cos(num109) * Math.Cos(num110);
			@struct.double_0[2] = Math.Sin(num110);
			struct2.double_0[0] = Math.Cos(num109);
			struct2.double_0[1] = Math.Sin(num109);
			struct2.double_0[2] = 0.0;
			for (i = 0; i < 3; i++)
			{
				struct3.double_0[i] = @struct.double_0[i] * Math.Sin(num108) + struct2.double_0[i] * Math.Cos(num108);
				struct4.double_0[i] = @struct.double_0[i] * Math.Cos(num108) - struct2.double_0[i] * Math.Sin(num108);
			}
			for (i = 0; i < 3; i++)
			{
				struct26_0.double_0[i] = num107 * struct3.double_0[i];
				struct26_1.double_0[i] = num111 * struct3.double_0[i] + num112 * struct4.double_0[i];
			}
		}

		// Token: 0x06006359 RID: 25433 RVA: 0x00312FAC File Offset: 0x003111AC
		public static void smethod_1(ref double double_0, ref Class242.Struct26 struct26_0, ref Class242.Struct26 struct26_1, ref Class242.Class243 class243_0)
		{
			Class242.Struct26 @struct;
			@struct.double_0 = new double[4];
			Class242.Struct26 struct2;
			struct2.double_0 = new double[4];
			Class242.Struct26 struct3;
			struct3.double_0 = new double[4];
			Class242.Struct26 struct4;
			struct4.double_0 = new double[4];
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 1.0122292801892716;
			double num4 = Math.Sqrt(1434962880.0 / Class244.smethod_0(6378.135));
			double num5 = Class244.smethod_1(Class244.smethod_1(0.0065849970249924894));
			double num6 = num4 / class243_0.double_2;
			double num7 = Math.Pow(num6, 0.66666666666666663);
			double num8 = Math.Cos(class243_0.double_5);
			double num9 = Class244.smethod_1(num8);
			double num10 = 3.0 * num9 - 1.0;
			double num11 = Class244.smethod_1(class243_0.double_6);
			double num12 = 1.0 - num11;
			double num13 = Math.Sqrt(num12);
			double num14 = 0.00081196185 * num10 / (Class244.smethod_1(num7) * num13 * num12);
			double num15 = num7 * (1.0 - num14 * (0.33333333333333331 + num14 * (1.0 + 1.654320987654321 * num14)));
			double num16 = 0.00081196185 * num10 / (Class244.smethod_1(num15) * num13 * num12);
			double num17 = class243_0.double_2 / (1.0 + num16);
			double num18 = num15 / (1.0 - num16);
			double num19 = num3;
			double num20 = num5;
			double num21 = (num18 * (1.0 - class243_0.double_6) - 1.0) * 6378.135;
			if (num21 < 156.0)
			{
				num19 = num21 - 78.0;
				if (num21 <= 98.0)
				{
					num19 = 20.0;
				}
				num20 = Math.Pow((120.0 - num19) * 1.0 / 6378.135, 4.0);
				num19 = num19 / 6378.135 + 1.0;
			}
			double num22 = 1.0 / (Class244.smethod_1(num18) * Class244.smethod_1(num12));
			double double_ = Math.Sin(class243_0.double_8);
			double double_2 = Math.Cos(class243_0.double_8);
			double num23 = 1.0 / (num18 - num19);
			double num24 = num18 * class243_0.double_6 * num23;
			double num25 = Class244.smethod_1(num24);
			double num26 = class243_0.double_6 * num24;
			double num27 = Math.Abs(1.0 - num25);
			double num28 = num20 * Math.Pow(num23, 4.0) / Math.Pow(num27, 3.5);
			double num29 = num28 * num17 * (num18 * (1.0 + 1.5 * num25 + num26 * (4.0 + num25)) + 0.000405980925 * num23 / num27 * num10 * (8.0 + 3.0 * num25 * (8.0 + num25)));
			double num30 = class243_0.double_4 * num29;
			double num31 = Math.Sin(class243_0.double_5);
			double num32 = 0.0046901403064688327 * Math.Pow(1.0, 3.0);
			double num33 = 1.0 - num9;
			double num34 = 2.0 * num17 * num28 * num18 * num12 * (num24 * (2.0 + 0.5 * num25) + class243_0.double_6 * (0.5 + 2.0 * num25) - 0.0010826158 * num23 / (num18 * num27) * (-3.0 * num10 * (1.0 - 2.0 * num26 + num25 * (1.5 - 0.5 * num26)) + 0.75 * num33 * (2.0 * num25 - num26 * (1.0 + num25)) * Math.Cos(2.0 * class243_0.double_8)));
			double num35 = Class244.smethod_1(num9);
			double num36 = 0.0016239237 * num22 * num17;
			num6 = num36 * 0.0005413079 * num22;
			double num37 = 7.7623593749999984E-07 * num22 * num22 * num17;
			double num38 = num17 + 0.5 * num36 * num13 * num10 + 0.0625 * num6 * num13 * (13.0 - 78.0 * num9 + 137.0 * num35);
			double num39 = 1.0 - 5.0 * num9;
			double num40 = -0.5 * num36 * num39 + 0.0625 * num6 * (7.0 - 114.0 * num9 + 395.0 * num35) + num37 * (3.0 - 36.0 * num9 + 49.0 * num35);
			double num41 = -num36 * num8;
			double num42 = num41 + (0.5 * num6 * (4.0 - 19.0 * num9) + 2.0 * num37 * (3.0 - 7.0 * num9)) * num8;
			double num43 = 3.5 * num12 * num41 * num30;
			double num44 = 1.5 * num30;
			double num45 = 0.125 * num32 * num31 * (3.0 + 5.0 * num8) / (1.0 + num8);
			double num46 = 0.25 * num32 * num31;
			double num47 = 7.0 * num9 - 1.0;
			Class242.Struct27 struct5;
			struct5.double_0 = num11;
			struct5.double_1 = num31;
			struct5.double_2 = num8;
			struct5.double_3 = num13;
			struct5.double_4 = num18;
			struct5.double_5 = num9;
			struct5.double_6 = double_;
			struct5.double_7 = double_2;
			struct5.double_8 = num12;
			struct5.double_9 = num38;
			struct5.double_10 = num40;
			struct5.double_11 = num42;
			struct5.double_12 = num17;
			Class239.smethod_0(ref struct5, ref class243_0);
			num11 = struct5.double_0;
			num31 = struct5.double_1;
			num8 = struct5.double_2;
			num13 = struct5.double_3;
			num18 = struct5.double_4;
			num9 = struct5.double_5;
			double_ = struct5.double_6;
			double_2 = struct5.double_7;
			num12 = struct5.double_8;
			num38 = struct5.double_9;
			num40 = struct5.double_10;
			num42 = struct5.double_11;
			num17 = struct5.double_12;
			double num48 = class243_0.double_7 + num38 * double_0;
			double num49 = class243_0.double_8 + num40 * double_0;
			double num50 = class243_0.double_9 + num42 * double_0;
			double num51 = Class244.smethod_1(double_0);
			double num52 = num50 + num43 * num51;
			double double_3 = 1.0 - num30 * double_0;
			double num53 = class243_0.double_4 * num34 * double_0;
			double num54 = num44 * num51;
			double num55 = num17;
			Class242.Struct28 struct6;
			struct6.double_0 = num48;
			struct6.double_1 = num49;
			struct6.double_2 = num52;
			struct6.double_3 = num;
			struct6.double_4 = num2;
			struct6.double_5 = num55;
			struct6.double_6 = double_0;
			Class239.smethod_1(ref struct6, ref class243_0);
			num48 = struct6.double_0;
			num49 = struct6.double_1;
			num52 = struct6.double_2;
			num = struct6.double_3;
			num2 = struct6.double_4;
			num55 = struct6.double_5;
			double_0 = struct6.double_6;
			double num56 = Math.Pow(num4 / num55, 0.66666666666666663) * Class244.smethod_1(double_3);
			double num57 = num - num53;
			double num58 = num48 + num17 * num54;
			Class242.Struct29 struct7;
			struct7.double_0 = num57;
			struct7.double_1 = num2;
			struct7.double_2 = num49;
			struct7.double_3 = num52;
			struct7.double_4 = num58;
			Class239.smethod_2(ref struct7, ref class243_0);
			num57 = struct7.double_0;
			num2 = struct7.double_1;
			num49 = struct7.double_2;
			num52 = struct7.double_3;
			num58 = struct7.double_4;
			double num59 = num58 + num49 + num52;
			double double_4 = Math.Sqrt(1.0 - Class244.smethod_1(num57));
			num55 = num4 / Math.Pow(num56, 1.5);
			double num60 = num57 * Math.Cos(num49);
			double num61 = 1.0 / (num56 * Class244.smethod_1(double_4));
			double num62 = num61 * num45 * num60;
			double num63 = num61 * num46;
			double num64 = num59 + num62;
			double num65 = num57 * Math.Sin(num49) + num63;
			double num66 = num64 - num52;
			double num67 = Class244.smethod_3(ref num66);
			num6 = num67;
			int i = 1;
			double num68;
			double num69;
			double num70;
			double num71;
			double num72;
			double num73;
			double num74;
			do
			{
				num68 = Math.Sin(num6);
				num69 = Math.Cos(num6);
				num37 = num60 * num68;
				num70 = num65 * num69;
				num71 = num60 * num69;
				num72 = num65 * num68;
				num73 = (num67 - num70 + num37 - num6) / (1.0 - num71 - num72) + num6;
				num74 = num6;
				num6 = num73;
				i++;
			}
			while (i <= 10 & Math.Abs(num73 - num74) > 1E-06);
			double num75 = num71 + num72;
			double num76 = num37 - num70;
			double num77 = Class244.smethod_1(num60) + Class244.smethod_1(num65);
			num61 = 1.0 - num77;
			double num78 = num56 * num61;
			double num79 = num56 * (1.0 - num75);
			num36 = 1.0 / num79;
			double num80 = num4 * Math.Sqrt(num56) * num76 * num36;
			double num81 = num4 * Math.Sqrt(num78) * num36;
			num6 = num56 * num36;
			double num82 = Math.Sqrt(num61);
			num37 = 1.0 / (1.0 + num82);
			double num83 = num6 * (num69 - num60 + num65 * num76 * num37);
			double num84 = num6 * (num68 - num65 - num60 * num76 * num37);
			double num85 = Class244.smethod_5(ref num84, ref num83);
			double num86 = 2.0 * num84 * num83;
			double num87 = 2.0 * Class244.smethod_1(num83) - 1.0;
			num61 = 1.0 / num78;
			num36 = 0.0005413079 * num61;
			num6 = num36 * num61;
			double num88 = num79 * (1.0 - 1.5 * num6 * num82 * num10) + 0.5 * num36 * num33 * num87;
			double num89 = num85 - 0.25 * num6 * num47 * num86;
			double num90 = num52 + 1.5 * num6 * num8 * num86;
			double num91 = num2 + 1.5 * num6 * num8 * num31 * num87;
			double num92 = num80 - num55 * num36 * num33 * num86;
			double num93 = num81 + num55 * num36 * (num33 * num87 + 1.5 * num10);
			@struct.double_0[0] = -Math.Sin(num90) * Math.Cos(num91);
			@struct.double_0[1] = Math.Cos(num90) * Math.Cos(num91);
			@struct.double_0[2] = Math.Sin(num91);
			struct2.double_0[0] = Math.Cos(num90);
			struct2.double_0[1] = Math.Sin(num90);
			struct2.double_0[2] = 0.0;
			for (i = 0; i < 3; i++)
			{
				struct3.double_0[i] = @struct.double_0[i] * Math.Sin(num89) + struct2.double_0[i] * Math.Cos(num89);
				struct4.double_0[i] = @struct.double_0[i] * Math.Cos(num89) - struct2.double_0[i] * Math.Sin(num89);
			}
			for (i = 0; i < 3; i++)
			{
				struct26_0.double_0[i] = num88 * struct3.double_0[i];
				struct26_1.double_0[i] = num92 * struct3.double_0[i] + num93 * struct4.double_0[i];
			}
		}

		// Token: 0x0600635A RID: 25434 RVA: 0x00313C98 File Offset: 0x00311E98
		public static void smethod_2(double double_0, ref Class242.Struct26 struct26_0, ref Class242.Struct26 struct26_1, Class242.Class243 class243_0)
		{
			double double_ = (double_0 - class243_0.double_1) * 1440.0;
			if (class243_0.int_0 == 0)
			{
				Class237.smethod_0(double_, ref struct26_0, ref struct26_1, class243_0);
			}
			else
			{
				Class237.smethod_1(ref double_, ref struct26_0, ref struct26_1, ref class243_0);
			}
		}
	}
}
