using System;
using System.Data.SQLite;
using Command_Core.DAL;

namespace ns2
{
	// 武器的目标
	public sealed class WeaponTarget
	{
		// 构造函数
		private WeaponTarget()
		{
		}

		// Token: 0x060061BE RID: 25022 RVA: 0x002F4DF8 File Offset: 0x002F2FF8
		public WeaponTarget(int ID, ref SQLiteConnection sqliteConnection_0)
		{
			WeaponTarget weaponTarget = this;
			DBFunctions.LoadWeaponTargets(ref weaponTarget, ID, ref sqliteConnection_0);
		}

		// 是否水面舰艇
		public bool IsSurfaceShip;

		// 是否水面/地面下的目标
		public bool IsSubsurface;

		// 是否飞机
		public bool IsAircraft;

		// 是否制导武器
		public bool IsGuidedWeapon;

		// 是否卫星
		public bool IsSatellite;

		// 是否雷达
		public bool IsRadar;

		// 是否跑道
		public bool IsRunway;

		// 软地面
		public bool IsSoftLandStructures;

		// 硬地面
		public bool IsHardLandStructures;
        
		// 鱼雷 
		public bool IsTorpedoe;

		// 地雷
		public bool IsMine;

		// 直升机
		public bool IsHelicopter;

		// 软性移动单元
		public bool IsSoftMobileUnit;

		// 刚体可移动单元
		public bool IsHardMobileUnit;

		// 水下
		public bool IsUnderwaterStructure;

		// Token: 0x0400352C RID: 13612
		public bool bool_15;

		// 空域？
		public bool IsAirfield;
	}
}
