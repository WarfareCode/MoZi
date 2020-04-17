using System;
using System.Diagnostics;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1
{
	// Token: 0x02000ABE RID: 2750
	public sealed class Facility_Kinematics : ActiveUnit_Kinematics
	{
		// Token: 0x060057DF RID: 22495 RVA: 0x002691FC File Offset: 0x002673FC
		private Facility GetParentPlatform()
		{
			if (Information.IsNothing(this.ParentPlatform))
			{
				this.ParentPlatform = (Facility)this.activeUnit;
			}
			return this.ParentPlatform;
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x00027D9E File Offset: 0x00025F9E
		public Facility_Kinematics(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x060057E1 RID: 22497 RVA: 0x00269234 File Offset: 0x00267434
		public override ActiveUnit.Throttle vmethod_38(float float_5, float float_6)
		{
			ActiveUnit.Throttle result;
			if (float_6 == 0f)
			{
				result = ActiveUnit.Throttle.FullStop;
			}
			else if (float_6 == 25f)
			{
				result = ActiveUnit.Throttle.Flank;
			}
			else
			{
				result = ActiveUnit.Throttle.Cruise;
			}
			return result;
		}

		// Token: 0x060057E2 RID: 22498 RVA: 0x000E44EC File Offset: 0x000E26EC
		public override float vmethod_20(bool bool_2, float? nullable_2, float? nullable_3)
		{
			return 3.40282347E+38f;
		}

		// Token: 0x060057E3 RID: 22499 RVA: 0x0026926C File Offset: 0x0026746C
		public override float GetTurnRate()
		{
			return 45f;
		}

		// Token: 0x060057E4 RID: 22500 RVA: 0x00269280 File Offset: 0x00267480
		public override float vmethod_9(ActiveUnit.Throttle throttle_0, float float_5)
		{
			return 2f;
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x00269280 File Offset: 0x00267480
		public override float vmethod_8(ActiveUnit.Throttle throttle, float altitude_ASL, float float_6)
		{
			return 2f;
		}

		// Token: 0x060057E6 RID: 22502 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool HasFlankAltBand()
		{
			return true;
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x00269294 File Offset: 0x00267494
		public override int GetSpeed(float float_5)
		{
			return this.GetMaxSpeed();
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x002692AC File Offset: 0x002674AC
		public override int GetMaxSpeed()
		{
			int result = 0;
			try
			{
				float num;
				if (this.GetParentPlatform().GetMobileUnitCategory() == Facility._MobileUnitCategory.Infrantry)
				{
					num = 5f;
				}
				else
				{
					num = 30f;
				}
				float num2 = Terrain.smethod_5(this.activeUnit.GetLatitude(null), this.activeUnit.GetLongitude(null), false);
				if ((double)num2 > 0.5)
				{
					result = (int)Math.Round((double)Math.Max(1f, num / 10f));
				}
				else
				{
					result = (int)Math.Round((double)Math.Max(num / 10f, num * (1f - num2)));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100559", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060057E9 RID: 22505 RVA: 0x002693B4 File Offset: 0x002675B4
		public override void UpdateUnitPositions(float float_5, bool bool_2, bool bool_3)
		{
			try
			{
				if (this.activeUnit.IsFixedFacility())
				{
					ActiveUnit_Kinematics.ExportUnitPositions(this.activeUnit);
				}
				else
				{
					if (this.activeUnit.GetAI().HoldPosition)
					{
						this.activeUnit.SetDesiredSpeed(0f);
					}
					base.UpdateUnitPositions(float_5, false, false);
					this.activeUnit.SetAltitude_ASL(false, (float)this.activeUnit.GetTerrainElevation(false, false, false));
					if (this.activeUnit.GetCommStuff().IsNotOutOfComms())
					{
						this.activeUnit.SetLongitudeLR(new double?(this.activeUnit.GetLongitude(null)));
						this.activeUnit.SetLatitudeLR(new double?(this.activeUnit.GetLatitude(null)));
					}
					else
					{
						if (!this.activeUnit.GetLongitudeLR().HasValue)
						{
							this.activeUnit.SetLongitudeLR(new double?(this.activeUnit.GetLongitude(null)));
						}
						if (!this.activeUnit.GetLatitudeLR().HasValue)
						{
							this.activeUnit.SetLatitudeLR(new double?(this.activeUnit.GetLatitude(null)));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100560", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x04002B44 RID: 11076
		private Facility ParentPlatform;
	}
}
