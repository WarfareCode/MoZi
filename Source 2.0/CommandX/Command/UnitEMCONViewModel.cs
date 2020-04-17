using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns35;
using ns4;

namespace Command
{
	// Token: 0x02000859 RID: 2137
	[Attribute0, Attribute2, Attribute3]
	public sealed class UnitEMCONViewModel : INotifyPropertyChanged
	{
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06003499 RID: 13465 RVA: 0x0011B544 File Offset: 0x00119744
		// (remove) Token: 0x0600349A RID: 13466 RVA: 0x0011B57C File Offset: 0x0011977C
		public static event UnitEMCONViewModel.Delegate56 SensorsFormRequested
		{
			[CompilerGenerated]
			add
			{
				UnitEMCONViewModel.Delegate56 @delegate = UnitEMCONViewModel.delegate56_0;
				UnitEMCONViewModel.Delegate56 delegate2;
				do
				{
					delegate2 = @delegate;
					UnitEMCONViewModel.Delegate56 value2 = (UnitEMCONViewModel.Delegate56)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<UnitEMCONViewModel.Delegate56>(ref UnitEMCONViewModel.delegate56_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				UnitEMCONViewModel.Delegate56 @delegate = UnitEMCONViewModel.delegate56_0;
				UnitEMCONViewModel.Delegate56 delegate2;
				do
				{
					delegate2 = @delegate;
					UnitEMCONViewModel.Delegate56 value2 = (UnitEMCONViewModel.Delegate56)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<UnitEMCONViewModel.Delegate56>(ref UnitEMCONViewModel.delegate56_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600349B RID: 13467 RVA: 0x0011B5B4 File Offset: 0x001197B4
		// (remove) Token: 0x0600349C RID: 13468 RVA: 0x0011B5F0 File Offset: 0x001197F0
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

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x0600349D RID: 13469 RVA: 0x0011B62C File Offset: 0x0011982C
		// (set) Token: 0x0600349E RID: 13470 RVA: 0x0001C0F9 File Offset: 0x0001A2F9
		public InvertableBool Inherit
		{
			[CompilerGenerated]
			get
			{
				return this.invertableBool_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.invertableBool_0 != value)
				{
					this.invertableBool_0 = value;
					this.vmethod_0("Inherit");
				}
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x0600349F RID: 13471 RVA: 0x0011B644 File Offset: 0x00119844
		// (set) Token: 0x060034A0 RID: 13472 RVA: 0x0001C11B File Offset: 0x0001A31B
		public InvertableBool RadarActive
		{
			[CompilerGenerated]
			get
			{
				return this.invertableBool_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.invertableBool_1 != value)
				{
					this.invertableBool_1 = value;
					this.vmethod_0("RadarActive");
				}
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060034A1 RID: 13473 RVA: 0x0011B65C File Offset: 0x0011985C
		// (set) Token: 0x060034A2 RID: 13474 RVA: 0x0001C13D File Offset: 0x0001A33D
		public InvertableBool SonarActive
		{
			[CompilerGenerated]
			get
			{
				return this.invertableBool_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.invertableBool_2 != value)
				{
					this.invertableBool_2 = value;
					this.vmethod_0("SonarActive");
				}
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060034A3 RID: 13475 RVA: 0x0011B674 File Offset: 0x00119874
		// (set) Token: 0x060034A4 RID: 13476 RVA: 0x0001C15F File Offset: 0x0001A35F
		public InvertableBool OECMActive
		{
			[CompilerGenerated]
			get
			{
				return this.invertableBool_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.invertableBool_3 != value)
				{
					this.invertableBool_3 = value;
					this.vmethod_0("OECMActive");
				}
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060034A5 RID: 13477 RVA: 0x0011B68C File Offset: 0x0011988C
		// (set) Token: 0x060034A6 RID: 13478 RVA: 0x0001C181 File Offset: 0x0001A381
		public InvertableBool ObeysEMCON
		{
			[CompilerGenerated]
			get
			{
				return this.invertableBool_4;
			}
			[CompilerGenerated]
			set
			{
				if (this.invertableBool_4 != value)
				{
					this.invertableBool_4 = value;
					this.vmethod_0("ObeysEMCON");
				}
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060034A7 RID: 13479 RVA: 0x0011B6A4 File Offset: 0x001198A4
		// (set) Token: 0x060034A8 RID: 13480 RVA: 0x0001C1A3 File Offset: 0x0001A3A3
		public Class2535 UpdateEMCONCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2535_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2535_0 != value)
				{
					this.class2535_0 = value;
					this.vmethod_0("UpdateEMCONCommand");
				}
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060034A9 RID: 13481 RVA: 0x0011B6BC File Offset: 0x001198BC
		// (set) Token: 0x060034AA RID: 13482 RVA: 0x0001C1C5 File Offset: 0x0001A3C5
		public Class2535 EMCONWindowCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2535_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2535_1 != value)
				{
					this.class2535_1 = value;
					this.vmethod_0("EMCONWindowCommand");
				}
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060034AB RID: 13483 RVA: 0x0011B6D4 File Offset: 0x001198D4
		// (set) Token: 0x060034AC RID: 13484 RVA: 0x0001C1E7 File Offset: 0x0001A3E7
		public Class2535 SensorsWindowCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2535_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2535_2 != value)
				{
					this.class2535_2 = value;
					this.vmethod_0("SensorsWindowCommand");
				}
			}
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x0011B6EC File Offset: 0x001198EC
		public void method_0()
		{
			DoctrineForm doctrineForm = new DoctrineForm();
			doctrineForm.subject = this.theUnit;
			doctrineForm.Show();
			doctrineForm.vmethod_0().SelectedIndex = 1;
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x0011B720 File Offset: 0x00119920
		public void method_1()
		{
			UnitEMCONViewModel.Delegate56 @delegate = UnitEMCONViewModel.delegate56_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x0011B740 File Offset: 0x00119940
		public void method_2()
		{
			this.ObeysEMCON = InvertableBool.smethod_0(this.theUnit.GetSensory().IsObeysEMCON());
			if (InvertableBool.smethod_1(this.Inherit))
			{
				this.theUnit.m_Doctrine.SetEMCON_Settings(true);
				this.RadarActive = InvertableBool.smethod_0(this.theUnit.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar() > Doctrine.EMCON_Settings.Enum36.const_0);
				this.SonarActive = InvertableBool.smethod_0(this.theUnit.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar() > Doctrine.EMCON_Settings.Enum36.const_0);
				this.OECMActive = InvertableBool.smethod_0(this.theUnit.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM() > Doctrine.EMCON_Settings.Enum36.const_0);
			}
			else
			{
				this.theUnit.m_Doctrine.SetEMCON_Settings(false);
				this.theUnit.m_Doctrine.SetEMCON_SettingsForSonar((Doctrine.EMCON_Settings.Enum36)Conversions.ToByte(Interaction.IIf(InvertableBool.smethod_1(this.RadarActive), Doctrine.EMCON_Settings.Enum36.const_1, Doctrine.EMCON_Settings.Enum36.const_0)), Client.GetClientScenario());
				this.theUnit.m_Doctrine.SetEMCON_SettingsForRadar((Doctrine.EMCON_Settings.Enum36)Conversions.ToByte(Interaction.IIf(InvertableBool.smethod_1(this.SonarActive), Doctrine.EMCON_Settings.Enum36.const_1, Doctrine.EMCON_Settings.Enum36.const_0)), Client.GetClientScenario());
				this.theUnit.m_Doctrine.method_173((Doctrine.EMCON_Settings.Enum36)Conversions.ToByte(Interaction.IIf(InvertableBool.smethod_1(this.OECMActive), Doctrine.EMCON_Settings.Enum36.const_1, Doctrine.EMCON_Settings.Enum36.const_0)), Client.GetClientScenario());
			}
			CommandFactory.GetCommandMain().GetMainForm().GetMapBox().Focus();
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x0011B8E0 File Offset: 0x00119AE0
		public void method_3()
		{
			this.Inherit = InvertableBool.smethod_0(this.theUnit.m_Doctrine.EMCON_SettingsHasNoValue());
			this.ObeysEMCON = InvertableBool.smethod_0(this.theUnit.GetSensory().IsObeysEMCON());
			this.RadarActive = InvertableBool.smethod_0(this.theUnit.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar() > Doctrine.EMCON_Settings.Enum36.const_0);
			this.SonarActive = InvertableBool.smethod_0(this.theUnit.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar() > Doctrine.EMCON_Settings.Enum36.const_0);
			this.OECMActive = InvertableBool.smethod_0(this.theUnit.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM() > Doctrine.EMCON_Settings.Enum36.const_0);
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x0011B99C File Offset: 0x00119B9C
		public UnitEMCONViewModel(ActiveUnit theUnit)
		{
			this.UpdateEMCONCommand = new Class2535(new Action<object>(this.method_4));
			this.EMCONWindowCommand = new Class2535(new Action<object>(this.method_5));
			this.SensorsWindowCommand = new Class2535(new Action<object>(this.method_6));
			try
			{
				this.theUnit = theUnit;
				this.method_3();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x0001C209 File Offset: 0x0001A409
		[CompilerGenerated]
		private void method_4(object a0)
		{
			this.method_2();
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x0001C211 File Offset: 0x0001A411
		[CompilerGenerated]
		private void method_5(object a0)
		{
			this.method_0();
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x0001C219 File Offset: 0x0001A419
		[CompilerGenerated]
		private void method_6(object a0)
		{
			this.method_1();
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x0011BA30 File Offset: 0x00119C30
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400185C RID: 6236
		[CompilerGenerated]
		private InvertableBool invertableBool_0;

		// Token: 0x0400185D RID: 6237
		[CompilerGenerated]
		private InvertableBool invertableBool_1;

		// Token: 0x0400185E RID: 6238
		[CompilerGenerated]
		private InvertableBool invertableBool_2;

		// Token: 0x0400185F RID: 6239
		[CompilerGenerated]
		private InvertableBool invertableBool_3;

		// Token: 0x04001860 RID: 6240
		[CompilerGenerated]
		private static UnitEMCONViewModel.Delegate56 delegate56_0;

		// Token: 0x04001861 RID: 6241
		[CompilerGenerated]
		private InvertableBool invertableBool_4;

		// Token: 0x04001862 RID: 6242
		[CompilerGenerated]
		private Class2535 class2535_0;

		// Token: 0x04001863 RID: 6243
		[CompilerGenerated]
		private Class2535 class2535_1;

		// Token: 0x04001864 RID: 6244
		[CompilerGenerated]
		private Class2535 class2535_2;

		// Token: 0x04001865 RID: 6245
		public ActiveUnit theUnit;

		// Token: 0x04001866 RID: 6246
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x0200085A RID: 2138
		// (Invoke) Token: 0x060034B7 RID: 13495
		public delegate void Delegate56();
	}
}
