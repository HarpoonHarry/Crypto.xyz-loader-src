using System;
using System.Collections.Generic;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000005 RID: 5
	internal class App
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00184CF8 File Offset: 0x0017FAF8
		public static string GrabVariable(string name)
		{
			string result;
			try
			{
				if (User.ID == null && User.HWID == null && User.IP == null && Constants.Breached)
				{
					Constants.Breached = true;
					result = "User is not logged in, possible breach detected!";
				}
				else
				{
					result = App.Variables[name];
				}
			}
			catch
			{
				result = "N/A";
			}
			return result;
		}

		// Token: 0x0400000C RID: 12
		public static string Error = null;

		// Token: 0x0400000D RID: 13
		public static Dictionary<string, string> Variables = new Dictionary<string, string>();
	}
}
