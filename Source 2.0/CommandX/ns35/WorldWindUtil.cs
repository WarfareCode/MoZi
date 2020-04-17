using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using Command_Core;
using Microsoft.DirectX;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns18;
using ns6;

namespace ns35
{
	// Token: 0x02000AA5 RID: 2725
	public sealed class WorldWindUtil
	{
		// Token: 0x06005667 RID: 22119 RVA: 0x002518F4 File Offset: 0x0024FAF4
		public static Point WorldToScreenCoordinate(ref WorldWindow worldWindow, double lat, double lng)
		{
			Point result = default(Point);
			int x = result.X;
			int y = result.Y;
			WorldWindUtil.WorldToScreenCoordinate(ref worldWindow, lat, lng, ref x, ref y);
			result.Y = y;
			result.X = x;
			return result;
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x00251938 File Offset: 0x0024FB38
		public static GeoPoint ScreenToWorldCoordinate(ref WorldWindow worldWindow, int x, int y)
		{
			GeoPoint geoPoint = new GeoPoint();
			Angle angle = default(Angle);
			Angle angle2 = default(Angle);
			worldWindow.GetDrawArgs().GetWorldCamera().PickingRayIntersection(x, y, out angle, out angle2);
			geoPoint.SetLongitude(angle2.GetDegrees());
			geoPoint.SetLatitude(angle.GetDegrees());
			return geoPoint;
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x00251990 File Offset: 0x0024FB90
		public static void ScreenToWorldCoordinate(ref WorldWindow worldWindow, ref int x, ref int y, ref double Lat, ref double Lon)
		{
			Angle angle = default(Angle);
			Angle angle2 = default(Angle);
			worldWindow.GetDrawArgs().GetWorldCamera().PickingRayIntersection(x, y, out angle, out angle2);
			Lat = angle2.GetDegrees();
			Lon = angle.GetDegrees();
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x002519DC File Offset: 0x0024FBDC
		public static void WorldToScreenCoordinate(ref WorldWindow WorldWindow_, double lat, double lng, ref int x, ref int y)
		{
			try
			{
				if (!double.IsNaN(lat) && !double.IsInfinity(lat) && !double.IsNaN(lng) && !double.IsInfinity(lng))
				{
					Vector3 vector = MathEngine.SphericalToCartesian(lat, lng, WorldWindow_.method_2().GetEquatorialRadius() + 0.0);
					Vector3 point = new Vector3((float)((double)vector.X - WorldWindow_.GetDrawArgs().GetWorldCamera().ReferenceCenter.X), (float)((double)vector.Y - WorldWindow_.GetDrawArgs().GetWorldCamera().ReferenceCenter.Y), (float)((double)vector.Z - WorldWindow_.GetDrawArgs().GetWorldCamera().ReferenceCenter.Z));
					Vector3 vector2 = WorldWindow_.GetDrawArgs().GetWorldCamera().Project(point);
					if (!float.IsNaN(vector2.X) && !float.IsNaN(vector2.Y))
					{
						Point point2 = new Point((int)Math.Round((double)vector2.X), (int)Math.Round((double)vector2.Y));
						x = point2.X;
						y = point2.Y;
					}
				}
				else
				{
					x = -1;
					y = -1;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200424", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600566B RID: 22123 RVA: 0x00251B68 File Offset: 0x0024FD68
		public static bool IsInFOV(ref WorldWindow worldWindow, double lat, double lng)
		{
			bool result;
			if (double.IsNaN(lat) | double.IsNaN(lng))
			{
				result = false;
			}
			else
			{
				Vector3 v = MathEngine.SphericalToCartesian(lat, lng, worldWindow.method_2().GetEquatorialRadius() + 0.0);
				result = worldWindow.GetDrawArgs().GetWorldCamera().GetViewFrustum().ContainsPoint(v);
			}
			return result;
		}

		// Token: 0x0600566C RID: 22124 RVA: 0x00251BC4 File Offset: 0x0024FDC4
		public static bool IsInFOV(ref WorldWindow worldWindow, Unit theUnit)
		{
			bool flag;
			bool result;
			if (theUnit.IsActiveUnit() && !((ActiveUnit)theUnit).IsOperating())
			{
				flag = false;
			}
			else
			{
				if (theUnit.IsContact())
				{
					List<GeoPoint> uncertaintyArea = ((Contact)theUnit).GetUncertaintyArea();
					if (!Information.IsNothing(uncertaintyArea))
					{
						int num = uncertaintyArea.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							GeoPoint geoPoint = uncertaintyArea[i];
							if (WorldWindUtil.IsInFOV(ref worldWindow, geoPoint.GetLatitude(), geoPoint.GetLongitude()))
							{
								result = true;
								return result;
							}
							if (WorldWindUtil.IsInFOV(ref worldWindow, theUnit.GetLatitude(null), theUnit.GetLongitude(null)))
							{
								result = true;
								return result;
							}
						}
						result = false;
						return result;
					}
				}
				double latitude = theUnit.GetLatitude(null);
				double longitude = theUnit.GetLongitude(null);
				if (double.IsNaN(latitude))
				{
					flag = false;
				}
				else if (double.IsNaN(longitude))
				{
					flag = false;
				}
				else
				{
					Vector3 v = MathEngine.SphericalToCartesian(latitude, longitude, worldWindow.method_2().GetEquatorialRadius() + 0.0);
					flag = worldWindow.GetDrawArgs().GetWorldCamera().GetViewFrustum().ContainsPoint(v);
				}
			}
			result = flag;
			return result;
		}
	}
}
