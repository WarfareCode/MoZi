using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using System.Windows.Threading;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns4;

namespace Command
{
	// 声音效果
	public sealed class SoundHandler_Effects : DispatcherObject
	{
		// Token: 0x060054E6 RID: 21734 RVA: 0x00236970 File Offset: 0x00234B70
		public SoundHandler_Effects()
		{
			this.list_0 = null;
			this.list_1 = null;
			this.list_2 = null;
			this.string_0 = CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Sound\\Effects\\";
			ActiveUnit_Weaponry.smethod_0(new ActiveUnit_Weaponry.Delegate5(this.method_2));
			Weapon.smethod_1(new Weapon.Delegate25(this.method_3));
			Aircraft_AirOps.smethod_1(new Aircraft_AirOps.Delegate6(this.method_1));
			ActiveUnit_Sensory.smethod_0(new ActiveUnit_Sensory.Delegate4(this.method_0));
		}

		// Token: 0x060054E7 RID: 21735 RVA: 0x002369FC File Offset: 0x00234BFC
		private void method_0(Side side_0, Contact_Base.ContactType contactType_0)
		{
			if (SimConfiguration.gameOptions.IsGameSoundsON() && !Information.IsNothing(Client.GetClientSide()) && !Information.IsNothing(Client.GetClientSide()) && (side_0 == Client.GetClientSide() || side_0.GetPostureStance(Client.GetClientSide()) == Misc.PostureStance.Friendly))
			{
				if (contactType_0 != Contact_Base.ContactType.Missile && contactType_0 != Contact_Base.ContactType.Torpedo)
				{
					this.method_5(this.string_0 + "contact_new.mp3");
				}
				else
				{
					this.method_5(this.string_0 + "Alert_missile.mp3");
				}
			}
		}

		// Token: 0x060054E8 RID: 21736 RVA: 0x00236A8C File Offset: 0x00234C8C
		private void method_1(Aircraft aircraft_0)
		{
			if (SimConfiguration.gameOptions.IsGameSoundsON() && !Information.IsNothing(Client.GetClientSide()) && aircraft_0.GetSide(false) == Client.GetClientSide())
			{
				if (aircraft_0.IsRotaryWingAircraft())
				{
					this.method_5(this.string_0 + "helo_takeoff.mp3");
				}
				else
				{
					this.method_5(this.string_0 + "airplane_takeoff.mp3");
				}
			}
		}

		// Token: 0x060054E9 RID: 21737 RVA: 0x00236B00 File Offset: 0x00234D00
		private void method_2(Scenario scenario_0, ActiveUnit activeUnit_0, Weapon weapon_0)
		{
			if (!Information.IsNothing(Client.GetClientSide()) && SimConfiguration.gameOptions.IsGameSoundsON() && (activeUnit_0.GetSide(false) == Client.GetClientSide() | activeUnit_0.GetSide(false).IsFriendlyToSide(Client.GetClientSide())) && scenario_0 == Client.GetClientScenario())
			{
				Weapon._WeaponType weaponType = weapon_0.GetWeaponType();
				switch (weaponType)
				{
				case Weapon._WeaponType.GuidedWeapon:
					if (weapon_0.GetFuelRecs().Count<FuelRec>() <= 0 || weapon_0.GetFuelRecs()[0].FuelType != FuelRec._FuelType.WeaponCoast)
					{
						if (weapon_0.GetLargestRangeMaxOfAllDomains() > 10f)
						{
							this.method_5(this.string_0 + "Missile_medium.mp3");
						}
						else
						{
							this.method_5(this.string_0 + "Missile_small.mp3");
						}
					}
					break;
				case Weapon._WeaponType.Rocket:
					this.method_5(this.string_0 + "Rocket_small.mp3");
					break;
				case Weapon._WeaponType.IronBomb:
					break;
				case Weapon._WeaponType.Gun:
					switch (weapon_0.m_Warheads[0].Caliber)
					{
					case Warhead.WarheadCaliber.Gun_6_15mm:
						this.method_5(this.string_0 + "Gunfire_machinegun.mp3");
						break;
					case Warhead.WarheadCaliber.Gun_16_24mm:
						this.method_5(this.string_0 + "Gunfire_20mm.mp3");
						break;
					case Warhead.WarheadCaliber.Gun_25_60mm:
						this.method_5(this.string_0 + "Gunfire_40mm.mp3");
						break;
					case Warhead.WarheadCaliber.Gun_61_80mm:
						this.method_5(this.string_0 + "Gunfire_76mm.mp3");
						break;
					case Warhead.WarheadCaliber.Gun_81_150mm:
						this.method_5(this.string_0 + "Gunfire_100mm.mp3");
						break;
					default:
						this.method_5(this.string_0 + "Gunfire_152mm.mp3");
						break;
					}
					break;
				default:
					if (weaponType == Weapon._WeaponType.Torpedo)
					{
						this.method_5(this.string_0 + "Torpedo_launch.mp3");
					}
					else if (weaponType == Weapon._WeaponType.Laser)
					{
						this.method_5(this.string_0 + "Gunfire_laser.mp3");
					}
					break;
				}
			}
		}

