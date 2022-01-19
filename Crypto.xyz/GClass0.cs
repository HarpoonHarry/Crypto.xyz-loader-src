using System;
using System.Runtime.InteropServices;

// Token: 0x02000013 RID: 19
public class GClass0
{
	// Token: 0x060000A9 RID: 169 RVA: 0x001B0304 File Offset: 0x001A9F04
	public GClass0()
	{
		if (GClass0.uint_0 == null)
		{
			GClass0.uint_0 = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ 3988292384U);
					}
					else
					{
						num >>= 1;
					}
				}
				GClass0.uint_0[i] = num;
			}
		}
	}

	// Token: 0x060000AA RID: 170 RVA: 0x001B03CC File Offset: 0x001A9FCC
	public uint method_0(IntPtr intptr_0, uint uint_1)
	{
		uint num = 0U;
		int num2 = 0;
		while ((long)num2 < (long)((ulong)uint_1))
		{
			num = (GClass0.uint_0[(int)(((uint)Marshal.ReadByte(new IntPtr(intptr_0.ToInt64() + (long)num2)) ^ num) & 255U)] ^ num >> 8);
			num2++;
		}
		return ~num;
	}

	// Token: 0x04000083 RID: 131
	private static uint[] uint_0;
}
