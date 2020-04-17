using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns0;
using ns4;

namespace Command_Core
{
	// Token: 0x02000C35 RID: 3125
	public sealed class LuaUtility
	{
		// Token: 0x06006866 RID: 26726 RVA: 0x003704D0 File Offset: 0x0036E6D0
		public static List<object> smethod_0(IDictionaryEnumerator idictionaryEnumerator_0)
		{
			List<Tuple<int, object>> list = new List<Tuple<int, object>>();
			while (idictionaryEnumerator_0.MoveNext())
			{
				int item = Conversions.ToInteger(idictionaryEnumerator_0.Key);
				list.Add(new Tuple<int, object>(item, RuntimeHelpers.GetObjectValue(idictionaryEnumerator_0.Value)));
			}
			return list.OrderBy(LuaUtility.TupleFunc0).Select(LuaUtility.TupleFunc1).ToList<object>();
		}

		// Token: 0x06006867 RID: 26727 RVA: 0x0037052C File Offset: 0x0036E72C
		public static Dictionary<string, object> GetObjectGeoLocation(IDictionaryEnumerator idictionaryEnumerator_)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			while (idictionaryEnumerator_.MoveNext())
			{
				string text = Conversions.ToString(idictionaryEnumerator_.Key).ToUpper();
				if (Operators.CompareString(text, "LAT", false) == 0)
				{
					text = "LATITUDE";
				}
				if (Operators.CompareString(text, "LON", false) == 0)
				{
					text = "LONGITUDE";
				}
				if (Operators.CompareString(text, "LONG", false) == 0)
				{
					text = "LONGITUDE";
				}
				if (Operators.CompareString(text, "ALT", false) == 0)
				{
					text = "ALTITUDE";
				}
				if (Operators.CompareString(text, "OBJECTID", false) == 0)
				{
					text = "GUID";
				}
				dictionary[text] = RuntimeHelpers.GetObjectValue(idictionaryEnumerator_.Value);
			}
			return dictionary;
		}

