using Command;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns33;
using ns34;
using ns35;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns32
{
    [GeneratedCode("MyTemplate", "11.0.0.0")]
    public sealed class CommandFactory
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public sealed class CommandMain
        {
            [ThreadStatic]
            private static Hashtable hashtable_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AboutBox1 aboutBox1_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AddMagazine addMagazine_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AddMount addMount_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AddSensor addSensor_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AddSide addSide_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AddNewUnit addNewUnit_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AddWeaponRecord addWeaponRecord_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AirOps airOps_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public BrowseScenarioPlatforms browseScenarioPlatforms_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public CampaignEnd campaignEnd_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public CampaignPlayWindow campaignPlayWindow_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public CampaignScenarioWindow campaignScenarioWindow_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public CargoOps cargoOps_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ChooseSide chooseSide_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ConsoleWindow consoleWindow_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ContactReport contactReport_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public CustomLayersForm customLayersForm_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public DBViewer dbviewer_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public DockingOps dockingOps_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public EditAC editAC_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public EditBoats editBoats_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public EditBriefing editBriefing_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public EditCargo editCargo_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public EditEvent editEvent_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public EditWeather editWeather_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Evaluation evaluation_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_QuickTurnaround form_QuickTurnaround_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_SetFuelAndAirborneTime form_SetFuelAndAirborneTime_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormationEditor formationEditor_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Hotkeys hotkeys_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public InsufficientLicenseWindow insufficientLicenseWindow_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ListActions listActions_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ListConditions listConditions_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ListEvents listEvents_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ListSpecialActions listSpecialActions_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ListTriggers listTriggers_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public LoadGroup loadGroup_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public LoadSaveProgress loadSaveProgress_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public LoadScenario loadScenario_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Losses losses_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MainForm mainForm_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MainSplash mainSplash_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MCMWindow mcmwindow_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MessageLogWindow messageLogWindow_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Migration migration_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MissionEditor missionEditor_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MonteCarloForm monteCarloForm_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MultipleUnitSensors multipleUnitSensors_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public NoNavZonesWindow noNavZonesWindow_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Options options_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ORBAT orbat_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Postures postures_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ReadyAircraft readyAircraft_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public RealismDialog realismDialog_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public RegressionTests regressionTests_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public RenameObject renameObject_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ResumeFromSave resumeFromSave_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SatPredictionForm satPredictionForm_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SaveGroup saveGroup_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ScenarioTitle scenarioTitle_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ScenAttachmentsWindow scenAttachmentsWindow_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ScoringWindow scoringWindow_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SelectLoadout selectLoadout_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public LoadScenarioAttachment form1_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Sides sides_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SpecialActionsForm specialActionsForm_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SpeedAlt speedAlt_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public StartGame startGame_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SteamPublishScenarioForm steamPublishScenarioForm_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SteamUpdateScenarioForm steamUpdateScenarioForm_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public TankerPlanner tankerPlanner_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public TimesAndDuration timesAndDuration_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public TimeToReadyWindow timeToReadyWindow_0;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public TitleAndDescription titleAndDescription_0;

            private static T GetInstance<T>(T gparam_0) where T : Form, new()
            {
                T t = default(T);
                T result;
                if (gparam_0 != null && !gparam_0.IsDisposed)
                {
                    t = gparam_0;
                }
                else
                {
                    if (CommandFactory.CommandMain.hashtable_0 != null)
                    {
                        if (CommandFactory.CommandMain.hashtable_0.ContainsKey(typeof(T)))
                        {
                            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
                        }
                    }
                    else
                    {
                        CommandFactory.CommandMain.hashtable_0 = new Hashtable();
                    }
                    CommandFactory.CommandMain.hashtable_0.Add(typeof(T), null);
                    try
                    {
                        t = Activator.CreateInstance<T>();
                        result = t;
                        return result;
                    }
                    catch (TargetInvocationException ex)
                    {
                        if (ex != null)
                        {
                            ProjectData.SetProjectError(ex);
                            TargetInvocationException ex2 = ex;
                            if (ex2.InnerException == null)
                            {
                            }
                        }
                    }
                    finally
                    {
                        CommandFactory.CommandMain.hashtable_0.Remove(typeof(T));
                    }
                }
                result = t;
                return result;
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public CommandMain()
            {
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object obj)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(obj));
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString()
            {
                return base.ToString();
            }

            public AboutBox1 GetAboutBox()
            {
                this.aboutBox1_0 = CommandFactory.CommandMain.GetInstance<AboutBox1>(this.aboutBox1_0);
                return this.aboutBox1_0;
            }

            public AddMagazine GetAddMagazine()
            {
                this.addMagazine_0 = CommandFactory.CommandMain.GetInstance<AddMagazine>(this.addMagazine_0);
                return this.addMagazine_0;
            }

            public AddMount GetAddMount()
            {
                this.addMount_0 = CommandFactory.CommandMain.GetInstance<AddMount>(this.addMount_0);
                return this.addMount_0;
            }

            public AddSensor GetAddSensor()
            {
                this.addSensor_0 = CommandFactory.CommandMain.GetInstance<AddSensor>(this.addSensor_0);
                return this.addSensor_0;
            }

            public AddSide GetAddSide()
            {
                this.addSide_0 = CommandFactory.CommandMain.GetInstance<AddSide>(this.addSide_0);
                return this.addSide_0;
            }

            public AddNewUnit GetAddNewUnit()
            {
                this.addNewUnit_0 = CommandFactory.CommandMain.GetInstance<AddNewUnit>(this.addNewUnit_0);
                return this.addNewUnit_0;
            }

            public AddWeaponRecord GetAddWeaponRecord()
            {
                this.addWeaponRecord_0 = CommandFactory.CommandMain.GetInstance<AddWeaponRecord>(this.addWeaponRecord_0);
                return this.addWeaponRecord_0;
            }

            public AirOps GetAirOps()
            {
                this.airOps_0 = CommandFactory.CommandMain.GetInstance<AirOps>(this.airOps_0);
                return this.airOps_0;
            }

            public BrowseScenarioPlatforms GetBrowseScenarioPlatforms()
            {
                this.browseScenarioPlatforms_0 = CommandFactory.CommandMain.GetInstance<BrowseScenarioPlatforms>(this.browseScenarioPlatforms_0);
                return this.browseScenarioPlatforms_0;
            }

            public CampaignEnd GetCampaignEnd()
            {
                this.campaignEnd_0 = CommandFactory.CommandMain.GetInstance<CampaignEnd>(this.campaignEnd_0);
                return this.campaignEnd_0;
            }

            public CampaignPlayWindow GetCampaignPlayWindow()
            {
                this.campaignPlayWindow_0 = CommandFactory.CommandMain.GetInstance<CampaignPlayWindow>(this.campaignPlayWindow_0);
                return this.campaignPlayWindow_0;
            }

            public CampaignScenarioWindow GetCampaignScenarioWindow()
            {
                this.campaignScenarioWindow_0 = CommandFactory.CommandMain.GetInstance<CampaignScenarioWindow>(this.campaignScenarioWindow_0);
                return this.campaignScenarioWindow_0;
            }

            public CargoOps GetCargoOps()
            {
                this.cargoOps_0 = CommandFactory.CommandMain.GetInstance<CargoOps>(this.cargoOps_0);
                return this.cargoOps_0;
            }

            public ChooseSide GetChooseSide()
            {
                this.chooseSide_0 = CommandFactory.CommandMain.GetInstance<ChooseSide>(this.chooseSide_0);
                return this.chooseSide_0;
            }

            public ConsoleWindow GetLuaConsoleWindow()
            {
                this.consoleWindow_0 = CommandFactory.CommandMain.GetInstance<ConsoleWindow>(this.consoleWindow_0);
                return this.consoleWindow_0;
            }

            public ContactReport GetContactReport()
            {
                this.contactReport_0 = CommandFactory.CommandMain.GetInstance<ContactReport>(this.contactReport_0);
                return this.contactReport_0;
            }

            public CustomLayersForm GetCustomLayersForm()
            {
                this.customLayersForm_0 = CommandFactory.CommandMain.GetInstance<CustomLayersForm>(this.customLayersForm_0);
                return this.customLayersForm_0;
            }

            public DBViewer GetDBViewer()
            {
                this.dbviewer_0 = CommandFactory.CommandMain.GetInstance<DBViewer>(this.dbviewer_0);
                return this.dbviewer_0;
            }

            public DockingOps GetDockingOps()
            {
                this.dockingOps_0 = CommandFactory.CommandMain.GetInstance<DockingOps>(this.dockingOps_0);
                return this.dockingOps_0;
            }

            public EditAC GetEditAC()
            {
                this.editAC_0 = CommandFactory.CommandMain.GetInstance<EditAC>(this.editAC_0);
                return this.editAC_0;
            }

            public EditBoats GetEditBoats()
            {
                this.editBoats_0 = CommandFactory.CommandMain.GetInstance<EditBoats>(this.editBoats_0);
                return this.editBoats_0;
            }

            public EditBriefing GetEditBriefing()
            {
                this.editBriefing_0 = CommandFactory.CommandMain.GetInstance<EditBriefing>(this.editBriefing_0);
                return this.editBriefing_0;
            }

            public EditCargo GetEditCargo()
            {
                this.editCargo_0 = CommandFactory.CommandMain.GetInstance<EditCargo>(this.editCargo_0);
                return this.editCargo_0;
            }

            public EditEvent GetEditEvent()
            {
                this.editEvent_0 = CommandFactory.CommandMain.GetInstance<EditEvent>(this.editEvent_0);
                return this.editEvent_0;
            }

            public EditWeather GetEditWeather()
            {
                this.editWeather_0 = CommandFactory.CommandMain.GetInstance<EditWeather>(this.editWeather_0);
                return this.editWeather_0;
            }

            public Evaluation GetEvaluation()
            {
                this.evaluation_0 = CommandFactory.CommandMain.GetInstance<Evaluation>(this.evaluation_0);
                return this.evaluation_0;
            }

            public Form_QuickTurnaround GetForm_QuickTurnaround()
            {
                this.form_QuickTurnaround_0 = CommandFactory.CommandMain.GetInstance<Form_QuickTurnaround>(this.form_QuickTurnaround_0);
                return this.form_QuickTurnaround_0;
            }

            public Form_SetFuelAndAirborneTime GetForm_SetFuelAndAirborneTime()
            {
                this.form_SetFuelAndAirborneTime_0 = CommandFactory.CommandMain.GetInstance<Form_SetFuelAndAirborneTime>(this.form_SetFuelAndAirborneTime_0);
                return this.form_SetFuelAndAirborneTime_0;
            }

            public FormationEditor GetFormationEditor()
            {
                this.formationEditor_0 = CommandFactory.CommandMain.GetInstance<FormationEditor>(this.formationEditor_0);
                return this.formationEditor_0;
            }

            public Hotkeys GetHotkeys()
            {
                this.hotkeys_0 = CommandFactory.CommandMain.GetInstance<Hotkeys>(this.hotkeys_0);
                return this.hotkeys_0;
            }

            public InsufficientLicenseWindow GetInsufficientLicenseWindow()
            {
                this.insufficientLicenseWindow_0 = CommandFactory.CommandMain.GetInstance<InsufficientLicenseWindow>(this.insufficientLicenseWindow_0);
                return this.insufficientLicenseWindow_0;
            }

            public ListActions GetListActions()
            {
                this.listActions_0 = CommandFactory.CommandMain.GetInstance<ListActions>(this.listActions_0);
                return this.listActions_0;
            }

            public ListConditions GetListConditions()
            {
                this.listConditions_0 = CommandFactory.CommandMain.GetInstance<ListConditions>(this.listConditions_0);
                return this.listConditions_0;
            }

            public ListEvents GetListEvents()
            {
                this.listEvents_0 = CommandFactory.CommandMain.GetInstance<ListEvents>(this.listEvents_0);
                return this.listEvents_0;
            }

            public ListSpecialActions GetListSpecialActions()
            {
                this.listSpecialActions_0 = CommandFactory.CommandMain.GetInstance<ListSpecialActions>(this.listSpecialActions_0);
                return this.listSpecialActions_0;
            }

            public ListTriggers GetListTriggers()
            {
                this.listTriggers_0 = CommandFactory.CommandMain.GetInstance<ListTriggers>(this.listTriggers_0);
                return this.listTriggers_0;
            }

            public LoadGroup GetLoadGroup()
            {
                this.loadGroup_0 = CommandFactory.CommandMain.GetInstance<LoadGroup>(this.loadGroup_0);
                return this.loadGroup_0;
            }

            public LoadSaveProgress GetLoadSaveProgress()
            {
                this.loadSaveProgress_0 = CommandFactory.CommandMain.GetInstance<LoadSaveProgress>(this.loadSaveProgress_0);
                return this.loadSaveProgress_0;
            }

            public LoadScenario GetLoadScenario()
            {
                this.loadScenario_0 = CommandFactory.CommandMain.GetInstance<LoadScenario>(this.loadScenario_0);
                return this.loadScenario_0;
            }

            public Losses GetLosses()
            {
                this.losses_0 = CommandFactory.CommandMain.GetInstance<Losses>(this.losses_0);
                return this.losses_0;
            }

            public MainForm GetMainForm()
            {
                this.mainForm_0 = CommandFactory.CommandMain.GetInstance<MainForm>(this.mainForm_0);
                return this.mainForm_0;
            }

            public MainSplash GetMainSplash()
            {
                this.mainSplash_0 = CommandFactory.CommandMain.GetInstance<MainSplash>(this.mainSplash_0);
                return this.mainSplash_0;
            }

            public MCMWindow GetMCMWindow()
            {
                this.mcmwindow_0 = CommandFactory.CommandMain.GetInstance<MCMWindow>(this.mcmwindow_0);
                return this.mcmwindow_0;
            }

            public MessageLogWindow GetMessageLogWindow()
            {
                this.messageLogWindow_0 = CommandFactory.CommandMain.GetInstance<MessageLogWindow>(this.messageLogWindow_0);
                return this.messageLogWindow_0;
            }

            public Migration GetMigration()
            {
                this.migration_0 = CommandFactory.CommandMain.GetInstance<Migration>(this.migration_0);
                return this.migration_0;
            }

            public MissionEditor GetMissionEditor()
            {
                this.missionEditor_0 = CommandFactory.CommandMain.GetInstance<MissionEditor>(this.missionEditor_0);
                return this.missionEditor_0;
            }

            public MonteCarloForm GetMonteCarloForm()
            {
                this.monteCarloForm_0 = CommandFactory.CommandMain.GetInstance<MonteCarloForm>(this.monteCarloForm_0);
                return this.monteCarloForm_0;
            }

            public MultipleUnitSensors GetMultipleUnitSensors()
            {
                this.multipleUnitSensors_0 = CommandFactory.CommandMain.GetInstance<MultipleUnitSensors>(this.multipleUnitSensors_0);
                return this.multipleUnitSensors_0;
            }

            public NoNavZonesWindow GetNoNavZonesWindow()
            {
                this.noNavZonesWindow_0 = CommandFactory.CommandMain.GetInstance<NoNavZonesWindow>(this.noNavZonesWindow_0);
                return this.noNavZonesWindow_0;
            }

            public Options GetOptions()
            {
                this.options_0 = CommandFactory.CommandMain.GetInstance<Options>(this.options_0);
                return this.options_0;
            }

            public ORBAT GetORBAT()
            {
                this.orbat_0 = CommandFactory.CommandMain.GetInstance<ORBAT>(this.orbat_0);
                return this.orbat_0;
            }

            public Postures GetPostures()
            {
                this.postures_0 = CommandFactory.CommandMain.GetInstance<Postures>(this.postures_0);
                return this.postures_0;
            }

            public ReadyAircraft GetReadyAircraft()
            {
                this.readyAircraft_0 = CommandFactory.CommandMain.GetInstance<ReadyAircraft>(this.readyAircraft_0);
                return this.readyAircraft_0;
            }

            public RealismDialog GetRealismDialog()
            {
                this.realismDialog_0 = CommandFactory.CommandMain.GetInstance<RealismDialog>(this.realismDialog_0);
                return this.realismDialog_0;
            }

            public RegressionTests GetRegressionTests()
            {
                this.regressionTests_0 = CommandFactory.CommandMain.GetInstance<RegressionTests>(this.regressionTests_0);
                return this.regressionTests_0;
            }

            public RenameObject GetRenameObject()
            {
                this.renameObject_0 = CommandFactory.CommandMain.GetInstance<RenameObject>(this.renameObject_0);
                return this.renameObject_0;
            }

            public ResumeFromSave GetResumeFromSave()
            {
                this.resumeFromSave_0 = CommandFactory.CommandMain.GetInstance<ResumeFromSave>(this.resumeFromSave_0);
                return this.resumeFromSave_0;
            }

            public SatPredictionForm GetSatPredictionForm()
            {
                this.satPredictionForm_0 = CommandFactory.CommandMain.GetInstance<SatPredictionForm>(this.satPredictionForm_0);
                return this.satPredictionForm_0;
            }

            public SaveGroup GetSaveGroup()
            {
                this.saveGroup_0 = CommandFactory.CommandMain.GetInstance<SaveGroup>(this.saveGroup_0);
                return this.saveGroup_0;
            }

            public ScenarioTitle GetScenarioTitle()
            {
                this.scenarioTitle_0 = CommandFactory.CommandMain.GetInstance<ScenarioTitle>(this.scenarioTitle_0);
                return this.scenarioTitle_0;
            }

            public ScenAttachmentsWindow GetScenAttachmentsWindow()
            {
                this.scenAttachmentsWindow_0 = CommandFactory.CommandMain.GetInstance<ScenAttachmentsWindow>(this.scenAttachmentsWindow_0);
                return this.scenAttachmentsWindow_0;
            }

            public ScoringWindow GetScoringWindow()
            {
                this.scoringWindow_0 = CommandFactory.CommandMain.GetInstance<ScoringWindow>(this.scoringWindow_0);
                return this.scoringWindow_0;
            }

            public SelectLoadout GetSelectLoadout()
            {
                this.selectLoadout_0 = CommandFactory.CommandMain.GetInstance<SelectLoadout>(this.selectLoadout_0);
                return this.selectLoadout_0;
            }

            public LoadScenarioAttachment method_64()
            {
                this.form1_0 = CommandFactory.CommandMain.GetInstance<LoadScenarioAttachment>(this.form1_0);
                return this.form1_0;
            }

            public Sides GetSides()
            {
                this.sides_0 = CommandFactory.CommandMain.GetInstance<Sides>(this.sides_0);
                return this.sides_0;
            }

            public SpecialActionsForm GetSpecialActionsForm()
            {
                this.specialActionsForm_0 = CommandFactory.CommandMain.GetInstance<SpecialActionsForm>(this.specialActionsForm_0);
                return this.specialActionsForm_0;
            }

            public SpeedAlt GetSpeedAlt()
            {
                this.speedAlt_0 = CommandFactory.CommandMain.GetInstance<SpeedAlt>(this.speedAlt_0);
                return this.speedAlt_0;
            }

            public StartGame GetStartGame()
            {
                this.startGame_0 = CommandFactory.CommandMain.GetInstance<StartGame>(this.startGame_0);
                return this.startGame_0;
            }

            public SteamPublishScenarioForm GetSteamPublishScenarioForm()
            {
                this.steamPublishScenarioForm_0 = CommandFactory.CommandMain.GetInstance<SteamPublishScenarioForm>(this.steamPublishScenarioForm_0);
                return this.steamPublishScenarioForm_0;
            }

            public SteamUpdateScenarioForm GetSteamUpdateScenarioForm()
            {
                this.steamUpdateScenarioForm_0 = CommandFactory.CommandMain.GetInstance<SteamUpdateScenarioForm>(this.steamUpdateScenarioForm_0);
                return this.steamUpdateScenarioForm_0;
            }

            public TankerPlanner GetTankerPlanner()
            {
                this.tankerPlanner_0 = CommandFactory.CommandMain.GetInstance<TankerPlanner>(this.tankerPlanner_0);
                return this.tankerPlanner_0;
            }

            public TimesAndDuration GetTimesAndDuration()
            {
                this.timesAndDuration_0 = CommandFactory.CommandMain.GetInstance<TimesAndDuration>(this.timesAndDuration_0);
                return this.timesAndDuration_0;
            }

            public TimeToReadyWindow GetTimeToReadyWindow()
            {
                this.timeToReadyWindow_0 = CommandFactory.CommandMain.GetInstance<TimeToReadyWindow>(this.timeToReadyWindow_0);
                return this.timeToReadyWindow_0;
            }

            public TitleAndDescription GetTitleAndDescription()
            {
                this.titleAndDescription_0 = CommandFactory.CommandMain.GetInstance<TitleAndDescription>(this.titleAndDescription_0);
                return this.titleAndDescription_0;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public sealed class Class2468
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object obj)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(obj));
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString()
            {
                return base.ToString();
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Class2468()
            {
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), ComVisible(false)]
        public sealed class SingletonMaker<T> where T : new()
        {
            [CompilerGenerated, ThreadStatic]
            private static T gparam_0;

            internal T GetInstance()
            {
                if (CommandFactory.SingletonMaker<T>.gparam_0 == null)
                {
                    CommandFactory.SingletonMaker<T>.gparam_0 = Activator.CreateInstance<T>();
                }
                return CommandFactory.SingletonMaker<T>.gparam_0;
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SingletonMaker()
            {
            }
        }

        private static readonly CommandFactory.SingletonMaker<MyComputer> myComputer = new CommandFactory.SingletonMaker<MyComputer>();

        private static readonly CommandFactory.SingletonMaker<CommandApp> commandApp = new CommandFactory.SingletonMaker<CommandApp>();

        private static readonly CommandFactory.SingletonMaker<User> user = new CommandFactory.SingletonMaker<User>();

        private static CommandFactory.SingletonMaker<CommandFactory.CommandMain> commandMain = new CommandFactory.SingletonMaker<CommandFactory.CommandMain>();

        private static readonly CommandFactory.SingletonMaker<CommandFactory.Class2468> class2469_4 = new CommandFactory.SingletonMaker<CommandFactory.Class2468>();

        internal static MyComputer GetComputer()
        {
            return CommandFactory.myComputer.GetInstance();
        }

        internal static CommandApp GetCommandApp()
        {
            return CommandFactory.commandApp.GetInstance();
        }

        internal static CommandFactory.CommandMain GetCommandMain()
        {
            return CommandFactory.commandMain.GetInstance();
        }
    }
}
