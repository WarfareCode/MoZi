using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace Command
{
	// 舰艇燃油属性变化
	[Attribute0, Attribute2, Attribute3]
	public sealed class ShipFuelViewModel : INotifyPropertyChanged
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06003168 RID: 12648 RVA: 0x0010BD74 File Offset: 0x00109F74
		// (remove) Token: 0x06003169 RID: 12649 RVA: 0x0010BDB0 File Offset: 0x00109FB0
		public event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x0600316A RID: 12650 RVA: 0x0010BDEC File Offset: 0x00109FEC
		// (set) Token: 0x0600316B RID: 12651 RVA: 0x0001A928 File Offset: 0x00018B28
		public double Percentage
		{
			[CompilerGenerated]
			get
			{
				return this.double_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_0 != value)
				{
					this.double_0 = value;
					this.vmethod_0("Percentage");
				}
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x0600316C RID: 12652 RVA: 0x0010BE04 File Offset: 0x0010A004
		// (set) Token: 0x0600316D RID: 12653 RVA: 0x0001A94A File Offset: 0x00018B4A
		public string Text
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.string_0, value, StringComparison.Ordinal))
				{
					this.string_0 = value;
					this.vmethod_0("Text");
				}
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x0600316E RID: 12654 RVA: 0x0010BE1C File Offset: 0x0010A01C
		// (set) Token: 0x0600316F RID: 12655 RVA: 0x0001A970 File Offset: 0x00018B70
		public string UnitName
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.string_1, value, StringComparison.Ordinal))
				{
					this.string_1 = value;
					this.vmethod_0("UnitName");
				}
			}
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x00004A21 File Offset: 0x00002C21
		[Obsolete("Used for design time only", true)]
		public ShipFuelViewModel()
		{
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x0010BE34 File Offset: 0x0010A034
		[Attribute0, Attribute2]
		public void Refresh()
		{
			this.UnitName = this.theUnit.Name;
			double value = 0.0;
			double num = 0.0;
			this.Percentage = (double)((int)Math.Round(this.theUnit.GetFuelLeft(ref value, ref num, false) * 100.0));
			long timeToBurnOut = this.theUnit.GetTimeToBurnOut(this.theUnit.GetThrottle(), null, new float?((float)((int)Math.Round((double)this.theUnit.GetDesiredSpeed()))), new float?(0f));
			HashSet<string> hashSet = new HashSet<string>();
			string text = "";
			FuelRec[] fuelRecs = this.theUnit.GetFuelRecs();
			string str;
			checked
			{
				for (int i = 0; i < fuelRecs.Length; i++)
				{
					FuelRec fuelRec = fuelRecs[i];
					hashSet.Add(fuelRec.FuelType.ToString());
				}
				if (hashSet.Count > 0)
				{
					text = " (" + string.Join(", ", hashSet.ToArray<string>()) + ")";
					if (hashSet.Count > 1)
					{
						text = "\r\n" + text;
					}
				}
				str = Conversions.ToString(Math.Round(value, 0)) + "燃油单位剩余";
				if (!string.IsNullOrEmpty(text))
				{
					str += text;
				}
			}
			string str2;
			if (this.theUnit.GetThrottle() == ActiveUnit.Throttle.FullStop)
			{
				str2 = "作战单元处于全速航行状态";
			}
			else
			{
				str2 = Misc.GetTimeString(timeToBurnOut, Aircraft_AirOps._Maintenance.const_0, false, true) + ", " + Conversions.ToString(Math.Round((double)((float)timeToBurnOut * this.theUnit.GetCurrentSpeed() / 3600f), 0)) + " nm";
			}
			this.Text = str + "\r\n" + str2;
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x0001A996 File Offset: 0x00018B96
		public ShipFuelViewModel(Ship theUnit)
		{
			this.theUnit = theUnit;
			this.Refresh();
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x0010BFF8 File Offset: 0x0010A1F8
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040016EF RID: 5871
		[CompilerGenerated]
		private double double_0;

		// Token: 0x040016F0 RID: 5872
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040016F1 RID: 5873
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040016F2 RID: 5874
		public Ship theUnit;

		// Token: 0x040016F3 RID: 5875
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
