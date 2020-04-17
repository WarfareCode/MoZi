using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using ns0;
using ns17;
using ns18;
using ns19;
using ns29;
using ns4;

namespace ns16
{
	// Token: 0x020004B9 RID: 1209
	public sealed class TiledPlacenameSet : RenderableObject
	{
		// Token: 0x06001F9F RID: 8095 RVA: 0x000D012C File Offset: 0x000CE32C
		public TiledPlacenameSet(string string_4, World class1995_2, double double_3, double double_4, double double_5, string string_5, FontDescription fontDescription_1, Color color_0, string string_6) : base(string_4, class1995_2.vmethod_15(), Quaternion.RotationYawPitchRoll(0f, 0f, 0f))
		{
			this.m_parentWorld = class1995_2;
			this.m_altitude = double_3;
			this.m_maximumDistanceSq = double_4 * double_4;
			this.m_minimumDistanceSq = double_5 * double_5;
			this.m_placenameListFilePath = string_5;
			this.m_fontDescription = fontDescription_1;
			this.m_color = color_0.ToArgb();
			this.m_iconFilePath = string_6;
			this.m_renderPriority = RenderPriority.Placenames;
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x0000D810 File Offset: 0x0000BA10
		public override bool IsOn()
		{
			return this.isOn;
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00013012 File Offset: 0x00011212
		public override void SetIsOn(bool value)
		{
			if (this.isOn && !value)
			{
				this.Dispose();
			}
			this.isOn = value;
			if (this.GetName() == "Placenames")
			{
				World.Settings.showPlacenames = value;
			}
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x000D0200 File Offset: 0x000CE400
		public override void Initialize(DrawArgs drawArgs)
		{
			this.isInitialized = true;
			this.m_drawingFont = drawArgs.CreateFont(this.m_fontDescription);
			if (!File.Exists(this.m_placenameListFilePath))
			{
				this.isInitialized = true;
				Log.Write(Log.Levels.Error, "PLACE", this.m_placenameListFilePath + " not found.");
			}
			else
			{
				if (this.m_iconFilePath != null)
				{
					this.m_iconTexture = ImageHelper.LoadIconTexture(this.m_iconFilePath);
					using (Surface surfaceLevel = this.m_iconTexture.GetSurfaceLevel(0))
					{
						SurfaceDescription description = surfaceLevel.Description;
						this.m_spriteSize = new Rectangle(0, 0, description.Width, description.Height);
					}
					this.m_sprite = new Sprite(drawArgs.device_0);
				}
				using (BufferedStream bufferedStream = new BufferedStream(File.Open(this.m_placenameListFilePath, FileMode.Open, FileAccess.Read, FileShare.Read)))
				{
					using (BinaryReader binaryReader = new BinaryReader(bufferedStream, Encoding.ASCII))
					{
						int num = binaryReader.ReadInt32();
						for (int i = 0; i < num; i++)
						{
							WorldWindPlacenameFile worldWindPlacenameFile = new WorldWindPlacenameFile();
							worldWindPlacenameFile.dataFilename = binaryReader.ReadString();
							worldWindPlacenameFile.west = binaryReader.ReadSingle();
							worldWindPlacenameFile.south = binaryReader.ReadSingle();
							worldWindPlacenameFile.east = binaryReader.ReadSingle();
							worldWindPlacenameFile.north = binaryReader.ReadSingle();
							this.m_placenameFileList.Add(worldWindPlacenameFile);
						}
					}
				}
			}
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x000D03A0 File Offset: 0x000CE5A0
		public override void Dispose()
		{
			this.isInitialized = false;
			if (this.m_placenameFileList != null)
			{
				object syncRoot = this.m_placenameFileList.SyncRoot;
				lock (syncRoot)
				{
					this.m_placenameFileList.Clear();
				}
			}
			if (this.m_placenameFiles != null)
			{
				object syncRoot = this.m_placenameFiles.SyncRoot;
				lock (syncRoot)
				{
					this.m_placenameFiles.Clear();
				}
			}
			if (this.m_placeNames != null)
			{
				lock (this)
				{
					this.m_placeNames = null;
				}
			}
			if (this.m_iconTexture != null)
			{
				this.m_iconTexture.Dispose();
				this.m_iconTexture = null;
			}
			if (this.m_sprite != null)
			{
				this.m_sprite.Dispose();
				this.m_sprite = null;
			}
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x000081A2 File Offset: 0x000063A2
		public override bool PerformSelectionAction(DrawArgs class1943_0)
		{
			return false;
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x000D04D0 File Offset: 0x000CE6D0
		public override bool Update(DrawArgs drawArgs)
		{
			bool result = false;
			try
			{
				if (!this.isInitialized)
				{
					this.Initialize(drawArgs);
					result = true;
				}
				if (this.lastView != drawArgs.GetWorldCamera().GetViewMatrix())
				{
					ArrayList arrayList = new ArrayList();
					bool arg_7D_0;
					if (this.m_minimumDistanceSq == 0.0)
					{
						if (this.m_maximumDistanceSq == 0.0)
						{
							arg_7D_0 = false;
							goto IL_7D;
						}
					}
					arg_7D_0 = (drawArgs.GetWorldCamera().GetAltitude() * drawArgs.GetWorldCamera().GetAltitude() > this.m_maximumDistanceSq);
					IL_7D:
					if (!arg_7D_0)
					{
						this.curPlaceNameIndex = 0;
						foreach (WorldWindPlacenameFile placenameFileDescriptor in this.m_placenameFileList)
						{
							this.UpdateNames(placenameFileDescriptor, arrayList, drawArgs);
						}
					}
					lock (this)
					{
						this.m_placeNames = new WorldWindPlacename[arrayList.Count];
						arrayList.CopyTo(this.m_placeNames);
					}
					this.lastView = drawArgs.GetWorldCamera().GetViewMatrix();
					result = true;
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x000D064C File Offset: 0x000CE84C
		private void UpdateNames(WorldWindPlacenameFile placenameFileDescriptor, ArrayList tempPlacenames, DrawArgs drawArgs)
		{
			double degrees = drawArgs.GetWorldCamera().GetTrueViewRange().GetDegrees();
			double num = drawArgs.GetWorldCamera().GetLatitude().GetDegrees() + degrees;
			double num2 = drawArgs.GetWorldCamera().GetLatitude().GetDegrees() - degrees;
			double num3 = drawArgs.GetWorldCamera().GetLongitude().GetDegrees() - degrees;
			double num4 = drawArgs.GetWorldCamera().GetLongitude().GetDegrees() + degrees;
			if ((double)placenameFileDescriptor.north >= num2 && (double)placenameFileDescriptor.south <= num && (double)placenameFileDescriptor.east >= num3 && (double)placenameFileDescriptor.west <= num4)
			{
				using (BufferedStream bufferedStream = new BufferedStream(File.Open(Path.Combine(Path.GetDirectoryName(this.m_placenameListFilePath), placenameFileDescriptor.dataFilename), FileMode.Open, FileAccess.Read, FileShare.Read)))
				{
					using (BinaryReader binaryReader = new BinaryReader(bufferedStream, Encoding.ASCII))
					{
						WorldWindPlacenameFile worldWindPlacenameFile = new WorldWindPlacenameFile();
						worldWindPlacenameFile.dataFilename = placenameFileDescriptor.dataFilename;
						worldWindPlacenameFile.north = placenameFileDescriptor.north;
						worldWindPlacenameFile.south = placenameFileDescriptor.south;
						worldWindPlacenameFile.west = placenameFileDescriptor.west;
						worldWindPlacenameFile.east = placenameFileDescriptor.east;
						int num5 = binaryReader.ReadInt32();
						tempPlacenames.Capacity = tempPlacenames.Count + num5;
						for (int i = 0; i < num5; i++)
						{
							if (this.m_placeNames != null && this.curPlaceNameIndex < this.m_placeNames.Length)
							{
							}
							string text = binaryReader.ReadString();
							float num6 = binaryReader.ReadSingle();
							float num7 = binaryReader.ReadSingle();
							int num8 = binaryReader.ReadInt32();
							for (int j = 0; j < num8; j++)
							{
								binaryReader.ReadString();
								binaryReader.ReadString();
							}
							float num9 = num7;
							if ((double)num9 < num3)
							{
								num9 += 360f;
							}
							if ((double)num6 <= num && (double)num6 >= num2 && (double)num9 <= num4 && (double)num9 >= num3)
							{
								WorldWindPlacename worldWindPlacename = default(WorldWindPlacename);
								worldWindPlacename.Lat = num6;
								worldWindPlacename.Lon = num7;
								worldWindPlacename.Name = text;
								worldWindPlacename.ChineseName = text;
								string value = TiledPlacenameSet.PlaceNameMapping.GetConfigList()["PlaceNameMapping"].GetValue(text);
								if (value != null)
								{
									worldWindPlacename.ChineseName = value;
								}
								float num10 = 0f;
								if (this.m_parentWorld.GetTerrainAccessor() != null && drawArgs.GetWorldCamera().GetAltitude() < 300000.0)
								{
									num10 = this.m_parentWorld.GetTerrainAccessor().vmethod_1((double)num6, (double)num7);
								}
								float num11 = (float)(this.m_parentWorld.GetEquatorialRadius() + (double)World.Settings.GetVerticalExaggeration() * this.m_altitude + (double)(World.Settings.GetVerticalExaggeration() * num10));
								worldWindPlacename.cartesianPoint = MathEngine.SphericalToCartesian((double)num6, (double)num7, (double)num11);
								float num12 = Vector3.LengthSq(worldWindPlacename.cartesianPoint - drawArgs.GetWorldCamera().GetPosition());
								if ((double)num12 <= this.m_maximumDistanceSq && (double)num12 >= this.m_minimumDistanceSq && drawArgs.GetWorldCamera().GetViewFrustum().ContainsPoint(worldWindPlacename.cartesianPoint))
								{
									tempPlacenames.Add(worldWindPlacename);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x000D09FC File Offset: 0x000CEBFC
		public override void Render(DrawArgs drawArgs)
		{
			try
			{
				lock (this)
				{
					Vector3 position = drawArgs.GetWorldCamera().GetPosition();
					if (this.m_placeNames != null)
					{
						int color = -2130706433;
						if ((this.m_color & 255) + (this.m_color >> 8 & 255) + (this.m_color >> 16 & 255) > 382)
						{
							color = -2147483648;
						}
						if (this.m_sprite != null)
						{
							this.m_sprite.Begin(SpriteFlags.AlphaBlend);
						}
						int num = 0;
						Vector3 right = new Vector3((float)drawArgs.GetWorldCamera().ReferenceCenter.X, (float)drawArgs.GetWorldCamera().ReferenceCenter.Y, (float)drawArgs.GetWorldCamera().ReferenceCenter.Z);
						for (int i = 0; i < this.m_placeNames.Length; i++)
						{
							Vector3 cartesianPoint = this.m_placeNames[i].cartesianPoint;
							float num2 = Vector3.LengthSq(cartesianPoint - position);
							if ((double)num2 <= this.m_maximumDistanceSq && (double)num2 >= this.m_minimumDistanceSq && drawArgs.GetWorldCamera().GetViewFrustum().ContainsPoint(cartesianPoint))
							{
								Vector3 vector = drawArgs.GetWorldCamera().Project(cartesianPoint - right);
								string text;
								if (this.bPlaceNameShowInChinese)
								{
									text = this.m_placeNames[i].ChineseName;
								}
								else
								{
									text = this.m_placeNames[i].Name;
								}
								Rectangle rectangle = this.m_drawingFont.MeasureString(null, text, this.m_textFormat, this.m_color);
								vector.Y -= (float)(rectangle.Height / 2);
								if (this.m_sprite == null)
								{
									vector.X -= (float)(rectangle.Width / 2);
								}
								rectangle.Inflate(3, 1);
								int num3 = (int)Math.Round((double)vector.X);
								int num4 = (int)Math.Round((double)vector.Y);
								rectangle.Offset(num3, num4);
								if (World.Settings.bool_9)
								{
									this.m_drawingFont.DrawText(null, text, num3 - 1, num4 - 1, color);
									this.m_drawingFont.DrawText(null, text, num3 - 1, num4 + 1, color);
									this.m_drawingFont.DrawText(null, text, num3 + 1, num4 - 1, color);
									this.m_drawingFont.DrawText(null, text, num3 + 1, num4 + 1, color);
								}
								this.m_drawingFont.DrawText(null, text, num3, num4, this.m_color);
								num++;
								if (num > 30)
								{
									break;
								}
							}
						}
						if (this.m_sprite != null)
						{
							this.m_sprite.End();
						}
					}
				}
			}
			catch (Exception exception_)
			{
				Log.smethod_3(exception_);
			}
		}

		// Token: 0x04000EDE RID: 3806
		protected World m_parentWorld;

		// Token: 0x04000EDF RID: 3807
		protected double m_minimumDistanceSq;

		// Token: 0x04000EE0 RID: 3808
		protected double m_maximumDistanceSq;

		// Token: 0x04000EE1 RID: 3809
		protected string m_placenameListFilePath;

		// Token: 0x04000EE2 RID: 3810
		protected string m_iconFilePath;

		// Token: 0x04000EE3 RID: 3811
		protected Sprite m_sprite;

		// Token: 0x04000EE4 RID: 3812
		protected Microsoft.DirectX.Direct3D.Font m_drawingFont;

		// Token: 0x04000EE5 RID: 3813
		protected int m_color;

		// Token: 0x04000EE6 RID: 3814
		protected ArrayList m_placenameFileList = new ArrayList();

		// Token: 0x04000EE7 RID: 3815
		protected Hashtable m_placenameFiles = new Hashtable();

		// Token: 0x04000EE8 RID: 3816
		protected Hashtable m_renderablePlacenames = new Hashtable();

		// Token: 0x04000EE9 RID: 3817
		protected WorldWindPlacename[] m_placeNames;

		// Token: 0x04000EEA RID: 3818
		protected double m_altitude = 0.0;

		// Token: 0x04000EEB RID: 3819
		protected Texture m_iconTexture;

		// Token: 0x04000EEC RID: 3820
		protected Rectangle m_spriteSize;

		// Token: 0x04000EED RID: 3821
		protected FontDescription m_fontDescription;

		// Token: 0x04000EEE RID: 3822
		protected DrawTextFormat m_textFormat;

		// Token: 0x04000EEF RID: 3823
		protected static int IconWidth = 48;

		// Token: 0x04000EF0 RID: 3824
		protected static int IconHeight = 48;

		// Token: 0x04000EF1 RID: 3825
		private int curPlaceNameIndex = 0;

		// Token: 0x04000EF2 RID: 3826
		private Matrix lastView = Matrix.Identity;

		// Token: 0x04000EF3 RID: 3827
		private static string PlaceNameTranslationFile = MyTemplate.GetApp().Info.DirectoryPath + "\\PlaceNameTranslation.ini";

		// Token: 0x04000EF4 RID: 3828
		public static Class2372 PlaceNameMapping = new Class2372(TiledPlacenameSet.PlaceNameTranslationFile);

		// Token: 0x04000EF5 RID: 3829
		private bool bPlaceNameShowInChinese = SimConfiguration.gameOptions.IsPlacenameShowInChinese();
	}
}
