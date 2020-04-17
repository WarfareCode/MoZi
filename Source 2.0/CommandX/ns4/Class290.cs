using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;

namespace ns4
{
	// Token: 0x02000C50 RID: 3152
	public sealed class Class290
	{
		// Token: 0x060068E8 RID: 26856 RVA: 0x0038577C File Offset: 0x0038397C
		public static LuaWrapper_ReferencePoint smethod_0(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			Side side = LuaUtility.smethod_16(objectGeoLocation, scenario_0);
			if (!objectGeoLocation.ContainsKey("NAME"))
			{
				throw new Exception2("Missing 'Name'");
			}
			string name = Conversions.ToString(objectGeoLocation["NAME"]);
			double? num = LuaUtility.smethod_10(objectGeoLocation);
			if (!num.HasValue)
			{
				throw new Exception2("Missing 'Latitude'");
			}
			double? num2 = LuaUtility.smethod_12(objectGeoLocation);
			if (!num2.HasValue)
			{
				throw new Exception2("Missing 'Longitude'");
			}
			ReferencePoint referencePoint = new ReferencePoint();
			referencePoint.SetLongitude(num2.Value);
			referencePoint.SetLatitude(num.Value);
			scenario_0.UnitsAutoIncrement++;
			referencePoint.Name = name;
			side.GetReferencePoints().Add(referencePoint);
			string guid = referencePoint.GetGuid();
			objectGeoLocation["GUID"] = guid;
			LuaUtility.smethod_3(objectGeoLocation, luaTable_0);
			return Class290.smethod_1(luaTable_0, scenario_0);
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x0038586C File Offset: 0x00383A6C
		public static LuaWrapper_ReferencePoint smethod_1(LuaTable luaTable_0, Scenario scenario_0)
		{
			Class290.Class291 @class = new Class290.Class291(null);
			@class.dictionary_0 = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			ReferencePoint referencePoint = null;
			List<ReferencePoint> list = new List<ReferencePoint>();
			Side side = LuaUtility.smethod_16(@class.dictionary_0, scenario_0);
			if (@class.dictionary_0.ContainsKey("GUID"))
			{
				referencePoint = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(@class.method_0));
				@class.dictionary_0["NAME"] = referencePoint.Name;
			}
			else if (@class.dictionary_0.ContainsKey("NAME"))
			{
				Class290.Class292 class2 = new Class290.Class292(null);
				class2.string_0 = Conversions.ToString(@class.dictionary_0["NAME"]);
				referencePoint = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class2.method_0));
				@class.dictionary_0["GUID"] = referencePoint.GetGuid();
			}
			else
			{
				if (!@class.dictionary_0.ContainsKey("AREA"))
				{
					throw new Exception2("Need to define a Side and Name to modify an RP. Or a Side and Guid. Or a set of RPs");
				}
				List<object> list2 = LuaUtility.smethod_0(((LuaTable)@class.dictionary_0["AREA"]).GetEnumerator());
				List<object>.Enumerator enumerator = list2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class290.Class293 class3 = new Class290.Class293(null);
						class3.object_0 = RuntimeHelpers.GetObjectValue(enumerator.Current);
						ReferencePoint referencePoint2 = null;
						if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class3.method_0))))
						{
							referencePoint2 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class3.method_1));
						}
						else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class3.method_2))))
						{
							referencePoint2 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class3.method_3));
						}
						else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class3.method_4))))
						{
							referencePoint2 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class3.method_5));
						}
						else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class3.method_6))))
						{
							referencePoint2 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class3.method_7));
						}
						if (!Information.IsNothing(referencePoint2))
						{
							list.Add(referencePoint2);
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			if (list.Count == 0 && referencePoint == null)
			{
				throw new Exception2("Need to define a Side and Name to modify an RP. Or a Side and Guid. Or a set of RPs");
			}
			if (referencePoint != null)
			{
				if (@class.dictionary_0.ContainsKey("NEWNAME"))
				{
					string text = Conversions.ToString(@class.dictionary_0["NEWNAME"]);
					if (Operators.CompareString(referencePoint.Name, text, false) != 0)
					{
						referencePoint.Name = text;
					}
				}
				double? num = LuaUtility.smethod_10(@class.dictionary_0);
				if (num.HasValue)
				{
					referencePoint.SetLatitude(num.Value);
				}
				double? num2 = LuaUtility.smethod_12(@class.dictionary_0);
				if (num2.HasValue)
				{
					referencePoint.SetLongitude(num2.Value);
				}
			}
			string value = null;
			if (referencePoint != null)
			{
				value = referencePoint.GetGuid();
				list.Add(referencePoint);
				referencePoint = null;
			}
			Unit unit = null;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			ReferencePoint.OrientationType bearingType = ReferencePoint.OrientationType.Fixed;
			if (@class.dictionary_0.ContainsKey("HIGHLIGHTED"))
			{
				bool? booleanValue = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(@class.dictionary_0["HIGHLIGHTED"]));
				if (booleanValue.HasValue)
				{
					flag = booleanValue.Value;
				}
			}
			else if (@class.dictionary_0.ContainsKey("TOGGLEHIGHLIGHTED") && LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(@class.dictionary_0["TOGGLEHIGHLIGHTED"])).GetValueOrDefault())
			{
				flag2 = true;
			}
			if (@class.dictionary_0.ContainsKey("LOCKED"))
			{
				flag3 = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(@class.dictionary_0["LOCKED"])).Value;
			}
			if (@class.dictionary_0.ContainsKey("BEARINGTYPE"))
			{
				ReferencePoint.OrientationType orientationType = (ReferencePoint.OrientationType)Conversions.ToByte(@class.dictionary_0["BEARINGTYPE"]);
				if (Enum.IsDefined(typeof(ReferencePoint.OrientationType), orientationType))
				{
					bearingType = orientationType;
				}
			}
			if (@class.dictionary_0.ContainsKey("CLEAR"))
			{
				bool? booleanValue2 = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(@class.dictionary_0["CLEAR"]));
				if (booleanValue2.HasValue)
				{
					flag4 = booleanValue2.Value;
				}
			}
			if (@class.dictionary_0.ContainsKey("RELATIVETO"))
			{
				string text2 = Conversions.ToString(@class.dictionary_0["RELATIVETO"]);
				if (Operators.CompareString(text2.ToLower(), "none", false) == 0)
				{
					flag4 = true;
				}
				else
				{
					unit = PrivateMethods.smethod_46(text2, side);
					if (unit == null)
					{
						throw new Exception2("Missing unit " + text2 + " from relative bearing");
					}
				}
			}
			foreach (ReferencePoint current in list)
			{
				if (flag)
				{
					current.SetIsSelected(flag);
				}
				if (flag2)
				{
					current.SetIsSelected(!current.IsSelected());
				}
				if (flag3)
				{
					current.IsLocked = flag3;
				}
				if (flag4)
				{
					current.IsRelativeToUnit = null;
					current.BearingType = ReferencePoint.OrientationType.Fixed;
					current.RelativeBearing = 0f;
					current.RelativeDistance = 0f;
				}
				else
				{
					current.BearingType = bearingType;
					if (unit != null)
					{
						current.IsRelativeToUnit = unit;
						current.RelativeCalculate();
					}
				}
			}
			referencePoint = list.First<ReferencePoint>();
			@class.dictionary_0["GUID"] = value;
			LuaUtility.smethod_3(@class.dictionary_0, luaTable_0);
			return new LuaWrapper_ReferencePoint(referencePoint, scenario_0);
		}

		// Token: 0x060068EA RID: 26858 RVA: 0x00385EBC File Offset: 0x003840BC
		public static LuaTable smethod_2(LuaTable luaTable_0, Scenario scenario_0)
		{
			Class290.Class294 @class = new Class290.Class294(null);
			@class.dictionary_0 = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			List<ReferencePoint> list = new List<ReferencePoint>();
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			Side side = LuaUtility.smethod_16(@class.dictionary_0, scenario_0);
			if (@class.dictionary_0.ContainsKey("GUID"))
			{
				ReferencePoint referencePoint = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(@class.method_0));
				@class.dictionary_0["NAME"] = referencePoint.Name;
			}
			else if (@class.dictionary_0.ContainsKey("NAME"))
			{
				Class290.Class295 class2 = new Class290.Class295(null);
				class2.string_0 = Conversions.ToString(@class.dictionary_0["NAME"]);
				ReferencePoint referencePoint = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class2.method_0));
				@class.dictionary_0["GUID"] = referencePoint.GetGuid();
			}
			else
			{
				if (!@class.dictionary_0.ContainsKey("AREA"))
				{
					throw new Exception2("Need to define a Side and Name to modify an RP. Or a Side and Guid.");
				}
				List<object> list2 = LuaUtility.smethod_0(((LuaTable)@class.dictionary_0["AREA"]).GetEnumerator());
				List<object>.Enumerator enumerator = list2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class290.Class296 class3 = new Class290.Class296(null);
						class3.object_0 = RuntimeHelpers.GetObjectValue(enumerator.Current);
						ReferencePoint referencePoint2 = null;
						if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class3.method_0))))
						{
							referencePoint2 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class3.method_1));
						}
						else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class3.method_2))))
						{
							referencePoint2 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class3.method_3));
						}
						else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class3.method_4))))
						{
							referencePoint2 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class3.method_5));
						}
						else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class3.method_6))))
						{
							referencePoint2 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class3.method_7));
						}
						if (!Information.IsNothing(referencePoint2))
						{
							list.Add(referencePoint2);
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			LuaSandBox.Singleton().CreateTable();
			int num = 1;
			LuaTable result;
			using (List<ReferencePoint>.Enumerator enumerator2 = list.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					Class290.Class297 class4 = new Class290.Class297(null);
					class4.referencePoint_0 = enumerator2.Current;
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					luaTable2["name"] = class4.referencePoint_0.Name;
					luaTable2["latitude"] = class4.referencePoint_0.GetLatitude().ToString();
					luaTable2["longitude"] = class4.referencePoint_0.GetLongitude().ToString();
					luaTable2["guid"] = class4.referencePoint_0.GetGuid().ToString();
					luaTable2["side"] = scenario_0.GetSides().First(new Func<Side, bool>(class4.method_0)).GetSideName();
					luaTable2["highlighted"] = class4.referencePoint_0.IsSelected().ToString();
					luaTable2["locked"] = class4.referencePoint_0.IsLocked.ToString();
					if (class4.referencePoint_0.IsRelativeToUnit != null)
					{
						luaTable2["bearingtype"] = class4.referencePoint_0.BearingType.ToString();
						luaTable2["relativeto"] = class4.referencePoint_0.IsRelativeToUnit.Name;
					}
					luaTable[num] = luaTable2;
					num++;
				}
				result = luaTable;
			}
			return result;
		}

		// Token: 0x060068EB RID: 26859 RVA: 0x0038631C File Offset: 0x0038451C
		public static bool smethod_3(LuaTable luaTable_0, Scenario scenario_0)
		{
			Class290.Class298 @class = new Class290.Class298();
			@class.dictionary_0 = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			Side side = LuaUtility.smethod_16(@class.dictionary_0, scenario_0);
			ReferencePoint referencePoint;
			if (@class.dictionary_0.ContainsKey("GUID"))
			{
				referencePoint = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(@class.method_0));
				@class.dictionary_0["NAME"] = referencePoint.Name;
			}
			else
			{
				if (!@class.dictionary_0.ContainsKey("NAME"))
				{
					throw new Exception2("Need to define a Side and Name to modify an RP. Or a Side and Guid.");
				}
				Class290.Class299 class2 = new Class290.Class299();
				class2.string_0 = Conversions.ToString(@class.dictionary_0["NAME"]);
				referencePoint = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class2.method_0));
				@class.dictionary_0["GUID"] = referencePoint.GetGuid();
			}
			side.GetReferencePoints().Remove(referencePoint);
			return true;
		}

		// Token: 0x02000C51 RID: 3153
		[CompilerGenerated]
		public sealed class Class291
		{
			// Token: 0x060068ED RID: 26861 RVA: 0x0002D2BE File Offset: 0x0002B4BE
			public Class291(Class290.Class291 class291_0)
			{
				if (class291_0 != null)
				{
					this.dictionary_0 = class291_0.dictionary_0;
				}
			}

			// Token: 0x060068EE RID: 26862 RVA: 0x0002D2D8 File Offset: 0x0002B4D8
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), Conversions.ToString(this.dictionary_0["GUID"]), false) == 0;
			}

			// Token: 0x04003B1A RID: 15130
			public Dictionary<string, object> dictionary_0;
		}

		// Token: 0x02000C52 RID: 3154
		[CompilerGenerated]
		public sealed class Class292
		{
			// Token: 0x060068EF RID: 26863 RVA: 0x0002D2FE File Offset: 0x0002B4FE
			public Class292(Class290.Class292 class292_0)
			{
				if (class292_0 != null)
				{
					this.string_0 = class292_0.string_0;
				}
			}

			// Token: 0x060068F0 RID: 26864 RVA: 0x0002D318 File Offset: 0x0002B518
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x04003B1B RID: 15131
			public string string_0;
		}

		// Token: 0x02000C53 RID: 3155
		[CompilerGenerated]
		public sealed class Class293
		{
			// Token: 0x060068F1 RID: 26865 RVA: 0x0002D339 File Offset: 0x0002B539
			public Class293(Class290.Class293 class293_0)
			{
				if (class293_0 != null)
				{
					this.object_0 = class293_0.object_0;
				}
			}

			// Token: 0x060068F2 RID: 26866 RVA: 0x0002D353 File Offset: 0x0002B553
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x060068F3 RID: 26867 RVA: 0x0002D353 File Offset: 0x0002B553
			internal bool method_1(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x060068F4 RID: 26868 RVA: 0x0002D36F File Offset: 0x0002B56F
			internal bool method_2(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x060068F5 RID: 26869 RVA: 0x0002D36F File Offset: 0x0002B56F
			internal bool method_3(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x060068F6 RID: 26870 RVA: 0x0002D395 File Offset: 0x0002B595
			internal bool method_4(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x060068F7 RID: 26871 RVA: 0x0002D395 File Offset: 0x0002B595
			internal bool method_5(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x060068F8 RID: 26872 RVA: 0x0002D3B1 File Offset: 0x0002B5B1
			internal bool method_6(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x060068F9 RID: 26873 RVA: 0x0002D3B1 File Offset: 0x0002B5B1
			internal bool method_7(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x04003B1C RID: 15132
			public object object_0;
		}

		// Token: 0x02000C54 RID: 3156
		[CompilerGenerated]
		public sealed class Class294
		{
			// Token: 0x060068FA RID: 26874 RVA: 0x0002D3D7 File Offset: 0x0002B5D7
			public Class294(Class290.Class294 class294_0)
			{
				if (class294_0 != null)
				{
					this.dictionary_0 = class294_0.dictionary_0;
				}
			}

			// Token: 0x060068FB RID: 26875 RVA: 0x0002D3F1 File Offset: 0x0002B5F1
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), Conversions.ToString(this.dictionary_0["GUID"]), false) == 0;
			}

			// Token: 0x04003B1D RID: 15133
			public Dictionary<string, object> dictionary_0;
		}

		// Token: 0x02000C55 RID: 3157
		[CompilerGenerated]
		public sealed class Class295
		{
			// Token: 0x060068FC RID: 26876 RVA: 0x0002D417 File Offset: 0x0002B617
			public Class295(Class290.Class295 class295_0)
			{
				if (class295_0 != null)
				{
					this.string_0 = class295_0.string_0;
				}
			}

			// Token: 0x060068FD RID: 26877 RVA: 0x0002D431 File Offset: 0x0002B631
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x04003B1E RID: 15134
			public string string_0;
		}

		// Token: 0x02000C56 RID: 3158
		[CompilerGenerated]
		public sealed class Class296
		{
			// Token: 0x060068FE RID: 26878 RVA: 0x0002D452 File Offset: 0x0002B652
			public Class296(Class290.Class296 class296_0)
			{
				if (class296_0 != null)
				{
					this.object_0 = class296_0.object_0;
				}
			}

			// Token: 0x060068FF RID: 26879 RVA: 0x0002D46C File Offset: 0x0002B66C
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006900 RID: 26880 RVA: 0x0002D46C File Offset: 0x0002B66C
			internal bool method_1(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006901 RID: 26881 RVA: 0x0002D488 File Offset: 0x0002B688
			internal bool method_2(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006902 RID: 26882 RVA: 0x0002D488 File Offset: 0x0002B688
			internal bool method_3(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006903 RID: 26883 RVA: 0x0002D4AE File Offset: 0x0002B6AE
			internal bool method_4(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006904 RID: 26884 RVA: 0x0002D4AE File Offset: 0x0002B6AE
			internal bool method_5(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006905 RID: 26885 RVA: 0x0002D4CA File Offset: 0x0002B6CA
			internal bool method_6(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006906 RID: 26886 RVA: 0x0002D4CA File Offset: 0x0002B6CA
			internal bool method_7(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x04003B1F RID: 15135
			public object object_0;
		}

		// Token: 0x02000C57 RID: 3159
		[CompilerGenerated]
		public sealed class Class297
		{
			// Token: 0x06006907 RID: 26887 RVA: 0x0002D4F0 File Offset: 0x0002B6F0
			public Class297(Class290.Class297 class297_0)
			{
				if (class297_0 != null)
				{
					this.referencePoint_0 = class297_0.referencePoint_0;
				}
			}

			// Token: 0x06006908 RID: 26888 RVA: 0x0002D50A File Offset: 0x0002B70A
			internal bool method_0(Side side_0)
			{
				return side_0.GetReferencePoints().Contains(this.referencePoint_0);
			}

			// Token: 0x04003B20 RID: 15136
			public ReferencePoint referencePoint_0;
		}

		// Token: 0x02000C58 RID: 3160
		[CompilerGenerated]
		public sealed class Class298
		{
			// Token: 0x06006909 RID: 26889 RVA: 0x0002D51D File Offset: 0x0002B71D
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), Conversions.ToString(this.dictionary_0["GUID"]), false) == 0;
			}

			// Token: 0x04003B21 RID: 15137
			public Dictionary<string, object> dictionary_0;
		}

		// Token: 0x02000C59 RID: 3161
		[CompilerGenerated]
		public sealed class Class299
		{
			// Token: 0x0600690B RID: 26891 RVA: 0x0002D543 File Offset: 0x0002B743
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x04003B22 RID: 15138
			public string string_0;
		}
	}
}
