using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Command
{
	// Token: 0x02000CF0 RID: 3312
	public sealed partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06006D12 RID: 27922 RVA: 0x0002EA83 File Offset: 0x0002CC83
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06006D13 RID: 27923 RVA: 0x003D2D70 File Offset: 0x003D0F70
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.menuStrip_0 = new System.Windows.Forms.MenuStrip();
            this.MenuItem_FileControl = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_StartUpWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_NewScenario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_LoadScenario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SaveScenario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MapSeting = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Tranlation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UpMove = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_RightMove = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_LeftMove = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DownMove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_22 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_ChooseNextUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ChoosePrevUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_21 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_DirectionRangeMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_19 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_MessageOutputWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_30 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_LonLatGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_BMNG = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ColorTopographic = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ShowBorders = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_OnlineGeographyData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_CustomLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_PlacenameLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DayNightLight = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SimulationControl = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_StartOrRecover = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SimIncreaseCompression = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SimDecreaseCompression = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_RealTimeSim = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_16 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_OrderOfBattle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_135 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_BrowseScenarioPlatforms = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ScenarioDescription = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MissileBriefReport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SideDoctrineAndEMCONAndWRA = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MenuItem_SpecialAction = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SatellitePassPredictions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_TSMI_Recorder = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MessageOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ClearMessageLog = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_PrintToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_LossesAndExpenditures = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Score = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_17 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SituationControl = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SwitchToUnitView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ShowGroupMember = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_GM_SelectedGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_GM_AllGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_GM_NotShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_15 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_ToAirDetectRange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ToSurfaceDetectRange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ToUnderWaterDetectRange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ToAirAttackRange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ToSurfaceAttackRange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ToLandAttackRange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ToUnderwaterAttackRange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ShowRange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SR_SelectedUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SR_AllUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SR_NotShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_ShowNonfriendlyRange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MergeShowRange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_10 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_SonobuoyVisbility = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SV_Common = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SV_Virtual = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SV_NotShow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ReferencePointVisibility = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_RPV_Common = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_RPV_Small = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_RPV_NotShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_25 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_LlluminationVectors = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_LV_SelectedUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_LV_AllUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_LV_NotShow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_TargetingVectors = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_TV_SelectedUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_TV_AllUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_TV_NotShow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UnitPropVisibility = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UPV_SelectedUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UPV_AllUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UPV_NotShow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DataLink = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DL_SelectedUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DL_AllUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DL_NotShow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ContactEmissions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_CE_SelectedTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_CE_AllTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_CE_NotShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_32 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_CE_AllEmissions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_CE_OnlyFCR = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_CE_SelectedShowAllRestOnlyFCR = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_PlottedCourses = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AU_AddUnit54 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_PC_AllUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_PC_NotShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_361 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_362 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_363 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_364 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MissionAreaOrCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MAOC_SelectedMission = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MAOC_AllMission = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MAOC_NotShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_18 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_TrackSelectedUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_QuickJump = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UnitOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AttackOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_AutoEngageTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_ManualEngageTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_LaunchOnlyBearing = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_DropTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_DropAllTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_IgnorePlottedCourse_SelectedUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_IPCSU_Yes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_IPCSU_No = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_IPCSU_SameAsSuperior = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_IgnorePlottedCourse_AllUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_IPCAU_Yes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_IPCAU_No = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_IPCAU_SameAsSuperior = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_WeaponContorlStatusForAllType_SelectUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_WCSFATSU_ForbidFire = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_WCSFATSU_LimitFire = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_WCSFATSU_FreeFire = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_WCSFATSU_SameAsSuperior = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_WeaponContorlStatusForAllType_AllUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_WCSFATAU_ForbidFire = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_WCSFATAU_LimitFire = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_WCSFATAU_FreeFire = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AO_WCSFATAU_SameAsSuperior = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AntiSubmarineWar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ASW_DropPassiveSonobuoy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ASW_DPS_Shallow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ASW_DPS_Deep = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DropActiveSonobuoy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ASW_DAS_Shallow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ASW_DAS_Deep = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DeployDippingSonar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ThrottleAltOrDeep = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_PlotCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Magazines = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AirOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_BoatDockingOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_WeaponStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SensorsStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SystemDamageStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ReturnToBase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SelectNewBase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AirRefuel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AR_AutoSelectAerialTanker = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AR_ManualSelectAerialTanker = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AR_SelectForMission = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_HoldPositon_SelectedUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_HoldPositon_AllUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_QuickTumaround = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_20 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_GroupOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_GO_GroupBySelectedUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_GO_SelectedUnitRemoveGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_GO_GroupEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_33 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_UnassignMissionUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AssignMissionToUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Doctrine_RoE_EMCON_WRA = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ContactTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DropTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_23 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_MarkHostile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MarkUnfriendly = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MarkNeutral = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MarkFriendly = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_24 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_FilteroutAllTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_CancelFilteroutAllContacts = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MissionAndReferencePoint = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MissionEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_NewMission = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_11 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_AddReferencePoint = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DeleteSelectedRefPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_RenameSelectedRefName = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DeselectAllRefPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DefineArea = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_12 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_RelativeSelectedRefPoint_FixedBearing = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_RelativeSelectedRefPoint_RotatingBearing = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SelectedRefPointChangeBearingToFixed = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SelectedRefPointChangeBearingToRotating = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SelectedRefPointRemoveRelativity = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_13 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_LockSelectedRefPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UnlockSelectedRefPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_26 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_NoNavigationZones = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_NNZ_EditExisting = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_NNZ_CreateBySelectedRefPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ExclusionZones = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_EZ_EditExisting = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_EZ_CreateBySelectedRefPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ScenarioEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ScenarioTime = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ScenarioDescribe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_6 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_DataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DB_ChangeDB = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DB_CDB_Waiting = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DB_SecnarioDataUpdateToLatestVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DB_SecnarioDataBandingToCustomDB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_0 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Battle = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Battle_New = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Battle_LoadForFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_31 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_NewOrEditRole = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SwitchToRole = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_EditMissionBriefReport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_EditScoreRules = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DirectorView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_TorpedoArea = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_TA_DesignatedAreaMine = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_TA_DesignatedAreaMineClearance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_9 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Weather = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SimulationRealismSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_EventEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_EE_Event = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_EE_Trigger = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_EE_Condition = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_EE_Action = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_EE_SpecialEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SpecialAction = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SA_CreateTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SA_CreateDeltaTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SA_UseSpecialEventScript = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_UnitOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UO_AddUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UO_AddSatellite = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UO_EditWarplane = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UO_EditBerthedBoats = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UO_EditCargo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UO_CopyUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UO_CloneUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UO_MoveUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UO_RenameUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UO_DeleteUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UO_SetOilAndHangTime = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UO_UnitAutoDetected = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UO_SettingBearing = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UO_HoldPositon = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_IsolatedUnitView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_DeleteOurSideAllUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ScenarioAttachment = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_PublishScenarioToSimulationServer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ScenarioPackingPublish = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UnitImportAndExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UIAE_SelectedUnitOrGroupSaveAsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UIAE_LoadUnitOrGroupForFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ScenarioMigration = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SM_ExportToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SM_ImportForFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SM_TransformToXML = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ScriptEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ReturnTo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MonteCarloSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_HotKey = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Tutorials = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_29 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_TestScript = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_19 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AU_AddUnit0 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AU_AddUnit1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AU_AddUnit2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AU_AddUnit3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_32 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_35 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_63 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AU_AddUnit4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_61 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_62 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_0 = new System.Windows.Forms.ToolStrip();
            this.Label_GameRunSpeed = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_0 = new System.Windows.Forms.ToolStripComboBox();
            this.Label_GameRunMode = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator_14 = new System.Windows.Forms.ToolStripSeparator();
            this.Button_StartOrRecover = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_7 = new System.Windows.Forms.ToolStripSeparator();
            this.Button_CustomLayer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_8 = new System.Windows.Forms.ToolStripSeparator();
            this.Button_VideoRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_36 = new System.Windows.Forms.ToolStripSeparator();
            this.Button_GameSpeed = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip_0 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_AU_AddUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AU_AddRefPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AU_DefineArea = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog_0 = new System.Windows.Forms.SaveFileDialog();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel_0 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_0 = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip_1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Unit_AttackOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_OA_AutoEngageTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_OA_ManualEngageTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_OA_LaunchOnlyBearing = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_DropTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_DropAllTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_IgnorePlottedCourse_SelectedUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_IPCSU_Yes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_IPCSU_No = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_IPCSU_SameAsSuperior = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_IgnorePlottedCourse_AllUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_IPCAU_Yes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_IPCAU_No = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_IPCAU_SameAsSuperior = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_WeaponContorlStatusForAllType_SelectUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_WCSFATSU_ForbidFire = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_WCSFATSU_LimitFire = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_WCSFATSU_FreeFire = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_WCSFATSU_SameAsSuperior = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_WeaponContorlStatusForAllType_AllUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_WCSFATAU_ForbidFire = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_WCSFATAU_LimitFire = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_WCSFATAU_FreeFire = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AO_WCSFATAU_SameAsSuperior = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AntiSubmarineWar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_ASW_DropPassiveSonobuoy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_ASW_DPS_Shallow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_ASW_DPS_Deep = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_DropActiveSonobuoy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_ASW_DAS_Shallow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_ASW_DAS_Deep = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_DeployDippingSonar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_ThrottleAltOrDeep = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_PlotCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_Magazines = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AirOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_BoatDockingOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_WeaponStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SensorsStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SystemDamageStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_ReturnToBase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SelectNewBase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AirRefuel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AR_AutoSelectAerialTanker = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AR_ManualSelectAerialTanker = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AR_SelectForMission = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_HoldPositon_SelectedUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_HoldPositon_AllUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_IsolationView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_QuickTumaround = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Unit_GroupOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_GO_GroupBySelectedUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_GO_SelectedUnitRemoveGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_GO_GroupEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Unit_UnassignMissionUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_AssignMissionToUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_Doctrine_RoE_EMCON = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_28 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Unit_DirectionRangeMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_27 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Unit_ScenarioEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_EditUnitProp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_EUP_Magazine = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_EUP_AmmunitionReserve = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_EUP_Airplane = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_SetUnitTrainingLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_SUTL_NewPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_SUTL_Trainee = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_SUTL_Common = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_SUTL_OldStager = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_SUTL_TopLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_SUTL_SameAsCamp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_AutoDetectedUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_UnitLoseCommunication = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_SetBearing = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_SE_CopyUnitID = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Unit_DischargeCargo = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker_0 = new System.ComponentModel.BackgroundWorker();
            this.timer_2 = new System.Windows.Forms.Timer(this.components);
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.timer_3 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog_0 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip_2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_ScenarioDescribe1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ScenarioDescribe0 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog_2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_2 = new System.Windows.Forms.OpenFileDialog();
            this.button_0 = new System.Windows.Forms.Button();
            this.checkBox_0 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip_3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_156 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_157 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_158 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_352 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_34 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_348 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_349 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_350 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_351 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_35 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_353 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_311 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_4 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog_3 = new System.Windows.Forms.OpenFileDialog();
            this.timer_5 = new System.Windows.Forms.Timer(this.components);
            this.timer_6 = new System.Windows.Forms.Timer(this.components);
            this.timer_7 = new System.Windows.Forms.Timer(this.components);
            this.label_0 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.WorldMapBox = new System.Windows.Forms.PictureBox();
            this.panel_0 = new System.Windows.Forms.Panel();
            this.elementHost_0 = new System.Windows.Forms.Integration.ElementHost();
            this.启动UDP服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_0.SuspendLayout();
            this.toolStrip_0.SuspendLayout();
            this.contextMenuStrip_0.SuspendLayout();
            this.statusStrip_0.SuspendLayout();
            this.contextMenuStrip_1.SuspendLayout();
            this.contextMenuStrip_2.SuspendLayout();
            this.contextMenuStrip_3.SuspendLayout();
            this.contextMenuStrip_4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorldMapBox)).BeginInit();
            this.panel_0.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_0
            // 
            this.menuStrip_0.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.menuStrip_0.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_FileControl,
            this.MenuItem_MapSeting,
            this.MenuItem_SimulationControl,
            this.MenuItem_SituationControl,
            this.MenuItem_QuickJump,
            this.MenuItem_UnitOrder,
            this.MenuItem_ContactTarget,
            this.MenuItem_MissionAndReferencePoint,
            this.MenuItem_ScenarioEditor,
            this.toolStripMenuItem_1,
            this.MenuItem_TestScript,
            this.toolStripMenuItem_61});
            this.menuStrip_0.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_0.Name = "menuStrip_0";
            this.menuStrip_0.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip_0.TabIndex = 4;
            this.menuStrip_0.Text = "MenuStrip1";
            // 
            // MenuItem_FileControl
            // 
            this.MenuItem_FileControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_StartUpWindow,
            this.MenuItem_NewScenario,
            this.MenuItem_LoadScenario,
            this.MenuItem_SaveScenario,
            this.MenuItem_SaveAs,
            this.MenuItem_Exit});
            this.MenuItem_FileControl.Name = "MenuItem_FileControl";
            this.MenuItem_FileControl.Size = new System.Drawing.Size(67, 20);
            this.MenuItem_FileControl.Text = "文件控制";
            this.MenuItem_FileControl.Click += new System.EventHandler(this.SetSaveAsEnable);
            // 
            // MenuItem_StartUpWindow
            // 
            this.MenuItem_StartUpWindow.Name = "MenuItem_StartUpWindow";
            this.MenuItem_StartUpWindow.Size = new System.Drawing.Size(157, 22);
            this.MenuItem_StartUpWindow.Text = "启动界面";
            this.MenuItem_StartUpWindow.Click += new System.EventHandler(this.method_177);
            // 
            // MenuItem_NewScenario
            // 
            this.MenuItem_NewScenario.Name = "MenuItem_NewScenario";
            this.MenuItem_NewScenario.Size = new System.Drawing.Size(157, 22);
            this.MenuItem_NewScenario.Text = "新建想定";
            this.MenuItem_NewScenario.Click += new System.EventHandler(this.Click_NewScenario);
            // 
            // MenuItem_LoadScenario
            // 
            this.MenuItem_LoadScenario.Name = "MenuItem_LoadScenario";
            this.MenuItem_LoadScenario.Size = new System.Drawing.Size(157, 22);
            this.MenuItem_LoadScenario.Text = "加载想定";
            this.MenuItem_LoadScenario.Click += new System.EventHandler(this.Click_LoadScenario);
            // 
            // MenuItem_SaveScenario
            // 
            this.MenuItem_SaveScenario.Name = "MenuItem_SaveScenario";
            this.MenuItem_SaveScenario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItem_SaveScenario.Size = new System.Drawing.Size(157, 22);
            this.MenuItem_SaveScenario.Text = "保存推演";
            this.MenuItem_SaveScenario.Click += new System.EventHandler(this.Click_SaveScenario);
            // 
            // MenuItem_SaveAs
            // 
            this.MenuItem_SaveAs.Name = "MenuItem_SaveAs";
            this.MenuItem_SaveAs.Size = new System.Drawing.Size(157, 22);
            this.MenuItem_SaveAs.Text = "另存为...";
            this.MenuItem_SaveAs.Click += new System.EventHandler(this.Click_SaveAs);
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.Size = new System.Drawing.Size(157, 22);
            this.MenuItem_Exit.Text = "退出";
            this.MenuItem_Exit.Click += new System.EventHandler(this.Click_Exit);
            // 
            // MenuItem_MapSeting
            // 
            this.MenuItem_MapSeting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_ZoomIn,
            this.MenuItem_ZoomOut,
            this.MenuItem_Tranlation,
            this.toolStripSeparator_22,
            this.MenuItem_ChooseNextUnit,
            this.MenuItem_ChoosePrevUnit,
            this.toolStripSeparator_21,
            this.MenuItem_DirectionRangeMeasure,
            this.toolStripSeparator_19,
            this.MenuItem_MessageOutputWindow,
            this.toolStripSeparator_30,
            this.MenuItem_LonLatGrid,
            this.MenuItem_BMNG,
            this.MenuItem_ColorTopographic,
            this.MenuItem_ShowBorders,
            this.MenuItem_OnlineGeographyData,
            this.MenuItem_CustomLayer,
            this.MenuItem_PlacenameLayer,
            this.MenuItem_DayNightLight});
            this.MenuItem_MapSeting.Name = "MenuItem_MapSeting";
            this.MenuItem_MapSeting.Size = new System.Drawing.Size(67, 20);
            this.MenuItem_MapSeting.Text = "显示设置";
            this.MenuItem_MapSeting.DropDownOpening += new System.EventHandler(this.Click_MapSeting);
            // 
            // MenuItem_ZoomIn
            // 
            this.MenuItem_ZoomIn.Name = "MenuItem_ZoomIn";
            this.MenuItem_ZoomIn.ShortcutKeyDisplayString = "Z /鼠标滚轮";
            this.MenuItem_ZoomIn.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_ZoomIn.Text = "放大";
            this.MenuItem_ZoomIn.Click += new System.EventHandler(this.Click_ZoomIn);
            // 
            // MenuItem_ZoomOut
            // 
            this.MenuItem_ZoomOut.Name = "MenuItem_ZoomOut";
            this.MenuItem_ZoomOut.ShortcutKeyDisplayString = "X /鼠标滚轮";
            this.MenuItem_ZoomOut.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_ZoomOut.Text = "缩小";
            this.MenuItem_ZoomOut.Click += new System.EventHandler(this.Click_ZoomOut);
            // 
            // MenuItem_Tranlation
            // 
            this.MenuItem_Tranlation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_UpMove,
            this.MenuItem_RightMove,
            this.MenuItem_LeftMove,
            this.MenuItem_DownMove});
            this.MenuItem_Tranlation.Name = "MenuItem_Tranlation";
            this.MenuItem_Tranlation.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_Tranlation.Text = "平移";
            // 
            // MenuItem_UpMove
            // 
            this.MenuItem_UpMove.Name = "MenuItem_UpMove";
            this.MenuItem_UpMove.ShortcutKeyDisplayString = "上箭头/数字键8";
            this.MenuItem_UpMove.Size = new System.Drawing.Size(188, 22);
            this.MenuItem_UpMove.Text = "上移";
            this.MenuItem_UpMove.Click += new System.EventHandler(this.Click_UpMove);
            // 
            // MenuItem_RightMove
            // 
            this.MenuItem_RightMove.Name = "MenuItem_RightMove";
            this.MenuItem_RightMove.ShortcutKeyDisplayString = "左箭头/数字键6";
            this.MenuItem_RightMove.Size = new System.Drawing.Size(188, 22);
            this.MenuItem_RightMove.Text = "右移";
            this.MenuItem_RightMove.Click += new System.EventHandler(this.Click_RightMove);
            // 
            // MenuItem_LeftMove
            // 
            this.MenuItem_LeftMove.Name = "MenuItem_LeftMove";
            this.MenuItem_LeftMove.ShortcutKeyDisplayString = "右箭头/数字键4";
            this.MenuItem_LeftMove.Size = new System.Drawing.Size(188, 22);
            this.MenuItem_LeftMove.Text = "左移";
            this.MenuItem_LeftMove.Click += new System.EventHandler(this.Click_LeftMove);
            // 
            // MenuItem_DownMove
            // 
            this.MenuItem_DownMove.Name = "MenuItem_DownMove";
            this.MenuItem_DownMove.ShortcutKeyDisplayString = "下箭头/数字键2";
            this.MenuItem_DownMove.Size = new System.Drawing.Size(188, 22);
            this.MenuItem_DownMove.Text = "下移";
            this.MenuItem_DownMove.Click += new System.EventHandler(this.Click_DownMove);
            // 
            // toolStripSeparator_22
            // 
            this.toolStripSeparator_22.Name = "toolStripSeparator_22";
            this.toolStripSeparator_22.Size = new System.Drawing.Size(186, 6);
            // 
            // MenuItem_ChooseNextUnit
            // 
            this.MenuItem_ChooseNextUnit.Name = "MenuItem_ChooseNextUnit";
            this.MenuItem_ChooseNextUnit.ShortcutKeyDisplayString = "\\";
            this.MenuItem_ChooseNextUnit.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_ChooseNextUnit.Text = "选择下一单元";
            this.MenuItem_ChooseNextUnit.Click += new System.EventHandler(this.Click_ChooseNextUnit);
            // 
            // MenuItem_ChoosePrevUnit
            // 
            this.MenuItem_ChoosePrevUnit.Name = "MenuItem_ChoosePrevUnit";
            this.MenuItem_ChoosePrevUnit.ShortcutKeyDisplayString = "退格键";
            this.MenuItem_ChoosePrevUnit.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_ChoosePrevUnit.Text = "选择前一单元";
            this.MenuItem_ChoosePrevUnit.Click += new System.EventHandler(this.Click_ChoosePrevUnit);
            // 
            // toolStripSeparator_21
            // 
            this.toolStripSeparator_21.Name = "toolStripSeparator_21";
            this.toolStripSeparator_21.Size = new System.Drawing.Size(186, 6);
            // 
            // MenuItem_DirectionRangeMeasure
            // 
            this.MenuItem_DirectionRangeMeasure.Name = "MenuItem_DirectionRangeMeasure";
            this.MenuItem_DirectionRangeMeasure.ShortcutKeyDisplayString = "Ctrl+D";
            this.MenuItem_DirectionRangeMeasure.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_DirectionRangeMeasure.Text = "测距/测向";
            this.MenuItem_DirectionRangeMeasure.Click += new System.EventHandler(this.Click_DirectionRangeMeasure);
            // 
            // toolStripSeparator_19
            // 
            this.toolStripSeparator_19.Name = "toolStripSeparator_19";
            this.toolStripSeparator_19.Size = new System.Drawing.Size(186, 6);
            // 
            // MenuItem_MessageOutputWindow
            // 
            this.MenuItem_MessageOutputWindow.Name = "MenuItem_MessageOutputWindow";
            this.MenuItem_MessageOutputWindow.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_MessageOutputWindow.Text = "消息输出窗口显示";
            this.MenuItem_MessageOutputWindow.Click += new System.EventHandler(this.Click_MessageOutputWindow);
            // 
            // toolStripSeparator_30
            // 
            this.toolStripSeparator_30.Name = "toolStripSeparator_30";
            this.toolStripSeparator_30.Size = new System.Drawing.Size(186, 6);
            // 
            // MenuItem_LonLatGrid
            // 
            this.MenuItem_LonLatGrid.Name = "MenuItem_LonLatGrid";
            this.MenuItem_LonLatGrid.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_LonLatGrid.Text = "经度纬度网格";
            this.MenuItem_LonLatGrid.Click += new System.EventHandler(this.Click_LatLonGrid);
            // 
            // MenuItem_BMNG
            // 
            this.MenuItem_BMNG.Name = "MenuItem_BMNG";
            this.MenuItem_BMNG.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_BMNG.Text = "BMNG图";
            this.MenuItem_BMNG.Click += new System.EventHandler(this.Click_BMNG);
            // 
            // MenuItem_ColorTopographic
            // 
            this.MenuItem_ColorTopographic.Name = "MenuItem_ColorTopographic";
            this.MenuItem_ColorTopographic.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_ColorTopographic.Text = "彩色地形图";
            this.MenuItem_ColorTopographic.Click += new System.EventHandler(this.Click_ColorTopographic);
            // 
            // MenuItem_ShowBorders
            // 
            this.MenuItem_ShowBorders.Name = "MenuItem_ShowBorders";
            this.MenuItem_ShowBorders.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_ShowBorders.Text = "边境线 + 海岸线";
            this.MenuItem_ShowBorders.Click += new System.EventHandler(this.Click_ShowBorders);
            // 
            // MenuItem_OnlineGeographyData
            // 
            this.MenuItem_OnlineGeographyData.Name = "MenuItem_OnlineGeographyData";
            this.MenuItem_OnlineGeographyData.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_OnlineGeographyData.Text = "在线地理数据";
            this.MenuItem_OnlineGeographyData.Click += new System.EventHandler(this.Click_OnlineGeographyData);
            // 
            // MenuItem_CustomLayer
            // 
            this.MenuItem_CustomLayer.Name = "MenuItem_CustomLayer";
            this.MenuItem_CustomLayer.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_CustomLayer.Text = "自定义图层";
            this.MenuItem_CustomLayer.Click += new System.EventHandler(this.Click_CustomLayer);
            // 
            // MenuItem_PlacenameLayer
            // 
            this.MenuItem_PlacenameLayer.Name = "MenuItem_PlacenameLayer";
            this.MenuItem_PlacenameLayer.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_PlacenameLayer.Text = "地名图层";
            this.MenuItem_PlacenameLayer.Click += new System.EventHandler(this.Click_PlacenameLayer);
            // 
            // MenuItem_DayNightLight
            // 
            this.MenuItem_DayNightLight.Name = "MenuItem_DayNightLight";
            this.MenuItem_DayNightLight.Size = new System.Drawing.Size(189, 22);
            this.MenuItem_DayNightLight.Text = "昼夜分明";
            this.MenuItem_DayNightLight.Click += new System.EventHandler(this.Click_DayNightLight);
            // 
            // MenuItem_SimulationControl
            // 
            this.MenuItem_SimulationControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_StartOrRecover,
            this.MenuItem_SimIncreaseCompression,
            this.MenuItem_SimDecreaseCompression,
            this.MenuItem_RealTimeSim,
            this.toolStripSeparator_16,
            this.MenuItem_OrderOfBattle,
            this.toolStripMenuItem_135,
            this.MenuItem_BrowseScenarioPlatforms,
            this.MenuItem_ScenarioDescription,
            this.MenuItem_MissileBriefReport,
            this.MenuItem_SideDoctrineAndEMCONAndWRA,
            this.MenuItem_MenuItem_SpecialAction,
            this.MenuItem_SatellitePassPredictions,
            this.MenuItem_TSMI_Recorder,
            this.MenuItem_MessageOutput,
            this.MenuItem_LossesAndExpenditures,
            this.MenuItem_Score,
            this.toolStripSeparator_17,
            this.MenuItem_Options,
            this.启动UDP服务ToolStripMenuItem});
            this.MenuItem_SimulationControl.Name = "MenuItem_SimulationControl";
            this.MenuItem_SimulationControl.Size = new System.Drawing.Size(67, 20);
            this.MenuItem_SimulationControl.Text = "推演控制";
            this.MenuItem_SimulationControl.DropDownOpening += new System.EventHandler(this.Click_SimulationControl);
            // 
            // MenuItem_StartOrRecover
            // 
            this.MenuItem_StartOrRecover.Name = "MenuItem_StartOrRecover";
            this.MenuItem_StartOrRecover.ShortcutKeyDisplayString = "F12 / Ctrl+Enter";
            this.MenuItem_StartOrRecover.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_StartOrRecover.Text = "启动/恢复";
            this.MenuItem_StartOrRecover.Click += new System.EventHandler(this.Click_StartOrRecover);
            // 
            // MenuItem_SimIncreaseCompression
            // 
            this.MenuItem_SimIncreaseCompression.Name = "MenuItem_SimIncreaseCompression";
            this.MenuItem_SimIncreaseCompression.ShortcutKeyDisplayString = "+";
            this.MenuItem_SimIncreaseCompression.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_SimIncreaseCompression.Text = "推演加速";
            this.MenuItem_SimIncreaseCompression.Click += new System.EventHandler(this.Click_SimIncreaseCompression);
            // 
            // MenuItem_SimDecreaseCompression
            // 
            this.MenuItem_SimDecreaseCompression.Name = "MenuItem_SimDecreaseCompression";
            this.MenuItem_SimDecreaseCompression.ShortcutKeyDisplayString = "-";
            this.MenuItem_SimDecreaseCompression.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_SimDecreaseCompression.Text = "推演减速";
            this.MenuItem_SimDecreaseCompression.Click += new System.EventHandler(this.Click_SimDecreaseCompression);
            // 
            // MenuItem_RealTimeSim
            // 
            this.MenuItem_RealTimeSim.Name = "MenuItem_RealTimeSim";
            this.MenuItem_RealTimeSim.ShortcutKeyDisplayString = "Enter";
            this.MenuItem_RealTimeSim.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_RealTimeSim.Text = "实时推演";
            this.MenuItem_RealTimeSim.Click += new System.EventHandler(this.Click_RealTimeSim);
            // 
            // toolStripSeparator_16
            // 
            this.toolStripSeparator_16.Name = "toolStripSeparator_16";
            this.toolStripSeparator_16.Size = new System.Drawing.Size(342, 6);
            // 
            // MenuItem_OrderOfBattle
            // 
            this.MenuItem_OrderOfBattle.Name = "MenuItem_OrderOfBattle";
            this.MenuItem_OrderOfBattle.ShortcutKeyDisplayString = "O";
            this.MenuItem_OrderOfBattle.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_OrderOfBattle.Text = "作战编成";
            this.MenuItem_OrderOfBattle.Click += new System.EventHandler(this.Click_OrderOfBattle);
            // 
            // toolStripMenuItem_135
            // 
            this.toolStripMenuItem_135.Name = "toolStripMenuItem_135";
            this.toolStripMenuItem_135.Size = new System.Drawing.Size(345, 22);
            this.toolStripMenuItem_135.Text = "浏览数据库";
            this.toolStripMenuItem_135.Click += new System.EventHandler(this.Click_DataBaseViewer);
            // 
            // MenuItem_BrowseScenarioPlatforms
            // 
            this.MenuItem_BrowseScenarioPlatforms.Name = "MenuItem_BrowseScenarioPlatforms";
            this.MenuItem_BrowseScenarioPlatforms.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_BrowseScenarioPlatforms.Text = "浏览想定平台";
            this.MenuItem_BrowseScenarioPlatforms.Click += new System.EventHandler(this.Click_BrowseScenarioPlatforms);
            // 
            // MenuItem_ScenarioDescription
            // 
            this.MenuItem_ScenarioDescription.Name = "MenuItem_ScenarioDescription";
            this.MenuItem_ScenarioDescription.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_ScenarioDescription.Text = "想定描述";
            this.MenuItem_ScenarioDescription.Click += new System.EventHandler(this.Click_ScenarioDescription);
            // 
            // MenuItem_MissileBriefReport
            // 
            this.MenuItem_MissileBriefReport.Name = "MenuItem_MissileBriefReport";
            this.MenuItem_MissileBriefReport.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_MissileBriefReport.Text = "任务简报";
            this.MenuItem_MissileBriefReport.Click += new System.EventHandler(this.Click_MissileBriefReport);
            // 
            // MenuItem_SideDoctrineAndEMCONAndWRA
            // 
            this.MenuItem_SideDoctrineAndEMCONAndWRA.Name = "MenuItem_SideDoctrineAndEMCONAndWRA";
            this.MenuItem_SideDoctrineAndEMCONAndWRA.ShortcutKeyDisplayString = "Ctrl+Shift+F9";
            this.MenuItem_SideDoctrineAndEMCONAndWRA.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_SideDoctrineAndEMCONAndWRA.Text = "作战条令、电磁管控以及武器使用规则";
            this.MenuItem_SideDoctrineAndEMCONAndWRA.Click += new System.EventHandler(this.Click_SideDoctrineAndEMCONAndWRA);
            // 
            // MenuItem_MenuItem_SpecialAction
            // 
            this.MenuItem_MenuItem_SpecialAction.Name = "MenuItem_MenuItem_SpecialAction";
            this.MenuItem_MenuItem_SpecialAction.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_MenuItem_SpecialAction.Text = "特殊事件";
            this.MenuItem_MenuItem_SpecialAction.Click += new System.EventHandler(this.Click_SpecialAction);
            // 
            // MenuItem_SatellitePassPredictions
            // 
            this.MenuItem_SatellitePassPredictions.Name = "MenuItem_SatellitePassPredictions";
            this.MenuItem_SatellitePassPredictions.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_SatellitePassPredictions.Text = "卫星过顶预报";
            this.MenuItem_SatellitePassPredictions.Click += new System.EventHandler(this.Click_SatellitePassPredictions);
            // 
            // MenuItem_TSMI_Recorder
            // 
            this.MenuItem_TSMI_Recorder.Name = "MenuItem_TSMI_Recorder";
            this.MenuItem_TSMI_Recorder.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_TSMI_Recorder.Text = "推演过程录像";
            this.MenuItem_TSMI_Recorder.Click += new System.EventHandler(this.Click_TSMI_Recorder);
            // 
            // MenuItem_MessageOutput
            // 
            this.MenuItem_MessageOutput.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_ClearMessageLog,
            this.MenuItem_PrintToFile});
            this.MenuItem_MessageOutput.Name = "MenuItem_MessageOutput";
            this.MenuItem_MessageOutput.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_MessageOutput.Text = "消息输出";
            // 
            // MenuItem_ClearMessageLog
            // 
            this.MenuItem_ClearMessageLog.Name = "MenuItem_ClearMessageLog";
            this.MenuItem_ClearMessageLog.ShortcutKeyDisplayString = "Ctrl+M";
            this.MenuItem_ClearMessageLog.Size = new System.Drawing.Size(135, 22);
            this.MenuItem_ClearMessageLog.Text = "清空";
            this.MenuItem_ClearMessageLog.Click += new System.EventHandler(this.Click_ClearMessageLog);
            // 
            // MenuItem_PrintToFile
            // 
            this.MenuItem_PrintToFile.Name = "MenuItem_PrintToFile";
            this.MenuItem_PrintToFile.Size = new System.Drawing.Size(135, 22);
            this.MenuItem_PrintToFile.Text = "打印到文件";
            this.MenuItem_PrintToFile.Click += new System.EventHandler(this.Click_PrintToFile);
            // 
            // MenuItem_LossesAndExpenditures
            // 
            this.MenuItem_LossesAndExpenditures.Name = "MenuItem_LossesAndExpenditures";
            this.MenuItem_LossesAndExpenditures.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_LossesAndExpenditures.Text = "战损+消耗";
            this.MenuItem_LossesAndExpenditures.Click += new System.EventHandler(this.Click_LossesAndExpenditures);
            // 
            // MenuItem_Score
            // 
            this.MenuItem_Score.Name = "MenuItem_Score";
            this.MenuItem_Score.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_Score.Text = "评分";
            this.MenuItem_Score.Click += new System.EventHandler(this.Click_Score);
            // 
            // toolStripSeparator_17
            // 
            this.toolStripSeparator_17.Name = "toolStripSeparator_17";
            this.toolStripSeparator_17.Size = new System.Drawing.Size(342, 6);
            // 
            // MenuItem_Options
            // 
            this.MenuItem_Options.Name = "MenuItem_Options";
            this.MenuItem_Options.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_Options.Text = "选项";
            this.MenuItem_Options.Click += new System.EventHandler(this.Click_Options);
            // 
            // MenuItem_SituationControl
            // 
            this.MenuItem_SituationControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_SwitchToUnitView,
            this.MenuItem_ShowGroupMember,
            this.toolStripSeparator_15,
            this.MenuItem_ToAirDetectRange,
            this.MenuItem_ToSurfaceDetectRange,
            this.MenuItem_ToUnderWaterDetectRange,
            this.MenuItem_ToAirAttackRange,
            this.MenuItem_ToSurfaceAttackRange,
            this.MenuItem_ToLandAttackRange,
            this.MenuItem_ToUnderwaterAttackRange,
            this.MenuItem_ShowRange,
            this.toolStripSeparator_2,
            this.MenuItem_ShowNonfriendlyRange,
            this.MenuItem_MergeShowRange,
            this.toolStripSeparator_10,
            this.MenuItem_SonobuoyVisbility,
            this.MenuItem_ReferencePointVisibility,
            this.toolStripSeparator_25,
            this.MenuItem_LlluminationVectors,
            this.MenuItem_TargetingVectors,
            this.MenuItem_UnitPropVisibility,
            this.MenuItem_DataLink,
            this.MenuItem_ContactEmissions,
            this.MenuItem_PlottedCourses,
            this.toolStripMenuItem_361,
            this.MenuItem_MissionAreaOrCourse,
            this.toolStripSeparator_18,
            this.MenuItem_TrackSelectedUnit});
            this.MenuItem_SituationControl.Name = "MenuItem_SituationControl";
            this.MenuItem_SituationControl.Size = new System.Drawing.Size(67, 20);
            this.MenuItem_SituationControl.Text = "态势控制";
            this.MenuItem_SituationControl.DropDownOpening += new System.EventHandler(this.Click_SituationControl);
            // 
            // MenuItem_SwitchToUnitView
            // 
            this.MenuItem_SwitchToUnitView.Name = "MenuItem_SwitchToUnitView";
            this.MenuItem_SwitchToUnitView.ShortcutKeyDisplayString = "V /PgUp/数字键9";
            this.MenuItem_SwitchToUnitView.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_SwitchToUnitView.Text = "切换到编组视图";
            this.MenuItem_SwitchToUnitView.Click += new System.EventHandler(this.Click_SwitchToUnitView);
            // 
            // MenuItem_ShowGroupMember
            // 
            this.MenuItem_ShowGroupMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_GM_SelectedGroup,
            this.MenuItem_GM_AllGroup,
            this.MenuItem_GM_NotShow});
            this.MenuItem_ShowGroupMember.Name = "MenuItem_ShowGroupMember";
            this.MenuItem_ShowGroupMember.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_ShowGroupMember.Text = "显示编组成员";
            // 
            // MenuItem_GM_SelectedGroup
            // 
            this.MenuItem_GM_SelectedGroup.Name = "MenuItem_GM_SelectedGroup";
            this.MenuItem_GM_SelectedGroup.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_GM_SelectedGroup.Text = "所选编组";
            this.MenuItem_GM_SelectedGroup.Click += new System.EventHandler(this.Click_GM_SelectedGroup);
            // 
            // MenuItem_GM_AllGroup
            // 
            this.MenuItem_GM_AllGroup.Name = "MenuItem_GM_AllGroup";
            this.MenuItem_GM_AllGroup.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_GM_AllGroup.Text = "所有编组";
            this.MenuItem_GM_AllGroup.Click += new System.EventHandler(this.Click_GM_AllGroup);
            // 
            // MenuItem_GM_NotShow
            // 
            this.MenuItem_GM_NotShow.Name = "MenuItem_GM_NotShow";
            this.MenuItem_GM_NotShow.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_GM_NotShow.Text = "不显示";
            this.MenuItem_GM_NotShow.Click += new System.EventHandler(this.Click_GM_NotShow);
            // 
            // toolStripSeparator_15
            // 
            this.toolStripSeparator_15.Name = "toolStripSeparator_15";
            this.toolStripSeparator_15.Size = new System.Drawing.Size(264, 6);
            // 
            // MenuItem_ToAirDetectRange
            // 
            this.MenuItem_ToAirDetectRange.Name = "MenuItem_ToAirDetectRange";
            this.MenuItem_ToAirDetectRange.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_ToAirDetectRange.Text = "对空探测范围";
            this.MenuItem_ToAirDetectRange.Click += new System.EventHandler(this.Click_ToAirDetectRange);
            // 
            // MenuItem_ToSurfaceDetectRange
            // 
            this.MenuItem_ToSurfaceDetectRange.Name = "MenuItem_ToSurfaceDetectRange";
            this.MenuItem_ToSurfaceDetectRange.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_ToSurfaceDetectRange.Text = "对海探测范围";
            this.MenuItem_ToSurfaceDetectRange.Click += new System.EventHandler(this.Click_ToSurfaceDetectRange);
            // 
            // MenuItem_ToUnderWaterDetectRange
            // 
            this.MenuItem_ToUnderWaterDetectRange.Name = "MenuItem_ToUnderWaterDetectRange";
            this.MenuItem_ToUnderWaterDetectRange.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_ToUnderWaterDetectRange.Text = "对潜探测范围";
            this.MenuItem_ToUnderWaterDetectRange.Click += new System.EventHandler(this.Click_ToUnderWaterDetectRange);
            // 
            // MenuItem_ToAirAttackRange
            // 
            this.MenuItem_ToAirAttackRange.Name = "MenuItem_ToAirAttackRange";
            this.MenuItem_ToAirAttackRange.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_ToAirAttackRange.Text = "对空攻击范围";
            this.MenuItem_ToAirAttackRange.Click += new System.EventHandler(this.Click_ToAirAttackRange);
            // 
            // MenuItem_ToSurfaceAttackRange
            // 
            this.MenuItem_ToSurfaceAttackRange.Name = "MenuItem_ToSurfaceAttackRange";
            this.MenuItem_ToSurfaceAttackRange.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_ToSurfaceAttackRange.Text = "对海攻击范围";
            this.MenuItem_ToSurfaceAttackRange.Click += new System.EventHandler(this.Click_ToSurfaceAttackRange);
            // 
            // MenuItem_ToLandAttackRange
            // 
            this.MenuItem_ToLandAttackRange.Name = "MenuItem_ToLandAttackRange";
            this.MenuItem_ToLandAttackRange.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_ToLandAttackRange.Text = "对地攻击范围";
            this.MenuItem_ToLandAttackRange.Click += new System.EventHandler(this.Click_ToLandAttackRange);
            // 
            // MenuItem_ToUnderwaterAttackRange
            // 
            this.MenuItem_ToUnderwaterAttackRange.Name = "MenuItem_ToUnderwaterAttackRange";
            this.MenuItem_ToUnderwaterAttackRange.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_ToUnderwaterAttackRange.Text = "对潜攻击范围";
            this.MenuItem_ToUnderwaterAttackRange.Click += new System.EventHandler(this.Click_ToUnderwaterAttackRange);
            // 
            // MenuItem_ShowRange
            // 
            this.MenuItem_ShowRange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_SR_SelectedUnit,
            this.MenuItem_SR_AllUnit,
            this.MenuItem_SR_NotShow});
            this.MenuItem_ShowRange.Name = "MenuItem_ShowRange";
            this.MenuItem_ShowRange.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_ShowRange.Text = "显示威力范围...";
            // 
            // MenuItem_SR_SelectedUnit
            // 
            this.MenuItem_SR_SelectedUnit.Name = "MenuItem_SR_SelectedUnit";
            this.MenuItem_SR_SelectedUnit.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_SR_SelectedUnit.Text = "所选单元";
            this.MenuItem_SR_SelectedUnit.Click += new System.EventHandler(this.Click_SR_SelectedUnit);
            // 
            // MenuItem_SR_AllUnit
            // 
            this.MenuItem_SR_AllUnit.Name = "MenuItem_SR_AllUnit";
            this.MenuItem_SR_AllUnit.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_SR_AllUnit.Text = "所有单元";
            this.MenuItem_SR_AllUnit.Click += new System.EventHandler(this.Click_SR_AllUnit);
            // 
            // MenuItem_SR_NotShow
            // 
            this.MenuItem_SR_NotShow.Name = "MenuItem_SR_NotShow";
            this.MenuItem_SR_NotShow.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_SR_NotShow.Text = "不显示";
            this.MenuItem_SR_NotShow.Click += new System.EventHandler(this.Click_SR_RangeNotShow);
            // 
            // toolStripSeparator_2
            // 
            this.toolStripSeparator_2.Name = "toolStripSeparator_2";
            this.toolStripSeparator_2.Size = new System.Drawing.Size(264, 6);
            // 
            // MenuItem_ShowNonfriendlyRange
            // 
            this.MenuItem_ShowNonfriendlyRange.Name = "MenuItem_ShowNonfriendlyRange";
            this.MenuItem_ShowNonfriendlyRange.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_ShowNonfriendlyRange.Text = "显示非友方威力范围";
            this.MenuItem_ShowNonfriendlyRange.Click += new System.EventHandler(this.Click_ShowNonfriendlyRange);
            // 
            // MenuItem_MergeShowRange
            // 
            this.MenuItem_MergeShowRange.Name = "MenuItem_MergeShowRange";
            this.MenuItem_MergeShowRange.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_MergeShowRange.Text = "融合显示威力范围";
            this.MenuItem_MergeShowRange.Click += new System.EventHandler(this.Click_MergeShowRange);
            // 
            // toolStripSeparator_10
            // 
            this.toolStripSeparator_10.Name = "toolStripSeparator_10";
            this.toolStripSeparator_10.Size = new System.Drawing.Size(264, 6);
            // 
            // MenuItem_SonobuoyVisbility
            // 
            this.MenuItem_SonobuoyVisbility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_SV_Common,
            this.MenuItem_SV_Virtual,
            this.MenuItem_SV_NotShow});
            this.MenuItem_SonobuoyVisbility.Name = "MenuItem_SonobuoyVisbility";
            this.MenuItem_SonobuoyVisbility.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_SonobuoyVisbility.Text = "声纳浮标显示";
            // 
            // MenuItem_SV_Common
            // 
            this.MenuItem_SV_Common.Name = "MenuItem_SV_Common";
            this.MenuItem_SV_Common.Size = new System.Drawing.Size(110, 22);
            this.MenuItem_SV_Common.Text = "一般";
            this.MenuItem_SV_Common.Click += new System.EventHandler(this.Click_SV_Common);
            // 
            // MenuItem_SV_Virtual
            // 
            this.MenuItem_SV_Virtual.Name = "MenuItem_SV_Virtual";
            this.MenuItem_SV_Virtual.Size = new System.Drawing.Size(110, 22);
            this.MenuItem_SV_Virtual.Text = "虚化";
            this.MenuItem_SV_Virtual.Click += new System.EventHandler(this.Click_SV_Virtual);
            // 
            // MenuItem_SV_NotShow
            // 
            this.MenuItem_SV_NotShow.Name = "MenuItem_SV_NotShow";
            this.MenuItem_SV_NotShow.Size = new System.Drawing.Size(110, 22);
            this.MenuItem_SV_NotShow.Text = "不显示";
            this.MenuItem_SV_NotShow.Click += new System.EventHandler(this.Click_SV_NotShow);
            // 
            // MenuItem_ReferencePointVisibility
            // 
            this.MenuItem_ReferencePointVisibility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_RPV_Common,
            this.MenuItem_RPV_Small,
            this.MenuItem_RPV_NotShow});
            this.MenuItem_ReferencePointVisibility.Name = "MenuItem_ReferencePointVisibility";
            this.MenuItem_ReferencePointVisibility.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_ReferencePointVisibility.Text = "参考点显示";
            // 
            // MenuItem_RPV_Common
            // 
            this.MenuItem_RPV_Common.Name = "MenuItem_RPV_Common";
            this.MenuItem_RPV_Common.Size = new System.Drawing.Size(110, 22);
            this.MenuItem_RPV_Common.Text = "一般";
            this.MenuItem_RPV_Common.Click += new System.EventHandler(this.Click_RPV_Common);
            // 
            // MenuItem_RPV_Small
            // 
            this.MenuItem_RPV_Small.Name = "MenuItem_RPV_Small";
            this.MenuItem_RPV_Small.Size = new System.Drawing.Size(110, 22);
            this.MenuItem_RPV_Small.Text = "小型";
            this.MenuItem_RPV_Small.Click += new System.EventHandler(this.Click_RPV_Small);
            // 
            // MenuItem_RPV_NotShow
            // 
            this.MenuItem_RPV_NotShow.Name = "MenuItem_RPV_NotShow";
            this.MenuItem_RPV_NotShow.Size = new System.Drawing.Size(110, 22);
            this.MenuItem_RPV_NotShow.Text = "不显示";
            this.MenuItem_RPV_NotShow.Click += new System.EventHandler(this.Click_RPV_NotShow);
            // 
            // toolStripSeparator_25
            // 
            this.toolStripSeparator_25.Name = "toolStripSeparator_25";
            this.toolStripSeparator_25.Size = new System.Drawing.Size(264, 6);
            // 
            // MenuItem_LlluminationVectors
            // 
            this.MenuItem_LlluminationVectors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_LV_SelectedUnit,
            this.MenuItem_LV_AllUnit,
            this.MenuItem_LV_NotShow});
            this.MenuItem_LlluminationVectors.Name = "MenuItem_LlluminationVectors";
            this.MenuItem_LlluminationVectors.ShortcutKeyDisplayString = "Toggle End /数字键1";
            this.MenuItem_LlluminationVectors.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_LlluminationVectors.Text = "雷达照射矢量";
            // 
            // MenuItem_LV_SelectedUnit
            // 
            this.MenuItem_LV_SelectedUnit.Name = "MenuItem_LV_SelectedUnit";
            this.MenuItem_LV_SelectedUnit.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_LV_SelectedUnit.Text = "所选单元";
            this.MenuItem_LV_SelectedUnit.Click += new System.EventHandler(this.Click_LV_SelectedUnit);
            // 
            // MenuItem_LV_AllUnit
            // 
            this.MenuItem_LV_AllUnit.Name = "MenuItem_LV_AllUnit";
            this.MenuItem_LV_AllUnit.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_LV_AllUnit.Text = "所有单元";
            this.MenuItem_LV_AllUnit.Click += new System.EventHandler(this.Click_LV_AllUnit);
            // 
            // MenuItem_LV_NotShow
            // 
            this.MenuItem_LV_NotShow.Name = "MenuItem_LV_NotShow";
            this.MenuItem_LV_NotShow.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_LV_NotShow.Text = "不显示";
            this.MenuItem_LV_NotShow.Click += new System.EventHandler(this.Click_LV_NotShow);
            // 
            // MenuItem_TargetingVectors
            // 
            this.MenuItem_TargetingVectors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_TV_SelectedUnit,
            this.MenuItem_TV_AllUnit,
            this.MenuItem_TV_NotShow});
            this.MenuItem_TargetingVectors.Name = "MenuItem_TargetingVectors";
            this.MenuItem_TargetingVectors.ShortcutKeyDisplayString = "Toggle Home /数字键7";
            this.MenuItem_TargetingVectors.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_TargetingVectors.Text = "目标瞄准矢量";
            // 
            // MenuItem_TV_SelectedUnit
            // 
            this.MenuItem_TV_SelectedUnit.Name = "MenuItem_TV_SelectedUnit";
            this.MenuItem_TV_SelectedUnit.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_TV_SelectedUnit.Text = "所选单元";
            this.MenuItem_TV_SelectedUnit.Click += new System.EventHandler(this.Click_TV_SelectedUnit);
            // 
            // MenuItem_TV_AllUnit
            // 
            this.MenuItem_TV_AllUnit.Name = "MenuItem_TV_AllUnit";
            this.MenuItem_TV_AllUnit.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_TV_AllUnit.Text = "所有单元";
            this.MenuItem_TV_AllUnit.Click += new System.EventHandler(this.Click_TV_AllUnit);
            // 
            // MenuItem_TV_NotShow
            // 
            this.MenuItem_TV_NotShow.Name = "MenuItem_TV_NotShow";
            this.MenuItem_TV_NotShow.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_TV_NotShow.Text = "不显示";
            this.MenuItem_TV_NotShow.Click += new System.EventHandler(this.Click_TV_NotShow);
            // 
            // MenuItem_UnitPropVisibility
            // 
            this.MenuItem_UnitPropVisibility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_UPV_SelectedUnit,
            this.MenuItem_UPV_AllUnit,
            this.MenuItem_UPV_NotShow});
            this.MenuItem_UnitPropVisibility.Name = "MenuItem_UnitPropVisibility";
            this.MenuItem_UnitPropVisibility.ShortcutKeyDisplayString = "Toggle *";
            this.MenuItem_UnitPropVisibility.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_UnitPropVisibility.Text = "单元属性显示";
            // 
            // MenuItem_UPV_SelectedUnit
            // 
            this.MenuItem_UPV_SelectedUnit.Name = "MenuItem_UPV_SelectedUnit";
            this.MenuItem_UPV_SelectedUnit.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_UPV_SelectedUnit.Text = "所选单元";
            this.MenuItem_UPV_SelectedUnit.Click += new System.EventHandler(this.Click_UPV_SelectedUnit);
            // 
            // MenuItem_UPV_AllUnit
            // 
            this.MenuItem_UPV_AllUnit.Name = "MenuItem_UPV_AllUnit";
            this.MenuItem_UPV_AllUnit.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_UPV_AllUnit.Text = "所有单元";
            this.MenuItem_UPV_AllUnit.Click += new System.EventHandler(this.Click_UPV_AllUnit);
            // 
            // MenuItem_UPV_NotShow
            // 
            this.MenuItem_UPV_NotShow.Name = "MenuItem_UPV_NotShow";
            this.MenuItem_UPV_NotShow.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_UPV_NotShow.Text = "不显示";
            this.MenuItem_UPV_NotShow.Click += new System.EventHandler(this.Click_UPV_NotShow);
            // 
            // MenuItem_DataLink
            // 
            this.MenuItem_DataLink.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_DL_SelectedUnit,
            this.MenuItem_DL_AllUnit,
            this.MenuItem_DL_NotShow});
            this.MenuItem_DataLink.Name = "MenuItem_DataLink";
            this.MenuItem_DataLink.ShortcutKeyDisplayString = "";
            this.MenuItem_DataLink.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_DataLink.Text = "数据链";
            // 
            // MenuItem_DL_SelectedUnit
            // 
            this.MenuItem_DL_SelectedUnit.Name = "MenuItem_DL_SelectedUnit";
            this.MenuItem_DL_SelectedUnit.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_DL_SelectedUnit.Text = "所选单元";
            this.MenuItem_DL_SelectedUnit.Click += new System.EventHandler(this.Click_DL_SelectedUnit);
            // 
            // MenuItem_DL_AllUnit
            // 
            this.MenuItem_DL_AllUnit.Name = "MenuItem_DL_AllUnit";
            this.MenuItem_DL_AllUnit.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_DL_AllUnit.Text = "所有单元";
            this.MenuItem_DL_AllUnit.Click += new System.EventHandler(this.Click_DL_AllUnit);
            // 
            // MenuItem_DL_NotShow
            // 
            this.MenuItem_DL_NotShow.Name = "MenuItem_DL_NotShow";
            this.MenuItem_DL_NotShow.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_DL_NotShow.Text = "不显示";
            this.MenuItem_DL_NotShow.Click += new System.EventHandler(this.Click_DL_NotShow);
            // 
            // MenuItem_ContactEmissions
            // 
            this.MenuItem_ContactEmissions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_CE_SelectedTarget,
            this.MenuItem_CE_AllTarget,
            this.MenuItem_CE_NotShow,
            this.toolStripSeparator_32,
            this.MenuItem_CE_AllEmissions,
            this.MenuItem_CE_OnlyFCR,
            this.MenuItem_CE_SelectedShowAllRestOnlyFCR});
            this.MenuItem_ContactEmissions.Name = "MenuItem_ContactEmissions";
            this.MenuItem_ContactEmissions.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_ContactEmissions.Text = "目标电磁辐射";
            // 
            // MenuItem_CE_SelectedTarget
            // 
            this.MenuItem_CE_SelectedTarget.Name = "MenuItem_CE_SelectedTarget";
            this.MenuItem_CE_SelectedTarget.Size = new System.Drawing.Size(398, 22);
            this.MenuItem_CE_SelectedTarget.Text = "所选目标";
            this.MenuItem_CE_SelectedTarget.Click += new System.EventHandler(this.Click_CE_SelectedTarget);
            // 
            // MenuItem_CE_AllTarget
            // 
            this.MenuItem_CE_AllTarget.Name = "MenuItem_CE_AllTarget";
            this.MenuItem_CE_AllTarget.Size = new System.Drawing.Size(398, 22);
            this.MenuItem_CE_AllTarget.Text = "所有目标";
            this.MenuItem_CE_AllTarget.Click += new System.EventHandler(this.Click_CE_AllTarget);
            // 
            // MenuItem_CE_NotShow
            // 
            this.MenuItem_CE_NotShow.Name = "MenuItem_CE_NotShow";
            this.MenuItem_CE_NotShow.Size = new System.Drawing.Size(398, 22);
            this.MenuItem_CE_NotShow.Text = "不显示";
            this.MenuItem_CE_NotShow.Click += new System.EventHandler(this.Click_CE_NotShow);
            // 
            // toolStripSeparator_32
            // 
            this.toolStripSeparator_32.Name = "toolStripSeparator_32";
            this.toolStripSeparator_32.Size = new System.Drawing.Size(395, 6);
            // 
            // MenuItem_CE_AllEmissions
            // 
            this.MenuItem_CE_AllEmissions.Name = "MenuItem_CE_AllEmissions";
            this.MenuItem_CE_AllEmissions.Size = new System.Drawing.Size(398, 22);
            this.MenuItem_CE_AllEmissions.Text = "所有电磁辐射";
            this.MenuItem_CE_AllEmissions.Click += new System.EventHandler(this.Click_CE_AllEmissions);
            // 
            // MenuItem_CE_OnlyFCR
            // 
            this.MenuItem_CE_OnlyFCR.Name = "MenuItem_CE_OnlyFCR";
            this.MenuItem_CE_OnlyFCR.Size = new System.Drawing.Size(398, 22);
            this.MenuItem_CE_OnlyFCR.Text = "仅显示火控雷达电磁辐射";
            this.MenuItem_CE_OnlyFCR.Click += new System.EventHandler(this.Click_CE_OnlyFCR);
            // 
            // MenuItem_CE_SelectedShowAllRestOnlyFCR
            // 
            this.MenuItem_CE_SelectedShowAllRestOnlyFCR.Name = "MenuItem_CE_SelectedShowAllRestOnlyFCR";
            this.MenuItem_CE_SelectedShowAllRestOnlyFCR.Size = new System.Drawing.Size(398, 22);
            this.MenuItem_CE_SelectedShowAllRestOnlyFCR.Text = "所选目标的所有电磁辐射，其余目标仅显示火控雷达电磁辐射";
            this.MenuItem_CE_SelectedShowAllRestOnlyFCR.Click += new System.EventHandler(this.Click_CE_SelectedShowAllRestOnlyFCR);
            // 
            // MenuItem_PlottedCourses
            // 
            this.MenuItem_PlottedCourses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AU_AddUnit54,
            this.MenuItem_PC_AllUnit,
            this.MenuItem_PC_NotShow});
            this.MenuItem_PlottedCourses.Name = "MenuItem_PlottedCourses";
            this.MenuItem_PlottedCourses.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_PlottedCourses.Text = "规划航线";
            // 
            // MenuItem_AU_AddUnit54
            // 
            this.MenuItem_AU_AddUnit54.Name = "MenuItem_AU_AddUnit54";
            this.MenuItem_AU_AddUnit54.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_AU_AddUnit54.Text = "所选单元";
            this.MenuItem_AU_AddUnit54.Click += new System.EventHandler(this.Click_PC_SelectedUnit);
            // 
            // MenuItem_PC_AllUnit
            // 
            this.MenuItem_PC_AllUnit.Name = "MenuItem_PC_AllUnit";
            this.MenuItem_PC_AllUnit.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_PC_AllUnit.Text = "所有单元";
            this.MenuItem_PC_AllUnit.Click += new System.EventHandler(this.Click_PC_AllUnit);
            // 
            // MenuItem_PC_NotShow
            // 
            this.MenuItem_PC_NotShow.Name = "MenuItem_PC_NotShow";
            this.MenuItem_PC_NotShow.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_PC_NotShow.Text = "不显示";
            this.MenuItem_PC_NotShow.Click += new System.EventHandler(this.Click_PC_NotShow);
            // 
            // toolStripMenuItem_361
            // 
            this.toolStripMenuItem_361.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_362,
            this.toolStripMenuItem_363,
            this.toolStripMenuItem_364});
            this.toolStripMenuItem_361.Name = "toolStripMenuItem_361";
            this.toolStripMenuItem_361.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItem_361.Text = "规划航线";
            // 
            // toolStripMenuItem_362
            // 
            this.toolStripMenuItem_362.Name = "toolStripMenuItem_362";
            this.toolStripMenuItem_362.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem_362.Text = "所选单元";
            this.toolStripMenuItem_362.Click += new System.EventHandler(this.method_551);
            // 
            // toolStripMenuItem_363
            // 
            this.toolStripMenuItem_363.Name = "toolStripMenuItem_363";
            this.toolStripMenuItem_363.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem_363.Text = "所有单元";
            this.toolStripMenuItem_363.Click += new System.EventHandler(this.method_552);
            // 
            // toolStripMenuItem_364
            // 
            this.toolStripMenuItem_364.Name = "toolStripMenuItem_364";
            this.toolStripMenuItem_364.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem_364.Text = "不显示";
            this.toolStripMenuItem_364.Click += new System.EventHandler(this.method_553);
            // 
            // MenuItem_MissionAreaOrCourse
            // 
            this.MenuItem_MissionAreaOrCourse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_MAOC_SelectedMission,
            this.MenuItem_MAOC_AllMission,
            this.MenuItem_MAOC_NotShow});
            this.MenuItem_MissionAreaOrCourse.Name = "MenuItem_MissionAreaOrCourse";
            this.MenuItem_MissionAreaOrCourse.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_MissionAreaOrCourse.Text = "任务区域/航线";
            // 
            // MenuItem_MAOC_SelectedMission
            // 
            this.MenuItem_MAOC_SelectedMission.Name = "MenuItem_MAOC_SelectedMission";
            this.MenuItem_MAOC_SelectedMission.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_MAOC_SelectedMission.Text = "所选任务";
            this.MenuItem_MAOC_SelectedMission.Click += new System.EventHandler(this.Click_MAOC_SelectedMission);
            // 
            // MenuItem_MAOC_AllMission
            // 
            this.MenuItem_MAOC_AllMission.Name = "MenuItem_MAOC_AllMission";
            this.MenuItem_MAOC_AllMission.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_MAOC_AllMission.Text = "所有任务";
            this.MenuItem_MAOC_AllMission.Click += new System.EventHandler(this.Click_MAOC_AllMission);
            // 
            // MenuItem_MAOC_NotShow
            // 
            this.MenuItem_MAOC_NotShow.Name = "MenuItem_MAOC_NotShow";
            this.MenuItem_MAOC_NotShow.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_MAOC_NotShow.Text = "不显示";
            this.MenuItem_MAOC_NotShow.Click += new System.EventHandler(this.Click_MAOC_NotShow);
            // 
            // toolStripSeparator_18
            // 
            this.toolStripSeparator_18.Name = "toolStripSeparator_18";
            this.toolStripSeparator_18.Size = new System.Drawing.Size(264, 6);
            // 
            // MenuItem_TrackSelectedUnit
            // 
            this.MenuItem_TrackSelectedUnit.Name = "MenuItem_TrackSelectedUnit";
            this.MenuItem_TrackSelectedUnit.ShortcutKeyDisplayString = "T";
            this.MenuItem_TrackSelectedUnit.Size = new System.Drawing.Size(267, 22);
            this.MenuItem_TrackSelectedUnit.Text = "跟踪所选单元";
            this.MenuItem_TrackSelectedUnit.Click += new System.EventHandler(this.Click_TrackSelectedUnit);
            // 
            // MenuItem_QuickJump
            // 
            this.MenuItem_QuickJump.Name = "MenuItem_QuickJump";
            this.MenuItem_QuickJump.Size = new System.Drawing.Size(67, 20);
            this.MenuItem_QuickJump.Text = "快速跳转";
            // 
            // MenuItem_UnitOrder
            // 
            this.MenuItem_UnitOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AttackOptions,
            this.MenuItem_AntiSubmarineWar,
            this.MenuItem_ThrottleAltOrDeep,
            this.MenuItem_PlotCourse,
            this.MenuItem_Magazines,
            this.MenuItem_AirOperations,
            this.MenuItem_BoatDockingOperations,
            this.MenuItem_WeaponStatus,
            this.MenuItem_SensorsStatus,
            this.MenuItem_SystemDamageStatus,
            this.MenuItem_ReturnToBase,
            this.MenuItem_SelectNewBase,
            this.MenuItem_AirRefuel,
            this.MenuItem_HoldPositon_SelectedUnit,
            this.MenuItem_HoldPositon_AllUnit,
            this.MenuItem_QuickTumaround,
            this.toolStripSeparator_20,
            this.MenuItem_GroupOperations,
            this.toolStripSeparator_33,
            this.MenuItem_UnassignMissionUnit,
            this.MenuItem_AssignMissionToUnit,
            this.MenuItem_Doctrine_RoE_EMCON_WRA});
            this.MenuItem_UnitOrder.Name = "MenuItem_UnitOrder";
            this.MenuItem_UnitOrder.ShortcutKeyDisplayString = "";
            this.MenuItem_UnitOrder.Size = new System.Drawing.Size(67, 20);
            this.MenuItem_UnitOrder.Text = "作战命令";
            this.MenuItem_UnitOrder.DropDownOpening += new System.EventHandler(this.DropDownOpening_UnitOrder);
            // 
            // MenuItem_AttackOptions
            // 
            this.MenuItem_AttackOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AO_AutoEngageTarget,
            this.MenuItem_AO_ManualEngageTarget,
            this.MenuItem_AO_LaunchOnlyBearing,
            this.MenuItem_AO_DropTarget,
            this.MenuItem_AO_DropAllTarget,
            this.MenuItem_AO_IgnorePlottedCourse_SelectedUnit,
            this.MenuItem_AO_IgnorePlottedCourse_AllUnit,
            this.MenuItem_AO_WeaponContorlStatusForAllType_SelectUnit,
            this.MenuItem_AO_WeaponContorlStatusForAllType_AllUnit});
            this.MenuItem_AttackOptions.Name = "MenuItem_AttackOptions";
            this.MenuItem_AttackOptions.ShortcutKeyDisplayString = "";
            this.MenuItem_AttackOptions.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_AttackOptions.Text = "攻击选择";
            // 
            // MenuItem_AO_AutoEngageTarget
            // 
            this.MenuItem_AO_AutoEngageTarget.Name = "MenuItem_AO_AutoEngageTarget";
            this.MenuItem_AO_AutoEngageTarget.ShortcutKeyDisplayString = "F1";
            this.MenuItem_AO_AutoEngageTarget.Size = new System.Drawing.Size(408, 22);
            this.MenuItem_AO_AutoEngageTarget.Text = "自动交战";
            this.MenuItem_AO_AutoEngageTarget.Click += new System.EventHandler(this.Click_AO_AutoEngageTarget);
            // 
            // MenuItem_AO_ManualEngageTarget
            // 
            this.MenuItem_AO_ManualEngageTarget.Name = "MenuItem_AO_ManualEngageTarget";
            this.MenuItem_AO_ManualEngageTarget.ShortcutKeyDisplayString = "Shift+F1";
            this.MenuItem_AO_ManualEngageTarget.Size = new System.Drawing.Size(408, 22);
            this.MenuItem_AO_ManualEngageTarget.Text = "手动交战";
            this.MenuItem_AO_ManualEngageTarget.Click += new System.EventHandler(this.Click_AO_ManualEngageTarget);
            // 
            // MenuItem_AO_LaunchOnlyBearing
            // 
            this.MenuItem_AO_LaunchOnlyBearing.Name = "MenuItem_AO_LaunchOnlyBearing";
            this.MenuItem_AO_LaunchOnlyBearing.ShortcutKeyDisplayString = "Ctrl+F1";
            this.MenuItem_AO_LaunchOnlyBearing.Size = new System.Drawing.Size(408, 22);
            this.MenuItem_AO_LaunchOnlyBearing.Text = "纯方位攻击";
            this.MenuItem_AO_LaunchOnlyBearing.Click += new System.EventHandler(this.Click_AO_LaunchOnlyBearing);
            // 
            // MenuItem_AO_DropTarget
            // 
            this.MenuItem_AO_DropTarget.Name = "MenuItem_AO_DropTarget";
            this.MenuItem_AO_DropTarget.ShortcutKeyDisplayString = "E";
            this.MenuItem_AO_DropTarget.Size = new System.Drawing.Size(408, 22);
            this.MenuItem_AO_DropTarget.Text = "放弃目标";
            this.MenuItem_AO_DropTarget.Click += new System.EventHandler(this.Click_AO_DropTarget);
            // 
            // MenuItem_AO_DropAllTarget
            // 
            this.MenuItem_AO_DropAllTarget.Name = "MenuItem_AO_DropAllTarget";
            this.MenuItem_AO_DropAllTarget.ShortcutKeyDisplayString = "Ctrl+E";
            this.MenuItem_AO_DropAllTarget.Size = new System.Drawing.Size(408, 22);
            this.MenuItem_AO_DropAllTarget.Text = "脱离交战 (放弃所有目标)";
            this.MenuItem_AO_DropAllTarget.Click += new System.EventHandler(this.Click_AO_DropAllTarget);
            // 
            // MenuItem_AO_IgnorePlottedCourse_SelectedUnit
            // 
            this.MenuItem_AO_IgnorePlottedCourse_SelectedUnit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AO_IPCSU_Yes,
            this.MenuItem_AO_IPCSU_No,
            this.MenuItem_AO_IPCSU_SameAsSuperior});
            this.MenuItem_AO_IgnorePlottedCourse_SelectedUnit.Name = "MenuItem_AO_IgnorePlottedCourse_SelectedUnit";
            this.MenuItem_AO_IgnorePlottedCourse_SelectedUnit.ShortcutKeyDisplayString = "I (Yes/Inherit)";
            this.MenuItem_AO_IgnorePlottedCourse_SelectedUnit.Size = new System.Drawing.Size(408, 22);
            this.MenuItem_AO_IgnorePlottedCourse_SelectedUnit.Text = "攻击时忽略计划航线—针对所选单元";
            // 
            // MenuItem_AO_IPCSU_Yes
            // 
            this.MenuItem_AO_IPCSU_Yes.Name = "MenuItem_AO_IPCSU_Yes";
            this.MenuItem_AO_IPCSU_Yes.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_AO_IPCSU_Yes.Text = "是";
            this.MenuItem_AO_IPCSU_Yes.Click += new System.EventHandler(this.Click_AO_IPCSU_Yes);
            // 
            // MenuItem_AO_IPCSU_No
            // 
            this.MenuItem_AO_IPCSU_No.Name = "MenuItem_AO_IPCSU_No";
            this.MenuItem_AO_IPCSU_No.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_AO_IPCSU_No.Text = "否";
            this.MenuItem_AO_IPCSU_No.Click += new System.EventHandler(this.Click_AO_IPCSU_No);
            // 
            // MenuItem_AO_IPCSU_SameAsSuperior
            // 
            this.MenuItem_AO_IPCSU_SameAsSuperior.Name = "MenuItem_AO_IPCSU_SameAsSuperior";
            this.MenuItem_AO_IPCSU_SameAsSuperior.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_AO_IPCSU_SameAsSuperior.Text = "与上级一致";
            this.MenuItem_AO_IPCSU_SameAsSuperior.Click += new System.EventHandler(this.Click_AO_IPCSU_SameAsSuperior);
            // 
            // MenuItem_AO_IgnorePlottedCourse_AllUnit
            // 
            this.MenuItem_AO_IgnorePlottedCourse_AllUnit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AO_IPCAU_Yes,
            this.MenuItem_AO_IPCAU_No,
            this.MenuItem_AO_IPCAU_SameAsSuperior});
            this.MenuItem_AO_IgnorePlottedCourse_AllUnit.Name = "MenuItem_AO_IgnorePlottedCourse_AllUnit";
            this.MenuItem_AO_IgnorePlottedCourse_AllUnit.ShortcutKeyDisplayString = "Ctrl+I I (Yes/Inherit)";
            this.MenuItem_AO_IgnorePlottedCourse_AllUnit.Size = new System.Drawing.Size(408, 22);
            this.MenuItem_AO_IgnorePlottedCourse_AllUnit.Text = "攻击时忽略计划航线—针对所有单元";
            // 
            // MenuItem_AO_IPCAU_Yes
            // 
            this.MenuItem_AO_IPCAU_Yes.Name = "MenuItem_AO_IPCAU_Yes";
            this.MenuItem_AO_IPCAU_Yes.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_AO_IPCAU_Yes.Text = "是";
            this.MenuItem_AO_IPCAU_Yes.Click += new System.EventHandler(this.Click_AO_IPCAU_Yes);
            // 
            // MenuItem_AO_IPCAU_No
            // 
            this.MenuItem_AO_IPCAU_No.Name = "MenuItem_AO_IPCAU_No";
            this.MenuItem_AO_IPCAU_No.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_AO_IPCAU_No.Text = "否";
            this.MenuItem_AO_IPCAU_No.Click += new System.EventHandler(this.Click_AO_IPCAU_No);
            // 
            // MenuItem_AO_IPCAU_SameAsSuperior
            // 
            this.MenuItem_AO_IPCAU_SameAsSuperior.Name = "MenuItem_AO_IPCAU_SameAsSuperior";
            this.MenuItem_AO_IPCAU_SameAsSuperior.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_AO_IPCAU_SameAsSuperior.Text = "与上级一致";
            this.MenuItem_AO_IPCAU_SameAsSuperior.Click += new System.EventHandler(this.Click_AO_IPCAU_SameAsSuperior);
            // 
            // MenuItem_AO_WeaponContorlStatusForAllType_SelectUnit
            // 
            this.MenuItem_AO_WeaponContorlStatusForAllType_SelectUnit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AO_WCSFATSU_ForbidFire,
            this.MenuItem_AO_WCSFATSU_LimitFire,
            this.MenuItem_AO_WCSFATSU_FreeFire,
            this.MenuItem_AO_WCSFATSU_SameAsSuperior});
            this.MenuItem_AO_WeaponContorlStatusForAllType_SelectUnit.Name = "MenuItem_AO_WeaponContorlStatusForAllType_SelectUnit";
            this.MenuItem_AO_WeaponContorlStatusForAllType_SelectUnit.ShortcutKeyDisplayString = "A (Hold/Inherit)";
            this.MenuItem_AO_WeaponContorlStatusForAllType_SelectUnit.Size = new System.Drawing.Size(408, 22);
            this.MenuItem_AO_WeaponContorlStatusForAllType_SelectUnit.Text = "针对所有目标类型的武器控制状态- 所选单元";
            // 
            // MenuItem_AO_WCSFATSU_ForbidFire
            // 
            this.MenuItem_AO_WCSFATSU_ForbidFire.Name = "MenuItem_AO_WCSFATSU_ForbidFire";
            this.MenuItem_AO_WCSFATSU_ForbidFire.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_AO_WCSFATSU_ForbidFire.Text = "禁止开火";
            this.MenuItem_AO_WCSFATSU_ForbidFire.Click += new System.EventHandler(this.Click_AO_WCSFATSU_ForbidFire);
            // 
            // MenuItem_AO_WCSFATSU_LimitFire
            // 
            this.MenuItem_AO_WCSFATSU_LimitFire.Name = "MenuItem_AO_WCSFATSU_LimitFire";
            this.MenuItem_AO_WCSFATSU_LimitFire.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_AO_WCSFATSU_LimitFire.Text = "限制开火";
            this.MenuItem_AO_WCSFATSU_LimitFire.Click += new System.EventHandler(this.Click_AO_WCSFATSU_LimitFire);
            // 
            // MenuItem_AO_WCSFATSU_FreeFire
            // 
            this.MenuItem_AO_WCSFATSU_FreeFire.Name = "MenuItem_AO_WCSFATSU_FreeFire";
            this.MenuItem_AO_WCSFATSU_FreeFire.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_AO_WCSFATSU_FreeFire.Text = "自由开火";
            this.MenuItem_AO_WCSFATSU_FreeFire.Click += new System.EventHandler(this.Click_AO_WCSFATSU_FreeFire);
            // 
            // MenuItem_AO_WCSFATSU_SameAsSuperior
            // 
            this.MenuItem_AO_WCSFATSU_SameAsSuperior.Name = "MenuItem_AO_WCSFATSU_SameAsSuperior";
            this.MenuItem_AO_WCSFATSU_SameAsSuperior.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_AO_WCSFATSU_SameAsSuperior.Text = "与上级一致";
            this.MenuItem_AO_WCSFATSU_SameAsSuperior.Click += new System.EventHandler(this.Click_AO_WCSFATSU_SameAsSuperior);
            // 
            // MenuItem_AO_WeaponContorlStatusForAllType_AllUnit
            // 
            this.MenuItem_AO_WeaponContorlStatusForAllType_AllUnit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AO_WCSFATAU_ForbidFire,
            this.MenuItem_AO_WCSFATAU_LimitFire,
            this.MenuItem_AO_WCSFATAU_FreeFire,
            this.MenuItem_AO_WCSFATAU_SameAsSuperior});
            this.MenuItem_AO_WeaponContorlStatusForAllType_AllUnit.Name = "MenuItem_AO_WeaponContorlStatusForAllType_AllUnit";
            this.MenuItem_AO_WeaponContorlStatusForAllType_AllUnit.ShortcutKeyDisplayString = "Ctrl+A (Hold/Inherit)";
            this.MenuItem_AO_WeaponContorlStatusForAllType_AllUnit.Size = new System.Drawing.Size(408, 22);
            this.MenuItem_AO_WeaponContorlStatusForAllType_AllUnit.Text = "针对所有目标类型的武器控制状态- 所有单元";
            // 
            // MenuItem_AO_WCSFATAU_ForbidFire
            // 
            this.MenuItem_AO_WCSFATAU_ForbidFire.Name = "MenuItem_AO_WCSFATAU_ForbidFire";
            this.MenuItem_AO_WCSFATAU_ForbidFire.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_AO_WCSFATAU_ForbidFire.Text = "禁止开火";
            this.MenuItem_AO_WCSFATAU_ForbidFire.Click += new System.EventHandler(this.Click_AO_WCSFATAU_ForbidFire);
            // 
            // MenuItem_AO_WCSFATAU_LimitFire
            // 
            this.MenuItem_AO_WCSFATAU_LimitFire.Name = "MenuItem_AO_WCSFATAU_LimitFire";
            this.MenuItem_AO_WCSFATAU_LimitFire.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_AO_WCSFATAU_LimitFire.Text = "限制开火";
            this.MenuItem_AO_WCSFATAU_LimitFire.Click += new System.EventHandler(this.Click_AO_WCSFATAU_LimitFire);
            // 
            // MenuItem_AO_WCSFATAU_FreeFire
            // 
            this.MenuItem_AO_WCSFATAU_FreeFire.Name = "MenuItem_AO_WCSFATAU_FreeFire";
            this.MenuItem_AO_WCSFATAU_FreeFire.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_AO_WCSFATAU_FreeFire.Text = "自由开火";
            this.MenuItem_AO_WCSFATAU_FreeFire.Click += new System.EventHandler(this.Click_AO_WCSFATAU_FreeFire);
            // 
            // MenuItem_AO_WCSFATAU_SameAsSuperior
            // 
            this.MenuItem_AO_WCSFATAU_SameAsSuperior.Name = "MenuItem_AO_WCSFATAU_SameAsSuperior";
            this.MenuItem_AO_WCSFATAU_SameAsSuperior.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_AO_WCSFATAU_SameAsSuperior.Text = "与上级一致";
            this.MenuItem_AO_WCSFATAU_SameAsSuperior.Click += new System.EventHandler(this.Click_AO_WCSFATAU_SameAsSuperior);
            // 
            // MenuItem_AntiSubmarineWar
            // 
            this.MenuItem_AntiSubmarineWar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_ASW_DropPassiveSonobuoy,
            this.MenuItem_DropActiveSonobuoy,
            this.MenuItem_DeployDippingSonar});
            this.MenuItem_AntiSubmarineWar.Name = "MenuItem_AntiSubmarineWar";
            this.MenuItem_AntiSubmarineWar.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_AntiSubmarineWar.Text = "反潜作战";
            // 
            // MenuItem_ASW_DropPassiveSonobuoy
            // 
            this.MenuItem_ASW_DropPassiveSonobuoy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_ASW_DPS_Shallow,
            this.MenuItem_ASW_DPS_Deep});
            this.MenuItem_ASW_DropPassiveSonobuoy.Name = "MenuItem_ASW_DropPassiveSonobuoy";
            this.MenuItem_ASW_DropPassiveSonobuoy.ShortcutKeyDisplayString = "";
            this.MenuItem_ASW_DropPassiveSonobuoy.Size = new System.Drawing.Size(188, 22);
            this.MenuItem_ASW_DropPassiveSonobuoy.Text = "投放被动声纳浮标";
            // 
            // MenuItem_ASW_DPS_Shallow
            // 
            this.MenuItem_ASW_DPS_Shallow.Name = "MenuItem_ASW_DPS_Shallow";
            this.MenuItem_ASW_DPS_Shallow.ShortcutKeyDisplayString = "Shift+[";
            this.MenuItem_ASW_DPS_Shallow.Size = new System.Drawing.Size(192, 22);
            this.MenuItem_ASW_DPS_Shallow.Text = "浅 - 温跃层之上";
            this.MenuItem_ASW_DPS_Shallow.Click += new System.EventHandler(this.Click_ASW_DPS_Shallow);
            // 
            // MenuItem_ASW_DPS_Deep
            // 
            this.MenuItem_ASW_DPS_Deep.Name = "MenuItem_ASW_DPS_Deep";
            this.MenuItem_ASW_DPS_Deep.ShortcutKeyDisplayString = "[";
            this.MenuItem_ASW_DPS_Deep.Size = new System.Drawing.Size(192, 22);
            this.MenuItem_ASW_DPS_Deep.Text = "深 - 温跃层之下";
            this.MenuItem_ASW_DPS_Deep.Click += new System.EventHandler(this.Click_ASW_DPS_Deep);
            // 
            // MenuItem_DropActiveSonobuoy
            // 
            this.MenuItem_DropActiveSonobuoy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_ASW_DAS_Shallow,
            this.MenuItem_ASW_DAS_Deep});
            this.MenuItem_DropActiveSonobuoy.Name = "MenuItem_DropActiveSonobuoy";
            this.MenuItem_DropActiveSonobuoy.ShortcutKeyDisplayString = "";
            this.MenuItem_DropActiveSonobuoy.Size = new System.Drawing.Size(188, 22);
            this.MenuItem_DropActiveSonobuoy.Text = "投放主动声纳浮标";
            // 
            // MenuItem_ASW_DAS_Shallow
            // 
            this.MenuItem_ASW_DAS_Shallow.Name = "MenuItem_ASW_DAS_Shallow";
            this.MenuItem_ASW_DAS_Shallow.ShortcutKeyDisplayString = "Shift+]";
            this.MenuItem_ASW_DAS_Shallow.Size = new System.Drawing.Size(192, 22);
            this.MenuItem_ASW_DAS_Shallow.Text = "浅 - 温跃层之上";
            this.MenuItem_ASW_DAS_Shallow.Click += new System.EventHandler(this.Click_ASW_DAS_Shallow);
            // 
            // MenuItem_ASW_DAS_Deep
            // 
            this.MenuItem_ASW_DAS_Deep.Name = "MenuItem_ASW_DAS_Deep";
            this.MenuItem_ASW_DAS_Deep.ShortcutKeyDisplayString = "]";
            this.MenuItem_ASW_DAS_Deep.Size = new System.Drawing.Size(192, 22);
            this.MenuItem_ASW_DAS_Deep.Text = "深 - 温跃层之下";
            this.MenuItem_ASW_DAS_Deep.Click += new System.EventHandler(this.Click_ASW_DAS_Deep);
            // 
            // MenuItem_DeployDippingSonar
            // 
            this.MenuItem_DeployDippingSonar.Name = "MenuItem_DeployDippingSonar";
            this.MenuItem_DeployDippingSonar.ShortcutKeyDisplayString = "Shift+D";
            this.MenuItem_DeployDippingSonar.Size = new System.Drawing.Size(188, 22);
            this.MenuItem_DeployDippingSonar.Text = "部署吊放声纳";
            this.MenuItem_DeployDippingSonar.Click += new System.EventHandler(this.Click_DeployDippingSonar);
            // 
            // MenuItem_ThrottleAltOrDeep
            // 
            this.MenuItem_ThrottleAltOrDeep.Name = "MenuItem_ThrottleAltOrDeep";
            this.MenuItem_ThrottleAltOrDeep.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.MenuItem_ThrottleAltOrDeep.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_ThrottleAltOrDeep.Text = "油门-高度/深度";
            this.MenuItem_ThrottleAltOrDeep.Click += new System.EventHandler(this.Click_ThrottleAltOrDeep);
            // 
            // MenuItem_PlotCourse
            // 
            this.MenuItem_PlotCourse.Name = "MenuItem_PlotCourse";
            this.MenuItem_PlotCourse.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.MenuItem_PlotCourse.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_PlotCourse.Text = "航线规划";
            this.MenuItem_PlotCourse.Click += new System.EventHandler(this.Click_PlotCourse);
            // 
            // MenuItem_Magazines
            // 
            this.MenuItem_Magazines.Name = "MenuItem_Magazines";
            this.MenuItem_Magazines.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MenuItem_Magazines.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_Magazines.Text = "弹药库";
            this.MenuItem_Magazines.Click += new System.EventHandler(this.Click_Magazines);
            // 
            // MenuItem_AirOperations
            // 
            this.MenuItem_AirOperations.Name = "MenuItem_AirOperations";
            this.MenuItem_AirOperations.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.MenuItem_AirOperations.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_AirOperations.Text = "空中作战";
            this.MenuItem_AirOperations.Click += new System.EventHandler(this.Click_AirOperations);
            // 
            // MenuItem_BoatDockingOperations
            // 
            this.MenuItem_BoatDockingOperations.Name = "MenuItem_BoatDockingOperations";
            this.MenuItem_BoatDockingOperations.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.MenuItem_BoatDockingOperations.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_BoatDockingOperations.Text = "船舶停靠";
            this.MenuItem_BoatDockingOperations.Click += new System.EventHandler(this.Click_BoatDockingOperations);
            // 
            // MenuItem_WeaponStatus
            // 
            this.MenuItem_WeaponStatus.Name = "MenuItem_WeaponStatus";
            this.MenuItem_WeaponStatus.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.MenuItem_WeaponStatus.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_WeaponStatus.Text = "武器状态";
            this.MenuItem_WeaponStatus.Click += new System.EventHandler(this.Click_WeaponStatus);
            // 
            // MenuItem_SensorsStatus
            // 
            this.MenuItem_SensorsStatus.Name = "MenuItem_SensorsStatus";
            this.MenuItem_SensorsStatus.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.MenuItem_SensorsStatus.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_SensorsStatus.Text = "传感器状态";
            this.MenuItem_SensorsStatus.Click += new System.EventHandler(this.Click_SensorsStatus);
            // 
            // MenuItem_SystemDamageStatus
            // 
            this.MenuItem_SystemDamageStatus.Name = "MenuItem_SystemDamageStatus";
            this.MenuItem_SystemDamageStatus.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.MenuItem_SystemDamageStatus.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_SystemDamageStatus.Text = "系统毁伤状态";
            this.MenuItem_SystemDamageStatus.Click += new System.EventHandler(this.Click_SystemDamageStatus);
            // 
            // MenuItem_ReturnToBase
            // 
            this.MenuItem_ReturnToBase.Name = "MenuItem_ReturnToBase";
            this.MenuItem_ReturnToBase.ShortcutKeyDisplayString = "B";
            this.MenuItem_ReturnToBase.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_ReturnToBase.Text = "返航";
            this.MenuItem_ReturnToBase.Click += new System.EventHandler(this.Click_ReturnToBase);
            // 
            // MenuItem_SelectNewBase
            // 
            this.MenuItem_SelectNewBase.Name = "MenuItem_SelectNewBase";
            this.MenuItem_SelectNewBase.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_SelectNewBase.Text = "选择新降落机场";
            this.MenuItem_SelectNewBase.Click += new System.EventHandler(this.Click_SelectNewBase);
            // 
            // MenuItem_AirRefuel
            // 
            this.MenuItem_AirRefuel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AR_AutoSelectAerialTanker,
            this.MenuItem_AR_ManualSelectAerialTanker,
            this.MenuItem_AR_SelectForMission});
            this.MenuItem_AirRefuel.Name = "MenuItem_AirRefuel";
            this.MenuItem_AirRefuel.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_AirRefuel.Text = "空中加油";
            // 
            // MenuItem_AR_AutoSelectAerialTanker
            // 
            this.MenuItem_AR_AutoSelectAerialTanker.Name = "MenuItem_AR_AutoSelectAerialTanker";
            this.MenuItem_AR_AutoSelectAerialTanker.Size = new System.Drawing.Size(185, 22);
            this.MenuItem_AR_AutoSelectAerialTanker.Text = "自动选择加油机";
            this.MenuItem_AR_AutoSelectAerialTanker.Click += new System.EventHandler(this.Click_AR_AutoSelectAerialTanker);
            // 
            // MenuItem_AR_ManualSelectAerialTanker
            // 
            this.MenuItem_AR_ManualSelectAerialTanker.Name = "MenuItem_AR_ManualSelectAerialTanker";
            this.MenuItem_AR_ManualSelectAerialTanker.Size = new System.Drawing.Size(185, 22);
            this.MenuItem_AR_ManualSelectAerialTanker.Text = "手动选择加油机";
            this.MenuItem_AR_ManualSelectAerialTanker.Click += new System.EventHandler(this.Click_AR_ManualSelectAerialTanker);
            // 
            // MenuItem_AR_SelectForMission
            // 
            this.MenuItem_AR_SelectForMission.Name = "MenuItem_AR_SelectForMission";
            this.MenuItem_AR_SelectForMission.Size = new System.Drawing.Size(185, 22);
            this.MenuItem_AR_SelectForMission.Text = "从任务中选择加油机:";
            // 
            // MenuItem_HoldPositon_SelectedUnit
            // 
            this.MenuItem_HoldPositon_SelectedUnit.Name = "MenuItem_HoldPositon_SelectedUnit";
            this.MenuItem_HoldPositon_SelectedUnit.ShortcutKeyDisplayString = "L";
            this.MenuItem_HoldPositon_SelectedUnit.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_HoldPositon_SelectedUnit.Text = "保持阵位—所选单元";
            this.MenuItem_HoldPositon_SelectedUnit.Click += new System.EventHandler(this.Click_HoldPositon_SelectedUnit);
            // 
            // MenuItem_HoldPositon_AllUnit
            // 
            this.MenuItem_HoldPositon_AllUnit.Name = "MenuItem_HoldPositon_AllUnit";
            this.MenuItem_HoldPositon_AllUnit.ShortcutKeyDisplayString = "Ctrl+L";
            this.MenuItem_HoldPositon_AllUnit.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_HoldPositon_AllUnit.Text = "保持阵位—所有单元";
            this.MenuItem_HoldPositon_AllUnit.Click += new System.EventHandler(this.Click_HoldPositon_AllUnit);
            // 
            // MenuItem_QuickTumaround
            // 
            this.MenuItem_QuickTumaround.Name = "MenuItem_QuickTumaround";
            this.MenuItem_QuickTumaround.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_QuickTumaround.Text = "快速出动(飞机)";
            this.MenuItem_QuickTumaround.Click += new System.EventHandler(this.Click_QuickTumaround);
            // 
            // toolStripSeparator_20
            // 
            this.toolStripSeparator_20.Name = "toolStripSeparator_20";
            this.toolStripSeparator_20.Size = new System.Drawing.Size(342, 6);
            // 
            // MenuItem_GroupOperations
            // 
            this.MenuItem_GroupOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_GO_GroupBySelectedUnit,
            this.MenuItem_GO_SelectedUnitRemoveGroup,
            this.MenuItem_GO_GroupEditor});
            this.MenuItem_GroupOperations.Name = "MenuItem_GroupOperations";
            this.MenuItem_GroupOperations.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_GroupOperations.Text = "编组作战";
            // 
            // MenuItem_GO_GroupBySelectedUnit
            // 
            this.MenuItem_GO_GroupBySelectedUnit.Name = "MenuItem_GO_GroupBySelectedUnit";
            this.MenuItem_GO_GroupBySelectedUnit.ShortcutKeyDisplayString = "G";
            this.MenuItem_GO_GroupBySelectedUnit.Size = new System.Drawing.Size(197, 22);
            this.MenuItem_GO_GroupBySelectedUnit.Text = "将所选单元进行编组";
            this.MenuItem_GO_GroupBySelectedUnit.Click += new System.EventHandler(this.Click_GO_GroupBySelectedUnit);
            // 
            // MenuItem_GO_SelectedUnitRemoveGroup
            // 
            this.MenuItem_GO_SelectedUnitRemoveGroup.Name = "MenuItem_GO_SelectedUnitRemoveGroup";
            this.MenuItem_GO_SelectedUnitRemoveGroup.ShortcutKeyDisplayString = "D";
            this.MenuItem_GO_SelectedUnitRemoveGroup.Size = new System.Drawing.Size(197, 22);
            this.MenuItem_GO_SelectedUnitRemoveGroup.Text = "将所选单元脱离编组";
            this.MenuItem_GO_SelectedUnitRemoveGroup.Click += new System.EventHandler(this.Click_GO_SelectedUnitRemoveGroup);
            // 
            // MenuItem_GO_GroupEditor
            // 
            this.MenuItem_GO_GroupEditor.Name = "MenuItem_GO_GroupEditor";
            this.MenuItem_GO_GroupEditor.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.MenuItem_GO_GroupEditor.Size = new System.Drawing.Size(197, 22);
            this.MenuItem_GO_GroupEditor.Text = "编队编辑器";
            this.MenuItem_GO_GroupEditor.Click += new System.EventHandler(this.Click_GO_GroupEditor);
            // 
            // toolStripSeparator_33
            // 
            this.toolStripSeparator_33.Name = "toolStripSeparator_33";
            this.toolStripSeparator_33.Size = new System.Drawing.Size(342, 6);
            // 
            // MenuItem_UnassignMissionUnit
            // 
            this.MenuItem_UnassignMissionUnit.Name = "MenuItem_UnassignMissionUnit";
            this.MenuItem_UnassignMissionUnit.ShortcutKeyDisplayString = "U";
            this.MenuItem_UnassignMissionUnit.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_UnassignMissionUnit.Text = "取消单元分配的任务";
            this.MenuItem_UnassignMissionUnit.Click += new System.EventHandler(this.Click_UnassignMissionUnit);
            // 
            // MenuItem_AssignMissionToUnit
            // 
            this.MenuItem_AssignMissionToUnit.Name = "MenuItem_AssignMissionToUnit";
            this.MenuItem_AssignMissionToUnit.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_AssignMissionToUnit.Text = "给单元分配任务:";
            // 
            // MenuItem_Doctrine_RoE_EMCON_WRA
            // 
            this.MenuItem_Doctrine_RoE_EMCON_WRA.Name = "MenuItem_Doctrine_RoE_EMCON_WRA";
            this.MenuItem_Doctrine_RoE_EMCON_WRA.ShortcutKeyDisplayString = "Ctrl+F9";
            this.MenuItem_Doctrine_RoE_EMCON_WRA.Size = new System.Drawing.Size(345, 22);
            this.MenuItem_Doctrine_RoE_EMCON_WRA.Text = "作战条令/交战规则/电磁管控/武器使用规则";
            this.MenuItem_Doctrine_RoE_EMCON_WRA.Click += new System.EventHandler(this.Click_Doctrine_RoE_EMCON_WRA);
            // 
            // MenuItem_ContactTarget
            // 
            this.MenuItem_ContactTarget.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_DropTarget,
            this.toolStripSeparator_23,
            this.MenuItem_MarkHostile,
            this.MenuItem_MarkUnfriendly,
            this.MenuItem_MarkNeutral,
            this.MenuItem_MarkFriendly,
            this.toolStripSeparator_24,
            this.MenuItem_Rename,
            this.MenuItem_FilteroutAllTarget,
            this.MenuItem_CancelFilteroutAllContacts});
            this.MenuItem_ContactTarget.Name = "MenuItem_ContactTarget";
            this.MenuItem_ContactTarget.Size = new System.Drawing.Size(67, 20);
            this.MenuItem_ContactTarget.Text = "感知目标";
            this.MenuItem_ContactTarget.DropDownOpening += new System.EventHandler(this.DropDownOpening_ContactTarget);
            // 
            // MenuItem_DropTarget
            // 
            this.MenuItem_DropTarget.Name = "MenuItem_DropTarget";
            this.MenuItem_DropTarget.ShortcutKeyDisplayString = "P / PgDn /数字键3";
            this.MenuItem_DropTarget.Size = new System.Drawing.Size(224, 22);
            this.MenuItem_DropTarget.Text = "放弃目标";
            this.MenuItem_DropTarget.Click += new System.EventHandler(this.Click_DropTarget);
            // 
            // toolStripSeparator_23
            // 
            this.toolStripSeparator_23.Name = "toolStripSeparator_23";
            this.toolStripSeparator_23.Size = new System.Drawing.Size(221, 6);
            // 
            // MenuItem_MarkHostile
            // 
            this.MenuItem_MarkHostile.ForeColor = System.Drawing.Color.Red;
            this.MenuItem_MarkHostile.Name = "MenuItem_MarkHostile";
            this.MenuItem_MarkHostile.ShortcutKeyDisplayString = "H";
            this.MenuItem_MarkHostile.Size = new System.Drawing.Size(224, 22);
            this.MenuItem_MarkHostile.Text = "标识为敌方";
            this.MenuItem_MarkHostile.Click += new System.EventHandler(this.Click_MarkHostile);
            // 
            // MenuItem_MarkUnfriendly
            // 
            this.MenuItem_MarkUnfriendly.ForeColor = System.Drawing.Color.Orange;
            this.MenuItem_MarkUnfriendly.Name = "MenuItem_MarkUnfriendly";
            this.MenuItem_MarkUnfriendly.ShortcutKeyDisplayString = "Ctrl+H";
            this.MenuItem_MarkUnfriendly.Size = new System.Drawing.Size(224, 22);
            this.MenuItem_MarkUnfriendly.Text = "标识为非友方";
            this.MenuItem_MarkUnfriendly.Click += new System.EventHandler(this.Click_MarkUnfriendly);
            // 
            // MenuItem_MarkNeutral
            // 
            this.MenuItem_MarkNeutral.ForeColor = System.Drawing.Color.LimeGreen;
            this.MenuItem_MarkNeutral.Name = "MenuItem_MarkNeutral";
            this.MenuItem_MarkNeutral.ShortcutKeyDisplayString = "N";
            this.MenuItem_MarkNeutral.Size = new System.Drawing.Size(224, 22);
            this.MenuItem_MarkNeutral.Text = "标识为中立方";
            this.MenuItem_MarkNeutral.Click += new System.EventHandler(this.Click_MarkNeutral);
            // 
            // MenuItem_MarkFriendly
            // 
            this.MenuItem_MarkFriendly.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MenuItem_MarkFriendly.Name = "MenuItem_MarkFriendly";
            this.MenuItem_MarkFriendly.ShortcutKeyDisplayString = "F";
            this.MenuItem_MarkFriendly.Size = new System.Drawing.Size(224, 22);
            this.MenuItem_MarkFriendly.Text = "标识为友方";
            this.MenuItem_MarkFriendly.Click += new System.EventHandler(this.Click_MarkFriendly);
            // 
            // toolStripSeparator_24
            // 
            this.toolStripSeparator_24.Name = "toolStripSeparator_24";
            this.toolStripSeparator_24.Size = new System.Drawing.Size(221, 6);
            // 
            // MenuItem_Rename
            // 
            this.MenuItem_Rename.Name = "MenuItem_Rename";
            this.MenuItem_Rename.ShortcutKeyDisplayString = "R";
            this.MenuItem_Rename.Size = new System.Drawing.Size(224, 22);
            this.MenuItem_Rename.Text = "重新命名";
            this.MenuItem_Rename.Click += new System.EventHandler(this.Click_Rename);
            // 
            // MenuItem_FilteroutAllTarget
            // 
            this.MenuItem_FilteroutAllTarget.Name = "MenuItem_FilteroutAllTarget";
            this.MenuItem_FilteroutAllTarget.Size = new System.Drawing.Size(224, 22);
            this.MenuItem_FilteroutAllTarget.Text = "过滤所有目标";
            this.MenuItem_FilteroutAllTarget.Click += new System.EventHandler(this.Click_FilteroutAllTarget);
            // 
            // MenuItem_CancelFilteroutAllContacts
            // 
            this.MenuItem_CancelFilteroutAllContacts.Name = "MenuItem_CancelFilteroutAllContacts";
            this.MenuItem_CancelFilteroutAllContacts.Size = new System.Drawing.Size(224, 22);
            this.MenuItem_CancelFilteroutAllContacts.Text = "取消过滤所有目标";
            this.MenuItem_CancelFilteroutAllContacts.Click += new System.EventHandler(this.Click_CancelFilteroutAllContacts);
            // 
            // MenuItem_MissionAndReferencePoint
            // 
            this.MenuItem_MissionAndReferencePoint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_MissionEditor,
            this.MenuItem_NewMission,
            this.toolStripSeparator_11,
            this.MenuItem_AddReferencePoint,
            this.MenuItem_DeleteSelectedRefPoint,
            this.MenuItem_RenameSelectedRefName,
            this.MenuItem_DeselectAllRefPoint,
            this.MenuItem_DefineArea,
            this.toolStripSeparator_12,
            this.MenuItem_RelativeSelectedRefPoint_FixedBearing,
            this.MenuItem_RelativeSelectedRefPoint_RotatingBearing,
            this.MenuItem_SelectedRefPointChangeBearingToFixed,
            this.MenuItem_SelectedRefPointChangeBearingToRotating,
            this.MenuItem_SelectedRefPointRemoveRelativity,
            this.toolStripSeparator_13,
            this.MenuItem_LockSelectedRefPoint,
            this.MenuItem_UnlockSelectedRefPoint,
            this.toolStripSeparator_26,
            this.MenuItem_NoNavigationZones,
            this.MenuItem_ExclusionZones});
            this.MenuItem_MissionAndReferencePoint.Name = "MenuItem_MissionAndReferencePoint";
            this.MenuItem_MissionAndReferencePoint.Size = new System.Drawing.Size(67, 20);
            this.MenuItem_MissionAndReferencePoint.Text = "任务规划";
            this.MenuItem_MissionAndReferencePoint.MouseEnter += new System.EventHandler(this.MouseEnter_MissionAndReferencePoint);
            // 
            // MenuItem_MissionEditor
            // 
            this.MenuItem_MissionEditor.Name = "MenuItem_MissionEditor";
            this.MenuItem_MissionEditor.ShortcutKeyDisplayString = "F11";
            this.MenuItem_MissionEditor.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_MissionEditor.Text = "任务编辑";
            this.MenuItem_MissionEditor.Click += new System.EventHandler(this.Click_MissionEditor);
            // 
            // MenuItem_NewMission
            // 
            this.MenuItem_NewMission.Name = "MenuItem_NewMission";
            this.MenuItem_NewMission.ShortcutKeyDisplayString = "Ctrl+F11";
            this.MenuItem_NewMission.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_NewMission.Text = "创建任务";
            this.MenuItem_NewMission.Click += new System.EventHandler(this.Click_NewMission);
            // 
            // toolStripSeparator_11
            // 
            this.toolStripSeparator_11.Name = "toolStripSeparator_11";
            this.toolStripSeparator_11.Size = new System.Drawing.Size(250, 6);
            // 
            // MenuItem_AddReferencePoint
            // 
            this.MenuItem_AddReferencePoint.Name = "MenuItem_AddReferencePoint";
            this.MenuItem_AddReferencePoint.ShortcutKeyDisplayString = "Ctrl+Ins";
            this.MenuItem_AddReferencePoint.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_AddReferencePoint.Text = "增加参考点";
            this.MenuItem_AddReferencePoint.Click += new System.EventHandler(this.Click_AddReferencePoint);
            // 
            // MenuItem_DeleteSelectedRefPoint
            // 
            this.MenuItem_DeleteSelectedRefPoint.Name = "MenuItem_DeleteSelectedRefPoint";
            this.MenuItem_DeleteSelectedRefPoint.ShortcutKeyDisplayString = "Ctrl+Del";
            this.MenuItem_DeleteSelectedRefPoint.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_DeleteSelectedRefPoint.Text = "删除参考点";
            this.MenuItem_DeleteSelectedRefPoint.Click += new System.EventHandler(this.Click_DeleteSelectedRefPoint);
            // 
            // MenuItem_RenameSelectedRefName
            // 
            this.MenuItem_RenameSelectedRefName.Name = "MenuItem_RenameSelectedRefName";
            this.MenuItem_RenameSelectedRefName.ShortcutKeyDisplayString = "Ctrl+R";
            this.MenuItem_RenameSelectedRefName.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_RenameSelectedRefName.Text = "调整参考点名称";
            this.MenuItem_RenameSelectedRefName.Click += new System.EventHandler(this.Click_RenameSelectedRefName);
            // 
            // MenuItem_DeselectAllRefPoint
            // 
            this.MenuItem_DeselectAllRefPoint.Name = "MenuItem_DeselectAllRefPoint";
            this.MenuItem_DeselectAllRefPoint.ShortcutKeyDisplayString = "Ctrl+End";
            this.MenuItem_DeselectAllRefPoint.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_DeselectAllRefPoint.Text = "取消对所有参考点的选择";
            this.MenuItem_DeselectAllRefPoint.Click += new System.EventHandler(this.Click_DeselectAllRefPoint);
            // 
            // MenuItem_DefineArea
            // 
            this.MenuItem_DefineArea.Name = "MenuItem_DefineArea";
            this.MenuItem_DefineArea.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_DefineArea.Text = "定义区域";
            this.MenuItem_DefineArea.Click += new System.EventHandler(this.Click_DefineArea);
            // 
            // toolStripSeparator_12
            // 
            this.toolStripSeparator_12.Name = "toolStripSeparator_12";
            this.toolStripSeparator_12.Size = new System.Drawing.Size(250, 6);
            // 
            // MenuItem_RelativeSelectedRefPoint_FixedBearing
            // 
            this.MenuItem_RelativeSelectedRefPoint_FixedBearing.Name = "MenuItem_RelativeSelectedRefPoint_FixedBearing";
            this.MenuItem_RelativeSelectedRefPoint_FixedBearing.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_RelativeSelectedRefPoint_FixedBearing.Text = "关联所选参考点(固定方位)";
            this.MenuItem_RelativeSelectedRefPoint_FixedBearing.Click += new System.EventHandler(this.Click_RelativeSelectedRefPoint_FixedBearing);
            // 
            // MenuItem_RelativeSelectedRefPoint_RotatingBearing
            // 
            this.MenuItem_RelativeSelectedRefPoint_RotatingBearing.Name = "MenuItem_RelativeSelectedRefPoint_RotatingBearing";
            this.MenuItem_RelativeSelectedRefPoint_RotatingBearing.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_RelativeSelectedRefPoint_RotatingBearing.Text = "关联所选参考点(旋转方位)...";
            this.MenuItem_RelativeSelectedRefPoint_RotatingBearing.Click += new System.EventHandler(this.Click_RelativeSelectedRefPoint_RotatingBearing);
            // 
            // MenuItem_SelectedRefPointChangeBearingToFixed
            // 
            this.MenuItem_SelectedRefPointChangeBearingToFixed.Name = "MenuItem_SelectedRefPointChangeBearingToFixed";
            this.MenuItem_SelectedRefPointChangeBearingToFixed.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_SelectedRefPointChangeBearingToFixed.Text = "将所选参考点方位类型改为固定";
            this.MenuItem_SelectedRefPointChangeBearingToFixed.Click += new System.EventHandler(this.Click_SelectedRefPointChangeBearingToFixed);
            // 
            // MenuItem_SelectedRefPointChangeBearingToRotating
            // 
            this.MenuItem_SelectedRefPointChangeBearingToRotating.Name = "MenuItem_SelectedRefPointChangeBearingToRotating";
            this.MenuItem_SelectedRefPointChangeBearingToRotating.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_SelectedRefPointChangeBearingToRotating.Text = "将所选参考点方位类型改为旋转";
            this.MenuItem_SelectedRefPointChangeBearingToRotating.Click += new System.EventHandler(this.Click_SelectedRefPointChangeBearingToRotating);
            // 
            // MenuItem_SelectedRefPointRemoveRelativity
            // 
            this.MenuItem_SelectedRefPointRemoveRelativity.Name = "MenuItem_SelectedRefPointRemoveRelativity";
            this.MenuItem_SelectedRefPointRemoveRelativity.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_SelectedRefPointRemoveRelativity.Text = "取消所选参考点的方位关联";
            this.MenuItem_SelectedRefPointRemoveRelativity.Click += new System.EventHandler(this.Click_SelectedRefPointRemoveRelativity);
            // 
            // toolStripSeparator_13
            // 
            this.toolStripSeparator_13.Name = "toolStripSeparator_13";
            this.toolStripSeparator_13.Size = new System.Drawing.Size(250, 6);
            // 
            // MenuItem_LockSelectedRefPoint
            // 
            this.MenuItem_LockSelectedRefPoint.Name = "MenuItem_LockSelectedRefPoint";
            this.MenuItem_LockSelectedRefPoint.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_LockSelectedRefPoint.Text = "锁定所选参考点";
            this.MenuItem_LockSelectedRefPoint.Click += new System.EventHandler(this.Click_LockSelectedRefPoint);
            // 
            // MenuItem_UnlockSelectedRefPoint
            // 
            this.MenuItem_UnlockSelectedRefPoint.Name = "MenuItem_UnlockSelectedRefPoint";
            this.MenuItem_UnlockSelectedRefPoint.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_UnlockSelectedRefPoint.Text = "解锁所选参考点";
            this.MenuItem_UnlockSelectedRefPoint.Click += new System.EventHandler(this.Click_UnlockSelectedRefPoint);
            // 
            // toolStripSeparator_26
            // 
            this.toolStripSeparator_26.Name = "toolStripSeparator_26";
            this.toolStripSeparator_26.Size = new System.Drawing.Size(250, 6);
            // 
            // MenuItem_NoNavigationZones
            // 
            this.MenuItem_NoNavigationZones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_NNZ_EditExisting,
            this.MenuItem_NNZ_CreateBySelectedRefPoint});
            this.MenuItem_NoNavigationZones.Name = "MenuItem_NoNavigationZones";
            this.MenuItem_NoNavigationZones.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_NoNavigationZones.Text = "禁航区";
            // 
            // MenuItem_NNZ_EditExisting
            // 
            this.MenuItem_NNZ_EditExisting.Name = "MenuItem_NNZ_EditExisting";
            this.MenuItem_NNZ_EditExisting.Size = new System.Drawing.Size(182, 22);
            this.MenuItem_NNZ_EditExisting.Text = "编辑禁航区";
            this.MenuItem_NNZ_EditExisting.Click += new System.EventHandler(this.Click_NNZ_EditExisting);
            // 
            // MenuItem_NNZ_CreateBySelectedRefPoint
            // 
            this.MenuItem_NNZ_CreateBySelectedRefPoint.Name = "MenuItem_NNZ_CreateBySelectedRefPoint";
            this.MenuItem_NNZ_CreateBySelectedRefPoint.Size = new System.Drawing.Size(182, 22);
            this.MenuItem_NNZ_CreateBySelectedRefPoint.Text = "根据所选参考点创建";
            this.MenuItem_NNZ_CreateBySelectedRefPoint.Click += new System.EventHandler(this.Click_NNZ_CreateBySelectedRefPoint);
            // 
            // MenuItem_ExclusionZones
            // 
            this.MenuItem_ExclusionZones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_EZ_EditExisting,
            this.MenuItem_EZ_CreateBySelectedRefPoint});
            this.MenuItem_ExclusionZones.Name = "MenuItem_ExclusionZones";
            this.MenuItem_ExclusionZones.Size = new System.Drawing.Size(253, 22);
            this.MenuItem_ExclusionZones.Text = "封锁区";
            // 
            // MenuItem_EZ_EditExisting
            // 
            this.MenuItem_EZ_EditExisting.Name = "MenuItem_EZ_EditExisting";
            this.MenuItem_EZ_EditExisting.Size = new System.Drawing.Size(182, 22);
            this.MenuItem_EZ_EditExisting.Text = "编辑封锁区";
            this.MenuItem_EZ_EditExisting.Click += new System.EventHandler(this.Click_EZ_EditExisting);
            // 
            // MenuItem_EZ_CreateBySelectedRefPoint
            // 
            this.MenuItem_EZ_CreateBySelectedRefPoint.Name = "MenuItem_EZ_CreateBySelectedRefPoint";
            this.MenuItem_EZ_CreateBySelectedRefPoint.Size = new System.Drawing.Size(182, 22);
            this.MenuItem_EZ_CreateBySelectedRefPoint.Text = "根据所选参考点创建";
            this.MenuItem_EZ_CreateBySelectedRefPoint.Click += new System.EventHandler(this.Click_EZ_CreateBySelectedRefPoint);
            // 
            // MenuItem_ScenarioEditor
            // 
            this.MenuItem_ScenarioEditor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_ScenarioTime,
            this.MenuItem_ScenarioDescribe,
            this.toolStripSeparator_6,
            this.MenuItem_DataBase,
            this.toolStripSeparator_0,
            this.MenuItem_Battle,
            this.toolStripSeparator_31,
            this.MenuItem_NewOrEditRole,
            this.MenuItem_SwitchToRole,
            this.MenuItem_EditMissionBriefReport,
            this.MenuItem_EditScoreRules,
            this.MenuItem_DirectorView,
            this.MenuItem_TorpedoArea,
            this.toolStripSeparator_9,
            this.MenuItem_Weather,
            this.MenuItem_SimulationRealismSettings,
            this.MenuItem_EventEditor,
            this.MenuItem_SpecialAction,
            this.toolStripSeparator_1,
            this.MenuItem_UnitOperation,
            this.MenuItem_IsolatedUnitView,
            this.toolStripSeparator_4,
            this.MenuItem_DeleteOurSideAllUnit,
            this.MenuItem_ScenarioAttachment,
            this.MenuItem_PublishScenarioToSimulationServer,
            this.MenuItem_ScenarioPackingPublish,
            this.MenuItem_UnitImportAndExport,
            this.MenuItem_ScenarioMigration,
            this.MenuItem_ScriptEditor,
            this.MenuItem_ReturnTo,
            this.MenuItem_MonteCarloSimulation});
            this.MenuItem_ScenarioEditor.Name = "MenuItem_ScenarioEditor";
            this.MenuItem_ScenarioEditor.Size = new System.Drawing.Size(67, 20);
            this.MenuItem_ScenarioEditor.Text = "想定编辑";
            this.MenuItem_ScenarioEditor.Visible = false;
            this.MenuItem_ScenarioEditor.DropDownOpening += new System.EventHandler(this.DropDownOpening_ScenarioEditor);
            // 
            // MenuItem_ScenarioTime
            // 
            this.MenuItem_ScenarioTime.Name = "MenuItem_ScenarioTime";
            this.MenuItem_ScenarioTime.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_ScenarioTime.Text = "想定时间";
            this.MenuItem_ScenarioTime.Click += new System.EventHandler(this.Click_ScenarioTime);
            // 
            // MenuItem_ScenarioDescribe
            // 
            this.MenuItem_ScenarioDescribe.Name = "MenuItem_ScenarioDescribe";
            this.MenuItem_ScenarioDescribe.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_ScenarioDescribe.Text = "想定描述";
            this.MenuItem_ScenarioDescribe.Click += new System.EventHandler(this.Click_ScenarioDescribe);
            // 
            // toolStripSeparator_6
            // 
            this.toolStripSeparator_6.Name = "toolStripSeparator_6";
            this.toolStripSeparator_6.Size = new System.Drawing.Size(237, 6);
            // 
            // MenuItem_DataBase
            // 
            this.MenuItem_DataBase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_DB_ChangeDB,
            this.MenuItem_DB_SecnarioDataUpdateToLatestVersion,
            this.MenuItem_DB_SecnarioDataBandingToCustomDB});
            this.MenuItem_DataBase.Name = "MenuItem_DataBase";
            this.MenuItem_DataBase.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_DataBase.Text = "数据库";
            // 
            // MenuItem_DB_ChangeDB
            // 
            this.MenuItem_DB_ChangeDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_DB_CDB_Waiting});
            this.MenuItem_DB_ChangeDB.Name = "MenuItem_DB_ChangeDB";
            this.MenuItem_DB_ChangeDB.Size = new System.Drawing.Size(278, 22);
            this.MenuItem_DB_ChangeDB.Text = "变更数据库";
            // 
            // MenuItem_DB_CDB_Waiting
            // 
            this.MenuItem_DB_CDB_Waiting.Name = "MenuItem_DB_CDB_Waiting";
            this.MenuItem_DB_CDB_Waiting.Size = new System.Drawing.Size(275, 22);
            this.MenuItem_DB_CDB_Waiting.Text = "正在扫描数据库，请几秒后重新尝试...";
            // 
            // MenuItem_DB_SecnarioDataUpdateToLatestVersion
            // 
            this.MenuItem_DB_SecnarioDataUpdateToLatestVersion.Name = "MenuItem_DB_SecnarioDataUpdateToLatestVersion";
            this.MenuItem_DB_SecnarioDataUpdateToLatestVersion.Size = new System.Drawing.Size(278, 22);
            this.MenuItem_DB_SecnarioDataUpdateToLatestVersion.Text = "将想定所用数据升级到最新数据库版本";
            this.MenuItem_DB_SecnarioDataUpdateToLatestVersion.Click += new System.EventHandler(this.Click_DB_SecnarioDataUpdateToLatestVersion);
            // 
            // MenuItem_DB_SecnarioDataBandingToCustomDB
            // 
            this.MenuItem_DB_SecnarioDataBandingToCustomDB.Name = "MenuItem_DB_SecnarioDataBandingToCustomDB";
            this.MenuItem_DB_SecnarioDataBandingToCustomDB.Size = new System.Drawing.Size(278, 22);
            this.MenuItem_DB_SecnarioDataBandingToCustomDB.Text = "将想定所有数据库绑定到自定义数据库";
            this.MenuItem_DB_SecnarioDataBandingToCustomDB.Click += new System.EventHandler(this.Click_DB_SecnarioDataBandingToCustomDB);
            // 
            // toolStripSeparator_0
            // 
            this.toolStripSeparator_0.Name = "toolStripSeparator_0";
            this.toolStripSeparator_0.Size = new System.Drawing.Size(237, 6);
            // 
            // MenuItem_Battle
            // 
            this.MenuItem_Battle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Battle_New,
            this.MenuItem_Battle_LoadForFile});
            this.MenuItem_Battle.Name = "MenuItem_Battle";
            this.MenuItem_Battle.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_Battle.Text = "战役";
            // 
            // MenuItem_Battle_New
            // 
            this.MenuItem_Battle_New.Name = "MenuItem_Battle_New";
            this.MenuItem_Battle_New.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_Battle_New.Text = "新建";
            this.MenuItem_Battle_New.Click += new System.EventHandler(this.Click_Battle_New);
            // 
            // MenuItem_Battle_LoadForFile
            // 
            this.MenuItem_Battle_LoadForFile.Name = "MenuItem_Battle_LoadForFile";
            this.MenuItem_Battle_LoadForFile.Size = new System.Drawing.Size(134, 22);
            this.MenuItem_Battle_LoadForFile.Text = "从文件加载";
            this.MenuItem_Battle_LoadForFile.Click += new System.EventHandler(this.Click_Battle_LoadForFile);
            // 
            // toolStripSeparator_31
            // 
            this.toolStripSeparator_31.Name = "toolStripSeparator_31";
            this.toolStripSeparator_31.Size = new System.Drawing.Size(237, 6);
            // 
            // MenuItem_NewOrEditRole
            // 
            this.MenuItem_NewOrEditRole.Name = "MenuItem_NewOrEditRole";
            this.MenuItem_NewOrEditRole.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_NewOrEditRole.Text = "新建/编辑推演方";
            this.MenuItem_NewOrEditRole.Click += new System.EventHandler(this.Click_NewOrEditRole);
            // 
            // MenuItem_SwitchToRole
            // 
            this.MenuItem_SwitchToRole.Name = "MenuItem_SwitchToRole";
            this.MenuItem_SwitchToRole.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_SwitchToRole.Text = "切换到...";
            // 
            // MenuItem_EditMissionBriefReport
            // 
            this.MenuItem_EditMissionBriefReport.Name = "MenuItem_EditMissionBriefReport";
            this.MenuItem_EditMissionBriefReport.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_EditMissionBriefReport.Text = "编辑任务简报";
            this.MenuItem_EditMissionBriefReport.Click += new System.EventHandler(this.Click_EditMissionBriefReport);
            // 
            // MenuItem_EditScoreRules
            // 
            this.MenuItem_EditScoreRules.Name = "MenuItem_EditScoreRules";
            this.MenuItem_EditScoreRules.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_EditScoreRules.Text = "编辑评分规则";
            this.MenuItem_EditScoreRules.Click += new System.EventHandler(this.Click_EditScoreRules);
            // 
            // MenuItem_DirectorView
            // 
            this.MenuItem_DirectorView.Name = "MenuItem_DirectorView";
            this.MenuItem_DirectorView.ShortcutKeyDisplayString = "Ctrl+V";
            this.MenuItem_DirectorView.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_DirectorView.Text = "导演视图 (看到各方)";
            this.MenuItem_DirectorView.Click += new System.EventHandler(this.Click_DirectorView);
            // 
            // MenuItem_TorpedoArea
            // 
            this.MenuItem_TorpedoArea.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_TA_DesignatedAreaMine,
            this.MenuItem_TA_DesignatedAreaMineClearance});
            this.MenuItem_TorpedoArea.Name = "MenuItem_TorpedoArea";
            this.MenuItem_TorpedoArea.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_TorpedoArea.Text = "水雷区";
            // 
            // MenuItem_TA_DesignatedAreaMine
            // 
            this.MenuItem_TA_DesignatedAreaMine.Name = "MenuItem_TA_DesignatedAreaMine";
            this.MenuItem_TA_DesignatedAreaMine.Size = new System.Drawing.Size(158, 22);
            this.MenuItem_TA_DesignatedAreaMine.Text = "为指定区域布雷";
            this.MenuItem_TA_DesignatedAreaMine.Click += new System.EventHandler(this.Click_TA_DesignatedAreaMine);
            // 
            // MenuItem_TA_DesignatedAreaMineClearance
            // 
            this.MenuItem_TA_DesignatedAreaMineClearance.Name = "MenuItem_TA_DesignatedAreaMineClearance";
            this.MenuItem_TA_DesignatedAreaMineClearance.Size = new System.Drawing.Size(158, 22);
            this.MenuItem_TA_DesignatedAreaMineClearance.Text = "为指定区域扫雷";
            this.MenuItem_TA_DesignatedAreaMineClearance.Click += new System.EventHandler(this.Click_TA_DesignatedAreaMineClearance);
            // 
            // toolStripSeparator_9
            // 
            this.toolStripSeparator_9.Name = "toolStripSeparator_9";
            this.toolStripSeparator_9.Size = new System.Drawing.Size(237, 6);
            // 
            // MenuItem_Weather
            // 
            this.MenuItem_Weather.Name = "MenuItem_Weather";
            this.MenuItem_Weather.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_Weather.Text = "天气";
            this.MenuItem_Weather.Click += new System.EventHandler(this.Click_Weather);
            // 
            // MenuItem_SimulationRealismSettings
            // 
            this.MenuItem_SimulationRealismSettings.Name = "MenuItem_SimulationRealismSettings";
            this.MenuItem_SimulationRealismSettings.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_SimulationRealismSettings.Text = "仿真精细度设置";
            this.MenuItem_SimulationRealismSettings.Click += new System.EventHandler(this.Click_SimulationRealismSettings);
            // 
            // MenuItem_EventEditor
            // 
            this.MenuItem_EventEditor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_EE_Event,
            this.MenuItem_EE_Trigger,
            this.MenuItem_EE_Condition,
            this.MenuItem_EE_Action,
            this.MenuItem_EE_SpecialEvent});
            this.MenuItem_EventEditor.Name = "MenuItem_EventEditor";
            this.MenuItem_EventEditor.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_EventEditor.Text = "事件编辑器";
            // 
            // MenuItem_EE_Event
            // 
            this.MenuItem_EE_Event.Name = "MenuItem_EE_Event";
            this.MenuItem_EE_Event.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_EE_Event.Text = "事件";
            this.MenuItem_EE_Event.Click += new System.EventHandler(this.Click_EE_Event);
            // 
            // MenuItem_EE_Trigger
            // 
            this.MenuItem_EE_Trigger.Name = "MenuItem_EE_Trigger";
            this.MenuItem_EE_Trigger.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_EE_Trigger.Text = "触发器";
            this.MenuItem_EE_Trigger.Click += new System.EventHandler(this.Click_EE_Trigger);
            // 
            // MenuItem_EE_Condition
            // 
            this.MenuItem_EE_Condition.Name = "MenuItem_EE_Condition";
            this.MenuItem_EE_Condition.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_EE_Condition.Text = "条件";
            this.MenuItem_EE_Condition.Click += new System.EventHandler(this.Click_EE_Condition);
            // 
            // MenuItem_EE_Action
            // 
            this.MenuItem_EE_Action.Name = "MenuItem_EE_Action";
            this.MenuItem_EE_Action.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_EE_Action.Text = "动作";
            this.MenuItem_EE_Action.Click += new System.EventHandler(this.Click_EE_Action);
            // 
            // MenuItem_EE_SpecialEvent
            // 
            this.MenuItem_EE_SpecialEvent.Name = "MenuItem_EE_SpecialEvent";
            this.MenuItem_EE_SpecialEvent.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_EE_SpecialEvent.Text = "特殊事件";
            this.MenuItem_EE_SpecialEvent.Click += new System.EventHandler(this.Click_EE_SpecialEvent);
            // 
            // MenuItem_SpecialAction
            // 
            this.MenuItem_SpecialAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_SA_CreateTemplate,
            this.MenuItem_SA_CreateDeltaTemplate,
            this.MenuItem_SA_UseSpecialEventScript});
            this.MenuItem_SpecialAction.Name = "MenuItem_SpecialAction";
            this.MenuItem_SpecialAction.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_SpecialAction.Text = "特殊动作";
            // 
            // MenuItem_SA_CreateTemplate
            // 
            this.MenuItem_SA_CreateTemplate.Name = "MenuItem_SA_CreateTemplate";
            this.MenuItem_SA_CreateTemplate.Size = new System.Drawing.Size(170, 22);
            this.MenuItem_SA_CreateTemplate.Text = "创建模板";
            this.MenuItem_SA_CreateTemplate.Click += new System.EventHandler(this.Click_SA_CreateTemplate);
            // 
            // MenuItem_SA_CreateDeltaTemplate
            // 
            this.MenuItem_SA_CreateDeltaTemplate.Name = "MenuItem_SA_CreateDeltaTemplate";
            this.MenuItem_SA_CreateDeltaTemplate.Size = new System.Drawing.Size(170, 22);
            this.MenuItem_SA_CreateDeltaTemplate.Text = "创建Delta模板";
            this.MenuItem_SA_CreateDeltaTemplate.Click += new System.EventHandler(this.Click_SA_CreateDeltaTemplate);
            // 
            // MenuItem_SA_UseSpecialEventScript
            // 
            this.MenuItem_SA_UseSpecialEventScript.Name = "MenuItem_SA_UseSpecialEventScript";
            this.MenuItem_SA_UseSpecialEventScript.Size = new System.Drawing.Size(170, 22);
            this.MenuItem_SA_UseSpecialEventScript.Text = "应用特殊事件脚本";
            this.MenuItem_SA_UseSpecialEventScript.Click += new System.EventHandler(this.Click_SA_UseSpecialEventScript);
            // 
            // toolStripSeparator_1
            // 
            this.toolStripSeparator_1.Name = "toolStripSeparator_1";
            this.toolStripSeparator_1.Size = new System.Drawing.Size(237, 6);
            // 
            // MenuItem_UnitOperation
            // 
            this.MenuItem_UnitOperation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_UO_AddUnit,
            this.MenuItem_UO_AddSatellite,
            this.MenuItem_UO_EditWarplane,
            this.MenuItem_UO_EditBerthedBoats,
            this.MenuItem_UO_EditCargo,
            this.MenuItem_UO_CopyUnit,
            this.MenuItem_UO_CloneUnit,
            this.MenuItem_UO_MoveUnit,
            this.MenuItem_UO_RenameUnit,
            this.MenuItem_UO_DeleteUnit,
            this.MenuItem_UO_SetOilAndHangTime,
            this.MenuItem_UO_UnitAutoDetected,
            this.MenuItem_UO_SettingBearing,
            this.MenuItem_UO_HoldPositon});
            this.MenuItem_UnitOperation.Name = "MenuItem_UnitOperation";
            this.MenuItem_UnitOperation.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_UnitOperation.Text = "作战单元操作";
            // 
            // MenuItem_UO_AddUnit
            // 
            this.MenuItem_UO_AddUnit.Name = "MenuItem_UO_AddUnit";
            this.MenuItem_UO_AddUnit.ShortcutKeyDisplayString = "Ins";
            this.MenuItem_UO_AddUnit.Size = new System.Drawing.Size(198, 22);
            this.MenuItem_UO_AddUnit.Text = "添加单元";
            this.MenuItem_UO_AddUnit.Click += new System.EventHandler(this.Click_UO_AddUnit);
            // 
            // MenuItem_UO_AddSatellite
            // 
            this.MenuItem_UO_AddSatellite.Name = "MenuItem_UO_AddSatellite";
            this.MenuItem_UO_AddSatellite.Size = new System.Drawing.Size(198, 22);
            this.MenuItem_UO_AddSatellite.Text = "添加卫星";
            this.MenuItem_UO_AddSatellite.Click += new System.EventHandler(this.Click_UO_AddSatellite);
            // 
            // MenuItem_UO_EditWarplane
            // 
            this.MenuItem_UO_EditWarplane.Name = "MenuItem_UO_EditWarplane";
            this.MenuItem_UO_EditWarplane.ShortcutKeyDisplayString = "Ctrl+F6";
            this.MenuItem_UO_EditWarplane.Size = new System.Drawing.Size(198, 22);
            this.MenuItem_UO_EditWarplane.Text = "编辑飞机";
            this.MenuItem_UO_EditWarplane.Click += new System.EventHandler(this.Click_UO_EditWarplane);
            // 
            // MenuItem_UO_EditBerthedBoats
            // 
            this.MenuItem_UO_EditBerthedBoats.Name = "MenuItem_UO_EditBerthedBoats";
            this.MenuItem_UO_EditBerthedBoats.ShortcutKeyDisplayString = "Ctrl+F7";
            this.MenuItem_UO_EditBerthedBoats.Size = new System.Drawing.Size(198, 22);
            this.MenuItem_UO_EditBerthedBoats.Text = "编辑停靠的舰船";
            this.MenuItem_UO_EditBerthedBoats.Click += new System.EventHandler(this.Click_UO_EditBerthedBoats);
            // 
            // MenuItem_UO_EditCargo
            // 
            this.MenuItem_UO_EditCargo.Name = "MenuItem_UO_EditCargo";
            this.MenuItem_UO_EditCargo.Size = new System.Drawing.Size(198, 22);
            this.MenuItem_UO_EditCargo.Text = "编辑货物";
            this.MenuItem_UO_EditCargo.Click += new System.EventHandler(this.Click_UO_EditCargo);
            // 
            // MenuItem_UO_CopyUnit
            // 
            this.MenuItem_UO_CopyUnit.Name = "MenuItem_UO_CopyUnit";
            this.MenuItem_UO_CopyUnit.ShortcutKeyDisplayString = "C";
            this.MenuItem_UO_CopyUnit.Size = new System.Drawing.Size(198, 22);
            this.MenuItem_UO_CopyUnit.Text = "复制单元";
            this.MenuItem_UO_CopyUnit.Click += new System.EventHandler(this.Click_UO_CopyUnit);
            // 
            // MenuItem_UO_CloneUnit
            // 
            this.MenuItem_UO_CloneUnit.Name = "MenuItem_UO_CloneUnit";
            this.MenuItem_UO_CloneUnit.ShortcutKeyDisplayString = "Shift+C";
            this.MenuItem_UO_CloneUnit.Size = new System.Drawing.Size(198, 22);
            this.MenuItem_UO_CloneUnit.Text = "克隆单元";
            this.MenuItem_UO_CloneUnit.Click += new System.EventHandler(this.Click_UO_CloneUnit);
            // 
            // MenuItem_UO_MoveUnit
            // 
            this.MenuItem_UO_MoveUnit.Name = "MenuItem_UO_MoveUnit";
            this.MenuItem_UO_MoveUnit.ShortcutKeyDisplayString = "m";
            this.MenuItem_UO_MoveUnit.Size = new System.Drawing.Size(198, 22);
            this.MenuItem_UO_MoveUnit.Text = "移动单元";
            this.MenuItem_UO_MoveUnit.Click += new System.EventHandler(this.Click_UO_MoveUnit);
            // 
            // MenuItem_UO_RenameUnit
            // 
            this.MenuItem_UO_RenameUnit.Name = "MenuItem_UO_RenameUnit";
            this.MenuItem_UO_RenameUnit.ShortcutKeyDisplayString = "R";
            this.MenuItem_UO_RenameUnit.Size = new System.Drawing.Size(198, 22);
            this.MenuItem_UO_RenameUnit.Text = "调整单元名称";
            this.MenuItem_UO_RenameUnit.Click += new System.EventHandler(this.Click_UO_RenameUnit);
            // 
            // MenuItem_UO_DeleteUnit
            // 
            this.MenuItem_UO_DeleteUnit.Name = "MenuItem_UO_DeleteUnit";
            this.MenuItem_UO_DeleteUnit.ShortcutKeyDisplayString = "Del";
            this.MenuItem_UO_DeleteUnit.Size = new System.Drawing.Size(198, 22);
            this.MenuItem_UO_DeleteUnit.Text = "删除单元";
            this.MenuItem_UO_DeleteUnit.Click += new System.EventHandler(this.Click_UO_DeleteUnit);
            // 
            // MenuItem_UO_SetOilAndHangTime
            // 
            this.MenuItem_UO_SetOilAndHangTime.Name = "MenuItem_UO_SetOilAndHangTime";
            this.MenuItem_UO_SetOilAndHangTime.Size = new System.Drawing.Size(198, 22);
            this.MenuItem_UO_SetOilAndHangTime.Text = "设置油量与留空时间";
            this.MenuItem_UO_SetOilAndHangTime.Click += new System.EventHandler(this.Click_UO_SetOilAndHangTime);
            // 
            // MenuItem_UO_UnitAutoDetected
            // 
            this.MenuItem_UO_UnitAutoDetected.Name = "MenuItem_UO_UnitAutoDetected";
            this.MenuItem_UO_UnitAutoDetected.Size = new System.Drawing.Size(198, 22);
            this.MenuItem_UO_UnitAutoDetected.Text = "单元自动探测到";
            this.MenuItem_UO_UnitAutoDetected.Click += new System.EventHandler(this.Click_UO_UnitAutoDetected);
            // 
            // MenuItem_UO_SettingBearing
            // 
            this.MenuItem_UO_SettingBearing.Name = "MenuItem_UO_SettingBearing";
            this.MenuItem_UO_SettingBearing.Size = new System.Drawing.Size(198, 22);
            this.MenuItem_UO_SettingBearing.Text = "设置方位";
            this.MenuItem_UO_SettingBearing.Click += new System.EventHandler(this.Click_UO_SettingBearing);
            // 
            // MenuItem_UO_HoldPositon
            // 
            this.MenuItem_UO_HoldPositon.Name = "MenuItem_UO_HoldPositon";
            this.MenuItem_UO_HoldPositon.Size = new System.Drawing.Size(198, 22);
            this.MenuItem_UO_HoldPositon.Text = "保持阵位";
            this.MenuItem_UO_HoldPositon.Click += new System.EventHandler(this.Click_UO_HoldPositon);
            // 
            // MenuItem_IsolatedUnitView
            // 
            this.MenuItem_IsolatedUnitView.Name = "MenuItem_IsolatedUnitView";
            this.MenuItem_IsolatedUnitView.ShortcutKeyDisplayString = "Ctrl+Shift+I";
            this.MenuItem_IsolatedUnitView.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_IsolatedUnitView.Text = "隔离的作战单元视图";
            this.MenuItem_IsolatedUnitView.Click += new System.EventHandler(this.Click_IsolatedUnitView);
            // 
            // toolStripSeparator_4
            // 
            this.toolStripSeparator_4.Name = "toolStripSeparator_4";
            this.toolStripSeparator_4.Size = new System.Drawing.Size(237, 6);
            // 
            // MenuItem_DeleteOurSideAllUnit
            // 
            this.MenuItem_DeleteOurSideAllUnit.Name = "MenuItem_DeleteOurSideAllUnit";
            this.MenuItem_DeleteOurSideAllUnit.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_DeleteOurSideAllUnit.Text = "删除本方所有单元";
            this.MenuItem_DeleteOurSideAllUnit.Click += new System.EventHandler(this.Click_DeleteOurSideAllUnit);
            // 
            // MenuItem_ScenarioAttachment
            // 
            this.MenuItem_ScenarioAttachment.Name = "MenuItem_ScenarioAttachment";
            this.MenuItem_ScenarioAttachment.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_ScenarioAttachment.Text = "想定附件";
            this.MenuItem_ScenarioAttachment.Click += new System.EventHandler(this.Click_ScenarioAttachment);
            // 
            // MenuItem_PublishScenarioToSimulationServer
            // 
            this.MenuItem_PublishScenarioToSimulationServer.Name = "MenuItem_PublishScenarioToSimulationServer";
            this.MenuItem_PublishScenarioToSimulationServer.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_PublishScenarioToSimulationServer.Text = "发布想定到推演服务器";
            this.MenuItem_PublishScenarioToSimulationServer.Click += new System.EventHandler(this.Click_PublishScenarioToSimulationServer);
            // 
            // MenuItem_ScenarioPackingPublish
            // 
            this.MenuItem_ScenarioPackingPublish.Name = "MenuItem_ScenarioPackingPublish";
            this.MenuItem_ScenarioPackingPublish.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_ScenarioPackingPublish.Text = "想定打包发布";
            this.MenuItem_ScenarioPackingPublish.Click += new System.EventHandler(this.Click_ScenarioPackingPublish);
            // 
            // MenuItem_UnitImportAndExport
            // 
            this.MenuItem_UnitImportAndExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_UIAE_SelectedUnitOrGroupSaveAsFile,
            this.MenuItem_UIAE_LoadUnitOrGroupForFile});
            this.MenuItem_UnitImportAndExport.Name = "MenuItem_UnitImportAndExport";
            this.MenuItem_UnitImportAndExport.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_UnitImportAndExport.Text = "单元导入/导出";
            // 
            // MenuItem_UIAE_SelectedUnitOrGroupSaveAsFile
            // 
            this.MenuItem_UIAE_SelectedUnitOrGroupSaveAsFile.Name = "MenuItem_UIAE_SelectedUnitOrGroupSaveAsFile";
            this.MenuItem_UIAE_SelectedUnitOrGroupSaveAsFile.Size = new System.Drawing.Size(235, 22);
            this.MenuItem_UIAE_SelectedUnitOrGroupSaveAsFile.Text = "将所选的单元/编组保存到文件";
            this.MenuItem_UIAE_SelectedUnitOrGroupSaveAsFile.Click += new System.EventHandler(this.Click_UIAE_SelectedUnitOrGroupSaveAsFile);
            // 
            // MenuItem_UIAE_LoadUnitOrGroupForFile
            // 
            this.MenuItem_UIAE_LoadUnitOrGroupForFile.Name = "MenuItem_UIAE_LoadUnitOrGroupForFile";
            this.MenuItem_UIAE_LoadUnitOrGroupForFile.Size = new System.Drawing.Size(235, 22);
            this.MenuItem_UIAE_LoadUnitOrGroupForFile.Text = "从文件中加载单元/编组";
            this.MenuItem_UIAE_LoadUnitOrGroupForFile.Click += new System.EventHandler(this.Click_UIAE_LoadUnitOrGroupForFile);
            // 
            // MenuItem_ScenarioMigration
            // 
            this.MenuItem_ScenarioMigration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_SM_ExportToFile,
            this.MenuItem_SM_ImportForFile,
            this.MenuItem_SM_TransformToXML});
            this.MenuItem_ScenarioMigration.Name = "MenuItem_ScenarioMigration";
            this.MenuItem_ScenarioMigration.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_ScenarioMigration.Text = "想定迁移";
            // 
            // MenuItem_SM_ExportToFile
            // 
            this.MenuItem_SM_ExportToFile.Name = "MenuItem_SM_ExportToFile";
            this.MenuItem_SM_ExportToFile.Size = new System.Drawing.Size(155, 22);
            this.MenuItem_SM_ExportToFile.Text = "导出到文件...";
            this.MenuItem_SM_ExportToFile.Click += new System.EventHandler(this.Click_SM_ExportToFile);
            // 
            // MenuItem_SM_ImportForFile
            // 
            this.MenuItem_SM_ImportForFile.Name = "MenuItem_SM_ImportForFile";
            this.MenuItem_SM_ImportForFile.Size = new System.Drawing.Size(155, 22);
            this.MenuItem_SM_ImportForFile.Text = "从文件中导入...";
            this.MenuItem_SM_ImportForFile.Click += new System.EventHandler(this.Click_SM_ImportForFile);
            // 
            // MenuItem_SM_TransformToXML
            // 
            this.MenuItem_SM_TransformToXML.Name = "MenuItem_SM_TransformToXML";
            this.MenuItem_SM_TransformToXML.Size = new System.Drawing.Size(155, 22);
            this.MenuItem_SM_TransformToXML.Text = ".scen转为XML";
            this.MenuItem_SM_TransformToXML.Click += new System.EventHandler(this.Click_SM_TransformToXML);
            // 
            // MenuItem_ScriptEditor
            // 
            this.MenuItem_ScriptEditor.Name = "MenuItem_ScriptEditor";
            this.MenuItem_ScriptEditor.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_ScriptEditor.Text = "脚本编辑";
            this.MenuItem_ScriptEditor.Click += new System.EventHandler(this.Click_ScriptEditor);
            // 
            // MenuItem_ReturnTo
            // 
            this.MenuItem_ReturnTo.Enabled = false;
            this.MenuItem_ReturnTo.Name = "MenuItem_ReturnTo";
            this.MenuItem_ReturnTo.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_ReturnTo.Text = "返回到...";
            // 
            // MenuItem_MonteCarloSimulation
            // 
            this.MenuItem_MonteCarloSimulation.Name = "MenuItem_MonteCarloSimulation";
            this.MenuItem_MonteCarloSimulation.Size = new System.Drawing.Size(240, 22);
            this.MenuItem_MonteCarloSimulation.Text = "蒙特卡洛仿真";
            this.MenuItem_MonteCarloSimulation.Click += new System.EventHandler(this.Click_MonteCarloSimulation);
            // 
            // toolStripMenuItem_1
            // 
            this.toolStripMenuItem_1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_HotKey,
            this.MenuItem_Tutorials,
            this.toolStripSeparator_29,
            this.MenuItem_About});
            this.toolStripMenuItem_1.Name = "toolStripMenuItem_1";
            this.toolStripMenuItem_1.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem_1.Text = "在线帮助";
            // 
            // MenuItem_HotKey
            // 
            this.MenuItem_HotKey.Name = "MenuItem_HotKey";
            this.MenuItem_HotKey.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_HotKey.Text = "热键";
            this.MenuItem_HotKey.Click += new System.EventHandler(this.Click_HotKey);
            // 
            // MenuItem_Tutorials
            // 
            this.MenuItem_Tutorials.Name = "MenuItem_Tutorials";
            this.MenuItem_Tutorials.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_Tutorials.Text = "教学案例";
            this.MenuItem_Tutorials.Click += new System.EventHandler(this.Click_Tutorials);
            // 
            // toolStripSeparator_29
            // 
            this.toolStripSeparator_29.Name = "toolStripSeparator_29";
            this.toolStripSeparator_29.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Name = "MenuItem_About";
            this.MenuItem_About.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_About.Text = "关于CommandX";
            this.MenuItem_About.Click += new System.EventHandler(this.Click_About);
            // 
            // MenuItem_TestScript
            // 
            this.MenuItem_TestScript.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_19,
            this.MenuItem_AU_AddUnit4});
            this.MenuItem_TestScript.Name = "MenuItem_TestScript";
            this.MenuItem_TestScript.Size = new System.Drawing.Size(67, 20);
            this.MenuItem_TestScript.Text = "测试脚本";
            // 
            // toolStripMenuItem_19
            // 
            this.toolStripMenuItem_19.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AU_AddUnit0,
            this.MenuItem_AU_AddUnit1,
            this.MenuItem_AU_AddUnit2,
            this.MenuItem_AU_AddUnit3,
            this.toolStripMenuItem_32,
            this.toolStripMenuItem_35,
            this.toolStripMenuItem_63});
            this.toolStripMenuItem_19.Name = "toolStripMenuItem_19";
            this.toolStripMenuItem_19.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem_19.Text = "DB3000";
            // 
            // MenuItem_AU_AddUnit0
            // 
            this.MenuItem_AU_AddUnit0.Name = "MenuItem_AU_AddUnit0";
            this.MenuItem_AU_AddUnit0.Size = new System.Drawing.Size(204, 22);
            this.MenuItem_AU_AddUnit0.Text = "#1 (A2A)";
            this.MenuItem_AU_AddUnit0.Click += new System.EventHandler(this.method_167);
            // 
            // MenuItem_AU_AddUnit1
            // 
            this.MenuItem_AU_AddUnit1.Name = "MenuItem_AU_AddUnit1";
            this.MenuItem_AU_AddUnit1.Size = new System.Drawing.Size(204, 22);
            this.MenuItem_AU_AddUnit1.Text = "#2 (ASuW + AAW)";
            this.MenuItem_AU_AddUnit1.Click += new System.EventHandler(this.method_168);
            // 
            // MenuItem_AU_AddUnit2
            // 
            this.MenuItem_AU_AddUnit2.Name = "MenuItem_AU_AddUnit2";
            this.MenuItem_AU_AddUnit2.Size = new System.Drawing.Size(204, 22);
            this.MenuItem_AU_AddUnit2.Text = "#3 (Mike)";
            this.MenuItem_AU_AddUnit2.Click += new System.EventHandler(this.method_169);
            // 
            // MenuItem_AU_AddUnit3
            // 
            this.MenuItem_AU_AddUnit3.Name = "MenuItem_AU_AddUnit3";
            this.MenuItem_AU_AddUnit3.Size = new System.Drawing.Size(204, 22);
            this.MenuItem_AU_AddUnit3.Text = "#4 (Group + Air Ops)";
            this.MenuItem_AU_AddUnit3.Click += new System.EventHandler(this.method_170);
            // 
            // toolStripMenuItem_32
            // 
            this.toolStripMenuItem_32.Enabled = false;
            this.toolStripMenuItem_32.Name = "toolStripMenuItem_32";
            this.toolStripMenuItem_32.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem_32.Text = "#5 (Iran)";
            this.toolStripMenuItem_32.Click += new System.EventHandler(this.method_181);
            // 
            // toolStripMenuItem_35
            // 
            this.toolStripMenuItem_35.Name = "toolStripMenuItem_35";
            this.toolStripMenuItem_35.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem_35.Text = "#6 (LOS + Terrain masking)";
            this.toolStripMenuItem_35.Click += new System.EventHandler(this.method_187);
            // 
            // toolStripMenuItem_63
            // 
            this.toolStripMenuItem_63.Name = "toolStripMenuItem_63";
            this.toolStripMenuItem_63.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem_63.Text = "#7 (ESM freeze bug)";
            this.toolStripMenuItem_63.Click += new System.EventHandler(this.method_234);
            // 
            // MenuItem_AU_AddUnit4
            // 
            this.MenuItem_AU_AddUnit4.Name = "MenuItem_AU_AddUnit4";
            this.MenuItem_AU_AddUnit4.Size = new System.Drawing.Size(139, 22);
            this.MenuItem_AU_AddUnit4.Text = "Colonial Wars";
            // 
            // toolStripMenuItem_61
            // 
            this.toolStripMenuItem_61.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_62});
            this.toolStripMenuItem_61.Name = "toolStripMenuItem_61";
            this.toolStripMenuItem_61.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem_61.Text = "Testing";
            // 
            // toolStripMenuItem_62
            // 
            this.toolStripMenuItem_62.Name = "toolStripMenuItem_62";
            this.toolStripMenuItem_62.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_62.Text = "Regression tests";
            this.toolStripMenuItem_62.Click += new System.EventHandler(this.method_233);
            // 
            // toolStrip_0
            // 
            this.toolStrip_0.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStrip_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.toolStrip_0.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_0.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Label_GameRunSpeed,
            this.toolStripComboBox_0,
            this.Label_GameRunMode,
            this.toolStripComboBox_1,
            this.toolStripSeparator_14,
            this.Button_StartOrRecover,
            this.toolStripSeparator_7,
            this.Button_CustomLayer,
            this.toolStripSeparator_8,
            this.Button_VideoRecord,
            this.toolStripSeparator_36,
            this.Button_GameSpeed});
            this.toolStrip_0.Location = new System.Drawing.Point(0, 24);
            this.toolStrip_0.Name = "toolStrip_0";
            this.toolStrip_0.Size = new System.Drawing.Size(1016, 25);
            this.toolStrip_0.TabIndex = 1;
            this.toolStrip_0.Text = "ToolStrip1";
            // 
            // Label_GameRunSpeed
            // 
            this.Label_GameRunSpeed.Name = "Label_GameRunSpeed";
            this.Label_GameRunSpeed.Size = new System.Drawing.Size(58, 22);
            this.Label_GameRunSpeed.Text = "推进速度:";
            // 
            // toolStripComboBox_0
            // 
            this.toolStripComboBox_0.AutoToolTip = true;
            this.toolStripComboBox_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_0.Items.AddRange(new object[] {
            "1秒(实时)",
            "2秒(2x)",
            "5秒(5x)",
            "15秒(15x)",
            "30秒(30x)",
            "1分钟(60x)",
            "5分钟(300x)",
            "15分钟(900x)",
            "30分钟(1800x)"});
            this.toolStripComboBox_0.Name = "toolStripComboBox_0";
            this.toolStripComboBox_0.Size = new System.Drawing.Size(100, 25);
            // 
            // Label_GameRunMode
            // 
            this.Label_GameRunMode.Name = "Label_GameRunMode";
            this.Label_GameRunMode.Size = new System.Drawing.Size(58, 22);
            this.Label_GameRunMode.Text = "推进模式:";
            // 
            // toolStripComboBox_1
            // 
            this.toolStripComboBox_1.AutoToolTip = true;
            this.toolStripComboBox_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_1.Items.AddRange(new object[] {
            "脉冲式推进(一般)",
            "非脉冲推进(尽快)"});
            this.toolStripComboBox_1.Name = "toolStripComboBox_1";
            this.toolStripComboBox_1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator_14
            // 
            this.toolStripSeparator_14.Name = "toolStripSeparator_14";
            this.toolStripSeparator_14.Size = new System.Drawing.Size(6, 25);
            // 
            // Button_StartOrRecover
            // 
            this.Button_StartOrRecover.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Button_StartOrRecover.Name = "Button_StartOrRecover";
            this.Button_StartOrRecover.Size = new System.Drawing.Size(64, 22);
            this.Button_StartOrRecover.Text = "启动/恢复";
            this.Button_StartOrRecover.Click += new System.EventHandler(this.BtnClick_StartOrRecover);
            // 
            // toolStripSeparator_7
            // 
            this.toolStripSeparator_7.Name = "toolStripSeparator_7";
            this.toolStripSeparator_7.Size = new System.Drawing.Size(6, 25);
            // 
            // Button_CustomLayer
            // 
            this.Button_CustomLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Button_CustomLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_CustomLayer.Name = "Button_CustomLayer";
            this.Button_CustomLayer.Size = new System.Drawing.Size(71, 22);
            this.Button_CustomLayer.Text = "自定义图层";
            this.Button_CustomLayer.Click += new System.EventHandler(this.BtnClick_CustomLayer);
            // 
            // toolStripSeparator_8
            // 
            this.toolStripSeparator_8.Name = "toolStripSeparator_8";
            this.toolStripSeparator_8.Size = new System.Drawing.Size(6, 25);
            // 
            // Button_VideoRecord
            // 
            this.Button_VideoRecord.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Button_VideoRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_VideoRecord.Name = "Button_VideoRecord";
            this.Button_VideoRecord.Size = new System.Drawing.Size(35, 22);
            this.Button_VideoRecord.Text = "录像";
            this.Button_VideoRecord.Click += new System.EventHandler(this.BtnClick_VideoRecord);
            // 
            // toolStripSeparator_36
            // 
            this.toolStripSeparator_36.Name = "toolStripSeparator_36";
            this.toolStripSeparator_36.Size = new System.Drawing.Size(6, 25);
            // 
            // Button_GameSpeed
            // 
            this.Button_GameSpeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Button_GameSpeed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_GameSpeed.Name = "Button_GameSpeed";
            this.Button_GameSpeed.Size = new System.Drawing.Size(59, 22);
            this.Button_GameSpeed.Text = "推演速度";
            this.Button_GameSpeed.Click += new System.EventHandler(this.BtnClick_GameSpeed);
            // 
            // contextMenuStrip_0
            // 
            this.contextMenuStrip_0.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AU_AddUnit,
            this.MenuItem_AU_AddRefPoint,
            this.MenuItem_AU_DefineArea});
            this.contextMenuStrip_0.Name = "CMenu_AddUnit";
            this.contextMenuStrip_0.Size = new System.Drawing.Size(191, 70);
            // 
            // MenuItem_AU_AddUnit
            // 
            this.MenuItem_AU_AddUnit.Name = "MenuItem_AU_AddUnit";
            this.MenuItem_AU_AddUnit.ShortcutKeyDisplayString = "Ins";
            this.MenuItem_AU_AddUnit.Size = new System.Drawing.Size(190, 22);
            this.MenuItem_AU_AddUnit.Text = "添加单元";
            this.MenuItem_AU_AddUnit.Click += new System.EventHandler(this.Click_AU_AddUnit);
            // 
            // MenuItem_AU_AddRefPoint
            // 
            this.MenuItem_AU_AddRefPoint.Name = "MenuItem_AU_AddRefPoint";
            this.MenuItem_AU_AddRefPoint.ShortcutKeyDisplayString = "Ctrl+Ins";
            this.MenuItem_AU_AddRefPoint.Size = new System.Drawing.Size(190, 22);
            this.MenuItem_AU_AddRefPoint.Text = "增加参考点";
            this.MenuItem_AU_AddRefPoint.Click += new System.EventHandler(this.Click_AU_AddRefPoint);
            // 
            // MenuItem_AU_DefineArea
            // 
            this.MenuItem_AU_DefineArea.Name = "MenuItem_AU_DefineArea";
            this.MenuItem_AU_DefineArea.Size = new System.Drawing.Size(190, 22);
            this.MenuItem_AU_DefineArea.Text = "定义区域";
            this.MenuItem_AU_DefineArea.Click += new System.EventHandler(this.Click_AU_DefineArea);
            // 
            // saveFileDialog_0
            // 
            this.saveFileDialog_0.DefaultExt = "scen";
            this.saveFileDialog_0.InitialDirectory = "\\Scenarios";
            this.saveFileDialog_0.Title = "保存推演想定";
            this.saveFileDialog_0.Disposed += new System.EventHandler(this.method_73);
            // 
            // timer_0
            // 
            this.timer_0.Interval = 250;
            this.timer_0.Tick += new System.EventHandler(this.method_143);
            // 
            // toolStripStatusLabel_0
            // 
            this.toolStripStatusLabel_0.Name = "toolStripStatusLabel_0";
            this.toolStripStatusLabel_0.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip_0
            // 
            this.statusStrip_0.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.statusStrip_0.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_0});
            this.statusStrip_0.Location = new System.Drawing.Point(0, 701);
            this.statusStrip_0.Name = "statusStrip_0";
            this.statusStrip_0.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip_0.TabIndex = 3;
            // 
            // contextMenuStrip_1
            // 
            this.contextMenuStrip_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Unit_AttackOptions,
            this.MenuItem_Unit_AntiSubmarineWar,
            this.MenuItem_Unit_ThrottleAltOrDeep,
            this.MenuItem_Unit_PlotCourse,
            this.MenuItem_Unit_Magazines,
            this.MenuItem_Unit_AirOperations,
            this.MenuItem_Unit_BoatDockingOperations,
            this.MenuItem_Unit_WeaponStatus,
            this.MenuItem_Unit_SensorsStatus,
            this.MenuItem_Unit_SystemDamageStatus,
            this.MenuItem_Unit_ReturnToBase,
            this.MenuItem_Unit_SelectNewBase,
            this.MenuItem_Unit_AirRefuel,
            this.MenuItem_Unit_HoldPositon_SelectedUnit,
            this.MenuItem_Unit_HoldPositon_AllUnit,
            this.MenuItem_Unit_IsolationView,
            this.MenuItem_Unit_QuickTumaround,
            this.toolStripSeparator_3,
            this.MenuItem_Unit_GroupOperations,
            this.toolStripSeparator_5,
            this.MenuItem_Unit_UnassignMissionUnit,
            this.MenuItem_Unit_AssignMissionToUnit,
            this.MenuItem_Unit_Doctrine_RoE_EMCON,
            this.toolStripSeparator_28,
            this.MenuItem_Unit_DirectionRangeMeasure,
            this.toolStripSeparator_27,
            this.MenuItem_Unit_ScenarioEdit,
            this.MenuItem_Unit_DischargeCargo});
            this.contextMenuStrip_1.Name = "CMenu_Unit";
            this.contextMenuStrip_1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip_1.ShowCheckMargin = true;
            this.contextMenuStrip_1.ShowImageMargin = false;
            this.contextMenuStrip_1.Size = new System.Drawing.Size(281, 556);
            // 
            // MenuItem_Unit_AttackOptions
            // 
            this.MenuItem_Unit_AttackOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Unit_OA_AutoEngageTarget,
            this.MenuItem_Unit_OA_ManualEngageTarget,
            this.MenuItem_Unit_OA_LaunchOnlyBearing,
            this.MenuItem_Unit_AO_DropTarget,
            this.MenuItem_Unit_AO_DropAllTarget,
            this.MenuItem_Unit_AO_IgnorePlottedCourse_SelectedUnit,
            this.MenuItem_Unit_AO_IgnorePlottedCourse_AllUnit,
            this.MenuItem_Unit_AO_WeaponContorlStatusForAllType_SelectUnit,
            this.MenuItem_Unit_AO_WeaponContorlStatusForAllType_AllUnit});
            this.MenuItem_Unit_AttackOptions.Name = "MenuItem_Unit_AttackOptions";
            this.MenuItem_Unit_AttackOptions.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_AttackOptions.Text = "攻击作战行动";
            // 
            // MenuItem_Unit_OA_AutoEngageTarget
            // 
            this.MenuItem_Unit_OA_AutoEngageTarget.Name = "MenuItem_Unit_OA_AutoEngageTarget";
            this.MenuItem_Unit_OA_AutoEngageTarget.ShortcutKeyDisplayString = "";
            this.MenuItem_Unit_OA_AutoEngageTarget.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.MenuItem_Unit_OA_AutoEngageTarget.Size = new System.Drawing.Size(440, 22);
            this.MenuItem_Unit_OA_AutoEngageTarget.Text = "自动接战目标";
            this.MenuItem_Unit_OA_AutoEngageTarget.Click += new System.EventHandler(this.Click_Unit_OA_AutoEngageTarget);
            // 
            // MenuItem_Unit_OA_ManualEngageTarget
            // 
            this.MenuItem_Unit_OA_ManualEngageTarget.Name = "MenuItem_Unit_OA_ManualEngageTarget";
            this.MenuItem_Unit_OA_ManualEngageTarget.Size = new System.Drawing.Size(440, 22);
            this.MenuItem_Unit_OA_ManualEngageTarget.Text = "手动接战目标";
            this.MenuItem_Unit_OA_ManualEngageTarget.Click += new System.EventHandler(this.Click_Unit_OA_ManualEngageTarget);
            // 
            // MenuItem_Unit_OA_LaunchOnlyBearing
            // 
            this.MenuItem_Unit_OA_LaunchOnlyBearing.Name = "MenuItem_Unit_OA_LaunchOnlyBearing";
            this.MenuItem_Unit_OA_LaunchOnlyBearing.Size = new System.Drawing.Size(440, 22);
            this.MenuItem_Unit_OA_LaunchOnlyBearing.Text = "纯方位攻击";
            this.MenuItem_Unit_OA_LaunchOnlyBearing.Click += new System.EventHandler(this.Click_Unit_OA_LaunchOnlyBearing);
            // 
            // MenuItem_Unit_AO_DropTarget
            // 
            this.MenuItem_Unit_AO_DropTarget.Name = "MenuItem_Unit_AO_DropTarget";
            this.MenuItem_Unit_AO_DropTarget.ShortcutKeyDisplayString = "E";
            this.MenuItem_Unit_AO_DropTarget.Size = new System.Drawing.Size(440, 22);
            this.MenuItem_Unit_AO_DropTarget.Text = "放弃目标";
            this.MenuItem_Unit_AO_DropTarget.Click += new System.EventHandler(this.Click_Unit_AO_DropTarget);
            // 
            // MenuItem_Unit_AO_DropAllTarget
            // 
            this.MenuItem_Unit_AO_DropAllTarget.Name = "MenuItem_Unit_AO_DropAllTarget";
            this.MenuItem_Unit_AO_DropAllTarget.ShortcutKeyDisplayString = "Ctrl+E";
            this.MenuItem_Unit_AO_DropAllTarget.Size = new System.Drawing.Size(440, 22);
            this.MenuItem_Unit_AO_DropAllTarget.Text = "脱离接战 (放弃所有目标)";
            this.MenuItem_Unit_AO_DropAllTarget.Click += new System.EventHandler(this.Click_Unit_AO_DropAllTarget);
            // 
            // MenuItem_Unit_AO_IgnorePlottedCourse_SelectedUnit
            // 
            this.MenuItem_Unit_AO_IgnorePlottedCourse_SelectedUnit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Unit_AO_IPCSU_Yes,
            this.MenuItem_Unit_AO_IPCSU_No,
            this.MenuItem_Unit_AO_IPCSU_SameAsSuperior});
            this.MenuItem_Unit_AO_IgnorePlottedCourse_SelectedUnit.Name = "MenuItem_Unit_AO_IgnorePlottedCourse_SelectedUnit";
            this.MenuItem_Unit_AO_IgnorePlottedCourse_SelectedUnit.ShortcutKeyDisplayString = "I (Yes/Inherit)";
            this.MenuItem_Unit_AO_IgnorePlottedCourse_SelectedUnit.Size = new System.Drawing.Size(440, 22);
            this.MenuItem_Unit_AO_IgnorePlottedCourse_SelectedUnit.Text = "攻击时忽略计划航线—针对所选单元";
            // 
            // MenuItem_Unit_AO_IPCSU_Yes
            // 
            this.MenuItem_Unit_AO_IPCSU_Yes.Name = "MenuItem_Unit_AO_IPCSU_Yes";
            this.MenuItem_Unit_AO_IPCSU_Yes.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Unit_AO_IPCSU_Yes.Text = "是";
            this.MenuItem_Unit_AO_IPCSU_Yes.Click += new System.EventHandler(this.Click_Unit_AO_IPCSU_Yes);
            // 
            // MenuItem_Unit_AO_IPCSU_No
            // 
            this.MenuItem_Unit_AO_IPCSU_No.Name = "MenuItem_Unit_AO_IPCSU_No";
            this.MenuItem_Unit_AO_IPCSU_No.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Unit_AO_IPCSU_No.Text = "否";
            this.MenuItem_Unit_AO_IPCSU_No.Click += new System.EventHandler(this.Click_Unit_AO_IPCSU_No);
            // 
            // MenuItem_Unit_AO_IPCSU_SameAsSuperior
            // 
            this.MenuItem_Unit_AO_IPCSU_SameAsSuperior.Name = "MenuItem_Unit_AO_IPCSU_SameAsSuperior";
            this.MenuItem_Unit_AO_IPCSU_SameAsSuperior.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Unit_AO_IPCSU_SameAsSuperior.Text = "与上级一致";
            this.MenuItem_Unit_AO_IPCSU_SameAsSuperior.Click += new System.EventHandler(this.Click_Unit_AO_IPCSU_SameAsSuperior);
            // 
            // MenuItem_Unit_AO_IgnorePlottedCourse_AllUnit
            // 
            this.MenuItem_Unit_AO_IgnorePlottedCourse_AllUnit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Unit_AO_IPCAU_Yes,
            this.MenuItem_Unit_AO_IPCAU_No,
            this.MenuItem_Unit_AO_IPCAU_SameAsSuperior});
            this.MenuItem_Unit_AO_IgnorePlottedCourse_AllUnit.Name = "MenuItem_Unit_AO_IgnorePlottedCourse_AllUnit";
            this.MenuItem_Unit_AO_IgnorePlottedCourse_AllUnit.ShortcutKeyDisplayString = "Ctrl+I (Yes/Inherit)";
            this.MenuItem_Unit_AO_IgnorePlottedCourse_AllUnit.Size = new System.Drawing.Size(440, 22);
            this.MenuItem_Unit_AO_IgnorePlottedCourse_AllUnit.Text = "攻击时忽略计划航线—针对所有单元";
            // 
            // MenuItem_Unit_AO_IPCAU_Yes
            // 
            this.MenuItem_Unit_AO_IPCAU_Yes.Name = "MenuItem_Unit_AO_IPCAU_Yes";
            this.MenuItem_Unit_AO_IPCAU_Yes.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Unit_AO_IPCAU_Yes.Text = "是";
            this.MenuItem_Unit_AO_IPCAU_Yes.Click += new System.EventHandler(this.Click_Unit_AO_IPCAU_Yes);
            // 
            // MenuItem_Unit_AO_IPCAU_No
            // 
            this.MenuItem_Unit_AO_IPCAU_No.Name = "MenuItem_Unit_AO_IPCAU_No";
            this.MenuItem_Unit_AO_IPCAU_No.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Unit_AO_IPCAU_No.Text = "否";
            this.MenuItem_Unit_AO_IPCAU_No.Click += new System.EventHandler(this.Click_Unit_AO_IPCAU_No);
            // 
            // MenuItem_Unit_AO_IPCAU_SameAsSuperior
            // 
            this.MenuItem_Unit_AO_IPCAU_SameAsSuperior.Name = "MenuItem_Unit_AO_IPCAU_SameAsSuperior";
            this.MenuItem_Unit_AO_IPCAU_SameAsSuperior.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Unit_AO_IPCAU_SameAsSuperior.Text = "与上级一致";
            this.MenuItem_Unit_AO_IPCAU_SameAsSuperior.Click += new System.EventHandler(this.Click_Unit_AO_IPCAU_SameAsSuperior);
            // 
            // MenuItem_Unit_AO_WeaponContorlStatusForAllType_SelectUnit
            // 
            this.MenuItem_Unit_AO_WeaponContorlStatusForAllType_SelectUnit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Unit_AO_WCSFATSU_ForbidFire,
            this.MenuItem_Unit_AO_WCSFATSU_LimitFire,
            this.MenuItem_Unit_AO_WCSFATSU_FreeFire,
            this.MenuItem_Unit_AO_WCSFATSU_SameAsSuperior});
            this.MenuItem_Unit_AO_WeaponContorlStatusForAllType_SelectUnit.Name = "MenuItem_Unit_AO_WeaponContorlStatusForAllType_SelectUnit";
            this.MenuItem_Unit_AO_WeaponContorlStatusForAllType_SelectUnit.ShortcutKeyDisplayString = "A (Hold/Inherit)";
            this.MenuItem_Unit_AO_WeaponContorlStatusForAllType_SelectUnit.Size = new System.Drawing.Size(440, 22);
            this.MenuItem_Unit_AO_WeaponContorlStatusForAllType_SelectUnit.Text = "针对所有目标类型的武器控制状态- 所选单元";
            // 
            // MenuItem_Unit_AO_WCSFATSU_ForbidFire
            // 
            this.MenuItem_Unit_AO_WCSFATSU_ForbidFire.Name = "MenuItem_Unit_AO_WCSFATSU_ForbidFire";
            this.MenuItem_Unit_AO_WCSFATSU_ForbidFire.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Unit_AO_WCSFATSU_ForbidFire.Text = "禁止开火";
            this.MenuItem_Unit_AO_WCSFATSU_ForbidFire.Click += new System.EventHandler(this.Click_Unit_AO_WCSFATSU_ForbidFire);
            // 
            // MenuItem_Unit_AO_WCSFATSU_LimitFire
            // 
            this.MenuItem_Unit_AO_WCSFATSU_LimitFire.Name = "MenuItem_Unit_AO_WCSFATSU_LimitFire";
            this.MenuItem_Unit_AO_WCSFATSU_LimitFire.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Unit_AO_WCSFATSU_LimitFire.Text = "限制开火";
            this.MenuItem_Unit_AO_WCSFATSU_LimitFire.Click += new System.EventHandler(this.Click_Unit_AO_WCSFATSU_LimitFire);
            // 
            // MenuItem_Unit_AO_WCSFATSU_FreeFire
            // 
            this.MenuItem_Unit_AO_WCSFATSU_FreeFire.Name = "MenuItem_Unit_AO_WCSFATSU_FreeFire";
            this.MenuItem_Unit_AO_WCSFATSU_FreeFire.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Unit_AO_WCSFATSU_FreeFire.Text = "自由开火";
            this.MenuItem_Unit_AO_WCSFATSU_FreeFire.Click += new System.EventHandler(this.Click_Unit_AO_WCSFATSU_FreeFire);
            // 
            // MenuItem_Unit_AO_WCSFATSU_SameAsSuperior
            // 
            this.MenuItem_Unit_AO_WCSFATSU_SameAsSuperior.Name = "MenuItem_Unit_AO_WCSFATSU_SameAsSuperior";
            this.MenuItem_Unit_AO_WCSFATSU_SameAsSuperior.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Unit_AO_WCSFATSU_SameAsSuperior.Text = "与上级一致";
            this.MenuItem_Unit_AO_WCSFATSU_SameAsSuperior.Click += new System.EventHandler(this.Click_Unit_AO_WCSFATSU_SameAsSuperior);
            // 
            // MenuItem_Unit_AO_WeaponContorlStatusForAllType_AllUnit
            // 
            this.MenuItem_Unit_AO_WeaponContorlStatusForAllType_AllUnit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Unit_AO_WCSFATAU_ForbidFire,
            this.MenuItem_Unit_AO_WCSFATAU_LimitFire,
            this.MenuItem_Unit_AO_WCSFATAU_FreeFire,
            this.MenuItem_Unit_AO_WCSFATAU_SameAsSuperior});
            this.MenuItem_Unit_AO_WeaponContorlStatusForAllType_AllUnit.Name = "MenuItem_Unit_AO_WeaponContorlStatusForAllType_AllUnit";
            this.MenuItem_Unit_AO_WeaponContorlStatusForAllType_AllUnit.ShortcutKeyDisplayString = "Ctrl+A (Hold/Inherit)";
            this.MenuItem_Unit_AO_WeaponContorlStatusForAllType_AllUnit.Size = new System.Drawing.Size(440, 22);
            this.MenuItem_Unit_AO_WeaponContorlStatusForAllType_AllUnit.Text = "针对所有目标类型的武器控制状态- 所有单元";
            // 
            // MenuItem_Unit_AO_WCSFATAU_ForbidFire
            // 
            this.MenuItem_Unit_AO_WCSFATAU_ForbidFire.Name = "MenuItem_Unit_AO_WCSFATAU_ForbidFire";
            this.MenuItem_Unit_AO_WCSFATAU_ForbidFire.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Unit_AO_WCSFATAU_ForbidFire.Text = "禁止开火";
            this.MenuItem_Unit_AO_WCSFATAU_ForbidFire.Click += new System.EventHandler(this.Click_Unit_AO_WCSFATAU_ForbidFire);
            // 
            // MenuItem_Unit_AO_WCSFATAU_LimitFire
            // 
            this.MenuItem_Unit_AO_WCSFATAU_LimitFire.Name = "MenuItem_Unit_AO_WCSFATAU_LimitFire";
            this.MenuItem_Unit_AO_WCSFATAU_LimitFire.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Unit_AO_WCSFATAU_LimitFire.Text = "限制开火";
            this.MenuItem_Unit_AO_WCSFATAU_LimitFire.Click += new System.EventHandler(this.Click_Unit_AO_WCSFATAU_LimitFire);
            // 
            // MenuItem_Unit_AO_WCSFATAU_FreeFire
            // 
            this.MenuItem_Unit_AO_WCSFATAU_FreeFire.Name = "MenuItem_Unit_AO_WCSFATAU_FreeFire";
            this.MenuItem_Unit_AO_WCSFATAU_FreeFire.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Unit_AO_WCSFATAU_FreeFire.Text = "自由开火";
            this.MenuItem_Unit_AO_WCSFATAU_FreeFire.Click += new System.EventHandler(this.Click_Unit_AO_WCSFATAU_FreeFire);
            // 
            // MenuItem_Unit_AO_WCSFATAU_SameAsSuperior
            // 
            this.MenuItem_Unit_AO_WCSFATAU_SameAsSuperior.Name = "MenuItem_Unit_AO_WCSFATAU_SameAsSuperior";
            this.MenuItem_Unit_AO_WCSFATAU_SameAsSuperior.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Unit_AO_WCSFATAU_SameAsSuperior.Text = "与上级一致";
            this.MenuItem_Unit_AO_WCSFATAU_SameAsSuperior.Click += new System.EventHandler(this.Click_Unit_AO_WCSFATAU_SameAsSuperior);
            // 
            // MenuItem_Unit_AntiSubmarineWar
            // 
            this.MenuItem_Unit_AntiSubmarineWar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Unit_ASW_DropPassiveSonobuoy,
            this.MenuItem_Unit_DropActiveSonobuoy,
            this.MenuItem_Unit_DeployDippingSonar});
            this.MenuItem_Unit_AntiSubmarineWar.Name = "MenuItem_Unit_AntiSubmarineWar";
            this.MenuItem_Unit_AntiSubmarineWar.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_AntiSubmarineWar.Text = "反潜作战行动";
            // 
            // MenuItem_Unit_ASW_DropPassiveSonobuoy
            // 
            this.MenuItem_Unit_ASW_DropPassiveSonobuoy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Unit_ASW_DPS_Shallow,
            this.MenuItem_Unit_ASW_DPS_Deep});
            this.MenuItem_Unit_ASW_DropPassiveSonobuoy.Name = "MenuItem_Unit_ASW_DropPassiveSonobuoy";
            this.MenuItem_Unit_ASW_DropPassiveSonobuoy.ShortcutKeyDisplayString = "";
            this.MenuItem_Unit_ASW_DropPassiveSonobuoy.Size = new System.Drawing.Size(199, 22);
            this.MenuItem_Unit_ASW_DropPassiveSonobuoy.Text = "投放被动声纳浮标";
            // 
            // MenuItem_Unit_ASW_DPS_Shallow
            // 
            this.MenuItem_Unit_ASW_DPS_Shallow.Name = "MenuItem_Unit_ASW_DPS_Shallow";
            this.MenuItem_Unit_ASW_DPS_Shallow.ShortcutKeyDisplayString = "Shift+[";
            this.MenuItem_Unit_ASW_DPS_Shallow.Size = new System.Drawing.Size(207, 22);
            this.MenuItem_Unit_ASW_DPS_Shallow.Text = "浅 - 温跃层之上";
            this.MenuItem_Unit_ASW_DPS_Shallow.Click += new System.EventHandler(this.Click_Unit_ASW_DPS_Shallow);
            // 
            // MenuItem_Unit_ASW_DPS_Deep
            // 
            this.MenuItem_Unit_ASW_DPS_Deep.Name = "MenuItem_Unit_ASW_DPS_Deep";
            this.MenuItem_Unit_ASW_DPS_Deep.ShortcutKeyDisplayString = "[";
            this.MenuItem_Unit_ASW_DPS_Deep.Size = new System.Drawing.Size(207, 22);
            this.MenuItem_Unit_ASW_DPS_Deep.Text = "深 - 温跃层之下";
            this.MenuItem_Unit_ASW_DPS_Deep.Click += new System.EventHandler(this.Click_Unit_ASW_DPS_Deep);
            // 
            // MenuItem_Unit_DropActiveSonobuoy
            // 
            this.MenuItem_Unit_DropActiveSonobuoy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Unit_ASW_DAS_Shallow,
            this.MenuItem_Unit_ASW_DAS_Deep});
            this.MenuItem_Unit_DropActiveSonobuoy.Name = "MenuItem_Unit_DropActiveSonobuoy";
            this.MenuItem_Unit_DropActiveSonobuoy.Size = new System.Drawing.Size(199, 22);
            this.MenuItem_Unit_DropActiveSonobuoy.Text = "投放主动声纳浮标";
            // 
            // MenuItem_Unit_ASW_DAS_Shallow
            // 
            this.MenuItem_Unit_ASW_DAS_Shallow.Name = "MenuItem_Unit_ASW_DAS_Shallow";
            this.MenuItem_Unit_ASW_DAS_Shallow.ShortcutKeyDisplayString = "Shift+]";
            this.MenuItem_Unit_ASW_DAS_Shallow.Size = new System.Drawing.Size(207, 22);
            this.MenuItem_Unit_ASW_DAS_Shallow.Text = "浅 - 温跃层之上";
            this.MenuItem_Unit_ASW_DAS_Shallow.Click += new System.EventHandler(this.Click_Unit_ASW_DAS_Shallow);
            // 
            // MenuItem_Unit_ASW_DAS_Deep
            // 
            this.MenuItem_Unit_ASW_DAS_Deep.Name = "MenuItem_Unit_ASW_DAS_Deep";
            this.MenuItem_Unit_ASW_DAS_Deep.ShortcutKeyDisplayString = "]";
            this.MenuItem_Unit_ASW_DAS_Deep.Size = new System.Drawing.Size(207, 22);
            this.MenuItem_Unit_ASW_DAS_Deep.Text = "深 - 温跃层之下";
            this.MenuItem_Unit_ASW_DAS_Deep.Click += new System.EventHandler(this.Click_Unit_ASW_DAS_Deep);
            // 
            // MenuItem_Unit_DeployDippingSonar
            // 
            this.MenuItem_Unit_DeployDippingSonar.Name = "MenuItem_Unit_DeployDippingSonar";
            this.MenuItem_Unit_DeployDippingSonar.ShortcutKeyDisplayString = "Shift+D";
            this.MenuItem_Unit_DeployDippingSonar.Size = new System.Drawing.Size(199, 22);
            this.MenuItem_Unit_DeployDippingSonar.Text = "部署吊放声纳";
            this.MenuItem_Unit_DeployDippingSonar.Click += new System.EventHandler(this.Click_Unit_DeployDippingSonar);
            // 
            // MenuItem_Unit_ThrottleAltOrDeep
            // 
            this.MenuItem_Unit_ThrottleAltOrDeep.Name = "MenuItem_Unit_ThrottleAltOrDeep";
            this.MenuItem_Unit_ThrottleAltOrDeep.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.MenuItem_Unit_ThrottleAltOrDeep.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_ThrottleAltOrDeep.Text = "油门-高度/深度";
            this.MenuItem_Unit_ThrottleAltOrDeep.Click += new System.EventHandler(this.Click_Unit_ThrottleAltOrDeep);
            // 
            // MenuItem_Unit_PlotCourse
            // 
            this.MenuItem_Unit_PlotCourse.Name = "MenuItem_Unit_PlotCourse";
            this.MenuItem_Unit_PlotCourse.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.MenuItem_Unit_PlotCourse.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_PlotCourse.Text = "航线规划";
            this.MenuItem_Unit_PlotCourse.Click += new System.EventHandler(this.Click_Unit_PlotCourse);
            // 
            // MenuItem_Unit_Magazines
            // 
            this.MenuItem_Unit_Magazines.Name = "MenuItem_Unit_Magazines";
            this.MenuItem_Unit_Magazines.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MenuItem_Unit_Magazines.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_Magazines.Text = "弹药库";
            this.MenuItem_Unit_Magazines.Click += new System.EventHandler(this.Click_Unit_Magazines);
            // 
            // MenuItem_Unit_AirOperations
            // 
            this.MenuItem_Unit_AirOperations.Name = "MenuItem_Unit_AirOperations";
            this.MenuItem_Unit_AirOperations.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.MenuItem_Unit_AirOperations.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_AirOperations.Text = "空中作战行动";
            this.MenuItem_Unit_AirOperations.Click += new System.EventHandler(this.Click_Unit_AirOperations);
            // 
            // MenuItem_Unit_BoatDockingOperations
            // 
            this.MenuItem_Unit_BoatDockingOperations.Name = "MenuItem_Unit_BoatDockingOperations";
            this.MenuItem_Unit_BoatDockingOperations.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.MenuItem_Unit_BoatDockingOperations.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_BoatDockingOperations.Text = "船舶停靠行动";
            this.MenuItem_Unit_BoatDockingOperations.Click += new System.EventHandler(this.Click_Unit_BoatDockingOperations);
            // 
            // MenuItem_Unit_WeaponStatus
            // 
            this.MenuItem_Unit_WeaponStatus.Name = "MenuItem_Unit_WeaponStatus";
            this.MenuItem_Unit_WeaponStatus.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.MenuItem_Unit_WeaponStatus.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_WeaponStatus.Text = "武器状态管理";
            this.MenuItem_Unit_WeaponStatus.Click += new System.EventHandler(this.Click_Unit_WeaponStatus);
            // 
            // MenuItem_Unit_SensorsStatus
            // 
            this.MenuItem_Unit_SensorsStatus.Name = "MenuItem_Unit_SensorsStatus";
            this.MenuItem_Unit_SensorsStatus.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.MenuItem_Unit_SensorsStatus.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_SensorsStatus.Text = "传感器状态管理";
            this.MenuItem_Unit_SensorsStatus.Click += new System.EventHandler(this.Click_Unit_SensorsStatus);
            // 
            // MenuItem_Unit_SystemDamageStatus
            // 
            this.MenuItem_Unit_SystemDamageStatus.Name = "MenuItem_Unit_SystemDamageStatus";
            this.MenuItem_Unit_SystemDamageStatus.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.MenuItem_Unit_SystemDamageStatus.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_SystemDamageStatus.Text = "系统毁伤状态";
            this.MenuItem_Unit_SystemDamageStatus.Click += new System.EventHandler(this.Click_Unit_SystemDamageStatus);
            // 
            // MenuItem_Unit_ReturnToBase
            // 
            this.MenuItem_Unit_ReturnToBase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuItem_Unit_ReturnToBase.Name = "MenuItem_Unit_ReturnToBase";
            this.MenuItem_Unit_ReturnToBase.ShortcutKeyDisplayString = "B";
            this.MenuItem_Unit_ReturnToBase.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_ReturnToBase.Text = "返航";
            this.MenuItem_Unit_ReturnToBase.Click += new System.EventHandler(this.Click_Unit_ReturnToBase);
            // 
            // MenuItem_Unit_SelectNewBase
            // 
            this.MenuItem_Unit_SelectNewBase.Name = "MenuItem_Unit_SelectNewBase";
            this.MenuItem_Unit_SelectNewBase.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_SelectNewBase.Text = "选择新基地";
            this.MenuItem_Unit_SelectNewBase.Click += new System.EventHandler(this.Click_Unit_SelectNewBase);
            // 
            // MenuItem_Unit_AirRefuel
            // 
            this.MenuItem_Unit_AirRefuel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Unit_AR_AutoSelectAerialTanker,
            this.MenuItem_Unit_AR_ManualSelectAerialTanker,
            this.MenuItem_Unit_AR_SelectForMission});
            this.MenuItem_Unit_AirRefuel.Name = "MenuItem_Unit_AirRefuel";
            this.MenuItem_Unit_AirRefuel.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_AirRefuel.Text = "加油(如何可能)";
            // 
            // MenuItem_Unit_AR_AutoSelectAerialTanker
            // 
            this.MenuItem_Unit_AR_AutoSelectAerialTanker.Name = "MenuItem_Unit_AR_AutoSelectAerialTanker";
            this.MenuItem_Unit_AR_AutoSelectAerialTanker.Size = new System.Drawing.Size(187, 22);
            this.MenuItem_Unit_AR_AutoSelectAerialTanker.Text = "自动选择加油机";
            this.MenuItem_Unit_AR_AutoSelectAerialTanker.Click += new System.EventHandler(this.Click_Unit_AR_AutoSelectAerialTanker);
            // 
            // MenuItem_Unit_AR_ManualSelectAerialTanker
            // 
            this.MenuItem_Unit_AR_ManualSelectAerialTanker.Name = "MenuItem_Unit_AR_ManualSelectAerialTanker";
            this.MenuItem_Unit_AR_ManualSelectAerialTanker.Size = new System.Drawing.Size(187, 22);
            this.MenuItem_Unit_AR_ManualSelectAerialTanker.Text = "手动选择加油机";
            this.MenuItem_Unit_AR_ManualSelectAerialTanker.Click += new System.EventHandler(this.Click_Unit_AR_ManualSelectAerialTanker);
            // 
            // MenuItem_Unit_AR_SelectForMission
            // 
            this.MenuItem_Unit_AR_SelectForMission.Name = "MenuItem_Unit_AR_SelectForMission";
            this.MenuItem_Unit_AR_SelectForMission.Size = new System.Drawing.Size(187, 22);
            this.MenuItem_Unit_AR_SelectForMission.Text = "从任务中选择加油机:";
            // 
            // MenuItem_Unit_HoldPositon_SelectedUnit
            // 
            this.MenuItem_Unit_HoldPositon_SelectedUnit.Name = "MenuItem_Unit_HoldPositon_SelectedUnit";
            this.MenuItem_Unit_HoldPositon_SelectedUnit.ShortcutKeyDisplayString = "L";
            this.MenuItem_Unit_HoldPositon_SelectedUnit.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_HoldPositon_SelectedUnit.Text = "保持阵位—所选单元";
            this.MenuItem_Unit_HoldPositon_SelectedUnit.Click += new System.EventHandler(this.Click_Unit_HoldPositon_SelectedUnit);
            // 
            // MenuItem_Unit_HoldPositon_AllUnit
            // 
            this.MenuItem_Unit_HoldPositon_AllUnit.Name = "MenuItem_Unit_HoldPositon_AllUnit";
            this.MenuItem_Unit_HoldPositon_AllUnit.ShortcutKeyDisplayString = "Ctrl+L";
            this.MenuItem_Unit_HoldPositon_AllUnit.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_HoldPositon_AllUnit.Text = "保持阵位—所有单元";
            this.MenuItem_Unit_HoldPositon_AllUnit.Click += new System.EventHandler(this.Click_Unit_HoldPositon_AllUnit);
            // 
            // MenuItem_Unit_IsolationView
            // 
            this.MenuItem_Unit_IsolationView.Name = "MenuItem_Unit_IsolationView";
            this.MenuItem_Unit_IsolationView.ShortcutKeyDisplayString = "Ctrl+Shift+I";
            this.MenuItem_Unit_IsolationView.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_IsolationView.Text = "隔离视图";
            this.MenuItem_Unit_IsolationView.Click += new System.EventHandler(this.Click_Unit_IsolationView);
            // 
            // MenuItem_Unit_QuickTumaround
            // 
            this.MenuItem_Unit_QuickTumaround.Name = "MenuItem_Unit_QuickTumaround";
            this.MenuItem_Unit_QuickTumaround.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_QuickTumaround.Text = "快速出动(飞机)";
            this.MenuItem_Unit_QuickTumaround.Click += new System.EventHandler(this.Click_Unit_QuickTumaround);
            // 
            // toolStripSeparator_3
            // 
            this.toolStripSeparator_3.Name = "toolStripSeparator_3";
            this.toolStripSeparator_3.Size = new System.Drawing.Size(277, 6);
            // 
            // MenuItem_Unit_GroupOperations
            // 
            this.MenuItem_Unit_GroupOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Unit_GO_GroupBySelectedUnit,
            this.MenuItem_Unit_GO_SelectedUnitRemoveGroup,
            this.MenuItem_Unit_GO_GroupEditor});
            this.MenuItem_Unit_GroupOperations.Name = "MenuItem_Unit_GroupOperations";
            this.MenuItem_Unit_GroupOperations.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_GroupOperations.Text = "编组作战行动";
            // 
            // MenuItem_Unit_GO_GroupBySelectedUnit
            // 
            this.MenuItem_Unit_GO_GroupBySelectedUnit.Name = "MenuItem_Unit_GO_GroupBySelectedUnit";
            this.MenuItem_Unit_GO_GroupBySelectedUnit.ShortcutKeyDisplayString = "G";
            this.MenuItem_Unit_GO_GroupBySelectedUnit.Size = new System.Drawing.Size(201, 22);
            this.MenuItem_Unit_GO_GroupBySelectedUnit.Text = "将所选单元进行编组";
            this.MenuItem_Unit_GO_GroupBySelectedUnit.Click += new System.EventHandler(this.Click_Unit_GO_GroupBySelectedUnit);
            // 
            // MenuItem_Unit_GO_SelectedUnitRemoveGroup
            // 
            this.MenuItem_Unit_GO_SelectedUnitRemoveGroup.Name = "MenuItem_Unit_GO_SelectedUnitRemoveGroup";
            this.MenuItem_Unit_GO_SelectedUnitRemoveGroup.ShortcutKeyDisplayString = "D";
            this.MenuItem_Unit_GO_SelectedUnitRemoveGroup.Size = new System.Drawing.Size(201, 22);
            this.MenuItem_Unit_GO_SelectedUnitRemoveGroup.Text = "将所选单元脱离编组";
            this.MenuItem_Unit_GO_SelectedUnitRemoveGroup.Click += new System.EventHandler(this.Click_Unit_GO_SelectedUnitRemoveGroup);
            // 
            // MenuItem_Unit_GO_GroupEditor
            // 
            this.MenuItem_Unit_GO_GroupEditor.Name = "MenuItem_Unit_GO_GroupEditor";
            this.MenuItem_Unit_GO_GroupEditor.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.MenuItem_Unit_GO_GroupEditor.Size = new System.Drawing.Size(201, 22);
            this.MenuItem_Unit_GO_GroupEditor.Text = "编队编辑器";
            this.MenuItem_Unit_GO_GroupEditor.Click += new System.EventHandler(this.Click_Unit_GO_GroupEditor);
            // 
            // toolStripSeparator_5
            // 
            this.toolStripSeparator_5.Name = "toolStripSeparator_5";
            this.toolStripSeparator_5.Size = new System.Drawing.Size(277, 6);
            // 
            // MenuItem_Unit_UnassignMissionUnit
            // 
            this.MenuItem_Unit_UnassignMissionUnit.Name = "MenuItem_Unit_UnassignMissionUnit";
            this.MenuItem_Unit_UnassignMissionUnit.ShortcutKeyDisplayString = "U";
            this.MenuItem_Unit_UnassignMissionUnit.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_UnassignMissionUnit.Text = "取消单元分配的任务";
            this.MenuItem_Unit_UnassignMissionUnit.Click += new System.EventHandler(this.Click_Unit_UnassignMissionUnit);
            // 
            // MenuItem_Unit_AssignMissionToUnit
            // 
            this.MenuItem_Unit_AssignMissionToUnit.Name = "MenuItem_Unit_AssignMissionToUnit";
            this.MenuItem_Unit_AssignMissionToUnit.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_AssignMissionToUnit.Text = "给单元分配任务:";
            // 
            // MenuItem_Unit_Doctrine_RoE_EMCON
            // 
            this.MenuItem_Unit_Doctrine_RoE_EMCON.Name = "MenuItem_Unit_Doctrine_RoE_EMCON";
            this.MenuItem_Unit_Doctrine_RoE_EMCON.ShortcutKeyDisplayString = "Ctrl+F9";
            this.MenuItem_Unit_Doctrine_RoE_EMCON.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_Doctrine_RoE_EMCON.Text = "作战条令/交战规则/电磁管控";
            this.MenuItem_Unit_Doctrine_RoE_EMCON.Click += new System.EventHandler(this.Click_Unit_Doctrine_RoE_EMCON);
            // 
            // toolStripSeparator_28
            // 
            this.toolStripSeparator_28.Name = "toolStripSeparator_28";
            this.toolStripSeparator_28.Size = new System.Drawing.Size(277, 6);
            // 
            // MenuItem_Unit_DirectionRangeMeasure
            // 
            this.MenuItem_Unit_DirectionRangeMeasure.Name = "MenuItem_Unit_DirectionRangeMeasure";
            this.MenuItem_Unit_DirectionRangeMeasure.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_DirectionRangeMeasure.Text = "测距+测向";
            this.MenuItem_Unit_DirectionRangeMeasure.Click += new System.EventHandler(this.Click_Unit_DirectionRangeMeasure);
            // 
            // toolStripSeparator_27
            // 
            this.toolStripSeparator_27.Name = "toolStripSeparator_27";
            this.toolStripSeparator_27.Size = new System.Drawing.Size(277, 6);
            // 
            // MenuItem_Unit_ScenarioEdit
            // 
            this.MenuItem_Unit_ScenarioEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Unit_SE_EditUnitProp,
            this.MenuItem_Unit_SE_SetUnitTrainingLevel,
            this.MenuItem_Unit_SE_AutoDetectedUnit,
            this.MenuItem_Unit_SE_UnitLoseCommunication,
            this.MenuItem_Unit_SE_SetBearing,
            this.MenuItem_Unit_SE_CopyUnitID});
            this.MenuItem_Unit_ScenarioEdit.Name = "MenuItem_Unit_ScenarioEdit";
            this.MenuItem_Unit_ScenarioEdit.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_ScenarioEdit.Text = "想定编辑";
            // 
            // MenuItem_Unit_SE_EditUnitProp
            // 
            this.MenuItem_Unit_SE_EditUnitProp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Unit_SE_EUP_Magazine,
            this.MenuItem_Unit_SE_EUP_AmmunitionReserve,
            this.MenuItem_Unit_SE_EUP_Airplane});
            this.MenuItem_Unit_SE_EditUnitProp.Name = "MenuItem_Unit_SE_EditUnitProp";
            this.MenuItem_Unit_SE_EditUnitProp.Size = new System.Drawing.Size(196, 22);
            this.MenuItem_Unit_SE_EditUnitProp.Text = "编辑单元属性";
            // 
            // MenuItem_Unit_SE_EUP_Magazine
            // 
            this.MenuItem_Unit_SE_EUP_Magazine.Name = "MenuItem_Unit_SE_EUP_Magazine";
            this.MenuItem_Unit_SE_EUP_Magazine.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_Unit_SE_EUP_Magazine.Text = "弹药库";
            this.MenuItem_Unit_SE_EUP_Magazine.Click += new System.EventHandler(this.Click_Unit_SE_EUP_Magazine);
            // 
            // MenuItem_Unit_SE_EUP_AmmunitionReserve
            // 
            this.MenuItem_Unit_SE_EUP_AmmunitionReserve.Enabled = false;
            this.MenuItem_Unit_SE_EUP_AmmunitionReserve.Name = "MenuItem_Unit_SE_EUP_AmmunitionReserve";
            this.MenuItem_Unit_SE_EUP_AmmunitionReserve.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_Unit_SE_EUP_AmmunitionReserve.Text = "弹药储备";
            // 
            // MenuItem_Unit_SE_EUP_Airplane
            // 
            this.MenuItem_Unit_SE_EUP_Airplane.Enabled = false;
            this.MenuItem_Unit_SE_EUP_Airplane.Name = "MenuItem_Unit_SE_EUP_Airplane";
            this.MenuItem_Unit_SE_EUP_Airplane.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_Unit_SE_EUP_Airplane.Text = "飞机";
            // 
            // MenuItem_Unit_SE_SetUnitTrainingLevel
            // 
            this.MenuItem_Unit_SE_SetUnitTrainingLevel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Unit_SE_SUTL_NewPlayer,
            this.MenuItem_Unit_SE_SUTL_Trainee,
            this.MenuItem_Unit_SE_SUTL_Common,
            this.MenuItem_Unit_SE_SUTL_OldStager,
            this.MenuItem_Unit_SE_SUTL_TopLevel,
            this.MenuItem_Unit_SE_SUTL_SameAsCamp});
            this.MenuItem_Unit_SE_SetUnitTrainingLevel.Name = "MenuItem_Unit_SE_SetUnitTrainingLevel";
            this.MenuItem_Unit_SE_SetUnitTrainingLevel.Size = new System.Drawing.Size(196, 22);
            this.MenuItem_Unit_SE_SetUnitTrainingLevel.Text = "设置单元训练水平";
            // 
            // MenuItem_Unit_SE_SUTL_NewPlayer
            // 
            this.MenuItem_Unit_SE_SUTL_NewPlayer.BackColor = System.Drawing.Color.Green;
            this.MenuItem_Unit_SE_SUTL_NewPlayer.Name = "MenuItem_Unit_SE_SUTL_NewPlayer";
            this.MenuItem_Unit_SE_SUTL_NewPlayer.Size = new System.Drawing.Size(184, 22);
            this.MenuItem_Unit_SE_SUTL_NewPlayer.Text = "新手";
            this.MenuItem_Unit_SE_SUTL_NewPlayer.Click += new System.EventHandler(this.Click_Unit_SE_SUTL_NewPlayer);
            // 
            // MenuItem_Unit_SE_SUTL_Trainee
            // 
            this.MenuItem_Unit_SE_SUTL_Trainee.BackColor = System.Drawing.Color.Lime;
            this.MenuItem_Unit_SE_SUTL_Trainee.Name = "MenuItem_Unit_SE_SUTL_Trainee";
            this.MenuItem_Unit_SE_SUTL_Trainee.Size = new System.Drawing.Size(184, 22);
            this.MenuItem_Unit_SE_SUTL_Trainee.Text = "实习";
            this.MenuItem_Unit_SE_SUTL_Trainee.Click += new System.EventHandler(this.Click_Unit_SE_SUTL_Trainee);
            // 
            // MenuItem_Unit_SE_SUTL_Common
            // 
            this.MenuItem_Unit_SE_SUTL_Common.BackColor = System.Drawing.Color.Yellow;
            this.MenuItem_Unit_SE_SUTL_Common.Name = "MenuItem_Unit_SE_SUTL_Common";
            this.MenuItem_Unit_SE_SUTL_Common.Size = new System.Drawing.Size(184, 22);
            this.MenuItem_Unit_SE_SUTL_Common.Text = "普通";
            this.MenuItem_Unit_SE_SUTL_Common.Click += new System.EventHandler(this.Click_Unit_SE_SUTL_Common);
            // 
            // MenuItem_Unit_SE_SUTL_OldStager
            // 
            this.MenuItem_Unit_SE_SUTL_OldStager.BackColor = System.Drawing.Color.Orange;
            this.MenuItem_Unit_SE_SUTL_OldStager.Name = "MenuItem_Unit_SE_SUTL_OldStager";
            this.MenuItem_Unit_SE_SUTL_OldStager.Size = new System.Drawing.Size(184, 22);
            this.MenuItem_Unit_SE_SUTL_OldStager.Text = "老手";
            this.MenuItem_Unit_SE_SUTL_OldStager.Click += new System.EventHandler(this.Click_Unit_SE_SUTL_OldStager);
            // 
            // MenuItem_Unit_SE_SUTL_TopLevel
            // 
            this.MenuItem_Unit_SE_SUTL_TopLevel.BackColor = System.Drawing.Color.Red;
            this.MenuItem_Unit_SE_SUTL_TopLevel.Name = "MenuItem_Unit_SE_SUTL_TopLevel";
            this.MenuItem_Unit_SE_SUTL_TopLevel.Size = new System.Drawing.Size(184, 22);
            this.MenuItem_Unit_SE_SUTL_TopLevel.Text = "顶级";
            this.MenuItem_Unit_SE_SUTL_TopLevel.Click += new System.EventHandler(this.Click_Unit_SE_SUTL_TopLevel);
            // 
            // MenuItem_Unit_SE_SUTL_SameAsCamp
            // 
            this.MenuItem_Unit_SE_SUTL_SameAsCamp.Name = "MenuItem_Unit_SE_SUTL_SameAsCamp";
            this.MenuItem_Unit_SE_SUTL_SameAsCamp.Size = new System.Drawing.Size(184, 22);
            this.MenuItem_Unit_SE_SUTL_SameAsCamp.Text = "[与推演方保持一致] ";
            this.MenuItem_Unit_SE_SUTL_SameAsCamp.Click += new System.EventHandler(this.method_471);
            // 
            // MenuItem_Unit_SE_AutoDetectedUnit
            // 
            this.MenuItem_Unit_SE_AutoDetectedUnit.Name = "MenuItem_Unit_SE_AutoDetectedUnit";
            this.MenuItem_Unit_SE_AutoDetectedUnit.Size = new System.Drawing.Size(196, 22);
            this.MenuItem_Unit_SE_AutoDetectedUnit.Text = "单元自动探测到";
            this.MenuItem_Unit_SE_AutoDetectedUnit.Click += new System.EventHandler(this.Click_Unit_SE_AutoDetectedUnit);
            // 
            // MenuItem_Unit_SE_UnitLoseCommunication
            // 
            this.MenuItem_Unit_SE_UnitLoseCommunication.Name = "MenuItem_Unit_SE_UnitLoseCommunication";
            this.MenuItem_Unit_SE_UnitLoseCommunication.Size = new System.Drawing.Size(196, 22);
            this.MenuItem_Unit_SE_UnitLoseCommunication.Text = "作战单元失去通信联系";
            this.MenuItem_Unit_SE_UnitLoseCommunication.Click += new System.EventHandler(this.Click_Unit_SE_UnitLoseCommunication);
            // 
            // MenuItem_Unit_SE_SetBearing
            // 
            this.MenuItem_Unit_SE_SetBearing.Name = "MenuItem_Unit_SE_SetBearing";
            this.MenuItem_Unit_SE_SetBearing.Size = new System.Drawing.Size(196, 22);
            this.MenuItem_Unit_SE_SetBearing.Text = "设置方位";
            this.MenuItem_Unit_SE_SetBearing.Click += new System.EventHandler(this.Click_Unit_SE_SetBearing);
            // 
            // MenuItem_Unit_SE_CopyUnitID
            // 
            this.MenuItem_Unit_SE_CopyUnitID.Name = "MenuItem_Unit_SE_CopyUnitID";
            this.MenuItem_Unit_SE_CopyUnitID.Size = new System.Drawing.Size(196, 22);
            this.MenuItem_Unit_SE_CopyUnitID.Text = "拷贝单元ID到剪切板";
            this.MenuItem_Unit_SE_CopyUnitID.Click += new System.EventHandler(this.Click_Unit_SE_CopyUnitID);
            // 
            // MenuItem_Unit_DischargeCargo
            // 
            this.MenuItem_Unit_DischargeCargo.Name = "MenuItem_Unit_DischargeCargo";
            this.MenuItem_Unit_DischargeCargo.Size = new System.Drawing.Size(280, 22);
            this.MenuItem_Unit_DischargeCargo.Text = "卸载货物";
            this.MenuItem_Unit_DischargeCargo.Click += new System.EventHandler(this.Click_Unit_DischargeCargo);
            // 
            // timer_1
            // 
            this.timer_1.Interval = 500;
            this.timer_1.Tick += new System.EventHandler(this.method_171);
            // 
            // backgroundWorker_0
            // 
            this.backgroundWorker_0.DoWork += new System.ComponentModel.DoWorkEventHandler(this.method_172);
            // 
            // timer_2
            // 
            this.timer_2.Tick += new System.EventHandler(this.method_176);
            // 
            // imageList_0
            // 
            this.imageList_0.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_0.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer_3
            // 
            this.timer_3.Interval = 1000;
            this.timer_3.Tick += new System.EventHandler(this.method_200);
            // 
            // openFileDialog_0
            // 
            this.openFileDialog_0.Multiselect = true;
            // 
            // contextMenuStrip_2
            // 
            this.contextMenuStrip_2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_ScenarioDescribe1,
            this.MenuItem_ScenarioDescribe0});
            this.contextMenuStrip_2.Name = "Cmenu_Refpoint";
            this.contextMenuStrip_2.Size = new System.Drawing.Size(157, 48);
            // 
            // MenuItem_ScenarioDescribe1
            // 
            this.MenuItem_ScenarioDescribe1.Name = "MenuItem_ScenarioDescribe1";
            this.MenuItem_ScenarioDescribe1.Size = new System.Drawing.Size(156, 22);
            this.MenuItem_ScenarioDescribe1.Text = "移动至...";
            // 
            // MenuItem_ScenarioDescribe0
            // 
            this.MenuItem_ScenarioDescribe0.Name = "MenuItem_ScenarioDescribe0";
            this.MenuItem_ScenarioDescribe0.ShortcutKeyDisplayString = "Ctrl+Del";
            this.MenuItem_ScenarioDescribe0.Size = new System.Drawing.Size(156, 22);
            this.MenuItem_ScenarioDescribe0.Text = "删除";
            this.MenuItem_ScenarioDescribe0.Click += new System.EventHandler(this.method_249);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(701, 1);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(75, 21);
            this.button_0.TabIndex = 24;
            this.button_0.Text = "测试";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Visible = false;
            this.button_0.Click += new System.EventHandler(this.method_294);
            // 
            // checkBox_0
            // 
            this.checkBox_0.Location = new System.Drawing.Point(782, 4);
            this.checkBox_0.Name = "checkBox_0";
            this.checkBox_0.Size = new System.Drawing.Size(46, 17);
            this.checkBox_0.TabIndex = 25;
            this.checkBox_0.Text = "CB1";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_0.Visible = false;
            // 
            // contextMenuStrip_3
            // 
            this.contextMenuStrip_3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_156,
            this.toolStripMenuItem_157,
            this.toolStripMenuItem_158});
            this.contextMenuStrip_3.Name = "CMenu_Waypoint";
            this.contextMenuStrip_3.Size = new System.Drawing.Size(358, 70);
            // 
            // toolStripMenuItem_156
            // 
            this.toolStripMenuItem_156.Name = "toolStripMenuItem_156";
            this.toolStripMenuItem_156.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.toolStripMenuItem_156.Size = new System.Drawing.Size(357, 22);
            this.toolStripMenuItem_156.Text = "油门-高度/深度";
            this.toolStripMenuItem_156.Click += new System.EventHandler(this.method_367);
            // 
            // toolStripMenuItem_157
            // 
            this.toolStripMenuItem_157.Name = "toolStripMenuItem_157";
            this.toolStripMenuItem_157.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.toolStripMenuItem_157.Size = new System.Drawing.Size(357, 22);
            this.toolStripMenuItem_157.Text = "传感器状态管理";
            this.toolStripMenuItem_157.Click += new System.EventHandler(this.method_321);
            // 
            // toolStripMenuItem_158
            // 
            this.toolStripMenuItem_158.Name = "toolStripMenuItem_158";
            this.toolStripMenuItem_158.ShortcutKeyDisplayString = "Ctrl+F9";
            this.toolStripMenuItem_158.Size = new System.Drawing.Size(357, 22);
            this.toolStripMenuItem_158.Text = "作战条令/交战规则/电磁管控/武器使用规则";
            this.toolStripMenuItem_158.Click += new System.EventHandler(this.method_259);
            // 
            // contextMenuStrip_4
            // 
            this.contextMenuStrip_4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_352,
            this.toolStripSeparator_34,
            this.toolStripMenuItem_348,
            this.toolStripMenuItem_349,
            this.toolStripMenuItem_350,
            this.toolStripMenuItem_351,
            this.toolStripSeparator_35,
            this.toolStripMenuItem_353,
            this.toolStripMenuItem_311});
            this.contextMenuStrip_4.Name = "CMenu_Contact";
            this.contextMenuStrip_4.Size = new System.Drawing.Size(260, 170);
            // 
            // toolStripMenuItem_352
            // 
            this.toolStripMenuItem_352.Name = "toolStripMenuItem_352";
            this.toolStripMenuItem_352.ShortcutKeyDisplayString = "P / PgDn /数字键3";
            this.toolStripMenuItem_352.Size = new System.Drawing.Size(259, 22);
            this.toolStripMenuItem_352.Text = "放弃探测目标";
            this.toolStripMenuItem_352.Click += new System.EventHandler(this.method_539);
            // 
            // toolStripSeparator_34
            // 
            this.toolStripSeparator_34.Name = "toolStripSeparator_34";
            this.toolStripSeparator_34.Size = new System.Drawing.Size(256, 6);
            // 
            // toolStripMenuItem_348
            // 
            this.toolStripMenuItem_348.ForeColor = System.Drawing.Color.Red;
            this.toolStripMenuItem_348.Name = "toolStripMenuItem_348";
            this.toolStripMenuItem_348.ShortcutKeyDisplayString = "H";
            this.toolStripMenuItem_348.Size = new System.Drawing.Size(259, 22);
            this.toolStripMenuItem_348.Text = "标识为敌方";
            this.toolStripMenuItem_348.Click += new System.EventHandler(this.method_511);
            // 
            // toolStripMenuItem_349
            // 
            this.toolStripMenuItem_349.ForeColor = System.Drawing.Color.Orange;
            this.toolStripMenuItem_349.Name = "toolStripMenuItem_349";
            this.toolStripMenuItem_349.ShortcutKeyDisplayString = "Ctrl+H";
            this.toolStripMenuItem_349.Size = new System.Drawing.Size(259, 22);
            this.toolStripMenuItem_349.Text = "标识为非友方";
            this.toolStripMenuItem_349.Click += new System.EventHandler(this.method_510);
            // 
            // toolStripMenuItem_350
            // 
            this.toolStripMenuItem_350.ForeColor = System.Drawing.Color.LimeGreen;
            this.toolStripMenuItem_350.Name = "toolStripMenuItem_350";
            this.toolStripMenuItem_350.ShortcutKeyDisplayString = "N";
            this.toolStripMenuItem_350.Size = new System.Drawing.Size(259, 22);
            this.toolStripMenuItem_350.Text = "标识为中立方";
            this.toolStripMenuItem_350.Click += new System.EventHandler(this.method_509);
            // 
            // toolStripMenuItem_351
            // 
            this.toolStripMenuItem_351.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolStripMenuItem_351.Name = "toolStripMenuItem_351";
            this.toolStripMenuItem_351.ShortcutKeyDisplayString = "F";
            this.toolStripMenuItem_351.Size = new System.Drawing.Size(259, 22);
            this.toolStripMenuItem_351.Text = "标识为友方";
            this.toolStripMenuItem_351.Click += new System.EventHandler(this.method_508);
            // 
            // toolStripSeparator_35
            // 
            this.toolStripSeparator_35.Name = "toolStripSeparator_35";
            this.toolStripSeparator_35.Size = new System.Drawing.Size(256, 6);
            // 
            // toolStripMenuItem_353
            // 
            this.toolStripMenuItem_353.Name = "toolStripMenuItem_353";
            this.toolStripMenuItem_353.ShortcutKeyDisplayString = "R";
            this.toolStripMenuItem_353.Size = new System.Drawing.Size(259, 22);
            this.toolStripMenuItem_353.Text = "重新命名";
            this.toolStripMenuItem_353.Click += new System.EventHandler(this.method_538);
            // 
            // toolStripMenuItem_311
            // 
            this.toolStripMenuItem_311.Name = "toolStripMenuItem_311";
            this.toolStripMenuItem_311.Size = new System.Drawing.Size(259, 22);
            this.toolStripMenuItem_311.Text = "过滤";
            this.toolStripMenuItem_311.Click += new System.EventHandler(this.method_512);
            // 
            // timer_4
            // 
            this.timer_4.Interval = 1000;
            this.timer_4.Tick += new System.EventHandler(this.method_513);
            // 
            // openFileDialog_3
            // 
            this.openFileDialog_3.FileName = "OpenFileDialog1";
            // 
            // timer_5
            // 
            this.timer_5.Interval = 60000;
            this.timer_5.Tick += new System.EventHandler(this.method_542);
            // 
            // timer_6
            // 
            this.timer_6.Interval = 1000;
            this.timer_6.Tick += new System.EventHandler(this.method_543);
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.BackColor = System.Drawing.Color.Black;
            this.label_0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_0.ForeColor = System.Drawing.Color.White;
            this.label_0.Location = new System.Drawing.Point(7, 56);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(120, 19);
            this.label_0.TabIndex = 15;
            this.label_0.Text = "Label_Caption";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label_1.ForeColor = System.Drawing.Color.White;
            this.label_1.Location = new System.Drawing.Point(138, 62);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(72, 13);
            this.label_1.TabIndex = 13;
            this.label_1.Text = "Label_Coords";
            // 
            // WorldMapBox
            // 
            this.WorldMapBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WorldMapBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorldMapBox.Location = new System.Drawing.Point(0, 0);
            this.WorldMapBox.Name = "WorldMapBox";
            this.WorldMapBox.Size = new System.Drawing.Size(1016, 701);
            this.WorldMapBox.TabIndex = 10;
            this.WorldMapBox.TabStop = false;
            this.WorldMapBox.Paint += new System.Windows.Forms.PaintEventHandler(this.WorldMapBox_Paint);
            this.WorldMapBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WorldMapBox_MouseDown);
            this.WorldMapBox.MouseEnter += new System.EventHandler(this.WorldMapBox_MouseEnter);
            this.WorldMapBox.MouseLeave += new System.EventHandler(this.WorldMapBox_MouseLeave);
            this.WorldMapBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WorldMapBox_MouseMove);
            this.WorldMapBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WorldMapBox_MouseUp);
            this.WorldMapBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.WorldMapBox_MouseWheel);
            this.WorldMapBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.WorldMapBox_PreviewKeyDown);
            this.WorldMapBox.Resize += new System.EventHandler(this.WorldMapBox_Resize);
            // 
            // panel_0
            // 
            this.panel_0.Controls.Add(this.WorldMapBox);
            this.panel_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_0.Location = new System.Drawing.Point(0, 0);
            this.panel_0.Name = "panel_0";
            this.panel_0.Size = new System.Drawing.Size(1016, 701);
            this.panel_0.TabIndex = 28;
            // 
            // elementHost_0
            // 
            this.elementHost_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementHost_0.BackColor = System.Drawing.Color.Transparent;
            this.elementHost_0.BackColorTransparent = true;
            this.elementHost_0.Location = new System.Drawing.Point(746, 49);
            this.elementHost_0.Margin = new System.Windows.Forms.Padding(0);
            this.elementHost_0.Name = "elementHost_0";
            this.elementHost_0.Size = new System.Drawing.Size(270, 3000);
            this.elementHost_0.TabIndex = 27;
            this.elementHost_0.Text = "ElementHost1";
            this.elementHost_0.Child = this.rightColumnWPF_0;
            // 
            // 启动UDP服务ToolStripMenuItem
            // 
            this.启动UDP服务ToolStripMenuItem.Name = "启动UDP服务ToolStripMenuItem";
            this.启动UDP服务ToolStripMenuItem.Size = new System.Drawing.Size(345, 22);
            this.启动UDP服务ToolStripMenuItem.Text = "启动UDP服务";
            this.启动UDP服务ToolStripMenuItem.Click += new System.EventHandler(this.启动UDP服务ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1016, 723);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.label_0);
            this.Controls.Add(this.checkBox_0);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.toolStrip_0);
            this.Controls.Add(this.menuStrip_0);
            this.Controls.Add(this.elementHost_0);
            this.Controls.Add(this.panel_0);
            this.Controls.Add(this.statusStrip_0);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip_0;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command";
            this.menuStrip_0.ResumeLayout(false);
            this.menuStrip_0.PerformLayout();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.contextMenuStrip_0.ResumeLayout(false);
            this.statusStrip_0.ResumeLayout(false);
            this.statusStrip_0.PerformLayout();
            this.contextMenuStrip_1.ResumeLayout(false);
            this.contextMenuStrip_2.ResumeLayout(false);
            this.contextMenuStrip_3.ResumeLayout(false);
            this.contextMenuStrip_4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorldMapBox)).EndInit();
            this.panel_0.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04003EFF RID: 16127
		private global::System.ComponentModel.IContainer icontainer_0;
        private IContainer components;
        public RightColumnWPF rightColumnWPF_0;
        private ToolStripMenuItem 启动UDP服务ToolStripMenuItem;
    }
}
