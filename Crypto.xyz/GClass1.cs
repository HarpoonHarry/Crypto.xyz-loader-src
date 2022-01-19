using System;

// Token: 0x02000014 RID: 20
public class GClass1
{
	// Token: 0x060000AB RID: 171 RVA: 0x001AA850 File Offset: 0x001A4450
	public GClass1()
	{
		this.uint_0 = 1290877069U;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x001B0418 File Offset: 0x001AA018
	public uint method_0(uint uint_1)
	{
		uint num = uint_1 ^ this.uint_0;
		this.uint_0 = (GClass2.smethod_0(this.uint_0, 7) ^ num);
		return num;
	}

	// Token: 0x04000084 RID: 132
	private uint uint_0;
}
