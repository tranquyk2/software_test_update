using System;
using System.IO;
using System.Windows.Forms;

namespace FT_ShungHo_Test
{
	// Token: 0x02000009 RID: 9
	public class ReadCsvFile
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00017208 File Offset: 0x00015408
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
				MessageBox.Show("File: " + File_Path + " not found", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			return num;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00017270 File Offset: 0x00015470
		public static string ReadTextFile(string filePath, int lineNumber)
		{
			string result;
			using (StreamReader streamReader = new StreamReader(filePath))
			{
				for (int i = 1; i <= lineNumber - 1; i++)
				{
					streamReader.ReadLine();
				}
				string text = streamReader.ReadLine();
				streamReader.Close();
				result = text;
			}
			return result;
		}
	}
}
