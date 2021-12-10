using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Crypto.xyz.Properties
{
	// Token: 0x02000003 RID: 3
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x001840A4 File Offset: 0x0017EEA4
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x001840AB File Offset: 0x0017EEAB
		// (set) Token: 0x06000008 RID: 8 RVA: 0x001840C0 File Offset: 0x0017EEC0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Username
		{
			get
			{
				return (string)this["Username"];
			}
			set
			{
				this["Username"] = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x001840D4 File Offset: 0x0017EED4
		// (set) Token: 0x0600000A RID: 10 RVA: 0x001840E9 File Offset: 0x0017EEE9
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Password
		{
			get
			{
				return (string)this["Password"];
			}
			set
			{
				this["Password"] = value;
			}
		}

		// Token: 0x04000003 RID: 3
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
