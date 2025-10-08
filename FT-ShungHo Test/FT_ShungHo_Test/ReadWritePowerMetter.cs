using System;

namespace FT_ShungHo_Test
{
	// Token: 0x0200000C RID: 12
	public class ReadWritePowerMetter
	{
		// Token: 0x04000144 RID: 324
		public static string setRemoteCommand = "COMMUNICATE:REMOTE ON";

		// Token: 0x04000145 RID: 325
		public static string getRemoteCommand = "COMMunicate:REMote?";

		// Token: 0x04000146 RID: 326
		public static string getValueMeasureCommand = "MEASURE:NORMAL:VALUE?";

		// Token: 0x04000147 RID: 327
		public static string settingDisplay1functionV = "DISPLAY1:FUNCTION V";

		// Token: 0x04000148 RID: 328
		public static string settingDisplay2functionA = "DISPLAY2:FUNCTION A";

		// Token: 0x04000149 RID: 329
		public static string settingDisplay3functionW = "DISPLAY3:FUNCTION W";

		// Token: 0x0400014A RID: 330
		public static string startCheckCommand = ":INTEGrate:STARt";

		// Token: 0x0400014B RID: 331
		public static string stopCheckCommand = ":INTEGrate:STOP";

		// Token: 0x0400014C RID: 332
		public static string resetCommand = "INTEGRATE:RESet";

		// Token: 0x0400014D RID: 333
		public static double CurrentRange = 2.0;

		// Token: 0x0400014E RID: 334
		public static double VoltageRange = 300.0;

		// Token: 0x0400014F RID: 335
		public static string currentRangeCommand = "CURRent:RANGe ";

		// Token: 0x04000150 RID: 336
		public static string voltageRangeCommand = "VOLTage:RANGe ";
	}
}
