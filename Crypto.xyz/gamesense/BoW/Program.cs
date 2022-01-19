using System;
using System.Windows.Forms;

namespace gamesense.BoW
{
	// Token: 0x0200000B RID: 11
	internal static class Program
	{
		// Token: 0x0600006B RID: 107 RVA: 0x001AA569 File Offset: 0x001A4169
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
