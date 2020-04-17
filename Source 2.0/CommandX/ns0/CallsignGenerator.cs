using System;
using System.Collections.ObjectModel;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{
	// Token: 0x0200009E RID: 158
	public sealed class CallsignGenerator
	{
		// Token: 0x06000318 RID: 792 RVA: 0x0005D648 File Offset: 0x0005B848
		private static void smethod_0()
		{
			if (Information.IsNothing(CallsignGenerator.collection_0))
			{
				CallsignGenerator.collection_0 = new Collection<string>();
			}
			CallsignGenerator.collection_0.Add("Karma");
			CallsignGenerator.collection_0.Add("Valiant");
			CallsignGenerator.collection_0.Add("Redcock");
			CallsignGenerator.collection_0.Add("Spirit");
			CallsignGenerator.collection_0.Add("Udoshi");
			CallsignGenerator.collection_0.Add("Sunliner");
			CallsignGenerator.collection_0.Add("Gladiator");
			CallsignGenerator.collection_0.Add("Stinger");
			CallsignGenerator.collection_0.Add("Argonaut");
			CallsignGenerator.collection_0.Add("Shrike");
			CallsignGenerator.collection_0.Add("Ghostrider");
			CallsignGenerator.collection_0.Add("Blue Hawk");
			CallsignGenerator.collection_0.Add("Tiger");
			CallsignGenerator.collection_0.Add("Black Lancer");
			CallsignGenerator.collection_0.Add("Champion");
			CallsignGenerator.collection_0.Add("Warhorse");
			CallsignGenerator.collection_0.Add("Knightrider");
			CallsignGenerator.collection_0.Add("Clansman");
			CallsignGenerator.collection_0.Add("Blackbird");
			CallsignGenerator.collection_0.Add("Hornet");
			CallsignGenerator.collection_0.Add("Challenger");
			CallsignGenerator.collection_0.Add("Green Pawn");
			CallsignGenerator.collection_0.Add("Bull");
			CallsignGenerator.collection_0.Add("Road Runner");
			CallsignGenerator.collection_0.Add("Panther");
			CallsignGenerator.collection_0.Add("Blue Blaster");
			CallsignGenerator.collection_0.Add("Black Knight");
			CallsignGenerator.collection_0.Add("Lancer");
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0005D814 File Offset: 0x0005BA14
		private static void smethod_1()
		{
			if (Information.IsNothing(CallsignGenerator.collection_1))
			{
				CallsignGenerator.collection_1 = new Collection<string>();
			}
			CallsignGenerator.collection_1.Add("Arrow");
			CallsignGenerator.collection_1.Add("Ghost");
			CallsignGenerator.collection_1.Add("Jason");
			CallsignGenerator.collection_1.Add("Spartan");
			CallsignGenerator.collection_1.Add("Thunder");
			CallsignGenerator.collection_1.Add("Ouzo");
			CallsignGenerator.collection_1.Add("Dolly");
			CallsignGenerator.collection_1.Add("Drumstick");
			CallsignGenerator.collection_1.Add("Eagle");
			CallsignGenerator.collection_1.Add("Havoc");
			CallsignGenerator.collection_1.Add("Jamjar");
			CallsignGenerator.collection_1.Add("Jimmy");
			CallsignGenerator.collection_1.Add("Lion");
			CallsignGenerator.collection_1.Add("Razor");
			CallsignGenerator.collection_1.Add("Rider");
			CallsignGenerator.collection_1.Add("Saint");
			CallsignGenerator.collection_1.Add("Spiff");
			CallsignGenerator.collection_1.Add("Sting");
			CallsignGenerator.collection_1.Add("Stumpy");
			CallsignGenerator.collection_1.Add("Tiger");
			CallsignGenerator.collection_1.Add("Viper");
			CallsignGenerator.collection_1.Add("Ace");
			CallsignGenerator.collection_1.Add("Adder");
			CallsignGenerator.collection_1.Add("Airgun");
			CallsignGenerator.collection_1.Add("Alamo");
			CallsignGenerator.collection_1.Add("Amber");
			CallsignGenerator.collection_1.Add("Angel");
			CallsignGenerator.collection_1.Add("Angry");
			CallsignGenerator.collection_1.Add("Apache");
			CallsignGenerator.collection_1.Add("Array");
			CallsignGenerator.collection_1.Add("Astro");
			CallsignGenerator.collection_1.Add("Atilla");
			CallsignGenerator.collection_1.Add("Axeman");
			CallsignGenerator.collection_1.Add("Bacon");
			CallsignGenerator.collection_1.Add("Badger");
			CallsignGenerator.collection_1.Add("Bandit");
			CallsignGenerator.collection_1.Add("Banshee");
			CallsignGenerator.collection_1.Add("Bat");
			CallsignGenerator.collection_1.Add("Beast");
			CallsignGenerator.collection_1.Add("Bigdog");
			CallsignGenerator.collection_1.Add("Bird");
			CallsignGenerator.collection_1.Add("Bobcat");
			CallsignGenerator.collection_1.Add("Bones");
			CallsignGenerator.collection_1.Add("Boxer");
			CallsignGenerator.collection_1.Add("Brave");
			CallsignGenerator.collection_1.Add("Bubba");
			CallsignGenerator.collection_1.Add("Bullet");
			CallsignGenerator.collection_1.Add("Butch");
			CallsignGenerator.collection_1.Add("Buzzard");
			CallsignGenerator.collection_1.Add("Cajun");
			CallsignGenerator.collection_1.Add("Cannon");
			CallsignGenerator.collection_1.Add("Cheetah");
			CallsignGenerator.collection_1.Add("Chevy");
			CallsignGenerator.collection_1.Add("Chili");
			CallsignGenerator.collection_1.Add("Claw");
			CallsignGenerator.collection_1.Add("Cobra");
			CallsignGenerator.collection_1.Add("Colt");
			CallsignGenerator.collection_1.Add("Combat");
			CallsignGenerator.collection_1.Add("Condor");
			CallsignGenerator.collection_1.Add("Corvette");
			CallsignGenerator.collection_1.Add("Cowboy");
			CallsignGenerator.collection_1.Add("Coyote");
			CallsignGenerator.collection_1.Add("Cully");
			CallsignGenerator.collection_1.Add("Cyclone");
			CallsignGenerator.collection_1.Add("Dagger");
			CallsignGenerator.collection_1.Add("Dart");
			CallsignGenerator.collection_1.Add("Death");
			CallsignGenerator.collection_1.Add("Demon");
			CallsignGenerator.collection_1.Add("Devil");
			CallsignGenerator.collection_1.Add("Disco");
			CallsignGenerator.collection_1.Add("Dog");
			CallsignGenerator.collection_1.Add("Dragon");
			CallsignGenerator.collection_1.Add("Dude");
			CallsignGenerator.collection_1.Add("Dusty");
			CallsignGenerator.collection_1.Add("Falcon");
			CallsignGenerator.collection_1.Add("Fang");
			CallsignGenerator.collection_1.Add("Farmer");
			CallsignGenerator.collection_1.Add("Flash");
			CallsignGenerator.collection_1.Add("Fox");
			CallsignGenerator.collection_1.Add("Foxy");
			CallsignGenerator.collection_1.Add("Fury");
			CallsignGenerator.collection_1.Add("Gambler");
			CallsignGenerator.collection_1.Add("Gator");
			CallsignGenerator.collection_1.Add("Goal");
			CallsignGenerator.collection_1.Add("Goose");
			CallsignGenerator.collection_1.Add("Greg");
			CallsignGenerator.collection_1.Add("Griffin");
			CallsignGenerator.collection_1.Add("Grim");
			CallsignGenerator.collection_1.Add("Grumpy");
			CallsignGenerator.collection_1.Add("Gunman");
			CallsignGenerator.collection_1.Add("Gypsy");
			CallsignGenerator.collection_1.Add("Hammer");
			CallsignGenerator.collection_1.Add("Harm");
			CallsignGenerator.collection_1.Add("Heat");
			CallsignGenerator.collection_1.Add("Hitman");
			CallsignGenerator.collection_1.Add("Hog");
			CallsignGenerator.collection_1.Add("Hook");
			CallsignGenerator.collection_1.Add("Hydra");
			CallsignGenerator.collection_1.Add("Iceman");
			CallsignGenerator.collection_1.Add("Iron");
			CallsignGenerator.collection_1.Add("Jackal");
			CallsignGenerator.collection_1.Add("Java");
			CallsignGenerator.collection_1.Add("Jive");
			CallsignGenerator.collection_1.Add("Karma");
			CallsignGenerator.collection_1.Add("Killer");
			CallsignGenerator.collection_1.Add("Knife");
			CallsignGenerator.collection_1.Add("Knight");
			CallsignGenerator.collection_1.Add("Lance");
			CallsignGenerator.collection_1.Add("Lancer");
			CallsignGenerator.collection_1.Add("Limit");
			CallsignGenerator.collection_1.Add("Lobo");
			CallsignGenerator.collection_1.Add("Lucky");
			CallsignGenerator.collection_1.Add("Mace");
			CallsignGenerator.collection_1.Add("Maddog");
			CallsignGenerator.collection_1.Add("Magic");
			CallsignGenerator.collection_1.Add("Marlin");
			CallsignGenerator.collection_1.Add("Mascot");
			CallsignGenerator.collection_1.Add("Maverick");
			CallsignGenerator.collection_1.Add("Metal");
			CallsignGenerator.collection_1.Add("Meteor");
			CallsignGenerator.collection_1.Add("Mexico");
			CallsignGenerator.collection_1.Add("Misty");
			CallsignGenerator.collection_1.Add("Mongol");
			CallsignGenerator.collection_1.Add("Mugger");
			CallsignGenerator.collection_1.Add("Musket");
			CallsignGenerator.collection_1.Add("Mustang");
			CallsignGenerator.collection_1.Add("Nail");
			CallsignGenerator.collection_1.Add("Nasty");
			CallsignGenerator.collection_1.Add("Nickel");
			CallsignGenerator.collection_1.Add("Ninja");
			CallsignGenerator.collection_1.Add("Nitro");
			CallsignGenerator.collection_1.Add("Nomad");
			CallsignGenerator.collection_1.Add("Outlaw");
			CallsignGenerator.collection_1.Add("Panther");
			CallsignGenerator.collection_1.Add("Pepsi");
			CallsignGenerator.collection_1.Add("Pistol");
			CallsignGenerator.collection_1.Add("Playboy");
			CallsignGenerator.collection_1.Add("Poker");
			CallsignGenerator.collection_1.Add("Pride");
			CallsignGenerator.collection_1.Add("Psycho");
			CallsignGenerator.collection_1.Add("Python");
			CallsignGenerator.collection_1.Add("Quest");
			CallsignGenerator.collection_1.Add("Racer");
			CallsignGenerator.collection_1.Add("Raider");
			CallsignGenerator.collection_1.Add("Ram");
			CallsignGenerator.collection_1.Add("Rambo");
			CallsignGenerator.collection_1.Add("Ranger");
			CallsignGenerator.collection_1.Add("Ravage");
			CallsignGenerator.collection_1.Add("Raygun");
			CallsignGenerator.collection_1.Add("Razz");
			CallsignGenerator.collection_1.Add("Reaper");
			CallsignGenerator.collection_1.Add("Rebel");
			CallsignGenerator.collection_1.Add("Red Dog");
			CallsignGenerator.collection_1.Add("Reno");
			CallsignGenerator.collection_1.Add("Rider");
			CallsignGenerator.collection_1.Add("Rifle");
			CallsignGenerator.collection_1.Add("Ringo");
			CallsignGenerator.collection_1.Add("Ripper");
			CallsignGenerator.collection_1.Add("Risk");
			CallsignGenerator.collection_1.Add("Rock");
			CallsignGenerator.collection_1.Add("Rocket");
			CallsignGenerator.collection_1.Add("Rocky");
			CallsignGenerator.collection_1.Add("Rouge");
			CallsignGenerator.collection_1.Add("Rumble");
			CallsignGenerator.collection_1.Add("Sabre");
			CallsignGenerator.collection_1.Add("Salty");
			CallsignGenerator.collection_1.Add("Savage");
			CallsignGenerator.collection_1.Add("Scar");
			CallsignGenerator.collection_1.Add("Scout");
			CallsignGenerator.collection_1.Add("Shack");
			CallsignGenerator.collection_1.Add("Shadow");
			CallsignGenerator.collection_1.Add("Shake");
			CallsignGenerator.collection_1.Add("Shark");
			CallsignGenerator.collection_1.Add("Shogun");
			CallsignGenerator.collection_1.Add("Shooter");
			CallsignGenerator.collection_1.Add("Silver");
			CallsignGenerator.collection_1.Add("Skate");
			CallsignGenerator.collection_1.Add("Skull");
			CallsignGenerator.collection_1.Add("Slam");
			CallsignGenerator.collection_1.Add("Slay");
			CallsignGenerator.collection_1.Add("Sledge");
			CallsignGenerator.collection_1.Add("Slugger");
			CallsignGenerator.collection_1.Add("Smoke");
			CallsignGenerator.collection_1.Add("Snake");
			CallsignGenerator.collection_1.Add("Sniper");
			CallsignGenerator.collection_1.Add("Snow");
			CallsignGenerator.collection_1.Add("Sonic");
			CallsignGenerator.collection_1.Add("Spark");
			CallsignGenerator.collection_1.Add("Speed");
			CallsignGenerator.collection_1.Add("Spike");
			CallsignGenerator.collection_1.Add("Stalk");
			CallsignGenerator.collection_1.Add("Steel");
			CallsignGenerator.collection_1.Add("Stick");
			CallsignGenerator.collection_1.Add("Sting");
			CallsignGenerator.collection_1.Add("Stinger");
			CallsignGenerator.collection_1.Add("Strike");
			CallsignGenerator.collection_1.Add("Stut");
			CallsignGenerator.collection_1.Add("Sweep");
			CallsignGenerator.collection_1.Add("Sword");
			CallsignGenerator.collection_1.Add("Tango");
			CallsignGenerator.collection_1.Add("Tater");
			CallsignGenerator.collection_1.Add("Thud");
			CallsignGenerator.collection_1.Add("Thug");
			CallsignGenerator.collection_1.Add("Thunder");
			CallsignGenerator.collection_1.Add("Time");
			CallsignGenerator.collection_1.Add("Titan");
			CallsignGenerator.collection_1.Add("Topgun");
			CallsignGenerator.collection_1.Add("Topcat");
			CallsignGenerator.collection_1.Add("Torch");
			CallsignGenerator.collection_1.Add("Vegas");
			CallsignGenerator.collection_1.Add("Venom");
			CallsignGenerator.collection_1.Add("Viking");
			CallsignGenerator.collection_1.Add("Viper");
			CallsignGenerator.collection_1.Add("Voodoo");
			CallsignGenerator.collection_1.Add("Vulcan");
			CallsignGenerator.collection_1.Add("Vulture");
			CallsignGenerator.collection_1.Add("Wild");
			CallsignGenerator.collection_1.Add("Wolf");
			CallsignGenerator.collection_1.Add("Zombie");
			CallsignGenerator.collection_1.Add("Zuni");
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0005E520 File Offset: 0x0005C720
		private static void smethod_2()
		{
			if (Information.IsNothing(CallsignGenerator.collection_2))
			{
				CallsignGenerator.collection_2 = new Collection<string>();
			}
			CallsignGenerator.collection_2.Add("Abrams");
			CallsignGenerator.collection_2.Add("Agony");
			CallsignGenerator.collection_2.Add("Align");
			CallsignGenerator.collection_2.Add("April");
			CallsignGenerator.collection_2.Add("Artic");
			CallsignGenerator.collection_2.Add("Astro");
			CallsignGenerator.collection_2.Add("Avon");
			CallsignGenerator.collection_2.Add("Baffle");
			CallsignGenerator.collection_2.Add("Baloo");
			CallsignGenerator.collection_2.Add("Bambi");
			CallsignGenerator.collection_2.Add("Baron");
			CallsignGenerator.collection_2.Add("Belga");
			CallsignGenerator.collection_2.Add("Black");
			CallsignGenerator.collection_2.Add("Boot");
			CallsignGenerator.collection_2.Add("Brewer");
			CallsignGenerator.collection_2.Add("Camel");
			CallsignGenerator.collection_2.Add("Casino");
			CallsignGenerator.collection_2.Add("Catch");
			CallsignGenerator.collection_2.Add("China");
			CallsignGenerator.collection_2.Add("Crisp");
			CallsignGenerator.collection_2.Add("Crown");
			CallsignGenerator.collection_2.Add("Dame");
			CallsignGenerator.collection_2.Add("Dare");
			CallsignGenerator.collection_2.Add("Derby");
			CallsignGenerator.collection_2.Add("Dino");
			CallsignGenerator.collection_2.Add("Diva");
			CallsignGenerator.collection_2.Add("Door");
			CallsignGenerator.collection_2.Add("Drug");
			CallsignGenerator.collection_2.Add("Easy");
			CallsignGenerator.collection_2.Add("Edgar");
			CallsignGenerator.collection_2.Add("Elvis");
			CallsignGenerator.collection_2.Add("Extra");
			CallsignGenerator.collection_2.Add("Fenny");
			CallsignGenerator.collection_2.Add("Flap");
			CallsignGenerator.collection_2.Add("Floss");
			CallsignGenerator.collection_2.Add("Frank");
			CallsignGenerator.collection_2.Add("Frisk");
			CallsignGenerator.collection_2.Add("Geld");
			CallsignGenerator.collection_2.Add("Gina");
			CallsignGenerator.collection_2.Add("Golly");
			CallsignGenerator.collection_2.Add("Hall");
			CallsignGenerator.collection_2.Add("Hardy");
			CallsignGenerator.collection_2.Add("Hawk");
			CallsignGenerator.collection_2.Add("Home");
			CallsignGenerator.collection_2.Add("Honk");
			CallsignGenerator.collection_2.Add("Horse");
			CallsignGenerator.collection_2.Add("Husky");
			CallsignGenerator.collection_2.Add("Idler");
			CallsignGenerator.collection_2.Add("Jake");
			CallsignGenerator.collection_2.Add("Jeris");
			CallsignGenerator.collection_2.Add("Jiggs");
			CallsignGenerator.collection_2.Add("Joss");
			CallsignGenerator.collection_2.Add("Juice");
			CallsignGenerator.collection_2.Add("Jumbo");
			CallsignGenerator.collection_2.Add("Kate");
			CallsignGenerator.collection_2.Add("Kirk");
			CallsignGenerator.collection_2.Add("Lamb");
			CallsignGenerator.collection_2.Add("Lolly");
			CallsignGenerator.collection_2.Add("Lotto");
			CallsignGenerator.collection_2.Add("Lusk");
			CallsignGenerator.collection_2.Add("Mango");
			CallsignGenerator.collection_2.Add("Mazer");
			CallsignGenerator.collection_2.Add("Meek");
			CallsignGenerator.collection_2.Add("Mercury");
			CallsignGenerator.collection_2.Add("Miller");
			CallsignGenerator.collection_2.Add("Monty");
			CallsignGenerator.collection_2.Add("Mongoose");
			CallsignGenerator.collection_2.Add("Moose");
			CallsignGenerator.collection_2.Add("More");
			CallsignGenerator.collection_2.Add("Music");
			CallsignGenerator.collection_2.Add("Nappy");
			CallsignGenerator.collection_2.Add("Natch");
			CallsignGenerator.collection_2.Add("Noose");
			CallsignGenerator.collection_2.Add("Nutty");
			CallsignGenerator.collection_2.Add("Olson");
			CallsignGenerator.collection_2.Add("Omega");
			CallsignGenerator.collection_2.Add("Oscar");
			CallsignGenerator.collection_2.Add("Pace");
			CallsignGenerator.collection_2.Add("Packer");
			CallsignGenerator.collection_2.Add("Pass");
			CallsignGenerator.collection_2.Add("Patio");
			CallsignGenerator.collection_2.Add("Peach");
			CallsignGenerator.collection_2.Add("Percy");
			CallsignGenerator.collection_2.Add("Perm");
			CallsignGenerator.collection_2.Add("Petro");
			CallsignGenerator.collection_2.Add("Phoenix");
			CallsignGenerator.collection_2.Add("Piggy");
			CallsignGenerator.collection_2.Add("Polar");
			CallsignGenerator.collection_2.Add("Rash");
			CallsignGenerator.collection_2.Add("Rash");
			CallsignGenerator.collection_2.Add("Raven");
			CallsignGenerator.collection_2.Add("Redhook");
			CallsignGenerator.collection_2.Add("Remit");
			CallsignGenerator.collection_2.Add("Remus");
			CallsignGenerator.collection_2.Add("Rhino");
			CallsignGenerator.collection_2.Add("Ripsaw");
			CallsignGenerator.collection_2.Add("Wagon");
			CallsignGenerator.collection_2.Add("Rodeo");
			CallsignGenerator.collection_2.Add("Roller");
			CallsignGenerator.collection_2.Add("Rook");
			CallsignGenerator.collection_2.Add("Royal");
			CallsignGenerator.collection_2.Add("Rubber");
			CallsignGenerator.collection_2.Add("Ruff");
			CallsignGenerator.collection_2.Add("Russo");
			CallsignGenerator.collection_2.Add("Samba");
			CallsignGenerator.collection_2.Add("Sandy");
			CallsignGenerator.collection_2.Add("Saucy");
			CallsignGenerator.collection_2.Add("Scrow");
			CallsignGenerator.collection_2.Add("Selma");
			CallsignGenerator.collection_2.Add("Shock");
			CallsignGenerator.collection_2.Add("Shocker");
			CallsignGenerator.collection_2.Add("Ship");
			CallsignGenerator.collection_2.Add("Shoe");
			CallsignGenerator.collection_2.Add("Skip");
			CallsignGenerator.collection_2.Add("Sooner");
			CallsignGenerator.collection_2.Add("Spirit");
			CallsignGenerator.collection_2.Add("Store");
			CallsignGenerator.collection_2.Add("Stork");
			CallsignGenerator.collection_2.Add("Storm");
			CallsignGenerator.collection_2.Add("Strap");
			CallsignGenerator.collection_2.Add("Sumo");
			CallsignGenerator.collection_2.Add("Sway");
			CallsignGenerator.collection_2.Add("Taffy");
			CallsignGenerator.collection_2.Add("Talon");
			CallsignGenerator.collection_2.Add("Thorn");
			CallsignGenerator.collection_2.Add("Timon");
			CallsignGenerator.collection_2.Add("Token");
			CallsignGenerator.collection_2.Add("Toxic");
			CallsignGenerator.collection_2.Add("Trim");
			CallsignGenerator.collection_2.Add("Troll");
			CallsignGenerator.collection_2.Add("Truck");
			CallsignGenerator.collection_2.Add("Tuna");
			CallsignGenerator.collection_2.Add("Turkey");
			CallsignGenerator.collection_2.Add("Utter");
			CallsignGenerator.collection_2.Add("Vader");
			CallsignGenerator.collection_2.Add("Venus");
			CallsignGenerator.collection_2.Add("Vesta");
			CallsignGenerator.collection_2.Add("Vetch");
			CallsignGenerator.collection_2.Add("Vine");
			CallsignGenerator.collection_2.Add("Wager");
			CallsignGenerator.collection_2.Add("Wake");
			CallsignGenerator.collection_2.Add("Wang");
			CallsignGenerator.collection_2.Add("Warp");
			CallsignGenerator.collection_2.Add("Whip");
			CallsignGenerator.collection_2.Add("Whiskey");
			CallsignGenerator.collection_2.Add("Window");
			CallsignGenerator.collection_2.Add("Worst");
			CallsignGenerator.collection_2.Add("Xenon");
			CallsignGenerator.collection_2.Add("Yankee");
			CallsignGenerator.collection_2.Add("Zero");
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0005EE10 File Offset: 0x0005D010
		public static string smethod_3()
		{
			if (Information.IsNothing(CallsignGenerator.collection_0))
			{
				CallsignGenerator.smethod_0();
			}
			return CallsignGenerator.collection_0[GameGeneral.GetRandom().Next(0, CallsignGenerator.collection_0.Count - 1)];
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0005EE54 File Offset: 0x0005D054
		public static string smethod_4()
		{
			if (Information.IsNothing(CallsignGenerator.collection_1))
			{
				CallsignGenerator.smethod_1();
			}
			return CallsignGenerator.collection_1[GameGeneral.GetRandom().Next(0, CallsignGenerator.collection_1.Count - 1)] + Conversions.ToString(GameGeneral.GetRandom().Next(1, 99));
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0005EEB0 File Offset: 0x0005D0B0
		public static string smethod_5()
		{
			if (Information.IsNothing(CallsignGenerator.collection_2))
			{
				CallsignGenerator.smethod_2();
			}
			return CallsignGenerator.collection_2[GameGeneral.GetRandom().Next(0, CallsignGenerator.collection_2.Count - 1)] + Conversions.ToString(GameGeneral.GetRandom().Next(1, 99));
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0005EF0C File Offset: 0x0005D10C
		public static string GenerateCallsignString(ref Mission mission_0)
		{
			string result;
			if (!Information.IsNothing(mission_0) && (mission_0.MissionClass == Mission._MissionClass.Strike || mission_0.MissionClass == Mission._MissionClass.Patrol || mission_0.MissionClass == Mission._MissionClass.Mining))
			{
				result = CallsignGenerator.smethod_4();
			}
			else
			{
				result = CallsignGenerator.smethod_5();
			}
			return result;
		}

		// Token: 0x040001C8 RID: 456
		public static Collection<string> collection_0;

		// Token: 0x040001C9 RID: 457
		public static Collection<string> collection_1;

		// Token: 0x040001CA RID: 458
		public static Collection<string> collection_2;
	}
}
