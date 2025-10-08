using System;
using System.IO;
using System.Windows.Forms;

namespace FT_ShungHo_Test
{
	// Token: 0x0200000E RID: 14
	public class VariableCommon
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00017BE8 File Offset: 0x00015DE8
		public static int CounterlineTextFile(string File_Path)
		{
			int num = 0;
			bool flag = File.Exists(File_Path);
			if (flag)
			{
				StreamReader streamReader = new StreamReader(File_Path);
				while (streamReader.ReadLine() != null)
				{
					num++;
				}
				streamReader.Close();
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00017C34 File Offset: 0x00015E34
		public static string ReadTextFile(string filePath, int lineNumber)
		{
			string result;
			using (StreamReader streamReader = new StreamReader(filePath))
			{
				for (int i = 1; i <= lineNumber - 1; i++)
				{
					bool flag = streamReader.ReadLine() == null;
				}
				string text = streamReader.ReadLine();
				streamReader.Close();
				result = text;
			}
			return result;
		}

		// Token: 0x0400017C RID: 380
		public static double powerSpec = 0.0;

		// Token: 0x0400017D RID: 381
		public static double ocpSpec = 0.0;

		// Token: 0x0400017E RID: 382
		public static double offsetPower = 0.0;

		// Token: 0x0400017F RID: 383
		public static double lowResValue1 = 0.0;

		// Token: 0x04000180 RID: 384
		public static double normalResValue1 = 0.0;

		// Token: 0x04000181 RID: 385
		public static double highResValue1 = 0.0;

		// Token: 0x04000182 RID: 386
		public static double lowCurValue1 = 0.0;

		// Token: 0x04000183 RID: 387
		public static double normalCurValue1 = 0.0;

		// Token: 0x04000184 RID: 388
		public static double highCurValue1 = 0.0;

		// Token: 0x04000185 RID: 389
		public static double lowVoltValue1 = 0.0;

		// Token: 0x04000186 RID: 390
		public static double normalVoltValue1 = 0.0;

		// Token: 0x04000187 RID: 391
		public static double highVoltValue1 = 0.0;

		// Token: 0x04000188 RID: 392
		public static double lowResValue2 = 0.0;

		// Token: 0x04000189 RID: 393
		public static double normalResValue2 = 0.0;

		// Token: 0x0400018A RID: 394
		public static double highResValue2 = 0.0;

		// Token: 0x0400018B RID: 395
		public static double lowCurValue2 = 0.0;

		// Token: 0x0400018C RID: 396
		public static double normalCurValue2 = 0.0;

		// Token: 0x0400018D RID: 397
		public static double highCurValue2 = 0.0;

		// Token: 0x0400018E RID: 398
		public static double lowVoltValue2 = 0.0;

		// Token: 0x0400018F RID: 399
		public static double normalVoltValue2 = 0.0;

		// Token: 0x04000190 RID: 400
		public static double highVoltValue2 = 0.0;

		// Token: 0x04000191 RID: 401
		public static double lowResValue3 = 0.0;

		// Token: 0x04000192 RID: 402
		public static double normalResValue3 = 0.0;

		// Token: 0x04000193 RID: 403
		public static double normalResValue4 = 0.0;

		// Token: 0x04000194 RID: 404
		public static double highResValue3 = 0.0;

		// Token: 0x04000195 RID: 405
		public static double lowCurValue3 = 0.0;

		// Token: 0x04000196 RID: 406
		public static double normalCurValue3 = 0.0;

		// Token: 0x04000197 RID: 407
		public static double normalCurValue4 = 0.0;

		// Token: 0x04000198 RID: 408
		public static double highCurValue3 = 0.0;

		// Token: 0x04000199 RID: 409
		public static double lowVoltValue3 = 0.0;

		// Token: 0x0400019A RID: 410
		public static double normalVoltValue3 = 0.0;

		// Token: 0x0400019B RID: 411
		public static double normalVoltValue4 = 0.0;

		// Token: 0x0400019C RID: 412
		public static double highVoltValue3 = 0.0;

		// Token: 0x0400019D RID: 413
		public static int presentMode = 0;

		// Token: 0x0400019E RID: 414
		public static double lowValuePer = 0.0;

		// Token: 0x0400019F RID: 415
		public static double highValuePer = 0.0;

		// Token: 0x040001A0 RID: 416
		public static double normalValuePer = 0.0;

		// Token: 0x040001A1 RID: 417
		public static string passratePath = Application.StartupPath + "\\passrate";

		// Token: 0x040001A2 RID: 418
		public static string reportPath = Application.StartupPath + "\\Report";

		// Token: 0x040001A3 RID: 419
		public static int status1 = 0;

		// Token: 0x040001A4 RID: 420
		public static int status2 = 0;

		// Token: 0x040001A5 RID: 421
		public static string complcsave = null;

		// Token: 0x040001A6 RID: 422
		public static string comload1save = null;

		// Token: 0x040001A7 RID: 423
		public static string comload2save = null;

		// Token: 0x040001A8 RID: 424
		public static string comPowerMeter1save = null;

		// Token: 0x040001A9 RID: 425
		public static string comPowerMeter2save = null;

		// Token: 0x040001AA RID: 426
		public static string comACSource1save = null;

		// Token: 0x040001AB RID: 427
		public static string comACSource2save = null;

		// Token: 0x040001AC RID: 428
		public static string plcAdress = null;

		// Token: 0x040001AD RID: 429
		public static string load1Adress = null;

		// Token: 0x040001AE RID: 430
		public static string load2Adress = null;

		// Token: 0x040001AF RID: 431
		public static string powerMeter1Adress = null;

		// Token: 0x040001B0 RID: 432
		public static string powerMeter2Adress = null;

		// Token: 0x040001B1 RID: 433
		public static string acSource1Adress = null;

		// Token: 0x040001B2 RID: 434
		public static string acSource2Adress = null;

		// Token: 0x040001B3 RID: 435
		public static string stCurrentDir = "";

		// Token: 0x040001B4 RID: 436
		public static string configPath;

		// Token: 0x040001B5 RID: 437
		public static string configFile = "SystemSetting.xml";

		// Token: 0x040001B6 RID: 438
		public static string programPath = Application.StartupPath + "\\program";

		// Token: 0x040001B7 RID: 439
		public static string progarmFile = "ProgramFile.csv";

		// Token: 0x040001B8 RID: 440
		public static string defaultsProgramFile = "EP200W-12V3.csv";

		// Token: 0x040001B9 RID: 441
		public static string configFilePass = "pw.org";

		// Token: 0x040001BA RID: 442
		public static string configFileProgram = "Program.ini";

		// Token: 0x040001BB RID: 443
		public static string pathFileTestSelect;

		// Token: 0x040001BC RID: 444
		public static string pathLog;

		// Token: 0x040001BD RID: 445
		public static bool comPlcOk1 = false;

		// Token: 0x040001BE RID: 446
		public static bool coml1OK = false;

		// Token: 0x040001BF RID: 447
		public static bool coml2OK = false;

		// Token: 0x040001C0 RID: 448
		public static bool compw1OK = false;

		// Token: 0x040001C1 RID: 449
		public static bool compw2OK = false;

		// Token: 0x040001C2 RID: 450
		public static bool comac1OK = false;

		// Token: 0x040001C3 RID: 451
		public static bool comac2OK = false;

		// Token: 0x040001C4 RID: 452
		public static bool bitSavePass = false;

		// Token: 0x040001C5 RID: 453
		public static bool bitSaveFail = false;

		// Token: 0x040001C6 RID: 454
		public static bool startbit = false;

		// Token: 0x040001C7 RID: 455
		public static bool startTest = false;

		// Token: 0x040001C8 RID: 456
		public static int noTotal = 0;

		// Token: 0x040001C9 RID: 457
		public static int noPass = 0;

		// Token: 0x040001CA RID: 458
		public static int noFail = 0;

		// Token: 0x040001CB RID: 459
		public static int[] datachart = new int[]
		{
			VariableCommon.noPass,
			VariableCommon.noFail
		};

		// Token: 0x040001CC RID: 460
		public static string timeSwPcb;

		// Token: 0x040001CD RID: 461
		public static double LOAD1VALUEMAX;

		// Token: 0x040001CE RID: 462
		public static double LOAD2VALUEMAX;

		// Token: 0x040001CF RID: 463
		public static double LOAD1VALUEMIN;

		// Token: 0x040001D0 RID: 464
		public static double LOAD2VALUEMIN;

		// Token: 0x040001D1 RID: 465
		public static double PW1VALUEMAX;

		// Token: 0x040001D2 RID: 466
		public static double PW2VALUEMAX;

		// Token: 0x040001D3 RID: 467
		public static double PW1VALUEMIN;

		// Token: 0x040001D4 RID: 468
		public static double PW2VALUEMIN;

		// Token: 0x040001D5 RID: 469
		public static int ACVOLTSETTING11 = 180;

		// Token: 0x040001D6 RID: 470
		public static int ACVOLTSETTING12 = 220;

		// Token: 0x040001D7 RID: 471
		public static int ACVOLTSETTING13 = 240;

		// Token: 0x040001D8 RID: 472
		public static int ACVOLTSETTING21 = 180;

		// Token: 0x040001D9 RID: 473
		public static int ACVOLTSETTING22 = 200;

		// Token: 0x040001DA RID: 474
		public static int ACVOLTSETTING23 = 220;

		// Token: 0x040001DB RID: 475
		public static int ACVOLTSETTING24 = 240;

		// Token: 0x040001DC RID: 476
		public static int ACVOLTSETTING31 = 180;

		// Token: 0x040001DD RID: 477
		public static int ACVOLTSETTING32 = 220;

		// Token: 0x040001DE RID: 478
		public static int ACVOLTSETTING33 = 240;

		// Token: 0x040001DF RID: 479
		public static string EPCODE = "8811700200";

		// Token: 0x040001E0 RID: 480
		public static string TEMPLATENAME = "OMS-EP200F-12V-CV";

		// Token: 0x040001E1 RID: 481
		public static double CCMODEVALUE = 16.6;

		// Token: 0x040001E2 RID: 482
		public static double CRMODEVALUE50 = 1.45;

		// Token: 0x040001E3 RID: 483
		public static double CRMODEVALUE100 = 0.72;

		// Token: 0x040001E4 RID: 484
		public static double STEP11MIN = 11.4;

		// Token: 0x040001E5 RID: 485
		public static double STEP11MAX = 13.5;

		// Token: 0x040001E6 RID: 486
		public static double STEP12MIN = 11.4;

		// Token: 0x040001E7 RID: 487
		public static double STEP12MAX = 13.5;

		// Token: 0x040001E8 RID: 488
		public static double STEP13MIN = 11.4;

		// Token: 0x040001E9 RID: 489
		public static double STEP13MAX = 14.0;

		// Token: 0x040001EA RID: 490
		public static double STEP21MIN = 11.4;

		// Token: 0x040001EB RID: 491
		public static double STEP21MAX = 12.6;

		// Token: 0x040001EC RID: 492
		public static double STEP22MIN = 11.4;

		// Token: 0x040001ED RID: 493
		public static double STEP22MAX = 12.6;

		// Token: 0x040001EE RID: 494
		public static double STEP23MIN = 11.4;

		// Token: 0x040001EF RID: 495
		public static double STEP23MAX = 12.6;

		// Token: 0x040001F0 RID: 496
		public static double STEP24MIN = 11.4;

		// Token: 0x040001F1 RID: 497
		public static double STEP24MAX = 12.6;

		// Token: 0x040001F2 RID: 498
		public static double STEP31MIN = 11.4;

		// Token: 0x040001F3 RID: 499
		public static double STEP31MAX = 12.6;

		// Token: 0x040001F4 RID: 500
		public static double STEP32MIN = 11.4;

		// Token: 0x040001F5 RID: 501
		public static double STEP32MAX = 12.6;

		// Token: 0x040001F6 RID: 502
		public static double STEP33MIN = 11.4;

		// Token: 0x040001F7 RID: 503
		public static double STEP33MAX = 12.6;

		// Token: 0x040001F8 RID: 504
		public static double POWERVALUE = 217.0;

		// Token: 0x040001F9 RID: 505
		public static double OCPVALUE = 21.6;

		// Token: 0x040001FA RID: 506
		public static double DIFFERENCEVALUEPOWER = 10.0;

		// Token: 0x040001FB RID: 507
		public static bool OCPENABLE = true;

		// Token: 0x040001FC RID: 508
		public static int ACFREQSETTING1 = 50;

		// Token: 0x040001FD RID: 509
		public static int ACFREQSETTING2 = 50;

		// Token: 0x040001FE RID: 510
		public static double[] offsetmeasureValue = new double[10];

		// Token: 0x040001FF RID: 511
		public static string[] parameterSetupLoad;

		// Token: 0x04000200 RID: 512
		public static string[] parameterSetupLoad1;

		// Token: 0x04000201 RID: 513
		public static string[] parameterSetupLoad2;

		// Token: 0x04000202 RID: 514
		public static string[] parameterSetupLoad3;

		// Token: 0x04000203 RID: 515
		public static string[] parameterSetupLoad4;

		// Token: 0x04000204 RID: 516
		public static string[] parameterSetupLoad5;

		// Token: 0x04000205 RID: 517
		public static string[] parameterSetupLoad6;

		// Token: 0x04000206 RID: 518
		public static string[] parameterSetupLoad7;

		// Token: 0x04000207 RID: 519
		public static string[] measureValueSetup;

		// Token: 0x04000208 RID: 520
		public static double[] measureValueUpdate = new double[23];

		// Token: 0x04000209 RID: 521
		public static double[] parametervalueupdate = new double[7];

		// Token: 0x0400020A RID: 522
		public static double[] parametervalueupdate1 = new double[7];

		// Token: 0x0400020B RID: 523
		public static double[] parametervalueupdate2 = new double[7];

		// Token: 0x0400020C RID: 524
		public static double[] parametervalueupdate3 = new double[7];

		// Token: 0x0400020D RID: 525
		public static double[] parametervalueupdate4 = new double[7];

		// Token: 0x0400020E RID: 526
		public static double[] parametervalueupdate5 = new double[7];

		// Token: 0x0400020F RID: 527
		public static double[] parametervalueupdate6 = new double[7];

		// Token: 0x04000210 RID: 528
		public static double[] acInputparam = new double[10];

		// Token: 0x04000211 RID: 529
		public static double[] resInputparam = new double[10];

		// Token: 0x04000212 RID: 530
		public static double[] curInputparam = new double[10];

		// Token: 0x04000213 RID: 531
		public static double[] dcvoltInputparam = new double[10];

		// Token: 0x04000214 RID: 532
		public static bool[] enableMeasurestep = new bool[15];

		// Token: 0x04000215 RID: 533
		public static string[] dataPrint = new string[128];

		// Token: 0x04000216 RID: 534
		public static string[] dataReport = new string[128];

		// Token: 0x04000217 RID: 535
		public static string strPrint;

		// Token: 0x04000218 RID: 536
		public static double resValue100;

		// Token: 0x04000219 RID: 537
		public static double curValue100;

		// Token: 0x0400021A RID: 538
		public static double voltValue100;
	}
}
