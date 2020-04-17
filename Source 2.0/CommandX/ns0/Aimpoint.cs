using System;
using System.Xml;
using Command_Core;

namespace ns0
{
	// Token: 0x020009BB RID: 2491
	public sealed class Aimpoint : Contact
	{
		// Token: 0x06004240 RID: 16960 RVA: 0x00180CF0 File Offset: 0x0017EEF0
		public Aimpoint(double Lat, double Lon) : base(null, 0)
		{
			this.contactType = Contact_Base.ContactType.Aimpoint;
			this.SetLatitude(null, Lat);
			this.SetLongitude(null, Lon);
			this.Name = "Aimpoint: " + Misc.GetGeoLocationString(this.GetLatitude(null), this.GetLongitude(null));
			base.SetGuid("Aimpoint_" + XmlConvert.ToString(this.GetLatitude(null)) + "_" + XmlConvert.ToString(this.GetLongitude(null)));
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x00180D9C File Offset: 0x0017EF9C
		public static Aimpoint GetAimpoint(string GeoLocationString)
		{
			string[] array = GeoLocationString.Split(new char[]
			{
				'_'
			});
			double lat = XmlConvert.ToDouble(array[1]);
			double lon = XmlConvert.ToDouble(array[2]);
			return new Aimpoint(lat, lon);
		}
	}
}