		// Token: 0x06006868 RID: 26728 RVA: 0x003705F8 File Offset: 0x0036E7F8
		public static Dictionary<string, object> smethod_2(IDictionaryEnumerator idictionaryEnumerator_0)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			while (idictionaryEnumerator_0.MoveNext())
			{
				string key = Conversions.ToString(idictionaryEnumerator_0.Key).ToLower();
				dictionary[key] = RuntimeHelpers.GetObjectValue(idictionaryEnumerator_0.Value);
			}
			return dictionary;
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x0037063C File Offset: 0x0036E83C
		public static void smethod_3(Dictionary<string, object> dictionary_0, LuaTable luaTable_0)
		{
			IDictionaryEnumerator dictionaryEnumerator = dictionary_0.GetEnumerator();
			while (dictionaryEnumerator.MoveNext())
			{
				luaTable_0[Conversions.ToString(dictionaryEnumerator.Key).ToLower()] = RuntimeHelpers.GetObjectValue(dictionaryEnumerator.Value);
			}
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x00370680 File Offset: 0x0036E880
		public static bool smethod_4(ref Dictionary<string, object> dictionary_0)
		{
			IDictionaryEnumerator dictionaryEnumerator = new Dictionary<string, object>(dictionary_0).GetEnumerator();
			while (dictionaryEnumerator.MoveNext())
			{
				string text = Conversions.ToString(dictionaryEnumerator.Key).ToUpper();
				RuntimeHelpers.GetObjectValue(dictionaryEnumerator.Value);
				if (Operators.CompareString(text, "UNIT", false) == 0)
				{
					text = "UNITNAME";
				}
				if (Operators.CompareString(text, "NAME", false) == 0)
				{
					text = "UNITNAME";
				}
				if (Operators.CompareString(text, "UNITNAMEORID", false) == 0)
				{
					text = "UNITNAME";
				}
				dictionary_0[text] = RuntimeHelpers.GetObjectValue(dictionaryEnumerator.Value);
			}
			return true;
		}

		// Token: 0x0600686B RID: 26731 RVA: 0x0037072C File Offset: 0x0036E92C
		public static bool smethod_5(ref Dictionary<string, object> dictionary_0)
		{
			IDictionaryEnumerator dictionaryEnumerator = new Dictionary<string, object>(dictionary_0).GetEnumerator();
			while (dictionaryEnumerator.MoveNext())
			{
				string text = Conversions.ToString(dictionaryEnumerator.Key).ToUpper();
				RuntimeHelpers.GetObjectValue(dictionaryEnumerator.Value);
				if (Operators.CompareString(text, "NAME", false) == 0)
				{
					text = "SIDE";
				}
				dictionary_0[text] = RuntimeHelpers.GetObjectValue(dictionaryEnumerator.Value);
			}
			return true;
		}

		// Token: 0x0600686C RID: 26732 RVA: 0x003707A0 File Offset: 0x0036E9A0
		public static double smethod_6(double double_0, double double_1, double double_2)
		{
			return double_0 + double_1 / 60.0 + double_2 / 3600.0;
		}

		// Token: 0x0600686D RID: 26733 RVA: 0x003707C8 File Offset: 0x0036E9C8
		public static double smethod_7(string string_0)
		{
			double result = 0.0;
			try
			{
				string left = string_0.Substring(0, 1).ToUpper();
				if (Operators.CompareString(left, "S", false) == 0 || Operators.CompareString(left, "N", false) == 0)
				{
					string_0 = string_0.Substring(1, string_0.Length - 1);
				}
				List<string> list = string_0.Split(new char[]
				{
					'.'
				}).Select(LuaUtility.stringFunc2).ToList<string>();
				double num;
				switch (list.Count)
				{
				case 1:
					num = (double)Conversions.ToInteger(string_0);
					break;
				case 2:
					num = XmlConvert.ToDouble(string_0);
					break;
				case 3:
				{
					double num2 = XmlConvert.ToDouble(list[0]);
					double num3 = XmlConvert.ToDouble(list[1]);
					double num4 = XmlConvert.ToDouble(list[2]);
					if (num2 < 0.0 | num3 < 0.0 | num4 < 0.0)
					{
						throw new Exception2("Latitude '" + string_0 + "' is hard to understand (negative numbers!). An example of a good latitude string is 'N 60.20.10'.");
					}
					if (num3 >= 60.0 | num4 >= 60.0)
					{
						throw new Exception2("Latitude '" + string_0 + "' is hard to understand (Minutes or Seconds greater or equal to 60).  An example of a good latitude string is 'N 60.20.10'.");
					}
					num = LuaUtility.smethod_6(num2, num3, num4);
					break;
				}
				default:
					throw new Exception2("Latitude '" + string_0 + "' is hard to understand (Too many numbers given). An example of a good latitude string is 'N 60.20.10'.");
				}
				if (Operators.CompareString(left, "S", false) == 0)
				{
					num = -num;
				}
				result = num;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				throw new Exception2("Latitude '" + string_0 + "' is hard to understand. An example of a good latitude string is 'N 60.20.10'.");
			}
			return result;
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x003709B4 File Offset: 0x0036EBB4
		public static double smethod_8(string string_0)
		{
			double result = 0.0;
			try
			{
				string left = string_0.Substring(0, 1).ToUpper();
				if (Operators.CompareString(left, "E", false) == 0 || Operators.CompareString(left, "W", false) == 0)
				{
					string_0 = string_0.Substring(1, string_0.Length - 1);
				}
				List<string> list = string_0.Split(new char[]
				{
					'.'
				}).Select(LuaUtility.stringFunc3).ToList<string>();
				double num;
				switch (list.Count)
				{
				case 1:
					num = (double)Conversions.ToInteger(string_0);
					break;
				case 2:
					num = XmlConvert.ToDouble(string_0);
					break;
				case 3:
				{
					double num2 = XmlConvert.ToDouble(list[0]);
					double num3 = XmlConvert.ToDouble(list[1]);
					double num4 = XmlConvert.ToDouble(list[2]);
					if (num2 < 0.0 | num3 < 0.0 | num4 < 0.0)
					{
						throw new Exception2("Longitude '" + string_0 + "' is hard to understand (negative numbers!). An example of a good longitude string is 'E 60.20.10'.");
					}
					if (num3 >= 60.0 | num4 >= 60.0)
					{
						throw new Exception2("Longitude '" + string_0 + "' is hard to understand (Minutes or Seconds greater or equal to 60). An example of a good longitude string is 'E 60.20.10'.");
					}
					num = LuaUtility.smethod_6(num2, num3, num4);
					break;
				}
				default:
					throw new Exception2("Longitude '" + string_0 + "' is hard to understand (Too many numbers given). An example of a good longitude string is 'E 60.20.10'.");
				}
				if (Operators.CompareString(left, "W", false) == 0)
				{
					num = -num;
				}
				result = num;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				throw new Exception2("Longitude '" + string_0 + "' is hard to understand. An example of a good longitude string is 'E 60.20.10'.");
			}
			return result;
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x00370BA0 File Offset: 0x0036EDA0
		public static bool? GetBooleanValue(object object_)
		{
			bool? result;
			if (object_ == null)
			{
				result = null;
			}
			else
			{
				try
				{
					if (object_ is string)
					{
						if (Operators.CompareString(Conversions.ToString(object_).ToLower(), "inherit", false) == 0)
						{
							result = null;
						}
						else
						{
							result = new bool?(bool.Parse(Conversions.ToString(object_).ToLower().Replace("yes", "true").Replace("no", "false")));
						}
					}
					else if (object_ is int)
					{
						result = new bool?(Conversions.ToInteger(object_) != 0);
					}
					else if (object_ is bool)
					{
						result = (bool?)object_;
					}
					else
					{
						if (!(object_ is double))
						{
							throw new Exception2("Lua can't understand '" + object_.ToString() + "' as a true/false value. Please use 1 or 0.");
						}
						result = new bool?(Conversions.ToDouble(object_) != 0.0);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("Lua can't understand '" + object_.ToString() + "' as a true/false value. Please use 1 or 0.");
				}
			}
			return result;
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x00370CE4 File Offset: 0x0036EEE4
		public static double? smethod_10(Dictionary<string, object> dictionary_0)
		{
			object obj = null;
			if (dictionary_0.ContainsKey("LATITUDE"))
			{
				obj = RuntimeHelpers.GetObjectValue(dictionary_0["LATITUDE"]);
			}
			return LuaUtility.smethod_11(RuntimeHelpers.GetObjectValue(obj));
		}

		// Token: 0x06006871 RID: 26737 RVA: 0x00370D24 File Offset: 0x0036EF24
		public static double? smethod_11(object object_0)
		{
			double? result;
			if (object_0 == null)
			{
				result = null;
			}
			else
			{
				double value = 0.0;
				if (object_0 is string)
				{
					value = LuaUtility.smethod_7(Conversions.ToString(object_0));
				}
				else if (object_0 is double)
				{
					value = Conversions.ToDouble(object_0);
				}
				else if (object_0 is int)
				{
					value = Conversions.ToDouble(object_0);
				}
				result = new double?(value);
			}
			return result;
		}

		// Token: 0x06006872 RID: 26738 RVA: 0x00370DA4 File Offset: 0x0036EFA4
		public static double? smethod_12(Dictionary<string, object> dictionary_0)
		{
			object obj = null;
			if (dictionary_0.ContainsKey("LONGITUDE"))
			{
				obj = RuntimeHelpers.GetObjectValue(dictionary_0["LONGITUDE"]);
			}
			return LuaUtility.smethod_13(RuntimeHelpers.GetObjectValue(obj));
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x00370DE4 File Offset: 0x0036EFE4
		public static double? smethod_13(object object_0)
		{
			double? result;
			if (object_0 == null)
			{
				result = null;
			}
			else
			{
				double value = 0.0;
				if (object_0 is string)
				{
					value = LuaUtility.smethod_8(Conversions.ToString(object_0));
				}
				else if (object_0 is double)
				{
					value = Conversions.ToDouble(object_0);
				}
				else if (object_0 is int)
				{
					value = Conversions.ToDouble(object_0);
				}
				result = new double?(value);
			}
			return result;
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x00370E64 File Offset: 0x0036F064
		public static Side smethod_14(object object_0, Scenario scenario_0)
		{
			Side result;
			if (object_0 is string)
			{
				LuaUtility.Class314 @class = new LuaUtility.Class314();
				@class.string_0 = Conversions.ToString(object_0);
				if (Operators.CompareString(@class.string_0.ToUpper(), "PlayerSide".ToUpper(), false) == 0)
				{
					result = scenario_0.GetCurrentSide();
				}
				else
				{
					result = scenario_0.GetSides().First(new Func<Side, bool>(@class.method_0));
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x00370EDC File Offset: 0x0036F0DC
		public static Side smethod_15(Dictionary<string, object> dictionary_0, Scenario scenario_0)
		{
			Side result;
			if (dictionary_0.ContainsKey("SIDE"))
			{
				result = LuaUtility.smethod_14(RuntimeHelpers.GetObjectValue(dictionary_0["SIDE"]), scenario_0);
			}
			else
			{
				if (!dictionary_0.ContainsKey("SIDENAME"))
				{
					throw new Exception2("Missing 'Side' please choose one of PlayerSide, " + string.Join(", ", scenario_0.GetSides().Select(LuaUtility.SideFunc4)));
				}
				result = LuaUtility.smethod_14(RuntimeHelpers.GetObjectValue(dictionary_0["SIDENAME"]), scenario_0);
			}
			return result;
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x00370F64 File Offset: 0x0036F164
		public static Side smethod_16(Dictionary<string, object> dictionary_0, Scenario scenario_0)
		{
			Side side = LuaUtility.smethod_15(dictionary_0, scenario_0);
			if (side == null)
			{
				throw new Exception2("Side '" + Conversions.ToString(dictionary_0["SIDE"]) + "' doesn't exist please choose one of PlayerSide, " + string.Join(", ", scenario_0.GetSides().Select(LuaUtility.SideFunc5)));
			}
			return side;
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x00370FC4 File Offset: 0x0036F1C4
		public static float? smethod_17(object object_0)
		{
			float value = 0f;
			float? num = null;
			float? result;
			if (object_0 is string)
			{
				string text = Conversions.ToString(object_0).ToUpper();
				text.Replace("-", "");
				int num2 = 0;
				if (!int.TryParse(text, out num2))
				{
					uint num3 = Class382.smethod_0(text);
					ActiveUnit_AI._AltitudePreset altitudePreset;
					if (num3 <= 1565158650u)
					{
						if (num3 <= 1492057481u)
						{
							if (num3 != 184116300u)
							{
								if (num3 != 1492057481u)
								{
									goto IL_1CE;
								}
								if (Operators.CompareString(text, "MINALTITUDE", false) != 0)
								{
									goto IL_1CE;
								}
							}
							else
							{
								if (Operators.CompareString(text, "HIGH36000", false) == 0)
								{
									altitudePreset = ActiveUnit_AI._AltitudePreset.HighAltitude36000;
									goto IL_27C;
								}
								goto IL_1CE;
							}
						}
						else if (num3 != 1519633240u)
						{
							if (num3 != 1565158650u || Operators.CompareString(text, "MINALT", false) != 0)
							{
								goto IL_1CE;
							}
						}
						else
						{
							if (Operators.CompareString(text, "HIGH25000", false) == 0)
							{
								altitudePreset = ActiveUnit_AI._AltitudePreset.HighAltitude25000;
								goto IL_27C;
							}
							goto IL_1CE;
						}
						altitudePreset = ActiveUnit_AI._AltitudePreset.MinAltitude;
						goto IL_27C;
					}
					if (num3 <= 2455723304u)
					{
						if (num3 != 2325274323u)
						{
							if (num3 != 2455723304u)
							{
								goto IL_1CE;
							}
							if (Operators.CompareString(text, "MAXALT", false) != 0)
							{
								goto IL_1CE;
							}
						}
						else
						{
							if (Operators.CompareString(text, "LOW2000", false) == 0)
							{
								altitudePreset = ActiveUnit_AI._AltitudePreset.LowAltitude2000;
								goto IL_27C;
							}
							goto IL_1CE;
						}
					}
					else if (num3 != 2968090778u)
					{
						if (num3 != 3180161568u)
						{
							if (num3 != 3973006395u || Operators.CompareString(text, "MAXALTITUDE", false) != 0)
							{
								goto IL_1CE;
							}
						}
						else
						{
							if (Operators.CompareString(text, "LOW1000", false) == 0)
							{
								altitudePreset = ActiveUnit_AI._AltitudePreset.LowAltitude1000;
								goto IL_27C;
							}
							goto IL_1CE;
						}
					}
					else
					{
						if (Operators.CompareString(text, "MED12000", false) != 0)
						{
							goto IL_1CE;
						}
						altitudePreset = ActiveUnit_AI._AltitudePreset.MediumAltitude12000;
						goto IL_27C;
					}
					altitudePreset = ActiveUnit_AI._AltitudePreset.MaxAltitude;
					goto IL_27C;
					IL_1CE:
					if (text.Contains("ft"))
					{
						value = float.Parse(text.Replace("ft", "").Replace("m", "").Trim()) * 0.3048f;
						num = new float?(value);
						result = num;
						return result;
					}
					if (text.Contains("m"))
					{
						value = float.Parse(text.Replace("ft", "").Replace("m", "").Trim());
						num = new float?(value);
						result = num;
						return result;
					}
					throw new Exception2("Invalid altitude " + text);
					IL_27C:
					value = (float)altitudePreset;
				}
				else if (text.Contains("ft"))
				{
					value = float.Parse(text.Replace("ft", "").Replace("m", "").Trim()) * 0.3048f;
				}
				else
				{
					value = float.Parse(text.Replace("ft", "").Replace("m", "").Trim());
				}
			}
			else if (object_0 is double)
			{
				value = Conversions.ToSingle(object_0);
			}
			else if (object_0 is float)
			{
				value = Conversions.ToSingle(object_0);
			}
			else if (object_0 is int)
			{
				value = Conversions.ToSingle(object_0);
			}
			num = new float?(value);
			result = num;
			return result;
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x00371314 File Offset: 0x0036F514
		public static float? smethod_18(Dictionary<string, object> dictionary_0)
		{
			object obj = null;
			if (dictionary_0.ContainsKey("ALTITUDE"))
			{
				obj = RuntimeHelpers.GetObjectValue(dictionary_0["ALTITUDE"]);
			}
			float? result = null;
			if (obj == null)
			{
				result = null;
			}
			else
			{
				result = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(obj));
			}
			return result;
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x00371370 File Offset: 0x0036F570
		public static float? smethod_19(object object_0)
		{
			float value = 0f;
			if (object_0 is string)
			{
				string text = Conversions.ToString(object_0).ToUpper();
				text.Replace("-", "");
				int num = 0;
				if (!int.TryParse(text, out num))
				{
					ActiveUnit_AI._DepthPreset depthPreset;
					if (Operators.CompareString(text, "SURFACE", false) != 0)
					{
						if (Operators.CompareString(text, "PERISCOPE", false) != 0)
						{
							if (Operators.CompareString(text, "SHALLOW", false) != 0)
							{
								if (Operators.CompareString(text, "OVERLAYER", false) != 0)
								{
									if (Operators.CompareString(text, "UNDERLAYER", false) != 0)
									{
										if (Operators.CompareString(text, "MAXDEPTH", false) != 0)
										{
											throw new Exception2("Invalid depth " + text);
										}
										depthPreset = ActiveUnit_AI._DepthPreset.MaxDepth;
									}
									else
									{
										depthPreset = ActiveUnit_AI._DepthPreset.UnderLayer;
									}
								}
								else
								{
									depthPreset = ActiveUnit_AI._DepthPreset.OverLayer;
								}
							}
							else
							{
								depthPreset = ActiveUnit_AI._DepthPreset.Shallow;
							}
						}
						else
						{
							depthPreset = ActiveUnit_AI._DepthPreset.Periscope;
						}
					}
					else
					{
						depthPreset = ActiveUnit_AI._DepthPreset.Surface;
					}
					value = (float)depthPreset;
				}
				else if (text.Contains("ft"))
				{
					value = float.Parse(text.Replace("ft", "").Replace("m", "").Trim()) * 0.3048f;
				}
				else
				{
					value = float.Parse(text.Replace("ft", "").Replace("m", "").Trim());
				}
			}
			else if (object_0 is double)
			{
				value = Conversions.ToSingle(object_0) * -1f;
			}
			else if (object_0 is float)
			{
				value = Conversions.ToSingle(object_0) * -1f;
			}
			else if (object_0 is int)
			{
				value = Conversions.ToSingle(object_0) * -1f;
			}
			float? result = new float?(value);
			return result;
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x0037152C File Offset: 0x0036F72C
		public static float? smethod_20(Dictionary<string, object> dictionary_0)
		{
			object obj = null;
			if (dictionary_0.ContainsKey("DEPTH"))
			{
				obj = RuntimeHelpers.GetObjectValue(dictionary_0["DEPTH"]);
			}
			float? result = null;
			if (obj == null)
			{
				result = null;
			}
			else
			{
				result = LuaUtility.smethod_19(RuntimeHelpers.GetObjectValue(obj));
			}
			return result;
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x00371588 File Offset: 0x0036F788
		public static ActiveUnit.Throttle smethod_21(Dictionary<string, object> dictionary_0)
		{
			ActiveUnit.Throttle result;
			if (dictionary_0.ContainsKey("THROTTLE"))
			{
				string string_ = Conversions.ToString(dictionary_0["THROTTLE"]);
				result = LuaUtility.smethod_22(string_);
			}
			else
			{
				result = ActiveUnit.Throttle.FullStop;
			}
			return result;
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x003715C4 File Offset: 0x0036F7C4
		public static ActiveUnit.Throttle smethod_22(string string_0)
		{
			string text = string_0.ToLower();
			uint num = Class382.smethod_0(text);
			if (num <= 2345205396u)
			{
				if (num <= 890022063u)
				{
					if (num != 822911587u)
					{
						if (num != 873244444u)
						{
							if (num != 890022063u)
							{
								goto IL_1CA;
							}
							if (Operators.CompareString(text, "0", false) != 0)
							{
								goto IL_1CA;
							}
						}
						else
						{
							if (Operators.CompareString(text, "1", false) != 0)
							{
								goto IL_1CA;
							}
							goto IL_1B5;
						}
					}
					else
					{
						if (Operators.CompareString(text, "4", false) != 0)
						{
							goto IL_1CA;
						}
						goto IL_167;
					}
				}
				else if (num != 906799682u)
				{
					if (num != 923577301u)
					{
						if (num != 2345205396u)
						{
							goto IL_1CA;
						}
						if (Operators.CompareString(text, "fullstop", false) != 0)
						{
							goto IL_1CA;
						}
					}
					else
					{
						if (Operators.CompareString(text, "2", false) != 0)
						{
							goto IL_1CA;
						}
						goto IL_1DB;
					}
				}
				else
				{
					if (Operators.CompareString(text, "3", false) != 0)
					{
						goto IL_1CA;
					}
					goto IL_19D;
				}
			}
			else if (num <= 3411225317u)
			{
				if (num != 2488379205u)
				{
					if (num != 2984601802u)
					{
						if (num != 3411225317u || Operators.CompareString(text, "stop", false) != 0)
						{
							goto IL_1CA;
						}
					}
					else
					{
						if (Operators.CompareString(text, "loiter", false) != 0)
						{
							goto IL_1CA;
						}
						goto IL_1B5;
					}
				}
				else
				{
					if (Operators.CompareString(text, "flank", false) == 0)
					{
						goto IL_167;
					}
					goto IL_1CA;
				}
			}
			else if (num != 3851873890u)
			{
				if (num != 4039985178u)
				{
					if (num == 4286165820u && Operators.CompareString(text, "full", false) == 0)
					{
						goto IL_19D;
					}
					goto IL_1CA;
				}
				else
				{
					if (Operators.CompareString(text, "creep", false) == 0)
					{
						goto IL_1B5;
					}
					goto IL_1CA;
				}
			}
			else
			{
				if (Operators.CompareString(text, "cruise", false) != 0)
				{
					goto IL_1CA;
				}
				goto IL_1DB;
			}
			ActiveUnit.Throttle result = ActiveUnit.Throttle.FullStop;
			return result;
			IL_167:
			result = ActiveUnit.Throttle.Flank;
			return result;
			IL_19D:
			result = ActiveUnit.Throttle.Full;
			return result;
			IL_1B5:
			result = ActiveUnit.Throttle.Loiter;
			return result;
			IL_1CA:
			throw new Exception2("Invalid throttle " + string_0);
			IL_1DB:
			result = ActiveUnit.Throttle.Cruise;
			return result;
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x003717B0 File Offset: 0x0036F9B0
		public static Group smethod_23(object object_0, Side side_0, Scenario scenario_0)
		{
			if (object_0 is string)
			{
				LuaUtility.Class315 @class = new LuaUtility.Class315();
				@class.string_0 = Conversions.ToString(object_0);
				Group result;
				if (scenario_0.GetActiveUnits().ContainsKey(@class.string_0))
				{
					ActiveUnit activeUnit = scenario_0.GetActiveUnits()[@class.string_0];
					if (!(activeUnit is Group))
					{
						throw new Exception2(string.Concat(new string[]
						{
							"Unable to understand '",
							object_0.ToString(),
							"' as a group. This is the guid for '",
							activeUnit.Name,
							"' which isn't a Group."
						}));
					}
					result = (Group)activeUnit;
				}
				else
				{
					result = (Group)side_0.ActiveUnitArray.FirstOrDefault(new Func<ActiveUnit, bool>(@class.method_0));
				}
				return result;
			}
			throw new Exception2("Unable to understand '" + object_0.ToString() + "' as a group.");
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x00371898 File Offset: 0x0036FA98
		public static Group smethod_24(Dictionary<string, object> dictionary_0, Side side_0, Scenario scenario_0)
		{
			object obj = null;
			if (dictionary_0.ContainsKey("GROUP"))
			{
				obj = RuntimeHelpers.GetObjectValue(dictionary_0["GROUP"]);
			}
			Group result;
			if (obj == null)
			{
				result = null;
			}
			else
			{
				result = LuaUtility.smethod_23(RuntimeHelpers.GetObjectValue(obj), side_0, scenario_0);
			}
			return result;
		}

		// Token: 0x0600687F RID: 26751 RVA: 0x003718E8 File Offset: 0x0036FAE8
		public static string smethod_25(Dictionary<string, object> dictionary_0, Scenario scenario_0)
		{
			ActiveUnit activeUnit = null;
			Side side = null;
			LuaUtility.smethod_4(ref dictionary_0);
			string text2;
			string result;
			if (dictionary_0.ContainsKey("GUID"))
			{
				string text = "";
				try
				{
					text = Conversions.ToString(dictionary_0["GUID"]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("Guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.GetActiveUnits()[text];
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					text2 = "Can't find guid " + text;
					ProjectData.ClearProjectError();
					result = text2;
					return result;
				}
				if (activeUnit == null)
				{
					dictionary_0.Remove("GUID");
				}
			}
			else if (dictionary_0.ContainsKey("UNITNAME"))
			{
				LuaUtility.Class316 @class = new LuaUtility.Class316();
				try
				{
					@class.string_0 = Conversions.ToString(dictionary_0["UNITNAME"]);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					throw new Exception2("Name must be a string");
				}
				if (dictionary_0.ContainsKey("SIDE"))
				{
					string text3;
					try
					{
						text3 = Conversions.ToString(dictionary_0["SIDE"]);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						throw new Exception2("Side must be a string");
					}
					try
					{
						side = LuaUtility.smethod_15(dictionary_0, scenario_0);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						text2 = "Can't find Side '" + text3 + "'";
						ProjectData.ClearProjectError();
						result = text2;
						return result;
					}
					try
					{
						activeUnit = side.ActiveUnitArray.First(new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						text2 = string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text3,
							"'"
						});
						ProjectData.ClearProjectError();
						result = text2;
						return result;
					}
					dictionary_0["GUID"] = activeUnit.GetGuid();
				}
				else
				{
					try
					{
						activeUnit = scenario_0.GetActiveUnitList().First(new Func<ActiveUnit, bool>(@class.method_1));
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						text2 = "Can't find Unit '" + @class.string_0 + "'";
						ProjectData.ClearProjectError();
						result = text2;
						return result;
					}
					dictionary_0["GUID"] = activeUnit.GetGuid();
					dictionary_0["SIDE"] = activeUnit.GetSide(false).GetSideName();
				}
			}
			text2 = "";
			result = text2;
			return result;
		}

		// Token: 0x06006880 RID: 26752 RVA: 0x00371B9C File Offset: 0x0036FD9C
		public static bool smethod_26(Dictionary<string, object> dictionary_0, Scenario scenario_0)
		{
			ActiveUnit activeUnit = null;
			Side side = null;
			bool result;
			if (dictionary_0.ContainsKey("BASE"))
			{
				LuaUtility.Class317 @class = new LuaUtility.Class317();
				side = LuaUtility.smethod_16(dictionary_0, scenario_0);
				@class.string_0 = "";
				try
				{
					@class.string_0 = Conversions.ToString(dictionary_0["BASE"]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("Base must be a string");
				}
				try
				{
					activeUnit = scenario_0.GetActiveUnits()[@class.string_0];
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					result = false;
					return result;
				}
				if (side != null && activeUnit != null && Operators.CompareString(activeUnit.GetSide(false).GetGuid(), side.GetGuid().ToLower(), false) != 0)
				{
					activeUnit = null;
				}
				if (Information.IsNothing(activeUnit))
				{
					try
					{
						activeUnit = scenario_0.GetActiveUnitList().FirstOrDefault(new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
						result = false;
						return result;
					}
				}
				if (activeUnit == null)
				{
					dictionary_0.Remove("BASE");
					result = false;
					return result;
				}
				dictionary_0["BASE"] = activeUnit.GetGuid();
			}
			result = true;
			return result;
		}

		// Token: 0x06006881 RID: 26753 RVA: 0x00371CEC File Offset: 0x0036FEEC
		public static Contact smethod_27(string NameOrId, Scenario ScenarioContext, ref Side Side)
		{
			Contact result = null;
			bool flag = false;
			checked
			{
				try
				{
					if (Side != null)
					{
						using (List<Contact>.Enumerator enumerator = Side.GetContactList().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Contact current = enumerator.Current;
								if (Operators.CompareString(current.GetGuid(), NameOrId.ToLower(), false) == 0 || Operators.CompareString(current.Name.ToUpper(), NameOrId.ToUpper(), false) == 0)
								{
									result = current;
									flag = true;
									break;
								}
							}
							goto IL_120;
						}
					}
					Side[] sides = ScenarioContext.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						if (flag)
						{
							break;
						}
						foreach (Contact current2 in side.GetContactList())
						{
							if (Operators.CompareString(current2.GetGuid(), NameOrId.ToLower(), false) == 0 || Operators.CompareString(current2.Name.ToUpper(), NameOrId.ToUpper(), false) == 0)
							{
								result = current2;
								flag = true;
								break;
							}
						}
					}
					IL_120:;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06006882 RID: 26754 RVA: 0x00371E7C File Offset: 0x0037007C
		public static long smethod_28(string string_0)
		{
			double a = 0.0;
			string[] array = Strings.Split(string_0, ":", -1, CompareMethod.Binary);
			if (array.Count<string>() == 4)
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (array[i] == "")
					{
						array[i] = "0";
					}
				}
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3]));
				a = timeSpan.TotalSeconds;
			}
			return (long)Math.Round(a);
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x00371F1C File Offset: 0x0037011C
		public static string smethod_29(object object_0)
		{
			checked
			{
				string result;
				if (object_0 is object[])
				{
					string text = "";
					bool flag = true;
					object[] array = (object[])object_0;
					for (int i = 0; i < array.Length; i++)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(array[i]);
						if (!flag)
						{
							text += ",";
						}
						else
						{
							flag = false;
						}
						text += LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(objectValue));
					}
					result = text;
				}
				else if (object_0 is string)
				{
					result = Conversions.ToString(object_0);
				}
				else if (object_0 is double)
				{
					result = Conversions.ToString(object_0);
				}
				else if (object_0 is bool)
				{
					if (Conversions.ToBoolean(object_0))
					{
						result = "'Yes'";
					}
					else
					{
						result = "'No'";
					}
				}
				else if (object_0 is LuaTable)
				{
					IDictionaryEnumerator enumerator = ((LuaTable)object_0).GetEnumerator();
					string text2 = "{";
					bool flag2 = true;
					while (enumerator.MoveNext())
					{
						if (!flag2)
						{
							text2 += ",";
						}
						else
						{
							flag2 = false;
						}
						if (enumerator.Key is string)
						{
							text2 = text2 + " " + enumerator.Key.ToString() + " = ";
						}
						else
						{
							text2 = text2 + " [" + enumerator.Key.ToString() + "] = ";
						}
						if (enumerator.Value is string)
						{
							text2 = text2 + "'" + LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(enumerator.Value)) + "'";
						}
						else if (enumerator.Value is LuaFunction)
						{
							text2 += enumerator.Value.ToString();
						}
						else if (enumerator.Value is LuaTable)
						{
							if (((LuaTable)enumerator.Value).Keys.Count > 50)
							{
								text2 += enumerator.Value.ToString();
							}
							else
							{
								text2 += LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(enumerator.Value));
							}
						}
						else
						{
							text2 += LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(enumerator.Value));
						}
					}
					text2 += " }";
					result = text2;
				}
				else if (object_0 != null)
				{
					result = object_0.ToString();
				}
				else
				{
					result = "nil";
				}
				return result;
			}
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x003721B8 File Offset: 0x003703B8
		public static void smethod_30(ref string InfoText, ref object debugTextObject, bool includeHeader = false)
		{
			try
			{
				if (!(!LuaSandBox._lua_console & !LuaSandBox._lua_event))
				{
					string text;
					if (debugTextObject.GetType() == typeof(string))
					{
						text = Conversions.ToString(debugTextObject);
					}
					else
					{
						Exception ex = (Exception)debugTextObject;
						StringBuilder stringBuilder = new StringBuilder();
						stringBuilder.Append("Exception: ").Append(ex.Message).Append("\r\n").Append("Stack Trace: ").Append(ex.StackTrace).Append("\r\n");
						if (!Information.IsNothing(ex.InnerException))
						{
							stringBuilder.Append("Inner Exception: ").Append(ex.InnerException.Message).Append("\r\n").Append("Inner StackTrace: ").Append(ex.InnerException.StackTrace).Append("\r\n");
						}
						if (ex.Data.Count > 0)
						{
							stringBuilder.Append("Call Stack & Error details: ");
							IDictionaryEnumerator enumerator = ex.Data.GetEnumerator();
							while (enumerator.MoveNext())
							{
								object current = enumerator.Current;
								DictionaryEntry dictionaryEntry = (current != null) ? ((DictionaryEntry)current) : default(DictionaryEntry);
								stringBuilder.Append("\r\n").Append(Conversions.ToString(dictionaryEntry.Key)).Append(", ").Append(Conversions.ToString(dictionaryEntry.Value));
							}
						}
						text = stringBuilder.ToString();
					}
					StringBuilder stringBuilder2 = new StringBuilder();
					if (includeHeader)
					{
						stringBuilder2.Append(DateAndTime.Now).Append(" -- B").Append("906.21").Append(" -- ").Append("\r\n");
					}
					if (InfoText.Length > 0)
					{
						stringBuilder2.Append(InfoText).Append("\r\n");
					}
					if (text.Length > 0)
					{
						stringBuilder2.Append(text).Append("\r\n");
					}
					try
					{
						string str = string.Concat(new string[]
						{
							DateAndTime.Now.Year.ToString(),
							"-",
							Strings.Right("00" + DateAndTime.Now.Month.ToString(), 2),
							"-",
							Strings.Right("00" + DateAndTime.Now.Day.ToString(), 2)
						});
						StreamWriter streamWriter = File.AppendText(MyTemplate.GetApp().Info.DirectoryPath + "\\Logs\\LuaHistory_" + str + ".txt");
						streamWriter.Write(stringBuilder2.ToString());
						streamWriter.Close();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x040038DC RID: 14556
		public static Func<Tuple<int, object>, int> TupleFunc0 = (Tuple<int, object> tuple_0) => tuple_0.Item1;

		// Token: 0x040038DD RID: 14557
		public static Func<Tuple<int, object>, object> TupleFunc1 = (Tuple<int, object> tuple_0) => tuple_0.Item2;

		// Token: 0x040038DE RID: 14558
		public static Func<string, string> stringFunc2 = (string string_0) => string_0.Trim();

		// Token: 0x040038DF RID: 14559
		public static Func<string, string> stringFunc3 = (string string_0) => string_0.Trim();

		// Token: 0x040038E0 RID: 14560
		public static Func<Side, string> SideFunc4 = (Side side_0) => side_0.GetSideName();

		// Token: 0x040038E1 RID: 14561
		public static Func<Side, string> SideFunc5 = (Side side_0) => side_0.GetSideName();

		// Token: 0x02000C36 RID: 3126
		[CompilerGenerated]
		public sealed class Class314
		{
			// Token: 0x0600688D RID: 26765 RVA: 0x0002CF58 File Offset: 0x0002B158
			internal bool method_0(Side side_0)
			{
				return Operators.CompareString(side_0.GetSideName().ToUpper(), this.string_0.ToUpper(), false) == 0 || Operators.CompareString(side_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x040038E8 RID: 14568
			public string string_0;
		}

		// Token: 0x02000C37 RID: 3127
		[CompilerGenerated]
		public sealed class Class315
		{
			// Token: 0x0600688F RID: 26767 RVA: 0x0002CF95 File Offset: 0x0002B195
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.IsGroup & Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x040038E9 RID: 14569
			public string string_0;
		}

		// Token: 0x02000C38 RID: 3128
		[CompilerGenerated]
		public sealed class Class316
		{
			// Token: 0x06006891 RID: 26769 RVA: 0x0002CFBD File Offset: 0x0002B1BD
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x06006892 RID: 26770 RVA: 0x0002CFBD File Offset: 0x0002B1BD
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x040038EA RID: 14570
			public string string_0;
		}

		// Token: 0x02000C39 RID: 3129
		[CompilerGenerated]
		public sealed class Class317
		{
			// Token: 0x06006894 RID: 26772 RVA: 0x0002CFF9 File Offset: 0x0002B1F9
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x040038EB RID: 14571
			public string string_0;
		}
	}
}
