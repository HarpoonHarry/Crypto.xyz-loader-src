using System;
using System.Runtime.CompilerServices;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000008 RID: 8
	internal class ApplicationSettings
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003B RID: 59 RVA: 0x001842CD File Offset: 0x0017F0CD
		// (set) Token: 0x0600003C RID: 60 RVA: 0x001842D4 File Offset: 0x0017F0D4
		public static bool Status
		{
			[CompilerGenerated]
			get
			{
				return ApplicationSettings.<Status>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				ApplicationSettings.<Status>k__BackingField = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003D RID: 61 RVA: 0x001842DF File Offset: 0x0017F0DF
		// (set) Token: 0x0600003E RID: 62 RVA: 0x001842E6 File Offset: 0x0017F0E6
		public static bool DeveloperMode
		{
			[CompilerGenerated]
			get
			{
				return ApplicationSettings.<DeveloperMode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				ApplicationSettings.<DeveloperMode>k__BackingField = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003F RID: 63 RVA: 0x001842F1 File Offset: 0x0017F0F1
		// (set) Token: 0x06000040 RID: 64 RVA: 0x001842F8 File Offset: 0x0017F0F8
		public static string Hash
		{
			[CompilerGenerated]
			get
			{
				return ApplicationSettings.<Hash>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				ApplicationSettings.<Hash>k__BackingField = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00184303 File Offset: 0x0017F103
		// (set) Token: 0x06000042 RID: 66 RVA: 0x0018430A File Offset: 0x0017F10A
		public static string Version { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00184315 File Offset: 0x0017F115
		// (set) Token: 0x06000044 RID: 68 RVA: 0x0018431C File Offset: 0x0017F11C
		public static string Update_Link { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00184327 File Offset: 0x0017F127
		// (set) Token: 0x06000046 RID: 70 RVA: 0x0018432E File Offset: 0x0017F12E
		public static bool Freemode { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00184339 File Offset: 0x0017F139
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00184340 File Offset: 0x0017F140
		public static bool Login
		{
			[CompilerGenerated]
			get
			{
				return ApplicationSettings.<Login>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				ApplicationSettings.<Login>k__BackingField = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0018434B File Offset: 0x0017F14B
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00184352 File Offset: 0x0017F152
		public static string Name
		{
			[CompilerGenerated]
			get
			{
				return ApplicationSettings.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				ApplicationSettings.<Name>k__BackingField = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0018435D File Offset: 0x0017F15D
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00184364 File Offset: 0x0017F164
		public static bool Register
		{
			[CompilerGenerated]
			get
			{
				return ApplicationSettings.<Register>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				ApplicationSettings.<Register>k__BackingField = value;
			}
		}

		// Token: 0x04000024 RID: 36
		private static bool <Status>k__BackingField;

		// Token: 0x04000025 RID: 37
		private static bool <DeveloperMode>k__BackingField;

		// Token: 0x04000026 RID: 38
		private static string <Hash>k__BackingField;

		// Token: 0x0400002A RID: 42
		private static bool <Login>k__BackingField;

		// Token: 0x0400002B RID: 43
		private static string <Name>k__BackingField;

		// Token: 0x0400002C RID: 44
		private static bool <Register>k__BackingField;
	}
}
