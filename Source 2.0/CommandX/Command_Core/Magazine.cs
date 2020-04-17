using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace Command_Core
{
	// Token: 弹药库
	public sealed class Magazine : PlatformComponent
	{
		// Token: 0x06005B4A RID: 23370 RVA: 0x0028AD24 File Offset: 0x00288F24
		[CompilerGenerated]
		public  ObservableCollection<WeaponRec> GetWeaponRecCollection()
		{
			return this.WeaponRecCollection;
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x0028AD3C File Offset: 0x00288F3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void vmethod_12(ObservableCollection<WeaponRec> observableCollection_1)
		{
			NotifyCollectionChangedEventHandler value = new NotifyCollectionChangedEventHandler(this.method_31);
			ObservableCollection<WeaponRec> weaponRecCollection = this.WeaponRecCollection;
			if (weaponRecCollection != null)
			{
				weaponRecCollection.CollectionChanged -= value;
			}
			this.WeaponRecCollection = observableCollection_1;
			weaponRecCollection = this.WeaponRecCollection;
			if (weaponRecCollection != null)
			{
				weaponRecCollection.CollectionChanged += value;
			}
		}

		// Token: 0x06005B4C RID: 23372 RVA: 0x0028AD88 File Offset: 0x00288F88
		public override void ClearGuid()
		{
			base.ClearGuid();
			using (IEnumerator<WeaponRec> enumerator = this.GetWeaponRecCollection().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.ClearGuid();
				}
			}
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x0028ADDC File Offset: 0x00288FDC
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Magazine");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (hashSet_0.Contains(base.GetGuid()))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(base.GetGuid());
					xmlWriter_0.WriteElementString("TTF", XmlConvert.ToString(this.TimeToFire));
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Status";
					byte componentStatus = (byte)this.m_ComponentStatus;
					xmlWriter.WriteElementString(localName, componentStatus.ToString());
					xmlWriter_0.WriteElementString("DamageSeverity", ((byte)base.GetDamageSeverity()).ToString());
					xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
					if (this.WeaponRecCollection.Count > 0)
					{
						xmlWriter_0.WriteStartElement("Weapons");
						using (IEnumerator<WeaponRec> enumerator = this.WeaponRecCollection.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								enumerator.Current.Save(ref xmlWriter_0, ref hashSet_0, ref scenario_0);
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100671", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x00028FC6 File Offset: 0x000271C6
		private Magazine()
		{
			this.vmethod_12(new ObservableCollection<WeaponRec>());
		}

		// Token: 0x06005B4F RID: 23375 RVA: 0x0028AF78 File Offset: 0x00289178
		public static Magazine smethod_2(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			Magazine result = null;
			try
			{
				Magazine magazine = new Magazine();
				XmlNode xmlNode = Misc.smethod_48(xmlNode_0.ChildNodes, "DBID");
				int magazineDBID;
				if (Information.IsNothing(xmlNode))
				{
					magazineDBID = DBFunctions.GetMagazineData(Misc.smethod_48(xmlNode_0.ChildNodes, "Name").InnerText, scenario_0.GetSQLiteConnection());
				}
				else
				{
					magazineDBID = Conversions.ToInteger(xmlNode.InnerText);
				}
				magazine = DBFunctions.GetMagazine(magazineDBID, ref scenario_0, false);
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					result = (Magazine)dictionary_0[innerText];
				}
				else
				{
					magazine.SetGuid(innerText);
					dictionary_0.Add(magazine.GetGuid(), magazine);
					IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							XmlNode xmlNode2 = (XmlNode)enumerator.Current;
							string name = xmlNode2.Name;
							if (Operators.CompareString(name, "Status", false) != 0)
							{
								if (Operators.CompareString(name, "DamageSeverity", false) != 0)
								{
									if (Operators.CompareString(name, "Weapons", false) != 0)
									{
										if (Operators.CompareString(name, "TimeToFire", false) == 0 || Operators.CompareString(name, "TTF", false) == 0)
										{
											magazine.TimeToFire = XmlConvert.ToSingle(xmlNode2.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										IEnumerator enumerator2 = xmlNode2.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator2.MoveNext())
											{
												XmlNode xmlNode3 = (XmlNode)enumerator2.Current;
												WeaponRec item = WeaponRec.smethod_2(ref xmlNode3, ref dictionary_0, ref scenario_0);
												magazine.GetWeaponRecCollection().Add(item);
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
								magazine.SetDamageSeverity((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode2.InnerText));
							}
							else
							{
								string innerText2 = xmlNode2.InnerText;
								if (Operators.CompareString(innerText2, "Operational", false) != 0)
								{
									if (Operators.CompareString(innerText2, "Damaged", false) != 0)
									{
										if (Operators.CompareString(innerText2, "Destroyed", false) != 0)
										{
											magazine.m_ComponentStatus = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode2.InnerText);
										}
										else
										{
											magazine.m_ComponentStatus = PlatformComponent._ComponentStatus.Destroyed;
										}
									}
									else
									{
										magazine.m_ComponentStatus = PlatformComponent._ComponentStatus.Damaged;
									}
								}
								else
								{
									magazine.m_ComponentStatus = PlatformComponent._ComponentStatus.Operational;
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
					result = magazine;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100672", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005B50 RID: 23376 RVA: 0x0028B27C File Offset: 0x0028947C
		public float GetTimeToFire()
		{
			return this.TimeToFire;
		}

		// Token: 0x06005B51 RID: 23377 RVA: 0x00028FD9 File Offset: 0x000271D9
		public void SetTimeToFire(float value)
		{
			this.TimeToFire = value;
		}

		// Token: 0x06005B52 RID: 23378 RVA: 0x00028FE2 File Offset: 0x000271E2
		public void ResetTimeToFire()
		{
			this.SetTimeToFire((float)this.MagazineROF);
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x0028B294 File Offset: 0x00289494
		public Magazine(ActiveUnit activeUnit_, int DBID_, string Name_, GlobalVariables.ArmorRating armorRating_, int MagazineROF_, int MagazineCapacity_, bool bool_10) : base(activeUnit_)
		{
			this.vmethod_12(new ObservableCollection<WeaponRec>());
			this.DBID = DBID_;
			this.Name = Name_;
			this.armorRating = armorRating_;
			this.MagazineROF = MagazineROF_;
			this.TimeToFire = (float)this.MagazineROF;
			this.MagazineCapacity = MagazineCapacity_;
			this.bool_8 = bool_10;
		}

		// Token: 0x06005B54 RID: 23380 RVA: 0x0028B2F0 File Offset: 0x002894F0
		public string AddToCurrentLoad(int WeaponID_)
		{
			string text = "";
			string result;
			try
			{
				foreach (WeaponRec current in this.GetWeaponRecCollection())
				{
					if (current.GetWeapon(base.GetParentPlatform().m_Scenario).DBID == WeaponID_ && current.GetCurrentLoad() < current.MaxLoad)
					{
						current.SetCurrentLoad(current.GetCurrentLoad() + 1);
						base.method_24();
						text = "OK";
						result = text;
						return result;
					}
				}
				text = "No suitable weapon record found";
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100673", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = text;
			return result;
		}

		// Token: 0x06005B55 RID: 23381 RVA: 0x0028B3E4 File Offset: 0x002895E4
		public int method_29(ref int int_2, ref int int_3)
		{
			int_2 = 0;
			int_3 = 0;
			foreach (WeaponRec current in this.GetWeaponRecCollection())
			{
				if (current.GetCurrentLoad() != 0)
				{
					if (current.Multiple > 1)
					{
						float num = (float)current.GetCurrentLoad() / (float)current.Multiple;
						if (num != (float)((int)Math.Round((double)num)))
						{
							int_3++;
							int_2 += (int)Math.Round(Math.Floor((double)current.GetCurrentLoad() / (double)current.Multiple));
						}
						else
						{
							int_2 += (int)Math.Round((double)num);
						}
					}
					else
					{
						int_2 += current.GetCurrentLoad();
					}
				}
			}
			return int_2 + int_3;
		}

		// Token: 0x06005B56 RID: 23382 RVA: 0x0028B4B8 File Offset: 0x002896B8
		public string method_30(int int_2, bool bool_10, ref float float_1)
		{
			bool flag = false;
			bool flag2 = false;
			string text = "";
			string result;
			try
			{
				foreach (WeaponRec current in this.GetWeaponRecCollection())
				{
					if (current.WeapID == int_2)
					{
						if (current.GetCurrentLoad() > 0)
						{
							if (bool_10)
							{
								current.SetCurrentLoad(current.GetCurrentLoad() - 1);
								current.SetTimeToFire();
								base.method_24();
								text = "OK";
								result = text;
								return result;
							}
							if (current.TimeToFire == 0f)
							{
								current.SetCurrentLoad(current.GetCurrentLoad() - 1);
								float_1 = current.GetROF();
								base.method_24();
								text = "OK";
								result = text;
								return result;
							}
							flag = true;
						}
						else
						{
							flag2 = true;
						}
					}
				}
				if (flag)
				{
					text = "Suitable weapon record found but not ready";
				}
				else if (flag2)
				{
					text = "Suitable weapon record not found";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100674", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = text;
			return result;
		}

		// Token: 0x06005B57 RID: 23383 RVA: 0x00028FF1 File Offset: 0x000271F1
		private void method_31(object sender, NotifyCollectionChangedEventArgs e)
		{
			base.method_24();
		}

		// Token: 0x04002E84 RID: 11908
		public GlobalVariables.ArmorRating armorRating;

		// Token: 0x04002E85 RID: 11909
		public int MagazineROF;

		// Token: 0x04002E86 RID: 11910
		public int MagazineCapacity;

		// Token: 0x04002E87 RID: 11911
		[CompilerGenerated]
		private ObservableCollection<WeaponRec> WeaponRecCollection;

		// Token: 0x04002E88 RID: 11912
		public bool bool_8;

		// Token: 0x04002E89 RID: 11913
		private float TimeToFire;

		// Token: 0x04002E8A RID: 11914
		public bool Hypothetical;
	}
}
