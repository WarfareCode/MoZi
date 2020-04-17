using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 武器
	public class Weapon : ActiveUnit
	{
		// Token: 0x06005554 RID: 21844 RVA: 0x0023A7D8 File Offset: 0x002389D8
		[CompilerGenerated]
		public  ObservableCollection<WeaponRec> GetWeaponRecCollection()
		{
			return this.WeaponRecCollection;
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x000273C6 File Offset: 0x000255C6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void SetWeaponRecCollection(ObservableCollection<WeaponRec> observableCollection_2)
		{
			this.WeaponRecCollection = observableCollection_2;
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x0023A7F0 File Offset: 0x002389F0
		[CompilerGenerated]
		public static void smethod_1(Weapon.Delegate25 delegate25_1)
		{
			Weapon.Delegate25 @delegate = Weapon.delegate25_0;
			Weapon.Delegate25 delegate2;
			do
			{
				delegate2 = @delegate;
				Weapon.Delegate25 value = (Weapon.Delegate25)Delegate.Combine(delegate2, delegate25_1);
				@delegate = Interlocked.CompareExchange<Weapon.Delegate25>(ref Weapon.delegate25_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x0023A828 File Offset: 0x00238A28
		public override bool IsOfAirLaunchedGuidedWeapon()
		{
			bool flag;
			bool result;
			if (GameGeneral.bProfessionEdition && !GameGeneral.bUsePitchForWeapons)
			{
				flag = false;
			}
			else
			{
				if (!this.IsAirLaunchedGuidedWeapon.HasValue)
				{
					if (Information.IsNothing(this.GetFiringParent()))
					{
						result = false;
						return result;
					}
					this.IsAirLaunchedGuidedWeapon = new bool?(this.GetWeaponType() == Weapon._WeaponType.GuidedWeapon && this.GetFiringParent().IsAircraft);
				}
				flag = this.IsAirLaunchedGuidedWeapon.Value;
			}
			result = flag;
			return result;
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x0023A8A4 File Offset: 0x00238AA4
		internal float method_127()
		{
			Weapon._WeaponType weaponType = this.GetWeaponType();
			float num;
			float result;
			if (weaponType <= Weapon._WeaponType.GuidedProjectile)
			{
				switch (weaponType)
				{
				case Weapon._WeaponType.GuidedWeapon:
					num = -20f;
					result = num;
					return result;
				case Weapon._WeaponType.Rocket:
				case Weapon._WeaponType.Gun:
					num = -88f;
					result = num;
					return result;
				case Weapon._WeaponType.IronBomb:
					break;
				default:
					if (weaponType == Weapon._WeaponType.GuidedProjectile)
					{
						num = -45f;
						result = num;
						return result;
					}
					break;
				}
			}
			else
			{
				if (weaponType == Weapon._WeaponType.Torpedo)
				{
					num = -85f;
					result = num;
					return result;
				}
				if (weaponType == Weapon._WeaponType.RV)
				{
					num = -85f;
					result = num;
					return result;
				}
				if (weaponType == Weapon._WeaponType.HGV)
				{
					num = -70f;
					result = num;
					return result;
				}
			}
			num = 0f;
			result = num;
			return result;
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x0023A960 File Offset: 0x00238B60
		public override void ClearGuid()
		{
			base.ClearGuid();
			Warhead[] warheads = this.m_Warheads;
			checked
			{
				for (int i = 0; i < warheads.Length; i++)
				{
					warheads[i].ClearGuid();
				}
			}
		}

		// 保存
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			checked
			{
				try
				{
					xmlWriter_0.WriteStartElement("Weapon");
					xmlWriter_0.WriteElementString("ID", base.GetGuid());
					if (hashSet_1.Contains(base.GetGuid()))
					{
						xmlWriter_0.WriteEndElement();
					}
					else
					{
						hashSet_1.Add(base.GetGuid());
						xmlWriter_0.WriteElementString("Name", this.Name);
						xmlWriter_0.WriteElementString("CH", XmlConvert.ToString(this.GetCurrentHeading()));
						xmlWriter_0.WriteElementString("CS", XmlConvert.ToString(this.GetCurrentSpeed()));
						xmlWriter_0.WriteElementString("CA", XmlConvert.ToString(this.GetCurrentAltitude_ASL(false)));
						xmlWriter_0.WriteElementString("Lon", XmlConvert.ToString(this.GetLongitude(null)));
						xmlWriter_0.WriteElementString("Lat", XmlConvert.ToString(this.GetLatitude(null)));
						if (base.GetLongitudeLR().HasValue)
						{
							xmlWriter_0.WriteElementString("LonLR", XmlConvert.ToString(base.GetLongitudeLR().Value));
						}
						if (base.GetLatitudeLR().HasValue)
						{
							xmlWriter_0.WriteElementString("LatLR", XmlConvert.ToString(base.GetLatitudeLR().Value));
						}
						if (this.GetPitch() != 0f)
						{
							xmlWriter_0.WriteElementString("Pitch", XmlConvert.ToString(this.GetPitch()));
						}
						if (this.GetRoll() != 0f)
						{
							xmlWriter_0.WriteElementString("Roll", XmlConvert.ToString(this.GetRoll()));
						}
						if (this.GetLongitude_UnitEntersAreaCheck().HasValue)
						{
							xmlWriter_0.WriteElementString("Longitude_UnitEntersAreaCheck", XmlConvert.ToString(this.GetLongitude_UnitEntersAreaCheck().Value));
						}
						if (this.GetLatitude_UnitEntersAreaCheck().HasValue)
						{
							xmlWriter_0.WriteElementString("Latitude_UnitEntersAreaCheck", XmlConvert.ToString(this.GetLatitude_UnitEntersAreaCheck().Value));
						}
						xmlWriter_0.WriteElementString("CEP_Surface", Conversions.ToString(XmlConvert.ToDouble(Conversions.ToString(this.GetCEP_Surface()))));
						xmlWriter_0.WriteElementString("CEP_Land", Conversions.ToString(XmlConvert.ToDouble(Conversions.ToString(this.GetCEP_Land()))));
						if (base.GetRangeSymbols().Count > 0)
						{
							xmlWriter_0.WriteStartElement("RangeSymbols");
							using (List<RangeSymbol>.Enumerator enumerator = base.GetRangeSymbols().GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									enumerator.Current.Save(ref xmlWriter_0);
								}
							}
							xmlWriter_0.WriteEndElement();
						}
						if (Information.IsNothing(this.GetSide(false)))
						{
							Side[] sides = this.m_Scenario.GetSides();
							for (int i = 0; i < sides.Length; i++)
							{
								Side side = sides[i];
								if (side.ActiveUnitArray.Contains(this))
								{
									this.m_Side = side;
									break;
								}
							}
						}
						if (!Information.IsNothing(this.GetSide(false)))
						{
							xmlWriter_0.WriteElementString("Side", this.GetSide(false).GetSideName());
						}
						if (!string.IsNullOrEmpty(this.Message))
						{
							xmlWriter_0.WriteElementString("Message", this.Message);
						}
						xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
						xmlWriter_0.WriteElementString("DH", XmlConvert.ToString(this.GetDesiredHeading(ActiveUnit._TurnRate.const_0)));
						xmlWriter_0.WriteElementString("DS", XmlConvert.ToString(this.GetDesiredSpeed()));
						xmlWriter_0.WriteElementString("DA", XmlConvert.ToString(this.GetDesiredAltitude()));
						xmlWriter_0.WriteElementString("DT", ((byte)this.GetDesiredTurnRate()).ToString());
						xmlWriter_0.WriteElementString("DTN", ((byte)this.GetDesiredTurnRate_Navigation()).ToString());
						xmlWriter_0.WriteElementString("TerrainFollowing", this.IsTerrainFollowing(this).ToString());
						xmlWriter_0.WriteElementString("TS", ((byte)this.GetThrottle()).ToString());
						xmlWriter_0.WriteStartElement("Sensors");
						Sensor[] sensors = this.m_Sensors;
						for (int j = 0; j < sensors.Length; j++)
						{
							sensors[j].Save(ref xmlWriter_0, ref hashSet_1, this.m_Scenario);
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Comms");
						CommDevice[] commDevices = this.m_CommDevices;
						for (int k = 0; k < commDevices.Length; k++)
						{
							commDevices[k].Save(ref xmlWriter_0, ref hashSet_1, this.m_Scenario);
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Propulsion");
						using (IEnumerator<Engine> enumerator2 = this.GetEngines().GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								enumerator2.Current.Save(ref xmlWriter_0, ref hashSet_1, this.m_Scenario);
							}
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Fuel");
						FuelRec[] fuelRecs = this.m_FuelRecs;
						for (int l = 0; l < fuelRecs.Length; l++)
						{
							fuelRecs[l].Save(ref xmlWriter_0);
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Mounts");
						Mount[] mounts = this.m_Mounts;
						for (int m = 0; m < mounts.Length; m++)
						{
							Mount mount = mounts[m];
							if (Information.IsNothing(mount.GetParentPlatform()))
							{
								mount.SetParentPlatform(this);
							}
							mount.Save(ref xmlWriter_0, ref hashSet_1, this.m_Scenario);
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("OnboardCargo");
						Cargo[] onboardCargos = this.m_OnboardCargos;
						for (int n = 0; n < onboardCargos.Length; n++)
						{
							onboardCargos[n].Save(ref xmlWriter_0, ref hashSet_1, this.m_Scenario);
						}
						xmlWriter_0.WriteEndElement();
						XmlWriter xmlWriter = xmlWriter_0;
						string localName = "Status";
						byte b = (byte)this.activeUnitStatus;
						xmlWriter.WriteElementString(localName, b.ToString());
						XmlWriter xmlWriter2 = xmlWriter_0;
						string localName2 = "FuelState";
						b = (byte)this.activeUnitFuelState;
						xmlWriter2.WriteElementString(localName2, b.ToString());
						XmlWriter xmlWriter3 = xmlWriter_0;
						string localName3 = "WeaponState";
						b = (byte)this.weaponState;
						xmlWriter3.WriteElementString(localName3, b.ToString());
						XmlWriter xmlWriter4 = xmlWriter_0;
						string localName4 = "SBR";
						b = (byte)this.SBR;
						xmlWriter4.WriteElementString(localName4, b.ToString());
						XmlWriter xmlWriter5 = xmlWriter_0;
						string localName5 = "SBED";
						b = (byte)this.SBEngagedDefensive;
						xmlWriter5.WriteElementString(localName5, b.ToString());
						XmlWriter xmlWriter6 = xmlWriter_0;
						string localName6 = "SBEO";
						b = (byte)this.SBEngagedOffensive;
						xmlWriter6.WriteElementString(localName6, b.ToString());
						XmlWriter xmlWriter7 = xmlWriter_0;
						string localName7 = "FSBR";
						b = (byte)this.FuelStateBR;
						xmlWriter7.WriteElementString(localName7, b.ToString());
						xmlWriter_0.WriteElementString("SBR_Altitude", XmlConvert.ToString(this.SBR_Altitude));
						xmlWriter_0.WriteElementString("SBR_Altitude_TF", XmlConvert.ToString(this.SBR_Altitude_TerrainFollowing));
						xmlWriter_0.WriteElementString("SBR_TF", XmlConvert.ToString(this.SBR_TerrainFollowing));
						XmlWriter xmlWriter8 = xmlWriter_0;
						string localName8 = "SBR_ThrottleSetting";
						b = (byte)this.SBR_ThrottleSetting;
						xmlWriter8.WriteElementString(localName8, b.ToString());
						xmlWriter_0.WriteElementString("SBED_Altitude", XmlConvert.ToString(this.SBEngagedDefensive_Altitude));
						xmlWriter_0.WriteElementString("SBED_Altitude_TF", XmlConvert.ToString(this.SBEngagedDefensive_Altitude_TerrainFollowing));
						xmlWriter_0.WriteElementString("SBED_TF", XmlConvert.ToString(this.SBEngagedDefensive_TerrainFollowing));
						XmlWriter xmlWriter9 = xmlWriter_0;
						string localName9 = "SBED_ThrottleSetting";
						b = (byte)this.SBEngagedDefensive_ThrottleSetting;
						xmlWriter9.WriteElementString(localName9, b.ToString());
						xmlWriter_0.WriteElementString("SBEO_Altitude", XmlConvert.ToString(this.SBEngagedOffensive_Altitude));
						xmlWriter_0.WriteElementString("SBEO_Altitude_TF", XmlConvert.ToString(this.SBEngagedOffensive_Altitude_TerrainFollowing));
						xmlWriter_0.WriteElementString("SBEO_TF", XmlConvert.ToString(this.SBEngagedOffensive_TerrainFollowing));
						XmlWriter xmlWriter10 = xmlWriter_0;
						string localName10 = "SBEO_ThrottleSetting";
						b = (byte)this.SBEngagedOffensive_ThrottleSetting;
						xmlWriter10.WriteElementString(localName10, b.ToString());
						xmlWriter_0.WriteElementString("DamagePts", XmlConvert.ToString(this.GetDamagePts(false)));
						if (this.m_AirFacilities.Length > 0)
						{
							xmlWriter_0.WriteStartElement("AirFacilities");
							AirFacility[] airFacilities = this.m_AirFacilities;
							for (int num = 0; num < airFacilities.Length; num++)
							{
								airFacilities[num].Save(ref xmlWriter_0, ref hashSet_1, this.m_Scenario);
								xmlWriter_0.Flush();
							}
							xmlWriter_0.WriteEndElement();
						}
						if (this.m_DockFacilities.Count<DockFacility>() > 0)
						{
							xmlWriter_0.WriteStartElement("DockFacilities");
							DockFacility[] dockFacilities = this.m_DockFacilities;
							for (int num2 = 0; num2 < dockFacilities.Length; num2++)
							{
								dockFacilities[num2].Save(ref xmlWriter_0, ref hashSet_1, this.m_Scenario);
								xmlWriter_0.Flush();
							}
							xmlWriter_0.WriteEndElement();
						}
						if (!Information.IsNothing(this.AssignedMission))
						{
							xmlWriter_0.WriteElementString("AssignedMission", this.AssignedMission.GetGuid());
						}
						if (!Information.IsNothing(this.GetAssignedTaskPool()))
						{
							xmlWriter_0.WriteElementString("AssignedTaskPool", this.AssignedTaskPool.GetGuid());
						}
						if (!Information.IsNothing(this.GetParentGroup(false)))
						{
							xmlWriter_0.WriteElementString("ParentGroup", this.parentGroup.GetGuid());
						}
						if (base.IsAutoDetectable(null))
						{
							xmlWriter_0.WriteElementString("IsAD", base.IsAutoDetectable(null).ToString());
						}
						this.m_Doctrine.Save(ref xmlWriter_0, ref this.m_Scenario, "Doctrine");
						xmlWriter_0.WriteStartElement("Warheads");
						Warhead[] warheads = this.m_Warheads;
						for (int num3 = 0; num3 < warheads.Length; num3++)
						{
							warheads[num3].Save(ref xmlWriter_0);
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteElementString("BT", this.BlindTime.ToString());
						xmlWriter_0.WriteElementString("DRT", this.DRT.ToString());
						if (!Information.IsNothing(this.GetDataLinkParent()))
						{
							xmlWriter_0.WriteElementString("DataLinkParent", this.GetDataLinkParent().GetGuid());
						}
						if (!Information.IsNothing(this.GetFiringParent()))
						{
							xmlWriter_0.WriteElementString("FiringParent", this.GetFiringParent().GetGuid());
						}
						if (!Information.IsNothing(this.searchPatternType))
						{
							XmlWriter xmlWriter11 = xmlWriter_0;
							string localName11 = "SearchPatternType";
							b = (byte)this.searchPatternType;
							xmlWriter11.WriteElementString(localName11, b.ToString());
						}
						xmlWriter_0.WriteElementString("Guidance", ((int)this.GetGuidanceMethod()).ToString());
						xmlWriter_0.WriteStartElement("LaunchPoint");
						this.LaunchPoint.Save(ref xmlWriter_0, ref hashSet_1);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteElementString("TTD", XmlConvert.ToString(this.DetonationDelay));
						if (!Information.IsNothing(this.m_Director))
						{
							xmlWriter_0.WriteElementString("SIFM", this.m_Director.GetGuid());
						}
						if (!Information.IsNothing(this.ARM_SpecifiedEmission.Value))
						{
							xmlWriter_0.WriteStartElement("ARM_SE");
							xmlWriter_0.WriteElementString("Emission" + this.ARM_SpecifiedEmission.Key.ToString(), this.ARM_SpecifiedEmission.Value.ToString());
							xmlWriter_0.WriteEndElement();
						}
						if (this.GetWeaponRecCollection().Count > 0)
						{
							xmlWriter_0.WriteStartElement("WeaponWeapons");
							using (IEnumerator<WeaponRec> enumerator3 = this.GetWeaponRecCollection().GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									enumerator3.Current.Save(ref xmlWriter_0, ref hashSet_1, ref this.m_Scenario);
								}
							}
							xmlWriter_0.WriteEndElement();
						}
						xmlWriter_0.WriteElementString("ARM_SEIM", this.ARM_SpecifiedEmissionIsMandatory.ToString());
						if (!Information.IsNothing(this.IlluminatorUnit))
						{
							xmlWriter_0.WriteElementString("IlluminatorUnit", this.IlluminatorUnit.GetGuid());
						}
						this.GetWeaponNavigator().Save(ref xmlWriter_0, ref hashSet_1);
						xmlWriter_0.WriteStartElement("Weapon_AI");
						this.GetWeaponAI().method_89(ref xmlWriter_0, ref hashSet_1);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Weapon_Kinematics");
						this.GetWeaponKinematics().Save(ref xmlWriter_0);
						xmlWriter_0.WriteEndElement();
						this.GetWeaponSensory().Save(ref xmlWriter_0);
						this.GetWeaponCommStuff().Save(ref xmlWriter_0, ref hashSet_1);
						this.GetWeaponDamage().Save(ref xmlWriter_0);
						xmlWriter_0.WriteEndElement();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100881", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x0023B660 File Offset: 0x00239860
		protected Weapon(string CustomGUID = null)
		{
			this.m_Warheads = new Warhead[0];
			this.weaponDirectorSet = new HashSet<int>();
			this.weaponCode = default(Weapon.WeaponCode);
			this.SetWeaponRecCollection(new ObservableCollection<WeaponRec>());
			this.list_3 = new List<Weapon._ASMode>();
			this.bool_20 = false;
			base.SetGuid(CustomGUID);
			this.IsWeapon = true;
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x0023B6C4 File Offset: 0x002398C4
		public static Weapon Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_1)
		{
			Weapon weapon = null;
			try
			{
				weapon = Weapon.LoadSubWeaponType(xmlNode_0, dictionary_0, scenario_1, scenario_1.LoadStockUnits);
			}
			catch (Exception0 projectError)
			{
				ProjectData.SetProjectError(projectError);
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				dictionary_0.Remove(innerText);
				weapon = Weapon.LoadSubWeaponType(xmlNode_0, dictionary_0, scenario_1, true);
				string text = "";
				if (weapon.HasParentGroup())
				{
					text = "(member of group: [" + weapon.GetParentGroup(false).Name + "])";
				}
				scenario_1.LoadingNotices.Add(string.Concat(new string[]
				{
					"The following weapon:[",
					weapon.Name,
					"]",
					text,
					" failed to shallow-rebuild because of a component missing. The weapon was instead deep-rebuilt, and instantiated in its pristine DB-stock condition. All customizations present in the weapon's components (damaged components, additions/removals etc. etc.) have been lost. Please re-apply any necessary customizations either manually or using an SBR script."
				}));
				ProjectData.ClearProjectError();
			}
			return weapon;
		}

		// Token: 0x0600555D RID: 21853 RVA: 0x0023B7B0 File Offset: 0x002399B0
		protected static void smethod_3(Weapon weapon_1, Scenario scenario_1, XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0)
		{
			IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					XmlNode xmlNode = (XmlNode)enumerator.Current;
					string name = xmlNode.Name;
					uint num = Class382.smethod_0(name);
					if (num <= 2241118125u)
					{
						if (num <= 1305748348u)
						{
							if (num != 970174858u)
							{
								if (num != 1305748348u || Operators.CompareString(name, "OnboardCargo", false) != 0)
								{
									continue;
								}
								IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
										Cargo cargo = Cargo.Load(ref xmlNode2, ref dictionary_0, weapon_1);
										ScenarioArrayUtil.AddCargo(ref weapon_1.m_OnboardCargos, cargo);
										cargo.SetParentPlatform(weapon_1);
									}
									continue;
								}
								finally
								{
									if (enumerator2 is IDisposable)
									{
										(enumerator2 as IDisposable).Dispose();
									}
								}
							}
							if (Operators.CompareString(name, "WeaponWeapons", false) != 0)
							{
								continue;
							}
							IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator3.MoveNext())
								{
									XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
									WeaponRec item = WeaponRec.smethod_2(ref xmlNode3, ref dictionary_0, ref scenario_1);
									weapon_1.GetWeaponRecCollection().Add(item);
								}
								continue;
							}
							finally
							{
								if (enumerator3 is IDisposable)
								{
									(enumerator3 as IDisposable).Dispose();
								}
							}
						}
						if (num != 2008421230u)
						{
							if (num != 2241118125u || Operators.CompareString(name, "Fuel", false) != 0)
							{
								continue;
							}
							IEnumerator enumerator4 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator4.MoveNext())
								{
									XmlNode xmlNode4 = (XmlNode)enumerator4.Current;
									FuelRec fuelRec_ = FuelRec.Load(ref xmlNode4, ref dictionary_0);
									ScenarioArrayUtil.AddFuelRec(ref weapon_1.m_FuelRecs, fuelRec_);
								}
								continue;
							}
							finally
							{
								if (enumerator4 is IDisposable)
								{
									(enumerator4 as IDisposable).Dispose();
								}
							}
						}
						if (Operators.CompareString(name, "Comms", false) == 0)
						{
							int num2 = xmlNode.ChildNodes.Count - 1;
							for (int num3 = 0; num3 <= num2; num3++)
							{
								XmlNode xmlNode5 = xmlNode.ChildNodes[num3];
								CommDevice commDevice = CommDevice.Load(ref xmlNode5, ref dictionary_0, weapon_1);
								if (commDevice.DBID == 0)
								{
									Weapon weapon = new Weapon(null);
									weapon.m_Scenario = scenario_1;
									DBFunctions.LoadWeaponData(scenario_1.GetSQLiteConnection(), weapon, weapon_1.DBID, scenario_1, true);
									try
									{
										commDevice = weapon.GetCommDevices()[num3];
										goto IL_2EA;
									}
									catch (Exception ex)
									{
										ProjectData.SetProjectError(ex);
										Exception ex2 = ex;
										ex2.Data.Add("Error at 101179", "");
										GameGeneral.LogException(ref ex2);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
										ProjectData.ClearProjectError();
										goto IL_2EA;
									}
									goto IL_2B5;
									IL_2EA:
									dictionary_0.Add(commDevice.GetGuid(), commDevice);
								}
								IL_2B5:
								if (weapon_1.GetWeaponType() == Weapon._WeaponType.Sonobuoy)
								{
									commDevice.ParentSpecific = false;
								}
								weapon_1.AddCommDevice(commDevice);
								commDevice.SetParentPlatform(weapon_1);
							}
						}
					}
					else
					{
						if (num <= 2424405304u)
						{
							if (num != 2246682072u)
							{
								if (num != 2424405304u || Operators.CompareString(name, "Sensors", false) != 0)
								{
									continue;
								}
								IEnumerator enumerator5 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator5.MoveNext())
									{
										Sensor sensor = Sensor.Load((XmlNode)enumerator5.Current, dictionary_0, weapon_1);
										ScenarioArrayUtil.AddSensor(ref weapon_1.m_Sensors, sensor);
										sensor.SetParentPlatform(weapon_1);
									}
									continue;
								}
								finally
								{
									if (enumerator5 is IDisposable)
									{
										(enumerator5 as IDisposable).Dispose();
									}
								}
							}
							if (Operators.CompareString(name, "Propulsion", false) != 0)
							{
								continue;
							}
							IEnumerator enumerator6 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator6.MoveNext())
								{
									XmlNode xmlNode6 = (XmlNode)enumerator6.Current;
									ActiveUnit activeUnit = weapon_1;
									Engine engine = Engine.Load(ref xmlNode6, ref dictionary_0, ref activeUnit);
									weapon_1.GetEngines().Add(engine);
									engine.SetParentPlatform(weapon_1);
								}
								continue;
							}
							finally
							{
								if (enumerator6 is IDisposable)
								{
									(enumerator6 as IDisposable).Dispose();
								}
							}
						}
						if (num != 3760177291u)
						{
							if (num != 3989581338u || Operators.CompareString(name, "AirFacilities", false) != 0)
							{
								continue;
							}
							IEnumerator enumerator7 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator7.MoveNext())
								{
									XmlNode xmlNode7 = (XmlNode)enumerator7.Current;
									AirFacility airFacility = AirFacility.Load(ref xmlNode7, ref dictionary_0, ref scenario_1);
									weapon_1.AddAirFacility(airFacility);
									airFacility.SetParentPlatform(weapon_1);
								}
								continue;
							}
							finally
							{
								if (enumerator7 is IDisposable)
								{
									(enumerator7 as IDisposable).Dispose();
								}
							}
						}
						if (Operators.CompareString(name, "Mounts", false) == 0)
						{
							IEnumerator enumerator8 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator8.MoveNext())
								{
									XmlNode xmlNode8 = (XmlNode)enumerator8.Current;
									Mount mount = Mount.Load(ref xmlNode8, ref dictionary_0, weapon_1);
									ScenarioArrayUtil.AddMount(ref weapon_1.m_Mounts, mount);
									mount.SetParentPlatform(weapon_1);
								}
							}
							finally
							{
								if (enumerator8 is IDisposable)
								{
									(enumerator8 as IDisposable).Dispose();
								}
							}
						}
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x0600555E RID: 21854 RVA: 0x0023BDE8 File Offset: 0x00239FE8
		protected static Weapon LoadSubWeaponType(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0, Scenario scenario_1, bool bool_21)
		{
			Weapon weapon = null;
			Weapon result;
			try
			{
				XmlNode xmlNode = Misc.smethod_48(xmlNode_0.ChildNodes, "DBID");
				int num = 0;
				if (!Information.IsNothing(xmlNode))
				{
					num = Conversions.ToInteger(xmlNode.InnerText);
					Weapon._WeaponType weaponTyp = DBFunctions.GetWeaponTyp(num, scenario_1);
					if (weaponTyp == Weapon._WeaponType.GuidedProjectile)
					{
						weapon = GuidedProjectile.Load(xmlNode_0, dictionary_0, scenario_1, bool_21);
						result = weapon;
						return result;
					}
					if (weaponTyp == Weapon._WeaponType.Torpedo)
					{
						weapon = Torpedo.Load(xmlNode_0, dictionary_0, scenario_1, bool_21);
						result = weapon;
						return result;
					}
					if (weaponTyp == Weapon._WeaponType.HGV)
					{
						weapon = HGV.Load(xmlNode_0, dictionary_0, scenario_1, bool_21);
						result = weapon;
						return result;
					}
				}
				Weapon weapon2 = new Weapon(null);
				weapon2.m_Scenario = scenario_1;
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					weapon = (Weapon)dictionary_0[innerText];
				}
				else
				{
					weapon2.SetGuid(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						weapon = weapon2;
					}
					else
					{
						dictionary_0.Add(weapon2.GetGuid(), weapon2);
						DBFunctions.LoadWeaponData(scenario_1.GetSQLiteConnection(), weapon2, num, scenario_1, bool_21);
						weapon2.DBID = num;
						if (weapon2.IsHypersonicGlideVehicle())
						{
							weapon2.SetCruiseAltitude_ASL(100000f);
						}
						if (bool_21)
						{
							weapon2.LoadAirFacilities(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						}
						if (!bool_21)
						{
							Weapon.smethod_3(weapon2, scenario_1, xmlNode_0, dictionary_0);
						}
						Weapon.smethod_5(weapon2, scenario_1, xmlNode_0, dictionary_0);
						float maxAltitude = weapon2.GetWeaponKinematics().GetMaxAltitude();
						float minAltitude = weapon2.GetWeaponKinematics().GetMinAltitude();
						if (weapon2.GetCurrentAltitude_ASL(false) > maxAltitude && (weapon2.GetWeaponType() == Weapon._WeaponType.GuidedWeapon || weapon2.GetWeaponType() == Weapon._WeaponType.Torpedo))
						{
							weapon2.SetAltitude_ASL(false, maxAltitude);
						}
						else if (weapon2.GetCurrentAltitude_ASL(false) < minAltitude && (weapon2.GetWeaponType() == Weapon._WeaponType.GuidedWeapon || weapon2.GetWeaponType() == Weapon._WeaponType.Torpedo))
						{
							weapon2.SetAltitude_ASL(false, minAltitude);
						}
						if (weapon2.GetDesiredAltitude() > maxAltitude && (weapon2.GetWeaponType() == Weapon._WeaponType.GuidedWeapon || weapon2.GetWeaponType() == Weapon._WeaponType.Torpedo))
						{
							weapon2.SetDesiredAltitude(maxAltitude);
						}
						else if (weapon2.GetDesiredAltitude() < minAltitude && (weapon2.GetWeaponType() == Weapon._WeaponType.GuidedWeapon || weapon2.GetWeaponType() == Weapon._WeaponType.Torpedo))
						{
							weapon2.SetDesiredAltitude(minAltitude);
						}
						weapon = weapon2;
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
				weapon = new Weapon(null);
				ProjectData.ClearProjectError();
			}
			result = weapon;
			return result;
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x0023C0E4 File Offset: 0x0023A2E4
		protected static void smethod_5(Weapon weapon_1, Scenario scenario_1, XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_0)
		{
			IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					XmlNode xmlNode = (XmlNode)enumerator.Current;
					string name = xmlNode.Name;
					uint num = Class382.smethod_0(name);
					if (num <= 1738278884u)
					{
						if (num <= 827630232u)
						{
							if (num <= 634280640u)
							{
								if (num <= 441941816u)
								{
									if (num <= 263373746u)
									{
										if (num != 6222351u)
										{
											if (num == 263373746u && Operators.CompareString(name, "FSBR", false) == 0)
											{
												weapon_1.FuelStateBR = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Status", false) != 0)
											{
												continue;
											}
											if (Versioned.IsNumeric(xmlNode.InnerText))
											{
												weapon_1.SetUnitStatus((ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode.InnerText));
											}
											else
											{
												weapon_1.SetUnitStatus((ActiveUnit._ActiveUnitStatus)Enum.Parse(typeof(ActiveUnit._ActiveUnitStatus), xmlNode.InnerText, true));
											}
											if (weapon_1.GetUnitStatus() == (ActiveUnit._ActiveUnitStatus)9)
											{
												weapon_1.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB);
												continue;
											}
											continue;
										}
									}
									else if (num != 266367750u)
									{
										if (num != 422144471u)
										{
											if (num != 441941816u)
											{
												continue;
											}
											if (Operators.CompareString(name, "CurrentAltitude", false) != 0)
											{
												continue;
											}
											goto IL_B98;
										}
										else
										{
											if (Operators.CompareString(name, "ARM_SpecifiedEmission", false) != 0)
											{
												continue;
											}
											goto IL_FBE;
										}
									}
									else
									{
										if (Operators.CompareString(name, "Name", false) == 0)
										{
											weapon_1.Name = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num <= 485784328u)
								{
									if (num != 468031071u)
									{
										if (num != 485784328u)
										{
											continue;
										}
										if (Operators.CompareString(name, "IsAD", false) != 0)
										{
											continue;
										}
										goto IL_1648;
									}
									else
									{
										if (Operators.CompareString(name, "SBED_Altitude_TF", false) == 0)
										{
											weapon_1.SBEngagedDefensive_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 500883205u)
								{
									if (num != 506380204u)
									{
										if (num != 634280640u)
										{
											continue;
										}
										if (Operators.CompareString(name, "DS", false) != 0)
										{
											continue;
										}
										goto IL_F32;
									}
									else
									{
										if (Operators.CompareString(name, "LatLR", false) == 0)
										{
											weapon_1.SetLatitudeLR(new double?(XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", "."))));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "DRT", false) == 0)
									{
										weapon_1.DRT = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
										continue;
									}
									continue;
								}
							}
							else if (num <= 699412232u)
							{
								if (num <= 639961112u)
								{
									if (num != 636840496u)
									{
										if (num != 639961112u || Operators.CompareString(name, "Weapon_AI", false) != 0)
										{
											continue;
										}
										Weapon_AI.smethod_1(xmlNode, dictionary_0, weapon_1);
										if (weapon_1.IsTerrainFollowing(weapon_1) && weapon_1.GetDesiredAltitude_TerrainFollowing() == 0f)
										{
											weapon_1.SetDesiredAltitude_TerrainFollowing(60.96f);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TS", false) != 0)
										{
											continue;
										}
										goto IL_74D;
									}
								}
								else if (num != 664498478u)
								{
									if (num != 685599235u)
									{
										if (num != 699412232u)
										{
											continue;
										}
										if (Operators.CompareString(name, "SIFM", false) != 0)
										{
											continue;
										}
										goto IL_824;
									}
									else if (Operators.CompareString(name, "BT", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "FuelState", false) == 0)
									{
										weapon_1.activeUnitFuelState = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 793602867u)
							{
								if (num != 759940032u)
								{
									if (num == 793602867u && Operators.CompareString(name, "Weapon_Navigator", false) == 0)
									{
										ActiveUnit activeUnit = weapon_1;
										weapon_1.weapon_Navigator = Weapon_Navigator.Load(ref xmlNode, ref dictionary_0, ref activeUnit);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "ARM_SEIM", false) != 0)
									{
										continue;
									}
									goto IL_1432;
								}
							}
							else if (num != 802113503u)
							{
								if (num != 803760973u)
								{
									if (num == 827630232u && Operators.CompareString(name, "SBED_Altitude", false) == 0)
									{
										weapon_1.SBEngagedDefensive_Altitude = XmlConvert.ToSingle(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "DamagePts", false) == 0)
									{
										weapon_1.SetDamagePts(false, XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "IlluminatorUnit", false) == 0)
								{
									weapon_1.IlluminatorUnit = ActiveUnit.Load(ref xmlNode, ref dictionary_0, ref scenario_1);
									continue;
								}
								continue;
							}
						}
						else
						{
							if (num <= 1171512409u)
							{
								if (num <= 1029238175u)
								{
									if (num <= 892023141u)
									{
										if (num != 834703028u)
										{
											if (num != 892023141u)
											{
												continue;
											}
											if (Operators.CompareString(name, "DesiredHeading", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "Weapon_CommStuff", false) == 0)
											{
												ActiveUnit activeUnit = weapon_1;
												weapon_1.weapon_CommStuff = Weapon_CommStuff.Load(ref xmlNode, ref dictionary_0, ref activeUnit);
												continue;
											}
											continue;
										}
									}
									else if (num != 929554659u)
									{
										if (num != 936277782u)
										{
											if (num != 1029238175u)
											{
												continue;
											}
											if (Operators.CompareString(name, "CEP", false) != 0)
											{
												continue;
											}
											goto IL_126D;
										}
										else
										{
											if (Operators.CompareString(name, "DA", false) != 0)
											{
												continue;
											}
											goto IL_B3E;
										}
									}
									else
									{
										if (Operators.CompareString(name, "TTD", false) != 0)
										{
											continue;
										}
										goto IL_F76;
									}
								}
								else if (num <= 1087276353u)
								{
									if (num != 1053953301u)
									{
										if (num != 1087276353u || Operators.CompareString(name, "DH", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "BlindTime", false) == 0)
										{
											goto IL_63A;
										}
										continue;
									}
								}
								else if (num != 1143797280u)
								{
									if (num != 1156592502u)
									{
										if (num == 1171512409u && Operators.CompareString(name, "DataLinkParent", false) == 0)
										{
											weapon_1.DataLinkParentGuid = xmlNode.InnerText;
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "SBR", false) == 0)
										{
											weapon_1.SBR = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "SBR_Altitude_TF", false) == 0)
									{
										weapon_1.SBR_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								weapon_1.SetDesiredHeading(ActiveUnit._TurnRate.const_0, XmlConvert.ToSingle(xmlNode.InnerText));
								continue;
							}
							if (num <= 1476905714u)
							{
								if (num <= 1255847155u)
								{
									if (num != 1238454347u)
									{
										if (num == 1255847155u && Operators.CompareString(name, "ThrottleSetting", false) == 0)
										{
											goto IL_74D;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "SensorIlluminatingForMe", false) == 0)
										{
											goto IL_824;
										}
										continue;
									}
								}
								else if (num != 1259548010u)
								{
									if (num != 1422437055u)
									{
										if (num == 1476905714u && Operators.CompareString(name, "WeaponState", false) == 0)
										{
											weapon_1.weaponState = (ActiveUnit._ActiveUnitWeaponState)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Doctrine", false) == 0)
										{
											weapon_1.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode, weapon_1);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "SBED_ThrottleSetting", false) != 0)
									{
										continue;
									}
									string innerText = xmlNode.InnerText;
									if (Operators.CompareString(innerText, "FullStop", false) == 0)
									{
										weapon_1.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.FullStop;
										continue;
									}
									if (Operators.CompareString(innerText, "Loiter", false) == 0)
									{
										weapon_1.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Loiter;
										continue;
									}
									if (Operators.CompareString(innerText, "Cruise", false) == 0)
									{
										weapon_1.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Cruise;
										continue;
									}
									if (Operators.CompareString(innerText, "Full", false) == 0)
									{
										weapon_1.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Full;
										continue;
									}
									if (Operators.CompareString(innerText, "Flank", false) != 0)
									{
										weapon_1.SBEngagedDefensive_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									weapon_1.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Flank;
									continue;
								}
							}
							else if (num <= 1708783731u)
							{
								if (num != 1488303767u)
								{
									if (num != 1708783731u)
									{
										continue;
									}
									if (Operators.CompareString(name, "CS", false) != 0)
									{
										continue;
									}
									goto IL_13E1;
								}
								else
								{
									if (Operators.CompareString(name, "SBEO_TF", false) == 0)
									{
										weapon_1.SBEngagedOffensive_TerrainFollowing = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 1716063484u)
							{
								if (num != 1729717486u)
								{
									if (num == 1738278884u && Operators.CompareString(name, "SBED_TF", false) == 0)
									{
										weapon_1.SBEngagedDefensive_TerrainFollowing = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Longitude", false) != 0)
									{
										continue;
									}
									goto IL_E29;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Weapon_Kinematics", false) == 0)
								{
									ActiveUnit_Kinematics.Load(xmlNode, dictionary_0, weapon_1);
									continue;
								}
								continue;
							}
						}
						IL_63A:
						weapon_1.BlindTime = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
						continue;
						IL_74D:
						string innerText2 = xmlNode.InnerText;
						if (Operators.CompareString(innerText2, "FullStop", false) == 0)
						{
							weapon_1.currentThrottle = ActiveUnit.Throttle.FullStop;
							continue;
						}
						if (Operators.CompareString(innerText2, "Loiter", false) == 0)
						{
							weapon_1.currentThrottle = ActiveUnit.Throttle.Loiter;
							continue;
						}
						if (Operators.CompareString(innerText2, "Cruise", false) == 0)
						{
							weapon_1.currentThrottle = ActiveUnit.Throttle.Cruise;
							continue;
						}
						if (Operators.CompareString(innerText2, "Full", false) == 0)
						{
							weapon_1.currentThrottle = ActiveUnit.Throttle.Full;
							continue;
						}
						if (Operators.CompareString(innerText2, "Flank", false) != 0)
						{
							weapon_1.currentThrottle = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
							continue;
						}
						weapon_1.currentThrottle = ActiveUnit.Throttle.Flank;
						continue;
						IL_824:
						weapon_1.SensorIlluminatingForMe = xmlNode.InnerText;
						continue;
					}
					if (num > 2844845263u)
					{
						goto IL_104C;
					}
					if (num <= 2532358002u)
					{
						if (num <= 2066337159u)
						{
							if (num <= 1992083866u)
							{
								if (num != 1836990821u)
								{
									if (num == 1992083866u && Operators.CompareString(name, "Latitude_UnitEntersAreaCheck", false) == 0)
									{
										weapon_1.SetLatitude_UnitEntersAreaCheck(new double?(XmlConvert.ToDouble(xmlNode.InnerText)));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Latitude", false) != 0)
									{
										continue;
									}
									goto IL_1119;
								}
							}
							else if (num != 2010780873u)
							{
								if (num != 2019197265u)
								{
									if (num == 2066337159u && Operators.CompareString(name, "DesiredAltitude", false) == 0)
									{
										goto IL_B3E;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Pitch", false) == 0)
									{
										weapon_1.SetPitch(XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "CA", false) == 0)
								{
									goto IL_B98;
								}
								continue;
							}
						}
						else if (num <= 2247649009u)
						{
							if (num != 2128224206u)
							{
								if (num == 2247649009u && Operators.CompareString(name, "AssignedMission", false) == 0 && xmlNode.HasChildNodes)
								{
									XmlNode xmlNode2 = xmlNode.ChildNodes[0];
									weapon_1.AssignedMissionName = xmlNode2.InnerText;
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "CH", false) != 0)
								{
									continue;
								}
								goto IL_15F7;
							}
						}
						else if (num != 2496321123u)
						{
							if (num != 2527167325u)
							{
								if (num == 2532358002u && Operators.CompareString(name, "FiringParent", false) == 0)
								{
									weapon_1.FiringParentGuid = xmlNode.InnerText;
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "TerrainFollowing", false) == 0)
								{
									weapon_1.SetIsTerrainFollowing(weapon_1, Conversions.ToBoolean(xmlNode.InnerText));
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "RangeSymbols", false) != 0)
							{
								continue;
							}
							IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									RangeSymbol item = RangeSymbol.Load((XmlNode)enumerator2.Current, dictionary_0);
									weapon_1.GetRangeSymbols().Add(item);
								}
								continue;
							}
							finally
							{
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
					}
					if (num <= 2638010429u)
					{
						if (num <= 2545405656u)
						{
							if (num != 2536212798u)
							{
								if (num == 2545405656u && Operators.CompareString(name, "LaunchPoint", false) == 0)
								{
									XmlNode xmlNode3 = xmlNode.FirstChild;
									weapon_1.LaunchPoint = GeoPoint.Load(ref xmlNode3, ref dictionary_0);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Roll", false) == 0)
								{
									weapon_1.SetRoll(XmlConvert.ToSingle(xmlNode.InnerText));
									continue;
								}
								continue;
							}
						}
						else if (num != 2564648390u)
						{
							if (num != 2590053246u)
							{
								if (num == 2638010429u && Operators.CompareString(name, "SearchPatternType", false) == 0)
								{
									weapon_1.searchPatternType = (Weapon._SearchPatternType)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Side", false) == 0)
								{
									weapon_1.strSide = xmlNode.InnerText;
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "Lon", false) == 0)
							{
								goto IL_E29;
							}
							continue;
						}
					}
					else if (num > 2698398137u)
					{
						if (num != 2749693904u)
						{
							if (num != 2811069936u)
							{
								if (num == 2844845263u && Operators.CompareString(name, "SBEO_Altitude", false) == 0)
								{
									weapon_1.SBEngagedOffensive_Altitude = XmlConvert.ToSingle(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Warheads", false) != 0)
								{
									continue;
								}
								IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator3.MoveNext())
									{
										XmlNode xmlNode4 = (XmlNode)enumerator3.Current;
										Warhead warhead_ = Warhead.Load(ref xmlNode4, ref dictionary_0);
										ScenarioArrayUtil.AddWarhead(ref weapon_1.m_Warheads, warhead_);
									}
									continue;
								}
								finally
								{
									if (enumerator3 is IDisposable)
									{
										(enumerator3 as IDisposable).Dispose();
									}
								}
							}
						}
						if (Operators.CompareString(name, "DesiredSpeed", false) == 0)
						{
							goto IL_F32;
						}
						continue;
					}
					else if (num != 2650669718u)
					{
						if (num == 2698398137u && Operators.CompareString(name, "TimeToDetonate", false) == 0)
						{
							goto IL_F76;
						}
						continue;
					}
					else
					{
						if (Operators.CompareString(name, "ARM_SE", false) == 0)
						{
							goto IL_FBE;
						}
						continue;
					}
					IL_B3E:
					weapon_1.SetDesiredAltitude(XmlConvert.ToSingle(xmlNode.InnerText));
					continue;
					IL_B98:
					weapon_1.SetAltitude_ASL(false, XmlConvert.ToSingle(xmlNode.InnerText));
					continue;
					IL_E29:
					weapon_1.SetLongitude(null, XmlConvert.ToDouble(xmlNode.InnerText));
					continue;
					IL_F32:
					weapon_1.SetDesiredSpeed(XmlConvert.ToSingle(xmlNode.InnerText));
					continue;
					IL_F76:
					xmlNode.InnerText = xmlNode.InnerText.Replace(",", ".");
					weapon_1.DetonationDelay = XmlConvert.ToSingle(xmlNode.InnerText);
					continue;
					IL_FBE:
					IEnumerator enumerator4 = xmlNode.ChildNodes.GetEnumerator();
					try
					{
						while (enumerator4.MoveNext())
						{
							XmlNode xmlNode5 = (XmlNode)enumerator4.Current;
							int num2 = Conversions.ToInteger(xmlNode5.Name.Remove(0, 8));
							int key = num2;
							XmlNode xmlNode3;
							string innerText3 = (xmlNode3 = xmlNode5).InnerText;
							EmissionContainer value = EmissionContainer.smethod_0(ref innerText3);
							xmlNode3.InnerText = innerText3;
							weapon_1.ARM_SpecifiedEmission = new KeyValuePair<int, EmissionContainer>(key, value);
						}
						continue;
					}
					finally
					{
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
					}
					IL_104C:
					if (num <= 3251319825u)
					{
						if (num <= 3001749054u)
						{
							if (num <= 2904824734u)
							{
								if (num != 2883730117u)
								{
									if (num == 2904824734u && Operators.CompareString(name, "SBEO_Altitude_TF", false) == 0)
									{
										weapon_1.SBEngagedOffensive_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "CEP_Land", false) == 0)
									{
										weapon_1.SetCEP_Land(Conversions.ToInteger(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num != 2920208772u)
							{
								if (num != 2923116889u)
								{
									if (num != 3001749054u || Operators.CompareString(name, "Lat", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "SBR_ThrottleSetting", false) != 0)
									{
										continue;
									}
									string innerText4 = xmlNode.InnerText;
									if (Operators.CompareString(innerText4, "FullStop", false) == 0)
									{
										weapon_1.SBR_ThrottleSetting = ActiveUnit.Throttle.FullStop;
										continue;
									}
									if (Operators.CompareString(innerText4, "Loiter", false) == 0)
									{
										weapon_1.SBR_ThrottleSetting = ActiveUnit.Throttle.Loiter;
										continue;
									}
									if (Operators.CompareString(innerText4, "Cruise", false) == 0)
									{
										weapon_1.SBR_ThrottleSetting = ActiveUnit.Throttle.Cruise;
										continue;
									}
									if (Operators.CompareString(innerText4, "Full", false) == 0)
									{
										weapon_1.SBR_ThrottleSetting = ActiveUnit.Throttle.Full;
										continue;
									}
									if (Operators.CompareString(innerText4, "Flank", false) != 0)
									{
										weapon_1.SBR_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									weapon_1.SBR_ThrottleSetting = ActiveUnit.Throttle.Flank;
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Message", false) == 0)
								{
									weapon_1.Message = xmlNode.InnerText;
									continue;
								}
								continue;
							}
						}
						else if (num <= 3089922411u)
						{
							if (num != 3070770765u)
							{
								if (num == 3089922411u && Operators.CompareString(name, "CEP_Surface", false) == 0)
								{
									goto IL_126D;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "SBR_Altitude", false) == 0)
								{
									weapon_1.SBR_Altitude = XmlConvert.ToSingle(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num != 3189373444u)
						{
							if (num != 3204468496u)
							{
								if (num == 3251319825u && Operators.CompareString(name, "SBR_TF", false) == 0)
								{
									weapon_1.SBR_TerrainFollowing = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "SBEO", false) == 0)
								{
									weapon_1.SBEngagedOffensive = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "LonLR", false) == 0)
							{
								weapon_1.SetLongitudeLR(new double?(XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", "."))));
								continue;
							}
							continue;
						}
					}
					else if (num <= 3609180422u)
					{
						if (num <= 3352664703u)
						{
							if (num != 3283119613u)
							{
								if (num == 3352664703u && Operators.CompareString(name, "Weapon_Sensory", false) == 0)
								{
									ActiveUnit activeUnit = weapon_1;
									weapon_1.weapon_Sensory = Weapon_Sensory.Load(ref xmlNode, ref dictionary_0, ref activeUnit);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "CurrentSpeed", false) == 0)
								{
									goto IL_13E1;
								}
								continue;
							}
						}
						else if (num != 3389022305u)
						{
							if (num != 3559367371u)
							{
								if (num == 3609180422u && Operators.CompareString(name, "ARM_SpecifiedEmissionIsMandatory", false) == 0)
								{
									goto IL_1432;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "SBEO_ThrottleSetting", false) != 0)
								{
									continue;
								}
								string innerText5 = xmlNode.InnerText;
								if (Operators.CompareString(innerText5, "FullStop", false) == 0)
								{
									weapon_1.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.FullStop;
									continue;
								}
								if (Operators.CompareString(innerText5, "Loiter", false) == 0)
								{
									weapon_1.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Loiter;
									continue;
								}
								if (Operators.CompareString(innerText5, "Cruise", false) == 0)
								{
									weapon_1.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Cruise;
									continue;
								}
								if (Operators.CompareString(innerText5, "Full", false) == 0)
								{
									weapon_1.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Full;
									continue;
								}
								if (Operators.CompareString(innerText5, "Flank", false) != 0)
								{
									weapon_1.SBEngagedOffensive_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								weapon_1.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Flank;
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "SBED", false) == 0)
							{
								weapon_1.SBEngagedDefensive = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode.InnerText);
								continue;
							}
							continue;
						}
					}
					else if (num <= 3792306253u)
					{
						if (num != 3736393060u)
						{
							if (num == 3792306253u && Operators.CompareString(name, "Longitude_UnitEntersAreaCheck", false) == 0)
							{
								weapon_1.SetLongitude_UnitEntersAreaCheck(new double?(XmlConvert.ToDouble(xmlNode.InnerText)));
								continue;
							}
							continue;
						}
						else
						{
							if (Operators.CompareString(name, "ParentGroup", false) == 0)
							{
								weapon_1.ParentGroupName = xmlNode.InnerText;
								continue;
							}
							continue;
						}
					}
					else if (num != 4080539297u)
					{
						if (num != 4087976791u)
						{
							if (num == 4152621540u && Operators.CompareString(name, "CurrentHeading", false) == 0)
							{
								goto IL_15F7;
							}
							continue;
						}
						else
						{
							if (Operators.CompareString(name, "Weapon_Damage", false) == 0)
							{
								ActiveUnit activeUnit = weapon_1;
								weapon_1.weapon_Damage = Weapon_Damage.Load(ref xmlNode, ref dictionary_0, ref activeUnit);
								continue;
							}
							continue;
						}
					}
					else
					{
						if (Operators.CompareString(name, "IsAutoDetectable", false) == 0)
						{
							goto IL_1648;
						}
						continue;
					}
					IL_1119:
					weapon_1.SetLatitude(null, XmlConvert.ToDouble(xmlNode.InnerText));
					continue;
					IL_126D:
					weapon_1.SetCEP_Surface(Conversions.ToInteger(xmlNode.InnerText));
					continue;
					IL_13E1:
					weapon_1.SetCurrentSpeed(XmlConvert.ToSingle(xmlNode.InnerText));
					continue;
					IL_1432:
					weapon_1.ARM_SpecifiedEmissionIsMandatory = Conversions.ToBoolean(xmlNode.InnerText);
					continue;
					IL_15F7:
					weapon_1.SetCurrentHeading(XmlConvert.ToSingle(xmlNode.InnerText));
					continue;
					IL_1648:
					weapon_1.SetIsAutoDetectable(null, Conversions.ToBoolean(xmlNode.InnerText));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x0023D7D8 File Offset: 0x0023B9D8
		public override void vmethod_113(ref Scenario scenario_, Dictionary<string, Subject> dictionary_0, bool bool_21)
		{
			checked
			{
				try
				{
					base.vmethod_113(ref scenario_, dictionary_0, bool_21);
					if (!Information.IsNothing(this.DataLinkParentGuid))
					{
						scenario_.GetActiveUnits().TryGetValue(this.DataLinkParentGuid, ref this.DataLinkParent);
					}
					if (!Information.IsNothing(this.FiringParentGuid))
					{
						scenario_.GetActiveUnits().TryGetValue(this.FiringParentGuid, ref this.FiringParent);
					}
					if (!Information.IsNothing(this.SensorIlluminatingForMe))
					{
						using (IEnumerator<ActiveUnit> enumerator = scenario_.GetActiveUnits().Values.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Sensor[] noneMCMSensors = enumerator.Current.GetNoneMCMSensors();
								for (int i = 0; i < noneMCMSensors.Length; i++)
								{
									Sensor sensor = noneMCMSensors[i];
									if (string.CompareOrdinal(sensor.GetGuid(), this.SensorIlluminatingForMe) == 0)
									{
										this.m_Director = sensor;
										return;
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100883", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x0023D914 File Offset: 0x0023BB14
		public float GetCruiseAltitude_ASL()
		{
			return this.CruiseAltitude_ASL;
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x000273CF File Offset: 0x000255CF
		public void SetCruiseAltitude_ASL(float float_47)
		{
			this.CruiseAltitude_ASL = float_47;
		}

		// Token: 0x06005563 RID: 21859 RVA: 0x0023D92C File Offset: 0x0023BB2C
		public override float GetCurrentHeading()
		{
			return base.GetCurrentHeading();
		}

		// Token: 0x06005564 RID: 21860 RVA: 0x000273D8 File Offset: 0x000255D8
		public override void SetCurrentHeading(float float_47)
		{
			base.SetCurrentHeading(float_47);
		}

		// Token: 0x06005565 RID: 21861 RVA: 0x001913AC File Offset: 0x0018F5AC
		public override float GetDesiredAltitude()
		{
			return base.GetDesiredAltitude();
		}

		// Token: 0x06005566 RID: 21862 RVA: 0x000273E1 File Offset: 0x000255E1
		public override void SetDesiredAltitude(float float_47)
		{
			base.SetDesiredAltitude(float_47);
		}

		// Token: 0x06005567 RID: 21863 RVA: 0x0023D944 File Offset: 0x0023BB44
		public override float GetDesiredHeading(ActiveUnit._TurnRate enum0_1)
		{
			return base.GetDesiredHeading(enum0_1);
		}

		// Token: 0x06005568 RID: 21864 RVA: 0x000273EA File Offset: 0x000255EA
		public override void SetDesiredHeading(ActiveUnit._TurnRate enum0_1, float float_47)
		{
			base.SetDesiredHeading(enum0_1, float_47);
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x000273F4 File Offset: 0x000255F4
		internal virtual bool IsHypersonicGlideVehicle()
		{
			return this.GetWeaponType() == Weapon._WeaponType.HGV;
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x0023D95C File Offset: 0x0023BB5C
		public override float GetCurrentAltitude_ASL(bool DoSanityCheck = false)
		{
			return base.GetCurrentAltitude_ASL(DoSanityCheck);
		}

		// Token: 0x0600556B RID: 21867 RVA: 0x00027403 File Offset: 0x00025603
		public override void SetAltitude_ASL(bool DoSanityCheck, float value)
		{
			if (DoSanityCheck && base.IsGuidedWeapon() && value < 6.09599972f)
			{
				value = 6.09599972f;
			}
			base.SetAltitude_ASL(DoSanityCheck, value);
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x0023D974 File Offset: 0x0023BB74
		public override Sensor[] GetNoneMCMSensors()
		{
			return this.m_Sensors;
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x0023D98C File Offset: 0x0023BB8C
		public Sensor[] GetWeaponDirectors()
		{
			Sensor[] array = null;
			Sensor[] result;
			switch (this.GetGuidanceMethod())
			{
			case Weapon._GuidanceMethod.SemiActive:
			case Weapon._GuidanceMethod.const_1:
			case Weapon._GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance:
			case Weapon._GuidanceMethod.CommandGuided:
			case Weapon._GuidanceMethod.TrackViaMissile:
			case Weapon._GuidanceMethod.BeamRiding:
				array = new Sensor[]
				{
					this.GetDirector()
				};
				result = array;
				break;
			case (Weapon._GuidanceMethod)3:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				array = null;
				result = array;
				break;
			case Weapon._GuidanceMethod.PassiveTerminalGuidance:
			case Weapon._GuidanceMethod.INSMidcoursePlusPassiveTerminalGuidance:
			case Weapon._GuidanceMethod.const_5:
			case Weapon._GuidanceMethod.ActiveTerminalGuidance:
			case Weapon._GuidanceMethod.const_7:
			case Weapon._GuidanceMethod.InertialMidCoursePlusActiveTerminalGuidance:
			case Weapon._GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance:
			case Weapon._GuidanceMethod.TimeSharedSemiActiveMidCoursePlusActiveTerminalGuidance:
				array = this.GetNoneMCMSensors();
				result = array;
				break;
			case Weapon._GuidanceMethod.InertiallyGuided:
				array = null;
				result = array;
				break;
			default:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = array;
				break;
			}
			return result;
		}

		// Token: 0x0600556E RID: 21870 RVA: 0x0023DA38 File Offset: 0x0023BC38
		public override float GetDesiredSpeed()
		{
			return base.GetDesiredSpeed();
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x0002742F File Offset: 0x0002562F
		public override void SetDesiredSpeed(float float_47)
		{
			base.SetDesiredSpeed(float_47);
		}

		// 是否地形跟随
		public override bool IsTerrainFollowing(ActiveUnit activeUnit_3)
		{
			return this.bTerrainFollowing;
		}

		// 设置是否地形跟随
		public override void SetIsTerrainFollowing(ActiveUnit activeUnit_3, bool value)
		{
			this.bTerrainFollowing = value;
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x0023DA50 File Offset: 0x0023BC50
		public float GetPenetration(GlobalVariables.ArmorRating armorRating, GlobalVariables.TargetVisualSizeClass targetVisualSizeClass)
		{
			Warhead warhead = this.m_Warheads[0];
			float num;
			float result;
			if (armorRating == GlobalVariables.ArmorRating.None && this.GetWeaponType() == Weapon._WeaponType.Gun)
			{
				switch (targetVisualSizeClass)
				{
				case GlobalVariables.TargetVisualSizeClass.Stealthy:
					num = 100f;
					result = num;
					return result;
				case GlobalVariables.TargetVisualSizeClass.Small:
				{
					Warhead.WarheadCaliber caliber = warhead.Caliber;
					if (caliber - Warhead.WarheadCaliber.Gun_6_15mm > 1)
					{
						num = 100f;
						result = num;
						return result;
					}
					break;
				}
				case GlobalVariables.TargetVisualSizeClass.Medium:
				{
					Warhead.WarheadCaliber caliber2 = warhead.Caliber;
					if (caliber2 - Warhead.WarheadCaliber.Gun_6_15mm > 2)
					{
						num = 100f;
						result = num;
						return result;
					}
					break;
				}
				case GlobalVariables.TargetVisualSizeClass.Large:
				case GlobalVariables.TargetVisualSizeClass.VLarge:
				{
					Warhead.WarheadCaliber caliber3 = warhead.Caliber;
					if (caliber3 - Warhead.WarheadCaliber.Gun_6_15mm > 3)
					{
						num = 100f;
						result = num;
						return result;
					}
					break;
				}
				}
			}
			Warhead.WarheadType warheadType = warhead.warheadType;
			short num2 = 0;
			if (warheadType <= Warhead.WarheadType.Weapon)
			{
				if (warheadType <= Warhead.WarheadType.DepthCharge)
				{
					switch (warheadType)
					{
					case Warhead.WarheadType.HE_BlastFrag:
						goto IL_418;
					case Warhead.WarheadType.ArmorPiercing:
					case Warhead.WarheadType.SemiAP:
					case Warhead.WarheadType.HardTargetPenetrator:
						goto IL_475;
					case Warhead.WarheadType.HEAT:
						goto IL_3CA;
					case Warhead.WarheadType.Incendiary:
						num2 = 0;
						goto IL_A62;
					case Warhead.WarheadType.Fragmentation:
					case Warhead.WarheadType.ContinuousRod:
						break;
					case Warhead.WarheadType.HESH:
					case Warhead.WarheadType.FAE:
						goto IL_A62;
					case Warhead.WarheadType.SuperFrag:
					case Warhead.WarheadType.DirectionalContinousRod:
						if (armorRating <= GlobalVariables.ArmorRating.Armor_HMG)
						{
							if (armorRating <= GlobalVariables.ArmorRating.Armor_Handgun)
							{
								if (armorRating == GlobalVariables.ArmorRating.None)
								{
									num2 = 100;
									goto IL_A62;
								}
								if (armorRating == GlobalVariables.ArmorRating.Armor_Handgun)
								{
									num2 = 100;
									goto IL_A62;
								}
								goto IL_A62;
							}
							else
							{
								if (armorRating == GlobalVariables.ArmorRating.Armor_Rifle)
								{
									num2 = 90;
									goto IL_A62;
								}
								if (armorRating == GlobalVariables.ArmorRating.Armor_HMG)
								{
									num2 = 80;
									goto IL_A62;
								}
								goto IL_A62;
							}
						}
						else if (armorRating <= GlobalVariables.ArmorRating.RHA_25mm)
						{
							if (armorRating == GlobalVariables.ArmorRating.RHA_20mm)
							{
								num2 = 70;
								goto IL_A62;
							}
							if (armorRating == GlobalVariables.ArmorRating.RHA_25mm)
							{
								num2 = 60;
								goto IL_A62;
							}
							goto IL_A62;
						}
						else
						{
							if (armorRating == GlobalVariables.ArmorRating.RHA_30mm)
							{
								num2 = 50;
								goto IL_A62;
							}
							if (armorRating == GlobalVariables.ArmorRating.RHA_35mm)
							{
								num2 = 40;
								goto IL_A62;
							}
							switch (armorRating)
							{
							case GlobalVariables.ArmorRating.Light:
								num2 = 30;
								goto IL_A62;
							case GlobalVariables.ArmorRating.Medium:
								num = 0f;
								result = num;
								return result;
							case GlobalVariables.ArmorRating.Heavy:
								num = 0f;
								result = num;
								return result;
							case GlobalVariables.ArmorRating.Special:
								num = 0f;
								result = num;
								return result;
							default:
								goto IL_A62;
							}
						}
						break;
					default:
						if (warheadType - Warhead.WarheadType.Torpedo > 1)
						{
							goto IL_A62;
						}
						goto IL_418;
					}
				}
				else
				{
					if (warheadType == Warhead.WarheadType.Nuclear)
					{
						num2 = 0;
						goto IL_A62;
					}
					if (warheadType == Warhead.WarheadType.Weapon)
					{
						num = this.m_Warheads[0].GetWeaponFromDP(this.m_Scenario).GetPenetration(armorRating, targetVisualSizeClass);
						result = num;
						return result;
					}
					goto IL_A62;
				}
			}
			else if (warheadType <= Warhead.WarheadType.Cluster_AT)
			{
				if (warheadType != Warhead.WarheadType.Cluster_AP)
				{
					if (warheadType == Warhead.WarheadType.Cluster_AT)
					{
						goto IL_3CA;
					}
					goto IL_A62;
				}
			}
			else
			{
				if (warheadType == Warhead.WarheadType.Cluster_SmartSubs)
				{
					goto IL_418;
				}
				if (warheadType == Warhead.WarheadType.LongRodPenetrator)
				{
					goto IL_475;
				}
				if (warheadType - Warhead.WarheadType.Laser_COIL <= 3)
				{
					if (armorRating <= GlobalVariables.ArmorRating.Armor_HMG)
					{
						if (armorRating <= GlobalVariables.ArmorRating.Armor_Handgun)
						{
							if (armorRating == GlobalVariables.ArmorRating.None)
							{
								num2 = 100;
								goto IL_A62;
							}
							if (armorRating == GlobalVariables.ArmorRating.Armor_Handgun)
							{
								num2 = 80;
								goto IL_A62;
							}
						}
						else
						{
							if (armorRating == GlobalVariables.ArmorRating.Armor_Rifle)
							{
								num2 = 60;
								goto IL_A62;
							}
							if (armorRating == GlobalVariables.ArmorRating.Armor_HMG)
							{
								num2 = 50;
								goto IL_A62;
							}
						}
					}
					else if (armorRating <= GlobalVariables.ArmorRating.RHA_25mm)
					{
						if (armorRating == GlobalVariables.ArmorRating.RHA_20mm)
						{
							num2 = 40;
							goto IL_A62;
						}
						if (armorRating == GlobalVariables.ArmorRating.RHA_25mm)
						{
							num2 = 30;
							goto IL_A62;
						}
					}
					else
					{
						if (armorRating == GlobalVariables.ArmorRating.RHA_30mm)
						{
							num2 = 20;
							goto IL_A62;
						}
						if (armorRating == GlobalVariables.ArmorRating.RHA_35mm)
						{
							num2 = 10;
							goto IL_A62;
						}
					}
					num = 0f;
					result = num;
					return result;
				}
				goto IL_A62;
			}
			if (armorRating <= GlobalVariables.ArmorRating.Armor_HMG)
			{
				if (armorRating <= GlobalVariables.ArmorRating.Armor_Handgun)
				{
					if (armorRating == GlobalVariables.ArmorRating.None || armorRating == GlobalVariables.ArmorRating.Armor_Handgun)
					{
						num2 = 100;
						goto IL_A62;
					}
				}
				else if (armorRating == GlobalVariables.ArmorRating.Armor_Rifle || armorRating == GlobalVariables.ArmorRating.Armor_HMG)
				{
					num2 = 90;
					goto IL_A62;
				}
			}
			else if (armorRating <= GlobalVariables.ArmorRating.RHA_25mm)
			{
				if (armorRating == GlobalVariables.ArmorRating.RHA_20mm)
				{
					num2 = 80;
					goto IL_A62;
				}
				if (armorRating == GlobalVariables.ArmorRating.RHA_25mm)
				{
					num2 = 70;
					goto IL_A62;
				}
			}
			else
			{
				if (armorRating == GlobalVariables.ArmorRating.RHA_30mm)
				{
					num2 = 60;
					goto IL_A62;
				}
				if (armorRating == GlobalVariables.ArmorRating.RHA_35mm)
				{
					num2 = 55;
					goto IL_A62;
				}
				if (armorRating == GlobalVariables.ArmorRating.Light)
				{
					num2 = 50;
					goto IL_A62;
				}
			}
			num2 = 0;
			goto IL_A62;
			IL_3CA:
			switch (armorRating)
			{
			case GlobalVariables.ArmorRating.Medium:
				num2 = 60;
				goto IL_A62;
			case GlobalVariables.ArmorRating.Heavy:
				num2 = 35;
				goto IL_A62;
			case GlobalVariables.ArmorRating.Special:
				num2 = 15;
				goto IL_A62;
			default:
				num2 = 100;
				goto IL_A62;
			}
			IL_418:
			switch (armorRating)
			{
			case GlobalVariables.ArmorRating.Light:
				num2 = 90;
				goto IL_A62;
			case GlobalVariables.ArmorRating.Medium:
				num2 = 40;
				goto IL_A62;
			case GlobalVariables.ArmorRating.Heavy:
				num2 = 20;
				goto IL_A62;
			case GlobalVariables.ArmorRating.Special:
				num2 = 5;
				goto IL_A62;
			default:
				num2 = 100;
				goto IL_A62;
			}
			IL_475:
			Warhead._ExplosivesType explosivesType = warhead.ExplosivesType;
			switch (explosivesType)
			{
			case Warhead._ExplosivesType.const_47:
				if (armorRating <= GlobalVariables.ArmorRating.Armor_HMG)
				{
					if (armorRating <= GlobalVariables.ArmorRating.Armor_Handgun)
					{
						if (armorRating == GlobalVariables.ArmorRating.None)
						{
							num2 = 100;
						}
						else if (armorRating == GlobalVariables.ArmorRating.Armor_Handgun)
						{
							num2 = 85;
						}
					}
					else if (armorRating == GlobalVariables.ArmorRating.Armor_Rifle)
					{
						num2 = 80;
					}
					else if (armorRating == GlobalVariables.ArmorRating.Armor_HMG)
					{
						num2 = 75;
					}
				}
				else if (armorRating <= GlobalVariables.ArmorRating.RHA_25mm)
				{
					if (armorRating == GlobalVariables.ArmorRating.RHA_20mm)
					{
						num2 = 70;
					}
					else if (armorRating == GlobalVariables.ArmorRating.RHA_25mm)
					{
						num2 = 65;
					}
				}
				else if (armorRating == GlobalVariables.ArmorRating.RHA_30mm)
				{
					num2 = 60;
				}
				else if (armorRating == GlobalVariables.ArmorRating.RHA_35mm)
				{
					num2 = 55;
				}
				else
				{
					switch (armorRating)
					{
					case GlobalVariables.ArmorRating.Light:
						num2 = 50;
						break;
					case GlobalVariables.ArmorRating.Medium:
						num2 = 20;
						break;
					case GlobalVariables.ArmorRating.Heavy:
						num = 0f;
						result = num;
						return result;
					case GlobalVariables.ArmorRating.Special:
						num = 0f;
						result = num;
						return result;
					}
				}
				break;
			case Warhead._ExplosivesType.const_48:
				if (armorRating <= GlobalVariables.ArmorRating.Armor_HMG)
				{
					if (armorRating <= GlobalVariables.ArmorRating.Armor_Handgun)
					{
						if (armorRating == GlobalVariables.ArmorRating.None)
						{
							num2 = 100;
						}
						else if (armorRating == GlobalVariables.ArmorRating.Armor_Handgun)
						{
							num2 = 100;
						}
					}
					else if (armorRating == GlobalVariables.ArmorRating.Armor_Rifle)
					{
						num2 = 100;
					}
					else if (armorRating == GlobalVariables.ArmorRating.Armor_HMG)
					{
						num2 = 95;
					}
				}
				else if (armorRating <= GlobalVariables.ArmorRating.RHA_25mm)
				{
					if (armorRating == GlobalVariables.ArmorRating.RHA_20mm)
					{
						num2 = 90;
					}
					else if (armorRating == GlobalVariables.ArmorRating.RHA_25mm)
					{
						num2 = 85;
					}
				}
				else if (armorRating == GlobalVariables.ArmorRating.RHA_30mm)
				{
					num2 = 80;
				}
				else if (armorRating == GlobalVariables.ArmorRating.RHA_35mm)
				{
					num2 = 75;
				}
				else
				{
					switch (armorRating)
					{
					case GlobalVariables.ArmorRating.Light:
						num2 = 70;
						break;
					case GlobalVariables.ArmorRating.Medium:
						num2 = 50;
						break;
					case GlobalVariables.ArmorRating.Heavy:
						num2 = 20;
						break;
					case GlobalVariables.ArmorRating.Special:
						num = 0f;
						result = num;
						return result;
					}
				}
				break;
			case Warhead._ExplosivesType.const_49:
				if (armorRating <= GlobalVariables.ArmorRating.Armor_HMG)
				{
					if (armorRating <= GlobalVariables.ArmorRating.Armor_Handgun)
					{
						if (armorRating == GlobalVariables.ArmorRating.None)
						{
							num2 = 100;
						}
						else if (armorRating == GlobalVariables.ArmorRating.Armor_Handgun)
						{
							num2 = 100;
						}
					}
					else if (armorRating == GlobalVariables.ArmorRating.Armor_Rifle)
					{
						num2 = 100;
					}
					else if (armorRating == GlobalVariables.ArmorRating.Armor_HMG)
					{
						num2 = 100;
					}
				}
				else if (armorRating <= GlobalVariables.ArmorRating.RHA_25mm)
				{
					if (armorRating == GlobalVariables.ArmorRating.RHA_20mm)
					{
						num2 = 100;
					}
					else if (armorRating == GlobalVariables.ArmorRating.RHA_25mm)
					{
						num2 = 100;
					}
				}
				else if (armorRating == GlobalVariables.ArmorRating.RHA_30mm)
				{
					num2 = 95;
				}
				else if (armorRating == GlobalVariables.ArmorRating.RHA_35mm)
				{
					num2 = 90;
				}
				else
				{
					switch (armorRating)
					{
					case GlobalVariables.ArmorRating.Light:
						num2 = 85;
						break;
					case GlobalVariables.ArmorRating.Medium:
						num2 = 80;
						break;
					case GlobalVariables.ArmorRating.Heavy:
						num2 = 50;
						break;
					case GlobalVariables.ArmorRating.Special:
						num2 = 20;
						break;
					}
				}
				break;
			case Warhead._ExplosivesType.const_50:
				if (armorRating == GlobalVariables.ArmorRating.Heavy)
				{
					num2 = 80;
				}
				else
				{
					if (armorRating != GlobalVariables.ArmorRating.Special)
					{
						num = 100f;
						result = num;
						return result;
					}
					num2 = 50;
				}
				break;
			default:
				if (explosivesType != Warhead._ExplosivesType.const_54)
				{
					if (armorRating == GlobalVariables.ArmorRating.Heavy)
					{
						num2 = 80;
					}
					else
					{
						if (armorRating != GlobalVariables.ArmorRating.Special)
						{
							num = 100f;
							result = num;
							return result;
						}
						num2 = 50;
					}
				}
				else if (armorRating <= GlobalVariables.ArmorRating.Armor_HMG)
				{
					if (armorRating <= GlobalVariables.ArmorRating.Armor_Handgun)
					{
						if (armorRating == GlobalVariables.ArmorRating.None)
						{
							num2 = 100;
						}
						else if (armorRating == GlobalVariables.ArmorRating.Armor_Handgun)
						{
							num2 = 90;
						}
					}
					else if (armorRating == GlobalVariables.ArmorRating.Armor_Rifle)
					{
						num2 = 80;
					}
					else if (armorRating == GlobalVariables.ArmorRating.Armor_HMG)
					{
						num2 = 70;
					}
				}
				else if (armorRating <= GlobalVariables.ArmorRating.RHA_25mm)
				{
					if (armorRating == GlobalVariables.ArmorRating.RHA_20mm)
					{
						num2 = 60;
					}
					else if (armorRating == GlobalVariables.ArmorRating.RHA_25mm)
					{
						num2 = 50;
					}
				}
				else if (armorRating == GlobalVariables.ArmorRating.RHA_30mm)
				{
					num2 = 40;
				}
				else if (armorRating == GlobalVariables.ArmorRating.RHA_35mm)
				{
					num2 = 30;
				}
				else
				{
					switch (armorRating)
					{
					case GlobalVariables.ArmorRating.Light:
						num2 = 20;
						break;
					case GlobalVariables.ArmorRating.Medium:
						num = 0f;
						result = num;
						return result;
					case GlobalVariables.ArmorRating.Heavy:
						num = 0f;
						result = num;
						return result;
					case GlobalVariables.ArmorRating.Special:
						num = 0f;
						result = num;
						return result;
					}
				}
				break;
			}
			IL_A62:
			int num3 = GameGeneral.GetRandom().Next((int)(num2 - 15), (int)(num2 + 16));
			if (num3 > 100)
			{
				num = 100f;
			}
			else if (num3 < 0)
			{
				num = 0f;
			}
			else
			{
				num = (float)num3;
			}
			result = num;
			return result;
		}

		// Token: 0x06005573 RID: 21875 RVA: 0x0023E504 File Offset: 0x0023C704
		public bool method_132(bool bool_21)
		{
			Weapon._GuidanceMethod guidanceMethod = this.GetGuidanceMethod();
			bool result;
			if (guidanceMethod > Weapon._GuidanceMethod.const_1 && guidanceMethod - Weapon._GuidanceMethod.PassiveTerminalGuidance > 1 && guidanceMethod != Weapon._GuidanceMethod.BeamRiding)
			{
				result = false;
			}
			else
			{
				bool flag;
				if (base.GetAllNoneMCMSensors().Length > 0)
				{
					Sensor.SensorType sensorType = base.GetAllNoneMCMSensors()[0].sensorType;
					if (sensorType - Sensor.SensorType.Visual > 1 && sensorType != Sensor.SensorType.LaserSpotTracker)
					{
						result = false;
						return result;
					}
					flag = (!bool_21 || (!this.weaponCode.Weapon_INSNavigation && !this.weaponCode.Weapon_INS_w_GPSNavigation && !this.weaponCode.Weapon_TERCOMNavigation));
				}
				else
				{
					flag = false;
				}
				result = flag;
			}
			return result;
		}

		// 有效目标列表
		public List<string> GetValidTargetsList()
		{
			List<string> list = new List<string>();
			if (this.weaponTarget.IsAircraft)
			{
				list.Add("飞机");
			}
			if (this.weaponTarget.IsHelicopter)
			{
				list.Add("直升机");
			}
			if (this.weaponTarget.IsSubsurface)
			{
				list.Add("潜艇");
			}
			if (this.weaponTarget.IsSurfaceShip)
			{
				list.Add("水面舰艇");
			}
			if (this.weaponTarget.IsHardLandStructures)
			{
				list.Add("地面建筑物(硬)");
			}
			if (this.weaponTarget.IsSoftLandStructures)
			{
				list.Add("地面建筑物(软)");
			}
			if (this.weaponTarget.IsHardMobileUnit)
			{
				list.Add("机动平台(硬)");
			}
			if (this.weaponTarget.IsSoftMobileUnit)
			{
				list.Add("机动平台(软)");
			}
			if (this.weaponTarget.IsRadar)
			{
				list.Add("雷达");
			}
			if (this.weaponTarget.IsRunway)
			{
				list.Add("跑道");
			}
			if (this.weaponTarget.IsMine)
			{
				list.Add("水雷");
			}
			if (this.weaponTarget.IsGuidedWeapon)
			{
				list.Add("导弹与制导炸弹");
			}
			if (this.weaponTarget.IsTorpedoe)
			{
				list.Add("鱼雷");
			}
			return list;
		}

		// 武器类型对应的字符串
		public string GetWeaponTypeString()
		{
			Weapon._WeaponType weaponType = this.GetWeaponType();
			string text;
			string result;
			if (weaponType <= Weapon._WeaponType.DummyMine)
			{
				if (weaponType <= Weapon._WeaponType.GuidedProjectile)
				{
					if (weaponType == Weapon._WeaponType.None)
					{
						text = "无";
						result = text;
						return result;
					}
					switch (weaponType)
					{
					case Weapon._WeaponType.GuidedWeapon:
						text = "制导武器";
						result = text;
						return result;
					case Weapon._WeaponType.Rocket:
						text = "火箭";
						result = text;
						return result;
					case Weapon._WeaponType.IronBomb:
						text = "炸弹";
						result = text;
						return result;
					case Weapon._WeaponType.Gun:
						text = "火炮";
						result = text;
						return result;
					case Weapon._WeaponType.Decoy_Expendable:
						text = "可消耗诱饵";
						result = text;
						return result;
					case Weapon._WeaponType.Decoy_Towed:
						text = "拖曳诱饵";
						result = text;
						return result;
					case Weapon._WeaponType.Decoy_Vehicle:
						text = "诱饵车";
						result = text;
						return result;
					case Weapon._WeaponType.TrainingRound:
						text = "训练弹";
						result = text;
						return result;
					case Weapon._WeaponType.Dispenser:
						text = "布撒武器";
						result = text;
						return result;
					case Weapon._WeaponType.GuidedProjectile:
						text = "制导炮弹";
						result = text;
						return result;
					}
				}
				else
				{
					switch (weaponType)
					{
					case Weapon._WeaponType.SensorPod:
						text = "Sensor Pod";
						result = text;
						return result;
					case Weapon._WeaponType.DropTank:
						text = "Drop Tank";
						result = text;
						return result;
					case Weapon._WeaponType.BuddyStore:
						text = "Buddy Store";
						result = text;
						return result;
					case Weapon._WeaponType.FerryTank:
						text = "Ferry Tank";
						result = text;
						return result;
					default:
						switch (weaponType)
						{
						case Weapon._WeaponType.Torpedo:
							text = "鱼雷";
							result = text;
							return result;
						case Weapon._WeaponType.DepthCharge:
							text = "深水炸弹";
							result = text;
							return result;
						case Weapon._WeaponType.Sonobuoy:
							text = "声纳浮标";
							result = text;
							return result;
						case Weapon._WeaponType.BottomMine:
							text = "沉底雷";
							result = text;
							return result;
						case Weapon._WeaponType.MooredMine:
							text = "锚雷";
							result = text;
							return result;
						case Weapon._WeaponType.FloatingMine:
							text = "浮动水雷";
							result = text;
							return result;
						case Weapon._WeaponType.MovingMine:
							text = "移动水雷";
							result = text;
							return result;
						case Weapon._WeaponType.RisingMine:
							text = "上浮水雷";
							result = text;
							return result;
						case Weapon._WeaponType.DriftingMine:
							text = "漂雷";
							result = text;
							return result;
						case Weapon._WeaponType.DummyMine:
							text = "假水雷";
							result = text;
							return result;
						}
						break;
					}
				}
			}
			else if (weaponType <= Weapon._WeaponType.RV)
			{
				if (weaponType == Weapon._WeaponType.HeliTowedPackage)
				{
					text = "直升机拖曳包";
					result = text;
					return result;
				}
				if (weaponType == Weapon._WeaponType.RV)
				{
					text = "再入飞行器";
					result = text;
					return result;
				}
			}
			else
			{
				if (weaponType == Weapon._WeaponType.Laser)
				{
					text = "激光器";
					result = text;
					return result;
				}
				if (weaponType == Weapon._WeaponType.HGV)
				{
					text = "高超声速滑翔弹";
					result = text;
					return result;
				}
				switch (weaponType)
				{
				case Weapon._WeaponType.Cargo:
					text = "货物";
					result = text;
					return result;
				case Weapon._WeaponType.Troops:
					text = "部队";
					result = text;
					return result;
				case Weapon._WeaponType.Paratroops:
					text = "伞兵";
					result = text;
					return result;
				}
			}
			text = this.GetWeaponType().ToString();
			result = text;
			return result;
		}

		// 取单元类型
		public override GlobalVariables.ActiveUnitType GetUnitType()
		{
			return GlobalVariables.ActiveUnitType.Weapon;
		}

		// 取通信设备
		public override CommDevice[] GetCommDevices()
		{
			CommDevice[] commDevices;
			if (this.GetWeaponType() == Weapon._WeaponType.Sonobuoy)
			{
				commDevices = this.m_CommDevices;
			}
			else
			{
				commDevices = base.GetCommDevices();
			}
			return commDevices;
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x0023EA3C File Offset: 0x0023CC3C
		public bool method_135()
		{
			return base.IsGuidedWeapon_RV_HGV() && (this.TargetIsLandFacility() || this.TargetIsShipOrRadar()) && this.CruiseAltitude != 0f && this.GetEngines().Count > 0 && this.GetEngines()[0].altBands.Length == 1 && this.GetFuelRecs()[0].MaxQuantity > 600;
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x0023EAAC File Offset: 0x0023CCAC
		public bool method_136()
		{
			bool result;
			if (this.GetWeaponType() == Weapon._WeaponType.GuidedWeapon)
			{
				if (this.GetEngines().Count > 0 && this.GetEngines()[0].PropulsionType == Engine._PropulsionType.WeaponCoast && !this.IsDecoy())
				{
					result = false;
					return result;
				}
				if ((this.TargetIsLandFacility() || this.TargetIsShipOrRadar()) && this.WaypointNumber > 0)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// 是否地雷
		public bool IsMine()
		{
			bool result;
			switch (this.GetWeaponType())
			{
			case Weapon._WeaponType.BottomMine:
			case Weapon._WeaponType.MooredMine:
			case Weapon._WeaponType.FloatingMine:
			case Weapon._WeaponType.MovingMine:
			case Weapon._WeaponType.RisingMine:
				result = true;
				break;
			default:
				result = false;
				break;
			}
			return result;
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x0023EB68 File Offset: 0x0023CD68
		public bool method_138()
		{
			bool flag;
			bool result;
			if (this.GetGuidanceMethod() == Weapon._GuidanceMethod.InertiallyGuided)
			{
				Weapon._WeaponType weaponType = this.GetWeaponType();
				if (weaponType <= Weapon._WeaponType.RisingMine)
				{
					if (weaponType - Weapon._WeaponType.Rocket > 2 && weaponType - Weapon._WeaponType.DepthCharge > 6)
					{
						goto IL_5E;
					}
				}
				else if (weaponType != Weapon._WeaponType.RV && weaponType - Weapon._WeaponType.Cargo > 2)
				{
					goto IL_5E;
				}
				flag = true;
				goto IL_5A;
				IL_5E:
				result = false;
				return result;
			}
			flag = false;
			IL_5A:
			result = flag;
			return result;
		}

		// 战斗部毁伤点数
		public float GetTotalDamagePointsOfAllWarheads()
		{
			float num = 0f;
			Warhead[] warheads = this.m_Warheads;
			for (int i = 0; i < warheads.Length; i = checked(i + 1))
			{
				Warhead warhead = warheads[i];
				num += warhead.DP;
			}
			return num;
		}

		// Token: 0x0600557D RID: 21885 RVA: 0x0023EC14 File Offset: 0x0023CE14
		public float method_140(float altitude_asl, Contact_Base.ContactType contactType_)
		{
			float result = 0f;
			try
			{
				float num = this.LaunchAltitudeMax;
				float launchAltitudeMin = this.LaunchAltitudeMin;
				if (this.GetWeaponType() == Weapon._WeaponType.Gun)
				{
					num = this.GetRangeMaxToTargetType(contactType_) * 1852f / 2f;
				}
				if (altitude_asl > num)
				{
					result = this.GetRangeMaxToTargetType(contactType_);
				}
				else if (altitude_asl <= num && altitude_asl >= this.LaunchAltitudeMin)
				{
					float num2 = (altitude_asl - launchAltitudeMin) / (num - launchAltitudeMin);
					float num3;
					if (this.GetWeaponType() == Weapon._WeaponType.Gun)
					{
						num3 = 0.05f;
					}
					else
					{
						num3 = 0.5f;
					}
					float num4 = 1f;
					float num5 = num3 + (num4 - num3) * num2;
					result = Math.Max(this.GetRangeMaxToTargetType(contactType_), this.GetRangeMaxToTargetType(Contact_Base.ContactType.Submarine)) * num5;
				}
				else
				{
					result = -1f;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100884", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x0023ED40 File Offset: 0x0023CF40
		public float GetLargestRangeMaxOfAllDomains()
		{
			return Math.Max(this.RangeAAWMax, Math.Max(this.RangeASUWMax, Math.Max(this.RangeLandMax, this.RangeASWMax)));
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x0023ED78 File Offset: 0x0023CF78
		public float GetLargestRangeMinOfAllDomains()
		{
			return Math.Max(this.RangeAAWMin, Math.Max(this.RangeASUWMin, Math.Max(this.RangeLandMin, this.RangeASWMin)));
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x0023EDB0 File Offset: 0x0023CFB0
		public float GetCrossRangeAmbiguityLimit()
		{
			float num = 0f;
			float result;
			try
			{
				switch (this.GetGuidanceMethod())
				{
				case Weapon._GuidanceMethod.SemiActive:
				case Weapon._GuidanceMethod.CommandGuided:
				case Weapon._GuidanceMethod.TrackViaMissile:
				case Weapon._GuidanceMethod.BeamRiding:
				case Weapon._GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance:
				case Weapon._GuidanceMethod.TimeSharedSemiActiveMidCoursePlusActiveTerminalGuidance:
					num = 0f;
					result = num;
					return result;
				case Weapon._GuidanceMethod.const_1:
				case Weapon._GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance:
				case Weapon._GuidanceMethod.PassiveTerminalGuidance:
				case Weapon._GuidanceMethod.INSMidcoursePlusPassiveTerminalGuidance:
				case Weapon._GuidanceMethod.const_5:
				case Weapon._GuidanceMethod.ActiveTerminalGuidance:
				case Weapon._GuidanceMethod.const_7:
				case Weapon._GuidanceMethod.InertialMidCoursePlusActiveTerminalGuidance:
					if (this.GetNoneMCMSensors().Length == 0)
					{
						num = 0f;
						result = num;
						return result;
					}
					num = this.GetNoneMCMSensors().OrderByDescending(Weapon.CombinedPortAndStarboardArcsForSensor).ElementAtOrDefault(0).GetCombinedPortAndStarboardArcs();
					result = num;
					return result;
				case (Weapon._GuidanceMethod)3:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw new NotImplementedException();
				case Weapon._GuidanceMethod.InertiallyGuided:
					if (this.m_Warheads[0].warheadType == Warhead.WarheadType.Weapon)
					{
						Weapon weaponFromDP = this.m_Warheads[0].GetWeaponFromDP(this.m_Scenario);
						if (weaponFromDP.GetNoneMCMSensors().Length > 0)
						{
							num = weaponFromDP.GetNoneMCMSensors()[0].GetCombinedPortAndStarboardArcs();
							result = num;
							return result;
						}
						if (weaponFromDP.m_Warheads.Length <= 0)
						{
							num = 0f;
							result = num;
							return result;
						}
						if (weaponFromDP.m_Warheads[0].method_13())
						{
							Weapon._WeaponType weaponType = weaponFromDP.GetWeaponType();
							if (weaponType <= Weapon._WeaponType.DepthCharge)
							{
								if (weaponType - Weapon._WeaponType.GuidedWeapon <= 3 || weaponType == Weapon._WeaponType.GuidedProjectile)
								{
									goto IL_1AE;
								}
								if (weaponType - Weapon._WeaponType.Torpedo > 1)
								{
									goto IL_1CB;
								}
							}
							else if (weaponType - Weapon._WeaponType.BottomMine > 4)
							{
								if (weaponType == Weapon._WeaponType.RV || weaponType == Weapon._WeaponType.HGV)
								{
									goto IL_1AE;
								}
								goto IL_1CB;
							}
							Weapon._DetonationMedium detonationMedium_ = Weapon._DetonationMedium.Underwater;
							goto IL_1B1;
							IL_1AE:
							detonationMedium_ = Weapon._DetonationMedium.Air;
							IL_1B1:
							num = Explosion.smethod_1((double)weaponFromDP.m_Warheads[0].DP, detonationMedium_);
							result = num;
							return result;
							IL_1CB:
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw new NotImplementedException();
						}
					}
					num = 0f;
					result = num;
					return result;
				default:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw new NotImplementedException();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100885", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = 0f;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x0023F018 File Offset: 0x0023D218
		public bool IsContactBomb()
		{
			Weapon._WeaponType weaponType = this.GetWeaponType();
			return weaponType - Weapon._WeaponType.ContactBomb_Suicide <= 1;
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x0023F03C File Offset: 0x0023D23C
		public float GetDownRangeAmbiguityLimit()
		{
			float num = 0f;
			float result;
			try
			{
				if (!this.IsContactBomb())
				{
					switch (this.GetGuidanceMethod())
					{
					case Weapon._GuidanceMethod.SemiActive:
					case Weapon._GuidanceMethod.CommandGuided:
					case Weapon._GuidanceMethod.TrackViaMissile:
					case Weapon._GuidanceMethod.BeamRiding:
					case Weapon._GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance:
					case Weapon._GuidanceMethod.TimeSharedSemiActiveMidCoursePlusActiveTerminalGuidance:
						num = 0f;
						result = num;
						return result;
					case Weapon._GuidanceMethod.const_1:
					case Weapon._GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance:
					case Weapon._GuidanceMethod.PassiveTerminalGuidance:
					case Weapon._GuidanceMethod.INSMidcoursePlusPassiveTerminalGuidance:
					case Weapon._GuidanceMethod.const_5:
					case Weapon._GuidanceMethod.ActiveTerminalGuidance:
					case Weapon._GuidanceMethod.const_7:
					case Weapon._GuidanceMethod.InertialMidCoursePlusActiveTerminalGuidance:
						num = this.GetLargestRangeMaxOfAllDomains();
						result = num;
						return result;
					case (Weapon._GuidanceMethod)3:
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new NotImplementedException();
					case Weapon._GuidanceMethod.InertiallyGuided:
						if (this.m_Warheads[0].warheadType == Warhead.WarheadType.Weapon)
						{
							Weapon weaponFromDP = this.m_Warheads[0].GetWeaponFromDP(this.m_Scenario);
							if (weaponFromDP.GetNoneMCMSensors().Length > 0)
							{
								num = weaponFromDP.GetNoneMCMSensors()[0].GetCombinedPortAndStarboardArcs();
								result = num;
								return result;
							}
							if (weaponFromDP.m_Warheads.Length <= 0)
							{
								num = 0f;
								result = num;
								return result;
							}
							if (weaponFromDP.m_Warheads[0].method_13())
							{
								Weapon._WeaponType weaponType = weaponFromDP.GetWeaponType();
								if (weaponType <= Weapon._WeaponType.DepthCharge)
								{
									if (weaponType - Weapon._WeaponType.GuidedWeapon <= 3)
									{
										goto IL_178;
									}
									if (weaponType - Weapon._WeaponType.Torpedo > 1)
									{
										goto IL_198;
									}
								}
								else if (weaponType - Weapon._WeaponType.BottomMine > 4)
								{
									if (weaponType == Weapon._WeaponType.RV || weaponType == Weapon._WeaponType.HGV)
									{
										goto IL_178;
									}
									goto IL_198;
								}
								Weapon._DetonationMedium detonationMedium_ = Weapon._DetonationMedium.Underwater;
								goto IL_17B;
								IL_178:
								detonationMedium_ = Weapon._DetonationMedium.Air;
								IL_17B:
								num = Explosion.smethod_1((double)weaponFromDP.m_Warheads[0].DP, detonationMedium_);
								result = num;
								return result;
								IL_198:
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								throw new NotImplementedException();
							}
						}
						if (this.m_Warheads[0].method_13())
						{
							Weapon._WeaponType weaponType2 = this.GetWeaponType();
							if (weaponType2 <= Weapon._WeaponType.DepthCharge)
							{
								if (weaponType2 - Weapon._WeaponType.GuidedWeapon <= 3 || weaponType2 == Weapon._WeaponType.GuidedProjectile)
								{
									goto IL_22F;
								}
								if (weaponType2 - Weapon._WeaponType.Torpedo > 1)
								{
									goto IL_24C;
								}
							}
							else if (weaponType2 - Weapon._WeaponType.BottomMine > 4)
							{
								if (weaponType2 == Weapon._WeaponType.RV || weaponType2 == Weapon._WeaponType.HGV)
								{
									goto IL_22F;
								}
								goto IL_24C;
							}
							Weapon._DetonationMedium detonationMedium_2 = Weapon._DetonationMedium.Underwater;
							goto IL_232;
							IL_22F:
							detonationMedium_2 = Weapon._DetonationMedium.Air;
							IL_232:
							num = Explosion.smethod_1((double)this.m_Warheads[0].DP, detonationMedium_2);
							result = num;
							return result;
							IL_24C:
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw new NotImplementedException();
						}
						num = 0f;
						result = num;
						return result;
					default:
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new NotImplementedException();
					}
				}
				else
				{
					num = 0f;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200294", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = 0f;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x0023F330 File Offset: 0x0023D530
		public bool HasDatalinkParentForGuidance()
		{
			Weapon._GuidanceMethod guidanceMethod = this.GetGuidanceMethod();
			bool result;
			if (guidanceMethod != Weapon._GuidanceMethod.SemiActive && guidanceMethod != Weapon._GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance)
			{
				switch (guidanceMethod)
				{
				case Weapon._GuidanceMethod.const_5:
				case Weapon._GuidanceMethod.const_7:
				case Weapon._GuidanceMethod.CommandGuided:
				case Weapon._GuidanceMethod.BeamRiding:
				case Weapon._GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance:
				case Weapon._GuidanceMethod.TimeSharedSemiActiveMidCoursePlusActiveTerminalGuidance:
					result = !Information.IsNothing(this.GetDataLinkParent());
					break;
				case Weapon._GuidanceMethod.ActiveTerminalGuidance:
				case Weapon._GuidanceMethod.InertialMidCoursePlusActiveTerminalGuidance:
				case Weapon._GuidanceMethod.TrackViaMissile:
				case Weapon._GuidanceMethod.InertiallyGuided:
					result = false;
					break;
				default:
					result = false;
					break;
				}
			}
			else
			{
				result = !Information.IsNothing(this.GetDataLinkParent());
			}
			return result;
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x0023F3AC File Offset: 0x0023D5AC
		public bool HasSensorWithCodeOfClassification_BrilliantWeapon()
		{
			Sensor[] noneMCMSensors = this.GetNoneMCMSensors();
			checked
			{
				bool result;
				for (int i = 0; i < noneMCMSensors.Length; i++)
				{
					if (noneMCMSensors[i].sensorCode.Classification_BrilliantWeapon)
					{
						result = true;
						return result;
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x0023F3EC File Offset: 0x0023D5EC
		public bool IsGuidingToTarget()
		{
			bool result = false;
			try
			{
				Weapon._GuidanceMethod guidanceMethod = this.GetGuidanceMethod();
				if (guidanceMethod == Weapon._GuidanceMethod.InertiallyGuided)
				{
					if (!this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
					{
						result = true;
					}
					else
					{
						Waypoint waypoint = this.GetWeaponNavigator().GetPlottedCourse()[this.GetWeaponNavigator().GetPlottedCourse().Count<Waypoint>() - 1];
						float distance = Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), waypoint.GetLatitude(), waypoint.GetLongitude());
						float distance2 = Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), this.LaunchPoint.GetLatitude(), this.LaunchPoint.GetLongitude());
						result = (distance < distance2);
					}
				}
				else
				{
					result = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100887", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x0023F510 File Offset: 0x0023D710
		public Weapon._WeaponType GetWeaponType()
		{
			return this.weaponType;
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x0002744C File Offset: 0x0002564C
		public void SetWeaponType(Weapon._WeaponType WeaponType_)
		{
			this.weaponType = WeaponType_;
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x0023F528 File Offset: 0x0023D728
		public Weapon._GuidanceMethod GetGuidanceMethod()
		{
			if (!this.GuidanceMethod.HasValue)
			{
				this.SetDefaultGuidanceMethod();
			}
			return this.GuidanceMethod.Value;
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x0023F558 File Offset: 0x0023D758
		public Sensor GetDirector()
		{
			return this.m_Director;
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x00027455 File Offset: 0x00025655
		public void SetDirector(Sensor sensor_)
		{
			this.m_Director = sensor_;
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x0023F570 File Offset: 0x0023D770
		public int GetCEP_Surface()
		{
			return this.CEP_Surface;
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x0002745E File Offset: 0x0002565E
		public void SetCEP_Surface(int value)
		{
			this.CEP_Surface = value;
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x0023F588 File Offset: 0x0023D788
		public int GetCEP_Land()
		{
			return this.CEP_Land;
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x00027467 File Offset: 0x00025667
		public void SetCEP_Land(int value)
		{
			this.CEP_Land = value;
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x0023F5A0 File Offset: 0x0023D7A0
		public bool IsNotSensorPod()
		{
			Weapon._WeaponType weaponType = this.weaponType;
			bool result;
			switch (weaponType)
			{
			case Weapon._WeaponType.Decoy_Expendable:
			case Weapon._WeaponType.Decoy_Towed:
			case Weapon._WeaponType.Decoy_Vehicle:
				break;
			default:
				if (weaponType != Weapon._WeaponType.SensorPod)
				{
					result = false;
					return result;
				}
				break;
			}
			result = true;
			return result;
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x0023F5E0 File Offset: 0x0023D7E0
		public ActiveUnit GetFiringParent()
		{
			ActiveUnit result;
			if (Information.IsNothing(this.FiringParent))
			{
				result = null;
			}
			else
			{
				result = this.FiringParent;
			}
			return result;
		}

		// Token: 0x06005591 RID: 21905 RVA: 0x00027470 File Offset: 0x00025670
		public void SetFiringParent(ActiveUnit activeUnit_)
		{
			this.FiringParent = activeUnit_;
			if (Information.IsNothing(activeUnit_))
			{
				this.FiringParentGuid = null;
			}
			else
			{
				this.FiringParentGuid = activeUnit_.GetGuid();
			}
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x0023F610 File Offset: 0x0023D810
		public ActiveUnit GetDataLinkParent()
		{
			ActiveUnit result;
			if (Information.IsNothing(this.DataLinkParent))
			{
				result = null;
			}
			else if (this.DataLinkParent.IsNotActive())
			{
				result = null;
			}
			else
			{
				result = this.DataLinkParent;
			}
			return result;
		}

		// Token: 0x06005593 RID: 21907 RVA: 0x0023F654 File Offset: 0x0023D854
		public void SetDataLinkParent(ActiveUnit activeUnit_)
		{
			checked
			{
				if (activeUnit_ == null)
				{
					CommDevice[] commDevices = this.GetCommDevices();
					for (int i = 0; i < commDevices.Length; i++)
					{
						commDevices[i].SetOccupiedChannels(0);
					}
					this.SetDefaultGuidanceMethod();
				}
				this.DataLinkParent = activeUnit_;
				Information.IsNothing(this.DataLinkParent);
			}
		}

		// 取到目标的最大距离
		public float GetMaxRangeToTarget(ActiveUnit activeUnit_, Contact theTarget, bool bool_21, Doctrine doctrine_, bool bool_22)
		{
			float num = 0f;
			float result;
			try
			{
				if (!bool_22 && !Information.IsNothing(doctrine_) && !Information.IsNothing(activeUnit_) && this.GetWeaponType() == Weapon._WeaponType.Gun && theTarget.IsSurfaceOrLandTarget() && activeUnit_.IsAircraft)
				{
					Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargetsDoctrine = doctrine_.GetGunStrafeGroundTargetsDoctrine(this.m_Scenario, false, false, false);
					byte? b = gunStrafeGroundTargetsDoctrine.HasValue ? new byte?((byte)gunStrafeGroundTargetsDoctrine.GetValueOrDefault()) : null;
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						num = 0f;
						result = num;
						return result;
					}
				}
				if (Information.IsNothing(theTarget.ActualUnit))
				{
					if (this.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
					{
						num = this.GetRangeMaxToTargetType(Contact_Base.ContactType.Air);
					}
					else if (this.IsShip)
					{
						num = this.GetRangeMaxToTargetType(Contact_Base.ContactType.Surface);
					}
					else if (this.IsFacility)
					{
						num = this.GetRangeMaxToTargetType(Contact_Base.ContactType.Facility_Fixed);
					}
					else if (this.IsSubmarine)
					{
						num = this.GetRangeMaxToTargetType(Contact_Base.ContactType.Submarine);
					}
					else
					{
						num = this.GetLargestRangeMaxOfAllDomains();
					}
				}
				else
				{
					ActiveUnit actualUnit = theTarget.ActualUnit;
					float num2;
					if (Information.IsNothing(actualUnit))
					{
						num2 = this.GetRangeMaxToTargetType(theTarget.contactType);
					}
					else if (actualUnit.IsSubmarine && ((Submarine)actualUnit).IsShallowerThanPeriscopeDepth())
					{
						if (this.GetRangeMaxToTargetType(Contact_Base.ContactType.Submarine) == 0f)
						{
							num2 = this.GetRangeMaxToTargetType(Contact_Base.ContactType.Surface);
						}
						else
						{
							num2 = this.GetRangeMaxToTargetType(Contact_Base.ContactType.Submarine);
						}
					}
					else if (actualUnit.IsAircraft && ((Aircraft)actualUnit).IsAirship())
					{
						num2 = Math.Max(this.GetRangeMaxToTargetType(Contact_Base.ContactType.Air), this.GetRangeMaxToTargetType(Contact_Base.ContactType.Surface));
					}
					else
					{
						num2 = this.GetRangeMaxToTargetType(theTarget.contactType);
					}
					if (bool_21 && num2 > 0f && !Information.IsNothing(doctrine_))
					{
						Doctrine doctrine = doctrine_;
						Weapon weapon = this;
						if (doctrine.IsLethalWeapon(ref weapon))
						{
							Doctrine doctrine2 = this.m_Doctrine;
							weapon = this;
							Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = this.m_Doctrine.GetWRA_WeaponTargetType(ref theTarget);
							Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType2 = doctrine2.GetWRA_WeaponTargetType(ref weapon, ref doctrine_, ref theTarget, ref wRA_WeaponTargetType);
							Doctrine doctrine3 = doctrine_;
							Scenario scenario = this.m_Scenario;
							Doctrine._WRA_WeaponTargetType selectedNodeTargetType = wRA_WeaponTargetType2;
							int? num3 = null;
							int? num4 = null;
							num4 = doctrine3.GetWeaponQty(scenario, this, selectedNodeTargetType, false, ref num3, ref num4);
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num2 = 0f;
							}
							if (num2 > 0f)
							{
								Doctrine doctrine4 = doctrine_;
								Scenario scenario2 = this.m_Scenario;
								int dBID = this.DBID;
								Doctrine._WRA_WeaponTargetType selectedNodeTargetType2 = wRA_WeaponTargetType2;
								num4 = null;
								num3 = null;
								int? firingRange = doctrine4.GetFiringRange(scenario2, dBID, selectedNodeTargetType2, false, ref num4, ref num3);
								if (!Information.IsNothing(firingRange))
								{
									num3 = firingRange;
									if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										num2 = 0f;
									}
									num3 = firingRange;
									if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() > 0) : null).GetValueOrDefault() && (float)firingRange.Value < num2)
									{
										num2 = (float)firingRange.Value;
									}
								}
							}
						}
					}
					num = num2;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200582", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = 0f;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x0023FAB8 File Offset: 0x0023DCB8
		private float GetRangeMaxToTargetType(Contact_Base.ContactType Target)
		{
			switch (Target)
			{
			case Contact_Base.ContactType.Air:
			case Contact_Base.ContactType.Missile:
			case Contact_Base.ContactType.Orbital:
			{
				float num = this.RangeAAWMax;
				float result = num;
				return result;
			}
			case Contact_Base.ContactType.Surface:
			case Contact_Base.ContactType.UndeterminedNaval:
			case Contact_Base.ContactType.Mine:
			case Contact_Base.ContactType.ActivationPoint:
			{
				float num = this.RangeASUWMax;
				float result = num;
				return result;
			}
			case Contact_Base.ContactType.Submarine:
			case Contact_Base.ContactType.Torpedo:
			{
				float num = this.RangeASWMax;
				float result = num;
				return result;
			}
			case Contact_Base.ContactType.Aimpoint:
			case Contact_Base.ContactType.Facility_Fixed:
			case Contact_Base.ContactType.Facility_Mobile:
			{
				float num = this.RangeLandMax;
				float result = num;
				return result;
			}
			case Contact_Base.ContactType.Decoy_Air:
			{
				float num = this.RangeAAWMax;
				float result = num;
				return result;
			}
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x0023FB78 File Offset: 0x0023DD78
		public float GetBlindTime()
		{
			return this.BlindTime;
		}

		// 设置被致盲时长
		public void SetBlindTime(float BT)
		{
			this.BlindTime = BT;
			if (this.BlindTime > 5f && (Information.IsNothing(this.GetDataLinkParent()) || this.GetGuidanceMethod() == Weapon._GuidanceMethod.TrackViaMissile))
			{
				Weapon._GuidanceMethod guidanceMethod = this.GetGuidanceMethod();
				if (guidanceMethod - Weapon._GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance <= 1)
				{
					this.method_212(true, true, false);
				}
				else
				{
					this.m_Scenario.RemoveUnit(this);
					if (this.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
					{
						base.LogMessage(string.Concat(new string[]
						{
							"武器: ",
							this.Name,
							"被致盲超过",
							Conversions.ToString((int)Math.Round((double)this.BlindTime)),
							"秒... 自毁."
						}), LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
					}
					else
					{
						base.LogMessage(string.Concat(new string[]
						{
							"武器: ",
							this.Name,
							"被致盲超过",
							Conversions.ToString((int)Math.Round((double)this.BlindTime)),
							"秒... 丢失目标."
						}), LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
					}
				}
			}
		}

		// Token: 0x06005598 RID: 21912 RVA: 0x0023FCF0 File Offset: 0x0023DEF0
		public float GetDRT()
		{
			return this.DRT;
		}

		// Token: 0x06005599 RID: 21913 RVA: 0x00027499 File Offset: 0x00025699
		public void SetDRT(float value)
		{
			this.DRT = value;
		}

		// Token: 0x0600559A RID: 21914 RVA: 0x000081A2 File Offset: 0x000063A2
		public override bool IsPlatform()
		{
			return false;
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x0023FD08 File Offset: 0x0023DF08
		public Weapon_Navigator GetWeaponNavigator()
		{
			if (Information.IsNothing(this.weapon_Navigator))
			{
				ActiveUnit activeUnit = this;
				this.weapon_Navigator = new Weapon_Navigator(ref activeUnit);
			}
			return this.weapon_Navigator;
		}

		// 取武器的AI
		public virtual Weapon_AI GetWeaponAI()
		{
			if (Information.IsNothing(this.weapon_AI))
			{
				this.weapon_AI = new Weapon_AI(this);
			}
			return this.weapon_AI;
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x0023FD70 File Offset: 0x0023DF70
		public virtual Weapon_Kinematics GetWeaponKinematics()
		{
			if (Information.IsNothing(this.weapon_Kinematics))
			{
				ActiveUnit activeUnit = this;
				this.weapon_Kinematics = new Weapon_Kinematics(ref activeUnit);
			}
			return this.weapon_Kinematics;
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x0023FDA4 File Offset: 0x0023DFA4
		public Weapon_Sensory GetWeaponSensory()
		{
			if (Information.IsNothing(this.weapon_Sensory))
			{
				ActiveUnit activeUnit = this;
				this.weapon_Sensory = new Weapon_Sensory(ref activeUnit);
			}
			return this.weapon_Sensory;
		}

		// Token: 0x0600559F RID: 21919 RVA: 0x0023FDD8 File Offset: 0x0023DFD8
		public Weapon_CommStuff GetWeaponCommStuff()
		{
			if (Information.IsNothing(this.weapon_CommStuff))
			{
				ActiveUnit activeUnit = this;
				this.weapon_CommStuff = new Weapon_CommStuff(ref activeUnit);
			}
			return this.weapon_CommStuff;
		}

		// Token: 0x060055A0 RID: 21920 RVA: 0x0023FE0C File Offset: 0x0023E00C
		public Weapon_Damage GetWeaponDamage()
		{
			if (Information.IsNothing(this.weapon_Damage))
			{
				ActiveUnit activeUnit = this;
				this.weapon_Damage = new Weapon_Damage(ref activeUnit);
			}
			return this.weapon_Damage;
		}

		// Token: 0x060055A1 RID: 21921 RVA: 0x000274A2 File Offset: 0x000256A2
		public bool HasNuclearWarhead()
		{
			return this.m_Warheads.Length != 0 && this.m_Warheads[0].HasNuclearWarhead(this.m_Scenario);
		}

		// Token: 0x060055A2 RID: 21922 RVA: 0x000274C4 File Offset: 0x000256C4
		public bool IsLongRangeAAWWeapon()
		{
			return this.RangeAAWMax > 15f;
		}

		// Token: 0x060055A3 RID: 21923 RVA: 0x000274D3 File Offset: 0x000256D3
		public bool IsShortRangeAAWGuideWeapon()
		{
			return this.GetWeaponType() == Weapon._WeaponType.GuidedWeapon && this.RangeAAWMax <= 15f;
		}

		// Token: 0x060055A4 RID: 21924 RVA: 0x000274F5 File Offset: 0x000256F5
		public bool method_176()
		{
			return Math.Max(this.RangeASUWMax, Math.Max(this.RangeLandMax, this.RangeASWMax)) >= 6f;
		}

		// Token: 0x060055A5 RID: 21925 RVA: 0x0002751D File Offset: 0x0002571D
		public bool method_177()
		{
			return base.IsGuidedWeapon() && this.GetEngines().Count == 1 && this.GetEngines()[0].PropulsionType == Engine._PropulsionType.WeaponCoast;
		}

		// 取经度
		public override double GetLongitude(bool? _HintIsOperating = null)
		{
			return this.longitude;
		}

		// 设置经度
		public override void SetLongitude(bool? _HintIsOperating, double value)
		{
			this.longitude = value;
		}

		// 取纬度
		public override double GetLatitude(bool? _HintIsOperating = null)
		{
			return this.latitude;
		}

		// 设置纬度
		public override void SetLatitude(bool? _HintIsOperating, double value)
		{
			this.latitude = value;
		}

		// 目标是否地面设施
		public bool TargetIsLandFacility()
		{
			return this.weaponTarget.IsHardLandStructures || this.weaponTarget.IsSoftLandStructures || this.weaponTarget.IsHardMobileUnit || this.weaponTarget.IsSoftMobileUnit || this.weaponTarget.IsRunway || this.weaponTarget.IsRadar;
		}

		// 目标是舰船或雷达吗？
		public bool TargetIsShipOrRadar()
		{
			return this.weaponTarget.IsSurfaceShip || this.weaponTarget.IsRadar;
		}

		// Token: 0x060055AC RID: 21932 RVA: 0x0002757F File Offset: 0x0002577F
		public bool TargetIsSubsurface()
		{
			return !Information.IsNothing(this.weaponTarget) && this.weaponTarget.IsSubsurface;
		}

		// Token: 0x060055AD RID: 21933 RVA: 0x0002759C File Offset: 0x0002579C
		public bool TargetIsRadar()
		{
			return this.weaponTarget.IsRadar;
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x0023FE9C File Offset: 0x0023E09C
		public bool WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon()
		{
			return this.GetWeaponType() != Weapon._WeaponType.Decoy_Vehicle && this.GetWeaponType() != Weapon._WeaponType.Decoy_Expendable && this.GetWeaponType() != Weapon._WeaponType.Decoy_Towed && !Information.IsNothing(this.weaponTarget) && (this.weaponTarget.IsGuidedWeapon || this.weaponTarget.IsAircraft);
		}

		// Token: 0x060055AF RID: 21935 RVA: 0x000275A9 File Offset: 0x000257A9
		public bool IsAntiAircraftOrMissileGuidedWeapon()
		{
			return this.GetWeaponType() == Weapon._WeaponType.GuidedWeapon && !Information.IsNothing(this.weaponTarget) && (this.weaponTarget.IsGuidedWeapon || this.weaponTarget.IsAircraft);
		}

		// Token: 0x060055B0 RID: 21936 RVA: 0x0023FEFC File Offset: 0x0023E0FC
		public bool IsTorpedoSonobuoyOrMine()
		{
			Weapon._WeaponType weaponType = this.GetWeaponType();
			bool flag = false;
			bool result;
			if (weaponType != Weapon._WeaponType.GuidedWeapon && weaponType != Weapon._WeaponType.Decoy_Vehicle)
			{
				switch (weaponType)
				{
				case Weapon._WeaponType.Torpedo:
					result = true;
					break;
				case Weapon._WeaponType.DepthCharge:
				case (Weapon._WeaponType)4010:
					result = false;
					break;
				case Weapon._WeaponType.Sonobuoy:
					result = true;
					break;
				case Weapon._WeaponType.BottomMine:
				case Weapon._WeaponType.MooredMine:
				case Weapon._WeaponType.FloatingMine:
				case Weapon._WeaponType.MovingMine:
				case Weapon._WeaponType.RisingMine:
				case Weapon._WeaponType.DriftingMine:
				case Weapon._WeaponType.DummyMine:
					result = true;
					break;
				default:
					result = false;
					break;
				}
			}
			else
			{
				result = flag;
			}
			return result;
		}

		// Token: 0x060055B1 RID: 21937 RVA: 0x000275E3 File Offset: 0x000257E3
		public bool TargetIsSatellite()
		{
			return this.weaponTarget.IsSatellite;
		}

		// Token: 0x060055B2 RID: 21938 RVA: 0x000275F0 File Offset: 0x000257F0
		public bool IsRVorHGV()
		{
			return this.GetWeaponType() == Weapon._WeaponType.RV | this.GetWeaponType() == Weapon._WeaponType.HGV;
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x0023FF84 File Offset: 0x0023E184
		public bool method_187()
		{
			Weapon._GuidanceMethod guidanceMethod = this.GetGuidanceMethod();
			return guidanceMethod - Weapon._GuidanceMethod.const_1 <= 1 || guidanceMethod - Weapon._GuidanceMethod.INSMidcoursePlusPassiveTerminalGuidance <= 4;
		}

		// Token: 0x060055B4 RID: 21940 RVA: 0x0002760D File Offset: 0x0002580D
		public override bool IsOperating()
		{
			return !base.IsNotActive();
		}

		// Token: 0x060055B5 RID: 21941 RVA: 0x0023FFAC File Offset: 0x0023E1AC
		public int method_188(ActiveUnit targetUnit_)
		{
			int num;
			int result;
			if (this.m_Warheads.Length == 0)
			{
				num = 0;
			}
			else if (!this.m_Warheads[0].method_18(this, targetUnit_))
			{
				num = 0;
			}
			else if (Information.IsNothing(targetUnit_))
			{
				num = 0;
			}
			else
			{
				if (this.HasNuclearWarhead())
				{
					if (targetUnit_.IsSubmarine)
					{
						if (((Submarine)targetUnit_).IsShallowerThanPeriscopeDepth())
						{
							result = 220;
							return result;
						}
						result = -100;
						return result;
					}
					else if (targetUnit_.IsAircraft || targetUnit_.IsGuidedWeapon_RV_HGV() || targetUnit_.IsSatellite())
					{
						num = (int)Math.Round((double)targetUnit_.GetAltitude_AGL());
						result = num;
						return result;
					}
				}
				if (this.m_Warheads[0].method_18(this, targetUnit_))
				{
					Warhead.WarheadType warheadType = this.m_Warheads[0].warheadType;
					if (warheadType > Warhead.WarheadType.DirectionalContinousRod)
					{
						if (warheadType <= Warhead.WarheadType.Cluster_Penetrator)
						{
							if (warheadType == Warhead.WarheadType.Nuclear)
							{
								num = (int)Math.Round(Math.Pow((double)(this.m_Warheads[0].DP / 1000000f), 0.33333333333333331) * 220.0);
								result = num;
								return result;
							}
							if (warheadType - Warhead.WarheadType.Cluster_AP > 2)
							{
								goto IL_1C9;
							}
						}
						else if (warheadType != Warhead.WarheadType.Cluster_SmartSubs)
						{
							if (warheadType == Warhead.WarheadType.EMP_Omni)
							{
								num = (int)Math.Round(3055.8);
								result = num;
								return result;
							}
							goto IL_1C9;
						}
						result = 800;
						return result;
					}
					if (warheadType != Warhead.WarheadType.HE_BlastFrag)
					{
						if (warheadType != Warhead.WarheadType.Fragmentation)
						{
							switch (warheadType)
							{
							case Warhead.WarheadType.ContinuousRod:
							case Warhead.WarheadType.DirectionalContinousRod:
								break;
							case Warhead.WarheadType.HardTargetPenetrator:
							case Warhead.WarheadType.SuperFrag:
								goto IL_1C9;
							case Warhead.WarheadType.FAE:
								result = 1;
								return result;
							default:
								goto IL_1C9;
							}
						}
						num = (int)Math.Round((double)(Explosion.smethod_2((double)this.m_Warheads[0].DP, Weapon._DetonationMedium.Air) * 1852f) * 0.5);
						result = num;
						return result;
					}
					num = (int)Math.Round((double)(Explosion.smethod_1((double)this.m_Warheads[0].DP, Weapon._DetonationMedium.Air) * 1852f) * 0.5);
					result = num;
					return result;
					IL_1C9:
					num = 0;
				}
				else
				{
					num = 0;
				}
			}
			result = num;
			return result;
		}

		// Token: 0x060055B6 RID: 21942 RVA: 0x002401EC File Offset: 0x0023E3EC
		public override GlobalVariables.TargetVisualSizeClass GetTargetVisualSizeClass()
		{
			float length = this.Length;
			GlobalVariables.TargetVisualSizeClass result;
			if (length > 10f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VLarge;
			}
			else if (length > 5f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Large;
			}
			else if (length > 3.5f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Medium;
			}
			else if (length > 2.5f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Small;
			}
			else if (length > 1.5f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VSmall;
			}
			else
			{
				result = GlobalVariables.TargetVisualSizeClass.Stealthy;
			}
			return result;
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x0024025C File Offset: 0x0023E45C
		public float method_189()
		{
			float result = 0f;
			try
			{
				int terrainElevation = base.GetTerrainElevation(false, false, false);
				bool flag = terrainElevation > 0;
				float num;
				if (flag)
				{
					num = 18.288f;
				}
				else
				{
					num = 9.144f;
				}
				if (this.IsHypersonicGlideVehicle())
				{
					num = 1000f;
				}
				if (flag)
				{
					result = (float)terrainElevation + num;
				}
				else
				{
					result = num;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100891", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060055B8 RID: 21944 RVA: 0x00240318 File Offset: 0x0023E518
		public static void smethod_6(Weapon weapon_, Scenario scenario_)
		{
			if (weapon_.IsOfAirLaunchedGuidedWeapon() && weapon_.GetWeaponType() == Weapon._WeaponType.GuidedWeapon && !scenario_.FeatureCompatibility.GuidedWeaponsPitchAttitude)
			{
				int num;
				if (scenario_.Cache_FuelForPitchEnabledWeapons.ContainsKey(weapon_.DBID))
				{
					num = scenario_.Cache_FuelForPitchEnabledWeapons[weapon_.DBID];
				}
				else
				{
					num = Class232.GetFuelForPitchEnabledWeapons(weapon_.DBID, scenario_);
					scenario_.Cache_FuelForPitchEnabledWeapons.TryAdd(weapon_.DBID, num);
				}
				if ((float)num > weapon_.GetFuelRecs()[0].CurrentQuantity)
				{
					weapon_.GetFuelRecs()[0].CurrentQuantity = (float)num;
				}
			}
		}

		// Token: 0x060055B9 RID: 21945 RVA: 0x002403BC File Offset: 0x0023E5BC
		public static Weapon GetWeapon(ref Scenario theScen, int WeaponDBID, string theGUID = null)
		{
			Weapon result = null;
			try
			{
				if (WeaponDBID == 0)
				{
					result = null;
				}
				else
				{
					Weapon._WeaponType weaponTyp = DBFunctions.GetWeaponTyp(WeaponDBID, theScen);
					Weapon weapon;
					if (weaponTyp != Weapon._WeaponType.GuidedProjectile)
					{
						if (weaponTyp != Weapon._WeaponType.Torpedo)
						{
							if (weaponTyp == Weapon._WeaponType.HGV)
							{
								weapon = new HGV(ref theScen, WeaponDBID, null);
							}
							else
							{
								weapon = new Weapon(ref theScen, WeaponDBID, null);
							}
						}
						else
						{
							weapon = new Torpedo(ref theScen, WeaponDBID, null);
						}
					}
					else
					{
						weapon = new GuidedProjectile(ref theScen, WeaponDBID, null);
					}
					weapon.m_Scenario = theScen;
					weapon.IsWeapon = true;
					DBFunctions.LoadWeaponData(theScen.GetSQLiteConnection(), weapon, WeaponDBID, theScen, true);
					if (weapon.weaponType == Weapon._WeaponType.RV)
					{
						weapon.RangeASUWMin = 1f;
					}
					if (weapon.weaponType == Weapon._WeaponType.Sonobuoy && weapon.GetNoneMCMSensors().Length > 0 && weapon.GetNoneMCMSensors()[0].IsActiveModeOnly())
					{
						weapon.GetNoneMCMSensors()[0].TurnOn();
					}
					if (weapon.weaponCode.BallisticMissile && weapon.HasNuclearWarhead())
					{
						weapon.list_3.Add(Weapon._ASMode.HighAltitudeDetonation);
					}
					result = weapon;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ex2.Data.Add("Error at 100902", "");
				GameGeneral.LogException(ref ex2);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x00240534 File Offset: 0x0023E734
		private Weapon(ref Scenario theScen, int WeaponDBID, string theGUID = null) : base(ref theScen, null)
		{
			this.m_Warheads = new Warhead[0];
			this.weaponDirectorSet = new HashSet<int>();
			this.weaponCode = default(Weapon.WeaponCode);
			this.SetWeaponRecCollection(new ObservableCollection<WeaponRec>());
			this.list_3 = new List<Weapon._ASMode>();
			this.bool_20 = false;
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x0024058C File Offset: 0x0023E78C
		public bool IsLaserWeapon()
		{
			bool flag = false;
			bool result;
			if (this.m_Warheads.Length > 0)
			{
				switch (this.m_Warheads[0].warheadType)
				{
				case Warhead.WarheadType.Laser_COIL:
				case Warhead.WarheadType.Laser_CarbonDioxide:
				case Warhead.WarheadType.Laser_DeuteriumFluoride:
				case Warhead.WarheadType.Laser_SolidStateFiber:
					result = true;
					break;
				default:
					result = false;
					break;
				}
			}
			else
			{
				result = flag;
			}
			return result;
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x00027618 File Offset: 0x00025818
		public new bool IsDecoy()
		{
			return this.weaponType == Weapon._WeaponType.Decoy_Expendable || this.weaponType == Weapon._WeaponType.Decoy_Towed || this.weaponType == Weapon._WeaponType.Decoy_Vehicle;
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x00027644 File Offset: 0x00025844
		public bool IsTrainingRound()
		{
			return this.weaponType == Weapon._WeaponType.TrainingRound;
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x002405E4 File Offset: 0x0023E7E4
		public bool IsSonarDetectable()
		{
			bool flag;
			bool result;
			if (!this.IsDecoy())
			{
				flag = false;
			}
			else
			{
				foreach (XSection current in base.GetXSections())
				{
					if (current.SignatureType == XSection._SignatureType.ActiveSonar_VLF_HF)
					{
						goto IL_46;
					}
					if (current.SignatureType == XSection._SignatureType.PassiveSonar_VLF)
					{
						goto IL_46;
					}
					bool arg_76_0 = true;
					IL_76:
					if (arg_76_0)
					{
						continue;
					}
					result = true;
					return result;
					IL_46:
					arg_76_0 = (current.GetFrontXSection(this) <= -10000f && current.GetSideXSection(this) <= -10000f && current.GetRearXSection(this) <= -10000f);
					goto IL_76;
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x0024069C File Offset: 0x0023E89C
		public bool IsRadarDetectable()
		{
			if (!this.bRadarDetectable.HasValue)
			{
				this.bRadarDetectable = new bool?(false);
				if (!this.IsDecoy())
				{
					this.bRadarDetectable = new bool?(false);
				}
				else
				{
					foreach (XSection current in base.GetXSections())
					{
						if (current.SignatureType == XSection._SignatureType.Radar_A_D_Band)
						{
							goto IL_6A;
						}
						if (current.SignatureType == XSection._SignatureType.Radar_E_M_Band)
						{
							goto IL_6A;
						}
						bool arg_9A_0 = true;
						IL_9A:
						if (arg_9A_0)
						{
							continue;
						}
						this.bRadarDetectable = new bool?(true);
						break;
						IL_6A:
						arg_9A_0 = (current.GetFrontXSection(this) <= -10000f && current.GetSideXSection(this) <= -10000f && current.GetRearXSection(this) <= -10000f);
						goto IL_9A;
					}
				}
			}
			return this.bRadarDetectable.Value;
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x00240788 File Offset: 0x0023E988
		public bool IsInfraredSensorDetectable()
		{
			bool flag;
			bool result;
			if (!this.IsDecoy())
			{
				flag = false;
			}
			else
			{
				foreach (XSection current in base.GetXSections())
				{
					XSection._SignatureType signatureType = current.SignatureType;
					if (signatureType - XSection._SignatureType.InfraredDetectionRange <= 1 && (current.GetFrontXSection(this) > -10000f || current.GetSideXSection(this) > -10000f || current.GetRearXSection(this) > -10000f))
					{
						result = true;
						return result;
					}
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x060055C1 RID: 21953 RVA: 0x00240838 File Offset: 0x0023EA38
		public bool IsVisualSensorDetectable()
		{
			bool flag;
			bool result;
			if (!this.IsDecoy())
			{
				flag = false;
			}
			else
			{
				foreach (XSection current in base.GetXSections())
				{
					XSection._SignatureType signatureType = current.SignatureType;
					if (signatureType - XSection._SignatureType.VisualDetectionRange <= 1 && (current.GetFrontXSection(this) > -10000f || current.GetSideXSection(this) > -10000f || current.GetRearXSection(this) > -10000f))
					{
						result = true;
						return result;
					}
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x060055C2 RID: 21954 RVA: 0x00027653 File Offset: 0x00025853
		public static bool IsNotLaunchableFireWeapon(int DBID_, ref Scenario scenario_)
		{
			return Weapon.IsTank(DBID_, ref scenario_) || Weapon.IsSonobuoy(DBID_, ref scenario_) || Weapon.IsGun(DBID_, ref scenario_) || Weapon.IsCargoOrTroops(DBID_, ref scenario_);
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x002408E8 File Offset: 0x0023EAE8
		public static bool IsTank(int DBID, ref Scenario scenario_)
		{
			SQLiteConnection sQLiteConnection = scenario_.GetSQLiteConnection();
			Weapon._WeaponType weaponType = DBFunctions.GetWeaponType(DBID, ref sQLiteConnection);
			return weaponType == Weapon._WeaponType.DropTank || weaponType == Weapon._WeaponType.FerryTank;
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x0024091C File Offset: 0x0023EB1C
		public static bool IsCargoOrTroops(int DBID, ref Scenario scenario_1)
		{
			SQLiteConnection sQLiteConnection = scenario_1.GetSQLiteConnection();
			Weapon._WeaponType weaponType = DBFunctions.GetWeaponType(DBID, ref sQLiteConnection);
			return weaponType == Weapon._WeaponType.Cargo || weaponType == Weapon._WeaponType.Paratroops || weaponType == Weapon._WeaponType.Troops;
		}

		// Token: 0x060055C5 RID: 21957 RVA: 0x00240958 File Offset: 0x0023EB58
		public static bool IsSonobuoy(int DBID, ref Scenario scenario_1)
		{
			SQLiteConnection sQLiteConnection = scenario_1.GetSQLiteConnection();
			return DBFunctions.GetWeaponType(DBID, ref sQLiteConnection) == Weapon._WeaponType.Sonobuoy;
		}

		// Token: 0x060055C6 RID: 21958 RVA: 0x0024097C File Offset: 0x0023EB7C
		public static bool IsGun(int DBID, ref Scenario scenario_1)
		{
			SQLiteConnection sQLiteConnection = scenario_1.GetSQLiteConnection();
			return DBFunctions.GetWeaponType(DBID, ref sQLiteConnection) == Weapon._WeaponType.Gun;
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x0002767A File Offset: 0x0002587A
		public bool IsTank()
		{
			return this.weaponType == Weapon._WeaponType.DropTank || this.weaponType == Weapon._WeaponType.FerryTank;
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x00027699 File Offset: 0x00025899
		public bool IsSensorPod()
		{
			return this.weaponType == Weapon._WeaponType.SensorPod;
		}

		// 攻击目标雷达的反辐射导弹数量
		private int GetNumOfARMsInSideForTargetRadar(Side theSide_, Contact theTarget_, int TargetRadarID_)
		{
			Weapon.ARMTarget aRMTarget = new Weapon.ARMTarget();
			aRMTarget.theTarget = theTarget_;
			aRMTarget.TargetRadarID = TargetRadarID_;
			int result = 0;
			try
			{
				result = theSide_.ActiveUnitArray.ToList<ActiveUnit>().Select(Weapon.ActiveUnitFunc1).Where(Weapon.IsWeaponFilter).Select(Weapon.ActiveUnitFunc3).Where(new Func<ActiveUnit, bool>(aRMTarget.IsTargetFor)).Count<ActiveUnit>();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100903", "");
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

		// 反辐射导弹
		public bool HasARM_SpecifiedEmission(ObservableDictionary<int, EmissionContainer> observableDictionary_, Side side_, Contact contact_, bool bool_21, ref Random random_1)
		{
			Weapon.ARMTargetMan aRMTargetMan = new Weapon.ARMTargetMan(null);
			aRMTargetMan.theWeapon = this;
			aRMTargetMan.EmissionContainerDictionary = observableDictionary_;
			aRMTargetMan.theSide = side_;
			aRMTargetMan.theTarget = contact_;
			bool flag = false;
			bool result;
			try
			{
				Weapon.Class220 @class = new Weapon.Class220(null);
				@class._ARMTargetMan = aRMTargetMan;
				if (bool_21)
				{
					@class.float_0 = 36000f;
				}
				else
				{
					@class.float_0 = 20f;
				}
				IEnumerable<int> enumerable = @class._ARMTargetMan.EmissionContainerDictionary.Dictionary.Where(new Func<KeyValuePair<int, EmissionContainer>, bool>(@class.method_0)).Select(Weapon.KeyValuePairFunc4);
				if (enumerable.Count<int>() > 0)
				{
					foreach (int current in enumerable)
					{
						if (this.GetNumOfARMsInSideForTargetRadar(@class._ARMTargetMan.theSide, @class._ARMTargetMan.theTarget, current) == 0)
						{
							this.ARM_SpecifiedEmission = new KeyValuePair<int, EmissionContainer>(current, @class._ARMTargetMan.EmissionContainerDictionary[current]);
							flag = true;
							result = true;
							return result;
						}
					}
				}
				IEnumerable<int> enumerable2 = @class._ARMTargetMan.EmissionContainerDictionary.Dictionary.Where(new Func<KeyValuePair<int, EmissionContainer>, bool>(@class.method_1)).Select(Weapon.KeyValuePairFunc5);
				if (enumerable2.Count<int>() > 0)
				{
					foreach (int current2 in enumerable2)
					{
						if (this.GetNumOfARMsInSideForTargetRadar(@class._ARMTargetMan.theSide, @class._ARMTargetMan.theTarget, current2) == 0)
						{
							this.ARM_SpecifiedEmission = new KeyValuePair<int, EmissionContainer>(current2, @class._ARMTargetMan.EmissionContainerDictionary[current2]);
							flag = true;
							result = true;
							return result;
						}
					}
				}
				IEnumerable<int> enumerable3 = @class._ARMTargetMan.EmissionContainerDictionary.Dictionary.Where(new Func<KeyValuePair<int, EmissionContainer>, bool>(@class.method_2)).Select(Weapon.KeyValuePairFunc6);
				if (enumerable3.Count<int>() > 0)
				{
					foreach (int current3 in enumerable3)
					{
						if (this.GetNumOfARMsInSideForTargetRadar(@class._ARMTargetMan.theSide, @class._ARMTargetMan.theTarget, current3) == 0)
						{
							this.ARM_SpecifiedEmission = new KeyValuePair<int, EmissionContainer>(current3, @class._ARMTargetMan.EmissionContainerDictionary[current3]);
							flag = true;
							result = true;
							return result;
						}
					}
				}
				if (this.weaponCode.HomeOnJam)
				{
					IEnumerable<int> enumerable4 = @class._ARMTargetMan.EmissionContainerDictionary.Dictionary.Where(new Func<KeyValuePair<int, EmissionContainer>, bool>(@class.method_3)).Select(Weapon.KeyValuePairFunc7);
					if (enumerable4.Count<int>() > 0)
					{
						foreach (int current4 in enumerable4)
						{
							if (this.GetNumOfARMsInSideForTargetRadar(@class._ARMTargetMan.theSide, @class._ARMTargetMan.theTarget, current4) == 0)
							{
								this.ARM_SpecifiedEmission = new KeyValuePair<int, EmissionContainer>(current4, @class._ARMTargetMan.EmissionContainerDictionary[current4]);
								flag = true;
								result = true;
								return result;
							}
						}
					}
				}
				IEnumerable<int> source;
				if (this.weaponCode.HomeOnJam)
				{
					source = @class._ARMTargetMan.EmissionContainerDictionary.Dictionary.Where(new Func<KeyValuePair<int, EmissionContainer>, bool>(@class.method_4)).OrderBy(new Func<KeyValuePair<int, EmissionContainer>, int>(@class._ARMTargetMan.GetNumOfARMsForTargetRadar)).Select(Weapon.KeyValuePairFunc8);
				}
				else
				{
					source = @class._ARMTargetMan.EmissionContainerDictionary.Dictionary.Where(new Func<KeyValuePair<int, EmissionContainer>, bool>(@class.method_5)).OrderBy(new Func<KeyValuePair<int, EmissionContainer>, int>(@class._ARMTargetMan.GetNumOfARMsForTargetRadar1)).Select(Weapon.KeyValuePairFunc9);
				}
				if (source.Count<int>() > 0)
				{
					this.ARM_SpecifiedEmission = new KeyValuePair<int, EmissionContainer>(source.ElementAtOrDefault(0), @class._ARMTargetMan.EmissionContainerDictionary[source.ElementAtOrDefault(0)]);
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100904", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x00240F30 File Offset: 0x0023F130
		public override void ScheduleLifeCycleActivities(float elapsedTime, ref Random random_)
        {
            bool? nullable;
            ActiveUnit_Weaponry weaponry;
            if (Information.IsNothing(this.GetWeaponry()))
            {
                return;
            }
            try
            {
                if (this.GetWeaponType() == _WeaponType.Sonobuoy)
                {
                    return;
                }
                switch (this.GetGuidanceMethod())
                {
                    case _GuidanceMethod.SemiActive:
                        try
                        {
                            this.SemiActiveGuidance(elapsedTime);
                        }
                        catch (Exception exception)
                        {
                            ProjectData.SetProjectError(exception);
                            Exception exception2 = exception;
                            exception2.Data.Add("Error at 100908", "");
                            GameGeneral.LogException(ref exception2);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                        goto Label_0C17;

                    case _GuidanceMethod.const_1:
                        try
                        {
                            this.method_232(elapsedTime);
                        }
                        catch (Exception exception15)
                        {
                            ProjectData.SetProjectError(exception15);
                            Exception exception16 = exception15;
                            exception16.Data.Add("Error at 100922", "");
                            GameGeneral.LogException(ref exception16);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                        goto Label_0C17;

                    case _GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance:
                        try
                        {
                            this.CommandGuidance(elapsedTime);
                            this.method_232(elapsedTime);
                        }
                        catch (Exception exception17)
                        {
                            ProjectData.SetProjectError(exception17);
                            Exception exception18 = exception17;
                            exception18.Data.Add("Error at 100917", "");
                            GameGeneral.LogException(ref exception18);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                        goto Label_0C17;

                    case (_GuidanceMethod.const_1 | _GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance):
                        goto Label_0C17;

                    case _GuidanceMethod.PassiveTerminalGuidance:
                        try
                        {
                            if (this.method_223() || this.method_225(60f, true, false, true, elapsedTime))
                            {
                                return;
                            }
                        }
                        catch (Exception exception19)
                        {
                            ProjectData.SetProjectError(exception19);
                            Exception exception20 = exception19;
                            exception20.Data.Add("Error at 100914", "");
                            GameGeneral.LogException(ref exception20);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                        goto Label_0C17;

                    case _GuidanceMethod.INSMidcoursePlusPassiveTerminalGuidance:
                        try
                        {
                            if (this.method_223() || this.method_225(60f, true, false, false, elapsedTime))
                            {
                                return;
                            }
                            this.method_208();
                        }
                        catch (Exception exception21)
                        {
                            ProjectData.SetProjectError(exception21);
                            Exception exception22 = exception21;
                            exception22.Data.Add("Error at 100921", "");
                            GameGeneral.LogException(ref exception22);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                        goto Label_0C17;

                    case _GuidanceMethod.const_5:
                        try
                        {
                            this.CommandGuidance(elapsedTime);
                            this.method_208();
                        }
                        catch (Exception exception23)
                        {
                            ProjectData.SetProjectError(exception23);
                            Exception exception24 = exception23;
                            exception24.Data.Add("Error at 100916", "");
                            GameGeneral.LogException(ref exception24);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                        goto Label_0C17;

                    case _GuidanceMethod.ActiveTerminalGuidance:
                        try
                        {
                            if (this.method_223() || this.method_225(60f, true, false, true, elapsedTime))
                            {
                                return;
                            }
                            if (!this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
                            {
                                foreach (Sensor sensor3 in this.GetNoneMCMSensors())
                                {
                                    if (!(!sensor3.IsActiveCapable() || sensor3.IsEmmitting()))
                                    {
                                        sensor3.TurnOn();
                                    }
                                }
                            }
                            else
                            {
                                this.method_208();
                            }
                        }
                        catch (Exception exception25)
                        {
                            ProjectData.SetProjectError(exception25);
                            Exception exception26 = exception25;
                            exception26.Data.Add("Error at 100913", "");
                            GameGeneral.LogException(ref exception26);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                        goto Label_0C17;

                    case _GuidanceMethod.const_7:
                        try
                        {
                            if ((this.GetNoneMCMSensors().Length > 0) && this.GetNoneMCMSensors()[0].IsEmmitting())
                            {
                                if ((this.method_220(elapsedTime) || this.method_221(elapsedTime)) || this.method_225(60f, true, true, true, elapsedTime))
                                {
                                    return;
                                }
                            }
                            else
                            {
                                this.CommandGuidance(elapsedTime);
                                this.method_208();
                            }
                        }
                        catch (Exception exception3)
                        {
                            ProjectData.SetProjectError(exception3);
                            Exception exception4 = exception3;
                            exception4.Data.Add("Error at 100915", "");
                            GameGeneral.LogException(ref exception4);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                        goto Label_0C17;

                    case _GuidanceMethod.InertialMidCoursePlusActiveTerminalGuidance:
                        try
                        {
                            if (this.method_223() || this.method_225(60f, true, false, false, elapsedTime))
                            {
                                return;
                            }
                            if (!((this.GetNoneMCMSensors().Length <= 0) || this.GetNoneMCMSensors()[0].IsEmmitting()))
                            {
                                this.method_208();
                            }
                        }
                        catch (Exception exception5)
                        {
                            ProjectData.SetProjectError(exception5);
                            Exception exception6 = exception5;
                            exception6.Data.Add("Error at 100920", "");
                            GameGeneral.LogException(ref exception6);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                        goto Label_0C17;

                    case _GuidanceMethod.CommandGuided:
                        try
                        {
                            this.CommandGuidance(elapsedTime);
                        }
                        catch (Exception exception7)
                        {
                            ProjectData.SetProjectError(exception7);
                            Exception exception8 = exception7;
                            exception8.Data.Add("Error at 100919", "");
                            GameGeneral.LogException(ref exception8);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                        goto Label_0C17;

                    case _GuidanceMethod.TrackViaMissile:
                        try
                        {
                            this.TrackViaMissileGuidance(elapsedTime);
                        }
                        catch (Exception exception9)
                        {
                            ProjectData.SetProjectError(exception9);
                            Exception exception10 = exception9;
                            exception10.Data.Add("Error at 100918", "");
                            GameGeneral.LogException(ref exception10);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                        goto Label_0C17;

                    case _GuidanceMethod.BeamRiding:
                        try
                        {
                            if (this.method_222(elapsedTime))
                            {
                                return;
                            }
                            Sensor director = this.GetDirector();
                            if (Information.IsNothing(director))
                            {
                                this.GetWeaponAI().SetPrimaryTarget(null);
                                nullable = null;
                                nullable = null;
                                base.LogMessage("武器: " + base.Name + "收不到制导信号", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(nullable), this.GetLatitude(nullable)));
                                return;
                            }
                            if (!director.GetTargetsTrackedForFireControl().Contains(this.GetWeaponAI().GetPrimaryTarget()))
                            {
                                this.GetWeaponAI().SetPrimaryTarget(null);
                                nullable = null;
                                nullable = null;
                                base.LogMessage("武器: " + base.Name + "收不到制导信号", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(nullable), this.GetLatitude(nullable)));
                                return;
                            }
                            if (!director.IsEmmitting())
                            {
                                this.GetWeaponAI().SetPrimaryTarget(null);
                                nullable = null;
                                nullable = null;
                                base.LogMessage("武器:" + base.Name + "收不到制导信号.", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(nullable), this.GetLatitude(nullable)));
                                return;
                            }
                            if (!(!this.IsPrimaryTargetDisappear() || Information.IsNothing(director)))
                            {
                                this.method_235(elapsedTime);
                                return;
                            }
                            if (this.IsPrimaryTargetDisappear())
                            {
                                this.SetBlindTime(this.GetBlindTime() + elapsedTime);
                                return;
                            }
                            this.SetBlindTime(0f);
                            this.GetWeaponAI().GetPrimaryTarget().Age = 0f;
                        }
                        catch (Exception exception11)
                        {
                            ProjectData.SetProjectError(exception11);
                            Exception exception12 = exception11;
                            exception12.Data.Add("Error at 100912", "");
                            GameGeneral.LogException(ref exception12);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                        goto Label_0C17;

                    case _GuidanceMethod.InertiallyGuided:
                        this.method_224();
                        goto Label_0C17;

                    case _GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance:
                        try
                        {
                            if ((this.GetNoneMCMSensors().Length > 0) && this.GetNoneMCMSensors()[0].IsEmmitting())
                            {
                                if (this.method_223() || this.method_225(60f, true, true, true, elapsedTime))
                                {
                                    return;
                                }
                                goto Label_0C17;
                            }
                            if (base.GetSlantRange(this.GetWeaponAI().GetPrimaryTarget(), 0f) <= (this.GetNoneMCMSensors()[0].MaxRange * 0.8))
                            {
                                this.method_212(false, true, true);
                                goto Label_0C17;
                            }
                            if (this.GetBlindTime() > 5f)
                            {
                                this.method_212(false, true, true);
                                goto Label_0C17;
                            }
                            if (this.method_222(elapsedTime))
                            {
                                return;
                            }
                            Sensor expression = this.GetDirector();
                            if (Information.IsNothing(expression))
                            {
                                if (this.IsReceivingBuddyIllumination())
                                {
                                    goto Label_0894;
                                }
                                this.SetBlindTime(this.GetBlindTime() + elapsedTime);
                                goto Label_0C17;
                            }
                            if (!expression.GetTargetsTrackedForFireControl().Contains(this.GetWeaponAI().GetPrimaryTarget()))
                            {
                                if (this.IsReceivingBuddyIllumination())
                                {
                                    goto Label_0894;
                                }
                                this.SetBlindTime(this.GetBlindTime() + elapsedTime);
                                goto Label_0C17;
                            }
                            if (!(expression.IsEmmitting() || this.IsReceivingBuddyIllumination()))
                            {
                                this.SetBlindTime(this.GetBlindTime() + elapsedTime);
                                goto Label_0C17;
                            }
                        Label_0894:
                            if (this.GetBlindTime() > 0f)
                            {
                                this.SetBlindTime(0f);
                            }
                            if (this.method_226(90f) || this.method_225(60f, true, true, true, elapsedTime))
                            {
                                return;
                            }
                        }
                        catch (Exception exception13)
                        {
                            ProjectData.SetProjectError(exception13);
                            Exception exception14 = exception13;
                            exception14.Data.Add("Error at 100909", "");
                            GameGeneral.LogException(ref exception14);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                        goto Label_0C17;

                    case _GuidanceMethod.TimeSharedSemiActiveMidCoursePlusActiveTerminalGuidance:
                        break;

                    default:
                        goto Label_0C17;
                }
                try
                {
                    if ((this.GetNoneMCMSensors().Length > 0) && this.GetNoneMCMSensors()[0].IsEmmitting())
                    {
                        if (this.method_223() || this.method_225(60f, true, true, true, elapsedTime))
                        {
                            return;
                        }
                        goto Label_0C17;
                    }
                    if (base.GetSlantRange(this.GetWeaponAI().GetPrimaryTarget(), 0f) <= (this.GetNoneMCMSensors()[0].MaxRange * 0.8))
                    {
                        this.method_212(false, true, true);
                        goto Label_0C17;
                    }
                    if (this.GetBlindTime() > 5f)
                    {
                        this.method_212(false, true, true);
                        goto Label_0C17;
                    }
                    if (this.method_222(elapsedTime))
                    {
                        return;
                    }
                    bool flag = false;
                    if (!Information.IsNothing(this.GetDataLinkParent()))
                    {
                        try
                        {
                            List<ActiveUnit> affectingJammers = null;
                            Unit._LOS_Exists_Visual? nullable2 = null;
                            bool? nullable3 = null;
                            bool? nullable4 = null;
                            bool? nullable5 = null;
                            foreach (Sensor sensor4 in this.GetDataLinkParent().GetNoneMCMSensors())
                            {
                                if (sensor4.IsEmmitting())
                                {
                                    if ((sensor4.sensorType == Sensor.SensorType.Radar) && Information.IsNothing(affectingJammers))
                                    {
                                        affectingJammers = this.GetDataLinkParent().GetSensory().GetAffectingJammers(false);
                                    }
                                    Lazy<ObservableDictionary<int, EmissionContainer>> lazy = new Lazy<ObservableDictionary<int, EmissionContainer>>();
                                    Sensor sensor5 = sensor4;
                                    ActiveUnit dataLinkParent = this.GetDataLinkParent();
                                    ActiveUnit actualUnit = this.GetWeaponAI().GetPrimaryTarget().ActualUnit;
                                    List<GeoPoint> list2 = null;
                                    if (sensor5.SensorDetectionAttempt(Sensor.DetectionAttemptType.SpecificTargetTracking, dataLinkParent, actualUnit, ref list2, this.GetDataLinkParent().GetSlantRange(this.GetWeaponAI().GetPrimaryTarget(), 0f), ref lazy, affectingJammers, ref nullable3, ref nullable4, ref nullable2, ref nullable5))
                                    {
                                        goto Label_0AEF;
                                    }
                                }
                            }
                            goto Label_0B34;
                        Label_0AEF:
                            flag = true;
                        }
                        catch (Exception exception27)
                        {
                            ProjectData.SetProjectError(exception27);
                            Exception exception28 = exception27;
                            exception28.Data.Add("Error at 100910", "");
                            GameGeneral.LogException(ref exception28);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                    }
                Label_0B34:
                    if (!flag)
                    {
                        this.SetBlindTime(this.GetBlindTime() + elapsedTime);
                    }
                    else
                    {
                        if (this.GetBlindTime() > 0f)
                        {
                            this.SetBlindTime(0f);
                        }
                        if (this.method_226(90f) || this.method_225(60f, true, true, true, elapsedTime))
                        {
                            return;
                        }
                    }
                }
                catch (Exception exception29)
                {
                    ProjectData.SetProjectError(exception29);
                    Exception exception30 = exception29;
                    exception30.Data.Add("Error at 100911", "");
                    GameGeneral.LogException(ref exception30);
                    if (Debugger.IsAttached)
                    {
                        Debugger.Break();
                    }
                    ProjectData.ClearProjectError();
                }
            }
            catch (Exception exception31)
            {
                ProjectData.SetProjectError(exception31);
                Exception exception32 = exception31;
                exception32.Data.Add("Error at 100907", "");
                GameGeneral.LogException(ref exception32);
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }
                ProjectData.ClearProjectError();
            }
        Label_0C17:
            if (!((this.GetDRT() <= 0f) || Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget())))
            {
                this.SetDRT(0f);
            }
            if (!(Information.IsNothing(this.ARM_SpecifiedEmission) || Information.IsNothing(this.ARM_SpecifiedEmission.Value)))
            {
                this.ARM_SpecifiedEmission.Value.elapsedTime += elapsedTime;
            }
            try
            {
                if (!this.weaponCode.BallisticMissile)
                {
                    goto Label_11ED;
                }
                if (!this.method_204())
                {
                    goto Label_130F;
                }
                List<Warhead> list3 = new List<Warhead>();
                if (!this.IsMREV_GuidedBallisticMissile())
                {
                    goto Label_0EE8;
                }
                int num3 = this.m_Warheads.Length - 1;
                int index = 0;
            Label_0CD2:
                if (index > num3)
                {
                    goto Label_118F;
                }
                Warhead item = this.m_Warheads[index];
                Weapon weaponFromDP = item.GetWeaponFromDP(base.m_Scenario);
                Contact primaryTarget = null;
                if (Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
                {
                    if (this.GetWeaponNavigator().HasPlottedCourse())
                    {
                        primaryTarget = new Aimpoint(this.GetWeaponNavigator().GetPlottedCourse().Last<Waypoint>().GetLatitude(), this.GetWeaponNavigator().GetPlottedCourse().Last<Waypoint>().GetLongitude());
                    }
                }
                else if (weaponFromDP.IsRVorHGV())
                {
                    nullable = null;
                    nullable = null;
                    primaryTarget = new Aimpoint(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(nullable), this.GetWeaponAI().GetPrimaryTarget().GetLongitude(nullable));
                }
                else
                {
                    primaryTarget = this.GetWeaponAI().GetPrimaryTarget();
                }
                weaponry = this.GetWeaponry();
                Weapon theWeapon = weaponFromDP;
                Contact theTarget = primaryTarget;
                Mount theMount = null;
                Sensor suitableDirectorSensor = null;
                short? nullable6 = null;
                if (string.CompareOrdinal(weaponry.CheckWeaponAttackCondition(theWeapon, theTarget, ref nullable6, false, false, theMount, ref suitableDirectorSensor), "OK") == 0)
                {
                    if (index != 0)
                    {
                        try
                        {
                            if (this.GetWeaponAI().GetTargets().Length > 0)
                            {
                                if ((index - 1) < this.GetWeaponAI().GetTargets().Length)
                                {
                                    this.method_201(weaponFromDP, this.GetWeaponAI().GetTargets()[index - 1], elapsedTime, false);
                                }
                                else
                                {
                                    this.method_201(weaponFromDP, this.GetWeaponAI().GetPrimaryTarget(), elapsedTime, false);
                                }
                            }
                            else
                            {
                                this.method_201(weaponFromDP, primaryTarget, elapsedTime, false);
                            }
                        }
                        catch (Exception exception33)
                        {
                            ProjectData.SetProjectError(exception33);
                            Exception exception34 = exception33;
                            this.method_201(weaponFromDP, this.GetWeaponAI().GetPrimaryTarget(), elapsedTime, false);
                            exception34.Data.Add("Error at 200047", exception34.Message);
                            GameGeneral.LogException(ref exception34);
                            if (Debugger.IsAttached)
                            {
                                Debugger.Break();
                            }
                            ProjectData.ClearProjectError();
                        }
                    }
                    else
                    {
                        this.method_201(weaponFromDP, primaryTarget, elapsedTime, true);
                    }
                    goto Label_0EDD;
                }
            Label_0ED2:
                index++;
                goto Label_0CD2;
            Label_0EDD:
                list3.Add(item);
                goto Label_0ED2;
            Label_0EE8:
                if (this.IsMREV_BallisticMissile())
                {
                    int num5 = this.m_Warheads.Length - 1;
                    for (int i = 0; i <= num5; i++)
                    {
                        Warhead warhead2 = this.m_Warheads[i];
                        Weapon weapon3 = warhead2.GetWeaponFromDP(base.m_Scenario);
                        Contact contact3 = null;
                        if (Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
                        {
                            if (this.GetWeaponNavigator().HasPlottedCourse())
                            {
                                contact3 = new Aimpoint(this.GetWeaponNavigator().GetPlottedCourse().Last<Waypoint>().GetLatitude(), this.GetWeaponNavigator().GetPlottedCourse().Last<Waypoint>().GetLongitude());
                            }
                        }
                        else if (weapon3.IsRVorHGV())
                        {
                            nullable = null;
                            nullable = null;
                            contact3 = new Aimpoint(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(nullable), this.GetWeaponAI().GetPrimaryTarget().GetLongitude(nullable));
                        }
                        else
                        {
                            contact3 = this.GetWeaponAI().GetPrimaryTarget();
                        }
                        ActiveUnit_Weaponry weaponry2 = this.GetWeaponry();
                        Weapon weapon4 = weapon3;
                        Contact contact4 = contact3;
                        Mount mount2 = null;
                        suitableDirectorSensor = null;
                        nullable6 = null;
                        if (string.CompareOrdinal(weaponry2.CheckWeaponAttackCondition(weapon4, contact4, ref nullable6, false, false, mount2, ref suitableDirectorSensor), "OK") == 0)
                        {
                            this.method_201(weapon3, contact3, elapsedTime, i == 0);
                            list3.Add(warhead2);
                        }
                    }
                }
                else
                {
                    Warhead warhead3 = this.m_Warheads[0];
                    Weapon weapon5 = warhead3.GetWeaponFromDP(base.m_Scenario);
                    if (!Information.IsNothing(weapon5))
                    {
                        Contact contact5 = null;
                        if (Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
                        {
                            if (this.GetWeaponNavigator().HasPlottedCourse())
                            {
                                contact5 = new Aimpoint(this.GetWeaponNavigator().GetPlottedCourse().Last<Waypoint>().GetLatitude(), this.GetWeaponNavigator().GetPlottedCourse().Last<Waypoint>().GetLongitude());
                            }
                        }
                        else if (weapon5.IsRVorHGV() && (weapon5.GetAllNoneMCMSensors().Length == 0))
                        {
                            nullable = null;
                            nullable = null;
                            contact5 = new Aimpoint(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(nullable), this.GetWeaponAI().GetPrimaryTarget().GetLongitude(nullable));
                        }
                        else
                        {
                            contact5 = this.GetWeaponAI().GetPrimaryTarget();
                        }
                        ActiveUnit_Weaponry weaponry3 = this.GetWeaponry();
                        Weapon weapon6 = weapon5;
                        Contact contact6 = contact5;
                        Mount mount3 = null;
                        suitableDirectorSensor = null;
                        nullable6 = null;
                        if (string.CompareOrdinal(weaponry3.CheckWeaponAttackCondition(weapon6, contact6, ref nullable6, false, false, mount3, ref suitableDirectorSensor), "OK") == 0)
                        {
                            this.method_201(weapon5, contact5, elapsedTime, true);
                            list3.Add(warhead3);
                        }
                    }
                }
            Label_118F:
                foreach (Warhead warhead4 in list3)
                {
                    ScenarioArrayUtil.RemoveWarhead(ref this.m_Warheads, warhead4);
                }
                if (this.m_Warheads.Length != 0)
                {
                    goto Label_130F;
                }
                base.m_Scenario.RemoveUnit(this);
                return;
            Label_11ED:
                if (!(((this.method_215() || (this.m_Warheads.Length <= 0)) || (this.m_Warheads[0].warheadType != Warhead.WarheadType.Weapon)) || this.m_Warheads[0].GetWeaponFromDP(base.m_Scenario).HasNuclearWarhead()))
                {
                    Weapon weapon7 = this.m_Warheads[0].GetWeaponFromDP(base.m_Scenario);
                    ActiveUnit_Weaponry weaponry4 = this.GetWeaponry();
                    Weapon weapon8 = weapon7;
                    Contact contact7 = this.GetWeaponAI().GetPrimaryTarget();
                    short? nullable7 = new short?((short)Math.Round((double)this.GetCurrentAltitude_ASL(false)));
                    Mount mount4 = null;
                    suitableDirectorSensor = null;
                    if (string.CompareOrdinal(weaponry4.CheckWeaponAttackCondition(weapon8, contact7, ref nullable7, false, false, mount4, ref suitableDirectorSensor), "OK") == 0)
                    {
                        this.method_201(weapon7, this.GetWeaponAI().GetPrimaryTarget(), elapsedTime, true);
                        base.m_Scenario.RemoveUnit(this);
                        return;
                    }
                }
            }
            catch (Exception exception35)
            {
                ProjectData.SetProjectError(exception35);
                Exception exception36 = exception35;
                exception36.Data.Add("Error at 100923", "");
                GameGeneral.LogException(ref exception36);
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }
                ProjectData.ClearProjectError();
            }
        Label_130F:
            if (this.m_Warheads.Any<Warhead>() && this.m_Warheads[0].IsEMP())
            {
                float num7 = 5f;
                try
                {
                    double? nullable8 = null;
                    double? nullable9 = null;
                    if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
                    {
                        nullable = null;
                        nullable8 = new double?(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(nullable));
                        nullable = null;
                        nullable9 = new double?(this.GetWeaponAI().GetPrimaryTarget().GetLongitude(nullable));
                    }
                    else if (this.GetWeaponNavigator().HasPlottedCourse())
                    {
                        nullable8 = new double?(this.GetWeaponNavigator().GetPlottedCourse()[0].GetLatitude());
                        nullable9 = new double?(this.GetWeaponNavigator().GetPlottedCourse()[0].GetLongitude());
                    }
                    Warhead.WarheadType warheadType = this.m_Warheads[0].warheadType;
                    if (warheadType != Warhead.WarheadType.EMP_Directed)
                    {
                        if (((warheadType == Warhead.WarheadType.EMP_Omni) && nullable8.HasValue) && nullable9.HasValue)
                        {
                            float num8 = base.HorizontalRangeTo(nullable8.Value, nullable9.Value);
                            if (num8 <= (num7 * 0.33))
                            {
                                nullable = null;
                                nullable = null;
                                this.Detonation(this.GetLatitude(nullable), this.GetLongitude(nullable), this.GetCurrentAltitude_ASL(false), ref random_);
                                return;
                            }
                            if (!(((num8 > num7) || Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget())) || Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit)))
                            {
                                float num9 = this.method_188(this.GetWeaponAI().GetPrimaryTarget().ActualUnit) + this.GetWeaponAI().GetPrimaryTarget().GetCurrentAltitude_ASL(false);
                                this.SetDesiredAltitude(num9);
                                this.GetWeaponKinematics().SetDesiredAltitudeOverride(true);
                            }
                        }
                    }
                    else if (nullable8.HasValue && nullable9.HasValue)
                    {
                        if (base.HorizontalRangeTo(nullable8.Value, nullable9.Value) <= 0.25)
                        {
                            if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
                            {
                                if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit))
                                {
                                    this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetDamage().AssessDamage(0.9f);
                                }
                                this.GetWeaponAI().DropTargeting(this.GetWeaponAI().GetPrimaryTarget(), true);
                                this.GetWeaponAI().SetPrimaryTarget(null);
                                this.GetWeaponNavigator().ClearPlottedCourse();
                            }
                            if (this.GetWeaponAI().GetTargets().Length == 0)
                            {
                                base.m_Scenario.RemoveUnit(this);
                            }
                            else
                            {
                                this.GetWeaponAI().SetPrimaryTarget(this.GetWeaponAI().GetTargets().OrderBy<Contact, double>(new Func<Contact, double>(this.GetAngularDistance)).ElementAtOrDefault<Contact>(0));
                            }
                        }
                        return;
                    }
                }
                catch (Exception exception37)
                {
                    ProjectData.SetProjectError(exception37);
                    if (Debugger.IsAttached)
                    {
                        Debugger.Break();
                    }
                    ProjectData.ClearProjectError();
                }
            }
            try
            {
                if ((Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) || !this.bPrimaryTargetAttackable) ? !this.IsTargetAttackable(elapsedTime) : false)
                {
                    goto Label_2069;
                }
                float num10 = 0f;
                if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
                {
                    if ((this.GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.Aimpoint) && !Information.IsNothing(this.GetWeaponAI().GetPrimaryTargetType()))
                    {
                        switch (this.GetWeaponAI().GetPrimaryTargetType())
                        {
                            case Contact_Base.ContactType.Surface:
                                num10 = 0f;
                                goto Label_17C3;

                            case Contact_Base.ContactType.Submarine:
                                num10 = Math.Max(this.GetWeaponAI().GetPrimaryTarget().GetTerrainElevation(false, false, false), -100);
                                goto Label_17C3;

                            case Contact_Base.ContactType.Aimpoint:
                                if (this.GetWeaponAI().GetPrimaryTarget().GetTerrainElevation(false, false, false) < 0f)
                                {
                                    break;
                                }
                                num10 = this.GetWeaponAI().GetPrimaryTarget().GetTerrainElevation(false, false, false);
                                goto Label_17C3;

                            case Contact_Base.ContactType.Facility_Fixed:
                            case Contact_Base.ContactType.Facility_Mobile:
                                num10 = this.GetWeaponAI().GetPrimaryTarget().GetTerrainElevation(false, false, false);
                                goto Label_17C3;

                            default:
                                num10 = this.GetWeaponAI().GetPrimaryTarget().GetTerrainElevation(false, false, false);
                                goto Label_17C3;
                        }
                        if (this.TargetIsSubsurface())
                        {
                            num10 = Math.Max(this.GetWeaponAI().GetPrimaryTarget().GetTerrainElevation(false, false, false), -100);
                        }
                        else
                        {
                            num10 = 0f;
                        }
                    }
                    else
                    {
                        num10 = this.GetWeaponAI().GetPrimaryTarget().GetTerrainElevation(false, false, false);
                    }
                }
                else
                {
                    num10 = base.GetTerrainElevation(false, false, false);
                }
            Label_17C3:
                if (base.IsDecoy())
                {
                    if (this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
                    {
                        this.GetWeaponNavigator().ClearPlottedCourse();
                    }
                    return;
                }
                if (this.method_215() && ((this.GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.Submarine) || (this.GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.ActivationPoint)))
                {
                    if (this.GetWeaponNavigator().HasPlottedCourse())
                    {
                        nullable = null;
                        this.SetLongitude(nullable, this.GetWeaponNavigator().GetPlottedCourse()[0].GetLongitude());
                        this.SetLatitude(null, this.GetWeaponNavigator().GetPlottedCourse()[0].GetLatitude());
                    }
                    else
                    {
                        nullable = null;
                        nullable = null;
                        this.SetLongitude(nullable, this.GetWeaponAI().GetPrimaryTarget().GetLongitude(nullable));
                        nullable = null;
                        this.SetLatitude(nullable, this.GetWeaponAI().GetPrimaryTarget().GetLatitude((bool?)null));
                    }
                    this.method_217();
                    return;
                }
                if (this.HasDepthChargeWarhead())
                {
                    this.method_218();
                    return;
                }
                if ((this.m_Warheads.Length > 0) && this.m_Warheads[0].HasNuclearWarhead(base.m_Scenario))
                {
                    if (!(Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) || Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit)))
                    {
                        this.WeaponEndGame(this.GetWeaponAI().GetPrimaryTarget().ActualUnit, ref this.m_Scenario, false, ref random_);
                        if (!base.m_Scenario.GetUnitRemovals().Contains(this))
                        {
                            nullable = null;
                            this.Detonation(this.GetLatitude(nullable), this.GetLongitude((bool?)null), this.GetCurrentAltitude_ASL(false), ref random_);
                        }
                    }
                    else if (Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
                    {
                        if (this.GetWeaponNavigator().HasPlottedCourse())
                        {
                            this.Detonation(this.GetWeaponNavigator().GetPlottedCourse()[0].GetLatitude(), this.GetWeaponNavigator().GetPlottedCourse()[0].GetLongitude(), num10, ref random_);
                        }
                        else
                        {
                            nullable = null;
                            this.Detonation(this.GetLatitude(nullable), this.GetLongitude((bool?)null), num10, ref random_);
                        }
                    }
                    else if (((this.GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.Aimpoint) && this.GetWeaponNavigator().HasPlottedCourse()) && (this.GetWeaponNavigator().GetPlottedCourse().First<Waypoint>().GetAltitude() > 9000f))
                    {
                        nullable = null;
                        this.Detonation(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(nullable), this.GetWeaponAI().GetPrimaryTarget().GetLongitude((bool?)null), this.GetWeaponNavigator().GetPlottedCourse().First<Waypoint>().GetAltitude(), ref random_);
                    }
                    else
                    {
                        nullable = null;
                        this.Detonation(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(nullable), this.GetWeaponAI().GetPrimaryTarget().GetLongitude((bool?)null), this.method_188(this.GetWeaponAI().GetPrimaryTarget().ActualUnit) + num10, ref random_);
                    }
                    return;
                }
                if (this.bPrimaryTargetAttackable)
                {
                    if (this.GetWeaponAI().GetPrimaryTarget().IsDestroyed(base.m_Scenario))
                    {
                        if (this.GetWeaponAI().GetPrimaryTarget().IsFacilityType())
                        {
                            nullable = null;
                            this.Detonation(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(nullable), this.GetWeaponAI().GetPrimaryTarget().GetLongitude((bool?)null), this.method_188(this.GetWeaponAI().GetPrimaryTarget().ActualUnit) + num10, ref random_);
                        }
                        return;
                    }
                    if (!(Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit) || Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetWeaponry())))
                    {
                        weaponry = this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetWeaponry();
                        Weapon weapon9 = this;
                        weaponry.AttackTarget(elapsedTime, ref weapon9);
                    }
                    else
                    {
                        if ((this.GetWeaponAI().GetPrimaryTarget().contactType != Contact_Base.ContactType.Aimpoint) && Debugger.IsAttached)
                        {
                            Debugger.Break();
                        }
                        base.m_Scenario.RemoveUnit(this);
                    }
                    goto Label_2069;
                }
                if (this.GetWeaponAI().GetPrimaryTarget().contactType != Contact_Base.ContactType.Aimpoint)
                {
                    goto Label_1F23;
                }
                if (this.m_Warheads.Any<Warhead>() && this.m_Warheads[0].method_18(this, this.GetWeaponAI().GetPrimaryTarget().ActualUnit))
                {
                    nullable = null;
                    nullable = null;
                    this.Detonation(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(nullable), this.GetWeaponAI().GetPrimaryTarget().GetLongitude(nullable), this.method_188(this.GetWeaponAI().GetPrimaryTarget().ActualUnit) + num10, ref random_);
                    goto Label_2069;
                }
                float missDistance = 0f;
                float missArimuth = 0f;
                this.IsTargetHit(this.GetWeaponAI().GetPrimaryTarget().ActualUnit, ref this.m_Scenario, ref missDistance, ref missArimuth, ref random_);
                double num13 = 0.0;
                double num14 = 0.0;
                nullable = null;
                nullable = null;
                Math2.GetAnotherGeopoint(this.GetWeaponAI().GetPrimaryTarget().GetLongitude(nullable), this.GetWeaponAI().GetPrimaryTarget().GetLatitude(nullable), ref num13, ref num14, missDistance / 1852f, missArimuth);
                using (List<ActiveUnit>.Enumerator enumerator2 = base.m_Scenario.GetActiveUnitList().GetEnumerator())
                {
                    ActiveUnit current;
                    while (enumerator2.MoveNext())
                    {
                        current = enumerator2.Current;
                        if (current.GetApproxAngularDistanceInDegrees(ref num14, ref num13) < Misc.double_0)
                        {
                            nullable = null;
                            nullable = null;
                            float num15 = Math2.GetDistance(num14, num13, current.GetLatitude(nullable), current.GetLongitude(nullable)) * 1852f;
                            if (IsHit(current, num15, this.LaunchPoint, this.GetLargestRangeMaxOfAllDomains(), false))
                            {
                                goto Label_1E1B;
                            }
                        }
                    }
                    goto Label_1F08;
                Label_1E1B:;
                    nullable = null;
                    nullable = null;
                    base.m_Scenario.LogMessage("武器: " + base.Name + "命中" + current.Name + ". ", LoggedMessage.MessageType.WeaponEndgame, 0, base.GetGuid(), null, new GeoPoint(current.GetLongitude(nullable), current.GetLatitude(nullable)));
                    ActiveUnit_Damage damage = current.GetDamage();
                    GeoPoint launchPoint = this.LaunchPoint;
                    float num16 = 0f;
                    float num17 = 0f;
                    ActiveUnit unit4 = null;
                    double? nullable10 = null;
                    double? nullable11 = null;
                    float? nullable12 = null;
                    string str = null;
                    damage.vmethod_11(this, launchPoint, num16, num17, unit4, nullable10, nullable11, nullable12, ref str);
                    base.m_Scenario.RemoveUnit(this);
                    return;
                }
            Label_1F08:
                this.Detonation(num14, num13, (float)Terrain.GetElevation(num14, num13, false), ref random_);
                goto Label_2069;
            Label_1F23:
                if (!((this.GetGuidanceMethod() == _GuidanceMethod.InertiallyGuided) || this.GetWeaponAI().GetPrimaryTarget().IsFacilityType()))
                {
                    this.GetWeaponAI().DropTargeting(this.GetWeaponAI().GetPrimaryTarget(), true);
                    return;
                }
                if (Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
                {
                    if (this.GetWeaponNavigator().HasPlottedCourse())
                    {
                        Waypoint waypoint = this.GetWeaponNavigator().GetPlottedCourse()[0];
                        this.Detonation(waypoint.GetLatitude(), waypoint.GetLongitude(), (float)Terrain.GetElevation(waypoint.GetLatitude(), waypoint.GetLongitude(), false), ref random_);
                    }
                    else
                    {
                        nullable = null;
                        nullable = null;
                        nullable = null;
                        nullable = null;
                        this.Detonation(this.GetLatitude(nullable), this.GetLongitude(nullable), (float)Terrain.GetElevation(this.GetLatitude(nullable), this.GetLongitude(nullable), false), ref random_);
                    }
                }
                else
                {
                    nullable = null;
                    nullable = null;
                    this.Detonation(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(nullable), this.GetWeaponAI().GetPrimaryTarget().GetLongitude(nullable), num10 + this.method_188(this.GetWeaponAI().GetPrimaryTarget().ActualUnit), ref random_);
                }
            Label_2069:
                if (this.DetonationDelay > 0f)
                {
                    this.DetonationDelay -= elapsedTime;
                    if (this.DetonationDelay <= 0f)
                    {
                        nullable = null;
                        this.Detonation(this.GetLatitude(nullable), this.GetLongitude((bool?)null), (float)base.GetTerrainElevation(false, false, false), ref random_);
                    }
                }
            }
            catch (Exception exception38)
            {
                ProjectData.SetProjectError(exception38);
                Exception exception39 = exception38;
                exception39.Data.Add("Error at 100925", "");
                GameGeneral.LogException(ref exception39);
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }
                ProjectData.ClearProjectError();
            }

        }

        // Token: 0x060055CC RID: 21964 RVA: 0x0024325C File Offset: 0x0024145C
        private void method_201(Weapon weapon_, Contact target_, float elapsedTime_, bool bool_21)
		{
			WeaponRec weaponRec = new WeaponRec(ref this.m_Scenario, weapon_.DBID, 1, 1, 1, 1, false, false);
			ActiveUnit_Weaponry weaponry = this.GetWeaponry();
			int i = 0;
			float initialHeading = 0f;
			Mount firingMount = null;
			WeaponSalvo weaponSalvo = null;
			List<Unit> list = weaponry.FireWeapons(elapsedTime_, ref weaponRec, target_, false, ref i, 0, initialHeading, ActiveUnit.Throttle.Flank, firingMount, SonarEnvironment._SonobuoyDepthSetting.Shallow, 0L, ref weaponSalvo);
			foreach (Unit current in list)
			{
				if (current.IsWeapon && ((Weapon)current).IsRVorHGV() && !((Weapon)current).IsHypersonicGlideVehicle())
				{
					((Weapon)current).SetCruiseAltitude_ASL(this.GetCurrentAltitude_ASL(false));
				}
			}
			checked
			{
				if (bool_21)
				{
					using (List<Unit>.Enumerator enumerator2 = list.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							ActiveUnit activeUnit = (ActiveUnit)enumerator2.Current;
							foreach (ActiveUnit current2 in this.m_Scenario.GetActiveUnitList())
							{
								foreach (Contact current3 in current2.GetSensory().method_63().Values)
								{
									if (!Information.IsNothing(current3.ActualUnit) && current3.ActualUnit == this)
									{
										current2.GetSensory().LazyContactDictionary.Value.TryAdd(base.GetGuid(), current3);
									}
								}
							}
							Side[] sides = this.m_Scenario.GetSides();
							for (i = 0; i < sides.Length; i++)
							{
								Side side = sides[i];
								if (side.GetContactObservableDictionary().ContainsKey(base.GetGuid()))
								{
									Contact contact = null;
									side.GetContactObservableDictionary().TryGetValue(base.GetGuid(), ref contact);
									if (!Information.IsNothing(contact))
									{
										contact.ActualUnit = activeUnit;
										contact.string_6 = activeUnit.GetGuid();
										side.GetContactObservableDictionary().Add(activeUnit.GetGuid(), contact);
										side.GetContactObservableDictionary().Remove(base.GetGuid());
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060055CD RID: 21965 RVA: 0x00243520 File Offset: 0x00241720
		public bool IsMREV_GuidedBallisticMissile()
		{
			if (!this.bMREV_GuidedBallisticMissile.HasValue)
			{
				this.bMREV_GuidedBallisticMissile = new bool?(this.GetWeaponType() == Weapon._WeaponType.GuidedWeapon && this.weaponCode.BallisticMissile && this.weaponCode.Warhead_MultipleIndependentReEntryVehicles);
			}
			return this.bMREV_GuidedBallisticMissile.Value;
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x000276A8 File Offset: 0x000258A8
		public bool IsMREV_BallisticMissile()
		{
			if (!this.bMREV_BallisticMissile.HasValue)
			{
				this.bMREV_BallisticMissile = new bool?(this.weaponCode.BallisticMissile && this.weaponCode.Warhead_MultipleReEntryVehicles);
			}
			return this.bMREV_BallisticMissile.Value;
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x00243578 File Offset: 0x00241778
		public bool method_204()
		{
			bool flag = false;
			bool result;
			try
			{
				if (this.bool_20)
				{
					flag = this.bool_20;
				}
				else if (this.IsRVorHGV())
				{
					flag = true;
				}
				else
				{
					float distance;
					float num;
					if (this.GetGuidanceMethod() == Weapon._GuidanceMethod.InertiallyGuided)
					{
						if (!this.GetWeaponNavigator().HasPlottedCourse())
						{
							flag = false;
							result = false;
							return result;
						}
						distance = Math2.GetDistance(this.LaunchPoint.GetLatitude(), this.LaunchPoint.GetLongitude(), this.GetWeaponNavigator().GetPlottedCourse()[this.GetWeaponNavigator().GetPlottedCourse().Count<Waypoint>() - 1].GetLatitude(), this.GetWeaponNavigator().GetPlottedCourse()[this.GetWeaponNavigator().GetPlottedCourse().Count<Waypoint>() - 1].GetLongitude());
						num = base.HorizontalRangeTo(this.GetWeaponNavigator().GetPlottedCourse()[this.GetWeaponNavigator().GetPlottedCourse().Count<Waypoint>() - 1]);
					}
					else
					{
						if (Information.IsNothing(this.GetWeaponAI()) || Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
						{
							flag = false;
							result = false;
							return result;
						}
						distance = Math2.GetDistance(this.LaunchPoint.GetLatitude(), this.LaunchPoint.GetLongitude(), this.GetWeaponAI().GetPrimaryTarget().GetLatitude(null), this.GetWeaponAI().GetPrimaryTarget().GetLongitude(null));
						num = base.GetHorizontalRange(this.GetWeaponAI().GetPrimaryTarget());
					}
					if (this.m_Warheads.Any<Warhead>() && !Information.IsNothing(this.m_Warheads[0].GetWeaponFromDP(this.m_Scenario)) && this.m_Warheads[0].GetWeaponFromDP(this.m_Scenario).IsHypersonicGlideVehicle() && this.GetCurrentAltitude_ASL(false) == this.GetCruiseAltitude_ASL())
					{
						this.bool_20 = true;
					}
					this.bool_20 = ((double)num * 1.1 < (double)(distance / 2f));
					flag = this.bool_20;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100926", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x002437E8 File Offset: 0x002419E8
		private bool IsReceivingBuddyIllumination()
		{
			bool result = false;
			try
			{
				if (!this.weaponCode.SupportsBuddyIllumination)
				{
					result = false;
				}
				else
				{
					ActiveUnit illuminatorOfTarget = this.GetIlluminatorOfTarget(this.GetSide(false), this.GetWeaponAI().GetPrimaryTarget());
					if (Information.IsNothing(illuminatorOfTarget))
					{
						result = false;
					}
					else
					{
						ActiveUnit_Sensory sensory = illuminatorOfTarget.GetSensory();
						Contact primaryTarget = this.GetWeaponAI().GetPrimaryTarget();
						bool? flag = null;
						bool? flag2 = null;
						Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
						bool? flag3 = null;
						result = sensory.IsIlluminatingTarget(primaryTarget, this, ref flag, ref flag2, ref lOS_Exists_Visual, ref flag3);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100927", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060055D1 RID: 21969 RVA: 0x002438CC File Offset: 0x00241ACC
		public void Detonation(double lat, double lon, float alt_asl, ref Random random_)
		{
			try
			{
				if (this.GetWeaponType() != Weapon._WeaponType.Sonobuoy)
				{
					float maxPOKForAllDomains = this.GetMaxPOKForAllDomains();
					if ((float)random_.Next(1, 101) < maxPOKForAllDomains)
					{
						float num = 0f;
						float azimuth = 0f;
						if (this.IsTargetHit(null, ref this.m_Scenario, ref num, ref azimuth, ref random_))
						{
							double num2 = 0.0;
							double num3 = 0.0;
							Math2.GetAnotherGeopoint(lon, lat, ref num2, ref num3, num / 1852f, azimuth);
							new Explosion(ref this.m_Scenario, num2, num3, num2, num3, this.GetCurrentHeading(), alt_asl, this.m_Warheads[0].DP, this.m_Warheads[0].DP, this.m_Warheads[0].warheadType, this.m_Warheads[0].ExplosivesType, null, null, null, null, null, this.m_Warheads[0].ClusterBombDispersionAreaLength, this.m_Warheads[0].ClusterBombDispersionAreaWidth, (int)this.m_Warheads[0].NumberOfWarheads, 0f, 0);
							this.m_Scenario.RemoveUnit(this);
						}
						else
						{
							new Explosion(ref this.m_Scenario, lon, lat, lon, lat, this.GetCurrentHeading(), alt_asl, this.m_Warheads[0].DP, this.m_Warheads[0].DP, this.m_Warheads[0].warheadType, this.m_Warheads[0].ExplosivesType, null, null, null, null, null, this.m_Warheads[0].ClusterBombDispersionAreaLength, this.m_Warheads[0].ClusterBombDispersionAreaWidth, (int)this.m_Warheads[0].NumberOfWarheads, 0f, 0);
							this.m_Scenario.RemoveUnit(this);
						}
					}
					else
					{
						this.m_Scenario.LogMessage("武器: " + this.Name + "发生故障.", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						this.m_Scenario.RemoveUnit(this);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101338", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060055D2 RID: 21970 RVA: 0x00243B3C File Offset: 0x00241D3C
		public bool IsPrimaryTargetDisappear()
		{
			return Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) || Information.IsNothing(this.m_Scenario) || (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit) && !this.GetWeaponAI().GetPrimaryTarget().ActualUnit.IsOperating());
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x00243BA0 File Offset: 0x00241DA0
		protected void method_208()
		{
			if (this.GetGuidanceMethod() != Weapon._GuidanceMethod.InertiallyGuided && !this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
			{
				this.method_212(!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) && this.GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.ActivationPoint, false, false);
			}
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x00243BF8 File Offset: 0x00241DF8
		public bool method_209()
		{
			bool result;
			if (this.method_211())
			{
				result = !this.GetWeaponNavigator().HasPlottedCourse();
			}
			else
			{
				result = (this.method_210() && Information.IsNothing(this.GetDataLinkParent()));
			}
			return result;
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x00243C3C File Offset: 0x00241E3C
		public bool method_210()
		{
			Weapon._GuidanceMethod guidanceMethod = this.GetGuidanceMethod();
			return guidanceMethod == Weapon._GuidanceMethod.const_5 || guidanceMethod == Weapon._GuidanceMethod.const_7 || guidanceMethod - Weapon._GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance <= 1;
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x00243C68 File Offset: 0x00241E68
		public bool method_211()
		{
			Weapon._GuidanceMethod guidanceMethod = this.GetGuidanceMethod();
			bool result;
			switch (guidanceMethod)
			{
			case Weapon._GuidanceMethod.PassiveTerminalGuidance:
			case Weapon._GuidanceMethod.INSMidcoursePlusPassiveTerminalGuidance:
			case Weapon._GuidanceMethod.ActiveTerminalGuidance:
			case Weapon._GuidanceMethod.InertialMidCoursePlusActiveTerminalGuidance:
				result = true;
				return result;
			case Weapon._GuidanceMethod.const_5:
			case Weapon._GuidanceMethod.const_7:
				break;
			default:
				if (guidanceMethod == Weapon._GuidanceMethod.InertiallyGuided)
				{
					result = true;
					return result;
				}
				break;
			}
			result = false;
			return result;
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x00243CB4 File Offset: 0x00241EB4
		private void method_212(bool clearPrimaryTarget = false, bool clearDatalink = false, bool clearPlottedCourse = false)
		{
			checked
			{
				try
				{
					if (this.DRT <= 0f || this.GetGuidanceMethod() != Weapon._GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance)
					{
						this.BlindTime = 0f;
					}
					this.DRT = 0f;
					if (clearPrimaryTarget)
					{
						ActiveUnit_AI weaponAI = this.GetWeaponAI();
						ActiveUnit activeUnit = this;
						weaponAI.ClearPrimaryTarget(ref activeUnit);
						if (!this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
						{
							this.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.GetCurrentHeading());
						}
					}
					if (clearDatalink)
					{
						this.ClearDatalink();
						this.SetDefaultGuidanceMethod();
						Weapon._GuidanceMethod? guidanceMethod = this.GuidanceMethod;
						byte? b = guidanceMethod.HasValue ? new byte?((byte)guidanceMethod.GetValueOrDefault()) : null;
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 13) : null).GetValueOrDefault() && !Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) && this.GetWeaponNavigator().GetPlottedCourse().Length == 0)
						{
							this.GetWeaponNavigator().AddWaypoint(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(null), this.GetWeaponAI().GetPrimaryTarget().GetLongitude(null), Waypoint.WaypointType.WeaponTerminalPoint, Waypoint._Creator.const_1, Waypoint._Category.const_0);
						}
					}
					if (clearPlottedCourse && this.GetGuidanceMethod() != Weapon._GuidanceMethod.InertiallyGuided)
					{
						this.GetWeaponNavigator().ClearPlottedCourse();
					}
					if (!this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
					{
						Sensor[] noneMCMSensors = this.GetNoneMCMSensors();
						for (int i = 0; i < noneMCMSensors.Length; i++)
						{
							Sensor sensor = noneMCMSensors[i];
							if (sensor.IsActiveCapable())
							{
								sensor.TurnOn();
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100928", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060055D8 RID: 21976 RVA: 0x000276E8 File Offset: 0x000258E8
		public void ClearDatalink()
		{
			if (!Information.IsNothing(this.GetDataLinkParent()))
			{
				this.SetDataLinkParent(null);
			}
			this.m_CommDevices = new CommDevice[0];
		}

		// Token: 0x060055D9 RID: 21977 RVA: 0x00243EC0 File Offset: 0x002420C0
		public void InitializeSensors()
		{
			if (this.GetNoneMCMSensors().Length > 0)
			{
				Sensor[] noneMCMSensors = this.GetNoneMCMSensors();
				ScenarioArrayUtil.NewSensorArray(ref noneMCMSensors);
			}
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x00243EEC File Offset: 0x002420EC
		public bool method_215()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					Warhead[] warheads = this.m_Warheads;
					for (int i = 0; i < warheads.Length; i++)
					{
						Warhead warhead = warheads[i];
						if (warhead.IsTorpedo())
						{
							flag = true;
							result = true;
							return result;
						}
						if (warhead.warheadType == Warhead.WarheadType.Weapon && warhead.GetWeaponFromDP(this.m_Scenario).IsTorpedo())
						{
							flag = true;
							result = true;
							return result;
						}
					}
					flag = false;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100929", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					flag = false;
					ProjectData.ClearProjectError();
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x00243FB0 File Offset: 0x002421B0
		private bool HasDepthChargeWarhead()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					Warhead[] warheads = this.m_Warheads;
					for (int i = 0; i < warheads.Length; i++)
					{
						Warhead warhead = warheads[i];
						if (warhead.warheadType == Warhead.WarheadType.DepthCharge)
						{
							flag = true;
							result = true;
							return result;
						}
						if (warhead.warheadType == Warhead.WarheadType.Weapon && warhead.GetWeaponFromDP(this.m_Scenario).GetWeaponType() == Weapon._WeaponType.DepthCharge)
						{
							flag = true;
							result = true;
							return result;
						}
					}
					flag = false;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100930", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					flag = false;
					ProjectData.ClearProjectError();
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x00244084 File Offset: 0x00242284
		private void method_217()
		{
			List<Warhead> list = new List<Warhead>();
			checked
			{
				try
				{
					Warhead[] warheads = this.m_Warheads;
					for (int i = 0; i < warheads.Length; i++)
					{
						Warhead warhead = warheads[i];
						if (!Information.IsNothing(warhead.GetWeaponFromDP(this.m_Scenario)) && warhead.GetWeaponFromDP(this.m_Scenario).IsTorpedo())
						{
							Weapon weapon = Weapon.GetWeapon(ref this.m_Scenario, unchecked((int)Math.Round((double)warhead.DP)), null);
							weapon.SetLatitude(null, this.GetLatitude(null));
							weapon.SetLongitude(null, this.GetLongitude(null));
							weapon.SetAltitude_ASL(false, -20f);
							weapon.SetCurrentHeading(this.GetCurrentHeading());
							weapon.SetDesiredHeading(ActiveUnit._TurnRate.const_0, weapon.GetCurrentHeading());
							weapon.LaunchPoint = new GeoPoint(this.GetLongitude(null), this.GetLatitude(null));
							weapon.SetSide(false, this.GetSide(false));
							weapon.SetThrottle(weapon.GetMaxThrottleAvailable(), null);
							weapon.GetWeaponAI().SetPrimaryTarget(this.GetWeaponAI().GetPrimaryTarget());
							weapon.SetFiringParent(this.GetFiringParent());
							weapon.searchPatternType = Weapon._SearchPatternType.const_2;
							if (!this.m_Scenario.GetActiveUnits().ContainsKey(weapon.GetGuid()))
							{
								this.m_Scenario.AddUnit(weapon);
							}
							list.Add(warhead);
							Weapon_AI weaponAI;
							Contact primaryTarget = (weaponAI = weapon.GetWeaponAI()).GetPrimaryTarget();
							this.method_233(ref weapon, ref primaryTarget, this.m_Scenario);
							weaponAI.SetPrimaryTarget(primaryTarget);
						}
					}
					foreach (Warhead current in list)
					{
						ScenarioArrayUtil.RemoveWarhead(ref this.m_Warheads, current);
					}
					if (this.m_Warheads.Length == 0 || this.GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.Submarine)
					{
						this.m_Scenario.RemoveUnit(this);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100931", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x00244324 File Offset: 0x00242524
		private void method_218()
		{
			List<Warhead> list = new List<Warhead>();
			checked
			{
				try
				{
					Warhead[] warheads = this.m_Warheads;
					for (int i = 0; i < warheads.Length; i++)
					{
						Warhead warhead = warheads[i];
						if (!Information.IsNothing(warhead.GetWeaponFromDP(this.m_Scenario)) && warhead.GetWeaponFromDP(this.m_Scenario).GetWeaponType() == Weapon._WeaponType.DepthCharge)
						{
							UnguidedWeapon unguidedWeapon = new UnguidedWeapon(warhead.GetWeaponFromDP(this.m_Scenario), this.GetWeaponAI().GetPrimaryTarget(), this, this.GetLatitude(null), this.GetLongitude(null), 0L);
							unguidedWeapon.CEP_Surface = (float)warhead.GetWeaponFromDP(this.m_Scenario).CEPSurface;
							unguidedWeapon.SetCurrentHeading(this.GetWeaponAI().GetAzimuth(this.GetWeaponAI().GetPrimaryTarget()));
							unguidedWeapon.SetSide(false, this.GetSide(false));
							unguidedWeapon.SetFiringParent(this.FiringParent);
							if (!Information.IsNothing(this.FiringParent))
							{
								unguidedWeapon.FiringParentName = this.FiringParent.GetGuid();
							}
							if (warhead.GetWeaponFromDP(this.m_Scenario).HasNuclearWarhead())
							{
								if ((float)GameGeneral.GetRandom().Next(1, 101) < unguidedWeapon.SubsurfacePOK)
								{
									unguidedWeapon.Detonation(this.m_Scenario);
								}
							}
							else
							{
								this.m_Scenario.GetUnguidedWeapons().Add(unguidedWeapon.GetGuid(), unguidedWeapon);
							}
							list.Add(warhead);
						}
					}
					foreach (Warhead current in list)
					{
						ScenarioArrayUtil.RemoveWarhead(ref this.m_Warheads, current);
					}
					if (this.m_Warheads.Length == 0 || this.GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.Submarine)
					{
						this.m_Scenario.RemoveUnit(this);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100932", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x00244588 File Offset: 0x00242788
		public void method_219(bool ComputeTerminalPoint = true)
		{
			checked
			{
				try
				{
					if (this.GetGuidanceMethod() == Weapon._GuidanceMethod.SemiActive)
					{
						this.weaponCode.IlluminateAtLaunch = false;
						this.weaponCode.TerminalIllumination = false;
						using (IEnumerator<ActiveUnit> enumerator = this.m_Scenario.GetActiveUnits().Values.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Sensor[] noneMCMSensors = enumerator.Current.GetNoneMCMSensors();
								for (int i = 0; i < noneMCMSensors.Length; i++)
								{
									Sensor sensor = noneMCMSensors[i];
									if (sensor.SemiActiveGuidedWeaponList.Contains(this))
									{
										sensor.SemiActiveGuidedWeaponList.Remove(this);
										this.SetDirector(null);
									}
									if (sensor.SemiActiveGuidedWeaponList.Count == 0)
									{
										Sensor sensor2 = sensor;
										Weapon_AI weaponAI;
										Contact primaryTarget = (weaponAI = this.GetWeaponAI()).GetPrimaryTarget();
										sensor2.StopIlluminateTarget(ref primaryTarget, false);
										weaponAI.SetPrimaryTarget(primaryTarget);
									}
								}
							}
						}
					}
					if (this.m_CommDevices.Count<CommDevice>() > 0 && (this.GetWeaponAI().GetPrimaryTargetType() == Contact_Base.ContactType.Surface || this.GetWeaponAI().GetPrimaryTargetType() == Contact_Base.ContactType.Submarine || this.GetWeaponAI().GetPrimaryTargetType() == Contact_Base.ContactType.Facility_Fixed || this.GetWeaponAI().GetPrimaryTargetType() == Contact_Base.ContactType.Facility_Mobile))
					{
						if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
						{
							Aimpoint primaryTarget2 = new Aimpoint(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(null), this.GetWeaponAI().GetPrimaryTarget().GetLongitude(null));
							this.GetWeaponAI().SetPrimaryTarget(primaryTarget2);
						}
						else
						{
							Aimpoint primaryTarget2 = new Aimpoint(this.GetWeaponAI().GetPrimaryTarget_LastKnown_Lat(), this.GetWeaponAI().GetPrimaryTarget_LastKnown_Lon());
							this.GetWeaponAI().SetPrimaryTarget(primaryTarget2);
						}
					}
					else
					{
						this.InitializeSensors();
						this.ClearDatalink();
						this.SetDefaultGuidanceMethod();
						if (this.GetGuidanceMethod() == Weapon._GuidanceMethod.InertiallyGuided && ComputeTerminalPoint)
						{
							this.GetWeaponNavigator().method_57((float)this.GetWeaponKinematics().GetSpeed(this.GetCurrentAltitude_ASL(false), this.GetThrottle()), false);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100933", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060055DF RID: 21983 RVA: 0x00244810 File Offset: 0x00242A10
		protected bool method_220(float elapsedTime)
		{
			bool result = false;
			try
			{
				if (!this.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() && this.GetWeaponType() != Weapon._WeaponType.Torpedo && this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
				{
					result = false;
				}
				else
				{
					if (Information.IsNothing(this.GetDataLinkParent()) || this.GetDataLinkParent().IsNotActive())
					{
						this.GetWeaponCommStuff().vmethod_1(elapsedTime);
					}
					if (!Information.IsNothing(this.GetDataLinkParent()) && !this.GetDataLinkParent().IsNotActive())
					{
						if (this.GetDataLinkParent().IsShip && ((Ship)this.GetDataLinkParent()).IsDestroyed())
						{
							this.method_212(false, true, false);
							result = true;
						}
						else
						{
							result = false;
						}
					}
					else
					{
						if (this.GetGuidanceMethod() == Weapon._GuidanceMethod.TrackViaMissile)
						{
							this.method_212(true, true, true);
						}
						else
						{
							this.method_212(false, true, false);
						}
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100934", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060055E0 RID: 21984 RVA: 0x00244944 File Offset: 0x00242B44
		protected bool method_221(float float_47)
		{
			bool result = false;
			try
			{
				if (this.IsPrimaryTargetDisappear())
				{
					this.Redirect(float_47);
					result = true;
				}
				else if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) && !this.GetWeaponAI().GetPrimaryTarget().IsDestroyed(this.m_Scenario))
				{
					if (this.GetWeaponAI().GetPrimaryTarget().Age > 30f && this.GetWeaponAI().GetPrimaryTarget().IsAirSpace() && !this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
					{
						if (!this.method_209())
						{
							this.method_212(true, true, false);
							base.LogMessage("武器: " + this.Name + "不能从发射平台获得稳定的目标更新信息... 转入自主模式.", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						}
						result = true;
					}
					else if (this.IsTorpedo() && this.GetWeaponAI().GetPrimaryTarget().Age > 1200f && !this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint() && !this.method_209())
					{
						this.method_212(true, true, false);
						base.LogMessage("武器: " + this.Name + "不能从发射平台获得稳定的目标更新信息... 转入自主模式.", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						result = true;
					}
					else
					{
						result = false;
					}
				}
				else
				{
					this.Redirect(float_47);
					result = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100935", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x00244B20 File Offset: 0x00242D20
		private bool method_222(float elapsedTime)
		{
			bool result = false;
			try
			{
				if (this.IsPrimaryTargetDisappear())
				{
					if (!base.HasInfraredSensor())
					{
						this.SetBlindTime(this.GetBlindTime() + elapsedTime);
					}
					result = true;
				}
				else if (this.GetWeaponAI().GetPrimaryTarget().IsDestroyed(this.m_Scenario))
				{
					if (!this.GetWeaponAI().GetPrimaryTarget().IsSurfaceOrLandTarget())
					{
						if (!Information.IsNothing(this.GetDataLinkParent()))
						{
							base.LogMessage("武器: " + this.Name + "的攻击目标已经在末段照射阶段被摧毁，重试重新调整目标...", LoggedMessage.MessageType.WeaponEndgame, 5, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
							this.Redirect(elapsedTime);
						}
						else
						{
							base.LogMessage("武器: " + this.Name + "的攻击目标已被摧毁...", LoggedMessage.MessageType.WeaponEndgame, 5, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
							this.method_212(true, true, true);
						}
					}
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100936", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x00244C90 File Offset: 0x00242E90
		protected bool method_223()
		{
			bool flag = false;
			bool result;
			try
			{
				if (this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
				{
					flag = false;
				}
				else
				{
					if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
					{
						if (this.GetWeaponAI().GetPrimaryTarget().IsDestroyed(this.m_Scenario))
						{
							this.method_212(true, true, false);
							flag = true;
							result = true;
							return result;
						}
					}
					else if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) && this.IsTorpedo() && this.GetWeaponAI().GetPrimaryTarget().Age > 600f)
					{
						base.LogMessage("Weapon: " + this.Name + " is not receiving firm target updates from parent unit... Going autonomous.", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						flag = true;
						result = true;
						return result;
					}
					flag = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100937", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x00244DD0 File Offset: 0x00242FD0
		private bool method_224()
		{
			bool flag = false;
			bool result;
			try
			{
				if (this.GetWeaponAI().GetPrimaryTargetType() == Contact_Base.ContactType.Surface || this.GetWeaponAI().GetPrimaryTargetType() == Contact_Base.ContactType.Submarine || this.GetWeaponAI().GetPrimaryTargetType() == Contact_Base.ContactType.Facility_Fixed || this.GetWeaponAI().GetPrimaryTargetType() == Contact_Base.ContactType.Facility_Mobile)
				{
					if (this.IsPrimaryTargetDisappear())
					{
						Aimpoint primaryTarget = new Aimpoint(this.GetWeaponAI().GetPrimaryTarget_LastKnown_Lat(), this.GetWeaponAI().GetPrimaryTarget_LastKnown_Lon());
						this.GetWeaponAI().SetPrimaryTarget(primaryTarget);
						flag = true;
						result = true;
						return result;
					}
					if (this.GetWeaponAI().GetPrimaryTarget().IsDestroyed(this.m_Scenario))
					{
						Aimpoint primaryTarget2 = new Aimpoint(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(null), this.GetWeaponAI().GetPrimaryTarget().GetLongitude(null));
						this.GetWeaponAI().SetPrimaryTarget(primaryTarget2);
						flag = true;
						result = true;
						return result;
					}
				}
				flag = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101297", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x060055E4 RID: 21988 RVA: 0x00244F20 File Offset: 0x00243120
		protected bool method_225(float angle, bool bool_21, bool bool_22, bool bool_23, float elapsedTime)
		{
			bool flag = false;
			bool result;
			try
			{
				if (this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
				{
					flag = false;
				}
				else
				{
					if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) && this.GetWeaponAI().GetPrimaryTarget().contactType != Contact_Base.ContactType.Aimpoint)
					{
						if ((double)base.GetHorizontalRange(this.GetWeaponAI().GetPrimaryTarget()) < 0.3)
						{
							flag = false;
							result = false;
							return result;
						}
						if (this.IsTorpedo() && this.weaponCode.SearchPattern)
						{
							ActiveUnit_AI weaponAI = this.GetWeaponAI();
							Weapon weapon = this;
							if (!weaponAI.method_59(ref weapon))
							{
								flag = false;
								result = false;
								return result;
							}
						}
						float angleBetween;
						if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit))
						{
							angleBetween = Class263.GetAngleBetween(this.GetCurrentHeading(), this.GetWeaponAI().GetAzimuth(this.GetWeaponAI().GetPrimaryTarget().ActualUnit));
						}
						else
						{
							angleBetween = Class263.GetAngleBetween(this.GetCurrentHeading(), this.GetWeaponAI().GetAzimuth(this.GetWeaponAI().GetPrimaryTarget()));
						}
						if (360f - angle > angleBetween && angleBetween > angle && !this.bPrimaryTargetAttackable)
						{
							if (!Information.IsNothing(this.GetDataLinkParent()))
							{
								if (base.GetHorizontalRange(this.GetDataLinkParent()) < 2f)
								{
									flag = false;
									result = false;
									return result;
								}
								this.Redirect(elapsedTime);
								flag = true;
								result = true;
								return result;
							}
							else
							{
								if (!Information.IsNothing(this.GetFiringParent()) && base.GetHorizontalRange(this.GetFiringParent()) < 2f)
								{
									flag = false;
									result = false;
									return result;
								}
								if (this.GetWeaponAI().GetPrimaryTarget().contactType != Contact_Base.ContactType.Aimpoint)
								{
									base.LogMessage("Weapon: " + this.Name + " overshot its target...", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
								}
								this.method_212(bool_21, bool_22, bool_23);
								flag = true;
								result = true;
								return result;
							}
						}
					}
					flag = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100938", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x002451A0 File Offset: 0x002433A0
		private bool method_226(float float_47)
		{
			bool flag = false;
			bool result;
			if (Information.IsNothing(this.GetDataLinkParent()) && Information.IsNothing(this.GetFiringParent()))
			{
				flag = false;
			}
			else if (Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit))
			{
				flag = false;
			}
			else
			{
				try
				{
					if (this.GetWeaponAI().GetPrimaryTarget().ActualUnit.IsAircraft || this.GetWeaponAI().GetPrimaryTarget().ActualUnit.IsWeapon)
					{
						if ((double)base.GetHorizontalRange(this.GetWeaponAI().GetPrimaryTarget()) < 0.3)
						{
							flag = false;
							result = false;
							return result;
						}
						float num = 0f;
						if (!Information.IsNothing(this.GetDataLinkParent()))
						{
							if (base.GetHorizontalRange(this.GetDataLinkParent()) < 2f)
							{
								flag = false;
								result = false;
								return result;
							}
							num = Class263.GetAngleBetween(this.GetCurrentHeading(), Math2.GetAzimuth(this.GetDataLinkParent().GetLatitude(null), this.GetDataLinkParent().GetLongitude(null), this.GetLatitude(null), this.GetLongitude(null)));
						}
						else if (!Information.IsNothing(this.GetFiringParent()))
						{
							if (base.GetHorizontalRange(this.GetFiringParent()) < 2f)
							{
								flag = false;
								result = false;
								return result;
							}
							num = Class263.GetAngleBetween(this.GetCurrentHeading(), Math2.GetAzimuth(this.GetFiringParent().GetLatitude(null), this.GetFiringParent().GetLongitude(null), this.GetLatitude(null), this.GetLongitude(null)));
						}
						if (num > float_47 && num < 360f - float_47 && !this.bPrimaryTargetAttackable)
						{
							if (this.GetGuidanceMethod() == Weapon._GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance || this.GetGuidanceMethod() == Weapon._GuidanceMethod.TimeSharedSemiActiveMidCoursePlusActiveTerminalGuidance)
							{
								base.LogMessage("Weapon: " + this.Name + " can no longer see reflected energy from its target (engagement geometry issue)... switching to onboard seeker", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
								this.method_212(false, true, true);
								flag = true;
								result = true;
								return result;
							}
							if (this.GetNoneMCMSensors().Length != 1 && this.GetGuidanceMethod() != Weapon._GuidanceMethod.TrackViaMissile)
							{
								base.LogMessage("Weapon: " + this.Name + " can no longer see reflected energy from target (engagement geometry issue)... Switching to backup seeker", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
								this.method_212(false, true, true);
								flag = true;
								result = true;
								return result;
							}
							base.LogMessage("Weapon: " + this.Name + " can no longer see reflected energy from target (engagement geometry issue)...", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
							this.method_212(true, true, true);
							flag = true;
							result = true;
							return result;
						}
					}
					flag = false;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100939", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					flag = false;
					ProjectData.ClearProjectError();
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x060055E6 RID: 21990 RVA: 0x00245524 File Offset: 0x00243724
		protected void CommandGuidance(float elapsedTime)
		{
			try
			{
				if (!this.method_220(elapsedTime) && !this.method_221(elapsedTime))
				{
					if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) && this.GetWeaponAI().GetPrimaryTarget().IsBallisticMissileOrReEntryVehicles())
					{
						if (this.method_225(120f, true, true, true, elapsedTime))
						{
						}
					}
					else
					{
						this.method_225(90f, true, true, true, elapsedTime);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100941", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x002455E4 File Offset: 0x002437E4
		public ActiveUnit GetIlluminatorOfTarget(Side side_, Contact target_)
		{
			Weapon.WeaponDirector weaponDirector = new Weapon.WeaponDirector();
			weaponDirector.theWeapon = this;
			weaponDirector.theTarget = target_;
			ActiveUnit activeUnit = null;
			ActiveUnit result;
			try
			{
				Weapon.Illuminator illuminator = new Weapon.Illuminator();
				illuminator.weaponDirector = weaponDirector;
				illuminator.LOS_Exists_Visual = null;
				illuminator.LOS_Exists_Radar = null;
				illuminator.LOS_Exists_RadarSW = null;
				illuminator.LOS_Exists_Sonar = null;
				if (!Information.IsNothing(this.IlluminatorUnit) && !Information.IsNothing(illuminator.weaponDirector.theTarget) && this.IlluminatorUnit.GetSensory().IsIlluminating(illuminator.weaponDirector.theTarget, this, ref illuminator.weaponDirector.Director, ref illuminator.LOS_Exists_Radar, ref illuminator.LOS_Exists_RadarSW, ref illuminator.LOS_Exists_Visual, ref illuminator.LOS_Exists_Sonar))
				{
					activeUnit = this.IlluminatorUnit;
				}
				else
				{
					List<ActiveUnit> source = side_.ActiveUnitArray.ToList<ActiveUnit>();
					if (this.weaponCode.SupportsBuddyIllumination && !Information.IsNothing(illuminator.weaponDirector.theTarget))
					{
						IEnumerable<ActiveUnit> source2 = source.Where(new Func<ActiveUnit, bool>(illuminator.IsIlluminating)).OrderBy(new Func<ActiveUnit, double>(illuminator.weaponDirector.GeAngularDistance));
						if (source2.Count<ActiveUnit>() > 0)
						{
							activeUnit = source2.ElementAtOrDefault(0);
							result = activeUnit;
							return result;
						}
					}
					activeUnit = null;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100942", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				activeUnit = null;
				ProjectData.ClearProjectError();
			}
			result = activeUnit;
			return result;
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x00245790 File Offset: 0x00243990
		private void TrackViaMissileGuidance(float elapsedTime)
		{
			try
			{
				if (this.GetWeaponType() != Weapon._WeaponType.Sonobuoy && !this.method_220(elapsedTime) && !this.method_221(elapsedTime))
				{
					if (this.IsTargetLost())
					{
						this.SetBlindTime(this.GetBlindTime() + elapsedTime);
					}
					else
					{
						this.SetBlindTime(0f);
						this.GetWeaponAI().GetPrimaryTarget().Age = 0f;
						base.GetDesiredSpeed(this.GetWeaponAI().GetPrimaryTarget(), this.GetCurrentSpeed(), this.GetCurrentHeading());
						if (this.bPrimaryTargetAttackable || this.IsTargetAttackable(elapsedTime))
						{
							if (this.GetWeaponAI().GetPrimaryTarget().IsDestroyed(this.m_Scenario))
							{
								return;
							}
							if (Information.IsNothing(this.GetDataLinkParent()) || Information.IsNothing(this.GetDirector()))
							{
								ActiveUnit illuminatorOfTarget = this.GetIlluminatorOfTarget(this.GetSide(false), this.GetWeaponAI().GetPrimaryTarget());
								if (!Information.IsNothing(illuminatorOfTarget))
								{
									ActiveUnit_Sensory sensory = illuminatorOfTarget.GetSensory();
									Contact primaryTarget = this.GetWeaponAI().GetPrimaryTarget();
									bool? flag = null;
									bool? flag2 = null;
									Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
									bool? hintIsOperating = null;
									sensory.IsIlluminatingTarget(primaryTarget, this, ref flag, ref flag2, ref lOS_Exists_Visual, ref hintIsOperating);
								}
								else
								{
									Contact_Base.ContactType contactType = this.GetWeaponAI().GetPrimaryTarget().contactType;
									if (contactType > Contact_Base.ContactType.Missile && contactType != Contact_Base.ContactType.Orbital)
									{
										this.SetCEP_Surface(3 * this.GetCEP_Surface());
										this.SetCEP_Land(3 * this.GetCEP_Land());
										this.SurfacePOK = (int)Math.Round((double)this.SurfacePOK / 3.0);
										this.LandPOK = (int)Math.Round((double)this.LandPOK / 3.0);
										this.SubsurfacePOK = (int)Math.Round((double)this.SubsurfacePOK / 3.0);
									}
									else if (this.GetNoneMCMSensors().Length == 1)
									{
										string string_ = "武器: " + this.Name + "无法获得对目标的照射...";
										bool? hintIsOperating = null;
										double longitude = this.GetLongitude(hintIsOperating);
										hintIsOperating = null;
										base.LogMessage(string_, LoggedMessage.MessageType.WeaponEndgame, 5, false, new GeoPoint(longitude, this.GetLatitude(hintIsOperating)));
										this.GetWeaponAI().SetPrimaryTarget(null);
										return;
									}
								}
							}
						}
						if (!this.GetDataLinkParent().GetSensory().HasTrackingSensorForTarget(this.GetWeaponAI().GetPrimaryTarget()))
						{
							ActiveUnit_Sensory sensory2 = this.GetDataLinkParent().GetSensory();
							Contact primaryTarget2 = this.GetWeaponAI().GetPrimaryTarget();
							bool? hintIsOperating = null;
							bool? flag2 = null;
							Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
							bool? flag = null;
							Sensor sensor = null;
							if (sensory2.IsIlluminating(primaryTarget2, this, ref sensor, ref hintIsOperating, ref flag2, ref lOS_Exists_Visual, ref flag))
							{
								ActiveUnit_Sensory sensory3 = this.GetDataLinkParent().GetSensory();
								Contact primaryTarget3 = this.GetWeaponAI().GetPrimaryTarget();
								flag = null;
								flag2 = null;
								lOS_Exists_Visual = null;
								hintIsOperating = null;
								sensory3.IsIlluminatingTarget(primaryTarget3, this, ref flag, ref flag2, ref lOS_Exists_Visual, ref hintIsOperating);
							}
						}
						if (!this.method_226(90f))
						{
							this.method_225(60f, true, true, true, elapsedTime);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100943", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060055E9 RID: 21993 RVA: 0x00245B30 File Offset: 0x00243D30
		private bool IsTargetLost()
		{
			bool result = false;
			try
			{
				if (Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
				{
					result = true;
				}
				else if (Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit))
				{
					result = true;
				}
				else
				{
					Sensor director = this.GetDirector();
					bool flag = false;
					if (!Information.IsNothing(director) && director.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
					{
						Sensor sensor = director;
						Weapon_AI weaponAI;
						Contact primaryTarget = (weaponAI = this.GetWeaponAI()).GetPrimaryTarget();
						bool flag2 = sensor.IsTargetTracked(ref primaryTarget);
						weaponAI.SetPrimaryTarget(primaryTarget);
						if (!flag2)
						{
							flag = true;
						}
						Sensor sensor2 = director;
						ActiveUnit parentPlatform = director.GetParentPlatform();
						primaryTarget = (weaponAI = this.GetWeaponAI()).GetPrimaryTarget();
						float slantRange = director.GetParentPlatform().GetSlantRange(this.GetWeaponAI().GetPrimaryTarget().ActualUnit, 0f);
						List<ActiveUnit> affectingJammers = null;
						bool isShip = director.GetParentPlatform().IsShip;
						bool isShip2 = director.GetParentPlatform().IsShip;
						bool? flag3 = null;
						bool? flag4 = null;
						Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
						bool? flag5 = null;
						int num = (int)sensor2.WeaponGuidanceAttempt(parentPlatform, ref primaryTarget, ref this.m_Scenario, slantRange, affectingJammers, isShip, isShip2, ref flag3, ref flag4, ref lOS_Exists_Visual, ref flag5);
						weaponAI.SetPrimaryTarget(primaryTarget);
						if (num != 1)
						{
							flag = true;
						}
					}
					else
					{
						flag = true;
					}
					if (flag)
					{
						if (!Information.IsNothing(this.GetFiringParent()))
						{
							ActiveUnit_Sensory sensory = this.GetFiringParent().GetSensory();
							Contact primaryTarget2 = this.GetWeaponAI().GetPrimaryTarget();
							bool? flag5 = null;
							bool? flag6 = null;
							Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
							bool? flag3 = null;
							if (sensory.IsIlluminatingTarget(primaryTarget2, this, ref flag5, ref flag6, ref lOS_Exists_Visual, ref flag3))
							{
								flag = false;
							}
						}
						if (flag && this.IsReceivingBuddyIllumination())
						{
							flag = false;
						}
					}
					result = flag;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100944", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060055EA RID: 21994 RVA: 0x00245D5C File Offset: 0x00243F5C
		private void SemiActiveGuidance(float elapsedTime)
		{
			try
			{
				if (!this.method_222(elapsedTime))
				{
					if (this.IsTargetLost())
					{
						this.SetBlindTime(this.GetBlindTime() + elapsedTime);
					}
					else
					{
						this.SetBlindTime(0f);
						this.GetWeaponAI().GetPrimaryTarget().Age = 0f;
					}
					if (this.bPrimaryTargetAttackable || this.IsTargetAttackable(elapsedTime))
					{
						if (this.GetWeaponAI().GetPrimaryTarget().IsDestroyed(this.m_Scenario))
						{
							return;
						}
						if ((double)this.GetBlindTime() > 0.5)
						{
							Contact_Base.ContactType contactType = this.GetWeaponAI().GetPrimaryTarget().contactType;
							if (contactType > Contact_Base.ContactType.Missile && contactType != Contact_Base.ContactType.Orbital)
							{
								this.SetCEP_Surface(200 * this.GetCEP_Surface() * (int)Math.Round((double)this.GetBlindTime()));
								this.SetCEP_Land(200 * this.GetCEP_Land() * (int)Math.Round((double)this.GetBlindTime()));
								base.LogMessage("武器: " + this.Name + "不能获得对目标的照射... 命中精度将严重下降.", LoggedMessage.MessageType.WeaponEndgame, 5, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
								return;
							}
							if (this.GetNoneMCMSensors().Length == 1)
							{
								base.LogMessage("武器: " + this.Name + "无法获得对目标的照射...", LoggedMessage.MessageType.WeaponEndgame, 5, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
								this.GetWeaponAI().SetPrimaryTarget(null);
								return;
							}
						}
					}
					if (!this.method_226(90f))
					{
						this.method_225(60f, true, true, true, elapsedTime);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100945", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060055EB RID: 21995 RVA: 0x00245F88 File Offset: 0x00244188
		private void method_232(float elapsedTime)
		{
			try
			{
				if (!this.method_222(elapsedTime))
				{
					float desiredSpeed = base.GetDesiredSpeed(this.GetWeaponAI().GetPrimaryTarget(), this.GetCurrentSpeed(), this.GetCurrentHeading());
					if (this.bPrimaryTargetAttackable || this.IsTargetAttackable(elapsedTime))
					{
						if (this.GetWeaponAI().GetPrimaryTarget().IsDestroyed(this.m_Scenario))
						{
							return;
						}
						if (this.IsTargetLost())
						{
							Contact_Base.ContactType contactType = this.GetWeaponAI().GetPrimaryTarget().contactType;
							if (contactType > Contact_Base.ContactType.Missile && contactType != Contact_Base.ContactType.Orbital)
							{
								this.SetCEP_Surface(200 * this.GetCEP_Surface());
								this.SetCEP_Land(200 * this.GetCEP_Land());
								string string_ = "武器: " + this.Name + "无法获得对目标的照射... 命中精度将严重缩减.";
								bool? hintIsOperating = null;
								double longitude = this.GetLongitude(hintIsOperating);
								hintIsOperating = null;
								base.LogMessage(string_, LoggedMessage.MessageType.WeaponEndgame, 5, false, new GeoPoint(longitude, this.GetLatitude(hintIsOperating)));
								return;
							}
							if (this.GetNoneMCMSensors().Length == 1)
							{
								string string_2 = "武器: " + this.Name + "无法获得对目标的照射...";
								bool? hintIsOperating = null;
								double longitude2 = this.GetLongitude(hintIsOperating);
								hintIsOperating = null;
								base.LogMessage(string_2, LoggedMessage.MessageType.WeaponEndgame, 5, false, new GeoPoint(longitude2, this.GetLatitude(hintIsOperating)));
								this.GetWeaponAI().SetPrimaryTarget(null);
								return;
							}
						}
						else
						{
							this.SetBlindTime(0f);
							this.GetWeaponAI().GetPrimaryTarget().Age = 0f;
						}
					}
					if (base.method_49(desiredSpeed, base.GetHorizontalRange(this.GetWeaponAI().GetPrimaryTarget())) <= (float)Math.Max(10, this.IlluminationTime))
					{
						if (this.GetWeaponAI().GetPrimaryTarget().IsDestroyed(this.m_Scenario))
						{
							return;
						}
						bool flag;
						if (flag = Information.IsNothing(this.GetDataLinkParent()))
						{
							if (flag)
							{
								ActiveUnit illuminatorOfTarget = this.GetIlluminatorOfTarget(this.GetSide(false), this.GetWeaponAI().GetPrimaryTarget());
								if (!Information.IsNothing(illuminatorOfTarget))
								{
									ActiveUnit_Sensory sensory = illuminatorOfTarget.GetSensory();
									Contact primaryTarget = this.GetWeaponAI().GetPrimaryTarget();
									bool? hintIsOperating = null;
									bool? flag2 = null;
									Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
									bool? flag3 = null;
									sensory.IsIlluminatingTarget(primaryTarget, this, ref hintIsOperating, ref flag2, ref lOS_Exists_Visual, ref flag3);
								}
							}
						}
						else if (!this.GetDataLinkParent().GetSensory().HasTrackingSensorForTarget(this.GetWeaponAI().GetPrimaryTarget()))
						{
							this.IsTargetLost();
						}
					}
					if (!this.method_226(90f) && this.GetGuidanceMethod() != Weapon._GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance)
					{
						this.method_225(60f, true, true, true, elapsedTime);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100946", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x002462A8 File Offset: 0x002444A8
		public void method_233(ref Weapon weapon_, ref Contact target_, Scenario scenario_)
		{
			WeaponSalvo[] weaponSalvos = weapon_.GetSide(false).WeaponSalvos;
			string text = "";
			checked
			{
				for (int i = 0; i < weaponSalvos.Length; i++)
				{
					WeaponSalvo weaponSalvo = weaponSalvos[i];
					if (weaponSalvo.Target == target_ && weaponSalvo.WeaponDBID == weapon_.DBID)
					{
						WeaponSalvo.Shooter[] shooters = weaponSalvo.m_Shooters;
						for (int j = 0; j < shooters.Length; j++)
						{
							WeaponSalvo.Shooter shooter = shooters[j];
							unchecked
							{
								if (!Information.IsNothing(weapon_.GetFiringParent()) && Operators.CompareString(shooter.ShooterObjectID, weapon_.GetFiringParent().GetGuid(), false) == 0)
								{
									shooter.QuantityAssigned++;
									shooter.QuantityFired++;
									ScenarioArrayUtil.AddStringToArray(ref weaponSalvo.WeaponObjectIDArray, weapon_.GetGuid());
									weaponSalvo.Quantity_Total++;
									return;
								}
							}
						}
						Side side;
						if (!Information.IsNothing(weapon_.GetFiringParent()))
						{
							side = weapon_.GetSide(false);
							int? nullable_ = new int?(1);
							int? nullable_2 = new int?(1);
							text = weapon_.GetFiringParent().GetGuid();
							side.SetWeaponSalvoParameter(ref weaponSalvo, nullable_, 1, nullable_2, false, ref text);
							goto IL_115;
						}
						side = weapon_.GetSide(false);
						int? nullable_3 = new int?(1);
						int? nullable_4 = new int?(1);
						text = "12456789";
						side.SetWeaponSalvoParameter(ref weaponSalvo, nullable_3, 1, nullable_4, false, ref text);
					}
					IL_115:;
				}
				int? num;
				if (!Information.IsNothing(weapon_.GetFiringParent()))
				{
					Side side = weapon_.GetSide(false);
					int? nullable_5 = new int?(1);
					int? nullable_6 = new int?(1);
					text = weapon_.GetFiringParent().GetGuid();
					num = new int?(1);
					ScenarioArrayUtil.AddStringToArray(ref side.WeaponSalvoAssigned(scenario_, ref weapon_, ref target_, nullable_5, 1, nullable_6, false, ref text, ref num, DateTime.MinValue).WeaponObjectIDArray, weapon_.GetGuid());
					return;
				}
				Side side2 = weapon_.GetSide(false);
				int? nullable_7 = new int?(1);
				int? nullable_8 = new int?(1);
				text = "123456789";
				num = new int?(1);
				ScenarioArrayUtil.AddStringToArray(ref side2.WeaponSalvoAssigned(scenario_, ref weapon_, ref target_, nullable_7, 1, nullable_8, false, ref text, ref num, DateTime.MinValue).WeaponObjectIDArray, weapon_.GetGuid());
			}
		}

		// Token: 0x060055ED RID: 21997 RVA: 0x002464E4 File Offset: 0x002446E4
		private void Redirect(float elapsedTime)
		{
			try
			{
				if (this.GetWeaponType() != Weapon._WeaponType.Sonobuoy)
				{
					if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
					{
						ActiveUnit_AI weaponAI = this.GetWeaponAI();
						ActiveUnit activeUnit = this;
						weaponAI.ClearPrimaryTarget(ref activeUnit);
						if (!this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
						{
							this.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.GetCurrentHeading());
						}
					}
					this.SetDRT(this.GetDRT() + elapsedTime);
					double num = Math.Round((double)this.GetDRT(), 1);
					checked
					{
						if (num == 0.1 || num == 1.0 || num == 6.0 || num == 11.0 || (num > 11.0 && this.GetWeaponAI().GetPrimaryTargetType() == Contact_Base.ContactType.ActivationPoint && num % 15.0 == 0.0))
						{
							List<Contact> list = new List<Contact>();
							List<Contact> list2 = new List<Contact>();
							if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTargetType()) && (this.GetWeaponAI().GetPrimaryTargetType() == Contact_Base.ContactType.Air || this.GetWeaponAI().GetPrimaryTargetType() == Contact_Base.ContactType.Missile || this.GetWeaponAI().GetPrimaryTargetType() == Contact_Base.ContactType.Submarine || this.GetWeaponAI().GetPrimaryTargetType() == Contact_Base.ContactType.Torpedo))
							{
								Side side = this.GetSide(false);
								string guid = base.GetGuid();
								side.RemoveWeaponSalvoByID(ref guid);
							}
							if (!Information.IsNothing(this.GetDataLinkParent()))
							{
								Contact[] targets = this.GetDataLinkParent().GetAI().GetTargets();
								for (int i = 0; i < targets.Length; i++)
								{
									Contact contact = targets[i];
									bool? flag;
									bool? flag2;
									if (contact.GetPostureStance(this.GetDataLinkParent().GetSide(false)) == Misc.PostureStance.Hostile)
									{
										flag = new bool?(false);
									}
									else
									{
										Doctrine._WeaponControlStatus? wCS_AirDoctrine = this.GetDataLinkParent().m_Doctrine.GetWCS_AirDoctrine(this.GetDataLinkParent().m_Scenario, false, null, false, false);
										byte? b = wCS_AirDoctrine.HasValue ? new byte?((byte)wCS_AirDoctrine.GetValueOrDefault()) : null;
										flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null);
										flag = (flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2);
									}
									bool? flag3;
									flag2 = (flag3 = flag);
									if (!((!flag2.HasValue || flag3.GetValueOrDefault()) ? (flag3 & !contact.IsSubSurface()) : new bool?(false)).GetValueOrDefault() && this.GetDataLinkParent().GetAI().method_63(contact) && (Math.Abs(contact.RelativeBearingTo(this, false)) <= 20f || contact.IsBallisticMissileOrReEntryVehicles() || contact.IsOrbital()))
									{
										float num2;
										if (contact.GetCurrentSpeed() == 0f)
										{
											num2 = this.GetCurrentSpeed();
										}
										else
										{
											num2 = base.GetDesiredSpeed(contact, this.GetCurrentSpeed(), this.GetCurrentHeading());
										}
										if (base.GetHorizontalRange(contact) / (num2 / 3600f) >= 3f)
										{
											try
											{
												if (Information.IsNothing(this.GetDataLinkParent()))
												{
													goto IL_3DA;
												}
												if (Operators.CompareString(this.GetDataLinkParent().GetWeaponry().method_26(this, contact), "OK", false) != 0)
												{
													goto IL_3DA;
												}
												goto IL_3E5;
											}
											catch (Exception ex)
											{
												ProjectData.SetProjectError(ex);
												Exception ex2 = ex;
												ex2.Data.Add("Error at 200048", ex2.Message);
												GameGeneral.LogException(ref ex2);
												if (Debugger.IsAttached)
												{
													Debugger.Break();
												}
												ProjectData.ClearProjectError();
												goto IL_3E5;
											}
											IL_3AE:
											if (contact.contactType == this.GetWeaponAI().GetPrimaryTargetType())
											{
												list.Add(contact);
												goto IL_3DA;
											}
											goto IL_3D1;
											IL_3E5:
											if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTargetType()))
											{
												goto IL_3AE;
											}
											IL_3D1:
											list2.Add(contact);
										}
									}
									IL_3DA:;
								}
								int count = list.Count;
								if (count != 0)
								{
									if (count == 1)
									{
										this.SetBlindTime(0f);
										this.SetDRT(0f);
										this.GetWeaponAI().SetPrimaryTarget(list[0]);
										Weapon weapon = this;
										Weapon_AI weaponAI2;
										Contact primaryTarget = (weaponAI2 = this.GetWeaponAI()).GetPrimaryTarget();
										this.method_233(ref weapon, ref primaryTarget, this.m_Scenario);
										weaponAI2.SetPrimaryTarget(primaryTarget);
										base.LogMessage("武器: " + this.Name + "仅有一个重定向的备选目标: " + this.GetWeaponAI().GetPrimaryTarget().Name, LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
									}
									else
									{
										this.SetBlindTime(0f);
										this.SetDRT(0f);
										IEnumerable<Contact> source = list.OrderBy(Weapon.ContactFunc10).ThenBy(new Func<Contact, double>(this.GetAngularDistance));
										this.GetWeaponAI().SetPrimaryTarget(source.ElementAtOrDefault(0));
										Weapon weapon = this;
										Weapon_AI weaponAI2;
										Contact primaryTarget = (weaponAI2 = this.GetWeaponAI()).GetPrimaryTarget();
										this.method_233(ref weapon, ref primaryTarget, this.m_Scenario);
										weaponAI2.SetPrimaryTarget(primaryTarget);
										base.LogMessage("武器: " + this.Name + "重定向攻击新目标: " + this.GetWeaponAI().GetPrimaryTarget().Name, LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
									}
								}
								else
								{
									int count2 = list2.Count;
									if (count2 != 0)
									{
										if (count2 != 1)
										{
											this.SetBlindTime(0f);
											this.SetDRT(0f);
											IEnumerable<Contact> source2 = list2.OrderBy(Weapon.ContactFunc11).ThenBy(new Func<Contact, double>(this.GetAngularDistance));
											this.GetWeaponAI().SetPrimaryTarget(source2.ElementAtOrDefault(0));
											Weapon weapon = this;
											Weapon_AI weaponAI2;
											Contact primaryTarget = (weaponAI2 = this.GetWeaponAI()).GetPrimaryTarget();
											this.method_233(ref weapon, ref primaryTarget, this.m_Scenario);
											weaponAI2.SetPrimaryTarget(primaryTarget);
											base.LogMessage("武器: " + this.Name + "重定向攻击新目标: " + this.GetWeaponAI().GetPrimaryTarget().Name, LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
										}
										else
										{
											this.SetBlindTime(0f);
											this.SetDRT(0f);
											this.GetWeaponAI().SetPrimaryTarget(list2[0]);
											Weapon weapon = this;
											Weapon_AI weaponAI2;
											Contact primaryTarget = (weaponAI2 = this.GetWeaponAI()).GetPrimaryTarget();
											this.method_233(ref weapon, ref primaryTarget, this.m_Scenario);
											weaponAI2.SetPrimaryTarget(primaryTarget);
											base.LogMessage("武器: " + this.Name + "仅有一个重定向的备选目标: " + this.GetWeaponAI().GetPrimaryTarget().Name, LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
										}
									}
									else if (this.GetWeaponAI().GetPrimaryTargetType() != Contact_Base.ContactType.Surface && this.GetWeaponAI().GetPrimaryTargetType() != Contact_Base.ContactType.Submarine && this.GetWeaponAI().GetPrimaryTargetType() != Contact_Base.ContactType.Facility_Fixed && this.GetWeaponAI().GetPrimaryTargetType() != Contact_Base.ContactType.Facility_Mobile)
									{
										if (this.GetDRT() >= 11f)
										{
											if (this.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
											{
												this.method_212(true, true, true);
												if (this.GetGuidanceMethod() != Weapon._GuidanceMethod.ActiveTerminalGuidance && this.GetGuidanceMethod() != Weapon._GuidanceMethod.PassiveTerminalGuidance && this.GetGuidanceMethod() != Weapon._GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance && this.GetGuidanceMethod() != Weapon._GuidanceMethod.TimeSharedSemiActiveMidCoursePlusActiveTerminalGuidance && this.GetNoneMCMSensors().Length <= 1)
												{
													base.LogMessage("武器: " + this.Name + "没有符合攻击条件的其它备选目标...", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
												}
												else
												{
													base.LogMessage("武器: " + this.Name + " 没有符合攻击条件的其它备选目标... 转入自动状态.", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
												}
											}
											else if (this.GetWeaponAI().GetPrimaryTargetType() != Contact_Base.ContactType.ActivationPoint)
											{
												this.method_212(true, true, true);
												return;
											}
										}
									}
									else
									{
										if (this.GetNoneMCMSensors().Length > 0 && this.weaponTarget.IsRadar && this.method_187())
										{
											this.method_212(true, true, true);
											return;
										}
										this.method_219(true);
									}
									if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) && this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
									{
										this.GetWeaponNavigator().method_57((float)this.GetWeaponKinematics().GetSpeed(this.GetCurrentAltitude_ASL(false), this.GetThrottle()), false);
										if (this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
										{
											this.SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.GetAzimuth(this.GetLatitude(null), this.GetLongitude(null), this.GetWeaponNavigator().GetPlottedCourse()[0].GetLatitude(), this.GetWeaponNavigator().GetPlottedCourse()[0].GetLongitude()));
										}
									}
								}
							}
							else
							{
								this.SetDRT(0f);
								this.method_212(true, true, false);
								if (this.GetGuidanceMethod() == Weapon._GuidanceMethod.const_7)
								{
									base.LogMessage("武器: " + this.Name + "没有合适的重定向备选目标... 将转入自主攻击模式.", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
								}
								else
								{
									base.LogMessage("武器: " + this.Name + "已丢失数据链连接...", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
									this.GetWeaponAI().SetPrimaryTarget(null);
								}
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100947", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060055EE RID: 21998 RVA: 0x00246F9C File Offset: 0x0024519C
		public void method_235(float elapsedTime)
		{
			try
			{
				ActiveUnit parentPlatform = this.GetDirector().GetParentPlatform();
				if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()))
				{
					ActiveUnit_AI weaponAI = this.GetWeaponAI();
					ActiveUnit activeUnit = this;
					weaponAI.ClearPrimaryTarget(ref activeUnit);
					if (!this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
					{
						this.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.GetCurrentHeading());
					}
				}
				this.SetDRT(this.GetDRT() + elapsedTime);
				double num = Math.Round((double)this.GetDRT(), 1);
				checked
				{
					if (num == 0.1 || num == 1.0 || num == 6.0 || num == 11.0)
					{
						Collection<Contact> collection = new Collection<Contact>();
						Contact[] targets = parentPlatform.GetAI().GetTargets();
						for (int i = 0; i < targets.Length; i++)
						{
							Contact contact = targets[i];
							float angleBetween = Class263.GetAngleBetween(this.GetCurrentHeading(), Math2.GetAzimuth(this.GetLatitude(null), this.GetLongitude(null), contact.GetLatitude(null), contact.GetLongitude(null)));
							if (340f <= angleBetween || angleBetween <= 20f)
							{
								collection.Add(contact);
							}
						}
						int count = collection.Count;
						if (count != 0)
						{
							if (count != 1)
							{
								this.SetDRT(0f);
								this.GetWeaponAI().SetPrimaryTarget(this.GetWeaponAI().method_41(collection));
								Weapon weapon = this;
								Weapon_AI weaponAI2;
								Contact primaryTarget = (weaponAI2 = this.GetWeaponAI()).GetPrimaryTarget();
								this.method_233(ref weapon, ref primaryTarget, this.m_Scenario);
								weaponAI2.SetPrimaryTarget(primaryTarget);
							}
							else
							{
								this.SetDRT(0f);
								this.GetWeaponAI().SetPrimaryTarget(collection[0]);
								Weapon weapon = this;
								Weapon_AI weaponAI2;
								Contact primaryTarget = (weaponAI2 = this.GetWeaponAI()).GetPrimaryTarget();
								this.method_233(ref weapon, ref primaryTarget, this.m_Scenario);
								weaponAI2.SetPrimaryTarget(primaryTarget);
							}
						}
						else if (this.GetDRT() >= 11f)
						{
							this.SetDRT(0f);
							this.GetWeaponAI().SetPrimaryTarget(null);
							base.LogMessage("Weapon: " + this.Name + " has no eligible alternative target to be redirected to...", LoggedMessage.MessageType.WeaponLogic, 10, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100948", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x00247278 File Offset: 0x00245478
		public bool IsSuitableForTarget(Scenario scenario_, ref Contact target_)
		{
			bool flag = false;
			bool flag2 = false;
			bool result;
			if (Information.IsNothing(target_))
			{
				flag2 = false;
			}
			else
			{
				try
				{
					if (target_.contactType == Contact_Base.ContactType.Aimpoint || target_.contactType == Contact_Base.ContactType.ActivationPoint)
					{
						Weapon._WeaponType weaponType = this.GetWeaponType();
						if (weaponType <= Weapon._WeaponType.TrainingRound)
						{
							if (weaponType - Weapon._WeaponType.Decoy_Expendable > 1 && weaponType != Weapon._WeaponType.TrainingRound)
							{
								goto IL_6D2;
							}
						}
						else if (weaponType - Weapon._WeaponType.SensorPod > 3 && weaponType != Weapon._WeaponType.HeliTowedPackage)
						{
							goto IL_6D2;
						}
						flag2 = false;
						goto IL_71C;
						IL_6D2:
						flag2 = true;
						result = true;
						return result;
					}
					Weapon._WeaponType weaponType2 = this.GetWeaponType();
					if (weaponType2 == Weapon._WeaponType.Decoy_Vehicle)
					{
						flag2 = false;
						result = false;
						return result;
					}
					if (target_.IsDestroyed(scenario_))
					{
						flag2 = false;
						result = false;
						return result;
					}
					if (!this.IsDecoy() || this.GetWeaponType() == Weapon._WeaponType.Decoy_Vehicle)
					{
						if (this.weaponTarget.IsRadar)
						{
							if (target_.HasEmissionContainer())
							{
								int num = 0;
								int[] array = target_.GetEmissionContainerObDictionary().Keys.ToArray<int>();
								for (int i = 0; i < array.Length; i = checked(i + 1))
								{
									int key = array[i];
									try
									{
										if (target_.GetEmissionContainerObDictionary()[key].elapsedTime < 30f)
										{
											num++;
										}
									}
									catch (Exception projectError)
									{
										ProjectData.SetProjectError(projectError);
										ProjectData.ClearProjectError();
									}
								}
								if (num > 0)
								{
									if (this.RangeAAWMax > 0f)
									{
										if (target_.contactType == Contact_Base.ContactType.Air)
										{
											flag2 = true;
											result = true;
											return result;
										}
									}
									else if (this.RangeASUWMax > 0f && (target_.contactType == Contact_Base.ContactType.Facility_Fixed || target_.contactType == Contact_Base.ContactType.Facility_Mobile || target_.contactType == Contact_Base.ContactType.Surface))
									{
										flag2 = true;
										result = true;
										return result;
									}
								}
							}
							else
							{
								if (Information.IsNothing(target_.ActualUnit))
								{
									flag2 = false;
									result = false;
									return result;
								}
								if (target_.GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownClass && target_.ActualUnit.GetAllNoneMCMSensors().Where(Weapon.IsOperationRadar).Count<Sensor>() > 0)
								{
									flag2 = true;
									result = true;
									return result;
								}
								flag2 = false;
								result = false;
								return result;
							}
						}
						Contact_Base.ContactType contactType = target_.contactType;
						switch (contactType)
						{
						case Contact_Base.ContactType.Air:
							if (target_.ActualUnit.IsAircraft)
							{
								if (((Aircraft)target_.ActualUnit).IsAirship())
								{
									if (this.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
									{
										flag = true;
									}
									if ((this.TargetIsLandFacility() || this.TargetIsShipOrRadar()) && this.GetWeaponType() == Weapon._WeaponType.GuidedWeapon)
									{
										flag = true;
									}
								}
								else if (this.weaponTarget.IsAircraft)
								{
									flag = true;
								}
							}
							else if (this.weaponTarget.IsAircraft)
							{
								flag = true;
							}
							break;
						case Contact_Base.ContactType.Missile:
							if (this.weaponTarget.IsGuidedWeapon)
							{
								flag = true;
							}
							if (((Weapon)target_.ActualUnit).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
							{
								if (!Information.IsNothing(((Weapon)target_.ActualUnit).GetWeaponAI().GetPrimaryTarget()) && !Information.IsNothing(((Weapon)target_.ActualUnit).GetWeaponAI().GetPrimaryTarget().ActualUnit))
								{
									if (!((Weapon)target_.ActualUnit).GetWeaponAI().GetPrimaryTarget().ActualUnit.IsShip && (!((Weapon)target_.ActualUnit).GetWeaponAI().GetPrimaryTarget().ActualUnit.IsSubmarine || !((Submarine)((Weapon)target_.ActualUnit).GetWeaponAI().GetPrimaryTarget().ActualUnit).IsShallowerThanPeriscopeDepth()))
									{
										flag = false;
									}
								}
								else
								{
									flag = false;
								}
							}
							break;
						case Contact_Base.ContactType.Surface:
						{
							if (this.weaponTarget.IsSurfaceShip)
							{
								flag = true;
							}
							ActiveUnit actualUnit = target_.ActualUnit;
							if (this.weaponTarget.IsSubsurface && actualUnit.IsSubmarine && actualUnit.GetCurrentAltitude_ASL(false) == 0f)
							{
								flag = true;
							}
							break;
						}
						case Contact_Base.ContactType.Submarine:
							if (this.weaponTarget.IsSubsurface)
							{
								flag = true;
							}
							if (target_.GetCurrentAltitude_ASL(false) == 0f && this.weaponTarget.IsSurfaceShip)
							{
								flag = true;
							}
							break;
						case Contact_Base.ContactType.UndeterminedNaval:
						case Contact_Base.ContactType.Mine:
						case Contact_Base.ContactType.Explosion:
						case Contact_Base.ContactType.Undetermined:
							break;
						case Contact_Base.ContactType.Aimpoint:
							flag2 = (result = (this.weaponTarget.IsHardLandStructures || this.weaponTarget.IsSoftLandStructures || this.weaponTarget.IsRunway));
							return result;
						case Contact_Base.ContactType.Orbital:
							flag2 = (result = this.weaponTarget.IsSatellite);
							return result;
						case Contact_Base.ContactType.Facility_Fixed:
						{
							Facility._FacilityCategory category = ((Facility)target_.ActualUnit).Category;
							flag2 = (result = ((category - Facility._FacilityCategory.Runway <= 2) ? this.weaponTarget.IsRunway : (category != Facility._FacilityCategory.AirBase && (this.weaponTarget.IsHardLandStructures || this.weaponTarget.IsSoftLandStructures))));
							return result;
						}
						case Contact_Base.ContactType.Facility_Mobile:
							flag2 = (result = (this.weaponTarget.IsHardMobileUnit || this.weaponTarget.IsSoftMobileUnit || ((this.weaponTarget.IsHardLandStructures || this.weaponTarget.IsSoftLandStructures) && target_.GetCurrentSpeed() == 0f)));
							return result;
						case Contact_Base.ContactType.Torpedo:
							flag2 = (result = this.weaponTarget.IsTorpedoe);
							return result;
						case Contact_Base.ContactType.Decoy_Air:
							if (this.weaponTarget.IsAircraft && target_.GetEmissionContainerObDictionary().Count > 0)
							{
								foreach (KeyValuePair<int, EmissionContainer> current in target_.GetEmissionContainerObDictionary())
								{
									if (current.Value.method_0(current.Key, scenario_).IsJammer())
									{
										flag = true;
									}
								}
							}
							break;
						default:
							if (contactType == Contact_Base.ContactType.ActivationPoint)
							{
								flag2 = (result = this.weaponTarget.IsSurfaceShip);
								return result;
							}
							break;
						}
						flag2 = (result = flag);
						return result;
					}
					Contact_Base.ContactType contactType2 = target_.contactType;
					if (contactType2 != Contact_Base.ContactType.Missile && contactType2 - Contact_Base.ContactType.Torpedo > 1)
					{
						flag2 = false;
						result = false;
						return result;
					}
					ActiveUnit actualUnit2 = target_.ActualUnit;
					if (Information.IsNothing(actualUnit2))
					{
						flag2 = false;
						result = false;
						return result;
					}
					checked
					{
						if (actualUnit2.IsWeapon)
						{
							Sensor[] noneMCMSensors = actualUnit2.GetNoneMCMSensors();
							for (int j = 0; j < noneMCMSensors.Length; j++)
							{
								Sensor targetSensor_ = noneMCMSensors[j];
								if (this.IsSuspectableTo(targetSensor_))
								{
									flag2 = true;
									result = true;
									return result;
								}
							}
						}
						flag2 = false;
						result = false;
						return result;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200276", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					flag2 = false;
					ProjectData.ClearProjectError();
				}
			}
			IL_71C:
			result = flag2;
			return result;
		}

		// Token: 0x060055F0 RID: 22000 RVA: 0x0002770A File Offset: 0x0002590A
		public bool CanReachTarget(float Distance, Contact Target)
		{
			return this.GetRangeMaxToTargetType(Target.contactType) >= Distance;
		}

		// Token: 0x060055F1 RID: 22001 RVA: 0x002479F0 File Offset: 0x00245BF0
		public bool method_238(Contact target_, bool bool_21)
		{
			bool flag = false;
			bool result;
			try
			{
				if (target_.ActualUnit.IsShip || target_.ActualUnit.IsSubmarine || target_.ActualUnit.IsFacility || target_.ActualUnit.IsTorpedo())
				{
					if (this.method_187())
					{
						Weapon._GuidanceMethod guidanceMethod = this.GetGuidanceMethod();
						if (guidanceMethod - Weapon._GuidanceMethod.const_1 <= 1)
						{
							flag = false;
							result = false;
							return result;
						}
						flag = true;
						result = true;
						return result;
					}
					else
					{
						if (this.weaponCode.BOLCapable)
						{
							flag = true;
							result = true;
							return result;
						}
						if (this.weaponTarget.IsRadar)
						{
							flag = true;
							result = true;
							return result;
						}
						if (this.weaponCode.IlluminateAtLaunch)
						{
							flag = true;
							result = true;
							return result;
						}
						Weapon._WeaponType weaponType = this.weaponType;
						if (weaponType - Weapon._WeaponType.Rocket <= 2)
						{
							switch (target_.contactType)
							{
							case Contact_Base.ContactType.Surface:
								flag = false;
								result = false;
								return result;
							case Contact_Base.ContactType.Submarine:
							case Contact_Base.ContactType.Aimpoint:
							case Contact_Base.ContactType.Facility_Fixed:
							case Contact_Base.ContactType.Facility_Mobile:
							case Contact_Base.ContactType.Torpedo:
								flag = true;
								result = true;
								return result;
							}
							flag = bool_21;
							result = bool_21;
							return result;
						}
						if (this.GetCommDevices().Count<CommDevice>() > 0 && this.GetNoneMCMSensors().Length > 0 && (target_.IsFacilityType() || target_.IsSurfaceOrLandTarget() || target_.IsSubSurface()))
						{
							flag = true;
							result = true;
							return result;
						}
						if (this.GetGuidanceMethod() == Weapon._GuidanceMethod.InertiallyGuided)
						{
							flag = true;
							result = true;
							return result;
						}
					}
				}
				flag = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100950", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x060055F2 RID: 22002 RVA: 0x00247BD0 File Offset: 0x00245DD0
		public bool TargetWithinRangeOfSuitableWeapon(float Distance, Contact Target)
		{
			bool result;
			switch (Target.contactType)
			{
			case Contact_Base.ContactType.Air:
			case Contact_Base.ContactType.Missile:
			case Contact_Base.ContactType.Orbital:
				result = (this.RangeAAWMin > Distance);
				return result;
			case Contact_Base.ContactType.Surface:
			case Contact_Base.ContactType.UndeterminedNaval:
				result = (this.RangeASUWMin > Distance);
				return result;
			case Contact_Base.ContactType.Submarine:
			case Contact_Base.ContactType.Mine:
				result = (this.RangeASWMin > Distance);
				return result;
			case Contact_Base.ContactType.Facility_Fixed:
			case Contact_Base.ContactType.Facility_Mobile:
				result = (this.RangeLandMin > Distance);
				return result;
			}
			result = false;
			return result;
		}

		// Token: 0x060055F3 RID: 22003 RVA: 0x00247C4C File Offset: 0x00245E4C
		public float GetDomainRangeMin(Contact contact_)
		{
			float num;
			float result;
			switch (contact_.contactType)
			{
			case Contact_Base.ContactType.Air:
			case Contact_Base.ContactType.Missile:
			case Contact_Base.ContactType.Orbital:
				num = this.RangeAAWMin;
				result = num;
				return result;
			case Contact_Base.ContactType.Surface:
			case Contact_Base.ContactType.UndeterminedNaval:
				num = this.RangeASUWMin;
				result = num;
				return result;
			case Contact_Base.ContactType.Submarine:
			case Contact_Base.ContactType.Mine:
				num = this.RangeASWMin;
				result = num;
				return result;
			case Contact_Base.ContactType.Facility_Fixed:
			case Contact_Base.ContactType.Facility_Mobile:
				num = this.RangeLandMin;
				result = num;
				return result;
			}
			num = 0f;
			result = num;
			return result;
		}

		// Token: 0x060055F4 RID: 22004 RVA: 0x00247CD0 File Offset: 0x00245ED0
		private bool IsTargetAttackable(Unit theTarget, float elapsedTime, bool CheckDistanceBasedOnClosureSpeed = false)
		{
			bool flag = false;
			bool result;
			try
			{
				if (this.GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.ActivationPoint && this.GetGuidanceMethod() != Weapon._GuidanceMethod.InertiallyGuided)
				{
					flag = false;
				}
				else
				{
					if (this.GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.Aimpoint)
					{
						if (this.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
						{
							flag = false;
							result = false;
							return result;
						}
						if ((this.TargetIsShipOrRadar() || this.TargetIsLandFacility()) && this.GetGuidanceMethod() != Weapon._GuidanceMethod.InertiallyGuided && this.GetWeaponAI().GetPrimaryTargetType() != Contact_Base.ContactType.Surface && this.GetWeaponAI().GetPrimaryTargetType() != Contact_Base.ContactType.Submarine && this.GetWeaponAI().GetPrimaryTargetType() != Contact_Base.ContactType.Facility_Fixed && this.GetWeaponAI().GetPrimaryTargetType() != Contact_Base.ContactType.Facility_Mobile)
						{
							flag = false;
							result = false;
							return result;
						}
					}
					if (base.GetHorizontalRange(theTarget) > 10f)
					{
						flag = false;
					}
					else
					{
						float num = 0f;
						if (this.IsTorpedo() || this.GetGuidanceMethod() != Weapon._GuidanceMethod.InertiallyGuided)
						{
							num = base.GetDesiredSpeed(theTarget, base.GetHorizontalSpeed(), this.GetCurrentHeading());
						}
						float num2 = num / 3600f;
						if (this.GetGuidanceMethod() == Weapon._GuidanceMethod.InertiallyGuided && !this.IsTorpedo())
						{
							if (!this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
							{
								flag = false;
								result = false;
								return result;
							}
							if (this.GetWeaponNavigator().HasPlottedCourse())
							{
								Waypoint waypoint = this.GetWeaponNavigator().GetPlottedCourse()[this.GetWeaponNavigator().GetPlottedCourse().Count<Waypoint>() - 1];
								float distance = Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), waypoint.GetLatitude(), waypoint.GetLongitude());
								float num3 = base.GetHorizontalSpeed() / 3600f;
								if (distance <= num3)
								{
									flag = true;
									result = true;
									return result;
								}
							}
						}
						else
						{
							if (this.IsTorpedo() && (theTarget.IsSubmarine || (theTarget.IsContact() && ((Contact)theTarget).IsSubSurface())) && Math.Abs(Math.Abs(this.GetCurrentAltitude_ASL(false)) - Math.Abs(theTarget.GetCurrentAltitude_ASL(false))) > 15f)
							{
								flag = false;
								result = false;
								return result;
							}
							float moveDistance = theTarget.GetMoveDistance(1f);
							double lon = 0.0;
							double lat = 0.0;
							GeoPointGenerator.GetOtherGeoPoint(theTarget.GetLongitude(null), theTarget.GetLatitude(null), ref lon, ref lat, (double)moveDistance, (double)theTarget.GetCurrentHeading());
							float distance2 = Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), lat, lon);
							float num4 = base.GetHorizontalSpeed() / 3600f;
							if (distance2 <= num4)
							{
								flag = true;
								result = true;
								return result;
							}
							float moveDistance2 = base.GetMoveDistance(1f);
							float azimuth = Math2.GetAzimuth(this.GetLatitude(null), this.GetLongitude(null), lat, lon);
							double lon2 = 0.0;
							double lat2 = 0.0;
							GeoPointGenerator.GetOtherGeoPoint(this.GetLongitude(null), this.GetLatitude(null), ref lon2, ref lat2, (double)moveDistance2, (double)azimuth);
							float distance3 = Math2.GetDistance(theTarget.GetLatitude(null), theTarget.GetLongitude(null), lat2, lon2);
							float num5 = Math.Abs(num2 - base.GetHorizontalSpeed() / 3600f);
							if (distance3 <= num5)
							{
								flag = true;
								result = true;
								return result;
							}
							if (CheckDistanceBasedOnClosureSpeed && distance2 <= num2)
							{
								flag = true;
								result = true;
								return result;
							}
						}
						flag = false;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100951", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x060055F5 RID: 22005 RVA: 0x002480E0 File Offset: 0x002462E0
		public bool IsTargetAttackable(float elapsedTime)
		{
			bool result = false;
			try
			{
				result = (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) && this.IsTargetAttackable(this.GetWeaponAI().GetPrimaryTarget(), elapsedTime, false));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100952", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060055F6 RID: 22006 RVA: 0x0024816C File Offset: 0x0024636C
		public virtual bool IsPrimaryTargetAttackable(float elapsedTime)
		{
			return !Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) && !Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit) && !this.GetWeaponAI().GetPrimaryTarget().IsDestroyed(this.m_Scenario) && this.IsTargetAttackable(this.GetWeaponAI().GetPrimaryTarget().ActualUnit, elapsedTime, true);
		}

		// Token: 0x060055F7 RID: 22007 RVA: 0x002481D8 File Offset: 0x002463D8
		private bool IsSuspectableTo(Sensor targetSensor_)
		{
			bool flag;
			bool result;
			if (targetSensor_.IsSonar())
			{
				flag = this.IsSonarDetectable();
			}
			else
			{
				Sensor.SensorType sensorType = targetSensor_.sensorType;
				switch (sensorType)
				{
				case Sensor.SensorType.Radar:
					result = this.IsRadarDetectable();
					return result;
				case Sensor.SensorType.SemiActive:
					if (!Information.IsNothing(targetSensor_.GetParentPlatform()) && !Information.IsNothing(((Weapon)targetSensor_.GetParentPlatform()).GetDirector()) && ((Weapon)targetSensor_.GetParentPlatform()).GetDirector().sensorType == Sensor.SensorType.Radar)
					{
						result = this.IsRadarDetectable();
						return result;
					}
					break;
				case Sensor.SensorType.Visual:
					result = this.IsVisualSensorDetectable();
					return result;
				case Sensor.SensorType.Infrared:
					result = this.IsInfraredSensorDetectable();
					return result;
				default:
					if (sensorType - Sensor.SensorType.LaserDesignator <= 2)
					{
						result = false;
						return result;
					}
					break;
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x060055F8 RID: 22008 RVA: 0x002482B0 File Offset: 0x002464B0
		private bool method_244(ref Weapon weapon_1, ref Sensor sensor_3, ref ActiveUnit activeUnit_3)
		{
			bool flag = false;
			bool result;
			try
			{
				bool? flag3;
				bool? flag2 = flag3 = sensor_3.IsSpoofed();
				bool? flag4;
				bool? flag6;
				if (flag2.HasValue && flag3.GetValueOrDefault())
				{
					flag4 = new bool?(true);
				}
				else
				{
					bool? flag5 = sensor_3.IsSpoofed();
					flag5 = (flag2 = (flag5.HasValue ? new bool?(!flag5.GetValueOrDefault()) : flag5));
					flag2 = (flag6 = ((!flag5.HasValue || flag2.GetValueOrDefault()) ? (flag2 & this.GetWeaponType() != Weapon._WeaponType.Decoy_Towed) : new bool?(false)));
					flag4 = (flag2.HasValue ? (flag3 | flag6.GetValueOrDefault()) : null);
				}
				flag6 = flag4;
				if (flag6.GetValueOrDefault())
				{
					flag = false;
				}
				else
				{
					StringBuilder stringBuilder = new StringBuilder();
					if (Information.IsNothing(sensor_3))
					{
						flag = false;
					}
					else
					{
						float maxPOKForAllDomains = this.GetMaxPOKForAllDomains();
						float num = 0f;
						if (this.IsRadarDetectable() && this.techGenerationClass == GlobalVariables.TechGenerationClass.NotApplicable)
						{
							GlobalVariables.TechGenerationClass techGenerationClass = sensor_3.techGenerationClass;
							if (techGenerationClass <= GlobalVariables.TechGenerationClass.Early1960s)
							{
								if (Information.IsNothing(weapon_1.GetWeaponAI().GetPrimaryTarget()))
								{
									flag = false;
									result = false;
									return result;
								}
								if (weapon_1.GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.Surface && !Information.IsNothing(weapon_1.GetWeaponAI().GetPrimaryTarget().ActualUnit))
								{
									switch (weapon_1.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetTargetVisualSizeClass())
									{
									case GlobalVariables.TargetVisualSizeClass.Stealthy:
									case GlobalVariables.TargetVisualSizeClass.VSmall:
										num = 100f;
										break;
									case GlobalVariables.TargetVisualSizeClass.Small:
										num = 98f;
										break;
									case GlobalVariables.TargetVisualSizeClass.Medium:
										num = 80f;
										break;
									case GlobalVariables.TargetVisualSizeClass.Large:
										num = 60f;
										break;
									case GlobalVariables.TargetVisualSizeClass.VLarge:
										num = 40f;
										break;
									}
								}
								else
								{
									num = 35f;
								}
							}
							else if (techGenerationClass <= GlobalVariables.TechGenerationClass.Late1960s)
							{
								if (weapon_1.GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.Surface && !Information.IsNothing(weapon_1.GetWeaponAI().GetPrimaryTarget().ActualUnit))
								{
									switch (weapon_1.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetTargetVisualSizeClass())
									{
									case GlobalVariables.TargetVisualSizeClass.Stealthy:
									case GlobalVariables.TargetVisualSizeClass.VSmall:
										num = 70f;
										break;
									case GlobalVariables.TargetVisualSizeClass.Small:
										num = 50f;
										break;
									case GlobalVariables.TargetVisualSizeClass.Medium:
										num = 40f;
										break;
									case GlobalVariables.TargetVisualSizeClass.Large:
										num = 30f;
										break;
									default:
										num = maxPOKForAllDomains;
										break;
									}
								}
								else
								{
									num = 35f;
								}
							}
							else if (techGenerationClass <= GlobalVariables.TechGenerationClass.Early1970s)
							{
								if (Information.IsNothing(weapon_1.GetWeaponAI().GetPrimaryTarget()))
								{
									flag = false;
									result = false;
									return result;
								}
								if (weapon_1.GetWeaponAI().GetPrimaryTarget().contactType == Contact_Base.ContactType.Surface && !Information.IsNothing(weapon_1.GetWeaponAI().GetPrimaryTarget().ActualUnit))
								{
									GlobalVariables.TargetVisualSizeClass targetVisualSizeClass = weapon_1.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetTargetVisualSizeClass();
									if (targetVisualSizeClass > GlobalVariables.TargetVisualSizeClass.VSmall)
									{
										if (targetVisualSizeClass != GlobalVariables.TargetVisualSizeClass.Small)
										{
											num = maxPOKForAllDomains;
										}
										else
										{
											num = 30f;
										}
									}
									else
									{
										num = 50f;
									}
								}
								else
								{
									num = 35f;
								}
							}
							else if (techGenerationClass <= GlobalVariables.TechGenerationClass.Late1970s)
							{
								num = maxPOKForAllDomains;
							}
							else if (techGenerationClass <= GlobalVariables.TechGenerationClass.Late1980s)
							{
								num = maxPOKForAllDomains;
							}
							else if (techGenerationClass <= GlobalVariables.TechGenerationClass.Late1990s)
							{
								num = maxPOKForAllDomains - 5f;
							}
							else
							{
								num = maxPOKForAllDomains - 10f;
							}
						}
						else if (this.techGenerationClass == GlobalVariables.TechGenerationClass.NotApplicable)
						{
							num = maxPOKForAllDomains;
						}
						else if (this.IsInfraredSensorDetectable())
						{
							int num2 = this.techGenerationClass - sensor_3.techGenerationClass;
							if (num2 < 0)
							{
								num = maxPOKForAllDomains - 10f;
							}
							else if (num2 == 0)
							{
								num = maxPOKForAllDomains;
							}
							else if (num2 > 0)
							{
								num = maxPOKForAllDomains + 5f;
							}
						}
						else
						{
							int num3 = this.techGenerationClass - sensor_3.techGenerationClass;
							if (num3 < -3)
							{
								num = maxPOKForAllDomains - 15f;
							}
							else if (num3 == -3)
							{
								num = maxPOKForAllDomains - 10f;
							}
							else if (num3 == -2)
							{
								num = maxPOKForAllDomains - 5f;
							}
							else if (num3 == -1)
							{
								num = maxPOKForAllDomains;
							}
							else if (num3 == 0)
							{
								num = maxPOKForAllDomains;
							}
							else if (num3 == 1)
							{
								num = maxPOKForAllDomains;
							}
							else if (num3 == 2)
							{
								num = maxPOKForAllDomains + 5f;
							}
							else if (num3 == 3)
							{
								num = maxPOKForAllDomains + 10f;
							}
							else if (num3 > 3)
							{
								num = maxPOKForAllDomains + 15f;
							}
						}
						if (num < 0f)
						{
							num = 0f;
						}
						stringBuilder.Append(string.Concat(new string[]
						{
							"诱饵 (",
							this.UnitClass,
							"; 技术水平: ",
							Misc.GetTechGenerationString(this.techGenerationClass),
							") 平台 ",
							activeUnit_3.Name,
							" 试图欺骗传感器: ",
							Misc.smethod_11(sensor_3.Name),
							" (技术水平: ",
							Misc.GetTechGenerationString(sensor_3.techGenerationClass),
							")(制导武器: ",
							weapon_1.Name,
							"). 最终概率: ",
							Conversions.ToString(Math.Round((double)num, 2)),
							"%. "
						}));
						if (weapon_1.weaponCode.Weapon_ImagingSeeker)
						{
							stringBuilder.Append("失败: 武器采用成像导引头.");
							weapon_1.m_Scenario.LogMessage(stringBuilder.ToString(), LoggedMessage.MessageType.WeaponEndgame, 10, base.GetGuid(), null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
							flag = false;
						}
						else
						{
							int num4 = GameGeneral.GetRandom().Next(1, 101);
							bool flag7 = false;
							if ((float)num4 <= num)
							{
								stringBuilder.Append("结果: " + Conversions.ToString(num4) + " - 成功");
								sensor_3.SetIsSpoofed(new bool?(true));
								flag7 = true;
							}
							else
							{
								stringBuilder.Append("结果: " + Conversions.ToString(num4) + " - 失败");
								sensor_3.SetIsSpoofed(new bool?(false));
							}
							weapon_1.m_Scenario.LogMessage(stringBuilder.ToString(), LoggedMessage.MessageType.WeaponEndgame, 10, base.GetGuid(), null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
							flag = flag7;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100953", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x060055F9 RID: 22009 RVA: 0x00248A2C File Offset: 0x00246C2C
		public bool method_245(ref Weapon weapon_1, ref ActiveUnit activeUnit_3)
		{
			bool result = false;
			checked
			{
				try
				{
					if (weapon_1.GetGuidanceMethod() == Weapon._GuidanceMethod.TrackViaMissile)
					{
						Sensor director = weapon_1.GetDirector();
						result = (!Information.IsNothing(director) && this.method_244(ref weapon_1, ref director, ref activeUnit_3));
					}
					else
					{
						Sensor[] noneMCMSensors = weapon_1.GetNoneMCMSensors();
						bool flag = false;
						for (int i = 0; i < noneMCMSensors.Length; i++)
						{
							Sensor sensor = noneMCMSensors[i];
							if (!Information.IsNothing(sensor) && this.IsSuspectableTo(sensor) && this.method_244(ref weapon_1, ref sensor, ref activeUnit_3))
							{
								flag = true;
							}
						}
						result = flag;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100954", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x060055FA RID: 22010 RVA: 0x00248B10 File Offset: 0x00246D10
		public bool WeaponEndGame(ActiveUnit Target_, ref Scenario scenario_, bool bool_21, ref Random random_1)
		{
			bool flag = false;
			bool result;
			if (Information.IsNothing(this))
			{
				flag = false;
			}
			else if (this.m_Scenario.GetUnitRemovals().Contains(this))
			{
				flag = false;
			}
			else
			{
				try
				{
					StringBuilder stringBuilder = new StringBuilder();
					bool flag2 = false;
					float num = 0f;
					if (Target_.IsAircraft)
					{
						if (((Aircraft)Target_).IsAirship())
						{
							if (!this.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
							{
								flag = (result = this.IsHit(Target_, ref scenario_, ref random_1));
								return result;
							}
							num = (float)this.AirPOK;
						}
						else
						{
							num = (float)this.AirPOK;
						}
					}
					else if (Target_.IsWeapon)
					{
						if (Target_.IsTorpedo())
						{
							num = (float)this.SubsurfacePOK;
						}
						else if (Target_.IsGuidedWeapon_RV_HGV())
						{
							num = (float)this.AirPOK;
						}
						else if (Target_.IsAirDecoy())
						{
							num = (float)this.AirPOK;
						}
						else if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
					else if (Target_.IsSatellite())
					{
						num = (float)this.AirPOK;
					}
					else if (Target_.IsShip)
					{
						if (!this.IsTorpedo())
						{
							flag = (result = this.IsHit(Target_, ref scenario_, ref random_1));
							return result;
						}
						num = (float)this.SurfacePOK;
					}
					else if (Target_.IsSubmarine)
					{
						num = (float)this.SubsurfacePOK;
						if (num == 0f && Target_.GetCurrentAltitude_ASL(false) == 0f)
						{
							num = (float)this.SurfacePOK;
						}
					}
					else if (Target_.IsFacility)
					{
						flag = (result = this.IsHit(Target_, ref scenario_, ref random_1));
						return result;
					}
					string text;
					if (string.IsNullOrEmpty(this.Name))
					{
						text = this.UnitClass;
					}
					else
					{
						text = this.Name;
					}
					if ((float)random_1.Next(1, 101) < num && this.HasNuclearWarhead())
					{
						this.Detonation(this.GetWeaponAI().GetPrimaryTarget().GetLatitude(null), this.GetWeaponAI().GetPrimaryTarget().GetLongitude(null), (float)(this.method_188(this.GetWeaponAI().GetPrimaryTarget().ActualUnit) + (int)((short)Math.Max(0, base.GetTerrainElevation(false, false, false)))), ref random_1);
						flag = false;
					}
					else
					{
						Weapon._WeaponType weaponType = this.weaponType;
						if (weaponType == Weapon._WeaponType.Gun)
						{
							stringBuilder.Append(string.Concat(new string[]
							{
								"火炮(",
								text,
								")正在攻击",
								Target_.Name,
								"，基准命中概率：",
								Conversions.ToString(Math.Round((double)num, 2)),
								"%. "
							}));
						}
						else
						{
							string text2;
							if (Target_.IsAircraft && Operators.CompareString(Target_.Name, Target_.UnitClass, false) != 0)
							{
								text2 = Target_.Name + " (" + Target_.UnitClass + ")";
							}
							else
							{
								text2 = Target_.Name;
							}
							stringBuilder.Append(string.Concat(new string[]
							{
								"武器: ",
								this.Name,
								"正在攻击目标",
								text2,
								"，基准命中概率：",
								Conversions.ToString(Math.Round((double)num, 2)),
								"%. "
							}));
						}
						float num8;
						if (Target_.IsAircraft)
						{
							if (Target_.isDestroyed | Target_.IsNotActive())
							{
								flag = true;
								result = true;
								return result;
							}
							if (base.IsGuidedWeapon_RV_HGV())
							{
								float num2 = base.HorizontalRangeTo(this.LaunchPoint) / this.RangeAAWMax;
								Engine._PropulsionType propulsionType = this.GetEngines()[0].PropulsionType;
								float num3;
								if (propulsionType != Engine._PropulsionType.Rocket && propulsionType != Engine._PropulsionType.WeaponCoast)
								{
									num3 = 0.75f;
								}
								else
								{
									num3 = 0.5f;
								}
								if (num2 > num3)
								{
									num = num * num3 + num * (1f - num3) * (1f - (num2 - num3) / (1f - num3));
									if (float.IsNaN(num))
									{
										num = 0f;
									}
									stringBuilder.Append("命中概率(经距离修正):  " + Conversions.ToString((int)Math.Round((double)num)) + "%. ");
								}
							}
							if (this.TargetSpeedMax > 0)
							{
								float num4 = 0f;
								if (Target_.GetCurrentSpeed() > (float)this.TargetSpeedMax)
								{
									num4 = 50f;
								}
								else if ((double)Target_.GetCurrentSpeed() > (double)this.TargetSpeedMax * 0.8)
								{
									num4 = 25f;
								}
								else if ((double)Target_.GetCurrentSpeed() > (double)this.TargetSpeedMax * 0.7)
								{
									num4 = 15f;
								}
								else if ((double)Target_.GetCurrentSpeed() > (double)this.TargetSpeedMax * 0.6)
								{
									num4 = 10f;
								}
								else if ((double)Target_.GetCurrentSpeed() > (double)this.TargetSpeedMax * 0.4)
								{
									num4 = 5f;
								}
								if (num4 != 0f)
								{
									num = (float)((int)Math.Round((double)(num - num4)));
									if (num < 0f)
									{
										num = 0f;
									}
								}
							}
							stringBuilder.Append("命中概率(经目标速度修正)(").Append((int)Math.Round((double)Target_.GetCurrentSpeed())).Append(" 节): ").Append(Math.Round((double)num, 1)).Append("%. ");
							if (((Aircraft)Target_).Crew > 0 && ((Aircraft)Target_).Agility > 0f)
							{
								if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit) && this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetSide(false).ActiveUnitIsContact(this))
								{
									stringBuilder.Append(Target_.Name).Append(" 目标基准机动系数: ").Append(((Aircraft)Target_).Agility).Append(", ");
									float num5 = (float)Math.Round((double)((Aircraft)Target_).GetAircraftKinematics().GetAgilityAtAltitude(), 1);
									stringBuilder.Append("高度修正: ").Append(num5).Append(". ");
									GlobalVariables.ProficiencyLevel? proficiencyLevel = Target_.GetProficiencyLevel();
									int? num6 = proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
									if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										num5 = (float)((double)num5 * 0.3);
									}
									else
									{
										num6 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
										if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											num5 = (float)((double)num5 * 0.5);
										}
										else
										{
											num6 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
											if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 2) : null).GetValueOrDefault())
											{
												num5 = (float)((double)num5 * 0.8);
											}
											else
											{
												num6 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
												if (!(num6.HasValue ? new bool?(num6.GetValueOrDefault() == 3) : null).GetValueOrDefault())
												{
													num6 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
													if ((num6.HasValue ? new bool?(num6.GetValueOrDefault() == 4) : null).GetValueOrDefault())
													{
														num5 = (float)((double)num5 * 1.2);
													}
												}
											}
										}
									}
									stringBuilder.Append("训练水平修正(").Append(Misc.GetProficiencyLevelString(Target_.GetProficiencyLevel().Value)).Append("): ").Append(num5).Append(". ");
									float weightFraction = ((Aircraft)Target_).GetWeightFraction();
									num5 = (float)(0.4 * (double)num5 + 0.6 * (double)num5 * (double)(1f - weightFraction));
									stringBuilder.Append(string.Concat(new string[]
									{
										"飞机重量分数为",
										Conversions.ToString(Math.Round((double)weightFraction, 2)),
										" - 机动系数修正为 ",
										Conversions.ToString(Math.Round((double)num5, 2)),
										". "
									}));
									if (((Aircraft)Target_).GetAircraftDamage().GetDamagePts() > 0f)
									{
										num5 = num5 * (100f - ((Aircraft)Target_).GetAircraftDamage().GetDamagePts()) / 100f;
										stringBuilder.Append(string.Concat(new string[]
										{
											"飞机遭受",
											Conversions.ToString(((Aircraft)Target_).GetAircraftDamage().GetDamagePts()),
											"% 机身/结构性毁伤 -机动系数修正为",
											Conversions.ToString(Math.Round((double)num5, 2)),
											". "
										}));
									}
									float num7 = base.RelativeBearingTo(Target_, false);
									if (num7 < 345f && num7 > 15f)
									{
										if ((num7 >= 15f && num7 <= 60f) || (num7 <= 345f && num7 >= 300f))
										{
											num5 = (float)((double)num5 * 0.7);
											stringBuilder.Append("机动系数(前向攻击效应修正): : " + Conversions.ToString(Math.Round((double)num5, 1)) + ". ");
										}
										else if ((num7 >= 60f && num7 <= 110f) || (num7 <= 300f && num7 >= 250f))
										{
											num5 = num5;
											stringBuilder.Append("机动系数(强转向攻击无影响). ");
										}
										else if ((num7 >= 110f && num7 <= 165f) || (num7 <= 250f && num7 >= 195f))
										{
											num5 = (float)((double)num5 * 0.85);
											stringBuilder.Append("机动系数(后向攻击效应修正):" + Conversions.ToString(Math.Round((double)num5, 1)) + ". ");
										}
										else
										{
											num5 = (float)((double)num5 * 0.5);
											stringBuilder.Append("机动系数(尾追攻击效应修正):" + Conversions.ToString(Math.Round((double)num5, 1)) + ". ");
										}
									}
									else
									{
										num5 = (float)((double)num5 * 0.6);
										stringBuilder.Append("机动系数(迎头攻击效应修正): " + Conversions.ToString(Math.Round((double)num5, 1)) + ". ");
									}
									num5 = (float)Math.Round((double)num5, 1);
									stringBuilder.Append("命中概率(机动系数修正量):-" + Conversions.ToString((int)Math.Round((double)(num5 * 10f))) + "%. ");
									num8 = num - num5 * 10f;
								}
								else
								{
									num8 = num;
								}
							}
							else
							{
								num8 = num;
							}
						}
						else
						{
							num8 = num;
						}
						if (Target_.GetCurrentAltitude_ASL(false) > 0f && (Target_.IsGuidedWeapon_RV_HGV() || Target_.IsAircraft) && !this.weaponCode.CapableVsSeaskimmer)
						{
							float seaSkimmerModifier = this.GetSeaSkimmerModifier(Target_.GetCurrentAltitude_ASL(false));
							if (seaSkimmerModifier > 0f)
							{
								num8 -= seaSkimmerModifier;
								stringBuilder.Append("命中概率(掠海攻击修正量):  -" + Conversions.ToString(seaSkimmerModifier) + "%. ");
							}
						}
						if (Target_.IsGuidedWeapon_RV_HGV())
						{
							float num9 = base.RelativeBearingTo(Target_, false);
							XSection crossSection = Sensor.GetCrossSection(Target_, XSection._SignatureType.Radar_E_M_Band);
							XSection crossSection2 = Sensor.GetCrossSection(Target_, XSection._SignatureType.InfraredDetectionRange);
							float targetRadarXSection_ = 0f;
							float targetIRXSection_ = 0f;
							if (num9 < 315f && num9 > 45f)
							{
								if ((num9 >= 45f && num9 <= 135f) || (num9 >= 225f && num9 <= 315f))
								{
									targetRadarXSection_ = crossSection.GetSideXSection(Target_);
									targetIRXSection_ = crossSection2.GetSideXSection(Target_);
								}
								else if (num9 >= 135f && num9 <= 225f)
								{
									targetRadarXSection_ = crossSection.GetRearXSection(Target_);
									targetIRXSection_ = crossSection2.GetRearXSection(Target_);
								}
							}
							else
							{
								targetRadarXSection_ = crossSection.GetFrontXSection(Target_);
								targetIRXSection_ = crossSection2.GetFrontXSection(Target_);
							}
							num8 = this.GetPHitModifiedBySpeedAndSignature((int)Math.Round((double)num8), Target_.GetCurrentSpeed(), targetRadarXSection_, targetIRXSection_, stringBuilder);
							if (bool_21 || base.HorizontalRangeTo(this.LaunchPoint) <= 2f)
							{
								Weapon weapon = (Weapon)Target_;
								if (weapon.weaponCode.TerminalManeuver_Popup)
								{
									stringBuilder.Append("目标导弹采用跃升俯冲末端机动 - 命中概率缩减25%.  ");
									num8 = (float)((double)num8 * 0.75);
								}
								else if (weapon.weaponCode.TerminalManeuver_Zigzag)
								{
									stringBuilder.Append("目标导弹采用蛇形末端机动 - 命中概率缩减33%. ");
									num8 = (float)((double)num8 * 0.66);
								}
								else if (weapon.weaponCode.TerminalManeuver_Random)
								{
									stringBuilder.Append("目标导弹采用随机末端机动 - 命中概率缩减50%.");
									num8 = (float)((double)num8 * 0.5);
								}
							}
						}
						if (Target_.IsTorpedo())
						{
							stringBuilder.Append("目标为鱼雷 - 命中概率减半. ");
							num8 = (float)((double)num8 * 0.5);
						}
						if (num8 < 0f)
						{
							num8 = 0f;
						}
						stringBuilder.Append("最终命中概率: " + Conversions.ToString((int)Math.Round((double)num8)) + "%. ");
						int num10 = random_1.Next(1, 101);
						if ((float)num10 <= num8)
						{
							stringBuilder.Append("结果: " + Conversions.ToString(num10) + " - 命中");
							flag2 = true;
						}
						else
						{
							stringBuilder.Append("结果: " + Conversions.ToString(num10) + " - 脱靶");
							if (this.m_Warheads.Length > 0 && Target_.IsFacility && this.m_Warheads[0].method_13())
							{
								float num11 = (float)random_1.Next(0, 359);
								float num12 = (float)random_1.Next(1, 50);
								stringBuilder.Append(" (脱靶量: " + Conversions.ToString(num12) + "米)");
								ActiveUnit_Damage damage = Target_.GetDamage();
								GeoPoint launchPoint = this.LaunchPoint;
								float missDistance_ = num12;
								float missAzimuth_ = num11;
								ActiveUnit activeUnit_ = null;
								double? nullable_ = null;
								double? nullable_2 = null;
								float? nullable_3 = null;
								string text3 = "";
								damage.vmethod_11(this, launchPoint, missDistance_, missAzimuth_, activeUnit_, nullable_, nullable_2, nullable_3, ref text3);
							}
						}
						Target_.m_Scenario.LogMessage(stringBuilder.ToString(), LoggedMessage.MessageType.WeaponEndgame, 10, base.GetGuid(), null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						if (flag2)
						{
							this.CalculateDamageEffect(Target_, stringBuilder);
							flag = true;
						}
						else
						{
							this.ExportWeaponEndgame(Target_, false, false, stringBuilder);
							flag = false;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100955", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					flag = false;
					ProjectData.ClearProjectError();
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x00249B2C File Offset: 0x00247D2C
		private void ExportWeaponEndgame(ActiveUnit activeUnit_, bool bHit, bool bKill, StringBuilder strEndgameMessage)
		{
			try
			{
				foreach (IEventExporter current in this.m_Scenario.GetEventExporters())
				{
					if (current.IsExportWeaponEndgame())
					{
						Dictionary<string, Tuple<Type, string>> dictionary = new Dictionary<string, Tuple<Type, string>>();
						dictionary.Add("TimelineID", new Tuple<Type, string>(typeof(string), this.m_Scenario.TimelineID));
						if (current.IsUseZeroHour())
						{
							TimeSpan timeSpan = this.m_Scenario.GetCurrentTime(false).Subtract(this.m_Scenario.ZeroHour);
							dictionary.Add("Time", new Tuple<Type, string>(typeof(TimeSpan), timeSpan.ToString("c")));
						}
						else
						{
							dictionary.Add("Time", new Tuple<Type, string>(typeof(DateTime), this.m_Scenario.GetCurrentTime(false).ToString("MM/dd/yyyy HH:mm:ss") + "." + this.m_Scenario.GetCurrentTime(false).Millisecond.ToString("D3")));
						}
						dictionary.Add("WeaponID", new Tuple<Type, string>(typeof(string), base.GetGuid()));
						dictionary.Add("WeaponName", new Tuple<Type, string>(typeof(string), this.Name));
						dictionary.Add("WeaponSide", new Tuple<Type, string>(typeof(string), this.GetSide(false).GetSideName()));
						if (!Information.IsNothing(this.GetFiringParent()))
						{
							dictionary.Add("ParentFiringUnitID", new Tuple<Type, string>(typeof(string), this.GetFiringParent().GetGuid()));
							dictionary.Add("ParentFiringUnitName", new Tuple<Type, string>(typeof(string), this.GetFiringParent().Name));
						}
						else
						{
							dictionary.Add("ParentFiringUnitID", new Tuple<Type, string>(typeof(string), "-"));
							dictionary.Add("ParentFiringUnitName", new Tuple<Type, string>(typeof(string), "-"));
						}
						dictionary.Add("TargetID", new Tuple<Type, string>(typeof(string), activeUnit_.GetGuid()));
						dictionary.Add("TargetName", new Tuple<Type, string>(typeof(string), activeUnit_.Name));
						dictionary.Add("TargetSide", new Tuple<Type, string>(typeof(string), activeUnit_.GetSide(false).GetSideName()));
						dictionary.Add("TargetLongitude", new Tuple<Type, string>(typeof(double), Conversions.ToString(activeUnit_.GetLongitude(null))));
						dictionary.Add("TargetLatitude", new Tuple<Type, string>(typeof(double), Conversions.ToString(activeUnit_.GetLatitude(null))));
						dictionary.Add("TargetAltitude_ASL_m", new Tuple<Type, string>(typeof(float), Conversions.ToString(activeUnit_.GetCurrentAltitude_ASL(false))));
						dictionary.Add("TargetAltitude_AGL_m", new Tuple<Type, string>(typeof(float), Conversions.ToString(activeUnit_.GetAltitude_AGL())));
						dictionary.Add("DistanceFromFiringUnit_Horiz", new Tuple<Type, string>(typeof(float), Conversions.ToString(Interaction.IIf(!Information.IsNothing(this.GetFiringParent()), base.GetHorizontalRange(this.GetFiringParent()), "UNKNOWN"))));
						if (bHit)
						{
							if (bKill)
							{
								dictionary.Add("Result", new Tuple<Type, string>(typeof(string), "KILL"));
							}
							else
							{
								dictionary.Add("Result", new Tuple<Type, string>(typeof(string), "HIT"));
							}
						}
						else
						{
							dictionary.Add("Result", new Tuple<Type, string>(typeof(string), "MISS"));
						}
						if (Information.IsNothing(strEndgameMessage))
						{
							dictionary.Add("EndgameMessage", new Tuple<Type, string>(typeof(string), "-"));
						}
						else
						{
							dictionary.Add("EndgameMessage", new Tuple<Type, string>(typeof(string), strEndgameMessage.ToString()));
						}
						current.ExportEvent(ExportedEventType.WeaponEndgame, dictionary, activeUnit_.m_Scenario);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101329", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060055FC RID: 22012 RVA: 0x00249FF4 File Offset: 0x002481F4
		public bool HasEmissionLockAndAlternativeSensor()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					if (!this.weaponTarget.IsRadar)
					{
						flag = false;
					}
					else if (this.GetNoneMCMSensors().Length < 2)
					{
						flag = false;
					}
					else
					{
						Sensor[] noneMCMSensors = this.GetNoneMCMSensors();
						for (int i = 0; i < noneMCMSensors.Length; i++)
						{
							if (noneMCMSensors[i].sensorType != Sensor.SensorType.ESM)
							{
								flag = true;
								result = true;
								return result;
							}
						}
						flag = false;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100956", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					flag = false;
					ProjectData.ClearProjectError();
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x060055FD RID: 22013 RVA: 0x0024A0B0 File Offset: 0x002482B0
		public static bool IsHit(ActiveUnit TargetUnit_, float MissDistance_, GeoPoint LaunchPoint_, float LargestRangeMaxOfAllDomains_, bool bool_21)
		{
			bool flag = false;
			bool result;
			try
			{
				float num = (float)(3.14159265358979 * Math.Pow((double)MissDistance_, 2.0));
				float num2 = 0f;
				if (TargetUnit_.IsShip)
				{
					if (((Ship)TargetUnit_).Length / 2f < MissDistance_)
					{
						flag = false;
						result = false;
						return result;
					}
					if (((Ship)TargetUnit_).Length / 2f > MissDistance_ && ((Ship)TargetUnit_).Beam / 2f > MissDistance_)
					{
						flag = true;
						result = true;
						return result;
					}
					num2 = MissDistance_ * ((Ship)TargetUnit_).Beam;
				}
				else if (TargetUnit_.IsSubmarine)
				{
					if (((Submarine)TargetUnit_).Length / 2f < MissDistance_)
					{
						flag = false;
						result = false;
						return result;
					}
					if (((Submarine)TargetUnit_).Length / 2f > MissDistance_ && ((Submarine)TargetUnit_).Beam / 2f > MissDistance_)
					{
						flag = true;
						result = true;
						return result;
					}
					num2 = MissDistance_ * ((Submarine)TargetUnit_).Beam;
				}
				else if (TargetUnit_.IsFacility)
				{
					if (((Facility)TargetUnit_).MountsAreAimpoints)
					{
						flag = (result = ((int)Math.Round((double)MissDistance_) <= 4));
						return result;
					}
					if (Math.Max(((Facility)TargetUnit_).Length, ((Facility)TargetUnit_).Width) / 2f < MissDistance_)
					{
						flag = false;
						result = false;
						return result;
					}
					if (((Facility)TargetUnit_).Length / 2f > MissDistance_ && ((Facility)TargetUnit_).Width / 2f > MissDistance_)
					{
						flag = true;
						result = true;
						return result;
					}
					num2 = (float)((Facility)TargetUnit_).Area;
				}
				else if (TargetUnit_.IsAircraft && ((Aircraft)TargetUnit_).IsAirship())
				{
					if (((Aircraft)TargetUnit_).Length / 2f < MissDistance_)
					{
						flag = false;
						result = false;
						return result;
					}
					if (((Aircraft)TargetUnit_).Length / 2f > MissDistance_ && ((Aircraft)TargetUnit_).Span / 2f > MissDistance_)
					{
						flag = true;
						result = true;
						return result;
					}
					num2 = MissDistance_ * ((Aircraft)TargetUnit_).Span;
				}
				float num3 = num2 / num * 100f;
				if (bool_21 && !Information.IsNothing(LaunchPoint_))
				{
					float num4 = TargetUnit_.HorizontalRangeTo(LaunchPoint_) / LargestRangeMaxOfAllDomains_;
					if (num4 <= 0.75f)
					{
						if (num4 > 0.5f)
						{
							num3 = (float)((int)Math.Round((double)num3 * 1.2));
						}
						else if (num4 > 0.25f)
						{
							num3 = (float)((int)Math.Round((double)num3 * 1.5));
						}
						else
						{
							num3 = (float)((int)Math.Round((double)(num3 * 2f)));
						}
					}
				}
				flag = ((double)GameGeneral.GetRandom().Next(1, 101) < (double)num3);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100957", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x0024A418 File Offset: 0x00248618
		public static void smethod_14(Scenario scenario_1, Weapon weapon_1, Unit unit_0, bool bool_21)
		{
			Weapon.Delegate25 @delegate = Weapon.delegate25_0;
			if (@delegate != null)
			{
				@delegate(scenario_1, weapon_1, unit_0, bool_21);
			}
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x0024A43C File Offset: 0x0024863C
		public float GetBasePOKForTargetUnit(ref ActiveUnit TargetUnit_)
		{
			float result;
			if (Information.IsNothing(TargetUnit_))
			{
				result = 0f;
			}
			else if (!TargetUnit_.IsShip && (!TargetUnit_.IsAircraft || !((Aircraft)TargetUnit_).IsAirship()) && (!TargetUnit_.IsSubmarine || !((Submarine)TargetUnit_).IsShallowerThanPeriscopeDepth()))
			{
				if (TargetUnit_.IsFacility)
				{
					result = (float)this.LandPOK;
				}
				else if (!TargetUnit_.IsSubmarine && !TargetUnit_.IsTorpedo())
				{
					result = 0f;
				}
				else
				{
					result = (float)this.SubsurfacePOK;
				}
			}
			else
			{
				result = (float)this.SurfacePOK;
			}
			return result;
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x0024A4EC File Offset: 0x002486EC
		public float GetMaxPOKForAllDomains()
		{
			return (float)Math.Max(this.AirPOK, Math.Max(this.SurfacePOK, Math.Max(this.LandPOK, this.SubsurfacePOK)));
		}

		// Token: 0x06005601 RID: 22017 RVA: 0x0024A524 File Offset: 0x00248724
		private bool IsHit(ActiveUnit TargetUnit_, ref Scenario scenario_, ref Random random_)
		{
			bool result = false;
			try
			{
				scenario_.RemoveUnit(this);
				float basePOKForTargetUnit = this.GetBasePOKForTargetUnit(ref TargetUnit_);
				bool flag = (float)random_.Next(1, 101) < basePOKForTargetUnit;
				float num = 0f;
				float azimuth = 0f;
				if (!this.IsTargetHit(TargetUnit_, ref scenario_, ref num, ref azimuth, ref random_))
				{
					result = false;
				}
				else
				{
					double num2 = 0.0;
					double num3 = 0.0;
					double lat = 0.0;
					double lon = 0.0;
					if (this.GetGuidanceMethod() == Weapon._GuidanceMethod.InertiallyGuided)
					{
						if (this.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
						{
							num2 = this.GetWeaponNavigator().GetPlottedCourse()[this.GetWeaponNavigator().GetPlottedCourse().Count<Waypoint>() - 1].GetLatitude();
							num3 = this.GetWeaponNavigator().GetPlottedCourse()[this.GetWeaponNavigator().GetPlottedCourse().Count<Waypoint>() - 1].GetLongitude();
							lat = num2;
							lon = num3;
						}
					}
					else if (TargetUnit_.MountsAreAimpoints())
					{
						checked
						{
							Mount mount2;
							if (!Information.IsNothing(this.ARM_SpecifiedEmission.Value))
							{
								List<Mount> list = new List<Mount>();
								List<Mount> list2 = new List<Mount>();
								Mount[] mounts = TargetUnit_.m_Mounts;
								for (int i = 0; i < mounts.Length; i++)
								{
									Mount mount = mounts[i];
									Sensor[] sensors = mount.GetSensors();
									for (int j = 0; j < sensors.Length; j++)
									{
										Sensor sensor = sensors[j];
										if (sensor.DBID == this.ARM_SpecifiedEmission.Key || (int)sensor.MasqueradeAs == this.ARM_SpecifiedEmission.Key)
										{
											list.Add(mount);
											if (sensor.IsEmmitting())
											{
												list2.Add(mount);
											}
										}
									}
								}
								if (list2.Count > 0)
								{
									mount2 = list2[random_.Next(0, list2.Count)];
								}
								else if (list.Count > 0)
								{
									mount2 = list[random_.Next(0, list.Count)];
								}
								else
								{
									mount2 = ((Facility)TargetUnit_).method_138();
								}
							}
							else
							{
								mount2 = ((Facility)TargetUnit_).method_138();
							}
							if (!Information.IsNothing(mount2))
							{
								Math2.GetAnotherGeopoint(TargetUnit_.GetLongitude(null), TargetUnit_.GetLatitude(null), ref num3, ref num2, mount2.GetAimpointOffset_Distance() / 1852f, (float)mount2.GetAimpointOffset_Bearing());
								lat = num2;
								lon = num3;
							}
							else if (this.GetWeaponAI().GetPrimaryTarget().Age == 0f && !Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit))
							{
								num2 = this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetLatitude(null);
								num3 = this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetLongitude(null);
							}
							else
							{
								num2 = this.GetWeaponAI().GetPrimaryTarget().GetLatitude(null);
								num3 = this.GetWeaponAI().GetPrimaryTarget().GetLongitude(null);
							}
						}
					}
					else if (this.GetWeaponAI().GetPrimaryTarget().Age == 0f && !Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit))
					{
						num2 = this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetLatitude(null);
						num3 = this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetLongitude(null);
					}
					else
					{
						num2 = this.GetWeaponAI().GetPrimaryTarget().GetLatitude(null);
						num3 = this.GetWeaponAI().GetPrimaryTarget().GetLongitude(null);
					}
					double num4 = 0.0;
					double num5 = 0.0;
					Math2.GetAnotherGeopoint(num3, num2, ref num4, ref num5, num / 1852f, azimuth);
					float num6;
					if (TargetUnit_.MountsAreAimpoints())
					{
						num6 = Math2.GetDistance(num5, num4, lat, lon) * 1852f;
					}
					else
					{
						num6 = Math2.GetDistance(num5, num4, TargetUnit_.GetLatitude(null), TargetUnit_.GetLongitude(null)) * 1852f;
					}
					float azimuth2 = Math2.GetAzimuth(TargetUnit_.GetLatitude(null), TargetUnit_.GetLongitude(null), num5, num4);
					bool flag2;
					if (flag2 = Weapon.IsHit(TargetUnit_, num6, this.LaunchPoint, this.GetLargestRangeMaxOfAllDomains(), false))
					{
						Weapon.Delegate25 @delegate = Weapon.delegate25_0;
						if (@delegate != null)
						{
							@delegate(this.m_Scenario, this, TargetUnit_, false);
						}
					}
					if (this.m_Warheads.Length > 0 && this.m_Warheads[0].method_15())
					{
						if (flag)
						{
							new Explosion(ref scenario_, num4, num5, num4, num5, this.GetCurrentHeading(), this.GetCurrentAltitude_ASL(false), this.m_Warheads[0].DP, this.m_Warheads[0].DP, this.m_Warheads[0].warheadType, this.m_Warheads[0].ExplosivesType, null, null, null, null, null, this.m_Warheads[0].ClusterBombDispersionAreaLength, this.m_Warheads[0].ClusterBombDispersionAreaWidth, (int)this.m_Warheads[0].NumberOfWarheads, 0f, 0).SetCurrentHeading(this.GetCurrentHeading());
						}
						else
						{
							scenario_.LogMessage("武器: " + this.Name + "发生故障.", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(num4, num5));
						}
						result = false;
					}
					else
					{
						if (this.m_Warheads[0].method_13())
						{
							if (!flag)
							{
								scenario_.LogMessage("武器: " + this.Name + "发生故障.", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(num4, num5));
							}
							else if (flag2)
							{
								if (this.m_Warheads[0].method_18(this, TargetUnit_))
								{
									if (base.IsGuidedWeapon_RV_HGV() && this.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() && (TargetUnit_.IsShip || TargetUnit_.IsFacility))
									{
										if (TargetUnit_.GetTargetVisualSizeClass() > GlobalVariables.TargetVisualSizeClass.VSmall)
										{
											this.CalculateDamageEffect(TargetUnit_, null);
										}
										else
										{
											scenario_.LogMessage("Weapon: " + this.Name + " airbursted directly on top of " + TargetUnit_.Name, LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
											float num7 = (float)Math.Max(0, (int)Terrain.GetElevation(num5, num4, false) + this.method_188(TargetUnit_));
											ActiveUnit_Damage damage = TargetUnit_.GetDamage();
											GeoPoint launchPoint = this.LaunchPoint;
											float missDistance_ = num6;
											float missAzimuth_ = azimuth2;
											ActiveUnit activeUnit_ = null;
											double? nullable_ = null;
											double? nullable_2 = null;
											float? nullable_3 = null;
											string text = "";
											damage.vmethod_11(this, launchPoint, missDistance_, missAzimuth_, activeUnit_, nullable_, nullable_2, nullable_3, ref text);
										}
									}
									else
									{
										scenario_.LogMessage("Weapon: " + this.Name + " airbursted directly on top of " + TargetUnit_.Name, LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
										float num7 = (float)Math.Max(0, (int)Terrain.GetElevation(num5, num4, false) + this.method_188(TargetUnit_));
										ActiveUnit_Damage damage2 = TargetUnit_.GetDamage();
										GeoPoint launchPoint2 = this.LaunchPoint;
										float missDistance_2 = num6;
										float missAzimuth_2 = azimuth2;
										ActiveUnit activeUnit_2 = null;
										double? nullable_4 = null;
										double? nullable_5 = null;
										float? nullable_6 = null;
										string text = "";
										damage2.vmethod_11(this, launchPoint2, missDistance_2, missAzimuth_2, activeUnit_2, nullable_4, nullable_5, nullable_6, ref text);
									}
								}
								else
								{
									this.CalculateDamageEffect(TargetUnit_, null);
								}
							}
							else
							{
								if (!TargetUnit_.MountsAreAimpoints())
								{
									if (this.m_Warheads[0].method_18(this, TargetUnit_))
									{
										if (SimConfiguration.gameOptions.UseImperialUnit())
										{
											scenario_.LogMessage(string.Concat(new string[]
											{
												"Weapon: ",
												this.Name,
												" airbursted off ",
												TargetUnit_.Name,
												" by ",
												Conversions.ToString(Math.Max(1, (int)Math.Round((double)(num6 * 3.28084f)))),
												"ft"
											}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
										}
										else
										{
											scenario_.LogMessage(string.Concat(new string[]
											{
												"Weapon: ",
												this.Name,
												" airbursted off ",
												TargetUnit_.Name,
												" by ",
												Conversions.ToString(Math.Max(1, (int)Math.Round((double)num6))),
												"m"
											}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
										}
									}
									else if (num6 < 926f)
									{
										if (SimConfiguration.gameOptions.UseImperialUnit())
										{
											scenario_.LogMessage(string.Concat(new string[]
											{
												"Weapon: ",
												this.Name,
												" missed ",
												TargetUnit_.Name,
												" by ",
												Conversions.ToString(Math.Max(1, (int)Math.Round((double)(num6 * 3.28084f)))),
												"ft"
											}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
										}
										else
										{
											scenario_.LogMessage(string.Concat(new string[]
											{
												"Weapon: ",
												this.Name,
												" missed ",
												TargetUnit_.Name,
												" by ",
												Conversions.ToString(Math.Max(1, (int)Math.Round((double)num6))),
												"m"
											}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
										}
									}
									else
									{
										scenario_.LogMessage(string.Concat(new string[]
										{
											"Weapon: ",
											this.Name,
											" missed ",
											TargetUnit_.Name,
											" by ",
											Conversions.ToString(Math.Round((double)(num6 / 1852f), 1)),
											"nm"
										}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
									}
								}
								float num7;
								if (this.IsTorpedo())
								{
									num7 = this.GetCurrentAltitude_ASL(false);
								}
								else
								{
									num7 = (float)Math.Max(0, (int)Terrain.GetElevation(num5, num4, false) + this.method_188(TargetUnit_));
								}
								if (num7 >= 0f || this.m_Warheads[0].HasNuclearWarhead(this.m_Scenario) || this.IsTorpedo() || this.m_Warheads[0].method_18(this, TargetUnit_))
								{
									ActiveUnit_Damage damage3 = TargetUnit_.GetDamage();
									GeoPoint launchPoint3 = this.LaunchPoint;
									float num8 = 0f;
									float missDistance_3 = num6 - num8;
									float missAzimuth_3 = azimuth2;
									ActiveUnit activeUnit_3 = null;
									double? nullable_7 = null;
									double? nullable_8 = null;
									float? nullable_9 = null;
									string text = "";
									damage3.vmethod_11(this, launchPoint3, missDistance_3, missAzimuth_3, activeUnit_3, nullable_7, nullable_8, nullable_9, ref text);
								}
							}
						}
						else if (flag2)
						{
							this.CalculateDamageEffect(TargetUnit_, null);
						}
						else if (this.m_Warheads[0].method_18(this, TargetUnit_))
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								scenario_.LogMessage(string.Concat(new string[]
								{
									"Weapon: ",
									this.Name,
									" airbursted off ",
									TargetUnit_.Name,
									" by ",
									Conversions.ToString(Math.Max(1, (int)Math.Round((double)(num6 * 3.28084f)))),
									"ft"
								}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
							}
							else
							{
								scenario_.LogMessage(string.Concat(new string[]
								{
									"Weapon: ",
									this.Name,
									" airbursted off ",
									TargetUnit_.Name,
									" by ",
									Conversions.ToString(Math.Max(1, (int)Math.Round((double)num6))),
									"m"
								}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
							}
						}
						else if (num6 > 926f)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								scenario_.LogMessage(string.Concat(new string[]
								{
									"Weapon: ",
									this.Name,
									" missed ",
									TargetUnit_.Name,
									" by ",
									Conversions.ToString(Math.Max(1, (int)Math.Round((double)(num6 * 3.28084f)))),
									"ft"
								}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
							}
							else
							{
								scenario_.LogMessage(string.Concat(new string[]
								{
									"Weapon: ",
									this.Name,
									" missed ",
									TargetUnit_.Name,
									" by ",
									Conversions.ToString(Math.Max(1, (int)Math.Round((double)num6))),
									"m"
								}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
							}
						}
						else
						{
							scenario_.LogMessage(string.Concat(new string[]
							{
								"Weapon: ",
								this.Name,
								" missed ",
								TargetUnit_.Name,
								" by ",
								Conversions.ToString(Math.Round((double)(num6 / 1852f), 1)),
								"nm"
							}), LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						}
						if (!flag2)
						{
							this.ExportWeaponEndgame(TargetUnit_, false, false, null);
						}
						result = flag2;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100958", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005602 RID: 22018 RVA: 0x0024B500 File Offset: 0x00249700
		public bool IsTargetHit(ActiveUnit TargetUnit_, ref Scenario scenario_, ref float MissDistance, ref float MissArimuth, ref Random random_)
		{
			bool flag = false;
			bool result;
			try
			{
				float num;
				if (!Information.IsNothing(TargetUnit_))
				{
					if (TargetUnit_.IsFacility)
					{
						num = (float)this.GetCEP_Land();
					}
					else
					{
						num = (float)this.GetCEP_Surface();
					}
				}
				else
				{
					num = (float)Math.Max(this.GetCEP_Land(), this.GetCEP_Surface());
				}
				if (this.GetGuidanceMethod() == Weapon._GuidanceMethod.InertiallyGuided && !Information.IsNothing(TargetUnit_) && TargetUnit_.GetCurrentSpeed() > 0f)
				{
					float num2 = (float)TargetUnit_.GetKinematics().GetSpeed(TargetUnit_.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Flank);
					float num3;
					if (num2 > 0f)
					{
						num3 = TargetUnit_.GetCurrentSpeed() / num2;
					}
					else
					{
						num3 = 0f;
					}
					if (TargetUnit_.IsFacility)
					{
						num = (float)this.GetCEP_Land() + (float)this.GetCEP_Land() * num3;
					}
					else
					{
						num = (float)this.GetCEP_Surface() + (float)this.GetCEP_Surface() * num3;
					}
				}
				if (this.weaponTarget.IsRadar)
				{
					if (!Information.IsNothing(this.ARM_SpecifiedEmission.Value))
					{
						if (this.ARM_SpecifiedEmission.Value.elapsedTime > 1f)
						{
							if (this.weaponCode.ARMTargetMemory)
							{
								num = Math.Min(num * 5f, num + this.ARM_SpecifiedEmission.Value.elapsedTime * 100f);
							}
							else
							{
								float num4 = Math.Min(this.ARM_SpecifiedEmission.Value.elapsedTime, (float)this.GetFuelRecs()[0].MaxQuantity - this.GetFuelRecs()[0].CurrentQuantity);
								num += num4 * 20f;
							}
						}
					}
					else if (!this.HasEmissionLockAndAlternativeSensor())
					{
						scenario_.LogMessage("Weapon: " + this.Name + " has no emission lock and no alternative sensor.... clean miss.", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						flag = false;
						result = false;
						return result;
					}
				}
				MissArimuth = (float)(random_.NextDouble() * 359.99);
				if (random_.Next(1, 3) == 1)
				{
					MissDistance = (float)((double)random_.Next(1, 101) / 100.0 * (double)num);
				}
				else
				{
					MissDistance = (float)((double)random_.Next(10, 24) / 10.0 * (double)num);
				}
				if (!Information.IsNothing(this.ARM_SpecifiedEmission) && !Information.IsNothing(this.ARM_SpecifiedEmission.Value) && !Information.IsNothing(TargetUnit_) && TargetUnit_.GetCurrentSpeed() > 0f && this.ARM_SpecifiedEmission.Value.elapsedTime > 1f)
				{
					MissDistance += this.ARM_SpecifiedEmission.Value.elapsedTime / 3600f * TargetUnit_.GetCurrentSpeed() * 1852f;
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101339", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06005603 RID: 22019 RVA: 0x0024B844 File Offset: 0x00249A44
		public void CalculateDamageEffect(ActiveUnit Target_, StringBuilder stringBuilder_0)
		{
			try
			{
				string text = "";
				bool flag = false;
				if (!this.IsDecoy())
				{
					Weapon.Delegate25 @delegate = Weapon.delegate25_0;
					if (@delegate != null)
					{
						@delegate(this.m_Scenario, this, Target_, true);
					}
					new WeaponImpact(ref Target_.m_Scenario, Target_.GetLongitude(null), Target_.GetLatitude(null), Target_.GetCurrentAltitude_ASL(false), WeaponImpact._WeaponImpactType.Airburst);
				}
				if (!Target_.IsAircraft && !Target_.IsWeapon)
				{
					if (Target_.IsFacility)
					{
						if (!((Facility)Target_).MountsAreAimpoints)
						{
							text = string.Concat(new string[]
							{
								"武器: ",
								this.Name,
								"命中",
								Target_.Name,
								". "
							});
						}
					}
					else
					{
						text = string.Concat(new string[]
						{
							"武器: ",
							this.Name,
							"命中",
							Target_.Name,
							". "
						});
					}
				}
				if (Target_.IsWeapon)
				{
					Weapon weapon = (Weapon)Target_;
					if (weapon.IsRVorHGV() || weapon.weaponCode.BallisticMissile)
					{
						Warhead.WarheadType warheadType = this.m_Warheads[0].warheadType;
						if (warheadType != Warhead.WarheadType.ArmorPiercing)
						{
							if (warheadType != Warhead.WarheadType.DirectionalContinousRod)
							{
								if (warheadType != Warhead.WarheadType.Kinetic)
								{
									text += "常规战斗部: 15%概率完全摧毁，30%概率显著偏离. ";
									int num = GameGeneral.GetRandom().Next(1, 101);
									int num2 = num;
									if (num2 <= 15)
									{
										text = text + "结果: " + Conversions.ToString(num) + ". 目标完全摧毁. ";
										flag = true;
										goto IL_441;
									}
									if (num2 <= 30)
									{
										text = text + "结果: " + Conversions.ToString(num) + ". 大幅度偏离弹道(目标武器圆概率偏差乘3). ";
										weapon.SetCEP_Land(weapon.GetCEP_Land() * 3);
										weapon.SetCEP_Surface(weapon.GetCEP_Surface() * 3);
										Target_.m_Scenario.LogMessage(text, LoggedMessage.MessageType.WeaponDamage, 10, base.GetGuid(), null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
										flag = false;
										goto IL_441;
									}
									text = text + "结果: " + Conversions.ToString(num) + ".小幅度偏离弹道(目标武器圆概率偏差乘1.5). ";
									weapon.SetCEP_Land((int)Math.Round((double)weapon.GetCEP_Land() * 1.5));
									weapon.SetCEP_Surface((int)Math.Round((double)weapon.GetCEP_Surface() * 1.5));
									Target_.m_Scenario.LogMessage(text, LoggedMessage.MessageType.WeaponDamage, 10, base.GetGuid(), null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
									flag = false;
									goto IL_441;
								}
							}
							else
							{
								text += "Directional continous-rod warhead: 30% chance of outright destruction, 60% chance of significant deviation. ";
								int num3 = GameGeneral.GetRandom().Next(1, 101);
								int num4 = num3;
								if (num4 <= 30)
								{
									text = text + "结果: " + Conversions.ToString(num3) + ".目标完全摧毁. ";
									flag = true;
									goto IL_441;
								}
								if (num4 <= 60)
								{
									text = text + "结果: " + Conversions.ToString(num3) + ". 大幅度偏离弹道(目标武器圆概率偏差乘3). ";
									weapon.SetCEP_Land(weapon.GetCEP_Land() * 3);
									weapon.SetCEP_Surface(weapon.GetCEP_Surface() * 3);
									Target_.m_Scenario.LogMessage(text, LoggedMessage.MessageType.WeaponDamage, 10, base.GetGuid(), null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
									flag = false;
									goto IL_441;
								}
								text = text + "结果: " + Conversions.ToString(num3) + ".小幅度偏离弹道(目标武器圆概率偏差乘1.5). ";
								weapon.SetCEP_Land((int)Math.Round((double)weapon.GetCEP_Land() * 1.5));
								weapon.SetCEP_Surface((int)Math.Round((double)weapon.GetCEP_Surface() * 1.5));
								Target_.m_Scenario.LogMessage(text, LoggedMessage.MessageType.WeaponDamage, 10, base.GetGuid(), null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
								flag = false;
								goto IL_441;
							}
						}
						text += "直接碰撞杀伤战斗部: 目标完全摧毁. ";
						flag = true;
						IL_441:
						stringBuilder_0.Append("\r\n").Append(text);
						this.ExportWeaponEndgame(Target_, true, flag, stringBuilder_0);
						if (flag)
						{
							ActiveUnit_Damage damage = Target_.GetDamage();
							GeoPoint launchPoint = this.LaunchPoint;
							float missDistance_ = 0f;
							float missAzimuth_ = 0f;
							ActiveUnit activeUnit_ = null;
							double? nullable_ = null;
							double? nullable_2 = null;
							float? nullable_3 = null;
							string text2 = "";
							damage.vmethod_11(this, launchPoint, missDistance_, missAzimuth_, activeUnit_, nullable_, nullable_2, nullable_3, ref text2);
						}
						return;
					}
				}
				if (Operators.CompareString(text, "", false) != 0)
				{
					Target_.m_Scenario.LogMessage(text, LoggedMessage.MessageType.WeaponDamage, 10, base.GetGuid(), null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
				}
				if (!Target_.IsAircraft && !Target_.IsGuidedWeapon_RV_HGV())
				{
					if (Target_.IsGuidedWeapon_RV_HGV())
					{
						stringBuilder_0.Append("\r\n").Append(text);
						this.ExportWeaponEndgame(Target_, true, flag, stringBuilder_0);
						ActiveUnit_Damage damage2 = Target_.GetDamage();
						GeoPoint launchPoint = this.LaunchPoint;
						float missDistance_2 = 0f;
						float missAzimuth_2 = 0f;
						ActiveUnit activeUnit_2 = null;
						double? nullable_4 = null;
						double? nullable_5 = null;
						float? nullable_6 = null;
						string text2 = "";
						damage2.vmethod_11(this, launchPoint, missDistance_2, missAzimuth_2, activeUnit_2, nullable_4, nullable_5, nullable_6, ref text2);
					}
					else
					{
						ActiveUnit_Damage damage3 = Target_.GetDamage();
						GeoPoint launchPoint2 = this.LaunchPoint;
						float missDistance_3 = 0f;
						float missAzimuth_3 = 0f;
						ActiveUnit activeUnit_3 = null;
						double? nullable_7 = null;
						double? nullable_8 = null;
						float? nullable_9 = null;
						string text2 = "";
						damage3.vmethod_11(this, launchPoint2, missDistance_3, missAzimuth_3, activeUnit_3, nullable_7, nullable_8, nullable_9, ref text2);
						bool bKill = Target_.IsNotActive();
						this.ExportWeaponEndgame(Target_, true, bKill, stringBuilder_0);
					}
				}
				else
				{
					ActiveUnit_Damage damage = Target_.GetDamage();
					GeoPoint launchPoint = this.LaunchPoint;
					float missDistance_4 = 0f;
					float missAzimuth_4 = 0f;
					ActiveUnit activeUnit_4 = null;
					double? nullable_10 = null;
					double? nullable_11 = null;
					float? nullable_12 = null;
					string text2 = "";
					damage.vmethod_11(this, launchPoint, missDistance_4, missAzimuth_4, activeUnit_4, nullable_10, nullable_11, nullable_12, ref text2);
					flag = Target_.IsNotActive();
					this.ExportWeaponEndgame(Target_, true, flag, stringBuilder_0);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100959", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005604 RID: 22020 RVA: 0x0024BF2C File Offset: 0x0024A12C
		public override void DestroyUnit(bool ScenEditAction, bool IsAimpointFacility, bool DestroyUnitNow = false)
		{
			this.isDestroyed = true;
			checked
			{
				try
				{
					if (!Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget()) && !this.GetWeaponAI().GetPrimaryTarget().IsDestroyed(this.m_Scenario) && this.GetWeaponAI().GetPrimaryTarget().contactType != Contact_Base.ContactType.Aimpoint && this.GetWeaponAI().GetPrimaryTarget().contactType != Contact_Base.ContactType.ActivationPoint && !Information.IsNothing(this.GetWeaponAI().GetPrimaryTarget().ActualUnit))
					{
						Contact[] threats = this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetAI().GetThreats();
						for (int i = 0; i < threats.Length; i++)
						{
							Contact contact = threats[i];
							if (contact.ActualUnit == this)
							{
								this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetAI().RemoveThreat(contact);
								this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetAI().SetPrimaryThreat(null);
								goto IL_105;
							}
						}
						this.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetAI().SetPrimaryThreat(null);
					}
					IL_105:
					using (IEnumerator<ActiveUnit> enumerator = this.m_Scenario.GetActiveUnits().Values.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Sensor[] noneMCMSensors = enumerator.Current.GetNoneMCMSensors();
							for (int j = 0; j < noneMCMSensors.Length; j++)
							{
								Sensor sensor = noneMCMSensors[j];
								if (sensor.SemiActiveGuidedWeaponList.Contains(this))
								{
									sensor.SemiActiveGuidedWeaponList.Remove(this);
									this.SetDirector(null);
								}
								if (sensor.SemiActiveGuidedWeaponList.Count == 0)
								{
									Sensor sensor2 = sensor;
									Weapon_AI weaponAI;
									Contact primaryTarget = (weaponAI = this.GetWeaponAI()).GetPrimaryTarget();
									sensor2.StopIlluminateTarget(ref primaryTarget, false);
									weaponAI.SetPrimaryTarget(primaryTarget);
								}
							}
						}
					}
					base.DestroyUnit(ScenEditAction, IsAimpointFacility, DestroyUnitNow);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200343", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x0024C180 File Offset: 0x0024A380
		public void SetDefaultGuidanceMethod()
		{
			if (this.GetWeaponType() == Weapon._WeaponType.Decoy_Vehicle)
			{
				this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.InertiallyGuided);
			}
			else if (this.weaponCode.IlluminateAtLaunch)
			{
				if (this.GetNoneMCMSensors().Length > 0)
				{
					Sensor.SensorType sensorType = this.GetNoneMCMSensors()[0].sensorType;
					if (sensorType == Sensor.SensorType.Radar)
					{
						this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance);
					}
					else if (sensorType == Sensor.SensorType.SemiActive)
					{
						this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.SemiActive);
					}
					else if (sensorType == Sensor.SensorType.LaserSpotTracker)
					{
						this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.SemiActive);
					}
				}
				else if (this.GetCommDevices().Count<CommDevice>() > 0)
				{
					this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.TrackViaMissile);
				}
				else
				{
					this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.BeamRiding);
				}
			}
			else if (this.weaponDirectorSet.Count > 0 && this.GetCommDevices().Count<CommDevice>() == 0 && !this.weaponCode.TerminalIllumination && base.HasRadar())
			{
				this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.TimeSharedSemiActiveMidCoursePlusActiveTerminalGuidance);
			}
			else if (this.weaponCode.TerminalIllumination)
			{
				if (this.GetCommDevices().Count<CommDevice>() != 0)
				{
					this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance);
				}
				else if (!base.HasInfraredSensor())
				{
					this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.const_1);
				}
				else if (!this.weaponCode.BOLCapable && !this.weaponCode.Weapon_INSNavigation && !this.weaponCode.Weapon_INS_w_GPSNavigation && !this.weaponCode.Weapon_TERCOMNavigation)
				{
					this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.PassiveTerminalGuidance);
				}
				else
				{
					this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.INSMidcoursePlusPassiveTerminalGuidance);
				}
			}
			else if (!base.HasRadar() && !base.HasActiveSonar())
			{
				if (base.HasPassiveSensor())
				{
					if (!this.weaponCode.BOLCapable && !this.weaponCode.Weapon_INSNavigation && !this.weaponCode.Weapon_INS_w_GPSNavigation && !this.weaponCode.Weapon_TERCOMNavigation)
					{
						if (this.GetCommDevices().Count<CommDevice>() == 0)
						{
							this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.PassiveTerminalGuidance);
						}
						else
						{
							this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.const_5);
						}
					}
					else if (this.GetCommDevices().Count<CommDevice>() == 0)
					{
						this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.INSMidcoursePlusPassiveTerminalGuidance);
					}
					else
					{
						this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.const_5);
					}
				}
				else if (this.GetCommDevices().Count<CommDevice>() > 0)
				{
					this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.CommandGuided);
				}
				else
				{
					this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.InertiallyGuided);
				}
			}
			else if (this.weaponCode.BOLCapable)
			{
				if (this.GetCommDevices().Count<CommDevice>() == 0)
				{
					this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.InertialMidCoursePlusActiveTerminalGuidance);
				}
				else
				{
					this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.const_7);
				}
			}
			else if (this.GetCommDevices().Count<CommDevice>() == 0)
			{
				this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.ActiveTerminalGuidance);
			}
			else
			{
				this.GuidanceMethod = new Weapon._GuidanceMethod?(Weapon._GuidanceMethod.const_7);
			}
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x0024C4C8 File Offset: 0x0024A6C8
		internal float GetSeaSkimmerModifier(float ASL_)
		{
			float result;
			if (ASL_ >= 91.44f)
			{
				result = 0f;
			}
			else if (ASL_ >= 60.96f)
			{
				result = 5f;
			}
			else if (ASL_ >= 30.48f)
			{
				result = 15f;
			}
			else
			{
				result = 30f;
			}
			return result;
		}

		// Token: 0x06005607 RID: 22023 RVA: 0x0024C51C File Offset: 0x0024A71C
		public override void UpdatePropulsionState(float elapsedTime)
		{
			try
			{
				if (this.GetFuelRecs().Count<FuelRec>() != 0)
				{
					if (this.m_FuelRecs[0].CurrentQuantity == 0f)
					{
						if (this.IsOfAirLaunchedGuidedWeapon() && this.GetPitch() < this.method_127())
						{
							return;
						}
						if (!this.HasNuclearWarhead() || this.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
						{
							if (this.GetWeaponType() != Weapon._WeaponType.Sonobuoy)
							{
								this.m_Scenario.LogMessage("武器: " + this.Name + " 能量耗光... 自毁", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
							}
							this.m_Scenario.RemoveUnit(this);
							return;
						}
						double latitude = this.GetLatitude(null);
						double longitude = this.GetLongitude(null);
						float currentAltitude_ASL = this.GetCurrentAltitude_ASL(false);
						Random random = GameGeneral.GetRandom();
						this.Detonation(latitude, longitude, currentAltitude_ASL, ref random);
					}
					float fuelConsumption = this.GetFuelConsumption(this.GetThrottle(), null, null, null, false, false, false, false);
					this.m_FuelRecs[0].CurrentQuantity = this.m_FuelRecs[0].CurrentQuantity - elapsedTime * fuelConsumption;
					if (this.m_FuelRecs[0].CurrentQuantity < 0f)
					{
						this.m_FuelRecs[0].CurrentQuantity = 0f;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100961", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x0024C704 File Offset: 0x0024A904
		public override float GetFuelConsumption(ActiveUnit.Throttle throttle_, AltBand altBand_, float? specificDesiredSpeed_, float? altitude_, bool bool_21, bool bool_22, bool bool_23, bool bool_24)
		{
			float result = 0f;
			try
			{
				if (this.GetEngines().Count == 0)
				{
					result = 1f;
				}
				else
				{
					AltBand altBand;
					if (Information.IsNothing(altBand_))
					{
						altBand = this.GetWeaponKinematics().vmethod_39();
					}
					else
					{
						altBand = altBand_;
					}
					if (Information.IsNothing(altBand))
					{
						throw new Exception();
					}
					switch (throttle_)
					{
					case ActiveUnit.Throttle.Loiter:
						if (!Information.IsNothing(altBand.Consumption_Loiter))
						{
							result = altBand.Consumption_Loiter;
						}
						break;
					case ActiveUnit.Throttle.Cruise:
						result = altBand.Consumption_Cruise;
						break;
					case ActiveUnit.Throttle.Full:
						if (altBand.Consumption_Full.HasValue)
						{
							result = altBand.Consumption_Full.Value;
						}
						else
						{
							result = altBand.Consumption_Cruise;
						}
						break;
					case ActiveUnit.Throttle.Flank:
						if (altBand.Consumption_Flank.HasValue)
						{
							result = altBand.Consumption_Flank.Value;
						}
						else if (altBand.Consumption_Full.HasValue)
						{
							result = altBand.Consumption_Full.Value;
						}
						else
						{
							result = altBand.Consumption_Cruise;
						}
						break;
					default:
						result = 0f;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100962", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005609 RID: 22025 RVA: 0x0024C870 File Offset: 0x0024AA70
		private float GetPHitModifiedBySpeedAndSignature(int pHit_, float TargetSpeed_, float TargetRadarXSection_, float TargetIRXSection_, StringBuilder stringBuilder_0)
		{
			float num = 0f;
			float result = 0f;
			try
			{
				if (TargetSpeed_ > (float)this.TargetSpeedMax)
				{
					num = 50f;
				}
				else if ((double)TargetSpeed_ > (double)this.TargetSpeedMax * 0.8)
				{
					num = 25f;
				}
				else if ((double)TargetSpeed_ > (double)this.TargetSpeedMax * 0.8)
				{
					num = 15f;
				}
				else if ((double)TargetSpeed_ > (double)this.TargetSpeedMax * 0.6)
				{
					num = 10f;
				}
				else if ((double)TargetSpeed_ > (double)this.TargetSpeedMax * 0.4)
				{
					num = 5f;
				}
				if (num != 0f)
				{
					stringBuilder_0.Append(" 目标速度修正: " + Conversions.ToString(-(int)Math.Round((double)num)) + "%. ");
				}
				float num2 = 0f;
				if (!Information.IsNothing(this.GetWeaponDirectors()) && this.GetWeaponDirectors().Length > 0 && !Information.IsNothing(this.GetWeaponDirectors()[0]))
				{
					Sensor.SensorType sensorType = this.GetWeaponDirectors()[0].sensorType;
					if (sensorType - Sensor.SensorType.Radar > 1)
					{
						if (sensorType != Sensor.SensorType.Infrared)
						{
							if (sensorType != Sensor.SensorType.LaserDesignator)
							{
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								num2 = 0f;
							}
							else
							{
								num2 = 0f;
							}
						}
						else if (TargetIRXSection_ > 1f)
						{
							num2 = 0f;
						}
						else if (TargetIRXSection_ > 0.5f)
						{
							num2 = 10f;
						}
						else if (TargetIRXSection_ > 0.25f)
						{
							num2 = 15f;
						}
						else
						{
							num2 = 20f;
						}
					}
					else
					{
						float num3 = (float)new ECM.Target
						{
							RCS = (double)TargetRadarXSection_
						}.GetRCS_m2();
						if (num3 > 1f)
						{
							num2 = 0f;
						}
						else if (num3 > 0.1f)
						{
							num2 = 10f;
						}
						else if (num3 > 0.01f)
						{
							num2 = 15f;
						}
						else
						{
							num2 = 20f;
						}
					}
					if (num2 != 0f)
					{
						stringBuilder_0.Append(" 目标信号特征修正: " + Conversions.ToString(-(int)Math.Round((double)num2)) + "%. ");
					}
				}
				result = Math.Max(1f, (float)pHit_ - num - num2);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100963", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600560A RID: 22026 RVA: 0x0024CB40 File Offset: 0x0024AD40
		public string GetWeaponCodeString()
		{
			string text = "";
			string str = "";
			bool flag = false;
			if (this.weaponCode.Weapon_INSNavigation)
			{
				text = "惯导";
				flag = true;
			}
			else if (this.weaponCode.Weapon_INS_w_GPSNavigation)
			{
				text = "GPS惯导";
				flag = true;
			}
			else if (this.weaponCode.Weapon_TERCOMNavigation)
			{
				text = "地形匹配";
				flag = true;
			}
			else if (this.weaponCode.AntiAir_RearAspect)
			{
				text = "后向攻击";
				flag = true;
			}
			else if (this.weaponCode.AntiAir_SternChase)
			{
				text = "尾追攻击";
				flag = true;
			}
			else if (this.weaponCode.AntiAir_AllAspect)
			{
				text = "全向攻击";
				flag = true;
			}
			else if (this.weaponCode.AntiAir_Dogfight_HighOffBoresight)
			{
				text = "全向大离轴攻击";
				flag = true;
			}
			else if (this.weaponCode.Torpedo_PatternRunning)
			{
				text = "预置航迹";
				flag = true;
			}
			else if (this.weaponCode.Torpedo_StraightRunningAndTimeDetonation)
			{
				text = "直航定时引爆";
				flag = true;
			}
			else if (this.weaponCode.Torpedo_StraightRunning)
			{
				text = "直航";
				flag = true;
			}
			else if (this.weaponCode.Torpedo_WakeHoming)
			{
				text = "尾流自导";
				flag = true;
			}
			checked
			{
				string result;
				switch (this.GetGuidanceMethod())
				{
				case Weapon._GuidanceMethod.SemiActive:
					text = "半主动";
					if (this.weaponDirectorSet.Count <= 0)
					{
						result = text;
						return result;
					}
					using (HashSet<int>.Enumerator enumerator = this.weaponDirectorSet.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							int current = enumerator.Current;
							SQLiteConnection sQLiteConnection = this.m_Scenario.GetSQLiteConnection();
							Sensor sensor = DBFunctions.LoadSensorData(current, ref sQLiteConnection);
							if (sensor.sensorType != Sensor.SensorType.Radar)
							{
								if (sensor.sensorType != Sensor.SensorType.LaserDesignator)
								{
									continue;
								}
								text += "激光寻的";
							}
							else
							{
								text += "雷达寻的";
							}
							IL_22B:
							result = text;
							return result;
						}
                            result = text;
                            return result;
                        }
					break;
				case Weapon._GuidanceMethod.const_1:
					break;
				case Weapon._GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance:
					text = "数据链(DL/INS)中段加半主动";
					if (this.weaponDirectorSet.Count > 0)
					{
						foreach (int current2 in this.weaponDirectorSet)
						{
							SQLiteConnection sQLiteConnection = this.m_Scenario.GetSQLiteConnection();
							Sensor sensor2 = DBFunctions.LoadSensorData(current2, ref sQLiteConnection);
							if (sensor2.sensorType != Sensor.SensorType.Radar)
							{
								if (sensor2.sensorType != Sensor.SensorType.LaserDesignator)
								{
									continue;
								}
								text += "激光寻的";
							}
							else
							{
								text += "雷达寻的";
							}
							break;
						}
					}
					if (this.GetNoneMCMSensors().Length > 0)
					{
						Sensor[] noneMCMSensors = this.GetNoneMCMSensors();
						for (int i = 0; i < noneMCMSensors.Length; i++)
						{
							Sensor sensor3 = noneMCMSensors[i];
							if (sensor3.sensorType == Sensor.SensorType.Infrared)
							{
								str = "带红外备份导引头";
							}
							else if (sensor3.sensorType == Sensor.SensorType.Visual)
							{
								str = "带光电备份导引头";
							}
						}
					}
					text = text + "末制导" + str;
					result = text;
					return result;
				case (Weapon._GuidanceMethod)3:
					result = text;
					return result;
				case Weapon._GuidanceMethod.PassiveTerminalGuidance:
					if (flag)
					{
						text += "中段加";
					}
					text += "被动";
					if (this.GetNoneMCMSensors().Length > 0)
					{
						Sensor[] noneMCMSensors2 = this.GetNoneMCMSensors();
						for (int j = 0; j < noneMCMSensors2.Length; j++)
						{
							Sensor sensor4 = noneMCMSensors2[j];
							if (sensor4.sensorType == Sensor.SensorType.Infrared)
							{
								text += "红外";
								break;
							}
							if (sensor4.sensorType == Sensor.SensorType.Visual)
							{
								text += "光电";
								break;
							}
							if (sensor4.sensorType == Sensor.SensorType.ESM)
							{
								text += "雷达寻的";
								break;
							}
						}
					}
					if (flag)
					{
						text += "末制导";
						result = text;
						return result;
					}
					result = text;
					return result;
				case Weapon._GuidanceMethod.INSMidcoursePlusPassiveTerminalGuidance:
					text = "惯导中段加被动";
					if (this.GetNoneMCMSensors().Length > 0)
					{
						Sensor[] noneMCMSensors3 = this.GetNoneMCMSensors();
						for (int k = 0; k < noneMCMSensors3.Length; k++)
						{
							Sensor sensor5 = noneMCMSensors3[k];
							if (sensor5.sensorType == Sensor.SensorType.Infrared)
							{
								text += "红外";
								break;
							}
							if (sensor5.sensorType == Sensor.SensorType.Visual)
							{
								text += "光电";
								break;
							}
							if (sensor5.sensorType == Sensor.SensorType.ESM)
							{
								text += "雷达寻的";
								break;
							}
						}
					}
					text += "末制导";
					result = text;
					return result;
				case Weapon._GuidanceMethod.const_5:
					if (flag)
					{
						text += "、";
					}
					if (this.GetWeaponType() == Weapon._WeaponType.GuidedWeapon)
					{
						text += "数据链中段加被动";
					}
					else if (this.GetWeaponType() == Weapon._WeaponType.Torpedo)
					{
						text += "有线制导中段加被动";
					}
					if (this.GetNoneMCMSensors().Length > 0)
					{
						Sensor[] noneMCMSensors4 = this.GetNoneMCMSensors();
						for (int l = 0; l < noneMCMSensors4.Length; l++)
						{
							if (noneMCMSensors4[l].sensorType == Sensor.SensorType.Radar)
							{
								text += "雷达寻的";
								break;
							}
						}
					}
					text += "末制导";
					result = text;
					return result;
				case Weapon._GuidanceMethod.ActiveTerminalGuidance:
					if (flag)
					{
						text += "中段加";
					}
					text += "主动";
					if (this.GetNoneMCMSensors().Length > 0)
					{
						Sensor[] noneMCMSensors5 = this.GetNoneMCMSensors();
						for (int m = 0; m < noneMCMSensors5.Length; m++)
						{
							if (noneMCMSensors5[m].sensorType == Sensor.SensorType.Radar)
							{
								text += "雷达寻的";
								break;
							}
						}
					}
					if (flag)
					{
						text += "末制导";
						result = text;
						return result;
					}
					result = text;
					return result;
				case Weapon._GuidanceMethod.const_7:
					if (flag)
					{
						text += "、";
					}
					if (this.GetWeaponType() == Weapon._WeaponType.GuidedWeapon)
					{
						text += "数据链(DL/INS)中段加主动";
					}
					else if (this.GetWeaponType() == Weapon._WeaponType.Torpedo)
					{
						text += "有线制导中段加主动";
					}
					if (this.GetNoneMCMSensors().Length > 0)
					{
						Sensor[] noneMCMSensors6 = this.GetNoneMCMSensors();
						for (int n = 0; n < noneMCMSensors6.Length; n++)
						{
							Sensor sensor6 = noneMCMSensors6[n];
							if (sensor6.sensorType == Sensor.SensorType.Radar)
							{
								text += "雷达寻的";
							}
							else if (sensor6.sensorType == Sensor.SensorType.Infrared)
							{
								str = "带红外备份导引头";
							}
							else if (sensor6.sensorType == Sensor.SensorType.Visual)
							{
								str = "带光电备份导引头";
							}
						}
					}
					text = text + "末制导" + str;
					result = text;
					return result;
				case Weapon._GuidanceMethod.InertialMidCoursePlusActiveTerminalGuidance:
					text = "惯导中段加主动";
					if (this.GetNoneMCMSensors().Length > 0)
					{
						Sensor[] noneMCMSensors7 = this.GetNoneMCMSensors();
						for (int num = 0; num < noneMCMSensors7.Length; num++)
						{
							Sensor sensor7 = noneMCMSensors7[num];
							if (sensor7.sensorType == Sensor.SensorType.Radar)
							{
								text += "雷达寻的";
							}
							else if (sensor7.sensorType == Sensor.SensorType.Infrared)
							{
								str = "带红外备份导引头";
							}
							else if (sensor7.sensorType == Sensor.SensorType.Visual)
							{
								str = "带光电备份导引头";
							}
							else if (sensor7.sensorType == Sensor.SensorType.ESM && this.weaponTarget.IsRadar)
							{
								str = "带反辐备份导引头";
							}
						}
					}
					text = text + "末制导" + str;
					result = text;
					return result;
				case Weapon._GuidanceMethod.CommandGuided:
					text = "指令制导";
					result = text;
					return result;
				case Weapon._GuidanceMethod.TrackViaMissile:
					text = "导弹跟踪制导";
					result = text;
					return result;
				case Weapon._GuidanceMethod.BeamRiding:
					text = "驾束制导";
					result = text;
					return result;
				case Weapon._GuidanceMethod.InertiallyGuided:
					text = "惯导";
					result = text;
					return result;
				case Weapon._GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance:
					text = "半主动中段加主动";
					if (this.GetNoneMCMSensors().Length > 0)
					{
						Sensor[] noneMCMSensors8 = this.GetNoneMCMSensors();
						for (int num2 = 0; num2 < noneMCMSensors8.Length; num2++)
						{
							if (noneMCMSensors8[num2].sensorType == Sensor.SensorType.Radar)
							{
								text += "雷达寻的";
								break;
							}
						}
					}
					text += "末制导";
					result = text;
					return result;
				case Weapon._GuidanceMethod.TimeSharedSemiActiveMidCoursePlusActiveTerminalGuidance:
					text = "分时半主动中段加主动";
					if (this.GetNoneMCMSensors().Length > 0)
					{
						Sensor[] noneMCMSensors9 = this.GetNoneMCMSensors();
						for (int num3 = 0; num3 < noneMCMSensors9.Length; num3++)
						{
							if (noneMCMSensors9[num3].sensorType == Sensor.SensorType.Radar)
							{
								text += "雷达寻的";
								break;
							}
						}
					}
					text += "末制导";
					result = text;
					return result;
				default:
					result = text;
					return result;
				}
				text = "惯导中段加半主动";
				if (this.weaponDirectorSet.Count > 0)
				{
					foreach (int current3 in this.weaponDirectorSet)
					{
						SQLiteConnection sQLiteConnection = this.m_Scenario.GetSQLiteConnection();
						Sensor sensor8 = DBFunctions.LoadSensorData(current3, ref sQLiteConnection);
						if (sensor8.sensorType != Sensor.SensorType.Radar)
						{
							if (sensor8.sensorType != Sensor.SensorType.LaserDesignator)
							{
								continue;
							}
							text += "激光寻的";
						}
						else
						{
							text += "雷达寻的";
						}
						break;
					}
				}
				text += "末制导";
				result = text;
				return result;
			}
		}

		// Token: 0x0600560B RID: 22027 RVA: 0x0024D53C File Offset: 0x0024B73C
		public bool method_258()
		{
			return this.IsMREV_GuidedBallisticMissile() || this.IsMREV_BallisticMissile() || (this.m_Warheads.Any<Warhead>() && this.m_Warheads[0].warheadType == Warhead.WarheadType.Weapon && this.m_Warheads[0].GetWeaponFromDP(this.m_Scenario).IsRVorHGV());
		}

		// Token: 0x0600560C RID: 22028 RVA: 0x0024D598 File Offset: 0x0024B798
		public float method_259()
		{
			float result = 0f;
			try
			{
				Weapon._WeaponType weaponType = this.weaponType;
				if (weaponType <= Weapon._WeaponType.GuidedProjectile)
				{
					switch (weaponType)
					{
					case Weapon._WeaponType.GuidedWeapon:
						goto IL_210;
					case Weapon._WeaponType.Rocket:
						result = (float)(0.5 * (double)this.WeightEmpty * Math.Pow(300.0, 2.0) / 100.0 / 15000.0);
						goto IL_253;
					case Weapon._WeaponType.IronBomb:
						result = (float)(0.5 * (double)this.WeightEmpty * Math.Pow(200.0, 2.0) / 100.0 / 15000.0);
						goto IL_253;
					case Weapon._WeaponType.Gun:
						result = (float)(0.5 * (double)this.WeightEmpty * Math.Pow((double)(this.GetCurrentSpeed() * 0.514444f), 2.0) / 100.0 / 15000.0);
						goto IL_253;
					default:
						if (weaponType == Weapon._WeaponType.GuidedProjectile)
						{
							result = (float)(0.5 * (double)this.WeightEmpty * Math.Pow((double)(this.GetCurrentSpeed() * 0.514444f), 2.0) / 100.0 / 15000.0);
							goto IL_253;
						}
						break;
					}
				}
				else
				{
					if (weaponType == Weapon._WeaponType.Torpedo)
					{
						goto IL_210;
					}
					if (weaponType == Weapon._WeaponType.HGV)
					{
						float num = (float)Math.Max(Math.Max(this.WeightMax, this.BurnoutWeight), Math.Max(this.WeightEmpty, this.WeightPayload));
						if ((double)num == 0.0 && this.m_Warheads.Any<Warhead>())
						{
							num = this.m_Warheads[0].DP;
						}
						float num2 = this.GetCurrentSpeed() * 0.514444f;
						result = (float)(0.5 * (double)num * Math.Pow((double)num2, 2.0) / 100.0 / 15000.0);
						goto IL_253;
					}
				}
				result = 0f;
				goto IL_253;
				IL_210:
				result = (float)(0.5 * (double)this.WeightEmpty * Math.Pow((double)(this.GetCurrentSpeed() * 0.514444f), 2.0) / 100.0 / 15000.0);
				IL_253:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100979", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x001974AC File Offset: 0x001956AC
		[CompilerGenerated]
		private double GetAngularDistance(Contact contact_0)
		{
			return base.GetApproxAngularDistanceInDegrees(contact_0);
		}

		// Token: 0x04002987 RID: 10631
		public static Func<Sensor, float> CombinedPortAndStarboardArcsForSensor = (Sensor sensor_0) => sensor_0.GetCombinedPortAndStarboardArcs();

		// Token: 0x04002988 RID: 10632
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc1 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04002989 RID: 10633
		public static Func<ActiveUnit, bool> IsWeaponFilter = (ActiveUnit activeUnit_0) => activeUnit_0.IsWeapon;

		// Token: 0x0400298A RID: 10634
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc3 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x0400298B RID: 10635
		public static Func<KeyValuePair<int, EmissionContainer>, int> KeyValuePairFunc4 = (KeyValuePair<int, EmissionContainer> keyValuePair_0) => keyValuePair_0.Key;

		// Token: 0x0400298C RID: 10636
		public static Func<KeyValuePair<int, EmissionContainer>, int> KeyValuePairFunc5 = (KeyValuePair<int, EmissionContainer> keyValuePair_0) => keyValuePair_0.Key;

		// Token: 0x0400298D RID: 10637
		public static Func<KeyValuePair<int, EmissionContainer>, int> KeyValuePairFunc6 = (KeyValuePair<int, EmissionContainer> keyValuePair_0) => keyValuePair_0.Key;

		// Token: 0x0400298E RID: 10638
		public static Func<KeyValuePair<int, EmissionContainer>, int> KeyValuePairFunc7 = (KeyValuePair<int, EmissionContainer> keyValuePair_0) => keyValuePair_0.Key;

		// Token: 0x0400298F RID: 10639
		public static Func<KeyValuePair<int, EmissionContainer>, int> KeyValuePairFunc8 = (KeyValuePair<int, EmissionContainer> keyValuePair_0) => keyValuePair_0.Key;

		// Token: 0x04002990 RID: 10640
		public static Func<KeyValuePair<int, EmissionContainer>, int> KeyValuePairFunc9 = (KeyValuePair<int, EmissionContainer> keyValuePair_0) => keyValuePair_0.Key;

		// Token: 0x04002991 RID: 10641
		public static Func<Contact, int> ContactFunc10 = (Contact contact_0) => contact_0.method_92().Length;

		// Token: 0x04002992 RID: 10642
		public static Func<Contact, int> ContactFunc11 = (Contact contact_0) => contact_0.method_92().Length;

		// Token: 0x04002993 RID: 10643
		public static Func<Sensor, bool> IsOperationRadar = (Sensor sensor_0) => sensor_0.sensorType == Sensor.SensorType.Radar && sensor_0.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational;

		// Token: 0x04002994 RID: 10644
		private Weapon._WeaponType weaponType;

		// Token: 0x04002995 RID: 10645
		public GlobalVariables.TechGenerationClass techGenerationClass;

		// Token: 0x04002996 RID: 10646
		public float Length;

		// Token: 0x04002997 RID: 10647
		public int BurnoutWeight;

		// Token: 0x04002998 RID: 10648
		public float Span;

		// Token: 0x04002999 RID: 10649
		public float Diameter;

		// Token: 0x0400299A RID: 10650
		public int CEPSurface;

		// Token: 0x0400299B RID: 10651
		private int CEP_Surface;

		// Token: 0x0400299C RID: 10652
		public int CEP;

		// Token: 0x0400299D RID: 10653
		private int CEP_Land;

		// Token: 0x0400299E RID: 10654
		public float CruiseAltitude;

		// Token: 0x0400299F RID: 10655
		private float CruiseAltitude_ASL;

		// Token: 0x040029A0 RID: 10656
		public int WaypointNumber;

		// Token: 0x040029A1 RID: 10657
		public int IlluminationTime;

		// Token: 0x040029A2 RID: 10658
		public int AirPOK;

		// Token: 0x040029A3 RID: 10659
		public int SurfacePOK;

		// Token: 0x040029A4 RID: 10660
		public int LandPOK;

		// Token: 0x040029A5 RID: 10661
		public int SubsurfacePOK;

		// Token: 0x040029A6 RID: 10662
		public int LaunchSpeedMax;

		// Token: 0x040029A7 RID: 10663
		public int LaunchSpeedMin;

		// 空空导弹最大杀伤范围
		public float RangeAAWMax;

        // 空空导弹最小杀伤范围
        public float RangeAAWMin;

		// Token: 0x040029AA RID: 10666
		public float RangeASUWMax;

		// Token: 0x040029AB RID: 10667
		public float RangeASUWMin;

		// Token: 0x040029AC RID: 10668
		public float RangeLandMax;

		// Token: 0x040029AD RID: 10669
		public float RangeLandMin;

		// Token: 0x040029AE RID: 10670
		public float RangeASWMax;

		// Token: 0x040029AF RID: 10671
		public float RangeASWMin;

		// Token: 0x040029B0 RID: 10672
		public float TorpedoRangeCruise;

		// Token: 0x040029B1 RID: 10673
		public float TorpedoRangeFull;

		// Token: 0x040029B2 RID: 10674
		public float LaunchAltitudeMin;

		// Token: 0x040029B3 RID: 10675
		public float LaunchAltitudeMax;

		// Token: 0x040029B4 RID: 10676
		public float TargetAltitudeMin;

		// Token: 0x040029B5 RID: 10677
		public float TargetAltitudeMax;

		// Token: 0x040029B6 RID: 10678
		public float LaunchAltitudeMin_ASL;

		// Token: 0x040029B7 RID: 10679
		public float LaunchAltitudeMax_ASL;

		// Token: 0x040029B8 RID: 10680
		public float TargetAltitudeMin_ASL;

		// Token: 0x040029B9 RID: 10681
		public float TargetAltitudeMax_ASL;

		// 目标最小速度
		public int TargetSpeedMin;

		// 目标最大速度
		public int TargetSpeedMax;

		// Token: 0x040029BC RID: 10684
		public float SnapUpDownAltitude_m;

		// 武器目标
		public WeaponTarget weaponTarget;

		// 战斗部
		public Warhead[] m_Warheads;

		// Token: 0x040029BF RID: 10687
		public HashSet<int> weaponDirectorSet;

		// Token: 0x040029C0 RID: 10688
		protected float BlindTime;

		// Token: 0x040029C1 RID: 10689
		protected float DRT;

		// Token: 0x040029C2 RID: 10690
		public Weapon.WeaponCode weaponCode;

		// Token: 0x040029C3 RID: 10691
		private ActiveUnit FiringParent;

		// Token: 0x040029C4 RID: 10692
		protected string FiringParentGuid;

		// Token: 0x040029C5 RID: 10693
		private ActiveUnit DataLinkParent;

		// Token: 0x040029C6 RID: 10694
		protected string DataLinkParentGuid;

		// Token: 0x040029C7 RID: 10695
		public Weapon._SearchPatternType searchPatternType;

		// Token: 0x040029C8 RID: 10696
		private Weapon._GuidanceMethod? GuidanceMethod;

		// Token: 0x040029C9 RID: 10697
		public GeoPoint LaunchPoint;

		// Token: 0x040029CA RID: 10698
		internal float DetonationDelay;

		// Token: 0x040029CB RID: 10699
		public bool CanActAsSensor;

		// Token: 0x040029CC RID: 10700
		private Sensor m_Director;

		// Token: 0x040029CD RID: 10701
		protected string SensorIlluminatingForMe;

		// Token: 0x040029CE RID: 10702
		public KeyValuePair<int, EmissionContainer> ARM_SpecifiedEmission;

		// Token: 0x040029CF RID: 10703
		public bool ARM_SpecifiedEmissionIsMandatory;

		// Token: 0x040029D0 RID: 10704
		internal bool bPrimaryTargetAttackable;

		// Token: 0x040029D1 RID: 10705
		[CompilerGenerated]
		private ObservableCollection<WeaponRec> WeaponRecCollection;

		// Token: 0x040029D2 RID: 10706
		public List<Weapon._ASMode> list_3;

		// Token: 0x040029D3 RID: 10707
		protected Weapon_Navigator weapon_Navigator;

		// Token: 0x040029D4 RID: 10708
		private Weapon_AI weapon_AI;

		// 武器的运动学
		private Weapon_Kinematics weapon_Kinematics;

		// 武器的传感器
		private Weapon_Sensory weapon_Sensory;

		// Token: 0x040029D7 RID: 10711
		private Weapon_CommStuff weapon_CommStuff;

		// Token: 0x040029D8 RID: 10712
		private Weapon_Damage weapon_Damage;

		// Token: 0x040029D9 RID: 10713
		protected ActiveUnit IlluminatorUnit;

		// Token: 0x040029DA RID: 10714
		[CompilerGenerated]
		private static Weapon.Delegate25 delegate25_0;

		// Token: 0x040029DB RID: 10715
		private bool? IsAirLaunchedGuidedWeapon;

		// Token: 0x040029DC RID: 10716
		private bool? bRadarDetectable;

		// Token: 0x040029DD RID: 10717
		private bool? bMREV_GuidedBallisticMissile;

		// Token: 0x040029DE RID: 10718
		private bool? bMREV_BallisticMissile;

		// Token: 0x040029DF RID: 10719
		private bool bool_20;

		// Token: 0x02000A94 RID: 2708
		// (Invoke) Token: 0x0600561D RID: 22045
		public delegate void Delegate25(Scenario theScen, Weapon theWeapon, Unit theTarget, bool DirectHit);

		// 武器类型
		public enum _WeaponType : short
		{
			// Token: 0x040029EE RID: 10734
			None = 1001,
			// 制导武器
			GuidedWeapon = 2001,
			// 火箭
			Rocket,
			// 铁炸弹
			IronBomb,
			// 枪支
			Gun,
			// Token: 0x040029F3 RID: 10739
			Decoy_Expendable,
			// 拖曳诱饵
			Decoy_Towed,
			// Token: 0x040029F5 RID: 10741
			Decoy_Vehicle,
			// Token: 0x040029F6 RID: 10742
			TrainingRound,
			// Token: 0x040029F7 RID: 10743
			Dispenser,
			// Token: 0x040029F8 RID: 10744
			ContactBomb_Suicide,
			// Token: 0x040029F9 RID: 10745
			ContactBomb_Sabotage,
			// Token: 0x040029FA RID: 10746
			GuidedProjectile,
			// Token: 0x040029FB RID: 10747
			SensorPod = 3001,
			// Token: 0x040029FC RID: 10748
			DropTank,
			// Token: 0x040029FD RID: 10749
			BuddyStore,
			// Token: 0x040029FE RID: 10750
			FerryTank,
			// Token: 0x040029FF RID: 10751
			Torpedo = 4001,
			// Token: 0x04002A00 RID: 10752
			DepthCharge,
			// Token: 0x04002A01 RID: 10753
			Sonobuoy,
			// Token: 0x04002A02 RID: 10754
			BottomMine,
			// Token: 0x04002A03 RID: 10755
			MooredMine,
			// Token: 0x04002A04 RID: 10756
			FloatingMine,
			// Token: 0x04002A05 RID: 10757
			MovingMine,
			// Token: 0x04002A06 RID: 10758
			RisingMine,
			// Token: 0x04002A07 RID: 10759
			DriftingMine,
			// Token: 0x04002A08 RID: 10760
			DummyMine = 4011,
			// Token: 0x04002A09 RID: 10761
			HeliTowedPackage = 4101,
			// Token: 0x04002A0A RID: 10762
			RV = 5001,
			// Token: 0x04002A0B RID: 10763
			Laser = 6001,
			// Token: 0x04002A0C RID: 10764
			HGV = 8001,
			// Token: 0x04002A0D RID: 10765
			Cargo = 9001,
			// Token: 0x04002A0E RID: 10766
			Troops,
			// Token: 0x04002A0F RID: 10767
			Paratroops
		}

		// 制导方法
		public enum _GuidanceMethod : byte
		{
			// 半主动
			SemiActive,
			// Token: 0x04002A12 RID: 10770
			const_1,
			// 中段指令+末端半主动
			DatalinkMidCoursePlusSemiActiveTerminalGuidance,
			// 末端被动导引
			PassiveTerminalGuidance = 4,
			// Token: 0x04002A15 RID: 10773
			INSMidcoursePlusPassiveTerminalGuidance,
			// Token: 0x04002A16 RID: 10774
			const_5,
			// 末端主动导引
			ActiveTerminalGuidance,
			// Token: 0x04002A18 RID: 10776
			const_7,
			// Token: 0x04002A19 RID: 10777
			InertialMidCoursePlusActiveTerminalGuidance,
			// 指令制导
			CommandGuided,
			// TVM，通过导弹制导
			TrackViaMissile,
			// 驾束
			BeamRiding,
			// 惯性制导
			InertiallyGuided,
			// 中段半主动加末端主动制导
			SemiActiveMidCoursePlusActiveTerminalGuidance,
			// Token: 0x04002A1F RID: 10783
			TimeSharedSemiActiveMidCoursePlusActiveTerminalGuidance
		}

		// 搜索模式
		public enum _SearchPatternType : byte
		{
			// Token: 0x04002A21 RID: 10785
			const_0,
			// Token: 0x04002A22 RID: 10786
			const_1,
			// Token: 0x04002A23 RID: 10787
			const_2
		}

		// 爆炸
		public enum _DetonationMedium : byte
		{
			// 空中爆炸
			Air,
			// 水面
			WaterSurface,
			// 水下
			Underwater,
			// 地下
			Underground,
			// Token: 0x04002A29 RID: 10793
			const_4
		}

		// 武器代码？？
		public struct WeaponCode
		{
			// Token: 0x04002A2A RID: 10794
			public bool IlluminateAtLaunch;

			// 末端照射
			public bool TerminalIllumination;

			// 伙伴照射
			public bool SupportsBuddyIllumination;

			// Token: 0x04002A2D RID: 10797
			public bool HomeOnJam;

			// Token: 0x04002A2E RID: 10798
			public bool AntiAir_SternChase;

			// Token: 0x04002A2F RID: 10799
			public bool AntiAir_RearAspect;

			// Token: 0x04002A30 RID: 10800
			public bool AntiAir_AllAspect;

			// Token: 0x04002A31 RID: 10801
			public bool AntiAir_Dogfight_HighOffBoresight;

			// Token: 0x04002A32 RID: 10802
			public bool NoDivingTargetMod;

			// Token: 0x04002A33 RID: 10803
			public bool CapableVsSeaskimmer;

			// Token: 0x04002A34 RID: 10804
			public bool ARMTargetMemory;

			// Token: 0x04002A35 RID: 10805
			public bool ARMLoiterCapability;

			// Token: 0x04002A36 RID: 10806
			public bool SearchPattern;

			// Token: 0x04002A37 RID: 10807
			public bool DriveThroughLogic;

			// Token: 0x04002A38 RID: 10808
			public bool BOLCapable;

			// 弹道导弹
			public bool BallisticMissile;

			// 地形跟随
			public bool TerrainFollowing;

			// Token: 0x04002A3B RID: 10811
			public bool Counter_RocketArtyMortar_Capable;

			// Token: 0x04002A3C RID: 10812
			public bool LockOnAfterLaunch;

			// Token: 0x04002A3D RID: 10813
			public bool LockOnAfterLaunch_CEC_Capable;

			// Token: 0x04002A3E RID: 10814
			public bool Pod_TerrainAvoidance;

			// Token: 0x04002A3F RID: 10815
			public bool Pod_TerrainFollowing;

			// Token: 0x04002A40 RID: 10816
			public bool Pod_DayOnlyNavigation;

			// Token: 0x04002A41 RID: 10817
			public bool Pod_DayOnlyNavigationAndAttack;

			// Token: 0x04002A42 RID: 10818
			public bool Pod_NightNavigation;

			// Token: 0x04002A43 RID: 10819
			public bool Pod_NightNavigationAndAttack;

			// Token: 0x04002A44 RID: 10820
			public bool Pod_Recon_DayOnly;

			// Token: 0x04002A45 RID: 10821
			public bool Pod_Recon_NightCapable;

			// Token: 0x04002A46 RID: 10822
			public bool Weapon_INSNavigation;

			// Token: 0x04002A47 RID: 10823
			public bool Weapon_INS_w_GPSNavigation;

			// Token: 0x04002A48 RID: 10824
			public bool Weapon_TERCOMNavigation;

			// Token: 0x04002A49 RID: 10825
			public bool Weapon_PreBriefedTargetOnly;

			// Token: 0x04002A4A RID: 10826
			public bool Weapon_ImagingSeeker;

			// Token: 0x04002A4B RID: 10827
			public bool Mine_ContactFuze;

			// Token: 0x04002A4C RID: 10828
			public bool Mine_MagneticFuze_SimpleMagnetic;

			// Token: 0x04002A4D RID: 10829
			public bool Mine_MagneticFuze_TotalFieldMagnetometer;

			// Token: 0x04002A4E RID: 10830
			public bool Mine_PassiveAcousticFuze_BroadBand;

			// Token: 0x04002A4F RID: 10831
			public bool Mine_PassiveAcousticFuze_NarrowBand;

			// Token: 0x04002A50 RID: 10832
			public bool Mine_PressureFuze;

			// Token: 0x04002A51 RID: 10833
			public bool Mine_SeismicFuze;

			// Token: 0x04002A52 RID: 10834
			public bool Mine_DelayCounter;

			// Token: 0x04002A53 RID: 10835
			public bool Mine_ArmingDelay;

			// Token: 0x04002A54 RID: 10836
			public bool Mine_TargetDiscriminationAndIdentification;

			// Token: 0x04002A55 RID: 10837
			public bool Mine_RemoteControlled;

			// Token: 0x04002A56 RID: 10838
			public bool Warhead_SingleReEntryVehicle;

			// Token: 0x04002A57 RID: 10839
			public bool Warhead_MultipleReEntryVehicles;

			// Token: 0x04002A58 RID: 10840
			public bool Warhead_MultipleIndependentReEntryVehicles;

			// Token: 0x04002A59 RID: 10841
			public bool CapableVsMobileLandUnit;

			// Token: 0x04002A5A RID: 10842
			public bool IsRetardedMunition;

			// Token: 0x04002A5B RID: 10843
			public bool Torpedo_StraightRunning;

			// Token: 0x04002A5C RID: 10844
			public bool Torpedo_WakeHoming;

			// Token: 0x04002A5D RID: 10845
			public bool Torpedo_StraightRunningAndTimeDetonation;

			// Token: 0x04002A5E RID: 10846
			public bool Torpedo_PatternRunning;

			// Token: 0x04002A5F RID: 10847
			public bool LevelCruiseFlight;

			// Token: 0x04002A60 RID: 10848
			public bool TerminalManeuver_Popup;

			// Token: 0x04002A61 RID: 10849
			public bool TerminalManeuver_Zigzag;

			// Token: 0x04002A62 RID: 10850
			public bool TerminalManeuver_Random;

			// Token: 0x04002A63 RID: 10851
			public bool ReAttackCapability;
		}

		// Token: 0x02000A9A RID: 2714
		public enum _ASMode
		{
			// Token: 0x04002A65 RID: 10853
			const_0,
			// Token: 0x04002A66 RID: 10854
			HighAltitudeDetonation
		}

		// 反辐射导弹目标
		[CompilerGenerated]
		public sealed class ARMTarget
		{
			// 该目标是否某反辐射导弹的攻击对象
			internal bool IsTargetFor(ActiveUnit theARM_)
			{
				return theARM_.GetAI().GetPrimaryTarget() == this.theTarget && ((Weapon)theARM_).ARM_SpecifiedEmission.Key == this.TargetRadarID;
			}

			// 目标航迹
			public Contact theTarget;

			// 目标雷达ID
			public int TargetRadarID;
		}

		// Token: 0x02000A9C RID: 2716
		[CompilerGenerated]
		public sealed class Class220
		{
			// Token: 0x06005622 RID: 22050 RVA: 0x00027769 File Offset: 0x00025969
			public Class220(Weapon.Class220 class220_0)
			{
				if (class220_0 != null)
				{
					this.float_0 = class220_0.float_0;
				}
			}

			// Token: 0x06005623 RID: 22051 RVA: 0x0024DA5C File Offset: 0x0024BC5C
			internal bool method_0(KeyValuePair<int, EmissionContainer> keyValuePair_0)
			{
				bool result;
				if (keyValuePair_0.Value.elapsedTime > this.float_0)
				{
					result = false;
				}
				else if (!this._ARMTargetMan.EmissionContainerDictionary[keyValuePair_0.Key].bool_0)
				{
					int key = keyValuePair_0.Key;
					SQLiteConnection sQLiteConnection = this._ARMTargetMan.theWeapon.m_Scenario.GetSQLiteConnection();
					result = DBFunctions.LoadSensorData(key, ref sQLiteConnection).NonSearchAndTrackSensorOtherThanMCMAndMAD();
				}
				else
				{
					result = true;
				}
				return result;
			}

			// Token: 0x06005624 RID: 22052 RVA: 0x0024DAD8 File Offset: 0x0024BCD8
			internal bool method_1(KeyValuePair<int, EmissionContainer> EmissionContainerPair)
			{
				bool result;
				if (EmissionContainerPair.Value.elapsedTime <= this.float_0)
				{
					int key = EmissionContainerPair.Key;
					SQLiteConnection sQLiteConnection = this._ARMTargetMan.theWeapon.m_Scenario.GetSQLiteConnection();
					result = DBFunctions.LoadSensorData(key, ref sQLiteConnection).IsWeaponDirector();
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x06005625 RID: 22053 RVA: 0x0024DB2C File Offset: 0x0024BD2C
			internal bool method_2(KeyValuePair<int, EmissionContainer> keyValuePair_0)
			{
				bool result;
				if (keyValuePair_0.Value.elapsedTime <= this.float_0)
				{
					int key = keyValuePair_0.Key;
					SQLiteConnection sQLiteConnection = this._ARMTargetMan.theWeapon.m_Scenario.GetSQLiteConnection();
					result = DBFunctions.LoadSensorData(key, ref sQLiteConnection).IsAirSearchRadar();
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x06005626 RID: 22054 RVA: 0x0024DB80 File Offset: 0x0024BD80
			internal bool method_3(KeyValuePair<int, EmissionContainer> keyValuePair_0)
			{
				bool result;
				if (keyValuePair_0.Value.elapsedTime <= this.float_0)
				{
					int key = keyValuePair_0.Key;
					SQLiteConnection sQLiteConnection = this._ARMTargetMan.theWeapon.m_Scenario.GetSQLiteConnection();
					result = DBFunctions.LoadSensorData(key, ref sQLiteConnection).HasOffensiveECMSensorRole();
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x06005627 RID: 22055 RVA: 0x0024DBD4 File Offset: 0x0024BDD4
			internal bool method_4(KeyValuePair<int, EmissionContainer> keyValuePair_0)
			{
				bool result;
				if (keyValuePair_0.Value.elapsedTime <= this.float_0)
				{
					if (!this._ARMTargetMan.EmissionContainerDictionary[keyValuePair_0.Key].bool_0)
					{
						int key = keyValuePair_0.Key;
						SQLiteConnection sQLiteConnection = this._ARMTargetMan.theWeapon.m_Scenario.GetSQLiteConnection();
						if (!DBFunctions.LoadSensorData(key, ref sQLiteConnection).NonSearchAndTrackSensorOtherThanMCMAndMAD())
						{
							int key2 = keyValuePair_0.Key;
							sQLiteConnection = this._ARMTargetMan.theWeapon.m_Scenario.GetSQLiteConnection();
							if (!DBFunctions.LoadSensorData(key2, ref sQLiteConnection).IsWeaponDirector())
							{
								int key3 = keyValuePair_0.Key;
								sQLiteConnection = this._ARMTargetMan.theWeapon.m_Scenario.GetSQLiteConnection();
								if (!DBFunctions.LoadSensorData(key3, ref sQLiteConnection).IsAirSearchRadar())
								{
									int key4 = keyValuePair_0.Key;
									sQLiteConnection = this._ARMTargetMan.theWeapon.m_Scenario.GetSQLiteConnection();
									result = DBFunctions.LoadSensorData(key4, ref sQLiteConnection).HasOffensiveECMSensorRole();
									return result;
								}
							}
						}
					}
					result = true;
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x06005628 RID: 22056 RVA: 0x0024DCE0 File Offset: 0x0024BEE0
			internal bool method_5(KeyValuePair<int, EmissionContainer> keyValuePair_0)
			{
				bool result;
				if (keyValuePair_0.Value.elapsedTime <= this.float_0)
				{
					int key = keyValuePair_0.Key;
					SQLiteConnection sQLiteConnection = this._ARMTargetMan.theWeapon.m_Scenario.GetSQLiteConnection();
					if (!DBFunctions.LoadSensorData(key, ref sQLiteConnection).NonSearchAndTrackSensorOtherThanMCMAndMAD() && !this._ARMTargetMan.EmissionContainerDictionary[keyValuePair_0.Key].bool_0)
					{
						int key2 = keyValuePair_0.Key;
						sQLiteConnection = this._ARMTargetMan.theWeapon.m_Scenario.GetSQLiteConnection();
						if (!DBFunctions.LoadSensorData(key2, ref sQLiteConnection).IsWeaponDirector())
						{
							int key3 = keyValuePair_0.Key;
							sQLiteConnection = this._ARMTargetMan.theWeapon.m_Scenario.GetSQLiteConnection();
							result = DBFunctions.LoadSensorData(key3, ref sQLiteConnection).IsAirSearchRadar();
							return result;
						}
					}
					result = true;
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x04002A69 RID: 10857
			public float float_0;

			// Token: 0x04002A6A RID: 10858
			public Weapon.ARMTargetMan _ARMTargetMan;
		}

		// 反辐射导弹目标？？？
		[CompilerGenerated]
		public sealed class ARMTargetMan
		{
			// 构造函数
			public ARMTargetMan(Weapon.ARMTargetMan ARMTargetMan_)
			{
				if (ARMTargetMan_ != null)
				{
					this.EmissionContainerDictionary = ARMTargetMan_.EmissionContainerDictionary;
					this.theSide = ARMTargetMan_.theSide;   // 所属方
					this.theTarget = ARMTargetMan_.theTarget;   // 目标（Contract）
				}
			}

			// 攻击目标雷达的反辐射导弹数量
			internal int GetNumOfARMsForTargetRadar(KeyValuePair<int, EmissionContainer> EmissionContainerPair_)
			{
				return this.theWeapon.GetNumOfARMsInSideForTargetRadar(this.theSide, this.theTarget, EmissionContainerPair_.Key);
			}

			// Token: 0x0600562B RID: 22059 RVA: 0x0024DDBC File Offset: 0x0024BFBC
			internal int GetNumOfARMsForTargetRadar1(KeyValuePair<int, EmissionContainer> EmissionContainer_)
			{
				return this.theWeapon.GetNumOfARMsInSideForTargetRadar(this.theSide, this.theTarget, EmissionContainer_.Key);
			}

			// Token: 0x04002A6B RID: 10859
			public ObservableDictionary<int, EmissionContainer> EmissionContainerDictionary;

			// Token: 0x04002A6C RID: 10860
			public Side theSide;

			// Token: 0x04002A6D RID: 10861
			public Contact theTarget;

			// Token: 0x04002A6E RID: 10862
			public Weapon theWeapon;
		}

		// Token: 0x02000A9E RID: 2718
		[CompilerGenerated]
		public sealed class WeaponDirector
		{
			// Token: 0x0600562C RID: 22060 RVA: 0x0024DDEC File Offset: 0x0024BFEC
			internal double GeAngularDistance(ActiveUnit activeUnit_)
			{
				return activeUnit_.GetApproxAngularDistanceInDegrees(new GeoPoint(this.theTarget.GetLongitude(null), this.theTarget.GetLatitude(null)));
			}

			// Token: 0x04002A6F RID: 10863
			public Contact theTarget;

			// Token: 0x04002A70 RID: 10864
			public Sensor Director;

			// Token: 0x04002A71 RID: 10865
			public Weapon theWeapon;
		}

		// Token: 0x02000A9F RID: 2719
		[CompilerGenerated]
		public sealed class Illuminator
		{
			// Token: 0x0600562E RID: 22062 RVA: 0x0024DE30 File Offset: 0x0024C030
			internal bool IsIlluminating(ActiveUnit activeUnit_)
			{
				return activeUnit_.GetSensory().IsIlluminating(this.weaponDirector.theTarget, this.weaponDirector.theWeapon, ref this.weaponDirector.Director, ref this.LOS_Exists_Radar, ref this.LOS_Exists_RadarSW, ref this.LOS_Exists_Visual, ref this.LOS_Exists_Sonar);
			}

			// Token: 0x04002A72 RID: 10866
			public bool? LOS_Exists_Radar;

			// Token: 0x04002A73 RID: 10867
			public bool? LOS_Exists_RadarSW;

			// Token: 0x04002A74 RID: 10868
			public Unit._LOS_Exists_Visual? LOS_Exists_Visual;

			// Token: 0x04002A75 RID: 10869
			public bool? LOS_Exists_Sonar;

			// Token: 0x04002A76 RID: 10870
			public Weapon.WeaponDirector weaponDirector;
		}
	}
}
