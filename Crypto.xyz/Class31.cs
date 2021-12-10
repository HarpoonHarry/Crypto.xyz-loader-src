using System;
using System.Runtime.InteropServices;

// Token: 0x0200001E RID: 30
internal static class Class31
{
	// Token: 0x06000135 RID: 309
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, int int_5, int int_6, IntPtr intptr_3, int int_7, int int_8, IntPtr intptr_4);

	// Token: 0x06000136 RID: 310
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFileMapping(IntPtr intptr_3, IntPtr intptr_4, Class31.Enum0 enum0_0, int int_5, int int_6, string string_0);

	// Token: 0x06000137 RID: 311
	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr MapViewOfFile(IntPtr intptr_3, Class31.Enum1 enum1_0, int int_5, int int_6, IntPtr intptr_4);

	// Token: 0x06000138 RID: 312
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool UnmapViewOfFile(IntPtr intptr_3);

	// Token: 0x06000139 RID: 313
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_3);

	// Token: 0x0600013A RID: 314
	[DllImport("kernel32", SetLastError = true)]
	public static extern uint GetFileSize(IntPtr intptr_3, IntPtr intptr_4);

	// Token: 0x0600013B RID: 315
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool VirtualProtect(IntPtr intptr_3, UIntPtr uintptr_0, Class31.Enum0 enum0_0, out Class31.Enum0 enum0_1);

	// Token: 0x0600013C RID: 316
	[DllImport("kernel32")]
	public static extern bool IsDebuggerPresent();

	// Token: 0x0600013D RID: 317
	[DllImport("kernel32")]
	public static extern bool CheckRemoteDebuggerPresent();

	// Token: 0x0600013E RID: 318
	[DllImport("ntdll")]
	public static extern int NtQueryInformationProcess(IntPtr intptr_3, int int_5, byte[] byte_0, uint uint_0, out uint uint_1);

	// Token: 0x04000093 RID: 147
	public const int int_0 = -2147483648;

	// Token: 0x04000094 RID: 148
	public const int int_1 = 3;

	// Token: 0x04000095 RID: 149
	public const int int_2 = 128;

	// Token: 0x04000096 RID: 150
	public const int int_3 = 1;

	// Token: 0x04000097 RID: 151
	public const int int_4 = 2;

	// Token: 0x04000098 RID: 152
	public static readonly IntPtr intptr_0 = new IntPtr(-1);

	// Token: 0x04000099 RID: 153
	public static readonly IntPtr intptr_1 = IntPtr.Zero;

	// Token: 0x0400009A RID: 154
	public static readonly IntPtr intptr_2 = new IntPtr(-1);

	// Token: 0x02000045 RID: 69
	public enum Enum0 : uint
	{
		// Token: 0x040000F9 RID: 249
		const_0 = 1U,
		// Token: 0x040000FA RID: 250
		const_1,
		// Token: 0x040000FB RID: 251
		const_2 = 4U,
		// Token: 0x040000FC RID: 252
		const_3 = 8U,
		// Token: 0x040000FD RID: 253
		const_4 = 16U,
		// Token: 0x040000FE RID: 254
		const_5 = 32U,
		// Token: 0x040000FF RID: 255
		const_6 = 64U,
		// Token: 0x04000100 RID: 256
		const_7 = 256U
	}

	// Token: 0x02000046 RID: 70
	public enum Enum1 : uint
	{
		// Token: 0x04000102 RID: 258
		const_0 = 1U,
		// Token: 0x04000103 RID: 259
		const_1,
		// Token: 0x04000104 RID: 260
		const_2 = 4U,
		// Token: 0x04000105 RID: 261
		const_3 = 31U
	}
}
