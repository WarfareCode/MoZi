using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace Command_Core
{
	// 投送
	public sealed class Cargo : PlatformComponent
	{
		// Token: 0x06005ADF RID: 23263 RVA: 0x00286890 File Offset: 0x00284A90
		public Cargo._CargoType GetCurrentType()
		{
			return this.CurrentType;
		}

		// Token: 0x06005AE0 RID: 23264 RVA: 0x00028CA3 File Offset: 0x00026EA3
		private void SetCurrentType(Cargo._CargoType value)
		{
			this.CurrentType = value;
		}

		// Token: 0x06005AE1 RID: 23265 RVA: 0x002868A8 File Offset: 0x00284AA8
		public object GetCargo()
		{
			if (this.CurrentType != Cargo._CargoType.const_1)
			{
				throw new NotImplementedException();
			}
			return this.m_Mount;
		}

		// Token: 0x06005AE2 RID: 23266 RVA: 0x002868D4 File Offset: 0x00284AD4
		public string GetCargoName()
		{
			if (this.CurrentType != Cargo._CargoType.const_1)
			{
				throw new NotImplementedException();
			}
			return this.m_Mount.Name;
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x00286904 File Offset: 0x00284B04
		public override void ClearGuid()
		{
			Cargo._CargoType currentType = this.GetCurrentType();
			if (currentType != Cargo._CargoType.const_1)
			{
				if (currentType == Cargo._CargoType.const_2)
				{
					((Weapon)this.GetCargo()).ClearGuid();
				}
			}
			else
			{
				((Mount)this.GetCargo()).ClearGuid();
			}
			base.ClearGuid();
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x00286950 File Offset: 0x00284B50
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Cargo");
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
				if (this.m_ComponentStatus != PlatformComponent._ComponentStatus.Operational)
				{
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Status";
					byte componentStatus = (byte)this.m_ComponentStatus;
					xmlWriter.WriteElementString(localName, componentStatus.ToString());
				}
				if (base.GetDamageSeverity() != PlatformComponent._DamageSeverityFactor.Light)
				{
					xmlWriter_0.WriteElementString("DamageSeverity", ((byte)base.GetDamageSeverity()).ToString());
				}
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("CurrentType", ((byte)this.CurrentType).ToString());
				if (this.CurrentType != Cargo._CargoType.const_1)
				{
					throw new NotImplementedException();
				}
				this.m_Mount.Save(ref xmlWriter_0, ref hashSet_0, scenario_0);
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100658", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x00286AA4 File Offset: 0x00284CA4
		public override void BeDestroyed(Side side_0, bool bool_8, bool bool_9)
		{
			try
			{
				base.BeDestroyed(side_0, bool_8, bool_9);
				if (this.GetCargo().GetType() == typeof(Mount))
				{
					((Mount)this.GetCargo()).BeDestroyed(side_0, bool_8, true);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100678", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x00286B3C File Offset: 0x00284D3C
		public static Cargo Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ActiveUnit activeUnit_1)
		{
			Cargo cargo = null;
			Cargo result;
			try
			{
				Cargo cargo2 = new Cargo();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "Status", false) != 0)
							{
								if (Operators.CompareString(name, "CurrentType", false) != 0)
								{
									if (Operators.CompareString(name, "Name", false) != 0)
									{
										if (Operators.CompareString(name, "DamageSeverity", false) != 0)
										{
											if (Operators.CompareString(name, "Mount", false) == 0)
											{
												cargo2.m_Mount = Mount.Load(ref xmlNode, ref dictionary_0, activeUnit_1);
												cargo2.m_Mount.SetParentPlatform(null);
											}
										}
										else
										{
											cargo2.SetDamageSeverity((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode.InnerText));
										}
									}
									else
									{
										cargo2.Name = xmlNode.InnerText;
									}
								}
								else
								{
									cargo2.CurrentType = (Cargo._CargoType)Conversions.ToInteger(xmlNode.InnerText);
								}
							}
							else
							{
								string innerText = xmlNode.InnerText;
								if (Operators.CompareString(innerText, "Operational", false) != 0)
								{
									if (Operators.CompareString(innerText, "Damaged", false) != 0)
									{
										if (Operators.CompareString(innerText, "Destroyed", false) != 0)
										{
											cargo2.m_ComponentStatus = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode.InnerText);
										}
										else
										{
											cargo2.m_ComponentStatus = PlatformComponent._ComponentStatus.Destroyed;
										}
									}
									else
									{
										cargo2.m_ComponentStatus = PlatformComponent._ComponentStatus.Damaged;
									}
								}
								else
								{
									cargo2.m_ComponentStatus = PlatformComponent._ComponentStatus.Operational;
								}
							}
						}
						else if (!Information.IsNothing(dictionary_0))
						{
							if (dictionary_0.ContainsKey(xmlNode.InnerText))
							{
								cargo = (Cargo)dictionary_0[xmlNode.InnerText];
								result = cargo;
								return result;
							}
							cargo2.SetGuid(xmlNode.InnerText);
							dictionary_0.Add(cargo2.GetGuid(), cargo2);
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
				cargo = cargo2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100659", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = cargo;
			return result;
		}

		// Token: 0x06005AE7 RID: 23271 RVA: 0x00028CAC File Offset: 0x00026EAC
		private Cargo() : base(null)
		{
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x00028CB5 File Offset: 0x00026EB5
		public Cargo(ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x00028CBE File Offset: 0x00026EBE
		public Cargo(ActiveUnit activeUnit_1, Mount mount_1) : base(activeUnit_1)
		{
			this.m_Mount = mount_1;
			this.SetCurrentType(Cargo._CargoType.const_1);
		}

		// Token: 0x04002DA1 RID: 11681
		private Cargo._CargoType CurrentType;

		// Token: 0x04002DA2 RID: 11682
		private Mount m_Mount;

		// Token: 0x02000B06 RID: 2822
		public enum _CargoType
		{
			// Token: 0x04002DA4 RID: 11684
			const_0,
			// Token: 0x04002DA5 RID: 11685
			const_1,
			// Token: 0x04002DA6 RID: 11686
			const_2
		}
	}
}
