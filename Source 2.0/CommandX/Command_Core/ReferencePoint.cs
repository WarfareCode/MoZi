using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 0x02000AD7 RID: 2775
	public sealed class ReferencePoint : GeoPoint
	{
		// Token: 0x060058B2 RID: 22706 RVA: 0x0026ECF0 File Offset: 0x0026CEF0
		public override void Save(ref XmlWriter theWriter, ref HashSet<string> ObjectsAlreadySerialized)
		{
			try
			{
				theWriter.WriteStartElement("RPoint");
				theWriter.WriteElementString("ID", base.GetGuid());
				if (!Information.IsNothing(ObjectsAlreadySerialized))
				{
					if (ObjectsAlreadySerialized.Contains(base.GetGuid()))
					{
						theWriter.WriteEndElement();
						return;
					}
					ObjectsAlreadySerialized.Add(base.GetGuid());
				}
				theWriter.WriteElementString("Lon", XmlConvert.ToString(base.GetLongitude()));
				theWriter.WriteElementString("Lat", XmlConvert.ToString(base.GetLatitude()));
				theWriter.WriteElementString("Alt", XmlConvert.ToString(base.GetAltitude()));
				theWriter.WriteElementString("Name", this.Name.ToString());
				theWriter.WriteElementString("IH", this.IsHighlighted.ToString());
				if (!Information.IsNothing(this.IsRelativeToUnit))
				{
					theWriter.WriteElementString("IRT", this.IsRelativeToUnit.GetGuid());
					theWriter.WriteElementString("RB", this.RelativeBearing.ToString());
					theWriter.WriteElementString("RD", this.RelativeDistance.ToString());
				}
				XmlWriter xmlWriter = theWriter;
				string localName = "BT";
				byte bearingType = (byte)this.BearingType;
				xmlWriter.WriteElementString(localName, bearingType.ToString());
				if (this.IsLocked)
				{
					theWriter.WriteElementString("IsLocked", "True");
				}
				theWriter.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100584", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x0026EEB4 File Offset: 0x0026D0B4
		public static ReferencePoint Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0)
		{
			ReferencePoint referencePoint2;
			ReferencePoint result;
			try
			{
				ReferencePoint referencePoint = new ReferencePoint();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num > 1836990821u)
						{
							if (num <= 2131034325u)
							{
								if (num <= 2030368611u)
								{
									if (num != 2022647575u)
									{
										if (num == 2030368611u && Operators.CompareString(name, "RD", false) == 0)
										{
											goto IL_2CE;
										}
										continue;
									}
									else if (Operators.CompareString(name, "Altitude", false) != 0)
									{
										continue;
									}
								}
								else if (num != 2108682236u)
								{
									if (num != 2131034325u)
									{
										continue;
									}
									if (Operators.CompareString(name, "RB", false) != 0)
									{
										continue;
									}
									goto IL_15A;
								}
								else if (Operators.CompareString(name, "Alt", false) != 0)
								{
									continue;
								}
								referencePoint.SetAltitude(XmlConvert.ToSingle(xmlNode.InnerText));
								continue;
							}
							if (num <= 2564648390u)
							{
								if (num != 2310993645u)
								{
									if (num == 2564648390u && Operators.CompareString(name, "Lon", false) == 0)
									{
										goto IL_3F5;
									}
									continue;
								}
								else if (Operators.CompareString(name, "RelativeBearing", false) != 0)
								{
									continue;
								}
							}
							else if (num != 3001749054u)
							{
								if (num != 3370226018u)
								{
									if (num == 3499333060u && Operators.CompareString(name, "IsSelected", false) == 0)
									{
										goto IL_419;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "IRT", false) == 0)
									{
										goto IL_32E;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Lat", false) == 0)
								{
									goto IL_3D1;
								}
								continue;
							}
							IL_15A:
							referencePoint.RelativeBearing = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
							continue;
						}
						if (num <= 1368635491u)
						{
							if (num <= 685599235u)
							{
								if (num != 266367750u)
								{
									if (num == 685599235u && Operators.CompareString(name, "BT", false) == 0)
									{
										referencePoint.BearingType = (ReferencePoint.OrientationType)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Name", false) == 0)
									{
										referencePoint.Name = xmlNode.InnerText;
										continue;
									}
									continue;
								}
							}
							else if (num != 1277788090u)
							{
								if (num == 1368635491u && Operators.CompareString(name, "IsLocked", false) == 0)
								{
									referencePoint.IsLocked = true;
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "RelativeDistance", false) != 0)
							{
								continue;
							}
						}
						else if (num <= 1570547740u)
						{
							if (num != 1458105184u)
							{
								if (num == 1570547740u && Operators.CompareString(name, "IsRelativeTo", false) == 0)
								{
									goto IL_32E;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "ID", false) != 0)
								{
									continue;
								}
								if (!Information.IsNothing(dictionary_0) && dictionary_0.ContainsKey(xmlNode.InnerText))
								{
									referencePoint2 = (ReferencePoint)dictionary_0[xmlNode.InnerText];
									result = referencePoint2;
									return result;
								}
								referencePoint.SetGuid(xmlNode.InnerText);
								if (!Information.IsNothing(dictionary_0))
								{
									dictionary_0.Add(referencePoint.GetGuid(), referencePoint);
									continue;
								}
								continue;
							}
						}
						else if (num != 1659436612u)
						{
							if (num != 1729717486u)
							{
								if (num == 1836990821u && Operators.CompareString(name, "Latitude", false) == 0)
								{
									goto IL_3D1;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Longitude", false) == 0)
								{
									goto IL_3F5;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "IH", false) == 0)
							{
								goto IL_419;
							}
							continue;
						}
						IL_2CE:
						referencePoint.RelativeDistance = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
						continue;
						IL_32E:
						referencePoint.IsRelativeToUnitName = xmlNode.InnerText;
						continue;
						IL_3D1:
						referencePoint.SetLatitude(XmlConvert.ToDouble(xmlNode.InnerText));
						continue;
						IL_3F5:
						referencePoint.SetLongitude(XmlConvert.ToDouble(xmlNode.InnerText));
						continue;
						IL_419:
						referencePoint.IsHighlighted = Conversions.ToBoolean(xmlNode.InnerText);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				referencePoint2 = referencePoint;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100585", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				referencePoint2 = new ReferencePoint();
				ProjectData.ClearProjectError();
			}
			result = referencePoint2;
			return result;
		}

		// Token: 0x060058B4 RID: 22708 RVA: 0x0002817F File Offset: 0x0002637F
		public void SetIsRelativeToUnit(Dictionary<string, Subject> dictionary_0)
		{
			if (Operators.CompareString(this.IsRelativeToUnitName, "", false) != 0 && dictionary_0.ContainsKey(this.IsRelativeToUnitName))
			{
				this.IsRelativeToUnit = (Unit)dictionary_0[this.IsRelativeToUnitName];
			}
		}

		// Token: 0x060058B5 RID: 22709 RVA: 0x000281BF File Offset: 0x000263BF
		public bool IsSelected()
		{
			return this.IsHighlighted;
		}

		// Token: 0x060058B6 RID: 22710 RVA: 0x000281C7 File Offset: 0x000263C7
		public void SetIsSelected(bool bool_10)
		{
			this.IsHighlighted = bool_10;
		}

		// Token: 0x060058B7 RID: 22711 RVA: 0x0026F3B4 File Offset: 0x0026D5B4
		public void RelativeCalculate()
		{
			if (!Information.IsNothing(this.IsRelativeToUnit))
			{
				try
				{
					ReferencePoint.OrientationType bearingType = this.BearingType;
					if (bearingType != ReferencePoint.OrientationType.Fixed)
					{
						if (bearingType == ReferencePoint.OrientationType.Rotating)
						{
							this.RelativeBearing = Class263.RelativeBearingTo(this.IsRelativeToUnit.GetCurrentHeading(), Math2.GetAzimuth(this.IsRelativeToUnit.GetLatitude(null), this.IsRelativeToUnit.GetLongitude(null), base.GetLatitude(), base.GetLongitude()));
						}
					}
					else
					{
						this.RelativeBearing = Math2.GetAzimuth(this.IsRelativeToUnit.GetLatitude(null), this.IsRelativeToUnit.GetLongitude(null), base.GetLatitude(), base.GetLongitude());
					}
					this.RelativeDistance = Math2.GetDistance(this.IsRelativeToUnit.GetLatitude(null), this.IsRelativeToUnit.GetLongitude(null), base.GetLatitude(), base.GetLongitude());
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100586", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060058B8 RID: 22712 RVA: 0x000281D0 File Offset: 0x000263D0
		public ReferencePoint(double Lon_, double Lat_)
		{
			base.SetLongitude(Lon_);
			base.SetLatitude(Lat_);
		}

		// Token: 0x060058B9 RID: 22713 RVA: 0x000281FC File Offset: 0x000263FC
		public ReferencePoint()
		{
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x0026F508 File Offset: 0x0026D708
		public ReferencePoint NewReferencePoint(ref ReferencePoint referencePoint_0)
		{
			return new ReferencePoint(referencePoint_0.Name, referencePoint_0.GetGuid(), referencePoint_0.GetLatitude(), referencePoint_0.GetLongitude(), referencePoint_0.GetAltitude(), referencePoint_0.IsHighlighted, referencePoint_0.IsRelativeToUnitName, referencePoint_0.RelativeBearing, referencePoint_0.RelativeDistance, referencePoint_0.BearingType, referencePoint_0.IsLocked);
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x0026F56C File Offset: 0x0026D76C
		public ReferencePoint(string string_3, string string_4, double double_2, double double_3, float float_3, bool bool_10, string string_5, float float_4, float float_5, ReferencePoint.OrientationType orientationType_1, bool bool_11)
		{
			this.Name = string_3;
			base.SetGuid(string_4);
			base.SetLatitude(double_2);
			base.SetLongitude(double_3);
			base.SetAltitude(float_3);
			this.IsHighlighted = bool_10;
			this.IsRelativeToUnitName = string_5;
			this.RelativeBearing = float_4;
			this.RelativeDistance = float_5;
			this.BearingType = orientationType_1;
			this.IsLocked = bool_11;
		}

		// Token: 0x04002BCB RID: 11211
		private bool IsHighlighted;

		// Token: 0x04002BCC RID: 11212
		public Unit IsRelativeToUnit;

		// Token: 0x04002BCD RID: 11213
		private string IsRelativeToUnitName = "";

		// Token: 0x04002BCE RID: 11214
		public float RelativeBearing;

		// Token: 0x04002BCF RID: 11215
		public float RelativeDistance = 0f;

		// Token: 0x04002BD0 RID: 11216
		public ReferencePoint.OrientationType BearingType;

		// Token: 0x04002BD1 RID: 11217
		public bool IsLocked;

		// Token: 0x02000AD8 RID: 2776
		public enum OrientationType : byte
		{
			// Token: 0x04002BD3 RID: 11219
			Fixed,
			// Token: 0x04002BD4 RID: 11220
			Rotating
		}
	}
}
