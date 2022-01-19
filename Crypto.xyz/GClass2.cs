using System;

// Token: 0x02000015 RID: 21
public class GClass2
{
	// Token: 0x060000AD RID: 173 RVA: 0x001B045C File Offset: 0x001AA05C
	public static uint smethod_0(uint uint_0, int int_1)
	{
		uint num = uint_0 << int_1;
		uint num2 = uint_0 >> 32 - int_1;
		return num | num2;
	}

	// Token: 0x04000085 RID: 133
	public const int int_0 = 32;
}
