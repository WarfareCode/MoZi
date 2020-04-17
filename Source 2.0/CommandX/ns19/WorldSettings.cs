using System;
using System.Collections;
using System.Drawing;
using System.Xml.Serialization;
using Microsoft.DirectX.Direct3D;
using ns18;

namespace ns19
{
	// Token: 0x0200040D RID: 1037
	public sealed class WorldSettings : SettingsBase
	{
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x0009E5D8 File Offset: 0x0009C7D8
		// (set) Token: 0x060019E2 RID: 6626 RVA: 0x00010D57 File Offset: 0x0000EF57
		[XmlIgnore]
		public float TimeMultiplier
		{
			get
			{
				return TimeKeeper.smethod_2();
			}
			set
			{
				TimeKeeper.smethod_3(value);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x0009E5EC File Offset: 0x0009C7EC
		// (set) Token: 0x060019E4 RID: 6628 RVA: 0x00010D5F File Offset: 0x0000EF5F
		[XmlIgnore]
		public Color ShadingAmbientColor
		{
			get
			{
				return Color.FromArgb(this.int_19);
			}
			set
			{
				this.int_19 = value.ToArgb();
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x0009E608 File Offset: 0x0009C808
		// (set) Token: 0x060019E6 RID: 6630 RVA: 0x00010D6E File Offset: 0x0000EF6E
		[XmlIgnore]
		public Color StandardAmbientColor
		{
			get
			{
				return Color.FromArgb(this.int_20);
			}
			set
			{
				this.int_20 = value.ToArgb();
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x0009E624 File Offset: 0x0009C824
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x00010D7D File Offset: 0x0000EF7D
		[XmlIgnore]
		public Color MeasureLineGroundColor
		{
			get
			{
				return Color.FromArgb(this.int_21);
			}
			set
			{
				this.int_21 = value.ToArgb();
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x0009E640 File Offset: 0x0009C840
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x0009E658 File Offset: 0x0009C858
		[XmlIgnore]
		public TimeSpan TerrainTileRetryInterval
		{
			get
			{
				return this.timeSpan_0;
			}
			set
			{
				TimeSpan timeSpan = TimeSpan.FromMinutes(1.0);
				if (value < timeSpan)
				{
					value = timeSpan;
				}
				this.timeSpan_0 = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x0009E68C File Offset: 0x0009C88C
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x00010D8C File Offset: 0x0000EF8C
		[XmlIgnore]
		public Color DownloadQueuedColor
		{
			get
			{
				return Color.FromArgb(this.int_23);
			}
			set
			{
				this.int_23 = value.ToArgb();
			}
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00010D9B File Offset: 0x0000EF9B
		public bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00010DA3 File Offset: 0x0000EFA3
		public bool method_1()
		{
			return this.bool_1;
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00010DAB File Offset: 0x0000EFAB
		public bool method_2()
		{
			return this.bool_11;
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00010DB3 File Offset: 0x0000EFB3
		public bool method_3()
		{
			return this.bool_8;
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x00010DBB File Offset: 0x0000EFBB
		public void method_4(bool bool_32)
		{
			this.bool_8 = bool_32;
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		public bool method_5()
		{
			return this.bool_3;
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00010DCC File Offset: 0x0000EFCC
		public void method_6(bool bool_32)
		{
			this.bool_3 = bool_32;
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x0009E6A8 File Offset: 0x0009C8A8
		public string method_7()
		{
			return this.string_3;
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x0009E6C0 File Offset: 0x0009C8C0
		public float method_8()
		{
			return this.float_1;
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x0009E6D8 File Offset: 0x0009C8D8
		public FontStyle method_9()
		{
			return this.fontStyle_0;
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00010DD5 File Offset: 0x0000EFD5
		public bool method_10()
		{
			return this.bool_4;
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00010DDD File Offset: 0x0000EFDD
		public void method_11(bool bool_32)
		{
			this.bool_4 = bool_32;
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00010DE6 File Offset: 0x0000EFE6
		public bool method_12()
		{
			return this.bool_5;
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00010DEE File Offset: 0x0000EFEE
		public void method_13(bool bool_32)
		{
			this.bool_5 = bool_32;
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x00010DF7 File Offset: 0x0000EFF7
		public bool method_14()
		{
			return this.bool_6;
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00010DFF File Offset: 0x0000EFFF
		public bool method_15()
		{
			return this.bool_7;
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0009E6F0 File Offset: 0x0009C8F0
		public int method_16()
		{
			return this.int_4;
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00010E07 File Offset: 0x0000F007
		public void method_17(bool bool_32)
		{
			this.bool_12 = bool_32;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00010E10 File Offset: 0x0000F010
		public bool method_18()
		{
			return this.bool_16;
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00010E18 File Offset: 0x0000F018
		public bool GetElevateCameraLookatPoint()
		{
			return this.bool_25;
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00010E20 File Offset: 0x0000F020
		public bool method_20()
		{
			return this.bool_18;
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0009E708 File Offset: 0x0009C908
		public Angle method_21()
		{
			return this.struct63_0;
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0009E720 File Offset: 0x0009C920
		public Angle method_22()
		{
			return this.struct63_1;
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0009E738 File Offset: 0x0009C938
		public double method_23()
		{
			return this.double_0;
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0009E750 File Offset: 0x0009C950
		public Angle method_24()
		{
			return this.struct63_2;
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0009E768 File Offset: 0x0009C968
		public Angle method_25()
		{
			return this.struct63_3;
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00010E28 File Offset: 0x0000F028
		public void method_26(bool bool_32)
		{
			this.bool_21 = bool_32;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00010E31 File Offset: 0x0000F031
		public void method_27(bool bool_32)
		{
			this.bool_20 = bool_32;
			this.float_5 = (this.bool_20 ? this.float_4 : this.float_3);
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00010E56 File Offset: 0x0000F056
		public void method_28(bool bool_32)
		{
			this.bool_22 = bool_32;
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00010E5F File Offset: 0x0000F05F
		public bool method_29()
		{
			return this.bool_23;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00010E67 File Offset: 0x0000F067
		public bool method_30()
		{
			return this.bool_24;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00010E6F File Offset: 0x0000F06F
		public void method_31(float float_14)
		{
			this.float_4 = float_14;
			if (this.bool_20)
			{
				this.float_5 = this.float_4;
			}
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00010E8F File Offset: 0x0000F08F
		public void method_32(float float_14)
		{
			this.float_3 = float_14;
			if (!this.bool_20)
			{
				this.float_5 = this.float_3;
			}
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0009E780 File Offset: 0x0009C980
		public float method_33()
		{
			return this.float_8;
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0009E798 File Offset: 0x0009C998
		public float method_34()
		{
			return this.float_9;
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0009E7B0 File Offset: 0x0009C9B0
		public float method_35()
		{
			return this.float_11;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x0009E7C8 File Offset: 0x0009C9C8
		public float method_36()
		{
			return this.float_10;
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00010EAC File Offset: 0x0000F0AC
		public bool method_37()
		{
			return this.bool_27;
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00010EB4 File Offset: 0x0000F0B4
		public void method_38(bool bool_32)
		{
			this.bool_27 = bool_32;
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0009E7E0 File Offset: 0x0009C9E0
		public Format method_39()
		{
			return this.format_0;
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00010EBD File Offset: 0x0000F0BD
		public bool IsEnableSunShading()
		{
			return this.bool_28;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00010EC5 File Offset: 0x0000F0C5
		public void SetIsEnableSunShading(bool bool_32)
		{
			this.bool_28 = bool_32;
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00010ECE File Offset: 0x0000F0CE
		public bool method_42()
		{
			return this.bool_29;
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x0009E7F8 File Offset: 0x0009C9F8
		public double method_43()
		{
			return this.double_1;
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0009E810 File Offset: 0x0009CA10
		public double method_44()
		{
			return this.double_2;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x0009E828 File Offset: 0x0009CA28
		public double method_45()
		{
			return this.double_3;
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00010ED6 File Offset: 0x0000F0D6
		public bool method_46()
		{
			return this.bool_26;
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0009E840 File Offset: 0x0009CA40
		public float method_47()
		{
			return this.float_12;
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00010EDE File Offset: 0x0000F0DE
		public bool method_48()
		{
			return this.bool_30;
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x0009E858 File Offset: 0x0009CA58
		public float GetVerticalExaggeration()
		{
			return this.float_13;
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0009E870 File Offset: 0x0009CA70
		public void method_50(float float_14)
		{
			if (float_14 > 100f)
			{
				throw new ArgumentException("Vertical exaggeration out of range: " + float_14);
			}
			if (float_14 <= 0f)
			{
				this.float_13 = 1.401298E-45f;
			}
			else
			{
				this.float_13 = float_14;
			}
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x0009E8C0 File Offset: 0x0009CAC0
		public Enum150 method_51()
		{
			return this.enum150_0;
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x0009E8D8 File Offset: 0x0009CAD8
		public int method_52()
		{
			return this.int_24;
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x0009E8F0 File Offset: 0x0009CAF0
		public override string ToString()
		{
			return "World";
		}

		// Token: 0x04000AA7 RID: 2727
		internal bool bool_0;

		// Token: 0x04000AA8 RID: 2728
		internal bool bool_1 = true;

		// Token: 0x04000AA9 RID: 2729
		internal bool bool_2 = true;

		// Token: 0x04000AAA RID: 2730
		internal bool bool_3;

		// Token: 0x04000AAB RID: 2731
		internal string string_2 = "Tahoma";

		// Token: 0x04000AAC RID: 2732
		internal float float_0 = 9f;

		// Token: 0x04000AAD RID: 2733
		internal string string_3 = "Tahoma";

		// Token: 0x04000AAE RID: 2734
		internal float float_1 = 8f;

		// Token: 0x04000AAF RID: 2735
		internal FontStyle fontStyle_0 = FontStyle.Bold;

		// Token: 0x04000AB0 RID: 2736
		public int int_0 = Color.FromArgb(128, 128, 128, 128).ToArgb();

		// Token: 0x04000AB1 RID: 2737
		internal string string_4 = "Tahoma";

		// Token: 0x04000AB2 RID: 2738
		internal float float_2 = 9f;

		// Token: 0x04000AB3 RID: 2739
		internal int int_1 = 200;

		// Token: 0x04000AB4 RID: 2740
		internal bool bool_4;

		// Token: 0x04000AB5 RID: 2741
		internal bool bool_5;

		// Token: 0x04000AB6 RID: 2742
		internal int int_2 = 50;

		// Token: 0x04000AB7 RID: 2743
		internal bool bool_6 = true;

		// Token: 0x04000AB8 RID: 2744
		internal int int_3 = 60;

		// Token: 0x04000AB9 RID: 2745
		internal int int_4 = 300;

		// Token: 0x04000ABA RID: 2746
		internal bool bool_7;

		// Token: 0x04000ABB RID: 2747
		internal int int_5 = Color.FromArgb(50, 0, 0, 255).ToArgb();

		// Token: 0x04000ABC RID: 2748
		internal int int_6 = Color.FromArgb(50, 255, 0, 0).ToArgb();

		// Token: 0x04000ABD RID: 2749
		internal int int_7 = Color.FromArgb(180, 255, 255, 255).ToArgb();

		// Token: 0x04000ABE RID: 2750
		internal int int_8 = Color.FromArgb(170, 40, 40, 40).ToArgb();

		// Token: 0x04000ABF RID: 2751
		internal int int_9 = Color.FromArgb(150, 160, 160, 160).ToArgb();

		// Token: 0x04000AC0 RID: 2752
		internal int int_10 = Color.FromArgb(0, 0, 0, 255).ToArgb();

		// Token: 0x04000AC1 RID: 2753
		internal int int_11 = Color.FromArgb(170, 100, 100, 100).ToArgb();

		// Token: 0x04000AC2 RID: 2754
		internal int int_12 = Color.FromArgb(170, 255, 255, 255).ToArgb();

		// Token: 0x04000AC3 RID: 2755
		internal int int_13 = Color.FromArgb(100, 255, 255, 255).ToArgb();

		// Token: 0x04000AC4 RID: 2756
		internal bool bool_8 = true;

		// Token: 0x04000AC5 RID: 2757
		internal bool bool_9;

		// Token: 0x04000AC6 RID: 2758
		internal int int_14 = 300;

		// Token: 0x04000AC7 RID: 2759
		internal bool bool_10 = true;

		// Token: 0x04000AC8 RID: 2760
		private bool bool_11;

		// Token: 0x04000AC9 RID: 2761
		internal bool bool_12;

		// Token: 0x04000ACA RID: 2762
		public int int_15 = Color.FromArgb(200, 160, 160, 160).ToArgb();

		// Token: 0x04000ACB RID: 2763
		public int int_16 = Color.FromArgb(160, 64, 224, 208).ToArgb();

		// Token: 0x04000ACC RID: 2764
		internal bool bool_13 = true;

		// Token: 0x04000ACD RID: 2765
		public int int_17 = Color.FromArgb(160, 176, 224, 230).ToArgb();

		// Token: 0x04000ACE RID: 2766
		internal bool bool_14;

		// Token: 0x04000ACF RID: 2767
		internal bool showPlacenames = true;

		// Token: 0x04000AD0 RID: 2768
		internal bool bool_16;

		// Token: 0x04000AD1 RID: 2769
		internal int int_18 = Color.FromArgb(115, 155, 185).ToArgb();

		// Token: 0x04000AD2 RID: 2770
		internal bool bool_17 = true;

		// Token: 0x04000AD3 RID: 2771
		internal bool bool_18 = true;

		// Token: 0x04000AD4 RID: 2772
		internal Angle struct63_0 = Angle.FromDegrees(0.0);

		// Token: 0x04000AD5 RID: 2773
		internal Angle struct63_1 = Angle.FromDegrees(0.0);

		// Token: 0x04000AD6 RID: 2774
		internal double double_0 = 20000000.0;

		// Token: 0x04000AD7 RID: 2775
		internal Angle struct63_2 = Angle.FromDegrees(0.0);

		// Token: 0x04000AD8 RID: 2776
		internal Angle struct63_3 = Angle.FromDegrees(0.0);

		// Token: 0x04000AD9 RID: 2777
		internal bool bool_19 = true;

		// Token: 0x04000ADA RID: 2778
		internal bool bool_20 = true;

		// Token: 0x04000ADB RID: 2779
		internal bool bool_21 = true;

		// Token: 0x04000ADC RID: 2780
		internal bool bool_22;

		// Token: 0x04000ADD RID: 2781
		internal bool bool_23 = true;

		// Token: 0x04000ADE RID: 2782
		internal bool bool_24 = true;

		// Token: 0x04000ADF RID: 2783
		internal float float_3 = 0.35f;

		// Token: 0x04000AE0 RID: 2784
		internal float float_4 = 0.05f;

		// Token: 0x04000AE1 RID: 2785
		internal float float_5 = 0.05f;

		// Token: 0x04000AE2 RID: 2786
		internal Angle cameraFov = Angle.FromRadians(0.78539816339744828);

		// Token: 0x04000AE3 RID: 2787
		internal Angle cameraFovMin = Angle.FromDegrees(5.0);

		// Token: 0x04000AE4 RID: 2788
		internal Angle cameraFovMax = Angle.FromDegrees(150.0);

		// Token: 0x04000AE5 RID: 2789
		internal float cameraZoomStepFactor = 0.015f;

		// Token: 0x04000AE6 RID: 2790
		internal float float_7 = 10f;

		// Token: 0x04000AE7 RID: 2791
		internal float float_8 = 1f;

		// Token: 0x04000AE8 RID: 2792
		internal float float_9 = 0.15f;

		// Token: 0x04000AE9 RID: 2793
		internal float float_10 = 3.5f;

		// Token: 0x04000AEA RID: 2794
		internal bool bool_25 = true;

		// Token: 0x04000AEB RID: 2795
		private float float_11 = 2f;

		// Token: 0x04000AEC RID: 2796
		private Format format_0 = Format.Dxt3;

		// Token: 0x04000AED RID: 2797
		private bool bool_26;

		// Token: 0x04000AEE RID: 2798
		private bool bool_27 = true;

		// Token: 0x04000AEF RID: 2799
		private bool bool_28;

		// Token: 0x04000AF0 RID: 2800
		private bool bool_29 = true;

		// Token: 0x04000AF1 RID: 2801
		private double double_1 = 0.78539816339744828;

		// Token: 0x04000AF2 RID: 2802
		private double double_2 = -0.78539816339744828;

		// Token: 0x04000AF3 RID: 2803
		private double double_3 = 150000000000.0;

		// Token: 0x04000AF4 RID: 2804
		private int int_19 = Color.FromArgb(50, 50, 50).ToArgb();

		// Token: 0x04000AF5 RID: 2805
		private int int_20 = Color.FromArgb(64, 64, 64).ToArgb();

		// Token: 0x04000AF6 RID: 2806
		private float float_12 = 3f;

		// Token: 0x04000AF7 RID: 2807
		private bool bool_30 = true;

		// Token: 0x04000AF8 RID: 2808
		private float float_13 = 3f;

		// Token: 0x04000AF9 RID: 2809
		internal int int_21 = Color.FromArgb(222, 0, 255, 0).ToArgb();

		// Token: 0x04000AFA RID: 2810
		internal int int_22 = Color.FromArgb(255, 255, 0, 0).ToArgb();

		// Token: 0x04000AFB RID: 2811
		private Enum150 enum150_0 = Enum150.const_1;

		// Token: 0x04000AFC RID: 2812
		private TimeSpan timeSpan_0 = TimeSpan.FromMinutes(30.0);

		// Token: 0x04000AFD RID: 2813
		internal int int_23 = Color.FromArgb(50, 128, 168, 128).ToArgb();

		// Token: 0x04000AFE RID: 2814
		internal ArrayList arrayList_0 = new ArrayList();

		// Token: 0x04000AFF RID: 2815
		internal bool bool_31 = true;

		// Token: 0x04000B00 RID: 2816
		internal int int_24 = 1;
	}
}
