using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// 活动实体的武器
	public class ActiveUnit_Weaponry
	{
		// Token: 0x06004144 RID: 16708 RVA: 0x00164594 File Offset: 0x00162794
		[CompilerGenerated]
		protected virtual ObservableCollection<WeaponAssignment> GetWeaponAssignments()
		{
			return this.WeaponAssignments;
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x001645AC File Offset: 0x001627AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		protected virtual void vmethod_1(ObservableCollection<WeaponAssignment> observableCollection_1)
		{
			NotifyCollectionChangedEventHandler value = new NotifyCollectionChangedEventHandler(this.WeaponAssignments_CollectionChanged);
			ObservableCollection<WeaponAssignment> weaponAssignments = this.WeaponAssignments;
			if (weaponAssignments != null)
			{
				weaponAssignments.CollectionChanged -= value;
			}
			this.WeaponAssignments = observableCollection_1;
			weaponAssignments = this.WeaponAssignments;
			if (weaponAssignments != null)
			{
				weaponAssignments.CollectionChanged += value;
			}
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x001645F8 File Offset: 0x001627F8
		[CompilerGenerated]
		public static void smethod_0(ActiveUnit_Weaponry.Delegate5 delegate5_1)
		{
			ActiveUnit_Weaponry.Delegate5 @delegate = ActiveUnit_Weaponry.delegate5_0;
			ActiveUnit_Weaponry.Delegate5 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_Weaponry.Delegate5 value = (ActiveUnit_Weaponry.Delegate5)Delegate.Combine(delegate2, delegate5_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_Weaponry.Delegate5>(ref ActiveUnit_Weaponry.delegate5_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x00164630 File Offset: 0x00162830
		public virtual void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			try
			{
				xmlWriter_0.WriteStartElement("ActiveUnit_Weaponry");
				if (this.GetWeaponAssignments().Count > 0)
				{
					xmlWriter_0.WriteStartElement("WeaponAssignments");
					using (IEnumerator<WeaponAssignment> enumerator = this.GetWeaponAssignments().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.Save(ref xmlWriter_0, ref hashSet_1);
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100284", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x00021241 File Offset: 0x0001F441
		private ActiveUnit_Weaponry()
		{
			this.vmethod_1(new ObservableCollection<WeaponAssignment>());
			this.lazy_0 = new Lazy<ConcurrentDictionary<Tuple<int, string>, string>>();
			this.hashSet_0 = new HashSet<string>();
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x00021271 File Offset: 0x0001F471
		public ActiveUnit_Weaponry(ActiveUnit activeUnit_1)
		{
			this.vmethod_1(new ObservableCollection<WeaponAssignment>());
			this.lazy_0 = new Lazy<ConcurrentDictionary<Tuple<int, string>, string>>();
			this.hashSet_0 = new HashSet<string>();
			this.ParentPlatform = activeUnit_1;
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x00164704 File Offset: 0x00162904
		public List<WeaponRec> method_0(bool bool_7)
		{
			List<WeaponRec> list = new List<WeaponRec>();
			List<WeaponRec> result = null;
			try
			{
				Mount[] mounts = this.ParentPlatform.m_Mounts;
				if (mounts.Length > 0)
				{
					int num = mounts.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						Mount mount = mounts[i];
						ObservableCollection<WeaponRec> weaponRecCollection = mount.GetWeaponRecCollection();
						int num2 = weaponRecCollection.Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							WeaponRec item = weaponRecCollection[j];
							list.Add(item);
						}
						ObservableCollection<WeaponRec> weaponRecCollection2 = mount.GetMagazineForMount().GetWeaponRecCollection();
						int num3 = weaponRecCollection2.Count - 1;
						for (int k = 0; k <= num3; k++)
						{
							WeaponRec item = weaponRecCollection2[k];
							list.Add(item);
						}
					}
				}
				Magazine[] magazines = this.ParentPlatform.GetMagazines();
				if (!Information.IsNothing(magazines))
				{
					int num4 = magazines.Length - 1;
					for (int l = 0; l <= num4; l++)
					{
						Magazine magazine = magazines[l];
						if (bool_7 || !magazine.bool_8)
						{
							ObservableCollection<WeaponRec> weaponRecCollection3 = magazine.GetWeaponRecCollection();
							int num5 = weaponRecCollection3.Count - 1;
							for (int m = 0; m <= num5; m++)
							{
								WeaponRec item = weaponRecCollection3[m];
								list.Add(item);
							}
						}
					}
				}
				if (this.ParentPlatform.IsAircraft && !Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
				{
					WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
					int num6 = weaponRecArray.Length - 1;
					for (int n = 0; n <= num6; n++)
					{
						WeaponRec item = weaponRecArray[n];
						list.Add(item);
					}
				}
				result = list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101300", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x00164930 File Offset: 0x00162B30
		public Dictionary<int, WeaponRec> method_1(bool bool_7)
		{
			Dictionary<int, WeaponRec> dictionary = new Dictionary<int, WeaponRec>();
			Dictionary<int, WeaponRec> result = null;
			try
			{
				Mount[] mounts = this.ParentPlatform.m_Mounts;
				if (mounts.Length > 0)
				{
					int num = mounts.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						Mount mount = mounts[i];
						ObservableCollection<WeaponRec> weaponRecCollection = mount.GetWeaponRecCollection();
						int num2 = weaponRecCollection.Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							WeaponRec weaponRec = weaponRecCollection[j];
							if (!dictionary.ContainsKey(weaponRec.WeapID))
							{
								dictionary.Add(weaponRec.WeapID, weaponRec);
							}
						}
						ObservableCollection<WeaponRec> weaponRecCollection2 = mount.GetMagazineForMount().GetWeaponRecCollection();
						int num3 = weaponRecCollection2.Count - 1;
						for (int k = 0; k <= num3; k++)
						{
							WeaponRec weaponRec = weaponRecCollection2[k];
							if (!dictionary.ContainsKey(weaponRec.WeapID))
							{
								dictionary.Add(weaponRec.WeapID, weaponRec);
							}
						}
					}
				}
				Magazine[] magazines = this.ParentPlatform.GetMagazines();
				if (!Information.IsNothing(magazines))
				{
					int num4 = magazines.Length - 1;
					for (int l = 0; l <= num4; l++)
					{
						Magazine magazine = magazines[l];
						if (bool_7 || !magazine.bool_8)
						{
							ObservableCollection<WeaponRec> weaponRecCollection3 = magazine.GetWeaponRecCollection();
							int num5 = weaponRecCollection3.Count - 1;
							for (int m = 0; m <= num5; m++)
							{
								WeaponRec weaponRec = weaponRecCollection3[m];
								if (!dictionary.ContainsKey(weaponRec.WeapID))
								{
									dictionary.Add(weaponRec.WeapID, weaponRec);
								}
							}
						}
					}
				}
				if (this.ParentPlatform.IsAircraft && !Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
				{
					WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
					int num6 = weaponRecArray.Length - 1;
					for (int n = 0; n <= num6; n++)
					{
						WeaponRec weaponRec = weaponRecArray[n];
						if (!dictionary.ContainsKey(weaponRec.WeapID))
						{
							dictionary.Add(weaponRec.WeapID, weaponRec);
						}
					}
				}
				result = dictionary;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101301", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x00164BB8 File Offset: 0x00162DB8
		public Dictionary<int, Weapon> GetWeaponsDictionary(bool bool_7)
		{
			Dictionary<int, Weapon> dictionary = new Dictionary<int, Weapon>();
			Dictionary<int, Weapon> result = null;
			try
			{
				Mount[] mounts = this.ParentPlatform.m_Mounts;
				if (mounts.Length > 0)
				{
					int num = mounts.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						Mount mount = mounts[i];
						ObservableCollection<WeaponRec> weaponRecCollection = mount.GetWeaponRecCollection();
						int num2 = weaponRecCollection.Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							WeaponRec weaponRec = weaponRecCollection[j];
							if (!dictionary.ContainsKey(weaponRec.WeapID))
							{
								dictionary.Add(weaponRec.WeapID, weaponRec.GetWeapon(this.ParentPlatform.m_Scenario));
							}
						}
						ObservableCollection<WeaponRec> weaponRecCollection2 = mount.GetMagazineForMount().GetWeaponRecCollection();
						int num3 = weaponRecCollection2.Count - 1;
						for (int k = 0; k <= num3; k++)
						{
							WeaponRec weaponRec = weaponRecCollection2[k];
							if (!dictionary.ContainsKey(weaponRec.WeapID))
							{
								dictionary.Add(weaponRec.WeapID, weaponRec.GetWeapon(this.ParentPlatform.m_Scenario));
							}
						}
					}
				}
				Magazine[] magazines = this.ParentPlatform.GetMagazines();
				if (!Information.IsNothing(magazines))
				{
					int num4 = magazines.Length - 1;
					for (int l = 0; l <= num4; l++)
					{
						Magazine magazine = magazines[l];
						if (bool_7 || !magazine.bool_8)
						{
							ObservableCollection<WeaponRec> weaponRecCollection3 = magazine.GetWeaponRecCollection();
							int num5 = weaponRecCollection3.Count - 1;
							for (int m = 0; m <= num5; m++)
							{
								WeaponRec weaponRec = weaponRecCollection3[m];
								if (!dictionary.ContainsKey(weaponRec.WeapID))
								{
									dictionary.Add(weaponRec.WeapID, weaponRec.GetWeapon(this.ParentPlatform.m_Scenario));
								}
							}
						}
					}
				}
				if (this.ParentPlatform.IsAircraft && !Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
				{
					WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
					int num6 = weaponRecArray.Length - 1;
					for (int n = 0; n <= num6; n++)
					{
						WeaponRec weaponRec = weaponRecArray[n];
						if (!dictionary.ContainsKey(weaponRec.WeapID))
						{
							dictionary.Add(weaponRec.WeapID, weaponRec.GetWeapon(this.ParentPlatform.m_Scenario));
						}
					}
				}
				result = dictionary;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100287", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x000212A8 File Offset: 0x0001F4A8
		public void method_3()
		{
			if (this.ParentPlatform.m_Scenario.SecondIsChangingOnThisPulse)
			{
				this.method_4();
			}
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x00164E84 File Offset: 0x00163084
		public void method_4()
		{
			this.WeaponArray = null;
			this.weapon_3 = null;
			this.weapon_2 = null;
			this.bool_3 = false;
			this.bool_2 = false;
			this.Weapon_AirRangeMax = null;
			this.bool_1 = false;
			this.weapon_5 = null;
			this.weapon_4 = null;
			this.bool_5 = false;
			this.bool_4 = false;
			this.weapon_6 = null;
			this.bool_6 = false;
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x00164EEC File Offset: 0x001630EC
		public Weapon[] GetAvailableWeapons(bool bool_7)
		{
			if (Information.IsNothing(this.WeaponArray))
			{
				HashSet<int> hashSet = new HashSet<int>();
				Weapon[] weaponArray = new Weapon[0];
				try
				{
					Mount[] mounts = this.ParentPlatform.m_Mounts;
					if (mounts.Length > 0)
					{
						int num = mounts.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							Mount mount = mounts[i];
							ObservableCollection<WeaponRec> weaponRecCollection = mount.GetWeaponRecCollection();
							int num2 = weaponRecCollection.Count - 1;
							for (int j = 0; j <= num2; j++)
							{
								WeaponRec weaponRec = weaponRecCollection[j];
								if (weaponRec.GetCurrentLoad() > 0 && !hashSet.Contains(weaponRec.WeapID))
								{
									hashSet.Add(weaponRec.WeapID);
									ScenarioArrayUtil.AddWeapon(ref weaponArray, weaponRec.GetWeapon(this.ParentPlatform.m_Scenario));
								}
							}
							ObservableCollection<WeaponRec> weaponRecCollection2 = mount.GetMagazineForMount().GetWeaponRecCollection();
							int num3 = weaponRecCollection2.Count - 1;
							for (int k = 0; k <= num3; k++)
							{
								WeaponRec weaponRec = weaponRecCollection2[k];
								if (weaponRec.GetCurrentLoad() > 0 && !hashSet.Contains(weaponRec.WeapID))
								{
									hashSet.Add(weaponRec.WeapID);
									ScenarioArrayUtil.AddWeapon(ref weaponArray, weaponRec.GetWeapon(this.ParentPlatform.m_Scenario));
								}
							}
						}
					}
					Magazine[] magazines = this.ParentPlatform.GetMagazines();
					if (!Information.IsNothing(magazines))
					{
						int num4 = magazines.Length - 1;
						for (int l = 0; l <= num4; l++)
						{
							Magazine magazine = magazines[l];
							if (bool_7 || !magazine.bool_8)
							{
								ObservableCollection<WeaponRec> weaponRecCollection3 = magazine.GetWeaponRecCollection();
								int num5 = weaponRecCollection3.Count - 1;
								for (int m = 0; m <= num5; m++)
								{
									WeaponRec weaponRec = weaponRecCollection3[m];
									if (weaponRec.GetCurrentLoad() > 0 && !hashSet.Contains(weaponRec.WeapID))
									{
										hashSet.Add(weaponRec.WeapID);
										ScenarioArrayUtil.AddWeapon(ref weaponArray, weaponRec.GetWeapon(this.ParentPlatform.m_Scenario));
									}
								}
							}
						}
					}
					if (this.ParentPlatform.IsAircraft && !Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
					{
						WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
						int num6 = weaponRecArray.Length - 1;
						for (int n = 0; n <= num6; n++)
						{
							WeaponRec weaponRec = weaponRecArray[n];
							if (weaponRec.GetCurrentLoad() > 0 && !hashSet.Contains(weaponRec.WeapID))
							{
								hashSet.Add(weaponRec.WeapID);
								ScenarioArrayUtil.AddWeapon(ref weaponArray, weaponRec.GetWeapon(this.ParentPlatform.m_Scenario));
							}
						}
					}
					this.WeaponArray = weaponArray;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100288", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			return this.WeaponArray;
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x000212C5 File Offset: 0x0001F4C5
		public void ClearWeapons()
		{
			this.WeaponArray = null;
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x00165230 File Offset: 0x00163430
		public int GetDefaultLoadForWeapon(int WeaponID_)
		{
			int result = 0;
			checked
			{
				try
				{
					Mount[] mounts = this.ParentPlatform.m_Mounts;
					int num = 0;
					for (int i = 0; i < mounts.Length; i++)
					{
						Mount mount = mounts[i];
						unchecked
						{
							if (mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
							{
								foreach (WeaponRec current in mount.GetWeaponRecCollection())
								{
									if (current.WeapID == WeaponID_)
									{
										num += current.DefaultLoad;
									}
								}
								foreach (WeaponRec current2 in mount.GetMagazineForMount().GetWeaponRecCollection())
								{
									if (current2.WeapID == WeaponID_)
									{
										num += current2.DefaultLoad;
									}
								}
							}
						}
					}
					Magazine[] magazines = this.ParentPlatform.GetMagazines();
					for (int j = 0; j < magazines.Length; j++)
					{
						Magazine magazine = magazines[j];
						unchecked
						{
							if (magazine.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
							{
								foreach (WeaponRec current3 in magazine.GetWeaponRecCollection())
								{
									if (current3.WeapID == WeaponID_)
									{
										num += current3.DefaultLoad;
									}
								}
							}
						}
					}
					if (this.ParentPlatform.IsAircraft && !Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
					{
						WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
						for (int k = 0; k < weaponRecArray.Length; k++)
						{
							WeaponRec weaponRec = weaponRecArray[k];
							unchecked
							{
								if (weaponRec.WeapID == WeaponID_)
								{
									num += weaponRec.DefaultLoad;
								}
							}
						}
					}
					result = num;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100290", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x001654C0 File Offset: 0x001636C0
		public int GetCurrentLoadForWeapon(int WeaponID_, bool bool_7)
		{
			int result = 0;
			checked
			{
				try
				{
					Mount[] mounts = this.ParentPlatform.m_Mounts;
					int num = 0;
					for (int i = 0; i < mounts.Length; i++)
					{
						Mount mount = mounts[i];
						unchecked
						{
							if (mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational || bool_7)
							{
								foreach (WeaponRec current in mount.GetWeaponRecCollection())
								{
									if (current.WeapID == WeaponID_)
									{
										num += current.GetCurrentLoad();
									}
								}
								foreach (WeaponRec current2 in mount.GetMagazineForMount().GetWeaponRecCollection())
								{
									if (current2.WeapID == WeaponID_)
									{
										num += current2.GetCurrentLoad();
									}
								}
							}
						}
					}
					Magazine[] magazines = this.ParentPlatform.GetMagazines();
					for (int j = 0; j < magazines.Length; j++)
					{
						Magazine magazine = magazines[j];
						unchecked
						{
							if (magazine.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational || bool_7)
							{
								foreach (WeaponRec current3 in magazine.GetWeaponRecCollection())
								{
									if (current3.WeapID == WeaponID_)
									{
										num += current3.GetCurrentLoad();
									}
								}
							}
						}
					}
					if (this.ParentPlatform.IsAircraft && !Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
					{
						WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
						for (int k = 0; k < weaponRecArray.Length; k++)
						{
							WeaponRec weaponRec = weaponRecArray[k];
							unchecked
							{
								if (weaponRec.WeapID == WeaponID_)
								{
									num += weaponRec.GetCurrentLoad();
								}
							}
						}
					}
					result = num;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100292", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x00165754 File Offset: 0x00163954
		public bool HasWeaponsInConditionToAttackTarget(Contact theTarget, bool CheckWRA, Doctrine theDoc, ref string Feedback, ref int FeedbackSeverity, Weapon[] AvailableWeapons = null)
		{
			bool flag = false;
			bool result;
			try
			{
				Weapon[] array;
				if (Information.IsNothing(AvailableWeapons))
				{
					array = this.GetAvailableWeapons(false);
				}
				else
				{
					array = AvailableWeapons;
				}
				int num = array.Length - 1;
				int i = 0;
				while (i <= num)
				{
					Weapon weapon = array[i];
					if (!this.ParentPlatform.IsAircraft || !theTarget.IsSurfaceOrLandTarget() || weapon.GetWeaponType() != Weapon._WeaponType.Gun)
					{
						goto IL_E6;
					}
					Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = null;
					if (Information.IsNothing(gunStrafeGroundTargets))
					{
						gunStrafeGroundTargets = this.ParentPlatform.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
					}
					byte? b = gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null;
					if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						goto IL_E6;
					}
					if (FeedbackSeverity < 2)
					{
						Feedback = "没有现有武器可以打击的目标(仅剩的武器是航炮，但是条令设置不允许使用航炮扫射).";
						FeedbackSeverity = 2;
					}
					IL_281:
					i++;
					continue;
					IL_E6:
					if (weapon.IsSuitableForTarget(this.ParentPlatform.m_Scenario, ref theTarget))
					{
						if (CheckWRA && !Information.IsNothing(theDoc) && theDoc.IsLethalWeapon(ref weapon))
						{
							Doctrine doctrine = weapon.m_Doctrine;
							Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = theDoc.GetWRA_WeaponTargetType(ref theTarget);
							Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType2 = doctrine.GetWRA_WeaponTargetType(ref weapon, ref theDoc, ref theTarget, ref wRA_WeaponTargetType);
							Doctrine doctrine2 = theDoc;
							Scenario scenario = weapon.m_Scenario;
							Weapon theWeapon = weapon;
							Doctrine._WRA_WeaponTargetType selectedNodeTargetType = wRA_WeaponTargetType2;
							int? num2 = null;
							int? num3 = null;
							num3 = doctrine2.GetWeaponQty(scenario, theWeapon, selectedNodeTargetType, false, ref num2, ref num3);
							if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								if (FeedbackSeverity < 4)
								{
									Feedback = "没有现有武器可以打击的目标 (武器使用规则—目标类型).";
									FeedbackSeverity = 4;
									goto IL_281;
								}
								goto IL_281;
							}
							else
							{
								Doctrine doctrine3 = theDoc;
								Scenario scenario2 = weapon.m_Scenario;
								int dBID = weapon.DBID;
								Doctrine._WRA_WeaponTargetType selectedNodeTargetType2 = wRA_WeaponTargetType2;
								num3 = null;
								num2 = null;
								int? firingRange = doctrine3.GetFiringRange(scenario2, dBID, selectedNodeTargetType2, false, ref num3, ref num2);
								if (!Information.IsNothing(firingRange))
								{
									num2 = firingRange;
									if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										if (FeedbackSeverity < 5)
										{
											Feedback = "没有现有武器可以打击的目标(武器使用规则—开火距离).";
											FeedbackSeverity = 5;
											goto IL_281;
										}
										goto IL_281;
									}
								}
							}
						}
						flag = true;
						result = true;
						return result;
					}
					goto IL_281;
				}
				if (FeedbackSeverity < 3)
				{
					Feedback = "没有现有武器可以打击的目标(弹目不匹配).";
					FeedbackSeverity = 3;
				}
				flag = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100293", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x00165A78 File Offset: 0x00163C78
		public void LayMines(float elapsedTime, long long_0)
		{
			List<WeaponRec> list = new List<WeaponRec>();
			List<Mount> list2 = new List<Mount>();
			List<Mount> list3 = new List<Mount>();
			List<Mount> list4 = new List<Mount>();
			checked
			{
				try
				{
					Mount[] mounts = this.ParentPlatform.m_Mounts;
					for (int i = 0; i < mounts.Length; i++)
					{
						Mount mount = mounts[i];
						foreach (WeaponRec weaponRec in mount.GetWeaponRecCollection())
						{
							weaponRec.myMount = mount;
							Weapon weapon = weaponRec.GetWeapon(this.ParentPlatform.m_Scenario);
							if (weapon.IsMine())
							{
								if (mount.RPrioritySet.Count == 0 && !list4.Contains(mount))
								{
									list4.Add(mount);
								}
								if (this.ParentPlatform.m_Scenario.FeatureCompatibility.get_WeaponAGL_ASL(this.ParentPlatform.m_Scenario.GetSQLiteConnection()) && weapon.LaunchAltitudeMax == 0f && weapon.LaunchAltitudeMin == 0f)
								{
									if (weapon.LaunchAltitudeMax_ASL < this.ParentPlatform.GetCurrentAltitude_ASL(false))
									{
										continue;
									}
									if (weapon.LaunchAltitudeMin_ASL > this.ParentPlatform.GetCurrentAltitude_ASL(false))
									{
										continue;
									}
								}
								else if (weapon.LaunchAltitudeMax < this.ParentPlatform.GetCurrentAltitude_ASL(false) || weapon.LaunchAltitudeMin > this.ParentPlatform.GetCurrentAltitude_ASL(false))
								{
									continue;
								}
								if (weaponRec.GetCurrentLoad() != 0 && mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
								{
									if (mount.RPrioritySet.Count == 0 && !list3.Contains(mount))
									{
										list3.Add(mount);
									}
									if (mount.GetTimeToFire() == 0f && weaponRec.TimeToFire == 0f)
									{
										if (mount.RPrioritySet.Count == 0 && !list2.Contains(mount))
										{
											list2.Add(mount);
										}
										UnguidedWeapon unguidedWeapon = new UnguidedWeapon(weapon, null, null, 0.0, 0.0, 0L);
										string text = UnguidedWeapon.LayMine(ref unguidedWeapon, this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), (float)this.ParentPlatform.GetTerrainElevation(false, false, false), this.ParentPlatform.m_Scenario);
										if (string.CompareOrdinal(text, "OK") != 0)
										{
											string text2 = "";
											if (Operators.CompareString(this.ParentPlatform.Name, this.ParentPlatform.UnitClass, false) != 0)
											{
												text2 = " (" + this.ParentPlatform.UnitClass + ")";
											}
											this.ParentPlatform.m_Scenario.LogMessage(string.Concat(new string[]
											{
												this.ParentPlatform.Name,
												text2,
												"不能部署如下型号的水雷：",
												weapon.Name,
												": ",
												text
											}), LoggedMessage.MessageType.WeaponEndgame, 0, null, null, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
										}
										else
										{
											list.Add(weaponRec);
										}
									}
								}
							}
						}
					}
					if (this.ParentPlatform.IsAircraft)
					{
						if (!Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
						{
							WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
							for (int j = 0; j < weaponRecArray.Length; j++)
							{
								WeaponRec weaponRec = weaponRecArray[j];
								weaponRec.myMount = null;
								Weapon weapon2 = weaponRec.GetWeapon(this.ParentPlatform.m_Scenario);
								if (weapon2.IsMine())
								{
									if (this.ParentPlatform.m_Scenario.FeatureCompatibility.get_WeaponAGL_ASL(this.ParentPlatform.m_Scenario.GetSQLiteConnection()) && weapon2.LaunchAltitudeMax == 0f)
									{
										if (weapon2.LaunchAltitudeMax_ASL < this.ParentPlatform.GetCurrentAltitude_ASL(false))
										{
											goto IL_517;
										}
									}
									else if (weapon2.LaunchAltitudeMax < this.ParentPlatform.GetCurrentAltitude_ASL(false))
									{
										goto IL_517;
									}
									if (weaponRec.GetCurrentLoad() != 0 && weaponRec.TimeToFire <= 0f)
									{
										UnguidedWeapon unguidedWeapon2 = new UnguidedWeapon(weapon2, null, null, 0.0, 0.0, 0L);
										if (string.CompareOrdinal(UnguidedWeapon.LayMine(ref unguidedWeapon2, this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), (float)this.ParentPlatform.GetTerrainElevation(false, false, false), this.ParentPlatform.m_Scenario), "OK") == 0)
										{
											list.Add(weaponRec);
										}
									}
								}
								IL_517:;
							}
						}
						if (list.Count == 0)
						{
							return;
						}
					}
					if (!this.ParentPlatform.IsAircraft)
					{
						if (list.Count == 0 && list4.Count == 0)
						{
							return;
						}
						if (list.Count == 0 && list3.Count == list2.Count)
						{
							Mount mount2 = list4[GameGeneral.GetRandom().Next(0, list4.Count)];
							WeaponRec weaponRec2 = mount2.GetWeaponRecCollection().FirstOrDefault(ActiveUnit_Weaponry.WeaponRecFunc0);
							WeaponRec weaponRec3 = mount2.GetWeaponRecCollection().FirstOrDefault(new Func<WeaponRec, bool>(this.method_58));
							if (weaponRec2 != null && weaponRec3 != null)
							{
								this.method_36(ref mount2, ref weaponRec2);
								this.method_37(ref mount2, ref weaponRec3);
							}
							return;
						}
						if (list.Count == 0)
						{
							return;
						}
					}
					WeaponRec weaponRec4;
					if (list.Count == 1)
					{
						weaponRec4 = list[0];
					}
					else
					{
						weaponRec4 = list[GameGeneral.GetRandom().Next(0, list.Count)];
					}
					Contact theTarget = null;
					int num = 0;
					float initialHeading = 0f;
					Mount firingMount = null;
					WeaponSalvo weaponSalvo = null;
					this.FireWeapons(elapsedTime, ref weaponRec4, theTarget, false, ref num, 0, initialHeading, ActiveUnit.Throttle.Flank, firingMount, SonarEnvironment._SonobuoyDepthSetting.Shallow, long_0, ref weaponSalvo);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100294", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x00166164 File Offset: 0x00164364
		public virtual ActiveUnit._ActiveUnitWeaponState vmethod_3()
		{
			ActiveUnit._ActiveUnitWeaponState result = ActiveUnit._ActiveUnitWeaponState.None;
			if (this.ParentPlatform.m_Mounts.Length == 0)
			{
				result = ActiveUnit._ActiveUnitWeaponState.None;
			}
			else
			{
				try
				{
					this.ParentPlatform.m_Mounts.Where(ActiveUnit_Weaponry.EmptyMountFilter).Count<Mount>();
					if (this.ParentPlatform.m_Mounts.Length == 0)
					{
						result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100295", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x00166210 File Offset: 0x00164410
		public Doctrine._WeaponControlStatus GetWeaponControlStatusFor(Contact_Base.ContactType contactType_)
		{
			switch (contactType_)
			{
			case Contact_Base.ContactType.Air:
			case Contact_Base.ContactType.Missile:
			case Contact_Base.ContactType.Orbital:
			case Contact_Base.ContactType.Decoy_Air:
			{
				Doctrine._WeaponControlStatus value = this.ParentPlatform.m_Doctrine.GetWCS_AirDoctrine(this.ParentPlatform.m_Scenario, false, null, false, false).Value;
				Doctrine._WeaponControlStatus result = value;
				return result;
			}
			case Contact_Base.ContactType.Surface:
			case Contact_Base.ContactType.Decoy_Surface:
			case Contact_Base.ContactType.ActivationPoint:
			{
				Doctrine._WeaponControlStatus value2 = this.ParentPlatform.m_Doctrine.GetWCS_SurfaceDoctrine(this.ParentPlatform.m_Scenario, false, null, false, false).Value;
				Doctrine._WeaponControlStatus result = value2;
				return result;
			}
			case Contact_Base.ContactType.Submarine:
			case Contact_Base.ContactType.Torpedo:
			case Contact_Base.ContactType.Decoy_Sub:
			{
				Doctrine._WeaponControlStatus value2 = this.ParentPlatform.m_Doctrine.GetWCS_SubmarineDoctrine(this.ParentPlatform.m_Scenario, false, null, false, false).Value;
				Doctrine._WeaponControlStatus result = value2;
				return result;
			}
			case Contact_Base.ContactType.Aimpoint:
			case Contact_Base.ContactType.Facility_Fixed:
			case Contact_Base.ContactType.Facility_Mobile:
			case Contact_Base.ContactType.Decoy_Land:
			case Contact_Base.ContactType.Installation:
			case Contact_Base.ContactType.AirBase:
			case Contact_Base.ContactType.NavalBase:
			case Contact_Base.ContactType.MobileGroup:
			{
				Doctrine._WeaponControlStatus value2 = this.ParentPlatform.m_Doctrine.GetWCS_LandDoctrine(this.ParentPlatform.m_Scenario, false, null, false, false).Value;
				Doctrine._WeaponControlStatus result = value2;
				return result;
			}
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x00166378 File Offset: 0x00164578
		public virtual void HandleWeaponSalvos(float elapsedTime)
		{
			checked
			{
				if (this.ParentPlatform.GetSide(false).WeaponSalvos.Length != 0)
				{
					bool flag = false;
					Dictionary<string, WeaponSalvo> dictionary = new Dictionary<string, WeaponSalvo>();
					List<WeaponSalvo> list = new List<WeaponSalvo>();
					try
					{
						this.bool_0 = false;
						List<WeaponSalvo> list2 = new List<WeaponSalvo>();
						WeaponSalvo[] weaponSalvos = this.ParentPlatform.GetSide(false).WeaponSalvos;
						for (int i = 0; i < weaponSalvos.Length; i++)
						{
							WeaponSalvo weaponSalvo = weaponSalvos[i];
							if (Information.IsNothing(weaponSalvo))
							{
								list.Add(weaponSalvo);
							}
							else if (weaponSalvo.m_Shooters.Length == 0)
							{
								if (weaponSalvo.GetTotalQuantityAssigned() == 0 && weaponSalvo.GetTotalQuantityFired() == 0)
								{
									list.Add(weaponSalvo);
								}
							}
							else
							{
								list2.Add(weaponSalvo);
							}
						}
						if (list.Count > 0)
						{
							foreach (WeaponSalvo current in list)
							{
								ScenarioArrayUtil.RemoveWeaponSalvo(ref this.ParentPlatform.GetSide(false).WeaponSalvos, current);
							}
							list.Clear();
						}
                        WeaponSalvo current2X;

                        foreach (WeaponSalvo current2 in list2)
						{
							Doctrine._WeaponControlStatus weaponControlStatusFor = this.GetWeaponControlStatusFor(current2.Target.contactType);
							WeaponSalvo.Shooter shooter = null;
							WeaponSalvo.Shooter[] array2;
							int k;
							unchecked
							{
								WeaponSalvo.Shooter[] array = new WeaponSalvo.Shooter[current2.m_Shooters.Length - 1 + 1];
								int num = array.Length - 1;
								for (int j = 0; j <= num; j++)
								{
									array[j] = current2.m_Shooters[j];
								}
								array2 = array;
								k = 0;
							}
							while (k < array2.Length)
							{
								WeaponSalvo.Shooter shooter2 = array2[k];
								if (Operators.CompareString(this.ParentPlatform.GetGuid(), shooter2.ShooterObjectID, false) != 0)
								{
									k++;
									if (k != array2.Length - 1)
									{
										continue;
									}
								}
								else
								{
									shooter = shooter2;
								}
								if (Information.IsNothing(shooter))
								{
									break;
								}
								int num2 = 0;
								short? num3;
								unchecked
								{
									if (shooter.Timeout >= 40 && !current2.ManualFire)
									{
										if (SimConfiguration.gameOptions.IsSalvoTimeout())
										{
											if (!dictionary.ContainsKey(shooter.ShooterObjectID))
											{
												dictionary.Add(shooter.ShooterObjectID, current2);
												break;
											}
											break;
										}
									}
									else if (current2.WeaponObjectIDArray.Count<string>() == 0)
									{
										if (!shooter.bool_0)
										{
											shooter.Timeout = 1;
										}
										else
										{
											shooter.Timeout++;
										}
									}
									else
									{
										shooter.Timeout = 0;
									}
									if (!current2.ManualFire && weaponControlStatusFor == Doctrine._WeaponControlStatus.Hold)
									{
										Side side = this.ParentPlatform.GetSide(false);
										ActiveUnit parentPlatform = this.ParentPlatform;
										Contact contact = null;
                                        current2X = current2;

                                        side.RemoveWeaponSalvoForTarget(ref parentPlatform.m_Scenario, ref this.ParentPlatform, ref contact, ref current2X);
										break;
									}
									if (!current2.ManualFire && shooter.QuantityAssigned == 0 && shooter.QuantityFired == 0)
									{
										list.Add(current2);
										break;
									}
									num2 = shooter.QuantityAssigned - shooter.QuantityFired;
									if (num2 <= 0)
									{
										this.ParentPlatform.GetSide(false).RemoveWeaponSalvo(current2);
										break;
									}
									if (current2.Target.IsSurface())
									{
										Contact._BattleDamageAssessment? battleDamageAssessment = current2.Target.GetBattleDamageAssessment(this.ParentPlatform.GetSide(false));
										byte? b = battleDamageAssessment.HasValue ? new byte?((byte)battleDamageAssessment.GetValueOrDefault()) : null;
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
										{
											Side side2 = this.ParentPlatform.GetSide(false);
											ActiveUnit parentPlatform2 = this.ParentPlatform;
											Contact contact = null;
                                            current2X = current2;

                                            side2.RemoveWeaponSalvoForTarget(ref parentPlatform2.m_Scenario, ref this.ParentPlatform, ref contact, ref current2X);
											break;
										}
									}
									if (!current2.FireSimultaneouslyFromMultipleMounts && (current2.Target.IsFacility || current2.Target.IsShip || current2.Target.IsSubmarine))
									{
										this.bool_0 = true;
									}
									if (shooter.TimeToNextLaunch > 0)
									{
										shooter.TimeToNextLaunch--;
										break;
									}
									num3 = null;
								}
								if (this.ParentPlatform.IsAircraft && !Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
								{
									WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
									for (int l = 0; l < weaponRecArray.Length; l++)
									{
										weaponRecArray[l].GetWeapon(this.ParentPlatform.m_Scenario).SetCurrentHeading(this.ParentPlatform.GetCurrentHeading());
									}
									WeaponRec[] weaponRecArray2 = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
									for (int m = 0; m < weaponRecArray2.Length; m++)
									{
										WeaponRec weaponRec = weaponRecArray2[m];
										unchecked
										{
											if (current2.WeaponDBID == weaponRec.WeapID)
											{
												if (weaponRec.GetCurrentLoad() == 0)
												{
													shooter.bool_0 = false;
												}
												else if (weaponRec.TimeToFire != 0f)
												{
													shooter.bool_0 = false;
												}
												else
												{
													shooter.bool_0 = true;
													if (shooter.Timeout > 1 || current2.ManualFire)
													{
													}
													ActiveUnit_Weaponry weaponry = this.ParentPlatform.GetWeaponry();
													Weapon weapon = weaponRec.GetWeapon(this.ParentPlatform.m_Scenario);
													Contact target = current2.Target;
													bool manualFire = current2.ManualFire;
													Mount theMount = null;
													Sensor sensor = null;
													if (Operators.CompareString(weaponry.CheckWeaponAttackCondition(weapon, target, ref num3, manualFire, false, theMount, ref sensor), "OK", false) == 0)
													{
														int num4 = 0;
                                                        current2X = current2;

                                                        this.ParentPlatform.GetWeaponry().FireWeapons(elapsedTime, ref weaponRec, current2.Target, false, ref num4, num2, 0f, ActiveUnit.Throttle.Flank, null, SonarEnvironment._SonobuoyDepthSetting.Shallow, 0L, ref current2X);
														shooter.QuantityFired += num4;
														if (num4 == 0)
														{
															flag = true;
														}
														if (num4 > 0 && !current2.FireSimultaneouslyFromMultipleMounts)
														{
															return;
														}
													}
												}
											}
										}
									}
								}
								try
								{
									if (!flag)
									{
										Mount[] mounts = this.ParentPlatform.m_Mounts;
										for (int n = 0; n < mounts.Length; n++)
										{
											Mount mount = mounts[n];
											unchecked
											{
												if (Operators.CompareString(shooter.PreferredMountObjectID, "", false) == 0 || Operators.CompareString(mount.GetGuid(), shooter.PreferredMountObjectID, false) == 0)
												{
                                                    WeaponRec current3X;
                                                    foreach (WeaponRec current3 in mount.GetWeaponRecCollection())
													{
														if (current2.WeaponDBID == current3.WeapID && current3.GetCurrentLoad() != 0)
														{
															if (mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
															{
																if (mount.GetTimeToFire() == 0f && mount.GetMagazineForMount().GetTimeToFire() == 0f)
																{
																	if (current3.TimeToFire != 0f)
																	{
																		continue;
																	}
																	shooter.bool_0 = true;
																	if (shooter.Timeout > 1 || current2.ManualFire)
																	{
																	}
																	ActiveUnit_Weaponry weaponry2 = this.ParentPlatform.GetWeaponry();
																	Weapon weapon2 = current3.GetWeapon(this.ParentPlatform.m_Scenario);
																	Contact target2 = current2.Target;
																	bool manualFire2 = current2.ManualFire;
																	Mount theMount2 = mount;
																	Sensor sensor = null;
																	if (Operators.CompareString(weaponry2.CheckWeaponAttackCondition(weapon2, target2, ref num3, manualFire2, false, theMount2, ref sensor), "OK", false) != 0)
																	{
																		continue;
																	}
																	int num5 = 0;
                                                                    current3X = current3;
                                                                    current2X = current2;
                                                                    this.ParentPlatform.GetWeaponry().FireWeapons(elapsedTime, ref current3X, current2.Target, false, ref num5, num2, 0f, ActiveUnit.Throttle.Flank, mount, SonarEnvironment._SonobuoyDepthSetting.Shallow, 0L, ref current2X);
																	if (!Information.IsNothing(current3.myMount))
																	{
																		current3.myMount.SetTimeToFire((float)current3.myMount.ROF);
																	}
																	shooter.QuantityFired += num5;
																	if (num5 == 0)
																	{
																		flag = true;
																	}
																	if (num5 > 0)
																	{
																		if (current3.GetCurrentLoad() != 0)
																		{
																			goto IL_851;
																		}
																		Mount mount2 = mount;
																		int num6 = 0;
																		int num7 = 0;
																		if (mount2.method_35(ref num6, ref num7) != 0)
																		{
																			goto IL_851;
																		}
																		mount.method_31(0f);
																		IL_886:
																		if (!current2.ManualFire && mount.ReserveTarget && current3.GetCurrentLoad() == 0 && current2.Target.IsAirSpace())
																		{
																			Side side = this.ParentPlatform.GetSide(false);
																			ActiveUnit parentPlatform3 = this.ParentPlatform;
																			Contact contact = null;
                                                                            current2X = current2;
                                                                            side.RemoveWeaponSalvoForTarget(ref parentPlatform3.m_Scenario, ref this.ParentPlatform, ref contact, ref current2X);
																			return;
																		}
																		if (current2.FireSimultaneouslyFromMultipleMounts)
																		{
																			goto IL_8C1;
																		}
																		if (current3.GetCurrentLoad() == 0)
																		{
																			shooter.PreferredMountObjectID = "";
																			shooter.TimeToNextLaunch = (int)Math.Round((double)current3.TimeToFire) - 1;
																		}
																		else
																		{
																			shooter.PreferredMountObjectID = mount.GetGuid();
																		}
																		return;
																		IL_851:
																		if (mount.method_30() < 300f)
																		{
																			mount.method_31(mount.GetTimeToFire() + 300f);
																			goto IL_886;
																		}
																		goto IL_886;
																	}
																	IL_8C1:
																	num2 = shooter.QuantityAssigned - shooter.QuantityFired;
																	if (num2 > 0)
																	{
																		continue;
																	}
																}
																else
																{
																	shooter.bool_0 = false;
																}
															}
															break;
														}
													}
													if (num2 <= 0)
													{
														break;
													}
												}
											}
										}
									}
									goto IL_A16;
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ex2.Data.Add("Error at 101210", "");
									GameGeneral.LogException(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
									goto IL_A16;
								}
								IL_9E2:
								if (flag && shooter.Timeout == 1 && current2.WeaponObjectIDArray.Count<string>() == 0)
								{
									list.Add(current2);
									break;
								}
								break;
								IL_A16:
								if (!current2.ManualFire)
								{
									goto IL_9E2;
								}
								break;
							}
						}
						foreach (KeyValuePair<string, WeaponSalvo> current4 in dictionary)
						{
							Side side3 = this.ParentPlatform.GetSide(false);
							ActiveUnit parentPlatform3 = this.ParentPlatform;
							string key = current4.Key;
							WeaponSalvo value = current4.Value;
							side3.RemoveWeaponSalvoByKeyValue(ref parentPlatform3.m_Scenario, key, ref value);
						}
						if (list.Count > 0)
						{
							foreach (WeaponSalvo current5 in list)
							{
								ScenarioArrayUtil.RemoveWeaponSalvo(ref this.ParentPlatform.GetSide(false).WeaponSalvos, current5);
							}
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ex4.Data.Add("Error at 200578", ex4.Message);
						GameGeneral.LogException(ref ex4);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x00166F68 File Offset: 0x00165168
		private bool IsTargetWithinWeaponBoresightLimits(Weapon weapon_, Contact target_)
		{
			bool result = false;
			try
			{
				Weapon._WeaponType weaponType = weapon_.GetWeaponType();
				float num;
				switch (weaponType)
				{
				case Weapon._WeaponType.GuidedWeapon:
					num = 40f;
					if (weapon_.weaponCode.AntiAir_Dogfight_HighOffBoresight)
					{
						num += 20f;
					}
					if (this.ParentPlatform.IsAircraft && ((Aircraft)this.ParentPlatform).HMD)
					{
						num += 30f;
						goto IL_FA;
					}
					goto IL_FA;
				case Weapon._WeaponType.Rocket:
					num = 30f;
					goto IL_FA;
				case Weapon._WeaponType.IronBomb:
					break;
				case Weapon._WeaponType.Gun:
					num = 8f;
					goto IL_FA;
				case Weapon._WeaponType.Decoy_Expendable:
				case Weapon._WeaponType.Decoy_Towed:
					goto IL_EC;
				case Weapon._WeaponType.Decoy_Vehicle:
					num = 135f;
					goto IL_FA;
				default:
					switch (weaponType)
					{
					case Weapon._WeaponType.Torpedo:
						num = 90f;
						goto IL_FA;
					case Weapon._WeaponType.DepthCharge:
						num = 20f;
						goto IL_FA;
					case Weapon._WeaponType.Sonobuoy:
						num = 4f;
						goto IL_FA;
					case Weapon._WeaponType.BottomMine:
					case Weapon._WeaponType.MooredMine:
					case Weapon._WeaponType.FloatingMine:
					case Weapon._WeaponType.MovingMine:
					case Weapon._WeaponType.RisingMine:
						break;
					default:
						goto IL_EC;
					}
					break;
				}
				num = 30f;
				goto IL_FA;
				IL_EC:
				num = 20f;
				IL_FA:
				result = (Math.Abs(target_.RelativeBearingTo(this.ParentPlatform, true)) < num);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100298", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x001670E4 File Offset: 0x001652E4
		public bool method_13(Contact target_, bool bool_7)
		{
			short? num = null;
			checked
			{
				bool result;
				if (this.ParentPlatform.IsAircraft && !Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
				{
					WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
					for (int i = 0; i < weaponRecArray.Length; i++)
					{
						weaponRecArray[i].GetWeapon(this.ParentPlatform.m_Scenario).SetCurrentHeading(this.ParentPlatform.GetCurrentHeading());
					}
					WeaponRec[] weaponRecArray2 = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
					for (int j = 0; j < weaponRecArray2.Length; j++)
					{
						WeaponRec weaponRec = weaponRecArray2[j];
						if (weaponRec.GetCurrentLoad() != 0 && weaponRec.TimeToFire <= 0f)
						{
							ActiveUnit_Weaponry weaponry = this.ParentPlatform.GetWeaponry();
							Weapon weapon = weaponRec.GetWeapon(this.ParentPlatform.m_Scenario);
							Mount theMount = null;
							Sensor sensor = null;
							if (Operators.CompareString(weaponry.CheckWeaponAttackCondition(weapon, target_, ref num, false, bool_7, theMount, ref sensor), "OK", false) == 0)
							{
								result = true;
								return result;
							}
						}
					}
				}
				Mount[] mounts = this.ParentPlatform.m_Mounts;
				for (int k = 0; k < mounts.Length; k++)
				{
					Mount mount = mounts[k];
					foreach (WeaponRec current in mount.GetWeaponRecCollection())
					{
						if (current.GetCurrentLoad() != 0 && current.TimeToFire <= 0f)
						{
							ActiveUnit_Weaponry weaponry2 = this.ParentPlatform.GetWeaponry();
							Weapon weapon2 = current.GetWeapon(this.ParentPlatform.m_Scenario);
							Mount theMount2 = mount;
							Sensor sensor = null;
							if (Operators.CompareString(weaponry2.CheckWeaponAttackCondition(weapon2, target_, ref num, false, bool_7, theMount2, ref sensor), "OK", false) == 0)
							{
								result = true;
								return result;
							}
						}
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x001672F4 File Offset: 0x001654F4
		public bool method_14(Contact target_, int int_0, int int_1, bool bool_7, DateTime dateTime_)
		{
			ActiveUnit_Weaponry.Class79 @class = new ActiveUnit_Weaponry.Class79(null);
			@class.activeUnit_Weaponry = this;
			@class.Target = target_;
			bool flag = false;
			if (!bool_7)
			{
				if (this.GetWeaponControlStatusFor(@class.Target.contactType) == Doctrine._WeaponControlStatus.Hold)
				{
					flag = false;
					bool result = false;
					return result;
				}
			}
			else
			{
				this.ParentPlatform.GetAI().MarkAsHostile(ref @class.Target, bool_7);
			}
			checked
			{
				bool result;
				try
				{
					switch (@class.Target.contactType)
					{
					case Contact_Base.ContactType.Surface:
					case Contact_Base.ContactType.Submarine:
					case Contact_Base.ContactType.Facility_Fixed:
					case Contact_Base.ContactType.Facility_Mobile:
						if (this.bool_0)
						{
							flag = false;
							result = false;
							return result;
						}
						break;
					case Contact_Base.ContactType.Decoy_Air:
						if (this.bool_0)
						{
							flag = false;
							result = false;
							return result;
						}
						break;
					case Contact_Base.ContactType.Decoy_Surface:
					case Contact_Base.ContactType.Decoy_Land:
					case Contact_Base.ContactType.Decoy_Sub:
						flag = false;
						result = false;
						return result;
					}
					if (@class.Target.GetBattleDamageAssessment(this.ParentPlatform.GetSide(false)).HasValue)
					{
						Contact._BattleDamageAssessment? battleDamageAssessment = @class.Target.GetBattleDamageAssessment(this.ParentPlatform.GetSide(false));
						byte? b = battleDamageAssessment.HasValue ? new byte?((byte)battleDamageAssessment.GetValueOrDefault()) : null;
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
						{
							flag = false;
							result = false;
							return result;
						}
					}
					WeaponSalvo[] array = this.ParentPlatform.GetSide(false).GetWeaponSalvoListForTarget(@class.Target).ToArray();
					bool flag2 = false;
					bool flag3 = false;
					WeaponSalvo weaponSalvo = null;
					if (!bool_7)
					{
						WeaponSalvo[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							WeaponSalvo weaponSalvo2 = array2[i];
							if (weaponSalvo2.Target == @class.Target)
							{
								List<WeaponSalvo.Shooter> list = weaponSalvo2.m_Shooters.ToList<WeaponSalvo.Shooter>();
								using (List<WeaponSalvo.Shooter>.Enumerator enumerator = list.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										if (Operators.CompareString(enumerator.Current.ShooterObjectID, this.ParentPlatform.GetGuid(), false) == 0)
										{
											if (this.ParentPlatform.IsAircraft)
											{
												flag = false;
												result = false;
												return result;
											}
											flag3 = true;
										}
									}
								}
								if (!weaponSalvo2.FireSimultaneouslyFromMultipleMounts)
								{
									flag2 = true;
								}
							}
						}
					}
					else
					{
						WeaponSalvo[] array3 = array;
						for (int j = 0; j < array3.Length; j++)
						{
							WeaponSalvo weaponSalvo3 = array3[j];
							if (weaponSalvo3.Target == @class.Target && int_0 == weaponSalvo3.WeaponDBID)
							{
								List<WeaponSalvo.Shooter> list2 = weaponSalvo3.m_Shooters.ToList<WeaponSalvo.Shooter>();
								using (List<WeaponSalvo.Shooter>.Enumerator enumerator2 = list2.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										if (Operators.CompareString(enumerator2.Current.ShooterObjectID, this.ParentPlatform.GetGuid(), false) == 0)
										{
											weaponSalvo3 = weaponSalvo3;
											break;
										}
									}
								}
							}
							if (!Information.IsNothing(weaponSalvo3))
							{
								break;
							}
						}
					}
					Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = this.ParentPlatform.m_Doctrine.GetWRA_WeaponTargetType(ref @class.Target);
					Dictionary<int, ActiveUnit_Weaponry.MountedWeapon> dictionary = new Dictionary<int, ActiveUnit_Weaponry.MountedWeapon>();
					float? num = null;
					float? num2 = null;
					float? num3 = null;
					bool flag4 = true;
					bool flag5 = false;
					Collection<WeaponRec> collection = new Collection<WeaponRec>();
					Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = null;
					try
					{
						int? num4 = null;
						int? num5 = null;
						short? num6 = null;
						if (this.ParentPlatform.IsAircraft && !Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
						{
							WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
							for (int k = 0; k < weaponRecArray.Length; k++)
							{
								WeaponRec weaponRec = weaponRecArray[k];
								weaponRec.GetWeapon(this.ParentPlatform.m_Scenario).SetCurrentHeading(this.ParentPlatform.GetCurrentHeading());
							}
							WeaponRec[] weaponRecArray2 = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
							int l = 0;
							while (l < weaponRecArray2.Length)
							{
								WeaponRec weaponRec = weaponRecArray2[l];
								if (!Information.IsNothing(weaponSalvo))
								{
									if (weaponRec.WeapID == weaponSalvo.WeaponDBID)
									{
										goto IL_44A;
									}
								}
								else if (!bool_7 || weaponRec.WeapID == int_0)
								{
									goto IL_44A;
								}
								IL_D8E:
								l++;
								continue;
								IL_44A:
								weaponRec.myMount = null;
								if (!bool_7)
								{
									if (weaponRec.GetCurrentLoad() == 0 || weaponRec.TimeToFire > 0f)
									{
										goto IL_D8E;
									}
									if (dictionary.ContainsKey(weaponRec.WeapID))
									{
										int? currentLoad = dictionary[weaponRec.WeapID].CurrentLoad;
										if (Information.IsNothing(currentLoad))
										{
											currentLoad = new int?(weaponRec.GetCurrentLoad());
											goto IL_D8E;
										}
										int? num7 = currentLoad;
										int m = weaponRec.GetCurrentLoad();
										if (!num7.HasValue)
										{
											int? num8 = null;
											goto IL_D8E;
										}
										new int?(unchecked(num7.GetValueOrDefault() + m));
										goto IL_D8E;
									}
									else
									{
										num4 = new int?(weaponRec.GetCurrentLoad());
										if (dictionary.ContainsKey(weaponRec.WeapID))
										{
											int? num9 = dictionary[weaponRec.WeapID].CurrentLoad;
											if (!Information.IsNothing(num9))
											{
												int? num10;
												if (!(num9.HasValue & num4.HasValue))
												{
													int? num7 = null;
													num10 = num7;
												}
												else
												{
													num10 = new int?(unchecked(num9.GetValueOrDefault() + num4.GetValueOrDefault()));
												}
												num9 = num10;
											}
											else
											{
												num9 = num4;
											}
											dictionary[weaponRec.WeapID].CurrentLoad = num9;
											goto IL_D8E;
										}
										if (!Information.IsNothing(weaponSalvo))
										{
											goto IL_D8E;
										}
										Weapon weapon = weaponRec.GetWeapon(this.ParentPlatform.m_Scenario);
										if (weapon.GetWeaponType() == Weapon._WeaponType.Gun && @class.Target.IsSurfaceOrLandTarget())
										{
											if (Information.IsNothing(gunStrafeGroundTargets))
											{
												gunStrafeGroundTargets = this.ParentPlatform.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
											}
											byte? b = gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null;
											if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
											{
												goto IL_D8E;
											}
										}
										if (!weapon.IsSuitableForTarget(this.ParentPlatform.m_Scenario, ref @class.Target))
										{
											goto IL_D8E;
										}
										float weaponRange = this.GetWeaponRange(ref this.ParentPlatform, ref weapon, ref @class.Target, false);
										if (weapon.GetWeaponType() == Weapon._WeaponType.Gun && Information.IsNothing(num2))
										{
											num2 = new float?(this.ParentPlatform.GetSlantRange(@class.Target, 0f));
										}
										else if (Information.IsNothing(num))
										{
											num = new float?(this.ParentPlatform.GetHorizontalRange(@class.Target));
										}
										float? num11;
										if (weapon.GetWeaponType() == Weapon._WeaponType.Gun)
										{
											num11 = num2;
											if ((num11.HasValue ? new bool?(num11.GetValueOrDefault() > weaponRange) : null).GetValueOrDefault())
											{
												goto IL_D8E;
											}
										}
										num11 = num;
										if ((num11.HasValue ? new bool?(num11.GetValueOrDefault() > weaponRange) : null).GetValueOrDefault())
										{
											goto IL_D8E;
										}
										if (weapon.GetWeaponType() == Weapon._WeaponType.Gun)
										{
											num3 = num2;
										}
										else
										{
											num3 = num;
										}
										if (this.ParentPlatform.m_Doctrine.IsLethalWeapon(ref weapon))
										{
											Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType2 = weapon.m_Doctrine.GetWRA_WeaponTargetType(ref weapon, ref weapon.m_Doctrine, ref @class.Target, ref wRA_WeaponTargetType);
											Doctrine doctrine = this.ParentPlatform.m_Doctrine;
											Scenario scenario = this.ParentPlatform.m_Scenario;
											Weapon theWeapon = weapon;
											Doctrine._WRA_WeaponTargetType selectedNodeTargetType = wRA_WeaponTargetType2;
											int? num7 = null;
											int? num8 = null;
											num5 = doctrine.GetWeaponQty(scenario, theWeapon, selectedNodeTargetType, false, ref num7, ref num8);
											num8 = num5;
											if ((num8.HasValue ? new bool?(num8.GetValueOrDefault() == 0) : null).GetValueOrDefault())
											{
												goto IL_D8E;
											}
											num8 = num5;
											if ((num8.HasValue ? new bool?(num8.GetValueOrDefault() == -99) : null).GetValueOrDefault())
											{
												num5 = new int?(2147483647);
											}
											Doctrine doctrine2 = this.ParentPlatform.m_Doctrine;
											Scenario scenario2 = this.ParentPlatform.m_Scenario;
											int dBID = weapon.DBID;
											Doctrine._WRA_WeaponTargetType selectedNodeTargetType2 = wRA_WeaponTargetType2;
											num8 = null;
											num7 = null;
											int? firingRange = doctrine2.GetFiringRange(scenario2, dBID, selectedNodeTargetType2, false, ref num8, ref num7);
											if (Information.IsNothing(firingRange))
											{
												firingRange = new int?(-99);
											}
											num7 = firingRange;
											if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == 0) : null).GetValueOrDefault())
											{
												goto IL_D8E;
											}
											num7 = firingRange;
											bool? flag6 = num7.HasValue ? new bool?(num7.GetValueOrDefault() == -99) : null;
											bool? flag7;
											flag6 = (flag7 = (flag6.HasValue ? new bool?(!flag6.GetValueOrDefault()) : flag6));
											bool? flag8;
											if (flag6.HasValue && !flag7.GetValueOrDefault())
											{
												flag8 = new bool?(false);
											}
											else
											{
												num11 = (firingRange.HasValue ? new float?((float)firingRange.GetValueOrDefault()) : null);
												flag6 = ((num11.HasValue & num3.HasValue) ? new bool?(num11.GetValueOrDefault() < num3.GetValueOrDefault()) : null);
												flag8 = (flag7 & flag6.GetValueOrDefault());
											}
											flag7 = flag8;
											if (flag7.GetValueOrDefault())
											{
												goto IL_D8E;
											}
											if (array.Length > 0)
											{
												if (@class.Target.IsAirSpace())
												{
													bool flag9 = false;
													WeaponSalvo[] array4 = array;
													for (int m = 0; m < array4.Length; m++)
													{
														if (array4[m].WeaponDBID == weapon.DBID)
														{
															goto IL_D8E;
														}
													}
													if (flag9)
													{
														goto IL_D8E;
													}
												}
												Doctrine doctrine3 = this.ParentPlatform.m_Doctrine;
												Scenario scenario3 = this.ParentPlatform.m_Scenario;
												Weapon theWeapon2 = weapon;
												Doctrine._WRA_WeaponTargetType selectedNodeTargetType3 = wRA_WeaponTargetType2;
												num7 = null;
												num8 = null;
												int? num12 = doctrine3.method_19(scenario3, theWeapon2, selectedNodeTargetType3, false, ref num7, ref num8);
												num8 = num12;
												if ((num8.HasValue ? new bool?(num8.GetValueOrDefault() == -99) : null).GetValueOrDefault())
												{
													num12 = new int?(unchecked((int)Math.Round((double)weaponRange)));
												}
												num8 = num12;
												if ((num8.HasValue ? new bool?(num8.GetValueOrDefault() > 0) : null).GetValueOrDefault())
												{
													num11 = (num12.HasValue ? new float?((float)num12.GetValueOrDefault()) : null);
													if (((num11.HasValue & num3.HasValue) ? new bool?(num11.GetValueOrDefault() < num3.GetValueOrDefault()) : null).GetValueOrDefault())
													{
														bool flag10 = false;
														WeaponSalvo[] array5 = array;
														for (int n = 0; n < array5.Length; n++)
														{
															WeaponSalvo weaponSalvo4 = array5[n];
															if (weaponSalvo4.WeaponDBID == weapon.DBID && weaponSalvo4.m_Shooters.Length < weaponSalvo4.NumberOfShooters && (weaponSalvo4.Quantity_Total == 2147483647 || weaponSalvo4.Quantity_Total > weaponSalvo4.GetTotalQuantityAssigned()))
															{
																goto IL_C38;
															}
														}
														if (!flag10)
														{
															goto IL_D8E;
														}
													}
												}
											}
										}
										IL_C38:
										if (array.Length > 0)
										{
											bool flag11 = false;
											WeaponSalvo[] array6 = array;
											for (int num13 = 0; num13 < array6.Length; num13++)
											{
												WeaponSalvo weaponSalvo5 = array6[num13];
												if (weaponSalvo5.WeaponDBID == weapon.DBID)
												{
													if (weaponSalvo5.GetTotalQuantityAssigned() >= weaponSalvo5.Quantity_Total && weaponSalvo5.Quantity_Total != 2147483647)
													{
														flag11 = true;
													}
													if (!flag11)
													{
														WeaponSalvo.Shooter[] shooters = weaponSalvo5.m_Shooters;
														for (int num14 = 0; num14 < shooters.Length; num14++)
														{
															if (Operators.CompareString(shooters[num14].ShooterObjectID, this.ParentPlatform.GetGuid(), false) == 0)
															{
																flag11 = true;
																break;
															}
														}
													}
													if (!flag11 && weaponSalvo5.m_Shooters.Length < weaponSalvo5.NumberOfShooters)
													{
														weaponSalvo = weaponSalvo5;
														if (!flag11)
														{
															goto IL_D24;
														}
														goto IL_D8E;
													}
												}
											}
											if (flag11)
											{
												goto IL_D8E;
											}
										}
										IL_D24:
										ActiveUnit_Weaponry weaponry = this.ParentPlatform.GetWeaponry();
										Weapon theWeapon3 = weapon;
										Contact target = @class.Target;
										Mount theMount = null;
										Sensor sensor = null;
										if (string.CompareOrdinal(weaponry.CheckWeaponAttackCondition(theWeapon3, target, ref num6, bool_7, false, theMount, ref sensor), "OK") != 0)
										{
											goto IL_D8E;
										}
									}
								}
								collection.Add(weaponRec);
								if (!bool_7)
								{
									ActiveUnit_Weaponry.MountedWeapon value = new ActiveUnit_Weaponry.MountedWeapon(num5, num4);
									dictionary.Add(weaponRec.WeapID, value);
									goto IL_D8E;
								}
								break;
							}
						}
						if (collection.Count == 0)
						{
							Mount[] mounts = this.ParentPlatform.m_Mounts;
							for (int num15 = 0; num15 < mounts.Length; num15++)
							{
								Mount mount = mounts[num15];
								if (bool_7 || (mount.GetTimeToFire() == 0f && mount.GetMagazineForMount().GetTimeToFire() == 0f))
								{
									using (IEnumerator<WeaponRec> enumerator3 = mount.GetWeaponRecCollection().GetEnumerator())
									{
										IL_190B:
										while (enumerator3.MoveNext())
										{
											WeaponRec weaponRec = enumerator3.Current;
											if (!Information.IsNothing(weaponSalvo))
											{
												if (weaponRec.WeapID != weaponSalvo.WeaponDBID)
												{
													continue;
												}
											}
											else if (bool_7 && weaponRec.WeapID != int_0)
											{
												continue;
											}
											weaponRec.myMount = mount;
											if (!bool_7)
											{
												if (mount.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational || weaponRec.TimeToFire != 0f || weaponRec.GetCurrentLoad() == 0)
												{
													continue;
												}
												num4 = new int?(weaponRec.GetCurrentLoad());
												Weapon weapon2 = null;
												float? num11;
												float weaponRange2;
												unchecked
												{
													int? num8;
													if (mount.GetMagazineForMount().GetWeaponRecCollection().Count > 0)
													{
														bool flag12 = false;
														if (mount.GetMagazineForMount().GetWeaponRecCollection().Count > 1)
														{
															using (IEnumerator<WeaponRec> enumerator4 = mount.GetWeaponRecCollection().GetEnumerator())
															{
																while (enumerator4.MoveNext())
																{
																	if (enumerator4.Current.HasReloadPriorityOnMount(mount))
																	{
																		flag12 = true;
																		break;
																	}
																}
															}
														}
														if (!flag12)
														{
															num8 = num4;
															int num16 = this.method_34(mount, weaponRec.WeapID);
															int? num17;
															if (!num8.HasValue)
															{
																int? num7 = null;
																num17 = num7;
															}
															else
															{
																num17 = new int?(num8.GetValueOrDefault() + num16);
															}
															num4 = num17;
														}
													}
													num8 = num4;
													if ((num8.HasValue ? new bool?(num8.GetValueOrDefault() == 0) : null).GetValueOrDefault())
													{
														continue;
													}
													if (dictionary.ContainsKey(weaponRec.WeapID))
													{
														int? num18 = dictionary[weaponRec.WeapID].CurrentLoad;
														if (!Information.IsNothing(num18))
														{
															int? num19;
															if (!(num18.HasValue & num4.HasValue))
															{
																num8 = null;
																num19 = num8;
															}
															else
															{
																num19 = new int?(num18.GetValueOrDefault() + num4.GetValueOrDefault());
															}
															num18 = num19;
														}
														else
														{
															num18 = num4;
														}
														dictionary[weaponRec.WeapID].CurrentLoad = num18;
														continue;
													}
													if (!Information.IsNothing(weaponSalvo))
													{
														continue;
													}
													weapon2 = weaponRec.GetWeapon(this.ParentPlatform.m_Scenario);
													if (this.ParentPlatform.IsAircraft && weapon2.GetWeaponType() == Weapon._WeaponType.Gun && @class.Target.IsSurfaceOrLandTarget())
													{
														if (Information.IsNothing(gunStrafeGroundTargets))
														{
															gunStrafeGroundTargets = this.ParentPlatform.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
														}
														byte? b = gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null;
														if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
														{
															continue;
														}
													}
													if (!weapon2.IsSuitableForTarget(this.ParentPlatform.m_Scenario, ref @class.Target))
													{
														continue;
													}
													weaponRange2 = this.GetWeaponRange(ref this.ParentPlatform, ref weapon2, ref @class.Target, false);
													if (weapon2.GetWeaponType() == Weapon._WeaponType.Gun && Information.IsNothing(num2))
													{
														num2 = new float?(this.ParentPlatform.GetSlantRange(@class.Target, 0f));
													}
													else if (Information.IsNothing(num))
													{
														num = new float?(this.ParentPlatform.GetHorizontalRange(@class.Target));
													}
													if (weapon2.GetWeaponType() == Weapon._WeaponType.Gun)
													{
														num11 = num2;
														if ((num11.HasValue ? new bool?(num11.GetValueOrDefault() > weaponRange2) : null).GetValueOrDefault())
														{
															continue;
														}
													}
													num11 = num;
													if ((num11.HasValue ? new bool?(num11.GetValueOrDefault() > weaponRange2) : null).GetValueOrDefault())
													{
														continue;
													}
													if (weapon2.GetWeaponType() == Weapon._WeaponType.Gun)
													{
														num3 = num2;
													}
													else
													{
														num3 = num;
													}
												}
												if (this.ParentPlatform.m_Doctrine.IsLethalWeapon(ref weapon2))
												{
													Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType2 = weapon2.m_Doctrine.GetWRA_WeaponTargetType(ref weapon2, ref weapon2.m_Doctrine, ref @class.Target, ref wRA_WeaponTargetType);
													Doctrine doctrine4 = this.ParentPlatform.m_Doctrine;
													Scenario scenario4 = this.ParentPlatform.m_Scenario;
													Weapon theWeapon4 = weapon2;
													Doctrine._WRA_WeaponTargetType selectedNodeTargetType4 = wRA_WeaponTargetType2;
													int? num8 = null;
													int? num7 = null;
													num5 = doctrine4.GetWeaponQty(scenario4, theWeapon4, selectedNodeTargetType4, false, ref num8, ref num7);
													num7 = num5;
													if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == 0) : null).GetValueOrDefault())
													{
														continue;
													}
													num7 = num5;
													if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == -99) : null).GetValueOrDefault())
													{
														num5 = new int?(2147483647);
													}
													Doctrine doctrine5 = this.ParentPlatform.m_Doctrine;
													Scenario scenario5 = this.ParentPlatform.m_Scenario;
													int dBID2 = weapon2.DBID;
													Doctrine._WRA_WeaponTargetType selectedNodeTargetType5 = wRA_WeaponTargetType2;
													num7 = null;
													num8 = null;
													int? firingRange = doctrine5.GetFiringRange(scenario5, dBID2, selectedNodeTargetType5, false, ref num7, ref num8);
													if (Information.IsNothing(firingRange))
													{
														firingRange = new int?(-99);
													}
													num8 = firingRange;
													if ((num8.HasValue ? new bool?(num8.GetValueOrDefault() == 0) : null).GetValueOrDefault())
													{
														continue;
													}
													num8 = firingRange;
													bool? flag6 = num8.HasValue ? new bool?(num8.GetValueOrDefault() == -99) : null;
													bool? flag7;
													flag6 = (flag7 = (flag6.HasValue ? new bool?(!flag6.GetValueOrDefault()) : flag6));
													bool? flag13;
													if (flag6.HasValue && !flag7.GetValueOrDefault())
													{
														flag13 = new bool?(false);
													}
													else
													{
														num11 = (firingRange.HasValue ? new float?((float)firingRange.GetValueOrDefault()) : null);
														flag6 = ((num11.HasValue & num3.HasValue) ? new bool?(num11.GetValueOrDefault() < num3.GetValueOrDefault()) : null);
														flag13 = (flag7 & flag6.GetValueOrDefault());
													}
													flag7 = flag13;
													if (flag7.GetValueOrDefault())
													{
														continue;
													}
													if (array.Length > 0)
													{
														if (@class.Target.IsAirSpace())
														{
															bool flag14 = false;
															WeaponSalvo[] array7 = array;
															for (int num16 = 0; num16 < array7.Length; num16++)
															{
																if (array7[num16].WeaponDBID == weapon2.DBID)
																{
																	goto IL_190B;
																}
															}
															if (flag14)
															{
																continue;
															}
														}
														Doctrine doctrine6 = this.ParentPlatform.m_Doctrine;
														Scenario scenario6 = this.ParentPlatform.m_Scenario;
														Weapon theWeapon5 = weapon2;
														Doctrine._WRA_WeaponTargetType selectedNodeTargetType6 = wRA_WeaponTargetType2;
														num8 = null;
														num7 = null;
														int? num12 = doctrine6.method_19(scenario6, theWeapon5, selectedNodeTargetType6, false, ref num8, ref num7);
														num7 = num12;
														if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() == -99) : null).GetValueOrDefault())
														{
															num12 = new int?(unchecked((int)Math.Round((double)weaponRange2)));
														}
														num7 = num12;
														if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() > 0) : null).GetValueOrDefault())
														{
															num11 = (num12.HasValue ? new float?((float)num12.GetValueOrDefault()) : null);
															if (((num11.HasValue & num3.HasValue) ? new bool?(num11.GetValueOrDefault() < num3.GetValueOrDefault()) : null).GetValueOrDefault())
															{
																if (!flag2 && (weapon2.IsGuidedWeapon() || weapon2.IsTorpedo()))
																{
																	goto IL_1719;
																}
																bool flag15 = false;
																WeaponSalvo[] array8 = array;
																for (int num20 = 0; num20 < array8.Length; num20++)
																{
																	WeaponSalvo weaponSalvo6 = array8[num20];
																	if (weaponSalvo6.WeaponDBID == weapon2.DBID && weaponSalvo6.m_Shooters.Length < weaponSalvo6.NumberOfShooters && (weaponSalvo6.Quantity_Total == 2147483647 || weaponSalvo6.Quantity_Total > weaponSalvo6.GetTotalQuantityAssigned()))
																	{
																		goto IL_1719;
																	}
																}
																if (!flag15)
																{
																	continue;
																}
																goto IL_1719;
															}
														}
														if (flag3 && (weapon2.IsGuidedWeapon() || weapon2.IsTorpedo()))
														{
															continue;
														}
													}
												}
												IL_1719:
												if (array.Length > 0)
												{
													bool flag16 = false;
													WeaponSalvo[] array9 = array;
													for (int num21 = 0; num21 < array9.Length; num21++)
													{
														WeaponSalvo weaponSalvo7 = array9[num21];
														if (weaponSalvo7.WeaponDBID == weapon2.DBID)
														{
															if (weaponSalvo7.GetTotalQuantityAssigned() >= weaponSalvo7.Quantity_Total && weaponSalvo7.Quantity_Total != 2147483647)
															{
																flag16 = true;
															}
															if (!flag16)
															{
																WeaponSalvo.Shooter[] shooters2 = weaponSalvo7.m_Shooters;
																for (int num22 = 0; num22 < shooters2.Length; num22++)
																{
																	if (Operators.CompareString(shooters2[num22].ShooterObjectID, this.ParentPlatform.GetGuid(), false) == 0)
																	{
																		flag16 = true;
																		break;
																	}
																}
															}
															if (!flag16 && weaponSalvo7.m_Shooters.Length < weaponSalvo7.NumberOfShooters)
															{
																weaponSalvo = weaponSalvo7;
																if (!flag16)
																{
																	goto IL_180B;
																}
																goto IL_190B;
															}
														}
													}
													if (flag16)
													{
														continue;
													}
												}
												IL_180B:
												ActiveUnit_Weaponry weaponry2 = this.ParentPlatform.GetWeaponry();
												Weapon theWeapon6 = weapon2;
												Contact target2 = @class.Target;
												Mount theMount2 = mount;
												Sensor sensor = null;
												if (string.CompareOrdinal(weaponry2.CheckWeaponAttackCondition(theWeapon6, target2, ref num6, bool_7, false, theMount2, ref sensor), "OK") != 0)
												{
													continue;
												}
												if (!flag5 && weapon2.GetWeaponType() == Weapon._WeaponType.GuidedWeapon && (weapon2.weaponCode.TerminalIllumination || weapon2.weaponCode.IlluminateAtLaunch || weapon2.GetCommDevices().Count<CommDevice>() > 0))
												{
													flag5 = true;
													flag4 = true;
												}
												num11 = num3;
												if ((num11.HasValue ? new bool?(num11.GetValueOrDefault() < 5f) : null).GetValueOrDefault() && !flag5)
												{
													flag4 = false;
												}
											}
											collection.Add(weaponRec);
											if (bool_7)
											{
												break;
											}
											ActiveUnit_Weaponry.MountedWeapon value2 = new ActiveUnit_Weaponry.MountedWeapon(num5, num4);
											dictionary.Add(weaponRec.WeapID, value2);
										}
									}
									if (bool_7 && collection.Count > 0)
									{
										break;
									}
								}
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 101238", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
					try
					{
						if (!bool_7 && this.ParentPlatform.IsAircraft && !Information.IsNothing(gunStrafeGroundTargets))
						{
							byte? b = gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null;
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && collection.Count > 1 && @class.Target.IsSurfaceOrLandTarget() && this.GetWeaponsForTargetsConsideringGunStrafeDoctrine(@class.Target, ref gunStrafeGroundTargets).Select(ActiveUnit_Weaponry.WeaponFunc2).Where(ActiveUnit_Weaponry.WeaponFunc3).Count<Weapon>() > 0)
							{
								List<WeaponRec> list3 = new List<WeaponRec>();
								list3.AddRange(collection);
								foreach (WeaponRec current in list3)
								{
									if (current.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.Gun)
									{
										collection.Remove(current);
									}
								}
							}
						}
						WeaponRec weaponRec2 = null;
						Weapon weapon3 = null;
						int? num23 = null;
						if (collection.Count > 0)
						{
							if (!bool_7)
							{
								if (collection.Count > 1)
								{
									collection.Select(ActiveUnit_Weaponry.WeaponRecFunc4).OrderByDescending(new Func<WeaponRec, int>(@class.method_0)).ThenBy(new Func<WeaponRec, float>(@class.method_1));
									weaponRec2 = collection[0];
								}
								else
								{
									weaponRec2 = collection[0];
								}
								weapon3 = weaponRec2.GetWeapon(this.ParentPlatform.m_Scenario);
								int? num8;
								if (Information.IsNothing(num23))
								{
									Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType2 = weapon3.m_Doctrine.GetWRA_WeaponTargetType(ref weapon3, ref weapon3.m_Doctrine, ref @class.Target, ref wRA_WeaponTargetType);
									Doctrine doctrine7 = this.ParentPlatform.m_Doctrine;
									Scenario scenario7 = this.ParentPlatform.m_Scenario;
									Weapon theWeapon7 = weapon3;
									Doctrine._WRA_WeaponTargetType selectedNodeTargetType7 = wRA_WeaponTargetType2;
									int? num7 = null;
									num8 = null;
									num23 = doctrine7.GetShooterQty(scenario7, theWeapon7, selectedNodeTargetType7, false, ref num7, ref num8);
								}
								num8 = num23;
								if ((num8.HasValue ? new bool?(num8.GetValueOrDefault() == -99) : null).GetValueOrDefault())
								{
									num23 = new int?(2147483647);
								}
							}
							else
							{
								weaponRec2 = collection[0];
								weapon3 = weaponRec2.GetWeapon(this.ParentPlatform.m_Scenario);
							}
						}
						if (!Information.IsNothing(weaponRec2))
						{
							int? num24;
							int? num25;
							if (!bool_7)
							{
								num24 = dictionary[weaponRec2.WeapID].WeaponQty;
								num25 = dictionary[weaponRec2.WeapID].CurrentLoad;
								int? num8 = num24;
								bool? flag7;
								bool? flag17;
								if (!(num8.HasValue ? new bool?(num8.GetValueOrDefault() < 0) : null).GetValueOrDefault())
								{
									flag17 = new bool?(false);
								}
								else
								{
									num8 = num24;
									flag7 = (num8.HasValue ? new bool?(num8.GetValueOrDefault() == -99) : null);
									flag17 = (flag7.HasValue ? new bool?(!flag7.GetValueOrDefault()) : flag7);
								}
								flag7 = flag17;
								if (flag7.GetValueOrDefault())
								{
									num24 = this.ParentPlatform.GetSide(false).GetWeaponQuantity(num24, ref this.ParentPlatform, ref @class.Target, ref weapon3);
								}
								num8 = num24;
								if ((num8.HasValue ? new bool?(num8.GetValueOrDefault() < 1) : null).GetValueOrDefault())
								{
									num24 = new int?(1);
								}
								bool? flag18;
								if (!((num25.HasValue & num24.HasValue) ? new bool?(num25.GetValueOrDefault() > num24.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									flag18 = new bool?(false);
								}
								else
								{
									num8 = num24;
									flag7 = (num8.HasValue ? new bool?(num8.GetValueOrDefault() == -99) : null);
									flag18 = (flag7.HasValue ? new bool?(!flag7.GetValueOrDefault()) : flag7);
								}
								flag7 = flag18;
								if (flag7.GetValueOrDefault())
								{
									num25 = num24;
								}
							}
							else
							{
								num24 = new int?(int_1);
								num25 = new int?(int_1);
							}
							if (Information.IsNothing(weaponSalvo))
							{
								Side side = this.ParentPlatform.GetSide(false);
								Scenario scenario = this.ParentPlatform.m_Scenario;
								Weapon weapon4 = weaponRec2.GetWeapon(this.ParentPlatform.m_Scenario);
								ActiveUnit_Weaponry.Class79 class2 = @class;
								int? nullable_ = num24;
								int? nullable_2 = num25;
								string guid = this.ParentPlatform.GetGuid();
								side.WeaponSalvoAssigned(scenario, ref weapon4, ref class2.Target, nullable_, 0, nullable_2, bool_7, ref guid, ref num23, DateTime.MinValue);
							}
							else
							{
								Side side = this.ParentPlatform.GetSide(false);
								int? nullable_3 = num24;
								int? nullable_4 = num25;
								string guid2 = this.ParentPlatform.GetGuid();
								side.SetWeaponSalvoParameter(ref weaponSalvo, nullable_3, 0, nullable_4, bool_7, ref guid2);
							}
							flag = (result = flag4);
							return result;
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ex4.Data.Add("Error at 101239", "");
						GameGeneral.LogException(ref ex4);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
					flag = false;
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ex6.Data.Add("Error at 100299", "");
					GameGeneral.LogException(ref ex6);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x00169320 File Offset: 0x00167520
		public int GetMissileDefenseValueForTarget(ref Contact target_)
		{
			int result;
			if (!Information.IsNothing(target_.ActualUnit))
			{
				if (target_.ActualUnit.IsShip)
				{
					int missileDefense = (int)((Ship)target_.ActualUnit).MissileDefense;
					result = missileDefense;
					return result;
				}
				if (target_.ActualUnit.IsFacility)
				{
					int missileDefense = ((Facility)target_.ActualUnit).MissileDefense;
					result = missileDefense;
					return result;
				}
			}
			result = 0;
			return result;
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x00169390 File Offset: 0x00167590
		private List<Weapon> GetWeaponsForTargetsConsideringGunStrafeDoctrine(Contact target_, ref Doctrine._GunStrafeGroundTargets? GunStrafeGroundTargetsDoc_)
		{
			List<Weapon> result = null;
			checked
			{
				try
				{
					Weapon[] availableWeapons = this.GetAvailableWeapons(false);
					List<Weapon> list = new List<Weapon>();
					Weapon[] array = availableWeapons;
					for (int i = 0; i < array.Length; i++)
					{
						Weapon weapon = array[i];
						if (weapon.IsSuitableForTarget(this.ParentPlatform.m_Scenario, ref target_))
						{
							if (this.ParentPlatform.IsAircraft && weapon.GetWeaponType() == Weapon._WeaponType.Gun && target_.IsSurfaceOrLandTarget())
							{
								if (Information.IsNothing(GunStrafeGroundTargetsDoc_))
								{
									GunStrafeGroundTargetsDoc_ = this.ParentPlatform.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
								}
								Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = GunStrafeGroundTargetsDoc_;
								byte? b = gunStrafeGroundTargets.HasValue ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null;
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									list.Add(weapon);
								}
							}
							else
							{
								list.Add(weapon);
							}
						}
					}
					result = list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100300", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x00169524 File Offset: 0x00167724
		public int method_17(ref Weapon weapon, ref Contact Target, bool bool_7)
		{
			int num = 0;
			int result;
			try
			{
				if (!weapon.IsSuitableForTarget(this.ParentPlatform.m_Scenario, ref Target))
				{
					num = 0;
				}
				else
				{
					bool? flag;
					bool? flag2;
					if (!weapon.HasNuclearWarhead())
					{
						flag = new bool?(false);
					}
					else
					{
						Doctrine._UseNuclear? useNuclearDoctrine = this.ParentPlatform.m_Doctrine.GetUseNuclearDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
						byte? b = useNuclearDoctrine.HasValue ? new byte?((byte)useNuclearDoctrine.GetValueOrDefault()) : null;
						flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null);
						flag = (flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2);
					}
					flag2 = flag;
					if (flag2.GetValueOrDefault())
					{
						num = 0;
					}
					else
					{
						if (bool_7)
						{
							float distance;
							if (weapon.GetWeaponType() == Weapon._WeaponType.Gun)
							{
								distance = this.ParentPlatform.GetSlantRange(Target, 0f);
							}
							else
							{
								distance = this.ParentPlatform.GetHorizontalRange(Target);
							}
							if (!weapon.CanReachTarget(distance, Target))
							{
								num = 0;
								result = 0;
								return result;
							}
							if (weapon.TargetWithinRangeOfSuitableWeapon(distance, Target))
							{
								num = 0;
								result = 0;
								return result;
							}
						}
						int num2 = 1;
						if (this.ParentPlatform.IsAircraft && weapon.GetWeaponType() == Weapon._WeaponType.Gun)
						{
							num2 -= 2;
						}
						if (weapon.m_Warheads.Length > 0)
						{
							Warhead warhead = weapon.m_Warheads[0];
							switch (Target.contactType)
							{
							case Contact_Base.ContactType.Air:
							{
								if (weapon.GetWeaponType() == Weapon._WeaponType.Gun && weapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() && !weapon.TargetIsLandFacility() && !weapon.TargetIsShipOrRadar())
								{
									num2++;
								}
								Warhead.WarheadType warheadType = warhead.warheadType;
								if (warheadType <= Warhead.WarheadType.ContinuousRod)
								{
									if (warheadType != Warhead.WarheadType.Fragmentation && warheadType != Warhead.WarheadType.ContinuousRod)
									{
										break;
									}
								}
								else
								{
									if (warheadType == Warhead.WarheadType.DirectionalContinousRod)
									{
										num2 += 2;
										break;
									}
									if (warheadType != Warhead.WarheadType.Nuclear)
									{
										break;
									}
								}
								num2++;
								break;
							}
							case Contact_Base.ContactType.Missile:
							{
								if (weapon.GetWeaponType() == Weapon._WeaponType.Gun && weapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() && !weapon.TargetIsLandFacility() && !weapon.TargetIsShipOrRadar())
								{
									num2++;
								}
								Warhead.WarheadType warheadType2 = warhead.warheadType;
								if (warheadType2 <= Warhead.WarheadType.ContinuousRod)
								{
									if (warheadType2 != Warhead.WarheadType.ArmorPiercing && warheadType2 != Warhead.WarheadType.Fragmentation && warheadType2 != Warhead.WarheadType.ContinuousRod)
									{
										break;
									}
								}
								else if (warheadType2 <= Warhead.WarheadType.LongRodPenetrator)
								{
									if (warheadType2 == Warhead.WarheadType.DirectionalContinousRod)
									{
										num2 += 2;
										break;
									}
									if (warheadType2 != Warhead.WarheadType.LongRodPenetrator)
									{
										break;
									}
								}
								else if (warheadType2 - Warhead.WarheadType.Laser_COIL > 3 && warheadType2 != Warhead.WarheadType.Kinetic)
								{
									break;
								}
								num2++;
								break;
							}
							case Contact_Base.ContactType.Surface:
							{
								if (weapon.TargetIsShipOrRadar() && !weapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
								{
									num2++;
								}
								Warhead.WarheadType warheadType3 = warhead.warheadType;
								if (warheadType3 <= Warhead.WarheadType.Nuclear)
								{
									switch (warheadType3)
									{
									case Warhead.WarheadType.HE_BlastFrag:
									case Warhead.WarheadType.ArmorPiercing:
									case Warhead.WarheadType.HEAT:
									case Warhead.WarheadType.SemiAP:
									case Warhead.WarheadType.HESH:
									case Warhead.WarheadType.HardTargetPenetrator:
										break;
									case Warhead.WarheadType.Incendiary:
									case Warhead.WarheadType.Fragmentation:
									case Warhead.WarheadType.ContinuousRod:
										goto IL_5C5;
									default:
										if (warheadType3 != Warhead.WarheadType.Nuclear)
										{
											goto IL_5C5;
										}
										break;
									}
								}
								else if (warheadType3 != Warhead.WarheadType.LongRodPenetrator && warheadType3 != Warhead.WarheadType.Kinetic)
								{
									break;
								}
								num2++;
								break;
							}
							case Contact_Base.ContactType.Submarine:
							{
								Warhead.WarheadType warheadType4 = warhead.warheadType;
								if (warheadType4 == Warhead.WarheadType.HEAT || warheadType4 == Warhead.WarheadType.HESH || warheadType4 - Warhead.WarheadType.Torpedo <= 1)
								{
									num2++;
								}
								break;
							}
							case Contact_Base.ContactType.Facility_Fixed:
							{
								if (weapon.TargetIsLandFacility() && !weapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
								{
									num2 += 2;
								}
								Warhead.WarheadType warheadType5 = warhead.warheadType;
								if (warheadType5 <= Warhead.WarheadType.Nuclear)
								{
									switch (warheadType5)
									{
									case Warhead.WarheadType.HE_BlastFrag:
									case Warhead.WarheadType.ArmorPiercing:
									case Warhead.WarheadType.HEAT:
									case Warhead.WarheadType.Incendiary:
									case Warhead.WarheadType.SemiAP:
									case Warhead.WarheadType.HESH:
									case Warhead.WarheadType.HardTargetPenetrator:
										break;
									case Warhead.WarheadType.Fragmentation:
									case Warhead.WarheadType.ContinuousRod:
										goto IL_48B;
									default:
										if (warheadType5 != Warhead.WarheadType.Nuclear)
										{
											goto IL_48B;
										}
										break;
									}
								}
								else if (warheadType5 != Warhead.WarheadType.Cluster_Penetrator && warheadType5 != Warhead.WarheadType.LongRodPenetrator && warheadType5 != Warhead.WarheadType.Kinetic)
								{
									goto IL_48B;
								}
								num2++;
								IL_48B:
								if (!Information.IsNothing(Target.ActualUnit) && Target.ActualUnit.MountsAreAimpoints() && warhead.method_12())
								{
									num2 += 3;
								}
								break;
							}
							case Contact_Base.ContactType.Facility_Mobile:
							{
								if (weapon.TargetIsLandFacility() && !weapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
								{
									num2++;
								}
								Warhead.WarheadType warheadType6 = warhead.warheadType;
								if (warheadType6 <= Warhead.WarheadType.Cluster_AT)
								{
									switch (warheadType6)
									{
									case Warhead.WarheadType.HE_BlastFrag:
									case Warhead.WarheadType.ArmorPiercing:
									case Warhead.WarheadType.HEAT:
									case Warhead.WarheadType.Incendiary:
									case Warhead.WarheadType.Fragmentation:
									case Warhead.WarheadType.HESH:
									case Warhead.WarheadType.SuperFrag:
										break;
									case Warhead.WarheadType.SemiAP:
									case Warhead.WarheadType.ContinuousRod:
									case Warhead.WarheadType.HardTargetPenetrator:
									case Warhead.WarheadType.FAE:
										goto IL_594;
									default:
										if (warheadType6 != Warhead.WarheadType.Nuclear && warheadType6 - Warhead.WarheadType.Cluster_AP > 1)
										{
											goto IL_594;
										}
										break;
									}
								}
								else if (warheadType6 <= Warhead.WarheadType.Landmine_AT)
								{
									if (warheadType6 != Warhead.WarheadType.Cluster_SmartSubs && warheadType6 - Warhead.WarheadType.Landmine_AP > 1)
									{
										goto IL_594;
									}
								}
								else if (warheadType6 != Warhead.WarheadType.LongRodPenetrator && warheadType6 != Warhead.WarheadType.Kinetic)
								{
									goto IL_594;
								}
								num2++;
								IL_594:
								if (!Information.IsNothing(Target.ActualUnit) && Target.ActualUnit.MountsAreAimpoints() && warhead.method_12())
								{
									num2 += 3;
								}
								break;
							}
							}
							IL_5C5:
							if (Target.GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownClass)
							{
								GlobalVariables.ArmorRating armorRating = (GlobalVariables.ArmorRating)0;
								switch (Target.contactType)
								{
								case Contact_Base.ContactType.Air:
								case Contact_Base.ContactType.Missile:
								case Contact_Base.ContactType.Orbital:
								case Contact_Base.ContactType.Torpedo:
								case Contact_Base.ContactType.Mine:
									armorRating = GlobalVariables.ArmorRating.None;
									goto IL_71C;
								case Contact_Base.ContactType.Surface:
								{
									ActiveUnit actualUnit = Target.ActualUnit;
									if (actualUnit.IsShip)
									{
										armorRating = ((Ship)actualUnit).ArmorBelt;
										goto IL_71C;
									}
									if (actualUnit.IsSubmarine)
									{
										armorRating = GlobalVariables.ArmorRating.Light;
										goto IL_71C;
									}
									if (actualUnit.IsFacility)
									{
										armorRating = ((Facility)actualUnit).ArmorGeneral;
										goto IL_71C;
									}
									goto IL_71C;
								}
								case Contact_Base.ContactType.Submarine:
									if (((Submarine)Target.ActualUnit).submarineCode.DoubleHull)
									{
										armorRating = GlobalVariables.ArmorRating.Medium;
										goto IL_71C;
									}
									armorRating = GlobalVariables.ArmorRating.Light;
									goto IL_71C;
								case Contact_Base.ContactType.Facility_Fixed:
								case Contact_Base.ContactType.Facility_Mobile:
									if (!Target.ActualUnit.MountsAreAimpoints())
									{
										armorRating = ((Facility)Target.ActualUnit).ArmorGeneral;
										goto IL_71C;
									}
									if (Target.ActualUnit.m_Mounts.Length > 0)
									{
										armorRating = Target.ActualUnit.m_Mounts[0].ArmorGeneral;
										goto IL_71C;
									}
									armorRating = ((Facility)Target.ActualUnit).ArmorGeneral;
									goto IL_71C;
								}
								armorRating = GlobalVariables.ArmorRating.Light;
								IL_71C:
								if (armorRating != GlobalVariables.ArmorRating.None)
								{
									if (armorRating != GlobalVariables.ArmorRating.Light)
									{
										Warhead.WarheadType warheadType7 = warhead.warheadType;
										if (warheadType7 <= Warhead.WarheadType.Cluster_SmartSubs)
										{
											switch (warheadType7)
											{
											case Warhead.WarheadType.ArmorPiercing:
											case Warhead.WarheadType.HEAT:
											case Warhead.WarheadType.SemiAP:
											case Warhead.WarheadType.HESH:
											case Warhead.WarheadType.HardTargetPenetrator:
												break;
											case Warhead.WarheadType.Incendiary:
											case Warhead.WarheadType.Fragmentation:
											case Warhead.WarheadType.ContinuousRod:
												goto IL_7BE;
											default:
												if (warheadType7 - Warhead.WarheadType.Cluster_AT > 1 && warheadType7 != Warhead.WarheadType.Cluster_SmartSubs)
												{
													goto IL_7BE;
												}
												break;
											}
										}
										else if (warheadType7 != Warhead.WarheadType.Landmine_AT && warheadType7 != Warhead.WarheadType.LongRodPenetrator && warheadType7 != Warhead.WarheadType.Kinetic)
										{
											goto IL_7BE;
										}
										num2++;
										IL_7BE:
										if (weapon.GetWeaponType() == Weapon._WeaponType.Gun)
										{
											if (warhead.Caliber > Warhead.WarheadCaliber.Gun_61_80mm)
											{
												num2++;
											}
											else
											{
												num2--;
											}
										}
									}
									else if (warhead.warheadType == Warhead.WarheadType.SuperFrag)
									{
										num2++;
									}
								}
								else
								{
									Warhead.WarheadType warheadType8 = warhead.warheadType;
									if (warheadType8 <= Warhead.WarheadType.DirectionalContinousRod)
									{
										if (warheadType8 <= Warhead.WarheadType.Fragmentation)
										{
											if (warheadType8 != Warhead.WarheadType.HE_BlastFrag && warheadType8 - Warhead.WarheadType.Incendiary > 1)
											{
												goto IL_8B5;
											}
										}
										else if (warheadType8 != Warhead.WarheadType.ContinuousRod && warheadType8 != Warhead.WarheadType.DirectionalContinousRod)
										{
											goto IL_8B5;
										}
									}
									else if (warheadType8 <= Warhead.WarheadType.Nuclear)
									{
										if (warheadType8 != Warhead.WarheadType.DepthCharge && warheadType8 != Warhead.WarheadType.Nuclear)
										{
											goto IL_8B5;
										}
									}
									else if (warheadType8 != Warhead.WarheadType.Cluster_AP && warheadType8 != Warhead.WarheadType.Landmine_AP)
									{
										goto IL_8B5;
									}
									num2++;
									IL_8B5:
									if (weapon.GetWeaponType() == Weapon._WeaponType.Gun)
									{
										if (warhead.Caliber <= Warhead.WarheadCaliber.Gun_61_80mm)
										{
											num2++;
										}
										else
										{
											num2--;
										}
									}
								}
							}
						}
						num = num2;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100301", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x00169E80 File Offset: 0x00168080
		public Weapon GetMaxRangeWeaponFor(Contact theTarget)
		{
			ActiveUnit_Weaponry.MaxRangeWeaponForTarget maxRangeWeaponForTarget = new ActiveUnit_Weaponry.MaxRangeWeaponForTarget();
			maxRangeWeaponForTarget.activeUnit_Weaponry = this;
			maxRangeWeaponForTarget.target = theTarget;
			Weapon result = null;
			try
			{
				Contact target = maxRangeWeaponForTarget.target;
				Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = null;
				IEnumerable<Weapon> weaponsForTargetsConsideringGunStrafeDoctrine = this.GetWeaponsForTargetsConsideringGunStrafeDoctrine(target, ref gunStrafeGroundTargets);
				if (weaponsForTargetsConsideringGunStrafeDoctrine.Count<Weapon>() == 0)
				{
					result = null;
				}
				else
				{
					int num = weaponsForTargetsConsideringGunStrafeDoctrine.Count<Weapon>();
					if (num != 0)
					{
						if (num != 1)
						{
							result = weaponsForTargetsConsideringGunStrafeDoctrine.OrderByDescending(new Func<Weapon, float>(maxRangeWeaponForTarget.GetMaxRangeToTarget)).ElementAtOrDefault(0);
						}
						else
						{
							result = weaponsForTargetsConsideringGunStrafeDoctrine.ElementAtOrDefault(0);
						}
					}
					else
					{
						result = null;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100302", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x00169F68 File Offset: 0x00168168
		public Weapon method_19(Contact target_, bool bool_7, bool bool_8, Doctrine doctrine_)
		{
			ActiveUnit_Weaponry.Class81 @class = new ActiveUnit_Weaponry.Class81();
			@class.activeUnit_Weaponry = this;
			@class.target = target_;
			@class.bool_0 = bool_7;
			@class.doctrine = doctrine_;
			Weapon result = null;
			try
			{
				ActiveUnit_Weaponry.Class82 class2 = new ActiveUnit_Weaponry.Class82();
				class2.class81_0 = @class;
				Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargetsDoctrine = class2.class81_0.doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
				List<Weapon> weaponsForTargetsConsideringGunStrafeDoctrine = this.GetWeaponsForTargetsConsideringGunStrafeDoctrine(class2.class81_0.target, ref gunStrafeGroundTargetsDoctrine);
				if (weaponsForTargetsConsideringGunStrafeDoctrine.Count == 0)
				{
					result = null;
				}
				else
				{
					class2.HorizontalRangeToTarget = this.ParentPlatform.GetHorizontalRange(class2.class81_0.target);
					IEnumerable<Weapon> source;
					if (bool_8 && class2.class81_0.bool_0)
					{
						source = weaponsForTargetsConsideringGunStrafeDoctrine.Where(new Func<Weapon, bool>(class2.method_0));
					}
					else if (bool_8 && !class2.class81_0.bool_0)
					{
						source = weaponsForTargetsConsideringGunStrafeDoctrine.Where(new Func<Weapon, bool>(class2.class81_0.method_0));
					}
					else if (!bool_8 && class2.class81_0.bool_0)
					{
						source = weaponsForTargetsConsideringGunStrafeDoctrine.Where(new Func<Weapon, bool>(class2.method_1));
					}
					else
					{
						source = weaponsForTargetsConsideringGunStrafeDoctrine;
					}
					int num = source.Count<Weapon>();
					if (num != 0)
					{
						if (num != 1)
						{
							result = source.OrderByDescending(new Func<Weapon, int>(class2.class81_0.method_1)).ThenByDescending(ActiveUnit_Weaponry.WeaponFunc5).ElementAtOrDefault(0);
						}
						else
						{
							result = source.ElementAtOrDefault(0);
						}
					}
					else
					{
						result = null;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100303", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x0016A14C File Offset: 0x0016834C
		public virtual void SchedulePlannedFire(float elapsedTime)
		{
			int num = this.ParentPlatform.m_Mounts.Length;
			try
			{
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					try
					{
						Mount mount = this.ParentPlatform.m_Mounts[num3];
						if (mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
						{
							float num4 = 0f;
							if (mount.GetTimeToFire() > 0f)
							{
								mount.SetTimeToFire(Math.Max(0f, mount.GetTimeToFire() - elapsedTime));
								num4 = mount.GetTimeToFire();
							}
							if (mount.GetMagazineForMount().GetTimeToFire() > 0f && mount.GetMagazineForMount().GetTimeToFire() > num4)
							{
								num4 = mount.GetMagazineForMount().GetTimeToFire();
							}
							int num5 = mount.GetWeaponRecCollection().Count - 1;
							for (int num6 = 0; num6 <= num5; num6++)
							{
								try
								{
									WeaponRec weaponRec = mount.GetWeaponRecCollection()[num6];
									WeaponRec weaponRec2 = weaponRec;
									weaponRec2.TimeToFire -= elapsedTime;
									if (weaponRec2.TimeToFire < 0f)
									{
										weaponRec2.TimeToFire = 0f;
									}
									if (weaponRec2.TimeToFire > num4)
									{
										num4 = weaponRec2.TimeToFire;
									}
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ex2.Data.Add("Error at 200437", ex2.Message);
									GameGeneral.LogException(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
								}
							}
							if (mount.GetMagazineForMount().GetTimeToFire() > 0f)
							{
								mount.GetMagazineForMount().SetTimeToFire(Math.Max(0f, mount.GetMagazineForMount().GetTimeToFire() - elapsedTime));
							}
							int num7 = mount.GetMagazineForMount().GetWeaponRecCollection().Count - 1;
							for (int num6 = 0; num6 <= num7; num6++)
							{
								try
								{
									WeaponRec weaponRec = mount.GetMagazineForMount().GetWeaponRecCollection()[num6];
									WeaponRec weaponRec3 = weaponRec;
									weaponRec3.TimeToFire -= elapsedTime;
									if (weaponRec3.TimeToFire < 0f)
									{
										weaponRec3.TimeToFire = 0f;
									}
									if (weaponRec3.TimeToFire > num4)
									{
										num4 = weaponRec3.TimeToFire;
									}
								}
								catch (Exception ex3)
								{
									ProjectData.SetProjectError(ex3);
									Exception ex4 = ex3;
									ex4.Data.Add("Error at 200438", ex4.Message);
									GameGeneral.LogException(ref ex4);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
								}
							}
							if (num4 <= 0f)
							{
								mount.ReloadStatus = Mount._ReloadStatus.const_0;
							}
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						ex6.Data.Add("Error at 200439", ex6.Message);
						GameGeneral.LogException(ref ex6);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
				if (this.ParentPlatform.IsPlatform())
				{
					Magazine[] magazines = ((Platform)this.ParentPlatform).m_Magazines;
					for (int i = 0; i < magazines.Length; i = checked(i + 1))
					{
						Magazine magazine = magazines[i];
						int num8 = magazine.GetWeaponRecCollection().Count - 1;
						for (int num3 = 0; num3 <= num8; num3++)
						{
							try
							{
								WeaponRec weaponRec = magazine.GetWeaponRecCollection()[num3];
								weaponRec.TimeToFire -= elapsedTime;
								if (weaponRec.TimeToFire < 0f)
								{
									weaponRec.TimeToFire = 0f;
								}
								goto IL_3CD;
							}
							catch (Exception ex7)
							{
								ProjectData.SetProjectError(ex7);
								Exception ex8 = ex7;
								ex8.Data.Add("Error at 200440", ex8.Message);
								GameGeneral.LogException(ref ex8);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								ProjectData.ClearProjectError();
								goto IL_3CD;
							}
							break;
							IL_3CD:;
						}
					}
				}
			}
			catch (Exception ex9)
			{
				ProjectData.SetProjectError(ex9);
				Exception ex10 = ex9;
				ex10.Data.Add("Error at 100304", "");
				GameGeneral.LogException(ref ex10);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x0016A5F0 File Offset: 0x001687F0
		public bool method_20(Contact target_, bool bool_7)
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					if (target_.ActualUnit.IsShip || target_.ActualUnit.IsFacility || target_.ActualUnit.IsSubmarine)
					{
						Weapon[] availableWeapons = this.GetAvailableWeapons(false);
						for (int i = 0; i < availableWeapons.Length; i++)
						{
							Weapon weapon = availableWeapons[i];
							if (weapon.IsSuitableForTarget(this.ParentPlatform.m_Scenario, ref target_) && string.CompareOrdinal(this.method_21(weapon, target_), "OK") == 0)
							{
								if (bool_7)
								{
									Weapon theWeapon = weapon;
									Contact theTarget = target_;
									short? num = null;
									Mount theMount = null;
									Sensor sensor = null;
									if (Operators.CompareString(this.CheckWeaponAttackCondition(theWeapon, theTarget, ref num, false, false, theMount, ref sensor), "OK", false) != 0)
									{
										goto IL_B0;
									}
								}
								flag = true;
								result = true;
								return result;
							}
							IL_B0:;
						}
					}
					flag = false;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100305", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x0016A71C File Offset: 0x0016891C
		public string method_21(Weapon theWeapon, Contact theTarget)
		{
			string result = "";
			try
			{
				Doctrine._BehaviorTowardsAmbigousTarget? behaviorTowardsAmbigousTargetDoctrine = this.ParentPlatform.m_Doctrine.GetBehaviorTowardsAmbigousTargetDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
				byte? b = behaviorTowardsAmbigousTargetDoctrine.HasValue ? new byte?((byte)behaviorTowardsAmbigousTargetDoctrine.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					result = "OK";
				}
				else
				{
					b = (behaviorTowardsAmbigousTargetDoctrine.HasValue ? new byte?((byte)behaviorTowardsAmbigousTargetDoctrine.GetValueOrDefault()) : null);
					int num = 0;
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						num = 3;
					}
					else
					{
						b = (behaviorTowardsAmbigousTargetDoctrine.HasValue ? new byte?((byte)behaviorTowardsAmbigousTargetDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							num = 1;
						}
					}
					float downRangeAmbiguity = theTarget.GetDownRangeAmbiguity(this.ParentPlatform);
					float num2 = (float)Math.Round((double)theWeapon.GetDownRangeAmbiguityLimit(), 1);
					string text = (num > 1) ? " " : (" " + Conversions.ToString(num) + "x ");
					if (Math.Round((double)downRangeAmbiguity, 1) > Math.Round((double)(num2 * (float)num), 1))
					{
						result = string.Concat(new string[]
						{
							"目标纵向距离不确定性区间(",
							Conversions.ToString(Math.Round((double)downRangeAmbiguity, 1)),
							"海里)超过",
							text,
							"武器可接受的极限(",
							Conversions.ToString(num2),
							"海里)"
						});
					}
					else
					{
						float crossRangeAmbiguity = theTarget.GetCrossRangeAmbiguity(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null));
						float num3 = (float)Math.Round((double)theWeapon.GetCrossRangeAmbiguityLimit(), 1);
						if (Math.Round((double)crossRangeAmbiguity, 1) > Math.Round((double)num3, 1))
						{
							result = string.Concat(new string[]
							{
								"目标横向距离不确定性区间(",
								Conversions.ToString(Math.Round((double)crossRangeAmbiguity, 1)),
								"海里)超过",
								text,
								"武器可接受的极限(",
								Conversions.ToString(num3),
								"海里)"
							});
						}
						else
						{
							result = "OK";
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100306", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x0016AA38 File Offset: 0x00168C38
		public float GetWeaponRange(ref ActiveUnit activeUnit_, ref Weapon weapon_, ref Contact contact_, bool bool_7)
		{
			float result;
			if (weapon_.IsGuidedWeapon_RV_HGV() && this.method_28(weapon_, contact_) && contact_.GetCurrentSpeed() != 0f)
			{
				if (!contact_.IsSurfaceOrLandTarget() && !contact_.IsFixed())
				{
					if (!contact_.IsBallisticMissileOrReEntryVehicles() && !contact_.ActualUnit.IsSatellite())
					{
						if (contact_.IsAir())
						{
							result = weapon_.GetMaxRangeToTarget(this.ParentPlatform, contact_, false, null, false);
						}
						else
						{
							result = (float)((double)weapon_.GetMaxRangeToTarget(this.ParentPlatform, contact_, false, null, false) * 1.5);
						}
					}
					else
					{
						result = weapon_.GetMaxRangeToTarget(this.ParentPlatform, contact_, false, null, false) * 10f;
					}
				}
				else
				{
					result = weapon_.GetMaxRangeToTarget(this.ParentPlatform, contact_, false, null, false);
				}
			}
			else
			{
				bool? flag;
				bool? flag5;
				if (!weapon_.IsTorpedo())
				{
					flag = new bool?(false);
				}
				else
				{
					Doctrine._UseTorpedoesKinematicRange? useTorpedoesKinematicRangeDoctrine = this.ParentPlatform.m_Doctrine.GetUseTorpedoesKinematicRangeDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
					byte? b = useTorpedoesKinematicRangeDoctrine.HasValue ? new byte?((byte)useTorpedoesKinematicRangeDoctrine.GetValueOrDefault()) : null;
					bool? flag3;
					bool? flag2 = flag3 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null);
					if (flag2.HasValue && flag3.GetValueOrDefault())
					{
						flag = new bool?(true);
					}
					else
					{
						bool? flag4;
						if (!bool_7)
						{
							flag4 = new bool?(false);
						}
						else
						{
							useTorpedoesKinematicRangeDoctrine = this.ParentPlatform.m_Doctrine.GetUseTorpedoesKinematicRangeDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
							b = (useTorpedoesKinematicRangeDoctrine.HasValue ? new byte?((byte)useTorpedoesKinematicRangeDoctrine.GetValueOrDefault()) : null);
							flag4 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null);
						}
						flag2 = (flag5 = flag4);
						flag = (flag2.HasValue ? (flag3 | flag5.GetValueOrDefault()) : null);
					}
				}
				flag5 = flag;
				if (flag5.GetValueOrDefault())
				{
					result = Math.Max(weapon_.TorpedoRangeCruise, weapon_.TorpedoRangeFull);
				}
				else if (weapon_.GetWeaponType() == Weapon._WeaponType.Gun && contact_.IsMissile() && !Information.IsNothing(contact_.ActualUnit) && !Information.IsNothing(contact_.ActualUnit.GetAI().GetPrimaryTarget()) && !Information.IsNothing(contact_.ActualUnit.GetAI().GetPrimaryTarget().ActualUnit) && contact_.ActualUnit.GetAI().GetPrimaryTarget().ActualUnit == activeUnit_)
				{
					if (contact_.GetCurrentAltitude_ASL(false) < 650f)
					{
						result = (float)Math.Min((double)weapon_.GetMaxRangeToTarget(this.ParentPlatform, contact_, false, null, false) * 1.5, 1.5);
					}
					else
					{
						float num;
						if (contact_.GetCurrentSpeed() < 1000f)
						{
							num = 1.5f;
						}
						else
						{
							num = 2f;
						}
						float num2 = (float)((double)Math.Abs(this.ParentPlatform.GetCurrentAltitude_ASL(false) - contact_.GetCurrentAltitude_ASL(false)) / 1852.0);
						result = (float)Math.Sqrt((double)(num * num + num2 * num2));
					}
				}
				else
				{
					result = weapon_.GetMaxRangeToTarget(this.ParentPlatform, contact_, false, this.ParentPlatform.m_Doctrine, bool_7);
				}
			}
			return result;
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x0016ADEC File Offset: 0x00168FEC
		public void method_23()
		{
			ActiveUnit_Weaponry.Class83 @class = new ActiveUnit_Weaponry.Class83(null);
			Weapon weapon = null;
			Contact contact = null;
			foreach (string current in this.hashSet_0)
			{
				int num = Conversions.ToInteger(current.Split(Conversions.ToCharArrayRankOne("_")).ToList<string>()[0]);
				@class.string_0 = current.Split(Conversions.ToCharArrayRankOne("_")).ToList<string>()[1];
				try
				{
					contact = this.ParentPlatform.GetAI().GetTargets().Where((@class.func_0 == null) ? (@class.func_0 = new Func<Contact, bool>(@class.method_0)) : @class.func_0).ElementAtOrDefault(0);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200441", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
					continue;
				}
				Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargetsDoctrine = this.ParentPlatform.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
				foreach (Weapon current2 in this.GetWeaponsForTargetsConsideringGunStrafeDoctrine(contact, ref gunStrafeGroundTargetsDoctrine))
				{
					if (current2.DBID == num)
					{
						weapon = current2;
					}
				}
				if (!Information.IsNothing(weapon) && !Information.IsNothing(contact))
				{
					string value = this.method_25(contact, weapon);
					this.lazy_0.Value.TryAdd(new Tuple<int, string>(num, @class.string_0), value);
				}
			}
			this.hashSet_0.Clear();
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x0016B004 File Offset: 0x00169204
		public string CheckWeaponAttackCondition(Weapon theWeapon, Contact theTarget, ref short? ASL_atFiringUnit, bool ManualFire, bool IgnoreAircraftOrientation, Mount theMount, ref Sensor SuitableDirectorSensor)
		{
			string text = "";
			string result;
			try
			{
				if (Information.IsNothing(theTarget))
				{
					text = "目标为空";
				}
				else if (Information.IsNothing(theWeapon))
				{
					text = "武器为空";
				}
				else if (!this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.EMP_Dir) && theWeapon.m_Warheads.Length > 0 && theWeapon.m_Warheads[0].warheadType == Warhead.WarheadType.EMP_Directed)
				{
					text = "本想定不支持定向电磁脉冲武器.";
				}
				else if (!this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.HGV) && theWeapon.m_Warheads.Length > 0 && !Information.IsNothing(theWeapon.m_Warheads[0].GetWeaponFromDP(this.ParentPlatform.m_Scenario)) && theWeapon.m_Warheads[0].GetWeaponFromDP(this.ParentPlatform.m_Scenario).GetWeaponType() == Weapon._WeaponType.HGV)
				{
					text = "本想定不支持高超声速滑翔弹.";
				}
				else if (theWeapon.IsLaserWeapon() && !(!this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.HighEnergyLasers) | GameGeneral.bProfessionEdition))
				{
					int dBID = theWeapon.DBID;
					if (dBID != 1203 && dBID != 3432)
					{
						text = "本想定不支持Phase-2高能激光器.";
						result = text;
						return result;
					}
				}
				else if (!this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.RailgunOrHVP) && theWeapon.GetWeaponType() == Weapon._WeaponType.GuidedProjectile && (theWeapon.Name.Contains("HVP") || theWeapon.Name.ToLower().Contains("railgun")))
				{
					text = "本想定不支持高超声速或磁轨炮。";
				}
				else if (theWeapon.GetWeaponType() != Weapon._WeaponType.Decoy_Expendable && theWeapon.GetWeaponType() != Weapon._WeaponType.Decoy_Towed)
				{
					if (theWeapon.IsMine())
					{
						UnguidedWeapon unguidedWeapon = new UnguidedWeapon(theWeapon, null, null, 0.0, 0.0, 0L);
						Unit unit = theTarget;
						bool? flag = null;
						double latitude = unit.GetLatitude(flag);
						Unit unit2 = theTarget;
						flag = null;
						string text2 = UnguidedWeapon.LayMine(ref unguidedWeapon, latitude, unit2.GetLongitude(flag), (float)theTarget.GetTerrainElevation(false, false, false), this.ParentPlatform.m_Scenario);
						if (string.CompareOrdinal(text2, "OK") != 0)
						{
							text = text2;
							result = text;
							return result;
						}
						text = "可以在此布雷。请为作战单元分配布雷任务。";
						result = text;
						return result;
					}
					else
					{
						if (!theWeapon.IsSuitableForTarget(this.ParentPlatform.m_Scenario, ref theTarget))
						{
							text = "武器与目标不匹配";
							result = text;
							return result;
						}
						if (!Information.IsNothing(theMount))
						{
							if (theMount.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
							{
								text = "武器挂架不能工作";
								result = text;
								return result;
							}
							if (theMount.ReloadStatus == Mount._ReloadStatus.Reloading)
							{
								text = "武器正在重新装载";
								result = text;
								return result;
							}
							if (theMount.ReloadStatus == Mount._ReloadStatus.Unloading)
							{
								text = "武器正在卸载";
								result = text;
								return result;
							}
							if (this.ParentPlatform.GetCurrentAltitude_ASL(false) < 0f && theWeapon.GetWeaponType() == Weapon._WeaponType.Gun)
							{
								text = "火炮不能水下射击";
								result = text;
								return result;
							}
						}
						if (theWeapon.HasNuclearWarhead() && this.ParentPlatform.m_Doctrine.GetUseNuclearDoctrine(this.ParentPlatform.m_Scenario, false, false, false).Value != Doctrine._UseNuclear.const_1 && (!this.ParentPlatform.IsWeapon || !((Weapon)this.ParentPlatform).weaponCode.BallisticMissile))
						{
							text = "没有授权本作战单元使用核武器";
							result = text;
							return result;
						}
						if (theWeapon.method_138() && theTarget.contactType == Contact_Base.ContactType.Facility_Mobile && theTarget.GetCurrentSpeed() > 0f && theTarget.Age > 5f)
						{
							text = "目标数据更新间隔时间超过5秒 -需要最新瞄准数据才能使用非制导武器";
							result = text;
							return result;
						}
						float horizontalRange = this.ParentPlatform.GetHorizontalRange(theTarget);
						float slantRange = this.ParentPlatform.GetSlantRange(theTarget, horizontalRange);
						if (theWeapon.GetWeaponType() == Weapon._WeaponType.Dispenser && horizontalRange * 1852f > (float)theWeapon.m_Warheads[0].ClusterBombDispersionAreaLength)
						{
							text = "目标超出武器射程";
							result = text;
							return result;
						}
						if (theWeapon.IsTorpedo() && this.ParentPlatform.IsAircraft && theTarget.contactType == Contact_Base.ContactType.Submarine && (double)horizontalRange > 0.4)
						{
							text = "反潜鱼雷必须在距离目标/瞄准点0.4海里之内投放";
							result = text;
							return result;
						}
						float weaponRange = this.GetWeaponRange(ref this.ParentPlatform, ref theWeapon, ref theTarget, ManualFire);
						if (theWeapon.GetWeaponType() == Weapon._WeaponType.Gun)
						{
							if (weaponRange < slantRange)
							{
								text = "目标超出武器射程";
								result = text;
								return result;
							}
						}
						else if (weaponRange < horizontalRange)
						{
							text = "目标超出武器射程";
							result = text;
							return result;
						}
						if (theWeapon.GetWeaponType() == Weapon._WeaponType.Gun)
						{
							if (theWeapon.TargetWithinRangeOfSuitableWeapon(slantRange, theTarget))
							{
								text = "目标在武器最小射程之内";
								result = text;
								return result;
							}
						}
						else if (theWeapon.TargetWithinRangeOfSuitableWeapon(horizontalRange, theTarget))
						{
							text = "目标在武器最小射程之内";
							result = text;
							return result;
						}
						if (this.ParentPlatform.IsAircraft && !theTarget.IsAirSpace() && !theTarget.IsSubSurface() && theWeapon.method_138())
						{
							float num = theWeapon.method_140(this.ParentPlatform.GetCurrentAltitude_ASL(false), theTarget.contactType);
							if (num >= 0f && horizontalRange > num)
							{
								text = string.Concat(new string[]
								{
									"与目标水平距离 (",
									Conversions.ToString(Math.Round((double)horizontalRange, 1)),
									"海里)超出武器在本高度上的地面投影距离(",
									Conversions.ToString(Math.Round((double)num, 1)),
									"海里)"
								});
								result = text;
								return result;
							}
						}
						if (theWeapon.IsGuidedWeapon_RV_HGV() && theWeapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
						{
							Contact_Base.ContactType contactType = theTarget.contactType;
							if (contactType == Contact_Base.ContactType.Surface && this.ParentPlatform.m_Doctrine.GetUseSAMsInASuWModeDoctrine(this.ParentPlatform.m_Scenario, false, false, false).Value != Doctrine._UseSAMsInASuWMode.const_1)
							{
								text = "没有授权本作战单元使用舰空导弹打击水面目标";
								result = text;
								return result;
							}
						}
						if (theWeapon.TargetSpeedMax > 0 && theTarget.GetCurrentSpeed() > (float)theWeapon.TargetSpeedMax * 1.2f)
						{
							text = string.Concat(new string[]
							{
								"目标速度(",
								Conversions.ToString((int)Math.Round((double)theTarget.GetCurrentSpeed())),
								" 节)远超过武器的最大目标速度(",
								Conversions.ToString(theWeapon.TargetSpeedMax),
								" 节)"
							});
							result = text;
							return result;
						}
						if (theTarget.contactType == Contact_Base.ContactType.ActivationPoint && !theWeapon.weaponCode.BOLCapable)
						{
							text = "武器不支持纯方位攻击";
							result = text;
							return result;
						}
						if (!theTarget.IsBallisticMissileOrReEntryVehicles() && theTarget.contactType != Contact_Base.ContactType.Surface)
						{
							if (theWeapon.TargetAltitudeMax > 0f)
							{
								float num2;
								if (this.ParentPlatform.IsFacility)
								{
									num2 = this.ParentPlatform.GetCurrentAltitude_ASL(false) + theWeapon.TargetAltitudeMax;
								}
								else
								{
									num2 = theWeapon.TargetAltitudeMax;
								}
								if (theTarget.GetAltitude_AGL() > num2 && theTarget.IsOnLand())
								{
									if (SimConfiguration.gameOptions.UseImperialUnit())
									{
										text = string.Concat(new string[]
										{
											"目标高度(",
											Conversions.ToString((int)Math.Round((double)(theTarget.GetAltitude_AGL() * 3.28084f))),
											"英尺(真高))超过武器的最大高度(",
											Conversions.ToString((int)Math.Round((double)(num2 * 3.28084f))),
											"英尺(真高))"
										});
										result = text;
										return result;
									}
									text = string.Concat(new string[]
									{
										"目标高度(",
										Conversions.ToString((int)Math.Round((double)theTarget.GetAltitude_AGL())),
										"米(真高))超过武器的最大高度(",
										Conversions.ToString(num2),
										"米(真高))"
									});
									result = text;
									return result;
								}
							}
							if (theWeapon.TargetAltitudeMax_ASL > 0f && theTarget.GetCurrentAltitude_ASL(false) > theWeapon.TargetAltitudeMax_ASL)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									text = string.Concat(new string[]
									{
										"目标高度 (",
										Conversions.ToString((int)Math.Round((double)(theTarget.GetCurrentAltitude_ASL(false) * 3.28084f))),
										"英尺(海高))超过武器的最大高度 (",
										Conversions.ToString((int)Math.Round((double)(theWeapon.TargetAltitudeMax_ASL * 3.28084f))),
										"英尺(海高))"
									});
									result = text;
									return result;
								}
								text = string.Concat(new string[]
								{
									"目标高度 (",
									Conversions.ToString((int)Math.Round((double)theTarget.GetCurrentAltitude_ASL(false))),
									"米(海高))超过武器的最大高度 (",
									Conversions.ToString(theWeapon.TargetAltitudeMax_ASL),
									"米(海高))"
								});
								result = text;
								return result;
							}
							else
							{
								if (theWeapon.TargetAltitudeMin > 0f)
								{
									float targetAltitudeMin = theWeapon.TargetAltitudeMin;
									if (theTarget.GetAltitude_AGL() < targetAltitudeMin)
									{
										if (SimConfiguration.gameOptions.UseImperialUnit())
										{
											text = string.Concat(new string[]
											{
												"目标高度 (",
												Conversions.ToString((int)Math.Round((double)(theTarget.GetAltitude_AGL() * 3.28084f))),
												"英尺(真高))低于武器的最低交战高度(",
												Conversions.ToString((int)Math.Round((double)(targetAltitudeMin * 3.28084f))),
												"英尺(真高))"
											});
											result = text;
											return result;
										}
										text = string.Concat(new string[]
										{
											"目标高度 (",
											Conversions.ToString((int)Math.Round((double)theTarget.GetAltitude_AGL())),
											"米(真高))低于武器的最低交战高度(",
											Conversions.ToString(targetAltitudeMin),
											"米(真高))"
										});
										result = text;
										return result;
									}
								}
								if (theWeapon.TargetAltitudeMin_ASL > 0f && theTarget.GetCurrentAltitude_ASL(false) < theWeapon.TargetAltitudeMin_ASL)
								{
									if (SimConfiguration.gameOptions.UseImperialUnit())
									{
										text = string.Concat(new string[]
										{
											"目标高度 (",
											Conversions.ToString((int)Math.Round((double)(theTarget.GetCurrentAltitude_ASL(false) * 3.28084f))),
											"英尺(海高))低于武器的最低交战高度(",
											Conversions.ToString((int)Math.Round((double)(theWeapon.TargetAltitudeMin_ASL * 3.28084f))),
											"英尺(海高))"
										});
										result = text;
										return result;
									}
									text = string.Concat(new string[]
									{
										"目标高度 (",
										Conversions.ToString((int)Math.Round((double)theTarget.GetCurrentAltitude_ASL(false))),
										"米(海高))低于武器的最低交战高度(",
										Conversions.ToString(theWeapon.TargetAltitudeMin_ASL),
										"米(海高))"
									});
									result = text;
									return result;
								}
							}
						}
						if (!theTarget.IsBallisticMissileOrReEntryVehicles() && this.ParentPlatform.m_Scenario.FeatureCompatibility.get_WeaponSnapUpDown(this.ParentPlatform.m_Scenario.GetSQLiteConnection()) && theWeapon.SnapUpDownAltitude_m > 0f && theTarget.IsAirSpace())
						{
							float num3 = Math.Abs(theTarget.GetCurrentAltitude_ASL(false) - this.ParentPlatform.GetCurrentAltitude_ASL(false));
							if (num3 > theWeapon.SnapUpDownAltitude_m)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									text = string.Concat(new string[]
									{
										"目标高度上的变化(",
										Conversions.ToString((int)Math.Round((double)(num3 * 3.28084f))),
										"英尺)超过武器在垂直方向上的机动能力 (",
										Conversions.ToString((int)Math.Round((double)(theWeapon.SnapUpDownAltitude_m * 3.28084f))),
										"英尺)"
									});
									result = text;
									return result;
								}
								text = string.Concat(new string[]
								{
									"目标高度上的变化(",
									Conversions.ToString((int)Math.Round((double)num3)),
									"米)超过武器在垂直方向上的机动能力 (",
									Conversions.ToString((int)Math.Round((double)theWeapon.SnapUpDownAltitude_m)),
									"米)"
								});
								result = text;
								return result;
							}
						}
						if (!theWeapon.HasNuclearWarhead() && theTarget.contactType == Contact_Base.ContactType.Submarine && (theWeapon.GetWeaponType() == Weapon._WeaponType.DepthCharge || theWeapon.GetWeaponType() == Weapon._WeaponType.Rocket) && !Information.IsNothing(theTarget.GetUncertaintyArea()))
						{
							text = "武器需要目标的的精确位置信息";
							result = text;
							return result;
						}
						if (!Information.IsNothing(theMount))
						{
							int num4 = 0;
							foreach (WeaponRec current in theMount.GetWeaponRecCollection())
							{
								if (current.WeapID == theWeapon.DBID)
								{
									num4 += current.GetCurrentLoad();
								}
							}
							if (num4 == 0)
							{
								text = "武器没有装载到挂架上";
								result = text;
								return result;
							}
						}
						Weapon weapon = theWeapon;
						bool? flag = null;
						bool? hintIsOperating = flag;
						ActiveUnit parentPlatform = this.ParentPlatform;
						flag = null;
						weapon.SetLatitude(hintIsOperating, parentPlatform.GetLatitude(flag));
						Weapon weapon2 = theWeapon;
						flag = null;
						bool? hintIsOperating2 = flag;
						ActiveUnit parentPlatform2 = this.ParentPlatform;
						flag = null;
						weapon2.SetLongitude(hintIsOperating2, parentPlatform2.GetLongitude(flag));
						theWeapon.SetAltitude_ASL(false, this.ParentPlatform.GetCurrentAltitude_ASL(false));
						if (this.ParentPlatform.IsAircraft)
						{
							theWeapon.SetCurrentHeading(this.ParentPlatform.GetCurrentHeading());
						}
						else if (!this.ParentPlatform.IsFacility && !this.ParentPlatform.IsShip)
						{
							if (this.ParentPlatform.IsSubmarine)
							{
								if (theWeapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
								{
									Weapon weapon3 = theWeapon;
									ActiveUnit parentPlatform3 = this.ParentPlatform;
									flag = null;
									double latitude2 = parentPlatform3.GetLatitude(flag);
									ActiveUnit parentPlatform4 = this.ParentPlatform;
									flag = null;
									double longitude = parentPlatform4.GetLongitude(flag);
									Unit unit3 = theTarget;
									flag = null;
									double latitude3 = unit3.GetLatitude(flag);
									Unit unit4 = theTarget;
									flag = null;
									weapon3.SetCurrentHeading(Math2.GetAzimuth(latitude2, longitude, latitude3, unit4.GetLongitude(flag)));
								}
								else
								{
									theWeapon.SetCurrentHeading(this.ParentPlatform.GetCurrentHeading());
								}
							}
						}
						else
						{
							Weapon weapon4 = theWeapon;
							ActiveUnit parentPlatform5 = this.ParentPlatform;
							flag = null;
							double latitude4 = parentPlatform5.GetLatitude(flag);
							ActiveUnit parentPlatform6 = this.ParentPlatform;
							flag = null;
							double longitude2 = parentPlatform6.GetLongitude(flag);
							Unit unit5 = theTarget;
							flag = null;
							double latitude5 = unit5.GetLatitude(flag);
							Unit unit6 = theTarget;
							flag = null;
							weapon4.SetCurrentHeading(Math2.GetAzimuth(latitude4, longitude2, latitude5, unit6.GetLongitude(flag)));
						}
						if (this.ParentPlatform.IsAircraft && !theTarget.IsOrbital() && (theWeapon.LaunchAltitudeMin != 0f || theWeapon.LaunchAltitudeMax != 0f || theWeapon.LaunchAltitudeMin_ASL != 0f || theWeapon.LaunchAltitudeMax_ASL != 0f))
						{
							if (!ASL_atFiringUnit.HasValue)
							{
								ASL_atFiringUnit = new short?((short)Math.Max(0, this.ParentPlatform.GetTerrainElevation(false, false, false)));
							}
							short value = ASL_atFiringUnit.Value;
							if (theWeapon.LaunchAltitudeMax > 0f && (double)(this.ParentPlatform.GetCurrentAltitude_ASL(false) - (float)value) > (double)theWeapon.LaunchAltitudeMax + 0.1)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									if (value > 0)
									{
										if (theWeapon.LaunchAltitudeMin > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太高 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin * 3.28084f))),
												"英尺(真高) —",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax * 3.28084f))),
												"英尺(真高), 地形海拔：",
												Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
												" 英尺)"
											});
											result = text;
											return result;
										}
										if (theWeapon.LaunchAltitudeMin_ASL > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太高 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin_ASL * 3.28084f))),
												"英尺(海高) — ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax * 3.28084f))),
												"英尺(真高),地形海拔：",
												Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
												" 英尺)"
											});
											result = text;
											return result;
										}
										text = string.Concat(new string[]
										{
											"飞机高度太高 (最高有效高度: ",
											Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax * 3.28084f))),
											"英尺(真高),地形海拔：",
											Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
											" 英尺)"
										});
										result = text;
										return result;
									}
									else
									{
										if (theWeapon.LaunchAltitudeMin > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太高 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin * 3.28084f))),
												"英尺(真高) — ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax * 3.28084f))),
												"英尺(真高))"
											});
											result = text;
											return result;
										}
										if (theWeapon.LaunchAltitudeMin_ASL > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太高 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin_ASL * 3.28084f))),
												"英尺(海高) — ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax * 3.28084f))),
												"英尺(真高))"
											});
											result = text;
											return result;
										}
										text = "飞机高度太高 (最大有效高度: " + Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax * 3.28084f))) + "英尺(真高))";
										result = text;
										return result;
									}
								}
								else if (value > 0)
								{
									if (theWeapon.LaunchAltitudeMin > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太高 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin)),
											"米(真高) — ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax)),
											"米(真高),地形海拔：",
											Conversions.ToString((int)value),
											"米)"
										});
										result = text;
										return result;
									}
									if (theWeapon.LaunchAltitudeMin_ASL > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太高 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin_ASL)),
											"米(海高) — ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax)),
											"米(真高),地形海拔：",
											Conversions.ToString((int)value),
											"米)"
										});
										result = text;
										return result;
									}
									text = string.Concat(new string[]
									{
										"飞机高度太高 (最大有效高度: ",
										Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax)),
										"米(真高) ,地形海拔：",
										Conversions.ToString((int)value),
										"米)"
									});
									result = text;
									return result;
								}
								else
								{
									if (theWeapon.LaunchAltitudeMin > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太高 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin)),
											"米(真高) — ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax)),
											"米(真高))"
										});
										result = text;
										return result;
									}
									if (theWeapon.LaunchAltitudeMin_ASL > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太高 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin_ASL)),
											"米(海高) — ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax)),
											"米(真高))"
										});
										result = text;
										return result;
									}
									text = "飞机高度太高 (最大有效高度: " + Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax)) + "米(真高))";
									result = text;
									return result;
								}
							}
							else if (theWeapon.LaunchAltitudeMax_ASL > 0f && (double)this.ParentPlatform.GetCurrentAltitude_ASL(false) > (double)theWeapon.LaunchAltitudeMax_ASL + 0.1)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									if (value > 0)
									{
										if (theWeapon.LaunchAltitudeMin > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太高 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin * 3.28084f))),
												"英尺(真高) —",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax_ASL * 3.28084f))),
												"英尺(海高),地形海拔：",
												Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
												"英尺)"
											});
											result = text;
											return result;
										}
										if (theWeapon.LaunchAltitudeMin_ASL > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太高 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin_ASL * 3.28084f))),
												"英尺(海高) —",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax_ASL * 3.28084f))),
												"英尺(海高),地形海拔：",
												Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
												"英尺)"
											});
											result = text;
											return result;
										}
										text = string.Concat(new string[]
										{
											"飞机高度太高 (最大有效高度: ",
											Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax_ASL * 3.28084f))),
											"英尺(海高),地形海拔：",
											Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
											"英尺)"
										});
										result = text;
										return result;
									}
									else
									{
										if (theWeapon.LaunchAltitudeMin > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太高 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin * 3.28084f))),
												"英尺(真高) —",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax_ASL * 3.28084f))),
												"英尺(海高))"
											});
											result = text;
											return result;
										}
										if (theWeapon.LaunchAltitudeMin_ASL > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太高 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin_ASL * 3.28084f))),
												"英尺(海高) — ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax_ASL * 3.28084f))),
												"英尺(海高))"
											});
											result = text;
											return result;
										}
										text = "飞机高度太高 (有效高度: " + Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax_ASL * 3.28084f))) + "英尺(海高) maximum)";
										result = text;
										return result;
									}
								}
								else if (value > 0)
								{
									if (theWeapon.LaunchAltitudeMin > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太高 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin)),
											"米(真高) —",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax_ASL)),
											"米(海高),地形海拔：",
											Conversions.ToString((int)value),
											"米)"
										});
										result = text;
										return result;
									}
									if (theWeapon.LaunchAltitudeMin_ASL > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太高 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin_ASL)),
											"米(海高) — ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax_ASL)),
											"米(海高),地形海拔：",
											Conversions.ToString((int)value),
											"米)"
										});
										result = text;
										return result;
									}
									text = string.Concat(new string[]
									{
										"飞机高度太高 (最大有效高度: ",
										Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax_ASL)),
										"米(海高),地形海拔：",
										Conversions.ToString((int)value),
										"米)"
									});
									result = text;
									return result;
								}
								else
								{
									if (theWeapon.LaunchAltitudeMin > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太高 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin)),
											"米(真高) —",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax_ASL)),
											"米(海高))"
										});
										result = text;
										return result;
									}
									if (theWeapon.LaunchAltitudeMin_ASL > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太高 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin_ASL)),
											"米(海高) — ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax_ASL)),
											"米(海高))"
										});
										result = text;
										return result;
									}
									text = "飞机高度太高 (最大有效高度: " + Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax_ASL)) + "米(海高))";
									result = text;
									return result;
								}
							}
							else if (theWeapon.LaunchAltitudeMin > 0f && (double)this.ParentPlatform.GetCurrentAltitude_ASL(false) < (double)(theWeapon.LaunchAltitudeMin + (float)value) - 0.1)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									if (value > 0)
									{
										if (theWeapon.LaunchAltitudeMax > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太低 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin * 3.28084f))),
												"英尺(真高) — ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax * 3.28084f))),
												"英尺(真高),地形海拔：",
												Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
												"英尺)"
											});
											result = text;
											return result;
										}
										if (theWeapon.LaunchAltitudeMax_ASL > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太低 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin * 3.28084f))),
												"英尺(真高) — ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax_ASL * 3.28084f))),
												"英尺(海高),地形海拔：",
												Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
												"英尺)"
											});
											result = text;
											return result;
										}
										text = string.Concat(new string[]
										{
											"飞机高度太低 (最小有效高度: ",
											Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin * 3.28084f))),
											"英尺(真高),地形海拔：",
											Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
											"英尺)"
										});
										result = text;
										return result;
									}
									else
									{
										if (theWeapon.LaunchAltitudeMax > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太低 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin * 3.28084f))),
												"英尺(真高) — ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax * 3.28084f))),
												"英尺(真高))"
											});
											result = text;
											return result;
										}
										if (theWeapon.LaunchAltitudeMax_ASL > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太低 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin * 3.28084f))),
												"英尺(真高) — ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax_ASL * 3.28084f))),
												"英尺(海高))"
											});
											result = text;
											return result;
										}
										text = "飞机高度太低 (最小有效高度: " + Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin * 3.28084f))) + "英尺(真高))";
										result = text;
										return result;
									}
								}
								else if (value > 0)
								{
									if (theWeapon.LaunchAltitudeMax > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太低 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin)),
											"米(真高) — ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax)),
											"米(真高),地形海拔：",
											Conversions.ToString((int)value),
											"米)"
										});
										result = text;
										return result;
									}
									if (theWeapon.LaunchAltitudeMax_ASL > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太低 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin)),
											"米(真高) — ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax_ASL)),
											"米(海高),地形海拔：",
											Conversions.ToString((int)value),
											"米)"
										});
										result = text;
										return result;
									}
									text = string.Concat(new string[]
									{
										"飞机高度太低 (最小有效高度: ",
										Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin)),
										"米(真高),地形海拔：",
										Conversions.ToString((int)value),
										"米)"
									});
									result = text;
									return result;
								}
								else
								{
									if (theWeapon.LaunchAltitudeMax > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太低 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin)),
											"米(真高) —",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax)),
											"米(真高))"
										});
										result = text;
										return result;
									}
									if (theWeapon.LaunchAltitudeMax_ASL > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太低 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin)),
											"米(真高) — ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax_ASL)),
											"米(海高))"
										});
										result = text;
										return result;
									}
									text = "飞机高度太低 (有效高度: " + Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin)) + "米(真高) minimum)";
									result = text;
									return result;
								}
							}
							else if (theWeapon.LaunchAltitudeMin_ASL > 0f && (double)this.ParentPlatform.GetCurrentAltitude_ASL(false) < (double)theWeapon.LaunchAltitudeMin_ASL - 0.1)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									if (value > 0)
									{
										if (theWeapon.LaunchAltitudeMax > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太低 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin_ASL * 3.28084f))),
												"英尺(海高) — ",
												Conversions.ToString((int)Math.Round((double)((theWeapon.LaunchAltitudeMax + (float)value) * 3.28084f))),
												"英尺(真高),地形海拔：",
												Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
												"英尺)"
											});
											result = text;
											return result;
										}
										if (theWeapon.LaunchAltitudeMax_ASL > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太低 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin_ASL * 3.28084f))),
												"英尺(海高) — ",
												Conversions.ToString((int)Math.Round((double)((theWeapon.LaunchAltitudeMax_ASL + (float)value) * 3.28084f))),
												"英尺(海高),地形海拔：",
												Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
												"英尺)"
											});
											result = text;
											return result;
										}
										text = string.Concat(new string[]
										{
											"飞机高度太低 (最小有效高度: ",
											Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin_ASL * 3.28084f))),
											"英尺(海高),地形海拔：",
											Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
											"英尺)"
										});
										result = text;
										return result;
									}
									else
									{
										if (theWeapon.LaunchAltitudeMax > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太低 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin_ASL * 3.28084f))),
												"英尺(海高) — ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax * 3.28084f))),
												"英尺(真高))"
											});
											result = text;
											return result;
										}
										if (theWeapon.LaunchAltitudeMax_ASL > 0f)
										{
											text = string.Concat(new string[]
											{
												"飞机高度太低 (有效高度: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin_ASL * 3.28084f))),
												"英尺(海高) —",
												Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax_ASL * 3.28084f))),
												"英尺(海高))"
											});
											result = text;
											return result;
										}
										text = "飞机高度太低 (最小有效高度: " + Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin_ASL * 3.28084f))) + "英尺(海高))";
										result = text;
										return result;
									}
								}
								else if (value > 0)
								{
									if (theWeapon.LaunchAltitudeMax > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太低 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin_ASL)),
											"米(海高) — ",
											Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax + (float)value))),
											"米(真高),地形海拔：",
											Conversions.ToString((int)value),
											"米)"
										});
										result = text;
										return result;
									}
									if (theWeapon.LaunchAltitudeMax_ASL > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太低 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin_ASL)),
											"米(海高) — ",
											Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax_ASL + (float)value))),
											"米(海高),地形海拔：",
											Conversions.ToString((int)value),
											"米)"
										});
										result = text;
										return result;
									}
									text = string.Concat(new string[]
									{
										"飞机高度太低 (最小有效高度: ",
										Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin_ASL)),
										"米(海高),地形海拔：",
										Conversions.ToString((int)value),
										"米)"
									});
									result = text;
									return result;
								}
								else
								{
									if (theWeapon.LaunchAltitudeMax > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太低 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin_ASL)),
											"米(海高) — ",
											Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax + (float)value))),
											"米(真高))"
										});
										result = text;
										return result;
									}
									if (theWeapon.LaunchAltitudeMax_ASL > 0f)
									{
										text = string.Concat(new string[]
										{
											"飞机高度太低 (有效高度: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin_ASL)),
											"米(海高) — ",
											Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax_ASL + (float)value))),
											"米(海高))"
										});
										result = text;
										return result;
									}
									text = "飞机高度太低 (最小有效高度: " + Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin_ASL)) + "米(海高))";
									result = text;
									return result;
								}
							}
						}
						if (this.ParentPlatform.IsSubmarine)
						{
							if (theWeapon.m_Scenario.FeatureCompatibility.get_WeaponAGL_ASL(theWeapon.m_Scenario.GetSQLiteConnection()) && theWeapon.LaunchAltitudeMin == 0f && theWeapon.LaunchAltitudeMax == 0f)
							{
								if ((double)this.ParentPlatform.GetCurrentAltitude_ASL(false) > (double)theWeapon.LaunchAltitudeMax_ASL + 0.1)
								{
									if (SimConfiguration.gameOptions.UseImperialUnit())
									{
										text = string.Concat(new string[]
										{
											"潜艇深度太浅不能发射 (有效潜深: ",
											Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin_ASL * 3.28084f))),
											" — ",
											Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax_ASL * 3.28084f))),
											"英尺)"
										});
										result = text;
										return result;
									}
									text = string.Concat(new string[]
									{
										"潜艇深度太浅不能发射 (有效潜深: ",
										Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin_ASL)),
										" — ",
										Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax_ASL)),
										"米)"
									});
									result = text;
									return result;
								}
								else if ((double)this.ParentPlatform.GetCurrentAltitude_ASL(false) < (double)theWeapon.LaunchAltitudeMin_ASL - 0.1)
								{
									if (SimConfiguration.gameOptions.UseImperialUnit())
									{
										text = string.Concat(new string[]
										{
											"潜艇深度太深不能发射 (有效潜深: ",
											Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin_ASL * 3.28084f))),
											" — ",
											Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax_ASL * 3.28084f))),
											"英尺)"
										});
										result = text;
										return result;
									}
									text = string.Concat(new string[]
									{
										"潜艇深度太深不能发射 (有效潜深: ",
										Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin_ASL)),
										" — ",
										Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax_ASL)),
										"米)"
									});
									result = text;
									return result;
								}
							}
							else if ((double)this.ParentPlatform.GetCurrentAltitude_ASL(false) > (double)theWeapon.LaunchAltitudeMax + 0.1)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									text = string.Concat(new string[]
									{
										"潜艇深度太浅不能发射 (有效潜深: ",
										Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin * 3.28084f))),
										" — ",
										Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax * 3.28084f))),
										"英尺)"
									});
									result = text;
									return result;
								}
								text = string.Concat(new string[]
								{
									"潜艇深度太浅不能发射 (有效潜深: ",
									Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin)),
									" — ",
									Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax)),
									"米)"
								});
								result = text;
								return result;
							}
							else if ((double)this.ParentPlatform.GetCurrentAltitude_ASL(false) < (double)theWeapon.LaunchAltitudeMin - 0.1)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									text = string.Concat(new string[]
									{
										"潜艇深度太深不能发射 (有效潜深: ",
										Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMin * 3.28084f))),
										" — ",
										Conversions.ToString((int)Math.Round((double)(theWeapon.LaunchAltitudeMax * 3.28084f))),
										"英尺)"
									});
									result = text;
									return result;
								}
								text = string.Concat(new string[]
								{
									"潜艇深度太深不能发射 (有效潜深: ",
									Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMin)),
									" — ",
									Conversions.ToString((int)Math.Round((double)theWeapon.LaunchAltitudeMax)),
									"米)"
								});
								result = text;
								return result;
							}
						}
						if (!IgnoreAircraftOrientation && this.ParentPlatform.IsAircraft && this.ParentPlatform.GetCurrentSpeed() > 0f)
						{
							bool flag2 = false;
							if (!Information.IsNothing(theMount))
							{
								flag2 = theMount.Trainable;
								if (!theMount.IsTargetInCoverageArc(theTarget, null))
								{
									text = "目标超出武器挂架火力覆盖范围(5海里之内)";
									result = text;
									return result;
								}
							}
							else if (!this.IsTargetWithinWeaponBoresightLimits(theWeapon, theTarget) && !flag2)
							{
								text = "目标超出武器瞄准线限制";
								result = text;
								return result;
							}
						}
						if (theTarget.contactType == Contact_Base.ContactType.Air)
						{
							if (theWeapon.weaponCode.AntiAir_SternChase)
							{
								float num5 = theWeapon.RelativeBearingTo(theTarget, true);
								if (Math.Abs(num5) < 130f)
								{
									text = "目标方位(" + Conversions.ToString(Math.Abs((int)Math.Round((double)num5))) + "度)不在尾追攻击武器的射击范围之内";
									result = text;
									return result;
								}
							}
							if (theWeapon.weaponCode.AntiAir_RearAspect)
							{
								float num6 = theWeapon.RelativeBearingTo(theTarget, true);
								if (Math.Abs(num6) < 100f)
								{
									text = "目标方位 (" + Conversions.ToString(Math.Abs((int)Math.Round((double)num6))) + "度)不在后向攻击武器的射击范围之内";
									result = text;
									return result;
								}
							}
						}
						if (this.ParentPlatform.IsAircraft)
						{
							float oODAReactionTime = this.ParentPlatform.GetAI().GetOODAReactionTime(theTarget);
							if (oODAReactionTime > 0f)
							{
								text = "武器在" + Conversions.ToString(Math.Round((double)oODAReactionTime, 1)) + "秒之内不能与目标交战(考虑OODA周期限制)";
								result = text;
								return result;
							}
						}
						else if (!Information.IsNothing(theMount) && !theMount.Autonomous)
						{
							float oODAReactionTime = this.ParentPlatform.GetAI().GetOODAReactionTime(theTarget);
							if (oODAReactionTime > 0f)
							{
								text = "武器在" + Conversions.ToString(Math.Round((double)oODAReactionTime, 1)) + "秒之内不能与目标交战(考虑OODA周期限制)";
								result = text;
								return result;
							}
						}
						if (!Information.IsNothing(theMount) && horizontalRange <= 5f && !theMount.IsTargetInCoverageArc(theTarget, null))
						{
							text = "目标超出武器挂架火力覆盖范围(5海里之内)";
							result = text;
							return result;
						}
						if (theTarget.contactType == Contact_Base.ContactType.ActivationPoint)
						{
							text = "OK";
							result = text;
							return result;
						}
						checked
						{
							if (Information.IsNothing(theTarget.ActualUnit))
							{
								if (!this.ParentPlatform.IsWeapon)
								{
									text = "目标消失";
									result = text;
									return result;
								}
								text = "OK";
								result = text;
								return result;
							}
							else
							{
								if (theTarget.ActualUnit.IsShip || theTarget.ActualUnit.IsSubmarine || theTarget.ActualUnit.IsFacility)
								{
									string text3 = this.method_21(theWeapon, theTarget);
									if (string.CompareOrdinal(text3, "OK") != 0)
									{
										text = text3;
										result = text;
										return result;
									}
								}
								Unit unit = theTarget;
								flag = null;
								double longitude3 = unit.GetLongitude(flag);
								Unit unit7 = theTarget;
								flag = null;
								if (ArcticSeaIce.IsNearMarginalIceZone(longitude3, unit7.GetLatitude(flag)))
								{
									if ((this.ParentPlatform.GetCurrentAltitude_ASL(false) > 0f && theTarget.ActualUnit.GetCurrentAltitude_ASL(false) < 0f) || (this.ParentPlatform.GetCurrentAltitude_ASL(false) < 0f && theTarget.ActualUnit.GetCurrentAltitude_ASL(false) > 0f))
									{
										text = "不能穿越冰层开火";
										result = text;
										return result;
									}
									if (this.ParentPlatform.GetCurrentAltitude_ASL(false) < 0f && theWeapon.IsGuidedWeapon_RV_HGV())
									{
										text = "不能在冰层之下发射导弹";
										result = text;
										return result;
									}
									if (this.ParentPlatform.GetCurrentAltitude_ASL(false) > 0f && theWeapon.IsTorpedo())
									{
										text = "不能在冰层内使用鱼雷";
										result = text;
										return result;
									}
								}
								if (theWeapon.GetWeaponType() == Weapon._WeaponType.Laser && !Information.IsNothing(theTarget.ActualUnit) && this.ParentPlatform.IsLOS_Exists_Visual(theTarget.ActualUnit, ref this.ParentPlatform.m_Scenario, true) != Unit._LOS_Exists_Visual.Yes)
								{
									text = "目标不在激光武器的视线之内";
									result = text;
									return result;
								}
								bool bool_ = false;
								if (this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.DetailedGunFireControl))
								{
									if (!this.ParentPlatform.IsAircraft && theWeapon.GetWeaponType() == Weapon._WeaponType.Gun && theTarget.contactType != Contact_Base.ContactType.Facility_Fixed && theTarget.contactType != Contact_Base.ContactType.Facility_Mobile && !Information.IsNothing(theMount) && !theMount.LocalControl)
									{
										if (this.method_27(theMount, theTarget).Count == 0)
										{
											text = "火炮没有本地控制，也没有可用的目标指示";
											result = text;
											return result;
										}
										bool_ = true;
									}
								}
								else
								{
									bool_ = true;
								}
								List<ActiveUnit> list = null;
								bool flag3 = false;
								if ((!theTarget.IsPreciselyLocatedNewTarget() & !theTarget.ActualUnit.IsAircraft) && !theWeapon.method_238(theTarget, bool_))
								{
									Sensor[] allNoneMCMSensors = this.ParentPlatform.GetAllNoneMCMSensors();
									for (int i = 0; i < allNoneMCMSensors.Length; i++)
									{
										Sensor sensor = allNoneMCMSensors[i];
										if (sensor.IsPreciselyLocatedEnable())
										{
											if (Information.IsNothing(list))
											{
												list = this.ParentPlatform.GetSensory().GetAffectingJammers(false);
											}
											float num7;
											if (theWeapon.GetWeaponType() == Weapon._WeaponType.Gun)
											{
												num7 = slantRange;
											}
											else
											{
												num7 = horizontalRange;
											}
											Sensor sensor2 = sensor;
											ActiveUnit parentPlatform7 = this.ParentPlatform;
											ActiveUnit actualUnit = theTarget.ActualUnit;
											List<GeoPoint> list2 = null;
											float slantRange2 = num7;
											Lazy<ObservableDictionary<int, EmissionContainer>> lazy = null;
											List<ActiveUnit> affectingJammers = list;
											flag = null;
											bool? flag4 = null;
											Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
											bool? flag5 = null;
											if (sensor2.SensorDetectionAttempt(Sensor.DetectionAttemptType.WeaponGuidance, parentPlatform7, actualUnit, ref list2, slantRange2, ref lazy, affectingJammers, ref flag, ref flag4, ref lOS_Exists_Visual, ref flag5))
											{
												if (theWeapon.GetWeaponType() == Weapon._WeaponType.Dispenser && unchecked(num7 * 1852f) > (float)theWeapon.m_Warheads[0].ClusterBombDispersionAreaLength)
												{
													text = "武器不能与超出武器射程的无精确位置信息的目标进行交战";
													result = text;
													return result;
												}
												if (theWeapon.IsTorpedo() && this.ParentPlatform.IsAircraft && theTarget.contactType == Contact_Base.ContactType.Submarine && (double)num7 > 0.4)
												{
													text = "武器不能与无精确位置信息的目标进行交战，这是由于反潜鱼雷必须在目标/瞄准点0.4海里之内投放";
													result = text;
													return result;
												}
												if (this.GetWeaponRange(ref this.ParentPlatform, ref theWeapon, ref theTarget, ManualFire) < num7)
												{
													text = "武器不能与超出武器射程的无精确位置信息的目标进行交战";
													result = text;
													return result;
												}
												if (theWeapon.TargetWithinRangeOfSuitableWeapon(num7, theTarget))
												{
													text = "武器不能与低于武器最小射程的无精确位置信息的目标进行交战";
													result = text;
													return result;
												}
												goto IL_30B3;
											}
										}
									}
									if (!flag3)
									{
										text = "武器不能与无精确位置信息的目标进行交战";
										result = text;
										return result;
									}
								}
								IL_30B3:
								Lazy<ObservableDictionary<int, EmissionContainer>> lazy2 = new Lazy<ObservableDictionary<int, EmissionContainer>>();
								if (theWeapon.GetGuidanceMethod() == Weapon._GuidanceMethod.PassiveTerminalGuidance && (!theWeapon.IsGuidedWeapon_RV_HGV() || theTarget.contactType != Contact_Base.ContactType.Air || !this.ParentPlatform.IsAircraft || !((Aircraft)this.ParentPlatform).HMD))
								{
									Sensor sensor3 = theWeapon.GetNoneMCMSensors()[0];
									ActiveUnit parentPlatform_ = theWeapon;
									ActiveUnit actualUnit2 = theTarget.ActualUnit;
									List<GeoPoint> list2 = null;
									float slantRange3 = horizontalRange;
									List<ActiveUnit> affectingJammers2 = null;
									bool? flag6 = null;
									bool? flag5 = null;
									bool? flag4 = null;
									Unit._LOS_Exists_Visual? lOS_Exists_Visual2 = null;
									flag = null;
									if (!sensor3.SensorDetectionAttempt(Sensor.DetectionAttemptType.WeaponGuidance, parentPlatform_, actualUnit2, ref list2, slantRange3, ref lazy2, affectingJammers2, ref flag6, ref flag5, ref lOS_Exists_Visual2, ref flag))
									{
										text = "武器在开火之前必须先发现目标";
										result = text;
										return result;
									}
								}
								CommDevice[] commDevices = theWeapon.GetCommDevices();
								if (commDevices.Count<CommDevice>() > 0 && !commDevices[0].IsOptional && Information.IsNothing(theWeapon.GetWeaponCommStuff().method_7(commDevices, this.ParentPlatform)))
								{
									text = "不能连接到与有数据链铰链的发射单元";
									result = text;
									return result;
								}
								if (theWeapon.weaponCode.IlluminateAtLaunch || theWeapon.weaponCode.TerminalIllumination)
								{
									bool flag7 = false;
									bool flag8 = false;
									bool flag9 = false;
									List<Sensor> list3 = new List<Sensor>();
									Sensor[] allNoneMCMSensors2 = this.ParentPlatform.GetAllNoneMCMSensors();
									for (int j = 0; j < allNoneMCMSensors2.Length; j++)
									{
										Sensor sensor4 = allNoneMCMSensors2[j];
										if (sensor4.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && sensor4.IsDirectorFor(ref theWeapon))
										{
											list3.Add(sensor4);
										}
									}
									if (list3.Count > 0)
									{
										flag7 = true;
										List<Sensor> list4 = new List<Sensor>();
										foreach (Sensor current2 in list3)
										{
											if (theWeapon.GetGuidanceMethod() == Weapon._GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance)
											{
												list4.Add(current2);
											}
											else if (current2.GetTargetsTrackedForFireControl().Count < current2.MaxIntercept || current2.IsTargetTracked(ref theTarget))
											{
												list4.Add(current2);
											}
										}
										if (list4.Count > 0)
										{
											flag8 = true;
											new List<Sensor>();
											Unit._LOS_Exists_Visual? lOS_Exists_Visual2 = null;
											bool? flag10 = null;
											bool? flag11 = null;
											bool? flag12 = null;
											bool? flag13 = null;
											foreach (Sensor current3 in list4)
											{
												if (current3.sensorType == Sensor.SensorType.Radar && Information.IsNothing(list))
												{
													list = this.ParentPlatform.GetSensory().GetAffectingJammers(false);
												}
												if (current3.WeaponGuidanceAttempt(this.ParentPlatform, ref theTarget, ref this.ParentPlatform.m_Scenario, horizontalRange, list, this.ParentPlatform.IsShip, false, ref flag11, ref flag12, ref lOS_Exists_Visual2, ref flag13) == Sensor._DetectionAttemptResult.Success)
												{
													SuitableDirectorSensor = current3;
													flag9 = true;
													break;
												}
											}
										}
									}
									ActiveUnit activeUnit = null;
									if ((!flag7 || !flag8 || !flag9) && theWeapon.weaponCode.SupportsBuddyIllumination)
									{
										activeUnit = theWeapon.GetIlluminatorOfTarget(this.ParentPlatform.GetSide(false), theTarget);
										if (!Information.IsNothing(activeUnit))
										{
											ActiveUnit_Sensory sensory = activeUnit.GetSensory();
											Contact target_ = theTarget;
											Weapon weapon_ = theWeapon;
											flag = null;
											bool? flag4 = null;
											Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
											bool? flag6 = null;
											Sensor sensor5 = null;
											if (sensory.IsIlluminating(target_, weapon_, ref sensor5, ref flag, ref flag4, ref lOS_Exists_Visual, ref flag6))
											{
												SuitableDirectorSensor = sensor5;
											}
										}
									}
									if (Information.IsNothing(activeUnit))
									{
										if (!flag7)
										{
											text = "无可用武器目标指示器对目标进行照射";
											result = text;
											return result;
										}
										if (!flag8)
										{
											text = "所有适合本武器的照射通道均被占用";
											result = text;
											return result;
										}
										if (!flag9)
										{
											text = "无可对目标进行照射的目标指示器(反射不足，或者不在视线之内)";
											result = text;
											return result;
										}
									}
								}
								if (theWeapon.GetGuidanceMethod() == Weapon._GuidanceMethod.BeamRiding)
								{
									bool flag14 = false;
									bool flag15 = false;
									Sensor[] noneMCMSensors = this.ParentPlatform.GetNoneMCMSensors();
									for (int k = 0; k < noneMCMSensors.Length; k++)
									{
										Sensor sensor6 = noneMCMSensors[k];
										if (sensor6.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && sensor6.IsDirectorFor(ref theWeapon))
										{
											flag14 = true;
											if (sensor6.GetTargetsTrackedForFireControl().Count < sensor6.MaxIntercept || sensor6.IsTargetTracked(ref theTarget))
											{
												SuitableDirectorSensor = sensor6;
												flag15 = true;
											}
										}
									}
									if (!flag14)
									{
										text = "无可用武器目标指示器对目标进行照射";
										result = text;
										return result;
									}
									if (!flag15)
									{
										text = "所有适合本武器的照射通道均被占用";
										result = text;
										return result;
									}
								}
								if (this.method_28(theWeapon, theTarget))
								{
									Tuple<int, string> key = new Tuple<int, string>(theWeapon.DBID, theTarget.GetGuid());
									this.hashSet_0.Add(Conversions.ToString(theWeapon.DBID) + "_" + theTarget.GetGuid());
									if (this.lazy_0.Value.ContainsKey(key))
									{
										if (Operators.CompareString(this.lazy_0.Value[key], "OK", false) != 0)
										{
											text = this.lazy_0.Value[key];
											result = text;
											return result;
										}
									}
									else
									{
										string text4 = this.method_25(theTarget, theWeapon);
										this.lazy_0.Value.TryAdd(key, text4);
										if (Operators.CompareString(text4, "OK", false) != 0)
										{
											text = text4;
											result = text;
											return result;
										}
									}
								}
								if (theWeapon.weaponTarget.IsRadar)
								{
									if (!theTarget.HasEmissionContainer())
									{
										text = "目标没有发出电磁辐射";
										result = text;
										return result;
									}
									Weapon weapon5 = theWeapon;
									ObservableDictionary<int, EmissionContainer> emissionContainerObDictionary = theTarget.GetEmissionContainerObDictionary();
									Side side = this.ParentPlatform.GetSide(false);
									Contact contact_ = theTarget;
									Random random = GameGeneral.GetRandom();
									if (!weapon5.HasARM_SpecifiedEmission(emissionContainerObDictionary, side, contact_, false, ref random))
									{
										text = "没有正在发射的威胁辐射源";
										result = text;
										return result;
									}
								}
								text = "OK";
								result = text;
								return result;
							}
						}
					}
				}
				else
				{
					text = "武器为诱饵装置，将自动部署";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101240", "");
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

		// Token: 0x06004166 RID: 16742 RVA: 0x0016E72C File Offset: 0x0016C92C
		public string method_25(Contact theTarget, Weapon theWeapon)
		{
			string result;
			if (Information.IsNothing(theTarget))
			{
				result = "目标没有定义";
			}
			else
			{
				float initialHeading;
				if (this.ParentPlatform.IsAircraft)
				{
					initialHeading = this.ParentPlatform.GetCurrentHeading();
				}
				else
				{
					initialHeading = 0f;
				}
				GeoPoint geoPoint = null;
				theWeapon.SetFiringParent(this.ParentPlatform);
				Weapon.smethod_6(theWeapon, this.ParentPlatform.m_Scenario);
				string text;
				if (theTarget.IsBallisticMissileOrReEntryVehicles())
				{
					text = this.method_51(this.ParentPlatform.m_Scenario, theWeapon.DBID, this.ParentPlatform, this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null), (float)((int)Math.Round((double)this.ParentPlatform.GetCurrentAltitude_ASL(false))), (int)Math.Round((double)this.ParentPlatform.GetCurrentSpeed()), theTarget, initialHeading, ActiveUnit.Throttle.Cruise);
				}
				else
				{
					Scenario scenario = this.ParentPlatform.m_Scenario;
					int dBID = theWeapon.DBID;
					ActiveUnit parentPlatform = this.ParentPlatform;
					double longitude = this.ParentPlatform.GetLongitude(null);
					double latitude = this.ParentPlatform.GetLatitude(null);
					float launchAltitude = (float)((int)Math.Round((double)this.ParentPlatform.GetCurrentAltitude_ASL(false)));
					int launchSpeed = (int)Math.Round((double)this.ParentPlatform.GetCurrentSpeed());
					double longitude2 = theTarget.GetLongitude(null);
					double latitude2 = theTarget.GetLatitude(null);
					float currentHeading = theTarget.GetCurrentHeading();
					bool heading_Known = theTarget.Heading_Known;
					int targetSpeed = (int)Math.Round((double)theTarget.GetCurrentSpeed());
					bool speed_Known = theTarget.Speed_Known;
					float currentAltitude_ASL = theTarget.GetCurrentAltitude_ASL(false);
					bool altitude_Known = theTarget.Altitude_Known;
					string text2 = null;
					text = ActiveUnit_Weaponry.smethod_3(scenario, dBID, parentPlatform, longitude, latitude, launchAltitude, launchSpeed, longitude2, latitude2, currentHeading, heading_Known, targetSpeed, speed_Known, currentAltitude_ASL, altitude_Known, ref geoPoint, ref text2, initialHeading, ActiveUnit.Throttle.Full, (int)Math.Round((double)((float)theWeapon.GetFuelRecs()[0].MaxQuantity) * 0.89999999850988388), null, null);
				}
				result = text;
			}
			return result;
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x0016E948 File Offset: 0x0016CB48
		public string method_26(Weapon weapon_, Contact target_)
		{
			string text = "";
			string result;
			try
			{
				if (Information.IsNothing(target_))
				{
					text = "目标为空";
				}
				else
				{
					if (weapon_.IsGuidedWeapon_RV_HGV() && weapon_.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
					{
						Contact_Base.ContactType contactType = target_.contactType;
						if ((contactType == Contact_Base.ContactType.Surface || contactType - Contact_Base.ContactType.Facility_Fixed <= 1) && this.ParentPlatform.m_Doctrine.GetUseSAMsInASuWModeDoctrine(this.ParentPlatform.m_Scenario, false, false, false).Value != Doctrine._UseSAMsInASuWMode.const_1)
						{
							text = "没有授权该单元使用舰空导弹打击水面目标";
							result = text;
							return result;
						}
					}
					if (weapon_.TargetSpeedMax > 0 && target_.GetCurrentSpeed() > (float)weapon_.TargetSpeedMax * 1.2f)
					{
						text = string.Concat(new string[]
						{
							"目标速度 (",
							Conversions.ToString((int)Math.Round((double)target_.GetCurrentSpeed())),
							"节)远超过武器的最大目标速度(",
							Conversions.ToString(weapon_.TargetSpeedMax),
							"节)"
						});
					}
					else
					{
						if (!target_.IsBallisticMissileOrReEntryVehicles() && target_.contactType != Contact_Base.ContactType.Surface)
						{
							if (weapon_.TargetAltitudeMax > 0f && target_.GetCurrentAltitude_ASL(false) > weapon_.TargetAltitudeMax)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									text = string.Concat(new string[]
									{
										"目标高度 (",
										Conversions.ToString((int)Math.Round((double)(target_.GetCurrentAltitude_ASL(false) * 3.28084f))),
										"英尺)超过武器的最大高度 (",
										Conversions.ToString((int)Math.Round((double)(weapon_.TargetAltitudeMax * 3.28084f))),
										"英尺)"
									});
									result = text;
									return result;
								}
								text = string.Concat(new string[]
								{
									"目标高度 (",
									Conversions.ToString((int)Math.Round((double)target_.GetCurrentAltitude_ASL(false))),
									"米)超过武器的最大高度 (",
									Conversions.ToString(weapon_.TargetAltitudeMax),
									"米)"
								});
								result = text;
								return result;
							}
							else if (weapon_.TargetAltitudeMin > 0f && target_.GetCurrentAltitude_ASL(false) < weapon_.TargetAltitudeMin)
							{
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									text = string.Concat(new string[]
									{
										"目标高度 (",
										Conversions.ToString((int)Math.Round((double)(target_.GetCurrentAltitude_ASL(false) * 3.28084f))),
										"英尺) 低于武器最小作战高度(",
										Conversions.ToString((int)Math.Round((double)(weapon_.TargetAltitudeMin * 3.28084f))),
										"英尺)"
									});
									result = text;
									return result;
								}
								text = string.Concat(new string[]
								{
									"目标高度 (",
									Conversions.ToString((int)Math.Round((double)target_.GetCurrentAltitude_ASL(false))),
									"米)低于武器最小作战高度(",
									Conversions.ToString(weapon_.TargetAltitudeMin),
									"米)"
								});
								result = text;
								return result;
							}
						}
						if (target_.contactType == Contact_Base.ContactType.ActivationPoint && !weapon_.weaponCode.BOLCapable)
						{
							text = "武器不支持纯方位攻击";
						}
						else if (!weapon_.HasNuclearWarhead() && target_.contactType == Contact_Base.ContactType.Submarine && (weapon_.GetWeaponType() == Weapon._WeaponType.DepthCharge || weapon_.GetWeaponType() == Weapon._WeaponType.Rocket) && !Information.IsNothing(target_.GetUncertaintyArea()))
						{
							text = "武器需要目标的精确位置信息";
						}
						else if (!weapon_.IsSuitableForTarget(this.ParentPlatform.m_Scenario, ref target_))
						{
							text = "武器与目标不匹配";
						}
						else
						{
							float num = 0f;
							if (weapon_.GetWeaponType() == Weapon._WeaponType.Gun)
							{
								num = this.ParentPlatform.GetSlantRange(target_, 0f);
							}
							else
							{
								num = this.ParentPlatform.GetHorizontalRange(target_);
							}
							if (weapon_.GetWeaponType() == Weapon._WeaponType.Dispenser && (double)(num * 1852f) > (double)weapon_.m_Warheads[0].ClusterBombDispersionAreaLength / 2.0)
							{
								text = "目标超出武器射程";
							}
							else
							{
								float num2;
								if (weapon_.IsGuidedWeapon_RV_HGV() && this.method_28(weapon_, target_) && target_.GetCurrentSpeed() != 0f)
								{
									if (target_.contactType == Contact_Base.ContactType.Surface)
									{
										num2 = weapon_.GetMaxRangeToTarget(this.ParentPlatform, target_, false, null, false);
									}
									else
									{
										num2 = (float)((double)weapon_.GetMaxRangeToTarget(this.ParentPlatform, target_, false, null, false) * 1.5);
									}
								}
								else
								{
									num2 = weapon_.GetMaxRangeToTarget(this.ParentPlatform, target_, false, null, false);
								}
								if (num2 < num)
								{
									text = "目标超出武器射程";
								}
								else if (target_.contactType == Contact_Base.ContactType.ActivationPoint)
								{
									text = "OK";
								}
								else if (Information.IsNothing(target_.ActualUnit))
								{
									text = "作战单元消失";
								}
								else
								{
									if (target_.ActualUnit.IsShip || target_.ActualUnit.IsFacility || target_.ActualUnit.IsSubmarine)
									{
										string text2 = this.method_21(weapon_, target_);
										if (string.CompareOrdinal(text2, "OK") != 0)
										{
											text = text2;
											result = text;
											return result;
										}
									}
									if (!target_.IsPreciselyLocatedNewTarget() && !weapon_.method_238(target_, false))
									{
										text = "武器不能与无精确位置信息的目标交战";
									}
									else
									{
										Lazy<ObservableDictionary<int, EmissionContainer>> lazy = new Lazy<ObservableDictionary<int, EmissionContainer>>();
										if (weapon_.GetGuidanceMethod() == Weapon._GuidanceMethod.PassiveTerminalGuidance)
										{
											Sensor sensor = weapon_.GetNoneMCMSensors()[0];
											ActiveUnit parentPlatform_ = weapon_;
											ActiveUnit actualUnit = target_.ActualUnit;
											List<GeoPoint> list = null;
											float slantRange = num;
											List<ActiveUnit> affectingJammers = null;
											bool? hintIsOperating = null;
											bool? flag = null;
											Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
											bool? flag2 = null;
											if (!sensor.SensorDetectionAttempt(Sensor.DetectionAttemptType.WeaponGuidance, parentPlatform_, actualUnit, ref list, slantRange, ref lazy, affectingJammers, ref hintIsOperating, ref flag, ref lOS_Exists_Visual, ref flag2))
											{
												text = "武器开火之前必须先发现目标";
												result = text;
												return result;
											}
										}
										GeoPoint geoPoint = null;
										float initialHeading;
										checked
										{
											if (weapon_.weaponCode.IlluminateAtLaunch || weapon_.weaponCode.TerminalIllumination)
											{
												bool flag3 = false;
												bool flag4 = false;
												bool flag5 = false;
												List<Sensor> list2 = new List<Sensor>();
												Sensor[] noneMCMSensors = this.ParentPlatform.GetNoneMCMSensors();
												for (int i = 0; i < noneMCMSensors.Length; i++)
												{
													Sensor sensor2 = noneMCMSensors[i];
													if (sensor2.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && sensor2.IsDirectorFor(ref weapon_))
													{
														list2.Add(sensor2);
													}
												}
												if (list2.Count > 0)
												{
													flag3 = true;
													List<Sensor> list3 = new List<Sensor>();
													foreach (Sensor current in list2)
													{
														if (weapon_.GetGuidanceMethod() == Weapon._GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance)
														{
															list3.Add(current);
														}
														else if (current.GetTargetsTrackedForFireControl().Count < current.MaxIntercept || current.IsTargetTracked(ref target_))
														{
															list3.Add(current);
														}
													}
													if (list3.Count > 0)
													{
														flag4 = true;
														new List<Sensor>();
														Unit._LOS_Exists_Visual? lOS_Exists_Visual2 = null;
														bool? flag6 = null;
														bool? flag7 = null;
														bool? flag8 = null;
														foreach (Sensor current2 in list3)
														{
															List<ActiveUnit> list4 = null;
															if (current2.sensorType == Sensor.SensorType.Radar && Information.IsNothing(list4))
															{
																list4 = this.ParentPlatform.GetSensory().GetAffectingJammers(false);
															}
															if (current2.WeaponGuidanceAttempt(this.ParentPlatform, ref target_, ref this.ParentPlatform.m_Scenario, num, list4, this.ParentPlatform.IsShip, false, ref flag6, ref flag7, ref lOS_Exists_Visual2, ref flag8) == Sensor._DetectionAttemptResult.Success)
															{
																flag5 = true;
																break;
															}
														}
													}
												}
												ActiveUnit activeUnit = null;
												if ((!flag3 || !flag4 || !flag5) && weapon_.weaponCode.SupportsBuddyIllumination)
												{
													activeUnit = weapon_.GetIlluminatorOfTarget(this.ParentPlatform.GetSide(false), target_);
													if (!Information.IsNothing(activeUnit))
													{
														ActiveUnit_Sensory sensory = activeUnit.GetSensory();
														Contact target_2 = target_;
														Weapon weapon_2 = weapon_;
														bool? flag2 = null;
														Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
														bool? flag9 = null;
														bool? hintIsOperating = null;
														Sensor sensor3 = null;
														sensory.IsIlluminating(target_2, weapon_2, ref sensor3, ref flag2, ref flag9, ref lOS_Exists_Visual, ref hintIsOperating);
													}
												}
												if (Information.IsNothing(activeUnit))
												{
													if (!flag3)
													{
														text = "没有可以照射目标的武器指示器";
														result = text;
														return result;
													}
													if (!flag4)
													{
														text = "所有适合本武器的照射通道均被占用";
														result = text;
														return result;
													}
													if (!flag5)
													{
														text = "所有指示器均不能照射目标(反射不足，不在视线之内等)";
														result = text;
														return result;
													}
												}
											}
											if (weapon_.GetGuidanceMethod() == Weapon._GuidanceMethod.BeamRiding)
											{
												bool flag10 = false;
												bool flag11 = false;
												Sensor[] noneMCMSensors2 = this.ParentPlatform.GetNoneMCMSensors();
												for (int j = 0; j < noneMCMSensors2.Length; j++)
												{
													Sensor sensor4 = noneMCMSensors2[j];
													if (sensor4.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && sensor4.IsDirectorFor(ref weapon_))
													{
														flag10 = true;
														if (sensor4.GetTargetsTrackedForFireControl().Count < sensor4.MaxIntercept || sensor4.IsTargetTracked(ref target_))
														{
															flag11 = true;
														}
													}
												}
												if (!flag10)
												{
													text = "没有可以照射目标的武器指示器";
													result = text;
													return result;
												}
												if (!flag11)
												{
													text = "所有适合本武器的照射通道均被占用";
													result = text;
													return result;
												}
											}
											if (this.ParentPlatform.IsAircraft)
											{
												initialHeading = this.ParentPlatform.GetCurrentHeading();
											}
											else
											{
												initialHeading = 0f;
											}
											geoPoint = null;
										}
										if (this.method_28(weapon_, target_))
										{
											Tuple<int, string> key = new Tuple<int, string>(weapon_.DBID, target_.GetGuid());
											if (this.lazy_0.Value.ContainsKey(key))
											{
												if (Operators.CompareString(this.lazy_0.Value[key], "OK", false) != 0)
												{
													text = this.lazy_0.Value[key];
													result = text;
													return result;
												}
											}
											else
											{
												string text3;
												if (target_.IsBallisticMissileOrReEntryVehicles())
												{
													Scenario scenario = this.ParentPlatform.m_Scenario;
													int dBID = weapon_.DBID;
													ActiveUnit parentPlatform = this.ParentPlatform;
													ActiveUnit parentPlatform2 = this.ParentPlatform;
													bool? hintIsOperating = null;
													double longitude = parentPlatform2.GetLongitude(hintIsOperating);
													ActiveUnit parentPlatform3 = this.ParentPlatform;
													hintIsOperating = null;
													text3 = this.method_51(scenario, dBID, parentPlatform, longitude, parentPlatform3.GetLatitude(hintIsOperating), (float)((int)Math.Round((double)this.ParentPlatform.GetCurrentAltitude_ASL(false))), (int)Math.Round((double)this.ParentPlatform.GetCurrentSpeed()), target_, initialHeading, ActiveUnit.Throttle.Cruise);
												}
												else
												{
													Scenario scenario2 = this.ParentPlatform.m_Scenario;
													int dBID2 = weapon_.DBID;
													ActiveUnit parentPlatform4 = this.ParentPlatform;
													ActiveUnit parentPlatform5 = this.ParentPlatform;
													bool? hintIsOperating = null;
													double longitude2 = parentPlatform5.GetLongitude(hintIsOperating);
													ActiveUnit parentPlatform6 = this.ParentPlatform;
													hintIsOperating = null;
													double latitude = parentPlatform6.GetLatitude(hintIsOperating);
													float launchAltitude = (float)((int)Math.Round((double)this.ParentPlatform.GetCurrentAltitude_ASL(false)));
													int launchSpeed = (int)Math.Round((double)this.ParentPlatform.GetCurrentSpeed());
													Unit unit = target_;
													hintIsOperating = null;
													double longitude3 = unit.GetLongitude(hintIsOperating);
													Unit unit2 = target_;
													hintIsOperating = null;
													double latitude2 = unit2.GetLatitude(hintIsOperating);
													float currentHeading = target_.GetCurrentHeading();
													bool heading_Known = target_.Heading_Known;
													int targetSpeed = (int)Math.Round((double)target_.GetCurrentSpeed());
													bool speed_Known = target_.Speed_Known;
													float currentAltitude_ASL = target_.GetCurrentAltitude_ASL(false);
													bool altitude_Known = target_.Altitude_Known;
													string text4 = null;
													text3 = ActiveUnit_Weaponry.smethod_3(scenario2, dBID2, parentPlatform4, longitude2, latitude, launchAltitude, launchSpeed, longitude3, latitude2, currentHeading, heading_Known, targetSpeed, speed_Known, currentAltitude_ASL, altitude_Known, ref geoPoint, ref text4, initialHeading, ActiveUnit.Throttle.Cruise, (int)Math.Round((double)((float)weapon_.GetFuelRecs()[0].MaxQuantity) * 0.89999999850988388), null, null);
												}
												this.lazy_0.Value.TryAdd(key, text3);
												if (Operators.CompareString(text3, "OK", false) != 0)
												{
													text = text3;
													result = text;
													return result;
												}
											}
										}
										if (weapon_.weaponTarget.IsRadar)
										{
											if (!target_.HasEmissionContainer())
											{
												text = "目标没有发出电磁辐射";
												result = text;
												return result;
											}
											Weapon weapon = weapon_;
											ObservableDictionary<int, EmissionContainer> emissionContainerObDictionary = target_.GetEmissionContainerObDictionary();
											Side side = this.ParentPlatform.GetSide(false);
											Contact contact_ = target_;
											Random random = GameGeneral.GetRandom();
											if (!weapon.HasARM_SpecifiedEmission(emissionContainerObDictionary, side, contact_, false, ref random))
											{
												text = "无正在发射的威胁辐射源";
												result = text;
												return result;
											}
										}
										text = "OK";
									}
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
				ex2.Data.Add("Error at 100307", "");
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

		// Token: 0x06004168 RID: 16744 RVA: 0x0016F61C File Offset: 0x0016D81C
		private List<Sensor> method_27(Mount mount_0, Contact contact_0)
		{
			List<Sensor> list = new List<Sensor>();
			Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
			bool? flag = null;
			bool? flag2 = null;
			bool? flag3 = null;
			bool? flag4 = null;
			List<Sensor> result = null;
			checked
			{
				try
				{
					List<ActiveUnit> list2 = null;
					Sensor[] noneMCMSensors = this.ParentPlatform.GetNoneMCMSensors();
					for (int i = 0; i < noneMCMSensors.Length; i++)
					{
						Sensor sensor = noneMCMSensors[i];
						if (sensor.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && mount_0.MountDirectorSet.Contains(sensor.DBID) && (sensor.IsFireChannelsEnough() || sensor.GetTargetsTrackedForFireControl().Contains(contact_0)))
						{
							if (sensor.sensorType == Sensor.SensorType.Radar && Information.IsNothing(list2))
							{
								list2 = this.ParentPlatform.GetSensory().GetAffectingJammers(false);
							}
							Sensor sensor2 = sensor;
							ActiveUnit parentPlatform = this.ParentPlatform;
							ActiveUnit actualUnit = contact_0.ActualUnit;
							List<GeoPoint> list3 = null;
							float horizontalRange = this.ParentPlatform.GetHorizontalRange(contact_0);
							Lazy<ObservableDictionary<int, EmissionContainer>> lazy = null;
							if (sensor2.SensorDetectionAttempt(Sensor.DetectionAttemptType.WeaponGuidance, parentPlatform, actualUnit, ref list3, horizontalRange, ref lazy, list2, ref flag2, ref flag3, ref lOS_Exists_Visual, ref flag4))
							{
								list.Add(sensor);
							}
						}
					}
					result = list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100308", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x0016F7AC File Offset: 0x0016D9AC
		private bool method_28(Weapon theWeapon, Contact theTarget)
		{
			bool flag = false;
			bool result;
			try
			{
				Weapon._WeaponType weaponType = theWeapon.GetWeaponType();
				if (weaponType != Weapon._WeaponType.GuidedWeapon)
				{
					flag = (weaponType == Weapon._WeaponType.Torpedo);
				}
				else if (theWeapon.method_135())
				{
					flag = false;
				}
				else
				{
					Contact_Base.ContactType contactType = theTarget.contactType;
					if (contactType > Contact_Base.ContactType.Missile && contactType != Contact_Base.ContactType.Orbital)
					{
						if (this.ParentPlatform.IsAircraft)
						{
							flag = true;
							result = true;
							return result;
						}
						if (theWeapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
						{
							Contact_Base.ContactType contactType2 = theTarget.contactType;
							if (contactType2 == Contact_Base.ContactType.Surface || contactType2 - Contact_Base.ContactType.Facility_Fixed <= 1)
							{
								flag = true;
								result = true;
								return result;
							}
						}
						flag = false;
						result = false;
						return result;
					}
					else
					{
						flag = true;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100309", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x0016F8A4 File Offset: 0x0016DAA4
		public void AttackTarget(float elapsedTime_, ref Weapon weapon_)
		{
			int num = 0;
			int num2 = 0;
			checked
			{
				try
				{
					if (weapon_.GetNoneMCMSensors().Length > 0)
					{
						Sensor[] noneMCMSensors = weapon_.GetNoneMCMSensors();
						for (int i = 0; i < noneMCMSensors.Length; i++)
						{
							Sensor sensor = noneMCMSensors[i];
							unchecked
							{
								if (sensor.sensorType == Sensor.SensorType.ESM)
								{
									if (weapon_.weaponTarget.IsRadar)
									{
										num2++;
										i++;
										continue;
									}
								}
								else if (sensor.sensorType != Sensor.SensorType.ECM && sensor.IsTargetDetectableByMe(this.ParentPlatform))
								{
									num2++;
									i++;
									continue;
								}
							}
						}
					}
					bool arg_CA_0;
					if (weapon_.GetNoneMCMSensors().Length <= 0)
					{
						if (weapon_.GetGuidanceMethod() != Weapon._GuidanceMethod.TrackViaMissile)
						{
							arg_CA_0 = true;
							goto IL_CA;
						}
					}
					arg_CA_0 = !weapon_.GetWeaponAI().GetPrimaryTarget().ActualUnit.GetSide(false).ActiveUnitIsContact(weapon_);
					IL_CA:
					if (!arg_CA_0)
					{
						List<ActiveUnit_Weaponry.FireQueueEntry> list = new List<ActiveUnit_Weaponry.FireQueueEntry>();
						Mount[] mounts = this.ParentPlatform.m_Mounts;
						for (int j = 0; j < mounts.Length; j++)
						{
							Mount mount = mounts[j];
							if (mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && mount.GetTimeToFire() <= 1f)
							{
                                WeaponRec weaponRecX;
                                foreach (WeaponRec weaponRec in mount.GetWeaponRecCollection())
								{
									if (weaponRec.GetCurrentLoad() > 0)
									{
										weaponRec.myMount = mount;
										if (this.method_30(weaponRec, mount, weapon_))
										{
											ActiveUnit parentPlatform = this.ParentPlatform;
											ActiveUnit activeUnit = weapon_;
                                            weaponRecX = weaponRec;
                                            ActiveUnit_Weaponry.FireQueueEntry item = new ActiveUnit_Weaponry.FireQueueEntry(ref elapsedTime_, parentPlatform, ref weaponRecX, ref activeUnit, ref mount);
											list.Add(item);
										}
									}
								}
							}
						}
						if (this.ParentPlatform.IsAircraft && !Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
						{
							WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
							for (int k = 0; k < weaponRecArray.Length; k++)
							{
								WeaponRec weaponRec = weaponRecArray[k];
								if (weaponRec.GetCurrentLoad() > 0)
								{
									Weapon weapon = weaponRec.GetWeapon(this.ParentPlatform.m_Scenario);
									if (weapon.IsSensorPod())
									{
										using (IEnumerator<WeaponRec> enumerator2 = weapon.GetWeaponRecCollection().GetEnumerator())
										{
											while (enumerator2.MoveNext())
											{
												WeaponRec current = enumerator2.Current;
												if (current.GetCurrentLoad() > 0 && this.method_31(current, weapon_))
												{
													ActiveUnit parentPlatform = this.ParentPlatform;
													ActiveUnit activeUnit = weapon_;
													Mount mount2 = null;
													ActiveUnit_Weaponry.FireQueueEntry item2 = new ActiveUnit_Weaponry.FireQueueEntry(ref elapsedTime_, parentPlatform, ref current, ref activeUnit, ref mount2);
													list.Add(item2);
												}
											}
											goto IL_2DA;
										}
									}
									if (this.method_31(weaponRec, weapon_))
									{
										ActiveUnit parentPlatform2 = this.ParentPlatform;
										ActiveUnit activeUnit = weapon_;
										Mount mount2 = null;
										ActiveUnit_Weaponry.FireQueueEntry item3 = new ActiveUnit_Weaponry.FireQueueEntry(ref elapsedTime_, parentPlatform2, ref weaponRec, ref activeUnit, ref mount2);
										list.Add(item3);
									}
								}
								IL_2DA:;
							}
						}
						if (list.Count > 0)
						{
							IEnumerable<ActiveUnit_Weaponry.FireQueueEntry> enumerable = list.Select(ActiveUnit_Weaponry.FireQueueEntryFunc6).OrderByDescending(new Func<ActiveUnit_Weaponry.FireQueueEntry, float>(this.method_59));
							foreach (ActiveUnit_Weaponry.FireQueueEntry current2 in enumerable)
							{
								this.method_40(current2.float_0, ref current2.activeUnit_0, ref current2.weaponRec_0, ref current2.activeUnit_1, true, 0f, ActiveUnit.Throttle.Flank, current2.mount_0);
								if (!Information.IsNothing(current2.mount_0))
								{
									if (current2.weaponRec_0.GetCurrentLoad() == 0)
									{
										Mount mount_ = current2.mount_0;
										int l = 0;
										int m = 0;
										if (mount_.method_35(ref l, ref m) == 0)
										{
											current2.mount_0.method_31(0f);
											continue;
										}
									}
									if (current2.mount_0.method_30() < 300f)
									{
										current2.mount_0.method_31(unchecked(current2.mount_0.GetTimeToFire() + 300f));
									}
								}
							}
						}
					}
					Sensor sensor2 = null;
					if (weapon_.GetNoneMCMSensors().Length > 0)
					{
						Sensor[] noneMCMSensors2 = weapon_.GetNoneMCMSensors();
						int m = 0;
						while (m < noneMCMSensors2.Length)
						{
							Sensor sensor3 = noneMCMSensors2[m];
							if (sensor3.sensorType == Sensor.SensorType.ESM)
							{
								if (weapon_.weaponTarget.IsRadar)
								{
									goto IL_485;
								}
							}
							else if (sensor3.sensorType != Sensor.SensorType.ECM && sensor3.IsTargetDetectableByMe(this.ParentPlatform))
							{
								goto IL_485;
							}
							IL_49E:
							m++;
							continue;
							IL_485:
							unchecked
							{
								if (sensor3.IsSpoofed().GetValueOrDefault())
								{
									num++;
									goto IL_49E;
								}
								goto IL_49E;
							}
						}
						if (num >= num2 && num2 > 0)
						{
							this.ParentPlatform.m_Scenario.LogMessage("所有武器导引头已被干扰——武器脱靶", LoggedMessage.MessageType.WeaponEndgame, 1, this.ParentPlatform.GetGuid(), null, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
							weapon_.m_Scenario.RemoveUnit(weapon_);
						}
					}
					else if (weapon_.GetGuidanceMethod() == Weapon._GuidanceMethod.TrackViaMissile)
					{
						sensor2 = weapon_.GetDirector();
						if (Information.IsNothing(sensor2))
						{
							this.ParentPlatform.m_Scenario.LogMessage(string.Concat(new string[]
							{
								"没有制导雷达服务于武器: ",
								weapon_.Name,
								" (",
								weapon_.UnitClass,
								") - 不能命中目标"
							}), LoggedMessage.MessageType.WeaponEndgame, 1, this.ParentPlatform.GetGuid(), null, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
						}
						else if (sensor2.IsSpoofed().GetValueOrDefault())
						{
							this.ParentPlatform.m_Scenario.LogMessage("TVM/SAGG武器的制导雷达被干扰，不能命中目标", LoggedMessage.MessageType.WeaponEndgame, 1, this.ParentPlatform.GetGuid(), null, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
							weapon_.m_Scenario.RemoveUnit(weapon_);
						}
					}
					if (!this.ParentPlatform.m_Scenario.GetUnitRemovals().Contains(weapon_))
					{
						if (weapon_.GetNoneMCMSensors().Length > 0)
						{
							Sensor[] noneMCMSensors3 = weapon_.GetNoneMCMSensors();
							for (int l = 0; l < noneMCMSensors3.Length; l++)
							{
								Sensor sensor4 = noneMCMSensors3[l];
								if (!sensor4.IsSpoofed().GetValueOrDefault())
								{
									if (sensor4.sensorType == Sensor.SensorType.ESM)
									{
										if (!weapon_.weaponTarget.IsRadar)
										{
											goto IL_75F;
										}
									}
									else if (sensor4.sensorType == Sensor.SensorType.ECM || !sensor4.IsTargetDetectableByMe(this.ParentPlatform))
									{
										goto IL_75F;
									}
									Sensor[] noneMCMSensors4 = this.ParentPlatform.GetNoneMCMSensors();
									int n = 0;
									while (n < noneMCMSensors4.Length)
									{
										Sensor sensor5 = noneMCMSensors4[n];
										if (!sensor5.IsECMOrIRCM() || !sensor5.IsJammerFor(sensor4))
										{
											n++;
										}
										else
										{
											unchecked
											{
												if (sensor5.IsSensorSpoofed(ref sensor4, ref this.ParentPlatform))
												{
													num++;
													sensor4.SetIsSpoofed(new bool?(true));
													break;
												}
												break;
											}
										}
									}
								}
								IL_75F:;
							}
						}
						else if (weapon_.GetGuidanceMethod() == Weapon._GuidanceMethod.TrackViaMissile)
						{
							bool? flag;
							bool? flag3;
							if (Information.IsNothing(sensor2))
							{
								flag = new bool?(false);
							}
							else
							{
								bool? flag2 = sensor2.IsSpoofed();
								flag2 = (flag3 = (flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2));
								flag = ((!flag2.HasValue || !flag3.GetValueOrDefault()) ? (flag3 | Information.IsNothing(sensor2.IsSpoofed())) : new bool?(true));
							}
							flag3 = flag;
							if (flag3.GetValueOrDefault())
							{
								Sensor[] noneMCMSensors5 = this.ParentPlatform.GetNoneMCMSensors();
								for (int num3 = 0; num3 < noneMCMSensors5.Length; num3++)
								{
									Sensor sensor6 = noneMCMSensors5[num3];
									if (sensor6.IsECMOrIRCM() && sensor6.IsJammerFor(sensor2) && sensor6.IsSensorSpoofed(ref sensor2, ref this.ParentPlatform))
									{
										sensor2.SetIsSpoofed(new bool?(true));
										this.ParentPlatform.m_Scenario.LogMessage("TVM/SAGG-guided武器的制导雷达被干扰 - 不能命中目标", LoggedMessage.MessageType.WeaponEndgame, 1, this.ParentPlatform.GetGuid(), null, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
										break;
									}
								}
							}
						}
						if (weapon_.GetNoneMCMSensors().Length > 0)
						{
							if (num >= num2 && num2 > 0)
							{
								this.ParentPlatform.m_Scenario.LogMessage("武器的所有导引头都已被干扰 - 武器脱靶", LoggedMessage.MessageType.WeaponEndgame, 1, this.ParentPlatform.GetGuid(), null, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
							}
							else
							{
								if (num > 0)
								{
									this.ParentPlatform.m_Scenario.LogMessage(string.Concat(new string[]
									{
										"只有",
										Conversions.ToString(num),
										"/",
										Conversions.ToString(num2),
										"的武器传感器被干扰"
									}), LoggedMessage.MessageType.WeaponEndgame, 1, this.ParentPlatform.GetGuid(), null, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
								}
								Weapon weapon2 = weapon_;
								ActiveUnit parentPlatform = this.ParentPlatform;
								ActiveUnit parentPlatform3 = this.ParentPlatform;
								Random random = GameGeneral.GetRandom();
								weapon2.WeaponEndGame(parentPlatform, ref parentPlatform3.m_Scenario, false, ref random);
							}
						}
						else if (!((!Information.IsNothing(sensor2)) ? sensor2.IsSpoofed() : new bool?(false)).GetValueOrDefault())
						{
							Weapon weapon3 = weapon_;
							ActiveUnit parentPlatform = this.ParentPlatform;
							ActiveUnit parentPlatform4 = this.ParentPlatform;
							Random random = GameGeneral.GetRandom();
							weapon3.WeaponEndGame(parentPlatform, ref parentPlatform4.m_Scenario, false, ref random);
						}
					}
					if (weapon_.GetGuidanceMethod() == Weapon._GuidanceMethod.TrackViaMissile)
					{
						if (!Information.IsNothing(sensor2) && !Information.IsNothing(sensor2.IsSpoofed()))
						{
							sensor2.SetIsSpoofed(null);
						}
					}
					else
					{
						Sensor[] noneMCMSensors6 = weapon_.GetNoneMCMSensors();
						for (int num4 = 0; num4 < noneMCMSensors6.Length; num4++)
						{
							Sensor sensor7 = noneMCMSensors6[num4];
							if (!Information.IsNothing(sensor7.IsSpoofed()))
							{
								sensor7.SetIsSpoofed(null);
							}
						}
					}
					if (!this.ParentPlatform.m_Scenario.GetUnitRemovals().Contains(weapon_))
					{
						weapon_.m_Scenario.RemoveUnit(weapon_);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100310", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x00170470 File Offset: 0x0016E670
		private bool method_30(WeaponRec weaponRec_0, Mount mount_0, Weapon weapon_7)
		{
			bool flag = false;
			bool result;
			try
			{
				Weapon._WeaponType weaponType = weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetWeaponType();
				switch (weaponType)
				{
				case Weapon._WeaponType.GuidedWeapon:
					flag = false;
					result = false;
					return result;
				case Weapon._WeaponType.Rocket:
					flag = false;
					result = false;
					return result;
				case Weapon._WeaponType.IronBomb:
					break;
				case Weapon._WeaponType.Gun:
					flag = false;
					result = false;
					return result;
				default:
					if (weaponType == Weapon._WeaponType.Laser)
					{
						flag = false;
						result = false;
						return result;
					}
					break;
				}
				if (mount_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
				{
					flag = false;
				}
				else if (weaponRec_0.GetCurrentLoad() == 0)
				{
					flag = false;
				}
				else
				{
					Weapon weapon = weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario);
					float distance = Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), weapon_7.GetLatitude(null), weapon_7.GetLongitude(null));
					Weapon._WeaponType weaponType2 = weapon_7.GetWeaponType();
					float num;
					if (weaponType2 == Weapon._WeaponType.Torpedo)
					{
						num = weapon.RangeASWMin;
					}
					else
					{
						num = weapon.RangeAAWMin;
					}
					if (distance < num)
					{
						flag = false;
					}
					else if (!mount_0.Autonomous && !mount_0.HasDecoy())
					{
						flag = false;
					}
					else
					{
						if (weapon.GetWeaponType() != Weapon._WeaponType.Decoy_Expendable && weapon.GetWeaponType() != Weapon._WeaponType.Decoy_Towed)
						{
							if (weaponRec_0.TimeToFire > 0f)
							{
								flag = false;
								result = false;
								return result;
							}
						}
						else if (weaponRec_0.TimeToFire > 1f)
						{
							flag = false;
							result = false;
							return result;
						}
						flag = (mount_0.GetTimeToFire() <= 0f && this.method_32(weaponRec_0, weapon_7));
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100311", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x001706A4 File Offset: 0x0016E8A4
		private bool method_31(WeaponRec weaponRec_0, Weapon weapon_7)
		{
			bool result = false;
			try
			{
				float distance = Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), weapon_7.GetLatitude(null), weapon_7.GetLongitude(null));
				result = (weaponRec_0.GetCurrentLoad() != 0 && distance >= weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).RangeAAWMin && this.method_32(weaponRec_0, weapon_7));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100312", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600416D RID: 16749 RVA: 0x00170794 File Offset: 0x0016E994
		private bool method_32(WeaponRec weaponRec_0, Weapon weapon_7)
		{
			bool result = false;
			checked
			{
				try
				{
					Weapon weapon = weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario);
					if (weapon.IsDecoy())
					{
						if (weapon.GetWeaponType() == Weapon._WeaponType.Decoy_Vehicle)
						{
							result = false;
						}
						else
						{
							bool flag = false;
							switch (weapon_7.GetWeaponAI().GetPrimaryTarget().contactType)
							{
							case Contact_Base.ContactType.Air:
							case Contact_Base.ContactType.Missile:
								flag = weapon.weaponTarget.IsAircraft;
								break;
							case Contact_Base.ContactType.Surface:
								flag = weapon.weaponTarget.IsSurfaceShip;
								break;
							case Contact_Base.ContactType.Submarine:
								flag = weapon.weaponTarget.IsSubsurface;
								break;
							case Contact_Base.ContactType.Facility_Fixed:
								flag = (weapon.weaponTarget.IsSoftLandStructures || weapon.weaponTarget.IsHardLandStructures);
								break;
							case Contact_Base.ContactType.Facility_Mobile:
								flag = (weapon.weaponTarget.IsSoftMobileUnit || weapon.weaponTarget.IsHardMobileUnit);
								break;
							}
							if (!flag)
							{
								result = false;
							}
							else
							{
								bool flag2 = false;
								if (weapon_7.GetGuidanceMethod() == Weapon._GuidanceMethod.TrackViaMissile)
								{
									if (weapon.IsRadarDetectable())
									{
										flag2 = true;
									}
								}
								else
								{
									Sensor[] noneMCMSensors = weapon_7.GetNoneMCMSensors();
									for (int i = 0; i < noneMCMSensors.Length; i++)
									{
										Sensor sensor = noneMCMSensors[i];
										if (sensor.IsSonar())
										{
											if (weapon.IsSonarDetectable())
											{
												flag2 = true;
											}
										}
										else
										{
											switch (sensor.sensorType)
											{
											case Sensor.SensorType.Radar:
											case Sensor.SensorType.SemiActive:
												if (weapon.IsRadarDetectable())
												{
													flag2 = true;
												}
												break;
											case Sensor.SensorType.Visual:
												if (weapon.IsVisualSensorDetectable())
												{
													flag2 = true;
												}
												break;
											case Sensor.SensorType.Infrared:
												if (weapon.IsInfraredSensorDetectable())
												{
													flag2 = true;
												}
												break;
											}
										}
									}
								}
								result = flag2;
							}
						}
					}
					else
					{
						Weapon._WeaponType weaponType = weapon_7.GetWeaponType();
						if (weaponType != Weapon._WeaponType.GuidedWeapon)
						{
							if (weaponType == Weapon._WeaponType.Torpedo)
							{
								result = weapon.weaponTarget.IsTorpedoe;
							}
						}
						else
						{
							result = (weapon.weaponTarget.IsGuidedWeapon && !weapon_7.weaponTarget.IsAircraft && !weapon_7.weaponTarget.IsGuidedWeapon);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100313", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x0600416E RID: 16750 RVA: 0x00170A10 File Offset: 0x0016EC10
		public int GetWeaponLoadsOnMount(Mount mount_, int DBID_)
		{
			int num = 0;
			int result = 0;
			try
			{
				foreach (WeaponRec current in mount_.GetWeaponRecCollection())
				{
					if (current.WeapID == DBID_)
					{
						num += current.GetCurrentLoad();
					}
				}
				foreach (WeaponRec current2 in mount_.GetMagazineForMount().GetWeaponRecCollection())
				{
					if (current2.WeapID == DBID_)
					{
						num += current2.GetCurrentLoad();
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100314", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600416F RID: 16751 RVA: 0x00170B28 File Offset: 0x0016ED28
		public int method_34(Mount mount_0, int int_0)
		{
			int num = 0;
			int result = 0;
			try
			{
				foreach (WeaponRec current in mount_0.GetMagazineForMount().GetWeaponRecCollection())
				{
					if (current.WeapID == int_0)
					{
						num += current.GetCurrentLoad();
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100315", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x00170BE8 File Offset: 0x0016EDE8
		public virtual int GetWeaponLoadsInMagazines(int WeapDBID)
		{
			int num = 0;
			int result = 0;
			try
			{
				Magazine[] magazines;
				if (this.ParentPlatform.HasParentGroup() && this.ParentPlatform.GetParentGroup(false).HasFixedFacility())
				{
					magazines = this.ParentPlatform.GetParentGroup(false).GetMagazines();
				}
				else
				{
					magazines = this.ParentPlatform.GetMagazines();
				}
				Magazine[] array = magazines;
				for (int i = 0; i < array.Length; i = checked(i + 1))
				{
					Magazine magazine = array[i];
					foreach (WeaponRec current in magazine.GetWeaponRecCollection())
					{
						if (current.WeapID == WeapDBID)
						{
							num += current.GetCurrentLoad();
						}
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100316", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004171 RID: 16753 RVA: 0x00170D10 File Offset: 0x0016EF10
		public  int vmethod_7(Loadout loadout_0, int int_0)
		{
			int num = 0;
			int result = 0;
			try
			{
				WeaponRec[] weaponRecArray = loadout_0.WeaponRecArray;
				for (int i = 0; i < weaponRecArray.Length; i = checked(i + 1))
				{
					WeaponRec weaponRec = weaponRecArray[i];
					if (weaponRec.WeapID == int_0)
					{
						num += weaponRec.GetCurrentLoad();
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100317", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x00170DB0 File Offset: 0x0016EFB0
		public void ScheduleWeaponSalvo()
		{
			try
			{
				if (!this.ParentPlatform.IsAircraft && !this.ParentPlatform.IsWeapon && this.ParentPlatform.m_Mounts.Length != 0)
				{
					int num = this.ParentPlatform.m_Mounts.Length;
					int num2 = this.ParentPlatform.GetMagazines().Length;
					Dictionary<int, WeaponSalvo.Shooter> dictionary = new Dictionary<int, WeaponSalvo.Shooter>();
					Doctrine._WeaponControlStatus value = this.ParentPlatform.m_Doctrine.GetWCS_AirDoctrine(this.ParentPlatform.m_Scenario, false, null, false, false).Value;
					List<WeaponSalvo> list = new List<WeaponSalvo>();
					List<WeaponSalvo> list2 = this.ParentPlatform.GetSide(false).WeaponSalvos.ToList<WeaponSalvo>();
					List<WeaponSalvo.Shooter> list3 = new List<WeaponSalvo.Shooter>();
					foreach (WeaponSalvo current in list2)
					{
						if (!Information.IsNothing(current) && (current.ManualFire || value != Doctrine._WeaponControlStatus.Hold))
						{
							list3.Clear();
							list3 = current.m_Shooters.ToList<WeaponSalvo.Shooter>();
							foreach (WeaponSalvo.Shooter current2 in list3)
							{
								if (Operators.CompareString(this.ParentPlatform.GetGuid(), current2.ShooterObjectID, false) == 0)
								{
									if (current2.QuantityFired < current2.QuantityAssigned && !dictionary.ContainsKey(current.WeaponDBID))
									{
										dictionary.Add(current.WeaponDBID, current2);
										if (current.ManualFire)
										{
											list.Add(current);
										}
									}
									break;
								}
							}
						}
					}
					int num3 = num - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						Mount mount = this.ParentPlatform.m_Mounts[num4];
						if (mount.method_30() > 0f && mount.GetWeaponRecCollection().Count != mount.GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.IsLaserWeapon)).Count<WeaponRec>())
						{
							mount.method_31(mount.method_30() - 1f);
						}
						else if (num2 != 0 || mount.GetMagazineForMount().GetWeaponRecCollection().Count != 0)
						{
							List<WeaponRec> list4 = new List<WeaponRec>();
							List<WeaponRec> list5 = new List<WeaponRec>();
							List<WeaponRec> list6 = new List<WeaponRec>();
							if (mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && mount.GetMagazineForMount().GetTimeToFire() <= 0f)
							{
								bool flag = false;
								using (IEnumerator<WeaponRec> enumerator3 = mount.GetWeaponRecCollection().GetEnumerator())
								{
									while (enumerator3.MoveNext())
									{
										if (enumerator3.Current.MaxLoad == mount.Capacity)
										{
											flag = true;
											break;
										}
									}
								}
								int num7;
								if (mount.GetWeaponRecCollection().Count > 1 && flag)
								{
									int num5 = mount.GetWeaponRecCollection().Count - 1;
									for (int i = 0; i <= num5; i++)
									{
										WeaponRec weaponRec = mount.GetWeaponRecCollection()[i];
										checked
										{
											if (weaponRec.HasReloadPriorityOnMount(mount))
											{
												if (weaponRec.GetCurrentLoad() < weaponRec.MaxLoad)
												{
													bool flag2 = false;
													foreach (WeaponRec current3 in mount.GetMagazineForMount().GetWeaponRecCollection())
													{
														if (current3.WeapID == weaponRec.WeapID && current3.GetCurrentLoad() > 0)
														{
															flag2 = true;
															break;
														}
													}
													if (!flag2)
													{
														Magazine[] magazines = ((Platform)this.ParentPlatform).m_Magazines;
														for (int j = 0; j < magazines.Length; j++)
														{
															Magazine magazine = magazines[j];
															if (magazine.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed)
															{
																foreach (WeaponRec current4 in magazine.GetWeaponRecCollection())
																{
																	if (current4.WeapID == weaponRec.WeapID && current4.GetCurrentLoad() > 0)
																	{
																		flag2 = true;
																		break;
																	}
																}
																if (flag2)
																{
																	break;
																}
															}
														}
													}
													if (flag2)
													{
														list5.Add(weaponRec);
													}
												}
												list4.Add(weaponRec);
											}
											else
											{
												list6.Add(weaponRec);
											}
										}
									}
									int num9;
                                    WeaponRec current5X;

                                    foreach (WeaponRec current5 in list5)
									{
										if (current5.GetCurrentLoad() < current5.MaxLoad)
										{
											if (list6.Count > 0)
											{
												int num6 = list6.Count - 1;
												for (int k = 0; k <= num6; k++)
												{
													WeaponRec weaponRec2 = list6[k];
													if (weaponRec2.GetCurrentLoad() > 0)
													{
														Mount mount2 = mount;
														num7 = 0;
														int num8 = 0;
														if (mount2.method_35(ref num7, ref num8) >= mount.Capacity && this.method_36(ref mount, ref weaponRec2))
														{
                                                            current5X = current5;
                                                            this.method_37(ref mount, ref current5X);
														}
													}
												}
											}
											if (list4.Count > 1)
											{
												int num8 = list4.Count - 1;
												for (int l = 0; l <= num8; l++)
												{
													WeaponRec weaponRec2 = list4[l];
													if (weaponRec2 != current5 && (double)weaponRec2.GetCurrentLoad() / (double)weaponRec2.Multiple - 1.0 > (double)current5.GetCurrentLoad())
													{
														Mount mount3 = mount;
														num7 = 0;
														num9 = 0;
														if (mount3.method_35(ref num7, ref num9) >= mount.Capacity && this.method_36(ref mount, ref weaponRec2))
														{
                                                            current5X = current5;
                                                            this.method_37(ref mount, ref current5X);
														}
													}
												}
											}
											int num10 = 0;
											int num11 = 0;
											mount.method_35(ref num10, ref num11);
											if (num11 <= 0 || current5.Multiple != 1 || num10 + num11 < mount.Capacity)
											{
                                                current5X = current5;
                                                this.method_37(ref mount, ref current5X);
											}
										}
									}
									bool flag3 = false;
									if (dictionary.Count <= 0 || list4.Count != 0)
									{
										goto IL_F10;
									}
									if (mount.GetMagazineForMount().GetWeaponRecCollection().Count > 0)
									{
										using (IEnumerator<WeaponRec> enumerator7 = mount.GetWeaponRecCollection().GetEnumerator())
										{
											while (enumerator7.MoveNext())
											{
												WeaponRec current6 = enumerator7.Current;
												if (!current6.HasReloadPriorityOnMount(mount) && !current6.GetWeapon(this.ParentPlatform.m_Scenario).IsDecoy() && this.method_34(mount, current6.WeapID) != 0 && dictionary.ContainsKey(current6.WeapID))
												{
													WeaponSalvo.Shooter shooter = dictionary[current6.WeapID];
													if (Operators.CompareString(shooter.PreferredMountObjectID, "", false) == 0 || Operators.CompareString(shooter.PreferredMountObjectID, mount.GetGuid(), false) == 0)
													{
														Mount mount4 = mount;
														num9 = 0;
														num7 = 0;
														if (mount4.method_35(ref num9, ref num7) >= mount.Capacity)
														{
															using (IEnumerator<WeaponRec> enumerator8 = mount.GetWeaponRecCollection().GetEnumerator())
															{
																while (enumerator8.MoveNext())
																{
																	WeaponRec current7 = enumerator8.Current;
																	if (current7 != current6 && this.method_36(ref mount, ref current7))
																	{
																		this.method_37(ref mount, ref current6);
																		break;
																	}
																}
																goto IL_7B8;
															}
														}
														this.method_37(ref mount, ref current6);
														IL_7B8:
														dictionary.Remove(current6.WeapID);
														flag3 = true;
														break;
													}
												}
											}
											goto IL_F10;
										}
									}
									if (list.Count <= 0)
									{
										goto IL_F10;
									}
									Mount mount5 = mount;
									num7 = 0;
									num9 = 0;
									if (mount5.method_35(ref num7, ref num9) >= mount.Capacity)
									{
										foreach (WeaponRec current8 in mount.GetWeaponRecCollection())
										{
											foreach (WeaponSalvo current9 in list)
											{
												if (current8.GetWeapon(this.ParentPlatform.m_Scenario).DBID == current9.WeaponDBID && current8.GetCurrentLoad() > 0)
												{
													flag3 = true;
													break;
												}
											}
											if (flag3)
											{
												break;
											}
										}
									}
									if (flag3)
									{
										goto IL_F05;
									}
									using (IEnumerator<WeaponRec> enumerator11 = mount.GetWeaponRecCollection().GetEnumerator())
									{
										while (enumerator11.MoveNext())
										{
											WeaponRec current10 = enumerator11.Current;
											if (!current10.HasReloadPriorityOnMount(mount) && !current10.GetWeapon(this.ParentPlatform.m_Scenario).IsDecoy() && this.GetWeaponLoadsInMagazines(current10.WeapID) != 0)
											{
												using (List<WeaponSalvo>.Enumerator enumerator12 = list.GetEnumerator())
												{
													while (enumerator12.MoveNext())
													{
														if (enumerator12.Current.WeaponDBID == current10.WeapID && dictionary.ContainsKey(current10.WeapID))
														{
															WeaponSalvo.Shooter shooter2 = dictionary[current10.WeapID];
															if (Operators.CompareString(shooter2.PreferredMountObjectID, "", false) == 0 || Operators.CompareString(shooter2.PreferredMountObjectID, mount.GetGuid(), false) == 0)
															{
																Mount mount6 = mount;
																num9 = 0;
																num7 = 0;
																if (mount6.method_35(ref num9, ref num7) >= mount.Capacity)
																{
																	using (IEnumerator<WeaponRec> enumerator13 = mount.GetWeaponRecCollection().GetEnumerator())
																	{
																		while (enumerator13.MoveNext())
																		{
																			WeaponRec current11 = enumerator13.Current;
																			if (current11.GetCurrentLoad() != 0 && current11 != current10 && this.method_36(ref mount, ref current11))
																			{
																				this.method_37(ref mount, ref current10);
																				break;
																			}
																		}
																		goto IL_A39;
																	}
																}
																if (current10.GetCurrentLoad() < current10.MaxLoad)
																{
																	this.method_37(ref mount, ref current10);
																}
																IL_A39:
																flag3 = true;
																break;
															}
														}
													}
												}
												if (flag3)
												{
													break;
												}
											}
										}
										goto IL_F10;
									}
									IL_A72:
									bool flag4 = false;
									if (!flag3 && list4.Count == 0 && (!Information.IsNothing(this.ParentPlatform.GetAI().GetPrimaryTarget()) || this.ParentPlatform.GetAI().GetTargets().Length > 0))
									{
										List<WeaponRec> list7;
										if (!Information.IsNothing(this.ParentPlatform.GetAI().GetPrimaryTarget()))
										{
											list7 = mount.GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.method_61)).OrderByDescending(new Func<WeaponRec, int>(this.method_62)).ToList<WeaponRec>();
										}
										else
										{
											list7 = mount.GetWeaponRecCollection().Where(new Func<WeaponRec, bool>(this.method_63)).OrderByDescending(new Func<WeaponRec, float>(this.method_64)).ToList<WeaponRec>();
										}
										if (list7.Count > 0)
										{
                                            WeaponRec current12X;
                                            foreach (WeaponRec current12 in list7)
											{
												if (this.method_34(mount, current12.WeapID) != 0 || this.GetWeaponLoadsInMagazines(current12.WeapID) != 0)
												{
													Mount mount7 = mount;
													num7 = 0;
													num9 = 0;
													if (mount7.method_35(ref num7, ref num9) < mount.Capacity)
													{
                                                        current12X = current12;
                                                        this.method_37(ref mount, ref current12X);
														flag4 = true;
														break;
													}
                                                    WeaponRec current13X;

                                                    foreach (WeaponRec current13 in mount.GetWeaponRecCollection())
													{
														if (current13 != current12 && !current13.HasReloadPriorityOnMount(mount) && current13.GetCurrentLoad() > 0 && !current13.GetWeapon(this.ParentPlatform.m_Scenario).IsDecoy())
														{
															Weapon weapon = current13.GetWeapon(this.ParentPlatform.m_Scenario);
															ActiveUnit_AI aI;
															Contact primaryTarget = (aI = this.ParentPlatform.GetAI()).GetPrimaryTarget();
															int num12 = this.method_17(ref weapon, ref primaryTarget, true);
															aI.SetPrimaryTarget(primaryTarget);
															weapon = current12.GetWeapon(this.ParentPlatform.m_Scenario);
															primaryTarget = (aI = this.ParentPlatform.GetAI()).GetPrimaryTarget();
															int num13 = this.method_17(ref weapon, ref primaryTarget, true);
															aI.SetPrimaryTarget(primaryTarget);
                                                            current13X = current13;

                                                            if (num12 < num13 && this.method_36(ref mount, ref current13X))
															{
                                                                current12X = current12;
                                                                this.method_37(ref mount, ref current12X);
																flag4 = true;
																break;
															}
														}
													}
												}
											}
										}
									}
									if (flag4 || flag3)
									{
										goto IL_E10;
									}
									int num14 = 0;
									int num15 = 0;
									mount.method_35(ref num14, ref num15);
									if (num14 < mount.Capacity && list5.Count <= 0)
									{
										num9 = list6.Count - 1;
										for (int m = 0; m <= num9; m++)
										{
											WeaponRec weaponRec2 = list6[m];
											if ((num15 <= 0 || weaponRec2.Multiple != 1 || num14 + num15 < mount.Capacity) && !weaponRec2.GetWeapon(this.ParentPlatform.m_Scenario).IsTrainingRound() && weaponRec2.GetCurrentLoad() < weaponRec2.MaxLoad)
											{
												this.method_37(ref mount, ref weaponRec2);
											}
										}
										goto IL_E10;
									}
									goto IL_E10;
									IL_F10:
									if (!flag3)
									{
										goto IL_A72;
									}
									goto IL_F05;
								}
								else
								{
                                    WeaponRec current14X;
                                    foreach (WeaponRec current14 in mount.GetWeaponRecCollection())
									{
                                        current14X = current14;
                                        if (current14.GetCurrentLoad() < current14.MaxLoad && this.method_37(ref mount, ref current14X))
										{
											break;
										}
									}
								}
								IL_E10:
								num7 = mount.GetMagazineForMount().GetWeaponRecCollection().Count - 1;
								for (int n = 0; n <= num7; n++)
								{
									WeaponRec weaponRec2 = mount.GetMagazineForMount().GetWeaponRecCollection()[n];
									if (!weaponRec2.GetWeapon(this.ParentPlatform.m_Scenario).IsTrainingRound() && weaponRec2.GetCurrentLoad() < weaponRec2.MaxLoad)
									{
										while (weaponRec2.GetCurrentLoad() < weaponRec2.MaxLoad)
										{
											float num16 = 0f;
											if (string.CompareOrdinal(this.vmethod_10(weaponRec2.WeapID, false, ref num16), "OK") != 0)
											{
												break;
											}
											weaponRec2.SetCurrentLoad(weaponRec2.GetCurrentLoad() + 1);
											Mount mount8;
											(mount8 = mount).SetTimeToFire(mount8.GetTimeToFire() + num16);
											Mount mount9 = mount;
											int num17 = 0;
											int num18 = 0;
											if (mount9.method_35(ref num17, ref num18) >= mount.Capacity)
											{
												break;
											}
										}
									}
								}
							}
						}
						IL_F05:;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100318", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x00171EB4 File Offset: 0x001700B4
		private bool method_36(ref Mount mount_, ref WeaponRec weaponRec_)
		{
			Mount mount = mount_;
			int num = 0;
			int num2 = 0;
			bool flag = false;
			bool result;
			if (mount.method_35(ref num, ref num2) == 0)
			{
				flag = false;
			}
			else if (weaponRec_.GetCurrentLoad() == 0)
			{
				flag = false;
			}
			else if (weaponRec_.TimeToFire > 0f)
			{
				flag = false;
			}
			else
			{
				try
				{
                    WeaponRec currentX;
                    foreach (WeaponRec current in mount_.GetMagazineForMount().GetWeaponRecCollection())
					{
                        currentX = current;
                        if (current.WeapID == weaponRec_.WeapID && string.CompareOrdinal(this.method_39(ref currentX), "OK") == 0)
						{
							if (weaponRec_.Multiple > 1)
							{
								num2 = weaponRec_.Multiple;
								for (int i = 1; i <= num2; i++)
								{
									weaponRec_.SetCurrentLoad(weaponRec_.GetCurrentLoad() - 1);
									float num3 = (float)weaponRec_.GetCurrentLoad() / (float)weaponRec_.Multiple;
									if (num3 == (float)((int)Math.Round((double)num3)))
									{
										break;
									}
								}
							}
							else
							{
								weaponRec_.SetCurrentLoad(weaponRec_.GetCurrentLoad() - 1);
							}
							weaponRec_.SetTimeToFire();
							mount_.ReloadStatus = Mount._ReloadStatus.Unloading;
							mount_.GetMagazineForMount().ResetTimeToFire();
							flag = true;
							result = true;
							return result;
						}
					}
					if (string.CompareOrdinal(this.AddToMagazineWeaponLoad(weaponRec_.WeapID, false, true), "OK") == 0)
					{
						if (weaponRec_.Multiple > 1)
						{
							num = weaponRec_.Multiple;
							for (int j = 1; j <= num; j++)
							{
								weaponRec_.SetCurrentLoad(weaponRec_.GetCurrentLoad() - 1);
								float num4 = (float)weaponRec_.GetCurrentLoad() / (float)weaponRec_.Multiple;
								if (num4 == (float)((int)Math.Round((double)num4)))
								{
									break;
								}
							}
						}
						else
						{
							weaponRec_.SetCurrentLoad(weaponRec_.GetCurrentLoad() - 1);
						}
						mount_.ReloadStatus = Mount._ReloadStatus.Unloading;
						weaponRec_.SetTimeToFire();
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
					ex2.Data.Add("Error at 100320", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x00172140 File Offset: 0x00170340
		private bool method_37(ref Mount mount_0, ref WeaponRec weaponRec_0)
		{
			Mount mount = mount_0;
			int num = 0;
			int num2 = 0;
			mount.method_35(ref num2, ref num);
			bool flag = false;
			bool result;
			if (num2 < mount_0.Capacity)
			{
				try
				{
					while (weaponRec_0.GetCurrentLoad() < weaponRec_0.MaxLoad)
					{
						if (!weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).IsLaserWeapon() || weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).m_Warheads[0].method_20() != Warhead.Enum86.const_2 || !this.ParentPlatform.m_Scenario.FifteenthSecondIsChangingOnThisPulse || (this.ParentPlatform.GetEngines().Count <= 0 && this.ParentPlatform.GetEngines().Where(ActiveUnit_Weaponry.EngineFunc7).Count<Engine>() <= 0))
						{
							int num3 = 0;
                            WeaponRec currentX;

                            foreach (WeaponRec current in mount_0.GetMagazineForMount().GetWeaponRecCollection())
							{
                                currentX = current;
                                if (current.WeapID == weaponRec_0.WeapID && string.CompareOrdinal(this.method_38(ref currentX), "OK") == 0)
								{
									if (weaponRec_0.Multiple > 1)
									{
										num = weaponRec_0.Multiple;
										for (int i = 1; i <= num; i++)
										{
											weaponRec_0.SetCurrentLoad(weaponRec_0.GetCurrentLoad() + 1);
											float num4 = (float)weaponRec_0.GetCurrentLoad() / (float)weaponRec_0.Multiple;
											if (num4 == (float)((int)Math.Round((double)num4)))
											{
												break;
											}
										}
									}
									else
									{
										weaponRec_0.SetCurrentLoad(weaponRec_0.GetCurrentLoad() + 1);
									}
									Mount mount2;
									(mount2 = mount_0).SetTimeToFire(mount2.GetTimeToFire() + (float)mount_0.GetMagazineForMount().MagazineROF);
									if (mount_0.GetTimeToFire() > (float)(mount_0.Capacity * mount_0.GetMagazineForMount().MagazineROF))
									{
										mount_0.SetTimeToFire((float)(mount_0.Capacity * mount_0.GetMagazineForMount().MagazineROF));
									}
									mount_0.ReloadStatus = Mount._ReloadStatus.Reloading;
									Mount mount3 = mount_0;
									num3 = 0;
									int num5 = 0;
									if (mount3.method_35(ref num3, ref num5) >= mount_0.Capacity)
									{
										flag = true;
										result = true;
										return result;
									}
								}
							}
							float num6 = 0f;
							if (string.CompareOrdinal(this.vmethod_10(weaponRec_0.WeapID, false, ref num6), "OK") == 0)
							{
								if (weaponRec_0.Multiple > 1)
								{
									int num5 = weaponRec_0.Multiple;
									for (int j = 1; j <= num5; j++)
									{
										weaponRec_0.SetCurrentLoad(weaponRec_0.GetCurrentLoad() + 1);
										float num7 = (float)weaponRec_0.GetCurrentLoad() / (float)weaponRec_0.Multiple;
										if (num7 == (float)((int)Math.Round((double)num7)))
										{
											break;
										}
									}
								}
								else
								{
									weaponRec_0.SetCurrentLoad(weaponRec_0.GetCurrentLoad() + 1);
								}
								Mount mount2;
								(mount2 = mount_0).SetTimeToFire(mount2.GetTimeToFire() + num6);
								if (mount_0.GetTimeToFire() > (float)mount_0.Capacity * num6)
								{
									mount_0.SetTimeToFire((float)mount_0.Capacity * num6);
								}
								mount_0.ReloadStatus = Mount._ReloadStatus.Reloading;
								Mount mount4 = mount_0;
								num3 = 0;
								mount4.method_35(ref num2, ref num3);
								if (num2 != mount_0.Capacity)
								{
									continue;
								}
								flag = true;
							}
							else
							{
								flag = false;
							}
						}
						else
						{
							weaponRec_0.SetCurrentLoad(weaponRec_0.GetCurrentLoad() + 1);
							flag = true;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100321", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x00172530 File Offset: 0x00170730
		public virtual string vmethod_8(int WeaponID_, bool bool_7, bool bool_8)
		{
			string text = "";
			checked
			{
				string result;
				try
				{
					if (Operators.CompareString(this.AddToMagazineWeaponLoad(WeaponID_, bool_7, bool_8), "OK", false) == 0)
					{
						text = "OK";
					}
					else
					{
						Mount[] mounts = this.ParentPlatform.m_Mounts;
						for (int i = 0; i < mounts.Length; i++)
						{
							Mount mount = mounts[i];
							Mount mount2 = mount;
							int num = 0;
							int num2 = 0;
							if (mount2.method_35(ref num, ref num2) < mount.Capacity)
							{
								foreach (WeaponRec current in mount.GetWeaponRecCollection())
								{
									if (current.WeapID == WeaponID_ && current.GetCurrentLoad() < current.MaxLoad)
									{
										WeaponRec weaponRec;
										(weaponRec = current).SetCurrentLoad(unchecked(weaponRec.GetCurrentLoad() + 1));
										text = "OK";
										result = text;
										return result;
									}
								}
							}
						}
						text = "Failed";
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100322", "");
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
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x00172690 File Offset: 0x00170890
		public virtual string AddToMagazineWeaponLoad(int WeaponID_, bool bool_7, bool bool_8)
		{
			string text = "";
			checked
			{
				string result;
				try
				{
					Magazine[] array = this.ParentPlatform.GetMagazinesForAllMounts();
					Magazine[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						if (string.CompareOrdinal(array2[i].AddToCurrentLoad(WeaponID_), "OK") == 0)
						{
							text = "OK";
							result = text;
							return result;
						}
					}
					if (bool_8 && ((Platform)this.ParentPlatform).GetMagazines().Length > 0)
					{
						array = ((Platform)this.ParentPlatform).GetMagazines();
						if (bool_7)
						{
							array = array.OrderByDescending(ActiveUnit_Weaponry.MagazineFunc8).ToArray<Magazine>();
						}
						array[0].GetWeaponRecCollection().Add(new WeaponRec(ref this.ParentPlatform.m_Scenario, WeaponID_, 0, array[0].MagazineCapacity, 1, 1, false, false));
						if (string.CompareOrdinal(array[0].AddToCurrentLoad(WeaponID_), "OK") == 0)
						{
							array[0].method_24();
							text = "OK";
							result = text;
							return result;
						}
					}
					text = "Failed";
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100323", "");
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
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x001727EC File Offset: 0x001709EC
		public virtual string vmethod_10(int int_0, bool bool_7, ref float MagazineROF_)
		{
			string text = "";
			checked
			{
				string result;
				try
				{
					if (bool_7 && this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags))
					{
						text = "OK";
					}
					else
					{
						Magazine[] magazines = ((Platform)this.ParentPlatform).m_Magazines;
						for (int i = 0; i < magazines.Length; i++)
						{
							Magazine magazine = magazines[i];
							if (magazine.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed && Operators.CompareString(magazine.method_30(int_0, bool_7, ref MagazineROF_), "OK", false) == 0)
							{
								MagazineROF_ = (float)magazine.MagazineROF;
								text = "OK";
								result = text;
								return result;
							}
						}
						text = "Weapon not found in magazines";
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100324", "");
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
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x001728E8 File Offset: 0x00170AE8
		private string method_38(ref WeaponRec weaponRec_0)
		{
			string result = "";
			try
			{
				if (weaponRec_0.TimeToFire > 0f)
				{
					result = "Cannot yet load/fire from this weapon record (TimeToFire > 0)";
				}
				else if (weaponRec_0.GetCurrentLoad() == 0)
				{
					result = "Weapon record is empty";
				}
				else
				{
					weaponRec_0.SetCurrentLoad(weaponRec_0.GetCurrentLoad() - 1);
					result = "OK";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100325", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x00172994 File Offset: 0x00170B94
		private string method_39(ref WeaponRec weaponRec_0)
		{
			string result = "";
			try
			{
				if (weaponRec_0.GetCurrentLoad() == weaponRec_0.MaxLoad)
				{
					result = "Weapon record is full";
				}
				else
				{
					weaponRec_0.SetCurrentLoad(weaponRec_0.GetCurrentLoad() + 1);
					result = "OK";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100326", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x00172A2C File Offset: 0x00170C2C
		public void method_40(float elapsedTime, ref ActiveUnit FiringUnit, ref WeaponRec theWeaponRec, ref ActiveUnit theTarget, bool PointDefenceMode, float InitialHeading = 0f, ActiveUnit.Throttle ThrottleSetting = ActiveUnit.Throttle.Flank, Mount FiringMount = null)
		{
			try
			{
				Contact contact = null;
				foreach (Contact current in FiringUnit.GetSide(false).GetContactList())
				{
					if (current.ActualUnit == theTarget)
					{
						contact = current;
						break;
					}
				}
				Contact theTarget2 = contact;
				float initialHeading = 0f;
				WeaponSalvo weaponSalvo = null;
				int num = 0;
				this.FireWeapons(elapsedTime, ref theWeaponRec, theTarget2, PointDefenceMode, ref num, 0, initialHeading, ActiveUnit.Throttle.Flank, FiringMount, SonarEnvironment._SonobuoyDepthSetting.Shallow, 0L, ref weaponSalvo);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100327", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x00172B14 File Offset: 0x00170D14
		private void ModifyWeaponAccuracy(ActiveUnit activeUnit_1, ref UnguidedWeapon unguidedWeapon_, StringBuilder stringBuilder_0)
		{
			try
			{
				if (activeUnit_1.IsAircraft)
				{
					switch (((Aircraft)activeUnit_1).Bombsight)
					{
					case Aircraft._Bombsight.BasicTech:
						if (!Information.IsNothing(stringBuilder_0))
						{
							stringBuilder_0.Append("Basic-tech bombsight - accuracy unaffected. ");
						}
						break;
					case Aircraft._Bombsight.BallisticTech:
						unguidedWeapon_.CEP_Land = (float)(0.75 * (double)unguidedWeapon_.CEP_Land);
						unguidedWeapon_.CEP_Surface = (float)(0.75 * (double)unguidedWeapon_.CEP_Surface);
						if (!Information.IsNothing(stringBuilder_0))
						{
							stringBuilder_0.Append("Ballistic-tech bombsight - accuracy improved by 25%. ");
						}
						break;
					case Aircraft._Bombsight.ComputingTech:
						unguidedWeapon_.CEP_Land = (float)(0.5 * (double)unguidedWeapon_.CEP_Land);
						unguidedWeapon_.CEP_Surface = (float)(0.5 * (double)unguidedWeapon_.CEP_Surface);
						if (!Information.IsNothing(stringBuilder_0))
						{
							stringBuilder_0.Append("Computing-tech bombsight - accuracy improved by 50%. ");
						}
						break;
					case Aircraft._Bombsight.AdvancedTech:
						unguidedWeapon_.CEP_Land = (float)(0.2 * (double)unguidedWeapon_.CEP_Land);
						unguidedWeapon_.CEP_Surface = (float)(0.2 * (double)unguidedWeapon_.CEP_Surface);
						if (!Information.IsNothing(stringBuilder_0))
						{
							stringBuilder_0.Append("Advanced-tech bombsight - accuracy improved by 80%. ");
						}
						break;
					}
					GlobalVariables.ProficiencyLevel? proficiencyLevel = activeUnit_1.GetProficiencyLevel();
					int? num = proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						unguidedWeapon_.CEP_Land *= 2f;
						unguidedWeapon_.CEP_Surface *= 2f;
						if (!Information.IsNothing(stringBuilder_0))
						{
							stringBuilder_0.Append("Crew is Novice - accuracy reduced by 100%. ");
						}
					}
					else
					{
						num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.5);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.5);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Crew is Cadet - accuracy reduced by 50%. ");
							}
						}
						else
						{
							num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.2);
								unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.2);
								if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Crew is Regular - accuracy reduced by 20%. ");
								}
							}
							else
							{
								num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									if (!Information.IsNothing(stringBuilder_0))
									{
										stringBuilder_0.Append("Crew is Veteran - accuracy unaffected. ");
									}
								}
								else
								{
									num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 0.5);
										unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 0.5);
										if (!Information.IsNothing(stringBuilder_0))
										{
											stringBuilder_0.Append("Crew is Ace - accuracy improved by 100%. ");
										}
									}
								}
							}
						}
					}
					if (unguidedWeapon_.GetWeaponType() == Weapon._WeaponType.IronBomb && activeUnit_1.GetAltitude_AGL() > 609.600037f)
					{
						float num2 = (activeUnit_1.GetAltitude_AGL() - 609.600037f) / 1500f;
						if (num2 > 0f)
						{
							switch (((Aircraft)activeUnit_1).Bombsight)
							{
							case Aircraft._Bombsight.BasicTech:
								unguidedWeapon_.CEP_Land += num2 * 100f;
								unguidedWeapon_.CEP_Surface += num2 * 100f;
								if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Basic-tech bombsight and ").Append(activeUnit_1.GetCurrentAltitude_ASL(false)).Append("m altitude - accuracy decreased by ").Append((int)Math.Round((double)num2)).Append("%. ");
								}
								break;
							case Aircraft._Bombsight.BallisticTech:
								unguidedWeapon_.CEP_Land += num2 * 75f;
								unguidedWeapon_.CEP_Surface += num2 * 75f;
								if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Ballistic-tech bombsight and ").Append(activeUnit_1.GetCurrentAltitude_ASL(false)).Append("m altitude - accuracy decreased by ").Append((int)Math.Round((double)num2)).Append("%. ");
								}
								break;
							case Aircraft._Bombsight.ComputingTech:
								unguidedWeapon_.CEP_Land += num2 * 50f;
								unguidedWeapon_.CEP_Surface += num2 * 50f;
								if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Computing-tech bombsight and ").Append(activeUnit_1.GetCurrentAltitude_ASL(false)).Append("m altitude - accuracy decreased by ").Append((int)Math.Round((double)num2)).Append("%. ");
								}
								break;
							case Aircraft._Bombsight.AdvancedTech:
								unguidedWeapon_.CEP_Land += num2 * 25f;
								unguidedWeapon_.CEP_Surface += num2 * 25f;
								if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Advanced-tech bombsight and ").Append(activeUnit_1.GetCurrentAltitude_ASL(false)).Append("m altitude - accuracy decreased by ").Append((int)Math.Round((double)num2)).Append("%. ");
								}
								break;
							}
						}
					}
				}
				else if (activeUnit_1.IsShip)
				{
					int seaState = Weather.GetWeatherProfile(activeUnit_1.m_Scenario, activeUnit_1.GetLatitude(null), activeUnit_1.GetLongitude(null), 0).SeaState;
					switch (((Ship)activeUnit_1).GetTargetVisualSizeClass())
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						switch (seaState)
						{
						case 0:
						case 1:
						case 2:
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 0-2 & very small ship - accuracy unaffected. ");
							}
							break;
						case 3:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.1);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.1);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 3 & very small ship - accuracy decreased by 10%. ");
							}
							break;
						case 4:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.2);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.2);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 4 & very small ship - accuracy decreased by 20%. ");
							}
							break;
						case 5:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.3);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.3);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 5 & very small ship - accuracy decreased by 20%. ");
							}
							break;
						case 6:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.5);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.5);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 6 & very small ship - accuracy decreased by 50%. ");
							}
							break;
						case 7:
							unguidedWeapon_.CEP_Land *= 2f;
							unguidedWeapon_.CEP_Surface *= 2f;
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 7 & very small ship - accuracy decreased by 100%. ");
							}
							break;
						case 8:
							unguidedWeapon_.CEP_Land *= 3f;
							unguidedWeapon_.CEP_Surface *= 3f;
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 8 & very small ship - accuracy decreased by 200%. ");
							}
							break;
						case 9:
							unguidedWeapon_.CEP_Land *= 4f;
							unguidedWeapon_.CEP_Surface *= 4f;
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 9 & very small ship - accuracy decreased by 300%. ");
							}
							break;
						}
						break;
					case GlobalVariables.TargetVisualSizeClass.Small:
						switch (seaState)
						{
						case 0:
						case 1:
						case 2:
						case 3:
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 0-3 & small ship - accuracy unaffected. ");
							}
							break;
						case 4:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.1);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.1);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 4 & small ship - accuracy decreased by 10%. ");
							}
							break;
						case 5:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.2);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.2);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 5 & small ship - accuracy decreased by 20%. ");
							}
							break;
						case 6:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.3);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.3);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 6 & small ship - accuracy decreased by 30%. ");
							}
							break;
						case 7:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.5);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.5);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 7 & small ship - accuracy decreased by 50%. ");
							}
							break;
						case 8:
							unguidedWeapon_.CEP_Land *= 2f;
							unguidedWeapon_.CEP_Surface *= 2f;
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 8 & small ship - accuracy decreased by 100%. ");
							}
							break;
						case 9:
							unguidedWeapon_.CEP_Land *= 3f;
							unguidedWeapon_.CEP_Surface *= 3f;
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 9 & small ship - accuracy decreased by 200%. ");
							}
							break;
						}
						break;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						switch (seaState)
						{
						case 0:
						case 1:
						case 2:
						case 3:
						case 4:
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 0-4 & medium ship - accuracy unaffected. ");
							}
							break;
						case 5:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.1);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.1);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 5 & medium ship - accuracy decreased by 10%. ");
							}
							break;
						case 6:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.2);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.2);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 6 & medium ship - accuracy decreased by 20%. ");
							}
							break;
						case 7:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.3);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.3);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 7 & medium ship - accuracy decreased by 30%. ");
							}
							break;
						case 8:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.5);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.5);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 8 & medium ship - accuracy decreased by 50%. ");
							}
							break;
						case 9:
							unguidedWeapon_.CEP_Land *= 2f;
							unguidedWeapon_.CEP_Surface *= 2f;
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 9 & medium ship - accuracy decreased by 100%. ");
							}
							break;
						}
						break;
					case GlobalVariables.TargetVisualSizeClass.Large:
						switch (seaState)
						{
						case 0:
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 0-5 & large ship - accuracy unaffected. ");
							}
							break;
						case 6:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.1);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.1);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 6 & large ship - accuracy decreased by 10%. ");
							}
							break;
						case 7:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.2);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.2);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 7 & large ship - accuracy decreased by 20%. ");
							}
							break;
						case 8:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.3);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.3);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 8 & large ship - accuracy decreased by 30%. ");
							}
							break;
						case 9:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.5);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.5);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 9 & large ship - accuracy decreased by 50%. ");
							}
							break;
						}
						break;
					case GlobalVariables.TargetVisualSizeClass.VLarge:
						switch (seaState)
						{
						case 0:
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 0-6 & very large ship - accuracy unaffected. ");
							}
							break;
						case 7:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.1);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.1);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 7 & very large ship - accuracy decreased by 10%. ");
							}
							break;
						case 8:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.2);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.2);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 8 & very large ship - accuracy decreased by 20%. ");
							}
							break;
						case 9:
							unguidedWeapon_.CEP_Land = (float)((double)unguidedWeapon_.CEP_Land * 1.3);
							unguidedWeapon_.CEP_Surface = (float)((double)unguidedWeapon_.CEP_Surface * 1.3);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 9 & very large ship - accuracy decreased by 30%. ");
							}
							break;
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100328", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x00173B70 File Offset: 0x00171D70
		public List<Unit> FireWeapons(float elapsedTime, ref WeaponRec theWeaponRec, Contact theTarget, bool PointDefenceMode, ref int NumberOfWeaponsFired, int SpecificNumberOfWeaponsToFire, float InitialHeading, ActiveUnit.Throttle ThrottleSetting, Mount FiringMount, SonarEnvironment._SonobuoyDepthSetting SonobuoyDepthSetting, long ArmDelay_sec, ref WeaponSalvo theWeaponSalvo)
		{
			ActiveUnit_Weaponry.TargetEntry targetEntry = new ActiveUnit_Weaponry.TargetEntry(null);
			targetEntry.Target = theTarget;
			float num = 0f;
			if (!Information.IsNothing(targetEntry.Target))
			{
				num = this.ParentPlatform.GetHorizontalRange(targetEntry.Target);
			}
			Weapon weapon = theWeaponRec.GetWeapon(this.ParentPlatform.m_Scenario);
			List<Unit> list = new List<Unit>();
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				if (!PointDefenceMode)
				{
					Weapon._WeaponType weaponType = weapon.GetWeaponType();
					if (weaponType <= Weapon._WeaponType.GuidedProjectile)
					{
						if (weaponType != Weapon._WeaponType.GuidedWeapon)
						{
							switch (weaponType)
							{
							case Weapon._WeaponType.Decoy_Vehicle:
							case Weapon._WeaponType.GuidedProjectile:
								break;
							case Weapon._WeaponType.TrainingRound:
							case Weapon._WeaponType.Dispenser:
								goto IL_802;
							case Weapon._WeaponType.ContactBomb_Suicide:
							{
								theWeaponRec.SetCurrentLoad(theWeaponRec.GetCurrentLoad() - 1);
								theWeaponRec.SetTimeToFire();
								this.ParentPlatform.m_Scenario.RemoveUnit(this.ParentPlatform);
								Warhead[] warheads = weapon.m_Warheads;
								checked
								{
									for (int i = 0; i < warheads.Length; i++)
									{
										Warhead warhead = warheads[i];
										new Explosion(ref this.ParentPlatform.m_Scenario, targetEntry.Target.GetLongitude(null), targetEntry.Target.GetLatitude(null), targetEntry.Target.GetLongitude(null), targetEntry.Target.GetLatitude(null), this.ParentPlatform.GetCurrentHeading(), this.ParentPlatform.GetCurrentAltitude_ASL(false), warhead.DP, warhead.DP, warhead.warheadType, warhead.ExplosivesType, targetEntry.Target.ActualUnit, null, this.ParentPlatform, null, null, warhead.ClusterBombDispersionAreaLength, warhead.ClusterBombDispersionAreaWidth, (int)warhead.NumberOfWarheads, 0f, 0).SetCurrentHeading(this.ParentPlatform.GetCurrentHeading());
									}
									if (!Information.IsNothing(theWeaponSalvo))
									{
										WeaponSalvo.Shooter[] shooters = theWeaponSalvo.m_Shooters;
										for (int j = 0; j < shooters.Length; j++)
										{
											WeaponSalvo.Shooter shooter = shooters[j];
											unchecked
											{
												if (Operators.CompareString(shooter.ShooterObjectID, this.ParentPlatform.GetGuid(), false) == 0)
												{
													shooter.QuantityFired++;
												}
											}
										}
										this.ParentPlatform.GetSide(false).RemoveWeaponSalvo(theWeaponSalvo);
										goto IL_167C;
									}
									goto IL_167C;
								}
							}
							case Weapon._WeaponType.ContactBomb_Sabotage:
							{
								theWeaponRec.SetCurrentLoad(theWeaponRec.GetCurrentLoad() - 1);
								theWeaponRec.SetTimeToFire();
								Warhead[] warheads2 = weapon.m_Warheads;
								checked
								{
									for (int k = 0; k < warheads2.Length; k++)
									{
										Warhead warhead2 = warheads2[k];
										new Explosion(ref this.ParentPlatform.m_Scenario, targetEntry.Target.GetLongitude(null), targetEntry.Target.GetLatitude(null), targetEntry.Target.GetLongitude(null), targetEntry.Target.GetLatitude(null), this.ParentPlatform.GetCurrentHeading(), this.ParentPlatform.GetCurrentAltitude_ASL(false), warhead2.DP, warhead2.DP, warhead2.warheadType, warhead2.ExplosivesType, targetEntry.Target.ActualUnit, null, this.ParentPlatform, null, null, warhead2.ClusterBombDispersionAreaLength, warhead2.ClusterBombDispersionAreaWidth, (int)warhead2.NumberOfWarheads, warhead2.DP, 0).SetCurrentHeading(this.ParentPlatform.GetCurrentHeading());
									}
									if (!Information.IsNothing(theWeaponSalvo))
									{
										WeaponSalvo.Shooter[] shooters2 = theWeaponSalvo.m_Shooters;
										for (int l = 0; l < shooters2.Length; l++)
										{
											WeaponSalvo.Shooter shooter2 = shooters2[l];
											unchecked
											{
												if (Operators.CompareString(shooter2.ShooterObjectID, this.ParentPlatform.GetGuid(), false) == 0)
												{
													shooter2.QuantityFired++;
												}
											}
										}
										this.ParentPlatform.GetSide(false).RemoveWeaponSalvo(theWeaponSalvo);
										goto IL_167C;
									}
									goto IL_167C;
								}
							}
							default:
								goto IL_802;
							}
						}
					}
					else
					{
						switch (weaponType)
						{
						case Weapon._WeaponType.Torpedo:
							break;
						case Weapon._WeaponType.DepthCharge:
							goto IL_802;
						case Weapon._WeaponType.Sonobuoy:
						{
							Weapon weapon2 = Weapon.GetWeapon(ref this.ParentPlatform.m_Scenario, theWeaponRec.WeapID, null);
							weapon2.SetCEP_Surface(weapon2.CEPSurface);
							weapon2.SetCEP_Land(weapon2.CEP);
							int weapID = theWeaponRec.WeapID;
							Contact contact = null;
							this.FireWeapon(elapsedTime, ref this.ParentPlatform, ref weapon2, weapID, ref contact, this.ParentPlatform.GetCurrentHeading(), ActiveUnit.Throttle.Cruise, SonobuoyDepthSetting, null);
							theWeaponRec.SetCurrentLoad(theWeaponRec.GetCurrentLoad() - 1);
							theWeaponRec.SetTimeToFire();
							NumberOfWeaponsFired = 1;
							list.Add(weapon2);
							goto IL_167C;
						}
						case Weapon._WeaponType.BottomMine:
						case Weapon._WeaponType.MooredMine:
						case Weapon._WeaponType.FloatingMine:
						case Weapon._WeaponType.MovingMine:
						case Weapon._WeaponType.RisingMine:
						{
							UnguidedWeapon unguidedWeapon = new UnguidedWeapon(weapon, null, null, 0.0, 0.0, ArmDelay_sec);
							unguidedWeapon.SetSide(false, this.ParentPlatform.GetSide(false));
							if (string.CompareOrdinal(UnguidedWeapon.LayMine(ref unguidedWeapon, this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), (float)this.ParentPlatform.GetTerrainElevation(false, false, false), this.ParentPlatform.m_Scenario), "OK") != 0)
							{
								goto IL_167C;
							}
							this.ParentPlatform.m_Scenario.GetUnguidedWeapons().Add(unguidedWeapon.GetGuid(), unguidedWeapon);
							theWeaponRec.SetCurrentLoad(theWeaponRec.GetCurrentLoad() - 1);
							theWeaponRec.SetTimeToFire();
							NumberOfWeaponsFired = 1;
							list.Add(unguidedWeapon);
							if (!Information.IsNothing(this.ParentPlatform.GetAssignedMission(false)) && this.ParentPlatform.GetAssignedMission(false).MissionClass == Mission._MissionClass.Mining)
							{
								this.ParentPlatform.GetNavigator().ClearPlottedCourse();
								goto IL_167C;
							}
							goto IL_167C;
						}
						default:
							if (weaponType != Weapon._WeaponType.RV && weaponType != Weapon._WeaponType.HGV)
							{
								goto IL_802;
							}
							break;
						}
					}
					try
					{
						Weapon weapon3 = Weapon.GetWeapon(ref this.ParentPlatform.m_Scenario, theWeaponRec.WeapID, null);
						weapon3.SetCEP_Surface(weapon3.CEPSurface);
						weapon3.SetCEP_Land(weapon3.CEP);
						try
						{
							if (!Information.IsNothing(theWeaponSalvo))
							{
							}
							if (this.ParentPlatform.IsAircraft)
							{
								this.FireWeapon(elapsedTime, ref this.ParentPlatform, ref weapon3, theWeaponRec.WeapID, ref targetEntry.Target, this.ParentPlatform.GetCurrentHeading(), ActiveUnit.Throttle.Cruise, SonobuoyDepthSetting, theWeaponSalvo);
							}
							else
							{
								this.FireWeapon(elapsedTime, ref this.ParentPlatform, ref weapon3, theWeaponRec.WeapID, ref targetEntry.Target, Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), targetEntry.Target.GetLatitude(null), targetEntry.Target.GetLongitude(null)), ActiveUnit.Throttle.Cruise, SonobuoyDepthSetting, theWeaponSalvo);
							}
							if (!Information.IsNothing(theWeaponSalvo))
							{
								string guid = weapon3.GetGuid();
								ScenarioArrayUtil.AddStringToArray(ref theWeaponSalvo.WeaponObjectIDArray, guid);
							}
							else if (this.ParentPlatform.IsWeapon)
							{
								weapon3.SetFiringParent(((Weapon)this.ParentPlatform).GetFiringParent());
								if (targetEntry.Target.contactType == Contact_Base.ContactType.Aimpoint)
								{
									List<Contact> list2 = new List<Contact>();
									if (this.ParentPlatform.GetAI().GetTargets().Length > 0)
									{
										list2.AddRange(this.ParentPlatform.GetAI().GetTargets());
									}
									if (!Information.IsNothing(this.ParentPlatform.GetAI().GetPrimaryTarget()) && this.ParentPlatform.GetAI().GetPrimaryTarget().contactType != Contact_Base.ContactType.Aimpoint)
									{
										list2.Add(this.ParentPlatform.GetAI().GetPrimaryTarget());
									}
									if (list2.Count != 0)
									{
										list2 = list2.OrderBy(new Func<Contact, double>(targetEntry.GetRange)).ToList<Contact>();
										targetEntry.Target = list2[0];
									}
								}
								weapon3.method_233(ref weapon3, ref targetEntry.Target, this.ParentPlatform.m_Scenario);
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 100333", "");
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
						theWeaponRec.SetCurrentLoad(theWeaponRec.GetCurrentLoad() - 1);
						theWeaponRec.SetTimeToFire();
						if (weapon3.weaponTarget.IsRadar && !Information.IsNothing(weapon.ARM_SpecifiedEmission) && weapon.ARM_SpecifiedEmission.Key != 0)
						{
							weapon3.ARM_SpecifiedEmission = weapon.ARM_SpecifiedEmission;
							weapon3.ARM_SpecifiedEmissionIsMandatory = true;
						}
						if (weapon3.GetWeaponType() == Weapon._WeaponType.RV | weapon3.GetWeaponType() == Weapon._WeaponType.HGV)
						{
							weapon3.SetCEP_Surface(((Weapon)this.ParentPlatform).GetCEP_Surface());
							weapon3.SetCEP_Land(((Weapon)this.ParentPlatform).GetCEP_Land());
						}
						NumberOfWeaponsFired = 1;
						list.Add(weapon3);
						if (weapon3.weaponCode.SearchPattern)
						{
							if (this.ParentPlatform.IsAircraft && weapon3.IsTorpedo())
							{
								weapon3.searchPatternType = Weapon._SearchPatternType.const_2;
							}
							else
							{
								weapon3.searchPatternType = Weapon._SearchPatternType.const_1;
							}
						}
						goto IL_167C;
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ex4.Data.Add("Error at 100332", "");
						GameGeneral.LogException(ref ex4);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
						goto IL_167C;
					}
					IL_802:
					Weapon._WeaponType weaponType2 = weapon.GetWeaponType();
					double? num5;
					if (weaponType2 <= Weapon._WeaponType.Gun)
					{
						if (weaponType2 - Weapon._WeaponType.Rocket <= 1)
						{
							int num2 = 150;
							if (SpecificNumberOfWeaponsToFire > 0 && num2 > SpecificNumberOfWeaponsToFire)
							{
								num2 = SpecificNumberOfWeaponsToFire;
							}
							if (num2 > theWeaponRec.GetCurrentLoad())
							{
								num2 = theWeaponRec.GetCurrentLoad();
							}
							Sensor director_ = null;
							stringBuilder.Append(this.ParentPlatform.Name).Append(" attacks with unguided weapon(s): ").Append(num2).Append("x ").Append(theWeaponRec.GetWeapon(this.ParentPlatform.m_Scenario).Name).Append(". ");
							this.method_48(ref targetEntry.Target, FiringMount, ref director_);
							int num3 = num2;
							for (int m = 1; m <= num3; m++)
							{
								if (theWeaponRec.GetCurrentLoad() == 0)
								{
									break;
								}
								UnguidedWeapon unguidedWeapon2 = new UnguidedWeapon(weapon, targetEntry.Target, this.ParentPlatform, this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), 0L);
								if (m == 1)
								{
									switch (targetEntry.Target.contactType)
									{
									case Contact_Base.ContactType.Air:
									case Contact_Base.ContactType.Missile:
										stringBuilder.Append("Nominal PoH: ").Append(unguidedWeapon2.AirPOK).Append("%. ");
										break;
									case Contact_Base.ContactType.Surface:
										stringBuilder.Append("Nominal CEP: ").Append(unguidedWeapon2.CEP_Surface).Append("m. ");
										break;
									case Contact_Base.ContactType.Submarine:
										stringBuilder.Append("Nominal PoH: ").Append(unguidedWeapon2.SubsurfacePOK).Append("%. ");
										break;
									case Contact_Base.ContactType.Facility_Fixed:
									case Contact_Base.ContactType.Facility_Mobile:
										stringBuilder.Append("Nominal CEP: ").Append(unguidedWeapon2.CEP_Land).Append("m. ");
										break;
									}
								}
								if (unguidedWeapon2.GetWeaponType() != Weapon._WeaponType.IronBomb && !this.ParentPlatform.IsAircraft)
								{
									double num4 = (double)(num / weapon.GetMaxRangeToTarget(this.ParentPlatform, targetEntry.Target, false, null, false));
									unguidedWeapon2.CEP_Surface = (float)((int)Math.Round((double)weapon.GetCEP_Surface() * num4));
									unguidedWeapon2.CEP_Land = (float)((int)Math.Round((double)weapon.GetCEP_Land() * num4));
									if (m == 1)
									{
										stringBuilder.Append("Range is ").Append((int)Math.Round(100.0 * num4)).Append("% of maximum, CEP adjusted to same. ");
									}
								}
								if (m == 1)
								{
									this.method_47(ref FiringMount, unguidedWeapon2, director_, targetEntry.Target, theWeaponSalvo, stringBuilder);
								}
								else
								{
									this.method_47(ref FiringMount, unguidedWeapon2, director_, targetEntry.Target, theWeaponSalvo, null);
								}
								this.ModifyWeaponAccuracy(this.ParentPlatform, ref unguidedWeapon2, stringBuilder);
								num5 = ActiveUnit_Navigator.smethod_4(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), (double)this.ParentPlatform.GetCurrentHeading(), targetEntry.Target, unguidedWeapon2.GetCurrentSpeed());
								float? num6 = num5.HasValue ? new float?((float)num5.GetValueOrDefault()) : null;
								if (num6.HasValue)
								{
									unguidedWeapon2.SetCurrentHeading(num6.Value);
								}
								else
								{
									unguidedWeapon2.SetCurrentHeading(this.ParentPlatform.GetAI().GetAzimuth(targetEntry.Target));
								}
								unguidedWeapon2.SetSide(false, this.ParentPlatform.GetSide(false));
								unguidedWeapon2.SetAltitude_ASL(false, this.ParentPlatform.GetCurrentAltitude_ASL(false));
								this.ParentPlatform.m_Scenario.GetUnguidedWeapons().Add(unguidedWeapon2.GetGuid(), unguidedWeapon2);
								theWeaponRec.SetCurrentLoad(theWeaponRec.GetCurrentLoad() - 1);
								NumberOfWeaponsFired++;
								list.Add(unguidedWeapon2);
								unguidedWeapon2.SetFiringParent(this.ParentPlatform);
								unguidedWeapon2.FiringParentName = this.ParentPlatform.GetGuid();
								switch (targetEntry.Target.contactType)
								{
								case Contact_Base.ContactType.Air:
								case Contact_Base.ContactType.Missile:
									stringBuilder.Append("Final PoH at fire/launch point: ").Append(unguidedWeapon2.AirPOK).Append("%. ");
									break;
								case Contact_Base.ContactType.Surface:
									stringBuilder.Append("Final CEP at fire/launch point: ").Append(unguidedWeapon2.CEP_Surface).Append("m. ");
									break;
								case Contact_Base.ContactType.Submarine:
									stringBuilder.Append("Final PoH at fire/launch point: ").Append(unguidedWeapon2.SubsurfacePOK).Append("%. ");
									break;
								case Contact_Base.ContactType.Facility_Fixed:
								case Contact_Base.ContactType.Facility_Mobile:
									stringBuilder.Append("Final CEP at fire/launch point: ").Append(unguidedWeapon2.CEP_Land).Append("m. ");
									break;
								}
								this.ParentPlatform.LogMessage(stringBuilder.ToString(), LoggedMessage.MessageType.UnguidedWeaponModifiers, 0, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
								if (!Information.IsNothing(theWeaponSalvo))
								{
									string guid2 = unguidedWeapon2.GetGuid();
									ScenarioArrayUtil.AddStringToArray(ref theWeaponSalvo.WeaponObjectIDArray, guid2);
								}
							}
							goto IL_167C;
						}
						if (weaponType2 != Weapon._WeaponType.Gun)
						{
							goto IL_167C;
						}
					}
					else if (weaponType2 != Weapon._WeaponType.Dispenser)
					{
						if (weaponType2 != Weapon._WeaponType.DepthCharge && weaponType2 != Weapon._WeaponType.Laser)
						{
							goto IL_167C;
						}
					}
					else
					{
						Weapon weapon4 = Weapon.GetWeapon(ref this.ParentPlatform.m_Scenario, theWeaponRec.WeapID, null);
						Warhead[] warheads3 = weapon4.m_Warheads;
						checked
						{
							for (int n = 0; n < warheads3.Length; n++)
							{
								Warhead warhead3 = warheads3[n];
								new Explosion(ref this.ParentPlatform.m_Scenario, targetEntry.Target.GetLongitude(null), targetEntry.Target.GetLatitude(null), targetEntry.Target.GetLongitude(null), targetEntry.Target.GetLatitude(null), this.ParentPlatform.GetCurrentHeading(), this.ParentPlatform.GetCurrentAltitude_ASL(false), warhead3.DP, warhead3.DP, warhead3.warheadType, warhead3.ExplosivesType, null, null, null, null, new float?(10f), warhead3.ClusterBombDispersionAreaLength, warhead3.ClusterBombDispersionAreaWidth, (int)warhead3.NumberOfWarheads, 0f, 0).SetCurrentHeading(this.ParentPlatform.GetCurrentHeading());
							}
						}
						theWeaponRec.SetCurrentLoad(theWeaponRec.GetCurrentLoad() - 1);
						NumberOfWeaponsFired = 1;
						list.Add(weapon4);
						theWeaponRec.SetTimeToFire();
						if (!Information.IsNothing(theWeaponSalvo))
						{
							string guid3 = weapon4.GetGuid();
							ScenarioArrayUtil.AddStringToArray(ref theWeaponSalvo.WeaponObjectIDArray, guid3);
							goto IL_167C;
						}
						goto IL_167C;
					}
					UnguidedWeapon unguidedWeapon3 = new UnguidedWeapon(weapon, targetEntry.Target, this.ParentPlatform, this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), 0L);
					if (weapon.GetMaxRangeToTarget(this.ParentPlatform, targetEntry.Target, false, null, false) > 0f)
					{
						unguidedWeapon3.CEP_Surface = (float)((int)Math.Round((double)((float)weapon.CEPSurface * num / weapon.GetMaxRangeToTarget(this.ParentPlatform, targetEntry.Target, false, null, false))));
						unguidedWeapon3.CEP_Land = (float)((int)Math.Round((double)((float)weapon.CEP * num / weapon.GetMaxRangeToTarget(this.ParentPlatform, targetEntry.Target, false, null, false))));
					}
					Sensor director_2 = null;
					stringBuilder.Append(this.ParentPlatform.Name).Append(" attacks with unguided weapon: ").Append(theWeaponRec.GetWeapon(this.ParentPlatform.m_Scenario).Name).Append(". ");
					switch (targetEntry.Target.contactType)
					{
					case Contact_Base.ContactType.Air:
					case Contact_Base.ContactType.Missile:
						stringBuilder.Append("Nominal PoH: ").Append(unguidedWeapon3.AirPOK).Append("%. ");
						break;
					case Contact_Base.ContactType.Surface:
						stringBuilder.Append("Nominal CEP: ").Append(unguidedWeapon3.CEP_Surface).Append("m. ");
						break;
					case Contact_Base.ContactType.Submarine:
						stringBuilder.Append("Nominal PoH: ").Append(unguidedWeapon3.SubsurfacePOK).Append("%. ");
						break;
					case Contact_Base.ContactType.Facility_Fixed:
					case Contact_Base.ContactType.Facility_Mobile:
						stringBuilder.Append("Nominal CEP: ").Append(unguidedWeapon3.CEP_Land).Append("m. ");
						break;
					}
					this.method_48(ref targetEntry.Target, FiringMount, ref director_2);
					this.method_47(ref FiringMount, unguidedWeapon3, director_2, targetEntry.Target, theWeaponSalvo, stringBuilder);
					this.ModifyWeaponAccuracy(this.ParentPlatform, ref unguidedWeapon3, stringBuilder);
					num5 = ActiveUnit_Navigator.smethod_4(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), (double)this.ParentPlatform.GetCurrentHeading(), targetEntry.Target, unguidedWeapon3.GetCurrentSpeed());
					float? num7 = num5.HasValue ? new float?((float)num5.GetValueOrDefault()) : null;
					if (num7.HasValue)
					{
						unguidedWeapon3.SetCurrentHeading(num7.Value);
					}
					else
					{
						unguidedWeapon3.SetCurrentHeading(this.ParentPlatform.GetAI().GetAzimuth(targetEntry.Target));
					}
					unguidedWeapon3.SetSide(false, this.ParentPlatform.GetSide(false));
					this.ParentPlatform.m_Scenario.GetUnguidedWeapons().Add(unguidedWeapon3.GetGuid(), unguidedWeapon3);
					theWeaponRec.SetCurrentLoad(theWeaponRec.GetCurrentLoad() - 1);
					NumberOfWeaponsFired = 1;
					list.Add(unguidedWeapon3);
					theWeaponRec.SetTimeToFire();
					unguidedWeapon3.LaunchPoint = new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetCurrentAltitude_ASL(false));
					unguidedWeapon3.SetFiringParent(this.ParentPlatform);
					unguidedWeapon3.FiringParentName = this.ParentPlatform.GetGuid();
					if (!Information.IsNothing(theWeaponSalvo))
					{
						string guid4 = unguidedWeapon3.GetGuid();
						ScenarioArrayUtil.AddStringToArray(ref theWeaponSalvo.WeaponObjectIDArray, guid4);
					}
					switch (targetEntry.Target.contactType)
					{
					case Contact_Base.ContactType.Air:
					case Contact_Base.ContactType.Missile:
						stringBuilder.Append("Final PoH at fire/launch point: ").Append(unguidedWeapon3.AirPOK).Append("%. ");
						break;
					case Contact_Base.ContactType.Surface:
						stringBuilder.Append("Final CEP at fire/launch point: ").Append(unguidedWeapon3.CEP_Surface).Append("m. ");
						break;
					case Contact_Base.ContactType.Submarine:
						stringBuilder.Append("Final PoH at fire/launch point: ").Append(unguidedWeapon3.SubsurfacePOK).Append("%. ");
						break;
					case Contact_Base.ContactType.Facility_Fixed:
					case Contact_Base.ContactType.Facility_Mobile:
						stringBuilder.Append("Final CEP at fire/launch point: ").Append(unguidedWeapon3.CEP_Land).Append("m. ");
						break;
					}
					this.ParentPlatform.LogMessage(stringBuilder.ToString(), LoggedMessage.MessageType.UnguidedWeaponModifiers, 0, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
				}
				else
				{
					Weapon._WeaponType weaponType3 = weapon.GetWeaponType();
					bool flag;
					if (weaponType3 - Weapon._WeaponType.Decoy_Expendable <= 1)
					{
						Weapon weapon5 = weapon;
						Weapon weapon6 = (Weapon)targetEntry.Target.ActualUnit;
						flag = weapon5.method_245(ref weapon6, ref this.ParentPlatform);
					}
					else
					{
						new UnguidedWeapon(weapon, targetEntry.Target, this.ParentPlatform, this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), 0L);
						Weapon weapon7 = weapon;
						ActiveUnit actualUnit = targetEntry.Target.ActualUnit;
						ActiveUnit parentPlatform = this.ParentPlatform;
						Random random = GameGeneral.GetRandom();
						flag = weapon7.WeaponEndGame(actualUnit, ref parentPlatform.m_Scenario, true, ref random);
					}
					if (weapon.GetWeaponType() == Weapon._WeaponType.Decoy_Towed)
					{
						if (flag && GameGeneral.GetRandom().Next(0, 101) > 50)
						{
							theWeaponRec.SetCurrentLoad(theWeaponRec.GetCurrentLoad() - 1);
							NumberOfWeaponsFired = 1;
							list.Add(weapon);
						}
					}
					else
					{
						theWeaponRec.SetCurrentLoad(theWeaponRec.GetCurrentLoad() - 1);
						theWeaponRec.SetTimeToFire();
						NumberOfWeaponsFired = 1;
						list.Add(weapon);
					}
				}
				IL_167C:
				if (this.ParentPlatform.IsAircraft && weapon.WeightEmpty > 0 && ((Aircraft)this.ParentPlatform).GetLoadout().PayloadWeight > 0)
				{
					this.method_43();
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 100331", "");
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			checked
			{
				try
				{
					Side[] sides = this.ParentPlatform.m_Scenario.GetSides();
					for (int num8 = 0; num8 < sides.Length; num8++)
					{
						sides[num8].MarkAsHostile(this.ParentPlatform, targetEntry.Target, theWeaponRec);
					}
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ex8.Data.Add("Error at 100330", "");
					GameGeneral.LogException(ref ex8);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				try
				{
					if (NumberOfWeaponsFired > 0)
					{
						this.ParentPlatform.GetSide(false).m_AAR.AddToExpenditures(theWeaponRec.WeapID, NumberOfWeaponsFired);
						ActiveUnit_Weaponry.Delegate5 @delegate = ActiveUnit_Weaponry.delegate5_0;
						if (@delegate != null)
						{
							@delegate(this.ParentPlatform.m_Scenario, this.ParentPlatform, weapon);
						}
					}
				}
				catch (Exception ex9)
				{
					ProjectData.SetProjectError(ex9);
					Exception ex10 = ex9;
					ex10.Data.Add("Error at 100328", "");
					GameGeneral.LogException(ref ex10);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return list;
			}
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x00175410 File Offset: 0x00173610
		public void method_43()
		{
			try
			{
				if (!Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
				{
					Loadout loadout = ((Aircraft)this.ParentPlatform).GetLoadout();
					DBFunctions.smethod_50(ref this.ParentPlatform.m_Scenario, ref loadout);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100334", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x001754A8 File Offset: 0x001736A8
		private void method_44(Weapon weapon_7, Contact contact_0)
		{
			checked
			{
				try
				{
					if (!Information.IsNothing(contact_0) && weapon_7.IsGuidedWeapon_RV_HGV() && contact_0.contactType == Contact_Base.ContactType.Submarine && weapon_7.GetNoneMCMSensors().Length > 0 && weapon_7.method_215())
					{
						Sensor[] noneMCMSensors = weapon_7.GetNoneMCMSensors();
						ScenarioArrayUtil.NewSensorArray(ref noneMCMSensors);
						weapon_7.SetDefaultGuidanceMethod();
					}
					if (!Information.IsNothing(contact_0) && !Information.IsNothing(contact_0.ActualUnit) && weapon_7.IsGuidedWeapon_RV_HGV() && contact_0.contactType == Contact_Base.ContactType.Facility_Fixed && weapon_7.GetNoneMCMSensors().Length > 0)
					{
						bool flag = false;
						Sensor[] noneMCMSensors = weapon_7.GetNoneMCMSensors();
						for (int i = 0; i < noneMCMSensors.Length; i++)
						{
							if (noneMCMSensors[i].IsTargetDetectableByMe(contact_0.ActualUnit))
							{
								goto IL_C4;
							}
						}
						if (!flag)
						{
							Sensor[] noneMCMSensors2 = weapon_7.GetNoneMCMSensors();
							ScenarioArrayUtil.NewSensorArray(ref noneMCMSensors2);
							weapon_7.SetDefaultGuidanceMethod();
						}
					}
					IL_C4:;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100335", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x001755CC File Offset: 0x001737CC
		private void FireWeapon(float elapsedTime, ref ActiveUnit FiringUnit, ref Weapon theWeapon, int WeaponID, ref Contact theTarget, float InitialHeading = 0f, ActiveUnit.Throttle ThrottleSetting = ActiveUnit.Throttle.Cruise, SonarEnvironment._SonobuoyDepthSetting SonobuoyDepthSetting = SonarEnvironment._SonobuoyDepthSetting.Shallow, WeaponSalvo ParentSalvo = null)
		{
			try
			{
				Weapon.smethod_6(theWeapon, FiringUnit.m_Scenario);
				FiringUnit.m_Scenario.UnitsAutoIncrement = FiringUnit.m_Scenario.UnitsAutoIncrement + 1;
				theWeapon.Name = theWeapon.Name + " #" + Conversions.ToString(FiringUnit.m_Scenario.UnitsAutoIncrement);
				theWeapon.SetSide(false, FiringUnit.GetSide(false));
				theWeapon.GetWeaponAI().SetPrimaryTarget(theTarget);
				if (!Information.IsNothing(theTarget))
				{
					theWeapon.GetWeaponAI().SetPrimaryTargetType(theTarget.contactType);
				}
				if (FiringUnit.GetCurrentSpeed() > 0f)
				{
					theWeapon.SetLongitude(null, FiringUnit.GetLongitude(elapsedTime));
					theWeapon.SetLatitude(null, FiringUnit.GetLatitude(elapsedTime));
				}
				else
				{
					theWeapon.SetLongitude(null, FiringUnit.GetLongitude(null));
					theWeapon.SetLatitude(null, FiringUnit.GetLatitude(null));
				}
				theWeapon.SetAltitude_ASL(true, FiringUnit.GetCurrentAltitude_ASL(false));
				if (theWeapon.IsTorpedo() && theWeapon.GetMaxThrottleAvailable() >= ActiveUnit.Throttle.Full)
				{
					Scenario scenario = this.ParentPlatform.m_Scenario;
					int dBID = theWeapon.DBID;
					ActiveUnit parentPlatform = this.ParentPlatform;
					double longitude = this.ParentPlatform.GetLongitude(null);
					double latitude = this.ParentPlatform.GetLatitude(null);
					float launchAltitude = (float)((int)Math.Round((double)this.ParentPlatform.GetCurrentAltitude_ASL(false)));
					int launchSpeed = (int)Math.Round((double)this.ParentPlatform.GetCurrentSpeed());
					double longitude2 = theTarget.GetLongitude(null);
					double latitude2 = theTarget.GetLatitude(null);
					float currentHeading = theTarget.GetCurrentHeading();
					bool heading_Known = theTarget.Heading_Known;
					int targetSpeed = (int)Math.Round((double)theTarget.GetCurrentSpeed());
					bool speed_Known = theTarget.Speed_Known;
					float currentAltitude_ASL = theTarget.GetCurrentAltitude_ASL(false);
					bool altitude_Known = theTarget.Altitude_Known;
					GeoPoint geoPoint = null;
					string text = null;
					if (Operators.CompareString(ActiveUnit_Weaponry.smethod_3(scenario, dBID, parentPlatform, longitude, latitude, launchAltitude, launchSpeed, longitude2, latitude2, currentHeading, heading_Known, targetSpeed, speed_Known, currentAltitude_ASL, altitude_Known, ref geoPoint, ref text, 0f, ActiveUnit.Throttle.Full, (int)Math.Round((double)((float)theWeapon.GetFuelRecs()[0].MaxQuantity) * 0.89999999850988388), null, null), "OK", false) == 0)
					{
						ThrottleSetting = ActiveUnit.Throttle.Full;
					}
				}
				theWeapon.SetThrottle(ThrottleSetting, null);
				float currentSpeed = (float)theWeapon.GetWeaponKinematics().GetSpeed(theWeapon.GetCurrentAltitude_ASL(false), ThrottleSetting);
				if (theWeapon.IsTorpedo())
				{
					theWeapon.SetCurrentSpeed(currentSpeed);
				}
				else if (theWeapon.GetWeaponType() == Weapon._WeaponType.GuidedProjectile)
				{
					theWeapon.SetCurrentSpeed(currentSpeed);
				}
				else
				{
					theWeapon.SetCurrentSpeed(FiringUnit.GetCurrentSpeed() + theWeapon.GetWeaponKinematics().vmethod_8(theWeapon.GetThrottle(), this.ParentPlatform.GetCurrentAltitude_ASL(false), this.ParentPlatform.GetCurrentSpeed()));
				}
				if (theWeapon.GetWeaponType() == Weapon._WeaponType.Sonobuoy)
				{
					theWeapon.SetCurrentSpeed(0f);
				}
				if (Information.IsNothing(theWeapon.GetDesiredSpeed()))
				{
					theWeapon.SetDesiredSpeed(theWeapon.GetCurrentSpeed());
				}
				this.method_44(theWeapon, theTarget);
				if (InitialHeading == 0f)
				{
					if (FiringUnit.IsAircraft)
					{
						theWeapon.SetCurrentHeading(FiringUnit.GetCurrentHeading());
					}
					else if (FiringUnit.IsSubmarine)
					{
						if (theWeapon.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
						{
							theWeapon.SetCurrentHeading(Math2.GetAzimuth(FiringUnit.GetLatitude(null), FiringUnit.GetLongitude(null), theWeapon.GetWeaponAI().GetPrimaryTarget().GetLatitude(null), theWeapon.GetWeaponAI().GetPrimaryTarget().GetLongitude(null)));
						}
						else
						{
							theWeapon.SetCurrentHeading(FiringUnit.GetCurrentHeading());
						}
					}
					else
					{
						theWeapon.SetCurrentHeading(Math2.GetAzimuth(FiringUnit.GetLatitude(null), FiringUnit.GetLongitude(null), theWeapon.GetWeaponAI().GetPrimaryTarget().GetLatitude(null), theWeapon.GetWeaponAI().GetPrimaryTarget().GetLongitude(null)));
					}
				}
				else
				{
					theWeapon.SetCurrentHeading(InitialHeading);
				}
				if (theWeapon.GetDesiredHeading(ActiveUnit._TurnRate.const_0) == 0f)
				{
					theWeapon.SetDesiredHeading(ActiveUnit._TurnRate.const_0, theWeapon.GetCurrentHeading());
				}
				if (theWeapon.IsGuidedProjectile() && !FiringUnit.IsAircraft)
				{
					double? num = ActiveUnit_Navigator.smethod_4(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), (double)this.ParentPlatform.GetCurrentHeading(), theWeapon.GetWeaponAI().GetPrimaryTarget(), theWeapon.GetCurrentSpeed());
					if (!Information.IsNothing(num))
					{
						theWeapon.SetCurrentHeading((float)num.Value);
						theWeapon.SetDesiredHeading(ActiveUnit._TurnRate.const_0, (float)num.Value);
					}
				}
				checked
				{
					if (!Information.IsNothing(theWeapon.GetWeaponAI().GetPrimaryTarget()) && theWeapon.GetCommDevices().Count<CommDevice>() == 0 && theWeapon.GetWeaponAI().GetPrimaryTarget().IsFixed() && theWeapon.weaponCode.Weapon_INS_w_GPSNavigation && !theWeapon.weaponTarget.IsRadar && theWeapon.GetWeaponAI().GetPrimaryTarget().contactType != Contact_Base.ContactType.ActivationPoint && theWeapon.weaponTarget.IsSurfaceShip)
					{
						Sensor[] noneMCMSensors = theWeapon.GetNoneMCMSensors();
						for (int i = 0; i < noneMCMSensors.Length; i++)
						{
							if (noneMCMSensors[i].sensorType == Sensor.SensorType.Radar)
							{
								theWeapon.method_219(false);
								break;
							}
						}
					}
					if (!Information.IsNothing(theTarget) && theTarget.contactType != Contact_Base.ContactType.ActivationPoint && !Information.IsNothing(ParentSalvo) && !Information.IsNothing(ParentSalvo.PlottedCourse))
					{
						if (ParentSalvo.PlottedCourse.Count<Waypoint>() > 0)
						{
							float num2 = Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), ParentSalvo.PlottedCourse[0].GetLatitude(), ParentSalvo.PlottedCourse[0].GetLongitude());
							unchecked
							{
								int num3 = ParentSalvo.PlottedCourse.Count<Waypoint>() - 2;
								for (int j = 0; j <= num3; j++)
								{
									num2 += Math2.GetDistance(ParentSalvo.PlottedCourse[j].GetLatitude(), ParentSalvo.PlottedCourse[j].GetLongitude(), ParentSalvo.PlottedCourse[j + 1].GetLatitude(), ParentSalvo.PlottedCourse[j + 1].GetLongitude());
								}
								num2 += Math2.GetDistance(ParentSalvo.PlottedCourse.Last<Waypoint>().GetLatitude(), ParentSalvo.PlottedCourse.Last<Waypoint>().GetLongitude(), theTarget.GetLatitude(null), theTarget.GetLongitude(null));
							}
							if (theWeapon.GetMaxRangeToTarget(FiringUnit, theTarget, false, FiringUnit.m_Doctrine, false) < num2)
							{
								theWeapon.GetWeaponNavigator().method_56(FiringUnit);
							}
							else
							{
								Waypoint[] plottedCourse = ParentSalvo.PlottedCourse;
								for (int k = 0; k < plottedCourse.Length; k++)
								{
									Waypoint waypoint = plottedCourse[k];
									theWeapon.GetWeaponNavigator().AddWaypoint(new Waypoint(waypoint.GetLongitude(), waypoint.GetLatitude(), waypoint.waypointType, Waypoint._Creator.const_2, Waypoint._Category.const_0));
								}
							}
						}
						else if (theWeapon.method_136())
						{
							theWeapon.GetWeaponNavigator().method_56(FiringUnit);
							Waypoint[] plottedCourse2 = theWeapon.GetWeaponNavigator().GetPlottedCourse();
							for (int l = 0; l < plottedCourse2.Length; l++)
							{
								Waypoint waypoint2 = plottedCourse2[l];
								ScenarioArrayUtil.AddWaypoint(ref ParentSalvo.PlottedCourse, new Waypoint(waypoint2.GetLongitude(), waypoint2.GetLatitude(), waypoint2.waypointType, Waypoint._Creator.const_2, Waypoint._Category.const_0));
							}
						}
					}
					if (!Information.IsNothing(theTarget) && (theWeapon.method_187() || theWeapon.GetGuidanceMethod() == Weapon._GuidanceMethod.InertiallyGuided))
					{
						float num4 = theTarget.GetCurrentAltitude_ASL(false);
						float minAltitude = theWeapon.GetWeaponKinematics().GetMinAltitude();
						float maxAltitude = theWeapon.GetWeaponKinematics().GetMaxAltitude();
						if (num4 > maxAltitude)
						{
							num4 = maxAltitude;
						}
						if (num4 < minAltitude)
						{
							num4 = minAltitude;
						}
						theWeapon.GetWeaponNavigator().method_57((float)theWeapon.GetWeaponKinematics().GetSpeed(num4, ThrottleSetting), FiringUnit.IsAircraft && theWeapon.IsTorpedo());
						if (!Information.IsNothing(ParentSalvo) && ParentSalvo.ASMode == Weapon._ASMode.HighAltitudeDetonation)
						{
							if (theWeapon.CruiseAltitude > 0f)
							{
								theWeapon.GetWeaponNavigator().GetPlottedCourse()[0].SetAltitude(theWeapon.CruiseAltitude);
							}
							else if (theWeapon.GetCruiseAltitude_ASL() > 0f)
							{
								theWeapon.GetWeaponNavigator().GetPlottedCourse()[0].SetAltitude(theWeapon.GetCruiseAltitude_ASL());
							}
							else
							{
								theWeapon.GetWeaponNavigator().GetPlottedCourse()[0].SetAltitude(theWeapon.GetWeaponKinematics().GetMaxAltitude());
							}
						}
						if (FiringUnit.IsWeapon && ((Weapon)FiringUnit).weaponCode.BallisticMissile && FiringUnit.GetNavigator().HasPlottedCourse() && theWeapon.GetWeaponNavigator().HasPlottedCourse())
						{
							theWeapon.GetWeaponNavigator().GetPlottedCourse().Last<Waypoint>().SetAltitude(FiringUnit.GetNavigator().GetPlottedCourse().Last<Waypoint>().GetAltitude());
						}
						if (theWeapon.GetWeaponNavigator().HasWaypointOtherPathfindingPoint())
						{
							theWeapon.SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.GetAzimuth(theWeapon.GetLatitude(null), theWeapon.GetLongitude(null), theWeapon.GetWeaponNavigator().GetPlottedCourse()[0].GetLatitude(), theWeapon.GetWeaponNavigator().GetPlottedCourse()[0].GetLongitude()));
						}
					}
					if (theWeapon.GetWeaponType() == Weapon._WeaponType.Sonobuoy)
					{
						if (SonobuoyDepthSetting == SonarEnvironment._SonobuoyDepthSetting.Shallow)
						{
							theWeapon.SetAltitude_ASL(true, -40f);
							theWeapon.DetonationDelay = 120f;
						}
						else
						{
							SonarEnvironment.Thermocline layer = SonarEnvironment.GetLayer(theWeapon.GetLatitude(null), theWeapon.GetLongitude(null), theWeapon.GetTerrainElevation(false, false, false));
							theWeapon.SetAltitude_ASL(true, (float)(unchecked(layer.Bottom - 20)));
							theWeapon.DetonationDelay = 240f;
						}
						theWeapon.SetDesiredAltitude(theWeapon.GetCurrentAltitude_ASL(false));
					}
					if (theWeapon.GetGuidanceMethod() == Weapon._GuidanceMethod.TimeSharedSemiActiveMidCoursePlusActiveTerminalGuidance)
					{
						theWeapon.SetDataLinkParent(FiringUnit);
					}
					Warhead[] warheads = theWeapon.m_Warheads;
					for (int m = 0; m < warheads.Length; m++)
					{
						Warhead warhead = warheads[m];
						if (warhead.warheadType == Warhead.WarheadType.Weapon)
						{
							warhead.GetWeaponFromDP(theWeapon.m_Scenario).GetWeaponAI().SetPrimaryTarget(theWeapon.GetWeaponAI().GetPrimaryTarget());
							warhead.GetWeaponFromDP(theWeapon.m_Scenario).GetWeaponAI().SetPrimaryTargetType(theWeapon.GetWeaponAI().GetPrimaryTarget().contactType);
						}
					}
					if (FiringUnit.IsAircraft && theWeapon.IsTorpedo())
					{
						Sensor[] noneMCMSensors2 = theWeapon.GetNoneMCMSensors();
						for (int n = 0; n < noneMCMSensors2.Length; n++)
						{
							Sensor sensor = noneMCMSensors2[n];
							if (sensor.IsActiveCapable())
							{
								sensor.TurnOn();
							}
						}
					}
					if (theWeapon.IsMREV_GuidedBallisticMissile())
					{
						theWeapon.m_Warheads[0].GetWeaponFromDP(FiringUnit.m_Scenario).GetWeaponAI().SetPrimaryTarget(theWeapon.GetWeaponAI().GetPrimaryTarget());
						theWeapon.m_Warheads[0].GetWeaponFromDP(FiringUnit.m_Scenario).GetWeaponAI().SetPrimaryTargetType(theWeapon.GetWeaponAI().GetPrimaryTarget().contactType);
						theWeapon.GetWeaponAI().method_90();
					}
					if (theWeapon.m_Warheads.Any<Warhead>() && theWeapon.m_Warheads[0].warheadType == Warhead.WarheadType.EMP_Directed)
					{
						Contact[] targets = FiringUnit.GetAI().GetTargets();
						for (int num5 = 0; num5 < targets.Length; num5++)
						{
							Contact contact = targets[num5];
							if (contact != theTarget && FiringUnit.GetAI().method_63(theTarget))
							{
								theWeapon.GetWeaponAI().TargetingContact(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
							}
						}
					}
				}
				if (theWeapon.weaponCode.BallisticMissile && theWeapon.m_Warheads.Any<Warhead>() && theWeapon.m_Warheads[0].warheadType == Warhead.WarheadType.Weapon)
				{
					Weapon weaponFromDP = theWeapon.m_Warheads[0].GetWeaponFromDP(this.ParentPlatform.m_Scenario);
					if (theWeapon.GetCruiseAltitude_ASL() > 0f)
					{
						float maxAltitude2 = weaponFromDP.GetWeaponKinematics().GetMaxAltitude();
						if (theWeapon.GetCruiseAltitude_ASL() > maxAltitude2)
						{
							theWeapon.SetCruiseAltitude_ASL(maxAltitude2 - 10f);
						}
					}
				}
				theWeapon.SetFiringParent(FiringUnit);
				if (theWeapon.IsOfAirLaunchedGuidedWeapon() && this.ParentPlatform.IsAircraft && !((Aircraft)this.ParentPlatform).IsRotaryWingAircraft())
				{
					theWeapon.SetPitch(this.ParentPlatform.GetPitch());
				}
				this.method_49(ref FiringUnit, ref theWeapon, ref theTarget);
				this.method_50(ref FiringUnit, ref theWeapon, ref theTarget);
				theWeapon.LaunchPoint = new GeoPoint(theWeapon.GetLongitude(null), theWeapon.GetLatitude(null), theWeapon.GetCurrentAltitude_ASL(false));
				FiringUnit.m_Scenario.AddUnit(theWeapon);
				this.ExportWeaponFired(theTarget, theWeapon);
				ActiveUnit_Kinematics.ExportUnitPositions(theWeapon);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100336", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x0017643C File Offset: 0x0017463C
		public void ExportWeaponFired(Contact contact_0, Weapon weapon_7)
		{
			if (!Information.IsNothing(contact_0))
			{
				foreach (IEventExporter current in this.ParentPlatform.m_Scenario.GetEventExporters())
				{
					if (current.IsExportWeaponFired())
					{
						Dictionary<string, Tuple<Type, string>> dictionary = new Dictionary<string, Tuple<Type, string>>();
						dictionary.Add("TimelineID", new Tuple<Type, string>(typeof(string), this.ParentPlatform.m_Scenario.TimelineID));
						if (current.IsUseZeroHour())
						{
							TimeSpan timeSpan = this.ParentPlatform.m_Scenario.GetCurrentTime(false).Subtract(this.ParentPlatform.m_Scenario.ZeroHour);
							dictionary.Add("Time", new Tuple<Type, string>(typeof(TimeSpan), timeSpan.ToString("c")));
						}
						else
						{
							dictionary.Add("Time", new Tuple<Type, string>(typeof(DateTime), this.ParentPlatform.m_Scenario.GetCurrentTime(false).ToString("MM/dd/yyyy HH:mm:ss") + "." + this.ParentPlatform.m_Scenario.GetCurrentTime(false).Millisecond.ToString("D3")));
						}
						dictionary.Add("FiringUnitID", new Tuple<Type, string>(typeof(string), this.ParentPlatform.GetGuid()));
						dictionary.Add("FiringUnitName", new Tuple<Type, string>(typeof(string), this.ParentPlatform.Name));
						dictionary.Add("FiringUnitClass", new Tuple<Type, string>(typeof(string), this.ParentPlatform.UnitClass));
						dictionary.Add("FiringUnitSide", new Tuple<Type, string>(typeof(string), this.ParentPlatform.GetSide(false).GetSideName()));
						dictionary.Add("FiringUnitLongitude", new Tuple<Type, string>(typeof(double), this.ParentPlatform.GetLongitude(null).ToString()));
						dictionary.Add("FiringUnitLatitude", new Tuple<Type, string>(typeof(double), this.ParentPlatform.GetLatitude(null).ToString()));
						dictionary.Add("FiringUnitCourse", new Tuple<Type, string>(typeof(float), this.ParentPlatform.GetCurrentHeading().ToString()));
						dictionary.Add("FiringUnitSpeed_kts", new Tuple<Type, string>(typeof(float), this.ParentPlatform.GetCurrentSpeed().ToString()));
						dictionary.Add("FiringUnitAltitude_m", new Tuple<Type, string>(typeof(float), this.ParentPlatform.GetCurrentAltitude_ASL(false).ToString()));
						dictionary.Add("FiringUnitAGL_m", new Tuple<Type, string>(typeof(float), this.ParentPlatform.GetAltitude_AGL().ToString()));
						dictionary.Add("WeaponID", new Tuple<Type, string>(typeof(string), weapon_7.GetGuid()));
						dictionary.Add("WeaponClass", new Tuple<Type, string>(typeof(string), weapon_7.UnitClass));
						dictionary.Add("WeaponType", new Tuple<Type, string>(typeof(string), weapon_7.GetUnitTypeName()));
						dictionary.Add("TargetContactID", new Tuple<Type, string>(typeof(string), contact_0.GetGuid()));
						dictionary.Add("TargetContactLongitude", new Tuple<Type, string>(typeof(double), contact_0.GetLongitude(null).ToString()));
						dictionary.Add("TargetContactLatitude", new Tuple<Type, string>(typeof(double), contact_0.GetLatitude(null).ToString()));
						dictionary.Add("TargetContactHeading", new Tuple<Type, string>(typeof(double), Conversions.ToString(Interaction.IIf(contact_0.Heading_Known, contact_0.GetCurrentHeading(), "Unknown"))));
						dictionary.Add("TargetContactSpeed", new Tuple<Type, string>(typeof(float), Conversions.ToString(Interaction.IIf(contact_0.Speed_Known, contact_0.GetCurrentSpeed(), "Unknown"))));
						dictionary.Add("TargetContactAltitude", new Tuple<Type, string>(typeof(float), Conversions.ToString(Interaction.IIf(contact_0.Altitude_Known, contact_0.GetCurrentAltitude_ASL(false).ToString(), "Unknown"))));
						dictionary.Add("TargetContactRangeHoriz_nm", new Tuple<Type, string>(typeof(float), this.ParentPlatform.GetHorizontalRange(contact_0).ToString()));
						dictionary.Add("TargetContactRangeSlant_nm", new Tuple<Type, string>(typeof(float), this.ParentPlatform.GetSlantRange(contact_0, 0f).ToString()));
						if (!Information.IsNothing(contact_0.ActualUnit))
						{
							dictionary.Add("TargetContactActualUnitID", new Tuple<Type, string>(typeof(string), contact_0.ActualUnit.GetGuid()));
							dictionary.Add("TargetContactActualUnitName", new Tuple<Type, string>(typeof(string), contact_0.ActualUnit.Name));
							dictionary.Add("TargetContactActualUnitClass", new Tuple<Type, string>(typeof(string), contact_0.ActualUnit.UnitClass));
							dictionary.Add("TargetContactActualUnitSide", new Tuple<Type, string>(typeof(string), contact_0.ActualUnit.GetSide(false).GetSideName()));
						}
						else
						{
							dictionary.Add("TargetContactActualUnitID", new Tuple<Type, string>(typeof(string), "-"));
							dictionary.Add("TargetContactActualUnitName", new Tuple<Type, string>(typeof(string), contact_0.Name));
							dictionary.Add("TargetContactActualUnitClass", new Tuple<Type, string>(typeof(string), "-"));
							dictionary.Add("TargetContactActualUnitSide", new Tuple<Type, string>(typeof(string), "-"));
						}
						current.ExportEvent(ExportedEventType.WeaponFired, dictionary, this.ParentPlatform.m_Scenario);
					}
				}
			}
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x00176AB0 File Offset: 0x00174CB0
		public static void smethod_1(Unit unit_0, bool bool_7)
		{
			if (!Information.IsNothing(unit_0) && unit_0.IsAircraft)
			{
				if (bool_7)
				{
					((Aircraft)unit_0).GetAircraftWeaponry().DropSonobuoys(((ActiveUnit)unit_0).m_Scenario.GetTimeStep(), new SonarEnvironment._SonobuoyDepthSetting?(SonarEnvironment._SonobuoyDepthSetting.Shallow), new bool?(false));
				}
				else
				{
					((Aircraft)unit_0).GetAircraftWeaponry().DropSonobuoys(((ActiveUnit)unit_0).m_Scenario.GetTimeStep(), new SonarEnvironment._SonobuoyDepthSetting?(SonarEnvironment._SonobuoyDepthSetting.Deep), new bool?(false));
				}
			}
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x00176B34 File Offset: 0x00174D34
		public static void smethod_2(Unit unit_0, bool bool_7)
		{
			if (!Information.IsNothing(unit_0) && unit_0.IsAircraft)
			{
				if (bool_7)
				{
					((Aircraft)unit_0).GetAircraftWeaponry().DropSonobuoys(((ActiveUnit)unit_0).m_Scenario.GetTimeStep(), new SonarEnvironment._SonobuoyDepthSetting?(SonarEnvironment._SonobuoyDepthSetting.Shallow), new bool?(true));
				}
				else
				{
					((Aircraft)unit_0).GetAircraftWeaponry().DropSonobuoys(((ActiveUnit)unit_0).m_Scenario.GetTimeStep(), new SonarEnvironment._SonobuoyDepthSetting?(SonarEnvironment._SonobuoyDepthSetting.Deep), new bool?(true));
				}
			}
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x00176BB8 File Offset: 0x00174DB8
		private void method_47(ref Mount mount_0, UnguidedWeapon unguidedWeapon_0, Sensor director_, Contact contact_0, WeaponSalvo WeaponSalvo_, StringBuilder stringBuilder_0)
		{
			try
			{
				bool flag = false;
				bool flag2 = false;
				if (this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.DetailedGunFireControl) && !this.ParentPlatform.IsAircraft && !Information.IsNothing(mount_0))
				{
					if (mount_0.LocalControl && mount_0.MountDirectorSet.Count == 0)
					{
						flag2 = true;
					}
					if (Information.IsNothing(director_))
					{
						if (!Information.IsNothing(stringBuilder_0))
						{
							stringBuilder_0.Append("Not using any director (manual aiming). ");
						}
						flag = true;
						if (contact_0.GetCurrentSpeed() > 0f && contact_0.Age == 0f && !Information.IsNothing(contact_0.ActualUnit) && unguidedWeapon_0.GetWeaponType() != Weapon._WeaponType.Laser)
						{
							double num = (double)contact_0.ActualUnit.GetKinematics().GetSpeed(contact_0.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Flank);
							if (num > 0.0)
							{
								double num2 = (double)contact_0.GetCurrentSpeed() / num;
								if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Target is moving at ").Append((int)Math.Round(100.0 * num2)).Append("% of its maximum speed; accuracy adjusted to same. ");
								}
								unguidedWeapon_0.CEP_Land = (float)((double)unguidedWeapon_0.CEP_Land * (1.0 + num2));
								unguidedWeapon_0.CEP_Surface = (float)((double)unguidedWeapon_0.CEP_Surface * (1.0 + num2));
							}
						}
					}
					else if (unguidedWeapon_0.GetWeaponType() != Weapon._WeaponType.Laser)
					{
						Sensor.SensorType sensorType = director_.sensorType;
						if (sensorType != Sensor.SensorType.Radar)
						{
							if (sensorType - Sensor.SensorType.Visual > 1)
							{
								if (sensorType == Sensor.SensorType.LaserDesignator)
								{
									unguidedWeapon_0.CEP_Surface = (float)((double)unguidedWeapon_0.CEP_Surface * 1.2);
									unguidedWeapon_0.CEP_Land = (float)((double)unguidedWeapon_0.CEP_Land * 1.2);
									unguidedWeapon_0.AirPOK = (float)((double)((long)Math.Round((double)unguidedWeapon_0.AirPOK)) / 1.2);
									if (!Information.IsNothing(stringBuilder_0))
									{
										stringBuilder_0.Append("Director (").Append(director_.Name).Append(") is laser; accuracy decreased by 20%. ");
									}
								}
							}
							else
							{
								unguidedWeapon_0.CEP_Surface = (float)((double)unguidedWeapon_0.CEP_Surface * 1.5);
								unguidedWeapon_0.CEP_Land = (float)((double)unguidedWeapon_0.CEP_Land * 1.5);
								unguidedWeapon_0.AirPOK = (float)((double)unguidedWeapon_0.AirPOK / 1.5);
								if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Director (").Append(director_.Name).Append(") is visual/EO/IR; accuracy decreased by 50%. ");
								}
							}
						}
						else if (!Information.IsNothing(stringBuilder_0))
						{
							stringBuilder_0.Append("Director (").Append(director_.Name).Append(") is radar; accuracy unaffected. ");
						}
					}
					if (!flag && !Information.IsNothing(WeaponSalvo_))
					{
						WeaponSalvo.Shooter[] shooters = WeaponSalvo_.m_Shooters;
						for (int i = 0; i < shooters.Length; i = checked(i + 1))
						{
							WeaponSalvo.Shooter shooter = shooters[i];
							if (Operators.CompareString(shooter.ShooterObjectID, this.ParentPlatform.GetGuid(), false) == 0)
							{
								int quantityFired = shooter.QuantityFired;
								if (quantityFired >= 4)
								{
									if (quantityFired < 8)
									{
										unguidedWeapon_0.CEP_Surface = (float)((double)unguidedWeapon_0.CEP_Surface * 0.9);
										unguidedWeapon_0.CEP_Land = (float)((double)unguidedWeapon_0.CEP_Land * 0.9);
										unguidedWeapon_0.AirPOK = (float)((double)unguidedWeapon_0.AirPOK * 1.1);
										if (!Information.IsNothing(stringBuilder_0))
										{
											stringBuilder_0.Append("A few (less than 8) rounds already fired in salvo; accuracy improving slightly. ");
										}
									}
									else if (quantityFired < 12)
									{
										unguidedWeapon_0.CEP_Surface = (float)((double)unguidedWeapon_0.CEP_Surface * 0.8);
										unguidedWeapon_0.CEP_Land = (float)((double)unguidedWeapon_0.CEP_Land * 0.8);
										unguidedWeapon_0.AirPOK = (float)((double)unguidedWeapon_0.AirPOK * 1.25);
										if (!Information.IsNothing(stringBuilder_0))
										{
											stringBuilder_0.Append("Some (less than 12) rounds already fired in salvo; accuracy improving measurably. ");
										}
									}
									else if (quantityFired < 15)
									{
										unguidedWeapon_0.CEP_Surface = (float)((double)unguidedWeapon_0.CEP_Surface * 0.7);
										unguidedWeapon_0.CEP_Land = (float)((double)unguidedWeapon_0.CEP_Land * 0.7);
										unguidedWeapon_0.AirPOK = (float)((double)unguidedWeapon_0.AirPOK * 1.5);
										if (!Information.IsNothing(stringBuilder_0))
										{
											stringBuilder_0.Append("Quite a few (less than 15) rounds already fired in salvo; accuracy improving substantially. ");
										}
									}
									else
									{
										unguidedWeapon_0.CEP_Surface = (float)((double)unguidedWeapon_0.CEP_Surface * 0.2);
										unguidedWeapon_0.CEP_Land = (float)((double)unguidedWeapon_0.CEP_Land * 0.2);
										unguidedWeapon_0.AirPOK *= 2f;
										if (!Information.IsNothing(stringBuilder_0))
										{
											stringBuilder_0.Append("Lots of rounds already fired in salvo; accuracy improving tremendously. ");
										}
									}
								}
							}
						}
					}
					if (flag && !flag2)
					{
						unguidedWeapon_0.CEP_Surface *= 3f;
						unguidedWeapon_0.CEP_Land *= 3f;
						unguidedWeapon_0.AirPOK /= 3f;
						unguidedWeapon_0.SubsurfacePOK /= 3f;
						if (!Information.IsNothing(stringBuilder_0))
						{
							stringBuilder_0.Append("Aiming manually in system not primarily designed for local control; accuracy sharply reduced. ");
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100337", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x00177180 File Offset: 0x00175380
		private void method_48(ref Contact contact_0, Mount mount_0, ref Sensor sensor_0)
		{
			if (!Information.IsNothing(mount_0))
			{
				try
				{
					List<Sensor> list = this.method_27(mount_0, contact_0);
					if (list.Count > 0)
					{
						IEnumerable<Sensor> source = list.Where(ActiveUnit_Weaponry.SensorIsRadarFilterFunc9);
						if (source.Count<Sensor>() > 0)
						{
							sensor_0 = source.ElementAtOrDefault(0);
							sensor_0.AddTargetsTrackedForFireControl(ref contact_0);
						}
						else
						{
							IEnumerable<Sensor> source2 = list.Where(ActiveUnit_Weaponry.SensorFunc10);
							if (source2.Count<Sensor>() > 0)
							{
								sensor_0 = source2.ElementAtOrDefault(0);
								sensor_0.AddTargetsTrackedForFireControl(ref contact_0);
							}
							else
							{
								IEnumerable<Sensor> source3 = list.Where(ActiveUnit_Weaponry.SensorFunc11);
								if (source3.Count<Sensor>() > 0)
								{
									sensor_0 = source3.ElementAtOrDefault(0);
									sensor_0.AddTargetsTrackedForFireControl(ref contact_0);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100338", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x0017728C File Offset: 0x0017548C
		private bool method_49(ref ActiveUnit activeUnit_1, ref Weapon weapon_7, ref Contact contact_0)
		{
			bool flag = false;
			checked
			{
				bool result;
				if (Information.IsNothing(contact_0))
				{
					flag = false;
				}
				else
				{
					try
					{
						if (weapon_7.weaponCode.IlluminateAtLaunch)
						{
							Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
							bool? flag2 = null;
							bool? flag3 = null;
							bool? flag4 = null;
							bool? flag5 = null;
							Sensor[] noneMCMSensors = activeUnit_1.GetNoneMCMSensors();
							for (int i = 0; i < noneMCMSensors.Length; i++)
							{
								Sensor sensor = noneMCMSensors[i];
								if (sensor.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && sensor.IsDirectorFor(ref weapon_7))
								{
									List<ActiveUnit> list = null;
									if (sensor.sensorType == Sensor.SensorType.Radar && Information.IsNothing(list))
									{
										list = this.ParentPlatform.GetSensory().GetAffectingJammers(false);
									}
									if (sensor.WeaponGuidanceAttempt(activeUnit_1, contact_0.ActualUnit, activeUnit_1.GetSlantRange(contact_0, 0f), list, this.ParentPlatform.IsShip, false, ref flag3, ref flag4, ref lOS_Exists_Visual, ref flag5) == Sensor._DetectionAttemptResult.Success)
									{
										if (!sensor.IsTargetTracked(ref contact_0))
										{
											if (!sensor.IsFireChannelsEnough())
											{
												goto IL_108;
											}
											sensor.AddTargetsTrackedForFireControl(ref contact_0);
										}
										if (!sensor.SemiActiveGuidedWeaponList.Contains(weapon_7))
										{
											sensor.SemiActiveGuidedWeaponList.Add(weapon_7);
											weapon_7.SetDirector(sensor);
										}
										if (!sensor.IsEmmitting())
										{
											sensor.TurnOn();
										}
										flag = true;
										result = true;
										return result;
									}
								}
								IL_108:;
							}
						}
						flag = false;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100339", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x00177464 File Offset: 0x00175664
		private bool method_50(ref ActiveUnit activeUnit_1, ref Weapon weapon_7, ref Contact contact_0)
		{
			bool result = false;
			if (Information.IsNothing(contact_0))
			{
				result = false;
			}
			else
			{
				try
				{
					CommDevice[] commDevices = weapon_7.GetCommDevices();
					if (commDevices.Count<CommDevice>() > 0 && !Information.IsNothing(weapon_7.GetWeaponCommStuff().method_7(commDevices, activeUnit_1)) && weapon_7.GetWeaponCommStuff().vmethod_3(null, activeUnit_1, false))
					{
						weapon_7.SetDataLinkParent(activeUnit_1);
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
					ex2.Data.Add("Error at 100340", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x00177524 File Offset: 0x00175724
		public string method_51(Scenario theScen, int WeaponID, ActiveUnit FiringUnit, double LaunchLongitude, double LaunchLatitude, float LaunchAltitude, int LaunchSpeed, Contact theTarget, float InitialHeading = 0f, ActiveUnit.Throttle ThrottleSetting = ActiveUnit.Throttle.Cruise)
		{
			string result = "";
			try
			{
				Weapon weapon = Weapon.GetWeapon(ref theScen, WeaponID, null);
				weapon.SetFiringParent(FiringUnit);
				Weapon.smethod_6(weapon, theScen);
				Weapon weapon2 = Weapon.GetWeapon(ref theScen, theTarget.ActualUnit.DBID, null);
				weapon2.GetWeaponAI().SetPrimaryTarget(theTarget.ActualUnit.GetAI().GetPrimaryTarget());
				weapon2.SetAltitude_ASL(false, theTarget.ActualUnit.GetCurrentAltitude_ASL(false));
				weapon2.SetCurrentSpeed(theTarget.ActualUnit.GetCurrentSpeed());
				weapon2.SetCurrentHeading(theTarget.ActualUnit.GetCurrentHeading());
				weapon2.SetLongitude(null, theTarget.GetLongitude(null));
				weapon2.SetLatitude(null, theTarget.GetLatitude(null));
				Weapon weapon3 = (Weapon)theTarget.ActualUnit;
				weapon2.LaunchPoint = new GeoPoint();
				weapon2.LaunchPoint.SetLongitude(weapon3.LaunchPoint.GetLongitude());
				weapon2.LaunchPoint.SetLatitude(weapon3.LaunchPoint.GetLatitude());
				weapon.SetLongitude(null, LaunchLongitude);
				weapon.SetLatitude(null, LaunchLatitude);
				weapon.SetAltitude_ASL(false, LaunchAltitude);
				weapon.SetCurrentSpeed((float)LaunchSpeed);
				weapon.SetThrottle(weapon.GetMaxThrottleAvailable(), null);
				if (InitialHeading > 0f)
				{
					weapon.SetCurrentHeading(InitialHeading);
				}
				else
				{
					weapon.SetCurrentHeading(Math2.GetAzimuth(LaunchLatitude, LaunchLongitude, theTarget.GetLatitude(null), theTarget.GetLongitude(null)));
				}
				Waypoint waypoint = new Waypoint();
				waypoint.SetLongitude(weapon.GetLongitude(null));
				waypoint.SetLatitude(weapon.GetLatitude(null));
				int num = (int)Math.Round((double)weapon.GetFuelRecs()[0].CurrentQuantity);
				Contact contact = new Contact(weapon2, 0);
				contact.ActualUnit = null;
				contact.SetAltitude_ASL(false, weapon2.GetCurrentAltitude_ASL(false));
				contact.SetCurrentSpeed(weapon2.GetCurrentSpeed());
				contact.SetCurrentHeading(weapon2.GetCurrentHeading());
				contact.SetLongitude(null, weapon2.GetLongitude(null));
				contact.SetLatitude(null, weapon2.GetLatitude(null));
				contact.Heading_Known = theTarget.Heading_Known;
				contact.Speed_Known = theTarget.Speed_Known;
				contact.Altitude_Known = theTarget.Altitude_Known;
				weapon.GetWeaponAI().SetPrimaryTarget(contact);
				weapon.SetDataLinkParent(this.ParentPlatform);
				if (weapon.method_187() || weapon.GetGuidanceMethod() == Weapon._GuidanceMethod.InertiallyGuided)
				{
					weapon.GetWeaponNavigator().method_57((float)weapon.GetWeaponKinematics().GetSpeed(weapon.GetCurrentAltitude_ASL(false), weapon.GetMaxThrottleAvailable()), !Information.IsNothing(weapon.GetDataLinkParent()) && this.ParentPlatform.IsAircraft && weapon.IsTorpedo());
				}
				float num2 = 1f;
				float num3 = (float)(num - 1);
				float num4 = num2;
				bool flag = num4 >= 0f;
				float num5 = 0f;
				bool flag2 = false;
				while (flag ? (num5 <= num3) : (num5 >= num3))
				{
					weapon2.GetWeaponAI().Navigate(num2);
					weapon2.SetThrottle(weapon2.GetMaxThrottleAvailable(), null);
					weapon2.GetWeaponKinematics().UpdateUnitPositions(num2, false, true);
					contact.SetAltitude_ASL(false, weapon2.GetCurrentAltitude_ASL(false));
					contact.SetCurrentSpeed(weapon2.GetCurrentSpeed());
					contact.SetCurrentHeading(weapon2.GetCurrentHeading());
					contact.SetLongitude(null, weapon2.GetLongitude(null));
					contact.SetLatitude(null, weapon2.GetLatitude(null));
					if (weapon.GetWeaponNavigator().HasPlottedCourse())
					{
						weapon.GetWeaponNavigator().GetPlottedCourse()[0].SetLatitude(contact.GetLatitude(null));
						weapon.GetWeaponNavigator().GetPlottedCourse()[0].SetLongitude(contact.GetLongitude(null));
					}
					weapon.GetWeaponAI().Navigate(num2);
					weapon.SetThrottle(weapon.GetMaxThrottleAvailable(), null);
					weapon.GetWeaponKinematics().UpdateUnitPositions(num2, false, true);
					if (num5 != (float)num)
					{
						bool flag3 = !this.ParentPlatform.m_Scenario.FeatureCompatibility.get_WeaponSnapUpDown(this.ParentPlatform.m_Scenario.GetSQLiteConnection()) || weapon.SnapUpDownAltitude_m <= 0f || (float)((int)Math.Round((double)Math.Abs(contact.GetCurrentAltitude_ASL(false) - this.ParentPlatform.GetCurrentAltitude_ASL(false)))) <= weapon.SnapUpDownAltitude_m;
						if (weapon.IsTargetAttackable(num2) && flag3)
						{
							double longitude = contact.GetLongitude(null);
							double latitude = contact.GetLatitude(null);
							Unit unit = (Unit)contact;

							Contact contact2 = contact;
							bool? hintIsOperating = null;
							double longitude2 = unit.GetLongitude(hintIsOperating);
							Unit unit2 = (Unit)contact;
							Contact contact3 = contact;

							bool? hintIsOperating2 = null;
							double latitude2 = unit2.GetLatitude(hintIsOperating2);
							GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref longitude2, ref latitude2, (double)(contact.GetCurrentSpeed() * num2 / 3600f), (double)contact.GetCurrentHeading());
							contact3.SetLatitude(hintIsOperating2, latitude2);
							contact2.SetLongitude(hintIsOperating, longitude2);
							weapon.SetLatitude(null, contact.GetLatitude(null));
							weapon.SetLongitude(null, contact.GetLongitude(null));
							weapon.SetAltitude_ASL(false, contact.GetCurrentAltitude_ASL(false));
							flag2 = true;
							break;
						}
					}
					num5 += num4;
				}
				if (flag2)
				{
					result = "OK";
				}
				else
				{
					result = "Target is out of the weapon's DLZ";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100341", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x00177B90 File Offset: 0x00175D90
		public static string smethod_3(Scenario theScen, int WeaponID, ActiveUnit FiringUnit, double LaunchLongitude, double LaunchLatitude, float LaunchAltitude, int LaunchSpeed, double TargetLongitude, double TargetLatitude, float TargetHeading, bool TargetHeadingKnown, int TargetSpeed, bool TargetSpeedKnown, float TargetAltitude, bool TargetAltitudeKnown, ref GeoPoint InterceptPoint, ref string FeedbackText, float InitialHeading, ActiveUnit.Throttle ThrottleSetting, int CustomWeaponFuel, ArrayList XDAT, ArrayList YDAT)
		{
			bool flag = false;
			InterceptPoint = null;
			string result;
			try
			{
				Weapon weapon = Weapon.GetWeapon(ref theScen, WeaponID, null);
				weapon.SetFiringParent(FiringUnit);
				Weapon.smethod_6(weapon, theScen);
				if (weapon.weaponCode.SearchPattern)
				{
					weapon.weaponCode.SearchPattern = false;
				}
				Aircraft detectedUnit = new Aircraft(ref theScen, null);
				weapon.SetLongitude(null, LaunchLongitude);
				weapon.SetLatitude(null, LaunchLatitude);
				weapon.SetAltitude_ASL(false, LaunchAltitude);
				weapon.SetCurrentSpeed((float)LaunchSpeed);
				if (ThrottleSetting > weapon.GetMaxThrottleAvailable())
				{
					float? num = null;
					weapon.SetThrottle(weapon.GetMaxThrottleAvailable(), num);
				}
				else
				{
					weapon.SetThrottle(ThrottleSetting, null);
				}
				if (InitialHeading <= 0f)
				{
					weapon.SetCurrentHeading(Math2.GetAzimuth(LaunchLatitude, LaunchLongitude, TargetLatitude, TargetLongitude));
				}
				else
				{
					weapon.SetCurrentHeading(InitialHeading);
				}
				if (CustomWeaponFuel > 0)
				{
					weapon.GetFuelRecs()[0].CurrentQuantity = (float)CustomWeaponFuel;
				}
				Waypoint waypoint = new Waypoint();
				waypoint.SetLongitude(weapon.GetLongitude(null));
				waypoint.SetLatitude(weapon.GetLatitude(null));
				float num2 = 5f * weapon.GetFuelRecs()[0].CurrentQuantity;
				Contact contact = new Contact(detectedUnit, 0)
				{
					ActualUnit = null
				};
				contact.SetAltitude_ASL(false, TargetAltitude);
				contact.Altitude_Known = TargetAltitudeKnown;
				contact.SetCurrentSpeed((float)TargetSpeed);
				contact.Speed_Known = TargetSpeedKnown;
				contact.SetCurrentHeading(TargetHeading);
				contact.Heading_Known = TargetHeadingKnown;
				contact.SetLongitude(null, TargetLongitude);
				contact.SetLatitude(null, TargetLatitude);
				weapon.GetWeaponAI().SetPrimaryTarget(contact);
				bool arg_1EF_0;
				if (!weapon.method_187())
				{
					if (weapon.GetGuidanceMethod() != Weapon._GuidanceMethod.InertiallyGuided)
					{
						arg_1EF_0 = true;
						goto IL_1EF;
					}
				}
				arg_1EF_0 = weapon.GetWeaponNavigator().method_57((float)weapon.GetWeaponKinematics().GetSpeed(contact.GetCurrentAltitude_ASL(false), ThrottleSetting), false);
				IL_1EF:
				if (!arg_1EF_0)
				{
					result = "不能计算拦截轨迹";
				}
				else
				{
					float? desiredSpeed_ = null;
					float? num = null;
					float num3 = weapon.GetFuelConsumption(weapon.GetThrottle(), null, desiredSpeed_, num, false, false, false, false);
					if (num3 <= 0f)
					{
						num3 = 1f;
					}
					float num4 = num2 / num3 - 1f;
					float num5 = 0f;
					while (num5 <= num4 && (num5 <= weapon.GetFuelRecs()[0].CurrentQuantity || (weapon.IsOfAirLaunchedGuidedWeapon() && weapon.GetPitch() < weapon.method_127())))
					{
						double longitude = contact.GetLongitude(null);
						double latitude = contact.GetLatitude(null);
						Contact contact2 = contact;
						Contact contact3 = contact2;
						double value = contact2.GetLongitude(null);
						Contact contact4 = contact;
						Contact contact5 = contact4;
						bool? hintIsOperating = null;
						double value2 = contact4.GetLatitude(hintIsOperating);
						GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref value, ref value2, (double)(contact.GetCurrentSpeed() * 1f / 3600f), (double)contact.GetCurrentHeading());
						contact5.SetLatitude(hintIsOperating, value2);
						contact3.SetLongitude(hintIsOperating, value);
						if (Class263.smethod_14((int)Math.Round((double)num5)))
						{
							weapon.GetWeaponAI().Navigate(1f);
							if (ThrottleSetting > weapon.GetMaxThrottleAvailable())
							{
								num = null;
								weapon.SetThrottle(weapon.GetMaxThrottleAvailable(), num);
							}
							else
							{
								weapon.SetThrottle(ThrottleSetting, null);
							}
						}
						weapon.GetWeaponKinematics().UpdateUnitPositions(1f, false, true);
						if (!Information.IsNothing(XDAT))
						{
							double latitude2 = waypoint.GetLatitude();
							double longitude2 = waypoint.GetLongitude();
							double latitude3 = weapon.GetLatitude(null);
							XDAT.Add(Math2.GetDistance(latitude2, longitude2, latitude3, weapon.GetLongitude(null)));
						}
						if (!Information.IsNothing(YDAT))
						{
							YDAT.Add(weapon.GetCurrentAltitude_ASL(false));
						}
						if (num5 != num2 && weapon.IsTargetAttackable(1f) && weapon.GetHorizontalRange(contact) < 1f)
						{
							double longitude3 = contact.GetLongitude(null);
							double latitude4 = contact.GetLatitude(null);
							Contact contact6 = contact;
							contact5 = contact6;
							value2 = contact6.GetLongitude(null);
							Contact contact7 = contact;
							contact3 = contact7;
							bool? hintIsOperating2 = null;
							value = contact7.GetLatitude(hintIsOperating2);
							GeoPointGenerator.GetOtherGeoPoint(longitude3, latitude4, ref value2, ref value, (double)(contact.GetCurrentSpeed() * 1f / 3600f), (double)contact.GetCurrentHeading());
							contact3.SetLatitude(hintIsOperating2, value);
							contact5.SetLongitude(hintIsOperating2, value2);
							weapon.SetLatitude(null, contact.GetLatitude(null));
							weapon.SetLongitude(null, contact.GetLongitude(null));
							weapon.SetAltitude_ASL(false, contact.GetCurrentAltitude_ASL(false));
							double latitude5 = weapon.GetLatitude(null);
							InterceptPoint = new GeoPoint(latitude5, weapon.GetLongitude(null), weapon.GetCurrentAltitude_ASL(false));
							flag = true;
							break;
						}
						num5 += 1f;
					}
					if (!flag)
					{
						string[] array = new string[7];
						array[0] = "FAILURE! Weapon fell short of the target after ";
						array[1] = Conversions.ToString(num5);
						array[2] = " seconds, covering ";
						string[] array2 = array;
						double latitude6 = waypoint.GetLatitude();
						double longitude4 = waypoint.GetLongitude();
						double latitude7 = weapon.GetLatitude(null);
						array2[3] = Conversions.ToString(Math.Round((double)Math2.GetDistance(latitude6, longitude4, latitude7, weapon.GetLongitude(null)), 2));
						array2[4] = "海里. 与目标剩余距离为 ";
						double latitude8 = contact.GetLatitude(null);
						double longitude5 = contact.GetLongitude(null);
						double latitude9 = weapon.GetLatitude(null);
						array2[5] = Conversions.ToString(Math.Round((double)Math2.GetDistance(latitude8, longitude5, latitude9, weapon.GetLongitude(null)), 2));
						array2[6] = "nm.";
						FeedbackText = string.Concat(array2);
					}
					else if (flag)
					{
						string[] array = new string[5];
						array[0] = "SUCCESS! Weapon reached target after ";
						array[1] = Conversions.ToString(num5);
						array[2] = " seconds. Distance from launch point is ";
						string[] array3 = array;
						double latitude10 = waypoint.GetLatitude();
						double longitude6 = waypoint.GetLongitude();
						double latitude11 = weapon.GetLatitude(null);
						array3[3] = Conversions.ToString(Math.Round((double)Math2.GetDistance(latitude10, longitude6, latitude11, weapon.GetLongitude(null)), 2));
						array3[4] = "nm.";
						FeedbackText = string.Concat(array3);
					}
					result = ((!flag) ? "目标超出武器动态发射区." : "OK");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100343", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = "Error";
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x00178308 File Offset: 0x00176508
		public Weapon GetAAWWeapon_RangeMax()
		{
			Weapon result = null;
			checked
			{
				try
				{
					if (Information.IsNothing(this.Weapon_AirRangeMax) && !this.bool_1)
					{
						Mount[] mounts = this.ParentPlatform.m_Mounts;
						float num = 0f;
						for (int i = 0; i < mounts.Length; i++)
						{
							Mount mount = mounts[i];
							if (mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && mount.GetMagazineForMount().GetTimeToFire() <= 0f)
							{
								using (IEnumerator<WeaponRec> enumerator = mount.GetWeaponRecCollection().GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										WeaponRec current;
										Weapon weapon = (current = enumerator.Current).GetWeapon(this.ParentPlatform.m_Scenario);
										if (!weapon.IsNotSensorPod())
										{
											if (weapon.HasNuclearWarhead())
											{
												Doctrine._UseNuclear? useNuclearDoctrine = this.ParentPlatform.m_Doctrine.GetUseNuclearDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
												byte? b = useNuclearDoctrine.HasValue ? new byte?((byte)useNuclearDoctrine.GetValueOrDefault()) : null;
												bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
												if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
												{
													continue;
												}
											}
											if (weapon.RangeAAWMax > num && current.GetCurrentLoad() > 0 && (weapon.weaponTarget.IsAircraft || weapon.weaponTarget.IsGuidedWeapon))
											{
												this.Weapon_AirRangeMax = weapon;
												num = weapon.RangeAAWMax;
											}
										}
									}
								}
							}
						}
						if (this.ParentPlatform.IsAircraft && !Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
						{
							WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
							for (int j = 0; j < weaponRecArray.Length; j++)
							{
								WeaponRec weaponRec;
								Weapon weapon2 = (weaponRec = weaponRecArray[j]).GetWeapon(this.ParentPlatform.m_Scenario);
								if (!weapon2.IsNotSensorPod())
								{
									if (weapon2.HasNuclearWarhead())
									{
										Doctrine._UseNuclear? useNuclearDoctrine = this.ParentPlatform.m_Doctrine.GetUseNuclearDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
										byte? b = useNuclearDoctrine.HasValue ? new byte?((byte)useNuclearDoctrine.GetValueOrDefault()) : null;
										bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
										if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
										{
											goto IL_31A;
										}
									}
									if (weapon2.RangeAAWMax > num && weaponRec.GetCurrentLoad() > 0 && (weapon2.weaponTarget.IsAircraft || weapon2.weaponTarget.IsGuidedWeapon || weapon2.weaponTarget.IsSatellite))
									{
										this.Weapon_AirRangeMax = weapon2;
										num = weapon2.RangeAAWMax;
									}
								}
								IL_31A:;
							}
						}
						this.bool_1 = true;
					}
					result = this.Weapon_AirRangeMax;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200296", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = null;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x001786D0 File Offset: 0x001768D0
		public Weapon GetASUWWeapon_RangeMax(bool bool_7)
		{
			Weapon result = null;
			float num = 0f;
			checked
			{
				try
				{
					if ((Information.IsNothing(this.weapon_2) && !bool_7 && !this.bool_2) || (Information.IsNothing(this.weapon_3) && bool_7 && !this.bool_3))
					{
						Mount[] mounts = this.ParentPlatform.m_Mounts;
						for (int i = 0; i < mounts.Length; i++)
						{
							Mount mount = mounts[i];
							if (mount.GetMagazineForMount().GetTimeToFire() <= 0f && mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
							{
								foreach (WeaponRec weaponRec in mount.GetWeaponRecCollection())
								{
									Weapon weapon = weaponRec.GetWeapon(this.ParentPlatform.m_Scenario);
									if (weapon.HasNuclearWarhead())
									{
										Doctrine._UseNuclear? useNuclearDoctrine = this.ParentPlatform.m_Doctrine.GetUseNuclearDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
										byte? b = useNuclearDoctrine.HasValue ? new byte?((byte)useNuclearDoctrine.GetValueOrDefault()) : null;
										bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
										if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
										{
											continue;
										}
									}
									if (!weapon.IsNotSensorPod() && (!bool_7 || weapon.RangeASUWMax <= 5400f))
									{
										float num2;
										if (this.ParentPlatform.IsAircraft && weapon.method_138())
										{
											num2 = weapon.method_140(this.ParentPlatform.GetCurrentAltitude_ASL(false), Contact_Base.ContactType.Surface);
										}
										else
										{
											num2 = weapon.RangeASUWMax;
										}
										if (num2 > num && weaponRec.GetCurrentLoad() > 0 && (weapon.weaponTarget.IsSurfaceShip || weapon.weaponTarget.IsRadar))
										{
											if (bool_7)
											{
												this.weapon_3 = weapon;
											}
											else
											{
												this.weapon_2 = weapon;
											}
											num = num2;
										}
									}
								}
							}
						}
						if (this.ParentPlatform.IsAircraft && !Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
						{
							WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
							int j = 0;
							while (j < weaponRecArray.Length)
							{
								WeaponRec weaponRec = weaponRecArray[j];
								Weapon weapon2 = weaponRec.GetWeapon(this.ParentPlatform.m_Scenario);
								if (weapon2.HasNuclearWarhead())
								{
									Doctrine._UseNuclear? useNuclearDoctrine = this.ParentPlatform.m_Doctrine.GetUseNuclearDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
									byte? b = useNuclearDoctrine.HasValue ? new byte?((byte)useNuclearDoctrine.GetValueOrDefault()) : null;
									bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
									if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
									{
										j++;
										continue;
									}
								}
								if (weapon2.IsNotSensorPod() || (bool_7 && weapon2.RangeASUWMax > 5400f))
								{
									j++;
								}
								else
								{
									float num3;
									if (this.ParentPlatform.IsAircraft && weapon2.method_138())
									{
										num3 = weapon2.method_140(this.ParentPlatform.GetCurrentAltitude_ASL(false), Contact_Base.ContactType.Surface);
									}
									else
									{
										num3 = weapon2.RangeASUWMax;
									}
									if (num3 > num && weaponRec.GetCurrentLoad() > 0 && (weapon2.weaponTarget.IsSurfaceShip || weapon2.weaponTarget.IsRadar))
									{
										if (bool_7)
										{
											this.weapon_3 = weapon2;
										}
										else
										{
											this.weapon_2 = weapon2;
										}
										num = num3;
									}
									j++;
								}
							}
						}
						if (bool_7)
						{
							this.bool_3 = true;
						}
						else
						{
							this.bool_2 = true;
						}
					}
					if (bool_7)
					{
						result = this.weapon_3;
					}
					else
					{
						result = this.weapon_2;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200297", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = null;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x00178BB0 File Offset: 0x00176DB0
		public Weapon GetLandWeapon_RangeMax(bool bool_7)
		{
			Weapon result = null;
			checked
			{
				try
				{
					if ((Information.IsNothing(this.weapon_4) && !bool_7 && !this.bool_4) || (Information.IsNothing(this.weapon_5) && bool_7 && !this.bool_5))
					{
						Mount[] mounts = this.ParentPlatform.m_Mounts;
						float num = 0f;
						for (int i = 0; i < mounts.Length; i++)
						{
							Mount mount = mounts[i];
							if (mount.GetMagazineForMount().GetTimeToFire() <= 0f && mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
							{
								foreach (WeaponRec weaponRec in mount.GetWeaponRecCollection())
								{
									Weapon weapon = weaponRec.GetWeapon(this.ParentPlatform.m_Scenario);
									if (weapon.HasNuclearWarhead())
									{
										Doctrine._UseNuclear? useNuclearDoctrine = this.ParentPlatform.m_Doctrine.GetUseNuclearDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
										byte? b = useNuclearDoctrine.HasValue ? new byte?((byte)useNuclearDoctrine.GetValueOrDefault()) : null;
										bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
										if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
										{
											continue;
										}
									}
									if (!weapon.IsNotSensorPod() && (!bool_7 || weapon.RangeLandMax <= 5400f))
									{
										float num2;
										if (this.ParentPlatform.IsAircraft && weapon.method_138())
										{
											num2 = weapon.method_140(this.ParentPlatform.GetCurrentAltitude_ASL(false), Contact_Base.ContactType.Facility_Fixed);
										}
										else
										{
											num2 = weapon.RangeLandMax;
										}
										if (num2 > num && weaponRec.GetCurrentLoad() > 0 && (weapon.weaponTarget.IsHardLandStructures || weapon.weaponTarget.IsHardMobileUnit || weapon.weaponTarget.IsSoftLandStructures || weapon.weaponTarget.IsRadar || weapon.weaponTarget.IsRunway || weapon.weaponTarget.IsSoftMobileUnit))
										{
											if (bool_7)
											{
												this.weapon_5 = weapon;
											}
											else
											{
												this.weapon_4 = weapon;
											}
											num = num2;
										}
									}
								}
							}
						}
						if (this.ParentPlatform.IsAircraft && !Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
						{
							WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
							int j = 0;
							while (j < weaponRecArray.Length)
							{
								WeaponRec weaponRec = weaponRecArray[j];
								Weapon weapon2 = weaponRec.GetWeapon(this.ParentPlatform.m_Scenario);
								if (!weapon2.HasNuclearWarhead())
								{
									goto IL_376;
								}
								Doctrine._UseNuclear? useNuclearDoctrine = this.ParentPlatform.m_Doctrine.GetUseNuclearDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
								byte? b = useNuclearDoctrine.HasValue ? new byte?((byte)useNuclearDoctrine.GetValueOrDefault()) : null;
								bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
								if (!(flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
								{
									goto IL_376;
								}
								IL_469:
								j++;
								continue;
								IL_376:
								if (weapon2.IsNotSensorPod() || (bool_7 && weapon2.RangeLandMax > 5400f))
								{
									goto IL_469;
								}
								float num3;
								if (this.ParentPlatform.IsAircraft && weapon2.method_138())
								{
									num3 = weapon2.method_140(this.ParentPlatform.GetCurrentAltitude_ASL(false), Contact_Base.ContactType.Facility_Fixed);
								}
								else
								{
									num3 = weapon2.RangeLandMax;
								}
								if (num3 > num && weaponRec.GetCurrentLoad() > 0 && (weapon2.weaponTarget.IsHardLandStructures || weapon2.weaponTarget.IsHardMobileUnit || weapon2.weaponTarget.IsSoftLandStructures || weapon2.weaponTarget.IsRadar || weapon2.weaponTarget.IsRunway || weapon2.weaponTarget.IsSoftMobileUnit))
								{
									if (bool_7)
									{
										this.weapon_5 = weapon2;
									}
									else
									{
										this.weapon_4 = weapon2;
									}
									num = num3;
									goto IL_469;
								}
								goto IL_469;
							}
						}
						if (bool_7)
						{
							this.bool_5 = true;
						}
						else
						{
							this.bool_4 = true;
						}
					}
					if (bool_7)
					{
						result = this.weapon_5;
					}
					else
					{
						result = this.weapon_4;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200298", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = null;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x001790E4 File Offset: 0x001772E4
		public Weapon GetASWWeapon_RangeMax()
		{
			Weapon result = null;
			checked
			{
				try
				{
					if (Information.IsNothing(this.weapon_6) && !this.bool_6)
					{
						Mount[] mounts = this.ParentPlatform.m_Mounts;
						float num = 0f;
						for (int i = 0; i < mounts.Length; i++)
						{
							Mount mount = mounts[i];
							if (mount.GetMagazineForMount().GetTimeToFire() <= 0f && mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
							{
								foreach (WeaponRec weaponRec in mount.GetWeaponRecCollection())
								{
									Weapon weapon = weaponRec.GetWeapon(this.ParentPlatform.m_Scenario);
									if (!weapon.IsNotSensorPod())
									{
										if (weapon.HasNuclearWarhead())
										{
											Doctrine._UseNuclear? useNuclearDoctrine = this.ParentPlatform.m_Doctrine.GetUseNuclearDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
											byte? b = useNuclearDoctrine.HasValue ? new byte?((byte)useNuclearDoctrine.GetValueOrDefault()) : null;
											bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
											if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
											{
												continue;
											}
										}
										if (weapon.RangeASWMax > num && weaponRec.GetCurrentLoad() > 0 && (weapon.weaponTarget.IsMine || weapon.weaponTarget.IsSubsurface || weapon.weaponTarget.IsTorpedoe))
										{
											this.weapon_6 = weapon;
											num = weapon.RangeASWMax;
										}
									}
								}
							}
						}
						if (this.ParentPlatform.IsAircraft && !Information.IsNothing(((Aircraft)this.ParentPlatform).GetLoadout()))
						{
							WeaponRec[] weaponRecArray = ((Aircraft)this.ParentPlatform).GetLoadout().WeaponRecArray;
							for (int j = 0; j < weaponRecArray.Length; j++)
							{
								WeaponRec weaponRec = weaponRecArray[j];
								Weapon weapon2 = weaponRec.GetWeapon(this.ParentPlatform.m_Scenario);
								if (!weapon2.IsNotSensorPod())
								{
									if (weapon2.HasNuclearWarhead())
									{
										Doctrine._UseNuclear? useNuclearDoctrine = this.ParentPlatform.m_Doctrine.GetUseNuclearDoctrine(this.ParentPlatform.m_Scenario, false, false, false);
										byte? b = useNuclearDoctrine.HasValue ? new byte?((byte)useNuclearDoctrine.GetValueOrDefault()) : null;
										bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
										if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
										{
											goto IL_32E;
										}
									}
									if (weapon2.RangeASWMax > num && weaponRec.GetCurrentLoad() > 0 && (weapon2.weaponTarget.IsMine || weapon2.weaponTarget.IsSubsurface || weapon2.weaponTarget.IsTorpedoe))
									{
										this.weapon_6 = weapon2;
										num = weapon2.RangeASWMax;
									}
								}
								IL_32E:;
							}
						}
						this.bool_6 = true;
					}
					result = this.weapon_6;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200299", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void WeaponAssignments_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x001794C0 File Offset: 0x001776C0
		public virtual Weapon vmethod_11()
		{
			List<WeaponRec> list = this.method_0(false);
			List<Weapon> list2 = new List<Weapon>();
			foreach (WeaponRec current in list)
			{
				if (current.DefaultLoad != 0)
				{
					Weapon weapon = current.GetWeapon(this.ParentPlatform.m_Scenario);
					if (weapon.TargetIsLandFacility() || weapon.TargetIsShipOrRadar())
					{
						list2.Add(weapon);
					}
				}
			}
			Weapon result;
			if (list2.Count > 0)
			{
				result = list2.OrderByDescending(ActiveUnit_Weaponry.WeaponMaxRangeFunc12).ElementAtOrDefault(0);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x00179584 File Offset: 0x00177784
		public virtual Weapon vmethod_12()
		{
			List<Weapon> list = this.GetAvailableWeapons(false).Where(ActiveUnit_Weaponry.WeaponFunc13).ToList<Weapon>();
			Weapon result;
			if (list.Count > 0)
			{
				result = list.OrderByDescending(ActiveUnit_Weaponry.WeaponFunc14).ElementAtOrDefault(0);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x001795D4 File Offset: 0x001777D4
		public virtual Weapon GetWeaponWithMaxRange()
		{
			List<Weapon> list = this.GetAvailableWeapons(false).Where(ActiveUnit_Weaponry.WeaponFunc15).ToList<Weapon>();
			Weapon result;
			if (list.Count > 0)
			{
				result = list.OrderByDescending(ActiveUnit_Weaponry.WeaponFunc16).ElementAtOrDefault(0);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x00179624 File Offset: 0x00177824
		public bool method_57(Contact contact_0)
		{
			bool result = false;
			try
			{
				result = (this.ParentPlatform.m_Scenario.GetGuidedWeaponsInAir().Count != 0 && (this.ParentPlatform.GetSensory().HasTrackingSensorForTarget(contact_0) || this.ParentPlatform.m_Scenario.GetGuidedWeaponsInAir().Where(new Func<Weapon, bool>(this.method_65)).Count<Weapon>() > 0));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100347", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x000212CE File Offset: 0x0001F4CE
		[CompilerGenerated]
		private bool method_58(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).IsMine();
		}

		// Token: 0x06004193 RID: 16787 RVA: 0x001796F0 File Offset: 0x001778F0
		[CompilerGenerated]
		private float method_59(ActiveUnit_Weaponry.FireQueueEntry fireQueueEntry_0)
		{
			return fireQueueEntry_0.weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).GetMaxPOKForAllDomains();
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x000212E6 File Offset: 0x0001F4E6
		[CompilerGenerated]
		private bool IsLaserWeapon(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).IsLaserWeapon();
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x0017971C File Offset: 0x0017791C
		[CompilerGenerated]
		private bool method_61(WeaponRec weaponRec_0)
		{
			bool result;
			if (!weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).IsDecoy() && !weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).IsTrainingRound())
			{
				Weapon weapon = weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario);
				Scenario scenario = this.ParentPlatform.m_Scenario;
				ActiveUnit_AI aI;
				Contact primaryTarget = (aI = this.ParentPlatform.GetAI()).GetPrimaryTarget();
				bool flag = weapon.IsSuitableForTarget(scenario, ref primaryTarget);
				aI.SetPrimaryTarget(primaryTarget);
				result = flag;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x001797AC File Offset: 0x001779AC
		[CompilerGenerated]
		private int method_62(WeaponRec weaponRec_0)
		{
			Weapon weapon = weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario);
			ActiveUnit_AI aI;
			Contact primaryTarget = (aI = this.ParentPlatform.GetAI()).GetPrimaryTarget();
			int result = this.method_17(ref weapon, ref primaryTarget, true);
			aI.SetPrimaryTarget(primaryTarget);
			return result;
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x001797F8 File Offset: 0x001779F8
		[CompilerGenerated]
		private bool method_63(WeaponRec weaponRec_0)
		{
			return !weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).IsDecoy() && !weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).IsTrainingRound() && weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x00179850 File Offset: 0x00177A50
		[CompilerGenerated]
		private float method_64(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.ParentPlatform.m_Scenario).RangeAAWMax;
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x000212FE File Offset: 0x0001F4FE
		[CompilerGenerated]
		private bool method_65(Weapon weapon_7)
		{
			return weapon_7.GetFiringParent() == this.ParentPlatform && weapon_7.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon();
		}

		// Token: 0x04001DFD RID: 7677
		public static Func<WeaponRec, bool> WeaponRecFunc0 = (WeaponRec weaponRec_0) => weaponRec_0.GetCurrentLoad() > 0;

		// Token: 0x04001DFE RID: 7678
		public static Func<Mount, bool> EmptyMountFilter = (Mount mount_0) => mount_0.IsEmpty();

		// Token: 0x04001DFF RID: 7679
		public static Func<Weapon, Weapon> WeaponFunc2 = (Weapon weapon_0) => weapon_0;

		// Token: 0x04001E00 RID: 7680
		public static Func<Weapon, bool> WeaponFunc3 = (Weapon weapon_0) => weapon_0.GetWeaponType() != Weapon._WeaponType.Gun;

		// Token: 0x04001E01 RID: 7681
		public static Func<WeaponRec, WeaponRec> WeaponRecFunc4 = (WeaponRec weaponRec_0) => weaponRec_0;

		// Token: 0x04001E02 RID: 7682
		public static Func<Weapon, float> WeaponFunc5 = (Weapon weapon_0) => weapon_0.GetTotalDamagePointsOfAllWarheads();

		// Token: 0x04001E03 RID: 7683
		public static Func<ActiveUnit_Weaponry.FireQueueEntry, ActiveUnit_Weaponry.FireQueueEntry> FireQueueEntryFunc6 = (ActiveUnit_Weaponry.FireQueueEntry fireQueueEntry_0) => fireQueueEntry_0;

		// Token: 0x04001E04 RID: 7684
		public static Func<Engine, bool> EngineFunc7 = (Engine engine_0) => engine_0.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational;

		// Token: 0x04001E05 RID: 7685
		public static Func<Magazine, string> MagazineFunc8 = (Magazine magazine_0) => magazine_0.bool_8.ToString();

		// Token: 0x04001E06 RID: 7686
		public static Func<Sensor, bool> SensorIsRadarFilterFunc9 = (Sensor sensor_0) => sensor_0.sensorType == Sensor.SensorType.Radar;

		// Token: 0x04001E07 RID: 7687
		public static Func<Sensor, bool> SensorFunc10 = (Sensor sensor_0) => sensor_0.sensorType == Sensor.SensorType.LaserDesignator;

		// Token: 0x04001E08 RID: 7688
		public static Func<Sensor, bool> SensorFunc11 = (Sensor sensor_0) => sensor_0.sensorType == Sensor.SensorType.Visual || sensor_0.sensorType == Sensor.SensorType.Infrared;

		// Token: 0x04001E09 RID: 7689
		public static Func<Weapon, float> WeaponMaxRangeFunc12 = (Weapon weapon_0) => weapon_0.GetLargestRangeMaxOfAllDomains();

		// Token: 0x04001E0A RID: 7690
		public static Func<Weapon, bool> WeaponFunc13 = (Weapon weapon_0) => weapon_0.TargetIsLandFacility() | weapon_0.TargetIsShipOrRadar();

		// Token: 0x04001E0B RID: 7691
		public static Func<Weapon, float> WeaponFunc14 = (Weapon weapon_0) => weapon_0.GetLargestRangeMaxOfAllDomains();

		// Token: 0x04001E0C RID: 7692
		public static Func<Weapon, bool> WeaponFunc15 = (Weapon weapon_0) => weapon_0.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() | weapon_0.TargetIsSubsurface();

		// Token: 0x04001E0D RID: 7693
		public static Func<Weapon, float> WeaponFunc16 = (Weapon weapon_0) => weapon_0.GetLargestRangeMaxOfAllDomains();

		// Token: 0x04001E0E RID: 7694
		protected ActiveUnit ParentPlatform;

		// Token: 0x04001E0F RID: 7695
		[CompilerGenerated]
		private ObservableCollection<WeaponAssignment> WeaponAssignments;

		// Token: 0x04001E10 RID: 7696
		public Lazy<ConcurrentDictionary<Tuple<int, string>, string>> lazy_0;

		// Token: 0x04001E11 RID: 7697
		public HashSet<string> hashSet_0;

		// Token: 0x04001E12 RID: 7698
		[CompilerGenerated]
		private static ActiveUnit_Weaponry.Delegate5 delegate5_0;

		// Token: 0x04001E13 RID: 7699
		private bool bool_0;

		// Token: 0x04001E14 RID: 7700
		private Weapon[] WeaponArray;

		// Token: 0x04001E15 RID: 7701
		private Weapon Weapon_AirRangeMax;

		// Token: 0x04001E16 RID: 7702
		private bool bool_1;

		// Token: 0x04001E17 RID: 7703
		private Weapon weapon_2;

		// Token: 0x04001E18 RID: 7704
		private Weapon weapon_3;

		// Token: 0x04001E19 RID: 7705
		private bool bool_2 = false;

		// Token: 0x04001E1A RID: 7706
		private bool bool_3;

		// Token: 0x04001E1B RID: 7707
		private Weapon weapon_4;

		// Token: 0x04001E1C RID: 7708
		private Weapon weapon_5;

		// Token: 0x04001E1D RID: 7709
		private bool bool_4;

		// Token: 0x04001E1E RID: 7710
		private bool bool_5;

		// Token: 0x04001E1F RID: 7711
		private Weapon weapon_6;

		// Token: 0x04001E20 RID: 7712
		private bool bool_6;

		// Token: 0x020009A9 RID: 2473
		// (Invoke) Token: 0x060041AD RID: 16813
		public delegate void Delegate5(Scenario theScen, ActiveUnit theFiringUnit, Weapon theWeapon);

		// Token: 0x020009AA RID: 2474
		private sealed class MountedWeapon
		{
			// Token: 0x060041B0 RID: 16816 RVA: 0x000213A2 File Offset: 0x0001F5A2
			public MountedWeapon(int? WeaponQty_, int? CurrentLoad)
			{
				this.WeaponQty = WeaponQty_;
				this.CurrentLoad = CurrentLoad;
			}

			// Token: 0x04001E32 RID: 7730
			public int? WeaponQty;

			// Token: 0x04001E33 RID: 7731
			public int? CurrentLoad;
		}

		// Token: 0x020009AB RID: 2475
		public sealed class FireQueueEntry
		{
			// Token: 0x060041B1 RID: 16817 RVA: 0x000213B8 File Offset: 0x0001F5B8
			public FireQueueEntry(ref float float_1, ActiveUnit activeUnit_2, ref WeaponRec weaponRec_1, ref ActiveUnit activeUnit_3, ref Mount mount_1)
			{
				this.float_0 = float_1;
				this.activeUnit_0 = activeUnit_2;
				this.weaponRec_0 = weaponRec_1;
				this.activeUnit_1 = activeUnit_3;
				this.mount_0 = mount_1;
			}

			// Token: 0x04001E34 RID: 7732
			public float float_0;

			// Token: 0x04001E35 RID: 7733
			public ActiveUnit activeUnit_0;

			// Token: 0x04001E36 RID: 7734
			public WeaponRec weaponRec_0;

			// Token: 0x04001E37 RID: 7735
			public ActiveUnit activeUnit_1;

			// Token: 0x04001E38 RID: 7736
			public Mount mount_0;
		}

		// Token: 0x020009AC RID: 2476
		[CompilerGenerated]
		public sealed class Class79
		{
			// Token: 0x060041B2 RID: 16818 RVA: 0x000213E9 File Offset: 0x0001F5E9
			public Class79(ActiveUnit_Weaponry.Class79 class79_0)
			{
				if (class79_0 != null)
				{
					this.Target = class79_0.Target;
				}
			}

			// Token: 0x060041B3 RID: 16819 RVA: 0x00179B2C File Offset: 0x00177D2C
			internal int method_0(WeaponRec weaponRec_)
			{
				ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_Weaponry;
				Weapon weapon = weaponRec_.GetWeapon(this.activeUnit_Weaponry.ParentPlatform.m_Scenario);
				return activeUnit_Weaponry.method_17(ref weapon, ref this.Target, false);
			}

			// Token: 0x060041B4 RID: 16820 RVA: 0x00179B68 File Offset: 0x00177D68
			internal float method_1(WeaponRec weaponRec_0)
			{
				return weaponRec_0.GetWeapon(this.activeUnit_Weaponry.ParentPlatform.m_Scenario).GetMaxRangeToTarget(this.activeUnit_Weaponry.ParentPlatform, this.Target, true, this.activeUnit_Weaponry.ParentPlatform.m_Doctrine, false);
			}

			// Token: 0x04001E39 RID: 7737
			public Contact Target;

			// Token: 0x04001E3A RID: 7738
			public ActiveUnit_Weaponry activeUnit_Weaponry;
		}

		// Token: 0x020009AD RID: 2477
		[CompilerGenerated]
		public sealed class MaxRangeWeaponForTarget
		{
			// Token: 0x060041B5 RID: 16821 RVA: 0x00179BB8 File Offset: 0x00177DB8
			internal float GetMaxRangeToTarget(Weapon weapon_)
			{
				return weapon_.GetMaxRangeToTarget(this.activeUnit_Weaponry.ParentPlatform, this.target, true, this.activeUnit_Weaponry.ParentPlatform.m_Doctrine, false);
			}

			// Token: 0x04001E3B RID: 7739
			public Contact target;

			// Token: 0x04001E3C RID: 7740
			public ActiveUnit_Weaponry activeUnit_Weaponry;
		}

		// Token: 0x020009AE RID: 2478
		[CompilerGenerated]
		public sealed class Class81
		{
			// Token: 0x060041B7 RID: 16823 RVA: 0x00021403 File Offset: 0x0001F603
			internal bool method_0(Weapon weapon_)
			{
				return weapon_.GetMaxRangeToTarget(this.activeUnit_Weaponry.ParentPlatform, this.target, true, this.doctrine, false) > 0f;
			}

			// Token: 0x060041B8 RID: 16824 RVA: 0x00179BF0 File Offset: 0x00177DF0
			internal int method_1(Weapon weapon_0)
			{
				ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_Weaponry;
				Weapon weapon = weapon_0;
				return activeUnit_Weaponry.method_17(ref weapon, ref this.target, this.bool_0);
			}

			// Token: 0x04001E3D RID: 7741
			public Contact target;

			// Token: 0x04001E3E RID: 7742
			public Doctrine doctrine;

			// Token: 0x04001E3F RID: 7743
			public bool bool_0;

			// Token: 0x04001E40 RID: 7744
			public ActiveUnit_Weaponry activeUnit_Weaponry;
		}

		// Token: 0x020009AF RID: 2479
		[CompilerGenerated]
		public sealed class Class82
		{
			// Token: 0x060041BA RID: 16826 RVA: 0x0002142B File Offset: 0x0001F62B
			internal bool method_0(Weapon weapon_0)
			{
				return weapon_0.GetMaxRangeToTarget(this.class81_0.activeUnit_Weaponry.ParentPlatform, this.class81_0.target, true, this.class81_0.doctrine, false) >= this.HorizontalRangeToTarget;
			}

			// Token: 0x060041BB RID: 16827 RVA: 0x00021466 File Offset: 0x0001F666
			internal bool method_1(Weapon weapon_0)
			{
				return weapon_0.GetMaxRangeToTarget(this.class81_0.activeUnit_Weaponry.ParentPlatform, this.class81_0.target, false, this.class81_0.doctrine, false) >= this.HorizontalRangeToTarget;
			}

			// Token: 0x04001E41 RID: 7745
			public float HorizontalRangeToTarget;

			// Token: 0x04001E42 RID: 7746
			public ActiveUnit_Weaponry.Class81 class81_0;
		}

		// Token: 0x020009B0 RID: 2480
		[CompilerGenerated]
		public sealed class Class83
		{
			// Token: 0x060041BD RID: 16829 RVA: 0x000214A1 File Offset: 0x0001F6A1
			public Class83(ActiveUnit_Weaponry.Class83 class83_0)
			{
				if (class83_0 != null)
				{
					this.string_0 = class83_0.string_0;
				}
			}

			// Token: 0x060041BE RID: 16830 RVA: 0x000214BB File Offset: 0x0001F6BB
			internal bool method_0(Contact contact_0)
			{
				return Operators.CompareString(contact_0.GetGuid(), this.string_0, false) == 0;
			}

			// Token: 0x04001E43 RID: 7747
			public string string_0;

			// Token: 0x04001E44 RID: 7748
			public Func<Contact, bool> func_0;
		}

		// Token: 0x020009B1 RID: 2481
		[CompilerGenerated]
		public sealed class TargetEntry
		{
			// Token: 0x060041BF RID: 16831 RVA: 0x000214D2 File Offset: 0x0001F6D2
			public TargetEntry(ActiveUnit_Weaponry.TargetEntry TargetEntry_)
			{
				if (TargetEntry_ != null)
				{
					this.Target = TargetEntry_.Target;
				}
			}

			// Token: 0x060041C0 RID: 16832 RVA: 0x00179C1C File Offset: 0x00177E1C
			internal double GetRange(Contact contact_1)
			{
				return RangeCalculator.GetRange(contact_1.GetLatitude(null), contact_1.GetLongitude(null), this.Target.GetLatitude(null), this.Target.GetLongitude(null));
			}

			// Token: 0x04001E45 RID: 7749
			public Contact Target;
		}
	}
}
