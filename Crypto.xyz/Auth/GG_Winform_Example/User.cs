using System;
using System.Runtime.CompilerServices;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000007 RID: 7
	internal class User
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00184207 File Offset: 0x0017F007
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0018420E File Offset: 0x0017F00E
		public static string ID { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00184219 File Offset: 0x0017F019
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00184220 File Offset: 0x0017F020
		public static string Username
		{
			[CompilerGenerated]
			get
			{
				return User.<Username>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				User.<Username>k__BackingField = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0018422B File Offset: 0x0017F02B
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00184232 File Offset: 0x0017F032
		public static string Password
		{
			get
			{
				return User.<Password>k__BackingField;
			}
			set
			{
				User.<Password>k__BackingField = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0018423D File Offset: 0x0017F03D
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00184244 File Offset: 0x0017F044
		public static string Email
		{
			get
			{
				return User.<Email>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				User.<Email>k__BackingField = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0018424F File Offset: 0x0017F04F
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00184256 File Offset: 0x0017F056
		public static string HWID
		{
			[CompilerGenerated]
			get
			{
				return User.<HWID>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				User.<HWID>k__BackingField = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00184261 File Offset: 0x0017F061
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00184268 File Offset: 0x0017F068
		public static string IP { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00184273 File Offset: 0x0017F073
		// (set) Token: 0x06000031 RID: 49 RVA: 0x0018427A File Offset: 0x0017F07A
		public static string UserVariable { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00184285 File Offset: 0x0017F085
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0018428C File Offset: 0x0017F08C
		public static string Rank { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00184297 File Offset: 0x0017F097
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0018429E File Offset: 0x0017F09E
		public static string Expiry { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000036 RID: 54 RVA: 0x001842A9 File Offset: 0x0017F0A9
		// (set) Token: 0x06000037 RID: 55 RVA: 0x001842B0 File Offset: 0x0017F0B0
		public static string LastLogin { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000038 RID: 56 RVA: 0x001842BB File Offset: 0x0017F0BB
		// (set) Token: 0x06000039 RID: 57 RVA: 0x001842C2 File Offset: 0x0017F0C2
		public static string RegisterDate
		{
			[CompilerGenerated]
			get
			{
				return User.<RegisterDate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				User.<RegisterDate>k__BackingField = value;
			}
		}

		// Token: 0x0400001A RID: 26
		private static string <Username>k__BackingField;

		// Token: 0x0400001B RID: 27
		private static string <Password>k__BackingField;

		// Token: 0x0400001C RID: 28
		private static string <Email>k__BackingField;

		// Token: 0x0400001D RID: 29
		private static string <HWID>k__BackingField;

		// Token: 0x04000023 RID: 35
		private static string <RegisterDate>k__BackingField;
	}
}
