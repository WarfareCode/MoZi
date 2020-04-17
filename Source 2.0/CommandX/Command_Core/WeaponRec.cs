using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace Command_Core
{
	// Token: 0x02000B94 RID: 2964
	public sealed class WeaponRec : Subject
	{
		// Token: 0x060061AA RID: 25002 RVA: 0x002F447C File Offset: 0x002F267C
		[CompilerGenerated]
		public static void smethod_0(WeaponRec.Delegate24 delegate24_1)
		{
			WeaponRec.Delegate24 @delegate = WeaponRec.delegate24_0;
			WeaponRec.Delegate24 delegate2;
			do
			{
				delegate2 = @delegate;
				WeaponRec.Delegate24 value = (WeaponRec.Delegate24)Delegate.Combine(delegate2, delegate24_1);
				@delegate = Interlocked.CompareExchange<WeaponRec.Delegate24>(ref WeaponRec.delegate24_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060061AB RID: 25003 RVA: 0x002F44B4 File Offset: 0x002F26B4
		[CompilerGenerated]
		public static void smethod_1(WeaponRec.Delegate24 delegate24_1)
		{
			WeaponRec.Delegate24 @delegate = WeaponRec.delegate24_0;
			WeaponRec.Delegate24 delegate2;
			do
			{
				delegate2 = @delegate;
				WeaponRec.Delegate24 value = (WeaponRec.Delegate24)Delegate.Remove(delegate2, delegate24_1);
				@delegate = Interlocked.CompareExchange<WeaponRec.Delegate24>(ref WeaponRec.delegate24_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060061AC RID: 25004 RVA: 0x0002B2B8 File Offset: 0x000294B8
		public override void ClearGuid()
		{
			base.ClearGuid();
			if (!Information.IsNothing(this.weapon))
			{
				this.weapon.ClearGuid();
			}
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x002F44EC File Offset: 0x002F26EC
		public void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("WRec");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				if (!Information.IsNothing(hashSet_0))
				{
					if (hashSet_0.Contains(base.GetGuid()))
					{
						xmlWriter_0.WriteEndElement();
						return;
					}
					hashSet_0.Add(base.GetGuid());
				}
				xmlWriter_0.WriteElementString("DL", this.DefaultLoad.ToString());
				xmlWriter_0.WriteElementString("CL", this.CurrentLoad.ToString());
				xmlWriter_0.WriteElementString("ML", this.MaxLoad.ToString());
				xmlWriter_0.WriteElementString("ROF", this.ROF.ToString());
				if (this.OW)
				{
					xmlWriter_0.WriteElementString("OW", this.OW.ToString());
				}
				if (this.IW)
				{
					xmlWriter_0.WriteElementString("IW", this.IW.ToString());
				}
				xmlWriter_0.WriteElementString("Mult", this.Multiple.ToString());
				xmlWriter_0.WriteElementString("WeapID", this.WeapID.ToString());
				if (this.TimeToFire != 0f)
				{
					xmlWriter_0.WriteElementString("TTF", XmlConvert.ToString(this.TimeToFire));
				}
				if (this.RecID.HasValue)
				{
					xmlWriter_0.WriteElementString("RecID", this.RecID.Value.ToString());
				}
				if (!Information.IsNothing(this.GetWeapon(scenario_0)) && this.GetWeapon(scenario_0).IsTank())
				{
					xmlWriter_0.WriteElementString("FuelTank", XmlConvert.ToString(this.GetWeapon(scenario_0).GetFuelRecs()[0].CurrentQuantity));
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101075", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060061AE RID: 25006 RVA: 0x002F471C File Offset: 0x002F291C
		public static WeaponRec smethod_2(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			WeaponRec result = null;
			try
			{
				WeaponRec weaponRec = new WeaponRec();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num > 1776879945u)
						{
							if (num <= 2195334682u)
							{
								if (num <= 1978145240u)
								{
									if (num != 1902341061u)
									{
										if (num == 1978145240u && Operators.CompareString(name, "ROF", false) == 0)
										{
											weaponRec.ROF = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else if (Operators.CompareString(name, "WeapID", false) != 0)
									{
										continue;
									}
								}
								else if (num != 2045027659u)
								{
									if (num == 2195334682u && Operators.CompareString(name, "CL", false) == 0)
									{
										weaponRec.CurrentLoad = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "OW", false) == 0)
									{
										weaponRec.OW = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 2333728401u)
							{
								if (num != 2305894001u)
								{
									if (num == 2333728401u && Operators.CompareString(name, "TimeToFire", false) == 0)
									{
										weaponRec.TimeToFire = XmlConvert.ToSingle(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "FuelTank", false) == 0)
									{
										weaponRec.GetWeapon(scenario_0).GetFuelRecs()[0].CurrentQuantity = XmlConvert.ToSingle(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 3140810977u)
							{
								if (num != 3611682378u)
								{
									if (num == 3767140958u && Operators.CompareString(name, "DefaultLoad", false) == 0)
									{
										weaponRec.DefaultLoad = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "WeaponDBID", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Multiple", false) == 0)
								{
									weaponRec.Multiple = Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							weaponRec.WeapID = Conversions.ToInteger(xmlNode.InnerText);
						}
						else if (num > 1037013698u)
						{
							if (num <= 1154386829u)
							{
								if (num != 1054853948u)
								{
									if (num == 1154386829u && Operators.CompareString(name, "DL", false) == 0)
									{
										weaponRec.DefaultLoad = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "ML", false) != 0)
								{
									continue;
								}
							}
							else if (num != 1298133685u)
							{
								if (num != 1458105184u)
								{
									if (num == 1776879945u && Operators.CompareString(name, "IW", false) == 0)
									{
										weaponRec.IW = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "ID", false) == 0)
									{
										weaponRec.SetGuid(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (Operators.CompareString(name, "MaxLoad", false) != 0)
							{
								continue;
							}
							weaponRec.MaxLoad = Conversions.ToInteger(xmlNode.InnerText);
						}
						else if (num <= 547133647u)
						{
							if (num != 126317010u)
							{
								if (num == 547133647u && Operators.CompareString(name, "Mult", false) == 0)
								{
									weaponRec.Multiple = Conversions.ToInteger(xmlNode.InnerText);
								}
							}
							else if (Operators.CompareString(name, "CurrentLoad", false) != 0)
							{
							}
						}
						else if (num != 963109897u)
						{
							if (num == 1037013698u && Operators.CompareString(name, "RecDBID", false) == 0)
							{
								weaponRec.RecID = new int?(Conversions.ToInteger(xmlNode.InnerText));
							}
						}
						else if (Operators.CompareString(name, "TTF", false) == 0)
						{
							weaponRec.TimeToFire = XmlConvert.ToSingle(xmlNode.InnerText);
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
				result = weaponRec;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101076", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new WeaponRec();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060061AF RID: 25007 RVA: 0x0002B2D8 File Offset: 0x000294D8
		private WeaponRec()
		{
			this.OW = false;
			this.IW = false;
		}

		// Token: 0x060061B0 RID: 25008 RVA: 0x002F4C30 File Offset: 0x002F2E30
		public int GetCurrentLoad()
		{
			return this.CurrentLoad;
		}

		// Token: 0x060061B1 RID: 25009 RVA: 0x002F4C48 File Offset: 0x002F2E48
		public void SetCurrentLoad(int NewLoad)
		{
			bool flag = NewLoad != this.CurrentLoad;
			this.CurrentLoad = NewLoad;
			if (flag)
			{
				WeaponRec.Delegate24 @delegate = WeaponRec.delegate24_0;
				if (@delegate != null)
				{
					@delegate(this);
				}
			}
		}

		// Token: 0x060061B2 RID: 25010 RVA: 0x0002B2FC File Offset: 0x000294FC
		public bool HasReloadPriorityOnMount(Mount mount_)
		{
			return mount_.RPrioritySet.Contains(this.WeapID);
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x002F4C84 File Offset: 0x002F2E84
		public Weapon GetWeapon(Scenario scenario_)
		{
			if (Information.IsNothing(this.weapon))
			{
				if (this.method_17(scenario_))
				{
					this.weapon = scenario_.GetWeapon(this.WeapID);
				}
				else
				{
					this.weapon = Weapon.GetWeapon(ref scenario_, this.WeapID, null);
				}
			}
			return this.weapon;
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x0002B30F File Offset: 0x0002950F
		public void Clear()
		{
			this.weapon = null;
		}

		// Token: 0x060061B5 RID: 25013 RVA: 0x002F4CE0 File Offset: 0x002F2EE0
		public bool method_17(Scenario scenario_0)
		{
			int weapID = this.WeapID;
			bool flag = false;
			SQLiteConnection sQLiteConnection = scenario_0.GetSQLiteConnection();
			Weapon._WeaponType weaponType = DBFunctions.GetWeaponType(weapID, ref sQLiteConnection);
			bool result;
			if (weaponType <= Weapon._WeaponType.DepthCharge)
			{
				if (weaponType - Weapon._WeaponType.Rocket <= 2 || weaponType == Weapon._WeaponType.DepthCharge)
				{
					result = true;
					return result;
				}
			}
			else if (weaponType == Weapon._WeaponType.Laser || weaponType - Weapon._WeaponType.Troops <= 1)
			{
				result = true;
				return result;
			}
			result = flag;
			return result;
		}

		// Token: 0x060061B6 RID: 25014 RVA: 0x0002B318 File Offset: 0x00029518
		public void SetTimeToFire()
		{
			if (this.ROF < 0)
			{
				this.TimeToFire = 30f * -(float)this.ROF;
			}
			else
			{
				this.TimeToFire = (float)this.ROF;
			}
		}

		// Token: 0x060061B7 RID: 25015 RVA: 0x002F4D58 File Offset: 0x002F2F58
		public float GetROF()
		{
			return (float)this.ROF;
		}

		// Token: 0x060061B8 RID: 25016 RVA: 0x002F4D70 File Offset: 0x002F2F70
		public WeaponRec(ref Scenario scenario_0, int int_6, int int_7, int int_8, int int_9, int int_10, bool bool_10, bool bool_11)
		{
			this.OW = false;
			this.IW = false;
			this.DefaultLoad = int_7;
			this.CurrentLoad = this.DefaultLoad;
			this.MaxLoad = int_8;
			this.ROF = int_9;
			this.Multiple = int_10;
			this.TimeToFire = 0f;
			this.WeapID = int_6;
			this.OW = bool_10;
			this.IW = bool_11;
			this.GetWeapon(scenario_0);
		}

		// Token: 0x04003510 RID: 13584
		public int? RecID;

		// Token: 0x04003511 RID: 13585
		public int DefaultLoad;

		// Token: 0x04003512 RID: 13586
		private int CurrentLoad;

		// Token: 0x04003513 RID: 13587
		public int MaxLoad = 0;

		// Token: 0x04003514 RID: 13588
		private int ROF = 0;

		// Token: 0x04003515 RID: 13589
		public int Multiple;

		// Token: 0x04003516 RID: 13590
		private Weapon weapon;

		// Token: 0x04003517 RID: 13591
		public bool OW;

		// Token: 0x04003518 RID: 13592
		public bool IW;

		// Token: 0x04003519 RID: 13593
		public int WeapID;

		// Token: 0x0400351A RID: 13594
		public float TimeToFire;

		// Token: 0x0400351B RID: 13595
		public Mount myMount;

		// Token: 0x0400351C RID: 13596
		[CompilerGenerated]
		private static WeaponRec.Delegate24 delegate24_0;

		// Token: 0x02000B95 RID: 2965
		// (Invoke) Token: 0x060061BA RID: 25018
		public delegate void Delegate24(WeaponRec theWR);
	}
}
