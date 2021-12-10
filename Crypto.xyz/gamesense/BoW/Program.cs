using System;
using System.Windows.Forms;
using Auth.GG_Winform_Example;

namespace gamesense.BoW
{
	// Token: 0x02000011 RID: 17
	internal static class Program
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x00184858 File Offset: 0x0017F658
		[STAThread]
		private static void Main()
		{
			OnProgramStart.Initialize("HWID Login System", "645635", "8yVATQYk3pVMkInnIKGSTynwjjLaEAMSEEW", "1.0");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
