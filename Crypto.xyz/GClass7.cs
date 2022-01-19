using System;
using System.IO;

// Token: 0x0200001F RID: 31
public class GClass7
{
	// Token: 0x06000143 RID: 323 RVA: 0x001B59C0 File Offset: 0x001AF5C0
	public void method_0(uint uint_5)
	{
		if (this.uint_1 != uint_5)
		{
			this.byte_0 = new byte[uint_5];
		}
		this.uint_1 = uint_5;
		this.uint_0 = 0U;
		this.uint_2 = 0U;
	}

	// Token: 0x06000144 RID: 324 RVA: 0x001B5A18 File Offset: 0x001AF618
	public void method_1(Stream stream_1, bool bool_0)
	{
		this.method_2();
		this.stream_0 = stream_1;
		if (!bool_0)
		{
			this.uint_2 = 0U;
			this.uint_0 = 0U;
			this.uint_4 = 0U;
		}
	}

	// Token: 0x06000145 RID: 325 RVA: 0x001AA944 File Offset: 0x001A4544
	public void method_2()
	{
		this.method_3();
		this.stream_0 = null;
	}

	// Token: 0x06000146 RID: 326 RVA: 0x001B5A6C File Offset: 0x001AF66C
	public void method_3()
	{
		uint num = this.uint_0 - this.uint_2;
		if (num == 0U)
		{
			return;
		}
		this.stream_0.Write(this.byte_0, (int)this.uint_2, (int)num);
		if (this.uint_0 >= this.uint_1)
		{
			this.uint_0 = 0U;
		}
		this.uint_2 = this.uint_0;
	}

	// Token: 0x06000147 RID: 327 RVA: 0x001B5AF0 File Offset: 0x001AF6F0
	public void method_4(uint uint_5, uint uint_6)
	{
		uint num = this.uint_0 - uint_5 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		while (uint_6 > 0U)
		{
			if (num >= this.uint_1)
			{
				num = 0U;
			}
			byte[] array = this.byte_0;
			uint num2 = this.uint_0;
			this.uint_0 = num2 + 1U;
			array[(int)num2] = this.byte_0[(int)num++];
			if (this.uint_0 >= this.uint_1)
			{
				this.method_3();
			}
			uint_6 -= 1U;
		}
	}

	// Token: 0x06000148 RID: 328 RVA: 0x001B5BD8 File Offset: 0x001AF7D8
	public void method_5(byte byte_1)
	{
		byte[] array = this.byte_0;
		uint num = this.uint_0;
		this.uint_0 = num + 1U;
		array[(int)num] = byte_1;
		if (this.uint_0 >= this.uint_1)
		{
			this.method_3();
		}
	}

	// Token: 0x06000149 RID: 329 RVA: 0x001B5C34 File Offset: 0x001AF834
	public byte method_6(uint uint_5)
	{
		uint num = this.uint_0 - uint_5 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		return this.byte_0[(int)num];
	}

	// Token: 0x040000CB RID: 203
	private byte[] byte_0;

	// Token: 0x040000CC RID: 204
	private uint uint_0;

	// Token: 0x040000CD RID: 205
	private uint uint_1;

	// Token: 0x040000CE RID: 206
	private uint uint_2;

	// Token: 0x040000CF RID: 207
	private Stream stream_0;

	// Token: 0x040000D0 RID: 208
	private uint uint_3 = 1U;

	// Token: 0x040000D1 RID: 209
	public uint uint_4;
}
