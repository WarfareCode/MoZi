using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns3;
using ns32;
using ns33;
using ns35;
using ns4;

namespace Command
{
	// Token: 0x02000948 RID: 2376
	[Attribute0, Attribute2, Attribute3]
	public sealed class EditCargoViewModel : INotifyPropertyChanged
	{
		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06003A3F RID: 14911 RVA: 0x00122B7C File Offset: 0x00120D7C
		// (remove) Token: 0x06003A40 RID: 14912 RVA: 0x00122BB8 File Offset: 0x00120DB8
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

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06003A41 RID: 14913 RVA: 0x00122BF4 File Offset: 0x00120DF4
		// (set) Token: 0x06003A42 RID: 14914 RVA: 0x0001EE6D File Offset: 0x0001D06D
		public ActiveUnit ActiveUnit
		{
			[CompilerGenerated]
			get
			{
				return this.activeUnit_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.activeUnit_0 != value)
				{
					this.activeUnit_0 = value;
					this.vmethod_0("ActiveUnit");
				}
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06003A43 RID: 14915 RVA: 0x00122C0C File Offset: 0x00120E0C
		// (set) Token: 0x06003A44 RID: 14916 RVA: 0x0001EE8F File Offset: 0x0001D08F
		public ObservableCollection<EditCargoCargoItemViewModel> Inventory
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_0 != value)
				{
					this.observableCollection_0 = value;
					this.vmethod_0("Inventory");
				}
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06003A45 RID: 14917 RVA: 0x00122C24 File Offset: 0x00120E24
		// (set) Token: 0x06003A46 RID: 14918 RVA: 0x0001EEB1 File Offset: 0x0001D0B1
		public DataTable AllMounts
		{
			[CompilerGenerated]
			get
			{
				return this.dataTable_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTable_0 != value)
				{
					this.dataTable_0 = value;
					this.vmethod_0("AllMounts");
				}
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06003A47 RID: 14919 RVA: 0x00122C3C File Offset: 0x00120E3C
		// (set) Token: 0x06003A48 RID: 14920 RVA: 0x0001EED3 File Offset: 0x0001D0D3
		public DataRowView SelectedMountToAdd
		{
			[CompilerGenerated]
			get
			{
				return this.dataRowView_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataRowView_0 != value)
				{
					this.dataRowView_0 = value;
					this.vmethod_0("SelectedMountToAdd");
				}
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06003A49 RID: 14921 RVA: 0x00122C54 File Offset: 0x00120E54
		// (set) Token: 0x06003A4A RID: 14922 RVA: 0x0001EEF5 File Offset: 0x0001D0F5
		public int Quantity
		{
			[CompilerGenerated]
			get
			{
				return this.int_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_0 != value)
				{
					this.int_0 = value;
					this.vmethod_0("Quantity");
				}
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06003A4B RID: 14923 RVA: 0x00122C6C File Offset: 0x00120E6C
		// (set) Token: 0x06003A4C RID: 14924 RVA: 0x0001EF17 File Offset: 0x0001D117
		public EditCargoCargoItemViewModel SelectedCargoToRemove
		{
			[CompilerGenerated]
			get
			{
				return this.editCargoCargoItemViewModel_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.editCargoCargoItemViewModel_0 != value)
				{
					this.editCargoCargoItemViewModel_0 = value;
					this.vmethod_0("SelectedCargoToRemove");
				}
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06003A4D RID: 14925 RVA: 0x00122C84 File Offset: 0x00120E84
		// (set) Token: 0x06003A4E RID: 14926 RVA: 0x0001EF39 File Offset: 0x0001D139
		public EditCargo Form
		{
			[CompilerGenerated]
			get
			{
				return this.editCargo_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.editCargo_0 != value)
				{
					this.editCargo_0 = value;
					this.vmethod_0("Form");
				}
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06003A4F RID: 14927 RVA: 0x00122C9C File Offset: 0x00120E9C
		// (set) Token: 0x06003A50 RID: 14928 RVA: 0x0001EF5B File Offset: 0x0001D15B
		public Class2535 AddCargoCommand
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
					this.vmethod_0("AddCargoCommand");
				}
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06003A51 RID: 14929 RVA: 0x00122CB4 File Offset: 0x00120EB4
		// (set) Token: 0x06003A52 RID: 14930 RVA: 0x0001EF7D File Offset: 0x0001D17D
		public Class2535 RemoveCargoCommand
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
					this.vmethod_0("RemoveCargoCommand");
				}
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06003A53 RID: 14931 RVA: 0x00122CCC File Offset: 0x00120ECC
		// (set) Token: 0x06003A54 RID: 14932 RVA: 0x0001EF9F File Offset: 0x0001D19F
		public Class2535 OKCommand
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
					this.vmethod_0("OKCommand");
				}
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06003A55 RID: 14933 RVA: 0x00122CE4 File Offset: 0x00120EE4
		// (set) Token: 0x06003A56 RID: 14934 RVA: 0x0001EFC1 File Offset: 0x0001D1C1
		public Class2535 CancelCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2535_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2535_3 != value)
				{
					this.class2535_3 = value;
					this.vmethod_0("CancelCommand");
				}
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06003A57 RID: 14935 RVA: 0x00122CFC File Offset: 0x00120EFC
		// (set) Token: 0x06003A58 RID: 14936 RVA: 0x0001EFE3 File Offset: 0x0001D1E3
		public string LastError
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
					this.vmethod_0("LastError");
				}
			}
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x00122D14 File Offset: 0x00120F14
		public void method_0()
		{
			EditCargoViewModel.Class2490 @class = new EditCargoViewModel.Class2490();
			if (this.SelectedMountToAdd != null)
			{
				@class.int_0 = Conversions.ToInteger(this.SelectedMountToAdd["ID"]);
				EditCargoCargoItemViewModel editCargoCargoItemViewModel = this.Inventory.Where(new Func<EditCargoCargoItemViewModel, bool>(@class.method_0)).FirstOrDefault<EditCargoCargoItemViewModel>();
				int mountDBID = @class.int_0;
				Scenario clientScenario = Client.GetClientScenario();
				Mount mount = DBFunctions.LoadMountData(mountDBID, ref clientScenario, true);
				ICargo cargo = (ICargo)this.ActiveUnit;
				if (mount.Cargo_Type > cargo.GetCargoType())
				{
					this.LastError = "Unable to add cargo to platform, due to cargo type limitations.";
				}
				else
				{
					if (editCargoCargoItemViewModel == null)
					{
						editCargoCargoItemViewModel = new EditCargoCargoItemViewModel
						{
							Cargo = new Cargo(this.ActiveUnit, DBFunctions.LoadMountData(@class.int_0, ref this.ActiveUnit.m_Scenario, true)),
							Quantity = 0
						};
						this.Inventory.Add(editCargoCargoItemViewModel);
					}
					EditCargoCargoItemViewModel editCargoCargoItemViewModel2;
					(editCargoCargoItemViewModel2 = editCargoCargoItemViewModel).Quantity = editCargoCargoItemViewModel2.Quantity + this.Quantity;
				}
			}
		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x00122E1C File Offset: 0x0012101C
		public void method_1()
		{
			if (this.SelectedCargoToRemove != null)
			{
				EditCargoCargoItemViewModel selectedCargoToRemove;
				(selectedCargoToRemove = this.SelectedCargoToRemove).Quantity = selectedCargoToRemove.Quantity - this.Quantity;
				if (this.SelectedCargoToRemove.Quantity <= 0)
				{
					this.Inventory.Remove(this.SelectedCargoToRemove);
				}
			}
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x00122E70 File Offset: 0x00121070
		public void method_2()
		{
			Cargo[] onboardCargos = this.ActiveUnit.m_OnboardCargos;
			Cargo[] array = new Cargo[0];
			using (IEnumerator<EditCargoCargoItemViewModel> enumerator = this.Inventory.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					EditCargoViewModel.Class2491 @class = new EditCargoViewModel.Class2491(null);
					@class.editCargoCargoItemViewModel_0 = enumerator.Current;
					IEnumerator<Cargo> enumerator2 = this.ActiveUnit.m_OnboardCargos.Where(EditCargoViewModel.CargoFunc0).Where(new Func<Cargo, bool>(@class.method_0)).Select(EditCargoViewModel.CargoFunc1).GetEnumerator();
					for (int i = @class.editCargoCargoItemViewModel_0.Quantity; i > 0; i--)
					{
						if (enumerator2.MoveNext())
						{
							ScenarioArrayUtil.AddCargo(ref array, enumerator2.Current);
						}
						else
						{
							ScenarioArrayUtil.AddCargo(ref array, new Cargo(this.ActiveUnit, DBFunctions.LoadMountData(((Mount)@class.editCargoCargoItemViewModel_0.Cargo.GetCargo()).DBID, ref this.ActiveUnit.m_Scenario, true)));
						}
					}
				}
			}
			ICargo cargo = (ICargo)this.ActiveUnit;
			float num = cargo.GetCargoMass();
			float num2 = cargo.GetCargoArea();
			float num3 = cargo.GetCargoCrew();
			Cargo[] array2 = array;
			for (int j = 0; j < array2.Length; j = checked(j + 1))
			{
				Cargo cargo2 = array2[j];
				if (cargo2.GetCurrentType() == Cargo._CargoType.const_1)
				{
					Mount mount = (Mount)cargo2.GetCargo();
					num -= (float)mount.Cargo_Mass;
					num2 -= (float)mount.Cargo_Area;
					num3 -= (float)mount.Cargo_Crew;
				}
				else if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			if (num < 0f | num2 < 0f | num3 < 0f)
			{
				this.LastError = "The cargo limits on this unit have been exceeded.";
			}
			else
			{
				ScenarioArrayUtil.NewCargoArray(ref onboardCargos);
				this.ActiveUnit.m_OnboardCargos = array;
				CommandFactory.GetCommandMain().GetMainForm().method_3().method_3(Client.GetHookedUnit(), Client.GetHookedUnit());
				this.Form.Close();
			}
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x0001F009 File Offset: 0x0001D209
		public void method_3()
		{
			this.Form.Close();
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x00123094 File Offset: 0x00121294
		private object AddCargo(object value)
		{
			DataTrigger dataTrigger = new DataTrigger();
			dataTrigger.Binding = new Binding("Cargo_Type");
			dataTrigger.Value = RuntimeHelpers.GetObjectValue(value);
			Setter setter = new Setter();
			dataTrigger.Setters.Add(setter);
			setter.Property = Control.BackgroundProperty;
			setter.Value = Brushes.Red;
			return dataTrigger;
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x001230F0 File Offset: 0x001212F0
		public EditCargoViewModel(EditCargo EditCargo_, ActiveUnit selectedHost)
		{
			this.Inventory = new ObservableCollection<EditCargoCargoItemViewModel>();
			this.AddCargoCommand = new Class2535(new Action<object>(this.method_4));
			this.RemoveCargoCommand = new Class2535(new Action<object>(this.method_5));
			this.OKCommand = new Class2535(new Action<object>(this.method_6));
			this.CancelCommand = new Class2535(new Action<object>(this.method_7));
			this.Form = EditCargo_;
			this.Quantity = 1;
			this.ActiveUnit = selectedHost;
			ICargo cargo = (ICargo)this.ActiveUnit;
			Style style = new Style();
			string text = "Not Cargo Capable";
			string text2 = "Personnel (Squads, MANPADS, ATGM)";
			string text3 = "Small Cargo (Cars, AAA Guns)";
			string text4 = "Medium Cargo (APC, Towed Arty)";
			string text5 = "Large Cargo (Tank, TEL, Trailer)";
			string text6 = "Very Large Cargo (IRBM / ICBM TEL)";
			if (cargo.GetCargoType() < _CargoType.VeryLargeCargo)
			{
				style.Triggers.Add((TriggerBase)this.AddCargo(text6));
			}
			if (cargo.GetCargoType() < _CargoType.LargeCargo)
			{
				style.Triggers.Add((TriggerBase)this.AddCargo(text5));
			}
			if (cargo.GetCargoType() < _CargoType.MediumCargo)
			{
				style.Triggers.Add((TriggerBase)this.AddCargo(text4));
			}
			if (cargo.GetCargoType() < _CargoType.SmallCargo)
			{
				style.Triggers.Add((TriggerBase)this.AddCargo(text3));
			}
			if (cargo.GetCargoType() < _CargoType.Personnel)
			{
				style.Triggers.Add((TriggerBase)this.AddCargo(text2));
			}
			if (cargo.GetCargoType() < _CargoType.NoCargo)
			{
				style.Triggers.Add((TriggerBase)this.AddCargo(text));
			}
			EditCargo_.editCargoControl_0.MyDataGrid.RowStyle = style;
			EditCargo_.Text = "Edit Cargo for " + selectedHost.Name;
			SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
			DataTable dataTable = DBFunctions.smethod_66(ref sQLiteConnection);
			this.AllMounts = dataTable.Clone();
			this.AllMounts.Columns["Cargo_Type"].DataType = typeof(string);
			foreach (object current in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(current);
				this.AllMounts.ImportRow((DataRow)objectValue);
			}
			foreach (object current in this.AllMounts.Rows)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(current);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(objectValue2, new object[]
				{
					"Cargo_Type"
				}, null), "0", false))
				{
					NewLateBinding.LateIndexSet(objectValue2, new object[]
					{
						"Cargo_Type",
						text
					}, null);
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(objectValue2, new object[]
				{
					"Cargo_Type"
				}, null), "1000", false))
				{
					NewLateBinding.LateIndexSet(objectValue2, new object[]
					{
						"Cargo_Type",
						text2
					}, null);
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(objectValue2, new object[]
				{
					"Cargo_Type"
				}, null), "2000", false))
				{
					NewLateBinding.LateIndexSet(objectValue2, new object[]
					{
						"Cargo_Type",
						text3
					}, null);
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(objectValue2, new object[]
				{
					"Cargo_Type"
				}, null), "3000", false))
				{
					NewLateBinding.LateIndexSet(objectValue2, new object[]
					{
						"Cargo_Type",
						text4
					}, null);
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(objectValue2, new object[]
				{
					"Cargo_Type"
				}, null), "4000", false))
				{
					NewLateBinding.LateIndexSet(objectValue2, new object[]
					{
						"Cargo_Type",
						text5
					}, null);
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(objectValue2, new object[]
				{
					"Cargo_Type"
				}, null), "5000", false))
				{
					NewLateBinding.LateIndexSet(objectValue2, new object[]
					{
						"Cargo_Type",
						text6
					}, null);
				}
			}
			Cargo[] onboardCargos = this.ActiveUnit.m_OnboardCargos;
			Func<Cargo, bool> predicate = (Cargo C) => C.GetCurrentType() == Cargo._CargoType.const_1;
			IEnumerable<Cargo> source = ((IEnumerable<Cargo>)onboardCargos).Where(predicate);
			Func<Cargo, int> keySelector = (Cargo C) => ((Mount)C.GetCargo()).DBID;
			foreach (var current2 in source.GroupBy(keySelector, (int DBID, IEnumerable<Cargo> argument0) => new
			{
				DBID = DBID,
				Count = argument0.Count<Cargo>()
			}))
			{
				EditCargoCargoItemViewModel item = new EditCargoCargoItemViewModel
				{
					Cargo = new Cargo(this.ActiveUnit, DBFunctions.LoadMountData(current2.DBID, ref this.ActiveUnit.m_Scenario, true)),
					Quantity = current2.Count
				};
				this.Inventory.Add(item);
			}
			if (((ICargo)this.ActiveUnit).GetCargoType() == _CargoType.NoCargo)
			{
				this.LastError = "This unit is unable to host cargo.";
			}
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x0001F016 File Offset: 0x0001D216
		[CompilerGenerated]
		private void method_4(object a0)
		{
			this.method_0();
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x0001F01E File Offset: 0x0001D21E
		[CompilerGenerated]
		private void method_5(object a0)
		{
			this.method_1();
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x0001F026 File Offset: 0x0001D226
		[CompilerGenerated]
		private void method_6(object a0)
		{
			this.method_2();
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x0001F02E File Offset: 0x0001D22E
		[CompilerGenerated]
		private void method_7(object a0)
		{
			this.method_3();
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x00123710 File Offset: 0x00121910
		public  void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04001A9D RID: 6813
		public static Func<Cargo, bool> CargoFunc0 = (Cargo C) => C.GetCurrentType() == Cargo._CargoType.const_1;

		// Token: 0x04001A9E RID: 6814
		public static Func<Cargo, Cargo> CargoFunc1 = (Cargo C) => C;

		// Token: 0x04001A9F RID: 6815
		public static Func<Cargo, bool> CargoFunc2 = (Cargo C) => C.GetCurrentType() == Cargo._CargoType.const_1;

		// Token: 0x04001AA0 RID: 6816
		public static Func<Cargo, int> CargoFunc3 = (Cargo C) => ((Mount)C.GetCargo()).DBID;

		// Token: 0x04001AA1 RID: 6817
		[CompilerGenerated]
		private ActiveUnit activeUnit_0;

		// Token: 0x04001AA2 RID: 6818
		[CompilerGenerated]
		private ObservableCollection<EditCargoCargoItemViewModel> observableCollection_0;

		// Token: 0x04001AA3 RID: 6819
		[CompilerGenerated]
		private DataTable dataTable_0;

		// Token: 0x04001AA4 RID: 6820
		[CompilerGenerated]
		private DataRowView dataRowView_0;

		// Token: 0x04001AA5 RID: 6821
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04001AA6 RID: 6822
		[CompilerGenerated]
		private EditCargoCargoItemViewModel editCargoCargoItemViewModel_0;

		// Token: 0x04001AA7 RID: 6823
		[CompilerGenerated]
		private EditCargo editCargo_0;

		// Token: 0x04001AA8 RID: 6824
		[CompilerGenerated]
		private Class2535 class2535_0;

		// Token: 0x04001AA9 RID: 6825
		[CompilerGenerated]
		private Class2535 class2535_1;

		// Token: 0x04001AAA RID: 6826
		[CompilerGenerated]
		private Class2535 class2535_2;

		// Token: 0x04001AAB RID: 6827
		[CompilerGenerated]
		private Class2535 class2535_3;

		// Token: 0x04001AAC RID: 6828
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04001AAD RID: 6829
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x02000949 RID: 2377
		[CompilerGenerated]
		public sealed class Class2490
		{
			// Token: 0x06003A6C RID: 14956 RVA: 0x0001F036 File Offset: 0x0001D236
			internal bool method_0(EditCargoCargoItemViewModel a)
			{
				return a.Cargo.GetCurrentType() == Cargo._CargoType.const_1 & ((Mount)a.Cargo.GetCargo()).DBID == this.int_0;
			}

			// Token: 0x04001AB5 RID: 6837
			public int int_0;
		}

		// Token: 0x0200094A RID: 2378
		[CompilerGenerated]
		public sealed class Class2491
		{
			// Token: 0x06003A6E RID: 14958 RVA: 0x0001F064 File Offset: 0x0001D264
			public Class2491(EditCargoViewModel.Class2491 arg0)
			{
				if (arg0 != null)
				{
					this.editCargoCargoItemViewModel_0 = arg0.editCargoCargoItemViewModel_0;
				}
			}

			// Token: 0x06003A6F RID: 14959 RVA: 0x0001F07E File Offset: 0x0001D27E
			internal bool method_0(Cargo C)
			{
				return ((Mount)C.GetCargo()).DBID == ((Mount)this.editCargoCargoItemViewModel_0.Cargo.GetCargo()).DBID;
			}

			// Token: 0x04001AB6 RID: 6838
			public EditCargoCargoItemViewModel editCargoCargoItemViewModel_0;
		}
	}
}
