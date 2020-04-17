using System;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;
using QuickGraph;

namespace Command_Core
{
	// Token: 0x02000CBE RID: 3262
	public sealed class WPModule
	{
		// Token: 0x04003D9D RID: 15773
		private static CultureInfo cultureInfo_0 = new CultureInfo("en-US");

		// Token: 0x02000CBF RID: 3263
		public class Class325 : IIdentifiable
		{
			// Token: 0x1700050B RID: 1291
			// (get) Token: 0x06006BB4 RID: 27572 RVA: 0x003BDEC0 File Offset: 0x003BC0C0
			// (set) Token: 0x06006BB5 RID: 27573 RVA: 0x0002E0F3 File Offset: 0x0002C2F3
			[XmlIgnore]
			public double Altitude
			{
				get
				{
					return this.double_0;
				}
				set
				{
					this.double_0 = value;
				}
			}

			// Token: 0x1700050C RID: 1292
			// (get) Token: 0x06006BB6 RID: 27574 RVA: 0x003BDED8 File Offset: 0x003BC0D8
			// (set) Token: 0x06006BB7 RID: 27575 RVA: 0x0002E0FC File Offset: 0x0002C2FC
			[XmlIgnore]
			public double Latitude
			{
				get
				{
					return this.double_1;
				}
				set
				{
					this.double_1 = value;
				}
			}

			// Token: 0x1700050D RID: 1293
			// (get) Token: 0x06006BB8 RID: 27576 RVA: 0x003BDEF0 File Offset: 0x003BC0F0
			// (set) Token: 0x06006BB9 RID: 27577 RVA: 0x0002E105 File Offset: 0x0002C305
			[XmlIgnore]
			public double Longitude
			{
				get
				{
					return this.double_2;
				}
				set
				{
					this.double_2 = value;
				}
			}

			// Token: 0x1700050E RID: 1294
			// (get) Token: 0x06006BBA RID: 27578 RVA: 0x003BDF08 File Offset: 0x003BC108
			// (set) Token: 0x06006BBB RID: 27579 RVA: 0x003BDF20 File Offset: 0x003BC120
			[XmlAttribute]
			public string Coords
			{
				get
				{
					return this.ToString();
				}
				set
				{
					string[] array = value.Split(new char[]
					{
						' '
					});
					if (array.Length == 3)
					{
						string s = array[0];
						IFormatProvider cultureInfo_ = WPModule.cultureInfo_0;
						double num = this.Latitude;
						bool flag = double.TryParse(s, NumberStyles.AllowDecimalPoint, cultureInfo_, out num);
						this.Latitude = num;
						if (flag)
						{
							string s2 = array[1];
							IFormatProvider cultureInfo_2 = WPModule.cultureInfo_0;
							num = this.Longitude;
							bool flag2 = double.TryParse(s2, NumberStyles.AllowDecimalPoint, cultureInfo_2, out num);
							this.Longitude = num;
							if (flag2)
							{
								string s3 = array[2];
								IFormatProvider cultureInfo_3 = WPModule.cultureInfo_0;
								num = this.Altitude;
								double.TryParse(s3, NumberStyles.AllowDecimalPoint, cultureInfo_3, out num);
								this.Altitude = num;
							}
						}
					}
					else if (array.Length == 2)
					{
						string s4 = array[0];
						IFormatProvider cultureInfo_4 = WPModule.cultureInfo_0;
						double num = this.Latitude;
						bool flag3 = double.TryParse(s4, NumberStyles.AllowDecimalPoint, cultureInfo_4, out num);
						this.Latitude = num;
						if (flag3)
						{
							string s5 = array[1];
							IFormatProvider cultureInfo_5 = WPModule.cultureInfo_0;
							num = this.Longitude;
							bool flag4 = double.TryParse(s5, NumberStyles.AllowDecimalPoint, cultureInfo_5, out num);
							this.Longitude = num;
							if (flag4)
							{
								this.Altitude = 0.0;
							}
						}
					}
					else
					{
						try
						{
							throw new Exception("Coords parse error");
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200260", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw;
						}
					}
				}
			}

			// Token: 0x1700050F RID: 1295
			// (get) Token: 0x06006BBC RID: 27580 RVA: 0x003BE0C0 File Offset: 0x003BC2C0
			public string ID
			{
				get
				{
					return this.string_0;
				}
			}

			// Token: 0x06006BBD RID: 27581 RVA: 0x003BE0D8 File Offset: 0x003BC2D8
			public Class325()
			{
				this.string_0 = Guid.NewGuid().ToString();
			}

			// Token: 0x04003D9E RID: 15774
			protected string string_0;

			// Token: 0x04003D9F RID: 15775
			protected double double_0;

			// Token: 0x04003DA0 RID: 15776
			protected double double_1;

