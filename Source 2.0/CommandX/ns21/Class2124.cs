using System;
using System.Collections;
using System.Xml;
using ns16;
using ns22;

namespace ns21
{
	// Token: 0x02000102 RID: 258
	public sealed class Class2124 : Class2059
	{
		// Token: 0x0600058D RID: 1421 RVA: 0x00067D1C File Offset: 0x00065F1C
		public Class2124()
		{
			this.method_50();
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00067E40 File Offset: 0x00066040
		public Class2124(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_50();
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00067F64 File Offset: 0x00066164
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "queryable");
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00067F84 File Offset: 0x00066184
		public Class2009 method_3(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "queryable", int_0)));
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00067FB0 File Offset: 0x000661B0
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "cascaded");
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00067FD0 File Offset: 0x000661D0
		public Class2018 method_5(int int_0)
		{
			return new Class2018(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "cascaded", int_0)));
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00067FFC File Offset: 0x000661FC
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "opaque");
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0006801C File Offset: 0x0006621C
		public Class2009 method_7(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "opaque", int_0)));
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00068048 File Offset: 0x00066248
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "noSubsets");
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00068068 File Offset: 0x00066268
		public Class2009 method_9(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "noSubsets", int_0)));
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00068094 File Offset: 0x00066294
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "fixedWidth");
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000680B4 File Offset: 0x000662B4
		public Class2018 method_11(int int_0)
		{
			return new Class2018(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "fixedWidth", int_0)));
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000680E0 File Offset: 0x000662E0
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "fixedHeight");
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00068100 File Offset: 0x00066300
		public Class2018 method_13(int int_0)
		{
			return new Class2018(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "fixedHeight", int_0)));
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0006812C File Offset: 0x0006632C
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Name");
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0006814C File Offset: 0x0006634C
		public Class2050 method_15(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Name", int_0)));
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0005B2A4 File Offset: 0x000594A4
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Title");
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0005B2C4 File Offset: 0x000594C4
		public Class2050 method_17(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Title", int_0)));
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00068178 File Offset: 0x00066378
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Abstract");
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00068198 File Offset: 0x00066398
		public Class2050 method_19(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Abstract", int_0)));
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000681C4 File Offset: 0x000663C4
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "KeywordList");
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x000681E4 File Offset: 0x000663E4
		public Class2122 method_21(int int_0)
		{
			return new Class2122(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "KeywordList", int_0));
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0006820C File Offset: 0x0006640C
		public int method_22()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "CRS");
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0006822C File Offset: 0x0006642C
		public Class2050 method_23(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "CRS", int_0)));
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00068258 File Offset: 0x00066458
		public int method_24()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "EX_GeographicBoundingBox");
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00068278 File Offset: 0x00066478
		public Class2117 method_25(int int_0)
		{
			return new Class2117(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "EX_GeographicBoundingBox", int_0));
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000682A0 File Offset: 0x000664A0
		public int method_26()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "BoundingBox");
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x000682C0 File Offset: 0x000664C0
		public Class2108 method_27(int int_0)
		{
			return new Class2108(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "BoundingBox", int_0));
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x000682E8 File Offset: 0x000664E8
		public int method_28()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Dimension");
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00068308 File Offset: 0x00066508
		public Class2115 method_29(int int_0)
		{
			return new Class2115(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Dimension", int_0));
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00068330 File Offset: 0x00066530
		public int method_30()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Attribution");
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00068350 File Offset: 0x00066550
		public Class2106 method_31(int int_0)
		{
			return new Class2106(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Attribution", int_0));
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00068378 File Offset: 0x00066578
		public int method_32()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "AuthorityURL");
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00068398 File Offset: 0x00066598
		public Class2107 method_33(int int_0)
		{
			return new Class2107(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "AuthorityURL", int_0));
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x000683C0 File Offset: 0x000665C0
		public int method_34()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Identifier");
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000683E0 File Offset: 0x000665E0
		public Class2121 method_35(int int_0)
		{
			return new Class2121(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Identifier", int_0));
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00068408 File Offset: 0x00066608
		public int method_36()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "MetadataURL");
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00068428 File Offset: 0x00066628
		public Class2127 method_37(int int_0)
		{
			return new Class2127(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "MetadataURL", int_0));
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00068450 File Offset: 0x00066650
		public int method_38()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "DataURL");
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00068470 File Offset: 0x00066670
		public Class2113 method_39(int int_0)
		{
			return new Class2113(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "DataURL", int_0));
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00068498 File Offset: 0x00066698
		public int method_40()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "FeatureListURL");
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000684B8 File Offset: 0x000666B8
		public Class2118 method_41(int int_0)
		{
			return new Class2118(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "FeatureListURL", int_0));
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000684E0 File Offset: 0x000666E0
		public int method_42()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Style");
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00068500 File Offset: 0x00066700
		public Class2134 method_43(int int_0)
		{
			return new Class2134(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Style", int_0));
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00068528 File Offset: 0x00066728
		public int method_44()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "MinScaleDenominator");
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00068548 File Offset: 0x00066748
		public Class2020 method_45(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "MinScaleDenominator", int_0)));
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00068574 File Offset: 0x00066774
		public int method_46()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "MaxScaleDenominator");
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00068594 File Offset: 0x00066794
		public Class2020 method_47(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "MaxScaleDenominator", int_0)));
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0005D4BC File Offset: 0x0005B6BC
		public int method_48()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Layer");
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0005D4DC File Offset: 0x0005B6DC
		public Class2124 method_49(int int_0)
		{
			return new Class2124(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Layer", int_0));
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000685C0 File Offset: 0x000667C0
		private void method_50()
		{
			this.class1513_0.method_0(this);
			this.class1515_0.method_0(this);
			this.class1517_0.method_0(this);
			this.class1519_0.method_0(this);
			this.class1521_0.method_0(this);
			this.class1523_0.method_0(this);
			this.class1525_0.method_0(this);
			this.class1527_0.method_0(this);
			this.class1529_0.method_0(this);
			this.class1531_0.method_0(this);
			this.class1533_0.method_0(this);
			this.class1535_0.method_0(this);
			this.class1537_0.method_0(this);
			this.class1539_0.method_0(this);
			this.class1541_0.method_0(this);
			this.class1543_0.method_0(this);
			this.class1545_0.method_0(this);
			this.class1547_0.method_0(this);
			this.class1549_0.method_0(this);
			this.class1551_0.method_0(this);
			this.class1553_0.method_0(this);
			this.class1555_0.method_0(this);
			this.class1557_0.method_0(this);
			this.class1559_0.method_0(this);
		}

		// Token: 0x040002A6 RID: 678
		public Class2124.Class1513 class1513_0 = new Class2124.Class1513();

		// Token: 0x040002A7 RID: 679
		public Class2124.Class1515 class1515_0 = new Class2124.Class1515();

		// Token: 0x040002A8 RID: 680
		public Class2124.Class1517 class1517_0 = new Class2124.Class1517();

		// Token: 0x040002A9 RID: 681
		public Class2124.Class1519 class1519_0 = new Class2124.Class1519();

		// Token: 0x040002AA RID: 682
		public Class2124.Class1521 class1521_0 = new Class2124.Class1521();

		// Token: 0x040002AB RID: 683
		public Class2124.Class1523 class1523_0 = new Class2124.Class1523();

		// Token: 0x040002AC RID: 684
		public Class2124.Class1525 class1525_0 = new Class2124.Class1525();

		// Token: 0x040002AD RID: 685
		public Class2124.Class1527 class1527_0 = new Class2124.Class1527();

		// Token: 0x040002AE RID: 686
		public Class2124.Class1529 class1529_0 = new Class2124.Class1529();

		// Token: 0x040002AF RID: 687
		public Class2124.Class1531 class1531_0 = new Class2124.Class1531();

		// Token: 0x040002B0 RID: 688
		public Class2124.Class1533 class1533_0 = new Class2124.Class1533();

		// Token: 0x040002B1 RID: 689
		public Class2124.Class1535 class1535_0 = new Class2124.Class1535();

		// Token: 0x040002B2 RID: 690
		public Class2124.Class1537 class1537_0 = new Class2124.Class1537();

		// Token: 0x040002B3 RID: 691
		public Class2124.Class1539 class1539_0 = new Class2124.Class1539();

		// Token: 0x040002B4 RID: 692
		public Class2124.Class1541 class1541_0 = new Class2124.Class1541();

		// Token: 0x040002B5 RID: 693
		public Class2124.Class1543 class1543_0 = new Class2124.Class1543();

		// Token: 0x040002B6 RID: 694
		public Class2124.Class1545 class1545_0 = new Class2124.Class1545();

		// Token: 0x040002B7 RID: 695
		public Class2124.Class1547 class1547_0 = new Class2124.Class1547();

		// Token: 0x040002B8 RID: 696
		public Class2124.Class1549 class1549_0 = new Class2124.Class1549();

		// Token: 0x040002B9 RID: 697
		public Class2124.Class1551 class1551_0 = new Class2124.Class1551();

		// Token: 0x040002BA RID: 698
		public Class2124.Class1553 class1553_0 = new Class2124.Class1553();

		// Token: 0x040002BB RID: 699
		public Class2124.Class1555 class1555_0 = new Class2124.Class1555();

		// Token: 0x040002BC RID: 700
		public Class2124.Class1557 class1557_0 = new Class2124.Class1557();

		// Token: 0x040002BD RID: 701
		public Class2124.Class1559 class1559_0 = new Class2124.Class1559();

		// Token: 0x02000103 RID: 259
		public sealed class Class1513 : IEnumerable
		{
			// Token: 0x060005C0 RID: 1472 RVA: 0x0000714D File Offset: 0x0000534D
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x060005C1 RID: 1473 RVA: 0x000686F0 File Offset: 0x000668F0
			public Class2124.Class1514 method_1()
			{
				return new Class2124.Class1514(this.class2124_0);
			}

			// Token: 0x060005C2 RID: 1474 RVA: 0x0006870C File Offset: 0x0006690C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002BE RID: 702
			private Class2124 class2124_0;
		}

		// Token: 0x02000104 RID: 260
		public sealed class Class1514 : IEnumerator
		{
			// Token: 0x1700007F RID: 127
			// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00068724 File Offset: 0x00066924
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060005C5 RID: 1477 RVA: 0x00007156 File Offset: 0x00005356
			public Class1514(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x060005C6 RID: 1478 RVA: 0x0000716C File Offset: 0x0000536C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060005C7 RID: 1479 RVA: 0x00007175 File Offset: 0x00005375
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_2();
			}

			// Token: 0x060005C8 RID: 1480 RVA: 0x0006873C File Offset: 0x0006693C
			public Class2009 method_0()
			{
				return this.class2124_0.method_3(this.int_0);
			}

			// Token: 0x040002BF RID: 703
			private int int_0;

			// Token: 0x040002C0 RID: 704
			private Class2124 class2124_0;
		}

		// Token: 0x02000105 RID: 261
		public sealed class Class1515 : IEnumerable
		{
			// Token: 0x060005C9 RID: 1481 RVA: 0x00007198 File Offset: 0x00005398
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x060005CA RID: 1482 RVA: 0x0006875C File Offset: 0x0006695C
			public Class2124.Class1516 method_1()
			{
				return new Class2124.Class1516(this.class2124_0);
			}

			// Token: 0x060005CB RID: 1483 RVA: 0x00068778 File Offset: 0x00066978
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002C1 RID: 705
			private Class2124 class2124_0;
		}

		// Token: 0x02000106 RID: 262
		public sealed class Class1516 : IEnumerator
		{
			// Token: 0x17000080 RID: 128
			// (get) Token: 0x060005CD RID: 1485 RVA: 0x00068790 File Offset: 0x00066990
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060005CE RID: 1486 RVA: 0x000071A1 File Offset: 0x000053A1
			public Class1516(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x060005CF RID: 1487 RVA: 0x000071B7 File Offset: 0x000053B7
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060005D0 RID: 1488 RVA: 0x000071C0 File Offset: 0x000053C0
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_4();
			}

			// Token: 0x060005D1 RID: 1489 RVA: 0x000687A8 File Offset: 0x000669A8
			public Class2018 method_0()
			{
				return this.class2124_0.method_5(this.int_0);
			}

			// Token: 0x040002C2 RID: 706
			private int int_0;

			// Token: 0x040002C3 RID: 707
			private Class2124 class2124_0;
		}

		// Token: 0x02000107 RID: 263
		public sealed class Class1517 : IEnumerable
		{
			// Token: 0x060005D2 RID: 1490 RVA: 0x000071E3 File Offset: 0x000053E3
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x060005D3 RID: 1491 RVA: 0x000687C8 File Offset: 0x000669C8
			public Class2124.Class1518 method_1()
			{
				return new Class2124.Class1518(this.class2124_0);
			}

			// Token: 0x060005D4 RID: 1492 RVA: 0x000687E4 File Offset: 0x000669E4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002C4 RID: 708
			private Class2124 class2124_0;
		}

		// Token: 0x02000108 RID: 264
		public sealed class Class1518 : IEnumerator
		{
			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060005D6 RID: 1494 RVA: 0x000687FC File Offset: 0x000669FC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060005D7 RID: 1495 RVA: 0x000071EC File Offset: 0x000053EC
			public Class1518(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x060005D8 RID: 1496 RVA: 0x00007202 File Offset: 0x00005402
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060005D9 RID: 1497 RVA: 0x0000720B File Offset: 0x0000540B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_6();
			}

			// Token: 0x060005DA RID: 1498 RVA: 0x00068814 File Offset: 0x00066A14
			public Class2009 method_0()
			{
				return this.class2124_0.method_7(this.int_0);
			}

			// Token: 0x040002C5 RID: 709
			private int int_0;

			// Token: 0x040002C6 RID: 710
			private Class2124 class2124_0;
		}

		// Token: 0x02000109 RID: 265
		public sealed class Class1519 : IEnumerable
		{
			// Token: 0x060005DB RID: 1499 RVA: 0x0000722E File Offset: 0x0000542E
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x060005DC RID: 1500 RVA: 0x00068834 File Offset: 0x00066A34
			public Class2124.Class1520 method_1()
			{
				return new Class2124.Class1520(this.class2124_0);
			}

			// Token: 0x060005DD RID: 1501 RVA: 0x00068850 File Offset: 0x00066A50
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002C7 RID: 711
			private Class2124 class2124_0;
		}

		// Token: 0x0200010A RID: 266
		public sealed class Class1520 : IEnumerator
		{
			// Token: 0x17000082 RID: 130
			// (get) Token: 0x060005DF RID: 1503 RVA: 0x00068868 File Offset: 0x00066A68
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060005E0 RID: 1504 RVA: 0x00007237 File Offset: 0x00005437
			public Class1520(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x060005E1 RID: 1505 RVA: 0x0000724D File Offset: 0x0000544D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060005E2 RID: 1506 RVA: 0x00007256 File Offset: 0x00005456
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_8();
			}

			// Token: 0x060005E3 RID: 1507 RVA: 0x00068880 File Offset: 0x00066A80
			public Class2009 method_0()
			{
				return this.class2124_0.method_9(this.int_0);
			}

			// Token: 0x040002C8 RID: 712
			private int int_0;

			// Token: 0x040002C9 RID: 713
			private Class2124 class2124_0;
		}

		// Token: 0x0200010B RID: 267
		public sealed class Class1521 : IEnumerable
		{
			// Token: 0x060005E4 RID: 1508 RVA: 0x00007279 File Offset: 0x00005479
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x060005E5 RID: 1509 RVA: 0x000688A0 File Offset: 0x00066AA0
			public Class2124.Class1522 method_1()
			{
				return new Class2124.Class1522(this.class2124_0);
			}

			// Token: 0x060005E6 RID: 1510 RVA: 0x000688BC File Offset: 0x00066ABC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002CA RID: 714
			private Class2124 class2124_0;
		}

		// Token: 0x0200010C RID: 268
		public sealed class Class1522 : IEnumerator
		{
			// Token: 0x17000083 RID: 131
			// (get) Token: 0x060005E8 RID: 1512 RVA: 0x000688D4 File Offset: 0x00066AD4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060005E9 RID: 1513 RVA: 0x00007282 File Offset: 0x00005482
			public Class1522(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x060005EA RID: 1514 RVA: 0x00007298 File Offset: 0x00005498
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060005EB RID: 1515 RVA: 0x000072A1 File Offset: 0x000054A1
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_10();
			}

			// Token: 0x060005EC RID: 1516 RVA: 0x000688EC File Offset: 0x00066AEC
			public Class2018 method_0()
			{
				return this.class2124_0.method_11(this.int_0);
			}

			// Token: 0x040002CB RID: 715
			private int int_0;

			// Token: 0x040002CC RID: 716
			private Class2124 class2124_0;
		}

		// Token: 0x0200010D RID: 269
		public sealed class Class1523 : IEnumerable
		{
			// Token: 0x060005ED RID: 1517 RVA: 0x000072C4 File Offset: 0x000054C4
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x060005EE RID: 1518 RVA: 0x0006890C File Offset: 0x00066B0C
			public Class2124.Class1524 method_1()
			{
				return new Class2124.Class1524(this.class2124_0);
			}

			// Token: 0x060005EF RID: 1519 RVA: 0x00068928 File Offset: 0x00066B28
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002CD RID: 717
			private Class2124 class2124_0;
		}

		// Token: 0x0200010E RID: 270
		public sealed class Class1524 : IEnumerator
		{
			// Token: 0x17000084 RID: 132
			// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00068940 File Offset: 0x00066B40
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060005F2 RID: 1522 RVA: 0x000072CD File Offset: 0x000054CD
			public Class1524(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x060005F3 RID: 1523 RVA: 0x000072E3 File Offset: 0x000054E3
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060005F4 RID: 1524 RVA: 0x000072EC File Offset: 0x000054EC
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_12();
			}

			// Token: 0x060005F5 RID: 1525 RVA: 0x00068958 File Offset: 0x00066B58
			public Class2018 method_0()
			{
				return this.class2124_0.method_13(this.int_0);
			}

			// Token: 0x040002CE RID: 718
			private int int_0;

			// Token: 0x040002CF RID: 719
			private Class2124 class2124_0;
		}

		// Token: 0x0200010F RID: 271
		public sealed class Class1525 : IEnumerable
		{
			// Token: 0x060005F6 RID: 1526 RVA: 0x0000730F File Offset: 0x0000550F
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x060005F7 RID: 1527 RVA: 0x00068978 File Offset: 0x00066B78
			public Class2124.Class1526 method_1()
			{
				return new Class2124.Class1526(this.class2124_0);
			}

			// Token: 0x060005F8 RID: 1528 RVA: 0x00068994 File Offset: 0x00066B94
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002D0 RID: 720
			private Class2124 class2124_0;
		}

		// Token: 0x02000110 RID: 272
		public sealed class Class1526 : IEnumerator
		{
			// Token: 0x17000085 RID: 133
			// (get) Token: 0x060005FA RID: 1530 RVA: 0x000689AC File Offset: 0x00066BAC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060005FB RID: 1531 RVA: 0x00007318 File Offset: 0x00005518
			public Class1526(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x060005FC RID: 1532 RVA: 0x0000732E File Offset: 0x0000552E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060005FD RID: 1533 RVA: 0x00007337 File Offset: 0x00005537
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_14();
			}

			// Token: 0x060005FE RID: 1534 RVA: 0x000689C4 File Offset: 0x00066BC4
			public Class2050 method_0()
			{
				return this.class2124_0.method_15(this.int_0);
			}

			// Token: 0x040002D1 RID: 721
			private int int_0;

			// Token: 0x040002D2 RID: 722
			private Class2124 class2124_0;
		}

		// Token: 0x02000111 RID: 273
		public sealed class Class1527 : IEnumerable
		{
			// Token: 0x060005FF RID: 1535 RVA: 0x0000735A File Offset: 0x0000555A
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x06000600 RID: 1536 RVA: 0x000689E4 File Offset: 0x00066BE4
			public Class2124.Class1528 method_1()
			{
				return new Class2124.Class1528(this.class2124_0);
			}

			// Token: 0x06000601 RID: 1537 RVA: 0x00068A00 File Offset: 0x00066C00
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002D3 RID: 723
			private Class2124 class2124_0;
		}

		// Token: 0x02000112 RID: 274
		public sealed class Class1528 : IEnumerator
		{
			// Token: 0x17000086 RID: 134
			// (get) Token: 0x06000603 RID: 1539 RVA: 0x00068A18 File Offset: 0x00066C18
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000604 RID: 1540 RVA: 0x00007363 File Offset: 0x00005563
			public Class1528(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x06000605 RID: 1541 RVA: 0x00007379 File Offset: 0x00005579
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000606 RID: 1542 RVA: 0x00007382 File Offset: 0x00005582
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_16();
			}

			// Token: 0x06000607 RID: 1543 RVA: 0x00068A30 File Offset: 0x00066C30
			public Class2050 method_0()
			{
				return this.class2124_0.method_17(this.int_0);
			}

			// Token: 0x040002D4 RID: 724
			private int int_0;

			// Token: 0x040002D5 RID: 725
			private Class2124 class2124_0;
		}

		// Token: 0x02000113 RID: 275
		public sealed class Class1529 : IEnumerable
		{
			// Token: 0x06000608 RID: 1544 RVA: 0x000073A5 File Offset: 0x000055A5
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x06000609 RID: 1545 RVA: 0x00068A50 File Offset: 0x00066C50
			public Class2124.Class1530 method_1()
			{
				return new Class2124.Class1530(this.class2124_0);
			}

			// Token: 0x0600060A RID: 1546 RVA: 0x00068A6C File Offset: 0x00066C6C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002D6 RID: 726
			private Class2124 class2124_0;
		}

		// Token: 0x02000114 RID: 276
		public sealed class Class1530 : IEnumerator
		{
			// Token: 0x17000087 RID: 135
			// (get) Token: 0x0600060C RID: 1548 RVA: 0x00068A84 File Offset: 0x00066C84
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600060D RID: 1549 RVA: 0x000073AE File Offset: 0x000055AE
			public Class1530(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x0600060E RID: 1550 RVA: 0x000073C4 File Offset: 0x000055C4
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600060F RID: 1551 RVA: 0x000073CD File Offset: 0x000055CD
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_18();
			}

			// Token: 0x06000610 RID: 1552 RVA: 0x00068A9C File Offset: 0x00066C9C
			public Class2050 method_0()
			{
				return this.class2124_0.method_19(this.int_0);
			}

			// Token: 0x040002D7 RID: 727
			private int int_0;

			// Token: 0x040002D8 RID: 728
			private Class2124 class2124_0;
		}

		// Token: 0x02000115 RID: 277
		public sealed class Class1531 : IEnumerable
		{
			// Token: 0x06000611 RID: 1553 RVA: 0x000073F0 File Offset: 0x000055F0
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x06000612 RID: 1554 RVA: 0x00068ABC File Offset: 0x00066CBC
			public Class2124.Class1532 method_1()
			{
				return new Class2124.Class1532(this.class2124_0);
			}

			// Token: 0x06000613 RID: 1555 RVA: 0x00068AD8 File Offset: 0x00066CD8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002D9 RID: 729
			private Class2124 class2124_0;
		}

		// Token: 0x02000116 RID: 278
		public sealed class Class1532 : IEnumerator
		{
			// Token: 0x17000088 RID: 136
			// (get) Token: 0x06000615 RID: 1557 RVA: 0x00068AF0 File Offset: 0x00066CF0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000616 RID: 1558 RVA: 0x000073F9 File Offset: 0x000055F9
			public Class1532(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x06000617 RID: 1559 RVA: 0x0000740F File Offset: 0x0000560F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000618 RID: 1560 RVA: 0x00007418 File Offset: 0x00005618
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_20();
			}

			// Token: 0x06000619 RID: 1561 RVA: 0x00068B08 File Offset: 0x00066D08
			public Class2122 method_0()
			{
				return this.class2124_0.method_21(this.int_0);
			}

			// Token: 0x040002DA RID: 730
			private int int_0;

			// Token: 0x040002DB RID: 731
			private Class2124 class2124_0;
		}

		// Token: 0x02000117 RID: 279
		public sealed class Class1533 : IEnumerable
		{
			// Token: 0x0600061A RID: 1562 RVA: 0x0000743B File Offset: 0x0000563B
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x0600061B RID: 1563 RVA: 0x00068B28 File Offset: 0x00066D28
			public Class2124.Class1534 method_1()
			{
				return new Class2124.Class1534(this.class2124_0);
			}

			// Token: 0x0600061C RID: 1564 RVA: 0x00068B44 File Offset: 0x00066D44
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002DC RID: 732
			private Class2124 class2124_0;
		}

		// Token: 0x02000118 RID: 280
		public sealed class Class1534 : IEnumerator
		{
			// Token: 0x17000089 RID: 137
			// (get) Token: 0x0600061E RID: 1566 RVA: 0x00068B5C File Offset: 0x00066D5C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600061F RID: 1567 RVA: 0x00007444 File Offset: 0x00005644
			public Class1534(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x06000620 RID: 1568 RVA: 0x0000745A File Offset: 0x0000565A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000621 RID: 1569 RVA: 0x00007463 File Offset: 0x00005663
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_22();
			}

			// Token: 0x06000622 RID: 1570 RVA: 0x00068B74 File Offset: 0x00066D74
			public Class2050 method_0()
			{
				return this.class2124_0.method_23(this.int_0);
			}

			// Token: 0x040002DD RID: 733
			private int int_0;

			// Token: 0x040002DE RID: 734
			private Class2124 class2124_0;
		}

		// Token: 0x02000119 RID: 281
		public sealed class Class1535 : IEnumerable
		{
			// Token: 0x06000623 RID: 1571 RVA: 0x00007486 File Offset: 0x00005686
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x06000624 RID: 1572 RVA: 0x00068B94 File Offset: 0x00066D94
			public Class2124.Class1536 method_1()
			{
				return new Class2124.Class1536(this.class2124_0);
			}

			// Token: 0x06000625 RID: 1573 RVA: 0x00068BB0 File Offset: 0x00066DB0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002DF RID: 735
			private Class2124 class2124_0;
		}

		// Token: 0x0200011A RID: 282
		public sealed class Class1536 : IEnumerator
		{
			// Token: 0x1700008A RID: 138
			// (get) Token: 0x06000627 RID: 1575 RVA: 0x00068BC8 File Offset: 0x00066DC8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000628 RID: 1576 RVA: 0x0000748F File Offset: 0x0000568F
			public Class1536(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x06000629 RID: 1577 RVA: 0x000074A5 File Offset: 0x000056A5
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600062A RID: 1578 RVA: 0x000074AE File Offset: 0x000056AE
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_24();
			}

			// Token: 0x0600062B RID: 1579 RVA: 0x00068BE0 File Offset: 0x00066DE0
			public Class2117 method_0()
			{
				return this.class2124_0.method_25(this.int_0);
			}

			// Token: 0x040002E0 RID: 736
			private int int_0;

			// Token: 0x040002E1 RID: 737
			private Class2124 class2124_0;
		}

		// Token: 0x0200011B RID: 283
		public sealed class Class1537 : IEnumerable
		{
			// Token: 0x0600062C RID: 1580 RVA: 0x000074D1 File Offset: 0x000056D1
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x0600062D RID: 1581 RVA: 0x00068C00 File Offset: 0x00066E00
			public Class2124.Class1538 method_1()
			{
				return new Class2124.Class1538(this.class2124_0);
			}

			// Token: 0x0600062E RID: 1582 RVA: 0x00068C1C File Offset: 0x00066E1C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002E2 RID: 738
			private Class2124 class2124_0;
		}

		// Token: 0x0200011C RID: 284
		public sealed class Class1538 : IEnumerator
		{
			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000630 RID: 1584 RVA: 0x00068C34 File Offset: 0x00066E34
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000631 RID: 1585 RVA: 0x000074DA File Offset: 0x000056DA
			public Class1538(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x06000632 RID: 1586 RVA: 0x000074F0 File Offset: 0x000056F0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000633 RID: 1587 RVA: 0x000074F9 File Offset: 0x000056F9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_26();
			}

			// Token: 0x06000634 RID: 1588 RVA: 0x00068C4C File Offset: 0x00066E4C
			public Class2108 method_0()
			{
				return this.class2124_0.method_27(this.int_0);
			}

			// Token: 0x040002E3 RID: 739
			private int int_0;

			// Token: 0x040002E4 RID: 740
			private Class2124 class2124_0;
		}

		// Token: 0x0200011D RID: 285
		public sealed class Class1539 : IEnumerable
		{
			// Token: 0x06000635 RID: 1589 RVA: 0x0000751C File Offset: 0x0000571C
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x06000636 RID: 1590 RVA: 0x00068C6C File Offset: 0x00066E6C
			public Class2124.Class1540 method_1()
			{
				return new Class2124.Class1540(this.class2124_0);
			}

			// Token: 0x06000637 RID: 1591 RVA: 0x00068C88 File Offset: 0x00066E88
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002E5 RID: 741
			private Class2124 class2124_0;
		}

		// Token: 0x0200011E RID: 286
		public sealed class Class1540 : IEnumerator
		{
			// Token: 0x1700008C RID: 140
			// (get) Token: 0x06000639 RID: 1593 RVA: 0x00068CA0 File Offset: 0x00066EA0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600063A RID: 1594 RVA: 0x00007525 File Offset: 0x00005725
			public Class1540(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x0600063B RID: 1595 RVA: 0x0000753B File Offset: 0x0000573B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600063C RID: 1596 RVA: 0x00007544 File Offset: 0x00005744
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_28();
			}

			// Token: 0x0600063D RID: 1597 RVA: 0x00068CB8 File Offset: 0x00066EB8
			public Class2115 method_0()
			{
				return this.class2124_0.method_29(this.int_0);
			}

			// Token: 0x040002E6 RID: 742
			private int int_0;

			// Token: 0x040002E7 RID: 743
			private Class2124 class2124_0;
		}

		// Token: 0x0200011F RID: 287
		public sealed class Class1541 : IEnumerable
		{
			// Token: 0x0600063E RID: 1598 RVA: 0x00007567 File Offset: 0x00005767
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x0600063F RID: 1599 RVA: 0x00068CD8 File Offset: 0x00066ED8
			public Class2124.Class1542 method_1()
			{
				return new Class2124.Class1542(this.class2124_0);
			}

			// Token: 0x06000640 RID: 1600 RVA: 0x00068CF4 File Offset: 0x00066EF4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002E8 RID: 744
			private Class2124 class2124_0;
		}

		// Token: 0x02000120 RID: 288
		public sealed class Class1542 : IEnumerator
		{
			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000642 RID: 1602 RVA: 0x00068D0C File Offset: 0x00066F0C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000643 RID: 1603 RVA: 0x00007570 File Offset: 0x00005770
			public Class1542(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x06000644 RID: 1604 RVA: 0x00007586 File Offset: 0x00005786
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000645 RID: 1605 RVA: 0x0000758F File Offset: 0x0000578F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_30();
			}

			// Token: 0x06000646 RID: 1606 RVA: 0x00068D24 File Offset: 0x00066F24
			public Class2106 method_0()
			{
				return this.class2124_0.method_31(this.int_0);
			}

			// Token: 0x040002E9 RID: 745
			private int int_0;

			// Token: 0x040002EA RID: 746
			private Class2124 class2124_0;
		}

		// Token: 0x02000121 RID: 289
		public sealed class Class1543 : IEnumerable
		{
			// Token: 0x06000647 RID: 1607 RVA: 0x000075B2 File Offset: 0x000057B2
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x06000648 RID: 1608 RVA: 0x00068D44 File Offset: 0x00066F44
			public Class2124.Class1544 method_1()
			{
				return new Class2124.Class1544(this.class2124_0);
			}

			// Token: 0x06000649 RID: 1609 RVA: 0x00068D60 File Offset: 0x00066F60
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002EB RID: 747
			private Class2124 class2124_0;
		}

		// Token: 0x02000122 RID: 290
		public sealed class Class1544 : IEnumerator
		{
			// Token: 0x1700008E RID: 142
			// (get) Token: 0x0600064B RID: 1611 RVA: 0x00068D78 File Offset: 0x00066F78
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600064C RID: 1612 RVA: 0x000075BB File Offset: 0x000057BB
			public Class1544(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x0600064D RID: 1613 RVA: 0x000075D1 File Offset: 0x000057D1
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600064E RID: 1614 RVA: 0x000075DA File Offset: 0x000057DA
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_32();
			}

			// Token: 0x0600064F RID: 1615 RVA: 0x00068D90 File Offset: 0x00066F90
			public Class2107 method_0()
			{
				return this.class2124_0.method_33(this.int_0);
			}

			// Token: 0x040002EC RID: 748
			private int int_0;

			// Token: 0x040002ED RID: 749
			private Class2124 class2124_0;
		}

		// Token: 0x02000123 RID: 291
		public sealed class Class1545 : IEnumerable
		{
			// Token: 0x06000650 RID: 1616 RVA: 0x000075FD File Offset: 0x000057FD
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x00068DB0 File Offset: 0x00066FB0
			public Class2124.Class1546 method_1()
			{
				return new Class2124.Class1546(this.class2124_0);
			}

			// Token: 0x06000652 RID: 1618 RVA: 0x00068DCC File Offset: 0x00066FCC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002EE RID: 750
			private Class2124 class2124_0;
		}

		// Token: 0x02000124 RID: 292
		public sealed class Class1546 : IEnumerator
		{
			// Token: 0x1700008F RID: 143
			// (get) Token: 0x06000654 RID: 1620 RVA: 0x00068DE4 File Offset: 0x00066FE4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000655 RID: 1621 RVA: 0x00007606 File Offset: 0x00005806
			public Class1546(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x06000656 RID: 1622 RVA: 0x0000761C File Offset: 0x0000581C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000657 RID: 1623 RVA: 0x00007625 File Offset: 0x00005825
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_34();
			}

			// Token: 0x06000658 RID: 1624 RVA: 0x00068DFC File Offset: 0x00066FFC
			public Class2121 method_0()
			{
				return this.class2124_0.method_35(this.int_0);
			}

			// Token: 0x040002EF RID: 751
			private int int_0;

			// Token: 0x040002F0 RID: 752
			private Class2124 class2124_0;
		}

		// Token: 0x02000125 RID: 293
		public sealed class Class1547 : IEnumerable
		{
			// Token: 0x06000659 RID: 1625 RVA: 0x00007648 File Offset: 0x00005848
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x0600065A RID: 1626 RVA: 0x00068E1C File Offset: 0x0006701C
			public Class2124.Class1548 method_1()
			{
				return new Class2124.Class1548(this.class2124_0);
			}

			// Token: 0x0600065B RID: 1627 RVA: 0x00068E38 File Offset: 0x00067038
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002F1 RID: 753
			private Class2124 class2124_0;
		}

		// Token: 0x02000126 RID: 294
		public sealed class Class1548 : IEnumerator
		{
			// Token: 0x17000090 RID: 144
			// (get) Token: 0x0600065D RID: 1629 RVA: 0x00068E50 File Offset: 0x00067050
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600065E RID: 1630 RVA: 0x00007651 File Offset: 0x00005851
			public Class1548(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x0600065F RID: 1631 RVA: 0x00007667 File Offset: 0x00005867
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000660 RID: 1632 RVA: 0x00007670 File Offset: 0x00005870
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_36();
			}

			// Token: 0x06000661 RID: 1633 RVA: 0x00068E68 File Offset: 0x00067068
			public Class2127 method_0()
			{
				return this.class2124_0.method_37(this.int_0);
			}

			// Token: 0x040002F2 RID: 754
			private int int_0;

			// Token: 0x040002F3 RID: 755
			private Class2124 class2124_0;
		}

		// Token: 0x02000127 RID: 295
		public sealed class Class1549 : IEnumerable
		{
			// Token: 0x06000662 RID: 1634 RVA: 0x00007693 File Offset: 0x00005893
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x06000663 RID: 1635 RVA: 0x00068E88 File Offset: 0x00067088
			public Class2124.Class1550 method_1()
			{
				return new Class2124.Class1550(this.class2124_0);
			}

			// Token: 0x06000664 RID: 1636 RVA: 0x00068EA4 File Offset: 0x000670A4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002F4 RID: 756
			private Class2124 class2124_0;
		}

		// Token: 0x02000128 RID: 296
		public sealed class Class1550 : IEnumerator
		{
			// Token: 0x17000091 RID: 145
			// (get) Token: 0x06000666 RID: 1638 RVA: 0x00068EBC File Offset: 0x000670BC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000667 RID: 1639 RVA: 0x0000769C File Offset: 0x0000589C
			public Class1550(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x06000668 RID: 1640 RVA: 0x000076B2 File Offset: 0x000058B2
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000669 RID: 1641 RVA: 0x000076BB File Offset: 0x000058BB
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_38();
			}

			// Token: 0x0600066A RID: 1642 RVA: 0x00068ED4 File Offset: 0x000670D4
			public Class2113 method_0()
			{
				return this.class2124_0.method_39(this.int_0);
			}

			// Token: 0x040002F5 RID: 757
			private int int_0;

			// Token: 0x040002F6 RID: 758
			private Class2124 class2124_0;
		}

		// Token: 0x02000129 RID: 297
		public sealed class Class1551 : IEnumerable
		{
			// Token: 0x0600066B RID: 1643 RVA: 0x000076DE File Offset: 0x000058DE
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x0600066C RID: 1644 RVA: 0x00068EF4 File Offset: 0x000670F4
			public Class2124.Class1552 method_1()
			{
				return new Class2124.Class1552(this.class2124_0);
			}

			// Token: 0x0600066D RID: 1645 RVA: 0x00068F10 File Offset: 0x00067110
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002F7 RID: 759
			private Class2124 class2124_0;
		}

		// Token: 0x0200012A RID: 298
		public sealed class Class1552 : IEnumerator
		{
			// Token: 0x17000092 RID: 146
			// (get) Token: 0x0600066F RID: 1647 RVA: 0x00068F28 File Offset: 0x00067128
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000670 RID: 1648 RVA: 0x000076E7 File Offset: 0x000058E7
			public Class1552(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x06000671 RID: 1649 RVA: 0x000076FD File Offset: 0x000058FD
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000672 RID: 1650 RVA: 0x00007706 File Offset: 0x00005906
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_40();
			}

			// Token: 0x06000673 RID: 1651 RVA: 0x00068F40 File Offset: 0x00067140
			public Class2118 method_0()
			{
				return this.class2124_0.method_41(this.int_0);
			}

			// Token: 0x040002F8 RID: 760
			private int int_0;

			// Token: 0x040002F9 RID: 761
			private Class2124 class2124_0;
		}

		// Token: 0x0200012B RID: 299
		public sealed class Class1553 : IEnumerable
		{
			// Token: 0x06000674 RID: 1652 RVA: 0x00007729 File Offset: 0x00005929
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x06000675 RID: 1653 RVA: 0x00068F60 File Offset: 0x00067160
			public Class2124.Class1554 method_1()
			{
				return new Class2124.Class1554(this.class2124_0);
			}

			// Token: 0x06000676 RID: 1654 RVA: 0x00068F7C File Offset: 0x0006717C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002FA RID: 762
			private Class2124 class2124_0;
		}

		// Token: 0x0200012C RID: 300
		public sealed class Class1554 : IEnumerator
		{
			// Token: 0x17000093 RID: 147
			// (get) Token: 0x06000678 RID: 1656 RVA: 0x00068F94 File Offset: 0x00067194
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000679 RID: 1657 RVA: 0x00007732 File Offset: 0x00005932
			public Class1554(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x0600067A RID: 1658 RVA: 0x00007748 File Offset: 0x00005948
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600067B RID: 1659 RVA: 0x00007751 File Offset: 0x00005951
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_42();
			}

			// Token: 0x0600067C RID: 1660 RVA: 0x00068FAC File Offset: 0x000671AC
			public Class2134 method_0()
			{
				return this.class2124_0.method_43(this.int_0);
			}

			// Token: 0x040002FB RID: 763
			private int int_0;

			// Token: 0x040002FC RID: 764
			private Class2124 class2124_0;
		}

		// Token: 0x0200012D RID: 301
		public sealed class Class1555 : IEnumerable
		{
			// Token: 0x0600067D RID: 1661 RVA: 0x00007774 File Offset: 0x00005974
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x0600067E RID: 1662 RVA: 0x00068FCC File Offset: 0x000671CC
			public Class2124.Class1556 method_1()
			{
				return new Class2124.Class1556(this.class2124_0);
			}

			// Token: 0x0600067F RID: 1663 RVA: 0x00068FE8 File Offset: 0x000671E8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040002FD RID: 765
			private Class2124 class2124_0;
		}

		// Token: 0x0200012E RID: 302
		public sealed class Class1556 : IEnumerator
		{
			// Token: 0x17000094 RID: 148
			// (get) Token: 0x06000681 RID: 1665 RVA: 0x00069000 File Offset: 0x00067200
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000682 RID: 1666 RVA: 0x0000777D File Offset: 0x0000597D
			public Class1556(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x06000683 RID: 1667 RVA: 0x00007793 File Offset: 0x00005993
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000684 RID: 1668 RVA: 0x0000779C File Offset: 0x0000599C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_44();
			}

			// Token: 0x06000685 RID: 1669 RVA: 0x00069018 File Offset: 0x00067218
			public Class2020 method_0()
			{
				return this.class2124_0.method_45(this.int_0);
			}

			// Token: 0x040002FE RID: 766
			private int int_0;

			// Token: 0x040002FF RID: 767
			private Class2124 class2124_0;
		}

		// Token: 0x0200012F RID: 303
		public sealed class Class1557 : IEnumerable
		{
			// Token: 0x06000686 RID: 1670 RVA: 0x000077BF File Offset: 0x000059BF
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x06000687 RID: 1671 RVA: 0x00069038 File Offset: 0x00067238
			public Class2124.Class1558 method_1()
			{
				return new Class2124.Class1558(this.class2124_0);
			}

			// Token: 0x06000688 RID: 1672 RVA: 0x00069054 File Offset: 0x00067254
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000300 RID: 768
			private Class2124 class2124_0;
		}

		// Token: 0x02000130 RID: 304
		public sealed class Class1558 : IEnumerator
		{
			// Token: 0x17000095 RID: 149
			// (get) Token: 0x0600068A RID: 1674 RVA: 0x0006906C File Offset: 0x0006726C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600068B RID: 1675 RVA: 0x000077C8 File Offset: 0x000059C8
			public Class1558(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x0600068C RID: 1676 RVA: 0x000077DE File Offset: 0x000059DE
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600068D RID: 1677 RVA: 0x000077E7 File Offset: 0x000059E7
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_46();
			}

			// Token: 0x0600068E RID: 1678 RVA: 0x00069084 File Offset: 0x00067284
			public Class2020 method_0()
			{
				return this.class2124_0.method_47(this.int_0);
			}

			// Token: 0x04000301 RID: 769
			private int int_0;

			// Token: 0x04000302 RID: 770
			private Class2124 class2124_0;
		}

		// Token: 0x02000131 RID: 305
		public sealed class Class1559 : IEnumerable
		{
			// Token: 0x0600068F RID: 1679 RVA: 0x0000780A File Offset: 0x00005A0A
			public void method_0(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
			}

			// Token: 0x06000690 RID: 1680 RVA: 0x000690A4 File Offset: 0x000672A4
			public Class2124.Class1560 method_1()
			{
				return new Class2124.Class1560(this.class2124_0);
			}

			// Token: 0x06000691 RID: 1681 RVA: 0x000690C0 File Offset: 0x000672C0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000303 RID: 771
			private Class2124 class2124_0;
		}

		// Token: 0x02000132 RID: 306
		public sealed class Class1560 : IEnumerator
		{
			// Token: 0x17000096 RID: 150
			// (get) Token: 0x06000693 RID: 1683 RVA: 0x000690D8 File Offset: 0x000672D8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000694 RID: 1684 RVA: 0x00007813 File Offset: 0x00005A13
			public Class1560(Class2124 class2124_1)
			{
				this.class2124_0 = class2124_1;
				this.int_0 = -1;
			}

			// Token: 0x06000695 RID: 1685 RVA: 0x00007829 File Offset: 0x00005A29
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000696 RID: 1686 RVA: 0x00007832 File Offset: 0x00005A32
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2124_0.method_48();
			}

			// Token: 0x06000697 RID: 1687 RVA: 0x000690F0 File Offset: 0x000672F0
			public Class2124 method_0()
			{
				return this.class2124_0.method_49(this.int_0);
			}

			// Token: 0x04000304 RID: 772
			private int int_0;

			// Token: 0x04000305 RID: 773
			private Class2124 class2124_0;
		}
	}
}
