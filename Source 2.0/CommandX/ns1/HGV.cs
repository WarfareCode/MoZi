using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;

namespace ns1
{
	// 高超音速滑翔弹
	public sealed class HGV : Weapon
	{
		// 构造函数
		public HGV() : base(null)
		{
			this.IsWeapon = true;
			base.SetWeaponType(Weapon._WeaponType.HGV); // 设置武器类型
			base.SetCruiseAltitude_ASL(100000f);        // 设置巡航高度
			this.SetPitch(0f);                          // 设置俯仰角
			this.SetRoll(0f);                           // 设置滚转角
		}

		// 构造函数
		public HGV(ref Scenario theScen, int WeaponDBID, string theGUID = null) : base(null)
		{
			this.IsWeapon = true;   // 是否武器
			base.SetWeaponType(Weapon._WeaponType.HGV);
			base.SetCruiseAltitude_ASL(100000f);
			this.SetPitch(0f);
			this.SetRoll(0f);
		}

		// 取AI，虚函数
		public override Weapon_AI GetWeaponAI()
		{
			if (Information.IsNothing(this.hgb_AI))
			{
				this.hgb_AI = new HGV_AI(this);
			}
			return this.hgb_AI;
		}

		// 取动力学
		public override Weapon_Kinematics GetWeaponKinematics()
		{
			if (Information.IsNothing(this.hgv_Kinematics))
			{
				ActiveUnit activeUnit = this;
				this.hgv_Kinematics = new HGV_Kinematics(ref activeUnit);
			}
			return this.hgv_Kinematics;
		}

		// 是否高超声速滑翔弹
		internal override bool IsHypersonicGlideVehicle()
		{
			return true;
		}

		// Token: 0x0600568F RID: 22159 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool IsOfAirLaunchedGuidedWeapon()
		{
			return true;
		}

		// 取俯仰角
		public override float GetPitch()
		{
			return this.Pitch;
		}

		// 设置俯仰角
		public override void SetPitch(float float_47)
		{
			this.Pitch = float_47;
		}

		// Token: 0x06005692 RID: 22162 RVA: 0x0006D5D0 File Offset: 0x0006B7D0
		public override float vmethod_19()
		{
			return this.float_5;
		}

		// Token: 0x06005693 RID: 22163 RVA: 0x00009346 File Offset: 0x00007546
		public override void vmethod_20(float float_47)
		{
			this.float_5 = float_47;
		}

		// 取海拔高
		public override float GetCurrentAltitude_ASL(bool DoSanityCheck = false)
		{
			return base.GetCurrentAltitude_ASL(DoSanityCheck);
		}

		// 设置海拔高
		public override void SetAltitude_ASL(bool DoSanityCheck, float value)
		{
			if (DoSanityCheck && base.IsGuidedWeapon() && value < 6.09599972f)
			{
				value = 6.09599972f;
			}
			this.GetCurrentAltitude_ASL(false);
			base.SetAltitude_ASL(DoSanityCheck, value);
		}

		// 载入
		public static HGV Load(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_1, bool bool_21)
		{
			HGV result = null;
			try
			{
				HGV hGV = new HGV();
				hGV.m_Scenario = scenario_1;
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					result = (HGV)dictionary_0[innerText];
				}
				else
				{
					hGV.SetGuid(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						result = hGV;
					}
					else
					{
						dictionary_0.Add(hGV.GetGuid(), hGV);
						int weaponDBID = Conversions.ToInteger(Misc.smethod_48(xmlNode_0.ChildNodes, "DBID").InnerText);
						DBFunctions.LoadWeaponData(scenario_1.GetSQLiteConnection(), hGV, weaponDBID, scenario_1, bool_21);
						if (hGV.IsHypersonicGlideVehicle())
						{
							hGV.SetCruiseAltitude_ASL(100000f);
						}
						if (bool_21)
						{
							hGV.LoadAirFacilities(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						}
						if (!bool_21)
						{
							Weapon.smethod_3(hGV, scenario_1, xmlNode_0, dictionary_0);
						}
						Weapon.smethod_5(hGV, scenario_1, xmlNode_0, dictionary_0);
						float maxAltitude = hGV.GetWeaponKinematics().GetMaxAltitude();
						float minAltitude = hGV.GetWeaponKinematics().GetMinAltitude();
						if (hGV.GetCurrentAltitude_ASL(false) > maxAltitude && (hGV.GetWeaponType() == Weapon._WeaponType.GuidedWeapon || hGV.GetWeaponType() == Weapon._WeaponType.Torpedo))
						{
							hGV.SetAltitude_ASL(false, maxAltitude);
						}
						else if (hGV.GetCurrentAltitude_ASL(false) < minAltitude && (hGV.GetWeaponType() == Weapon._WeaponType.GuidedWeapon || hGV.GetWeaponType() == Weapon._WeaponType.Torpedo))
						{
							hGV.SetAltitude_ASL(false, minAltitude);
						}
						if (hGV.GetDesiredAltitude() > maxAltitude && (hGV.GetWeaponType() == Weapon._WeaponType.GuidedWeapon || hGV.GetWeaponType() == Weapon._WeaponType.Torpedo))
						{
							hGV.SetDesiredAltitude(maxAltitude);
						}
						else if (hGV.GetDesiredAltitude() < minAltitude && (hGV.GetWeaponType() == Weapon._WeaponType.GuidedWeapon || hGV.GetWeaponType() == Weapon._WeaponType.Torpedo))
						{
							hGV.SetDesiredAltitude(minAltitude);
						}
						result = hGV;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100882", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new HGV();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// AI
		private HGV_AI hgb_AI;

		// 动力学
		private HGV_Kinematics hgv_Kinematics;
	}
}
