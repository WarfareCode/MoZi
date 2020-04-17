using System;
using Command_Core;
using ns3;

namespace ns1
{
	// 运动学
	public sealed class HGV_Kinematics : Weapon_Kinematics
	{
		// 构造函数
		public HGV_Kinematics(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x0600567C RID: 22140 RVA: 0x00252900 File Offset: 0x00250B00
		public override float vmethod_18()
		{
			return 1.5f;
		}

		// Token: 0x0600567D RID: 22141 RVA: 0x00252914 File Offset: 0x00250B14
		public override float vmethod_17()
		{
			return 4f;
		}

		// Token: 0x0600567E RID: 22142 RVA: 0x00252080 File Offset: 0x00250280
		public override float vmethod_16()
		{
			return 25f;
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x00252928 File Offset: 0x00250B28
		public override void SetAltitude_ASL(float elapsedTime, float desiredAltitude_, float? allowedMinAltitude_)
		{
			this.activeUnit.SetPreviousAltitude_ASL(this.activeUnit.GetCurrentAltitude_ASL(false));
			if (this.activeUnit.GetPitch() != 0f)
			{
				double num = Math2.Sin_D((double)this.activeUnit.GetPitch()) * (double)this.activeUnit.GetCurrentSpeed();
				ActiveUnit activeUnit;
				(activeUnit = this.activeUnit).SetAltitude_ASL(false, activeUnit.GetCurrentAltitude_ASL(false) + (float)num);
			}
		}
	}
}
