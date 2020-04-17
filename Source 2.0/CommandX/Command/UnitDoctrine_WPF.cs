using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace Command
{
	// Token: 0x0200078F RID: 1935
	[DesignerGenerated]
	public sealed partial class UnitDoctrine_WPF : System.Windows.Controls.UserControl, IComponentConnector
	{
		// Token: 0x06002FB8 RID: 12216 RVA: 0x00019CC5 File Offset: 0x00017EC5
		public UnitDoctrine_WPF()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x00107F68 File Offset: 0x00106168
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			DoctrineViewModel doctrineViewModel = (DoctrineViewModel)base.DataContext;
			if (doctrineViewModel != null && doctrineViewModel.theUnit != null)
			{
				new DoctrineForm
				{
					subject = doctrineViewModel.theUnit
				}.Show();
			}
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x00107FAC File Offset: 0x001061AC
		private void method_0()
		{
			this.list_0 = new List<SpecificDoctrineViewModel>();
			List<SpecificDoctrineViewModel> list = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction = delegate(Doctrine argument0, System.Windows.Forms.ComboBox argument1, Scenario argument2)
			{
				argument0.method_263(ref argument1, ref argument2, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction = delegate(Doctrine argument3, System.Windows.Forms.ComboBox argument4, Scenario argument5)
			{
				int num = 0;
				argument3.method_264(ref argument4, ref argument5, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc = (Doctrine argument6, Scenario argument7) => argument6.IsNukes_PlayerEditable(argument7);
			list.Add(new SpecificDoctrineViewModel("核武器", "战略", populateAction, selectionChangedAction, playerEditableFunc));
			List<SpecificDoctrineViewModel> list2 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction2 = delegate(Doctrine argument8, System.Windows.Forms.ComboBox argument9, Scenario argument10)
			{
				argument8.method_265(ref argument9, ref argument10, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction2 = delegate(Doctrine argument11, System.Windows.Forms.ComboBox argument12, Scenario argument13)
			{
				int num = 0;
				argument11.method_266(ref argument12, ref argument13, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc2 = (Doctrine argument14, Scenario argument15) => argument14.IsWCS_Air_PlayerEditable(argument15);
			list2.Add(new SpecificDoctrineViewModel("WCS, 对空", "交战规则", populateAction2, selectionChangedAction2, playerEditableFunc2));
			List<SpecificDoctrineViewModel> list3 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction3 = delegate(Doctrine argument16, System.Windows.Forms.ComboBox argument17, Scenario argument18)
			{
				argument16.method_267(ref argument17, ref argument18, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction3 = delegate(Doctrine argument19, System.Windows.Forms.ComboBox argument20, Scenario argument21)
			{
				int num = 0;
				argument19.method_268(ref argument20, ref argument21, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc3 = (Doctrine argument22, Scenario argument23) => argument22.IsWCS_Surface_PlayerEditable(argument23);
			list3.Add(new SpecificDoctrineViewModel("WCS, 对海", "交战规则", populateAction3, selectionChangedAction3, playerEditableFunc3));
			List<SpecificDoctrineViewModel> list4 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction4 = delegate(Doctrine argument24, System.Windows.Forms.ComboBox argument25, Scenario argument26)
			{
				argument24.method_269(ref argument25, ref argument26, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction4 = delegate(Doctrine argument27, System.Windows.Forms.ComboBox argument28, Scenario argument29)
			{
				int num = 0;
				argument27.method_270(ref argument28, ref argument29, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc4 = (Doctrine argument30, Scenario argument31) => argument30.IsWCS_Submarine_PlayerEditable(argument31);
			list4.Add(new SpecificDoctrineViewModel("WCS, 对潜", "交战规则", populateAction4, selectionChangedAction4, playerEditableFunc4));
			List<SpecificDoctrineViewModel> list5 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction5 = delegate(Doctrine argument32, System.Windows.Forms.ComboBox argument33, Scenario argument34)
			{
				argument32.method_271(ref argument33, ref argument34, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction5 = delegate(Doctrine argument35, System.Windows.Forms.ComboBox argument36, Scenario argument37)
			{
				int num = 0;
				argument35.method_272(ref argument36, ref argument37, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc5 = (Doctrine argument38, Scenario argument39) => argument38.IsWCSLand_PlayerEditable(argument39);
			list5.Add(new SpecificDoctrineViewModel("WCS, 对地", "交战规则", populateAction5, selectionChangedAction5, playerEditableFunc5));
			List<SpecificDoctrineViewModel> list6 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction6 = delegate(Doctrine argument40, System.Windows.Forms.ComboBox argument41, Scenario argument42)
			{
				argument40.method_273(ref argument41, ref argument42, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction6 = delegate(Doctrine argument43, System.Windows.Forms.ComboBox argument44, Scenario argument45)
			{
				int num = 0;
				argument43.method_274(ref argument44, ref argument45, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc6 = (Doctrine argument46, Scenario argument47) => argument46.IsIgnorePlottedCourseWhenAttackingPlayerEditable(argument47);
			list6.Add(new SpecificDoctrineViewModel("忽略计划航线", "交战规则", populateAction6, selectionChangedAction6, playerEditableFunc6));
			List<SpecificDoctrineViewModel> list7 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction7 = delegate(Doctrine argument48, System.Windows.Forms.ComboBox argument49, Scenario argument50)
			{
				argument48.method_281(ref argument49, ref argument50, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction7 = delegate(Doctrine argument51, System.Windows.Forms.ComboBox argument52, Scenario argument53)
			{
				int num = 0;
				argument51.method_282(ref argument52, ref argument53, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc7 = (Doctrine argument54, Scenario argument55) => argument54.IsBehaviorTowardsAmbigousTarget_PlayerEditable(argument55);
			list7.Add(new SpecificDoctrineViewModel("接战模糊位置目标", "交战规则", populateAction7, selectionChangedAction7, playerEditableFunc7));
			List<SpecificDoctrineViewModel> list8 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction8 = delegate(Doctrine argument56, System.Windows.Forms.ComboBox argument57, Scenario argument58)
			{
				argument56.method_293(ref argument57, ref argument58, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction8 = delegate(Doctrine argument59, System.Windows.Forms.ComboBox argument60, Scenario argument61)
			{
				int num = 0;
				argument59.method_294(ref argument60, ref argument61, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc8 = (Doctrine argument62, Scenario argument63) => argument62.method_159(argument63);
			list8.Add(new SpecificDoctrineViewModel("接战临机出现目标", "交战规则", populateAction8, selectionChangedAction8, playerEditableFunc8));
			List<SpecificDoctrineViewModel> list9 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction9 = delegate(Doctrine argument64, System.Windows.Forms.ComboBox argument65, Scenario argument66)
			{
				argument64.method_297(ref argument65, ref argument66, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction9 = delegate(Doctrine argument67, System.Windows.Forms.ComboBox argument68, Scenario argument69)
			{
				int num = 0;
				argument67.method_298(ref argument68, ref argument69, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc9 = (Doctrine argument70, Scenario argument71) => argument70.method_169(argument71);
			list9.Add(new SpecificDoctrineViewModel("攻击时忽略", "电磁管控", populateAction9, selectionChangedAction9, playerEditableFunc9));
			List<SpecificDoctrineViewModel> list10 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction10 = delegate(Doctrine argument72, System.Windows.Forms.ComboBox argument73, Scenario argument74)
			{
				argument72.method_307(ref argument73, ref argument74, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction10 = delegate(Doctrine argument75, System.Windows.Forms.ComboBox argument76, Scenario argument77)
			{
				int num = 0;
				argument75.method_308(ref argument76, ref argument77, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc10 = (Doctrine argument78, Scenario argument79) => argument78.method_198(argument79);
			list10.Add(new SpecificDoctrineViewModel("鱼雷射程", "杂项", populateAction10, selectionChangedAction10, playerEditableFunc10));
			List<SpecificDoctrineViewModel> list11 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction11 = delegate(Doctrine argument80, System.Windows.Forms.ComboBox argument81, Scenario argument82)
			{
				argument80.method_283(ref argument81, ref argument82, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction11 = delegate(Doctrine argument83, System.Windows.Forms.ComboBox argument84, Scenario argument85)
			{
				int num = 0;
				argument83.method_284(ref argument84, ref argument85, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc11 = (Doctrine argument86, Scenario argument87) => argument86.method_134(argument87);
			list11.Add(new SpecificDoctrineViewModel("自动规避", "杂项", populateAction11, selectionChangedAction11, playerEditableFunc11));
			List<SpecificDoctrineViewModel> list12 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction12 = delegate(Doctrine argument88, System.Windows.Forms.ComboBox argument89, Scenario argument90)
			{
				argument88.method_289(ref argument89, ref argument90, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction12 = delegate(Doctrine argument91, System.Windows.Forms.ComboBox argument92, Scenario argument93)
			{
				int selectedIndex = argument92.SelectedIndex;
				int num = 0;
				argument91.method_290(ref selectedIndex, ref argument93, ref num, false, true, false);
				argument92.SelectedIndex = selectedIndex;
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc12 = (Doctrine argument94, Scenario argument95) => argument94.method_149(argument95);
			list12.Add(new SpecificDoctrineViewModel("使用加油", "杂项", populateAction12, selectionChangedAction12, playerEditableFunc12));
			List<SpecificDoctrineViewModel> list13 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction13 = delegate(Doctrine argument96, System.Windows.Forms.ComboBox argument97, Scenario argument98)
			{
				argument96.method_319(ref argument97, ref argument98, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction13 = delegate(Doctrine argument99, System.Windows.Forms.ComboBox argument100, Scenario argument101)
			{
				int num = 0;
				argument99.method_320(ref argument100, ref argument101, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc13 = (Doctrine argument102, Scenario argument103) => argument102.RefuelAllies_PlayerEditable(argument103);
			list13.Add(new SpecificDoctrineViewModel("为盟军加油", "杂项", populateAction13, selectionChangedAction13, playerEditableFunc13));
			List<SpecificDoctrineViewModel> list14 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction14 = delegate(Doctrine argument104, System.Windows.Forms.ComboBox argument105, Scenario argument106)
			{
				bool flag = true;
				argument104.method_301(ref argument105, ref argument106, ref flag, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction14 = delegate(Doctrine argument107, System.Windows.Forms.ComboBox argument108, Scenario argument109)
			{
				int num = -1;
				bool flag = false;
				argument107.method_302(ref argument108, ref argument109, ref num, ref flag, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc14 = (Doctrine argument110, Scenario argument111) => argument110.method_183(argument111);
			list14.Add(new SpecificDoctrineViewModel("空战节奏", "空中作战行动", populateAction14, selectionChangedAction14, playerEditableFunc14));
			List<SpecificDoctrineViewModel> list15 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction15 = delegate(Doctrine argument112, System.Windows.Forms.ComboBox argument113, Scenario argument114)
			{
				bool flag = true;
				argument112.method_299(ref argument113, ref argument114, ref flag, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction15 = delegate(Doctrine argument115, System.Windows.Forms.ComboBox argument116, Scenario argument117)
			{
				int num = -1;
				bool flag = false;
				argument115.method_300(ref argument116, ref argument117, ref num, ref flag, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc15 = (Doctrine argument118, Scenario argument119) => argument118.method_178(argument119);
			list15.Add(new SpecificDoctrineViewModel("快速出动", "空中作战行动", populateAction15, selectionChangedAction15, playerEditableFunc15));
			List<SpecificDoctrineViewModel> list16 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction16 = delegate(Doctrine argument120, System.Windows.Forms.ComboBox argument121, Scenario argument122)
			{
				bool flag = true;
				argument120.method_303(ref argument121, ref argument122, ref flag, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction16 = delegate(Doctrine argument123, System.Windows.Forms.ComboBox argument124, Scenario argument125)
			{
				int num = -1;
				bool flag = false;
				bool flag2 = false;
				argument123.method_304(ref argument124, ref argument125, ref num, ref flag, ref flag2, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc16 = (Doctrine argument126, Scenario argument127) => argument126.method_188(argument127);
			list16.Add(new SpecificDoctrineViewModel("燃油状态", "空中作战行动", populateAction16, selectionChangedAction16, playerEditableFunc16));
			List<SpecificDoctrineViewModel> list17 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction17 = delegate(Doctrine argument128, System.Windows.Forms.ComboBox argument129, Scenario argument130)
			{
				argument128.method_277(ref argument129, ref argument130, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction17 = delegate(Doctrine argument131, System.Windows.Forms.ComboBox argument132, Scenario argument133)
			{
				int num = 0;
				argument131.method_278(ref argument132, ref argument133, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc17 = (Doctrine argument134, Scenario argument135) => argument134.method_124(argument135);
			list17.Add(new SpecificDoctrineViewModel("返航燃油状态", "空中作战行动", populateAction17, selectionChangedAction17, playerEditableFunc17));
			List<SpecificDoctrineViewModel> list18 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction18 = delegate(Doctrine argument136, System.Windows.Forms.ComboBox argument137, Scenario argument138)
			{
				bool flag = true;
				argument136.method_305(ref argument137, ref argument138, ref flag, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction18 = delegate(Doctrine argument139, System.Windows.Forms.ComboBox argument140, Scenario argument141)
			{
				int num = -1;
				bool flag = false;
				argument139.method_306(ref argument140, ref argument141, ref num, ref flag, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc18 = (Doctrine argument142, Scenario argument143) => argument142.method_193(argument143);
			list18.Add(new SpecificDoctrineViewModel("武器状态", "空中作战行动", populateAction18, selectionChangedAction18, playerEditableFunc18));
			List<SpecificDoctrineViewModel> list19 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction19 = delegate(Doctrine argument144, System.Windows.Forms.ComboBox argument145, Scenario argument146)
			{
				argument144.method_275(ref argument145, ref argument146, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction19 = delegate(Doctrine argument147, System.Windows.Forms.ComboBox argument148, Scenario argument149)
			{
				int num = 0;
				argument147.method_276(ref argument148, ref argument149, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc19 = (Doctrine argument150, Scenario argument151) => argument150.method_119(argument151);
			list19.Add(new SpecificDoctrineViewModel("返航武器状态", "空中作战行动", populateAction19, selectionChangedAction19, playerEditableFunc19));
			List<SpecificDoctrineViewModel> list20 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction20 = delegate(Doctrine argument152, System.Windows.Forms.ComboBox argument153, Scenario argument154)
			{
				argument152.method_287(ref argument153, ref argument154, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction20 = delegate(Doctrine argument155, System.Windows.Forms.ComboBox argument156, Scenario argument157)
			{
				int num = 0;
				argument155.method_288(ref argument156, ref argument157, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc20 = (Doctrine argument158, Scenario argument159) => argument158.method_144(argument159);
			list20.Add(new SpecificDoctrineViewModel("空对地扫射(航炮)", "空中作战行动", populateAction20, selectionChangedAction20, playerEditableFunc20));
			List<SpecificDoctrineViewModel> list21 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction21 = delegate(Doctrine argument160, System.Windows.Forms.ComboBox argument161, Scenario argument162)
			{
				argument160.method_279(ref argument161, ref argument162, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction21 = delegate(Doctrine argument163, System.Windows.Forms.ComboBox argument164, Scenario argument165)
			{
				int num = 0;
				argument163.method_280(ref argument164, ref argument165, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc21 = (Doctrine argument166, Scenario argument167) => argument166.method_129(argument167);
			list21.Add(new SpecificDoctrineViewModel("抛弃弹药", "空中作战行动", populateAction21, selectionChangedAction21, playerEditableFunc21));
			List<SpecificDoctrineViewModel> list22 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction22 = delegate(Doctrine argument168, System.Windows.Forms.ComboBox argument169, Scenario argument170)
			{
				argument168.method_295(ref argument169, ref argument170, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction22 = delegate(Doctrine argument171, System.Windows.Forms.ComboBox argument172, Scenario argument173)
			{
				int num = 0;
				argument171.method_296(ref argument172, ref argument173, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc22 = (Doctrine argument174, Scenario argument175) => argument174.method_164(argument175);
			list22.Add(new SpecificDoctrineViewModel("反舰舰空导弹", "反舰作战行动", populateAction22, selectionChangedAction22, playerEditableFunc22));
			List<SpecificDoctrineViewModel> list23 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction23 = delegate(Doctrine argument176, System.Windows.Forms.ComboBox argument177, Scenario argument178)
			{
				argument176.method_285(ref argument177, ref argument178, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction23 = delegate(Doctrine argument179, System.Windows.Forms.ComboBox argument180, Scenario argument181)
			{
				int num = 0;
				argument179.method_286(ref argument180, ref argument181, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc23 = (Doctrine argument182, Scenario argument183) => argument182.method_139(argument183);
			list23.Add(new SpecificDoctrineViewModel("保持距离", "反舰作战行动", populateAction23, selectionChangedAction23, playerEditableFunc23));
			List<SpecificDoctrineViewModel> list24 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction24 = delegate(Doctrine argument184, System.Windows.Forms.ComboBox argument185, Scenario argument186)
			{
				argument184.method_321(ref argument185, ref argument186, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction24 = delegate(Doctrine argument187, System.Windows.Forms.ComboBox argument188, Scenario argument189)
			{
				int num = 0;
				argument187.method_322(ref argument188, ref argument189, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc24 = (Doctrine argument190, Scenario argument191) => argument190.AvoidContact_PlayerEditable(argument191);
			list24.Add(new SpecificDoctrineViewModel("避免探测", "反潜作战行动", populateAction24, selectionChangedAction24, playerEditableFunc24));
			List<SpecificDoctrineViewModel> list25 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction25 = delegate(Doctrine argument192, System.Windows.Forms.ComboBox argument193, Scenario argument194)
			{
				argument192.method_323(ref argument193, ref argument194, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction25 = delegate(Doctrine argument195, System.Windows.Forms.ComboBox argument196, Scenario argument197)
			{
				int num = 0;
				argument195.method_324(ref argument196, ref argument197, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc25 = (Doctrine argument198, Scenario argument199) => argument198.DiveWhenThreatsDetected_PlayerEditable(argument199);
			list25.Add(new SpecificDoctrineViewModel("遭遇威胁下潜", "反潜作战行动", populateAction25, selectionChangedAction25, playerEditableFunc25));
			List<SpecificDoctrineViewModel> list26 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction26 = delegate(Doctrine argument200, System.Windows.Forms.ComboBox argument201, Scenario argument202)
			{
				argument200.method_325(ref argument201, ref argument202, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction26 = delegate(Doctrine argument203, System.Windows.Forms.ComboBox argument204, Scenario argument205)
			{
				int num = 0;
				argument203.method_326(ref argument204, ref argument205, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc26 = (Doctrine argument206, Scenario argument207) => argument206.RechargePercentagePatrol_PlayerEditable(argument207);
			list26.Add(new SpecificDoctrineViewModel("充电, 巡逻", "反潜作战行动", populateAction26, selectionChangedAction26, playerEditableFunc26));
			List<SpecificDoctrineViewModel> list27 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction27 = delegate(Doctrine argument208, System.Windows.Forms.ComboBox argument209, Scenario argument210)
			{
				argument208.method_327(ref argument209, ref argument210, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction27 = delegate(Doctrine argument211, System.Windows.Forms.ComboBox argument212, Scenario argument213)
			{
				int num = 0;
				argument211.method_328(ref argument212, ref argument213, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc27 = (Doctrine argument214, Scenario argument215) => argument214.RechargePercentageAttack_PlayerEditable(argument215);
			list27.Add(new SpecificDoctrineViewModel("充电, 攻击", "反潜作战行动", populateAction27, selectionChangedAction27, playerEditableFunc27));
			List<SpecificDoctrineViewModel> list28 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction28 = delegate(Doctrine argument216, System.Windows.Forms.ComboBox argument217, Scenario argument218)
			{
				argument216.method_329(ref argument217, ref argument218, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction28 = delegate(Doctrine argument219, System.Windows.Forms.ComboBox argument220, Scenario argument221)
			{
				int num = 0;
				argument219.method_330(ref argument220, ref argument221, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc28 = (Doctrine argument222, Scenario argument223) => argument222.AIPUsage_PlayerEditable(argument223);
			list28.Add(new SpecificDoctrineViewModel("使用AIP", "反潜作战行动", populateAction28, selectionChangedAction28, playerEditableFunc28));
			List<SpecificDoctrineViewModel> list29 = this.list_0;
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> populateAction29 = delegate(Doctrine argument224, System.Windows.Forms.ComboBox argument225, Scenario argument226)
			{
				argument224.method_331(ref argument225, ref argument226, null);
			};
			Action<Doctrine, System.Windows.Forms.ComboBox, Scenario> selectionChangedAction29 = delegate(Doctrine argument227, System.Windows.Forms.ComboBox argument228, Scenario argument229)
			{
				int num = 0;
				argument227.method_332(ref argument228, ref argument229, ref num, false, true);
			};
			Func<Doctrine, Scenario, bool> playerEditableFunc29 = (Doctrine argument230, Scenario argument231) => argument230.DippingSonar_PlayerEditable(argument231);
			list29.Add(new SpecificDoctrineViewModel("吊放声纳", "反潜作战行动", populateAction29, selectionChangedAction29, playerEditableFunc29));
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x00108E5C File Offset: 0x0010705C
		public void method_1(ActiveUnit activeUnit)
		{
			if (this.list_0 == null)
			{
				this.method_0();
			}
			if (base.DataContext == null)
			{
				base.DataContext = new DoctrineViewModel(activeUnit, this.list_0);
			}
			else
			{
				DoctrineViewModel doctrineViewModel = (DoctrineViewModel)base.DataContext;
				if (doctrineViewModel.theUnit == activeUnit)
				{
					doctrineViewModel.Refresh();
				}
				else
				{
					base.DataContext = new DoctrineViewModel(activeUnit, this.list_0);
				}
			}
		}

		
		
		// Token: 0x04001616 RID: 5654
		public List<SpecificDoctrineViewModel> list_0;

		// Token: 0x04001617 RID: 5655
		private bool bool_0;


	}
}
