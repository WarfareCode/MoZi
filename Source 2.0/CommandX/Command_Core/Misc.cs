using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace Command_Core
{
	// Token: 杂项
	public sealed class Misc
	{
		// Token: 0x06006627 RID: 26151 RVA: 0x0002C371 File Offset: 0x0002A571
		public static bool smethod_0(string string_0)
		{
			return !Directory.EnumerateFileSystemEntries(string_0).Any<string>();
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x00350DB8 File Offset: 0x0034EFB8
		public static string smethod_1(string string_0)
		{
			string text = Path.GetExtension(string_0);
			if (text.Length == 4)
			{
				text = Conversions.ToString(text[0]) + Conversions.ToString(text[1]) + Conversions.ToString(text[text.Length - 1]) + "w";
			}
			else
			{
				text += "w";
			}
			string text2 = Path.ChangeExtension(string_0, text);
			string result;
			if (!File.Exists(text2))
			{
				result = null;
			}
			else
			{
				string text3 = File.ReadAllText(text2);
				text3 = text3.Replace(",", ".");
				File.WriteAllText(text2, text3);
				result = text2;
			}
			return result;
		}

		// Token: 0x06006629 RID: 26153 RVA: 0x00350E60 File Offset: 0x0034F060
		public static void smethod_2(string string_0, string string_1, bool bool_0)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			if (!directoryInfo.Exists)
			{
				throw new DirectoryNotFoundException(Convert.ToString("Source directory does not exist or could not be found: ") + string_0);
			}
			if (!Directory.Exists(string_1))
			{
				Directory.CreateDirectory(string_1);
			}
			FileInfo[] files = directoryInfo.GetFiles();
			checked
			{
				for (int i = 0; i < files.Length; i++)
				{
					FileInfo fileInfo = files[i];
					string destFileName = Path.Combine(string_1, fileInfo.Name);
					fileInfo.CopyTo(destFileName, true);
				}
				if (bool_0)
				{
					DirectoryInfo[] array = directories;
					for (int j = 0; j < array.Length; j++)
					{
						DirectoryInfo directoryInfo2 = array[j];
						string string_2 = Path.Combine(string_1, directoryInfo2.Name);
						Misc.smethod_2(directoryInfo2.FullName, string_2, bool_0);
					}
				}
			}
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x00350F24 File Offset: 0x0034F124
		public static void ClearTemp(string string_0)
		{
			checked
			{
				if (!Directory.Exists(string_0))
				{
					Directory.CreateDirectory(string_0);
				}
				else
				{
					using (IEnumerator<string> enumerator = Directory.EnumerateDirectories(string_0).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Directory.Delete(enumerator.Current, true);
						}
					}
					string[] files = Directory.GetFiles(string_0);
					for (int i = 0; i < files.Length; i++)
					{
						string text = files[i];
						try
						{
							File.Delete(text);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200574: Could not delete file " + text, ex2.Message);
							bool arg_93_0 = Debugger.IsAttached;
							ProjectData.ClearProjectError();
						}
					}
				}
			}
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x00350FF0 File Offset: 0x0034F1F0
		public static string smethod_4(string string_0)
		{
			string @string = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
			if (string_0.StartsWith(@string))
			{
				string_0 = string_0.Remove(0, @string.Length);
			}
			if (!string_0.StartsWith("<"))
			{
				string_0 = "<" + string_0;
			}
			if (string_0.StartsWith("<?xml"))
			{
				string_0 = Strings.Right(string_0, Strings.Len(string_0) - Strings.InStr(string_0, ">", CompareMethod.Binary));
			}
			return string_0;
		}

		// Token: 0x0600662C RID: 26156 RVA: 0x00351078 File Offset: 0x0034F278
		public static byte[] smethod_5(byte[] byte_0)
		{
			int num = byte_0.Length - 1;
			int num2 = 0;
			byte[] array = null;
			byte[] array2;
			byte[] result;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(Conversions.ToString(Convert.ToChar(byte_0[i])), ">", false) == 0)
				{
					num2 = i;
					array2 = new byte[byte_0.Length - (num2 + 2) + 1];
					try
					{
						Array.Copy(byte_0, num2 + 1, array2, 0, array2.Length);
						byte_0 = array2;
						array = byte_0;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 101335", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						array = null;
						ProjectData.ClearProjectError();
					}
					result = array;
					return result;
				}
			}
			array2 = new byte[byte_0.Length - (num2 + 2) + 1];
			try
			{
				Array.Copy(byte_0, num2 + 1, array2, 0, array2.Length);
				byte_0 = array2;
				array = byte_0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101335", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				array = null;
				ProjectData.ClearProjectError();
			}
			result = array;
			return result;
		}

		// Token: 0x0600662D RID: 26157 RVA: 0x003511BC File Offset: 0x0034F3BC
		public static string smethod_6(string string_0)
		{
			StringBuilder stringBuilder = new StringBuilder(string_0.Length);
			string text = string_0;
			checked
			{
				for (int i = 0; i < text.Length; i++)
				{
					char c = text[i];
					if (Misc.smethod_8((int)c))
					{
						stringBuilder.Append(c);
					}
				}
				string_0 = stringBuilder.ToString();
				return string_0;
			}
		}

		// Token: 0x0600662E RID: 26158 RVA: 0x00351214 File Offset: 0x0034F414
		public static byte[] smethod_7(byte[] byte_0)
		{
			int num = byte_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (!Misc.smethod_8((int)Convert.ToChar(byte_0[i])))
				{
					byte_0[i] = 0;
				}
			}
			return byte_0;
		}

		// Token: 0x0600662F RID: 26159 RVA: 0x00351250 File Offset: 0x0034F450
		private static bool smethod_8(int int_0)
		{
			return int_0 == 9 || int_0 == 10 || int_0 == 13 || (int_0 >= 32 && int_0 <= 55295) || (int_0 >= 57344 && int_0 <= 65533) || (int_0 >= 65536 && int_0 <= 1114111);
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x003512A4 File Offset: 0x0034F4A4
		public static string GetGeoLocationString(double Latitude_, double Longitude_)
		{
			string text;
			if (Latitude_ > 0.0)
			{
				text = "北纬";
			}
			else
			{
				text = "南纬";
				Latitude_ = -Latitude_;
			}
			string text2;
			if (Longitude_ > 0.0)
			{
				text2 = "东经";
			}
			else
			{
				text2 = "西经";
				Longitude_ = -Longitude_;
			}
			return string.Concat(new string[]
			{
				text,
				Class263.smethod_9(Class263.smethod_8(Math.Round(Latitude_, 4))),
				", ",
				text2,
				Class263.smethod_9(Class263.smethod_8(Math.Round(Longitude_, 4)))
			});
		}

		// Token: 0x06006631 RID: 26161 RVA: 0x00351344 File Offset: 0x0034F544
		public static void smethod_10(Scenario scenario_0)
		{
			if (Information.IsNothing(scenario_0.GetTimeCompression()))
			{
				scenario_0.SetTimeCompression(0);
			}
			Side[] sides = scenario_0.GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					if (Information.IsNothing(side.GetMapCenter()))
					{
						side.SetMapCenter(new GeoPoint(0.0, 0.0));
					}
					if (Information.IsNothing(side.CameraAlt))
					{
						side.CameraAlt = 6000000.0;
					}
					else if (side.CameraAlt == 0.0)
					{
						side.CameraAlt = 4000000.0;
					}
				}
			}
		}

		// Token: 0x06006632 RID: 26162 RVA: 0x00351408 File Offset: 0x0034F608
		public static string smethod_11(string string_0)
		{
			int num = Strings.InStr(string_0, "|", CompareMethod.Binary);
			string result;
			if (num == 0)
			{
				result = string_0;
			}
			else
			{
				result = Strings.Left(string_0, num - 1);
			}
			return result;
		}

		// Token: 0x06006633 RID: 26163 RVA: 0x00351444 File Offset: 0x0034F644
		public static DateTime GetLocalTime(DateTime dateTime_0, double double_1, bool bool_0, string string_0, string string_1)
		{
			DateTime result;
			try
			{
				DateTime dateTime = dateTime_0.AddHours(Math.Floor((double_1 + 7.5) / 15.0));
				if (bool_0)
				{
					List<string> list = string_0.Split(new char[]
					{
						'.'
					}).ToList<string>();
					List<string> list2 = string_1.Split(new char[]
					{
						'.'
					}).ToList<string>();
					if ((Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list2[0]) & Versioned.IsNumeric(list2[1])) && ((double)dateTime_0.Day >= Conversions.ToDouble(list[0]) & (double)dateTime_0.Month >= Conversions.ToDouble(list[1])) && ((double)dateTime_0.Day <= Conversions.ToDouble(list2[0]) & (double)dateTime_0.Month <= Conversions.ToDouble(list2[1])))
					{
						dateTime = dateTime.AddHours(1.0);
					}
				}
				result = dateTime;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101099", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = default(DateTime);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006634 RID: 26164 RVA: 0x003515D8 File Offset: 0x0034F7D8
		public static string GetTimeString(long seconds, Aircraft_AirOps._Maintenance Maintenance = Aircraft_AirOps._Maintenance.const_0, bool ReturnNo = false, bool ReturnZero = false)
		{
			string text;
			string result;
			if (seconds > 2147483647L)
			{
				text = "很长时间";
			}
			else
			{
				TimeSpan timeSpan;
				try
				{
					timeSpan = TimeSpan.FromSeconds((double)seconds);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200091", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					text = "N/A";
					ProjectData.ClearProjectError();
					result = text;
					return result;
				}
				int num = (int)Math.Round(Math.Floor((double)timeSpan.Days / 7.0));
				int num2 = (int)Math.Round(Math.Floor((double)timeSpan.Days / 30.0));
				int num3 = (int)Math.Round(Math.Floor((double)timeSpan.Days / 365.0));
				if (Maintenance == Aircraft_AirOps._Maintenance.Unavailable)
				{
					text = "不可用";
				}
				else if (num3 > 0)
				{
					text = Conversions.ToString(num3) + "年" + Interaction.IIf(num2 - num3 * 12 == 0, "", " " + Conversions.ToString(num2 - num3 * 12) + "月").ToString();
				}
				else if (num2 > 0)
				{
					text = Conversions.ToString(num2) + "月" + Interaction.IIf(num - num2 * 4 == 0, "", " " + Conversions.ToString(num - num2 * 4) + "周").ToString();
				}
				else if (num > 0)
				{
					text = Conversions.ToString(num) + "周" + Interaction.IIf(timeSpan.Days - num * 7 == 0, "", " " + Conversions.ToString(timeSpan.Days - num * 7) + "天").ToString();
				}
				else if (timeSpan.Days > 0)
				{
					text = Conversions.ToString(timeSpan.Days) + "天" + Interaction.IIf(timeSpan.Hours == 0, "", " " + Conversions.ToString(timeSpan.Hours) + "小时").ToString();
				}
				else if (timeSpan.Hours > 0)
				{
					text = Conversions.ToString(timeSpan.Hours) + "小时" + Interaction.IIf(timeSpan.Minutes == 0, "", " " + Conversions.ToString(timeSpan.Minutes) + "分").ToString();
				}
				else if (timeSpan.Minutes > 0)
				{
					text = Conversions.ToString(timeSpan.Minutes) + "分" + Interaction.IIf(timeSpan.Seconds == 0, "", " " + Conversions.ToString(timeSpan.Seconds) + "秒").ToString();
				}
				else if (timeSpan.Seconds > 0)
				{
					text = Conversions.ToString(timeSpan.Seconds) + "秒";
				}
				else if (timeSpan.Seconds == 0)
				{
					if (ReturnNo)
					{
						text = "无";
					}
					else if (ReturnZero)
					{
						text = "0";
					}
					else
					{
						text = "就绪";
					}
				}
				else
				{
					text = "错误!";
				}
			}
			result = text;
			return result;
		}

		// Token: 0x06006635 RID: 26165 RVA: 0x00351968 File Offset: 0x0034FB68
		public static string smethod_14(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
			int num = byte_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				stringBuilder.Append(byte_0[i].ToString("X2"));
			}
			return stringBuilder.ToString().ToLower();
		}

		// Token: 0x06006636 RID: 26166 RVA: 0x0002C381 File Offset: 0x0002A581
		public static bool smethod_15(ConcurrentDictionary<int, bool> concurrentDictionary_0)
		{
			return !concurrentDictionary_0.GetEnumerator().MoveNext();
		}

		// Token: 0x06006637 RID: 26167 RVA: 0x0002C391 File Offset: 0x0002A591
		public static bool smethod_16(ConcurrentDictionary<Tuple<int, string>, string> concurrentDictionary_0)
		{
			return !concurrentDictionary_0.GetEnumerator().MoveNext();
		}

		// Token: 0x06006638 RID: 26168 RVA: 0x0002C3A1 File Offset: 0x0002A5A1
		public static bool smethod_17(ConcurrentDictionary<string, Contact> concurrentDictionary_0)
		{
			return !concurrentDictionary_0.GetEnumerator().MoveNext();
		}

		// Token: 0x06006639 RID: 26169 RVA: 0x0002C3B1 File Offset: 0x0002A5B1
		public static bool smethod_18(ConcurrentDictionary<long, LoggedMessage> concurrentDictionary_0)
		{
			return !concurrentDictionary_0.GetEnumerator().MoveNext();
		}

		// Token: 0x0600663A RID: 26170 RVA: 0x003519BC File Offset: 0x0034FBBC
		public static bool HasActiveMode(Sensor.SensorType SensorType_)
		{
			bool flag = false;
			bool result;
			if (SensorType_ <= Sensor.SensorType.LaserRangefinder)
			{
				if (SensorType_ <= Sensor.SensorType.ECM)
				{
					if (SensorType_ == Sensor.SensorType.Radar || SensorType_ == Sensor.SensorType.ECM)
					{
						result = true;
						return result;
					}
				}
				else if (SensorType_ == Sensor.SensorType.LaserDesignator || SensorType_ == Sensor.SensorType.LaserRangefinder)
				{
					result = true;
					return result;
				}
			}
			else if (SensorType_ <= Sensor.SensorType.TowedArray_ActiveOnly)
			{
				if (SensorType_ - Sensor.SensorType.HullSonar_ActivePassive <= 1 || SensorType_ - Sensor.SensorType.TowedArray_ActivePassive <= 1)
				{
					result = true;
					return result;
				}
			}
			else if (SensorType_ - Sensor.SensorType.VDS_ActivePassive <= 1 || SensorType_ - Sensor.SensorType.DippingSonar_ActivePassive <= 1)
			{
				result = true;
				return result;
			}
			result = flag;
			return result;
		}

		// Token: 0x0600663B RID: 26171 RVA: 0x00351A6C File Offset: 0x0034FC6C
		public static void smethod_20<T>(IList<T> ilist_0)
		{
			RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
			int i = ilist_0.Count;
			while (i > 1)
			{
				byte[] array = new byte[1];
				do
				{
					rNGCryptoServiceProvider.GetBytes(array);
				}
				while ((double)array[0] >= (double)i * (255.0 / (double)i));
				int index = (int)array[0] % i;
				i--;
				T value = ilist_0[index];
				ilist_0[index] = ilist_0[i];
				ilist_0[i] = value;
			}
		}

		// Token: 0x0600663C RID: 26172 RVA: 0x0002C3C1 File Offset: 0x0002A5C1
		public static bool smethod_21(string string_0, string string_1)
		{
			return (double)(string_0.Length - string_0.Replace(string_1, string.Empty).Length) / (double)string_1.Length == 1.0;
		}

		// Token: 0x0600663D RID: 26173 RVA: 0x00351AE0 File Offset: 0x0034FCE0
		public static string GetCockpitVisibilityLevelString(Aircraft._CockpitVisibilityLevel enum9_0)
		{
			string result;
			switch (enum9_0)
			{
			case Aircraft._CockpitVisibilityLevel.Excellent:
				result = "好";
				break;
			case Aircraft._CockpitVisibilityLevel.Average:
				result = "中";
				break;
			case Aircraft._CockpitVisibilityLevel.Poor:
				result = "差";
				break;
			default:
				result = "错误!";
				break;
			}
			return result;
		}

		// Token: 0x0600663E RID: 26174 RVA: 0x00351B2C File Offset: 0x0034FD2C
		public static string GetProficiencyLevelString(GlobalVariables.ProficiencyLevel proficiencyLevel_0)
		{
			string result;
			switch (proficiencyLevel_0)
			{
			case GlobalVariables.ProficiencyLevel.Novice:
				result = "新手";
				break;
			case GlobalVariables.ProficiencyLevel.Cadet:
				result = "实习";
				break;
			case GlobalVariables.ProficiencyLevel.Regular:
				result = "普通";
				break;
			case GlobalVariables.ProficiencyLevel.Veteran:
				result = "老手";
				break;
			case GlobalVariables.ProficiencyLevel.Ace:
				result = "顶级";
				break;
			default:
				result = "错误!";
				break;
			}
			return result;
		}

		// Token: 0x0600663F RID: 26175 RVA: 0x00351B8C File Offset: 0x0034FD8C
		public static bool HasNuclearWarhead(IEnumerable<Weapon> ienumerable_0)
		{
			bool flag = false;
			bool result;
			try
			{
				using (IEnumerator<Weapon> enumerator = ienumerable_0.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.HasNuclearWarhead())
						{
							flag = true;
							result = true;
							return result;
						}
					}
				}
				flag = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101097", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06006640 RID: 26176 RVA: 0x00351C34 File Offset: 0x0034FE34
		public static string GetDetectionAttemptTypeString(Sensor.DetectionAttemptType detectionAttemptType_0)
		{
			string result;
			switch (detectionAttemptType_0)
			{
			case Sensor.DetectionAttemptType.VolumeSearch:
				result = "搜索";
				break;
			case Sensor.DetectionAttemptType.SpecificTargetTracking:
				result = "目标跟踪";
				break;
			case Sensor.DetectionAttemptType.WeaponGuidance:
				result = "武器制导";
				break;
			case Sensor.DetectionAttemptType.Recon:
				result = "侦察";
				break;
			default:
				result = detectionAttemptType_0.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006641 RID: 26177 RVA: 0x00351C90 File Offset: 0x0034FE90
		public static string GetMessageTypeString(LoggedMessage.MessageType messageType_0)
		{
			string text;
			string result;
			switch (messageType_0)
			{
			case LoggedMessage.MessageType.NewContact:
				text = "发现新目标";
				result = text;
				return result;
			case LoggedMessage.MessageType.ContactChange:
				text = "目标变更";
				result = text;
				return result;
			case LoggedMessage.MessageType.WeaponEndgame:
				text = "武器末段计算";
				result = text;
				return result;
			case LoggedMessage.MessageType.WeaponDamage:
				text = "武器毁伤";
				result = text;
				return result;
			case LoggedMessage.MessageType.AirOps:
				text = "空中行动";
				result = text;
				return result;
			case LoggedMessage.MessageType.UnitLost:
				text = "作战单元损失";
				result = text;
				return result;
			case LoggedMessage.MessageType.UnitDamage:
				text = "作战单元毁伤";
				result = text;
				return result;
			case LoggedMessage.MessageType.PointDefence:
				text = "点防御";
				result = text;
				return result;
			case LoggedMessage.MessageType.UI:
				text = "用户界面";
				result = text;
				return result;
			case LoggedMessage.MessageType.WeaponLogic:
				text = "武器逻辑";
				result = text;
				return result;
			case LoggedMessage.MessageType.UnitAI:
				text = "作战单元AI";
				result = text;
				return result;
			case LoggedMessage.MessageType.EventEngine:
				text = "想定事件";
				result = text;
				return result;
			case LoggedMessage.MessageType.NewWeaponContact:
				text = "发现新武器目标";
				result = text;
				return result;
			case LoggedMessage.MessageType.DockingOps:
				text = "停靠行动";
				result = text;
				return result;
			case LoggedMessage.MessageType.SpecialMessage:
				text = "特殊消息";
				result = text;
				return result;
			case LoggedMessage.MessageType.NewMineContact:
				text = "发现新鱼雷目标";
				result = text;
				return result;
			case LoggedMessage.MessageType.CommsIsolatedMessage:
				text = "通信隔离消息";
				result = text;
				return result;
			case LoggedMessage.MessageType.NewAirContact:
				text = "发现新空中目标";
				result = text;
				return result;
			case LoggedMessage.MessageType.NewSurfaceContact:
				text = "发现新水面目标";
				result = text;
				return result;
			case LoggedMessage.MessageType.NewUnderwaterContact:
				text = "发现新水下目标";
				result = text;
				return result;
			case LoggedMessage.MessageType.NewGroundContact:
				text = "发现新地面目标";
				result = text;
				return result;
			case LoggedMessage.MessageType.UnguidedWeaponModifiers:
				text = "非制导武器精度修正";
				result = text;
				return result;
			}
			text = messageType_0.ToString();
			result = text;
			return result;
		}

		// Token: 0x06006642 RID: 26178 RVA: 0x00351E18 File Offset: 0x00350018
		public static string GetSatelliteTypeDescription(Satellite._SatelliteType enum80_0, SQLiteConnection sqliteConnection_0)
		{
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(sqliteConnection_0), "SELECT ST.Description from EnumSatelliteType as ST where ST.ID = " + Conversions.ToString((int)enum80_0));
		}

		// Token: 0x06006643 RID: 26179 RVA: 0x00351E44 File Offset: 0x00350044
		public static string GetSatelliteCategoryDescription(Satellite._SatelliteCategory _SatelliteCategory_0, SQLiteConnection sqliteConnection_0)
		{
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(sqliteConnection_0), "SELECT SC.Description from EnumSatelliteCategory as SC where SC.ID = " + Conversions.ToString((int)_SatelliteCategory_0));
		}

		// Token: 0x06006644 RID: 26180 RVA: 0x00351E70 File Offset: 0x00350070
		public static string GetPropulsionTypeDescription(Engine._PropulsionType enum75_0, SQLiteConnection sqliteConnection_0)
		{
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(sqliteConnection_0), "SELECT PT.Description from EnumPropulsionType as PT where PT.ID = " + Conversions.ToString((int)enum75_0));
		}

		// Token: 0x06006645 RID: 26181 RVA: 0x00351E9C File Offset: 0x0035009C
		public static string GetFuelTypeDescription(FuelRec._FuelType _FuelType_0, SQLiteConnection sqliteConnection_0)
		{
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(sqliteConnection_0), "SELECT FT.Description from EnumFuelType as FT where FT.ID = " + Conversions.ToString((int)_FuelType_0));
		}

		// Token: 0x06006646 RID: 26182 RVA: 0x00351EC8 File Offset: 0x003500C8
		public static string GetFacilityCategoryDesciption(Facility._FacilityCategory _FacilityCategory_0, SQLiteConnection sqliteConnection_0)
		{
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(sqliteConnection_0), "SELECT FC.Description from EnumFacilityCategory as FC where FC.ID = " + Conversions.ToString((int)_FacilityCategory_0));
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x00351EF4 File Offset: 0x003500F4
		public static string GetLoadoutDayNightString(Loadout._LoadoutDayNight _LoadoutDayNight_0)
		{
			string result;
			if (_LoadoutDayNight_0 != Loadout._LoadoutDayNight.None)
			{
				switch (_LoadoutDayNight_0)
				{
				case Loadout._LoadoutDayNight.DayNight:
					result = "白天/夜间";
					break;
				case Loadout._LoadoutDayNight.NightOnly:
					result = "仅夜间";
					break;
				case Loadout._LoadoutDayNight.DayOnly:
					result = "仅白天";
					break;
				default:
					result = "错误!";
					break;
				}
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x00351F54 File Offset: 0x00350154
		public static string GetWeatherProfileString(Loadout._WeatherProfile enum54_0)
		{
			string result;
			if (enum54_0 != Loadout._WeatherProfile.None)
			{
				switch (enum54_0)
				{
				case Loadout._WeatherProfile.AllWeather:
					result = "全天候";
					break;
				case Loadout._WeatherProfile.LimitedAllWeather:
					result = "有限全天候";
					break;
				case Loadout._WeatherProfile.ClearWeather:
					result = "晴好天气";
					break;
				default:
					result = "错误!";
					break;
				}
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06006649 RID: 26185 RVA: 0x00351FB4 File Offset: 0x003501B4
		public static string GetLoadoutRoleDescription(Loadout.LoadoutRole loadoutRole_0, SQLiteConnection sqliteConnection_0)
		{
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(sqliteConnection_0), "SELECT LR.Description from EnumLoadoutRole as LR where LR.ID = " + Conversions.ToString((int)loadoutRole_0));
		}

		// Token: 0x0600664A RID: 26186 RVA: 0x00351FE0 File Offset: 0x003501E0
		public static string GetAircraftTypeDescription(Aircraft._AircraftType _AircraftType_0, SQLiteConnection sqliteConnection_0)
		{
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(sqliteConnection_0), "SELECT AT.Description from EnumAircraftType as AT where AT.ID = " + Conversions.ToString((int)_AircraftType_0));
		}

		// Token: 0x0600664B RID: 26187 RVA: 0x0035200C File Offset: 0x0035020C
		public static string GetAircraftCategoryDescription(Aircraft._AircraftCategory enum11_0, SQLiteConnection sqliteConnection_0)
		{
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(sqliteConnection_0), "SELECT AC.Description from EnumAircraftCategory as AC where AC.ID = " + Conversions.ToString((int)enum11_0));
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x00352038 File Offset: 0x00350238
		public static string GetAircraftSizeClassString(GlobalVariables.AircraftSizeClass aircraftSizeClass_0, SQLiteConnection sqliteConnection_0)
		{
			string result;
			switch (aircraftSizeClass_0)
			{
			case GlobalVariables.AircraftSizeClass.None:
				result = "无";
				break;
			case GlobalVariables.AircraftSizeClass.Small:
				result = "小型飞机(0-12米长)";
				break;
			case GlobalVariables.AircraftSizeClass.Medium:
				result = "中型飞机(12.1-18米长)";
				break;
			case GlobalVariables.AircraftSizeClass.Large:
				result = "大型飞机(18.1-26米长)";
				break;
			case GlobalVariables.AircraftSizeClass.VLarge:
				result = "超大型飞机(26.1-75米长)";
				break;
			default:
				result = aircraftSizeClass_0.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600664D RID: 26189 RVA: 0x003520A0 File Offset: 0x003502A0
		public static string GetShipTypeDescription(Ship._ShipType _ShipType_0, SQLiteConnection sqliteConnection_0)
		{
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(sqliteConnection_0), "SELECT ST.Description from EnumShipType as ST where ST.ID = " + Conversions.ToString((int)_ShipType_0));
		}

		// Token: 0x0600664E RID: 26190 RVA: 0x003520CC File Offset: 0x003502CC
		public static string GetShipCategoryDescription(Ship._ShipCategory enum82_0, SQLiteConnection sqliteConnection_0)
		{
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(sqliteConnection_0), "SELECT ST.Description from EnumShipCategory as ST where ST.ID = " + Conversions.ToString((int)enum82_0));
		}

		// Token: 0x0600664F RID: 26191 RVA: 0x003520F8 File Offset: 0x003502F8
		public static string GetSubmarineTypeDescription(Submarine._SubmarineType _SubmarineType_0, SQLiteConnection sqliteConnection_0)
		{
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(sqliteConnection_0), "SELECT ST.Description from EnumSubmarineType as ST where ST.ID = " + Conversions.ToString((int)_SubmarineType_0));
		}

		// Token: 0x06006650 RID: 26192 RVA: 0x00352124 File Offset: 0x00350324
		public static string GetSubmarineCategoryDescription(Submarine._SubmarineCategory enum84_0, SQLiteConnection sqliteConnection_0)
		{
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(sqliteConnection_0), "SELECT ST.Description from EnumSubmarineCategory as ST where ST.ID = " + Conversions.ToString((int)enum84_0));
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x00352150 File Offset: 0x00350350
		public static string GetArmorTypeDescription(GlobalVariables.ArmorRating armorRating_0, SQLiteConnection sqliteConnection_0)
		{
			SQLiteDataBase db = new SQLiteDataBase(sqliteConnection_0);
			string result;
			if (armorRating_0 == GlobalVariables.ArmorRating.None)
			{
				result = "None";
			}
			else
			{
				result = CachedDataBase.ExecuteScalar(db, "SELECT AT.Description from EnumArmorType as AT where AT.ID = " + Conversions.ToString((int)armorRating_0));
			}
			return result;
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x0035219C File Offset: 0x0035039C
		public static string GetDockingFacilityPhysicalSizeDescription(DockFacility._DockFacilityPhysicalSizeCode enum21_0, SQLiteConnection sqliteConnection_0)
		{
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(sqliteConnection_0), "SELECT Description from EnumDockingFacilityPhysicalSize where ID = " + Conversions.ToString((int)enum21_0));
		}

		// Token: 0x06006653 RID: 26195 RVA: 0x003521C8 File Offset: 0x003503C8
		public static string GetAircraftRunwayLengthDescription(GlobalVariables._RunwayLengthCode enum105_0, SQLiteConnection sqliteConnection_0)
		{
			return CachedDataBase.ExecuteScalar(new SQLiteDataBase(sqliteConnection_0), "SELECT ARL.Description from EnumAircraftRunwayLength as ARL where ARL.ID = " + Conversions.ToString((int)enum105_0));
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x003521F4 File Offset: 0x003503F4
		public static string smethod_45(string string_0)
		{
			string result = "";
			try
			{
				int num = string_0.IndexOf(" ");
				if (num == -1)
				{
					result = string_0;
				}
				else
				{
					result = string_0.Substring(0, num);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101088", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = "Error!";
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006655 RID: 26197 RVA: 0x00352284 File Offset: 0x00350484
		public static string GetThrottleString(ActiveUnit.Throttle throttle_0, ActiveUnit activeUnit_0)
		{
			string result;
			switch (throttle_0)
			{
			case ActiveUnit.Throttle.FullStop:
				if (activeUnit_0.IsAircraft && ((Aircraft)activeUnit_0).IsRotaryWing(false))
				{
					result = "悬停";
				}
				else
				{
					result = "停车";
				}
				break;
			case ActiveUnit.Throttle.Loiter:
				if (activeUnit_0.IsAircraft | activeUnit_0.IsGuidedWeapon_RV_HGV())
				{
					result = "低速";
				}
				else
				{
					result = "低速";
				}
				break;
			case ActiveUnit.Throttle.Cruise:
				result = "巡航";
				break;
			case ActiveUnit.Throttle.Full:
				result = "全速";
				break;
			case ActiveUnit.Throttle.Flank:
				if (activeUnit_0.IsAircraft | activeUnit_0.IsGuidedWeapon_RV_HGV())
				{
					result = "加力";
				}
				else
				{
					result = "最大";
				}
				break;
			default:
				result = "未定义!";
				break;
			}
			return result;
		}

		// Token: 0x06006656 RID: 26198 RVA: 0x0035233C File Offset: 0x0035053C
		public static string GetActiveUnitTypeString(GlobalVariables.ActiveUnitType activeUnitType_0)
		{
			string result;
			switch (activeUnitType_0)
			{
			case GlobalVariables.ActiveUnitType.None:
				result = "无";
				break;
			case GlobalVariables.ActiveUnitType.Aircraft:
				result = "飞机";
				break;
			case GlobalVariables.ActiveUnitType.Ship:
				result = "水面舰艇";
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				result = "潜艇";
				break;
			case GlobalVariables.ActiveUnitType.Facility:
				result = "战场设施";
				break;
			case GlobalVariables.ActiveUnitType.Aimpoint:
				result = "瞄准点";
				break;
			case GlobalVariables.ActiveUnitType.Weapon:
				result = "武器";
				break;
			case GlobalVariables.ActiveUnitType.Satellite:
				result = "卫星";
				break;
			default:
				throw new NotImplementedException();
			}
			return result;
		}

		// Token: 0x06006657 RID: 26199 RVA: 0x003523C0 File Offset: 0x003505C0
		public static string GetPostureStanceString(Misc.PostureStance posture_)
		{
			string result;
			switch (posture_)
			{
			case Misc.PostureStance.Neutral:
				result = "中立方";
				break;
			case Misc.PostureStance.Friendly:
				result = "友方";
				break;
			case Misc.PostureStance.Unfriendly:
				result = "非友方";
				break;
			case Misc.PostureStance.Hostile:
				result = "敌方";
				break;
			case Misc.PostureStance.Unknown:
				result = "不明";
				break;
			default:
				throw new NotImplementedException();
			}
			return result;
		}

		// Token: 0x06006658 RID: 26200 RVA: 0x00352420 File Offset: 0x00350620
		public static XmlNode smethod_48(XmlNodeList xmlNodeList_0, string string_0)
		{
			XmlNode xmlNode2;
			XmlNode result;
			try
			{
				int num = xmlNodeList_0.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					XmlNode xmlNode = xmlNodeList_0[i];
					if (string.CompareOrdinal(xmlNode.Name, string_0) == 0)
					{
						xmlNode2 = xmlNode;
						result = xmlNode2;
						return result;
					}
				}
				xmlNode2 = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101093", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				xmlNode2 = null;
				ProjectData.ClearProjectError();
			}
			result = xmlNode2;
			return result;
		}

		// Token: 0x06006659 RID: 26201 RVA: 0x003524C8 File Offset: 0x003506C8
		public static string smethod_49(Stream stream_)
		{
			long position = stream_.Position;
			stream_.Position = 0L;
			string result = new StreamReader(stream_).ReadToEnd();
			stream_.Position = position;
			return result;
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x00352504 File Offset: 0x00350704
		public static GeoPoint smethod_50(List<GeoPoint> GeoPoints)
		{
			GeoPoint result = null;
			try
			{
				double num = 0.0;
				double num2 = 0.0;
				double num3 = 0.0;
				foreach (GeoPoint current in GeoPoints)
				{
					double num4 = Math.Cos(0.0174532925199433 * current.GetLatitude()) * Math.Cos(0.0174532925199433 * current.GetLongitude());
					double num5 = Math.Cos(0.0174532925199433 * current.GetLatitude()) * Math.Sin(0.0174532925199433 * current.GetLongitude());
					double num6 = Math.Sin(0.0174532925199433 * current.GetLatitude());
					num += num4;
					num2 += num5;
					num3 += num6;
				}
				double num7 = Math.Sqrt(num * num + num2 * num2 + num3 * num3);
				num /= num7;
				num2 /= num7;
				num3 /= num7;
				double num8 = Math.Atan2(num2, num);
				double x = Math.Sqrt(num * num + num2 * num2);
				double num9 = Math.Atan2(num3, x);
				result = new GeoPoint(57.2957795130823 * num8, 57.2957795130823 * num9);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101332", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new GeoPoint(0.0, 0.0);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600665B RID: 26203 RVA: 0x003526DC File Offset: 0x003508DC
		public static GeoPoint smethod_51(List<ReferencePoint> list_0)
		{
			GeoPoint result = null;
			try
			{
				result = Misc.smethod_50(list_0.Cast<GeoPoint>().ToList<GeoPoint>());
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101331", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new GeoPoint(0.0, 0.0);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600665C RID: 26204 RVA: 0x00352764 File Offset: 0x00350964
		public static bool smethod_52(List<GeoPoint> list_0)
		{
			bool result = false;
			try
			{
				if (Math2.smethod_19(list_0))
				{
					List<GeoPoint> list = new List<GeoPoint>();
					foreach (GeoPoint current in list_0)
					{
						list.Add(new GeoPoint(Math2.NormalizeLongitude(current.GetLongitude() + 180.0), current.GetLatitude()));
					}
					result = Math2.smethod_19(list);
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
				ex2.Data.Add("Error at 101091", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600665D RID: 26205 RVA: 0x00352840 File Offset: 0x00350A40
		public static string GetTechGenerationString(GlobalVariables.TechGenerationClass techGenerationClass_0)
		{
			string result;
			if (techGenerationClass_0 != GlobalVariables.TechGenerationClass.NotApplicable)
			{
				switch (techGenerationClass_0)
				{
				case GlobalVariables.TechGenerationClass.Early1950s:
					result = "1950年代早期";
					break;
				case GlobalVariables.TechGenerationClass.Late1950s:
					result = "1950年代晚期";
					break;
				case GlobalVariables.TechGenerationClass.Early1960s:
					result = "1960年代早期";
					break;
				case GlobalVariables.TechGenerationClass.Late1960s:
					result = "1960年代晚期";
					break;
				case GlobalVariables.TechGenerationClass.Early1970s:
					result = "1970年代早期";
					break;
				case GlobalVariables.TechGenerationClass.Late1970s:
					result = "1970年代晚期";
					break;
				case GlobalVariables.TechGenerationClass.Early1980s:
					result = "1980年代早期";
					break;
				case GlobalVariables.TechGenerationClass.Late1980s:
					result = "1980年代晚期";
					break;
				case GlobalVariables.TechGenerationClass.Early1990s:
					result = "1990年代早期";
					break;
				case GlobalVariables.TechGenerationClass.Late1990s:
					result = "1990年代晚期";
					break;
				case GlobalVariables.TechGenerationClass.Early2000s:
					result = "2000年代早期";
					break;
				case GlobalVariables.TechGenerationClass.Late2000s:
					result = "2000年代晚期";
					break;
				case GlobalVariables.TechGenerationClass.Early2010s:
					result = "2010年代早期";
					break;
				case GlobalVariables.TechGenerationClass.Late2010s:
					result = "2010年代晚期";
					break;
				default:
					switch (techGenerationClass_0)
					{
					case GlobalVariables.TechGenerationClass.IR_SingleSpectral:
						result = "单谱红外";
						break;
					case GlobalVariables.TechGenerationClass.IR_DualSpectral:
						result = "双谱红外";
						break;
					case GlobalVariables.TechGenerationClass.IR_Imaging_FPA:
						result = "成像红外";
						break;
					default:
						result = techGenerationClass_0.ToString();
						break;
					}
					break;
				}
			}
			else
			{
				result = "N/A";
			}
			return result;
		}

		// Token: 0x0600665E RID: 26206 RVA: 0x00352968 File Offset: 0x00350B68
		public static string GetFireIntensityString(ActiveUnit_Damage.FireIntensityLevel? nullable_0)
		{
			ActiveUnit_Damage.FireIntensityLevel? fireIntensityLevel = nullable_0;
			byte? b = fireIntensityLevel.HasValue ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null;
			string result;
			if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				result = "无失火";
			}
			else
			{
				b = (fireIntensityLevel.HasValue ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					result = "小型失火";
				}
				else
				{
					b = (fireIntensityLevel.HasValue ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						result = "大型失火";
					}
					else
					{
						b = (fireIntensityLevel.HasValue ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							result = "严重失火";
						}
						else
						{
							b = (fireIntensityLevel.HasValue ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								result = "快速燃烧";
							}
							else
							{
								result = nullable_0.ToString();
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600665F RID: 26207 RVA: 0x00352B60 File Offset: 0x00350D60
		public static string GetFloodingIntensityString(ActiveUnit_Damage.FloodingIntensityLevel? nullable_0)
		{
			ActiveUnit_Damage.FloodingIntensityLevel? floodingIntensityLevel = nullable_0;
			byte? b = floodingIntensityLevel.HasValue ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null;
			string result;
			if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				result = "没有进水";
			}
			else
			{
				b = (floodingIntensityLevel.HasValue ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					result = "小规模进水";
				}
				else
				{
					b = (floodingIntensityLevel.HasValue ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						result = "大规模进水";
					}
					else
					{
						b = (floodingIntensityLevel.HasValue ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							result = "严重进水";
						}
						else
						{
							b = (floodingIntensityLevel.HasValue ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								result = "即将沉没";
							}
							else
							{
								result = nullable_0.ToString();
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06006660 RID: 26208 RVA: 0x00352D58 File Offset: 0x00350F58
		public static string GetBDAString(Contact._BattleDamageAssessment? BDA_)
		{
			Contact._BattleDamageAssessment? battleDamageAssessment = BDA_;
			byte? b = battleDamageAssessment.HasValue ? new byte?((byte)battleDamageAssessment.GetValueOrDefault()) : null;
			string result;
			if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				result = "未毁伤";
			}
			else
			{
				b = (battleDamageAssessment.HasValue ? new byte?((byte)battleDamageAssessment.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					result = "轻度毁伤";
				}
				else
				{
					b = (battleDamageAssessment.HasValue ? new byte?((byte)battleDamageAssessment.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						result = "中度毁伤";
					}
					else
					{
						b = (battleDamageAssessment.HasValue ? new byte?((byte)battleDamageAssessment.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							result = "重度毁伤";
						}
						else
						{
							b = (battleDamageAssessment.HasValue ? new byte?((byte)battleDamageAssessment.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								result = "摧毁";
							}
							else
							{
								result = BDA_.ToString();
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06006661 RID: 26209 RVA: 0x00352F50 File Offset: 0x00351150
		public static string GetWeaponTypeString(Weapon._WeaponType _WeaponType_0)
		{
			string text;
			string result;
			if (_WeaponType_0 <= Weapon._WeaponType.FerryTank)
			{
				if (_WeaponType_0 == Weapon._WeaponType.None)
				{
					text = "None";
					result = text;
					return result;
				}
				switch (_WeaponType_0)
				{
				case Weapon._WeaponType.GuidedWeapon:
					text = "制导武器";
					result = text;
					return result;
				case Weapon._WeaponType.Rocket:
					text = "火箭";
					result = text;
					return result;
				case Weapon._WeaponType.IronBomb:
					text = "非制导弹药b";
					result = text;
					return result;
				case Weapon._WeaponType.Gun:
					text = "火炮";
					result = text;
					return result;
				case Weapon._WeaponType.Decoy_Expendable:
					text = "诱饵(可消耗)";
					result = text;
					return result;
				case Weapon._WeaponType.Decoy_Towed:
					text = "诱饵(拖曳)";
					result = text;
					return result;
				case Weapon._WeaponType.Decoy_Vehicle:
					text = "诱饵(车)";
					result = text;
					return result;
				case Weapon._WeaponType.TrainingRound:
					text = "训练弹";
					result = text;
					return result;
				default:
					switch (_WeaponType_0)
					{
					case Weapon._WeaponType.SensorPod:
						text = "Sensor/EW Pod";
						result = text;
						return result;
					case Weapon._WeaponType.DropTank:
						text = "副油箱";
						result = text;
						return result;
					case Weapon._WeaponType.BuddyStore:
						text = "Buddy Store";
						result = text;
						return result;
					case Weapon._WeaponType.FerryTank:
						text = "Ferry Tank";
						result = text;
						return result;
					}
					break;
				}
			}
			else if (_WeaponType_0 <= Weapon._WeaponType.RV)
			{
				switch (_WeaponType_0)
				{
				case Weapon._WeaponType.Torpedo:
					text = "鱼雷";
					result = text;
					return result;
				case Weapon._WeaponType.DepthCharge:
					text = "深水炸弹";
					result = text;
					return result;
				case Weapon._WeaponType.Sonobuoy:
					text = "声纳浮标";
					result = text;
					return result;
				case Weapon._WeaponType.BottomMine:
					text = "沉底雷";
					result = text;
					return result;
				case Weapon._WeaponType.MooredMine:
					text = "锚雷";
					result = text;
					return result;
				case Weapon._WeaponType.FloatingMine:
					text = "漂雷";
					result = text;
					return result;
				case Weapon._WeaponType.MovingMine:
					text = "移动水雷";
					result = text;
					return result;
				case Weapon._WeaponType.RisingMine:
					text = "上浮水雷";
					result = text;
					return result;
				default:
					if (_WeaponType_0 == Weapon._WeaponType.RV)
					{
						text = "再入飞行器";
						result = text;
						return result;
					}
					break;
				}
			}
			else
			{
				if (_WeaponType_0 == Weapon._WeaponType.Laser)
				{
					text = "激光";
					result = text;
					return result;
				}
				switch (_WeaponType_0)
				{
				case Weapon._WeaponType.Cargo:
					text = "货物";
					result = text;
					return result;
				case Weapon._WeaponType.Troops:
					text = "部队";
					result = text;
					return result;
				case Weapon._WeaponType.Paratroops:
					text = "伞兵";
					result = text;
					return result;
				}
			}
			text = _WeaponType_0.ToString();
			result = text;
			return result;
		}

		// Token: 0x06006662 RID: 26210 RVA: 0x0035318C File Offset: 0x0035138C
		public static string GetTargetVisualSizeClassString(GlobalVariables.TargetVisualSizeClass targetVisualSizeClass_0)
		{
			string result;
			switch (targetVisualSizeClass_0)
			{
			case GlobalVariables.TargetVisualSizeClass.Stealthy:
				result = "超小";
				break;
			case GlobalVariables.TargetVisualSizeClass.VSmall:
				result = "很小";
				break;
			case GlobalVariables.TargetVisualSizeClass.Small:
				result = "小";
				break;
			case GlobalVariables.TargetVisualSizeClass.Medium:
				result = "中";
				break;
			case GlobalVariables.TargetVisualSizeClass.Large:
				result = "大";
				break;
			case GlobalVariables.TargetVisualSizeClass.VLarge:
				result = "超大";
				break;
			case GlobalVariables.TargetVisualSizeClass.Unknown:
				result = "不明";
				break;
			default:
				result = targetVisualSizeClass_0.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x0035320C File Offset: 0x0035140C
		public static string GetActiveUnitStatusString(ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_0, ActiveUnit activeUnit_0)
		{
			ActiveUnit._ActiveUnitFuelState fuelState = activeUnit_0.GetFuelState();
			ActiveUnit._ActiveUnitWeaponState weaponState = activeUnit_0.GetWeaponState();
			string text = "";
			if (fuelState == ActiveUnit._ActiveUnitFuelState.IsBingo)
			{
				text = "最低油量状态";
			}
			else if (fuelState == ActiveUnit._ActiveUnitFuelState.IsJoker)
			{
				text = "Joker";
			}
			else if (fuelState == ActiveUnit._ActiveUnitFuelState.IgnoreBingoAndJoker)
			{
				text = "RTB order cancelled after reaching fuel/weapon state";
			}
			if (weaponState == ActiveUnit._ActiveUnitWeaponState.IsWinchester)
			{
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += " and ";
				}
				text += "Winchester";
			}
			else if (weaponState == ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO)
			{
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += " and ";
				}
				text += "Winchester, engaging opportunity target";
			}
			else if (weaponState == ActiveUnit._ActiveUnitWeaponState.IsShotgun)
			{
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += " and ";
				}
				text += "Shotgun";
			}
			else if (weaponState == ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO)
			{
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += " and ";
				}
				text += "Shotgun, engaging opportunity target";
			}
			else if (fuelState != ActiveUnit._ActiveUnitFuelState.IgnoreBingoAndJoker && weaponState == ActiveUnit._ActiveUnitWeaponState.IgnoreWinchesterAndShotgun)
			{
				text = "RTB order cancelled after reaching fuel/weapon state";
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				text = " (" + text + ")";
			}
			string text2;
			string result;
			switch (_ActiveUnitStatus_0)
			{
			case ActiveUnit._ActiveUnitStatus.Unassigned:
				text2 = "未分配任务" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.OnPlottedCourse:
				text2 = "按计划航行" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.EngagedOffensive:
				text2 = "参与进攻行动" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.EngagedDefensive:
				text2 = "参与防御行动" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.OnAttackRun:
				text2 = "On Attack Run" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.OnPatrol:
				text2 = "正在巡逻" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.RTB:
				text2 = "返回基地" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.Tasked:
				if (activeUnit_0.GetAI().IsEscort)
				{
					text2 = "任务护航" + text;
					result = text2;
					return result;
				}
				text2 = "正在执行任务" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.FormingUp:
				text2 = "形成编队" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.RTB_Manual:
				text2 = "返回基地(受命)" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.OnSupportMission:
				text2 = "正在执行保障任务" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.OnFerryMission:
				text2 = "正在执行转场任务" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint:
				text2 = "正飞赴加油点" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.Refuelling:
				text2 = "正在加油" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.RTB_MissionOver:
				text2 = "返回基地(任务完成)" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.GroupLead_SlowingToAllowFormUp:
				text2 = "降速(编队整理阵形)" + text;
				result = text2;
				return result;
			case ActiveUnit._ActiveUnitStatus.RTB_Group:
				text2 = "返回基地(编组命令)" + text;
				result = text2;
				return result;
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			text2 = _ActiveUnitStatus_0.ToString();
			result = text2;
			return result;
		}

		// Token: 0x06006664 RID: 26212 RVA: 0x00353554 File Offset: 0x00351754
		public static void smethod_60(Collection<ActiveUnit> UnitsCollection, Scenario theScen, Side theSide, Mission theMission = null)
		{
			try
			{
				foreach (ActiveUnit current in UnitsCollection)
				{
					if (!Information.IsNothing(current.GetParentGroup(false)))
					{
						current.SetParentGroup(false, null);
					}
				}
				if (UnitsCollection.Select(Misc.ActiveUnitFunc0).Where(Misc.ActiveUnitFunc1).Count<ActiveUnit>() == UnitsCollection.Count)
				{
					IEnumerable<int> enumerable = UnitsCollection.Select(Misc.ActiveUnitFunc2).Distinct<int>();
					using (IEnumerator<int> enumerator2 = enumerable.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							int current2 = enumerator2.Current;
							Misc.LoadoutChecker loadoutChecker = new Misc.LoadoutChecker(null);
							loadoutChecker.LoadoutDBID = current2;
							List<ActiveUnit> list = new List<ActiveUnit>();
							IEnumerable<ActiveUnit> enumerable2 = UnitsCollection.Where(new Func<ActiveUnit, bool>(loadoutChecker.HasSameLoadout));
							foreach (ActiveUnit current3 in enumerable2)
							{
								list.Add(current3);
							}
							if (list.Count > 1)
							{
								Group group = new Group(ref theScen, ref theSide, list, false, null, null);
								if (!Information.IsNothing(theMission))
								{
									group.m_Doctrine = theMission.m_Doctrine;
								}
							}
						}
						goto IL_176;
					}
				}
				List<ActiveUnit> list2 = new List<ActiveUnit>();
				list2.AddRange(UnitsCollection);
				Group group2 = new Group(ref theScen, ref theSide, list2, false, null, null);
				if (!Information.IsNothing(theMission))
				{
					group2.m_Doctrine = theMission.m_Doctrine;
				}
				IL_176:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101092", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006665 RID: 26213 RVA: 0x00353780 File Offset: 0x00351980
		public static float smethod_61(float float_0, float float_1)
		{
			return (float)((double)((float)((double)((float)((double)float_0 * 1.68780986) * (360f / float_1)) / 3.14159265358979 / 2.0)) / 6076.11549);
		}

		// Token: 0x06006666 RID: 26214 RVA: 0x003537C8 File Offset: 0x003519C8
		public static List<List<GraphicsPath>> smethod_62(List<GraphicsPath> SourceList, int ListSize = 30)
		{
			List<List<GraphicsPath>> list = new List<List<GraphicsPath>>();
			for (int i = 0; i < SourceList.Count; i += ListSize)
			{
				list.Add(SourceList.GetRange(i, Math.Min(ListSize, SourceList.Count - i)));
			}
			return list;
		}

		// Token: 0x06006667 RID: 26215 RVA: 0x0035380C File Offset: 0x00351A0C
		public static Misc.Enum102 smethod_63(float float_0, float float_1)
		{
			float_1 = Math2.Normalize(float_1 - float_0);
			float_0 = 0f;
			Misc.Enum102 result;
			if (float_1 > 180f)
			{
				result = Misc.Enum102.const_0;
			}
			else
			{
				result = Misc.Enum102.const_1;
			}
			return result;
		}

		// Token: 0x06006668 RID: 26216 RVA: 0x0002C3EF File Offset: 0x0002A5EF
		public static bool smethod_64(string text, string value, StringComparison comparisonType)
		{
			return text.IndexOf(value, comparisonType) >= 0;
		}

		// Token: 0x04003838 RID: 14392
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc0 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04003839 RID: 14393
		public static Func<ActiveUnit, bool> ActiveUnitFunc1 = (ActiveUnit activeUnit_0) => activeUnit_0.IsAircraft;

		// Token: 0x0400383A RID: 14394
		public static Func<ActiveUnit, int> ActiveUnitFunc2 = (ActiveUnit activeUnit_0) => ((Aircraft)activeUnit_0).GetLoadoutDBID();

		// Token: 0x0400383B RID: 14395
		public static double double_0;

		// Token: 0x0400383C RID: 14396
		private static readonly MD5 md5_0 = MD5.Create();

		// Token: 0x02000C02 RID: 3074
		public enum PostureStance : byte
		{
			// Token: 0x04003841 RID: 14401
			Neutral,
			// Token: 0x04003842 RID: 14402
			Friendly,
			// Token: 0x04003843 RID: 14403
			Unfriendly,
			// Token: 0x04003844 RID: 14404
			Hostile,
			// Token: 0x04003845 RID: 14405
			Unknown
		}

		// Token: 0x02000C03 RID: 3075
		public enum Enum102
		{
			// Token: 0x04003847 RID: 14407
			const_0 = 1,
			// Token: 0x04003848 RID: 14408
			const_1
		}

		// Token: 0x02000C04 RID: 3076
		[CompilerGenerated]
		public sealed class LoadoutChecker
		{
			// Token: 0x0600666E RID: 26222 RVA: 0x0002C3FF File Offset: 0x0002A5FF
			public LoadoutChecker(Misc.LoadoutChecker LoadoutChecker_)
			{
				if (LoadoutChecker_ != null)
				{
					this.LoadoutDBID = LoadoutChecker_.LoadoutDBID;
				}
			}

			// Token: 0x0600666F RID: 26223 RVA: 0x0002C419 File Offset: 0x0002A619
			internal bool HasSameLoadout(ActiveUnit activeUnit_)
			{
				return ((Aircraft)activeUnit_).GetLoadoutDBID() == this.LoadoutDBID;
			}

			// Token: 0x04003849 RID: 14409
			public int LoadoutDBID;
		}
	}
}
