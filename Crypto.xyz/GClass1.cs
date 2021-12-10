using System;

// Token: 0x02000019 RID: 25
public class GClass1
{
	// Token: 0x060000BC RID: 188 RVA: 0x0018498A File Offset: 0x0017F78A
	public GClass1()
	{
		this.uint_0 = 1392336978U;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x0018A8A4 File Offset: 0x001856A4
	public uint method_0(uint uint_1)
	{
		uint num = uint_1 ^ this.uint_0;
		this.uint_0 = (GClass2.smethod_0(this.uint_0, 7) ^ num);
		return num;
	}

	// Token: 0x04000081 RID: 129
	private uint uint_0;
}
