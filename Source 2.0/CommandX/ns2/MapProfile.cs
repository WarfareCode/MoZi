using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace ns2
{
	// Token: 0x02000B08 RID: 2824
	public sealed class MapProfile
	{
		// Token: 0x06005AEE RID: 23278 RVA: 0x002870C0 File Offset: 0x002852C0
		public void method_0(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("MapProfile");
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("ShowLatLonGrid", this.IsMapLatLonGridShown().ToString());
				xmlWriter_0.WriteElementString("Layer_BMNG", this.IsLayerBMNGShown().ToString());
				xmlWriter_0.WriteElementString("Layer_Relief", this.IsLayerReliefShown().ToString());
				xmlWriter_0.WriteElementString("Layer_Borders", this.IsLayerBordersShown().ToString());
				xmlWriter_0.WriteElementString("Layer_Placenames", this.IsLayerPlacenamesShown().ToString());
				xmlWriter_0.WriteElementString("DayNightLighting", this.IsDayNightLighting().ToString());
				xmlWriter_0.WriteElementString("RSVisible_AASensor", ((short)this.GetRSVisible_AASensor()).ToString());
				xmlWriter_0.WriteElementString("RSVisible_ASSensor", ((short)this.GetRSVisible_ASSensor()).ToString());
				xmlWriter_0.WriteElementString("RSVisible_ASWSensor", ((short)this.GetRSVisible_ASWSensor()).ToString());
				xmlWriter_0.WriteElementString("RSVisible_AAWeapon", ((short)this.GetRSVisible_AAWeapon()).ToString());
				xmlWriter_0.WriteElementString("RSVisible_ASWeapon", ((short)this.GetRSVisible_ASWeapon()).ToString());
				xmlWriter_0.WriteElementString("RSVisible_AGWeapon", ((short)this.GetRSVisible_AGWeapon()).ToString());
				xmlWriter_0.WriteElementString("RSVisible_ASWWeapon", ((short)this.GetRSVisible_ASWWeapon()).ToString());
				xmlWriter_0.WriteElementString("MergeRangeSymbols", this.IsMergeRangesymbols().ToString());
				xmlWriter_0.WriteElementString("ShowNonFriendly", this.IsShowNonFriendly().ToString());
				xmlWriter_0.WriteElementString("ShowTargetingVectors", ((byte)this.GetShowTargetingVectors()).ToString());
				xmlWriter_0.WriteElementString("ShowDatalinks", ((byte)this.GetShowDatalinks()).ToString());
				xmlWriter_0.WriteElementString("ShowDatablocks", ((byte)this.GetShowDatablocks()).ToString());
				xmlWriter_0.WriteElementString("ShowIlluminationVectors", ((byte)this.GetShowIlluminationVectors()).ToString());
				xmlWriter_0.WriteElementString("ShowContactEmissions", ((byte)this.GetShowContactEmissions()).ToString());
				xmlWriter_0.WriteElementString("ShowContactEmissions_Details", ((byte)this.GetShowContactEmissions_Details()).ToString());
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "ViewMode";
				byte viewMode = (byte)this.ViewMode;
				xmlWriter.WriteElementString(localName, viewMode.ToString());
				xmlWriter_0.WriteElementString("GodsEye", this.GodsEye.ToString());
				if (!string.IsNullOrEmpty(this.IsolatedPOVObjectID))
				{
					xmlWriter_0.WriteElementString("IsolatedPOVObjectID", this.IsolatedPOVObjectID);
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101013", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x002873D0 File Offset: 0x002855D0
		public static MapProfile Load(XmlNode xmlNode_0)
		{
			MapProfile result = null;
			try
			{
				MapProfile mapProfile = new MapProfile();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1756788299u)
						{
							if (num <= 724566713u)
							{
								if (num <= 266367750u)
								{
									if (num != 186371082u)
									{
										if (num != 244136149u)
										{
											if (num == 266367750u && Operators.CompareString(name, "Name", false) == 0)
											{
												mapProfile.Name = xmlNode.InnerText;
											}
										}
										else if (Operators.CompareString(name, "RSVisible_ASWeapon", false) == 0)
										{
											string innerText = xmlNode.InnerText;
											if (Operators.CompareString(innerText, "True", false) != 0)
											{
												if (Operators.CompareString(innerText, "False", false) != 0)
												{
													mapProfile.SetRSVisible_ASWeapon((MapProfile._UnitCoverage)Conversions.ToShort(xmlNode.InnerText));
												}
												else
												{
													mapProfile.SetRSVisible_ASWeapon(MapProfile._UnitCoverage.const_2);
												}
											}
											else
											{
												mapProfile.SetRSVisible_ASWeapon(MapProfile._UnitCoverage.const_0);
											}
										}
									}
									else if (Operators.CompareString(name, "RSVisible_ASWWeapon", false) == 0)
									{
										string innerText2 = xmlNode.InnerText;
										if (Operators.CompareString(innerText2, "True", false) != 0)
										{
											if (Operators.CompareString(innerText2, "False", false) != 0)
											{
												mapProfile.SetRSVisible_ASWWeapon((MapProfile._UnitCoverage)Conversions.ToShort(xmlNode.InnerText));
											}
											else
											{
												mapProfile.SetRSVisible_ASWWeapon(MapProfile._UnitCoverage.const_2);
											}
										}
										else
										{
											mapProfile.SetRSVisible_ASWWeapon(MapProfile._UnitCoverage.const_0);
										}
									}
								}
								else if (num != 636993161u)
								{
									if (num != 705302369u)
									{
										if (num == 724566713u && Operators.CompareString(name, "IsolatedPOVObjectID", false) == 0)
										{
											mapProfile.IsolatedPOVObjectID = xmlNode.InnerText;
										}
									}
									else if (Operators.CompareString(name, "ShowTargetingVectors", false) == 0)
									{
										mapProfile.ShowTargetingVectors = (MapProfile._UnitCoverage)Conversions.ToShort(xmlNode.InnerText);
									}
								}
								else if (Operators.CompareString(name, "Layer_BMNG", false) == 0)
								{
									mapProfile.IsShowLayer_BMNG = Conversions.ToBoolean(xmlNode.InnerText);
								}
							}
							else if (num <= 1357375637u)
							{
								if (num != 935075537u)
								{
									if (num != 1087302924u)
									{
										if (num == 1357375637u && Operators.CompareString(name, "DayNightLighting", false) == 0)
										{
											mapProfile.bDayNightLighting = Conversions.ToBoolean(xmlNode.InnerText);
										}
									}
									else if (Operators.CompareString(name, "RSVisible_ASWSensor", false) == 0)
									{
										string innerText3 = xmlNode.InnerText;
										if (Operators.CompareString(innerText3, "True", false) != 0)
										{
											if (Operators.CompareString(innerText3, "False", false) != 0)
											{
												mapProfile.SetIsRSVisible_ASWSensor((MapProfile._UnitCoverage)Conversions.ToShort(xmlNode.InnerText));
											}
											else
											{
												mapProfile.SetIsRSVisible_ASWSensor(MapProfile._UnitCoverage.const_2);
											}
										}
										else
										{
											mapProfile.SetIsRSVisible_ASWSensor(MapProfile._UnitCoverage.const_0);
										}
									}
								}
								else if (Operators.CompareString(name, "ShowIlluminationVectors", false) == 0)
								{
									mapProfile.ShowIlluminationVectors = (MapProfile._UnitCoverage)Conversions.ToShort(xmlNode.InnerText);
								}
							}
							else if (num != 1514581527u)
							{
								if (num != 1615731467u)
								{
									if (num == 1756788299u && Operators.CompareString(name, "GodsEye", false) == 0)
									{
										mapProfile.GodsEye = Conversions.ToBoolean(xmlNode.InnerText);
									}
								}
								else if (Operators.CompareString(name, "ViewMode", false) == 0)
								{
									mapProfile.ViewMode = (MapProfile._ViewMode)Conversions.ToByte(xmlNode.InnerText);
								}
							}
							else if (Operators.CompareString(name, "RSVisible_ASSensor", false) == 0)
							{
								string innerText4 = xmlNode.InnerText;
								if (Operators.CompareString(innerText4, "True", false) != 0)
								{
									if (Operators.CompareString(innerText4, "False", false) != 0)
									{
										mapProfile.SetRSVisible_ASSensor((MapProfile._UnitCoverage)Conversions.ToShort(xmlNode.InnerText));
									}
									else
									{
										mapProfile.SetRSVisible_ASSensor(MapProfile._UnitCoverage.const_2);
									}
								}
								else
								{
									mapProfile.SetRSVisible_ASSensor(MapProfile._UnitCoverage.const_0);
								}
							}
						}
						else if (num <= 3196990692u)
						{
							if (num <= 2144161573u)
							{
								if (num != 1761601820u)
								{
									if (num != 2077221006u)
									{
										if (num == 2144161573u && Operators.CompareString(name, "ShowDatalinks", false) == 0)
										{
											mapProfile.ShowDatalinks = (MapProfile._UnitCoverage)Conversions.ToShort(xmlNode.InnerText);
										}
									}
									else if (Operators.CompareString(name, "ShowLatLonGrid", false) == 0)
									{
										mapProfile.IsShowLatLonGrid = Conversions.ToBoolean(xmlNode.InnerText);
									}
								}
								else if (Operators.CompareString(name, "ShowNonFriendly", false) == 0)
								{
									mapProfile.SetIsShowNonFriendly(Conversions.ToBoolean(xmlNode.InnerText));
								}
							}
							else if (num != 2715175290u)
							{
								if (num != 3029283923u)
								{
									if (num == 3196990692u && Operators.CompareString(name, "ShowContactEmissions", false) == 0)
									{
										mapProfile.ShowContactEmissions = (MapProfile._UnitCoverage)Conversions.ToShort(xmlNode.InnerText);
									}
								}
								else if (Operators.CompareString(name, "RSVisible_AAWeapon", false) == 0)
								{
									string innerText5 = xmlNode.InnerText;
									if (Operators.CompareString(innerText5, "True", false) != 0)
									{
										if (Operators.CompareString(innerText5, "False", false) != 0)
										{
											mapProfile.SetRSVisible_AAWeapon((MapProfile._UnitCoverage)Conversions.ToShort(xmlNode.InnerText));
										}
										else
										{
											mapProfile.SetRSVisible_AAWeapon(MapProfile._UnitCoverage.const_2);
										}
									}
									else
									{
										mapProfile.SetRSVisible_AAWeapon(MapProfile._UnitCoverage.const_0);
									}
								}
							}
							else if (Operators.CompareString(name, "Layer_Borders", false) == 0)
							{
								mapProfile.bLayerBordersShow = Conversions.ToBoolean(xmlNode.InnerText);
							}
						}
						else if (num <= 3464835409u)
						{
							if (num != 3342653966u)
							{
								if (num != 3404056025u)
								{
									if (num == 3464835409u && Operators.CompareString(name, "RSVisible_AGWeapon", false) == 0)
									{
										string innerText6 = xmlNode.InnerText;
										if (Operators.CompareString(innerText6, "True", false) != 0)
										{
											if (Operators.CompareString(innerText6, "False", false) != 0)
											{
												mapProfile.SetRSVisible_AGWeapon((MapProfile._UnitCoverage)Conversions.ToShort(xmlNode.InnerText));
											}
											else
											{
												mapProfile.SetRSVisible_AGWeapon(MapProfile._UnitCoverage.const_2);
											}
										}
										else
										{
											mapProfile.SetRSVisible_AGWeapon(MapProfile._UnitCoverage.const_0);
										}
									}
								}
								else if (Operators.CompareString(name, "ShowContactEmissions_Details", false) == 0)
								{
									mapProfile.ShowContactEmissions_Details = (MapProfile.Enum56)Conversions.ToShort(xmlNode.InnerText);
								}
							}
							else if (Operators.CompareString(name, "Layer_Relief", false) == 0)
							{
								mapProfile.IsShowLayer_Relief = Conversions.ToBoolean(xmlNode.InnerText);
							}
						}
						else if (num <= 3609936337u)
						{
							if (num != 3493220302u)
							{
								if (num == 3609936337u && Operators.CompareString(name, "MergeRangeSymbols", false) == 0)
								{
									mapProfile.SetIsMergeRangesymbols(Conversions.ToBoolean(xmlNode.InnerText));
								}
							}
							else if (Operators.CompareString(name, "Layer_Placenames", false) == 0)
							{
								mapProfile.IsShowLayer_Placenames = Conversions.ToBoolean(xmlNode.InnerText);
							}
						}
						else if (num != 3738204765u)
						{
							if (num == 3816345098u && Operators.CompareString(name, "ShowDatablocks", false) == 0)
							{
								mapProfile.ShowDatablocks = (MapProfile._UnitCoverage)Conversions.ToShort(xmlNode.InnerText);
							}
						}
						else if (Operators.CompareString(name, "RSVisible_AASensor", false) == 0)
						{
							string innerText7 = xmlNode.InnerText;
							if (Operators.CompareString(innerText7, "True", false) != 0)
							{
								if (Operators.CompareString(innerText7, "False", false) != 0)
								{
									mapProfile.SetRSVisible_AASensor((MapProfile._UnitCoverage)Conversions.ToShort(xmlNode.InnerText));
								}
								else
								{
									mapProfile.SetRSVisible_AASensor(MapProfile._UnitCoverage.const_2);
								}
							}
							else
							{
								mapProfile.SetRSVisible_AASensor(MapProfile._UnitCoverage.const_0);
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
				result = mapProfile;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101014", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x00028CED File Offset: 0x00026EED
		public bool IsGodsEyeView()
		{
			return this.GodsEye;
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x00028CF5 File Offset: 0x00026EF5
		public void SetIsGodsEyeView(bool bool_9)
		{
			this.GodsEye = bool_9;
		}

		// Token: 0x06005AF2 RID: 23282 RVA: 0x00028CFE File Offset: 0x00026EFE
		public bool IsMapLatLonGridShown()
		{
			return this.IsShowLatLonGrid;
		}

		// Token: 0x06005AF3 RID: 23283 RVA: 0x00028D06 File Offset: 0x00026F06
		public void SetIsMapLatLonGridShown(bool value)
		{
			this.IsShowLatLonGrid = value;
		}

		// Token: 0x06005AF4 RID: 23284 RVA: 0x00028D0F File Offset: 0x00026F0F
		public bool IsLayerBMNGShown()
		{
			return this.IsShowLayer_BMNG;
		}

		// Token: 0x06005AF5 RID: 23285 RVA: 0x00028D17 File Offset: 0x00026F17
		public void SetIsLayerBMNGShown(bool bool_9)
		{
			this.IsShowLayer_BMNG = bool_9;
		}

		// Token: 0x06005AF6 RID: 23286 RVA: 0x00028D20 File Offset: 0x00026F20
		public bool IsLayerReliefShown()
		{
			return this.IsShowLayer_Relief;
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x00028D28 File Offset: 0x00026F28
		public void SetIsLayerReliefShown(bool bool_9)
		{
			this.IsShowLayer_Relief = bool_9;
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x00028D31 File Offset: 0x00026F31
		public bool IsLayerBordersShown()
		{
			return this.bLayerBordersShow;
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x00028D39 File Offset: 0x00026F39
		public void SetIsLayerBordersShown(bool bool_9)
		{
			this.bLayerBordersShow = bool_9;
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x00028D42 File Offset: 0x00026F42
		public bool IsLayerPlacenamesShown()
		{
			return this.IsShowLayer_Placenames;
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x00028D4A File Offset: 0x00026F4A
		public void SetIsLayerPlacenamesShown(bool bool_9)
		{
			this.IsShowLayer_Placenames = bool_9;
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x00028D53 File Offset: 0x00026F53
		public bool IsDayNightLighting()
		{
			return this.bDayNightLighting;
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x00028D5B File Offset: 0x00026F5B
		public void SetIsDayNightLighting(bool bool_9)
		{
			this.bDayNightLighting = bool_9;
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x00028D64 File Offset: 0x00026F64
		public bool IsMergeRangesymbols()
		{
			return this.bMergeRangesymbols;
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x00028D6C File Offset: 0x00026F6C
		public void SetIsMergeRangesymbols(bool bool_9)
		{
			this.bMergeRangesymbols = bool_9;
		}

		// Token: 0x06005B00 RID: 23296 RVA: 0x00028D75 File Offset: 0x00026F75
		public bool IsShowNonFriendly()
		{
			return this.bShowNonFriendly;
		}

		// Token: 0x06005B01 RID: 23297 RVA: 0x00028D7D File Offset: 0x00026F7D
		public void SetIsShowNonFriendly(bool bool_9)
		{
			this.bShowNonFriendly = bool_9;
		}

		// Token: 0x06005B02 RID: 23298 RVA: 0x00287CBC File Offset: 0x00285EBC
		public MapProfile._UnitCoverage GetRSVisible_AASensor()
		{
			return this.RSVisible_AASensor;
		}

		// Token: 0x06005B03 RID: 23299 RVA: 0x00028D86 File Offset: 0x00026F86
		public void SetRSVisible_AASensor(MapProfile._UnitCoverage enum55_13)
		{
			if (enum55_13 == (MapProfile._UnitCoverage)255)
			{
				enum55_13 = MapProfile._UnitCoverage.const_2;
			}
			if (enum55_13 == (MapProfile._UnitCoverage)3)
			{
				enum55_13 = MapProfile._UnitCoverage.const_0;
			}
			this.RSVisible_AASensor = enum55_13;
		}

		// Token: 0x06005B04 RID: 23300 RVA: 0x00287CD4 File Offset: 0x00285ED4
		public MapProfile._UnitCoverage GetRSVisible_AAWeapon()
		{
			return this.RSVisible_AAWeapon;
		}

		// Token: 0x06005B05 RID: 23301 RVA: 0x00028DAB File Offset: 0x00026FAB
		public void SetRSVisible_AAWeapon(MapProfile._UnitCoverage enum55_13)
		{
			if (enum55_13 == (MapProfile._UnitCoverage)255)
			{
				enum55_13 = MapProfile._UnitCoverage.const_2;
			}
			if (enum55_13 == (MapProfile._UnitCoverage)3)
			{
				enum55_13 = MapProfile._UnitCoverage.const_0;
			}
			this.RSVisible_AAWeapon = enum55_13;
		}

		// Token: 0x06005B06 RID: 23302 RVA: 0x00287CEC File Offset: 0x00285EEC
		public MapProfile._UnitCoverage GetRSVisible_ASSensor()
		{
			return this.RSVisible_ASSensor;
		}

		// Token: 0x06005B07 RID: 23303 RVA: 0x00028DD0 File Offset: 0x00026FD0
		public void SetRSVisible_ASSensor(MapProfile._UnitCoverage enum55_13)
		{
			if (enum55_13 == (MapProfile._UnitCoverage)255)
			{
				enum55_13 = MapProfile._UnitCoverage.const_2;
			}
			if (enum55_13 == (MapProfile._UnitCoverage)3)
			{
				enum55_13 = MapProfile._UnitCoverage.const_0;
			}
			this.RSVisible_ASSensor = enum55_13;
		}

		// Token: 0x06005B08 RID: 23304 RVA: 0x00287D04 File Offset: 0x00285F04
		public MapProfile._UnitCoverage GetRSVisible_ASWeapon()
		{
			return this.RSVisible_ASWeapon;
		}

		// Token: 0x06005B09 RID: 23305 RVA: 0x00028DF5 File Offset: 0x00026FF5
		public void SetRSVisible_ASWeapon(MapProfile._UnitCoverage enum55_13)
		{
			if (enum55_13 == (MapProfile._UnitCoverage)255)
			{
				enum55_13 = MapProfile._UnitCoverage.const_2;
			}
			if (enum55_13 == (MapProfile._UnitCoverage)3)
			{
				enum55_13 = MapProfile._UnitCoverage.const_0;
			}
			this.RSVisible_ASWeapon = enum55_13;
		}

		// Token: 0x06005B0A RID: 23306 RVA: 0x00287D1C File Offset: 0x00285F1C
		public MapProfile._UnitCoverage GetRSVisible_AGWeapon()
		{
			return this.RSVisible_AGWeapon;
		}

		// Token: 0x06005B0B RID: 23307 RVA: 0x00028E1A File Offset: 0x0002701A
		public void SetRSVisible_AGWeapon(MapProfile._UnitCoverage enum55_13)
		{
			if (enum55_13 == (MapProfile._UnitCoverage)255)
			{
				enum55_13 = MapProfile._UnitCoverage.const_2;
			}
			if (enum55_13 == (MapProfile._UnitCoverage)3)
			{
				enum55_13 = MapProfile._UnitCoverage.const_0;
			}
			this.RSVisible_AGWeapon = enum55_13;
		}

		// Token: 0x06005B0C RID: 23308 RVA: 0x00287D34 File Offset: 0x00285F34
		public MapProfile._UnitCoverage GetRSVisible_ASWSensor()
		{
			return this.RSVisible_ASWSensor;
		}

		// Token: 0x06005B0D RID: 23309 RVA: 0x00028E3F File Offset: 0x0002703F
		public void SetIsRSVisible_ASWSensor(MapProfile._UnitCoverage enum55_13)
		{
			if (enum55_13 == (MapProfile._UnitCoverage)255)
			{
				enum55_13 = MapProfile._UnitCoverage.const_2;
			}
			if (enum55_13 == (MapProfile._UnitCoverage)3)
			{
				enum55_13 = MapProfile._UnitCoverage.const_0;
			}
			this.RSVisible_ASWSensor = enum55_13;
		}

		// Token: 0x06005B0E RID: 23310 RVA: 0x00287D4C File Offset: 0x00285F4C
		public MapProfile._UnitCoverage GetRSVisible_ASWWeapon()
		{
			return this.RSVisible_ASWWeapon;
		}

		// Token: 0x06005B0F RID: 23311 RVA: 0x00028E64 File Offset: 0x00027064
		public void SetRSVisible_ASWWeapon(MapProfile._UnitCoverage enum55_13)
		{
			if (enum55_13 == (MapProfile._UnitCoverage)255)
			{
				enum55_13 = MapProfile._UnitCoverage.const_2;
			}
			if (enum55_13 == (MapProfile._UnitCoverage)3)
			{
				enum55_13 = MapProfile._UnitCoverage.const_0;
			}
			this.RSVisible_ASWWeapon = enum55_13;
		}

		// Token: 0x06005B10 RID: 23312 RVA: 0x00287D64 File Offset: 0x00285F64
		public MapProfile._UnitCoverage GetShowDatalinks()
		{
			return this.ShowDatalinks;
		}

		// Token: 0x06005B11 RID: 23313 RVA: 0x00028E89 File Offset: 0x00027089
		public void SetShowDatalinks(MapProfile._UnitCoverage enum55_13)
		{
			if (enum55_13 == (MapProfile._UnitCoverage)255)
			{
				enum55_13 = MapProfile._UnitCoverage.const_2;
			}
			if (enum55_13 == (MapProfile._UnitCoverage)3)
			{
				enum55_13 = MapProfile._UnitCoverage.const_0;
			}
			this.ShowDatalinks = enum55_13;
		}

		// Token: 0x06005B12 RID: 23314 RVA: 0x00287D7C File Offset: 0x00285F7C
		public MapProfile._UnitCoverage GetShowDatablocks()
		{
			return this.ShowDatablocks;
		}

		// Token: 0x06005B13 RID: 23315 RVA: 0x00028EAE File Offset: 0x000270AE
		public void SetShowDatablocks(MapProfile._UnitCoverage enum55_13)
		{
			if (enum55_13 == (MapProfile._UnitCoverage)3)
			{
				enum55_13 = MapProfile._UnitCoverage.const_0;
			}
			this.ShowDatablocks = enum55_13;
		}

		// Token: 0x06005B14 RID: 23316 RVA: 0x00287D94 File Offset: 0x00285F94
		public MapProfile._UnitCoverage GetShowTargetingVectors()
		{
			return this.ShowTargetingVectors;
		}

		// Token: 0x06005B15 RID: 23317 RVA: 0x00028EC3 File Offset: 0x000270C3
		public void SetShowTargetingVectors(MapProfile._UnitCoverage enum55_13)
		{
			if (enum55_13 == (MapProfile._UnitCoverage)3)
			{
				enum55_13 = MapProfile._UnitCoverage.const_0;
			}
			this.ShowTargetingVectors = enum55_13;
		}

		// Token: 0x06005B16 RID: 23318 RVA: 0x00287DAC File Offset: 0x00285FAC
		public MapProfile._UnitCoverage GetShowIlluminationVectors()
		{
			return this.ShowIlluminationVectors;
		}

		// Token: 0x06005B17 RID: 23319 RVA: 0x00028ED8 File Offset: 0x000270D8
		public void SetShowIlluminationVectors(MapProfile._UnitCoverage enum55_13)
		{
			if (enum55_13 == (MapProfile._UnitCoverage)3)
			{
				enum55_13 = MapProfile._UnitCoverage.const_0;
			}
			this.ShowIlluminationVectors = enum55_13;
		}

		// Token: 0x06005B18 RID: 23320 RVA: 0x00287DC4 File Offset: 0x00285FC4
		public MapProfile._UnitCoverage GetShowContactEmissions()
		{
			return this.ShowContactEmissions;
		}

		// Token: 0x06005B19 RID: 23321 RVA: 0x00028EED File Offset: 0x000270ED
		public void SetShowContactEmissions(MapProfile._UnitCoverage enum55_13)
		{
			this.ShowContactEmissions = enum55_13;
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x00287DDC File Offset: 0x00285FDC
		public MapProfile.Enum56 GetShowContactEmissions_Details()
		{
			return this.ShowContactEmissions_Details;
		}

		// Token: 0x06005B1B RID: 23323 RVA: 0x00028EF6 File Offset: 0x000270F6
		public void SetShowContactEmissions_Details(MapProfile.Enum56 enum56_1)
		{
			this.ShowContactEmissions_Details = enum56_1;
		}

		// Token: 0x06005B1C RID: 23324 RVA: 0x00287DF4 File Offset: 0x00285FF4
		public MapProfile._UnitCoverage GetShowRangeSymbols()
		{
			return this.ShowRangeSymbols;
		}

		// Token: 0x06005B1D RID: 23325 RVA: 0x00028EFF File Offset: 0x000270FF
		public void SetShowRangeSymbols(MapProfile._UnitCoverage enum55_13)
		{
			this.ShowRangeSymbols = enum55_13;
		}

		// Token: 0x06005B1E RID: 23326 RVA: 0x00287E0C File Offset: 0x0028600C
		public string GetIsolatedPOVObjectID()
		{
			return this.IsolatedPOVObjectID;
		}

		// Token: 0x06005B1F RID: 23327 RVA: 0x00028F08 File Offset: 0x00027108
		public void SetIsolatedPOVObjectID(string text)
		{
			this.IsolatedPOVObjectID = text;
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x00287E24 File Offset: 0x00286024
		public static MapProfile GetDefaultMapProfile()
		{
			return new MapProfile
			{
				Name = "Default Map Profile"
			};
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x00287E48 File Offset: 0x00286048
		private MapProfile()
		{
			this.struct14_0 = default(MapProfile.Struct14);
			this.ShowTargetingVectors = MapProfile._UnitCoverage.const_0;
			this.ShowDatalinks = MapProfile._UnitCoverage.const_0;
			this.ShowDatablocks = MapProfile._UnitCoverage.const_0;
			this.ViewMode = MapProfile._ViewMode.GroupMode;
			this.struct14_0.color_0 = Color.White;
			this.SetRSVisible_AASensor(MapProfile._UnitCoverage.const_0);
			this.struct14_0.color_1 = Color.FromArgb(255, 105, 105);
			this.SetRSVisible_AAWeapon(MapProfile._UnitCoverage.const_0);
			this.struct14_0.color_2 = Color.Yellow;
			this.SetRSVisible_ASSensor(MapProfile._UnitCoverage.const_0);
			this.struct14_0.color_3 = Color.Red;
			this.SetRSVisible_ASWeapon(MapProfile._UnitCoverage.const_0);
			this.struct14_0.color_4 = Color.Chocolate;
			this.SetRSVisible_AGWeapon(MapProfile._UnitCoverage.const_0);
			this.struct14_0.color_5 = Color.FromArgb(123, 199, 123);
			this.SetIsRSVisible_ASWSensor(MapProfile._UnitCoverage.const_0);
			this.struct14_0.color_6 = Color.Green;
			this.SetRSVisible_ASWWeapon(MapProfile._UnitCoverage.const_0);
			this.ShowDatablocks = MapProfile._UnitCoverage.const_1;
			this.ShowDatalinks = MapProfile._UnitCoverage.const_2;
			this.ShowIlluminationVectors = MapProfile._UnitCoverage.const_0;
			this.ShowTargetingVectors = MapProfile._UnitCoverage.const_2;
			this.ShowContactEmissions = MapProfile._UnitCoverage.const_0;
			this.ShowContactEmissions_Details = MapProfile.Enum56.const_0;
			this.IsShowLayer_BMNG = true;
			this.IsShowLayer_Relief = false;
			this.bLayerBordersShow = true;
			this.IsShowLayer_Placenames = true;
			this.bDayNightLighting = true;
			this.IsShowLatLonGrid = false;
			this.bMergeRangesymbols = false;
			this.bShowNonFriendly = true;
			this.ViewMode = MapProfile._ViewMode.GroupMode;
		}

		// Token: 0x04002DA7 RID: 11687
		public string Name;

		// Token: 0x04002DA8 RID: 11688
		private bool IsShowLatLonGrid;

		// Token: 0x04002DA9 RID: 11689
		private bool IsShowLayer_BMNG;

		// Token: 0x04002DAA RID: 11690
		private bool IsShowLayer_Relief = false;

		// Token: 0x04002DAB RID: 11691
		private bool bLayerBordersShow;

		// Token: 0x04002DAC RID: 11692
		private bool IsShowLayer_Placenames;

		// Token: 0x04002DAD RID: 11693
		private bool bDayNightLighting;

		// Token: 0x04002DAE RID: 11694
		private bool bMergeRangesymbols;

		// Token: 0x04002DAF RID: 11695
		private bool bShowNonFriendly;

		// Token: 0x04002DB0 RID: 11696
		private MapProfile._UnitCoverage ShowContactEmissions;

		// Token: 0x04002DB1 RID: 11697
		private MapProfile.Enum56 ShowContactEmissions_Details;

		// Token: 0x04002DB2 RID: 11698
		public MapProfile.Struct14 struct14_0;

		// Token: 0x04002DB3 RID: 11699
		private MapProfile._UnitCoverage ShowTargetingVectors;

		// Token: 0x04002DB4 RID: 11700
		private MapProfile._UnitCoverage ShowDatalinks;

		// Token: 0x04002DB5 RID: 11701
		private MapProfile._UnitCoverage ShowDatablocks;

		// Token: 0x04002DB6 RID: 11702
		private MapProfile._UnitCoverage ShowIlluminationVectors;

		// Token: 0x04002DB7 RID: 11703
		private MapProfile._UnitCoverage ShowRangeSymbols;

		// Token: 0x04002DB8 RID: 11704
		public MapProfile._ViewMode ViewMode;

		// Token: 0x04002DB9 RID: 11705
		private bool GodsEye;

		// Token: 0x04002DBA RID: 11706
		private string IsolatedPOVObjectID;

		// Token: 0x04002DBB RID: 11707
		private MapProfile._UnitCoverage RSVisible_AASensor;

		// Token: 0x04002DBC RID: 11708
		private MapProfile._UnitCoverage RSVisible_AAWeapon;

		// Token: 0x04002DBD RID: 11709
		private MapProfile._UnitCoverage RSVisible_ASSensor;

		// Token: 0x04002DBE RID: 11710
		private MapProfile._UnitCoverage RSVisible_ASWeapon;

		// Token: 0x04002DBF RID: 11711
		private MapProfile._UnitCoverage RSVisible_AGWeapon;

		// Token: 0x04002DC0 RID: 11712
		private MapProfile._UnitCoverage RSVisible_ASWSensor;

		// Token: 0x04002DC1 RID: 11713
		private MapProfile._UnitCoverage RSVisible_ASWWeapon;

		// Token: 0x02000B09 RID: 2825
		public struct Struct14
		{
			// Token: 0x04002DC2 RID: 11714
			public Color color_0;

			// Token: 0x04002DC3 RID: 11715
			public Color color_1;

			// Token: 0x04002DC4 RID: 11716
			public Color color_2;

			// Token: 0x04002DC5 RID: 11717
			public Color color_3;

			// Token: 0x04002DC6 RID: 11718
			public Color color_4;

			// Token: 0x04002DC7 RID: 11719
			public Color color_5;

			// Token: 0x04002DC8 RID: 11720
			public Color color_6;
		}

		// Token: 0x02000B0A RID: 2826
		public enum _UnitCoverage : short
		{
			// Token: 0x04002DCA RID: 11722
			const_0,
			// Token: 0x04002DCB RID: 11723
			const_1,
			// Token: 0x04002DCC RID: 11724
			const_2
		}

		// Token: 0x02000B0B RID: 2827
		public enum Enum56 : short
		{
			// Token: 0x04002DCE RID: 11726
			const_0,
			// Token: 0x04002DCF RID: 11727
			const_1,
			// Token: 0x04002DD0 RID: 11728
			const_2
		}

		// Token: 0x02000B0C RID: 2828
		public enum _ViewMode : byte
		{
			// Token: 0x04002DD2 RID: 11730
			GroupMode,
			// Token: 0x04002DD3 RID: 11731
			UnitMode
		}
	}
}
