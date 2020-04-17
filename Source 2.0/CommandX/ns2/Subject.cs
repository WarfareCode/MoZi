using System;
using Command_Core;

namespace ns2
{
	// Token: 0x020001B8 RID: 440
	public class Subject
	{
		// Token: 0x060009AC RID: 2476 RVA: 0x0006CAE8 File Offset: 0x0006ACE8
		public Subject()
		{
			this.lazy_Guid = new Lazy<string>(new Func<string>(this.GetGuidString));
			this.IsGroup = false;
			this.IsWeapon = false;
			this.IsAircraft = false;
			this.IsSubmarine = false;
			this.IsShip = false;
			this.IsFacility = false;
			this.IsMission = false;
			this.IsWayPoint = false;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0006CB4C File Offset: 0x0006AD4C
		public string GetGuid()
		{
			return this.lazy_Guid.Value;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x000091EE File Offset: 0x000073EE
		public void SetGuid(string string_2)
		{
			this.strGuid = string_2;
			this.lazy_Guid = null;
			this.lazy_Guid = new Lazy<string>(new Func<string>(this.GetGuidString));
			string arg_30_0 = this.lazy_Guid.Value;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0006CB68 File Offset: 0x0006AD68
		private string GetGuidString()
		{
			string result;
			if (string.IsNullOrEmpty(this.strGuid))
			{
				result = Guid.NewGuid().ToString();
			}
			else
			{
				result = this.strGuid;
			}
			return result;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00009221 File Offset: 0x00007421
		public virtual void ClearGuid()
		{
			this.lazy_Guid = null;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual bool IsActiveUnit()
		{
			return false;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0000922A File Offset: 0x0000742A
		public bool IsGuidedWeapon()
		{
			return this.IsWeapon && ((Weapon)this).GetWeaponType() == Weapon._WeaponType.GuidedWeapon;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00009249 File Offset: 0x00007449
		public bool IsSatellite()
		{
			return base.GetType() == typeof(Satellite);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x000081A2 File Offset: 0x000063A2
		public virtual bool IsGuidedProjectile()
		{
			return false;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0006CBAC File Offset: 0x0006ADAC
		public bool IsGuidedWeapon_RV_HGV()
		{
			bool result;
			if (this.IsWeapon)
			{
				Weapon weapon = (Weapon)this;
				result = (weapon.GetWeaponType() == Weapon._WeaponType.GuidedWeapon | weapon.IsRVorHGV() | weapon.IsHypersonicGlideVehicle());
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00009260 File Offset: 0x00007460
		public bool IsDecoyVehicle()
		{
			return this.IsWeapon && ((Weapon)this).GetWeaponType() == Weapon._WeaponType.Decoy_Vehicle;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0000927F File Offset: 0x0000747F
		public virtual bool IsTorpedo()
		{
			return this.IsWeapon && ((Weapon)this).GetWeaponType() == Weapon._WeaponType.Torpedo;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x000081A2 File Offset: 0x000063A2
		public bool method_7()
		{
			return false;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0000929E File Offset: 0x0000749E
		public bool IsFixedFacility()
		{
			return this.IsFacility && !((Facility)this).IsMobile();
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x000092B9 File Offset: 0x000074B9
		public bool MountsAreAimpoints()
		{
			return this.IsFacility && ((Facility)this).MountsAreAimpoints;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x000092D1 File Offset: 0x000074D1
		public bool AreAimpoints()
		{
			return base.GetType() == typeof(Mount) && ((Mount)this).GetParentPlatform().MountsAreAimpoints();
		}

		// Token: 0x04000403 RID: 1027
		private Lazy<string> lazy_Guid;

		// Token: 0x04000404 RID: 1028
		private string strGuid;

		// Token: 0x04000405 RID: 1029
		public string Name;

		// Token: 0x04000406 RID: 1030
		public bool IsGroup;

		// Token: 0x04000407 RID: 1031
		public bool IsWeapon;

		// Token: 0x04000408 RID: 1032
		public bool IsAircraft;

		// Token: 0x04000409 RID: 1033
		public bool IsSubmarine;

		// Token: 0x0400040A RID: 1034
		public bool IsShip;

		// Token: 0x0400040B RID: 1035
		public bool IsFacility;

		// Token: 0x0400040C RID: 1036
		public bool IsMission;

		// Token: 0x0400040D RID: 1037
		public bool IsWayPoint;
	}
}
