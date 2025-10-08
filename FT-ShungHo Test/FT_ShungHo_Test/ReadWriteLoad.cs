using System;

namespace FT_ShungHo_Test
{
	// Token: 0x0200000B RID: 11
	public class ReadWriteLoad
	{
		// Token: 0x04000128 RID: 296
		public static string clearErrorCommand = "*CLS";

		// Token: 0x04000129 RID: 297
		public static string errorLoadCommand = "SYSTem:ERRor?";

		// Token: 0x0400012A RID: 298
		public static string systemRemoteCommand = "SYSTem:REM";

		// Token: 0x0400012B RID: 299
		public static string systemLocalCommand = "SYST:LOC";

		// Token: 0x0400012C RID: 300
		public static string inputOFFCommand = "INPUT 0";

		// Token: 0x0400012D RID: 301
		public static string inputONCommand = "INPUT 1";

		// Token: 0x0400012E RID: 302
		public static string measureCurrentCommand = "MEAS:CURR?";

		// Token: 0x0400012F RID: 303
		public static string measurePowerInputCommand = "MEAS:POW?";

		// Token: 0x04000130 RID: 304
		public static string measureVoltCommand = "MEAS:VOLT?";

		// Token: 0x04000131 RID: 305
		public static string modeCCCommand = "MODE CURR";

		// Token: 0x04000132 RID: 306
		public static string modeCRCommand = "MODE RES";

		// Token: 0x04000133 RID: 307
		public static string modeCVCommand = "MODE VOLT";

		// Token: 0x04000134 RID: 308
		public static string modeCWCommand = "MODE POW";

		// Token: 0x04000135 RID: 309
		public static string modeCheckCommand = "MODE?";

		// Token: 0x04000136 RID: 310
		public static double currentValueCommand = 2.2;

		// Token: 0x04000137 RID: 311
		public static string currentCommand = "CURR ";

		// Token: 0x04000138 RID: 312
		public static double resValueCommand = 0.48;

		// Token: 0x04000139 RID: 313
		public static string resCommand = "RES ";

		// Token: 0x0400013A RID: 314
		public static double voltValueCommand = 24.0;

		// Token: 0x0400013B RID: 315
		public static string voltCommand = "VOLT ";

		// Token: 0x0400013C RID: 316
		public static double powerValueCommand = 100.0;

		// Token: 0x0400013D RID: 317
		public static string powerCommand = "POW ";

		// Token: 0x0400013E RID: 318
		public static double OCPCurrentValueCommand = 3.9;

		// Token: 0x0400013F RID: 319
		public static double OCPTimeVauecommand = 0.5;

		// Token: 0x04000140 RID: 320
		public static string OCPEnableCommand = "OCP ON";

		// Token: 0x04000141 RID: 321
		public static string OCPDisableCommand = "OCP OFF";

		// Token: 0x04000142 RID: 322
		public static string SenseModeOnCommand = "SYST:SENS ON";

		// Token: 0x04000143 RID: 323
		public static string SenseModeOffCommand = "SYST:SENS OFF";
	}
}
