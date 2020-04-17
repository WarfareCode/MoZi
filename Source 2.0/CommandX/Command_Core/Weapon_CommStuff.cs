using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns2;
using ns3;

namespace Command_Core
{
	// 通信设备
	public sealed class Weapon_CommStuff : ActiveUnit_CommStuff
	{
		// Token: 0x0600615D RID: 24925 RVA: 0x002EEDEC File Offset: 0x002ECFEC
		private Weapon GetParentWeapon()
		{
			if (Information.IsNothing(this.ParentWeapon))
			{
				this.ParentWeapon = (Weapon)this.ParentPlatform;
			}
			return this.ParentWeapon;
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x002EEE24 File Offset: 0x002ED024
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					xmlWriter_0.WriteStartElement("Weapon_CommStuff");
					CommDevice[] commDevices = this.ParentPlatform.GetCommDevices();
					for (int i = 0; i < commDevices.Length; i++)
					{
						commDevices[i].SetParentPlatform(this.ParentPlatform);
					}
					xmlWriter_0.WriteStartElement("CLE");
					ActiveUnit_CommLink[] commLinksEstablished = base.GetCommLinksEstablished();
					for (int j = 0; j < commLinksEstablished.Length; j++)
					{
						commLinksEstablished[j].Save(ref xmlWriter_0, ref hashSet_0, this.ParentPlatform.m_Scenario);
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteEndElement();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100973", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600615F RID: 24927 RVA: 0x002EEF00 File Offset: 0x002ED100
		public static Weapon_CommStuff Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Weapon_CommStuff result = null;
			try
			{
				Weapon_CommStuff weapon_CommStuff = new Weapon_CommStuff(ref activeUnit_1);
				weapon_CommStuff.ParentPlatform = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "CommLinksEstablished", false) == 0 || Operators.CompareString(name, "CLE", false) == 0)
						{
							weapon_CommStuff.CommLinksEstablished = new ActiveUnit_CommLink[xmlNode.ChildNodes.Count - 1 + 1];
							int num = xmlNode.ChildNodes.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								XmlNode xmlNode2 = xmlNode.ChildNodes[i];
								ActiveUnit_CommLink activeUnit_CommLink = ActiveUnit_CommLink.Load(ref xmlNode2, ref dictionary_0, ref activeUnit_1);
								weapon_CommStuff.CommLinksEstablished[i] = activeUnit_CommLink;
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
				result = weapon_CommStuff;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100974", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006160 RID: 24928 RVA: 0x000246DA File Offset: 0x000228DA
		public Weapon_CommStuff(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// 是否可与数据链父对象通信
		public bool CanCommToDataLinkParent()
		{
			return !Information.IsNothing(this.GetParentWeapon().GetDataLinkParent()) && !Information.IsNothing(this.GetCommLinkToDataLinkParent()) && !this.GetCommLinkToDataLinkParent().DeviceUsed.commCapability.Receive_Only;
		}

		// Token: 0x06006162 RID: 24930 RVA: 0x002EF05C File Offset: 0x002ED25C
		public ActiveUnit_CommLink GetCommLinkToDataLinkParent()
		{
			ActiveUnit_CommLink[] commLinksEstablished = base.GetCommLinksEstablished();
			ActiveUnit_CommLink activeUnit_CommLink = null;
			checked
			{
				ActiveUnit_CommLink result;
				for (int i = 0; i < commLinksEstablished.Length; i++)
				{
					ActiveUnit_CommLink activeUnit_CommLink2 = commLinksEstablished[i];
					if (activeUnit_CommLink2.CommPartner == this.GetParentWeapon().GetDataLinkParent())
					{
						activeUnit_CommLink = activeUnit_CommLink2;
						result = activeUnit_CommLink;
						return result;
					}
				}
				result = activeUnit_CommLink;
				return result;
			}
		}

		// 清除被占用的通道
		public override void ClearOccupiedChannels()
		{
			if (this.float_0 <= 0f)
			{
				base.ClearOccupiedChannels();
			}
		}

		// Token: 0x06006164 RID: 24932 RVA: 0x002EF0AC File Offset: 0x002ED2AC
		public override bool vmethod_3(CommDevice commDevice_0, ActiveUnit activeUnit_1, bool bool_1)
		{
			bool result;
			if (result = base.vmethod_3(commDevice_0, activeUnit_1, bool_1))
			{
				this.GetParentWeapon().SetDataLinkParent(activeUnit_1);
			}
			return result;
		}

		// Token: 0x06006165 RID: 24933 RVA: 0x002EF0D8 File Offset: 0x002ED2D8
		public override void vmethod_1(float float_1)
		{
			try
			{
				Weapon parentWeapon = this.GetParentWeapon();
				if (!Information.IsNothing(parentWeapon.GetDataLinkParent()))
				{
					if (parentWeapon.GetDataLinkParent().IsNotActive())
					{
						parentWeapon.SetDataLinkParent(null);
					}
					else if (!parentWeapon.GetDataLinkParent().IsOperating())
					{
						parentWeapon.SetDataLinkParent(null);
					}
				}
				else if (base.GetCommLinksEstablished().Length > 0)
				{
					base.ClearOccupiedChannels();
				}
				this.float_0 -= float_1;
				if (!parentWeapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
				{
					if (this.float_0 > 0f)
					{
						return;
					}
					this.float_0 = (float)this.ParentPlatform.GetRandom().Next(1, 16);
				}
				if (this.float_0 < 0f)
				{
					this.float_0 = 0f;
				}
				CommDevice[] commDevices = this.ParentPlatform.GetCommDevices();
				checked
				{
					if (commDevices.Length != 0 && base.HaveFreeChannelAvaible())
					{
						if (!Information.IsNothing(parentWeapon.GetDataLinkParent()))
						{
							CommDevice commDevice = base.method_7(commDevices, parentWeapon.GetDataLinkParent());
							if (!Information.IsNothing(commDevice))
							{
								this.vmethod_3(commDevice, parentWeapon.GetDataLinkParent(), false);
							}
							else
							{
								parentWeapon.SetDataLinkParent(null);
							}
						}
						if (Information.IsNothing(parentWeapon.GetDataLinkParent()) && commDevices.Where(Weapon_CommStuff.IsNotParentSpecific).Any<CommDevice>())
						{
							Weapon_CommStuff.DistanceMeasurer distanceMeasurer = new Weapon_CommStuff.DistanceMeasurer(null);
							double num = commDevices.Select(Weapon_CommStuff.GetCommunicationRange).Max();
							Math2.ApproxAngularDistance(num);
							distanceMeasurer.Latitude = parentWeapon.GetLatitude(null);
							distanceMeasurer.Longitude = parentWeapon.GetLongitude(null);
							LinkedList<ActiveUnit> linkedList = new LinkedList<ActiveUnit>();
							ActiveUnit[] array = this.ParentPlatform.GetSide(false).GetNoneWeaponFriendlyUnitsIsOperating(this.ParentPlatform.m_Scenario);
							for (int i = 0; i < array.Length; i++)
							{
								ActiveUnit activeUnit = array[i];
								if (activeUnit != this.ParentPlatform && !activeUnit.IsWeapon && (parentWeapon.GetWeaponType() != Weapon._WeaponType.Sonobuoy || !activeUnit.IsFacility))
								{
									linkedList.AddLast(activeUnit);
								}
							}
							List<ActiveUnit> list = RangeCalculator.GetUnitsInRange(linkedList, true, distanceMeasurer.Latitude, distanceMeasurer.Longitude, num);
							list = list.OrderBy(new Func<ActiveUnit, double>(distanceMeasurer.GetAngularDistance)).ToList<ActiveUnit>();
							foreach (ActiveUnit current in list)
							{
								CommDevice commDevice2 = base.method_7(commDevices, current);
								if (!Information.IsNothing(commDevice2))
								{
									base.ClearOccupiedChannels();
									if (parentWeapon.GetWeaponType() == Weapon._WeaponType.Sonobuoy)
									{
										this.vmethod_3(commDevice2, current, false);
									}
									else
									{
										this.vmethod_3(commDevice2, current, true);
									}
									break;
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
				ex2.Data.Add("Error at 100975", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x04003464 RID: 13412
		public static Func<CommDevice, bool> IsNotParentSpecific = (CommDevice commDevice_0) => !commDevice_0.ParentSpecific;

		// Token: 0x04003465 RID: 13413
		public static Func<CommDevice, double> GetCommunicationRange = (CommDevice commDevice_0) => commDevice_0.Range;

		// 所在的武器
		private Weapon ParentWeapon;

		// Token: 0x02000B7F RID: 2943
		[CompilerGenerated]
		public sealed class DistanceMeasurer
		{
			// Token: 0x06006169 RID: 24937 RVA: 0x0002B1A5 File Offset: 0x000293A5
			public DistanceMeasurer(Weapon_CommStuff.DistanceMeasurer DistanceMeasurer_)
			{
				if (DistanceMeasurer_ != null)
				{
					this.Latitude = DistanceMeasurer_.Latitude;
					this.Longitude = DistanceMeasurer_.Longitude;
				}
			}

			// 取角距离
			internal double GetAngularDistance(ActiveUnit activeUnit_)
			{
				return RangeCalculator.GetAngularDistance(this.Latitude, this.Longitude, activeUnit_.GetLatitude(null), activeUnit_.GetLongitude(null));
			}

			// 属性
			public double Latitude;// 纬度			
			public double Longitude;// 经度
		}
	}
}
