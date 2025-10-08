using System;

namespace FT_ShungHo_Test
{
	// Token: 0x0200000A RID: 10
	public class ReadWriteACSource
	{
		// Token: 0x04000120 RID: 288
		public static double voltageSetCommand = 200.0;

		// Token: 0x04000121 RID: 289
		public static double freqSetCommand = 50.0;

		// Token: 0x04000122 RID: 290
		public static string outputOnCommand = "PON";

		// Token: 0x04000123 RID: 291
		public static string outputOffCommand = "POFF";

		// Token: 0x04000124 RID: 292
		public static string voltageOutputCommand = "SVOL ";

		// Token: 0x04000125 RID: 293
		public static string freqRangeCommand = "SFRE ";

		// Token: 0x04000126 RID: 294
		public static string queryVoltSetCommand = "?SVOL";

		// Token: 0x04000127 RID: 295
		public static string queryFreqSetCommand = "?SFRE";
	}
}