		// Token: 0x060054EA RID: 21738 RVA: 0x00236D18 File Offset: 0x00234F18
		private void method_3(Scenario scenario_0, Weapon weapon_0, Unit unit_0, bool bool_0)
		{
			if (SimConfiguration.gameOptions.IsGameSoundsON() && !Information.IsNothing(Client.GetClientSide()) && (weapon_0.GetSide(false) == Client.GetClientSide() | (!Information.IsNothing(unit_0.GetSide(false)) && unit_0.GetSide(false) == Client.GetClientSide())) && scenario_0 == Client.GetClientScenario())
			{
				if (bool_0)
				{
					switch (weapon_0.GetWeaponType())
					{
					case Weapon._WeaponType.GuidedWeapon:
					case Weapon._WeaponType.IronBomb:
						if (unit_0.IsAircraft)
						{
							this.method_5(this.string_0 + "Explosion_air_medium.mp3");
						}
						else
						{
							float dP = weapon_0.m_Warheads[0].DP;
							if (dP < 5f)
							{
								this.method_5(this.string_0 + "Impact_directhit_vsmall.mp3");
							}
							else if (dP < 50f)
							{
								this.method_5(this.string_0 + "Impact_directhit_small.mp3");
							}
							else if (dP < 200f)
							{
								this.method_5(this.string_0 + "Impact_directhit_medium.mp3");
							}
							else
							{
								this.method_5(this.string_0 + "Impact_directhit_large.mp3");
							}
						}
						break;
					case Weapon._WeaponType.Rocket:
					case Weapon._WeaponType.Gun:
					{
						Warhead.WarheadCaliber caliber = weapon_0.m_Warheads[0].Caliber;
						if (caliber - Warhead.WarheadCaliber.Gun_6_15mm <= 3)
						{
							this.method_5(this.string_0 + "Impact_directhit_small.mp3");
						}
						else if (caliber - Warhead.WarheadCaliber.Gun_81_150mm > 1)
						{
							this.method_5(this.string_0 + "Impact_directhit_large.mp3");
						}
						else
						{
							this.method_5(this.string_0 + "Impact_directhit_medium.mp3");
						}
						break;
					}
					}
				}
				else if (weapon_0.IsOnLand())
				{
					switch (weapon_0.GetWeaponType())
					{
					case Weapon._WeaponType.GuidedWeapon:
					case Weapon._WeaponType.IronBomb:
					{
						float dP2 = weapon_0.m_Warheads[0].DP;
						if (dP2 < 50f)
						{
							this.method_5(this.string_0 + "Impact_miss_land_small.mp3");
						}
						else if (dP2 < 200f)
						{
							this.method_5(this.string_0 + "Impact_miss_land_medium.mp3");
						}
						else
						{
							this.method_5(this.string_0 + "Impact_miss_land_large.mp3");
						}
						break;
					}
					case Weapon._WeaponType.Rocket:
					case Weapon._WeaponType.Gun:
					{
						Warhead.WarheadCaliber caliber2 = weapon_0.m_Warheads[0].Caliber;
						if (caliber2 - Warhead.WarheadCaliber.Gun_6_15mm <= 3)
						{
							this.method_5(this.string_0 + "Impact_miss_land_small.mp3");
						}
						else if (caliber2 - Warhead.WarheadCaliber.Gun_81_150mm > 1)
						{
							this.method_5(this.string_0 + "Impact_miss_land_large.mp3");
						}
						else
						{
							this.method_5(this.string_0 + "Impact_miss_land_medium.mp3");
						}
						break;
					}
					}
				}
				else
				{
					this.method_5(this.string_0 + "Watersplash_large.mp3");
				}
			}
		}

