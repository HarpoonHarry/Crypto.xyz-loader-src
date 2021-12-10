using System;

// Token: 0x02000022 RID: 34
internal struct Struct2
{
	// Token: 0x0600014D RID: 333 RVA: 0x00184A41 File Offset: 0x0017F841
	public void method_0()
	{
		this.uint_1 = 1024U;
	}

	// Token: 0x0600014E RID: 334 RVA: 0x0018FC00 File Offset: 0x0018AA00
	public uint method_1(Class35 class35_0)
	{
		uint num = (class35_0.uint_2 >> 11) * this.uint_1;
		if (class35_0.uint_3 < num)
		{
			class35_0.uint_2 = num;
			this.uint_1 += 2048U - this.uint_1 >> 5;
			if (class35_0.uint_2 < 16777216U)
			{
				class35_0.uint_3 = (class35_0.uint_3 << 8 | (uint)((byte)class35_0.stream_0.ReadByte()));
				class35_0.uint_2 <<= 8;
			}
			return 0U;
		}
		class35_0.uint_2 -= num;
		class35_0.uint_3 -= num;
		this.uint_1 -= this.uint_1 >> 5;
		if (class35_0.uint_2 < 16777216U)
		{
			class35_0.uint_3 = (class35_0.uint_3 << 8 | (uint)((byte)class35_0.stream_0.ReadByte()));
			class35_0.uint_2 <<= 8;
		}
		return 1U;
	}

	// Token: 0x040000C2 RID: 194
	private const int int_0 = 11;

	// Token: 0x040000C3 RID: 195
	private const uint uint_0 = 2048U;

	// Token: 0x040000C4 RID: 196
	private const int int_1 = 5;

	// Token: 0x040000C5 RID: 197
	private uint uint_1;
}
