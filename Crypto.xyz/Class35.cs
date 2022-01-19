using System;
using System.IO;

// Token: 0x0200001C RID: 28
internal class Class35
{
	// Token: 0x06000138 RID: 312 RVA: 0x001B55EC File Offset: 0x001AF1EC
	public void method_0(Stream stream_1)
	{
		this.stream_0 = stream_1;
		this.uint_3 = 0U;
		this.uint_2 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			this.uint_3 = (this.uint_3 << 8 | (uint)((byte)this.stream_0.ReadByte()));
		}
	}

	// Token: 0x06000139 RID: 313 RVA: 0x001AA8E2 File Offset: 0x001A44E2
	public void method_1()
	{
		this.stream_0 = null;
	}

	// Token: 0x0600013A RID: 314 RVA: 0x001B5670 File Offset: 0x001AF270
	public uint method_2(int int_0)
	{
		uint num = this.uint_2;
		uint num2 = this.uint_3;
		uint num3 = 0U;
		for (int i = int_0; i > 0; i--)
		{
			num >>= 1;
			uint num4 = num2 - num >> 31;
			num2 -= (num & num4 - 1U);
			num3 = (num3 << 1 | 1U - num4);
			if (num < 16777216U)
			{
				num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				num <<= 8;
			}
		}
		this.uint_2 = num;
		this.uint_3 = num2;
		return num3;
	}

	// Token: 0x040000C0 RID: 192
	private uint uint_0 = 1U;

	// Token: 0x040000C1 RID: 193
	public const uint uint_1 = 16777216U;

	// Token: 0x040000C2 RID: 194
	public uint uint_2;

	// Token: 0x040000C3 RID: 195
	public uint uint_3;

	// Token: 0x040000C4 RID: 196
	public Stream stream_0;
}
