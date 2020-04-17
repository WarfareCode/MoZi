using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace Command_Core
{
	// Token: 引擎、发动机
	public sealed class Engine : PlatformComponent
	{
		// Token: 0x06005B2C RID: 23340 RVA: 0x00289250 File Offset: 0x00287450
		internal static float? method_1(AltBand altBand_0)
		{
			float num = (float)altBand_0.Speed_Loiter;
			float? consumption_Full = altBand_0.Consumption_Full;
			float? result;
			if (!consumption_Full.HasValue)
			{
				result = null;
			}
			else
			{
				result = new float?(num / consumption_Full.GetValueOrDefault());
			}
			return result;
		}

		// Token: 0x06005B2D RID: 23341 RVA: 0x00289294 File Offset: 0x00287494
		internal static float? method_7(AltBand altBand_0)
		{
			long? speed_Full = altBand_0.Speed_Full;
			float? num = speed_Full.HasValue ? new float?((float)speed_Full.GetValueOrDefault()) : null;
			float? consumption_Full = altBand_0.Consumption_Full;
			float? result;
			if (!(num.HasValue & consumption_Full.HasValue))
			{
				result = null;
			}
			else
			{
				result = new float?(num.GetValueOrDefault() / consumption_Full.GetValueOrDefault());
			}
			return result;
		}

		// Token: 0x06005B2E RID: 23342 RVA: 0x00289308 File Offset: 0x00287508
		internal static float? method_9(AltBand altBand_0)
		{
			long? speed_Flank = altBand_0.Speed_Flank;
			float? num = speed_Flank.HasValue ? new float?((float)speed_Flank.GetValueOrDefault()) : null;
			float? consumption_Flank = altBand_0.Consumption_Flank;
			float? result;
			if (!(num.HasValue & consumption_Flank.HasValue))
			{
				result = null;
			}
			else
			{
				result = new float?(num.GetValueOrDefault() / consumption_Flank.GetValueOrDefault());
			}
			return result;
		}

		// Token: 0x06005B2F RID: 23343 RVA: 0x0028937C File Offset: 0x0028757C
		public override void ClearGuid()
		{
			base.ClearGuid();
			AltBand[] array = this.altBands;
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i].ClearGuid();
				}
			}
		}

		// Token: 0x06005B30 RID: 23344 RVA: 0x002893B0 File Offset: 0x002875B0
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Engine");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (hashSet_0.Contains(base.GetGuid()))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(base.GetGuid());
					xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
					xmlWriter_0.WriteElementString("Name", this.Name);
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Status";
					byte componentStatus = (byte)this.m_ComponentStatus;
					xmlWriter.WriteElementString(localName, componentStatus.ToString());
					xmlWriter_0.WriteElementString("DamageSeverity", ((byte)base.GetDamageSeverity()).ToString());
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100669", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B31 RID: 23345 RVA: 0x00028F40 File Offset: 0x00027140
		private Engine() : base(null)
		{
			this.altBands = new AltBand[0];
		}

		// Token: 0x06005B32 RID: 23346 RVA: 0x002894C0 File Offset: 0x002876C0
		public static Engine Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Engine engine4;
			Engine result;
			try
			{
				Engine engine = new Engine();
				engine.SetParentPlatform(activeUnit_1);
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "Name", false) != 0)
							{
								if (Operators.CompareString(name, "Status", false) != 0)
								{
									if (Operators.CompareString(name, "DamageSeverity", false) != 0)
									{
										if (Operators.CompareString(name, "DBID", false) == 0)
										{
											int int_ = Conversions.ToInteger(xmlNode.InnerText);
											Engine engine2;
											ActiveUnit parentPlatform = (engine2 = engine).GetParentPlatform();
											Engine engine3 = DBFunctions.LoadPropulsionData(int_, ref parentPlatform);
											engine2.SetParentPlatform(parentPlatform);
											engine3.SetGuid(engine.GetGuid());
											engine3.m_ComponentStatus = engine.GetComponentStatus();
											engine3.Name = engine.Name;
											engine = engine3;
										}
									}
									else
									{
										engine.SetDamageSeverity((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode.InnerText));
									}
								}
								else
								{
									string innerText = xmlNode.InnerText;
									if (Operators.CompareString(innerText, "Operational", false) != 0)
									{
										if (Operators.CompareString(innerText, "Damaged", false) != 0)
										{
											if (Operators.CompareString(innerText, "Destroyed", false) != 0)
											{
												engine.m_ComponentStatus = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode.InnerText);
											}
											else
											{
												engine.m_ComponentStatus = PlatformComponent._ComponentStatus.Destroyed;
											}
										}
										else
										{
											engine.m_ComponentStatus = PlatformComponent._ComponentStatus.Damaged;
										}
									}
									else
									{
										engine.m_ComponentStatus = PlatformComponent._ComponentStatus.Operational;
									}
								}
							}
							else
							{
								engine.Name = xmlNode.InnerText;
							}
						}
						else
						{
							if (dictionary_0.ContainsKey(xmlNode.InnerText))
							{
								engine4 = (Engine)dictionary_0[xmlNode.InnerText];
								result = engine4;
								return result;
							}
							engine.SetGuid(xmlNode.InnerText);
							dictionary_0.Add(engine.GetGuid(), engine);
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
				engine4 = engine;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100670", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				engine4 = new Engine();
				ProjectData.ClearProjectError();
			}
			result = engine4;
			return result;
		}

		// Token: 0x06005B33 RID: 23347 RVA: 0x00289744 File Offset: 0x00287944
		public AltBand GetAltBand(ActiveUnit.Throttle throttle_)
		{
			AltBand result;
			switch (throttle_)
			{
			case ActiveUnit.Throttle.FullStop:
				result = this.altBands.Select(Engine.AltBandFunc0).OrderByDescending(Engine.AltBandFunc1).ElementAtOrDefault(0);
				break;
			case ActiveUnit.Throttle.Loiter:
				result = this.altBands.Select(Engine.AltBandFunc2).OrderByDescending(Engine.AltBandFunc3).ElementAtOrDefault(0);
				break;
			case ActiveUnit.Throttle.Cruise:
				result = this.altBands.Select(Engine.AltBandFunc4).OrderByDescending(Engine.AltBandFunc5).ElementAtOrDefault(0);
				break;
			case ActiveUnit.Throttle.Full:
				result = this.altBands.Select(Engine.AltBandFunc6).OrderByDescending(Engine.AltBandFunc7).ElementAtOrDefault(0);
				break;
			case ActiveUnit.Throttle.Flank:
				result = this.altBands.Select(Engine.AltBandFunc8).OrderByDescending(Engine.AltBandFunc9).ElementAtOrDefault(0);
				break;
			default:
				if (this.altBands.Length > 0)
				{
					result = this.altBands[this.altBands.Length - 1];
				}
				else
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = null;
				}
				break;
			}
			return result;
		}

		// Token: 0x06005B34 RID: 23348 RVA: 0x00289860 File Offset: 0x00287A60
		public bool IsFueTypeSuitable(FuelRec._FuelType FuelType_)
		{
			Engine._PropulsionType propulsionType = this.PropulsionType;
			bool result;
			if (propulsionType <= Engine._PropulsionType.GasTurbine)
			{
				if (propulsionType == Engine._PropulsionType.Turbojet || propulsionType == Engine._PropulsionType.Turbofan || propulsionType == Engine._PropulsionType.Turboprop || propulsionType == Engine._PropulsionType.HeloTurboshaft)
				{
					result = (FuelType_ == FuelRec._FuelType.AviationFuel);
					return result;
				}
				switch (propulsionType)
				{
				case Engine._PropulsionType.Diesel:
					result = (FuelType_ == FuelRec._FuelType.DieselFuel);
					return result;
				case Engine._PropulsionType.Steam:
					result = (FuelType_ == FuelRec._FuelType.OilFuel);
					return result;
				case Engine._PropulsionType.GasTurbine:
					result = (FuelType_ == FuelRec._FuelType.GasFuel);
					return result;
				}
			}
			else
			{
				if (propulsionType == Engine._PropulsionType.Electric)
				{
					result = (FuelType_ == FuelRec._FuelType.Battery);
					return result;
				}
				if (propulsionType == Engine._PropulsionType.AirIndependent)
				{
					result = (FuelType_ == FuelRec._FuelType.AirIndepedent);
					return result;
				}
				switch (propulsionType)
				{
				case Engine._PropulsionType.Rocket:
					result = (FuelType_ == FuelRec._FuelType.RocketFuel);
					return result;
				case Engine._PropulsionType.TorpedoEngine:
					result = (FuelType_ == FuelRec._FuelType.RocketFuel);
					return result;
				case Engine._PropulsionType.WeaponCoast:
					result = (FuelType_ == FuelRec._FuelType.WeaponCoast);
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06005B35 RID: 23349 RVA: 0x00028F55 File Offset: 0x00027155
		public Engine(ActiveUnit activeUnit_1, int DBID_, string Name_, Engine._PropulsionType PropulsionType_) : base(activeUnit_1)
		{
			this.altBands = new AltBand[0];
			this.DBID = DBID_;
			this.Name = Name_;
			this.PropulsionType = PropulsionType_;
		}

		// Token: 0x04002E51 RID: 11857
		public static Func<AltBand, AltBand> AltBandFunc0 = (AltBand altBand_0) => altBand_0;

		// Token: 0x04002E52 RID: 11858
		public static Func<AltBand, float?> AltBandFunc1 = (AltBand altBand_0) => Engine.method_1(altBand_0);

		// Token: 0x04002E53 RID: 11859
		public static Func<AltBand, AltBand> AltBandFunc2 = (AltBand altBand_0) => altBand_0;

		// Token: 0x04002E54 RID: 11860
		public static Func<AltBand, float> AltBandFunc3 = (AltBand altBand_0) => (float)altBand_0.Speed_Loiter / altBand_0.Consumption_Loiter;

		// Token: 0x04002E55 RID: 11861
		public static Func<AltBand, AltBand> AltBandFunc4 = (AltBand altBand_0) => altBand_0;

		// Token: 0x04002E56 RID: 11862
		public static Func<AltBand, float> AltBandFunc5 = (AltBand altBand_0) => (float)altBand_0.Speed_Cruise / altBand_0.Consumption_Cruise;

		// Token: 0x04002E57 RID: 11863
		public static Func<AltBand, AltBand> AltBandFunc6 = (AltBand altBand_0) => altBand_0;

		// Token: 0x04002E58 RID: 11864
		public static Func<AltBand, float?> AltBandFunc7 = (AltBand altBand_0) => Engine.method_7(altBand_0);

		// Token: 0x04002E59 RID: 11865
		public static Func<AltBand, AltBand> AltBandFunc8 = (AltBand altBand_0) => altBand_0;

		// Token: 0x04002E5A RID: 11866
		public static Func<AltBand, float?> AltBandFunc9 = (AltBand altBand_0) => Engine.method_9(altBand_0);

		// Token: 0x04002E5B RID: 11867
		public Engine._PropulsionType PropulsionType;

		// Token: 0x04002E5C RID: 11868
		public AltBand[] altBands;

		// Token: 0x04002E5D RID: 11869
		public bool Hypothetical;

		// Token: 0x02000B11 RID: 2833
		public enum _PropulsionType : short
		{
			// Token: 0x04002E69 RID: 11881
			None = 1001,
			// Token: 0x04002E6A RID: 11882
			Turbojet = 2001,
			// Token: 0x04002E6B RID: 11883
			Turbofan,
			// Token: 0x04002E6C RID: 11884
			Turboprop,
			// Token: 0x04002E6D RID: 11885
			Piston,
			// Token: 0x04002E6E RID: 11886
			HeloTurboshaft,
			// Token: 0x04002E6F RID: 11887
			Diesel = 3001,
			// Token: 0x04002E70 RID: 11888
			Steam,
			// Token: 0x04002E71 RID: 11889
			GasTurbine,
			// Token: 0x04002E72 RID: 11890
			Nuclear,
			// Token: 0x04002E73 RID: 11891
			Electric = 4001,
			// Token: 0x04002E74 RID: 11892
			AirIndependent,
			// Token: 0x04002E75 RID: 11893
			Rocket = 5001,
			// Token: 0x04002E76 RID: 11894
			TorpedoEngine,
			// Token: 0x04002E77 RID: 11895
			WeaponCoast
		}
	}
}
