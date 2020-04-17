using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns3
{
	// Token: 0x02000B80 RID: 2944
	public sealed class Weapon_Damage : ActiveUnit_Damage
	{
		// Token: 0x0600616B RID: 24939 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void Save(ref XmlWriter xmlWriter_0)
		{
		}

		// Token: 0x0600616C RID: 24940 RVA: 0x002EF4BC File Offset: 0x002ED6BC
		public static Weapon_Damage Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Weapon_Damage result = null;
			try
			{
				result = new Weapon_Damage(ref activeUnit_1)
				{
					activeUnit = activeUnit_1
				};
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100977", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Weapon_Damage(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x000247CD File Offset: 0x000229CD
		public Weapon_Damage(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x0600616E RID: 24942 RVA: 0x002EF538 File Offset: 0x002ED738
		public override void vmethod_11(Weapon weapon_0, GeoPoint LaunchPoint_, float float_1, float float_2, ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2, ref string string_0)
		{
			try
			{
				this.activeUnit.m_Scenario.RemoveUnit(this.activeUnit);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100978", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}
	}
}