			// Token: 0x04003DA1 RID: 15777
			protected double double_2 = 0.0;
		}

		// Token: 0x02000CC0 RID: 3264
		public sealed class Class326 : IIdentifiableVertexFactory<WPModule.Waypoint>
		{
			// Token: 0x06006BBE RID: 27582 RVA: 0x003BE114 File Offset: 0x003BC314
			public WPModule.Waypoint CreateVertex(string id)
			{
				return new WPModule.Waypoint(id);
			}
		}

		// Token: 0x02000CC1 RID: 3265
		[Serializable]
		public sealed class Waypoint : WPModule.Class325
		{
			// Token: 0x17000510 RID: 1296
			// (get) Token: 0x06006BC0 RID: 27584 RVA: 0x003BE12C File Offset: 0x003BC32C
			// (set) Token: 0x06006BC1 RID: 27585 RVA: 0x003BE168 File Offset: 0x003BC368
			[XmlAttribute]
			public string DisplayCoords
			{
				get
				{
					return this._X.ToString(WPModule.cultureInfo_0) + " " + this._Y.ToString(WPModule.cultureInfo_0);
				}
				set
				{
					string[] array = value.Split(new char[]
					{
						' '
					});
					try
					{
						if (array.Length != 2)
						{
							throw new Exception("DisplayCoords parse error");
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200261", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw;
					}
					try
					{
						if (!double.TryParse(array[0], NumberStyles.AllowDecimalPoint, WPModule.cultureInfo_0, out this._X))
						{
							throw new Exception("x parse error");
						}
						if (!double.TryParse(array[1], NumberStyles.AllowDecimalPoint, WPModule.cultureInfo_0, out this._Y))
						{
							throw new Exception("y parse error");
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ex4.Data.Add("Error at 200262", ex4.Message);
						GameGeneral.LogException(ref ex4);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw;
					}
				}
			}

			// Token: 0x17000511 RID: 1297
			// (get) Token: 0x06006BC2 RID: 27586 RVA: 0x003BE278 File Offset: 0x003BC478
			// (set) Token: 0x06006BC3 RID: 27587 RVA: 0x0002E10E File Offset: 0x0002C30E
			[XmlIgnore]
			public double X
			{
				get
				{
					return this._X;
				}
				set
				{
					this._X = value;
				}
			}

			// Token: 0x17000512 RID: 1298
			// (get) Token: 0x06006BC4 RID: 27588 RVA: 0x003BE290 File Offset: 0x003BC490
			// (set) Token: 0x06006BC5 RID: 27589 RVA: 0x0002E117 File Offset: 0x0002C317
			[XmlIgnore]
			public double Y
			{
				get
				{
					return this._Y;
				}
				set
				{
					this._Y = value;
				}
			}

			// Token: 0x06006BC6 RID: 27590 RVA: 0x0002E120 File Offset: 0x0002C320
			public Waypoint(string string_1)
			{
				this.string_0 = string_1;
			}

			// Token: 0x06006BC7 RID: 27591 RVA: 0x0002E12F File Offset: 0x0002C32F
			public Waypoint()
			{
			}

			// Token: 0x06006BC8 RID: 27592 RVA: 0x003BE2A8 File Offset: 0x003BC4A8
			public override string ToString()
			{
				return string.Concat(new string[]
				{
					this.double_1.ToString(WPModule.cultureInfo_0),
					" ",
					this.double_2.ToString(WPModule.cultureInfo_0),
					" ",
					this.double_0.ToString(WPModule.cultureInfo_0)
				});
			}

			// Token: 0x04003DA2 RID: 15778
			protected double _X;

			// Token: 0x04003DA3 RID: 15779
			protected double _Y;
		}

		// Token: 0x02000CC2 RID: 3266
		public sealed class Class327 : IIdentifiableEdgeFactory<WPModule.Waypoint, WPModule.Class328>
		{
			// Token: 0x06006BC9 RID: 27593 RVA: 0x003BE310 File Offset: 0x003BC510
			public WPModule.Class328 CreateEdge(string id, WPModule.Waypoint source, WPModule.Waypoint target)
			{
				return new WPModule.Class328(id, ref source, ref target);
			}
		}

		// Token: 0x02000CC3 RID: 3267
		public sealed class Class328 : IdentifiableEdge<WPModule.Waypoint>
		{
			// Token: 0x06006BCB RID: 27595 RVA: 0x003BE32C File Offset: 0x003BC52C
			public Class328(string string_1, ref WPModule.Waypoint waypoint_0, ref WPModule.Waypoint waypoint_1) : base(string_1, waypoint_0, waypoint_1)
			{
				this.string_0 = Guid.NewGuid().ToString();
			}

			// Token: 0x04003DA4 RID: 15780
			protected string string_0;
		}
	}
}
