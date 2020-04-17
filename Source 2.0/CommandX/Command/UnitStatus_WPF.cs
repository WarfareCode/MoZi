using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns32;
using ns35;
using ns4;

namespace Command
{
	// Token: 0x02000987 RID: 2439
	[DesignerGenerated]
	public sealed partial class UnitStatus_WPF : System.Windows.Controls.UserControl, IComponentConnector
	{
		// Token: 0x06003D69 RID: 15721 RVA: 0x0013CB54 File Offset: 0x0013AD54
		[CompilerGenerated]
		public static void smethod_0(UnitStatus_WPF.Delegate60 delegate60_1)
		{
			UnitStatus_WPF.Delegate60 @delegate = UnitStatus_WPF.delegate60_0;
			UnitStatus_WPF.Delegate60 delegate2;
			do
			{
				delegate2 = @delegate;
				UnitStatus_WPF.Delegate60 value = (UnitStatus_WPF.Delegate60)Delegate.Combine(delegate2, delegate60_1);
				@delegate = Interlocked.CompareExchange<UnitStatus_WPF.Delegate60>(ref UnitStatus_WPF.delegate60_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06003D6A RID: 15722 RVA: 0x0013CB8C File Offset: 0x0013AD8C
		[CompilerGenerated]
		public static void smethod_1(UnitStatus_WPF.Delegate61 delegate61_1)
		{
			UnitStatus_WPF.Delegate61 @delegate = UnitStatus_WPF.delegate61_0;
			UnitStatus_WPF.Delegate61 delegate2;
			do
			{
				delegate2 = @delegate;
				UnitStatus_WPF.Delegate61 value = (UnitStatus_WPF.Delegate61)Delegate.Combine(delegate2, delegate61_1);
				@delegate = Interlocked.CompareExchange<UnitStatus_WPF.Delegate61>(ref UnitStatus_WPF.delegate61_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06003D6B RID: 15723 RVA: 0x0013CBC4 File Offset: 0x0013ADC4
		[CompilerGenerated]
		public static void smethod_2(UnitStatus_WPF.Delegate62 delegate62_1)
		{
			UnitStatus_WPF.Delegate62 @delegate = UnitStatus_WPF.delegate62_0;
			UnitStatus_WPF.Delegate62 delegate2;
			do
			{
				delegate2 = @delegate;
				UnitStatus_WPF.Delegate62 value = (UnitStatus_WPF.Delegate62)Delegate.Combine(delegate2, delegate62_1);
				@delegate = Interlocked.CompareExchange<UnitStatus_WPF.Delegate62>(ref UnitStatus_WPF.delegate62_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x0013CBFC File Offset: 0x0013ADFC
		[CompilerGenerated]
		public static void smethod_3(UnitStatus_WPF.Delegate63 delegate63_1)
		{
			UnitStatus_WPF.Delegate63 @delegate = UnitStatus_WPF.delegate63_0;
			UnitStatus_WPF.Delegate63 delegate2;
			do
			{
				delegate2 = @delegate;
				UnitStatus_WPF.Delegate63 value = (UnitStatus_WPF.Delegate63)Delegate.Combine(delegate2, delegate63_1);
				@delegate = Interlocked.CompareExchange<UnitStatus_WPF.Delegate63>(ref UnitStatus_WPF.delegate63_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x0013CC34 File Offset: 0x0013AE34
		private string method_0(ActiveUnit activeUnit_0)
		{
			string str;
			if (activeUnit_0.IsAircraft)
			{
				str = "Aircraft";
			}
			else if (activeUnit_0.IsShip)
			{
				str = "Ship";
			}
			else if (activeUnit_0.IsSubmarine)
			{
				str = "Submarine";
			}
			else if (activeUnit_0.IsFacility)
			{
				str = "Facility";
			}
			else if (activeUnit_0.IsSatellite())
			{
				str = "Satellite";
			}
			else
			{
				if (!activeUnit_0.IsWeapon)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw new NotImplementedException();
				}
				str = "Weapon";
			}
			string str2;
			switch (DBOps.GetDBRecord(Client.GetClientScenario().GetDBUsed(), ref this.dbfileCheckResult_0, false, false).DBID)
			{
			case 1:
				str2 = "DB3000";
				break;
			case 2:
				str2 = "CWDB";
				break;
			case 3:
				str2 = "WW2DB";
				break;
			default:
				str2 = "DB3000";
				break;
			}
			string text = CommandFactory.GetCommandApp().Info.DirectoryPath + "\\DB\\Images\\" + str2;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			return Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + ".jpg");
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x0013CD68 File Offset: 0x0013AF68
		private BitmapImage method_1(ActiveUnit activeUnit_0, string string_1)
		{
			BitmapImage result;
			if (UnitStatus_WPF.dictionary_0.ContainsKey(string_1))
			{
				result = UnitStatus_WPF.dictionary_0[string_1];
			}
			else if (File.Exists(string_1))
			{
				BitmapImage bitmapImage = new BitmapImage(new Uri(string_1));
				UnitStatus_WPF.dictionary_0[string_1] = bitmapImage;
				result = bitmapImage;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x000200E0 File Offset: 0x0001E2E0
		public UnitStatus_WPF()
		{
			base.SizeChanged += new SizeChangedEventHandler(this.UnitStatus_WPF_SizeChanged);
			this.string_0 = "";
			this.InitializeComponent();
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x0013CDC0 File Offset: 0x0013AFC0
		private void method_2(ActiveUnit activeUnit_0)
		{
			if (activeUnit_0.GetAllPlatformComponents().Count == 0)
			{
				this.PB_ComponentsDestroyed.Width = 0.0;
				this.PB_ComponentsHeavyDamage.Width = 0.0;
				this.PB_ComponentsMediumDamage.Width = 0.0;
				this.PB_ComponentsLightDamage.Width = 0.0;
				this.PB_ComponentsOK.Width = 0.0;
			}
			else
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				foreach (PlatformComponent current in activeUnit_0.GetAllPlatformComponents())
				{
					switch (current.GetComponentStatus())
					{
					case PlatformComponent._ComponentStatus.Operational:
						num++;
						break;
					case PlatformComponent._ComponentStatus.Damaged:
						switch (current.GetDamageSeverity())
						{
						case PlatformComponent._DamageSeverityFactor.Light:
							num2++;
							break;
						case PlatformComponent._DamageSeverityFactor.Medium:
							num3++;
							break;
						case PlatformComponent._DamageSeverityFactor.Heavy:
							num4++;
							break;
						}
						break;
					case PlatformComponent._ComponentStatus.Destroyed:
						num5++;
						break;
					}
				}
				try
				{
					if (num5 > 0)
					{
						this.PB_ComponentsDestroyed.Width = (double)((int)Math.Round((double)(190 * num5) / (double)activeUnit_0.GetAllPlatformComponents().Count));
					}
					else
					{
						this.PB_ComponentsDestroyed.Width = 0.0;
					}
					if (num4 > 0)
					{
						this.PB_ComponentsHeavyDamage.Width = (double)((int)Math.Round((double)(190 * num4) / (double)activeUnit_0.GetAllPlatformComponents().Count));
					}
					else
					{
						this.PB_ComponentsHeavyDamage.Width = 0.0;
					}
					if (num3 > 0)
					{
						this.PB_ComponentsMediumDamage.Width = (double)((int)Math.Round((double)(190 * num3) / (double)activeUnit_0.GetAllPlatformComponents().Count));
					}
					else
					{
						this.PB_ComponentsMediumDamage.Width = 0.0;
					}
					if (num2 > 0)
					{
						this.PB_ComponentsLightDamage.Width = (double)((int)Math.Round((double)(190 * num2) / (double)activeUnit_0.GetAllPlatformComponents().Count));
					}
					else
					{
						this.PB_ComponentsLightDamage.Width = 0.0;
					}
					if (num > 0)
					{
						this.PB_ComponentsOK.Width = (double)((int)Math.Round((double)(190 * num) / (double)activeUnit_0.GetAllPlatformComponents().Count));
					}
					else
					{
						this.PB_ComponentsOK.Width = 0.0;
					}
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
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x0013D098 File Offset: 0x0013B298
		private void ShowUnitStatusImage(ActiveUnit activeUnit_0)
		{
			try
			{
				string text = this.method_0(activeUnit_0);
				if (Operators.CompareString(this.string_0, text, false) != 0)
				{
					if (SimConfiguration.gameOptions.IsShowUnitStatusImage())
					{
						BitmapImage bitmapImage = this.method_1(activeUnit_0, text);
						if (Information.IsNothing(bitmapImage) & !Information.IsNothing(this.bitmapImage_0))
						{
							this.Image_UnitImage.Source = null;
							this.Image_UnitImage.Visibility = Visibility.Collapsed;
							this.bitmapImage_0 = null;
						}
						else if (!(Information.IsNothing(bitmapImage) & Information.IsNothing(this.bitmapImage_0)))
						{
							if (!Information.IsNothing(bitmapImage) && !Information.IsNothing(this.bitmapImage_0) && Operators.CompareString(bitmapImage.ToString(), this.bitmapImage_0.ToString(), false) == 0)
							{
								this.Image_UnitImage.Visibility = Visibility.Visible;
								if (Information.IsNothing(this.Image_UnitImage.Source))
								{
									this.Image_UnitImage.Source = bitmapImage;
								}
							}
							else
							{
								this.Image_UnitImage.Source = this.method_1(activeUnit_0, text);
								this.Image_UnitImage.Visibility = Visibility.Visible;
								this.bitmapImage_0 = bitmapImage;
							}
						}
					}
					else if (!Information.IsNothing(this.bitmapImage_0))
					{
						this.Image_UnitImage.Source = null;
						this.Image_UnitImage.Visibility = Visibility.Collapsed;
						this.bitmapImage_0 = null;
					}
					this.string_0 = text;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (this.Image_UnitImage.Source != null)
				{
					this.Image_UnitImage.Source = null;
					this.Image_UnitImage.Visibility = Visibility.Collapsed;
				}
				ex2.Data.Add("Error at 200371", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x0013D278 File Offset: 0x0013B478
		private void ShowContactStatus(Scenario scenario_0, Side side_0, Unit unit_0)
		{
			this.DockPanel_Mission.Visibility = Visibility.Collapsed;
			this.TextBlock_Loadout.Visibility = Visibility.Collapsed;
			this.Expander_GroupMembers.Visibility = Visibility.Collapsed;
			this.Expander_TankerClients.Visibility = Visibility.Collapsed;
			this.TextBlock_UnitStatus.Visibility = Visibility.Collapsed;
			this.Button_ContactReport.Visibility = Visibility.Visible;
			this.Button_Weapons.Visibility = Visibility.Hidden;
			this.Button_MCM.Visibility = Visibility.Collapsed;
			this.DockPanel_AssignedHost.Visibility = Visibility.Collapsed;
			this.Label_UnitProficiency.Visibility = Visibility.Collapsed;
			this.Button_Damage.Visibility = Visibility.Collapsed;
			this.Dockpanel_ComponentStatus.Visibility = Visibility.Collapsed;
			this.DockPanel_GroupLeadSlowDown.Visibility = Visibility.Collapsed;
			this.Button_CargoOps.Visibility = Visibility.Collapsed;
			Contact contact = (Contact)unit_0;
			if (!Information.IsNothing(contact.ActualUnit) && (side_0.GetContactObservableDictionary().ContainsKey(contact.ActualUnit.GetGuid()) || side_0.GetContactsObDictionary().ContainsKey(contact.ActualUnit.GetGuid())))
			{
				this.Label_UnitName.Content = contact.Name;
				if (contact.GetIdentificationStatus() > Contact_Base.IdentificationStatus.KnownType)
				{
					this.TextBlock_UnitClass.Text = Misc.smethod_11(contact.ActualUnit.UnitClass);
					this.Hyperlink_UnitClass.IsEnabled = true;
					if (!(contact.contactType == Contact_Base.ContactType.Installation | contact.contactType == Contact_Base.ContactType.MobileGroup | contact.contactType == Contact_Base.ContactType.AirBase | contact.contactType == Contact_Base.ContactType.NavalBase))
					{
						this.ShowUnitStatusImage(contact.ActualUnit);
					}
					else
					{
						this.Image_UnitImage.Source = null;
						this.Image_UnitImage.Visibility = Visibility.Collapsed;
					}
				}
				else
				{
					this.TextBlock_UnitClass.Text = "不明型号";
					this.Hyperlink_UnitClass.IsEnabled = false;
					this.Image_UnitImage.Source = null;
					this.Image_UnitImage.Visibility = Visibility.Collapsed;
				}
				this.Label_UnitCourse.Content = "航向: " + contact.method_80();
				if ((contact.contactType == Contact_Base.ContactType.Air | contact.contactType == Contact_Base.ContactType.Missile) & contact.Altitude_Known)
				{
					this.Label_UnitSpeed.Content = string.Concat(new string[]
					{
						"航速: ",
						Conversions.ToString((int)Math.Round((double)contact.GetCurrentSpeed())),
						" 节(马赫数:",
						Conversions.ToString(Math.Round((double)Class263.GetIRCrossSectionModifier((double)contact.GetCurrentAltitude_ASL(false), (double)contact.GetCurrentSpeed()), 2)),
						")"
					});
				}
				else
				{
					this.Label_UnitSpeed.Content = "航速: " + contact.method_81();
				}
				if (contact.SideIsKnown)
				{
					if (!Information.IsNothing(contact.ActualUnit.GetSide(false)))
					{
						this.Label_UnitSide.Content = "推演方: " + contact.ActualUnit.GetSide(false).GetSideName();
					}
				}
				else
				{
					this.Label_UnitSide.Content = "推演方: 不明";
				}
				if (contact.ActualUnit.IsShip | contact.ActualUnit.IsFacility)
				{
					this.DockPanel_UnitAlt.Visibility = Visibility.Collapsed;
					this.CB_SpeedOverride.Visibility = Visibility.Collapsed;
					this.CB_AltitudeOverride.Visibility = Visibility.Collapsed;
					this.TB_SpeedOverride.Visibility = Visibility.Collapsed;
					this.TB_AltitudeOverride.Visibility = Visibility.Collapsed;
				}
				else
				{
					this.Label_UnitAlt.Content = "高度: " + contact.method_82(SimConfiguration.gameOptions.UseImperialUnit());
					this.DockPanel_UnitAlt.Visibility = Visibility.Visible;
					this.CB_AltitudeOverride.Visibility = Visibility.Collapsed;
					this.TB_AltitudeOverride.Visibility = Visibility.Collapsed;
					this.DockPanel_UnitSpeed.Visibility = Visibility.Visible;
					this.CB_SpeedOverride.Visibility = Visibility.Collapsed;
					this.TB_SpeedOverride.Visibility = Visibility.Collapsed;
				}
				this.DockPanel_SensorsWeapons.Visibility = Visibility.Collapsed;
				if (!contact.ActualUnit.IsAircraft && !contact.ActualUnit.IsWeapon)
				{
					this.Dockpanel_Damage.Visibility = Visibility.Visible;
					this.Dockpanel_FireDamage.Visibility = Visibility.Visible;
					if (contact.ActualUnit.IsShip | contact.ActualUnit.IsSubmarine)
					{
						this.Dockpanel_FloodDamage.Visibility = Visibility.Visible;
					}
					else
					{
						this.Dockpanel_FloodDamage.Visibility = Visibility.Collapsed;
					}
					this.Label_UnitDamage.Text = "战损评估: " + Misc.GetBDAString(contact.GetBattleDamageAssessment(Client.GetClientSide()));
					if (!contact.ActualUnit.IsShip && !contact.ActualUnit.IsSubmarine)
					{
						this.Label_FloodDamage.Visibility = Visibility.Hidden;
						this.PB_FloodDamage.Visibility = Visibility.Hidden;
					}
					else
					{
						this.Label_FloodDamage.Visibility = Visibility.Visible;
						this.PB_FloodDamage.Visibility = Visibility.Visible;
						if (contact.GetBDA_Flood(Client.GetClientSide()).HasValue)
						{
							this.Label_FloodDamage.Content = "进水:";
							ActiveUnit_Damage.FloodingIntensityLevel? bDA_Flood = contact.GetBDA_Flood(Client.GetClientSide());
							byte? b = bDA_Flood.HasValue ? new byte?((byte)bDA_Flood.GetValueOrDefault()) : null;
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								this.PB_FloodDamage.Value = 0.0;
							}
							else
							{
								b = (bDA_Flood.HasValue ? new byte?((byte)bDA_Flood.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									this.PB_FloodDamage.Value = 25.0;
								}
								else
								{
									b = (bDA_Flood.HasValue ? new byte?((byte)bDA_Flood.GetValueOrDefault()) : null);
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										this.PB_FloodDamage.Value = 50.0;
									}
									else
									{
										b = (bDA_Flood.HasValue ? new byte?((byte)bDA_Flood.GetValueOrDefault()) : null);
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											this.PB_FloodDamage.Value = 75.0;
										}
										else
										{
											b = (bDA_Flood.HasValue ? new byte?((byte)bDA_Flood.GetValueOrDefault()) : null);
											if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												this.PB_FloodDamage.Value = 100.0;
											}
										}
									}
								}
							}
						}
						else
						{
							this.PB_FloodDamage.Visibility = Visibility.Collapsed;
							this.Label_FloodDamage.Content = "进水: 不明";
						}
					}
					this.Label_FireDamage.Visibility = Visibility.Visible;
					this.PB_FireDamage.Visibility = Visibility.Visible;
					if (contact.GetBDA_Fire(Client.GetClientSide()).HasValue)
					{
						this.Label_FireDamage.Content = "失火:";
						ActiveUnit_Damage.FireIntensityLevel? bDA_Fire = contact.GetBDA_Fire(Client.GetClientSide());
						byte? b = bDA_Fire.HasValue ? new byte?((byte)bDA_Fire.GetValueOrDefault()) : null;
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							this.PB_FireDamage.Value = 0.0;
						}
						else
						{
							b = (bDA_Fire.HasValue ? new byte?((byte)bDA_Fire.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								this.PB_FireDamage.Value = 25.0;
							}
							else
							{
								b = (bDA_Fire.HasValue ? new byte?((byte)bDA_Fire.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									this.PB_FireDamage.Value = 50.0;
								}
								else
								{
									b = (bDA_Fire.HasValue ? new byte?((byte)bDA_Fire.GetValueOrDefault()) : null);
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
									{
										this.PB_FireDamage.Value = 75.0;
									}
									else
									{
										b = (bDA_Fire.HasValue ? new byte?((byte)bDA_Fire.GetValueOrDefault()) : null);
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
										{
											this.PB_FireDamage.Value = 100.0;
										}
									}
								}
							}
						}
					}
					else
					{
						this.PB_FireDamage.Visibility = Visibility.Collapsed;
						this.Label_FireDamage.Content = "失火: 不明";
					}
				}
				else
				{
					this.Dockpanel_Damage.Visibility = Visibility.Collapsed;
					this.Dockpanel_FireDamage.Visibility = Visibility.Collapsed;
					this.Dockpanel_FloodDamage.Visibility = Visibility.Collapsed;
				}
				this.Button_Magazines.Visibility = Visibility.Collapsed;
				this.Dockpanel_Ops.Visibility = Visibility.Collapsed;
			}
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x0013DC60 File Offset: 0x0013BE60
		private void ShowGroupStatus(Scenario scenario_, Side side_, Unit unit_)
		{
			this.group = (Group)unit_;
			if (!Information.IsNothing(this.group) && !Information.IsNothing(this.group.GetGroupLead()))
			{
				this.ShowUnitStatusImage(this.group.GetGroupLead());
				this.DockPanel_Status.Visibility = Visibility.Visible;
				this.Button_ContactReport.Visibility = Visibility.Collapsed;
				this.Button_Weapons.Visibility = Visibility.Hidden;
				this.Button_MCM.Visibility = Visibility.Collapsed;
				this.Button_CargoOps.Visibility = Visibility.Collapsed;
				this.Button_Magazines.Visibility = Visibility.Collapsed;
				this.Dockpanel_Damage.Visibility = Visibility.Collapsed;
				this.Dockpanel_FireDamage.Visibility = Visibility.Collapsed;
				this.Dockpanel_FloodDamage.Visibility = Visibility.Collapsed;
				this.Expander_GroupMembers.Visibility = Visibility.Visible;
				this.Expander_TankerClients.Visibility = Visibility.Collapsed;
				this.DockPanel_AssignedHost.Visibility = Visibility.Collapsed;
				this.Label_UnitProficiency.Visibility = Visibility.Collapsed;
				this.TextBlock_UnitClass.Visibility = Visibility.Visible;
				this.Dockpanel_ComponentStatus.Visibility = Visibility.Collapsed;
				this.Hyperlink_UnitClass.IsEnabled = true;
				switch (this.group.GetGroupType())
				{
				case Group.GroupType.AirGroup:
				case Group.GroupType.Installation:
				case Group.GroupType.AirBase:
				case Group.GroupType.NavalBase:
					this.DockPanel_GroupLeadSlowDown.Visibility = Visibility.Collapsed;
					break;
				case Group.GroupType.SurfaceGroup:
				case Group.GroupType.SubGroup:
				case Group.GroupType.MobileGroup:
					this.DockPanel_GroupLeadSlowDown.Visibility = Visibility.Visible;
					this.CB_GroupLeadSlowDown.IsChecked = new bool?(this.group.GetGroupKinematics().GetLATSD());
					break;
				default:
					this.DockPanel_GroupLeadSlowDown.Visibility = Visibility.Visible;
					this.CB_GroupLeadSlowDown.IsChecked = new bool?(this.group.GetGroupKinematics().GetLATSD());
					break;
				}
				if (this.Expander_GroupMembers.IsExpanded)
				{
					this.method_8();
				}
				if (this.group.GetGroupType() == Group.GroupType.AirGroup)
				{
					if (this.group.GetUnitsInGroup().Count > 0)
					{
						this.TextBlock_UnitClass.Text = string.Concat(new string[]
						{
							"(",
							Conversions.ToString(this.group.GetUnitsInGroup().Count),
							"x ",
							Misc.smethod_11(this.group.GetUnitsInGroup().Values.ElementAtOrDefault(0).UnitClass),
							")"
						});
					}
					this.TextBlock_Loadout.Visibility = Visibility.Visible;
					if (this.group.GetUnitsInGroup().Count > 0)
					{
						this.TextBlock_Loadout.Text = "挂载: " + Misc.smethod_11(((Aircraft)this.group.GetUnitsInGroup().Values.ElementAtOrDefault(0)).GetLoadoutName());
					}
				}
				else
				{
					this.TextBlock_UnitClass.Text = this.group.GetGroupTypeString() + " (" + Conversions.ToString(this.group.GetUnitsInGroup().Count) + "个作战单元)";
					this.TextBlock_Loadout.Visibility = Visibility.Collapsed;
				}
				if (this.group.HasAirFacilities() | this.group.HasDockFacilities())
				{
					this.Dockpanel_Ops.Visibility = Visibility.Visible;
					if (this.group.HasAirFacilities())
					{
						this.Button_AirOps.Visibility = Visibility.Visible;
						this.Button_AirOps.Content = "载机: " + Conversions.ToString(this.group.GetAirOps().method_3().Count<Aircraft>()) + "/" + Conversions.ToString(this.group.GetAirOps().GetHostedAircrafts().Count);
					}
					else
					{
						this.Button_AirOps.Visibility = Visibility.Hidden;
					}
					if (this.group.HasDockFacilities())
					{
						this.Button_DockOps.Visibility = Visibility.Visible;
						this.Button_DockOps.Content = "载艇: " + Conversions.ToString(this.group.GetDockingOps().method_2().Count<ActiveUnit>()) + "/" + Conversions.ToString(this.group.GetDockingOps().GetDockedUnits().Count);
					}
					else
					{
						this.Button_DockOps.Visibility = Visibility.Hidden;
					}
				}
				else
				{
					this.Dockpanel_Ops.Visibility = Visibility.Collapsed;
				}
				this.Label_UnitName.Content = unit_.Name;
				this.Label_UnitCourse.Content = "航向: " + Math.Round((double)unit_.GetCurrentHeading(), 0).ToString() + "度";
				if (this.group.GetGroupType() == Group.GroupType.AirGroup)
				{
					if (!Information.IsNothing(this.group.GetGroupLead()))
					{
						this.Label_UnitSpeed.Content = string.Concat(new string[]
						{
							"航速: ",
							Math.Round((double)unit_.GetCurrentSpeed(), 0).ToString(),
							"节 (马赫数：",
							Conversions.ToString(Math.Round((double)Class263.GetIRCrossSectionModifier((double)this.group.GetGroupLead().GetCurrentAltitude_ASL(false), (double)this.group.GetGroupLead().GetCurrentSpeed()), 2)),
							") (",
							Misc.GetThrottleString(this.group.GetGroupLead().GetThrottle(), this.group.GetGroupLead()),
							")"
						});
					}
				}
				else if (!Information.IsNothing(this.group.GetGroupLead()))
				{
					this.Label_UnitSpeed.Content = string.Concat(new string[]
					{
						"航速: ",
						Math.Round((double)unit_.GetCurrentSpeed(), 0).ToString(),
						" 节 (",
						Misc.GetThrottleString(this.group.GetGroupLead().GetThrottle(), this.group.GetGroupLead()),
						")"
					});
				}
				if (!Information.IsNothing(this.group.GetGroupLead()) && this.group.GetGroupLead().GetAI().IsRegroupNeeded())
				{
					this.Label_UnitSpeed.Content = this.Label_UnitSpeed.Content.ToString() + "\r\n(减速重整阵形)";
				}
				if (!Information.IsNothing(unit_.GetSide(false)))
				{
					this.Label_UnitSide.Content = unit_.GetSide(false).GetSideName();
				}
				else
				{
					this.Label_UnitSide.Content = "无";
				}
				if (unit_.GetSide(false) == side_)
				{
					this.DockPanel_SensorsWeapons.Visibility = Visibility.Visible;
				}
				else
				{
					this.DockPanel_SensorsWeapons.Visibility = Visibility.Collapsed;
				}
				if (SimConfiguration.gameOptions.UseImperialUnit())
				{
					if (unit_.GetAltitude_AGL() > 3048f)
					{
						if (this.group.GetGroupType() == Group.GroupType.AirGroup)
						{
							this.Label_UnitAlt.Content = "高度: " + Math.Round((double)(unit_.GetCurrentAltitude_ASL(false) * 3.28084f), 0).ToString() + "英尺(海高)";
						}
						else
						{
							this.Label_UnitAlt.Content = "高度: " + Math.Round((double)(unit_.GetCurrentAltitude_ASL(false) * 3.28084f), 0).ToString() + "英尺";
						}
					}
					else if (this.group.GetGroupType() == Group.GroupType.AirGroup)
					{
						if (unit_.IsOnLand())
						{
							this.Label_UnitAlt.Content = string.Concat(new string[]
							{
								"高度: ",
								Conversions.ToString(Math.Round((double)(unit_.GetCurrentAltitude_ASL(false) * 3.28084f), 0)),
								"英尺(海高)(",
								Conversions.ToString(Math.Round((double)(unit_.GetAltitude_AGL() * 3.28084f), 0)),
								"英尺(真高))"
							});
						}
						else
						{
							this.Label_UnitAlt.Content = "高度: " + Conversions.ToString(Math.Round((double)(unit_.GetCurrentAltitude_ASL(false) * 3.28084f), 0)) + "英尺(海高)";
						}
					}
					else
					{
						this.Label_UnitAlt.Content = "高度: " + Math.Round((double)(unit_.GetCurrentAltitude_ASL(false) * 3.28084f), 0).ToString() + "英尺";
					}
				}
				else if (unit_.GetAltitude_AGL() > 3048f)
				{
					if (this.group.GetGroupType() == Group.GroupType.AirGroup)
					{
						this.Label_UnitAlt.Content = "高度: " + Math.Round((double)unit_.GetCurrentAltitude_ASL(false), 0).ToString() + "米(海高)";
					}
					else
					{
						this.Label_UnitAlt.Content = "高度: " + Math.Round((double)unit_.GetCurrentAltitude_ASL(false), 0).ToString() + "米";
					}
				}
				else if (this.group.GetGroupType() == Group.GroupType.AirGroup)
				{
					if (unit_.IsOnLand())
					{
						this.Label_UnitAlt.Content = string.Concat(new string[]
						{
							"高度: ",
							Conversions.ToString(Math.Round((double)unit_.GetCurrentAltitude_ASL(false), 0)),
							"米(海高)(",
							Conversions.ToString(Math.Round((double)unit_.GetAltitude_AGL(), 0)),
							"米(真高))"
						});
					}
					else
					{
						this.Label_UnitAlt.Content = "高度: " + Conversions.ToString(Math.Round((double)unit_.GetCurrentAltitude_ASL(false), 0)) + "米(海高)";
					}
				}
				else
				{
					this.Label_UnitAlt.Content = "高度: " + Math.Round((double)unit_.GetCurrentAltitude_ASL(false), 0).ToString() + "米";
				}
				if (!Information.IsNothing(this.group.GetGroupLead()))
				{
					Group.GroupType groupType = this.group.GetGroupType();
					if (groupType != Group.GroupType.AirGroup && groupType != Group.GroupType.SubGroup)
					{
						this.DockPanel_UnitAlt.Visibility = Visibility.Collapsed;
						if (this.group.GetGroupLead().GetKinematics().GetDesiredSpeedOverride().HasValue)
						{
							this.CB_SpeedOverride.Visibility = Visibility.Visible;
							this.CB_SpeedOverride.IsChecked = new bool?(true);
							this.TB_SpeedOverride.Visibility = Visibility.Collapsed;
						}
						else
						{
							this.TB_SpeedOverride.Visibility = Visibility.Visible;
							this.CB_SpeedOverride.Visibility = Visibility.Collapsed;
						}
					}
					else
					{
						this.DockPanel_UnitAlt.Visibility = Visibility.Visible;
						if (this.group.GetGroupLead().GetKinematics().GetDesiredAltitudeOverride())
						{
							this.CB_AltitudeOverride.Visibility = Visibility.Visible;
							this.CB_AltitudeOverride.IsChecked = new bool?(true);
							this.TB_AltitudeOverride.Visibility = Visibility.Collapsed;
						}
						else
						{
							this.TB_AltitudeOverride.Visibility = Visibility.Visible;
							this.CB_AltitudeOverride.Visibility = Visibility.Collapsed;
						}
						if (this.group.GetGroupLead().GetKinematics().GetDesiredSpeedOverride().HasValue)
						{
							this.CB_SpeedOverride.Visibility = Visibility.Visible;
							this.CB_SpeedOverride.IsChecked = new bool?(true);
							this.TB_SpeedOverride.Visibility = Visibility.Collapsed;
						}
						else
						{
							this.TB_SpeedOverride.Visibility = Visibility.Visible;
							this.CB_SpeedOverride.Visibility = Visibility.Collapsed;
						}
					}
				}
				this.Dockpanel_Damage.Visibility = Visibility.Collapsed;
				if (this.group.HasFixedFacility())
				{
					if (unit_.GetSide(false) == side_)
					{
						this.Button_Magazines.Visibility = Visibility.Visible;
					}
					else
					{
						this.Button_Magazines.Visibility = Visibility.Collapsed;
					}
				}
				else
				{
					this.Button_Magazines.Visibility = Visibility.Collapsed;
				}
				this.TextBlock_UnitStatus.Text = "状态: " + Misc.GetActiveUnitStatusString(this.group.GetUnitStatus(), this.group);
				if (this.group.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.FormingUp)
				{
					int value = this.group.GetUnitsInGroup().Values.Where(UnitStatus_WPF.ActiveUnitFunc0).Count<ActiveUnit>();
					this.TextBlock_UnitStatus.Text = "组建编队: " + Conversions.ToString(value) + "/" + Conversions.ToString(this.group.GetUnitsInGroup().Count);
				}
				if (this.group.GetAssignedMission(false) != null && this.group.GetSide(false) == Client.GetClientSide())
				{
					this.DockPanel_Mission.Visibility = Visibility.Visible;
					this.Hyperlink_Mission.Tag = this.group.GetAssignedMission(false);
					string text = "";
					if (!Information.IsNothing(this.group.GetGroupLead()) && this.group.GetGroupLead().GetAI().IsEscort)
					{
						text = "(护航) ";
					}
					text = string.Concat(new string[]
					{
						text,
						this.group.GetAssignedMission(false).Name,
						" (",
						this.group.GetAssignedMission(false).GetTypeString(Client.GetClientScenario()),
						")"
					});
					this.TextBlock_MissionName.Text = text;
				}
				else
				{
					this.DockPanel_Mission.Visibility = Visibility.Collapsed;
				}
			}
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x0013E948 File Offset: 0x0013CB48
		private void ShowActiveUnitStatus(Scenario scenario_0, Side side_0, Unit unit_0)
		{
			ActiveUnit activeUnit = (ActiveUnit)unit_0;
			this.ShowUnitStatusImage((ActiveUnit)unit_0);
			this.Button_CargoOps.Visibility = Visibility.Collapsed;
			if (this.Expander_GroupMembers.Visibility != Visibility.Collapsed)
			{
				this.Expander_GroupMembers.Visibility = Visibility.Collapsed;
			}
			if (activeUnit.IsAircraft && ((Aircraft)activeUnit).IsAirRefuelingCapable())
			{
				this.Expander_TankerClients.Visibility = Visibility.Visible;
				Aircraft_AirOps aircraftAirOps = ((Aircraft)activeUnit).GetAircraftAirOps();
				this.Expander_TankerClients.Header = string.Concat(new string[]
				{
					"加油队列: ",
					Conversions.ToString(aircraftAirOps.GetRefuellingQueue().Count + aircraftAirOps.GetA2ARCDictionary().Count),
					" [授油: ",
					Conversions.ToString(aircraftAirOps.A2AR_NumberOfReceiverHookups),
					"]"
				});
				if (this.Expander_TankerClients.IsExpanded)
				{
					this.ShowTankerClientsStatus(ref activeUnit);
				}
			}
			else if (activeUnit.IsShip && ((Ship)activeUnit).CanRefuelOrUNREP(activeUnit))
			{
				this.Expander_TankerClients.Visibility = Visibility.Visible;
				ActiveUnit_DockingOps dockingOps = ((Ship)activeUnit).GetDockingOps();
				int num = 0;
				if (dockingOps.GetUNREPQueue().Count > 0 || !string.IsNullOrEmpty(dockingOps.UNREP_Starboard) || !string.IsNullOrEmpty(dockingOps.UNREP_Port) || !string.IsNullOrEmpty(dockingOps.UNREP_Astern))
				{
					if (!string.IsNullOrEmpty(dockingOps.UNREP_Starboard))
					{
						num++;
					}
					if (!string.IsNullOrEmpty(dockingOps.UNREP_Port))
					{
						num++;
					}
					if (!string.IsNullOrEmpty(dockingOps.UNREP_Astern))
					{
						num++;
					}
					foreach (string arg_1B0_0 in dockingOps.GetUNREPQueue())
					{
						num++;
					}
				}
				this.Expander_TankerClients.Header = "补给队列:" + Conversions.ToString(num);
				if (this.Expander_TankerClients.IsExpanded)
				{
					this.ShowTankerClientsStatus(ref activeUnit);
				}
			}
			else if (this.Expander_TankerClients.Visibility != Visibility.Collapsed)
			{
				this.Expander_TankerClients.Visibility = Visibility.Collapsed;
			}
			if (this.TextBlock_UnitStatus.Visibility != Visibility.Visible)
			{
				this.TextBlock_UnitStatus.Visibility = Visibility.Visible;
			}
			if (this.Button_ContactReport.Visibility != Visibility.Collapsed)
			{
				this.Button_ContactReport.Visibility = Visibility.Collapsed;
			}
			if (!unit_0.IsWeapon)
			{
				this.Button_Weapons.Visibility = Visibility.Visible;
			}
			else
			{
				this.Button_Weapons.Visibility = Visibility.Collapsed;
			}
			this.DockPanel_GroupLeadSlowDown.Visibility = Visibility.Collapsed;
			this.DockPanel_AssignedHost.Visibility = Visibility.Visible;
			this.TextBlock_UnitClass.Visibility = Visibility.Visible;
			if (activeUnit.IsWeapon)
			{
				this.Label_UnitProficiency.Visibility = Visibility.Collapsed;
			}
			else
			{
				this.Label_UnitProficiency.Visibility = Visibility.Visible;
				this.Label_UnitProficiency.Content = Misc.GetProficiencyLevelString(activeUnit.GetProficiencyLevel().Value);
			}
			this.Hyperlink_UnitClass.IsEnabled = true;
			if (unit_0.IsAircraft)
			{
				this.TextBlock_Loadout.Visibility = Visibility.Visible;
				Loadout loadout = ((Aircraft)unit_0).GetLoadout();
				Aircraft_AirOps aircraftAirOps2 = ((Aircraft)unit_0).GetAircraftAirOps();
				if (!Information.IsNothing(loadout))
				{
					if (aircraftAirOps2.QuickTurnaround_Enabled)
					{
						this.TextBlock_Loadout.Text = string.Concat(new string[]
						{
							"挂载: ",
							Misc.smethod_11(loadout.Name),
							", 支持快速出动, ",
							Conversions.ToString(aircraftAirOps2.QuickTurnaround_SortiesFlown),
							" / ",
							Conversions.ToString(aircraftAirOps2.QuickTurnaround_SortiesTotal),
							"波次"
						});
					}
					else
					{
						this.TextBlock_Loadout.Text = "挂载: " + Misc.smethod_11(loadout.Name);
					}
				}
				else
				{
					this.TextBlock_Loadout.Text = "挂载: 无";
				}
			}
			else
			{
				this.TextBlock_Loadout.Visibility = Visibility.Collapsed;
			}
			ActiveUnit assignedHostUnit;
			if (activeUnit.IsAircraft)
			{
				assignedHostUnit = ((Aircraft)activeUnit).GetAircraftAirOps().GetAssignedHostUnit(false);
			}
			else
			{
				assignedHostUnit = activeUnit.GetDockingOps().GetAssignedHostUnit(false);
			}
			if (Information.IsNothing(assignedHostUnit))
			{
				this.TextBlock_AssignedHost.Text = "配属基地:无";
			}
			else
			{
				string name;
				if (assignedHostUnit.IsFacility && assignedHostUnit.HasParentGroup())
				{
					name = assignedHostUnit.GetParentGroup(false).Name;
				}
				else
				{
					name = assignedHostUnit.Name;
				}
				this.TextBlock_AssignedHost.Text = "配属基地: " + name;
			}
			if ((!activeUnit.HasAirFacilities() && !activeUnit.HasDockFacilities() && !activeUnit.HasOnboardCargos()) || (!activeUnit.GetCommStuff().IsNotOutOfComms() && !Class2529.IsIsolatedPOVObject(activeUnit) && !Client.GetMap().IsGodsEyeView()))
			{
				this.Dockpanel_Ops.Visibility = Visibility.Collapsed;
			}
			else
			{
				this.Dockpanel_Ops.Visibility = Visibility.Visible;
				if (activeUnit.HasAirFacilities())
				{
					this.Button_AirOps.Visibility = Visibility.Visible;
					this.Button_AirOps.Content = "载机: " + Conversions.ToString(activeUnit.GetAirOps().method_3().Count<Aircraft>()) + "/" + Conversions.ToString(activeUnit.GetAirOps().GetHostedAircrafts().Count);
				}
				else
				{
					this.Button_AirOps.Visibility = Visibility.Collapsed;
				}
				if (activeUnit.HasDockFacilities())
				{
					this.Button_DockOps.Visibility = Visibility.Visible;
					this.Button_DockOps.Content = "载艇: " + Conversions.ToString(activeUnit.GetDockingOps().method_2().Count<ActiveUnit>()) + "/" + Conversions.ToString(activeUnit.GetDockingOps().GetDockedUnits().Count);
				}
				else
				{
					this.Button_DockOps.Visibility = Visibility.Collapsed;
				}
				activeUnit.HasOnboardCargos();
				this.Button_CargoOps.Visibility = Visibility.Collapsed;
			}
			if (activeUnit.IsGroupLead())
			{
				this.Label_UnitName.Content = "[领队] " + activeUnit.Name;
			}
			else
			{
				this.Label_UnitName.Content = unit_0.Name;
			}
			this.TextBlock_UnitClass.Text = Misc.smethod_11(unit_0.UnitClass);
			if (!activeUnit.GetCommStuff().IsNotOutOfComms() && !Class2529.IsIsolatedPOVObject(activeUnit) && !Client.GetMap().IsGodsEyeView())
			{
				this.Label_UnitCourse.Content = "航向: XXX";
			}
			else
			{
				this.Label_UnitCourse.Content = "航向: " + Conversions.ToString(Math.Round((double)unit_0.GetCurrentHeading(), 0)) + "度";
				if (activeUnit.GetNavigator().bool_2)
				{
					System.Windows.Controls.Label label_UnitCourse;
					(label_UnitCourse = this.Label_UnitCourse).Content = Operators.AddObject(label_UnitCourse.Content, " (规划航线..." + Conversions.ToString((int)Math.Round((double)(activeUnit.GetNavigator().float_1 * 100f))) + "%)");
				}
			}
			if (!activeUnit.GetCommStuff().IsNotOutOfComms() && !Class2529.IsIsolatedPOVObject(activeUnit) && !Client.GetMap().IsGodsEyeView())
			{
				this.Label_UnitSpeed.Content = "航速: XXX";
			}
			else if (unit_0.IsAircraft | unit_0.IsGuidedWeapon_RV_HGV())
			{
				if (unit_0.IsOfAirLaunchedGuidedWeapon())
				{
					this.Label_UnitSpeed.Content = string.Concat(new string[]
					{
						"航速:\r\nTAS ",
						Conversions.ToString((int)Math.Round((double)unit_0.GetCurrentSpeed())),
						" 节 (马赫数:",
						Conversions.ToString(Math.Round((double)Class263.GetIRCrossSectionModifier((double)unit_0.GetCurrentAltitude_ASL(false), (double)unit_0.GetCurrentSpeed()), 2)),
						")\r\nGnd ",
						Conversions.ToString((int)Math.Round((double)unit_0.GetCurrentSpeed() * Math2.Cos_D((double)unit_0.GetPitch()))),
						" 节 (",
						Misc.GetThrottleString(activeUnit.GetThrottle(), (ActiveUnit)unit_0),
						")"
					});
				}
				else
				{
					this.Label_UnitSpeed.Content = string.Concat(new string[]
					{
						"航速: ",
						Conversions.ToString((int)Math.Round((double)unit_0.GetCurrentSpeed())),
						" 节 (马赫数:",
						Conversions.ToString(Math.Round((double)Class263.GetIRCrossSectionModifier((double)unit_0.GetCurrentAltitude_ASL(false), (double)unit_0.GetCurrentSpeed()), 2)),
						") (",
						Misc.GetThrottleString(activeUnit.GetThrottle(), (ActiveUnit)unit_0),
						")"
					});
				}
			}
			else if (unit_0.IsSatellite())
			{
				this.Label_UnitSpeed.Content = "航速: " + Conversions.ToString((int)Math.Round((double)unit_0.GetCurrentSpeed())) + " 节";
			}
			else
			{
				this.Label_UnitSpeed.Content = string.Concat(new string[]
				{
					"航速: ",
					Conversions.ToString(Math.Round((double)unit_0.GetCurrentSpeed(), 0)),
					" 节(",
					Misc.GetThrottleString(activeUnit.GetThrottle(), (ActiveUnit)unit_0),
					")"
				});
			}
			if (!Information.IsNothing(unit_0.GetSide(false)))
			{
				this.Label_UnitSide.Content = "推演方: " + unit_0.GetSide(false).GetSideName();
			}
			else
			{
				this.Label_UnitSide.Content = "推演方: 无";
			}
			if (unit_0.GetSide(false) == side_0 && (activeUnit.GetCommStuff().IsNotOutOfComms() || Class2529.IsIsolatedPOVObject(activeUnit) || Client.GetMap().IsGodsEyeView()))
			{
				this.DockPanel_SensorsWeapons.Visibility = Visibility.Visible;
			}
			else
			{
				this.DockPanel_SensorsWeapons.Visibility = Visibility.Collapsed;
			}
			if (!unit_0.IsWeapon && (activeUnit.GetCommStuff().IsNotOutOfComms() || Class2529.IsIsolatedPOVObject(activeUnit) || Client.GetMap().IsGodsEyeView()))
			{
				this.Dockpanel_Damage.Visibility = Visibility.Visible;
				this.Dockpanel_FireDamage.Visibility = Visibility.Visible;
				if (unit_0.IsShip | unit_0.IsSubmarine)
				{
					this.Dockpanel_FloodDamage.Visibility = Visibility.Visible;
				}
				else
				{
					this.Dockpanel_FloodDamage.Visibility = Visibility.Collapsed;
				}
				this.Button_Damage.Visibility = Visibility.Visible;
				if (unit_0.IsShip && ((Ship)unit_0).IsDestroyed())
				{
					this.Label_UnitDamage.Text = "沉没";
				}
				else
				{
					this.Label_UnitDamage.Text = Conversions.ToString(Math.Round((double)activeUnit.GetDamage().GetDamagePts(), 1)) + "%";
				}
				if (!unit_0.IsShip && !unit_0.IsSubmarine)
				{
					this.Label_FloodDamage.Visibility = Visibility.Collapsed;
					this.PB_FloodDamage.Visibility = Visibility.Collapsed;
				}
				else
				{
					this.Label_FloodDamage.Visibility = Visibility.Visible;
					this.PB_FloodDamage.Visibility = Visibility.Visible;
					this.Label_FloodDamage.Content = "进水:";
					switch (activeUnit.GetDamage().GetFloodingIntensityLevel())
					{
					case ActiveUnit_Damage.FloodingIntensityLevel.NoFlooding:
						this.PB_FloodDamage.Value = 0.0;
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Minor:
						this.PB_FloodDamage.Value = 25.0;
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Major:
						this.PB_FloodDamage.Value = 50.0;
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Severe:
						this.PB_FloodDamage.Value = 75.0;
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Capsizing:
						this.PB_FloodDamage.Value = 100.0;
						break;
					}
				}
				this.Label_FireDamage.Visibility = Visibility.Visible;
				this.PB_FireDamage.Visibility = Visibility.Visible;
				this.Label_FireDamage.Content = "失火:";
				switch (activeUnit.GetDamage().GetFireIntensityLevel())
				{
				case ActiveUnit_Damage.FireIntensityLevel.NoFire:
					this.PB_FireDamage.Value = 0.0;
					break;
				case ActiveUnit_Damage.FireIntensityLevel.Minor:
					this.PB_FireDamage.Value = 25.0;
					break;
				case ActiveUnit_Damage.FireIntensityLevel.Major:
					this.PB_FireDamage.Value = 50.0;
					break;
				case ActiveUnit_Damage.FireIntensityLevel.Severe:
					this.PB_FireDamage.Value = 75.0;
					break;
				case ActiveUnit_Damage.FireIntensityLevel.Conflagration:
					this.PB_FireDamage.Value = 100.0;
					break;
				}
			}
			else
			{
				this.Dockpanel_Damage.Visibility = Visibility.Collapsed;
				this.Dockpanel_FireDamage.Visibility = Visibility.Collapsed;
				this.Dockpanel_FloodDamage.Visibility = Visibility.Collapsed;
			}
			GlobalVariables.ActiveUnitType unitType = ((ActiveUnit)unit_0).GetUnitType();
			if (unitType != GlobalVariables.ActiveUnitType.Ship && unitType != GlobalVariables.ActiveUnitType.Facility)
			{
				if (!activeUnit.GetCommStuff().IsNotOutOfComms() && !Class2529.IsIsolatedPOVObject(activeUnit) && !Client.GetMap().IsGodsEyeView())
				{
					this.Label_UnitAlt.Content = "高度: XXX";
				}
				else if (SimConfiguration.gameOptions.UseImperialUnit())
				{
					if (unit_0.GetCurrentAltitude_ASL(false) > 45720f)
					{
						this.Label_UnitAlt.Content = "高度: " + Conversions.ToString(Math.Round((double)(unit_0.GetCurrentAltitude_ASL(false) / 1000f), 1)) + "公里(海高)";
					}
					else if (unit_0.GetAltitude_AGL() > 3048f)
					{
						if (unit_0.IsAircraft | unit_0.IsWeapon)
						{
							this.Label_UnitAlt.Content = "高度: " + Conversions.ToString(Math.Round((double)(unit_0.GetCurrentAltitude_ASL(false) * 3.28084f), 0)) + "英尺(海高)";
						}
						else
						{
							this.Label_UnitAlt.Content = "高度: " + Conversions.ToString(Math.Round((double)(unit_0.GetCurrentAltitude_ASL(false) * 3.28084f), 0)) + " 英尺";
						}
					}
					else if (unit_0.IsAircraft | unit_0.IsWeapon)
					{
						if (unit_0.IsOnLand())
						{
							this.Label_UnitAlt.Content = string.Concat(new string[]
							{
								"高度: ",
								Conversions.ToString(Math.Round((double)(unit_0.GetCurrentAltitude_ASL(false) * 3.28084f), 0)),
								"英尺(海高)(",
								Conversions.ToString(Math.Round((double)(unit_0.GetAltitude_AGL() * 3.28084f), 0)),
								"英尺(真高))"
							});
						}
						else
						{
							this.Label_UnitAlt.Content = "高度: " + Conversions.ToString(Math.Round((double)(unit_0.GetCurrentAltitude_ASL(false) * 3.28084f), 0)) + "英尺(海高)";
						}
					}
					else
					{
						this.Label_UnitAlt.Content = "高度: " + Conversions.ToString(Math.Round((double)(unit_0.GetCurrentAltitude_ASL(false) * 3.28084f), 0)) + "英尺";
					}
				}
				else if (unit_0.GetCurrentAltitude_ASL(false) > 45720f)
				{
					this.Label_UnitAlt.Content = "高度: " + Conversions.ToString(Math.Round((double)(unit_0.GetCurrentAltitude_ASL(false) / 1000f), 1)) + "公里(海高)";
				}
				else if (unit_0.GetAltitude_AGL() > 3048f)
				{
					if (unit_0.IsAircraft | unit_0.IsWeapon)
					{
						this.Label_UnitAlt.Content = "高度: " + Conversions.ToString(Math.Round((double)unit_0.GetCurrentAltitude_ASL(false), 0)) + "米(海高)";
					}
					else
					{
						this.Label_UnitAlt.Content = "高度: " + Conversions.ToString(Math.Round((double)unit_0.GetCurrentAltitude_ASL(false), 0)) + "米";
					}
				}
				else if (unit_0.IsAircraft | unit_0.IsWeapon)
				{
					if (unit_0.IsOnLand())
					{
						this.Label_UnitAlt.Content = string.Concat(new string[]
						{
							"高度: ",
							Conversions.ToString(Math.Round((double)unit_0.GetCurrentAltitude_ASL(false), 0)),
							"米(海高) (",
							Conversions.ToString(Math.Round((double)unit_0.GetAltitude_AGL(), 0)),
							"米(真高))"
						});
					}
					else
					{
						this.Label_UnitAlt.Content = "高度: " + Conversions.ToString(Math.Round((double)unit_0.GetCurrentAltitude_ASL(false), 0)) + "米(海高)";
					}
				}
				else
				{
					this.Label_UnitAlt.Content = "高度: " + Conversions.ToString(Math.Round((double)unit_0.GetCurrentAltitude_ASL(false), 0)) + "米";
				}
				this.DockPanel_UnitAlt.Visibility = Visibility.Visible;
				if (activeUnit.GetKinematics().GetDesiredAltitudeOverride())
				{
					this.CB_AltitudeOverride.Visibility = Visibility.Visible;
					this.CB_AltitudeOverride.IsChecked = new bool?(true);
					this.TB_AltitudeOverride.Visibility = Visibility.Collapsed;
				}
				else
				{
					this.TB_AltitudeOverride.Visibility = Visibility.Visible;
					this.CB_AltitudeOverride.Visibility = Visibility.Collapsed;
				}
				if (activeUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
				{
					if (activeUnit.GetCommStuff().IsNotOutOfComms())
					{
						this.CB_SpeedOverride.Visibility = Visibility.Visible;
					}
					else
					{
						this.CB_SpeedOverride.Visibility = Visibility.Hidden;
					}
					this.CB_SpeedOverride.IsChecked = new bool?(true);
					this.TB_SpeedOverride.Visibility = Visibility.Collapsed;
				}
				else
				{
					this.TB_SpeedOverride.Visibility = Visibility.Visible;
					this.CB_SpeedOverride.Visibility = Visibility.Collapsed;
				}
			}
			else
			{
				this.DockPanel_UnitAlt.Visibility = Visibility.Collapsed;
				if (activeUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
				{
					if (activeUnit.GetCommStuff().IsNotOutOfComms())
					{
						this.CB_SpeedOverride.Visibility = Visibility.Visible;
					}
					else
					{
						this.CB_SpeedOverride.Visibility = Visibility.Hidden;
					}
					this.CB_SpeedOverride.IsChecked = new bool?(true);
					this.TB_SpeedOverride.Visibility = Visibility.Collapsed;
				}
				else
				{
					this.TB_SpeedOverride.Visibility = Visibility.Visible;
					this.CB_SpeedOverride.Visibility = Visibility.Collapsed;
				}
			}
			if (activeUnit.GetSide(false) == Client.GetClientSide())
			{
				if (activeUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
				{
					if (activeUnit.GetCommStuff().IsNotOutOfComms())
					{
						this.CB_SpeedOverride.Visibility = Visibility.Visible;
					}
					else
					{
						this.CB_SpeedOverride.Visibility = Visibility.Hidden;
					}
				}
				else
				{
					this.CB_SpeedOverride.Visibility = Visibility.Collapsed;
				}
				if (activeUnit.GetKinematics().GetDesiredAltitudeOverride())
				{
					this.CB_AltitudeOverride.Visibility = Visibility.Visible;
				}
				else
				{
					this.CB_AltitudeOverride.Visibility = Visibility.Collapsed;
				}
			}
			else
			{
				if (activeUnit.GetCommStuff().IsNotOutOfComms())
				{
					this.CB_SpeedOverride.Visibility = Visibility.Visible;
				}
				else
				{
					this.CB_SpeedOverride.Visibility = Visibility.Hidden;
				}
				this.CB_AltitudeOverride.Visibility = Visibility.Visible;
			}
			checked
			{
				if (unit_0.IsPlatform() && Client.IsVisible(unit_0))
				{
					if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit && ((Platform)unit_0).m_Magazines.Count<Magazine>() <= 0)
					{
						bool flag = false;
						if ((unit_0.IsShip || unit_0.IsFacility) && ((Platform)unit_0).m_Mounts.Length > 0)
						{
							Mount[] mounts = ((Platform)unit_0).m_Mounts;
							for (int i = 0; i < mounts.Length; i++)
							{
								if (mounts[i].GetMagazineForMount().GetWeaponRecCollection().Count > 0)
								{
									flag = true;
									break;
								}
							}
						}
						if (flag)
						{
							this.Button_Magazines.Visibility = Visibility.Visible;
						}
						else
						{
							this.Button_Magazines.Visibility = Visibility.Collapsed;
						}
					}
					else if (activeUnit.IsAircraft)
					{
						this.Button_Magazines.Visibility = Visibility.Collapsed;
					}
					else if (unit_0.GetSide(false) == side_0)
					{
						this.Button_Magazines.Visibility = Visibility.Visible;
					}
					else
					{
						this.Button_Magazines.Visibility = Visibility.Collapsed;
					}
				}
				else
				{
					this.Button_Magazines.Visibility = Visibility.Collapsed;
				}
				if (activeUnit.HaveMineCounterMeasures() && Client.IsVisible(unit_0))
				{
					this.Button_MCM.Visibility = Visibility.Visible;
				}
				else
				{
					this.Button_MCM.Visibility = Visibility.Collapsed;
				}
			}
			if (unit_0.IsShip && ((Ship)unit_0).IsDestroyed())
			{
				this.TextBlock_UnitStatus.Text = "状态: 沉没";
			}
			else if (!activeUnit.GetCommStuff().IsNotOutOfComms() && !Class2529.IsIsolatedPOVObject(activeUnit) && !Client.GetMap().IsGodsEyeView())
			{
				this.TextBlock_UnitStatus.Text = "状态: 不明 (失去通信联系)";
			}
			else if (activeUnit.IsWeapon && ((Weapon)activeUnit).GetWeaponType() == Weapon._WeaponType.Sonobuoy)
			{
				this.TextBlock_UnitStatus.Text = "剩余工作时间: " + Misc.GetTimeString((long)Math.Round((double)activeUnit.GetFuelRecs()[0].CurrentQuantity), Aircraft_AirOps._Maintenance.const_0, false, false);
			}
			else
			{
				this.TextBlock_UnitStatus.Text = "状态: " + Misc.GetActiveUnitStatusString(activeUnit.GetUnitStatus(), activeUnit);
				if ((unit_0.IsShip | unit_0.IsSubmarine) && !activeUnit.GetNavigator().HasPlottedCourse() && activeUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Unassigned && activeUnit.GetNavigator().GetFormationStation().SprintAndDrift)
				{
					ActiveUnit_Kinematics._SprintAndDriftControl sprintAndDriftControl = activeUnit.GetKinematics().SprintAndDriftControl;
					if (sprintAndDriftControl != ActiveUnit_Kinematics._SprintAndDriftControl.Sprinting)
					{
						if (sprintAndDriftControl == ActiveUnit_Kinematics._SprintAndDriftControl.Drifting)
						{
							TextBlock textBlock;
							(textBlock = this.TextBlock_UnitStatus).Text = textBlock.Text + " (低速)";
						}
					}
					else
					{
						TextBlock textBlock;
						(textBlock = this.TextBlock_UnitStatus).Text = textBlock.Text + " (高速)";
					}
				}
				if (activeUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
				{
					GlobalVariables.ActiveUnitType unitType2 = activeUnit.GetUnitType();
					if (unitType2 == GlobalVariables.ActiveUnitType.Aircraft)
					{
						if (!Information.IsNothing(((Aircraft)activeUnit).GetAircraftAirOps().GetA2ARefuelingDestinationAircraft()))
						{
							this.TextBlock_UnitStatus.Text = this.TextBlock_UnitStatus.Text + " (加油对象: " + ((Aircraft)activeUnit).GetAircraftAirOps().GetA2ARefuelingDestinationAircraft().Name + ")";
						}
						else if (activeUnit.IsNotGroupLead() && !Information.IsNothing(activeUnit.IsGroupLead()))
						{
							ActiveUnit groupLead = activeUnit.GetParentGroup(false).GetGroupLead();
							if (!Information.IsNothing(((Aircraft)groupLead).GetAircraftAirOps().GetA2ARefuelingDestinationAircraft()))
							{
								this.TextBlock_UnitStatus.Text = this.TextBlock_UnitStatus.Text + " (加油对象: " + ((Aircraft)groupLead).GetAircraftAirOps().GetA2ARefuelingDestinationAircraft().Name + ")";
							}
						}
					}
					else if (!Information.IsNothing(activeUnit.GetDockingOps().GetUNREPDestinationUnit()))
					{
						this.TextBlock_UnitStatus.Text = this.TextBlock_UnitStatus.Text + " (补给对象: " + activeUnit.GetDockingOps().GetUNREPDestinationUnit().Name + ")";
					}
				}
				if (unit_0.IsAircraft)
				{
					if (((Aircraft)unit_0).GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.RTB)
					{
						string text = " (" + ((Aircraft)unit_0).GetAircraftAirOps().GetAirOpsConditionString();
						Aircraft_AirOps._AirOpsCondition airOpsCondition = ((Aircraft)activeUnit).GetAircraftAirOps().GetAirOpsCondition();
						if (airOpsCondition == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
						{
							if (activeUnit.GetCurrentAltitude_ASL(false) > 45.72f)
							{
								text += ", 调整高度";
							}
							else
							{
								text = text + " (" + Misc.GetTimeString((long)Math.Round((double)((Aircraft)activeUnit).GetAircraftAirOps().GetConditionTimer()), Aircraft_AirOps._Maintenance.const_0, false, true) + ")";
							}
						}
						text += ")";
						this.TextBlock_UnitStatus.Text = this.TextBlock_UnitStatus.Text + text;
					}
				}
				else
				{
					if (activeUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling)
					{
						string text2 = string.Empty;
						int refuelingQuantity = activeUnit.GetDockingOps().GetUNREPDestinationUnit().GetDockingOps().GetRefuelingQuantity(activeUnit);
						int reloadQuantity = activeUnit.GetDockingOps().GetUNREPDestinationUnit().GetDockingOps().GetReloadQuantity(activeUnit);
						if (refuelingQuantity > 0)
						{
							text2 = text2 + "正在加油(还剩" + Conversions.ToString(refuelingQuantity) + "公斤)";
						}
						if (reloadQuantity > 0)
						{
							if (refuelingQuantity > 0)
							{
								text2 += " - ";
							}
							text2 = text2 + "正在补给(还剩" + Conversions.ToString(reloadQuantity) + "个货物)";
						}
						this.TextBlock_UnitStatus.Text = "Status: " + text2;
					}
					if (activeUnit.GetDockingOps().HasUNREPTargetUnit())
					{
						string text3 = "\r\n提供补给: ";
						ActiveUnit activeUnit2 = null;
						if (!string.IsNullOrEmpty(activeUnit.GetDockingOps().UNREP_Port))
						{
							activeUnit2 = Client.GetClientScenario().GetActiveUnits()[activeUnit.GetDockingOps().UNREP_Port];
						}
						if (!Information.IsNothing(activeUnit2))
						{
							text3 = text3 + "\r\n左舷: " + activeUnit2.Name;
						}
						activeUnit2 = null;
						if (!string.IsNullOrEmpty(activeUnit.GetDockingOps().UNREP_Starboard))
						{
							activeUnit2 = Client.GetClientScenario().GetActiveUnits()[activeUnit.GetDockingOps().UNREP_Starboard];
						}
						if (!Information.IsNothing(activeUnit2))
						{
							text3 = text3 + "\r\n右舷: " + activeUnit2.Name;
						}
						activeUnit2 = null;
						if (!string.IsNullOrEmpty(activeUnit.GetDockingOps().UNREP_Astern))
						{
							activeUnit2 = Client.GetClientScenario().GetActiveUnits()[activeUnit.GetDockingOps().UNREP_Astern];
						}
						if (!Information.IsNothing(activeUnit2))
						{
							text3 = text3 + "\r\n船尾: " + activeUnit2.Name;
						}
						TextBlock textBlock;
						(textBlock = this.TextBlock_UnitStatus).Text = textBlock.Text + text3;
					}
					else if (!unit_0.IsFixedFacility() || activeUnit.GetDockingOps().GetDockingOpsCondition() != ActiveUnit_DockingOps._DockingOpsCondition.Underway)
					{
						TextBlock textBlock;
						(textBlock = this.TextBlock_UnitStatus).Text = textBlock.Text + " (" + activeUnit.GetDockingOps().GetDockingOpsConditionName() + ")";
					}
				}
			}
			if (activeUnit.GetAssignedMission(false) != null && activeUnit.GetSide(false) == Client.GetClientSide())
			{
				this.DockPanel_Mission.Visibility = Visibility.Visible;
				this.Hyperlink_Mission.Tag = activeUnit.GetAssignedMission(false);
				string text4 = "";
				if (activeUnit.GetAI().IsEscort)
				{
					text4 = "(护航) ";
				}
				text4 = string.Concat(new string[]
				{
					text4,
					activeUnit.GetAssignedMission(false).Name,
					" (",
					activeUnit.GetAssignedMission(false).GetTypeString(Client.GetClientScenario()),
					")"
				});
				this.TextBlock_MissionName.Text = text4;
				if (!activeUnit.GetAssignedMission(false).IsActive())
				{
					TextBlock textBlock;
					(textBlock = this.TextBlock_MissionName).Text = textBlock.Text + " - 未启用";
				}
			}
			else
			{
				this.DockPanel_Mission.Visibility = Visibility.Collapsed;
			}
			if (activeUnit.GetCommStuff().IsNotOutOfComms())
			{
				this.Dockpanel_ComponentStatus.Visibility = Visibility.Visible;
				this.method_2(activeUnit);
			}
			else
			{
				this.Dockpanel_ComponentStatus.Visibility = Visibility.Collapsed;
			}
		}

		// Token: 0x06003D75 RID: 15733 RVA: 0x0014040C File Offset: 0x0013E60C
		public void ShowUnitStatus(Scenario scenario_0, Side side_0, Unit unit_)
		{
			if (!Information.IsNothing(unit_))
			{
				if (unit_.IsContact())
				{
					this.ShowContactStatus(scenario_0, side_0, unit_);
				}
				else if (unit_.IsGroup)
				{
					this.ShowGroupStatus(scenario_0, side_0, unit_);
				}
				else
				{
					if (!unit_.IsActiveUnit())
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new NotImplementedException();
					}
					this.ShowActiveUnitStatus(scenario_0, side_0, unit_);
				}
			}
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x0014047C File Offset: 0x0013E67C
		private void Button_Damage_Click(object sender, RoutedEventArgs e)
		{
			UnitStatus_WPF.Delegate60 @delegate = UnitStatus_WPF.delegate60_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x0002010B File Offset: 0x0001E30B
		private void Button_AirOps_Click(object sender, RoutedEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().OnAirOps();
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x0014049C File Offset: 0x0013E69C
		private void Button_Magazines_Click(object sender, RoutedEventArgs e)
		{
			UnitStatus_WPF.Delegate61 @delegate = UnitStatus_WPF.delegate61_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x001404BC File Offset: 0x0013E6BC
		private void Button_Sensors_Click(object sender, RoutedEventArgs e)
		{
			UnitStatus_WPF.Delegate63 @delegate = UnitStatus_WPF.delegate63_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x001404DC File Offset: 0x0013E6DC
		private void Button_Weapons_Click(object sender, RoutedEventArgs e)
		{
			UnitStatus_WPF.Delegate62 @delegate = UnitStatus_WPF.delegate62_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x0002011C File Offset: 0x0001E31C
		private void StackPanel1_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			base.Height = this.StackPanel1.ActualHeight;
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x001404FC File Offset: 0x0013E6FC
		private void method_8()
		{
			if (!Information.IsNothing(this.group))
			{
				this.ListView_GroupMembers.Items.Clear();
				if (this.group.GetGroupType() != Group.GroupType.AirGroup && this.group.GetGroupType() != Group.GroupType.SurfaceGroup && this.group.GetGroupType() != Group.GroupType.SubGroup)
				{
					IEnumerable<string> enumerable = this.group.GetUnitsInGroup().Values.Select(UnitStatus_WPF.ActiveUnitFunc3).OrderBy(UnitStatus_WPF.stringFunc4).Distinct<string>();
					using (IEnumerator<string> enumerator = enumerable.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							UnitStatus_WPF.Class2499 @class = new UnitStatus_WPF.Class2499(null);
							@class.string_0 = current;
							IEnumerable<ActiveUnit> source = this.group.GetUnitsInGroup().Values.Select(UnitStatus_WPF.ActiveUnitFunc5).Where(new Func<ActiveUnit, bool>(@class.method_0));
							int value = source.Count<ActiveUnit>();
							System.Windows.Forms.ListViewItem listViewItem = new System.Windows.Forms.ListViewItem();
							listViewItem.Text = Conversions.ToString(value) + "x " + @class.string_0;
							string str;
							if (source.ElementAtOrDefault(0).IsAircraft)
							{
								str = "飞机";
							}
							else if (source.ElementAtOrDefault(0).IsShip)
							{
								str = "水面舰艇";
							}
							else if (source.ElementAtOrDefault(0).IsSubmarine)
							{
								str = "潜艇";
							}
							else if (source.ElementAtOrDefault(0).IsFacility)
							{
								str = "战场设施";
							}
							else if (source.ElementAtOrDefault(0).IsSatellite())
							{
								str = "卫星";
							}
							else
							{
								if (!source.ElementAtOrDefault(0).IsSatellite())
								{
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									throw new NotImplementedException();
								}
								str = "武器";
							}
							listViewItem.Tag = str + "_" + Conversions.ToString(source.ElementAtOrDefault(0).DBID);
							this.ListView_GroupMembers.Items.Add(listViewItem);
						}
						return;
					}
				}
				IEnumerable<ActiveUnit> enumerable2 = this.group.GetUnitsInGroup().Values.Select(UnitStatus_WPF.ActiveUnitFunc1).OrderBy(UnitStatus_WPF.ActiveUnitFunc2);
				foreach (ActiveUnit current2 in enumerable2)
				{
					System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem();
					listViewItem2.Text = current2.Name + " (" + current2.UnitClass + ")";
					string str2;
					if (current2.IsAircraft)
					{
						str2 = "飞机";
					}
					else if (current2.IsShip)
					{
						str2 = "水面舰艇";
					}
					else if (current2.IsSubmarine)
					{
						str2 = "潜艇";
					}
					else if (current2.IsFacility)
					{
						str2 = "战场设施";
					}
					else if (current2.IsSatellite())
					{
						str2 = "卫星";
					}
					else
					{
						if (!current2.IsSatellite())
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw new NotImplementedException();
						}
						str2 = "武器";
					}
					listViewItem2.Tag = str2 + "_" + Conversions.ToString(current2.DBID);
					this.ListView_GroupMembers.Items.Add(listViewItem2);
				}
			}
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x0002012F File Offset: 0x0001E32F
		private void Expander_GroupMembers_Collapsed(object sender, RoutedEventArgs e)
		{
			this.Expander_GroupMembers.Header = "编组构成:";
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x00020141 File Offset: 0x0001E341
		private void Expander_GroupMembers_Expanded(object sender, RoutedEventArgs e)
		{
			this.Expander_GroupMembers.Header = "编组构成(选择查看数据库信息):";
			this.method_8();
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void Expander_TankerClients_Collapsed(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x00140890 File Offset: 0x0013EA90
		private void Expander_TankerClients_Expanded(object sender, RoutedEventArgs e)
		{
			if (!Information.IsNothing(Client.GetHookedUnit()))
			{
				ActiveUnit activeUnit = (ActiveUnit)Client.GetHookedUnit();
				this.ShowTankerClientsStatus(ref activeUnit);
			}
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x001408BC File Offset: 0x0013EABC
		private void ShowTankerClientsStatus(ref ActiveUnit activeUnit_0)
		{
			if (!Information.IsNothing(activeUnit_0))
			{
				this.ListView_TankerClients.Items.Clear();
				if (activeUnit_0.IsAircraft)
				{
					Aircraft aircraft = (Aircraft)activeUnit_0;
					foreach (KeyValuePair<string, Aircraft_AirOps._RefuellingConnection> current in aircraft.GetAircraftAirOps().GetA2ARCDictionary())
					{
						Aircraft aircraft2 = (Aircraft)activeUnit_0.m_Scenario.GetActiveUnits()[current.Key];
						System.Windows.Forms.ListViewItem listViewItem = new System.Windows.Forms.ListViewItem();
						listViewItem.Text = string.Concat(new string[]
						{
							"加油: ",
							aircraft2.Name,
							" (",
							aircraft2.UnitClass,
							")"
						});
						listViewItem.Tag = "飞机_" + Conversions.ToString(aircraft2.DBID);
						this.ListView_TankerClients.Items.Add(listViewItem);
					}
					using (IEnumerator<string> enumerator2 = aircraft.GetAircraftAirOps().GetRefuellingQueue().GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							string current2 = enumerator2.Current;
							Aircraft aircraft3 = (Aircraft)activeUnit_0.m_Scenario.GetActiveUnits()[current2];
							System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem();
							listViewItem2.Text = string.Concat(new string[]
							{
								"排队: ",
								aircraft3.Name,
								" (",
								aircraft3.UnitClass,
								")"
							});
							listViewItem2.Tag = "飞机_" + Conversions.ToString(aircraft3.DBID);
							this.ListView_TankerClients.Items.Add(listViewItem2);
						}
						return;
					}
				}
				if (activeUnit_0.IsShip)
				{
					Ship ship = (Ship)activeUnit_0;
					if (!string.IsNullOrEmpty(((Ship)activeUnit_0).GetDockingOps().UNREP_Starboard))
					{
						Ship ship2 = (Ship)activeUnit_0.m_Scenario.GetActiveUnits()[((Ship)activeUnit_0).GetDockingOps().UNREP_Starboard];
						System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem();
						listViewItem3.Text = string.Concat(new string[]
						{
							"补给, 右舷: ",
							ship2.Name,
							" (",
							ship2.UnitClass,
							")"
						});
						listViewItem3.Tag = "水面舰艇_" + Conversions.ToString(ship2.DBID);
						this.ListView_TankerClients.Items.Add(listViewItem3);
					}
					if (!string.IsNullOrEmpty(((Ship)activeUnit_0).GetDockingOps().UNREP_Port))
					{
						Ship ship3 = (Ship)activeUnit_0.m_Scenario.GetActiveUnits()[((Ship)activeUnit_0).GetDockingOps().UNREP_Port];
						System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem();
						listViewItem4.Text = string.Concat(new string[]
						{
							"补给, 左舷: ",
							ship3.Name,
							" (",
							ship3.UnitClass,
							")"
						});
						listViewItem4.Tag = "水面舰艇_" + Conversions.ToString(ship3.DBID);
						this.ListView_TankerClients.Items.Add(listViewItem4);
					}
					if (!string.IsNullOrEmpty(((Ship)activeUnit_0).GetDockingOps().UNREP_Astern))
					{
						Ship ship4 = (Ship)activeUnit_0.m_Scenario.GetActiveUnits()[((Ship)activeUnit_0).GetDockingOps().UNREP_Astern];
						System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem();
						listViewItem5.Text = string.Concat(new string[]
						{
							"补给, 船尾: ",
							ship4.Name,
							" (",
							ship4.UnitClass,
							")"
						});
						listViewItem5.Tag = "水面舰艇_" + Conversions.ToString(ship4.DBID);
						this.ListView_TankerClients.Items.Add(listViewItem5);
					}
					foreach (string current3 in ship.GetDockingOps().GetUNREPQueue())
					{
						Ship ship5 = (Ship)activeUnit_0.m_Scenario.GetActiveUnits()[current3];
						System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem();
						listViewItem6.Text = string.Concat(new string[]
						{
							"排队: ",
							ship5.Name,
							" (",
							ship5.UnitClass,
							")"
						});
						listViewItem6.Tag = "水面舰艇_" + Conversions.ToString(ship5.DBID);
						this.ListView_TankerClients.Items.Add(listViewItem6);
					}
				}
			}
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x00140E04 File Offset: 0x0013F004
		private void UnitStatus_WPF_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			UnitStatus_WPF.Delegate59 @delegate = UnitStatus_WPF.delegate59_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x00140E24 File Offset: 0x0013F024
		private void CB_AltitudeOverride_Unchecked(object sender, RoutedEventArgs e)
		{
			if (!Information.IsNothing(Client.GetHookedUnit()) && Client.GetHookedUnit().IsActiveUnit())
			{
				ActiveUnit activeUnit = (ActiveUnit)Client.GetHookedUnit();
				activeUnit.GetKinematics().SetDesiredAltitudeOverride(false);
				activeUnit.GetAI().method_18(ref activeUnit);
				this.ShowUnitStatus(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit());
			}
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x00140E88 File Offset: 0x0013F088
		private void CB_SpeedOverride_Unchecked(object sender, RoutedEventArgs e)
		{
			if (!Information.IsNothing(Client.GetHookedUnit()) && Client.GetHookedUnit().IsActiveUnit())
			{
				ActiveUnit activeUnit = (ActiveUnit)Client.GetHookedUnit();
				activeUnit.GetKinematics().SetDesiredSpeedOverride(null);
				activeUnit.GetAI().method_18(ref activeUnit);
				this.ShowUnitStatus(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit());
			}
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x00140EF4 File Offset: 0x0013F0F4
		private void Button_ContactReport_Click(object sender, RoutedEventArgs e)
		{
			if (!Information.IsNothing(Client.GetHookedUnit()) && Client.GetHookedUnit().IsContact())
			{
				CommandFactory.GetCommandMain().GetContactReport().contact = (Contact)Client.GetHookedUnit();
				CommandFactory.GetCommandMain().GetContactReport().Show();
			}
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x00020159 File Offset: 0x0001E359
		private void Button_CargoOps_Click(object sender, RoutedEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().OnCargoOps();
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x0002016A File Offset: 0x0001E36A
		private void Button_DockOps_Click(object sender, RoutedEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().OnDockOps();
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x0002017B File Offset: 0x0001E37B
		private void Button_MCM_Click(object sender, RoutedEventArgs e)
		{
			if (!Information.IsNothing(Client.GetHookedUnit()))
			{
				CommandFactory.GetCommandMain().GetMCMWindow().Show();
			}
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x00140F48 File Offset: 0x0013F148
		private void ListView_GroupMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.ListView_GroupMembers.SelectedItem)))
			{
				string text = Conversions.ToString(NewLateBinding.LateGet(this.ListView_GroupMembers.SelectedItem, null, "Tag", new object[0], null, null, null));
				string strUnitType = text.ToString().Split(new char[]
				{
					'_'
				})[0];
				int dBID = Conversions.ToInteger(text.ToString().Split(new char[]
				{
					'_'
				})[1]);
				Client.ShowDBInfo(strUnitType, dBID);
			}
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x00140FD4 File Offset: 0x0013F1D4
		private void CB_GroupLeadSlowDown_Click(object sender, RoutedEventArgs e)
		{
			if (!Information.IsNothing(Client.GetHookedUnit()) && Client.GetHookedUnit().IsGroup)
			{
				((Group)Client.GetHookedUnit()).GetGroupKinematics().method_18(this.CB_GroupLeadSlowDown.IsChecked.Value);
			}
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x00141028 File Offset: 0x0013F228
		private void Hyperlink_Mission_Click(object sender, RoutedEventArgs e)
		{
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.Hyperlink_Mission.Tag)))
			{
				Client.GetMissionEditor().method_5((Mission)this.Hyperlink_Mission.Tag);
				if (!Client.GetMissionEditor().Visible)
				{
					Client.GetMissionEditor().Show();
				}
				else
				{
					Client.GetMissionEditor().method_1();
				}
			}
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x00141088 File Offset: 0x0013F288
		private void Hyperlink_UnitClass_Click(object sender, RoutedEventArgs e)
		{
			if (!Information.IsNothing(Client.GetHookedUnit()))
			{
				ActiveUnit activeUnit_ = null;
				if (Client.GetHookedUnit().IsActiveUnit())
				{
					activeUnit_ = (ActiveUnit)Client.GetHookedUnit();
				}
				if (Client.GetHookedUnit().IsContact())
				{
					activeUnit_ = ((Contact)Client.GetHookedUnit()).ActualUnit;
				}
				if (Client.GetHookedUnit().IsGroup && ((Group)Client.GetHookedUnit()).GetGroupType() == Group.GroupType.AirGroup)
				{
					activeUnit_ = ((Group)Client.GetHookedUnit()).GetUnitsInGroup().Values.ElementAtOrDefault(0);
				}
				Client.ShowDBInfo(activeUnit_);
			}
		}

				
		// Token: 0x04001BFA RID: 7162
		public static Func<ActiveUnit, bool> ActiveUnitFunc0 = (ActiveUnit activeUnit_0) => activeUnit_0.IsOperating();

		// Token: 0x04001BFB RID: 7163
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc1 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04001BFC RID: 7164
		public static Func<ActiveUnit, string> ActiveUnitFunc2 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x04001BFD RID: 7165
		public static Func<ActiveUnit, string> ActiveUnitFunc3 = (ActiveUnit activeUnit_0) => Misc.smethod_11(activeUnit_0.UnitClass);

		// Token: 0x04001BFE RID: 7166
		public static Func<string, string> stringFunc4 = (string string_0) => string_0;

		// Token: 0x04001BFF RID: 7167
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc5 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04001C00 RID: 7168
		[CompilerGenerated]
		private static UnitStatus_WPF.Delegate59 delegate59_0;

		// Token: 0x04001C01 RID: 7169
		[CompilerGenerated]
		private static UnitStatus_WPF.Delegate60 delegate60_0;

		// Token: 0x04001C02 RID: 7170
		[CompilerGenerated]
		private static UnitStatus_WPF.Delegate61 delegate61_0;

		// Token: 0x04001C03 RID: 7171
		[CompilerGenerated]
		private static UnitStatus_WPF.Delegate62 delegate62_0;

		// Token: 0x04001C04 RID: 7172
		[CompilerGenerated]
		private static UnitStatus_WPF.Delegate63 delegate63_0;

		// Token: 0x04001C05 RID: 7173
		private Group group;

		// Token: 0x04001C06 RID: 7174
		private static Dictionary<string, BitmapImage> dictionary_0 = new Dictionary<string, BitmapImage>();

		// Token: 0x04001C07 RID: 7175
		private string string_0;

		// Token: 0x04001C08 RID: 7176
		private BitmapImage bitmapImage_0;

		// Token: 0x04001C09 RID: 7177
		private bool bool_0;

		// Token: 0x04001C0A RID: 7178
		private DBOps.DBFileCheckResult dbfileCheckResult_0;

	
		// Token: 0x02000988 RID: 2440
		// (Invoke) Token: 0x06003D97 RID: 15767
		public delegate void Delegate59();

		// Token: 0x02000989 RID: 2441
		// (Invoke) Token: 0x06003D9B RID: 15771
		public delegate void Delegate60();

		// Token: 0x0200098A RID: 2442
		// (Invoke) Token: 0x06003D9F RID: 15775
		public delegate void Delegate61();

		// Token: 0x0200098B RID: 2443
		// (Invoke) Token: 0x06003DA3 RID: 15779
		public delegate void Delegate62();

		// Token: 0x0200098C RID: 2444
		// (Invoke) Token: 0x06003DA7 RID: 15783
		public delegate void Delegate63();

		// Token: 0x0200098D RID: 2445
		[CompilerGenerated]
		public sealed class Class2499
		{
			// Token: 0x06003DAA RID: 15786 RVA: 0x000201A0 File Offset: 0x0001E3A0
			public Class2499(UnitStatus_WPF.Class2499 class2499_0)
			{
				if (class2499_0 != null)
				{
					this.string_0 = class2499_0.string_0;
				}
			}

			// Token: 0x06003DAB RID: 15787 RVA: 0x000201BA File Offset: 0x0001E3BA
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return string.CompareOrdinal(Misc.smethod_11(activeUnit_0.UnitClass), this.string_0) == 0;
			}

			// Token: 0x04001C4C RID: 7244
			public string string_0;
		}
	}
}
