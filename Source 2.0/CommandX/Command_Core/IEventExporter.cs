using System;
using System.Collections.Generic;

namespace Command_Core
{
	// Token: 0x02000BBB RID: 3003
	public interface IEventExporter
	{
		// Token: 0x0600635E RID: 25438
		string GetExporterName();

		// Token: 0x0600635F RID: 25439
		int GetEventQueueLength();

		// Token: 0x06006360 RID: 25440
		string GetExportDirectory();

		// Token: 0x06006361 RID: 25441
		void SetExportDirectory(string string_0);

		// Token: 0x06006362 RID: 25442
		_ExporterType GetExporterType();

		// Token: 0x06006363 RID: 25443
		_RunMode GetRunMode();

		// Token: 0x06006364 RID: 25444
		void SetRunMode(_RunMode enum100_0);

		// Token: 0x06006365 RID: 25445
		void ExportEvent(ExportedEventType exportedEventType_0, Dictionary<string, Tuple<Type, string>> dictionary_0, Scenario scenario_0);

		// Token: 0x06006366 RID: 25446
		void StartExport();

		// Token: 0x06006367 RID: 25447
		void StopExport();

		// Token: 0x06006368 RID: 25448
		bool IsUseZeroHour();

		// Token: 0x06006369 RID: 25449
		void SetUseZeroHour(bool bool_0);

		// Token: 0x0600636A RID: 25450
		bool IsExportSensorDetectionSuccess();

		// Token: 0x0600636B RID: 25451
		void SetExportSensorDetectionSuccess(bool bool_0);

		// Token: 0x0600636C RID: 25452
		bool IsExportSensorDetectionFailure();

		// Token: 0x0600636D RID: 25453
		void SetExportSensorDetectionFailure(bool bool_0);

		// Token: 0x0600636E RID: 25454
		bool IsExportWeaponFired();

		// Token: 0x0600636F RID: 25455
		void SetExportWeaponFired(bool bool_0);

		// Token: 0x06006370 RID: 25456
		bool IsExportWeaponEndgame();

		// Token: 0x06006371 RID: 25457
		void SetExportWeaponEndgame(bool bool_0);

		// Token: 0x06006372 RID: 25458
		bool IsExportUnitPositions();

		// Token: 0x06006373 RID: 25459
		void SetExportUnitPositions(bool bool_0);

		// Token: 0x06006374 RID: 25460
		bool IsExportEngagementCycle();

		// Token: 0x06006375 RID: 25461
		void SetExportEngagementCycle(bool bool_0);

		// Token: 0x06006376 RID: 25462
		bool imethod_24();

		// Token: 0x06006377 RID: 25463
		void imethod_25(bool bool_0);

		// Token: 0x06006378 RID: 25464
		bool IsExportFuelConsumed();

		// Token: 0x06006379 RID: 25465
		void SetExportFuelConsumed(bool bool_0);

		// Token: 0x0600637A RID: 25466
		bool IsExportFuelTransfer();

		// Token: 0x0600637B RID: 25467
		void SetExportFuelTransfer(bool bool_0);

		// Token: 0x0600637C RID: 25468
		bool imethod_30();
	}
}
