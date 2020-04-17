using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: baoz
	public sealed class Explosion : Unit
	{
		// Token: 0x06005FDD RID: 24541 RVA: 0x002D454C File Offset: 0x002D274C
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Explosion");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (hashSet_0.Contains(base.GetGuid()))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(base.GetGuid());
					xmlWriter_0.WriteElementString("Name", this.Name);
					xmlWriter_0.WriteElementString("CH", XmlConvert.ToString(this.GetCurrentHeading()));
					xmlWriter_0.WriteElementString("CA", XmlConvert.ToString(this.GetCurrentAltitude_ASL(false)));
					xmlWriter_0.WriteElementString("Lon", XmlConvert.ToString(this.GetLongitude(null)));
					xmlWriter_0.WriteElementString("Lat", XmlConvert.ToString(this.GetLatitude(null)));
					xmlWriter_0.WriteElementString("Lon_Graphics", XmlConvert.ToString(this.GetLon_Graphics()));
					xmlWriter_0.WriteElementString("Lat_Graphics", XmlConvert.ToString(this.GetLat_Graphics()));
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
					if (!string.IsNullOrEmpty(this.Message))
					{
						xmlWriter_0.WriteElementString("Message", this.Message);
					}
					xmlWriter_0.WriteElementString("Yield", XmlConvert.ToString(this.ExplosiveYield));
					xmlWriter_0.WriteElementString("Yield_Graphics", XmlConvert.ToString(this.Yield_Graphics));
					xmlWriter_0.WriteElementString("TTL", XmlConvert.ToString(this.TTL));
					if (!Information.IsNothing(this.MaxD))
					{
						xmlWriter_0.WriteElementString("MaxD", XmlConvert.ToString(this.MaxD.Value));
					}
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Type";
					int num = (int)this.warheadType;
					xmlWriter.WriteElementString(localName, num.ToString());
					XmlWriter xmlWriter2 = xmlWriter_0;
					string localName2 = "ExpType";
					short expType = (short)this.ExpType;
					xmlWriter2.WriteElementString(localName2, expType.ToString());
					if (!Information.IsNothing(this.DirectImpactUnit))
					{
						xmlWriter_0.WriteElementString("_DirectImpactUnit", this.DirectImpactUnit.GetGuid());
					}
					if (!Information.IsNothing(this.DirectImpactAimpoint))
					{
						xmlWriter_0.WriteElementString("_DirectImpactAimpoint", this.DirectImpactAimpoint.GetGuid());
					}
					if (!Information.IsNothing(this.ExcludedUnit))
					{
						xmlWriter_0.WriteElementString("_ExcludedUnit", this.ExcludedUnit.GetGuid());
					}
					xmlWriter_0.WriteElementString("_ExcludedAimPointID", this.ExcludedAimPointID);
					if (!Information.IsNothing(this.ExcludedAimpoint))
					{
						xmlWriter_0.WriteElementString("_ExcludedAimpoint", this.ExcludedAimpoint.GetGuid());
					}
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100842", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005FDE RID: 24542 RVA: 0x002D48A0 File Offset: 0x002D2AA0
		public static Explosion Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0)
		{
			Explosion explosion = null;
			Explosion result;
			try
			{
				Explosion explosion2 = new Explosion();
				explosion2.warheadType = Warhead.WarheadType.HE_BlastFrag;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 2035017543u)
						{
							if (num <= 1458105184u)
							{
								if (num <= 1063775611u)
								{
									if (num != 266367750u)
									{
										if (num != 441941816u)
										{
											if (num == 1063775611u && Operators.CompareString(name, "TTL", false) == 0)
											{
												explosion2.TTL = XmlConvert.ToDouble(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "CurrentAltitude", false) != 0)
											{
												continue;
											}
											goto IL_401;
										}
									}
									else
									{
										if (Operators.CompareString(name, "Name", false) == 0)
										{
											explosion2.Name = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num != 1091296846u)
								{
									if (num != 1213695817u)
									{
										if (num != 1458105184u || Operators.CompareString(name, "ID", false) != 0)
										{
											continue;
										}
										if (!dictionary_0.ContainsKey(xmlNode.InnerText))
										{
											explosion2.SetGuid(xmlNode.InnerText);
											continue;
										}
										explosion = (Explosion)dictionary_0[xmlNode.InnerText];
										result = explosion;
										return result;
									}
									else
									{
										if (Operators.CompareString(name, "_ExcludedAimPoint", false) == 0)
										{
											explosion2.ExcludedAimPointID = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "Yield", false) == 0)
									{
										explosion2.ExplosiveYield = XmlConvert.ToDouble(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 1836990821u)
							{
								if (num != 1564175899u)
								{
									if (num != 1729717486u)
									{
										if (num != 1836990821u)
										{
											continue;
										}
										if (Operators.CompareString(name, "Latitude", false) != 0)
										{
											continue;
										}
										goto IL_47C;
									}
									else if (Operators.CompareString(name, "Longitude", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "Latitude_Graphics", false) == 0)
									{
										explosion2.method_55(XmlConvert.ToDouble(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num != 1905141184u)
							{
								if (num != 2010780873u)
								{
									if (num == 2035017543u && Operators.CompareString(name, "MaxD", false) == 0)
									{
										explosion2.MaxD = new float?(XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "CA", false) == 0)
									{
										explosion2.SetAltitude_ASL(false, XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "ExpType", false) == 0)
								{
									explosion2.ExpType = (Warhead._ExplosivesType)Conversions.ToShort(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 3019778271u)
						{
							if (num <= 2564648390u)
							{
								if (num != 2128224206u)
								{
									if (num != 2496321123u)
									{
										if (num == 2564648390u && Operators.CompareString(name, "Lon", false) == 0)
										{
											goto IL_358;
										}
										continue;
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
												explosion2.GetRangeSymbols().Add(item);
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
								if (Operators.CompareString(name, "CH", false) == 0)
								{
									goto IL_401;
								}
								continue;
							}
							else if (num != 2920208772u)
							{
								if (num != 3001749054u)
								{
									if (num == 3019778271u && Operators.CompareString(name, "_DirectImpactUnit", false) == 0)
									{
										explosion2.string_4 = xmlNode.InnerText;
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Lat", false) == 0)
									{
										goto IL_47C;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Message", false) == 0)
								{
									explosion2.Message = xmlNode.InnerText;
									continue;
								}
								continue;
							}
						}
						else if (num <= 3512062061u)
						{
							if (num != 3281247622u)
							{
								if (num != 3311729638u)
								{
									if (num != 3512062061u || Operators.CompareString(name, "Type", false) != 0)
									{
										continue;
									}
									explosion2.warheadType = (Warhead.WarheadType)Conversions.ToInteger(xmlNode.InnerText);
									if (Versioned.IsNumeric(xmlNode.InnerText))
									{
										explosion2.warheadType = (Warhead.WarheadType)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									explosion2.warheadType = (Warhead.WarheadType)Enum.Parse(typeof(Warhead.WarheadType), xmlNode.InnerText, true);
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Yield_Graphics", false) == 0)
									{
										explosion2.Yield_Graphics = XmlConvert.ToDouble(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Longitude_Graphics", false) == 0)
								{
									explosion2.method_53(XmlConvert.ToDouble(xmlNode.InnerText));
									continue;
								}
								continue;
							}
						}
						else if (num != 3569830189u)
						{
							if (num != 3680159696u)
							{
								if (num == 3891284906u && Operators.CompareString(name, "_ExcludedUnit", false) == 0)
								{
									explosion2.ExcludedUnitName = xmlNode.InnerText;
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "_DirectImpactAimpoint", false) == 0)
								{
									explosion2.DirectImpactAimpointName = xmlNode.InnerText;
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "Duration", false) == 0)
							{
								explosion2.TTL = XmlConvert.ToDouble(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						IL_358:
						explosion2.SetLongitude(null, XmlConvert.ToDouble(xmlNode.InnerText));
						continue;
						IL_401:
						explosion2.SetCurrentHeading(XmlConvert.ToSingle(xmlNode.InnerText));
						continue;
						IL_47C:
						explosion2.SetLatitude(null, XmlConvert.ToDouble(xmlNode.InnerText));
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				dictionary_0.Add(explosion2.GetGuid(), explosion2);
				explosion = explosion2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100843", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = explosion;
			return result;
		}

		// Token: 0x06005FDF RID: 24543 RVA: 0x002D4FE8 File Offset: 0x002D31E8
		public double GetLon_Graphics()
		{
			return this.double_6;
		}

		// Token: 0x06005FE0 RID: 24544 RVA: 0x002D5000 File Offset: 0x002D3200
		public void method_53(double double_7)
		{
			if (double_7 > 180.0 || double_7 < -180.0)
			{
				double_7 = Math2.NormalizeLongitude(double_7);
			}
			if (double.IsNaN(double_7))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			else
			{
				this.double_6 = double_7;
			}
		}

		// Token: 0x06005FE1 RID: 24545 RVA: 0x002D5058 File Offset: 0x002D3258
		public double GetLat_Graphics()
		{
			return this.double_5;
		}

		// Token: 0x06005FE2 RID: 24546 RVA: 0x002D5070 File Offset: 0x002D3270
		public void method_55(double double_7)
		{
			if (double_7 > 90.0 || double_7 < -90.0)
			{
				double_7 = Math2.NormalizeLatitude(double_7);
			}
			if (double.IsNaN(double_7))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			else
			{
				this.double_5 = double_7;
			}
		}

		// Token: 0x06005FE3 RID: 24547 RVA: 0x002D50C8 File Offset: 0x002D32C8
		public void method_56(ref Dictionary<string, Subject> dictionary_0)
		{
			try
			{
				if (!Information.IsNothing(this.string_4))
				{
					this.DirectImpactUnit = (ActiveUnit)dictionary_0[this.string_4];
					this.DirectImpactAimpoint = (Mount)dictionary_0[this.DirectImpactAimpointName];
					this.ExcludedUnit = (ActiveUnit)dictionary_0[this.ExcludedUnitName];
					this.ExcludedAimpoint = (Mount)dictionary_0[this.ExcludedAimPointID];
				}
				if (!string.IsNullOrEmpty(this.ExcludedUnitName) && dictionary_0.ContainsKey(this.ExcludedUnitName))
				{
					this.ExcludedUnit = (ActiveUnit)dictionary_0[this.ExcludedUnitName];
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200040", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005FE4 RID: 24548 RVA: 0x0002A92F File Offset: 0x00028B2F
		private Explosion()
		{
			this.ExpType = Warhead._ExplosivesType.const_0;
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x002D51CC File Offset: 0x002D33CC
		public float GetMaxDuration()
		{
			float num3;
			float result;
			if (Information.IsNothing(this.MaxD))
			{
				double num = (double)base.GetAltitude_AGL();
				Warhead.WarheadType warheadType = this.warheadType;
				if (warheadType <= Warhead.WarheadType.DepthCharge)
				{
					if (warheadType != Warhead.WarheadType.HE_BlastFrag)
					{
						switch (warheadType)
						{
						case Warhead.WarheadType.SemiAP:
						case Warhead.WarheadType.HESH:
						case Warhead.WarheadType.HardTargetPenetrator:
							break;
						case Warhead.WarheadType.ContinuousRod:
						case Warhead.WarheadType.FAE:
							goto IL_201;
						case Warhead.WarheadType.SuperFrag:
							goto IL_1E4;
						default:
							if (warheadType - Warhead.WarheadType.Torpedo <= 1)
							{
								double num2 = (double)Explosion.smethod_1(this.ExplosiveYield, Weapon._DetonationMedium.Underwater);
								num3 = (float)Math.Max(2.0, num2 / 2916.0 * 3600.0);
								result = num3;
								return result;
							}
							goto IL_201;
						}
					}
				}
				else if (warheadType != Warhead.WarheadType.Nuclear)
				{
					if (warheadType - Warhead.WarheadType.Cluster_AP <= 2 || warheadType == Warhead.WarheadType.Cluster_SmartSubs)
					{
						goto IL_1E4;
					}
					goto IL_201;
				}
				double num4 = num;
				double num5 = 0.0;
				if (num4 >= 0.0)
				{
					num5 = (double)Explosion.smethod_1(this.ExplosiveYield, Weapon._DetonationMedium.Air);
				}
				else if (num4 < 0.0)
				{
					if (base.IsOnLand())
					{
						double num6 = (double)Explosion.smethod_1(this.ExplosiveYield, Weapon._DetonationMedium.Underground);
						num3 = (float)Math.Max(2.0, num6 / 5832.0 * 3600.0);
						result = num3;
						return result;
					}
					double num7 = (double)Explosion.smethod_1(this.ExplosiveYield, Weapon._DetonationMedium.Underwater);
					num3 = (float)Math.Max(2.0, num7 / 2916.0 * 3600.0);
					result = num3;
					return result;
				}
				num3 = (float)Math.Max(2.0, num5 / 661.0 * 3600.0);
				goto IL_1C5;
				IL_1E4:
				num3 = Math.Max(2f, this.GetCurrentAltitude_ASL(false) / 300f);
				result = num3;
				return result;
				IL_201:
				num3 = 0f;
				result = num3;
				return result;
			}
			num3 = this.MaxD.Value;
			IL_1C5:
			result = num3;
			return result;
		}

		// Token: 0x06005FE6 RID: 24550 RVA: 0x0002A942 File Offset: 0x00028B42
		public override bool IsUnderGround()
		{
			if (!this.bUnderGround.HasValue)
			{
				this.bUnderGround = new bool?(base.IsUnderGround());
			}
			return this.bUnderGround.Value;
		}

		// Token: 0x06005FE7 RID: 24551 RVA: 0x0002A96D File Offset: 0x00028B6D
		public override bool IsUnderWater()
		{
			if (!this.bUnderWater.HasValue)
			{
				this.bUnderWater = new bool?(base.IsUnderWater());
			}
			return this.bUnderWater.Value;
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x002D53E8 File Offset: 0x002D35E8
		public double GetTimeToLast()
		{
			return this.TTL;
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x0002A998 File Offset: 0x00028B98
		public bool IsTimeOut()
		{
			return this.TTL == (double)this.GetMaxDuration();
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x002D5400 File Offset: 0x002D3600
		public bool method_60()
		{
			Warhead.WarheadType warheadType = this.warheadType;
			return warheadType == Warhead.WarheadType.SuperFrag || warheadType - Warhead.WarheadType.Cluster_AP <= 2 || warheadType == Warhead.WarheadType.Cluster_SmartSubs;
		}

		// Token: 0x06005FEB RID: 24555 RVA: 0x002D5440 File Offset: 0x002D3640
		public void ProcessExplosion(ref Scenario scenario_, float elapsedTime_)
		{
			this.TTL += (double)elapsedTime_;
			double num = (double)this.GetMaxDuration();
			if (this.TTL > num)
			{
				this.TTL = num;
			}
			string text;
			if (!Information.IsNothing(this.ExcludedUnit))
			{
				text = this.ExcludedUnit.GetGuid();
			}
			else
			{
				text = this.ExcludedUnitName;
			}
			if (this.TTL == num && this.method_60())
			{
				this.method_74(scenario_, text);
			}
			if (this.TTL < num)
			{
				Warhead.WarheadType warheadType = this.warheadType;
				if (warheadType <= Warhead.WarheadType.HESH)
				{
					if (warheadType != Warhead.WarheadType.HE_BlastFrag && warheadType - Warhead.WarheadType.SemiAP > 1)
					{
						return;
					}
				}
				else if (warheadType != Warhead.WarheadType.HardTargetPenetrator && warheadType != Warhead.WarheadType.Torpedo && warheadType != Warhead.WarheadType.Nuclear)
				{
					return;
				}
				if (this.IsUnderWater())
				{
					this.ProcessExplosion(scenario_, text, Weapon._DetonationMedium.Underwater, this.warheadType, elapsedTime_);
				}
				else if (this.IsUnderGround())
				{
					this.ProcessExplosion(scenario_, text, Weapon._DetonationMedium.Underground, this.warheadType, elapsedTime_);
				}
				else
				{
					this.ProcessExplosion(scenario_, text, Weapon._DetonationMedium.Air, this.warheadType, elapsedTime_);
				}
			}
		}

		// Token: 0x06005FEC RID: 24556 RVA: 0x002D556C File Offset: 0x002D376C
		public Explosion(ref Scenario theScen, double theLongitude, double theLatitude, double theLongitude_Graphics, double theLatitude_Graphics, float theHeading, float theAltitude, float theExpYield, float theExpYield_Graphics, Warhead.WarheadType theWarheadType, Warhead._ExplosivesType theExplosiveType, ActiveUnit DirectImpactUnit = null, Mount DirectImpactAimpoint = null, ActiveUnit ExcludedUnit = null, Mount ExcludedAimPoint = null, float? ExplosionDuration = null, short theClusterCoverageLength = 0, short theClusterCoverageWidth = 0, int theClusterSubmunitionQty = 0, float theClusterSubmunitionYield = 0f, int ARM_TargetedRadar = 0)
		{
			this.ExpType = Warhead._ExplosivesType.const_0;
			try
			{
				this.SetLongitude(null, theLongitude);
				this.SetLatitude(null, theLatitude);
				this.method_53(theLongitude_Graphics);
				this.method_55(theLatitude_Graphics);
				this.SetAltitude_ASL(false, theAltitude);
				this.ExplosiveYield = (double)theExpYield;
				this.Yield_Graphics = (double)theExpYield_Graphics;
				this.warheadType = theWarheadType;
				this.ExpType = theExplosiveType;
				this.DirectImpactUnit = DirectImpactUnit;
				this.DirectImpactAimpoint = DirectImpactAimpoint;
				this.ExcludedUnit = ExcludedUnit;
				this.ExcludedAimpoint = ExcludedAimPoint;
				this.TTL = 0.0;
				base.ClearAltitudeData();
				this.ClusterCoverageLength = (int)theClusterCoverageLength;
				this.ClusterCoverageWidth = (int)theClusterCoverageWidth;
				this.ClusterSubmunitionQty = theClusterSubmunitionQty;
				this.float_7 = (float)(this.ExplosiveYield / (double)theClusterSubmunitionQty);
				if (!Information.IsNothing(this.ExcludedUnit))
				{
					this.ExcludedUnitName = this.ExcludedUnit.GetGuid();
				}
				else
				{
					this.ExcludedUnitName = "";
				}
				if (theWarheadType == Warhead.WarheadType.Nuclear)
				{
					this.method_71(ref theScen, this.ExcludedUnitName);
					this.method_72(ref theScen, this.ExcludedUnitName);
				}
				if (this.method_62())
				{
					if (this.ExplosiveYield > 0.0)
					{
						Explosion explosion = new Explosion(ref theScen, theLongitude, theLatitude, this.GetLon_Graphics(), this.GetLat_Graphics(), theHeading, theAltitude, theExpYield, theExpYield_Graphics, theWarheadType, theExplosiveType, Weapon._DetonationMedium.Air, DirectImpactUnit, DirectImpactAimpoint, ExcludedUnit, ExcludedAimPoint, ExplosionDuration, ARM_TargetedRadar);
						explosion.ClusterCoverageLength = this.ClusterCoverageLength;
						explosion.ClusterCoverageWidth = this.ClusterCoverageWidth;
						explosion.ClusterSubmunitionQty = this.ClusterSubmunitionQty;
						explosion.float_7 = this.float_7;
						if (!Information.IsNothing(ExplosionDuration))
						{
							explosion.MaxD = ExplosionDuration;
						}
						if (this.method_76((double)(theExpYield / 1000000f), (double)base.GetAltitude_AGL()))
						{
							this.method_70(ref theScen, this.ExcludedUnitName, Weapon._DetonationMedium.Air);
						}
					}
					if (this.warheadType == Warhead.WarheadType.Nuclear)
					{
						if (this.ExplosiveYield > 0.0)
						{
							this.method_79(theScen);
						}
					}
					else if (this.warheadType == Warhead.WarheadType.Fragmentation || this.warheadType == Warhead.WarheadType.HardTargetPenetrator || this.warheadType == Warhead.WarheadType.HE_BlastFrag || this.warheadType == Warhead.WarheadType.HEAT || this.warheadType == Warhead.WarheadType.HESH || this.warheadType == Warhead.WarheadType.Landmine_AP || this.warheadType == Warhead.WarheadType.Landmine_AT || this.warheadType == Warhead.WarheadType.SemiAP || this.warheadType == Warhead.WarheadType.FAE)
					{
						if (!base.IsOnLand() && this.warheadType != Warhead.WarheadType.Incendiary)
						{
							new WaterSplash(ref theScen, this.GetLon_Graphics(), this.GetLat_Graphics(), Explosion.smethod_1(this.Yield_Graphics, Weapon._DetonationMedium.WaterSurface));
						}
						else
						{
							new GroundImpact(ref theScen, this.GetLon_Graphics(), this.GetLat_Graphics(), Explosion.smethod_1(this.Yield_Graphics, Weapon._DetonationMedium.Air), this.warheadType == Warhead.WarheadType.Incendiary);
						}
					}
					if (this.warheadType == Warhead.WarheadType.EMP_Omni)
					{
						this.ExplosiveYield = 42999999.0;
						this.method_79(theScen);
					}
				}
				else if (this.method_63())
				{
					if (this.ExplosiveYield > 0.0)
					{
						Explosion explosion2 = new Explosion(ref theScen, theLongitude, theLatitude, this.GetLon_Graphics(), this.GetLat_Graphics(), theHeading, (float)(Terrain.GetElevation(theLatitude, theLongitude, false) + 1), (float)((double)theExpYield * 0.95), theExpYield_Graphics, theWarheadType, theExplosiveType, Weapon._DetonationMedium.Air, DirectImpactUnit, DirectImpactAimpoint, ExcludedUnit, ExcludedAimPoint, ExplosionDuration, 0);
						explosion2.ClusterCoverageLength = this.ClusterCoverageLength;
						explosion2.ClusterCoverageWidth = this.ClusterCoverageWidth;
						explosion2.ClusterSubmunitionQty = this.ClusterSubmunitionQty;
						explosion2.float_7 = this.float_7;
						if (!Information.IsNothing(ExplosionDuration))
						{
							explosion2.MaxD = ExplosionDuration;
						}
						this.method_70(ref theScen, this.ExcludedUnitName, Weapon._DetonationMedium.WaterSurface);
					}
					if (this.warheadType == Warhead.WarheadType.Nuclear)
					{
						if (this.ExplosiveYield > 0.0)
						{
							this.method_79(theScen);
						}
					}
					else if (this.warheadType == Warhead.WarheadType.Incendiary || this.warheadType == Warhead.WarheadType.Fragmentation || this.warheadType == Warhead.WarheadType.HardTargetPenetrator || this.warheadType == Warhead.WarheadType.HE_BlastFrag || this.warheadType == Warhead.WarheadType.HEAT || this.warheadType == Warhead.WarheadType.HESH || this.warheadType == Warhead.WarheadType.Landmine_AP || this.warheadType == Warhead.WarheadType.Landmine_AT || this.warheadType == Warhead.WarheadType.SemiAP || this.warheadType == Warhead.WarheadType.FAE)
					{
						new GroundImpact(ref theScen, this.GetLon_Graphics(), this.GetLat_Graphics(), Explosion.smethod_1(this.Yield_Graphics, Weapon._DetonationMedium.Air), this.warheadType == Warhead.WarheadType.Incendiary);
					}
				}
				else if (this.method_64())
				{
					if (this.ExplosiveYield > 0.0)
					{
						Explosion explosion3 = new Explosion(ref theScen, theLongitude, theLatitude, this.GetLon_Graphics(), this.GetLat_Graphics(), theHeading, 1f, (float)((double)theExpYield * 0.9), theExpYield_Graphics, theWarheadType, theExplosiveType, Weapon._DetonationMedium.Air, DirectImpactUnit, DirectImpactAimpoint, ExcludedUnit, ExcludedAimPoint, ExplosionDuration, 0);
						explosion3.ClusterCoverageLength = this.ClusterCoverageLength;
						explosion3.ClusterCoverageWidth = this.ClusterCoverageWidth;
						explosion3.ClusterSubmunitionQty = this.ClusterSubmunitionQty;
						explosion3.float_7 = this.float_7;
						if (!Information.IsNothing(ExplosionDuration))
						{
							explosion3.MaxD = ExplosionDuration;
						}
						if (this.warheadType == Warhead.WarheadType.Nuclear)
						{
							Explosion explosion4 = new Explosion(ref theScen, theLongitude, theLatitude, this.GetLon_Graphics(), this.GetLat_Graphics(), theHeading, -1f, (float)((double)theExpYield * 0.1), theExpYield_Graphics, Warhead.WarheadType.HE_BlastFrag, theExplosiveType, Weapon._DetonationMedium.Underwater, DirectImpactUnit, DirectImpactAimpoint, ExcludedUnit, ExcludedAimPoint, ExplosionDuration, 0);
							explosion4.ClusterCoverageLength = this.ClusterCoverageLength;
							explosion4.ClusterCoverageWidth = this.ClusterCoverageWidth;
							if (!Information.IsNothing(ExplosionDuration))
							{
								explosion4.MaxD = ExplosionDuration;
							}
						}
					}
					if (this.warheadType == Warhead.WarheadType.Nuclear)
					{
						if (this.ExplosiveYield > 0.0)
						{
							this.method_79(theScen);
						}
					}
					else if (this.warheadType == Warhead.WarheadType.Incendiary)
					{
						new GroundImpact(ref theScen, this.GetLon_Graphics(), this.GetLat_Graphics(), 0.01349892f, this.warheadType == Warhead.WarheadType.Incendiary);
					}
					else if (!this.method_60())
					{
						new WaterSplash(ref theScen, this.GetLon_Graphics(), this.GetLat_Graphics(), Explosion.smethod_1(this.Yield_Graphics, Weapon._DetonationMedium.Air));
					}
				}
				else if (this.IsUnderWater())
				{
					if (this.ExplosiveYield > 0.0)
					{
						Explosion explosion5 = new Explosion(ref theScen, theLongitude, theLatitude, this.GetLon_Graphics(), this.GetLat_Graphics(), theHeading, theAltitude, theExpYield, theExpYield_Graphics, theWarheadType, theExplosiveType, Weapon._DetonationMedium.Underwater, DirectImpactUnit, DirectImpactAimpoint, ExcludedUnit, ExcludedAimPoint, ExplosionDuration, 0);
						explosion5.ClusterCoverageLength = this.ClusterCoverageLength;
						explosion5.ClusterCoverageWidth = this.ClusterCoverageWidth;
						explosion5.ClusterSubmunitionQty = this.ClusterSubmunitionQty;
						explosion5.float_7 = this.float_7;
						if (!Information.IsNothing(ExplosionDuration))
						{
							explosion5.MaxD = ExplosionDuration;
						}
					}
					if (!this.method_60())
					{
						new WaterSplash(ref theScen, this.GetLon_Graphics(), this.GetLat_Graphics(), Explosion.smethod_1(this.Yield_Graphics, Weapon._DetonationMedium.Underwater));
					}
				}
				else
				{
					if (!this.IsUnderGround())
					{
						throw new NotImplementedException();
					}
					if (this.ExplosiveYield > 0.0)
					{
						this.method_70(ref theScen, this.ExcludedUnitName, Weapon._DetonationMedium.Underground);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100844", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005FED RID: 24557 RVA: 0x002D5D7C File Offset: 0x002D3F7C
		private Explosion(ref Scenario theScen, double theLongitude, double theLatitude, double theLongitude_Graphics, double theLatitude_Graphics, float theHeading, float theAltitude, float theExpYield, float theExpYield_Graphics, Warhead.WarheadType theWarheadType, Warhead._ExplosivesType theExplosiveType, Weapon._DetonationMedium DetMedium, ActiveUnit DirectImpactUnit = null, Mount DirectImpactAimpoint = null, ActiveUnit ExcludedUnit = null, Mount ExcludedAimPoint = null, float? ExplosionDuration = null, int ARM_TargetedRadar = 0)
		{
			this.ExpType = Warhead._ExplosivesType.const_0;
			try
			{
				this.SetLongitude(null, theLongitude);
				this.SetLatitude(null, theLatitude);
				this.method_53(theLongitude_Graphics);
				this.method_55(theLatitude_Graphics);
				this.SetAltitude_ASL(false, theAltitude);
				this.SetCurrentHeading(theHeading);
				this.ExplosiveYield = (double)theExpYield;
				this.Yield_Graphics = (double)theExpYield_Graphics;
				this.warheadType = theWarheadType;
				this.ExpType = theExplosiveType;
				this.DirectImpactUnit = DirectImpactUnit;
				this.DirectImpactAimpoint = DirectImpactAimpoint;
				this.ExcludedUnit = ExcludedUnit;
				this.ExcludedAimpoint = ExcludedAimPoint;
				this.TTL = 0.0;
				if (!Information.IsNothing(ExplosionDuration))
				{
					this.MaxD = ExplosionDuration;
				}
				if (!Information.IsNothing(this.ExcludedUnit))
				{
					this.ExcludedUnitName = this.ExcludedUnit.GetGuid();
				}
				else
				{
					this.ExcludedUnitName = "";
				}
				theScen.UnitsAutoIncrement++;
				theScen.GetExplosions().Add(this);
				Warhead.WarheadType warheadType = this.warheadType;
				switch (warheadType)
				{
				case Warhead.WarheadType.HE_BlastFrag:
				case Warhead.WarheadType.SemiAP:
				case Warhead.WarheadType.HardTargetPenetrator:
					break;
				case Warhead.WarheadType.ArmorPiercing:
				case Warhead.WarheadType.HEAT:
				case Warhead.WarheadType.HESH:
				case Warhead.WarheadType.ContinuousRod:
					goto IL_25F;
				case Warhead.WarheadType.Incendiary:
					this.method_67(theScen, null, this.warheadType, theScen.GetTimeStep());
					goto IL_25F;
				case Warhead.WarheadType.Fragmentation:
					if (this.GetCurrentAltitude_ASL(false) >= 0f)
					{
						this.method_65(theScen, this.ExcludedUnitName, ARM_TargetedRadar);
						goto IL_25F;
					}
					goto IL_25F;
				case Warhead.WarheadType.FAE:
					this.method_68(theScen, this.ExcludedUnitName, Warhead.WarheadType.FAE, theScen.GetTimeStep());
					goto IL_25F;
				default:
					if (warheadType - Warhead.WarheadType.Torpedo > 1)
					{
						goto IL_25F;
					}
					break;
				}
				if (base.GetAltitude_AGL() >= 0f && base.IsOnLand())
				{
					this.method_65(theScen, this.ExcludedUnitName, ARM_TargetedRadar);
				}
				if (this.GetMaxDuration() <= theScen.GetTimeStep())
				{
					this.TTL = (double)theScen.GetTimeStep();
					if (this.IsUnderWater())
					{
						this.ProcessExplosion(theScen, this.ExcludedUnitName, Weapon._DetonationMedium.Underwater, theWarheadType, theScen.GetTimeStep());
					}
					else if (this.IsUnderGround())
					{
						this.ProcessExplosion(theScen, this.ExcludedUnitName, Weapon._DetonationMedium.Underground, theWarheadType, theScen.GetTimeStep());
					}
					else
					{
						this.ProcessExplosion(theScen, this.ExcludedUnitName, Weapon._DetonationMedium.Air, theWarheadType, theScen.GetTimeStep());
					}
				}
				IL_25F:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100845", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005FEE RID: 24558 RVA: 0x0002A9A9 File Offset: 0x00028BA9
		public bool method_62()
		{
			return base.GetAltitude_AGL() > 0f && this.GetCurrentAltitude_ASL(false) > 0f;
		}

		// Token: 0x06005FEF RID: 24559 RVA: 0x0002A9C9 File Offset: 0x00028BC9
		private bool method_63()
		{
			return base.GetAltitude_AGL() == 0f && base.IsOnLand();
		}

		// Token: 0x06005FF0 RID: 24560 RVA: 0x0002A9E1 File Offset: 0x00028BE1
		private bool method_64()
		{
			return this.GetCurrentAltitude_ASL(false) == 0f && !base.IsOnLand();
		}

		// Token: 0x06005FF1 RID: 24561 RVA: 0x002D6044 File Offset: 0x002D4244
		private void method_65(Scenario theScen, string ExcludedUnit_ObjectID, int ARM_TargetedRadar = 0)
		{
			Explosion.ExcludedUnitMan excludedUnitMan = new Explosion.ExcludedUnitMan(null);
			excludedUnitMan.explosion = this;
			excludedUnitMan.scenario = theScen;
			excludedUnitMan.excludedUnit_ObjectID = ExcludedUnit_ObjectID;
			try
			{
				Explosion.ActiveUnitBagMan activeUnitBagMan = new Explosion.ActiveUnitBagMan(null);
				activeUnitBagMan.excludedUnitMan = excludedUnitMan;
				activeUnitBagMan.theCutOffRange_Frag = Explosion.smethod_2(this.ExplosiveYield, Weapon._DetonationMedium.Air);
				if (!Information.IsNothing(this.DirectImpactAimpoint))
				{
					this.DirectImpactAimpoint.method_44(this.ExplosiveYield, activeUnitBagMan.theCutOffRange_Frag, ARM_TargetedRadar);
				}
				activeUnitBagMan.ActiveUnitBag = new ConcurrentBag<ActiveUnit>();
				Parallel.ForEach<ActiveUnit>(activeUnitBagMan.excludedUnitMan.scenario.GetActiveUnits().Values, new Action<ActiveUnit>(activeUnitBagMan.AddToBag));
				foreach (ActiveUnit current in activeUnitBagMan.ActiveUnitBag)
				{
					float slantRange = Class263.GetSlantRange(Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), current.GetLatitude(null), current.GetLongitude(null)), Math.Abs(this.GetCurrentAltitude_ASL(false) - current.GetCurrentAltitude_ASL(false)));
					if (current.IsFacility && ((Facility)current).MountsAreAimpoints)
					{
						if (!Information.IsNothing(this.DirectImpactAimpoint))
						{
							this.DirectImpactAimpoint.method_47(this.ExplosiveYield, this.warheadType);
						}
						IEnumerable<Mount> enumerable = current.m_Mounts.Where(new Func<Mount, bool>(this.IsMountNotExcludedDirectImpactAimpointAndUndestroyed));
						using (IEnumerator<Mount> enumerator2 = enumerable.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								Mount current2 = enumerator2.Current;
								double lon = 0.0;
								double lat = 0.0;
								Math2.GetAnotherGeopoint(current.GetLongitude(null), current.GetLatitude(null), ref lon, ref lat, current2.GetAimpointOffset_Distance() / 1852f, (float)current2.GetAimpointOffset_Bearing());
								float num = Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), lat, lon);
								if (num < 0f)
								{
									num = -num;
								}
								double num2 = (double)Warhead.smethod_3((double)Class263.GetSlantRange(num, Math.Abs(this.GetCurrentAltitude_ASL(false) - current.GetCurrentAltitude_ASL(false))), this.warheadType, this.ExplosiveYield, Weapon._DetonationMedium.Air);
								if (num2 > 0.0)
								{
									current2.method_44(num2, activeUnitBagMan.theCutOffRange_Frag, ARM_TargetedRadar);
								}
							}
							continue;
						}
					}
					float damageYield = Warhead.smethod_3((double)slantRange, this.warheadType, this.ExplosiveYield, Weapon._DetonationMedium.Air);
					current.GetDamage().vmethod_5(damageYield, activeUnitBagMan.theCutOffRange_Frag, ARM_TargetedRadar);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100846", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005FF2 RID: 24562 RVA: 0x002D63A8 File Offset: 0x002D45A8
		private bool method_66(ActiveUnit targetUnit, Weapon._DetonationMedium detonationMedium)
		{
			switch (detonationMedium)
			{
			case Weapon._DetonationMedium.Air:
			{
				bool result = !targetUnit.IsUnderGround() && !targetUnit.IsUnderWater();
				return result;
			}
			case Weapon._DetonationMedium.Underwater:
			{
				bool result = targetUnit.GetCurrentAltitude_ASL(false) <= 0f && !targetUnit.IsOnLand();
				return result;
			}
			case Weapon._DetonationMedium.Underground:
			{
				bool result = targetUnit.IsFixedFacility() || targetUnit.IsUnderGround();
				return result;
			}
			}
			throw new NotImplementedException();
		}

		// Token: 0x06005FF3 RID: 24563 RVA: 0x002D641C File Offset: 0x002D461C
		private void method_67(Scenario scenario_, string string_8, Warhead.WarheadType warheadType_, float timeStep_)
		{
			Explosion.Class207 @class = new Explosion.Class207(null);
			@class.explosion = this;
			@class.CutoffRange_m = Math.Sqrt(668.45076098596041);
			@class.ActiveUnitBag = new ConcurrentBag<ActiveUnit>();
			Parallel.ForEach<ActiveUnit>(scenario_.GetActiveUnits().Values, new Action<ActiveUnit>(@class.AddToBag));
			foreach (ActiveUnit current in @class.ActiveUnitBag)
			{
				if (current.IsFacility && ((Facility)current).MountsAreAimpoints)
				{
					IEnumerable<Mount> enumerable = current.m_Mounts.Where(new Func<Mount, bool>(this.IsMountNotExcludedDirectImpactAimpointAndUndestroyed));
					using (IEnumerator<Mount> enumerator2 = enumerable.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							Mount current2 = enumerator2.Current;
							int num;
							switch (current2.ArmorGeneral)
							{
							case GlobalVariables.ArmorRating.Light:
								num = 6;
								break;
							case GlobalVariables.ArmorRating.Medium:
								num = 4;
								break;
							case GlobalVariables.ArmorRating.Heavy:
							case GlobalVariables.ArmorRating.Special:
								num = 2;
								break;
							default:
								num = 8;
								break;
							}
							if (current.GetRandom().Next(1, 11) < num)
							{
								current.LogMessage(Misc.smethod_11(current.Name) + "战损报告: " + Misc.smethod_11(current2.Name) + "已被摧毁.", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(current.GetLongitude(null), current.GetLatitude(null)));
								current2.BeDestroyed(current.GetSide(false), false, true);
							}
						}
						continue;
					}
				}
				GlobalVariables.ArmorRating armorRating = (GlobalVariables.ArmorRating)0;
				switch (current.GetUnitType())
				{
				case GlobalVariables.ActiveUnitType.Ship:
					armorRating = ((Ship)current).ArmorDeck;
					break;
				case GlobalVariables.ActiveUnitType.Submarine:
					continue;
				case GlobalVariables.ActiveUnitType.Facility:
					armorRating = ((Facility)current).ArmorGeneral;
					break;
				}
				int num2 = 0;
				switch (current.GetTargetVisualSizeClass())
				{
				case GlobalVariables.TargetVisualSizeClass.Stealthy:
				case GlobalVariables.TargetVisualSizeClass.VSmall:
					num2 += 4;
					break;
				case GlobalVariables.TargetVisualSizeClass.Small:
					num2 += 3;
					break;
				case GlobalVariables.TargetVisualSizeClass.Medium:
					num2 += 2;
					break;
				case GlobalVariables.TargetVisualSizeClass.Large:
				case GlobalVariables.TargetVisualSizeClass.VLarge:
					num2++;
					break;
				}
				switch (armorRating)
				{
				case GlobalVariables.ArmorRating.Light:
					num2 += 3;
					break;
				case GlobalVariables.ArmorRating.Medium:
					num2 += 2;
					break;
				case GlobalVariables.ArmorRating.Heavy:
				case GlobalVariables.ArmorRating.Special:
					num2++;
					break;
				default:
					num2 += 4;
					break;
				}
				num2 = Math.Min(4, (int)Math.Round((double)num2 / 2.0));
				current.GetDamage().SetFireIntensityLevel((ActiveUnit_Damage.FireIntensityLevel)Math.Max((int)current.GetDamage().GetFireIntensityLevel(), num2));
			}
		}

		// Token: 0x06005FF4 RID: 24564 RVA: 0x002D6700 File Offset: 0x002D4900
		private void method_68(Scenario scenario_, string ExcludedUnitName_, Warhead.WarheadType warheadType_, float timeStep_)
		{
			Explosion.Class208 @class = new Explosion.Class208(null);
			@class.explosion = this;
			@class.excludedUnitName = ExcludedUnitName_;
			double num = this.ExplosiveYield;
			float rainFallRate = Weather.GetWeatherProfile(scenario_, this.GetLatitude(null), this.GetLongitude(null), (int)Math.Round((double)this.GetCurrentAltitude_ASL(false))).RainFallRate;
			if (rainFallRate >= 5f)
			{
				if (rainFallRate < 10f)
				{
					num *= 0.9;
				}
				else if (rainFallRate < 20f)
				{
					num *= 0.7;
				}
				else if (rainFallRate < 30f)
				{
					num *= 0.5;
				}
				else if (rainFallRate < 40f)
				{
					num *= 0.35;
				}
				else
				{
					num *= 0.2;
				}
			}
			float currentAltitude_ASL = this.GetCurrentAltitude_ASL(false);
			if (currentAltitude_ASL >= 1000f)
			{
				if (currentAltitude_ASL < 2000f)
				{
					num *= 0.9;
				}
				else if (currentAltitude_ASL < 3000f)
				{
					num *= 0.75;
				}
				else if (currentAltitude_ASL < 4000f)
				{
					num *= 0.6;
				}
				else if (currentAltitude_ASL < 5000f)
				{
					num *= 0.45;
				}
				else if (currentAltitude_ASL < 6000f)
				{
					num *= 0.3;
				}
				else
				{
					num *= 0.2;
				}
			}
			@class.float_1 = (float)(this.ExplosiveYield / 5.0);
			@class.float_2 = @class.float_1 + Explosion.smethod_1(num, Weapon._DetonationMedium.Air) * 1852f;
			@class.concurrentBag_0 = new ConcurrentBag<ActiveUnit>();
			@class.concurrentBag_1 = new ConcurrentBag<ActiveUnit>();
			Parallel.ForEach<ActiveUnit>(scenario_.GetActiveUnits().Values, new Action<ActiveUnit>(@class.method_0));
			foreach (ActiveUnit current in @class.concurrentBag_0)
			{
				if (current.IsFacility && ((Facility)current).MountsAreAimpoints)
				{
					IEnumerable<Mount> enumerable = current.m_Mounts.Where(new Func<Mount, bool>(this.IsMountNotExcludedDirectImpactAimpointAndUndestroyed));
					using (IEnumerator<Mount> enumerator2 = enumerable.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.method_47(num, warheadType_);
						}
						continue;
					}
				}
				current.GetDamage().SetFireIntensityLevel(ActiveUnit_Damage.FireIntensityLevel.Major);
				current.GetDamage().vmethod_6((float)num, warheadType_, this.ExpType, Weapon._DetonationMedium.Air);
			}
			foreach (ActiveUnit current2 in @class.concurrentBag_1)
			{
				float num2 = Warhead.smethod_4((double)(current2.HorizontalRangeTo(this.GetLatitude(null), this.GetLongitude(null)) - @class.float_1 / 1852f), (double)current2.GetInitialDP(), this.warheadType, num, Weapon._DetonationMedium.Air);
				if (current2.IsFacility && ((Facility)current2).MountsAreAimpoints)
				{
					IEnumerable<Mount> enumerable2 = current2.m_Mounts.Where(new Func<Mount, bool>(this.IsMountNotExcludedDirectImpactAimpointAndUndestroyed));
					using (IEnumerator<Mount> enumerator4 = enumerable2.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							enumerator4.Current.method_47((double)num2, warheadType_);
						}
						continue;
					}
				}
				current2.GetDamage().SetFireIntensityLevel(ActiveUnit_Damage.FireIntensityLevel.Major);
				current2.GetDamage().vmethod_6(num2, warheadType_, this.ExpType, Weapon._DetonationMedium.Air);
			}
		}

		// Token: 0x06005FF5 RID: 24565 RVA: 0x002D6B04 File Offset: 0x002D4D04
		private void ProcessExplosion(Scenario scenario_, string excludedUnit_, Weapon._DetonationMedium detonationMedium_, Warhead.WarheadType warheadType_, float elapsedTime_)
		{
			Explosion.Detonation detonation = new Explosion.Detonation(null);
			detonation.explosion = this;
			detonation.scenario = scenario_;
			detonation.excludedUnit = excludedUnit_;
			detonation.detonationMedium = detonationMedium_;
			detonation.warheadType = warheadType_;
			try
			{
				Explosion.AffectedTargetUnits affectedTargetUnits = new Explosion.AffectedTargetUnits(null);
				affectedTargetUnits.detonation = detonation;
				if (!Information.IsNothing(this.DirectImpactAimpoint))
				{
					this.DirectImpactAimpoint.method_47(this.ExplosiveYield, this.warheadType);
				}
				int num = 0;
				switch (affectedTargetUnits.detonation.detonationMedium)
				{
				case Weapon._DetonationMedium.Air:
					num = 661;
					break;
				case Weapon._DetonationMedium.Underwater:
					num = 2916;
					break;
				case Weapon._DetonationMedium.Underground:
					num = 5832;
					break;
				}
				affectedTargetUnits.MaxRange = this.TTL / 3600.0 * (double)num;
				affectedTargetUnits.MinRange = (this.TTL - (double)elapsedTime_) / 3600.0 * (double)num;
				float num2 = Explosion.smethod_1(this.ExplosiveYield, affectedTargetUnits.detonation.detonationMedium);
				if (affectedTargetUnits.MaxRange > (double)num2)
				{
					affectedTargetUnits.MaxRange = (double)num2;
				}
				affectedTargetUnits.TargetUnitsInDetonationRange = new ConcurrentBag<ActiveUnit>();
				Parallel.ForEach<ActiveUnit>(affectedTargetUnits.detonation.scenario.GetActiveUnitList(), new Action<ActiveUnit>(affectedTargetUnits.AddAsAffected));
				foreach (ActiveUnit current in affectedTargetUnits.TargetUnitsInDetonationRange)
				{
					float distance = Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), current.GetLatitude(null), current.GetLongitude(null));
					float num3;
					if (Math.Abs(this.GetCurrentAltitude_ASL(false) - current.GetCurrentAltitude_ASL(false)) == 0f)
					{
						num3 = distance;
					}
					else
					{
						num3 = Class263.GetSlantRange(distance, Math.Abs(this.GetCurrentAltitude_ASL(false) - current.GetCurrentAltitude_ASL(false)));
					}
					if (current.IsFacility)
					{
						if (((Facility)current).MountsAreAimpoints)
						{
							if (!Information.IsNothing(this.DirectImpactAimpoint))
							{
								this.DirectImpactAimpoint.method_47(this.ExplosiveYield, this.warheadType);
							}
							IEnumerable<Mount> enumerable = current.m_Mounts.Where(new Func<Mount, bool>(this.IsMountNotExcludedDirectImpactAimpointAndUndestroyed));
							using (IEnumerator<Mount> enumerator2 = enumerable.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									Mount current2 = enumerator2.Current;
									double lon = 0.0;
									double lat = 0.0;
									Math2.GetAnotherGeopoint(current.GetLongitude(null), current.GetLatitude(null), ref lon, ref lat, current2.GetAimpointOffset_Distance() / 1852f, (float)current2.GetAimpointOffset_Bearing());
									double num4 = (double)Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), lat, lon);
									double num5;
									if (Math.Abs(this.GetCurrentAltitude_ASL(false) - current.GetCurrentAltitude_ASL(false)) == 0f)
									{
										num5 = num4;
									}
									else
									{
										num5 = (double)Class263.GetSlantRange((float)num4, Math.Abs(this.GetCurrentAltitude_ASL(false) - current.GetCurrentAltitude_ASL(false)));
									}
									if (num5 <= (double)num2)
									{
										double num6 = (double)Warhead.smethod_4(num5, (double)current2.DamagePoints, this.warheadType, this.ExplosiveYield, affectedTargetUnits.detonation.detonationMedium);
										if (num6 > 0.0)
										{
											current2.method_47(num6, this.warheadType);
										}
									}
								}
								continue;
							}
						}
						float yield_ = Warhead.smethod_4((double)num3, (double)current.GetInitialDP(), this.warheadType, this.ExplosiveYield, affectedTargetUnits.detonation.detonationMedium);
						current.GetDamage().vmethod_6(yield_, this.warheadType, this.ExpType, affectedTargetUnits.detonation.detonationMedium);
					}
					else if (current.IsWeapon)
					{
						current.LogMessage(current.Name + "已给爆炸冲击波摧毁!", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(current.GetLongitude(null), current.GetLatitude(null)));
						current.m_Scenario.RemoveUnit(current);
					}
					else
					{
						Weapon._DetonationMedium detonationMedium = affectedTargetUnits.detonation.detonationMedium;
						if (detonationMedium == Weapon._DetonationMedium.Underwater)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								current.LogMessage(current.Name + "已被水下爆炸所命中：" + Conversions.ToString((int)Math.Round((double)(num3 * 1852f * 3.28084f))) + "英尺!", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(current.GetLongitude(null), current.GetLatitude(null)));
							}
							else
							{
								current.LogMessage(current.Name + "已被水下爆炸所命中：" + Conversions.ToString((int)Math.Round((double)(num3 * 1852f))) + "米!", LoggedMessage.MessageType.UnitDamage, 0, false, new GeoPoint(current.GetLongitude(null), current.GetLatitude(null)));
							}
						}
						float num7 = Warhead.smethod_4((double)num3, (double)current.GetInitialDP(), this.warheadType, this.ExplosiveYield, affectedTargetUnits.detonation.detonationMedium);
						if (affectedTargetUnits.detonation.detonationMedium == Weapon._DetonationMedium.Underground || affectedTargetUnits.detonation.detonationMedium == Weapon._DetonationMedium.Underwater)
						{
							float num8 = Math.Abs((float)Math2.Sin_D((double)Math2.GetAzimuth(current.GetLatitude(null), current.GetLongitude(null), this.GetLatitude(null), this.GetLongitude(null))));
							num7 = (float)((double)num7 * (0.2 + 0.8 * (double)num8));
						}
						current.GetDamage().vmethod_6(num7, this.warheadType, this.ExpType, affectedTargetUnits.detonation.detonationMedium);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100847", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005FF6 RID: 24566 RVA: 0x002D71DC File Offset: 0x002D53DC
		private void method_70(ref Scenario scenario_, string excludedUnitName_, Weapon._DetonationMedium detonationMedium_)
		{
			try
			{
				float num;
				if (this.warheadType == Warhead.WarheadType.Nuclear)
				{
					num = (float)(1.0 * this.ExplosiveYield) / 1000f;
				}
				else
				{
					num = (float)(1.0 * this.ExplosiveYield);
				}
				switch (detonationMedium_)
				{
				case Weapon._DetonationMedium.Air:
					num = (float)((double)num * 0.01);
					break;
				case Weapon._DetonationMedium.WaterSurface:
					num = (float)((double)num * 0.05);
					break;
				}
				double num2 = 0.0;
				double num3 = 0.0;
				double num4 = 0.0;
				this.method_77((double)num, ref num2, ref num3, ref num4, (double)base.GetAltitude_AGL());
				num2 /= 1852.0;
				num3 /= 1852.0;
				float num5 = (float)(3.0 * num3);
				float num6 = (float)(2.0 * num3);
				float num7 = (float)(1.5 * num3);
				float num8 = (float)(2.5 * num3);
				float num9 = (float)(2.0 * num3);
				float num10 = (float)(1.25 * num3);
				foreach (ActiveUnit current in scenario_.GetActiveUnits().Values)
				{
					if (current.IsOperating() && !current.IsGroup && current.IsFacility && Operators.CompareString(excludedUnitName_, current.GetGuid(), false) != 0 && ((Facility)current).Category == Facility._FacilityCategory.Building_Underground)
					{
						float slantRange = base.GetSlantRange(current, 0f);
						float num11;
						if (((Facility)current).ArmorGeneral > GlobalVariables.ArmorRating.Medium)
						{
							if (slantRange > num5)
							{
								continue;
							}
							if (num5 > slantRange && slantRange > num6)
							{
								num11 = (float)(GameGeneral.GetRandom().NextDouble() * 0.3);
							}
							else if (num6 > slantRange && slantRange > num7)
							{
								num11 = (float)(GameGeneral.GetRandom().NextDouble() * 0.5);
							}
							else
							{
								num11 = (float)(GameGeneral.GetRandom().NextDouble() * 0.8);
							}
						}
						else
						{
							if (slantRange > num8)
							{
								break;
							}
							if (num8 > slantRange && slantRange > num9)
							{
								num11 = (float)(GameGeneral.GetRandom().NextDouble() * 0.3);
							}
							else if (num9 > slantRange && slantRange > num10)
							{
								num11 = (float)(GameGeneral.GetRandom().NextDouble() * 0.5);
							}
							else
							{
								num11 = (float)(GameGeneral.GetRandom().NextDouble() * 0.8);
							}
						}
						current.GetDamage().vmethod_6((float)current.GetInitialDP() * num11, this.warheadType, this.ExpType, Weapon._DetonationMedium.Underground);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100848", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005FF7 RID: 24567 RVA: 0x002D7558 File Offset: 0x002D5758
		private void method_71(ref Scenario scenario_0, string string_8)
		{
			Explosion.Class212 @class = new Explosion.Class212(null);
			@class.explosion_0 = this;
			@class.string_0 = string_8;
			try
			{
				Explosion.Class211 class2 = new Explosion.Class211(null);
				class2.class212_0 = @class;
				if (base.IsOnLand())
				{
					double num = 0.0;
					double num2 = 0.0;
					this.method_77(1.0 * this.ExplosiveYield / 1000000.0, ref class2.double_0, ref num, ref num2, (double)base.GetAltitude_AGL());
				}
				else
				{
					double num = 0.0;
					double num2 = 0.0;
					this.method_77(1.0 * this.ExplosiveYield / 1000000.0, ref class2.double_0, ref num, ref num2, (double)this.GetCurrentAltitude_ASL(false));
				}
				if (class2.double_0 != 0.0)
				{
					class2.double_0 /= 1852.0;
					class2.concurrentBag_0 = new ConcurrentBag<ActiveUnit>();
					Parallel.ForEach<ActiveUnit>(scenario_0.GetActiveUnits().Values, new Action<ActiveUnit>(class2.method_0));
					foreach (ActiveUnit current in class2.concurrentBag_0)
					{
						scenario_0.RemoveUnit(current);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100849", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005FF8 RID: 24568 RVA: 0x002D7724 File Offset: 0x002D5924
		private void method_72(ref Scenario scenario_0, string string_8)
		{
			Explosion.Class214 @class = new Explosion.Class214(null);
			@class.explosion_0 = this;
			@class.string_0 = string_8;
			try
			{
				Explosion.Class213 class2 = new Explosion.Class213(null);
				class2.class214_0 = @class;
				if (this.GetCurrentAltitude_ASL(false) >= 0f && base.GetAltitude_AGL() >= 0f)
				{
					class2.double_0 = 1.0;
					class2.concurrentBag_0 = new ConcurrentBag<ActiveUnit>();
					Parallel.ForEach<ActiveUnit>(scenario_0.GetActiveUnits().Values, new Action<ActiveUnit>(class2.method_0));
					foreach (ActiveUnit current in class2.concurrentBag_0)
					{
						scenario_0.RemoveUnit(current);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100849", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005FF9 RID: 24569 RVA: 0x002D7840 File Offset: 0x002D5A40
		public List<GeoPoint> method_73(float float_8)
		{
			List<GeoPoint> result = null;
			try
			{
				float num = (float)this.ClusterCoverageLength * float_8;
				float num2 = (float)this.ClusterCoverageWidth * float_8;
				GeoPoint geoPoint = new GeoPoint();
				GeoPoint geoPoint2 = new GeoPoint();
				GeoPoint geoPoint3 = new GeoPoint();
				GeoPoint geoPoint4 = new GeoPoint();
				GeoPoint geoPoint5 = new GeoPoint();
				GeoPoint geoPoint6 = new GeoPoint();
				double longitude = this.GetLongitude(null);
				double latitude = this.GetLatitude(null);
				GeoPoint geoPoint7;
				double num3 = (geoPoint7 = geoPoint6).GetLongitude();
				GeoPoint geoPoint8;
				double num4 = (geoPoint8 = geoPoint6).GetLatitude();
				GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref num3, ref num4, (double)((float)((double)this.ClusterCoverageLength / 2.0 / 1852.0)), (double)Math2.Normalize(this.GetCurrentHeading() + 180f));
				geoPoint8.SetLatitude(num4);
				geoPoint7.SetLongitude(num3);
				double longitude2 = geoPoint6.GetLongitude();
				double latitude2 = geoPoint6.GetLatitude();
				num4 = (geoPoint8 = geoPoint3).GetLongitude();
				num3 = (geoPoint7 = geoPoint3).GetLatitude();
				GeoPointGenerator.GetOtherGeoPoint(longitude2, latitude2, ref num4, ref num3, (double)(num / 1852f), (double)this.GetCurrentHeading());
				geoPoint7.SetLatitude(num3);
				geoPoint8.SetLongitude(num4);
				double longitude3 = geoPoint3.GetLongitude();
				double latitude3 = geoPoint3.GetLatitude();
				num3 = (geoPoint7 = geoPoint).GetLongitude();
				num4 = (geoPoint8 = geoPoint).GetLatitude();
				GeoPointGenerator.GetOtherGeoPoint(longitude3, latitude3, ref num3, ref num4, (double)(num2 / 2f / 1852f), (double)Math2.Normalize(this.GetCurrentHeading() - 90f));
				geoPoint8.SetLatitude(num4);
				geoPoint7.SetLongitude(num3);
				double longitude4 = geoPoint3.GetLongitude();
				double latitude4 = geoPoint3.GetLatitude();
				num4 = (geoPoint8 = geoPoint2).GetLongitude();
				num3 = (geoPoint7 = geoPoint2).GetLatitude();
				GeoPointGenerator.GetOtherGeoPoint(longitude4, latitude4, ref num4, ref num3, (double)(num2 / 2f / 1852f), (double)Math2.Normalize(this.GetCurrentHeading() + 90f));
				geoPoint7.SetLatitude(num3);
				geoPoint8.SetLongitude(num4);
				double longitude5 = geoPoint6.GetLongitude();
				double latitude5 = geoPoint6.GetLatitude();
				num3 = (geoPoint7 = geoPoint4).GetLongitude();
				num4 = (geoPoint8 = geoPoint4).GetLatitude();
				GeoPointGenerator.GetOtherGeoPoint(longitude5, latitude5, ref num3, ref num4, (double)(num2 / 2f / 1852f), (double)Math2.Normalize(this.GetCurrentHeading() - 90f));
				geoPoint8.SetLatitude(num4);
				geoPoint7.SetLongitude(num3);
				double longitude6 = geoPoint6.GetLongitude();
				double latitude6 = geoPoint6.GetLatitude();
				num4 = (geoPoint8 = geoPoint5).GetLongitude();
				num3 = (geoPoint7 = geoPoint5).GetLatitude();
				GeoPointGenerator.GetOtherGeoPoint(longitude6, latitude6, ref num4, ref num3, (double)(num2 / 2f / 1852f), (double)Math2.Normalize(this.GetCurrentHeading() + 90f));
				geoPoint7.SetLatitude(num3);
				geoPoint8.SetLongitude(num4);
				result = new List<GeoPoint>
				{
					geoPoint,
					geoPoint2,
					geoPoint5,
					geoPoint4
				};
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100850", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005FFA RID: 24570 RVA: 0x002D7BA0 File Offset: 0x002D5DA0
		private void method_74(Scenario scenario_, string string_8)
		{
			Explosion.Class216 @class = new Explosion.Class216(null);
			@class.scenario_0 = scenario_;
			@class.string_0 = string_8;
			try
			{
				Explosion.Class215 class2 = new Explosion.Class215(null);
				class2.class216_0 = @class;
				class2.list_0 = this.method_73(1f);
				int num = this.ClusterCoverageLength * this.ClusterCoverageWidth;
				class2.concurrentBag_0 = new ConcurrentBag<ActiveUnit>();
				Parallel.ForEach<ActiveUnit>(class2.class216_0.scenario_0.GetActiveUnits().Values, new Action<ActiveUnit>(class2.method_0));
				foreach (ActiveUnit current in class2.concurrentBag_0)
				{
					if (current.IsFacility && ((Facility)current).MountsAreAimpoints)
					{
						List<Mount> list = new List<Mount>();
						IEnumerable<Mount> enumerable = current.m_Mounts.Where(Explosion.MountFunc);
						foreach (Mount current2 in enumerable)
						{
							double double_ = 0.0;
							double double_2 = 0.0;
							Math2.GetAnotherGeopoint(current.GetLongitude(null), current.GetLatitude(null), ref double_, ref double_2, current2.GetAimpointOffset_Distance() / 1852f, (float)current2.GetAimpointOffset_Bearing());
							if (new GeoPoint(double_, double_2).method_21(ref class2.list_0, true))
							{
								list.Add(current2);
							}
						}
						using (List<Mount>.Enumerator enumerator3 = list.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								Mount current3 = enumerator3.Current;
								double double_3 = (double)Warhead.smethod_2(current3, this.ExplosiveYield, this.ClusterSubmunitionQty, this.float_7, (double)num, this.warheadType, this.ExpType);
								current3.method_45(double_3, this.warheadType, (float)this.ClusterCoverageLength);
							}
							continue;
						}
					}
					double yieldSuffered = Warhead.GetYieldSuffered((Platform)current, this.ExplosiveYield, (double)num, this.GetCurrentHeading());
					current.GetDamage().vmethod_7((float)yieldSuffered, this.warheadType, this.ExpType, (float)this.ClusterCoverageLength);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100851", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005FFB RID: 24571 RVA: 0x002D7E90 File Offset: 0x002D6090
		public static float smethod_1(double Yield_, Weapon._DetonationMedium DetonationMedium_)
		{
			double d = Yield_ * 1.0;
			double num = Math.Exp(0.3315 * Math.Log(d) + 2.9034);
			float result;
			switch (DetonationMedium_)
			{
			case Weapon._DetonationMedium.Air:
			case Weapon._DetonationMedium.WaterSurface:
				result = (float)(num / 1852.0);
				break;
			case Weapon._DetonationMedium.Underwater:
				result = (float)(num * 4.4114977307110435 / 1852.0);
				break;
			case Weapon._DetonationMedium.Underground:
				result = (float)(num * 8.8229954614220869 / 1852.0);
				break;
			case Weapon._DetonationMedium.const_4:
				result = 0f;
				break;
			default:
				throw new NotImplementedException();
			}
			return result;
		}

		// Token: 0x06005FFC RID: 24572 RVA: 0x002D7F40 File Offset: 0x002D6140
		public static float smethod_2(double yield_, Weapon._DetonationMedium detonationMedium_)
		{
			double num;
			if (detonationMedium_ != Weapon._DetonationMedium.Air)
			{
				if (detonationMedium_ != Weapon._DetonationMedium.const_4)
				{
					num = 0.0;
				}
				else
				{
					num = 10.0 * yield_;
				}
			}
			else
			{
				num = 10.0 * Math.Pow(yield_, 0.33333333333333331);
			}
			return (float)(num / 1852.0);
		}

		// Token: 0x06005FFD RID: 24573 RVA: 0x002D7FA8 File Offset: 0x002D61A8
		private double method_75(double double_7, double double_8)
		{
			double num = 0.0;
			double result;
			if (double_8 < 0.15 && double_8 > -3.0)
			{
				double num2;
				double num3;
				double num4;
				double num5;
				double num6;
				double num7;
				if (double_8 >= 0.0)
				{
					if (double_7 <= 1.0)
					{
						num2 = -1.05;
						num3 = -0.105;
						num4 = 0.0573;
						num5 = -0.5;
						num6 = 16989.0;
						num7 = 5.0;
					}
					else
					{
						if (double_7 < 20.0)
						{
							result = num;
							return result;
						}
						num2 = -2.0;
						num3 = -0.3044;
						num4 = 0.0707;
						num5 = -0.9059;
						num6 = 5663.0;
						num7 = 5.0;
					}
				}
				else if (double_7 <= 1.0)
				{
					num2 = 0.258;
					num3 = 0.01;
					num4 = 0.1;
					num5 = 1.9;
					num6 = 16989.0;
					num7 = 5.0;
				}
				else
				{
					if (double_7 < 20.0)
					{
						result = num;
						return result;
					}
					num2 = 0.53;
					num3 = 0.028;
					num4 = -0.021739130434782608;
					num5 = 1.74;
					num6 = 5663.0;
					num7 = 5.0;
				}
				num = num6 / num7 * Math.Pow(10.0, num5 * (Math.Exp(num2 * double_8 + num3 * double_8 * double_8) - 1.0) + num4 * double_8);
			}
			else if (double_8 >= 5.0 && double_8 <= 40.0)
			{
				double num8 = 9.34;
				double num9 = 0.131;
				double num10 = -0.00231;
				double num11 = 0.0;
				num = Math.Exp(num8 + num9 * double_8 + num10 * double_8 * double_8) - num11;
			}
			result = num;
			return result;
		}

		// Token: 0x06005FFE RID: 24574 RVA: 0x002D8224 File Offset: 0x002D6424
		private bool method_76(double double_7, double theExpAltitude_AGL)
		{
			double num = Math.Pow(double_7, 0.33333333333333331);
			return theExpAltitude_AGL < 3.0 * num;
		}

		// Token: 0x06005FFF RID: 24575 RVA: 0x002D8250 File Offset: 0x002D6450
		private void method_77(double Yield_kT, ref double CraterRadius, ref double ApparentCraterRadius, ref double CraterDepth, double HOB = 0.0)
		{
			try
			{
				double num = 0.29411764705882354;
				if (Yield_kT >= 0.1 && Yield_kT <= 30000.0)
				{
					double num2 = Math.Pow(Yield_kT, 0.33333333333333331);
					if (HOB >= -40.0 * num2 && HOB <= 3.0 * num2)
					{
						double num3 = -HOB / num2;
						double num4;
						if (num3 < 0.15)
						{
							num4 = 0.33333333333333331;
						}
						else if (num3 < 5.0)
						{
							num4 = 0.2946 * Math.Exp(-num3 * Math.Log10(583.0)) / Math.Sqrt(305.0);
						}
						else
						{
							num4 = 0.29411764705882354;
						}
						double x;
						if (Yield_kT < 1.0)
						{
							double num5 = num4;
							double double_ = -HOB / Math.Pow(Yield_kT, num5);
							double num6 = this.method_75(Yield_kT, double_);
							x = num6 * Math.Pow(Yield_kT, 3.0 * num5);
						}
						else if (Yield_kT > 20.0)
						{
							double num5 = num;
							double double_ = -HOB / Math.Pow(Yield_kT, num5);
							double num7 = this.method_75(Yield_kT, double_);
							x = num7 * Math.Pow(Yield_kT, 3.0 * num5);
						}
						else
						{
							double num8 = 1.0 - Math.Min(1.0, Math.Max(0.0, Math.Log(Yield_kT) / Math.Log(20.0)));
							double num5 = 3.0 * (num + num8 * (num4 - num));
							double num6 = this.method_75(1.0, -HOB);
							double num7 = this.method_75(20.0, -HOB / Math.Pow(20.0, num5));
							if (num7 != 0.0)
							{
								x = num7 * Math.Pow(num6 / num7, num8) * Math.Pow(Yield_kT, num5);
							}
							else
							{
								x = 0.0;
							}
						}
						ApparentCraterRadius = 1.2 * Math.Pow(x, 0.33333333333333331);
						double num9 = 1.8 * ApparentCraterRadius;
						CraterRadius = num9;
						CraterDepth = 0.5 * Math.Pow(x, 0.33333333333333331);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				CraterRadius = 0.0;
				CraterDepth = 0.0;
				ex2.Data.Add("Error at 200041", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006000 RID: 24576 RVA: 0x002D854C File Offset: 0x002D674C
		internal float method_78(double Yield_)
		{
			float result;
			if (this.GetCurrentAltitude_ASL(false) <= 12000f)
			{
				result = Explosion.smethod_1(Yield_, Weapon._DetonationMedium.Air);
			}
			else
			{
				result = Explosion.smethod_1(Yield_, Weapon._DetonationMedium.Air) * this.GetCurrentAltitude_ASL(false) / 12000f;
			}
			return result;
		}

		// Token: 0x06006001 RID: 24577 RVA: 0x002D8594 File Offset: 0x002D6794
		private void method_79(Scenario scenario_0)
		{
			try
			{
				float num = this.method_78(this.ExplosiveYield);
				ConcurrentBag<ActiveUnit> concurrentBag = new ConcurrentBag<ActiveUnit>();
				foreach (ActiveUnit current in scenario_0.GetActiveUnitList())
				{
					if ((current.IsOperating() || (current.IsMoving() && current.vmethod_119())) && !current.IsGroup && !current.IsWeapon && (!current.IsFacility || ((Facility)current).Category != Facility._FacilityCategory.Building_Underground) && current.GetCurrentAltitude_ASL(false) >= 0f && (double)base.GetSlantRange(current, 0f) < (double)num)
					{
						concurrentBag.Add(current);
					}
				}
				foreach (ActiveUnit current2 in concurrentBag)
				{
					float distance = Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), current2.GetLatitude(null), current2.GetLongitude(null));
					if (Math.Abs(this.GetCurrentAltitude_ASL(false) - current2.GetCurrentAltitude_ASL(false)) != 0f)
					{
						Class263.GetSlantRange(distance, Math.Abs(this.GetCurrentAltitude_ASL(false) - current2.GetCurrentAltitude_ASL(false)));
					}
					if (base.IsLOS_Exists_Radar(current2, ref scenario_0, false))
					{
						float float_ = 1f - base.GetSlantRange(current2, 0f) / num;
						current2.GetDamage().AssessDamage(float_);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 192758436", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006002 RID: 24578 RVA: 0x0002A9FD File Offset: 0x00028BFD
		[CompilerGenerated]
		private bool IsMountNotExcludedDirectImpactAimpointAndUndestroyed(Mount mount_)
		{
			return mount_.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed && mount_ != this.DirectImpactAimpoint && mount_ != this.ExcludedAimpoint;
		}

		// Token: 0x040032B1 RID: 12977
		public static Func<Mount, bool> MountFunc = (Mount mount_0) => mount_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x040032B2 RID: 12978
		public double ExplosiveYield;

		// Token: 0x040032B3 RID: 12979
		public double Yield_Graphics;

		// Token: 0x040032B4 RID: 12980
		private double TTL;

		// Token: 0x040032B5 RID: 12981
		public Warhead.WarheadType warheadType;

		// Token: 0x040032B6 RID: 12982
		public Warhead._ExplosivesType ExpType;

		// Token: 0x040032B7 RID: 12983
		public int ClusterCoverageLength;

		// Token: 0x040032B8 RID: 12984
		public int ClusterCoverageWidth;

		// Token: 0x040032B9 RID: 12985
		public int ClusterSubmunitionQty;

		// Token: 0x040032BA RID: 12986
		public float float_7;

		// Token: 0x040032BB RID: 12987
		private ActiveUnit DirectImpactUnit;

		// Token: 0x040032BC RID: 12988
		private Mount DirectImpactAimpoint;

		// Token: 0x040032BD RID: 12989
		private ActiveUnit ExcludedUnit;

		// Token: 0x040032BE RID: 12990
		private Mount ExcludedAimpoint;

		// Token: 0x040032BF RID: 12991
		private string string_4;

		// Token: 0x040032C0 RID: 12992
		private string DirectImpactAimpointName;

		// Token: 0x040032C1 RID: 12993
		private string ExcludedUnitName;

		// Token: 0x040032C2 RID: 12994
		private string ExcludedAimPointID;

		// Token: 0x040032C3 RID: 12995
		private float? MaxD;

		// Token: 0x040032C4 RID: 12996
		private bool? bUnderGround;

		// Token: 0x040032C5 RID: 12997
		private bool? bUnderWater;

		// Token: 0x040032C6 RID: 12998
		private double double_5;

		// Token: 0x040032C7 RID: 12999
		private double double_6;

		// Token: 0x02000B58 RID: 2904
		[CompilerGenerated]
		public sealed class ExcludedUnitMan
		{
			// Token: 0x06006005 RID: 24581 RVA: 0x0002AA44 File Offset: 0x00028C44
			public ExcludedUnitMan(Explosion.ExcludedUnitMan ExcludedUnitMan_)
			{
				if (ExcludedUnitMan_ != null)
				{
					this.scenario = ExcludedUnitMan_.scenario;
					this.excludedUnit_ObjectID = ExcludedUnitMan_.excludedUnit_ObjectID;
				}
			}

			// Token: 0x040032C9 RID: 13001
			public Scenario scenario;

			// Token: 0x040032CA RID: 13002
			public string excludedUnit_ObjectID;

			// Token: 0x040032CB RID: 13003
			public Explosion explosion;
		}

		// Token: 0x02000B59 RID: 2905
		[CompilerGenerated]
		public sealed class ActiveUnitBagMan
		{
			// Token: 0x06006006 RID: 24582 RVA: 0x0002AA6A File Offset: 0x00028C6A
			public ActiveUnitBagMan(Explosion.ActiveUnitBagMan ActiveUnitBagMan_)
			{
				if (ActiveUnitBagMan_ != null)
				{
					this.ActiveUnitBag = ActiveUnitBagMan_.ActiveUnitBag;
					this.theCutOffRange_Frag = ActiveUnitBagMan_.theCutOffRange_Frag;
				}
			}

			// Token: 0x06006007 RID: 24583 RVA: 0x002D87D4 File Offset: 0x002D69D4
			internal void AddToBag(ActiveUnit activeUnit_)
			{
				if (activeUnit_.IsOperating())
				{
					if (activeUnit_.MountsAreAimpoints())
					{
						if (this.excludedUnitMan.explosion.IsLOS_Exists_Visual(activeUnit_, ref this.excludedUnitMan.scenario, false) == Unit._LOS_Exists_Visual.Yes)
						{
							this.ActiveUnitBag.Add(activeUnit_);
						}
					}
					else if (!activeUnit_.IsWeapon && !activeUnit_.IsAircraft && !activeUnit_.IsGroup && activeUnit_ != this.excludedUnitMan.explosion.DirectImpactUnit && activeUnit_ != this.excludedUnitMan.explosion.ExcludedUnit && this.excludedUnitMan.explosion.GetSlantRange(activeUnit_, 0f) <= this.theCutOffRange_Frag && Operators.CompareString(this.excludedUnitMan.excludedUnit_ObjectID, activeUnit_.GetGuid(), false) != 0 && (!this.excludedUnitMan.explosion.IsOnLand() || this.excludedUnitMan.explosion.IsLOS_Exists_Visual(activeUnit_, ref this.excludedUnitMan.scenario, false) == Unit._LOS_Exists_Visual.Yes))
					{
						this.ActiveUnitBag.Add(activeUnit_);
					}
				}
			}

			// Token: 0x040032CC RID: 13004
			public ConcurrentBag<ActiveUnit> ActiveUnitBag;

			// Token: 0x040032CD RID: 13005
			public float theCutOffRange_Frag;

			// Token: 0x040032CE RID: 13006
			public Explosion.ExcludedUnitMan excludedUnitMan;
		}

		// Token: 0x02000B5A RID: 2906
		[CompilerGenerated]
		public sealed class Class207
		{
			// Token: 0x06006008 RID: 24584 RVA: 0x0002AA90 File Offset: 0x00028C90
			public Class207(Explosion.Class207 class207_0)
			{
				if (class207_0 != null)
				{
					this.rangeToTarget_nm = class207_0.rangeToTarget_nm;
					this.CutoffRange_m = class207_0.CutoffRange_m;
					this.ActiveUnitBag = class207_0.ActiveUnitBag;
				}
			}

			// Token: 0x06006009 RID: 24585 RVA: 0x002D8900 File Offset: 0x002D6B00
			internal void AddToBag(ActiveUnit activeUnit_)
			{
				if (activeUnit_.IsOperating() && !activeUnit_.IsWeapon && !activeUnit_.IsAircraft && !activeUnit_.IsGroup && activeUnit_ != this.explosion.ExcludedUnit)
				{
					this.rangeToTarget_nm = this.explosion.GetSlantRange(activeUnit_, 0f);
					if ((double)(this.rangeToTarget_nm * 1852f) <= this.CutoffRange_m)
					{
						this.ActiveUnitBag.Add(activeUnit_);
					}
				}
			}

			// Token: 0x040032CF RID: 13007
			public float rangeToTarget_nm;

			// Token: 0x040032D0 RID: 13008
			public double CutoffRange_m;

			// Token: 0x040032D1 RID: 13009
			public ConcurrentBag<ActiveUnit> ActiveUnitBag;

			// Token: 0x040032D2 RID: 13010
			public Explosion explosion;
		}

		// Token: 0x02000B5B RID: 2907
		[CompilerGenerated]
		public sealed class Class208
		{
			// Token: 0x0600600A RID: 24586 RVA: 0x002D897C File Offset: 0x002D6B7C
			public Class208(Explosion.Class208 class208_0)
			{
				if (class208_0 != null)
				{
					this.excludedUnitName = class208_0.excludedUnitName;
					this.range = class208_0.range;
					this.float_1 = class208_0.float_1;
					this.concurrentBag_0 = class208_0.concurrentBag_0;
					this.float_2 = class208_0.float_2;
					this.concurrentBag_1 = class208_0.concurrentBag_1;
				}
			}

			// Token: 0x0600600B RID: 24587 RVA: 0x002D89E8 File Offset: 0x002D6BE8
			internal void method_0(ActiveUnit activeUnit_)
			{
				if (activeUnit_.IsOperating() && !activeUnit_.IsWeapon && !activeUnit_.IsAircraft && !activeUnit_.IsGroup && activeUnit_ != this.explosion.ExcludedUnit && Operators.CompareString(this.excludedUnitName, activeUnit_.GetGuid(), false) != 0)
				{
					this.range = this.explosion.GetSlantRange(activeUnit_, 0f);
					if (this.range * 1852f <= this.float_1)
					{
						this.concurrentBag_0.Add(activeUnit_);
					}
					else if (this.range * 1852f <= this.float_2)
					{
						this.concurrentBag_1.Add(activeUnit_);
					}
				}
			}

			// Token: 0x040032D3 RID: 13011
			public string excludedUnitName;

			// Token: 0x040032D4 RID: 13012
			public float range;

			// Token: 0x040032D5 RID: 13013
			public float float_1;

			// Token: 0x040032D6 RID: 13014
			public ConcurrentBag<ActiveUnit> concurrentBag_0;

			// Token: 0x040032D7 RID: 13015
			public float float_2 = 0f;

			// Token: 0x040032D8 RID: 13016
			public ConcurrentBag<ActiveUnit> concurrentBag_1;

			// Token: 0x040032D9 RID: 13017
			public Explosion explosion;
		}

		// Token: 0x02000B5C RID: 2908
		[CompilerGenerated]
		public sealed class Detonation
		{
			// Token: 0x0600600C RID: 24588 RVA: 0x0002AAC2 File Offset: 0x00028CC2
			public Detonation(Explosion.Detonation Detonation_)
			{
				if (Detonation_ != null)
				{
					this.excludedUnit = Detonation_.excludedUnit;
					this.scenario = Detonation_.scenario;
					this.warheadType = Detonation_.warheadType;
					this.detonationMedium = Detonation_.detonationMedium;
				}
			}

			// Token: 0x040032DA RID: 13018
			public string excludedUnit;

			// Token: 0x040032DB RID: 13019
			public Scenario scenario;

			// Token: 0x040032DC RID: 13020
			public Warhead.WarheadType warheadType;

			// Token: 0x040032DD RID: 13021
			public Weapon._DetonationMedium detonationMedium;

			// Token: 0x040032DE RID: 13022
			public Explosion explosion;
		}

		// Token: 0x02000B5D RID: 2909
		[CompilerGenerated]
		public sealed class AffectedTargetUnits
		{
			// Token: 0x0600600D RID: 24589 RVA: 0x0002AB00 File Offset: 0x00028D00
			public AffectedTargetUnits(Explosion.AffectedTargetUnits AffectedTargetUnits_)
			{
				if (AffectedTargetUnits_ != null)
				{
					this.TargetUnitsInDetonationRange = AffectedTargetUnits_.TargetUnitsInDetonationRange;
					this.MinRange = AffectedTargetUnits_.MinRange;
					this.MaxRange = AffectedTargetUnits_.MaxRange;
				}
			}

			// Token: 0x0600600E RID: 24590 RVA: 0x002D8A9C File Offset: 0x002D6C9C
			internal void AddAsAffected(ActiveUnit TargetUnit_)
			{
				if (Operators.CompareString(this.detonation.excludedUnit, TargetUnit_.GetGuid(), false) != 0)
				{
					if (TargetUnit_.MountsAreAimpoints())
					{
						if (this.detonation.explosion.IsLOS_Exists_Visual(TargetUnit_, ref this.detonation.scenario, false) == Unit._LOS_Exists_Visual.Yes)
						{
							this.TargetUnitsInDetonationRange.Add(TargetUnit_);
						}
					}
					else if (TargetUnit_.IsOperating() && !TargetUnit_.IsGroup && (!TargetUnit_.IsWeapon || (this.detonation.warheadType == Warhead.WarheadType.Nuclear && ((Weapon)TargetUnit_).IsTorpedoSonobuoyOrMine())) && (!TargetUnit_.IsAircraft || this.detonation.explosion.warheadType != Warhead.WarheadType.HE_BlastFrag) && (!TargetUnit_.IsFacility || ((Facility)TargetUnit_).Category != Facility._FacilityCategory.Building_Underground) && TargetUnit_ != this.detonation.explosion.ExcludedUnit && this.detonation.explosion.method_66(TargetUnit_, this.detonation.detonationMedium))
					{
						double num = (double)this.detonation.explosion.GetSlantRange(TargetUnit_, 0f);
						if (this.MinRange <= num && num <= this.MaxRange && (!this.detonation.explosion.IsOnLand() || this.detonation.explosion.IsLOS_Exists_Visual(TargetUnit_, ref this.detonation.scenario, false) == Unit._LOS_Exists_Visual.Yes))
						{
							this.TargetUnitsInDetonationRange.Add(TargetUnit_);
						}
					}
				}
			}

			// Token: 0x040032DF RID: 13023
			public ConcurrentBag<ActiveUnit> TargetUnitsInDetonationRange;

			// Token: 0x040032E0 RID: 13024
			public double MinRange;

			// Token: 0x040032E1 RID: 13025
			public double MaxRange;

			// Token: 0x040032E2 RID: 13026
			public Explosion.Detonation detonation;
		}

		// Token: 0x02000B5E RID: 2910
		[CompilerGenerated]
		public sealed class Class211
		{
			// Token: 0x0600600F RID: 24591 RVA: 0x0002AB32 File Offset: 0x00028D32
			public Class211(Explosion.Class211 class211_0)
			{
				if (class211_0 != null)
				{
					this.double_0 = class211_0.double_0;
					this.concurrentBag_0 = class211_0.concurrentBag_0;
				}
			}

			// Token: 0x06006010 RID: 24592 RVA: 0x002D8C2C File Offset: 0x002D6E2C
			internal void method_0(ActiveUnit activeUnit_0)
			{
				if (activeUnit_0.IsOperating() && !activeUnit_0.IsGroup)
				{
					if ((double)this.class212_0.explosion_0.SlantRangeTo(new GeoPoint(activeUnit_0.GetLongitude(null), activeUnit_0.GetLatitude(null), activeUnit_0.GetCurrentAltitude_ASL(false))) <= this.double_0)
					{
						if (Operators.CompareString(this.class212_0.string_0, activeUnit_0.GetGuid(), false) != 0)
						{
							this.concurrentBag_0.Add(activeUnit_0);
						}
					}
					else if (this.class212_0.explosion_0.GetCurrentAltitude_ASL(false) < 0f && activeUnit_0.GetCurrentAltitude_ASL(false) > this.class212_0.explosion_0.GetCurrentAltitude_ASL(false) && activeUnit_0.GetCurrentAltitude_ASL(false) < 2000f && (double)this.class212_0.explosion_0.HorizontalRangeTo(activeUnit_0.GetLatitude(null), activeUnit_0.GetLongitude(null)) <= this.double_0 * 2.0 && Operators.CompareString(this.class212_0.string_0, activeUnit_0.GetGuid(), false) != 0)
					{
						this.concurrentBag_0.Add(activeUnit_0);
					}
				}
			}

			// Token: 0x040032E3 RID: 13027
			public double double_0;

			// Token: 0x040032E4 RID: 13028
			public ConcurrentBag<ActiveUnit> concurrentBag_0;

			// Token: 0x040032E5 RID: 13029
			public Explosion.Class212 class212_0;
		}

		// Token: 0x02000B5F RID: 2911
		[CompilerGenerated]
		public sealed class Class212
		{
			// Token: 0x06006011 RID: 24593 RVA: 0x0002AB58 File Offset: 0x00028D58
			public Class212(Explosion.Class212 class212_0)
			{
				if (class212_0 != null)
				{
					this.string_0 = class212_0.string_0;
				}
			}

			// Token: 0x040032E6 RID: 13030
			public string string_0;

			// Token: 0x040032E7 RID: 13031
			public Explosion explosion_0;
		}

		// Token: 0x02000B60 RID: 2912
		[CompilerGenerated]
		public sealed class Class213
		{
			// Token: 0x06006012 RID: 24594 RVA: 0x0002AB72 File Offset: 0x00028D72
			public Class213(Explosion.Class213 class213_0)
			{
				if (class213_0 != null)
				{
					this.double_0 = class213_0.double_0;
					this.concurrentBag_0 = class213_0.concurrentBag_0;
				}
			}

			// Token: 0x06006013 RID: 24595 RVA: 0x002D8D74 File Offset: 0x002D6F74
			internal void method_0(ActiveUnit activeUnit_0)
			{
				if (activeUnit_0.IsOperating() && !activeUnit_0.IsGroup && activeUnit_0.GetCurrentAltitude_ASL(false) >= 0f && activeUnit_0.GetAltitude_AGL() >= 0f && (double)this.class214_0.explosion_0.SlantRangeTo(new GeoPoint(activeUnit_0.GetLongitude(null), activeUnit_0.GetLatitude(null), activeUnit_0.GetCurrentAltitude_ASL(false))) <= this.double_0 && Operators.CompareString(this.class214_0.string_0, activeUnit_0.GetGuid(), false) != 0)
				{
					this.concurrentBag_0.Add(activeUnit_0);
				}
			}

			// Token: 0x040032E8 RID: 13032
			public double double_0;

			// Token: 0x040032E9 RID: 13033
			public ConcurrentBag<ActiveUnit> concurrentBag_0;

			// Token: 0x040032EA RID: 13034
			public Explosion.Class214 class214_0;
		}

		// Token: 0x02000B61 RID: 2913
		[CompilerGenerated]
		public sealed class Class214
		{
			// Token: 0x06006014 RID: 24596 RVA: 0x0002AB98 File Offset: 0x00028D98
			public Class214(Explosion.Class214 class214_0)
			{
				if (class214_0 != null)
				{
					this.string_0 = class214_0.string_0;
				}
			}

			// Token: 0x040032EB RID: 13035
			public string string_0;

			// Token: 0x040032EC RID: 13036
			public Explosion explosion_0;
		}

		// Token: 0x02000B62 RID: 2914
		[CompilerGenerated]
		public sealed class Class215
		{
			// Token: 0x06006015 RID: 24597 RVA: 0x0002ABB2 File Offset: 0x00028DB2
			public Class215(Explosion.Class215 class215_0)
			{
				if (class215_0 != null)
				{
					this.concurrentBag_0 = class215_0.concurrentBag_0;
					this.list_0 = class215_0.list_0;
				}
			}

			// Token: 0x06006016 RID: 24598 RVA: 0x002D8E20 File Offset: 0x002D7020
			internal void method_0(ActiveUnit activeUnit_0)
			{
				if (activeUnit_0.MountsAreAimpoints())
				{
					this.concurrentBag_0.Add(activeUnit_0);
				}
				else if (!activeUnit_0.IsWeapon && !activeUnit_0.IsAircraft && !activeUnit_0.IsGroup && activeUnit_0.IsOperating() && activeUnit_0.vmethod_39(this.list_0, this.class216_0.scenario_0, false) && Operators.CompareString(this.class216_0.string_0, activeUnit_0.GetGuid(), false) != 0)
				{
					this.concurrentBag_0.Add(activeUnit_0);
				}
			}

			// Token: 0x040032ED RID: 13037
			public ConcurrentBag<ActiveUnit> concurrentBag_0;

			// Token: 0x040032EE RID: 13038
			public List<GeoPoint> list_0;

			// Token: 0x040032EF RID: 13039
			public Explosion.Class216 class216_0;
		}

		// Token: 0x02000B63 RID: 2915
		[CompilerGenerated]
		public sealed class Class216
		{
			// Token: 0x06006017 RID: 24599 RVA: 0x0002ABD8 File Offset: 0x00028DD8
			public Class216(Explosion.Class216 class216_0)
			{
				if (class216_0 != null)
				{
					this.scenario_0 = class216_0.scenario_0;
					this.string_0 = class216_0.string_0;
				}
			}

			// Token: 0x040032F0 RID: 13040
			public Scenario scenario_0;

			// Token: 0x040032F1 RID: 13041
			public string string_0;
		}
	}
}
