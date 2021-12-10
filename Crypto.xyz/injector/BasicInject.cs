using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace injector
{
	// Token: 0x02000004 RID: 4
	public class BasicInject
	{
		// Token: 0x0600000D RID: 13
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

		// Token: 0x0600000E RID: 14
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x0600000F RID: 15
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		// Token: 0x06000010 RID: 16
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x06000011 RID: 17
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

		// Token: 0x06000012 RID: 18
		[DllImport("kernel32.dll")]
		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

		// Token: 0x06000013 RID: 19 RVA: 0x00184C04 File Offset: 0x0017FA04
		public static int Inject(string dllpath, string procname)
		{
			Process process = Process.GetProcessesByName(procname)[0];
			IntPtr hProcess = BasicInject.OpenProcess(1082, false, process.Id);
			IntPtr procAddress = BasicInject.GetProcAddress(BasicInject.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
			IntPtr intPtr = BasicInject.VirtualAllocEx(hProcess, IntPtr.Zero, (uint)((dllpath.Length + 1) * Marshal.SizeOf(typeof(char))), 12288U, 4U);
			UIntPtr uintPtr;
			BasicInject.WriteProcessMemory(hProcess, intPtr, Encoding.Default.GetBytes(dllpath), (uint)((dllpath.Length + 1) * Marshal.SizeOf(typeof(char))), out uintPtr);
			BasicInject.CreateRemoteThread(hProcess, IntPtr.Zero, 0U, procAddress, intPtr, 0U, IntPtr.Zero);
			return 0;
		}

		// Token: 0x04000004 RID: 4
		private const int PROCESS_CREATE_THREAD = 2;

		// Token: 0x04000005 RID: 5
		private const int PROCESS_QUERY_INFORMATION = 1024;

		// Token: 0x04000006 RID: 6
		private const int PROCESS_VM_OPERATION = 8;

		// Token: 0x04000007 RID: 7
		private const int PROCESS_VM_WRITE = 32;

		// Token: 0x04000008 RID: 8
		private const int PROCESS_VM_READ = 16;

		// Token: 0x04000009 RID: 9
		private const uint MEM_COMMIT = 4096U;

		// Token: 0x0400000A RID: 10
		private const uint MEM_RESERVE = 8192U;

		// Token: 0x0400000B RID: 11
		private const uint PAGE_READWRITE = 4U;
	}
}
