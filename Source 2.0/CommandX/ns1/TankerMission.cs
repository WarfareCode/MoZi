using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1
{
	// Token: 0x02000A6E RID: 2670
	public sealed class TankerMission : Mission
	{
		// Token: 0x0600547C RID: 21628 RVA: 0x00230850 File Offset: 0x0022EA50
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Mission");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("Category", ((byte)this.category).ToString());
				this.m_Doctrine.Save(ref xmlWriter_0, ref scenario_0, "Doctrine");
				xmlWriter_0.WriteElementString("SISIH", this.SISIH.ToString());
				xmlWriter_0.WriteElementString("ETMID", this.EscortTargetMissionID);
				if (base.GetMissionStatus(scenario_0) != Mission._MissionStatus.Activation)
				{
					xmlWriter_0.WriteElementString("Status", ((byte)base.GetMissionStatus(scenario_0)).ToString());
				}
				if (this.TransitThrottle_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("TransitThrottle_Aircraft", Conversions.ToString((int)this.TransitThrottle_Aircraft.Value));
				}
				if (this.StationThrottle_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("StationThrottle_Aircraft", Conversions.ToString((int)this.StationThrottle_Aircraft.Value));
				}
				if (this.TransitAltitude_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("TransitAltitude_Aircraft", this.TransitAltitude_Aircraft.Value.ToString());
				}
				if (this.StationAltitude_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("StationAltitude_Aircraft", this.StationAltitude_Aircraft.Value.ToString());
				}
				xmlWriter_0.WriteElementString("TransitTerrainFollowing_Aircraft", this.TransitTerrainFollowing_Aircraft.ToString());
				xmlWriter_0.WriteElementString("AttackTerrainFollowing_Aircraft", this.AttackTerrainFollowing_Aircraft.ToString());
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "FlightSize";
				int num = (int)this.m_FlightSize;
				xmlWriter.WriteElementString(localName, num.ToString());
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "Formation_Cruise";
				num = (int)this.Formation_Cruise;
				xmlWriter2.WriteElementString(localName2, num.ToString());
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "Formation_Attack";
				num = (int)this.Formation_Attack;
				xmlWriter3.WriteElementString(localName3, num.ToString());
				XmlWriter xmlWriter4 = xmlWriter_0;
				string localName4 = "MinAircraftReq";
				num = (int)this.MinAircraftReq;
				xmlWriter4.WriteElementString(localName4, num.ToString());
				xmlWriter_0.WriteElementString("UseFlightSizeHardLimit", this.UseFlightSizeHardLimit.ToString());
				XmlWriter xmlWriter5 = xmlWriter_0;
				string localName5 = "TankerUsage";
				byte tankerUsage = (byte)this.TankerUsage;
				xmlWriter5.WriteElementString(localName5, tankerUsage.ToString());
				xmlWriter_0.WriteStartElement("TankerMissionList");
				foreach (Mission current in this.TankerMissionList)
				{
					if (!Information.IsNothing(current))
					{
						xmlWriter_0.WriteElementString("ID", current.GetGuid());
					}
				}
				xmlWriter_0.WriteEndElement();
				if (this.LaunchMissionWithoutTankersInPlace)
				{
					xmlWriter_0.WriteElementString("LaunchMissionWithoutTankersInPlace", this.LaunchMissionWithoutTankersInPlace.ToString());
				}
				xmlWriter_0.WriteElementString("TankerMinNumber_Total", this.TankerMinNumber_Total.ToString());
				xmlWriter_0.WriteElementString("TankerMinNumber_Airborne", this.TankerMinNumber_Airborne.ToString());
				xmlWriter_0.WriteElementString("TankerMinNumber_Station", this.TankerMinNumber_Station.ToString());
				xmlWriter_0.WriteElementString("MaxReceiversInQueuePerTanker_Airborne", this.MaxReceiversInQueuePerTanker_Airborne.ToString());
				xmlWriter_0.WriteElementString("FuelQtyToStartLookingForTanker_Airborne", this.FuelQtyToStartLookingForTanker_Airborne.ToString());
				xmlWriter_0.WriteElementString("TankerMaxDistance_Airborne", this.TankerMaxDistance_Airborne.ToString());
				xmlWriter_0.WriteElementString("TankerFollowsReceivers", this.bTankerFollowsReceivers.ToString());
				if (!Information.IsNothing(this.EmptySlotsList) && this.EmptySlotsList.Count > 0)
				{
					Mission.EmptySlot.Save(ref xmlWriter_0, ref hashSet_0, ref scenario_0, ref this.EmptySlotsList);
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100631", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x00026EDA File Offset: 0x000250DA
		private TankerMission(Side side_0, Scenario scenario_0) : base(side_0, scenario_0)
		{
		}

		// Token: 0x040028AA RID: 10410
		public string EscortTargetMissionID;

		// Token: 0x040028AB RID: 10411
		public string string_4;

		// Token: 0x040028AC RID: 10412
		public Mission._FlightQty MinAircraftReq;

		// Token: 0x040028AD RID: 10413
		public ActiveUnit.Throttle? TransitThrottle_Aircraft;

		// Token: 0x040028AE RID: 10414
		public ActiveUnit.Throttle? StationThrottle_Aircraft;

		// Token: 0x040028AF RID: 10415
		public float? TransitAltitude_Aircraft;

		// Token: 0x040028B0 RID: 10416
		public float? StationAltitude_Aircraft;

		// Token: 0x040028B1 RID: 10417
		public bool TransitTerrainFollowing_Aircraft;

		// Token: 0x040028B2 RID: 10418
		public bool AttackTerrainFollowing_Aircraft;

		// Token: 0x040028B3 RID: 10419
		public Mission._Formation Formation_Cruise;

		// Token: 0x040028B4 RID: 10420
		public Mission._Formation Formation_Attack;
	}
}
