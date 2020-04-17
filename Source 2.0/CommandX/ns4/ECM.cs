using System;
using System.Collections;
using System.Diagnostics;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace ns4
{
	// 电子战
	public sealed class ECM
	{
		// 目标是否已被探测
		public static bool IsTargetDetected(ECM.Radar Radar, ECM.Target Target, int NumJammers, ECM.Jammer[] Jammers, double DistanceToTarget, double[] DistancesToJammers, double[] AzimouthsToJammers, Weather.WeatherProfile Env, float FractionOverWater, double ChaffDensity, double ChaffCloudThickness, ref ECM.Radar RadarReceiver, double ReceiverDistanceToTarget, ECM._TerrainType TerrainType)
		{
			bool flag = false;
			bool result;
			try
			{
				bool flag2 = false;
				if (RadarReceiver != null)
				{
					flag2 = true;
				}
				double[] array = new double[NumJammers - 1 + 1];
				if (DistanceToTarget <= 0.0)
				{
					flag = false;
				}
				else if (!flag2 && DistanceToTarget <= Radar.method_4())
				{
					flag = false;
				}
				else
				{
					if (Radar.GetPulsewidth() == 0.0 && Radar.GetScanRate() == 0.0)
					{
						throw new Exception("Zero pulsewidth and zero scanrate, cannot compute detection - illuminators not implemented");
					}
					if (Radar.GetAntennaGain() == 0.0)
					{
						throw new Exception("Zero antenna gain, cannot compute detection");
					}
					if (Radar.GetHorizontalBeamwidth() == 0.0 || Radar.GetVerticalBeamwidth() == 0.0)
					{
						throw new Exception("Zero beamwidth, cannot compute detection");
					}
					if (Radar.Frequency == 0.0)
					{
						throw new Exception("Zero frequency, cannot compute detection");
					}
					if (flag2)
					{
						if (ReceiverDistanceToTarget <= 0.0)
						{
							throw new Exception("Receiver is ON target. Why use a radar at all - a good fuze is all you need!");
						}
						if (RadarReceiver.GetAntennaGain() == 0.0)
						{
							throw new Exception("Zero RECEIVER antenna gain, cannot compute detection");
						}
						if (RadarReceiver.GetHorizontalBeamwidth() == 0.0 || RadarReceiver.GetVerticalBeamwidth() == 0.0)
						{
							throw new Exception("Zero RECEIVER beamwidth, cannot compute detection");
						}
					}
					double num = Math.Pow(10.0, Radar.GetAntennaGain() / 10.0);
					double num2 = 299792458.0 / Radar.Frequency;
					double signalPulseWidth = Radar.GetSignalPulseWidth();
					double num3 = 1.0 / signalPulseWidth;
					int num4 = NumJammers - 1;
					double distanceToTarget_km;
					for (int i = 0; i <= num4; i++)
					{
						double num5 = Math.Pow(10.0, Jammers[i].GetAntennaGain() / 10.0);
						double num6;
						if (flag2)
						{
							double azimuthsToJammer_ = AzimouthsToJammers[i];
							double antennaGain = RadarReceiver.GetAntennaGain();
							double horizontalBeamwidth = RadarReceiver.GetHorizontalBeamwidth();
							ECM.Radar radar;
							ECM.SteerableNulls steerableNulls = (radar = RadarReceiver).GetSteerableNulls();
							double antennaGainConsideringSteerableNulls = ECM.GetAntennaGainConsideringSteerableNulls(azimuthsToJammer_, antennaGain, horizontalBeamwidth, ref steerableNulls);
							radar.SetSteerableNulls(steerableNulls);
							num6 = antennaGainConsideringSteerableNulls;
						}
						else
						{
							double azimuthsToJammer_2 = AzimouthsToJammers[i];
							double antennaGain2 = Radar.GetAntennaGain();
							double horizontalBeamwidth2 = Radar.GetHorizontalBeamwidth();
							ECM.Radar radar;
							ECM.SteerableNulls steerableNulls = (radar = Radar).GetSteerableNulls();
							double antennaGainConsideringSteerableNulls2 = ECM.GetAntennaGainConsideringSteerableNulls(azimuthsToJammer_2, antennaGain2, horizontalBeamwidth2, ref steerableNulls);
							radar.SetSteerableNulls(steerableNulls);
							num6 = antennaGainConsideringSteerableNulls2;
						}
						double num7 = Math.Pow(10.0, num6 / 10.0);
						double num8;
						if (flag2)
						{
							distanceToTarget_km = Math.Max(DistancesToJammers[i], Class258.smethod_10(DistancesToJammers[i], (double)RadarReceiver.AntennaHeight, Jammers[i].GetAntennaAltitude())) * 1852.0 / 1000.0;
							num8 = Math.Pow(10.0, ECM.GetPropogationLoss((double)RadarReceiver.AntennaHeight, Jammers[i].GetAntennaAltitude(), Radar.Frequency, RadarReceiver.GetVerticalBeamwidth(), RadarReceiver.double_16, distanceToTarget_km, ref Env) / 10.0);
						}
						else
						{
							distanceToTarget_km = Math.Max(DistancesToJammers[i], Class258.smethod_10(DistancesToJammers[i], (double)Radar.AntennaHeight, Jammers[i].GetAntennaAltitude())) * 1852.0 / 1000.0;
							num8 = Math.Pow(10.0, ECM.GetPropogationLoss((double)Radar.AntennaHeight, Jammers[i].GetAntennaAltitude(), Radar.Frequency, Radar.GetVerticalBeamwidth(), Radar.double_16, distanceToTarget_km, ref Env) / 10.0);
						}
						double num9 = 0.0;
						switch (Radar.enum109_0)
						{
						case ECM.Enum109.const_0:
							num9 = Jammers[i].GetBandwidth() / 1E-06;
							break;
						case ECM.Enum109.const_1:
						case ECM.Enum109.const_2:
							num9 = Radar.GetHitsPerScan() * (Jammers[i].GetBandwidth() / 1E-06);
							break;
						case ECM.Enum109.const_3:
							num9 = Jammers[i].GetBandwidth() / (Radar.GetScanRate() / 6.0);
							break;
						case ECM.Enum109.const_4:
							num9 = Math.Sqrt(-1.0);
							break;
						}
						double num10 = Jammers[i].GetPeakPower() * num5 * num7 * (num3 / num9) / num8;
						array[i] = num10 / (1.380650424E-23 * num3);
					}
					double num11 = 0.0;
					int num12 = NumJammers - 1;
					for (int i = 0; i <= num12; i++)
					{
						if (array[i] > num11)
						{
							num11 = array[i];
						}
					}
					double num13;
					if (flag2)
					{
						num13 = RadarReceiver.SNRThreshold + RadarReceiver.TAndF + num11;
					}
					else
					{
						num13 = Radar.SNRThreshold + Radar.TAndF + num11;
					}
					double num14 = 1.380650424E-23 * num13 * num3;
					double num15 = 1.0 * num14;
					double num16;
					if (flag2)
					{
						num16 = Math.Pow(10.0, RadarReceiver.GetProcessingGainLoss() / 10.0);
					}
					else
					{
						num16 = Math.Pow(10.0, Radar.GetProcessingGainLoss() / 10.0);
					}
					double num17 = Math.Max((double)Target.fAntennaAltitude_ASL, Target.AntennaAltitude_ASL);
					distanceToTarget_km = Math.Max(DistanceToTarget, Class258.smethod_10(DistanceToTarget, (double)Radar.AntennaHeight, num17)) * 1852.0 / 1000.0;
					double num19;
					if (flag2)
					{
						double distanceToTarget_km2 = Math.Max(ReceiverDistanceToTarget, Class258.smethod_10(ReceiverDistanceToTarget, (double)RadarReceiver.AntennaHeight, num17)) * 1852.0 / 1000.0;
						double propogationLoss = ECM.GetPropogationLoss((double)Radar.AntennaHeight, num17, Radar.Frequency, Radar.GetVerticalBeamwidth(), Radar.double_16, distanceToTarget_km, ref Env);
						double propogationLoss2 = ECM.GetPropogationLoss((double)RadarReceiver.AntennaHeight, num17, Radar.Frequency, RadarReceiver.GetVerticalBeamwidth(), RadarReceiver.double_16, distanceToTarget_km2, ref Env);
						double num18 = Math.Pow(10.0, (propogationLoss + propogationLoss2) / 10.0);
						num19 = Radar.PeakPower * (num * num) * num16 * 4.0 * 3.14159265358979 / (num18 * (num2 * num2));
					}
					else
					{
						ECM.GetPropogationLoss((double)Radar.AntennaHeight, num17, Radar.Frequency, Radar.GetVerticalBeamwidth(), Radar.double_16, distanceToTarget_km, ref Env);
						double num8 = Math.Pow(10.0, ECM.GetFreeSpacePropogationLoss(DistanceToTarget * 1852.0 / 1000.0, Radar.GetFrequency()) / 10.0);
						num19 = Radar.PeakPower * (num * num) * num16 * 4.0 * 3.14159265358979 / (num8 * num8 * (num2 * num2));
					}
					double num20 = num19 * Target.GetRCS_m2();
					if (num15 > num20)
					{
						flag = false;
						result = false;
						return result;
					}
					if (Radar.enum109_0 == ECM.Enum109.const_0 && Target.AntennaAltitude_ASL > 0.0 && DistanceToTarget <= ECM.smethod_5((double)Radar.AntennaHeight, num17, Env.GetDN()) * 1000.0 / 1852.0)
					{
						double num21 = Radar.double_16;
						if (num21 <= 0.0)
						{
							num21 = Math.Abs(num21);
						}
						double num22;
						if ((double)FractionOverWater > 0.8)
						{
							num22 = ECM.smethod_1(DistanceToTarget, ref Radar, num17, Weather.smethod_4(Env.SeaState), 45.0, ref Env, num21);
						}
						else
						{
							num22 = ECM.smethod_2(DistanceToTarget, ref Radar, num17, TerrainType, ref Env, num21);
						}
						double num23 = num19 * num22;
						if (Radar.method_6() == ECM.Enum112.E_1980Plus)
						{
							num23 /= 2.0;
						}
						else if (Radar.method_6() == ECM.Enum112.E_2000Plus)
						{
							num23 /= 4.0;
						}
						if (num23 > num20)
						{
							flag = false;
							result = false;
							return result;
						}
					}
					if (ChaffDensity > 0.0 && ChaffCloudThickness > 0.0)
					{
						double num24 = 0.73 * (num2 * num2) * ChaffDensity;
						num20 *= Math.Pow(10.0, -2.0 * num24 * ChaffCloudThickness * 1852.0 / 10.0);
					}
					flag = (result = (num15 <= num20));
					return result;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101124", "");
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

		// Token: 0x06006ACD RID: 27341 RVA: 0x003A24C4 File Offset: 0x003A06C4
		public static double smethod_1(double DistanceToTarget_, ref ECM.Radar Radar_, double double_1, double SeaStateRelativeVar, double double_3, ref Weather.WeatherProfile Env_, double double_4)
		{
			double num = ECM.smethod_12(Class258.smethod_10(DistanceToTarget_, (double)Radar_.AntennaHeight, double_1), Radar_.GetVerticalBeamwidth(), Radar_.GetHorizontalBeamwidth(), Radar_.GetPulsewidth(), double_4);
			double num2 = ECM.smethod_8(ref Radar_, DistanceToTarget_ * 1852.0 / 1000.0, double_4, SeaStateRelativeVar, double_3);
			return Math.Pow(10.0, (num2 + num) / 10.0);
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x003A253C File Offset: 0x003A073C
		public static double smethod_2(double double_0, ref ECM.Radar Radar_, double double_1, ECM._TerrainType TerrainType_, ref Weather.WeatherProfile Env_, double double_2)
		{
			double num = Class258.smethod_10(double_0, (double)Radar_.AntennaHeight, 0.0) * 1852.0 * Radar_.GetSignalPulseWidth() * 299792458.0 * 0.5 * Math.Tan(double_2 * 0.0174532925199433);
			return ECM.smethod_9(ref Radar_, TerrainType_, double_2) * num;
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x003A25A8 File Offset: 0x003A07A8
		public static bool IsComDeviceNotSpoofed(CommDevice commDevice, Sensor sensor, float distance)
		{
			Random random = GameGeneral.GetRandom();
			bool result;
			if (sensor.HasJammingCondition(commDevice))
			{
				float num = (float)Math.Pow((double)sensor.ECMPeakPower, 0.75);
				if (distance <= num)
				{
					double num2 = Math.Min(1.0, 1.5 * (double)(1f - distance / num));
					if (commDevice.IsSATCOM())
					{
						num2 *= 0.333;
					}
					result = (num2 <= random.NextDouble());
				}
				else
				{
					result = true;
				}
			}
			else
			{
				result = true;
			}
			return result;
		}

        // Token: 0x06006AD0 RID: 27344 RVA: 0x003A2638 File Offset: 0x003A0838
        //public static bool smethod_3(ECM.IEmitter Emitter, ECM.Receiver Receiver, double DistanceToEmitter, double AzimouthOffEmitterBoresight, Weather.WeatherProfile Env, ref ECM.IPropLossMatrix PropLossMatrix)

        public static bool IsEmitterDectect(ECM.IEmitter Emitter, ECM.Receiver Receiver, double DistanceToEmitter, double AzimouthOffEmitterBoresight, Weather.WeatherProfile Env, ref ECM.IPropLossMatrix PropLossMatrix)
		{
			double antennaGain = Emitter.GetAntennaGain();
			double horizontalBeamwidth = Emitter.GetHorizontalBeamwidth();
			ECM.SteerableNulls steerableNulls = Emitter.GetSteerableNulls();
			double antennaGainConsideringSteerableNulls = ECM.GetAntennaGainConsideringSteerableNulls(AzimouthOffEmitterBoresight, antennaGain, horizontalBeamwidth, ref steerableNulls);
			Emitter.SetSteerableNulls(steerableNulls);
			double num = antennaGainConsideringSteerableNulls;
			double num2 = 10.0 * Math.Log10(Emitter.GetPeakPower()) + 30.0 + num - Receiver.Sensitivity - Receiver.SystemLoss;
			double distanceToTarget_km = Math.Max(DistanceToEmitter, Class258.smethod_10(DistanceToEmitter, Emitter.GetAntennaAltitude(), (double)Receiver.AntennaHeight)) * 1852.0 / 1000.0;
			return ECM.GetPropogationLoss(Emitter.GetAntennaAltitude(), (double)Receiver.AntennaHeight, Emitter.GetFrequency(), Emitter.GetVerticalBeamwidth(), Emitter.imethod_12(), distanceToTarget_km, ref Env) <= num2;
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x003A2704 File Offset: 0x003A0904
		public static double GetAntennaGainConsideringSteerableNulls(double AzimuthsToJammer_, double AntennaMaxGain_, double BeamWidth, ref ECM.SteerableNulls SteerableNulls)
		{
			double num = Math.Abs(AzimuthsToJammer_);
			if (num > 180.0)
			{
				throw new Exception("Angle out of limits");
			}
			double result;
			if (num < 0.001)
			{
				result = AntennaMaxGain_;
			}
			else
			{
				result = Math.Min(AntennaMaxGain_, AntennaMaxGain_ + 20.0 * Math.Log10(Math.Abs(Math.Sin(2.7831 * num / BeamWidth) / (2.7831 * num / BeamWidth))));
			}
			if (SteerableNulls != null)
			{
				int num2 = SteerableNulls.method_0().Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (Math.Abs(AzimuthsToJammer_ - SteerableNulls.method_0()[i]) <= SteerableNulls.method_1() / 2.0)
					{
						result = SteerableNulls.method_2();
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x003A27E8 File Offset: 0x003A09E8
		public static double smethod_5(double HT, double HR, double DeltaN = 39.0)
		{
			double num = Weather.smethod_1(DeltaN) * 1000.0;
			double num2 = Math.Sqrt(2.0 * num * HR + HR * HR);
			double num3 = Math.Sqrt(2.0 * num * HT + HT * HT);
			return (Math.Atan(num2 / 6371000.0) + Math.Atan(num3 / 6371000.0)) * 6371.0;
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x003A2864 File Offset: 0x003A0A64
		public static double smethod_6(double distance, double Altitude_ASL1, double Altitude_ASL2, ref Weather.WeatherProfile Env_)
		{
			double result;
			if (Altitude_ASL1 == 0.0 && Altitude_ASL2 == 0.0)
			{
				result = 0.0;
			}
			else
			{
				double num = ECM.smethod_5(Altitude_ASL2, Altitude_ASL1, Env_.GetDN()) * 1000.0 / 1852.0;
				double num2 = 6371000.0 + Altitude_ASL1;
				double num3 = num2 * num2;
				double d;
				double num4;
				if (distance >= num)
				{
					d = num * 1852.0 / 6371000.0;
					num4 = 6371000.0;
				}
				else
				{
					d = distance * 1852.0 / 6371000.0;
					num4 = 6371000.0 + Altitude_ASL2;
				}
				double num5 = num4 * num4;
				double num6 = Math.Sqrt(num5 + num3 - 2.0 * num4 * num2 * Math.Cos(d));
				result = Math.Acos((num6 * num6 + num5 - num3) / (2.0 * num6 * num4)) * 57.2957795130823 - 90.0;
			}
			return result;
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x003A2998 File Offset: 0x003A0B98
		public static int smethod_7(double double_0)
		{
			int num = (int)Math.Round(double_0);
			if (double_0 - (double)num < 0.0)
			{
				num--;
			}
			return num;
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x003A29C8 File Offset: 0x003A0BC8
		public static double smethod_8(ref ECM.Radar radar_, double DistanceToTarget_km, double double_1, double SeaStateRelatedVar, double double_3)
		{
			double num;
			if (double_1 == 0.0)
			{
				num = 0.0;
			}
			else
			{
				double num2 = double_1 * 0.0174532925199433;
				double num3 = 299792458.0 / radar_.Frequency;
				double num4 = Math.Pow(SeaStateRelatedVar, 0.66666666666666663) / 0.836;
				double num5 = num4 * num4 * num4 / 300.0;
				double num6;
				if (num5 == 0.0)
				{
					num6 = 1.5707963267949;
				}
				else
				{
					num6 = Math.Min(1.5707963267949, Math.Asin(num3 / (12.56637061435916 * num5)));
				}
				double num7 = 6.0 * num4 + 10.0 * Math.Log10(num3) - 64.0;
				double num8 = Math.Pow(10.0, num7 / 10.0);
				double num10;
				if (num2 <= num6)
				{
					double num9 = num2 / num6;
					num9 *= num9;
					num9 *= num9;
					num10 = Math.Log10(num8 * num2 * num9) * 10.0;
				}
				else
				{
					num10 = Math.Log10(num8 * Math.Sin(num2)) * 10.0;
				}
				num = num10;
				if (double.IsNaN(num))
				{
					num = 0.0;
				}
			}
			return num;
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x003A2B50 File Offset: 0x003A0D50
		public static double smethod_9(ref ECM.Radar Radar_, ECM._TerrainType TerrainType_, double double_0)
		{
			double num = double_0 * 0.0174532925199433;
			double num2 = 299792458.0 / Radar_.Frequency;
			double num3;
			double num4;
			switch (TerrainType_)
			{
			case ECM._TerrainType.const_0:
				num3 = -5.0;
				num4 = 10.0;
				break;
			case ECM._TerrainType.const_1:
				num3 = -5.0;
				num4 = 100.0;
				break;
			case ECM._TerrainType.const_2:
				num3 = -10.0;
				num4 = 3.0;
				break;
			case ECM._TerrainType.const_3:
				num3 = -12.0;
				num4 = 5.0;
				break;
			case ECM._TerrainType.const_4:
				num3 = -15.0;
				num4 = 10.0;
				break;
			case ECM._TerrainType.const_5:
				num3 = -20.0;
				num4 = 3.0;
				break;
			case ECM._TerrainType.const_6:
			case ECM._TerrainType.const_7:
			case ECM._TerrainType.const_8:
				num3 = -20.0;
				num4 = 1.0;
				break;
			default:
				throw new Exception("Unsupported surface type");
			}
			double num5 = Math.Pow(10.0, num3 / 10.0);
			double num6;
			if (num4 == 0.0)
			{
				num6 = 1.5707963267949;
			}
			else
			{
				num6 = Math.Min(1.5707963267949, Math.Asin(num2 / (12.56637061435916 * num4)));
			}
			double num8;
			if (num <= num6)
			{
				double num7 = num / num6;
				num7 *= num7;
				num7 *= num7;
				num8 = Math.Log10(num5 * num * num7) * 10.0;
			}
			else
			{
				num8 = Math.Log10(num5 * Math.Sin(num)) * 10.0;
			}
			return Math.Pow(10.0, num8 / 10.0);
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x003A2D44 File Offset: 0x003A0F44
		public static double GetFreeSpacePropogationLoss(double DistanceToTarget_km, double Frequency_)
		{
			return 10.0 * Math.Log10(1.7570265424158548E-09) + 20.0 * Math.Log10(DistanceToTarget_km) + 20.0 * Math.Log10(Frequency_);
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x003A2D90 File Offset: 0x003A0F90
		public static double GetPropogationLoss(double RadarReceiverAntennaHeight, double JammerAntennaAltitude, double RadarFrequency, double ReceiverVerticalBeamwidth, double double_4, double DistanceToTarget_km, ref Weather.WeatherProfile Env_)
		{
			return ECM.GetFreeSpacePropogationLoss(DistanceToTarget_km, RadarFrequency);
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x003A2DA8 File Offset: 0x003A0FA8
		public static double smethod_12(double double_0, double double_1, double double_2, double double_3, double double_4)
		{
			double num = double_0 * 1852.0;
			double val = 3.14159265358979 * num * num * Math.Tan(double_2 * 0.0174532925199433 / 2.0) * Math.Tan(double_1 * 0.0174532925199433 / 2.0) / Math.Sin(double_4 * 0.0174532925199433);
			double val2 = num * double_2 * 0.0174532925199433 * 299792458.0 * double_3 * 1E-06 / (2.0 * Math.Cos(double_4 * 0.0174532925199433));
			return Math.Log10(Math.Min(val, val2)) * 10.0;
		}

		// Token: 0x04003C60 RID: 15456
		public static int int_0 = Enum.GetValues(typeof(ECM.Enum110)).Length - 1;

		// Token: 0x02000C97 RID: 3223
		public enum _TerrainType
		{
			// Token: 0x04003C62 RID: 15458
			const_0,
			// Token: 0x04003C63 RID: 15459
			const_1,
			// Token: 0x04003C64 RID: 15460
			const_2,
			// Token: 0x04003C65 RID: 15461
			const_3,
			// Token: 0x04003C66 RID: 15462
			const_4,
			// Token: 0x04003C67 RID: 15463
			const_5,
			// Token: 0x04003C68 RID: 15464
			const_6,
			// Token: 0x04003C69 RID: 15465
			const_7,
			// Token: 0x04003C6A RID: 15466
			const_8
		}

		// Token: 0x02000C98 RID: 3224
		public enum Enum107
		{
			// Token: 0x04003C6C RID: 15468
			const_0,
			// Token: 0x04003C6D RID: 15469
			const_1,
			// Token: 0x04003C6E RID: 15470
			const_2,
			// Token: 0x04003C6F RID: 15471
			const_3,
			// Token: 0x04003C70 RID: 15472
			const_4,
			// Token: 0x04003C71 RID: 15473
			const_5,
			// Token: 0x04003C72 RID: 15474
			const_6,
			// Token: 0x04003C73 RID: 15475
			const_7,
			// Token: 0x04003C74 RID: 15476
			const_8
		}

		// Token: 0x02000C99 RID: 3225
		public enum Enum108
		{
			// Token: 0x04003C76 RID: 15478
			const_0,
			// Token: 0x04003C77 RID: 15479
			const_1,
			// Token: 0x04003C78 RID: 15480
			const_2
		}

		// Token: 0x02000C9A RID: 3226
		public enum Enum109
		{
			// Token: 0x04003C7A RID: 15482
			const_0,
			// Token: 0x04003C7B RID: 15483
			const_1,
			// Token: 0x04003C7C RID: 15484
			const_2,
			// Token: 0x04003C7D RID: 15485
			const_3,
			// Token: 0x04003C7E RID: 15486
			const_4
		}

		// Token: 0x02000C9B RID: 3227
		public enum Enum110
		{
			// Token: 0x04003C80 RID: 15488
			const_0,
			// Token: 0x04003C81 RID: 15489
			const_1,
			// Token: 0x04003C82 RID: 15490
			const_2,
			// Token: 0x04003C83 RID: 15491
			const_3 = 4,
			// Token: 0x04003C84 RID: 15492
			const_4 = 8,
			// Token: 0x04003C85 RID: 15493
			const_5 = 16,
			// Token: 0x04003C86 RID: 15494
			const_6 = 32,
			// Token: 0x04003C87 RID: 15495
			const_7 = 64,
			// Token: 0x04003C88 RID: 15496
			const_8 = 128,
			// Token: 0x04003C89 RID: 15497
			const_9 = 256,
			// Token: 0x04003C8A RID: 15498
			const_10 = 512,
			// Token: 0x04003C8B RID: 15499
			const_11 = 1024,
			// Token: 0x04003C8C RID: 15500
			const_12 = 2048,
			// Token: 0x04003C8D RID: 15501
			const_13 = 4096,
			// Token: 0x04003C8E RID: 15502
			const_14 = 8192,
			// Token: 0x04003C8F RID: 15503
			const_15 = 16384,
			// Token: 0x04003C90 RID: 15504
			const_16 = 32768,
			// Token: 0x04003C91 RID: 15505
			const_17 = 65536,
			// Token: 0x04003C92 RID: 15506
			const_18 = 131072
		}

		// Token: 0x02000C9C RID: 3228
		public struct Struct35
		{
			// Token: 0x04003C93 RID: 15507
			public double double_0;

			// Token: 0x04003C94 RID: 15508
			public double double_1;

			// Token: 0x04003C95 RID: 15509
			public double double_2;

			// Token: 0x04003C96 RID: 15510
			public double double_3;
		}

		// Token: 0x02000C9D RID: 3229
		public struct Struct36
		{
			// Token: 0x04003C97 RID: 15511
			public double double_0;

			// Token: 0x04003C98 RID: 15512
			public double double_1;

			// Token: 0x04003C99 RID: 15513
			public double double_2;

			// Token: 0x04003C9A RID: 15514
			public double double_3;
		}

		// Token: 0x02000C9E RID: 3230
		public struct Struct37
		{
			// Token: 0x04003C9B RID: 15515
			public ECM.Enum107 enum107_0;

			// Token: 0x04003C9C RID: 15516
			public double double_0;

			// Token: 0x04003C9D RID: 15517
			public double double_1;

			// Token: 0x04003C9E RID: 15518
			public double double_2;

			// Token: 0x04003C9F RID: 15519
			public double double_3;

			// Token: 0x04003CA0 RID: 15520
			public double double_4;
		}

		// Token: 0x02000C9F RID: 3231
		public struct Struct38
		{
			// Token: 0x04003CA1 RID: 15521
			public double double_0;

			// Token: 0x04003CA2 RID: 15522
			public double double_1;

			// Token: 0x04003CA3 RID: 15523
			public double double_2;

			// Token: 0x04003CA4 RID: 15524
			public double double_3;

			// Token: 0x04003CA5 RID: 15525
			public double double_4;

			// Token: 0x04003CA6 RID: 15526
			public double double_5;

			// Token: 0x04003CA7 RID: 15527
			public double double_6;

			// Token: 0x04003CA8 RID: 15528
			public double double_7;

			// Token: 0x04003CA9 RID: 15529
			public double double_8;

			// Token: 0x04003CAA RID: 15530
			public double double_9;

			// Token: 0x04003CAB RID: 15531
			public double double_10;

			// Token: 0x04003CAC RID: 15532
			public double double_11;

			// Token: 0x04003CAD RID: 15533
			public double double_12;

			// Token: 0x04003CAE RID: 15534
			public double double_13;

			// Token: 0x04003CAF RID: 15535
			public double double_14;

			// Token: 0x04003CB0 RID: 15536
			public double double_15;

			// Token: 0x04003CB1 RID: 15537
			public double double_16;
		}

		// Token: 0x02000CA0 RID: 3232
		public interface IPropLossMatrix
		{
		}

		// Token: 0x02000CA1 RID: 3233
		public sealed class SteerableNulls
		{
			// Token: 0x06006ADC RID: 27356 RVA: 0x003A2E70 File Offset: 0x003A1070
			public double[] method_0()
			{
				return this.double_0;
			}

			// Token: 0x06006ADD RID: 27357 RVA: 0x003A2E88 File Offset: 0x003A1088
			public double method_1()
			{
				return this.double_1;
			}

			// Token: 0x06006ADE RID: 27358 RVA: 0x003A2EA0 File Offset: 0x003A10A0
			public double method_2()
			{
				return this.double_2;
			}

			// Token: 0x06006ADF RID: 27359 RVA: 0x0002DE6B File Offset: 0x0002C06B
			public SteerableNulls()
			{
				this.double_0 = new double[0];
				this.double_1 = 1.0;
				this.double_2 = -50.0;
			}

			// Token: 0x04003CB2 RID: 15538
			protected double[] double_0;

			// Token: 0x04003CB3 RID: 15539
			protected double double_1;

			// Token: 0x04003CB4 RID: 15540
			protected double double_2;
		}

		// Token: 0x02000CA2 RID: 3234
		public interface IEmitter
		{
			// Token: 0x06006AE0 RID: 27360
			double GetFrequency();

			// Token: 0x06006AE1 RID: 27361
			void SetFrequency(double double_0);

			// Token: 0x06006AE2 RID: 27362
			double GetPeakPower();

			// Token: 0x06006AE3 RID: 27363
			void SetPeakPower(double double_0);

			// Token: 0x06006AE4 RID: 27364
			double GetAntennaAltitude();

			// Token: 0x06006AE5 RID: 27365
			void SetAntennaAltitude(double double_0);

			// Token: 0x06006AE6 RID: 27366
			double GetVerticalBeamwidth();

			// Token: 0x06006AE7 RID: 27367
			double GetHorizontalBeamwidth();

			// Token: 0x06006AE8 RID: 27368
			double GetAntennaGain();

			// Token: 0x06006AE9 RID: 27369
			void SetAntennaGain(double double_0);

			// Token: 0x06006AEA RID: 27370
			ECM.SteerableNulls GetSteerableNulls();

			// Token: 0x06006AEB RID: 27371
			void SetSteerableNulls(ECM.SteerableNulls class365_0);

			// Token: 0x06006AEC RID: 27372
			double imethod_12();
		}

		// Token: 0x02000CA3 RID: 3235
		public sealed class Radar : ECM.IEmitter
		{
			// Token: 0x06006AED RID: 27373 RVA: 0x003A2EB8 File Offset: 0x003A10B8
			public double GetPRF()
			{
				return this.PRF;
			}

			// Token: 0x06006AEE RID: 27374 RVA: 0x003A2ED0 File Offset: 0x003A10D0
			public void SetPRF(double value)
			{
				this.PRF = value;
				if (value <= 0.0)
				{
					this.double_7 = Math.Sqrt(-1.0);
				}
				else
				{
					this.double_7 = 299792458.0 / (2.0 * value) / 1852.0;
					if (this.GetScanRate() > 0.0)
					{
						this.HitsPerScan = this.GetHorizontalBeamwidth() * value / (6.0 * this.GetScanRate());
					}
					else
					{
						this.HitsPerScan = Math.Sqrt(-1.0);
					}
				}
			}

			// Token: 0x06006AEF RID: 27375 RVA: 0x003A2F78 File Offset: 0x003A1178
			public double GetPulsewidth()
			{
				return this.Pulsewidth;
			}

			// Token: 0x06006AF0 RID: 27376 RVA: 0x003A2F90 File Offset: 0x003A1190
			public void SetPulseWidth(double value)
			{
				this.Pulsewidth = value;
				this.double_4 = 299792458.0 * value * 1E-06 / 2.0;
				if (this.Pulsewidth != 1000.0)
				{
					this.double_8 = this.method_5();
				}
				else
				{
					this.double_8 = 0.0;
				}
			}

			// Token: 0x06006AF1 RID: 27377 RVA: 0x003A2FFC File Offset: 0x003A11FC
			public Radar()
			{
				this.double_8 = 0.0;
				this.double_18 = 0.0;
				this.double_19 = 0.0;
				this.TAndF = 275.0;
				this.SNRThreshold = 15.0;
				this.method_8(0.0);
				this.AntennaHeight = 10f;
				this.SetPRF(100.0);
				this.SetScanRate(6.0);
				this.enum107_0 = ECM.Enum107.const_2;
				this.enum108_0 = ECM.Enum108.const_0;
				this.enum109_0 = ECM.Enum109.const_0;
				this.double_16 = 0.0;
				this.double_17 = 1E-06;
				this.AntennaGain = Math.Sqrt(-1.0);
				this.VerticalBeamwidth = 0.0;
				this.HorizontalBeamwidth = Math.Sqrt(-1.0);
				this.SetSteerableNulls(new ECM.SteerableNulls());
				this.method_7(ECM.Enum112.const_0);
			}

			// Token: 0x06006AF2 RID: 27378 RVA: 0x003A3168 File Offset: 0x003A1368
			public double method_4()
			{
				return this.double_8;
			}

			// Token: 0x06006AF3 RID: 27379 RVA: 0x003A3180 File Offset: 0x003A1380
			public double method_5()
			{
				double result;
				if (this.Pulsewidth == 0.0)
				{
					result = 0.0;
				}
				else
				{
					result = 299792458.0 * (this.Pulsewidth + this.double_11) * 1E-06 * 0.5 / 1852.0;
				}
				return result;
			}

			// Token: 0x06006AF4 RID: 27380 RVA: 0x003A31F4 File Offset: 0x003A13F4
			public double GetAntennaAltitude()
			{
				return (double)this.AntennaHeight;
			}

			// Token: 0x06006AF5 RID: 27381 RVA: 0x0002DE9D File Offset: 0x0002C09D
			public void SetAntennaAltitude(double double_20)
			{
				this.AntennaHeight = (float)((int)Math.Round(double_20));
			}

			// Token: 0x06006AF6 RID: 27382 RVA: 0x003A320C File Offset: 0x003A140C
			public ECM.Enum112 method_6()
			{
				return this.enum112_0;
			}

			// Token: 0x06006AF7 RID: 27383 RVA: 0x0002DEAD File Offset: 0x0002C0AD
			public void method_7(ECM.Enum112 enum112_1)
			{
				this.enum112_0 = enum112_1;
			}

			// Token: 0x06006AF8 RID: 27384 RVA: 0x003A3224 File Offset: 0x003A1424
			public double GetFrequency()
			{
				return this.Frequency;
			}

			// Token: 0x06006AF9 RID: 27385 RVA: 0x0002DEB6 File Offset: 0x0002C0B6
			public void SetFrequency(double value)
			{
				this.Frequency = value;
			}

			// Token: 0x06006AFA RID: 27386 RVA: 0x003A323C File Offset: 0x003A143C
			public double GetPeakPower()
			{
				return this.PeakPower;
			}

			// Token: 0x06006AFB RID: 27387 RVA: 0x0002DEBF File Offset: 0x0002C0BF
			public void SetPeakPower(double value)
			{
				this.PeakPower = value;
			}

			// Token: 0x06006AFC RID: 27388 RVA: 0x0002DEC8 File Offset: 0x0002C0C8
			public void method_8(double double_20)
			{
				this.double_11 = double_20;
				this.double_8 = this.method_5();
			}

			// Token: 0x06006AFD RID: 27389 RVA: 0x003A3254 File Offset: 0x003A1454
			public double GetProcessingGainLoss()
			{
				return this.ProcessingGainLoss;
			}

			// Token: 0x06006AFE RID: 27390 RVA: 0x0002DEDD File Offset: 0x0002C0DD
			public void SetProcessingGainLoss(double value)
			{
				this.ProcessingGainLoss = value;
			}

			// Token: 0x06006AFF RID: 27391 RVA: 0x003A326C File Offset: 0x003A146C
			public double GetAntennaGain()
			{
				double antennaGain;
				if (double.IsNaN(this.AntennaGain))
				{
					if (!double.IsNaN(this.VerticalBeamwidth) && !double.IsNaN(this.HorizontalBeamwidth))
					{
						this.AntennaGain = 10.0 * Math.Log10(12.56637061435916 / (2.0 * Math.Sin(this.GetHorizontalBeamwidth() * 0.0174532925199433 / 2.0) * this.GetVerticalBeamwidth() * 0.0174532925199433));
						antennaGain = this.AntennaGain;
					}
					else
					{
						antennaGain = this.AntennaGain;
					}
				}
				else
				{
					antennaGain = this.AntennaGain;
				}
				return antennaGain;
			}

			// Token: 0x06006B00 RID: 27392 RVA: 0x003A3328 File Offset: 0x003A1528
			public void SetAntennaGain(double value)
			{
				this.AntennaGain = value;
				if (double.IsNaN(this.VerticalBeamwidth) && !double.IsNaN(this.HorizontalBeamwidth))
				{
					this.VerticalBeamwidth = 12.56637061435916 / (Math.Pow(10.0, value / 10.0) * 2.0 * Math.Sin(this.HorizontalBeamwidth * 0.0174532925199433 / 2.0) * 0.0174532925199433);
				}
				if (double.IsNaN(this.HorizontalBeamwidth) && !double.IsNaN(this.VerticalBeamwidth))
				{
					this.HorizontalBeamwidth = 2.0 * Math.Asin(12.56637061435916 / (Math.Pow(10.0, value / 10.0) * 2.0 * this.VerticalBeamwidth * 0.0174532925199433)) / 0.0174532925199433;
				}
			}

			// Token: 0x06006B01 RID: 27393 RVA: 0x003A3430 File Offset: 0x003A1630
			public double GetScanRate()
			{
				return this.ScanRate;
			}

			// Token: 0x06006B02 RID: 27394 RVA: 0x003A3448 File Offset: 0x003A1648
			public void SetScanRate(double value)
			{
				this.ScanRate = value;
				if (value > 0.0 && this.GetPRF() > 0.0 && this.GetScanRate() > 0.0)
				{
					this.HitsPerScan = this.GetHorizontalBeamwidth() * this.GetPRF() / (6.0 * value);
				}
				else
				{
					this.HitsPerScan = Math.Sqrt(-1.0);
				}
			}

			// Token: 0x06006B03 RID: 27395 RVA: 0x003A34C8 File Offset: 0x003A16C8
			public double GetHorizontalBeamwidth()
			{
				return this.HorizontalBeamwidth;
			}

			// Token: 0x06006B04 RID: 27396 RVA: 0x003A34E0 File Offset: 0x003A16E0
			public double GetVerticalBeamwidth()
			{
				return this.VerticalBeamwidth;
			}

			// Token: 0x06006B05 RID: 27397 RVA: 0x003A34F8 File Offset: 0x003A16F8
			public double imethod_12()
			{
				return this.double_16;
			}

			// Token: 0x06006B06 RID: 27398 RVA: 0x003A3510 File Offset: 0x003A1710
			public ECM.SteerableNulls GetSteerableNulls()
			{
				return this.steerableNulls;
			}

			// Token: 0x06006B07 RID: 27399 RVA: 0x0002DEE6 File Offset: 0x0002C0E6
			public void SetSteerableNulls(ECM.SteerableNulls value)
			{
				this.steerableNulls = value;
			}

			// Token: 0x06006B08 RID: 27400 RVA: 0x003A3528 File Offset: 0x003A1728
			public double GetHitsPerScan()
			{
				if (this.GetScanRate() == 0.0)
				{
					throw new Exception("Zero scan rate! Can't measure hits per scan");
				}
				return this.HitsPerScan;
			}

			// Token: 0x06006B09 RID: 27401 RVA: 0x003A3560 File Offset: 0x003A1760
			public void SetSystemNoiseLevel(double SystemNoiseLevel_)
			{
				this.SNRThreshold = 40.0;
				this.TAndF = Math.Pow(10.0, SystemNoiseLevel_ / 10.0) * 290.0 - this.SNRThreshold;
			}

			// Token: 0x06006B0A RID: 27402 RVA: 0x003A35AC File Offset: 0x003A17AC
			public double GetSignalPulseWidth()
			{
				double result = 0.0;
				switch (this.enum109_0)
				{
				case ECM.Enum109.const_0:
					result = this.GetPulsewidth() * 1E-06;
					break;
				case ECM.Enum109.const_1:
				case ECM.Enum109.const_2:
					result = this.GetHitsPerScan() * this.GetPulsewidth() * 1E-06;
					break;
				case ECM.Enum109.const_3:
					result = this.GetHorizontalBeamwidth() / (this.GetScanRate() / 6.0);
					break;
				case ECM.Enum109.const_4:
					result = Math.Sqrt(-1.0);
					break;
				}
				return result;
			}

			// Token: 0x06006B0B RID: 27403 RVA: 0x003A3640 File Offset: 0x003A1840
			public void SetBeamwidth(double HorizontalBeamwidth_, double VerticalBeamwidth_)
			{
				this.HorizontalBeamwidth = HorizontalBeamwidth_;
				this.VerticalBeamwidth = VerticalBeamwidth_;
				double d = 12.56637061435916 / (2.0 * Math.Sin(this.HorizontalBeamwidth * 0.0174532925199433 / 2.0) * this.VerticalBeamwidth * 0.0174532925199433);
				this.AntennaGain = 10.0 * Math.Log10(d);
			}

			// Token: 0x04003CB5 RID: 15541
			private double VerticalBeamwidth;

			// Token: 0x04003CB6 RID: 15542
			private double HorizontalBeamwidth;

			// Token: 0x04003CB7 RID: 15543
			private double AntennaGain = 0.0;

			// Token: 0x04003CB8 RID: 15544
			private double HitsPerScan = 0.0;

			// Token: 0x04003CB9 RID: 15545
			protected double double_4 = 0.0;

			// Token: 0x04003CBA RID: 15546
			protected double PRF = 0.0;

			// Token: 0x04003CBB RID: 15547
			protected double Pulsewidth = 0.0;

			// Token: 0x04003CBC RID: 15548
			protected double double_7 = 0.0;

			// Token: 0x04003CBD RID: 15549
			protected double double_8;

			// Token: 0x04003CBE RID: 15550
			public float AntennaHeight;

			// Token: 0x04003CBF RID: 15551
			private ECM.Enum112 enum112_0;

			// Token: 0x04003CC0 RID: 15552
			public double Frequency;

			// Token: 0x04003CC1 RID: 15553
			public double PeakPower;

			// Token: 0x04003CC2 RID: 15554
			protected double double_11;

			// Token: 0x04003CC3 RID: 15555
			public double SNRThreshold;

			// Token: 0x04003CC4 RID: 15556
			public double TAndF;

			// Token: 0x04003CC5 RID: 15557
			protected double ProcessingGainLoss;

			// Token: 0x04003CC6 RID: 15558
			public ECM.Enum107 enum107_0;

			// Token: 0x04003CC7 RID: 15559
			private double ScanRate;

			// Token: 0x04003CC8 RID: 15560
			public double double_16;

			// Token: 0x04003CC9 RID: 15561
			public ECM.Enum109 enum109_0;

			// Token: 0x04003CCA RID: 15562
			public ECM.Enum108 enum108_0;

			// Token: 0x04003CCB RID: 15563
			public double double_17;

			// Token: 0x04003CCC RID: 15564
			protected ECM.SteerableNulls steerableNulls;

			// Token: 0x04003CCD RID: 15565
			protected double double_18;

			// Token: 0x04003CCE RID: 15566
			protected double double_19;
		}

		// Token: 0x02000CA4 RID: 3236
		public sealed class Jammer : ECM.IEmitter
		{
			// Token: 0x06006B0C RID: 27404 RVA: 0x003A36B8 File Offset: 0x003A18B8
			public double GetAntennaAltitude()
			{
				return (double)this.AntennaAltitude;
			}

			// Token: 0x06006B0D RID: 27405 RVA: 0x0002DEEF File Offset: 0x0002C0EF
			public void SetAntennaAltitude(double double_5)
			{
				this.AntennaAltitude = (float)((int)Math.Round(double_5));
			}

			// Token: 0x06006B0E RID: 27406 RVA: 0x003A36D0 File Offset: 0x003A18D0
			public double GetAntennaGain()
			{
				return this.AntennaGain;
			}

			// Token: 0x06006B0F RID: 27407 RVA: 0x003A36E8 File Offset: 0x003A18E8
			public void SetAntennaGain(double double_5)
			{
				this.AntennaGain = double_5;
				this.Beamwidth = 9.8696044010893385 / Math.Pow(10.0, this.GetAntennaGain() / 10.0) * 57.2957795130823;
			}

			// Token: 0x06006B10 RID: 27408 RVA: 0x003A3734 File Offset: 0x003A1934
			public double GetPeakPower()
			{
				return this.PeakPower;
			}

			// Token: 0x06006B11 RID: 27409 RVA: 0x0002DEFF File Offset: 0x0002C0FF
			public void SetPeakPower(double value)
			{
				this.PeakPower = value;
			}

			// Token: 0x06006B12 RID: 27410 RVA: 0x003A374C File Offset: 0x003A194C
			public double GetBandwidth()
			{
				return this.Bandwidth;
			}

			// Token: 0x06006B13 RID: 27411 RVA: 0x0002DF08 File Offset: 0x0002C108
			public void SetBandwidth(double value)
			{
				this.Bandwidth = value;
			}

			// Token: 0x06006B14 RID: 27412 RVA: 0x003A3764 File Offset: 0x003A1964
			public Jammer()
			{
				this.bitArray_0 = new BitArray(ECM.int_0);
			}

			// Token: 0x06006B15 RID: 27413 RVA: 0x000DD398 File Offset: 0x000DB598
			public double imethod_12()
			{
				return 0.0;
			}

			// Token: 0x06006B16 RID: 27414 RVA: 0x003A37B4 File Offset: 0x003A19B4
			public double GetFrequency()
			{
				return this.Frequency;
			}

			// Token: 0x06006B17 RID: 27415 RVA: 0x0002DF11 File Offset: 0x0002C111
			public void SetFrequency(double double_5)
			{
				this.Frequency = double_5;
			}

			// Token: 0x06006B18 RID: 27416 RVA: 0x003A37CC File Offset: 0x003A19CC
			public double GetHorizontalBeamwidth()
			{
				return this.Beamwidth;
			}

			// Token: 0x06006B19 RID: 27417 RVA: 0x003A37E4 File Offset: 0x003A19E4
			public ECM.SteerableNulls GetSteerableNulls()
			{
				return null;
			}

			// Token: 0x06006B1A RID: 27418 RVA: 0x003A37F4 File Offset: 0x003A19F4
			public void SetSteerableNulls(ECM.SteerableNulls SteerableNulls_)
			{
				try
				{
					throw new Exception("You're not supposed to add steerable null support to jammers!");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200224", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
			}

			// Token: 0x06006B1B RID: 27419 RVA: 0x003A37CC File Offset: 0x003A19CC
			public double GetVerticalBeamwidth()
			{
				return this.Beamwidth;
			}

			// Token: 0x04003CCF RID: 15567
			private float AntennaAltitude;

			// Token: 0x04003CD0 RID: 15568
			private double AntennaGain;

			// Token: 0x04003CD1 RID: 15569
			protected double Beamwidth;

			// Token: 0x04003CD2 RID: 15570
			private double PeakPower = 0.0;

			// Token: 0x04003CD3 RID: 15571
			private double Bandwidth = 0.0;

			// Token: 0x04003CD4 RID: 15572
			private BitArray bitArray_0;

			// Token: 0x04003CD5 RID: 15573
			protected double Frequency = 0.0;
		}

		// Token: 0x02000CA5 RID: 3237
		public struct Receiver
		{
			// Token: 0x04003CD6 RID: 15574
			public float AntennaHeight;

			// Token: 0x04003CD7 RID: 15575
			public double Sensitivity;

			// Token: 0x04003CD8 RID: 15576
			public double SystemLoss;

			// Token: 0x04003CD9 RID: 15577
			public BitArray bitArray_0;

			// Token: 0x04003CDA RID: 15578
			public double double_2;

			// Token: 0x04003CDB RID: 15579
			public double double_3;

			// Token: 0x04003CDC RID: 15580
			public int int_0;
		}

		// Token: 0x02000CA6 RID: 3238
		public sealed class Target
		{
			// Token: 0x06006B1C RID: 27420 RVA: 0x0002DF1A File Offset: 0x0002C11A
			public Target()
			{
				this.enum111_0 = ECM.Enum111.const_0;
				this.AntennaAltitude_ASL = 0.0;
				this.double_2 = 0.0;
			}

			// Token: 0x06006B1D RID: 27421 RVA: 0x003A3854 File Offset: 0x003A1A54
			public double GetRCS_m2()
			{
				return Math.Pow(10.0, this.RCS / 10.0);
			}

			// Token: 0x06006B1E RID: 27422 RVA: 0x0002DF56 File Offset: 0x0002C156
			public void SetRCS(double value)
			{
				this.RCS = 10.0 * Math.Log10(value);
			}

			// Token: 0x04003CDD RID: 15581
			public float fAntennaAltitude_ASL;

			// Token: 0x04003CDE RID: 15582
			public double RCS;

			// Token: 0x04003CDF RID: 15583
			public ECM.Enum111 enum111_0;

			// Token: 0x04003CE0 RID: 15584
			public double AntennaAltitude_ASL;

			// Token: 0x04003CE1 RID: 15585
			public double double_2 = 0.0;
		}

		// Token: 0x02000CA7 RID: 3239
		public enum Enum111
		{
			// Token: 0x04003CE3 RID: 15587
			const_0,
			// Token: 0x04003CE4 RID: 15588
			const_1,
			// Token: 0x04003CE5 RID: 15589
			const_2,
			// Token: 0x04003CE6 RID: 15590
			const_3,
			// Token: 0x04003CE7 RID: 15591
			const_4,
			// Token: 0x04003CE8 RID: 15592
			const_5,
			// Token: 0x04003CE9 RID: 15593
			const_6,
			// Token: 0x04003CEA RID: 15594
			const_7
		}

		// Token: 0x02000CA8 RID: 3240
		public enum Enum112
		{
			// Token: 0x04003CEC RID: 15596
			const_0,
			// Token: 0x04003CED RID: 15597
			E_BasicCapability,
			// Token: 0x04003CEE RID: 15598
			E_1980Plus,
			// Token: 0x04003CEF RID: 15599
			E_2000Plus
		}
	}
}
