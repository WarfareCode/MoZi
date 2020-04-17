using System;

namespace Command_Core
{
	// Token: 全局变量
	public sealed class GlobalVariables
	{
		// Token: 0x02000CDA RID: 3290
		public enum ProficiencyLevel
		{
			// Token: 0x04003DEC RID: 15852
			Novice,
			// Token: 0x04003DED RID: 15853
			Cadet,
			// Token: 0x04003DEE RID: 15854
			Regular,
			// Token: 0x04003DEF RID: 15855
			Veteran,
			// Token: 0x04003DF0 RID: 15856
			Ace
		}

		// Token: 0x02000CDB RID: 3291
		public enum ArmorRating : short
		{
			// Token: 0x04003DF2 RID: 15858
			None = 1001,
			// Token: 0x04003DF3 RID: 15859
			Armor_Handgun = 1005,
			// Token: 0x04003DF4 RID: 15860
			Armor_Rifle = 1010,
			// Token: 0x04003DF5 RID: 15861
			Armor_HMG = 1015,
			// Token: 0x04003DF6 RID: 15862
			RHA_20mm = 1020,
			// Token: 0x04003DF7 RID: 15863
			RHA_25mm = 1025,
			// Token: 0x04003DF8 RID: 15864
			RHA_30mm = 1030,
			// Token: 0x04003DF9 RID: 15865
			RHA_35mm = 1035,
			// Token: 0x04003DFA RID: 15866
			Light = 2001,
			// Token: 0x04003DFB RID: 15867
			Medium,
			// Token: 0x04003DFC RID: 15868
			Heavy,
			// Token: 0x04003DFD RID: 15869
			Special
		}

		// Token: 0x02000CDC RID: 3292
		public enum PatrolType : byte
		{
			// Token: 0x04003DFF RID: 15871
			ASW,
			// Token: 0x04003E00 RID: 15872
			ASuW_Naval,
			// Token: 0x04003E01 RID: 15873
			AAW,
			// Token: 0x04003E02 RID: 15874
			ASuW_Land,
			// Token: 0x04003E03 RID: 15875
			ASuW_Mixed,
			// Token: 0x04003E04 RID: 15876
			SEAD,
			// Token: 0x04003E05 RID: 15877
			SeaControl
		}

		// Token: 0x02000CDD RID: 3293
		public enum TargetVisualSizeClass : byte
		{
			// Token: 0x04003E07 RID: 15879
			Stealthy,
			// Token: 0x04003E08 RID: 15880
			VSmall,
			// Token: 0x04003E09 RID: 15881
			Small,
			// Token: 0x04003E0A RID: 15882
			Medium,
			// Token: 0x04003E0B RID: 15883
			Large,
			// Token: 0x04003E0C RID: 15884
			VLarge,
			// Token: 0x04003E0D RID: 15885
			Unknown
		}

		// Token: 0x02000CDE RID: 3294
		public enum Enum104 : byte
		{
			// Token: 0x04003E0F RID: 15887
			const_0,
			// Token: 0x04003E10 RID: 15888
			const_1,
			// Token: 0x04003E11 RID: 15889
			const_2,
			// Token: 0x04003E12 RID: 15890
			const_3,
			// Token: 0x04003E13 RID: 15891
			const_4
		}

		// Token: 0x02000CDF RID: 3295
		public enum ActiveUnitType : byte
		{
			// Token: 0x04003E15 RID: 15893
			None,
			// Token: 0x04003E16 RID: 15894
			Aircraft,
			// Token: 0x04003E17 RID: 15895
			Ship,
			// Token: 0x04003E18 RID: 15896
			Submarine,
			// Token: 0x04003E19 RID: 15897
			Facility,
			// Token: 0x04003E1A RID: 15898
			Aimpoint,
			// Token: 0x04003E1B RID: 15899
			Weapon,
			// Token: 0x04003E1C RID: 15900
			Satellite
		}

		// Token: 0x02000CE0 RID: 3296
		public enum AircraftSizeClass : byte
		{
			// Token: 0x04003E1E RID: 15902
			None,
			// Token: 0x04003E1F RID: 15903
			Small,
			// Token: 0x04003E20 RID: 15904
			Medium,
			// Token: 0x04003E21 RID: 15905
			Large,
			// Token: 0x04003E22 RID: 15906
			VLarge
		}

		// Token: 0x02000CE1 RID: 3297
		public enum _RunwayLengthCode
		{
			// Token: 0x04003E24 RID: 15908
			None = 1001,
			// Token: 0x04003E25 RID: 15909
			TOD_LAD_0m_VTOL = 2001,
			// Token: 0x04003E26 RID: 15910
			TOD_LAD_1_450m,
			// Token: 0x04003E27 RID: 15911
			TOD_LAD_451_900m,
			// Token: 0x04003E28 RID: 15912
			TOD_LAD_901_1400m,
			// Token: 0x04003E29 RID: 15913
			TOD_LAD_1401_2000m,
			// Token: 0x04003E2A RID: 15914
			TOD_LAD_2001_2600m,
			// Token: 0x04003E2B RID: 15915
			TOD_LAD_2601_3200m,
			// Token: 0x04003E2C RID: 15916
			TOD_LAD_3201_4000m,
			// Token: 0x04003E2D RID: 15917
			TOD_LAD_4001_5600m
		}

		// Token: 0x02000CE2 RID: 3298
		public enum TechGenerationClass
		{
			// Token: 0x04003E2F RID: 15919
			None = 1001,
			// Token: 0x04003E30 RID: 15920
			NotApplicable,
			// Token: 0x04003E31 RID: 15921
			Early1950s = 2001,
			// Token: 0x04003E32 RID: 15922
			Late1950s,
			// Token: 0x04003E33 RID: 15923
			Early1960s,
			// Token: 0x04003E34 RID: 15924
			Late1960s,
			// Token: 0x04003E35 RID: 15925
			Early1970s,
			// Token: 0x04003E36 RID: 15926
			Late1970s,
			// Token: 0x04003E37 RID: 15927
			Early1980s,
			// Token: 0x04003E38 RID: 15928
			Late1980s,
			// Token: 0x04003E39 RID: 15929
			Early1990s,
			// Token: 0x04003E3A RID: 15930
			Late1990s,
			// Token: 0x04003E3B RID: 15931
			Early2000s,
			// Token: 0x04003E3C RID: 15932
			Late2000s,
			// Token: 0x04003E3D RID: 15933
			Early2010s,
			// Token: 0x04003E3E RID: 15934
			Late2010s,
			// Token: 0x04003E3F RID: 15935
			IR_SingleSpectral = 3001,
			// Token: 0x04003E40 RID: 15936
			IR_DualSpectral,
			// Token: 0x04003E41 RID: 15937
			IR_Imaging_FPA
		}
	}
}
