using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Command_Core.DAL;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 想定
	[Serializable]
	public sealed class Scenario
	{
		// Token: 0x06005CA3 RID: 23715 RVA: 0x002AC85C File Offset: 0x002AAA5C
		[CompilerGenerated]
		public  ObservableDictionary<string, ActiveUnit> GetActiveUnits()
		{
			return this._ActiveUnits;
		}

		// Token: 0x06005CA4 RID: 23716 RVA: 0x002AC874 File Offset: 0x002AAA74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void SetActiveUnits(ObservableDictionary<string, ActiveUnit> observableDictionary_0)
		{
			INotifyDictionaryChanged<string, ActiveUnit>.DictionaryChangedEventHandler value = new INotifyDictionaryChanged<string, ActiveUnit>.DictionaryChangedEventHandler(this.ActiveUnits_DictionaryChanged);
			ObservableDictionary<string, ActiveUnit> activeUnits = this._ActiveUnits;
			if (activeUnits != null)
			{
				activeUnits.DictionaryChanged -= value;
			}
			this._ActiveUnits = observableDictionary_0;
			activeUnits = this._ActiveUnits;
			if (activeUnits != null)
			{
				activeUnits.DictionaryChanged += value;
			}
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x002AC8C0 File Offset: 0x002AAAC0
		[CompilerGenerated]
		public  ObservableDictionary<string, ScenAttachmentObject> GetScenAttachments()
		{
			return this._ScenAttachments;
		}

		// Token: 0x06005CA6 RID: 23718 RVA: 0x002AC8D8 File Offset: 0x002AAAD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void SetScenAttachmentEvent(ObservableDictionary<string, ScenAttachmentObject> observableDictionary_0)
		{
			INotifyDictionaryChanged<string, ScenAttachmentObject>.DictionaryChangedEventHandler value = new INotifyDictionaryChanged<string, ScenAttachmentObject>.DictionaryChangedEventHandler(this.ScenAttachments_DictionaryChanged);
			ObservableDictionary<string, ScenAttachmentObject> scenAttachments = this._ScenAttachments;
			if (scenAttachments != null)
			{
				scenAttachments.DictionaryChanged -= value;
			}
			this._ScenAttachments = observableDictionary_0;
			scenAttachments = this._ScenAttachments;
			if (scenAttachments != null)
			{
				scenAttachments.DictionaryChanged += value;
			}
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x002AC924 File Offset: 0x002AAB24
		[CompilerGenerated]
		public  ObservableDictionary<string, EventTrigger> GetEventTriggers()
		{
			return this._EventTriggers;
		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x002AC93C File Offset: 0x002AAB3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void SetEventTriggersEvent(ObservableDictionary<string, EventTrigger> observableDictionary_0)
		{
			INotifyDictionaryChanged<string, EventTrigger>.DictionaryChangedEventHandler value = new INotifyDictionaryChanged<string, EventTrigger>.DictionaryChangedEventHandler(this.EventTriggers_DictionaryChanged);
			ObservableDictionary<string, EventTrigger> eventTriggers = this._EventTriggers;
			if (eventTriggers != null)
			{
				eventTriggers.DictionaryChanged -= value;
			}
			this._EventTriggers = observableDictionary_0;
			eventTriggers = this._EventTriggers;
			if (eventTriggers != null)
			{
				eventTriggers.DictionaryChanged += value;
			}
		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x002AC988 File Offset: 0x002AAB88
		[CompilerGenerated]
		public  ObservableDictionary<string, EventCondition> GetEventConditions()
		{
			return this._EventConditions;
		}

		// Token: 0x06005CAA RID: 23722 RVA: 0x002AC9A0 File Offset: 0x002AABA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
        public  void SetEventConditions(ObservableDictionary<string, EventCondition> observableDictionary_0)
		{
			INotifyDictionaryChanged<string, EventCondition>.DictionaryChangedEventHandler value = new INotifyDictionaryChanged<string, EventCondition>.DictionaryChangedEventHandler(this.EventConditions_DictionaryChanged);
			ObservableDictionary<string, EventCondition> eventConditions = this._EventConditions;
			if (eventConditions != null)
			{
				eventConditions.DictionaryChanged -= value;
			}
			this._EventConditions = observableDictionary_0;
			eventConditions = this._EventConditions;
			if (eventConditions != null)
			{
				eventConditions.DictionaryChanged += value;
			}
		}

		// Token: 0x06005CAB RID: 23723 RVA: 0x002AC9EC File Offset: 0x002AABEC
		[CompilerGenerated]
		public  ObservableDictionary<string, EventAction> GetEventActions()
		{
			return this._EventActions;
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x002ACA04 File Offset: 0x002AAC04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void SetEventActions(ObservableDictionary<string, EventAction> observableDictionary_0)
		{
			INotifyDictionaryChanged<string, EventAction>.DictionaryChangedEventHandler value = new INotifyDictionaryChanged<string, EventAction>.DictionaryChangedEventHandler(this.EventActions_DictionaryChanged);
			ObservableDictionary<string, EventAction> eventActions = this._EventActions;
			if (eventActions != null)
			{
				eventActions.DictionaryChanged -= value;
			}
			this._EventActions = observableDictionary_0;
			eventActions = this._EventActions;
			if (eventActions != null)
			{
				eventActions.DictionaryChanged += value;
			}
		}

		// Token: 0x06005CAD RID: 23725 RVA: 0x002ACA50 File Offset: 0x002AAC50
		[CompilerGenerated]
		public  ObservableDictionary<string, SimEvent> GetSimEvents()
		{
			return this._SimEvents;
		}

		// Token: 0x06005CAE RID: 23726 RVA: 0x00029554 File Offset: 0x00027754
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void SetSimEvents(ObservableDictionary<string, SimEvent> observableDictionary_0)
		{
			this._SimEvents = observableDictionary_0;
		}

		// Token: 0x06005CAF RID: 23727 RVA: 0x002ACA68 File Offset: 0x002AAC68
		[CompilerGenerated]
		public  ObservableCollection<Explosion> GetExplosions()
		{
			return this._Explosions;
		}

		// Token: 0x06005CB0 RID: 23728 RVA: 0x0002955D File Offset: 0x0002775D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void SetExplosions(ObservableCollection<Explosion> observableCollection_0)
		{
			this._Explosions = observableCollection_0;
		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x002ACA80 File Offset: 0x002AAC80
		[CompilerGenerated]
		public  ObservableCollection<WeaponImpact> GetWeaponImpacts()
		{
			return this._WeaponImpacts;
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x002ACA98 File Offset: 0x002AAC98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void SetWeaponImpacts(ObservableCollection<WeaponImpact> observableCollection_0)
		{
			NotifyCollectionChangedEventHandler value = new NotifyCollectionChangedEventHandler(this._WeaponImpacts_CollectionChanged);
			ObservableCollection<WeaponImpact> weaponImpacts = this._WeaponImpacts;
			if (weaponImpacts != null)
			{
				weaponImpacts.CollectionChanged -= value;
			}
			this._WeaponImpacts = observableCollection_0;
			weaponImpacts = this._WeaponImpacts;
			if (weaponImpacts != null)
			{
				weaponImpacts.CollectionChanged += value;
			}
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x002ACAE4 File Offset: 0x002AACE4
		[CompilerGenerated]
		public  ObservableCollection<WaterSplash> GetWaterSplashes()
		{
			return this._WaterSplashes;
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x00029566 File Offset: 0x00027766
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void SetWaterSplashes(ObservableCollection<WaterSplash> observableCollection_0)
		{
			this._WaterSplashes = observableCollection_0;
		}

		// Token: 0x06005CB5 RID: 23733 RVA: 0x002ACAFC File Offset: 0x002AACFC
		[CompilerGenerated]
		public  ObservableCollection<GroundImpact> GetGroundImpacts()
		{
			return this._GroundImpacts;
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x002ACB14 File Offset: 0x002AAD14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void SetGroundImpacts(ObservableCollection<GroundImpact> observableCollection_0)
		{
			NotifyCollectionChangedEventHandler value = new NotifyCollectionChangedEventHandler(this._GroundImpacts_CollectionChanged);
			ObservableCollection<GroundImpact> groundImpacts = this._GroundImpacts;
			if (groundImpacts != null)
			{
				groundImpacts.CollectionChanged -= value;
			}
			this._GroundImpacts = observableCollection_0;
			groundImpacts = this._GroundImpacts;
			if (groundImpacts != null)
			{
				groundImpacts.CollectionChanged += value;
			}
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x002ACB60 File Offset: 0x002AAD60
		[CompilerGenerated]
		public  ObservableDictionary<string, UnguidedWeapon> GetUnguidedWeapons()
		{
			return this._UnguidedWeapons;
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x002ACB78 File Offset: 0x002AAD78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void SetUnguidedWeapons(ObservableDictionary<string, UnguidedWeapon> observableDictionary_0)
		{
			INotifyDictionaryChanged<string, UnguidedWeapon>.DictionaryChangedEventHandler value = new INotifyDictionaryChanged<string, UnguidedWeapon>.DictionaryChangedEventHandler(this._UnguidedWeapons_DictionaryChanged);
			ObservableDictionary<string, UnguidedWeapon> unguidedWeapons = this._UnguidedWeapons;
			if (unguidedWeapons != null)
			{
				unguidedWeapons.DictionaryChanged -= value;
			}
			this._UnguidedWeapons = observableDictionary_0;
			unguidedWeapons = this._UnguidedWeapons;
			if (unguidedWeapons != null)
			{
				unguidedWeapons.DictionaryChanged += value;
			}
		}

		// Token: 0x06005CB9 RID: 23737 RVA: 0x002ACBC4 File Offset: 0x002AADC4
		[CompilerGenerated]
		public static void AddTitleChangedEvent(Scenario.TitleChangedEventHandler titleChangedEventHandler_0)
		{
			Scenario.TitleChangedEventHandler titleChangedEventHandler = Scenario.TitleChangedEvent;
			Scenario.TitleChangedEventHandler titleChangedEventHandler2;
			do
			{
				titleChangedEventHandler2 = titleChangedEventHandler;
				Scenario.TitleChangedEventHandler value = (Scenario.TitleChangedEventHandler)Delegate.Combine(titleChangedEventHandler2, titleChangedEventHandler_0);
				titleChangedEventHandler = Interlocked.CompareExchange<Scenario.TitleChangedEventHandler>(ref Scenario.TitleChangedEvent, value, titleChangedEventHandler2);
			}
			while (titleChangedEventHandler != titleChangedEventHandler2);
		}

		// Token: 0x06005CBA RID: 23738 RVA: 0x002ACBFC File Offset: 0x002AADFC
		[CompilerGenerated]
		public static void AddCurrentSideChangedEventHandler(Scenario.CurrentSideChangedEventHandler currentSideChangedEventHandler_0)
		{
			Scenario.CurrentSideChangedEventHandler currentSideChangedEventHandler = Scenario.CurrentSideChangedEvent;
			Scenario.CurrentSideChangedEventHandler currentSideChangedEventHandler2;
			do
			{
				currentSideChangedEventHandler2 = currentSideChangedEventHandler;
				Scenario.CurrentSideChangedEventHandler value = (Scenario.CurrentSideChangedEventHandler)Delegate.Combine(currentSideChangedEventHandler2, currentSideChangedEventHandler_0);
				currentSideChangedEventHandler = Interlocked.CompareExchange<Scenario.CurrentSideChangedEventHandler>(ref Scenario.CurrentSideChangedEvent, value, currentSideChangedEventHandler2);
			}
			while (currentSideChangedEventHandler != currentSideChangedEventHandler2);
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x002ACC34 File Offset: 0x002AAE34
		[CompilerGenerated]
		public static void AddSidesChangedEventHandler(Scenario.SidesChangedEventHandler sidesChangedEventHandler_0)
		{
			Scenario.SidesChangedEventHandler sidesChangedEventHandler = Scenario.SidesChangedEvent;
			Scenario.SidesChangedEventHandler sidesChangedEventHandler2;
			do
			{
				sidesChangedEventHandler2 = sidesChangedEventHandler;
				Scenario.SidesChangedEventHandler value = (Scenario.SidesChangedEventHandler)Delegate.Combine(sidesChangedEventHandler2, sidesChangedEventHandler_0);
				sidesChangedEventHandler = Interlocked.CompareExchange<Scenario.SidesChangedEventHandler>(ref Scenario.SidesChangedEvent, value, sidesChangedEventHandler2);
			}
			while (sidesChangedEventHandler != sidesChangedEventHandler2);
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x002ACC6C File Offset: 0x002AAE6C
		[CompilerGenerated]
		public static void AddTimeCompressionChangedEvent(Scenario.TimeCompressionChangedEventHandler timeCompressionChangedEventHandler_0)
		{
			Scenario.TimeCompressionChangedEventHandler timeCompressionChangedEventHandler = Scenario.TimeCompressionChangedEvent;
			Scenario.TimeCompressionChangedEventHandler timeCompressionChangedEventHandler2;
			do
			{
				timeCompressionChangedEventHandler2 = timeCompressionChangedEventHandler;
				Scenario.TimeCompressionChangedEventHandler value = (Scenario.TimeCompressionChangedEventHandler)Delegate.Combine(timeCompressionChangedEventHandler2, timeCompressionChangedEventHandler_0);
				timeCompressionChangedEventHandler = Interlocked.CompareExchange<Scenario.TimeCompressionChangedEventHandler>(ref Scenario.TimeCompressionChangedEvent, value, timeCompressionChangedEventHandler2);
			}
			while (timeCompressionChangedEventHandler != timeCompressionChangedEventHandler2);
		}

		// Token: 0x06005CBD RID: 23741 RVA: 0x002ACCA4 File Offset: 0x002AAEA4
		[CompilerGenerated]
		public static void AddUnitRemovedEvent(Scenario.UnitRemovedEventHandler unitRemovedEventHandler_0)
		{
			Scenario.UnitRemovedEventHandler unitRemovedEventHandler = Scenario.UnitRemovedEvent;
			Scenario.UnitRemovedEventHandler unitRemovedEventHandler2;
			do
			{
				unitRemovedEventHandler2 = unitRemovedEventHandler;
				Scenario.UnitRemovedEventHandler value = (Scenario.UnitRemovedEventHandler)Delegate.Combine(unitRemovedEventHandler2, unitRemovedEventHandler_0);
				unitRemovedEventHandler = Interlocked.CompareExchange<Scenario.UnitRemovedEventHandler>(ref Scenario.UnitRemovedEvent, value, unitRemovedEventHandler2);
			}
			while (unitRemovedEventHandler != unitRemovedEventHandler2);
		}

		// Token: 0x06005CBE RID: 23742 RVA: 0x002ACCDC File Offset: 0x002AAEDC
		[CompilerGenerated]
		public static void RemoveUnitRemovedEvent(Scenario.UnitRemovedEventHandler unitRemovedEventHandler_0)
		{
			Scenario.UnitRemovedEventHandler unitRemovedEventHandler = Scenario.UnitRemovedEvent;
			Scenario.UnitRemovedEventHandler unitRemovedEventHandler2;
			do
			{
				unitRemovedEventHandler2 = unitRemovedEventHandler;
				Scenario.UnitRemovedEventHandler value = (Scenario.UnitRemovedEventHandler)Delegate.Remove(unitRemovedEventHandler2, unitRemovedEventHandler_0);
				unitRemovedEventHandler = Interlocked.CompareExchange<Scenario.UnitRemovedEventHandler>(ref Scenario.UnitRemovedEvent, value, unitRemovedEventHandler2);
			}
			while (unitRemovedEventHandler != unitRemovedEventHandler2);
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x002ACD14 File Offset: 0x002AAF14
		[CompilerGenerated]
		public static void AddEventTriggersChangedEvent(Scenario.EventTriggersChangedEventHandler eventTriggersChangedEventHandler_0)
		{
			Scenario.EventTriggersChangedEventHandler eventTriggersChangedEventHandler = Scenario.EventTriggersChangedEvent;
			Scenario.EventTriggersChangedEventHandler eventTriggersChangedEventHandler2;
			do
			{
				eventTriggersChangedEventHandler2 = eventTriggersChangedEventHandler;
				Scenario.EventTriggersChangedEventHandler value = (Scenario.EventTriggersChangedEventHandler)Delegate.Combine(eventTriggersChangedEventHandler2, eventTriggersChangedEventHandler_0);
				eventTriggersChangedEventHandler = Interlocked.CompareExchange<Scenario.EventTriggersChangedEventHandler>(ref Scenario.EventTriggersChangedEvent, value, eventTriggersChangedEventHandler2);
			}
			while (eventTriggersChangedEventHandler != eventTriggersChangedEventHandler2);
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x002ACD4C File Offset: 0x002AAF4C
		[CompilerGenerated]
		public static void RemoveEventTriggersChangedEvent(Scenario.EventTriggersChangedEventHandler eventTriggersChangedEventHandler_0)
		{
			Scenario.EventTriggersChangedEventHandler eventTriggersChangedEventHandler = Scenario.EventTriggersChangedEvent;
			Scenario.EventTriggersChangedEventHandler eventTriggersChangedEventHandler2;
			do
			{
				eventTriggersChangedEventHandler2 = eventTriggersChangedEventHandler;
				Scenario.EventTriggersChangedEventHandler value = (Scenario.EventTriggersChangedEventHandler)Delegate.Remove(eventTriggersChangedEventHandler2, eventTriggersChangedEventHandler_0);
				eventTriggersChangedEventHandler = Interlocked.CompareExchange<Scenario.EventTriggersChangedEventHandler>(ref Scenario.EventTriggersChangedEvent, value, eventTriggersChangedEventHandler2);
			}
			while (eventTriggersChangedEventHandler != eventTriggersChangedEventHandler2);
		}

		// Token: 0x06005CC1 RID: 23745 RVA: 0x002ACD84 File Offset: 0x002AAF84
		[CompilerGenerated]
		public static void AddConditionsChangedEvent(Scenario.EventConditionsChangedEventHandler eventConditionsChangedEventHandler_0)
		{
			Scenario.EventConditionsChangedEventHandler eventConditionsChangedEventHandler = Scenario.EventConditionsChangedEvent;
			Scenario.EventConditionsChangedEventHandler eventConditionsChangedEventHandler2;
			do
			{
				eventConditionsChangedEventHandler2 = eventConditionsChangedEventHandler;
				Scenario.EventConditionsChangedEventHandler value = (Scenario.EventConditionsChangedEventHandler)Delegate.Combine(eventConditionsChangedEventHandler2, eventConditionsChangedEventHandler_0);
				eventConditionsChangedEventHandler = Interlocked.CompareExchange<Scenario.EventConditionsChangedEventHandler>(ref Scenario.EventConditionsChangedEvent, value, eventConditionsChangedEventHandler2);
			}
			while (eventConditionsChangedEventHandler != eventConditionsChangedEventHandler2);
		}

		// Token: 0x06005CC2 RID: 23746 RVA: 0x002ACDBC File Offset: 0x002AAFBC
		[CompilerGenerated]
		public static void RemoveConditionsChangedEvent(Scenario.EventConditionsChangedEventHandler eventConditionsChangedEventHandler_0)
		{
			Scenario.EventConditionsChangedEventHandler eventConditionsChangedEventHandler = Scenario.EventConditionsChangedEvent;
			Scenario.EventConditionsChangedEventHandler eventConditionsChangedEventHandler2;
			do
			{
				eventConditionsChangedEventHandler2 = eventConditionsChangedEventHandler;
				Scenario.EventConditionsChangedEventHandler value = (Scenario.EventConditionsChangedEventHandler)Delegate.Remove(eventConditionsChangedEventHandler2, eventConditionsChangedEventHandler_0);
				eventConditionsChangedEventHandler = Interlocked.CompareExchange<Scenario.EventConditionsChangedEventHandler>(ref Scenario.EventConditionsChangedEvent, value, eventConditionsChangedEventHandler2);
			}
			while (eventConditionsChangedEventHandler != eventConditionsChangedEventHandler2);
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x002ACDF4 File Offset: 0x002AAFF4
		[CompilerGenerated]
		public static void AddActionsChangedEvent(Scenario.EventActionsChangedEventHandler eventActionsChangedEventHandler_0)
		{
			Scenario.EventActionsChangedEventHandler eventActionsChangedEventHandler = Scenario.EventActionsChangedEvent;
			Scenario.EventActionsChangedEventHandler eventActionsChangedEventHandler2;
			do
			{
				eventActionsChangedEventHandler2 = eventActionsChangedEventHandler;
				Scenario.EventActionsChangedEventHandler value = (Scenario.EventActionsChangedEventHandler)Delegate.Combine(eventActionsChangedEventHandler2, eventActionsChangedEventHandler_0);
				eventActionsChangedEventHandler = Interlocked.CompareExchange<Scenario.EventActionsChangedEventHandler>(ref Scenario.EventActionsChangedEvent, value, eventActionsChangedEventHandler2);
			}
			while (eventActionsChangedEventHandler != eventActionsChangedEventHandler2);
		}

		// Token: 0x06005CC4 RID: 23748 RVA: 0x002ACE2C File Offset: 0x002AB02C
		[CompilerGenerated]
		public static void RemoveActionsChangedEvent(Scenario.EventActionsChangedEventHandler eventActionsChangedEventHandler_0)
		{
			Scenario.EventActionsChangedEventHandler eventActionsChangedEventHandler = Scenario.EventActionsChangedEvent;
			Scenario.EventActionsChangedEventHandler eventActionsChangedEventHandler2;
			do
			{
				eventActionsChangedEventHandler2 = eventActionsChangedEventHandler;
				Scenario.EventActionsChangedEventHandler value = (Scenario.EventActionsChangedEventHandler)Delegate.Remove(eventActionsChangedEventHandler2, eventActionsChangedEventHandler_0);
				eventActionsChangedEventHandler = Interlocked.CompareExchange<Scenario.EventActionsChangedEventHandler>(ref Scenario.EventActionsChangedEvent, value, eventActionsChangedEventHandler2);
			}
			while (eventActionsChangedEventHandler != eventActionsChangedEventHandler2);
		}

		// Token: 0x06005CC5 RID: 23749 RVA: 0x002ACE64 File Offset: 0x002AB064
		[CompilerGenerated]
		public static void AddScenCompletedEventHandler(Scenario.ScenCompletedEventHandler scenCompletedEventHandler_0)
		{
			Scenario.ScenCompletedEventHandler scenCompletedEventHandler = Scenario.ScenCompletedEvent;
			Scenario.ScenCompletedEventHandler scenCompletedEventHandler2;
			do
			{
				scenCompletedEventHandler2 = scenCompletedEventHandler;
				Scenario.ScenCompletedEventHandler value = (Scenario.ScenCompletedEventHandler)Delegate.Combine(scenCompletedEventHandler2, scenCompletedEventHandler_0);
				scenCompletedEventHandler = Interlocked.CompareExchange<Scenario.ScenCompletedEventHandler>(ref Scenario.ScenCompletedEvent, value, scenCompletedEventHandler2);
			}
			while (scenCompletedEventHandler != scenCompletedEventHandler2);
		}

		// Token: 0x06005CC6 RID: 23750 RVA: 0x002ACE9C File Offset: 0x002AB09C
		public string GetScenarioTitle()
		{
			return this._Title;
		}

		// Token: 0x06005CC7 RID: 23751 RVA: 0x002ACEB4 File Offset: 0x002AB0B4
		public void SetScenarioTitle(string string_0)
		{
			this._Title = string_0;
			Scenario.TitleChangedEventHandler titleChangedEvent = Scenario.TitleChangedEvent;
			if (titleChangedEvent != null)
			{
				titleChangedEvent(this, string_0);
			}
		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x002ACEDC File Offset: 0x002AB0DC
		public string GetObjectID()
		{
			if (string.IsNullOrEmpty(this._ObjectID))
			{
				this._ObjectID = Guid.NewGuid().ToString();
			}
			return this._ObjectID;
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x0002956F File Offset: 0x0002776F
		public void SetObjectID(string string_0)
		{
			this._ObjectID = string_0;
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x002ACF1C File Offset: 0x002AB11C
		public string GetDescription()
		{
			return this._Description;
		}

		// Token: 0x06005CCB RID: 23755 RVA: 0x00029578 File Offset: 0x00027778
		public void SetDescription(string string_0)
		{
			this._Description = string_0;
		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x002ACF34 File Offset: 0x002AB134
		public List<IEventExporter> GetEventExporters()
		{
			List<IEventExporter> result;
			if (this.RunningInMonteCarloMode)
			{
				result = EventExporters.listMonteCarlo;
			}
			else
			{
				result = EventExporters.listRegular;
			}
			return result;
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x002ACF60 File Offset: 0x002AB160
		public string GetDBUsed()
		{
			return this._DBUsed;
		}

		// Token: 0x06005CCE RID: 23758 RVA: 0x002ACF78 File Offset: 0x002AB178
		public void SetDBUsed(string string_0)
		{
			bool flag = string.IsNullOrEmpty(this._DBUsed) || string.IsNullOrEmpty(string_0) || Operators.CompareString(string_0, this._DBUsed, false) != 0;
			this._DBUsed = string_0;
			if (flag)
			{
				this._DBConnection = null;
				SQLiteConnection sQLiteConnection = this.GetSQLiteConnection();
				DBFunctions.LoadPlatformDataTables(ref this.Cache_Aircraft_DT, ref this.Cache_Ships_DT, ref this.Cache_Subs_DT, ref this.Cache_Facilities_DT, ref this.Cache_Satellites_DT, ref this.Cache_Weapons_DT, ref sQLiteConnection);
				sQLiteConnection = this.GetSQLiteConnection();
				this.Cache_OperatorCountries_DT = DBFunctions.GetOperatorCountryDataTable(ref sQLiteConnection);
			}
		}

		// Token: 0x06005CCF RID: 23759 RVA: 0x002AD00C File Offset: 0x002AB20C
		public void CheckDeclaredFeatures()
		{
			checked
			{
				if (!this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CargoOps))
				{
					using (List<ActiveUnit>.Enumerator enumerator = this.GetActiveUnitList().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.HasOnboardCargos())
							{
								this.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.CargoOps);
								break;
							}
						}
					}
					Side[] sides = this.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						using (IEnumerator<Mission> enumerator2 = side.GetPatrolMissionCollection(this).GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.MissionClass == Mission._MissionClass.Cargo)
								{
									this.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.CargoOps);
									break;
								}
							}
						}
					}
				}
				if (!this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CommsDisruption))
				{
					using (List<ActiveUnit>.Enumerator enumerator3 = this.GetActiveUnitList().GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							if (!enumerator3.Current.GetCommStuff().IsNotOutOfComms())
							{
								this.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.CommsDisruption);
								break;
							}
						}
					}
					foreach (EventAction current in this.GetEventActions().Values)
					{
						if (current.eventActionType == EventAction.EventActionType.LuaScript && Misc.smethod_64(((EventAction_LuaScript)current).ScriptText, "OUTOFCOMMS", StringComparison.OrdinalIgnoreCase))
						{
							this.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.CommsDisruption);
							break;
						}
					}
				}
				if (!this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.AircraftDamageModel))
				{
					foreach (ActiveUnit current2 in this.GetActiveUnitList())
					{
						if (current2.IsAircraft && current2.GetDamage().GetDamagePts() > 0f)
						{
							this.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.AircraftDamageModel);
							break;
						}
					}
				}
				if (!this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.EMP_Omni))
				{
					bool flag = false;
					using (List<ActiveUnit>.Enumerator enumerator6 = this.GetActiveUnitList().GetEnumerator())
					{
						while (enumerator6.MoveNext())
						{
							Weapon[] availableWeapons = enumerator6.Current.GetWeaponry().GetAvailableWeapons(true);
							for (int j = 0; j < availableWeapons.Length; j++)
							{
								Weapon weapon = availableWeapons[j];
								if (weapon.m_Warheads.Length > 0 && weapon.m_Warheads[0].IsEMP())
								{
									this.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.EMP_Omni);
									goto IL_2A0;
								}
							}
							if (flag)
							{
								break;
							}
						}
					}
				}
				IL_2A0:
				if (!this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.HighEnergyLasers))
				{
					bool flag2 = false;
					using (List<ActiveUnit>.Enumerator enumerator7 = this.GetActiveUnitList().GetEnumerator())
					{
						while (enumerator7.MoveNext())
						{
							Weapon[] availableWeapons2 = enumerator7.Current.GetWeaponry().GetAvailableWeapons(true);
							for (int k = 0; k < availableWeapons2.Length; k++)
							{
								Weapon weapon2 = availableWeapons2[k];
								if (weapon2.IsLaserWeapon())
								{
									int dBID = weapon2.DBID;
									if (dBID != 1203 && dBID != 3432)
									{
										this.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.HighEnergyLasers);
										goto IL_352;
									}
								}
							}
							if (flag2)
							{
								break;
							}
						}
					}
				}
				IL_352:
				if (!this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.RailgunOrHVP))
				{
					bool flag3 = false;
					using (List<ActiveUnit>.Enumerator enumerator8 = this.GetActiveUnitList().GetEnumerator())
					{
						while (enumerator8.MoveNext())
						{
							Weapon[] availableWeapons3 = enumerator8.Current.GetWeaponry().GetAvailableWeapons(true);
							for (int l = 0; l < availableWeapons3.Length; l++)
							{
								Weapon weapon3 = availableWeapons3[l];
								if (weapon3.GetWeaponType() == Weapon._WeaponType.GuidedProjectile && (weapon3.Name.ToLower().Contains("hvp") || weapon3.Name.ToLower().Contains("railgun")))
								{
									this.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.RailgunOrHVP);
                                    goto IL_353; 
								}
							}
							if (flag3)
							{
								break;
							}
						}
					}
				}
                //ZSP HGV
                IL_353:
                if (!this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.HGV))
                {
                    bool flag3 = false;
                    using (List<ActiveUnit>.Enumerator enumerator8 = this.GetActiveUnitList().GetEnumerator())
                    {
                        while (enumerator8.MoveNext())
                        {
                            Weapon[] availableWeapons3 = enumerator8.Current.GetWeaponry().GetAvailableWeapons(true);
                            for (int l = 0; l < availableWeapons3.Length; l++)
                            {
                                Weapon weapon3 = availableWeapons3[l];
                                if (weapon3.IsHypersonicGlideVehicle())
                                {
                                    this.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.HGV);
                                    return;
                                }
                            }
                            if (flag3)
                            {
                                break;
                            }
                        }
                    }
                }
            }
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x002AD49C File Offset: 0x002AB69C
		public bool IsLOSExistedBetweenTwoUnits(ref Scenario theScen, ref Unit SrcUnit, ref double Lat_Src, ref double Lon_Src, ref float Alt_Src, ref Unit DestUnit, ref double Lat_Dest, ref double Lon_Dest, ref float Alt_Dest, bool CheckCache, bool LandMassCheck, int ExtraSensorHeight = 0, bool IgnoreRadarHorizon = false)
		{
			bool result = false;
			try
			{
				float num = 900f;
				float num2 = 9000f;
				float num3 = 0f;
				float num4 = 18900f;
				double num5 = 0.0;
				double num6 = 0.0;
				double num7 = 0.0;
				Class258.smethod_3(Lat_Src, Lon_Src, (double)(Alt_Src + (float)ExtraSensorHeight), ref num5, ref num6, ref num7);
				double num8 = 0.0;
				double num9 = 0.0;
				double num10 = 0.0;
				Class258.smethod_3(Lat_Dest, Lon_Dest, (double)Alt_Dest, ref num8, ref num9, ref num10);
				double num11 = num8 - num5;
				double num12 = num9 - num6;
				double num13 = num10 - num7;
				double num14 = Math.Sqrt(num11 * num11 + num12 * num12 + num13 * num13);
				LinkedList<float> linkedList = new LinkedList<float>();
				if (num14 < (double)37800f)
				{
					for (double num15 = num14; num15 > (double)num; num15 -= (double)num)
					{
						num3 += num;
						if ((double)num3 > num14)
						{
							break;
						}
						linkedList.AddLast(num3);
					}
				}
				else
				{
					float num16 = num4;
					float num17 = num4;
					double num18 = num14 - (double)(num4 * 2f);
					float num19 = (float)(num14 - (double)num4);
					while (num16 > num)
					{
						num3 += num;
						if (num3 > num4)
						{
							break;
						}
						linkedList.AddLast(num3);
						num16 -= num;
					}
					if (num18 > (double)(num2 * 2f))
					{
						double num20 = num18;
						num3 = num4;
						while (num20 > (double)num2)
						{
							num3 += num2;
							if (num3 > num19)
							{
								break;
							}
							linkedList.AddLast(num3);
							num20 -= (double)num2;
						}
					}
					num3 = (float)num14 - num4;
					while (num17 > num)
					{
						num3 += num;
						if ((double)num3 > num14)
						{
							break;
						}
						linkedList.AddLast(num3);
						num17 -= num;
					}
				}
				bool flag = false;
				try
				{
					using (LinkedList<float>.Enumerator enumerator = linkedList.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							float num21 = (float)((double)enumerator.Current / num14);
							if (num21 <= 1f)
							{
								double double_ = num5 + num11 * (double)num21;
								double double_2 = num6 + num12 * (double)num21;
								double double_3 = num7 + num13 * (double)num21;
								double double_4 = 0.0;
								double double_5 = 0.0;
								double num22 = 0.0;
								Class258.smethod_4(double_, double_2, double_3, ref double_4, ref double_5, ref num22);
								if ((num22 <= (double)Alt_Src || num22 <= (double)Alt_Dest) && (num22 >= (double)Alt_Src || num22 >= (double)Alt_Dest))
								{
									short num23 = Class270.smethod_1(double_4, double_5);
									if (num22 <= (double)num23)
									{
										int elevation = (int)Terrain.GetElevation(double_4, double_5, false);
										if (LandMassCheck)
										{
											if (elevation <= 0)
											{
												continue;
											}
											flag = true;
										}
										else
										{
											if ((IgnoreRadarHorizon && elevation <= 0) || num22 > (double)elevation)
											{
												continue;
											}
											flag = true;
										}
										break;
									}
									flag = false;
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200463", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				result = !flag;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100872", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x002AD85C File Offset: 0x002ABA5C
		public LuaSandBox GetLuaSandBox()
		{
			if (Information.IsNothing(this._LuaSandbox))
			{
				this._LuaSandbox = new LuaSandBox(this);
			}
			return this._LuaSandbox;
		}

		// Token: 0x06005CD2 RID: 23762 RVA: 0x002AD890 File Offset: 0x002ABA90
		public void Serialize(Stream stream_0, bool bool_0)
		{
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			if (!bool_0)
			{
				xmlWriterSettings.Indent = true;
				xmlWriterSettings.IndentChars = "    ";
			}
			XmlWriter xmlWriter_ = XmlWriter.Create(stream_0, xmlWriterSettings);
			this.Save(xmlWriter_);
		}

		// Token: 0x06005CD3 RID: 23763 RVA: 0x002AD8C8 File Offset: 0x002ABAC8
		private void Save(XmlWriter xmlWriter_0)
		{
			checked
			{
				try
				{
					HashSet<string> hashSet_ = new HashSet<string>();
					using (xmlWriter_0)
					{
						if (string.IsNullOrEmpty(this.ContentTag))
						{
							xmlWriter_0.WriteStartElement("Scenario");
						}
						else
						{
							xmlWriter_0.WriteStartElement("ContentScenario");
						}
						xmlWriter_0.WriteElementString("TimelineID", this.TimelineID.ToString());
						xmlWriter_0.WriteElementString("ObjectID", this.GetObjectID().ToString());
						xmlWriter_0.WriteElementString("ContentTag", this.ContentTag);
						xmlWriter_0.WriteElementString("CampaignID", this.CampaignID);
						xmlWriter_0.WriteElementString("CampaignSessionID", this.CampaignSessionID);
						xmlWriter_0.WriteElementString("CampaignScore", this.CampaignScore.ToString());
						xmlWriter_0.WriteElementString("Title", this._Title);
						xmlWriter_0.WriteElementString("Description", this._Description);
						xmlWriter_0.WriteElementString("Meta_Complexity", Conversions.ToString((int)this.Meta_Complexity));
						xmlWriter_0.WriteElementString("Meta_Difficulty", Conversions.ToString((int)this.Meta_Difficulty));
						xmlWriter_0.WriteElementString("Meta_ScenSetting", this.Meta_ScenSetting);
						xmlWriter_0.WriteElementString("FileName", this.FileName);
						xmlWriter_0.WriteElementString("Time", this._Time.ToBinary().ToString());
						xmlWriter_0.WriteElementString("ZeroHour", this.ZeroHour.ToBinary().ToString());
						if (this._StartTime.HasValue)
						{
							xmlWriter_0.WriteElementString("StartTime", this._StartTime.Value.ToBinary().ToString());
						}
						if (this._Duration.HasValue)
						{
							xmlWriter_0.WriteElementString("Duration", this._Duration.Value.Ticks.ToString());
						}
						xmlWriter_0.WriteElementString("DaylightSavingTime", this._DaylightSavingTime.ToString());
						if (Information.IsNothing(this._DaylightSavingTime_Start))
						{
							this._DaylightSavingTime_Start = "00.00";
						}
						if (Information.IsNothing(this._DaylightSavingTime_End))
						{
							this._DaylightSavingTime_End = "00.00";
						}
						xmlWriter_0.WriteElementString("DaylightSavingTime_Start", this._DaylightSavingTime_Start.ToString());
						xmlWriter_0.WriteElementString("DaylightSavingTime_End", this._DaylightSavingTime_End.ToString());
						xmlWriter_0.WriteStartElement("Sides");
						Side[] sides = this.GetSides();
						for (int i = 0; i < sides.Length; i++)
						{
							Side side = sides[i];
							Scenario scenario = this;
							side.Save(ref xmlWriter_0, ref hashSet_, ref scenario);
							xmlWriter_0.Flush();
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("NonActiveUnits");
						xmlWriter_0.WriteStartElement("Explosions");
						using (IEnumerator<Explosion> enumerator = this.GetExplosions().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								enumerator.Current.Save(ref xmlWriter_0, ref hashSet_);
							}
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("WeaponImpacts");
						using (IEnumerator<WeaponImpact> enumerator2 = this.GetWeaponImpacts().GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								enumerator2.Current.Save(ref xmlWriter_0, ref hashSet_);
							}
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("UnguidedWeapons");
						using (IEnumerator<UnguidedWeapon> enumerator3 = this.GetUnguidedWeapons().Values.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.Save(ref xmlWriter_0, ref hashSet_);
								xmlWriter_0.Flush();
							}
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("ActiveUnits");
						using (List<ActiveUnit>.Enumerator enumerator4 = this.GetActiveUnitList().GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.Save(ref xmlWriter_0, ref hashSet_);
								xmlWriter_0.Flush();
							}
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Groups");
						foreach (Group current in this.Groups)
						{
							xmlWriter_0.WriteElementString("ID", current.GetGuid());
							xmlWriter_0.Flush();
						}
						xmlWriter_0.WriteEndElement();
						XmlWriter xmlWriter2 = xmlWriter_0;
						string localName = "WeatherModel";
						byte weatherLevel = (byte)this.WeatherLevel;
						xmlWriter2.WriteElementString(localName, weatherLevel.ToString());
						xmlWriter_0.WriteStartElement("GlobalWeather");
						this.GetWeatherProfile().Save(ref xmlWriter_0);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("EventTriggers");
						using (IEnumerator<EventTrigger> enumerator6 = this.GetEventTriggers().Values.GetEnumerator())
						{
							while (enumerator6.MoveNext())
							{
								enumerator6.Current.Save(xmlWriter_0, hashSet_, this);
							}
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("EventConditions");
						using (IEnumerator<EventCondition> enumerator7 = this.GetEventConditions().Values.GetEnumerator())
						{
							while (enumerator7.MoveNext())
							{
								enumerator7.Current.Save(xmlWriter_0, hashSet_, this);
							}
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("EventActions");
						using (IEnumerator<EventAction> enumerator8 = this.GetEventActions().Values.GetEnumerator())
						{
							while (enumerator8.MoveNext())
							{
								enumerator8.Current.Save(xmlWriter_0, hashSet_, this);
							}
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("SimEvents");
						using (IEnumerator<SimEvent> enumerator9 = this.GetSimEvents().Values.GetEnumerator())
						{
							while (enumerator9.MoveNext())
							{
								enumerator9.Current.Save(xmlWriter_0, hashSet_, this);
							}
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("ScenAttachmentObjects");
						using (IEnumerator<ScenAttachmentObject> enumerator10 = this.GetScenAttachments().Values.GetEnumerator())
						{
							while (enumerator10.MoveNext())
							{
								enumerator10.Current.Save(xmlWriter_0, hashSet_, this);
							}
						}
						xmlWriter_0.WriteEndElement();
						XmlWriter xmlWriter3 = xmlWriter_0;
						string localName2 = "TimeCompression";
						int timeCompression = (int)this._TimeCompression;
						xmlWriter3.WriteElementString(localName2, timeCompression.ToString());
						xmlWriter_0.WriteElementString("GameResolution", XmlConvert.ToString(this._GameResolution));
						this.SaveMessageLog(xmlWriter_0);
						xmlWriter_0.WriteElementString("MessageIncrement", this._MessageIncrement.ToString());
						xmlWriter_0.WriteElementString("UnitsAutoIncrement", this.UnitsAutoIncrement.ToString());
						if (!Information.IsNothing(this.GetCurrentSide()))
						{
							xmlWriter_0.WriteElementString("CurrentSide", this.GetCurrentSide().GetSideName());
						}
						xmlWriter_0.WriteElementString("GameVersion", this.GameVersion);
						xmlWriter_0.WriteElementString("DBUsed", this.GetDBUsed().ToString());
						if (this.LastSavedInScenEdit)
						{
							xmlWriter_0.WriteElementString("LastSavedInScenEdit", "True");
						}
						if (this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.DetailedGunFireControl))
						{
							xmlWriter_0.WriteElementString("Realism_DetailedGunFireControl", "True");
						}
						if (this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags))
						{
							xmlWriter_0.WriteElementString("Realism_UnlimitedBaseMags", "True");
						}
						if (this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CargoOps))
						{
							xmlWriter_0.WriteElementString("Realism_Cargo", "True");
						}
						if (this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CommsJamming))
						{
							xmlWriter_0.WriteElementString("Realism_CommsJamming", "True");
						}
						if (this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CommsDisruption))
						{
							xmlWriter_0.WriteElementString("Realism_CommsDisruption", "True");
						}
						if (this.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.AircraftDamageModel))
						{
							xmlWriter_0.WriteElementString("Realism_AircraftDamage", "True");
						}
						xmlWriter_0.WriteElementString("LuaXml", this.LuaXml);
						xmlWriter_0.WriteEndElement();
					}
					hashSet_ = null;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101022", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// 载入想定
		private static Scenario LoadXMLScenario(XmlDocument XMLDoc, ref string ErrorFeedback, ref double PercentageComplete, bool ForceDeepRebuild = false)
		{
			Scenario result = null;
			try
			{
				Scenario scenario = new Scenario("", "", "");
				Dictionary<string, Subject> dictionary = new Dictionary<string, Subject>();
				XmlNode xmlNode = XMLDoc.SelectSingleNode("/Scenario");
				string str;
				if (!Information.IsNothing(xmlNode))
				{
					str = "Scenario";
				}
				else
				{
					str = "ContentScenario";
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/GameGUID");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.TimelineID = xmlNode.InnerText;
				}
				else
				{
					scenario.TimelineID = XMLDoc.SelectSingleNode("/" + str + "/TimelineID").InnerText;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/ObjectID");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.SetObjectID(xmlNode.InnerText);
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/ContentTag");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.ContentTag = xmlNode.InnerText;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/CampaignID");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.CampaignID = xmlNode.InnerText;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/CampaignSessionID");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.CampaignSessionID = xmlNode.InnerText;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/CampaignScore");
				if (!Information.IsNothing(xmlNode))
				{
					scenario.CampaignScore = Conversions.ToInteger(xmlNode.InnerText);
				}
				scenario.SetScenarioTitle(XMLDoc.SelectSingleNode("/" + str + "/Title").InnerText);
				scenario.SetDescription(XMLDoc.SelectSingleNode("/" + str + "/Description").InnerText);
				scenario.SetDescription(scenario.GetDescription().Replace("<HR>", ""));
				try
				{
					scenario.Meta_Complexity = Conversions.ToShort(XMLDoc.SelectSingleNode("/" + str + "/Meta_Complexity").InnerText);
					scenario.Meta_Difficulty = Conversions.ToShort(XMLDoc.SelectSingleNode("/" + str + "/Meta_Difficulty").InnerText);
					scenario.Meta_ScenSetting = XMLDoc.SelectSingleNode("/" + str + "/Meta_ScenSetting").InnerText;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200051", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				scenario.FileName = XMLDoc.SelectSingleNode("/" + str + "/FileName").InnerText;
				scenario._Time = DateTime.FromBinary(Conversions.ToLong(XMLDoc.SelectSingleNode("/" + str + "/Time").InnerText));
				try
				{
					scenario.ZeroHour = DateTime.FromBinary(Conversions.ToLong(XMLDoc.SelectSingleNode("/" + str + "/ZeroHour").InnerText));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/StartTime");
				if (!Information.IsNothing(xmlNode) && Operators.CompareString(xmlNode.InnerText, "0", false) != 0)
				{
					scenario._StartTime = new DateTime?(DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText)));
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/DaylightSavingTime");
				if (!Information.IsNothing(xmlNode))
				{
					scenario._DaylightSavingTime = Conversions.ToBoolean(xmlNode.InnerText);
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/DaylightSavingTime_Start");
				if (!Information.IsNothing(xmlNode) && Operators.CompareString(xmlNode.InnerText, "0", false) != 0)
				{
					scenario._DaylightSavingTime_Start = XMLDoc.SelectSingleNode("/" + str + "/DaylightSavingTime_Start").InnerText.Replace(",", ".");
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Duration");
				if (!Information.IsNothing(xmlNode) && Operators.CompareString(xmlNode.InnerText, "0", false) != 0)
				{
					scenario._Duration = new TimeSpan?(new TimeSpan(Conversions.ToLong(xmlNode.InnerText)));
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/DaylightSavingTime_End");
				if (!Information.IsNothing(xmlNode) && Operators.CompareString(xmlNode.InnerText, "0", false) != 0)
				{
					scenario._DaylightSavingTime_End = XMLDoc.SelectSingleNode("/" + str + "/DaylightSavingTime_End").InnerText.Replace(",", ".");
				}
				scenario.SetDBUsed(XMLDoc.SelectSingleNode("/" + str + "/DBUsed").InnerText.ToString());
				if (Versioned.IsNumeric(scenario.GetDBUsed()))
				{
					scenario.SetDBUsed(DBOps.GetDBRecordHash(Conversions.ToInteger(scenario.GetDBUsed())));
				}
				DBRecord dBRecord = null;
				try
				{
					DBOps.DBFileCheckResult dBFileCheckResult = DBOps.DBFileCheckResult.Undefined;
					dBRecord = DBOps.GetDBRecord(scenario.GetDBUsed(), ref dBFileCheckResult, true, true);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 101172", "");
					GameGeneral.LogException(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				if (dBRecord.IsOfficialDBRecord())
				{
					bool? isSupported = dBRecord.IsSupported;
					if ((isSupported.HasValue ? new bool?(!isSupported.GetValueOrDefault()) : isSupported).GetValueOrDefault())
					{
						ErrorFeedback += "CAUTION! The database version matching this scenario is no longer supported by the simulation engine. The loaded scenario was automatically matched to the current version of this database. This change will persist on the next scenario save.\r\nNOTE: All units in the scenario will be rebuilt as brand-new from the DB (thus erasing any modified state on them, e.g. damage or expended fuel/weapons). Please use the SBR to restore any unit customizations (damage, ammo etc.) after the rebuild process.";
						scenario.SetDBUsed(DBOps.GetDBRecordHash(DBOps.GetDBRecord(scenario.GetDBUsed()).DBID));
						scenario.LoadStockUnits = true;
					}
				}
				if (ForceDeepRebuild)
				{
					scenario.LoadStockUnits = true;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Sides");
				XmlNodeList xmlNodeListSide = null;
				if (!Information.IsNothing(xmlNode))
				{
					xmlNodeListSide = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/NonActiveUnits/Explosions");
				XmlNodeList xmlNodeListExplosions = null;
				if (!Information.IsNothing(xmlNode))
				{
					xmlNodeListExplosions = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/NonActiveUnits/WeaponImpacts");
				XmlNodeList xmlNodeListWeaponImpacts = null;
				if (!Information.IsNothing(xmlNode))
				{
					xmlNodeListWeaponImpacts = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/NonActiveUnits/UnguidedWeapons");
				XmlNodeList xmlNodeListUnguidedWeapons = null;
				if (!Information.IsNothing(xmlNode))
				{
					xmlNodeListUnguidedWeapons = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/ActiveUnits");
				XmlNodeList xmlNodeListActiveUnits = null;
				if (!Information.IsNothing(xmlNode))
				{
					xmlNodeListActiveUnits = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Groups");
				XmlNodeList xmlNodeListGroups = null;
				if (!Information.IsNothing(xmlNode))
				{
					xmlNodeListGroups = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/EventTriggers");
				XmlNodeList xmlNodeListEventTriggers = null;
				if (!Information.IsNothing(xmlNode))
				{
					xmlNodeListEventTriggers = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/EventConditions");
				XmlNodeList xmlNodeListEventConditions = null;
				if (!Information.IsNothing(xmlNode))
				{
					xmlNodeListEventConditions = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/EventActions");
				XmlNodeList xmlNodeListEventActions = null;
				if (!Information.IsNothing(xmlNode))
				{
					xmlNodeListEventActions = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/SimEvents");
				XmlNodeList xmlNodeListSimEvents = null;
				if (!Information.IsNothing(xmlNode))
				{
					xmlNodeListSimEvents = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/ScenAttachmentObjects");
				XmlNodeList xmlNodeListScenAttachmentObjects = null;
				if (!Information.IsNothing(xmlNode))
				{
					xmlNodeListScenAttachmentObjects = xmlNode.ChildNodes;
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/MessageLog");
				XmlNodeList xmlNodeListMessageLog = null;
				if (!Information.IsNothing(xmlNode))
				{
					xmlNodeListMessageLog = xmlNode.ChildNodes;
				}
				int num = 0;
				if (!Information.IsNothing(xmlNodeListSide))
				{
					num += xmlNodeListSide.Count;
				}
				if (!Information.IsNothing(xmlNodeListExplosions))
				{
					num += xmlNodeListExplosions.Count;
				}
				if (!Information.IsNothing(xmlNodeListWeaponImpacts))
				{
					num += xmlNodeListWeaponImpacts.Count;
				}
				if (!Information.IsNothing(xmlNodeListUnguidedWeapons))
				{
					num += xmlNodeListUnguidedWeapons.Count;
				}
				if (!Information.IsNothing(xmlNodeListActiveUnits))
				{
					num += xmlNodeListActiveUnits.Count;
				}
				if (!Information.IsNothing(xmlNodeListGroups))
				{
					num += xmlNodeListGroups.Count;
				}
				if (!Information.IsNothing(xmlNodeListEventTriggers))
				{
					num += xmlNodeListEventTriggers.Count;
				}
				if (!Information.IsNothing(xmlNodeListEventConditions))
				{
					num += xmlNodeListEventConditions.Count;
				}
				if (!Information.IsNothing(xmlNodeListEventActions))
				{
					num += xmlNodeListEventActions.Count;
				}
				if (!Information.IsNothing(xmlNodeListSimEvents))
				{
					num += xmlNodeListSimEvents.Count;
				}
				if (!Information.IsNothing(xmlNodeListScenAttachmentObjects))
				{
					num += xmlNodeListScenAttachmentObjects.Count;
				}
				if (!Information.IsNothing(xmlNodeListMessageLog))
				{
					num += xmlNodeListMessageLog.Count;
				}
				int num2 = 0;
				if (!Information.IsNothing(xmlNodeListSide))
				{
					IEnumerator enumerator = xmlNodeListSide.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							XmlNode xmlNode2 = (XmlNode)enumerator.Current;
							Side side_ = Side.GetSideXmlNode(ref xmlNode2, ref scenario, ref dictionary);
							scenario.AddSide(side_);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(xmlNodeListExplosions))
				{
					IEnumerator enumerator2 = xmlNodeListExplosions.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							XmlNode xmlNode3 = (XmlNode)enumerator2.Current;
							Explosion item = Explosion.Load(ref xmlNode3, ref dictionary);
							scenario.GetExplosions().Add(item);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(xmlNodeListWeaponImpacts))
				{
					IEnumerator enumerator3 = xmlNodeListWeaponImpacts.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							XmlNode xmlNode4 = (XmlNode)enumerator3.Current;
							WeaponImpact item2 = WeaponImpact.smethod_0(ref xmlNode4, ref dictionary);
							scenario.GetWeaponImpacts().Add(item2);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(xmlNodeListUnguidedWeapons))
				{
					IEnumerator enumerator4 = xmlNodeListUnguidedWeapons.GetEnumerator();
					try
					{
						while (enumerator4.MoveNext())
						{
							XmlNode xmlNode5 = (XmlNode)enumerator4.Current;
							UnguidedWeapon unguidedWeapon = UnguidedWeapon.smethod_2(ref xmlNode5, ref dictionary, ref scenario);
							scenario.GetUnguidedWeapons().Add(unguidedWeapon.GetGuid(), unguidedWeapon);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(xmlNodeListActiveUnits))
				{
					IEnumerator enumerator5 = xmlNodeListActiveUnits.GetEnumerator();
					try
					{
						while (enumerator5.MoveNext())
						{
							XmlNode xmlNode6 = (XmlNode)enumerator5.Current;
							ActiveUnit activeUnit = ActiveUnit.Load(ref xmlNode6, ref dictionary, ref scenario);
							if (!Information.IsNothing(activeUnit))
							{
								if (!scenario.GetActiveUnits().ContainsKey(activeUnit.GetGuid()))
								{
									scenario.GetActiveUnits().Add(activeUnit.GetGuid(), activeUnit);
								}
								num2++;
								PercentageComplete = (double)num2 / (double)num;
								if (!Information.IsNothing(activeUnit.GetAssignedMission(false)))
								{
									if (activeUnit.GetAssignedMission(false).MissionClass != Mission._MissionClass.Strike && activeUnit.GetAI().IsEscort)
									{
										activeUnit.GetAI().IsEscort = false;
									}
								}
								else if (activeUnit.GetAI().IsEscort)
								{
									activeUnit.GetAI().IsEscort = false;
								}
							}
						}
					}
					finally
					{
						if (enumerator5 is IDisposable)
						{
							(enumerator5 as IDisposable).Dispose();
						}
					}
					using (IEnumerator<ActiveUnit> enumerator6 = scenario.GetActiveUnits().Values.GetEnumerator())
					{
						while (enumerator6.MoveNext())
						{
							enumerator6.Current.m_Scenario = scenario;
						}
					}
				}
                XmlNode currentX;

                foreach (XmlNode current in scenario.UnitsForLateInstantiation)
				{
                    currentX = current;
                    ActiveUnit activeUnit2 = ActiveUnit.Load(ref currentX, ref dictionary, ref scenario);
					scenario.GetActiveUnits()[activeUnit2.GetGuid()] = activeUnit2;
				}
				scenario.UnitsForLateInstantiation.Clear();
				if (!Information.IsNothing(xmlNodeListGroups))
				{
					IEnumerator enumerator8 = xmlNodeListGroups.GetEnumerator();
					try
					{
						while (enumerator8.MoveNext())
						{
							XmlNode xmlNode7 = (XmlNode)enumerator8.Current;
							Group group = (Group)dictionary[xmlNode7.InnerText];
							scenario.Groups.Add(group);
							group.m_Scenario = scenario;
							group.bool_17 = true;
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						if (enumerator8 is IDisposable)
						{
							(enumerator8 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(xmlNodeListEventTriggers))
				{
					IEnumerator enumerator9 = xmlNodeListEventTriggers.GetEnumerator();
					try
					{
						while (enumerator9.MoveNext())
						{
							XmlNode xmlNode8 = (XmlNode)enumerator9.Current;
							EventTrigger eventTrigger = EventTrigger.smethod_0(ref xmlNode8, ref dictionary, ref scenario);
							scenario.GetEventTriggers().Add(eventTrigger.GetGuid(), eventTrigger);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						if (enumerator9 is IDisposable)
						{
							(enumerator9 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(xmlNodeListEventConditions))
				{
					IEnumerator enumerator10 = xmlNodeListEventConditions.GetEnumerator();
					try
					{
						while (enumerator10.MoveNext())
						{
							XmlNode xmlNode9 = (XmlNode)enumerator10.Current;
							EventCondition eventCondition = EventCondition.Load(ref xmlNode9, ref dictionary, ref scenario);
							scenario.GetEventConditions().Add(eventCondition.GetGuid(), eventCondition);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						if (enumerator10 is IDisposable)
						{
							(enumerator10 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(xmlNodeListEventActions))
				{
					IEnumerator enumerator11 = xmlNodeListEventActions.GetEnumerator();
					try
					{
						while (enumerator11.MoveNext())
						{
							XmlNode xmlNode10 = (XmlNode)enumerator11.Current;
							EventAction eventAction = EventAction.smethod_0(ref xmlNode10, ref dictionary, ref scenario);
							scenario.GetEventActions().Add(eventAction.GetGuid(), eventAction);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						if (enumerator11 is IDisposable)
						{
							(enumerator11 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(xmlNodeListSimEvents))
				{
					IEnumerator enumerator12 = xmlNodeListSimEvents.GetEnumerator();
					try
					{
						while (enumerator12.MoveNext())
						{
							SimEvent simEvent = SimEvent.Load((XmlNode)enumerator12.Current, dictionary, scenario);
							scenario.GetSimEvents().Add(simEvent.GetGuid(), simEvent);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						if (enumerator12 is IDisposable)
						{
							(enumerator12 as IDisposable).Dispose();
						}
					}
				}
				if (!Information.IsNothing(xmlNodeListScenAttachmentObjects))
				{
					IEnumerator enumerator13 = xmlNodeListScenAttachmentObjects.GetEnumerator();
					try
					{
						while (enumerator13.MoveNext())
						{
							ScenAttachmentObject scenAttachmentObject = ScenAttachmentObject.smethod_0((XmlNode)enumerator13.Current, dictionary, scenario);
							scenario.GetScenAttachments().Add(scenAttachmentObject.method_0(), scenAttachmentObject);
							num2++;
							PercentageComplete = (double)num2 / (double)num;
						}
					}
					finally
					{
						if (enumerator13 is IDisposable)
						{
							(enumerator13 as IDisposable).Dispose();
						}
					}
				}
				XmlNode xmlNode11 = XMLDoc.SelectSingleNode("/" + str + "/WeatherModel");
				if (Information.IsNothing(xmlNode11))
				{
					scenario.WeatherLevel = Scenario.WeatherModellingLevel.Level0;
				}
				else
				{
					scenario.WeatherLevel = (Scenario.WeatherModellingLevel)Conversions.ToByte(xmlNode11.InnerText);
				}
				xmlNode11 = XMLDoc.SelectSingleNode("/" + str + "/GlobalWeather");
				if (!Information.IsNothing(xmlNode11))
				{
					scenario._GlobalWeather = Weather.WeatherProfile.smethod_0(ref xmlNode11);
				}
				string innerText = XMLDoc.SelectSingleNode("/" + str + "/TimeCompression").InnerText;
				if (Versioned.IsNumeric(innerText))
				{
					scenario._TimeCompression = (Scenario.enumTimeCompression)Conversions.ToByte(innerText);
				}
				else
				{
					scenario._TimeCompression = (Scenario.enumTimeCompression)Enum.Parse(typeof(Scenario.enumTimeCompression), innerText, true);
				}
				scenario._GameResolution = XmlConvert.ToSingle(XMLDoc.SelectSingleNode("/" + str + "/GameResolution").InnerText.Replace(",", "."));
				IEnumerator enumerator14 = xmlNodeListMessageLog.GetEnumerator();
				try
				{
					while (enumerator14.MoveNext())
					{
						XmlNode xmlNode12 = (XmlNode)enumerator14.Current;
						LoggedMessage loggedMessage = LoggedMessage.Load(ref xmlNode12, ref dictionary);
						if (!Information.IsNothing(loggedMessage))
						{
							scenario.MessageLog.TryAdd(loggedMessage.Increment, loggedMessage);
						}
						num2++;
						PercentageComplete = (double)num2 / (double)num;
					}
				}
				finally
				{
					if (enumerator14 is IDisposable)
					{
						(enumerator14 as IDisposable).Dispose();
					}
				}
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/MessageIncrement");
				if (!Information.IsNothing(xmlNode))
				{
					scenario._MessageIncrement = (long)Conversions.ToInteger(xmlNode.InnerText);
				}
				scenario.UnitsAutoIncrement = Conversions.ToInteger(XMLDoc.SelectSingleNode("/" + str + "/UnitsAutoIncrement").InnerText);
				xmlNode = XMLDoc.SelectSingleNode("/" + str + "/MessageIncrement");
				if (!Information.IsNothing(xmlNode))
				{
					scenario._MessageIncrement = (long)Conversions.ToInteger(xmlNode.InnerText);
				}
				checked
				{
					if (!Information.IsNothing(XMLDoc.SelectSingleNode("/" + str + "/CurrentSide")))
					{
						string innerText2 = XMLDoc.SelectSingleNode("/" + str + "/CurrentSide").InnerText;
						Side[] sides = scenario.GetSides();
						for (int i = 0; i < sides.Length; i++)
						{
							Side side = sides[i];
							if (Operators.CompareString(side.GetSideName(), innerText2, false) == 0)
							{
								scenario.ChangeSide(side);
							}
						}
					}
					scenario.GameVersion = XMLDoc.SelectSingleNode("/" + str + "/GameVersion").InnerText;
					xmlNode = XMLDoc.SelectSingleNode("/" + str + "/LastSavedInScenEdit");
					if (!Information.IsNothing(xmlNode))
					{
						scenario.LastSavedInScenEdit = true;
					}
					if (scenario.LastSavedInScenEdit)
					{
						scenario.ZeroHour = scenario._Time;
					}
					xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_DetailedGunFireControl");
					if (!Information.IsNothing(xmlNode))
					{
						scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.DetailedGunFireControl);
					}
					xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_UnlimitedAirWeapons");
					if (!Information.IsNothing(xmlNode))
					{
						scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags);
					}
					xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_UnlimitedBaseMags");
					if (!Information.IsNothing(xmlNode))
					{
						scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags);
					}
					xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_CommsJamming");
					if (!Information.IsNothing(xmlNode))
					{
						scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.CommsJamming);
					}
					xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_AircraftDamage");
					if (!Information.IsNothing(xmlNode))
					{
						scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.AircraftDamageModel);
					}
					xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_Cargo");
					if (!Information.IsNothing(xmlNode))
					{
						scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.CargoOps);
					}
					xmlNode = XMLDoc.SelectSingleNode("/" + str + "/Realism_CommsDisruption");
					if (!Information.IsNothing(xmlNode))
					{
						scenario.DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.CommsDisruption);
					}
					xmlNode = XMLDoc.SelectSingleNode("/" + str + "/LuaXml");
					if (!Information.IsNothing(xmlNode))
					{
						scenario.LuaXml = xmlNode.InnerText;
					}
					Side[] sides2 = scenario.GetSides();
					for (int j = 0; j < sides2.Length; j++)
					{
						Side side2 = sides2[j];
						side2.SetXDictionary(ref scenario, dictionary, false);
						List<Contact> list = new List<Contact>();
						list.AddRange(side2.GetContactList());
						foreach (Contact current2 in list)
						{
							if (!current2.method_56(ref scenario, ref dictionary, ref side2))
							{
								side2.GetContactObservableDictionary().Remove(current2.string_6);
							}
						}
						List<Contact> list2 = new List<Contact>();
						list2.AddRange(side2.GetBaseContacts());
						foreach (Contact current3 in list2)
						{
							if (!current3.method_56(ref scenario, ref dictionary, ref side2))
							{
								side2.GetContactsObDictionary().Remove(current3.string_6);
							}
						}
						using (IEnumerator<ReferencePoint> enumerator17 = side2.GetReferencePoints().GetEnumerator())
						{
							while (enumerator17.MoveNext())
							{
								enumerator17.Current.SetIsRelativeToUnit(dictionary);
							}
						}
						foreach (Mission current4 in side2.GetPatrolMissionCollection(scenario))
						{
							if (!Information.IsNothing(current4))
							{
								current4.vmethod_6(ref scenario, side2, false);
							}
						}
						List<ActiveUnit> list3 = side2.ActiveUnitArray.ToList<ActiveUnit>();
                        ActiveUnit current5X;
                        foreach (ActiveUnit current5 in list3)
						{
                            current5X = current5;
                            current5.GetSensory().method_73(ref current5X, dictionary);
						}
					}
					using (IEnumerator<ActiveUnit> enumerator20 = scenario.GetActiveUnits().Values.GetEnumerator())
					{
						while (enumerator20.MoveNext())
						{
							enumerator20.Current.method_91(ref scenario, dictionary);
						}
					}
					foreach (ActiveUnit current6 in scenario.GetActiveUnits().Values)
					{
						current6.vmethod_113(ref scenario, dictionary, false);
						if (current6.IsWeapon)
						{
							((Weapon)current6).vmethod_113(ref scenario, dictionary, false);
						}
						if (!current6.IsGroup)
						{
							List<ActiveUnit_CommLink> list4 = new List<ActiveUnit_CommLink>();
							list4.AddRange(current6.GetCommStuff().GetCommLinksEstablished());
							foreach (ActiveUnit_CommLink current7 in list4)
							{
								try
								{
									current7.SetCommPartner(ref dictionary);
								}
								catch (Exception ex5)
								{
									ProjectData.SetProjectError(ex5);
									Exception ex6 = ex5;
									current6.GetCommStuff().RemoveCommLink(current7);
									ex6.Data.Add("Error at 200052", ex6.Message);
									GameGeneral.LogException(ref ex6);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
								}
							}
							Sensor[] noneMCMSensors = current6.GetNoneMCMSensors();
							for (int k = 0; k < noneMCMSensors.Length; k++)
							{
								Sensor sensor = noneMCMSensors[k];
								sensor.CreateSemiActiveGuidedWeaponList(ref scenario);
								if (Information.IsNothing(sensor.GetParentPlatform()))
								{
									sensor.SetParentPlatform(current6);
								}
							}
						}
					}
					using (IEnumerator<Explosion> enumerator23 = scenario.GetExplosions().GetEnumerator())
					{
						while (enumerator23.MoveNext())
						{
							enumerator23.Current.method_56(ref dictionary);
						}
					}
					using (IEnumerator<UnguidedWeapon> enumerator24 = scenario.GetUnguidedWeapons().Values.GetEnumerator())
					{
						while (enumerator24.MoveNext())
						{
							enumerator24.Current.method_54(ref scenario);
						}
					}
					using (IEnumerator<Group> enumerator25 = scenario.Groups.GetEnumerator())
					{
						while (enumerator25.MoveNext())
						{
							enumerator25.Current.bool_17 = false;
						}
					}
					dictionary.Clear();
					foreach (string current8 in scenario.LoadingNotices)
					{
						ErrorFeedback = ErrorFeedback + "\r\n" + current8 + "\r\n";
					}
					scenario.SetGuidedWeaponsInAir(null);
					scenario.SetSonobuoysInWater(null);
					scenario.SetAllWeaponsAlive(null);
					scenario.GetGuidedWeaponsInAir();
					scenario.SetFlightSize();
					result = scenario;
				}
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				ex8.Data.Add("Error at 101023", "");
				GameGeneral.LogException(ref ex8);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06005CD5 RID: 23765 RVA: 0x002AFD20 File Offset: 0x002ADF20
		public static Scenario LoadScenario(string string_0, ref string ErrorFeedback, ref double PercentageComplete, bool ForceDeepRebuild)
		{
			Scenario result = null;
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				try
				{
					xmlDocument.LoadXml(string_0);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200465", ex2.Message);
					GameGeneral.LogException(ref ex2);
					bool arg_3F_0 = Debugger.IsAttached;
					try
					{
						string_0 = Misc.smethod_4(string_0);
						xmlDocument.LoadXml(string_0);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ex2.Data.Add("Error at 200466", ex2.Message);
						GameGeneral.LogException(ref ex2);
						bool arg_7C_0 = Debugger.IsAttached;
						string_0 = Misc.smethod_6(string_0);
						xmlDocument.LoadXml(string_0);
						ProjectData.ClearProjectError();
					}
					ProjectData.ClearProjectError();
				}
				result = Scenario.LoadXMLScenario(xmlDocument, ref ErrorFeedback, ref PercentageComplete, ForceDeepRebuild);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 101024", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06005CD6 RID: 23766 RVA: 0x002AFE3C File Offset: 0x002AE03C
		public static Scenario XmlScenLoad(string string_0, ref string string_1, ref double double_0)
		{
			Scenario result = null;
			try
			{
				FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
				XmlDocument xmlDocument = new XmlDocument();
				using (fileStream)
				{
					xmlDocument.Load(fileStream);
				}
				result = Scenario.LoadXMLScenario(xmlDocument, ref string_1, ref double_0, false);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101025", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005CD7 RID: 23767 RVA: 0x00029581 File Offset: 0x00027781
		public bool IsFastMode()
		{
			return (this.GetTimeCompression() == 1 && SimConfiguration.gameOptions.IsHighFidelityMode()) || (SimConfiguration.gameOptions.NoPulseMapUpdate() && this.GetTimeCompression() > 1);
		}

		// Token: 0x06005CD8 RID: 23768 RVA: 0x002AFEE4 File Offset: 0x002AE0E4
		public void TriggerScenLoadedEvents()
		{
			List<EventTrigger> list = new List<EventTrigger>();
			foreach (EventTrigger current in this.GetEventTriggers().Values)
			{
				if (current.eventTriggerType == EventTrigger.EventTriggerType.ScenLoaded)
				{
					list.Add(current);
				}
			}
			if (list.Count > 0)
			{
				this.TriggerEvents(list);
			}
		}

		// Token: 0x06005CD9 RID: 23769 RVA: 0x002AFF64 File Offset: 0x002AE164
		public static List<string> XmlReaderList(string string_0, List<string> list_0)
		{
			List<string> list = new List<string>();
			string s = ScenContainer.smethod_2(string_0).method_9();
			foreach (string current in list_0)
			{
				XmlReader xmlReader = XmlReader.Create(new StringReader(s));
				using (xmlReader)
				{
					if (xmlReader.ReadToDescendant(current))
					{
						list.Add(xmlReader.ReadElementContentAsString());
					}
					else
					{
						list.Add("");
					}
				}
			}
			return list;
		}

		// Token: 0x06005CDA RID: 23770 RVA: 0x002B0018 File Offset: 0x002AE218
		public static string XmlReaderSting(string string_0, string string_1)
		{
			string result = "";
			try
			{
				XmlReader xmlReader = XmlReader.Create(new StringReader(string_0));
				using (xmlReader)
				{
					if (xmlReader.ReadToDescendant(string_1))
					{
						result = xmlReader.ReadElementContentAsString();
					}
					else
					{
						result = null;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101285", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005CDB RID: 23771 RVA: 0x000295B3 File Offset: 0x000277B3
		public bool IsCampaignSession()
		{
			return !string.IsNullOrEmpty(this.CampaignID) && !string.IsNullOrEmpty(this.CampaignSessionID);
		}

		// Token: 0x06005CDC RID: 23772 RVA: 0x002B00C4 File Offset: 0x002AE2C4
		public List<Weapon> GetGuidedWeaponsInAir()
		{
			List<Weapon> guidedWeaponsInAir;
			try
			{
				if (Information.IsNothing(this._GuidedWeaponsInAir) || Information.IsNothing(this._SonobuoysInWater) || Information.IsNothing(this._AllWeaponsAlive))
				{
					object lockObject = this.LockObject2;
					ObjectFlowControl.CheckForSyncLockOnValueType(lockObject);
					lock (lockObject)
					{
						if (Information.IsNothing(this._GuidedWeaponsInAir) || Information.IsNothing(this._SonobuoysInWater) || Information.IsNothing(this._AllWeaponsAlive))
						{
							List<Weapon> list = new List<Weapon>();
							List<Weapon> list2 = new List<Weapon>();
							List<Weapon> list3 = new List<Weapon>();
							List<ActiveUnit> list4 = this.GetActiveUnits().Values.ToList<ActiveUnit>();
							int num = list4.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								ActiveUnit activeUnit = list4[i];
								if (activeUnit.IsWeapon)
								{
									list3.Add((Weapon)activeUnit);
									Weapon weapon = (Weapon)activeUnit;
									if (!weapon.IsGuidedWeapon() && !weapon.IsGuidedProjectile() && !weapon.IsRVorHGV() && (weapon.GetWeaponType() != Weapon._WeaponType.Torpedo || weapon.GetCommDevices().Length <= 0))
									{
										if (weapon.GetWeaponType() == Weapon._WeaponType.Sonobuoy)
										{
											list2.Add((Weapon)activeUnit);
										}
									}
									else
									{
										list.Add((Weapon)activeUnit);
									}
								}
							}
							this._GuidedWeaponsInAir = list;
							this._SonobuoysInWater = list2;
							this._AllWeaponsAlive = list3;
						}
					}
				}
				guidedWeaponsInAir = this._GuidedWeaponsInAir;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101026", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				guidedWeaponsInAir = this._GuidedWeaponsInAir;
				ProjectData.ClearProjectError();
			}
			return guidedWeaponsInAir;
		}

		// Token: 0x06005CDD RID: 23773 RVA: 0x000295D3 File Offset: 0x000277D3
		public void SetGuidedWeaponsInAir(List<Weapon> list_0)
		{
			this._GuidedWeaponsInAir = list_0;
		}

		// Token: 0x06005CDE RID: 23774 RVA: 0x002B02E8 File Offset: 0x002AE4E8
		public List<Weapon> GetSonobuoysInWater()
		{
			List<Weapon> sonobuoysInWater;
			try
			{
				if (Information.IsNothing(this._SonobuoysInWater))
				{
					this.GetGuidedWeaponsInAir();
				}
				sonobuoysInWater = this._SonobuoysInWater;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101274", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				sonobuoysInWater = this._SonobuoysInWater;
				ProjectData.ClearProjectError();
			}
			return sonobuoysInWater;
		}

		// Token: 0x06005CDF RID: 23775 RVA: 0x000295DC File Offset: 0x000277DC
		public void SetSonobuoysInWater(List<Weapon> SonobuoysInWater_)
		{
			this._SonobuoysInWater = SonobuoysInWater_;
		}

		// Token: 0x06005CE0 RID: 23776 RVA: 0x002B036C File Offset: 0x002AE56C
		public List<Weapon> GetAllWeaponsAlive()
		{
			List<Weapon> allWeaponsAlive;
			try
			{
				if (Information.IsNothing(this._AllWeaponsAlive))
				{
					this.GetGuidedWeaponsInAir();
				}
				allWeaponsAlive = this._AllWeaponsAlive;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101275", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				allWeaponsAlive = this._AllWeaponsAlive;
				ProjectData.ClearProjectError();
			}
			return allWeaponsAlive;
		}

		// Token: 0x06005CE1 RID: 23777 RVA: 0x000295E5 File Offset: 0x000277E5
		public void SetAllWeaponsAlive(List<Weapon> list_0)
		{
			this._AllWeaponsAlive = list_0;
		}

		// Token: 0x06005CE2 RID: 23778 RVA: 0x002B03F0 File Offset: 0x002AE5F0
		public Weather.WeatherProfile GetWeatherProfile()
		{
			if (Information.IsNothing(this._GlobalWeather))
			{
				this._GlobalWeather = Weather.GetWeatherProfile();
			}
			return this._GlobalWeather;
		}

		// Token: 0x06005CE3 RID: 23779 RVA: 0x002B0420 File Offset: 0x002AE620
		public void TriggerEvents(List<EventTrigger> EventTriggers_)
		{
			try
			{
				foreach (EventTrigger current in EventTriggers_)
				{
					foreach (SimEvent current2 in this.GetSimEvents().Values)
					{
						if (current2.IsActive && current2.Triggers.Contains(current))
						{
							if (current2.IsConditionsMet(this))
							{
								if (current2.Probability != 100 && GameGeneral.GetRandom().Next(0, 100) > (int)current2.Probability)
								{
									if (current2.IsShown)
									{
										this.LogMessage("事件: '" + current2.Description + "'被触发但是没有激活(没有通过概率检验).", LoggedMessage.MessageType.EventEngine, 1, "", null, null);
									}
									if (!current2.IsRepeatable)
									{
										current2.IsActive = false;
										continue;
									}
									continue;
								}
								else
								{
									ActiveUnit activeUnit = null;
									if (current.eventTriggerType == EventTrigger.EventTriggerType.UnitRemainsInArea)
									{
										activeUnit = ((EventTrigger_UnitRemainsInArea)current).activeUnit_0;
									}
									else if (current.eventTriggerType == EventTrigger.EventTriggerType.UnitEntersArea)
									{
										activeUnit = ((EventTrigger_UnitEntersArea)current).activeUnit_0;
									}
									else if (current.eventTriggerType == EventTrigger.EventTriggerType.UnitDamaged)
									{
										activeUnit = ((EventTrigger_UnitDamaged)current).activeUnit_0;
									}
									else if (current.eventTriggerType == EventTrigger.EventTriggerType.UnitDestroyed)
									{
										activeUnit = ((EventTrigger_UnitDestroyed)current).activeUnit_0;
									}
									else if (current.eventTriggerType == EventTrigger.EventTriggerType.UnitDetected)
									{
										activeUnit = ((EventTrigger_UnitDetected)current).activeUnit_0;
									}
									if (!Information.IsNothing(activeUnit))
									{
										activeUnit.m_Scenario.GetLuaSandBox().UnitX = activeUnit;
									}
									if (current2.IsShown)
									{
										this.LogMessage("事件: '" + current2.Description + "'已触发.", LoggedMessage.MessageType.EventEngine, 1, "", null, null);
									}
									if (!current2.IsRepeatable)
									{
										current2.IsActive = false;
									}
									using (List<EventAction>.Enumerator enumerator3 = current2.Actions.GetEnumerator())
									{
										while (enumerator3.MoveNext())
										{
											enumerator3.Current.FireEventAction(this, current2);
										}
										continue;
									}
								}
							}
							if (current2.IsShown)
							{
								this.LogMessage("事件: '" + current2.Description + "'被触发但是没有激活(至少一个条件没有满足).", LoggedMessage.MessageType.EventEngine, 1, "", null, null);
							}
							if (!current2.IsRepeatable)
							{
								current2.IsActive = false;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101028", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005CE4 RID: 23780 RVA: 0x000295EE File Offset: 0x000277EE
		public bool HasEnded()
		{
			return this._HasEnded;
		}

		// Token: 0x06005CE5 RID: 23781 RVA: 0x000295F6 File Offset: 0x000277F6
		public bool HasStarted()
		{
			return DateTime.Compare(this.GetCurrentTime(false), this.GetStartTime()) > 0;
		}

		// Token: 0x06005CE6 RID: 23782 RVA: 0x002B073C File Offset: 0x002AE93C
		public DateTime GetStartTime()
		{
			if (!this._StartTime.HasValue)
			{
				this._StartTime = new DateTime?(this.GetCurrentTime(false));
			}
			return this._StartTime.Value;
		}

		// Token: 0x06005CE7 RID: 23783 RVA: 0x0002960D File Offset: 0x0002780D
		public void SetStartTime(DateTime dateTime_0)
		{
			this._StartTime = new DateTime?(dateTime_0);
		}

		// Token: 0x06005CE8 RID: 23784 RVA: 0x002B0778 File Offset: 0x002AE978
		public TimeSpan GetDuration()
		{
			if (!this._Duration.HasValue)
			{
				this._Duration = new TimeSpan?(new TimeSpan(24, 0, 0));
			}
			return this._Duration.Value;
		}

		// Token: 0x06005CE9 RID: 23785 RVA: 0x0002961B File Offset: 0x0002781B
		public void SetDuration(TimeSpan timeSpan_0)
		{
			this._Duration = new TimeSpan?(timeSpan_0);
		}

		// Token: 0x06005CEA RID: 23786 RVA: 0x002B07B4 File Offset: 0x002AE9B4
		public DateTime GetCurrentTime(bool ManualChange = false)
		{
			return this._Time;
		}

		// Token: 0x06005CEB RID: 23787 RVA: 0x002B07CC File Offset: 0x002AE9CC
		public void AdvanceSimTime(bool ManualChange, DateTime value)
		{
			try
			{
				if (this._TimeCompression > Scenario.enumTimeCompression.OneSec)
				{
					this.SecondIsChangingOnThisPulse = true;
				}
				else if (this._Time.Second == value.Second)
				{
					this.SecondIsChangingOnThisPulse = false;
				}
				else
				{
					this.SecondIsChangingOnThisPulse = true;
				}
				this.FifthSecondIsChangingOnThisPulse = false;
				this.FifteenthSecondIsChangingOnThisPulse = false;
				this.ThirtiethSecondIsChangingOnThisPulse = false;
				this.MinuteIsChangingOnThisPulse = false;
				this.FifthMinuteIsChangingOnThisPulse = false;
				this.FifteenthMinuteIsChangingOnThisPulse = false;
				this.ThirtiethMinuteIsChangingOnThisPulse = false;
				this.HourIsChangingOnThisPulse = false;
				if (this.SecondIsChangingOnThisPulse && value.Second % 5 == 0)
				{
					this.FifthSecondIsChangingOnThisPulse = true;
					if (value.Second % 15 == 0)
					{
						this.FifteenthSecondIsChangingOnThisPulse = true;
						if (value.Second % 30 == 0)
						{
							this.ThirtiethSecondIsChangingOnThisPulse = true;
							if (value.Second % 60 == 0)
							{
								this.MinuteIsChangingOnThisPulse = true;
								if (value.Minute % 5 == 0)
								{
									this.FifthMinuteIsChangingOnThisPulse = true;
									if (value.Minute % 15 == 0)
									{
										this.FifteenthMinuteIsChangingOnThisPulse = true;
										if (value.Minute % 30 == 0)
										{
											this.ThirtiethMinuteIsChangingOnThisPulse = true;
											if (this._Time.Hour != value.Hour)
											{
												this.HourIsChangingOnThisPulse = true;
											}
										}
									}
								}
							}
						}
					}
				}
				List<EventTrigger> list = new List<EventTrigger>();
				if (ManualChange)
				{
					Scenario.TimeChangedManuallyEventHandler timeChangedManuallyEvent = Scenario.TimeChangedManuallyEvent;
					if (timeChangedManuallyEvent != null)
					{
						timeChangedManuallyEvent(this, value);
					}
					using (IEnumerator<EventTrigger> enumerator = this.GetEventTriggers().Values.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							EventTrigger current = enumerator.Current;
							if (current.eventTriggerType == EventTrigger.EventTriggerType.Time)
							{
								TimeSpan t = value - this._Time;
								((EventTrigger_Time)current).m_Time += t;
							}
						}
						goto IL_3D5;
					}
				}
				foreach (EventTrigger current2 in this.GetEventTriggers().Values)
				{
					if (current2.eventTriggerType == EventTrigger.EventTriggerType.Time && ((EventTrigger_Time)current2).Before(value))
					{
						list.Add(current2);
					}
					if (current2.eventTriggerType == EventTrigger.EventTriggerType.RandomTime && ((EventTrigger_RandomTime)current2).method_12(value))
					{
						list.Add(current2);
					}
					if (current2.eventTriggerType == EventTrigger.EventTriggerType.RegularTime && ((EventTrigger_RegularTime)current2).method_11(this))
					{
						list.Add(current2);
					}
				}
				if (this.SecondIsChangingOnThisPulse)
				{
					bool flag = false;
					if (this._TimeCompression == Scenario.enumTimeCompression.OneSec)
					{
						flag = true;
					}
					else if (this._TimeCompression == Scenario.enumTimeCompression.TwoSec)
					{
						flag = true;
					}
					else if (this._TimeCompression == Scenario.enumTimeCompression.FiveSec && this.FifthSecondIsChangingOnThisPulse)
					{
						flag = true;
					}
					else if (this._TimeCompression == Scenario.enumTimeCompression.FifteenSec && this.FifteenthSecondIsChangingOnThisPulse)
					{
						flag = true;
					}
					else if (this._TimeCompression == Scenario.enumTimeCompression.ThirtySec && this.ThirtiethSecondIsChangingOnThisPulse)
					{
						flag = true;
					}
					else if (this._TimeCompression == Scenario.enumTimeCompression.OneMin && this.MinuteIsChangingOnThisPulse)
					{
						flag = true;
					}
					else
					{
						bool arg_36A_0;
						if (this._TimeCompression <= Scenario.enumTimeCompression.FiveMin && this._TimeCompression != Scenario.enumTimeCompression.FifteenMin)
						{
							if (this._TimeCompression != Scenario.enumTimeCompression.ThirtyMin)
							{
								arg_36A_0 = true;
								goto IL_36A;
							}
						}
						arg_36A_0 = !this.FifthMinuteIsChangingOnThisPulse;
						IL_36A:
						if (!arg_36A_0)
						{
							flag = true;
						}
					}
					if (flag)
					{
						foreach (EventTrigger current3 in this.GetEventTriggers().Values)
						{
							if (current3.eventTriggerType == EventTrigger.EventTriggerType.UnitEntersArea && ((EventTrigger_UnitEntersArea)current3).method_11(this))
							{
								list.Add(current3);
							}
						}
					}
				}
				IL_3D5:
				this._Time = value;
				this.TriggerEvents(list);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101029", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005CEC RID: 23788 RVA: 0x00029629 File Offset: 0x00027829
		public bool IsUseDaylightSavingTime()
		{
			return this._DaylightSavingTime;
		}

		// Token: 0x06005CED RID: 23789 RVA: 0x00029631 File Offset: 0x00027831
		public void SetIsUseDaylightSavingTime(bool bool_0)
		{
			this._DaylightSavingTime = bool_0;
		}

		// Token: 0x06005CEE RID: 23790 RVA: 0x002B0C64 File Offset: 0x002AEE64
		public string GetDaylightSavingTime_Start()
		{
			return this._DaylightSavingTime_Start;
		}

		// Token: 0x06005CEF RID: 23791 RVA: 0x0002963A File Offset: 0x0002783A
		public void SetDaylightSavingTime_Start(string string_0)
		{
			this._DaylightSavingTime_Start = string_0;
		}

		// Token: 0x06005CF0 RID: 23792 RVA: 0x002B0C7C File Offset: 0x002AEE7C
		public string GetDaylightSavingTime_End()
		{
			return this._DaylightSavingTime_End;
		}

		// Token: 0x06005CF1 RID: 23793 RVA: 0x00029643 File Offset: 0x00027843
		public void SetDaylightSavingTime_End(string string_0)
		{
			this._DaylightSavingTime_End = string_0;
		}

		// Token: 0x06005CF2 RID: 23794 RVA: 0x002B0C94 File Offset: 0x002AEE94
		public SQLiteConnection GetSQLiteConnection()
		{
			if (Information.IsNothing(this._DBConnection))
			{
				if (string.IsNullOrEmpty(this.GetDBUsed()))
				{
					this._DBConnection = null;
				}
				else
				{
					this._DBConnection = new SQLiteConnection(DBOps.GetDataSource(MyTemplate.GetApp().Info.DirectoryPath, this.GetDBUsed()));
				}
			}
			return this._DBConnection;
		}

		// Token: 0x06005CF3 RID: 23795 RVA: 0x002B0CF8 File Offset: 0x002AEEF8
		public float GetTimeStep()
		{
			return this._GameResolution;
		}

		// Token: 0x06005CF4 RID: 23796 RVA: 0x0002964C File Offset: 0x0002784C
		public void SetTimeStep(float value)
		{
			this._GameResolution = value;
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x002B0D10 File Offset: 0x002AEF10
		public List<ActiveUnit> GetActiveUnitList()
		{
			List<ActiveUnit> result = null;
			try
			{
				if (Information.IsNothing(this._ActiveUnits_List) || this._ActiveUnits_List.Count != this.GetActiveUnits().Count)
				{
					object lockObject = this.LockObject1;
					ObjectFlowControl.CheckForSyncLockOnValueType(lockObject);
					lock (lockObject)
					{
						if (Information.IsNothing(this._ActiveUnits_List) || this._ActiveUnits_List.Count != this.GetActiveUnits().Count)
						{
							this._ActiveUnits_List = this.GetActiveUnits().Values.ToList<ActiveUnit>();
						}
					}
				}
				result = this._ActiveUnits_List;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200053", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = this.GetActiveUnits().Values.ToList<ActiveUnit>();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005CF6 RID: 23798 RVA: 0x002B0E30 File Offset: 0x002AF030
		public void SetActiveUnitList(List<ActiveUnit> list_0)
		{
			object lockObject = this.LockObject1;
			ObjectFlowControl.CheckForSyncLockOnValueType(lockObject);
			lock (lockObject)
			{
				this._ActiveUnits_List = list_0;
			}
		}

		// Token: 0x06005CF7 RID: 23799 RVA: 0x002B0E7C File Offset: 0x002AF07C
		public Side[] GetSides()
		{
			return this._Sides;
		}

		// Token: 0x06005CF8 RID: 23800 RVA: 0x002B0E94 File Offset: 0x002AF094
		public List<ActiveUnit> GetUnitAdditions()
		{
			return this._UnitAdditions;
		}

		// Token: 0x06005CF9 RID: 23801 RVA: 0x002B0EAC File Offset: 0x002AF0AC
		public List<ActiveUnit> GetUnitRemovals()
		{
			return this._UnitRemovals;
		}

		// Token: 0x06005CFA RID: 23802 RVA: 0x002B0EC4 File Offset: 0x002AF0C4
		public int GetTimeCompression()
		{
			int result;
			switch (this._TimeCompression)
			{
			case Scenario.enumTimeCompression.OneSec:
				result = 1;
				break;
			case Scenario.enumTimeCompression.TwoSec:
				result = 2;
				break;
			case Scenario.enumTimeCompression.FiveSec:
				result = 5;
				break;
			case Scenario.enumTimeCompression.FifteenSec:
				result = 15;
				break;
			case Scenario.enumTimeCompression.ThirtySec:
				result = 30;
				break;
			case Scenario.enumTimeCompression.OneMin:
				result = 60;
				break;
			case Scenario.enumTimeCompression.FiveMin:
				result = 300;
				break;
			case Scenario.enumTimeCompression.FifteenMin:
				result = 900;
				break;
			case Scenario.enumTimeCompression.ThirtyMin:
				result = 1800;
				break;
			default:
				result = 1;
				break;
			}
			return result;
		}

		// Token: 0x06005CFB RID: 23803 RVA: 0x002B0F3C File Offset: 0x002AF13C
		public void ScenCompleted()
		{
			this._HasEnded = true;
			Scenario.ScenCompletedEventHandler scenCompletedEvent = Scenario.ScenCompletedEvent;
			if (scenCompletedEvent != null)
			{
				scenCompletedEvent(this);
			}
		}

		// Token: 0x06005CFC RID: 23804 RVA: 0x00029655 File Offset: 0x00027855
		private void SetTimeStep()
		{
			if (this._TimeCompression == Scenario.enumTimeCompression.OneSec && this.HighFidelityMode)
			{
				this.SetTimeStep(0.1f);
			}
			else
			{
				this.SetTimeStep(1f);
			}
		}

		// Token: 0x06005CFD RID: 23805 RVA: 0x002B0F64 File Offset: 0x002AF164
		public void IncreaseTimeCompression()
		{
			if (this._TimeCompression < Scenario.enumTimeCompression.ThirtyMin)
			{
				this._TimeCompression += 1;
				this.SetTimeStep();
				Scenario.TimeCompressionChangedEventHandler timeCompressionChangedEvent = Scenario.TimeCompressionChangedEvent;
				if (timeCompressionChangedEvent != null)
				{
					timeCompressionChangedEvent();
				}
			}
		}

		// Token: 0x06005CFE RID: 23806 RVA: 0x002B0FA8 File Offset: 0x002AF1A8
		public void DecreaseTimeCompression()
		{
			if (this._TimeCompression > Scenario.enumTimeCompression.OneSec)
			{
				this._TimeCompression = (Scenario.enumTimeCompression)(this._TimeCompression - Scenario.enumTimeCompression.TwoSec);
				this.SetTimeStep();
				Scenario.TimeCompressionChangedEventHandler timeCompressionChangedEvent = Scenario.TimeCompressionChangedEvent;
				if (timeCompressionChangedEvent != null)
				{
					timeCompressionChangedEvent();
				}
			}
		}

		// Token: 0x06005CFF RID: 23807 RVA: 0x002B0FEC File Offset: 0x002AF1EC
		public void SetTimeCompression(int int_0)
		{
			this._TimeCompression = (Scenario.enumTimeCompression)int_0;
			this.SetTimeStep();
			Scenario.TimeCompressionChangedEventHandler timeCompressionChangedEvent = Scenario.TimeCompressionChangedEvent;
			if (timeCompressionChangedEvent != null)
			{
				timeCompressionChangedEvent();
			}
		}

		// Token: 0x06005D00 RID: 23808 RVA: 0x002B101C File Offset: 0x002AF21C
		public void ChangeSide(Side side_0)
		{
			this._CurrentSide = side_0;
			Scenario.CurrentSideChangedEventHandler currentSideChangedEvent = Scenario.CurrentSideChangedEvent;
			if (currentSideChangedEvent != null)
			{
				currentSideChangedEvent(this);
			}
		}

		// Token: 0x06005D01 RID: 23809 RVA: 0x002B1044 File Offset: 0x002AF244
		public Side GetCurrentSide()
		{
			Side result;
			if (this.GetSides().Count<Side>() == 0)
			{
				result = null;
			}
			else if (Information.IsNothing(this._CurrentSide))
			{
				result = this.GetSides()[0];
			}
			else
			{
				result = this._CurrentSide;
			}
			return result;
		}

		// Token: 0x06005D02 RID: 23810 RVA: 0x002B1090 File Offset: 0x002AF290
		public void SetTimelineID()
		{
			this.ParentTimelineID = this.TimelineID;
			this.TimelineID = Guid.NewGuid().ToString();
		}

		// Token: 0x06005D03 RID: 23811 RVA: 0x002B10C4 File Offset: 0x002AF2C4
		public Scenario()
		{
			this.RunningInMonteCarloMode = false;
			this.SetActiveUnits(new ObservableDictionary<string, ActiveUnit>());
			this.Groups = new GroupsCollection();
			this._GuidedWeaponsInAir = new List<Weapon>();
			this._SonobuoysInWater = new List<Weapon>();
			this._AllWeaponsAlive = new List<Weapon>();
			this.SnapShots = new Collection<Scenario>();
			this._Sides = new Side[0];
			this._UnitAdditions = new List<ActiveUnit>();
			this._UnitRemovals = new List<ActiveUnit>();
			this._UnitDeletions = new List<ActiveUnit>();
			this.Navigation_FinegrainedThresholdDistance = 8f;
			this.Navigation_FinegrainedMaxDistance = 0.5f;
			this.UserIsPlottingCourse = false;
			this.SetScenAttachmentEvent(new ObservableDictionary<string, ScenAttachmentObject>());
			this.UnhandledPopUpMessages = new Queue<LoggedMessage>();
			this.MessageLog = new ConcurrentDictionary<long, LoggedMessage>();
			this.UnitsForLateInstantiation = new HashSet<XmlNode>();
			this.Cache_FacilitiesWithPiers = new List<ActiveUnit>();
			this.Cache_Weapons = new ConcurrentDictionary<int, Weapon>();
			this.Cache_SensorCompatibleFrequencies = new ConcurrentDictionary<int, ConcurrentDictionary<int, bool>>();
			this.Cache_XSections = new ConcurrentDictionary<string, List<XSection>>();
			this.Cache_Aircraft_DT = new DataTable();
			this.Cache_Ships_DT = new DataTable();
			this.Cache_Subs_DT = new DataTable();
			this.Cache_Facilities_DT = new DataTable();
			this.Cache_Satellites_DT = new DataTable();
			this.Cache_Weapons_DT = new DataTable();
			this.Cache_OperatorCountries_DT = new DataTable();
			this.Cache_FuelForPitchEnabledWeapons = new ConcurrentDictionary<int, int>();
			this.CandidatesForDetectionByMines = new ActiveUnit[0];
			this.LoadingNotices = new List<string>();
			this.ThreadedOpsMustStop = false;
			this.DeclaredFeatures = new HashSet<Scenario.ScenarioFeatureOption>();
			this.LastSavedInScenEdit = false;
			this.FeatureCompatibility = default(Scenario._FeatureCompatibility);
			this.MissionPlannerErrorList = new List<string>();
			this.SetEventTriggersEvent(new ObservableDictionary<string, EventTrigger>());
			this.SetEventConditions(new ObservableDictionary<string, EventCondition>());
			this.SetEventActions(new ObservableDictionary<string, EventAction>());
			this.SetSimEvents(new ObservableDictionary<string, SimEvent>());
			this.SetExplosions(new ObservableCollection<Explosion>());
			this.SetWeaponImpacts(new ObservableCollection<WeaponImpact>());
			this.SetWaterSplashes(new ObservableCollection<WaterSplash>());
			this.SetGroundImpacts(new ObservableCollection<GroundImpact>());
			this.SetUnguidedWeapons(new ObservableDictionary<string, UnguidedWeapon>());
			this.LockObject1 = RuntimeHelpers.GetObjectValue(new object());
			this.LockObject2 = RuntimeHelpers.GetObjectValue(new object());
			this.TimelineID = Guid.NewGuid().ToString();
			this._ObjectID = Guid.NewGuid().ToString();
			this.ZeroHour = this._Time;
		}

		// Token: 0x06005D04 RID: 23812 RVA: 0x002B1324 File Offset: 0x002AF524
		public Scenario(string st_Title, string str_Description, string str_FileName)
		{
			this.RunningInMonteCarloMode = false;
			this.SetActiveUnits(new ObservableDictionary<string, ActiveUnit>());
			this.Groups = new GroupsCollection();
			this._GuidedWeaponsInAir = new List<Weapon>();
			this._SonobuoysInWater = new List<Weapon>();
			this._AllWeaponsAlive = new List<Weapon>();
			this.SnapShots = new Collection<Scenario>();
			this._Sides = new Side[0];
			this._UnitAdditions = new List<ActiveUnit>();
			this._UnitRemovals = new List<ActiveUnit>();
			this._UnitDeletions = new List<ActiveUnit>();
			this.Navigation_FinegrainedThresholdDistance = 8f;
			this.Navigation_FinegrainedMaxDistance = 0.5f;
			this.UserIsPlottingCourse = false;
			this.SetScenAttachmentEvent(new ObservableDictionary<string, ScenAttachmentObject>());
			this.UnhandledPopUpMessages = new Queue<LoggedMessage>();
			this.MessageLog = new ConcurrentDictionary<long, LoggedMessage>();
			this.UnitsForLateInstantiation = new HashSet<XmlNode>();
			this.Cache_FacilitiesWithPiers = new List<ActiveUnit>();
			this.Cache_Weapons = new ConcurrentDictionary<int, Weapon>();
			this.Cache_SensorCompatibleFrequencies = new ConcurrentDictionary<int, ConcurrentDictionary<int, bool>>();
			this.Cache_XSections = new ConcurrentDictionary<string, List<XSection>>();
			this.Cache_Aircraft_DT = new DataTable();
			this.Cache_Ships_DT = new DataTable();
			this.Cache_Subs_DT = new DataTable();
			this.Cache_Facilities_DT = new DataTable();
			this.Cache_Satellites_DT = new DataTable();
			this.Cache_Weapons_DT = new DataTable();
			this.Cache_OperatorCountries_DT = new DataTable();
			this.Cache_FuelForPitchEnabledWeapons = new ConcurrentDictionary<int, int>();
			this.CandidatesForDetectionByMines = new ActiveUnit[0];
			this.LoadingNotices = new List<string>();
			this.ThreadedOpsMustStop = false;
			this.DeclaredFeatures = new HashSet<Scenario.ScenarioFeatureOption>();
			this.LastSavedInScenEdit = false;
			this.FeatureCompatibility = default(Scenario._FeatureCompatibility);
			this.MissionPlannerErrorList = new List<string>();
			this.SetEventTriggersEvent(new ObservableDictionary<string, EventTrigger>());
			this.SetEventConditions(new ObservableDictionary<string, EventCondition>());
			this.SetEventActions(new ObservableDictionary<string, EventAction>());
			this.SetSimEvents(new ObservableDictionary<string, SimEvent>());
			this.SetExplosions(new ObservableCollection<Explosion>());
			this.SetWeaponImpacts(new ObservableCollection<WeaponImpact>());
			this.SetWaterSplashes(new ObservableCollection<WaterSplash>());
			this.SetGroundImpacts(new ObservableCollection<GroundImpact>());
			this.SetUnguidedWeapons(new ObservableDictionary<string, UnguidedWeapon>());
			this.LockObject1 = RuntimeHelpers.GetObjectValue(new object());
			this.LockObject2 = RuntimeHelpers.GetObjectValue(new object());
			this.SetScenarioTitle(st_Title);
			this.SetDescription(str_Description);
			this.FileName = str_FileName;
			this.AdvanceSimTime(false, DateAndTime.Now.ToUniversalTime());
			this.TimelineID = Guid.NewGuid().ToString();
			this._ObjectID = Guid.NewGuid().ToString();
			this.ZeroHour = this._Time;
		}

		// Token: 0x06005D05 RID: 23813 RVA: 0x002B15AC File Offset: 0x002AF7AC
		public Scenario(string string_DBUsed)
		{
			this.RunningInMonteCarloMode = false;
			this.SetActiveUnits(new ObservableDictionary<string, ActiveUnit>());
			this.Groups = new GroupsCollection();
			this._GuidedWeaponsInAir = new List<Weapon>();
			this._SonobuoysInWater = new List<Weapon>();
			this._AllWeaponsAlive = new List<Weapon>();
			this.SnapShots = new Collection<Scenario>();
			this._Sides = new Side[0];
			this._UnitAdditions = new List<ActiveUnit>();
			this._UnitRemovals = new List<ActiveUnit>();
			this._UnitDeletions = new List<ActiveUnit>();
			this.Navigation_FinegrainedThresholdDistance = 8f;
			this.Navigation_FinegrainedMaxDistance = 0.5f;
			this.UserIsPlottingCourse = false;
			this.SetScenAttachmentEvent(new ObservableDictionary<string, ScenAttachmentObject>());
			this.UnhandledPopUpMessages = new Queue<LoggedMessage>();
			this.MessageLog = new ConcurrentDictionary<long, LoggedMessage>();
			this.UnitsForLateInstantiation = new HashSet<XmlNode>();
			this.Cache_FacilitiesWithPiers = new List<ActiveUnit>();
			this.Cache_Weapons = new ConcurrentDictionary<int, Weapon>();
			this.Cache_SensorCompatibleFrequencies = new ConcurrentDictionary<int, ConcurrentDictionary<int, bool>>();
			this.Cache_XSections = new ConcurrentDictionary<string, List<XSection>>();
			this.Cache_Aircraft_DT = new DataTable();
			this.Cache_Ships_DT = new DataTable();
			this.Cache_Subs_DT = new DataTable();
			this.Cache_Facilities_DT = new DataTable();
			this.Cache_Satellites_DT = new DataTable();
			this.Cache_Weapons_DT = new DataTable();
			this.Cache_OperatorCountries_DT = new DataTable();
			this.Cache_FuelForPitchEnabledWeapons = new ConcurrentDictionary<int, int>();
			this.CandidatesForDetectionByMines = new ActiveUnit[0];
			this.LoadingNotices = new List<string>();
			this.ThreadedOpsMustStop = false;
			this.DeclaredFeatures = new HashSet<Scenario.ScenarioFeatureOption>();
			this.LastSavedInScenEdit = false;
			this.FeatureCompatibility = default(Scenario._FeatureCompatibility);
			this.MissionPlannerErrorList = new List<string>();
			this.SetEventTriggersEvent(new ObservableDictionary<string, EventTrigger>());
			this.SetEventConditions(new ObservableDictionary<string, EventCondition>());
			this.SetEventActions(new ObservableDictionary<string, EventAction>());
			this.SetSimEvents(new ObservableDictionary<string, SimEvent>());
			this.SetExplosions(new ObservableCollection<Explosion>());
			this.SetWeaponImpacts(new ObservableCollection<WeaponImpact>());
			this.SetWaterSplashes(new ObservableCollection<WaterSplash>());
			this.SetGroundImpacts(new ObservableCollection<GroundImpact>());
			this.SetUnguidedWeapons(new ObservableDictionary<string, UnguidedWeapon>());
			this.LockObject1 = RuntimeHelpers.GetObjectValue(new object());
			this.LockObject2 = RuntimeHelpers.GetObjectValue(new object());
			this._Time = DateAndTime.Now.ToUniversalTime();
			this.SetDBUsed(string_DBUsed);
			this.TimelineID = Guid.NewGuid().ToString();
			this._ObjectID = Guid.NewGuid().ToString();
			this.ZeroHour = this._Time;
		}

		// Token: 0x06005D06 RID: 23814 RVA: 0x002B1824 File Offset: 0x002AFA24
		public long GetMessageIncrement()
		{
			return this._MessageIncrement;
		}

		// Token: 0x06005D07 RID: 23815 RVA: 0x00029685 File Offset: 0x00027885
		public void AddMessageIncrement()
		{
			this._MessageIncrement += 1L;
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x002B183C File Offset: 0x002AFA3C
		public void MessageLogTryAdd(LoggedMessage loggedMessage_0)
		{
			Scenario.NewMessageEventHandler newMessageEvent = Scenario.NewMessageEvent;
			if (newMessageEvent != null)
			{
				newMessageEvent(loggedMessage_0);
			}
			if (!Information.IsNothing(loggedMessage_0))
			{
				try
				{
					if (SimConfiguration.gameOptions.MessageTypeShowOptionsDictionary[loggedMessage_0.messageType].bool_1)
					{
						this.UnhandledPopUpMessages.Enqueue(loggedMessage_0);
					}
					if (SimConfiguration.gameOptions.MessageTypeShowOptionsDictionary[loggedMessage_0.messageType].bool_0)
					{
						this.MessageLog.TryAdd(loggedMessage_0.Increment, loggedMessage_0);
						if (!Information.IsNothing(loggedMessage_0.side))
						{
							LoggedMessage.MessageType messageType = loggedMessage_0.messageType;
							if (messageType - LoggedMessage.MessageType.NewContact <= 1 || messageType - LoggedMessage.MessageType.UnitLost <= 1 || messageType - LoggedMessage.MessageType.NewAirContact <= 3)
							{
								Side[] sides = this.GetSides();
								checked
								{
									for (int i = 0; i < sides.Length; i++)
									{
										Side side = sides[i];
										if (side != loggedMessage_0.side && loggedMessage_0.side.GetPostureStance(side) == Misc.PostureStance.Friendly)
										{
											this.AddMessageIncrement();
											LoggedMessage loggedMessage = new LoggedMessage(this._MessageIncrement, loggedMessage_0.Text, loggedMessage_0.messageType, this._Time, loggedMessage_0.ReporterID, loggedMessage_0.Level, side, loggedMessage_0.Location);
											this.MessageLog.TryAdd(loggedMessage.Increment, loggedMessage);
										}
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200584", "");
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005D09 RID: 23817 RVA: 0x002B19E4 File Offset: 0x002AFBE4
		public void LogMessage(string MessageText, LoggedMessage.MessageType MessageType, byte MessageLevel, string ReporterID, Side theSide = null, GeoPoint theLocation = null)
		{
			try
			{
				if (MessageType != LoggedMessage.MessageType.UnguidedWeaponModifiers || GameGeneral.bProfessionEdition)
				{
					if (this._MessageIncrement == 9223372036854775807L)
					{
						this._MessageIncrement = 1L;
					}
					else
					{
						this._MessageIncrement += 1L;
					}
					LoggedMessage loggedMessage_ = new LoggedMessage(this._MessageIncrement, MessageText, MessageType, this._Time, ReporterID, MessageLevel, theSide, theLocation);
					this.MessageLogTryAdd(loggedMessage_);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101031", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005D0A RID: 23818 RVA: 0x002B1AB0 File Offset: 0x002AFCB0
		public void UpdateExplosionList()
		{
			try
			{
				List<Explosion> list = new List<Explosion>();
				foreach (Explosion current in this.GetExplosions())
				{
					if (current.IsTimeOut())
					{
						list.Add(current);
					}
				}
				foreach (Explosion current2 in list)
				{
					this.GetExplosions().Remove(current2);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101032", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005D0B RID: 23819 RVA: 0x0002969D File Offset: 0x0002789D
		public void ClearMessageLog()
		{
			this.MessageLog.Clear();
		}

		// Token: 0x06005D0C RID: 23820 RVA: 0x002B1BA8 File Offset: 0x002AFDA8
		public void UpdateActiveUnits()
		{
			try
			{
				for (int i = this._UnitAdditions.Count - 1; i >= 0; i += -1)
				{
					ActiveUnit activeUnit = this._UnitAdditions[i];
					if (!this.GetActiveUnits().ContainsKey(activeUnit.GetGuid()))
					{
						this.GetActiveUnits().Add(activeUnit.GetGuid(), activeUnit);
					}
					this._UnitAdditions.Remove(activeUnit);
				}
				for (int j = this._UnitRemovals.Count - 1; j >= 0; j += -1)
				{
					ActiveUnit activeUnit2 = this._UnitRemovals[j];
					if (this._UnitDeletions.Contains(activeUnit2))
					{
						this._UnitDeletions.Remove(activeUnit2);
					}
					this.GetActiveUnits().Remove(activeUnit2.GetGuid());
					this._UnitRemovals.Remove(activeUnit2);
					activeUnit2.DestroyUnit(false, false, false);
				}
				for (int k = this._UnitDeletions.Count - 1; k >= 0; k += -1)
				{
					ActiveUnit activeUnit3 = this._UnitDeletions[k];
					activeUnit3.DestroyUnit(true, false, false);
					this.GetActiveUnits().Remove(activeUnit3.GetGuid());
					this._UnitDeletions.Remove(activeUnit3);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101033", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005D0D RID: 23821 RVA: 0x000296AA File Offset: 0x000278AA
		public void DeleteUnit(ActiveUnit activeUnit_0)
		{
			if (!this._UnitDeletions.Contains(activeUnit_0))
			{
				this._UnitDeletions.Add(activeUnit_0);
			}
		}

		// Token: 0x06005D0E RID: 23822 RVA: 0x002B1D3C File Offset: 0x002AFF3C
		public void RemoveUnit(ActiveUnit activeUnit_0)
		{
			if (!this._UnitRemovals.Contains(activeUnit_0))
			{
				this._UnitRemovals.Add(activeUnit_0);
			}
			foreach (IEventExporter current in this.GetEventExporters())
			{
				if (current.imethod_24())
				{
					Dictionary<string, Tuple<Type, string>> dictionary = new Dictionary<string, Tuple<Type, string>>();
					dictionary.Add("TimelineID", new Tuple<Type, string>(typeof(string), this.TimelineID));
					if (current.IsUseZeroHour())
					{
						TimeSpan timeSpan = this.GetCurrentTime(false).Subtract(this.ZeroHour);
						dictionary.Add("Time", new Tuple<Type, string>(typeof(TimeSpan), timeSpan.ToString("c")));
					}
					else
					{
						dictionary.Add("Time", new Tuple<Type, string>(typeof(DateTime), this.GetCurrentTime(false).ToString("MM/dd/yyyy HH:mm:ss") + "." + activeUnit_0.m_Scenario.GetCurrentTime(false).Millisecond.ToString("D3")));
					}
					dictionary.Add("UnitID", new Tuple<Type, string>(typeof(string), activeUnit_0.GetGuid()));
					dictionary.Add("UnitName", new Tuple<Type, string>(typeof(string), activeUnit_0.Name));
					dictionary.Add("UnitClass", new Tuple<Type, string>(typeof(string), activeUnit_0.UnitClass));
					dictionary.Add("UnitSide", new Tuple<Type, string>(typeof(string), activeUnit_0.GetSide(false).GetSideName()));
					dictionary.Add("MiscInfo", new Tuple<Type, string>(typeof(string), ""));
					current.ExportEvent(ExportedEventType.UnitDestroyed, dictionary, this);
				}
			}
		}

		// Token: 0x06005D0F RID: 23823 RVA: 0x000296C6 File Offset: 0x000278C6
		public void AddUnit(ActiveUnit activeUnit_0)
		{
			if (!this._UnitAdditions.Contains(activeUnit_0))
			{
				this._UnitAdditions.Add(activeUnit_0);
			}
		}

		// Token: 0x06005D10 RID: 23824 RVA: 0x002B1F3C File Offset: 0x002B013C
		public void AddSide(Side side_0)
		{
			ScenarioArrayUtil.AddSide(ref this._Sides, side_0);
			Scenario.SidesChangedEventHandler sidesChangedEvent = Scenario.SidesChangedEvent;
			if (sidesChangedEvent != null)
			{
				sidesChangedEvent(this, Scenario._SideChange.AddSide);
			}
		}

		// Token: 0x06005D11 RID: 23825 RVA: 0x002B1F6C File Offset: 0x002B016C
		public void RemoveSide(Side side_0)
		{
			ScenarioArrayUtil.RemoveSide(ref this._Sides, side_0);
			Scenario.SidesChangedEventHandler sidesChangedEvent = Scenario.SidesChangedEvent;
			if (sidesChangedEvent != null)
			{
				sidesChangedEvent(this, Scenario._SideChange.RemoveSide);
			}
		}

		// Token: 0x06005D12 RID: 23826 RVA: 0x002B1F9C File Offset: 0x002B019C
		public Aircraft AddAircraft(Side theSide, string theName, double Longitude, double Latitude, int AircraftDBID, int LoadoutID, float Altitude, string theGUID = null)
		{
			Aircraft result = null;
			try
			{
				if (this.IsUnitExists(theGUID))
				{
					throw new Exception("Requested custom GUID is already in use in this scenario");
				}
				Scenario scenario = this;
				Aircraft aircraft = new Aircraft(ref scenario, theGUID);
				scenario = this;
				DBFunctions.smethod_19(ref scenario, ref aircraft, AircraftDBID, true);
				this.UnitsAutoIncrement++;
				aircraft.Name = theName;
				aircraft.SetSide(false, theSide);
				if (!Information.IsNothing(LoadoutID) && LoadoutID > 0)
				{
					DBFunctions.smethod_48(ref aircraft, LoadoutID, false);
				}
				aircraft.SetThrottle(ActiveUnit.Throttle.Loiter, null);
				aircraft.GetAircraftKinematics().SetBingoJokerFuel();
				aircraft.SetCurrentHeading(0f);
				aircraft.SetCurrentSpeed((float)aircraft.GetAircraftKinematics().GetSpeed(Altitude, ActiveUnit.Throttle.Loiter));
				aircraft.SetLatitude(null, Latitude);
				aircraft.SetLongitude(null, Longitude);
				aircraft.SetAltitude_ASL(false, Altitude);
				aircraft.GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
				aircraft.SetDesiredHeading(ActiveUnit._TurnRate.const_0, 0f);
				aircraft.SetDesiredAltitude(Altitude);
				ActiveUnit activeUnit = aircraft;
				scenario = this;
				GameGeneral.AddActiveUnit(ref activeUnit, ref scenario);
				checked
				{
					if (!Information.IsNothing(aircraft.GetLoadout()))
					{
						WeaponRec[] weaponRecArray = aircraft.GetLoadout().WeaponRecArray;
						for (int i = 0; i < weaponRecArray.Length; i++)
						{
							Weapon weapon = weaponRecArray[i].GetWeapon(aircraft.m_Scenario);
							weapon.SetLongitude(null, aircraft.GetLongitude(null));
							weapon.SetLatitude(null, aircraft.GetLatitude(null));
							weapon.SetAltitude_ASL(false, aircraft.GetCurrentAltitude_ASL(false));
							weapon.SetCurrentHeading(aircraft.GetCurrentHeading());
							weapon.SetCurrentSpeed(aircraft.GetCurrentSpeed());
						}
					}
					ActiveUnit_Kinematics.ExportUnitPositions(aircraft);
					result = aircraft;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101034", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06005D13 RID: 23827 RVA: 0x002B21D0 File Offset: 0x002B03D0
		public Satellite AddSatellite(Side theSide, string theName, int SatelliteDBID, int OrbitIndex, string theGUID = null)
		{
			Satellite result = null;
			try
			{
				Scenario scenario = this;
				Satellite satellite = new Satellite(ref scenario);
				scenario = this;
				DBFunctions.LoadSatelliteData(ref scenario, ref satellite, SatelliteDBID, OrbitIndex, true);
				this.UnitsAutoIncrement++;
				satellite.GetSatelliteKinematics().UpdateUnitPositions(1f, false, false);
				Side[] sides = this.GetSides();
				checked
				{
					for (int i = 0; i < sides.Length; i++)
					{
						Side side_ = sides[i];
						satellite.SetIsAutoDetectable(side_, true);
					}
					if (!string.IsNullOrEmpty(theName))
					{
						satellite.Name = theName;
					}
					satellite.SetSide(false, theSide);
					ActiveUnit activeUnit = satellite;
					scenario = this;
					GameGeneral.AddActiveUnit(ref activeUnit, ref scenario);
					ActiveUnit_Kinematics.ExportUnitPositions(satellite);
					result = satellite;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101035", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06005D14 RID: 23828 RVA: 0x002B22C4 File Offset: 0x002B04C4
		public Ship AddShip(Side theSide, int ShipDBID, string theName, double Longitude, double Latitude, bool IgnoreElevationCheck = false, string theGUID = null)
		{
			Ship result = null;
			try
			{
				if (this.IsUnitExists(theGUID))
				{
					throw new Exception("Requested custom GUID is already in use in this scenario");
				}
				double num = (double)Terrain.GetElevation(Latitude, Longitude, false);
				if (!IgnoreElevationCheck && num > 0.0)
				{
					throw new Exception("You cannot place a ship overland!");
				}
				Scenario scenario = this;
				Ship ship = new Ship(ref scenario, theGUID);
				scenario = this;
				DBFunctions.smethod_51(ref scenario, ref ship, ShipDBID, true);
				this.UnitsAutoIncrement++;
				ship.Name = theName;
				ship.SetSide(false, theSide);
				ship.SetCurrentHeading(0f);
				ship.SetCurrentSpeed(0f);
				ship.SetLatitude(null, Latitude);
				ship.SetLongitude(null, Longitude);
				ship.SetDesiredSpeed(0f);
				ship.SetDesiredHeading(ActiveUnit._TurnRate.const_0, 0f);
				ActiveUnit activeUnit = ship;
				scenario = this;
				GameGeneral.AddActiveUnit(ref activeUnit, ref scenario);
				ActiveUnit_Kinematics.ExportUnitPositions(ship);
				result = ship;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101036", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06005D15 RID: 23829 RVA: 0x002B240C File Offset: 0x002B060C
		private bool IsUnitExists(string string_0)
		{
			bool flag;
			bool result;
			if (string.IsNullOrEmpty(string_0))
			{
				flag = false;
			}
			else
			{
				using (List<ActiveUnit>.Enumerator enumerator = this.GetActiveUnitList().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (Operators.CompareString(enumerator.Current.GetGuid(), string_0, false) == 0)
						{
							result = true;
							return result;
						}
					}
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06005D16 RID: 23830 RVA: 0x002B2488 File Offset: 0x002B0688
		public Submarine AddSubmarine(Side theSide, int SubDBID, string theName, double Longitude, double Latitude, bool IgnoreElevationCheck = false, string theGUID = null)
		{
			Submarine result = null;
			try
			{
				if (this.IsUnitExists(theGUID))
				{
					throw new Exception("Requested custom GUID is already in use in this scenario");
				}
				double num = (double)Terrain.GetElevation(Latitude, Longitude, false);
				if (!IgnoreElevationCheck && num > 0.0)
				{
					throw new Exception("You cannot place a submarine overland!");
				}
				Scenario scenario = this;
				Submarine submarine = new Submarine(ref scenario, theGUID);
				scenario = this;
				DBFunctions.LoadSubmarineData(ref scenario, ref submarine, SubDBID, true);
				this.UnitsAutoIncrement++;
				submarine.Name = theName;
				submarine.SetSide(false, theSide);
				submarine.SetCurrentHeading(0f);
				submarine.SetCurrentSpeed(4f);
				submarine.SetAltitude_ASL(false, Math.Max(-40f, submarine.GetSubmarineKinematics().GetMinAltitude()));
				submarine.SetLatitude(null, Latitude);
				submarine.SetLongitude(null, Longitude);
				submarine.SetDesiredSpeed(0f);
				submarine.SetDesiredHeading(ActiveUnit._TurnRate.const_0, 0f);
				submarine.SetDesiredAltitude(-20f);
				ActiveUnit activeUnit = submarine;
				scenario = this;
				GameGeneral.AddActiveUnit(ref activeUnit, ref scenario);
				ActiveUnit_Kinematics.ExportUnitPositions(submarine);
				result = submarine;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101037", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06005D17 RID: 23831 RVA: 0x002B2600 File Offset: 0x002B0800
		public Facility AddFacility(Side theSide, int FacilityDBID, string theName, double Longitude, double Latitude, bool IgnoreElevationCheck = false, string theGUID = null)
		{
			Facility result;
			try
			{
				if (this.IsUnitExists(theGUID))
				{
					throw new Exception("Requested custom GUID is already in use in this scenario");
				}
				Scenario scenario = this;
				Facility facility = new Facility(ref scenario, theGUID);
				int elevation = (int)Terrain.GetElevation(Latitude, Longitude, false);
				scenario = this;
				DBFunctions.LoadFacilityData(ref scenario, ref facility, FacilityDBID, true);
				if (facility.IsFixedFacility())
				{
					facility.SetIsAutoDetectable(null, true);
				}
				facility.Name = theName;
				if (!IgnoreElevationCheck && elevation < 0 && facility.Category != Facility._FacilityCategory.Underwater)
				{
					throw new Exception(string.Concat(new string[]
					{
						"尝试部署地面设施: ",
						facility.Name,
						" (类型: ",
						facility.UnitClass,
						" - DBID: ",
						Conversions.ToString(facility.DBID),
						")于地理坐标点: 纬度: ",
						Conversions.ToString(Latitude),
						" - 经度: ",
						Conversions.ToString(Longitude),
						" . 该坐标点似乎位于水下。部署终止！"
					}));
				}
				this.UnitsAutoIncrement++;
				facility.SetSide(false, theSide);
				facility.SetCurrentHeading(0f);
				facility.SetCurrentSpeed(0f);
				facility.SetLatitude(null, Latitude);
				facility.SetLongitude(null, Longitude);
				facility.SetAltitude_ASL(false, (float)elevation);
				facility.SetDesiredSpeed(0f);
				facility.SetDesiredHeading(ActiveUnit._TurnRate.const_0, 0f);
				ActiveUnit activeUnit = facility;
				scenario = this;
				GameGeneral.AddActiveUnit(ref activeUnit, ref scenario);
				ActiveUnit_Kinematics.ExportUnitPositions(facility);
				result = facility;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101286", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06005D18 RID: 23832 RVA: 0x002B27E0 File Offset: 0x002B09E0
		public UnguidedWeapon AddUnguidedWeapon(Side side_0, int int_0, List<ReferencePoint> list_0)
		{
			UnguidedWeapon result = null;
			try
			{
				Weapon weapon = this.GetWeapon(int_0);
				UnguidedWeapon unguidedWeapon = new UnguidedWeapon(weapon, null, null, 0.0, 0.0, 0L);
				unguidedWeapon.SetSide(false, side_0);
				GeoPoint geoPoint = Math2.PickSuitablePointInsideArea(list_0);
				if (Information.IsNothing(geoPoint))
				{
					result = null;
				}
				else if (string.CompareOrdinal(UnguidedWeapon.LayMine(ref unguidedWeapon, geoPoint.GetLatitude(), geoPoint.GetLongitude(), (float)Terrain.GetElevation(geoPoint.GetLatitude(), geoPoint.GetLongitude(), false), this), "OK") == 0)
				{
					this.GetUnguidedWeapons().Add(unguidedWeapon.GetGuid(), unguidedWeapon);
					result = unguidedWeapon;
				}
				else
				{
					result = null;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101039", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x002B28E4 File Offset: 0x002B0AE4
		public Collection<ActiveUnit> ImportUnits(string strImportFromFile, Side side_0)
		{
			Collection<ActiveUnit> result = null;
			try
			{
				StreamReader streamReader = new StreamReader(strImportFromFile);
				Collection<ActiveUnit> collection = new Collection<ActiveUnit>();
				new Collection<string>();
				ImportExportRecord importExportRecord;
				using (streamReader)
				{
					importExportRecord = (ImportExportRecord)JsonConvert.DeserializeObject(streamReader.ReadToEnd(), typeof(ImportExportRecord));
				}
				foreach (ImportExportRecord.MemberRecord current in importExportRecord.MemberRecords)
				{
					try
					{
						this.ImportMemberRecord(current, ref collection, ref side_0);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200054", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
				List<Group> list = new List<Group>();
				List<ActiveUnit> list2 = side_0.ActiveUnitArray.ToList<ActiveUnit>();
				foreach (ActiveUnit current2 in list2)
				{
					if (current2.IsGroup && ((Group)current2).GetUnitsInGroup().Count < 2)
					{
						list.Add((Group)current2);
					}
				}
				foreach (Group current3 in list)
				{
					Scenario scenario = this;
					GameGeneral.RemoveUnit(ref scenario, current3.GetGuid());
				}
				result = collection;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 101040", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Collection<ActiveUnit>();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x002B2B4C File Offset: 0x002B0D4C
		private void ImportMemberRecord(ImportExportRecord.MemberRecord memberRecord_0, ref Collection<ActiveUnit> collection_0, ref Side side_0)
		{
			ActiveUnit activeUnit = null;
			if (Information.IsNothing(memberRecord_0.MemberType))
			{
				Facility facility = this.AddFacility(side_0, memberRecord_0.Member_DBID, memberRecord_0.MemberName, memberRecord_0.Longitude, memberRecord_0.Latitude, false, memberRecord_0.Member_GUID);
				facility.SetCurrentHeading(memberRecord_0.Orientation);
				collection_0.Add(facility);
				activeUnit = facility;
				this.ImportGroupMemberRecord(ref memberRecord_0, ref side_0, ref activeUnit);
			}
			else
			{
				string memberType = memberRecord_0.MemberType;
				uint num = Class382.smethod_0(memberType);
				if (num <= 2722002328u)
				{
					if (num <= 746798495u)
					{
						if (num != 200131980u)
						{
							if (num == 746798495u && Operators.CompareString(memberType, "Ship", false) == 0)
							{
								Ship ship = this.AddShip(side_0, memberRecord_0.Member_DBID, memberRecord_0.MemberName, memberRecord_0.Longitude, memberRecord_0.Latitude, false, memberRecord_0.Member_GUID);
								ship.SetCurrentHeading(memberRecord_0.Orientation);
								activeUnit = ship;
								this.ImportHostedAircraftRecords(ref activeUnit, side_0, ref memberRecord_0);
								collection_0.Add(ship);
								activeUnit = ship;
								this.ImportGroupMemberRecord(ref memberRecord_0, ref side_0, ref activeUnit);
							}
						}
						else if (Operators.CompareString(memberType, "Command_Core.Aircraft", false) == 0)
						{
							Aircraft aircraft = this.AddAircraft(side_0, memberRecord_0.MemberName, memberRecord_0.Longitude, memberRecord_0.Latitude, memberRecord_0.Member_DBID, memberRecord_0.LoadoutID, (float)memberRecord_0.Altitude, memberRecord_0.Member_GUID);
							aircraft.SetCurrentHeading(memberRecord_0.Orientation);
							activeUnit = aircraft;
							this.ImportHostedAircraftRecords(ref activeUnit, side_0, ref memberRecord_0);
							collection_0.Add(aircraft);
							activeUnit = aircraft;
							this.ImportGroupMemberRecord(ref memberRecord_0, ref side_0, ref activeUnit);
						}
					}
					else if (num != 1158526071u)
					{
						if (num == 2722002328u && Operators.CompareString(memberType, "Facility", false) == 0)
						{
							Facility facility2 = this.AddFacility(side_0, memberRecord_0.Member_DBID, memberRecord_0.MemberName, memberRecord_0.Longitude, memberRecord_0.Latitude, false, memberRecord_0.Member_GUID);
							facility2.SetCurrentHeading(memberRecord_0.Orientation);
							activeUnit = facility2;
							this.ImportHostedAircraftRecords(ref activeUnit, side_0, ref memberRecord_0);
							collection_0.Add(facility2);
							activeUnit = facility2;
							this.ImportGroupMemberRecord(ref memberRecord_0, ref side_0, ref activeUnit);
						}
					}
					else if (Operators.CompareString(memberType, "Submarine", false) == 0)
					{
						Submarine submarine = this.AddSubmarine(side_0, memberRecord_0.Member_DBID, memberRecord_0.MemberName, memberRecord_0.Longitude, memberRecord_0.Latitude, false, memberRecord_0.Member_GUID);
						submarine.SetCurrentHeading(memberRecord_0.Orientation);
						activeUnit = submarine;
						this.ImportHostedAircraftRecords(ref activeUnit, side_0, ref memberRecord_0);
						collection_0.Add(submarine);
						activeUnit = submarine;
						this.ImportGroupMemberRecord(ref memberRecord_0, ref side_0, ref activeUnit);
					}
				}
				else if (num <= 3043739066u)
				{
					if (num != 3015506108u)
					{
						if (num == 3043739066u && Operators.CompareString(memberType, "Command_Core.Submarine", false) == 0)
						{
							Submarine submarine = this.AddSubmarine(side_0, memberRecord_0.Member_DBID, memberRecord_0.MemberName, memberRecord_0.Longitude, memberRecord_0.Latitude, false, memberRecord_0.Member_GUID);
							submarine.SetCurrentHeading(memberRecord_0.Orientation);
							activeUnit = submarine;
							this.ImportHostedAircraftRecords(ref activeUnit, side_0, ref memberRecord_0);
							collection_0.Add(submarine);
							activeUnit = submarine;
							this.ImportGroupMemberRecord(ref memberRecord_0, ref side_0, ref activeUnit);
						}
					}
					else if (Operators.CompareString(memberType, "Command_Core.Ship", false) == 0)
					{
						Ship ship = this.AddShip(side_0, memberRecord_0.Member_DBID, memberRecord_0.MemberName, memberRecord_0.Longitude, memberRecord_0.Latitude, false, memberRecord_0.Member_GUID);
						ship.SetCurrentHeading(memberRecord_0.Orientation);
						activeUnit = ship;
						this.ImportHostedAircraftRecords(ref activeUnit, side_0, ref memberRecord_0);
						collection_0.Add(ship);
						activeUnit = ship;
						this.ImportGroupMemberRecord(ref memberRecord_0, ref side_0, ref activeUnit);
					}
				}
				else if (num != 3409620667u)
				{
					if (num == 4032298643u && Operators.CompareString(memberType, "Aircraft", false) == 0)
					{
						Aircraft aircraft = this.AddAircraft(side_0, memberRecord_0.MemberName, memberRecord_0.Longitude, memberRecord_0.Latitude, memberRecord_0.Member_DBID, memberRecord_0.LoadoutID, (float)memberRecord_0.Altitude, memberRecord_0.Member_GUID);
						aircraft.SetCurrentHeading(memberRecord_0.Orientation);
						activeUnit = aircraft;
						this.ImportHostedAircraftRecords(ref activeUnit, side_0, ref memberRecord_0);
						collection_0.Add(aircraft);
						activeUnit = aircraft;
						this.ImportGroupMemberRecord(ref memberRecord_0, ref side_0, ref activeUnit);
					}
				}
				else if (Operators.CompareString(memberType, "Command_Core.Facility", false) == 0)
				{
					Facility facility2 = this.AddFacility(side_0, memberRecord_0.Member_DBID, memberRecord_0.MemberName, memberRecord_0.Longitude, memberRecord_0.Latitude, false, memberRecord_0.Member_GUID);
					facility2.SetCurrentHeading(memberRecord_0.Orientation);
					activeUnit = facility2;
					this.ImportHostedAircraftRecords(ref activeUnit, side_0, ref memberRecord_0);
					collection_0.Add(facility2);
					activeUnit = facility2;
					this.ImportGroupMemberRecord(ref memberRecord_0, ref side_0, ref activeUnit);
				}
			}
		}

		// Token: 0x06005D1B RID: 23835 RVA: 0x002B300C File Offset: 0x002B120C
		private void ImportHostedAircraftRecords(ref ActiveUnit activeUnit_0, Side side_0, ref ImportExportRecord.MemberRecord memberRecord_0)
		{
			if (!Information.IsNothing(memberRecord_0.HostedAircraftRecords) && memberRecord_0.HostedAircraftRecords.Count != 0)
			{
				try
				{
					foreach (ImportExportRecord.HostedAircraftRecord current in memberRecord_0.HostedAircraftRecords)
					{
						Aircraft aircraft_ = this.AddAircraft(side_0, current.Name, 0.0, 0.0, current.AC_DBID, current.Loadout_ID, 0f, null);
						activeUnit_0.GetAirOps().method_18(aircraft_, false);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101041", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005D1C RID: 23836 RVA: 0x002B3108 File Offset: 0x002B1308
		private void ImportGroupMemberRecord(ref ImportExportRecord.MemberRecord memberRecord_0, ref Side side_0, ref ActiveUnit activeUnit_0)
		{
			try
			{
				if (!Information.IsNothing(memberRecord_0.ParentGroupName))
				{
					if (this.Groups.method_1(memberRecord_0.ParentGroupName))
					{
						activeUnit_0.SetParentGroup(false, this.Groups.method_0(memberRecord_0.ParentGroupName));
					}
					else
					{
						List<ActiveUnit> list = new List<ActiveUnit>();
						list.Add(activeUnit_0);
						Scenario scenario = this;
						new Group(ref scenario, ref side_0, list, false, null, null).Name = memberRecord_0.ParentGroupName;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101042", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x002B31CC File Offset: 0x002B13CC
		public void UnitDestroyedEventsTrigger(ActiveUnit activeUnit_0, float float_0)
		{
			try
			{
				if (!activeUnit_0.IsGroup)
				{
					List<EventTrigger> list = new List<EventTrigger>();
					foreach (EventTrigger current in this.GetEventTriggers().Values)
					{
						if (current.eventTriggerType == EventTrigger.EventTriggerType.UnitDestroyed && ((EventTrigger_UnitDestroyed)current).method_11(activeUnit_0))
						{
							list.Add(current);
						}
					}
					foreach (EventTrigger current2 in this.GetEventTriggers().Values)
					{
						if (current2.eventTriggerType == EventTrigger.EventTriggerType.UnitDamaged && ((EventTrigger_UnitDamaged)current2).method_11(activeUnit_0, float_0, 101f))
						{
							list.Add(current2);
						}
					}
					this.TriggerEvents(list);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101043", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005D1E RID: 23838 RVA: 0x002B3314 File Offset: 0x002B1514
		public Weapon GetWeapon(int WeaponDBID)
		{
			Weapon weapon = null;
			if (!this.Cache_Weapons.TryGetValue(WeaponDBID, out weapon))
			{
				Scenario scenario = this;
				weapon = Weapon.GetWeapon(ref scenario, WeaponDBID, null);
				this.Cache_Weapons.TryAdd(WeaponDBID, weapon);
			}
			return weapon;
		}

		// Token: 0x06005D1F RID: 23839 RVA: 0x002B3350 File Offset: 0x002B1550
		private void ActiveUnits_DictionaryChanged(object sender, NotifyDictionaryChangedEventArgs<string, ActiveUnit> e)
		{
			checked
			{
				try
				{
					this._ActiveUnits_List = null;
					Side[] sides = this.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						sides[i].SetNoneWeaponFriendlyUnits(this, null);
					}
					NotifyCollectionChangedAction action = e.Action;
					if (action != NotifyCollectionChangedAction.Add)
					{
						if (action == NotifyCollectionChangedAction.Remove)
						{
							Scenario.UnitRemovedEventHandler unitRemovedEvent = Scenario.UnitRemovedEvent;
							if (unitRemovedEvent != null)
							{
								unitRemovedEvent(this, e.OldItem.Value);
							}
							ScenarioArrayUtil.RemoveActiveUnit(ref e.OldItem.Value.GetSide(false).ActiveUnitArray, e.OldItem.Value);
						}
					}
					else
					{
						if (!Information.IsNothing(e.NewItem.Value.GetSide(false)) && !e.NewItem.Value.GetSide(false).ActiveUnitArray.Contains(e.NewItem.Value))
						{
							ScenarioArrayUtil.AddActiveUnit(ref e.NewItem.Value.GetSide(false).ActiveUnitArray, e.NewItem.Value);
							Scenario.UnitAddedEventHandler unitAddedEvent = Scenario.UnitAddedEvent;
							if (unitAddedEvent != null)
							{
								unitAddedEvent(this, e.NewItem.Value);
							}
						}
						if (e.NewItem.Value.IsFixedFacility())
						{
							ActiveUnit_Kinematics.ExportUnitPositions(e.NewItem.Value);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200568", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005D20 RID: 23840 RVA: 0x002B3524 File Offset: 0x002B1724
		private void _UnguidedWeapons_DictionaryChanged(object sender, NotifyDictionaryChangedEventArgs<string, UnguidedWeapon> e)
		{
			checked
			{
				try
				{
					NotifyCollectionChangedAction action = e.Action;
					if (action == NotifyCollectionChangedAction.Remove)
					{
						Side[] sides = this.GetSides();
						for (int i = 0; i < sides.Length; i++)
						{
							sides[i].Contacts_NonAU.Remove(e.OldItem.Key);
						}
					}
					this.Mines = this.GetUnguidedWeapons().Values.Where(Scenario.IsMineFilter).ToList<UnguidedWeapon>();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101045", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005D21 RID: 23841 RVA: 0x002B35E8 File Offset: 0x002B17E8
		private void EventTriggers_DictionaryChanged(object sender, NotifyDictionaryChangedEventArgs<string, EventTrigger> e)
		{
			Scenario.EventTriggersChangedEventHandler eventTriggersChangedEvent = Scenario.EventTriggersChangedEvent;
			if (eventTriggersChangedEvent != null)
			{
				eventTriggersChangedEvent(this);
			}
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x002B3608 File Offset: 0x002B1808
		private void EventConditions_DictionaryChanged(object sender, NotifyDictionaryChangedEventArgs<string, EventCondition> e)
		{
			Scenario.EventConditionsChangedEventHandler eventConditionsChangedEvent = Scenario.EventConditionsChangedEvent;
			if (eventConditionsChangedEvent != null)
			{
				eventConditionsChangedEvent(this);
			}
		}

		// Token: 0x06005D23 RID: 23843 RVA: 0x002B3628 File Offset: 0x002B1828
		private void EventActions_DictionaryChanged(object sender, NotifyDictionaryChangedEventArgs<string, EventAction> e)
		{
			Scenario.EventActionsChangedEventHandler eventActionsChangedEvent = Scenario.EventActionsChangedEvent;
			if (eventActionsChangedEvent != null)
			{
				eventActionsChangedEvent(this);
			}
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x002B3648 File Offset: 0x002B1848
		private void SaveMessageLog(XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("MessageLog");
				foreach (KeyValuePair<long, LoggedMessage> current in this.MessageLog)
				{
					LoggedMessage value = current.Value;
					if (!Information.IsNothing(value) && this.GetSides().Contains(value.side))
					{
						value.Save(ref xmlWriter_0);
					}
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101046", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005D25 RID: 23845 RVA: 0x002B3720 File Offset: 0x002B1920
		private void ScenAttachments_DictionaryChanged(object sender, NotifyDictionaryChangedEventArgs<string, ScenAttachmentObject> e)
		{
			Scenario.ScenAttachmentsChangedEventHandler scenAttachmentsChangedEvent = Scenario.ScenAttachmentsChangedEvent;
			if (scenAttachmentsChangedEvent != null)
			{
				scenAttachmentsChangedEvent();
			}
		}

		// Token: 0x06005D26 RID: 23846 RVA: 0x002B3740 File Offset: 0x002B1940
		private void SetFlightSize()
		{
			Side[] sides = this.GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					if (!Information.IsNothing(side.GetMissionCollection()))
					{
						foreach (Mission current in side.GetPatrolMissionCollection(this))
						{
							if (!Information.IsNothing(current))
							{
								int num = 99;
								Mission._FlightSize flightSize = Mission._FlightSize.None;
								switch (current.MissionClass)
								{
								case Mission._MissionClass.Strike:
									flightSize = ((Strike)current).m_FlightSize;
									break;
								case Mission._MissionClass.Patrol:
									flightSize = ((Patrol)current).m_FlightSize;
									break;
								case Mission._MissionClass.Support:
									flightSize = ((SupportMission)current).m_FlightSize;
									break;
								case Mission._MissionClass.Ferry:
									flightSize = ((FerryMission)current).m_FlightSize;
									break;
								case Mission._MissionClass.Mining:
									flightSize = ((MiningMission)current).m_FlightSize;
									break;
								case Mission._MissionClass.MineClearing:
									flightSize = ((MineClearingMission)current).m_FlightSize;
									break;
								case Mission._MissionClass.Escort:
									flightSize = ((TankerMission)current).m_FlightSize;
									break;
								}
								if (flightSize == Mission._FlightSize.None)
								{
									Mission mission = current;
									Scenario scenario = this;
									Dictionary<string, Dictionary<string, Dictionary<string, int>>> dictionary = mission.method_22(ref scenario, false, false);
									foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, int>>> current2 in dictionary)
									{
										Dictionary<string, Dictionary<string, int>> value = current2.Value;
										foreach (KeyValuePair<string, Dictionary<string, int>> current3 in value)
										{
											Dictionary<string, int> value2 = current3.Value;
											foreach (KeyValuePair<string, int> current4 in value2)
											{
												if (current4.Value < num)
												{
													num = current4.Value;
												}
											}
										}
									}
									switch (current.MissionClass)
									{
									case Mission._MissionClass.Strike:
									{
										Strike strike = (Strike)current;
										Strike.StrikeType strikeType = strike.strikeType;
										if (strikeType != Strike.StrikeType.Air_Intercept)
										{
											if (strikeType != Strike.StrikeType.Sub_Strike)
											{
												if (num == 1)
												{
													strike.m_FlightSize = Mission._FlightSize.SingleAircraft;
												}
												else if (num == 2)
												{
													strike.m_FlightSize = Mission._FlightSize.TwoAircraft;
												}
												else if (num == 3)
												{
													strike.m_FlightSize = Mission._FlightSize.ThreeAircraft;
												}
												else if (num <= 5)
												{
													strike.m_FlightSize = Mission._FlightSize.FourAircraft;
												}
												else if (num <= 7)
												{
													strike.m_FlightSize = Mission._FlightSize.SixAircraft;
												}
												else
												{
													strike.m_FlightSize = Mission._FlightSize.FourAircraft;
												}
											}
											else
											{
												strike.m_FlightSize = Mission._FlightSize.SingleAircraft;
											}
										}
										else if (num == 1)
										{
											strike.m_FlightSize = Mission._FlightSize.SingleAircraft;
										}
										else
										{
											strike.m_FlightSize = Mission._FlightSize.TwoAircraft;
										}
										break;
									}
									case Mission._MissionClass.Patrol:
									{
										Patrol patrol = (Patrol)current;
										switch (patrol.patrolType)
										{
										case GlobalVariables.PatrolType.ASW:
											patrol.m_FlightSize = Mission._FlightSize.SingleAircraft;
											continue;
										case GlobalVariables.PatrolType.AAW:
											if (num == 1)
											{
												patrol.m_FlightSize = Mission._FlightSize.SingleAircraft;
												continue;
											}
											patrol.m_FlightSize = Mission._FlightSize.TwoAircraft;
											continue;
										case GlobalVariables.PatrolType.ASuW_Land:
											if (num == 1)
											{
												patrol.m_FlightSize = Mission._FlightSize.SingleAircraft;
												continue;
											}
											patrol.m_FlightSize = Mission._FlightSize.TwoAircraft;
											continue;
										case GlobalVariables.PatrolType.ASuW_Mixed:
											if (num == 1)
											{
												patrol.m_FlightSize = Mission._FlightSize.SingleAircraft;
												continue;
											}
											patrol.m_FlightSize = Mission._FlightSize.TwoAircraft;
											continue;
										case GlobalVariables.PatrolType.SEAD:
											if (num == 1)
											{
												patrol.m_FlightSize = Mission._FlightSize.SingleAircraft;
												continue;
											}
											patrol.m_FlightSize = Mission._FlightSize.TwoAircraft;
											continue;
										}
										patrol.m_FlightSize = Mission._FlightSize.SingleAircraft;
										break;
									}
									case Mission._MissionClass.Support:
										((SupportMission)current).m_FlightSize = Mission._FlightSize.SingleAircraft;
										break;
									case Mission._MissionClass.Ferry:
									{
										FerryMission ferryMission = (FerryMission)current;
										if (num == 1)
										{
											ferryMission.m_FlightSize = Mission._FlightSize.SingleAircraft;
										}
										else if (num == 2)
										{
											ferryMission.m_FlightSize = Mission._FlightSize.TwoAircraft;
										}
										else if (num == 3)
										{
											ferryMission.m_FlightSize = Mission._FlightSize.ThreeAircraft;
										}
										else if (num <= 5)
										{
											ferryMission.m_FlightSize = Mission._FlightSize.FourAircraft;
										}
										else if (num <= 7)
										{
											ferryMission.m_FlightSize = Mission._FlightSize.SixAircraft;
										}
										else
										{
											ferryMission.m_FlightSize = Mission._FlightSize.FourAircraft;
										}
										break;
									}
									case Mission._MissionClass.Mining:
									{
										MiningMission miningMission = (MiningMission)current;
										if (num == 1)
										{
											miningMission.m_FlightSize = Mission._FlightSize.SingleAircraft;
										}
										else if (num == 2)
										{
											miningMission.m_FlightSize = Mission._FlightSize.TwoAircraft;
										}
										else if (num == 3)
										{
											miningMission.m_FlightSize = Mission._FlightSize.ThreeAircraft;
										}
										else if (num <= 5)
										{
											miningMission.m_FlightSize = Mission._FlightSize.FourAircraft;
										}
										else if (num <= 7)
										{
											miningMission.m_FlightSize = Mission._FlightSize.SixAircraft;
										}
										else
										{
											miningMission.m_FlightSize = Mission._FlightSize.FourAircraft;
										}
										break;
									}
									case Mission._MissionClass.MineClearing:
										((MineClearingMission)current).m_FlightSize = Mission._FlightSize.SingleAircraft;
										break;
									case Mission._MissionClass.Escort:
										flightSize = ((TankerMission)current).m_FlightSize;
										break;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005D27 RID: 23847 RVA: 0x002B3CA4 File Offset: 0x002B1EA4
		public void ZoneAreaCheck(bool bool_0, ref string string_0)
		{
			checked
			{
				try
				{
					Side[] sides = this.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						foreach (Zone current in side.NoNavZoneList)
						{
							string text = "";
							if (!ActiveUnit_Navigator.smethod_6(ref current.Area, ref text, side.GetSideName(), "No-Navigation Zone '" + current.Description + "'"))
							{
								if (bool_0)
								{
									string_0 = string_0 + "    " + text + "\r\n";
								}
								else
								{
									Interaction.MsgBox(text + " Contact the scenario designer to have the problem rectified.", MsgBoxStyle.OkOnly, null);
								}
							}
						}
						foreach (Zone current2 in side.ExclusionZoneList)
						{
							string text2 = "";
							if (!ActiveUnit_Navigator.smethod_6(ref current2.Area, ref text2, side.GetSideName(), "Exclusion Zone '" + current2.Description + "'"))
							{
								if (bool_0)
								{
									string_0 = string_0 + "    " + text2 + "\r\n";
								}
								else
								{
									Interaction.MsgBox(text2 + " Contact the scenario designer to have the problem rectified.", MsgBoxStyle.OkOnly, null);
								}
							}
						}
						foreach (Mission current3 in side.GetMissionCollection())
						{
							string text3 = "";
							if (current3.MissionClass == Mission._MissionClass.Patrol)
							{
								if (!ActiveUnit_Navigator.smethod_6(ref ((Patrol)current3).PatrolAreaVertices, ref text3, side.GetSideName(), "patrol mission '" + current3.Name + "'"))
								{
									if (bool_0)
									{
										string_0 = string_0 + "    " + text3 + "\r\n";
									}
									else
									{
										Interaction.MsgBox(text3 + " Contact the scenario designer to have the problem rectified.", MsgBoxStyle.OkOnly, null);
									}
								}
							}
							else if (current3.MissionClass == Mission._MissionClass.Support)
							{
								if (!ActiveUnit_Navigator.smethod_6(ref ((SupportMission)current3).NavigationCourseReferencePoints, ref text3, side.GetSideName(), "support mission '" + current3.Name + "'"))
								{
									if (bool_0)
									{
										string_0 = string_0 + "    " + text3 + "\r\n";
									}
									else
									{
										Interaction.MsgBox(text3 + " Contact the scenario designer to have the problem rectified.", MsgBoxStyle.OkOnly, null);
									}
								}
							}
							else if (current3.MissionClass == Mission._MissionClass.Mining)
							{
								if (!ActiveUnit_Navigator.smethod_6(ref ((MiningMission)current3).AreaVertices, ref text3, side.GetSideName(), "mining mission '" + current3.Name + "'"))
								{
									if (bool_0)
									{
										string_0 = string_0 + "    " + text3 + "\r\n";
									}
									else
									{
										Interaction.MsgBox(text3 + " Contact the scenario designer to have the problem rectified.", MsgBoxStyle.OkOnly, null);
									}
								}
							}
							else if (current3.MissionClass == Mission._MissionClass.MineClearing && !ActiveUnit_Navigator.smethod_6(ref ((MineClearingMission)current3).AreaVertices, ref text3, side.GetSideName(), "mine clearing mission '" + current3.Name + "'"))
							{
								if (bool_0)
								{
									string_0 = string_0 + "    " + text3 + "\r\n";
								}
								else
								{
									Interaction.MsgBox(text3 + " Contact the scenario designer to have the problem rectified.", MsgBoxStyle.OkOnly, null);
								}
							}
						}
					}
					foreach (EventTrigger current4 in this.GetEventTriggers().Values)
					{
						EventTrigger.EventTriggerType eventTriggerType = current4.eventTriggerType;
						if (eventTriggerType != EventTrigger.EventTriggerType.UnitRemainsInArea)
						{
							if (eventTriggerType == EventTrigger.EventTriggerType.UnitEntersArea)
							{
								string text4 = "";
								if (!ActiveUnit_Navigator.smethod_6(ref ((EventTrigger_UnitEntersArea)current4).Area, ref text4, "", "Unit Remains In Area trigger '" + current4.strDescription + "'"))
								{
									if (bool_0)
									{
										string_0 = string_0 + "    " + text4 + "\r\n";
									}
									else
									{
										Interaction.MsgBox(text4 + " Contact the scenario designer to have the problem rectified.", MsgBoxStyle.OkOnly, null);
									}
								}
							}
						}
						else
						{
							string text5 = "";
							if (!ActiveUnit_Navigator.smethod_6(ref ((EventTrigger_UnitRemainsInArea)current4).referencePointList, ref text5, "", "Unit Remains In Area trigger '" + current4.strDescription + "'"))
							{
								if (bool_0)
								{
									string_0 = string_0 + "    " + text5 + "\r\n";
								}
								else
								{
									Interaction.MsgBox(text5 + " Contact the scenario designer to have the problem rectified.", MsgBoxStyle.OkOnly, null);
								}
							}
						}
					}
					foreach (EventAction current5 in this.GetEventActions().Values)
					{
						EventAction.EventActionType eventActionType = current5.eventActionType;
						if (eventActionType == EventAction.EventActionType.TeleportInArea)
						{
							string text6 = "";
							if (!ActiveUnit_Navigator.smethod_6(ref ((EventAction_TeleportInArea)current5).Area, ref text6, "", "Teleport In Area action '" + current5.strDescription + "'"))
							{
								if (bool_0)
								{
									string_0 = string_0 + "    " + text6 + "\r\n";
								}
								else
								{
									Interaction.MsgBox(text6 + " Contact the scenario designer to have the problem rectified.", MsgBoxStyle.OkOnly, null);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101269", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005D28 RID: 23848 RVA: 0x002B42DC File Offset: 0x002B24DC
		public List<string> FlightSizeHardLimitCheckInfo(ref Side side_0, ref Mission mission_0)
		{
			List<string> list = new List<string>();
			List<string> list2 = null;
			List<string> result;
			if (!Information.IsNothing(this) && !Information.IsNothing(mission_0))
			{
				bool flag = false;
				bool flag2 = false;
				try
				{
					Mission mission = mission_0;
					Scenario scenario = this;
					Dictionary<string, Dictionary<string, Dictionary<string, int>>> dictionary = mission.method_22(ref scenario, false, false);
					Dictionary<string, Dictionary<string, Dictionary<string, int>>> dictionary2;
					Dictionary<string, Dictionary<string, Dictionary<string, int>>> dictionary3;
					if (mission_0.MissionClass == Mission._MissionClass.Strike && ((Strike)mission_0).Escort_FlightSize_NonShooter == Mission._FlightSize.None)
					{
						Mission mission2 = mission_0;
						scenario = this;
						dictionary2 = mission2.method_22(ref scenario, true, true);
						dictionary3 = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
					}
					else
					{
						Mission mission3 = mission_0;
						scenario = this;
						dictionary2 = mission3.method_22(ref scenario, true, false);
						Mission mission4 = mission_0;
						scenario = this;
						dictionary3 = mission4.method_22(ref scenario, false, true);
					}
					if (dictionary.Count > 0 || dictionary2.Count > 0 || dictionary3.Count > 0)
					{
						Mission._FlightSize flightSize = Mission._FlightSize.None;
						Mission._FlightSize flightSize2 = Mission._FlightSize.None;
						Mission._FlightSize flightSize3 = Mission._FlightSize.None;
						switch (mission_0.MissionClass)
						{
						case Mission._MissionClass.Strike:
						{
							Strike strike = (Strike)mission_0;
							flightSize = strike.m_FlightSize;
							flightSize2 = strike.Escort_FlightSize_Shooter;
							flightSize3 = strike.Escort_FlightSize_NonShooter;
							strike.GetFlightQty(ref flightSize, ref strike.MinAircraftReq_Strikers);
							strike.GetFlightQty(ref flightSize2, ref strike.MinAircraftReq_Escorts_Shooter);
							strike.GetFlightQty(ref flightSize3, ref strike.MinAircraftReq_Escorts_NonShooter);
							flag = strike.UseFlightSizeHardLimit;
							flag2 = strike.UseFlightSizeHardLimit_Escort;
							break;
						}
						case Mission._MissionClass.Patrol:
						{
							Patrol patrol = (Patrol)mission_0;
							flightSize = patrol.m_FlightSize;
							patrol.GetFlightQty(ref flightSize, ref patrol.MinAircraftReq);
							flag = patrol.UseFlightSizeHardLimit;
							break;
						}
						case Mission._MissionClass.Support:
						{
							SupportMission supportMission = (SupportMission)mission_0;
							flightSize = supportMission.m_FlightSize;
							supportMission.GetFlightQty(ref flightSize, ref supportMission.MinAircraftReq);
							flag = supportMission.UseFlightSizeHardLimit;
							break;
						}
						case Mission._MissionClass.Ferry:
						{
							FerryMission ferryMission = (FerryMission)mission_0;
							flightSize = ferryMission.m_FlightSize;
							flag = ferryMission.UseFlightSizeHardLimit;
							break;
						}
						case Mission._MissionClass.Mining:
						{
							MiningMission miningMission = (MiningMission)mission_0;
							flightSize = miningMission.m_FlightSize;
							miningMission.GetFlightQty(ref flightSize, ref miningMission.MinAircraftReq);
							flag = miningMission.UseFlightSizeHardLimit;
							break;
						}
						case Mission._MissionClass.MineClearing:
						{
							MineClearingMission mineClearingMission = (MineClearingMission)mission_0;
							flightSize = mineClearingMission.m_FlightSize;
							mineClearingMission.GetFlightQty(ref flightSize, ref mineClearingMission.MinAircraftReq);
							flag = mineClearingMission.UseFlightSizeHardLimit;
							break;
						}
						case Mission._MissionClass.Escort:
						{
							TankerMission tankerMission = (TankerMission)mission_0;
							flightSize = tankerMission.m_FlightSize;
							flag2 = tankerMission.UseFlightSizeHardLimit;
							break;
						}
						}
						if (flag)
						{
							foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, int>>> current in dictionary)
							{
								Dictionary<string, Dictionary<string, int>> value = current.Value;
								string key = current.Key;


								foreach (KeyValuePair<string, Dictionary<string, int>> current2 in value)
								{
                                    //ZSP 
                                    Dictionary<string, int> value2 = current2.Value;
									string key2 = current2.Key;
                                    

                                    foreach (KeyValuePair<string, int> current3 in value2)
                                    {
                                        string key3 = current3.Key;
                                        int value3 = current3.Value;

                                        if (value3 < (int)flightSize)
										{
											string item;
											if (Information.IsNothing(side_0))
											{
												item = string.Concat(new string[]
												{
													"Mission: ",
													mission_0.Name,
													", aircraft ",
													key2,
													", loadout ",
													key3,
													" on ship/base ",
													key,
													": Number of aircraft (",
													Conversions.ToString(value3),
													") is lower than minimum flight size (",
													Conversions.ToString((int)flightSize),
													")"
												});
											}
											else
											{
												item = string.Concat(new string[]
												{
													"Side: ",
													side_0.GetSideName(),
													", mission: ",
													mission_0.Name,
													", aircraft ",
													key2,
													", loadout ",
													key3,
													" on ship/base ",
													key,
													": Number of aircraft (",
													Conversions.ToString(value3),
													") is lower than minimum flight size (",
													Conversions.ToString((int)flightSize),
													")"
												});
											}
											list.Add(item);
										}
									}
								}
							}
						}
						if (flag2)
						{
							foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, int>>> current4 in dictionary2)
							{
								Dictionary<string, Dictionary<string, int>> value4 = current4.Value;
								string key4 = current4.Key;
								foreach (KeyValuePair<string, Dictionary<string, int>> current5 in value4)
								{
									Dictionary<string, int> value5 = current5.Value;
									string key5 = current5.Key;
									foreach (KeyValuePair<string, int> current6 in value5)
									{
										string key6 = current6.Key;
                                        //ZSP int value6 = current6.Value;
                                        int value6 = current6.Value;
                                        if (value6 < (int)flightSize2)
										{
											string item2;
											if (Information.IsNothing(side_0))
											{
												item2 = string.Concat(new string[]
												{
													"Fighter/SEAD escort on mission: ",
													mission_0.Name,
													", aircraft ",
													key5,
													", loadout ",
													key6,
													" on ship/base ",
													key4,
													": Number of aircraft (",
													Conversions.ToString(value6),
													") is lower than minimum flight size (",
													Conversions.ToString((int)flightSize2),
													")"
												});
											}
											else
											{
												item2 = string.Concat(new string[]
												{
													"Side: ",
													side_0.GetSideName(),
													", fighter/SEAD escort on mission: ",
													mission_0.Name,
													", aircraft ",
													key5,
													", loadout ",
													key6,
													" on ship/base ",
													key4,
													": Number of aircraft (",
													Conversions.ToString(value6),
													") is lower than minimum flight size (",
													Conversions.ToString((int)flightSize2),
													")"
												});
											}
											list.Add(item2);
										}
									}
								}
							}
							if (!Information.IsNothing(flightSize3))
							{
								foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, int>>> current7 in dictionary3)
								{
									Dictionary<string, Dictionary<string, int>> value7 = current7.Value;
									string key7 = current7.Key;
									foreach (KeyValuePair<string, Dictionary<string, int>> current8 in value7)
									{
										Dictionary<string, int> value8 = current8.Value;
										string key8 = current8.Key;
										foreach (KeyValuePair<string, int> current9 in value8)
										{
											string key9 = current9.Key;
                                            //ZSP int value9 = current9.Value;
                                            int value9 = current9.Value;
                                            if (value9 < (int)flightSize3)
											{
												string item3;
												if (Information.IsNothing(side_0))
												{
													item3 = string.Concat(new string[]
													{
														"Support escort on mission: ",
														mission_0.Name,
														", aircraft ",
														key8,
														", loadout ",
														key9,
														" on ship/base ",
														key7,
														": Number of aircraft (",
														Conversions.ToString(value9),
														") is lower than minimum flight size (",
														Conversions.ToString((int)flightSize3),
														")"
													});
												}
												else
												{
													item3 = string.Concat(new string[]
													{
														"Side: ",
														side_0.GetSideName(),
														", support escort on mission: ",
														mission_0.Name,
														", aircraft ",
														key8,
														", loadout ",
														key9,
														" on ship/base ",
														key7,
														": Number of aircraft (",
														Conversions.ToString(value9),
														") is lower than minimum flight size (",
														Conversions.ToString((int)flightSize3),
														")"
													});
												}
												list.Add(item3);
											}
										}
									}
								}
							}
						}
					}
					list2 = list;
					result = list2;
					return result;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101252", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
					result = list2;
					return result;
				}
			}
			list2 = list;
			result = list2;
			return result;
		}

		// Token: 0x06005D29 RID: 23849 RVA: 0x002B4D0C File Offset: 0x002B2F0C
		private void _GroundImpacts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			NotifyCollectionChangedAction arg_06_0 = e.Action;
		}

		// Token: 0x06005D2A RID: 23850 RVA: 0x000296E2 File Offset: 0x000278E2
		private void _WeaponImpacts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == NotifyCollectionChangedAction.Add)
			{
				WeaponImpact.ExportWeaponImpact((WeaponImpact)e.NewItems[0], this);
			}
		}

		// Token: 0x040030CC RID: 12492
		public static Func<UnguidedWeapon, bool> IsMineFilter = (UnguidedWeapon unguidedWeapon_0) => unguidedWeapon_0.IsMine();

		// Token: 0x040030CD RID: 12493
		public string TimelineID;

		// Token: 0x040030CE RID: 12494
		public string ParentTimelineID;

		// Token: 0x040030CF RID: 12495
		private string _ObjectID;

		// Token: 0x040030D0 RID: 12496
		public string ContentTag;

		// Token: 0x040030D1 RID: 12497
		public string CampaignID;

		// Token: 0x040030D2 RID: 12498
		public string CampaignSessionID;

		// Token: 0x040030D3 RID: 12499
		public int CampaignScore;

		// Token: 0x040030D4 RID: 12500
		public bool RunningInMonteCarloMode;

		// Token: 0x040030D5 RID: 12501
		private string _Title;

		// Token: 0x040030D6 RID: 12502
		private string _Description;

		// Token: 0x040030D7 RID: 12503
		public short Meta_Complexity;

		// Token: 0x040030D8 RID: 12504
		public short Meta_Difficulty;

		// Token: 0x040030D9 RID: 12505
		public string Meta_ScenSetting;

		// Token: 0x040030DA RID: 12506
		public string FileName;

		// Token: 0x040030DB RID: 12507
		private DateTime _Time;

		// Token: 0x040030DC RID: 12508
		internal DateTime ZeroHour;

		// Token: 0x040030DD RID: 12509
		private bool _DaylightSavingTime;

		// Token: 0x040030DE RID: 12510
		private string _DaylightSavingTime_Start;

		// Token: 0x040030DF RID: 12511
		private string _DaylightSavingTime_End;

		// Token: 0x040030E0 RID: 12512
		private DateTime? _StartTime;

		// Token: 0x040030E1 RID: 12513
		private TimeSpan? _Duration;

		// Token: 0x040030E2 RID: 12514
		private bool _HasEnded;

		// Token: 0x040030E3 RID: 12515
		[CompilerGenerated]
		private ObservableDictionary<string, ActiveUnit> _ActiveUnits;

		// Token: 0x040030E4 RID: 12516
		private List<ActiveUnit> _ActiveUnits_List;

		// Token: 0x040030E5 RID: 12517
		public GroupsCollection Groups;

		// Token: 0x040030E6 RID: 12518
		private List<Weapon> _GuidedWeaponsInAir;

		// Token: 0x040030E7 RID: 12519
		private List<Weapon> _SonobuoysInWater;

		// Token: 0x040030E8 RID: 12520
		private List<Weapon> _AllWeaponsAlive;

		// Token: 0x040030E9 RID: 12521
		private Scenario.enumTimeCompression _TimeCompression;

		// Token: 0x040030EA RID: 12522
		private float _GameResolution;

		// Token: 0x040030EB RID: 12523
		public Collection<Scenario> SnapShots;

		// Token: 0x040030EC RID: 12524
		private Side[] _Sides;

		// Token: 0x040030ED RID: 12525
		private List<ActiveUnit> _UnitAdditions;

		// Token: 0x040030EE RID: 12526
		private List<ActiveUnit> _UnitRemovals;

		// Token: 0x040030EF RID: 12527
		private List<ActiveUnit> _UnitDeletions;

		// Token: 0x040030F0 RID: 12528
		public int UnitsAutoIncrement;

		// Token: 0x040030F1 RID: 12529
		private Side _CurrentSide;

		// Token: 0x040030F2 RID: 12530
		public string GameVersion;

		// Token: 0x040030F3 RID: 12531
		public bool HighFidelityMode;

		// Token: 0x040030F4 RID: 12532
		public bool ExecutionInProgress;

		// Token: 0x040030F5 RID: 12533
		public bool SerializationInProgress;

		// Token: 0x040030F6 RID: 12534
		public float Navigation_FinegrainedThresholdDistance;

		// Token: 0x040030F7 RID: 12535
		public float Navigation_FinegrainedMaxDistance;

		// Token: 0x040030F8 RID: 12536
		public bool UserIsPlottingCourse;

		// Token: 0x040030F9 RID: 12537
		[CompilerGenerated]
		private ObservableDictionary<string, ScenAttachmentObject> _ScenAttachments;

		// Token: 0x040030FA RID: 12538
		public Queue<LoggedMessage> UnhandledPopUpMessages;

		// Token: 0x040030FB RID: 12539
		public ConcurrentDictionary<long, LoggedMessage> MessageLog;

		// Token: 0x040030FC RID: 12540
		private long _MessageIncrement;

		// Token: 0x040030FD RID: 12541
		private string _DBUsed;

		// Token: 0x040030FE RID: 12542
		private SQLiteConnection _DBConnection;

		// Token: 0x040030FF RID: 12543
		public bool LoadStockUnits;

		// Token: 0x04003100 RID: 12544
		private List<ActiveUnit> _OperativeUnits;

		// Token: 0x04003101 RID: 12545
		private List<ActiveUnit> _NonoperativeUnits;

		// Token: 0x04003102 RID: 12546
		internal HashSet<XmlNode> UnitsForLateInstantiation;

		// Token: 0x04003103 RID: 12547
		public bool SecondIsChangingOnThisPulse;

		// Token: 0x04003104 RID: 12548
		public bool FifthSecondIsChangingOnThisPulse;

		// Token: 0x04003105 RID: 12549
		public bool FifteenthSecondIsChangingOnThisPulse;

		// Token: 0x04003106 RID: 12550
		public bool ThirtiethSecondIsChangingOnThisPulse;

		// Token: 0x04003107 RID: 12551
		public bool MinuteIsChangingOnThisPulse;

		// Token: 0x04003108 RID: 12552
		public bool FifthMinuteIsChangingOnThisPulse;

		// Token: 0x04003109 RID: 12553
		public bool FifteenthMinuteIsChangingOnThisPulse;

		// Token: 0x0400310A RID: 12554
		public bool ThirtiethMinuteIsChangingOnThisPulse;

		// Token: 0x0400310B RID: 12555
		public bool HourIsChangingOnThisPulse;

		// Token: 0x0400310C RID: 12556
		internal List<ActiveUnit> Cache_FacilitiesWithPiers;

		// Token: 0x0400310D RID: 12557
		public ConcurrentDictionary<int, Weapon> Cache_Weapons;

		// Token: 0x0400310E RID: 12558
		internal ConcurrentDictionary<int, ConcurrentDictionary<int, bool>> Cache_SensorCompatibleFrequencies;

		// Token: 0x0400310F RID: 12559
		internal ConcurrentDictionary<string, List<XSection>> Cache_XSections;

		// Token: 0x04003110 RID: 12560
		public DataTable Cache_Aircraft_DT;

		// Token: 0x04003111 RID: 12561
		public DataTable Cache_Ships_DT;

		// Token: 0x04003112 RID: 12562
		public DataTable Cache_Subs_DT;

		// Token: 0x04003113 RID: 12563
		public DataTable Cache_Facilities_DT;

		// Token: 0x04003114 RID: 12564
		public DataTable Cache_Satellites_DT;

		// Token: 0x04003115 RID: 12565
		public DataTable Cache_Weapons_DT;

		// Token: 0x04003116 RID: 12566
		public DataTable Cache_OperatorCountries_DT;

		// Token: 0x04003117 RID: 12567
		internal ConcurrentDictionary<int, int> Cache_FuelForPitchEnabledWeapons;

		// Token: 0x04003118 RID: 12568
		internal ActiveUnit[] CandidatesForDetectionByMines;

		// Token: 0x04003119 RID: 12569
		public List<string> LoadingNotices;

		// Token: 0x0400311A RID: 12570
		internal bool ThreadedOpsMustStop;

		// Token: 0x0400311B RID: 12571
		public HashSet<Scenario.ScenarioFeatureOption> DeclaredFeatures;

		// Token: 0x0400311C RID: 12572
		public bool LastSavedInScenEdit;

		// Token: 0x0400311D RID: 12573
		public Scenario._FeatureCompatibility FeatureCompatibility;

		// Token: 0x0400311E RID: 12574
		public int? MaxRisingMineRange_meters;

		// Token: 0x0400311F RID: 12575
		private LuaSandBox _LuaSandbox;

		// Token: 0x04003120 RID: 12576
		public Scenario.WeatherModellingLevel WeatherLevel;

		// Token: 0x04003121 RID: 12577
		private Weather.WeatherProfile _GlobalWeather;

		// Token: 0x04003122 RID: 12578
		public List<string> MissionPlannerErrorList;

		// Token: 0x04003123 RID: 12579
		[CompilerGenerated]
		private ObservableDictionary<string, EventTrigger> _EventTriggers;

		// Token: 0x04003124 RID: 12580
		[CompilerGenerated]
		private ObservableDictionary<string, EventCondition> _EventConditions;

		// Token: 0x04003125 RID: 12581
		[CompilerGenerated]
		private ObservableDictionary<string, EventAction> _EventActions;

		// Token: 0x04003126 RID: 12582
		[CompilerGenerated]
		private ObservableDictionary<string, SimEvent> _SimEvents;

		// Token: 0x04003127 RID: 12583
		[CompilerGenerated]
		private ObservableCollection<Explosion> _Explosions;

		// Token: 0x04003128 RID: 12584
		[CompilerGenerated]
		private ObservableCollection<WeaponImpact> _WeaponImpacts;

		// Token: 0x04003129 RID: 12585
		[CompilerGenerated]
		private ObservableCollection<WaterSplash> _WaterSplashes;

		// Token: 0x0400312A RID: 12586
		[CompilerGenerated]
		private ObservableCollection<GroundImpact> _GroundImpacts;

		// Token: 0x0400312B RID: 12587
		[CompilerGenerated]
		private ObservableDictionary<string, UnguidedWeapon> _UnguidedWeapons;

		// Token: 0x0400312C RID: 12588
		public List<UnguidedWeapon> Mines;

		// Token: 0x0400312D RID: 12589
		[CompilerGenerated]
		private static Scenario.TitleChangedEventHandler TitleChangedEvent;

		// Token: 0x0400312E RID: 12590
		[CompilerGenerated]
		private static Scenario.CurrentSideChangedEventHandler CurrentSideChangedEvent;

		// Token: 0x0400312F RID: 12591
		[CompilerGenerated]
		private static Scenario.SidesChangedEventHandler SidesChangedEvent;

		// Token: 0x04003130 RID: 12592
		[CompilerGenerated]
		private static Scenario.TimeCompressionChangedEventHandler TimeCompressionChangedEvent;

		// Token: 0x04003131 RID: 12593
		[CompilerGenerated]
		private static Scenario.TimeChangedManuallyEventHandler TimeChangedManuallyEvent;

		// Token: 0x04003132 RID: 12594
		[CompilerGenerated]
		private static Scenario.NewMessageEventHandler NewMessageEvent;

		// Token: 0x04003133 RID: 12595
		[CompilerGenerated]
		private static Scenario.UnitAddedEventHandler UnitAddedEvent;

		// Token: 0x04003134 RID: 12596
		[CompilerGenerated]
		private static Scenario.UnitRemovedEventHandler UnitRemovedEvent;

		// Token: 0x04003135 RID: 12597
		[CompilerGenerated]
		private static Scenario.EventTriggersChangedEventHandler EventTriggersChangedEvent;

		// Token: 0x04003136 RID: 12598
		[CompilerGenerated]
		private static Scenario.EventConditionsChangedEventHandler EventConditionsChangedEvent;

		// Token: 0x04003137 RID: 12599
		[CompilerGenerated]
		private static Scenario.EventActionsChangedEventHandler EventActionsChangedEvent;

		// Token: 0x04003138 RID: 12600
		[CompilerGenerated]
		private static Scenario.ScenAttachmentsChangedEventHandler ScenAttachmentsChangedEvent;

		// Token: 0x04003139 RID: 12601
		[CompilerGenerated]
		private static Scenario.ScenCompletedEventHandler ScenCompletedEvent;

		// Token: 0x0400313A RID: 12602
		public string LuaXml;

		// Token: 0x0400313B RID: 12603
		private object LockObject1;

		// Token: 0x0400313C RID: 12604
		private object LockObject2;

		// Token: 0x02000B3E RID: 2878
		// (Invoke) Token: 0x06005D2E RID: 23854
		public delegate void TitleChangedEventHandler(Scenario theScen, string NewTitle);

		// Token: 0x02000B3F RID: 2879
		// (Invoke) Token: 0x06005D32 RID: 23858
		public delegate void CurrentSideChangedEventHandler(Scenario theScen);

		// Token: 0x02000B40 RID: 2880
		// (Invoke) Token: 0x06005D36 RID: 23862
		public delegate void SidesChangedEventHandler(Scenario theScen, Scenario._SideChange AddOrRemove);

		// Token: 0x02000B41 RID: 2881
		// (Invoke) Token: 0x06005D3A RID: 23866
		public delegate void TimeCompressionChangedEventHandler();

		// Token: 0x02000B42 RID: 2882
		// (Invoke) Token: 0x06005D3E RID: 23870
		public delegate void TimeChangedManuallyEventHandler(Scenario theScen, DateTime NewTime);

		// Token: 0x02000B43 RID: 2883
		// (Invoke) Token: 0x06005D42 RID: 23874
		public delegate void NewMessageEventHandler(LoggedMessage theM);

		// Token: 0x02000B44 RID: 2884
		// (Invoke) Token: 0x06005D46 RID: 23878
		public delegate void UnitAddedEventHandler(Scenario theScen, ActiveUnit theUnit);

		// Token: 0x02000B45 RID: 2885
		// (Invoke) Token: 0x06005D4A RID: 23882
		public delegate void UnitRemovedEventHandler(Scenario theScen, ActiveUnit theUnit);

		// Token: 0x02000B46 RID: 2886
		// (Invoke) Token: 0x06005D4E RID: 23886
		public delegate void EventTriggersChangedEventHandler(Scenario theScen);

		// Token: 0x02000B47 RID: 2887
		// (Invoke) Token: 0x06005D52 RID: 23890
		public delegate void EventConditionsChangedEventHandler(Scenario theScen);

		// Token: 0x02000B48 RID: 2888
		// (Invoke) Token: 0x06005D56 RID: 23894
		public delegate void EventActionsChangedEventHandler(Scenario theScen);

		// Token: 0x02000B49 RID: 2889
		// (Invoke) Token: 0x06005D5A RID: 23898
		public delegate void ScenAttachmentsChangedEventHandler();

		// Token: 0x02000B4A RID: 2890
		// (Invoke) Token: 0x06005D5E RID: 23902
		public delegate void ScenCompletedEventHandler(Scenario theScen);

		// Token: 0x02000B4B RID: 2891
		public enum enumTimeCompression : byte
		{
			// Token: 0x0400313F RID: 12607
			OneSec,
			// Token: 0x04003140 RID: 12608
			TwoSec,
			// Token: 0x04003141 RID: 12609
			FiveSec,
			// Token: 0x04003142 RID: 12610
			FifteenSec,
			// Token: 0x04003143 RID: 12611
			ThirtySec,
			// Token: 0x04003144 RID: 12612
			OneMin,
			// Token: 0x04003145 RID: 12613
			FiveMin,
			// Token: 0x04003146 RID: 12614
			FifteenMin,
			// Token: 0x04003147 RID: 12615
			ThirtyMin
		}

		// Token: 0x02000B4C RID: 2892
		public enum ScenarioFeatureOption
		{
			// Token: 0x04003149 RID: 12617
			const_0,
			// Token: 0x0400314A RID: 12618
			DetailedGunFireControl,
			// Token: 0x0400314B RID: 12619
			Realism_UnlimitedBaseMags,
			// Token: 0x0400314C RID: 12620
			AircraftDamageModel,
			// Token: 0x0400314D RID: 12621
			CargoOps,
			// Token: 0x0400314E RID: 12622
			CommsJamming,
			// Token: 0x0400314F RID: 12623
			CommsDisruption,
			// Token: 0x04003150 RID: 12624
			EMP_Omni,
			// Token: 0x04003151 RID: 12625
			EMP_Dir,
			// Token: 0x04003152 RID: 12626
			HighEnergyLasers,
			// Token: 0x04003153 RID: 12627
			RailgunOrHVP,
			// Token: 0x04003154 RID: 12628
			HGV
		}

		// Token: 0x02000B4D RID: 2893
		public enum _SideChange : byte
		{
			// Token: 0x04003156 RID: 12630
			AddSide,
			// Token: 0x04003157 RID: 12631
			RemoveSide
		}

		// 气象模型级别
		public enum WeatherModellingLevel : byte
		{
			// Token: 0x04003159 RID: 12633
			Level0,
			// Token: 0x0400315A RID: 12634
			Level1
		}

		// Token: 0x02000B4F RID: 2895
		public struct _FeatureCompatibility
		{
			// Token: 0x17000481 RID: 1153
			// (get) Token: 0x06005D61 RID: 23905 RVA: 0x00029735 File Offset: 0x00027935
			public bool get_CarrierCapableFlag(SQLiteConnection sqliteConnection_0)
			{
				
				{
					if (!this._CarrierCapableFlag.HasValue)
					{
						this._CarrierCapableFlag = new bool?(DBFunctions.smethod_100(1, sqliteConnection_0));
					}
					return this._CarrierCapableFlag.Value;
				}
			}

			// Token: 0x17000482 RID: 1154
			// (get) Token: 0x06005D62 RID: 23906 RVA: 0x00029761 File Offset: 0x00027961
			public bool get_WRA(SQLiteConnection sqliteConnection_0)
            {
				//get
				{
					if (!this._WRA.HasValue)
					{
						this._WRA = new bool?(DBFunctions.smethod_100(2, sqliteConnection_0));
					}
					return this._WRA.Value;
				}
			}

			// Token: 0x17000483 RID: 1155
			// (get) Token: 0x06005D63 RID: 23907 RVA: 0x0002978D File Offset: 0x0002798D
			public bool get_LPI_Radars(SQLiteConnection sqliteConnection_0)
            {
				//get
				{
					if (!this._LPI_Radars.HasValue)
					{
						this._LPI_Radars = new bool?(DBFunctions.smethod_100(3, sqliteConnection_0));
					}
					return this._LPI_Radars.Value;
				}
			}

			// Token: 0x17000484 RID: 1156
			// (get) Token: 0x06005D64 RID: 23908 RVA: 0x000297B9 File Offset: 0x000279B9
			public bool get_WeaponSnapUpDown(SQLiteConnection sqliteConnection_0)
            {
				//get
				{
					if (!this._WeaponSnapUpDown.HasValue)
					{
						this._WeaponSnapUpDown = new bool?(DBFunctions.smethod_100(4, sqliteConnection_0));
					}
					return this._WeaponSnapUpDown.Value;
				}
			}

			// Token: 0x17000485 RID: 1157
			// (get) Token: 0x06005D65 RID: 23909 RVA: 0x000297E5 File Offset: 0x000279E5
			public bool get_WeaponAGL_ASL(SQLiteConnection sqliteConnection_0)
            {
				//get
				{
					if (!this._WeaponAGL_ASL.HasValue)
					{
						this._WeaponAGL_ASL = new bool?(DBFunctions.smethod_100(5, sqliteConnection_0));
					}
					return this._WeaponAGL_ASL.Value;
				}
			}

			// Token: 0x1700047F RID: 1151
			// (get) Token: 0x06005D66 RID: 23910 RVA: 0x000081A2 File Offset: 0x000063A2
			public bool GuidedWeaponsPitchAttitude
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000480 RID: 1152
			// (get) Token: 0x06005D67 RID: 23911 RVA: 0x00029811 File Offset: 0x00027A11
			// (set) Token: 0x06005D68 RID: 23912 RVA: 0x00029819 File Offset: 0x00027A19
			public bool CockpitVisibility
			{
				get;
				set;
			}

			// Token: 0x0400315B RID: 12635
			private bool? _Hypotheticals;

			// Token: 0x0400315C RID: 12636
			private bool? _CarrierCapableFlag;

			// Token: 0x0400315D RID: 12637
			private bool? _WRA;

			// Token: 0x0400315E RID: 12638
			private bool? _LPI_Radars;

			// Token: 0x0400315F RID: 12639
			private bool? _WeaponSnapUpDown;

			// Token: 0x04003160 RID: 12640
			private bool? _WeaponAGL_ASL;

			// Token: 0x04003161 RID: 12641
			private bool? _GuidedWeaponsPitchAttitude;

			// Token: 0x04003162 RID: 12642
			[CompilerGenerated]
			private bool _CockpitVisibility;
		}
	}
}
