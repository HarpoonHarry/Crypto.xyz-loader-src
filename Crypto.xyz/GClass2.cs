using System;

// Token: 0x0200001A RID: 26
public class GClass2
{
	// Token: 0x060000BE RID: 190 RVA: 0x0018A8E8 File Offset: 0x001856E8
	public static uint smethod_0(uint uint_0, int int_1)
	{
		uint num = uint_0 << int_1;
		uint num2 = uint_0 >> 32 - int_1;
		return num | num2;
	}

	// Token: 0x04000082 RID: 130
	public const int int_0 = 32;
}
