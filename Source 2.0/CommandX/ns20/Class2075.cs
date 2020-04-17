using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns20
{
	// Token: 0x02000750 RID: 1872
	public sealed class Class2075 : Class2059
	{
		// Token: 0x06002E75 RID: 11893 RVA: 0x001063E4 File Offset: 0x001045E4
		public Class2075()
		{
			this.method_36();
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x001064B8 File Offset: 0x001046B8
		public Class2075(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_36();
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x00106590 File Offset: 0x00104790
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "ShowAtStartup");
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x001065B0 File Offset: 0x001047B0
		public Class2009 method_3(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "ShowAtStartup", int_0)));
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x0007D12C File Offset: 0x0007B32C
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Name");
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x0007D14C File Offset: 0x0007B34C
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Name", int_0)));
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x001065DC File Offset: 0x001047DC
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Latitude");
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x001065FC File Offset: 0x001047FC
		public Class2081 method_7(int int_0)
		{
			return new Class2081(base.method_1(Class2059.Enum155.const_1, "", "Latitude", int_0));
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x00106624 File Offset: 0x00104824
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Longitude");
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x00106644 File Offset: 0x00104844
		public Class2086 method_9(int int_0)
		{
			return new Class2086(base.method_1(Class2059.Enum155.const_1, "", "Longitude", int_0));
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x0010666C File Offset: 0x0010486C
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DistanceAboveSurface");
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x0010668C File Offset: 0x0010488C
		public Class2020 method_11(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DistanceAboveSurface", int_0)));
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x001066B8 File Offset: 0x001048B8
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MinimumDisplayAltitude");
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x001066D8 File Offset: 0x001048D8
		public Class2020 method_13(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MinimumDisplayAltitude", int_0)));
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x00106704 File Offset: 0x00104904
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MaximumDisplayAltitude");
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x00106724 File Offset: 0x00104924
		public Class2020 method_15(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MaximumDisplayAltitude", int_0)));
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x00106750 File Offset: 0x00104950
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TextureFilePath");
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x00106770 File Offset: 0x00104970
		public Class2050 method_17(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "TextureFilePath", int_0)));
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x0010679C File Offset: 0x0010499C
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TextureWidthPixels");
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x001067BC File Offset: 0x001049BC
		public Class2010 method_19(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "TextureWidthPixels", int_0)));
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x001067E8 File Offset: 0x001049E8
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TextureHeightPixels");
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x00106808 File Offset: 0x00104A08
		public Class2010 method_21(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "TextureHeightPixels", int_0)));
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00106834 File Offset: 0x00104A34
		public int method_22()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "IconWidthPixels");
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x00106854 File Offset: 0x00104A54
		public Class2010 method_23(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "IconWidthPixels", int_0)));
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00106880 File Offset: 0x00104A80
		public int method_24()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "IconHeightPixels");
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x001068A0 File Offset: 0x00104AA0
		public Class2010 method_25(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "IconHeightPixels", int_0)));
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x001068CC File Offset: 0x00104ACC
		public int method_26()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Caption");
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x001068EC File Offset: 0x00104AEC
		public Class2071 method_27(int int_0)
		{
			return new Class2071(base.method_1(Class2059.Enum155.const_1, "", "Caption", int_0));
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00106914 File Offset: 0x00104B14
		public int method_28()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ClickableUrl");
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00106934 File Offset: 0x00104B34
		public Class2050 method_29(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ClickableUrl", int_0)));
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x00106960 File Offset: 0x00104B60
		public int method_30()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MouseoverTextColor");
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x00106980 File Offset: 0x00104B80
		public Class2096 method_31(int int_0)
		{
			return new Class2096(base.method_1(Class2059.Enum155.const_1, "", "MouseoverTextColor", int_0));
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x001069A8 File Offset: 0x00104BA8
		public int method_32()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ExtendedInformation");
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x001069C8 File Offset: 0x00104BC8
		public Class2074 method_33(int int_0)
		{
			return new Class2074(base.method_1(Class2059.Enum155.const_1, "", "ExtendedInformation", int_0));
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x001069F0 File Offset: 0x00104BF0
		public int method_34()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Description");
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x00106A10 File Offset: 0x00104C10
		public Class2050 method_35(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Description", int_0)));
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x00106A3C File Offset: 0x00104C3C
		private void method_36()
		{
			this.class959_0.method_0(this);
			this.class961_0.method_0(this);
			this.class963_0.method_0(this);
			this.class965_0.method_0(this);
			this.class967_0.method_0(this);
			this.class969_0.method_0(this);
			this.class971_0.method_0(this);
			this.class973_0.method_0(this);
			this.class975_0.method_0(this);
			this.class977_0.method_0(this);
			this.class979_0.method_0(this);
			this.class981_0.method_0(this);
			this.class983_0.method_0(this);
			this.class985_0.method_0(this);
			this.class987_0.method_0(this);
			this.class989_0.method_0(this);
			this.class991_0.method_0(this);
		}

		// Token: 0x040015A7 RID: 5543
		public Class2075.Class959 class959_0 = new Class2075.Class959();

		// Token: 0x040015A8 RID: 5544
		public Class2075.Class961 class961_0 = new Class2075.Class961();

		// Token: 0x040015A9 RID: 5545
		public Class2075.Class963 class963_0 = new Class2075.Class963();

		// Token: 0x040015AA RID: 5546
		public Class2075.Class965 class965_0 = new Class2075.Class965();

		// Token: 0x040015AB RID: 5547
		public Class2075.Class967 class967_0 = new Class2075.Class967();

		// Token: 0x040015AC RID: 5548
		public Class2075.Class969 class969_0 = new Class2075.Class969();

		// Token: 0x040015AD RID: 5549
		public Class2075.Class971 class971_0 = new Class2075.Class971();

		// Token: 0x040015AE RID: 5550
		public Class2075.Class973 class973_0 = new Class2075.Class973();

		// Token: 0x040015AF RID: 5551
		public Class2075.Class975 class975_0 = new Class2075.Class975();

		// Token: 0x040015B0 RID: 5552
		public Class2075.Class977 class977_0 = new Class2075.Class977();

		// Token: 0x040015B1 RID: 5553
		public Class2075.Class979 class979_0 = new Class2075.Class979();

		// Token: 0x040015B2 RID: 5554
		public Class2075.Class981 class981_0 = new Class2075.Class981();

		// Token: 0x040015B3 RID: 5555
		public Class2075.Class983 class983_0 = new Class2075.Class983();

		// Token: 0x040015B4 RID: 5556
		public Class2075.Class985 class985_0 = new Class2075.Class985();

		// Token: 0x040015B5 RID: 5557
		public Class2075.Class987 class987_0 = new Class2075.Class987();

		// Token: 0x040015B6 RID: 5558
		public Class2075.Class989 class989_0 = new Class2075.Class989();

		// Token: 0x040015B7 RID: 5559
		public Class2075.Class991 class991_0 = new Class2075.Class991();

		// Token: 0x02000751 RID: 1873
		public sealed class Class959 : IEnumerable
		{
			// Token: 0x06002E9A RID: 11930 RVA: 0x00019431 File Offset: 0x00017631
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002E9B RID: 11931 RVA: 0x00106B18 File Offset: 0x00104D18
			public Class2075.Class960 method_1()
			{
				return new Class2075.Class960(this.class2075_0);
			}

			// Token: 0x06002E9C RID: 11932 RVA: 0x00106B34 File Offset: 0x00104D34
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015B8 RID: 5560
			private Class2075 class2075_0;
		}

		// Token: 0x02000752 RID: 1874
		public sealed class Class960 : IEnumerator
		{
			// Token: 0x17000325 RID: 805
			// (get) Token: 0x06002E9E RID: 11934 RVA: 0x00106B4C File Offset: 0x00104D4C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002E9F RID: 11935 RVA: 0x0001943A File Offset: 0x0001763A
			public Class960(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002EA0 RID: 11936 RVA: 0x00019450 File Offset: 0x00017650
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002EA1 RID: 11937 RVA: 0x00019459 File Offset: 0x00017659
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_2();
			}

			// Token: 0x06002EA2 RID: 11938 RVA: 0x00106B64 File Offset: 0x00104D64
			public Class2009 method_0()
			{
				return this.class2075_0.method_3(this.int_0);
			}

			// Token: 0x040015B9 RID: 5561
			private int int_0;

			// Token: 0x040015BA RID: 5562
			private Class2075 class2075_0;
		}

		// Token: 0x02000753 RID: 1875
		public sealed class Class961 : IEnumerable
		{
			// Token: 0x06002EA3 RID: 11939 RVA: 0x0001947C File Offset: 0x0001767C
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002EA4 RID: 11940 RVA: 0x00106B84 File Offset: 0x00104D84
			public Class2075.Class962 method_1()
			{
				return new Class2075.Class962(this.class2075_0);
			}

			// Token: 0x06002EA5 RID: 11941 RVA: 0x00106BA0 File Offset: 0x00104DA0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015BB RID: 5563
			private Class2075 class2075_0;
		}

		// Token: 0x02000754 RID: 1876
		public sealed class Class962 : IEnumerator
		{
			// Token: 0x17000326 RID: 806
			// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x00106BB8 File Offset: 0x00104DB8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002EA8 RID: 11944 RVA: 0x00019485 File Offset: 0x00017685
			public Class962(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002EA9 RID: 11945 RVA: 0x0001949B File Offset: 0x0001769B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002EAA RID: 11946 RVA: 0x000194A4 File Offset: 0x000176A4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_4();
			}

			// Token: 0x06002EAB RID: 11947 RVA: 0x00106BD0 File Offset: 0x00104DD0
			public Class2050 method_0()
			{
				return this.class2075_0.method_5(this.int_0);
			}

			// Token: 0x040015BC RID: 5564
			private int int_0;

			// Token: 0x040015BD RID: 5565
			private Class2075 class2075_0;
		}

		// Token: 0x02000755 RID: 1877
		public sealed class Class963 : IEnumerable
		{
			// Token: 0x06002EAC RID: 11948 RVA: 0x000194C7 File Offset: 0x000176C7
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002EAD RID: 11949 RVA: 0x00106BF0 File Offset: 0x00104DF0
			public Class2075.Class964 method_1()
			{
				return new Class2075.Class964(this.class2075_0);
			}

			// Token: 0x06002EAE RID: 11950 RVA: 0x00106C0C File Offset: 0x00104E0C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015BE RID: 5566
			private Class2075 class2075_0;
		}

		// Token: 0x02000756 RID: 1878
		public sealed class Class964 : IEnumerator
		{
			// Token: 0x17000327 RID: 807
			// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x00106C24 File Offset: 0x00104E24
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002EB1 RID: 11953 RVA: 0x000194D0 File Offset: 0x000176D0
			public Class964(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002EB2 RID: 11954 RVA: 0x000194E6 File Offset: 0x000176E6
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002EB3 RID: 11955 RVA: 0x000194EF File Offset: 0x000176EF
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_6();
			}

			// Token: 0x06002EB4 RID: 11956 RVA: 0x00106C3C File Offset: 0x00104E3C
			public Class2081 method_0()
			{
				return this.class2075_0.method_7(this.int_0);
			}

			// Token: 0x040015BF RID: 5567
			private int int_0;

			// Token: 0x040015C0 RID: 5568
			private Class2075 class2075_0;
		}

		// Token: 0x02000757 RID: 1879
		public sealed class Class965 : IEnumerable
		{
			// Token: 0x06002EB5 RID: 11957 RVA: 0x00019512 File Offset: 0x00017712
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002EB6 RID: 11958 RVA: 0x00106C5C File Offset: 0x00104E5C
			public Class2075.Class966 method_1()
			{
				return new Class2075.Class966(this.class2075_0);
			}

			// Token: 0x06002EB7 RID: 11959 RVA: 0x00106C78 File Offset: 0x00104E78
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015C1 RID: 5569
			private Class2075 class2075_0;
		}

		// Token: 0x02000758 RID: 1880
		public sealed class Class966 : IEnumerator
		{
			// Token: 0x17000328 RID: 808
			// (get) Token: 0x06002EB9 RID: 11961 RVA: 0x00106C90 File Offset: 0x00104E90
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002EBA RID: 11962 RVA: 0x0001951B File Offset: 0x0001771B
			public Class966(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002EBB RID: 11963 RVA: 0x00019531 File Offset: 0x00017731
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002EBC RID: 11964 RVA: 0x0001953A File Offset: 0x0001773A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_8();
			}

			// Token: 0x06002EBD RID: 11965 RVA: 0x00106CA8 File Offset: 0x00104EA8
			public Class2086 method_0()
			{
				return this.class2075_0.method_9(this.int_0);
			}

			// Token: 0x040015C2 RID: 5570
			private int int_0;

			// Token: 0x040015C3 RID: 5571
			private Class2075 class2075_0;
		}

		// Token: 0x02000759 RID: 1881
		public sealed class Class967 : IEnumerable
		{
			// Token: 0x06002EBE RID: 11966 RVA: 0x0001955D File Offset: 0x0001775D
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002EBF RID: 11967 RVA: 0x00106CC8 File Offset: 0x00104EC8
			public Class2075.Class968 method_1()
			{
				return new Class2075.Class968(this.class2075_0);
			}

			// Token: 0x06002EC0 RID: 11968 RVA: 0x00106CE4 File Offset: 0x00104EE4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015C4 RID: 5572
			private Class2075 class2075_0;
		}

		// Token: 0x0200075A RID: 1882
		public sealed class Class968 : IEnumerator
		{
			// Token: 0x17000329 RID: 809
			// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x00106CFC File Offset: 0x00104EFC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002EC3 RID: 11971 RVA: 0x00019566 File Offset: 0x00017766
			public Class968(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002EC4 RID: 11972 RVA: 0x0001957C File Offset: 0x0001777C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002EC5 RID: 11973 RVA: 0x00019585 File Offset: 0x00017785
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_10();
			}

			// Token: 0x06002EC6 RID: 11974 RVA: 0x00106D14 File Offset: 0x00104F14
			public Class2020 method_0()
			{
				return this.class2075_0.method_11(this.int_0);
			}

			// Token: 0x040015C5 RID: 5573
			private int int_0;

			// Token: 0x040015C6 RID: 5574
			private Class2075 class2075_0;
		}

		// Token: 0x0200075B RID: 1883
		public sealed class Class969 : IEnumerable
		{
			// Token: 0x06002EC7 RID: 11975 RVA: 0x000195A8 File Offset: 0x000177A8
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002EC8 RID: 11976 RVA: 0x00106D34 File Offset: 0x00104F34
			public Class2075.Class970 method_1()
			{
				return new Class2075.Class970(this.class2075_0);
			}

			// Token: 0x06002EC9 RID: 11977 RVA: 0x00106D50 File Offset: 0x00104F50
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015C7 RID: 5575
			private Class2075 class2075_0;
		}

		// Token: 0x0200075C RID: 1884
		public sealed class Class970 : IEnumerator
		{
			// Token: 0x1700032A RID: 810
			// (get) Token: 0x06002ECB RID: 11979 RVA: 0x00106D68 File Offset: 0x00104F68
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002ECC RID: 11980 RVA: 0x000195B1 File Offset: 0x000177B1
			public Class970(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002ECD RID: 11981 RVA: 0x000195C7 File Offset: 0x000177C7
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002ECE RID: 11982 RVA: 0x000195D0 File Offset: 0x000177D0
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_12();
			}

			// Token: 0x06002ECF RID: 11983 RVA: 0x00106D80 File Offset: 0x00104F80
			public Class2020 method_0()
			{
				return this.class2075_0.method_13(this.int_0);
			}

			// Token: 0x040015C8 RID: 5576
			private int int_0;

			// Token: 0x040015C9 RID: 5577
			private Class2075 class2075_0;
		}

		// Token: 0x0200075D RID: 1885
		public sealed class Class971 : IEnumerable
		{
			// Token: 0x06002ED0 RID: 11984 RVA: 0x000195F3 File Offset: 0x000177F3
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002ED1 RID: 11985 RVA: 0x00106DA0 File Offset: 0x00104FA0
			public Class2075.Class972 method_1()
			{
				return new Class2075.Class972(this.class2075_0);
			}

			// Token: 0x06002ED2 RID: 11986 RVA: 0x00106DBC File Offset: 0x00104FBC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015CA RID: 5578
			private Class2075 class2075_0;
		}

		// Token: 0x0200075E RID: 1886
		public sealed class Class972 : IEnumerator
		{
			// Token: 0x1700032B RID: 811
			// (get) Token: 0x06002ED4 RID: 11988 RVA: 0x00106DD4 File Offset: 0x00104FD4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002ED5 RID: 11989 RVA: 0x000195FC File Offset: 0x000177FC
			public Class972(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002ED6 RID: 11990 RVA: 0x00019612 File Offset: 0x00017812
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002ED7 RID: 11991 RVA: 0x0001961B File Offset: 0x0001781B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_14();
			}

			// Token: 0x06002ED8 RID: 11992 RVA: 0x00106DEC File Offset: 0x00104FEC
			public Class2020 method_0()
			{
				return this.class2075_0.method_15(this.int_0);
			}

			// Token: 0x040015CB RID: 5579
			private int int_0;

			// Token: 0x040015CC RID: 5580
			private Class2075 class2075_0;
		}

		// Token: 0x0200075F RID: 1887
		public sealed class Class973 : IEnumerable
		{
			// Token: 0x06002ED9 RID: 11993 RVA: 0x0001963E File Offset: 0x0001783E
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002EDA RID: 11994 RVA: 0x00106E0C File Offset: 0x0010500C
			public Class2075.Class974 method_1()
			{
				return new Class2075.Class974(this.class2075_0);
			}

			// Token: 0x06002EDB RID: 11995 RVA: 0x00106E28 File Offset: 0x00105028
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015CD RID: 5581
			private Class2075 class2075_0;
		}

		// Token: 0x02000760 RID: 1888
		public sealed class Class974 : IEnumerator
		{
			// Token: 0x1700032C RID: 812
			// (get) Token: 0x06002EDD RID: 11997 RVA: 0x00106E40 File Offset: 0x00105040
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002EDE RID: 11998 RVA: 0x00019647 File Offset: 0x00017847
			public Class974(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002EDF RID: 11999 RVA: 0x0001965D File Offset: 0x0001785D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002EE0 RID: 12000 RVA: 0x00019666 File Offset: 0x00017866
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_16();
			}

			// Token: 0x06002EE1 RID: 12001 RVA: 0x00106E58 File Offset: 0x00105058
			public Class2050 method_0()
			{
				return this.class2075_0.method_17(this.int_0);
			}

			// Token: 0x040015CE RID: 5582
			private int int_0;

			// Token: 0x040015CF RID: 5583
			private Class2075 class2075_0;
		}

		// Token: 0x02000761 RID: 1889
		public sealed class Class975 : IEnumerable
		{
			// Token: 0x06002EE2 RID: 12002 RVA: 0x00019689 File Offset: 0x00017889
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002EE3 RID: 12003 RVA: 0x00106E78 File Offset: 0x00105078
			public Class2075.Class976 method_1()
			{
				return new Class2075.Class976(this.class2075_0);
			}

			// Token: 0x06002EE4 RID: 12004 RVA: 0x00106E94 File Offset: 0x00105094
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015D0 RID: 5584
			private Class2075 class2075_0;
		}

		// Token: 0x02000762 RID: 1890
		public sealed class Class976 : IEnumerator
		{
			// Token: 0x1700032D RID: 813
			// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x00106EAC File Offset: 0x001050AC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002EE7 RID: 12007 RVA: 0x00019692 File Offset: 0x00017892
			public Class976(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002EE8 RID: 12008 RVA: 0x000196A8 File Offset: 0x000178A8
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002EE9 RID: 12009 RVA: 0x000196B1 File Offset: 0x000178B1
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_18();
			}

			// Token: 0x06002EEA RID: 12010 RVA: 0x00106EC4 File Offset: 0x001050C4
			public Class2010 method_0()
			{
				return this.class2075_0.method_19(this.int_0);
			}

			// Token: 0x040015D1 RID: 5585
			private int int_0;

			// Token: 0x040015D2 RID: 5586
			private Class2075 class2075_0;
		}

		// Token: 0x02000763 RID: 1891
		public sealed class Class977 : IEnumerable
		{
			// Token: 0x06002EEB RID: 12011 RVA: 0x000196D4 File Offset: 0x000178D4
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002EEC RID: 12012 RVA: 0x00106EE4 File Offset: 0x001050E4
			public Class2075.Class978 method_1()
			{
				return new Class2075.Class978(this.class2075_0);
			}

			// Token: 0x06002EED RID: 12013 RVA: 0x00106F00 File Offset: 0x00105100
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015D3 RID: 5587
			private Class2075 class2075_0;
		}

		// Token: 0x02000764 RID: 1892
		public sealed class Class978 : IEnumerator
		{
			// Token: 0x1700032E RID: 814
			// (get) Token: 0x06002EEF RID: 12015 RVA: 0x00106F18 File Offset: 0x00105118
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002EF0 RID: 12016 RVA: 0x000196DD File Offset: 0x000178DD
			public Class978(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002EF1 RID: 12017 RVA: 0x000196F3 File Offset: 0x000178F3
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002EF2 RID: 12018 RVA: 0x000196FC File Offset: 0x000178FC
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_20();
			}

			// Token: 0x06002EF3 RID: 12019 RVA: 0x00106F30 File Offset: 0x00105130
			public Class2010 method_0()
			{
				return this.class2075_0.method_21(this.int_0);
			}

			// Token: 0x040015D4 RID: 5588
			private int int_0;

			// Token: 0x040015D5 RID: 5589
			private Class2075 class2075_0;
		}

		// Token: 0x02000765 RID: 1893
		public sealed class Class979 : IEnumerable
		{
			// Token: 0x06002EF4 RID: 12020 RVA: 0x0001971F File Offset: 0x0001791F
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002EF5 RID: 12021 RVA: 0x00106F50 File Offset: 0x00105150
			public Class2075.Class980 method_1()
			{
				return new Class2075.Class980(this.class2075_0);
			}

			// Token: 0x06002EF6 RID: 12022 RVA: 0x00106F6C File Offset: 0x0010516C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015D6 RID: 5590
			private Class2075 class2075_0;
		}

		// Token: 0x02000766 RID: 1894
		public sealed class Class980 : IEnumerator
		{
			// Token: 0x1700032F RID: 815
			// (get) Token: 0x06002EF8 RID: 12024 RVA: 0x00106F84 File Offset: 0x00105184
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002EF9 RID: 12025 RVA: 0x00019728 File Offset: 0x00017928
			public Class980(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002EFA RID: 12026 RVA: 0x0001973E File Offset: 0x0001793E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002EFB RID: 12027 RVA: 0x00019747 File Offset: 0x00017947
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_22();
			}

			// Token: 0x06002EFC RID: 12028 RVA: 0x00106F9C File Offset: 0x0010519C
			public Class2010 method_0()
			{
				return this.class2075_0.method_23(this.int_0);
			}

			// Token: 0x040015D7 RID: 5591
			private int int_0;

			// Token: 0x040015D8 RID: 5592
			private Class2075 class2075_0;
		}

		// Token: 0x02000767 RID: 1895
		public sealed class Class981 : IEnumerable
		{
			// Token: 0x06002EFD RID: 12029 RVA: 0x0001976A File Offset: 0x0001796A
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002EFE RID: 12030 RVA: 0x00106FBC File Offset: 0x001051BC
			public Class2075.Class982 method_1()
			{
				return new Class2075.Class982(this.class2075_0);
			}

			// Token: 0x06002EFF RID: 12031 RVA: 0x00106FD8 File Offset: 0x001051D8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015D9 RID: 5593
			private Class2075 class2075_0;
		}

		// Token: 0x02000768 RID: 1896
		public sealed class Class982 : IEnumerator
		{
			// Token: 0x17000330 RID: 816
			// (get) Token: 0x06002F01 RID: 12033 RVA: 0x00106FF0 File Offset: 0x001051F0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002F02 RID: 12034 RVA: 0x00019773 File Offset: 0x00017973
			public Class982(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002F03 RID: 12035 RVA: 0x00019789 File Offset: 0x00017989
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002F04 RID: 12036 RVA: 0x00019792 File Offset: 0x00017992
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_24();
			}

			// Token: 0x06002F05 RID: 12037 RVA: 0x00107008 File Offset: 0x00105208
			public Class2010 method_0()
			{
				return this.class2075_0.method_25(this.int_0);
			}

			// Token: 0x040015DA RID: 5594
			private int int_0;

			// Token: 0x040015DB RID: 5595
			private Class2075 class2075_0;
		}

		// Token: 0x02000769 RID: 1897
		public sealed class Class983 : IEnumerable
		{
			// Token: 0x06002F06 RID: 12038 RVA: 0x000197B5 File Offset: 0x000179B5
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002F07 RID: 12039 RVA: 0x00107028 File Offset: 0x00105228
			public Class2075.Class984 method_1()
			{
				return new Class2075.Class984(this.class2075_0);
			}

			// Token: 0x06002F08 RID: 12040 RVA: 0x00107044 File Offset: 0x00105244
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015DC RID: 5596
			private Class2075 class2075_0;
		}

		// Token: 0x0200076A RID: 1898
		public sealed class Class984 : IEnumerator
		{
			// Token: 0x17000331 RID: 817
			// (get) Token: 0x06002F0A RID: 12042 RVA: 0x0010705C File Offset: 0x0010525C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002F0B RID: 12043 RVA: 0x000197BE File Offset: 0x000179BE
			public Class984(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002F0C RID: 12044 RVA: 0x000197D4 File Offset: 0x000179D4
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002F0D RID: 12045 RVA: 0x000197DD File Offset: 0x000179DD
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_26();
			}

			// Token: 0x06002F0E RID: 12046 RVA: 0x00107074 File Offset: 0x00105274
			public Class2071 method_0()
			{
				return this.class2075_0.method_27(this.int_0);
			}

			// Token: 0x040015DD RID: 5597
			private int int_0;

			// Token: 0x040015DE RID: 5598
			private Class2075 class2075_0;
		}

		// Token: 0x0200076B RID: 1899
		public sealed class Class985 : IEnumerable
		{
			// Token: 0x06002F0F RID: 12047 RVA: 0x00019800 File Offset: 0x00017A00
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002F10 RID: 12048 RVA: 0x00107094 File Offset: 0x00105294
			public Class2075.Class986 method_1()
			{
				return new Class2075.Class986(this.class2075_0);
			}

			// Token: 0x06002F11 RID: 12049 RVA: 0x001070B0 File Offset: 0x001052B0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015DF RID: 5599
			private Class2075 class2075_0;
		}

		// Token: 0x0200076C RID: 1900
		public sealed class Class986 : IEnumerator
		{
			// Token: 0x17000332 RID: 818
			// (get) Token: 0x06002F13 RID: 12051 RVA: 0x001070C8 File Offset: 0x001052C8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002F14 RID: 12052 RVA: 0x00019809 File Offset: 0x00017A09
			public Class986(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002F15 RID: 12053 RVA: 0x0001981F File Offset: 0x00017A1F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002F16 RID: 12054 RVA: 0x00019828 File Offset: 0x00017A28
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_28();
			}

			// Token: 0x06002F17 RID: 12055 RVA: 0x001070E0 File Offset: 0x001052E0
			public Class2050 method_0()
			{
				return this.class2075_0.method_29(this.int_0);
			}

			// Token: 0x040015E0 RID: 5600
			private int int_0;

			// Token: 0x040015E1 RID: 5601
			private Class2075 class2075_0;
		}

		// Token: 0x0200076D RID: 1901
		public sealed class Class987 : IEnumerable
		{
			// Token: 0x06002F18 RID: 12056 RVA: 0x0001984B File Offset: 0x00017A4B
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002F19 RID: 12057 RVA: 0x00107100 File Offset: 0x00105300
			public Class2075.Class988 method_1()
			{
				return new Class2075.Class988(this.class2075_0);
			}

			// Token: 0x06002F1A RID: 12058 RVA: 0x0010711C File Offset: 0x0010531C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015E2 RID: 5602
			private Class2075 class2075_0;
		}

		// Token: 0x0200076E RID: 1902
		public sealed class Class988 : IEnumerator
		{
			// Token: 0x17000333 RID: 819
			// (get) Token: 0x06002F1C RID: 12060 RVA: 0x00107134 File Offset: 0x00105334
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002F1D RID: 12061 RVA: 0x00019854 File Offset: 0x00017A54
			public Class988(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002F1E RID: 12062 RVA: 0x0001986A File Offset: 0x00017A6A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002F1F RID: 12063 RVA: 0x00019873 File Offset: 0x00017A73
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_30();
			}

			// Token: 0x06002F20 RID: 12064 RVA: 0x0010714C File Offset: 0x0010534C
			public Class2096 method_0()
			{
				return this.class2075_0.method_31(this.int_0);
			}

			// Token: 0x040015E3 RID: 5603
			private int int_0;

			// Token: 0x040015E4 RID: 5604
			private Class2075 class2075_0;
		}

		// Token: 0x0200076F RID: 1903
		public sealed class Class989 : IEnumerable
		{
			// Token: 0x06002F21 RID: 12065 RVA: 0x00019896 File Offset: 0x00017A96
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002F22 RID: 12066 RVA: 0x0010716C File Offset: 0x0010536C
			public Class2075.Class990 method_1()
			{
				return new Class2075.Class990(this.class2075_0);
			}

			// Token: 0x06002F23 RID: 12067 RVA: 0x00107188 File Offset: 0x00105388
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015E5 RID: 5605
			private Class2075 class2075_0;
		}

		// Token: 0x02000770 RID: 1904
		public sealed class Class990 : IEnumerator
		{
			// Token: 0x17000334 RID: 820
			// (get) Token: 0x06002F25 RID: 12069 RVA: 0x001071A0 File Offset: 0x001053A0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002F26 RID: 12070 RVA: 0x0001989F File Offset: 0x00017A9F
			public Class990(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002F27 RID: 12071 RVA: 0x000198B5 File Offset: 0x00017AB5
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002F28 RID: 12072 RVA: 0x000198BE File Offset: 0x00017ABE
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_32();
			}

			// Token: 0x06002F29 RID: 12073 RVA: 0x001071B8 File Offset: 0x001053B8
			public Class2074 method_0()
			{
				return this.class2075_0.method_33(this.int_0);
			}

			// Token: 0x040015E6 RID: 5606
			private int int_0;

			// Token: 0x040015E7 RID: 5607
			private Class2075 class2075_0;
		}

		// Token: 0x02000771 RID: 1905
		public sealed class Class991 : IEnumerable
		{
			// Token: 0x06002F2A RID: 12074 RVA: 0x000198E1 File Offset: 0x00017AE1
			public void method_0(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
			}

			// Token: 0x06002F2B RID: 12075 RVA: 0x001071D8 File Offset: 0x001053D8
			public Class2075.Class992 method_1()
			{
				return new Class2075.Class992(this.class2075_0);
			}

			// Token: 0x06002F2C RID: 12076 RVA: 0x001071F4 File Offset: 0x001053F4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015E8 RID: 5608
			private Class2075 class2075_0;
		}

		// Token: 0x02000772 RID: 1906
		public sealed class Class992 : IEnumerator
		{
			// Token: 0x17000335 RID: 821
			// (get) Token: 0x06002F2E RID: 12078 RVA: 0x0010720C File Offset: 0x0010540C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002F2F RID: 12079 RVA: 0x000198EA File Offset: 0x00017AEA
			public Class992(Class2075 class2075_1)
			{
				this.class2075_0 = class2075_1;
				this.int_0 = -1;
			}

			// Token: 0x06002F30 RID: 12080 RVA: 0x00019900 File Offset: 0x00017B00
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002F31 RID: 12081 RVA: 0x00019909 File Offset: 0x00017B09
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2075_0.method_34();
			}

			// Token: 0x06002F32 RID: 12082 RVA: 0x00107224 File Offset: 0x00105424
			public Class2050 method_0()
			{
				return this.class2075_0.method_35(this.int_0);
			}

			// Token: 0x040015E9 RID: 5609
			private int int_0;

			// Token: 0x040015EA RID: 5610
			private Class2075 class2075_0;
		}
	}
}
