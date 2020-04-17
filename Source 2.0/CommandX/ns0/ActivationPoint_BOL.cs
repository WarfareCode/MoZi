using System;
using System.Xml;
using Command_Core;

namespace ns0
{
	// Token: 0x020009BC RID: 2492
	public sealed class ActivationPoint_BOL : Contact
	{
		// Token: 0x06004242 RID: 16962 RVA: 0x00180DDC File Offset: 0x0017EFDC
		public ActivationPoint_BOL(double Lat_, double Lon_) : base(null, 0)
		{
			this.contactType = Contact_Base.ContactType.ActivationPoint;
			this.SetLatitude(null, Lat_);
			this.SetLongitude(null, Lon_);
			this.Name = "BOL Activation Point: " + Misc.GetGeoLocationString(this.GetLatitude(null), this.GetLongitude(null));
			base.SetGuid("ActivationPoint_" + XmlConvert.ToString(this.GetLatitude(null)) + "_" + XmlConvert.ToString(this.GetLongitude(null)));
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x00180E8C File Offset: 0x0017F08C
		public static ActivationPoint_BOL GetActivationPoint_BOL(string strGeoLocation)
		{
			string[] array = strGeoLocation.Split(new char[]
			{
				'_'
			});
			double lat_ = XmlConvert.ToDouble(array[1]);
			double lon_ = XmlConvert.ToDouble(array[2]);
			return new ActivationPoint_BOL(lat_, lon_);
		}
	}
}
