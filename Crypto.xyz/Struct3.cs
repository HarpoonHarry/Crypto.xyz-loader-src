using System;

// Token: 0x02000023 RID: 35
internal struct Struct3
{
	// Token: 0x0600014F RID: 335 RVA: 0x00184A51 File Offset: 0x0017F851
	public Struct3(int int_1)
	{
		this.int_0 = int_1;
		this.struct2_0 = new Struct2[1 << int_1];
	}

	// Token: 0x06000150 RID: 336 RVA: 0x0018FD60 File Offset: 0x0018AB60
	public void method_0()
	{
		while (1L < 1L << (this.int_0 & 31))
		{
			this.struct2_0[1].method_0();
		}
	}

	// Token: 0x06000151 RID: 337 RVA: 0x0018FD98 File Offset: 0x0018AB98
	public uint method_1(Class35 class35_0)
	{
		for (int i = this.int_0; i > 0; i--)
		{
			uint num = 2U + this.struct2_0[1].method_1(class35_0);
		}
		return 1U - (1U << this.int_0);
	}

	// Token: 0x06000152 RID: 338 RVA: 0x0018FDD8 File Offset: 0x0018ABD8
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

	// Token: 0x06000153 RID: 339 RVA: 0x0018FE18 File Offset: 0x0018AC18
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

	// Token: 0x040000C6 RID: 198
	private readonly Struct2[] struct2_0;

	// Token: 0x040000C7 RID: 199
	private readonly int int_0;
}
