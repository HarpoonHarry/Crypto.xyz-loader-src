using System;

// Token: 0x0200001D RID: 29
internal struct Struct2
{
	// Token: 0x0600013C RID: 316 RVA: 0x001AA907 File Offset: 0x001A4507
	public void method_0()
	{
		this.uint_1 = 1024U;
	}

	// Token: 0x0600013D RID: 317 RVA: 0x001B5770 File Offset: 0x001AF370
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

	// Token: 0x040000C5 RID: 197
	private const int int_0 = 11;

	// Token: 0x040000C6 RID: 198
	private const uint uint_0 = 2048U;

	// Token: 0x040000C7 RID: 199
	private const int int_1 = 5;

	// Token: 0x040000C8 RID: 200
	private uint uint_1;
}
