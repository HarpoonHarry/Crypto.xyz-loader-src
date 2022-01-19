using System;

// Token: 0x0200001E RID: 30
internal struct Struct3
{
	// Token: 0x0600013E RID: 318 RVA: 0x001AA917 File Offset: 0x001A4517
	public Struct3(int int_1)
	{
		this.int_0 = int_1;
		this.struct2_0 = new Struct2[1 << int_1];
	}

	// Token: 0x0600013F RID: 319 RVA: 0x001B58D0 File Offset: 0x001AF4D0
	public void method_0()
	{
		while (1L < 1L << (this.int_0 & 31))
		{
			this.struct2_0[1].method_0();
		}
	}

	// Token: 0x06000140 RID: 320 RVA: 0x001B5908 File Offset: 0x001AF508
	public uint method_1(Class35 class35_0)
	{
		for (int i = this.int_0; i > 0; i--)
		{
			uint num = 2U + this.struct2_0[1].method_1(class35_0);
		}
		return 1U - (1U << this.int_0);
	}

	// Token: 0x06000141 RID: 321 RVA: 0x001B5948 File Offset: 0x001AF548
	public uint method_2(Class35 class35_0)
	{
		uint num = 0U;
		for (int i = 0; i < this.int_0; i++)
		{
			uint num2 = this.struct2_0[1].method_1(class35_0);
			num |= num2 << i;
		}
		return num;
	}

	// Token: 0x06000142 RID: 322 RVA: 0x001B5988 File Offset: 0x001AF588
	public static uint smethod_0(Struct2[] struct2_1, uint uint_0, Class35 class35_0, int int_1)
	{
		uint num = 0U;
		for (int i = 0; i < int_1; i++)
		{
			uint num2 = struct2_1[(int)(uint_0 + 1U)].method_1(class35_0);
			num |= num2 << i;
		}
		return num;
	}

	// Token: 0x040000C9 RID: 201
	private readonly Struct2[] struct2_0;

	// Token: 0x040000CA RID: 202
	private readonly int int_0;
}
