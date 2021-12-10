using System;
using System.IO;

// Token: 0x02000021 RID: 33
internal class Class35
{
	// Token: 0x06000149 RID: 329 RVA: 0x0018FA7C File Offset: 0x0018A87C
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

	// Token: 0x0600014A RID: 330 RVA: 0x00184A1C File Offset: 0x0017F81C
	public void method_1()
	{
		this.stream_0 = null;
	}

	// Token: 0x0600014B RID: 331 RVA: 0x0018FB00 File Offset: 0x0018A900
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

	// Token: 0x040000BD RID: 189
	private uint uint_0 = 1U;

	// Token: 0x040000BE RID: 190
	public const uint uint_1 = 16777216U;

	// Token: 0x040000BF RID: 191
	public uint uint_2;

	// Token: 0x040000C0 RID: 192
	public uint uint_3;

	// Token: 0x040000C1 RID: 193
	public Stream stream_0;
}
