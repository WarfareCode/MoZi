using System;

namespace Command_Core
{
	// Token: 导出文件类型
	public enum _ExporterType
	{
		// Token: 0x04003645 RID: 13893
		Unknown,
		// Token: XML文件
		XMLFile,
		// CSV文件
		CSVFile,
		// Access数据库
		MSAccess,
		// Tecview三维
		Tacview1x,
        // Tecview三维
        Tacview2x
    }
}
