using System;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns4;

namespace Command_Core.Lua
{
	// Token: 0x02000C5A RID: 3162
	[Attribute1, Attribute2, Attribute3]
	public sealed class LuaEnuNames
	{
		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x0600690D RID: 26893 RVA: 0x0038640C File Offset: 0x0038460C
		[Attribute2]
		public LuaTable ContactType
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				byte[] array = (byte[])Enum.GetValues(typeof(Contact_Base.ContactType));
				for (int i = 0; i < array.Length; i++)
				{
					byte b = array[i];
					luaTable[b.ToString()] = b.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600690E RID: 26894 RVA: 0x00386468 File Offset: 0x00384668
		[Attribute2]
		public LuaTable FuelState
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				byte[] array = (byte[])Enum.GetValues(typeof(FuelRec._FuelType));
				for (int i = 0; i < array.Length; i++)
				{
					byte b = array[i];
					luaTable[b.ToString()] = b.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600690F RID: 26895 RVA: 0x00386468 File Offset: 0x00384668
		[Attribute2]
		public LuaTable FuelType
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				byte[] array = (byte[])Enum.GetValues(typeof(FuelRec._FuelType));
				for (int i = 0; i < array.Length; i++)
				{
					byte b = array[i];
					luaTable[b.ToString()] = b.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06006910 RID: 26896 RVA: 0x003864C4 File Offset: 0x003846C4
		[Attribute2]
		public LuaTable PatrolType
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				byte[] array = (byte[])Enum.GetValues(typeof(GlobalVariables.PatrolType));
				for (int i = 0; i < array.Length; i++)
				{
					byte b = array[i];
					luaTable[b.ToString()] = b.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06006911 RID: 26897 RVA: 0x00386520 File Offset: 0x00384720
		[Attribute2]
		public LuaTable Proficiency
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int[] array = (int[])Enum.GetValues(typeof(GlobalVariables.ProficiencyLevel));
				for (int i = 0; i < array.Length; i++)
				{
					int num = array[i];
					luaTable[num.ToString()] = num.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06006912 RID: 26898 RVA: 0x0038657C File Offset: 0x0038477C
		[Attribute2]
		public LuaTable Throttle
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				byte[] array = (byte[])Enum.GetValues(typeof(ActiveUnit.Throttle));
				for (int i = 0; i < array.Length; i++)
				{
					byte b = array[i];
					luaTable[b.ToString()] = b.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06006913 RID: 26899 RVA: 0x003865D8 File Offset: 0x003847D8
		[Attribute2]
		public LuaTable UnitType
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				byte[] array = (byte[])Enum.GetValues(typeof(GlobalVariables.ActiveUnitType));
				for (int i = 0; i < array.Length; i++)
				{
					byte b = array[i];
					luaTable[b.ToString()] = b.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x00386634 File Offset: 0x00384834
		[Attribute2]
		public LuaTable Doctrine(string type)
		{
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			string left = type.ToLower();
			if (Operators.CompareString(left, "fuelstate", false) == 0)
			{
				byte[] array = (byte[])Enum.GetValues(typeof(Doctrine._FuelState));
				for (int i = 0; i < array.Length; i++)
				{
					byte b = array[i];
					luaTable[b.ToString()] = b.ToString();
				}
			}
			else if (Operators.CompareString(left, "weaponstate", false) == 0)
			{
				int[] array2 = (int[])Enum.GetValues(typeof(Doctrine._WeaponState));
				for (int j = 0; j < array2.Length; j++)
				{
					int num = array2[j];
					luaTable[num.ToString()] = num.ToString();
				}
			}
			else if (Operators.CompareString(left, "rechargebattery", false) == 0)
			{
				int[] array3 = (int[])Enum.GetValues(typeof(Doctrine._RechargeBatteryPercentage));
				for (int k = 0; k < array3.Length; k++)
				{
					int num2 = array3[k];
					luaTable[num2.ToString()] = num2.ToString();
				}
			}
			else if (Operators.CompareString(left, "wratargettype", false) == 0)
			{
				int[] array4 = (int[])Enum.GetValues(typeof(Doctrine._WRA_WeaponTargetType));
				for (int l = 0; l < array4.Length; l++)
				{
					int num3 = array4[l];
					luaTable[num3.ToString()] = num3.ToString();
				}
			}
			return luaTable;
		}
	}
}
