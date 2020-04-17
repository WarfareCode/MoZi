using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace Command_Core
{
	// Token: 0x02000AF5 RID: 2805
	public sealed class Group_Kinematics : ActiveUnit_Kinematics
	{
		// Token: 0x06005A89 RID: 23177 RVA: 0x00282AA8 File Offset: 0x00280CA8
		public override void Save(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteElementString("AMV", XmlConvert.ToString(this.ActualMovementVector));
				if (this.GetDesiredSpeedOverride().HasValue)
				{
					xmlWriter_0.WriteElementString("DSO", this.GetDesiredSpeedOverride().ToString());
				}
				xmlWriter_0.WriteElementString("DAO", this.GetDesiredAltitudeOverride().ToString());
				xmlWriter_0.WriteElementString("LATSD", this.LATSD.ToString());
				xmlWriter_0.WriteElementString("SP", ((byte)this.GetSpeedPreset()).ToString());
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100612", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x00282B9C File Offset: 0x00280D9C
		public static Group_Kinematics Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Group_Kinematics result;
			try
			{
				Group_Kinematics group_Kinematics = new Group_Kinematics(ref activeUnit_1);
				group_Kinematics.activeUnit = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1633936287u)
						{
							if (num != 154738112u)
							{
								if (num != 316182301u)
								{
									if (num != 1633936287u)
									{
										continue;
									}
									if (Operators.CompareString(name, "AMV", false) != 0)
									{
										continue;
									}
									goto IL_174;
								}
								else if (Operators.CompareString(name, "DSO", false) != 0)
								{
									continue;
								}
							}
							else if (Operators.CompareString(name, "DesiredSpeedOverride", false) != 0)
							{
								continue;
							}
							if (Operators.CompareString(xmlNode.InnerText, true.ToString(), false) != 0 && Operators.CompareString(xmlNode.InnerText, false.ToString(), false) != 0)
							{
								group_Kinematics.SetDesiredSpeedOverride(new float?(XmlConvert.ToSingle(xmlNode.InnerText)));
								continue;
							}
							if (Operators.CompareString(xmlNode.InnerText, true.ToString(), false) == 0)
							{
								group_Kinematics.SetDesiredSpeedOverride(new float?(activeUnit_1.GetDesiredSpeed()));
								continue;
							}
							continue;
						}
						else if (num <= 2788980997u)
						{
							if (num != 1728224374u)
							{
								if (num != 2788980997u || Operators.CompareString(name, "ActualMovementVector", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "SP", false) == 0)
								{
									group_Kinematics.SetSpeedPreset((ActiveUnit_Kinematics._SpeedPreset)Conversions.ToByte(xmlNode.InnerText));
									continue;
								}
								continue;
							}
						}
						else if (num != 3498149545u)
						{
							if (num == 3806043832u && Operators.CompareString(name, "ClimbRate", false) == 0)
							{
								group_Kinematics.SetClimbRate(XmlConvert.ToSingle(xmlNode.InnerText));
								continue;
							}
							continue;
						}
						else
						{
							if (Operators.CompareString(name, "LATSD", false) == 0)
							{
								group_Kinematics.LATSD = Conversions.ToBoolean(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						IL_174:
						group_Kinematics.ActualMovementVector = XmlConvert.ToSingle(xmlNode.InnerText);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = group_Kinematics;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100613", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Group_Kinematics(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x00028B1C File Offset: 0x00026D1C
		public Group_Kinematics(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
			this.LATSD = true;
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x00028B33 File Offset: 0x00026D33
		public bool GetLATSD()
		{
			return this.LATSD;
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x00282E6C File Offset: 0x0028106C
		public void method_18(bool bool_3)
		{
			this.LATSD = bool_3;
			if (bool_3 && !Information.IsNothing(((Group)this.activeUnit).GetGroupLead()))
			{
				((Group)this.activeUnit).GetGroupLead().GetKinematics().SetDesiredSpeedOverride(null);
			}
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x00282EC0 File Offset: 0x002810C0
		public void method_19()
		{
			if (!Information.IsNothing(((Group)this.activeUnit).GetGroupLead()))
			{
				this.activeUnit.SetLongitude(null, ((Group)this.activeUnit).GetGroupLead().GetLongitude(null));
				this.activeUnit.SetLatitude(null, ((Group)this.activeUnit).GetGroupLead().GetLatitude(null));
				this.activeUnit.SetAltitude_ASL(false, ((Group)this.activeUnit).GetGroupLead().GetCurrentAltitude_ASL(false));
				this.activeUnit.SetCurrentHeading(((Group)this.activeUnit).GetGroupLead().GetCurrentHeading());
				this.activeUnit.SetCurrentSpeed(((Group)this.activeUnit).GetGroupLead().GetCurrentSpeed());
			}
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void UpdateUnitPositions(float elapsedTime, bool bool_3, bool bool_4)
		{
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x00282FB0 File Offset: 0x002811B0
		public override float? GetDesiredSpeedOverride()
		{
			float? result = null;
			if (!Information.IsNothing(((Group)this.activeUnit).GetGroupLead()))
			{
				result = ((Group)this.activeUnit).GetGroupLead().GetKinematics().GetDesiredSpeedOverride();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x00283004 File Offset: 0x00281204
		public override void SetDesiredSpeedOverride(float? nullable_2)
		{
			try
			{
				if (!Information.IsNothing(((Group)this.activeUnit).GetGroupLead()))
				{
					((Group)this.activeUnit).GetGroupLead().GetKinematics().SetDesiredSpeedOverride(nullable_2);
				}
				foreach (ActiveUnit current in ((Group)this.activeUnit).GetUnitsInGroup().Values)
				{
					if (!current.IsGroupLead())
					{
						current.GetKinematics().SetDesiredSpeedOverride(null);
					}
				}
				if (Information.IsNothing(nullable_2))
				{
					this.activeUnit.GetKinematics().SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset.None);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100614", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x00283118 File Offset: 0x00281318
		public override ActiveUnit_Kinematics._SpeedPreset GetSpeedPreset()
		{
			ActiveUnit_Kinematics._SpeedPreset result;
			if (!Information.IsNothing(((Group)this.activeUnit).GetGroupLead()))
			{
				result = ((Group)this.activeUnit).GetGroupLead().GetKinematics().GetSpeedPreset();
			}
			else
			{
				result = ActiveUnit_Kinematics._SpeedPreset.FullStop;
			}
			return result;
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x00283160 File Offset: 0x00281360
		public override void SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset enum6_1)
		{
			try
			{
				if (!Information.IsNothing(((Group)this.activeUnit).GetGroupLead()))
				{
					((Group)this.activeUnit).GetGroupLead().GetKinematics().SetSpeedPreset(enum6_1);
				}
				foreach (ActiveUnit current in ((Group)this.activeUnit).GetUnitsInGroup().Values)
				{
					if (!current.IsGroupLead())
					{
						current.GetKinematics().SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset.None);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100615", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x00028B3B File Offset: 0x00026D3B
		public override bool GetDesiredAltitudeOverride()
		{
			return !Information.IsNothing(((Group)this.activeUnit).GetGroupLead()) && ((Group)this.activeUnit).GetGroupLead().GetKinematics().GetDesiredAltitudeOverride();
		}

		// Token: 0x06005A95 RID: 23189 RVA: 0x0028324C File Offset: 0x0028144C
		public override void SetDesiredAltitudeOverride(bool bool_3)
		{
			try
			{
				if (!Information.IsNothing(((Group)this.activeUnit).GetGroupLead()))
				{
					((Group)this.activeUnit).GetGroupLead().GetKinematics().SetDesiredAltitudeOverride(bool_3);
				}
				foreach (ActiveUnit current in ((Group)this.activeUnit).GetUnitsInGroup().Values)
				{
					if (!current.IsGroupLead())
					{
						current.GetKinematics().SetDesiredAltitudeOverride(false);
					}
				}
				if (!bool_3)
				{
					if (this.activeUnit.IsGroup && ((Group)this.activeUnit).GetGroupType() == Group.GroupType.SubGroup)
					{
						((Group_AI)this.activeUnit.GetAI()).method_88(ActiveUnit_AI._DepthPreset.None);
					}
					if (this.activeUnit.IsGroup && ((Group)this.activeUnit).GetGroupType() == Group.GroupType.AirGroup)
					{
						((Group_AI)this.activeUnit.GetAI()).method_89(ActiveUnit_AI._AltitudePreset.None);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100616", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005A96 RID: 23190 RVA: 0x002833CC File Offset: 0x002815CC
		public override float GetMaxAltitude()
		{
			Group.GroupType groupType = ((Group)this.activeUnit).GetGroupType();
			float result;
			if (groupType != Group.GroupType.SurfaceGroup && groupType - Group.GroupType.Installation > 2)
			{
				IEnumerable<ActiveUnit> source = ((Group)this.activeUnit).GetUnitsInGroup().Values.OrderByDescending(Group_Kinematics.ActiveUnitFunc0);
				if (source.Count<ActiveUnit>() == 0)
				{
					result = 0f;
				}
				else
				{
					result = source.ElementAtOrDefault(0).GetKinematics().GetMaxAltitude();
				}
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x06005A97 RID: 23191 RVA: 0x00283458 File Offset: 0x00281658
		public override float GetMinAltitude()
		{
			Group.GroupType groupType = ((Group)this.activeUnit).GetGroupType();
			float result;
			if (groupType != Group.GroupType.SurfaceGroup && groupType - Group.GroupType.Installation > 2)
			{
				IEnumerable<ActiveUnit> source = ((Group)this.activeUnit).GetUnitsInGroup().Values.OrderBy(Group_Kinematics.ActiveUnitFunc1);
				if (source.Count<ActiveUnit>() == 0)
				{
					result = 0f;
				}
				else
				{
					result = source.ElementAtOrDefault(0).GetKinematics().GetMinAltitude();
				}
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x06005A98 RID: 23192 RVA: 0x002834E4 File Offset: 0x002816E4
		public override float GetMinSpeed(float float_5)
		{
			return ((Group)this.activeUnit).GetGroupLead().GetKinematics().GetMinSpeed(float_5);
		}

		// Token: 0x06005A99 RID: 23193 RVA: 0x00283510 File Offset: 0x00281710
		public override int GetSpeed(float float_5, ActiveUnit.Throttle throttle_0)
		{
			int result;
			if (Information.IsNothing(((Group)this.activeUnit).GetGroupLead()))
			{
				result = 0;
			}
			else
			{
				result = ((Group)this.activeUnit).GetGroupLead().GetKinematics().GetSpeed(float_5, throttle_0);
			}
			return result;
		}

		// Token: 0x06005A9A RID: 23194 RVA: 0x00283560 File Offset: 0x00281760
		public override int GetSpeed(float float_5)
		{
			int result;
			if (Information.IsNothing(((Group)this.activeUnit).GetGroupLead()))
			{
				result = 0;
			}
			else
			{
				result = ((Group)this.activeUnit).GetGroupLead().GetKinematics().GetSpeed(float_5);
			}
			return result;
		}

		// Token: 0x06005A9B RID: 23195 RVA: 0x002835AC File Offset: 0x002817AC
		public int method_20(ActiveUnit.Throttle throttle_0)
		{
			int num = 200000000;
			int result = 0;
			try
			{
				foreach (ActiveUnit current in ((Group)this.activeUnit).GetUnitsInGroup().Values)
				{
					int speed = current.GetKinematics().GetSpeed(current.GetCurrentAltitude_ASL(false), throttle_0);
					if (speed < num)
					{
						num = speed;
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100617", "");
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

		// Token: 0x04002CF1 RID: 11505
		public static Func<ActiveUnit, float> ActiveUnitFunc0 = (ActiveUnit activeUnit_0) => activeUnit_0.GetKinematics().GetMaxAltitude();

		// Token: 0x04002CF2 RID: 11506
		public static Func<ActiveUnit, float> ActiveUnitFunc1 = (ActiveUnit activeUnit_0) => activeUnit_0.GetKinematics().GetMinAltitude();

		// Token: 0x04002CF3 RID: 11507
		private bool LATSD = false;
	}
}
