using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace Command_Core
{
	// Token: 气象
	public sealed class Weather
	{
		// 取气象剖面
		public static Weather.WeatherProfile GetWeatherProfile(Scenario scenario_0, double double_0, double double_1, int int_0)
		{
			Scenario.WeatherModellingLevel weatherLevel = scenario_0.WeatherLevel;
			if (weatherLevel != Scenario.WeatherModellingLevel.Level0)
			{
				throw new NotImplementedException();
			}
			return scenario_0.GetWeatherProfile();
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x003869B8 File Offset: 0x00384BB8
		public static double smethod_1(double DeltaN)
		{
			double num = 157.0 / (157.0 - DeltaN);
			return 6371.0 * num;
		}

		// Token: 0x06006923 RID: 26915 RVA: 0x003869E8 File Offset: 0x00384BE8
		public static void smethod_2(Weather._AtmosphereType AtmosphereType, int Altitude, ref Weather._Atmosphere Atmosphere, float? TemperatureAtSL_Celcius = null)
		{
			double num = (double)Altitude / 1000.0;
			if (Information.IsNothing(TemperatureAtSL_Celcius))
			{
				TemperatureAtSL_Celcius = new float?(15f);
			}
			double? num2 = TemperatureAtSL_Celcius.HasValue ? new double?((double)TemperatureAtSL_Celcius.GetValueOrDefault()) : null;
			float num3 = (float)(num2.HasValue ? new double?(num2.GetValueOrDefault() + 273.15) : null).Value;
			switch (AtmosphereType)
			{
			case Weather._AtmosphereType.const_0:
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_0 = 1012.8186 - 111.5569 * num + 3.8646 * num * num;
				}
				else if (num > 10.0 & num <= 72.0)
				{
					Atmosphere.double_0 = 283.709 * Math.Exp(-0.147 * (num - 10.0));
				}
				else if (num > 72.0 & num <= 100.0)
				{
					Atmosphere.double_0 = 0.0312402229 * Math.Exp(-0.165 * (num - 72.0));
				}
				else
				{
					Atmosphere.double_0 = 0.0;
				}
				if (num >= 0.0 & num <= 13.0)
				{
					Atmosphere.double_1 = 294.9838 - 5.2159 * num - 0.07109 * num * num;
				}
				else if (num > 13.0 & num <= 17.0)
				{
					Atmosphere.double_1 = 215.15;
				}
				else if (num > 17.0 & num <= 47.0)
				{
					Atmosphere.double_1 = 215.15 * Math.Exp(0.008128 * (num - 17.0));
				}
				else if (num > 47.0 & num <= 53.0)
				{
					Atmosphere.double_1 = 275.0;
				}
				else if (num > 53.0 & num <= 80.0)
				{
					Atmosphere.double_1 = 275.0 + 20.0 * (1.0 - Math.Exp(0.06 * (num - 53.0)));
				}
				else if (num > 80.0 & num <= 100.0)
				{
					Atmosphere.double_1 = 175.0;
				}
				else
				{
					Atmosphere.double_1 = 0.0;
				}
				if (num >= 0.0 & num <= 15.0)
				{
					Atmosphere.double_2 = 14.2542 * Math.Exp(-0.4174 * num - 0.0229 * num * num + 0.001007 * num * num * num);
				}
				else
				{
					Atmosphere.double_2 = 0.0;
				}
				break;
			case Weather._AtmosphereType.const_1:
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_0 = 1018.8627 - 124.2954 * num + 4.8307 * num * num;
				}
				else if (num > 10.0 & num <= 72.0)
				{
					Atmosphere.double_0 = 258.9787 * Math.Exp(-0.147 * (num - 10.0));
				}
				else if (num > 72.0 & num <= 100.0)
				{
					Atmosphere.double_0 = 0.0285170199 * Math.Exp(-0.155 * (num - 72.0));
				}
				else
				{
					Atmosphere.double_0 = 0.0;
				}
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_1 = 272.7241 - 3.6217 * num - 0.1759 * num * num;
				}
				else if (num > 10.0 & num <= 33.0)
				{
					Atmosphere.double_1 = 218.0;
				}
				else if (num > 33.0 & num <= 47.0)
				{
					Atmosphere.double_1 = 218.0 + 3.3571 * (num - 33.0);
				}
				else if (num > 47.0 & num <= 53.0)
				{
					Atmosphere.double_1 = 265.0;
				}
				else if (num > 53.0 & num <= 80.0)
				{
					Atmosphere.double_1 = 265.0 - 2.037 * (num - 53.0);
				}
				else if (num > 80.0 & num <= 100.0)
				{
					Atmosphere.double_1 = 210.0;
				}
				else
				{
					Atmosphere.double_1 = 0.0;
				}
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_2 = 3.4742 * Math.Exp(-0.2697 * num - 0.03604 * num * num + 0.0004489 * num * num * num);
				}
				else
				{
					Atmosphere.double_2 = 0.0;
				}
				break;
			case Weather._AtmosphereType.const_2:
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_0 = 1008.0278 - 113.2494 * num + 3.9408 * num * num;
				}
				else if (num > 10.0 & num <= 72.0)
				{
					Atmosphere.double_0 = 269.6138 * Math.Exp(-0.14 * (num - 10.0));
				}
				else if (num > 72.0 & num <= 100.0)
				{
					Atmosphere.double_0 = 0.0458211532 * Math.Exp(-0.165 * (num - 72.0));
				}
				else
				{
					Atmosphere.double_0 = 0.0;
				}
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_1 = 286.8374 - 4.7805 * num - 0.1402 * num * num;
				}
				else if (num > 10.0 & num <= 23.0)
				{
					Atmosphere.double_1 = 225.0;
				}
				else if (num > 23.0 & num <= 48.0)
				{
					Atmosphere.double_1 = 225.0 * Math.Exp(0.008317 * (num - 23.0));
				}
				else if (num > 48.0 & num <= 53.0)
				{
					Atmosphere.double_1 = 277.0;
				}
				else if (num > 53.0 & num <= 79.0)
				{
					Atmosphere.double_1 = 277.0 - 4.0769 * (num - 53.0);
				}
				else if (num > 79.0 & num <= 100.0)
				{
					Atmosphere.double_1 = 171.0;
				}
				else
				{
					Atmosphere.double_1 = 0.0;
				}
				if (num >= 0.0 & num <= 15.0)
				{
					Atmosphere.double_2 = 8.988 * Math.Exp(-0.3614 * num - 0.005402 * num * num - 0.001955 * num * num * num);
				}
				else
				{
					Atmosphere.double_2 = 0.0;
				}
				break;
			case Weather._AtmosphereType.const_3:
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_0 = 1010.8828 - 122.2411 * num + 4.554 * num * num;
				}
				else if (num > 10.0 & num <= 72.0)
				{
					Atmosphere.double_0 = 243.8718 * Math.Exp(-0.147 * (num - 10.0));
				}
				else if (num > 72.0 & num <= 100.0)
				{
					Atmosphere.double_0 = 0.0268535481 * Math.Exp(-0.15 * (num - 72.0));
				}
				else
				{
					Atmosphere.double_0 = 0.0;
				}
				if (num >= 0.0 & num <= 8.5)
				{
					Atmosphere.double_1 = 257.4345 + 2.3474 * num - 1.5479 * num * num + 0.08473 * num * num * num;
				}
				else if (num > 8.5 & num <= 30.0)
				{
					Atmosphere.double_1 = 217.5;
				}
				else if (num > 30.0 & num <= 50.0)
				{
					Atmosphere.double_1 = 217.5 + 2.125 * (num - 30.0);
				}
				else if (num > 50.0 & num <= 54.0)
				{
					Atmosphere.double_1 = 260.0;
				}
				else if (num > 54.0 & num <= 100.0)
				{
					Atmosphere.double_1 = 260.0 - 1.667 * (num - 54.0);
				}
				else
				{
					Atmosphere.double_1 = 0.0;
				}
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_2 = 1.2319 * Math.Exp(0.07481 * num - 0.0981 * num * num + 0.00281 * num * num * num);
				}
				else
				{
					Atmosphere.double_2 = 0.0;
				}
				break;
			case Weather._AtmosphereType.const_4:
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_0 = 1012.0306 - 109.0338 * num + 3.6316 * num * num;
				}
				else if (num > 10.0 & num <= 72.0)
				{
					Atmosphere.double_0 = 284.8526 * Math.Exp(-0.147 * (num - 10.0));
				}
				else if (num > 72.0 & num <= 100.0)
				{
					Atmosphere.double_0 = 0.0313660825 * Math.Exp(-0.165 * (num - 72.0));
				}
				else
				{
					Atmosphere.double_0 = 0.0;
				}
				if (num >= 0.0 & num <= 17.0)
				{
					Atmosphere.double_1 = 300.4222 - 6.3533 * num + 0.005886 * num * num;
				}
				else if (num > 17.0 & num <= 47.0)
				{
					Atmosphere.double_1 = 194.0 + 2.533 * (num - 17.0);
				}
				else if (num > 47.0 & num <= 52.0)
				{
					Atmosphere.double_1 = 270.0;
				}
				else if (num > 52.0 & num <= 80.0)
				{
					Atmosphere.double_1 = 270.0 - 3.0714 * (num - 52.0);
				}
				else if (num > 80.0 & num <= 100.0)
				{
					Atmosphere.double_1 = 184.0;
				}
				else
				{
					Atmosphere.double_1 = 0.0;
				}
				if (num >= 0.0 & num <= 15.0)
				{
					Atmosphere.double_2 = 19.6542 * Math.Exp(-0.2313 * num - 0.1122 * num * num + 0.01351 * num * num * num - 0.0005923 * num * num * num * num);
				}
				else
				{
					Atmosphere.double_2 = 0.0;
				}
				break;
			case Weather._AtmosphereType.const_5:
				if (num >= 0.0 & num <= 11.0)
				{
					Atmosphere.double_0 = 1013.25 * Math.Pow(288.15 / (288.15 + -6.5 * num), -5.2558461538461536);
				}
				else if (num > 11.0 & num <= 20.0)
				{
					Atmosphere.double_0 = 226.3226 * Math.Exp(-34.163 * (num - 11.0) / 216.65);
				}
				else if (num > 20.0 & num <= 32.0)
				{
					Atmosphere.double_0 = 54.7498 * Math.Pow(216.65 / (216.65 + 1.0 * (num - 20.0)), 34.163);
				}
				else if (num > 32.0 & num <= 47.0)
				{
					Atmosphere.double_0 = 8.6804 * Math.Pow(228.65 / (228.65 + 2.8 * (num - 32.0)), 12.201071428571428);
				}
				else if (num > 47.0 & num <= 51.0)
				{
					Atmosphere.double_0 = 1.1091 * Math.Exp(-34.163 * (num - 47.0) / 270.65);
				}
				else if (num > 51.0 & num <= 71.0)
				{
					Atmosphere.double_0 = 0.6694 * Math.Pow(270.65 / (270.65 + -2.8 * (num - 51.0)), -12.201071428571428);
				}
				else if (num > 71.0 & num <= 100.0)
				{
					Atmosphere.double_0 = 0.0396 * Math.Pow(214.65 / (214.65 + -2.0 * (num - 71.0)), -17.0815);
				}
				else
				{
					Atmosphere.double_0 = 0.0;
				}
				if (num >= 0.0 & num <= 20.0)
				{
					Atmosphere.double_1 = (double)num3 + -6.5 * num;
				}
				else if (num > 20.0 & num <= 32.0)
				{
					Atmosphere.double_1 = (double)num3 - 71.5 + (num - 20.0);
				}
				else if (num > 32.0 & num <= 47.0)
				{
					Atmosphere.double_1 = (double)num3 - 59.5 + 2.8 * (num - 32.0);
				}
				else if (num > 47.0 & num <= 51.0)
				{
					Atmosphere.double_1 = (double)num3 - 17.5;
				}
				else if (num > 51.0 & num <= 71.0)
				{
					Atmosphere.double_1 = (double)num3 - 17.85 - 2.8 * (num - 51.0);
				}
				else if (num > 71.0 & num <= 100.0)
				{
					Atmosphere.double_1 = (double)num3 - 73.65 - 2.0 * (num - 71.0);
				}
				else
				{
					Atmosphere.double_1 = 0.0;
				}
				if (num <= 100.0)
				{
					Atmosphere.double_2 = 7.5 * Math.Exp(-0.5 * num);
					if (Atmosphere.double_2 * Atmosphere.double_1 / 216.7 / Atmosphere.double_0 < 2E-06)
					{
						double num4 = 2E-06 * Atmosphere.double_0;
						Atmosphere.double_2 = num4 * 216.7 / Atmosphere.double_1;
					}
				}
				break;
			}
		}

		// Token: 0x06006924 RID: 26916 RVA: 0x00387EA0 File Offset: 0x003860A0
		public static double smethod_3(double Temperature_, double double_1, double double_2)
		{
			double num = Temperature_ + 273.15;
			double d = 25.22 * (Temperature_ / num) - 5.31 * Math.Log(num / 273.15);
			double num2 = double_2 * 6.105 * Math.Exp(d) / 100.0;
			return 77.6 * double_1 / num + num2 * 373000.0 / (num * num);
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x00387F20 File Offset: 0x00386120
		public static double smethod_4(int SeaState)
		{
			double result = 0.0;
			switch (SeaState)
			{
			case 0:
				result = 0.0;
				break;
			case 1:
				result = 3.131;
				break;
			case 2:
				result = 7.67;
				break;
			case 3:
				result = 13.099;
				break;
			case 4:
				result = 19.175;
				break;
			case 5:
				result = 25.246;
				break;
			case 6:
				result = 31.313;
				break;
			case 7:
				result = 38.351;
				break;
			case 8:
				result = 47.489;
				break;
			case 9:
				result = 54.237;
				break;
			}
			return result;
		}

		// Token: 0x06006926 RID: 26918 RVA: 0x00387FE4 File Offset: 0x003861E4
		public static Weather.WeatherProfile GetWeatherProfile()
		{
			return new Weather.WeatherProfile();
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x00387FF8 File Offset: 0x003861F8
		public static bool CanLookThroughCloud(Unit SrcUnit, Unit DestUnit, ref Scenario scenario_)
		{
			float fUR = Weather.GetWeatherProfile(scenario_, DestUnit.GetLatitude(null), DestUnit.GetLongitude(null), (int)Math.Round((double)DestUnit.GetCurrentAltitude_ASL(false))).GetFUR();
			bool flag;
			bool result;
			if (fUR > 0.9f)
			{
				flag = (!SrcUnit.IsShip && !SrcUnit.IsSubmarine && !SrcUnit.IsFacility && !DestUnit.IsShip && !DestUnit.IsSubmarine && !DestUnit.IsFacility && ((SrcUnit.GetCurrentAltitude_ASL(false) >= 10972.8f && DestUnit.GetCurrentAltitude_ASL(false) >= 10972.8f) || (SrcUnit.GetAltitude_AGL() >= 609.6f && SrcUnit.GetCurrentAltitude_ASL(false) <= 2133.6f && DestUnit.GetAltitude_AGL() >= 609.6f && DestUnit.GetCurrentAltitude_ASL(false) <= 2133.6f)));
			}
			else if (fUR > 0.8f)
			{
				flag = ((SrcUnit.GetCurrentAltitude_ASL(false) >= 10972.8f && DestUnit.GetCurrentAltitude_ASL(false) >= 10972.8f) || (SrcUnit.GetAltitude_AGL() >= 609.6f && SrcUnit.GetCurrentAltitude_ASL(false) <= 2133.6f && DestUnit.GetAltitude_AGL() >= 609.6f && DestUnit.GetCurrentAltitude_ASL(false) <= 2133.6f) || ((SrcUnit.GetAltitude_AGL() < 2000f || DestUnit.GetAltitude_AGL() < 2000f) && Math.Abs(SrcUnit.GetCurrentAltitude_ASL(false) - DestUnit.GetCurrentAltitude_ASL(false)) < 304.8f));
			}
			else if (fUR > 0.7f)
			{
				flag = ((SrcUnit.GetCurrentAltitude_ASL(false) >= 10972.8f && DestUnit.GetCurrentAltitude_ASL(false) >= 10972.8f) || (SrcUnit.GetCurrentAltitude_ASL(false) >= 4876.8f && SrcUnit.GetCurrentAltitude_ASL(false) <= 9144f && DestUnit.GetCurrentAltitude_ASL(false) >= 4876.8f && DestUnit.GetCurrentAltitude_ASL(false) <= 9144f) || (SrcUnit.GetCurrentAltitude_ASL(false) <= 2133.6f && DestUnit.GetCurrentAltitude_ASL(false) <= 2133.6f) || (SrcUnit.GetCurrentAltitude_ASL(false) >= 4876.8f && DestUnit.GetCurrentAltitude_ASL(false) >= 4876.8f && Math.Abs(SrcUnit.GetCurrentAltitude_ASL(false) - DestUnit.GetCurrentAltitude_ASL(false)) < 762f));
			}
			else if (fUR > 0.6f)
			{
				if (SrcUnit.GetCurrentAltitude_ASL(false) >= 9144f && DestUnit.GetCurrentAltitude_ASL(false) >= 9144f)
				{
					flag = true;
				}
				else if (SrcUnit.GetCurrentAltitude_ASL(false) >= 4876.8f && SrcUnit.GetCurrentAltitude_ASL(false) <= 8229.6f && DestUnit.GetCurrentAltitude_ASL(false) >= 4876.8f && DestUnit.GetCurrentAltitude_ASL(false) <= 8229.6f)
				{
					flag = true;
				}
				else if (SrcUnit.GetCurrentAltitude_ASL(false) <= 2133.6f && DestUnit.GetCurrentAltitude_ASL(false) <= 2133.6f)
				{
					flag = true;
				}
				else
				{
					if (SrcUnit.GetCurrentAltitude_ASL(false) >= 4876.8f && DestUnit.GetCurrentAltitude_ASL(false) >= 4876.8f)
					{
						if (Math.Abs(SrcUnit.GetCurrentAltitude_ASL(false) - DestUnit.GetCurrentAltitude_ASL(false)) < 1524f)
						{
							result = true;
							return result;
						}
					}
					else if (Math.Abs(SrcUnit.GetCurrentAltitude_ASL(false) - DestUnit.GetCurrentAltitude_ASL(false)) < 762f)
					{
						result = true;
						return result;
					}
					flag = false;
				}
			}
			else if (fUR > 0.5f)
			{
				flag = ((SrcUnit.GetCurrentAltitude_ASL(false) >= 8534.4f && DestUnit.GetCurrentAltitude_ASL(false) >= 8534.4f) || (SrcUnit.GetCurrentAltitude_ASL(false) <= 7620f && DestUnit.GetCurrentAltitude_ASL(false) <= 7620f) || Math.Abs(SrcUnit.GetCurrentAltitude_ASL(false) - DestUnit.GetCurrentAltitude_ASL(false)) < 762f);
			}
			else if (fUR > 0.4f)
			{
				flag = ((SrcUnit.GetCurrentAltitude_ASL(false) >= 4876.8f && DestUnit.GetCurrentAltitude_ASL(false) >= 4876.8f) || (SrcUnit.GetCurrentAltitude_ASL(false) <= 2133.6f && DestUnit.GetCurrentAltitude_ASL(false) <= 2133.6f) || Math.Abs(SrcUnit.GetCurrentAltitude_ASL(false) - DestUnit.GetCurrentAltitude_ASL(false)) < 762f);
			}
			else if (fUR > 0.3f)
			{
				flag = ((SrcUnit.GetCurrentAltitude_ASL(false) >= 2133.6f && DestUnit.GetCurrentAltitude_ASL(false) >= 2133.6f) || (SrcUnit.GetCurrentAltitude_ASL(false) <= 609.6f && DestUnit.GetCurrentAltitude_ASL(false) <= 609.6f) || Math.Abs(SrcUnit.GetCurrentAltitude_ASL(false) - DestUnit.GetCurrentAltitude_ASL(false)) < 762f);
			}
			else if (fUR > 0.2f)
			{
				flag = ((SrcUnit.GetCurrentAltitude_ASL(false) >= 7010.4f && DestUnit.GetCurrentAltitude_ASL(false) >= 7010.4f) || (SrcUnit.GetCurrentAltitude_ASL(false) <= 6096f && DestUnit.GetCurrentAltitude_ASL(false) <= 6096f) || Math.Abs(SrcUnit.GetCurrentAltitude_ASL(false) - DestUnit.GetCurrentAltitude_ASL(false)) < 1524f);
			}
			else if (fUR > 0.1f)
			{
				flag = ((SrcUnit.GetCurrentAltitude_ASL(false) >= 4876.8f && DestUnit.GetCurrentAltitude_ASL(false) >= 4876.8f) || (SrcUnit.GetCurrentAltitude_ASL(false) <= 3048f && DestUnit.GetCurrentAltitude_ASL(false) <= 3048f) || Math.Abs(SrcUnit.GetCurrentAltitude_ASL(false) - DestUnit.GetCurrentAltitude_ASL(false)) < 1524f);
			}
			else
			{
				flag = (fUR <= 0f || (SrcUnit.GetCurrentAltitude_ASL(false) >= 2133.6f && DestUnit.GetCurrentAltitude_ASL(false) >= 2133.6f) || (SrcUnit.GetCurrentAltitude_ASL(false) <= 1524f && DestUnit.GetCurrentAltitude_ASL(false) <= 1524f) || Math.Abs(SrcUnit.GetCurrentAltitude_ASL(false) - DestUnit.GetCurrentAltitude_ASL(false)) < 1524f);
			}
			result = flag;
			return result;
		}

		// Token: 0x02000C5E RID: 3166
		public enum _TimeOfDay : byte
		{
			// Token: 0x04003B28 RID: 15144
			Day,
			// Token: 0x04003B29 RID: 15145
			DawnOrDusk,
			// Token: 0x04003B2A RID: 15146
			Night
		}

		// Token: 0x02000C5F RID: 3167
		public enum Enum96 : byte
		{
			// Token: 0x04003B2C RID: 15148
			const_0,
			// Token: 0x04003B2D RID: 15149
			const_1 = 8,
			// Token: 0x04003B2E RID: 15150
			const_2,
			// Token: 0x04003B2F RID: 15151
			const_3
		}

		// Token: 0x02000C60 RID: 3168
		public enum Enum97 : byte
		{
			// Token: 0x04003B31 RID: 15153
			const_0,
			// Token: 0x04003B32 RID: 15154
			const_1 = 5,
			// Token: 0x04003B33 RID: 15155
			const_2,
			// Token: 0x04003B34 RID: 15156
			const_3
		}

		// Token: 0x02000C61 RID: 3169
		public enum Enum98 : byte
		{
			// Token: 0x04003B36 RID: 15158
			const_0,
			// Token: 0x04003B37 RID: 15159
			const_1,
			// Token: 0x04003B38 RID: 15160
			const_2,
			// Token: 0x04003B39 RID: 15161
			const_3,
			// Token: 0x04003B3A RID: 15162
			const_4
		}

		// Token: 0x02000C62 RID: 3170
		public struct Struct31
		{
			// Token: 0x04003B3B RID: 15163
			public Weather.Enum98 enum98_0;

			// Token: 0x04003B3C RID: 15164
			public int int_0;

			// Token: 0x04003B3D RID: 15165
			public int int_1;

			// Token: 0x04003B3E RID: 15166
			public int int_2;

			// Token: 0x04003B3F RID: 15167
			public Weather.Enum97 enum97_0;

			// Token: 0x04003B40 RID: 15168
			public int int_3;

			// Token: 0x04003B41 RID: 15169
			public int int_4;

			// Token: 0x04003B42 RID: 15170
			public int int_5;

			// Token: 0x04003B43 RID: 15171
			public Weather.Enum96 enum96_0;

			// Token: 0x04003B44 RID: 15172
			public int int_6;

			// Token: 0x04003B45 RID: 15173
			public int int_7;

			// Token: 0x04003B46 RID: 15174
			public int int_8;
		}

		// 气象剖面
		public sealed class WeatherProfile
		{
			// 构造函数
			public WeatherProfile()
			{
				this.lazy_0 = new Lazy<ConcurrentDictionary<double, double>>();
				this.SetTemp(15.0);
				this.SetPressure(1013.25);
				this.SetRL(86.17);
				this.GRC = 0.0;
				this.SetDN(39.0);
				this.GetSDH = 0.0;
				this.EDH = 0.0;
				this.RainFallRate = 0f;
				this.SetFUR(0f);
				this.SeaState = 0;
			}

			// Token: 0x0600692A RID: 26922 RVA: 0x003886C8 File Offset: 0x003868C8
			public void Save(ref XmlWriter xmlWriter_0)
			{
				xmlWriter_0.WriteStartElement("WeatherProfile");
				xmlWriter_0.WriteElementString("Temp", XmlConvert.ToString(this.GetTemp()));
				xmlWriter_0.WriteElementString("Pressure", XmlConvert.ToString(this.GetPressure()));
				xmlWriter_0.WriteElementString("RL", XmlConvert.ToString(this.GetRL()));
				xmlWriter_0.WriteElementString("GRC", XmlConvert.ToString(this.GRC));
				xmlWriter_0.WriteElementString("DN", XmlConvert.ToString(this.GetDN()));
				xmlWriter_0.WriteElementString("SDH", XmlConvert.ToString(this.GetSDH));
				xmlWriter_0.WriteElementString("EDH", XmlConvert.ToString(this.EDH));
				xmlWriter_0.WriteElementString("RFR", XmlConvert.ToString(this.RainFallRate));
				xmlWriter_0.WriteElementString("FUR", XmlConvert.ToString(this.GetFUR()));
				xmlWriter_0.WriteElementString("SS", XmlConvert.ToString(this.SeaState));
				xmlWriter_0.WriteEndElement();
			}

			// Token: 0x0600692B RID: 26923 RVA: 0x003887D0 File Offset: 0x003869D0
			public static Weather.WeatherProfile smethod_0(ref XmlNode xmlNode_0)
			{
				Weather.WeatherProfile weatherProfile = new Weather.WeatherProfile();
				IEnumerator enumerator = xmlNode_0.ChildNodes[0].ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 2164589563u)
						{
							if (num <= 1078463463u)
							{
								if (num != 520028718u)
								{
									if (num == 1078463463u && Operators.CompareString(name, "Temp", false) == 0)
									{
										weatherProfile.SetTemp(XmlConvert.ToDouble(xmlNode.InnerText));
									}
								}
								else if (Operators.CompareString(name, "SDH", false) == 0)
								{
									weatherProfile.GetSDH = XmlConvert.ToDouble(xmlNode.InnerText);
								}
							}
							else if (num != 1120831591u)
							{
								if (num != 1711446755u)
								{
									if (num == 2164589563u && Operators.CompareString(name, "RL", false) == 0)
									{
										weatherProfile.SetRL(XmlConvert.ToDouble(xmlNode.InnerText));
									}
								}
								else if (Operators.CompareString(name, "SS", false) == 0)
								{
									weatherProfile.SeaState = (int)XmlConvert.ToInt16(xmlNode.InnerText);
								}
							}
							else if (Operators.CompareString(name, "DN", false) == 0)
							{
								weatherProfile.SetDN(XmlConvert.ToDouble(xmlNode.InnerText));
							}
						}
						else if (num <= 2804646028u)
						{
							if (num != 2211899073u)
							{
								if (num == 2804646028u && Operators.CompareString(name, "EDH", false) == 0)
								{
									weatherProfile.EDH = XmlConvert.ToDouble(xmlNode.InnerText);
								}
							}
							else if (Operators.CompareString(name, "RFR", false) == 0)
							{
								weatherProfile.RainFallRate = (float)XmlConvert.ToInt32(xmlNode.InnerText);
							}
						}
						else if (num != 2886844557u)
						{
							if (num != 3324005570u)
							{
								if (num == 4155875938u && Operators.CompareString(name, "FUR", false) == 0)
								{
									weatherProfile.SetFUR((float)XmlConvert.ToDouble(xmlNode.InnerText));
								}
							}
							else if (Operators.CompareString(name, "Pressure", false) == 0)
							{
								weatherProfile.SetPressure(XmlConvert.ToDouble(xmlNode.InnerText));
							}
						}
						else if (Operators.CompareString(name, "GRC", false) == 0)
						{
							weatherProfile.GRC = XmlConvert.ToDouble(xmlNode.InnerText);
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
				return weatherProfile;
			}

			// Token: 0x0600692C RID: 26924 RVA: 0x00388ABC File Offset: 0x00386CBC
			public short GetTemperature(Weather._TimeOfDay TimeOfDay_)
			{
				short result;
				switch (TimeOfDay_)
				{
				case Weather._TimeOfDay.Day:
					result = (short)Math.Round(this.GetTemp() + 10.0);
					break;
				case Weather._TimeOfDay.DawnOrDusk:
					result = (short)Math.Round(this.GetTemp());
					break;
				case Weather._TimeOfDay.Night:
					result = (short)Math.Round(this.GetTemp() - 10.0);
					break;
				default:
					throw new NotImplementedException();
				}
				return result;
			}

			// Token: 0x0600692D RID: 26925 RVA: 0x00388B28 File Offset: 0x00386D28
			public string GetRainLevelStr()
			{
				float rainFallRate = this.RainFallRate;
				string result;
				if (rainFallRate == 0f)
				{
					result = "无雨";
				}
				else if (rainFallRate < 5f)
				{
					result = "细雨";
				}
				else if (rainFallRate < 10f)
				{
					result = "小雨";
				}
				else if (rainFallRate < 20f)
				{
					result = "中雨";
				}
				else if (rainFallRate < 30f)
				{
					result = "大雨";
				}
				else if (rainFallRate < 40f)
				{
					result = "暴雨";
				}
				else
				{
					result = "特大暴雨";
				}
				return result;
			}

			// Token: 0x0600692E RID: 26926 RVA: 0x00388BCC File Offset: 0x00386DCC
			public float GetFUR()
			{
				return this.FUR;
			}

			// Token: 0x0600692F RID: 26927 RVA: 0x00388BE4 File Offset: 0x00386DE4
			public void SetFUR(float value)
			{
				this.FUR = value;
				float num = (float)((double)this.FUR - 0.001);
				if (this.FUR == 0f)
				{
					num = 0f;
				}
				if ((double)num > 0.9)
				{
					this.struct31_0.int_7 = 10973;
					this.struct31_0.int_6 = 2134;
					this.struct31_0.int_8 = 8;
					this.struct31_0.int_4 = 0;
					this.struct31_0.int_3 = 0;
					this.struct31_0.int_5 = 0;
					this.struct31_0.int_1 = 610;
					this.struct31_0.int_0 = 0;
					this.struct31_0.int_2 = 8;
				}
				else if ((double)num > 0.8)
				{
					this.struct31_0.int_7 = 10973;
					this.struct31_0.int_6 = 2134;
					this.struct31_0.int_8 = 8;
					this.struct31_0.int_4 = 0;
					this.struct31_0.int_3 = 0;
					this.struct31_0.int_5 = 0;
					this.struct31_0.int_1 = 610;
					this.struct31_0.int_0 = 0;
					this.struct31_0.int_2 = 2;
				}
				else if ((double)num > 0.7)
				{
					this.struct31_0.int_7 = 10973;
					this.struct31_0.int_6 = 9144;
					this.struct31_0.int_8 = 4;
					this.struct31_0.int_4 = 4877;
					this.struct31_0.int_3 = 2134;
					this.struct31_0.int_5 = 8;
					this.struct31_0.int_1 = 0;
					this.struct31_0.int_0 = 0;
					this.struct31_0.int_2 = 0;
				}
				else if ((double)num > 0.6)
				{
					this.struct31_0.int_7 = 9144;
					this.struct31_0.int_6 = 8230;
					this.struct31_0.int_8 = 2;
					this.struct31_0.int_4 = 4877;
					this.struct31_0.int_3 = 2134;
					this.struct31_0.int_5 = 4;
					this.struct31_0.int_1 = 0;
					this.struct31_0.int_0 = 0;
					this.struct31_0.int_2 = 0;
				}
				else if ((double)num > 0.5)
				{
					this.struct31_0.int_7 = 0;
					this.struct31_0.int_6 = 0;
					this.struct31_0.int_8 = 0;
					this.struct31_0.int_4 = 8534;
					this.struct31_0.int_3 = 7620;
					this.struct31_0.int_5 = 4;
					this.struct31_0.int_1 = 0;
					this.struct31_0.int_0 = 0;
					this.struct31_0.int_2 = 0;
				}
				else if ((double)num > 0.4)
				{
					this.struct31_0.int_7 = 0;
					this.struct31_0.int_6 = 0;
					this.struct31_0.int_8 = 0;
					this.struct31_0.int_4 = 4877;
					this.struct31_0.int_3 = 2134;
					this.struct31_0.int_5 = 4;
					this.struct31_0.int_1 = 0;
					this.struct31_0.int_0 = 0;
					this.struct31_0.int_2 = 0;
				}
				else if ((double)num > 0.3)
				{
					this.struct31_0.int_7 = 0;
					this.struct31_0.int_6 = 0;
					this.struct31_0.int_8 = 0;
					this.struct31_0.int_4 = 0;
					this.struct31_0.int_3 = 0;
					this.struct31_0.int_5 = 0;
					this.struct31_0.int_1 = 2134;
					this.struct31_0.int_0 = 610;
					this.struct31_0.int_2 = 4;
				}
				else if ((double)num > 0.2)
				{
					this.struct31_0.int_7 = 0;
					this.struct31_0.int_6 = 0;
					this.struct31_0.int_8 = 0;
					this.struct31_0.int_4 = 7010;
					this.struct31_0.int_3 = 6096;
					this.struct31_0.int_5 = 2;
					this.struct31_0.int_1 = 0;
					this.struct31_0.int_0 = 0;
					this.struct31_0.int_2 = 0;
				}
				else if ((double)num > 0.1)
				{
					this.struct31_0.int_7 = 0;
					this.struct31_0.int_6 = 0;
					this.struct31_0.int_8 = 0;
					this.struct31_0.int_4 = 4877;
					this.struct31_0.int_3 = 3048;
					this.struct31_0.int_5 = 2;
					this.struct31_0.int_1 = 0;
					this.struct31_0.int_0 = 0;
					this.struct31_0.int_2 = 0;
				}
				else if ((double)num > 0.0)
				{
					this.struct31_0.int_7 = 0;
					this.struct31_0.int_6 = 0;
					this.struct31_0.int_8 = 0;
					this.struct31_0.int_4 = 0;
					this.struct31_0.int_3 = 0;
					this.struct31_0.int_5 = 0;
					this.struct31_0.int_1 = 2134;
					this.struct31_0.int_0 = 1524;
					this.struct31_0.int_2 = 2;
				}
				else
				{
					this.struct31_0.int_7 = 0;
					this.struct31_0.int_6 = 0;
					this.struct31_0.int_8 = 0;
					this.struct31_0.int_4 = 0;
					this.struct31_0.int_3 = 0;
					this.struct31_0.int_5 = 0;
					this.struct31_0.int_1 = 0;
					this.struct31_0.int_0 = 0;
					this.struct31_0.int_2 = 0;
				}
			}

			// Token: 0x06006930 RID: 26928 RVA: 0x00389218 File Offset: 0x00387418
			public string method_5()
			{
				float fUR = this.GetFUR();
				string result;
				if (fUR > 0.9f)
				{
					if (SimConfiguration.gameOptions.UseImperialUnit())
					{
						result = "Thick fog 0 - 2k ft, solid cloud cover 7 - 36k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Thick fog 0 - ",
							Conversions.ToString(Math.Round(0.60959994792938232, 2)),
							"km, solid cloud cover ",
							Conversions.ToString(Math.Round(2.1335999965667725, 2)),
							" - ",
							Conversions.ToString(Math.Round(10.972800254821777, 2)),
							" km"
						});
					}
				}
				else if (fUR > 0.8f)
				{
					if (SimConfiguration.gameOptions.UseImperialUnit())
					{
						result = "Thin fog 0 - 2k ft, solid cloud cover 7 - 36k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Thin fog 0 - ",
							Conversions.ToString(Math.Round(0.60959994792938232, 2)),
							"km, solid cloud cover ",
							Conversions.ToString(Math.Round(2.1335999965667725, 2)),
							" - ",
							Conversions.ToString(Math.Round(10.972800254821777, 2)),
							" km"
						});
					}
				}
				else if (fUR > 0.7f)
				{
					if (SimConfiguration.gameOptions.UseImperialUnit())
					{
						result = "Solid middle clouds 7 - 16k ft, moderate high clouds 30 - 36k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Solid middle clouds ",
							Conversions.ToString(Math.Round(2.1335999965667725, 2)),
							" - ",
							Conversions.ToString(Math.Round(4.8767995834350586, 2)),
							" km, moderate high clouds ",
							Conversions.ToString(Math.Round(9.1440000534057617, 2)),
							" - ",
							Conversions.ToString(Math.Round(10.972800254821777, 2)),
							" km"
						});
					}
				}
				else if (fUR > 0.6f)
				{
					if (SimConfiguration.gameOptions.UseImperialUnit())
					{
						result = "Moderate middle clouds 7 - 16k ft, light high clouds 27 - 30k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Moderate middle clouds ",
							Conversions.ToString(Math.Round(2.1335999965667725, 2)),
							" - ",
							Conversions.ToString(Math.Round(4.8767995834350586, 2)),
							" km, light high clouds ",
							Conversions.ToString(Math.Round(8.2295999526977539, 2)),
							" - ",
							Conversions.ToString(Math.Round(9.1440000534057617, 2)),
							" km"
						});
					}
				}
				else if (fUR > 0.5f)
				{
					if (SimConfiguration.gameOptions.UseImperialUnit())
					{
						result = "Moderate high clouds 25 - 28k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Moderate high clouds ",
							Conversions.ToString(Math.Round(7.619999885559082, 2)),
							" - ",
							Conversions.ToString(Math.Round(8.53439998626709, 2)),
							" km"
						});
					}
				}
				else if (fUR > 0.4f)
				{
					if (SimConfiguration.gameOptions.UseImperialUnit())
					{
						result = "Moderate middle clouds 7 - 16k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Moderate middle clouds ",
							Conversions.ToString(Math.Round(2.1335999965667725, 2)),
							" - ",
							Conversions.ToString(Math.Round(4.8767995834350586, 2)),
							" km"
						});
					}
				}
				else if (fUR > 0.3f)
				{
					if (SimConfiguration.gameOptions.UseImperialUnit())
					{
						result = "Moderate low clouds 2 - 7k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Moderate low clouds ",
							Conversions.ToString(Math.Round(0.60959994792938232, 2)),
							" - ",
							Conversions.ToString(Math.Round(2.1335999965667725, 2)),
							" km"
						});
					}
				}
				else if (fUR > 0.2f)
				{
					if (SimConfiguration.gameOptions.UseImperialUnit())
					{
						result = "Light high clouds 20 - 23k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Light high clouds ",
							Conversions.ToString(Math.Round(6.0960001945495605, 2)),
							" - ",
							Conversions.ToString(Math.Round(7.01039981842041, 2)),
							" km"
						});
					}
				}
				else if (fUR > 0.1f)
				{
					if (SimConfiguration.gameOptions.UseImperialUnit())
					{
						result = "Light middle clouds 10 - 16k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Light middle clouds ",
							Conversions.ToString(Math.Round(3.0480000972747803, 2)),
							" - ",
							Conversions.ToString(Math.Round(4.8767995834350586, 2)),
							" km"
						});
					}
				}
				else if (fUR > 0f)
				{
					if (SimConfiguration.gameOptions.UseImperialUnit())
					{
						result = "Light low clouds 5 - 7k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Light low clouds ",
							Conversions.ToString(Math.Round(1.5240000486373901, 2)),
							" - ",
							Conversions.ToString(Math.Round(2.1335999965667725, 2)),
							" km"
						});
					}
				}
				else
				{
					result = "晴天";
				}
				return result;
			}

			// Token: 0x06006931 RID: 26929 RVA: 0x00389800 File Offset: 0x00387A00
			public double GetTemp()
			{
				return this.Temperature;
			}

			// Token: 0x06006932 RID: 26930 RVA: 0x00389818 File Offset: 0x00387A18
			public void SetTemp(double value)
			{
				if (this.Temperature != value)
				{
					this.Temperature = value;
					this.double_5 = Weather.smethod_3(this.Temperature, this.Pressure, this.RainLevel);
					this.lazy_0.Value.Clear();
				}
			}

			// Token: 0x06006933 RID: 26931 RVA: 0x00389864 File Offset: 0x00387A64
			public double GetPressure()
			{
				return this.Pressure;
			}

			// Token: 0x06006934 RID: 26932 RVA: 0x0038987C File Offset: 0x00387A7C
			public void SetPressure(double value)
			{
				if (this.Pressure != value)
				{
					this.Pressure = value;
					this.double_5 = Weather.smethod_3(this.Temperature, this.Pressure, this.RainLevel);
					this.lazy_0.Value.Clear();
				}
			}

			// Token: 0x06006935 RID: 26933 RVA: 0x003898C8 File Offset: 0x00387AC8
			public double GetRL()
			{
				return this.RainLevel;
			}

			// Token: 0x06006936 RID: 26934 RVA: 0x003898E0 File Offset: 0x00387AE0
			public void SetRL(double double_10)
			{
				if (this.RainLevel != double_10)
				{
					this.RainLevel = double_10;
					this.double_5 = Weather.smethod_3(this.Temperature, this.Pressure, this.RainLevel);
					this.lazy_0.Value.Clear();
				}
			}

			// Token: 0x06006937 RID: 26935 RVA: 0x0038992C File Offset: 0x00387B2C
			public double GetDN()
			{
				return this.DeltN;
			}

			// Token: 0x06006938 RID: 26936 RVA: 0x0002D59E File Offset: 0x0002B79E
			public void SetDN(double value)
			{
				if (this.DeltN != value)
				{
					this.DeltN = value;
					this.double_8 = Weather.smethod_1(value);
					this.double_9 = 157.0 / (157.0 - this.GetDN());
				}
			}

			// Token: 0x04003B47 RID: 15175
			public Lazy<ConcurrentDictionary<double, double>> lazy_0;

			// Token: 0x04003B48 RID: 15176
			protected double Temperature;

			// Token: 0x04003B49 RID: 15177
			protected double Pressure;

			// Token: 0x04003B4A RID: 15178
			protected double RainLevel;

			// Token: 0x04003B4B RID: 15179
			public int SeaState;

			// Token: 0x04003B4C RID: 15180
			public float RainFallRate;

			// Token: 0x04003B4D RID: 15181
			private float FUR;

			// Token: 0x04003B4E RID: 15182
			public Weather.Struct31 struct31_0;

			// Token: 0x04003B4F RID: 15183
			public double GRC = 0.0;

			// Token: 0x04003B50 RID: 15184
			protected double DeltN = 0.0;

			// Token: 0x04003B51 RID: 15185
			public double double_5 = 0.0;

			// Token: 0x04003B52 RID: 15186
			public double GetSDH = 0.0;

			// Token: 0x04003B53 RID: 15187
			public double EDH = 0.0;

			// Token: 0x04003B54 RID: 15188
			public double double_8;

			// Token: 0x04003B55 RID: 15189
			public double double_9;
		}

		// Token: 0x02000C64 RID: 3172
		public enum _AtmosphereType
		{
			// Token: 0x04003B57 RID: 15191
			const_0,
			// Token: 0x04003B58 RID: 15192
			const_1,
			// Token: 0x04003B59 RID: 15193
			const_2,
			// Token: 0x04003B5A RID: 15194
			const_3,
			// Token: 0x04003B5B RID: 15195
			const_4,
			// Token: 0x04003B5C RID: 15196
			const_5
		}

		// Token: 0x02000C65 RID: 3173
		public struct _Atmosphere
		{
			// Token: 0x04003B5D RID: 15197
			public double double_0;

			// Token: 0x04003B5E RID: 15198
			public double double_1;

			// Token: 0x04003B5F RID: 15199
			public double double_2;
		}
	}
}