		// Token: 0x060054EB RID: 21739 RVA: 0x00237030 File Offset: 0x00235230
		private void method_4(string string_1)
		{
			if (this.list_0 == null)
			{
				this.list_0 = new List<MediaPlayer>();
				this.list_0.AddRange(Enumerable.Range(0, 8).Select(SoundHandler_Effects.intFunc0));
				this.list_1 = new List<bool>();
				this.list_1.AddRange(Enumerable.Range(0, 8).Select(SoundHandler_Effects.intFunc1));
				this.list_2 = new List<string>();
				this.list_2.AddRange(Enumerable.Range(0, 8).Select(SoundHandler_Effects.intFunc2));
				int num = 0;
				do
				{
					SoundHandler_Effects.Class2532 @class = new SoundHandler_Effects.Class2532(null);
					@class.soundHandler_Effects_0 = this;
					@class.int_0 = num;
					this.list_0[num].MediaEnded += new EventHandler(@class.method_0);
					this.list_0[num].MediaOpened += new EventHandler(@class.method_2);
					this.list_1[@class.int_0] = false;
					num++;
				}
				while (num <= 7);
			}
			if (!this.list_2.Contains(string_1))
			{
				int num2 = this.list_1.IndexOf(false);
				if (num2 != -1)
				{
					MediaPlayer mediaPlayer = this.list_0.Skip(num2).First<MediaPlayer>();
					mediaPlayer.Open(new Uri(string_1));
					mediaPlayer.Play();
					this.list_2[num2] = string_1;
				}
			}
		}

		// Token: 0x060054EC RID: 21740 RVA: 0x00237188 File Offset: 0x00235388
		private void method_5(string string_1)
		{
			SoundHandler_Effects.Class2533 @class = new SoundHandler_Effects.Class2533();
			@class.soundHandler_Effects_0 = this;
			@class.string_0 = string_1;
			try
			{
				base.Dispatcher.Invoke(new Delegate48(@class.method_0), new object[0]);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200421", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x04002921 RID: 10529
		public static Func<int, MediaPlayer> intFunc0 = (int int_0) => new MediaPlayer();

		// Token: 0x04002922 RID: 10530
		public static Func<int, bool> intFunc1 = (int int_0) => false;

		// Token: 0x04002923 RID: 10531
		public static Func<int, string> intFunc2 = (int int_0) => "";

		// Token: 0x04002924 RID: 10532
		private string string_0;

		// Token: 0x04002925 RID: 10533
		private List<MediaPlayer> list_0;

		// Token: 0x04002926 RID: 10534
		private List<bool> list_1;

		// Token: 0x04002927 RID: 10535
		private List<string> list_2;

		// Token: 0x02000A79 RID: 2681
		[CompilerGenerated]
		public sealed class Class2532
		{
			// Token: 0x060054F1 RID: 21745 RVA: 0x000270EB File Offset: 0x000252EB
			public Class2532(SoundHandler_Effects.Class2532 class2532_0)
			{
				if (class2532_0 != null)
				{
					this.int_0 = class2532_0.int_0;
				}
			}

			// Token: 0x060054F2 RID: 21746 RVA: 0x002372A0 File Offset: 0x002354A0
			internal void method_0(object sender, EventArgs e)
			{
				this.soundHandler_Effects_0.Dispatcher.Invoke((this.delegate48_0 == null) ? (this.delegate48_0 = new Delegate48(this.method_1)) : this.delegate48_0, new object[0]);
			}

			// Token: 0x060054F3 RID: 21747 RVA: 0x00027105 File Offset: 0x00025305
			internal void method_1()
			{
				this.soundHandler_Effects_0.list_1[this.int_0] = false;
				this.soundHandler_Effects_0.list_2[this.int_0] = "";
			}

			// Token: 0x060054F4 RID: 21748 RVA: 0x002372EC File Offset: 0x002354EC
			internal void method_2(object sender, EventArgs e)
			{
				this.soundHandler_Effects_0.Dispatcher.Invoke((this.delegate48_1 == null) ? (this.delegate48_1 = new Delegate48(this.method_3)) : this.delegate48_1, new object[0]);
			}

			// Token: 0x060054F5 RID: 21749 RVA: 0x00027139 File Offset: 0x00025339
			internal void method_3()
			{
				this.soundHandler_Effects_0.list_1[this.int_0] = true;
			}

			// Token: 0x0400292B RID: 10539
			public int int_0;

			// Token: 0x0400292C RID: 10540
			public SoundHandler_Effects soundHandler_Effects_0;

			// Token: 0x0400292D RID: 10541
			public Delegate48 delegate48_0;

			// Token: 0x0400292E RID: 10542
			public Delegate48 delegate48_1;
		}

		// Token: 0x02000A7A RID: 2682
		[CompilerGenerated]
		public sealed class Class2533
		{
			// Token: 0x060054F6 RID: 21750 RVA: 0x00027152 File Offset: 0x00025352
			internal void method_0()
			{
				this.soundHandler_Effects_0.method_4(this.string_0);
			}

			// Token: 0x0400292F RID: 10543
			public string string_0;

			// Token: 0x04002930 RID: 10544
			public SoundHandler_Effects soundHandler_Effects_0;
		}
	}
}
