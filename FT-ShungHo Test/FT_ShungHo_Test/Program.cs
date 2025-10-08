using System;
using System.Windows.Forms;

namespace FT_ShungHo_Test
{
	// Token: 0x02000007 RID: 7
	internal static class Program
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00011E7F File Offset: 0x0001007F
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

		// Token: 0x02000010 RID: 16
		public class delay
		{
			// Token: 0x06000105 RID: 261 RVA: 0x00018518 File Offset: 0x00016718
			public static bool Delay2(int delayTime)
			{
				DateTime now = DateTime.Now;
				int seconds;
				do
				{
					seconds = (DateTime.Now - now).Seconds;
					Application.DoEvents();
				}
				while (seconds < delayTime);
				return true;
			}

			// Token: 0x06000106 RID: 262 RVA: 0x00018558 File Offset: 0x00016758
			public static void Delay1(double delayTime)
			{
				DateTime now = DateTime.Now;
				double totalMilliseconds;
				do
				{
					totalMilliseconds = (DateTime.Now - now).TotalMilliseconds;
					Application.DoEvents();
				}
				while (totalMilliseconds < delayTime);
			}
		}
	}
}
